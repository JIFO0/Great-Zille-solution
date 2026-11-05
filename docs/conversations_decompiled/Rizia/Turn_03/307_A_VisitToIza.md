# Rizia/Turn 3/A_VisitToIza

- **ID konwersacji:** `307`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/307_A_VisitToIza.md`
- **Liczba węzłów dialogowych:** 743
- **Liczba wyborów gracza:** 156

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[90]** Bruno
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_FamilyStatues_KingValero`
- `RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus`
- `RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO`
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Relations_Vina_TookBookAway`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn02_Hunting_KA74`
- `RiziaDLCIsolated.Turn02_Hunting_Rifle`
- `RiziaDLCIsolated.Turn02_Hunting_ShootToMiss`
- `RiziaDLCIsolated.Turn03_Iza_SawStatues`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.DeployedSO`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.FundedSO`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Rico_ShotDog`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn02_Hunting_KA74`
- `RiziaDLCIsolated.Turn02_Hunting_Rifle`
- `RiziaDLCIsolated.Turn02_Hunting_ShootToMiss`
- `RiziaDLCIsolated.Turn03_Iza_SawStatues`
- `RiziaDLCSupport.Journal_Turn03_Iza_AdoptBruno`
- `RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats`
- `RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO`
- `RiziaDLCSupport.News_RH_Turn03_Gossip_BrunoAdopted`
- `RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **""Go away! I hate dogs!""** | `[12]` **Narrator**: "We walked up to the doors. As so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Rico Toras**: ""Bella! Bruno! Sit."" |
| `[14]` | **"Pet the dogs."** | `[12]` **Narrator**: "We walked up to the doors. As so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Rico Toras**: ""Bella! Bruno! Sit."" |
| `[15]` | **""Easy there, puppies.""** | `[12]` **Narrator**: "We walked up to the doors. As so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Rico Toras**: ""Bella! Bruno! Sit."" |
| `[16]` | **""Stay back, Vina. They might be dangerous.""** | `[12]` **Narrator**: "We walked up to the doors. As so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Rico Toras**: ""Bella! Bruno! Sit."" |
| `[19]` | **""Greetings, Your Grace.""** | `[11]` **Rico Toras**: ""Welcome, my cousins! It has bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Rico Toras**: ""I trust Father informed you of ..." |
| `[20]` | **""So it has, Rico. You're looking sporty.""** | `[11]` **Rico Toras**: ""Welcome, my cousins! It has bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Rico Toras**: ""Did Father not tell you? We're ..." |
| `[24]` | **""I wish we were seeing each other under more pleasant circumstances.""** | `[11]` **Rico Toras**: ""Welcome, my cousins! It has bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Rico Toras**: ""What do you mean? An afternoon ..." |
| `[25]` | **""I enjoyed hunting with you as a child. But I prefer more intellectual pursuits now.""** | `[22]` **Hugo Toras**: ""Your first hunt as king. I want..." | `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true` | *Brak zmian stanu* | `[36]` **Hugo Toras**: ""Hunting requires a keen eye and..." |
| `[26]` | **""A welcome surprise indeed. It's been ages since I shot something.""** | `[22]` **Hugo Toras**: ""Your first hunt as king. I want..." | `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true` | *Brak zmian stanu* | `[38]` **Rico Toras**: ""You'll be glad to know the tech..." |
| `[27]` | **""You know how much I love hunting. But I wanted to have a serious discussion.""** | `[22]` **Hugo Toras**: ""Your first hunt as king. I want..." | `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true` | *Brak zmian stanu* | `[35]` **Hugo Toras**: ""We'll have plenty of chances fo..." |
| `[28]` | **""You could've warned us about the canine welcoming committee.""** | `[11]` **Rico Toras**: ""Welcome, my cousins! It has bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Rico Toras**: ""Bella and Bruno wouldn't hurt a..." |
| `[32]` | **""I appreciate it. But I was hoping the four of us could have a serious conversation.""** | `[22]` **Hugo Toras**: ""Your first hunt as king. I want..." | `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false` | *Brak zmian stanu* | `[35]` **Hugo Toras**: ""We'll have plenty of chances fo..." |
| `[33]` | **""You know me too well. Let's go shoot something!""** | `[22]` **Hugo Toras**: ""Your first hunt as king. I want..." | `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false` | *Brak zmian stanu* | `[44]` **Rico Toras**: ""As His Majesty proclaims, so it..." |
| `[34]` | **""It's a barbaric sport. I prefer more intellectual pursuits.""** | `[22]` **Hugo Toras**: ""Your first hunt as king. I want..." | `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false` | *Brak zmian stanu* | `[36]` **Hugo Toras**: ""Hunting requires a keen eye and..." |
| `[47]` | **""I want a KA-74, same as Rico.""** | `[46]` **Hugo Toras**: ""We have outfits prepared for th..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Hunting boars with machine guns","Iza Fo...`<br>`Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] = true;` | `[49]` **Rico Toras**: ""See, Father? We'll have bagged ..." |
| `[48]` | **""It'll be a good old-fashioned rifle for me.""** | `[46]` **Hugo Toras**: ""We have outfits prepared for th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] = true;` | `[51]` **Narrator**: "Hugo smirked at his son." |
| `[62]` | **""Don't forget to whom you are speaking, Duke Toras. Count yourself lucky I haven't..."** | `[58]` **Rico Toras**: ""I remember a time when you were..."<br>`[63]` **Rico Toras**: ""I knew you didn't approve of th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Rico Toras**: ""Of course, of course. Forgive me."" |
| `[64]` | **""I had no other choice. I'm trying to avoid an international incident.""** | `[58]` **Rico Toras**: ""I remember a time when you were..."<br>`[63]` **Rico Toras**: ""I knew you didn't approve of th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Rico Toras**: ""Well, I humbly request that you..." |
| `[66]` | **""Wehlen has every reason to suspect Su Omina's involvement in what happened. As do..."** | `[58]` **Rico Toras**: ""I remember a time when you were..."<br>`[63]` **Rico Toras**: ""I knew you didn't approve of th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Rico Toras**: ""Trust me, nobody I know has a c..." |
| `[69]` | **""I don't need names. The investigation will turn up the truth.""** | `[340]` **Rico Toras**: ""If one or two of them were to c..." | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]` | *Brak zmian stanu* | `[349]` **Rico Toras**: ""In time to get Zille back by th..." |
| `[70]` | **""A bold suggestion, Your Grace.""** | `[340]` **Rico Toras**: ""If one or two of them were to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Rico Toras**: ""Would you expect anything less ..." |
| `[75]` | **""Just between us... did Su Omina plan the attack?""** | `[413]` **Rico Toras**: ""I know the Wehzeks were pressur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Rico Toras**: ""That's the funny thing. Nobody ..." |
| `[77]` | **""A false flag if I ever saw one. Wehlen obviously planned the bombing.""** | `[413]` **Rico Toras**: ""I know the Wehzeks were pressur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Rico Toras**: ""Killing a few of their own mean..." |
| `[78]` | **""No need to thank me. I was protecting myself as well.""** | `[413]` **Rico Toras**: ""I know the Wehzeks were pressur..." | `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true` | *Brak zmian stanu* | `[90]` **Rico Toras**: ""Nonetheless, I appreciate it. E..." |
| `[79]` | **""What choice did I have? Members of our house must stand by each other.""** | `[413]` **Rico Toras**: ""I know the Wehzeks were pressur..." | `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false) == false` | *Brak zmian stanu* | `[90]` **Rico Toras**: ""Nonetheless, I appreciate it. E..." |
| `[81]` | **""Have you no compassion, son? Those are human beings who died.""** | `[80]` **Rico Toras**: ""Killing a few of their own mean..."<br>`[414]` **Rico Toras**: ""Although we weren't sorry to he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Narrator**: "Rico contorted his mouth into an..." |
| `[82]` | **""Halaita. If it is said, so it is.""** | `[80]` **Rico Toras**: ""Killing a few of their own mean..."<br>`[414]` **Rico Toras**: ""Although we weren't sorry to he..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[415]` **Narrator**: "Rico smirked." |
| `[83]` | **""Watch your mouth. It's that kind of language that made Wehlen suspect Su Omina in..."** | `[80]` **Rico Toras**: ""Killing a few of their own mean..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Rico Toras**: ""It's just us here in this car, ..." |
| `[95]` | **""I suspect the Golden Guard investigation I ordered will be the main topic of disc..."** | `[94]` **Vina Toras**: ""Hugo's meeting us here too, rig..." | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[103]` **Vina Toras**: ""I can't even remember the last ..." |
| `[96]` | **""I have my guesses. We'll see if they're right.""** | `[94]` **Vina Toras**: ""Hugo's meeting us here too, rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Vina Toras**: ""I can't even remember the last ..." |
| `[97]` | **""To see something like those statues, I wager. Give us an inkling of the pressure ..."** | `[94]` **Vina Toras**: ""Hugo's meeting us here too, rig..." | `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true` | *Brak zmian stanu* | `[103]` **Vina Toras**: ""I can't even remember the last ..." |
| `[98]` | **""The family hasn't been all together in ages. It's about time.""** | `[94]` **Vina Toras**: ""Hugo's meeting us here too, rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Vina Toras**: ""I can't even remember the last ..." |
| `[102]` | **""The invitation coming so soon after the Zille incident is no coincidence.""** | `[94]` **Vina Toras**: ""Hugo's meeting us here too, rig..." | `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[103]` **Vina Toras**: ""I can't even remember the last ..." |
| `[107]` | **""Actually, I was hoping *I* could escort my daughter on her first hunt.""** | `[115]` **Narrator**: "He extended his hand to my daugh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "Hugo smoothly stepped between us." |
| `[109]` | **""Go ahead, Vina. I hear Rico is an excellent shot.""** | `[115]` **Narrator**: "He extended his hand to my daugh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "Vina took Rico's hand. With a sm..." |
| `[110]` | **""It's not my decision. Do you want to go with him, Vina?""** | `[115]` **Narrator**: "He extended his hand to my daugh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Vina Toras**: ""Why not? I've had enough father..."<br>`[220]` **Vina Toras**: ""Yes, I'd love to. We didn't eve..." |
| `[136]` | **""Why were you so keen that he and Vina go off together?""** | `[135]` **Hugo Toras**: ""I may not like Rico's hunting m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "He calmly adjusted his rifle's s..." |
| `[137]` | **""Rico's a shrewd kid. Takes after his father.""** | `[135]` **Hugo Toras**: ""I may not like Rico's hunting m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Hugo Toras**: ""You're too kind."" |
| `[140]` | **""It's up to Vina to choose her own husband. And I doubt her cousin ranks high on t..."** | `[515]` **Hugo Toras**: ""Or have you seriously never con..." | `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true` | *Brak zmian stanu* | `[504]` **Hugo Toras**: ""Her cousin once removed."" |
| `[145]` | **""Of course I have. But the two of them turned out as different as night and day.""** | `[515]` **Hugo Toras**: ""Or have you seriously never con..." | `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false` | *Brak zmian stanu* | `[503]` **Hugo Toras**: ""And yet night and day are insep..." |
| `[146]` | **""Shockingly enough, the thought never crossed my mind.""** | `[513]` **Hugo Toras**: ""So you'll consider him as a mar..."<br>`[515]` **Hugo Toras**: ""Or have you seriously never con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Hugo Toras**: ""That is indeed shocking, Your M..." |
| `[147]` | **""I might have if your son were more of a gentleman.""** | `[515]` **Hugo Toras**: ""Or have you seriously never con..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[149]` **Hugo Toras**: ""Choose your words carefully, Yo..." |
| `[153]` | **"Shoot a boar."** | `[525]` **Narrator**: "Looking through my gun sight, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "As I gripped the KA-74, my milit..."<br>`[167]` **Narrator**: "The largest boar fell to the gro..."<br>*(oraz 4 innych odgałęzień)* |
| `[154]` | **"Miss intentionally."** | `[525]` **Narrator**: "Looking through my gun sight, I ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] =...` | `[188]` **Narrator**: "My shot went just wide of where ..."<br>`[166]` **Narrator**: "I struggled to keep the gun stea..."<br>*(oraz 1 innych odgałęzień)* |
| `[211]` | **""You will refer to me as 'Your Majesty'.""** | `[210]` **Rico Toras**: ""What the hell, cousin? You shot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Rico Toras**: ""Excuse me. His Majesty King Rom..." |
| `[212]` | **""It's not my fault. I was aiming for the boar.""** | `[210]` **Rico Toras**: ""What the hell, cousin? You shot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Rico Toras**: ""Next time, aim at your own fuck..." |
| `[213]` | **""It's a scratch. He'll be fine.""** | `[210]` **Rico Toras**: ""What the hell, cousin? You shot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Rico Toras**: ""He can't hunt on three fucking ..." |
| `[214]` | **""It was my first time with a KA-74. I got flustered.""** | `[210]` **Rico Toras**: ""What the hell, cousin? You shot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Rico Toras**: ""You don't fucking say!"" |
| `[230]` | **""Vina is your intellectual superior in every way, you twit. You will apologize to ..."** | `[229]` **Rico Toras**: ""I'm afraid your daughter didn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Narrator**: "He seemed to collect himself for..." |
| `[244]` | **""You've done well enough for all four of us. Congratulations.""** | `[229]` **Rico Toras**: ""I'm afraid your daughter didn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "He seemed to collect himself for..." |
| `[245]` | **""Vina, we're guests here in Iza. Apologize to Rico now.""** | `[229]` **Rico Toras**: ""I'm afraid your daughter didn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Narrator**: "Vina looked sullenly at the ground." |
| `[249]` | **""Yes, you two go on. I'm truly sorry, Rico.""** | `[248]` **Narrator**: "My uncle gave me a meaningful gl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Narrator**: "Rico seemed to collect himself f..." |
| `[250]` | **""Actually, Hugo should go with you. I'll travel with the princess.""** | `[248]` **Narrator**: "My uncle gave me a meaningful gl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "Rico seemed like he was about to..." |
| `[280]` | **""Yes, go ahead. One last chance for you two to have a civil conversation before we..."** | `[279]` **Narrator**: "Vina gave me a pleading look." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[284]` **Narrator**: "Vina grimaced at me as Rico led ..." |
| `[281]` | **""Why don't you go with your son, Hugo? I'll accompany the princess.""** | `[279]` **Narrator**: "Vina gave me a pleading look." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "Hugo raised an eyebrow." |
| `[303]` | **""I'll ride with Duke Rico. I have much to discuss with him.""** | `[52]` **Narrator**: "Inside, Vina and I quickly refre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Narrator**: "Rico nodded. An aide held the do..." |
| `[304]` | **""Vina, care to share a car with your old man?""** | `[52]` **Narrator**: "Inside, Vina and I quickly refre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Narrator**: "Rico swiftly interjected." |
| `[305]` | **""Hugo, shall we ride together and let the children catch up?""** | `[52]` **Narrator**: "Inside, Vina and I quickly refre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Narrator**: "Rico swiftly interjected." |
| `[314]` | **""Halaita. If it is said, so it is.""** | `[313]` **Rico Toras**: ""Though I can't say I wasn't hap..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[321]` **Rico Toras**: ""We were all thinking it."" |
| `[315]` | **""For heaven's sake, son, have some respect for the dead.""** | `[313]` **Rico Toras**: ""Though I can't say I wasn't hap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Rico Toras**: ""Excuse me. Your Majesty."" |
| `[316]` | **""You'll get what's coming to you if you carry on with that kind of talk.""** | `[313]` **Rico Toras**: ""Though I can't say I wasn't hap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Rico Toras**: ""Excuse me. Your Majesty."" |
| `[318]` | **""So you want me to believe your organization is completely innocent?""** | `[313]` **Rico Toras**: ""Though I can't say I wasn't hap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Rico Toras**: ""In Wehlen? Yes."" |
| `[333]` | **""How?""** | `[330]` **Rico Toras**: ""But if you want this mess clear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Narrator**: "He cleared his throat." |
| `[334]` | **""I still don't believe you.""** | `[330]` **Rico Toras**: ""But if you want this mess clear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Rico Toras**: ""Regardless..."" |
| `[335]` | **""In exchange for what?""** | `[330]` **Rico Toras**: ""But if you want this mess clear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Rico Toras**: ""Aside from getting your Golden ..."<br>`[740]` **Rico Toras**: ""Do you really think I'd dare to..." |
| `[344]` | **""So you're offering to commit a crime on my behalf.""** | `[340]` **Rico Toras**: ""If one or two of them were to c..." | `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]) == false` | *Brak zmian stanu* | `[350]` **Rico Toras**: ""I'm not offering anything. Just..." |
| `[345]` | **""Wehlen's investigators aren't stupid. They'd uncover the truth.""** | `[340]` **Rico Toras**: ""If one or two of them were to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Rico Toras**: ""Not if the truth is that Wehlen..." |
| `[351]` | **""Just how loyal are these scapegoats you're proposing? Would they crack under inte..."** | `[71]` **Rico Toras**: ""Would you expect anything less ..."<br>`[348]` **Rico Toras**: ""By handing over my men, we'd be..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Rico Toras**: ""Trust me, cousin. If it came do..." |
| `[352]` | **""And the fact that this would put a premature end to my investigation into Su Omin..."** | `[71]` **Rico Toras**: ""Would you expect anything less ..."<br>`[348]` **Rico Toras**: ""By handing over my men, we'd be..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[363]` **Rico Toras**: ""And you as well. Don't forget y..."<br>`[364]` **Rico Toras**: ""And you as well. Don't forget t..." |
| `[356]` | **""I appreciate the gesture. But I can't condone this.""** | `[71]` **Rico Toras**: ""Would you expect anything less ..."<br>`[348]` **Rico Toras**: ""By handing over my men, we'd be..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Rico Toras**: ""Understood, Your Majesty."" |
| `[357]` | **""I don't care how long it takes. I won't stoop to the kind of tactics you're sugge..."** | `[349]` **Rico Toras**: ""In time to get Zille back by th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Rico Toras**: ""I-- Understood, Your Majesty."" |
| `[358]` | **""It *would* be convenient to put this incident behind us as fast as possible.""** | `[71]` **Rico Toras**: ""Would you expect anything less ..."<br>`[348]` **Rico Toras**: ""By handing over my men, we'd be..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Rico Toras**: ""Just say the word, cousin."" |
| `[369]` | **""That's not code, Rico. Come forth with false suspects, and I'll have your head.""** | `[366]` **Narrator**: "He winked." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Rico Toras**: ""Oh."" |
| `[370]` | **""*If* it were to emerge that said suspects were lying, the order for them to come ..."** | `[359]` **Rico Toras**: ""Trust me, cousin. If it came do..."<br>`[363]` **Rico Toras**: ""And you as well. Don't forget y..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Rico Toras**: ""Of course."" |
| `[377]` | **""Then we have an understanding.""** | `[371]` **Rico Toras**: ""Of course."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true; ...` | `[375]` **Narrator**: "Rico nodded solemnly." |
| `[378]` | **""Actually, no. I won't go along with this plan. Your organization must be held acc..."** | `[371]` **Rico Toras**: ""Of course."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Rico Toras**: ""I-- well within your right, You..." |
| `[382]` | **""Very well, Your Grace. Let's try this your way.""** | `[359]` **Rico Toras**: ""Trust me, cousin. If it came do..."<br>`[363]` **Rico Toras**: ""And you as well. Don't forget y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Rico Toras**: ""I-- thank you, Your Majesty."" |
| `[383]` | **""I can't believe I'm even entertaining this thought. The answer is no.""** | `[359]` **Rico Toras**: ""Trust me, cousin. If it came do..."<br>`[363]` **Rico Toras**: ""And you as well. Don't forget y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Rico Toras**: ""I-- Understood, Your Majesty."" |
| `[389]` | **""If there's anything else you'd like to bring up with your king, now is the time.""** | `[374]` **Narrator**: "Rico looked away for a moment. T..."<br>`[388]` **Narrator**: "We drove on. The woods around us..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Narrator**: "Rico eagerly turned back toward me." |
| `[390]` | **""How are you faring as Duke of Iza, my cousin? Be honest.""** | `[374]` **Narrator**: "Rico looked away for a moment. T..."<br>`[388]` **Narrator**: "We drove on. The woods around us..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Narrator**: "Rico eagerly turned back toward me." |
| `[393]` | **""The headless statues.""** | `[72]` **Rico Toras**: ""The drugs, the violence, the op..." | `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true` | *Brak zmian stanu* | `[397]` **Rico Toras**: ""You weren't supposed to see tho..." |
| `[394]` | **""You're not a child, Rico. Pull yourself together and become the leader this city ..."** | `[72]` **Rico Toras**: ""The drugs, the violence, the op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Rico Toras**: ""I'm trying. But I can't do it w..." |
| `[395]` | **""It doesn't seem that bad to me.""** | `[72]` **Rico Toras**: ""The drugs, the violence, the op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Rico Toras**: ""Sooner or later, it will add up..." |
| `[396]` | **""It's concerning indeed. What can I do to help?""** | `[72]` **Rico Toras**: ""The drugs, the violence, the op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Rico Toras**: ""I'm glad you asked."" |
| `[403]` | **""Rightly so. You should be cooperating with the greater province of Brenas.""** | `[402]` **Rico Toras**: ""I've petitioned your War and Se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Rico Toras**: ""You mean with the Sazons?"" |
| `[404]` | **""So you're using your family connections to go over her head.""** | `[402]` **Rico Toras**: ""I've petitioned your War and Se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Rico Toras**: ""Well... yes. I don't see anothe..." |
| `[405]` | **""She made a mistake. The Brenas police cannot be counted on to help you keep the p..."** | `[402]` **Rico Toras**: ""I've petitioned your War and Se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Rico Toras**: ""If anything, they are actively ..." |
| `[417]` | **""I'm not sure I believe that.""** | `[90]` **Rico Toras**: ""Nonetheless, I appreciate it. E..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Rico Toras**: ""You don't have to. But I'm tell..." |
| `[418]` | **""It's clearly a ruse planned by the Wehzeks themselves.""** | `[90]` **Rico Toras**: ""Nonetheless, I appreciate it. E..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Rico Toras**: ""They'll be exposed soon enough...." |
| `[419]` | **""They're upstanding citizens. I can't imagine they would stoop to violence.""** | `[90]` **Rico Toras**: ""Nonetheless, I appreciate it. E..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Rico Toras**: ""No, sir."" |
| `[429]` | **""I hope you're not still planning on going through with that.""** | `[426]` **Rico Toras**: ""Just prior to the incident, we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Rico Toras**: ""Why shouldn't we?"" |
| `[430]` | **""What do you mean, 'activate?'""** | `[426]` **Rico Toras**: ""Just prior to the incident, we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Rico Toras**: ""The region is teeming with Rizi..." |
| `[431]` | **""That would have been an idiotic thing to do without the King's permission.""** | `[426]` **Rico Toras**: ""Just prior to the incident, we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Rico Toras**: ""The region is teeming with Rizi..." |
| `[432]` | **""To what end, precisely?""** | `[426]` **Rico Toras**: ""Just prior to the incident, we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Rico Toras**: ""The region is teeming with Rizi..." |
| `[436]` | **""I can't condone this, Rico.""** | `[438]` **Rico Toras**: ""Of course anyone we sent up the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Rico Toras**: ""No, Your Majesty. Of course you..." |
| `[437]` | **""Define 'mess with.'""** | `[438]` **Rico Toras**: ""Of course anyone we sent up the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Rico Toras**: ""Nothing as extreme as the bombi..." |
| `[442]` | **""I already have one pro-Rizian organization active in Zille. I don't need two.""** | `[438]` **Rico Toras**: ""Of course anyone we sent up the..." | `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true` | *Brak zmian stanu* | `[452]` **Rico Toras**: ""We wouldn't interfere with what..." |
| `[446]` | **""It wouldn't hurt to have more of an upper hand.""** | `[438]` **Rico Toras**: ""Of course anyone we sent up the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Rico Toras**: ""Nothing as extreme as the bombi..." |
| `[448]` | **""Were your group's activities in Zille to be revealed, I would proclaim complete i..."** | `[440]` **Narrator**: "He winked." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Rico Toras**: ""Quite right."" |
| `[450]` | **""That's not code. If I hear about any Su Omina activity north of the Wehlen border..."** | `[440]` **Narrator**: "He winked." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Rico Toras**: ""I-- understood."" |
| `[451]` | **""Seriously, I appreciate the offer, but I don't want to put your organization at r..."** | `[440]` **Narrator**: "He winked." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Rico Toras**: ""That should be the least of you..." |
| `[455]` | **""A tempting proposition, but I wouldn't want to put you or your organization at ri..."** | `[447]` **Rico Toras**: ""With or without some light coer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Rico Toras**: ""That should be the least of you..." |
| `[456]` | **""More people should be aware of my benevolence, it's true.""** | `[447]` **Rico Toras**: ""With or without some light coer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Rico Toras**: ""Consider us your flag bearers."" |
| `[457]` | **""I'm not like you. I don't need brute force to accomplish my goals.""** | `[447]` **Rico Toras**: ""With or without some light coer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[460]` **Rico Toras**: ""You might not *need* it. But it..." |
| `[463]` | **""Yes. We are in agreement." [-2 Budget, -250 Military Equipment]"** | `[461]` **Rico Toras**: ""So... we have an understanding,..."<br>`[466]` **Rico Toras**: ""You don't have to get your hand..." | `Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250` | *Brak zmian stanu* | `[468]` **Narrator**: "Rico grinned." |
| `[464]` | **"Nod. [-2 Budget, -250 Military Equipment]"** | `[461]` **Rico Toras**: ""So... we have an understanding,..."<br>`[466]` **Rico Toras**: ""You don't have to get your hand..." | `Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250` | *Brak zmian stanu* | `[468]` **Narrator**: "Rico grinned." |
| `[465]` | **""Actually... no. You are to limit Su Omina's activity to within Rizia.""** | `[461]` **Rico Toras**: ""So... we have an understanding,..."<br>`[466]` **Rico Toras**: ""You don't have to get your hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Rico Toras**: ""I-- understood."" |
| `[467]` | **""I don't know how much clearer I can make this. My answer is no.""** | `[466]` **Rico Toras**: ""You don't have to get your hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Rico Toras**: ""I-- understood."" |
| `[483]` | **""Keep at it, Hugo. You'll make a huntress out of my daughter yet.""** | `[482]` **Hugo Toras**: ""...so you see, Your Highness, k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Hugo Toras**: ""With her instincts, she'll be t..." |
| `[484]` | **""With the essential difference that lettuce doesn't bleed when you pierce it.""** | `[482]` **Hugo Toras**: ""...so you see, Your Highness, k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Narrator**: "Hugo chuckled politely. He waved..." |
| `[485]` | **""I trust you two enjoyed the car ride?""** | `[482]` **Hugo Toras**: ""...so you see, Your Highness, k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Hugo Toras**: ""It's always a pleasure to get t..." |
| `[486]` | **""Don't listen to Hugo, Vina. Your uncle's a notoriously terrible shot.""** | `[482]` **Hugo Toras**: ""...so you see, Your Highness, k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Narrator**: "Hugo scowled at me briefly. He w..." |
| `[502]` | **""I can't help but think you and he had an ulterior motive for inviting us here.""** | `[135]` **Hugo Toras**: ""I may not like Rico's hunting m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Narrator**: "He calmly adjusted his rifle's s..." |
| `[508]` | **""What? No! They're cousins!""** | `[513]` **Hugo Toras**: ""So you'll consider him as a mar..."<br>`[515]` **Hugo Toras**: ""Or have you seriously never con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Hugo Toras**: ""Once removed."" |
| `[514]` | **""I never said that. Vina deserves to marry a gentleman.""** | `[513]` **Hugo Toras**: ""So you'll consider him as a mar..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[149]` **Hugo Toras**: ""Choose your words carefully, Yo..." |
| `[516]` | **""You may have a point, but it's still Vina's decision.""** | `[505]` **Hugo Toras**: ""Consanguinity wouldn't be my fi..."<br>`[507]` **Hugo Toras**: ""What are Her Highness' other op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[517]` **Hugo Toras**: ""Letting youngsters 'follow thei..." |
| `[518]` | **""Let's see how they get along today before we start making wedding arrangements.""** | `[505]` **Hugo Toras**: ""Consanguinity wouldn't be my fi..."<br>`[507]` **Hugo Toras**: ""What are Her Highness' other op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Hugo Toras**: ""Fair enough. Rico can be quite ..." |
| `[519]` | **""Our family has been in power long enough.""** | `[505]` **Hugo Toras**: ""Consanguinity wouldn't be my fi..."<br>`[507]` **Hugo Toras**: ""What are Her Highness' other op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Hugo Toras**: ""Not as long as God has preordai..." |
| `[522]` | **""The right alliances can make us more powerful than blood alone.""** | `[505]` **Hugo Toras**: ""Consanguinity wouldn't be my fi..."<br>`[507]` **Hugo Toras**: ""What are Her Highness' other op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Hugo Toras**: ""And the wrong ones will doom us..." |
| `[532]` | **""You're still holding a gun. Put him out of his misery.""** | `[531]` **Rico Toras**: ""But what good is a hunting dog ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[533]` **Vina Toras**: ""What? Father! No!"" |
| `[536]` | **""Put him out to stud. I bet he's got good blood, doesn't he?""** | `[531]` **Rico Toras**: ""But what good is a hunting dog ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Narrator**: "Rico half-smirked at me." |
| `[540]` | **""I'll take him, then. I wouldn't mind having a dog around the palace.""** | `[531]` **Rico Toras**: ""But what good is a hunting dog ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[541]` **Narrator**: "Vina's eyes widened." |
| `[543]` | **""I shot the poor fellow. He's my responsibility now.""** | `[542]` **Vina Toras**: ""Really, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[546]` **Narrator**: "Rico looked down at his dog." |
| `[544]` | **""Who knows what your brute of a cousin will do to him if I don't take him?""** | `[542]` **Vina Toras**: ""Really, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[546]` **Narrator**: "Rico looked down at his dog." |
| `[545]` | **""A three-legged royal dog? The public will love it!""** | `[542]` **Vina Toras**: ""Really, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[546]` **Narrator**: "Rico looked down at his dog." |
| `[555]` | **""You don't care about dead Wehzeks, but you care about an injured dog?""** | `[535]` **Rico Toras**: ""How big of an asshole do you th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[560]` **Rico Toras**: ""Wehzeks are expendable. Bruno i..." |
| `[556]` | **""Sorry. That was a joke.""** | `[535]` **Rico Toras**: ""How big of an asshole do you th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[559]` **Vina Toras**: ""It wasn't funny, Father."" |
| `[557]` | **""You said it yourself. He's useless on three legs.""** | `[535]` **Rico Toras**: ""How big of an asshole do you th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Rico Toras**: ""No, no. I'll find something to ..." |
| `[571]` | **""Yes, you two go on.""** | `[570]` **Narrator**: "My uncle gave me a meaningful gl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Narrator**: "Vina nodded solemnly and turned ..." |
| `[572]` | **""Actually, I'd prefer to travel with the princess.""** | `[570]` **Narrator**: "My uncle gave me a meaningful gl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[578]` **Vina Toras**: ""Let's go, then.""<br>`[581]` **Narrator**: "Vina looked at me coldly." |
| `[584]` | **""Stop the car at once. I want to see what's under that sheet.""** | `[583]` **Narrator**: "In front of the university libra..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] = true;` | `[586]` **Narrator**: "We came to a halt. My guards exi..." |
| `[585]` | **""We don't have time to stop. Let's just get to Rico's.""** | `[583]` **Narrator**: "In front of the university libra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[654]` **Vina Toras**: ""Yes, let's get this over with.""<br>`[94]` **Vina Toras**: ""Hugo's meeting us here too, rig..." |
| `[599]` | **""This is an outrage. The guilty party must be found and punished.""** | `[591]` **Narrator**: "His head had been chopped off."<br>`[596]` **Narrator**: "Both of our heads had been chopp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[619]` **Vina Toras**: ""It's certainly not a warm welco..."<br>`[632]` **Vina Toras**: ""It's certainly not a warm welco..." |
| `[600]` | **""How could Rico have allowed this to happen?""** | `[591]` **Narrator**: "His head had been chopped off."<br>`[596]` **Narrator**: "Both of our heads had been chopp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[637]` **Vina Toras**: ""Like Duchess Azaro said, he's i..."<br>`[642]` **Vina Toras**: ""If there's a revolution coming,..." |
| `[601]` | **""Looks like the good people of Iza are exercising their freedom of expression.""** | `[591]` **Narrator**: "His head had been chopped off."<br>`[596]` **Narrator**: "Both of our heads had been chopp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[614]` **Vina Toras**: ""You're not worried, Father?""<br>`[615]` **Vina Toras**: ""Today it's statues they're behe..." |
| `[602]` | **""Don't worry, Vina. It's only my father they're mad at, not you or me.""** | `[591]` **Narrator**: "His head had been chopped off." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[608]` **Vina Toras**: ""I'm not worried."" |
| `[603]` | **""Don't worry, Vina. I'm sure it's just teenage vandals.""** | `[596]` **Narrator**: "Both of our heads had been chopp..."<br>`[598]` **Narrator**: "All of our heads had been choppe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[608]` **Vina Toras**: ""I'm not worried."" |
| `[620]` | **""That's a good theory, Vina. You're as perceptive as your mother was.""** | `[618]` **Vina Toras**: ""He's trying to crack down on cr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Vina Toras**: ""Thank you, Father."" |
| `[623]` | **""If he can't keep a few troublemakers from defacing statues, he's not fit to be in..."** | `[622]` **Vina Toras**: ""What better excuse than seditio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[658]` **Vina Toras**: ""Beheading royals strikes me as ..." |
| `[624]` | **""That's a good theory, Vina. You're as perceptive as your mother was.""** | `[622]` **Vina Toras**: ""What better excuse than seditio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Vina Toras**: ""Thank you, Father."" |
| `[626]` | **""'Sedition' is a strong word. This is just some light hooliganism.""** | `[622]` **Vina Toras**: ""What better excuse than seditio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[657]` **Vina Toras**: ""I don't know, Father. Beheading..." |
| `[627]` | **""If that's his strategy, it's not a very smart one. He's allowing the authority of..."** | `[622]` **Vina Toras**: ""What better excuse than seditio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[659]` **Vina Toras**: ""Then it's good that the King of..." |
| `[639]` | **""If he can't keep vandals from defacing royal statues before the King's visit, he ..."** | `[618]` **Vina Toras**: ""He's trying to crack down on cr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[660]` **Vina Toras**: ""I suppose you'll have to hear h..." |
| `[640]` | **""Either way, this is a disgrace. Order must be brought to Iza one way or another.""** | `[618]` **Vina Toras**: ""He's trying to crack down on cr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[661]` **Vina Toras**: ""Good thing the King of Rizia is..." |
| `[641]` | **""This is bigger than just Iza. The anti-monarchist foreign powers are out to get us.""** | `[618]` **Vina Toras**: ""He's trying to crack down on cr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[662]` **Vina Toras**: ""If that were true, it wouldn't ..." |
| `[647]` | **""Talk to me, Vina. What's going on with you?""** | `[650]` **Narrator**: "She sighed audibly and slouched ..."<br>`[701]` **Narrator**: "Vina didn't seem to notice. She ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[665]` **Vina Toras**: ""Nothing. Remind me again why I ..." |
| `[648]` | **""Enough with the attitude. You're the Princess of Rizia and I want you on your bes..."** | `[650]` **Narrator**: "She sighed audibly and slouched ..."<br>`[701]` **Narrator**: "Vina didn't seem to notice. She ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[663]` **Narrator**: "She straightened up a little." |
| `[649]` | **"Say nothing."** | `[650]` **Narrator**: "She sighed audibly and slouched ..."<br>`[701]` **Narrator**: "Vina didn't seem to notice. She ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Narrator**: "We rode on in silence until we r..." |
| `[666]` | **""Because your king commands it.""** | `[665]` **Vina Toras**: ""Nothing. Remind me again why I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[682]` **Narrator**: "She straightened up a little." |
| `[667]` | **""Because your family has requested your presence, and family is the most important..."** | `[665]` **Vina Toras**: ""Nothing. Remind me again why I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[676]` **Vina Toras**: ""And your own daughter's wishes?..." |
| `[671]` | **""Because if I leave you alone, you'll start reading that propaganda again.""** | `[665]` **Vina Toras**: ""Nothing. Remind me again why I ..." | `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true` | *Brak zmian stanu* | `[675]` **Vina Toras**: ""And wake up to the truth about ..." |
| `[672]` | **""I want your opinion on the Rico situation. It's valuable to me.""** | `[665]` **Vina Toras**: ""Nothing. Remind me again why I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[674]` **Narrator**: "She smiled slightly."<br>`[680]` **Vina Toras**: ""If you wanted my opinion, you s..." |
| `[709]` | **""That doesn't mean I approve of the group or its activities.""** | `[413]` **Rico Toras**: ""I know the Wehzeks were pressur..." | `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false` | *Brak zmian stanu* | `[710]` **Rico Toras**: ""Of course, of course. You're en..." |
| `[722]` | **""No, I don't. Assuming you are innocent, the investigation will clear your name.""** | `[721]` **Rico Toras**: ""But then I got wind of your inv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Rico Toras**: ""Trust me, nobody I know has a c..." |
| `[723]` | **""You tell me, Ricardus. Do you have something to hide?""** | `[721]` **Rico Toras**: ""But then I got wind of your inv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[724]` **Rico Toras**: ""With regards to Zille? Nothing ..." |
| `[736]` | **""We can't afford to do this right now.""** | `[461]` **Rico Toras**: ""So... we have an understanding,..."<br>`[466]` **Rico Toras**: ""You don't have to get your hand..." | `(Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250) == false` | *Brak zmian stanu* | `[453]` **Rico Toras**: ""I-- understood."" |

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
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Discussing security while hunting with t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After months of promises and schedule conflicts, Vina and I were finally on our way to visit my cousin Rico Toras at his palace in Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The city's main road was straight and impossibly wide, a ..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I waved out the car window to the crowds of citizens lini..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I waved out the car window to the crowds of citizens lini..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I waved out the car window to the crowds of citizens lining the road. Up ahead, the domed library of the university brought back memories -- first of my happy student years there, then of the horrifying way they'd ended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I noticed most of the people who'd come out to see us wer..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I waved out the car window to the crowds of citizens lining the road. Up ahead loomed the domed library of the university."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I noticed most of the people who'd come out to see us wer..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The city's main road was straight and impossibly wide, a relic of Markian times when the city was a major trading center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Under Rico's stewardship, a formidable-looking iron gate had been constructed around the otherwise tranquil palace complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "His security let us through to the Duke's residence, a bl..."*)

### Węzeł `[11]`
Mówca: **Rico Toras**
> ""Welcome, my cousins! It has been far too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Greetings, Your Grace.""*)
  - -> `[20]` (*Player_Romus: ""So it has, Rico. You're looking sporty.""*)
  - -> `[24]` (*Player_Romus: ""I wish we were seeing each other under more pleasant cir..."*)
  - -> `[28]` (*Player_Romus: ""You could've warned us about the canine welcoming commit..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "We walked up to the doors. As soon as the guards opened them, a pair of long-nosed Rizian hunting dogs raced towards us, barking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""Go away! I hate dogs!""*)
  - -> `[14]` (*Player_Romus_Italic: "Pet the dogs."*)
  - -> `[15]` (*Player_Romus: ""Easy there, puppies.""*)
  - -> `[16]` (*Player_Romus: ""Stay back, Vina. They might be dangerous.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go away! I hate dogs!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Rico Toras: ""Bella! Bruno! Sit.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Pet the dogs."]** — Mówca: **Player_Romus_Italic**
> "I reached out and carefully gave each dog a pat on the head."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Rico Toras: ""Bella! Bruno! Sit.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Easy there, puppies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Rico Toras: ""Bella! Bruno! Sit.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay back, Vina. They might be dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Rico Toras: ""Bella! Bruno! Sit.""*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Both dogs promptly sat at attention, still as statues."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I heard the sound of boots on tile as my cousin Rico appr..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I heard the sound of boots on tile as my cousin Rico approached. He was wearing an olive-green tweed jacket and a flat cap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "He gave me a quick bow of acknowledgement, then knelt and..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Greetings, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Rico Toras: ""I trust Father informed you of today's plans? We leave f..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So it has, Rico. You're looking sporty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Rico Toras: ""Did Father not tell you? We're going hunting!""*)

### Węzeł `[21]`
Mówca: **Rico Toras**
> ""Did Father not tell you? We're going hunting!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Vina Toras: ""Wait. What?""*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Your first hunt as king. I wanted it to be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Hugo appeared from behind his son, a sheepish look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""Your first hunt as king. I wanted it to be a surprise.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish we were seeing each other under more pleasant circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Rico Toras: ""What do you mean? An afternoon in the woods killing boar..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I enjoyed hunting with you as a child. But I prefer more intellectual pursuits now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Hunting requires a keen eye and a keener mind. Done prop..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A welcome surprise indeed. It's been ages since I shot something.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Rico Toras: ""You'll be glad to know the technology has greatly improv..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know how much I love hunting. But I wanted to have a serious discussion.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""We'll have plenty of chances for that. Nine-tenths of th..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You could've warned us about the canine welcoming committee.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Rico Toras: ""Bella and Bruno wouldn't hurt a fly. They're just overex..."*)

### Węzeł `[29]`
Mówca: **Rico Toras**
> ""Bella and Bruno wouldn't hurt a fly. They're just overexcited about today's hunt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Vina Toras: ""Wait. What?""*)

### Węzeł `[30]`
Mówca: **Rico Toras**
> ""What do you mean? An afternoon in the woods killing boars sounds like the definition of pleasant to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Vina Toras: ""Wait. What?""*)

### Węzeł `[31]`
Mówca: **Rico Toras**
> ""I trust Father informed you of today's plans? We leave for the woods in an hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Vina Toras: ""Wait. What?""*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate it. But I was hoping the four of us could have a serious conversation.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Hugo Toras: ""We'll have plenty of chances for that. Nine-tenths of th..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know me too well. Let's go shoot something!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Rico Toras: ""As His Majesty proclaims, so it shall be!""*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a barbaric sport. I prefer more intellectual pursuits.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""Hunting requires a keen eye and a keener mind. Done prop..."*)

### Węzeł `[35]`
Mówca: **Hugo Toras**
> ""We'll have plenty of chances for that. Nine-tenths of this sport is waiting, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Rico Toras: ""Not when you have this.""*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""Hunting requires a keen eye and a keener mind. Done properly, it's the most intellectual pursuit there is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Rico Toras: ""You're behind the times, Father. Who needs a keen mind w..."*)

### Węzeł `[37]`
Mówca: **Rico Toras**
> ""Not when you have this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned around and showed us the KA-74 automatic rifle ..."*)

### Węzeł `[38]`
Mówca: **Rico Toras**
> ""You'll be glad to know the technology has greatly improved since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned around and showed us the KA-74 automatic rifle ..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "He turned around and showed us the KA-74 automatic rifle strapped to his back. Hugo turned up his nose disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Vina Toras: ""Isn't that cheating?""*)

### Węzeł `[40]`
Mówca: **Vina Toras**
> ""Isn't that cheating?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Rico Toras: ""Boars are speedy bastards. You'd be surprised, Your High..."*)

### Węzeł `[41]`
Mówca: **Rico Toras**
> ""Boars are speedy bastards. You'd be surprised, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He smiled rakishly at my daughter."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "He smiled rakishly at my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: ""We have outfits prepared for the two of you. And your ch..."*)

### Węzeł `[43]`
Mówca: **Rico Toras**
> ""You're behind the times, Father. Who needs a keen mind when you have this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned around and showed us the KA-74 automatic rifle ..."*)

### Węzeł `[44]`
Mówca: **Rico Toras**
> ""As His Majesty proclaims, so it shall be!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Rico Toras: ""I'm already equipped, myself.""*)

### Węzeł `[45]`
Mówca: **Rico Toras**
> ""I'm already equipped, myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned around and showed us the KA-74 automatic rifle ..."*)

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""We have outfits prepared for the two of you. And your choice of weapons, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""I want a KA-74, same as Rico.""*)
  - -> `[48]` (*Player_Romus: ""It'll be a good old-fashioned rifle for me.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want a KA-74, same as Rico.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Hunting boars with machine guns", "Iza F..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll be a good old-fashioned rifle for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_Rifle = true"*)

### Węzeł `[49]`
Mówca: **Rico Toras**
> ""See, Father? We'll have bagged a dozen boars before you've even finished loading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""Why stop there? Why not hire an airplane and shoot them ..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""You see, boy, there are still real gentlemen in this world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Vina Toras: ""I do wish I'd known about these plans. I've never so muc..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Hugo smirked at his son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""You see, boy, there are still real gentlemen in this wor..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Inside, Vina and I quickly refreshed ourselves and changed into the hunting garb that had been laid out for us. We stepped out to find two waiting jeeps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: ""I'll ride with Duke Rico. I have much to discuss with him.""*)
  - -> `[304]` (*Player_Romus: ""Vina, care to share a car with your old man?""*)
  - -> `[305]` (*Player_Romus: ""Hugo, shall we ride together and let the children catch ..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "I turned away from the window to see Rico looking at me intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Rico Toras: ""You must already know what I'm about to say, Your Majesty.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_Denounce..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I turned away from the window to see Rico looking at me i..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I turned away from the window to see my cousin smiling at..."*)

### Węzeł `[57]`
Mówca: **Rico Toras**
> ""You must already know what I'm about to say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)

### Węzeł `[58]`
Mówca: **Rico Toras**
> ""I remember a time when you were chomping at the bit to speak in front of Su Omina. Now you regard us -- them -- as criminals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Don't forget to whom you are speaking, Duke Toras. Count..."*)
  - -> `[64]` (*Player_Romus: ""I had no other choice. I'm trying to avoid an internatio..."*)
  - -> `[66]` (*Player_Romus: ""Wehlen has every reason to suspect Su Omina's involvemen..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Rico Toras: ""I remember a time when you were chomping at the bit to s..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Rico Toras: ""I knew you didn't approve of the company I keep here in ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget to whom you are speaking, Duke Toras. Count yourself lucky I haven't ordered your arrest yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Rico Toras), `[63]` (Rico Toras), `[721]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Rico Toras: ""Of course, of course. Forgive me.""*)

### Węzeł `[63]`
Mówca: **Rico Toras**
> ""I knew you didn't approve of the company I keep here in Iza. But to accuse us -- them -- of terrorism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Don't forget to whom you are speaking, Duke Toras. Count..."*)
  - -> `[64]` (*Player_Romus: ""I had no other choice. I'm trying to avoid an internatio..."*)
  - -> `[66]` (*Player_Romus: ""Wehlen has every reason to suspect Su Omina's involvemen..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had no other choice. I'm trying to avoid an international incident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Rico Toras), `[63]` (Rico Toras), `[721]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Rico Toras: ""Well, I humbly request that you try harder.""*)

### Węzeł `[65]`
Mówca: **Rico Toras**
> ""What I meant to say was... the Zille attack wasn't us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "A light smirk formed on his face."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen has every reason to suspect Su Omina's involvement in what happened. As do I.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Rico Toras), `[63]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Rico Toras: ""Trust me, nobody I know has a clue who was behind the Zi..."*)

### Węzeł `[67]`
Mówca: **Rico Toras**
> ""Of course, of course. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Rico Toras: ""What I meant to say was... the Zille attack wasn't us.""*)

### Węzeł `[68]`
Mówca: **Rico Toras**
> ""Trust me, nobody I know has a clue who was behind the Zille attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "A light smirk formed on his face."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need names. The investigation will turn up the truth.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]`
- **Kontekst wejściowy (poprzednik):** `[340]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Rico Toras: ""In time to get Zille back by the end of the year? I doub..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A bold suggestion, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Rico Toras: ""Would you expect anything less of the Duke of Iza?""*)

### Węzeł `[71]`
Mówca: **Rico Toras**
> ""Would you expect anything less of the Duke of Iza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""It *would* be convenient to put this incident behind us ..."*)
  - -> `[351]` (*Player_Romus: ""Just how loyal are these scapegoats you're proposing? Wo..."*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[356]` (*Player_Romus: ""I appreciate the gesture. But I can't condone this.""*)

### Węzeł `[72]`
Mówca: **Rico Toras**
> ""The drugs, the violence, the open resistance against our government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Iza_SawStatues == true"*)
  - -> `[394]` (*Player_Romus: ""You're not a child, Rico. Pull yourself together and bec..."*)
  - -> `[395]` (*Player_Romus: ""It doesn't seem that bad to me.""*)
  - -> `[396]` (*Player_Romus: ""It's concerning indeed. What can I do to help?""*)

### Węzeł `[73]`
Mówca: **Rico Toras**
> ""I wanted to thank you for your understanding, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Rico Toras: ""I know the Wehzeks were pressuring you to denounce Su Om..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "I turned away from the window to see my cousin smiling at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Rico Toras: ""I wanted to thank you for your understanding, Your Majes..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just between us... did Su Omina plan the attack?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Rico Toras: ""That's the funny thing. Nobody I've spoken to has a clue..."*)

### Węzeł `[76]`
Mówca: **Rico Toras**
> ""That's the funny thing. Nobody I've spoken to has a clue who did it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Rico Toras: ""Although we weren't sorry to hear those Wehzeks got what..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A false flag if I ever saw one. Wehlen obviously planned the bombing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Rico Toras: ""Killing a few of their own means nothing to them. They'r..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to thank me. I was protecting myself as well.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Kontekst wejściowy (poprzednik):** `[413]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Rico Toras: ""Nonetheless, I appreciate it. Especially since the organ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What choice did I have? Members of our house must stand by each other.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[413]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Rico Toras: ""Nonetheless, I appreciate it. Especially since the organ..."*)

### Węzeł `[80]`
Mówca: **Rico Toras**
> ""Killing a few of their own means nothing to them. They're like ants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Halaita. If it is said, so it is.""*)
  - -> `[81]` (*Player_Romus: ""Have you no compassion, son? Those are human beings who ..."*)
  - -> `[83]` (*Player_Romus: ""Watch your mouth. It's that kind of language that made W..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you no compassion, son? Those are human beings who died.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Rico Toras), `[414]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Rico contorted his mouth into an approximation of a frown."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Rico Toras), `[414]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your mouth. It's that kind of language that made Wehlen suspect Su Omina in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Rico Toras: ""It's just us here in this car, isn't it? We can tell it ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""No need to thank me. I was protecting myself as well.""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Rico Toras**
> ""Come now, I'll teach you. It'll be great fun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Inside, Vina and I quickly refreshed ourselves and change..."*)

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""I do wish I'd known about these plans. I've never so much as held a gun before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Rico Toras: ""Come now, I'll teach you. It'll be great fun.""*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Why stop there? Why not hire an airplane and shoot them from the sky?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Rico Toras: ""What a splendid idea. Remind me to plan that for next ti..."*)

### Węzeł `[90]`
Mówca: **Rico Toras**
> ""Nonetheless, I appreciate it. Especially since the organization is entirely innocent in this matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Player_Romus: ""I'm not sure I believe that.""*)
  - -> `[418]` (*Player_Romus: ""It's clearly a ruse planned by the Wehzeks themselves.""*)
  - -> `[419]` (*Player_Romus: ""They're upstanding citizens. I can't imagine they would ..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Vina suddenly tapped me on the shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Vina Toras: ""Father? Look over there.""*)

### Węzeł `[92]`
Mówca: **Vina Toras**
> ""Father? Look over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Narrator: "In front of the university library, a construction crew w..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "His security let us through to the Duke's residence, a blindingly white building with the flags of Rizia and House Toras hanging from every window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "We walked up to the doors. As soon as the guards opened t..."*)

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""Hugo's meeting us here too, right? Why do you think they wanted us here so badly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[96]` (*Player_Romus: ""I have my guesses. We'll see if they're right.""*)
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Iza_SawStatues == true"*)
  - -> `[98]` (*Player_Romus: ""The family hasn't been all together in ages. It's about ..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect the Golden Guard investigation I ordered will be the main topic of discussion.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""I can't even remember the last time Cousin Rico and I pr..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my guesses. We'll see if they're right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""I can't even remember the last time Cousin Rico and I pr..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To see something like those statues, I wager. Give us an inkling of the pressure Rico is under.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true`
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""I can't even remember the last time Cousin Rico and I pr..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The family hasn't been all together in ages. It's about time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""I can't even remember the last time Cousin Rico and I pr..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""I suspect the Golden Guard investigation I ordered will ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""The invitation coming so soon after the Zille incident i..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The invitation coming so soon after the Zille incident is no coincidence.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""I can't even remember the last time Cousin Rico and I pr..."*)

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""I can't even remember the last time Cousin Rico and I properly spoke. When we were children, maybe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "We rode on until we reached Palas Sazon."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "We rode on until we reached Palas Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Under Rico's stewardship, a formidable-looking iron gate ..."*)

### Węzeł `[105]`
Mówca: **Rico Toras**
> ""Caught the scent already, my dears? Must be dozens of boars out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: "The other car pulled up next to us. Hugo and Vina got out..."*)

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""But I've bored you enough, Your Highness. I believe Rico was going to show you the ropes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Rico Toras: ""I would be delighted to. If the King permits.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I was hoping *I* could escort my daughter on her first hunt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Hugo smoothly stepped between us."*)

### Węzeł `[108]`
Mówca: **Rico Toras**
> ""I would be delighted to. If the King permits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "He extended his hand to my daughter."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead, Vina. I hear Rico is an excellent shot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Vina took Rico's hand. With a smile, he picked up their g..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not my decision. Do you want to go with him, Vina?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_Hunting_KA74 == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_Hunting_KA74 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Hugo smoothly stepped between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Hugo Toras: ""Why not let the youngsters have their fun? Old men like ..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "He extended his hand to my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""Actually, I was hoping *I* could escort my daughter on h..."*)
  - -> `[109]` (*Player_Romus: ""Go ahead, Vina. I hear Rico is an excellent shot.""*)
  - -> `[110]` (*Player_Romus: ""It's not my decision. Do you want to go with him, Vina?""*)

### Węzeł `[116]`
Mówca: **Narrator**
> "An assistant handed me my KA-74. It was slightly different than the one I'd handled in my army days, but felt reassuringly familiar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""You and my son may aim for quantity. But I know quality ..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "An assistant handed me my rifle. It was a Rizian-made Dator 56, similar to the one I'd used during my summers hunting with Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""My son may aim for quantity. But men like us know qualit..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Vina took Rico's hand. With a smile, he picked up their guns and walked her over to one of the blinds, dogs in tow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Rico To..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "An assistant handed me my KA-74. It was slightly differen..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "An assistant handed me my KA-74. It was much heavier than..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "An assistant handed me my KA-74. It was much heavier than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""You and my son may aim for quantity. But I know quality ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "An assistant handed me my rifle. It was a Rizian-made Dat..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[126]`
Mówca: **Narrator**
> "An assistant handed me my rifle. It was a Rizian-made Dator 56. Clunkier than the one I'd used in the military, but usable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""My son may aim for quantity. But men like us know qualit..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "An assistant handed me my rifle. It was a Rizian-made Dat..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "An assistant handed me my rifle, a Rizian-made Dator 56. ..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "An assistant handed me my rifle, a Rizian-made Dator 56. It was more awkward to hold than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Hugo Toras: ""My son may aim for quantity. But men like us know qualit..."*)

### Węzeł `[131]`
Mówca: **Hugo Toras**
> ""My son may aim for quantity. But men like us know quality is key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He locked and loaded his own Dator rifle. Its stock had a..."*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""You and my son may aim for quantity. But I know quality is key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He locked and loaded his own Dator rifle. Its stock had a..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "He locked and loaded his own Dator rifle. Its stock had a gold-embossed bull on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "We climbed up into the hunting blind opposite of Vina and..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "We climbed up into the hunting blind opposite of Vina and Rico's position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Hugo Toras: ""And now we play the waiting game.""*)

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""I may not like Rico's hunting methods, but his dogs are second to none. They'll drive the boars out in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Why were you so keen that he and Vina go off together?""*)
  - -> `[502]` (*Player_Romus: ""I can't help but think you and he had an ulterior motive..."*)
  - -> `[137]` (*Player_Romus: ""Rico's a shrewd kid. Takes after his father.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why were you so keen that he and Vina go off together?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He calmly adjusted his rifle's sight."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico's a shrewd kid. Takes after his father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Hugo Toras: ""You're too kind.""*)

### Węzeł `[138]`
Mówca: **Hugo Toras**
> ""You're too kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "He calmly aimed his rifle towards the glade."*)

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""If my son and your daughter are to be married, they ought to spend time together first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Hugo Toras: ""Or have you seriously never considered the possibility?""*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's up to Vina to choose her own husband. And I doubt her cousin ranks high on the list of candidates.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Kontekst wejściowy (poprzednik):** `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Hugo Toras: ""Her cousin once removed.""*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He calmly adjusted his rifle's sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Hugo Toras: ""If my son and your daughter are to be married, they ough..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == t..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""It's up to Vina to choose her own husband. And I doubt h..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: ""Of course I have. But the two of them turned out as diff..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I have. But the two of them turned out as different as night and day.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Hugo Toras: ""And yet night and day are inseparable.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shockingly enough, the thought never crossed my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[513]` (Hugo Toras), `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Hugo Toras: ""That is indeed shocking, Your Majesty.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might have if your son were more of a gentleman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Hugo Toras: ""Choose your words carefully, Your Majesty. You're referr..."*)

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""Choose your words carefully, Your Majesty. You're referring to the last male scion of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Hugo Toras: ""What are Her Highness' other options? A rival house? A f..."*)

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""As you know, there are interests both inside and outside this country who seek to snatch Rizia away from House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Hugo Toras: ""Consanguinity wouldn't be my first choice, either. But i..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Just then, we heard a rustling sound coming from the woods. Bella and Bruno had found their quarry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "A group of boars raced into the clearing, the dogs nippin..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "A group of boars raced into the clearing, the dogs nipping at their heels. Working in tandem, they forced their prey into the lowest part of the glade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "Looking through my gun sight, I fixed my crosshairs on th..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "Shoot a boar."]** — Mówca: **Player_Romus_Italic**
> "I took aim and pulled the trigger."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[525]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 == true"*)

### Węzeł `[154]`
**[WYBÓR GRACZA: "Miss intentionally."]** — Mówca: **Player_Romus_Italic**
> "I aimed slightly to the right and pulled the trigger."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[525]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_ShootToMiss = true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_Hunting_KA74 == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_Hunting_KA74 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[158]`
Mówca: **Narrator**
> "As I gripped the KA-74, my military training took over. I fired a flurry of bullets into the group of boars. One after another fell to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "My uncle gave me a look of disapproval."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "As I gripped the KA-74, my military training took over. I..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "The assault rifle was more unwieldy than the ones I was u..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I struggled to keep the gun steady as it unleashed a roun..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "The assault rifle was more unwieldy than the ones I was used to, but I managed to hit the largest boar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "The others squealed as they scattered. A flurry of bullet..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "I struggled to keep the gun steady as it unleashed a round of bullets. The boars scattered in all directions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Bruno: ""YELP!""*)

### Węzeł `[167]`
Mówca: **Narrator**
> "The largest boar fell to the ground. The others scattered in all directions, squealing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Hugo Toras: ""Well done!""*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "The largest boar fell to the ground. The others scattered..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "My first shot managed to hit the largest boar. I fired ag..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I struggled to keep the gun steady as it fired. The shot ..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "My first shot managed to hit the largest boar. I fired again and hit another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Hugo Toras: ""Well done!""*)

### Węzeł `[175]`
Mówca: **Narrator**
> "I struggled to keep the gun steady as it fired. The shot went wide, and the boars scattered in all directions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Hugo Toras: ""Been too long, has it? Allow me.""*)

### Węzeł `[176]`
Mówca: **Rico Toras**
> ""Bruno!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Rico jumped down from his blind and raced into the cleari..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Rico jumped down from his blind and raced into the clearing. The dog lay on his side, whimpering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Hugo, Vina and I climbed down as Rico frantically ripped ..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "The others squealed as they scattered. A flurry of bullets came from Rico's blind, and one boar after another fell to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "By the end of the hunt, I'd racked up six kills. Hugo had..."*)

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""Well done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "As I turned away to reload, I heard a series of rapid-fir..."*)

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "By the end of the hunt, Hugo had four kills and Rico and ..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "As I turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Hugo Toras: ""Hmph. Not very sporting, if you ask me.""*)

### Węzeł `[182]`
Mówca: **Narrator**
> "By the end of the hunt, I'd racked up six kills. Hugo had four, and Rico had a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He and my daughter were deep in conversation as they clim..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "By the end of the hunt, Hugo had four kills and Rico and I had both racked up about a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He and my daughter were deep in conversation as they clim..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "He and my daughter were deep in conversation as they climbed down from their blind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""Hmph. Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "By the end of the hunt, I'd racked up four kills. Hugo ha..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "By the end of the hunt, I had zero kills. Hugo had six, and Rico had racked up a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He and my daughter were deep in conversation as they clim..."*)

### Węzeł `[187]`
Mówca: **Rico Toras**
> ""Lyza this, Lyza that. I'm telling you, if the Wehlen Civil War had happened while Grandmother was still in power, she wouldn't have set out the welcome mat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Vina Toras: ""No! Lyza would have honored Rizia and Wehlen's long hist..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "My shot went just wide of where the boars were. They scattered in all directions, squealing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Hugo Toras: ""Been too long, has it? Allow me.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Pr..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "My shot went just wide of where the boars were. They scat..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 == true"*)

### Węzeł `[192]`
Mówca: **Hugo Toras**
> ""Ha! Well done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "As I turned away to reload, I heard a series of rapid-fir..."*)

### Węzeł `[193]`
Mówca: **Hugo Toras**
> ""Been too long, has it? Allow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "In one swift motion, he aimed and fired his rifle. The la..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "As I turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Hugo Toras: ""Not very sporting, if you ask me.""*)

### Węzeł `[195]`
Mówca: **Narrator**
> "I got through the rest of the hunt without any additional kills. Hugo racked up four; Rico, a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He and my daughter were deep in conversation as they clim..."*)

### Węzeł `[196]`
Mówca: **Hugo Toras**
> ""Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "I got through the rest of the hunt without any additional..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "In one swift motion, he aimed and fired his rifle. The largest of the boars fell to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "As we turned away to reload, I heard a series of rapid-fi..."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "As we turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Hugo Toras: ""Hmph. Not very sporting, if you ask me.""*)

### Węzeł `[199]`
Mówca: **Narrator**
> "By the end of the hunt, I'd racked up four kills. Hugo had six, and Rico had a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He and my daughter were deep in conversation as they clim..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "By the end of the hunt, I'd racked up six kills. Hugo had four, and Rico had a dozen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "He and my daughter were deep in conversation as they clim..."*)

### Węzeł `[201]`
Mówca: **Hugo Toras**
> ""Well done!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "As I turned away to reload, I heard a series of rapid-fir..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "As I turned away to reload, I heard a series of rapid-fire bangs coming from Rico's direction. I looked back out of the blind to see the ground littered with dead boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Hugo Toras: ""Hmph. Not very sporting, if you ask me.""*)

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""Hmph. Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "By the end of the hunt, I'd racked up six kills. Hugo had..."*)

### Węzeł `[204]`
Mówca: **Hugo Toras**
> ""Hmph. Not very sporting, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "By the end of the hunt, I had zero kills. Hugo had six, a..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_Hunting_KA74 == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I struggled to keep the gun steady as it unleashed a roun..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_Hunting_KA74 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "I heard a squeal, then a thud. To my surprise, I'd hit on..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "I heard a squeal, then a thud. To my surprise, I'd hit one of the boars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Hugo Toras: ""Ha! Well done!""*)

### Węzeł `[209]`
Mówca: **Narrator**
> "Hugo, Vina and I climbed down as Rico frantically ripped off a piece of his shirt and wrapped it tight around Bruno's bleeding leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Narrator: "He looked up at me with almost feral eyes."*)

### Węzeł `[210]`
Mówca: **Rico Toras**
> ""What the hell, cousin? You shot my dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""You will refer to me as 'Your Majesty'.""*)
  - -> `[212]` (*Player_Romus: ""It's not my fault. I was aiming for the boar.""*)
  - -> `[213]` (*Player_Romus: ""It's a scratch. He'll be fine.""*)
  - -> `[214]` (*Player_Romus: ""It was my first time with a KA-74. I got flustered.""*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refer to me as 'Your Majesty'.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Rico Toras: ""Excuse me. His Majesty King Romus Toras shot my fucking ..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not my fault. I was aiming for the boar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Rico Toras: ""Next time, aim at your own fucking head!""*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a scratch. He'll be fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Rico Toras: ""He can't hunt on three fucking legs!""*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my first time with a KA-74. I got flustered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Rico Toras: ""You don't fucking say!""*)

### Węzeł `[215]`
Mówca: **Rico Toras**
> ""You don't fucking say!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hugo Toras: ""For God's sake, Rico, shut your mouth!""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Vina Toras: ""Why not? I've had enough father-daughter time lately.""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Vina Toras: ""Yes, I'd love to. We didn't even get a chance to speak a..."*)

### Węzeł `[219]`
Mówca: **Vina Toras**
> ""Why not? I've had enough father-daughter time lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Vina took Rico's hand. With a smile, he picked up their g..."*)

### Węzeł `[220]`
Mówca: **Vina Toras**
> ""Yes, I'd love to. We didn't even get a chance to speak at the coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Vina took Rico's hand. With a smile, he picked up their g..."*)

### Węzeł `[221]`
Mówca: **Rico Toras**
> ""Bella! Bruno! Sit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Both dogs promptly sat at attention, still as statues."*)

### Węzeł `[222]`
Mówca: **Vina Toras**
> ""I'm telling you, if Wehzeks and Derdians were granted the same rights as native Rizians, none of this would be happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Rico Toras: ""You're right. It'd be worse. Rizia would have collapsed ..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Rico Toras: ""Lyza this, Lyza that. I'm telling you, if the Wehlen Civ..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Vina Toras: ""I'm telling you, if Wehzeks and Derdians were granted th..."*)

### Węzeł `[226]`
Mówca: **Vina Toras**
> ""No! Lyza would have honored Rizia and Wehlen's long history of cooperation, and shown compassion for those who suffered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Rico Toras: ""You naive little girl. Everyone in Merkopa wants what we..."*)

### Węzeł `[227]`
Mówca: **Rico Toras**
> ""You naive little girl. Everyone in Merkopa wants what we Rizians have. The Wehzeks saw a chance to get it, and they jumped on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "He flung his gun on the ground in frustration."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "He flung his gun on the ground in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Rico Toras: ""I'm afraid your daughter didn't shoot a damn thing on to..."*)

### Węzeł `[229]`
Mówca: **Rico Toras**
> ""I'm afraid your daughter didn't shoot a damn thing on today's hunt, Your Majesty. She was too busy distracting me with her nonsense opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: ""Vina is your intellectual superior in every way, you twi..."*)
  - -> `[244]` (*Player_Romus: ""You've done well enough for all four of us. Congratulati..."*)
  - -> `[245]` (*Player_Romus: ""Vina, we're guests here in Iza. Apologize to Rico now.""*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina is your intellectual superior in every way, you twit. You will apologize to her. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He seemed to collect himself for a moment."*)

### Węzeł `[231]`
Mówca: **Rico Toras**
> ""He can't hunt on three fucking legs!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hugo Toras: ""For God's sake, Rico, shut your mouth!""*)

### Węzeł `[232]`
Mówca: **Rico Toras**
> ""Excuse me. His Majesty King Romus Toras shot my fucking dog!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hugo Toras: ""For God's sake, Rico, shut your mouth!""*)

### Węzeł `[233]`
Mówca: **Rico Toras**
> ""Next time, aim at your own fucking head!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Hugo Toras: ""For God's sake, Rico, shut your mouth!""*)

### Węzeł `[234]`
Mówca: **Vina Toras**
> ""Please, Rico. It was an accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "She put her hand on Rico's shoulder. He forced himself to..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 0)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Vina Toras: ""Please, Rico. It was an accident.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Vina Toras: ""Honestly, Father! Why choose such a dangerous weapon if ..."*)

### Węzeł `[238]`
Mówca: **Vina Toras**
> ""Honestly, Father! Why choose such a dangerous weapon if you don't know how to use it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "She put her hand on Rico's shoulder. He forced himself to..."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Vina bent down and stroked Bruno's fur. The dog raised his head slightly and licked her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)

### Węzeł `[240]`
Mówca: **Hugo Toras**
> ""Rico, Vina, why don't you two take Bruno back to the palace? His Majesty and I will wrap everything up here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "My uncle gave me a meaningful glance."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "She put her hand on Rico's shoulder. He forced himself to take a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Rico Toras: ""Please excuse my outburst, Your Majesty. I understand yo..."*)

### Węzeł `[242]`
Mówca: **Rico Toras**
> ""You're right. It'd be worse. Rizia would have collapsed under the strain of providing for its own as well as millions of foreign parasites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Vina Toras: ""Parasites? They mine our gold and farm our crops, you id..."*)

### Węzeł `[243]`
Mówca: **Vina Toras**
> ""Parasites? They mine our gold and farm our crops, you idiot. If anyone's a parasite, it's the nobles siphoning wealth from their labor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "He flung his gun on the ground in frustration."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've done well enough for all four of us. Congratulations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "He seemed to collect himself for a moment, then smirked."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, we're guests here in Iza. Apologize to Rico now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Vina looked sullenly at the ground."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "He seemed to collect himself for a moment, then smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)

### Węzeł `[247]`
Mówca: **Rico Toras**
> ""Thank you. You didn't make out too poorly yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "We posed for photographs next to the boars we'd killed. T..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "My uncle gave me a meaningful glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""Yes, you two go on. I'm truly sorry, Rico.""*)
  - -> `[250]` (*Player_Romus: ""Actually, Hugo should go with you. I'll travel with the ..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you two go on. I'm truly sorry, Rico.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "Rico seemed to collect himself for a moment."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Hugo should go with you. I'll travel with the princess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Rico seemed like he was about to object, but thought bett..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "Rico seemed to collect himself for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC...."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC...."*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDL..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Rico Toras: ""I accept your apology. And this won't affect the agreeme..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Rico Toras: ""I accept your apology. I hope you'll give extra consider..."*)

### Węzeł `[255]`
Mówca: **Rico Toras**
> ""I accept your apology. And this won't affect the agreement we made today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[256]`
Mówca: **Rico Toras**
> ""I accept your apology. I hope you'll give extra consideration to my police request, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Rico seemed like he was about to object, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Rico Toras: ""As you wish, Your Majesty. This won't affect the agreeme..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Rico Toras: ""Go on, then. I hope you'll give extra consideration to m..."*)

### Węzeł `[261]`
Mówca: **Rico Toras**
> ""As you wish, Your Majesty. This won't affect the agreement we made today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[262]`
Mówca: **Rico Toras**
> ""Go on, then. I hope you'll give extra consideration to my police request, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "He seemed to collect himself for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Rico Toras: ""I'm sorry, Your Highness. I must have gotten carried away.""*)

### Węzeł `[264]`
Mówca: **Rico Toras**
> ""I'm sorry, Your Highness. I must have gotten carried away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Vina looked sullenly at the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Vina Toras: ""Sorry, Your Grace.""*)

### Węzeł `[266]`
Mówca: **Vina Toras**
> ""Sorry, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Pr..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Rico Toras: ""Thank you. You didn't make out too poorly yourself.""*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Rico Toras: ""Thank you. I wish I could say the same to you.""*)

### Węzeł `[270]`
Mówca: **Rico Toras**
> ""Thank you. I wish I could say the same to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Rico and Hugo posed for photographs next to the boars the..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "We posed for photographs next to the boars we'd killed. The assistants began packing everything away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Hugo Toras: ""We'll eat well tonight. The chef at Palas Sazon does an ..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Rico and Hugo posed for photographs next to the boars they'd killed. The assistants began packing everything away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Hugo Toras: ""We'll eat well tonight. The chef at Palas Sazon does an ..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_ShootToMiss = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Pr..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "We posed for photographs next to the boars we'd killed. T..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true || (RiziaDLCIsolated.Turn02_Hunting_Rifle == true && RiziaDLCIsolated.Turn02_Hunting_ShootToMiss == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true  or  (Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] == true  and  Variable["RiziaDLCIsolated.Turn02_Hunting_ShootToMiss"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Rico and Hugo posed for photographs next to the boars the..."*)

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""We'll eat well tonight. The chef at Palas Sazon does an excellent braised boar with wine sauce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Hugo Toras: ""Rico, Vina, why don't you two ride ahead and notify the ..."*)

### Węzeł `[278]`
Mówca: **Hugo Toras**
> ""Rico, Vina, why don't you two ride ahead and notify the kitchen staff? His Majesty and I will be right behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "Vina gave me a pleading look."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "Vina gave me a pleading look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Why don't you go with your son, Hugo? I'll accompany the..."*)
  - -> `[280]` (*Player_Romus: ""Yes, go ahead. One last chance for you two to have a civ..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, go ahead. One last chance for you two to have a civil conversation before we leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you go with your son, Hugo? I'll accompany the princess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Hugo raised an eyebrow."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Hugo raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Vina grimaced at me as Rico led her to one of the waiting..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Vina grimaced at me as Rico led her to one of the waiting jeeps. Hugo and I got into the second, and the four of us headed back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Dinner that night was indeed delicious."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "Dinner that night was indeed delicious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false"*)

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""As you wish. Come along, Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Vina silently thanked me as Rico and Hugo departed. We cl..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Hugo Toras: ""As you wish. Come along, Rico.""*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Vina silently thanked me as Rico and Hugo departed. We climbed into the second jeep and headed back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Dinner that night was indeed delicious."*)

### Węzeł `[289]`
Mówca: **Narrator**
> "The assistants carefully placed Bruno on a blanket in the back of one of the jeeps. Hugo and Rico got in, and the car sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Vina and I got into the other jeep and followed them back..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "Vina and I got into the other jeep and followed them back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "We left for Porte Drazon without staying for dinner."*)

### Węzeł `[291]`
Mówca: **Narrator**
> "We left for Porte Drazon without staying for dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "The assistants carefully placed Bruno on a blanket in the back of one of the jeeps. Vina and Rico got in, and the car sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "Hugo and I got into the other jeep and followed them back..."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "Hugo and I got into the other jeep and followed them back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "He calmly aimed his rifle towards the glade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Hugo Toras: ""So you'll consider him as a marriage prospect for your d..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Rico_ShotDog = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Rico Toras: ""Bruno!""*)

### Węzeł `[296]`
Mówca: **Narrator**
> "I noticed most of the people who'd come out to see us were native Rizian -- even on the streets of the city's Wehzek quarter, Little Wraclawitz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true..."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "He gave me a quick bow of acknowledgement, then knelt and kissed Vina's hand. I was struck by his transformation from a gawky, insecure teen to a broad-shouldered, preternaturally confident young man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Rico Toras: ""Welcome, my cousins! It has been far too long.""*)

### Węzeł `[298]`
Mówca: **Vina Toras**
> ""Wait. What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Hugo appeared from behind his son, a sheepish look on his..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""A welcome surprise indeed. It's been ages since I shot s..."*)
  - -> `[27]` (*Player_Romus: ""You know how much I love hunting. But I wanted to have a..."*)
  - -> `[25]` (*Player_Romus: ""I enjoyed hunting with you as a child. But I prefer more..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""You know me too well. Let's go shoot something!""*)
  - -> `[32]` (*Player_Romus: ""I appreciate it. But I was hoping the four of us could h..."*)
  - -> `[34]` (*Player_Romus: ""It's a barbaric sport. I prefer more intellectual pursui..."*)

### Węzeł `[302]`
Mówca: **Rico Toras**
> ""What a splendid idea. Remind me to plan that for next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Vina Toras: ""I do wish I'd known about these plans. I've never so muc..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll ride with Duke Rico. I have much to discuss with him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "Rico nodded. An aide held the door open, and we hopped in..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, care to share a car with your old man?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Rico swiftly interjected."*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, shall we ride together and let the children catch up?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Rico swiftly interjected."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "Rico swiftly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Rico Toras: ""If you don't mind, Your Majesty, I've had this car prepa..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "Rico nodded. An aide held the door open, and we hopped into the first car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[308]`
Mówca: **Rico Toras**
> ""If you don't mind, Your Majesty, I've had this car prepared for the two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "He gestured to his aide, who held the door of the first j..."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "He gestured to his aide, who held the door of the first jeep open. The two of us stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Hugo To..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "East of the palace, the landscape quickly turned hilly and green. We were entering the Brenas Forest Estate, a private hunting ground reserved for nobility only."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)

### Węzeł `[311]`
Mówca: **Rico Toras**
> ""Well, I humbly request that you try harder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Rico Toras: ""Whatever you may think of us, Su Omina didn't plan the Z..."*)

### Węzeł `[312]`
Mówca: **Rico Toras**
> ""Whatever you may think of us, Su Omina didn't plan the Zille attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "A light smirk formed on his face."*)

### Węzeł `[313]`
Mówca: **Rico Toras**
> ""Though I can't say I wasn't happy to see those Wehzeks get what was coming to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""Halaita. If it is said, so it is.""*)
  - -> `[315]` (*Player_Romus: ""For heaven's sake, son, have some respect for the dead.""*)
  - -> `[316]` (*Player_Romus: ""You'll get what's coming to you if you carry on with tha..."*)
  - -> `[318]` (*Player_Romus: ""So you want me to believe your organization is completel..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For heaven's sake, son, have some respect for the dead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Rico Toras: ""Excuse me. Your Majesty.""*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll get what's coming to you if you carry on with that kind of talk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Rico Toras: ""Excuse me. Your Majesty.""*)

### Węzeł `[317]`
Mówca: **Narrator**
> "A light smirk formed on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Rico Toras: ""Though I can't say I wasn't happy to see those Wehzeks g..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you want me to believe your organization is completely innocent?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Rico Toras: ""In Wehlen? Yes.""*)

### Węzeł `[319]`
Mówca: **Rico Toras**
> ""In Wehlen? Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[320]`
Mówca: **Rico Toras**
> ""Excuse me. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[321]`
Mówca: **Rico Toras**
> ""We were all thinking it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[322]`
Mówca: **Rico Toras**
> ""The point is that your investigation into us will turn up nothing. About Wehlen, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Rico Toras: ""But if you want this mess cleared up in time for Zille t..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Rico Toras: ""Your investigation into us will turn up nothing.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Rico Toras: ""Smolak's accusations are based on nothing. Just his own ..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Rico Toras: ""The point is that your investigation into us will turn u..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Rico Toras: ""The point is that President Smolak's accusations are bas..."*)

### Węzeł `[329]`
Mówca: **Rico Toras**
> ""Your investigation into us will turn up nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Rico Toras: ""But if you want this mess cleared up in time for Zille t..."*)

### Węzeł `[330]`
Mówca: **Rico Toras**
> ""But if you want this mess cleared up in time for Zille to be returned, I think I can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Player_Romus: ""How?""*)
  - -> `[334]` (*Player_Romus: ""I still don't believe you.""*)
  - -> `[335]` (*Player_Romus: ""In exchange for what?""*)

### Węzeł `[331]`
Mówca: **Rico Toras**
> ""The point is that President Smolak's accusations are based on nothing. Just his own vendetta against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Rico Toras: ""But if you want this mess cleared up in time for Zille t..."*)

### Węzeł `[332]`
Mówca: **Rico Toras**
> ""Smolak's accusations are based on nothing. Just his own vendetta against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Rico Toras: ""But if you want this mess cleared up in time for Zille t..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "He cleared his throat."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't believe you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Rico Toras: ""Regardless...""*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In exchange for what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_GoldenGuard_InvestigateSO == true"*)

### Węzeł `[336]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Rico Toras: ""The people in my organization are loyal to me, Your Maje..."*)

### Węzeł `[337]`
Mówca: **Rico Toras**
> ""The people in my organization are loyal to me, Your Majesty. Very loyal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Rico Toras: ""If one or two of them were to confess to the attack, as ..."*)

### Węzeł `[338]`
Mówca: **Rico Toras**
> ""Aside from getting your Golden Guard off Su Omina's tail? Nothing. I wouldn't dare to bargain with my cousin and my King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "He cleared his throat."*)

### Węzeł `[339]`
Mówca: **Rico Toras**
> ""Regardless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "He cleared his throat."*)

### Węzeł `[340]`
Mówca: **Rico Toras**
> ""If one or two of them were to confess to the attack, as a splinter cell acting independently of both Su Omina and the crown, it'd solve both of our problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded"*)
  - -> `[70]` (*Player_Romus: ""A bold suggestion, Your Grace.""*)
  - -> `[345]` (*Player_Romus: ""Wehlen's investigators aren't stupid. They'd uncover the..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""I don't need names. The investigation will turn up the t..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Player_Romus: ""So you're offering to commit a crime on my behalf.""*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're offering to commit a crime on my behalf.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"]) == false`
- **Kontekst wejściowy (poprzednik):** `[340]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Rico Toras: ""I'm not offering anything. Just pointing out how conveni..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen's investigators aren't stupid. They'd uncover the truth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Rico Toras: ""Not if the truth is that Wehlen itself was behind the at..."*)

### Węzeł `[346]`
Mówca: **Rico Toras**
> ""Not if the truth is that Wehlen itself was behind the attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Rico Toras: ""My hunch is, they're counting on Rizia to deny the crime..."*)

### Węzeł `[347]`
Mówca: **Rico Toras**
> ""My hunch is, they're counting on Rizia to deny the crime so they can postpone the Zille handover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Rico Toras: ""By handing over my men, we'd be calling their bluff.""*)

### Węzeł `[348]`
Mówca: **Rico Toras**
> ""By handing over my men, we'd be calling their bluff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""It *would* be convenient to put this incident behind us ..."*)
  - -> `[351]` (*Player_Romus: ""Just how loyal are these scapegoats you're proposing? Wo..."*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[356]` (*Player_Romus: ""I appreciate the gesture. But I can't condone this.""*)

### Węzeł `[349]`
Mówca: **Rico Toras**
> ""In time to get Zille back by the end of the year? I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""It *would* be convenient to put this incident behind us ..."*)
  - -> `[357]` (*Player_Romus: ""I don't care how long it takes. I won't stoop to the kin..."*)
  - -> `[351]` (*Player_Romus: ""Just how loyal are these scapegoats you're proposing? Wo..."*)

### Węzeł `[350]`
Mówca: **Rico Toras**
> ""I'm not offering anything. Just pointing out how convenient it would be should such a confession occur.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""It *would* be convenient to put this incident behind us ..."*)
  - -> `[351]` (*Player_Romus: ""Just how loyal are these scapegoats you're proposing? Wo..."*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[356]` (*Player_Romus: ""I appreciate the gesture. But I can't condone this.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just how loyal are these scapegoats you're proposing? Would they crack under interrogation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Rico Toras), `[348]` (Rico Toras), `[349]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Rico Toras: ""Trust me, cousin. If it came down to that, I have the re..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the fact that this would put a premature end to my investigation into Su Omina? A nice little bonus for you, I presume.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Rico Toras), `[348]` (Rico Toras), `[350]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player_Romus: ""And the fact that this would put a premature end to my i..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the gesture. But I can't condone this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Rico Toras), `[348]` (Rico Toras), `[350]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Rico Toras: ""Understood, Your Majesty.""*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care how long it takes. I won't stoop to the kind of tactics you're suggesting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Rico Toras: ""I-- Understood, Your Majesty.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It *would* be convenient to put this incident behind us as fast as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Rico Toras), `[348]` (Rico Toras), `[349]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Rico Toras: ""Just say the word, cousin.""*)

### Węzeł `[359]`
Mówca: **Rico Toras**
> ""Trust me, cousin. If it came down to that, I have the resources to make sure their loved ones are well cared for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""I can't believe I'm even entertaining this thought. The ..."*)
  - -> `[382]` (*Player_Romus: ""Very well, Your Grace. Let's try this your way.""*)
  - -> `[370]` (*Player_Romus: ""*If* it were to emerge that said suspects were lying, th..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Rico Toras: ""And you as well. Don't forget your own history with us.""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Rico Toras: ""And you as well. Don't forget that we're related.""*)

### Węzeł `[363]`
Mówca: **Rico Toras**
> ""And you as well. Don't forget your own history with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""I can't believe I'm even entertaining this thought. The ..."*)
  - -> `[382]` (*Player_Romus: ""Very well, Your Grace. Let's try this your way.""*)
  - -> `[370]` (*Player_Romus: ""*If* it were to emerge that said suspects were lying, th..."*)

### Węzeł `[364]`
Mówca: **Rico Toras**
> ""And you as well. Don't forget that we're related.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""I can't believe I'm even entertaining this thought. The ..."*)
  - -> `[382]` (*Player_Romus: ""Very well, Your Grace. Let's try this your way.""*)
  - -> `[370]` (*Player_Romus: ""*If* it were to emerge that said suspects were lying, th..."*)

### Węzeł `[365]`
Mówca: **Rico Toras**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "He winked."*)

### Węzeł `[366]`
Mówca: **Narrator**
> "He winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Player_Romus: ""*If* it were to emerge that said suspects were lying, th..."*)
  - -> `[369]` (*Player_Romus: ""That's not code, Rico. Come forth with false suspects, a..."*)

### Węzeł `[367]`
Mówca: **Rico Toras**
> ""I-- Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Rico Toras: ""Carry on with your investigation and forget I said anyth..."*)

### Węzeł `[368]`
Mówca: **Rico Toras**
> ""Just say the word, cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""I can't believe I'm even entertaining this thought. The ..."*)
  - -> `[382]` (*Player_Romus: ""Very well, Your Grace. Let's try this your way.""*)
  - -> `[370]` (*Player_Romus: ""*If* it were to emerge that said suspects were lying, th..."*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not code, Rico. Come forth with false suspects, and I'll have your head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Rico Toras: ""Oh.""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* it were to emerge that said suspects were lying, the order for them to come forward would never be traceable back to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Rico Toras), `[363]` (Rico Toras), `[364]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Rico Toras: ""Of course.""*)

### Węzeł `[371]`
Mówca: **Rico Toras**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player_Romus: ""Then we have an understanding.""*)
  - -> `[378]` (*Player_Romus: ""Actually, no. I won't go along with this plan. Your orga..."*)

### Węzeł `[372]`
Mówca: **Rico Toras**
> ""Oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Rico Toras: ""Never mind, then.""*)

### Węzeł `[373]`
Mówca: **Rico Toras**
> ""Never mind, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "Rico looked away for a moment. The woods around us were g..."*)

### Węzeł `[374]`
Mówca: **Narrator**
> "Rico looked away for a moment. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player_Romus: ""If there's anything else you'd like to bring up with you..."*)
  - -> `[390]` (*Player_Romus: ""How are you faring as Duke of Iza, my cousin? Be honest.""*)

### Węzeł `[375]`
Mówca: **Narrator**
> "Rico nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Rico Toras: ""I'll make the arrangements as soon as we get back into t..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats = true; RiziaDLC.Security_GoldenGuard_InvestigateSO = false; RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 2;
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true;
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] = false;
Variable["RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 2;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "Rico nodded solemnly."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we have an understanding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats = true; RiziaDLC.Sec..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, no. I won't go along with this plan. Your organization must be held accountable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Rico Toras: ""I-- well within your right, Your Majesty.""*)

### Węzeł `[379]`
Mówca: **Rico Toras**
> ""Carry on with your investigation and forget I mentioned anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease = false"*)

### Węzeł `[380]`
Mówca: **Rico Toras**
> ""I-- well within your right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Rico Toras: ""Carry on with your investigation and forget I mentioned ..."*)

### Węzeł `[381]`
Mówca: **Rico Toras**
> ""Carry on with your investigation and forget I said anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease = false"*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. Let's try this your way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Rico Toras), `[363]` (Rico Toras), `[364]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Rico Toras: ""I-- thank you, Your Majesty.""*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe I'm even entertaining this thought. The answer is no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Rico Toras), `[363]` (Rico Toras), `[364]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Rico Toras: ""I-- Understood, Your Majesty.""*)

### Węzeł `[384]`
Mówca: **Rico Toras**
> ""I-- thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Rico Toras: ""I'll make the arrangements as soon as we get back into t..."*)

### Węzeł `[385]`
Mówca: **Rico Toras**
> ""I'll make the arrangements as soon as we get back into the city. And thank you in advance for ending that useless investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats = true; RiziaDLC.Sec..."*)

### Węzeł `[386]`
Mówca: **Rico Toras**
> ""I'll make the arrangements as soon as we get back into the city. And thank you in advance for ending that useless investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "We drove on. The woods around us were growing denser."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats = true; RiziaDLC.Security_GoldenGuard_InvestigateSO = false; RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 2;
RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] = true;
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] = false;
Variable["RiziaDLCSupport.Journal_Turn03_Zille_Scapegoats"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 2;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "We drove on. The woods around us were growing denser."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "We drove on. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player_Romus: ""If there's anything else you'd like to bring up with you..."*)
  - -> `[390]` (*Player_Romus: ""How are you faring as Duke of Iza, my cousin? Be honest.""*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If there's anything else you'd like to bring up with your king, now is the time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Narrator), `[388]` (Narrator), `[462]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "Rico eagerly turned back toward me."*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you faring as Duke of Iza, my cousin? Be honest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Narrator), `[388]` (Narrator), `[462]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Narrator: "Rico eagerly turned back toward me."*)

### Węzeł `[391]`
Mówca: **Narrator**
> "Rico eagerly turned back toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Rico Toras: ""I'm sure you've been kept abreast of the situation here,..."*)

### Węzeł `[392]`
Mówca: **Rico Toras**
> ""I'm sure you've been kept abreast of the situation here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Rico Toras: ""The drugs, the violence, the open resistance against our..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The headless statues.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Rico Toras: ""You weren't supposed to see those.""*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not a child, Rico. Pull yourself together and become the leader this city needs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Rico Toras: ""I'm trying. But I can't do it without reinforcements.""*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't seem that bad to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Rico Toras: ""Sooner or later, it will add up to something greater tha..."*)

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's concerning indeed. What can I do to help?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Rico Toras: ""I'm glad you asked.""*)

### Węzeł `[397]`
Mówca: **Rico Toras**
> ""You weren't supposed to see those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Rico Toras: ""I've heard that in times of emergency, police from the R..."*)

### Węzeł `[398]`
Mówca: **Rico Toras**
> ""I'm trying. But I can't do it without reinforcements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Rico Toras: ""I've heard that in times of emergency, police from the R..."*)

### Węzeł `[399]`
Mówca: **Rico Toras**
> ""Sooner or later, it will add up to something greater than its parts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Rico Toras: ""I've heard that in times of emergency, police from the R..."*)

### Węzeł `[400]`
Mówca: **Rico Toras**
> ""I'm glad you asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Rico Toras: ""I've heard that in times of emergency, police from the R..."*)

### Węzeł `[401]`
Mówca: **Rico Toras**
> ""I've heard that in times of emergency, police from the Rizian central forces can be placed under individual leaders' direct command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Rico Toras: ""I've petitioned your War and Security Councilor for just..."*)

### Węzeł `[402]`
Mówca: **Rico Toras**
> ""I've petitioned your War and Security Councilor for just such a transfer, but she refused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Player_Romus: ""Rightly so. You should be cooperating with the greater p..."*)
  - -> `[404]` (*Player_Romus: ""So you're using your family connections to go over her h..."*)
  - -> `[405]` (*Player_Romus: ""She made a mistake. The Brenas police cannot be counted ..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rightly so. You should be cooperating with the greater province of Brenas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[402]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Rico Toras: ""You mean with the Sazons?""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're using your family connections to go over her head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[402]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Rico Toras: ""Well... yes. I don't see another alternative.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She made a mistake. The Brenas police cannot be counted on to help you keep the peace here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[402]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Rico Toras: ""If anything, they are actively working against me.""*)

### Węzeł `[406]`
Mówca: **Rico Toras**
> ""You mean with the Sazons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "He snorted."*)

### Węzeł `[407]`
Mówca: **Rico Toras**
> ""Well... yes. I don't see another alternative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Rico Toras: ""You understand that this city is a bellwether for our ho..."*)

### Węzeł `[408]`
Mówca: **Rico Toras**
> ""If anything, they are actively working against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Rico Toras: ""You understand that this city is a bellwether for our ho..."*)

### Węzeł `[409]`
Mówca: **Narrator**
> "He snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Rico Toras: ""They can't be counted on to cooperate. If anything, they..."*)

### Węzeł `[410]`
Mówca: **Rico Toras**
> ""They can't be counted on to cooperate. If anything, they're actively plotting against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Rico Toras: ""I'll send you the petition when we are both back home. I..."*)

### Węzeł `[411]`
Mówca: **Rico Toras**
> ""You understand that this city is a bellwether for our house. If we lose it, we lose Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Rico Toras: ""I'll send you the petition when we are both back home. I..."*)

### Węzeł `[412]`
Mówca: **Rico Toras**
> ""I'll send you the petition when we are both back home. I trust you to do what's best for our city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Narrator: "We pulled off the road and continued some distance on a d..."*)

### Węzeł `[413]`
Mówca: **Rico Toras**
> ""I know the Wehzeks were pressuring you to denounce Su Omina. You very wisely saw their witch hunt for what it was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""Just between us... did Su Omina plan the attack?""*)
  - -> `[77]` (*Player_Romus: ""A false flag if I ever saw one. Wehlen obviously planned..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO =..."*)

### Węzeł `[414]`
Mówca: **Rico Toras**
> ""Although we weren't sorry to hear those Wehzeks got what was coming to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Halaita. If it is said, so it is.""*)
  - -> `[81]` (*Player_Romus: ""Have you no compassion, son? Those are human beings who ..."*)

### Węzeł `[415]`
Mówca: **Narrator**
> "Rico smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Rico Toras: ""I will let you in on a secret, though.""*)

### Węzeł `[416]`
Mówca: **Rico Toras**
> ""I will let you in on a secret, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Rico Toras: ""Just prior to the incident, we were about to activate a ..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure I believe that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Rico Toras: ""You don't have to. But I'm telling you the truth.""*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's clearly a ruse planned by the Wehzeks themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Rico Toras: ""They'll be exposed soon enough. They aren't intelligent ..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They're upstanding citizens. I can't imagine they would stoop to violence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Rico Toras: ""No, sir.""*)

### Węzeł `[420]`
Mówca: **Rico Toras**
> ""No, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "He glanced at me conspiratorially."*)

### Węzeł `[421]`
Mówca: **Rico Toras**
> ""You don't have to. But I'm telling you the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Rico Toras: ""I will let you in on a secret, though.""*)

### Węzeł `[422]`
Mówca: **Narrator**
> "Rico contorted his mouth into an approximation of a frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Rico Toras: ""Of course. It was a terrible tragedy.""*)

### Węzeł `[423]`
Mówca: **Rico Toras**
> ""Of course. It was a terrible tragedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Rico Toras: ""I will let you in on a secret, though.""*)

### Węzeł `[424]`
Mówca: **Rico Toras**
> ""It's just us here in this car, isn't it? We can tell it like it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Rico Toras: ""Speaking of which... I'll let you in on a secret.""*)

### Węzeł `[425]`
Mówca: **Rico Toras**
> ""Speaking of which... I'll let you in on a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Rico Toras: ""Just prior to the incident, we were about to activate a ..."*)

### Węzeł `[426]`
Mówca: **Rico Toras**
> ""Just prior to the incident, we were about to activate a branch of Su Omina in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player_Romus: ""To what end, precisely?""*)
  - -> `[431]` (*Player_Romus: ""That would have been an idiotic thing to do without the ..."*)
  - -> `[430]` (*Player_Romus: ""What do you mean, 'activate?'""*)
  - -> `[429]` (*Player_Romus: ""I hope you're not still planning on going through with t..."*)

### Węzeł `[427]`
Mówca: **Rico Toras**
> ""They'll be exposed soon enough. They aren't intelligent enough to cover their own tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Rico Toras: ""I will let you in on a secret, though.""*)

### Węzeł `[428]`
Mówca: **Narrator**
> "He glanced at me conspiratorially."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Rico Toras: ""I will let you in on a secret, though.""*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're not still planning on going through with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Rico Toras: ""Why shouldn't we?""*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean, 'activate?'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Rico Toras: ""The region is teeming with Rizian loyalists anyway. All ..."*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would have been an idiotic thing to do without the King's permission.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Rico Toras: ""The region is teeming with Rizian loyalists anyway. All ..."*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To what end, precisely?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Rico Toras: ""The region is teeming with Rizian loyalists anyway. All ..."*)

### Węzeł `[433]`
Mówca: **Rico Toras**
> ""Why shouldn't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Rico Toras: ""Smolak was never going to hand Zille over on a silver pl..."*)

### Węzeł `[434]`
Mówca: **Rico Toras**
> ""Smolak was never going to hand Zille over on a silver platter. We'll only get back what's ours if we put the screws to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Rico Toras: ""Of course anyone we sent up there would have to operate ..."*)

### Węzeł `[435]`
Mówca: **Rico Toras**
> ""The region is teeming with Rizian loyalists anyway. All they need is a spark.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Rico Toras: ""Smolak was never going to hand Zille over on a silver pl..."*)

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't condone this, Rico.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Rico Toras: ""No, Your Majesty. Of course you can't.""*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Define 'mess with.'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Rico Toras: ""Nothing as extreme as the bombing, mind you. We'd just s..."*)

### Węzeł `[438]`
Mówca: **Rico Toras**
> ""Of course anyone we sent up there would have to operate in total secrecy. But wouldn't it be fun to mess with the Wehzeks?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Player_Romus: ""I can't condone this, Rico.""*)
  - -> `[437]` (*Player_Romus: ""Define 'mess with.'""*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[446]` (*Player_Romus: ""It wouldn't hurt to have more of an upper hand.""*)

### Węzeł `[439]`
Mówca: **Rico Toras**
> ""No, Your Majesty. Of course you can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Narrator: "He winked."*)

### Węzeł `[440]`
Mówca: **Narrator**
> "He winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Player_Romus: ""Were your group's activities in Zille to be revealed, I ..."*)
  - -> `[450]` (*Player_Romus: ""That's not code. If I hear about any Su Omina activity n..."*)
  - -> `[451]` (*Player_Romus: ""Seriously, I appreciate the offer, but I don't want to p..."*)

### Węzeł `[441]`
Mówca: **Rico Toras**
> ""Nothing as extreme as the bombing, mind you. We'd just spread the word about the benevolence of King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Rico Toras: ""With or without some light coercion.""*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already have one pro-Rizian organization active in Zille. I don't need two.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Kontekst wejściowy (poprzednik):** `[438]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Rico Toras: ""We wouldn't interfere with whatever you have in motion. ..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Player_Romus: ""I already have one pro-Rizian organization active in Zil..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It wouldn't hurt to have more of an upper hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Rico Toras: ""Nothing as extreme as the bombing, mind you. We'd just s..."*)

### Węzeł `[447]`
Mówca: **Rico Toras**
> ""With or without some light coercion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""A tempting proposition, but I wouldn't want to put you o..."*)
  - -> `[456]` (*Player_Romus: ""More people should be aware of my benevolence, it's true.""*)
  - -> `[457]` (*Player_Romus: ""I'm not like you. I don't need brute force to accomplish..."*)

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Were your group's activities in Zille to be revealed, I would proclaim complete ignorance of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Rico Toras: ""Quite right.""*)

### Węzeł `[449]`
Mówca: **Rico Toras**
> ""Quite right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Rico Toras: ""The only thing we would need to seal this deal is some a..."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not code. If I hear about any Su Omina activity north of the Wehlen border, I'll have your head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Rico Toras: ""I-- understood.""*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seriously, I appreciate the offer, but I don't want to put your organization at risk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[440]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Rico Toras: ""That should be the least of your worries. We know how to..."*)

### Węzeł `[452]`
Mówca: **Rico Toras**
> ""We wouldn't interfere with whatever you have in motion. We'd simply spread the word about the benevolence of King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Rico Toras: ""With or without some light coercion.""*)

### Węzeł `[453]`
Mówca: **Rico Toras**
> ""I-- understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Rico Toras: ""I was only trying to help.""*)

### Węzeł `[454]`
Mówca: **Rico Toras**
> ""I was only trying to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Rico looked away for a moment. The woods around us were g..."*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A tempting proposition, but I wouldn't want to put you or your organization at risk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Rico Toras: ""That should be the least of your worries. We know how to..."*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More people should be aware of my benevolence, it's true.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Rico Toras: ""Consider us your flag bearers.""*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not like you. I don't need brute force to accomplish my goals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Rico Toras: ""You might not *need* it. But it makes for a fine insuran..."*)

### Węzeł `[458]`
Mówca: **Rico Toras**
> ""That should be the least of your worries. We know how to protect ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Rico Toras: ""You don't have to get your hands dirty, cousin. Just say..."*)

### Węzeł `[459]`
Mówca: **Rico Toras**
> ""Consider us your flag bearers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Rico Toras: ""The only thing we would need to seal this deal is some a..."*)

### Węzeł `[460]`
Mówca: **Rico Toras**
> ""You might not *need* it. But it makes for a fine insurance policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Rico Toras: ""You don't have to get your hands dirty, cousin. Just say..."*)

### Węzeł `[461]`
Mówca: **Rico Toras**
> ""So... we have an understanding, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Mili..."*)
  - -> `[465]` (*Player_Romus: ""Actually... no. You are to limit Su Omina's activity to ..."*)

### Węzeł `[462]`
Mówca: **Narrator**
> "Rico looked away for a moment. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player_Romus: ""If there's anything else you'd like to bring up with you..."*)
  - -> `[390]` (*Player_Romus: ""How are you faring as Duke of Iza, my cousin? Be honest.""*)

### Węzeł `[463]`
**[WYBÓR GRACZA: ""Yes. We are in agreement." [-2 Budget, -250 Military Equipment]"]** — Mówca: **Player_Romus**
> ""Yes. We are in agreement.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250`
- **Kontekst wejściowy (poprzednik):** `[461]` (Rico Toras), `[466]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Narrator: "Rico grinned."*)

### Węzeł `[464]`
**[WYBÓR GRACZA: "Nod. [-2 Budget, -250 Military Equipment]"]** — Mówca: **Player_Romus_Italic**
> "I nodded wordlessly."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250`
- **Kontekst wejściowy (poprzednik):** `[461]` (Rico Toras), `[466]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Narrator: "Rico grinned."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually... no. You are to limit Su Omina's activity to within Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[461]` (Rico Toras), `[466]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Rico Toras: ""I-- understood.""*)

### Węzeł `[466]`
Mówca: **Rico Toras**
> ""You don't have to get your hands dirty, cousin. Just say the word if you want our assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Mili..."*)
  - -> `[465]` (*Player_Romus: ""Actually... no. You are to limit Su Omina's activity to ..."*)
  - -> `[467]` (*Player_Romus: ""I don't know how much clearer I can make this. My answer..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know how much clearer I can make this. My answer is no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Rico Toras: ""I-- understood.""*)

### Węzeł `[468]`
Mówca: **Narrator**
> "Rico grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Rico Toras: ""The Crown has much to gain from this arrangement, Your M..."*)

### Węzeł `[469]`
Mówca: **Rico Toras**
> ""The Crown has much to gain from this arrangement, Your Majesty. And not only in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive = true; ..."*)

### Węzeł `[470]`
Mówca: **Narrator**
> "We kept driving. The woods around us were growing denser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player_Romus: ""If there's anything else you'd like to bring up with you..."*)
  - -> `[390]` (*Player_Romus: ""How are you faring as Duke of Iza, my cousin? Be honest.""*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive = true;
RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO = true;
RiziaDLC.Resources_Military_Equipment -= 250;
RiziaDLC.Resources_Budget -= 2;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2;
RiziaDLC.Zille_ViolentResistancePower += 1;
RiziaDLC.LeaningValue_Democratic -= 2;
RiziaDLC.FundedSO += 1;
RiziaDLC.DeployedSO += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Zille_StartFundingSO"] = true;
Variable["RiziaDLC.Resources_Military_Equipment"] = Variable["RiziaDLC.Resources_Military_Equipment"] - 250;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 2;
Variable["RiziaDLC.FundedSO"] = Variable["RiziaDLC.FundedSO"] + 1;
Variable["RiziaDLC.DeployedSO"] = Variable["RiziaDLC.DeployedSO"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Narrator: "We kept driving. The woods around us were growing denser."*)

### Węzeł `[472]`
Mówca: **Narrator**
> "We pulled off the road and continued some distance on a dirt path that wound through the pines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "We came to a halt at the mouth of a grassy clearing with ..."*)

### Węzeł `[473]`
Mówca: **Narrator**
> "We came to a halt at the mouth of a grassy clearing with gently sloping sides. Hunting blinds lined its perimeter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "In my youth, Hugo and I had nicknamed it the 'Soup Tureen'.""*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Narrator: "It vaguely resembled a gigantic serving vessel."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "In my youth, Hugo and I had nicknamed it the 'Soup Tureen'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Rico Toras: ""At last! Enough politics talk.""*)

### Węzeł `[478]`
Mówca: **Narrator**
> "It vaguely resembled a gigantic serving vessel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Rico Toras: ""At last! Enough politics talk.""*)

### Węzeł `[479]`
Mówca: **Rico Toras**
> ""At last! Enough politics talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Narrator: "We disembarked and Rico eagerly unlatched the back of our..."*)

### Węzeł `[480]`
Mówca: **Narrator**
> "We disembarked and Rico eagerly unlatched the back of our jeep. Bella and Bruno hopped out and started sniffing the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Rico Toras: ""Caught the scent already, my dears? Must be dozens of bo..."*)

### Węzeł `[481]`
Mówca: **Narrator**
> "The other car pulled up next to us. Hugo and Vina got out, still in conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras"); AddConversant("Hugo Toras");"*)

### Węzeł `[482]`
Mówca: **Hugo Toras**
> ""...so you see, Your Highness, knowing how to aim and fire a gun correctly is as useful a royal skill as knowing how to hold a salad fork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Player_Romus: ""Keep at it, Hugo. You'll make a huntress out of my daugh..."*)
  - -> `[484]` (*Player_Romus: ""With the essential difference that lettuce doesn't bleed..."*)
  - -> `[485]` (*Player_Romus: ""I trust you two enjoyed the car ride?""*)
  - -> `[486]` (*Player_Romus: ""Don't listen to Hugo, Vina. Your uncle's a notoriously t..."*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep at it, Hugo. You'll make a huntress out of my daughter yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Hugo Toras: ""With her instincts, she'll be the finest shot this kingd..."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the essential difference that lettuce doesn't bleed when you pierce it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Hugo chuckled politely. He waved his son over."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you two enjoyed the car ride?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Hugo Toras: ""It's always a pleasure to get to know the princess better.""*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't listen to Hugo, Vina. Your uncle's a notoriously terrible shot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Narrator: "Hugo scowled at me briefly. He waved his son over."*)

### Węzeł `[487]`
Mówca: **Narrator**
> "Hugo scowled at me briefly. He waved his son over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Hugo Toras: ""I've bored you enough, Your Highness. I believe Rico was..."*)

### Węzeł `[488]`
Mówca: **Hugo Toras**
> ""It's always a pleasure to get to know the princess better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "He waved his son over."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "He waved his son over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Hugo Toras: ""But I've bored you enough, Your Highness. I believe Rico..."*)

### Węzeł `[490]`
Mówca: **Hugo Toras**
> ""I've bored you enough, Your Highness. I believe Rico was going to show you the ropes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Rico Toras: ""I would be delighted to. If the King permits.""*)

### Węzeł `[491]`
Mówca: **Narrator**
> "Hugo chuckled politely. He waved his son over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Hugo Toras: ""I've bored you enough, Your Highness. I believe Rico was..."*)

### Węzeł `[492]`
Mówca: **Hugo Toras**
> ""With her instincts, she'll be the finest shot this kingdom ever saw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "He waved his son over."*)

### Węzeł `[493]`
Mówca: **Hugo Toras**
> ""Why not let the youngsters have their fun? Old men like us would slow them down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Rico Toras: ""You're damned right about that, Father. Shall we, Vina?""*)

### Węzeł `[494]`
Mówca: **Rico Toras**
> ""You're damned right about that, Father. Shall we, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Narrator: "He beckoned to Vina again. She hesitantly followed him ov..."*)

### Węzeł `[495]`
Mówca: **Narrator**
> "He beckoned to Vina again. She hesitantly followed him over to the nearest hunting blind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Rico To..."*)

### Węzeł `[496]`
Mówca: **Narrator**
> "Hugo shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Hugo Toras: ""The two of us it is, Your Majesty.""*)

### Węzeł `[497]`
Mówca: **Hugo Toras**
> ""The two of us it is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 == true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_KA74 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_KA74"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Rico Toras: ""See, Father? We'll have bagged a dozen boars before you'..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_Hunting_Rifle = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Hunting_Rifle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Hugo smirked at his son."*)

### Węzeł `[500]`
Mówca: **Hugo Toras**
> ""And now we play the waiting game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "There was a long stretch of silence, punctuated only by t..."*)

### Węzeł `[501]`
Mówca: **Narrator**
> "There was a long stretch of silence, punctuated only by the chirping of birds and the occasional bark of Bella and Bruno in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Hugo Toras: ""I may not like Rico's hunting methods, but his dogs are ..."*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't help but think you and he had an ulterior motive for inviting us here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Narrator: "He calmly adjusted his rifle's sight."*)

### Węzeł `[503]`
Mówca: **Hugo Toras**
> ""And yet night and day are inseparable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Hugo Toras: ""What are Her Highness' other options? A rival house? A f..."*)

### Węzeł `[504]`
Mówca: **Hugo Toras**
> ""Her cousin once removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Hugo Toras: ""As you know, there are interests both inside and outside..."*)

### Węzeł `[505]`
Mówca: **Hugo Toras**
> ""Consanguinity wouldn't be my first choice, either. But it's the only way to keep our family in power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Player_Romus: ""You may have a point, but it's still Vina's decision.""*)
  - -> `[518]` (*Player_Romus: ""Let's see how they get along today before we start makin..."*)
  - -> `[519]` (*Player_Romus: ""Our family has been in power long enough.""*)
  - -> `[522]` (*Player_Romus: ""The right alliances can make us more powerful than blood..."*)

### Węzeł `[506]`
Mówca: **Hugo Toras**
> ""That is indeed shocking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Hugo Toras: ""As you know, there are interests both inside and outside..."*)

### Węzeł `[507]`
Mówca: **Hugo Toras**
> ""What are Her Highness' other options? A rival house? A foreign prince? Anyone other than Rico would dilute our family's blood and loosen our grip on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Player_Romus: ""You may have a point, but it's still Vina's decision.""*)
  - -> `[518]` (*Player_Romus: ""Let's see how they get along today before we start makin..."*)
  - -> `[519]` (*Player_Romus: ""Our family has been in power long enough.""*)
  - -> `[522]` (*Player_Romus: ""The right alliances can make us more powerful than blood..."*)

### Węzeł `[508]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? No! They're cousins!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[513]` (Hugo Toras), `[515]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Hugo Toras: ""Once removed.""*)

### Węzeł `[509]`
Mówca: **Hugo Toras**
> ""Once removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Hugo Toras: ""What are Her Highness' other options? A rival house? A f..."*)

### Węzeł `[510]`
Mówca: **Hugo Toras**
> ""But more pressingly, if my son and your daughter are to be married, they ought to spend time together first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Hugo Toras: ""Or have you seriously never considered the possibility?""*)

### Węzeł `[511]`
Mówca: **Narrator**
> "He calmly adjusted his rifle's sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Hugo Toras: ""Of course there's the nastiness with Wehlen.""*)

### Węzeł `[512]`
Mówca: **Hugo Toras**
> ""Of course there's the nastiness with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Hugo Toras: ""But more pressingly, if my son and your daughter are to ..."*)

### Węzeł `[513]`
Mówca: **Hugo Toras**
> ""So you'll consider him as a marriage prospect for your daughter, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""Shockingly enough, the thought never crossed my mind.""*)
  - -> `[508]` (*Player_Romus: ""What? No! They're cousins!""*)
  - -> `[514]` (*Player_Romus: ""I never said that. Vina deserves to marry a gentleman.""*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never said that. Vina deserves to marry a gentleman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[513]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[515]`
Mówca: **Hugo Toras**
> ""Or have you seriously never considered the possibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage == true"*)
  - -> `[146]` (*Player_Romus: ""Shockingly enough, the thought never crossed my mind.""*)
  - -> `[147]` (*Player_Romus: ""I might have if your son were more of a gentleman.""*)
  - -> `[508]` (*Player_Romus: ""What? No! They're cousins!""*)

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point, but it's still Vina's decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Hugo Toras), `[507]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Hugo Toras: ""Letting youngsters 'follow their hearts' is a recipe for..."*)

### Węzeł `[517]`
Mówca: **Hugo Toras**
> ""Letting youngsters 'follow their hearts' is a recipe for disaster. My brother was the ultimate example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Hugo Toras: ""As your uncle and your advisor, this is my advice. You m..."*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's see how they get along today before we start making wedding arrangements.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Hugo Toras), `[507]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Hugo Toras: ""Fair enough. Rico can be quite the charmer when he sets ..."*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our family has been in power long enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Hugo Toras), `[507]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Hugo Toras: ""Not as long as God has preordained.""*)

### Węzeł `[520]`
Mówca: **Hugo Toras**
> ""Not as long as God has preordained.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Hugo Toras: ""As your uncle and your advisor, this is my advice. You m..."*)

### Węzeł `[521]`
Mówca: **Hugo Toras**
> ""Fair enough. Rico can be quite the charmer when he sets his mind to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Hugo Toras: ""As your uncle and your advisor, this is my advice. You m..."*)

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The right alliances can make us more powerful than blood alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Hugo Toras), `[507]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Hugo Toras: ""And the wrong ones will doom us to history's dustbin.""*)

### Węzeł `[523]`
Mówca: **Hugo Toras**
> ""And the wrong ones will doom us to history's dustbin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Hugo Toras: ""As your uncle and your advisor, this is my advice. You m..."*)

### Węzeł `[524]`
Mówca: **Hugo Toras**
> ""As your uncle and your advisor, this is my advice. You may follow or disregard it as you choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Just then, we heard a rustling sound coming from the wood..."*)

### Węzeł `[525]`
Mówca: **Narrator**
> "Looking through my gun sight, I fixed my crosshairs on the group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus_Italic: "Shoot a boar."*)
  - -> `[154]` (*Player_Romus_Italic: "Miss intentionally."*)

### Węzeł `[526]`
Mówca: **Narrator**
> "My uncle gave me a look of disapproval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Hugo Toras: ""Not very sporting, if you ask me.""*)

### Węzeł `[527]`
Mówca: **Narrator**
> "He looked up at me with almost feral eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Rico Toras: ""What the hell, cousin? You shot my dog!""*)

### Węzeł `[528]`
Mówca: **Hugo Toras**
> ""For God's sake, Rico, shut your mouth!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Hugo Toras: ""My deepest apologies, Your Majesty. My son's not in his ..."*)

### Węzeł `[529]`
Mówca: **Hugo Toras**
> ""My deepest apologies, Your Majesty. My son's not in his right mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Vina bent down and stroked Bruno's fur. The dog raised hi..."*)

### Węzeł `[530]`
Mówca: **Rico Toras**
> ""Please excuse my outburst, Your Majesty. I understand you weren't aiming for Bruno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Rico Toras: ""But what good is a hunting dog who can't hunt?""*)

### Węzeł `[531]`
Mówca: **Rico Toras**
> ""But what good is a hunting dog who can't hunt?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player_Romus: ""You're still holding a gun. Put him out of his misery.""*)
  - -> `[540]` (*Player_Romus: ""I'll take him, then. I wouldn't mind having a dog around..."*)
  - -> `[536]` (*Player_Romus: ""Put him out to stud. I bet he's got good blood, doesn't ..."*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still holding a gun. Put him out of his misery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Vina Toras: ""What? Father! No!""*)

### Węzeł `[533]`
Mówca: **Vina Toras**
> ""What? Father! No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "Rico looked at me, appalled."*)

### Węzeł `[534]`
Mówca: **Narrator**
> "Rico looked at me, appalled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Rico Toras: ""How big of an asshole do you think I am, Your Majesty?""*)

### Węzeł `[535]`
Mówca: **Rico Toras**
> ""How big of an asshole do you think I am, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Player_Romus: ""You don't care about dead Wehzeks, but you care about an..."*)
  - -> `[556]` (*Player_Romus: ""Sorry. That was a joke.""*)
  - -> `[557]` (*Player_Romus: ""You said it yourself. He's useless on three legs.""*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Put him out to stud. I bet he's got good blood, doesn't he?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Narrator: "Rico half-smirked at me."*)

### Węzeł `[537]`
Mówca: **Narrator**
> "Rico half-smirked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Rico Toras: ""A purebred through and through, Your Majesty.""*)

### Węzeł `[538]`
Mówca: **Rico Toras**
> ""A purebred through and through, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Rico Toras: ""All right. I'll keep the poor fellow around.""*)

### Węzeł `[539]`
Mówca: **Rico Toras**
> ""All right. I'll keep the poor fellow around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Hugo Toras: ""Rico, Vina, why don't you two take Bruno back to the pal..."*)

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll take him, then. I wouldn't mind having a dog around the palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Narrator: "Vina's eyes widened."*)

### Węzeł `[541]`
Mówca: **Narrator**
> "Vina's eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Vina Toras: ""Really, Father?""*)

### Węzeł `[542]`
Mówca: **Vina Toras**
> ""Really, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Player_Romus: ""A three-legged royal dog? The public will love it!""*)
  - -> `[544]` (*Player_Romus: ""Who knows what your brute of a cousin will do to him if ..."*)
  - -> `[543]` (*Player_Romus: ""I shot the poor fellow. He's my responsibility now.""*)

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I shot the poor fellow. He's my responsibility now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[542]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Rico looked down at his dog."*)

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who knows what your brute of a cousin will do to him if I don't take him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[542]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Rico looked down at his dog."*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A three-legged royal dog? The public will love it!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[542]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Rico looked down at his dog."*)

### Węzeł `[546]`
Mówca: **Narrator**
> "Rico looked down at his dog."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Rico Toras: ""Well, Bruno? You want to go live in Porte Drazon?""*)

### Węzeł `[547]`
Mówca: **Rico Toras**
> ""Well, Bruno? You want to go live in Porte Drazon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Bruno: ""Aroo...""*)

### Węzeł `[548]`
Mówca: **Narrator**
> "Rico looked at me and shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Rico Toras: ""Very well, Your Majesty. He eats only raw meat. Venison,..."*)

### Węzeł `[549]`
Mówca: **Rico Toras**
> ""Very well, Your Majesty. He eats only raw meat. Venison, if you have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Narrator: "He reached into his vest pocket."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC...."*)
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDL..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Rico Toras: ""Take good care of him. And this won't affect the agreeme..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Rico Toras: ""Take good care of him. And I hope you'll give extra cons..."*)

### Węzeł `[553]`
Mówca: **Rico Toras**
> ""Take good care of him. And this won't affect the agreement we made today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted = true; RiziaDLC.Relations_Vina..."*)

### Węzeł `[554]`
Mówca: **Rico Toras**
> ""Take good care of him. And I hope you'll give extra consideration to my police request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted = true; RiziaDLC.Relations_Vina..."*)

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't care about dead Wehzeks, but you care about an injured dog?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[535]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Rico Toras: ""Wehzeks are expendable. Bruno is a royal pedigree.""*)

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. That was a joke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[535]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Vina Toras: ""It wasn't funny, Father.""*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said it yourself. He's useless on three legs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[535]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Rico Toras: ""No, no. I'll find something to do with him.""*)

### Węzeł `[558]`
Mówca: **Rico Toras**
> ""No, no. I'll find something to do with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Rico Toras: ""Actually... if he can't hunt, I can still put him out to..."*)

### Węzeł `[559]`
Mówca: **Vina Toras**
> ""It wasn't funny, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Rico Toras: ""Let's take him home. I'll figure out what to do with him..."*)

### Węzeł `[560]`
Mówca: **Rico Toras**
> ""Wehzeks are expendable. Bruno is a royal pedigree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Rico Toras: ""Actually... if he can't hunt, I can still put him out to..."*)

### Węzeł `[561]`
Mówca: **Rico Toras**
> ""Actually... if he can't hunt, I can still put him out to stud. Wouldn't want to let a good bloodline go to waste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Narrator: "He half-smirked at me."*)

### Węzeł `[562]`
Mówca: **Narrator**
> "He half-smirked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Hugo Toras: ""Rico, Vina, why don't you two take Bruno back to the pal..."*)

### Węzeł `[563]`
Mówca: **Rico Toras**
> ""Let's take him home. I'll figure out what to do with him there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Hugo Toras: ""Rico, Vina, why don't you two take Bruno back to the pal..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted = true; RiziaDLC.Relations_Vina += 1; RiziaDLCSupport.Journal_Turn03_Iza_AdoptBruno = true;
RiziaDLCSupport.News_RH_Turn03_Gossip_BrunoAdopted = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BrunoDog_Adopted"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;
Variable["RiziaDLCSupport.Journal_Turn03_Iza_AdoptBruno"] = true;
Variable["RiziaDLCSupport.News_RH_Turn03_Gossip_BrunoAdopted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_Bruno");"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "East of the palace, the landscape quickly turned hilly an..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "After months of promises and schedule conflicts, Vina and..."*)

### Węzeł `[568]`
Mówca: **Narrator**
> "He got to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Hugo Toras: ""Rico, Vina, why don't you two take Bruno back to the pal..."*)

### Węzeł `[569]`
Mówca: **Hugo Toras**
> ""Rico, Vina, why don't you two take Bruno back to the palace? His Majesty and I will wrap everything up here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Narrator: "My uncle gave me a meaningful glance."*)

### Węzeł `[570]`
Mówca: **Narrator**
> "My uncle gave me a meaningful glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Player_Romus: ""Yes, you two go on.""*)
  - -> `[572]` (*Player_Romus: ""Actually, I'd prefer to travel with the princess.""*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you two go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Narrator: "Vina nodded solemnly and turned to Rico."*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I'd prefer to travel with the princess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina >= 0"*)

### Węzeł `[573]`
Mówca: **Narrator**
> "Vina nodded solemnly and turned to Rico."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Vina Toras: ""You can tell me more about Bruno on the way.""*)

### Węzeł `[574]`
Mówca: **Vina Toras**
> ""You can tell me more about Bruno on the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina >= 0"*)
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina >= 0)"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Vina Toras: ""Let's go, then.""*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Narrator: "Vina looked at me coldly."*)

### Węzeł `[578]`
Mówca: **Vina Toras**
> ""Let's go, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[579]`
Mówca: **Narrator**
> "The assistants carefully placed Bruno on a blanket in the back of one of the jeeps. Hugo and Rico got in, and the car sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "My daughter and I got in the other car and followed them ..."*)

### Węzeł `[580]`
Mówca: **Narrator**
> "My daughter and I got in the other car and followed them back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false"*)

### Węzeł `[581]`
Mówca: **Narrator**
> "Vina looked at me coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Vina Toras: ""If it's quite all right, I'll go with Rico. He can tell ..."*)

### Węzeł `[582]`
Mówca: **Vina Toras**
> ""If it's quite all right, I'll go with Rico. He can tell me more about Bruno on the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "The assistants carefully placed Bruno on a blanket in the..."*)

### Węzeł `[583]`
Mówca: **Narrator**
> "In front of the university library, a construction crew was hastily pulling a sheet over a large object."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Player_Romus: ""We don't have time to stop. Let's just get to Rico's.""*)
  - -> `[584]` (*Player_Romus: ""Stop the car at once. I want to see what's under that sh..."*)

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop the car at once. I want to see what's under that sheet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[583]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Iza_SawStatues = true"*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have time to stop. Let's just get to Rico's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[583]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[586]`
Mówca: **Narrator**
> "We came to a halt. My guards exited the car and ordered the workers to remove the sheet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true"*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true"*)
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true)"*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Narrator: "Beneath it was one of the statues I'd commissioned of my ..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus..."*)

### Węzeł `[590]`
Mówca: **Narrator**
> "Beneath it was one of the statues I'd commissioned of my father, King Valero."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Narrator: "His head had been chopped off."*)

### Węzeł `[591]`
Mówca: **Narrator**
> "His head had been chopped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Player_Romus: ""Don't worry, Vina. It's only my father they're mad at, n..."*)
  - -> `[601]` (*Player_Romus: ""Looks like the good people of Iza are exercising their f..."*)
  - -> `[599]` (*Player_Romus: ""This is an outrage. The guilty party must be found and p..."*)
  - -> `[600]` (*Player_Romus: ""How could Rico have allowed this to happen?""*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus..."*)
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRom..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "Beneath it was one of the statues I'd commissioned earlie..."*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "Beneath it was one of the statues I'd commissioned earlie..."*)

### Węzeł `[595]`
Mówca: **Narrator**
> "Beneath it was one of the statues I'd commissioned earlier in my reign, depicting myself standing beside my father King Valero."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "Both of our heads had been chopped off."*)

### Węzeł `[596]`
Mówca: **Narrator**
> "Both of our heads had been chopped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Romus: ""Don't worry, Vina. I'm sure it's just teenage vandals.""*)
  - -> `[601]` (*Player_Romus: ""Looks like the good people of Iza are exercising their f..."*)
  - -> `[599]` (*Player_Romus: ""This is an outrage. The guilty party must be found and p..."*)
  - -> `[600]` (*Player_Romus: ""How could Rico have allowed this to happen?""*)

### Węzeł `[597]`
Mówca: **Narrator**
> "Beneath it was one of the statues I'd commissioned earlier in my reign, depicting the Toras lineage: my father, myself, and Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Narrator: "All of our heads had been chopped off."*)

### Węzeł `[598]`
Mówca: **Narrator**
> "All of our heads had been chopped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Player_Romus: ""Don't worry, Vina. I'm sure it's just teenage vandals.""*)
  - -> `[601]` (*Player_Romus: ""Looks like the good people of Iza are exercising their f..."*)
  - -> `[599]` (*Player_Romus: ""This is an outrage. The guilty party must be found and p..."*)
  - -> `[600]` (*Player_Romus: ""How could Rico have allowed this to happen?""*)

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is an outrage. The guilty party must be found and punished.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Narrator), `[596]` (Narrator), `[598]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could Rico have allowed this to happen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Narrator), `[596]` (Narrator), `[598]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks like the good people of Iza are exercising their freedom of expression.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Narrator), `[596]` (Narrator), `[598]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Vina. It's only my father they're mad at, not you or me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[591]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Vina Toras: ""I'm not worried.""*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Vina. I'm sure it's just teenage vandals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[596]` (Narrator), `[598]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Vina Toras: ""I'm not worried.""*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Narrator: "Her face looked noticeably paler. She unconsciously put a..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Narrator: "She wore a bemused expression on her face."*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[608]`
Mówca: **Vina Toras**
> ""I'm not worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[609]`
Mówca: **Narrator**
> "Her face looked noticeably paler. She unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Vina Toras: ""I wonder if Rico wanted us to see this. He's trying to c..."*)

### Węzeł `[610]`
Mówca: **Narrator**
> "She wore a bemused expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Vina Toras: ""I wonder if Rico wanted us to see this. He's trying to c..."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Vina Toras: ""You're not worried, Father?""*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Vina Toras: ""Today it's statues they're beheading, tomorrow...""*)

### Węzeł `[614]`
Mówca: **Vina Toras**
> ""You're not worried, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Narrator: "Vina unconsciously put a hand to her own neck."*)

### Węzeł `[615]`
Mówca: **Vina Toras**
> ""Today it's statues they're beheading, tomorrow...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "Vina laughed grimly."*)

### Węzeł `[616]`
Mówca: **Narrator**
> "Vina laughed grimly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Vina Toras: ""I wonder if Rico wanted us to see this. He's trying to c..."*)

### Węzeł `[617]`
Mówca: **Vina Toras**
> ""Do you think Rico wanted us to see this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Vina Toras: ""He's trying to crack down on crime here, isn't he? What ..."*)

### Węzeł `[618]`
Mówca: **Vina Toras**
> ""He's trying to crack down on crime here, isn't he? What better excuse than sedition against the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Player_Romus: ""That's a good theory, Vina. You're as perceptive as your..."*)
  - -> `[639]` (*Player_Romus: ""If he can't keep vandals from defacing royal statues bef..."*)
  - -> `[640]` (*Player_Romus: ""Either way, this is a disgrace. Order must be brought to..."*)
  - -> `[641]` (*Player_Romus: ""This is bigger than just Iza. The anti-monarchist foreig..."*)

### Węzeł `[619]`
Mówca: **Vina Toras**
> ""It's certainly not a warm welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Narrator: "Her face looked noticeably paler. She unconsciously put a..."*)

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a good theory, Vina. You're as perceptive as your mother was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Vina Toras: ""Thank you, Father.""*)

### Węzeł `[621]`
Mówca: **Vina Toras**
> ""I wonder if Rico wanted us to see this. He's trying to crack down on crime here, isn't he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Vina Toras: ""What better excuse than sedition against the royal family?""*)

### Węzeł `[622]`
Mówca: **Vina Toras**
> ""What better excuse than sedition against the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Player_Romus: ""If he can't keep a few troublemakers from defacing statu..."*)
  - -> `[626]` (*Player_Romus: ""'Sedition' is a strong word. This is just some light hoo..."*)
  - -> `[627]` (*Player_Romus: ""If that's his strategy, it's not a very smart one. He's ..."*)
  - -> `[624]` (*Player_Romus: ""That's a good theory, Vina. You're as perceptive as your..."*)

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he can't keep a few troublemakers from defacing statues, he's not fit to be in charge here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[622]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Vina Toras: ""Beheading royals strikes me as more than mere 'troublema..."*)

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a good theory, Vina. You're as perceptive as your mother was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[622]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Vina Toras: ""Thank you, Father.""*)

### Węzeł `[625]`
Mówca: **Narrator**
> "Vina unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Vina Toras: ""I wonder if Rico wanted us to see this. He's trying to c..."*)

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Sedition' is a strong word. This is just some light hooliganism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[622]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Vina Toras: ""I don't know, Father. Beheading royals is a strong state..."*)

### Węzeł `[627]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's his strategy, it's not a very smart one. He's allowing the authority of House Toras to be undermined.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[622]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Vina Toras: ""Then it's good that the King of Rizia is on his way to r..."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Vina Toras: ""It's certainly not a warm welcome.""*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Vina Toras: ""It's certainly not a warm welcome.""*)

### Węzeł `[631]`
Mówca: **Narrator**
> "Her face looked noticeably paler. She unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Vina Toras: ""Do you think Rico wanted us to see this?""*)

### Węzeł `[632]`
Mówca: **Vina Toras**
> ""It's certainly not a warm welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Narrator: "Vina laughed bleakly."*)

### Węzeł `[633]`
Mówca: **Narrator**
> "Vina laughed bleakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Vina Toras: ""Do you think Rico wanted us to see this?""*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Vina Toras: ""Like Duchess Azaro said, he's in over his head.""*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Vina Toras: ""If there's a revolution coming, it doesn't need House To..."*)

### Węzeł `[637]`
Mówca: **Vina Toras**
> ""Like Duchess Azaro said, he's in over his head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Narrator: "She unconsciously put a hand to her own neck."*)

### Węzeł `[638]`
Mówca: **Narrator**
> "She unconsciously put a hand to her own neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Vina Toras: ""Do you think Rico wanted us to see this?""*)

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he can't keep vandals from defacing royal statues before the King's visit, he doesn't deserve my support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Vina Toras: ""I suppose you'll have to hear him out first. Find out wh..."*)

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Either way, this is a disgrace. Order must be brought to Iza one way or another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Vina Toras: ""Good thing the King of Rizia is on his way to restore it.""*)

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is bigger than just Iza. The anti-monarchist foreign powers are out to get us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Vina Toras: ""If that were true, it wouldn't just be statues losing th..."*)

### Węzeł `[642]`
Mówca: **Vina Toras**
> ""If there's a revolution coming, it doesn't need House Toras' permission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Narrator: "Vina laughed bleakly."*)

### Węzeł `[643]`
Mówca: **Narrator**
> "Vina laughed bleakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Vina Toras: ""Do you think Rico wanted us to see this?""*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Vina Toras: ""Now can we please get this over with?""*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Vina Toras: ""Hugo's meeting us here too, right? Why do you think they..."*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Talk to me, Vina. What's going on with you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[650]` (Narrator), `[701]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Vina Toras: ""Nothing. Remind me again why I have to be here?""*)

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the attitude. You're the Princess of Rizia and I want you on your best behavior for this visit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[650]` (Narrator), `[701]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Narrator: "She straightened up a little."*)

### Węzeł `[649]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I didn't comment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[650]` (Narrator), `[701]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "We rode on in silence until we reached Palas Sazon."*)

### Węzeł `[650]`
Mówca: **Narrator**
> "She sighed audibly and slouched against the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Player_Romus: ""Talk to me, Vina. What's going on with you?""*)
  - -> `[648]` (*Player_Romus: ""Enough with the attitude. You're the Princess of Rizia a..."*)
  - -> `[649]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Vina Toras: ""Yes, let's get this over with.""*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Vina Toras: ""Hugo's meeting us here too, right? Why do you think they..."*)

### Węzeł `[654]`
Mówca: **Vina Toras**
> ""Yes, let's get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Narrator: "She sighed audibly and slouched against the window."*)

### Węzeł `[655]`
Mówca: **Vina Toras**
> ""Thank you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[656]`
Mówca: **Vina Toras**
> ""Now can we please get this over with?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Narrator: "She sighed audibly and slouched against the window."*)

### Węzeł `[657]`
Mówca: **Vina Toras**
> ""I don't know, Father. Beheading royals is a strong statement, even if they're only made of marble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[658]`
Mówca: **Vina Toras**
> ""Beheading royals strikes me as more than mere 'troublemaking', Father. Even if they're only made of marble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[659]`
Mówca: **Vina Toras**
> ""Then it's good that the King of Rizia is on his way to restore that authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[660]`
Mówca: **Vina Toras**
> ""I suppose you'll have to hear him out first. Find out what he actually wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[661]`
Mówca: **Vina Toras**
> ""Good thing the King of Rizia is on his way to restore it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[662]`
Mówca: **Vina Toras**
> ""If that were true, it wouldn't just be statues losing their heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[663]`
Mówca: **Narrator**
> "She straightened up a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Vina Toras: ""I understand, Father. I won't make a scene.""*)

### Węzeł `[664]`
Mówca: **Vina Toras**
> ""I understand, Father. I won't make a scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "We rode on in silence until we reached Palas Sazon."*)

### Węzeł `[665]`
Mówca: **Vina Toras**
> ""Nothing. Remind me again why I have to be here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Player_Romus: ""I want your opinion on the Rico situation. It's valuable..."*)
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway == true"*)
  - -> `[667]` (*Player_Romus: ""Because your family has requested your presence, and fam..."*)
  - -> `[666]` (*Player_Romus: ""Because your king commands it.""*)

### Węzeł `[666]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because your king commands it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[665]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Narrator: "She straightened up a little."*)

### Węzeł `[667]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because your family has requested your presence, and family is the most important thing in this world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[665]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Vina Toras: ""And your own daughter's wishes? Those are of no importan..."*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway == true"*)
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_TookBookAway == true)"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Player_Romus: ""Because if I leave you alone, you'll start reading that ..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_TookBookAway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because if I leave you alone, you'll start reading that propaganda again.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Kontekst wejściowy (poprzednik):** `[665]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Vina Toras: ""And wake up to the truth about how the world works? Yes,..."*)

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want your opinion on the Rico situation. It's valuable to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[665]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[673]`
Mówca: **Vina Toras**
> ""Whatever you say, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "We rode on in silence until we reached Palas Sazon."*)

### Węzeł `[674]`
Mówca: **Narrator**
> "She smiled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[675]`
Mówca: **Vina Toras**
> ""And wake up to the truth about how the world works? Yes, heaven forbid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Narrator: "She sighed again."*)

### Węzeł `[676]`
Mówca: **Vina Toras**
> ""And your own daughter's wishes? Those are of no importance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Narrator: "She sighed again."*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Narrator: "She smiled slightly."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Vina Toras: ""If you wanted my opinion, you should've let me on your c..."*)

### Węzeł `[680]`
Mówca: **Vina Toras**
> ""If you wanted my opinion, you should've let me on your council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Narrator: "She sighed again."*)

### Węzeł `[681]`
Mówca: **Vina Toras**
> ""All right. I'll try to gather all the insight I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "We rode on in silence until we reached Palas Sazon."*)

### Węzeł `[682]`
Mówca: **Narrator**
> "She straightened up a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Vina Toras: ""Whatever you say, Your Majesty.""*)

### Węzeł `[683]`
Mówca: **Narrator**
> "We rode on in silence until we reached Palas Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Under Rico's stewardship, a formidable-looking iron gate ..."*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Vina Toras: ""All right. I'll try to gather all the insight I can.""*)

### Węzeł `[685]`
Mówca: **Narrator**
> "She sighed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Vina Toras: ""Sorry, Your Majesty. I'll be on my best behavior with Co..."*)

### Węzeł `[686]`
Mówca: **Vina Toras**
> ""Sorry, Your Majesty. I'll be on my best behavior with Cousin Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Narrator: "We rode on in silence until we reached Palas Sazon."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Iza_SawStatues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Narrator: "We came to a halt. My guards exited the car and ordered t..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Iza_SawStatues == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Iza_SawStatues == true"*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Iza_SawStatues == true)"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Iza_SawStatues == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player_Romus: ""The headless statues.""*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Iza_SawStatues == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false"*)
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false)"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_PorteDrazon_GenderPayGap =..."*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_EqualPayMenWomen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Order_SuOmina_ActivitiesIncrease"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "Rico looked away for a moment. The woods around us were g..."*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true || RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true || RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true..."*)
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == tr..."*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true || RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true || RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Vina suddenly tapped me on the shoulder."*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_FamilyStatues_KingValero == true || RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus == true || RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValero"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_KingValeroAndRomus"] == true  or  Variable["RiziaDLC.Decision_Turn02_FamilyStatues_TorasFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Narrator: "We passed a street cleaner who was rapidly trying to scru..."*)

### Węzeł `[699]`
Mówca: **Narrator**
> "We passed a street cleaner who was rapidly trying to scrub graffiti off of the side of a building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Narrator: "I could just make out the remnants. They read "House Tora..."*)

### Węzeł `[700]`
Mówca: **Narrator**
> "I could just make out the remnants. They read "House Toras Will Fall"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[701]`
Mówca: **Narrator**
> "Vina didn't seem to notice. She sighed audibly as she slouched against the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Player_Romus: ""Talk to me, Vina. What's going on with you?""*)
  - -> `[648]` (*Player_Romus: ""Enough with the attitude. You're the Princess of Rizia a..."*)
  - -> `[649]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Narrator: "Vina didn't seem to notice. She sighed audibly as she slo..."*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Narrator: "Vina didn't seem to notice. She looked lost in thought."*)

### Węzeł `[705]`
Mówca: **Narrator**
> "Vina didn't seem to notice. She looked lost in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Vina Toras: ""Hugo's meeting us here too, right? Why do you think they..."*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO =..."*)
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO..."*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Player_Romus: ""That doesn't mean I approve of the group or its activiti..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""What choice did I have? Members of our house must stand ..."*)

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't mean I approve of the group or its activities.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DefendSO"] == false`
- **Kontekst wejściowy (poprzednik):** `[413]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Rico Toras: ""Of course, of course. You're entitled to your own opinion.""*)

### Węzeł `[710]`
Mówca: **Rico Toras**
> ""Of course, of course. You're entitled to your own opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Rico Toras: ""Nonetheless, I appreciate it. Especially since the organ..."*)

### Węzeł `[711]`
Mówca: **Narrator**
> "He reached into his vest pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Rico Toras: ""Here's his favorite toy.""*)

### Węzeł `[712]`
Mówca: **Rico Toras**
> ""Here's his favorite toy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_DogToy");"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_DogToy");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_DogToy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true || RiziaDLC...."*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Iza_SawStatues == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_Iza_SawStatues == true"*)
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_Iza_SawStatues == true)"*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_Iza_SawStatues == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""To see something like those statues, I wager. Give us an..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_Iza_SawStatues == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_Iza_SawStatues"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_Denounce..."*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Rico Toras: ""You refused to denounce Su Omina in the face of pressure..."*)

### Węzeł `[720]`
Mówca: **Rico Toras**
> ""You refused to denounce Su Omina in the face of pressure from Wehlen. For that, we -- they -- are grateful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Rico Toras: ""But then I got wind of your investigation. Tell me, cous..."*)

### Węzeł `[721]`
Mówca: **Rico Toras**
> ""But then I got wind of your investigation. Tell me, cousin, do you really think I keep company with terrorists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Don't forget to whom you are speaking, Duke Toras. Count..."*)
  - -> `[64]` (*Player_Romus: ""I had no other choice. I'm trying to avoid an internatio..."*)
  - -> `[722]` (*Player_Romus: ""No, I don't. Assuming you are innocent, the investigatio..."*)
  - -> `[723]` (*Player_Romus: ""You tell me, Ricardus. Do you have something to hide?""*)

### Węzeł `[722]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I don't. Assuming you are innocent, the investigation will clear your name.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[721]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Rico Toras: ""Trust me, nobody I know has a clue who was behind the Zi..."*)

### Węzeł `[723]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You tell me, Ricardus. Do you have something to hide?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[721]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Rico Toras: ""With regards to Zille? Nothing at all.""*)

### Węzeł `[724]`
Mówca: **Rico Toras**
> ""With regards to Zille? Nothing at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "A light smirk formed on his face."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_Bruno");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Narrator: "He got to his feet."*)

### Węzeł `[726]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "Rico smirked."*)

### Węzeł `[727]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Rico Toras: ""We were all thinking it.""*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");
RemoveConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Rico Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "Hugo shrugged."*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");
AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");
AddConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Hugo Toras: ""...so you see, Your Highness, knowing how to aim and fir..."*)

### Węzeł `[730]`
Mówca: **Bruno**
> ""YELP!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Rico_ShotDog = true"*)

### Węzeł `[731]`
Mówca: **Bruno**
> ""Aroo...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Narrator: "Rico looked at me and shrugged."*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Military_Equipment >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Mili..."*)
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Mi..."*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Military_Equipment >= 250`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player_Romus: ""Yes. We are in agreement." [-2 Budget, -250 Military Equ..."*)
  - -> `[464]` (*Player_Romus_Italic: "Nod. [-2 Budget, -250 Military Equipment]"*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2 && RiziaDLC.Resources_Military_Equipment >= 250)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Player_Romus: ""We can't afford to do this right now.""*)

### Węzeł `[735]`
Mówca: **Rico Toras**
> ""The only thing we would need to seal this deal is some additional treasury support and some weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Rico Toras: ""So... we have an understanding, then?""*)

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't afford to do this right now.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  and  Variable["RiziaDLC.Resources_Military_Equipment"] >= 250) == false`
- **Kontekst wejściowy (poprzednik):** `[461]` (Rico Toras), `[466]` (Rico Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Rico Toras: ""I-- understood.""*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_GoldenGuard_InvestigateSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_GoldenGuard_InvestigateSO == true"*)
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_GoldenGuard_InvestigateSO == true)"*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_GoldenGuard_InvestigateSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Rico Toras: ""Aside from getting your Golden Guard off Su Omina's tail..."*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_GoldenGuard_InvestigateSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Rico Toras: ""Do you really think I'd dare to bargain with the King of..."*)

### Węzeł `[740]`
Mówca: **Rico Toras**
> ""Do you really think I'd dare to bargain with the King of Rizia? Consider it a family favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "He cleared his throat."*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Discussing security while hunting with the Duke of Iza", "Iza Forest", "Province of Brenas");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Discussing security while hunting with the Duke of Iza","Iza Forest","Province of Brenas");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");"*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Hunting boars with machine guns", "Iza Forest", "Province of Brenas");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Hunting boars with machine guns","Iza Forest","Province of Brenas");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_Hunting_KA74 = true"*)
