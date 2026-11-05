# Sordland/Turn10/DINNER WITH PETR

- **ID konwersacji:** `214`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/214_DINNER_WITH_PETR.md`
- **Liczba węzłów dialogowych:** 313
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

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
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Turn10_PartyCongress_Won`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Exile_PetrWithYou`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`
- `BaseGameIsolated.Turn10_FinalSupper_GameOff`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[46]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **""I don't know if I can make it to the end of my term.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" |
| `[14]` | **""I don't think I can win this election.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" |
| `[16]` | **""I can't wait till I can leave this all behind.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" |
| `[18]` | **"Flee the country."** | `[76]` **Narrator**: "After showing Petr to the door, ..." | `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)` | *Brak zmian stanu* | `[49]` **Narrator**: "I could go to Kyrute. It was the..." |
| `[19]` | **"Leave after covering up your tracks."** | `[49]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[17]` **Narrator**: "It was time for a fresh start. I..." |
| `[23]` | **""I don't think I want another term.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" |
| `[25]` | **""I can't wait for my next term.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`<br>`Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[45]` **Narrator**: "Petr smiled." |
| `[28]` | **""Thanks. If you don't mind, Petr, I'd rather be alone tonight after all. I want to..."** | `[84]` **Petr Vectern**: ""And I'll be right there with you.""<br>`[180]` **Petr Vectern**: ""We'll get through this. You can..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Petr Vectern**: ""Yeah, sure."" |
| `[35]` | **""That Anton Rayne was a liar.""** | `[257]` **Petr Vectern**: ""I would have followed him to th..."<br>`[258]` **Petr Vectern**: ""I would have followed him to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Player**: ""I've got to face facts, Petr. I..."<br>`[210]` **Player**: ""But I've made it this far. I'll..."<br>*(oraz 1 innych odgałęzień)* |
| `[40]` | **"Don't look at them and go to your door."** | `[26]` **Narrator**: "I didn't know if it was my imagi..."<br>`[29]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[44]` **Narrator**: "Once we were inside, I locked th..." |
| `[41]` | **"Give the guards a suspicious look."** | `[26]` **Narrator**: "I didn't know if it was my imagi..."<br>`[29]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[44]` **Narrator**: "Once we were inside, I locked th..." |
| `[42]` | **"Leave now."** | `[49]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[33]` **Narrator**: "It was time for a fresh start. I..." |
| `[54]` | **""I'd make dinner, but the chef has the night off and I don't have any food in the ..."** | `[43]` **Narrator**: "We hurried past them and went in..."<br>`[44]` **Narrator**: "Once we were inside, I locked th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Petr Vectern**: ""Frozen TV dinners, my man! They..." |
| `[57]` | **""Sorry about the mess in here.""** | `[43]` **Narrator**: "We hurried past them and went in..."<br>`[44]` **Narrator**: "Once we were inside, I locked th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Petr Vectern**: ""Ha. You should see my place."" |
| `[58]` | **""See? You've still got a few fans in Sordland.""** | `[214]` **Narrator**: "Before kickoff, the team captain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Player**: ""In Anrica, anyway.""<br>`[204]` **Player**: ""Yeah, I know."" |
| `[59]` | **""I can't even watch a goddamn football game anymore!""** | `[150]` **Petr Vectern**: ""Whoa there, cowboy!""<br>`[151]` **Petr Vectern**: ""Bummer."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Petr Vectern**: ""Anton? Something on your mind?"" |
| `[60]` | **"Decide to continue."** | `[76]` **Narrator**: "After showing Petr to the door, ..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[51]` **Narrator**: "If only for Petr's sake." |
| `[61]` | **"Draft a speech announcing your retirement from politics."** | `[76]` **Narrator**: "After showing Petr to the door, ..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[50]` **Narrator**: "I hoped Petr wouldn't be too mad..." |
| `[62]` | **"Start planning for the end of your presidency."** | `[76]` **Narrator**: "After showing Petr to the door, ..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[52]` **Narrator**: "I only had a few months left as ..." |
| `[63]` | **""I don't think we have a choice.""** | `[69]` **Petr Vectern**: ""Whoa. Whoa! We're really doing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "A slow smile spread across Petr'..." |
| `[64]` | **""Yes.""** | `[69]` **Petr Vectern**: ""Whoa. Whoa! We're really doing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "A slow smile spread across Petr'..." |
| `[65]` | **""Petr, want a beer?""** | `[43]` **Narrator**: "We hurried past them and went in..."<br>`[44]` **Narrator**: "Once we were inside, I locked th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Petr Vectern**: ""Don't you remember? I'm sober a..."<br>`[219]` **Narrator**: "Petr raised an eyebrow." |
| `[67]` | **""I lost Serge.""** | `[39]` **Petr Vectern**: ""Come on, Anton. Really?""<br>`[51]` **Narrator**: "If only for Petr's sake."<br>*(oraz 9 innych węzłów)* | `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true` | *Brak zmian stanu* | `[181]` **Player**: ""And I think things are about to..."<br>`[201]` **Player**: ""And I think the military is sti..."<br>*(oraz 4 innych odgałęzień)* |
| `[68]` | **""I lost my wife, Petr.""** | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Player**: ""And I think things are about to..."<br>`[201]` **Player**: ""And I think the military is sti..."<br>*(oraz 4 innych odgałęzień)* |
| `[74]` | **""Why can't they just stick to kicking the ball around? Why bring politics into it?""** | `[150]` **Petr Vectern**: ""Whoa there, cowboy!""<br>`[151]` **Petr Vectern**: ""Bummer."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Petr Vectern**: ""Anton? Something on your mind?"" |
| `[77]` | **""And you're coming with me.""** | `[142]` **Player**: ""Yes. That's it. I will leave fo..."<br>`[141]` **Player**: ""Yes. That's it. I'm leaving for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Petr Vectern**: ""Whoa. Whoa! We're really doing ..." |
| `[78]` | **""I won't ask you to come with me. I know you've got your life here.""** | `[142]` **Player**: ""Yes. That's it. I will leave fo..."<br>`[141]` **Player**: ""Yes. That's it. I'm leaving for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Petr Vectern**: ""Excuse me, but what life? Of co..." |
| `[79]` | **""Sorry. I suddenly lost my interest in football.""** | `[150]` **Petr Vectern**: ""Whoa there, cowboy!""<br>`[151]` **Petr Vectern**: ""Bummer."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Petr Vectern**: ""Anton? Something on your mind?"" |
| `[91]` | **""I can get along just fine without her.""** | `[225]` **Petr Vectern**: ""I'm sorry you didn't learn from..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Petr Vectern**: ""Very convincing."" |
| `[92]` | **""Too good for me.""** | `[225]` **Petr Vectern**: ""I'm sorry you didn't learn from..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Petr Vectern**: ""Just like Evelyn."" |
| `[94]` | **""I'm going to get my wife and kids back.""** | `[66]` **Petr Vectern**: ""Now that's the Anton Rayne I kn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Petr Vectern**: ""Damn right you will."" |
| `[104]` | **""I'm going to crush *all* my enemies.""** | `[66]` **Petr Vectern**: ""Now that's the Anton Rayne I kn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Petr Vectern**: ""Damn right you will."" |
| `[105]` | **"Throw a heavy paperweight at the TV."** | `[99]` **Narrator**: "The captain stood up and explain..."<br>`[131]` **Narrator**: "Before kickoff, the team captain..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] =...` | `[150]` **Petr Vectern**: ""Whoa there, cowboy!"" |
| `[106]` | **""It's true. I was strong. And I still am.""** | `[257]` **Petr Vectern**: ""I would have followed him to th..."<br>`[258]` **Petr Vectern**: ""I would have followed him to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Player**: ""But sometimes being strong mean..."<br>`[212]` **Player**: ""Thanks for believing in me, Pet..."<br>*(oraz 1 innych odgałęzień)* |
| `[115]` | **""That Anton Rayne was a naive idiot.""** | `[257]` **Petr Vectern**: ""I would have followed him to th..."<br>`[258]` **Petr Vectern**: ""I would have followed him to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Player**: ""I've got to face facts, Petr. I..."<br>`[210]` **Player**: ""But I've made it this far. I'll..."<br>*(oraz 1 innych odgałęzień)* |
| `[119]` | **""Thanks, that means a lot. Let's finish the game.""** | `[84]` **Petr Vectern**: ""And I'll be right there with you.""<br>`[180]` **Petr Vectern**: ""We'll get through this. You can..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false` | *Brak zmian stanu* | `[103]` **Petr Vectern**: ""Nothing would make me happier."" |
| `[120]` | **""Thanks, that means a lot. Sorry I broke the TV, but you can still stay for a drin..."** | `[84]` **Petr Vectern**: ""And I'll be right there with you.""<br>`[180]` **Petr Vectern**: ""We'll get through this. You can..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true` | *Brak zmian stanu* | `[102]` **Petr Vectern**: ""I thought you'd never ask."" |
| `[121]` | **"Turn off the TV."** | `[99]` **Narrator**: "The captain stood up and explain..."<br>`[131]` **Narrator**: "Before kickoff, the team captain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Petr Vectern**: ""Bummer."" |
| `[125]` | **""You still think I'm great? After everything that's come out about me?""** | `[107]` **Petr Vectern**: ""Don't you worry. You'll find an..." | `Variable["BaseGame.LeakedScandals_Severity"] > 3` | *Brak zmian stanu* | `[233]` **Petr Vectern**: ""Like I haven't done worse?"" |
| `[126]` | **""You still think I'm great? After losing the nomination to Lileas?""** | `[107]` **Petr Vectern**: ""Don't you worry. You'll find an..." | `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true` | *Brak zmian stanu* | `[232]` **Petr Vectern**: ""Don't beat yourself up about it..." |
| `[135]` | **""Thanks. Let's finish the game.""** | `[281]` **Petr Vectern**: ""I understand, though. I hope be..." | `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false` | *Brak zmian stanu* | `[117]` **Petr Vectern**: ""Nothing would make me happier."" |
| `[136]` | **""Who says I don't have fun now? Sorry I broke the TV, but you can still stay for a..."** | `[281]` **Petr Vectern**: ""I understand, though. I hope be..." | `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true` | *Brak zmian stanu* | `[116]` **Petr Vectern**: ""I thought you'd never ask."" |
| `[137]` | **""Thanks for that. If you don't mind, I'd rather be alone tonight after all. I want..."** | `[281]` **Petr Vectern**: ""I understand, though. I hope be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Petr Vectern**: ""Yeah, sure."" |
| `[141]` | **""Yes. That's it. I'm leaving for Kyrute tomorrow.""** | `[153]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...`<br>`Variable["BaseGame.Exile_LeaveNow"] = true;` | `[77]` **Player**: ""And you're coming with me.""<br>`[78]` **Player**: ""I won't ask you to come with me..." |
| `[142]` | **""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my trac..."** | `[153]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[77]` **Player**: ""And you're coming with me.""<br>`[78]` **Player**: ""I won't ask you to come with me..." |
| `[143]` | **""Yes, I will. But tonight's not the time to start looking.""** | `[107]` **Petr Vectern**: ""Don't you worry. You'll find an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "Petr ducked into the kitchen and..."<br>`[246]` **Narrator**: "Petr ducked into the kitchen and..." |
| `[152]` | **""That's because I own them.""** | `[56]` **Petr Vectern**: ""See? The football team still th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[160]` | **""I'm going to get back at those bastards that tried to kill me.""** | `[66]` **Petr Vectern**: ""Now that's the Anton Rayne I kn..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[55]` **Petr Vectern**: ""Damn right you will."" |
| `[166]` | **""I'm going to do everything right this time.""** | `[66]` **Petr Vectern**: ""Now that's the Anton Rayne I kn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Petr Vectern**: ""Damn right you will."" |
| `[172]` | **""But you're right. I should try to think positively.""** | `[67]` **Player**: ""I lost Serge.""<br>`[68]` **Player**: ""I lost my wife, Petr.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`<br>`(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[3]` **Narrator**: "Petr grinned." |
| `[173]` | **""Who or what else am I going to have to sacrifice before this is over?""** | `[67]` **Player**: ""I lost Serge.""<br>`[68]` **Player**: ""I lost my wife, Petr.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`<br>`(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[38]` **Petr Vectern**: ""Now you listen here."" |
| `[174]` | **""I'm leaving Sordland.""** | `[198]` **Petr Vectern**: ""You mean..."" | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[168]` **Narrator**: "Petr's eyes widened." |
| `[175]` | **""I'm not staying in politics after my presidency ends.""** | `[198]` **Petr Vectern**: ""You mean..."" | `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[167]` **Narrator**: "Petr frowned." |
| `[176]` | **""I'm retiring from politics. My mind is made up.""** | `[198]` **Petr Vectern**: ""You mean..."" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[167]` **Narrator**: "Petr frowned." |
| `[181]` | **""And I think things are about to get a whole lot worse.""** | `[67]` **Player**: ""I lost Serge.""<br>`[68]` **Player**: ""I lost my wife, Petr.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[38]` **Petr Vectern**: ""Now you listen here."" |
| `[182]` | **""Not to mention that the Court's about to have me impeached.""** | `[67]` **Player**: ""I lost Serge.""<br>`[68]` **Player**: ""I lost my wife, Petr.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`<br>`(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[38]` **Petr Vectern**: ""Now you listen here."" |
| `[200]` | **""And I'm about to get crucified for giving half our country to Rumburg.""** | `[67]` **Player**: ""I lost Serge.""<br>`[68]` **Player**: ""I lost my wife, Petr.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[38]` **Petr Vectern**: ""Now you listen here."" |
| `[201]` | **""And I think the military is still plotting against me.""** | `[67]` **Player**: ""I lost Serge.""<br>`[68]` **Player**: ""I lost my wife, Petr.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[38]` **Petr Vectern**: ""Now you listen here."" |
| `[202]` | **""Yeah, I know.""** | `[56]` **Petr Vectern**: ""See? The football team still th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[203]` | **""In Anrica, anyway.""** | `[58]` **Petr Vectern**: ""See? You've still got a few fan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[204]` | **""Yeah, I know.""** | `[58]` **Petr Vectern**: ""See? You've still got a few fan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[208]` | **""But you're right. I've made it this far. I've got to keep going.""** | `[35]` **Player**: ""That Anton Rayne was a liar.""<br>`[115]` **Player**: ""That Anton Rayne was a naive id..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[199]` **Narrator**: "Petr looked at me, his eyes glow..." |
| `[209]` | **""I've got to face facts, Petr. It's over.""** | `[35]` **Player**: ""That Anton Rayne was a liar.""<br>`[115]` **Player**: ""That Anton Rayne was a naive id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Petr Vectern**: ""You mean..."" |
| `[210]` | **""But I've made it this far. I'll stick out the rest of my term for you.""** | `[35]` **Player**: ""That Anton Rayne was a liar.""<br>`[115]` **Player**: ""That Anton Rayne was a naive id..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[199]` **Narrator**: "Petr looked at me, his eyes glow..." |
| `[211]` | **""But sometimes being strong means knowing when to throw in the towel.""** | `[106]` **Player**: ""It's true. I was strong. And I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Petr Vectern**: ""You mean..."" |
| `[212]` | **""Thanks for believing in me, Petr. I'll stick out the rest of my term for you.""** | `[106]` **Player**: ""It's true. I was strong. And I ..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[199]` **Narrator**: "Petr looked at me, his eyes glow..." |
| `[213]` | **""Thanks for believing in me, Petr. I'll keep going for you.""** | `[106]` **Player**: ""It's true. I was strong. And I ..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[199]` **Narrator**: "Petr looked at me, his eyes glow..." |
| `[226]` | **""What woman would want us now?""** | `[83]` **Petr Vectern**: ""Look at us. A couple of swingin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Petr Vectern**: ""Oh, you'd be surprised."" |
| `[227]` | **""Sure. Mothers, lock up your daughters.""** | `[83]` **Petr Vectern**: ""Look at us. A couple of swingin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Petr Vectern**: ""Very convincing."" |
| `[228]` | **""I miss her, Petr.""** | `[83]` **Petr Vectern**: ""Look at us. A couple of swingin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Petr Vectern**: ""I miss Evelyn, too."" |
| `[237]` | **""You still think I'm great? After getting my driver killed?""** | `[107]` **Petr Vectern**: ""Don't you worry. You'll find an..." | `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`<br>`(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false` | *Brak zmian stanu* | `[239]` **Petr Vectern**: ""I'm sorry about Serge, But ther..." |
| `[238]` | **""I wouldn't count on that.""** | `[107]` **Petr Vectern**: ""Don't you worry. You'll find an..." | `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`<br>`(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false` | *Brak zmian stanu* | `[247]` **Narrator**: "Petr ducked into the kitchen and..."<br>`[246]` **Narrator**: "Petr ducked into the kitchen and..." |
| `[255]` | **""I can't wait for our next term.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`<br>`Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[45]` **Narrator**: "Petr smiled." |
| `[256]` | **""I might never see my kids again, Petr.""** | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Player**: ""And I think things are about to..."<br>`[201]` **Player**: ""And I think the military is sti..."<br>*(oraz 4 innych odgałęzień)* |
| `[261]` | **""We're fleeing the country, not going on holiday.""** | `[260]` **Petr Vectern**: ""Anton, this could be exactly wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Petr Vectern**: ""Spoilsport."" |
| `[262]` | **""I don't know. When you've messed up as badly as we have, there are no fresh starts.""** | `[260]` **Petr Vectern**: ""Anton, this could be exactly wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Petr Vectern**: ""Spoilsport."" |
| `[263]` | **""Exactly. Some mountain air, some vegetable farming, no godforskaken budget meetin..."** | `[260]` **Petr Vectern**: ""Anton, this could be exactly wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Petr Vectern**: ""Bet you'll miss Lucian, though."" |
| `[266]` | **""Very funny.""** | `[265]` **Petr Vectern**: ""Bet you'll miss Lucian, though."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Player**: ""Stay for a drink. Let's plan th..."<br>`[269]` **Player**: ""Go home and start making your a..." |
| `[267]` | **""I kind of will.""** | `[265]` **Petr Vectern**: ""Bet you'll miss Lucian, though."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Player**: ""Stay for a drink. Let's plan th..."<br>`[269]` **Player**: ""Go home and start making your a..." |
| `[268]` | **""Stay for a drink. Let's plan this out.""** | `[264]` **Petr Vectern**: ""Spoilsport.""<br>`[266]` **Player**: ""Very funny.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Petr Vectern**: ""With pleasure, Mr. President."" |
| `[269]` | **""Go home and start making your arrangements. I'll call you in the morning.""** | `[264]` **Petr Vectern**: ""Spoilsport.""<br>`[266]` **Player**: ""Very funny.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Petr Vectern**: ""Right away, Mr. President."" |
| `[295]` | **"Go to bed."** | `[76]` **Narrator**: "After showing Petr to the door, ..." | `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false` | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[299]` | **""I don't want to stay in politics.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[39]` **Petr Vectern**: ""Come on, Anton. Really?"" |
| `[300]` | **""I can't wait for a fresh start in politics once my term ends.""** | `[27]` **Petr Vectern**: ""Talk to me, Anton. I know you'v..."<br>`[36]` **Petr Vectern**: ""Anton? Something on your mind?"" | `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[45]` **Narrator**: "Petr smiled." |
| `[307]` | **""I'm not running for re-election. I'm giving up politics.""** | `[198]` **Petr Vectern**: ""You mean..."" | `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[167]` **Narrator**: "Petr frowned." |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Petr grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Petr Vectern: ""Exactly.""*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""Oh, you'd be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""Don't you worry. You'll find another woman deserving of ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I walked him out, then got busy packing. My head was buzzing with excitement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Maybe Petr was right. Maybe this could be a fresh start."*)

### Węzeł `[9]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Petr Vectern: ""The Anton Rayne I met in university would never have sat..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""I don't know if I can make it to the end of my term.""*)
  - -> `[16]` (*Player: ""I can't wait till I can leave this all behind.""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Tur..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I don't know if I can make it to the end of my term.""]** — Mówca: **Player**
> ""I don't know if I can make it to the end of the term.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Come on, Anton. Really?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""I don't think I can win this election.""]** — Mówca: **Player**
> ""I don't think I can win this election.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Come on, Anton. Really?""*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Right away, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I walked him out, then got busy packing. My head was buzz..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I can't wait till I can leave this all behind.""]** — Mówca: **Player**
> ""I can't wait till I can leave this all behind.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Come on, Anton. Really?""*)

### Węzeł `[17]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Petr would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Flee the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Leave after covering up your tracks."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks. There were some documents that needed to be incinerated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeac..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Flee the country."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player_Italic: "Go to bed."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""I don't think I want another term.""]** — Mówca: **Player**
> ""I don't think I want another term.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Come on, Anton. Really?""*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "The guards formed a cordon to let Petr and me through."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I can't wait for my next term.""]** — Mówca: **Player**
> ""I can't wait for my next term.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true` AND `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Petr smiled."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""Talk to me, Anton. I know you've got something on your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Thanks. If you don't mind, Petr, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks. If you don't mind, Petr, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Petr Vectern), `[180]` (Petr Vectern), `[251]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: ""Yeah, sure.""*)

### Węzeł `[29]`
Mówca: **Narrator**
> "The guards formed a cordon to let Petr and me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Italic: "Give the guards a suspicious look."*)
  - -> `[40]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "We hurried past them and went inside. I locked the front ..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Petr would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""That Anton Rayne was a liar.""]** — Mówca: **Player**
> ""That Anton Rayne was a liar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Petr Vectern), `[258]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[209]` (*Player: ""I've got to face facts, Petr. It's over.""*)

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""Anton? Something on your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Petr leaned over and switched off the TV. He looked at me with serious eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: ""Talk to me, Anton. I know you've got something on your m..."*)

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""Now you listen here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Petr Vectern: ""The Anton Rayne I met in university would never have sat..."*)

### Węzeł `[39]`
Mówca: **Petr Vectern**
> ""Come on, Anton. Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""I lost my wife, Petr.""*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[256]` (*Player: ""I might never see my kids again, Petr.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "We rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator), `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Once we were inside, I locked the front door behind me."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator), `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Once we were inside, I locked the front door behind me."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "We hurried past them and went inside. I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Petr, want a beer?""*)
  - -> `[57]` (*Player: ""Sorry about the mess in here.""*)
  - -> `[54]` (*Player: ""I'd make dinner, but the chef has the night off and I do..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Once we were inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Petr, want a beer?""*)
  - -> `[57]` (*Player: ""Sorry about the mess in here.""*)
  - -> `[54]` (*Player: ""I'd make dinner, but the chef has the night off and I do..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Petr smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Petr Vectern: ""Now that's the Anton Rayne I know and love.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I lost Serge.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Italic: "Leave now."*)
  - -> `[19]` (*Player_Italic: "Leave after covering up your tracks."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "I hoped Petr wouldn't be too mad at me for letting him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "If only for Petr's sake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "I only had a few months left as President of Sordland. I had to make them count."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "A slow smile spread across Petr's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Petr Vectern: ""Anton, this could be exactly what both of us need. A fre..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'd make dinner, but the chef has the night off and I don't have any food in the fridge.""]** — Mówca: **Player**
> ""I'd make dinner, but the chef has the night off and I don't have any food in the fridge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Petr Vectern: ""Frozen TV dinners, my man! They're a game-changer.""*)

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""Damn right you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""See? The football team still thinks you're great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""That's because I own them.""*)
  - -> `[202]` (*Player: ""Yeah, I know.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Sorry about the mess in here.""]** — Mówca: **Player**
> ""Sorry about the mess in here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""Ha. You should see my place.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""See? You've still got a few fans in Sordland.""]** — Mówca: **Petr Vectern**
> ""See? You've still got a few fans in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""In Anrica, anyway.""*)
  - -> `[204]` (*Player: ""Yeah, I know.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I can't even watch a goddamn football game anymore!""]** — Mówca: **Player**
> ""I can't even watch a goddamn football game anymore!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Petr Vectern), `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: ""Anton? Something on your mind?""*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "Decide to continue."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I had come this far. I would finish what I had started."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "If only for Petr's sake."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I hoped Petr wouldn't be too mad at me for letting him down."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "Start planning for the end of your presidency."]** — Mówca: **Player_Italic**
> "I went upstairs to my office and started working again."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I only had a few months left as President of Sordland. I ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I don't think we have a choice.""]** — Mówca: **Player**
> ""I don't think we have a choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "A slow smile spread across Petr's face."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "A slow smile spread across Petr's face."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Petr, want a beer?""]** — Mówca: **Player**
> ""Petr, want a beer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""Now that's the Anton Rayne I know and love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""I'm going to do everything right this time.""*)
  - -> `[104]` (*Player: ""I'm going to crush *all* my enemies.""*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[94]` (*Player: ""I'm going to get my wife and kids back.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I lost Serge.""]** — Mówca: **Player**
> ""I lost Serge.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern), `[51]` (Narrator), `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""I lost my wife, Petr.""]** — Mówca: **Player**
> ""I lost my wife, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[69]`
Mówca: **Petr Vectern**
> ""Whoa. Whoa! We're really doing this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""Yes.""*)
  - -> `[63]` (*Player: ""I don't think we have a choice.""*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Italic: "Start planning for the end of your presidency."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Italic: "Draft a speech announcing your retirement from politics."*)
  - -> `[60]` (*Player_Italic: "Decide to continue."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Maybe this would be my year after all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why can't they just stick to kicking the ball around? Why bring politics into it?""]** — Mówca: **Player**
> ""Why can't they just stick to kicking the ball around? Why bring politics into it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Petr Vectern), `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: ""Anton? Something on your mind?""*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Ha. You should see my place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Petr glanced around the house. With Monica and the childr..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "After showing Petr to the door, I sat and thought for a while longer. His confidence in me was touching. But was it enough?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""And you're coming with me.""]** — Mówca: **Player**
> ""And you're coming with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Player), `[141]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Petr Vectern: ""Whoa. Whoa! We're really doing this?""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I won't ask you to come with me. I know you've got your life here.""]** — Mówca: **Player**
> ""I won't ask you to come with me. I know you've got your life here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Player), `[141]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Petr Vectern: ""Excuse me, but what life? Of course I'm coming with you.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Sorry. I suddenly lost my interest in football.""]** — Mówca: **Player**
> ""Sorry. I suddenly lost my interest in football.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Petr Vectern), `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: ""Anton? Something on your mind?""*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Petr glanced around the house. With Monica and the children's belongings gone and my work documents spread everywhere, it barely resembled a home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "My presidency was coming to an end. But for this evening, at least, it didn't matter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "I walked Petr to the door, then went upstairs. I still had some work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Look at us. A couple of swinging bachelors, just like in the old days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""What woman would want us now?""*)
  - -> `[227]` (*Player: ""Sure. Mothers, lock up your daughters.""*)
  - -> `[228]` (*Player: ""I miss her, Petr.""*)

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""And I'll be right there with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[28]` (*Player: ""Thanks. If you don't mind, Petr, I'd rather be alone ton..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "FC Anrica was playing marvellously. But as the game went on, I found my attention waning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Petr leaned over and switched off the TV. He looked at me..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""I'm going to get back at those bastards that tried to ki..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Maybe this would be my year after all."*)

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""Good luck, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "After showing Petr to the door, I sat and thought for a w..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""I can get along just fine without her.""]** — Mówca: **Player**
> ""I can get along just fine without her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Petr Vectern: ""Very convincing.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Too good for me.""]** — Mówca: **Player**
> ""Too good for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Petr Vectern: ""Just like Evelyn.""*)

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""The Anton Rayne I met in university would never have sat around feeling sorry for himself like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""He was strong. Brave. Full of hope.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""I'm going to get my wife and kids back.""]** — Mówca: **Player**
> ""I'm going to get my wife and kids back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""Damn right you will.""*)

### Węzeł `[95]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "My presidency was coming to an end. But for this evening,..."*)

### Węzeł `[96]`
Mówca: **Petr Vectern**
> ""Good luck, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "I walked Petr to the door, then went upstairs. I still ha..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "My presidency was coming to an end. But for this evening,..."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""He was strong. Brave. Full of hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The captain stood up and explained that the President of Sordland had a substantial stake in the team. In protest of my despicable actions, he and his teammates would not be playing tonight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Italic: "Turn off the TV."*)
  - -> `[105]` (*Player_Italic: "Throw a heavy paperweight at the TV."*)

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""Yeah, sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""Good luck, Mr. President.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""And you're coming with me.""*)
  - -> `[78]` (*Player: ""I won't ask you to come with me. I know you've got your ..."*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""I thought you'd never ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[103]`
Mówca: **Petr Vectern**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I turned the TV back on. FC Anrica had already scored a g..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""I'm going to crush *all* my enemies.""]** — Mówca: **Player**
> ""I'm going to crush *all* my enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""Damn right you will.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "Throw a heavy paperweight at the TV."]** — Mówca: **Player_Italic**
> "I picked up the nearest paperweight and threw it at the screen. Broken glass flew everywhere."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Narrator), `[131]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV = true"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""It's true. I was strong. And I still am.""]** — Mówca: **Player**
> ""It's true. I was strong. And I still am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Petr Vectern), `[258]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[211]` (*Player: ""But sometimes being strong means knowing when to throw i..."*)

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""Don't you worry. You'll find another woman deserving of the great Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[143]` (*Player: ""Yes, I will. But tonight's not the time to start looking.""*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Now that I'd said it, it seemed like the most obvious solution in the world. The gears in my head started spinning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

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
  - -> `[181]` (*Player: ""And I think things are about to get a whole lot worse.""*)
  - -> `[182]` (*Player: ""Not to mention that the Court's about to have me impeach..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: ""Who or what else am I going to have to sacrifice before ..."*)
  - -> `[172]` (*Player: ""But you're right. I should try to think positively.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""You still think I'm great? After everything that's come ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""That Anton Rayne was a naive idiot.""]** — Mówca: **Player**
> ""That Anton Rayne was a naive idiot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Petr Vectern), `[258]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[209]` (*Player: ""I've got to face facts, Petr. It's over.""*)

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""I thought you'd never ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "I turned the TV back on. FC Anrica had already scored a g..."*)

### Węzeł `[118]`
Mówca: **Petr Vectern**
> ""Yeah, sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Petr Vectern: ""Good luck, Mr. President.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Thanks, that means a lot. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[84]` (Petr Vectern), `[180]` (Petr Vectern), `[251]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Petr Vectern: ""Nothing would make me happier.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Thanks, that means a lot. Sorry I broke the TV, but you can still stay for a drink or two.""]** — Mówca: **Player**
> ""Thanks, that means a lot. Sorry I broke the TV, but you can still stay for a drink or two.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Kontekst wejściowy (poprzednik):** `[84]` (Petr Vectern), `[180]` (Petr Vectern), `[251]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""I thought you'd never ask.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "Turn off the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Narrator), `[131]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""Bummer.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""You still think I'm great? After losing the nomination t..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WYBÓR GRACZA: ""You still think I'm great? After everything that's come out about me?""]** — Mówca: **Player**
> ""You still think I'm great? After everything that's come out about me?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Kontekst wejściowy (poprzednik):** `[107]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Petr Vectern: ""Like I haven't done worse?""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""You still think I'm great? After losing the nomination to Lileas?""]** — Mówca: **Player**
> ""You still think I'm great? After losing the nomination to Lileas?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Petr Vectern: ""Don't beat yourself up about it. You know she only got t..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Petr Vectern: ""Whoa there, cowboy!""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: ""And I think things are about to get a whole lot worse.""*)
  - -> `[200]` (*Player: ""And I'm about to get crucified for giving half our count..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing Lileas Graf for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Italic: "Turn off the TV."*)
  - -> `[105]` (*Player_Italic: "Throw a heavy paperweight at the TV."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: ""And I think things are about to get a whole lot worse.""*)
  - -> `[201]` (*Player: ""And I think the military is still plotting against me.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Thanks. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""Nothing would make me happier.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Who says I don't have fun now? Sorry I broke the TV, but you can still stay for a drink or two.""]** — Mówca: **Player**
> ""Who says I don't have fun now? Sorry I broke the TV, but you can still stay for a drink or two.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Petr Vectern: ""I thought you'd never ask.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Thanks for that. If you don't mind, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks for that. If you don't mind, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Petr Vectern: ""Yeah, sure.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true )"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""Thanks, that means a lot. Sorry I broke the TV, but you ..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""Thanks, that means a lot. Let's finish the game.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Yes. That's it. I'm leaving for Kyrute tomorrow.""]** — Mówca: **Player**
> ""Yes. That's it. I'm leaving for Kyrute tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""]** — Mówca: **Player**
> ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Yes, I will. But tonight's not the time to start looking.""]** — Mówca: **Player**
> ""Yes, I will. But tonight's not the time to start looking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""Who says I don't have fun now? Sorry I broke the TV, but..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""Thanks. Let's finish the game.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player: ""But I've made it this far. I'll stick out the rest of my..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player: ""But you're right. I've made it this far. I've got to kee..."*)

### Węzeł `[150]`
Mówca: **Petr Vectern**
> ""Whoa there, cowboy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""I can't even watch a goddamn football game anymore!""*)
  - -> `[74]` (*Player: ""Why can't they just stick to kicking the ball around? Wh..."*)
  - -> `[79]` (*Player: ""Sorry. I suddenly lost my interest in football.""*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""Bummer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""I can't even watch a goddamn football game anymore!""*)
  - -> `[74]` (*Player: ""Why can't they just stick to kicking the ball around? Wh..."*)
  - -> `[79]` (*Player: ""Sorry. I suddenly lost my interest in football.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""That's because I own them.""]** — Mówca: **Player**
> ""That's because I own them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: ""Yes. That's it. I'm leaving for Kyrute tomorrow.""*)
  - -> `[142]` (*Player: ""Yes. That's it. I will leave for Kyrute soon. But, first..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: ""See? The football team still thinks you're great.""*)

### Węzeł `[155]`
Mówca: **Narrator**
> "We went into the living room and settled into our chairs. The game was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[156]`
Mówca: **Petr Vectern**
> ""That makes us both quitters, then. Somehow, I always thought you were better than me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Petr Vectern: ""I understand, though. I hope being retired means you'll ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Won == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""I'm going to get back at those bastards that tried to kill me.""]** — Mówca: **Player**
> ""I'm going to get back at those bastards that tried to kill me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[66]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""Damn right you will.""*)

### Węzeł `[161]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech thanking me for all I'd done during my term."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: ""See? The football team still thinks you're great.""*)

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""You're what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Now that I'd said it, it seemed like the most obvious sol..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I'm going to do everything right this time.""]** — Mówca: **Player**
> ""I'm going to do everything right this time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""Damn right you will.""*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Petr frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Petr's eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Petr Vectern: ""You're what?""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Publi..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_GameOff = true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""But you're right. I should try to think positively.""]** — Mówca: **Player**
> ""But you're right. I should try to think positively.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false` AND `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player), `[68]` (Player), `[256]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Petr grinned."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Who or what else am I going to have to sacrifice before this is over?""]** — Mówca: **Player**
> ""Who or what else am I going to have to sacrifice before this is over?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false` AND `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player), `[68]` (Player), `[256]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Now you listen here.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""I'm leaving Sordland.""]** — Mówca: **Player**
> ""I'm leaving Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Petr's eyes widened."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I'm not staying in politics after my presidency ends.""]** — Mówca: **Player**
> ""I'm not staying in politics after my presidency ends.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Petr frowned."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I'm retiring from politics. My mind is made up.""]** — Mówca: **Player**
> ""I'm retiring from politics. My mind is made up.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Petr frowned."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Won == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_LileasResigned == true"*)

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""We'll get through this. You can count on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[28]` (*Player: ""Thanks. If you don't mind, Petr, I'd rather be alone ton..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""And I think things are about to get a whole lot worse.""]** — Mówca: **Player**
> ""And I think things are about to get a whole lot worse.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player), `[68]` (Player), `[256]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Now you listen here.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Not to mention that the Court's about to have me impeached.""]** — Mówca: **Player**
> ""Not to mention that the Court's about to have me impeached.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true` AND `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player), `[68]` (Player), `[256]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Now you listen here.""*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: ""I'm leaving Sordland.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Narrator**
> "Right before kickoff, all of the members of FC Anrica suddenly lay down on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "The captain stood up and explained that the President of ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""I'm retiring from politics. My mind is made up.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[190]`
Mówca: **Petr Vectern**
> ""That sounds like the Anton I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_LileasResigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_LileasResigned == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_LileasResigned == true )"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_LileasResigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_LileasResigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_LileasResigned == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_LileasResigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_GameOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_GameOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Right before kickoff, all of the members of FC Anrica sud..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Before kickoff, the team captain gave a short speech than..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[198]`
Mówca: **Petr Vectern**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[199]`
Mówca: **Narrator**
> "Petr looked at me, his eyes glowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Petr Vectern: ""That sounds like the Anton I know.""*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""And I'm about to get crucified for giving half our country to Rumburg.""]** — Mówca: **Player**
> ""And I'm about to get crucified for giving half our country to Rumburg.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player), `[68]` (Player), `[256]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Now you listen here.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA: ""And I think the military is still plotting against me.""]** — Mówca: **Player**
> ""And I think the military is still plotting against me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[67]` (Player), `[68]` (Player), `[256]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Petr Vectern: ""Now you listen here.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""In Anrica, anyway.""]** — Mówca: **Player**
> ""In Anrica, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""Thanks for believing in me, Petr. I'll stick out the res..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: ""Thanks for believing in me, Petr. I'll keep going for you.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""But you're right. I've made it this far. I've got to keep going.""]** — Mówca: **Player**
> ""But you're right. I've made it this far. I've got to keep going.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Player), `[115]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Petr looked at me, his eyes glowing."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""I've got to face facts, Petr. It's over.""]** — Mówca: **Player**
> ""I've got to face facts, Petr. It's over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Player), `[115]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Petr Vectern: ""You mean...""*)

### Węzeł `[210]`
**[WYBÓR GRACZA: ""But I've made it this far. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""But I've made it this far. I'll stick out the rest of my term for you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Player), `[115]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Petr looked at me, his eyes glowing."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: ""But sometimes being strong means knowing when to throw in the towel.""]** — Mówca: **Player**
> ""But sometimes being strong means knowing when to throw in the towel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Petr Vectern: ""You mean...""*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Petr. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Petr. I'll stick out the rest of my term for you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[106]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Petr looked at me, his eyes glowing."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Petr. I'll keep going for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Petr. I'll keep going for you.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Petr looked at me, his eyes glowing."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Petr Vectern: ""See? You've still got a few fans in Sordland.""*)

### Węzeł `[215]`
Mówca: **Petr Vectern**
> ""Frozen TV dinners, my man! They're a game-changer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Petr glanced around the house. With Monica and the childr..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Petr Vectern: ""Don't you remember? I'm sober as a nun these days. I'm h..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Petr raised an eyebrow."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Petr raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Petr Vectern: ""Only if you don't have anything stronger.""*)

### Węzeł `[220]`
Mówca: **Petr Vectern**
> ""Only if you don't have anything stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Petr glanced around the house. With Monica and the childr..."*)

### Węzeł `[221]`
Mówca: **Petr Vectern**
> ""Don't you remember? I'm sober as a nun these days. I'm healthier than I've ever been and so, so bored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Petr glanced around the house. With Monica and the childr..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Petr Vectern: ""I'm sorry you didn't learn from my mistakes. She was a g..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""Look at us. A couple of swinging bachelors, just like in..."*)

### Węzeł `[225]`
Mówca: **Petr Vectern**
> ""I'm sorry you didn't learn from my mistakes. She was a good woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""I can get along just fine without her.""*)
  - -> `[92]` (*Player: ""Too good for me.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""What woman would want us now?""]** — Mówca: **Player**
> ""What woman would want us now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Petr Vectern: ""Oh, you'd be surprised.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""Sure. Mothers, lock up your daughters.""]** — Mówca: **Player**
> ""Sure. Mothers, lock up your daughters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Petr Vectern: ""Very convincing.""*)

### Węzeł `[228]`
**[WYBÓR GRACZA: ""I miss her, Petr.""]** — Mówca: **Player**
> ""I miss her, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Petr Vectern: ""I miss Evelyn, too.""*)

### Węzeł `[229]`
Mówca: **Petr Vectern**
> ""Just like Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""Don't you worry. You'll find another woman deserving of ..."*)

### Węzeł `[230]`
Mówca: **Petr Vectern**
> ""Very convincing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""Don't you worry. You'll find another woman deserving of ..."*)

### Węzeł `[231]`
Mówca: **Petr Vectern**
> ""I miss Evelyn, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""Don't you worry. You'll find another woman deserving of ..."*)

### Węzeł `[232]`
Mówca: **Petr Vectern**
> ""Don't beat yourself up about it. You know she only got that far with Soll's hand up her keister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[233]`
Mówca: **Petr Vectern**
> ""Like I haven't done worse?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""You still think I'm great? After getting my driver killed?""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player: ""I wouldn't count on that.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""You still think I'm great? After getting my driver killed?""]** — Mówca: **Player**
> ""You still think I'm great? After getting my driver killed?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true` AND `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Petr Vectern: ""I'm sorry about Serge, But there was nothing you could h..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""I wouldn't count on that.""]** — Mówca: **Player**
> ""I wouldn't count on that.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false` AND `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Kontekst wejściowy (poprzednik):** `[107]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""I'm sorry about Serge, But there was nothing you could have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Petr ducked into the kitchen and helped himself to some o..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Petr ducked into the kitchen and took two beers from the ..."*)

### Węzeł `[243]`
Mówca: **Petr Vectern**
> ""So, how are things back at the office?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Petr Vectern: ""You know what? Don't answer that. You deserve one night ..."*)

### Węzeł `[244]`
Mówca: **Petr Vectern**
> ""You know what? Don't answer that. You deserve one night off from politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "We went into the living room and settled into our chairs...."*)

### Węzeł `[245]`
Mówca: **Petr Vectern**
> ""Thanks for the invite, Anton. I think we both deserve a night off from politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "We went into the living room and settled into our chairs...."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Petr ducked into the kitchen and took two beers from the fridge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Petr Vectern: ""Thanks for the invite, Anton. I think we both deserve a ..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "Petr ducked into the kitchen and helped himself to some orange juice from the fridge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Petr Vectern: ""So, how are things back at the office?""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Petr Vectern: ""I just wish I could be there to help you.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: ""And I'll be right there with you.""*)

### Węzeł `[251]`
Mówca: **Petr Vectern**
> ""I just wish I could be there to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[28]` (*Player: ""Thanks. If you don't mind, Petr, I'd rather be alone ton..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""I can't wait for my next term.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player: ""I can't wait for our next term.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA: ""I can't wait for our next term.""]** — Mówca: **Player**
> ""I can't wait for our next term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false` AND `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Petr smiled."*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I might never see my kids again, Petr.""]** — Mówca: **Player**
> ""I might never see my kids again, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[257]`
Mówca: **Petr Vectern**
> ""I would have followed him to the ends of the earth. And I basically did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""That Anton Rayne was a naive idiot.""*)
  - -> `[35]` (*Player: ""That Anton Rayne was a liar.""*)
  - -> `[106]` (*Player: ""It's true. I was strong. And I still am.""*)

### Węzeł `[258]`
Mówca: **Petr Vectern**
> ""I would have followed him to the ends of the earth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""That Anton Rayne was a naive idiot.""*)
  - -> `[35]` (*Player: ""That Anton Rayne was a liar.""*)
  - -> `[106]` (*Player: ""It's true. I was strong. And I still am.""*)

### Węzeł `[259]`
Mówca: **Petr Vectern**
> ""Excuse me, but what life? Of course I'm coming with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "A slow smile spread across Petr's face."*)

### Węzeł `[260]`
Mówca: **Petr Vectern**
> ""Anton, this could be exactly what both of us need. A fresh start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player: ""We're fleeing the country, not going on holiday.""*)
  - -> `[262]` (*Player: ""I don't know. When you've messed up as badly as we have,..."*)
  - -> `[263]` (*Player: ""Exactly. Some mountain air, some vegetable farming, no g..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""We're fleeing the country, not going on holiday.""]** — Mówca: **Player**
> ""We're fleeing the country, not going on holiday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Petr Vectern: ""Spoilsport.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""I don't know. When you've messed up as badly as we have, there are no fresh starts.""]** — Mówca: **Player**
> ""I don't know. When you've messed up as badly as we have, there are no fresh starts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Petr Vectern: ""Spoilsport.""*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""Exactly. Some mountain air, some vegetable farming, no godforskaken budget meetings ever again.""]** — Mówca: **Player**
> ""Exactly. Some mountain air, some vegetable farming, no godforsaken budget meetings ever again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Petr Vectern: ""Bet you'll miss Lucian, though.""*)

### Węzeł `[264]`
Mówca: **Petr Vectern**
> ""Spoilsport.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""Stay for a drink. Let's plan this out.""*)
  - -> `[269]` (*Player: ""Go home and start making your arrangements. I'll call yo..."*)

### Węzeł `[265]`
Mówca: **Petr Vectern**
> ""Bet you'll miss Lucian, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: ""Very funny.""*)
  - -> `[267]` (*Player: ""I kind of will.""*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Very funny.""]** — Mówca: **Player**
> ""Very funny.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""Stay for a drink. Let's plan this out.""*)
  - -> `[269]` (*Player: ""Go home and start making your arrangements. I'll call yo..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA: ""I kind of will.""]** — Mówca: **Player**
> ""I kind of will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""Stay for a drink. Let's plan this out.""*)
  - -> `[269]` (*Player: ""Go home and start making your arrangements. I'll call yo..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA: ""Stay for a drink. Let's plan this out.""]** — Mówca: **Player**
> ""Stay for a drink. Let's plan this out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Petr Vectern), `[266]` (Player), `[267]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Petr Vectern: ""With pleasure, Mr. President.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""Go home and start making your arrangements. I'll call you in the morning.""]** — Mówca: **Player**
> ""Go home and start making your arrangements. I'll call you in the morning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Petr Vectern), `[266]` (Player), `[267]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""Right away, Mr. President.""*)

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""With pleasure, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "We stayed up until late, planning our departure and our i..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "We stayed up until late, planning our departure and our initial few nights of accommodation in Kyrute. By the end of it, I was excited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Maybe Petr was right. Maybe this could be a fresh start."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Maybe Petr was right. Maybe this could be a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou = true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_PetrWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Petr Vectern: ""I would have followed him to the ends of the earth.""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Petr Vectern: ""I would have followed him to the ends of the earth. And ..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Petr Vectern: ""That makes us both quitters, then. Somehow, I always tho..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Petr Vectern: ""But being your right-hand man is pretty much the only th..."*)

### Węzeł `[280]`
Mówca: **Petr Vectern**
> ""But being your right-hand man is pretty much the only thing I've got left going for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Petr Vectern: ""I understand, though. I hope being retired means you'll ..."*)

### Węzeł `[281]`
Mówca: **Petr Vectern**
> ""I understand, though. I hope being retired means you'll actually get to have some fun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[137]` (*Player: ""Thanks for that. If you don't mind, I'd rather be alone ..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "I poured a beer for myself and a glass of juice for Petr...."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "I cracked open two beers and we raised the bottles in a b..."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "I poured a beer for myself and a glass of juice for Petr. We raised our cups in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "My presidency was coming to an end. But for this evening,..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Petr Vectern: ""Just wish I could be there to see it through with you.""*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Petr Vectern: ""We'll get through this. You can count on me.""*)

### Węzeł `[289]`
Mówca: **Petr Vectern**
> ""Just wish I could be there to see it through with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[28]` (*Player: ""Thanks. If you don't mind, Petr, I'd rather be alone ton..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "I poured a beer for myself and a glass of juice for Petr...."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "I cracked open two beers and we raised the bottles in a b..."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Maybe this would be my year after all."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "I poured a beer for myself and a glass of juice for Petr. We raised our cups in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Maybe this would be my year after all."*)

### Węzeł `[295]`
**[WYBÓR GRACZA: "Go to bed."]** — Mówca: **Player_Italic**
> "I went upstairs and collapsed in my bed."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[299]`
**[WYBÓR GRACZA: ""I don't want to stay in politics.""]** — Mówca: **Player**
> ""I don't want to stay in politics.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Come on, Anton. Really?""*)

### Węzeł `[300]`
**[WYBÓR GRACZA: ""I can't wait for a fresh start in politics once my term ends.""]** — Mówca: **Player**
> ""I can't wait for a fresh start in politics once my term ends.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Petr Vectern), `[36]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Petr smiled."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Turn10_PartyCongress_FormNewParty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Tur..."*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Won == true || BaseGame.T..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Turn10_PartyCongress_FormNewParty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""I don't think I want another term.""*)
  - -> `[14]` (*Player: ""I don't think I can win this election.""*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Turn10_PartyCongress_FormNewParty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player: ""I don't want to stay in politics.""*)
  - -> `[300]` (*Player: ""I can't wait for a fresh start in politics once my term ..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: ""I'm not staying in politics after my presidency ends.""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: ""I'm not running for re-election. I'm giving up politics.""*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""I'm not running for re-election. I'm giving up politics.""]** — Mówca: **Player**
> ""I'm not running for re-election. I'm giving up politics.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Petr frowned."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""And you're coming with me.""*)
  - -> `[78]` (*Player: ""I won't ask you to come with me. I know you've got your ..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "It was time for a fresh start. I hoped Petr would underst..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "It was time for a fresh start. I hoped Petr would underst..."*)
