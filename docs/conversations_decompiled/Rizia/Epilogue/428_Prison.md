# Rizia/Prison

- **ID konwersacji:** `428`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Prison)`
- **Lokalizacja pliku:** `Rizia/Epilogue/428_Prison.md`
- **Liczba węzłów dialogowych:** 400
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_RumburgWarLost`
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Ending_WorldWar`
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.BirthdayGathering_HouseStrike_Success`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_TitusBetrays`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Coup_Leader_Angelica`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Reform`
- `RiziaDLC.Epilogue_Prison_ConstitutionSigning`
- `RiziaDLC.Epilogue_Prison_HugoSendsToPrison`
- `RiziaDLC.Epilogue_Prison_Revolution_Surrounded`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Hugo_Resigned`
- `RiziaDLC.Hugo_RicoNotPardoned`
- `RiziaDLC.LateGameCoup_TitusBetrays`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Manus_ConvinceToLeave`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Manus_ThreatenToLeave`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Son_Romus`
- `RiziaDLC.Successor_Vina`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Epilogue_DiedInPrison`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLCText.LenaTooltip`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[18]`
- Węzeł `[164]` -> **[430] Rizia/Peaceful Power Transition** (../Epilogue/430_Peaceful_Power_Transition.md), Węzeł `[83]`
- Węzeł `[200]` -> **[430] Rizia/Peaceful Power Transition** (../Epilogue/430_Peaceful_Power_Transition.md), Węzeł `[552]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **"1958\|Porte Drazon"** | `[346]` **Player_Romus**: "You felt your mind slipping away." | `Variable["RiziaDLC.Lucita_Married"] == true`<br>`Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true` | *Brak zmian stanu* | `[20]` **Player_Romus**: "...ran after her as fast as you ..."<br>`[13]` **Player_Romus**: "...could not make sense of what ..."<br>*(oraz 1 innych odgałęzień)* |
| `[13]` | **"...could not make sense of what was happening."** | `[12]` **Narrator**: "You were in a dark tunnel with n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[20]` | **"...ran after her as fast as you could."** | `[12]` **Narrator**: "You were in a dark tunnel with n..."<br>`[26]` **Narrator**: "You were in a dark tunnel with n..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[21]` | **"...told her to stay with you."** | `[12]` **Narrator**: "You were in a dark tunnel with n..."<br>`[26]` **Narrator**: "You were in a dark tunnel with n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[22]` | **"1958\|Porte Drazon"** | `[46]` **Player_Romus**: "The last of his name."<br>`[67]` **Player_Romus**: "The second-to-last of his name."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[23]` **Player_Romus**: "...ran after him as fast as you ..."<br>`[24]` **Player_Romus**: "...could not make sense of what ..."<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **"...ran after him as fast as you could."** | `[22]` **Narrator**: "You were in a dark tunnel with n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[24]` | **"...could not make sense of what was happening."** | `[22]` **Narrator**: "You were in a dark tunnel with n..."<br>`[26]` **Narrator**: "You were in a dark tunnel with n..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[25]` | **"...told him to stay with you."** | `[22]` **Narrator**: "You were in a dark tunnel with n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[26]` | **"1958\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player_Romus**: "...ran after her as fast as you ..."<br>`[21]` **Player_Romus**: "...told her to stay with you."<br>*(oraz 1 innych odgałęzień)* |
| `[28]` | **"...felt the brush of something soft."** | `[31]` **Narrator**: "It was the most magnificent bull..."<br>`[34]` **Narrator**: "It was the most magnificent bull..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "A rat was looking at you.  You h..." |
| `[30]` | **"...did not dare to move."** | `[27]` **Narrator**: "You heard a deep bellow from rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "It was the most magnificent bull..." |
| `[32]` | **"...ran for your life."** | `[27]` **Narrator**: "You heard a deep bellow from rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "But, there was no escape. It app..." |
| `[33]` | **"...turned around to face it."** | `[27]` **Narrator**: "You heard a deep bellow from rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "It was the most magnificent bull..." |
| `[36]` | **"The cell door opened."** | `[29]` **Narrator**: "A rat was looking at you.  You h..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_DiedInPrison"] = true;` | `[37]` **Narrator**: "The warden entered your cell to ..." |
| `[38]` | **"...nothing."** | `[37]` **Narrator**: "The warden entered your cell to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "After your meal, you were dragge..." |
| `[39]` | **"...Toras flambeé."** | `[37]` **Narrator**: "The warden entered your cell to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "After your meal, you were dragge..." |
| `[40]` | **"...a rizetta."** | `[37]` **Narrator**: "The warden entered your cell to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "After your meal, you were dragge..." |
| `[42]` | **"...the bull was nowhere to be found."** | `[41]` **Narrator**: "After your meal, you were dragge..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_guillotine");` | `[43]` **Narrator**: "Among the cheers of the crowd, t..." |
| `[44]` | **"The blade dropped."** | `[47]` **Narrator**: "It was all for naught.  You look..."<br>`[51]` **Narrator**: "You looked up and saw the sharp ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_light");` | `[45]` **Narrator**: "And so passed His Majesty, Romus..." |
| `[46]` | **"The last of his name."** | `[45]` **Narrator**: "And so passed His Majesty, Romus..." | `(Variable["RiziaDLC.Son_Romus"] == true) == false` | `UnlockAchievement("Rizia_Epilogue_Death");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[48]` | **"...did not resist at all."** | `[43]` **Narrator**: "Among the cheers of the crowd, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "You looked up and saw the sharp ..." |
| `[49]` | **"...tried to get away with all your might."** | `[43]` **Narrator**: "Among the cheers of the crowd, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "It was all for naught.  You look..." |
| `[50]` | **"...accepted your fate with dignity."** | `[43]` **Narrator**: "Among the cheers of the crowd, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "You looked up and saw the sharp ..." |
| `[52]` | **"...a bottle of wine."** | `[37]` **Narrator**: "The warden entered your cell to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;` | `[41]` **Narrator**: "After your meal, you were dragge..." |
| `[67]` | **"The second-to-last of his name."** | `[45]` **Narrator**: "And so passed His Majesty, Romus..." | `Variable["RiziaDLC.Son_Romus"] == true` | `UnlockAchievement("Rizia_Epilogue_Death");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[71]` | **"1958\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player_Romus**: "...ran after her as fast as you ..."<br>`[24]` **Player_Romus**: "...could not make sense of what ..."<br>*(oraz 1 innych odgałęzień)* |
| `[72]` | **"...cursed her for giving birth to you."** | `[71]` **Narrator**: "You were in a dark tunnel with n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "You heard a deep bellow from rig..." |
| `[76]` | **"At least you fought for something greater, for a better world."** | `[78]` **Narrator**: "Rumors seeped through the prison..."<br>`[124]` **Narrator**: "Rumors seeped through the prison..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[117]` **Narrator**: "News had been scarce since you w..."<br>`[97]` **Narrator**: "All three noble houses united be..." |
| `[77]` | **"You couldn't help but wish you had crushed your enemies when you had the chance."** | `[78]` **Narrator**: "Rumors seeped through the prison..."<br>`[124]` **Narrator**: "Rumors seeped through the prison..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[117]` **Narrator**: "News had been scarce since you w..."<br>`[97]` **Narrator**: "All three noble houses united be..." |
| `[79]` | **"...felt nothing but the weight of time."** | `[82]` **Narrator**: "Power had been a fragile thing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "Rumors seeped through the prison..."<br>`[124]` **Narrator**: "Rumors seeped through the prison..."<br>*(oraz 1 innych odgałęzień)* |
| `[80]` | **"...counted each day, a silent rebellion against your fate."** | `[82]` **Narrator**: "Power had been a fragile thing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "Rumors seeped through the prison..."<br>`[124]` **Narrator**: "Rumors seeped through the prison..."<br>*(oraz 1 innych odgałęzień)* |
| `[81]` | **"It seemed pointless now, worrying about what could have been."** | `[78]` **Narrator**: "Rumors seeped through the prison..."<br>`[124]` **Narrator**: "Rumors seeped through the prison..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[117]` **Narrator**: "News had been scarce since you w..."<br>`[97]` **Narrator**: "All three noble houses united be..." |
| `[82]` | **"1957\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Player_Romus**: "...found bitter irony in this cr..."<br>`[79]` **Player_Romus**: "...felt nothing but the weight o..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **"...found bitter irony in this cruel twist of fate."** | `[82]` **Narrator**: "Power had been a fragile thing, ..."<br>`[163]` **Narrator**: "To circumvent any potential for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "Rumors seeped through the prison..."<br>`[124]` **Narrator**: "Rumors seeped through the prison..."<br>*(oraz 1 innych odgałęzień)* |
| `[108]` | **"And then came the news -- Hugo had been crowned king."** | `[97]` **Narrator**: "All three noble houses united be..."<br>`[98]` **Narrator**: "Houses Toras and Sazon united be..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;` | `[171]` **Narrator**: "At some point, you lost track of..." |
| `[113]` | **"And then came the news -- Taddeus had been crowned king."** | `[100]` **Narrator**: "Houses Sazon and Azaro united be..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;` | `[171]` **Narrator**: "At some point, you lost track of..." |
| `[141]` | **"The days passed."** | `[117]` **Narrator**: "News had been scarce since you w..."<br>`[126]` **Narrator**: "News had been scarce since you w..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "At some point, you lost track of..." |
| `[157]` | **"...by the royal decree of King Hugo Toras, your life shall be spared, your honor r..."** | `[158]` **Narrator**: "Your release came as part of the..." | `Variable["RiziaDLC.Coup_Leader_Hugo"] == true` | *Brak zmian stanu* | `[165]` **Narrator**: "Fully free at last, life could b..." |
| `[158]` | **"1958\|Porte Drazon"** | `[345]` **Player_Romus**: "Until one day, the cell door ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Player_Romus**: "...by the royal decree of King H..."<br>`[159]` **Player_Romus**: "...under the royal decree of Kin..."<br>*(oraz 4 innych odgałęzień)* |
| `[159]` | **"...under the royal decree of King Rico Toras, your life is hereby preserved, your ..."** | `[158]` **Narrator**: "Your release came as part of the..." | `Variable["RiziaDLC.Coup_Leader_Rico"] == true` | *Brak zmian stanu* | `[165]` **Narrator**: "Fully free at last, life could b..." |
| `[160]` | **"...by the royal decree of King Taddeus Azaro, your life is spared, your honor rest..."** | `[158]` **Narrator**: "Your release came as part of the..." | `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[161]` | **"...by the royal decree of Queen Lucita Azaro, your life is spared, your honor rede..."** | `[158]` **Narrator**: "Your release came as part of the..." | `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true) == false`<br>`Variable["RiziaDLC.Coup_Leader_Lucita"] == true` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[162]` | **"...by the royal decree of Queen Angelica Sazon, your existence is spared, your hon..."** | `[158]` **Narrator**: "Your release came as part of the..." | `Variable["RiziaDLC.Coup_Leader_Angelica"] == true` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[166]` | **"...by the royal decree of Queen Lucita Azaro, you were to be released in one month..."** | `[158]` **Narrator**: "Your release came as part of the..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true`<br>`Variable["RiziaDLC.Coup_Leader_Lucita"] == true` | *Brak zmian stanu* | `[163]` **Narrator**: "To circumvent any potential for ..." |
| `[167]` | **"A fresh start awaited."** | `[165]` **Narrator**: "Fully free at last, life could b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[199]` | **"1958\|Porte Drazon"** | `[349]` **Player_Romus**: "Until one day, the cell door ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Player_Romus**: ""I wanted you to know that I hav..."<br>`[208]` **Player_Romus**: ""I am writing this from exile --..."<br>*(oraz 1 innych odgałęzień)* |
| `[201]` | **""I wanted you to know that I have given birth to our son, {RiziaDLCText.KingsSon},..."** | `[199]` **Narrator**: "Thousands were being released fr..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false` | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[208]` | **""I am writing this from exile -- I will not tell you where for my protection and t..."** | `[199]` **Narrator**: "Thousands were being released fr..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[209]` | **""I wanted you to know that I have given birth to your son, {RiziaDLCText.KingsSon}..."** | `[199]` **Narrator**: "Thousands were being released fr..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[216]` | **""I wanted you to know that I tried to see you, but they would not allow it. Not fa..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[217]` | **""Darling -- the bastards are pressuring me to make a show of fealty to the new reg..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[267]` | **"You couldn't care less."** | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[247]` **Narrator**: "You heard rumors that Queen Ange..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "After months, your family was fi..." |
| `[268]` | **"You cursed his name."** | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "After months, your family was fi..." |
| `[269]` | **"Long live the King."** | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "After months, your family was fi..." |
| `[270]` | **"You cursed her name."** | `[247]` **Narrator**: "You heard rumors that Queen Ange..."<br>`[258]` **Narrator**: "You heard rumors that Queen Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "After months, your family was fi..." |
| `[271]` | **"...listened in silence, unsure what to feel."** | `[233]` **Narrator**: "After months, your family was fi..."<br>`[237]` **Narrator**: "After months, your family was fi..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[272]` | **"...missed your daughter more than anything."** | `[238]` **Narrator**: "After months, your family was fi..."<br>`[242]` **Narrator**: "After months, your family was fi..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[273]` | **"...clung to her every word, desperate to know about the world outside your four wa..."** | `[233]` **Narrator**: "After months, your family was fi..."<br>`[237]` **Narrator**: "After months, your family was fi..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[274]` | **"...said they shouldn't waste their time on false hope."** | `[237]` **Narrator**: "After months, your family was fi..."<br>`[240]` **Narrator**: "After months, your family was fi..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[275]` | **"...smiled, knowing that even in prison, you were not forgotten."** | `[237]` **Narrator**: "After months, your family was fi..."<br>`[240]` **Narrator**: "After months, your family was fi..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[280]` | **"...nodded, but all you wanted was to see your son."** | `[233]` **Narrator**: "After months, your family was fi..."<br>`[237]` **Narrator**: "After months, your family was fi..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false` | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[295]` | **"At least order had been restored."** | `[294]` **Narrator**: "Rumors seeped through the prison..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[117]` **Narrator**: "News had been scarce since you w..."<br>`[97]` **Narrator**: "All three noble houses united be..." |
| `[298]` | **"War, war never changes."** | `[296]` **Narrator**: "The next day, you received news ..."<br>`[297]` **Narrator**: "The next day, you received news ..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[308]` **Narrator**: "Days later, the news reached you..."<br>`[332]` **Narrator**: "Some time later, you received a ..." |
| `[304]` | **"1965\|Rizia"** | `[336]` **Player_Romus**: "...embraced her."<br>`[337]` **Player_Romus**: "...couldn't hold back your tears."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Player_Romus**: "Years passed." |
| `[309]` | **"You worried about the future."** | `[308]` **Narrator**: "Days later, the news reached you..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[332]` **Narrator**: "Some time later, you received a ..." |
| `[314]` | **"War, war never changes."** | `[300]` **Narrator**: "The next day, a chilling announc..."<br>`[313]` **Narrator**: "The next day, a chilling announc..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[332]` **Narrator**: "Some time later, you received a ..." |
| `[315]` | **"You were happy you didn't have to clean up the mess."** | `[308]` **Narrator**: "Days later, the news reached you..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[332]` **Narrator**: "Some time later, you received a ..." |
| `[316]` | **"You wished you could take charge of the situation."** | `[308]` **Narrator**: "Days later, the news reached you..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[332]` **Narrator**: "Some time later, you received a ..." |
| `[322]` | **"...nodded, but all you wanted was to see Pabel."** | `[233]` **Narrator**: "After months, your family was fi..."<br>`[237]` **Narrator**: "After months, your family was fi..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[323]` | **"Years passed."** | `[304]` **Narrator**: "Little by little, your legacy di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Narrator**: "Inside the walls of your cell, t..." |
| `[330]` | **"1959\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Player_Romus**: "...couldn't hold back your tears."<br>`[336]` **Player_Romus**: "...embraced her."<br>*(oraz 2 innych odgałęzień)* |
| `[332]` | **"1959\|Porte Drazon"** | `[309]` **Player_Romus**: "You worried about the future."<br>`[314]` **Player_Romus**: "War, war never changes."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["BaseGame.Ending_WorldWar"] == false`<br>`(Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false` | *Brak zmian stanu* | `[341]` **Player_Romus**: "...urged her to go elsewhere, kn..."<br>`[337]` **Player_Romus**: "...couldn't hold back your tears."<br>*(oraz 2 innych odgałęzień)* |
| `[336]` | **"...embraced her."** | `[330]` **Narrator**: "A year later, Vina visited once ..."<br>`[332]` **Narrator**: "Some time later, you received a ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[304]` **Narrator**: "Little by little, your legacy di..." |
| `[337]` | **"...couldn't hold back your tears."** | `[330]` **Narrator**: "A year later, Vina visited once ..."<br>`[332]` **Narrator**: "Some time later, you received a ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[304]` **Narrator**: "Little by little, your legacy di..." |
| `[338]` | **"...apologized for everything."** | `[332]` **Narrator**: "Some time later, you received a ..."<br>`[383]` **Narrator**: "Some time later, you received a ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[304]` **Narrator**: "Little by little, your legacy di..." |
| `[339]` | **"...wished the best for them."** | `[330]` **Narrator**: "A year later, Vina visited once ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[304]` **Narrator**: "Little by little, your legacy di..." |
| `[341]` | **"...urged her to go elsewhere, knowing she'd never truly be safe at home."** | `[332]` **Narrator**: "Some time later, you received a ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[304]` **Narrator**: "Little by little, your legacy di..." |
| `[342]` | **"1970\|Rizia"** | `[323]` **Player_Romus**: "Years passed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Player_Romus**: "Until it faded away." |
| `[343]` | **"Until it faded away."** | `[342]` **Narrator**: "Inside the walls of your cell, t..." | *Brak (Dostępna bezwarunkowo)* | `UnlockAchievement("Rizia_Epilogue_Prison");` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[345]` | **"Until one day, the cell door opened."** | `[171]` **Narrator**: "At some point, you lost track of..." | `Variable["RiziaDLC.Coup_Leader_Hugo"] == true  and  Variable["RiziaDLC.Hugo_Resigned"] == false  and  Variable["RiziaDLC.Hugo_RicoNotPardoned"] == false`<br>`((Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false` | *Brak zmian stanu* | `[158]` **Narrator**: "Your release came as part of the..." |
| `[346]` | **"You felt your mind slipping away."** | `[171]` **Narrator**: "At some point, you lost track of..." | `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true` | *Brak zmian stanu* | `[12]` **Narrator**: "You were in a dark tunnel with n..." |
| `[349]` | **"Until one day, the cell door opened."** | `[171]` **Narrator**: "At some point, you lost track of..." | `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true` | *Brak zmian stanu* | `[199]` **Narrator**: "Thousands were being released fr..." |
| `[353]` | **""Rom -- the new regime reinstituted the homosexuality ban, and your brute of a bod..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[357]` | **""Rom -- the new regime reinstituted the homosexuality ban, and I made it out of th..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "You heard rumors that King Hugo ..."<br>`[254]` **Narrator**: "You heard rumors that King Ricar..." |
| `[358]` | **"Long live the Queen."** | `[247]` **Narrator**: "You heard rumors that Queen Ange..."<br>`[258]` **Narrator**: "You heard rumors that Queen Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "After months, your family was fi..." |
| `[363]` | **"...apologized for all the trouble she'd gone through because of you."** | `[233]` **Narrator**: "After months, your family was fi..."<br>`[367]` **Narrator**: "After months, your family was fi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[313]` **Narrator**: "The next day, a chilling announc..."<br>`[300]` **Narrator**: "The next day, a chilling announc..." |
| `[383]` | **"1959\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Player_Romus**: "...couldn't hold back your tears."<br>`[336]` **Player_Romus**: "...embraced her."<br>*(oraz 1 innych odgałęzień)* |
| `[388]` | **"1959\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Player_Romus**: "...couldn't hold back your tears."<br>`[336]` **Player_Romus**: "...embraced her."<br>*(oraz 1 innych odgałęzień)* |
| `[392]` | **"1959\|Porte Drazon"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Player_Romus**: "...couldn't hold back your tears."<br>`[336]` **Player_Romus**: "...embraced her."<br>*(oraz 2 innych odgałęzień)* |
| `[393]` | **"...felt bitter that you couldn't watch her grow up."** | `[330]` **Narrator**: "A year later, Vina visited once ..."<br>`[392]` **Narrator**: "A year later, Vina finally visit..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[304]` **Narrator**: "Little by little, your legacy di..." |

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
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_jail")"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_ConstitutionSigning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_ConstitutionSigning == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Prison_ConstitutionSigning == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_ConstitutionSigning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_ConstitutionSigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "Jump to: [Prison Constitution Signing]"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Prison_ConstitutionSigning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_ConstitutionSigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "Jump to: [Prison House Fallouts Hub]"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Prison Constitution Signing`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Prison House Fallouts Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Prison Constitution Signing]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "Prison Constitution Signing"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Prison House Fallouts Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "Prison House Fallouts Hub"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Prison Revolution Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Prison Revolution Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "Prison Revolution Hub"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was Lucita, growing further and further away from you.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true` AND `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[346]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "...ran after her as fast as you could."*)
  - -> `[13]` (*Player_Romus: "...could not make sense of what was happening."*)
  - -> `[21]` (*Player_Romus: "...told her to stay with you."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could not make sense of what was happening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ran after her as fast as you could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator), `[26]` (Narrator), `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told her to stay with you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator), `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was Pabel, growing further and further away from you.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Player_Romus), `[67]` (Player_Romus), `[343]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: "...ran after him as fast as you could."*)
  - -> `[24]` (*Player_Romus: "...could not make sense of what was happening."*)
  - -> `[25]` (*Player_Romus: "...told him to stay with you."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ran after him as fast as you could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could not make sense of what was happening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[26]` (Narrator), `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told him to stay with you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was Lena, growing further and further away from you.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "...ran after her as fast as you could."*)
  - -> `[21]` (*Player_Romus: "...told her to stay with you."*)
  - -> `[24]` (*Player_Romus: "...could not make sense of what was happening."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "You heard a deep bellow from right behind you. It sounded like something was grunting within the darkness.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: "...turned around to face it."*)
  - -> `[30]` (*Player_Romus: "...did not dare to move."*)
  - -> `[32]` (*Player_Romus: "...ran for your life."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt the brush of something soft."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[34]` (Narrator), `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "A rat was looking at you.  You had lost track of the pass..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "A rat was looking at you.

You had lost track of the passage of time long ago. It had been at least a few months, you thought, but it did not matter anymore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: "The cell door opened."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not dare to move."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "It was the most magnificent bull you had ever seen. Its h..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "It was the most magnificent bull you had ever seen. Its hair was black as night, its eyes red with rage.

With a challenging roar, the bull pawed the ground and charged at you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: "...felt the brush of something soft."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ran for your life."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "But, there was no escape. It appeared right before you. I..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...turned around to face it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "It was the most magnificent bull you had ever seen. Its h..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "It was the most magnificent bull you had ever seen. Its hair was black as night, its eyes red with rage.

With a challenging roar, the bull pawed the ground and charged at you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: "...felt the brush of something soft."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "But, there was no escape. It appeared right before you. It was the most magnificent bull you had ever seen. Its hair was black as night, its eyes red with rage.

With a challenging roar, the bull pawed the ground and charged at you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: "...felt the brush of something soft."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The cell door opened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_DiedInPrison = true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The warden entered your cell to read you your final rites before the execution.

He asked what you wanted for your final meal.

You requested..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: "...a bottle of wine."*)
  - -> `[40]` (*Player_Romus: "...a rizetta."*)
  - -> `[39]` (*Player_Romus: "...Toras flambeé."*)
  - -> `[38]` (*Player_Romus: "...nothing."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "After your meal, you were dragged through a tunnel, just ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...Toras flambeé."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "After your meal, you were dragged through a tunnel, just ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a rizetta."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "After your meal, you were dragged through a tunnel, just ..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "After your meal, you were dragged through a tunnel, just like the one from your dream.

You looked around, but..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: "...the bull was nowhere to be found."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the bull was nowhere to be found."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_guillotine")"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Among the cheers of the crowd, the executioners made you kneel for the guillotine.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: "...tried to get away with all your might."*)
  - -> `[48]` (*Player_Romus: "...did not resist at all."*)
  - -> `[50]` (*Player_Romus: "...accepted your fate with dignity."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The blade dropped."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_light")"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "And so passed His Majesty, Romus of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Son_Romus == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The last of his name."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Son_Romus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Epilogue_Death");"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "It was all for naught.

You looked up and saw the sharp blade glimmering in the sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Guillotine");"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not resist at all."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "You looked up and saw the sharp blade glimmering in the sun."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to get away with all your might."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "It was all for naught.  You looked up and saw the sharp b..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...accepted your fate with dignity."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "You looked up and saw the sharp blade glimmering in the sun."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "You looked up and saw the sharp blade glimmering in the sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Guillotine");"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a bottle of wine."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Epilogue Taddeus Coup Arrest`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Death In Prison"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Guillotine");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Guillotine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: "The blade dropped."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Guillotine");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Guillotine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: "The blade dropped."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_jail")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_guillotine")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_guillotine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Among the cheers of the crowd, the executioners made you ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_light")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "And so passed His Majesty, Romus of House Toras."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "After your meal, you were dragged through a tunnel, just ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "After your meal, you were dragged through a tunnel, just ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Son_Romus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Son_Romus == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Son_Romus == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Son_Romus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Son_Romus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: "The second-to-last of his name."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Son_Romus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Son_Romus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: "The last of his name."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The second-to-last of his name."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Son_Romus"] == true`
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Epilogue_Death");"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was your mother, growing further and further away from you.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "...ran after her as fast as you could."*)
  - -> `[24]` (*Player_Romus: "...could not make sense of what was happening."*)
  - -> `[72]` (*Player_Romus: "...cursed her for giving birth to you."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...cursed her for giving birth to you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "You heard a deep bellow from right behind you. It sounded..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Reform == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Rumors seeped through the prison walls. The coupists had ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "At least you fought for something greater, for a better world."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[124]` (Narrator), `[266]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't help but wish you had crushed your enemies when you had the chance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[124]` (Narrator), `[266]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The coupists had crushed Rizia's nascent democracy and were unleashing a violent crackdown on the reformists.

The House of Delegates had been dismantled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: "At least you fought for something greater, for a better w..."*)
  - -> `[77]` (*Player_Romus: "You couldn't help but wish you had crushed your enemies w..."*)
  - -> `[81]` (*Player_Romus: "It seemed pointless now, worrying about what could have b..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt nothing but the weight of time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...counted each day, a silent rebellion against your fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It seemed pointless now, worrying about what could have been."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[124]` (Narrator), `[266]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Power had been a fragile thing, bestowed and then forcibly taken away. In the Citadel, days turned into weeks. 

The same walls that had once confined criminals and traitors during your reign now held you captive.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: "...found bitter irony in this cruel twist of fate."*)
  - -> `[79]` (*Player_Romus: "...felt nothing but the weight of time."*)
  - -> `[80]` (*Player_Romus: "...counted each day, a silent rebellion against your fate."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...found bitter irony in this cruel twist of fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator), `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "1957|Porte Drazon"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Houses Toras and Azaro united behind Hugo after you were ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "All three noble houses united behind Hugo after you were ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Houses Toras and Sazon united behind Hugo after you were ..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Houses Sazon and Azaro united behind General Taddeus afte..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "All three noble houses united behind Hugo after you were declared a traitor to the Crown.

Their forces swept across the kingdom while you were behind bars, eliminating your last remaining loyalists and other threats to their rule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: "And then came the news -- Hugo had been crowned king."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Houses Toras and Sazon united behind Hugo after you were declared a traitor to the Crown.

While you sat behind bars, their forces swept across the kingdom, crushing your last remaining loyalists and using the chaos to weaken House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: "And then came the news -- Hugo had been crowned king."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Houses Toras and Azaro united behind Hugo after you were declared a traitor to the Crown.

While you sat behind bars, their forces swept across the kingdom, crushing your last remaining loyalists and using the chaos to strike House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: "And then came the news -- Hugo had been crowned king."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Houses Sazon and Azaro united behind General Taddeus after you were declared a traitor to the Crown.

While you sat behind bars, their forces swept across the kingdom, using the opportunity to crush House Toras and your loyalists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: "And then came the news -- Taddeus had been crowned king."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "While you sat behind bars, House Azaro's forces swept acr..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "All three noble houses united behind Hugo after you were ..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "While you sat behind bars, House Sazon's forces swept across the kingdom, seizing the opportunity to strike Houses Toras and Azaro.

In response, the Azaros rallied behind Hugo to stop them, preventing the country from descending to chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: "And then came the news -- Hugo had been crowned king."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And then came the news -- Hugo had been crowned king."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator), `[98]` (Narrator), `[99]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo = true"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "While you sat behind bars, House Azaro's forces swept across the kingdom, seizing the opportunity to strike Houses Toras and Sazon.

In response, the Sazons rallied behind Hugo to stop them, preventing the country from descending to chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: "And then came the news -- Hugo had been crowned king."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "While you sat behind bars, House Sazon's forces swept acr..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "All three noble houses united behind Hugo after you were ..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And then came the news -- Taddeus had been crowned king."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "News had been scarce since you were branded a traitor to ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "News had been scarce since you were branded a traitor to the Crown and thrown into jail by Titus.

But then, word arrived -- Hugo had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "News had been scarce since you were arrested by the coupi..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == ..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Rumors seeped through the prison walls. The Crown's force..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The Crown's forces were crushing revolutionaries and the reformists across Rizia.

Adarfo Sotelato's movement, once a beacon of hope, had withered into nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: "At least you fought for something greater, for a better w..."*)
  - -> `[77]` (*Player_Romus: "You couldn't help but wish you had crushed your enemies w..."*)
  - -> `[81]` (*Player_Romus: "It seemed pointless now, worrying about what could have b..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || Riz..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Hugo had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "News had been scarce since you were arrested by the coupi..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[130]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Rico had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "News had been scarce since you were arrested by the coupi..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "News had been scarce since you were arrested by the coupi..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "News had been scarce since you were arrested by the coupi..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Lucita had been officially crowned queen in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Taddeus had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Angelica had been officially crowned queen in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: "The days passed."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The days passed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator), `[126]` (Narrator), `[130]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "At some point, you lost track of the passage of time. Had..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Angelica == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: "...by the royal decree of Queen Angelica Sazon, your exis..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: "...by the royal decree of King Hugo Toras, your life shal..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: "...under the royal decree of King Rico Toras, your life i..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player_Romus: "...by the royal decree of King Taddeus Azaro, your life i..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Su..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: "...by the royal decree of Queen Lucita Azaro, you were to..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: "...by the royal decree of Queen Lucita Azaro, your life i..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of King Hugo Toras, your life shall be spared, your honor reinstated, and your family granted amnesty."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Fully free at last, life could begin anew. For the first ..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "Your release came as part of the Sovereign Transition and Clemency Act signed by Rizia's new monarch.

On your way out you were handed a letter that read..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[345]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true"*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...under the royal decree of King Rico Toras, your life is hereby preserved, your honor reclaimed, and the safety of your family assured."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Fully free at last, life could begin anew. For the first ..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of King Taddeus Azaro, your life is spared, your honor restored, and your family's sanctity upheld."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "Jump to: [JumpFromPrison]"*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, your life is spared, your honor redeemed, and your family's well-being guaranteed."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true) == false` AND `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "Jump to: [JumpFromPrison]"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Angelica Sazon, your existence is spared, your honor renewed, and your family's safety preserved."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "Jump to: [JumpFromPrison]"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "To circumvent any potential for political unrest in the capital, Queen Lucita moved your imprisonment to Iza, far from Porte Drazon. 

You were relocated to a slightly better jail cell with a view of the city skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Jump to: [EpilogueIza]"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EpilogueIza]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: "...found bitter irony in this cruel twist of fate."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Fully free at last, life could begin anew. For the first time since birth, choosing your destiny was in your hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: "A fresh start awaited."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, you were to be released in one month's time."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true` AND `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "To circumvent any potential for political unrest in the c..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A fresh start awaited."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "Jump to: [JumpFromPrison]"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Su..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
Mówca: **Narrator**
> "At some point, you lost track of the passage of time. Had you been in the Citadel for weeks, or months? There was no way of knowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike ==..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player_Romus: "You felt your mind slipping away."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: "Until one day, the cell door opened."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resigned == false && RiziaDLC.Hugo_RicoNotPardoned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resign..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resi..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resigned == false && RiziaDLC.Hugo_RicoNotPardoned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true  and  Variable["RiziaDLC.Hugo_Resigned"] == false  and  Variable["RiziaDLC.Hugo_RicoNotPardoned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: "Until one day, the cell door opened."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resigned == false && RiziaDLC.Hugo_RicoNotPardoned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true  and  Variable["RiziaDLC.Hugo_Resigned"] == false  and  Variable["RiziaDLC.Hugo_RicoNotPardoned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_Ro..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_RomanceHappened == true && RiziaDLC.Taddeus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_Ro..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_RomanceHappened == true && RiziaDLC.Taddeus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Lucita_RomanceHappened"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: "Until one day, the cell door opened."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_RomanceHappened == true && RiziaDLC.Taddeus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Lucita_RomanceHappened"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_E..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_E..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: "Until one day, the cell door opened."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Gone == true && RiziaDLC.Manus_ConvinceToLeave == false && RiziaDLC.Manus_DiesInWar == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manu..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Gone == true && RiziaDLC.Manus_ConvinceToLeave == false && RiziaDLC.Manus_DiesInWar == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Manus_ConvinceToLeave"] == false  and  Variable["RiziaDLC.Manus_DiesInWar"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: "Until one day, the cell door opened."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Gone == true && RiziaDLC.Manus_ConvinceToLeave == false && RiziaDLC.Manus_DiesInWar == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Manus_ConvinceToLeave"] == false  and  Variable["RiziaDLC.Manus_DiesInWar"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_E..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death In Prison]"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Execut..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_E..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death In Prison]"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_E..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Execut..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Exec..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true  and  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death In Prison]"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true  and  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manu..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [Death In Prison]"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "Thousands were being released from prison. Their freedom came as part of the Sovereign Transition and Clemency signed by the new monarch. But for you, there was no amnesty.

The warden handed you a letter that read..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [JumpFromPrison]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted you to know that I have given birth to our son, {RiziaDLCText.KingsSon}, the future King of Rizia. May he grow up to be a more noble and honorable man than his father. Sincerely, Queen Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true) && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leade..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true) && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""I wanted you to know that I have given birth to our son,..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true) && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.Coup_Leader_Taddeus == false && RiziaDLC.Coup_Leader_Lucita == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.Coup_Leader_Taddeus == false && RiziaDLC.Coup_Leader_Lucita == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Romus: ""I am writing this from exile -- I will not tell you wher..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.Coup_Leader_Taddeus == false && RiziaDLC.Coup_Leader_Lucita == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am writing this from exile -- I will not tell you where for my protection and that of our newborn son, {RiziaDLCText.KingsSon}. I will raise him well and keep him safe until the day you are able to join us. Love always, Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted you to know that I have given birth to your son, {RiziaDLCText.KingsSon}. May he grow up to be a more noble and honorable man than his father. Yours truly, Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""I wanted you to know that I have given birth to your son..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""Darling -- the bastards are pressuring me to make a show..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted you to know that I tried to see you, but they would not allow it. Not family, they said. As if love needs permission. But I will not give up hope. Bi mare volu, un oxit solu -- P.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Darling -- the bastards are pressuring me to make a show of fealty to the new regime. No matter what you see or read in there, know that in my heart there is only one true King of Rizia, and that's my son. Love always, Estela.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vin..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.V..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_H..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDL..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Es..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Es..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)

### Węzeł `[233]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Your daughter told you that the new leadership had forced her to sign a document renouncing her claim to the throne. In exchange, she and Axel were allowed to live in Pales in peace.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[363]` (*Player_Romus: "...apologized for all the trouble she'd gone through beca..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)

### Węzeł `[237]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that life in Pales was good, and that she and Axel were trying to get you extradited to the Grand Duchy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[274]` (*Player_Romus: "...said they shouldn't waste their time on false hope."*)
  - -> `[275]` (*Player_Romus: "...smiled, knowing that even in prison, you were not forg..."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela when she came to see you for the first time since you were arrested. A threat to nobody, she'd been granted a modest residence of her own in Porte Drazon.

Vina wasn't with her. Your mother assured you she'd visit when she was ready.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[272]` (*Player_Romus: "...missed your daughter more than anything."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that she and Rico had filed for divorce. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that she and Manus were fighting to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[274]` (*Player_Romus: "...said they shouldn't waste their time on false hope."*)
  - -> `[275]` (*Player_Romus: "...smiled, knowing that even in prison, you were not forg..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

They told you that they were doing anything they can to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[274]` (*Player_Romus: "...said they shouldn't waste their time on false hope."*)
  - -> `[275]` (*Player_Romus: "...smiled, knowing that even in prison, you were not forg..."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela when she came to see you for the first time since you were arrested.

A threat to nobody, she'd been granted a modest residence of her own in Porte Drazon, not far from the palace.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[272]` (*Player_Romus: "...missed your daughter more than anything."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "You heard rumors that King Hugo Toras was garnering respe..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[246]`
Mówca: **Narrator**
> "You heard rumors that King Hugo Toras was garnering respect from older citizens, who hailed him as "The Protector King."

According to the Royal Herald, he was championing education and traditional values."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: "Long live the King."*)
  - -> `[267]` (*Player_Romus: "You couldn't care less."*)
  - -> `[268]` (*Player_Romus: "You cursed his name."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "You heard rumors that Queen Angelica Sazon garnered much respect from the Rizian gentry. 

According to the Royal Herald, she championed liberal values without losing sight of tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: "Long live the Queen."*)
  - -> `[267]` (*Player_Romus: "You couldn't care less."*)
  - -> `[270]` (*Player_Romus: "You cursed her name."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "You heard rumors that King Hugo Toras was garnering respe..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "You heard rumors that King Ricardus Toras had instilled a..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[254]`
Mówca: **Narrator**
> "You heard rumors that King Ricardus Toras had instilled a newfound sense of nationalism and monarchism in Rizia. 

According to the Royal Herald, he was about to institute strict border bans and incorporate Su Omina into the kingdom's national security forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: "Long live the King."*)
  - -> `[267]` (*Player_Romus: "You couldn't care less."*)
  - -> `[268]` (*Player_Romus: "You cursed his name."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "You heard rumors that Queen Lucita Azaro's popularity had..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[258]`
Mówca: **Narrator**
> "You heard rumors that Queen Lucita Azaro's popularity had extended beyond Cardesse-Montaklar, overshadowing the legacy of House Toras. 

According to the Royal Herald, she planned to expand the powers of the Rizian Armed Forces, giving them a greater role in government even during peacetime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: "Long live the Queen."*)
  - -> `[267]` (*Player_Romus: "You couldn't care less."*)
  - -> `[270]` (*Player_Romus: "You cursed her name."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "You heard rumors that King Taddeus Azaro infused a newfou..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "You heard rumors that Queen Angelica Sazon garnered much ..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "You heard rumors that King Taddeus Azaro infused a newfound sense of militarism and monarchism in Rizia. 

According to the Royal Herald, he planned to expand the powers of the Rizian Armed Forces, giving them a greater role in government even during peacetime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: "Long live the King."*)
  - -> `[267]` (*Player_Romus: "You couldn't care less."*)
  - -> `[268]` (*Player_Romus: "You cursed his name."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path == true || RiziaDLC.Adarfo_AbdicationPath == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Pa..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path == true || RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == false  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Rumors seeped through the prison walls. The Crown's force..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path == true || RiziaDLC.Adarfo_AbdicationPath == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == false  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The Crown's forces were crushing the reformists and their collaborators across Rizia.

The reform movement, once a beacon of hope, had withered into nothing but a stillborn dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: "At least you fought for something greater, for a better w..."*)
  - -> `[77]` (*Player_Romus: "You couldn't help but wish you had crushed your enemies w..."*)
  - -> `[81]` (*Player_Romus: "It seemed pointless now, worrying about what could have b..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't care less."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Narrator), `[247]` (Narrator), `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vin..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You cursed his name."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Narrator), `[254]` (Narrator), `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vin..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the King."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Narrator), `[254]` (Narrator), `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vin..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You cursed her name."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vin..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...listened in silence, unsure what to feel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[237]` (Narrator), `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...missed your daughter more than anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator), `[242]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...clung to her every word, desperate to know about the world outside your four walls."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[237]` (Narrator), `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...said they shouldn't waste their time on false hope."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator), `[240]` (Narrator), `[241]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...smiled, knowing that even in prison, you were not forgotten."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator), `[240]` (Narrator), `[241]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: "...nodded, but all you wanted was to see your son."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...nodded, but all you wanted was to see your son."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[237]` (Narrator), `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || RiziaDLC.Coup_Leader_Hugo == true || RiziaDLC.Coup_Leader_Rico == true || RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true || RiziaDLC.Coup_Leader_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || Riz..."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || R..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || RiziaDLC.Coup_Leader_Hugo == true || RiziaDLC.Coup_Leader_Rico == true || RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true || RiziaDLC.Coup_Leader_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  Variable["RiziaDLC.Coup_Leader_Rico"] == true  or  Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  or  Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || RiziaDLC.Coup_Leader_Hugo == true || RiziaDLC.Coup_Leader_Rico == true || RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true || RiziaDLC.Coup_Leader_Angelica == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  Variable["RiziaDLC.Coup_Leader_Rico"] == true  or  Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  or  Variable["RiziaDLC.Coup_Leader_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "At some point, you lost track of the passage of time. Had..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The next day, you received news of the Palesian forces' u..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "The next day, you received news that the war had come to ..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Rumors seeped through the prison walls. The Crown's force..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || Riz..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The Crown's forces were crushing the unrest and all reformist collaborators across Rizia.

The reform movement, once a beacon of hope, had withered into nothing but a stillborn dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Romus: "You couldn't help but wish you had crushed your enemies w..."*)
  - -> `[81]` (*Player_Romus: "It seemed pointless now, worrying about what could have b..."*)
  - -> `[295]` (*Player_Romus: "At least order had been restored."*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "At least order had been restored."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[296]`
Mówca: **Narrator**
> "The next day, you received news of the Palesian forces' unconditional surrender.

Newspapers were filled with images of Axel Reinhart, bound and escorted by Rizian soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: "War, war never changes."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "The next day, you received news that the war had come to an end -- not in conquest, but in compromise. Rizia and Pales had agreed to settle with pre-war borders, neither side claiming victory.

Newspapers were filled with images of Axel Reinhart, walking tall as he left the negotiation table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: "War, war never changes."*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "War, war never changes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Narrator), `[297]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_..."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "The next day, a chilling announcement halted the continent: a devastating nuclear exchange had ravaged Holsord and parts of Rumburg.

The AN moved swiftly to contain the crisis, but their intervention did little to stop the unraveling of peace. Instead, tensions exploded across Eastern Merkopa, igniting a continental conflict.

The Pales-Rizia war, once a regional struggle, turned into another battleground in a far greater catastrophe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: "War, war never changes."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_WorldWar == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_WorldWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[304]`
**[WYBÓR GRACZA: "1965|Rizia"]** — Mówca: **Narrator**
> "Little by little, your legacy dissolved into obscurity. 

The eight years you spent as king became little more than a footnote in history, while you remained trapped in the past.

Estela's visits became less and less frequent as her health failed. Then, they stopped entirely."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Player_Romus), `[337]` (Player_Romus), `[338]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player_Romus: "Years passed."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true || BaseGame.Endin..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "Days later, the news reached your cell: War had broken ou..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[308]`
Mówca: **Narrator**
> "Days later, the news reached your cell: War had broken out between Rumburg and Sordland.

The toll was already steep, with no end in sight. While the battles themselves were distant, the war's impact was felt in Rizia, where Rumburgian refugees were reluctant to return to their ravaged homeland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player_Romus: "You were happy you didn't have to clean up the mess."*)
  - -> `[309]` (*Player_Romus: "You worried about the future."*)
  - -> `[316]` (*Player_Romus: "You wished you could take charge of the situation."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You worried about the future."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == false)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "The next day, a chilling announcement halted the continen..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "The next day, a chilling announcement halted the continen..."*)

### Węzeł `[313]`
Mówca: **Narrator**
> "The next day, a chilling announcement halted the continent: a devastating nuclear exchange had ravaged Holsord and parts of Rumburg.

The AN moved swiftly to contain the crisis, but their intervention did little to stop the unraveling of peace. Instead, tensions exploded across Eastern Merkopa, igniting a continental conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: "War, war never changes."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "War, war never changes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Narrator), `[313]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were happy you didn't have to clean up the mess."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wished you could take charge of the situation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player_Romus: "...nodded, but all you wanted was to see Pabel."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player_Romus: "...clung to her every word, desperate to know about the w..."*)
  - -> `[271]` (*Player_Romus: "...listened in silence, unsure what to feel."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...nodded, but all you wanted was to see Pabel."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[237]` (Narrator), `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Years passed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "1970|Rizia"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_Revolution_Surrounded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [Prison Revolution Hub]"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_Revolution_Surrounded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_ConstitutionSigning == true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC...."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[330]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "A year later, Vina visited once more, bringing along a surprise: her baby daughter Lena, named after her grandmother.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: "...couldn't hold back your tears."*)
  - -> `[336]` (*Player_Romus: "...embraced her."*)
  - -> `[339]` (*Player_Romus: "...wished the best for them."*)
  - -> `[393]` (*Player_Romus: "...felt bitter that you couldn't watch her grow up."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[332]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "Some time later, you received a surprise visitor: Vina.

After the war ended, she had finally been allowed to leave Pales. 

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["BaseGame.Ending_WorldWar"] == false` AND `(Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[309]` (Player_Romus), `[314]` (Player_Romus), `[315]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player_Romus: "...urged her to go elsewhere, knowing she'd never truly b..."*)
  - -> `[337]` (*Player_Romus: "...couldn't hold back your tears."*)
  - -> `[336]` (*Player_Romus: "...embraced her."*)
  - -> `[338]` (*Player_Romus: "...apologized for everything."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar..."*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldW..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["BaseGame.Ending_WorldWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "1959|Porte Drazon"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["BaseGame.Ending_WorldWar"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...embraced her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Narrator), `[332]` (Narrator), `[383]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...couldn't hold back your tears."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Narrator), `[332]` (Narrator), `[383]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...apologized for everything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Narrator), `[383]` (Narrator), `[388]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished the best for them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "1965|Rizia"*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...urged her to go elsewhere, knowing she'd never truly be safe at home."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[342]`
**[WYBÓR GRACZA: "1970|Rizia"]** — Mówca: **Narrator**
> "Inside the walls of your cell, time had no meaning. The days blurred together, indistinguishable from one another.

You had nothing left but your thoughts—fragments of a life that once was, replayed over and over, growing fainter and fainter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[323]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: "Until it faded away."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Until it faded away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[342]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Epilogue_Prison");"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "At some point, you lost track of the passage of time. Had..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Until one day, the cell door opened."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true  and  Variable["RiziaDLC.Hugo_Resigned"] == false  and  Variable["RiziaDLC.Hugo_RicoNotPardoned"] == false` AND `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You felt your mind slipping away."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Kontekst wejściowy (poprzednik):** `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_E..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Death In Prison`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Death In Prison]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Death In Prison"*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Until one day, the cell door opened."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Kontekst wejściowy (poprzednik):** `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "1958|Porte Drazon"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Angelica == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Angelica == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player_Romus: ""I wanted you to know that I tried to see you, but they w..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_TitusBetrays == true || Rizia..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rom -- the new regime reinstituted the homosexuality ban, and your brute of a bodyguard turned me in immediately. No matter what happens to either of us, I love you and regret nothing. Bi mare volu, un oxit solu -- P.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_TitusBetrays == true || RiziaDLC.LateGameCoup_TitusBetrays == true) && RiziaDLC.Turn05_MurderInvest_SuspectPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_TitusBetrays == true || Rizia..."*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_TitusBetrays == true || Riz..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_TitusBetrays == true || RiziaDLC.LateGameCoup_TitusBetrays == true) && RiziaDLC.Turn05_MurderInvest_SuspectPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] == true  or  Variable["RiziaDLC.LateGameCoup_TitusBetrays"] == true)  and  Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""Rom -- the new regime reinstituted the homosexuality ban..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_TitusBetrays == true || RiziaDLC.LateGameCoup_TitusBetrays == true) && RiziaDLC.Turn05_MurderInvest_SuspectPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] == true  or  Variable["RiziaDLC.LateGameCoup_TitusBetrays"] == true)  and  Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player_Romus: ""Rom -- the new regime reinstituted the homosexuality ban..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rom -- the new regime reinstituted the homosexuality ban, and I made it out of the country just in time. If you're ever released, find me in Derdia. Bi mare volu, un oxit solu -- P.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true"*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the Queen."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vin..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Vina == true)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that life in the newly reunited Province of Pales was flourishing.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...apologized for all the trouble she'd gone through because of you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator), `[367]` (Narrator), `[371]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Vina == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[367]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that the new leadership had forced her to sign a document renouncing her claim to the throne. She and Axel were trying hard to get you extradited to the Grand Duchy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[363]` (*Player_Romus: "...apologized for all the trouble she'd gone through beca..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_Hugo == false && RiziaDLC.Coup_Leader_Rico == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_H..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_Hugo == false && RiziaDLC.Coup_Leader_Rico == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Coup_Leader_Hugo"] == false  and  Variable["RiziaDLC.Coup_Leader_Rico"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_Hugo == false && RiziaDLC.Coup_Leader_Rico == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Coup_Leader_Hugo"] == false  and  Variable["RiziaDLC.Coup_Leader_Rico"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that the new leadership had forced her to sign a document renouncing her claim to the throne. Now that she no longer had to carry on the royal bloodline, she and Rico had filed for divorce. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[363]` (*Player_Romus: "...apologized for all the trouble she'd gone through beca..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Vina == true )"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Vina == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[375]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that the new leadership had forced her to sign a document renouncing her claim to the throne. In exchange, she and Manus were allowed to live in Porte Drazon in peace. They were trying to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[363]` (*Player_Romus: "...apologized for all the trouble she'd gone through beca..."*)
  - -> `[274]` (*Player_Romus: "...said they shouldn't waste their time on false hope."*)
  - -> `[275]` (*Player_Romus: "...smiled, knowing that even in prison, you were not forg..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Vina == true"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Vina == true )"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Vina == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "After months, your family was finally given allowance to ..."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you she'd been forced to sign an official document renouncing her claim to the throne. She and her grandmother were now doing everything they could to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[274]` (*Player_Romus: "...said they shouldn't waste their time on false hope."*)
  - -> `[275]` (*Player_Romus: "...smiled, knowing that even in prison, you were not forg..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "Some time later, you received a surprise visitor, a woman you barely recognized. Vina.

After her escape from Palas Rezna, she'd traveled from country to country before secretly moving in with Manus in Kyrute. They now had a daughter together: Lena.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: "...couldn't hold back your tears."*)
  - -> `[336]` (*Player_Romus: "...embraced her."*)
  - -> `[338]` (*Player_Romus: "...apologized for everything."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_..."*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manu..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "1959|Porte Drazon"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "1959|Porte Drazon"*)

### Węzeł `[388]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "Some time later, you received a surprise visitor, a woman you barely recognized. Vina.

After her escape from Palas Rezna, she'd traveled from country to country before settling down as a commoner in Kyrute.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: "...couldn't hold back your tears."*)
  - -> `[336]` (*Player_Romus: "...embraced her."*)
  - -> `[338]` (*Player_Romus: "...apologized for everything."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "1959|Porte Drazon"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "1959|Porte Drazon"*)

### Węzeł `[392]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "A year later, Vina finally visited you. Although she still didn't want to be close with you, there was someone she wanted you to meet: her new baby daughter, Lena.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: "...couldn't hold back your tears."*)
  - -> `[336]` (*Player_Romus: "...embraced her."*)
  - -> `[338]` (*Player_Romus: "...apologized for everything."*)
  - -> `[393]` (*Player_Romus: "...felt bitter that you couldn't watch her grow up."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt bitter that you couldn't watch her grow up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Narrator), `[392]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true && RiziaDLC.BirthdayGathering_HouseStrike_Success == false) || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike ==..."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike ..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true && RiziaDLC.BirthdayGathering_HouseStrike_Success == false) || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true && RiziaDLC.BirthdayGathering_HouseStrike_Success == false) || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resign..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Epilogue_Death");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Epilogue_Death");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Epilogue_Prison");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Epilogue_Prison");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_DiedInPrison = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_DiedInPrison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The warden entered your cell to read you your final rites..."*)
