# Rizia/Turn 11/Ending_Coup_HouseFallouts

- **ID konwersacji:** `454`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Rizia/Turn_11/454_Ending_Coup_HouseFallouts.md`
- **Liczba węzłów dialogowych:** 878
- **Liczba wyborów gracza:** 138

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[85]** Sevrio Castellanus
- **[87]** Sal Ignacius
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Rumburg_War`
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.CoupWarning_BoatCancelled`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Sazon`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Rusty_Hostile`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Situation_Order_SuOmina_Destabilizing`
- `RiziaDLC.SuOmina_OrderedToKillManus`
- `RiziaDLC.Successor_Vina`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_Rescue_Success`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.War_Pales_Loss`
- `RiziaDLCIsolated.Coup_BringFamily`
- `RiziaDLCIsolated.Coup_BringGuards`
- `RiziaDLCIsolated.Coup_ToldToOpenFire`
- `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coup_Leader_Angelica`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstela`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina`
- `RiziaDLC.Epilogue_Death_HouseFallouts`
- `RiziaDLC.Epilogue_Prison_HouseFallouts`
- `RiziaDLC.Epilogue_Survived_HouseFallouts`
- `RiziaDLC.Epilogue_Usurped_HouseFallouts`
- `RiziaDLC.LateGameCoup_TitusBetrays`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLCIsolated.Coup_BringFamily`
- `RiziaDLCIsolated.Coup_BringGuards`
- `RiziaDLCIsolated.Coup_GuardsStay`
- `RiziaDLCIsolated.Coup_ToldToOpenFire`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **"Take a closer look."** | `[3]` **Narrator**: "As I entered the study and shift..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "I strained to discern anything i..." |
| `[18]` | **"Ignore it."** | `[3]` **Narrator**: "As I entered the study and shift..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[785]` **Narrator**: "There was no word from my daught..."<br>`[789]` **Narrator**: "There was a telegram from Vina, ..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **"Keep watching."** | `[20]` **Narrator**: "And then, out of nowhere, I caug..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "Several pairs of headlights sudd..." |
| `[22]` | **"Call the guards."** | `[20]` **Narrator**: "And then, out of nowhere, I caug..." | `Variable["RiziaDLC.Theocracy_Full"] == true`<br>`(Variable["RiziaDLC.Titus_Arrested"] == false) == false` | *Brak zmian stanu* | `[780]` **Narrator**: "Suddenly, the doors swung open a..." |
| `[25]` | **"Look out the window."** | `[23]` **Narrator**: "As I rummaged through the papers..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");` | `[28]` **Narrator**: "Several pairs of headlights sudd..." |
| `[26]` | **"Ignore the noise."** | `[23]` **Narrator**: "As I rummaged through the papers..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");` | `[391]` **Narrator**: "All of a sudden, the doors swung..."<br>`[29]` **Narrator**: "All of a sudden, the doors swung..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **""What do you mean the radio doesn't work? Go and tell the other guards what's happ..."** | `[56]` **Narrator**: "As we attempted to figure out wh..."<br>`[408]` **Titus Gordion**: ""Nothing. The signal's gone dead.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Coup_BringGuards"] = true;` | `[416]` **Titus Gordion**: ""Of course, Your Majesty. I'll b..."<br>`[834]` **Sevrio Castellanus**: ""Yes, Your Majesty. I'll be back..."<br>*(oraz 1 innych odgałęzień)* |
| `[61]` | **""Go and make sure my mother is safe.""** | `[56]` **Narrator**: "As we attempted to figure out wh..."<br>`[408]` **Titus Gordion**: ""Nothing. The signal's gone dead.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Coup_BringFamily"] = true;` | `[416]` **Titus Gordion**: ""Of course, Your Majesty. I'll b..."<br>`[834]` **Sevrio Castellanus**: ""Yes, Your Majesty. I'll be back..."<br>*(oraz 1 innych odgałęzień)* |
| `[62]` | **""Don't go anywhere. Stay with me.""** | `[56]` **Narrator**: "As we attempted to figure out wh..."<br>`[408]` **Titus Gordion**: ""Nothing. The signal's gone dead.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Titus Gordion**: ""I will, Your Majesty.""<br>`[830]` **Sevrio Castellanus**: ""Yes, Your Majesty.""<br>*(oraz 1 innych odgałęzień)* |
| `[122]` | **""I must address their demands.""** | `[120]` **Estela Toras**: ""What are you going to do?""<br>`[350]` **Vina Toras**: ""What are you going to do?"" | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[143]` **Estela Toras**: ""Romus. Please think before you ..." |
| `[123]` | **""Nothing. I'm afraid I have no choice but to do as they say.""** | `[120]` **Estela Toras**: ""What are you going to do?""<br>`[350]` **Vina Toras**: ""What are you going to do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Estela Toras**: ""Romus. Please think before you ..." |
| `[124]` | **""Fight back. Guards! Get in position and open fire!""** | `[120]` **Estela Toras**: ""What are you going to do?""<br>`[350]` **Vina Toras**: ""What are you going to do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Vina Toras**: ""What? No!""<br>`[195]` **Estela Toras**: ""What? No!"" |
| `[125]` | **""Good. Tell them to open fire!""** | `[115]` **Titus Gordion**: ""What are your orders?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Titus Gordion**: ""As you wish, Your Majesty."" |
| `[126]` | **""I don't have a choice. We must listen to the rebels' demands.""** | `[115]` **Titus Gordion**: ""What are your orders?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Titus Gordion**: ""But..."" |
| `[127]` | **""Let me talk to them.""** | `[115]` **Titus Gordion**: ""What are your orders?"" | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." |
| `[128]` | **""You have to get my family out of here this instant. In the meantime, I will talk ..."** | `[96]` **Narrator**: "The guards cast nervous glances ..."<br>`[447]` **Narrator**: "Titus cast an agitated glance my..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Narrator**: "The soldiers saluted me as I gra..." |
| `[129]` | **""I'm going to go out and talk to them.""** | `[96]` **Narrator**: "The guards cast nervous glances ..."<br>`[447]` **Narrator**: "Titus cast an agitated glance my..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Narrator**: "The soldiers saluted me as I gra..."<br>`[134]` **Titus Gordion**: ""Are you suggesting we negotiate..."<br>*(oraz 1 innych odgałęzień)* |
| `[130]` | **""We hold our ground, no exceptions. Is that understood? Now open fire!""** | `[96]` **Narrator**: "The guards cast nervous glances ..."<br>`[447]` **Narrator**: "Titus cast an agitated glance my..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Titus Gordion**: ""As you wish, Your Majesty.""<br>`[855]` **Sevrio Castellanus**: ""Your Majesty, I really must ins..."<br>*(oraz 1 innych odgałęzień)* |
| `[135]` | **""Given our limited numbers, we don't stand a chance. There's no other way out of t..."** | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Titus Gordion**: ""But..."" |
| `[136]` | **""I don't know. However, while they're focusing on me, you can better assess the si..."** | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;` | `[139]` **Titus Gordion**: ""As you wish, Your Majesty."" |
| `[137]` | **""It will buy us time. While their attention is on me, you can catch them off guard..."** | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Titus Gordion**: ""Understood, Your Majesty."" |
| `[147]` | **""It's a distraction. While I'm talking to the rebels, Titus will coordinate everyo..."** | `[143]` **Estela Toras**: ""Romus. Please think before you ..." | `(Variable["RiziaDLC.Titus_Arrested"] == true) == false` | `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;` | `[142]` **Narrator**: "My mother and daughter watched i..."<br>`[443]` **Narrator**: "My mother watched in wordless te..." |
| `[148]` | **""I have to do this to save our family.""** | `[143]` **Estela Toras**: ""Romus. Please think before you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "My mother and daughter watched i..."<br>`[443]` **Narrator**: "My mother watched in wordless te..." |
| `[149]` | **""Don't worry. I'll be right back.""** | `[143]` **Estela Toras**: ""Romus. Please think before you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "My mother and daughter watched i..."<br>`[443]` **Narrator**: "My mother watched in wordless te..." |
| `[150]` | **""Talking to them should distract them long enough for you to make your escape from..."** | `[143]` **Estela Toras**: ""Romus. Please think before you ..." | `Variable["RiziaDLC.Titus_Arrested"] == true` | *Brak zmian stanu* | `[142]` **Narrator**: "My mother and daughter watched i..."<br>`[443]` **Narrator**: "My mother watched in wordless te..." |
| `[153]` | **""Listen carefully. Take your weapons and depart from my palace, and I will disrega..."** | `[152]` **Narrator**: "Upon catching sight of me, the i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[154]` | **""Where the hell is my cousin? You're carrying out the orders of someone who lacks ..."** | `[152]` **Narrator**: "Upon catching sight of me, the i..." | `Variable["RiziaDLC.Coup_Leader_Rico"] == true` | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[167]` | **""Where the hell is my uncle? You're carrying out the orders of someone who lacks t..."** | `[152]` **Narrator**: "Upon catching sight of me, the i..." | `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`<br>`(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false` | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[168]` | **""Where the hell is Lucita? You're carrying out the orders of someone who lacks the..."** | `[152]` **Narrator**: "Upon catching sight of me, the i..." | `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`<br>`(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`<br>`(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false` | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[169]` | **""Where the hell is Taddeus? You're carrying out the orders of someone who lacks th..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[170]` | **""Where the hell is Angelica? You're carrying out the orders of someone who lacks t..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[171]` | **""Stand down. I'm not here to fight.""** | `[152]` **Narrator**: "Upon catching sight of me, the i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Narrator**: "A hush suddenly came over the cr..." |
| `[172]` | **"Don't say anything."** | `[152]` **Narrator**: "Upon catching sight of me, the i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Narrator**: "A hush suddenly came over the cr..." |
| `[179]` | **""Soldier! Lower that gun at once! You're pointing your weapon at your king!""** | `[652]` **Narrator**: "The officer took another step fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[669]` **Narrator**: "The man's aim faltered slightly ..."<br>`[670]` **Narrator**: "The man's aim faltered slightly ..."<br>*(oraz 1 innych odgałęzień)* |
| `[180]` | **""Go ahead. Shoot me. You can pry my crown from my cold dead hands!""** | `[652]` **Narrator**: "The officer took another step fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "At that moment, the stable doors..."<br>`[310]` **Narrator**: "Without a moment of hesitation, ..." |
| `[186]` | **""Stop! I surrender. Guards, drop your weapons!""** | `[669]` **Narrator**: "The man's aim faltered slightly ..."<br>`[670]` **Narrator**: "The man's aim faltered slightly ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false` | *Brak zmian stanu* | `[767]` **Narrator**: "Titus reluctantly signaled to hi..."<br>`[860]` **Narrator**: "Sevrio reluctantly signaled to h..."<br>*(oraz 1 innych odgałęzień)* |
| `[187]` | **""Guards! Open fire!""** | `[669]` **Narrator**: "The man's aim faltered slightly ..."<br>`[670]` **Narrator**: "The man's aim faltered slightly ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false` | *Brak zmian stanu* | `[203]` **Narrator**: "A thunderous barrage erupted as ..." |
| `[196]` | **""There's no time. Open fire immediately!""** | `[190]` **Narrator**: "The guards insisted on escorting..."<br>`[855]` **Sevrio Castellanus**: ""Your Majesty, I really must ins..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Narrator**: "The guards, displaying utmost pr..." |
| `[197]` | **"Follow them to the safe room."** | `[190]` **Narrator**: "The guards insisted on escorting..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`PlaySoundEffect("Gunfight");` | `[208]` **Narrator**: "As we rushed through corridors a..." |
| `[198]` | **""We have no time. Open fire immediately!""** | `[189]` **Titus Gordion**: ""But first, I need to escort you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Narrator**: "He nodded and gave a series of h..." |
| `[199]` | **""Very well. Lead the way.""** | `[189]` **Titus Gordion**: ""But first, I need to escort you..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`PlaySoundEffect("Gunfight");` | `[208]` **Narrator**: "As we rushed through corridors a..." |
| `[225]` | **""We've got to get you to safety. Let's go.""** | `[215]` **Vina Toras**: ""Father! What do we do?""<br>`[219]` **Estela Toras**: ""Romus! What do we do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[681]` **Narrator**: "Titus appeared by our side. He t..."<br>`[686]` **Narrator**: "Accompanied by our guards, we sp..." |
| `[226]` | **""Take cover! We'll wait here until the situation stabilizes.""** | `[215]` **Vina Toras**: ""Father! What do we do?""<br>`[219]` **Estela Toras**: ""Romus! What do we do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[680]` **Estela Toras**: ""To hell with that. We've got to..." |
| `[227]` | **""It is out of our hands now. We must pray.""** | `[215]` **Vina Toras**: ""Father! What do we do?""<br>`[219]` **Estela Toras**: ""Romus! What do we do?"" | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[680]` **Estela Toras**: ""To hell with that. We've got to..." |
| `[234]` | **"Comply."** | `[230]` **Narrator**: "Glancing back, I saw a group of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[694]` **Narrator**: "A spatter of gunshots suddenly e..."<br>`[236]` **Narrator**: "The rebels moved with quick step..." |
| `[235]` | **"Stand still."** | `[230]` **Narrator**: "Glancing back, I saw a group of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[695]` **Narrator**: "A spatter of gunshots suddenly e..."<br>`[240]` **Narrator**: "Vina and my mother threw themsel..."<br>*(oraz 3 innych odgałęzień)* |
| `[248]` | **""This isn't necessary. We're not resisting!""** | `[247]` **Narrator**: "They confidently brandished thei..."<br>`[236]` **Narrator**: "The rebels moved with quick step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Ignoring my words, they simply s..." |
| `[249]` | **""I am not some petty criminal. Release me from these restraints!""** | `[247]` **Narrator**: "They confidently brandished thei..."<br>`[236]` **Narrator**: "The rebels moved with quick step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Ignoring my words, they simply s..." |
| `[250]` | **""Do what you must.""** | `[247]` **Narrator**: "They confidently brandished thei..."<br>`[236]` **Narrator**: "The rebels moved with quick step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Ignoring my words, they simply s..." |
| `[251]` | **""One day, you will pay for this.""** | `[247]` **Narrator**: "They confidently brandished thei..."<br>`[236]` **Narrator**: "The rebels moved with quick step..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[252]` **Narrator**: "Ignoring my words, they simply s..." |
| `[256]` | **"Stay standing."** | `[254]` **Narrator**: ""Get down or we'll shoot!" one o..." | *Brak (Dostępna bezwarunkowo)* | `StopMusic(); ;`<br>`PlaySoundEffect("CoupGunshot");` | `[310]` **Narrator**: "Without a moment of hesitation, ..." |
| `[271]` | **""Are you certain we can clear the perimeter? There were tanks stationed outside th..."** | `[262]` **Titus Gordion**: ""In the meantime, we must leave ..."<br>`[269]` **Sal Ignacius**: ""We must leave the palace as soo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Titus Gordion**: ""My guards are equipped to withs..."<br>`[290]` **Sevrio Castellanus**: ""Wruhec's Guardians are capable ..." |
| `[272]` | **""Where will we go?""** | `[262]` **Titus Gordion**: ""In the meantime, we must leave ..."<br>`[269]` **Sal Ignacius**: ""We must leave the palace as soo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Titus Gordion**: ""We'll regroup with our armed fo..."<br>`[285]` **Sal Ignacius**: ""We'll regroup with our armed fo..." |
| `[273]` | **""Lord help us.""** | `[269]` **Sal Ignacius**: ""We must leave the palace as soo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Sal Ignacius**: ""Halaita."" |
| `[274]` | **""See to it that all who played a part in this are brought to justice. Do I make my..."** | `[262]` **Titus Gordion**: ""In the meantime, we must leave ..."<br>`[269]` **Sal Ignacius**: ""We must leave the palace as soo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Titus Gordion**: ""Yes, Your Majesty. I will make ..."<br>`[279]` **Sal Ignacius**: ""Gladly. I'll make sure of it."" |
| `[328]` | **"Call the guards."** | `[20]` **Narrator**: "And then, out of nowhere, I caug..." | `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`<br>`(Variable["RiziaDLC.Titus_Arrested"] == false) == false` | *Brak zmian stanu* | `[24]` **Narrator**: "It was then that the sound of ro..." |
| `[341]` | **""I will speak to these traitors at once. I refuse to cower in fear!""** | `[115]` **Titus Gordion**: ""What are your orders?"" | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." |
| `[349]` | **""I will address these traitors at once. I refuse to cower in fear!""** | `[120]` **Estela Toras**: ""What are you going to do?""<br>`[350]` **Vina Toras**: ""What are you going to do?"" | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[143]` **Estela Toras**: ""Romus. Please think before you ..." |
| `[387]` | **""Titus!""** | `[20]` **Narrator**: "And then, out of nowhere, I caug..." | `Variable["RiziaDLC.Titus_Arrested"] == false` | *Brak zmian stanu* | `[392]` **Narrator**: "The doors swung open and Captain..." |
| `[423]` | **""This is my wife we're talking about. I'm sure we can reach an understanding.""** | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true` | *Brak zmian stanu* | `[138]` **Titus Gordion**: ""But..."" |
| `[427]` | **""This is my uncle we're talking about. I'm sure we can reach an understanding.""** | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." | `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false` | *Brak zmian stanu* | `[138]` **Titus Gordion**: ""But..."" |
| `[431]` | **""This is my cousin we're talking about. I'm sure we can reach an understanding.""** | `[134]` **Titus Gordion**: ""Are you suggesting we negotiate..." | `Variable["RiziaDLC.Coup_Leader_Rico"] == true`<br>`(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false` | *Brak zmian stanu* | `[138]` **Titus Gordion**: ""But..."" |
| `[432]` | **""Just get me out of here. Now.""** | `[115]` **Titus Gordion**: ""What are your orders?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Titus Gordion**: ""Right away, sir. Follow me."" |
| `[437]` | **""Titus is going to get us all out of here alive. Aren't you, Captain?""** | `[120]` **Estela Toras**: ""What are you going to do?""<br>`[350]` **Vina Toras**: ""What are you going to do?"" | `Variable["RiziaDLC.Titus_Arrested"] == false` | *Brak zmian stanu* | `[433]` **Titus Gordion**: ""Right away, sir. Follow me."" |
| `[438]` | **""Guards! Get us out of here.""** | `[120]` **Estela Toras**: ""What are you going to do?""<br>`[350]` **Vina Toras**: ""What are you going to do?"" | `(Variable["RiziaDLC.Titus_Arrested"] == false) == false` | *Brak zmian stanu* | `[439]` **Narrator**: "My protectors nodded their assen..." |
| `[457]` | **""Get me in contact with Lucita. If my wife knew about this, she'd put an end to it..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "None of the soldiers reacted." |
| `[478]` | **""Hugo. You don't have to do this.""** | `[477]` **Narrator**: "I saw profound regret etched ont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[485]` **Hugo Toras**: ""Believe me, Romus. I wish there..." |
| `[480]` | **""Ricardus. Listen to me. You don't have to do this.""** | `[479]` **Narrator**: "My cousin looked up at me in gri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." |
| `[481]` | **""By order of the King, you and your men will stand down.""** | `[479]` **Narrator**: "My cousin looked up at me in gri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." |
| `[482]` | **"Spit on him."** | `[479]` **Narrator**: "My cousin looked up at me in gri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." |
| `[484]` | **""You've gotten my attention. What do you want?""** | `[479]` **Narrator**: "My cousin looked up at me in gri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." |
| `[486]` | **""By order of the King, you and your men will stand down.""** | `[477]` **Narrator**: "I saw profound regret etched ont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Hugo Toras**: ""Please, Romus... I urge you to ..." |
| `[488]` | **""You've gotten my attention. What do you want?""** | `[477]` **Narrator**: "I saw profound regret etched ont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Hugo Toras**: ""I want what is best for our hou..." |
| `[490]` | **""You bastard. This was your plan all along, wasn't it?""** | `[477]` **Narrator**: "I saw profound regret etched ont..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[485]` **Hugo Toras**: ""Believe me, Romus. I wish there..." |
| `[496]` | **""Come on, Luce. You don't have to do this.""** | `[494]` **Narrator**: "She put a protective hand over h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[500]` **Lucita Azaro**: ""I'm sorry, Romus."" |
| `[497]` | **""Did you ever love me?""** | `[494]` **Narrator**: "She put a protective hand over h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[501]` **Narrator**: "She briefly looked away." |
| `[498]` | **""Bitch. Traitor. You'll burn in hell for this.""** | `[494]` **Narrator**: "She put a protective hand over h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[503]` **Lucita Azaro**: ""Watch your mouth, Toras."" |
| `[499]` | **""You have my attention. What do you want?""** | `[494]` **Narrator**: "She put a protective hand over h..."<br>`[495]` **Narrator**: "Her eyes were stone cold as she ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Lucita Azaro**: ""I believe my men have already t..." |
| `[505]` | **""You don't have to do this, Lucita.""** | `[495]` **Narrator**: "Her eyes were stone cold as she ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Lucita Azaro**: ""Neither do you."" |
| `[507]` | **""By order of the King, you and your men will stand down.""** | `[494]` **Narrator**: "She put a protective hand over h..."<br>`[495]` **Narrator**: "Her eyes were stone cold as she ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[508]` **Lucita Azaro**: ""Your orders mean nothing."" |
| `[511]` | **""You can't usurp me. You can't even walk!""** | `[510]` **Narrator**: "He looked up at me, his eyes stern." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[515]` **Taddeus Azaro**: ""Even half an Azaro is twice the..." |
| `[512]` | **""You've gotten my attention. What do you want?""** | `[510]` **Narrator**: "He looked up at me, his eyes stern." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[516]` **Taddeus Azaro**: ""My men have already told you. F..." |
| `[513]` | **""General. You don't have to do this.""** | `[510]` **Narrator**: "He looked up at me, his eyes stern." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Taddeus Azaro**: ""The time for bargaining is over..." |
| `[514]` | **""By order of the King, you and your men will stand down.""** | `[510]` **Narrator**: "He looked up at me, his eyes stern." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Taddeus Azaro**: ""Your orders don't mean anything..." |
| `[521]` | **""I need your word that you won't hurt my family.""** | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Rico Toras**: ""Don't be ridiculous. Your famil..." |
| `[522]` | **""You couldn't even handle Iza. What makes you fit to rule over a whole kingdom?""** | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Rico Toras**: ""Treasonous words. I have to say..." |
| `[523]` | **""I need your word that you won't hurt my family.""** | `[487]` **Hugo Toras**: ""Please, Romus... I urge you to ..."<br>`[489]` **Hugo Toras**: ""I want what is best for our hou..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Hugo Toras**: ""Your family is my family. Do yo..." |
| `[532]` | **""Was this Hugo's idea?""** | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[534]` **Rico Toras**: ""Before you killed him, you mean?""<br>`[535]` **Rico Toras**: ""House Toras had our doubts abou..." |
| `[533]` | **""I'll die before I bend the knee to you.""** | `[483]` **Rico Toras**: ""Please, cousin. Just cooperate...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Rico Toras**: ""Do you think we have any proble..."<br>`[543]` **Rico Toras**: ""Then you'll die. You have my si..." |
| `[545]` | **""Guards! You heard him. Relinquish your weapons right away!""** | `[544]` **Rico Toras**: ""I'll give you one chance. Tell ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[767]` **Narrator**: "Titus reluctantly signaled to hi..."<br>`[860]` **Narrator**: "Sevrio reluctantly signaled to h..."<br>*(oraz 1 innych odgałęzień)* |
| `[546]` | **""I can't do that.""** | `[544]` **Rico Toras**: ""I'll give you one chance. Tell ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[547]` | **""Why don't you surrender *your* weapons before it's too late?""** | `[544]` **Rico Toras**: ""I'll give you one chance. Tell ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[548]` | **""I'll die before I bend the knee to you.""** | `[487]` **Hugo Toras**: ""Please, Romus... I urge you to ..."<br>`[489]` **Hugo Toras**: ""I want what is best for our hou..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Hugo Toras**: ""You don't mean that. Think of y..." |
| `[552]` | **""I should've killed you along with your son.""** | `[487]` **Hugo Toras**: ""Please, Romus... I urge you to ..."<br>`[489]` **Hugo Toras**: ""I want what is best for our hou..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Rico_Executed"] == true` | *Brak zmian stanu* | `[556]` **Narrator**: "Hugo didn't respond." |
| `[553]` | **""What makes you think you'll be a better king than me? You'll be dead in a few yea..."** | `[487]` **Hugo Toras**: ""Please, Romus... I urge you to ..."<br>`[489]` **Hugo Toras**: ""I want what is best for our hou..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[556]` **Narrator**: "Hugo didn't respond." |
| `[560]` | **""Guards! You heard him. Relinquish your weapons right away!""** | `[559]` **Hugo Toras**: ""I am begging you, my nephew. Te..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[767]` **Narrator**: "Titus reluctantly signaled to hi..."<br>`[860]` **Narrator**: "Sevrio reluctantly signaled to h..."<br>*(oraz 1 innych odgałęzień)* |
| `[561]` | **""I can't do that.""** | `[559]` **Hugo Toras**: ""I am begging you, my nephew. Te..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[562]` | **""Why don't you surrender *your* weapons before it's too late?""** | `[559]` **Hugo Toras**: ""I am begging you, my nephew. Te..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[566]` | **""I take it all back. Our son will inherit the throne after all. Now can we put thi..."** | `[502]` **Lucita Azaro**: ""Please just cooperate. It'll be..."<br>`[509]` **Lucita Azaro**: ""If you know what's best for you..." | `Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true` | *Brak zmian stanu* | `[579]` **Lucita Azaro**: ""It's too late for that."" |
| `[567]` | **""I need your word that you won't hurt my family.""** | `[502]` **Lucita Azaro**: ""Please just cooperate. It'll be..."<br>`[509]` **Lucita Azaro**: ""If you know what's best for you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[580]` **Lucita Azaro**: ""What kind of monster do you thi..."<br>`[584]` **Lucita Azaro**: ""Step down peacefully, and nobod..." |
| `[568]` | **""I should've killed you along with your father.""** | `[502]` **Lucita Azaro**: ""Please just cooperate. It'll be..."<br>`[509]` **Lucita Azaro**: ""If you know what's best for you..." | `Variable["RiziaDLC.Taddeus_Executed"] == true` | *Brak zmian stanu* | `[573]` **Narrator**: "Rage flashed across her face." |
| `[569]` | **""I'll die before I bend the knee to you.""** | `[502]` **Lucita Azaro**: ""Please just cooperate. It'll be..."<br>`[509]` **Lucita Azaro**: ""If you know what's best for you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Lucita Azaro**: ""You don't mean that. I know you.""<br>`[578]` **Lucita Azaro**: ""If that's the way it has to be..."" |
| `[588]` | **""Guards! You heard her. Relinquish your weapons right away!""** | `[587]` **Lucita Azaro**: ""This is your last chance. Tell ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[767]` **Narrator**: "Titus reluctantly signaled to hi..."<br>`[860]` **Narrator**: "Sevrio reluctantly signaled to h..."<br>*(oraz 1 innych odgałęzień)* |
| `[589]` | **""I can't do that.""** | `[587]` **Lucita Azaro**: ""This is your last chance. Tell ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[590]` | **""Why don't you surrender *your* weapons before it's too late?""** | `[587]` **Lucita Azaro**: ""This is your last chance. Tell ..." | `(Variable["RiziaDLC.Lucita_Married"] == true) == false` | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[594]` | **""For the sake of our son, I am begging you to stand down.""** | `[587]` **Lucita Azaro**: ""This is your last chance. Tell ..." | `Variable["RiziaDLC.Lucita_Married"] == true` | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[595]` | **""I need your word that you won't hurt my family.""** | `[516]` **Taddeus Azaro**: ""My men have already told you. F..."<br>`[520]` **Taddeus Azaro**: ""Cooperate with us, and you will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Taddeus Azaro**: ""Step down peacefully, and I swe..." |
| `[596]` | **""I'll die before I bend the knee to you.""** | `[516]` **Taddeus Azaro**: ""My men have already told you. F..."<br>`[520]` **Taddeus Azaro**: ""Cooperate with us, and you will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[607]` **Taddeus Azaro**: ""After what you did to Lucita, y..."<br>`[611]` **Taddeus Azaro**: ""Then you will die."" |
| `[597]` | **""You couldn't even take Pales. What makes you think you can rule the country?""** | `[516]` **Taddeus Azaro**: ""My men have already told you. F..."<br>`[520]` **Taddeus Azaro**: ""Cooperate with us, and you will..." | `Variable["RiziaDLC.War_Pales_Loss"] == true  or  Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true` | *Brak zmian stanu* | `[605]` **Narrator**: "Rage flashed across his face." |
| `[604]` | **""You should've died along with your daughter.""** | `[516]` **Taddeus Azaro**: ""My men have already told you. F..."<br>`[520]` **Taddeus Azaro**: ""Cooperate with us, and you will..." | `Variable["RiziaDLC.Lucita_Executed"] == true` | *Brak zmian stanu* | `[605]` **Narrator**: "Rage flashed across his face." |
| `[615]` | **""Guards! You heard him. Relinquish your weapons right away!""** | `[614]` **Taddeus Azaro**: ""I will give you one chance. Tel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[767]` **Narrator**: "Titus reluctantly signaled to hi..."<br>`[860]` **Narrator**: "Sevrio reluctantly signaled to h..."<br>*(oraz 1 innych odgałęzień)* |
| `[616]` | **""I can't do that.""** | `[614]` **Taddeus Azaro**: ""I will give you one chance. Tel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[617]` | **""Why don't you surrender *your* weapons before it's too late?""** | `[614]` **Taddeus Azaro**: ""I will give you one chance. Tel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[619]` | **""Angelica. You don't have to do this.""** | `[618]` **Narrator**: "She looked up at me, her posture..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Angelica Sazon**: ""You will address me as Duchess."" |
| `[620]` | **""I let you out of prison, and this is how you repay me?""** | `[618]` **Narrator**: "She looked up at me, her posture..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[625]` **Angelica Sazon**: ""Do you truly expect gratitude a..." |
| `[621]` | **""By order of the King, you and your men will stand down.""** | `[618]` **Narrator**: "She looked up at me, her posture..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[626]` **Angelica Sazon**: ""You are no king of mine."" |
| `[622]` | **""You have my attention. What do you want?""** | `[618]` **Narrator**: "She looked up at me, her posture..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Angelica Sazon**: ""You have already been told. Ced..." |
| `[631]` | **""You should've died along with your son.""** | `[627]` **Angelica Sazon**: ""I implore you to cooperate. No ..." | `Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true` | *Brak zmian stanu* | `[645]` **Narrator**: "Her face turned white with rage." |
| `[632]` | **""My father should've killed you along with your husband.""** | `[627]` **Angelica Sazon**: ""I implore you to cooperate. No ..." | `(Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true) == false` | *Brak zmian stanu* | `[645]` **Narrator**: "Her face turned white with rage." |
| `[633]` | **""I need your word that you won't hurt my family.""** | `[627]` **Angelica Sazon**: ""I implore you to cooperate. No ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Angelica Sazon**: ""Of course I won't. My son loves..."<br>`[639]` **Angelica Sazon**: ""I swear to you that nobody will..." |
| `[638]` | **""I'll die before I bend the knee to you.""** | `[627]` **Angelica Sazon**: ""I implore you to cooperate. No ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[640]` **Angelica Sazon**: ""Please. Think of your mother.""<br>`[644]` **Angelica Sazon**: ""Please. Think of your mother. Y..." |
| `[649]` | **""Guards! You heard her. Relinquish your weapons right away!""** | `[648]` **Angelica Sazon**: ""This is your final chance. Tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[767]` **Narrator**: "Titus reluctantly signaled to hi..."<br>`[860]` **Narrator**: "Sevrio reluctantly signaled to h..."<br>*(oraz 1 innych odgałęzień)* |
| `[650]` | **""I can't do that.""** | `[648]` **Angelica Sazon**: ""This is your final chance. Tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[651]` | **""Why don't you surrender *your* weapons before it's too late?""** | `[648]` **Angelica Sazon**: ""This is your final chance. Tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "The officer took another step fo..." |
| `[653]` | **""You wouldn't dare.""** | `[652]` **Narrator**: "The officer took another step fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[669]` **Narrator**: "The man's aim faltered slightly ..."<br>`[670]` **Narrator**: "The man's aim faltered slightly ..."<br>*(oraz 1 innych odgałęzień)* |
| `[679]` | **""That traitor is still out there. I'm going after them.""** | `[215]` **Vina Toras**: ""Father! What do we do?""<br>`[219]` **Estela Toras**: ""Romus! What do we do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[680]` **Estela Toras**: ""To hell with that. We've got to..." |
| `[702]` | **""No time for prayers. Let's get inside.""** | `[701]` **Sal Ignacius**: ""Your Majesty. Thank the Divine ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[710]` **Narrator**: "Together with Sevrio and the gua..." |
| `[703]` | **""Halaita.""** | `[701]` **Sal Ignacius**: ""Your Majesty. Thank the Divine ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[353]` **Narrator**: "The door shut behind us with a d..."<br>`[710]` **Narrator**: "Together with Sevrio and the gua..." |
| `[711]` | **""Thank the Divine for you and the Guardians, Sal.""** | `[701]` **Sal Ignacius**: ""Your Majesty. Thank the Divine ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[710]` **Narrator**: "Together with Sevrio and the gua..." |
| `[736]` | **""It's not over yet. We've got to fight.""** | `[733]` **Estela Toras**: ""But in this particular case, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[744]` **Vina Toras**: ""What's the point, Father? Half ..."<br>`[758]` **Estela Toras**: ""You really don't know when to g..." |
| `[737]` | **""Thanks for remembering Bruno.""** | `[733]` **Estela Toras**: ""But in this particular case, I ..." | `Variable["RiziaDLC.BrunoDog_Adopted"] == true` | *Brak zmian stanu* | `[743]` **Estela Toras**: ""I wasn't about to make the same..." |
| `[741]` | **""Forgive me, Mother. We should have fled when we had the chance.""** | `[733]` **Estela Toras**: ""But in this particular case, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[745]` **Vina Toras**: ""It's not too late. We can still..."<br>`[757]` **Estela Toras**: ""We still have a chance. Don't we?"" |
| `[742]` | **""I'm just happy you're safe.""** | `[733]` **Estela Toras**: ""But in this particular case, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[755]` **Vina Toras**: ""For now. We need to get out of ..."<br>`[756]` **Estela Toras**: ""For now. We need to get out of ..." |
| `[776]` | **""May God have mercy on your soul.""** | `[247]` **Narrator**: "They confidently brandished thei..."<br>`[236]` **Narrator**: "The rebels moved with quick step..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[252]` **Narrator**: "Ignoring my words, they simply s..." |
| `[777]` | **"Get down."** | `[254]` **Narrator**: ""Get down or we'll shoot!" one o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Narrator**: "The rebels moved with quick step..." |
| `[801]` | **"Rico and Hubertus were there with her, ready to protect House Toras at all costs."** | `[794]` **Narrator**: "There was a telegram from Vina, ..." | `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false` | *Brak zmian stanu* | `[23]` **Narrator**: "As I rummaged through the papers..." |
| `[802]` | **"Hubertus was nearby, ready to protect House Toras at all costs -- or so he had said."** | `[794]` **Narrator**: "There was a telegram from Vina, ..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false) == false` | *Brak zmian stanu* | `[23]` **Narrator**: "As I rummaged through the papers..." |
| `[856]` | **""Fine. Get me to the safe room.""** | `[855]` **Sevrio Castellanus**: ""Your Majesty, I really must ins..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`PlaySoundEffect("Gunfight");` | `[208]` **Narrator**: "As we rushed through corridors a..." |

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
  - -> `[877]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Ending their reign with...", "Porte Draz..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "As I entered the study and shifted my gaze toward the window, the sudden extinguishing of the lights at the palace gates drew my attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus_Italic: "Take a closer look."*)
  - -> `[18]` (*Player_Romus_Italic: "Ignore it."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I tossed and turned all night. Despite the exhaustion of a busy day, sleep eluded me entirely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "The sheets felt clammy against my skin, and the soft glow..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "In the hope of clearing my mind, I got out of bed and made my way through the palace corridors to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Narrator: "I exchanged nods with the guards posted outside the Queen..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Before evening fell, I had received news of my sister-in-law's speech at the Alliance of Nations, openly threatening Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "As her ally, I feared the repercussions her actions might..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Despite distancing ourselves from Rumburg, I feared the r..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "As her ally, I feared the repercussions her actions might bring to the Kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "In the hope of clearing my mind, I got out of bed and mad..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Despite distancing ourselves from Rumburg, I feared the repercussions her actions might have on our region of Merkopa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "In the hope of clearing my mind, I got out of bed and mad..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "While she assured me earlier that she didn't intend to go..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "While she assured me earlier that she didn't intend to go to war, her speech was making headlines in Rizia, sparking questions about our position in the event of a conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I knew she desired war from the start. And her unprecedented speech was now making headlines in Rizia, sparking questions about our position in the event of a conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Take a closer look."]** — Mówca: **Player_Romus_Italic**
> "I stood up and approached the window to take a closer look."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I strained to discern anything in the dark, only to reali..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Ignore it."]** — Mówca: **Player_Romus_Italic**
> "Not giving it a second thought, I moved to my desk and started looking through my recent correspondence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vin..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I strained to discern anything in the dark, only to realize that the entire palace gardens had turned pitch-black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "And then, out of nowhere, I caught sight of large shadows hurtling from the gates toward the palace at full speed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus_Italic: "Keep watching."*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Keep watching."]** — Mówca: **Player_Romus_Italic**
> "I kept my eyes fixed on the shapes as they approached."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Several pairs of headlights suddenly pierced the darkness..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Call the guards."]** — Mówca: **Player_Romus_Italic**
> "I stepped outside my chambers and alerted two Wruhec's Guardian sentries."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Theocracy_Full"] == true` AND `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Narrator: "Suddenly, the doors swung open and Sevrio hurried in, vis..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "As I rummaged through the papers on my desk, I heard the hum of engines outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus_Italic: "Look out the window."*)
  - -> `[26]` (*Player_Romus_Italic: "Ignore the noise."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "It was then that the sound of roaring engines filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Turning back toward the window, I saw armored personnel c..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "Look out the window."]** — Mówca: **Player_Romus_Italic**
> "I stood up and moved toward the window to get a closer look."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "Ignore the noise."]** — Mówca: **Player_Romus_Italic**
> "I ignored the noise and kept looking at the letters."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Turning back toward the window, I saw armored personnel carriers with mounted guns. Their headlights were shining straight up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Several pairs of headlights suddenly pierced the darkness. They belonged to armored personnel carriers with mounted guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "All of a sudden, the doors swung open. Sevrio and several Wruhec's Guardians hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Sevrio Castellanus: ""Your Majesty. Forgive me. They surrounded us before we c..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "With an abrupt thud, the doors opened and my guards rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Wearing puzzled expressions, the guards gestured at the v..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Wearing puzzled expressions, the guards gestured at the vehicles outside, specifically pointing to the flags on them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Azaro == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "It was the coat of arms of House Azaro."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Azaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "It was the coat of arms of House Toras."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "It was the coat of arms of House Sazon."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_PoliceChief_PorteDrazon == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Several cars from the Porte Drazon Police Department barr..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_PoliceChief_PorteDrazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "It was the coat of arms of House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Cou..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "It was the coat of arms of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Sazon == true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "It was the coat of arms of House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Coup_Sazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Cou..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_C..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Coup_Sazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Behind the leading vehicles, I also noticed the flags of ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Coup_Sazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Sazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Sazon == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Sazon == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Sazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Sazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Behind the leading vehicles, I also noticed the flags of ..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Sazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Sazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Behind the leading vehicles, I also noticed the flags of ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Sazon == true"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Behind the leading vehicles, I also noticed the flags of House Toras and Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Behind the leading vehicles, I also noticed the flags of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Behind the leading vehicles, I also noticed the flags of House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "As we attempted to figure out what was happening, the guards informed me that their radio had stopped picking up any signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Several cars from the Porte Drazon Police Department barreled through the gates, sirens blaring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Titus anxiously punched a code on his radio and held it to his ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Titus Gordion: ""Nothing. The signal's gone dead.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Don't go anywhere. Stay with me.""*)
  - -> `[60]` (*Player_Romus: ""What do you mean the radio doesn't work? Go and tell the..."*)
  - -> `[61]` (*Player_Romus: ""Go and make sure my mother is safe.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean the radio doesn't work? Go and tell the other guards what's happening! Now!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[408]` (Titus Gordion), `[829]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringGuards = true"*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go and make sure my mother is safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[408]` (Titus Gordion), `[829]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily = true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't go anywhere. Stay with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[408]` (Titus Gordion), `[829]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "The guards, shouting "Yes, Your Majesty," readied their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_GuardsStay = true"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "At that moment, a man outside in full military uniform seized a megaphone and began to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: ""Romus Toras. We have Palas Rezna completely surrounded.""*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_GuardsStay = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Coup_GuardsStay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "At that moment, a man outside in full military uniform se..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> ""Romus Toras. We have Palas Rezna completely surrounded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[67]`
Mówca: **Narrator**
> ""Abdicate the throne to Angelica Sazon, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica = true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Azaro == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Azaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: ""Abdicate the throne to Angelica Sazon, and your life and..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: ""He's just been released from prison, and shall be recogn..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: ""I repeat. If you abdicate, your noble status will be pre..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> ""Abdicate the throne to Lucita Azaro, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita = true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Exec..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Ex..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: ""Abdicate the throne to Lucita Azaro, and your life and n..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: ""Abdicate the throne to Taddeus Azaro, and your life and ..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> ""Abdicate the throne to Taddeus Azaro, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus = true"*)

### Węzeł `[82]`
Mówca: **Narrator**
> ""Abdicate the throne to Hugo Toras, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[83]`
Mówca: **Narrator**
> ""Abdicate the throne to Ricardus Toras, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico = true"*)

### Węzeł `[84]`
Mówca: **Narrator**
> ""He's just been released from prison, and shall be recognized as the true King of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: ""I repeat. If you abdicate, your noble status will be pre..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus < 1"*)
  - -> `[91]` (*Narrator: ""I repeat. If you abdicate, your noble status will be pre..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: ""I'll say it again. If you abdicate, your noble status wi..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: ""I'll say it again. If you abdicate, your noble status wi..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: ""I'll say it again. If you abdicate, your noble status wi..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> ""I'll say it again. If you abdicate, your noble status will be preserved. All we ask is that you step down in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "His words resonated in my skull."*)

### Węzeł `[91]`
Mówca: **Narrator**
> ""I repeat. If you abdicate, your noble status will be preserved. All we ask is that you step down in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "His words resonated in my skull."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Tit..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.T..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "It was at that moment that Titus, accompanied by a group ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "His words resonated in my skull."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Tit..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "The guards cast nervous glances my way, waiting for instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""I'm going to go out and talk to them.""*)
  - -> `[130]` (*Player_Romus: ""We hold our ground, no exceptions. Is that understood? N..."*)
  - -> `[128]` (*Player_Romus: ""You have to get my family out of here this instant. In t..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "While she assured me it was the Sords who were readying f..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I knew she desired war from the start. And her unpreceden..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "While she assured me it was the Sords who were readying for war and not Rumburg, I knew that she wanted to attack Sordland from the start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "And her unprecedented speech was now making headlines in ..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "It was at that moment that Titus, accompanied by a group of guardsmen, rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_BringFamily == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_BringFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "It was at that moment my mother and Vina, accompanied by ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "It was at that moment that my mother, accompanied by the ..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "It was at that moment my mother and Vina, accompanied by the guards, rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras"); AddConversant("Vina Toras");"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "It was at that moment that my mother, accompanied by the guards, rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Titus Gordion: ""Your Majesty!""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");
AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");
AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Estela Toras: ""That's a wrap on your reign, darling. Don't say I didn't..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Estela Toras: ""That's a wrap on your reign, darling. Don't say I didn't..."*)

### Węzeł `[113]`
Mówca: **Titus Gordion**
> ""Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[114]`
Mówca: **Titus Gordion**
> ""The Golden Guard has taken their positions and are prepared to defend the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Titus Gordion: ""What are your orders?""*)

### Węzeł `[115]`
Mówca: **Titus Gordion**
> ""What are your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[125]` (*Player_Romus: ""Good. Tell them to open fire!""*)
  - -> `[126]` (*Player_Romus: ""I don't have a choice. We must listen to the rebels' dem..."*)
  - -> `[432]` (*Player_Romus: ""Just get me out of here. Now.""*)

### Węzeł `[116]`
Mówca: **Estela Toras**
> ""That's a wrap on your reign, darling. Don't say I didn't warn you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Vina Toras: ""Father. Is this really happening?""*)

### Węzeł `[117]`
Mówca: **Estela Toras**
> ""That's a wrap on your reign, darling. Don't say I didn't warn you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Estela Toras: ""Although I imagined something a little more subtle than ..."*)

### Węzeł `[118]`
Mówca: **Vina Toras**
> ""Father. Is this really happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Vina's complexion paled noticeably as she caught sight of..."*)

### Węzeł `[119]`
Mówca: **Estela Toras**
> ""Although I imagined something a little more subtle than this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "Mother's complexion paled noticeably as she regarded the ..."*)

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""What are you going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[123]` (*Player_Romus: ""Nothing. I'm afraid I have no choice but to do as they s..."*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[124]` (*Player_Romus: ""Fight back. Guards! Get in position and open fire!""*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Vina's complexion paled noticeably as she caught sight of the armored vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Vina Toras: ""What are you going to do?""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must address their demands.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[120]` (Estela Toras), `[350]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Estela Toras: ""Romus. Please think before you do or say anything stupid.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing. I'm afraid I have no choice but to do as they say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Estela Toras), `[350]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Estela Toras: ""Romus. Please think before you do or say anything stupid.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fight back. Guards! Get in position and open fire!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Estela Toras), `[350]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Tell them to open fire!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have a choice. We must listen to the rebels' demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""But...""*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me talk to them.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Titus Gordion: ""Are you suggesting we negotiate? I'm sorry, sir, but I d..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have to get my family out of here this instant. In the meantime, I will talk to the soldiers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator), `[447]` (Narrator), `[851]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The soldiers saluted me as I grabbed a coat and walked ou..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm going to go out and talk to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator), `[447]` (Narrator), `[851]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We hold our ground, no exceptions. Is that understood? Now open fire!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator), `[447]` (Narrator), `[851]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringGuards = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Coup_BringGuards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[133]`
Mówca: **Narrator**
> "The soldiers saluted me as I grabbed a coat and walked out on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Upon catching sight of me, the insurgents outside display..."*)

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""Are you suggesting we negotiate? I'm sorry, sir, but I doubt the enemy is receptive to your arguments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[135]` (*Player_Romus: ""Given our limited numbers, we don't stand a chance. Ther..."*)
  - -> `[136]` (*Player_Romus: ""I don't know. However, while they're focusing on me, you..."*)
  - -> `[137]` (*Player_Romus: ""It will buy us time. While their attention is on me, you..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given our limited numbers, we don't stand a chance. There's no other way out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""But...""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. However, while they're focusing on me, you can better assess the situation and determine the best course of action.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire = true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will buy us time. While their attention is on me, you can catch them off guard and ambush them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Titus Gordion: ""Understood, Your Majesty.""*)

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "Titus clenched his jaw, his muscles tensing with determin..."*)

### Węzeł `[139]`
Mówca: **Titus Gordion**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He saluted as I grabbed a coat and stepped out onto the b..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He saluted as I grabbed a coat and stepped out onto the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Upon catching sight of me, the insurgents outside display..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "My mother and daughter watched in wordless terror as I grabbed a coat and stepped out onto the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Upon catching sight of me, the insurgents outside display..."*)

### Węzeł `[143]`
Mówca: **Estela Toras**
> ""Romus. Please think before you do or say anything stupid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: ""Don't worry. I'll be right back.""*)
  - -> `[148]` (*Player_Romus: ""I have to do this to save our family.""*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""Talking to them should distract them long enough for you..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""It's a distraction. While I'm talking to the rebels, Tit..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a distraction. While I'm talking to the rebels, Titus will coordinate everyone's position and commence firing.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire = true"*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to do this to save our family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll be right back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Talking to them should distract them long enough for you to make your escape from the palace. Is that clear?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Upon catching sight of me, the insurgents outside displayed a mix of astonishment and relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[153]` (*Player_Romus: ""Listen carefully. Take your weapons and depart from my p..."*)
  - -> `[171]` (*Player_Romus: ""Stand down. I'm not here to fight.""*)
  - -> `[172]` (*Player_Romus_Italic: "Don't say anything."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen carefully. Take your weapons and depart from my palace, and I will disregard this... misunderstanding. You still have the opportunity to withdraw.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is my cousin? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: ""Where the hell is my cousin? You're carrying out the ord..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""Where the hell is my uncle? You're carrying out the orde..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""Where the hell is Lucita? You're carrying out the orders..."*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""Where the hell is Taddeus? You're carrying out the order..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Where the hell is Angelica? You're carrying out the orde..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is my uncle? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true` AND `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is Lucita? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true` AND `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false` AND `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is Taddeus? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is Angelica? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stand down. I'm not here to fight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "A hush suddenly came over the crowd. The people below me ..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I remained silent, fixing them with a steady gaze."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "A hush suddenly came over the crowd. The people below me ..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "None of the soldiers reacted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "A hush suddenly came over the crowd. The people below me ..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == false"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_ToldToOpenFire == false)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Stop! I surrender. Guards, drop your weapons!""*)
  - -> `[187]` (*Player_Romus: ""Guards! Open fire!""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_ToldToOpenFire == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "At that moment, the stable doors burst open with a thunde..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "The guards within the palace reluctantly dropped their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "In response, the rebels surged forward, their determined ..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "At that moment, the stable doors burst open with a thunderous crash, and two regal horses galloped wildly through the palace gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Soldier! Lower that gun at once! You're pointing your weapon at your king!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[652]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead. Shoot me. You can pry my crown from my cold dead hands!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[652]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == true"*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Soon after, an ear-splitting explosion shattered the tranquility of the courtyard, plunging the rebel soldiers into a panic as a thick cloud of smoke engulfed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "The armored vehicle had been obliterated, leaving behind ..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "I hurled myself back inside as gunshots erupted from every direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Tit..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.T..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Titus seized my arm and dragged me out of the room, rushi..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Nearby guards dragged me out of the room, rushing me thro..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop! I surrender. Guards, drop your weapons!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false`
- **Kontekst wejściowy (poprzednik):** `[669]` (Narrator), `[670]` (Narrator), `[671]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Surrender]"*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! Open fire!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false`
- **Kontekst wejściowy (poprzednik):** `[669]` (Narrator), `[670]` (Narrator), `[671]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "A thunderous barrage erupted as my guards started firing ..."*)

### Węzeł `[188]`
Mówca: **Titus Gordion**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Titus Gordion: ""But first, I need to escort you to a secure location.""*)

### Węzeł `[189]`
Mówca: **Titus Gordion**
> ""But first, I need to escort you to a secure location.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""We have no time. Open fire immediately!""*)
  - -> `[199]` (*Player_Romus: ""Very well. Lead the way.""*)

### Węzeł `[190]`
Mówca: **Narrator**
> "The guards insisted on escorting me to a safe room before initiating the attack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""There's no time. Open fire immediately!""*)
  - -> `[197]` (*Player_Romus_Italic: "Follow them to the safe room."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Vina Toras: ""What? No!""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Estela Toras: ""What? No!""*)

### Węzeł `[194]`
Mówca: **Vina Toras**
> ""What? No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Hearing my orders, the guards opened fire below."*)

### Węzeł `[195]`
Mówca: **Estela Toras**
> ""What? No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Hearing my orders, the guards opened fire below."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no time. Open fire immediately!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator), `[855]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The guards, displaying utmost professionalism, saluted me..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "Follow them to the safe room."]** — Mówca: **Player_Romus_Italic**
> "I heeded their pleas and followed them to the safe room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have no time. Open fire immediately!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "He nodded and gave a series of hand signals."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Lead the way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "He nodded and gave a series of hand signals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "A thunderous barrage erupted as my..."]"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "A thunderous barrage erupted as my..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "A thunderous barrage erupted as my guards started firing ..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "The guards, displaying utmost professionalism, saluted me before taking firing positions around the windows, their guns aimed at the rebels below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[203]`
Mówca: **Narrator**
> "A thunderous barrage erupted as my guards started firing at the soldiers below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "I threw myself to the floor as an ear-splitting explosion..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "A thunderous barrage erupted as my..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "A thunderous barrage erupted as my guards started firing ..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "I threw myself to the floor as an ear-splitting explosion engulfed the courtyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Hearing my orders, the guards opened fire below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "I threw myself to the floor as an e...."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[208]`
Mówca: **Narrator**
> "As we rushed through corridors and descended a back stairwell, the sound of gunshots reverberated from outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "It wasn't until we were deep within the bowels of the pal..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "I threw myself to the floor as an e..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "I threw myself to the floor as an ear-splitting explosion..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_BringFamily == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_BringFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Tit..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "My mother looked at me in shock as the chaos unfolded around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Titus seized my arm and dragged me out of the room, rushing me through the palace corridors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[215]`
Mówca: **Vina Toras**
> ""Father! What do we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[679]` (*Player_Romus: ""That traitor is still out there. I'm going after them.""*)
  - -> `[226]` (*Player_Romus: ""Take cover! We'll wait here until the situation stabiliz..."*)
  - -> `[225]` (*Player_Romus: ""We've got to get you to safety. Let's go.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Vina Toras: ""Father! What do we do?""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Estela Toras: ""Romus! What do we do?""*)

### Węzeł `[219]`
Mówca: **Estela Toras**
> ""Romus! What do we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[679]` (*Player_Romus: ""That traitor is still out there. I'm going after them.""*)
  - -> `[226]` (*Player_Romus: ""Take cover! We'll wait here until the situation stabiliz..."*)
  - -> `[225]` (*Player_Romus: ""We've got to get you to safety. Let's go.""*)

### Węzeł `[220]`
Mówca: **Narrator**
> "Nearby guards dragged me out of the room, rushing me through the palace corridors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[221]`
Mówca: **Narrator**
> "It wasn't until we were deep within the bowels of the palace that the clamor of the battle above gradually subsided."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Before long, we came to a heavy metal door -- the entranc..."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "We could still hear the exchange of gunfire from outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "It wasn't until we were deep within the bowels of the pal..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "It was a simple, fortified space devoid of any luxury, designed solely for one purpose..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Survival."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Before long, we came to a heavy metal door -- the entrance to the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "However, just as the captain extended his hand toward the..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to get you to safety. Let's go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Vina Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take cover! We'll wait here until the situation stabilizes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Vina Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Estela Toras: ""To hell with that. We've got to get to the safe room.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is out of our hands now. We must pray.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[215]` (Vina Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Estela Toras: ""To hell with that. We've got to get to the safe room.""*)

### Węzeł `[228]`
Mówca: **Narrator**
> "However, just as the captain extended his hand toward the handle, a sudden, resounding crash reverberated through the passages."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "Behind us, we heard someone shout, "Everyone down on the ..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "Behind us, we heard someone shout, "Everyone down on the ground!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Glancing back, I saw a group of rebels, each concealed be..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Glancing back, I saw a group of rebels, each concealed behind a mask, aiming their KA-74's at us with deadly precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus_Italic: "Comply."*)
  - -> `[235]` (*Player_Romus_Italic: "Stand still."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Vina and my mother threw themselves to the ground. There ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "My mother threw herself to the ground. There was fear in ..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "Comply."]** — Mówca: **Player_Romus_Italic**
> "With no options left, I pressed my face to the cold floor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaD..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "Stand still."]** — Mówca: **Player_Romus_Italic**
> "I remained still, locking eyes with them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaD..."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "The rebels moved with quick steps, pinning us down, their boots heavy against the backs of our necks. And with a clink of their handcuffs, they secured our wrists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HouseFallouts = true; RiziaDLC.S..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_BringFamily == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_BringFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Vina and my mother threw themselves to the ground. There was fear in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: ""Get down or we'll shoot!" one of the masked men shouted."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "My mother threw herself to the ground. There was fear in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: ""Get down or we'll shoot!" one of the masked men shouted."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Emboldened by my reaction, Titus turned toward them, his ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: ""Get down or we'll shoot!" one of the masked men shouted."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "Emboldened by my reaction, Titus turned toward them, his rifle drawn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: ""Get down or we'll shoot!" one of the masked men shouted."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Upon reaching our location, they swiftly subdued and restrained us, securing our wrists with a click of their handcuffs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "They confidently brandished their weaponry aloft as a tes..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "They confidently brandished their weaponry aloft as a testament to their newfound authority within the palace walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Usurped_HouseFallouts = true; RiziaDLC...."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't necessary. We're not resisting!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Ignoring my words, they simply smiled and escorted us out..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not some petty criminal. Release me from these restraints!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Ignoring my words, they simply smiled and escorted us out..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do what you must.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Ignoring my words, they simply smiled and escorted us out..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One day, you will pay for this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Ignoring my words, they simply smiled and escorted us out..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Ignoring my words, they simply smiled and escorted us outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "As they roughly shoved me into the back of a car, I turne..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[254]`
Mówca: **Narrator**
> ""Get down or we'll shoot!" one of the masked men shouted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Player_Romus_Italic: "Get down."*)
  - -> `[256]` (*Player_Romus_Italic: "Stay standing."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[248]` (*Player_Romus: ""This isn't necessary. We're not resisting!""*)
  - -> `[249]` (*Player_Romus: ""I am not some petty criminal. Release me from these rest..."*)
  - -> `[250]` (*Player_Romus: ""Do what you must.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA: "Stay standing."]** — Mówca: **Player_Romus_Italic**
> "Once again, I refused to comply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "StopMusic();"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[260]`
Mówca: **Titus Gordion**
> ""Good news, Your Majesty. Our communications are active again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Titus Gordion: ""I've just received word that we've identified collaborat..."*)

### Węzeł `[261]`
Mówca: **Titus Gordion**
> ""I've just received word that we've identified collaborators among the rebels as well as their locations. Our forces are ready to respond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Titus Gordion: ""In the meantime, we must leave the palace as soon as the..."*)

### Węzeł `[262]`
Mówca: **Titus Gordion**
> ""In the meantime, we must leave the palace as soon as the perimeter is secured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""See to it that all who played a part in this are brought..."*)
  - -> `[271]` (*Player_Romus: ""Are you certain we can clear the perimeter? There were t..."*)
  - -> `[272]` (*Player_Romus: ""Where will we go?""*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true )"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Sal, Sevrio and a number of Wruhec's Guardians were huddl..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Sal, Sevrio and a number of Wruhec's Guardians were huddled in a corner, conversing. They turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Sevrio Castellanus: ""You'll be pleased to know that our communications are ac..."*)

### Węzeł `[267]`
Mówca: **Sevrio Castellanus**
> ""I've just been informed that collaborators among the rebels have been identified, along with their locations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Sevrio Castellanus: ""Wruhec's Guardians stand ready to respond, bringing the ..."*)

### Węzeł `[268]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians stand ready to respond, bringing the wrath of God in their wake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Sal Ignacius: ""We must leave the palace as soon as the perimeter is cle..."*)

### Węzeł `[269]`
Mówca: **Sal Ignacius**
> ""We must leave the palace as soon as the perimeter is cleared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""See to it that all who played a part in this are brought..."*)
  - -> `[271]` (*Player_Romus: ""Are you certain we can clear the perimeter? There were t..."*)
  - -> `[272]` (*Player_Romus: ""Where will we go?""*)
  - -> `[273]` (*Player_Romus: ""Lord help us.""*)

### Węzeł `[270]`
Mówca: **Sevrio Castellanus**
> ""You'll be pleased to know that our communications are active again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Sevrio Castellanus: ""I've just been informed that collaborators among the reb..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you certain we can clear the perimeter? There were tanks stationed outside the palace!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Titus Gordion), `[269]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where will we go?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Titus Gordion), `[269]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lord help us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Sal Ignacius: ""Halaita.""*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See to it that all who played a part in this are brought to justice. Do I make myself clear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Titus Gordion), `[269]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Titus Gordion: ""Yes, Your Majesty. I will make sure of it.""*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Sal Ignacius: ""Gladly. I'll make sure of it.""*)

### Węzeł `[278]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[279]`
Mówca: **Sal Ignacius**
> ""Gladly. I'll make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[280]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Titus Gordion: ""We'll regroup with our armed forces, who can provide us ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Sal Ignacius: ""We'll regroup with our armed forces, who can provide us ..."*)

### Węzeł `[284]`
Mówca: **Titus Gordion**
> ""We'll regroup with our armed forces, who can provide us with enhanced protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Titus Gordion: ""We must avoid any other encounters with the rebels until..."*)

### Węzeł `[285]`
Mówca: **Sal Ignacius**
> ""We'll regroup with our armed forces, who can provide us with enhanced protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Sal Ignacius: ""We must avoid any other encounters with the rebels until..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Titus Gordion: ""My guards are equipped to withstand a professional force..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Sevrio Castellanus: ""Wruhec's Guardians are capable of resisting a profession..."*)

### Węzeł `[289]`
Mówca: **Titus Gordion**
> ""My guards are equipped to withstand a professional force significantly larger than their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Titus Gordion: ""This includes anti-tank and anti-air capabilities. I ass..."*)

### Węzeł `[290]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians are capable of resisting a professional force much larger than their size.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[291]`
Mówca: **Titus Gordion**
> ""This includes anti-tank and anti-air capabilities. I assure you, there's no need for concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "After a few minutes, the clamor from the recent skirmish between the rebels and palace guards outside gradually subsided."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "The guards informed us that the perimeter was momentarily..."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "I embraced my mother and daughter. Together, we emerged from the safety of our underground stronghold and returned to the surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina = true"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "After hugging my mother, we emerged from the safety of our underground stronghold, returning to the surface together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Coup_Survived_WithEstela = true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "I embraced my mother and daughter. Together, we emerged f..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "After hugging my mother, we emerged from the safety of ou..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "The guards informed us that the perimeter was momentarily secured and that we had a window of opportunity to evacuate the palace. It was now or never."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "There was no telling when the enemy would regroup and ret..."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "As we stepped into the courtyard, I beheld the once immaculate garden strewn with the scattered remnants of armored vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "The ground was littered with bodies, shattered weapons, a..."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "The ground was littered with bodies, shattered weapons, and fragments of uniforms, making it difficult to navigate without stepping on them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "Before long, our escort brought us to an armored truck th..."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "Before long, our escort brought us to an armored truck that would transport us to safety."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "Despite surviving tonight's attack, I knew this was just ..."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "Despite surviving tonight's attack, I knew this was just the beginning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "The culprit behind it all was still out there."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[304]`
Mówca: **Narrator**
> "The culprit behind it all was still out there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_HouseFallouts = true; RiziaDLC..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Breather", "R_Breather_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CoupWarning_BoatCancelled == false"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "And then, out of nowhere, I caught sight of large shadows..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Several pairs of headlights suddenly pierced the darkness..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "After a few minutes, the clamor from the recent skirmish ..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Without a moment of hesitation, he discharged his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SkipToEpilogue = true; RiziaDLC.Epilogue_Death_H..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Death_HouseFallouts = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Death_HouseFallouts"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Without a moment of hesitation, he..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Without a moment of hesitation, he discharged his firearm."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_HouseFallouts = true; RiziaDLC.SkipToEpilogue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Survived_HouseFallouts"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Usurped_HouseFallouts = true; RiziaDLC.SkipToEpilogue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Usurped_HouseFallouts"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HouseFallouts = true; RiziaDLC.SkipToEpilogue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Prison_HouseFallouts"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "As we stepped into the courtyard, I beheld the once immac..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Coup_Survived_WithEstela = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "As we stepped into the courtyard, I beheld the once immac..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Explosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Explosion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "A thunderous barrage erupted as my..."]"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Explosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Soon after, an ear-splitting explosion shattered the tran..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "My mother looked at me in shock as the chaos unfolded aro..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "We could still hear the exchange of gunfire from outside."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "As we rushed through corridors and descended a back stair..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CoupGunshot");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CoupGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Without a moment of hesitation, he discharged his firearm."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `StopMusic();`
- **Efekt skryptowy (`userScript`):** `StopMusic();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CoupGunshot");"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus_Italic: "Call the guards."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player_Romus_Italic: "Call the guards."*)

### Węzeł `[328]`
**[WYBÓR GRACZA: "Call the guards."]** — Mówca: **Player_Romus_Italic**
> "I stepped outside my chambers and alerted two Golden Guard sentries."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false` AND `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "It was then that the sound of roaring engines filled the ..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "All of a sudden, the doors swung open. Sevrio and several..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "All of a sudden, the doors swung open, and several Golden..."*)

### Węzeł `[332]`
Mówca: **Narrator**
> "All of a sudden, the doors swung open, and several Golden Guardsmen hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "It was then that the sound of roaring engines filled the ..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Titus Gordion: ""Wruhec's Guardians have taken their positions and are pr..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Titus Gordion: ""The Golden Guard has taken their positions and are prepa..."*)

### Węzeł `[336]`
Mówca: **Titus Gordion**
> ""Wruhec's Guardians have taken their positions and are prepared to defend the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Titus Gordion: ""What are your orders?""*)

### Węzeł `[337]`
Mówca: **Narrator**
> "And her unprecedented speech was now making headlines in Rizia, sparking questions about our position in the event of a conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player_Romus: ""I will speak to these traitors at once. I refuse to cowe..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""Let me talk to them.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will speak to these traitors at once. I refuse to cower in fear!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[115]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Titus Gordion: ""Are you suggesting we negotiate? I'm sorry, sir, but I d..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "Titus clenched his jaw, his muscles tensing with determination. After a second, he reluctantly nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[343]`
Mówca: **Titus Gordion**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire = true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He saluted as I grabbed a coat and stepped out onto the b..."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "Mother's complexion paled noticeably as she regarded the armored vehicles outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Estela Toras: ""What are you going to do?""*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: ""I will address these traitors at once. I refuse to cower..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""I must address their demands.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will address these traitors at once. I refuse to cower in fear!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[120]` (Estela Toras), `[350]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Estela Toras: ""Romus. Please think before you do or say anything stupid.""*)

### Węzeł `[350]`
Mówca: **Vina Toras**
> ""What are you going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[123]` (*Player_Romus: ""Nothing. I'm afraid I have no choice but to do as they s..."*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[124]` (*Player_Romus: ""Fight back. Guards! Get in position and open fire!""*)

### Węzeł `[351]`
Mówca: **Narrator**
> "The armored vehicle had been obliterated, leaving behind a scene of blood and metal strewn across the cobblestone. My would-be usurper disappeared into the haze, surrounded by a cordon of guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "I hurled myself back inside as gunshots erupted from ever..."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "In response, the rebels surged forward, their determined strides echoing through the halls as they breached the once-secure threshold of the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Upon reaching our location, they swiftly subdued and rest..."*)

### Węzeł `[353]`
Mówca: **Narrator**
> "The door shut behind us with a definitive clang, sealing us off from the outside world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "It was a simple, fortified space devoid of any luxury, de..."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "Survival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == false"*)

### Węzeł `[355]`
Mówca: **Titus Gordion**
> ""We must avoid any other encounters with the rebels until loyalist troops can intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[356]`
Mówca: **Sal Ignacius**
> ""We must avoid any other encounters with the rebels until loyalist troops, guided by Divine providence, can intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[357]`
Mówca: **Narrator**
> "There was no telling when the enemy would regroup and return for another assault."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[358]`
Mówca: **Narrator**
> "The sheets felt clammy against my skin, and the soft glow of the moon through the curtains offered no solace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "Every creak of the floorboards and rustle of the wind out..."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "Every creak of the floorboards and rustle of the wind outside seemed to amplify in the stillness of the night, further unsettling my restless mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Before evening fell, I had received news of my sister-in-..."*)

### Węzeł `[360]`
Mówca: **Narrator**
> "I tossed and turned all night. Despite my utter exhaustion, sleep eluded me entirely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "The sheets felt clammy against my skin, and the soft glow..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CoupWarning_BoatCancelled == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CoupWarning_BoatCancelled == false"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CoupWarning_BoatCancelled == false)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CoupWarning_BoatCancelled == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CoupWarning_BoatCancelled"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I tossed and turned all night. Despite the exhaustion of ..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CoupWarning_BoatCancelled == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CoupWarning_BoatCancelled"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "I tossed and turned all night. Despite my utter exhaustio..."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "The sheets felt clammy against my skin, and the soft glow of the moon through the curtains offered no solace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[365]`
Mówca: **Narrator**
> "Each creak of the floorboards and rustle of the wind outside seemed to amplify in the stillness of the night, setting off alarms in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "They were coming for me. Or were they?"*)

### Węzeł `[366]`
Mówca: **Narrator**
> "They were coming for me. Or were they?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "Bruno had abandoned his usual resting spot and was pacing..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "Each creak of the floorboards and rustle of the wind outs..."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "Bruno had abandoned his usual resting spot and was pacing back and forth in front of the door, as he'd begun doing every night since my mother's warning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "Each creak of the floorboards and rustle of the wind outs..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "In the hope of distracting myself, I got out of bed and made my way through the palace corridors to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Narrator: "I exchanged nods with the guards posted outside the Queen..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "I had told Pabel to lay low on his estate until the threa..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_..."*)

### Węzeł `[375]`
Mówca: **Narrator**
> "I had told Pabel to lay low on his estate until the threat blew over. The palace felt empty without him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "In the hope of distracting myself, I got out of bed and m..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_..."*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabe..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] > 2  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "I had told Pabel to lay low at a friend's place in the ca..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] > 2  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[379]`
Mówca: **Narrator**
> "I had told Pabel to lay low at a friend's place in the capital until the threat blew over. The palace felt empty without him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "In the hope of distracting myself, I got out of bed and m..."*)

### Węzeł `[380]`
Mówca: **Narrator**
> "Lucita had called me from the hospital, telling me she had experienced some premature contractions and was being kept overnight for observation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Narrator: "The palace felt empty without her, but at least she would..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "Lucita had called me from the hospital, telling me she ha..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "In the hope of distracting myself, I got out of bed and m..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Player_Romus: ""Titus!""*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "The doors swung open and Captain Gordion burst in."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "All of a sudden, the doors swung open and Titus hurried i..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[391]`
Mówca: **Narrator**
> "All of a sudden, the doors swung open and Titus hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Titus Gordion: ""Your Majesty. Forgive me. They surrounded us before we c..."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "The doors swung open and Captain Gordion burst in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Titus Gordion: ""Your Majesty. Forgive me. They surrounded us before we c..."*)

### Węzeł `[393]`
Mówca: **Titus Gordion**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "It was then that the sound of roaring engines filled the ..."*)

### Węzeł `[394]`
Mówca: **Narrator**
> "As he stared out the window, Titus' eyes widened in horror. I followed his gaze to the flag mounted on the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "As he stared out the window, Titus' eyes widened in horro..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "Wearing puzzled expressions, the guards gestured outside...."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "Wearing puzzled expressions, the guards gestured outside. I followed their gaze to the flag mounted on the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "With an abrupt thud, the doors opened and Titus rushed in."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[402]`
Mówca: **Narrator**
> "With an abrupt thud, the doors opened and Titus rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Titus Gordion: ""Your Majesty. Forgive me. They surrounded us before we c..."*)

### Węzeł `[403]`
Mówca: **Titus Gordion**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Titus Gordion: ""Wait. Is that what I think it is?""*)

### Węzeł `[404]`
Mówca: **Titus Gordion**
> ""Wait. Is that what I think it is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Narrator: "As he stared out the window, Sevrio's eyes widened in hor..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Titus anxiously punched a code on his radio and held it t..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[408]`
Mówca: **Titus Gordion**
> ""Nothing. The signal's gone dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Titus Gordion: ""I will, Your Majesty.""*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[412]`
Mówca: **Titus Gordion**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_GuardsStay = true"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Titus Gordion: ""Of course, Your Majesty. I'll be back in an instant.""*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[416]`
Mówca: **Titus Gordion**
> ""Of course, Your Majesty. I'll be back in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "Titus bowed and rushed out."*)

### Węzeł `[417]`
Mówca: **Narrator**
> ""Yes, Your Majesty," the guards shouted as they rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "At that moment, a man outside in full military uniform se..."*)

### Węzeł `[418]`
Mówca: **Narrator**
> "Titus bowed and rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Sevr..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "At that moment, a man outside in full military uniform se..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: ""This is my wife we're talking about. I'm sure we can rea..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is my wife we're talking about. I'm sure we can reach an understanding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[134]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""But...""*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player_Romus: ""This is my uncle we're talking about. I'm sure we can re..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is my uncle we're talking about. I'm sure we can reach an understanding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""But...""*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Player_Romus: ""This is my cousin we're talking about. I'm sure we can r..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is my cousin we're talking about. I'm sure we can reach an understanding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true` AND `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""But...""*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just get me out of here. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Titus Gordion: ""Right away, sir. Follow me.""*)

### Węzeł `[433]`
Mówca: **Titus Gordion**
> ""Right away, sir. Follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""Titus is going to get us all out of here alive. Aren't y..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Player_Romus: ""Guards! Get us out of here.""*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is going to get us all out of here alive. Aren't you, Captain?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[120]` (Estela Toras), `[350]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Titus Gordion: ""Right away, sir. Follow me.""*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! Get us out of here.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[120]` (Estela Toras), `[350]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Narrator: "My protectors nodded their assent and motioned for us to ..."*)

### Węzeł `[439]`
Mówca: **Narrator**
> "My protectors nodded their assent and motioned for us to follow them to the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "My mother and daughter watched in wordless terror as I gr..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "My mother watched in wordless terror as I grabbed a coat ..."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "My mother watched in wordless terror as I grabbed a coat and stepped out onto the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Upon catching sight of me, the insurgents outside display..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Narrator: "Titus cast an agitated glance my way, waiting for my inst..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[447]`
Mówca: **Narrator**
> "Titus cast an agitated glance my way, waiting for my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""I'm going to go out and talk to them.""*)
  - -> `[130]` (*Player_Romus: ""We hold our ground, no exceptions. Is that understood? N..."*)
  - -> `[128]` (*Player_Romus: ""You have to get my family out of here this instant. In t..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == false"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The soldiers saluted me as I grabbed a coat and walked ou..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player_Romus: ""Get me in contact with Lucita. If my wife knew about thi..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get me in contact with Lucita. If my wife knew about this, she'd put an end to it immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "None of the soldiers reacted."*)

### Węzeł `[458]`
Mówca: **Narrator**
> "A hush suddenly came over the crowd. The people below me parted ways as a heavily armored car slowly made its way through the throng."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Narrator: "It rolled over the garden's succulents and rose bushes wi..."*)

### Węzeł `[459]`
Mówca: **Narrator**
> "It rolled over the garden's succulents and rose bushes with a series of sickening crunches before coming to a halt in front of the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[460]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. The back door opened, and Rico stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Narrator: "My cousin looked up at me in grim satisfaction."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "The soldiers formed a protective circle around the vehicl..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "The soldiers formed a protective circle around the vehicl..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[467]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. The back door opened, and Hugo stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "I saw profound regret etched onto my uncle's face."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Narrator: "The soldiers formed a protective circle around the vehicl..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[471]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. One of them opened the back door, and Lucita stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Narrator: "The soldiers formed a protective circle around the vehicl..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Narrator: "The soldiers formed a protective circle around the vehicl..."*)

### Węzeł `[475]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. One of them brought a wheelchair around to the back door and helped General Taddeus into it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "He looked up at me, his eyes stern."*)

### Węzeł `[476]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. One of them opened the back door, and Angelica Sazon stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Narrator: "She looked up at me, her posture rigid."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "I saw profound regret etched onto my uncle's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""Hugo. You don't have to do this.""*)
  - -> `[486]` (*Player_Romus: ""By order of the King, you and your men will stand down.""*)
  - -> `[488]` (*Player_Romus: ""You've gotten my attention. What do you want?""*)
  - -> `[490]` (*Player_Romus: ""You bastard. This was your plan all along, wasn't it?""*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo. You don't have to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Hugo Toras: ""Believe me, Romus. I wish there was another way.""*)

### Węzeł `[479]`
Mówca: **Narrator**
> "My cousin looked up at me in grim satisfaction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Player_Romus: ""Ricardus. Listen to me. You don't have to do this.""*)
  - -> `[481]` (*Player_Romus: ""By order of the King, you and your men will stand down.""*)
  - -> `[482]` (*Player_Romus_Italic: "Spit on him."*)
  - -> `[484]` (*Player_Romus: ""You've gotten my attention. What do you want?""*)

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ricardus. Listen to me. You don't have to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Rico Toras: ""Please, cousin. Just cooperate. It'll be so much easier ..."*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Rico Toras: ""Please, cousin. Just cooperate. It'll be so much easier ..."*)

### Węzeł `[482]`
**[WYBÓR GRACZA: "Spit on him."]** — Mówca: **Player_Romus_Italic**
> "I spit off the balcony, aiming for Rico's face. His guards shielded him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Rico Toras: ""Please, cousin. Just cooperate. It'll be so much easier ..."*)

### Węzeł `[483]`
Mówca: **Rico Toras**
> ""Please, cousin. Just cooperate. It'll be so much easier that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[532]` (*Player_Romus: ""Was this Hugo's idea?""*)
  - -> `[522]` (*Player_Romus: ""You couldn't even handle Iza. What makes you fit to rule..."*)
  - -> `[533]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten my attention. What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Rico Toras: ""Please, cousin. Just cooperate. It'll be so much easier ..."*)

### Węzeł `[485]`
Mówca: **Hugo Toras**
> ""Believe me, Romus. I wish there was another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Hugo Toras: ""Please just cooperate with us.""*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Hugo Toras: ""Please, Romus... I urge you to cooperate. You must know ..."*)

### Węzeł `[487]`
Mówca: **Hugo Toras**
> ""Please, Romus... I urge you to cooperate. You must know you're outnumbered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[548]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)
  - -> `[553]` (*Player_Romus: ""What makes you think you'll be a better king than me? Yo..."*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten my attention. What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Hugo Toras: ""I want what is best for our house, Romus. Please just co..."*)

### Węzeł `[489]`
Mówca: **Hugo Toras**
> ""I want what is best for our house, Romus. Please just cooperate with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[548]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)
  - -> `[553]` (*Player_Romus: ""What makes you think you'll be a better king than me? Yo..."*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You bastard. This was your plan all along, wasn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Hugo Toras: ""Believe me, Romus. I wish there was another way.""*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Narrator: "She put a protective hand over her belly as she looked up..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Narrator: "Her eyes were stone cold as she looked up at me."*)

### Węzeł `[494]`
Mówca: **Narrator**
> "She put a protective hand over her belly as she looked up at me. I saw sadness in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Player_Romus: ""Come on, Luce. You don't have to do this.""*)
  - -> `[497]` (*Player_Romus: ""Did you ever love me?""*)
  - -> `[498]` (*Player_Romus: ""Bitch. Traitor. You'll burn in hell for this.""*)
  - -> `[499]` (*Player_Romus: ""You have my attention. What do you want?""*)
  - -> `[507]` (*Player_Romus: ""By order of the King, you and your men will stand down.""*)

### Węzeł `[495]`
Mówca: **Narrator**
> "Her eyes were stone cold as she looked up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Player_Romus: ""You have my attention. What do you want?""*)
  - -> `[505]` (*Player_Romus: ""You don't have to do this, Lucita.""*)
  - -> `[507]` (*Player_Romus: ""By order of the King, you and your men will stand down.""*)

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Luce. You don't have to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Lucita Azaro: ""I'm sorry, Romus.""*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you ever love me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "She briefly looked away."*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bitch. Traitor. You'll burn in hell for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Lucita Azaro: ""Watch your mouth, Toras.""*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my attention. What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator), `[495]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Lucita Azaro: ""I believe my men have already told you.""*)

### Węzeł `[500]`
Mówca: **Lucita Azaro**
> ""I'm sorry, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Lucita Azaro: ""Please just cooperate. It'll be easier for all of us.""*)

### Węzeł `[501]`
Mówca: **Narrator**
> "She briefly looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Lucita Azaro: ""I'm sorry, Romus.""*)

### Węzeł `[502]`
Mówca: **Lucita Azaro**
> ""Please just cooperate. It'll be easier for all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Marrie..."*)
  - -> `[569]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[503]`
Mówca: **Lucita Azaro**
> ""Watch your mouth, Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Lucita Azaro: ""If you know what's best for you, you'll cooperate.""*)

### Węzeł `[504]`
Mówca: **Lucita Azaro**
> ""I believe my men have already told you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Lucita Azaro: ""Please just cooperate. It'll be easier for all of us.""*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to do this, Lucita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Lucita Azaro: ""Neither do you.""*)

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""Neither do you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Lucita Azaro: ""Please just cooperate. It'll be easier for all of us.""*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator), `[495]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Lucita Azaro: ""Your orders mean nothing.""*)

### Węzeł `[508]`
Mówca: **Lucita Azaro**
> ""Your orders mean nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Lucita Azaro: ""If you know what's best for you, you'll cooperate.""*)

### Węzeł `[509]`
Mówca: **Lucita Azaro**
> ""If you know what's best for you, you'll cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Marrie..."*)
  - -> `[569]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)

### Węzeł `[510]`
Mówca: **Narrator**
> "He looked up at me, his eyes stern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Player_Romus: ""You can't usurp me. You can't even walk!""*)
  - -> `[512]` (*Player_Romus: ""You've gotten my attention. What do you want?""*)
  - -> `[513]` (*Player_Romus: ""General. You don't have to do this.""*)
  - -> `[514]` (*Player_Romus: ""By order of the King, you and your men will stand down.""*)

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't usurp me. You can't even walk!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Taddeus Azaro: ""Even half an Azaro is twice the king you'll ever be, Tor..."*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten my attention. What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Taddeus Azaro: ""My men have already told you. Forsake your title and ced..."*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""General. You don't have to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Taddeus Azaro: ""The time for bargaining is over, Toras.""*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[510]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Taddeus Azaro: ""Your orders don't mean anything anymore.""*)

### Węzeł `[515]`
Mówca: **Taddeus Azaro**
> ""Even half an Azaro is twice the king you'll ever be, Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Taddeus Azaro: ""Cooperate with us, and you will be spared.""*)

### Węzeł `[516]`
Mówca: **Taddeus Azaro**
> ""My men have already told you. Forsake your title and cede the throne to House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[596]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_N..."*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)

### Węzeł `[517]`
Mówca: **Hugo Toras**
> ""Please just cooperate with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[548]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)
  - -> `[553]` (*Player_Romus: ""What makes you think you'll be a better king than me? Yo..."*)

### Węzeł `[518]`
Mówca: **Taddeus Azaro**
> ""Your orders don't mean anything anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Taddeus Azaro: ""Cooperate with us, and you will be spared.""*)

### Węzeł `[519]`
Mówca: **Taddeus Azaro**
> ""The time for bargaining is over, Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Taddeus Azaro: ""Cooperate with us, and you will be spared.""*)

### Węzeł `[520]`
Mówca: **Taddeus Azaro**
> ""Cooperate with us, and you will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[596]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_N..."*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Rico Toras: ""Don't be ridiculous. Your family is my family.""*)

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You couldn't even handle Iza. What makes you fit to rule over a whole kingdom?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Rico Toras: ""Treasonous words. I have to say you're not off to a good..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Hugo Toras), `[489]` (Hugo Toras), `[517]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Hugo Toras: ""Your family is my family. Do you really believe me capab..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Rico Toras: ""Before you killed him, you mean?""*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Rico Toras: ""House Toras had our doubts about you from the start. All..."*)

### Węzeł `[527]`
Mówca: **Rico Toras**
> ""Don't be ridiculous. Your family is my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[528]`
Mówca: **Rico Toras**
> ""We won't even lay a finger on your husband. Wife? Whatever you people call it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "He nodded to one of his officers. The man strode towards ..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Rico Toras: ""We won't even lay a finger on your husband. Wife? Whatev..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "He nodded to one of his officers. The man strode towards ..."*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this Hugo's idea?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)

### Węzeł `[534]`
Mówca: **Rico Toras**
> ""Before you killed him, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Rico Toras: ""House Toras had our doubts about you from the start. All..."*)

### Węzeł `[535]`
Mówca: **Rico Toras**
> ""House Toras had our doubts about you from the start. All you've done since then is prove us right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "He nodded to one of his officers. The man strode towards ..."*)

### Węzeł `[536]`
Mówca: **Rico Toras**
> ""Treasonous words. I have to say you're not off to a good start with the new regime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "He nodded to one of his officers. The man strode towards ..."*)

### Węzeł `[537]`
Mówca: **Rico Toras**
> ""Do you think we have any problem with killing you? After what you did to my father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "He nodded to one of his officers. The man strode towards ..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == true)"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Rico Toras: ""Do you think we have any problem with killing you? After..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Rico Toras: ""Then you'll die. You have my sincerest apologies.""*)

### Węzeł `[541]`
Mówca: **Narrator**
> "As his officer took up a position directly beneath the balcony, Rico spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Rico Toras: ""I'll give you one chance. Tell your guards to surrender ..."*)

### Węzeł `[542]`
Mówca: **Narrator**
> "He nodded to one of his officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Narrator: "As his officer took up a position directly beneath the ba..."*)

### Węzeł `[543]`
Mówca: **Rico Toras**
> ""Then you'll die. You have my sincerest apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "He nodded to one of his officers. The man strode towards ..."*)

### Węzeł `[544]`
Mówca: **Rico Toras**
> ""I'll give you one chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Player_Romus: ""Guards! You heard him. Relinquish your weapons right away!""*)
  - -> `[546]` (*Player_Romus: ""I can't do that.""*)
  - -> `[547]` (*Player_Romus: ""Why don't you surrender *your* weapons before it's too l..."*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard him. Relinquish your weapons right away!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[544]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Surrender]"*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[544]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[544]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Hugo Toras), `[489]` (Hugo Toras), `[517]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Hugo Toras: ""You don't mean that. Think of your mother. She'll die of..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == true"*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == true )"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Player_Romus: ""I should've killed you along with your son.""*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should've killed you along with your son.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[487]` (Hugo Toras), `[489]` (Hugo Toras), `[517]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Narrator: "Hugo didn't respond."*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think you'll be a better king than me? You'll be dead in a few years anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Hugo Toras), `[489]` (Hugo Toras), `[517]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Narrator: "Hugo didn't respond."*)

### Węzeł `[554]`
Mówca: **Hugo Toras**
> ""Your family is my family. Do you really believe me capable of such cruelty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[555]`
Mówca: **Hugo Toras**
> ""You don't mean that. Think of your mother. She'll die of a broken heart if she loses you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[556]`
Mówca: **Narrator**
> "Hugo didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[557]`
Mówca: **Narrator**
> "As his officer took up a position directly beneath the balcony, Hugo spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Hugo Toras: ""I am begging you, my nephew. Tell your guards to surrend..."*)

### Węzeł `[558]`
Mówca: **Narrator**
> "He motioned to one of his officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Narrator: "As his officer took up a position directly beneath the ba..."*)

### Węzeł `[559]`
Mówca: **Hugo Toras**
> ""I am begging you, my nephew. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player_Romus: ""Guards! You heard him. Relinquish your weapons right away!""*)
  - -> `[561]` (*Player_Romus: ""I can't do that.""*)
  - -> `[562]` (*Player_Romus: ""Why don't you surrender *your* weapons before it's too l..."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard him. Relinquish your weapons right away!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[559]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Surrender]"*)

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[559]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[559]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Marrie..."*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Marr..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Player_Romus: ""I take it all back. Our son will inherit the throne afte..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I take it all back. Our son will inherit the throne after all. Now can we put this nonsense behind us?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Kontekst wejściowy (poprzednik):** `[502]` (Lucita Azaro), `[509]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Lucita Azaro: ""It's too late for that.""*)

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Lucita Azaro), `[509]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should've killed you along with your father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[502]` (Lucita Azaro), `[509]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Narrator: "Rage flashed across her face."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Lucita Azaro), `[509]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true"*)
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true)"*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player_Romus: ""I should've killed you along with your father.""*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[573]`
Mówca: **Narrator**
> "Rage flashed across her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[574]`
Mówca: **Lucita Azaro**
> ""You don't mean that. I know you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Lucita Azaro: ""You don't mean that. I know you.""*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Lucita Azaro: ""If that's the way it has to be...""*)

### Węzeł `[578]`
Mówca: **Lucita Azaro**
> ""If that's the way it has to be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[579]`
Mówca: **Lucita Azaro**
> ""It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[580]`
Mówca: **Lucita Azaro**
> ""What kind of monster do you think I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Lucita Azaro: ""Step down peacefully, and nobody will be harmed.""*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Lucita Azaro: ""What kind of monster do you think I am?""*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Lucita Azaro: ""Step down peacefully, and nobody will be harmed.""*)

### Węzeł `[584]`
Mówca: **Lucita Azaro**
> ""Step down peacefully, and nobody will be harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[585]`
Mówca: **Narrator**
> "As the officer took up a position directly beneath the balcony, Lucita spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Lucita Azaro: ""This is your last chance. Tell your guards to surrender ..."*)

### Węzeł `[586]`
Mówca: **Narrator**
> "She motioned to one of her officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Narrator: "As the officer took up a position directly beneath the ba..."*)

### Węzeł `[587]`
Mówca: **Lucita Azaro**
> ""This is your last chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Player_Romus: ""Guards! You heard her. Relinquish your weapons right away!""*)
  - -> `[589]` (*Player_Romus: ""I can't do that.""*)
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard her. Relinquish your weapons right away!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Surrender]"*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[587]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Player_Romus: ""For the sake of our son, I am begging you to stand down.""*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Player_Romus: ""Why don't you surrender *your* weapons before it's too l..."*)

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the sake of our son, I am begging you to stand down.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Kontekst wejściowy (poprzednik):** `[587]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Taddeus Azaro), `[520]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Taddeus Azaro: ""Step down peacefully, and I swear on my ancestors' grave..."*)

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Taddeus Azaro), `[520]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)

### Węzeł `[597]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You couldn't even take Pales. What makes you think you can rule the country?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Loss"] == true  or  Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Kontekst wejściowy (poprzednik):** `[516]` (Taddeus Azaro), `[520]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "Rage flashed across his face."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_N..."*)
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome..."*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Loss"] == true  or  Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Player_Romus: ""You couldn't even take Pales. What makes you think you c..."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Loss"] == true  or  Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true)"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Player_Romus: ""You should've died along with your daughter.""*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should've died along with your daughter.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[516]` (Taddeus Azaro), `[520]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "Rage flashed across his face."*)

### Węzeł `[605]`
Mówca: **Narrator**
> "Rage flashed across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[606]`
Mówca: **Taddeus Azaro**
> ""Step down peacefully, and I swear on my ancestors' graves that nobody will be harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[607]`
Mówca: **Taddeus Azaro**
> ""After what you did to Lucita, you deserve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Executed == true"*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Executed == true)"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Taddeus Azaro: ""After what you did to Lucita, you deserve it.""*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Taddeus Azaro: ""Then you will die.""*)

### Węzeł `[611]`
Mówca: **Taddeus Azaro**
> ""Then you will die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Narrator: "He motioned to one of his officers. The man strode toward..."*)

### Węzeł `[612]`
Mówca: **Narrator**
> "As the officer took up a position directly beneath the balcony, Taddeus spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Taddeus Azaro: ""I will give you one chance. Tell your guards to surrende..."*)

### Węzeł `[613]`
Mówca: **Narrator**
> "He motioned to one of his officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Narrator: "As the officer took up a position directly beneath the ba..."*)

### Węzeł `[614]`
Mówca: **Taddeus Azaro**
> ""I will give you one chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Player_Romus: ""Guards! You heard him. Relinquish your weapons right away!""*)
  - -> `[616]` (*Player_Romus: ""I can't do that.""*)
  - -> `[617]` (*Player_Romus: ""Why don't you surrender *your* weapons before it's too l..."*)

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard him. Relinquish your weapons right away!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[614]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Surrender]"*)

### Węzeł `[616]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[614]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[617]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[614]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[618]`
Mówca: **Narrator**
> "She looked up at me, her posture rigid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Player_Romus: ""Angelica. You don't have to do this.""*)
  - -> `[620]` (*Player_Romus: ""I let you out of prison, and this is how you repay me?""*)
  - -> `[621]` (*Player_Romus: ""By order of the King, you and your men will stand down.""*)
  - -> `[622]` (*Player_Romus: ""You have my attention. What do you want?""*)

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Angelica. You don't have to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Angelica Sazon: ""You will address me as Duchess.""*)

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I let you out of prison, and this is how you repay me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Angelica Sazon: ""Do you truly expect gratitude after you humiliated my fa..."*)

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Angelica Sazon: ""You are no king of mine.""*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my attention. What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Angelica Sazon: ""You have already been told. Cede the throne to House Saz..."*)

### Węzeł `[623]`
Mówca: **Angelica Sazon**
> ""You have already been told. Cede the throne to House Sazon, and we will let you live.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Angelica Sazon: ""I implore you to cooperate. No more blood needs to be sh..."*)

### Węzeł `[624]`
Mówca: **Angelica Sazon**
> ""You will address me as Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Angelica Sazon: ""I implore you to cooperate. No more blood needs to be sh..."*)

### Węzeł `[625]`
Mówca: **Angelica Sazon**
> ""Do you truly expect gratitude after you humiliated my family for all those years?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Angelica Sazon: ""I implore you to cooperate. No more blood needs to be sh..."*)

### Węzeł `[626]`
Mówca: **Angelica Sazon**
> ""You are no king of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Angelica Sazon: ""I implore you to cooperate. No more blood needs to be sh..."*)

### Węzeł `[627]`
Mówca: **Angelica Sazon**
> ""I implore you to cooperate. No more blood needs to be shed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Player_Romus: ""I need your word that you won't hurt my family.""*)
  - -> `[638]` (*Player_Romus: ""I'll die before I bend the knee to you.""*)
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInW..."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true || RiziaDLC.SuOmina_OrderedToKillManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInW..."*)
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesI..."*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true || RiziaDLC.SuOmina_OrderedToKillManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Player_Romus: ""You should've died along with your son.""*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true || RiziaDLC.SuOmina_OrderedToKillManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Player_Romus: ""My father should've killed you along with your husband.""*)

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should've died along with your son.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true`
- **Kontekst wejściowy (poprzednik):** `[627]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "Her face turned white with rage."*)

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should've killed you along with your husband.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[627]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "Her face turned white with rage."*)

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[627]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[634]`
Mówca: **Angelica Sazon**
> ""Of course I won't. My son loves your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Angelica Sazon: ""Of course I won't. My son loves your daughter.""*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Angelica Sazon: ""I swear to you that nobody will be harmed.""*)

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[627]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)

### Węzeł `[639]`
Mówca: **Angelica Sazon**
> ""I swear to you that nobody will be harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[640]`
Mówca: **Angelica Sazon**
> ""Please. Think of your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true)"*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Angelica Sazon: ""Please. Think of your mother.""*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Angelica Sazon: ""Please. Think of your mother. Your daughter.""*)

### Węzeł `[644]`
Mówca: **Angelica Sazon**
> ""Please. Think of your mother. Your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[645]`
Mówca: **Narrator**
> "Her face turned white with rage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "She motioned to one of her officers. The man strode towar..."*)

### Węzeł `[646]`
Mówca: **Narrator**
> "As the officer took up a position directly beneath the balcony, Angelica spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Angelica Sazon: ""This is your final chance. Tell your guards to surrender..."*)

### Węzeł `[647]`
Mówca: **Narrator**
> "She motioned to one of her officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Narrator: "As the officer took up a position directly beneath the ba..."*)

### Węzeł `[648]`
Mówca: **Angelica Sazon**
> ""This is your final chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Player_Romus: ""Guards! You heard her. Relinquish your weapons right away!""*)
  - -> `[650]` (*Player_Romus: ""I can't do that.""*)
  - -> `[651]` (*Player_Romus: ""Why don't you surrender *your* weapons before it's too l..."*)

### Węzeł `[649]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard her. Relinquish your weapons right away!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Surrender]"*)

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Angelica Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "The officer took another step forward. He lifted his gun ..."*)

### Węzeł `[652]`
Mówca: **Narrator**
> "The officer took another step forward. He lifted his gun and pointed it straight at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Soldier! Lower that gun at once! You're pointing your we..."*)
  - -> `[653]` (*Player_Romus: ""You wouldn't dare.""*)
  - -> `[180]` (*Player_Romus: ""Go ahead. Shoot me. You can pry my crown from my cold de..."*)

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You wouldn't dare.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[652]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Narrator: "The man's aim faltered slightly as he looked at Rico for ..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Narrator: "The man's aim faltered slightly as he looked at Hugo for ..."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Narrator: "The man's aim faltered slightly as he looked at Lucita fo..."*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == true"*)
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_ToldToOpenFire == true)"*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_ToldToOpenFire == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "At that moment, the stable doors burst open with a thunde..."*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_ToldToOpenFire == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Without a moment of hesitation, he..."]"*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "The man's aim faltered slightly as he looked at Taddeus f..."*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "The man's aim faltered slightly as he looked at Angelica ..."*)

### Węzeł `[669]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Rico for confirmation. My cousin gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == false"*)

### Węzeł `[670]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Hugo for confirmation. My cousin gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == false"*)

### Węzeł `[671]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Lucita for confirmation. She gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == false"*)

### Węzeł `[672]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Taddeus for confirmation. The general gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == false"*)

### Węzeł `[673]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Angelica for confirmation. She gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_ToldToOpenFire == false"*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Peaceful Surrender`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Peaceful Surrender]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "Peaceful Surrender"*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""It is out of our hands now. We must pray.""*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That traitor is still out there. I'm going after them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Vina Toras), `[219]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Estela Toras: ""To hell with that. We've got to get to the safe room.""*)

### Węzeł `[680]`
Mówca: **Estela Toras**
> ""To hell with that. We've got to get to the safe room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[681]`
Mówca: **Narrator**
> "Titus appeared by our side. He took a moment to catch his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Titus Gordion: ""We don't have much time, Your Majesty. This way.""*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Narrator: "Titus appeared by our side. He took a moment to catch his..."*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Narrator: "Accompanied by our guards, we sprinted into the corridor ..."*)

### Węzeł `[685]`
Mówca: **Titus Gordion**
> ""We don't have much time, Your Majesty. This way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Narrator: "We sprinted into the corridor and raced toward a back sta..."*)

### Węzeł `[686]`
Mówca: **Narrator**
> "Accompanied by our guards, we sprinted into the corridor and raced toward a back stairwell, descending as quickly as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "We could still hear the exchange of gunfire from outside."*)

### Węzeł `[687]`
Mówca: **Narrator**
> "We sprinted into the corridor and raced toward a back stairwell, descending as quickly as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "We could still hear the exchange of gunfire from outside."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaD..."*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true || Rizi..."*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Narrator: "A spatter of gunshots suddenly echoed through the hallway."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "The rebels moved with quick steps, pinning us down, their..."*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaD..."*)
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true || Rizi..."*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Narrator: "A spatter of gunshots suddenly echoed through the hallway..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == true"*)

### Węzeł `[694]`
Mówca: **Narrator**
> "A spatter of gunshots suddenly echoed through the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[695]`
Mówca: **Narrator**
> "A spatter of gunshots suddenly echoed through the hallway. I dropped to the floor to take cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[696]`
Mówca: **Narrator**
> "I lifted my head to see my attackers lying dead on the ground. Above them stood Sal Ignacius and a group of Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Sal Ignacius: ""Your Majesty. Thank the Divine you are safe.""*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Narrator: "I lifted my head to see my attackers lying dead on the gr..."*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Narrator: "I lifted my head to see my attackers lying dead on the gr..."*)

### Węzeł `[700]`
Mówca: **Narrator**
> "I lifted my head to see my attackers lying dead on the ground. Above them, a backup contingent of Golden Guards slowly lowered their guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[701]`
Mówca: **Sal Ignacius**
> ""Your Majesty. Thank the Divine you are safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Player_Romus: ""Thank the Divine for you and the Guardians, Sal.""*)
  - -> `[702]` (*Player_Romus: ""No time for prayers. Let's get inside.""*)
  - -> `[703]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for prayers. Let's get inside.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[701]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Narrator: "Together with Sevrio and the guards, we rushed inside the..."*)

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[701]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "The door shut behind us with a definitive clang, sealing ..."*)
  - -> `[710]` (*Narrator: "Together with Sevrio and the guards, we rushed inside the..."*)

### Węzeł `[705]`
Mówca: **Narrator**
> "Titus pulled me up off the floor, and we rushed inside the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "The door shut behind us with a definitive clang, sealing ..."*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Narrator: "Titus pulled me up off the floor, and we rushed inside th..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Narrator: "One of them pulled me up off the floor, and we rushed ins..."*)

### Węzeł `[709]`
Mówca: **Narrator**
> "One of them pulled me up off the floor, and we rushed inside the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "The door shut behind us with a definitive clang, sealing ..."*)

### Węzeł `[710]`
Mówca: **Narrator**
> "Together with Sevrio and the guards, we rushed inside the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "The door shut behind us with a definitive clang, sealing ..."*)

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank the Divine for you and the Guardians, Sal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[701]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Narrator: "Together with Sevrio and the guards, we rushed inside the..."*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_BringFamily == false"*)
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Coup_BringFamily == false)"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Coup_BringFamily == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Coup_BringFamily == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[715]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother and Vina were already here, along with Bruno. The dog ran to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras"); AddConversant("Vina Toras"..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "I looked around the room and saw that my mother and Vina ..."*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Narrator: "I looked around the room and saw that my mother and Vina ..."*)

### Węzeł `[722]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother and Bruno were already here. The dog ran to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Narrator: "I looked around the room and saw that one of the guards h..."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[726]`
Mówca: **Narrator**
> "I looked around the room and saw that one of the guards had brought Bruno here already. The dog ran to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[727]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother and Vina were already here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras"); AddConversant("Vina Toras"..."*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Narrator: "I looked around the room and saw that my mother and Bruno..."*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Narrator: "I looked around the room and saw that my mother was alrea..."*)

### Węzeł `[731]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother was already here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[732]`
Mówca: **Estela Toras**
> ""I hate to say I told you so -- oh, who am I kidding? I love it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Estela Toras: ""But in this particular case, I do so wish I was wrong.""*)

### Węzeł `[733]`
Mówca: **Estela Toras**
> ""But in this particular case, I do so wish I was wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Player_Romus: ""It's not over yet. We've got to fight.""*)
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[741]` (*Player_Romus: ""Forgive me, Mother. We should have fled when we had the ..."*)
  - -> `[742]` (*Player_Romus: ""I'm just happy you're safe.""*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");
AddConversant("Vina Toras");
AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");
AddConversant("Vina Toras");
AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Estela Toras: ""I hate to say I told you so -- oh, who am I kidding? I l..."*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Estela Toras: ""I hate to say I told you so -- oh, who am I kidding? I l..."*)

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not over yet. We've got to fight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[733]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[737]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for remembering Bruno.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Kontekst wejściowy (poprzednik):** `[733]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Estela Toras: ""I wasn't about to make the same mistake twice. And I adm..."*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Player_Romus: ""Thanks for remembering Bruno.""*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[741]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, Mother. We should have fled when we had the chance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[733]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just happy you're safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[733]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)

### Węzeł `[743]`
Mówca: **Estela Toras**
> ""I wasn't about to make the same mistake twice. And I admit he is a very good boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[744]`
Mówca: **Vina Toras**
> ""What's the point, Father? Half the kingdom hates us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[745]`
Mówca: **Vina Toras**
> ""It's not too late. We can still escape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Vina Toras: ""It's not too late. We can still escape.""*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Estela Toras: ""We still have a chance. Don't we?""*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Vina Toras: ""What's the point, Father? Half the kingdom hates us.""*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Estela Toras: ""You really don't know when to give up, do you?""*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true"*)
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == t..."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Vina Toras: ""For now. We need to get out of here.""*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Estela Toras: ""For now. We need to get out of here.""*)

### Węzeł `[755]`
Mówca: **Vina Toras**
> ""For now. We need to get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[756]`
Mówca: **Estela Toras**
> ""For now. We need to get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[757]`
Mówca: **Estela Toras**
> ""We still have a chance. Don't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[758]`
Mówca: **Estela Toras**
> ""You really don't know when to give up, do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Narrator: "Titus, Sal, Sevrio and a number of Wruhec's Guardians wer..."*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Narrator: "Titus and his guardsmen were huddled in a corner, convers..."*)

### Węzeł `[762]`
Mówca: **Narrator**
> "Titus, Sal, Sevrio and a number of Wruhec's Guardians were huddled in a corner, conversing. They turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Titus Gordion: ""Good news, Your Majesty. Our communications are active a..."*)

### Węzeł `[763]`
Mówca: **Narrator**
> "Titus and his guardsmen were huddled in a corner, conversing. They turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Titus Gordion: ""Good news, Your Majesty. Our communications are active a..."*)

### Węzeł `[764]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Narrator: "Titus reluctantly signaled to his guards to drop their we..."*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[767]`
Mówca: **Narrator**
> "Titus reluctantly signaled to his guards to drop their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "In response, the rebels surged forward, their determined ..."*)

### Węzeł `[768]`
Mówca: **Narrator**
> "As they roughly shoved me into the back of a car, I turned my head and took one more look at Palas Rezna. My home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Narrator: "I knew I would never return."*)

### Węzeł `[769]`
Mówca: **Narrator**
> "I knew I would never return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[770]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[772]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""One day, you will pay for this.""*)

### Węzeł `[772]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[774]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Player_Romus: ""May God have mercy on your soul.""*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[776]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God have mercy on your soul.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[236]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Ignoring my words, they simply smiled and escorted us out..."*)

### Węzeł `[777]`
**[WYBÓR GRACZA: "Get down."]** — Mówca: **Player_Romus_Italic**
> "With no options left, I pressed my face to the cold floor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "The rebels moved with quick steps, pinning us down, their..."*)

### Węzeł `[778]`
Mówca: **Narrator**
> "I exchanged nods with the guards posted outside the Queen Mother's chambers. She was barely leaving her room these days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "As I entered the study and shifted my gaze toward the win..."*)

### Węzeł `[779]`
Mówca: **Narrator**
> "The palace felt empty without her, but at least she would be safe there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "In the hope of distracting myself, I got out of bed and m..."*)

### Węzeł `[780]`
Mówca: **Narrator**
> "Suddenly, the doors swung open and Sevrio hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Sevrio Castellanus: ""Your Majesty. Forgive me. They surrounded us before we c..."*)

### Węzeł `[781]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "It was then that the sound of roaring engines filled the ..."*)

### Węzeł `[782]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vin..."*)
  - -> `[784]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.V..."*)

### Węzeł `[783]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Narrator: "There was no word from my daughter. I hoped that she was ..."*)

### Węzeł `[784]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)

### Węzeł `[785]`
Mówca: **Narrator**
> "There was no word from my daughter. I hoped that she was safe, wherever she was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTora..."*)

### Węzeł `[786]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true)"*)

### Węzeł `[787]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Narrator: "There was a telegram from Vina, assuring me that her secu..."*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[789]`
Mówca: **Narrator**
> "There was a telegram from Vina, assuring me that her security team in Pales had been alerted to the possible danger and were taking precautions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTora..."*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Narrator: "There was a telegram from Vina, assuring me that she and ..."*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[793]`
Mówca: **Narrator**
> "There was a telegram from Vina, assuring me that she and Manus were in a secure location."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTora..."*)

### Węzeł `[794]`
Mówca: **Narrator**
> "There was a telegram from Vina, assuring me that her palace in Monqiz was still secure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[797]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Narrator: "There was a telegram from Vina, assuring me that her pala..."*)

### Węzeł `[797]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHap..."*)

### Węzeł `[798]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[799]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Player_Romus: "Rico and Hubertus were there with her, ready to protect H..."*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Player_Romus: "Hubertus was nearby, ready to protect House Toras at all ..."*)

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Rico and Hubertus were there with her, ready to protect House Toras at all costs."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[794]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As I rummaged through the papers on my desk, I heard the ..."*)

### Węzeł `[802]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Hubertus was nearby, ready to protect House Toras at all costs -- or so he had said."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[794]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As I rummaged through the papers on my desk, I heard the ..."*)

### Węzeł `[803]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Rescue_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHap..."*)
  - -> `[805]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralH..."*)

### Węzeł `[804]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Rescue_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Rescue_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Narrator: "There was a telegram from the war front, letting me know ..."*)

### Węzeł `[805]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Rescue_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Rescue_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTora..."*)

### Węzeł `[806]`
Mówca: **Narrator**
> "There was a telegram from the war front, letting me know that Vina still hadn't been found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTora..."*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseToras_Conquered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTora..."*)
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseTo..."*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseToras_Conquered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.HouseToras_Conquered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Narrator: "Hubertus had written from Monqiz, saying that he had hear..."*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseToras_Conquered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.HouseToras_Conquered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_A..."*)

### Węzeł `[810]`
Mówca: **Narrator**
> "Hubertus had written from Monqiz, saying that he had heard the rumors and was covertly marshalling all the Toras loyalists he could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As I rummaged through the papers on my desk, I heard the ..."*)

### Węzeł `[811]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.HouseAzaro_Conquered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_A..."*)
  - -> `[813]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup..."*)

### Węzeł `[812]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.HouseAzaro_Conquered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.HouseAzaro_Conquered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Narrator: "My father-in-law had written from Montaklar, saying that ..."*)

### Węzeł `[813]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.HouseAzaro_Conquered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.HouseAzaro_Conquered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true &&..."*)

### Węzeł `[814]`
Mówca: **Narrator**
> "My father-in-law had written from Montaklar, saying that he had heard the rumors and was covertly marshalling all the loyalists he could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As I rummaged through the papers on my desk, I heard the ..."*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.Ending_Coup_Sazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true &&..."*)
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true ..."*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.Ending_Coup_Sazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == false  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Narrator: "Angelica Sazon had written from Brenas, saying that she h..."*)

### Węzeł `[817]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.Ending_Coup_Sazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == false  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As I rummaged through the papers on my desk, I heard the ..."*)

### Węzeł `[818]`
Mówca: **Narrator**
> "Angelica Sazon had written from Brenas, saying that she had heard the rumors and was covertly marshalling all the loyalists she could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As I rummaged through the papers on my desk, I heard the ..."*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Narrator: "With an abrupt thud, the doors opened and Sevrio rushed in."*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "With an abrupt thud, the doors opened and my guards rushe..."*)

### Węzeł `[822]`
Mówca: **Narrator**
> "With an abrupt thud, the doors opened and Sevrio rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Sevrio Castellanus: ""Your Majesty. Forgive me. They surrounded us before we c..."*)

### Węzeł `[823]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Sevrio Castellanus: ""Wait. Is that what I think it is?""*)

### Węzeł `[824]`
Mówca: **Sevrio Castellanus**
> ""Wait. Is that what I think it is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "As he stared out the window, Titus' eyes widened in horro..."*)

### Węzeł `[825]`
Mówca: **Narrator**
> "As he stared out the window, Sevrio's eyes widened in horror. I followed his gaze to the flag mounted on the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true"*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Sevrio Castellanus: ""Lord save us. The radio signal's gone dead.""*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "As we attempted to figure out what was happening, the gua..."*)

### Węzeł `[829]`
Mówca: **Sevrio Castellanus**
> ""Lord save us. The radio signal's gone dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[830]`
Mówca: **Sevrio Castellanus**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Coup_GuardsStay = true"*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[832]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Sevrio Castellanus: ""Yes, Your Majesty.""*)

### Węzeł `[833]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "The guards, shouting "Yes, Your Majesty," readied their w..."*)

### Węzeł `[834]`
Mówca: **Sevrio Castellanus**
> ""Yes, Your Majesty. I'll be back in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Narrator: "Sevrio bowed and rushed out."*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Sevrio Castellanus: ""Yes, Your Majesty. I'll be back in an instant.""*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: ""Yes, Your Majesty," the guards shouted as they rushed out."*)

### Węzeł `[838]`
Mówca: **Narrator**
> "Sevrio bowed and rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Sevr..."*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus < 1"*)
  - -> `[841]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Titus < 1)"*)

### Węzeł `[840]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LateGameCoup_TitusBetrays = true"*)

### Węzeł `[841]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Titus < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: ""I repeat. If you abdicate, your noble status will be pre..."*)

### Węzeł `[842]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LateGameCoup_TitusBetrays = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LateGameCoup_TitusBetrays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: ""I repeat. If you abdicate, your noble status will be pre..."*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == false"*)
  - -> `[845]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == false)"*)

### Węzeł `[844]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Titus Gordion: ""Are you suggesting we negotiate? I'm sorry, sir, but I d..."*)

### Węzeł `[845]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Narrator: "Sevrio paled."*)

### Węzeł `[846]`
Mówca: **Narrator**
> "Sevrio paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Sevrio Castellanus: ""Good luck, sir.""*)

### Węzeł `[847]`
Mówca: **Sevrio Castellanus**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The soldiers saluted me as I grabbed a coat and walked ou..."*)

### Węzeł `[848]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[850]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[849]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]` (*Narrator: "Sevrio muttered a prayer as he awaited my instructions."*)

### Węzeł `[850]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "The guards cast nervous glances my way, waiting for instr..."*)

### Węzeł `[851]`
Mówca: **Narrator**
> "Sevrio muttered a prayer as he awaited my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""I'm going to go out and talk to them.""*)
  - -> `[130]` (*Player_Romus: ""We hold our ground, no exceptions. Is that understood? N..."*)
  - -> `[128]` (*Player_Romus: ""You have to get my family out of here this instant. In t..."*)

### Węzeł `[852]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[854]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[853]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Sevrio Castellanus: ""Your Majesty, I really must insist on escorting you to a..."*)

### Węzeł `[854]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "The guards insisted on escorting me to a safe room before..."*)

### Węzeł `[855]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty, I really must insist on escorting you to a safe place before initiating anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""There's no time. Open fire immediately!""*)
  - -> `[856]` (*Player_Romus: ""Fine. Get me to the safe room.""*)

### Węzeł `[856]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Get me to the safe room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[855]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[857]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[859]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[858]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Narrator: "Sevrio reluctantly signaled to his guards to drop their w..."*)

### Węzeł `[859]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "The guards within the palace reluctantly dropped their we..."*)

### Węzeł `[860]`
Mówca: **Narrator**
> "Sevrio reluctantly signaled to his guards to drop their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "In response, the rebels surged forward, their determined ..."*)

### Węzeł `[861]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Hostile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[862]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true"*)
  - -> `[863]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Hostile == true)"*)

### Węzeł `[862]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Hostile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Hostile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Narrator: "Alongside them were a pair of vans bearing the Palantor S..."*)

### Węzeł `[863]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Hostile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Hostile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true"*)

### Węzeł `[864]`
Mówca: **Narrator**
> "Alongside them were a pair of vans bearing the Palantor Security Solutions logo. Rusty's men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true"*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC.Situation_Order_SuOmina_Destabilizing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC..."*)
  - -> `[867]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaD..."*)

### Węzeł `[866]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC.Situation_Order_SuOmina_Destabilizing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true  or  Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradit..."*)

### Węzeł `[867]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC.Situation_Order_SuOmina_Destabilizing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true  or  Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Orde..."*)

### Węzeł `[868]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == false && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Orde..."*)
  - -> `[870]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Or..."*)

### Węzeł `[869]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == false && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Deposed"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == false  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradit..."*)

### Węzeł `[870]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == false && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Deposed"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == false  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)

### Węzeł `[871]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradited == false && RiziaDLC.Rico_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradit..."*)
  - -> `[873]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extrad..."*)

### Węzeł `[872]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradited == false && RiziaDLC.Rico_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: ""Abdicate the throne to Ricardus Toras, and your life and..."*)

### Węzeł `[873]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradited == false && RiziaDLC.Rico_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[874]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)
  - -> `[876]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrest..."*)

### Węzeł `[875]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: ""Abdicate the throne to Hugo Toras, and your life and nob..."*)

### Węzeł `[876]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: ""Abdicate the throne to Ricardus Toras, and your life and..."*)

### Węzeł `[877]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Ending their reign with...", "Porte Drazon", "Kingdom of Rizia");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Ending their reign with...","Porte Drazon","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Breather", "R_Breather_Loop");"*)
