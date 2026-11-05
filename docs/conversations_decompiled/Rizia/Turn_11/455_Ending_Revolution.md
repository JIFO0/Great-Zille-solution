# Rizia/Turn 11/Ending_Revolution

- **ID konwersacji:** `455`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Rizia/Turn_11/455_Ending_Revolution.md`
- **Liczba węzłów dialogowych:** 1287
- **Liczba wyborów gracza:** 178

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[90]** Bruno
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_InjuredInRevolution`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_FinalDecision_StayAndFight`
- `RiziaDLC.Pabel_InjuredInRevolution`
- `RiziaDLC.Policy_Order_GoldenGuard_Default`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn01_Religion_DivusZaitu`
- `RiziaDLCIsolated.Ending_Revolution_SevrioDead`
- `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno`
- `RiziaDLCIsolated.Revolution_EscapeCountdown`
- `RiziaDLCIsolated.Revolution_Guards_Count`
- `RiziaDLCIsolated.Revolution_Guards_Defend`
- `RiziaDLCIsolated.Revolution_Guards_Follow`
- `RiziaDLCIsolated.Revolution_Guards_Reinforcements`
- `RiziaDLCIsolated.Revolution_GunEmpty`
- `RiziaDLCIsolated.Revolution_HelicopterEnemyCount`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow`
- `RiziaDLCIsolated.Revolution_Titus_Reinforcements`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Epilogue_Death_Revolution_Speech`
- `RiziaDLC.Epilogue_Death_Revolution_Surrounded`
- `RiziaDLC.Epilogue_KingdomDissolves_Revolution`
- `RiziaDLC.Epilogue_Prison_Revolution_Surrounded`
- `RiziaDLC.Epilogue_Revolution_Survived_WithLucita`
- `RiziaDLC.Epilogue_Revolution_Survived_WithPabel`
- `RiziaDLC.Epilogue_Survived_Revolution`
- `RiziaDLC.Lucita_InjuredInRevolution`
- `RiziaDLC.Pabel_InjuredInRevolution`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLCIsolated.Ending_Revolution_SevrioDead`
- `RiziaDLCIsolated.Ending_Revolution_TitusDead`
- `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno`
- `RiziaDLCIsolated.Revolution_Barricade`
- `RiziaDLCIsolated.Revolution_Dialogue`
- `RiziaDLCIsolated.Revolution_EscapeCountdown`
- `RiziaDLCIsolated.Revolution_Guards_Count`
- `RiziaDLCIsolated.Revolution_Guards_Defend`
- `RiziaDLCIsolated.Revolution_Guards_Follow`
- `RiziaDLCIsolated.Revolution_Guards_Reinforcements`
- `RiziaDLCIsolated.Revolution_GunEmpty`
- `RiziaDLCIsolated.Revolution_Helicopter`
- `RiziaDLCIsolated.Revolution_HelicopterEnemyCount`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend`
- `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow`
- `RiziaDLCIsolated.Revolution_Titus_Reinforcements`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""There's too many of them. We don't stand a chance. I'll address them from the pal..."** | `[190]` **Player_Romus_Italic**: "I loaded a magazine into my gun ..."<br>`[729]` **Narrator**: "Titus handed me a gun. I stared ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_Dialogue"] = true;` | `[31]` **Lucita Azaro**: ""No, you can't! Are you insane? ..." |
| `[7]` | **""We can't rely on outside help. We have to get to the helipad on our own. It's ris..."** | `[190]` **Player_Romus_Italic**: "I loaded a magazine into my gun ..."<br>`[729]` **Narrator**: "Titus handed me a gun. I stared ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_Helicopter"] = true;` | `[39]` **Lucita Azaro**: ""I'll try my best to keep up. Bu..." |
| `[8]` | **""We'll barricade ourselves here and hold out until help arrives. We have no choice..."** | `[190]` **Player_Romus_Italic**: "I loaded a magazine into my gun ..."<br>`[729]` **Narrator**: "Titus handed me a gun. I stared ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_Barricade"] = true;` | `[49]` **Lucita Azaro**: ""They'd better arrive soon, or w..." |
| `[19]` | **""I'll do whatever it takes to protect you. Both of you.""** | `[23]` **Lucita Azaro**: ""If it weren't for {RiziaDLCText..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[641]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[20]` | **""I'm afraid you're right.""** | `[23]` **Lucita Azaro**: ""If it weren't for {RiziaDLCText..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[641]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[21]` | **""Don't worry. Everything's going to be fine.""** | `[23]` **Lucita Azaro**: ""If it weren't for {RiziaDLCText..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[641]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[52]` | **""Stay with us. Grab whatever you can and barricade the door.""** | `[51]` **Narrator**: "My guards turned to me for instr..."<br>`[993]` **Titus Gordion**: ""Your orders, sir?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1001]` **Narrator**: "Titus saluted, prompting the oth..."<br>`[1276]` **Narrator**: "Sevrio saluted me, prompting the..."<br>*(oraz 1 innych odgałęzień)* |
| `[53]` | **""We need reinforcements. Go round up as many other guards as you can.""** | `[51]` **Narrator**: "My guards turned to me for instr..."<br>`[993]` **Titus Gordion**: ""Your orders, sir?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[997]` **Narrator**: "With a salute, Titus rushed out ..."<br>`[1272]` **Narrator**: "With a salute, Sevrio rushed out..."<br>*(oraz 1 innych odgałęzień)* |
| `[54]` | **""All of you, come with me. We need every available hand to make it through.""** | `[41]` **Narrator**: "My guards awaited my instructions."<br>`[653]` **Titus Gordion**: ""Your instructions, sir?""<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "They saluted and fell in step be..." |
| `[55]` | **""One of you remain here in case there's any attempt to contact us over the radio.""** | `[41]` **Narrator**: "My guards awaited my instructions."<br>`[1221]` **Narrator**: "They informed me that the enemy ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Va...` | `[62]` **Narrator**: "One of the guards saluted before..." |
| `[56]` | **""Come with me. I can't go out there without any guards.""** | `[42]` **Narrator**: "I turned to see my guards, their..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "They saluted and fell into step ..." |
| `[57]` | **""Stay here and defend this room with your lives. Is that clear?""** | `[42]` **Narrator**: "I turned to see my guards, their..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "They gave a resounding "Yes, sir..." |
| `[74]` | **""If I don't make it back, know that I will always love you.""** | `[31]` **Lucita Azaro**: ""No, you can't! Are you insane? ..."<br>`[32]` **Pabel Adria**: ""That's insane! They'll arrest y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Narrator**: "I turned to see Titus awaiting m..."<br>`[1142]` **Narrator**: "I turned to see Sevrio, his expe..."<br>*(oraz 1 innych odgałęzień)* |
| `[75]` | **""Remember me well.""** | `[31]` **Lucita Azaro**: ""No, you can't! Are you insane? ..."<br>`[32]` **Pabel Adria**: ""That's insane! They'll arrest y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Narrator**: "I turned to see Titus awaiting m..."<br>`[1142]` **Narrator**: "I turned to see Sevrio, his expe..."<br>*(oraz 1 innych odgałęzień)* |
| `[76]` | **"Kiss him."** | `[32]` **Pabel Adria**: ""That's insane! They'll arrest y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Narrator**: "I turned to see Titus awaiting m..."<br>`[1142]` **Narrator**: "I turned to see Sevrio, his expe..."<br>*(oraz 1 innych odgałęzień)* |
| `[77]` | **"Kiss her."** | `[31]` **Lucita Azaro**: ""No, you can't! Are you insane? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Narrator**: "I turned to see Titus awaiting m..."<br>`[1142]` **Narrator**: "I turned to see Sevrio, his expe..."<br>*(oraz 1 innych odgałęzień)* |
| `[78]` | **"Leave the room."** | `[919]` **Player_Romus**: ""It's too dangerous for you out ..."<br>`[923]` **Player_Romus**: ""Stay here and protect Pabel.""<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`<br>`(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | `RemoveConversant("Titus Gordion"); RemoveConversant("Sevr...` | `[585]` **Narrator**: "The moment I stepped out, the gu..." |
| `[79]` | **"Leave the room."** | `[59]` **Narrator**: "They saluted and fell in step be..."<br>`[62]` **Narrator**: "One of the guards saluted before..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Narrator**: "One of the guards carefully open..." |
| `[81]` | **"Barricade with a table."** | `[58]` **Narrator**: "With a salute, two of my guards ..."<br>`[1272]` **Narrator**: "With a salute, Sevrio rushed out..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "And then we waited." |
| `[82]` | **"Barricade with a bookshelf."** | `[58]` **Narrator**: "With a salute, two of my guards ..."<br>`[1272]` **Narrator**: "With a salute, Sevrio rushed out..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "And then we waited." |
| `[84]` | **""Who is this?""** | `[86]` **Narrator**: "Before long, there was a knock o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "I heard the muffled voices of mu..." |
| `[85]` | **""Identify yourself.""** | `[86]` **Narrator**: "Before long, there was a knock o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "I heard the muffled voices of mu..." |
| `[87]` | **"Do not answer."** | `[86]` **Narrator**: "Before long, there was a knock o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "I heard the muffled voices of mu..." |
| `[88]` | **"Open the door."** | `[1100]` **Narrator**: "Bruno sniffed at the door and wa..."<br>`[90]` **Narrator**: "I heard the muffled voices of mu..." | `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | *Brak zmian stanu* | `[92]` **Narrator**: "It was the returning sentries br..."<br>`[117]` **Narrator**: "It was one of the palace cleaner..."<br>*(oraz 2 innych odgałęzień)* |
| `[89]` | **"Do not open the door."** | `[1100]` **Narrator**: "Bruno sniffed at the door and wa..."<br>`[90]` **Narrator**: "I heard the muffled voices of mu..." | `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | *Brak zmian stanu* | `[91]` **Narrator**: "After a short while, the people ..." |
| `[94]` | **""Before we proceed, we need additional reinforcements. Hurry and seek out more gua..."** | `[41]` **Narrator**: "My guards awaited my instructions." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "They saluted me and dashed out o..." |
| `[121]` | **"Listen closely."** | `[1065]` **Narrator**: "Bruno's ears flattened, and he s..."<br>`[120]` **Narrator**: "We continued reinforcing the doo..." | `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | *Brak zmian stanu* | `[123]` **Narrator**: "That's when I heard a loud pierc..." |
| `[122]` | **"Don't move."** | `[1065]` **Narrator**: "Bruno's ears flattened, and he s..."<br>`[120]` **Narrator**: "We continued reinforcing the doo..." | `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | *Brak zmian stanu* | `[127]` **Narrator**: "That's when I heard a loud beep." |
| `[124]` | **""GET DOWN!""** | `[123]` **Narrator**: "That's when I heard a loud pierc..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");` | `[1070]` **Titus Gordion**: ""Your Majesty! Look out!""<br>`[1280]` **Sevrio Castellanus**: ""Your Majesty! Look out!""<br>*(oraz 1 innych odgałęzień)* |
| `[125]` | **""IT'S THEM!""** | `[123]` **Narrator**: "That's when I heard a loud pierc..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");` | `[1070]` **Titus Gordion**: ""Your Majesty! Look out!""<br>`[1280]` **Sevrio Castellanus**: ""Your Majesty! Look out!""<br>*(oraz 1 innych odgałęzień)* |
| `[126]` | **""RUN!""** | `[123]` **Narrator**: "That's when I heard a loud pierc..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");` | `[1070]` **Titus Gordion**: ""Your Majesty! Look out!""<br>`[1280]` **Sevrio Castellanus**: ""Your Majesty! Look out!""<br>*(oraz 1 innych odgałęzień)* |
| `[133]` | **"Take cover."** | `[132]` **Narrator**: "A barrage of gunfire suddenly er..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Va...` | `[145]` **Narrator**: "As did Lucita."<br>`[152]` **Narrator**: "As did Pabel."<br>*(oraz 1 innych odgałęzień)* |
| `[140]` | **"Shield Pabel with your body."** | `[132]` **Narrator**: "A barrage of gunfire suddenly er..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[143]` **Narrator**: "I cried out in agony as a sharp ..." |
| `[141]` | **"Shield Lucita with your body."** | `[132]` **Narrator**: "A barrage of gunfire suddenly er..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false` | *Brak zmian stanu* | `[143]` **Narrator**: "I cried out in agony as a sharp ..." |
| `[142]` | **"Fire your gun blindly at the door."** | `[132]` **Narrator**: "A barrage of gunfire suddenly er..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "Cries of pain told me I'd manage..." |
| `[174]` | **"Drop your weapon."** | `[173]` **Narrator**: "That's when I realized that I wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "One of them stepped forward and ..." |
| `[175]` | **"Shoot them."** | `[173]` **Narrator**: "That's when I realized that I wa..." | *Brak (Dostępna bezwarunkowo)* | `StopMusic(); ;`<br>`StopMusic(); ;` | `[551]` **Lucita Azaro**: ""No! Romus! Don't do it!""<br>`[552]` **Pabel Adria**: ""Romus, wait! Don't!"" |
| `[182]` | **""Please. I beg you. Don't hurt me.""** | `[185]` **Narrator**: "One of them stepped forward and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "They closed in on me, delivering..." |
| `[183]` | **"“I’ll give you anything you want. Name your price. Just let us go.”"** | `[185]` **Narrator**: "One of them stepped forward and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "They closed in on me, delivering..." |
| `[186]` | **""You will pay for what you've done.""** | `[185]` **Narrator**: "One of them stepped forward and ..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[184]` **Narrator**: "They closed in on me, delivering..." |
| `[190]` | **"Load your gun."** | `[584]` **Narrator**: "They were inside." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true` | `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = 4;` | `[6]` **Player_Romus**: ""There's too many of them. We do..."<br>`[7]` **Player_Romus**: ""We can't rely on outside help. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[198]` | **"Hurry to the garden exit."** | `[202]` **Narrator**: "It was the most direct route but..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] =...` | `[201]` **Narrator**: "I couldn't believe that I was fl..."<br>`[207]` **Narrator**: "We attempted to cross swiftly, b..." |
| `[199]` | **"Approach cautiously."** | `[202]` **Narrator**: "It was the most direct route but..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] =...` | `[200]` **Narrator**: "Our small group advanced a few m..." |
| `[209]` | **"Instruct your guards to create a distraction."** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`<br>`(Variable["RiziaDLC.Titus_Arrested"] == false) == false`<br>`(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 0;...` | `[229]` **Narrator**: "In a flash, gunfire erupted. The..." |
| `[210]` | **"Try to sneak by without being seen."** | `[594]` **Narrator**: "However, considering the number ..."<br>`[208]` **Narrator**: "I cursed under my breath upon se..." | `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | *Brak zmian stanu* | `[220]` **Narrator**: "As I thought, the guards' equipm..."<br>`[227]` **Narrator**: "As luck would have it, we someho..." |
| `[214]` | **"Instruct your remaining guard to create a distraction."** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false`<br>`(Variable["RiziaDLC.Titus_Arrested"] == false) == false`<br>`(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Va...` | `[229]` **Narrator**: "In a flash, gunfire erupted. The..." |
| `[215]` | **"Instruct one of your guards to create a distraction."** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`<br>`(Variable["RiziaDLC.Titus_Arrested"] == false) == false`<br>`(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Va...` | `[229]` **Narrator**: "In a flash, gunfire erupted. The..." |
| `[216]` | **"Run by them as fast as you can."** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 0;...` | `[229]` **Narrator**: "In a flash, gunfire erupted. The..." |
| `[275]` | **""PRESS FORWARD! FIRE AT WILL!""** | `[267]` **Narrator**: "We had time. We could make it if..."<br>`[271]` **Narrator**: "It would be almost impossible to..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCoun...`<br>`Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCoun...`<br>*(+1 skryptów)* | `[303]` **Narrator**: "What followed was a blur in my m..." |
| `[276]` | **"Aim and fire your weapon."** | `[267]` **Narrator**: "We had time. We could make it if..."<br>`[271]` **Narrator**: "It would be almost impossible to..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "The shot struck the man planting..."<br>`[292]` **Narrator**: "I missed my shot." |
| `[327]` | **"Shoot him."** | `[315]` **Narrator**: "He immediately threw down his ri..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); ;` | `[335]` **Narrator**: "We had won. There was nothing in..." |
| `[328]` | **"Spare him."** | `[315]` **Narrator**: "He immediately threw down his ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Narrator**: "But just as I turned away from h..."<br>`[357]` **Narrator**: "But just as I turned away from h..."<br>*(oraz 1 innych odgałęzień)* |
| `[401]` | **"Board the helicopter."** | `[389]` **Narrator**: "Fueled by adrenaline, I found th..."<br>`[391]` **Narrator**: "Fueled by adrenaline, I found th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[799]` **Narrator**: "Just in time, Bruno hopped in an..."<br>`[409]` **Lucita Azaro**: ""R... Romus...""<br>*(oraz 2 innych odgałęzień)* |
| `[414]` | **""Sshh. Don't waste your energy, my love.""** | `[409]` **Lucita Azaro**: ""R... Romus...""<br>`[410]` **Pabel Adria**: ""R... Romus..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Lucita Azaro**: ""Lis... Listen to me...""<br>`[420]` **Pabel Adria**: ""Listen... Listen to me..."" |
| `[415]` | **""It's okay. It's over now. We're going to be fine. Just hang on.""** | `[409]` **Lucita Azaro**: ""R... Romus...""<br>`[410]` **Pabel Adria**: ""R... Romus..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Lucita Azaro**: ""Lis... Listen to me...""<br>`[420]` **Pabel Adria**: ""Listen... Listen to me..."" |
| `[416]` | **""We are almost out of here. I promise.""** | `[409]` **Lucita Azaro**: ""R... Romus...""<br>`[410]` **Pabel Adria**: ""R... Romus..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Lucita Azaro**: ""Lis... Listen to me...""<br>`[420]` **Pabel Adria**: ""Listen... Listen to me..."" |
| `[440]` | **""I love you so much.""** | `[419]` **Lucita Azaro**: ""Please...""<br>`[422]` **Pabel Adria**: ""My heart has always belonged to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Narrator**: "I ripped off another piece of my..." |
| `[441]` | **""Don't leave me. I need you.""** | `[419]` **Lucita Azaro**: ""Please...""<br>`[422]` **Pabel Adria**: ""My heart has always belonged to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Narrator**: "I ripped off another piece of my..." |
| `[442]` | **"“You’ll be fine. Just hold on a little longer.""** | `[419]` **Lucita Azaro**: ""Please...""<br>`[422]` **Pabel Adria**: ""My heart has always belonged to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Narrator**: "I ripped off another piece of my..." |
| `[448]` | **""I understand you now, Father. Perhaps I've grasped the depths of disgrace and sha..."** | `[447]` **Narrator**: "And that's when it hit me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[893]` **Titus Gordion**: ""Your Majesty, there's nothing t..."<br>`[452]` **Narrator**: "Unsurprisingly, his portrait did..." |
| `[449]` | **""Like father like son... 'Frail.' Am I destined to bear the same name?""** | `[447]` **Narrator**: "And that's when it hit me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[866]` **Titus Gordion**: ""Your Majesty, your strength sur..."<br>`[452]` **Narrator**: "Unsurprisingly, his portrait did..." |
| `[450]` | **""You should have never been the King.""** | `[447]` **Narrator**: "And that's when it hit me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Narrator**: "Unsurprisingly, his portrait did..." |
| `[451]` | **""I should have never been the King.""** | `[447]` **Narrator**: "And that's when it hit me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[871]` **Titus Gordion**: ""Sire, your reign has been marke..."<br>`[452]` **Narrator**: "Unsurprisingly, his portrait did..." |
| `[456]` | **""Halaita.""** | `[455]` **Narrator**: "I took a deep breath." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[898]` **Titus Gordion**: ""Divus zaitu!""<br>`[1163]` **Sevrio Castellanus**: ""Divus zaitu, Your Majesty. May ..."<br>*(oraz 1 innych odgałęzień)* |
| `[457]` | **""If I die, so be it.""** | `[455]` **Narrator**: "I took a deep breath." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[898]` **Titus Gordion**: ""Divus zaitu!""<br>`[1163]` **Sevrio Castellanus**: ""Divus zaitu, Your Majesty. May ..."<br>*(oraz 1 innych odgałęzień)* |
| `[458]` | **""Come on, Romus. You can do this.""** | `[455]` **Narrator**: "I took a deep breath." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[898]` **Titus Gordion**: ""Divus zaitu!""<br>`[1163]` **Sevrio Castellanus**: ""Divus zaitu, Your Majesty. May ..."<br>*(oraz 1 innych odgałęzień)* |
| `[459]` | **"Open the balcony doors."** | `[950]` **Narrator**: ""Divus zaitu" was a Wruhecist te..."<br>`[1163]` **Sevrio Castellanus**: ""Divus zaitu, Your Majesty. May ..."<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] == false) == false`<br>`(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false` | `RemoveConversant("Titus Gordion"); RemoveConversant("Sevr...` | `[460]` **Narrator**: "I gazed out into the Palace grou..." |
| `[462]` | **""Porte Drazon. Hear me!""** | `[461]` **Narrator**: "Yells and screams erupted from t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Narrator**: "A few mocking laughs reached my ..." |
| `[463]` | **""My fellow Rizians!""** | `[461]` **Narrator**: "Yells and screams erupted from t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Narrator**: "A few mocking laughs reached my ..." |
| `[464]` | **""My dearest subjects!""** | `[461]` **Narrator**: "Yells and screams erupted from t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Narrator**: "A few mocking laughs reached my ..." |
| `[466]` | **""I understand your anger, but it's misplaced.""** | `[465]` **Narrator**: "A few mocking laughs reached my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Player_Romus**: ""The fault lies with the system ..."<br>`[469]` **Player_Romus**: ""The responsibility for the mess..."<br>*(oraz 1 innych odgałęzień)* |
| `[467]` | **""Everything I've done has been for the betterment of this nation! Nothing else.""** | `[465]` **Narrator**: "A few mocking laughs reached my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Player_Romus**: ""I thought I was right, but ackn..."<br>`[472]` **Player_Romus**: ""I love my country more than any..."<br>*(oraz 2 innych odgałęzień)* |
| `[468]` | **""A king without his people is no king.""** | `[465]` **Narrator**: "A few mocking laughs reached my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Player_Romus**: ""I recognize your resolve, and I..."<br>`[487]` **Player_Romus**: ""This Kingdom owes everything to..."<br>*(oraz 1 innych odgałęzień)* |
| `[469]` | **""The responsibility for the mess we find ourselves in rests with the other royal h..."** | `[466]` **Player_Romus**: ""I understand your anger, but it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Player_Romus**: ""Malenyevist conspirators have c..."<br>`[482]` **Player_Romus**: ""Rot has taken place in our gove..."<br>*(oraz 1 innych odgałęzień)* |
| `[470]` | **""I thought I was right, but acknowledge that mistakes may have been made.""** | `[467]` **Player_Romus**: ""Everything I've done has been f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[474]` **Player_Romus**: ""Every decision I've made has be..."<br>`[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>*(oraz 1 innych odgałęzień)* |
| `[471]` | **""It is a shame that the Rizian people have suffered. But I am not to blame.""** | `[467]` **Player_Romus**: ""Everything I've done has been f..." | `(Variable["RiziaDLC.Reform_Path"] == true) == false` | *Brak zmian stanu* | `[474]` **Player_Romus**: ""Every decision I've made has be..."<br>`[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>*(oraz 1 innych odgałęzień)* |
| `[472]` | **""I love my country more than anything! I know you do as well. That's why you are h..."** | `[467]` **Player_Romus**: ""Everything I've done has been f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[474]` **Player_Romus**: ""Every decision I've made has be..."<br>`[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>*(oraz 1 innych odgałęzień)* |
| `[473]` | **""Yes, I've made my fair share of poor decisions. However, let's not overlook the g..."** | `[470]` **Player_Romus**: ""I thought I was right, but ackn..."<br>`[471]` **Player_Romus**: ""It is a shame that the Rizian p..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Player_Romus**: ""I may wear the crown, but we sh..."<br>`[476]` **Player_Romus**: ""I beg you. Make the right choic..."<br>*(oraz 1 innych odgałęzień)* |
| `[474]` | **""Every decision I've made has been with one goal in mind -- you!""** | `[470]` **Player_Romus**: ""I thought I was right, but ackn..."<br>`[471]` **Player_Romus**: ""It is a shame that the Rizian p..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Player_Romus**: ""I may wear the crown, but we sh..."<br>`[476]` **Player_Romus**: ""I beg you. Make the right choic..."<br>*(oraz 1 innych odgałęzień)* |
| `[475]` | **""I am but a fellow patriot much like yourselves!""** | `[470]` **Player_Romus**: ""I thought I was right, but ackn..."<br>`[471]` **Player_Romus**: ""It is a shame that the Rizian p..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Player_Romus**: ""I may wear the crown, but we sh..."<br>`[476]` **Player_Romus**: ""I beg you. Make the right choic..."<br>*(oraz 1 innych odgałęzień)* |
| `[476]` | **""I beg you. Make the right choice and release me. There's so much we can accomplis..."** | `[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>`[474]` **Player_Romus**: ""Every decision I've made has be..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[477]` | **""I may wear the crown, but we share the same Rizian blood -- which means we are th..."** | `[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>`[474]` **Player_Romus**: ""Every decision I've made has be..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[478]` | **""Break this cycle of violence and let us usher in a new era of prosperity for Rizia.""** | `[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>`[474]` **Player_Romus**: ""Every decision I've made has be..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[479]` | **""The fault lies with the system that created this situation.""** | `[466]` **Player_Romus**: ""I understand your anger, but it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Player_Romus**: ""Malenyevist conspirators have c..."<br>`[482]` **Player_Romus**: ""Rot has taken place in our gove..."<br>*(oraz 1 innych odgałęzień)* |
| `[480]` | **""Even the most well-intentioned individuals can end up in the most precarious situ..."** | `[466]` **Player_Romus**: ""I understand your anger, but it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Player_Romus**: ""Malenyevist conspirators have c..."<br>`[482]` **Player_Romus**: ""Rot has taken place in our gove..."<br>*(oraz 1 innych odgałęzień)* |
| `[481]` | **""Malenyevist conspirators have contrived this scenario to weaken us.""** | `[469]` **Player_Romus**: ""The responsibility for the mess..."<br>`[479]` **Player_Romus**: ""The fault lies with the system ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[484]` **Player_Romus**: ""I need your help to bring us to..."<br>`[485]` **Player_Romus**: ""Nevertheless, as your rightful ..."<br>*(oraz 1 innych odgałęzień)* |
| `[482]` | **""Rot has taken place in our governmental institutions.""** | `[469]` **Player_Romus**: ""The responsibility for the mess..."<br>`[479]` **Player_Romus**: ""The fault lies with the system ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[484]` **Player_Romus**: ""I need your help to bring us to..."<br>`[485]` **Player_Romus**: ""Nevertheless, as your rightful ..."<br>*(oraz 1 innych odgałęzień)* |
| `[483]` | **""I've done all I could to stop this from happening.""** | `[469]` **Player_Romus**: ""The responsibility for the mess..."<br>`[479]` **Player_Romus**: ""The fault lies with the system ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[484]` **Player_Romus**: ""I need your help to bring us to..."<br>`[485]` **Player_Romus**: ""Nevertheless, as your rightful ..."<br>*(oraz 1 innych odgałęzień)* |
| `[484]` | **""I need your help to bring us to a better future. Together.""** | `[481]` **Player_Romus**: ""Malenyevist conspirators have c..."<br>`[482]` **Player_Romus**: ""Rot has taken place in our gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[485]` | **""Nevertheless, as your rightful king, I promise that better days will come.""** | `[481]` **Player_Romus**: ""Malenyevist conspirators have c..."<br>`[482]` **Player_Romus**: ""Rot has taken place in our gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[486]` | **""The future of this country is in your hands.""** | `[481]` **Player_Romus**: ""Malenyevist conspirators have c..."<br>`[482]` **Player_Romus**: ""Rot has taken place in our gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[487]` | **""This Kingdom owes everything to you.""** | `[468]` **Player_Romus**: ""A king without his people is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Player_Romus**: ""I live only to serve this natio..."<br>`[491]` **Player_Romus**: ""Yet, violence can never be the ..."<br>*(oraz 1 innych odgałęzień)* |
| `[488]` | **""I recognize your resolve, and I commend it.""** | `[468]` **Player_Romus**: ""A king without his people is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Player_Romus**: ""I live only to serve this natio..."<br>`[491]` **Player_Romus**: ""Yet, violence can never be the ..."<br>*(oraz 1 innych odgałęzień)* |
| `[489]` | **""You, the people, have spoken. And I am listening.""** | `[468]` **Player_Romus**: ""A king without his people is no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Player_Romus**: ""I live only to serve this natio..."<br>`[491]` **Player_Romus**: ""Yet, violence can never be the ..."<br>*(oraz 1 innych odgałęzień)* |
| `[490]` | **""I live only to serve this nation and I will abide by the rules that make it.""** | `[487]` **Player_Romus**: ""This Kingdom owes everything to..."<br>`[488]` **Player_Romus**: ""I recognize your resolve, and I..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Player_Romus**: ""Through unity, we will demonstr..."<br>`[494]` **Player_Romus**: ""I believe in this nation and I ..."<br>*(oraz 1 innych odgałęzień)* |
| `[491]` | **""Yet, violence can never be the answer to our issues. It will only increase our wo..."** | `[487]` **Player_Romus**: ""This Kingdom owes everything to..."<br>`[488]` **Player_Romus**: ""I recognize your resolve, and I..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Player_Romus**: ""Through unity, we will demonstr..."<br>`[494]` **Player_Romus**: ""I believe in this nation and I ..."<br>*(oraz 1 innych odgałęzień)* |
| `[492]` | **""If you wish to claim the palace, then come forth. It's yours.""** | `[487]` **Player_Romus**: ""This Kingdom owes everything to..."<br>`[488]` **Player_Romus**: ""I recognize your resolve, and I..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Player_Romus**: ""Through unity, we will demonstr..."<br>`[494]` **Player_Romus**: ""I believe in this nation and I ..."<br>*(oraz 1 innych odgałęzień)* |
| `[493]` | **""Through unity, we will demonstrate to the world that our resilience and strength ..."** | `[490]` **Player_Romus**: ""I live only to serve this natio..."<br>`[491]` **Player_Romus**: ""Yet, violence can never be the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[494]` | **""I believe in this nation and I believe in you to do the right thing.""** | `[490]` **Player_Romus**: ""I live only to serve this natio..."<br>`[491]` **Player_Romus**: ""Yet, violence can never be the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[495]` | **""What kind of a country we would be if we could not accept change?""** | `[490]` **Player_Romus**: ""I live only to serve this natio..."<br>`[491]` **Player_Romus**: ""Yet, violence can never be the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "But the crowd wasn't listening. ..." |
| `[497]` | **""Very well. I respect your wishes and hereby announce my abdication from the throne.""** | `[496]` **Narrator**: "But the crowd wasn't listening. ..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); ;` | `[509]` **Narrator**: "The crowd fell silent. Each seco..." |
| `[498]` | **""Despite your calls, I refuse to abdicate. For I am the only one who truly grasps ..."** | `[496]` **Narrator**: "But the crowd wasn't listening. ..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Consequence","R_Consequence_Loop"); ;` | `[499]` **Narrator**: "As I uttered my defiance, I watc..." |
| `[500]` | **"Duck and take cover."** | `[499]` **Narrator**: "As I uttered my defiance, I watc..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Titus Gordion");`<br>`StopMusic();`<br>*(+1 skryptów)* | `[506]` **Narrator**: "At that moment, my guards ran ou..."<br>`[983]` **Narrator**: "At that moment, Titus ran out on..."<br>*(oraz 1 innych odgałęzień)* |
| `[501]` | **""Taking my life would mean losing the only king who's willing to listen and speak ..."** | `[499]` **Narrator**: "As I uttered my defiance, I watc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[502]` **Narrator**: "My words fell on deaf ears. I un..." |
| `[513]` | **""Please, heed my words... I will abdicate. All I ask is that you spare both me and..."** | `[499]` **Narrator**: "As I uttered my defiance, I watc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[502]` **Narrator**: "My words fell on deaf ears. I un..." |
| `[514]` | **""If it's riches you desire, they're yours for the taking -- all the gold you could..."** | `[499]` **Narrator**: "As I uttered my defiance, I watc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[502]` **Narrator**: "My words fell on deaf ears. I un..." |
| `[516]` | **""You have emerged victorious. Now it is up to you to make sure it's not in vain.""** | `[510]` **Narrator**: "A single clap resonated through ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Narrator**: "More cheers came from the crowd...." |
| `[517]` | **""Now, let's stop this violence, and, together, bring peace to Rizia!""** | `[510]` **Narrator**: "A single clap resonated through ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Narrator**: "More cheers came from the crowd...." |
| `[518]` | **""Let it be known that I have done all I could for this kingdom.""** | `[510]` **Narrator**: "A single clap resonated through ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Narrator**: "More cheers came from the crowd...." |
| `[612]` | **""As God is my witness, you will pay for what you've done.""** | `[185]` **Narrator**: "One of them stepped forward and ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[184]` **Narrator**: "They closed in on me, delivering..." |
| `[623]` | **""I pray to God that all three of us will make it out of here alive.""** | `[23]` **Lucita Azaro**: ""If it weren't for {RiziaDLCText..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[641]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[624]` | **""We'll rebuild everything. Together.""** | `[18]` **Pabel Adria**: ""They've trampled straight throu..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[637]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[625]` | **""Pabel. I promise I'll do whatever it takes to protect you.""** | `[18]` **Pabel Adria**: ""They've trampled straight throu..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[637]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[626]` | **""No need for a stiff upper lip. I'm scared too.""** | `[18]` **Pabel Adria**: ""They've trampled straight throu..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[637]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[630]` | **""I pray to God that we'll make it out of here alive.""** | `[18]` **Pabel Adria**: ""They've trampled straight throu..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `AddConversant("Bruno");` | `[22]` **Narrator**: "Collective gasps and shouts of d..."<br>`[637]` **Narrator**: "Beside us, Bruno let out a nervo..." |
| `[646]` | **""Don't worry, boy. I'll do whatever it takes to keep you safe.""** | `[645]` **Narrator**: "Beside me, Bruno let out a nervo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Collective gasps and shouts of d..." |
| `[647]` | **""You'll protect me, won't you, Bru?""** | `[645]` **Narrator**: "Beside me, Bruno let out a nervo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Collective gasps and shouts of d..." |
| `[648]` | **"Pat him on the head."** | `[645]` **Narrator**: "Beside me, Bruno let out a nervo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Collective gasps and shouts of d..." |
| `[654]` | **""I need one of the guards to stay behind in case there's an attempt to contact us ..."** | `[653]` **Titus Gordion**: ""Your instructions, sir?""<br>`[1176]` **Sevrio Castellanus**: ""Your instructions, sir?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1186]` **Sevrio Castellanus**: ""Good thinking. I'll stick with ..."<br>`[655]` **Titus Gordion**: ""Good thinking. I'll stick with ..." |
| `[656]` | **""Before we proceed, we need additional reinforcements. Hurry and seek out more gua..."** | `[653]` **Titus Gordion**: ""Your instructions, sir?""<br>`[1176]` **Sevrio Castellanus**: ""Your instructions, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1180]` **Sevrio Castellanus**: ""Right away.""<br>`[657]` **Titus Gordion**: ""Right away."" |
| `[673]` | **""Titus, stay with me. Everyone else, go create a distraction.""** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`<br>`Variable["RiziaDLC.Titus_Arrested"] == false`<br>`(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | *Brak zmian stanu* | `[691]` **Titus Gordion**: ""You heard His Majesty. Move."" |
| `[677]` | **""Titus, can one of your guards create a distraction?""** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..." | `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`<br>`Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`<br>`Variable["RiziaDLC.Titus_Arrested"] == false` | *Brak zmian stanu* | `[690]` **Titus Gordion**: ""Yes, Your Majesty."" |
| `[678]` | **""Titus, I need you to create a distraction.""** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false`<br>`Variable["RiziaDLC.Titus_Arrested"] == false`<br>`(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false` | *Brak zmian stanu* | `[679]` **Titus Gordion**: ""I'll do what I can."" |
| `[682]` | **""Stop talking nonsense! Of course, you'll make it.""** | `[681]` **Titus Gordion**: ""Your Majesty... In case I don't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[699]` **Narrator**: "He turned to Lucita, but couldn'..."<br>`[702]` **Narrator**: "With a final salute, Titus stepp..." |
| `[683]` | **""The honor has been all mine.""** | `[681]` **Titus Gordion**: ""Your Majesty... In case I don't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[699]` **Narrator**: "He turned to Lucita, but couldn'..."<br>`[702]` **Narrator**: "With a final salute, Titus stepp..." |
| `[684]` | **""I told you to create a distraction. What the hell are you waiting for?""** | `[681]` **Titus Gordion**: ""Your Majesty... In case I don't..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[699]` **Narrator**: "He turned to Lucita, but couldn'..."<br>`[702]` **Narrator**: "With a final salute, Titus stepp..." |
| `[688]` | **""Glovurius axa Rizia.""** | `[681]` **Titus Gordion**: ""Your Majesty... In case I don't..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...` | `[699]` **Narrator**: "He turned to Lucita, but couldn'..."<br>`[702]` **Narrator**: "With a final salute, Titus stepp..." |
| `[788]` | **""Thank you for everything, Captain Gordion.""** | `[787]` **Titus Gordion**: ""You should make a run for it, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[794]` **Titus Gordion**: ""It's been an honor, King Romus."" |
| `[789]` | **""Screw that, Titus. You're coming, too.""** | `[787]` **Titus Gordion**: ""You should make a run for it, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[792]` **Narrator**: "He shook his head." |
| `[790]` | **""For king and country.""** | `[787]` **Titus Gordion**: ""You should make a run for it, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[791]` **Titus Gordion**: ""For king and country."" |
| `[795]` | **"Board the helicopter."** | `[400]` **Narrator**: "I started running toward the cho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[803]` **Narrator**: "Just in time, Bruno hopped in an..."<br>`[409]` **Lucita Azaro**: ""R... Romus...""<br>*(oraz 2 innych odgałęzień)* |
| `[812]` | **""Thank you for everything, Captain Gordion.""** | `[811]` **Titus Gordion**: ""You two should make a run for i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[818]` **Titus Gordion**: ""It's been an honor, King Romus."" |
| `[813]` | **""Screw that, Titus. You're coming, too.""** | `[811]` **Titus Gordion**: ""You two should make a run for i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[817]` **Narrator**: "He shook his head." |
| `[814]` | **""For king and country.""** | `[811]` **Titus Gordion**: ""You two should make a run for i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[816]` **Titus Gordion**: ""For king and country."" |
| `[830]` | **""Have fun running the country. I warn you, it's not as easy as it looks.""** | `[510]` **Narrator**: "A single clap resonated through ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[519]` **Narrator**: "More cheers came from the crowd...." |
| `[838]` | **""Come with me. I can't go out there without backup.""** | `[837]` **Titus Gordion**: ""How can we support you, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[841]` **Titus Gordion**: ""We're with you, Your Majesty."" |
| `[839]` | **""Stay here and defend this room with your lives. Is that clear?""** | `[837]` **Titus Gordion**: ""How can we support you, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[840]` **Titus Gordion**: ""As you command, Your Majesty. M..." |
| `[844]` | **"Leave the room."** | `[919]` **Player_Romus**: ""It's too dangerous for you out ..."<br>`[923]` **Player_Romus**: ""Stay here and protect Pabel.""<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`<br>`(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | `RemoveConversant("Lucita Azaro");`<br>`RemoveConversant("Lucita Azaro");` | `[445]` **Narrator**: "Ahead of me, a set of doors led ..." |
| `[845]` | **"Leave the room."** | `[918]` **Player_Romus**: ""Come along, boy. The public wil..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Titus Gordion"); RemoveConversant("Sevr...`<br>`RemoveConversant("Lucita Azaro");`<br>*(+1 skryptów)* | `[585]` **Narrator**: "The moment I stepped out, the gu..." |
| `[873]` | **""Please focus on the task at hand, Titus.""** | `[867]` **Titus Gordion**: ""You possess the strength and wi..."<br>`[872]` **Titus Gordion**: ""'Frail' is but a word, not a re..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[880]` **Narrator**: "A loud commotion drew everyone's..." |
| `[874]` | **""This is neither the time nor the place for flattery!""** | `[872]` **Titus Gordion**: ""'Frail' is but a word, not a re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[880]` **Narrator**: "A loud commotion drew everyone's..." |
| `[875]` | **""Thank you for supporting your king in his darkest hour.""** | `[867]` **Titus Gordion**: ""You possess the strength and wi..."<br>`[872]` **Titus Gordion**: ""'Frail' is but a word, not a re..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[880]` **Narrator**: "A loud commotion drew everyone's..." |
| `[876]` | **""May God grant me the strength to live up to your belief in me.""** | `[867]` **Titus Gordion**: ""You possess the strength and wi..."<br>`[872]` **Titus Gordion**: ""'Frail' is but a word, not a re..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[880]` **Narrator**: "A loud commotion drew everyone's..." |
| `[899]` | **""Shut up and listen to me!""** | `[461]` **Narrator**: "Yells and screams erupted from t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Narrator**: "A few mocking laughs reached my ..." |
| `[912]` | **""If anything happens, protect yourself and {RiziaDLCText.KingsSon}. Don't worry ab..."** | `[31]` **Lucita Azaro**: ""No, you can't! Are you insane? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Narrator**: "I turned to see Titus awaiting m..."<br>`[1142]` **Narrator**: "I turned to see Sevrio, his expe..."<br>*(oraz 1 innych odgałęzień)* |
| `[913]` | **""I'm sorry we didn't get more time together.""** | `[32]` **Pabel Adria**: ""That's insane! They'll arrest y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Narrator**: "I turned to see Titus awaiting m..."<br>`[1142]` **Narrator**: "I turned to see Sevrio, his expe..."<br>*(oraz 1 innych odgałęzień)* |
| `[918]` | **""Come along, boy. The public will have more sympathy for a cute animal.""** | `[917]` **Narrator**: "Bruno tilted his head and looked..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_B...` | `[845]` **Player_Romus_Italic**: "We left the room." |
| `[919]` | **""It's too dangerous for you out there. Stay until I get back.""** | `[917]` **Narrator**: "Bruno tilted his head and looked..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Bruno"); ;` | `[844]` **Player_Romus_Italic**: "My guards and I left the room."<br>`[78]` **Player_Romus_Italic**: "I left the room." |
| `[923]` | **""Stay here and protect Pabel.""** | `[917]` **Narrator**: "Bruno tilted his head and looked..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | `RemoveConversant("Bruno"); ;` | `[844]` **Player_Romus_Italic**: "My guards and I left the room."<br>`[78]` **Player_Romus_Italic**: "I left the room." |
| `[927]` | **""Stay here and protect Lucita.""** | `[917]` **Narrator**: "Bruno tilted his head and looked..." | `Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true`<br>`(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` | `RemoveConversant("Bruno"); ;` | `[844]` **Player_Romus_Italic**: "My guards and I left the room."<br>`[78]` **Player_Romus_Italic**: "I left the room." |
| `[958]` | **""Yes, Titus. I'm afraid I don't have any other option.""** | `[957]` **Narrator**: "I turned to see Titus standing i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[961]` **Titus Gordion**: ""But, sir, the kingdom needs you..." |
| `[959]` | **""Unfortunately, yes. For the first time in my life, I'm out of a job.""** | `[957]` **Narrator**: "I turned to see Titus standing i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[978]` **Titus Gordion**: ""But, sir, our kingdom depends o..." |
| `[960]` | **""Your ears serve you well, Titus.""** | `[957]` **Narrator**: "I turned to see Titus standing i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[979]` **Titus Gordion**: ""But, sir, Rizia's future hinges..." |
| `[962]` | **""Rizia will endure, Titus, with or without a king.""** | `[961]` **Titus Gordion**: ""But, sir, the kingdom needs you..."<br>`[978]` **Titus Gordion**: ""But, sir, our kingdom depends o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[965]` **Titus Gordion**: ""It goes without saying, Your Ma..." |
| `[963]` | **""This is the best course for our people, as much as it pains me to admit it.""** | `[961]` **Titus Gordion**: ""But, sir, the kingdom needs you..."<br>`[978]` **Titus Gordion**: ""But, sir, our kingdom depends o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[965]` **Titus Gordion**: ""It goes without saying, Your Ma..." |
| `[964]` | **""The country will just have to go on without me.""** | `[961]` **Titus Gordion**: ""But, sir, the kingdom needs you..."<br>`[978]` **Titus Gordion**: ""But, sir, our kingdom depends o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[965]` **Titus Gordion**: ""It goes without saying, Your Ma..." |
| `[967]` | **""You've done more than enough, Titus. Now, it's time for a new chapter, for both o..."** | `[966]` **Titus Gordion**: ""I only wish I could have done m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[975]` **Titus Gordion**: ""I trust that the future holds b..." |
| `[968]` | **""Farewell, my friend. May our paths cross again under better circumstances.""** | `[966]` **Titus Gordion**: ""I only wish I could have done m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[973]` **Titus Gordion**: ""May the future be kinder to us ..." |
| `[969]` | **""The failure is mine, not yours. Until we meet again, Captain.""** | `[966]` **Titus Gordion**: ""I only wish I could have done m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[976]` **Titus Gordion**: ""Hopefully sooner than later. Fa..." |
| `[970]` | **""Just leave.""** | `[966]` **Titus Gordion**: ""I only wish I could have done m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[974]` **Narrator**: "A flicker of disappointment brie..." |
| `[977]` | **""Spare me your pity and get out of my sight.""** | `[957]` **Narrator**: "I turned to see Titus standing i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[971]` **Narrator**: "Titus bowed respectfully and too..." |
| `[1081]` | **""Much appreciated, but we haven't lost this fight yet!""** | `[1080]` **Titus Gordion**: ""Whatever happens, Your Majesty,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "We continued reinforcing the doo..." |
| `[1082]` | **""Save the sentiment, Titus. We're not dead yet.""** | `[1080]` **Titus Gordion**: ""Whatever happens, Your Majesty,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "We continued reinforcing the doo..." |
| `[1083]` | **""No, Titus, the honor is mine.""** | `[1080]` **Titus Gordion**: ""Whatever happens, Your Majesty,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "We continued reinforcing the doo..." |
| `[1106]` | **"Listen closely."** | `[1105]` **Narrator**: "Bruno's ears flattened, and he s..."<br>`[1101]` **Narrator**: "Before long, the footsteps stopp..." | `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | *Brak zmian stanu* | `[1108]` **Narrator**: "That's when I heard a loud pierc..." |
| `[1107]` | **"Don't move."** | `[1105]` **Narrator**: "Bruno's ears flattened, and he s..."<br>`[1101]` **Narrator**: "Before long, the footsteps stopp..." | `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false` | *Brak zmian stanu* | `[1109]` **Narrator**: "That's when I heard a loud beep." |
| `[1118]` | **""GET DOWN!""** | `[1116]` **Lucita Azaro**: ""An E4-X7 from DuMont Powder Com..."<br>`[1117]` **Pabel Adria**: ""That can't be good.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | `PlaySoundEffect("Explosion");` | `[128]` **Narrator**: "The door burst open with a deafe..." |
| `[1119]` | **""IT'S THEM!""** | `[1116]` **Lucita Azaro**: ""An E4-X7 from DuMont Powder Com..."<br>`[1117]` **Pabel Adria**: ""That can't be good.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | `PlaySoundEffect("Explosion");` | `[128]` **Narrator**: "The door burst open with a deafe..." |
| `[1120]` | **""RUN!""** | `[1116]` **Lucita Azaro**: ""An E4-X7 from DuMont Powder Com..."<br>`[1117]` **Pabel Adria**: ""That can't be good.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | `PlaySoundEffect("Explosion");` | `[128]` **Narrator**: "The door burst open with a deafe..." |
| `[1143]` | **""Come with me. I can't go out there without backup.""** | `[1142]` **Narrator**: "I turned to see Sevrio, his expe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1146]` **Sevrio Castellanus**: ""We are with you, Your Majesty."" |
| `[1144]` | **""You and the Guardians will stay here and defend this room with your lives. Is tha..."** | `[1142]` **Narrator**: "I turned to see Sevrio, his expe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1145]` **Sevrio Castellanus**: ""As you command, sir. May God be..." |
| `[1167]` | **""Here goes nothing.""** | `[455]` **Narrator**: "I took a deep breath." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[898]` **Titus Gordion**: ""Divus zaitu!""<br>`[1163]` **Sevrio Castellanus**: ""Divus zaitu, Your Majesty. May ..."<br>*(oraz 1 innych odgałęzień)* |
| `[1171]` | **""I fought for the reforms you wanted. If there's anyone you should be angry at, it..."** | `[467]` **Player_Romus**: ""Everything I've done has been f..." | `Variable["RiziaDLC.Reform_Path"] == true` | *Brak zmian stanu* | `[474]` **Player_Romus**: ""Every decision I've made has be..."<br>`[473]` **Player_Romus**: ""Yes, I've made my fair share of..."<br>*(oraz 1 innych odgałęzień)* |
| `[1194]` | **""Sevrio, can you create a distraction?""** | `[590]` **Narrator**: "Shots were fired. We had been seen."<br>`[594]` **Narrator**: "However, considering the number ..." | `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`<br>`Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`<br>`Variable["RiziaDLC.Titus_Arrested"] == false` | *Brak zmian stanu* | `[1195]` **Sevrio Castellanus**: ""It would be my honor, Your Maje..." |
| `[1252]` | **""Halaita.""** | `[1251]` **Sevrio Castellanus**: ""So that I could survive until t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[1254]` **Narrator**: "Sevrio readied his weapon and as..." |
| `[1256]` | **""The eternal bliss of Golconda will be your reward, my good soldier.""** | `[1251]` **Sevrio Castellanus**: ""So that I could survive until t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1254]` **Narrator**: "Sevrio readied his weapon and as..." |
| `[1257]` | **""No. You're coming with me.""** | `[1251]` **Sevrio Castellanus**: ""So that I could survive until t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1258]` **Sevrio Castellanus**: ""Do not try to dissuade me from ..." |
| `[1262]` | **"“Bi mare volu...""** | `[422]` **Pabel Adria**: ""My heart has always belonged to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[1263]` **Narrator**: "He didn't have the strength to r..." |

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
  - -> `[1286]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Ending their reign with...", "Porte Draz..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by Titus and Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "Together with a handful of military personnel, we watched..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Revolutionaries, armed to the teeth with a menacing array of weaponry, were pushing against the palace gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Narrator: "Behind them surged a relentless tide of protestors. Some ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "While no shots had been fired, tension hung heavy in the air, as if the slightest spark would ignite the powder keg of unrest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "With our avenues for retreat dwindling and imminent dange..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's too many of them. We don't stand a chance. I'll address them from the palace balcony -- try to calm them down or at least buy us some time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus_Italic), `[729]` (Narrator), `[733]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Speech Hub]"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't rely on outside help. We have to get to the helipad on our own. It's risky, but it's our only means of escape.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus_Italic), `[729]` (Narrator), `[733]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Helicopter Hub]"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll barricade ourselves here and hold out until help arrives. We have no choice but to wait.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus_Italic), `[729]` (Narrator), `[733]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Barricade Hub]"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria");"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucita squeezed my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_FinalDecision_StayAndFight == true"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Pabel squeezed my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_FinalDecision_StayAndFight == true"*)

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""I can't believe I'm saying this, but I'm scared. There are just too many of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Narrator: "She put a protective hand over her belly."*)

### Węzeł `[18]`
Mówca: **Pabel Adria**
> ""They've trampled straight through the hedge maze. That'll take weeks to replant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Player_Romus: ""We'll rebuild everything. Together.""*)
  - -> `[625]` (*Player_Romus: ""Pabel. I promise I'll do whatever it takes to protect you.""*)
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[626]` (*Player_Romus: ""No need for a stiff upper lip. I'm scared too.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do whatever it takes to protect you. Both of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid you're right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. Everything's going to be fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Collective gasps and shouts of disbelief suddenly erupted from all around me. I turned back to the security monitor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Narrator: "There, in stark black and white, I witnessed the revoluti..."*)

### Węzeł `[23]`
Mówca: **Lucita Azaro**
> ""If it weren't for {RiziaDLCText.KingsSon}, I'd insist we hold the capital at all costs. But Romus... I think this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[19]` (*Player_Romus: ""I'll do whatever it takes to protect you. Both of you.""*)
  - -> `[20]` (*Player_Romus: ""I'm afraid you're right.""*)
  - -> `[21]` (*Player_Romus: ""Don't worry. Everything's going to be fine.""*)

### Węzeł `[24]`
Mówca: **Narrator**
> "He'd stayed by my side even as the revolutionaries closed in on Porte Drazon, drinking glass after glass of wine with me and listening to me reminisce about the days when kings still held power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Pabel Adria: ""They've trampled straight through the hedge maze. That'l..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""No, you can't! Are you insane? They'll arrest you -- or ..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Pabel Adria: ""That's insane! They'll arrest you -- or worse.""*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""No, you can't! Are you insane? They'll arrest you -- or worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[912]` (*Player_Romus: ""If anything happens, protect yourself and {RiziaDLCText...."*)
  - -> `[74]` (*Player_Romus: ""If I don't make it back, know that I will always love you.""*)
  - -> `[75]` (*Player_Romus: ""Remember me well.""*)
  - -> `[77]` (*Player_Romus_Italic: "Kiss her."*)

### Węzeł `[32]`
Mówca: **Pabel Adria**
> ""That's insane! They'll arrest you -- or worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""If I don't make it back, know that I will always love you.""*)
  - -> `[75]` (*Player_Romus: ""Remember me well.""*)
  - -> `[76]` (*Player_Romus_Italic: "Kiss him."*)
  - -> `[913]` (*Player_Romus: ""I'm sorry we didn't get more time together.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucita Azaro: ""I'll try my best to keep up. But don't slow down because..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Pabel Adria: ""I'm with you, Rom. Always.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[39]`
Mówca: **Lucita Azaro**
> ""I'll try my best to keep up. But don't slow down because of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[40]`
Mówca: **Pabel Adria**
> ""I'm with you, Rom. Always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "My guards awaited my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""All of you, come with me. We need every available hand t..."*)
  - -> `[55]` (*Player_Romus: ""One of you remain here in case there's any attempt to co..."*)
  - -> `[94]` (*Player_Romus: ""Before we proceed, we need additional reinforcements. Hu..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "I turned to see my guards, their expectant gazes awaiting my command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""Stay here and defend this room with your lives. Is that ..."*)
  - -> `[56]` (*Player_Romus: ""Come with me. I can't go out there without any guards.""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucita Azaro: ""They'd better arrive soon, or we're finished.""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Pabel Adria: ""Let's hope they arrive soon or we're done for.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""They'd better arrive soon, or we're finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[50]`
Mówca: **Pabel Adria**
> ""Let's hope they arrive soon or we're done for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "My guards turned to me for instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""We need reinforcements. Go round up as many other guards..."*)
  - -> `[52]` (*Player_Romus: ""Stay with us. Grab whatever you can and barricade the do..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay with us. Grab whatever you can and barricade the door.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator), `[993]` (Titus Gordion), `[1268]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[998]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need reinforcements. Go round up as many other guards as you can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator), `[993]` (Titus Gordion), `[1268]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[994]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of you, come with me. We need every available hand to make it through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[653]` (Titus Gordion), `[1176]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "They saluted and fell in step behind me."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of you remain here in case there's any attempt to contact us over the radio.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[1221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come with me. I can't go out there without any guards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "They saluted and fell into step behind me."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and defend this room with your lives. Is that clear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "They gave a resounding "Yes, sir!" and saluted me."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "With a salute, two of my guards rushed out of the room as quickly as they could. In the meantime, we needed to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements = true;"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "They saluted and fell in step behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Follow = true"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "They gave a resounding "Yes, sir!" and saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend = true"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "They saluted and fell into step behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Follow = true"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "One of the guards saluted before attempting to tune into a radio channel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend = true"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "They saluted me and scanned the room for anything they could use to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend = true;"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown = 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""There's too many of them. We don't stand a chance. I'll ..."*)
  - -> `[7]` (*Player_Romus: ""We can't rely on outside help. We have to get to the hel..."*)
  - -> `[8]` (*Player_Romus: ""We'll barricade ourselves here and hold out until help a..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Helicopter = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Helicopter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Dialogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Dialogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Barricade = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Barricade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Follow = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "Leave the room."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Follow = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "Leave the room."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Reinforcements = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus_Italic: "Barricade with a table."*)
  - -> `[82]` (*Player_Romus_Italic: "Barricade with a bookshelf."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus_Italic: "Barricade with a table."*)
  - -> `[82]` (*Player_Romus_Italic: "Barricade with a bookshelf."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I don't make it back, know that I will always love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro), `[32]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember me well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro), `[32]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "Kiss him."]** — Mówca: **Player_Romus_Italic**
> "I kissed him. He had tears in his eyes as I pulled away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "Kiss her."]** — Mówca: **Player_Romus_Italic**
> "I kissed her. She had tears in her eyes as I pulled away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "I left the room."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false` AND `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[919]` (Player_Romus), `[923]` (Player_Romus), `[927]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1148]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Sevr..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "We slipped out of the room as quietly as possible and ascended nearby stairs to the ground floor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator), `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "One of the guards carefully opened the door and peeked ar..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "And then we waited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "I heard the sound of footsteps approaching from the level..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "Barricade with a table."]** — Mówca: **Player_Romus_Italic**
> "I moved the table to block the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[1272]` (Narrator), `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "And then we waited."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "Barricade with a bookshelf."]** — Mówca: **Player_Romus_Italic**
> "I moved the bookshelf to block the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator), `[1272]` (Narrator), `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "And then we waited."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "I heard the sound of footsteps approaching from the level above, gradually drawing closer and closer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Before long, there was a knock on the door. I gripped my ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "I heard the muffled voices of multiple people in the hall..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Identify yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "I heard the muffled voices of multiple people in the hall..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Before long, there was a knock on the door. I gripped my gun firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Who is this?""*)
  - -> `[85]` (*Player_Romus: ""Identify yourself.""*)
  - -> `[87]` (*Player_Romus_Italic: "Do not answer."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "Do not answer."]** — Mówca: **Player_Romus_Italic**
> "I did not answer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "I heard the muffled voices of multiple people in the hall..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Romus_Italic**
> "I opened the door."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[1100]` (Narrator), `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements == true"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "Do not open the door."]** — Mówca: **Player_Romus_Italic**
> "I did not open the door."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[1100]` (Narrator), `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "After a short while, the people on the other side left."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "I heard the muffled voices of multiple people in the hallway. I couldn't make out who it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1097]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "After a short while, the people on the other side left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1024]` (*Narrator: "However, it wasn't long before an influx of footsteps, mo..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "It was the returning sentries bringing along four other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 4;"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "They entered and informed us that the revolutionaries wer..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we proceed, we need additional reinforcements. Hurry and seek out more guards to aid in our defense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "They saluted me and dashed out of the room as fast as pos..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "They saluted me and dashed out of the room as fast as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements = true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Reinforcements = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "We waited, anxious for the return of our reinforcements. ..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "We waited, anxious for the return of our reinforcements. Knowing that armed militants were rampaging through the palace made the minutes feel like hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Narrator: "Before long, we heard the sound of approaching footsteps."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && Riz..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && R..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "It was the returning sentries bringing along four other G..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Default == true && Rizi..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Default == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Default == true && Rizi..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Default == true && Ri..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Default == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "It was the returning sentries bringing along two other Go..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Default == true && RiziaDLC.Religious_WruhecsGuardians_Sal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true  and  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "It was Sevrio, bringing along seven other Wruhec's Guardi..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "My guards returned. They couldn't find anyone."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "It was the returning sentries bringing along two other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 2;"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "They entered and informed us that the revolutionaries wer..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "It was Sevrio, bringing along seven other Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 7;"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 7;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "They entered and informed us that the revolutionaries wer..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "My guards returned. They couldn't find anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "They entered and informed us that the revolutionaries wer..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "They entered and informed us that the revolutionaries were closing in, urging us to prepare for the imminent threat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "It was then I heard an increasing number of footsteps gro..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Reinforcements == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Reinforcements == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Reinforcements == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && Riz..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Reinforcements == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1004]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Titus_Reinforcements == true"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "It was one of the palace cleaners, trying to run away from the militants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "It was then I heard an increasing number of footsteps gro..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "It was then I heard an increasing number of footsteps growing louder by the second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "They were rapidly approaching."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "They were rapidly approaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1077]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "We continued reinforcing the door. Before long, the footsteps stopped right outside our barricade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1062]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Listen closely."]** — Mówca: **Player_Romus_Italic**
> "I listened closely to understand what was going on."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[1065]` (Narrator), `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "That's when I heard a loud piercing beep."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "Don't move."]** — Mówca: **Player_Romus_Italic**
> "I remained still, waiting to see what would happen."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[1065]` (Narrator), `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "That's when I heard a loud beep."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "That's when I heard a loud piercing beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""IT'S THEM!""*)
  - -> `[124]` (*Player_Romus: ""GET DOWN!""*)
  - -> `[126]` (*Player_Romus: ""RUN!""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""GET DOWN!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1067]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""IT'S THEM!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1067]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""RUN!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1067]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "That's when I heard a loud beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1072]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[128]`
Mówca: **Narrator**
> "The door burst open with a deafening explosion, knocking me to the ground as an intense sound and flash overwhelmed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 2;"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "I could feel the sharp glass and splinters piercing my sk..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "With a deafening explosion, the door burst open, knocking me to the ground as an intense sound and flash overwhelmed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "I could feel the sharp glass and splinters piercing my sk..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "A barrage of gunfire suddenly erupted from the hall -- the smoke from the explosion obscuring the gunmen -- and I took off running."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus_Italic: "Fire your gun blindly at the door."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[133]` (*Player_Romus_Italic: "Take cover."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "Take cover."]** — Mówca: **Player_Romus_Italic**
> "I took cover behind the table."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus_Italic: "Shield Lucita with your body."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus_Italic: "Shield Pabel with your body."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
**[WYBÓR GRACZA: "Shield Pabel with your body."]** — Mówca: **Player_Romus_Italic**
> "I shielded Pabel with my body."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "I cried out in agony as a sharp searing pain spread throu..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "Shield Lucita with your body."]** — Mówca: **Player_Romus_Italic**
> "I shielded Lucita with my body."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "I cried out in agony as a sharp searing pain spread throu..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "Fire your gun blindly at the door."]** — Mówca: **Player_Romus_Italic**
> "Unable to see the assailants, I fired my gun blindly toward the direction of the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Cries of pain told me I'd managed to land a hit."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "I cried out in agony as a sharp searing pain spread through my thigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1031]` (*Narrator: "I'd been shot."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Cries of pain told me I'd managed to land a hit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1030]` (*Narrator: "When the smoke cleared, I saw I had taken down two of them."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "As did Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 4;"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "As did Lucita."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "As did Pabel."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 4;"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "As did Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 4;"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1032]` (*Narrator: "Before I could react, a mob of masked militants wielding ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1032]` (*Narrator: "Before I could react, a mob of masked militants wielding ..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Before I knew it, a mob of masked militants wielding auto..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "An eerie silence settled in, and a slow, creeping terror began to consume my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "A barrage of gunfire suddenly erupted from the hall -- th..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "I could feel the sharp glass and splinters piercing my skin as I crawled on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1025]` (*Narrator: "As the smoke cleared, and my hearing slowly returned, I s..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Before I knew it, a mob of masked militants wielding automatic rifles stormed the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "They aimed their rifles in my direction the moment I was ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count <= 0"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count <= 0)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1033]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pab..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "My remaining guards threw down their weapons."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "All of my guards were dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "They aimed their rifles in my direction the moment I was identified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Glancing over at Lucita, I was relieved to see her unharmed. At least for the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count <= 0"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Glancing over at Lucita, I was relieved to see her unharm..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Glancing over at Pabel, I was relieved to see him unharme..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count <= 0"*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Glancing over at Pabel, I was relieved to see him unharmed. At least for the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count <= 0"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "My remaining guards threw down their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "That's when I realized that I was the only one still holding a gun. The militants were yelling at me to lower it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus_Italic: "Drop your weapon."*)
  - -> `[175]` (*Player_Romus_Italic: "Shoot them."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "Drop your weapon."]** — Mówca: **Player_Romus_Italic**
> "I dropped my weapon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "One of them stepped forward and kicked the gun away with ..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "Shoot them."]** — Mówca: **Player_Romus_Italic**
> "I raised the barrel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_GunEmpty = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_GunEmpty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 2;"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_GunEmpty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_GunEmpty == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_GunEmpty == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_GunEmpty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_GunEmpty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_GunEmpty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_GunEmpty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "All I heard was a click. The magazine was empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CoupGunshot");"*)

### Węzeł `[181]`
Mówca: **Narrator**
> "I targeted the man in the lead, shooting him in the head. In response, all rifles redirected their aim towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CoupGunshot");"*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. I beg you. Don't hurt me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "They closed in on me, delivering a blow to my gut before ..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’ll give you anything you want. Name your price. Just let us go.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "They closed in on me, delivering a blow to my gut before ..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "They closed in on me, delivering a blow to my gut before binding my wrists with handcuffs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "One of them stepped forward and kicked the gun away with his boot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""Please. I beg you. Don't hurt me.""*)
  - -> `[183]` (*Player_Romus: "“I’ll give you anything you want. Name your price. Just l..."*)
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will pay for what you've done.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "They closed in on me, delivering a blow to my gut before ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Prison_Revolution_Surrounded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Prison_Revolution_Surrounded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Death_Revolution_Surrounded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Death_Revolution_Surrounded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[190]`
**[WYBÓR GRACZA: "Load your gun."]** — Mówca: **Player_Romus_Italic**
> "I loaded a magazine into my gun and pulled back the slide, preparing for the worst."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[584]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown = 4;"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Stress", "R_Stress_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[192]`
Mówca: **Narrator**
> "It was Sevrio, accompanied by six additional Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 6;"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 6;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Sevrio Castellanus: ""They're closing in, Your Majesty. We've got to act fast.""*)

### Węzeł `[194]`
Mówca: **Sevrio Castellanus**
> ""They're closing in, Your Majesty. We've got to act fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1222]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "One of the guards saluted before attempting to tune into ..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "Our small group advanced a few meters at a time, using co..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "One of the guards carefully opened the door and peeked around the corner. Seeing the coast was clear, he motioned for us to follow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Narrator: "As I stepped out, a pair of ornate double doors at the fa..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "Hurry to the garden exit."]** — Mówca: **Player_Romus_Italic**
> "We hurried toward the garden exit."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "Approach cautiously."]** — Mówca: **Player_Romus_Italic**
> "Instead of charging toward the exit at full speed, we took a cautious approach."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "Our small group advanced a few meters at a time, using columns and other obstructions as cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Narrator: "At one point, a restless mob surged past from a hallway, ..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "I couldn't believe that I was fleeing my own palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Narrator: "As we passed another hall, a large mob on the far end cau..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "It was the most direct route but would leave us exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus_Italic: "Hurry to the garden exit."*)
  - -> `[199]` (*Player_Romus_Italic: "Approach cautiously."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I couldn't believe that I was fleeing my own palace."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "We attempted to cross swiftly, but Lucita couldn't keep u..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "We attempted to cross swiftly, but Lucita couldn't keep up, so we slowed our pace to accommodate her despite her protestations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Narrator: "At one point, a restless mob surged past from a hallway, ..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "I cursed under my breath upon seeing three armed men. Fortunately, their backs were turned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "Instruct your guards to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I instructed my guards to create a distraction so that we might increase the chances of escape."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1` AND `(Variable["RiziaDLC.Titus_Arrested"] == false) == false` AND `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 0; RiziaDLCIso..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "Try to sneak by without being seen."]** — Mówca: **Player_Romus_Italic**
> "We tried to sneak by without being seen."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 1"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count > 1)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus_Italic: "Instruct your guards to create a distraction."*)
  - -> `[215]` (*Player_Romus_Italic: "Instruct one of your guards to create a distraction."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus_Italic: "Instruct your remaining guard to create a distraction."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "Instruct your remaining guard to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I instructed my remaining guard to create a distraction so that we might increase the chances of escape."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false` AND `(Variable["RiziaDLC.Titus_Arrested"] == false) == false` AND `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "Instruct one of your guards to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I instructed one of my guards to create a distraction so that we might increase the chances of escape."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1` AND `(Variable["RiziaDLC.Titus_Arrested"] == false) == false` AND `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "Run by them as fast as you can."]** — Mówca: **Player_Romus_Italic**
> "We ran by them as fast as we could."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 0; RiziaDLCIso..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count = 0; RiziaDLCIsolated.Ending_Revolution_TitusDead = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 0;
Variable["RiziaDLCIsolated.Ending_Revolution_TitusDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "In a flash, gunfire erupted. The frenzy of the firefight ..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "In a flash, gunfire erupted. The frenzy of the firefight ..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "In a flash, gunfire erupted. The frenzy of the firefight ..."*)

### Węzeł `[220]`
Mówca: **Narrator**
> "As I thought, the guards' equipment made too much noise and we were immediately spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "As I thought, the guards' equipment made too much noise a..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "As luck would have it, we somehow passed without attracti..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Narrator: "However, considering the number of guards with us, I knew..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[210]` (*Player_Romus_Italic: "Try to sneak by without being seen."*)
  - -> `[216]` (*Player_Romus_Italic: "Run by them as fast as you can."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "As luck would have it, we somehow passed without attracting their attention. Before long, we reached the doors leading to the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "I did a quick headcount to see if we'd lost anyone."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "I did a quick headcount to see if we'd lost anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;"*)

### Węzeł `[229]`
Mówca: **Narrator**
> "In a flash, gunfire erupted. The frenzy of the firefight granted us a chance to escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount = 3;"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "Thankfully, Lucita was uninjured."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Thankfully, Pabel was uninjured."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[237]`
Mówca: **Narrator**
> "Thankfully, Lucita was uninjured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Thankfully, Pabel was uninjured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "And the guards that were left were sufficient to get us t..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 2"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 2"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 2)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "However, only two guards remained, which wasn't very reas..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count == 1)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "However, with only one guard remaining, our chances of su..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "However, there were no guards left. Our situation was bleak."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "And the guards that were left were sufficient to get us the rest of the way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1206]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_Revolution_SevrioDead == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "However, only two guards remained, which wasn't very reassuring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1203]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_Revolution_SevrioDead == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[250]`
Mówca: **Narrator**
> "However, with only one guard remaining, our chances of success were greatly diminished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[251]`
Mówca: **Narrator**
> "However, there were no guards left. Our situation was bleak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Peeking through the cracked door, I could spot the helicopter from my vantage point. However, I also noticed three armed men kneeling beside it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "I squinted, struggling for a moment to discern their acti..."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "But before I could decipher what was going on, a deafening blast rang out. The helicopter blew up, along with our hopes of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "I froze in place, and my vision started to blur."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_EscapeCountdown >= 2)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "I could see the helicopter from where I was,  but I also ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_EscapeCountdown >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_EscapeCountdown >= 1)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Peeking through the cracked door, I could spot the helico..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_EscapeCountdown >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "I could make out the helicopter from my vantage point, bu..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "I could see the helicopter from where I was,  but I also saw three armed men running towards it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "I could make out the helicopter from my vantage point, but I also spotted three armed men making their way toward it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "But before I could decipher what was going on, a deafenin..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "I did a quick headcount to see if we'd lost anyone."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] = Variable["RiziaDLCIsolated.Revolution_EscapeCountdown"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "Before long, we reached the doors leading to the garden."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "I squinted, struggling for a moment to discern their actions, and soon realized they appeared to be planting a bomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Narrator: "We had to take action now."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "We had time. We could make it if we were quick enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""PRESS FORWARD! FIRE AT WILL!""*)
  - -> `[276]` (*Player_Romus_Italic: "Aim and fire your weapon."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "It would be almost impossible to reach the vehicle before..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "We had time. We could make it if we were quick enough."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "It would be almost impossible to reach the vehicle before them, especially with Lucita in her current state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""PRESS FORWARD! FIRE AT WILL!""*)
  - -> `[276]` (*Player_Romus_Italic: "Aim and fire your weapon."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "I froze in place, and my vision started to blur."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "I could barely make out the men rushing to surround us, t..."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "I could barely make out the men rushing to surround us, their rifles aimed at our heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "The harsh reality of my situation became painfully clear."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "The harsh reality of my situation became painfully clear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""PRESS FORWARD! FIRE AT WILL!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Narrator), `[271]` (Narrator), `[613]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "Aim and fire your weapon."]** — Mówca: **Player_Romus_Italic**
> "Without delay, I focused my aim and discharged my firearm."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Narrator), `[271]` (Narrator), `[613]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Pr..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "The shot struck the man planting the bomb in the back of ..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "I missed my shot."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "The shot struck the man planting the bomb in the back of the head. He crumpled to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount = 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || R..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 3;"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 2;"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "What followed was a blur in my memory."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "What followed was a blur in my memory."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "What followed was a blur in my memory."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count > 0)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "I missed my shot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || R..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 2;"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count > 0)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "What followed was a blur in my memory."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "What followed was a blur in my memory."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] = Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "What followed was a blur in my memory."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. All three militants were still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)

### Węzeł `[302]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. All of the militants were dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[303]`
Mówca: **Narrator**
> "What followed was a blur in my memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "When I came to my senses, I looked up. All three militant..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "When I came to my senses, I looked up. Two of the militan..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "When I came to my senses, I looked up. Only one of the mi..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_HelicopterEnemyCount >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_HelicopterEnemyCount"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "When I came to my senses, I looked up. All of the militan..."*)

### Węzeł `[313]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. Two of the militants were still standing, and my gun's magazine was now empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Narrator: "I froze."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "When I came to my senses, I looked up. Only one of the militants was still standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "He immediately threw down his rifle and kneeled on the gr..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "He immediately threw down his rifle and kneeled on the ground, begging for his life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player_Romus_Italic: "Shoot him."*)
  - -> `[328]` (*Player_Romus_Italic: "Spare him."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[319]`
Mówca: **Narrator**
> "But then, much to my relief, I noticed one of my guards on the ground, playing dead. He gave me a slight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "The moment the militants approached, he stood and opened ..."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "The moment the militants approached, he stood and opened fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || R..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "By some miracle, he managed to kill both of them."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "He managed to kill one of them before a hail of machine g..."*)

### Węzeł `[324]`
Mówca: **Narrator**
> "By some miracle, he managed to kill both of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[325]`
Mówca: **Narrator**
> "He managed to kill one of them before a hail of machine gun bullets tore through his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I never forgot his face."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "I never forgot his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[327]`
**[WYBÓR GRACZA: "Shoot him."]** — Mówca: **Player_Romus_Italic**
> "I took aim and shot him dead."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[328]`
**[WYBÓR GRACZA: "Spare him."]** — Mówca: **Player_Romus_Italic**
> "After a moment's hesitation, I decided to leave him alive."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Surrounded Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Surrounded Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Surrounded Hub"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Surrounded Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Surrounded Hub"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Surrounded Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Surrounded Hub"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Surrounded Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Surrounded Hub"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Survived Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "We had won. There was nothing in between us and the helicopter. But at what cost?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Survived Hub"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Survived Hub"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Survived Hub"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1037]` (*Narrator: "I shot at our assailants until I realized I wasn't firing..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Surrounded Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Surrounded Hub"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || R..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "By some miracle, they managed to kill all three men."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "I watched them die one by one."*)

### Węzeł `[346]`
Mówca: **Narrator**
> "By some miracle, they managed to kill all three men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[347]`
Mówca: **Narrator**
> "I watched them die one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Surrounded Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Surrounded Hub"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Survived Hub"*)

### Węzeł `[350]`
Mówca: **Narrator**
> "But as I diverted my attention, he lunged forward and tried to stab me with his knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "But just as I turned away from him, he lunged at Lucita w..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "But just as I turned away from him, he lunged at Pabel wi..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "But as I diverted my attention, he lunged forward and tri..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "But just as I turned away from him, he lunged at Pabel with his knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)

### Węzeł `[358]`
Mówca: **Narrator**
> "But just as I turned away from him, he lunged at Lucita with his knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "Fortunately, Titus quickly recognized his intentions and ..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[365]`
Mówca: **Narrator**
> "I tried to stop him, but it was too late. My wife screamed in agony as her attacker sunk his knife into her chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Narrator: "With lightning speed, Lucita managed to draw her own knif..."*)

### Węzeł `[366]`
Mówca: **Narrator**
> "Fortunately, Titus quickly recognized his intentions and promptly shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Narrator: "I let out a huge sigh of relief."*)

### Węzeł `[367]`
Mówca: **Narrator**
> "Blinded by rage, I strangled the assailant until he died."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[368]`
Mówca: **Narrator**
> "Sevrio and I tried to stop him, but we were too late. My wife screamed in agony as the assailant sunk his knife into her chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Narrator: "With lightning speed, Lucita managed to draw her own knif..."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "The guard immediately shot the attacker dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution = true;"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_InjuredInRevolution = true;"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_InjuredInRevolution = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_InjuredInRevolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "We had won. There was nothing in between us and the helic..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pab..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "We had won. There was nothing between us and the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Narrator: "But the clamor of the revolutionary mob was growing louder."*)

### Węzeł `[382]`
Mówca: **Narrator**
> "I let out a huge sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Survived Hub"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Survived Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "Survived Hub"*)

### Węzeł `[385]`
Mówca: **Narrator**
> "I tore off a piece of my shirt and wrapped it around Lucita's wound. She was bleeding profusely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1040]` (*Narrator: "I turned my gaze to Lucita and her injury."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1041]` (*Narrator: "I turned my gaze to Pabel and his injury."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "Fueled by adrenaline, I found the strength to carry my wife in my arms and hurried toward the chopper as quickly as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus_Italic: "Board the helicopter."*)

### Węzeł `[390]`
Mówca: **Narrator**
> "I tore off a piece of my shirt and wrapped it around Pabel's wound. He was bleeding profusely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)

### Węzeł `[391]`
Mówca: **Narrator**
> "Fueled by adrenaline, I found the strength to carry my lover in my arms and hurried toward the chopper as quickly as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus_Italic: "Board the helicopter."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "I grabbed Lucita by the waist to support her, and we hurried toward the chopper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus_Italic: "Board the helicopter."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "I grabbed Lucita by the waist to support her, and we hurr..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "I grabbed Pabel by the hand and we hurried toward the cho..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "I started running toward the chopper."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "I grabbed Pabel by the hand and we hurried toward the chopper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus_Italic: "Board the helicopter."*)

### Węzeł `[400]`
Mówca: **Narrator**
> "I started running toward the chopper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Player_Romus_Italic: "Board the helicopter."*)

### Węzeł `[401]`
**[WYBÓR GRACZA: "Board the helicopter."]** — Mówca: **Player_Romus_Italic**
> "We boarded the helicopter as the pilot started the engine."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Narrator), `[391]` (Narrator), `[392]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[402]`
Mówca: **Narrator**
> "With our avenues for retreat dwindling and imminent danger looming ever closer, our only hope lay in the helicopter in the palace gardens where a skilled pilot sat at the ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true)"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucita Azaro: ""R... Romus...""*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Pabel Adria: ""R... Romus...""*)

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""R... Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""Sshh. Don't waste your energy, my love.""*)
  - -> `[415]` (*Player_Romus: ""It's okay. It's over now. We're going to be fine. Just h..."*)
  - -> `[416]` (*Player_Romus: ""We are almost out of here. I promise.""*)

### Węzeł `[410]`
Mówca: **Pabel Adria**
> ""R... Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""Sshh. Don't waste your energy, my love.""*)
  - -> `[415]` (*Player_Romus: ""It's okay. It's over now. We're going to be fine. Just h..."*)
  - -> `[416]` (*Player_Romus: ""We are almost out of here. I promise.""*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Lucita Azaro: ""Lis... Listen to me...""*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Pabel Adria: ""Listen... Listen to me...""*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sshh. Don't waste your energy, my love.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Lucita Azaro), `[410]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's okay. It's over now. We're going to be fine. Just hang on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Lucita Azaro), `[410]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are almost out of here. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Lucita Azaro), `[410]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[417]`
Mówca: **Lucita Azaro**
> ""Lis... Listen to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Lucita Azaro: ""If it comes down to choosing between me and our child......"*)

### Węzeł `[418]`
Mówca: **Lucita Azaro**
> ""If it comes down to choosing between me and our child... please, put his life first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Lucita Azaro: ""Please...""*)

### Węzeł `[419]`
Mówca: **Lucita Azaro**
> ""Please...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player_Romus: ""I love you so much.""*)
  - -> `[441]` (*Player_Romus: ""Don't leave me. I need you.""*)
  - -> `[442]` (*Player_Romus: "“You’ll be fine. Just hold on a little longer.""*)

### Węzeł `[420]`
Mówca: **Pabel Adria**
> ""Listen... Listen to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Pabel Adria: ""I just wanted to say that...""*)

### Węzeł `[421]`
Mówca: **Pabel Adria**
> ""I just wanted to say that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Pabel Adria: ""My heart has always belonged to you. I love you.""*)

### Węzeł `[422]`
Mówca: **Pabel Adria**
> ""My heart has always belonged to you. I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player_Romus: ""I love you so much.""*)
  - -> `[441]` (*Player_Romus: ""Don't leave me. I need you.""*)
  - -> `[442]` (*Player_Romus: "“You’ll be fine. Just hold on a little longer.""*)
  - -> `[1262]` (*Player_Romus: "“Bi mare volu...""*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Lucita Azaro: ""I can't believe we made it.""*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Pabel Adria: ""It's hard to believe that we made it.""*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "We began rising over the palace turrets. I took a look be..."*)

### Węzeł `[429]`
Mówca: **Lucita Azaro**
> ""I can't believe we made it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Lucita Azaro: ""That was magnificent, Romus. My heart's still pounding.""*)

### Węzeł `[430]`
Mówca: **Pabel Adria**
> ""It's hard to believe that we made it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Pabel Adria: ""I'm at a loss for words...""*)

### Węzeł `[431]`
Mówca: **Lucita Azaro**
> ""That was magnificent, Romus. My heart's still pounding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucita Azaro: ""Keep up that kind of bravery, and the capital is ours fo..."*)

### Węzeł `[432]`
Mówca: **Pabel Adria**
> ""I'm at a loss for words...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Pabel Adria: ""You're more than a great king, Rom. You're a great man.""*)

### Węzeł `[433]`
Mówca: **Lucita Azaro**
> ""Keep up that kind of bravery, and the capital is ours for the retaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lucita Azaro: ""I love you. Now let's get the hell out of here.""*)

### Węzeł `[434]`
Mówca: **Pabel Adria**
> ""You're more than a great king, Rom. You're a great man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Pabel Adria: ""I love you.""*)

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""I love you. Now let's get the hell out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Narrator: "We kissed passionately as the helicopter blades whirred t..."*)

### Węzeł `[436]`
Mówca: **Pabel Adria**
> ""I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Narrator: "We kissed passionately as the helicopter blades whirred t..."*)

### Węzeł `[437]`
Mówca: **Narrator**
> "We kissed passionately as the helicopter blades whirred to life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "We began rising over the palace turrets. I took a look be..."*)

### Węzeł `[438]`
Mówca: **Narrator**
> "We began rising over the palace turrets. I took a look below me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revo..."*)

### Węzeł `[439]`
Mówca: **Narrator**
> "I ripped off another piece of my shirt to stop the bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "We began rising over the palace turrets. I took a look be..."*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you so much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Lucita Azaro), `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Narrator: "I ripped off another piece of my shirt to stop the bleeding."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't leave me. I need you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Lucita Azaro), `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Narrator: "I ripped off another piece of my shirt to stop the bleeding."*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You’ll be fine. Just hold on a little longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Lucita Azaro), `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Narrator: "I ripped off another piece of my shirt to stop the bleeding."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "Palas Rezna, my home, was on fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Survived_Revolution = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Survived_Revolution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[445]`
Mówca: **Narrator**
> "Ahead of me, a set of doors led to a long stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Narrator: "Five flights later, I emerged into the upper-level corrid..."*)

### Węzeł `[446]`
Mówca: **Narrator**
> "Five flights later, I emerged into the upper-level corridor, still untouched by the armed assailants. The balcony was in the audience chamber at the far end of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[932]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)

### Węzeł `[447]`
Mówca: **Narrator**
> "And that's when it hit me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""Like father like son... 'Frail.' Am I destined to bear t..."*)
  - -> `[448]` (*Player_Romus: ""I understand you now, Father. Perhaps I've grasped the d..."*)
  - -> `[450]` (*Player_Romus: ""You should have never been the King.""*)
  - -> `[451]` (*Player_Romus: ""I should have never been the King.""*)

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand you now, Father. Perhaps I've grasped the depths of disgrace and shame a little too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like father like son... 'Frail.' Am I destined to bear the same name?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should have never been the King.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "Unsurprisingly, his portrait didn't reply in return."*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should have never been the King.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true"*)

### Węzeł `[452]`
Mówca: **Narrator**
> "Unsurprisingly, his portrait didn't reply in return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Narrator: "The distant sounds of unrest from outside snapped me back..."*)

### Węzeł `[453]`
Mówca: **Narrator**
> "The distant sounds of unrest from outside snapped me back to the present."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "It wasn't long before I reached the doors to the audience..."*)

### Węzeł `[454]`
Mówca: **Narrator**
> "It wasn't long before I reached the doors to the audience chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Narrator: "I hurried to the nearest window and glanced outside. From..."*)

### Węzeł `[455]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player_Romus: ""If I die, so be it.""*)
  - -> `[458]` (*Player_Romus: ""Come on, Romus. You can do this.""*)
  - -> `[1167]` (*Player_Romus: ""Here goes nothing.""*)
  - -> `[1164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[455]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I die, so be it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[455]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Romus. You can do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[455]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[459]`
**[WYBÓR GRACZA: "Open the balcony doors."]** — Mówca: **Player_Romus_Italic**
> "I opened the balcony doors."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] == false) == false` AND `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false` AND `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[950]` (Narrator), `[1163]` (Sevrio Castellanus), `[898]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[955]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Sevr..."*)

### Węzeł `[460]`
Mówca: **Narrator**
> "I gazed out into the Palace grounds. Just like during my coronation, they were packed with huge crowds of people -- except now, instead of praising my name, they were calling for my downfall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[943]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)

### Węzeł `[461]`
Mówca: **Narrator**
> "Yells and screams erupted from the crowd. I had certainly captured their attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Player_Romus: ""Porte Drazon. Hear me!""*)
  - -> `[464]` (*Player_Romus: ""My dearest subjects!""*)
  - -> `[463]` (*Player_Romus: ""My fellow Rizians!""*)
  - -> `[899]` (*Player_Romus: ""Shut up and listen to me!""*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Porte Drazon. Hear me!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "A few mocking laughs reached my ears. Despite this, I pre..."*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow Rizians!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "A few mocking laughs reached my ears. Despite this, I pre..."*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My dearest subjects!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "A few mocking laughs reached my ears. Despite this, I pre..."*)

### Węzeł `[465]`
Mówca: **Narrator**
> "A few mocking laughs reached my ears. Despite this, I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""Everything I've done has been for the betterment of this..."*)
  - -> `[466]` (*Player_Romus: ""I understand your anger, but it's misplaced.""*)
  - -> `[468]` (*Player_Romus: ""A king without his people is no king.""*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your anger, but it's misplaced.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player_Romus: ""The fault lies with the system that created this situati..."*)
  - -> `[469]` (*Player_Romus: ""The responsibility for the mess we find ourselves in res..."*)
  - -> `[480]` (*Player_Romus: ""Even the most well-intentioned individuals can end up in..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything I've done has been for the betterment of this nation! Nothing else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[470]` (*Player_Romus: ""I thought I was right, but acknowledge that mistakes may..."*)
  - -> `[472]` (*Player_Romus: ""I love my country more than anything! I know you do as w..."*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A king without his people is no king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[465]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Player_Romus: ""I recognize your resolve, and I commend it.""*)
  - -> `[487]` (*Player_Romus: ""This Kingdom owes everything to you.""*)
  - -> `[489]` (*Player_Romus: ""You, the people, have spoken. And I am listening.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The responsibility for the mess we find ourselves in rests with the other royal houses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Malenyevist conspirators have contrived this scenario to..."*)
  - -> `[482]` (*Player_Romus: ""Rot has taken place in our governmental institutions.""*)
  - -> `[483]` (*Player_Romus: ""I've done all I could to stop this from happening.""*)

### Węzeł `[470]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought I was right, but acknowledge that mistakes may have been made.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[467]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""Every decision I've made has been with one goal in mind ..."*)
  - -> `[473]` (*Player_Romus: ""Yes, I've made my fair share of poor decisions. However,..."*)
  - -> `[475]` (*Player_Romus: ""I am but a fellow patriot much like yourselves!""*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a shame that the Rizian people have suffered. But I am not to blame.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[467]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""Every decision I've made has been with one goal in mind ..."*)
  - -> `[473]` (*Player_Romus: ""Yes, I've made my fair share of poor decisions. However,..."*)
  - -> `[475]` (*Player_Romus: ""I am but a fellow patriot much like yourselves!""*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love my country more than anything! I know you do as well. That's why you are here!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[467]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""Every decision I've made has been with one goal in mind ..."*)
  - -> `[473]` (*Player_Romus: ""Yes, I've made my fair share of poor decisions. However,..."*)
  - -> `[475]` (*Player_Romus: ""I am but a fellow patriot much like yourselves!""*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I've made my fair share of poor decisions. However, let's not overlook the good ones as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Player_Romus), `[471]` (Player_Romus), `[472]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Player_Romus: ""I may wear the crown, but we share the same Rizian blood..."*)
  - -> `[476]` (*Player_Romus: ""I beg you. Make the right choice and release me. There's..."*)
  - -> `[478]` (*Player_Romus: ""Break this cycle of violence and let us usher in a new e..."*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every decision I've made has been with one goal in mind -- you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Player_Romus), `[471]` (Player_Romus), `[472]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Player_Romus: ""I may wear the crown, but we share the same Rizian blood..."*)
  - -> `[476]` (*Player_Romus: ""I beg you. Make the right choice and release me. There's..."*)
  - -> `[478]` (*Player_Romus: ""Break this cycle of violence and let us usher in a new e..."*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am but a fellow patriot much like yourselves!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Player_Romus), `[471]` (Player_Romus), `[472]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Player_Romus: ""I may wear the crown, but we share the same Rizian blood..."*)
  - -> `[476]` (*Player_Romus: ""I beg you. Make the right choice and release me. There's..."*)
  - -> `[478]` (*Player_Romus: ""Break this cycle of violence and let us usher in a new e..."*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I beg you. Make the right choice and release me. There's so much we can accomplish together, side by side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Player_Romus), `[474]` (Player_Romus), `[475]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may wear the crown, but we share the same Rizian blood -- which means we are the same! I trust you to make the right call.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Player_Romus), `[474]` (Player_Romus), `[475]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Break this cycle of violence and let us usher in a new era of prosperity for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Player_Romus), `[474]` (Player_Romus), `[475]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fault lies with the system that created this situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Malenyevist conspirators have contrived this scenario to..."*)
  - -> `[482]` (*Player_Romus: ""Rot has taken place in our governmental institutions.""*)
  - -> `[483]` (*Player_Romus: ""I've done all I could to stop this from happening.""*)

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even the most well-intentioned individuals can end up in the most precarious situations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Malenyevist conspirators have contrived this scenario to..."*)
  - -> `[482]` (*Player_Romus: ""Rot has taken place in our governmental institutions.""*)
  - -> `[483]` (*Player_Romus: ""I've done all I could to stop this from happening.""*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevist conspirators have contrived this scenario to weaken us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[469]` (Player_Romus), `[479]` (Player_Romus), `[480]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player_Romus: ""I need your help to bring us to a better future. Together.""*)
  - -> `[485]` (*Player_Romus: ""Nevertheless, as your rightful king, I promise that bett..."*)
  - -> `[486]` (*Player_Romus: ""The future of this country is in your hands.""*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rot has taken place in our governmental institutions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[469]` (Player_Romus), `[479]` (Player_Romus), `[480]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player_Romus: ""I need your help to bring us to a better future. Together.""*)
  - -> `[485]` (*Player_Romus: ""Nevertheless, as your rightful king, I promise that bett..."*)
  - -> `[486]` (*Player_Romus: ""The future of this country is in your hands.""*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've done all I could to stop this from happening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[469]` (Player_Romus), `[479]` (Player_Romus), `[480]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player_Romus: ""I need your help to bring us to a better future. Together.""*)
  - -> `[485]` (*Player_Romus: ""Nevertheless, as your rightful king, I promise that bett..."*)
  - -> `[486]` (*Player_Romus: ""The future of this country is in your hands.""*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your help to bring us to a better future. Together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Player_Romus), `[482]` (Player_Romus), `[483]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nevertheless, as your rightful king, I promise that better days will come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Player_Romus), `[482]` (Player_Romus), `[483]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The future of this country is in your hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Player_Romus), `[482]` (Player_Romus), `[483]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This Kingdom owes everything to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Player_Romus: ""I live only to serve this nation and I will abide by the..."*)
  - -> `[491]` (*Player_Romus: ""Yet, violence can never be the answer to our issues. It ..."*)
  - -> `[492]` (*Player_Romus: ""If you wish to claim the palace, then come forth. It's y..."*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I recognize your resolve, and I commend it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Player_Romus: ""I live only to serve this nation and I will abide by the..."*)
  - -> `[491]` (*Player_Romus: ""Yet, violence can never be the answer to our issues. It ..."*)
  - -> `[492]` (*Player_Romus: ""If you wish to claim the palace, then come forth. It's y..."*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You, the people, have spoken. And I am listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Player_Romus: ""I live only to serve this nation and I will abide by the..."*)
  - -> `[491]` (*Player_Romus: ""Yet, violence can never be the answer to our issues. It ..."*)
  - -> `[492]` (*Player_Romus: ""If you wish to claim the palace, then come forth. It's y..."*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I live only to serve this nation and I will abide by the rules that make it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Player_Romus), `[488]` (Player_Romus), `[489]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus: ""Through unity, we will demonstrate to the world that our..."*)
  - -> `[494]` (*Player_Romus: ""I believe in this nation and I believe in you to do the ..."*)
  - -> `[495]` (*Player_Romus: ""What kind of a country we would be if we could not accep..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet, violence can never be the answer to our issues. It will only increase our woes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Player_Romus), `[488]` (Player_Romus), `[489]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus: ""Through unity, we will demonstrate to the world that our..."*)
  - -> `[494]` (*Player_Romus: ""I believe in this nation and I believe in you to do the ..."*)
  - -> `[495]` (*Player_Romus: ""What kind of a country we would be if we could not accep..."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you wish to claim the palace, then come forth. It's yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Player_Romus), `[488]` (Player_Romus), `[489]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus: ""Through unity, we will demonstrate to the world that our..."*)
  - -> `[494]` (*Player_Romus: ""I believe in this nation and I believe in you to do the ..."*)
  - -> `[495]` (*Player_Romus: ""What kind of a country we would be if we could not accep..."*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Through unity, we will demonstrate to the world that our resilience and strength will never be broken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Player_Romus), `[491]` (Player_Romus), `[492]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe in this nation and I believe in you to do the right thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Player_Romus), `[491]` (Player_Romus), `[492]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of a country we would be if we could not accept change?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Player_Romus), `[491]` (Player_Romus), `[492]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "But the crowd wasn't listening. They simply chanted "Abdi..."*)

### Węzeł `[496]`
Mówca: **Narrator**
> "But the crowd wasn't listening. They simply chanted "Abdicate, Abdicate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Player_Romus: ""Very well. I respect your wishes and hereby announce my ..."*)
  - -> `[498]` (*Player_Romus: ""Despite your calls, I refuse to abdicate. For I am the o..."*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I respect your wishes and hereby announce my abdication from the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[496]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Kingdom Dissolves Hub]"*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite your calls, I refuse to abdicate. For I am the only one who truly grasps your needs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[496]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "Jump to: [Revolution Speech Death Hub]"*)

### Węzeł `[499]`
Mówca: **Narrator**
> "As I uttered my defiance, I watched as rifles trained on me from within the crowd. The air filled with the ominous chant of "Death to the King!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player_Romus: ""Please, heed my words... I will abdicate. All I ask is t..."*)
  - -> `[514]` (*Player_Romus: ""If it's riches you desire, they're yours for the taking ..."*)
  - -> `[501]` (*Player_Romus: ""Taking my life would mean losing the only king who's wil..."*)
  - -> `[500]` (*Player_Romus_Italic: "Duck and take cover."*)

### Węzeł `[500]`
**[WYBÓR GRACZA: "Duck and take cover."]** — Mówca: **Player_Romus_Italic**
> "I ducked and took cover."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend == true"*)

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Taking my life would mean losing the only king who's willing to listen and speak to the common man, despite his noble status.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "My words fell on deaf ears. I understood then and there w..."*)

### Węzeł `[502]`
Mówca: **Narrator**
> "My words fell on deaf ears. I understood then and there what was about to happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend == true"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend == true"*)
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Defend == true)"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Defend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "At that moment, my guards ran out onto the balcony, attem..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Defend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Defend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[980]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[506]`
Mówca: **Narrator**
> "At that moment, my guards ran out onto the balcony, attempting to rush me away, but they were too late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[507]`
Mówca: **Narrator**
> "Glancing down, I couldn't believe the sight of so much blood pooling beneath me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1046]` (*Narrator: "Memories suddenly flooded my mind -- memories of Vina, my..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Death_Revolution_Speech = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Death_Revolution_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[509]`
Mówca: **Narrator**
> "The crowd fell silent. Each second felt heavier than the last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "A single clap resonated through the silence,  igniting a ..."*)

### Węzeł `[510]`
Mówca: **Narrator**
> "A single clap resonated through the silence,  igniting a chain reaction of applause throughout the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player_Romus: ""Now, let's stop this violence, and, together, bring peac..."*)
  - -> `[516]` (*Player_Romus: ""You have emerged victorious. Now it is up to you to make..."*)
  - -> `[518]` (*Player_Romus: ""Let it be known that I have done all I could for this ki..."*)
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "That's when I realized that I was the only one still hold..."*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, heed my words... I will abdicate. All I ask is that you spare both me and my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "My words fell on deaf ears. I understood then and there w..."*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it's riches you desire, they're yours for the taking -- all the gold you could ever want. But, please, spare the Royal Family from harm.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "My words fell on deaf ears. I understood then and there w..."*)

### Węzeł `[515]`
Mówca: **Narrator**
> "Gunshots rang out, and the next thing I knew, I was lying on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[984]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have emerged victorious. Now it is up to you to make sure it's not in vain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Narrator: "More cheers came from the crowd. They were chanting "Rizi..."*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, let's stop this violence, and, together, bring peace to Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Narrator: "More cheers came from the crowd. They were chanting "Rizi..."*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let it be known that I have done all I could for this kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Narrator: "More cheers came from the crowd. They were chanting "Rizi..."*)

### Węzeł `[519]`
Mówca: **Narrator**
> "More cheers came from the crowd. They were chanting "Rizia! Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[947]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)

### Węzeł `[520]`
Mówca: **Narrator**
> "And then they started fading away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Death_R..."*)

### Węzeł `[521]`
Mówca: **Narrator**
> "They had gotten what they came for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_KingdomDissolves_Revolution = true; RiziaDLC.SkipToEpilogue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_KingdomDissolves_Revolution"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Kingdom Dissolves Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Speech Death Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Kingdom Dissolves Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "Revolution Kingdom Dissolves Hub"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Speech Death Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "Revolution Speech Death Hub"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Narrator: "As I uttered my defiance, I watched as rifles trained on ..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Narrator: "The crowd fell silent. Each second felt heavier than the ..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucita squeezed my hand."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Pabel squeezed my hand."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Speech Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Dialogue = true"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Helicopter Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Helicopter = true"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Revolution Barricade Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Barricade = true"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Speech Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "Revolution Speech Hub"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Helicopter Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "Revolution Helicopter Hub"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Revolution Barricade Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "Revolution Barricade Hub"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Lucita Azaro: ""No! Romus! Don't do it!""*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Pabel Adria: ""Romus, wait! Don't!""*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_GunEmpty == true"*)

### Węzeł `[551]`
Mówca: **Lucita Azaro**
> ""No! Romus! Don't do it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_GunEmpty == true"*)

### Węzeł `[552]`
Mówca: **Pabel Adria**
> ""Romus, wait! Don't!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_GunEmpty == true"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Lucita Azaro: ""No! Romus! Let him go!""*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Pabel Adria: ""No! Romus! Let him go!""*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Narrator: "My consciousness slowly faded."*)

### Węzeł `[559]`
Mówca: **Lucita Azaro**
> ""No! Romus! Let him go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Narrator: "My consciousness slowly faded."*)

### Węzeł `[560]`
Mówca: **Pabel Adria**
> ""No! Romus! Let him go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Narrator: "My consciousness slowly faded."*)

### Węzeł `[561]`
Mówca: **Narrator**
> "My consciousness slowly faded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Prison_..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithLucita = true"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Revolution_Survived_WithPabel = true"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Survive..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithPabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Survive..."*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Revolution_Survived_WithLucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Survive..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CoupGunshot");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CoupGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Death_R..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CoupGunshot");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CoupGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Death_R..."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `StopMusic();`
- **Efekt skryptowy (`userScript`):** `StopMusic();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "All I heard was a click. The magazine was empty."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `StopMusic();`
- **Efekt skryptowy (`userScript`):** `StopMusic();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "I targeted the man in the lead, shooting him in the head...."*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Explosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "The door burst open with a deafening explosion, knocking ..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Explosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "With a deafening explosion, the door burst open, knocking..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `StopMusic();`
- **Efekt skryptowy (`userScript`):** `StopMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_KingdomDissolves_Revolution = true; Riz..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `StopMusic();`
- **Efekt skryptowy (`userScript`):** `StopMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MultipleGunshots");"*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MultipleGunshots");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MultipleGunshots");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Narrator: "Gunshots rang out, and the next thing I knew, I was lying..."*)

### Węzeł `[580]`
Mówca: **Narrator**
> "Together with a handful of military personnel, we watched live images of the unfolding chaos on the security monitors before us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Revolutionaries, armed to the teeth with a menacing array..."*)

### Węzeł `[581]`
Mówca: **Narrator**
> "Behind them surged a relentless tide of protestors. Some were calling out for justice; others were demanding my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "While no shots had been fired, tension hung heavy in the ..."*)

### Węzeł `[582]`
Mówca: **Narrator**
> "She put a protective hand over her belly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucita Azaro: ""If it weren't for {RiziaDLCText.KingsSon}, I'd insist we..."*)

### Węzeł `[583]`
Mówca: **Narrator**
> "There, in stark black and white, I witnessed the revolutionaries breach the palace gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Narrator: "They were inside."*)

### Węzeł `[584]`
Mówca: **Narrator**
> "They were inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)

### Węzeł `[585]`
Mówca: **Narrator**
> "The moment I stepped out, the guards began barricading the room from the inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[586]`
Mówca: **Narrator**
> "Before I knew it, I found myself standing beneath the portrait of my father, Valero the Frail, as if drawn to him involuntarily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[587]`
Mówca: **Narrator**
> "I hurried to the nearest window and glanced outside. From there, I could see the crowd steadily expanding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "I took a deep breath."*)

### Węzeł `[588]`
Mówca: **Narrator**
> "Before long, we heard the sound of approaching footsteps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown -= 1;"*)

### Węzeł `[589]`
Mówca: **Narrator**
> "As we passed another hall, a large mob on the far end caught my eye. Their cries of alarm resonated through the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Narrator: "Shots were fired. We had been seen."*)

### Węzeł `[590]`
Mówca: **Narrator**
> "Shots were fired. We had been seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[216]` (*Player_Romus_Italic: "Run by them as fast as you can."*)

### Węzeł `[591]`
Mówca: **Narrator**
> "At one point, a restless mob surged past from a hallway, but we remained motionless and evaded detection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Narrator: "Once they'd moved on, we resumed our slow progress. Howev..."*)

### Węzeł `[592]`
Mówca: **Narrator**
> "Once they'd moved on, we resumed our slow progress. However, the murmur of voices from around a nearby corner brought us to an abrupt halt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Narrator: "As I strained to identify the source of the sound, the po..."*)

### Węzeł `[593]`
Mówca: **Narrator**
> "As I strained to identify the source of the sound, the polished surface of a nearby decorative vase caught my eye. Its gleaming reflection gave me the answer I was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "I cursed under my breath upon seeing three armed men. For..."*)

### Węzeł `[594]`
Mówca: **Narrator**
> "However, considering the number of guards with us, I knew it would be a challenge to sneak past them undetected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[210]` (*Player_Romus_Italic: "Try to sneak by without being seen."*)
  - -> `[216]` (*Player_Romus_Italic: "Run by them as fast as you can."*)

### Węzeł `[595]`
Mówca: **Narrator**
> "Before long, we reached the doors leading to the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "I did a quick headcount to see if we'd lost anyone."*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "The guards that were left were more than enough to make i..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 2"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 2"*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 2)"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Narrator: "Only two guards remained, which wasn't very reassuring."*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count == 1)"*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Narrator: "Only one guard remained, which greatly reduced our chance..."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Narrator: "There were no guards left. The situation was bleak."*)

### Węzeł `[605]`
Mówca: **Narrator**
> "The guards that were left were more than enough to make it the rest of the way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[606]`
Mówca: **Narrator**
> "Only two guards remained, which wasn't very reassuring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[607]`
Mówca: **Narrator**
> "Only one guard remained, which greatly reduced our chances of success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[608]`
Mówca: **Narrator**
> "There were no guards left. The situation was bleak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""As God is my witness, you will pay for what you've done.""*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""You will pay for what you've done.""*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As God is my witness, you will pay for what you've done.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "They closed in on me, delivering a blow to my gut before ..."*)

### Węzeł `[613]`
Mówca: **Narrator**
> "We had to take action now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""PRESS FORWARD! FIRE AT WILL!""*)
  - -> `[276]` (*Player_Romus_Italic: "Aim and fire your weapon."*)

### Węzeł `[614]`
Mówca: **Narrator**
> "I froze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[908]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[618]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by Sevrio Castellanus and his loyal second-in-command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "Together with a handful of military personnel, we watched..."*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[904]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Player_Romus: ""I pray to God that all three of us will make it out of h..."*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray to God that all three of us will make it out of here alive.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll rebuild everything. Together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel. I promise I'll do whatever it takes to protect you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need for a stiff upper lip. I'm scared too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Player_Romus: ""I pray to God that we'll make it out of here alive.""*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray to God that we'll make it out of here alive.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Pr..."*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus_Italic: "Load your gun."*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1133]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[637]`
Mówca: **Narrator**
> "Beside us, Bruno let out a nervous whimper. Pabel patted his head reassuringly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1128]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[641]`
Mówca: **Narrator**
> "Beside us, Bruno let out a nervous whimper. Lucita patted his head reassuringly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1134]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[645]`
Mówca: **Narrator**
> "Beside me, Bruno let out a nervous whimper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Player_Romus: ""Don't worry, boy. I'll do whatever it takes to keep you ..."*)
  - -> `[647]` (*Player_Romus: ""You'll protect me, won't you, Bru?""*)
  - -> `[648]` (*Player_Romus_Italic: "Pat him on the head."*)

### Węzeł `[646]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, boy. I'll do whatever it takes to keep you safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[645]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll protect me, won't you, Bru?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[645]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[648]`
**[WYBÓR GRACZA: "Pat him on the head."]** — Mówca: **Player_Romus_Italic**
> "I patted his head reassuringly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[645]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Collective gasps and shouts of disbelief suddenly erupted..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "Titus gave a nod of confirmation."*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[652]`
Mówca: **Narrator**
> "Titus gave a nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Titus Gordion: ""Your instructions, sir?""*)

### Węzeł `[653]`
Mówca: **Titus Gordion**
> ""Your instructions, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Player_Romus: ""I need one of the guards to stay behind in case there's ..."*)
  - -> `[54]` (*Player_Romus: ""All of you, come with me. We need every available hand t..."*)
  - -> `[656]` (*Player_Romus: ""Before we proceed, we need additional reinforcements. Hu..."*)

### Węzeł `[654]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need one of the guards to stay behind in case there's an attempt to contact us over the radio.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[653]` (Titus Gordion), `[1176]` (Sevrio Castellanus), `[194]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[655]`
Mówca: **Titus Gordion**
> ""Good thinking. I'll stick with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[656]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before we proceed, we need additional reinforcements. Hurry and seek out more guards to assist in our defense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[653]` (Titus Gordion), `[1176]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[657]`
Mówca: **Titus Gordion**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "Titus saluted me and dashed out of the room as fast as po..."*)

### Węzeł `[658]`
Mówca: **Narrator**
> "Titus saluted me and dashed out of the room as fast as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements = true"*)

### Węzeł `[660]`
Mówca: **Narrator**
> "Titus appeared in the doorway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && Riz..."*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Narrator: "Titus appeared in the doorway."*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && Riz..."*)
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && R..."*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Titus Gordion: ""I've brought four additional Golden Guardsmen. You shoul..."*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Titus Gordion: ""I've brought two additional Golden Guardsmen. We'll cove..."*)

### Węzeł `[665]`
Mówca: **Titus Gordion**
> ""I've brought four additional Golden Guardsmen. You should be well protected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 4;"*)

### Węzeł `[666]`
Mówca: **Titus Gordion**
> ""I've brought two additional Golden Guardsmen. We'll cover you as best we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 2;"*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Titus Gordion: ""We have to move fast, though. The enemy is closing in.""*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Titus Gordion: ""We have to move fast, though. The enemy is closing in.""*)

### Węzeł `[669]`
Mówca: **Titus Gordion**
> ""We have to move fast, though. The enemy is closing in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1222]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 1"*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 1"*)

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, stay with me. Everyone else, go create a distraction.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1` AND `Variable["RiziaDLC.Titus_Arrested"] == false` AND `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Titus Gordion: ""You heard His Majesty. Move.""*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 1"*)
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count > 1)"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[673]` (*Player_Romus: ""Titus, stay with me. Everyone else, go create a distract..."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Player_Romus: ""Titus, I need you to create a distraction.""*)

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, can one of your guards create a distraction?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false` AND `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1` AND `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Titus Gordion: ""Yes, Your Majesty.""*)

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus, I need you to create a distraction.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1) == false` AND `Variable["RiziaDLC.Titus_Arrested"] == false` AND `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator), `[208]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Titus Gordion: ""I'll do what I can.""*)

### Węzeł `[679]`
Mówca: **Titus Gordion**
> ""I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Narrator: "My bodyguard swallowed."*)

### Węzeł `[680]`
Mówca: **Narrator**
> "My bodyguard swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Titus Gordion: ""Your Majesty... In case I don't make it, it's been an ho..."*)

### Węzeł `[681]`
Mówca: **Titus Gordion**
> ""Your Majesty... In case I don't make it, it's been an honor serving you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Player_Romus: ""Stop talking nonsense! Of course, you'll make it.""*)
  - -> `[683]` (*Player_Romus: ""The honor has been all mine.""*)
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop talking nonsense! Of course, you'll make it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[683]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The honor has been all mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told you to create a distraction. What the hell are you waiting for?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[681]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Player_Romus: ""I told you to create a distraction. What the hell are yo..."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Player_Romus: ""Glovurius axa Rizia.""*)

### Węzeł `[688]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[681]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[690]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[691]`
Mówca: **Titus Gordion**
> ""You heard His Majesty. Move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 1;"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count = 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Narrator: "Titus motioned to his remaining guardsmen. They stepped o..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Narrator: "Titus motioned to one of his guardsmen, who stepped out t..."*)

### Węzeł `[694]`
Mówca: **Narrator**
> "Titus motioned to his remaining guardsmen. They stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1198]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sevrio Castellanus"); RiziaDLCIsolated...."*)

### Węzeł `[695]`
Mówca: **Narrator**
> "Titus motioned to one of his guardsmen, who stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "In a flash, gunfire erupted. The frenzy of the firefight ..."*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Narrator: "He turned to Lucita, but couldn't quite look her in the eye."*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Narrator: "With a final salute, Titus stepped out to face the mob."*)

### Węzeł `[699]`
Mówca: **Narrator**
> "He turned to Lucita, but couldn't quite look her in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Titus Gordion: ""Keep him safe, milady.""*)

### Węzeł `[700]`
Mówca: **Titus Gordion**
> ""Keep him safe, milady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Lucita Azaro: ""I will, Captain.""*)

### Węzeł `[701]`
Mówca: **Lucita Azaro**
> ""I will, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Narrator: "With a final salute, Titus stepped out to face the mob."*)

### Węzeł `[702]`
Mówca: **Narrator**
> "With a final salute, Titus stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 0; RiziaDLCIso..."*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == true)"*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 0; RiziaDLCIso..."*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count = 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "In a flash, gunfire erupted. The frenzy of the firefight ..."*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Narrator: "Bruno was still trotting along beside me."*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)

### Węzeł `[710]`
Mówca: **Narrator**
> "Bruno was still trotting along beside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 3"*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count == 1)"*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Narrator: "However, Titus was the only one left to guard us."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Narrator: "But Titus -- poor Titus -- hadn't made it."*)

### Węzeł `[717]`
Mówca: **Narrator**
> "However, Titus was the only one left to guard us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1203]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_Revolution_SevrioDead == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[718]`
Mówca: **Narrator**
> "But Titus -- poor Titus -- hadn't made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == true)"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count == 1"*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count == 1)"*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Narrator: "Titus was the only one guarding me. I hoped he would be e..."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Narrator: "It seemed like Titus hadn't made it. The situation was be..."*)

### Węzeł `[726]`
Mówca: **Narrator**
> "Titus was the only one guarding me. I hoped he would be enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[727]`
Mówca: **Narrator**
> "It seemed like Titus hadn't made it. The situation was becoming increasingly bleak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 1"*)

### Węzeł `[729]`
Mówca: **Narrator**
> "Titus handed me a gun. I stared at it, remembering how badly things had gone in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown = 4;"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Narrator: "Titus handed me a gun. I stared at it, remembering how ba..."*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[733]`
Mówca: **Narrator**
> "One of my guards thrust a gun into my hands. I stared at it, remembering how badly things had gone in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown = 4;"*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[736]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Narrator: "From behind me, I heard Lucita fire her own weapon. The s..."*)

### Węzeł `[736]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)

### Węzeł `[737]`
Mówca: **Narrator**
> "From behind me, I heard Lucita fire her own weapon. The shot struck the man planting the bomb in the back of the head, and he collapsed to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_HelicopterEnemyCount -= 1;"*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Narrator: "I looked at the ground and saw Titus lying flat on his ba..."*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[741]`
Mówca: **Narrator**
> "I looked at the ground and saw Titus lying flat on his back, seemingly dead. One of his eyes quickly closed, then opened again -- a wink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "The moment the militants approached, he stood and opened ..."*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[743]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "I tried to stop him, but it was too late. My wife screame..."*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Narrator: "I tried to stop him, but it was too late. Pabel screamed ..."*)

### Węzeł `[745]`
Mówca: **Narrator**
> "I tried to stop him, but it was too late. Pabel screamed in agony as the attacker plunged the knife into his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[749]`
Mówca: **Narrator**
> "A guard and I tried to stop him, but we were too late. Pabel screamed in agony as the assailant sunk his knife into his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "The guard immediately shot the attacker dead."*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Blinded by rage, I strangled the assailant until he died."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Narrator: "Blinded by rage, I immediately shot the assailant dead."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Narrator: "Bruno leaped at the assailant, snarling."*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)

### Węzeł `[756]`
Mówca: **Narrator**
> "Bruno leaped at the assailant, snarling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)

### Węzeł `[757]`
Mówca: **Narrator**
> "Blinded by rage, I immediately shot the assailant dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)"*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[763]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Narrator: "He staggered backward, and without a moment's hesitation,..."*)

### Węzeł `[763]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[764]`
Mówca: **Narrator**
> "He staggered backward, and without a moment's hesitation, Titus shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[765]`
Mówca: **Narrator**
> "He staggered backward, and without a moment's hesitation, Sevrio shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Narrator: "Without a moment's hesitation, Titus shot him dead."*)

### Węzeł `[768]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count >= 1"*)
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)"*)

### Węzeł `[770]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[772]`
Mówca: **Narrator**
> "Without a moment's hesitation, Titus shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[773]`
Mówca: **Narrator**
> "Without a moment's hesitation, my guard shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[774]`
Mówca: **Narrator**
> "With lightning speed, Lucita managed to draw her own knife from its holster and slit the assailant's throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true || RiziaDLCIsolated.Revolution_Guards_Count > 0 || RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pab..."*)
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_P..."*)

### Węzeł `[776]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true || RiziaDLCIsolated.Revolution_Guards_Count > 0 || RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0  or  Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "We had won. There was nothing between us and the helicopter."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true || RiziaDLCIsolated.Revolution_Guards_Count > 0 || RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0  or  Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Narrator: "I had won. There was nothing between me and the helicopter."*)

### Węzeł `[778]`
Mówca: **Narrator**
> "I had won. There was nothing between me and the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Narrator: "But the clamor of the revolutionary mob was growing louder."*)

### Węzeł `[779]`
Mówca: **Narrator**
> "But the clamor of the revolutionary mob was growing louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)

### Węzeł `[780]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)
  - -> `[782]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count > 0)"*)

### Węzeł `[781]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[782]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[783]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[785]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[784]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Narrator: "Titus looked at me with solemn eyes."*)

### Węzeł `[785]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[786]`
Mówca: **Narrator**
> "Titus looked at me with solemn eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Titus Gordion: ""You should make a run for it, Your Majesty. I'll make su..."*)

### Węzeł `[787]`
Mówca: **Titus Gordion**
> ""You should make a run for it, Your Majesty. I'll make sure you're covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Player_Romus: ""Thank you for everything, Captain Gordion.""*)
  - -> `[789]` (*Player_Romus: ""Screw that, Titus. You're coming, too.""*)
  - -> `[790]` (*Player_Romus: ""For king and country.""*)

### Węzeł `[788]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for everything, Captain Gordion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[787]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Titus Gordion: ""It's been an honor, King Romus.""*)

### Węzeł `[789]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw that, Titus. You're coming, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[787]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Narrator: "He shook his head."*)

### Węzeł `[790]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For king and country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[787]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]` (*Titus Gordion: ""For king and country.""*)

### Węzeł `[791]`
Mówca: **Titus Gordion**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1084]` (*Narrator: "Titus saluted then readied his weapon, assuming a defensi..."*)

### Węzeł `[792]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Titus Gordion: ""Good luck out there, King Romus.""*)

### Węzeł `[793]`
Mówca: **Titus Gordion**
> ""Good luck out there, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1084]` (*Narrator: "Titus saluted then readied his weapon, assuming a defensi..."*)

### Węzeł `[794]`
Mówca: **Titus Gordion**
> ""It's been an honor, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1084]` (*Narrator: "Titus saluted then readied his weapon, assuming a defensi..."*)

### Węzeł `[795]`
**[WYBÓR GRACZA: "Board the helicopter."]** — Mówca: **Player_Romus_Italic**
> "I boarded the helicopter as the pilot started the engine."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[797]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "Just in time, Bruno hopped in and lay down at our feet."*)

### Węzeł `[798]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[799]`
Mówca: **Narrator**
> "Just in time, Bruno hopped in and lay down at our feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[802]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[801]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Narrator: "Just in time, Bruno hopped in and lay down at my feet."*)

### Węzeł `[802]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[803]`
Mówca: **Narrator**
> "Just in time, Bruno hopped in and lay down at my feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[804]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count > 0"*)
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Count > 0)"*)

### Węzeł `[805]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[806]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Count > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Narrator: "Titus looked at me with solemn eyes."*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[810]`
Mówca: **Narrator**
> "Titus looked at me with solemn eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Titus Gordion: ""You two should make a run for it, Your Majesty. I'll mak..."*)

### Węzeł `[811]`
Mówca: **Titus Gordion**
> ""You two should make a run for it, Your Majesty. I'll make sure you're covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Player_Romus: ""Thank you for everything, Captain Gordion.""*)
  - -> `[813]` (*Player_Romus: ""Screw that, Titus. You're coming, too.""*)
  - -> `[814]` (*Player_Romus: ""For king and country.""*)

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for everything, Captain Gordion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Titus Gordion: ""It's been an honor, King Romus.""*)

### Węzeł `[813]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw that, Titus. You're coming, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Narrator: "He shook his head."*)

### Węzeł `[814]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For king and country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Titus Gordion: ""For king and country.""*)

### Węzeł `[815]`
Mówca: **Titus Gordion**
> ""Good luck out there, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1038]` (*Narrator: "Titus saluted, then readied his weapon and assumed a defe..."*)

### Węzeł `[816]`
Mówca: **Titus Gordion**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1038]` (*Narrator: "Titus saluted, then readied his weapon and assumed a defe..."*)

### Węzeł `[817]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Titus Gordion: ""Good luck out there, King Romus.""*)

### Węzeł `[818]`
Mówca: **Titus Gordion**
> ""It's been an honor, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1038]` (*Narrator: "Titus saluted, then readied his weapon and assumed a defe..."*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC..."*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.Pabel_InjuredInRevolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true  or  Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revo..."*)
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Re..."*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revolution_Guards_Count > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Narrator: "The revolutionaries were streaming into the gardens as Ti..."*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false && RiziaDLCIsolated.Revolution_Guards_Count > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "Palas Rezna, my home, was on fire."*)

### Węzeł `[825]`
Mówca: **Narrator**
> "The revolutionaries were streaming into the gardens as Titus shot at them again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Narrator: "And Palas Rezna -- my home -- was on fire."*)

### Węzeł `[826]`
Mówca: **Narrator**
> "And Palas Rezna -- my home -- was on fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1060]` (*Narrator: "The life I once knew was gone."*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Player_Romus: ""Have fun running the country. I warn you, it's not as ea..."*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[830]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have fun running the country. I warn you, it's not as easy as it looks.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Narrator: "More cheers came from the crowd. They were chanting "Rizi..."*)

### Węzeł `[831]`
Mówca: **Narrator**
> "As I stepped out, a pair of ornate double doors at the far end of the hall caught my eye..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "The exit leading to the garden."*)

### Węzeł `[832]`
Mówca: **Narrator**
> "The exit leading to the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "It was the most direct route but would leave us exposed."*)

### Węzeł `[833]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Narrator: "I turned to see Titus awaiting my command."*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[836]`
Mówca: **Narrator**
> "I turned to see Titus awaiting my command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Titus Gordion: ""How can we support you, sir?""*)

### Węzeł `[837]`
Mówca: **Titus Gordion**
> ""How can we support you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Player_Romus: ""Stay here and defend this room with your lives. Is that ..."*)
  - -> `[838]` (*Player_Romus: ""Come with me. I can't go out there without backup.""*)

### Węzeł `[838]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come with me. I can't go out there without backup.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[837]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Titus Gordion: ""We're with you, Your Majesty.""*)

### Węzeł `[839]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and defend this room with your lives. Is that clear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[837]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Titus Gordion: ""As you command, Your Majesty. May God be with you.""*)

### Węzeł `[840]`
Mówca: **Titus Gordion**
> ""As you command, Your Majesty. May God be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Defend = true"*)

### Węzeł `[841]`
Mówca: **Titus Gordion**
> ""We're with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow = true"*)

### Węzeł `[842]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[844]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "My guards and I left the room."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true` AND `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[919]` (Player_Romus), `[923]` (Player_Romus), `[927]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[845]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Romus_Italic**
> "We left the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[918]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1150]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[846]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)
  - -> `[848]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == tr..."*)

### Węzeł `[847]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[848]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Narrator: "Ahead of me, a set of doors led to a long stairwell."*)

### Węzeł `[849]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[851]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[850]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Narrator: "With his weapon drawn, Titus led the way, escorting me to..."*)

### Węzeł `[851]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[852]`
Mówca: **Narrator**
> "Weapons drawn, my guards led the way, escorting me to a nearby stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Narrator: "Five flights later, we emerged into the upper-level corri..."*)

### Węzeł `[853]`
Mówca: **Narrator**
> "With his weapon drawn, Titus led the way, escorting me to a nearby stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Narrator: "Five flights later, we emerged into the upper-level corri..."*)

### Węzeł `[854]`
Mówca: **Narrator**
> "Five flights later, we emerged into the upper-level corridor, still untouched by the armed assailants. The balcony was in the audience chamber at the far end of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[937]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)

### Węzeł `[855]`
Mówca: **Narrator**
> "Once my men confirmed the coast was clear, we hurried along. As we made our way down the hall, portraits of former rulers lining the walls caught my eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "Before I knew it, I found myself standing beneath the por..."*)

### Węzeł `[856]`
Mówca: **Narrator**
> "My escort formed a protective circle around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Narrator: "And that's when it hit me."*)

### Węzeł `[857]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)
  - -> `[859]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == tr..."*)

### Węzeł `[858]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]` (*Narrator: "My escort formed a protective circle around me."*)

### Węzeł `[859]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Narrator: "And that's when it hit me."*)

### Węzeł `[860]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[862]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[861]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Titus Gordion: ""Your Majesty, your strength surpasses that of any title.""*)

### Węzeł `[862]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "Unsurprisingly, his portrait didn't reply in return."*)

### Węzeł `[863]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[864]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Titus Gordion: ""Your Majesty, there's nothing to be ashamed of.""*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "Unsurprisingly, his portrait didn't reply in return."*)

### Węzeł `[866]`
Mówca: **Titus Gordion**
> ""Your Majesty, your strength surpasses that of any title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]` (*Titus Gordion: ""'Frail' is but a word, not a reflection of your indomita..."*)

### Węzeł `[867]`
Mówca: **Titus Gordion**
> ""You possess the strength and wisdom to lead us forward with honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Player_Romus: ""Thank you for supporting your king in his darkest hour.""*)
  - -> `[877]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[873]` (*Player_Romus: ""Please focus on the task at hand, Titus.""*)

### Węzeł `[868]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true"*)
  - -> `[870]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true)"*)

### Węzeł `[869]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Titus Gordion: ""Sire, your reign has been marked by resilience and coura..."*)

### Węzeł `[870]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Defend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "Unsurprisingly, his portrait didn't reply in return."*)

### Węzeł `[871]`
Mówca: **Titus Gordion**
> ""Sire, your reign has been marked by resilience and courage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]` (*Titus Gordion: ""You are the rightful king, and we stand with you.""*)

### Węzeł `[872]`
Mówca: **Titus Gordion**
> ""'Frail' is but a word, not a reflection of your indomitable spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Player_Romus: ""Thank you for supporting your king in his darkest hour.""*)
  - -> `[874]` (*Player_Romus: ""This is neither the time nor the place for flattery!""*)
  - -> `[877]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[873]` (*Player_Romus: ""Please focus on the task at hand, Titus.""*)

### Węzeł `[873]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please focus on the task at hand, Titus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[867]` (Titus Gordion), `[872]` (Titus Gordion), `[894]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]` (*Narrator: "A loud commotion drew everyone's attention to the unrest ..."*)

### Węzeł `[874]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is neither the time nor the place for flattery!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[872]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]` (*Narrator: "A loud commotion drew everyone's attention to the unrest ..."*)

### Węzeł `[875]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for supporting your king in his darkest hour.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[867]` (Titus Gordion), `[872]` (Titus Gordion), `[894]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]` (*Narrator: "A loud commotion drew everyone's attention to the unrest ..."*)

### Węzeł `[876]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God grant me the strength to live up to your belief in me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[867]` (Titus Gordion), `[872]` (Titus Gordion), `[894]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]` (*Narrator: "A loud commotion drew everyone's attention to the unrest ..."*)

### Węzeł `[877]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[879]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[878]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Player_Romus: ""May God grant me the strength to live up to your belief ..."*)

### Węzeł `[879]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[880]`
Mówca: **Narrator**
> "A loud commotion drew everyone's attention to the unrest outside the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[881]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[882]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]` (*Titus Gordion: ""We should get moving, Your Majesty.""*)

### Węzeł `[883]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]` (*Narrator: "Not wanting to wait any longer, I signaled for my guards ..."*)

### Węzeł `[884]`
Mówca: **Titus Gordion**
> ""We should get moving, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]` (*Narrator: "I gave a curt nod, signaling Titus to proceed."*)

### Węzeł `[885]`
Mówca: **Narrator**
> "I gave a curt nod, signaling Titus to proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]` (*Narrator: "It wasn't long before we reached the doors to the audienc..."*)

### Węzeł `[886]`
Mówca: **Narrator**
> "Not wanting to wait any longer, I signaled for my guards to keep moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]` (*Narrator: "It wasn't long before we reached the doors to the audienc..."*)

### Węzeł `[887]`
Mówca: **Narrator**
> "Titus ordered his men to take defensive positions in the hall while he and I entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Narrator: "I hurried to the nearest window and glanced outside. From..."*)

### Węzeł `[888]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[890]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[889]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]` (*Narrator: "Titus ordered his men to take defensive positions in the ..."*)

### Węzeł `[890]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[891]`
Mówca: **Narrator**
> "It wasn't long before we reached the doors to the audience chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[892]`
Mówca: **Narrator**
> "Sevrio instructed his guards to take up defensive positions in the hall while I went inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Narrator: "I hurried to the nearest window and glanced outside. From..."*)

### Węzeł `[893]`
Mówca: **Titus Gordion**
> ""Your Majesty, there's nothing to be ashamed of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]` (*Titus Gordion: ""You possess the strength and wisdom to lead us forward w..."*)

### Węzeł `[894]`
Mówca: **Titus Gordion**
> ""You are the rightful king, and we stand with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Player_Romus: ""Thank you for supporting your king in his darkest hour.""*)
  - -> `[877]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[873]` (*Player_Romus: ""Please focus on the task at hand, Titus.""*)

### Węzeł `[895]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[896]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[897]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[896]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]` (*Titus Gordion: ""Divus zaitu!""*)

### Węzeł `[897]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)

### Węzeł `[898]`
Mówca: **Titus Gordion**
> ""Divus zaitu!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1086]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Religion_DivusZaitu == false"*)

### Węzeł `[899]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shut up and listen to me!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "A few mocking laughs reached my ears. Despite this, I pre..."*)

### Węzeł `[900]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[902]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[901]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]` (*Narrator: "Titus gave a nod of confirmation."*)

### Węzeł `[902]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[903]`
Mówca: **Narrator**
> "Titus gave a nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Titus Gordion: ""How can we support you, sir?""*)

### Węzeł `[904]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[906]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[905]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1121]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sevrio Castellanus");"*)

### Węzeł `[906]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]` (*Narrator: "In the dimly lit basement of the palace, I found myself f..."*)

### Węzeł `[907]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by Titus and his second-in-command in the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "Together with a handful of military personnel, we watched..."*)

### Węzeł `[908]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[910]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[909]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1122]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sevrio Castellanus");"*)

### Węzeł `[910]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[911]` (*Narrator: "In the dimly lit basement of the palace, I found myself f..."*)

### Węzeł `[911]`
Mówca: **Narrator**
> "In the dimly lit basement of the palace, I found myself flanked by the new captain of the Golden Guard and his loyal second-in-command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "Together with a handful of military personnel, we watched..."*)

### Węzeł `[912]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything happens, protect yourself and {RiziaDLCText.KingsSon}. Don't worry about me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[913]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry we didn't get more time together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[914]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[916]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[915]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1147]` (*Bruno: ""Hrr?""*)

### Węzeł `[916]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[928]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[917]`
Mówca: **Narrator**
> "Bruno tilted his head and looked at me quizzically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[918]` (*Player_Romus: ""Come along, boy. The public will have more sympathy for ..."*)
  - -> `[919]` (*Player_Romus: ""It's too dangerous for you out there. Stay until I get b..."*)
  - -> `[920]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[918]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come along, boy. The public will have more sympathy for a cute animal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[917]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[931]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno = true"*)

### Węzeł `[919]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too dangerous for you out there. Stay until I get back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[917]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1149]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bruno");"*)

### Węzeł `[920]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[921]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[922]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[921]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[923]` (*Player_Romus: ""Stay here and protect Pabel.""*)

### Węzeł `[922]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[924]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[923]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and protect Pabel.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[917]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1149]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bruno");"*)

### Węzeł `[924]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[925]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arre..."*)
  - -> `[926]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Ar..."*)

### Węzeł `[925]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[927]` (*Player_Romus: ""Stay here and protect Lucita.""*)

### Węzeł `[926]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[927]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay here and protect Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true` AND `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[917]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1149]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bruno");"*)

### Węzeł `[928]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[929]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)
  - -> `[930]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == tr..."*)

### Węzeł `[929]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Player_Romus_Italic: "Leave the room."*)

### Węzeł `[930]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus_Italic: "Leave the room."*)

### Węzeł `[931]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Player_Romus_Italic: "Leave the room."*)

### Węzeł `[932]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)
  - -> `[934]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == ..."*)

### Węzeł `[933]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[935]` (*Narrator: "Bruno, with his keen sense for danger, appeared relaxed a..."*)

### Węzeł `[934]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]` (*Narrator: "Confident the coast was clear, I hurried down the hall. A..."*)

### Węzeł `[935]`
Mówca: **Narrator**
> "Bruno, with his keen sense for danger, appeared relaxed as he sniffed a nearby statue -- his behavior reassuring me that we weren't under any immediate threat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]` (*Narrator: "Confident the coast was clear, I hurried down the hall. A..."*)

### Węzeł `[936]`
Mówca: **Narrator**
> "Confident the coast was clear, I hurried down the hall. As I did, I glanced at the portraits of former rulers lining the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "Before I knew it, I found myself standing beneath the por..."*)

### Węzeł `[937]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[938]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)
  - -> `[939]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == ..."*)

### Węzeł `[938]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[940]` (*Narrator: "Bruno, with his keen sense for danger, appeared relaxed a..."*)

### Węzeł `[939]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Narrator: "Once my men confirmed the coast was clear, we hurried alo..."*)

### Węzeł `[940]`
Mówca: **Narrator**
> "Bruno, with his keen sense for danger, appeared relaxed as he sniffed a nearby statue -- his behavior reassuring us that we weren't under any immediate threat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[941]` (*Narrator: "Once my men confirmed the coast was clear, we hurried alo..."*)

### Węzeł `[941]`
Mówca: **Narrator**
> "Once my men confirmed the coast was clear, we hurried along. As I did, I glanced at the portraits of former rulers lining the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "Before I knew it, I found myself standing beneath the por..."*)

### Węzeł `[942]`
Mówca: **Narrator**
> "Bruno followed me out onto the balcony and remained by my side. His steadfast presence reassured me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Narrator: "Yells and screams erupted from the crowd. I had certainly..."*)

### Węzeł `[943]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[944]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)
  - -> `[945]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == ..."*)

### Węzeł `[944]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[942]` (*Narrator: "Bruno followed me out onto the balcony and remained by my..."*)

### Węzeł `[945]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Narrator: "Yells and screams erupted from the crowd. I had certainly..."*)

### Węzeł `[946]`
Mówca: **Narrator**
> "Bruno licked my hand, as if to comfort me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[951]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[947]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[948]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)
  - -> `[949]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == ..."*)

### Węzeł `[948]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]` (*Narrator: "Bruno licked my hand, as if to comfort me."*)

### Węzeł `[949]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[951]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[950]`
Mówca: **Narrator**
> ""Divus zaitu" was a Wruhecist term meaning "May God be with you"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Player_Romus_Italic: "Open the balcony doors."*)

### Węzeł `[951]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[952]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[953]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[952]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[956]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[953]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Narrator: "They had gotten what they came for."*)

### Węzeł `[954]`
Mówca: **Titus Gordion**
> ""Your Majesty, did I hear correctly? Are you truly abdicating the throne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[957]` (*Narrator: "I turned to see Titus standing in the doorway, his eyes w..."*)

### Węzeł `[955]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "I gazed out into the Palace grounds. Just like during my ..."*)

### Węzeł `[956]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]` (*Titus Gordion: ""Your Majesty, did I hear correctly? Are you truly abdica..."*)

### Węzeł `[957]`
Mówca: **Narrator**
> "I turned to see Titus standing in the doorway, his eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[977]` (*Player_Romus: ""Spare me your pity and get out of my sight.""*)
  - -> `[960]` (*Player_Romus: ""Your ears serve you well, Titus.""*)
  - -> `[959]` (*Player_Romus: ""Unfortunately, yes. For the first time in my life, I'm o..."*)
  - -> `[958]` (*Player_Romus: ""Yes, Titus. I'm afraid I don't have any other option.""*)

### Węzeł `[958]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Titus. I'm afraid I don't have any other option.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[957]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[961]` (*Titus Gordion: ""But, sir, the kingdom needs your guidance.""*)

### Węzeł `[959]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, yes. For the first time in my life, I'm out of a job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[957]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[978]` (*Titus Gordion: ""But, sir, our kingdom depends on your leadership.""*)

### Węzeł `[960]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your ears serve you well, Titus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[957]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[979]` (*Titus Gordion: ""But, sir, Rizia's future hinges on your guidance!""*)

### Węzeł `[961]`
Mówca: **Titus Gordion**
> ""But, sir, the kingdom needs your guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]` (*Player_Romus: ""The country will just have to go on without me.""*)
  - -> `[963]` (*Player_Romus: ""This is the best course for our people, as much as it pa..."*)
  - -> `[962]` (*Player_Romus: ""Rizia will endure, Titus, with or without a king.""*)

### Węzeł `[962]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia will endure, Titus, with or without a king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[961]` (Titus Gordion), `[978]` (Titus Gordion), `[979]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]` (*Titus Gordion: ""It goes without saying, Your Majesty, that serving you h..."*)

### Węzeł `[963]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the best course for our people, as much as it pains me to admit it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[961]` (Titus Gordion), `[978]` (Titus Gordion), `[979]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]` (*Titus Gordion: ""It goes without saying, Your Majesty, that serving you h..."*)

### Węzeł `[964]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The country will just have to go on without me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[961]` (Titus Gordion), `[978]` (Titus Gordion), `[979]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]` (*Titus Gordion: ""It goes without saying, Your Majesty, that serving you h..."*)

### Węzeł `[965]`
Mówca: **Titus Gordion**
> ""It goes without saying, Your Majesty, that serving you has been the greatest honor of my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[966]` (*Titus Gordion: ""I only wish I could have done more.""*)

### Węzeł `[966]`
Mówca: **Titus Gordion**
> ""I only wish I could have done more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[969]` (*Player_Romus: ""The failure is mine, not yours. Until we meet again, Cap..."*)
  - -> `[970]` (*Player_Romus: ""Just leave.""*)
  - -> `[968]` (*Player_Romus: ""Farewell, my friend. May our paths cross again under bet..."*)
  - -> `[967]` (*Player_Romus: ""You've done more than enough, Titus. Now, it's time for ..."*)

### Węzeł `[967]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've done more than enough, Titus. Now, it's time for a new chapter, for both of us."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[966]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[975]` (*Titus Gordion: ""I trust that the future holds brighter days.""*)

### Węzeł `[968]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Farewell, my friend. May our paths cross again under better circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[966]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[973]` (*Titus Gordion: ""May the future be kinder to us all.""*)

### Węzeł `[969]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The failure is mine, not yours. Until we meet again, Captain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[966]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[976]` (*Titus Gordion: ""Hopefully sooner than later. Farewell.""*)

### Węzeł `[970]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[966]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Narrator: "A flicker of disappointment briefly crossed Titus's face...."*)

### Węzeł `[971]`
Mówca: **Narrator**
> "Titus bowed respectfully and took his leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[972]` (*Narrator: "I looked back to see the crowd, whose celebrations showed..."*)

### Węzeł `[972]`
Mówca: **Narrator**
> "I looked back to see the crowd, whose celebrations showed no signs of stopping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Narrator: "They had gotten what they came for."*)

### Węzeł `[973]`
Mówca: **Titus Gordion**
> ""May the future be kinder to us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]` (*Narrator: "Titus bowed respectfully and took his leave."*)

### Węzeł `[974]`
Mówca: **Narrator**
> "A flicker of disappointment briefly crossed Titus's face. However, he remained composed, bowing respectfully before taking his leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[972]` (*Narrator: "I looked back to see the crowd, whose celebrations showed..."*)

### Węzeł `[975]`
Mówca: **Titus Gordion**
> ""I trust that the future holds brighter days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]` (*Narrator: "Titus bowed respectfully and took his leave."*)

### Węzeł `[976]`
Mówca: **Titus Gordion**
> ""Hopefully sooner than later. Farewell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]` (*Narrator: "Titus bowed respectfully and took his leave."*)

### Węzeł `[977]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spare me your pity and get out of my sight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[957]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]` (*Narrator: "Titus bowed respectfully and took his leave."*)

### Węzeł `[978]`
Mówca: **Titus Gordion**
> ""But, sir, our kingdom depends on your leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]` (*Player_Romus: ""The country will just have to go on without me.""*)
  - -> `[963]` (*Player_Romus: ""This is the best course for our people, as much as it pa..."*)
  - -> `[962]` (*Player_Romus: ""Rizia will endure, Titus, with or without a king.""*)

### Węzeł `[979]`
Mówca: **Titus Gordion**
> ""But, sir, Rizia's future hinges on your guidance!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]` (*Player_Romus: ""The country will just have to go on without me.""*)
  - -> `[963]` (*Player_Romus: ""This is the best course for our people, as much as it pa..."*)
  - -> `[962]` (*Player_Romus: ""Rizia will endure, Titus, with or without a king.""*)

### Węzeł `[980]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[982]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[981]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[988]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[982]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[983]`
Mówca: **Narrator**
> "At that moment, Titus ran out onto the balcony, attempting to rush me away, but he was too late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[984]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[985]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)
  - -> `[986]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)"*)

### Węzeł `[985]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[987]` (*Narrator: "Titus stood over me, his voice a distant murmur that I co..."*)

### Węzeł `[986]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1090]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)

### Węzeł `[987]`
Mówca: **Narrator**
> "Titus stood over me, his voice a distant murmur that I couldn't comprehend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1090]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)

### Węzeł `[988]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[983]` (*Narrator: "At that moment, Titus ran out onto the balcony, attemptin..."*)

### Węzeł `[989]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[990]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[991]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[990]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[992]` (*Narrator: "Titus nodded in confirmation."*)

### Węzeł `[991]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[992]`
Mówca: **Narrator**
> "Titus nodded in confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[993]` (*Titus Gordion: ""Your orders, sir?""*)

### Węzeł `[993]`
Mówca: **Titus Gordion**
> ""Your orders, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""We need reinforcements. Go round up as many other guards..."*)
  - -> `[52]` (*Player_Romus: ""Stay with us. Grab whatever you can and barricade the do..."*)

### Węzeł `[994]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[995]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[996]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[995]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[997]` (*Narrator: "With a salute, Titus rushed out of the room. In the meant..."*)

### Węzeł `[996]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[997]`
Mówca: **Narrator**
> "With a salute, Titus rushed out of the room. In the meantime, we needed to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1003]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Titus_Reinforcements = true;"*)

### Węzeł `[998]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[1000]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[999]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1001]` (*Narrator: "Titus saluted, prompting the other guards to scan the roo..."*)

### Węzeł `[1000]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[1001]`
Mówca: **Narrator**
> "Titus saluted, prompting the other guards to scan the room for anything they could use to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1002]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Defend = true;"*)

### Węzeł `[1002]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Defend = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Defend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus_Italic: "Barricade with a table."*)
  - -> `[82]` (*Player_Romus_Italic: "Barricade with a bookshelf."*)

### Węzeł `[1003]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Titus_Reinforcements = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus_Italic: "Barricade with a table."*)
  - -> `[82]` (*Player_Romus_Italic: "Barricade with a bookshelf."*)

### Węzeł `[1004]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Titus_Reinforcements == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1005]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Titus_Reinforcements == true"*)
  - -> `[1006]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)"*)

### Węzeł `[1005]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Titus_Reinforcements == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1009]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[1006]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "It was one of the palace cleaners, trying to run away fro..."*)

### Węzeł `[1007]`
Mówca: **Narrator**
> "It was Titus and his men bringing along four other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1008]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 4;"*)

### Węzeł `[1008]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]` (*Narrator: "Everyone came inside."*)

### Węzeł `[1009]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1010]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[1011]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[1010]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1007]` (*Narrator: "It was Titus and his men bringing along four other Golden..."*)

### Węzeł `[1011]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1012]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Default == true"*)

### Węzeł `[1012]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1013]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Default == true"*)
  - -> `[1014]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Default == true)"*)

### Węzeł `[1013]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1019]` (*Narrator: "It was Titus and his men bringing along two other Golden ..."*)

### Węzeł `[1014]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1016]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[1015]`
Mówca: **Narrator**
> "Everyone came inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1066]` (*Titus Gordion: ""Sir, the militants are closing in. We have to get ready.""*)

### Węzeł `[1016]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1017]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1018]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1017]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1023]` (*Narrator: "It was Titus and Sevrio bringing along seven other Wruhec..."*)

### Węzeł `[1018]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1022]` (*Narrator: "Titus and his men had returned. They couldn't find anyone."*)

### Węzeł `[1019]`
Mówca: **Narrator**
> "It was Titus and his men bringing along two other Golden Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1020]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 2;"*)

### Węzeł `[1020]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]` (*Narrator: "Everyone came inside."*)

### Węzeł `[1021]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 7;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]` (*Narrator: "Everyone came inside."*)

### Węzeł `[1022]`
Mówca: **Narrator**
> "Titus and his men had returned. They couldn't find anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1015]` (*Narrator: "Everyone came inside."*)

### Węzeł `[1023]`
Mówca: **Narrator**
> "It was Titus and Sevrio bringing along seven other Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1021]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 7;"*)

### Węzeł `[1024]`
Mówca: **Narrator**
> "However, it wasn't long before an influx of footsteps, more than before, could be heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1093]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements == true..."*)

### Węzeł `[1025]`
Mówca: **Narrator**
> "As the smoke cleared, and my hearing slowly returned, I saw that two nearby guards lay dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1026]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[1026]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1027]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[1028]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[1027]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1029]` (*Narrator: "Nearby, Titus was down, unconscious but still breathing."*)

### Węzeł `[1028]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[1029]`
Mówca: **Narrator**
> "Nearby, Titus was down, unconscious but still breathing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1042]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[1030]`
Mówca: **Narrator**
> "When the smoke cleared, I saw I had taken down two of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_GunEmpty = true;"*)

### Węzeł `[1031]`
Mówca: **Narrator**
> "I'd been shot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 4;"*)

### Węzeł `[1032]`
Mówca: **Narrator**
> "Before I could react, a mob of masked militants wielding automatic rifles stormed the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "They aimed their rifles in my direction the moment I was ..."*)

### Węzeł `[1033]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1034]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pab..."*)
  - -> `[1035]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_P..."*)

### Węzeł `[1034]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1036]` (*Narrator: "But all of my guards were dead."*)

### Węzeł `[1035]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true || RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "All of my guards were dead."*)

### Węzeł `[1036]`
Mówca: **Narrator**
> "But all of my guards were dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "Jump to: [Surrounded Hub]"*)

### Węzeł `[1037]`
Mówca: **Narrator**
> "I shot at our assailants until I realized I wasn't firing at all. My magazine was empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1224]` (*Narrator: "My guards remained under cover, attempting to return fire."*)

### Węzeł `[1038]`
Mówca: **Narrator**
> "Titus saluted, then readied his weapon and assumed a defensive stance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1039]` (*Narrator: "It hit me then that I had no idea when or if I'd ever see..."*)

### Węzeł `[1039]`
Mówca: **Narrator**
> "It hit me then that I had no idea when or if I'd ever see him again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1255]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Sevr..."*)

### Węzeł `[1040]`
Mówca: **Narrator**
> "I turned my gaze to Lucita and her injury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "I tore off a piece of my shirt and wrapped it around Luci..."*)

### Węzeł `[1041]`
Mówca: **Narrator**
> "I turned my gaze to Pabel and his injury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "I tore off a piece of my shirt and wrapped it around Pabe..."*)

### Węzeł `[1042]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1043]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[1044]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[1043]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1045]` (*Narrator: "Bruno was nowhere in sight."*)

### Węzeł `[1044]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "An eerie silence settled in, and a slow, creeping terror ..."*)

### Węzeł `[1045]`
Mówca: **Narrator**
> "Bruno was nowhere in sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "An eerie silence settled in, and a slow, creeping terror ..."*)

### Węzeł `[1046]`
Mówca: **Narrator**
> "Memories suddenly flooded my mind -- memories of Vina, my mother..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1047]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[1047]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1048]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[1049]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[1048]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1050]` (*Narrator: "Lucita..."*)

### Węzeł `[1049]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1051]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[1050]`
Mówca: **Narrator**
> "Lucita..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1051]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[1051]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1052]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[1053]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[1052]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1054]` (*Narrator: "Pabel..."*)

### Węzeł `[1053]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1055]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[1054]`
Mówca: **Narrator**
> "Pabel..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1055]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[1055]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1056]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[1057]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[1056]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1058]` (*Narrator: "And Lena, my first love..."*)

### Węzeł `[1057]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1061]` (*Narrator: "Not to mention all of my triumphs and failures."*)

### Węzeł `[1058]`
Mówca: **Narrator**
> "And Lena, my first love..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1061]` (*Narrator: "Not to mention all of my triumphs and failures."*)

### Węzeł `[1059]`
Mówca: **Narrator**
> "It was as if all the important moments of my life were captured in a single flash."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Narrator: "And then they started fading away."*)

### Węzeł `[1060]`
Mówca: **Narrator**
> "The life I once knew was gone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[1061]`
Mówca: **Narrator**
> "Not to mention all of my triumphs and failures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1059]` (*Narrator: "It was as if all the important moments of my life were ca..."*)

### Węzeł `[1062]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1063]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[1064]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[1063]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1065]` (*Narrator: "Bruno's ears flattened, and he started to growl."*)

### Węzeł `[1064]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus_Italic: "Listen closely."*)
  - -> `[122]` (*Player_Romus_Italic: "Don't move."*)

### Węzeł `[1065]`
Mówca: **Narrator**
> "Bruno's ears flattened, and he started to growl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus_Italic: "Listen closely."*)
  - -> `[122]` (*Player_Romus_Italic: "Don't move."*)

### Węzeł `[1066]`
Mówca: **Titus Gordion**
> ""Sir, the militants are closing in. We have to get ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "It was then I heard an increasing number of footsteps gro..."*)

### Węzeł `[1067]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1068]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[1069]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[1068]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1070]` (*Titus Gordion: ""Your Majesty! Look out!""*)

### Węzeł `[1069]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[1070]`
Mówca: **Titus Gordion**
> ""Your Majesty! Look out!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1071]` (*Narrator: "Titus propelled himself between me and the door."*)

### Węzeł `[1071]`
Mówca: **Narrator**
> "Titus propelled himself between me and the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1072]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1073]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[1074]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[1073]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1075]` (*Titus Gordion: ""Your Majesty! Get down!""*)

### Węzeł `[1074]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[1075]`
Mówca: **Titus Gordion**
> ""Your Majesty! Get down!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1076]` (*Narrator: "Titus propelled himself between me and the door."*)

### Węzeł `[1076]`
Mówca: **Narrator**
> "Titus propelled himself between me and the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1077]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1078]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[1079]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[1078]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1080]` (*Titus Gordion: ""Whatever happens, Your Majesty, I just wanted you to kno..."*)

### Węzeł `[1079]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "We continued reinforcing the door. Before long, the foots..."*)

### Węzeł `[1080]`
Mówca: **Titus Gordion**
> ""Whatever happens, Your Majesty, I just wanted you to know that it's been an honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1083]` (*Player_Romus: ""No, Titus, the honor is mine.""*)
  - -> `[1082]` (*Player_Romus: ""Save the sentiment, Titus. We're not dead yet.""*)
  - -> `[1081]` (*Player_Romus: ""Much appreciated, but we haven't lost this fight yet!""*)

### Węzeł `[1081]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Much appreciated, but we haven't lost this fight yet!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1080]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "We continued reinforcing the door. Before long, the foots..."*)

### Węzeł `[1082]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Save the sentiment, Titus. We're not dead yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1080]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "We continued reinforcing the door. Before long, the foots..."*)

### Węzeł `[1083]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Titus, the honor is mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1080]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "We continued reinforcing the door. Before long, the foots..."*)

### Węzeł `[1084]`
Mówca: **Narrator**
> "Titus saluted then readied his weapon, assuming a defensive stance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1085]` (*Narrator: "It dawned on me that I had no idea when or if I'd ever se..."*)

### Węzeł `[1085]`
Mówca: **Narrator**
> "It dawned on me that I had no idea when or if I'd ever see him again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[1086]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Religion_DivusZaitu == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1087]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Religion_DivusZaitu == false"*)
  - -> `[1088]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Religion_DivusZaitu == false)"*)

### Węzeł `[1087]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Religion_DivusZaitu == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]` (*Narrator: ""Divus zaitu" was a Wruhecist term meaning "May God be wi..."*)

### Węzeł `[1088]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Religion_DivusZaitu == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Player_Romus_Italic: "Open the balcony doors."*)

### Węzeł `[1089]`
Mówca: **Narrator**
> "I felt a cold, wet nose against my cheek. Bruno was nudging me, trying to keep me awake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "Glancing down, I couldn't believe the sight of so much bl..."*)

### Węzeł `[1090]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1091]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true"*)
  - -> `[1092]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == ..."*)

### Węzeł `[1091]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1089]` (*Narrator: "I felt a cold, wet nose against my cheek. Bruno was nudgi..."*)

### Węzeł `[1092]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.RevolutionEnding_FinalSpeech_Bruno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "Glancing down, I couldn't believe the sight of so much bl..."*)

### Węzeł `[1093]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Reinforcements == true || RiziaDLCIsolated.Revolution_Titus_Reinforcements == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1094]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements == true..."*)
  - -> `[1095]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_Guards_Reinforcements == tr..."*)

### Węzeł `[1094]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Reinforcements == true || RiziaDLCIsolated.Revolution_Titus_Reinforcements == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true  or  Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1096]` (*Narrator: "They were rapidly approaching."*)

### Węzeł `[1095]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_Guards_Reinforcements == true || RiziaDLCIsolated.Revolution_Titus_Reinforcements == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_Guards_Reinforcements"] == true  or  Variable["RiziaDLCIsolated.Revolution_Titus_Reinforcements"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "They were rapidly approaching."*)

### Węzeł `[1096]`
Mówca: **Narrator**
> "They were rapidly approaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1101]` (*Narrator: "Before long, the footsteps stopped right outside the barr..."*)

### Węzeł `[1097]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1098]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[1099]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[1098]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1100]` (*Narrator: "Bruno sniffed at the door and wagged his tail eagerly. Wh..."*)

### Węzeł `[1099]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus_Italic: "Open the door."*)
  - -> `[89]` (*Player_Romus_Italic: "Do not open the door."*)

### Węzeł `[1100]`
Mówca: **Narrator**
> "Bruno sniffed at the door and wagged his tail eagerly. Whoever it was, they weren't hostile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus_Italic: "Open the door."*)
  - -> `[89]` (*Player_Romus_Italic: "Do not open the door."*)

### Węzeł `[1101]`
Mówca: **Narrator**
> "Before long, the footsteps stopped right outside the barricade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[1102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[1104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[1103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1105]` (*Narrator: "Bruno's ears flattened, and he started to growl."*)

### Węzeł `[1104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1106]` (*Player_Romus_Italic: "Listen closely."*)
  - -> `[1107]` (*Player_Romus_Italic: "Don't move."*)

### Węzeł `[1105]`
Mówca: **Narrator**
> "Bruno's ears flattened, and he started to growl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1106]` (*Player_Romus_Italic: "Listen closely."*)
  - -> `[1107]` (*Player_Romus_Italic: "Don't move."*)

### Węzeł `[1106]`
**[WYBÓR GRACZA: "Listen closely."]** — Mówca: **Player_Romus_Italic**
> "I listened closely to understand what was going on."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[1105]` (Narrator), `[1101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1108]` (*Narrator: "That's when I heard a loud piercing beep."*)

### Węzeł `[1107]`
**[WYBÓR GRACZA: "Don't move."]** — Mówca: **Player_Romus_Italic**
> "I remained still, waiting to see what would happen."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[1105]` (Narrator), `[1101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1109]` (*Narrator: "That's when I heard a loud beep."*)

### Węzeł `[1108]`
Mówca: **Narrator**
> "That's when I heard a loud piercing beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[1109]`
Mówca: **Narrator**
> "That's when I heard a loud beep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[1110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[1112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[1111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1116]` (*Lucita Azaro: ""An E4-X7 from DuMont Powder Company. I thought they stop..."*)

### Węzeł `[1112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[1113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[1115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[1114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1117]` (*Pabel Adria: ""That can't be good.""*)

### Węzeł `[1115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1119]` (*Player_Romus: ""IT'S THEM!""*)
  - -> `[1118]` (*Player_Romus: ""GET DOWN!""*)
  - -> `[1120]` (*Player_Romus: ""RUN!""*)

### Węzeł `[1116]`
Mówca: **Lucita Azaro**
> ""An E4-X7 from DuMont Powder Company. I thought they stopped making those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1119]` (*Player_Romus: ""IT'S THEM!""*)
  - -> `[1118]` (*Player_Romus: ""GET DOWN!""*)
  - -> `[1120]` (*Player_Romus: ""RUN!""*)

### Węzeł `[1117]`
Mówca: **Pabel Adria**
> ""That can't be good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1119]` (*Player_Romus: ""IT'S THEM!""*)
  - -> `[1118]` (*Player_Romus: ""GET DOWN!""*)
  - -> `[1120]` (*Player_Romus: ""RUN!""*)

### Węzeł `[1118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""GET DOWN!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[1116]` (Lucita Azaro), `[1117]` (Pabel Adria), `[1108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""IT'S THEM!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[1116]` (Lucita Azaro), `[1117]` (Pabel Adria), `[1108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""RUN!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[1116]` (Lucita Azaro), `[1117]` (Pabel Adria), `[1108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "In the dimly lit basement of the palace, I found myself f..."*)

### Węzeł `[1122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Narrator: "In the dimly lit basement of the palace, I found myself f..."*)

### Węzeł `[1123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_FinalDecision_StayAndFight == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_FinalDecision_StayAndFight == true"*)
  - -> `[1125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_FinalDecision_StayAndFight == true)"*)

### Węzeł `[1124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_FinalDecision_StayAndFight == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1126]` (*Narrator: "She'd stayed by my side even as the revolutionaries close..."*)

### Węzeł `[1125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_FinalDecision_StayAndFight == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1127]` (*Narrator: "She'd stayed by my side even as the revolutionaries close..."*)

### Węzeł `[1126]`
Mówca: **Narrator**
> "She'd stayed by my side even as the revolutionaries closed in on Porte Drazon, helping me plan for the fight that still lay ahead of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucita Azaro: ""I can't believe I'm saying this, but I'm scared. There a..."*)

### Węzeł `[1127]`
Mówca: **Narrator**
> "She'd stayed by my side even as the revolutionaries closed in on Porte Drazon, watching me drink glass after glass of wine and reminisce about the days when kings still held power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucita Azaro: ""I can't believe I'm saying this, but I'm scared. There a..."*)

### Węzeł `[1128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "Beside us, Bruno let out a nervous whimper. Lucita patted..."*)

### Węzeł `[1129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1132]` (*Narrator: "Sevrio handed me a gun. I stared at it, remembering how b..."*)

### Węzeł `[1131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Narrator: "One of my guards thrust a gun into my hands. I stared at ..."*)

### Węzeł `[1132]`
Mówca: **Narrator**
> "Sevrio handed me a gun. I stared at it, remembering how badly things had gone in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown = 4;"*)

### Węzeł `[1133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Narrator: "Beside us, Bruno let out a nervous whimper. Pabel patted ..."*)

### Węzeł `[1134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "Beside me, Bruno let out a nervous whimper."*)

### Węzeł `[1135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_FinalDecision_StayAndFight == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_FinalDecision_StayAndFight == true"*)
  - -> `[1137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_FinalDecision_StayAndFight == true)"*)

### Węzeł `[1136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_FinalDecision_StayAndFight == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1138]` (*Narrator: "He'd stayed by my side even as the revolutionaries closed..."*)

### Węzeł `[1137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_FinalDecision_StayAndFight == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_FinalDecision_StayAndFight"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He'd stayed by my side even as the revolutionaries closed..."*)

### Węzeł `[1138]`
Mówca: **Narrator**
> "He'd stayed by my side even as the revolutionaries closed in on Porte Drazon, helping me plan for the fight that still lay ahead of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Pabel Adria: ""They've trampled straight through the hedge maze. That'l..."*)

### Węzeł `[1139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1142]` (*Narrator: "I turned to see Sevrio, his expectant gaze awaiting my co..."*)

### Węzeł `[1141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "I turned to see my guards, their expectant gazes awaiting..."*)

### Węzeł `[1142]`
Mówca: **Narrator**
> "I turned to see Sevrio, his expectant gaze awaiting my command."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1144]` (*Player_Romus: ""You and the Guardians will stay here and defend this roo..."*)
  - -> `[1143]` (*Player_Romus: ""Come with me. I can't go out there without backup.""*)

### Węzeł `[1143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come with me. I can't go out there without backup.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1146]` (*Sevrio Castellanus: ""We are with you, Your Majesty.""*)

### Węzeł `[1144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and the Guardians will stay here and defend this room with your lives. Is that clear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1142]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1145]` (*Sevrio Castellanus: ""As you command, sir. May God be with you.""*)

### Węzeł `[1145]`
Mówca: **Sevrio Castellanus**
> ""As you command, sir. May God be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend = true"*)

### Węzeł `[1146]`
Mówca: **Sevrio Castellanus**
> ""We are with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Follow = true"*)

### Węzeł `[1147]`
Mówca: **Bruno**
> ""Hrr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]` (*Narrator: "Bruno tilted his head and looked at me quizzically."*)

### Węzeł `[1148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Narrator: "The moment I stepped out, the guards began barricading th..."*)

### Węzeł `[1149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Bruno");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[928]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)

### Węzeł `[1150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1151]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true..."*)
  - -> `[1152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == tr..."*)

### Węzeł `[1151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[1152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true || RiziaDLCIsolated.Revolution_Guards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Revolution_TitusAndGuards_Follow"] == true  or  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1148]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Sevr..."*)

### Węzeł `[1153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1156]` (*Narrator: "With his weapon drawn, Sevrio led the way, escorting me t..."*)

### Węzeł `[1155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Narrator: "Weapons drawn, my guards led the way, escorting me to a n..."*)

### Węzeł `[1156]`
Mówca: **Narrator**
> "With his weapon drawn, Sevrio led the way, escorting me to a nearby stairwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Narrator: "Five flights later, we emerged into the upper-level corri..."*)

### Węzeł `[1157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[892]` (*Narrator: "Sevrio instructed his guards to take up defensive positio..."*)

### Węzeł `[1159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Narrator: "I hurried to the nearest window and glanced outside. From..."*)

### Węzeł `[1160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Revolution_Guards_Follow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1163]` (*Sevrio Castellanus: ""Divus zaitu, Your Majesty. May the Lord be with you.""*)

### Węzeł `[1162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Revolution_Guards_Follow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Revolution_Guards_Follow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Player_Romus_Italic: "Open the balcony doors."*)

### Węzeł `[1163]`
Mówca: **Sevrio Castellanus**
> ""Divus zaitu, Your Majesty. May the Lord be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Player_Romus_Italic: "Open the balcony doors."*)

### Węzeł `[1164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[1166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[1165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[1166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[1167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here goes nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[455]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_TitusAndGuards_Follow == true"*)

### Węzeł `[1168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[1170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[1169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1171]` (*Player_Romus: ""I fought for the reforms you wanted. If there's anyone y..."*)

### Węzeł `[1170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Player_Romus: ""It is a shame that the Rizian people have suffered. But ..."*)

### Węzeł `[1171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fought for the reforms you wanted. If there's anyone you should be angry at, it's the nobles who refused to let them pass.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[467]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""Every decision I've made has been with one goal in mind ..."*)
  - -> `[473]` (*Player_Romus: ""Yes, I've made my fair share of poor decisions. However,..."*)
  - -> `[475]` (*Player_Romus: ""I am but a fellow patriot much like yourselves!""*)

### Węzeł `[1172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1175]` (*Narrator: "Sevrio gave a nod of confirmation."*)

### Węzeł `[1174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "My guards awaited my instructions."*)

### Węzeł `[1175]`
Mówca: **Narrator**
> "Sevrio gave a nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1176]` (*Sevrio Castellanus: ""Your instructions, sir?""*)

### Węzeł `[1176]`
Mówca: **Sevrio Castellanus**
> ""Your instructions, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Player_Romus: ""I need one of the guards to stay behind in case there's ..."*)
  - -> `[54]` (*Player_Romus: ""All of you, come with me. We need every available hand t..."*)
  - -> `[656]` (*Player_Romus: ""Before we proceed, we need additional reinforcements. Hu..."*)

### Węzeł `[1177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1180]` (*Sevrio Castellanus: ""Right away.""*)

### Węzeł `[1179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Titus Gordion: ""Right away.""*)

### Węzeł `[1180]`
Mówca: **Sevrio Castellanus**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1181]` (*Narrator: "Sevrio saluted me and dashed out of the room as fast as p..."*)

### Węzeł `[1181]`
Mówca: **Narrator**
> "Sevrio saluted me and dashed out of the room as fast as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1182]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sevrio Castellanus");"*)

### Węzeł `[1182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements = true"*)

### Węzeł `[1183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Titus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Titus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1186]` (*Sevrio Castellanus: ""Good thinking. I'll stick with you.""*)

### Węzeł `[1185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLC.Titus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Titus Gordion: ""Good thinking. I'll stick with you.""*)

### Węzeł `[1186]`
Mówca: **Sevrio Castellanus**
> ""Good thinking. I'll stick with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[1187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1190]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sevrio Castellanus");"*)

### Węzeł `[1189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)

### Węzeł `[1190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "It was Sevrio, accompanied by six additional Wruhec's Gua..."*)

### Węzeł `[1191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1194]` (*Player_Romus: ""Sevrio, can you create a distraction?""*)

### Węzeł `[1193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Player_Romus: ""Titus, can one of your guards create a distraction?""*)

### Węzeł `[1194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sevrio, can you create a distraction?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true` AND `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] > 1` AND `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[590]` (Narrator), `[594]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1195]` (*Sevrio Castellanus: ""It would be my honor, Your Majesty.""*)

### Węzeł `[1195]`
Mówca: **Sevrio Castellanus**
> ""It would be my honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count -= 1;"*)

### Węzeł `[1196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1197]` (*Narrator: "With a deep breath, Sevrio stepped out to face the mob."*)

### Węzeł `[1197]`
Mówca: **Narrator**
> "With a deep breath, Sevrio stepped out to face the mob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1198]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sevrio Castellanus"); RiziaDLCIsolated...."*)

### Węzeł `[1198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sevrio Castellanus"); RiziaDLCIsolated.Ending_Revolution_SevrioDead = true;`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sevrio Castellanus");
Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "In a flash, gunfire erupted. The frenzy of the firefight ..."*)

### Węzeł `[1199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1202]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_Revolution_SevrioDead = true"*)

### Węzeł `[1201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 1;"*)

### Węzeł `[1202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_Revolution_SevrioDead = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count = 1;"*)

### Węzeł `[1203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_Revolution_SevrioDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1204]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_Revolution_SevrioDead == true"*)
  - -> `[1205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)"*)

### Węzeł `[1204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_Revolution_SevrioDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1210]` (*Narrator: "And it seemed like poor Sevrio hadn't made it."*)

### Węzeł `[1205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[1206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_Revolution_SevrioDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_Revolution_SevrioDead == true"*)
  - -> `[1208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)"*)

### Węzeł `[1207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_Revolution_SevrioDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1209]` (*Narrator: "But it seemed like poor Sevrio hadn't made it."*)

### Węzeł `[1208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_Revolution_SevrioDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[1209]`
Mówca: **Narrator**
> "But it seemed like poor Sevrio hadn't made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[1210]`
Mówca: **Narrator**
> "And it seemed like poor Sevrio hadn't made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_EscapeCountdown >= 2"*)

### Węzeł `[1211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)
  - -> `[1213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == true)"*)

### Węzeł `[1212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[1213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[1214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[1216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[1215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1217]` (*Narrator: "It was the guard I'd sent out, accompanied by four additi..."*)

### Węzeł `[1216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1218]` (*Narrator: "It was the guard I'd sent out, accompanied by two additio..."*)

### Węzeł `[1217]`
Mówca: **Narrator**
> "It was the guard I'd sent out, accompanied by four additional Golden Guardsmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1219]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 4;"*)

### Węzeł `[1218]`
Mówca: **Narrator**
> "It was the guard I'd sent out, accompanied by two additional Golden Guardsmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1220]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Count += 2;"*)

### Węzeł `[1219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1221]` (*Narrator: "They informed me that the enemy was quickly closing in."*)

### Węzeł `[1220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Revolution_Guards_Count += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Revolution_Guards_Count"] = Variable["RiziaDLCIsolated.Revolution_Guards_Count"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1221]` (*Narrator: "They informed me that the enemy was quickly closing in."*)

### Węzeł `[1221]`
Mówca: **Narrator**
> "They informed me that the enemy was quickly closing in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1223]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[1222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Player_Romus: ""I need one of the guards to stay behind in case there's ..."*)
  - -> `[54]` (*Player_Romus: ""All of you, come with me. We need every available hand t..."*)

### Węzeł `[1223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""All of you, come with me. We need every available hand t..."*)
  - -> `[55]` (*Player_Romus: ""One of you remain here in case there's any attempt to co..."*)

### Węzeł `[1224]`
Mówca: **Narrator**
> "My guards remained under cover, attempting to return fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)

### Węzeł `[1225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1227]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1228]` (*Narrator: "But then, much to my relief, I noticed Sevrio on the grou..."*)

### Węzeł `[1227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "But then, much to my relief, I noticed one of my guards o..."*)

### Węzeł `[1228]`
Mówca: **Narrator**
> "But then, much to my relief, I noticed Sevrio on the ground, playing dead. He gave me a slight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "The moment the militants approached, he stood and opened ..."*)

### Węzeł `[1229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1232]` (*Narrator: "Sevrio and I tried to stop him, but we were too late. Pab..."*)

### Węzeł `[1231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Narrator: "A guard and I tried to stop him, but we were too late. Pa..."*)

### Węzeł `[1232]`
Mówca: **Narrator**
> "Sevrio and I tried to stop him, but we were too late. Pabel screamed in agony as the assailant sunk his knife into his chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1237]` (*Narrator: "Sevrio immediately shot the attacker dead."*)

### Węzeł `[1233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Sevrio and I tried to stop him, but we were too late. My ..."*)

### Węzeł `[1235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1236]` (*Narrator: "Sevrio and I tried to stop him, but we were too late. My ..."*)

### Węzeł `[1236]`
Mówca: **Narrator**
> "Sevrio and I tried to stop him, but we were too late. My wife screamed in agony as the assailant sunk his knife into her chest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[1237]`
Mówca: **Narrator**
> "Sevrio immediately shot the attacker dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[1238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1240]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Narrator: "He staggered backward, and without a moment's hesitation,..."*)

### Węzeł `[1240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1241]` (*Narrator: "He staggered backward, and without a moment's hesitation,..."*)

### Węzeł `[1241]`
Mówca: **Narrator**
> "He staggered backward, and without a moment's hesitation, my guard shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[1242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1245]` (*Narrator: "Without a moment's hesitation, Sevrio shot him dead."*)

### Węzeł `[1244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Narrator: "Without a moment's hesitation, my guard shot him dead."*)

### Węzeł `[1245]`
Mówca: **Narrator**
> "Without a moment's hesitation, Sevrio shot him dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "Jump to: [Survived Hub]"*)

### Węzeł `[1246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaD..."*)
  - -> `[1248]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && Rizi..."*)

### Węzeł `[1247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1249]` (*Narrator: "Sevrio looked at me with solemn eyes."*)

### Węzeł `[1248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true && RiziaDLCIsolated.Ending_Revolution_SevrioDead == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  and  Variable["RiziaDLCIsolated.Ending_Revolution_SevrioDead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[1249]`
Mówca: **Narrator**
> "Sevrio looked at me with solemn eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1250]` (*Sevrio Castellanus: ""The Lord put me on this planet for one reason, Your Maje..."*)

### Węzeł `[1250]`
Mówca: **Sevrio Castellanus**
> ""The Lord put me on this planet for one reason, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1251]` (*Sevrio Castellanus: ""So that I could survive until today, until this very mom..."*)

### Węzeł `[1251]`
Mówca: **Sevrio Castellanus**
> ""So that I could survive until today, until this very moment, to defend my King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1252]` (*Player_Romus: ""Halaita.""*)
  - -> `[1256]` (*Player_Romus: ""The eternal bliss of Golconda will be your reward, my go..."*)
  - -> `[1257]` (*Player_Romus: ""No. You're coming with me.""*)

### Węzeł `[1252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1251]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[1253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1254]` (*Narrator: "Sevrio readied his weapon and assumed a defensive stance."*)

### Węzeł `[1254]`
Mówca: **Narrator**
> "Sevrio readied his weapon and assumed a defensive stance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1039]` (*Narrator: "It hit me then that I had no idea when or if I'd ever see..."*)

### Węzeł `[1255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true || RiziaDLC.P..."*)

### Węzeł `[1256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The eternal bliss of Golconda will be your reward, my good soldier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1251]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1254]` (*Narrator: "Sevrio readied his weapon and assumed a defensive stance."*)

### Węzeł `[1257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. You're coming with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[1251]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1258]` (*Sevrio Castellanus: ""Do not try to dissuade me from serving my highest purpos..."*)

### Węzeł `[1258]`
Mówca: **Sevrio Castellanus**
> ""Do not try to dissuade me from serving my highest purpose. Go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1254]` (*Narrator: "Sevrio readied his weapon and assumed a defensive stance."*)

### Węzeł `[1259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_InjuredInRevolution == true"*)
  - -> `[1261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_InjuredInRevolution == true )"*)

### Węzeł `[1260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_InjuredInRevolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "Fueled by adrenaline, I found the strength to carry my wi..."*)

### Węzeł `[1261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_InjuredInRevolution == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "Fueled by adrenaline, I found the strength to carry my lo..."*)

### Węzeł `[1262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Bi mare volu...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1263]` (*Narrator: "He didn't have the strength to respond. I ripped off anot..."*)

### Węzeł `[1263]`
Mówca: **Narrator**
> "He didn't have the strength to respond. I ripped off another piece of my shirt to stop the bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "We began rising over the palace turrets. I took a look be..."*)

### Węzeł `[1264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1267]` (*Narrator: "Sevrio nodded in confirmation."*)

### Węzeł `[1266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "My guards turned to me for instructions."*)

### Węzeł `[1267]`
Mówca: **Narrator**
> "Sevrio nodded in confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1268]` (*Sevrio Castellanus: ""Your orders, sir?""*)

### Węzeł `[1268]`
Mówca: **Sevrio Castellanus**
> ""Your orders, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""We need reinforcements. Go round up as many other guards..."*)
  - -> `[52]` (*Player_Romus: ""Stay with us. Grab whatever you can and barricade the do..."*)

### Węzeł `[1269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1270]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1271]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1272]` (*Narrator: "With a salute, Sevrio rushed out of the room. In the mean..."*)

### Węzeł `[1271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "With a salute, two of my guards rushed out of the room as..."*)

### Węzeł `[1272]`
Mówca: **Narrator**
> "With a salute, Sevrio rushed out of the room. In the meantime, we needed to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Reinforcements = true;"*)

### Węzeł `[1273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1276]` (*Narrator: "Sevrio saluted me, prompting the others to scan the room ..."*)

### Węzeł `[1275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "They saluted me and scanned the room for anything they co..."*)

### Węzeł `[1276]`
Mówca: **Narrator**
> "Sevrio saluted me, prompting the others to scan the room for anything they could use to block the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Revolution_Guards_Defend = true;"*)

### Węzeł `[1277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1280]` (*Sevrio Castellanus: ""Your Majesty! Look out!""*)

### Węzeł `[1279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1280]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty! Look out!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1281]` (*Narrator: "Sevrio propelled himself between me and the door."*)

### Węzeł `[1281]`
Mówca: **Narrator**
> "Sevrio propelled himself between me and the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[1282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[1284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[1283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1285]` (*Narrator: "Nearby, Sevrio was down, unconscious but still breathing."*)

### Węzeł `[1284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1042]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[1285]`
Mówca: **Narrator**
> "Nearby, Sevrio was down, unconscious but still breathing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1042]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[1286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Ending their reign with...", "Porte Drazon", "Kingdom of Rizia");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Ending their reign with...","Porte Drazon","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Stress", "R_Stress_Loop");"*)
