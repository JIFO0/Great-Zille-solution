# Rizia/Peaceful Power Transition

- **ID konwersacji:** `430`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Peaceful Power Transition)`
- **Lokalizacja pliku:** `Rizia/Epilogue/430_Peaceful_Power_Transition.md`
- **Liczba węzłów dialogowych:** 694
- **Liczba wyborów gracza:** 178

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
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Country_QuelledProtests`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Reform`
- `RiziaDLC.Ending_Coup_Sazon`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Ending_Monarch_Hubertus`
- `RiziaDLC.Ending_Monarch_Hugo`
- `RiziaDLC.Ending_Monarch_Lucita`
- `RiziaDLC.Ending_Monarch_Rico`
- `RiziaDLC.Ending_Monarch_Vina`
- `RiziaDLC.Ending_Revolution`
- `RiziaDLC.Epilogue_Abdication_Speech`
- `RiziaDLC.Epilogue_Exile_HugoSendsToExile`
- `RiziaDLC.Epilogue_KingdomDissolves_Revolution`
- `RiziaDLC.Epilogue_PrimeMinister_Adarfo`
- `RiziaDLC.Epilogue_PrimeMinister_Daria`
- `RiziaDLC.Epilogue_PrimeMinister_Manus`
- `RiziaDLC.Epilogue_Prison_HugoSendsToPrison`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_ConvinceToLeave`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Manus_ThreatenToLeave`
- `RiziaDLC.NatDes_FinalDecision_Abdicate`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal`
- `RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.ZilleReferendum_Independence`
- `RiziaDLC.ZilleReturn_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.CoupWarning_Destination_Kyrute`
- `RiziaDLC.CoupWarning_Destination_Rumburg`
- `RiziaDLC.Epilogue_ExileTogether_Estela`
- `RiziaDLC.Epilogue_Exile_DecidedInEpilogue`
- `RiziaDLC.Epilogue_Exile_Rumburg`
- `RiziaDLCText.LenaTooltip`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[18]`
- Węzeł `[169]` -> **[426] Rizia/Exile** (../Epilogue/426_Exile.md), Węzeł `[346]`
- Węzeł `[170]` -> **[427] Rizia/Immediate Death** (../Epilogue/427_Immediate_Death.md), Węzeł `[79]`
- Węzeł `[642]` -> **[426] Rizia/Exile** (../Epilogue/426_Exile.md), Węzeł `[7]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"1957\|Porte Drazon\|A New Era"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Player_Romus**: "...felt relieved from the burden."<br>`[5]` **Player_Romus**: "...were furious with anger."<br>*(oraz 1 innych odgałęzień)* |
| `[5]` | **"...were furious with anger."** | `[4]` **Narrator**: "You leaned over the balcony rail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "People were cheering with a magn..."<br>`[560]` **Narrator**: "People from all walks of life we..." |
| `[6]` | **"...felt relieved from the burden."** | `[4]` **Narrator**: "You leaned over the balcony rail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "People were cheering with a magn..."<br>`[560]` **Narrator**: "People from all walks of life we..." |
| `[7]` | **"...felt lucky that you didn't die."** | `[4]` **Narrator**: "You leaned over the balcony rail..."<br>`[176]` **Player_Romus**: "Rumburg sounded nice."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Ending_Revolution"] == true` | *Brak zmian stanu* | `[8]` **Narrator**: "People were cheering with a magn..."<br>`[560]` **Narrator**: "People from all walks of life we..." |
| `[9]` | **"...promised that you would get your revenge one day."** | `[8]` **Narrator**: "People were cheering with a magn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The Rizian flag atop the palace ..." |
| `[10]` | **"...thought that perhaps this was the best possible outcome."** | `[8]` **Narrator**: "People were cheering with a magn..."<br>`[560]` **Narrator**: "People from all walks of life we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The Rizian flag atop the palace ..." |
| `[11]` | **"...wondered how your days would be from now on."** | `[8]` **Narrator**: "People were cheering with a magn..."<br>`[560]` **Narrator**: "People from all walks of life we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The Rizian flag atop the palace ..." |
| `[13]` | **"...the most beautiful thing you ever saw."** | `[12]` **Narrator**: "The Rizian flag atop the palace ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Narrator**: "In the following days, the revol..."<br>`[544]` **Narrator**: "In the following days, the revol..."<br>*(oraz 1 innych odgałęzień)* |
| `[14]` | **"...not worth dying for."** | `[12]` **Narrator**: "The Rizian flag atop the palace ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Narrator**: "In the following days, the revol..."<br>`[544]` **Narrator**: "In the following days, the revol..."<br>*(oraz 1 innych odgałęzień)* |
| `[15]` | **"...just a piece of cloth."** | `[12]` **Narrator**: "The Rizian flag atop the palace ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Narrator**: "In the following days, the revol..."<br>`[544]` **Narrator**: "In the following days, the revol..."<br>*(oraz 1 innych odgałęzień)* |
| `[24]` | **"1958\|Porte Drazon\|A New Era"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Player_Romus**: "...a sense of relief wash over you."<br>`[195]` **Player_Romus**: "...hopeful about the future unfo..."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **"Then democracy arrived in the kingdom."** | `[343]` **Narrator**: "You watched your successor's cro..." | `Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true`<br>`(Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true) == false` | `PrologueImage("pe_newgovernment");` | `[179]` **Narrator**: "The first ever general election ..." |
| `[26]` | **"1958\|Porte Drazon\|A New Era"** | `[278]` **Player_Romus**: "And thus your story ended."<br>`[297]` **Player_Romus**: "It had a nice ring to it."<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true) == false` | *Brak zmian stanu* | `[27]` **Player_Romus**: "...found bitter irony in this cr..."<br>`[65]` **Player_Romus**: "...felt nothing but the weight o..."<br>*(oraz 1 innych odgałęzień)* |
| `[27]` | **"...found bitter irony in this cruel twist of fate."** | `[26]` **Narrator**: "Power had been a fragile thing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Rumors seeped through the prison..."<br>`[64]` **Narrator**: "The world outside had shifted an..." |
| `[50]` | **"...to accept her offer and move to the province."** | `[49]` **Narrator**: "Vina wasted no time visiting. Sh..."<br>`[85]` **Narrator**: "Vina wasted no time visiting. Li..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Pales_Rizia_Unification"] == true` | `PrologueImage("pe_palesvisit");` | `[52]` **Narrator**: "You, your mother and Lucita were..."<br>`[445]` **Narrator**: "You, your mother and Pabel were ..."<br>*(oraz 1 innych odgałęzień)* |
| `[51]` | **"...to remain in Rizia, requesting for her to visit you soon."** | `[49]` **Narrator**: "Vina wasted no time visiting. Sh..."<br>`[85]` **Narrator**: "Vina wasted no time visiting. Li..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Taking refuge in your mother's g..." |
| `[52]` | **"1958\|Pales\|Court Life"** | `[50]` **Player_Romus**: "...to accept her offer and move ..."<br>`[441]` **Player_Romus**: "...to accept her offer and move ..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false` | *Brak zmian stanu* | `[53]` **Player_Romus**: "You accepted."<br>`[54]` **Player_Romus**: "You rejected." |
| `[53]` | **"You accepted."** | `[52]` **Narrator**: "You, your mother and Lucita were..."<br>`[445]` **Narrator**: "You, your mother and Pabel were ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "The ambassador Nicolas Rembrandt..." |
| `[54]` | **"You rejected."** | `[52]` **Narrator**: "You, your mother and Lucita were..."<br>`[445]` **Narrator**: "You, your mother and Pabel were ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Narrator**: "You decided to explore the city ..." |
| `[55]` | **"...you didn't want family tying you down."** | `[128]` **Narrator**: "Months passed in Pales, and the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Narrator**: "You congratulated your daughter ..." |
| `[60]` | **"...by the royal decree of King Hugo Toras, your life shall be spared, your honor r..."** | `[64]` **Narrator**: "The world outside had shifted an..." | `Variable["RiziaDLC.Coup_Leader_Hugo"] == true` | *Brak zmian stanu* | `[84]` **Narrator**: "You would never again wear the c..." |
| `[61]` | **"At least you fought for something greater, for a better world."** | `[63]` **Narrator**: "Rumors seeped through the prison..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "The world outside had shifted an..." |
| `[62]` | **"You couldn't help but wish you had crushed your enemies when you had the chance."** | `[63]` **Narrator**: "Rumors seeped through the prison..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "The world outside had shifted an..." |
| `[65]` | **"...felt nothing but the weight of time, indifferent and patient."** | `[26]` **Narrator**: "Power had been a fragile thing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Rumors seeped through the prison..."<br>`[64]` **Narrator**: "The world outside had shifted an..." |
| `[66]` | **"...counted each day, a silent rebellion against your fate."** | `[26]` **Narrator**: "Power had been a fragile thing, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Rumors seeped through the prison..."<br>`[64]` **Narrator**: "The world outside had shifted an..." |
| `[67]` | **"It seemed pointless now, worrying about what could have been."** | `[63]` **Narrator**: "Rumors seeped through the prison..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "The world outside had shifted an..." |
| `[68]` | **"...under the royal decree of King Rico Toras, your life is hereby preserved, your ..."** | `[64]` **Narrator**: "The world outside had shifted an..." | `Variable["RiziaDLC.Coup_Leader_Rico"] == true`<br>`(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false` | *Brak zmian stanu* | `[84]` **Narrator**: "You would never again wear the c..." |
| `[69]` | **"...through the royal decree of King Taddeus Azaro, your life is spared, your honor..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Stepping out of the Citadel, the..." |
| `[70]` | **"...by the royal decree of Queen Lucita Azaro, your life is spared, your honor rede..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Stepping out of the Citadel, the..." |
| `[71]` | **"...by the royal decree of Queen Angelica Sazon, your existence is spared, your hon..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Stepping out of the Citadel, the..." |
| `[79]` | **"...moved to Iza for a taste of city life."** | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[262]` **Narrator**: "Lucita followed you to the Brena..."<br>`[263]` **Narrator**: "Your mother, open to a change of..." |
| `[80]` | **"...moved to a hut in Zpana's nature."** | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[166]` **Narrator**: "Though skeptical at first, Lucit..."<br>`[167]` **Narrator**: "Pabel, eager to get away from pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[81]` | **".....settled seaside in Topes, near the ancient Rezenid sites."** | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[103]` **Narrator**: "Lucita agreed with the plan. Tog..."<br>`[105]` **Narrator**: "Estela welcomed the change and j..." |
| `[89]` | **"...wife, Lucita."** | `[72]` **Narrator**: "Stepping out of the Citadel, the..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false` | *Brak zmian stanu* | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..."<br>*(oraz 2 innych odgałęzień)* |
| `[90]` | **"...by the royal decree of Queen Lucita Azaro, your sentence is to be extended by a..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "To circumvent any potential for ..." |
| `[91]` | **"...mother, Estela."** | `[72]` **Narrator**: "Stepping out of the Citadel, the..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..."<br>*(oraz 2 innych odgałęzień)* |
| `[92]` | **"A fresh start awaited."** | `[84]` **Narrator**: "You would never again wear the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Stepping out of the Citadel, the..." |
| `[96]` | **"...life partner, Pabel."** | `[72]` **Narrator**: "Stepping out of the Citadel, the..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[489]` **Narrator**: "He explained to you that the new..."<br>`[76]` **Narrator**: "Settling into Estela's guest hou..."<br>*(oraz 1 innych odgałęzień)* |
| `[103]` | **"1958\|Topes\|Seaside Life"** | `[81]` **Player_Romus**: ".....settled seaside in Topes, n..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false` | *Brak zmian stanu* | `[255]` **Player_Romus**: "Managed the local tourism center..."<br>`[256]` **Player_Romus**: "Took up fishing as a pastime."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **"1958\|Topes\|Seaside Life"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Player_Romus**: "Managed the local tourism center..."<br>`[256]` **Player_Romus**: "Took up fishing as a pastime."<br>*(oraz 1 innych odgałęzień)* |
| `[105]` | **"1958\|Topes\|Seaside Life"** | `[81]` **Player_Romus**: ".....settled seaside in Topes, n..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false` | *Brak zmian stanu* | `[255]` **Player_Romus**: "Managed the local tourism center..."<br>`[256]` **Player_Romus**: "Took up fishing as a pastime."<br>*(oraz 1 innych odgałęzień)* |
| `[114]` | **"...the joy of parenthood eclipsed all else."** | `[109]` **Narrator**: "After a long, intense wait, the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[115]` | **"...everything else faded, only this moment mattered."** | `[109]` **Narrator**: "After a long, intense wait, the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[116]` | **"...all of life's complexities seemed trivial."** | `[109]` **Narrator**: "After a long, intense wait, the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[123]` | **"..legendary humor, regaling them with witty anecdotes."** | `[56]` **Narrator**: "The ambassador Nicolas Rembrandt..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[124]` | **"...outlandish tales from your Party Prince days."** | `[56]` **Narrator**: "The ambassador Nicolas Rembrandt..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[125]` | **"...deep philosophical musings."** | `[56]` **Narrator**: "The ambassador Nicolas Rembrandt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[126]` | **"..enjoyed the beach scene, mingling incognito with locals and tourists."** | `[122]` **Narrator**: "You decided to explore the city ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[127]` | **"...went out on the town, hunting for the best restaurants and bars."** | `[122]` **Narrator**: "You decided to explore the city ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[129]` | **"...you wanted nothing more than to be a caring grandfather."** | `[128]` **Narrator**: "Months passed in Pales, and the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Narrator**: "Embracing grandfatherhood, you s..." |
| `[133]` | **"..wandered the historic streets, absorbing the city's heritage."** | `[122]` **Narrator**: "You decided to explore the city ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[149]` | **"It was good to spend time with loved ones."** | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[128]` **Narrator**: "Months passed in Pales, and the ..." |
| `[158]` | **"...your mother, Estela."** | `[153]` **Narrator**: "After serving your month-long se..."<br>`[502]` **Narrator**: "After serving your month-long se..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` | *Brak zmian stanu* | `[154]` **Narrator**: "With nothing but painful reminde..." |
| `[159]` | **"...your life partner, Pabel."** | `[153]` **Narrator**: "After serving your month-long se..."<br>`[502]` **Narrator**: "After serving your month-long se..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[154]` **Narrator**: "With nothing but painful reminde..." |
| `[166]` | **"1958\|Zpana\|Rural Life"** | `[80]` **Player_Romus**: "...moved to a hut in Zpana's nat..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false` | *Brak zmian stanu* | `[253]` **Player_Romus**: "Took up hunting as a hobby."<br>`[254]` **Player_Romus**: "Started farming, cultivating you..."<br>*(oraz 1 innych odgałęzień)* |
| `[167]` | **"1958\|Zpana\|Rural Life"** | `[80]` **Player_Romus**: "...moved to a hut in Zpana's nat..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false` | *Brak zmian stanu* | `[253]` **Player_Romus**: "Took up hunting as a hobby."<br>`[254]` **Player_Romus**: "Started farming, cultivating you..."<br>*(oraz 1 innych odgałęzień)* |
| `[168]` | **"1958\|Zpana\|Rural Life"** | `[80]` **Player_Romus**: "...moved to a hut in Zpana's nat..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false` | *Brak zmian stanu* | `[253]` **Player_Romus**: "Took up hunting as a hobby."<br>`[254]` **Player_Romus**: "Started farming, cultivating you..."<br>*(oraz 1 innych odgałęzień)* |
| `[175]` | **"Kyrute was the safest option."** | `[597]` **Narrator**: "Estela and Vina were staying at ..."<br>`[634]` **Narrator**: "Estela was staying at a hotel in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = false; Vari...`<br>`Variable["RiziaDLC.CoupWarning_Destination_Rumburg"] = fa...` | `[7]` **Player_Romus**: "...felt lucky that you didn't die."<br>`[347]` **Narrator**: "She and Manus visited Palas Rezn..." |
| `[176]` | **"Rumburg sounded nice."** | `[597]` **Narrator**: "Estela and Vina were staying at ..."<br>`[634]` **Narrator**: "Estela was staying at a hotel in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true; Varia...`<br>`Variable["RiziaDLC.CoupWarning_Destination_Rumburg"] = fa...` | `[7]` **Player_Romus**: "...felt lucky that you didn't die."<br>`[347]` **Narrator**: "She and Manus visited Palas Rezn..." |
| `[178]` | **"Your life was an open door."** | `[188]` **Narrator**: "Over time, the security threats ..."<br>`[223]` **Narrator**: "Over time, the security threats ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..." |
| `[184]` | **"...didn't care and just wanted to move on."** | `[179]` **Narrator**: "The first ever general election ..."<br>`[603]` **Narrator**: "The first ever general election ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[185]` | **"...wrote her a letter congratulating her on her win."** | `[180]` **Narrator**: "Rizia's first general election w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[186]` | **"...wrote him a letter of congratulations."** | `[179]` **Narrator**: "The first ever general election ..."<br>`[603]` **Narrator**: "The first ever general election ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[187]` | **"...wished for more radical change."** | `[180]` **Narrator**: "Rizia's first general election w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[194]` | **"...a sense of relief wash over you."** | `[24]` **Narrator**: "Releasing the reins of power had..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pa_abdication1");` | `[212]` **Narrator**: "Queen Vina quickly endeared hers..."<br>`[213]` **Narrator**: "King Hugo garnered respect from ..." |
| `[195]` | **"...hopeful about the future unfolding."** | `[24]` **Narrator**: "Releasing the reins of power had..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pa_abdication1");` | `[212]` **Narrator**: "Queen Vina quickly endeared hers..."<br>`[213]` **Narrator**: "King Hugo garnered respect from ..." |
| `[196]` | **"...a pang of regret for your past reign's shortcomings."** | `[24]` **Narrator**: "Releasing the reins of power had..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pa_abdication1");` | `[212]` **Narrator**: "Queen Vina quickly endeared hers..."<br>`[213]` **Narrator**: "King Hugo garnered respect from ..." |
| `[217]` | **"Long live the new Queen."** | `[212]` **Narrator**: "Queen Vina quickly endeared hers..."<br>`[216]` **Narrator**: "As Lucita Azaro ascended the thr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Narrator**: "You watched your successor's cro..." |
| `[218]` | **"Long live the new King."** | `[213]` **Narrator**: "King Hugo garnered respect from ..."<br>`[214]` **Narrator**: "King Rico Toras infused a newfou..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Narrator**: "You watched your successor's cro..." |
| `[222]` | **"...let the Palace staff do most of the work."** | `[233]` **Narrator**: "The birth of Queen Lucita's son ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[352]` **Narrator**: "You lived out the rest of your d..." |
| `[224]` | **"...felt a twinge of obsolescence."** | `[179]` **Narrator**: "The first ever general election ..."<br>`[603]` **Narrator**: "The first ever general election ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[225]` | **"...felt reassured by her approach to maintain unity."** | `[180]` **Narrator**: "Rizia's first general election w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[226]` | **"...immersing yourself in study and knowledge."** | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Narrator**: "But the serenity of your new lif..." |
| `[229]` | **"Vina was expecting a child."** | `[228]` **Narrator**: "But the serenity of your new lif..." | `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[248]` **Narrator**: "The news of your grandchild-to-b..."<br>`[347]` **Narrator**: "She and Manus visited Palas Rezn..." |
| `[230]` | **"...tending to the gardens."** | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Narrator**: "But the serenity of your new lif..." |
| `[231]` | **"...aiding her in state matters as King Consort."** | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Narrator**: "But the serenity of your new lif..." |
| `[232]` | **"Lucita was in labor."** | `[228]` **Narrator**: "But the serenity of your new lif..." | `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | `PrologueImage("pe_princebirth");` | `[233]` **Narrator**: "The birth of Queen Lucita's son ..." |
| `[234]` | **"...assumed childrearing duties while your wife held the throne."** | `[233]` **Narrator**: "The birth of Queen Lucita's son ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[352]` **Narrator**: "You lived out the rest of your d..." |
| `[239]` | **"A few weeks passed."** | `[343]` **Narrator**: "You watched your successor's cro..." | `(Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] == true) == false`<br>`(Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true) == false`<br>`(Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true) == false` | `PrologueImage("pe_continuedreign1");` | `[227]` **Narrator**: "Queen Lucita Azaro arranged for ..."<br>`[244]` **Narrator**: "At long last, the security threa..." |
| `[240]` | **"Then democracy arrived in the kingdom."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Rizia's first general election w..." |
| `[249]` | **"Rizia's new prince was born."** | `[248]` **Narrator**: "The news of your grandchild-to-b..."<br>`[347]` **Narrator**: "She and Manus visited Palas Rezn..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[233]` **Narrator**: "The birth of Queen Lucita's son ..." |
| `[253]` | **"Took up hunting as a hobby."** | `[166]` **Narrator**: "Though skeptical at first, Lucit..."<br>`[167]` **Narrator**: "Pabel, eager to get away from pr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[254]` | **"Started farming, cultivating your own crops."** | `[166]` **Narrator**: "Though skeptical at first, Lucit..."<br>`[167]` **Narrator**: "Pabel, eager to get away from pr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[255]` | **"Managed the local tourism center, occasionally guiding."** | `[103]` **Narrator**: "Lucita agreed with the plan. Tog..."<br>`[104]` **Narrator**: "Pabel immediately agreed to come..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[256]` | **"Took up fishing as a pastime."** | `[103]` **Narrator**: "Lucita agreed with the plan. Tog..."<br>`[104]` **Narrator**: "Pabel immediately agreed to come..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[257]` | **"...started writing poetry and joined art circles."** | `[154]` **Narrator**: "With nothing but painful reminde..."<br>`[262]` **Narrator**: "Lucita followed you to the Brena..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[258]` | **"...decided to try your hand at stand-up comedy."** | `[154]` **Narrator**: "With nothing but painful reminde..."<br>`[262]` **Narrator**: "Lucita followed you to the Brena..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[259]` | **"Relaxed and enjoyed your new downtime."** | `[103]` **Narrator**: "Lucita agreed with the plan. Tog..."<br>`[104]` **Narrator**: "Pabel immediately agreed to come..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[260]` | **"Relaxed and made new friends."** | `[166]` **Narrator**: "Though skeptical at first, Lucit..."<br>`[167]` **Narrator**: "Pabel, eager to get away from pr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[261]` | **"...reveled in your sudden free time."** | `[154]` **Narrator**: "With nothing but painful reminde..."<br>`[262]` **Narrator**: "Lucita followed you to the Brena..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[262]` | **"1958\|Iza\|City Life"** | `[79]` **Player_Romus**: "...moved to Iza for a taste of c..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false` | *Brak zmian stanu* | `[257]` **Player_Romus**: "...started writing poetry and jo..."<br>`[261]` **Player_Romus**: "...reveled in your sudden free t..."<br>*(oraz 2 innych odgałęzień)* |
| `[263]` | **"1958\|Iza\|City Life"** | `[79]` **Player_Romus**: "...moved to Iza for a taste of c..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false` | *Brak zmian stanu* | `[257]` **Player_Romus**: "...started writing poetry and jo..."<br>`[261]` **Player_Romus**: "...reveled in your sudden free t..."<br>*(oraz 2 innych odgałęzień)* |
| `[264]` | **"1958\|Iza\|City Life"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Player_Romus**: "...started writing poetry and jo..."<br>`[261]` **Player_Romus**: "...reveled in your sudden free t..."<br>*(oraz 2 innych odgałęzień)* |
| `[271]` | **"Things could be much worse in life."** | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[128]` **Narrator**: "Months passed in Pales, and the ..." |
| `[272]` | **"...you could balance your time between helping with Lena and pursuing your own int..."** | `[128]` **Narrator**: "Months passed in Pales, and the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "You became a guiding presence in..." |
| `[273]` | **"...guiding Lena's early years could become a significant part of your legacy."** | `[128]` **Narrator**: "Months passed in Pales, and the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "In grandfatherhood, you found a ..." |
| `[278]` | **"And thus your story ended."** | `[274]` **Narrator**: "Embracing grandfatherhood, you s..."<br>`[276]` **Narrator**: "You became a guiding presence in..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[280]` | **"...immersing yourself in the local culture."** | `[113]` **Narrator**: "Life with Pabel was fulfilling, ..."<br>`[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[281]` | **"...pursuing hobbies and self-growth."** | `[113]` **Narrator**: "Life with Pabel was fulfilling, ..."<br>`[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[282]` | **"...partaking in community social work."** | `[113]` **Narrator**: "Life with Pabel was fulfilling, ..."<br>`[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[283]` | **"...guided your granddaughter and new son with wisdom and care."** | `[120]` **Narrator**: "A year later, Vina and Axel visi..."<br>`[367]` **Narrator**: "A year later, Vina and Manus vis..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false` | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[284]` | **"...dedicated yourself to raising your son wisely."** | `[371]` **Narrator**: "Vina, freed of the burden of car..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false` | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[285]` | **"...balanced your grandfatherly duties with personal time."** | `[399]` **Narrator**: "Vina visited you often. Now that..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false` | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[286]` | **"...the psychology of warfare."** | `[287]` **Narrator**: "As you flipped through the typew..."<br>`[691]` **Narrator**: "As you flipped through the typew..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "Though your paper resonated with..." |
| `[288]` | **"...the influence of the spiritual will in human societies."** | `[287]` **Narrator**: "As you flipped through the typew..."<br>`[418]` **Narrator**: "As you flipped through the typew..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "Though your paper resonated with..." |
| `[289]` | **"...the wealth disparities in Rizia and the societal issues that arose from them."** | `[287]` **Narrator**: "As you flipped through the typew..."<br>`[418]` **Narrator**: "As you flipped through the typew..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "Though your paper resonated with..." |
| `[290]` | **"1966\|Rizia\|An Old Man"** | `[313]` **Player_Romus**: "It felt good to be off the hook."<br>`[681]` **Player_Romus**: "You ached to feel important again."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false` | `PrologueImage("pe_letter");` | `[316]` **Player_Romus**: "...a political thesis a friend h..."<br>`[314]` **Player_Romus**: "...a history book from your fath..."<br>*(oraz 1 innych odgałęzień)* |
| `[291]` | **"...the teachings of Prophet Hu, the founder of Zaranism."** | `[315]` **Narrator**: "Engrossed, you delved into..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Narrator**: "Time unfolded as you pursued thi..." |
| `[292]` | **"...Miraclism theories and the principles of conservatism."** | `[315]` **Narrator**: "Engrossed, you delved into..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Narrator**: "Time unfolded as you pursued thi..." |
| `[293]` | **"...totalism and the concept of enforced efficient change."** | `[315]` **Narrator**: "Engrossed, you delved into..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Narrator**: "Time unfolded as you pursued thi..." |
| `[297]` | **"It had a nice ring to it."** | `[295]` **Narrator**: "Time unfolded as you pursued thi..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[298]` | **"And there was finally peace."** | `[296]` **Narrator**: "As time marched on, you aged wit..."<br>`[436]` **Narrator**: "Eventually, you and Vina struck ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[299]` | **"It had a nice ring to it."** | `[294]` **Narrator**: "Though your paper resonated with..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[302]` | **"...partying with your old rich friends."** | `[113]` **Narrator**: "Life with Pabel was fulfilling, ..."<br>`[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[309]` | **"...decided to focus on yourself."** | `[121]` **Narrator**: "Vina's whereabouts remained a my..."<br>`[367]` **Narrator**: "A year later, Vina and Manus vis..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[311]` | **"War, war never changes."** | `[189]` **Narrator**: "A chilling announcement halted t..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_continuedreign5");`<br>`PrologueImage("pe_relaxed");` | `[310]` **Narrator**: "At long last, Rumburg and Sordla..."<br>`[290]` **Narrator**: "Over the years, your societal pr..." |
| `[312]` | **"You worried about the future."** | `[190]` **Narrator**: "An alarming broadcast interrupte..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_continuedreign5");`<br>`PrologueImage("pe_continuedreign5");` | `[450]` **Narrator**: "At long last, Rumburg and Sordla..."<br>`[456]` **Narrator**: "At long last, Rumburg and Sordla..." |
| `[313]` | **"It felt good to be off the hook."** | `[310]` **Narrator**: "At long last, Rumburg and Sordla..."<br>`[450]` **Narrator**: "At long last, Rumburg and Sordla..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[290]` **Narrator**: "Over the years, your societal pr..." |
| `[314]` | **"...a history book from your father's old collection."** | `[290]` **Narrator**: "Over the years, your societal pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Narrator**: "Engrossed, you delved into..." |
| `[316]` | **"...a political thesis a friend had entrusted you to review."** | `[290]` **Narrator**: "Over the years, your societal pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Narrator**: "As you flipped through the typew..."<br>`[418]` **Narrator**: "As you flipped through the typew..."<br>*(oraz 1 innych odgałęzień)* |
| `[317]` | **"...the immediatist movement, studying their drive for swift change."** | `[315]` **Narrator**: "Engrossed, you delved into..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Narrator**: "Time unfolded as you pursued thi..." |
| `[318]` | **"...the healing effects of humor in society."** | `[287]` **Narrator**: "As you flipped through the typew..."<br>`[691]` **Narrator**: "As you flipped through the typew..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[294]` **Narrator**: "Though your paper resonated with..." |
| `[326]` | **"Purges against the nobility began."** | `[325]` **Narrator**: "Under Sotelato’s leadership, the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[612]` **Narrator**: "Sotelato held back the hardline ..."<br>`[621]` **Narrator**: "Sotelato held back the hardline ..."<br>*(oraz 4 innych odgałęzień)* |
| `[327]` | **"Then, a loud bang."** | `[328]` **Narrator**: "You decamped to one of your fami..."<br>`[551]` **Narrator**: "You decamped to one of your fami..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Player_Romus**: "...moved to Iza for a taste of c..." |
| `[329]` | **"You took her advice."** | `[549]` **Narrator**: "Amid this uncertainty, your moth..."<br>`[591]` **Narrator**: "Estela still didn't understand w..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_suitcase");` | `[643]` **Narrator**: "Your mother reminded you that sh..."<br>`[511]` **Narrator**: "Your mother reminded you that sh..." |
| `[330]` | **"In spite of her warnings, you chose to stay."** | `[591]` **Narrator**: "Estela still didn't understand w..."<br>`[630]` **Narrator**: "Your loved ones still didn't und..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Narrator**: "You decamped to one of your fami..."<br>`[328]` **Narrator**: "You decamped to one of your fami..." |
| `[351]` | **"...tried not to make the same mistakes you did with Vina."** | `[233]` **Narrator**: "The birth of Queen Lucita's son ..." | `Variable["RiziaDLC.Vina_Escapes"] == true` | `PrologueImage("pe_relaxed");` | `[352]` **Narrator**: "You lived out the rest of your d..." |
| `[352]` | **"1976\|Porte Drazon\|Long Live The King"** | `[222]` **Player_Romus**: "...let the Palace staff do most ..."<br>`[234]` **Player_Romus**: "...assumed childrearing duties w..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Player_Romus**: "...did not envy him."<br>`[354]` **Player_Romus**: "...wished him the best of luck."<br>*(oraz 1 innych odgałęzień)* |
| `[353]` | **"...did not envy him."** | `[352]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[354]` | **"...wished him the best of luck."** | `[352]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[355]` | **"...were reassured by the knowledge that the reign of House Toras would continue --..."** | `[352]` **Narrator**: "You lived out the rest of your d..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[359]` | **"Days passed in uncertainty."** | `[356]` **Narrator**: "You decamped to one of your fami..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Narrator**: "At long last, the security threa..."<br>`[223]` **Narrator**: "Over time, the security threats ..."<br>*(oraz 1 innych odgałęzień)* |
| `[363]` | **"...your heartache from Vina's death diminished, though it never truly went away."** | `[109]` **Narrator**: "After a long, intense wait, the ..." | `Variable["RiziaDLC.Vina_FuneralHappened"] == true` | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[403]` | **"...threw yourself into raising your son."** | `[121]` **Narrator**: "Vina's whereabouts remained a my..." | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false` | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[404]` | **"...spent all your spare time trying to track her down."** | `[121]` **Narrator**: "Vina's whereabouts remained a my..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[410]` | **"A crown was on your head."** | `[409]` **Narrator**: "In it, your daughter expressed h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[411]` | **"...a letter from Vina."** | `[290]` **Narrator**: "Over the years, your societal pr..." | `Variable["RiziaDLC.Vina_FuneralHappened"] == false` | *Brak zmian stanu* | `[685]` **Narrator**: "In a short note, your daughter e..."<br>`[690]` **Narrator**: "In a short note, your daughter e..."<br>*(oraz 2 innych odgałęzień)* |
| `[423]` | **"...welcomed her with open arms."** | `[419]` **Narrator**: "After the war ended, she had fin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[424]` | **"...urged her to go elsewhere, knowing she'd never truly be safe at home."** | `[419]` **Narrator**: "After the war ended, she had fin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[425]` | **"...apologized for the way everything had turned out."** | `[419]` **Narrator**: "After the war ended, she had fin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[429]` | **"...never answered."** | `[408]` **Narrator**: "With stiff formality, she inform..."<br>`[432]` **Narrator**: "With stiff formality, she inform..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[430]` | **"...wrote back, apologizing for everything you'd put her through."** | `[408]` **Narrator**: "With stiff formality, she inform..."<br>`[432]` **Narrator**: "With stiff formality, she inform..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Narrator**: "Eventually, you and Vina struck ..." |
| `[431]` | **"...burned the letter, knowing your daughter's family would be safer that way."** | `[408]` **Narrator**: "With stiff formality, she inform..."<br>`[432]` **Narrator**: "With stiff formality, she inform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[434]` | **"You had it framed."** | `[433]` **Narrator**: "In it, your daughter expressed h..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[435]` | **"You couldn't bear to look at it."** | `[433]` **Narrator**: "In it, your daughter expressed h..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[296]` **Narrator**: "As time marched on, you aged wit..." |
| `[441]` | **"...to accept her offer and move to the Grand Duchy."** | `[49]` **Narrator**: "Vina wasted no time visiting. Sh..."<br>`[85]` **Narrator**: "Vina wasted no time visiting. Li..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false` | `PrologueImage("pe_palesvisit");` | `[52]` **Narrator**: "You, your mother and Lucita were..."<br>`[445]` **Narrator**: "You, your mother and Pabel were ..."<br>*(oraz 1 innych odgałęzień)* |
| `[445]` | **"1958\|Pales\|Court Life"** | `[50]` **Player_Romus**: "...to accept her offer and move ..."<br>`[441]` **Player_Romus**: "...to accept her offer and move ..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[53]` **Player_Romus**: "You accepted."<br>`[54]` **Player_Romus**: "You rejected." |
| `[449]` | **"1958\|Pales\|Court Life"** | `[50]` **Player_Romus**: "...to accept her offer and move ..."<br>`[441]` **Player_Romus**: "...to accept her offer and move ..." | `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[53]` **Player_Romus**: "You accepted."<br>`[54]` **Player_Romus**: "You rejected." |
| `[474]` | **"You sent her a letter of congratulations."** | `[473]` **Narrator**: "One day, you opened your morning..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[478]` **Narrator**: "The Queen didn't respond to your..." |
| `[475]` | **"You begged her to be able to visit your child."** | `[473]` **Narrator**: "One day, you opened your morning..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Narrator**: "The Queen sent her regrets, tell..." |
| `[476]` | **"You ignored the news."** | `[473]` **Narrator**: "One day, you opened your morning..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>`[460]` **Narrator**: "Your mother, feeling homesick, t..." |
| `[479]` | **"You wondered how it came to this."** | `[477]` **Narrator**: "The Queen sent her regrets, tell..."<br>`[478]` **Narrator**: "The Queen didn't respond to your..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>`[460]` **Narrator**: "Your mother, feeling homesick, t..." |
| `[480]` | **"You tried to move on."** | `[477]` **Narrator**: "The Queen sent her regrets, tell..."<br>`[478]` **Narrator**: "The Queen didn't respond to your..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Narrator**: "Your mother, feeling homesick, t..."<br>`[460]` **Narrator**: "Your mother, feeling homesick, t..." |
| `[490]` | **"You cursed your family."** | `[489]` **Narrator**: "He explained to you that the new..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..."<br>*(oraz 2 innych odgałęzień)* |
| `[491]` | **"It was better than living in fear."** | `[489]` **Narrator**: "He explained to you that the new..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "Settling into Estela's guest hou..."<br>`[77]` **Narrator**: "Taking refuge in your mother's g..."<br>*(oraz 2 innych odgałęzień)* |
| `[495]` | **"1958\|Topes\|Seaside Life"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Player_Romus**: "Managed the local tourism center..."<br>`[256]` **Player_Romus**: "Took up fishing as a pastime."<br>*(oraz 1 innych odgałęzień)* |
| `[503]` | **"...tried to relax, but couldn't stop following the news."** | `[154]` **Narrator**: "With nothing but painful reminde..."<br>`[262]` **Narrator**: "Lucita followed you to the Brena..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth");` | `[109]` **Narrator**: "After a long, intense wait, the ..."<br>`[473]` **Narrator**: "One day, you opened your morning..."<br>*(oraz 1 innych odgałęzień)* |
| `[504]` | **"1958\|Iza\|City Life"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Player_Romus**: "...started writing poetry and jo..."<br>`[261]` **Player_Romus**: "...reveled in your sudden free t..."<br>*(oraz 2 innych odgałęzień)* |
| `[512]` | **"You left as soon as you could."** | `[511]` **Narrator**: "Your mother reminded you that sh..."<br>`[596]` **Narrator**: "Estela was staying at a hotel in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = false; Vari...`<br>`Variable["RiziaDLC.CoupWarning_Destination_Rumburg"] = fa...` | `[7]` **Player_Romus**: "...felt lucky that you didn't die."<br>`[347]` **Narrator**: "She and Manus visited Palas Rezn..." |
| `[543]` | **"The Kingdom was no more."** | `[542]` **Narrator**: "In the following days, Adarfo an..."<br>`[544]` **Narrator**: "In the following days, the revol..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `UnlockAchievement("Rizia_Sotelato");` | `[325]` **Narrator**: "Under Sotelato’s leadership, the..." |
| `[546]` | **"The Kingdom was no more."** | `[545]` **Narrator**: "In the following days, the revol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[547]` **Narrator**: "Without a clear leadership, the ..." |
| `[548]` | **"Purges against the nobility began."** | `[547]` **Narrator**: "Without a clear leadership, the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "Amid this uncertainty, your moth..." |
| `[550]` | **"In spite of her warnings, you chose to stay."** | `[549]` **Narrator**: "Amid this uncertainty, your moth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[551]` **Narrator**: "You decamped to one of your fami..." |
| `[561]` | **"...wished you could partake in their joy with them."** | `[560]` **Narrator**: "People from all walks of life we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "The Rizian flag atop the palace ..." |
| `[584]` | **"...begged for forgiveness."** | `[580]` **Narrator**: "Sotelato held back the hardline ..."<br>`[592]` **Narrator**: "Sotelato held back the hardline ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Narrator**: "Estela still didn't understand w..."<br>`[630]` **Narrator**: "Your loved ones still didn't und..." |
| `[585]` | **"...cried with relief."** | `[580]` **Narrator**: "Sotelato held back the hardline ..."<br>`[592]` **Narrator**: "Sotelato held back the hardline ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Narrator**: "Estela still didn't understand w..."<br>`[630]` **Narrator**: "Your loved ones still didn't und..." |
| `[586]` | **"...missed Lucita more than ever."** | `[580]` **Narrator**: "Sotelato held back the hardline ..."<br>`[592]` **Narrator**: "Sotelato held back the hardline ..." | `Variable["RiziaDLC.Lucita_Married"] == true` | *Brak zmian stanu* | `[591]` **Narrator**: "Estela still didn't understand w..."<br>`[630]` **Narrator**: "Your loved ones still didn't und..." |
| `[590]` | **"...wondered if your family would ever be truly safe."** | `[580]` **Narrator**: "Sotelato held back the hardline ..."<br>`[592]` **Narrator**: "Sotelato held back the hardline ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Narrator**: "Estela still didn't understand w..."<br>`[630]` **Narrator**: "Your loved ones still didn't und..." |
| `[601]` | **"Then democracy arrived in the kingdom."** | `[343]` **Narrator**: "You watched your successor's cro..." | `Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true` | `PrologueImage("pe_newgovernment");` | `[603]` **Narrator**: "The first ever general election ..." |
| `[622]` | **"...tried to explain your side of the story."** | `[580]` **Narrator**: "Sotelato held back the hardline ..."<br>`[592]` **Narrator**: "Sotelato held back the hardline ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Narrator**: "Estela still didn't understand w..."<br>`[630]` **Narrator**: "Your loved ones still didn't und..." |
| `[647]` | **"...insights gleaned from your time as Rizia's monarch."** | `[56]` **Narrator**: "The ambassador Nicolas Rembrandt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Lucita's discomfort with the Pal..."<br>`[147]` **Narrator**: "Pabel reveled in the city's ener..."<br>*(oraz 1 innych odgałęzień)* |
| `[651]` | **"...you swore you'd be a better father the second time around."** | `[109]` **Narrator**: "After a long, intense wait, the ..." | `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`<br>`(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false` | `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>`Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`<br>*(+2 skryptów)* | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[120]` **Narrator**: "A year later, Vina and Axel visi..." |
| `[675]` | **"You were happy for her."** | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[672]` **Narrator**: "Through the grapevine, you heard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[676]` | **"Her absence stung."** | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[672]` **Narrator**: "Through the grapevine, you heard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[680]` | **"You were too wrapped up in fatherhood to care."** | `[669]` **Narrator**: "Through the grapevine, you heard..."<br>`[672]` **Narrator**: "Through the grapevine, you heard..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false` | `PrologueImage("pe_burning");`<br>`PrologueImage("pe_continuedreign5");`<br>*(+1 skryptów)* | `[189]` **Narrator**: "A chilling announcement halted t..."<br>`[190]` **Narrator**: "An alarming broadcast interrupte..." |
| `[681]` | **"You ached to feel important again."** | `[310]` **Narrator**: "At long last, Rumburg and Sordla..."<br>`[450]` **Narrator**: "At long last, Rumburg and Sordla..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_relaxed");` | `[290]` **Narrator**: "Over the years, your societal pr..." |
| `[689]` | **"A crown was on her head."** | `[685]` **Narrator**: "In a short note, your daughter e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Narrator**: "Eventually, you and Vina struck ..." |
| `[692]` | **"A long month passed."** | `[78]` **Narrator**: "To circumvent any potential for ..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_continuedreign1");` | `[153]` **Narrator**: "After serving your month-long se..."<br>`[502]` **Narrator**: "After serving your month-long se..." |

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
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_KingdomDissolves_Revolution == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Abdication_Speech == true)"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "1957|Porte Drazon|A New Era"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "1957|Porte Drazon|A New Era"]** — Mówca: **Narrator**
> "You leaned over the balcony railing. Your knees felt weak.

'Was this it?', you asked. 'Was this the end of my reign?'. With these words in your mind, gone were the days of Romus the First.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: "...felt relieved from the burden."*)
  - -> `[5]` (*Player_Romus: "...were furious with anger."*)
  - -> `[7]` (*Player_Romus: "...felt lucky that you didn't die."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were furious with anger."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt relieved from the burden."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt lucky that you didn't die."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Ending_Revolution"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator), `[176]` (Player_Romus), `[175]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "People were cheering with a magnitude you had never seen before. They threw down their weapons and hugged each other.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: "...thought that perhaps this was the best possible outcome."*)
  - -> `[9]` (*Player_Romus: "...promised that you would get your revenge one day."*)
  - -> `[11]` (*Player_Romus: "...wondered how your days would be from now on."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...promised that you would get your revenge one day."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The Rizian flag atop the palace unfurled strongly with th..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...thought that perhaps this was the best possible outcome."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator), `[560]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The Rizian flag atop the palace unfurled strongly with th..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wondered how your days would be from now on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator), `[560]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The Rizian flag atop the palace unfurled strongly with th..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The Rizian flag atop the palace unfurled strongly with the wind.

You thought that it was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: "...the most beautiful thing you ever saw."*)
  - -> `[14]` (*Player_Romus: "...not worth dying for."*)
  - -> `[15]` (*Player_Romus: "...just a piece of cloth."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the most beautiful thing you ever saw."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...not worth dying for."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...just a piece of cloth."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Abdication_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Abdication_Speech == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Abdication_Speech == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Abdication_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "Jump to: [Abdication Hub]"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Abdication_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "Jump to: [Usurped Hub]"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Abdication Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "Abdication Hub"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Abdication Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Kingdom Dissolves Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_revolution")"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Usurped Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Usurped Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "Usurped Hub"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "1958|Porte Drazon|A New Era"]** — Mówca: **Narrator**
> "Releasing the reins of power had been a challenge, both for you and for the nation. Yet, it was a threshold crossed, a door shut behind you. 

As one chapter ended, another began – not just for you, but for Rizia too. In the weeks that followed, the kingdom felt reborn, marked by new leadership and new attitudes. 

You felt..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: "...a sense of relief wash over you."*)
  - -> `[195]` (*Player_Romus: "...hopeful about the future unfolding."*)
  - -> `[196]` (*Player_Romus: "...a pang of regret for your past reign's shortcomings."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then democracy arrived in the kingdom."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true` AND `(Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[343]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_newgovernment")"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "1958|Porte Drazon|A New Era"]** — Mówca: **Narrator**
> "Power had been a fragile thing, bestowed and then forcibly taken away. In the Citadel, days had turned into weeks. 

The same walls that had once confined many during your reign now held you captive.

You..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[278]` (Player_Romus), `[297]` (Player_Romus), `[298]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: "...found bitter irony in this cruel twist of fate."*)
  - -> `[65]` (*Player_Romus: "...felt nothing but the weight of time, indifferent and p..."*)
  - -> `[66]` (*Player_Romus: "...counted each day, a silent rebellion against your fate."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...found bitter irony in this cruel twist of fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Adarfo == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_PrimeMinister_Adarfo == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: "Then democracy arrived in the kingdom."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Daria == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Reform == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Rumors seeped through the prison walls. The coupists had ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The world outside had shifted and morphed, yet in many wa..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Hugo == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: "...by the royal decree of King Hugo Toras, your life shal..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Rico == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Rico == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: "...under the royal decree of King Rico Toras, your life i..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Taddeus == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: "...through the royal decree of King Taddeus Azaro, your l..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: "...by the royal decree of Queen Angelica Sazon, your exis..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Su..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: "...by the royal decree of Queen Lucita Azaro, your senten..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: "...by the royal decree of Queen Lucita Azaro, your life i..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Relations_Vina_Estranged == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true && RiziaDLC...."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Relations_Vina_Estranged == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Co..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Relations_Vina_Estranged == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Vina wasted no time visiting. She recounted how she and Axel had spent the days following the coup with their ears glued to the radio, anxiously waiting for news of your survival.

Now that you were free, she asked you to join her and her husband in Pales, away from the influence of the noble houses.

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[51]` (*Player_Romus: "...to remain in Rizia, requesting for her to visit you soon."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to accept her offer and move to the province."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator), `[85]` (Narrator), `[472]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_palesvisit")"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to remain in Rizia, requesting for her to visit you soon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator), `[85]` (Narrator), `[472]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Taking refuge in your mother's guest house in Porte Drazo..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "1958|Pales|Court Life"]** — Mówca: **Narrator**
> "You, your mother and Lucita were given an exquisitely lavish set of rooms at the castle with Axel, Vina and the rest of the royal household.

It felt like the luxury of the old days, and spending time around Vina felt good. 

Axel came to you to ask for a favor. Your presence was requested at a party where Arcasian diplomats would be in attendance."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Player_Romus), `[441]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: "You accepted."*)
  - -> `[54]` (*Player_Romus: "You rejected."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator), `[445]` (Narrator), `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The ambassador Nicolas Rembrandteur and the Foreign Minis..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You rejected."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator), `[445]` (Narrator), `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "You decided to explore the city of Pales instead. You had..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you didn't want family tying you down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "You congratulated your daughter and her husband on their ..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "The ambassador Nicolas Rembrandteur and the Foreign Minister Louis Martell were present at the evening.

Axel introduced them to you and you charmed them with your..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[647]` (*Player_Romus: "...insights gleaned from your time as Rizia's monarch."*)
  - -> `[125]` (*Player_Romus: "...deep philosophical musings."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: "...life partner, Pabel."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: "...mother, Estela."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of King Hugo Toras, your life shall be spared, your honor reinstated, and your family granted clemency."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "You would never again wear the crown. But for the first t..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "At least you fought for something greater, for a better world."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The world outside had shifted and morphed, yet in many wa..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't help but wish you had crushed your enemies when you had the chance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The world outside had shifted and morphed, yet in many wa..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The coupists had crushed Rizia's nascent democracy. 

The reform movement, once a beacon of hope, had become nothing but a stillborn dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: "At least you fought for something greater, for a better w..."*)
  - -> `[62]` (*Player_Romus: "You couldn't help but wish you had crushed your enemies w..."*)
  - -> `[67]` (*Player_Romus: "It seemed pointless now, worrying about what could have b..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "The world outside had shifted and morphed, yet in many ways, it had remained achingly the same. 

Your release came as part of the Sovereign Transition and Clemency Act signed by the new monarch of Rizia.

On your way out you were handed a letter that read..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Hugo == true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt nothing but the weight of time, indifferent and patient."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...counted each day, a silent rebellion against your fate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Reform == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It seemed pointless now, worrying about what could have been."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The world outside had shifted and morphed, yet in many wa..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...under the royal decree of King Rico Toras, your life is hereby preserved, your honor reclaimed, and the safety of your family assured."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true` AND `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "You would never again wear the crown. But for the first t..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...through the royal decree of King Taddeus Azaro, your life is spared, your honor restored, and your family's sanctity upheld."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Stepping out of the Citadel, the sight of new monuments a..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, your life is spared, your honor redeemed, and your family's well-being guaranteed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Stepping out of the Citadel, the sight of new monuments a..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Angelica Sazon, your existence is spared, your honor renewed, and your family's safety preserved."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Stepping out of the Citadel, the sight of new monuments a..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Stepping out of the Citadel, the sight of new monuments and currency greeted you, your once-familiar kingly face absent from it all. 

Beyond the prison gates, there awaited your beloved..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Settling into Estela's guest house in Porte Drazon for a ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Taking refuge in your mother's guest house in Porte Drazo..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Settling into Estela's guest house in Porte Drazon for a few days provided a needed respite to gather your thoughts. 

Leafing through a newspaper, you discovered the war at the southern border with the Grand Duchy was still unrelenting.

It was a moment to ponder your next steps. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ".....settled seaside in Topes, near the ancient Rezenid s..."*)
  - -> `[80]` (*Player_Romus: "...moved to a hut in Zpana's nature."*)
  - -> `[79]` (*Player_Romus: "...moved to Iza for a taste of city life."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Taking refuge in your mother's guest house in Porte Drazon, you allowed yourself a few days to reorient.

A glance at the newspaper revealed upcoming celebrations and festivities across Rizia, marking a time of national joy. 

It was a moment to ponder your next steps. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ".....settled seaside in Topes, near the ancient Rezenid s..."*)
  - -> `[80]` (*Player_Romus: "...moved to a hut in Zpana's nature."*)
  - -> `[79]` (*Player_Romus: "...moved to Iza for a taste of city life."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "To circumvent any potential for political unrest in the capital, Queen Lucita moved your imprisonment to Iza, far from Porte Drazon. 

You were relocated to a slightly better jail cell with a view of the city skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Player_Romus: "A long month passed."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...moved to Iza for a taste of city life."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator), `[77]` (Narrator), `[327]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...moved to a hut in Zpana's nature."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator), `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ".....settled seaside in Topes, near the ancient Rezenid sites."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator), `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EpilogueIza]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "EpilogueIza"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EpilogueIza`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_continuedreign1")"*)

### Węzeł `[84]`
Mówca: **Narrator**
> "You would never again wear the crown. But for the first time since your birth, choosing your destiny was truly in your hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: "A fresh start awaited."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Vina wasted no time visiting. Life in Pales with Axel was flourishing, she said. She extended an invitation to join them and start anew together. 

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[51]` (*Player_Romus: "...to remain in Rizia, requesting for her to visit you soon."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: "...wife, Lucita."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wife, Lucita."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, your sentence is to be extended by an additional 30 days."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "To circumvent any potential for political unrest in the c..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...mother, Estela."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A fresh start awaited."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Stepping out of the Citadel, the sight of new monuments a..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "After serving your month-long sentence, you emerged from ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "After serving your month-long sentence, you emerged from ..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...life partner, Pabel."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_P..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "1958|Topes|Seaside Life"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "1958|Topes|Seaside Life"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Lucita agreed with the plan. Together, you journeyed to the east coast of Valenqiris. 

A lovely house was chosen, graced with a sea view and proximity to historical sites.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Kontekst wejściowy (poprzednik):** `[81]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: "Managed the local tourism center, occasionally guiding."*)
  - -> `[256]` (*Player_Romus: "Took up fishing as a pastime."*)
  - -> `[259]` (*Player_Romus: "Relaxed and enjoyed your new downtime."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Pabel immediately agreed to come with you to the east coast of Valenqiris.

You found a delightful house with a stunning sea view, nestled near historical landmarks.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: "Managed the local tourism center, occasionally guiding."*)
  - -> `[256]` (*Player_Romus: "Took up fishing as a pastime."*)
  - -> `[259]` (*Player_Romus: "Relaxed and enjoyed your new downtime."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Estela welcomed the change and journeyed with you to the east coast of Valenqiris.

Once there, you..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[81]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: "Managed the local tourism center, occasionally guiding."*)
  - -> `[256]` (*Player_Romus: "Took up fishing as a pastime."*)
  - -> `[259]` (*Player_Romus: "Relaxed and enjoyed your new downtime."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_princebirth")"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "After a long, intense wait, the moment arrived. Late at night, Lucita woke you up to tell you the baby was coming.

At 11:13 AM, your son opened his eyes to his first morning. In that instant..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[114]` (*Player_Romus: "...the joy of parenthood eclipsed all else."*)
  - -> `[115]` (*Player_Romus: "...everything else faded, only this moment mattered."*)
  - -> `[116]` (*Player_Romus: "...all of life's complexities seemed trivial."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Life with Pabel was fulfilling, despite the occasional od..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_Z..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Life with Pabel was fulfilling, despite the occasional odd looks from locals. When you were together, everything else seemed trivial. 

In this newfound contentment, you spent more time..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: "...immersing yourself in the local culture."*)
  - -> `[281]` (*Player_Romus: "...pursuing hobbies and self-growth."*)
  - -> `[282]` (*Player_Romus: "...partaking in community social work."*)
  - -> `[302]` (*Player_Romus: "...partying with your old rich friends."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the joy of parenthood eclipsed all else."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...everything else faded, only this moment mattered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...all of life's complexities seemed trivial."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true )"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "A year later, Vina and Axel visited, bringing a delightful surprise – their baby daughter Lena, named after her grandmother.

In that moment of familial joy, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Vina's whereabouts remained a mystery.

You wondered if you would ever see or hear from your daughter again.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[404]` (*Player_Romus: "...spent all your spare time trying to track her down."*)
  - -> `[309]` (*Player_Romus: "...decided to focus on yourself."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "You decided to explore the city of Pales instead. You had never truly gotten to know it before. Now, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: "..wandered the historic streets, absorbing the city's her..."*)
  - -> `[126]` (*Player_Romus: "..enjoyed the beach scene, mingling incognito with locals..."*)
  - -> `[127]` (*Player_Romus: "...went out on the town, hunting for the best restaurants..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "..legendary humor, regaling them with witty anecdotes."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...outlandish tales from your Party Prince days."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...deep philosophical musings."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "..enjoyed the beach scene, mingling incognito with locals and tourists."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...went out on the town, hunting for the best restaurants and bars."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Months passed in Pales, and the Grand Duchy, under Vina and Axel's stewardship, flourished. 

Their happiness grew with the arrival of their baby daughter Lena, named after her grandmother. When Vina asked for your help in caring for her new child, it prompted a moment of reflection. 

You realized..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: "...you wanted nothing more than to be a caring grandfather."*)
  - -> `[55]` (*Player_Romus: "...you didn't want family tying you down."*)
  - -> `[272]` (*Player_Romus: "...you could balance your time between helping with Lena ..."*)
  - -> `[273]` (*Player_Romus: "...guiding Lena's early years could become a significant ..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you wanted nothing more than to be a caring grandfather."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Embracing grandfatherhood, you spent countless hours with..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: "..legendary humor, regaling them with witty anecdotes."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "..wandered the historic streets, absorbing the city's heritage."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_WorldWar == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_WorldWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_burning")"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_WorldWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true || BaseGame.Endin..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "An alarming broadcast interrupted your day: Rumburg was u..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Lucita's discomfort with the Palesians deepened as her pr..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Pabel reveled in the city's energy. You made no secret of..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "The sea air was a comfort to your aging mother, though sh..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Lucita's discomfort with the Palesians deepened as her pregnancy advanced. You did your best to support her regardless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: "It was good to spend time with loved ones."*)
  - -> `[271]` (*Player_Romus: "Things could be much worse in life."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Pabel reveled in the city's energy. You made no secret of your relationship, and though at first you were worried you wouldn't be accepted, the elite social circles seemed indifferent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: "It was good to spend time with loved ones."*)
  - -> `[271]` (*Player_Romus: "Things could be much worse in life."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "The sea air was a comfort to your aging mother, though she often yearned for Zille. 

She threw herself into helping Vina and Axel organize parties and gatherings for the Palesian elite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: "It was good to spend time with loved ones."*)
  - -> `[271]` (*Player_Romus: "Things could be much worse in life."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was good to spend time with loved ones."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator), `[147]` (Narrator), `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_princebirth")"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[153]`
Mówca: **Narrator**
> "After serving your month-long sentence, you emerged from Iza City Prison to a different world. New monuments had risen, and the currency circulated without the familiar imprint of your face. 

Clutching a newspaper, you learned the war at the southern border near the Grand Duchy was still raging. Its ramifications would last years, if not decades.

As you stepped beyond the prison gates, there awaited..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "With nothing but painful reminders of your past life awaiting in Porte Drazon, you chose to stay in Iza and turn over a new leaf.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: "...started writing poetry and joined art circles."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[261]` (*Player_Romus: "...reveled in your sudden free time."*)
  - -> `[503]` (*Player_Romus: "...tried to relax, but couldn't stop following the news."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: "...your life partner, Pabel."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: "...your mother, Estela."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...your mother, Estela."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator), `[502]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "With nothing but painful reminders of your past life awai..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...your life partner, Pabel."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator), `[502]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "With nothing but painful reminders of your past life awai..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "1958|Zpana|Rural Life"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "1958|Zpana|Rural Life"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false &&RiziaDLC.Coup_Leader_Lucita == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false &&RiziaDLC.Coup_Leader_Lucita == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "1958|Zpana|Rural Life"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false &&RiziaDLC.Coup_Leader_Lucita == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "1958|Zpana|Rural Life"]** — Mówca: **Narrator**
> "Though skeptical at first, Lucita joined you in the wilderness. After a while, she began to appreciate the slower pace of life there.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: "Took up hunting as a hobby."*)
  - -> `[254]` (*Player_Romus: "Started farming, cultivating your own crops."*)
  - -> `[260]` (*Player_Romus: "Relaxed and made new friends."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "1958|Zpana|Rural Life"]** — Mówca: **Narrator**
> "Pabel, eager to get away from prying eyes, accompanied you to the serene hut nestled in Zpana's wilderness.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: "Took up hunting as a hobby."*)
  - -> `[254]` (*Player_Romus: "Started farming, cultivating your own crops."*)
  - -> `[260]` (*Player_Romus: "Relaxed and made new friends."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "1958|Zpana|Rural Life"]** — Mówca: **Narrator**
> "Your mother appreciated the serenity of Zpana's nature, endorsing the move to the peaceful hut.

You..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: "Took up hunting as a hobby."*)
  - -> `[254]` (*Player_Romus: "Started farming, cultivating your own crops."*)
  - -> `[260]` (*Player_Romus: "Relaxed and made new friends."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Jump From Kingdom Dissolves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Jump from Kingdom Dissolves to Death]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: "...moved to Iza for a taste of city life."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_QuelledProtests <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_Qu..."*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_QuelledProtests <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == false  and  Variable["RiziaDLC.Country_QuelledProtests"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "You decamped to one of your family guest houses near Port..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_QuelledProtests <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false  and  Variable["RiziaDLC.Country_QuelledProtests"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "You decamped to one of your family guest houses near Port..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Exile_Rumburg = true;
RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true;
Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CoupWarning_Destination_Rumburg = false; RiziaDL..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Kyrute was the safest option."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Narrator), `[634]` (Narrator), `[643]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_Rumburg = false; RiziaDLC.Epilogu..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Rumburg sounded nice."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Narrator), `[634]` (Narrator), `[643]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_Rumburg = true; RiziaDLC.Epilogue..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Exile_Rumburg = false; RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = false;
Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CoupWarning_Destination_Rumburg = false; RiziaDL..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Your life was an open door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator), `[223]` (Narrator), `[244]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[179]`
Mówca: **Narrator**
> "The first ever general election in Rizia was nothing short of a spectacle. With an impressive 80% turnout, the people demonstrated their hunger for change and voted overwhelmingly in favor of the RPP.

Adarfo Sotelato championed a sweeping reform agenda, far beyond what you had managed to achieve as king.

In his inaugural speech, he hailed a new era, while relegating your legacy to the past. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: "...felt a twinge of obsolescence."*)
  - -> `[186]` (*Player_Romus: "...wrote him a letter of congratulations."*)
  - -> `[184]` (*Player_Romus: "...didn't care and just wanted to move on."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Rizia's first general election was a remarkable event. Achieving a 60% turnout, Prime Minister Daria de Rava triumphed, resonating with the kingdom's nationalist pulse. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: "...wrote her a letter congratulating her on her win."*)
  - -> `[187]` (*Player_Romus: "...wished for more radical change."*)
  - -> `[225]` (*Player_Romus: "...felt reassured by her approach to maintain unity."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Daria == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_PrimeMinister_Daria == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_letter")"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Romus: "A few weeks passed."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't care and just wanted to move on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator), `[603]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wrote her a letter congratulating her on her win."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wrote him a letter of congratulations."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator), `[603]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished for more radical change."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Over time, the security threats diminished, granting you the freedom you'd longed for. 

You rekindled your bonds with friends and acquaintances you hadn't seen since taking the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: "Your life was an open door."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "A chilling announcement halted the continent: a devastating nuclear exchange had ravaged Holsord and parts of Rumburg.

The AN's swift intervention brought a respite from the hostilities within 72 hours, though conventional conflicts in East Merkopa escalated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: "War, war never changes."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "An alarming broadcast interrupted your day: Rumburg was under invasion by the Republic of Sordland. 

The toll was already steep, with no end in sight. While Rumburg was distant, the war's impact was felt in Rizia, where Rumburgian refugees were reluctant to return to their ravaged homeland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player_Romus: "You worried about the future."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Lucita == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coup_Leader_Lucita == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Su..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coup_Leader_Taddeus == true"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a sense of relief wash over you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pa_abdication1")"*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...hopeful about the future unfolding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pa_abdication1")"*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a pang of regret for your past reign's shortcomings."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pa_abdication1")"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Vina == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Vina == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Queen Vina quickly endeared herself to the populace, earn..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Hugo == true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Hugo == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Hugo == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "King Hugo garnered respect from older citizens, who haile..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Rico == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Rico == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Rico == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Hubertus == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Hubertus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Hubertus == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Hubertus == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Hubertus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Hubertus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Hubertus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Hubertus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Lucita == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "You watched your successor's crowning from seclusion. Dea..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Queen Vina quickly endeared herself to the populace, earning the affectionate title of 'People's Queen.' 

Shortly after her coronation, she initiated a sweeping campaign to eradicate poverty that proved both popular and effective. 

In her speeches, she gratefully acknowledged your contributions to the nation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: "Long live the new Queen."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "King Hugo garnered respect from older citizens, who hailed him as 'The Protector King.' 

In his coronation address, he championed education and traditional values while paying homage to your legacy with respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "Long live the new King."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "King Rico Toras infused a newfound sense of nationalism and monarchism in Rizia. 

His first decree incorporated Su Omina into Rizia's national security forces.

Notably, he made no mention of you in his coronation address."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "Long live the new King."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Ascending monarch Hubertus Toras faced skepticism beyond Valenqiris, evidenced by the subdued response to his coronation. 

His first decree focused on boosting tourism with an amusement park in Valenqir. 

During his first address, he devoted a considerable time to lauding your tenure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "Long live the new King."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "As Lucita Azaro ascended the throne as interim queen, you stood by her side as King Consort. Her popularity extended beyond Cardesse-Montaklar, overshadowing even your own legacy. 

In her first address, she acknowledged your past contributions with graciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: "Long live the new Queen."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the new Queen."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Narrator), `[216]` (Narrator), `[334]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "You watched your successor's crowning from seclusion. Dea..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the new King."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Narrator), `[214]` (Narrator), `[215]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "You watched your successor's crowning from seclusion. Dea..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Lucita == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Queen Lucita Azaro arranged for your transfer to Palas Re..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "Security threats diminished"*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...let the Palace staff do most of the work."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Over time, the security threats diminished, granting you the freedom you'd longed for. 

You immediately sought out Pabel. At long last, the two of you could be together without fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: "Your life was an open door."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt a twinge of obsolescence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator), `[603]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt reassured by her approach to maintain unity."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...immersing yourself in study and knowledge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "But the serenity of your new life didn't last long. You w..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "Queen Lucita Azaro arranged for your transfer to Palas Rezna, reflecting the country's return to tranquility and a smoother-than-anticipated transition. 

In the grandeur of the palace, you spent your days..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: "...aiding her in state matters as King Consort."*)
  - -> `[230]` (*Player_Romus: "...tending to the gardens."*)
  - -> `[226]` (*Player_Romus: "...immersing yourself in study and knowledge."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "But the serenity of your new life didn't last long. You were in your study when you received the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Vina was expecting a child."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tending to the gardens."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "But the serenity of your new life didn't last long. You w..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...aiding her in state matters as King Consort."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "But the serenity of your new life didn't last long. You w..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Lucita was in labor."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_princebirth")"*)

### Węzeł `[233]`
Mówca: **Narrator**
> "The birth of Queen Lucita's son {RiziaDLCText.KingsSon} sparked jubilation throughout the kingdom.

As a father for the second time, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus: "...assumed childrearing duties while your wife held the t..."*)
  - -> `[222]` (*Player_Romus: "...let the Palace staff do most of the work."*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...assumed childrearing duties while your wife held the throne."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Over time, the security threats diminished, granting you ..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Over time, the security threats diminished, granting you ..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A few weeks passed."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Daria"] == true) == false` AND `(Variable["RiziaDLC.Epilogue_PrimeMinister_Adarfo"] == true) == false` AND `(Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[343]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_continuedreign1")"*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then democracy arrived in the kingdom."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Rizia's first general election was a remarkable event. Ac..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "At long last, the security threats diminished, granting y..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[244]`
Mówca: **Narrator**
> "At long last, the security threats diminished, granting you the freedom you'd longed for. 

You reunited with Lucita, grateful that you hadn't yet missed the birth of your son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: "Your life was an open door."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC...."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: "Vina was expecting a child."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: "Lucita was in labor."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "The news of your grandchild-to-be -- and the new heir to the Palesian throne -- filled you with joy.

Axel and Vina's visit to Palas Rezna was a time of celebration, a gathering of generations. 

Then, just a week later, the Queen herself went into labor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: "Rizia's new prince was born."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Rizia's new prince was born."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Narrator), `[347]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_princebirth")"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Outcome_NoPeace_KeepFighting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_continuedreign5")"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Took up hunting as a hobby."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator), `[167]` (Narrator), `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Started farming, cultivating your own crops."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator), `[167]` (Narrator), `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Managed the local tourism center, occasionally guiding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Narrator), `[104]` (Narrator), `[105]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Took up fishing as a pastime."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Narrator), `[104]` (Narrator), `[105]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...started writing poetry and joined art circles."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[262]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to try your hand at stand-up comedy."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[262]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Relaxed and enjoyed your new downtime."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Narrator), `[104]` (Narrator), `[105]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Relaxed and made new friends."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator), `[167]` (Narrator), `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...reveled in your sudden free time."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[262]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Lucita followed you to the Brenas capital. Together, you dove into the bustling urban culture there.

You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: "...started writing poetry and joined art circles."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[261]` (*Player_Romus: "...reveled in your sudden free time."*)
  - -> `[503]` (*Player_Romus: "...tried to relax, but couldn't stop following the news."*)

### Węzeł `[263]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Your mother, open to a change of scenery, relocated along with you.

You..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: "...started writing poetry and joined art circles."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[261]` (*Player_Romus: "...reveled in your sudden free time."*)
  - -> `[503]` (*Player_Romus: "...tried to relax, but couldn't stop following the news."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Pabel was excited to move to the Brenas capital. Since homosexuality was decriminalized, nightlife in the cultural hub was more thrilling than ever.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: "...started writing poetry and joined art circles."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[261]` (*Player_Romus: "...reveled in your sudden free time."*)
  - -> `[503]` (*Player_Romus: "...tried to relax, but couldn't stop following the news."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_E..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "1958|Iza|City Life"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "1958|Iza|City Life"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Things could be much worse in life."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator), `[147]` (Narrator), `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you could balance your time between helping with Lena and pursuing your own interests."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "You became a guiding presence in Lena's life while not fo..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...guiding Lena's early years could become a significant part of your legacy."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "In grandfatherhood, you found a sense of purpose. Your wi..."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Embracing grandfatherhood, you spent countless hours with Lena, witnessing her first steps, her first words. 

The bond you formed with her was irreplaceable, enriching your days with joy and laughter. 

As Lena grew, so did your role in her life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: "And thus your story ended."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "You congratulated your daughter and her husband on their new child, but told them you couldn't be counted on to help out.

You spent the rest of your days pursuing your own interests, traveling the world and telling anyone who'd listen about the brief time you spent as King of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_plane")"*)

### Węzeł `[276]`
Mówca: **Narrator**
> "You became a guiding presence in Lena's life while not forgoing your interests. 

The arrangement brought depth to your days, blending family warmth with personal growth. 

As Lena grew older, your relationship evolved. The title of "King Romus" faded from your memory, replaced by the name "Grandfather"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: "And thus your story ended."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "In grandfatherhood, you found a sense of purpose. Your wisdom and experiences became the bedrock of her upbringing. 

As she grew, so did the impact of your teachings.

The path ahead gleamed with the promise of her blossoming under your tutelage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: "And thus your story ended."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And thus your story ended."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator), `[276]` (Narrator), `[277]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[279]`
Mówca: **Narrator**
> "Your mother, feeling homesick, told you she wanted to spend her last years at her old house in Zille.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: "...immersing yourself in the local culture."*)
  - -> `[281]` (*Player_Romus: "...pursuing hobbies and self-growth."*)
  - -> `[282]` (*Player_Romus: "...partaking in community social work."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...immersing yourself in the local culture."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator), `[279]` (Narrator), `[460]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...pursuing hobbies and self-growth."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator), `[279]` (Narrator), `[460]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...partaking in community social work."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator), `[279]` (Narrator), `[460]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...guided your granddaughter and new son with wisdom and care."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator), `[367]` (Narrator), `[658]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...dedicated yourself to raising your son wisely."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[371]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...balanced your grandfatherly duties with personal time."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[399]` (Narrator), `[120]` (Narrator), `[367]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the psychology of warfare."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator), `[691]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Though your paper resonated with those who knew you best,..."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "As you flipped through the typewritten pages, a spark reignited within you for politics. 

Motivated, you resolved to pen your own thesis, asking your old university professors for guidance.

As a scholar, you focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[286]` (*Player_Romus: "...the psychology of warfare."*)
  - -> `[289]` (*Player_Romus: "...the wealth disparities in Rizia and the societal issue..."*)
  - -> `[288]` (*Player_Romus: "...the influence of the spiritual will in human societies."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the influence of the spiritual will in human societies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator), `[418]` (Narrator), `[691]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Though your paper resonated with those who knew you best,..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the wealth disparities in Rizia and the societal issues that arose from them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator), `[418]` (Narrator), `[691]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Though your paper resonated with those who knew you best,..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "1966|Rizia|An Old Man"]** — Mówca: **Narrator**
> "Over the years, your societal prominence waned. The eight years you spent as king faded in your memory, crowded out by your many other life experiences. 

During a quiet day at home, you picked up..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[313]` (Player_Romus), `[681]` (Player_Romus), `[311]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player_Romus: "...a political thesis a friend had entrusted you to review."*)
  - -> `[314]` (*Player_Romus: "...a history book from your father's old collection."*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == false"*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the teachings of Prophet Hu, the founder of Zaranism."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Time unfolded as you pursued this newfound passion for kn..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...Miraclism theories and the principles of conservatism."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Time unfolded as you pursued this newfound passion for kn..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...totalism and the concept of enforced efficient change."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Time unfolded as you pursued this newfound passion for kn..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Though your paper resonated with those who knew you best, it received a lukewarm reception from academic circles. 

For you, at least, the endeavor marked a new, more thoughtful chapter in your life.

Those around you began referring to you affectionately as 'the Professor King'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player_Romus: "It had a nice ring to it."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "Time unfolded as you pursued this newfound passion for knowledge. 

Your intellectual exploration defined your later years, earning you the moniker 'the philosopher king'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Player_Romus: "It had a nice ring to it."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "As time marched on, you aged with the wisdom and contentment your choices brought. 

Throughout the years, the name 'Romus Toras' was spoken with fondness and respect by those you cared about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: "And there was finally peace."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It had a nice ring to it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And there was finally peace."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Narrator), `[436]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It had a nice ring to it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "1958|Porte Drazon|A New Era"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Continuation","R_Continuation_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "1958|Porte Drazon|A New Era"*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...partying with your old rich friends."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator), `[279]` (Narrator), `[467]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: "...guided your granddaughter and new son with wisdom and ..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: "...balanced your grandfatherly duties with personal time."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player_Romus: "...dedicated yourself to raising your son wisely."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to focus on yourself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Narrator), `[367]` (Narrator), `[371]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[310]`
Mówca: **Narrator**
> "At long last, Rumburg and Sordland reached a ceasefire, leading to a lasting peace. 

The years had seen much loss, often for reasons that now seemed trivial. But the burden of these events was no longer yours to bear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Player_Romus: "You ached to feel important again."*)
  - -> `[313]` (*Player_Romus: "It felt good to be off the hook."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "War, war never changes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You worried about the future."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It felt good to be off the hook."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[450]` (Narrator), `[456]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a history book from your father's old collection."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Engrossed, you delved into..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "Engrossed, you delved into..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: "...the teachings of Prophet Hu, the founder of Zaranism."*)
  - -> `[292]` (*Player_Romus: "...Miraclism theories and the principles of conservatism."*)
  - -> `[293]` (*Player_Romus: "...totalism and the concept of enforced efficient change."*)
  - -> `[317]` (*Player_Romus: "...the immediatist movement, studying their drive for swi..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a political thesis a friend had entrusted you to review."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the immediatist movement, studying their drive for swift change."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "Time unfolded as you pursued this newfound passion for kn..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the healing effects of humor in society."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[287]` (Narrator), `[691]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Though your paper resonated with those who knew you best,..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player_Romus: "...the healing effects of humor in society."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC...."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "In it, your daughter expressed her gratitude for everythi..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[325]`
Mówca: **Narrator**
> "Under Sotelato’s leadership, the revolutionary government solidified, elevating him to a Prime Minister with tangible authority. 

Despite his ascendancy, factions were getting more extreme."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: "Purges against the nobility began."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Purges against the nobility began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true"*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then, a loud bang."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator), `[551]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Jump to: [Jump from Kingdom Dissolves to Death]"*)

### Węzeł `[328]`
Mówca: **Narrator**
> "You decamped to one of your family guest houses near Porte Drazon.

After a few weeks in isolation, you couldn't take it anymore. You put on a disguise and went into the Old Town to get some air.

Suddenly, out of nowhere, you heard a shout. "YOU MONSTER! YOU TOOK HER AWAY FROM ME!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player_Romus: "Then, a loud bang."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You took her advice."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Narrator), `[591]` (Narrator), `[630]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase")"*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In spite of her warnings, you chose to stay."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Narrator), `[630]` (Narrator), `[573]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Abdication_Speech == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "As Lucita Azaro ascended the throne as interim queen, you..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "As Lucita Azaro ascended the throne as interim queen, you..."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "As Lucita Azaro ascended the throne as interim queen, you stood by her side as King Consort. 

In her first address, she acknowledged your past contributions with graciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: "Long live the new Queen."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Ascending monarch Hubertus Toras faced skepticism beyond ..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Ascending monarch Hubertus Toras faced skepticism beyond ..."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "Ascending monarch Hubertus Toras faced skepticism beyond Valenqiris, evidenced by the subdued response to his coronation. 

During his first address, he devoted a considerable time to lauding your tenure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "Long live the new King."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "King Rico Toras infused a newfound sense of nationalism a..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "King Rico Toras infused a newfound sense of nationalism a..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "King Rico Toras infused a newfound sense of nationalism and monarchism in Rizia. 

Notably, he made no mention of you in his coronation address."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "Long live the new King."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "You watched your successor's crowning from seclusion. Death threats had begun arriving shortly after your abdication, and security advised you to keep a low profile.

You and your mother absconded to a family estate on the outskirts of Porte Drazon, waiting for the news that you were safe at last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Manus == true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "The news of your grandchild-to-be -- and the new heir to ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "She and Manus visited Palas Rezna to celebrate. It was a ..."*)

### Węzeł `[347]`
Mówca: **Narrator**
> "She and Manus visited Palas Rezna to celebrate. It was a time of joy, a gathering of generations.

Then, just a week later, the Queen herself went into labor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: "Rizia's new prince was born."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: "...tried not to make the same mistakes you did with Vina."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried not to make the same mistakes you did with Vina."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[352]`
**[WYBÓR GRACZA: "1976|Porte Drazon|Long Live The King"]** — Mówca: **Narrator**
> "You lived out the rest of your days as King Emeritus of Rizia, commanding respect but little authority.

The day your son came of age, the golden Toras crown was placed upon his head.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Player_Romus), `[234]` (Player_Romus), `[351]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: "...did not envy him."*)
  - -> `[354]` (*Player_Romus: "...wished him the best of luck."*)
  - -> `[355]` (*Player_Romus: "...were reassured by the knowledge that the reign of Hous..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not envy him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished him the best of luck."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were reassured by the knowledge that the reign of House Toras would continue -- with or without you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[356]`
Mówca: **Narrator**
> "You decamped to one of your family guest houses near Porte Drazon and waited for the air to clear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: "Days passed in uncertainty."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Security threats diminished`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Security threats diminished]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "Security threats diminished"*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Days passed in uncertainty."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "Jump to: [Security threats diminished]"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == true"*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == true)"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player_Romus: "...your heartache from Vina's death diminished, though it..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vin..."*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...your heartache from Vina's death diminished, though it never truly went away."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDL..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)

### Węzeł `[367]`
Mówca: **Narrator**
> "A year later, Vina and Manus visited, bringing a delightful surprise – their baby daughter Lena, named after her grandmother.

In that moment of familial joy, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[309]` (*Player_Romus: "...decided to focus on yourself."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Vina == true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "Vina, freed of the burden of carrying the Toras lineage forward, filed for divorce against Rico.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[309]` (*Player_Romus: "...decided to focus on yourself."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pa_abdication1")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pa_abdication1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Vina == true"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_newgovernment")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_newgovernment");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "The first ever general election in Rizia was nothing shor..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_continuedreign1")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_continuedreign1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Lucita == true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_letter")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_letter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: "Then democracy arrived in the kingdom."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_princebirth")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_princebirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "The birth of Queen Lucita's son {RiziaDLCText.KingsSon} s..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "1976|Porte Drazon|Long Live The King"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_palesvisit")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_palesvisit");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_plane")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: "And thus your story ended."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_princebirth")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_princebirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "After a long, intense wait, the moment arrived. Late at n..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_burning")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_burning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "A chilling announcement halted the continent: a devastati..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "1966|Rizia|An Old Man"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_continuedreign5")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_continuedreign5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "At long last, Rumburg and Sordland reached a ceasefire, l..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_letter")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_letter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player_Romus: "...a letter from Vina."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_relaxed")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_continuedreign1")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_continuedreign1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Outcome_NoPeace_KeepFighting == true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suitcase")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatD..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_revolution")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_revolution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Continuation", "R_Continuation_Loop");"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Vina's whereabouts remained a mystery.  You wondered if y..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == false"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: "...partying with your old rich friends."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[399]`
Mówca: **Narrator**
> "Vina visited you often. Now that you were no longer king, your bond felt stronger than ever.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: "...balanced your grandfatherly duties with personal time."*)
  - -> `[309]` (*Player_Romus: "...decided to focus on yourself."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Player_Romus: "...threw yourself into raising your son."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...threw yourself into raising your son."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[121]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...spent all your spare time trying to track her down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "In it, your daughter expressed her gratitude for the way ..."*)

### Węzeł `[408]`
Mówca: **Narrator**
> "With stiff formality, she informed you she had been living in Kyrute under an assumed name.

After a year or so, she had tracked down Manus Sazon. The two of them now had a daughter, named after her late grandmother Lena.

She wished you the best.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: "...never answered."*)
  - -> `[430]` (*Player_Romus: "...wrote back, apologizing for everything you'd put her t..."*)
  - -> `[431]` (*Player_Romus: "...burned the letter, knowing your daughter's family woul..."*)

### Węzeł `[409]`
Mówca: **Narrator**
> "In it, your daughter expressed her gratitude for everything you'd taught her.

She enclosed a portrait that Lena had drawn of you in art class."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: "A crown was on your head."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A crown was on your head."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a letter from Vina."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "As you flipped through the typewritten pages, a spark rei..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed..."*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Complet..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "As you flipped through the typewritten pages, a spark rei..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_RomusTorasUniversity_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Narrator: "As you flipped through the typewritten pages, a spark rei..."*)

### Węzeł `[418]`
Mówca: **Narrator**
> "As you flipped through the typewritten pages, a spark reignited within you for politics. 

Motivated, you resolved to pen your own thesis, asking the professors at Romus Toras University for guidance.

As a scholar, you focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player_Romus: "...the wealth disparities in Rizia and the societal issue..."*)
  - -> `[288]` (*Player_Romus: "...the influence of the spiritual will in human societies."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "After the war ended, she had finally been allowed to leave Pales. 

She was on her way back to Rizia.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: "...welcomed her with open arms."*)
  - -> `[424]` (*Player_Romus: "...urged her to go elsewhere, knowing she'd never truly b..."*)
  - -> `[425]` (*Player_Romus: "...apologized for the way everything had turned out."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "After the war ended, she had finally been allowed to leav..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...welcomed her with open arms."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...urged her to go elsewhere, knowing she'd never truly be safe at home."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...apologized for the way everything had turned out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_..."*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manu..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "With stiff formality, she informed you she had been livin..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Narrator: "With stiff formality, she informed you she had been livin..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...never answered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Narrator), `[432]` (Narrator), `[690]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wrote back, apologizing for everything you'd put her through."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Narrator), `[432]` (Narrator), `[690]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "Eventually, you and Vina struck up a correspondence. You ..."*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...burned the letter, knowing your daughter's family would be safer that way."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[408]` (Narrator), `[432]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "As time marched on, you aged with the wisdom and contentm..."*)

### Węzeł `[432]`
Mówca: **Narrator**
> "With stiff formality, she informed you she had been living in Kyrute under an assumed name.

She had married a commoner who knew nothing of her royal identity. The two of them now had a daughter, named after her late grandmother Lena. 

She wished you the best.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: "...never answered."*)
  - -> `[430]` (*Player_Romus: "...wrote back, apologizing for everything you'd put her t..."*)
  - -> `[431]` (*Player_Romus: "...burned the letter, knowing your daughter's family woul..."*)

### Węzeł `[433]`
Mówca: **Narrator**
> "In it, your daughter expressed her gratitude for the way you had raised her.

She enclosed an old drawing she'd made as a child: you, her and Lena, with big golden crowns on your heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player_Romus: "You had it framed."*)
  - -> `[435]` (*Player_Romus: "You couldn't bear to look at it."*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had it framed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't bear to look at it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[436]`
Mówca: **Narrator**
> "Eventually, you and Vina struck up a correspondence. You felt sorrow for all the years you'd missed, but gratitude that your daughter was back in your life.

As time marched on, you aged with the wisdom and contentment your choices brought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: "And there was finally peace."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CoupWarning_Destination_Rumburg = false;
RiziaDLC.CoupWarning_Destination_Kyrute = false;
RiziaDLC.Epilogue_ExileTogether_Estela = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.CoupWarning_Destination_Rumburg"] = false;
Variable["RiziaDLC.CoupWarning_Destination_Kyrute"] = false;
Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: "...to accept her offer and move to the province."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Player_Romus: "...to accept her offer and move to the Grand Duchy."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to accept her offer and move to the Grand Duchy."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator), `[85]` (Narrator), `[472]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_palesvisit")"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "1958|Pales|Court Life"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[445]`
**[WYBÓR GRACZA: "1958|Pales|Court Life"]** — Mówca: **Narrator**
> "You, your mother and Pabel were given an exquisitely lavish set of rooms at the castle with Axel, Vina and the rest of the royal household.

It felt like the luxury of the old days, and spending time around Vina felt good. 

Axel came to you to ask for a favor. Your presence was requested at a party where Arcasian diplomats would be in attendance."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Player_Romus), `[441]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: "You accepted."*)
  - -> `[54]` (*Player_Romus: "You rejected."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Narrator: "1958|Pales|Court Life"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "1958|Pales|Court Life"*)

### Węzeł `[449]`
**[WYBÓR GRACZA: "1958|Pales|Court Life"]** — Mówca: **Narrator**
> "You and your mother were given an exquisitely lavish set of rooms at the castle with Axel, Vina and the rest of the royal household.

It felt like the luxury of the old days, and spending time around Vina felt good. 

Axel came to you to ask for a favor. Your presence was requested at a party where Arcasian diplomats would be in attendance."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Player_Romus), `[441]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: "You accepted."*)
  - -> `[54]` (*Player_Romus: "You rejected."*)

### Węzeł `[450]`
Mówca: **Narrator**
> "At long last, Rumburg and Sordland reached a ceasefire, though your former sister-in-law's kingdom had suffered heavy losses.

The years had seen much loss, often for reasons that now seemed trivial. But the burden of these events was no longer yours to bear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Player_Romus: "You ached to feel important again."*)
  - -> `[313]` (*Player_Romus: "It felt good to be off the hook."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_continuedreign5")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_continuedreign5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Narrator: "At long last, Rumburg and Sordland reached a ceasefire, t..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_continuedreign5")"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_continuedreign5")"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_continuedreign5")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_continuedreign5");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "At long last, Rumburg and Sordland reached a ceasefire, w..."*)

### Węzeł `[456]`
Mówca: **Narrator**
> "At long last, Rumburg and Sordland reached a ceasefire, with your former sister-in-law's kingdom claiming a decisive victory.

The years had seen much loss, often for reasons that now seemed trivial. But the burden of these events was no longer yours to bear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Player_Romus: "You ached to feel important again."*)
  - -> `[313]` (*Player_Romus: "It felt good to be off the hook."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_Z..."*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  and  Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "Your mother, feeling homesick, told you she wanted to spe..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  and  Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[460]`
Mówca: **Narrator**
> "Your mother, feeling homesick, told you she wanted to spend her last years in her old village in Zille.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: "...immersing yourself in the local culture."*)
  - -> `[281]` (*Player_Romus: "...pursuing hobbies and self-growth."*)
  - -> `[282]` (*Player_Romus: "...partaking in community social work."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "Your mother, feeling homesick, told you she wanted to spe..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence == true"*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Independence == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Independence == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Independence == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Independence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "Your mother, feeling homesick, petitioned the government ..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Independence == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Independence"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Narrator: "Your mother, feeling homesick, petitioned the Wehzek gove..."*)

### Węzeł `[467]`
Mówca: **Narrator**
> "Your mother, feeling homesick, petitioned the government of {RiziaDLCText.IndependentZille} to allow her to spend her remaining years in her old village.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: "...immersing yourself in the local culture."*)
  - -> `[281]` (*Player_Romus: "...pursuing hobbies and self-growth."*)
  - -> `[282]` (*Player_Romus: "...partaking in community social work."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[468]`
Mówca: **Narrator**
> "Your mother, feeling homesick, petitioned the Wehzek government to allow her to spend her remaining years in her old village in Zille.

You saw her off, promising to visit as often as you could.

Your focus turned to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: "...immersing yourself in the local culture."*)
  - -> `[281]` (*Player_Romus: "...pursuing hobbies and self-growth."*)
  - -> `[282]` (*Player_Romus: "...partaking in community social work."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Cou..."*)
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_C..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Vina wasted no time visiting. She recounted how she and A..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true"*)

### Węzeł `[472]`
Mówca: **Narrator**
> "Vina wasted no time visiting. She recounted how she and Axel had spent the days following the revolution with their ears glued to the radio, anxiously waiting for news of your survival.

Meanwhile, they had negotiated a tenuous deal with the Sotelato government. Pales and Rizia were to stay on amicable terms, their trade agreements untouched.

She extended an invitation for you to join her in the Grand Duchy.

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[51]` (*Player_Romus: "...to remain in Rizia, requesting for her to visit you soon."*)

### Węzeł `[473]`
Mówca: **Narrator**
> "One day, you opened your morning paper and saw the headlines. Queen Lucita had given birth to an heir, {RiziaDLCText.KingsSon}. Your son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_princebirth")"*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You sent her a letter of congratulations."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Narrator: "The Queen didn't respond to your letter. You had no way o..."*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You begged her to be able to visit your child."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "The Queen sent her regrets, telling you she wanted the pr..."*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You ignored the news."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[477]`
Mówca: **Narrator**
> "The Queen sent her regrets, telling you she wanted the prince to grow up without your influence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player_Romus: "You wondered how it came to this."*)
  - -> `[480]` (*Player_Romus: "You tried to move on."*)

### Węzeł `[478]`
Mówca: **Narrator**
> "The Queen didn't respond to your letter. You had no way of knowing if she even received it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player_Romus: "You wondered how it came to this."*)
  - -> `[480]` (*Player_Romus: "You tried to move on."*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wondered how it came to this."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Narrator), `[478]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to move on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Narrator), `[478]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_princebirth")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_princebirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: "You sent her a letter of congratulations."*)
  - -> `[475]` (*Player_Romus: "You begged her to be able to visit your child."*)
  - -> `[476]` (*Player_Romus: "You ignored the news."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "One day, you opened your morning paper and saw the headli..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Coup_Leader_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true && RiziaDLC.Turn08_Z..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_P..."*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "He explained to you that the new Toras regime had re-crim..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "He explained to you that the new Toras regime had re-criminalized homosexuality almost immediately. 

As part of your clemency, you and he had received a special dispensation to be together. But you would still have to keep a low profile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Player_Romus: "You cursed your family."*)
  - -> `[491]` (*Player_Romus: "It was better than living in fear."*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You cursed your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was better than living in fear."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true && RiziaDLC.Re..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true"*)
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true)"*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Narrator: "1958|Topes|Seaside Life"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "1958|Topes|Seaside Life"*)

### Węzeł `[495]`
**[WYBÓR GRACZA: "1958|Topes|Seaside Life"]** — Mówca: **Narrator**
> "Though reluctant to move into the heart of Toras territory, Pabel eventually agreed with the plan.

You found a delightful house with a stunning sea view, nestled near historical landmarks.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: "Managed the local tourism center, occasionally guiding."*)
  - -> `[256]` (*Player_Romus: "Took up fishing as a pastime."*)
  - -> `[259]` (*Player_Romus: "Relaxed and enjoyed your new downtime."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Exile_HugoSendsToExile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_E..."*)
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Exile_HugoSendsToExile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Exile_HugoSendsToExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Narrator: "1958|Iza|City Life"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Epilogue_Exile_HugoSendsToExile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Epilogue_Exile_HugoSendsToExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "1958|Iza|City Life"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: "...decided to try your hand at stand-up comedy."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[502]`
Mówca: **Narrator**
> "After serving your month-long sentence, you emerged from Iza City Prison to a different world. New monuments had risen, and the currency circulated without the familiar imprint of your face. 

As you stepped beyond the prison gates, there awaited..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to relax, but couldn't stop following the news."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[262]` (Narrator), `[263]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA: "1958|Iza|City Life"]** — Mówca: **Narrator**
> "Pabel was excited to move to the Brenas capital. It was the one place in Rizia where an underground gay scene still thrived, despite the government's ban.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: "...started writing poetry and joined art circles."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[261]` (*Player_Romus: "...reveled in your sudden free time."*)
  - -> `[503]` (*Player_Romus: "...tried to relax, but couldn't stop following the news."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Months passed in Pales, and the Grand Duchy, under Vina a..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "A year later, Vina and Axel visited, bringing a delightfu..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "A year later, Vina and Manus visited, bringing a delightf..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Birthday_Adarfo_Usurped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaD..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Birthday_Adarfo_Usurped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Narrator: "Your mother reminded you that she'd been putting aside fu..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Birthday_Adarfo_Usurped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Narrator: "Your mother reminded you that she'd been putting aside fu..."*)

### Węzeł `[511]`
Mówca: **Narrator**
> "Your mother reminded you that she'd been putting aside funds for a beachside villa in Kyrute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: "You left as soon as you could."*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You left as soon as you could."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[511]` (Narrator), `[596]` (Narrator), `[638]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Exile_Rumburg = false; RiziaDLC.Epilogu..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == false"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == false)"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened == false"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FuneralHappened == false)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_letter")"*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FuneralHappened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.Reform_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Co..."*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.Reform_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true)  and  Variable["RiziaDLC.Reform_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Cou..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Azaro == true || RiziaDLC.Ending_Coup_Reform == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Toras == true) && RiziaDLC.Reform_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true  or  Variable["RiziaDLC.Ending_Coup_Reform"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true)  and  Variable["RiziaDLC.Reform_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Vina wasted no time visiting. Life in Pales with Axel was..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Vina == true"*)

### Węzeł `[525]`
Mówca: **Narrator**
> "Vina wasted no time visiting. Life in Pales with Axel was flourishing, she said. Now that she had been crowned queen, talk of reunification was flowing once more. She extended an invitation to join her family and start anew together. 

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Vina == true"*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Vina == true)"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "Vina wasted no time visiting. Life in Pales with Axel was..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Vina wasted no time visiting. Life in Pales with Axel was..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Abdication_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Abdication_Speech == true"*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_Abdication_Speech == true)"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Abdication_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "You decamped to one of your family guest houses near Port..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_Abdication_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Abdication_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == false && RiziaDLC.Country_Qu..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Narrator: "Vina rarely visited you. Now that you were no longer king..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "Vina visited you often. Now that you were no longer king,..."*)

### Węzeł `[535]`
Mówca: **Narrator**
> "Vina rarely visited you. Now that you were no longer king, your bond felt weaker than ever.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: "...decided to focus on yourself."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed == true"*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Executed == true)"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "In the following days, the revolutionaries seized all gov..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true"*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == true)"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Narrator: "In the following days, the revolutionaries seized all gov..."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes..."*)

### Węzeł `[542]`
Mówca: **Narrator**
> "In the following days, Adarfo and his revolutionaries seized all governmental institutions in Porte Drazon and declared the end of the monarchy.

He praised your peaceful abdication as a defining moment in history."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Player_Romus: "The Kingdom was no more."*)

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The Kingdom was no more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[542]` (Narrator), `[544]` (Narrator), `[562]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Sotelato");"*)

### Węzeł `[544]`
Mówca: **Narrator**
> "In the following days, the revolutionaries seized all governmental institutions in Porte Drazon and released Adarfo Sotelato from prison. 

After taking the leadership of the movement, he declared the official end of the monarchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Player_Romus: "The Kingdom was no more."*)

### Węzeł `[545]`
Mówca: **Narrator**
> "In the following days, the revolutionaries seized all governmental institutions in Porte Drazon and declared the official end of the monarchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player_Romus: "The Kingdom was no more."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The Kingdom was no more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[545]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Narrator: "Without a clear leadership, the revolutionary government ..."*)

### Węzeł `[547]`
Mówca: **Narrator**
> "Without a clear leadership, the revolutionary government succumbed to infighting. 

The factions were getting more extreme."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Player_Romus: "Purges against the nobility began."*)

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Purges against the nobility began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[547]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "Amid this uncertainty, your mother implored you to flee, ..."*)

### Węzeł `[549]`
Mówca: **Narrator**
> "Amid this uncertainty, your mother implored you to flee, fearing for your safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player_Romus: "In spite of her warnings, you chose to stay."*)
  - -> `[329]` (*Player_Romus: "You took her advice."*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In spite of her warnings, you chose to stay."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Narrator: "You decamped to one of your family guest houses near Port..."*)

### Węzeł `[551]`
Mówca: **Narrator**
> "You decamped to one of your family guest houses near Porte Drazon.

After a few weeks in isolation, you couldn't take it anymore. You put on a disguise and went into the Old Town to get some air.

Suddenly, out of nowhere, you heard a shout: "We finally found you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player_Romus: "Then, a loud bang."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `JumpFromPrison`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Stepping out of the Citadel, the sight of new monuments a..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_KingdomDissolves_Revolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_KingdomDissolves_Revolution == true"*)
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_KingdomDissolves_Revolution == true)"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_KingdomDissolves_Revolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_KingdomDissolves_Revolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "Jump to: [Kingdom Dissolves Hub]"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_KingdomDissolves_Revolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_KingdomDissolves_Revolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Abdication_Speech == true"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Kingdom Dissolves Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Kingdom Dissolves Hub"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true"*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Revolution == true)"*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "People were cheering with a magnitude you had never seen ..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Revolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Narrator: "People from all walks of life were applauding, crying, hu..."*)

### Węzeł `[560]`
Mówca: **Narrator**
> "People from all walks of life were applauding, crying, hugging each other.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: "...thought that perhaps this was the best possible outcome."*)
  - -> `[11]` (*Player_Romus: "...wondered how your days would be from now on."*)
  - -> `[561]` (*Player_Romus: "...wished you could partake in their joy with them."*)

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished you could partake in their joy with them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The Rizian flag atop the palace unfurled strongly with th..."*)

### Węzeł `[562]`
Mówca: **Narrator**
> "In the following days, Adarfo and his revolutionaries seized all governmental institutions in Porte Drazon and declared the end of the monarchy.

They arrested the members of the RNC and started preparing a new constitution with the help of a revolutionary committee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Player_Romus: "The Kingdom was no more."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes..."*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatD..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "In the following days, Adarfo and his revolutionaries sei..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adar..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adarfo_AbdicationPath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adar..."*)
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Ad..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adarfo_AbdicationPath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  and  Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Narrator: "In the following days, Adarfo and his revolutionaries sei..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Adarfo_Usurped == true && RiziaDLC.Adarfo_AbdicationPath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  and  Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "In the following days, Adarfo and his revolutionaries sei..."*)

### Węzeł `[569]`
Mówca: **Narrator**
> "In the following days, Adarfo and his revolutionaries seized all governmental institutions in Porte Drazon and declared the end of the monarchy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Player_Romus: "The Kingdom was no more."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_FinalDecision_Abdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_FinalDecision_Abdicate == true"*)
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_FinalDecision_Abdicate == true)"*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_FinalDecision_Abdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Narrator: "Sotelato held back the hardline revolutionaries, shieldin..."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_FinalDecision_Abdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)

### Węzeł `[573]`
Mówca: **Narrator**
> "In a surprising act of mercy, Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you and Lucita to join her in exile, fearing for your family's safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true || RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatD..."*)
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Na..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true || RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.NatDes_FinalDecision_Abdicate == true || RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.NatDes_FinalDecision_Abdicate"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true"*)
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Adarfo_Usurped == true)"*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Adarfo_Usurped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_FinalDecision_Abdicate == true"*)

### Węzeł `[580]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother and Vina were released. 

On seeing them, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: "...begged for forgiveness."*)
  - -> `[585]` (*Player_Romus: "...cried with relief."*)
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[590]` (*Player_Romus: "...wondered if your family would ever be truly safe."*)
  - -> `[622]` (*Player_Romus: "...tried to explain your side of the story."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...begged for forgiveness."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[580]` (Narrator), `[592]` (Narrator), `[621]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGath..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...cried with relief."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[580]` (Narrator), `[592]` (Narrator), `[621]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGath..."*)

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...missed Lucita more than ever."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Kontekst wejściowy (poprzednik):** `[580]` (Narrator), `[592]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGath..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Player_Romus: "...missed Lucita more than ever."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wondered if your family would ever be truly safe."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[580]` (Narrator), `[592]` (Narrator), `[621]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGath..."*)

### Węzeł `[591]`
Mówca: **Narrator**
> "Estela still didn't understand why you had collaborated with the revolutionaries behind her back. It would take time to heal the mistrust between you.

But for now, she feared for your life above all else. She urged you to flee the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: "In spite of her warnings, you chose to stay."*)
  - -> `[329]` (*Player_Romus: "You took her advice."*)

### Węzeł `[592]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother was released. 

On seeing her, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: "...begged for forgiveness."*)
  - -> `[585]` (*Player_Romus: "...cried with relief."*)
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[590]` (*Player_Romus: "...wondered if your family would ever be truly safe."*)
  - -> `[622]` (*Player_Romus: "...tried to explain your side of the story."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)"*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)

### Węzeł `[596]`
Mówca: **Narrator**
> "Estela was staying at a hotel in Kyrute. She told you that she had enough funds squirreled away to buy a beachside villa in the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: "You left as soon as you could."*)

### Węzeł `[597]`
Mówca: **Narrator**
> "Estela and Vina were staying at a hotel in Kyrute. Your mother told you that she had enough funds squirreled away to buy a beachside villa in the area. 

On the other hand, Queen Beatrice had offered you and your family a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: "Rumburg sounded nice."*)
  - -> `[175]` (*Player_Romus: "Kyrute was the safest option."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Manus == true"*)
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Epilogue_PrimeMinister_Manus == true)"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Player_Romus: "Then democracy arrived in the kingdom."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Epilogue_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_PrimeMinister_Adarfo == true"*)

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then democracy arrived in the kingdom."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Epilogue_PrimeMinister_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[343]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_newgovernment")"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_newgovernment")`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_newgovernment");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Narrator: "The first ever general election in Rizia was nothing shor..."*)

### Węzeł `[603]`
Mówca: **Narrator**
> "The first ever general election in Rizia was nothing short of a spectacle. With an impressive 70% turnout, the people demonstrated their hunger for change and voted overwhelmingly in favor of the RPP.

Manus Sazon promoted new laws aimed at raising living standards and positioning Rizia at the forefront of global innovation.

In his inaugural speech, he hailed a new era while praising the Royal Family and its legacy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: "...felt a twinge of obsolescence."*)
  - -> `[186]` (*Player_Romus: "...wrote him a letter of congratulations."*)
  - -> `[184]` (*Player_Romus: "...didn't care and just wanted to move on."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true"*)
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Adarfo_Usurped == true)"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Narrator: "In the meantime, Vina had gone back to Pales.  She and Ax..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Adarfo_Usurped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Narrator: "Vina wasted no time visiting. She recounted how she and A..."*)

### Węzeł `[607]`
Mówca: **Narrator**
> "In the meantime, Vina had gone back to Pales.

She and Axel had negotiated a tenuous deal with the Sotelato government. Pales and Rizia were to stay on amicable terms, their trade agreements untouched.

Despite everything that had happened, they extended an invitation for you to join them.

You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[51]` (*Player_Romus: "...to remain in Rizia, requesting for her to visit you soon."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Execut..."*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Exec..."*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Narrator: "In a surprising act of mercy, Sotelato held back the hard..."*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[611]`
Mówca: **Narrator**
> "In a surprising act of mercy, Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you and Pabel to join her in exile, fearing for your family's safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[612]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you flee the country, fearing for your safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: "In spite of her warnings, you chose to stay."*)
  - -> `[329]` (*Player_Romus: "You took her advice."*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Narrator: "In a surprising act of mercy, Sotelato held back the hard..."*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "In a surprising act of mercy, Sotelato held back the hard..."*)

### Węzeł `[617]`
Mówca: **Narrator**
> "In a surprising act of mercy, Sotelato held back the hardline revolutionaries, shielding you from extremist threats. 

Amid this uncertainty, your mother implored you to join her in exile, fearing for your family's safety in a country teetering on the edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Narrator: "Sotelato held back the hardline revolutionaries, shieldin..."*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "Sotelato held back the hardline revolutionaries, shieldin..."*)

### Węzeł `[621]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother, Vina and Pabel were released. 

On seeing them, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: "...begged for forgiveness."*)
  - -> `[585]` (*Player_Romus: "...cried with relief."*)
  - -> `[590]` (*Player_Romus: "...wondered if your family would ever be truly safe."*)
  - -> `[622]` (*Player_Romus: "...tried to explain your side of the story."*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to explain your side of the story."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[580]` (Narrator), `[592]` (Narrator), `[621]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGath..."*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[624]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Narrator: "Sotelato held back the hardline revolutionaries, shieldin..."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Narrator: "Sotelato held back the hardline revolutionaries, shieldin..."*)

### Węzeł `[626]`
Mówca: **Narrator**
> "Sotelato held back the hardline revolutionaries, shielding you from the worst of the threats. 

While Hugo and the most prominent noble house members remained in detention, your mother and Pabel were released.

On seeing them, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: "...begged for forgiveness."*)
  - -> `[585]` (*Player_Romus: "...cried with relief."*)
  - -> `[590]` (*Player_Romus: "...wondered if your family would ever be truly safe."*)
  - -> `[622]` (*Player_Romus: "...tried to explain your side of the story."*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGathering_Invited_Vina == false && RiziaDLC.Relations_Pabel_Together == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGath..."*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGa..."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGathering_Invited_Vina == false && RiziaDLC.Relations_Pabel_Together == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false  and  Variable["RiziaDLC.Relations_Pabel_Together"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Narrator: "Estela still didn't understand why you had collaborated w..."*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == false && RiziaDLC.BirthdayGathering_Invited_Vina == false && RiziaDLC.Relations_Pabel_Together == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == false  and  Variable["RiziaDLC.Relations_Pabel_Together"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Narrator: "Your loved ones still didn't understand why you had colla..."*)

### Węzeł `[630]`
Mówca: **Narrator**
> "Your loved ones still didn't understand why you had collaborated with the revolutionaries behind their back. It would take time to heal the mistrust between you.

But for now, Estela feared for your life above all else. She urged you to flee the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: "In spite of her warnings, you chose to stay."*)
  - -> `[329]` (*Player_Romus: "You took her advice."*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true && Rizi..."*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "Estela and Vina were staying at a hotel in Kyrute. Your m..."*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Narrator: "Estela was staying at a hotel in Kyrute. She told you tha..."*)

### Węzeł `[634]`
Mówca: **Narrator**
> "Estela was staying at a hotel in Kyrute. She told you that she had enough funds squirreled away to buy a beachside villa in the area. 

On the other hand, Queen Beatrice had offered you and your family a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: "Rumburg sounded nice."*)
  - -> `[175]` (*Player_Romus: "Kyrute was the safest option."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaD..."*)
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true && Rizi..."*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Narrator: "Estela and Vina were staying at a hotel in Kyrute. Your m..."*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Vina_MarriageDecision_Axel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "Estela was staying at a hotel in Kyrute. She told you tha..."*)

### Węzeł `[638]`
Mówca: **Narrator**
> "Estela and Vina were staying at a hotel in Kyrute. Your mother told you that she had enough funds squirreled away to buy a beachside villa in the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: "You left as soon as you could."*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true"*)
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Revolution == true)"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "Jump to: [Decided In Epilogue Exile Hub]"*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Revolution == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Jump to: [Jump From Kingdom Dissolves]"*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Decided In Epilogue Exile Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: "...felt lucky that you didn't die."*)

### Węzeł `[643]`
Mówca: **Narrator**
> "Your mother reminded you that she'd been putting aside funds for a beachside villa in Kyrute.

Alternately, Queen Beatrice had offered you a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: "Rumburg sounded nice."*)
  - -> `[175]` (*Player_Romus: "Kyrute was the safest option."*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: "...outlandish tales from your Party Prince days."*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...insights gleaned from your time as Rizia's monarch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vin..."*)
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.V..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Player_Romus: "...you swore you'd be a better father the second time aro..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...you swore you'd be a better father the second time around."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true` AND `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Monarch_Vina == true"*)
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Monarch_Vina == true)"*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Monarch_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Monarch_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Monarch_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Monarch_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "Vina, freed of the burden of carrying the Toras lineage f..."*)

### Węzeł `[658]`
Mówca: **Narrator**
> "Queen Vina visited with her new baby daughter, Lena. She looked nothing like Rico, but nobody said anything.

In that moment of familial joy, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[309]` (*Player_Romus: "...decided to focus on yourself."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "Queen Vina visited with her new baby daughter, Lena. She ..."*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDL..."*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true"*)
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true )"*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.LenaTooltip = "Your granddaughter.""*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC...."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.V..."*)
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "Through the grapevine, you heard that Vina, free from the..."*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Narrator: "Through the grapevine, you heard that Vina, free from the..."*)

### Węzeł `[669]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina and Axel had a child now: Lena, named after her grandmother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Player_Romus: "You were happy for her."*)
  - -> `[676]` (*Player_Romus: "Her absence stung."*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Narrator: "Through the grapevine, you heard that Vina and Axel had a..."*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.LenaTooltip = "Your granddaughter."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "Through the grapevine, you heard that Vina and Manus had ..."*)

### Węzeł `[672]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina and Manus had a child now: Lena, named after her grandmother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Player_Romus: "You were happy for her."*)
  - -> `[676]` (*Player_Romus: "Her absence stung."*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[673]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina, free from the burden of carrying the Toras name forward, had filed for divorce from Rico."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Player_Romus: "You were happy for her."*)
  - -> `[676]` (*Player_Romus: "Her absence stung."*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[674]`
Mówca: **Narrator**
> "Through the grapevine, you heard that Vina, free from the burden of carrying the Toras name forward, had embarked on a journey around the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Player_Romus: "You were happy for her."*)
  - -> `[676]` (*Player_Romus: "Her absence stung."*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were happy for her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[669]` (Narrator), `[672]` (Narrator), `[673]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[676]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Her absence stung."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[669]` (Narrator), `[672]` (Narrator), `[673]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_L..."*)
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader..."*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Player_Romus: "You were too wrapped up in fatherhood to care."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were too wrapped up in fatherhood to care."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[669]` (Narrator), `[672]` (Narrator), `[673]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_WorldWar == true"*)

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You ached to feel important again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[450]` (Narrator), `[456]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_relaxed")"*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)

### Węzeł `[685]`
Mówca: **Narrator**
> "In a short note, your daughter expressed her regret for the way things had turned out.

She enclosed a self-portrait Lena had drawn in art class."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Player_Romus: "A crown was on her head."*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vi..."*)
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC...."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Narrator: "In a short note, your daughter expressed her regret for t..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "In a short note, your daughter expressed her regret for t..."*)

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A crown was on her head."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[685]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "Eventually, you and Vina struck up a correspondence. You ..."*)

### Węzeł `[690]`
Mówca: **Narrator**
> "In a short note, your daughter expressed her regret for the way things had turned out.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: "...never answered."*)
  - -> `[430]` (*Player_Romus: "...wrote back, apologizing for everything you'd put her t..."*)

### Węzeł `[691]`
Mówca: **Narrator**
> "As you flipped through the typewritten pages, a spark reignited within you for politics. 

Motivated, you resolved to pen your own thesis, asking the Iza University professors for guidance.

As a scholar, you focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[286]` (*Player_Romus: "...the psychology of warfare."*)
  - -> `[289]` (*Player_Romus: "...the wealth disparities in Rizia and the societal issue..."*)
  - -> `[288]` (*Player_Romus: "...the influence of the spiritual will in human societies."*)

### Węzeł `[692]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A long month passed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "Jump to: [EpilogueIza]"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Sotelato");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "Under Sotelato’s leadership, the revolutionary government..."*)
