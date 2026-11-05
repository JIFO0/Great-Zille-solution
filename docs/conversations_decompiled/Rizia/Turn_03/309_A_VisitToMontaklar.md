# Rizia/Turn 3/A_VisitToMontaklar

- **ID konwersacji:** `309`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/309_A_VisitToMontaklar.md`
- **Liczba węzłów dialogowych:** 683
- **Liczba wyborów gracza:** 173

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Pales_ProWar`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Turn02_Diplomacy_Intention_ATO`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage`
- `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Turn03_Montaklar_TookMap`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies`
- `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage`
- `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind`
- `RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps`
- `RiziaDLCSupport.News_Turn03_RH_Gossip_KingLucita`
- `RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplete`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""It's fine. I always preferred the ocean over mountains, myself.""** | `[8]` **Narrator**: "From here, we could look down in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lucita Azaro**: ""My province has been cut off fr..." |
| `[10]` | **""Spectacular. Why did you bring me here, Duchess Azaro?""** | `[8]` **Narrator**: "From here, we could look down in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucita Azaro**: ""For one, it's been too long sin..." |
| `[11]` | **""I remember it well from my military days.""** | `[8]` **Narrator**: "From here, we could look down in..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[17]` **Lucita Azaro**: ""I've come here as a child, as a..." |
| `[15]` | **""Imagine how this fortress must have looked a thousand years ago.""** | `[8]` **Narrator**: "From here, we could look down in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucita Azaro**: ""Incredible, isn't it?"" |
| `[21]` | **""Is that why you brought me here, Duchess Azaro?""** | `[20]` **Lucita Azaro**: ""It took years for the Azaro and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Lucita Azaro**: ""In part, yes."" |
| `[22]` | **""Nothing means more to me than keeping the favor of House Azaro.""** | `[20]` **Lucita Azaro**: ""It took years for the Azaro and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucita Azaro**: ""It's great to hear you say that."" |
| `[26]` | **""You don't understand. Iza is at a tipping point. The city's fate could determine ..."** | `[633]` **Lucita Azaro**: ""And considering the provincial ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Lucita Azaro**: ""All the more reason to keep the..." |
| `[27]` | **""House Toras takes care of its own. If I do grant special favors to my cousin, tha..."** | `[633]` **Lucita Azaro**: ""And considering the provincial ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[262]` **Lucita Azaro**: ""I beg your pardon, Your Majesty..." |
| `[28]` | **""My family comes first, Duchess. You have to respect that.""** | `[634]` **Lucita Azaro**: ""As long as the provincial polic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Lucita Azaro**: ""I do. But putting more power in..." |
| `[35]` | **"Follow her."** | `[34]` **Narrator**: "Lucita scaled it in a matter of ..." | `(Variable["RiziaDLC.Prologue_Limp"] == true) == false` | *Brak zmian stanu* | `[48]` **Narrator**: "From this side, we could see Cam..." |
| `[36]` | **""I'll stay down here for now. What can you see?""** | `[34]` **Narrator**: "Lucita scaled it in a matter of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Lucita Azaro**: ""Don't you remember? Camp Domus ..."<br>`[41]` **Lucita Azaro**: ""Camp Domus is just downhill fro..." |
| `[59]` | **""I can't believe they're still using that system.""** | `[58]` **Narrator**: "The soldiers snapped into a V-sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lucita Azaro**: ""Comms can get jammed, orders mi..." |
| `[60]` | **""Very impressive.""** | `[58]` **Narrator**: "The soldiers snapped into a V-sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucita Azaro**: ""Still the best-trained soldiers..." |
| `[63]` | **""A little archaic, isn't it?""** | `[62]` **Narrator**: "The soldiers snapped into a V-sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucita Azaro**: ""Comms can get jammed, orders mi..." |
| `[64]` | **""Very impressive.""** | `[62]` **Narrator**: "The soldiers snapped into a V-sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lucita Azaro**: ""The best-trained soldiers in So..." |
| `[65]` | **""The woman on the right side was a little slow.""** | `[58]` **Narrator**: "The soldiers snapped into a V-sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucita Azaro**: ""These are new recruits. She'll ..." |
| `[68]` | **""How did you know that?""** | `[62]` **Narrator**: "The soldiers snapped into a V-sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lucita Azaro**: ""It's an ancient system from the..." |
| `[70]` | **""I can't believe they're still using that system.""** | `[46]` **Lucita Azaro**: ""Long, short, short, long... tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucita Azaro**: ""Comms can get jammed, orders mi..." |
| `[71]` | **""How many men are down there?""** | `[45]` **Lucita Azaro**: ""Long, short, short, long... tha..."<br>`[46]` **Lucita Azaro**: ""Long, short, short, long... tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucita Azaro**: ""At least 50. And five women, fr..." |
| `[72]` | **""Sounds like one of them is just a little bit out of step.""** | `[46]` **Lucita Azaro**: ""Long, short, short, long... tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lucita Azaro**: ""These are new recruits. They'll..." |
| `[79]` | **""How did you know that?""** | `[45]` **Lucita Azaro**: ""Long, short, short, long... tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucita Azaro**: ""It's an ancient system from the..." |
| `[81]` | **""A little archaic, isn't it?""** | `[45]` **Lucita Azaro**: ""Long, short, short, long... tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucita Azaro**: ""Comms can get jammed, orders mi..." |
| `[89]` | **"Catch her."** | `[85]` **Narrator**: "She began falling backwards towa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "As she landed in my arms, my wea..."<br>`[93]` **Narrator**: "She landed in my arms." |
| `[90]` | **"Don't catch her."** | `[85]` **Narrator**: "She began falling backwards towa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "She brushed herself off and turn..." |
| `[94]` | **"Get up."** | `[92]` **Narrator**: "As she landed in my arms, my wea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lucita Azaro**: ""Thank you, Your Majesty. It see..." |
| `[95]` | **"Don't get up."** | `[92]` **Narrator**: "As she landed in my arms, my wea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Narrator**: "Her eyes softened as they met mine."<br>`[317]` **Narrator**: "She quickly pushed away from me ..." |
| `[96]` | **"Put her down."** | `[93]` **Narrator**: "She landed in my arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lucita Azaro**: ""Thank you, Your Majesty. It see..." |
| `[97]` | **"Don't put her down."** | `[93]` **Narrator**: "She landed in my arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Narrator**: "Her eyes softened as they met mine."<br>`[317]` **Narrator**: "She quickly pushed away from me ..." |
| `[104]` | **""I would follow you, but my bum leg won't allow it.""** | `[34]` **Narrator**: "Lucita scaled it in a matter of ..." | `Variable["RiziaDLC.Prologue_Limp"] == true` | *Brak zmian stanu* | `[105]` **Lucita Azaro**: ""I'm afraid I forgot about that,..." |
| `[108]` | **""Very impressive.""** | `[45]` **Lucita Azaro**: ""Long, short, short, long... tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lucita Azaro**: ""The best-trained soldiers in So..." |
| `[115]` | **"Grab her arm."** | `[114]` **Narrator**: "She began falling backwards." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "She looked up at me in surprise,..." |
| `[116]` | **"Do nothing."** | `[114]` **Narrator**: "She began falling backwards." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "She brushed herself off. I saw s..." |
| `[118]` | **"Let go of her."** | `[117]` **Narrator**: "She looked up at me in surprise,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucita Azaro**: ""It seems old habits die hard. T..." |
| `[119]` | **"Don't let go of her."** | `[117]` **Narrator**: "She looked up at me in surprise,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "Her eyes softened as they met mine."<br>`[322]` **Narrator**: "She hurriedly pushed me away and..." |
| `[128]` | **""I don't see why that wouldn't be the case. You and your relatives have sworn feal..."** | `[20]` **Lucita Azaro**: ""It took years for the Azaro and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Lucita Azaro**: ""Of course. But, well..."" |
| `[129]` | **""As long as you keep your family in line, they will.""** | `[20]` **Lucita Azaro**: ""It took years for the Azaro and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Lucita Azaro**: ""You don't need to worry about m..." |
| `[134]` | **""I want to have that relationship with all of my councilors, Duchess. Nobody shoul..."** | `[132]` **Lucita Azaro**: ""I'd like it if you and I had a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Lucita Azaro**: ""Perfect, Your Majesty. Thank you."" |
| `[135]` | **""And what makes you think you deserve that? You've barely been on the council for ..."** | `[132]` **Lucita Azaro**: ""I'd like it if you and I had a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Lucita Azaro**: ""I know. It would be exceedingly..." |
| `[136]` | **""How can we when we barely even know each other?""** | `[132]` **Lucita Azaro**: ""I'd like it if you and I had a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lucita Azaro**: ""A fair point, Your Majesty."" |
| `[140]` | **""Well... why aren't you married? As an Azaro, you should've been paired off the da..."** | `[139]` **Lucita Azaro**: ""You have my permission, then. A..."<br>`[354]` **Lucita Azaro**: ""That depends, Your Majesty. Wha..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == false` | *Brak zmian stanu* | `[146]` **Narrator**: "She grimaced." |
| `[141]` | **""Let's drop the small talk. You brought me here today because you want something.""** | `[139]` **Lucita Azaro**: ""You have my permission, then. A..."<br>`[354]` **Lucita Azaro**: ""That depends, Your Majesty. Wha..." | `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false`<br>`Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true` | *Brak zmian stanu* | `[198]` **Narrator**: "She looked at me with flinty eyes." |
| `[142]` | **""Let's see. Do you have any hobbies?""** | `[139]` **Lucita Azaro**: ""You have my permission, then. A..."<br>`[354]` **Lucita Azaro**: ""That depends, Your Majesty. Wha..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == false` | *Brak zmian stanu* | `[162]` **Lucita Azaro**: ""I've always enjoyed archery, wh..." |
| `[143]` | **""Why did you follow in the Azaro family's footsteps? You could've chosen your own ..."** | `[139]` **Lucita Azaro**: ""You have my permission, then. A..."<br>`[354]` **Lucita Azaro**: ""That depends, Your Majesty. Wha..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == false` | *Brak zmian stanu* | `[144]` **Lucita Azaro**: ""My path was chosen for me after..." |
| `[149]` | **""Who's going to carry on the Azaro legacy, then?""** | `[148]` **Lucita Azaro**: ""By the time I got out, I was co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Narrator**: "She looked away." |
| `[150]` | **""That's ridiculous. A woman like you should be swarmed with suitors.""** | `[148]` **Lucita Azaro**: ""By the time I got out, I was co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "A wry smile formed on her face." |
| `[151]` | **""So you've never known the touch of a man?""** | `[148]` **Lucita Azaro**: ""By the time I got out, I was co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Narrator**: "She raised an eyebrow, then laug..." |
| `[152]` | **""You were what, 28? That's ancient for a woman.""** | `[148]` **Lucita Azaro**: ""By the time I got out, I was co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Narrator**: "She frowned and looked away." |
| `[165]` | **""Who wins?""** | `[163]` **Lucita Azaro**: ""And my father and I used to pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Lucita Azaro**: ""I do, mostly. I've let him win ..." |
| `[166]` | **""Maybe you and I can play someday.""** | `[163]` **Lucita Azaro**: ""And my father and I used to pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "She gave me a taunting look." |
| `[167]` | **""No needlepoint? Calligraphy?""** | `[163]` **Lucita Azaro**: ""And my father and I used to pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Lucita Azaro**: ""You *really* must not know me, ..." |
| `[168]` | **""Chess is a silly game.""** | `[163]` **Lucita Azaro**: ""And my father and I used to pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Lucita Azaro**: ""I beg to differ. If you can win..." |
| `[181]` | **""That's all I wanted to know.""** | `[139]` **Lucita Azaro**: ""You have my permission, then. A..."<br>`[354]` **Lucita Azaro**: ""That depends, Your Majesty. Wha..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true` | *Brak zmian stanu* | `[250]` **Lucita Azaro**: ""I hope your curiosity has been ..." |
| `[191]` | **""Those days are over. We don't have to live in fear of another uprising.""** | `[145]` **Lucita Azaro**: ""Even as a young girl, I knew th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[295]` **Lucita Azaro**: ""We shouldn't fear an uprising, ..." |
| `[192]` | **""The real threat isn't from the commoners. It's from the foreign powers who want t..."** | `[145]` **Lucita Azaro**: ""Even as a young girl, I knew th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Lucita Azaro**: ""Whatever the source of the thre..." |
| `[193]` | **""Your words ring true. I had the exact same thought after my kidnapping.""** | `[145]` **Lucita Azaro**: ""Even as a young girl, I knew th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[610]` **Lucita Azaro**: ""I joined the military so I'd ne..."<br>`[194]` **Lucita Azaro**: ""And you didn't feel the drive t..." |
| `[207]` | **""It's all strategic. Without the Sazons on my side, I won't be able to prevent ano..."** | `[206]` **Lucita Azaro**: ""Sources say you were quite deep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Lucita Azaro**: ""That's what he led you to belie..." |
| `[208]` | **""We were speaking of repairing the bond between our houses. As you yourself said, ..."** | `[206]` **Lucita Azaro**: ""Sources say you were quite deep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Lucita Azaro**: ""The Sazons were never a royal f..." |
| `[209]` | **""We were guests in his province. Refusing to converse would've been a terrible bre..."** | `[206]` **Lucita Azaro**: ""Sources say you were quite deep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Lucita Azaro**: ""As terrible as what his family ..." |
| `[213]` | **""Did those sources fail to tell you I turned him away?""** | `[206]` **Lucita Azaro**: ""Sources say you were quite deep..." | `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true` | *Brak zmian stanu* | `[219]` **Lucita Azaro**: ""I had that impression. But I wa..." |
| `[220]` | **""I want to get closer to Arcasia. It's part of my diplomatic strategy.""** | `[217]` **Lucita Azaro**: ""You know the entire house is st..." | `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true` | *Brak zmian stanu* | `[239]` **Lucita Azaro**: ""I would ask you to reconsider t..." |
| `[221]` | **""I don't know about Manus. He seems different.""** | `[217]` **Lucita Azaro**: ""You know the entire house is st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Lucita Azaro**: ""That's what he wants you to thi..." |
| `[222]` | **""That isn't surprising. Arcasia has eyes and ears everywhere.""** | `[217]` **Lucita Azaro**: ""You know the entire house is st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Lucita Azaro**: ""They and their allies have spen..." |
| `[223]` | **""Well, better Arcasia than United Contana.""** | `[217]` **Lucita Azaro**: ""You know the entire house is st..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0` | *Brak zmian stanu* | `[230]` **Lucita Azaro**: ""Oh, I'm not discounting the thr..." |
| `[240]` | **""Thank you for your advice. Perhaps I'll require your assistance with this in the ..."** | `[227]` **Lucita Azaro**: ""Don't trust the man around your..."<br>`[228]` **Lucita Azaro**: ""No matter what, Your Majesty, I..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false` | *Brak zmian stanu* | `[246]` **Lucita Azaro**: ""I'm just looking out for nation..." |
| `[241]` | **""This is not a matter of national security. You needn't involve yourself in it.""** | `[227]` **Lucita Azaro**: ""Don't trust the man around your..."<br>`[228]` **Lucita Azaro**: ""No matter what, Your Majesty, I..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false` | *Brak zmian stanu* | `[244]` **Lucita Azaro**: ""Isn't it, though? An agent of c..." |
| `[242]` | **""My daughter is allowed to consort with whomever she wants. Surely you understand ..."** | `[227]` **Lucita Azaro**: ""Don't trust the man around your..."<br>`[228]` **Lucita Azaro**: ""No matter what, Your Majesty, I..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucita Azaro**: ""As the woman in charge of this ..." |
| `[243]` | **""I appreciate your concern. But I will deal with Mr. Sazon and his family on my own.""** | `[227]` **Lucita Azaro**: ""Don't trust the man around your..."<br>`[228]` **Lucita Azaro**: ""No matter what, Your Majesty, I..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false` | *Brak zmian stanu* | `[254]` **Lucita Azaro**: ""Well, let me know if you do req..." |
| `[247]` | **""Well, I am nothing if not gracious. Tell me what's on your mind.""** | `[200]` **Lucita Azaro**: ""I know. It would be exceedingly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[249]` | **""I cannot trust you if I don't know you. Tell me more about yourself.""** | `[200]` **Lucita Azaro**: ""I know. It would be exceedingly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Lucita Azaro**: ""About myself?"" |
| `[252]` | **""Go ahead.""** | `[251]` **Lucita Azaro**: ""May I speak freely now?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksM...` | `[253]` **Lucita Azaro**: ""Well, Your Majesty..."" |
| `[266]` | **""No, I'd still rather you didn't.""** | `[251]` **Lucita Azaro**: ""May I speak freely now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Narrator**: "Before she could stop herself, s..." |
| `[267]` | **""I will extend you my trust when you have earned it. That time has not yet come.""** | `[200]` **Lucita Azaro**: ""I know. It would be exceedingly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Lucita Azaro**: ""No?"" |
| `[273]` | **""Do not berate our staff, Duchess Azaro. But yes, I don't want this photograph get..."** | `[271]` **Lucita Azaro**: ""You are to find this photograph..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The guards nodded. One of them s..." |
| `[274]` | **""You heard her. I'm embarrassed at this obvious security lapse. You ought to be as..."** | `[271]` **Lucita Azaro**: ""You are to find this photograph..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The guards nodded. One of them s..." |
| `[275]` | **""Disregard that order, gentlemen. Let the papers do what they will.""** | `[271]` **Lucita Azaro**: ""You are to find this photograph..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_CompromisingPhoto"] = true; Var...` | `[277]` **Narrator**: "Lucita spun around towards me." |
| `[279]` | **""And why not? You yourself said our houses should be more harmonious.""** | `[278]` **Lucita Azaro**: ""Really? I thought you wouldn't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Narrator**: "She gave me a coy smile." |
| `[280]` | **""That's beside the point. I'm not going to participate in censorship of the press.""** | `[278]` **Lucita Azaro**: ""Really? I thought you wouldn't ..." | `Variable["RiziaDLC.LeaningValue_Democratic"] > 0` | *Brak zmian stanu* | `[290]` **Narrator**: "She nodded." |
| `[284]` | **""Being seen with my arms around a gorgeous noblewoman will only benefit my reputat..."** | `[278]` **Lucita Azaro**: ""Really? I thought you wouldn't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Narrator**: "She gave me a coy smile." |
| `[285]` | **""I don't care what the public thinks. The King of Rizia is above such concerns.""** | `[278]` **Lucita Azaro**: ""Really? I thought you wouldn't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Narrator**: "She nodded." |
| `[299]` | **""Arcasia's power is laughable compared to the combined might of the international ..."** | `[217]` **Lucita Azaro**: ""You know the entire house is st..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false` | *Brak zmian stanu* | `[300]` **Lucita Azaro**: ""I... don't know what to say to ..." |
| `[327]` | **""To be continued, Duchess Azaro.""** | `[276]` **Narrator**: "The guards nodded. One of them s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[330]` **Narrator**: "She gave me a coy smile." |
| `[328]` | **""That was close. Wouldn't want anyone to think anything untoward was happening bet..."** | `[276]` **Narrator**: "The guards nodded. One of them s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Lucita Azaro**: ""Certainly not, Your Majesty."" |
| `[333]` | **""Honestly. What do we even pay the Golden Guard for?""** | `[276]` **Narrator**: "The guards nodded. One of them s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Lucita Azaro**: ""You said it, Your Majesty. I di..." |
| `[339]` | **""Consider that request refused, Duchess.""** | `[338]` **Lucita Azaro**: ""All I am requesting is a chance..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Narrator**: "Before she could stop herself, s..." |
| `[340]` | **""That's reasonable enough. Go ahead, then.""** | `[338]` **Lucita Azaro**: ""All I am requesting is a chance..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Lucita Azaro**: ""Well, Your Majesty..."" |
| `[345]` | **""Were you hoping for special treatment?""** | `[344]` **Narrator**: "She was smiling, but I registere..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Lucita Azaro**: ""No, no. That would be unfair to..." |
| `[346]` | **""It's precisely your willingness to speak your mind that makes you such a valuable..."** | `[344]` **Narrator**: "She was smiling, but I registere..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Lucita Azaro**: ""I'm pleased to hear that."" |
| `[348]` | **""I'd like to get to know you better. Tell me about yourself.""** | `[344]` **Narrator**: "She was smiling, but I registere..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Lucita Azaro**: ""About myself?"" |
| `[372]` | **""While we're at it, is there anything you want to know about me?""** | `[250]` **Lucita Azaro**: ""I hope your curiosity has been ..." | `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false` | *Brak zmian stanu* | `[375]` **Lucita Azaro**: ""Now that you mention it..."" |
| `[373]` | **""It has. Now, what did you want to say to me?""** | `[250]` **Lucita Azaro**: ""I hope your curiosity has been ..." | `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false` | *Brak zmian stanu* | `[253]` **Lucita Azaro**: ""Well, Your Majesty..."" |
| `[378]` | **""I'm terrified at the idea of loving someone that much again, only to lose them.""** | `[377]` **Lucita Azaro**: ""Turnabout is fair play, Your Ma..." | `Variable["RiziaDLC.Prologue_LovedWife"]` | *Brak zmian stanu* | `[388]` **Lucita Azaro**: ""Falling in love is like heading..." |
| `[379]` | **""I was already in one loveless marriage. I'm not about to enter another.""** | `[377]` **Lucita Azaro**: ""Turnabout is fair play, Your Ma..." | `(Variable["RiziaDLC.Prologue_LovedWife"]) == false` | *Brak zmian stanu* | `[387]` **Lucita Azaro**: ""What makes you think it would b..." |
| `[383]` | **""That is a highly inappropriate question. I refuse to answer.""** | `[377]` **Lucita Azaro**: ""Turnabout is fair play, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Narrator**: "Lucita took a step back." |
| `[384]` | **""Romance isn't easy as a royal. You can never tell who truly loves you and who's j..."** | `[377]` **Lucita Azaro**: ""Turnabout is fair play, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[386]` **Lucita Azaro**: ""I understand completely. That's..." |
| `[385]` | **""I'm still looking for a woman who can handle me.""** | `[377]` **Lucita Azaro**: ""Turnabout is fair play, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Lucita Azaro**: ""Ha. All men think they're hard ..." |
| `[396]` | **""I know that now. Next time, I'll be better protected.""** | `[388]` **Lucita Azaro**: ""Falling in love is like heading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[541]` **Lucita Azaro**: ""Tell the Golden Guard to form a..." |
| `[398]` | **""...Royal orbs?""** | `[397]` **Lucita Azaro**: ""Pardon my inappropriateness, Yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[538]` **Narrator**: "She laughed." |
| `[402]` | **""It was a gesture of good faith. I will trust you when you get results.""** | `[365]` **Lucita Azaro**: ""I thought your granting extra f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Lucita Azaro**: ""We will."" |
| `[403]` | **""I trust your capabilities. I'm still deciding whether I trust you, personally.""** | `[365]` **Lucita Azaro**: ""I thought your granting extra f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Lucita Azaro**: ""Well... maybe this will help ch..." |
| `[404]` | **""I was only being pragmatic, Duchess. Zille was bombed. Of course we had to invest..."** | `[365]` **Lucita Azaro**: ""I thought your granting extra f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Lucita Azaro**: ""You had other options, and you ..." |
| `[405]` | **""That had nothing to do with trust. I didn't want to provoke Wehlen so close to th..."** | `[401]` **Lucita Azaro**: ""I suppose your turning down my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Lucita Azaro**: ""Respectfully, Wehlen doesn't se..." |
| `[412]` | **""Yes, perhaps it should have been.""** | `[401]` **Lucita Azaro**: ""I suppose your turning down my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Narrator**: "She folded her arms and didn't s..." |
| `[413]` | **""Enough of this, Duchess. You are on my council to provide guidance, not complaints.""** | `[365]` **Lucita Azaro**: ""I thought your granting extra f..."<br>`[401]` **Lucita Azaro**: ""I suppose your turning down my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Lucita Azaro**: ""That's fair, Your Majesty. My a..." |
| `[420]` | **""Don't take it personally. Titus made a better case.""** | `[401]` **Lucita Azaro**: ""I suppose your turning down my ..." | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[423]` **Lucita Azaro**: ""Right. The man whose only quali..." |
| `[421]` | **""Don't take it personally. I thought both the proposed investigations were a waste..."** | `[401]` **Lucita Azaro**: ""I suppose your turning down my ..." | `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[422]` **Lucita Azaro**: ""May I remind you that the deadl..." |
| `[435]` | **""So they were plotting another attempt on Pales. That's not surprising.""** | `[434]` **Lucita Azaro**: ""Look at the date. 1949."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Lucita Azaro**: ""Had this been attempted, it wou..." |
| `[439]` | **""This would never have worked. Not with the military still weakened from the 1920s.""** | `[434]` **Lucita Azaro**: ""Look at the date. 1949."" | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[445]` **Lucita Azaro**: ""You're absolutely right."" |
| `[440]` | **""This is complete gibberish to me.""** | `[434]` **Lucita Azaro**: ""Look at the date. 1949."" | `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false` | *Brak zmian stanu* | `[446]` **Lucita Azaro**: ""It's a plan to reconquer Pales...." |
| `[441]` | **""Pathetic. The work of two sad, deluded old men.""** | `[434]` **Lucita Azaro**: ""Look at the date. 1949."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Lucita Azaro**: ""Some of these instructions are ..." |
| `[442]` | **""Intriguing. Why didn't my father tell me about this?""** | `[434]` **Lucita Azaro**: ""Look at the date. 1949."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[451]` **Lucita Azaro**: ""He thought you'd inform Duke Re..."<br>`[452]` **Lucita Azaro**: ""It was still a work in progress..." |
| `[454]` | **""How dare you even imply that my father's death was a fortunate occurrence? I shou..."** | `[444]` **Lucita Azaro**: ""All glory to King Valero, but p..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[470]` **Lucita Azaro**: ""I -- I'm so sorry. I never mean..." |
| `[458]` | **""Is it possible that whoever murdered him knew about this plan?""** | `[444]` **Lucita Azaro**: ""All glory to King Valero, but p..." | `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true` | *Brak zmian stanu* | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..." |
| `[459]` | **""It pains me to say so, but yes. Better that he died rather than order more soldie..."** | `[444]` **Lucita Azaro**: ""All glory to King Valero, but p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Lucita Azaro**: ""If he was murdered as you suspe..."<br>`[469]` **Lucita Azaro**: ""Then again, it's possible they ..." |
| `[461]` | **""Maybe he didn't intend to carry it out. Maybe he wanted me to do it.""** | `[444]` **Lucita Azaro**: ""All glory to King Valero, but p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[463]` **Narrator**: "She frowned." |
| `[472]` | **""His dying wish was for me to take back the lands that were lost. I can't fail him.""** | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..."<br>`[464]` **Lucita Azaro**: ""Or the plan was scrapped when t..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true` | *Brak zmian stanu* | `[489]` **Lucita Azaro**: ""Yes, I heard your coronation sp..." |
| `[473]` | **""I don't understand why this even exists, though. Why does Rizia need to reconquer..."** | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..."<br>`[464]` **Lucita Azaro**: ""Or the plan was scrapped when t..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Prologue_Pales_ProWar"] == true) == false` | *Brak zmian stanu* | `[485]` **Narrator**: "Lucita shook her head." |
| `[477]` | **""The plan doesn't even make sense. I supported the Reclamation War, but... now? Af..."** | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..."<br>`[464]` **Lucita Azaro**: ""Or the plan was scrapped when t..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Prologue_Pales_ProWar"] == true` | *Brak zmian stanu* | `[485]` **Narrator**: "Lucita shook her head." |
| `[478]` | **""I understand why they drew this up, though. I too never gave up on reconquering P..."** | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..."<br>`[464]` **Lucita Azaro**: ""Or the plan was scrapped when t..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Prologue_Pales_ProWar"] == true` | *Brak zmian stanu* | `[487]` **Lucita Azaro**: ""You and most of my province. Th..." |
| `[479]` | **""The timing wasn't right to reconquer Pales in the '20s. But perhaps now...""** | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..."<br>`[464]` **Lucita Azaro**: ""Or the plan was scrapped when t..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Prologue_Pales_ProWar"] == true) == false` | *Brak zmian stanu* | `[484]` **Lucita Azaro**: ""You, too?"" |
| `[483]` | **""His dying wish was for me to take back the lands that were lost. But I'm no conqu..."** | `[462]` **Lucita Azaro**: ""If he was murdered, that could ..."<br>`[464]` **Lucita Azaro**: ""Or the plan was scrapped when t..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false` | *Brak zmian stanu* | `[488]` **Lucita Azaro**: ""It's an outdated concept. Invad..." |
| `[491]` | **""Are you saying there are other reasons?""** | `[490]` **Lucita Azaro**: ""But I don't see any merit in ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "She looked away." |
| `[492]` | **""I trust your guidance, Duchess. If there's a reason you think we should go to war..."** | `[490]` **Lucita Azaro**: ""But I don't see any merit in ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Narrator**: "She looked away." |
| `[495]` | **""You're lying. You're as thirsty for revenge as the rest of your family.""** | `[490]` **Lucita Azaro**: ""But I don't see any merit in ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Lucita Azaro**: ""I'm a realist, Your Majesty. Re..." |
| `[502]` | **""That's ridiculous. It's an inconsequential little strip of land.""** | `[500]` **Lucita Azaro**: ""But with Lespia in ATO, and Mor..."<br>`[501]` **Lucita Azaro**: ""With Lespia in ATO, and Morella..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[505]` **Lucita Azaro**: ""Look at what happened to Wehlen..." |
| `[503]` | **""I'm not sure what you're getting at.""** | `[500]` **Lucita Azaro**: ""But with Lespia in ATO, and Mor..."<br>`[501]` **Lucita Azaro**: ""With Lespia in ATO, and Morella..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[505]` **Lucita Azaro**: ""Look at what happened to Wehlen..." |
| `[504]` | **""Hmm. That's a legitimate worry.""** | `[500]` **Lucita Azaro**: ""But with Lespia in ATO, and Mor..."<br>`[501]` **Lucita Azaro**: ""With Lespia in ATO, and Morella..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[505]` **Lucita Azaro**: ""Look at what happened to Wehlen..." |
| `[507]` | **""Lespia's involvement with Pales is clear. But we haven't seen any signs that the ..."** | `[506]` **Lucita Azaro**: ""And now Pales may be sitting on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[516]` **Lucita Azaro**: ""Not yet. But with Morella edgin..." |
| `[508]` | **""So you think we should conquer Pales for its own good.""** | `[506]` **Lucita Azaro**: ""And now Pales may be sitting on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[514]` **Lucita Azaro**: ""'Conquer' is such an old-fashio..." |
| `[509]` | **""You're my security councilor, Duchess. I don't want you concerning yourself with ..."** | `[506]` **Lucita Azaro**: ""And now Pales may be sitting on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[515]` **Lucita Azaro**: ""This is a security issue, Your ..." |
| `[510]` | **""I'm glad that you're the one who wound up on my council, not your hawk of a father.""** | `[490]` **Lucita Azaro**: ""But I don't see any merit in ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Narrator**: "She blanched slightly." |
| `[518]` | **""That's not Pales' resource. It's ours.""** | `[506]` **Lucita Azaro**: ""And now Pales may be sitting on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Lucita Azaro**: ""At least part of it belongs to ..." |
| `[520]` | **""So? How does that involve Rizia?""** | `[506]` **Lucita Azaro**: ""And now Pales may be sitting on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Lucita Azaro**: ""The Wehlen Civil War happened b..." |
| `[523]` | **""I know that. I've been aiming for diplomacy this entire time.""** | `[522]` **Lucita Azaro**: ""That doesn't mean I think we sh..." | `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true` | *Brak zmian stanu* | `[529]` **Lucita Azaro**: ""If we get into a dispute over t..." |
| `[527]` | **""My war councilor is urging me to practice diplomacy. Now I've heard everything.""** | `[522]` **Lucita Azaro**: ""That doesn't mean I think we sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Lucita Azaro**: ""War should be a last resort, Yo..." |
| `[530]` | **""Diplomatic attempts will only get us so far. At some point, force may be needed.""** | `[522]` **Lucita Azaro**: ""That doesn't mean I think we sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[531]` **Lucita Azaro**: ""You may be right. But we should..." |
| `[532]` | **""I disagree. You've just given me one more reason why retaking Pales is the best c..."** | `[522]` **Lucita Azaro**: ""That doesn't mean I think we sh..." | `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false` | *Brak zmian stanu* | `[533]` **Lucita Azaro**: ""I would not presume to contradi..." |
| `[534]` | **""No, you're right. Beautiful women are a weakness of mine.""** | `[397]` **Lucita Azaro**: ""Pardon my inappropriateness, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Narrator**: "She smiled knowingly." |
| `[536]` | **""That's not how it works. You can't fall in love if you're holding a part of yours..."** | `[388]` **Lucita Azaro**: ""Falling in love is like heading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[540]` **Lucita Azaro**: ""Giving all of yourself to a lov..." |
| `[537]` | **""I don't much care for discussions about love. What are your feelings on the Galmi..."** | `[387]` **Lucita Azaro**: ""What makes you think it would b..."<br>`[388]` **Lucita Azaro**: ""Falling in love is like heading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Narrator**: "She didn't blink." |
| `[548]` | **""Marriages between royals are political arrangements. Love seldom has anything to ..."** | `[387]` **Lucita Azaro**: ""What makes you think it would b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[551]` **Lucita Azaro**: ""You never know, Your Majesty. Y..." |
| `[549]` | **""I've never loved a woman up till now. I just don't see it happening.""** | `[387]` **Lucita Azaro**: ""What makes you think it would b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[550]` **Lucita Azaro**: ""It's never too late, though, is..." |
| `[557]` | **""Actually, I find intelligence far more attractive than physical attributes.""** | `[397]` **Lucita Azaro**: ""Pardon my inappropriateness, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[560]` **Narrator**: "She smiled politely." |
| `[562]` | **""Far from it, Duchess. You still remain an inscrutable mystery to me.""** | `[250]` **Lucita Azaro**: ""I hope your curiosity has been ..." | `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false` | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[564]` **Narrator**: "She smiled." |
| `[567]` | **""Thank you for the suggestion. But I'm afraid such an action will be misinterprete..."** | `[307]` **Lucita Azaro**: ""My department has the funding a..."<br>`[308]` **Lucita Azaro**: ""I wouldn't even need extra fund..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[570]` **Lucita Azaro**: ""The idea would be to avoid aggr..." |
| `[568]` | **""That sounds wise. Do what you need to do." [-1 Budget]"** | `[312]` **Lucita Azaro**: ""It'd just take a small amount o..." | `Variable["RiziaDLC.Resources_Budget"] >= 1` | *Brak zmian stanu* | `[572]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[569]` | **""No. I want all our intelligence capabilities concentrated on the Zille incident a..."** | `[307]` **Lucita Azaro**: ""My department has the funding a..."<br>`[308]` **Lucita Azaro**: ""I wouldn't even need extra fund..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Lucita Azaro**: ""I understand. We'll focus on th..." |
| `[571]` | **""I respectfully refuse. Our internal security is a lot more pressing right now.""** | `[307]` **Lucita Azaro**: ""My department has the funding a..."<br>`[308]` **Lucita Azaro**: ""I wouldn't even need extra fund..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Lucita Azaro**: ""I understand. We'll focus on th..." |
| `[574]` | **""That sounds wise. Do what you need to do.""** | `[307]` **Lucita Azaro**: ""My department has the funding a..."<br>`[308]` **Lucita Azaro**: ""I wouldn't even need extra fund..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[614]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[579]` | **""I appreciate you coming to me with all this. Please feel free to express your unf..."** | `[576]` **Narrator**: "She began standing up." | `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == true` | *Brak zmian stanu* | `[597]` **Lucita Azaro**: ""You can count on it."" |
| `[580]` | **""May I keep that map of Pales?""** | `[576]` **Narrator**: "She began standing up." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn03_Montaklar_TookMap"] = true;` | `[581]` **Lucita Azaro**: ""I don't see why not."" |
| `[588]` | **""Thank you for showing me this. But I must insist you bring up such issues at coun..."** | `[576]` **Narrator**: "She began standing up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[598]` **Lucita Azaro**: ""Certainly, Your Majesty. I woul..." |
| `[589]` | **""Feel free to throw that map away. It's of no use to me.""** | `[576]` **Narrator**: "She began standing up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[599]` **Lucita Azaro**: ""Agreed, Your Majesty. It's a re..." |
| `[590]` | **""I will do everything in my power to prevent conflict with Pales. But just in case..."** | `[582]` **Narrator**: "She handed me the piece of paper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[593]` **Lucita Azaro**: ""If it does come to that, you'll..." |
| `[591]` | **""I will finish what our fathers started. Even if it takes my entire reign.""** | `[582]` **Narrator**: "She handed me the piece of paper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[594]` **Lucita Azaro**: ""If you insist on taking that pa..." |
| `[592]` | **""I will keep this as a reminder of Valero the Frail's folly.""** | `[582]` **Narrator**: "She handed me the piece of paper..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[595]` **Lucita Azaro**: ""And General Taddeus Azaro's."" |
| `[601]` | **""Why didn't the guards step in? I should have them disciplined at once.""** | `[78]` **Narrator**: "She brushed herself off. I saw s..."<br>`[91]` **Narrator**: "She brushed herself off and turn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[608]` **Lucita Azaro**: ""I wasn't expecting their assist..." |
| `[602]` | **""Forgive me. I wasn't fast enough to help you.""** | `[78]` **Narrator**: "She brushed herself off. I saw s..."<br>`[91]` **Narrator**: "She brushed herself off and turn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[604]` **Lucita Azaro**: ""I wasn't expecting your assista..." |
| `[603]` | **""Thank God you're unharmed.""** | `[78]` **Narrator**: "She brushed herself off. I saw s..."<br>`[91]` **Narrator**: "She brushed herself off and turn..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[606]` **Lucita Azaro**: ""God has nothing to do with it."" |
| `[609]` | **""That was the purpose of the uprising. To show us that our blood doesn't make us s..."** | `[145]` **Lucita Azaro**: ""Even as a young girl, I knew th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[612]` **Lucita Azaro**: ""All it showed me was that I had..." |
| `[621]` | **""I'll make sure you'll get what the help you need without the extra funds. Do what..."** | `[312]` **Lucita Azaro**: ""It'd just take a small amount o..." | `Variable["RiziaDLC.Resources_Authority"] >= 2` | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...`<br>`Variable["RiziaDLC.Security_Pales_SendSpecialOps"] = true...` | `[576]` **Narrator**: "She began standing up." |
| `[623]` | **""Sorry but we don't have extra funds to spare.""** | `[312]` **Lucita Azaro**: ""It'd just take a small amount o..." | `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false` | *Brak zmian stanu* | `[624]` **Lucita Azaro**: ""I understand."" |
| `[636]` | **""You can send more police to Cardesse-Montaklar if you like. I won't stop you.""** | `[633]` **Lucita Azaro**: ""And considering the provincial ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[637]` **Lucita Azaro**: ""That's not the point."" |
| `[638]` | **""Brenas won't help him. House Sazon is practically laughing in his face.""** | `[634]` **Lucita Azaro**: ""As long as the provincial polic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[639]` **Lucita Azaro**: ""Then we ought to force them int..." |
| `[640]` | **""Just give Rico some time. If he can't get Iza under control with these extra rein..."** | `[633]` **Lucita Azaro**: ""And considering the provincial ..."<br>`[634]` **Lucita Azaro**: ""As long as the provincial polic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Narrator**: "She nodded, not entirely convinced." |
| `[647]` | **""I thought you'd be pleased with this decision. A completely centralized military ..."** | `[648]` **Lucita Azaro**: ""Do you have reason to believe t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Narrator**: "She half-smiled." |
| `[649]` | **""I believe certain houses can be trusted and certain others can't. But it would ha..."** | `[648]` **Lucita Azaro**: ""Do you have reason to believe t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[651]` **Lucita Azaro**: ""I see..."" |
| `[650]` | **""Sorry, but the provincial armies were a potential threat to my power as King. The..."** | `[648]` **Lucita Azaro**: ""Do you have reason to believe t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[670]` **Narrator**: "She frowned in disappointment." |
| `[653]` | **""That is strictly confidential. I'd rather not discuss it with you.""** | `[648]` **Lucita Azaro**: ""Do you have reason to believe t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable[...` | `[658]` **Lucita Azaro**: ""You'd rather not discuss signif..." |
| `[662]` | **""And they will be just as skillfull and dedicated serving directly under the Crown..."** | `[661]` **Lucita Azaro**: ""The Azaro army had a long, prou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[665]` **Narrator**: "She frowned reluctantly." |
| `[663]` | **""Exactly. If such a formidable force ever were to turn against their King, the con..."** | `[661]` **Lucita Azaro**: ""The Azaro army had a long, prou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[667]` **Lucita Azaro**: ""I'm disappointed you think that..." |
| `[664]` | **""That's the problem. Your house was making the rest of army look weak by compariso..."** | `[661]` **Lucita Azaro**: ""The Azaro army had a long, prou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[672]` **Narrator**: "She gave a short laugh." |
| `[671]` | **""Yes, and I am truly sad to see it go. But greater things are on the horizon for R..."** | `[661]` **Lucita Azaro**: ""The Azaro army had a long, prou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[676]` **Lucita Azaro**: ""Whatever you have in store, I h..." |
| `[682]` | **""Of course. But while we're on the subject... isn't there anything you'd like to k..."** | `[251]` **Lucita Azaro**: ""May I speak freely now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Lucita Azaro**: ""Now that you mention it..."" |

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
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Visiting Fortress Azaro with their Milit..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "From anywhere in the city of Montaklar, you could look high into the hills and see the ruins of Fortress Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Expanded and fortified over the centuries, it had served ..."*)

### Węzeł `[4]`
Mówca: **Lucita Azaro**
> ""How do you like the view, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "From here, we could look down into the valley, where the ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Expanded and fortified over the centuries, it had served as a stronghold for the city's inhabitants from the early years of the Rezenid Empire until its destruction in the War of Rizian Succession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Today, the ruins served as a symbol of Montaklar's resili..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Today, the ruins served as a symbol of Montaklar's resilience - and that of its governing house. Perhaps that was why Lucita had invited me here for a tour and private talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "For safety's sake, a wooden walkway had been constructed ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "For safety's sake, a wooden walkway had been constructed over the crumbling remains of the parapets. Lucita and I walked along it until we came to the northwestern corner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucita Azaro: ""How do you like the view, Your Majesty?""*)

### Węzeł `[8]`
Mówca: **Narrator**
> "From here, we could look down into the valley, where the provincial capital sprawled across the fast-flowing Alca river and up into the foothills of the mountains opposite us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""It's fine. I always preferred the ocean over mountains, ..."*)
  - -> `[10]` (*Player_Romus: ""Spectacular. Why did you bring me here, Duchess Azaro?""*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[15]` (*Player_Romus: ""Imagine how this fortress must have looked a thousand ye..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's fine. I always preferred the ocean over mountains, myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucita Azaro: ""My province has been cut off from the ocean since we los..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spectacular. Why did you bring me here, Duchess Azaro?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucita Azaro: ""For one, it's been too long since you visited this provi..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember it well from my military days.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucita Azaro: ""I've come here as a child, as an army recruit and as a d..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""I remember it well from my military days.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Imagine how this fortress must have looked a thousand years ago.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Incredible, isn't it?""*)

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""Incredible, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The fortress was closed off for our visit, but a crowd ha..."*)

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""I've come here as a child, as an army recruit and as a duchess. It's always different, and always the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The fortress was closed off for our visit, but a crowd ha..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "The fortress was closed off for our visit, but a crowd had gathered just outside its walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "We waved down to them, then turned away, following the wa..."*)

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""My province has been cut off from the ocean since we lost Pales. We've learned to make do with what we have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The fortress was closed off for our visit, but a crowd ha..."*)

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""It took years for the Azaro and Toras families to repair their bond. I hope our houses will remain harmonious through your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""As long as you keep your family in line, they will.""*)
  - -> `[128]` (*Player_Romus: ""I don't see why that wouldn't be the case. You and your ..."*)
  - -> `[21]` (*Player_Romus: ""Is that why you brought me here, Duchess Azaro?""*)
  - -> `[22]` (*Player_Romus: ""Nothing means more to me than keeping the favor of House..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that why you brought me here, Duchess Azaro?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucita Azaro: ""In part, yes.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing means more to me than keeping the favor of House Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucita Azaro: ""It's great to hear you say that.""*)

### Węzeł `[23]`
Mówca: **Lucita Azaro**
> ""In part, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""Your father and mine were close, Your Majesty. General T..."*)

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""I didn't agree with your decision to supercede my authority and transfer Central Police forces to the Duke of Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""It's great to hear you say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""Your father and mine were close, Your Majesty. General T..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't understand. Iza is at a tipping point. The city's fate could determine that of the country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[633]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucita Azaro: ""All the more reason to keep the balance as it is, rather..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras takes care of its own. If I do grant special favors to my cousin, that's none of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[633]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family comes first, Duchess. You have to respect that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[634]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucita Azaro: ""I do. But putting more power in your cousin's hands sets..."*)

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""Not even the Markians could destroy this place, you know. Only when Rizia's noble families turned against each other did it finally fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "She paused and turned to face me."*)

### Węzeł `[30]`
Mówca: **Lucita Azaro**
> ""For one, it's been too long since you visited this province. My constituents were starting to wonder if their king still cared about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The fortress was closed off for our visit, but a crowd ha..."*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""Speaking of provincial activities...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""My house and I had questions regarding your recent meeti..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "She paused and turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucita Azaro: ""It took years for the Azaro and Toras families to repair..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "She gestured to the stone wall behind us. A metal ladder led to the top of a small watchtower, now the fortress' highest surviving structure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Lucita scaled it in a matter of seconds."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Lucita scaled it in a matter of seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[36]` (*Player_Romus: ""I'll stay down here for now. What can you see?""*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "Follow her."]** — Mówca: **Player_Romus_Italic**
> "I followed her to the top of the tower."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "From this side, we could see Camp Domus, the country's la..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll stay down here for now. What can you see?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""Don't you remember? Camp Domus is just downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "She was right. I remembered exactly how the camp looked -..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""Don't you remember? Camp Domus is just downhill from here.""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucita Azaro: ""Camp Domus is just downhill from here.""*)

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""Camp Domus is just downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "From below, I heard the sound of a snare drum beating out..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "From below, I heard the sound of a snare drum beating out a complex rhythm, followed by that of boots hitting the ground in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucita Azaro: ""Long, short, short, long... that's an inverted wedge.""*)

### Węzeł `[43]`
Mówca: **Narrator**
> "From what I knew was the main square, I heard the sound of a snare drum beating out a complex rhythm, followed by that of boots hitting the ground in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "The drumbeat dictated the platoon formation. It was a sys..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "The drumbeat dictated the platoon formation. It was a system from ancient days, modernized by Lucita's ancestor Domus Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucita Azaro: ""Long, short, short, long... that's an inverted wedge, ri..."*)

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""How many men are down there?""*)
  - -> `[79]` (*Player_Romus: ""How did you know that?""*)
  - -> `[81]` (*Player_Romus: ""A little archaic, isn't it?""*)
  - -> `[108]` (*Player_Romus: ""Very impressive.""*)

### Węzeł `[46]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""I can't believe they're still using that system.""*)
  - -> `[71]` (*Player_Romus: ""How many men are down there?""*)
  - -> `[72]` (*Player_Romus: ""Sounds like one of them is just a little bit out of step.""*)

### Węzeł `[47]`
Mówca: **Lucita Azaro**
> ""These are new recruits. They'll learn fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "From this side, we could see Camp Domus, the country's largest military training facility. It stretched far into the distance, with hundreds of barracks clustered around grounds that simulated all types of terrain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "We looked down onto the main square. A platoon of some 50..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "We looked down onto the main square. A platoon of some 50 soldiers -- mostly men, but a few women as well -- was preparing for an exercise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[50]`
Mówca: **Lucita Azaro**
> ""Remember the code?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "A drummer to the side of the square beat out a complex rh..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucita Azaro: ""Remember the code?""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucita Azaro: ""Listen closely.""*)

### Węzeł `[54]`
Mówca: **Lucita Azaro**
> ""Listen closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "A drummer to the side of the square beat out a complex rh..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "A drummer to the side of the square beat out a complex rhythm on a snare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""Long, short, short, long... that's an inverted wedge, ri..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "A drummer to the side of the square beat out a complex rhythm on a snare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: ""Long, short, short, long... that's an inverted wedge.""*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "The soldiers snapped into a V-shaped formation, narrow at..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "The soldiers snapped into a V-shaped formation, narrow at the back and widening towards the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""I can't believe they're still using that system.""*)
  - -> `[60]` (*Player_Romus: ""Very impressive.""*)
  - -> `[65]` (*Player_Romus: ""The woman on the right side was a little slow.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe they're still using that system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucita Azaro: ""Comms can get jammed, orders misunderstood. But rhythm, ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very impressive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucita Azaro: ""Still the best-trained soldiers in South Merkopa.""*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Long, short, short, long... that's an inverted wedge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "The soldiers snapped into a V-shaped formation, narrow at..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "The soldiers snapped into a V-shaped formation, narrow at the back and widening towards the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""How did you know that?""*)
  - -> `[64]` (*Player_Romus: ""Very impressive.""*)
  - -> `[63]` (*Player_Romus: ""A little archaic, isn't it?""*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little archaic, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucita Azaro: ""Comms can get jammed, orders misunderstood. But rhythm, ..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very impressive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucita Azaro: ""The best-trained soldiers in South Merkopa.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The woman on the right side was a little slow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucita Azaro: ""These are new recruits. She'll learn.""*)

### Węzeł `[66]`
Mówca: **Lucita Azaro**
> ""Comms can get jammed, orders misunderstood. But rhythm, you feel in your bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""Comms can get jammed, orders misunderstood. But rhythm, you feel in your bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How did you know that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucita Azaro: ""It's an ancient system from the province. My ancestor Do..."*)

### Węzeł `[69]`
Mówca: **Lucita Azaro**
> ""It's an ancient system from the province. My ancestor Domus Azaro turned it into a proper code.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe they're still using that system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""Comms can get jammed, orders miscommunicated. But rhythm..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many men are down there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucita Azaro), `[46]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""At least 50. And five women, from the looks of it.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like one of them is just a little bit out of step.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucita Azaro: ""These are new recruits. They'll learn fast.""*)

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""Comms can get jammed, orders miscommunicated. But rhythm, you feel in your bones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""At least 50. And five women, from the looks of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[75]`
Mówca: **Lucita Azaro**
> ""The best-trained soldiers in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Still the best-trained soldiers in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""These are new recruits. She'll learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "She brushed herself off. I saw steel in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Player_Romus: ""Why didn't the guards step in? I should have them discip..."*)
  - -> `[602]` (*Player_Romus: ""Forgive me. I wasn't fast enough to help you.""*)
  - -> `[603]` (*Player_Romus: ""Thank God you're unharmed.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How did you know that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucita Azaro: ""It's an ancient system from the province. My ancestor Do..."*)

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""It's an ancient system from the province. My ancestor Domus Azaro turned it into a proper code.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little archaic, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""Comms can get jammed, orders miscommunicated. But rhythm..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Another rhythm came from the drum: two rimshots followed by a rapid roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucita Azaro: ""Extended line spreading out into herringbone.""*)

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""Extended line spreading out into herringbone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Almost unconsciously, she started moving along with the s..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Almost unconsciously, she started moving along with the soldiers. But as she put her left foot down, the section of wall beneath it suddenly gave way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "She began falling backwards towards me."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "She began falling backwards towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus_Italic: "Don't catch her."*)
  - -> `[89]` (*Player_Romus_Italic: "Catch her."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "As she landed in my arms, my weak leg buckled underneath ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "She landed in my arms."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "Catch her."]** — Mówca: **Player_Romus_Italic**
> "I ran to break her fall."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "Don't catch her."]** — Mówca: **Player_Romus_Italic**
> "I watched her fall. She hit the ground with her knees bent, did a quick roll and stood back up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "She brushed herself off and turned to face me. I saw stee..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "She brushed herself off and turned to face me. I saw steel in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Player_Romus: ""Why didn't the guards step in? I should have them discip..."*)
  - -> `[602]` (*Player_Romus: ""Forgive me. I wasn't fast enough to help you.""*)
  - -> `[603]` (*Player_Romus: ""Thank God you're unharmed.""*)

### Węzeł `[92]`
Mówca: **Narrator**
> "As she landed in my arms, my weak leg buckled underneath me. I hit the ground with her on top of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Romus_Italic: "Get up."*)
  - -> `[95]` (*Player_Romus_Italic: "Don't get up."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "She landed in my arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus_Italic: "Put her down."*)
  - -> `[97]` (*Player_Romus_Italic: "Don't put her down."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "Get up."]** — Mówca: **Player_Romus_Italic**
> "I shoved her off of me and stood up with some difficulty. She took a second to compose herself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""Thank you, Your Majesty. It seems old habits die hard.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "Don't get up."]** — Mówca: **Player_Romus_Italic**
> "We stayed in that position for a few long seconds."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance >= 0"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "Put her down."]** — Mówca: **Player_Romus_Italic**
> "I put her down. She took a second to compose herself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""Thank you, Your Majesty. It seems old habits die hard.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "Don't put her down."]** — Mówca: **Player_Romus_Italic**
> "I held on to her for a few long seconds."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance >= 0"*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""I'm fine. We're both fine. But who the hell let that happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucita Azaro: ""You are to find this photographer and prevent the public..."*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. It seems old habits die hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "She swiftly turned her back on me and told the guards it ..."*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""It's nearly four. Let me show you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "She gestured to the stone wall behind us. A metal ladder ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""I would follow you, but my bum leg won't allow it.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus_Italic: "Follow her."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would follow you, but my bum leg won't allow it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Kontekst wejściowy (poprzednik):** `[34]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""I'm afraid I forgot about that, Your Majesty. You always..."*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""I'm afraid I forgot about that, Your Majesty. You always seem so limber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucita Azaro: ""You're familiar with the sight, anyway. Camp Domus is ju..."*)

### Węzeł `[106]`
Mówca: **Lucita Azaro**
> ""You're familiar with the sight, anyway. Camp Domus is just downhill from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "She was right. I remembered exactly how the camp looked -..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "She was right. I remembered exactly how the camp looked -- a vast training ground simulating all types of terrain, surrounded by hundreds of barracks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "From what I knew was the main square, I heard the sound o..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very impressive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucita Azaro: ""The best-trained soldiers in South Merkopa.""*)

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""The best-trained soldiers in South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Another rhythm came from the drum: two rimshots followed ..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Lucita avoided my gaze as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplet..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Another rhythm came from the drum: two rimshots followed by a rapid roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucita Azaro: ""Extended line spreading out into herringbone.""*)

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""Extended line spreading out into herringbone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Almost unconsciously, she started moving along with the s..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Almost unconsciously, she started moving along with the soldiers. But as she put her left foot down, the section of wall beneath it suddenly gave way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "She began falling backwards."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "She began falling backwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Romus_Italic: "Grab her arm."*)
  - -> `[116]` (*Player_Romus_Italic: "Do nothing."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Grab her arm."]** — Mówca: **Player_Romus_Italic**
> "I grabbed her arm and pulled her towards me to safety."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "She looked up at me in surprise, breathing heavily."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Romus_Italic**
> "I watched her fall. With expert reflexes, she managed to grab the top rung of the ladder and pull herself back up to stand next to me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "She brushed herself off. I saw steel in her eyes."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "She looked up at me in surprise, breathing heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus_Italic: "Let go of her."*)
  - -> `[119]` (*Player_Romus_Italic: "Don't let go of her."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "Let go of her."]** — Mówca: **Player_Romus_Italic**
> "I released my grip on her arm. She stepped back from me and brushed herself off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucita Azaro: ""It seems old habits die hard. Thank you, Your Majesty.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "Don't let go of her."]** — Mówca: **Player_Romus_Italic**
> "I held on to her for a few long seconds."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance >= 0"*)

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""It seems old habits die hard. Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She swiftly climbed down and told the guards it was time ..."*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Now, who the hell let that happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucita Azaro: ""You are to find this photographer and prevent the public..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Lucita hurriedly stepped away from me, brushed herself off and turned to the guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""Now, who the hell let that happen?""*)

### Węzeł `[123]`
Mówca: **Narrator**
> "She swiftly turned her back on me and told the guards it was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplet..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "She swiftly climbed down and told the guards it was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplet..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CameraShutter");"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "From anywhere in the city of Montaklar, you could look hi..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "We waved down to them, then turned away, following the walkway towards the former armory. Our aides and guards stayed a respectable distance behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""Not even the Markians could destroy this place, you know..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't see why that wouldn't be the case. You and your relatives have sworn fealty to the crown, have they not?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lucita Azaro: ""Of course. But, well...""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as you keep your family in line, they will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""You don't need to worry about my family's loyalty. I gue..."*)

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""Of course. But, well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""Your father and mine were close, Your Majesty. General T..."*)

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""Your father and mine were close, Your Majesty. General Taddeus told me that he felt free to express his true opinions to the King, with no fear of repercussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "Lucita bit her lip. She seemed uncharacteristically nervous."*)

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""I'd like it if you and I had a similar relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""I want to have that relationship with all of my councilo..."*)
  - -> `[135]` (*Player_Romus: ""And what makes you think you deserve that? You've barely..."*)
  - -> `[136]` (*Player_Romus: ""How can we when we barely even know each other?""*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""You don't need to worry about my family's loyalty. I guess I'm referring specifically to the two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""Your father and mine were close, Your Majesty. General T..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to have that relationship with all of my councilors, Duchess. Nobody should feel like they have to hold back their opinions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucita Azaro: ""Perfect, Your Majesty. Thank you.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what makes you think you deserve that? You've barely been on the council for a year.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucita Azaro: ""I know. It would be exceedingly gracious of you to exten..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can we when we barely even know each other?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucita Azaro: ""A fair point, Your Majesty.""*)

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""A fair point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "She trained her eyes on a lizard that was crawling up the..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "She trained her eyes on a lizard that was crawling up the wall next to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucita Azaro: ""You have my permission, then. Ask me anything about myse..."*)

### Węzeł `[139]`
Mówca: **Lucita Azaro**
> ""You have my permission, then. Ask me anything about myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Lucita Personal Qs"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... why aren't you married? As an Azaro, you should've been paired off the day you came of age.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucita Azaro), `[354]` (Lucita Azaro), `[171]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "She grimaced."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's drop the small talk. You brought me here today because you want something.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false` AND `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucita Azaro), `[354]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "She looked at me with flinty eyes."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's see. Do you have any hobbies?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucita Azaro), `[354]` (Lucita Azaro), `[171]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: ""I've always enjoyed archery, when I've had the time for ..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you follow in the Azaro family's footsteps? You could've chosen your own path in life.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucita Azaro), `[354]` (Lucita Azaro), `[171]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucita Azaro: ""My path was chosen for me after my uncle was killed in t..."*)

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""My path was chosen for me after my uncle was killed in the uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucita Azaro: ""Even as a young girl, I knew that marked a turning point..."*)

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""Even as a young girl, I knew that marked a turning point. My noble blood didn't make me safe anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""Those days are over. We don't have to live in fear of an..."*)
  - -> `[192]` (*Player_Romus: ""The real threat isn't from the commoners. It's from the ..."*)
  - -> `[193]` (*Player_Romus: ""Your words ring true. I had the exact same thought after..."*)
  - -> `[609]` (*Player_Romus: ""That was the purpose of the uprising. To show us that ou..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "She grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucita Azaro: ""They had a match chosen for me, of course. But my father..."*)

### Węzeł `[147]`
Mówca: **Lucita Azaro**
> ""They had a match chosen for me, of course. But my father allowed me to break off the engagement when I joined the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucita Azaro: ""By the time I got out, I was considered too old to be of..."*)

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""By the time I got out, I was considered too old to be of use in the marriage arena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: ""Who's going to carry on the Azaro legacy, then?""*)
  - -> `[150]` (*Player_Romus: ""That's ridiculous. A woman like you should be swarmed wi..."*)
  - -> `[151]` (*Player_Romus: ""So you've never known the touch of a man?""*)
  - -> `[152]` (*Player_Romus: ""You were what, 28? That's ancient for a woman.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who's going to carry on the Azaro legacy, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "She looked away."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. A woman like you should be swarmed with suitors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "A wry smile formed on her face."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you've never known the touch of a man?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "She raised an eyebrow, then laughed lightly."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were what, 28? That's ancient for a woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "She frowned and looked away."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "She raised an eyebrow, then laughed lightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucita Azaro: ""Unmarried doesn't mean chaste, Your Majesty.""*)

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""Unmarried doesn't mean chaste, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[155]`
Mówca: **Narrator**
> "She frowned and looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucita Azaro: ""Call me foolish. I chose my country over my womanly repu..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "A wry smile formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucita Azaro: ""I'm not so pathetic as to base my self-worth on what men..."*)

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""I'm not so pathetic as to base my self-worth on what men think of me. But thank you for the compliment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[158]`
Mówca: **Lucita Azaro**
> ""Call me foolish. I chose my country over my womanly reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""Do you have any questions of a less... intimate nature?""*)

### Węzeł `[159]`
Mówca: **Narrator**
> "She looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucita Azaro: ""My younger sister is poised to bring us an heir sooner o..."*)

### Węzeł `[160]`
Mówca: **Lucita Azaro**
> ""My younger sister is poised to bring us an heir sooner or later. If not her, then surely one of our cousins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""Do you have any questions of a less... intimate nature?""*)

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""Do you have any questions of a less... intimate nature?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage = true"*)

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""I've always enjoyed archery, when I've had the time for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucita Azaro: ""And my father and I used to play chess together. We stil..."*)

### Węzeł `[163]`
Mówca: **Lucita Azaro**
> ""And my father and I used to play chess together. We still do, when he has a lucid moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""Who wins?""*)
  - -> `[166]` (*Player_Romus: ""Maybe you and I can play someday.""*)
  - -> `[167]` (*Player_Romus: ""No needlepoint? Calligraphy?""*)
  - -> `[168]` (*Player_Romus: ""Chess is a silly game.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Lucita Personal Qs`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true ..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who wins?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucita Azaro: ""I do, mostly. I've let him win a few times since the str..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe you and I can play someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "She gave me a taunting look."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No needlepoint? Calligraphy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucita Azaro: ""You *really* must not know me, Your Majesty.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chess is a silly game.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucita Azaro: ""I beg to differ. If you can win at chess, you can win at..."*)

### Węzeł `[169]`
Mówca: **Lucita Azaro**
> ""If you're prepared to lose, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[170]`
Mówca: **Narrator**
> "She gave me a taunting look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucita Azaro: ""If you're prepared to lose, Your Majesty.""*)

### Węzeł `[171]`
Mówca: **Lucita Azaro**
> ""I do, mostly. I've let him win a few times since the stroke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies = true"*)

### Węzeł `[172]`
Mówca: **Lucita Azaro**
> ""I beg to differ. If you can win at chess, you can win at war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies = true"*)

### Węzeł `[173]`
Mówca: **Lucita Azaro**
> ""You *really* must not know me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies = true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Personal Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Lucita Personal Qs"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Personal Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Lucita Personal Qs"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true ..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == tru..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false"*)
  - -> `[181]` (*Player_Romus: ""That's all I wanted to know.""*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == true || RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Personal Qs]"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Personal Qs]"*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I wanted to know.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == true  or  Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucita Azaro), `[354]` (Lucita Azaro), `[171]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucita Azaro: ""I hope your curiosity has been satisfied.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""Let's see. Do you have any hobbies?""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == fa..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""Well... why aren't you married? As an Azaro, you should'..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Marriage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""Why did you follow in the Azaro family's footsteps? You ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those days are over. We don't have to live in fear of another uprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The real threat isn't from the commoners. It's from the foreign powers who want to destroy our way of life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucita Azaro: ""Whatever the source of the threat, it pays to be prepare..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your words ring true. I had the exact same thought after my kidnapping.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""And you didn't feel the drive to do something about it? To armor yourself against such threats in the future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucita Azaro: ""I joined the military so I'd never get caught by surpris..."*)

### Węzeł `[195]`
Mówca: **Lucita Azaro**
> ""Whatever the source of the threat, it pays to be prepared for it. As a kingdom, and as an individual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucita Azaro: ""I joined the military so I'd never get caught by surpris..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Personal Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Lucita Personal Qs"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Personal Qs]"*)

### Węzeł `[198]`
Mówca: **Narrator**
> "She looked at me with flinty eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Lucita Azaro: ""Is that so surprising? Everyone wants something from the..."*)

### Węzeł `[199]`
Mówca: **Lucita Azaro**
> ""Perfect, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true"*)

### Węzeł `[200]`
Mówca: **Lucita Azaro**
> ""I know. It would be exceedingly gracious of you to extend that level of trust to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""Well, I am nothing if not gracious. Tell me what's on yo..."*)
  - -> `[249]` (*Player_Romus: ""I cannot trust you if I don't know you. Tell me more abo..."*)
  - -> `[267]` (*Player_Romus: ""I will extend you my trust when you have earned it. That..."*)

### Węzeł `[201]`
Mówca: **Lucita Azaro**
> ""First of all, I must say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucita Azaro: ""I didn't agree with your decision to supercede my author..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""My house and I had questions regarding your recent meeting in Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucita Azaro: ""Sources say you were quite deep in conversation with the..."*)

### Węzeł `[206]`
Mówca: **Lucita Azaro**
> ""Sources say you were quite deep in conversation with the House Sazon heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player_Romus: ""It's all strategic. Without the Sazons on my side, I won..."*)
  - -> `[208]` (*Player_Romus: ""We were speaking of repairing the bond between our house..."*)
  - -> `[209]` (*Player_Romus: ""We were guests in his province. Refusing to converse wou..."*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all strategic. Without the Sazons on my side, I won't be able to prevent another uprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucita Azaro: ""That's what he led you to believe? His house would help ..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We were speaking of repairing the bond between our houses. As you yourself said, Rizia can only be strong if all of its royal families stand together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucita Azaro: ""The Sazons were never a royal family. Just a group of me..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We were guests in his province. Refusing to converse would've been a terrible breach of etiquette.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucita Azaro: ""As terrible as what his family did to you?""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Did those sources fail to tell you I turned him away?""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did those sources fail to tell you I turned him away?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Kontekst wejściowy (poprzednik):** `[206]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""I had that impression. But I wanted to hear it from you.""*)

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""That's what he led you to believe? His house would help you stop an uprising?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""You might as well use gasoline to put out a fire.""*)

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""You might as well use gasoline to put out a fire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""You know the entire house is still suspected to have tie..."*)

### Węzeł `[216]`
Mówca: **Lucita Azaro**
> ""The Sazons were never a royal family. Just a group of merchants who fancied themselves higher than their true station.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""You know the entire house is still suspected to have tie..."*)

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""You know the entire house is still suspected to have ties to Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[222]` (*Player_Romus: ""That isn't surprising. Arcasia has eyes and ears everywh..."*)
  - -> `[221]` (*Player_Romus: ""I don't know about Manus. He seems different.""*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_ATO == true"*)

### Węzeł `[218]`
Mówca: **Lucita Azaro**
> ""As terrible as what his family did to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""You know the entire house is still suspected to have tie..."*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""I had that impression. But I wanted to hear it from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""You know the entire house is still suspected to have tie..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to get closer to Arcasia. It's part of my diplomatic strategy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Lucita Azaro: ""I would ask you to reconsider that. Put your faith in th..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about Manus. He seems different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Lucita Azaro: ""That's what he wants you to think. Keep in mind Arcasia ..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That isn't surprising. Arcasia has eyes and ears everywhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Lucita Azaro: ""They and their allies have spent the better part of this..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, better Arcasia than United Contana.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Lucita Azaro: ""Oh, I'm not discounting the threat of United Contana. Bu..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucita Azaro: ""Don't trust the man around your daughter, is all I'm say..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Thank you for your advice. Perhaps I'll require your ass..."*)
  - -> `[241]` (*Player_Romus: ""This is not a matter of national security. You needn't i..."*)
  - -> `[243]` (*Player_Romus: ""I appreciate your concern. But I will deal with Mr. Sazo..."*)

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""Don't trust the man around your daughter, is all I'm saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Thank you for your advice. Perhaps I'll require your ass..."*)
  - -> `[241]` (*Player_Romus: ""This is not a matter of national security. You needn't i..."*)
  - -> `[242]` (*Player_Romus: ""My daughter is allowed to consort with whomever she want..."*)
  - -> `[243]` (*Player_Romus: ""I appreciate your concern. But I will deal with Mr. Sazo..."*)

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""No matter what, Your Majesty, I wouldn't trust that man around your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Thank you for your advice. Perhaps I'll require your ass..."*)
  - -> `[241]` (*Player_Romus: ""This is not a matter of national security. You needn't i..."*)
  - -> `[242]` (*Player_Romus: ""My daughter is allowed to consort with whomever she want..."*)
  - -> `[243]` (*Player_Romus: ""I appreciate your concern. But I will deal with Mr. Sazo..."*)

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""All the more reason not to trust that man around your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Thank you for your advice. Perhaps I'll require your ass..."*)
  - -> `[241]` (*Player_Romus: ""This is not a matter of national security. You needn't i..."*)
  - -> `[242]` (*Player_Romus: ""My daughter is allowed to consort with whomever she want..."*)
  - -> `[243]` (*Player_Romus: ""I appreciate your concern. But I will deal with Mr. Sazo..."*)

### Węzeł `[230]`
Mówca: **Lucita Azaro**
> ""Oh, I'm not discounting the threat of United Contana. But they don't have tentacles in the Rizian nobility. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[231]`
Mówca: **Lucita Azaro**
> ""They and their allies have spent the better part of this century trying to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucita Azaro: ""All the more reason not to trust that man around your da..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Thank you for your advice. Perhaps I'll require your ass..."*)
  - -> `[241]` (*Player_Romus: ""This is not a matter of national security. You needn't i..."*)
  - -> `[243]` (*Player_Romus: ""I appreciate your concern. But I will deal with Mr. Sazo..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucita Azaro: ""No matter what, Your Majesty, I wouldn't trust that man ..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Thank you for your advice. Perhaps I'll require your ass..."*)
  - -> `[241]` (*Player_Romus: ""This is not a matter of national security. You needn't i..."*)
  - -> `[243]` (*Player_Romus: ""I appreciate your concern. But I will deal with Mr. Sazo..."*)

### Węzeł `[238]`
Mówca: **Lucita Azaro**
> ""That's what he wants you to think. Keep in mind Arcasia and its allies have been endlessly inventive in their attempts to undermine us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[239]`
Mówca: **Lucita Azaro**
> ""I would ask you to reconsider that. Put your faith in the West and their allies, and they'll abuse it every time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your advice. Perhaps I'll require your assistance with this in the future.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucita Azaro), `[228]` (Lucita Azaro), `[229]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucita Azaro: ""I'm just looking out for national security. As is my job.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not a matter of national security. You needn't involve yourself in it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucita Azaro), `[228]` (Lucita Azaro), `[229]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Lucita Azaro: ""Isn't it, though? An agent of chaos attempting to get co..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter is allowed to consort with whomever she wants. Surely you understand that as a modern woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucita Azaro), `[228]` (Lucita Azaro), `[229]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucita Azaro: ""As the woman in charge of this country's security, all I..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern. But I will deal with Mr. Sazon and his family on my own.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucita Azaro), `[228]` (Lucita Azaro), `[229]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Lucita Azaro: ""Well, let me know if you do require my assistance.""*)

### Węzeł `[244]`
Mówca: **Lucita Azaro**
> ""Isn't it, though? An agent of chaos attempting to get cozy with the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""As the woman in charge of this country's security, all I see is an agent of chaos attempting to get cozy with the royal family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""I'm just looking out for national security. As is my job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I am nothing if not gracious. Tell me what's on your mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[248]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucita Azaro: ""First of all, I must say...""*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot trust you if I don't know you. Tell me more about yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Lucita Azaro: ""About myself?""*)

### Węzeł `[250]`
Mówca: **Lucita Azaro**
> ""I hope your curiosity has been satisfied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false"*)

### Węzeł `[251]`
Mówca: **Lucita Azaro**
> ""May I speak freely now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player_Romus: ""Go ahead.""*)
  - -> `[266]` (*Player_Romus: ""No, I'd still rather you didn't.""*)
  - -> `[682]` (*Player_Romus: ""Of course. But while we're on the subject... isn't there..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true"*)

### Węzeł `[253]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita/Azaro grievances]"*)

### Węzeł `[254]`
Mówca: **Lucita Azaro**
> ""Well, let me know if you do require my assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[255]`
Mówca: **Lucita Azaro**
> ""I had one more thing I wanted to bring up while we were alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "Lucita Pales Talk"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lucita Azaro: ""Especially while he's the subject of an investigation th..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Lucita Azaro: ""Especially given the level of scrutiny he is currently u..."*)

### Węzeł `[259]`
Mówca: **Lucita Azaro**
> ""Especially given the level of scrutiny he is currently under from Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""Especially while he's the subject of an investigation that, again, was commissioned without the involvement of my department.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)

### Węzeł `[261]`
Mówca: **Lucita Azaro**
> ""All the more reason to keep the balance as it is, rather than put more power in your cousin's hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "She sighed."*)

### Węzeł `[262]`
Mówca: **Lucita Azaro**
> ""I beg your pardon, Your Majesty, but Rizia's internal security *is* my business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "She sighed."*)

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""I do. But putting more power in your cousin's hands sets a dangerous precedent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "She sighed."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Hobbies = true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""Do you have any questions of a less... intimate nature?""*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I'd still rather you didn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Before she could stop herself, she let out an exasperated..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will extend you my trust when you have earned it. That time has not yet come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Lucita Azaro: ""No?""*)

### Węzeł `[268]`
Mówca: **Narrator**
> "We had come to a small grassy patch in the shade of the fortress' southern wall. Lucita gestured for me to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Lucita Azaro: ""I had one more thing I wanted to bring up while we were ..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "Suddenly, we heard the click of a camera shutter. A news photographer had managed to get a photo of us from the opposite parapet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Her head disappeared back over the wall. Lucita hurriedly..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "From below, a camera clicked. A news photographer had managed to reach the base of the fortress and capture a picture of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Lucita hurriedly stepped away from me, brushed herself of..."*)

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""You are to find this photographer and prevent the publication of this picture at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player_Romus: ""Do not berate our staff, Duchess Azaro. But yes, I don't..."*)
  - -> `[274]` (*Player_Romus: ""You heard her. I'm embarrassed at this obvious security ..."*)
  - -> `[275]` (*Player_Romus: ""Disregard that order, gentlemen. Let the papers do what ..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Her head disappeared back over the wall. Lucita hurriedly pushed away from me, brushed herself off and turned to the guards surrounding us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""I'm fine. We're both fine. But who the hell let that hap..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not berate our staff, Duchess Azaro. But yes, I don't want this photograph getting out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The guards nodded. One of them sprinted off in the direct..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard her. I'm embarrassed at this obvious security lapse. You ought to be ashamed of yourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The guards nodded. One of them sprinted off in the direct..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disregard that order, gentlemen. Let the papers do what they will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto = true; RiziaDLCSupport..."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "The guards nodded. One of them sprinted off in the direction of the photographer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player_Romus: ""To be continued, Duchess Azaro.""*)
  - -> `[328]` (*Player_Romus: ""That was close. Wouldn't want anyone to think anything u..."*)
  - -> `[333]` (*Player_Romus: ""Honestly. What do we even pay the Golden Guard for?""*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Lucita spun around towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucita Azaro: ""Really? I thought you wouldn't want the public to think ..."*)

### Węzeł `[278]`
Mówca: **Lucita Azaro**
> ""Really? I thought you wouldn't want the public to think anything was happening between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""And why not? You yourself said our houses should be more..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[285]` (*Player_Romus: ""I don't care what the public thinks. The King of Rizia i..."*)
  - -> `[284]` (*Player_Romus: ""Being seen with my arms around a gorgeous noblewoman wil..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why not? You yourself said our houses should be more harmonious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "She gave me a coy smile."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's beside the point. I'm not going to participate in censorship of the press.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Kontekst wejściowy (poprzednik):** `[278]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "She nodded."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""That's beside the point. I'm not going to participate in..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Being seen with my arms around a gorgeous noblewoman will only benefit my reputation, wouldn't you agree?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "She gave me a coy smile."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what the public thinks. The King of Rizia is above such concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "She nodded."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "She gave me a coy smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucita Azaro: ""If you say so, Your Majesty.""*)

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""If you say so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "The smile was still on her face as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplet..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto = true; RiziaDLCSupport.News_Turn03_RH_Gossip_KingLucita = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] = true;
Variable["RiziaDLCSupport.News_Turn03_RH_Gossip_KingLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Lucita spun around towards me."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucita Azaro: ""It's your decision, Your Majesty.""*)

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""It's your decision, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "She had a small smile on her face as we left the fortress."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "She had a small smile on her face as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplet..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Lucita Azaro: ""We shouldn't fear an uprising, but we should be prepared..."*)

### Węzeł `[295]`
Mówca: **Lucita Azaro**
> ""We shouldn't fear an uprising, but we should be prepared for one regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucita Azaro: ""I joined the military so I'd never get caught by surpris..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist < 0)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""Well, better Arcasia than United Contana.""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player_Romus: ""Arcasia's power is laughable compared to the combined mi..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arcasia's power is laughable compared to the combined might of the international workers' movement.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[217]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""I... don't know what to say to that. Except that they bo..."*)

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""I... don't know what to say to that. Except that they both pose a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_ATO == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""I want to get closer to Arcasia. It's part of my diploma..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucita Azaro: ""My department has the funding already. It wouldn't eat i..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_GoldenGuard_InvestigateSO == true"*)

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""My department has the funding already. It wouldn't eat into our budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Player_Romus: ""That sounds wise. Do what you need to do.""*)
  - -> `[567]` (*Player_Romus: ""Thank you for the suggestion. But I'm afraid such an act..."*)
  - -> `[569]` (*Player_Romus: ""No. I want all our intelligence capabilities concentrate..."*)
  - -> `[571]` (*Player_Romus: ""I respectfully refuse. Our internal security is a lot mo..."*)

### Węzeł `[308]`
Mówca: **Lucita Azaro**
> ""I wouldn't even need extra funding. Your expansion of the Golden Guard has created a few redundancies in our intelligence division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Player_Romus: ""That sounds wise. Do what you need to do.""*)
  - -> `[567]` (*Player_Romus: ""Thank you for the suggestion. But I'm afraid such an act..."*)
  - -> `[569]` (*Player_Romus: ""No. I want all our intelligence capabilities concentrate..."*)
  - -> `[571]` (*Player_Romus: ""I respectfully refuse. Our internal security is a lot mo..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_GoldenGuard_InvestigateSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_GoldenGuard_InvestigateSO == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_GoldenGuard_InvestigateSO == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_GoldenGuard_InvestigateSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucita Azaro: ""I wouldn't even need extra funding. Your expansion of th..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_GoldenGuard_InvestigateSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucita Azaro: ""It'd just take a small amount of funding.""*)

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""It'd just take a small amount of funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""Thank you for the suggestion. But I'm afraid such an act..."*)
  - -> `[571]` (*Player_Romus: ""I respectfully refuse. Our internal security is a lot mo..."*)
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 2"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance >= 0"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Romance >= 0)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Her eyes softened as they met mine."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Romance >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "She quickly pushed away from me and brushed herself off."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "Her eyes softened as they met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Lucita Azaro: ""Nice catch, Your Majesty.""*)

### Węzeł `[317]`
Mówca: **Narrator**
> "She quickly pushed away from me and brushed herself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "She swiftly turned her back on me and told the guards it ..."*)

### Węzeł `[318]`
Mówca: **Lucita Azaro**
> ""Nice catch, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance >= 0"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Romance >= 0)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "Her eyes softened as they met mine."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Romance >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "She hurriedly pushed me away and brushed herself off."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "She hurriedly pushed me away and brushed herself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[323]`
Mówca: **Narrator**
> "Her eyes softened as they met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Lucita Azaro: ""Nice reflexes, Your Majesty.""*)

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""Nice reflexes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[325]`
Mówca: **Lucita Azaro**
> ""That's true, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[326]`
Mówca: **Narrator**
> "She gave me a coy smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucita Azaro: ""That's true, Your Majesty.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be continued, Duchess Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was close. Wouldn't want anyone to think anything untoward was happening between us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Lucita Azaro: ""Certainly not, Your Majesty.""*)

### Węzeł `[329]`
Mówca: **Lucita Azaro**
> ""Certainly not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Lucita avoided my gaze as we left the fortress."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "She gave me a coy smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Lucita Azaro: ""I hope so, Your Majesty.""*)

### Węzeł `[331]`
Mówca: **Lucita Azaro**
> ""I hope so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "The smile was still on her face as we left the fortress."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "She gave me a coy smile."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly. What do we even pay the Golden Guard for?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Lucita Azaro: ""You said it, Your Majesty. I didn't.""*)

### Węzeł `[334]`
Mówca: **Lucita Azaro**
> ""You said it, Your Majesty. I didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "She had a small smile on her face as we left the fortress."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "She had a small smile on her face as we left the fortress."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplet..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Pales Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "Lucita Pales Talk"*)

### Węzeł `[337]`
Mówca: **Lucita Azaro**
> ""Is that so surprising? Everyone wants something from the King of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Lucita Azaro: ""All I am requesting is a chance to speak to you without ..."*)

### Węzeł `[338]`
Mówca: **Lucita Azaro**
> ""All I am requesting is a chance to speak to you without the stultifying formality of the council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus: ""That's reasonable enough. Go ahead, then.""*)
  - -> `[339]` (*Player_Romus: ""Consider that request refused, Duchess.""*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Consider that request refused, Duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Before she could stop herself, she let out an exasperated..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's reasonable enough. Go ahead, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucita Azaro: ""Well, Your Majesty...""*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "From below, a camera clicked. A news photographer had man..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "Suddenly, we heard the click of a camera shutter. A news ..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "Lucita bit her lip. She seemed uncharacteristically nervous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucita Azaro: ""I'd like it if you and I had a similar relationship.""*)

### Węzeł `[344]`
Mówca: **Narrator**
> "She was smiling, but I registered slight disappointment in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""Were you hoping for special treatment?""*)
  - -> `[346]` (*Player_Romus: ""It's precisely your willingness to speak your mind that ..."*)
  - -> `[348]` (*Player_Romus: ""I'd like to get to know you better. Tell me about yourse..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Were you hoping for special treatment?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Lucita Azaro: ""No, no. That would be unfair to the others.""*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's precisely your willingness to speak your mind that makes you such a valuable asset on my council.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Lucita Azaro: ""I'm pleased to hear that.""*)

### Węzeł `[347]`
Mówca: **Lucita Azaro**
> ""No, no. That would be unfair to the others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "She stared out at the surrounding mountains before turnin..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to get to know you better. Tell me about yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Lucita Azaro: ""About myself?""*)

### Węzeł `[349]`
Mówca: **Lucita Azaro**
> ""I'm pleased to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "She stared out at the surrounding mountains before turnin..."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "She stared out at the surrounding mountains before turning back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Lucita Azaro: ""So. On the subject of speaking my mind.""*)

### Węzeł `[351]`
Mówca: **Lucita Azaro**
> ""So. On the subject of speaking my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "Lucita/Azaro grievances"*)

### Węzeł `[352]`
Mówca: **Lucita Azaro**
> ""About myself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "She seemed to be searching for words."*)

### Węzeł `[353]`
Mówca: **Narrator**
> "She seemed to be searching for words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Lucita Azaro: ""That depends, Your Majesty. What would you like to know?""*)

### Węzeł `[354]`
Mówca: **Lucita Azaro**
> ""That depends, Your Majesty. What would you like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Personal Qs]"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Personal Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Lucita Personal Qs"*)

### Węzeł `[356]`
Mówca: **Lucita Azaro**
> ""My sincerest apologies, Your Majesty. I didn't mean to bother you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Lucita Azaro: ""While we're here, though... there *is* something you sho..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Before she could stop herself, she let out an exasperated sigh. She tried to camouflage it as a cough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lucita Azaro: ""My sincerest apologies, Your Majesty. I didn't mean to b..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Lucita/Azaro grievances`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_Iza_GiveRicoPolice == true"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita/Azaro grievances]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "Lucita/Azaro grievances"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "She was smiling, but I registered slight disappointment i..."*)

### Węzeł `[361]`
Mówca: **Lucita Azaro**
> ""No?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Lucita Azaro: ""I thought your granting extra funding to my department w..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Lucita Azaro: ""I suppose your turning down my request for funding shoul..."*)

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""I thought your granting extra funding to my department was an indication of your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player_Romus: ""It was a gesture of good faith. I will trust you when yo..."*)
  - -> `[403]` (*Player_Romus: ""I trust your capabilities. I'm still deciding whether I ..."*)
  - -> `[404]` (*Player_Romus: ""I was only being pragmatic, Duchess. Zille was bombed. O..."*)
  - -> `[413]` (*Player_Romus: ""Enough of this, Duchess. You are on my council to provid..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == f..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""Let's drop the small talk. You brought me here today bec..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == f..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Lucita Azaro: ""May I speak freely now?""*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player_Romus: ""It has. Now, what did you want to say to me?""*)
  - -> `[562]` (*Player_Romus: ""Far from it, Duchess. You still remain an inscrutable my..."*)
  - -> `[372]` (*Player_Romus: ""While we're at it, is there anything you want to know ab..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While we're at it, is there anything you want to know about me?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Lucita Azaro: ""Now that you mention it...""*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It has. Now, what did you want to say to me?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucita Azaro: ""Well, Your Majesty...""*)

### Węzeł `[374]`
Mówca: **Lucita Azaro**
> ""While we're here, though... there *is* something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Pales Talk]"*)

### Węzeł `[375]`
Mówca: **Lucita Azaro**
> ""Now that you mention it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "She looked me in the eye."*)

### Węzeł `[376]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Lucita Azaro: ""Turnabout is fair play, Your Majesty. Why aren't *you* m..."*)

### Węzeł `[377]`
Mówca: **Lucita Azaro**
> ""Turnabout is fair play, Your Majesty. Why aren't *you* married?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife"*)
  - -> `[385]` (*Player_Romus: ""I'm still looking for a woman who can handle me.""*)
  - -> `[384]` (*Player_Romus: ""Romance isn't easy as a royal. You can never tell who tr..."*)
  - -> `[383]` (*Player_Romus: ""That is a highly inappropriate question. I refuse to ans..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm terrified at the idea of loving someone that much again, only to lose them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"]`
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lucita Azaro: ""Falling in love is like heading into battle. You've got ..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was already in one loveless marriage. I'm not about to enter another.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"]) == false`
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucita Azaro: ""What makes you think it would be loveless?""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player_Romus: ""I'm terrified at the idea of loving someone that much ag..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""I was already in one loveless marriage. I'm not about to..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is a highly inappropriate question. I refuse to answer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Lucita took a step back."*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Romance isn't easy as a royal. You can never tell who truly loves you and who's just grasping for wealth and power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Lucita Azaro: ""I understand completely. That's why it's safest for us n..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still looking for a woman who can handle me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Lucita Azaro: ""Ha. All men think they're hard to handle, until they tur..."*)

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""I understand completely. That's why it's safest for us nobles to marry amongst each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "She and I looked at each other for a long moment."*)

### Węzeł `[387]`
Mówca: **Lucita Azaro**
> ""What makes you think it would be loveless?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Player_Romus: ""I don't much care for discussions about love. What are y..."*)
  - -> `[548]` (*Player_Romus: ""Marriages between royals are political arrangements. Lov..."*)
  - -> `[549]` (*Player_Romus: ""I've never loved a woman up till now. I just don't see i..."*)

### Węzeł `[388]`
Mówca: **Lucita Azaro**
> ""Falling in love is like heading into battle. You've got to know what you're up against, and protect yourself accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Player_Romus: ""I know that now. Next time, I'll be better protected.""*)
  - -> `[536]` (*Player_Romus: ""That's not how it works. You can't fall in love if you'r..."*)
  - -> `[537]` (*Player_Romus: ""I don't much care for discussions about love. What are y..."*)

### Węzeł `[389]`
Mówca: **Lucita Azaro**
> ""Ha. All men think they're hard to handle, until they turn into putty at the sight of a nice pair of--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "She caught herself."*)

### Węzeł `[390]`
Mówca: **Narrator**
> "Lucita took a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Lucita Azaro: ""We're not equals after all, then.""*)

### Węzeł `[392]`
Mówca: **Lucita Azaro**
> ""We're not equals after all, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Lucita Azaro: ""I may as well get to my point.""*)

### Węzeł `[393]`
Mówca: **Narrator**
> "She caught herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Lucita Azaro: ""Pardon my inappropriateness, Your Majesty.""*)

### Węzeł `[394]`
Mówca: **Lucita Azaro**
> ""I may as well get to my point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita/Azaro grievances]"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita/Azaro grievances]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "Lucita/Azaro grievances"*)

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that now. Next time, I'll be better protected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Lucita Azaro: ""Tell the Golden Guard to form a cordon around your heart.""*)

### Węzeł `[397]`
Mówca: **Lucita Azaro**
> ""Pardon my inappropriateness, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player_Romus: ""...Royal orbs?""*)
  - -> `[534]` (*Player_Romus: ""No, you're right. Beautiful women are a weakness of mine.""*)
  - -> `[557]` (*Player_Romus: ""Actually, I find intelligence far more attractive than p..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""...Royal orbs?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1; RiziaDLC.Personal..."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "She and I looked at each other for a long moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Lucita Pales Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Lucita Azaro: ""When I took over my father's position on the Royal Counc..."*)

### Węzeł `[401]`
Mówca: **Lucita Azaro**
> ""I suppose your turning down my request for funding should have been an indication that you didn't trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Player_Romus: ""That had nothing to do with trust. I didn't want to prov..."*)
  - -> `[412]` (*Player_Romus: ""Yes, perhaps it should have been.""*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[413]` (*Player_Romus: ""Enough of this, Duchess. You are on my council to provid..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a gesture of good faith. I will trust you when you get results.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Lucita Azaro: ""We will.""*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust your capabilities. I'm still deciding whether I trust you, personally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Lucita Azaro: ""Well... maybe this will help change your mind.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was only being pragmatic, Duchess. Zille was bombed. Of course we had to investigate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucita Azaro: ""You had other options, and you went with me. I'd like to..."*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That had nothing to do with trust. I didn't want to provoke Wehlen so close to the handover deadline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Lucita Azaro: ""Respectfully, Wehlen doesn't seem to have any intention ..."*)

### Węzeł `[406]`
Mówca: **Lucita Azaro**
> ""Well... maybe this will help change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "We had come to a small grassy patch in the shade of the fortress' southern wall. Lucita gestured for me to sit down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita Pales Talk]"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucita Pales Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "Lucita Pales Talk"*)

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""You had other options, and you went with me. I'd like to think that means something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucita Azaro: ""Regardless, though... there's something you should know.""*)

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""We will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Lucita Azaro: ""In the meantime... there's something else I wanted to te..."*)

### Węzeł `[411]`
Mówca: **Lucita Azaro**
> ""In the meantime... there's something else I wanted to tell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, perhaps it should have been.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Narrator: "She folded her arms and didn't speak for a while. We kept..."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this, Duchess. You are on my council to provide guidance, not complaints.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro), `[401]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Lucita Azaro: ""That's fair, Your Majesty. My apologies.""*)

### Węzeł `[414]`
Mówca: **Lucita Azaro**
> ""That's fair, Your Majesty. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Lucita Azaro: ""On the subject of guidance... there is something you sho..."*)

### Węzeł `[415]`
Mówca: **Lucita Azaro**
> ""On the subject of guidance... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[416]`
Mówca: **Lucita Azaro**
> ""Respectfully, Wehlen doesn't seem to have any intention of meeting that deadline. They could do with a little provocation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Lucita Azaro: ""Wehlen aside... there is something you should know.""*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""Don't take it personally. Titus made a better case.""*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Player_Romus: ""Don't take it personally. I thought both the proposed in..."*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't take it personally. Titus made a better case.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[401]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Lucita Azaro: ""Right. The man whose only qualification is his ability t..."*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't take it personally. I thought both the proposed investigations were a waste of time and money.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Lucita Azaro: ""May I remind you that the deadline for the Zille handove..."*)

### Węzeł `[422]`
Mówca: **Lucita Azaro**
> ""May I remind you that the deadline for the Zille handover has almost passed? Perhaps at least one investigation could have sped up that process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Lucita Azaro: ""But Zille aside... there is something you should know.""*)

### Węzeł `[423]`
Mówca: **Lucita Azaro**
> ""Right. The man whose only qualification is his ability to take a punch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Lucita Azaro: ""The Golden Guard aside... there is something you should ..."*)

### Węzeł `[424]`
Mówca: **Narrator**
> "She folded her arms and didn't speak for a while. We kept walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Lucita Azaro: ""While we are here... there is something you should know.""*)

### Węzeł `[425]`
Mówca: **Lucita Azaro**
> ""While we are here... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[426]`
Mówca: **Lucita Azaro**
> ""Regardless, though... there's something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[427]`
Mówca: **Lucita Azaro**
> ""Wehlen aside... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""The Golden Guard aside... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[429]`
Mówca: **Lucita Azaro**
> ""But Zille aside... there is something you should know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "We had come to a small grassy patch in the shade of the f..."*)

### Węzeł `[430]`
Mówca: **Lucita Azaro**
> ""When I took over my father's position on the Royal Council, he gave me a trove of his old files.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Lucita Azaro: ""Wedged between standard purchase orders and internal sec..."*)

### Węzeł `[431]`
Mówca: **Lucita Azaro**
> ""Wedged between standard purchase orders and internal security reports, I found this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Narrator: "She reached into her pocket and unfolded a thin square of..."*)

### Węzeł `[432]`
Mówca: **Narrator**
> "She reached into her pocket and unfolded a thin square of paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "On it was a map of Pales. Overlaying the outline of the G..."*)

### Węzeł `[433]`
Mówca: **Narrator**
> "On it was a map of Pales. Overlaying the outline of the Grand Duchy were arrows, diagrams of tanks and battalions, and hastily scribbled instructions. Some of them were in my father's handwriting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Lucita Azaro: ""Look at the date. 1949.""*)

### Węzeł `[434]`
Mówca: **Lucita Azaro**
> ""Look at the date. 1949.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player_Romus: ""So they were plotting another attempt on Pales. That's n..."*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[441]` (*Player_Romus: ""Pathetic. The work of two sad, deluded old men.""*)
  - -> `[442]` (*Player_Romus: ""Intriguing. Why didn't my father tell me about this?""*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So they were plotting another attempt on Pales. That's not surprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Lucita Azaro: ""Had this been attempted, it would have been a complete r..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Player_Romus: ""This would never have worked. Not with the military stil..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Player_Romus: ""This is complete gibberish to me.""*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This would never have worked. Not with the military still weakened from the 1920s.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[434]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Lucita Azaro: ""You're absolutely right.""*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is complete gibberish to me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[434]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Lucita Azaro: ""It's a plan to reconquer Pales. One that would have been..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pathetic. The work of two sad, deluded old men.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Lucita Azaro: ""Some of these instructions are actually genius. But it w..."*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Intriguing. Why didn't my father tell me about this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales == true"*)

### Węzeł `[443]`
Mówca: **Lucita Azaro**
> ""Had this been attempted, it would have been a complete rout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""All glory to King Valero, but perhaps it's fortunate tha..."*)

### Węzeł `[444]`
Mówca: **Lucita Azaro**
> ""All glory to King Valero, but perhaps it's fortunate that he died before this could be carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player_Romus: ""How dare you even imply that my father's death was a for..."*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[459]` (*Player_Romus: ""It pains me to say so, but yes. Better that he died rath..."*)
  - -> `[461]` (*Player_Romus: ""Maybe he didn't intend to carry it out. Maybe he wanted ..."*)

### Węzeł `[445]`
Mówca: **Lucita Azaro**
> ""You're absolutely right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""All glory to King Valero, but perhaps it's fortunate tha..."*)

### Węzeł `[446]`
Mówca: **Lucita Azaro**
> ""It's a plan to reconquer Pales. One that would have been futile, at least with the military of the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""All glory to King Valero, but perhaps it's fortunate tha..."*)

### Węzeł `[447]`
Mówca: **Lucita Azaro**
> ""Some of these instructions are actually genius. But it would have been futile with the military of the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""All glory to King Valero, but perhaps it's fortunate tha..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FriendlyToPales == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucita Azaro: ""He thought you'd inform Duke Reinhart, I assume.""*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FriendlyToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Lucita Azaro: ""It was still a work in progress when he died, I assume.""*)

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""He thought you'd inform Duke Reinhart, I assume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Lucita Azaro: ""This plan would have ended in a complete rout. At least ..."*)

### Węzeł `[452]`
Mówca: **Lucita Azaro**
> ""It was still a work in progress when he died, I assume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Lucita Azaro: ""This plan would have ended in a complete rout. At least ..."*)

### Węzeł `[453]`
Mówca: **Lucita Azaro**
> ""This plan would have ended in a complete rout. At least with the military of the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""All glory to King Valero, but perhaps it's fortunate tha..."*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare you even imply that my father's death was a fortunate occurrence? I should have you skinned alive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player_Romus: ""Is it possible that whoever murdered him knew about this..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it possible that whoever murdered him knew about this plan?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[444]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Lucita Azaro: ""If he was murdered, that could have served as a motivati..."*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It pains me to say so, but yes. Better that he died rather than order more soldiers to their deaths.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Lucita Azaro: ""I -- I'm so sorry. I never meant to imply that.""*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe he didn't intend to carry it out. Maybe he wanted me to do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Narrator: "She frowned."*)

### Węzeł `[462]`
Mówca: **Lucita Azaro**
> ""If he was murdered, that could have served as a motivation, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_ProWar == true"*)

### Węzeł `[463]`
Mówca: **Narrator**
> "She frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Lucita Azaro: ""Or the plan was scrapped when they realized it would nev..."*)

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Or the plan was scrapped when they realized it would never work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_ProWar == true"*)

### Węzeł `[465]`
Mówca: **Lucita Azaro**
> ""If he was murdered as you suspect... that could be a motivation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_ProWar == true"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Lucita Azaro: ""If he was murdered as you suspect... that could be a mot..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Lucita Azaro: ""Then again, it's possible they never intended to execute..."*)

### Węzeł `[469]`
Mówca: **Lucita Azaro**
> ""Then again, it's possible they never intended to execute this plan. It could've just been idle daydreaming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_ProWar == true"*)

### Węzeł `[470]`
Mówca: **Lucita Azaro**
> ""I -- I'm so sorry. I never meant to imply that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Lucita Azaro: ""Perhaps he never even intended to execute this, anyway.""*)

### Węzeł `[471]`
Mówca: **Lucita Azaro**
> ""Perhaps he never even intended to execute this, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_ProWar == true"*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His dying wish was for me to take back the lands that were lost. I can't fail him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Kontekst wejściowy (poprzednik):** `[462]` (Lucita Azaro), `[464]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Lucita Azaro: ""Yes, I heard your coronation speech.""*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand why this even exists, though. Why does Rizia need to reconquer Pales?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Pales_ProWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[462]` (Lucita Azaro), `[464]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "Lucita shook her head."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Pales_ProWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Pales_ProWar == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Pales_ProWar == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Pales_ProWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Pales_ProWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Player_Romus: ""The plan doesn't even make sense. I supported the Reclam..."*)
  - -> `[478]` (*Player_Romus: ""I understand why they drew this up, though. I too never ..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Pales_ProWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Pales_ProWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Player_Romus: ""I don't understand why this even exists, though. Why doe..."*)
  - -> `[479]` (*Player_Romus: ""The timing wasn't right to reconquer Pales in the '20s. ..."*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The plan doesn't even make sense. I supported the Reclamation War, but... now? After all these years?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Pales_ProWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[462]` (Lucita Azaro), `[464]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "Lucita shook her head."*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand why they drew this up, though. I too never gave up on reconquering Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Pales_ProWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[462]` (Lucita Azaro), `[464]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Lucita Azaro: ""You and most of my province. The Azaros never got over l..."*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The timing wasn't right to reconquer Pales in the '20s. But perhaps now...""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Pales_ProWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[462]` (Lucita Azaro), `[464]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lucita Azaro: ""You, too?""*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_TakeBackLand == true)"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Player_Romus: ""His dying wish was for me to take back the lands that we..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_TakeBackLand == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Player_Romus: ""His dying wish was for me to take back the lands that we..."*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His dying wish was for me to take back the lands that were lost. But I'm no conqueror.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[462]` (Lucita Azaro), `[464]` (Lucita Azaro), `[465]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Lucita Azaro: ""It's an outdated concept. Invading territories based on ..."*)

### Węzeł `[484]`
Mówca: **Lucita Azaro**
> ""You, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Lucita Azaro: ""My family would be with you, of course. The Azaros never..."*)

### Węzeł `[485]`
Mówca: **Narrator**
> "Lucita shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Lucita Azaro: ""It's an outdated concept. Invading territories based on ..."*)

### Węzeł `[486]`
Mówca: **Lucita Azaro**
> ""Of course, my family would disagree. My province never got over losing our access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Lucita Azaro: ""But I don't see any merit in taking back Pales. At least..."*)

### Węzeł `[487]`
Mówca: **Lucita Azaro**
> ""You and most of my province. The Azaros never got over losing their access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Lucita Azaro: ""But I don't see any merit in taking back Pales. At least..."*)

### Węzeł `[488]`
Mówca: **Lucita Azaro**
> ""It's an outdated concept. Invading territories based on centuries-old grudges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Lucita Azaro: ""Of course, my family would disagree. My province never g..."*)

### Węzeł `[489]`
Mówca: **Lucita Azaro**
> ""Yes, I heard your coronation speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Lucita Azaro: ""My family is with you, of course. The Azaros never got o..."*)

### Węzeł `[490]`
Mówca: **Lucita Azaro**
> ""But I don't see any merit in taking back Pales. At least, not for historic reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player_Romus: ""I'm glad that you're the one who wound up on my council,..."*)
  - -> `[491]` (*Player_Romus: ""Are you saying there are other reasons?""*)
  - -> `[492]` (*Player_Romus: ""I trust your guidance, Duchess. If there's a reason you ..."*)
  - -> `[495]` (*Player_Romus: ""You're lying. You're as thirsty for revenge as the rest ..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying there are other reasons?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "She looked away."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust your guidance, Duchess. If there's a reason you think we should go to war with Pales again, I want to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "She looked away."*)

### Węzeł `[493]`
Mówca: **Lucita Azaro**
> ""My family is with you, of course. The Azaros never got over losing their access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Lucita Azaro: ""But I don't see any merit in taking back Pales. At least..."*)

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""My family would be with you, of course. The Azaros never got over losing their access to the sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Lucita Azaro: ""But I don't see any merit in taking back Pales. At least..."*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lying. You're as thirsty for revenge as the rest of your family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Lucita Azaro: ""I'm a realist, Your Majesty. Revenge has no place in my ..."*)

### Węzeł `[496]`
Mówca: **Narrator**
> "She looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Lucita Azaro: ""I don't want to sound paranoid.""*)

### Węzeł `[497]`
Mówca: **Lucita Azaro**
> ""I don't want to sound paranoid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Lucita Azaro: ""But with Lespia in ATO, and Morella becoming closer to V..."*)

### Węzeł `[498]`
Mówca: **Lucita Azaro**
> ""I'm a realist, Your Majesty. Revenge has no place in my worldview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Lucita Azaro: ""Having said that...""*)

### Węzeł `[499]`
Mówca: **Lucita Azaro**
> ""Having said that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Lucita Azaro: ""With Lespia in ATO, and Morella becoming closer to Valgs..."*)

### Węzeł `[500]`
Mówca: **Lucita Azaro**
> ""But with Lespia in ATO, and Morella becoming closer to Valgsland and the CSP... I do wonder whether our neighbor will get swallowed up in the superpower conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Player_Romus: ""That's ridiculous. It's an inconsequential little strip ..."*)
  - -> `[503]` (*Player_Romus: ""I'm not sure what you're getting at.""*)
  - -> `[504]` (*Player_Romus: ""Hmm. That's a legitimate worry.""*)

### Węzeł `[501]`
Mówca: **Lucita Azaro**
> ""With Lespia in ATO, and Morella becoming closer to Valgsland and the CSP, I do wonder whether our neighbor will get swallowed up in the superpower conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Player_Romus: ""That's ridiculous. It's an inconsequential little strip ..."*)
  - -> `[503]` (*Player_Romus: ""I'm not sure what you're getting at.""*)
  - -> `[504]` (*Player_Romus: ""Hmm. That's a legitimate worry.""*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. It's an inconsequential little strip of land.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Lucita Azaro), `[501]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Lucita Azaro: ""Look at what happened to Wehlen in the 1930s. Arcasia an..."*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure what you're getting at.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Lucita Azaro), `[501]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Lucita Azaro: ""Look at what happened to Wehlen in the 1930s. Arcasia an..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. That's a legitimate worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Lucita Azaro), `[501]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Lucita Azaro: ""Look at what happened to Wehlen in the 1930s. Arcasia an..."*)

### Węzeł `[505]`
Mówca: **Lucita Azaro**
> ""Look at what happened to Wehlen in the 1930s. Arcasia and United Contana nearly destroyed it by proxy in a rush to gain access to its oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Lucita Azaro: ""And now Pales may be sitting on an even more valuable re..."*)

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""And now Pales may be sitting on an even more valuable resource...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Player_Romus: ""Lespia's involvement with Pales is clear. But we haven't..."*)
  - -> `[508]` (*Player_Romus: ""So you think we should conquer Pales for its own good.""*)
  - -> `[518]` (*Player_Romus: ""That's not Pales' resource. It's ours.""*)
  - -> `[520]` (*Player_Romus: ""So? How does that involve Rizia?""*)
  - -> `[509]` (*Player_Romus: ""You're my security councilor, Duchess. I don't want you ..."*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia's involvement with Pales is clear. But we haven't seen any signs that the CSP has designs on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Lucita Azaro: ""Not yet. But with Morella edging closer to Valgsland, th..."*)

### Węzeł `[508]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you think we should conquer Pales for its own good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Lucita Azaro: ""'Conquer' is such an old-fashioned word.""*)

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're my security councilor, Duchess. I don't want you concerning yourself with geopolitics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Lucita Azaro: ""This is a security issue, Your Majesty.""*)

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad that you're the one who wound up on my council, not your hawk of a father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Narrator: "She blanched slightly."*)

### Węzeł `[511]`
Mówca: **Narrator**
> "She blanched slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lucita Azaro: ""My father belongs to a different generation. One that so..."*)

### Węzeł `[512]`
Mówca: **Lucita Azaro**
> ""My father belongs to a different generation. One that solves disputes with brute force, not subtlety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Lucita Azaro: ""I must admit that I harbor concerns about Pales as well,..."*)

### Węzeł `[513]`
Mówca: **Lucita Azaro**
> ""I must admit that I harbor concerns about Pales as well, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Lucita Azaro: ""With Lespia in ATO, and Morella becoming closer to Valgs..."*)

### Węzeł `[514]`
Mówca: **Lucita Azaro**
> ""'Conquer' is such an old-fashioned word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lucita Azaro: ""Think of it as a chess game. Sometimes it's best to remo..."*)

### Węzeł `[515]`
Mówca: **Lucita Azaro**
> ""This is a security issue, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lucita Azaro: ""Think of it as a chess game. Sometimes it's best to remo..."*)

### Węzeł `[516]`
Mówca: **Lucita Azaro**
> ""Not yet. But with Morella edging closer to Valgsland, they might be emboldened to try for a reconquest of their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lucita Azaro: ""Think of it as a chess game. Sometimes it's best to remo..."*)

### Węzeł `[517]`
Mówca: **Lucita Azaro**
> ""Think of it as a chess game. Sometimes it's best to remove certain pieces from the board before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Lucita Azaro: ""That doesn't mean I think we should attack Pales again. ..."*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not Pales' resource. It's ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Lucita Azaro: ""At least part of it belongs to Pales. The researchers ha..."*)

### Węzeł `[519]`
Mówca: **Lucita Azaro**
> ""At least part of it belongs to Pales. The researchers have determined that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lucita Azaro: ""Think of it as a chess game. Sometimes it's best to remo..."*)

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So? How does that involve Rizia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Lucita Azaro: ""The Wehlen Civil War happened before the development of ..."*)

### Węzeł `[521]`
Mówca: **Lucita Azaro**
> ""The Wehlen Civil War happened before the development of nuclear weapons, Your Majesty. Today's superpower conflicts have the potential for far more wide-ranging damage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lucita Azaro: ""Think of it as a chess game. Sometimes it's best to remo..."*)

### Węzeł `[522]`
Mówca: **Lucita Azaro**
> ""That doesn't mean I think we should attack Pales again. Using diplomacy to get them on our side would be a more effective tactic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales == true"*)
  - -> `[527]` (*Player_Romus: ""My war councilor is urging me to practice diplomacy. Now..."*)
  - -> `[530]` (*Player_Romus: ""Diplomatic attempts will only get us so far. At some poi..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that. I've been aiming for diplomacy this entire time.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[522]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Lucita Azaro: ""If we get into a dispute over the new gas field, it may ..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FriendlyToPales == true)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""I know that. I've been aiming for diplomacy this entire ..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FriendlyToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""I disagree. You've just given me one more reason why ret..."*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war councilor is urging me to practice diplomacy. Now I've heard everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Lucita Azaro: ""War should be a last resort, Your Majesty. Contrary to w..."*)

### Węzeł `[528]`
Mówca: **Lucita Azaro**
> ""War should be a last resort, Your Majesty. Contrary to what your or my father would say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Lucita Azaro: ""If you wanted me to, I could send a task force to Pales ..."*)

### Węzeł `[529]`
Mówca: **Lucita Azaro**
> ""If we get into a dispute over the new gas field, it may be more difficult to stay the course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Lucita Azaro: ""If you wanted me to, I could send a task force to Pales ..."*)

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Diplomatic attempts will only get us so far. At some point, force may be needed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Lucita Azaro: ""You may be right. But we should not be the first to init..."*)

### Węzeł `[531]`
Mówca: **Lucita Azaro**
> ""You may be right. But we should not be the first to initiate aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Lucita Azaro: ""If you wanted me to, I could send a task force to Pales ..."*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. You've just given me one more reason why retaking Pales is the best course of action.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[522]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Lucita Azaro: ""I would not presume to contradict you, Your Majesty. But..."*)

### Węzeł `[533]`
Mówca: **Lucita Azaro**
> ""I would not presume to contradict you, Your Majesty. But I urge caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Lucita Azaro: ""If you wanted me to, I could send a task force to Pales ..."*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, you're right. Beautiful women are a weakness of mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "She smiled knowingly."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1; RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;
Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Narrator: "She laughed."*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not how it works. You can't fall in love if you're holding a part of yourself back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Lucita Azaro: ""Giving all of yourself to a lover allows them to have ab..."*)

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't much care for discussions about love. What are your feelings on the Galmish Manifesto?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Lucita Azaro), `[388]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "She didn't blink."*)

### Węzeł `[538]`
Mówca: **Narrator**
> "She laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Lucita Azaro: ""Exactly.""*)

### Węzeł `[539]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Lucita Azaro: ""I should move on to what I wanted to say.""*)

### Węzeł `[540]`
Mówca: **Lucita Azaro**
> ""Giving all of yourself to a lover allows them to have absolute power over you. I refuse to subjugate myself to anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Narrator: "The corner of her mouth twitched."*)

### Węzeł `[541]`
Mówca: **Lucita Azaro**
> ""Tell the Golden Guard to form a cordon around your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "She laughed softly at her own joke."*)

### Węzeł `[542]`
Mówca: **Narrator**
> "She laughed softly at her own joke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Lucita Azaro: ""But we'd better move on to what I wanted to say.""*)

### Węzeł `[543]`
Mówca: **Narrator**
> "The corner of her mouth twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Lucita Azaro: ""Except my king, of course.""*)

### Węzeł `[544]`
Mówca: **Lucita Azaro**
> ""Except my king, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[545]`
Mówca: **Narrator**
> "She didn't blink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Lucita Azaro: ""It seeks to replace the sanctity of order and hierarchy ..."*)

### Węzeł `[546]`
Mówca: **Lucita Azaro**
> ""It seeks to replace the sanctity of order and hierarchy with empty egalitarian illusions. Their leader Halvorsdatir won't hold out till the end of her term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Lucita Azaro: ""But we'd better move on to what I wanted to say.""*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Lucita Azaro: ""But we'd better move on to what I wanted to say.""*)

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Marriages between royals are political arrangements. Love seldom has anything to do with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Lucita Azaro: ""You never know, Your Majesty. You might get lucky.""*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've never loved a woman up till now. I just don't see it happening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Lucita Azaro: ""It's never too late, though, is it?""*)

### Węzeł `[550]`
Mówca: **Lucita Azaro**
> ""It's never too late, though, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[551]`
Mówca: **Lucita Azaro**
> ""You never know, Your Majesty. You might get lucky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "She smiled."*)

### Węzeł `[553]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Lucita Azaro: ""But we'd better move on to what I wanted to say.""*)

### Węzeł `[554]`
Mówca: **Lucita Azaro**
> ""But we'd better move on to what I wanted to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita/Azaro grievances]"*)

### Węzeł `[555]`
Mówca: **Lucita Azaro**
> ""I should move on to what I wanted to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucita/Azaro grievances]"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Lucita Azaro: ""I should move on to what I wanted to say.""*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I find intelligence far more attractive than physical attributes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Narrator: "She smiled politely."*)

### Węzeł `[558]`
Mówca: **Narrator**
> "She smiled knowingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Lucita Azaro: ""Then you'd better remarry quickly, before one takes adva..."*)

### Węzeł `[559]`
Mówca: **Lucita Azaro**
> ""Then you'd better remarry quickly, before one takes advantage of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[560]`
Mówca: **Narrator**
> "She smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Lucita Azaro: ""I'm sure you do.""*)

### Węzeł `[561]`
Mówca: **Lucita Azaro**
> ""I'm sure you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Lucita Azaro: ""I should move on to what I wanted to say.""*)

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Far from it, Duchess. You still remain an inscrutable mystery to me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Narrator: "She smiled."*)

### Węzeł `[564]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Lucita Azaro: ""Fear not, Your Majesty. You'll have plenty of chances to..."*)

### Węzeł `[565]`
Mówca: **Lucita Azaro**
> ""Fear not, Your Majesty. You'll have plenty of chances to learn more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Lucita Azaro: ""But we'd better move on to what I wanted to say.""*)

### Węzeł `[566]`
Mówca: **Lucita Azaro**
> ""If you wanted me to, I could send a task force to Pales to monitor the situation more closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the suggestion. But I'm afraid such an action will be misinterpreted as aggression.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Lucita Azaro), `[308]` (Lucita Azaro), `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Lucita Azaro: ""The idea would be to avoid aggression. But I understand.""*)

### Węzeł `[568]`
**[WYBÓR GRACZA: ""That sounds wise. Do what you need to do." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""That sounds wise. Do what you need to do.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want all our intelligence capabilities concentrated on the Zille incident at the moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Lucita Azaro), `[308]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Lucita Azaro: ""I understand. We'll focus on that going forward.""*)

### Węzeł `[570]`
Mówca: **Lucita Azaro**
> ""The idea would be to avoid aggression. But I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "She began standing up."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respectfully refuse. Our internal security is a lot more pressing right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Lucita Azaro), `[308]` (Lucita Azaro), `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Lucita Azaro: ""I understand. We'll focus on that going forward.""*)

### Węzeł `[572]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[573]`
Mówca: **Lucita Azaro**
> ""I understand. We'll focus on that going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "She began standing up."*)

### Węzeł `[574]`
**[WYBÓR GRACZA: ""That sounds wise. Do what you need to do.""]** — Mówca: **Player_Romus**
> ""That sounds wise. Do what you need to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Lucita Azaro), `[308]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[575]`
Mówca: **Lucita Azaro**
> ""I understand. We'll focus on that going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "She began standing up."*)

### Węzeł `[576]`
Mówca: **Narrator**
> "She began standing up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true"*)
  - -> `[588]` (*Player_Romus: ""Thank you for showing me this. But I must insist you bri..."*)
  - -> `[589]` (*Player_Romus: ""Feel free to throw that map away. It's of no use to me.""*)
  - -> `[580]` (*Player_Romus: ""May I keep that map of Pales?""*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps = true; RiziaDLCSu..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps = true; RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Pales_SendSpecialOps"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "She began standing up."*)

### Węzeł `[579]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate you coming to me with all this. Please feel free to express your unfettered opinions to me in the future.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == true`
- **Kontekst wejściowy (poprzednik):** `[576]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Lucita Azaro: ""You can count on it.""*)

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May I keep that map of Pales?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Montaklar_TookMap = true"*)

### Węzeł `[581]`
Mówca: **Lucita Azaro**
> ""I don't see why not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Narrator: "She handed me the piece of paper. I took a last look at it."*)

### Węzeł `[582]`
Mówca: **Narrator**
> "She handed me the piece of paper. I took a last look at it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Player_Romus: ""I will do everything in my power to prevent conflict wit..."*)
  - -> `[591]` (*Player_Romus: ""I will finish what our fathers started. Even if it takes..."*)
  - -> `[592]` (*Player_Romus: ""I will keep this as a reminder of Valero the Frail's fol..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true"*)
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == t..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Player_Romus: ""I appreciate you coming to me with all this. Please feel..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "Lucita/Azaro grievances"*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Montaklar_LucitaSpeaksMind"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucita Azaro: ""Well, Your Majesty...""*)

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for showing me this. But I must insist you bring up such issues at council meetings in the future. I don't want anyone getting the wrong idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Lucita Azaro: ""Certainly, Your Majesty. I wouldn't presume to demand sp..."*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Feel free to throw that map away. It's of no use to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Lucita Azaro: ""Agreed, Your Majesty. It's a relic of a more reckless age.""*)

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do everything in my power to prevent conflict with Pales. But just in case...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[582]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Lucita Azaro: ""If it does come to that, you'll need a better strategy. ..."*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will finish what our fathers started. Even if it takes my entire reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[582]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Lucita Azaro: ""If you insist on taking that path, you'll have my family..."*)

### Węzeł `[592]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will keep this as a reminder of Valero the Frail's folly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[582]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Lucita Azaro: ""And General Taddeus Azaro's.""*)

### Węzeł `[593]`
Mówca: **Lucita Azaro**
> ""If it does come to that, you'll need a better strategy. Or a better army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Lucita Azaro: ""But speaking of the military...""*)

### Węzeł `[594]`
Mówca: **Lucita Azaro**
> ""If you insist on taking that path, you'll have my family's aid. As well as mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Lucita Azaro: ""But speaking of the military...""*)

### Węzeł `[595]`
Mówca: **Lucita Azaro**
> ""And General Taddeus Azaro's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Lucita Azaro: ""But speaking of the military...""*)

### Węzeł `[596]`
Mówca: **Lucita Azaro**
> ""But speaking of the military...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""It's nearly four. Let me show you something.""*)

### Węzeł `[597]`
Mówca: **Lucita Azaro**
> ""You can count on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""It's nearly four. Let me show you something.""*)

### Węzeł `[598]`
Mówca: **Lucita Azaro**
> ""Certainly, Your Majesty. I wouldn't presume to demand special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""It's nearly four. Let me show you something.""*)

### Węzeł `[599]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. It's a relic of a more reckless age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""It's nearly four. Let me show you something.""*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Montaklar_TookMap = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn03_Montaklar_TookMap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Lucita Azaro: ""I don't see why not.""*)

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't the guards step in? I should have them disciplined at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Lucita Azaro: ""I wasn't expecting their assistance, Your Majesty.""*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me. I wasn't fast enough to help you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Lucita Azaro: ""I wasn't expecting your assistance, Your Majesty.""*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God you're unharmed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator), `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[604]`
Mówca: **Lucita Azaro**
> ""I wasn't expecting your assistance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Lucita Azaro: ""There's only one person I rely on for protection. Me.""*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Lucita Azaro: ""God has nothing to do with it.""*)

### Węzeł `[606]`
Mówca: **Lucita Azaro**
> ""God has nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Lucita Azaro: ""There's only one person I rely on for protection. Me.""*)

### Węzeł `[607]`
Mówca: **Lucita Azaro**
> ""There's only one person I rely on for protection. Me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "She swiftly turned her back on me and told the guards it ..."*)

### Węzeł `[608]`
Mówca: **Lucita Azaro**
> ""I wasn't expecting their assistance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Lucita Azaro: ""There's only one person I rely on for protection. Me.""*)

### Węzeł `[609]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was the purpose of the uprising. To show us that our blood doesn't make us special.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[610]`
Mówca: **Lucita Azaro**
> ""I joined the military so I'd never get caught by surprise like that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_LucitaPersonalQs_Career = true"*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Lucita Azaro: ""All it showed me was that I had to be prepared to defend..."*)

### Węzeł `[612]`
Mówca: **Lucita Azaro**
> ""All it showed me was that I had to be prepared to defend myself at a moment's notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucita Azaro: ""I joined the military so I'd never get caught by surpris..."*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplete = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Caleqabiz_GasSurveyComplete"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[614]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps = true; RiziaDLCSu..."*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player_Romus: ""That sounds wise. Do what you need to do." [-1 Budget]"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Player_Romus: ""Sorry but we don't have extra funds to spare.""*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 2"*)
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 2)"*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Player_Romus: ""I'll make sure you'll get what the help you need without..."*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[621]`
**[WYBÓR GRACZA: ""I'll make sure you'll get what the help you need without the extra funds. Do what you need to do." [-2 Authority]"]** — Mówca: **Player_Romus**
> ""I'll make sure you'll get what the help you need without the extra funds. Do what you need to do.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority -= 2"*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps = true; RiziaDLCSu..."*)

### Węzeł `[623]`
**[WYBÓR GRACZA: ""Sorry but we don't have extra funds to spare.""]** — Mówca: **Player_Romus**
> ""Sorry but we don't have extra funds to spare.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Lucita Azaro: ""I understand.""*)

### Węzeł `[624]`
Mówca: **Lucita Azaro**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Narrator: "She began standing up."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CameraShutter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CameraShutter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CameraShutter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CameraShutter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Lucita Azaro: ""I joined the military so I'd never get caught by surpris..."*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucita Azaro: ""And you didn't feel the drive to do something about it? ..."*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true"*)
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Lucita Azaro: ""And considering the provincial leaders no longer command..."*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Lucita Azaro: ""As long as the provincial police system exists, Iza shou..."*)

### Węzeł `[633]`
Mówca: **Lucita Azaro**
> ""And considering the provincial leaders no longer command their own police forces... it seems to me like you're granting Ricardus a special favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""House Toras takes care of its own. If I do grant special..."*)
  - -> `[26]` (*Player_Romus: ""You don't understand. Iza is at a tipping point. The cit..."*)
  - -> `[636]` (*Player_Romus: ""You can send more police to Cardesse-Montaklar if you li..."*)
  - -> `[640]` (*Player_Romus: ""Just give Rico some time. If he can't get Iza under cont..."*)

### Węzeł `[634]`
Mówca: **Lucita Azaro**
> ""As long as the provincial police system exists, Iza should be receiving help from Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""My family comes first, Duchess. You have to respect that.""*)
  - -> `[638]` (*Player_Romus: ""Brenas won't help him. House Sazon is practically laughi..."*)
  - -> `[640]` (*Player_Romus: ""Just give Rico some time. If he can't get Iza under cont..."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lucita Azaro: ""I beg your pardon, Your Majesty, but Rizia's internal se..."*)

### Węzeł `[636]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can send more police to Cardesse-Montaklar if you like. I won't stop you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[633]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Lucita Azaro: ""That's not the point.""*)

### Węzeł `[637]`
Mówca: **Lucita Azaro**
> ""That's not the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "She sighed."*)

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Brenas won't help him. House Sazon is practically laughing in his face.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[634]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Lucita Azaro: ""Then we ought to force them into line.""*)

### Węzeł `[639]`
Mówca: **Lucita Azaro**
> ""Then we ought to force them into line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "She sighed."*)

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just give Rico some time. If he can't get Iza under control with these extra reinforcements, I'll take them away again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[633]` (Lucita Azaro), `[634]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Narrator: "She nodded, not entirely convinced."*)

### Węzeł `[641]`
Mówca: **Narrator**
> "She nodded, not entirely convinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Lucita Azaro: ""I will not question you any further about this. But ther..."*)

### Węzeł `[642]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Lucita Azaro: ""I will not question you any further about this. But ther..."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Lucita Azaro: ""I am curious why you decided to remove the provincial le..."*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""My house and I had questions regarding your recent meeti..."*)

### Węzeł `[646]`
Mówca: **Lucita Azaro**
> ""I am curious why you decided to remove the provincial levy system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Lucita Azaro: ""Do you have reason to believe the royal houses should no..."*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you'd be pleased with this decision. A completely centralized military means more troops under your direct command.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Narrator: "She half-smiled."*)

### Węzeł `[648]`
Mówca: **Lucita Azaro**
> ""Do you have reason to believe the royal houses should not be entrusted with their own armies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Player_Romus: ""I thought you'd be pleased with this decision. A complet..."*)
  - -> `[649]` (*Player_Romus: ""I believe certain houses can be trusted and certain othe..."*)
  - -> `[650]` (*Player_Romus: ""Sorry, but the provincial armies were a potential threat..."*)
  - -> `[653]` (*Player_Romus: ""That is strictly confidential. I'd rather not discuss it..."*)

### Węzeł `[649]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe certain houses can be trusted and certain others can't. But it would have raised too much suspicion to remove the levies in only one province.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Lucita Azaro: ""I see...""*)

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but the provincial armies were a potential threat to my power as King. They had to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1; RiziaDLC.Relations_Lu..."*)

### Węzeł `[651]`
Mówca: **Lucita Azaro**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Lucita Azaro: ""I must tell you House Azaro wasn't happy with this direc..."*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.Relations_Lucita_Romance -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Narrator: "She frowned in disappointment."*)

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is strictly confidential. I'd rather not discuss it with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1;"*)

### Węzeł `[654]`
Mówca: **Lucita Azaro**
> ""I'm sorry you felt that way. I know your father considered the Azaro special forces among his most valuable military assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Lucita Azaro: ""And I hope you believe me when I say the Azaros will nev..."*)

### Węzeł `[655]`
Mówca: **Narrator**
> "She half-smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Lucita Azaro: ""As a councilor, I'm honored. As the Duchess of this prov..."*)

### Węzeł `[656]`
Mówca: **Lucita Azaro**
> ""As a councilor, I'm honored. As the Duchess of this province, I am skeptical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Lucita Azaro: ""The Azaro army had a long, proud tradition of defending ..."*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Lucita Azaro: ""You'd rather not discuss significant security matters......"*)

### Węzeł `[658]`
Mówca: **Lucita Azaro**
> ""You'd rather not discuss significant security matters... with your security councilor. I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Lucita Azaro: ""Well, perhaps you're willing to discuss this.""*)

### Węzeł `[659]`
Mówca: **Lucita Azaro**
> ""Well, perhaps you're willing to discuss this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""My house and I had questions regarding your recent meeti..."*)

### Węzeł `[660]`
Mówca: **Lucita Azaro**
> ""I must tell you House Azaro wasn't happy with this directive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Lucita Azaro: ""The Azaro army had a long, proud tradition of defending ..."*)

### Węzeł `[661]`
Mówca: **Lucita Azaro**
> ""The Azaro army had a long, proud tradition of defending Rizia and its monarch. Their skill and dedication were unlike anything else in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Player_Romus: ""And they will be just as skillfull and dedicated serving..."*)
  - -> `[663]` (*Player_Romus: ""Exactly. If such a formidable force ever were to turn ag..."*)
  - -> `[664]` (*Player_Romus: ""That's the problem. Your house was making the rest of ar..."*)
  - -> `[671]` (*Player_Romus: ""Yes, and I am truly sad to see it go. But greater things..."*)

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And they will be just as skillfull and dedicated serving directly under the Crown. Won't they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Narrator: "She frowned reluctantly."*)

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. If such a formidable force ever were to turn against their King, the consequences would be catastrophic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Lucita Azaro: ""I'm disappointed you think that would even be a possibil..."*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the problem. Your house was making the rest of army look weak by comparison. Such greatness needs to be dispersed through the entire Armed Forces, not concentrated in one province.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "She gave a short laugh."*)

### Węzeł `[665]`
Mówca: **Narrator**
> "She frowned reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Lucita Azaro: ""Yes. I'll see to that.""*)

### Węzeł `[666]`
Mówca: **Lucita Azaro**
> ""Yes. I'll see to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""Speaking of provincial activities...""*)

### Węzeł `[667]`
Mówca: **Lucita Azaro**
> ""I'm disappointed you think that would even be a possibility, Your Majesty. Your father considered the Azaro special forces among his most valuable military assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Lucita Azaro: ""But you are not King Valero. I understand.""*)

### Węzeł `[669]`
Mówca: **Lucita Azaro**
> ""But you are not King Valero. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""Speaking of provincial activities...""*)

### Węzeł `[670]`
Mówca: **Narrator**
> "She frowned in disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Lucita Azaro: ""I'm sorry you felt that way. I know your father consider..."*)

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I am truly sad to see it go. But greater things are on the horizon for Rizia's armies. You'll see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Lucita Azaro: ""Whatever you have in store, I hope I'll be the first to ..."*)

### Węzeł `[672]`
Mówca: **Narrator**
> "She gave a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Lucita Azaro: ""That's very kind of you. I'll try to convey that reasoni..."*)

### Węzeł `[673]`
Mówca: **Lucita Azaro**
> ""That's very kind of you. I'll try to convey that reasoning to my relatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""Speaking of provincial activities...""*)

### Węzeł `[674]`
Mówca: **Lucita Azaro**
> ""And I hope you believe me when I say the Azaros will never pose a threat to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Lucita Azaro: ""On the other hand...""*)

### Węzeł `[675]`
Mówca: **Lucita Azaro**
> ""On the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""My house and I had questions regarding your recent meeti..."*)

### Węzeł `[676]`
Mówca: **Lucita Azaro**
> ""Whatever you have in store, I hope I'll be the first to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""My house and I had questions regarding your recent meeti..."*)

### Węzeł `[677]`
Mówca: **Lucita Azaro**
> ""I will not question you any further about this. But there's something else that's been bothering me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CameraShutter");"*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "The smile was still on her face as we left the fortress."*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Visiting Fortress Azaro with their Military Councillor", "Montaklar", "Province of Cardesse-Montaklar");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Visiting Fortress Azaro with their Military Councillor","Montaklar","Province of Cardesse-Montaklar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucita Azaro: ""It seems old habits die hard. Thank you, Your Majesty.""*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. But while we're on the subject... isn't there anything you'd like to know about me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Lucita Azaro: ""Now that you mention it...""*)
