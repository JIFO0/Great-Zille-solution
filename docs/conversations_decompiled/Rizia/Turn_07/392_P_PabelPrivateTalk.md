# Rizia/Turn 7/P_PabelPrivateTalk

- **ID konwersacji:** `392`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/392_P_PabelPrivateTalk.md`
- **Liczba węzłów dialogowych:** 769
- **Liczba wyborów gracza:** 199

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.DiscussedDerdianHomosexuality`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Law_GolcondistBlasphemy`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs`
- `RiziaDLC.Situation_Welfare_LivingStandards_Average`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn02_Diplomacy_Intention_GRACE`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn07_Duel_Success`
- `RiziaDLCIsolated.Turn07_Duel_TitusFights`
- `RiziaDLCIsolated.Turn07_PabelTalk_Clothed`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLCIsolated.Turn07_PabelTalk_Clothed`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Who is it?""** | `[3]` **Narrator**: "Early in the morning, I heard a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "There was no reply, just another..." |
| `[5]` | **""Go away. I don't have to be up for another hour.""** | `[3]` **Narrator**: "Early in the morning, I heard a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "There was no reply, just another..." |
| `[6]` | **""Bruno, can you open the door?""** | `[3]` **Narrator**: "Early in the morning, I heard a ..." | `Variable["RiziaDLC.BrunoDog_Adopted"] == true` | `AddConversant("Bruno");` | `[10]` **Narrator**: "Bruno jumped off my bed, ran to ..."<br>`[14]` **Narrator**: "Bruno ran to the door and began ..." |
| `[16]` | **"Pretend to be asleep."** | `[3]` **Narrator**: "Early in the morning, I heard a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "There were a few seconds of sile..." |
| `[20]` | **"Pick it up."** | `[19]` **Narrator**: "As I was about to open it, I not..." | *Brak (Dostępna bezwarunkowo)* | `EnableCollectionItem("CollectionItem_PoemScroll"); ;` | `[21]` **Narrator**: ""Find me in the labyrinth of pas..." |
| `[29]` | **""I'm going for a walk. No need to accompany me.""** | `[24]` **Narrator**: "Bruno followed me out of my bedr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Titus nodded." |
| `[30]` | **""Who was at my door just now?""** | `[24]` **Narrator**: "Bruno followed me out of my bedr..."<br>`[28]` **Narrator**: "I walked out of my bedroom and r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Titus Gordion**: ""Your butler, Your Majesty. I to..." |
| `[31]` | **""You don't sleep much, do you?""** | `[24]` **Narrator**: "Bruno followed me out of my bedr..."<br>`[28]` **Narrator**: "I walked out of my bedroom and r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Titus Gordion**: ""Not since Derdia. I can't belie..."<br>`[93]` **Titus Gordion**: ""Not since the events in Wehlen...." |
| `[41]` | **"Go straight ahead."** | `[64]` **Narrator**: "I made my way to the maze. Its e..."<br>`[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[42]` | **"Go right."** | `[64]` **Narrator**: "I made my way to the maze. Its e..."<br>`[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[43]` | **"Go left."** | `[64]` **Narrator**: "I made my way to the maze. Its e..."<br>`[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[45]` **Player_Romus_Italic**: "I walked to the right until I ca..."<br>*(oraz 2 innych odgałęzień)* |
| `[44]` | **"Go straight ahead."** | `[43]` **Player_Romus_Italic**: "I walked to the left until I cam..."<br>`[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[45]` | **"Go right."** | `[43]` **Player_Romus_Italic**: "I walked to the left until I cam..."<br>`[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[49]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych odgałęzień)* |
| `[46]` | **"Go backwards."** | `[41]` **Player_Romus_Italic**: "I walked straight ahead and enco..."<br>`[42]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Player_Romus_Italic**: "I walked straight ahead and enco..."<br>`[42]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 1 innych odgałęzień)* |
| `[47]` | **"Go left."** | `[43]` **Player_Romus_Italic**: "I walked to the left until I cam..."<br>`[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[48]` | **"Go straight ahead."** | `[45]` **Player_Romus_Italic**: "I walked to the right until I ca..."<br>`[52]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[55]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych odgałęzień)* |
| `[49]` | **"Go right."** | `[45]` **Player_Romus_Italic**: "I walked to the right until I ca..."<br>`[52]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[50]` | **"Go backwards."** | `[44]` **Player_Romus_Italic**: "I walked straight ahead and enco..."<br>`[47]` **Player_Romus_Italic**: "I walked to the left and encount..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[45]` **Player_Romus_Italic**: "I walked to the right until I ca..."<br>*(oraz 2 innych odgałęzień)* |
| `[51]` | **"Go left."** | `[45]` **Player_Romus_Italic**: "I walked to the right until I ca..."<br>`[52]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[52]` | **"Go backwards."** | `[49]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>`[51]` **Player_Romus_Italic**: "I walked to the left and encount..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[49]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych odgałęzień)* |
| `[53]` | **"Go left."** | `[74]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[65]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 1 innych odgałęzień)* |
| `[54]` | **"Go left."** | `[48]` **Player_Romus_Italic**: "I walked straight ahead. I knew ..."<br>`[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[55]` | **"Go right."** | `[48]` **Player_Romus_Italic**: "I walked straight ahead. I knew ..."<br>`[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[56]` | **"Go straight ahead."** | `[48]` **Player_Romus_Italic**: "I walked straight ahead. I knew ..."<br>`[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[57]` | **"Go right."** | `[74]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[58]` | **"Go backwards."** | `[54]` **Player_Romus_Italic**: "I walked to the left and encount..."<br>`[55]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[55]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych odgałęzień)* |
| `[59]` | **"Go straight ahead."** | `[74]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[60]` | **"Go left."** | `[53]` **Player_Romus_Italic**: "Looking to the left, I noticed a..."<br>`[79]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "Pabel was sitting there, waiting..." |
| `[62]` | **""It was a lovely poem. But between the war and everything else going on, I'm reall..."** | `[61]` **Narrator**: "Pabel was sitting there, waiting..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[85]` **Narrator**: "He gave a brief sigh of disappoi..." |
| `[63]` | **"Take it."** | `[61]` **Narrator**: "Pabel was sitting there, waiting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "By the time we finally spoke, th..." |
| `[65]` | **"Go right."** | `[53]` **Player_Romus_Italic**: "Looking to the left, I noticed a..."<br>`[79]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Player_Romus_Italic**: "I retraced my steps to the previ..." |
| `[66]` | **"Go backwards."** | `[57]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>`[59]` **Player_Romus_Italic**: "I walked straight ahead and enco..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[57]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych odgałęzień)* |
| `[74]` | **"Go backwards."** | `[48]` **Player_Romus_Italic**: "I walked straight ahead. I knew ..."<br>`[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[57]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 2 innych odgałęzień)* |
| `[79]` | **"Go backwards."** | `[65]` **Player_Romus_Italic**: "I walked to the right and encoun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Player_Romus_Italic**: "I retraced my steps to the previ..."<br>`[65]` **Player_Romus_Italic**: "I walked to the right and encoun..."<br>*(oraz 1 innych odgałęzień)* |
| `[84]` | **""It was a lovely poem. But considering everything that's been going on, I'm not re..."** | `[61]` **Narrator**: "Pabel was sitting there, waiting..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[85]` **Narrator**: "He gave a brief sigh of disappoi..." |
| `[96]` | **""I'll find him myself.""** | `[94]` **Titus Gordion**: ""Your butler was just here. Shou..."<br>`[95]` **Titus Gordion**: ""Should I fetch him now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Titus Gordion**: ""Understood, Your Majesty. Enjoy..." |
| `[97]` | **""No need. I'm just going for a quick walk.""** | `[94]` **Titus Gordion**: ""Your butler was just here. Shou..."<br>`[95]` **Titus Gordion**: ""Should I fetch him now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Titus Gordion**: ""Understood, Your Majesty. Enjoy..." |
| `[98]` | **""Keep guarding my room. I'll be back shortly.""** | `[94]` **Titus Gordion**: ""Your butler was just here. Shou..."<br>`[95]` **Titus Gordion**: ""Should I fetch him now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Titus Gordion**: ""Understood, Your Majesty. Enjoy..." |
| `[100]` | **""That was... a-maze-ing.""** | `[89]` **Narrator**: "By the time we finally spoke, th..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[104]` **Narrator**: "Pabel gave a short laugh. He sat..." |
| `[105]` | **""Another day, another illicit meeting spot.""** | `[89]` **Narrator**: "By the time we finally spoke, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Pabel Adria**: ""You must admit it's more comfor..." |
| `[106]` | **""Do you think Titus knows about us yet?""** | `[89]` **Narrator**: "By the time we finally spoke, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Pabel Adria**: ""He's got eyes everywhere. But i..."<br>`[112]` **Pabel Adria**: ""He knows we're friends. I doubt..." |
| `[123]` | **""Is that the man you were with in the wine cellar?""** | `[130]` **Pabel Adria**: ""Montalvo had recently been jail..." | `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)` | *Brak zmian stanu* | `[127]` **Narrator**: "Pabel nodded, his teeth clenched." |
| `[124]` | **""With a client? Was he mad?""** | `[130]` **Pabel Adria**: ""Montalvo had recently been jail..." | `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)) == false` | *Brak zmian stanu* | `[136]` **Pabel Adria**: ""No madder than a king doing the..." |
| `[125]` | **""Did you know him?""** | `[130]` **Pabel Adria**: ""Montalvo had recently been jail..." | `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)) == false` | *Brak zmian stanu* | `[128]` **Narrator**: "Pabel nodded, his teeth clenched." |
| `[131]` | **""Oh, no. Was he arrested because of my investigation?""** | `[130]` **Pabel Adria**: ""Montalvo had recently been jail..." | `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)` | *Brak zmian stanu* | `[134]` **Narrator**: "Pabel shook his head." |
| `[133]` | **""This is happening in Rizia's prisons? I'll have to improve security there at once.""** | `[130]` **Pabel Adria**: ""Montalvo had recently been jail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "Pabel shook his head." |
| `[138]` | **""It's a disgrace that this was allowed to occur during my reign.""** | `[130]` **Pabel Adria**: ""Montalvo had recently been jail..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Pabel nodded, his teeth clenched." |
| `[140]` | **""People like *us*? I'm not a homosexual.""** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "Pabel gaped at me in astonishmen..." |
| `[141]` | **""I am working to achieve parity between commoners and nobles. I can't let the prob..."** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true` | *Brak zmian stanu* | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..." |
| `[151]` | **""Your Mateus was a sinner, and so are we. I can barely stomach such behavior, let ..."** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[159]` **Narrator**: "Pabel sighed in frustration." |
| `[152]` | **""I've been wanting to get rid of that law since I became king. But I'm afraid I do..."** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | `Variable["RiziaDLC.Resources_Authority"] <= 4` | *Brak zmian stanu* | `[163]` **Pabel Adria**: ""If you care about me -- about u..." |
| `[155]` | **""We shouldn't. I think Titus is starting to get suspicious.""** | `[61]` **Narrator**: "Pabel was sitting there, waiting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "He groaned quietly and withdrew ..." |
| `[157]` | **""You missed your calling. You should've become a poet.""** | `[89]` **Narrator**: "By the time we finally spoke, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Pabel Adria**: ""I'd be living in the gutter. An..." |
| `[164]` | **""There are only so many decrees I can make as king. I have to prioritize.""** | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..."<br>`[696]` **Pabel Adria**: ""Why would it have to be at anyo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Pabel Adria**: ""Then please. Prioritize this one."" |
| `[165]` | **""I've made so much progress for Rizia's working class. They'll see it as a betraya..."** | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..."<br>`[154]` **Pabel Adria**: ""We're talking about basic human..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false` | *Brak zmian stanu* | `[171]` **Pabel Adria**: ""Whose values, exactly? Working-..." |
| `[169]` | **""If I show too much sympathy towards your community, my house will never accept my..."** | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..."<br>`[154]` **Pabel Adria**: ""We're talking about basic human..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true` | *Brak zmian stanu* | `[170]` **Pabel Adria**: ""'My' community. Right."" |
| `[173]` | **""I'm the king. I have the authority. I can make it happen.""** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false` | *Brak zmian stanu* | `[174]` **Pabel Adria**: ""If you care about me -- about u..." |
| `[179]` | **""It's not God that's sick and twisted. It's us.""** | `[178]` **Pabel Adria**: ""You said you felt things with m..."<br>`[180]` **Pabel Adria**: ""You said you felt things with m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "He stood up and brushed himself ..."<br>`[193]` **Narrator**: "He hurriedly started putting his..." |
| `[184]` | **""The same God who let the Palesians take my daughter from me.""** | `[178]` **Pabel Adria**: ""You said you felt things with m..."<br>`[180]` **Pabel Adria**: ""You said you felt things with m..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[194]` **Narrator**: "He put a hand on my shoulder." |
| `[185]` | **""The same God who took my wife away from me.""** | `[180]` **Pabel Adria**: ""You said you felt things with m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Narrator**: "He put a hand on my shoulder." |
| `[186]` | **""A truly devout Wruhecist must abandon all thoughts of earthly pleasure if he is t..."** | `[178]` **Pabel Adria**: ""You said you felt things with m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "He stood up and brushed himself ..."<br>`[193]` **Narrator**: "He hurriedly started putting his..." |
| `[203]` | **""Yes, all right. Point taken.""** | `[202]` **Pabel Adria**: ""Or do you think a jury would le..."<br>`[144]` **Pabel Adria**: ""Call yourself what you want. It..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[207]` **Pabel Adria**: ""It's not too late to change the..." |
| `[204]` | **""I am attracted to human beings. Whether they're male or female is of no consequen..."** | `[202]` **Pabel Adria**: ""Or do you think a jury would le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Pabel Adria**: ""Plenty of your subjects feel th..." |
| `[205]` | **""I can turn it on and off, like a light switch. It's not my fault that other peopl..."** | `[202]` **Pabel Adria**: ""Or do you think a jury would le..."<br>`[144]` **Pabel Adria**: ""Call yourself what you want. It..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[260]` **Pabel Adria**: ""Wow. And I thought I knew you."" |
| `[208]` | **""Changing the law would definitely give us an edge with Derdia.""** | `[163]` **Pabel Adria**: ""If you care about me -- about u..."<br>`[174]` **Pabel Adria**: ""If you care about me -- about u..." | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0` | *Brak zmian stanu* | `[228]` **Pabel Adria**: ""For whatever that's worth. Look..." |
| `[212]` | **""If I show too much sympathy towards your community, my house will disown me.""** | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..."<br>`[154]` **Pabel Adria**: ""We're talking about basic human..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false` | *Brak zmian stanu* | `[213]` **Pabel Adria**: ""'My' community. Right."" |
| `[215]` | **""The Dastnurists will hate it, though. What am I supposed to tell Rumburg?""** | `[163]` **Pabel Adria**: ""If you care about me -- about u..."<br>`[174]` **Pabel Adria**: ""If you care about me -- about u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Pabel Adria**: ""Isn't Queen Beatrice a proponen..." |
| `[220]` | **""Still, we're in the middle of a war. It's not the time to go around making huge c..."** | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..."<br>`[154]` **Pabel Adria**: ""We're talking about basic human..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[221]` **Pabel Adria**: ""If not now, then when?"" |
| `[227]` | **""If I take this leap, my house will never forgive me.""** | `[163]` **Pabel Adria**: ""If you care about me -- about u..."<br>`[174]` **Pabel Adria**: ""If you care about me -- about u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[226]` **Pabel Adria**: ""I know you're close with your f..." |
| `[234]` | **""We must both repent, Pabel. Before it's too late.""** | `[232]` **Pabel Adria**: ""I've got to go oversee breakfas..."<br>`[233]` **Pabel Adria**: ""There's still some time before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Pabel Adria**: ""It's already too late for Mateus."" |
| `[235]` | **""I'm sorry. I wish I could see it differently.""** | `[232]` **Pabel Adria**: ""I've got to go oversee breakfas..."<br>`[233]` **Pabel Adria**: ""There's still some time before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Pabel Adria**: ""Don't apologize to me. Apologiz..." |
| `[236]` | **""I will think about what you said. I promise.""** | `[232]` **Pabel Adria**: ""I've got to go oversee breakfas..."<br>`[233]` **Pabel Adria**: ""There's still some time before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Pabel Adria**: ""Please do."" |
| `[237]` | **""Watch your own mouth. You're still speaking to the king.""** | `[233]` **Pabel Adria**: ""There's still some time before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Narrator**: "He stiffly bowed." |
| `[253]` | **""Whether or not I personally agree, classifying it as such would definitely put me..."** | `[661]` **Pabel Adria**: ""Is it really such a stretch to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Pabel Adria**: ""For whatever that's worth. Look..." |
| `[254]` | **""The Dastnurists would hate me if I took that leap.""** | `[661]` **Pabel Adria**: ""Is it really such a stretch to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Pabel Adria**: ""Good thing they're still a mino..." |
| `[255]` | **""I'm still worried about what my house will think.""** | `[661]` **Pabel Adria**: ""Is it really such a stretch to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[226]` **Pabel Adria**: ""I know you're close with your f..." |
| `[256]` | **""It's not a stretch at all. Why is my butler talking more sense than my religious ..."** | `[661]` **Pabel Adria**: ""Is it really such a stretch to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Pabel Adria**: ""Because the Grand Wiseman hasn'..." |
| `[261]` | **""I like guns. I'm not some nancy boy.""** | `[202]` **Pabel Adria**: ""Or do you think a jury would le..."<br>`[144]` **Pabel Adria**: ""Call yourself what you want. It..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`<br>`(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[265]` **Pabel Adria**: ""Really? You're going to buy int..." |
| `[266]` | **""The working class will see it as a betrayal of their values.""** | `[153]` **Pabel Adria**: ""Rom. Any fight for equal rights..."<br>`[154]` **Pabel Adria**: ""We're talking about basic human..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false` | *Brak zmian stanu* | `[171]` **Pabel Adria**: ""Whose values, exactly? Working-..." |
| `[268]` | **""I haven't seen this side of you before and frankly, I'm incredibly turned on by it.""** | `[207]` **Pabel Adria**: ""It's not too late to change the..."<br>`[225]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Narrator**: "Pabel smiled grimly." |
| `[269]` | **""I've already got my council and the House of Delegates telling me what to do. Now..."** | `[207]` **Pabel Adria**: ""It's not too late to change the..."<br>`[225]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "He stood up and brushed himself ..."<br>`[324]` **Narrator**: "He hurriedly started putting his..." |
| `[270]` | **""Even if homosexuality were legal in Rizia, it doesn't mean you and I could be tog..."** | `[207]` **Pabel Adria**: ""It's not too late to change the..."<br>`[225]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Pabel Adria**: ""I know. That's a discussion for..." |
| `[275]` | **""You're right. I have a historic opportunity to change the law. I've got to seize ..."** | `[207]` **Pabel Adria**: ""It's not too late to change the..."<br>`[225]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Pabel Adria**: ""The sooner you do, the more liv..." |
| `[287]` | **""Then keep your mouth shut. You're here to serve me, remember?""** | `[286]` **Pabel Adria**: ""But if this isn't important to ..."<br>`[319]` **Pabel Adria**: ""But if this isn't important to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[294]` **Narrator**: "He stared me down coldly." |
| `[288]` | **""It doesn't make a difference. Even if homosexuality were legal in Rizia, the peop..."** | `[286]` **Pabel Adria**: ""But if this isn't important to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Pabel Adria**: ""This is more important than you..." |
| `[291]` | **""Wait. It's important to me if it's important to you.""** | `[286]` **Pabel Adria**: ""But if this isn't important to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Pabel Adria**: ""This goes beyond either of us i..." |
| `[302]` | **""Not unless you write me another poem.""** | `[301]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[339]` **Pabel Adria**: ""My creative muscles are spent. ..." |
| `[325]` | **""It's important to me. But it won't happen overnight.""** | `[319]` **Pabel Adria**: ""But if this isn't important to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Narrator**: "His expression softened." |
| `[327]` | **""My child might die. That's what's important to me right now.""** | `[319]` **Pabel Adria**: ""But if this isn't important to ..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[669]` **Narrator**: "Pabel put a hand on my shoulder." |
| `[331]` | **""Is that why you're with me? To push your... lavender agenda?""** | `[319]` **Pabel Adria**: ""But if this isn't important to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Narrator**: "He stared me down coldly." |
| `[336]` | **""I'll look into making a decree. I promise.""** | `[301]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Pabel Adria**: ""Thank you."" |
| `[337]` | **""Bi mare volu...""** | `[301]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Pabel Adria**: ""...Un oxit solu."" |
| `[345]` | **""I'm sorry about your lover.""** | `[301]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[583]` **Pabel Adria**: ""He wasn't my lover. But I'm sor..." |
| `[358]` | **""What's going on, Pabel? Are you all right?""** | `[356]` **Narrator**: "There was a tinge of melancholy ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Pabel Adria**: ""I'm fine, thanks for asking."" |
| `[359]` | **""Where's my paper?""** | `[356]` **Narrator**: "There was a tinge of melancholy ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Pabel Adria**: ""I have it. Just give me one mom..." |
| `[360]` | **""I slept wonderfully.""** | `[356]` **Narrator**: "There was a tinge of melancholy ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Pabel Adria**: ""I'm glad to hear it."" |
| `[364]` | **""I won't sleep until we take Pales.""** | `[356]` **Narrator**: "There was a tinge of melancholy ..." | `Variable["RiziaDLC.Pales_War"]` | *Brak zmian stanu* | `[369]` **Pabel Adria**: ""Even a king needs to close his ..."<br>`[587]` **Pabel Adria**: ""Even a king needs to close his ..." |
| `[365]` | **""I won't sleep until we have Zille back.""** | `[356]` **Narrator**: "There was a tinge of melancholy ..." | `(Variable["RiziaDLC.Pales_War"]) == false` | *Brak zmian stanu* | `[369]` **Pabel Adria**: ""Even a king needs to close his ..."<br>`[587]` **Pabel Adria**: ""Even a king needs to close his ..." |
| `[372]` | **""To the land of blasphemous lunatics, you mean? I couldn't be more excited.""** | `[371]` **Pabel Adria**: ""How are preparations going for ..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false` | *Brak zmian stanu* | `[376]` **Pabel Adria**: ""Lunatics, Your Majesty?"" |
| `[380]` | **""It can't be that bad in Rizia. Can it?""** | `[379]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[726]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Narrator**: "His eyes darkened." |
| `[381]` | **""Really? I thought the lure of the forbidden was part of your whole... thing.""** | `[379]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[726]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Narrator**: "He frowned, insulted." |
| `[387]` | **""Something must be done to improve the status of your kind here at home.""** | `[379]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[726]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Pabel Adria**: ""I'm happy you agree."" |
| `[393]` | **""I've been reading up on the Golcondists. Perhaps Rizia has been too harsh to judg..."** | `[371]` **Pabel Adria**: ""How are preparations going for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[590]` **Pabel Adria**: ""Interesting, Your Majesty."" |
| `[397]` | **""I don't have high hopes, to be honest. The Derdians and I have nothing in common.""** | `[371]` **Pabel Adria**: ""How are preparations going for ..." | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0` | *Brak zmian stanu* | `[399]` **Pabel Adria**: ""You know what they say about op..." |
| `[398]` | **""They are going well, thank you. I'm hoping to contract their mercenaries for the ..."** | `[371]` **Pabel Adria**: ""How are preparations going for ..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[403]` **Pabel Adria**: ""I see. I've heard they're very ..." |
| `[402]` | **""I've got high hopes for it. The Derdians and I agree on many points.""** | `[371]` **Pabel Adria**: ""How are preparations going for ..." | `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0) == false` | *Brak zmian stanu* | `[592]` **Pabel Adria**: ""Do you, Your Majesty?"" |
| `[409]` | **""Is that the man you were with in the wine cellar? Allegedly, I mean.""** | `[401]` **Pabel Adria**: ""Montalvo had recently been jail..." | `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false` | *Brak zmian stanu* | `[413]` **Narrator**: "Pabel nodded, his teeth clenched." |
| `[410]` | **""With a client? Was he mad?""** | `[401]` **Pabel Adria**: ""Montalvo had recently been jail..." | `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false` | *Brak zmian stanu* | `[421]` **Pabel Adria**: ""If he's mad, then so am I."" |
| `[411]` | **""Did you know him?""** | `[401]` **Pabel Adria**: ""Montalvo had recently been jail..." | `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false` | *Brak zmian stanu* | `[414]` **Narrator**: "Pabel nodded, his teeth clenched." |
| `[416]` | **""Oh, no. Was he arrested because of my investigation?""** | `[401]` **Pabel Adria**: ""Montalvo had recently been jail..." | `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false` | *Brak zmian stanu* | `[419]` **Narrator**: "Pabel shook his head." |
| `[418]` | **""This is happening in Rizia's prisons? I'll have to improve security there at once.""** | `[401]` **Pabel Adria**: ""Montalvo had recently been jail..." | `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false` | *Brak zmian stanu* | `[412]` **Narrator**: "Pabel shook his head." |
| `[423]` | **""It's a disgrace that this happened during my reign.""** | `[401]` **Pabel Adria**: ""Montalvo had recently been jail..." | `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false` | *Brak zmian stanu* | `[424]` **Narrator**: "Pabel nodded, his teeth clenched." |
| `[426]` | **""Relax. I'm the king. If you ever get found out, I'll just pardon you.""** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Narrator**: "Pabel gave me a look of frustrat..." |
| `[427]` | **""I am working to achieve parity between commoners and nobles. I can't let the prob..."** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true` | *Brak zmian stanu* | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..." |
| `[429]` | **""If the people of Rizia wanted legal homosexuality, my parliament would have broug..."** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Pabel Adria**: ""This is one instance where demo..."<br>`[682]` **Pabel Adria**: ""You know very well that your pa..." |
| `[437]` | **""Your Mateus was a sinner, and so are you. I can barely stomach such behavior, let..."** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[441]` **Narrator**: "Pabel sighed in frustration." |
| `[438]` | **""I've been wanting to get rid of that law since I became king. But I'm afraid it's..."** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | `Variable["RiziaDLC.Resources_Authority"] <= 4` | *Brak zmian stanu* | `[445]` **Pabel Adria**: ""It is a challenge, I know. Not ..." |
| `[446]` | **""There are only so many royal decrees I can make. I have to prioritize.""** | `[678]` **Pabel Adria**: ""Why would it have to be at anyo..."<br>`[682]` **Pabel Adria**: ""You know very well that your pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Pabel Adria**: ""Then as your friend, I beg of y..."<br>`[611]` **Pabel Adria**: ""Then as your butler and humble ..." |
| `[447]` | **""I've made so much progress for Rizia's working class. They'll see it as a betraya..."** | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..."<br>`[440]` **Pabel Adria**: ""This is one instance where demo..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false` | *Brak zmian stanu* | `[452]` **Pabel Adria**: ""Whose values? Working-class hom..." |
| `[451]` | **""If I show too much sympathy towards your community, my house will never accept my..."** | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..."<br>`[440]` **Pabel Adria**: ""This is one instance where demo..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true` | *Brak zmian stanu* | `[498]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[477]` **Pabel Adria**: ""Your approval means as much to ..." |
| `[453]` | **""Rizia is still a majority-Wruhecist country. If I made homosexuality legal, the r..."** | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..."<br>`[440]` **Pabel Adria**: ""This is one instance where demo..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Pabel Adria**: ""I understand the influence Gran..." |
| `[455]` | **""I have the authority. I can change our kingdom's anti-homosexuality laws.""** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false` | *Brak zmian stanu* | `[456]` **Pabel Adria**: ""It's a major step forward, I kn..." |
| `[458]` | **""It's not God that's sick and twisted. It's you. No offense.""** | `[457]` **Pabel Adria**: ""What kind of sick, twisted God ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[553]` **Narrator**: "He hurriedly rose." |
| `[459]` | **""It is true that Wruhecist teachings stress the importance of bringing joy to othe..."** | `[457]` **Pabel Adria**: ""What kind of sick, twisted God ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Pabel Adria**: ""Yes! Precisely!"" |
| `[463]` | **""The same God who let the Palesians take my daughter from me.""** | `[457]` **Pabel Adria**: ""What kind of sick, twisted God ..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[465]` **Narrator**: "His expression turned compassion..." |
| `[464]` | **""The same God who took my wife away from me.""** | `[457]` **Pabel Adria**: ""What kind of sick, twisted God ..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[468]` **Narrator**: "His expression turned compassion..." |
| `[478]` | **""Rizia may be ready, but House Toras is not.""** | `[614]` **Pabel Adria**: ""But Rizia is ready now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[477]` **Pabel Adria**: ""Your approval means as much to ..." |
| `[480]` | **""Repent, Pabel. Before it's too late.""** | `[479]` **Pabel Adria**: ""I've got to go oversee breakfas..."<br>`[560]` **Pabel Adria**: ""I've got to go oversee breakfas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Pabel Adria**: ""It's already too late for Mateus."" |
| `[482]` | **""Personally, I would rather not imagine it. But politically, it'd give us an edge ..."** | `[471]` **Pabel Adria**: ""Is it such a stretch to imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Pabel Adria**: ""As well as with the Golcondists..." |
| `[483]` | **""The Dastnurists would hate me if I took that leap.""** | `[471]` **Pabel Adria**: ""Is it such a stretch to imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Pabel Adria**: ""They are still a minority here...." |
| `[484]` | **""I'm still worried about what my house will think.""** | `[471]` **Pabel Adria**: ""Is it such a stretch to imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[477]` **Pabel Adria**: ""Your approval means as much to ..." |
| `[485]` | **""It's not a stretch at all. Why is my butler talking more sense than my religious ..."** | `[471]` **Pabel Adria**: ""Is it such a stretch to imagine..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[486]` **Pabel Adria**: ""Because the Grand Wiseman hasn'..." |
| `[490]` | **""A truly devout Wruhecist must abandon all thoughts of earthly pleasure if he is t..."** | `[457]` **Pabel Adria**: ""What kind of sick, twisted God ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[553]` **Narrator**: "He hurriedly rose." |
| `[492]` | **""Decriminalizing homosexuality will definitely give us an edge with Derdia.""** | `[614]` **Pabel Adria**: ""But Rizia is ready now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Pabel Adria**: ""As well as with the Golcondists..." |
| `[494]` | **""If I show too much sympathy towards your community, my house will disown me.""** | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..."<br>`[440]` **Pabel Adria**: ""This is one instance where demo..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false` | *Brak zmian stanu* | `[498]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[477]` **Pabel Adria**: ""Your approval means as much to ..." |
| `[499]` | **""The Dastnurists will hate it, though. What am I supposed to tell Rumburg?""** | `[614]` **Pabel Adria**: ""But Rizia is ready now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[500]` **Pabel Adria**: ""Isn't Queen Beatrice a proponen..." |
| `[501]` | **""Still, we're in the middle of a war. It's not the time to go around making huge c..."** | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..."<br>`[440]` **Pabel Adria**: ""This is one instance where demo..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[473]` **Pabel Adria**: ""If not now, then when?"" |
| `[502]` | **""I will think about what you said. I promise.""** | `[479]` **Pabel Adria**: ""I've got to go oversee breakfas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[503]` **Pabel Adria**: ""Please do."" |
| `[505]` | **""You shouldn't be worried. I am seeing clearly for the first time in my life.""** | `[479]` **Pabel Adria**: ""I've got to go oversee breakfas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Pabel Adria**: ""Then why can't you see homosexu..." |
| `[510]` | **""I'm sorry. I wish I could see it differently.""** | `[479]` **Pabel Adria**: ""I've got to go oversee breakfas..."<br>`[560]` **Pabel Adria**: ""I've got to go oversee breakfas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Pabel Adria**: ""Don't apologize to me. Apologiz..." |
| `[512]` | **""The working class will see it as a betrayal of their values.""** | `[439]` **Pabel Adria**: ""Any fight for equal rights shou..."<br>`[440]` **Pabel Adria**: ""This is one instance where demo..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false` | *Brak zmian stanu* | `[452]` **Pabel Adria**: ""Whose values? Working-class hom..." |
| `[519]` | **""My child might die. That's what's important to me right now.""** | `[541]` **Pabel Adria**: ""But if this isn't important to ..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[520]` **Pabel Adria**: ""Mateus was someone's child, too."" |
| `[528]` | **""I'll look into making a decree. I promise.""** | `[531]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Pabel Adria**: ""Thank you."" |
| `[529]` | **""Bi mare volu...""** | `[531]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0` | *Brak zmian stanu* | `[526]` **Pabel Adria**: ""Un oxit solu."" |
| `[530]` | **""I'm sorry about your lover.""** | `[531]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[579]` **Pabel Adria**: ""Thank you."" |
| `[534]` | **""I've already got my council and the House of Delegates telling me what to do. Now..."** | `[477]` **Pabel Adria**: ""Your approval means as much to ..."<br>`[489]` **Pabel Adria**: ""It's not just about what I want..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[539]` **Narrator**: "He stood up indignantly." |
| `[535]` | **""Even if I made homosexuality legal tomorrow, you couldn't go parading about town ..."** | `[477]` **Pabel Adria**: ""Your approval means as much to ..."<br>`[489]` **Pabel Adria**: ""It's not just about what I want..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Pabel Adria**: ""I assure you I will be as discr..." |
| `[537]` | **""You're right. I have a historic opportunity. I've got to seize it while I still c..."** | `[477]` **Pabel Adria**: ""Your approval means as much to ..."<br>`[489]` **Pabel Adria**: ""It's not just about what I want..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[538]` **Pabel Adria**: ""The sooner you do, the more liv..." |
| `[540]` | **""Then keep your mouth shut. You're my servant, remember?""** | `[541]` **Pabel Adria**: ""But if this isn't important to ..."<br>`[571]` **Pabel Adria**: ""But if the lives of other homos..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[575]` **Narrator**: "His face turned stony."<br>`[574]` **Narrator**: "Pabel looked crestfallen." |
| `[542]` | **""It's important to me. But it won't happen overnight.""** | `[541]` **Pabel Adria**: ""But if this isn't important to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Narrator**: "His expression softened." |
| `[546]` | **""Is that why you worked your way up to head butler? To push your... lavender agenda?""** | `[541]` **Pabel Adria**: ""But if this isn't important to ..."<br>`[571]` **Pabel Adria**: ""But if the lives of other homos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[522]` **Narrator**: "His face turned stony." |
| `[550]` | **""Plenty of people don't get to experience love. I didn't.""** | `[457]` **Pabel Adria**: ""What kind of sick, twisted God ..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[551]` **Pabel Adria**: ""That's not a reason to deny it ..." |
| `[559]` | **""I will gladly forget it. And I'll thank you not to trouble me with such talk again.""** | `[560]` **Pabel Adria**: ""I've got to go oversee breakfas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Pabel Adria**: ""I won't."" |
| `[562]` | **""If I show too much sympathy towards your community, my house will disown me.""** | `[430]` **Pabel Adria**: ""That's very kind of you, but th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Pabel Adria**: ""I beg your pardon, but from wha..."<br>`[477]` **Pabel Adria**: ""Your approval means as much to ..." |
| `[563]` | **""There are only so many decrees I can make. I have to prioritize.""** | `[430]` **Pabel Adria**: ""That's very kind of you, but th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Pabel Adria**: ""Then as your friend, I beg of y..."<br>`[611]` **Pabel Adria**: ""Then as your butler and humble ..." |
| `[564]` | **""They can move to Derdia. You said it's safe for them there, right?""** | `[430]` **Pabel Adria**: ""That's very kind of you, but th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[565]` **Pabel Adria**: ""Not everyone has the resources ..." |
| `[573]` | **""They are important to me. But I can't make change happen overnight.""** | `[571]` **Pabel Adria**: ""But if the lives of other homos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Narrator**: "His expression softened." |
| `[580]` | **""What do I wear?""** | `[531]` **Pabel Adria**: ""I'm late to oversee breakfast. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[581]` **Pabel Adria**: ""Navy blue suit, burgundy pocket..." |
| `[591]` | **""They are going well, thank you. I'm hoping to contract their mercenaries for use ..."** | `[371]` **Pabel Adria**: ""How are preparations going for ..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[403]` **Pabel Adria**: ""I see. I've heard they're very ..." |
| `[594]` | **""One of the many perversions of Golcondism.""** | `[593]` **Pabel Adria**: ""It's one of the only places in ..." | `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true` | *Brak zmian stanu* | `[718]` **Pabel Adria**: ""I wouldn't call it that, exactl..." |
| `[598]` | **""Are you saying that in some respects, Golcondists are more enlightened than mains..."** | `[593]` **Pabel Adria**: ""It's one of the only places in ..." | `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false` | *Brak zmian stanu* | `[722]` **Pabel Adria**: ""Well, not exactly..."" |
| `[599]` | **""A fascinating contradiction. How can such an extremist society allow homosexuality?""** | `[593]` **Pabel Adria**: ""It's one of the only places in ..." | `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false` | *Brak zmian stanu* | `[601]` **Pabel Adria**: ""The only reason Derdia allows h..." |
| `[600]` | **""Would you ever move there, Pabel?""** | `[593]` **Pabel Adria**: ""It's one of the only places in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[612]` **Pabel Adria**: ""Only in an emergency."" |
| `[602]` | **""It could greatly improve our image in the war. A kingdom that grants rights to wo..."** | `[489]` **Pabel Adria**: ""It's not just about what I want..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[607]` **Pabel Adria**: ""That's not precisely what I mea..." |
| `[615]` | **""To the land of blasphemous lunatics, you mean? I couldn't be more excited.""** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[616]` **Pabel Adria**: ""Not all of their beliefs are cr..." |
| `[620]` | **""It can't be that bad in Rizia. Can it?""** | `[619]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[763]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Narrator**: "His eyes darkened." |
| `[621]` | **""Derdia's attitude towards homosexuality is just an extension of the deep-seated s..."** | `[619]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[763]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[627]` **Pabel Adria**: ""Because of what our kingdom doe..." |
| `[622]` | **""Boring. Without the lure of the forbidden, I might as well be with a woman.""** | `[619]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[763]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[625]` **Narrator**: "Outrage flashed in his eyes." |
| `[629]` | **""So do I. They should never have had to flee Rizia.""** | `[619]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[763]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[630]` **Pabel Adria**: ""And those who fled are the luck..." |
| `[634]` | **""Aha. You're jealous that I get to go to the homosexual country and you don't.""** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true` | *Brak zmian stanu* | `[643]` **Pabel Adria**: ""Well, yes. A little."" |
| `[638]` | **""I don't have high hopes, to be honest. The Derdians and I have nothing in common.""** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0` | *Brak zmian stanu* | `[640]` **Pabel Adria**: ""Nothing? Are you certain about ..." |
| `[639]` | **""As well as can be expected. I'm hoping to contract their mercenaries for the war.""** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[642]` **Pabel Adria**: ""Ah. I've heard they're very ski..." |
| `[641]` | **""I've got high hopes for it. The Derdians and I agree on many points.""** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0) == false` | *Brak zmian stanu* | `[645]` **Pabel Adria**: ""Do you? Interesting."" |
| `[644]` | **""As well as can be expected. I'm hoping to contract their mercenaries for use in Z..."** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[642]` **Pabel Adria**: ""Ah. I've heard they're very ski..." |
| `[647]` | **""One of the many perversions of Golcondism.""** | `[646]` **Pabel Adria**: ""It's one of the only places in ..." | `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true` | *Brak zmian stanu* | `[672]` **Pabel Adria**: ""Since when is what we're doing ..." |
| `[651]` | **""Are you saying that in some respects, Golcondists are more enlightened than mains..."** | `[646]` **Pabel Adria**: ""It's one of the only places in ..." | `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false` | *Brak zmian stanu* | `[666]` **Pabel Adria**: ""No, not exactly..."" |
| `[652]` | **""A fascinating contradiction. How can such an extremist society allow homosexuality?""** | `[646]` **Pabel Adria**: ""It's one of the only places in ..." | `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false` | *Brak zmian stanu* | `[654]` **Pabel Adria**: ""The only reason homosexuality i..." |
| `[653]` | **""Would you ever move there, Pabel?""** | `[646]` **Pabel Adria**: ""It's one of the only places in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Pabel Adria**: ""And leave my king? Never. But I..." |
| `[657]` | **""I would love to permit such a thing in Rizia, but I'd lose the throne in an insta..."** | `[646]` **Pabel Adria**: ""It's one of the only places in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[658]` **Pabel Adria**: ""To be fair, the Derdians are fa..." |
| `[659]` | **""It is true that Wruhecist teachings stress the importance of bringing joy to othe..."** | `[178]` **Pabel Adria**: ""You said you felt things with m..."<br>`[180]` **Pabel Adria**: ""You said you felt things with m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[660]` **Pabel Adria**: ""Yes! Precisely!""<br>`[665]` **Pabel Adria**: ""Exactly. And don't even try to ..." |
| `[677]` | **""You're talking about a tiny minority of citizens. Why cater to them at the expens..."** | `[422]` **Pabel Adria**: ""Until homosexuality is no longe..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false` | *Brak zmian stanu* | `[678]` **Pabel Adria**: ""Why would it have to be at anyo..." |
| `[686]` | **""If Rizia wanted legal homosexuality, my parliament would have brought it up by now.""** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Pabel Adria**: ""We're talking about basic human..."<br>`[690]` **Pabel Adria**: ""You know very well that your pa..." |
| `[694]` | **""Rizia is still a majority-Wruhecist country. If I made homosexuality legal, the r..."** | `[154]` **Pabel Adria**: ""We're talking about basic human..."<br>`[690]` **Pabel Adria**: ""You know very well that your pa..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Pabel Adria**: ""I understand the influence Gran..." |
| `[695]` | **""People like us represent a tiny minority of citizens. Why focus on them at the ex..."** | `[137]` **Pabel Adria**: ""Until homosexuality is no longe..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false` | *Brak zmian stanu* | `[696]` **Pabel Adria**: ""Why would it have to be at anyo..." |
| `[697]` | **""Derdia's attitude towards homosexuality is just an extension of the deep-seated s..."** | `[379]` **Pabel Adria**: ""It's not perfect. But I underst..."<br>`[726]` **Pabel Adria**: ""But I understand the desire to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[698]` **Pabel Adria**: ""Because of what our kingdom doe..." |
| `[703]` | **""Why do you care about my diplomatic dealings?""** | `[702]` **Pabel Adria**: ""Palace scuttlebutt has it you t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[704]` **Pabel Adria**: ""I know it's not my business. Bu..." |
| `[705]` | **""Yes, I don't want to have any more contact with those lunatics than I need to.""** | `[702]` **Pabel Adria**: ""Palace scuttlebutt has it you t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[706]` **Pabel Adria**: ""Understandable. But I would hav..." |
| `[707]` | **""It would have been a waste of time. Rizia's place is among the monarchies of GRAC..."** | `[702]` **Pabel Adria**: ""Palace scuttlebutt has it you t..." | `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true` | *Brak zmian stanu* | `[706]` **Pabel Adria**: ""Understandable. But I would hav..." |
| `[711]` | **""It would've been counterproductive. I'll have better relations with our other int..."** | `[702]` **Pabel Adria**: ""Palace scuttlebutt has it you t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[712]` **Pabel Adria**: ""I see. Still, I would have been..." |
| `[713]` | **""Yes, and I'm regretting it now. I'd be interested in seeing how they live over th..."** | `[702]` **Pabel Adria**: ""Palace scuttlebutt has it you t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[714]` **Pabel Adria**: ""As would I."" |
| `[723]` | **""Accepted and condoned. Sal told me all about this.""** | `[593]` **Pabel Adria**: ""It's one of the only places in ..." | `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true` | *Brak zmian stanu* | `[724]` **Pabel Adria**: ""With a judgemental scowl on his..." |
| `[728]` | **""Since when do you care about my diplomatic dealings?""** | `[727]` **Pabel Adria**: ""So, palace scuttlebutt has it y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[729]` **Pabel Adria**: ""I know it's not my business. Bu..." |
| `[730]` | **""I don't want to have any more contact with those lunatics than I need to.""** | `[727]` **Pabel Adria**: ""So, palace scuttlebutt has it y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[731]` **Pabel Adria**: ""Understandable. But I would hav..." |
| `[732]` | **""It would have been a waste of time. Rizia's place is among the monarchies of GRAC..."** | `[727]` **Pabel Adria**: ""So, palace scuttlebutt has it y..." | `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true` | *Brak zmian stanu* | `[731]` **Pabel Adria**: ""Understandable. But I would hav..." |
| `[736]` | **""Yes, and I'm regretting it now. I'd be interested in seeing how they live over th..."** | `[727]` **Pabel Adria**: ""So, palace scuttlebutt has it y..." | `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false` | *Brak zmian stanu* | `[737]` **Pabel Adria**: ""So would I."" |
| `[738]` | **""It would've been counterproductive. I'll have better relations with our other int..."** | `[727]` **Pabel Adria**: ""So, palace scuttlebutt has it y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[739]` **Pabel Adria**: ""Sure. Still, I would have been ..." |
| `[752]` | **""Since when do you care about my diplomatic dealings?""** | `[87]` **Pabel Adria**: ""Your royal visit to Derdia is c..." | `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false` | *Brak zmian stanu* | `[753]` **Pabel Adria**: ""I don't, usually. But this one ..." |
| `[754]` | **""You should be glad. What if I went there and some handsome, virile Golcondist war..."** | `[727]` **Pabel Adria**: ""So, palace scuttlebutt has it y..." | `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true` | *Brak zmian stanu* | `[755]` **Pabel Adria**: ""At least neither of you would b..." |
| `[760]` | **""Accepted and condoned. Sal told me all about this.""** | `[646]` **Pabel Adria**: ""It's one of the only places in ..." | `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true` | *Brak zmian stanu* | `[761]` **Pabel Adria**: ""With a judgemental frown on his..." |

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
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Privately reflecting on Rizia’s stance o..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Early in the morning, I heard a soft tap on the door to my bedchambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus_Italic: "Pretend to be asleep."*)
  - -> `[4]` (*Player_Romus: ""Who is it?""*)
  - -> `[5]` (*Player_Romus: ""Go away. I don't have to be up for another hour.""*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "There was no reply, just another soft knock."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go away. I don't have to be up for another hour.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "There was no reply, just another soft knock."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bruno, can you open the door?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""Bruno, can you open the door?""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Narrator**
> "Bruno jumped off my bed, ran to the door and began scratching at it. It didn't open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I dragged myself out of bed and walked towards the door."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Bruno jumped off my bed, ran to the door and began scratc..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Bruno ran to the door and began scratching at it. It didn..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Bruno ran to the door and began scratching at it. It didn't open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I dragged myself out of bed and walked towards the door."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "There was no reply, just another soft knock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I dragged myself out of bed and walked towards the door."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Pretend to be asleep."]** — Mówca: **Player_Romus_Italic**
> "I pretended to be asleep."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "There were a few seconds of silence, then another soft kn..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "There were a few seconds of silence, then another soft knock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I dragged myself out of bed and walked towards the door."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I dragged myself out of bed and walked towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "As I was about to open it, I noticed an object had been s..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "As I was about to open it, I noticed an object had been slipped underneath it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus_Italic: "Pick it up."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I picked it up. It was a miniature scroll, lettered in precise handwriting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_PoemScroll");"*)

### Węzeł `[21]`
Mówca: **Narrator**
> ""Find me in the labyrinth of past memories, 

left at the crossroads of whispering trees.

Close to the heart, all wrongs become right,

as we forge ahead from shadow into light.

Retracing our steps, we can find what we missed

The words left unsaid, the lips left unkissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "I looked out the window. The sky had just barely begun to..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "I looked out the window. The sky had just barely begun to lighten, and a grey mist still hung over the palace gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "My eyes came to rest on the hedge maze. I remembered watc..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "My eyes came to rest on the hedge maze. I remembered watching Pabel and his father construct it when I was a teenager."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Bruno followed me out of my bedroom. I ran into Titus pacing up and down the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""I'm going for a walk. No need to accompany me.""*)
  - -> `[30]` (*Player_Romus: ""Who was at my door just now?""*)
  - -> `[31]` (*Player_Romus: ""You don't sleep much, do you?""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Bruno followed me out of my bedroom. I ran into Titus pac..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I walked out of my bedroom and ran straight into Titus. M..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "I walked out of my bedroom and ran straight into Titus. My guard was pacing up and down the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""Who was at my door just now?""*)
  - -> `[31]` (*Player_Romus: ""You don't sleep much, do you?""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm going for a walk. No need to accompany me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Titus nodded."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was at my door just now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Titus Gordion: ""Your butler, Your Majesty. I told him to return at your ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't sleep much, do you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_TitusFights == true && Rizia..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Titus nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Titus Gordion: ""The palace grounds are secure, Your Majesty. Enjoy.""*)

### Węzeł `[33]`
Mówca: **Titus Gordion**
> ""The palace grounds are secure, Your Majesty. Enjoy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");  // Removes the conver..."*)

### Węzeł `[34]`
Mówca: **Titus Gordion**
> ""Your butler, Your Majesty. I told him to return at your appropriate wake-up time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Titus Gordion: ""Should I fetch him now?""*)

### Węzeł `[35]`
Mówca: **Titus Gordion**
> ""Not since Derdia. I can't believe I let you down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""Your butler was just here. Should I fetch him?""*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Few other palace staff were about as I wandered into the mist-enshrouded gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Bruno split off to chase a squirrel as I made my way to the maze. Its entrance was marked by a pair of willow trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bruno");"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Bruno split off to chase a squirrel as I made my way to t..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "I made my way to the maze. Its entrance was marked by a p..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[46]` (Player_Romus_Italic), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[46]` (Player_Romus_Italic), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left until I came to a junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator), `[46]` (Player_Romus_Italic), `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "Maze Choice 2"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[50]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right until I came to another junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[50]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "Maze Choice 3"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Player_Romus_Italic), `[42]` (Player_Romus_Italic), `[43]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Jump to: [Maze Choice 1]"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Player_Romus_Italic), `[50]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead. I knew I was close to the center of the maze."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Player_Romus_Italic), `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Maze Choice 4"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Player_Romus_Italic), `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Romus_Italic), `[47]` (Player_Romus_Italic), `[45]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Jump to: [Maze Choice 2]"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Player_Romus_Italic), `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic), `[51]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "Jump to: [Maze Choice 3]"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "Looking to the left, I noticed a freshly carved hole in one of the hedges. I stepped through it into a part of the maze I didn't recognize."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Player_Romus_Italic), `[66]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "Maze Choice 6"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Player_Romus_Italic), `[58]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Player_Romus_Italic), `[58]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Player_Romus_Italic), `[58]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Player_Romus_Italic), `[66]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Player_Romus_Italic), `[55]` (Player_Romus_Italic), `[56]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "Jump to: [Maze Choice 4]"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Player_Romus_Italic), `[66]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and found myself in a small clearing, shaded by flowering laurels and lined with soft-looking moss."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Player_Romus_Italic), `[79]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Pabel was sitting there, waiting for me. He reached his h..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Pabel was sitting there, waiting for me. He reached his hand towards mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[63]` (*Player_Romus_Italic: "Take it."*)
  - -> `[155]` (*Player_Romus: ""We shouldn't. I think Titus is starting to get suspicious.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a lovely poem. But between the war and everything else going on, I'm really not in the mood.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He gave a brief sigh of disappointment and withdrew his h..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Take it."]** — Mówca: **Player_Romus_Italic**
> "I took his hand and he gently pulled me towards the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "By the time we finally spoke, the morning sunlight was pe..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "I made my way to the maze. Its entrance was marked by a pair of willow trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "Maze Choice 1"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Player_Romus_Italic), `[79]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "Go backwards."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player_Romus_Italic), `[59]` (Player_Romus_Italic), `[53]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Jump to: [Maze choice 5]"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Maze Choice 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus_Italic: "Go straight ahead."*)
  - -> `[42]` (*Player_Romus_Italic: "Go right."*)
  - -> `[43]` (*Player_Romus_Italic: "Go left."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Maze Choice 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus_Italic: "Go backwards."*)
  - -> `[45]` (*Player_Romus_Italic: "Go right."*)
  - -> `[47]` (*Player_Romus_Italic: "Go left."*)
  - -> `[44]` (*Player_Romus_Italic: "Go straight ahead."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Maze Choice 1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "Maze Choice 1"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Maze Choice 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus_Italic: "Go backwards."*)
  - -> `[49]` (*Player_Romus_Italic: "Go right."*)
  - -> `[51]` (*Player_Romus_Italic: "Go left."*)
  - -> `[48]` (*Player_Romus_Italic: "Go straight ahead."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Maze Choice 2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "Maze Choice 2"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Maze Choice 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus_Italic: "Go backwards."*)
  - -> `[55]` (*Player_Romus_Italic: "Go right."*)
  - -> `[54]` (*Player_Romus_Italic: "Go left."*)
  - -> `[56]` (*Player_Romus_Italic: "Go straight ahead."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Maze Choice 3]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "Maze Choice 3"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Player_Romus_Italic), `[58]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Maze choice 5"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Maze Choice 4]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Maze Choice 4"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Maze choice 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus_Italic: "Go backwards."*)
  - -> `[57]` (*Player_Romus_Italic: "Go right."*)
  - -> `[53]` (*Player_Romus_Italic: "Go left."*)
  - -> `[59]` (*Player_Romus_Italic: "Go straight ahead."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Maze Choice 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus_Italic: "Go backwards."*)
  - -> `[65]` (*Player_Romus_Italic: "Go right."*)
  - -> `[60]` (*Player_Romus_Italic: "Go left."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Maze choice 5]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "Maze choice 5"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "Jump to: [Maze Choice 6]"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Maze Choice 6]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "Maze Choice 6"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""It was a lovely poem. But between the war and everything..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""It was a lovely poem. But considering everything that's ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a lovely poem. But considering everything that's been going on, I'm not really in the mood.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He gave a brief sigh of disappointment and withdrew his h..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "He gave a brief sigh of disappointment and withdrew his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed = true"*)

### Węzeł `[86]`
Mówca: **Pabel Adria**
> ""It's fine. We can talk for a few minutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I took a seat on the ground next to him. He turned to loo..."*)

### Węzeł `[87]`
Mówca: **Pabel Adria**
> ""Your royal visit to Derdia is coming up, isn't it? How are the preparations going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Player_Romus: ""To the land of blasphemous lunatics, you mean? I couldn'..."*)
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0"*)
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "I took a seat on the ground next to him. He turned to look into my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)

### Węzeł `[89]`
Mówca: **Narrator**
> "By the time we finally spoke, the morning sunlight was peeking through the branches above us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[105]` (*Player_Romus: ""Another day, another illicit meeting spot.""*)
  - -> `[157]` (*Player_Romus: ""You missed your calling. You should've become a poet.""*)
  - -> `[106]` (*Player_Romus: ""Do you think Titus knows about us yet?""*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_Duel_TitusFights == true && Rizia..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_Duel_TitusFights == true && Riz..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Titus Gordion: ""Not since Derdia. I can't believe I let you down like th..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Titus Gordion: ""Not since the events in Wehlen. I can't believe I let yo..."*)

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Not since the events in Wehlen. I can't believe I let you down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""Your butler was just here. Should I fetch him?""*)

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""Your butler was just here. Should I fetch him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""I'll find him myself.""*)
  - -> `[97]` (*Player_Romus: ""No need. I'm just going for a quick walk.""*)
  - -> `[98]` (*Player_Romus: ""Keep guarding my room. I'll be back shortly.""*)

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""Should I fetch him now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""I'll find him myself.""*)
  - -> `[97]` (*Player_Romus: ""No need. I'm just going for a quick walk.""*)
  - -> `[98]` (*Player_Romus: ""Keep guarding my room. I'll be back shortly.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll find him myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Titus Gordion), `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Titus Gordion: ""Understood, Your Majesty. Enjoy your constitutional.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need. I'm just going for a quick walk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Titus Gordion), `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Titus Gordion: ""Understood, Your Majesty. Enjoy your constitutional.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep guarding my room. I'll be back shortly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Titus Gordion), `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Titus Gordion: ""Understood, Your Majesty. Enjoy your constitutional.""*)

### Węzeł `[99]`
Mówca: **Titus Gordion**
> ""Understood, Your Majesty. Enjoy your constitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");  // Removes the conver..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was... a-maze-ing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Pabel gave a short laugh. He sat up and plucked a leaf ou..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""That was... a-maze-ing.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
Mówca: **Narrator**
> "Pabel gave a short laugh. He sat up and plucked a leaf out of my hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another day, another illicit meeting spot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Pabel Adria: ""You must admit it's more comfortable than that rocky cov..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think Titus knows about us yet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Inv..."*)

### Węzeł `[107]`
Mówca: **Pabel Adria**
> ""He's got eyes everywhere. But if he were able to pin something on me yet, he would have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Pabel sat up and plucked a leaf out of my hair."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.InvestigatePoisoning_NoPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.Inv..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.I..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.InvestigatePoisoning_NoPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Pabel Adria: ""He's got eyes everywhere. But if he were able to pin som..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.InvestigatePoisoning_NoPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Pabel Adria: ""He knows we're friends. I doubt any other possibility ha..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Pabel sat up and plucked a leaf out of my hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)

### Węzeł `[112]`
Mówca: **Pabel Adria**
> ""He knows we're friends. I doubt any other possibility has penetrated his skull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Pabel sat up and plucked a leaf out of my hair."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Pabel Adria: ""It's fine. We can talk for a few minutes.""*)

### Węzeł `[114]`
Mówca: **Narrator**
> "He reached into the pocket of his suit jacket and pulled out a newspaper clipping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Pabel Adria: ""'Man, 33, beaten to death in Monqiz Prison... the deceas..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He reached into the pocket of his suit jacket and pulled ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "His suit jacket was lying on the ground behind us. He rea..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "His suit jacket was lying on the ground behind us. He reached into its pocket and pulled out a newspaper clipping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Pabel Adria: ""'Man, 33, beaten to death in Monqiz Prison... the deceas..."*)

### Węzeł `[119]`
Mówca: **Pabel Adria**
> ""'Man, 33, beaten to death in Monqiz Prison... the deceased was identified as Mateus Montalvo, a courier for the Cantuavo vineyards.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Pabel Adria: ""Montalvo had recently been jailed and dismissed from his..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaD..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.InvestigatePoisoning_NoPabel == false && (Rizi..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""Oh, no. Was he arrested because of my investigation?""*)
  - -> `[123]` (*Player_Romus: ""Is that the man you were with in the wine cellar?""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""Did you know him?""*)
  - -> `[124]` (*Player_Romus: ""With a client? Was he mad?""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that the man you were with in the wine cellar?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)`
- **Kontekst wejściowy (poprzednik):** `[130]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Pabel nodded, his teeth clenched."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With a client? Was he mad?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)) == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Pabel Adria: ""No madder than a king doing the same with his butler.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you know him?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)) == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Pabel nodded, his teeth clenched."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Pabel Adria: ""That isn't the point.""*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Pabel Adria: ""Our encounter was obviously neither his first nor last. ..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Pabel Adria: ""We had an encounter some time before your coronation. Cl..."*)

### Węzeł `[129]`
Mówca: **Pabel Adria**
> ""That isn't the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[130]`
Mówca: **Pabel Adria**
> ""Montalvo had recently been jailed and dismissed from his job after engaging in suspected homosexual activity with a client.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""It's a disgrace that this was allowed to occur during my..."*)
  - -> `[133]` (*Player_Romus: ""This is happening in Rizia's prisons? I'll have to impro..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaD..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, no. Was he arrested because of my investigation?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)`
- **Kontekst wejściowy (poprzednik):** `[130]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[132]`
Mówca: **Pabel Adria**
> ""Our encounter was obviously neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is happening in Rizia's prisons? I'll have to improve security there at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Pabel Adria: ""Our encounter was obviously neither his first nor last. ..."*)

### Węzeł `[135]`
Mówca: **Pabel Adria**
> ""We had an encounter some time before your coronation. Clearly neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[136]`
Mówca: **Pabel Adria**
> ""No madder than a king doing the same with his butler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[137]`
Mówca: **Pabel Adria**
> ""Until homosexuality is no longer a crime in Rizia, people like us are going to keep dying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""People like *us*? I'm not a homosexual.""*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_..."*)
  - -> `[686]` (*Player_Romus: ""If Rizia wanted legal homosexuality, my parliament would..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 4"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a disgrace that this was allowed to occur during my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Pabel nodded, his teeth clenched."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Pabel Adria: ""He wasn't the first. And he won't be the last.""*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People like *us*? I'm not a homosexual.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Pabel gaped at me in astonishment. A short laugh escaped ..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am working to achieve parity between commoners and nobles. I can't let the problems of a tiny minority distract me from that fight.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Pabel Adria: ""Rom. Any fight for equal rights should include *all* Riz..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Pabel gaped at me in astonishment. A short laugh escaped his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Pabel Adria: ""Call yourself what you want. It doesn't change the fact ..."*)

### Węzeł `[143]`
Mówca: **Pabel Adria**
> ""You must admit it's more comfortable than that rocky cove in Monqiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Pabel sat up and plucked a leaf out of my hair."*)

### Węzeł `[144]`
Mówca: **Pabel Adria**
> ""Call yourself what you want. It doesn't change the fact that in the eyes of the law, you're a criminal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focu..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""I am working to achieve parity between commoners and nob..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Player_Romus: ""People like us represent a tiny minority of citizens. Wh..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""Your Mateus was a sinner, and so are we. I can barely st..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Mateus was a sinner, and so are we. I can barely stomach such behavior, let alone enshrine it into law.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Pabel sighed in frustration."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been wanting to get rid of that law since I became king. But I'm afraid I don't have the authority.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] <= 4`
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Pabel Adria: ""If you care about me -- about us -- you will find a way ..."*)

### Węzeł `[153]`
Mówca: **Pabel Adria**
> ""Rom. Any fight for equal rights should include *all* Rizians. Regardless of their romantic preferences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""There are only so many decrees I can make as king. I hav..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[154]`
Mówca: **Pabel Adria**
> ""We're talking about basic human rights. You can't wait for the population to catch up with the times. You have to show them the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[694]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't. I think Titus is starting to get suspicious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "He groaned quietly and withdrew his hand."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "He groaned quietly and withdrew his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed = true"*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You missed your calling. You should've become a poet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Pabel Adria: ""I'd be living in the gutter. And you'd have no one to ha..."*)

### Węzeł `[158]`
Mówca: **Pabel Adria**
> ""I'd be living in the gutter. And you'd have no one to handle your... household.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Pabel sat up and plucked a leaf out of my hair."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Pabel sighed in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 4"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority <= 4)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority <= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""I've been wanting to get rid of that law since I became ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority <= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""I'm the king. I have the authority. I can make it happen.""*)

### Węzeł `[163]`
Mówca: **Pabel Adria**
> ""If you care about me -- about us -- you will find a way to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0"*)
  - -> `[215]` (*Player_Romus: ""The Dastnurists will hate it, though. What am I supposed..."*)
  - -> `[227]` (*Player_Romus: ""If I take this leap, my house will never forgive me.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are only so many decrees I can make as king. I have to prioritize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Pabel Adria), `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Pabel Adria: ""Then please. Prioritize this one.""*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've made so much progress for Rizia's working class. They'll see it as a betrayal of their values.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Pabel Adria), `[154]` (Pabel Adria), `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Pabel Adria: ""Whose values, exactly? Working-class homosexuals are at ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""I've made so much progress for Rizia's working class. Th..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""The working class will see it as a betrayal of their val..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will never accept my plans for reform.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Pabel Adria), `[154]` (Pabel Adria), `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Pabel Adria: ""'My' community. Right.""*)

### Węzeł `[170]`
Mówca: **Pabel Adria**
> ""'My' community. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""Whose values, exactly? Working-class homosexuals are at more risk than anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[172]`
Mówca: **Pabel Adria**
> ""I understand the influence Grand Wiseman Ignacius wields. But do you really plan to spend the rest of your reign catering to the Sanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm the king. I have the authority. I can make it happen.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Pabel Adria: ""If you care about me -- about us -- then you will.""*)

### Węzeł `[174]`
Mówca: **Pabel Adria**
> ""If you care about me -- about us -- then you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0"*)
  - -> `[215]` (*Player_Romus: ""The Dastnurists will hate it, though. What am I supposed..."*)
  - -> `[227]` (*Player_Romus: ""If I take this leap, my house will never forgive me.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Pabel Adria: ""You said you felt things with me that you hadn't felt wi..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Pabel Adria: ""You said you felt things with me that you never felt wit..."*)

### Węzeł `[178]`
Mówca: **Pabel Adria**
> ""You said you felt things with me that you never felt with any woman. What kind of sick, twisted God would forbid you from that pleasure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Player_Romus: ""It is true that Wruhecist teachings stress the importanc..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[179]` (*Player_Romus: ""It's not God that's sick and twisted. It's us.""*)
  - -> `[186]` (*Player_Romus: ""A truly devout Wruhecist must abandon all thoughts of ea..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not God that's sick and twisted. It's us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[180]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[180]`
Mówca: **Pabel Adria**
> ""You said you felt things with me that you hadn't felt with anyone since Lena. What kind of sick, twisted God would forbid you from that pleasure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Player_Romus: ""It is true that Wruhecist teachings stress the importanc..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[185]` (*Player_Romus: ""The same God who took my wife away from me.""*)
  - -> `[179]` (*Player_Romus: ""It's not God that's sick and twisted. It's us.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""The same God who let the Palesians take my daughter from..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who let the Palesians take my daughter from me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[180]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "He put a hand on my shoulder."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who took my wife away from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "He put a hand on my shoulder."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly devout Wruhecist must abandon all thoughts of earthly pleasure if he is to achieve Golconda.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "He stood up and brushed himself off."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He hurriedly started putting his clothes back on."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Pabel Adria: ""I care about you, Romus. I always have.""*)

### Węzeł `[191]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Pabel Adria: ""But friend to friend... all this religious talk is start..."*)

### Węzeł `[192]`
Mówca: **Pabel Adria**
> ""But friend to friend... all this religious talk is starting to worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[193]`
Mówca: **Narrator**
> "He hurriedly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Pabel Adria: ""I care about you, Romus. I always have.""*)

### Węzeł `[194]`
Mówca: **Narrator**
> "He put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Pabel Adria: ""You're going through a hard time, I know.""*)

### Węzeł `[195]`
Mówca: **Pabel Adria**
> ""You're going through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Pabel Adria: ""But you deserve love. We both do.""*)

### Węzeł `[196]`
Mówca: **Pabel Adria**
> ""But you deserve love. We both do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[197]`
Mówca: **Narrator**
> "He put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Pabel Adria: ""You've gone through a hard time, I know.""*)

### Węzeł `[198]`
Mówca: **Pabel Adria**
> ""You've gone through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Pabel Adria: ""But you deserve love. We both do.""*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Pabel Adria: ""Or do you think a jury would let you off the hook becaus..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""I can turn it on and off, like a light switch. It's not ..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[203]` (*Player_Romus: ""Yes, all right. Point taken.""*)

### Węzeł `[202]`
Mówca: **Pabel Adria**
> ""Or do you think a jury would let you off the hook because you're attracted to women too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""I can turn it on and off, like a light switch. It's not ..."*)
  - -> `[204]` (*Player_Romus: ""I am attracted to human beings. Whether they're male or ..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[203]` (*Player_Romus: ""Yes, all right. Point taken.""*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, all right. Point taken.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[202]` (Pabel Adria), `[144]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Pabel Adria: ""It's not too late to change the law. You'd be giving so ..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am attracted to human beings. Whether they're male or female is of no consequence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Pabel Adria: ""Plenty of your subjects feel the same way. Shouldn't the..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can turn it on and off, like a light switch. It's not my fault that other people can't.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[202]` (Pabel Adria), `[144]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Pabel Adria: ""Wow. And I thought I knew you.""*)

### Węzeł `[206]`
Mówca: **Pabel Adria**
> ""Plenty of your subjects feel the same way. Shouldn't the law reflect that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[207]`
Mówca: **Pabel Adria**
> ""It's not too late to change the law. You'd be giving so many of your subjects a chance at love. At life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[268]` (*Player_Romus: ""I haven't seen this side of you before and frankly, I'm ..."*)
  - -> `[270]` (*Player_Romus: ""Even if homosexuality were legal in Rizia, it doesn't me..."*)
  - -> `[275]` (*Player_Romus: ""You're right. I have a historic opportunity to change th..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changing the law would definitely give us an edge with Derdia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0`
- **Kontekst wejściowy (poprzednik):** `[163]` (Pabel Adria), `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Pabel Adria: ""For whatever that's worth. Look at how they treat women...""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Romus: ""Changing the law would definitely give us an edge with D..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will disown me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Pabel Adria), `[154]` (Pabel Adria), `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Pabel Adria: ""'My' community. Right.""*)

### Węzeł `[213]`
Mówca: **Pabel Adria**
> ""'My' community. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[214]`
Mówca: **Pabel Adria**
> ""Then please. Prioritize this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists will hate it, though. What am I supposed to tell Rumburg?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Pabel Adria), `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Pabel Adria: ""Isn't Queen Beatrice a proponent of secularization? She'..."*)

### Węzeł `[216]`
Mówca: **Pabel Adria**
> ""Isn't Queen Beatrice a proponent of secularization? She'll understand the need to separate state laws from religious ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""Still, we're in the middle of a war. It's not the time t..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, we're in the middle of a war. It's not the time to go around making huge changes.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[153]` (Pabel Adria), `[154]` (Pabel Adria), `[163]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Pabel Adria: ""If not now, then when?""*)

### Węzeł `[221]`
Mówca: **Pabel Adria**
> ""If not now, then when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Pabel Adria: ""I beg your pardon, but from what I can tell your relatio..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Pabel Adria: ""I know you're close with your family. But if they insist..."*)

### Węzeł `[225]`
Mówca: **Pabel Adria**
> ""I beg your pardon, but from what I can tell your relationship with your family is already beyond repair. What's one more burned bridge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[268]` (*Player_Romus: ""I haven't seen this side of you before and frankly, I'm ..."*)
  - -> `[270]` (*Player_Romus: ""Even if homosexuality were legal in Rizia, it doesn't me..."*)
  - -> `[275]` (*Player_Romus: ""You're right. I have a historic opportunity to change th..."*)

### Węzeł `[226]`
Mówca: **Pabel Adria**
> ""I know you're close with your family. But if they insist on denying us our humanity, then I'm sorry, but screw them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[268]` (*Player_Romus: ""I haven't seen this side of you before and frankly, I'm ..."*)
  - -> `[270]` (*Player_Romus: ""Even if homosexuality were legal in Rizia, it doesn't me..."*)
  - -> `[275]` (*Player_Romus: ""You're right. I have a historic opportunity to change th..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I take this leap, my house will never forgive me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Pabel Adria), `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[228]`
Mówca: **Pabel Adria**
> ""For whatever that's worth. Look at how they treat women...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Pabel Adria: ""But yes. The Golcondists in Rizia  would also be very ha..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Pabel Adria: ""I've got to go oversee breakfast. I trust you can find y..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Pabel Adria: ""There's still some time before breakfast. I suggest you ..."*)

### Węzeł `[232]`
Mówca: **Pabel Adria**
> ""I've got to go oversee breakfast. I trust you can find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus: ""We must both repent, Pabel. Before it's too late.""*)
  - -> `[235]` (*Player_Romus: ""I'm sorry. I wish I could see it differently.""*)
  - -> `[236]` (*Player_Romus: ""I will think about what you said. I promise.""*)

### Węzeł `[233]`
Mówca: **Pabel Adria**
> ""There's still some time before breakfast. I suggest you go back inside and wash the sin out of your mouth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus: ""We must both repent, Pabel. Before it's too late.""*)
  - -> `[235]` (*Player_Romus: ""I'm sorry. I wish I could see it differently.""*)
  - -> `[237]` (*Player_Romus: ""Watch your own mouth. You're still speaking to the king.""*)
  - -> `[236]` (*Player_Romus: ""I will think about what you said. I promise.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must both repent, Pabel. Before it's too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Pabel Adria), `[233]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Pabel Adria: ""It's already too late for Mateus.""*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. I wish I could see it differently.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Pabel Adria), `[233]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Pabel Adria: ""Don't apologize to me. Apologize to Mateus.""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will think about what you said. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Pabel Adria), `[233]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Pabel Adria: ""Please do.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your own mouth. You're still speaking to the king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "He stiffly bowed."*)

### Węzeł `[238]`
Mówca: **Pabel Adria**
> ""Don't apologize to me. Apologize to Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "He bowed and disappeared into the greenery."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "He stood up and brushed himself off."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "He slowly started putting his clothes back on."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Pabel Adria: ""I've got to go oversee breakfast. I trust you can find y..."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "He slowly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Pabel Adria: ""There's still some time before breakfast. I suggest you ..."*)

### Węzeł `[244]`
Mówca: **Pabel Adria**
> ""It's already too late for Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "He bowed and disappeared into the greenery."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "He stiffly bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Pabel Adria: ""Forgive me.""*)

### Węzeł `[246]`
Mówca: **Pabel Adria**
> ""Please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Pabel Adria: ""It's too late for Mateus. But not for many others.""*)

### Węzeł `[247]`
Mówca: **Pabel Adria**
> ""Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Pabel Adria: ""And for God's sake, forgive yourself.""*)

### Węzeł `[248]`
Mówca: **Pabel Adria**
> ""He wasn't the first. And he won't be the last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[249]`
Mówca: **Pabel Adria**
> ""And for God's sake, forgive yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "He turned around and swiftly disappeared into the greenery."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "He bowed and disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");  // Removes the conversa..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "He turned around and swiftly disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");  // Removes the conversa..."*)

### Węzeł `[252]`
Mówca: **Pabel Adria**
> ""It's too late for Mateus. But not for many others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "He turned around and swiftly disappeared into the greenery."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether or not I personally agree, classifying it as such would definitely put me on good terms with Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Pabel Adria: ""For whatever that's worth. Look at how they treat women...""*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists would hate me if I took that leap.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Pabel Adria: ""Good thing they're still a minority here. You can afford..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still worried about what my house will think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a stretch at all. Why is my butler talking more sense than my religious councilor?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Pabel Adria: ""Because the Grand Wiseman hasn't been intimate since bef..."*)

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""Because the Grand Wiseman hasn't been intimate since before the invention of the automobile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[258]`
Mówca: **Pabel Adria**
> ""Good thing they're still a minority here. You can afford to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[259]`
Mówca: **Pabel Adria**
> ""But yes. The Golcondists in Rizia  would also be very happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Pabel Adria: ""It's not just about you and me. This is a universal stru..."*)

### Węzeł `[260]`
Mówca: **Pabel Adria**
> ""Wow. And I thought I knew you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like guns. I'm not some nancy boy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true` AND `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[202]` (Pabel Adria), `[144]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Pabel Adria: ""Really? You're going to buy into those ancient stereotyp..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prol..."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Pr..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""I like guns. I'm not some nancy boy.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Pabel Adria**
> ""Really? You're going to buy into those ancient stereotypes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The working class will see it as a betrayal of their values.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[153]` (Pabel Adria), `[154]` (Pabel Adria), `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Pabel Adria: ""Whose values, exactly? Working-class homosexuals are at ..."*)

### Węzeł `[267]`
Mówca: **Pabel Adria**
> ""It's not just about you and me. This is a universal struggle. Think of the example we could set for the rest of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[268]` (*Player_Romus: ""I haven't seen this side of you before and frankly, I'm ..."*)
  - -> `[270]` (*Player_Romus: ""Even if homosexuality were legal in Rizia, it doesn't me..."*)
  - -> `[275]` (*Player_Romus: ""You're right. I have a historic opportunity to change th..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't seen this side of you before and frankly, I'm incredibly turned on by it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Pabel Adria), `[225]` (Pabel Adria), `[226]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Pabel smiled grimly."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already got my council and the House of Delegates telling me what to do. Now I have to take orders from my butler?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Pabel Adria), `[225]` (Pabel Adria), `[226]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if homosexuality were legal in Rizia, it doesn't mean you and I could be together openly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Pabel Adria), `[225]` (Pabel Adria), `[226]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Pabel Adria: ""I know. That's a discussion for a later date.""*)

### Węzeł `[271]`
Mówca: **Pabel Adria**
> ""I know. That's a discussion for a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Pabel smiled grimly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Pabel Adria: ""It's what happens to a man when enough of his kind are i..."*)

### Węzeł `[273]`
Mówca: **Pabel Adria**
> ""It's what happens to a man when enough of his kind are imprisoned, dead or exiled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[274]`
Mówca: **Pabel Adria**
> ""I'm not ordering you to do anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Pabel Adria: ""But if this isn't important to you... I don't know what ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I have a historic opportunity to change the law. I've got to seize it while I still can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Pabel Adria), `[225]` (Pabel Adria), `[226]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Pabel Adria: ""The sooner you do, the more lives will be saved.""*)

### Węzeł `[276]`
Mówca: **Pabel Adria**
> ""The sooner you do, the more lives will be saved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "He stood up and brushed himself off."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "He began putting his clothes back on."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He stood up and brushed himself off."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "He hurriedly started putting his clothes back on."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Pabel Adria: ""I care about you, Romus. I always have.""*)

### Węzeł `[284]`
Mówca: **Narrator**
> "He hurriedly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Pabel Adria: ""I care about you, Romus. I always have.""*)

### Węzeł `[285]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Pabel Adria: ""But if this isn't important to you... I don't know what ..."*)

### Węzeł `[286]`
Mówca: **Pabel Adria**
> ""But if this isn't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player_Romus: ""It doesn't make a difference. Even if homosexuality were..."*)
  - -> `[291]` (*Player_Romus: ""Wait. It's important to me if it's important to you.""*)
  - -> `[287]` (*Player_Romus: ""Then keep your mouth shut. You're here to serve me, reme..."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then keep your mouth shut. You're here to serve me, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Pabel Adria), `[319]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 3"*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't make a difference. Even if homosexuality were legal in Rizia, the people would never accept a degenerate king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Pabel Adria: ""This is more important than you or me. You could save th..."*)

### Węzeł `[289]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "He began putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. It's important to me if it's important to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Pabel Adria: ""This goes beyond either of us individually. It's basic h..."*)

### Węzeł `[292]`
Mówca: **Pabel Adria**
> ""This is more important than you or me. You could save thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[293]`
Mówca: **Pabel Adria**
> ""This goes beyond either of us individually. It's basic human rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "He stared me down coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[295]`
Mówca: **Pabel Adria**
> ""I am sorry, Your Majesty. For believing our encounters were more than an extension of my... royal duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[296]`
Mówca: **Pabel Adria**
> ""I know the war is your highest priority right now. But I hope you'll at least think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Pabel Adria: ""I know the war is your highest priority right now. But I..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Pabel Adria: ""I know you have other priorities. But please just think ..."*)

### Węzeł `[300]`
Mówca: **Pabel Adria**
> ""I know you have other priorities. But please just think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[301]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I trust you can find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[336]` (*Player_Romus: ""I'll look into making a decree. I promise.""*)
  - -> `[337]` (*Player_Romus: ""Bi mare volu...""*)
  - -> `[345]` (*Player_Romus: ""I'm sorry about your lover.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not unless you write me another poem.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[301]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Pabel Adria: ""My creative muscles are spent. Just look for the willows.""*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Pabel Adria: ""I am sorry, Your Majesty. For believing our encounters w..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Pabel Adria: ""Please forgive my confusion, Your Majesty. I wasn't the ..."*)

### Węzeł `[306]`
Mówca: **Pabel Adria**
> ""Please forgive my confusion, Your Majesty. I wasn't the one on my knees a moment ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[307]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I trust you can find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "He bowed and swiftly disappeared into the greenery."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "He bowed and swiftly disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");  // Removes the conversa..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "After collecting my thoughts, I stood and left the maze t..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "After collecting my thoughts, I dressed and left the maze..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "After collecting my thoughts, I dressed and left the maze the way I'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[313]`
Mówca: **Narrator**
> "After collecting my thoughts, I stood and left the maze the way I'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Bruno ran towards me as soon as I emerged. Together, we b..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "I emerged by the willow trees and began the walk back to ..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "Bruno ran towards me as soon as I emerged. Together, we began the walk back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexual..."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "I emerged by the willow trees and began the walk back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexual..."*)

### Węzeł `[319]`
Mówca: **Pabel Adria**
> ""But if this isn't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Then keep your mouth shut. You're here to serve me, reme..."*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[331]` (*Player_Romus: ""Is that why you're with me? To push your... lavender age..."*)
  - -> `[325]` (*Player_Romus: ""It's important to me. But it won't happen overnight.""*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "He stood up and brushed himself off."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "He hurriedly started putting his clothes back on."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Pabel Adria: ""I'm not ordering you to do anything.""*)

### Węzeł `[324]`
Mówca: **Narrator**
> "He hurriedly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Pabel Adria: ""I'm not ordering you to do anything.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's important to me. But it won't happen overnight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "His expression softened."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "His expression softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Pabel Adria: ""I know. Forgive my impatience.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My child might die. That's what's important to me right now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Narrator: "Pabel put a hand on my shoulder."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player_Romus: ""My child might die. That's what's important to me right ..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that why you're with me? To push your... lavender agenda?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "He stared me down coldly."*)

### Węzeł `[332]`
Mówca: **Pabel Adria**
> ""I know. But Mateus was someone's child, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""Not unless you write me another poem.""*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll look into making a decree. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Pabel Adria: ""Thank you.""*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Pabel Adria: ""...Un oxit solu.""*)

### Węzeł `[338]`
Mówca: **Pabel Adria**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "He leaned down and kissed me, then swiftly disappeared in..."*)

### Węzeł `[339]`
Mówca: **Pabel Adria**
> ""My creative muscles are spent. Just look for the willows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "He leaned down and kissed me, then swiftly disappeared in..."*)

### Węzeł `[340]`
Mówca: **Pabel Adria**
> ""I know. Forgive my impatience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "He stared me down coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Pabel Adria: ""It's not an agenda. It's a crisis. How many more of us h..."*)

### Węzeł `[342]`
Mówca: **Pabel Adria**
> ""It's not an agenda. It's a crisis. How many more of us have to die before you see it the same way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Pabel Adria: ""I'm late to oversee breakfast. I trust you can find your..."*)

### Węzeł `[343]`
Mówca: **Pabel Adria**
> ""...Un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "He leaned down and kissed me, then swiftly disappeared in..."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "He leaned down and kissed me, then swiftly disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");  // Removes the conversa..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about your lover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Pabel Adria: ""He wasn't my lover. But I'm sorry too.""*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Breather", "R_Breather_Loop");"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Breather", "R_Breather_Loop");"*)

### Węzeł `[349]`
Mówca: **Narrator**
> "Early in the morning, I heard a soft tap on the door to my bedchambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "It was Pabel, coming to wake me at my usual time."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "It was Pabel, coming to wake me at my usual time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Pabel Adria: ""Good morning, {RiziaDLCText.PabelToPlayer}. I hope you s..."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "Bruno ran up to him with a gleeful wag of his tail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Pabel Adria: ""What a happy fellow. I hope you both slept well.""*)

### Węzeł `[355]`
Mówca: **Pabel Adria**
> ""What a happy fellow. I hope you both slept well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "There was a tinge of melancholy in his voice."*)

### Węzeł `[356]`
Mówca: **Narrator**
> "There was a tinge of melancholy in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""What's going on, Pabel? Are you all right?""*)
  - -> `[359]` (*Player_Romus: ""Where's my paper?""*)
  - -> `[360]` (*Player_Romus: ""I slept wonderfully.""*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War"*)

### Węzeł `[357]`
Mówca: **Pabel Adria**
> ""Good morning, {RiziaDLCText.PabelToPlayer}. I hope you slept well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "There was a tinge of melancholy in his voice."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's going on, Pabel? Are you all right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Pabel Adria: ""I'm fine, thanks for asking.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's my paper?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Pabel Adria: ""I have it. Just give me one moment.""*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I slept wonderfully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Pabel Adria: ""I'm glad to hear it.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Player_Romus: ""I won't sleep until we take Pales.""*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""I won't sleep until we have Zille back.""*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't sleep until we take Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"]`
- **Kontekst wejściowy (poprzednik):** `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true"*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't sleep until we have Zille back.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"]) == false`
- **Kontekst wejściowy (poprzednik):** `[356]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true"*)

### Węzeł `[366]`
Mówca: **Pabel Adria**
> ""I have it. Just give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "He began drawing open my curtains, then stopped and spoke..."*)

### Węzeł `[367]`
Mówca: **Pabel Adria**
> ""I'm fine, thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "He began drawing open my curtains, then stopped and spoke..."*)

### Węzeł `[368]`
Mówca: **Pabel Adria**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "He began drawing open my curtains, then stopped and spoke..."*)

### Węzeł `[369]`
Mówca: **Pabel Adria**
> ""Even a king needs to close his eyes sometimes. I'll ask the pharmacist to procure you some Wehzek tablets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "He began drawing open my curtains, then stopped and spoke..."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "He began drawing open my curtains, then stopped and spoke to me in a forced casual tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)

### Węzeł `[371]`
Mówca: **Pabel Adria**
> ""How are preparations going for your royal visit to Derdia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[393]` (*Player_Romus: ""I've been reading up on the Golcondists. Perhaps Rizia h..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the land of blasphemous lunatics, you mean? I couldn't be more excited.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false`
- **Kontekst wejściowy (poprzednik):** `[371]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Pabel Adria: ""Lunatics, Your Majesty?""*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""To the land of blasphemous lunatics, you mean? I couldn'..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[376]`
Mówca: **Pabel Adria**
> ""Lunatics, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[377]`
Mówca: **Narrator**
> "He paused again, as if in deliberation. Finally, he walked over to the chair next to my bed and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Pabel Adria: ""I don't know if you're aware, but many Rizians of my per..."*)

### Węzeł `[378]`
Mówca: **Pabel Adria**
> ""I don't know if you're aware, but many Rizians of my persuasion have fled to Derdia since its establishment as a Golcondist republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Pabel Adria: ""It's one of the only places in Merkopa where relations b..."*)

### Węzeł `[379]`
Mówca: **Pabel Adria**
> ""It's not perfect. But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player_Romus: ""It can't be that bad in Rizia. Can it?""*)
  - -> `[697]` (*Player_Romus: ""Derdia's attitude towards homosexuality is just an exten..."*)
  - -> `[381]` (*Player_Romus: ""Really? I thought the lure of the forbidden was part of ..."*)
  - -> `[387]` (*Player_Romus: ""Something must be done to improve the status of your kin..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It can't be that bad in Rizia. Can it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Pabel Adria), `[726]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "His eyes darkened."*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? I thought the lure of the forbidden was part of your whole... thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Pabel Adria), `[726]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "He frowned, insulted."*)

### Węzeł `[382]`
Mówca: **Pabel Adria**
> ""You don't know the half of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "He tossed the morning paper onto my bed."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "His eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Pabel Adria: ""You don't know the half of it.""*)

### Węzeł `[384]`
Mówca: **Narrator**
> "He frowned, insulted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Pabel Adria: ""It's not a game, {RiziaDLCText.PabelToPlayer}. It's who ..."*)

### Węzeł `[385]`
Mówca: **Pabel Adria**
> ""It's not a game, {RiziaDLCText.PabelToPlayer}. It's who we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "He tossed the morning paper onto my bed."*)

### Węzeł `[386]`
Mówca: **Pabel Adria**
> ""Here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "He tossed the morning paper onto my bed."*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something must be done to improve the status of your kind here at home.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Pabel Adria), `[726]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Pabel Adria: ""I'm happy you agree.""*)

### Węzeł `[388]`
Mówca: **Pabel Adria**
> ""I'm happy you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Pabel Adria: ""And the sooner, the better.""*)

### Węzeł `[389]`
Mówca: **Pabel Adria**
> ""And the sooner, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "He tossed the morning paper onto my bed."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player_Romus: ""I don't have high hopes, to be honest. The Derdians and ..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player_Romus: ""I've got high hopes for it. The Derdians and I agree on ..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been reading up on the Golcondists. Perhaps Rizia has been too harsh to judge them in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Pabel Adria: ""Interesting, Your Majesty.""*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player_Romus: ""They are going well, thank you. I'm hoping to contract t..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Player_Romus: ""They are going well, thank you. I'm hoping to contract t..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have high hopes, to be honest. The Derdians and I have nothing in common.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0`
- **Kontekst wejściowy (poprzednik):** `[371]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Pabel Adria: ""You know what they say about opposites attracting, Your ..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are going well, thank you. I'm hoping to contract their mercenaries for the war.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[371]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Pabel Adria: ""I see. I've heard they're very skilled fighters.""*)

### Węzeł `[399]`
Mówca: **Pabel Adria**
> ""You know what they say about opposites attracting, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[400]`
Mówca: **Pabel Adria**
> ""'Man, 33, beaten to death in Monqiz Prison... the deceased was identified as Mateus Montalvo, a courier for the Cantuavo vineyards.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Pabel Adria: ""Montalvo had recently been jailed and dismissed from his..."*)

### Węzeł `[401]`
Mówca: **Pabel Adria**
> ""Montalvo had recently been jailed and dismissed from his job after engaging in suspected homosexual activity with a client.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've got high hopes for it. The Derdians and I agree on many points.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[371]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Pabel Adria: ""Do you, Your Majesty?""*)

### Węzeł `[403]`
Mówca: **Pabel Adria**
> ""I see. I've heard they're very skilled fighters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "He tossed the morning paper onto my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Pabel Adria: ""Look at the bottom of the first page.""*)

### Węzeł `[405]`
Mówca: **Pabel Adria**
> ""Look at the bottom of the first page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Pabel Adria: ""'Man, 33, beaten to death in Monqiz Prison... the deceas..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.P..."*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: ""It's a disgrace that this happened during my reign.""*)
  - -> `[418]` (*Player_Romus: ""This is happening in Rizia's prisons? I'll have to impro..."*)
  - -> `[416]` (*Player_Romus: ""Oh, no. Was he arrested because of my investigation?""*)
  - -> `[409]` (*Player_Romus: ""Is that the man you were with in the wine cellar? Allege..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player_Romus: ""Did you know him?""*)
  - -> `[410]` (*Player_Romus: ""With a client? Was he mad?""*)

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that the man you were with in the wine cellar? Allegedly, I mean.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Narrator: "Pabel nodded, his teeth clenched."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With a client? Was he mad?""
- **Wymagania odblokowania (kod gry):** `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Pabel Adria: ""If he's mad, then so am I.""*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you know him?""
- **Wymagania odblokowania (kod gry):** `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "Pabel nodded, his teeth clenched."*)

### Węzeł `[412]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Pabel Adria: ""That isn't the point.""*)

### Węzeł `[413]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Pabel Adria: ""Our encounter was obviously neither his first nor last. ..."*)

### Węzeł `[414]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Pabel Adria: ""We had an encounter some time before your coronation. Cl..."*)

### Węzeł `[415]`
Mówca: **Pabel Adria**
> ""That isn't the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, no. Was he arrested because of my investigation?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[417]`
Mówca: **Pabel Adria**
> ""Our encounter was obviously neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is happening in Rizia's prisons? I'll have to improve security there at once.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Pabel Adria: ""Our encounter was obviously neither his first nor last. ..."*)

### Węzeł `[420]`
Mówca: **Pabel Adria**
> ""We had an encounter some time before your coronation. Clearly neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[421]`
Mówca: **Pabel Adria**
> ""If he's mad, then so am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Pabel Adria: ""We had an encounter some time before your coronation. Cl..."*)

### Węzeł `[422]`
Mówca: **Pabel Adria**
> ""Until homosexuality is no longer a crime in Rizia, people like him -- like me -- are going to keep dying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player_Romus: ""Relax. I'm the king. If you ever get found out, I'll jus..."*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_..."*)
  - -> `[429]` (*Player_Romus: ""If the people of Rizia wanted legal homosexuality, my pa..."*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 4"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a disgrace that this happened during my reign.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Kontekst wejściowy (poprzednik):** `[401]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Narrator: "Pabel nodded, his teeth clenched."*)

### Węzeł `[424]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Pabel Adria: ""He wasn't the first. And he won't be the last.""*)

### Węzeł `[425]`
Mówca: **Pabel Adria**
> ""He wasn't the first. And he won't be the last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Pabel Adria: ""Until homosexuality is no longer a crime in Rizia, peopl..."*)

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I'm the king. If you ever get found out, I'll just pardon you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "Pabel gave me a look of frustration."*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am working to achieve parity between commoners and nobles. I can't let the problems of a tiny minority distract me from that fight.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Pabel Adria: ""Any fight for equal rights should include *all* Rizians...."*)

### Węzeł `[428]`
Mówca: **Narrator**
> "Pabel gave me a look of frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Pabel Adria: ""That's very kind of you, but there are thousands like me..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the people of Rizia wanted legal homosexuality, my parliament would have brought it up by now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[430]`
Mówca: **Pabel Adria**
> ""That's very kind of you, but there are thousands like me in this kingdom. And they count as some of its most vulnerable citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Player_Romus: ""They can move to Derdia. You said it's safe for them the..."*)
  - -> `[563]` (*Player_Romus: ""There are only so many decrees I can make. I have to pri..."*)
  - -> `[562]` (*Player_Romus: ""If I show too much sympathy towards your community, my h..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_..."*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focu..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player_Romus: ""I am working to achieve parity between commoners and nob..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Player_Romus: ""You're talking about a tiny minority of citizens. Why ca..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""Your Mateus was a sinner, and so are you. I can barely s..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Mateus was a sinner, and so are you. I can barely stomach such behavior, let alone enshrine it into law.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "Pabel sighed in frustration."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been wanting to get rid of that law since I became king. But I'm afraid it's going to take more resources than I have.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] <= 4`
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Pabel Adria: ""It is a challenge, I know. Not even Queen Lyza dared to ..."*)

### Węzeł `[439]`
Mówca: **Pabel Adria**
> ""Any fight for equal rights should include *all* Rizians. Regardless of their romantic preferences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[453]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[440]`
Mówca: **Pabel Adria**
> ""This is one instance where democracy doesn't work. You can't wait for the population to catch up with the times. You have to show them the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[453]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[441]`
Mówca: **Narrator**
> "Pabel sighed in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Pabel Adria: ""What kind of sick, twisted God would forbid a person fro..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 4"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority <= 4)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority <= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Player_Romus: ""I've been wanting to get rid of that law since I became ..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority <= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""I have the authority. I can change our kingdom's anti-ho..."*)

### Węzeł `[445]`
Mówca: **Pabel Adria**
> ""It is a challenge, I know. Not even Queen Lyza dared to imagine it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Pabel Adria: ""But Rizia is ready now.""*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are only so many royal decrees I can make. I have to prioritize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[678]` (Pabel Adria), `[682]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've made so much progress for Rizia's working class. They'll see it as a betrayal of their values.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Kontekst wejściowy (poprzednik):** `[439]` (Pabel Adria), `[440]` (Pabel Adria), `[678]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Pabel Adria: ""Whose values? Working-class homosexuals are at more risk..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player_Romus: ""I've made so much progress for Rizia's working class. Th..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: ""The working class will see it as a betrayal of their val..."*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will never accept my plans for reform.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Kontekst wejściowy (poprzednik):** `[439]` (Pabel Adria), `[440]` (Pabel Adria), `[678]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[452]`
Mówca: **Pabel Adria**
> ""Whose values? Working-class homosexuals are at more risk than nearly anyone else in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is still a majority-Wruhecist country. If I made homosexuality legal, the religious backlash could end my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[439]` (Pabel Adria), `[440]` (Pabel Adria), `[678]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Pabel Adria: ""I understand the influence Grand Wiseman Ignacius wields..."*)

### Węzeł `[454]`
Mówca: **Pabel Adria**
> ""I understand the influence Grand Wiseman Ignacius wields. But do you really plan to spend the rest of your reign catering to the Sanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have the authority. I can change our kingdom's anti-homosexuality laws.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Pabel Adria: ""It's a major step forward, I know. Not even Queen Lyza d..."*)

### Węzeł `[456]`
Mówca: **Pabel Adria**
> ""It's a major step forward, I know. Not even Queen Lyza dared to imagine it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Pabel Adria: ""But Rizia is ready now.""*)

### Węzeł `[457]`
Mówca: **Pabel Adria**
> ""What kind of sick, twisted God would forbid a person from experiencing love?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Player_Romus: ""It is true that Wruhecist teachings stress the importanc..."*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[458]` (*Player_Romus: ""It's not God that's sick and twisted. It's you. No offen..."*)
  - -> `[490]` (*Player_Romus: ""A truly devout Wruhecist must abandon all thoughts of ea..."*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not God that's sick and twisted. It's you. No offense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "He hurriedly rose."*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true that Wruhecist teachings stress the importance of bringing joy to others. They do not specify which sex.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Pabel Adria: ""Yes! Precisely!""*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player_Romus: ""The same God who let the Palesians take my daughter from..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who let the Palesians take my daughter from me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[457]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "His expression turned compassionate."*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who took my wife away from me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[457]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Narrator: "His expression turned compassionate."*)

### Węzeł `[465]`
Mówca: **Narrator**
> "His expression turned compassionate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Pabel Adria: ""You're going through a hard time, I know.""*)

### Węzeł `[466]`
Mówca: **Pabel Adria**
> ""You're going through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Pabel Adria: ""But you deserve love.""*)

### Węzeł `[467]`
Mówca: **Pabel Adria**
> ""But you deserve love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Pabel Adria: ""All of us do.""*)

### Węzeł `[468]`
Mówca: **Narrator**
> "His expression turned compassionate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Pabel Adria: ""You've gone through a hard time, I know.""*)

### Węzeł `[469]`
Mówca: **Pabel Adria**
> ""You've gone through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Pabel Adria: ""But remember the joy you experienced during your marriag..."*)

### Węzeł `[470]`
Mówca: **Pabel Adria**
> ""Yes! Precisely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Pabel Adria: ""Is it such a stretch to imagine that a bond of affection..."*)

### Węzeł `[471]`
Mówca: **Pabel Adria**
> ""Is it such a stretch to imagine that a bond of affection between two men can be as pure -- as holy -- as that between a man and a woman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Player_Romus: ""Personally, I would rather not imagine it. But political..."*)
  - -> `[483]` (*Player_Romus: ""The Dastnurists would hate me if I took that leap.""*)
  - -> `[484]` (*Player_Romus: ""I'm still worried about what my house will think.""*)
  - -> `[485]` (*Player_Romus: ""It's not a stretch at all. Why is my butler talking more..."*)

### Węzeł `[472]`
Mówca: **Pabel Adria**
> ""Then as your friend, I beg of you. Prioritize this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[473]`
Mówca: **Pabel Adria**
> ""If not now, then when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Pabel Adria: ""I beg your pardon, but from what I can tell your relatio..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Pabel Adria: ""Your approval means as much to House Toras as theirs mea..."*)

### Węzeł `[477]`
Mówca: **Pabel Adria**
> ""Your approval means as much to House Toras as theirs means to you. They can be won over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[535]` (*Player_Romus: ""Even if I made homosexuality legal tomorrow, you couldn'..."*)
  - -> `[537]` (*Player_Romus: ""You're right. I have a historic opportunity. I've got to..."*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia may be ready, but House Toras is not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[614]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[479]`
Mówca: **Pabel Adria**
> ""I've got to go oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Player_Romus: ""Repent, Pabel. Before it's too late.""*)
  - -> `[510]` (*Player_Romus: ""I'm sorry. I wish I could see it differently.""*)
  - -> `[505]` (*Player_Romus: ""You shouldn't be worried. I am seeing clearly for the fi..."*)
  - -> `[502]` (*Player_Romus: ""I will think about what you said. I promise.""*)

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Repent, Pabel. Before it's too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Pabel Adria), `[560]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Pabel Adria: ""It's already too late for Mateus.""*)

### Węzeł `[481]`
Mówca: **Pabel Adria**
> ""It's already too late for Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Pabel Adria: ""Pardon my frustration. I'll see you shortly.""*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Personally, I would rather not imagine it. But politically, it'd give us an edge with Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Pabel Adria: ""As well as with the Golcondists living here in Rizia.""*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists would hate me if I took that leap.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Pabel Adria: ""They are still a minority here. You can afford to lose t..."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still worried about what my house will think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a stretch at all. Why is my butler talking more sense than my religious councilor?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Pabel Adria: ""Because the Grand Wiseman hasn't been intimate since bef..."*)

### Węzeł `[486]`
Mówca: **Pabel Adria**
> ""Because the Grand Wiseman hasn't been intimate since before the invention of the automobile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[487]`
Mówca: **Pabel Adria**
> ""They are still a minority here. You can afford to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[488]`
Mówca: **Pabel Adria**
> ""But that's not the real reason the law should be changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[489]`
Mówca: **Pabel Adria**
> ""It's not just about what I want. This is a universal struggle. Think of the example you'd be setting for the rest of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[535]` (*Player_Romus: ""Even if I made homosexuality legal tomorrow, you couldn'..."*)
  - -> `[537]` (*Player_Romus: ""You're right. I have a historic opportunity. I've got to..."*)
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly devout Wruhecist must abandon all thoughts of earthly pleasure if he is to achieve Golconda.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "He hurriedly rose."*)

### Węzeł `[491]`
Mówca: **Pabel Adria**
> ""But friend to friend... all this religious talk is starting to worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Pabel Adria: ""I've got to go oversee breakfast. I'll leave you to dres..."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Decriminalizing homosexuality will definitely give us an edge with Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[614]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Pabel Adria: ""As well as with the Golcondists living here in Rizia.""*)

### Węzeł `[493]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Pabel Adria: ""But friend to friend... all this religious talk is start..."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will disown me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[439]` (Pabel Adria), `[440]` (Pabel Adria), `[678]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player_Romus: ""Still, we're in the middle of a war. It's not the time t..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[498]`
Mówca: **Pabel Adria**
> ""I beg your pardon, but from what I can tell your relationship with your family is already beyond repair. What's one more burned bridge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player_Romus: ""I've already got my council and the House of Delegates t..."*)
  - -> `[535]` (*Player_Romus: ""Even if I made homosexuality legal tomorrow, you couldn'..."*)
  - -> `[537]` (*Player_Romus: ""You're right. I have a historic opportunity. I've got to..."*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists will hate it, though. What am I supposed to tell Rumburg?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[614]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Pabel Adria: ""Isn't Queen Beatrice a proponent of secularization? She'..."*)

### Węzeł `[500]`
Mówca: **Pabel Adria**
> ""Isn't Queen Beatrice a proponent of secularization? She'll understand the need to separate state laws from religious ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, we're in the middle of a war. It's not the time to go around making huge changes.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[439]` (Pabel Adria), `[440]` (Pabel Adria), `[614]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Pabel Adria: ""If not now, then when?""*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will think about what you said. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Pabel Adria: ""Please do.""*)

### Węzeł `[503]`
Mówca: **Pabel Adria**
> ""Please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Pabel Adria: ""It's too late for Mateus. But not for many others.""*)

### Węzeł `[504]`
Mówca: **Pabel Adria**
> ""As well as with the Golcondists living here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Pabel Adria: ""But that's not the real reason the law should be changed.""*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't be worried. I am seeing clearly for the first time in my life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""Then why can't you see homosexuals as people?""*)

### Węzeł `[506]`
Mówca: **Pabel Adria**
> ""Then why can't you see homosexuals as people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Pabel Adria: ""Pardon my frustration. I'll see you shortly.""*)

### Węzeł `[507]`
Mówca: **Pabel Adria**
> ""Pardon my frustration. I'll see you shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[508]`
Mówca: **Narrator**
> "He bowed and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[509]`
Mówca: **Pabel Adria**
> ""It's too late for Mateus. But not for many others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. I wish I could see it differently.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Pabel Adria), `[560]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Pabel Adria: ""Don't apologize to me. Apologize to Mateus.""*)

### Węzeł `[511]`
Mówca: **Pabel Adria**
> ""Don't apologize to me. Apologize to Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Pabel Adria: ""Pardon my frustration. I'll see you shortly.""*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The working class will see it as a betrayal of their values.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[439]` (Pabel Adria), `[440]` (Pabel Adria), `[678]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Pabel Adria: ""Whose values? Working-class homosexuals are at more risk..."*)

### Węzeł `[513]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Pabel Adria: ""I'm late to oversee breakfast. I'll leave you to dress y..."*)

### Węzeł `[514]`
Mówca: **Pabel Adria**
> ""I am sorry, Your Majesty. I was mistaken to conflate our past friendship with our professional relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Pabel Adria: ""I'm late to oversee breakfast. I'll leave you to dress y..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "His face turned stony."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Narrator: "Pabel looked crestfallen."*)

### Węzeł `[518]`
Mówca: **Narrator**
> "His expression softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Pabel Adria: ""I know. Forgive my impatience.""*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My child might die. That's what's important to me right now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[541]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Pabel Adria: ""Mateus was someone's child, too.""*)

### Węzeł `[520]`
Mówca: **Pabel Adria**
> ""Mateus was someone's child, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Pabel Adria: ""I'm late to oversee breakfast. I'll leave you to dress y..."*)

### Węzeł `[521]`
Mówca: **Pabel Adria**
> ""I know. Forgive my impatience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Pabel Adria: ""I'm late to oversee breakfast. I'll leave you to dress y..."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "His face turned stony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Pabel Adria: ""It's not an agenda. It's a crisis. How many more of us h..."*)

### Węzeł `[523]`
Mówca: **Pabel Adria**
> ""It's not an agenda. It's a crisis. How many more of us have to die before you see it the same way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Pabel Adria: ""I'm late to oversee breakfast. I'll leave you to dress y..."*)

### Węzeł `[524]`
Mówca: **Narrator**
> "He bowed and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[525]`
Mówca: **Narrator**
> "He bowed and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[526]`
Mówca: **Pabel Adria**
> ""Un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[527]`
Mówca: **Pabel Adria**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll look into making a decree. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Pabel Adria: ""Thank you.""*)

### Węzeł `[529]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0`
- **Kontekst wejściowy (poprzednik):** `[531]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Pabel Adria: ""Un oxit solu.""*)

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about your lover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Pabel Adria: ""Thank you.""*)

### Węzeł `[531]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Player_Romus: ""I'll look into making a decree. I promise.""*)
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)
  - -> `[530]` (*Player_Romus: ""I'm sorry about your lover.""*)
  - -> `[580]` (*Player_Romus: ""What do I wear?""*)

### Węzeł `[532]`
Mówca: **Pabel Adria**
> ""I'm so sorry, Your Majesty. I won't bring up personal topics with you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Pabel Adria: ""I'm late to oversee breakfast. I'll leave you to dress y..."*)

### Węzeł `[533]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already got my council and the House of Delegates telling me what to do. Now I have to take orders from my butler?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Pabel Adria), `[489]` (Pabel Adria), `[498]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Narrator: "He stood up indignantly."*)

### Węzeł `[535]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if I made homosexuality legal tomorrow, you couldn't go parading about town in a ball gown. Royal protocol must be observed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Pabel Adria), `[489]` (Pabel Adria), `[498]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Pabel Adria: ""I assure you I will be as discreet as ever. I will merel..."*)

### Węzeł `[536]`
Mówca: **Pabel Adria**
> ""I assure you I will be as discreet as ever. I will merely be happy to see fewer of my kind imprisoned, killed or exiled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Pabel Adria: ""And not all homosexual men wear  gowns. Just as not all ..."*)

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I have a historic opportunity. I've got to seize it while I still can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Pabel Adria), `[489]` (Pabel Adria), `[498]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Pabel Adria: ""The sooner you do, the more lives will be saved.""*)

### Węzeł `[538]`
Mówca: **Pabel Adria**
> ""The sooner you do, the more lives will be saved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Narrator: "He stood up."*)

### Węzeł `[539]`
Mówca: **Narrator**
> "He stood up indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then keep your mouth shut. You're my servant, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Pabel Adria), `[571]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 3"*)

### Węzeł `[541]`
Mówca: **Pabel Adria**
> ""But if this isn't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Player_Romus: ""Then keep your mouth shut. You're my servant, remember?""*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[546]` (*Player_Romus: ""Is that why you worked your way up to head butler? To pu..."*)
  - -> `[542]` (*Player_Romus: ""It's important to me. But it won't happen overnight.""*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's important to me. But it won't happen overnight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "His expression softened."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Player_Romus: ""My child might die. That's what's important to me right ..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that why you worked your way up to head butler? To push your... lavender agenda?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Pabel Adria), `[571]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "His face turned stony."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Player_Romus: ""The same God who took my wife away from me.""*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player_Romus: ""Plenty of people don't get to experience love. I didn't.""*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Plenty of people don't get to experience love. I didn't.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[457]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Pabel Adria: ""That's not a reason to deny it to others.""*)

### Węzeł `[551]`
Mówca: **Pabel Adria**
> ""That's not a reason to deny it to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "He hurriedly rose."*)

### Węzeł `[552]`
Mówca: **Pabel Adria**
> ""But remember the joy you experienced during your marriage to Princess Lena. Shouldn't everyone get a chance at that, even if it ends in heartbreak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Pabel Adria: ""I've got to go oversee breakfast. I'll leave you to dres..."*)

### Węzeł `[553]`
Mówca: **Narrator**
> "He hurriedly rose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Pabel Adria: ""I care about you, Romus. I always have.""*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Pabel Adria: ""I shouldn't have brought this up with you, Your Majesty.""*)

### Węzeł `[557]`
Mówca: **Pabel Adria**
> ""I shouldn't have brought this up with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Pabel Adria: ""Please forget I said anything.""*)

### Węzeł `[558]`
Mówca: **Pabel Adria**
> ""Please forget I said anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Pabel Adria: ""I've got to go oversee breakfast. I'll leave you to dres..."*)

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will gladly forget it. And I'll thank you not to trouble me with such talk again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Pabel Adria: ""I won't.""*)

### Węzeł `[560]`
Mówca: **Pabel Adria**
> ""I've got to go oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Player_Romus: ""Repent, Pabel. Before it's too late.""*)
  - -> `[510]` (*Player_Romus: ""I'm sorry. I wish I could see it differently.""*)
  - -> `[559]` (*Player_Romus: ""I will gladly forget it. And I'll thank you not to troub..."*)

### Węzeł `[561]`
Mówca: **Pabel Adria**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will disown me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[563]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are only so many decrees I can make. I have to prioritize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They can move to Derdia. You said it's safe for them there, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Pabel Adria: ""Not everyone has the resources to flee the country. And ..."*)

### Węzeł `[565]`
Mówca: **Pabel Adria**
> ""Not everyone has the resources to flee the country. And living as a Golcondist is hardly an ideal solution, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Narrator: "He stood up."*)

### Węzeł `[566]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Pabel Adria: ""I care about you, Romus. I always have.""*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Pabel Adria: ""I'm grateful that you respect my identity, Your Majesty.""*)

### Węzeł `[570]`
Mówca: **Pabel Adria**
> ""I'm grateful that you respect my identity, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Pabel Adria: ""But if the lives of other homosexuals in Rizia aren't im..."*)

### Węzeł `[571]`
Mówca: **Pabel Adria**
> ""But if the lives of other homosexuals in Rizia aren't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Player_Romus: ""Then keep your mouth shut. You're my servant, remember?""*)
  - -> `[546]` (*Player_Romus: ""Is that why you worked your way up to head butler? To pu..."*)
  - -> `[573]` (*Player_Romus: ""They are important to me. But I can't make change happen..."*)

### Węzeł `[572]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Pabel Adria: ""But if this isn't important to you... I don't know what ..."*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are important to me. But I can't make change happen overnight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[571]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "His expression softened."*)

### Węzeł `[574]`
Mówca: **Narrator**
> "Pabel looked crestfallen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Pabel Adria: ""I'm so sorry, Your Majesty. I won't bring up personal to..."*)

### Węzeł `[575]`
Mówca: **Narrator**
> "His face turned stony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Pabel Adria: ""I am sorry, Your Majesty. I was mistaken to conflate our..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true && Rizi..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Player_Romus: ""Bi mare volu...""*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[579]`
Mówca: **Pabel Adria**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do I wear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Pabel Adria: ""Navy blue suit, burgundy pocket square. The diamond cuff..."*)

### Węzeł `[581]`
Mówca: **Pabel Adria**
> ""Navy blue suit, burgundy pocket square. The diamond cuff links Hugo gave you for your birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "He bowed and swiftly left the room."*)

### Węzeł `[582]`
Mówca: **Narrator**
> "After taking a moment to collect my thoughts, I dressed and headed downstairs for breakfast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexual..."*)

### Węzeł `[583]`
Mówca: **Pabel Adria**
> ""He wasn't my lover. But I'm sorry too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "He leaned down and kissed me, then swiftly disappeared in..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true"*)
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true)"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Pabel Adria: ""Even a king needs to close his eyes sometimes. I'll ask ..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Pabel Adria: ""Even a king needs to close his eyes sometimes. I'll ask ..."*)

### Węzeł `[587]`
Mówca: **Pabel Adria**
> ""Even a king needs to close his eyes sometimes. I'll ask the chef to procure some valerian root for tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "He began drawing open my curtains, then stopped and spoke..."*)

### Węzeł `[588]`
Mówca: **Pabel Adria**
> ""All of us do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Pabel Adria: ""I've got to go oversee breakfast. I'll leave you to dres..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[590]`
Mówca: **Pabel Adria**
> ""Interesting, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are going well, thank you. I'm hoping to contract their mercenaries for use in Zille.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[371]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Pabel Adria: ""I see. I've heard they're very skilled fighters.""*)

### Węzeł `[592]`
Mówca: **Pabel Adria**
> ""Do you, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[593]`
Mówca: **Pabel Adria**
> ""It's one of the only places in Merkopa where relations between members of the same sex are accepted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == true"*)
  - -> `[600]` (*Player_Romus: ""Would you ever move there, Pabel?""*)
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of the many perversions of Golcondism.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Kontekst wejściowy (poprzednik):** `[593]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Pabel Adria: ""I wouldn't call it that, exactly...""*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == true"*)
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_GolcondistBlasphemy == true)"*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Player_Romus: ""One of the many perversions of Golcondism.""*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_GolcondistBlasphemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Player_Romus: ""Are you saying that in some respects, Golcondists are mo..."*)

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying that in some respects, Golcondists are more enlightened than mainstream Wruhecists?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[593]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Pabel Adria: ""Well, not exactly...""*)

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A fascinating contradiction. How can such an extremist society allow homosexuality?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[593]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Pabel Adria: ""The only reason Derdia allows homosexuality is because G..."*)

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you ever move there, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[593]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Pabel Adria: ""Only in an emergency.""*)

### Węzeł `[601]`
Mówca: **Pabel Adria**
> ""The only reason Derdia allows homosexuality is because Golcondists view intimacy between men as the most sacred form of love. They say it strengthens bonds on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Pabel Adria: ""As for women... as long as they accept their role as pro..."*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It could greatly improve our image in the war. A kingdom that grants rights to women and homosexuals can't be an aggressor.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[489]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Pabel Adria: ""That's not precisely what I meant.""*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Player_Romus: ""It could greatly improve our image in the war. A kingdom..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[606]`
Mówca: **Pabel Adria**
> ""And not all homosexual men wear  gowns. Just as not all men who wear gowns are homosexual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Narrator: "He stood up."*)

### Węzeł `[607]`
Mówca: **Pabel Adria**
> ""That's not precisely what I meant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Narrator: "He stood up."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Pabel Adria: ""Then as your friend, I beg of you. Prioritize this one.""*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Pabel Adria: ""Then as your butler and humble subject, I beg of you. Pr..."*)

### Węzeł `[611]`
Mówca: **Pabel Adria**
> ""Then as your butler and humble subject, I beg of you. Prioritize this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Pabel Adria: ""It's not just about what I want. This is a universal str..."*)

### Węzeł `[612]`
Mówca: **Pabel Adria**
> ""Only in an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[613]`
Mówca: **Pabel Adria**
> ""As for women... as long as they accept their role as providers and childbearers, they may consort among themselves if they wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Pabel Adria: ""It's not perfect. But I understand the desire to live op..."*)

### Węzeł `[614]`
Mówca: **Pabel Adria**
> ""But Rizia is ready now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[492]` (*Player_Romus: ""Decriminalizing homosexuality will definitely give us an..."*)
  - -> `[499]` (*Player_Romus: ""The Dastnurists will hate it, though. What am I supposed..."*)
  - -> `[478]` (*Player_Romus: ""Rizia may be ready, but House Toras is not.""*)

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the land of blasphemous lunatics, you mean? I couldn't be more excited.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Pabel Adria: ""Not all of their beliefs are crazy.""*)

### Węzeł `[616]`
Mówca: **Pabel Adria**
> ""Not all of their beliefs are crazy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[617]`
Mówca: **Narrator**
> "He paused. I saw a flash of melancholy in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Pabel Adria: ""I don't know if you're aware, but many Rizians of my per..."*)

### Węzeł `[618]`
Mówca: **Pabel Adria**
> ""I don't know if you're aware, but many Rizians of my persuasion have fled to Derdia since its establishment as a Golcondist republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Pabel Adria: ""It's one of the only places in Merkopa where relations b..."*)

### Węzeł `[619]`
Mówca: **Pabel Adria**
> ""It's not perfect. But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Player_Romus: ""It can't be that bad in Rizia. Can it?""*)
  - -> `[621]` (*Player_Romus: ""Derdia's attitude towards homosexuality is just an exten..."*)
  - -> `[622]` (*Player_Romus: ""Boring. Without the lure of the forbidden, I might as we..."*)
  - -> `[629]` (*Player_Romus: ""So do I. They should never have had to flee Rizia.""*)

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It can't be that bad in Rizia. Can it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Pabel Adria), `[763]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Narrator: "His eyes darkened."*)

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derdia's attitude towards homosexuality is just an extension of the deep-seated sexism in its society. How could anyone prefer that to our kingdom?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Pabel Adria), `[763]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Pabel Adria: ""Because of what our kingdom does to homosexuals who get ..."*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Boring. Without the lure of the forbidden, I might as well be with a woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Pabel Adria), `[763]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Narrator: "Outrage flashed in his eyes."*)

### Węzeł `[623]`
Mówca: **Pabel Adria**
> ""You don't know the half of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[624]`
Mówca: **Narrator**
> "His eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Pabel Adria: ""You don't know the half of it.""*)

### Węzeł `[625]`
Mówca: **Narrator**
> "Outrage flashed in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Pabel Adria: ""Do you mean that, Romus? Is this a game to you?""*)

### Węzeł `[626]`
Mówca: **Pabel Adria**
> ""Do you mean that, Romus? Is this a game to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[627]`
Mówca: **Pabel Adria**
> ""Because of what our kingdom does to homosexuals who get caught.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Pabel Adria: ""Here.""*)

### Węzeł `[628]`
Mówca: **Pabel Adria**
> ""Here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[629]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So do I. They should never have had to flee Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Pabel Adria), `[763]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Pabel Adria: ""And those who fled are the lucky ones.""*)

### Węzeł `[630]`
Mówca: **Pabel Adria**
> ""And those who fled are the lucky ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0"*)
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0)"*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Player_Romus: ""I don't have high hopes, to be honest. The Derdians and ..."*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Player_Romus: ""I've got high hopes for it. The Derdians and I agree on ..."*)

### Węzeł `[634]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aha. You're jealous that I get to go to the homosexual country and you don't.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Pabel Adria: ""Well, yes. A little.""*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Player_Romus: ""As well as can be expected. I'm hoping to contract their..."*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Player_Romus: ""As well as can be expected. I'm hoping to contract their..."*)

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have high hopes, to be honest. The Derdians and I have nothing in common.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0`
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Pabel Adria: ""Nothing? Are you certain about that?""*)

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As well as can be expected. I'm hoping to contract their mercenaries for the war.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Pabel Adria: ""Ah. I've heard they're very skilled fighters.""*)

### Węzeł `[640]`
Mówca: **Pabel Adria**
> ""Nothing? Are you certain about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've got high hopes for it. The Derdians and I agree on many points.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Pabel Adria: ""Do you? Interesting.""*)

### Węzeł `[642]`
Mówca: **Pabel Adria**
> ""Ah. I've heard they're very skilled fighters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[643]`
Mówca: **Pabel Adria**
> ""Well, yes. A little.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As well as can be expected. I'm hoping to contract their mercenaries for use in Zille.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Pabel Adria: ""Ah. I've heard they're very skilled fighters.""*)

### Węzeł `[645]`
Mówca: **Pabel Adria**
> ""Do you? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[646]`
Mówca: **Pabel Adria**
> ""It's one of the only places in Merkopa where relations between members of the same sex are accepted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == true"*)
  - -> `[653]` (*Player_Romus: ""Would you ever move there, Pabel?""*)
  - -> `[657]` (*Player_Romus: ""I would love to permit such a thing in Rizia, but I'd lo..."*)
  - -> `[757]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of the many perversions of Golcondism.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Kontekst wejściowy (poprzednik):** `[646]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Pabel Adria: ""Since when is what we're doing a perversion?""*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_GolcondistBlasphemy == true"*)
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_GolcondistBlasphemy == true)"*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_GolcondistBlasphemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Player_Romus: ""One of the many perversions of Golcondism.""*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_GolcondistBlasphemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Player_Romus: ""Are you saying that in some respects, Golcondists are mo..."*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying that in some respects, Golcondists are more enlightened than mainstream Wruhecists?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[646]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Pabel Adria: ""No, not exactly...""*)

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A fascinating contradiction. How can such an extremist society allow homosexuality?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[646]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Pabel Adria: ""The only reason homosexuality is allowed in Derdia is be..."*)

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you ever move there, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[646]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Pabel Adria: ""And leave my king? Never. But I do sometimes wonder what..."*)

### Węzeł `[654]`
Mówca: **Pabel Adria**
> ""The only reason homosexuality is allowed in Derdia is because Golcondists view intimacy between men as the most sacred form of love. They say it strengthens bonds on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Pabel Adria: ""As for women... as long as they accept their role as pro..."*)

### Węzeł `[655]`
Mówca: **Pabel Adria**
> ""And leave my king? Never. But I do sometimes wonder what such a society is like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[656]`
Mówca: **Pabel Adria**
> ""As for women... as long as they accept their role as providers and childbearers, they may consort among themselves if they wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Pabel Adria: ""It's not perfect. But I understand the desire to live op..."*)

### Węzeł `[657]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would love to permit such a thing in Rizia, but I'd lose the throne in an instant. All of society is against it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[646]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Pabel Adria: ""To be fair, the Derdians are far from enlightened.""*)

### Węzeł `[658]`
Mówca: **Pabel Adria**
> ""To be fair, the Derdians are far from enlightened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[659]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true that Wruhecist teachings stress the importance of bringing joy to others. They do not specify which sex.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[180]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[660]`
Mówca: **Pabel Adria**
> ""Yes! Precisely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Pabel Adria: ""Is it really such a stretch to imagine that the love bet..."*)

### Węzeł `[661]`
Mówca: **Pabel Adria**
> ""Is it really such a stretch to imagine that the love between two men can be as pure -- as holy -- as that between members of the opposite sex?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""Whether or not I personally agree, classifying it as suc..."*)
  - -> `[254]` (*Player_Romus: ""The Dastnurists would hate me if I took that leap.""*)
  - -> `[255]` (*Player_Romus: ""I'm still worried about what my house will think.""*)
  - -> `[256]` (*Player_Romus: ""It's not a stretch at all. Why is my butler talking more..."*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)"*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Pabel Adria: ""Yes! Precisely!""*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Pabel Adria: ""Exactly. And don't even try to tell me I didn't bring jo..."*)

### Węzeł `[665]`
Mówca: **Pabel Adria**
> ""Exactly. And don't even try to tell me I didn't bring joy to you just now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Pabel Adria: ""Is it really such a stretch to imagine that the love bet..."*)

### Węzeł `[666]`
Mówca: **Pabel Adria**
> ""No, not exactly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Narrator: "He frowned."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "He stared me down coldly."*)

### Węzeł `[669]`
Mówca: **Narrator**
> "Pabel put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Pabel Adria: ""I know. But Mateus was someone's child, too.""*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_PoemScroll");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_PoemScroll");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: ""Find me in the labyrinth of past memories,   left at the..."*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");

// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Few other palace staff were about as I wandered into the ..."*)

### Węzeł `[672]`
Mówca: **Pabel Adria**
> ""Since when is what we're doing a perversion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Narrator: "He frowned."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");

// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true"*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Narrator: "After taking a moment to collect my thoughts, I dressed a..."*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Breather", "R_Breather_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "Early in the morning, I heard a soft tap on the door to m..."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're talking about a tiny minority of citizens. Why cater to them at the expense of everyone else?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[422]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Pabel Adria: ""Why would it have to be at anyone's expense? Who are we ..."*)

### Węzeł `[678]`
Mówca: **Pabel Adria**
> ""Why would it have to be at anyone's expense? Who are we hurting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Player_Romus: ""There are only so many royal decrees I can make. I have ..."*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[453]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Pabel Adria: ""This is one instance where democracy doesn't work. You c..."*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Pabel Adria: ""You know very well that your parliament only puts forth ..."*)

### Węzeł `[682]`
Mówca: **Pabel Adria**
> ""You know very well that your parliament only puts forth the interests of the nobility. Who can afford to keep their perversions hidden away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Player_Romus: ""There are only so many royal decrees I can make. I have ..."*)
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[453]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Player_Romus: ""If I show too much sympathy towards your community, my h..."*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""If I show too much sympathy towards your community, my h..."*)

### Węzeł `[686]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Rizia wanted legal homosexuality, my parliament would have brought it up by now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Pabel Adria: ""We're talking about basic human rights. You can't wait f..."*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Pabel Adria: ""You know very well that your parliament only puts forth ..."*)

### Węzeł `[690]`
Mówca: **Pabel Adria**
> ""You know very well that your parliament only puts forth the interests of the nobility. Who can afford to keep their perversions hidden away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""If I show too much sympathy towards your community, my h..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player_Romus: ""If I show too much sympathy towards your community, my h..."*)

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is still a majority-Wruhecist country. If I made homosexuality legal, the religious backlash could end my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Pabel Adria), `[690]` (Pabel Adria), `[696]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Pabel Adria: ""I understand the influence Grand Wiseman Ignacius wields..."*)

### Węzeł `[695]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People like us represent a tiny minority of citizens. Why focus on them at the expense of everyone else?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Pabel Adria: ""Why would it have to be at anyone's expense? Who are we ..."*)

### Węzeł `[696]`
Mówca: **Pabel Adria**
> ""Why would it have to be at anyone's expense? Who are we hurting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""There are only so many decrees I can make as king. I hav..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[694]` (*Player_Romus: ""Rizia is still a majority-Wruhecist country. If I made h..."*)

### Węzeł `[697]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derdia's attitude towards homosexuality is just an extension of the deep-seated sexism in its society. How could anyone prefer that to our kingdom?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Pabel Adria), `[726]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Pabel Adria: ""Because of what our kingdom does to homosexuals who get ..."*)

### Węzeł `[698]`
Mówca: **Pabel Adria**
> ""Because of what our kingdom does to homosexuals who get caught.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Pabel Adria: ""Here.""*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Pabel Adria: ""How are preparations going for your royal visit to Derdia?""*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Pabel Adria: ""Palace scuttlebutt has it you turned down the chance to ..."*)

### Węzeł `[702]`
Mówca: **Pabel Adria**
> ""Palace scuttlebutt has it you turned down the chance to visit Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Player_Romus: ""Why do you care about my diplomatic dealings?""*)
  - -> `[705]` (*Player_Romus: ""Yes, I don't want to have any more contact with those lu..."*)
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true"*)
  - -> `[711]` (*Player_Romus: ""It would've been counterproductive. I'll have better rel..."*)
  - -> `[713]` (*Player_Romus: ""Yes, and I'm regretting it now. I'd be interested in see..."*)

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you care about my diplomatic dealings?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[702]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Pabel Adria: ""I know it's not my business. But I would have been curio..."*)

### Węzeł `[704]`
Mówca: **Pabel Adria**
> ""I know it's not my business. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I don't want to have any more contact with those lunatics than I need to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[702]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Pabel Adria: ""Understandable. But I would have been curious to hear wh..."*)

### Węzeł `[706]`
Mówca: **Pabel Adria**
> ""Understandable. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would have been a waste of time. Rizia's place is among the monarchies of GRACE, not scrabbling for favor with our neighbors.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true`
- **Kontekst wejściowy (poprzednik):** `[702]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Pabel Adria: ""Understandable. But I would have been curious to hear wh..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true"*)
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)"*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Player_Romus: ""It would have been a waste of time. Rizia's place is amo..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would've been counterproductive. I'll have better relations with our other international partners if I avoid Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[702]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Pabel Adria: ""I see. Still, I would have been curious what you thought..."*)

### Węzeł `[712]`
Mówca: **Pabel Adria**
> ""I see. Still, I would have been curious what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[713]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I'm regretting it now. I'd be interested in seeing how they live over there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[702]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Pabel Adria: ""As would I.""*)

### Węzeł `[714]`
Mówca: **Pabel Adria**
> ""As would I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "He paused again, as if in deliberation. Finally, he walke..."*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedDerdianHomosexuality == true)"*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Player_Romus: ""Accepted and condoned. Sal told me all about this.""*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedDerdianHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Player_Romus: ""A fascinating contradiction. How can such an extremist s..."*)

### Węzeł `[718]`
Mówca: **Pabel Adria**
> ""I wouldn't call it that, exactly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedDerdianHomosexuality == true)"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Pabel Adria: ""I don't agree with Derdia's religious justification for ..."*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedDerdianHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Pabel Adria: ""The only reason Derdia allows homosexuality is because G..."*)

### Węzeł `[722]`
Mówca: **Pabel Adria**
> ""Well, not exactly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[723]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Accepted and condoned. Sal told me all about this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Kontekst wejściowy (poprzednik):** `[593]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Pabel Adria: ""With a judgemental scowl on his face, no doubt.""*)

### Węzeł `[724]`
Mówca: **Pabel Adria**
> ""With a judgemental scowl on his face, no doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Pabel Adria: ""I don't agree with Derdia's religious justification for ..."*)

### Węzeł `[725]`
Mówca: **Pabel Adria**
> ""I don't agree with Derdia's religious justification for homosexuality. And I certainly don't like their martial culture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Pabel Adria: ""But I understand the desire to live openly among fundame..."*)

### Węzeł `[726]`
Mówca: **Pabel Adria**
> ""But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player_Romus: ""It can't be that bad in Rizia. Can it?""*)
  - -> `[697]` (*Player_Romus: ""Derdia's attitude towards homosexuality is just an exten..."*)
  - -> `[381]` (*Player_Romus: ""Really? I thought the lure of the forbidden was part of ..."*)
  - -> `[387]` (*Player_Romus: ""Something must be done to improve the status of your kin..."*)

### Węzeł `[727]`
Mówca: **Pabel Adria**
> ""So, palace scuttlebutt has it you turned down the chance to visit Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Player_Romus: ""Since when do you care about my diplomatic dealings?""*)
  - -> `[730]` (*Player_Romus: ""I don't want to have any more contact with those lunatic..."*)
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true"*)
  - -> `[738]` (*Player_Romus: ""It would've been counterproductive. I'll have better rel..."*)
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since when do you care about my diplomatic dealings?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Pabel Adria: ""I know it's not my business. But I would have been curio..."*)

### Węzeł `[729]`
Mówca: **Pabel Adria**
> ""I know it's not my business. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to have any more contact with those lunatics than I need to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Pabel Adria: ""Understandable. But I would have been curious to hear wh..."*)

### Węzeł `[731]`
Mówca: **Pabel Adria**
> ""Understandable. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[732]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would have been a waste of time. Rizia's place is among the monarchies of GRACE, not scrabbling for favor with our neighbors.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true`
- **Kontekst wejściowy (poprzednik):** `[727]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Pabel Adria: ""Understandable. But I would have been curious to hear wh..."*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true"*)
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)"*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Player_Romus: ""It would have been a waste of time. Rizia's place is amo..."*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I'm regretting it now. I'd be interested in seeing how they live over there.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[727]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Pabel Adria: ""So would I.""*)

### Węzeł `[737]`
Mówca: **Pabel Adria**
> ""So would I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[738]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would've been counterproductive. I'll have better relations with our other international partners if I avoid Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Pabel Adria: ""Sure. Still, I would have been curious what you thought ..."*)

### Węzeł `[739]`
Mówca: **Pabel Adria**
> ""Sure. Still, I would have been curious what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)"*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Pabel Adria: ""Your royal visit to Derdia is coming up, isn't it? How a..."*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Pabel Adria: ""So, palace scuttlebutt has it you turned down the chance..."*)

### Węzeł `[743]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedDerdianHomosexuality == true)"*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Pabel Adria: ""I don't agree with the Derdians' religious justification..."*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedDerdianHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Pabel Adria: ""The only reason homosexuality is allowed in Derdia is be..."*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedDerdianHomosexuality == true)"*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Player_Romus: ""You should be glad. What if I went there and some handso..."*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedDerdianHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Player_Romus: ""Yes, and I'm regretting it now. I'd be interested in see..."*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedDerdianHomosexuality == true)"*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Player_Romus: ""Aha. You're jealous that I get to go to the homosexual c..."*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedDerdianHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Player_Romus: ""Since when do you care about my diplomatic dealings?""*)

### Węzeł `[752]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since when do you care about my diplomatic dealings?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Pabel Adria: ""I don't, usually. But this one is different.""*)

### Węzeł `[753]`
Mówca: **Pabel Adria**
> ""I don't, usually. But this one is different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[754]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should be glad. What if I went there and some handsome, virile Golcondist warrior swept me off my feet?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Kontekst wejściowy (poprzednik):** `[727]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Pabel Adria: ""At least neither of you would be jailed for it.""*)

### Węzeł `[755]`
Mówca: **Pabel Adria**
> ""At least neither of you would be jailed for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "He paused. I saw a flash of melancholy in his eyes."*)

### Węzeł `[756]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)

### Węzeł `[757]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedDerdianHomosexuality == true"*)
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedDerdianHomosexuality == true)"*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedDerdianHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Player_Romus: ""Accepted and condoned. Sal told me all about this.""*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedDerdianHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Player_Romus: ""A fascinating contradiction. How can such an extremist s..."*)

### Węzeł `[760]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Accepted and condoned. Sal told me all about this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Kontekst wejściowy (poprzednik):** `[646]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Pabel Adria: ""With a judgemental frown on his face, no doubt.""*)

### Węzeł `[761]`
Mówca: **Pabel Adria**
> ""With a judgemental frown on his face, no doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Pabel Adria: ""I don't agree with the Derdians' religious justification..."*)

### Węzeł `[762]`
Mówca: **Pabel Adria**
> ""I don't agree with the Derdians' religious justification for homosexuality. And I certainly don't like their martial culture...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Pabel Adria: ""But I understand the desire to live openly among fundame..."*)

### Węzeł `[763]`
Mówca: **Pabel Adria**
> ""But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Player_Romus: ""It can't be that bad in Rizia. Can it?""*)
  - -> `[621]` (*Player_Romus: ""Derdia's attitude towards homosexuality is just an exten..."*)
  - -> `[622]` (*Player_Romus: ""Boring. Without the lure of the forbidden, I might as we..."*)
  - -> `[629]` (*Player_Romus: ""So do I. They should never have had to flee Rizia.""*)

### Węzeł `[764]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "Maze Choice 1"*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Bruno ran up to him with a gleeful wag of his tail."*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Breather", "R_Breather_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Early in the morning, I heard a soft tap on the door to m..."*)

### Węzeł `[768]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Privately reflecting on Rizia’s stance on homosexuality", "Private Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Privately reflecting on Rizia’s stance on homosexuality","Private Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
