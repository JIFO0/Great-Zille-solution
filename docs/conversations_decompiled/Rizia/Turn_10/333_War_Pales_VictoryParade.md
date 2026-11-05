# Rizia/Turn 10/War_Pales_VictoryParade

- **ID konwersacji:** `333`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/333_War_Pales_VictoryParade.md`
- **Liczba węzłów dialogowych:** 376
- **Liczba wyborów gracza:** 47

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Enable_Policy_RD_Welfare_KingsCars`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_SendToWar`
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Situation_Military_Airforce_Defence_Strong`
- `RiziaDLC.Situation_Military_Airforce_Offence_Strong`
- `RiziaDLC.Situation_Military_Airforce_Total_Large`
- `RiziaDLC.Situation_Military_LostPrideOfNavy`
- `RiziaDLC.Situation_Military_Manpower_Average`
- `RiziaDLC.Situation_Military_Manpower_High`
- `RiziaDLC.Situation_Military_Manpower_Massive`
- `RiziaDLC.Situation_Military_Marines_LargeForce`
- `RiziaDLC.Situation_Military_MobileForces_Large`
- `RiziaDLC.Situation_Military_MobileForces_Medium`
- `RiziaDLC.Situation_Military_MorellanAirPlanes`
- `RiziaDLC.Situation_Military_RiziaFleet_Large`
- `RiziaDLC.Situation_Military_RiziaFleet_Medium`
- `RiziaDLC.Situation_Military_StrongPalesResistance`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Operation1Briefing_Frontline`
- `RiziaDLC.War_Used_ExperimentalWeapons_Pales`
- `RiziaDLC.War_Used_ExperimentalWeapons_Remaz`
- `RiziaDLC.War_Used_ExperimentalWeapons_Solles`
- `RiziaDLC.War_Used_ExperimentalWeapons_Ziqes`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Axel_Arrested`
- `RiziaDLC.Faction_HouseSazon_Angelica`
- `RiziaDLC.Faction_HouseSazon_Leona`
- `RiziaDLC.Faction_HouseSazon_Manus`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.War_Pales_Won_AxelTortured`
- `RiziaDLC.Win_Renamed_CastlePales`
- `RiziaDLC.Win_Renamed_CastleRomus`
- `RiziaDLC.Win_Renamed_CastleToras`
- `RiziaDLC.Win_Renamed_CastleVictory`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar`
- `RiziaDLCSupport.News_Turn10_V_ManusBackFromWarEngaged`
- `RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup`
- `RiziaDLCSupport.Reports_Turn10_Pales_War`
- `RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup`
- `RiziaDLCSupport.Reports_Turn10_Sallabes_ManusWarHero`
- `RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup`
- `RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"No need."** | `[8]` **Narrator**: "I wondered if I should have it r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operat...`<br>`AddConversant("Daria de Rava");`<br>*(+1 skryptów)* | `[217]` **Narrator**: "The gates opened with a heavy gr..."<br>`[237]` **Narrator**: "The gates opened with a heavy gr..." |
| `[10]` | **"Castle Victory."** | `[8]` **Narrator**: "I wondered if I should have it r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Win_Renamed_CastleVictory"] = true; Va...`<br>`AddConversant("Daria de Rava");`<br>*(+1 skryptów)* | `[217]` **Narrator**: "The gates opened with a heavy gr..."<br>`[237]` **Narrator**: "The gates opened with a heavy gr..." |
| `[11]` | **"Castle Toras."** | `[8]` **Narrator**: "I wondered if I should have it r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Win_Renamed_CastleToras"] = true; Vari...`<br>`AddConversant("Daria de Rava");`<br>*(+1 skryptów)* | `[217]` **Narrator**: "The gates opened with a heavy gr..."<br>`[237]` **Narrator**: "The gates opened with a heavy gr..." |
| `[12]` | **"Castle Romus."** | `[8]` **Narrator**: "I wondered if I should have it r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Win_Renamed_CastleRomus"] = true; Vari...`<br>`AddConversant("Daria de Rava");`<br>*(+1 skryptów)* | `[217]` **Narrator**: "The gates opened with a heavy gr..."<br>`[237]` **Narrator**: "The gates opened with a heavy gr..." |
| `[13]` | **"Castle Pales."** | `[8]` **Narrator**: "I wondered if I should have it r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Win_Renamed_CastlePales"] = true; Vari...`<br>`AddConversant("Daria de Rava");`<br>*(+1 skryptów)* | `[217]` **Narrator**: "The gates opened with a heavy gr..."<br>`[237]` **Narrator**: "The gates opened with a heavy gr..." |
| `[17]` | **"Gesture for her to approach and take the bouquet."** | `[16]` **Narrator**: "A child tried to approach my hor..."<br>`[362]` **Narrator**: "A child tried to approach my hor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "A few of our Morellan fighter je..."<br>`[37]` **Narrator**: "Rizian airplanes flew very close..." |
| `[18]` | **"Disregard her and follow the protocol."** | `[16]` **Narrator**: "A child tried to approach my hor..."<br>`[362]` **Narrator**: "A child tried to approach my hor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "A few of our Morellan fighter je..."<br>`[37]` **Narrator**: "Rizian airplanes flew very close..." |
| `[25]` | **""He's just an old man. Let him go. What is he even going to do?""** | `[27]` **Narrator**: "Titus looked towards me for orders."<br>`[323]` **Narrator**: "My guards looked towards me for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "The guards let him go. He cursed..." |
| `[26]` | **""Straight to prison. Make sure he learns his place.""** | `[27]` **Narrator**: "Titus looked towards me for orders."<br>`[323]` **Narrator**: "My guards looked towards me for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Adarfo Sotelato**: ""What?! Absolutely not.""<br>`[335]` **Manus Sazon**: ""Disregard His Majesty's order. ..."<br>*(oraz 2 innych odgałęzień)* |
| `[28]` | **""Off with his head.""** | `[27]` **Narrator**: "Titus looked towards me for orders."<br>`[323]` **Narrator**: "My guards looked towards me for ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[334]` **Adarfo Sotelato**: ""What?! Absolutely not.""<br>`[335]` **Manus Sazon**: ""Disregard His Majesty's order. ..."<br>*(oraz 2 innych odgałęzień)* |
| `[83]` | **"Pick it up and handle it with care and honor."** | `[82]` **Narrator**: "A half-burned Palesian flag land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "I approached the defeated man be..." |
| `[84]` | **"Step on the flag."** | `[82]` **Narrator**: "A half-burned Palesian flag land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "I approached the defeated man be..." |
| `[85]` | **"Rip it up in front of the crowd."** | `[82]` **Narrator**: "A half-burned Palesian flag land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "I approached the defeated man be..." |
| `[86]` | **"Salute them."** | `[74]` **Narrator**: "Each battleship deck was full of..."<br>`[78]` **Narrator**: "I could see the marines saluting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "In celebration, battleships cann..." |
| `[89]` | **""I won't be satisfied until you get down and lick my boots.""** | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Making the Grand-Duke kiss their boot","...` | `[98]` **Axel Reinhart**: ""What? That's ridiculous. We're ..." |
| `[91]` | **"Put the crown on your head."** | `[90]` **Narrator**: "He took the crown from his head ..." | *Brak (Dostępna bezwarunkowo)* | `EnableCollectionItem("CollectionItem_PalesCrown");` | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." |
| `[92]` | **"Shove the crown aside."** | `[90]` **Narrator**: "He took the crown from his head ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." |
| `[94]` | **""Apologize to your King. In front of everyone.""** | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Axel Reinhart**: ""I won't. I--"" |
| `[95]` | **""Kiss my ring.""** | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Axel Reinhart**: ""Come on. There's no need for--"" |
| `[96]` | **""I hope you enjoy your time in prison.""** | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Axel Reinhart**: ""Prison? I-"" |
| `[97]` | **""You fought valiantly, Axel.""** | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Axel Reinhart**: ""As did you."" |
| `[123]` | **""Have you heard of a device called 'Saint Mercy'? We haven't used it since last ce..."** | `[110]` **Axel Reinhart**: ""Prison? I-"" | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true` | `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true; V...` | `[310]` **Axel Reinhart**: ""You mean to torture me?! Now wa..." |
| `[166]` | **"Now that he'd proven himself, it was finally time."** | `[165]` **Narrator**: "After returning from the front, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true; ...`<br>`Variable["RiziaDLC.Faction_HouseSazon_Leona"] = false; Va...`<br>*(+2 skryptów)* | `[38]` **Narrator**: "I rode past by tanks and mechani..." |
| `[167]` | **"I'd refused."** | `[165]` **Narrator**: "After returning from the front, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....`<br>`Variable["RiziaDLC.Faction_HouseSazon_Leona"] = false; Va...`<br>*(+2 skryptów)* | `[38]` **Narrator**: "I rode past by tanks and mechani..." |
| `[179]` | **""Much appreciated. Guards, arrest this man for his many, many violent acts against..."** | `[100]` **Narrator**: "I smiled as he reluctantly stuck..."<br>`[103]` **Axel Reinhart**: ""I apologize. Your Majesty...""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Axel Reinhart**: ""What? But--"" |
| `[180]` | **""I will. Guards, arrest this man for his many, many violent acts against Rizia.""** | `[109]` **Axel Reinhart**: ""Take good care of it."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Axel Reinhart**: ""What? But--"" |
| `[182]` | **""You are a war criminal and you must be treated appropriately.""** | `[110]` **Axel Reinhart**: ""Prison? I-""<br>`[181]` **Axel Reinhart**: ""What? But--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Axel Reinhart**: ""A war criminal? How dare y--"" |
| `[183]` | **""As you walk free today, remember the mercy King Romus Toras showed you. It is mor..."** | `[100]` **Narrator**: "I smiled as he reluctantly stuck..."<br>`[103]` **Axel Reinhart**: ""I apologize. Your Majesty...""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "He bowed low to the ground." |
| `[184]` | **""You have done what any monarch would in your situation. You have my blessing to l..."** | `[100]` **Narrator**: "I smiled as he reluctantly stuck..."<br>`[103]` **Axel Reinhart**: ""I apologize. Your Majesty...""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "He bowed low to the ground." |
| `[188]` | **""One more thing. I want him tortured. The so-called Duke will beg for his life.""** | `[110]` **Axel Reinhart**: ""Prison? I-"" | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true; V...` | `[308]` **Axel Reinhart**: ""Torture?! Now wait a sec--""" |
| `[191]` | **""You will stay there until you have repented for your infringement on my kingdom's..."** | `[110]` **Axel Reinhart**: ""Prison? I-""<br>`[181]` **Axel Reinhart**: ""What? But--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Axel Reinhart**: ""I swear to you, I've repented a..." |
| `[193]` | **""Not another word from you, Reinhart.""** | `[110]` **Axel Reinhart**: ""Prison? I-""<br>`[181]` **Axel Reinhart**: ""What? But--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "He shut his mouth, resigned." |
| `[221]` | **""A reminder of why we keep fighting for Rizia’s future.""** | `[219]` **Daria de Rava**: ""What a glorious day for a parad..."<br>`[239]` **Manus Sazon**: ""A glorious day for a parade, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Daria de Rava**: ""A future worth fighting for, in..."<br>`[246]` **Manus Sazon**: ""Indeed, a future worth fighting..." |
| `[222]` | **""A parade is just a show. The real work remains ahead.""** | `[219]` **Daria de Rava**: ""What a glorious day for a parad..."<br>`[239]` **Manus Sazon**: ""A glorious day for a parade, Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Daria de Rava**: ""Indeed, Your Majesty. But even ..."<br>`[245]` **Manus Sazon**: "Of course, Your Majesty. But eve..."<br>*(oraz 1 innych odgałęzień)* |
| `[223]` | **""This is a celebration of those who earned victory, not merely observed it.""** | `[219]` **Daria de Rava**: ""What a glorious day for a parad..."<br>`[239]` **Manus Sazon**: ""A glorious day for a parade, Yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "Daria’s smile faltered, but she ..."<br>`[274]` **Narrator**: "Manus' smile faltered, but he qu..."<br>*(oraz 1 innych odgałęzień)* |
| `[227]` | **""Ah, yes, the skies. Always so supportive in matters of war and statecraft.""** | `[219]` **Daria de Rava**: ""What a glorious day for a parad..."<br>`[239]` **Manus Sazon**: ""A glorious day for a parade, Yo..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[236]` **Daria de Rava**: ""The skies were certainly kind t..."<br>`[343]` **Narrator**: "Daria's smile wavered, but she q..."<br>*(oraz 2 innych odgałęzień)* |
| `[231]` | **""Yes, the heavens themselves seem to honor the sacrifices made for this victory.""** | `[239]` **Manus Sazon**: ""A glorious day for a parade, Yo..."<br>`[219]` **Daria de Rava**: ""What a glorious day for a parad..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[234]` **Daria de Rava**: ""Halaita.""<br>`[244]` **Manus Sazon**: ""Halaita."" |
| `[252]` | **""Perhaps, but even the working class needs to see that their sacrifices weren't in..."** | `[251]` **Adarfo Sotelato**: ""Parades like this mask the true..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Adarfo Sotelato**: ""Sacrifice from some, profit for..." |
| `[253]` | **""War demands sacrifice.""** | `[251]` **Adarfo Sotelato**: ""Parades like this mask the true..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Adarfo Sotelato**: ""Sacrifice from some, profit for..." |
| `[276]` | **"Allow the Prime Minister to go ahead of you."** | `[279]` **Narrator**: "The sound of drums began, signal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Loud cheers rose from the crowds..." |
| `[277]` | **"Ride alongside them."** | `[279]` **Narrator**: "The sound of drums began, signal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Loud cheers rose from the crowds..." |
| `[278]` | **"Have them follow behind you."** | `[279]` **Narrator**: "The sound of drums began, signal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Loud cheers rose from the crowds..." |
| `[311]` | **""Ah, of course. My apologies. I got ahead of myself there.""** | `[305]` **Daria de Rava**: ""Your Majesty, I agree with your..."<br>`[306]` **Manus Sazon**: ""Your Majesty, I agree with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "Rizia's new prime minister signa..." |
| `[312]` | **""Damned rules and their constraints! But fine. I'll allow it to stand, for now.""** | `[305]` **Daria de Rava**: ""Your Majesty, I agree with your..."<br>`[306]` **Manus Sazon**: ""Your Majesty, I agree with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "Rizia's new prime minister signa..." |
| `[313]` | **""Fine. You win this round.""** | `[305]` **Daria de Rava**: ""Your Majesty, I agree with your..."<br>`[306]` **Manus Sazon**: ""Your Majesty, I agree with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "Rizia's new prime minister signa..." |
| `[316]` | **""I'm sorry for everything that happened. But trust me, this is for the best.""** | `[93]` **Axel Reinhart**: ""I hope that you are satisfied. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Axel Reinhart**: ""The Grand Duchy is all yours now."" |
| `[352]` | **""Manus. It's his fault she's dead.""** | `[306]` **Manus Sazon**: ""Your Majesty, I agree with your..." | `Variable["RiziaDLC.Vina_FuneralHappened"] == true` | *Brak zmian stanu* | `[356]` **Narrator**: "Pain mixed with anger on the Pri..." |

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
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Succe..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was a beautiful, sunny day in Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Most of the city center was prepared for the Victory Para..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "From within the courtyard of Castle Reinhart, near the front gate, I admired the fortress's timeless grandeur."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "An oversized Rizian flag flapped majestically in the wind..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Most of the city center was prepared for the Victory Parade. Everything seemed clean, as if the war had never happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "However, if anyone went into the back alleys, to governme..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "However, if anyone went into the back alleys, to government buildings, to residential areas, one would find sandbags lying around and bullet holes on the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Nothing that couldn't be fixed in due time."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Nothing that couldn't be fixed in due time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "From within the courtyard of Castle Reinhart, near the fr..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I wondered if I should have it renamed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus_Italic: "Castle Romus."*)
  - -> `[11]` (*Player_Romus_Italic: "Castle Toras."*)
  - -> `[10]` (*Player_Romus_Italic: "Castle Victory."*)
  - -> `[13]` (*Player_Romus_Italic: "Castle Pales."*)
  - -> `[9]` (*Player_Romus_Italic: "No need."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "No need."]** — Mówca: **Player_Romus_Italic**
> "I found it unnecessary."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Succe..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Castle Victory."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Win_Renamed_CastleVictory = true; RiziaDLCSuppor..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Castle Toras."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Win_Renamed_CastleToras = true; RiziaDLCSupport...."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Castle Romus."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Win_Renamed_CastleRomus = true; RiziaDLCSupport...."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Castle Pales."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Win_Renamed_CastlePales = true; RiziaDLCSupport...."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The gates creaked open with a heavy groan, and I spurred my horse, following the parade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "The marching band started their song. Loud cheers rose fr..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "The marching band started their song. Loud cheers rose from the crowds all around me as I slowly made my way through the capital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_StrongPalesResistance == true"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "A child tried to approach my horse with a bouquet of roses. The Golden Guard held her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus_Italic: "Gesture for her to approach and take the bouquet."*)
  - -> `[18]` (*Player_Romus_Italic: "Disregard her and follow the protocol."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Gesture for her to approach and take the bouquet."]** — Mówca: **Player_Romus_Italic**
> "I gestured for her to approach and I took the bouquet. People clapped and cameras flashed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MorellanAirPlanes == true"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Disregard her and follow the protocol."]** — Mówca: **Player_Romus_Italic**
> "I disregarded her and stuck with the protocol."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MorellanAirPlanes == true"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The guards grabbed him roughly and took him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MorellanAirPlanes == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_StrongPalesResistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_StrongPalesResistance == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_StrongPalesResistance == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_StrongPalesResistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_StrongPalesResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "An old man from the crowd tried to approach my horse with..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_StrongPalesResistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_StrongPalesResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "An old man from the crowd tried to approach my horse with what looked like a cane. He was swinging it over his head, swearing and cursing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Multiple guards immediately jumped on him and held him on..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Multiple guards immediately jumped on him and held him on the ground. The crowd looked disturbed and curious about what would happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's just an old man. Let him go. What is he even going to do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator), `[323]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The guards let him go. He cursed and disappeared into the..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Straight to prison. Make sure he learns his place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator), `[323]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Titus looked towards me for orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""He's just an old man. Let him go. What is he even going ..."*)
  - -> `[26]` (*Player_Romus: ""Straight to prison. Make sure he learns his place.""*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Off with his head.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator), `[323]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Off with his head.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Narrator**
> "The guards let him go. He cursed and disappeared into the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MorellanAirPlanes == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_MorellanAirPlanes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MorellanAirPlanes == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_MorellanAirPlanes == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_MorellanAirPlanes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_MorellanAirPlanes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "A few of our Morellan fighter jets flew by close to the g..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_MorellanAirPlanes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_MorellanAirPlanes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Rizian airplanes flew very close to the ground, deafening..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "A few of our Morellan fighter jets flew by close to the ground, deafening everyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_Massive == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Rizian airplanes flew very close to the ground, deafening everyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_Massive == true"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "I rode past by tanks and mechanized forces. The long lines of drivers and vehicles simply did not end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_MobileForces_Large == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Large == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_MobileForces_Large == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_MobileForces_Large == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_MobileForces_Large"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "I rode past by tanks and mechanized forces. The long line..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_MobileForces_Large == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_MobileForces_Large"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Medium == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_MobileForces_Medium == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Medium == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_MobileForces_Medium == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_MobileForces_Medium == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_MobileForces_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I rode past by a great number of tanks and mechanized veh..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_MobileForces_Medium == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_MobileForces_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "I rode past by a great number of tanks and mechanized vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I rode past our tanks and mechanized forces, marveling at how such a small number of them were able to subdue the Palesian army."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "The infantry column, an unending sea of uniforms, was awaiting my salute. There was a thunderous sound as their boots all hit the ground at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_Massive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_Massive == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Manpower_Massive == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_Massive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "The infantry column, an unending sea of uniforms, was awa..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Manpower_Massive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_High == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_High == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_High == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Manpower_High == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_High == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_High"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The infantry column was awaiting my salute. A grand numbe..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Manpower_High == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_High"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_Average == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Manpower_Average == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Manpower_Average == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Manpower_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "The infantry column was awaiting my salute. They all hit ..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Manpower_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "The infantry column was awaiting my salute. They all hit ..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "The infantry column was awaiting my salute. A grand number of troops all hit the ground with their boots and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "The infantry column was awaiting my salute. They all hit the ground with their boots and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "The infantry column was awaiting my salute. They all hit the ground with their boots and saluted. Only a few hundred troops were in sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "I looked at the horizon towards the port of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_LostPrideOfNavy == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_LostPrideOfNavy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_LostPrideOfNavy == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_LostPrideOfNavy == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_LostPrideOfNavy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_LostPrideOfNavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "What a shame it was to not have the pride of our navy, ou..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_LostPrideOfNavy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_LostPrideOfNavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_RiziaFleet_Large == true"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "What a shame it was to not have the pride of our navy, our flagship."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_RiziaFleet_Large == true"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "The Rizian fleet was covering the entirety of the Gulf of Pales, leaving no space for any other vessel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Marines_LargeForce == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_RiziaFleet_Large == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_RiziaFleet_Large == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_RiziaFleet_Large == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_RiziaFleet_Large == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_RiziaFleet_Large"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The Rizian fleet was covering the entirety of the Gulf of..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_RiziaFleet_Large == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_RiziaFleet_Large"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_RiziaFleet_Medium == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_RiziaFleet_Medium == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_RiziaFleet_Medium == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_RiziaFleet_Medium == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_RiziaFleet_Medium == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_RiziaFleet_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The Rizian fleet was covering the Gulf of Pales."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_RiziaFleet_Medium == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_RiziaFleet_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The Rizian fleet -- comprising just a handful of battlesh..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The Rizian fleet was covering the Gulf of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Marines_LargeForce == true"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The Rizian fleet -- comprising just a handful of battleships -- floated on the Gulf of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Marines_LargeForce == true"*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Each battleship deck was full of marines. I could see them saluting from a distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus_Italic: "Salute them."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Marines_LargeForce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Marines_LargeForce == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Marines_LargeForce == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Marines_LargeForce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Marines_LargeForce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Each battleship deck was full of marines. I could see the..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Marines_LargeForce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Marines_LargeForce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I could see the marines saluting from a distance."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "I could see the marines saluting from a distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus_Italic: "Salute them."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "The parade finally stopped and I got off my horse. I patted him on the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "In front of me, on the grand stairs to my new palace, was..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "In celebration, battleships cannons fired into the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "The parade finally stopped and I got off my horse. I patt..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "In front of me, on the grand stairs to my new palace, was Duke Reinhart. Behind him was the Throne of Pales. He was kneeling and looking at the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "A half-burned Palesian flag landed on my foot. The wind m..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "A half-burned Palesian flag landed on my foot. The wind must have brought it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus_Italic: "Pick it up and handle it with care and honor."*)
  - -> `[84]` (*Player_Romus_Italic: "Step on the flag."*)
  - -> `[85]` (*Player_Romus_Italic: "Rip it up in front of the crowd."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "Pick it up and handle it with care and honor."]** — Mówca: **Player_Romus_Italic**
> "I picked it up and handled it with care and honor, giving the flag to a nearby guard. The crowd started clapping and chanting my name."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I approached the defeated man before me."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Step on the flag."]** — Mówca: **Player_Romus_Italic**
> "I stepped on the flag intentionally as I walked to the Duke. I heard some gasps."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I approached the defeated man before me."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "Rip it up in front of the crowd."]** — Mówca: **Player_Romus_Italic**
> "I picked up the flag and ripped it in front of the crowd. Some began clapping and cheering, others were frowning in silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I approached the defeated man before me."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "Salute them."]** — Mówca: **Player_Romus_Italic**
> "I saluted our brave sailors. I was proud of every single one of them for defeating our enemy."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator), `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "In celebration, battleships cannons fired into the air."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "I approached the defeated man before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[88]`
Mówca: **Axel Reinhart**
> ""That's it, Your Majesty. You've won. Pales surrenders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He took the crown from his head and presented it to me."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't be satisfied until you get down and lick my boots.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Making the Grand-Duke kiss their boot", ..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He took the crown from his head and presented it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus_Italic: "Put the crown on your head."*)
  - -> `[92]` (*Player_Romus_Italic: "Shove the crown aside."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "Put the crown on your head."]** — Mówca: **Player_Romus_Italic**
> "I put the crown on my head. Cheers and chants of my name ensued."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_PalesCrown");"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "Shove the crown aside."]** — Mówca: **Player_Romus_Italic**
> "I shoved the crown aside. It fell on the ground. Gasps were heard."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""I hope that you are satisfied. I have nothing else to sa..."*)

### Węzeł `[93]`
Mówca: **Axel Reinhart**
> ""I hope that you are satisfied. I have nothing else to say to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""I hope you enjoy your time in prison.""*)
  - -> `[316]` (*Player_Romus: ""I'm sorry for everything that happened. But trust me, th..."*)
  - -> `[89]` (*Player_Romus: ""I won't be satisfied until you get down and lick my boots.""*)
  - -> `[94]` (*Player_Romus: ""Apologize to your King. In front of everyone.""*)
  - -> `[95]` (*Player_Romus: ""Kiss my ring.""*)
  - -> `[97]` (*Player_Romus: ""You fought valiantly, Axel.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Apologize to your King. In front of everyone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Axel Reinhart: ""I won't. I--""*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Kiss my ring.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Axel Reinhart: ""Come on. There's no need for--""*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you enjoy your time in prison.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Axel Reinhart: ""Prison? I-""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fought valiantly, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Axel Reinhart: ""As did you.""*)

### Węzeł `[98]`
Mówca: **Axel Reinhart**
> ""What? That's ridiculous. We're both gentlemen here--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "The guards grabbed him and made him kneel down further."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The guards grabbed him and made him kneel down further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I smiled as he reluctantly stuck his tongue out and licke..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I smiled as he reluctantly stuck his tongue out and licked my boot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Much appreciated. Guards, arrest this man for his many, ..."*)
  - -> `[184]` (*Player_Romus: ""You have done what any monarch would in your situation. ..."*)
  - -> `[183]` (*Player_Romus: ""As you walk free today, remember the mercy King Romus To..."*)

### Węzeł `[101]`
Mówca: **Axel Reinhart**
> ""I won't. I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "The guards grabbed him and made him kneel down further."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "The guards grabbed him and made him kneel down further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Axel Reinhart: ""I apologize. Your Majesty...""*)

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""I apologize. Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Much appreciated. Guards, arrest this man for his many, ..."*)
  - -> `[184]` (*Player_Romus: ""You have done what any monarch would in your situation. ..."*)
  - -> `[183]` (*Player_Romus: ""As you walk free today, remember the mercy King Romus To..."*)

### Węzeł `[104]`
Mówca: **Axel Reinhart**
> ""Come on. There's no need for--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "The guards grabbed him and made him kneel down further."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "The guards grabbed him and made him kneel down further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He kissed the ring."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He kissed the ring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Much appreciated. Guards, arrest this man for his many, ..."*)
  - -> `[184]` (*Player_Romus: ""You have done what any monarch would in your situation. ..."*)
  - -> `[183]` (*Player_Romus: ""As you walk free today, remember the mercy King Romus To..."*)

### Węzeł `[107]`
Mówca: **Axel Reinhart**
> ""As did you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Axel Reinhart: ""The Grand Duchy is all yours now.""*)

### Węzeł `[108]`
Mówca: **Axel Reinhart**
> ""The Grand Duchy is all yours now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Axel Reinhart: ""Take good care of it.""*)

### Węzeł `[109]`
Mówca: **Axel Reinhart**
> ""Take good care of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player_Romus: ""I will. Guards, arrest this man for his many, many viole..."*)
  - -> `[184]` (*Player_Romus: ""You have done what any monarch would in your situation. ..."*)
  - -> `[183]` (*Player_Romus: ""As you walk free today, remember the mercy King Romus To..."*)

### Węzeł `[110]`
Mówca: **Axel Reinhart**
> ""Prison? I-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory =..."*)
  - -> `[182]` (*Player_Romus: ""You are a war criminal and you must be treated appropria..."*)
  - -> `[191]` (*Player_Romus: ""You will stay there until you have repented for your inf..."*)
  - -> `[193]` (*Player_Romus: ""Not another word from you, Reinhart.""*)

### Węzeł `[111]`
Mówca: **Narrator**
> "The guards roughly pushed Axel and he fell to the ground. I watched as he was dragged away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "The guards carefully watched him as he walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "I turned around and looked at Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "The rays of sun were coming down from the clouds to paint..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "The rays of sun were coming down from the clouds to paint the rooftops golden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "I sat down on the Throne of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "My throne."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "My throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Axel Reinhart: ""That's it, Your Majesty. You've won. Pales surrenders.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "I turned around and looked at Pales."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory =..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""Have you heard of a device called 'Saint Mercy'? We have..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you heard of a device called 'Saint Mercy'? We haven't used it since last century. But we're going to break it out of retirement especially for you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true`
- **Kontekst wejściowy (poprzednik):** `[110]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won_AxelTortured = true; RiziaDLC.Axel..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won_AxelTortured = true;
RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true;
Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel"] = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Axel Reinhart: ""You mean to torture me?! Now wait a sec--""*)

### Węzeł `[125]`
Mówca: **Narrator**
> "My eyes caught Major Tigris -- now Colonel -- in front of the column."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesIn..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Operation1Briefing_Frontline == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Operation1Briefing_Frontline == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Operation1Briefing_Frontline == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "My eyes caught Major Tigris -- now Colonel -- in front of..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Operation1Briefing_Frontline == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesIn..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Win_Renamed_CastleRomus = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastleRomus"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Win_Renamed_CastleToras = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastleToras"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Win_Renamed_CastleVictory = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastleVictory"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Win_Renamed_CastlePales = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastlePales"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Winning the War against the Grand-Duchy ..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ForThePeople","R_ForThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was a beautiful, sunny day in Pales."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Pales_War = true;
EnableCollectionItem("CollectionItem_PalesCrown");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Pales_War"] = true;
EnableCollectionItem("CollectionItem_PalesCrown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Pales_War = true; EnableCo..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Pales == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Solles == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Pales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Pales == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Used_ExperimentalWeapons_Pales == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Pales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup = true;"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Used_ExperimentalWeapons_Pales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Pales_War = true; EnableCo..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Remaz"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup = true;"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Remaz"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Pales == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Solles == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Solles == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Used_ExperimentalWeapons_Solles == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Solles == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Solles"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup = t..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Used_ExperimentalWeapons_Solles == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Solles"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup = true;"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Solles == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Conqueror");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Conqueror");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Control_Skipped == false)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Conqueror");"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Control_Skipped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesIn..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_Dies..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Manus Sazon led the provincial troops from Brenas. He loo..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Large == true"*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Manus Sazon led the provincial troops from Brenas. He looked much older and more hardened than the last time I'd seen him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "Rows of polished medals gleamed across his chest, their r..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Manus_Gone"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Wedding_Happened == false && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_FuneralHappened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Relations_VinaManus_Approve == true || RiziaD..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Wedding_Happened == false && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_FuneralHappened == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "After returning from the front, the first thing he'd done..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Wedding_Happened == false && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_FuneralHappened == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseSazon_Leona = false; RiziaDLC.Facti..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "After returning from the front, the first thing he'd done was request Vina's hand in marriage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus_Italic: "Now that he'd proven himself, it was finally time."*)
  - -> `[167]` (*Player_Romus_Italic: "I'd refused."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Now that he'd proven himself, it was finally time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus = true;  RiziaDLC.Re..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I'd refused."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 3;"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus = true; 
RiziaDLC.Relations_Vina += 3; RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar = true;
RiziaDLCSupport.News_Turn10_V_ManusBackFromWarEngaged = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 3;
Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_ManusBackFromWarEngaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseSazon_Leona = false; RiziaDLC.Facti..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseSazon_Leona = false; RiziaDLC.Facti..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Faction_HouseSazon_Leona = false;
RiziaDLC.Faction_HouseSazon_Angelica = false;
RiziaDLC.Faction_HouseSazon_Manus = true;
RiziaDLCSupport.Reports_Turn10_Sallabes_ManusWarHero = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Faction_HouseSazon_Leona"] = false;
Variable["RiziaDLC.Faction_HouseSazon_Angelica"] = false;
Variable["RiziaDLC.Faction_HouseSazon_Manus"] = true;
Variable["RiziaDLCSupport.Reports_Turn10_Sallabes_ManusWarHero"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == false)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Large == true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_HouseOfDelegates", "HODPosition_Speaker", "HOD_Speaker_ManusSazon");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_Speaker","HOD_Speaker_ManusSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Large == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_2", "HOD_RPP_Member_ManusSazon");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_2","HOD_RPP_Member_ManusSazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MobileForces_Large == true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_HouseOfDelegates", "HODPosition_Sp..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_HouseOfDelegates", "HODPosition_No..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Much appreciated. Guards, arrest this man for his many, many violent acts against Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator), `[103]` (Axel Reinhart), `[106]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Axel Reinhart: ""What? But--""*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. Guards, arrest this man for his many, many violent acts against Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Axel Reinhart: ""What? But--""*)

### Węzeł `[181]`
Mówca: **Axel Reinhart**
> ""What? But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""You are a war criminal and you must be treated appropria..."*)
  - -> `[191]` (*Player_Romus: ""You will stay there until you have repented for your inf..."*)
  - -> `[193]` (*Player_Romus: ""Not another word from you, Reinhart.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a war criminal and you must be treated appropriately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Axel Reinhart), `[181]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Axel Reinhart: ""A war criminal? How dare y--""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you walk free today, remember the mercy King Romus Toras showed you. It is more than you deserve.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator), `[103]` (Axel Reinhart), `[106]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "He bowed low to the ground."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have done what any monarch would in your situation. You have my blessing to leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator), `[103]` (Axel Reinhart), `[106]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "He bowed low to the ground."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""One more thing. I want him tortured. The so-called Duke ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One more thing. I want him tortured. The so-called Duke will beg for his life.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[110]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won_AxelTortured = true; RiziaDLC.Axel..."*)

### Węzeł `[189]`
Mówca: **Axel Reinhart**
> ""A war criminal? How dare y--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel"] = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will stay there until you have repented for your infringement on my kingdom's sovereignty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Axel Reinhart), `[181]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Axel Reinhart: ""I swear to you, I've repented already--""*)

### Węzeł `[192]`
Mówca: **Axel Reinhart**
> ""I swear to you, I've repented already--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not another word from you, Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Axel Reinhart), `[181]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "He shut his mouth, resigned."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "He shut his mouth, resigned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Tu..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "He bowed low to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Axel Reinhart: ""Thank you, Your Majesty. I will not forget this.""*)

### Węzeł `[196]`
Mówca: **Axel Reinhart**
> ""Thank you, Your Majesty. I will not forget this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "The guards carefully watched him as he walked away."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_WehlenJoined == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "I rode past a small number of tanks and mechanized forces."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_WehlenJoined == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I rode past our tanks and mechanized forces, marveling at..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "I rode past a small number of tanks and mechanized forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_WehlenJoined == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_WehlenJoined == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_WehlenJoined == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Behind them was a massive swell of soldiers from the Wehz..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_WehlenJoined == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I looked at the horizon towards the port of Pales."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "Behind them was a massive swell of soldiers from the Wehzek Armed Forces. They marched with grim-faced determination, a contrast to the jubilation of my own troops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I looked at the horizon towards the port of Pales."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Enable_Policy_RD_Welfare_KingsCars"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato");"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Enable_Policy_RD_Welfare_KingsCars"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "The gates opened with a heavy groan, revealing Rizia's in..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The gates creaked open with a heavy groan, and I spurred ..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Daria de Rava, seated in the back of a luxurious open-top car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "I nudged my horse forward until I was alongside her."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "An oversized Rizian flag flapped majestically in the wind, a proud emblem against its imposing stone walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I wondered if I should have it renamed."*)

### Węzeł `[219]`
Mówca: **Daria de Rava**
> ""What a glorious day for a parade, Your Majesty. The skies seem to be celebrating with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""This is a celebration of those who earned victory, not m..."*)
  - -> `[221]` (*Player_Romus: ""A reminder of why we keep fighting for Rizia’s future.""*)
  - -> `[222]` (*Player_Romus: ""A parade is just a show. The real work remains ahead.""*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "I nudged my horse forward until I was alongside her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Daria de Rava: ""What a glorious day for a parade, Your Majesty. The skie..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder of why we keep fighting for Rizia’s future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Daria de Rava), `[239]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A parade is just a show. The real work remains ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Daria de Rava), `[239]` (Manus Sazon), `[251]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a celebration of those who earned victory, not merely observed it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Daria de Rava), `[239]` (Manus Sazon), `[251]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true )"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""Ah, yes, the skies. Always so supportive in matters of w..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes, the skies. Always so supportive in matters of war and statecraft.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[219]` (Daria de Rava), `[239]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true )"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Yes, the heavens themselves seem to honor the sacrifices..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, the heavens themselves seem to honor the sacrifices made for this victory.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[239]` (Manus Sazon), `[219]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Daria’s smile faltered, but she quickly regained her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[233]`
Mówca: **Daria de Rava**
> ""A future worth fighting for, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[234]`
Mówca: **Daria de Rava**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[235]`
Mówca: **Daria de Rava**
> ""Indeed, Your Majesty. But even victories deserve a moment in the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[236]`
Mówca: **Daria de Rava**
> ""The skies were certainly kind to us in this war. Our brave air force helped save the day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Manus Sazon, seated in the back of a luxurious open-top car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "I nudged my horse forward until I was alongside him."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "I nudged my horse forward until I was alongside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Manus Sazon: ""A glorious day for a parade, Your Majesty. The skies see..."*)

### Węzeł `[239]`
Mówca: **Manus Sazon**
> ""A glorious day for a parade, Your Majesty. The skies seem to be celebrating with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""This is a celebration of those who earned victory, not m..."*)
  - -> `[221]` (*Player_Romus: ""A reminder of why we keep fighting for Rizia’s future.""*)
  - -> `[231]` (*Player_Romus: ""Yes, the heavens themselves seem to honor the sacrifices..."*)
  - -> `[222]` (*Player_Romus: ""A parade is just a show. The real work remains ahead.""*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Manus' smile wavered, but he quickly regained his composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Airforce_Total_Large == true ..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Airforce_Total_Large == true ..."*)

### Węzeł `[244]`
Mówca: **Manus Sazon**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[245]`
Mówca: **Manus Sazon**
> "Of course, Your Majesty. But even victories deserve a moment in the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[246]`
Mówca: **Manus Sazon**
> ""Indeed, a future worth fighting for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Adarfo Sotelato, seated in the back of one of the vehicles from the King's Cars initiative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Recently renamed The People's Car, it was simple and unad..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Recently renamed The People's Car, it was simple and unadorned, embodying practicality over extravagance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "I nudged my horse forward until I was alongside him."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Adarfo Sotelato, seated in the back of a open-top car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "I nudged my horse forward until I was alongside him."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "I nudged my horse forward until I was alongside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Adarfo Sotelato: ""Parades like this mask the true cost of war, glossing ov..."*)

### Węzeł `[251]`
Mówca: **Adarfo Sotelato**
> ""Parades like this mask the true cost of war, glossing over the sacrifices of the working class who fought and died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""This is a celebration of those who earned victory, not m..."*)
  - -> `[222]` (*Player_Romus: ""A parade is just a show. The real work remains ahead.""*)
  - -> `[253]` (*Player_Romus: ""War demands sacrifice.""*)
  - -> `[252]` (*Player_Romus: ""Perhaps, but even the working class needs to see that th..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps, but even the working class needs to see that their sacrifices weren't in vain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Adarfo Sotelato: ""Sacrifice from some, profit for others.""*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""War demands sacrifice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Adarfo Sotelato: ""Sacrifice from some, profit for others.""*)

### Węzeł `[254]`
Mówca: **Adarfo Sotelato**
> ""Sacrifice from some, profit for others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[255]`
Mówca: **Adarfo Sotelato**
> ""Agreed. Those who bled for this victory must reap the rewards, not just the privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Daria de Rava: ""Indeed, Your Majesty. But even victories deserve a momen..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Manus Sazon: "Of course, Your Majesty. But even victories deserve a mom..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Adarfo Sotelato: ""Agreed. Those who bled for this victory must reap the re..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Daria de Rava: ""Halaita.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Manus Sazon: ""Halaita.""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Daria de Rava: ""A future worth fighting for, indeed.""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Manus Sazon: ""Indeed, a future worth fighting for.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Daria’s smile faltered, but she quickly regained her comp..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Manus' smile faltered, but he quickly regained his compos..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Adarfo’s gaze hardened before slowly turning away."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Manus' smile faltered, but he quickly regained his composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "Adarfo’s gaze hardened before slowly turning away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "Allow the Prime Minister to go ahead of you."]** — Mówca: **Player_Romus_Italic**
> "I allowed the Prime Minister to go ahead of me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Loud cheers rose from the crowds all around as I slowly m..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "Ride alongside them."]** — Mówca: **Player_Romus_Italic**
> "I rode alongside the Prime Minister to stand as equals."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Loud cheers rose from the crowds all around as I slowly m..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "Have them follow behind you."]** — Mówca: **Player_Romus_Italic**
> "I had the Prime Minister follow behind me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Loud cheers rose from the crowds all around as I slowly m..."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "The sound of drums began, signaling the start of the grand procession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player_Romus_Italic: "Allow the Prime Minister to go ahead of you."*)
  - -> `[277]` (*Player_Romus_Italic: "Ride alongside them."*)
  - -> `[278]` (*Player_Romus_Italic: "Have them follow behind you."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Loud cheers rose from the crowds all around as I slowly made my way through the capital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_StrongPalesResistance == true"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "Daria followed alongside me."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Manus followed alongside me."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[287]`
Mówca: **Narrator**
> "Daria followed alongside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Manus followed alongside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Adarfo followed alongside me."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Adarfo followed alongside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "The gates opened with a heavy groan, revealing Rizia's in..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "The gates opened with a heavy groan, revealing Rizia's in..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "The gates opened with a heavy groan, revealing Rizia's in..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Daria de Rava: ""Your Majesty, I agree with your order to take Duke Reinh..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Manus Sazon: ""Your Majesty, I agree with your order to take Duke Reinh..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Adarfo Sotelato: ""Your Majesty, I agree with your order to take Duke Reinh..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The guards roughly pushed Axel and he fell to the ground...."*)

### Węzeł `[305]`
Mówca: **Daria de Rava**
> ""Your Majesty, I agree with your order to take Duke Reinhart into custody, but torture is a bridge too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: ""Ah, of course. My apologies. I got ahead of myself there.""*)
  - -> `[312]` (*Player_Romus: ""Damned rules and their constraints! But fine. I'll allow..."*)
  - -> `[313]` (*Player_Romus: ""Fine. You win this round.""*)

### Węzeł `[306]`
Mówca: **Manus Sazon**
> ""Your Majesty, I agree with your order to take Duke Reinhart into custody, but I will not condone such an inhumane punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[311]` (*Player_Romus: ""Ah, of course. My apologies. I got ahead of myself there.""*)
  - -> `[312]` (*Player_Romus: ""Damned rules and their constraints! But fine. I'll allow..."*)
  - -> `[313]` (*Player_Romus: ""Fine. You win this round.""*)

### Węzeł `[307]`
Mówca: **Adarfo Sotelato**
> ""Your Majesty, I agree with your order to take Duke Reinhart into custody, but I forbid you to have him tortured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: ""Ah, of course. My apologies. I got ahead of myself there.""*)
  - -> `[312]` (*Player_Romus: ""Damned rules and their constraints! But fine. I'll allow..."*)
  - -> `[313]` (*Player_Romus: ""Fine. You win this round.""*)

### Węzeł `[308]`
Mówca: **Axel Reinhart**
> ""Torture?! Now wait a sec--"""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won_AxelTortured = true;
RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true;
Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel"] = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Axel Reinhart: ""Torture?! Now wait a sec--"""*)

### Węzeł `[310]`
Mówca: **Axel Reinhart**
> ""You mean to torture me?! Now wait a sec--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, of course. My apologies. I got ahead of myself there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Daria de Rava), `[306]` (Manus Sazon), `[307]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Rizia's new prime minister signaled to the guards, who to..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damned rules and their constraints! But fine. I'll allow it to stand, for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Daria de Rava), `[306]` (Manus Sazon), `[307]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Rizia's new prime minister signaled to the guards, who to..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. You win this round.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Daria de Rava), `[306]` (Manus Sazon), `[307]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Rizia's new prime minister signaled to the guards, who to..."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "Rizia's new prime minister signaled to the guards, who took hold of Axel and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won_AxelTortured = false; RiziaDLC.Axe..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won_AxelTortured = false;
RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel = false;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = false;
Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel"] = false;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry for everything that happened. But trust me, this is for the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Axel Reinhart: ""The Grand Duchy is all yours now.""*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I sat down on the Throne of Pales."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "My guards looked towards me for orders."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Titus looked towards me for orders."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "My guards looked towards me for orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""He's just an old man. Let him go. What is he even going ..."*)
  - -> `[26]` (*Player_Romus: ""Straight to prison. Make sure he learns his place.""*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Adarfo Sotelato: ""What?! Absolutely not.""*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true )"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Manus Sazon: ""Disregard His Majesty's order. The man goes free.""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true )"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "Daria nodded, confirming the order. The guards grabbed hi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The guards grabbed him roughly and took him away."*)

### Węzeł `[333]`
Mówca: **Narrator**
> "Daria nodded, confirming the order. The guards grabbed him roughly and took him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_MorellanAirPlanes == true"*)

### Węzeł `[334]`
Mówca: **Adarfo Sotelato**
> ""What?! Absolutely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The guards let him go. He cursed and disappeared into the..."*)

### Węzeł `[335]`
Mówca: **Manus Sazon**
> ""Disregard His Majesty's order. The man goes free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The guards let him go. He cursed and disappeared into the..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "The Prime Minister and I watched as the guards dragged hi..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The guards roughly pushed Axel and he fell to the ground...."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "The Prime Minister and I watched as the guards dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Airforce_Total_Large == true ..."*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Airforce_Total_Large == tru..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Daria de Rava: ""The skies were certainly kind to us in this war. Our bra..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "Daria's smile wavered, but she quickly regained her compo..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "Daria's smile wavered, but she quickly regained her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Military_Airforce_Total_Large == true ..."*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Military_Airforce_Total_Large == tru..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Manus Sazon: ""The skies were certainly kind to us in this war. It was ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Manus' smile wavered, but he quickly regained his composure."*)

### Węzeł `[347]`
Mówca: **Manus Sazon**
> ""The skies were certainly kind to us in this war. It was our air force that helped us best Pales, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Refor..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Manus Sazon: ""I only wish Vina -- Her Highness -- had lived to see thi..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "The sound of drums began, signaling the start of the gran..."*)

### Węzeł `[351]`
Mówca: **Manus Sazon**
> ""I only wish Vina -- Her Highness -- had lived to see this day...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "The sound of drums began, signaling the start of the gran..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus. It's his fault she's dead.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Kontekst wejściowy (poprzednik):** `[306]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "Pain mixed with anger on the Prime Minister's face. He co..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player_Romus: ""Manus. It's his fault she's dead.""*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
Mówca: **Narrator**
> "Pain mixed with anger on the Prime Minister's face. He could barely choke out his next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Manus Sazon: ""Fine. Do it.""*)

### Węzeł `[357]`
Mówca: **Manus Sazon**
> ""Fine. Do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The guards roughly pushed Axel and he fell to the ground...."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_PalesCrown");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_PalesCrown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""I hope that you are satisfied. I have nothing else to sa..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "A child tried to approach my horse with a bouquet of rose..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "A child tried to approach my horse with a bouquet of rose..."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "A child tried to approach my horse with a bouquet of roses. Wruhec's Guardians held her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus_Italic: "Gesture for her to approach and take the bouquet."*)
  - -> `[18]` (*Player_Romus_Italic: "Disregard her and follow the protocol."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseSazon_Conquered == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseSazon_Conquered == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseSazon_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseSazon_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC..."*)

### Węzeł `[366]`
Mówca: **Narrator**
> "He'd returned from the front only to find his home province in Crown hands, his family in disarray and the House of Delegates dismantled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "I almost felt bad for him."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "He'd returned from the front only to find his home provin..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "He'd returned from the front only to find his home provin..."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "He'd returned from the front only to find his home province in Crown hands and his family in disarray."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "I almost felt bad for him."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "I almost felt bad for him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseSazon_Leona = false; RiziaDLC.Facti..."*)

### Węzeł `[372]`
Mówca: **Narrator**
> "Rows of polished medals gleamed across his chest, their ribbons crisp and colors sharp against the dark fabric of his uniform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_OfficerSazon");"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_OfficerSazon");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_OfficerSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone = false;"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Winning the War against the Grand-Duchy of Pales", "Old Town", "Grand-Duchy of Pales");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Winning the War against the Grand-Duchy of Pales","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Making the Grand-Duke kiss their boot", "Old Town", "Grand-Duchy of Pales");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Making the Grand-Duke kiss their boot","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Axel Reinhart: ""What? That's ridiculous. We're both gentlemen here--""*)
