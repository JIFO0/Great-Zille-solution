# Rizia/Turn 4/FPnT_PalesDukeVisit

- **ID konwersacji:** `311`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/311_FPnT_PalesDukeVisit.md`
- **Liczba węzłów dialogowych:** 957
- **Liczba wyborów gracza:** 289

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Pales_Friendly`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_MetAxel`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_PalesTrade`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Order_KingsGuardForce_Limited`
- `RiziaDLC.Situation_Order_KingsGuardForce_Powerful`
- `RiziaDLC.Turn03_Security_TitusLeadsInvestigation`
- `RiziaDLC.War_Pales_PublicWarSupport`
- `RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights`
- `RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField`
- `RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal`
- `RiziaDLCSupport.Reports_Turn04_ArbitrationBegins`
- `RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound`
- `RiziaDLCSupport.Reports_Turn04_NavyWithdrawn`
- `RiziaDLCSupport.Reports_Turn04_Pales_SellField`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Your country sending the drillship was an act of provocation. I had no choice but..."** | `[148]` **Axel Reinhart**: ""Tell me, Your Majesty. What is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Axel Reinhart**: ""You could have waited for me to..."<br>`[153]` **Axel Reinhart**: ""You could have waited for me to..." |
| `[7]` | **""What do you think it means, Your Grace?""** | `[148]` **Axel Reinhart**: ""Tell me, Your Majesty. What is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Axel Reinhart**: ""It means that, as usual, the Ri..."<br>`[15]` **Axel Reinhart**: ""It means that despite my prior ..." |
| `[8]` | **""Why did you send that ship to begin with? Why not notify my government?""** | `[148]` **Axel Reinhart**: ""Tell me, Your Majesty. What is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Axel Reinhart**: ""You haven't exactly listened to..."<br>`[193]` **Axel Reinhart**: ""You may not have shown hostilit..." |
| `[16]` | **""This is the 'Party Prince' you're talking to. I know the feeling.""** | `[9]` **Axel Reinhart**: ""I was perfectly happy living a ..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]` | *Brak zmian stanu* | `[28]` **Axel Reinhart**: ""Yes, I know all about your esca..."<br>`[27]` **Axel Reinhart**: ""A brilliant idea, putting jerks..." |
| `[20]` | **""You didn't have to take his place.""** | `[9]` **Axel Reinhart**: ""I was perfectly happy living a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Axel Reinhart**: ""Oh, but I did. Somebody had to ..."<br>`[32]` **Axel Reinhart**: ""And who would have stepped up i..." |
| `[21]` | **""Wait. Which celebrities?""** | `[9]` **Axel Reinhart**: ""I was perfectly happy living a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Axel Reinhart**: ""You'll have to wait until my me..."<br>`[36]` **Axel Reinhart**: ""If I listed them all, we'd neve..." |
| `[22]` | **""Life is full of surprises, Your Grace. Should we get down to negotiations?""** | `[9]` **Axel Reinhart**: ""I was perfectly happy living a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Axel Reinhart**: ""What is there to negotiate?""<br>`[33]` **Axel Reinhart**: ""Yes, I suppose we had better."" |
| `[51]` | **""For the amount I'm paying, something good had better come out of this.""** | `[50]` **Axel Reinhart**: ""But what can I say? I'm an opti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "Duke Reinhart's secretary opened..." |
| `[52]` | **""So am I.""** | `[50]` **Axel Reinhart**: ""But what can I say? I'm an opti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "Duke Reinhart's secretary opened..." |
| `[53]` | **""You're lucky that this Rizian sees reason.""** | `[50]` **Axel Reinhart**: ""But what can I say? I'm an opti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "Duke Reinhart's secretary opened..." |
| `[54]` | **""You're not your brother. And I'm not my father. We can break this cycle.""** | `[50]` **Axel Reinhart**: ""But what can I say? I'm an opti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "Duke Reinhart's secretary opened..." |
| `[57]` | **""Surprisingly well. I'm excited to see what comes next.""** | `[45]` **Titus Gordion**: ""How did it go, Your Majesty?"" | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true` | *Brak zmian stanu* | `[66]` **Narrator**: "Titus nodded wordlessly. We got ..." |
| `[61]` | **""One step closer to Palesian-Rizian reunification, Titus.""** | `[45]` **Titus Gordion**: ""How did it go, Your Majesty?"" | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true` | *Brak zmian stanu* | `[66]` **Narrator**: "Titus nodded wordlessly. We got ..." |
| `[62]` | **""The Duke is a snake. But I can still get the upper hand on him.""** | `[45]` **Titus Gordion**: ""How did it go, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Titus nodded wordlessly. We got ..." |
| `[63]` | **""Not great. Not great at all.""** | `[45]` **Titus Gordion**: ""How did it go, Your Majesty?"" | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false` | *Brak zmian stanu* | `[66]` **Narrator**: "Titus nodded wordlessly. We got ..." |
| `[64]` | **""We may yet have a chance to avenge your father's death.""** | `[45]` **Titus Gordion**: ""How did it go, Your Majesty?"" | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false` | *Brak zmian stanu* | `[66]` **Narrator**: "Titus nodded wordlessly. We got ..." |
| `[65]` | **""That's between me and His Grace.""** | `[45]` **Titus Gordion**: ""How did it go, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Titus nodded wordlessly. We got ..." |
| `[77]` | **""You sound unimpressed, Captain.""** | `[76]` **Titus Gordion**: ""So this is the 'Pearl of the An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Titus Gordion**: ""I'm a simple man, sir. Give me ..." |
| `[78]` | **""Amazing what Lespian money can buy, isn't it?""** | `[76]` **Titus Gordion**: ""So this is the 'Pearl of the An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Titus Gordion**: ""'Amazing' is one word for it, s..." |
| `[79]` | **""Hard to believe all of this sprung up in the last few decades alone.""** | `[76]` **Titus Gordion**: ""So this is the 'Pearl of the An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Titus Gordion**: ""Truly a feat, sir."" |
| `[92]` | **""What about that *other* investigation I ordered?""** | `[91]` **Titus Gordion**: ""Your cousin's associates have b..." | `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true` | *Brak zmian stanu* | `[99]` **Titus Gordion**: ""Still in the works, sir. It's t..." |
| `[96]` | **""Investigate harder, damn it.""** | `[91]` **Titus Gordion**: ""Your cousin's associates have b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Titus Gordion**: ""I'll pass on the order."" |
| `[98]` | **""Keep up the good work.""** | `[91]` **Titus Gordion**: ""Your cousin's associates have b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Titus Gordion**: ""I'll pass that on."" |
| `[102]` | **""Where are you from, Titus?""** | `[80]` **Titus Gordion**: ""I'm a simple man, sir. Give me ..."<br>`[81]` **Titus Gordion**: ""Truly a feat, sir.""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`<br>`(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[103]` **Titus Gordion**: ""Born and raised in Porte Drazon."" |
| `[105]` | **""He gave his life for a good cause.""** | `[104]` **Titus Gordion**: ""My father was killed during the..."<br>`[112]` **Titus Gordion**: ""No, sir. My father fought in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Titus Gordion**: ""He believed in it with all his ..." |
| `[106]` | **""So much senseless bloodshed. May it never happen again.""** | `[104]` **Titus Gordion**: ""My father was killed during the..."<br>`[112]` **Titus Gordion**: ""No, sir. My father fought in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Titus Gordion**: ""For what it's worth, sir, he be..." |
| `[107]` | **""I bet you were good at it.""** | `[104]` **Titus Gordion**: ""My father was killed during the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Titus Gordion**: ""Good enough to get noticed by m..." |
| `[111]` | **""So you've never been to Pales before?""** | `[80]` **Titus Gordion**: ""I'm a simple man, sir. Give me ..."<br>`[81]` **Titus Gordion**: ""Truly a feat, sir.""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`<br>`(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[112]` **Titus Gordion**: ""No, sir. My father fought in th..." |
| `[113]` | **""Sorry if this visit is bringing up bad memories.""** | `[112]` **Titus Gordion**: ""No, sir. My father fought in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Titus Gordion**: ""Not a problem, sir. He died fig..." |
| `[116]` | **""Into the breach.""** | `[115]` **Narrator**: "A panel in the wall slid open, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Titus Gordion**: ""Good luck, sir."" |
| `[117]` | **""Sit tight. This ought to be quick.""** | `[115]` **Narrator**: "A panel in the wall slid open, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Titus Gordion**: ""Will do, sir."" |
| `[118]` | **""Make yourself comfortable. This might be a while.""** | `[115]` **Narrator**: "A panel in the wall slid open, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Titus Gordion**: ""Will do, sir."" |
| `[127]` | **""It's always a pleasure to visit this beautiful castle.""** | `[126]` **Axel Reinhart**: ""Your Majesty. We meet again."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Axel Reinhart**: ""Really? You think it's beautiful?"" |
| `[128]` | **""I only wish it was under better circumstances, Your Grace.""** | `[122]` **Axel Reinhart**: ""Your Majesty. A pleasure to fin..."<br>`[126]` **Axel Reinhart**: ""Your Majesty. We meet again."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Axel Reinhart**: ""As do I."" |
| `[132]` | **""Likewise. You have a beautiful castle.""** | `[122]` **Axel Reinhart**: ""Your Majesty. A pleasure to fin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Axel Reinhart**: ""Really? You think it's beautiful?"" |
| `[133]` | **"Bow."** | `[122]` **Axel Reinhart**: ""Your Majesty. A pleasure to fin..."<br>`[126]` **Axel Reinhart**: ""Your Majesty. We meet again."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Axel Reinhart**: ""How do you like my castle?"" |
| `[136]` | **""No ministers? No aides?""** | `[122]` **Axel Reinhart**: ""Your Majesty. A pleasure to fin..."<br>`[126]` **Axel Reinhart**: ""Your Majesty. We meet again."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Axel Reinhart**: ""I thought it best to try and se..." |
| `[139]` | **""It's very... modern.""** | `[134]` **Axel Reinhart**: ""Really? You think it's beautiful?""<br>`[138]` **Axel Reinhart**: ""How do you like my castle?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "A corner of his mouth turned up." |
| `[140]` | **""It's breathtaking.""** | `[134]` **Axel Reinhart**: ""Really? You think it's beautiful?""<br>`[138]` **Axel Reinhart**: ""How do you like my castle?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "He raised an eyebrow." |
| `[141]` | **""I have to be diplomatic, don't I?""** | `[134]` **Axel Reinhart**: ""Really? You think it's beautiful?""<br>`[138]` **Axel Reinhart**: ""How do you like my castle?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "A corner of his mouth turned up." |
| `[154]` | **""I recognize your claim on the field. But you must recognize Rizia's right to it a..."** | `[44]` **Axel Reinhart**: ""I know that our expedition may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Axel Reinhart**: ""You can't truly think that the ..." |
| `[155]` | **""You broke the law by sending that ship. Count yourself lucky that Rizia has not r..."** | `[44]` **Axel Reinhart**: ""I know that our expedition may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Axel Reinhart**: ""That's brave talk, Your Majesty."" |
| `[156]` | **""Rizia does not dispute your claim to the field. In fact, we're prepared to let yo..."** | `[44]` **Axel Reinhart**: ""I know that our expedition may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Axel Reinhart**: ""You are?"" |
| `[163]` | **""I know our first meeting went badly. This is my attempt to make amends.""** | `[162]` **Axel Reinhart**: ""Is this the same Romus Toras I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Axel Reinhart**: ""And how can I trust you?"" |
| `[165]` | **""My goal has always been to get Pales to rejoin Rizia. If giving up a gas field wi..."** | `[162]` **Axel Reinhart**: ""Is this the same Romus Toras I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Axel Reinhart**: ""You think we're willing to trad..." |
| `[167]` | **""I didn't say I would cede the field out of pure generosity.""** | `[162]` **Axel Reinhart**: ""Is this the same Romus Toras I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Axel Reinhart**: ""You must understand that Pales ..." |
| `[168]` | **""My goal has always been to get Pales to rejoin Rizia. If giving up a gas field wi..."** | `[164]` **Axel Reinhart**: ""Let me guess. You want somethin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Axel Reinhart**: ""You think we're willing to trad..." |
| `[169]` | **""No. I truly don't believe it's worth the hassle to fight for the field.""** | `[164]` **Axel Reinhart**: ""Let me guess. You want somethin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Narrator**: "He cast a suspicious glance at me." |
| `[170]` | **""Of course I do, Your Grace.""** | `[164]` **Axel Reinhart**: ""Let me guess. You want somethin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Axel Reinhart**: ""You must understand that Pales ..." |
| `[178]` | **""They supported your independence... by making you dependent on them.""** | `[339]` **Axel Reinhart**: ""Lespia was the only nation will..."<br>`[351]` **Axel Reinhart**: ""Lespia, on the other hand, was ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Axel Reinhart**: ""You know how wealthy we are. It..." |
| `[179]` | **""Your family must have realized their motives for doing so were less than pure.""** | `[339]` **Axel Reinhart**: ""Lespia was the only nation will..."<br>`[351]` **Axel Reinhart**: ""Lespia, on the other hand, was ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Axel Reinhart**: ""Of course. But what choice did ..." |
| `[180]` | **""You should never have been put in that position, Your Grace. My predecessors' agg..."** | `[339]` **Axel Reinhart**: ""Lespia was the only nation will..."<br>`[351]` **Axel Reinhart**: ""Lespia, on the other hand, was ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Axel Reinhart**: ""Thank you for acknowledging tha..." |
| `[182]` | **""I see no other choice but arbitration. The Alliance of Nations will decide owners..."** | `[442]` **Axel Reinhart**: ""What would you prefer as a solu..."<br>`[456]` **Axel Reinhart**: ""Then... what do you suggest, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Duke Reinhart frowned." |
| `[183]` | **""I suggest you keep the field, and keep the deal with Lespia. Rizia is staying out..."** | `[442]` **Axel Reinhart**: ""What would you prefer as a solu..."<br>`[456]` **Axel Reinhart**: ""Then... what do you suggest, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "Duke Reinhart frowned." |
| `[195]` | **""I hope Rico was right about them not cracking under pressure.""** | `[97]` **Titus Gordion**: ""By the way, Your Majesty, the m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Titus Gordion**: ""They're a stubborn lot. My own ..." |
| `[196]` | **""Poor bastards.""** | `[97]` **Titus Gordion**: ""By the way, Your Majesty, the m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Titus Gordion**: ""I wouldn't feel too sorry for t..." |
| `[197]` | **""I couldn't care less. I'm sure they're guilty of *something*.""** | `[97]` **Titus Gordion**: ""By the way, Your Majesty, the m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Titus Gordion**: ""My men did some digging into th..." |
| `[203]` | **""No. The expanded unit might still prove useful.""** | `[202]` **Titus Gordion**: ""Speaking of which, now that our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Titus Gordion**: ""Glad to hear it, sir."" |
| `[204]` | **""No. I want all your extra manpower concentrated on that *other* investigation I o..."** | `[202]` **Titus Gordion**: ""Speaking of which, now that our..." | `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true` | *Brak zmian stanu* | `[209]` **Titus Gordion**: ""Right, sir. We'll double down o..." |
| `[208]` | **""Good point. Yes, that's money I could be putting to better use.""** | `[202]` **Titus Gordion**: ""Speaking of which, now that our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Titus Gordion**: ""Are you sure, Your Majesty? Tha..."<br>`[216]` **Titus Gordion**: ""Are you sure, Your Majesty? You..." |
| `[212]` | **""There's too much going on to make this decision. Let's talk later.""** | `[210]` **Titus Gordion**: ""Are you sure, Your Majesty? Tha..."<br>`[216]` **Titus Gordion**: ""Are you sure, Your Majesty? You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "Titus nodded." |
| `[217]` | **""Yes, I'm quite sure.""** | `[210]` **Titus Gordion**: ""Are you sure, Your Majesty? Tha..."<br>`[216]` **Titus Gordion**: ""Are you sure, Your Majesty? You..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = ...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[222]` **Titus Gordion**: ""Very well, Your Majesty. I'll d..." |
| `[218]` | **""Hmm. All right, let's keep the extra Golden Guards on the royal payroll.""** | `[210]` **Titus Gordion**: ""Are you sure, Your Majesty? Tha..."<br>`[216]` **Titus Gordion**: ""Are you sure, Your Majesty? You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "Titus nodded." |
| `[242]` | **""I can only imagine how difficult it must be for you to be here, considering this ..."** | `[80]` **Titus Gordion**: ""I'm a simple man, sir. Give me ..."<br>`[81]` **Titus Gordion**: ""Truly a feat, sir.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`<br>`(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[245]` **Titus Gordion**: ""The pain never really goes away..." |
| `[243]` | **""There's no doubt in my mind that Pales still falls under the Rizian banner. Their..."** | `[80]` **Titus Gordion**: ""I'm a simple man, sir. Give me ..."<br>`[81]` **Titus Gordion**: ""Truly a feat, sir.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`<br>`(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[247]` **Titus Gordion**: ""An injustice I hope to see rect..." |
| `[244]` | **""I do hope our two countries can resolve our historical rivalries. A harmonious pa..."** | `[80]` **Titus Gordion**: ""I'm a simple man, sir. Give me ..."<br>`[81]` **Titus Gordion**: ""Truly a feat, sir.""<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`<br>`(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false` | *Brak zmian stanu* | `[246]` **Titus Gordion**: ""Sure. Though I must admit, I do..." |
| `[251]` | **""I know the feeling. Not a day goes by where I don't think about my late wife.""** | `[245]` **Titus Gordion**: ""The pain never really goes away..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[257]` **Titus Gordion**: ""I've never been married myself,..." |
| `[252]` | **""One mustn't let personal feelings get in the way of doing one's duty.""** | `[245]` **Titus Gordion**: ""The pain never really goes away..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Titus Gordion**: ""Of course. I never meant to imp..." |
| `[253]` | **""I got over my wife's death fairly quickly. Granted, she and I were never very clo..."** | `[245]` **Titus Gordion**: ""The pain never really goes away..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[266]` **Titus Gordion**: ""Much like a snowflake, grief ma..." |
| `[254]` | **""As do I. I'm determined to make it happen.""** | `[247]` **Titus Gordion**: ""An injustice I hope to see rect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Titus Gordion**: ""I have no doubt, sir."" |
| `[255]` | **""You and me both. Though, this matter must be approached with caution. Setting thi..."** | `[247]` **Titus Gordion**: ""An injustice I hope to see rect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Titus Gordion**: ""Agreed. Haste can lead to mista..." |
| `[261]` | **""I think about my father on a daily basis too, despite my best efforts to forget a..."** | `[245]` **Titus Gordion**: ""The pain never really goes away..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true` | *Brak zmian stanu* | `[263]` **Titus Gordion**: ""Father-son relationships can be..." |
| `[262]` | **""Not a day goes by where I don't think about my own father. I try to remind myself..."** | `[245]` **Titus Gordion**: ""The pain never really goes away..." | `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false` | *Brak zmian stanu* | `[264]` **Titus Gordion**: ""An optimistic way to look at li..." |
| `[268]` | **""I believe there are far more pressing issues to deal with than Pales' reunificati..."** | `[247]` **Titus Gordion**: ""An injustice I hope to see rect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Titus Gordion**: ""While I personally believe the ..." |
| `[272]` | **""This is all a misunderstanding, Duke Reinhart. Send your ship back and we can set..."** | `[44]` **Axel Reinhart**: ""I know that our expedition may ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Axel Reinhart**: ""Now you're interested in peace?""<br>`[277]` **Axel Reinhart**: ""I would like to, Your Majesty."" |
| `[280]` | **""So you're admitting it. You're a puppet of Lespia.""** | `[172]` **Axel Reinhart**: ""Your Majesty, I urge you to let..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Narrator**: "Duke Reinhart drew himself upright." |
| `[281]` | **""My own experts would say that you've acted in clear violation of the Alliance of ..."** | `[173]` **Axel Reinhart**: ""My legal experts have assured m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Axel Reinhart**: ""You are ignoring ANDOR's nuance..." |
| `[285]` | **""That's precisely why I will not let this go. Western superpowers have no place me..."** | `[172]` **Axel Reinhart**: ""Your Majesty, I urge you to let..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Axel Reinhart**: ""I wouldn't call it 'meddling', ..." |
| `[286]` | **""I too have the backing of powerful interests. You do not want to incur the wrath ..."** | `[172]` **Axel Reinhart**: ""Your Majesty, I urge you to let..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[572]` **Axel Reinhart**: ""If I must do so to assert Pales..." |
| `[288]` | **""You ruled on behalf of the Valgos Empire, who stole Pales from Rizia. I would har..."** | `[284]` **Axel Reinhart**: ""If you are going to question ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Axel Reinhart**: ""You are talking about ancient h..." |
| `[289]` | **""I respect the length of your family's rule. However, Pales has only been a sovere..."** | `[284]` **Axel Reinhart**: ""If you are going to question ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Axel Reinhart**: ""That does not mean our sovereig..." |
| `[290]` | **""You are correct. Both of our families have clung to power for too long.""** | `[284]` **Axel Reinhart**: ""If you are going to question ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Axel Reinhart**: ""Yet I don't see you hanging up ..." |
| `[291]` | **""Our island counts just as much as your barely legitimate country.""** | `[171]` **Axel Reinhart**: ""You can't truly think that the ..."<br>`[173]` **Axel Reinhart**: ""My legal experts have assured m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "Duke Reinhart bristled at that r..." |
| `[292]` | **""I don't make the rules. Our claim is clearly valid according to the Alliance of N..."** | `[171]` **Axel Reinhart**: ""You can't truly think that the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Axel Reinhart**: ""You are ignoring ANDOR's nuance..." |
| `[293]` | **""Caleqabiz may be small, but it is still a part of the great nation of Rizia.""** | `[171]` **Axel Reinhart**: ""You can't truly think that the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Axel Reinhart**: ""You chose a convenient time to ..." |
| `[295]` | **""I was under pressure from my father. I did not truly mean what I said.""** | `[279]` **Axel Reinhart**: ""I offered you a chance for peac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Axel Reinhart**: ""I wish that I could believe you..." |
| `[301]` | **""We've established that we have differing interpretations of the law. What will it..."** | `[173]` **Axel Reinhart**: ""My legal experts have assured m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Axel Reinhart**: ""I'm afraid it may be too late f..." |
| `[302]` | **""I was under pressure from him then. Now that I am king, I am no longer beholden t..."** | `[299]` **Axel Reinhart**: ""I offered you a chance for peac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Axel Reinhart**: ""I wish that I could believe you..." |
| `[303]` | **""I did not and still do not want to cooperate with Pales after the violence of the..."** | `[279]` **Axel Reinhart**: ""I offered you a chance for peac..."<br>`[299]` **Axel Reinhart**: ""I offered you a chance for peac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Axel Reinhart**: ""Neither of us do, Your Majesty."" |
| `[304]` | **""I do still have doubts about Pales' legitimacy. But this resource dispute overrid..."** | `[279]` **Axel Reinhart**: ""I offered you a chance for peac..."<br>`[299]` **Axel Reinhart**: ""I offered you a chance for peac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "Duke Reinhart bristled at that r..." |
| `[311]` | **""Your family only came to power because the Valgos Empire put you there. And now t..."** | `[305]` **Axel Reinhart**: ""But until and unless Rizia resp..."<br>`[352]` **Axel Reinhart**: ""But no Rizian ruler has ever tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Narrator**: "He sighed." |
| `[312]` | **""Your 'sovereignty' only exists because of Lespian support. Without it, Pales woul..."** | `[305]` **Axel Reinhart**: ""But until and unless Rizia resp..."<br>`[352]` **Axel Reinhart**: ""But no Rizian ruler has ever tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "Duke Reinhart drew himself upright." |
| `[315]` | **""Please, Your Grace. Let's not let the hostility between our families color our pr..."** | `[305]` **Axel Reinhart**: ""But until and unless Rizia resp..."<br>`[352]` **Axel Reinhart**: ""But no Rizian ruler has ever tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Narrator**: "He sighed." |
| `[316]` | **""So you're admitting it. You're a puppet of Lespia.""** | `[278]` **Axel Reinhart**: ""Unfortunately, there are greate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "Duke Reinhart drew himself upright." |
| `[317]` | **""That's precisely why I will not let this go. Western superpowers have no place me..."** | `[278]` **Axel Reinhart**: ""Unfortunately, there are greate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Axel Reinhart**: ""I wouldn't call it 'meddling', ..." |
| `[318]` | **""I too have the backing of powerful interests. You do not want to incur the wrath ..."** | `[278]` **Axel Reinhart**: ""Unfortunately, there are greate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Axel Reinhart**: ""If I must do so to assert Pales..." |
| `[326]` | **""Pales could have kept its cultural identity intact if it had rejoined Rizia.""** | `[309]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Axel Reinhart**: ""Your father would never have ac..." |
| `[327]` | **""Regimes end. It was your time.""** | `[309]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Axel Reinhart**: ""That wasn't your kingdom's deci..." |
| `[328]` | **""No. No, I suppose not.""** | `[309]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Axel Reinhart**: ""I heard what it was like back t..." |
| `[329]` | **""I would have done that before turning to Lespia.""** | `[309]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Axel Reinhart**: ""You don't know what you would h..." |
| `[342]` | **""What sovereignty? Your family only came to power because the Valgos Empire put yo..."** | `[176]` **Axel Reinhart**: ""By claiming the Aureus field, w..."<br>`[346]` **Axel Reinhart**: ""If I must do so to assert Pales..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Narrator**: "He sighed." |
| `[343]` | **""Your 'sovereignty' only exists because of Lespian support. Without it, Pales woul..."** | `[176]` **Axel Reinhart**: ""By claiming the Aureus field, w..."<br>`[346]` **Axel Reinhart**: ""If I must do so to assert Pales..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "Duke Reinhart drew himself upright." |
| `[344]` | **""Please, Your Grace. Let's not let the hostility between our families color our pr..."** | `[176]` **Axel Reinhart**: ""By claiming the Aureus field, w..."<br>`[346]` **Axel Reinhart**: ""If I must do so to assert Pales..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Narrator**: "He sighed." |
| `[349]` | **""Then tell me, how can Rizia satisfy those interests?""** | `[278]` **Axel Reinhart**: ""Unfortunately, there are greate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Axel Reinhart**: ""I'm afraid it may be too late f..." |
| `[363]` | **""Now that Lespia is an ATO member, they won't want to be connected to a monarchy f..."** | `[184]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[340]` **Axel Reinhart**: ""Of course. But what choice did ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Narrator**: "His gaze hardened as he looked a..."<br>`[353]` **Narrator**: "He leaned forward and lowered hi..." |
| `[365]` | **""I understand why Pales accepted Lespia's aid. But now that Morella is in league w..."** | `[184]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[341]` **Axel Reinhart**: ""You know how wealthy we are. It..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Narrator**: "His gaze hardened as he looked a..."<br>`[353]` **Narrator**: "He leaned forward and lowered hi..." |
| `[366]` | **""Let's end the history lecture. What are we doing about this gas field?""** | `[184]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[340]` **Axel Reinhart**: ""Of course. But what choice did ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Narrator**: "His gaze hardened as he looked a..."<br>`[379]` **Narrator**: "He leaned forward and lowered hi..." |
| `[382]` | **""My war and security councilor wanted me to deploy our navy around the field. I sh..."** | `[364]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..."<br>`[378]` **Axel Reinhart**: ""And we certainly cannot let Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Axel Reinhart**: ""Do it if you like. We defeated ..." |
| `[383]` | **""Rizia is not looking for a fight. Surely there's still a peaceful solution to be ..."** | `[364]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..."<br>`[378]` **Axel Reinhart**: ""And we certainly cannot let Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Axel Reinhart**: ""There is, Your Majesty."" |
| `[384]` | **""Is that a threat, Your Grace?""** | `[364]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..."<br>`[378]` **Axel Reinhart**: ""And we certainly cannot let Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[543]` **Axel Reinhart**: ""Cede the field to Pales and you..." |
| `[388]` | **""Come on, Your Grace. This isn't who you are. Let's just settle this quickly so yo..."** | `[364]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..."<br>`[378]` **Axel Reinhart**: ""And we certainly cannot let Riz..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[389]` **Narrator**: "He exhaled heavily." |
| `[393]` | **""Unless what?""** | `[362]` **Axel Reinhart**: ""Unless..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Narrator**: "He spoke his next words very del..." |
| `[394]` | **""I see where this is going.""** | `[362]` **Axel Reinhart**: ""Unless..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Narrator**: "He spoke his next words very del..." |
| `[395]` | **""I'm listening...""** | `[362]` **Axel Reinhart**: ""Unless..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Narrator**: "He spoke his next words very del..." |
| `[408]` | **""That's far too much. Can't you go any lower?""** | `[403]` **Narrator**: "It was an extremely large sum, b..."<br>`[930]` **Narrator**: "It was a ridiculously large sum,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Narrator**: "He rubbed his chin." |
| `[410]` | **""I'm sorry about your cousin.""** | `[409]` **Axel Reinhart**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[411]` **Axel Reinhart**: ""Cocaine and skydiving don't mix."" |
| `[412]` | **""I don't. Please explain.""** | `[409]` **Axel Reinhart**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Narrator**: "He briefly closed his eyes." |
| `[413]` | **""I think so, but I don't like it.""** | `[409]` **Axel Reinhart**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Axel Reinhart**: ""Sorry, but this is the best com..." |
| `[414]` | **""I do. How big of a parachute are we talking about?""** | `[409]` **Axel Reinhart**: ""Do you understand what I'm sayi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[500]` **Narrator**: "He blinked in surprise." |
| `[420]` | **""How do I know you won't just turn around and sell the field to Lespia once we ced..."** | `[419]` **Axel Reinhart**: ""Cede the field to us and agree ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Axel Reinhart**: ""We're both men of honor, Your M..." |
| `[421]` | **""That's ridiculous. We shouldn't have to pay for what's rightfully ours.""** | `[419]` **Axel Reinhart**: ""Cede the field to us and agree ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Axel Reinhart**: ""I am generously offering you wh..." |
| `[425]` | **""That depends. How much is Lespia offering?""** | `[419]` **Axel Reinhart**: ""Cede the field to us and agree ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[426]` **Axel Reinhart**: ""Now we're talking."" |
| `[431]` | **""You can have the field if you need it so badly. But I will not pay for the gas." ..."** | `[424]` **Axel Reinhart**: ""I hope you see how beneficial t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Narrator**: "Duke Reinhart frowned." |
| `[432]` | **""Sorry, but I must refuse. We have a legitimate claim to that gas field, and I am ..."** | `[424]` **Axel Reinhart**: ""I hope you see how beneficial t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[438]` **Axel Reinhart**: ""Then court it is, Your Majesty."" |
| `[433]` | **""Okay. Just out of curiosity, tell me how much we would have to pay.""** | `[424]` **Axel Reinhart**: ""I hope you see how beneficial t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Axel Reinhart**: ""It was always my family's polic..." |
| `[434]` | **""Sorry, but there's no way Rizia can pay this much.""** | `[407]` **Narrator**: "It was more than our treasury co..."<br>`[917]` **Narrator**: "It was an extremely large sum, m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Narrator**: "He rubbed his chin." |
| `[435]` | **""Seems reasonable to me. You have a deal, Duke Reinhart." [-6 Budget Now, -2 Budge..."** | `[932]` **Narrator**: "It was a very large sum, but our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`--;`<br>*(+3 skryptów)* | `[464]` **Axel Reinhart**: ""Really?"" |
| `[436]` | **""Can't I just buy the rights to part of the field?""** | `[403]` **Narrator**: "It was an extremely large sum, b..."<br>`[930]` **Narrator**: "It was a ridiculously large sum,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Axel Reinhart**: ""This is an all-or-nothing deal,..." |
| `[437]` | **""On second thought, this is insulting. My kingdom will not pay for our own gas.""** | `[403]` **Narrator**: "It was an extremely large sum, b..."<br>`[407]` **Narrator**: "It was more than our treasury co..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Narrator**: "Duke Reinhart crumpled up the pi..." |
| `[439]` | **""Can't I just buy the rights to part of the field?""** | `[407]` **Narrator**: "It was more than our treasury co..."<br>`[917]` **Narrator**: "It was an extremely large sum, m..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Axel Reinhart**: ""This is an all-or-nothing deal,..." |
| `[449]` | **""Sorry to disappoint you.""** | `[447]` **Axel Reinhart**: ""I approached you because I beli..."<br>`[453]` **Axel Reinhart**: ""Frankly, I thought Rizia could ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[456]` **Axel Reinhart**: ""Then... what do you suggest, Yo..." |
| `[450]` | **""Rizia's economy is as robust as it's ever been. But we will not pay so much to a ..."** | `[447]` **Axel Reinhart**: ""I approached you because I beli..."<br>`[453]` **Axel Reinhart**: ""Frankly, I thought Rizia could ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Axel Reinhart**: ""Harm? If I recall correctly, *y..." |
| `[451]` | **""Our resources have shrunk in the past years. That's why we need that gas field.""** | `[447]` **Axel Reinhart**: ""I approached you because I beli..."<br>`[453]` **Axel Reinhart**: ""Frankly, I thought Rizia could ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[501]` **Axel Reinhart**: ""However badly you need it, we n..." |
| `[460]` | **""Very well, Your Grace. You have a deal." [-10 Budget Now, -2 Budget Per Turn Now,..."** | `[455]` **Axel Reinhart**: ""Unfortunately, if you can't pur..." | `Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`--;`<br>*(+3 skryptów)* | `[464]` **Axel Reinhart**: ""Really?"" |
| `[461]` | **""Stick with Lespia, then. You can keep the field, but we're not paying for it." [C..."** | `[455]` **Axel Reinhart**: ""Unfortunately, if you can't pur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "Duke Reinhart frowned." |
| `[462]` | **""Then we will have to enter the arbitration process. I'll see you in court, Duke R..."** | `[455]` **Axel Reinhart**: ""Unfortunately, if you can't pur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Duke Reinhart frowned." |
| `[467]` | **""Well, I have a daughter...""** | `[466]` **Axel Reinhart**: ""Perfect, Your Majesty. Now, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[473]` **Narrator**: "His lip twitched." |
| `[468]` | **""A young playboy like you needn't settle down yet.""** | `[466]` **Axel Reinhart**: ""Perfect, Your Majesty. Now, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Axel Reinhart**: ""My people demand a queen. You k..." |
| `[469]` | **""I look forward to a fruitful energy partnership.""** | `[466]` **Axel Reinhart**: ""Perfect, Your Majesty. Now, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Axel Reinhart**: ""As do I."" |
| `[474]` | **""As a matter of fact, I'm sending naval reinforcements to prevent Pales from furth..."** | `[445]` **Axel Reinhart**: ""If there's truly no other choic..." | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false` | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...`<br>`Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = V...` | `[475]` **Narrator**: "His nostrils flared." |
| `[477]` | **""Nor I. But with the help of a third party, I'm sure we'll be able to come to a co..."** | `[445]` **Axel Reinhart**: ""If there's truly no other choic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[478]` **Axel Reinhart**: ""A fast one, I hope. Lespia has ..." |
| `[479]` | **""That's what you get for trying to sniff around for the best deal.""** | `[445]` **Axel Reinhart**: ""If there's truly no other choic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Axel Reinhart**: ""This will work out worse for yo..." |
| `[481]` | **""Prime Minister Alvarez will be interested in hearing how close you came to betray..."** | `[446]` **Axel Reinhart**: ""Thank you, I guess. But it's no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Axel Reinhart**: ""What?! You wouldn't."" |
| `[483]` | **""Nor I. But I'm willing to let the field go to keep the peace between our countries.""** | `[446]` **Axel Reinhart**: ""Thank you, I guess. But it's no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[486]` **Axel Reinhart**: ""Peace, yes."" |
| `[485]` | **""Then you shouldn't have tried to play Lespia and Rizia off each other.""** | `[446]` **Axel Reinhart**: ""Thank you, I guess. But it's no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Axel Reinhart**: ""That's not what -- Never mind."" |
| `[487]` | **""My war councilor suggested it as soon as your ship launched. I should have listen..."** | `[476]` **Axel Reinhart**: ""That's *really* not the outcome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Axel Reinhart**: ""She's an Azaro, isn't she? This..." |
| `[489]` | **""Fine, fine, I'll marry you. Just don't tell our Grand Wiseman.""** | `[466]` **Axel Reinhart**: ""Perfect, Your Majesty. Now, if ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[490]` **Axel Reinhart**: ""Funny. But you're not exactly m..." |
| `[492]` | **""Sorry. But your willingness to double-cross Lespia shows you cannot be trusted.""** | `[476]` **Axel Reinhart**: ""That's *really* not the outcome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Axel Reinhart**: ""It was an attempt at reconcilia..." |
| `[497]` | **""Win or lose, I will not simply capitulate to Pales.""** | `[496]` **Axel Reinhart**: ""I should warn you that you're g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[510]` **Axel Reinhart**: ""Nor I to Rizia."" |
| `[498]` | **""A shame we were unable to settle this like gentlemen, Your Grace.""** | `[496]` **Axel Reinhart**: ""I should warn you that you're g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Axel Reinhart**: ""Let the record show that we tri..." |
| `[499]` | **""You're bluffing.""** | `[496]` **Axel Reinhart**: ""I should warn you that you're g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Axel Reinhart**: ""Am I? You'll find out."" |
| `[502]` | **""You're not the only one who can play games.""** | `[482]` **Axel Reinhart**: ""What?! You wouldn't."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Narrator**: "Reinhart scowled. He reached und..." |
| `[503]` | **""Just wait and see.""** | `[482]` **Axel Reinhart**: ""What?! You wouldn't."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Narrator**: "Reinhart scowled. He reached und..." |
| `[506]` | **""No, I wouldn't. But it was fun to watch your face as I said that.""** | `[482]` **Axel Reinhart**: ""What?! You wouldn't."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Narrator**: "Reinhart scowled. He reached und..." |
| `[512]` | **""That's an unbefitting attitude. All I want is to keep the peace between our count..."** | `[496]` **Axel Reinhart**: ""I should warn you that you're g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[513]` **Axel Reinhart**: ""I want that as well. But I'm ju..." |
| `[516]` | **""This doesn't preclude the possibility of cooperation in the future.""** | `[446]` **Axel Reinhart**: ""Thank you, I guess. But it's no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[517]` **Axel Reinhart**: ""Cooperation will be a lot harde..." |
| `[519]` | **""Of course not. It's your field.""** | `[515]` **Axel Reinhart**: ""We'll send over an official con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[522]` **Axel Reinhart**: ""Thank you."" |
| `[520]` | **""Just remember that it is only staying due to our largesse.""** | `[515]` **Axel Reinhart**: ""We'll send over an official con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Axel Reinhart**: ""Yes, thank you, Your Majesty."" |
| `[521]` | **""We'll meet again, Duke Reinhart.""** | `[515]` **Axel Reinhart**: ""We'll send over an official con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[524]` **Axel Reinhart**: ""I am sure that we will. We're n..." |
| `[526]` | **""I'm only taking precautions.""** | `[476]` **Axel Reinhart**: ""That's *really* not the outcome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Axel Reinhart**: ""Then so will we."" |
| `[531]` | **""Yes. I look forward to it, in fact.""** | `[530]` **Axel Reinhart**: ""I hope you understand that if y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "Duke Reinhart's secretary opened..." |
| `[532]` | **""Don't do anything too rash. Nobody wants escalation.""** | `[530]` **Axel Reinhart**: ""I hope you understand that if y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[539]` **Axel Reinhart**: ""Ha. Unbelievable."" |
| `[533]` | **""Halaita. If it is said, so it is, so it will be.""** | `[530]` **Axel Reinhart**: ""I hope you understand that if y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[538]` **Axel Reinhart**: ""Sure."" |
| `[544]` | **""Yes?""** | `[541]` **Axel Reinhart**: ""Or..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[550]` **Axel Reinhart**: ""The only other way out I see is..." |
| `[545]` | **""I knew there was a more reasonable option.""** | `[541]` **Axel Reinhart**: ""Or..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[550]` **Axel Reinhart**: ""The only other way out I see is..." |
| `[546]` | **""I can't marry you, Your Grace. It's illegal in my country.""** | `[541]` **Axel Reinhart**: ""Or..."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[548]` **Narrator**: "He looked at me strangely." |
| `[552]` | **""Are you sure there's absolutely nothing else you would accept?""** | `[551]` **Axel Reinhart**: ""But the arbitration process cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Narrator**: "He shook his head." |
| `[553]` | **""We are willing to wait however long we have to for justice to be served.""** | `[551]` **Axel Reinhart**: ""But the arbitration process cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Axel Reinhart**: ""Are you sure about that, Your M..." |
| `[554]` | **""If I cede the field to Pales, what will you give Rizia in return?""** | `[551]` **Axel Reinhart**: ""But the arbitration process cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[559]` **Axel Reinhart**: ""The chance to avoid a lengthy, ..." |
| `[561]` | **""Not much of a consolation prize.""** | `[560]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[569]` **Axel Reinhart**: ""Sorry. I can't think of anythin..." |
| `[563]` | **""What makes you think Rizia will lose?""** | `[560]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Axel Reinhart**: ""We have the backing of Lespia, ..." |
| `[564]` | **""What about a chance for lasting peace between our two nations?""** | `[560]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[565]` **Axel Reinhart**: ""You made it clear that Rizia di..." |
| `[571]` | **""I do want peace. But your attitude is making it difficult.""** | `[566]` **Axel Reinhart**: ""But if you've changed your mind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[644]` **Axel Reinhart**: ""Then let's end this conversatio..." |
| `[573]` | **""What sovereignty? Your family only came to power because the Valgos Empire put yo..."** | `[572]` **Axel Reinhart**: ""If I must do so to assert Pales..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Narrator**: "He sighed." |
| `[574]` | **""Your 'sovereignty' only exists because of Lespian support. Without it, Pales woul..."** | `[572]` **Axel Reinhart**: ""If I must do so to assert Pales..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[576]` **Axel Reinhart**: ""What of Rizia and Rumburg, then?"" |
| `[575]` | **""We respect Palesian sovereignty. All we are asking for is the right to our own gas.""** | `[572]` **Axel Reinhart**: ""If I must do so to assert Pales..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[577]` **Axel Reinhart**: ""I don't know if I can believe y..." |
| `[578]` | **""The Zille bombing was a tragedy. But our relations with Wehlen are as strong as t..."** | `[562]` **Axel Reinhart**: ""I know your kingdom has been ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[593]` **Axel Reinhart**: ""I was mistaken, then."" |
| `[579]` | **""Who do you think we are? The kingdom of Rizia can afford as many disputes as we l..."** | `[562]` **Axel Reinhart**: ""I know your kingdom has been ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[591]` **Axel Reinhart**: ""Forgive my impertinence, then."" |
| `[580]` | **""Please, Your Grace. Give my kingdom a chance and we will prove ourselves.""** | `[557]` **Axel Reinhart**: ""But you made it very clear that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[584]` **Axel Reinhart**: ""I'm afraid it's too late."" |
| `[581]` | **""Just be reasonable. You are letting past grudges get in the way of a constructive..."** | `[557]` **Axel Reinhart**: ""But you made it very clear that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[587]` **Axel Reinhart**: ""We are not talking about past g..." |
| `[582]` | **""Could you blame me? We lost many good men fighting your country.""** | `[557]` **Axel Reinhart**: ""But you made it very clear that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[583]` **Axel Reinhart**: ""Invading my country, you mean."" |
| `[589]` | **""I must admit that our difficulties with Wehlen have only made our need for natura..."** | `[562]` **Axel Reinhart**: ""I know your kingdom has been ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[590]` **Axel Reinhart**: ""I understand. But Pales cannot ..." |
| `[595]` | **""I still don't believe that the international community will rally around your ins..."** | `[568]` **Axel Reinhart**: ""But if you'd like to test that ..."<br>`[570]` **Axel Reinhart**: ""But even a small percentage of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[640]` **Axel Reinhart**: ""Enough insults, Your Majesty. T..." |
| `[596]` | **""Then I see no choice but to get the AN involved. We have to enter arbitration.""** | `[592]` **Axel Reinhart**: ""No, this conversation is over. ..."<br>`[594]` **Axel Reinhart**: ""But I am not backing down. Pale..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[618]` **Narrator**: "Duke Reinhart nodded." |
| `[597]` | **""My country is not as desperate as yours. Keep the field if you like." [Cede Field]"** | `[592]` **Axel Reinhart**: ""No, this conversation is over. ..."<br>`[594]` **Axel Reinhart**: ""But I am not backing down. Pale..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[598]` **Narrator**: "Duke Reinhart blinked." |
| `[603]` | **""It's a small price to pay for a chance at reconciliation.""** | `[602]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Axel Reinhart**: ""I believe you mean that."" |
| `[604]` | **""All I ask in return is that you remember our generosity.""** | `[602]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Axel Reinhart**: ""I will."" |
| `[610]` | **""This doesn't preclude the possibility of cooperation in the future.""** | `[602]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[611]` **Axel Reinhart**: ""Cooperation will be a lot harde..." |
| `[612]` | **""You and Lespia will both be first against the wall when the revolution comes, any..."** | `[602]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[615]` **Narrator**: "Reinhart scowled." |
| `[616]` | **""Considerable for Pales, perhaps. Rizia's energy needs are greater than you know.""** | `[570]` **Axel Reinhart**: ""But even a small percentage of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[642]` **Axel Reinhart**: ""Understood, Your Majesty. Tell ..." |
| `[617]` | **""I'd like to save us both the hassle. But I am under as much pressure as you are t..."** | `[566]` **Axel Reinhart**: ""But if you've changed your mind..."<br>`[568]` **Axel Reinhart**: ""But if you'd like to test that ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[642]` **Axel Reinhart**: ""Understood, Your Majesty. Tell ..." |
| `[619]` | **""Furthermore, I'm sending naval reinforcements to prevent Pales from further invad..."** | `[600]` **Axel Reinhart**: ""Not the outcome I was hoping fo..." | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false` | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...`<br>`Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = V...` | `[621]` **Narrator**: "His nostrils flared." |
| `[622]` | **""With the help of a third party, I'm sure we'll be able to come to a compromise.""** | `[600]` **Axel Reinhart**: ""Not the outcome I was hoping fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[625]` **Axel Reinhart**: ""A fast one, I hope. Lespia has ..." |
| `[623]` | **""Did you really think we'd just hand you the field?""** | `[600]` **Axel Reinhart**: ""Not the outcome I was hoping fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Axel Reinhart**: ""I thought you'd recognize a los..." |
| `[628]` | **""My war councilor suggested it as soon as your ship launched. I should have listen..."** | `[627]` **Axel Reinhart**: ""That's *really* not the outcome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[631]` **Axel Reinhart**: ""She's an Azaro, isn't she? This..." |
| `[629]` | **""I trust you. But I fear Lespia might lose its patience.""** | `[627]` **Axel Reinhart**: ""That's *really* not the outcome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[632]` **Axel Reinhart**: ""If you insist on stoking potent..." |
| `[630]` | **""I'm only taking precautions.""** | `[627]` **Axel Reinhart**: ""That's *really* not the outcome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[633]` **Axel Reinhart**: ""Then so will we."" |
| `[641]` | **""I see no choice but to enter arbitration. We will notify the Alliance of Nations ..."** | `[640]` **Axel Reinhart**: ""Enough insults, Your Majesty. T..."<br>`[642]` **Axel Reinhart**: ""Understood, Your Majesty. Tell ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[618]` **Narrator**: "Duke Reinhart nodded." |
| `[643]` | **""You know what? Rizia is not that desperate. We will cede the field to you if you ..."** | `[640]` **Axel Reinhart**: ""Enough insults, Your Majesty. T..."<br>`[642]` **Axel Reinhart**: ""Understood, Your Majesty. Tell ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[598]` **Narrator**: "Duke Reinhart blinked." |
| `[645]` | **""What sovereignty? Your family only came to power because the Valgos Empire put yo..."** | `[14]` **Axel Reinhart**: ""You could have waited for me to..."<br>`[15]` **Axel Reinhart**: ""It means that despite my prior ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[659]` **Axel Reinhart**: ""And what of Rizia? Trudging for..." |
| `[646]` | **""Your 'sovereignty' only exists because of Lespian support. Without it, Pales woul..."** | `[14]` **Axel Reinhart**: ""You could have waited for me to..."<br>`[15]` **Axel Reinhart**: ""It means that despite my prior ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[650]` **Axel Reinhart**: ""And what of Rizia and Rumburg? ..." |
| `[647]` | **""Please, Your Grace. Let's not let the bad blood between our families color our pr..."** | `[14]` **Axel Reinhart**: ""You could have waited for me to..."<br>`[15]` **Axel Reinhart**: ""It means that despite my prior ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Axel Reinhart**: ""Between our families? I think y..."<br>`[655]` **Axel Reinhart**: ""I am prepared to reconcile as l..." |
| `[648]` | **""We respect your sovereignty. It doesn't mean you can steal our gas from us.""** | `[14]` **Axel Reinhart**: ""You could have waited for me to..."<br>`[15]` **Axel Reinhart**: ""It means that despite my prior ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[651]` **Axel Reinhart**: ""It is disrespectful to claim th..." |
| `[662]` | **""Pales could have kept its cultural identity intact if it had rejoined Rizia.""** | `[661]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Axel Reinhart**: ""Your father would never have al..." |
| `[663]` | **""Regimes end. It was your time.""** | `[661]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[667]` **Axel Reinhart**: ""That wasn't your kingdom's deci..." |
| `[664]` | **""No. No, I suppose not.""** | `[661]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[676]` **Axel Reinhart**: ""I heard what it was like back t..." |
| `[665]` | **""I would have done that before turning to Lespia.""** | `[661]` **Axel Reinhart**: ""When the Empire fell apart, wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[668]` **Axel Reinhart**: ""You don't know what you would h..." |
| `[678]` | **""They supported your independence... by making you dependent on them.""** | `[674]` **Axel Reinhart**: ""Lespia, on the other hand, was ..."<br>`[675]` **Axel Reinhart**: ""So they accepted help from Lesp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Axel Reinhart**: ""By making us wealthy. By giving..." |
| `[679]` | **""Your family must have realized their motives for doing so were less than pure.""** | `[674]` **Axel Reinhart**: ""Lespia, on the other hand, was ..."<br>`[675]` **Axel Reinhart**: ""So they accepted help from Lesp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[682]` **Axel Reinhart**: ""Of course. But thanks to Rizia'..." |
| `[680]` | **""You should never have been put in that position, Your Grace. My country should ha..."** | `[674]` **Axel Reinhart**: ""Lespia, on the other hand, was ..."<br>`[675]` **Axel Reinhart**: ""So they accepted help from Lesp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[681]` **Axel Reinhart**: ""Thank you for acknowledging tha..." |
| `[684]` | **""Now that Lespia is an ATO member, they won't want to be connected to a monarchy f..."** | `[681]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[682]` **Axel Reinhart**: ""Of course. But thanks to Rizia'..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[688]` **Narrator**: "His gaze hardened as he looked a..." |
| `[685]` | **""I understand why Pales accepted Lespia's aid. But now that Morella is in league w..."** | `[681]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[682]` **Axel Reinhart**: ""Of course. But thanks to Rizia'..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[691]` **Narrator**: "His gaze hardened as he looked a..." |
| `[686]` | **""Enough with the history lesson. What do you plan to do *now*?""** | `[681]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[682]` **Axel Reinhart**: ""Of course. But thanks to Rizia'..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[693]` **Narrator**: "His gaze hardened as he looked a..." |
| `[687]` | **""Have you met their new prime minister? Do you trust him?""** | `[681]` **Axel Reinhart**: ""Thank you for acknowledging tha..."<br>`[682]` **Axel Reinhart**: ""Of course. But thanks to Rizia'..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[700]` **Narrator**: "His gaze hardened as he looked a..." |
| `[696]` | **""Calm down, Your Grace. We have no intention of starting a fight.""** | `[690]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[697]` **Axel Reinhart**: ""Then prove it. Send your ships ..." |
| `[698]` | **""If it's a fight you want, it's a fight you'll get.""** | `[690]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[703]` **Axel Reinhart**: ""Are you sure, Your Majesty? You..." |
| `[699]` | **""You are not the only country with obligations. And the gas field is large enough ..."** | `[690]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[704]` **Axel Reinhart**: ""Sharing a gas field requires cl..." |
| `[702]` | **""A compelling argument. But we won't cede the field to you for nothing.""** | `[690]` **Axel Reinhart**: ""So you see, Your Majesty, we ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[706]` **Axel Reinhart**: ""Why not? It would avoid us both..." |
| `[705]` | **""I will when you send *your* ship back.""** | `[697]` **Axel Reinhart**: ""Then prove it. Send your ships ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[715]` **Axel Reinhart**: ""No, I will not withdraw Pales' ..." |
| `[707]` | **""I am considering it. But we have to come to an agreement regarding the gas field ..."** | `[697]` **Axel Reinhart**: ""Then prove it. Send your ships ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[716]` **Axel Reinhart**: ""Excuse me, Your Majesty, but I'..." |
| `[708]` | **""How do I know you won't just resume drilling if I call for a retreat?""** | `[697]` **Axel Reinhart**: ""Then prove it. Send your ships ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[717]` **Axel Reinhart**: ""If I do that, you can call your..." |
| `[709]` | **""Yes. We had you beat until you went crying to Lespia.""** | `[703]` **Axel Reinhart**: ""Are you sure, Your Majesty? You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[718]` **Axel Reinhart**: ""Lespia only offered us minor as..." |
| `[710]` | **""Yes. We lost a lot of good men fighting Pales.""** | `[703]` **Axel Reinhart**: ""Are you sure, Your Majesty? You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[719]` **Axel Reinhart**: ""Invading Pales, you mean."" |
| `[711]` | **""I remember better than you. You weren't even born.""** | `[703]` **Axel Reinhart**: ""Are you sure, Your Majesty? You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[720]` **Axel Reinhart**: ""Then you know how unwise it is ..." |
| `[712]` | **""I admit I acted harshly. If I agree to call back our ships, can we have a reasona..."** | `[704]` **Axel Reinhart**: ""Sharing a gas field requires cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[721]` **Axel Reinhart**: ""At last, something resembling s..." |
| `[713]` | **""We don't have to collaborate. Just stay on our respective sides.""** | `[704]` **Axel Reinhart**: ""Sharing a gas field requires cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[724]` **Axel Reinhart**: ""There's too much potential for ..." |
| `[714]` | **""If you don't choose to collaborate, we will force you to do so.""** | `[704]` **Axel Reinhart**: ""Sharing a gas field requires cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[725]` **Axel Reinhart**: ""Please, Your Majesty. Neither o..." |
| `[728]` | **""Giving in to Pales, and therefore Lespia, would make us look weak internationally..."** | `[706]` **Axel Reinhart**: ""Why not? It would avoid us both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[733]` **Axel Reinhart**: ""Have you thought about how it w..." |
| `[729]` | **""Rizia needs the gas in that field, Your Grace. Do not test us.""** | `[706]` **Axel Reinhart**: ""Why not? It would avoid us both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[732]` **Axel Reinhart**: ""Just because you need it doesn'..." |
| `[730]` | **""It's the principle of the thing. I truly believe the field's proximity to Caleqab..."** | `[706]` **Axel Reinhart**: ""Why not? It would avoid us both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[731]` **Axel Reinhart**: ""And I believe it doesn't. So wh..." |
| `[735]` | **""Absolutely not. My ships are staying right where they are.""** | `[722]` **Axel Reinhart**: ""I am asking you politely. Withd..."<br>`[723]` **Axel Reinhart**: ""I will give you one chance. Wit..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[739]` **Narrator**: "Duke Reinhart paled. He swallowe..." |
| `[736]` | **""If it means we can move forward, then fine. I'll call off my ships effective imme..."** | `[722]` **Axel Reinhart**: ""I am asking you politely. Withd..."<br>`[723]` **Axel Reinhart**: ""I will give you one chance. Wit..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[737]` **Narrator**: "Duke Reinhart breathed a shaky s..." |
| `[742]` | **""Great. They'll easily rule that Pales acted in direct violation of the AN Directi..."** | `[741]` **Axel Reinhart**: ""I see no choice but to call in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[749]` **Axel Reinhart**: ""A directive we never ratified."" |
| `[744]` | **""Halaita. If it is said, so it is, so it will be.""** | `[741]` **Axel Reinhart**: ""I see no choice but to call in ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[747]` **Axel Reinhart**: ""I never cared for those old Wru..." |
| `[745]` | **""It's only nuanced compared to its predecessors. It doesn't stand alone as a brill..."** | `[743]` **Axel Reinhart**: ""And even if it applies, ANDOR i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[777]` **Axel Reinhart**: ""It's nuanced enough that I beli..." |
| `[746]` | **""We have the support of the international community. Pales doesn't.""** | `[743]` **Axel Reinhart**: ""And even if it applies, ANDOR i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[776]` **Axel Reinhart**: ""We have the backing of Lespia, ..." |
| `[748]` | **""The rules over our maritime borders seem clear to me. And to my councilors as well.""** | `[743]` **Axel Reinhart**: ""And even if it applies, ANDOR i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[778]` **Axel Reinhart**: ""Let's see if the AN sees it tha..." |
| `[750]` | **""You're disrespecting our religion now?""** | `[747]` **Axel Reinhart**: ""I never cared for those old Wru..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[755]` **Axel Reinhart**: ""I'm as God-fearing as the next ..." |
| `[751]` | **""Come on. What happened to solving disputes man to man?""** | `[741]` **Axel Reinhart**: ""I see no choice but to call in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[752]` **Axel Reinhart**: ""I won't risk it. The potential ..." |
| `[753]` | **""It's not a saw, it's a promise. Your words shall translate into actions.""** | `[747]` **Axel Reinhart**: ""I never cared for those old Wru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[756]` **Axel Reinhart**: ""You're right about that."" |
| `[757]` | **""Nor do I, but my subjects go crazy for them.""** | `[747]` **Axel Reinhart**: ""I never cared for those old Wru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[758]` **Axel Reinhart**: ""Everyone loves a king with a di..." |
| `[762]` | **""Wait. If I *do* cede the field to Pales, what will you give Rizia in return?""** | `[761]` **Axel Reinhart**: ""So the only choice I see is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[763]` **Axel Reinhart**: ""The chance to avoid a lengthy, ..." |
| `[765]` | **""Not much of a consolation prize.""** | `[764]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[772]` **Axel Reinhart**: ""Well. I can't think of anything..." |
| `[766]` | **""What makes you think Rizia will lose?""** | `[764]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[770]` **Axel Reinhart**: ""We have the backing of Lespia, ..." |
| `[767]` | **""What about a chance for lasting peace between our two nations?""** | `[764]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[768]` **Axel Reinhart**: ""You made it clear that Rizia di..." |
| `[774]` | **""I refuse to make deals with Lespia.""** | `[764]` **Axel Reinhart**: ""We don't have much to give, I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[775]` **Axel Reinhart**: ""Then never mind."" |
| `[780]` | **""Your intimidation won't work on me. Remember, my navy is still surrounding your s..."** | `[776]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[777]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[793]` **Axel Reinhart**: ""And I hope you will send it awa..." |
| `[781]` | **""You're forgetting the support we have from Rumburg and GRACE.""** | `[776]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[777]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[796]` **Axel Reinhart**: ""This is the 20th century, Your ..." |
| `[782]` | **""The rest of Southern Merkopa will take my side.""** | `[776]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[777]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[797]` **Axel Reinhart**: ""Will they? After you've shown t..." |
| `[783]` | **""You shouldn't place so much trust in Lespia, Your Grace.""** | `[776]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[777]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[798]` **Axel Reinhart**: ""And you should not underestimat..." |
| `[784]` | **""You're right. Calling in a third party will help us find a compromise.""** | `[752]` **Axel Reinhart**: ""I won't risk it. The potential ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[786]` **Axel Reinhart**: ""To the extent that 'compromise'..." |
| `[787]` | **""Armed conflict... what about arm wrestling? We can settle the argument right here..."** | `[752]` **Axel Reinhart**: ""I won't risk it. The potential ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[788]` **Narrator**: "He raised an eyebrow. I saw the ..." |
| `[794]` | **""That's presumptuous of you, Your Grace. You'll find no support from the rest of S..."** | `[785]` **Axel Reinhart**: ""In any event, I hope you will s..."<br>`[791]` **Axel Reinhart**: ""Just as you will lose the arbit..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[813]` **Axel Reinhart**: ""And you will?"" |
| `[795]` | **""What makes you think we will lose? Remember that we have GRACE on our side.""** | `[785]` **Axel Reinhart**: ""In any event, I hope you will s..."<br>`[791]` **Axel Reinhart**: ""Just as you will lose the arbit..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[814]` **Axel Reinhart**: ""This is the 20th century, Your ..." |
| `[800]` | **""That's the only choice? Can't we come to a compromise on our own?""** | `[761]` **Axel Reinhart**: ""So the only choice I see is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[836]` **Axel Reinhart**: ""Not after your past animosity t..."<br>`[840]` **Axel Reinhart**: ""I'm afraid your naval blockade ..." |
| `[801]` | **""You're afraid of what would happen if I unleashed the full power of the Rizian mi..."** | `[752]` **Axel Reinhart**: ""I won't risk it. The potential ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[802]` **Axel Reinhart**: ""I most certainly am not."" |
| `[807]` | **""By all means, do.""** | `[806]` **Axel Reinhart**: ""You do understand that as long ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[819]` **Axel Reinhart**: ""You're playing a very dangerous..." |
| `[808]` | **""Your vastly inferior ships, you mean.""** | `[806]` **Axel Reinhart**: ""You do understand that as long ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[818]` **Axel Reinhart**: ""You do not want to test the str..." |
| `[809]` | **""I'm sorry that it's come to this, Your Grace.""** | `[806]` **Axel Reinhart**: ""You do understand that as long ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[817]` **Axel Reinhart**: ""This entirely avoidable situati..." |
| `[810]` | **""Watching your face as you surrender will be worth it.""** | `[803]` **Axel Reinhart**: ""But if we get into a conflict a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[830]` **Axel Reinhart**: ""Believe me, Pales would not sur..." |
| `[811]` | **""I will respect whatever the AN decides, as long as their judgement is fair and un..."** | `[785]` **Axel Reinhart**: ""In any event, I hope you will s..."<br>`[792]` **Axel Reinhart**: ""I hope you will send your ships..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[815]` **Axel Reinhart**: ""I'll hold you to that, Your Maj..." |
| `[812]` | **""I knew the Duke of Pales would be too cowardly to arm wrestle a real king.""** | `[791]` **Axel Reinhart**: ""Just as you will lose the arbit..."<br>`[905]` **Axel Reinhart**: ""We're going to arbitration. And..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[816]` **Axel Reinhart**: ""You're embarrassing yourself, Y..." |
| `[823]` | **""Until then, Duke Reinhart.""** | `[822]` **Axel Reinhart**: ""I'll see you in court, King Rom..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitra...`<br>`Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = ...`<br>*(+1 skryptów)* | `[55]` **Narrator**: "I rejoined Titus in the receptio..." |
| `[824]` | **""Goodbye, Your Grace.""** | `[822]` **Axel Reinhart**: ""I'll see you in court, King Rom..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitra...`<br>`Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = ...`<br>*(+1 skryptów)* | `[55]` **Narrator**: "I rejoined Titus in the receptio..." |
| `[825]` | **""See you on the battlefield.""** | `[822]` **Axel Reinhart**: ""I'll see you in court, King Rom..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...`<br>`Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitra...`<br>*(+2 skryptów)* | `[55]` **Narrator**: "I rejoined Titus in the receptio..." |
| `[827]` | **""Then we'll just have to do our fighting elsewhere.""** | `[803]` **Axel Reinhart**: ""But if we get into a conflict a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[829]` **Axel Reinhart**: ""I truly hope you don't mean that."" |
| `[828]` | **""I was only posturing. I have no intention of inciting conflict.""** | `[803]` **Axel Reinhart**: ""But if we get into a conflict a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[831]` **Axel Reinhart**: ""Nor do I. But accidents happen."" |
| `[841]` | **""They'll easily rule that Pales acted in direct violation of the AN Directive on O..."** | `[761]` **Axel Reinhart**: ""So the only choice I see is to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[846]` **Axel Reinhart**: ""A directive we never ratified."" |
| `[843]` | **""It's only nuanced compared to its predecessors. It doesn't stand alone as a brill..."** | `[842]` **Axel Reinhart**: ""And even if it applies, ANDOR i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[848]` **Axel Reinhart**: ""It's nuanced enough that I beli..." |
| `[844]` | **""We have the support of the international community. Pales doesn't.""** | `[842]` **Axel Reinhart**: ""And even if it applies, ANDOR i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[847]` **Axel Reinhart**: ""We have the backing of Lespia, ..." |
| `[845]` | **""The rules over our maritime borders seem clear to me. And to my councilors as well.""** | `[842]` **Axel Reinhart**: ""And even if it applies, ANDOR i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[855]` **Axel Reinhart**: ""Let's see if the AN sees it tha..." |
| `[849]` | **""You shouldn't place so much trust in Lespia, Your Grace.""** | `[847]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[848]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[854]` **Axel Reinhart**: ""And you should not underestimat..." |
| `[850]` | **""Your intimidation won't work on me.""** | `[847]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[848]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[856]` **Axel Reinhart**: ""It's not intimidation. I'm just..." |
| `[851]` | **""You're forgetting the support we have from Rumburg and GRACE.""** | `[847]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[848]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[852]` **Axel Reinhart**: ""This is the 20th century, Your ..." |
| `[858]` | **""The rest of Southern Merkopa will take my side.""** | `[847]` **Axel Reinhart**: ""We have the backing of Lespia, ..."<br>`[848]` **Axel Reinhart**: ""It's nuanced enough that I beli..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[853]` **Axel Reinhart**: ""Will they? After you've shown t..." |
| `[861]` | **""I am not backing down. We will have to enter arbitration.""** | `[769]` **Axel Reinhart**: ""But if you've changed your mind..."<br>`[771]` **Axel Reinhart**: ""But if you'd like to test that ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitra...`<br>`Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = ...` | `[906]` **Narrator**: "The Duke gritted his teeth." |
| `[862]` | **""You know what? You're obviously more desperate for this gas field than we are. Ke..."** | `[769]` **Axel Reinhart**: ""But if you've changed your mind..."<br>`[771]` **Axel Reinhart**: ""But if you'd like to test that ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true...`<br>`Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...` | `[867]` **Narrator**: "Duke Reinhart blinked." |
| `[870]` | **""It's a small price to pay for a chance at reconciliation.""** | `[869]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[874]` **Axel Reinhart**: ""You sent your navy after us, no..." |
| `[871]` | **""All I ask in return is that you remember our generosity.""** | `[869]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[875]` **Axel Reinhart**: ""You sent your navy after us, no..." |
| `[872]` | **""I am hoping that this gives us a chance for cooperation in the future.""** | `[869]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[879]` **Axel Reinhart**: ""You sent your navy after us, an..." |
| `[873]` | **""You and Lespia will both be first against the wall when the revolution comes, any..."** | `[869]` **Axel Reinhart**: ""Thank you. I guess."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[882]` **Narrator**: "Reinhart scowled." |
| `[910]` | **""I believe we're done here.""** | `[916]` **Axel Reinhart**: ""I'm sorry it had to come to that."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...` | `[863]` **Axel Reinhart**: ""So be it, Your Majesty."" |
| `[911]` | **""Furthermore, since you were unable to offer us anything, I will not be recalling ..."** | `[916]` **Axel Reinhart**: ""I'm sorry it had to come to that."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = ...` | `[914]` **Narrator**: "His jaw twitched." |
| `[912]` | **""As am I.""** | `[916]` **Axel Reinhart**: ""I'm sorry it had to come to that."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...` | `[863]` **Axel Reinhart**: ""So be it, Your Majesty."" |
| `[933]` | **""Seems reasonable to me. You have a deal, Duke Reinhart." [-10 Budget Now, -2 Budg..."** | `[930]` **Narrator**: "It was a ridiculously large sum,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`--;`<br>*(+3 skryptów)* | `[464]` **Axel Reinhart**: ""Really?"" |
| `[934]` | **""Seems reasonable to me. You have a deal, Duke Reinhart." [-8 Budget Now, -2 Budge..."** | `[403]` **Narrator**: "It was an extremely large sum, b..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`--;`<br>*(+3 skryptów)* | `[464]` **Axel Reinhart**: ""Really?"" |
| `[941]` | **""Very well, Your Grace. You have a deal." [-8 Budget Now, -2 Budget Per Turn Now, ..."** | `[455]` **Axel Reinhart**: ""Unfortunately, if you can't pur..." | `Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`--;`<br>*(+3 skryptów)* | `[464]` **Axel Reinhart**: ""Really?"" |
| `[942]` | **""Very well, Your Grace. You have a deal." [-6 Budget Now, -2 Budget Per Turn Now, ..."** | `[455]` **Axel Reinhart**: ""Unfortunately, if you can't pur..." | `Variable["RiziaDLC.Resources_Budget"] >= 6  and  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true) == true`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`--;`<br>*(+3 skryptów)* | `[464]` **Axel Reinhart**: ""Really?"" |
| `[954]` | **""We can afford the deal if we need to. But I was hoping for a neighborly discount.""** | `[447]` **Axel Reinhart**: ""I approached you because I beli..."<br>`[453]` **Axel Reinhart**: ""Frankly, I thought Rizia could ..." | `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 6  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == false  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false)` | *Brak zmian stanu* | `[955]` **Axel Reinhart**: ""This *is* my discount."" |

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
  - -> `[956]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Choosing between peace and war", "Castle..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "He sighed and slid a report across the table towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Axel Reinhart: ""My security minister woke me up at midnight with this.""*)

### Węzeł `[4]`
Mówca: **Axel Reinhart**
> ""My security minister woke me up at midnight with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Axel Reinhart: ""I was assured that Pales had every right to begin drilli..."*)

### Węzeł `[5]`
Mówca: **Axel Reinhart**
> ""I was assured that Pales had every right to begin drilling in the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Axel Reinhart: ""And now our ship finds itself in a standoff with the Riz..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your country sending the drillship was an act of provocation. I had no choice but to respond in kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think it means, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you send that ship to begin with? Why not notify my government?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[9]`
Mówca: **Axel Reinhart**
> ""I was perfectly happy living a life of leisure, coasting off the family fortune, enjoying the odd celebrity rendezvous...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince"*)
  - -> `[20]` (*Player_Romus: ""You didn't have to take his place.""*)
  - -> `[22]` (*Player_Romus: ""Life is full of surprises, Your Grace. Should we get dow..."*)
  - -> `[21]` (*Player_Romus: ""Wait. Which celebrities?""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "He looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Axel Reinhart: ""I know that our expedition may have seemed like an act o..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Axel Reinhart: ""You could have waited for me to state my case. Instead, ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Axel Reinhart: ""You could have waited for me to state my case. Instead, ..."*)

### Węzeł `[14]`
Mówca: **Axel Reinhart**
> ""You could have waited for me to state my case. Instead, you proved, once more, that you have no respect for Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[646]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[647]` (*Player_Romus: ""Please, Your Grace. Let's not let the bad blood between ..."*)
  - -> `[648]` (*Player_Romus: ""We respect your sovereignty. It doesn't mean you can ste..."*)

### Węzeł `[15]`
Mówca: **Axel Reinhart**
> ""It means that despite my prior entreaties to you, the Rizian government continues to disrespect Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[646]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[647]` (*Player_Romus: ""Please, Your Grace. Let's not let the bad blood between ..."*)
  - -> `[648]` (*Player_Romus: ""We respect your sovereignty. It doesn't mean you can ste..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the 'Party Prince' you're talking to. I know the feeling.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Kontekst wejściowy (poprzednik):** `[9]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""This is the 'Party Prince' you're talking to. I know the..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You didn't have to take his place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. Which celebrities?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Life is full of surprises, Your Grace. Should we get down to negotiations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[23]`
Mówca: **Axel Reinhart**
> ""Oh, but I did. Somebody had to step up to protect the Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He sighed and slid a report across the table towards me."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Axel Reinhart: ""Yes, I know all about your escapades. In another life, w..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Axel Reinhart: ""A brilliant idea, putting jerks like us in charge of ent..."*)

### Węzeł `[27]`
Mówca: **Axel Reinhart**
> ""A brilliant idea, putting jerks like us in charge of entire countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""Yes, I know all about your escapades. In another life, we could've been friends. But in this one...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He sighed and slid a report across the table towards me."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Axel Reinhart: ""Oh, but I did. Somebody had to step up to protect the Gr..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Axel Reinhart: ""And who would have stepped up in my stead? Who's left to..."*)

### Węzeł `[32]`
Mówca: **Axel Reinhart**
> ""And who would have stepped up in my stead? Who's left to protect Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[33]`
Mówca: **Axel Reinhart**
> ""Yes, I suppose we had better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[34]`
Mówca: **Axel Reinhart**
> ""What is there to negotiate?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He sighed and slid a report across the table towards me."*)

### Węzeł `[35]`
Mówca: **Axel Reinhart**
> ""You'll have to wait until my memoirs are published. If I live long enough to write them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He sighed and slid a report across the table towards me."*)

### Węzeł `[36]`
Mówca: **Axel Reinhart**
> ""If I listed them all, we'd never have time for this talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[37]`
Mówca: **Axel Reinhart**
> ""I'll be honest with you, Your Majesty. I never expected my brother to abdicate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Axel Reinhart: ""I was perfectly happy living a life of leisure, coasting..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Axel Reinhart: ""What is there to negotiate?""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Axel Reinhart: ""Yes, I suppose we had better.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Axel Reinhart: ""You'll have to wait until my memoirs are published. If I..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Axel Reinhart: ""If I listed them all, we'd never have time for this talk.""*)

### Węzeł `[44]`
Mówca: **Axel Reinhart**
> ""I know that our expedition may have seemed like an act of aggression. But all we are doing is claiming what is rightfully ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: ""I recognize your claim on the field. But you must recogn..."*)
  - -> `[155]` (*Player_Romus: ""You broke the law by sending that ship. Count yourself l..."*)
  - -> `[272]` (*Player_Romus: ""This is all a misunderstanding, Duke Reinhart. Send your..."*)
  - -> `[156]` (*Player_Romus: ""Rizia does not dispute your claim to the field. In fact,..."*)

### Węzeł `[45]`
Mówca: **Titus Gordion**
> ""How did it go, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[62]` (*Player_Romus: ""The Duke is a snake. But I can still get the upper hand ..."*)
  - -> `[65]` (*Player_Romus: ""That's between me and His Grace.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The Duke reached beneath the table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Axel Reinhart: ""Hilda? Be a doll and help show His Majesty the way out o..."*)

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He sat back in his chair and scrutinized me closely."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Axel Reinhart: ""My brother always told me never to reason with a Rizian.""*)

### Węzeł `[49]`
Mówca: **Axel Reinhart**
> ""My brother always told me never to reason with a Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Axel Reinhart: ""But what can I say? I'm an optimist.""*)

### Węzeł `[50]`
Mówca: **Axel Reinhart**
> ""But what can I say? I'm an optimist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""For the amount I'm paying, something good had better com..."*)
  - -> `[52]` (*Player_Romus: ""So am I.""*)
  - -> `[53]` (*Player_Romus: ""You're lucky that this Rizian sees reason.""*)
  - -> `[54]` (*Player_Romus: ""You're not your brother. And I'm not my father. We can b..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the amount I'm paying, something good had better come out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So am I.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lucky that this Rizian sees reason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not your brother. And I'm not my father. We can break this cycle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "I rejoined Titus in the reception room. We followed Hilda through winding corridors to the front door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "We stepped outside into the waning sunlight. He waited un..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "We stepped outside into the waning sunlight. He waited until we were out of the building's shadow to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Titus Gordion: ""How did it go, Your Majesty?""*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surprisingly well. I'm excited to see what comes next.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Kontekst wejściowy (poprzednik):** `[45]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Titus nodded wordlessly. We got into the car and began th..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""Surprisingly well. I'm excited to see what comes next.""*)
  - -> `[61]` (*Player_Romus: ""One step closer to Palesian-Rizian reunification, Titus.""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""Not great. Not great at all.""*)
  - -> `[64]` (*Player_Romus: ""We may yet have a chance to avenge your father's death.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One step closer to Palesian-Rizian reunification, Titus.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Kontekst wejściowy (poprzednik):** `[45]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Titus nodded wordlessly. We got into the car and began th..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Duke is a snake. But I can still get the upper hand on him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Titus nodded wordlessly. We got into the car and began th..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not great. Not great at all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[45]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Titus nodded wordlessly. We got into the car and began th..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may yet have a chance to avenge your father's death.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[45]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Titus nodded wordlessly. We got into the car and began th..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's between me and His Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Titus nodded wordlessly. We got into the car and began th..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Titus nodded wordlessly. We got into the car and began the long trip back to Porte Drazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_MetAxel == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_MetAxel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "It was my first visit to Pales since becoming King of Rizia."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_MetAxel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_MetAxel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I hadn't been to Pales in many years."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I hadn't been to Pales in many years."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Titus and I stood side by side, peering out the window of..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "It was my first visit to Pales since becoming King of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Titus and I stood side by side, peering out the window of..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Titus and I stood side by side, peering out the window of Castle Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The Grand Duchy's royal residence was built on the founda..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The Grand Duchy's royal residence was built on the foundations of an ancient paleacco, one of the stone fortifications that gave Pales its name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "After his coronation, Duke Axel Reinhart had hired an up-..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "After his coronation, Duke Axel Reinhart had hired an up-and-coming local architect to expand the old building into a swooping, bulging wood and glass structure that seemed almost alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "The reception room had been moved to the top floor, and b..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "The reception room had been moved to the top floor, and boasted enormous curved windows with a view of the Pales skyline. Its soaring, angular skyscrapers were unlike anything built in Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Titus Gordion: ""So this is the 'Pearl of the Antacean.'""*)

### Węzeł `[76]`
Mówca: **Titus Gordion**
> ""So this is the 'Pearl of the Antacean.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Romus: ""You sound unimpressed, Captain.""*)
  - -> `[79]` (*Player_Romus: ""Hard to believe all of this sprung up in the last few de..."*)
  - -> `[78]` (*Player_Romus: ""Amazing what Lespian money can buy, isn't it?""*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You sound unimpressed, Captain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Titus Gordion: ""I'm a simple man, sir. Give me the classicism of Palas R..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing what Lespian money can buy, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Titus Gordion: ""'Amazing' is one word for it, sir.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hard to believe all of this sprung up in the last few decades alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Titus Gordion: ""Truly a feat, sir.""*)

### Węzeł `[80]`
Mówca: **Titus Gordion**
> ""I'm a simple man, sir. Give me the classicism of Palas Rezna over... whatever this is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[81]`
Mówca: **Titus Gordion**
> ""Truly a feat, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[82]`
Mówca: **Titus Gordion**
> ""'Amazing' is one word for it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Titus glanced around us."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Titus glanced around us."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Titus glanced around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Titus Gordion: ""By the way, Your Majesty, the men your cousin turned ove..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Titus glanced around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Titus Gordion: ""We've been making little headway with the Su Omina inves..."*)

### Węzeł `[91]`
Mówca: **Titus Gordion**
> ""Your cousin's associates have been less than cooperative. Even if they're innocent in the Wehlen bombing, I suspect they still have something to hide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[96]` (*Player_Romus: ""Investigate harder, damn it.""*)
  - -> `[98]` (*Player_Romus: ""Keep up the good work.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about that *other* investigation I ordered?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[91]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Titus Gordion: ""Still in the works, sir. It's too sensitive to assign to..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""What about that *other* investigation I ordered?""*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Investigate harder, damn it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Titus Gordion: ""I'll pass on the order.""*)

### Węzeł `[97]`
Mówca: **Titus Gordion**
> ""By the way, Your Majesty, the men your cousin turned over have been extradited to Wehlen. There's still no word on what will happen to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_TitusLeadsInvestigation = false"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep up the good work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Titus Gordion: ""I'll pass that on.""*)

### Węzeł `[99]`
Mówca: **Titus Gordion**
> ""Still in the works, sir. It's too sensitive to assign to anyone else, so I'll have to pick it back up once we have significant time in the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[100]`
Mówca: **Titus Gordion**
> ""I'll pass on the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[101]`
Mówca: **Titus Gordion**
> ""I'll pass that on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where are you from, Titus?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false` AND `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Titus Gordion), `[81]` (Titus Gordion), `[82]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Titus Gordion: ""Born and raised in Porte Drazon.""*)

### Węzeł `[103]`
Mówca: **Titus Gordion**
> ""Born and raised in Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Titus Gordion: ""My father was killed during the operation to take back P..."*)

### Węzeł `[104]`
Mówca: **Titus Gordion**
> ""My father was killed during the operation to take back Pales. I took up championship boxing to support my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player_Romus: ""He gave his life for a good cause.""*)
  - -> `[106]` (*Player_Romus: ""So much senseless bloodshed. May it never happen again.""*)
  - -> `[107]` (*Player_Romus: ""I bet you were good at it.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He gave his life for a good cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Titus Gordion), `[112]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Titus Gordion: ""He believed in it with all his heart. He never turned ag..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So much senseless bloodshed. May it never happen again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Titus Gordion), `[112]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Titus Gordion: ""For what it's worth, sir, he believed in the cause. He n..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bet you were good at it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""Good enough to get noticed by military recruiters. I do ..."*)

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""Good enough to get noticed by military recruiters. I do miss those days in the ring sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[109]`
Mówca: **Titus Gordion**
> ""For what it's worth, sir, he believed in the cause. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[110]`
Mówca: **Titus Gordion**
> ""He believed in it with all his heart. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you've never been to Pales before?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false` AND `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Titus Gordion), `[81]` (Titus Gordion), `[82]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Titus Gordion: ""No, sir. My father fought in the operation to take it ba..."*)

### Węzeł `[112]`
Mówca: **Titus Gordion**
> ""No, sir. My father fought in the operation to take it back. Actually, he was killed here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player_Romus: ""He gave his life for a good cause.""*)
  - -> `[106]` (*Player_Romus: ""So much senseless bloodshed. May it never happen again.""*)
  - -> `[113]` (*Player_Romus: ""Sorry if this visit is bringing up bad memories.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry if this visit is bringing up bad memories.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Titus Gordion: ""Not a problem, sir. He died fighting for what he believe..."*)

### Węzeł `[114]`
Mówca: **Titus Gordion**
> ""Not a problem, sir. He died fighting for what he believed in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "A panel in the wall slid open, and a secretary clad in a pastel minidress emerged. She motioned for me to enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""Into the breach.""*)
  - -> `[117]` (*Player_Romus: ""Sit tight. This ought to be quick.""*)
  - -> `[118]` (*Player_Romus: ""Make yourself comfortable. This might be a while.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Into the breach.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Titus Gordion: ""Good luck, sir.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit tight. This ought to be quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Titus Gordion: ""Will do, sir.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Make yourself comfortable. This might be a while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Titus Gordion: ""Will do, sir.""*)

### Węzeł `[119]`
Mówca: **Titus Gordion**
> ""Will do, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "The secretary announced my entrance. I stepped into the room and was greeted by Duke Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""Your Majesty. A pleasure to finally meet you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus_Italic: "Bow."*)
  - -> `[136]` (*Player_Romus: ""No ministers? No aides?""*)
  - -> `[128]` (*Player_Romus: ""I only wish it was under better circumstances, Your Grace.""*)
  - -> `[132]` (*Player_Romus: ""Likewise. You have a beautiful castle.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_MetAxel == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_MetAxel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "The Palesian ruler hadn't aged a day since we last met."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_MetAxel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_MetAxel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "The Palesian ruler was tall and square-jawed, with looks ..."*)

### Węzeł `[126]`
Mówca: **Axel Reinhart**
> ""Your Majesty. We meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""It's always a pleasure to visit this beautiful castle.""*)
  - -> `[133]` (*Player_Romus_Italic: "Bow."*)
  - -> `[136]` (*Player_Romus: ""No ministers? No aides?""*)
  - -> `[128]` (*Player_Romus: ""I only wish it was under better circumstances, Your Grace.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's always a pleasure to visit this beautiful castle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Axel Reinhart: ""Really? You think it's beautiful?""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only wish it was under better circumstances, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart), `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Axel Reinhart: ""As do I.""*)

### Węzeł `[129]`
Mówca: **Narrator**
> "The Palesian ruler hadn't aged a day since we last met."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "He was tall, square-jawed, with looks out of an adventure..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "The Palesian ruler was tall and square-jawed, with looks out of an adventure serial. I recalled that the tabloids had nicknamed him "Duke Dashing"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "He maintained eye contact as he bowed to me."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "He was tall, square-jawed, with looks out of an adventure serial. I recalled that the tabloids had nicknamed him "Duke Dashing"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He maintained eye contact as he bowed to me."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Likewise. You have a beautiful castle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Axel Reinhart: ""Really? You think it's beautiful?""*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "Bow."]** — Mówca: **Player_Romus_Italic**
> "I returned Duke Reinhart's bow. He spread his arms out wide."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart), `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Axel Reinhart: ""How do you like my castle?""*)

### Węzeł `[134]`
Mówca: **Axel Reinhart**
> ""Really? You think it's beautiful?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""It's very... modern.""*)
  - -> `[140]` (*Player_Romus: ""It's breathtaking.""*)
  - -> `[141]` (*Player_Romus: ""I have to be diplomatic, don't I?""*)

### Węzeł `[135]`
Mówca: **Axel Reinhart**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "The secretary left, closing the door behind her. The Duke..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No ministers? No aides?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart), `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Axel Reinhart: ""I thought it best to try and settle this business betwee..."*)

### Węzeł `[137]`
Mówca: **Axel Reinhart**
> ""I thought it best to try and settle this business between ourselves. Like in the old days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "The secretary left, closing the door behind her. The Duke..."*)

### Węzeł `[138]`
Mówca: **Axel Reinhart**
> ""How do you like my castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""It's very... modern.""*)
  - -> `[140]` (*Player_Romus: ""It's breathtaking.""*)
  - -> `[141]` (*Player_Romus: ""I have to be diplomatic, don't I?""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's very... modern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Axel Reinhart), `[138]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "A corner of his mouth turned up."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's breathtaking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Axel Reinhart), `[138]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "He raised an eyebrow."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to be diplomatic, don't I?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Axel Reinhart), `[138]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "A corner of his mouth turned up."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "A corner of his mouth turned up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Axel Reinhart: ""I wasn't sure about it myself. But when you're the leade..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Axel Reinhart: ""I wasn't sure about it myself. But when you're the leade..."*)

### Węzeł `[144]`
Mówca: **Axel Reinhart**
> ""I wasn't sure about it myself. But when you're the leader of such an advanced economy, there's always pressure to keep up with the times. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "The secretary left, closing the door behind her. The Duke..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "The secretary left, closing the door behind her. The Duke and I took seats on opposite sides of a wooden conference table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "His posture was casual, even as he regarded me with inten..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "His posture was casual, even as he regarded me with intensity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Axel Reinhart: ""I'll be honest with you, Your Majesty. I never expected ..."*)

### Węzeł `[147]`
Mówca: **Axel Reinhart**
> ""And now our ship finds itself in a standoff with the Rizian navy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Axel Reinhart: ""Tell me, Your Majesty. What is the meaning of this?""*)

### Węzeł `[148]`
Mówca: **Axel Reinhart**
> ""Tell me, Your Majesty. What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""Your country sending the drillship was an act of provoca..."*)
  - -> `[7]` (*Player_Romus: ""What do you think it means, Your Grace?""*)
  - -> `[8]` (*Player_Romus: ""Why did you send that ship to begin with? Why not notify..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Axel Reinhart: ""It means that, as usual, the Rizian government continues..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Axel Reinhart: ""It means that despite my prior entreaties to you, the Ri..."*)

### Węzeł `[152]`
Mówca: **Axel Reinhart**
> ""It means that, as usual, the Rizian government continues to disrespect Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[646]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[647]` (*Player_Romus: ""Please, Your Grace. Let's not let the bad blood between ..."*)
  - -> `[648]` (*Player_Romus: ""We respect your sovereignty. It doesn't mean you can ste..."*)

### Węzeł `[153]`
Mówca: **Axel Reinhart**
> ""You could have waited for me to state my case. Instead, you showed that, despite my prior entreaties, Rizia refuses to respect Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[646]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[647]` (*Player_Romus: ""Please, Your Grace. Let's not let the bad blood between ..."*)
  - -> `[648]` (*Player_Romus: ""We respect your sovereignty. It doesn't mean you can ste..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I recognize your claim on the field. But you must recognize Rizia's right to it as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Axel Reinhart: ""You can't truly think that the field's proximity to Cale..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You broke the law by sending that ship. Count yourself lucky that Rizia has not retaliated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Axel Reinhart: ""That's brave talk, Your Majesty.""*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia does not dispute your claim to the field. In fact, we're prepared to let you keep it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Axel Reinhart: ""You are?""*)

### Węzeł `[157]`
Mówca: **Axel Reinhart**
> ""You are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "He raised an eyebrow in suspicion."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "He raised an eyebrow in suspicion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Axel Reinhart: ""Is this the same Romus Toras I spoke to three years ago?""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Axel Reinhart: ""Let me guess. You want something in return.""*)

### Węzeł `[162]`
Mówca: **Axel Reinhart**
> ""Is this the same Romus Toras I spoke to three years ago?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""I know our first meeting went badly. This is my attempt ..."*)
  - -> `[165]` (*Player_Romus: ""My goal has always been to get Pales to rejoin Rizia. If..."*)
  - -> `[167]` (*Player_Romus: ""I didn't say I would cede the field out of pure generosi..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know our first meeting went badly. This is my attempt to make amends.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Axel Reinhart: ""And how can I trust you?""*)

### Węzeł `[164]`
Mówca: **Axel Reinhart**
> ""Let me guess. You want something in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Of course I do, Your Grace.""*)
  - -> `[169]` (*Player_Romus: ""No. I truly don't believe it's worth the hassle to fight..."*)
  - -> `[168]` (*Player_Romus: ""My goal has always been to get Pales to rejoin Rizia. If..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My goal has always been to get Pales to rejoin Rizia. If giving up a gas field will help me achieve that goal, I'll do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Axel Reinhart: ""You think we're willing to trade our sovereignty for acc..."*)

### Węzeł `[166]`
Mówca: **Axel Reinhart**
> ""You think we're willing to trade our sovereignty for access to natural gas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Axel Reinhart: ""Your Majesty, the Reinhart family has ruled over the Pal..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't say I would cede the field out of pure generosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Axel Reinhart: ""You must understand that Pales doesn't owe Rizia anything.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My goal has always been to get Pales to rejoin Rizia. If giving up a gas field will help me achieve that goal, I'll do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Axel Reinhart: ""You think we're willing to trade our sovereignty for acc..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I truly don't believe it's worth the hassle to fight for the field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "He cast a suspicious glance at me."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I do, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Axel Reinhart: ""You must understand that Pales doesn't owe Rizia anything.""*)

### Węzeł `[171]`
Mówca: **Axel Reinhart**
> ""You can't truly think that the field's proximity to Caleqabiz gives you a right to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player_Romus: ""Caleqabiz may be small, but it is still a part of the gr..."*)
  - -> `[292]` (*Player_Romus: ""I don't make the rules. Our claim is clearly valid accor..."*)
  - -> `[291]` (*Player_Romus: ""Our island counts just as much as your barely legitimate..."*)

### Węzeł `[172]`
Mówca: **Axel Reinhart**
> ""Your Majesty, I urge you to let this go. There are more powerful interests at play than either of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player_Romus: ""I too have the backing of powerful interests. You do not..."*)
  - -> `[285]` (*Player_Romus: ""That's precisely why I will not let this go. Western sup..."*)
  - -> `[280]` (*Player_Romus: ""So you're admitting it. You're a puppet of Lespia.""*)

### Węzeł `[173]`
Mówca: **Axel Reinhart**
> ""My legal experts have assured me that the proximity of Caleqabiz does not give Rizia a claim to our gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: ""Our island counts just as much as your barely legitimate..."*)
  - -> `[281]` (*Player_Romus: ""My own experts would say that you've acted in clear viol..."*)
  - -> `[301]` (*Player_Romus: ""We've established that we have differing interpretations..."*)

### Węzeł `[174]`
Mówca: **Axel Reinhart**
> ""And how can I trust you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Axel Reinhart: ""Your Majesty, you must understand that Pales doesn't owe..."*)

### Węzeł `[175]`
Mówca: **Axel Reinhart**
> ""You must understand that Pales doesn't owe Rizia anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""By claiming the Aureus field, we are merely asserting th..."*)

### Węzeł `[176]`
Mówca: **Axel Reinhart**
> ""By claiming the Aureus field, we are merely asserting the sovereignty that your country has disrespected for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[343]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[344]` (*Player_Romus: ""Please, Your Grace. Let's not let the hostility between ..."*)

### Węzeł `[177]`
Mówca: **Axel Reinhart**
> ""Your Majesty, you must understand that Pales doesn't owe Rizia anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""By claiming the Aureus field, we are merely asserting th..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They supported your independence... by making you dependent on them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Axel Reinhart), `[351]` (Axel Reinhart), `[361]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Axel Reinhart: ""You know how wealthy we are. It wasn't entirely a one-wa..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family must have realized their motives for doing so were less than pure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Axel Reinhart), `[351]` (Axel Reinhart), `[361]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Axel Reinhart: ""Of course. But what choice did they have?""*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should never have been put in that position, Your Grace. My predecessors' aggression was out of line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Axel Reinhart), `[351]` (Axel Reinhart), `[361]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Axel Reinhart: ""Thank you for acknowledging that. But it doesn't change ..."*)

### Węzeł `[181]`
Mówca: **Axel Reinhart**
> ""That's brave talk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Axel Reinhart: ""My legal experts have assured me that the proximity of C..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I see no other choice but arbitration. The Alliance of Nations will decide ownership." [Arbitration]"]** — Mówca: **Player_Romus**
> ""I see no other choice but arbitration. The Alliance of Nations will decide ownership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Axel Reinhart), `[456]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Duke Reinhart frowned."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""I suggest you keep the field, and keep the deal with Lespia. Rizia is staying out of this." [Cede Field]"]** — Mówca: **Player_Romus**
> ""I suggest you keep the field, and keep the deal with Lespia. Rizia is staying out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Axel Reinhart), `[456]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Duke Reinhart frowned."*)

### Węzeł `[184]`
Mówca: **Axel Reinhart**
> ""Thank you for acknowledging that. But it doesn't change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player_Romus: ""Now that Lespia is an ATO member, they won't want to be ..."*)
  - -> `[365]` (*Player_Romus: ""I understand why Pales accepted Lespia's aid. But now th..."*)
  - -> `[366]` (*Player_Romus: ""Let's end the history lecture. What are we doing about t..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Duke Reinhart frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede = true"*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Duke Reinhart frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = tru..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "Duke Reinhart's secretary opened the door. He stood up and gestured for me to do the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Axel Reinhart: ""Until next time, King Romus.""*)

### Węzeł `[188]`
Mówca: **Axel Reinhart**
> ""Until next time, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Axel Reinhart: ""You haven't exactly listened to my government's wishes i..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Axel Reinhart: ""You may not have shown hostility towards Pales, Your Maj..."*)

### Węzeł `[192]`
Mówca: **Axel Reinhart**
> ""You haven't exactly listened to my government's wishes in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Axel Reinhart: ""Sending that ship was our way of asserting Palesian sove..."*)

### Węzeł `[193]`
Mówca: **Axel Reinhart**
> ""You may not have shown hostility towards Pales, Your Majesty, but many in your government have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Axel Reinhart: ""Sending that ship was our way of asserting Palesian sove..."*)

### Węzeł `[194]`
Mówca: **Axel Reinhart**
> ""Sending that ship was our way of asserting Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[646]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[647]` (*Player_Romus: ""Please, Your Grace. Let's not let the bad blood between ..."*)
  - -> `[648]` (*Player_Romus: ""We respect your sovereignty. It doesn't mean you can ste..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope Rico was right about them not cracking under pressure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Titus Gordion: ""They're a stubborn lot. My own men couldn't get a word o..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor bastards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Titus Gordion: ""I wouldn't feel too sorry for them. Even if they weren't..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't care less. I'm sure they're guilty of *something*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Titus Gordion: ""My men did some digging into their backgrounds. Light mi..."*)

### Węzeł `[198]`
Mówca: **Titus Gordion**
> ""They're a stubborn lot. My own men couldn't get a word out of them, and believe me, they tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Titus Gordion: ""Speaking of which, now that our investigation has ended,..."*)

### Węzeł `[199]`
Mówca: **Titus Gordion**
> ""My men did some digging into their backgrounds. Light misdemeanors, mostly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Titus Gordion: ""Speaking of which, now that our investigation has ended,..."*)

### Węzeł `[200]`
Mówca: **Titus Gordion**
> ""I wouldn't feel too sorry for them. Even if they weren't involved in Zille, their record was less than shining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Titus Gordion: ""Speaking of which, now that our investigation has ended,..."*)

### Węzeł `[201]`
Mówca: **Titus Gordion**
> ""We've been making little headway with the Su Omina investigation, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Titus Gordion: ""Your cousin's associates have been less than cooperative..."*)

### Węzeł `[202]`
Mówca: **Titus Gordion**
> ""Speaking of which, now that our investigation has ended, do you plan to return the Golden Guard to its previous size and function?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player_Romus: ""No. The expanded unit might still prove useful.""*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[208]` (*Player_Romus: ""Good point. Yes, that's money I could be putting to bett..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. The expanded unit might still prove useful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Titus Gordion: ""Glad to hear it, sir.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want all your extra manpower concentrated on that *other* investigation I ordered.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[202]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Titus Gordion: ""Right, sir. We'll double down on that one.""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""No. I want all your extra manpower concentrated on that ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. Yes, that's money I could be putting to better use.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)

### Węzeł `[209]`
Mówca: **Titus Gordion**
> ""Right, sir. We'll double down on that one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[210]`
Mówca: **Titus Gordion**
> ""Are you sure, Your Majesty? That would also mean putting an end to the *other* investigation you ordered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""Yes, I'm quite sure.""*)
  - -> `[218]` (*Player_Romus: ""Hmm. All right, let's keep the extra Golden Guards on th..."*)
  - -> `[212]` (*Player_Romus: ""There's too much going on to make this decision. Let's t..."*)

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""Glad to hear it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's too much going on to make this decision. Let's talk later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Titus Gordion), `[216]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Titus nodded."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Titus Gordion: ""Are you sure, Your Majesty? That would also mean putting..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Titus Gordion: ""Are you sure, Your Majesty? You never know when you'll n..."*)

### Węzeł `[216]`
Mówca: **Titus Gordion**
> ""Are you sure, Your Majesty? You never know when you'll need an elite investigation unit at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""Yes, I'm quite sure.""*)
  - -> `[218]` (*Player_Romus: ""Hmm. All right, let's keep the extra Golden Guards on th..."*)
  - -> `[212]` (*Player_Romus: ""There's too much going on to make this decision. Let's t..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm quite sure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Titus Gordion), `[216]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded = false;  Rizi..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. All right, let's keep the extra Golden Guards on the royal payroll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Titus Gordion), `[216]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Titus nodded."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Titus nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded = false; 
RiziaDLC.Situation_Order_KingsGuardForce_Limited = true;
RiziaDLC.Situation_Order_KingsGuardForce_Powerful = false;
RiziaDLC.PoisonInvestigator_Titus = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = false;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Limited"] = true;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Powerful"] = false;
Variable["RiziaDLC.PoisonInvestigator_Titus"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget += 1"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Titus Gordion: ""Very well, Your Majesty. I'll drop the news to the other..."*)

### Węzeł `[222]`
Mówca: **Titus Gordion**
> ""Very well, Your Majesty. I'll drop the news to the other units when we're back in the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "The secretary announced my entrance. I stepped into the r..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "I rejoined Titus in the reception room. We followed Hilda..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Scapegoats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound = true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Scapegoats == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_Pales_SellField = true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_Pales_SellField = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Pales_SellField"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_ArbitrationBegins = true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_ArbitrationBegins = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_ArbitrationBegins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgrou..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackgr..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""Where are you from, Titus?""*)
  - -> `[111]` (*Player_Romus: ""So you've never been to Pales before?""*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I can only imagine how difficult it must be for you to b..."*)
  - -> `[243]` (*Player_Romus: ""There's no doubt in my mind that Pales still falls under..."*)
  - -> `[244]` (*Player_Romus: ""I do hope our two countries can resolve our historical r..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can only imagine how difficult it must be for you to be here, considering this is where your father lost his life.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false` AND `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Titus Gordion), `[81]` (Titus Gordion), `[82]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Titus Gordion: ""The pain never really goes away. I've simply learned to ..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no doubt in my mind that Pales still falls under the Rizian banner. Their hostile attitude toward reunification is nothing short of a crime.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false` AND `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Titus Gordion), `[81]` (Titus Gordion), `[82]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Titus Gordion: ""An injustice I hope to see rectified in my lifetime.""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope our two countries can resolve our historical rivalries. A harmonious partnership could bring significant benefits.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false` AND `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[80]` (Titus Gordion), `[81]` (Titus Gordion), `[82]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Titus Gordion: ""Sure. Though I must admit, I do hope to one day see the ..."*)

### Węzeł `[245]`
Mówca: **Titus Gordion**
> ""The pain never really goes away. I've simply learned to live with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[252]` (*Player_Romus: ""One mustn't let personal feelings get in the way of doin..."*)

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""Sure. Though I must admit, I do hope to one day see the Rizian flag flying over Pales once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[247]`
Mówca: **Titus Gordion**
> ""An injustice I hope to see rectified in my lifetime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Romus: ""As do I. I'm determined to make it happen.""*)
  - -> `[255]` (*Player_Romus: ""You and me both. Though, this matter must be approached ..."*)
  - -> `[268]` (*Player_Romus: ""I believe there are far more pressing issues to deal wit..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""I know the feeling. Not a day goes by where I don't thin..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""I got over my wife's death fairly quickly. Granted, she ..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the feeling. Not a day goes by where I don't think about my late wife.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[245]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Titus Gordion: ""I've never been married myself, but I can only imagine t..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One mustn't let personal feelings get in the way of doing one's duty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Titus Gordion: ""Of course. I never meant to imply that it would.""*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I got over my wife's death fairly quickly. Granted, she and I were never very close.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Titus Gordion: ""Much like a snowflake, grief manifests in countless shap..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As do I. I'm determined to make it happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Titus Gordion: ""I have no doubt, sir.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and me both. Though, this matter must be approached with caution. Setting things in motion takes time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Titus Gordion: ""Agreed. Haste can lead to mistakes.""*)

### Węzeł `[256]`
Mówca: **Titus Gordion**
> ""Of course. I never meant to imply that it would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[257]`
Mówca: **Titus Gordion**
> ""I've never been married myself, but I can only imagine the heartache one must feel from losing someone so close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""I think about my father on a daily basis too, despite my..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""Not a day goes by where I don't think about my own fathe..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think about my father on a daily basis too, despite my best efforts to forget about him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Kontekst wejściowy (poprzednik):** `[245]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Titus Gordion: ""Father-son relationships can be complicated. Everyone's ..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not a day goes by where I don't think about my own father. I try to remind myself that grief makes one stronger.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Titus Gordion: ""An optimistic way to look at life. I admire it.""*)

### Węzeł `[263]`
Mówca: **Titus Gordion**
> ""Father-son relationships can be complicated. Everyone's is different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[264]`
Mówca: **Titus Gordion**
> ""An optimistic way to look at life. I admire it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[265]`
Mówca: **Titus Gordion**
> ""Agreed. Haste can lead to mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[266]`
Mówca: **Titus Gordion**
> ""Much like a snowflake, grief manifests in countless shapes and forms, never identical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[267]`
Mówca: **Titus Gordion**
> ""I have no doubt, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe there are far more pressing issues to deal with than Pales' reunification. It's dangerous when countries try to relive their imperial glory-days.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Titus Gordion: ""While I personally believe the issue is of great importa..."*)

### Węzeł `[269]`
Mówca: **Titus Gordion**
> ""While I personally believe the issue is of great importance, I understand your reasoning to give this matter a lower priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "A panel in the wall slid open, and a secretary clad in a ..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "He maintained eye contact as he bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Axel Reinhart: ""Your Majesty. A pleasure to finally meet you.""*)

### Węzeł `[271]`
Mówca: **Narrator**
> "He maintained eye contact as he bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Axel Reinhart: ""Your Majesty. We meet again.""*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all a misunderstanding, Duke Reinhart. Send your ship back and we can settle this peacefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[273]`
Mówca: **Axel Reinhart**
> ""Now you're interested in peace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Axel Reinhart: ""Now you're interested in peace?""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Axel Reinhart: ""I would like to, Your Majesty.""*)

### Węzeł `[277]`
Mówca: **Axel Reinhart**
> ""I would like to, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Axel Reinhart: ""Unfortunately, there are greater interests at play than ..."*)

### Węzeł `[278]`
Mówca: **Axel Reinhart**
> ""Unfortunately, there are greater interests at play than either of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: ""Then tell me, how can Rizia satisfy those interests?""*)
  - -> `[318]` (*Player_Romus: ""I too have the backing of powerful interests. You do not..."*)
  - -> `[317]` (*Player_Romus: ""That's precisely why I will not let this go. Western sup..."*)
  - -> `[316]` (*Player_Romus: ""So you're admitting it. You're a puppet of Lespia.""*)

### Węzeł `[279]`
Mówca: **Axel Reinhart**
> ""I offered you a chance for peace the last time we met. You turned it down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player_Romus: ""I was under pressure from my father. I did not truly mea..."*)
  - -> `[303]` (*Player_Romus: ""I did not and still do not want to cooperate with Pales ..."*)
  - -> `[304]` (*Player_Romus: ""I do still have doubts about Pales' legitimacy. But this..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're admitting it. You're a puppet of Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "Duke Reinhart drew himself upright."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My own experts would say that you've acted in clear violation of the Alliance of Nations Directive on Offshore Resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Axel Reinhart: ""You are ignoring ANDOR's nuances. It leaves much more ro..."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Duke Reinhart bristled at that remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Axel Reinhart: ""Your Majesty, the Reinhart family has ruled over the Pal..."*)

### Węzeł `[283]`
Mówca: **Axel Reinhart**
> ""Your Majesty, the Reinhart family has ruled over the Palesian peninsula for just as long as the Torases have ruled over Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Axel Reinhart: ""If you are going to question our legitimacy, you may as ..."*)

### Węzeł `[284]`
Mówca: **Axel Reinhart**
> ""If you are going to question our legitimacy, you may as well question your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player_Romus: ""You ruled on behalf of the Valgos Empire, who stole Pale..."*)
  - -> `[289]` (*Player_Romus: ""I respect the length of your family's rule. However, Pal..."*)
  - -> `[290]` (*Player_Romus: ""You are correct. Both of our families have clung to powe..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's precisely why I will not let this go. Western superpowers have no place meddling in South Merkopan affairs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Axel Reinhart: ""I wouldn't call it 'meddling', exactly.""*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I too have the backing of powerful interests. You do not want to incur the wrath of Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Axel Reinhart: ""If I must do so to assert Pales' sovereignty, then I will.""*)

### Węzeł `[287]`
Mówca: **Axel Reinhart**
> ""You are ignoring ANDOR's nuances. It leaves much more room for ambiguity than other laws of its kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "His expression turned more serious."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You ruled on behalf of the Valgos Empire, who stole Pales from Rizia. I would hardly call that 'legitimate'.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Axel Reinhart: ""You are talking about ancient history, Your Majesty.""*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect the length of your family's rule. However, Pales has only been a sovereign nation for a fraction of that time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Axel Reinhart: ""That does not mean our sovereignty is undeserving of res..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are correct. Both of our families have clung to power for too long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Axel Reinhart: ""Yet I don't see you hanging up your crown.""*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our island counts just as much as your barely legitimate country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Axel Reinhart), `[173]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Duke Reinhart bristled at that remark."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't make the rules. Our claim is clearly valid according to the Alliance of Nations Directive on Offshore Resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Axel Reinhart: ""You are ignoring ANDOR's nuances. It leaves much more ro..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Caleqabiz may be small, but it is still a part of the great nation of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Axel Reinhart: ""You chose a convenient time to get patriotic about an is..."*)

### Węzeł `[294]`
Mówca: **Axel Reinhart**
> ""You chose a convenient time to get patriotic about an island full of exiles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "His expression turned more serious."*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was under pressure from my father. I did not truly mean what I said.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Axel Reinhart: ""I wish that I could believe you, Your Majesty.""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_MetAxel == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_MetAxel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Axel Reinhart: ""I offered you a chance for peace the last time we met. Y..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_MetAxel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_MetAxel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Axel Reinhart: ""I offered you a chance for peace three years ago. Instea..."*)

### Węzeł `[299]`
Mówca: **Axel Reinhart**
> ""I offered you a chance for peace three years ago. Instead, you betrayed me to your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""I was under pressure from him then. Now that I am king, ..."*)
  - -> `[303]` (*Player_Romus: ""I did not and still do not want to cooperate with Pales ..."*)
  - -> `[304]` (*Player_Romus: ""I do still have doubts about Pales' legitimacy. But this..."*)

### Węzeł `[300]`
Mówca: **Axel Reinhart**
> ""I'm afraid it may be too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've established that we have differing interpretations of the law. What will it take to come to a compromise?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Axel Reinhart: ""I'm afraid it may be too late for that.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was under pressure from him then. Now that I am king, I am no longer beholden to his wishes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[299]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Axel Reinhart: ""I wish that I could believe you, Your Majesty.""*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not and still do not want to cooperate with Pales after the violence of the 1920s. That doesn't mean I want a repeat of that conflict.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Axel Reinhart), `[299]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Axel Reinhart: ""Neither of us do, Your Majesty.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do still have doubts about Pales' legitimacy. But this resource dispute overrides them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Axel Reinhart), `[299]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Duke Reinhart bristled at that remark."*)

### Węzeł `[305]`
Mówca: **Axel Reinhart**
> ""But until and unless Rizia respects Palesian sovereignty, we will be forced to assert ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: ""Your family only came to power because the Valgos Empire..."*)
  - -> `[312]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[315]` (*Player_Romus: ""Please, Your Grace. Let's not let the hostility between ..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "His expression turned more serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Axel Reinhart: ""Your Majesty, I urge you to let this go. There are more ..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "Duke Reinhart drew himself upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Axel Reinhart: ""And what of Rizia and Rumburg? What of the deal your fat..."*)

### Węzeł `[308]`
Mówca: **Axel Reinhart**
> ""Yes, Pales was part of the Valgos Empire. But we developed our own laws and customs. Even our own language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Axel Reinhart: ""When the Empire fell apart, what were we supposed to do?..."*)

### Węzeł `[309]`
Mówca: **Axel Reinhart**
> ""When the Empire fell apart, what were we supposed to do? Simply give up everything we had built?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Player_Romus: ""I would have done that before turning to Lespia.""*)
  - -> `[328]` (*Player_Romus: ""No. No, I suppose not.""*)
  - -> `[327]` (*Player_Romus: ""Regimes end. It was your time.""*)
  - -> `[326]` (*Player_Romus: ""Pales could have kept its cultural identity intact if it..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Axel Reinhart: ""Yes, Pales was part of the Valgos Empire. But we develop..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Axel Reinhart), `[352]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Axel Reinhart), `[352]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Duke Reinhart drew himself upright."*)

### Węzeł `[313]`
Mówca: **Axel Reinhart**
> ""And what of Rizia and Rumburg? What of the deal your father made with Wehlen to keep House Toras in power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Axel Reinhart: ""You know, Your Majesty, we Reinharts have ruled Pales fo..."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "Duke Reinhart drew himself upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Axel Reinhart: ""And what of Rizia and Rumburg? What of the deal your fat..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Let's not let the hostility between our families color our present relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[305]` (Axel Reinhart), `[352]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "He sighed."*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're admitting it. You're a puppet of Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Duke Reinhart drew himself upright."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's precisely why I will not let this go. Western superpowers have no place meddling in South Merkopan affairs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Axel Reinhart: ""I wouldn't call it 'meddling', necessarily.""*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I too have the backing of powerful interests. You do not want to incur the wrath of Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Axel Reinhart: ""If I must do so to assert Pales' sovereignty, then I will.""*)

### Węzeł `[319]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Axel Reinhart: ""You know, Your Majesty, we Reinharts have ruled Pales fo..."*)

### Węzeł `[320]`
Mówca: **Axel Reinhart**
> ""Neither of us do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Axel Reinhart: ""But until and unless Rizia respects Palesian sovereignty..."*)

### Węzeł `[321]`
Mówca: **Axel Reinhart**
> ""I wish that I could believe you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Axel Reinhart: ""But no Rizian ruler has ever truly respected Palesian so..."*)

### Węzeł `[322]`
Mówca: **Axel Reinhart**
> ""Yet I don't see you hanging up your crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[323]`
Mówca: **Axel Reinhart**
> ""You know, Your Majesty, we Reinharts have ruled Pales for as long as your family has ruled Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Axel Reinhart: ""Yes, Pales was part of the Valgos Empire. But we develop..."*)

### Węzeł `[324]`
Mówca: **Axel Reinhart**
> ""That does not mean our sovereignty is undeserving of respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[325]`
Mówca: **Axel Reinhart**
> ""You are talking about ancient history, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales could have kept its cultural identity intact if it had rejoined Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Axel Reinhart: ""Your father would never have accepted that.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regimes end. It was your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Axel Reinhart: ""That wasn't your kingdom's decision to make.""*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. No, I suppose not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""I heard what it was like back then. Rizia and Morella pi..."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would have done that before turning to Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Axel Reinhart: ""You don't know what you would have done.""*)

### Węzeł `[330]`
Mówca: **Axel Reinhart**
> ""Your father would never have accepted that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)

### Węzeł `[331]`
Mówca: **Axel Reinhart**
> ""That wasn't your kingdom's decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""I heard what it was like back then. Rizia and Morella pi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Axel Reinhart: ""And your own nationalist tendencies make me think you wo..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Axel Reinhart: ""Even if he had, my family never would have agreed. They ..."*)

### Węzeł `[335]`
Mówca: **Axel Reinhart**
> ""And your own nationalist tendencies make me think you wouldn't, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Axel Reinhart: ""Lespia, on the other hand, was more than willing to supp..."*)

### Węzeł `[336]`
Mówca: **Axel Reinhart**
> ""Even if he had, my family never would have agreed. They had too much pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Axel Reinhart: ""So they accepted help from Lespia. The only country will..."*)

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""I heard what it was like back then. Rizia and Morella picking at us like vultures. Goddamn Valgsland trying to provoke a revolution from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Axel Reinhart: ""Lespia was the only nation willing to support our indepe..."*)

### Węzeł `[338]`
Mówca: **Axel Reinhart**
> ""You don't know what you would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""I heard what it was like back then. Rizia and Morella pi..."*)

### Węzeł `[339]`
Mówca: **Axel Reinhart**
> ""Lespia was the only nation willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""They supported your independence... by making you depend..."*)
  - -> `[179]` (*Player_Romus: ""Your family must have realized their motives for doing s..."*)
  - -> `[180]` (*Player_Romus: ""You should never have been put in that position, Your Gr..."*)

### Węzeł `[340]`
Mówca: **Axel Reinhart**
> ""Of course. But what choice did they have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player_Romus: ""Now that Lespia is an ATO member, they won't want to be ..."*)
  - -> `[366]` (*Player_Romus: ""Let's end the history lecture. What are we doing about t..."*)

### Węzeł `[341]`
Mówca: **Axel Reinhart**
> ""You know how wealthy we are. It wasn't entirely a one-way street.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player_Romus: ""Now that Lespia is an ATO member, they won't want to be ..."*)
  - -> `[365]` (*Player_Romus: ""I understand why Pales accepted Lespia's aid. But now th..."*)
  - -> `[366]` (*Player_Romus: ""Let's end the history lecture. What are we doing about t..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sovereignty? Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Axel Reinhart), `[346]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Axel Reinhart), `[346]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Duke Reinhart drew himself upright."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Let's not let the hostility between our families color our present relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Axel Reinhart), `[346]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "He sighed."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "He cast a suspicious glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Axel Reinhart: ""You must understand that Pales doesn't owe Rizia anything.""*)

### Węzeł `[346]`
Mówca: **Axel Reinhart**
> ""If I must do so to assert Pales' sovereignty, then I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[343]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[344]` (*Player_Romus: ""Please, Your Grace. Let's not let the hostility between ..."*)

### Węzeł `[347]`
Mówca: **Axel Reinhart**
> ""I wouldn't call it 'meddling', necessarily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "He sighed."*)

### Węzeł `[348]`
Mówca: **Axel Reinhart**
> ""I wouldn't call it 'meddling', exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then tell me, how can Rizia satisfy those interests?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Axel Reinhart: ""I'm afraid it may be too late for that.""*)

### Węzeł `[350]`
Mówca: **Axel Reinhart**
> ""I'm afraid it may be too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "He sighed."*)

### Węzeł `[351]`
Mówca: **Axel Reinhart**
> ""Lespia, on the other hand, was more than willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""They supported your independence... by making you depend..."*)
  - -> `[179]` (*Player_Romus: ""Your family must have realized their motives for doing s..."*)
  - -> `[180]` (*Player_Romus: ""You should never have been put in that position, Your Gr..."*)

### Węzeł `[352]`
Mówca: **Axel Reinhart**
> ""But no Rizian ruler has ever truly respected Palesian sovereignty. I don't see why you would be different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: ""Your family only came to power because the Valgos Empire..."*)
  - -> `[312]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[315]` (*Player_Romus: ""Please, Your Grace. Let's not let the hostility between ..."*)

### Węzeł `[353]`
Mówca: **Narrator**
> "He leaned forward and lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Axel Reinhart: ""I know that. I'm not a fool.""*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "He leaned forward and lowered his voice."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Axel Reinhart: ""No, they won't. They need our gas.""*)

### Węzeł `[358]`
Mówca: **Axel Reinhart**
> ""No, they won't. They need our gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Axel Reinhart: ""So you see, Your Majesty, we can't let Rizia take it fro..."*)

### Węzeł `[359]`
Mówca: **Axel Reinhart**
> ""I know that. I'm not a fool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Axel Reinhart: ""But in the meantime, Lespia needs our gas. And they are ..."*)

### Węzeł `[360]`
Mówca: **Axel Reinhart**
> ""But in the meantime, Lespia needs our gas. And they are promising us a sum that we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "Rights Purchase Deal"*)

### Węzeł `[361]`
Mówca: **Axel Reinhart**
> ""So they accepted help from Lespia. The only country willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""They supported your independence... by making you depend..."*)
  - -> `[179]` (*Player_Romus: ""Your family must have realized their motives for doing s..."*)
  - -> `[180]` (*Player_Romus: ""You should never have been put in that position, Your Gr..."*)

### Węzeł `[362]`
Mówca: **Axel Reinhart**
> ""Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player_Romus: ""Unless what?""*)
  - -> `[394]` (*Player_Romus: ""I see where this is going.""*)
  - -> `[395]` (*Player_Romus: ""I'm listening...""*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that Lespia is an ATO member, they won't want to be connected to a monarchy for long. They'll have you overthrown the first chance they get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Axel Reinhart), `[340]` (Axel Reinhart), `[341]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[364]`
Mówca: **Axel Reinhart**
> ""So you see, Your Majesty, we can't let Rizia take it from us. Not without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player_Romus: ""My war and security councilor wanted me to deploy our na..."*)
  - -> `[383]` (*Player_Romus: ""Rizia is not looking for a fight. Surely there's still a..."*)
  - -> `[384]` (*Player_Romus: ""Is that a threat, Your Grace?""*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand why Pales accepted Lespia's aid. But now that Morella is in league with Valgsland, you could get caught between superpowers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Axel Reinhart), `[341]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's end the history lecture. What are we doing about this gas field?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Axel Reinhart), `[340]` (Axel Reinhart), `[341]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "He leaned forward and lowered his voice."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Axel Reinhart: ""That's precisely why we need a bargaining chip. And we h..."*)

### Węzeł `[371]`
Mówca: **Axel Reinhart**
> ""That's precisely why we need a bargaining chip. And we have one, right at the bottom of the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Axel Reinhart: ""So you see, Your Majesty, we can't let Rizia take it fro..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "He leaned forward and lowered his voice."*)

### Węzeł `[375]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Axel Reinhart: ""I am bringing this up so you understand the stakes.""*)

### Węzeł `[376]`
Mówca: **Axel Reinhart**
> ""I am bringing this up so you understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Axel Reinhart: ""We have an obligation to Lespia. When they ask us for na..."*)

### Węzeł `[377]`
Mówca: **Axel Reinhart**
> ""We have an obligation to Lespia. When they ask us for natural gas, we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Axel Reinhart: ""And we certainly cannot let Rizia take it from us. Not w..."*)

### Węzeł `[378]`
Mówca: **Axel Reinhart**
> ""And we certainly cannot let Rizia take it from us. Not without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player_Romus: ""My war and security councilor wanted me to deploy our na..."*)
  - -> `[383]` (*Player_Romus: ""Rizia is not looking for a fight. Surely there's still a..."*)
  - -> `[384]` (*Player_Romus: ""Is that a threat, Your Grace?""*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[379]`
Mówca: **Narrator**
> "He leaned forward and lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Axel Reinhart: ""I brought all this up so you would understand the stakes.""*)

### Węzeł `[380]`
Mówca: **Axel Reinhart**
> ""I brought all this up so you would understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Axel Reinhart: ""We have an obligation to Lespia. When they ask us for na..."*)

### Węzeł `[381]`
Mówca: **Axel Reinhart**
> ""We have an obligation to Lespia. When they ask us for natural gas, we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "Rights Purchase Deal"*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war and security councilor wanted me to deploy our navy around the field. I should have listened to her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Axel Reinhart), `[378]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Axel Reinhart: ""Do it if you like. We defeated your country once before.""*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is not looking for a fight. Surely there's still a peaceful solution to be found.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Axel Reinhart), `[378]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Axel Reinhart: ""There is, Your Majesty.""*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a threat, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Axel Reinhart), `[378]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Axel Reinhart: ""Cede the field to Pales and you will not have to find out.""*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Player_Romus: ""Come on, Your Grace. This isn't who you are. Let's just ..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Your Grace. This isn't who you are. Let's just settle this quickly so you can get back to dating celebrities.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[364]` (Axel Reinhart), `[378]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "He exhaled heavily."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "He exhaled heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Axel Reinhart: ""You're right. I can't believe it's come to this. But I d..."*)

### Węzeł `[390]`
Mówca: **Axel Reinhart**
> ""You're right. I can't believe it's come to this. But I don't see another way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "Rights Purchase Deal"*)

### Węzeł `[391]`
Mówca: **Axel Reinhart**
> ""There is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Axel Reinhart: ""You cede the field to Pales and allow us to continue our..."*)

### Węzeł `[392]`
Mówca: **Axel Reinhart**
> ""Do it if you like. We defeated your country once before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Axel Reinhart: ""But the simplest solution is for Rizia to know when to g..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unless what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "He spoke his next words very deliberately."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see where this is going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "He spoke his next words very deliberately."*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm listening...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "He spoke his next words very deliberately."*)

### Węzeł `[396]`
Mówca: **Narrator**
> "He spoke his next words very deliberately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Axel Reinhart: ""I could envision a future where Pales severs its ties wi..."*)

### Węzeł `[397]`
Mówca: **Axel Reinhart**
> ""I could envision a future where Pales severs its ties with Lespia in favor of a partnership with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Axel Reinhart: ""But as my late cousin Ivar learned the hard way on holid..."*)

### Węzeł `[398]`
Mówca: **Axel Reinhart**
> ""But as my late cousin Ivar learned the hard way on holiday in the Montese Isles, one doesn't jump out of a plane without a parachute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Axel Reinhart: ""Do you understand what I'm saying, Your Majesty?""*)

### Węzeł `[399]`
Mówca: **Narrator**
> "Duke Reinhart grabbed the nearest piece of paper and scribbled a number on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Axel Reinhart: ""This would buy you the full exploration rights to the Au..."*)

### Węzeł `[400]`
Mówca: **Axel Reinhart**
> ""This would buy you the full exploration rights to the Aureus field, as we were preparing to grant Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Axel Reinhart: ""Cede the field to us and pay what we're asking, and Rizi..."*)

### Węzeł `[401]`
Mówca: **Axel Reinhart**
> ""Cede the field to us and pay what we're asking, and Rizia will have all the energy it could ever ask for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "I took a look at the numbers he'd written down."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "I took a look at the numbers he'd written down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]` (*Narrator: "An upfront fee, an annual extraction rights payment, and ..."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "It was an extremely large sum, but our treasury could afford it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[934]` (*Player_Romus: ""Seems reasonable to me. You have a deal, Duke Reinhart."..."*)
  - -> `[408]` (*Player_Romus: ""That's far too much. Can't you go any lower?""*)
  - -> `[436]` (*Player_Romus: ""Can't I just buy the rights to part of the field?""*)
  - -> `[437]` (*Player_Romus: ""On second thought, this is insulting. My kingdom will no..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 8"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 8)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "It was an extremely large sum, but our treasury could aff..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]` (*Narrator: "It was an extremely large sum, more than our treasury cou..."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "It was more than our treasury could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""On second thought, this is insulting. My kingdom will no..."*)
  - -> `[434]` (*Player_Romus: ""Sorry, but there's no way Rizia can pay this much.""*)
  - -> `[439]` (*Player_Romus: ""Can't I just buy the rights to part of the field?""*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's far too much. Can't you go any lower?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator), `[930]` (Narrator), `[932]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "He rubbed his chin."*)

### Węzeł `[409]`
Mówca: **Axel Reinhart**
> ""Do you understand what I'm saying, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: ""I'm sorry about your cousin.""*)
  - -> `[412]` (*Player_Romus: ""I don't. Please explain.""*)
  - -> `[413]` (*Player_Romus: ""I think so, but I don't like it.""*)
  - -> `[414]` (*Player_Romus: ""I do. How big of a parachute are we talking about?""*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about your cousin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Axel Reinhart: ""Cocaine and skydiving don't mix.""*)

### Węzeł `[411]`
Mówca: **Axel Reinhart**
> ""Cocaine and skydiving don't mix.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Axel Reinhart: ""Anyway...""*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't. Please explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "He briefly closed his eyes."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think so, but I don't like it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Axel Reinhart: ""Sorry, but this is the best compromise I can offer.""*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do. How big of a parachute are we talking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Narrator: "He blinked in surprise."*)

### Węzeł `[415]`
Mówca: **Axel Reinhart**
> ""Lespia's energy company LesPower has put in a bid for the exploration rights to the Aureus field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Axel Reinhart: ""Cede the field to us and agree to match their offer, and..."*)

### Węzeł `[416]`
Mówca: **Axel Reinhart**
> ""Sorry, but this is the best compromise I can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Axel Reinhart: ""Lespia's energy company LesPower has put in a bid for th..."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "He briefly closed his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Axel Reinhart: ""Lespia's energy company LesPower has put in a bid for th..."*)

### Węzeł `[418]`
Mówca: **Axel Reinhart**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Axel Reinhart: ""Lespia's energy company LesPower has put in a bid for th..."*)

### Węzeł `[419]`
Mówca: **Axel Reinhart**
> ""Cede the field to us and agree to match their offer, and I will sell the rights to Rizia instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""How do I know you won't just turn around and sell the fi..."*)
  - -> `[421]` (*Player_Romus: ""That's ridiculous. We shouldn't have to pay for what's r..."*)
  - -> `[425]` (*Player_Romus: ""That depends. How much is Lespia offering?""*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do I know you won't just turn around and sell the field to Lespia once we cede it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Axel Reinhart: ""We're both men of honor, Your Majesty. You'll have to tr..."*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. We shouldn't have to pay for what's rightfully ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Axel Reinhart: ""I am generously offering you what's rightfully *ours*.""*)

### Węzeł `[422]`
Mówca: **Axel Reinhart**
> ""We're both men of honor, Your Majesty. You'll have to trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Axel Reinhart: ""I hope you see how beneficial this could be to both of o..."*)

### Węzeł `[423]`
Mówca: **Axel Reinhart**
> ""I am generously offering you what's rightfully *ours*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Axel Reinhart: ""I hope you see how beneficial this could be to both of o..."*)

### Węzeł `[424]`
Mówca: **Axel Reinhart**
> ""I hope you see how beneficial this could be to both of our countries. We end our dependence on Lespia, Rizia gets all the energy it could wish for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player_Romus: ""Sorry, but I must refuse. We have a legitimate claim to ..."*)
  - -> `[431]` (*Player_Romus: ""You can have the field if you need it so badly. But I wi..."*)
  - -> `[433]` (*Player_Romus: ""Okay. Just out of curiosity, tell me how much we would h..."*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That depends. How much is Lespia offering?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Axel Reinhart: ""Now we're talking.""*)

### Węzeł `[426]`
Mówca: **Axel Reinhart**
> ""Now we're talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Axel Reinhart: ""It was always my family's policy not to discuss money ou..."*)

### Węzeł `[427]`
Mówca: **Axel Reinhart**
> ""I didn't think you'd come to the table so quickly. But great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Axel Reinhart: ""It was always my family's policy not to discuss money ou..."*)

### Węzeł `[428]`
Mówca: **Axel Reinhart**
> ""It was always my family's policy not to discuss money out loud, so...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "Duke Reinhart grabbed the nearest piece of paper and scri..."*)

### Węzeł `[429]`
Mówca: **Axel Reinhart**
> ""It was always my family's policy not to discuss money out loud, so...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Narrator: "Duke Reinhart grabbed the nearest piece of paper and scri..."*)

### Węzeł `[430]`
Mówca: **Narrator**
> "Duke Reinhart grabbed the nearest piece of paper and scribbled a numbers on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]` (*Narrator: "An upfront fee, an annual extraction rights payment, and ..."*)

### Węzeł `[431]`
**[WYBÓR GRACZA: ""You can have the field if you need it so badly. But I will not pay for the gas." [Cede Field]"]** — Mówca: **Player_Romus**
> ""You can have the field if you need it so badly. But I will not pay for the gas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "Duke Reinhart frowned."*)

### Węzeł `[432]`
**[WYBÓR GRACZA: ""Sorry, but I must refuse. We have a legitimate claim to that gas field, and I am willing to defend it in court if necessary." [AN Arbitration]"]** — Mówca: **Player_Romus**
> ""Sorry, but I must refuse. We have a legitimate claim to that gas field, and I am willing to defend it in court if necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Axel Reinhart: ""Then court it is, Your Majesty.""*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Just out of curiosity, tell me how much we would have to pay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Axel Reinhart: ""It was always my family's policy not to discuss money ou..."*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but there's no way Rizia can pay this much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Narrator), `[917]` (Narrator), `[931]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "He rubbed his chin."*)

### Węzeł `[435]`
**[WYBÓR GRACZA: ""Seems reasonable to me. You have a deal, Duke Reinhart." [-6 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Seems reasonable to me. You have a deal, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[932]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[945]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 6; RiziaDLC.Budget_Modifier_..."*)

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't I just buy the rights to part of the field?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator), `[930]` (Narrator), `[932]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Axel Reinhart: ""This is an all-or-nothing deal, I'm afraid.""*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, this is insulting. My kingdom will not pay for our own gas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator), `[407]` (Narrator), `[917]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Narrator: "Duke Reinhart crumpled up the piece of paper and casually..."*)

### Węzeł `[438]`
Mówca: **Axel Reinhart**
> ""Then court it is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Duke Reinhart frowned."*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't I just buy the rights to part of the field?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Narrator), `[917]` (Narrator), `[931]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Axel Reinhart: ""This is an all-or-nothing deal, I'm afraid.""*)

### Węzeł `[440]`
Mówca: **Narrator**
> "Duke Reinhart crumpled up the piece of paper and casually tossed it away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Axel Reinhart: ""That was my best suggestion.""*)

### Węzeł `[441]`
Mówca: **Axel Reinhart**
> ""That was my best suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Axel Reinhart: ""What would you prefer as a solution, Your Majesty?""*)

### Węzeł `[442]`
Mówca: **Axel Reinhart**
> ""What would you prefer as a solution, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""I see no other choice but arbitration. The Alliance of N..."*)
  - -> `[183]` (*Player_Romus: ""I suggest you keep the field, and keep the deal with Les..."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "Duke Reinhart frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Axel Reinhart: ""Well... if you're sure.""*)

### Węzeł `[444]`
Mówca: **Axel Reinhart**
> ""Well... if you're sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede = true"*)

### Węzeł `[445]`
Mówca: **Axel Reinhart**
> ""If there's truly no other choice, then I will gladly agree to enter arbitration. But it's not quite the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false"*)
  - -> `[477]` (*Player_Romus: ""Nor I. But with the help of a third party, I'm sure we'l..."*)
  - -> `[479]` (*Player_Romus: ""That's what you get for trying to sniff around for the b..."*)

### Węzeł `[446]`
Mówca: **Axel Reinhart**
> ""Thank you, I guess. But it's not quite the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Prime Minister Alvarez will be interested in hearing how..."*)
  - -> `[483]` (*Player_Romus: ""Nor I. But I'm willing to let the field go to keep the p..."*)
  - -> `[485]` (*Player_Romus: ""Then you shouldn't have tried to play Lespia and Rizia o..."*)
  - -> `[516]` (*Player_Romus: ""This doesn't preclude the possibility of cooperation in ..."*)

### Węzeł `[447]`
Mówca: **Axel Reinhart**
> ""I approached you because I believed Rizia was flourishing economically. Was I wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""Sorry to disappoint you.""*)
  - -> `[450]` (*Player_Romus: ""Rizia's economy is as robust as it's ever been. But we w..."*)
  - -> `[451]` (*Player_Romus: ""Our resources have shrunk in the past years. That's why ..."*)
  - -> `[951]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Di..."*)

### Węzeł `[448]`
Mówca: **Narrator**
> "He rubbed his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Axel Reinhart: ""I approached you because I believed Rizia was flourishin..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry to disappoint you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[453]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Axel Reinhart: ""Then... what do you suggest, Your Majesty?""*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's economy is as robust as it's ever been. But we will not pay so much to a country that has done us so much harm in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[453]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Axel Reinhart: ""Harm? If I recall correctly, *you* invaded *us."""*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our resources have shrunk in the past years. That's why we need that gas field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[453]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Axel Reinhart: ""However badly you need it, we need it more.""*)

### Węzeł `[452]`
Mówca: **Axel Reinhart**
> ""This is an all-or-nothing deal, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Axel Reinhart: ""Frankly, I thought Rizia could easily afford it.""*)

### Węzeł `[453]`
Mówca: **Axel Reinhart**
> ""Frankly, I thought Rizia could easily afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""Sorry to disappoint you.""*)
  - -> `[450]` (*Player_Romus: ""Rizia's economy is as robust as it's ever been. But we w..."*)
  - -> `[451]` (*Player_Romus: ""Our resources have shrunk in the past years. That's why ..."*)
  - -> `[951]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Di..."*)

### Węzeł `[454]`
Mówca: **Axel Reinhart**
> ""Harm? If I recall correctly, *you* invaded *us."""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Axel Reinhart: ""Unfortunately, if you can't purchase the rights to the e..."*)

### Węzeł `[455]`
Mówca: **Axel Reinhart**
> ""Unfortunately, if you can't purchase the rights to the entire field for the price I am asking, we will be forced to honor our original deal with Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Dip..."*)
  - -> `[461]` (*Player_Romus: ""Stick with Lespia, then. You can keep the field, but we'..."*)
  - -> `[462]` (*Player_Romus: ""Then we will have to enter the arbitration process. I'll..."*)

### Węzeł `[456]`
Mówca: **Axel Reinhart**
> ""Then... what do you suggest, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""I see no other choice but arbitration. The Alliance of N..."*)
  - -> `[183]` (*Player_Romus: ""I suggest you keep the field, and keep the deal with Les..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Dip..."*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_D..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Player_Romus: ""Very well, Your Grace. You have a deal." [-10 Budget Now..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[935]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Dipl..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA: ""Very well, Your Grace. You have a deal." [-10 Budget Now, -2 Budget Per Turn Now, -5 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. You have a deal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Kontekst wejściowy (poprzednik):** `[455]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[947]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 10; RiziaDLC.Budget_Modifier..."*)

### Węzeł `[461]`
**[WYBÓR GRACZA: ""Stick with Lespia, then. You can keep the field, but we're not paying for it." [Cede Field]"]** — Mówca: **Player_Romus**
> ""Stick with Lespia, then. You can keep the field, but we're not paying for it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[455]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Duke Reinhart frowned."*)

### Węzeł `[462]`
**[WYBÓR GRACZA: ""Then we will have to enter the arbitration process. I'll see you in court, Duke Reinhart." [Arbitration]"]** — Mówca: **Player_Romus**
> ""Then we will have to enter the arbitration process. I'll see you in court, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[455]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Duke Reinhart frowned."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy = true;
RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = false;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = true;
RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights = true;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = true;
Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = false;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights"] = true;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Pales", "Progres..."*)

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "A boyish smile spread across his face."*)

### Węzeł `[465]`
Mówca: **Narrator**
> "A boyish smile spread across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Axel Reinhart: ""Perfect, Your Majesty. Now, if only finding a wife was t..."*)

### Węzeł `[466]`
Mówca: **Axel Reinhart**
> ""Perfect, Your Majesty. Now, if only finding a wife was this easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""Well, I have a daughter...""*)
  - -> `[468]` (*Player_Romus: ""A young playboy like you needn't settle down yet.""*)
  - -> `[469]` (*Player_Romus: ""I look forward to a fruitful energy partnership.""*)
  - -> `[489]` (*Player_Romus: ""Fine, fine, I'll marry you. Just don't tell our Grand Wi..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I have a daughter...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "His lip twitched."*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A young playboy like you needn't settle down yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Axel Reinhart: ""My people demand a queen. You know how it is.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to a fruitful energy partnership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Axel Reinhart: ""As do I.""*)

### Węzeł `[470]`
Mówca: **Axel Reinhart**
> ""My people demand a queen. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The Duke reached beneath the table and pressed an interco..."*)

### Węzeł `[471]`
Mówca: **Axel Reinhart**
> ""And she's a beauty. But let's see how this gas deal goes before we get any closer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The Duke reached beneath the table and pressed an interco..."*)

### Węzeł `[472]`
Mówca: **Axel Reinhart**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The Duke reached beneath the table and pressed an interco..."*)

### Węzeł `[473]`
Mówca: **Narrator**
> "His lip twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Axel Reinhart: ""And she's a beauty. But let's see how this gas deal goes..."*)

### Węzeł `[474]`
**[WYBÓR GRACZA: ""As a matter of fact, I'm sending naval reinforcements to prevent Pales from further invading the field during the arbitration process." [Send Navy, +1 Authority]"]** — Mówca: **Player_Romus**
> ""As a matter of fact, I'm sending naval reinforcements to prevent Pales from further breaching the field's borders during the arbitration process.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false`
- **Kontekst wejściowy (poprzednik):** `[445]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; ..."*)

### Węzeł `[475]`
Mówca: **Narrator**
> "His nostrils flared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Axel Reinhart: ""That's *really* not the outcome I was hoping for.""*)

### Węzeł `[476]`
Mówca: **Axel Reinhart**
> ""That's *really* not the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Player_Romus: ""My war councilor suggested it as soon as your ship launc..."*)
  - -> `[492]` (*Player_Romus: ""Sorry. But your willingness to double-cross Lespia shows..."*)
  - -> `[526]` (*Player_Romus: ""I'm only taking precautions.""*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor I. But with the help of a third party, I'm sure we'll be able to come to a compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[445]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Axel Reinhart: ""A fast one, I hope. Lespia has its eyes on us.""*)

### Węzeł `[478]`
Mówca: **Axel Reinhart**
> ""A fast one, I hope. Lespia has its eyes on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "End Peaceful Arbitration"*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's what you get for trying to sniff around for the best deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[445]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Axel Reinhart: ""This will work out worse for you in the end. I know that..."*)

### Węzeł `[480]`
Mówca: **Axel Reinhart**
> ""This will work out worse for you in the end. I know that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "End Peaceful Arbitration"*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Alvarez will be interested in hearing how close you came to betraying him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Axel Reinhart: ""What?! You wouldn't.""*)

### Węzeł `[482]`
Mówca: **Axel Reinhart**
> ""What?! You wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Player_Romus: ""You're not the only one who can play games.""*)
  - -> `[503]` (*Player_Romus: ""Just wait and see.""*)
  - -> `[506]` (*Player_Romus: ""No, I wouldn't. But it was fun to watch your face as I s..."*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor I. But I'm willing to let the field go to keep the peace between our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Axel Reinhart: ""Peace, yes.""*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Axel Reinhart: ""Thank you, I guess. But it's not quite the outcome I was..."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you shouldn't have tried to play Lespia and Rizia off each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Axel Reinhart: ""That's not what -- Never mind.""*)

### Węzeł `[486]`
Mówca: **Axel Reinhart**
> ""Peace, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Axel Reinhart: ""I truly hope we can maintain peace with a fleet of Lespi..."*)

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war councilor suggested it as soon as your ship launched. I should have listened to her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Axel Reinhart: ""She's an Azaro, isn't she? This meeting was doomed from ..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1; RiziaDLC..."*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, fine, I'll marry you. Just don't tell our Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[490]`
Mówca: **Axel Reinhart**
> ""Funny. But you're not exactly my type.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The Duke reached beneath the table and pressed an interco..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Axel Reinhart: ""Funny. But you're not exactly my type.""*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. But your willingness to double-cross Lespia shows you cannot be trusted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Axel Reinhart: ""It was an attempt at reconciliation. A futile one.""*)

### Węzeł `[493]`
Mówca: **Narrator**
> "He reached under his desk and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Axel Reinhart: ""Hilda? Be a doll and help show His Majesty the way out o..."*)

### Węzeł `[494]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Narrator: "He sat back in his chair and scrutinized me closely."*)

### Węzeł `[495]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Axel Reinhart: ""I should warn you that you're going to lose. Badly.""*)

### Węzeł `[496]`
Mówca: **Axel Reinhart**
> ""I should warn you that you're going to lose. Badly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Player_Romus: ""Win or lose, I will not simply capitulate to Pales.""*)
  - -> `[498]` (*Player_Romus: ""A shame we were unable to settle this like gentlemen, Yo..."*)
  - -> `[499]` (*Player_Romus: ""You're bluffing.""*)
  - -> `[512]` (*Player_Romus: ""That's an unbefitting attitude. All I want is to keep th..."*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Win or lose, I will not simply capitulate to Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[496]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Axel Reinhart: ""Nor I to Rizia.""*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A shame we were unable to settle this like gentlemen, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[496]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Axel Reinhart: ""Let the record show that we tried.""*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're bluffing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[496]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Axel Reinhart: ""Am I? You'll find out.""*)

### Węzeł `[500]`
Mówca: **Narrator**
> "He blinked in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Axel Reinhart: ""I didn't think you'd come to the table so quickly. But g..."*)

### Węzeł `[501]`
Mówca: **Axel Reinhart**
> ""However badly you need it, we need it more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Axel Reinhart: ""Unfortunately, if you can't purchase the rights to the e..."*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not the only one who can play games.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "Reinhart scowled. He reached under his table and pressed ..."*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just wait and see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "Reinhart scowled. He reached under his table and pressed ..."*)

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""That's not what -- Never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[505]`
Mówca: **Axel Reinhart**
> ""I truly hope we can maintain peace with a fleet of Lespian drillships between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I wouldn't. But it was fun to watch your face as I said that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "Reinhart scowled. He reached under his table and pressed ..."*)

### Węzeł `[507]`
Mówca: **Narrator**
> "Reinhart scowled. He reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "End Cede Field"*)

### Węzeł `[508]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "He turned back to me."*)

### Węzeł `[509]`
Mówca: **Axel Reinhart**
> ""Let the record show that we tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[510]`
Mówca: **Axel Reinhart**
> ""Nor I to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[511]`
Mówca: **Axel Reinhart**
> ""Am I? You'll find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an unbefitting attitude. All I want is to keep the peace between our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[496]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Axel Reinhart: ""I want that as well. But I'm just stating the facts.""*)

### Węzeł `[513]`
Mówca: **Axel Reinhart**
> ""I want that as well. But I'm just stating the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[514]`
Mówca: **Narrator**
> "Reinhart reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "End Cede Field"*)

### Węzeł `[515]`
Mówca: **Axel Reinhart**
> ""We'll send over an official concession form for you to sign. In the meantime, you won't object if our ship stays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Player_Romus: ""Of course not. It's your field.""*)
  - -> `[520]` (*Player_Romus: ""Just remember that it is only staying due to our largesse.""*)
  - -> `[521]` (*Player_Romus: ""We'll meet again, Duke Reinhart.""*)

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This doesn't preclude the possibility of cooperation in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Axel Reinhart: ""Cooperation will be a lot harder with a fleet of Lespian..."*)

### Węzeł `[517]`
Mówca: **Axel Reinhart**
> ""Cooperation will be a lot harder with a fleet of Lespian drillships between us. But we'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[518]`
Mówca: **Narrator**
> "He turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Axel Reinhart: ""We'll send over an official concession form for you to s..."*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. It's your field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Axel Reinhart: ""Thank you.""*)

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just remember that it is only staying due to our largesse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Axel Reinhart: ""Yes, thank you, Your Majesty.""*)

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll meet again, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Axel Reinhart: ""I am sure that we will. We're neighbors, aren't we?""*)

### Węzeł `[522]`
Mówca: **Axel Reinhart**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[523]`
Mówca: **Axel Reinhart**
> ""Yes, thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""I am sure that we will. We're neighbors, aren't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; 
RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.Resources_Authority += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2; RiziaDLC...."*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm only taking precautions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Axel Reinhart: ""Then so will we.""*)

### Węzeł `[527]`
Mówca: **Axel Reinhart**
> ""She's an Azaro, isn't she? This meeting was doomed from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "End Violent Arbitration"*)

### Węzeł `[528]`
Mówca: **Axel Reinhart**
> ""It was an attempt at reconciliation. A futile one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "End Violent Arbitration"*)

### Węzeł `[529]`
Mówca: **Axel Reinhart**
> ""Then so will we.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "End Violent Arbitration"*)

### Węzeł `[530]`
Mówca: **Axel Reinhart**
> ""I hope you understand that if your navy enters the field before the AN has decided its ownership, I will be obligated to send our own fleet to join yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Player_Romus: ""Yes. I look forward to it, in fact.""*)
  - -> `[532]` (*Player_Romus: ""Don't do anything too rash. Nobody wants escalation.""*)
  - -> `[533]` (*Player_Romus: ""Halaita. If it is said, so it is, so it will be.""*)

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I look forward to it, in fact.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[530]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't do anything too rash. Nobody wants escalation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[530]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Axel Reinhart: ""Ha. Unbelievable.""*)

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is, so it will be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[530]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1; RiziaDLC.Said_Hala..."*)

### Węzeł `[534]`
Mówca: **Narrator**
> "He reached under his desk and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Axel Reinhart: ""Hilda? Be a doll and help show His Majesty the way out o..."*)

### Węzeł `[535]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "He sat back in his chair and scrutinized me closely."*)

### Węzeł `[536]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Axel Reinhart: ""I hope you understand that if your navy enters the field..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1;
RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;
Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Axel Reinhart: ""Sure.""*)

### Węzeł `[538]`
Mówca: **Axel Reinhart**
> ""Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[539]`
Mówca: **Axel Reinhart**
> ""Ha. Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[540]`
Mówca: **Axel Reinhart**
> ""You cede the field to Pales and allow us to continue our exploratory drilling without objection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Axel Reinhart: ""Or...""*)

### Węzeł `[541]`
Mówca: **Axel Reinhart**
> ""Or...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Player_Romus: ""Yes?""*)
  - -> `[545]` (*Player_Romus: ""I knew there was a more reasonable option.""*)
  - -> `[546]` (*Player_Romus: ""I can't marry you, Your Grace. It's illegal in my country.""*)

### Węzeł `[542]`
Mówca: **Axel Reinhart**
> ""But the simplest solution is for Rizia to know when to give up. Cede the field to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Axel Reinhart: ""Or...""*)

### Węzeł `[543]`
Mówca: **Axel Reinhart**
> ""Cede the field to Pales and you will not have to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Axel Reinhart: ""Or...""*)

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Axel Reinhart: ""The only other way out I see is allowing the Alliance of..."*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew there was a more reasonable option.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Axel Reinhart: ""The only other way out I see is allowing the Alliance of..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't marry you, Your Grace. It's illegal in my country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Narrator: "He looked at me strangely."*)

### Węzeł `[548]`
Mówca: **Narrator**
> "He looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Axel Reinhart: ""I hope that was a joke.""*)

### Węzeł `[549]`
Mówca: **Axel Reinhart**
> ""I hope that was a joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Axel Reinhart: ""The only other way out I see is allowing the Alliance of..."*)

### Węzeł `[550]`
Mówca: **Axel Reinhart**
> ""The only other way out I see is allowing the Alliance of Nations to decide the field's ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Axel Reinhart: ""But the arbitration process could take years, as I'm sur..."*)

### Węzeł `[551]`
Mówca: **Axel Reinhart**
> ""But the arbitration process could take years, as I'm sure you have been warned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Player_Romus: ""Are you sure there's absolutely nothing else you would a..."*)
  - -> `[553]` (*Player_Romus: ""We are willing to wait however long we have to for justi..."*)
  - -> `[554]` (*Player_Romus: ""If I cede the field to Pales, what will you give Rizia i..."*)

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure there's absolutely nothing else you would accept?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "He shook his head."*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are willing to wait however long we have to for justice to be served.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Axel Reinhart: ""Are you sure about that, Your Majesty?""*)

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I cede the field to Pales, what will you give Rizia in return?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Axel Reinhart: ""The chance to avoid a lengthy, costly court process that..."*)

### Węzeł `[555]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Axel Reinhart: ""I reached out to you after my coronation because I was i..."*)

### Węzeł `[556]`
Mówca: **Axel Reinhart**
> ""I reached out to you after my coronation because I was interested in Rizia as an alternative economic partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Axel Reinhart: ""But you made it very clear that Rizia did not reciprocat..."*)

### Węzeł `[557]`
Mówca: **Axel Reinhart**
> ""But you made it very clear that Rizia did not reciprocate that interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Player_Romus: ""Please, Your Grace. Give my kingdom a chance and we will..."*)
  - -> `[581]` (*Player_Romus: ""Just be reasonable. You are letting past grudges get in ..."*)
  - -> `[582]` (*Player_Romus: ""Could you blame me? We lost many good men fighting your ..."*)

### Węzeł `[558]`
Mówca: **Axel Reinhart**
> ""Are you sure about that, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Axel Reinhart: ""I know your kingdom has been having difficulties with We..."*)

### Węzeł `[559]`
Mówca: **Axel Reinhart**
> ""The chance to avoid a lengthy, costly court process that you will inevitably lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Axel Reinhart: ""We don't have much to give, I'm afraid. But maybe Lespia..."*)

### Węzeł `[560]`
Mówca: **Axel Reinhart**
> ""We don't have much to give, I'm afraid. But maybe Lespia will sell you part of their rights once they've been awarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Player_Romus: ""Not much of a consolation prize.""*)
  - -> `[563]` (*Player_Romus: ""What makes you think Rizia will lose?""*)
  - -> `[564]` (*Player_Romus: ""What about a chance for lasting peace between our two na..."*)

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not much of a consolation prize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Axel Reinhart: ""Sorry. I can't think of anything else under the circumst..."*)

### Węzeł `[562]`
Mówca: **Axel Reinhart**
> ""I know your kingdom has been having difficulties with Wehlen. Can you afford to get caught up in multiple disputes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Player_Romus: ""The Zille bombing was a tragedy. But our relations with ..."*)
  - -> `[579]` (*Player_Romus: ""Who do you think we are? The kingdom of Rizia can afford..."*)
  - -> `[589]` (*Player_Romus: ""I must admit that our difficulties with Wehlen have only..."*)

### Węzeł `[563]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think Rizia will lose?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Axel Reinhart: ""We have the backing of Lespia, which has the backing of ..."*)

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about a chance for lasting peace between our two nations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Axel Reinhart: ""You made it clear that Rizia did not want peace.""*)

### Węzeł `[565]`
Mówca: **Axel Reinhart**
> ""You made it clear that Rizia did not want peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Axel Reinhart: ""But if you've changed your mind, ceding the field to us ..."*)

### Węzeł `[566]`
Mówca: **Axel Reinhart**
> ""But if you've changed your mind, ceding the field to us would certainly help ease tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Player_Romus: ""I'd like to save us both the hassle. But I am under as m..."*)
  - -> `[571]` (*Player_Romus: ""I do want peace. But your attitude is making it difficult.""*)

### Węzeł `[567]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Axel Reinhart: ""But if you'd like to test that theory, be my guest.""*)

### Węzeł `[568]`
Mówca: **Axel Reinhart**
> ""But if you'd like to test that theory, be my guest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Player_Romus: ""I'd like to save us both the hassle. But I am under as m..."*)
  - -> `[595]` (*Player_Romus: ""I still don't believe that the international community w..."*)

### Węzeł `[569]`
Mówca: **Axel Reinhart**
> ""Sorry. I can't think of anything else under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Axel Reinhart: ""But even a small percentage of the Aureus field would be..."*)

### Węzeł `[570]`
Mówca: **Axel Reinhart**
> ""But even a small percentage of the Aureus field would be a considerable amount of energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Player_Romus: ""Considerable for Pales, perhaps. Rizia's energy needs ar..."*)
  - -> `[617]` (*Player_Romus: ""I'd like to save us both the hassle. But I am under as m..."*)
  - -> `[595]` (*Player_Romus: ""I still don't believe that the international community w..."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do want peace. But your attitude is making it difficult.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[566]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Axel Reinhart: ""Then let's end this conversation. Tell me what you want ..."*)

### Węzeł `[572]`
Mówca: **Axel Reinhart**
> ""If I must do so to assert Pales' sovereignty, then I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Player_Romus: ""What sovereignty? Your family only came to power because..."*)
  - -> `[574]` (*Player_Romus: ""Your 'sovereignty' only exists because of Lespian suppor..."*)
  - -> `[575]` (*Player_Romus: ""We respect Palesian sovereignty. All we are asking for i..."*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sovereignty? Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[572]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "He sighed."*)

### Węzeł `[574]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[572]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Axel Reinhart: ""What of Rizia and Rumburg, then?""*)

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We respect Palesian sovereignty. All we are asking for is the right to our own gas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[572]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Axel Reinhart: ""I don't know if I can believe you.""*)

### Węzeł `[576]`
Mówca: **Axel Reinhart**
> ""What of Rizia and Rumburg, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Axel Reinhart: ""You know, Your Majesty, we Reinharts have ruled Pales fo..."*)

### Węzeł `[577]`
Mówca: **Axel Reinhart**
> ""I don't know if I can believe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "He sighed."*)

### Węzeł `[578]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Zille bombing was a tragedy. But our relations with Wehlen are as strong as they've ever been.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Axel Reinhart: ""I was mistaken, then.""*)

### Węzeł `[579]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who do you think we are? The kingdom of Rizia can afford as many disputes as we like.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Axel Reinhart: ""Forgive my impertinence, then.""*)

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Give my kingdom a chance and we will prove ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Axel Reinhart: ""I'm afraid it's too late.""*)

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just be reasonable. You are letting past grudges get in the way of a constructive solution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Axel Reinhart: ""We are not talking about past grudges. We are talking ab..."*)

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could you blame me? We lost many good men fighting your country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Axel Reinhart: ""Invading my country, you mean.""*)

### Węzeł `[583]`
Mówca: **Axel Reinhart**
> ""Invading my country, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Axel Reinhart: ""No, this conversation is over. Pales will only recognize..."*)

### Węzeł `[584]`
Mówca: **Axel Reinhart**
> ""I'm afraid it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rights Purchase Deal]"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Rights Purchase Deal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Axel Reinhart: ""Unless...""*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rights Purchase Deal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "Rights Purchase Deal"*)

### Węzeł `[587]`
Mówca: **Axel Reinhart**
> ""We are not talking about past grudges. We are talking about your current attitude towards my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Axel Reinhart: ""This conversation is over.""*)

### Węzeł `[588]`
Mówca: **Axel Reinhart**
> ""This conversation is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rights Purchase Deal]"*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit that our difficulties with Wehlen have only made our need for natural gas greater.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Axel Reinhart: ""I understand. But Pales cannot back down. Lespia has off..."*)

### Węzeł `[590]`
Mówca: **Axel Reinhart**
> ""I understand. But Pales cannot back down. Lespia has offered a sum that we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rights Purchase Deal]"*)

### Węzeł `[591]`
Mówca: **Axel Reinhart**
> ""Forgive my impertinence, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Axel Reinhart: ""But I am not backing down. Pales will only recognize Riz..."*)

### Węzeł `[592]`
Mówca: **Axel Reinhart**
> ""No, this conversation is over. Pales will only recognize Rizia's claim to the gas field if we are forced to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Player_Romus: ""Then I see no choice but to get the AN involved. We have..."*)
  - -> `[597]` (*Player_Romus: ""My country is not as desperate as yours. Keep the field ..."*)

### Węzeł `[593]`
Mówca: **Axel Reinhart**
> ""I was mistaken, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Axel Reinhart: ""But I am not backing down. Pales will only recognize Riz..."*)

### Węzeł `[594]`
Mówca: **Axel Reinhart**
> ""But I am not backing down. Pales will only recognize Rizia's claim to the gas field if we are forced to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Player_Romus: ""Then I see no choice but to get the AN involved. We have..."*)
  - -> `[597]` (*Player_Romus: ""My country is not as desperate as yours. Keep the field ..."*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't believe that the international community will rally around your insignificant little peninsula.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[568]` (Axel Reinhart), `[570]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Axel Reinhart: ""Enough insults, Your Majesty. Tell me what you want to do.""*)

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I see no choice but to get the AN involved. We have to enter arbitration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[592]` (Axel Reinhart), `[594]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Narrator: "Duke Reinhart nodded."*)

### Węzeł `[597]`
**[WYBÓR GRACZA: ""My country is not as desperate as yours. Keep the field if you like." [Cede Field]"]** — Mówca: **Player_Romus**
> ""My country is not as desperate as yours. Keep the field if you like.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[592]` (Axel Reinhart), `[594]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Narrator: "Duke Reinhart blinked."*)

### Węzeł `[598]`
Mówca: **Narrator**
> "Duke Reinhart blinked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Axel Reinhart: ""That's it?""*)

### Węzeł `[599]`
Mówca: **Axel Reinhart**
> ""That's it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLCSu..."*)

### Węzeł `[600]`
Mówca: **Axel Reinhart**
> ""Not the outcome I was hoping for. But I accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[892]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false"*)
  - -> `[622]` (*Player_Romus: ""With the help of a third party, I'm sure we'll be able t..."*)
  - -> `[623]` (*Player_Romus: ""Did you really think we'd just hand you the field?""*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Axel Reinhart: ""Thank you. I guess.""*)

### Węzeł `[602]`
Mówca: **Axel Reinhart**
> ""Thank you. I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""You and Lespia will both be first against the wall when ..."*)
  - -> `[603]` (*Player_Romus: ""It's a small price to pay for a chance at reconciliation.""*)
  - -> `[604]` (*Player_Romus: ""All I ask in return is that you remember our generosity.""*)
  - -> `[610]` (*Player_Romus: ""This doesn't preclude the possibility of cooperation in ..."*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a small price to pay for a chance at reconciliation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Axel Reinhart: ""I believe you mean that.""*)

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I ask in return is that you remember our generosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Axel Reinhart: ""I will.""*)

### Węzeł `[605]`
Mówca: **Axel Reinhart**
> ""I believe you mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Axel Reinhart: ""Although reconciliation will be difficult with a fleet o..."*)

### Węzeł `[606]`
Mówca: **Axel Reinhart**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[607]`
Mówca: **Axel Reinhart**
> ""Although reconciliation will be difficult with a fleet of Lespian drillships between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[608]`
Mówca: **Narrator**
> "He reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Cede Field]"*)

### Węzeł `[609]`
Mówca: **Narrator**
> "Reinhart reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Cede Field]"*)

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This doesn't preclude the possibility of cooperation in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Axel Reinhart: ""Cooperation will be a lot harder with a fleet of Lespian..."*)

### Węzeł `[611]`
Mówca: **Axel Reinhart**
> ""Cooperation will be a lot harder with a fleet of Lespian drillships between us. But we'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and Lespia will both be first against the wall when the revolution comes, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Narrator: "Reinhart scowled."*)

### Węzeł `[614]`
Mówca: **Axel Reinhart**
> ""Are you serious? If anyone's in danger from the so-called revolution, it's your limping monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Narrator: "He reached under his table and pressed an intercom button."*)

### Węzeł `[615]`
Mówca: **Narrator**
> "Reinhart scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Axel Reinhart: ""Are you serious? If anyone's in danger from the so-calle..."*)

### Węzeł `[616]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Considerable for Pales, perhaps. Rizia's energy needs are greater than you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Axel Reinhart: ""Understood, Your Majesty. Tell me what you want to do.""*)

### Węzeł `[617]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to save us both the hassle. But I am under as much pressure as you are to claim that field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[566]` (Axel Reinhart), `[568]` (Axel Reinhart), `[570]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Axel Reinhart: ""Understood, Your Majesty. Tell me what you want to do.""*)

### Węzeł `[618]`
Mówca: **Narrator**
> "Duke Reinhart nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = tru..."*)

### Węzeł `[619]`
**[WYBÓR GRACZA: ""Furthermore, I'm sending naval reinforcements to prevent Pales from further invading the field during the arbitration process." [Send Navy, +1 Authority]"]** — Mówca: **Player_Romus**
> ""Furthermore, I'm sending naval reinforcements to prevent Pales from further breaching the field's borders during the arbitration process.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false`
- **Kontekst wejściowy (poprzednik):** `[600]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; ..."*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[896]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1; RiziaDLC..."*)

### Węzeł `[621]`
Mówca: **Narrator**
> "His nostrils flared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Axel Reinhart: ""That's *really* not the outcome I was hoping for.""*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the help of a third party, I'm sure we'll be able to come to a compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[600]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Axel Reinhart: ""A fast one, I hope. Lespia has its eyes on us.""*)

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you really think we'd just hand you the field?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[600]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Axel Reinhart: ""I thought you'd recognize a lost cause when you saw one...."*)

### Węzeł `[624]`
Mówca: **Axel Reinhart**
> ""I thought you'd recognize a lost cause when you saw one. But it seems the Rizia of the 1920s is alive and well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Peaceful Arbitration]"*)

### Węzeł `[625]`
Mówca: **Axel Reinhart**
> ""A fast one, I hope. Lespia has its eyes on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Peaceful Arbitration]"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade = true;
RiziaDLC.PersonalValue_Tyrant += 1; 
RiziaDLC.Resources_Authority += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade"] = true;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2; RiziaDLC...."*)

### Węzeł `[627]`
Mówca: **Axel Reinhart**
> ""That's *really* not the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Player_Romus: ""My war councilor suggested it as soon as your ship launc..."*)
  - -> `[629]` (*Player_Romus: ""I trust you. But I fear Lespia might lose its patience.""*)
  - -> `[630]` (*Player_Romus: ""I'm only taking precautions.""*)

### Węzeł `[628]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war councilor suggested it as soon as your ship launched. I should have listened to her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[627]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Axel Reinhart: ""She's an Azaro, isn't she? This meeting was doomed from ..."*)

### Węzeł `[629]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you. But I fear Lespia might lose its patience.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[627]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Axel Reinhart: ""If you insist on stoking potential conflict... so be it.""*)

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm only taking precautions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[627]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Axel Reinhart: ""Then so will we.""*)

### Węzeł `[631]`
Mówca: **Axel Reinhart**
> ""She's an Azaro, isn't she? This meeting was doomed from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Violent Arbitration]"*)

### Węzeł `[632]`
Mówca: **Axel Reinhart**
> ""If you insist on stoking potential conflict... so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Violent Arbitration]"*)

### Węzeł `[633]`
Mówca: **Axel Reinhart**
> ""Then so will we.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Violent Arbitration]"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End Peaceful Arbitration`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End Cede Field]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "End Cede Field"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End Peaceful Arbitration]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "End Peaceful Arbitration"*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End Violent Arbitration`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End Violent Arbitration]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "End Violent Arbitration"*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End Cede Field`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Axel Reinhart: ""Hilda? Be a doll and help show His Majesty the way out o..."*)

### Węzeł `[640]`
Mówca: **Axel Reinhart**
> ""Enough insults, Your Majesty. Tell me what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Player_Romus: ""I see no choice but to enter arbitration. We will notify..."*)
  - -> `[643]` (*Player_Romus: ""You know what? Rizia is not that desperate. We will cede..."*)

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no choice but to enter arbitration. We will notify the Alliance of Nations at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[640]` (Axel Reinhart), `[642]` (Axel Reinhart), `[644]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Narrator: "Duke Reinhart nodded."*)

### Węzeł `[642]`
Mówca: **Axel Reinhart**
> ""Understood, Your Majesty. Tell me what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Player_Romus: ""I see no choice but to enter arbitration. We will notify..."*)
  - -> `[643]` (*Player_Romus: ""You know what? Rizia is not that desperate. We will cede..."*)

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? Rizia is not that desperate. We will cede the field to you if you like.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[640]` (Axel Reinhart), `[642]` (Axel Reinhart), `[644]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Narrator: "Duke Reinhart blinked."*)

### Węzeł `[644]`
Mówca: **Axel Reinhart**
> ""Then let's end this conversation. Tell me what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Player_Romus: ""I see no choice but to enter arbitration. We will notify..."*)
  - -> `[643]` (*Player_Romus: ""You know what? Rizia is not that desperate. We will cede..."*)

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sovereignty? Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Axel Reinhart), `[15]` (Axel Reinhart), `[152]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Axel Reinhart: ""And what of Rizia? Trudging forward with the legacy of t..."*)

### Węzeł `[646]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Axel Reinhart), `[15]` (Axel Reinhart), `[152]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Axel Reinhart: ""And what of Rizia and Rumburg? What of the deal your fat..."*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Let's not let the bad blood between our families color our present relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Axel Reinhart), `[15]` (Axel Reinhart), `[152]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We respect your sovereignty. It doesn't mean you can steal our gas from us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Axel Reinhart), `[15]` (Axel Reinhart), `[152]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Axel Reinhart: ""It is disrespectful to claim that the sovereignty of our..."*)

### Węzeł `[649]`
Mówca: **Axel Reinhart**
> ""Between our families? I think you're forgetting our personal history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Axel Reinhart: ""But I am prepared to reconcile as long as you recognize ..."*)

### Węzeł `[650]`
Mówca: **Axel Reinhart**
> ""And what of Rizia and Rumburg? What of the deal your father made with Wehlen to keep House Toras in power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "I saw intensity in his eyes."*)

### Węzeł `[651]`
Mówca: **Axel Reinhart**
> ""It is disrespectful to claim that the sovereignty of our nation, however young, is equal to that of a neglected speck of a Rizian island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "I saw intensity in his eyes."*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Axel Reinhart: ""Between our families? I think you're forgetting our pers..."*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Axel Reinhart: ""I am prepared to reconcile as long as you recognize that..."*)

### Węzeł `[655]`
Mówca: **Axel Reinhart**
> ""I am prepared to reconcile as long as you recognize that the gas field belongs to Pales alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "I saw intensity in his eyes."*)

### Węzeł `[656]`
Mówca: **Axel Reinhart**
> ""But I am prepared to reconcile as long as you recognize that the gas field belongs to Pales alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "I saw intensity in his eyes."*)

### Węzeł `[657]`
Mówca: **Narrator**
> "I saw intensity in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Axel Reinhart: ""You know, Your Majesty, we Reinharts have ruled Pales fo..."*)

### Węzeł `[658]`
Mówca: **Axel Reinhart**
> ""You know, Your Majesty, we Reinharts have ruled Pales for as long as the Torases have ruled Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Axel Reinhart: ""Yes, Pales was part of the Valgos Empire. But we develop..."*)

### Węzeł `[659]`
Mówca: **Axel Reinhart**
> ""And what of Rizia? Trudging forward with the legacy of the mighty Rezenids, long after their empire should have turned to dust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "I saw intensity in his eyes."*)

### Węzeł `[660]`
Mówca: **Axel Reinhart**
> ""Yes, Pales was part of the Valgos Empire. But we developed our own laws and customs. Even our own language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Axel Reinhart: ""When the Empire fell apart, what were we supposed to do?..."*)

### Węzeł `[661]`
Mówca: **Axel Reinhart**
> ""When the Empire fell apart, what were we supposed to do? Simply give up everything we had built?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Player_Romus: ""I would have done that before turning to Lespia.""*)
  - -> `[664]` (*Player_Romus: ""No. No, I suppose not.""*)
  - -> `[663]` (*Player_Romus: ""Regimes end. It was your time.""*)
  - -> `[662]` (*Player_Romus: ""Pales could have kept its cultural identity intact if it..."*)

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales could have kept its cultural identity intact if it had rejoined Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Axel Reinhart: ""Your father would never have allowed that.""*)

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regimes end. It was your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Axel Reinhart: ""That wasn't your kingdom's decision to make.""*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. No, I suppose not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Axel Reinhart: ""I heard what it was like back then. Rizia and Morella pi..."*)

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would have done that before turning to Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Axel Reinhart: ""You don't know what you would have done.""*)

### Węzeł `[666]`
Mówca: **Axel Reinhart**
> ""Your father would never have allowed that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC...."*)

### Węzeł `[667]`
Mówca: **Axel Reinhart**
> ""That wasn't your kingdom's decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Axel Reinhart: ""I heard what it was like back then. Rizia and Morella pi..."*)

### Węzeł `[668]`
Mówca: **Axel Reinhart**
> ""You don't know what you would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Axel Reinhart: ""I heard what it was like back then. Rizia and Morella pi..."*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC...."*)
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Absolutism == true || RiziaDL..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Axel Reinhart: ""And your own nationalist tendencies make me think you wo..."*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Axel Reinhart: ""Even if he had, my family never would have agreed. They ..."*)

### Węzeł `[672]`
Mówca: **Axel Reinhart**
> ""And your own nationalist tendencies make me think you wouldn't, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Axel Reinhart: ""Lespia, on the other hand, was more than willing to supp..."*)

### Węzeł `[673]`
Mówca: **Axel Reinhart**
> ""Even if he had, my family never would have agreed. They had too much pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Axel Reinhart: ""So they accepted help from Lespia. The only country will..."*)

### Węzeł `[674]`
Mówca: **Axel Reinhart**
> ""Lespia, on the other hand, was more than willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Player_Romus: ""They supported your independence... by making you depend..."*)
  - -> `[679]` (*Player_Romus: ""Your family must have realized their motives for doing s..."*)
  - -> `[680]` (*Player_Romus: ""You should never have been put in that position, Your Gr..."*)

### Węzeł `[675]`
Mówca: **Axel Reinhart**
> ""So they accepted help from Lespia. The only country willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Player_Romus: ""They supported your independence... by making you depend..."*)
  - -> `[679]` (*Player_Romus: ""Your family must have realized their motives for doing s..."*)
  - -> `[680]` (*Player_Romus: ""You should never have been put in that position, Your Gr..."*)

### Węzeł `[676]`
Mówca: **Axel Reinhart**
> ""I heard what it was like back then. Rizia and Morella picking at us like vultures. Goddamn Valgsland trying to provoke a revolution from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Axel Reinhart: ""Lespia was the only nation willing to support our indepe..."*)

### Węzeł `[677]`
Mówca: **Axel Reinhart**
> ""Lespia was the only nation willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Player_Romus: ""They supported your independence... by making you depend..."*)
  - -> `[679]` (*Player_Romus: ""Your family must have realized their motives for doing s..."*)
  - -> `[680]` (*Player_Romus: ""You should never have been put in that position, Your Gr..."*)

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They supported your independence... by making you dependent on them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[674]` (Axel Reinhart), `[675]` (Axel Reinhart), `[677]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Axel Reinhart: ""By making us wealthy. By giving us the capacity to defen..."*)

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family must have realized their motives for doing so were less than pure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[674]` (Axel Reinhart), `[675]` (Axel Reinhart), `[677]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Axel Reinhart: ""Of course. But thanks to Rizia's aggression, they had no..."*)

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should never have been put in that position, Your Grace. My country should have left Pales alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[674]` (Axel Reinhart), `[675]` (Axel Reinhart), `[677]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Axel Reinhart: ""Thank you for acknowledging that. But it doesn't change ..."*)

### Węzeł `[681]`
Mówca: **Axel Reinhart**
> ""Thank you for acknowledging that. But it doesn't change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Player_Romus: ""Now that Lespia is an ATO member, they won't want to be ..."*)
  - -> `[685]` (*Player_Romus: ""I understand why Pales accepted Lespia's aid. But now th..."*)
  - -> `[687]` (*Player_Romus: ""Have you met their new prime minister? Do you trust him?""*)
  - -> `[686]` (*Player_Romus: ""Enough with the history lesson. What do you plan to do *..."*)

### Węzeł `[682]`
Mówca: **Axel Reinhart**
> ""Of course. But thanks to Rizia's aggression, they had no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Player_Romus: ""Now that Lespia is an ATO member, they won't want to be ..."*)
  - -> `[685]` (*Player_Romus: ""I understand why Pales accepted Lespia's aid. But now th..."*)
  - -> `[687]` (*Player_Romus: ""Have you met their new prime minister? Do you trust him?""*)
  - -> `[686]` (*Player_Romus: ""Enough with the history lesson. What do you plan to do *..."*)

### Węzeł `[683]`
Mówca: **Axel Reinhart**
> ""By making us wealthy. By giving us the capacity to defend ourselves against aggressors like you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Player_Romus: ""Now that Lespia is an ATO member, they won't want to be ..."*)
  - -> `[685]` (*Player_Romus: ""I understand why Pales accepted Lespia's aid. But now th..."*)
  - -> `[687]` (*Player_Romus: ""Have you met their new prime minister? Do you trust him?""*)
  - -> `[686]` (*Player_Romus: ""Enough with the history lesson. What do you plan to do *..."*)

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that Lespia is an ATO member, they won't want to be connected to a monarchy for long. They'll have you overthrown the first chance they get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Axel Reinhart), `[682]` (Axel Reinhart), `[683]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[685]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand why Pales accepted Lespia's aid. But now that Morella is in league with Valgsland, you could get caught between superpowers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Axel Reinhart), `[682]` (Axel Reinhart), `[683]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[686]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the history lesson. What do you plan to do *now*?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Axel Reinhart), `[682]` (Axel Reinhart), `[683]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[687]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you met their new prime minister? Do you trust him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Axel Reinhart), `[682]` (Axel Reinhart), `[683]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Narrator: "His gaze hardened as he looked at me."*)

### Węzeł `[688]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Axel Reinhart: ""No, they won't. Not while they need our gas.""*)

### Węzeł `[689]`
Mówca: **Axel Reinhart**
> ""No, they won't. Not while they need our gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Axel Reinhart: ""So you see, Your Majesty, we can't let Rizia take it fro..."*)

### Węzeł `[690]`
Mówca: **Axel Reinhart**
> ""So you see, Your Majesty, we can't let Rizia take it from us. Not without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Player_Romus: ""Calm down, Your Grace. We have no intention of starting ..."*)
  - -> `[698]` (*Player_Romus: ""If it's a fight you want, it's a fight you'll get.""*)
  - -> `[699]` (*Player_Romus: ""You are not the only country with obligations. And the g..."*)
  - -> `[702]` (*Player_Romus: ""A compelling argument. But we won't cede the field to yo..."*)

### Węzeł `[691]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Axel Reinhart: ""Not as long as we have a bargaining chip. And we do, rig..."*)

### Węzeł `[692]`
Mówca: **Axel Reinhart**
> ""Not as long as we have a bargaining chip. And we do, right at the bottom of the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Axel Reinhart: ""So you see, Your Majesty, we can't let Rizia take it fro..."*)

### Węzeł `[693]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Axel Reinhart: ""I am bringing this up so you understand the stakes.""*)

### Węzeł `[694]`
Mówca: **Axel Reinhart**
> ""I am bringing this up so you understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Axel Reinhart: ""We have an obligation to Lespia. When they ask us for na..."*)

### Węzeł `[695]`
Mówca: **Axel Reinhart**
> ""We have an obligation to Lespia. When they ask us for natural gas, we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Axel Reinhart: ""So you see, Your Majesty, we can't let Rizia take it fro..."*)

### Węzeł `[696]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Calm down, Your Grace. We have no intention of starting a fight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[690]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Axel Reinhart: ""Then prove it. Send your ships back.""*)

### Węzeł `[697]`
Mówca: **Axel Reinhart**
> ""Then prove it. Send your ships back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Player_Romus: ""I will when you send *your* ship back.""*)
  - -> `[707]` (*Player_Romus: ""I am considering it. But we have to come to an agreement..."*)
  - -> `[708]` (*Player_Romus: ""How do I know you won't just resume drilling if I call f..."*)

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it's a fight you want, it's a fight you'll get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[690]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Axel Reinhart: ""Are you sure, Your Majesty? You remember what happened i..."*)

### Węzeł `[699]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are not the only country with obligations. And the gas field is large enough to be split.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[690]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Axel Reinhart: ""Sharing a gas field requires close collaboration. You'll..."*)

### Węzeł `[700]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Axel Reinhart: ""I trust Patricio Alvarez more than I trust you.""*)

### Węzeł `[701]`
Mówca: **Axel Reinhart**
> ""I trust Patricio Alvarez more than I trust you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Axel Reinhart: ""We have an obligation to Lespia. When they ask us for na..."*)

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A compelling argument. But we won't cede the field to you for nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[690]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Axel Reinhart: ""Why not? It would avoid us both a lot of headache.""*)

### Węzeł `[703]`
Mówca: **Axel Reinhart**
> ""Are you sure, Your Majesty? You remember what happened in the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Player_Romus: ""Yes. We had you beat until you went crying to Lespia.""*)
  - -> `[710]` (*Player_Romus: ""Yes. We lost a lot of good men fighting Pales.""*)
  - -> `[711]` (*Player_Romus: ""I remember better than you. You weren't even born.""*)

### Węzeł `[704]`
Mówca: **Axel Reinhart**
> ""Sharing a gas field requires close collaboration. You'll excuse me if I don't feel like collaborating with Rizia right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Player_Romus: ""I admit I acted harshly. If I agree to call back our shi..."*)
  - -> `[713]` (*Player_Romus: ""We don't have to collaborate. Just stay on our respectiv..."*)
  - -> `[714]` (*Player_Romus: ""If you don't choose to collaborate, we will force you to..."*)

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will when you send *your* ship back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[697]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Axel Reinhart: ""No, I will not withdraw Pales' presence from the field a..."*)

### Węzeł `[706]`
Mówca: **Axel Reinhart**
> ""Why not? It would avoid us both a lot of headache.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Player_Romus: ""Giving in to Pales, and therefore Lespia, would make us ..."*)
  - -> `[729]` (*Player_Romus: ""Rizia needs the gas in that field, Your Grace. Do not te..."*)
  - -> `[730]` (*Player_Romus: ""It's the principle of the thing. I truly believe the fie..."*)

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am considering it. But we have to come to an agreement regarding the gas field first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[697]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Axel Reinhart: ""Excuse me, Your Majesty, but I'm feeling less than agree..."*)

### Węzeł `[708]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do I know you won't just resume drilling if I call for a retreat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[697]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Axel Reinhart: ""If I do that, you can call your ships right back in.""*)

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We had you beat until you went crying to Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[703]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Axel Reinhart: ""Lespia only offered us minor assistance with weapons and..."*)

### Węzeł `[710]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We lost a lot of good men fighting Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[703]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Axel Reinhart: ""Invading Pales, you mean.""*)

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember better than you. You weren't even born.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[703]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Axel Reinhart: ""Then you know how unwise it is to provoke my Grand Duchy.""*)

### Węzeł `[712]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I admit I acted harshly. If I agree to call back our ships, can we have a reasonable talk?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[704]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Axel Reinhart: ""At last, something resembling sanity from the King of Ri..."*)

### Węzeł `[713]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have to collaborate. Just stay on our respective sides.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[704]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Axel Reinhart: ""There's too much potential for disagreement. Which Rizia..."*)

### Węzeł `[714]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't choose to collaborate, we will force you to do so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[704]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Axel Reinhart: ""Please, Your Majesty. Neither of us want escalation.""*)

### Węzeł `[715]`
Mówca: **Axel Reinhart**
> ""No, I will not withdraw Pales' presence from the field as long as the Rizian navy is there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Axel Reinhart: ""I am asking you politely. Withdraw your navy, and we wil..."*)

### Węzeł `[716]`
Mówca: **Axel Reinhart**
> ""Excuse me, Your Majesty, but I'm feeling less than agreeable with your ships' guns pointed at mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Axel Reinhart: ""I am asking you politely. Withdraw your navy, and we wil..."*)

### Węzeł `[717]`
Mówca: **Axel Reinhart**
> ""If I do that, you can call your ships right back in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Axel Reinhart: ""I am asking you politely. Withdraw your navy, and we wil..."*)

### Węzeł `[718]`
Mówca: **Axel Reinhart**
> ""Lespia only offered us minor assistance with weapons and equipment. Your own internal strife harmed you more than Lespia did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I will give you one chance. Withdraw your navy, and we w..."*)

### Węzeł `[719]`
Mówca: **Axel Reinhart**
> ""Invading Pales, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I will give you one chance. Withdraw your navy, and we w..."*)

### Węzeł `[720]`
Mówca: **Axel Reinhart**
> ""Then you know how unwise it is to provoke my Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I will give you one chance. Withdraw your navy, and we w..."*)

### Węzeł `[721]`
Mówca: **Axel Reinhart**
> ""At last, something resembling sanity from the King of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Axel Reinhart: ""Yes. Withdraw your navy, and we will continue this conve..."*)

### Węzeł `[722]`
Mówca: **Axel Reinhart**
> ""I am asking you politely. Withdraw your navy, and we will talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Player_Romus: ""Absolutely not. My ships are staying right where they are.""*)
  - -> `[736]` (*Player_Romus: ""If it means we can move forward, then fine. I'll call of..."*)

### Węzeł `[723]`
Mówca: **Axel Reinhart**
> ""I will give you one chance. Withdraw your navy, and we will have a reasonable discussion about the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Player_Romus: ""Absolutely not. My ships are staying right where they are.""*)
  - -> `[736]` (*Player_Romus: ""If it means we can move forward, then fine. I'll call of..."*)

### Węzeł `[724]`
Mówca: **Axel Reinhart**
> ""There's too much potential for disagreement. Which Rizia has already proved itself incapable of handling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Axel Reinhart: ""Before we continue this conversation, I must insist that..."*)

### Węzeł `[725]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. Neither of us want escalation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Axel Reinhart: ""Before we continue this conversation, I must insist that..."*)

### Węzeł `[726]`
Mówca: **Axel Reinhart**
> ""Before we continue this conversation, I must insist that you withdraw your navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Player_Romus: ""Absolutely not. My ships are staying right where they are.""*)
  - -> `[736]` (*Player_Romus: ""If it means we can move forward, then fine. I'll call of..."*)

### Węzeł `[727]`
Mówca: **Axel Reinhart**
> ""Yes. Withdraw your navy, and we will continue this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Player_Romus: ""Absolutely not. My ships are staying right where they are.""*)
  - -> `[736]` (*Player_Romus: ""If it means we can move forward, then fine. I'll call of..."*)

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving in to Pales, and therefore Lespia, would make us look weak internationally. We can't afford that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[706]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Axel Reinhart: ""Have you thought about how it would make us look to cave..."*)

### Węzeł `[729]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia needs the gas in that field, Your Grace. Do not test us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[706]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Axel Reinhart: ""Just because you need it doesn't make you entitled to it.""*)

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's the principle of the thing. I truly believe the field's proximity to Caleqabiz gives us a right to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[706]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Axel Reinhart: ""And I believe it doesn't. So where does that get us?""*)

### Węzeł `[731]`
Mówca: **Axel Reinhart**
> ""And I believe it doesn't. So where does that get us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Axel Reinhart: ""Please, Your Majesty. We can discuss this. But I want yo..."*)

### Węzeł `[732]`
Mówca: **Axel Reinhart**
> ""Just because you need it doesn't make you entitled to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Axel Reinhart: ""Please, Your Majesty. We can discuss this. But I want yo..."*)

### Węzeł `[733]`
Mówca: **Axel Reinhart**
> ""Have you thought about how it would make us look to cave in to Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Axel Reinhart: ""Please, Your Majesty. We can discuss this. But I want yo..."*)

### Węzeł `[734]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. We can discuss this. But I want you to withdraw your navy first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Player_Romus: ""Absolutely not. My ships are staying right where they are.""*)
  - -> `[736]` (*Player_Romus: ""If it means we can move forward, then fine. I'll call of..."*)

### Węzeł `[735]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. My ships are staying right where they are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[722]` (Axel Reinhart), `[723]` (Axel Reinhart), `[726]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Narrator: "Duke Reinhart paled. He swallowed before speaking."*)

### Węzeł `[736]`
**[WYBÓR GRACZA: ""If it means we can move forward, then fine. I'll call off my ships effective immediately." [Recall Fleet]"]** — Mówca: **Player_Romus**
> ""If it means we can move forward, then fine. I'll call off my ships effective immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[722]` (Axel Reinhart), `[723]` (Axel Reinhart), `[726]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Narrator: "Duke Reinhart breathed a shaky sigh of relief."*)

### Węzeł `[737]`
Mówca: **Narrator**
> "Duke Reinhart breathed a shaky sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Axel Reinhart: ""Thank you.""*)

### Węzeł `[738]`
Mówca: **Axel Reinhart**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Axel Reinhart: ""Unfortunately, our options for the Aureus field are stil..."*)

### Węzeł `[739]`
Mówca: **Narrator**
> "Duke Reinhart paled. He swallowed before speaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Axel Reinhart: ""That's it, then.""*)

### Węzeł `[740]`
Mówca: **Axel Reinhart**
> ""That's it, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Axel Reinhart: ""I see no choice but to call in the AN for arbitration.""*)

### Węzeł `[741]`
Mówca: **Axel Reinhart**
> ""I see no choice but to call in the AN for arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Player_Romus: ""Great. They'll easily rule that Pales acted in direct vi..."*)
  - -> `[744]` (*Player_Romus: ""Halaita. If it is said, so it is, so it will be.""*)
  - -> `[751]` (*Player_Romus: ""Come on. What happened to solving disputes man to man?""*)

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. They'll easily rule that Pales acted in direct violation of the AN Directive on Offshore Resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[741]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Axel Reinhart: ""A directive we never ratified.""*)

### Węzeł `[743]`
Mówca: **Axel Reinhart**
> ""And even if it applies, ANDOR is not black and white. It's very nuanced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Player_Romus: ""It's only nuanced compared to its predecessors. It doesn..."*)
  - -> `[746]` (*Player_Romus: ""We have the support of the international community. Pale..."*)
  - -> `[748]` (*Player_Romus: ""The rules over our maritime borders seem clear to me. An..."*)

### Węzeł `[744]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is, so it will be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[741]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[908]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[745]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's only nuanced compared to its predecessors. It doesn't stand alone as a brilliant piece of legislation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[743]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Axel Reinhart: ""It's nuanced enough that I believe Pales will get the be..."*)

### Węzeł `[746]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have the support of the international community. Pales doesn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[743]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Axel Reinhart: ""We have the backing of Lespia, which has the backing of ..."*)

### Węzeł `[747]`
Mówca: **Axel Reinhart**
> ""I never cared for those old Wruhecist saws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Player_Romus: ""You're disrespecting our religion now?""*)
  - -> `[753]` (*Player_Romus: ""It's not a saw, it's a promise. Your words shall transla..."*)
  - -> `[757]` (*Player_Romus: ""Nor do I, but my subjects go crazy for them.""*)

### Węzeł `[748]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rules over our maritime borders seem clear to me. And to my councilors as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[743]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Axel Reinhart: ""Let's see if the AN sees it that way.""*)

### Węzeł `[749]`
Mówca: **Axel Reinhart**
> ""A directive we never ratified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Axel Reinhart: ""And even if it applies, ANDOR is not black and white. It..."*)

### Węzeł `[750]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're disrespecting our religion now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[747]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[751]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on. What happened to solving disputes man to man?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[741]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Axel Reinhart: ""I won't risk it. The potential for inciting an armed con..."*)

### Węzeł `[752]`
Mówca: **Axel Reinhart**
> ""I won't risk it. The potential for inciting an armed conflict is too high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Player_Romus: ""You're right. Calling in a third party will help us find..."*)
  - -> `[787]` (*Player_Romus: ""Armed conflict... what about arm wrestling? We can settl..."*)
  - -> `[801]` (*Player_Romus: ""You're afraid of what would happen if I unleashed the fu..."*)

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a saw, it's a promise. Your words shall translate into actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[747]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Axel Reinhart: ""You're right about that.""*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Axel Reinhart: ""I'm as God-fearing as the next man. But we can't stay be..."*)

### Węzeł `[755]`
Mówca: **Axel Reinhart**
> ""I'm as God-fearing as the next man. But we can't stay beholden to the words of old saints forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Axel Reinhart: ""In any event, I hope you will send your ships away peace..."*)

### Węzeł `[756]`
Mówca: **Axel Reinhart**
> ""You're right about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Axel Reinhart: ""In any event, I hope you will send your ships away peace..."*)

### Węzeł `[757]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor do I, but my subjects go crazy for them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[747]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Axel Reinhart: ""Everyone loves a king with a direct line to God.""*)

### Węzeł `[758]`
Mówca: **Axel Reinhart**
> ""Everyone loves a king with a direct line to God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Axel Reinhart: ""In any event, I hope you will send your ships away peace..."*)

### Węzeł `[759]`
Mówca: **Axel Reinhart**
> ""Unfortunately, our options for the Aureus field are still limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Axel Reinhart: ""Lespia is on the verge of purchasing the exploration rig..."*)

### Węzeł `[760]`
Mówca: **Axel Reinhart**
> ""Lespia is on the verge of purchasing the exploration rights to the field. Yet you obviously are not willing to cede it to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Axel Reinhart: ""So the only choice I see is to take this to the Alliance..."*)

### Węzeł `[761]`
Mówca: **Axel Reinhart**
> ""So the only choice I see is to take this to the Alliance of Nations for arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Player_Romus: ""They'll easily rule that Pales acted in direct violation..."*)
  - -> `[800]` (*Player_Romus: ""That's the only choice? Can't we come to a compromise on..."*)
  - -> `[762]` (*Player_Romus: ""Wait. If I *do* cede the field to Pales, what will you g..."*)

### Węzeł `[762]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. If I *do* cede the field to Pales, what will you give Rizia in return?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[761]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Axel Reinhart: ""The chance to avoid a lengthy, costly court process that..."*)

### Węzeł `[763]`
Mówca: **Axel Reinhart**
> ""The chance to avoid a lengthy, costly court process that you will inevitably lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Axel Reinhart: ""We don't have much to give, I'm afraid. But maybe Lespia..."*)

### Węzeł `[764]`
Mówca: **Axel Reinhart**
> ""We don't have much to give, I'm afraid. But maybe Lespia will sell you part of the rights once they've been awarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Player_Romus: ""Not much of a consolation prize.""*)
  - -> `[766]` (*Player_Romus: ""What makes you think Rizia will lose?""*)
  - -> `[774]` (*Player_Romus: ""I refuse to make deals with Lespia.""*)
  - -> `[767]` (*Player_Romus: ""What about a chance for lasting peace between our two na..."*)

### Węzeł `[765]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not much of a consolation prize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[764]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Axel Reinhart: ""Well. I can't think of anything else under the circumsta..."*)

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think Rizia will lose?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[764]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Axel Reinhart: ""We have the backing of Lespia, which has the backing of ..."*)

### Węzeł `[767]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about a chance for lasting peace between our two nations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[764]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Axel Reinhart: ""You made it clear that Rizia did not want peace.""*)

### Węzeł `[768]`
Mówca: **Axel Reinhart**
> ""You made it clear that Rizia did not want peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Axel Reinhart: ""But if you've changed your mind about that, here's your ..."*)

### Węzeł `[769]`
Mówca: **Axel Reinhart**
> ""But if you've changed your mind about that, here's your opportunity to prove it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Player_Romus: ""I am not backing down. We will have to enter arbitration.""*)
  - -> `[862]` (*Player_Romus: ""You know what? You're obviously more desperate for this ..."*)

### Węzeł `[770]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Axel Reinhart: ""But if you'd like to test that theory, be my guest.""*)

### Węzeł `[771]`
Mówca: **Axel Reinhart**
> ""But if you'd like to test that theory, be my guest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Player_Romus: ""I am not backing down. We will have to enter arbitration.""*)
  - -> `[862]` (*Player_Romus: ""You know what? You're obviously more desperate for this ..."*)

### Węzeł `[772]`
Mówca: **Axel Reinhart**
> ""Well. I can't think of anything else under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Axel Reinhart: ""But even a small percentage of the Aureus field would be..."*)

### Węzeł `[773]`
Mówca: **Axel Reinhart**
> ""But even a small percentage of the Aureus field would be a considerable amount of energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Player_Romus: ""I am not backing down. We will have to enter arbitration.""*)
  - -> `[862]` (*Player_Romus: ""You know what? You're obviously more desperate for this ..."*)

### Węzeł `[774]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I refuse to make deals with Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[764]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Axel Reinhart: ""Then never mind.""*)

### Węzeł `[775]`
Mówca: **Axel Reinhart**
> ""Then never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Axel Reinhart: ""I am all for arbitration. Just wanted to save you the ha..."*)

### Węzeł `[776]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Player_Romus: ""Your intimidation won't work on me. Remember, my navy is..."*)
  - -> `[781]` (*Player_Romus: ""You're forgetting the support we have from Rumburg and G..."*)
  - -> `[782]` (*Player_Romus: ""The rest of Southern Merkopa will take my side.""*)
  - -> `[783]` (*Player_Romus: ""You shouldn't place so much trust in Lespia, Your Grace.""*)

### Węzeł `[777]`
Mówca: **Axel Reinhart**
> ""It's nuanced enough that I believe Pales will get the benefit of the doubt. Especially with international help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Player_Romus: ""Your intimidation won't work on me. Remember, my navy is..."*)
  - -> `[781]` (*Player_Romus: ""You're forgetting the support we have from Rumburg and G..."*)
  - -> `[782]` (*Player_Romus: ""The rest of Southern Merkopa will take my side.""*)
  - -> `[783]` (*Player_Romus: ""You shouldn't place so much trust in Lespia, Your Grace.""*)

### Węzeł `[778]`
Mówca: **Axel Reinhart**
> ""Let's see if the AN sees it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Axel Reinhart: ""Remember, we have the backing of Lespia, which has the b..."*)

### Węzeł `[779]`
Mówca: **Axel Reinhart**
> ""Remember, we have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Player_Romus: ""Your intimidation won't work on me. Remember, my navy is..."*)
  - -> `[781]` (*Player_Romus: ""You're forgetting the support we have from Rumburg and G..."*)
  - -> `[782]` (*Player_Romus: ""The rest of Southern Merkopa will take my side.""*)
  - -> `[783]` (*Player_Romus: ""You shouldn't place so much trust in Lespia, Your Grace.""*)

### Węzeł `[780]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your intimidation won't work on me. Remember, my navy is still surrounding your ship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart), `[777]` (Axel Reinhart), `[779]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Axel Reinhart: ""And I hope you will send it away peacefully once you lose.""*)

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're forgetting the support we have from Rumburg and GRACE.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart), `[777]` (Axel Reinhart), `[779]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Axel Reinhart: ""This is the 20th century, Your Majesty. Dying monarchies..."*)

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rest of Southern Merkopa will take my side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart), `[777]` (Axel Reinhart), `[779]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Axel Reinhart: ""Will they? After you've shown that you'll deploy your mi..."*)

### Węzeł `[783]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't place so much trust in Lespia, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart), `[777]` (Axel Reinhart), `[779]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Axel Reinhart: ""And you should not underestimate them. Or us.""*)

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Calling in a third party will help us find a compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[752]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Axel Reinhart: ""To the extent that 'compromise' is possible with a kingd..."*)

### Węzeł `[785]`
Mówca: **Axel Reinhart**
> ""In any event, I hope you will send your ships away peacefully once you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's presumptuous of you, Your Grace. You'll find no s..."*)
  - -> `[795]` (*Player_Romus: ""What makes you think we will lose? Remember that we have..."*)
  - -> `[811]` (*Player_Romus: ""I will respect whatever the AN decides, as long as their..."*)

### Węzeł `[786]`
Mówca: **Axel Reinhart**
> ""To the extent that 'compromise' is possible with a kingdom as militant as yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Axel Reinhart: ""I hope you will send your ships away peacefully once you..."*)

### Węzeł `[787]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Armed conflict... what about arm wrestling? We can settle the argument right here at this table.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[752]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[788]`
Mówca: **Narrator**
> "He raised an eyebrow. I saw the muscles in his arm twitch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Narrator: "He raised an eyebrow. I saw the muscles in his arm twitch."*)

### Węzeł `[790]`
Mówca: **Axel Reinhart**
> ""Are you joking? You would lose in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]` (*Axel Reinhart: ""Just as you will lose the arbitration process.""*)

### Węzeł `[791]`
Mówca: **Axel Reinhart**
> ""Just as you will lose the arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's presumptuous of you, Your Grace. You'll find no s..."*)
  - -> `[795]` (*Player_Romus: ""What makes you think we will lose? Remember that we have..."*)
  - -> `[812]` (*Player_Romus: ""I knew the Duke of Pales would be too cowardly to arm wr..."*)

### Węzeł `[792]`
Mówca: **Axel Reinhart**
> ""I hope you will send your ships away peacefully once you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's presumptuous of you, Your Grace. You'll find no s..."*)
  - -> `[795]` (*Player_Romus: ""What makes you think we will lose? Remember that we have..."*)
  - -> `[811]` (*Player_Romus: ""I will respect whatever the AN decides, as long as their..."*)

### Węzeł `[793]`
Mówca: **Axel Reinhart**
> ""And I hope you will send it away peacefully once you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's presumptuous of you, Your Grace. You'll find no support from the rest of South Merkopa.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[785]` (Axel Reinhart), `[791]` (Axel Reinhart), `[792]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Axel Reinhart: ""And you will?""*)

### Węzeł `[795]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think we will lose? Remember that we have GRACE on our side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[785]` (Axel Reinhart), `[791]` (Axel Reinhart), `[792]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Axel Reinhart: ""This is the 20th century, Your Majesty. Dying monarchies..."*)

### Węzeł `[796]`
Mówca: **Axel Reinhart**
> ""This is the 20th century, Your Majesty. Dying monarchies don't have as much clout as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[797]`
Mówca: **Axel Reinhart**
> ""Will they? After you've shown that you'll deploy your military at the drop of a hat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[798]`
Mówca: **Axel Reinhart**
> ""And you should not underestimate them. Or us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[799]`
Mówca: **Narrator**
> "He reached under his desk and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Axel Reinhart: ""Hilda? Be a doll and help show His Majesty the way out o..."*)

### Węzeł `[800]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the only choice? Can't we come to a compromise on our own?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[761]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're afraid of what would happen if I unleashed the full power of the Rizian military on Pales. As you should be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[752]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[802]`
Mówca: **Axel Reinhart**
> ""I most certainly am not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Axel Reinhart: ""But if we get into a conflict around the Aureus field, w..."*)

### Węzeł `[803]`
Mówca: **Axel Reinhart**
> ""But if we get into a conflict around the Aureus field, we risk damaging the very resource we're fighting over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Player_Romus: ""Watching your face as you surrender will be worth it.""*)
  - -> `[827]` (*Player_Romus: ""Then we'll just have to do our fighting elsewhere.""*)
  - -> `[828]` (*Player_Romus: ""I was only posturing. I have no intention of inciting co..."*)

### Węzeł `[804]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Narrator: "He sat back in his chair and scrutinized me closely."*)

### Węzeł `[805]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Axel Reinhart: ""You do understand that as long as your navy is in our wa..."*)

### Węzeł `[806]`
Mówca: **Axel Reinhart**
> ""You do understand that as long as your navy is in our waters, we are obligated to send our ships to join yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Player_Romus: ""By all means, do.""*)
  - -> `[808]` (*Player_Romus: ""Your vastly inferior ships, you mean.""*)
  - -> `[809]` (*Player_Romus: ""I'm sorry that it's come to this, Your Grace.""*)

### Węzeł `[807]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By all means, do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[806]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Axel Reinhart: ""You're playing a very dangerous game.""*)

### Węzeł `[808]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your vastly inferior ships, you mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[806]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Axel Reinhart: ""You do not want to test the strength of the Palesian navy.""*)

### Węzeł `[809]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry that it's come to this, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[806]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Axel Reinhart: ""This entirely avoidable situation? Yes, I'm sorry as well.""*)

### Węzeł `[810]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watching your face as you surrender will be worth it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[803]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Axel Reinhart: ""Believe me, Pales would not surrender.""*)

### Węzeł `[811]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will respect whatever the AN decides, as long as their judgement is fair and unbiased.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[785]` (Axel Reinhart), `[792]` (Axel Reinhart), `[833]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Axel Reinhart: ""I'll hold you to that, Your Majesty.""*)

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew the Duke of Pales would be too cowardly to arm wrestle a real king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[791]` (Axel Reinhart), `[905]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Axel Reinhart: ""You're embarrassing yourself, Your Majesty.""*)

### Węzeł `[813]`
Mówca: **Axel Reinhart**
> ""And you will?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[814]`
Mówca: **Axel Reinhart**
> ""This is the 20th century, Your Majesty. Dying monarchies don't have as much clout as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[815]`
Mówca: **Axel Reinhart**
> ""I'll hold you to that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[816]`
Mówca: **Axel Reinhart**
> ""You're embarrassing yourself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "He reached under his desk and pressed an intercom button."*)

### Węzeł `[817]`
Mówca: **Axel Reinhart**
> ""This entirely avoidable situation? Yes, I'm sorry as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Axel Reinhart: ""I truly hope we can come to a peaceful resolution throug..."*)

### Węzeł `[818]`
Mówca: **Axel Reinhart**
> ""You do not want to test the strength of the Palesian navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Axel Reinhart: ""I truly hope we can come to a peaceful resolution throug..."*)

### Węzeł `[819]`
Mówca: **Axel Reinhart**
> ""You're playing a very dangerous game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Axel Reinhart: ""I truly hope we can come to a peaceful resolution throug..."*)

### Węzeł `[820]`
Mówca: **Axel Reinhart**
> ""I truly hope we can come to a peaceful resolution through the Alliance of Nations. For your sake, mostly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Narrator: "Duke Reinhart's secretary opened the door. He stood up an..."*)

### Węzeł `[821]`
Mówca: **Narrator**
> "Duke Reinhart's secretary opened the door. He stood up and gestured for me to do the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Axel Reinhart: ""I'll see you in court, King Romus.""*)

### Węzeł `[822]`
Mówca: **Axel Reinhart**
> ""I'll see you in court, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Player_Romus: ""Until then, Duke Reinhart.""*)
  - -> `[824]` (*Player_Romus: ""Goodbye, Your Grace.""*)
  - -> `[825]` (*Player_Romus: ""See you on the battlefield.""*)

### Węzeł `[823]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until then, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[822]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = tru..."*)

### Węzeł `[824]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[822]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = tru..."*)

### Węzeł `[825]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you on the battlefield.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[822]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = tru..."*)

### Węzeł `[827]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we'll just have to do our fighting elsewhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[803]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Axel Reinhart: ""I truly hope you don't mean that.""*)

### Węzeł `[828]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was only posturing. I have no intention of inciting conflict.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[803]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Axel Reinhart: ""Nor do I. But accidents happen.""*)

### Węzeł `[829]`
Mówca: **Axel Reinhart**
> ""I truly hope you don't mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Axel Reinhart: ""With luck, the arbitration proceedings will conclude bef..."*)

### Węzeł `[830]`
Mówca: **Axel Reinhart**
> ""Believe me, Pales would not surrender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Axel Reinhart: ""With luck, the arbitration proceedings will conclude bef..."*)

### Węzeł `[831]`
Mówca: **Axel Reinhart**
> ""Nor do I. But accidents happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Axel Reinhart: ""With luck, the arbitration proceedings will conclude bef..."*)

### Węzeł `[832]`
Mówca: **Axel Reinhart**
> ""With luck, the arbitration proceedings will conclude before mistakes are made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Axel Reinhart: ""And with more luck, you will send your ships away peacef..."*)

### Węzeł `[833]`
Mówca: **Axel Reinhart**
> ""And with more luck, you will send your ships away peacefully when you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's presumptuous of you, Your Grace. You'll find no s..."*)
  - -> `[795]` (*Player_Romus: ""What makes you think we will lose? Remember that we have..."*)
  - -> `[811]` (*Player_Romus: ""I will respect whatever the AN decides, as long as their..."*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Axel Reinhart: ""I most certainly am not.""*)

### Węzeł `[835]`
Mówca: **Axel Reinhart**
> ""I am all for arbitration. Just wanted to save you the hassle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Player_Romus: ""I am not backing down. We will have to enter arbitration.""*)
  - -> `[862]` (*Player_Romus: ""You know what? You're obviously more desperate for this ..."*)

### Węzeł `[836]`
Mówca: **Axel Reinhart**
> ""Not after your past animosity towards the Grand Duchy. And certainly not after your naval blockade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Axel Reinhart: ""Either you cede us the field -- sparing us both a long a..."*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[838]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Axel Reinhart: ""Not after your past animosity towards the Grand Duchy. A..."*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Axel Reinhart: ""I'm afraid your naval blockade has precluded any chance ..."*)

### Węzeł `[840]`
Mówca: **Axel Reinhart**
> ""I'm afraid your naval blockade has precluded any chance of doing business with Pales, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Axel Reinhart: ""Either you cede us the field -- sparing us both a long a..."*)

### Węzeł `[841]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll easily rule that Pales acted in direct violation of the AN Directive on Offshore Resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[761]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Axel Reinhart: ""A directive we never ratified.""*)

### Węzeł `[842]`
Mówca: **Axel Reinhart**
> ""And even if it applies, ANDOR is not black and white. It's very nuanced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]` (*Player_Romus: ""It's only nuanced compared to its predecessors. It doesn..."*)
  - -> `[844]` (*Player_Romus: ""We have the support of the international community. Pale..."*)
  - -> `[845]` (*Player_Romus: ""The rules over our maritime borders seem clear to me. An..."*)

### Węzeł `[843]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's only nuanced compared to its predecessors. It doesn't stand alone as a brilliant piece of legislation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[842]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Axel Reinhart: ""It's nuanced enough that I believe Pales will get the be..."*)

### Węzeł `[844]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have the support of the international community. Pales doesn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[842]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Axel Reinhart: ""We have the backing of Lespia, which has the backing of ..."*)

### Węzeł `[845]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rules over our maritime borders seem clear to me. And to my councilors as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[842]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Axel Reinhart: ""Let's see if the AN sees it that way.""*)

### Węzeł `[846]`
Mówca: **Axel Reinhart**
> ""A directive we never ratified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Axel Reinhart: ""And even if it applies, ANDOR is not black and white. It..."*)

### Węzeł `[847]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Player_Romus: ""Your intimidation won't work on me.""*)
  - -> `[851]` (*Player_Romus: ""You're forgetting the support we have from Rumburg and G..."*)
  - -> `[858]` (*Player_Romus: ""The rest of Southern Merkopa will take my side.""*)
  - -> `[849]` (*Player_Romus: ""You shouldn't place so much trust in Lespia, Your Grace.""*)

### Węzeł `[848]`
Mówca: **Axel Reinhart**
> ""It's nuanced enough that I believe Pales will get the benefit of the doubt. Especially with international help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Player_Romus: ""Your intimidation won't work on me.""*)
  - -> `[851]` (*Player_Romus: ""You're forgetting the support we have from Rumburg and G..."*)
  - -> `[858]` (*Player_Romus: ""The rest of Southern Merkopa will take my side.""*)
  - -> `[849]` (*Player_Romus: ""You shouldn't place so much trust in Lespia, Your Grace.""*)

### Węzeł `[849]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't place so much trust in Lespia, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[847]` (Axel Reinhart), `[848]` (Axel Reinhart), `[857]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Axel Reinhart: ""And you should not underestimate them. Or us.""*)

### Węzeł `[850]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your intimidation won't work on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[847]` (Axel Reinhart), `[848]` (Axel Reinhart), `[857]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]` (*Axel Reinhart: ""It's not intimidation. I'm just stating the facts.""*)

### Węzeł `[851]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're forgetting the support we have from Rumburg and GRACE.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[847]` (Axel Reinhart), `[848]` (Axel Reinhart), `[857]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Axel Reinhart: ""This is the 20th century, Your Majesty. Dying monarchies..."*)

### Węzeł `[852]`
Mówca: **Axel Reinhart**
> ""This is the 20th century, Your Majesty. Dying monarchies don't have as much clout as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Axel Reinhart: ""I'm telling you, if you cede the gas field to us without..."*)

### Węzeł `[853]`
Mówca: **Axel Reinhart**
> ""Will they? After you've shown that you'll deploy your military at the drop of a hat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Axel Reinhart: ""I'm telling you, if you cede the gas field to us without..."*)

### Węzeł `[854]`
Mówca: **Axel Reinhart**
> ""And you should not underestimate them. Or us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Axel Reinhart: ""I'm telling you, if you cede the gas field to us without..."*)

### Węzeł `[855]`
Mówca: **Axel Reinhart**
> ""Let's see if the AN sees it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Axel Reinhart: ""Remember, we have the backing of Lespia, which has the b..."*)

### Węzeł `[856]`
Mówca: **Axel Reinhart**
> ""It's not intimidation. I'm just stating the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Axel Reinhart: ""I'm telling you, if you cede the gas field to us without..."*)

### Węzeł `[857]`
Mówca: **Axel Reinhart**
> ""Remember, we have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Player_Romus: ""Your intimidation won't work on me.""*)
  - -> `[851]` (*Player_Romus: ""You're forgetting the support we have from Rumburg and G..."*)
  - -> `[858]` (*Player_Romus: ""The rest of Southern Merkopa will take my side.""*)
  - -> `[849]` (*Player_Romus: ""You shouldn't place so much trust in Lespia, Your Grace.""*)

### Węzeł `[858]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rest of Southern Merkopa will take my side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[847]` (Axel Reinhart), `[848]` (Axel Reinhart), `[857]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Axel Reinhart: ""Will they? After you've shown that you'll deploy your mi..."*)

### Węzeł `[859]`
Mówca: **Axel Reinhart**
> ""Either you cede us the field -- sparing us both a long and costly process -- or we call in the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Player_Romus: ""I am not backing down. We will have to enter arbitration.""*)
  - -> `[862]` (*Player_Romus: ""You know what? You're obviously more desperate for this ..."*)

### Węzeł `[860]`
Mówca: **Axel Reinhart**
> ""I'm telling you, if you cede the gas field to us without argument, you'll be able to avoid a long and costly process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Player_Romus: ""I am not backing down. We will have to enter arbitration.""*)
  - -> `[862]` (*Player_Romus: ""You know what? You're obviously more desperate for this ..."*)

### Węzeł `[861]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not backing down. We will have to enter arbitration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[769]` (Axel Reinhart), `[771]` (Axel Reinhart), `[773]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = tru..."*)

### Węzeł `[862]`
**[WYBÓR GRACZA: ""You know what? You're obviously more desperate for this gas field than we are. Keep it if you like." [Cede Field]"]** — Mówca: **Player_Romus**
> ""You know what? You're obviously more desperate for this gas field than we are. Keep it if you like.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[769]` (Axel Reinhart), `[771]` (Axel Reinhart), `[773]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLCSu..."*)

### Węzeł `[863]`
Mówca: **Axel Reinhart**
> ""So be it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Peaceful Arbitration]"*)

### Węzeł `[864]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End Peaceful Arbitration]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "End Peaceful Arbitration"*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1; RiziaDLC..."*)

### Węzeł `[866]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1;
RiziaDLC.War_Pales_PublicWarSupport += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;
Variable["RiziaDLC.War_Pales_PublicWarSupport"] = Variable["RiziaDLC.War_Pales_PublicWarSupport"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false;..."*)

### Węzeł `[867]`
Mówca: **Narrator**
> "Duke Reinhart blinked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Axel Reinhart: ""That's it?""*)

### Węzeł `[868]`
Mówca: **Axel Reinhart**
> ""That's it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Axel Reinhart: ""Thank you. I guess.""*)

### Węzeł `[869]`
Mówca: **Axel Reinhart**
> ""Thank you. I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]` (*Player_Romus: ""You and Lespia will both be first against the wall when ..."*)
  - -> `[870]` (*Player_Romus: ""It's a small price to pay for a chance at reconciliation.""*)
  - -> `[871]` (*Player_Romus: ""All I ask in return is that you remember our generosity.""*)
  - -> `[872]` (*Player_Romus: ""I am hoping that this gives us a chance for cooperation ..."*)

### Węzeł `[870]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a small price to pay for a chance at reconciliation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[869]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]` (*Axel Reinhart: ""You sent your navy after us, now you speak of reconcilia..."*)

### Węzeł `[871]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I ask in return is that you remember our generosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[869]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Axel Reinhart: ""You sent your navy after us, now you expect us to praise..."*)

### Węzeł `[872]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am hoping that this gives us a chance for cooperation in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[869]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]` (*Axel Reinhart: ""You sent your navy after us, and now you speak of cooper..."*)

### Węzeł `[873]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and Lespia will both be first against the wall when the revolution comes, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[869]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[874]`
Mówca: **Axel Reinhart**
> ""You sent your navy after us, now you speak of reconciliation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Axel Reinhart: ""I am glad that you saw reason and backed down. But I do ..."*)

### Węzeł `[875]`
Mówca: **Axel Reinhart**
> ""You sent your navy after us, now you expect us to praise your generosity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Axel Reinhart: ""I am glad that you saw reason and backed down. But I do ..."*)

### Węzeł `[876]`
Mówca: **Axel Reinhart**
> ""I am glad that you saw reason and backed down. But I do not wish to have any dealings with Rizia in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Narrator: "Reinhart reached under his table and pressed an intercom ..."*)

### Węzeł `[877]`
Mówca: **Narrator**
> "He reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Cede Field]"*)

### Węzeł `[878]`
Mówca: **Narrator**
> "Reinhart reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Cede Field]"*)

### Węzeł `[879]`
Mówca: **Axel Reinhart**
> ""You sent your navy after us, and now you speak of cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Axel Reinhart: ""I am glad that you saw reason and backed down. But I do ..."*)

### Węzeł `[880]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Narrator: "Reinhart scowled."*)

### Węzeł `[881]`
Mówca: **Axel Reinhart**
> ""Are you serious? If anyone's in danger from the so-called revolution, it's your limping monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]` (*Narrator: "He reached under his table and pressed an intercom button."*)

### Węzeł `[882]`
Mówca: **Narrator**
> "Reinhart scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Axel Reinhart: ""Are you serious? If anyone's in danger from the so-calle..."*)

### Węzeł `[883]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End Cede Field]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "End Cede Field"*)

### Węzeł `[884]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.PersonalValue_Pacifist -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Narrator: "His nostrils flared."*)

### Węzeł `[885]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.PersonalValue_Pacifist -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Narrator: "His nostrils flared."*)

### Węzeł `[886]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1; RiziaDLC..."*)

### Węzeł `[887]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]` (*Narrator: "Duke Reinhart blinked."*)

### Węzeł `[888]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower += 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Axel Reinhart: ""Really?""*)

### Węzeł `[889]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false"*)
  - -> `[891]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)"*)

### Węzeł `[890]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""As a matter of fact, I'm sending naval reinforcements to..."*)

### Węzeł `[891]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[892]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false"*)
  - -> `[894]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)"*)

### Węzeł `[893]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Player_Romus: ""Furthermore, I'm sending naval reinforcements to prevent..."*)

### Węzeł `[894]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[895]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Axel Reinhart: ""If there's truly no other choice, then I will gladly agr..."*)

### Węzeł `[896]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Axel Reinhart: ""Not the outcome I was hoping for. But I accept.""*)

### Węzeł `[897]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[906]` (*Narrator: "The Duke gritted his teeth."*)

### Węzeł `[898]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[899]`
Mówca: **Narrator**
> "An upfront fee, an annual extraction rights payment, and in exchange, a stable annual energy supply from the gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[918]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)

### Węzeł `[900]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower += 2; RiziaDLC...."*)

### Węzeł `[901]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[903]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[902]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[904]` (*Axel Reinhart: ""I'm sure you could hold your own in that arena, Your Maj..."*)

### Węzeł `[903]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Axel Reinhart: ""Are you joking? You would lose in an instant.""*)

### Węzeł `[904]`
Mówca: **Axel Reinhart**
> ""I'm sure you could hold your own in that arena, Your Majesty. But no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Axel Reinhart: ""We're going to arbitration. And Rizia will lose.""*)

### Węzeł `[905]`
Mówca: **Axel Reinhart**
> ""We're going to arbitration. And Rizia will lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's presumptuous of you, Your Grace. You'll find no s..."*)
  - -> `[795]` (*Player_Romus: ""What makes you think we will lose? Remember that we have..."*)
  - -> `[812]` (*Player_Romus: ""I knew the Duke of Pales would be too cowardly to arm wr..."*)

### Węzeł `[906]`
Mówca: **Narrator**
> "The Duke gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[916]` (*Axel Reinhart: ""I'm sorry it had to come to that.""*)

### Węzeł `[907]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_TitusLeadsInvestigation = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""I couldn't care less. I'm sure they're guilty of *someth..."*)
  - -> `[195]` (*Player_Romus: ""I hope Rico was right about them not cracking under pres..."*)
  - -> `[196]` (*Player_Romus: ""Poor bastards.""*)

### Węzeł `[908]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Axel Reinhart: ""I never cared for those old Wruhecist saws.""*)

### Węzeł `[909]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]` (*Axel Reinhart: ""So be it, Your Majesty.""*)

### Węzeł `[910]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe we're done here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[916]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false;..."*)

### Węzeł `[911]`
**[WYBÓR GRACZA: ""Furthermore, since you were unable to offer us anything, I will not be recalling my fleet after all. Our navy will stay at the field until arbitration is through." [Continue Blockade]"]** — Mówca: **Player_Romus**
> ""Furthermore, since you were unable to offer us anything, I will not be recalling my fleet after all. Our navy will stay at the field until arbitration is through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[916]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1; RiziaDLC..."*)

### Węzeł `[912]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As am I.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[916]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false;..."*)

### Węzeł `[913]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Narrator: "His jaw twitched."*)

### Węzeł `[914]`
Mówca: **Narrator**
> "His jaw twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]` (*Axel Reinhart: ""That's a big mistake.""*)

### Węzeł `[915]`
Mówca: **Axel Reinhart**
> ""That's a big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Węzeł Logiki Narracyjnej: "Jump to: [End Peaceful Arbitration]"*)

### Węzeł `[916]`
Mówca: **Axel Reinhart**
> ""I'm sorry it had to come to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[911]` (*Player_Romus: ""Furthermore, since you were unable to offer us anything,..."*)
  - -> `[912]` (*Player_Romus: ""As am I.""*)
  - -> `[910]` (*Player_Romus: ""I believe we're done here.""*)

### Węzeł `[917]`
Mówca: **Narrator**
> "It was an extremely large sum, more than our treasury could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""On second thought, this is insulting. My kingdom will no..."*)
  - -> `[434]` (*Player_Romus: ""Sorry, but there's no way Rizia can pay this much.""*)
  - -> `[439]` (*Player_Romus: ""Can't I just buy the rights to part of the field?""*)

### Węzeł `[918]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[919]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true"*)
  - -> `[920]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)"*)

### Węzeł `[919]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[924]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 10"*)

### Węzeł `[920]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[921]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)

### Węzeł `[921]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[922]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true"*)
  - -> `[923]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average ==..."*)

### Węzeł `[922]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 8"*)

### Węzeł `[923]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[927]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 6"*)

### Węzeł `[924]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[925]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 10"*)
  - -> `[926]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 10)"*)

### Węzeł `[925]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[930]` (*Narrator: "It was a ridiculously large sum, but our treasury could a..."*)

### Węzeł `[926]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[931]` (*Narrator: "It was a ridiculously large sum, much more than our treas..."*)

### Węzeł `[927]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[928]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 6"*)
  - -> `[929]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 6)"*)

### Węzeł `[928]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[932]` (*Narrator: "It was a very large sum, but our treasury could afford it."*)

### Węzeł `[929]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "It was more than our treasury could afford."*)

### Węzeł `[930]`
Mówca: **Narrator**
> "It was a ridiculously large sum, but our treasury could afford it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]` (*Player_Romus: ""Seems reasonable to me. You have a deal, Duke Reinhart."..."*)
  - -> `[408]` (*Player_Romus: ""That's far too much. Can't you go any lower?""*)
  - -> `[436]` (*Player_Romus: ""Can't I just buy the rights to part of the field?""*)
  - -> `[437]` (*Player_Romus: ""On second thought, this is insulting. My kingdom will no..."*)

### Węzeł `[931]`
Mówca: **Narrator**
> "It was a ridiculously large sum, much more than our treasury could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""On second thought, this is insulting. My kingdom will no..."*)
  - -> `[434]` (*Player_Romus: ""Sorry, but there's no way Rizia can pay this much.""*)
  - -> `[439]` (*Player_Romus: ""Can't I just buy the rights to part of the field?""*)

### Węzeł `[932]`
Mówca: **Narrator**
> "It was a very large sum, but our treasury could afford it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player_Romus: ""Seems reasonable to me. You have a deal, Duke Reinhart."..."*)
  - -> `[408]` (*Player_Romus: ""That's far too much. Can't you go any lower?""*)
  - -> `[436]` (*Player_Romus: ""Can't I just buy the rights to part of the field?""*)
  - -> `[437]` (*Player_Romus: ""On second thought, this is insulting. My kingdom will no..."*)

### Węzeł `[933]`
**[WYBÓR GRACZA: ""Seems reasonable to me. You have a deal, Duke Reinhart." [-10 Budget Now, -2 Budget Per Turn Now, -5 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Seems reasonable to me. You have a deal, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[930]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[943]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 10; RiziaDLC.Budget_Modifier..."*)

### Węzeł `[934]`
**[WYBÓR GRACZA: ""Seems reasonable to me. You have a deal, Duke Reinhart." [-8 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Seems reasonable to me. You have a deal, Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[944]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 8; RiziaDLC.Budget_Modifier_..."*)

### Węzeł `[935]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Dipl..."*)
  - -> `[937]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Di..."*)

### Węzeł `[936]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[941]` (*Player_Romus: ""Very well, Your Grace. You have a deal." [-8 Budget Now,..."*)

### Węzeł `[937]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[938]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Dip..."*)

### Węzeł `[938]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.CountryRelation_Pales_Friendly == true) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[939]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Dip..."*)
  - -> `[940]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_D..."*)

### Węzeł `[939]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.CountryRelation_Pales_Friendly == true) == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 6  and  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[942]` (*Player_Romus: ""Very well, Your Grace. You have a deal." [-6 Budget Now,..."*)

### Węzeł `[940]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.CountryRelation_Pales_Friendly == true) == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 6  and  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true) == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[941]`
**[WYBÓR GRACZA: ""Very well, Your Grace. You have a deal." [-8 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. You have a deal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true` AND `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[455]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[948]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 8; RiziaDLC.Budget_Modifier_..."*)

### Węzeł `[942]`
**[WYBÓR GRACZA: ""Very well, Your Grace. You have a deal." [-6 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. You have a deal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 6  and  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true) == true` AND `(Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false` AND `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[455]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[949]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 6; RiziaDLC.Budget_Modifier_..."*)

### Węzeł `[943]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 10;
RiziaDLC.Budget_Modifier_PalesTrade = -5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 10;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[944]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 8;
RiziaDLC.Budget_Modifier_PalesTrade = -4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 8;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[945]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 6;
RiziaDLC.Budget_Modifier_PalesTrade = -4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 6;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[946]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy = true; RiziaDLC.Si..."*)

### Węzeł `[947]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 10;
RiziaDLC.Budget_Modifier_PalesTrade = -5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 10;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[948]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 8;
RiziaDLC.Budget_Modifier_PalesTrade = -4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 8;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[949]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 6;
RiziaDLC.Budget_Modifier_PalesTrade = -4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 6;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[950]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy = true; RiziaDLC.Si..."*)

### Węzeł `[951]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true) || (RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true) || (RiziaDLC.Resources_Budget >= 6 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == false && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[952]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Di..."*)
  - -> `[953]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_..."*)

### Węzeł `[952]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true) || (RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true) || (RiziaDLC.Resources_Budget >= 6 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == false && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 6  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == false  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]` (*Player_Romus: ""We can afford the deal if we need to. But I was hoping f..."*)

### Węzeł `[953]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true) || (RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true) || (RiziaDLC.Resources_Budget >= 6 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == false && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 6  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == false  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[954]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can afford the deal if we need to. But I was hoping for a neighborly discount.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 6  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == false  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false)`
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[453]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[955]` (*Axel Reinhart: ""This *is* my discount.""*)

### Węzeł `[955]`
Mówca: **Axel Reinhart**
> ""This *is* my discount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Axel Reinhart: ""Unfortunately, if you can't purchase the rights to the e..."*)

### Węzeł `[956]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Choosing between peace and war", "Castle Reinhart", "Grand-Duchy of Pales");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Choosing between peace and war","Castle Reinhart","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");"*)
