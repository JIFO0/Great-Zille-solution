# Rizia/Turn 8/Notes/Notes Conversation

- **ID konwersacji:** `588`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/588_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 520
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Situation_Diplomacy_Pales_ATAActive`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation`
- `RiziaDLC.Turn05_Security_InvestigateBombingWehlen`
- `RiziaDLC.Zille_ViolentResistancePower`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus`

### Skoki między-konwersacyjne:
- Węzeł `[49]` -> **[409] Rizia/Turn 8/SnO_SecurityBriefAndZille** (../Turn_08/409_SnO_SecurityBriefAndZille.md), Węzeł `[550]`
- Węzeł `[113]` -> **[409] Rizia/Turn 8/SnO_SecurityBriefAndZille** (../Turn_08/409_SnO_SecurityBriefAndZille.md), Węzeł `[889]`
- Węzeł `[174]` -> **[409] Rizia/Turn 8/SnO_SecurityBriefAndZille** (../Turn_08/409_SnO_SecurityBriefAndZille.md), Węzeł `[889]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Persuasion?""** | `[7]` **Lucita Azaro**: ""After some delicate negotiation..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Lucita Azaro**: ""Yes, Your Majesty."" |
| `[11]` | **""And what did they find?""** | `[10]` **Lucita Azaro**: ""We knew Wehlen’s databases were..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucita Azaro**: ""Sure enough, after some thoroug..."<br>`[299]` **Lucita Azaro**: ""Not much, Your Majesty."" |
| `[14]` | **""Viktor Karnov? Should I know who that is?""** | `[13]` **Lucita Azaro**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucita Azaro**: ""Indeed, Your Majesty. Viktor Ka..." |
| `[17]` | **""So who is he and why is he important?""** | `[13]` **Lucita Azaro**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Lucita Azaro**: ""He's a known spy for Lespia. Th..." |
| `[18]` | **"Wait for her to continue."** | `[13]` **Lucita Azaro**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucita Azaro**: ""Stationed at their consulate in..." |
| `[19]` | **""A part of me secretly wonders what it would be like to be arrested.""** | `[13]` **Lucita Azaro**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Lucita Azaro**: ""It involves a lot of paperwork ..." |
| `[20]` | **"Enough with the generalities. I need specifics. What exactly did your operative fi..."** | `[10]` **Lucita Azaro**: ""We knew Wehlen’s databases were..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucita Azaro**: ""Sure enough, after some thoroug..."<br>`[299]` **Lucita Azaro**: ""Not much, Your Majesty."" |
| `[21]` | **""Impressive work. I’m curious to know more about what was discovered."** | `[10]` **Lucita Azaro**: ""We knew Wehlen’s databases were..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucita Azaro**: ""Sure enough, after some thoroug..."<br>`[299]` **Lucita Azaro**: ""Not much, Your Majesty."" |
| `[22]` | **""Ah, the good old carrot-and-stick approach. It seems we’ve managed to find a will..."** | `[7]` **Lucita Azaro**: ""After some delicate negotiation..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Lucita Azaro**: ""Rightly, so, Your Majesty."" |
| `[23]` | **""Sometimes, the promise of a better future is all that's needed to turn the tide.""** | `[7]` **Lucita Azaro**: ""After some delicate negotiation..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Lucita Azaro**: ""Spy-craft 101."" |
| `[24]` | **""I can't say I condone such actions, but I suppose if it achieves the desired resu..."** | `[7]` **Lucita Azaro**: ""After some delicate negotiation..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[386]` **Lucita Azaro**: ""I'm glad to hear it."" |
| `[29]` | **""What did you find?""** | `[28]` **Titus Gordion**: ""Despite the lack of immediate l..."<br>`[81]` **Titus Gordion**: ""Even though the fingerprints fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Titus Gordion**: ""I had a gut feeling that there ..." |
| `[34]` | **""So, they took him at his word?""** | `[33]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Titus Gordion**: ""Alexei’s cover was impeccable."" |
| `[37]` | **""And what did they find?""** | `[36]` **Titus Gordion**: ""In any case, he gained their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Titus Gordion**: ""A regrettable turn of events, Y..."<br>`[38]` **Titus Gordion**: ""After meticulously combing thro..." |
| `[40]` | **""Viktor Karnov? Should I know who that is?""** | `[39]` **Titus Gordion**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Titus Gordion**: ""Viktor Karnov is a noted spy fo..." |
| `[43]` | **""Viktor Karnov... Viktor Karnov... Nope. Doesn't ring a bell.""** | `[39]` **Titus Gordion**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Titus Gordion**: ""Viktor Karnov is a well-known s..." |
| `[67]` | **""Excellent work. It requires great skill to execute such an infiltration.""** | `[33]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Titus Gordion**: ""I assure you, Alexei is the bes..." |
| `[68]` | **""I hope Alexei covered his tracks thoroughly. The last thing we need is Wehlen unc..."** | `[33]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[419]` **Titus Gordion**: ""He took all necessary measures ..." |
| `[69]` | **""That sounds a bit far-fetched, but go on.""** | `[36]` **Titus Gordion**: ""In any case, he gained their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Titus Gordion**: ""A regrettable turn of events, Y..."<br>`[38]` **Titus Gordion**: ""After meticulously combing thro..." |
| `[70]` | **""A trove, huh? Alright, let's see them.""** | `[36]` **Titus Gordion**: ""In any case, he gained their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Titus Gordion**: ""A regrettable turn of events, Y..."<br>`[38]` **Titus Gordion**: ""After meticulously combing thro..." |
| `[71]` | **""I do hope these documents are genuine, or there will be consequences.""** | `[36]` **Titus Gordion**: ""In any case, he gained their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Titus Gordion**: ""No doubt, Your Majesty."" |
| `[72]` | **""It’s fascinating how the shadows of society can reveal the most vital information.""** | `[33]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Titus Gordion**: ""A reminder of the importance of..." |
| `[73]` | **""Okay, I'm listening.""** | `[28]` **Titus Gordion**: ""Despite the lack of immediate l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Titus Gordion**: ""I had a gut feeling that there ..." |
| `[93]` | **""This is excellent news. What of his present whereabouts?""** | `[92]` **Taddeus Azaro**: ""He manipulated dates, quantitie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Taddeus Azaro**: ""Unfortunately, his trail ran co..." |
| `[96]` | **""Well, well... quite the diligent individual, I must say.""** | `[92]` **Taddeus Azaro**: ""He manipulated dates, quantitie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Taddeus Azaro**: ""That's one way of putting it. T..." |
| `[97]` | **""Impressive work, General. We're finally getting closer to uncovering the truth be..."** | `[92]` **Taddeus Azaro**: ""He manipulated dates, quantitie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Taddeus Azaro**: ""Thank you. Unfortunately, any p..." |
| `[98]` | **""So there is a culprit? He must be found and punished immediately.""** | `[92]` **Taddeus Azaro**: ""He manipulated dates, quantitie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Taddeus Azaro**: ""Unfortunately, that's as far as..." |
| `[99]` | **""A dead end? Unacceptable! We can't afford setbacks like this!""** | `[95]` **Taddeus Azaro**: ""To put it plainly, we've hit a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Taddeus Azaro**: ""I wish there was more I could do."" |
| `[100]` | **""I appreciate your honesty, General. It's a challenging situation. There's only so..."** | `[95]` **Taddeus Azaro**: ""To put it plainly, we've hit a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Taddeus Azaro**: ""Thank you for understanding."" |
| `[101]` | **""Well, that's just great. Can we expect anything different at this point?""** | `[95]` **Taddeus Azaro**: ""To put it plainly, we've hit a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Taddeus Azaro**: ""No, Your Majesty. Not until new..." |
| `[102]` | **""I had hoped for better news, General. This is a setback we can ill afford.""** | `[95]` **Taddeus Azaro**: ""To put it plainly, we've hit a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Taddeus Azaro**: ""I understand, Your Majesty. But..." |
| `[134]` | **""I hope this won't take too long.""** | `[139]` **Narrator**: "I had come to receive the latest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lucita Azaro**: ""Of course, Your Majesty.""<br>`[204]` **Titus Gordion**: ""Certainly, Your Majesty.""<br>*(oraz 4 innych odgałęzień)* |
| `[135]` | **""Always a pleasure to be here. So, what have you got for me?""** | `[139]` **Narrator**: "I had come to receive the latest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucita Azaro**: ""As you already know, we're to g..."<br>`[211]` **Titus Gordion**: ""As you already know, we're to g..." |
| `[136]` | **""Let's skip the pleasantries and get to it.""** | `[139]` **Narrator**: "I had come to receive the latest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Lucita Azaro**: ""Then I will get us started.""<br>`[142]` **Titus Gordion**: ""I will strive for brevity, sir.""<br>*(oraz 2 innych odgałęzień)* |
| `[143]` | **""Please... try to contain your excitement. What pressing matters await my ears tod..."** | `[139]` **Narrator**: "I had come to receive the latest..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[150]` **Lucita Azaro**: ""As you already know, we're to g..."<br>`[211]` **Titus Gordion**: ""As you already know, we're to g..." |
| `[148]` | **""Oh, you know me, always eager to dive into the riveting world of bureaucratic dis..."** | `[139]` **Narrator**: "I had come to receive the latest..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[137]` **Lucita Azaro**: ""Of course, Your Majesty.""<br>`[204]` **Titus Gordion**: ""Certainly, Your Majesty.""<br>*(oraz 4 innych odgałęzień)* |
| `[155]` | **""'Final findings?' I'm not sure I like the sound of that.""** | `[153]` **Lucita Azaro**: ""But before we do, we should go ..."<br>`[212]` **Titus Gordion**: ""But before we do, we should rev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Lucita Azaro**: ""I wish I had better news, but I..."<br>`[482]` **Titus Gordion**: ""I wish I had better news, but t..."<br>*(oraz 2 innych odgałęzień)* |
| `[156]` | **""Excellent. I've been looking forward  to settling this matter once and for all.""** | `[153]` **Lucita Azaro**: ""But before we do, we should go ..."<br>`[212]` **Titus Gordion**: ""But before we do, we should rev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Lucita Azaro**: ""Unfortunately, the final findin..."<br>`[447]` **Titus Gordion**: ""Regrettably, the final findings..."<br>*(oraz 4 innych odgałęzień)* |
| `[158]` | **""Why do I have a bad feeling about this?""** | `[153]` **Lucita Azaro**: ""But before we do, we should go ..."<br>`[212]` **Titus Gordion**: ""But before we do, we should rev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[516]` **Lucita Azaro**: ""I understand your apprehension,..."<br>`[517]` **Titus Gordion**: ""Your concern is understandable,..."<br>*(oraz 2 innych odgałęzień)* |
| `[163]` | **""What do you mean a dead end? This is unacceptable!""** | `[162]` **Lucita Azaro**: "'I hate to say it, but I'm afrai..."<br>`[227]` **Titus Gordion**: ""As much as I hate to say it, I'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Lucita Azaro**: ""I truly wish there was more I c..."<br>`[187]` **Titus Gordion**: ""I wish there was more I could d..." |
| `[164]` | **""I appreciate your honesty, Lucita. It's a challenging situation. There's only so ..."** | `[162]` **Lucita Azaro**: "'I hate to say it, but I'm afrai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Lucita Azaro**: ""Thank you for understanding, Yo..." |
| `[165]` | **""Well, isn't that just peachy... Can we anticipate any changes in the situation?""** | `[162]` **Lucita Azaro**: "'I hate to say it, but I'm afrai..."<br>`[227]` **Titus Gordion**: ""As much as I hate to say it, I'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Lucita Azaro**: ""No, Your Majesty. Not until new..."<br>`[186]` **Titus Gordion**: ""No, sir. Not until new informat..." |
| `[166]` | **""I had hoped for better news, Lucita. This is a setback we can ill afford.""** | `[162]` **Lucita Azaro**: "'I hate to say it, but I'm afrai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Lucita Azaro**: ""Believe me, I understand comple..." |
| `[184]` | **""I appreciate your honesty, Titus. It's a challenging situation. There's only so m..."** | `[227]` **Titus Gordion**: ""As much as I hate to say it, I'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Titus Gordion**: "'Thanks. I do wish I could have ..." |
| `[185]` | **""I had hoped for better news, Titus. This is a setback we can ill afford.""** | `[227]` **Titus Gordion**: ""As much as I hate to say it, I'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Titus Gordion**: ""I completely understand, sir. B..." |
| `[238]` | **"“It’s unusual for Lucita to keep us waiting like this.”"** | `[237]` **Narrator**: "Titus, punctual as usual, stood ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Titus Gordion**: "“Quite uncharacteristic of her.”" |
| `[243]` | **"“Where have you been?”"** | `[242]` **Narrator**: "The trio's entrance spoke of urg..."<br>`[240]` **Narrator**: "Just as my eyes were beginning t..." | `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false` | *Brak zmian stanu* | `[244]` **Lucita Azaro**: "“My apologies, Your Majesty. Urg..." |
| `[245]` | **"“I'll believe that when I hear it, Duchess.""** | `[258]` **Lucita Azaro**: ""Suffice it to say we've had a b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Lucita Azaro**: ""You won't hear it. You'll see it.""<br>`[254]` **Narrator**: "Lucita signaled to the men, who ..."<br>*(oraz 1 innych odgałęzień)* |
| `[246]` | **""Lucita did say she'd be here, yes?""** | `[237]` **Narrator**: "Titus, punctual as usual, stood ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""As far as I know. I'm just as s..." |
| `[247]` | **""It seems Lucita is fashionably late to her own council meeting.""** | `[237]` **Narrator**: "Titus, punctual as usual, stood ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Titus Gordion**: ""It's unlike her to keep us wait..." |
| `[248]` | **""I don't suppose you know what Lucita intended to discuss today, do you?""** | `[237]` **Narrator**: "Titus, punctual as usual, stood ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Titus Gordion**: ""Unfortunately, no. Only the gen..." |
| `[249]` | **""Lucita. So glad you could finally join us. I was beginning to think you got lost ..."** | `[242]` **Narrator**: "The trio's entrance spoke of urg..."<br>`[240]` **Narrator**: "Just as my eyes were beginning t..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true`<br>`(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false` | *Brak zmian stanu* | `[256]` **Lucita Azaro**: ""Please excuse my late arrival, ..." |
| `[250]` | **""You're late.""** | `[242]` **Narrator**: "The trio's entrance spoke of urg..."<br>`[240]` **Narrator**: "Just as my eyes were beginning t..." | `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false` | *Brak zmian stanu* | `[257]` **Lucita Azaro**: ""My apologies, Your Majesty. I w..." |
| `[251]` | **""Really? Then please proceed.""** | `[258]` **Lucita Azaro**: ""Suffice it to say we've had a b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Lucita Azaro**: "“Thank you. Gentlemen?"" |
| `[252]` | **"Remain silent."** | `[258]` **Lucita Azaro**: ""Suffice it to say we've had a b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Narrator**: "Lucita signaled to the men, who ..."<br>`[281]` **Narrator**: "Lucita opened her folder and dis..." |
| `[253]` | **""Let's hope this doesn't devolve into a wild goose chase, Lucita.""** | `[258]` **Lucita Azaro**: ""Suffice it to say we've had a b..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[264]` **Lucita Azaro**: ""I promise it won't."" |
| `[265]` | **""Lucita. So glad you could finally join us. I was beginning to think you weren't c..."** | `[242]` **Narrator**: "The trio's entrance spoke of urg..."<br>`[240]` **Narrator**: "Just as my eyes were beginning t..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`<br>`(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false` | *Brak zmian stanu* | `[255]` **Lucita Azaro**: ""Please forgive me, Your Majesty..." |
| `[266]` | **""Let's pray this doesn't veer into a wild goose chase, Lucita.""** | `[258]` **Lucita Azaro**: ""Suffice it to say we've had a b..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[263]` **Lucita Azaro**: ""It won't. I can promise you that."" |
| `[288]` | **""That being?""** | `[287]` **Lucita Azaro**: ""But to our surprise, a piece of..."<br>`[315]` **Titus Gordion**: ""However, much to our surprise, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Lucita Azaro**: ""The fingerprints Wehlen provide..."<br>`[332]` **Titus Gordion**: ""The fingerprints Wehlen supplie..."<br>*(oraz 4 innych odgałęzień)* |
| `[289]` | **""This sounds promising. I want to hear every detail.""** | `[287]` **Lucita Azaro**: ""But to our surprise, a piece of..."<br>`[315]` **Titus Gordion**: ""However, much to our surprise, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Lucita Azaro**: ""The fingerprints Wehlen provide..."<br>`[332]` **Titus Gordion**: ""The fingerprints Wehlen supplie..."<br>*(oraz 4 innych odgałęzień)* |
| `[290]` | **""What’s this evidence, and how does it shift our entire investigation?""** | `[287]` **Lucita Azaro**: ""But to our surprise, a piece of..."<br>`[315]` **Titus Gordion**: ""However, much to our surprise, ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Lucita Azaro**: ""The fingerprints Wehlen provide..."<br>`[332]` **Titus Gordion**: ""The fingerprints Wehlen supplie..."<br>*(oraz 4 innych odgałęzień)* |
| `[302]` | **""So, we lost our lead?""** | `[301]` **Lucita Azaro**: ""Apparently, Su Omina sabotaged ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Lucita Azaro**: ""Yes, Your Majesty. An unfortuna..." |
| `[307]` | **""I knew it was a mistake to enable Su Omina operations.""** | `[301]` **Lucita Azaro**: ""Apparently, Su Omina sabotaged ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Lucita Azaro**: ""An unfortunate turn of events. ..." |
| `[308]` | **""That's disappointing news. My condolences.""** | `[301]` **Lucita Azaro**: ""Apparently, Su Omina sabotaged ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Lucita Azaro**: ""Thank you, Your Majesty. It was..." |
| `[309]` | **""Great. So it was all for nothing.""** | `[301]` **Lucita Azaro**: ""Apparently, Su Omina sabotaged ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Lucita Azaro**: ""While we may not have come to t..." |
| `[342]` | **""And they believed him?""** | `[341]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Titus Gordion**: ""Yes, Your Majesty. Alexei’s cov..." |
| `[346]` | **""It’s fascinating how the shadows of society can yield the most crucial information.""** | `[341]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Titus Gordion**: ""A reminder of the importance of..." |
| `[347]` | **""Impressive work. It takes a lot of skill to pull off such an infiltration.""** | `[341]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Titus Gordion**: ""Believe me, Alexei is the best ..." |
| `[348]` | **""I hope Alexei covered his tracks well. The last thing we need is Wehlen discoveri..."** | `[341]` **Titus Gordion**: ""My operative, Alexei, posed as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Titus Gordion**: ""Alexei took all necessary measu..." |
| `[349]` | **""And what exactly did they find?""** | `[344]` **Titus Gordion**: ""In any case, he earned their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[350]` | **""And where are these documents now?""** | `[344]` **Titus Gordion**: ""In any case, he earned their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[351]` | **""A trove, eh? Alright, let's see them.""** | `[344]` **Titus Gordion**: ""In any case, he earned their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[352]` | **""Let’s not waste time. Bring those documents to me so I can examine them.""** | `[344]` **Titus Gordion**: ""In any case, he earned their tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[359]` | **""What do you mean?""** | `[358]` **Titus Gordion**: ""However, on his way there, Alex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Titus Gordion**: ""Su Omina militants had planned ..." |
| `[360]` | **""Get to the point.""** | `[358]` **Titus Gordion**: ""However, on his way there, Alex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Titus Gordion**: ""I was just getting there, sir."" |
| `[361]` | **""How convenient.""** | `[358]` **Titus Gordion**: ""However, on his way there, Alex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Titus Gordion**: ""I assure you, it was anything b..." |
| `[367]` | **""Great. So, we lost our lead?""** | `[368]` **Titus Gordion**: ""It was a tragic coincidence."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Titus Gordion**: ""I'm afraid so, sir."" |
| `[369]` | **""Great. So you're saying this was all for nothing.""** | `[368]` **Titus Gordion**: ""It was a tragic coincidence."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Titus Gordion**: ""I wouldn't say that."" |
| `[370]` | **""That's disappointing news. My condolences to your operative.""** | `[368]` **Titus Gordion**: ""It was a tragic coincidence."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Titus Gordion**: ""Thank you, sir. It was a most u..." |
| `[379]` | **""I don't like the sound of this. What evidence?""** | `[378]` **Lucita Azaro**: ""But to our surprise, a piece of..."<br>`[380]` **Titus Gordion**: ""However, a piece of evidence we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Lucita Azaro**: ""The fingerprints Wehlen provide..."<br>`[332]` **Titus Gordion**: ""The fingerprints Wehlen supplie..."<br>*(oraz 4 innych odgałęzień)* |
| `[391]` | **""Sounds like my kind of guy!""** | `[13]` **Lucita Azaro**: ""He was arrested over 25 years a..." | `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true` | *Brak zmian stanu* | `[397]` **Lucita Azaro**: ""Let's hope you never have the p..." |
| `[401]` | **""I knew enable Su Omina operations in ZIlle was a mistake.""** | `[368]` **Titus Gordion**: ""It was a tragic coincidence."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Titus Gordion**: ""An unfortunate turn of events. ..." |
| `[407]` | **""Who is he?""** | `[39]` **Titus Gordion**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Titus Gordion**: ""It just so happens that Viktor ..." |
| `[409]` | **"Wait for Titus to continue."** | `[39]` **Titus Gordion**: ""He was arrested over 25 years a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Titus Gordion**: ""Viktor Karnov is a well-known s..." |
| `[410]` | **""Ha! Sounds like my kind of guy!""** | `[39]` **Titus Gordion**: ""He was arrested over 25 years a..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[414]` **Titus Gordion**: ""Let’s hope you never have the m..." |
| `[417]` | **""Oh, yes. I'd nearly forgotten all about them.""** | `[28]` **Titus Gordion**: ""Despite the lack of immediate l..."<br>`[81]` **Titus Gordion**: ""Even though the fingerprints fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Titus Gordion**: ""I had a gut feeling that there ..." |
| `[418]` | **""Sounds like your instincts were spot on.""** | `[81]` **Titus Gordion**: ""Even though the fingerprints fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Titus Gordion**: ""I had a gut feeling that there ..." |
| `[463]` | **""A motion picture to support your findings?""** | `[467]` **Narrator**: "They began setting it up at the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[464]` | **""What does it have to do with a film projector?""** | `[467]` **Narrator**: "They began setting it up at the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[465]` | **""Oh, a movie? How delightful. Is popcorn included, or do I need to bring my own?""** | `[467]` **Narrator**: "They began setting it up at the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Despite the lack of immediate leads, I wasn’t convinced that it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucita Azaro: ""My instincts told me there was more to uncover, and as i..."*)

### Węzeł `[4]`
Mówca: **Lucita Azaro**
> ""My instincts told me there was more to uncover, and as it turns out, I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[5]`
Mówca: **Lucita Azaro**
> ""One of my operatives managed to get in deep with a record keeper in the forensics department of Wehlen's Security Ministry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)

### Węzeł `[6]`
Mówca: **Lucita Azaro**
> ""This man was rather unhappy with his current situation and was... susceptible to persuasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucita Azaro: ""After some delicate negotiations and the promise of a be..."*)

### Węzeł `[7]`
Mówca: **Lucita Azaro**
> ""After some delicate negotiations and the promise of a better life elsewhere, he agreed to help us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Sometimes, the promise of a better future is all that's ..."*)
  - -> `[22]` (*Player_Romus: ""Ah, the good old carrot-and-stick approach. It seems we’..."*)
  - -> `[8]` (*Player_Romus: ""Persuasion?""*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Persuasion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucita Azaro: ""Yes, Your Majesty.""*)

### Węzeł `[9]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Lucita Azaro: ""My operative managed to coerce him into digging deeper i..."*)

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""We knew Wehlen’s databases were extensive, but rarely do they go back more than a decade in their routine checks. This was the key.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: "Enough with the generalities. I need specifics. What exac..."*)
  - -> `[11]` (*Player_Romus: ""And what did they find?""*)
  - -> `[21]` (*Player_Romus: ""Impressive work. I’m curious to know more about what was..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what did they find?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""Sure enough, after some thorough searching, our contact found a match. The fingerprints we discovered at the bombing scene matched those of a man named Viktor Karnov.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucita Azaro: ""He was arrested over 25 years ago for disorderly conduct..."*)

### Węzeł `[13]`
Mówca: **Lucita Azaro**
> ""He was arrested over 25 years ago for disorderly conduct and public intoxication. He was only 16 years old.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""So who is he and why is he important?""*)
  - -> `[19]` (*Player_Romus: ""A part of me secretly wonders what it would be like to b..."*)
  - -> `[14]` (*Player_Romus: ""Viktor Karnov? Should I know who that is?""*)
  - -> `[18]` (*Player_Romus_Italic: "Wait for her to continue."*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Viktor Karnov? Should I know who that is?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucita Azaro: ""Indeed, Your Majesty. Viktor Karnov is a well-known spy ..."*)

### Węzeł `[15]`
Mówca: **Lucita Azaro**
> ""Indeed, Your Majesty. Viktor Karnov is a well-known spy for Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Stationed at their consulate in Zille, he’s been operati..."*)

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""Stationed at their consulate in Zille, he’s been operating under the radar for years, seamlessly blending into various roles and avoiding detection.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So who is he and why is he important?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Lucita Azaro: ""He's a known spy for Lespia. That's who he is.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Wait for her to continue."]** — Mówca: **Player_Romus_Italic**
> "I waited for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Stationed at their consulate in Zille, he’s been operati..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A part of me secretly wonders what it would be like to be arrested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Lucita Azaro: ""It involves a lot of paperwork and fewer royal privileges.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Enough with the generalities. I need specifics. What exactly did your operative find that we don’t already know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive work. I’m curious to know more about what was discovered."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, the good old carrot-and-stick approach. It seems we’ve managed to find a willing ally with a little incentive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Lucita Azaro: ""Rightly, so, Your Majesty.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes, the promise of a better future is all that's needed to turn the tide.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucita Azaro: ""Spy-craft 101.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't say I condone such actions, but I suppose if it achieves the desired results, I can look the other way.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Lucita Azaro: ""I'm glad to hear it.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ==..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucita Azaro: ""The fingerprints Wehlen provided that were found at the ..."*)

### Węzeł `[28]`
Mówca: **Titus Gordion**
> ""Despite the lack of immediate leads from the fingerprints that were found at the scene, I wasn’t convinced it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Player_Romus: ""Oh, yes. I'd nearly forgotten all about them.""*)
  - -> `[29]` (*Player_Romus: ""What did you find?""*)
  - -> `[73]` (*Player_Romus: ""Okay, I'm listening.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you find?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Titus Gordion), `[81]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Titus Gordion: ""I had a gut feeling that there was more to uncover, and ..."*)

### Węzeł `[30]`
Mówca: **Titus Gordion**
> ""I had a gut feeling that there was more to uncover, and as it turns out, I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "Jump to: [TitusWehlenInvestigation_Hub]"*)

### Węzeł `[31]`
Mówca: **Titus Gordion**
> ""One of my operatives gained access to Wehlen's Security Ministry by infiltrating a network of underground informants and black-market traders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Titus Gordion: ""We'd previously identified a group of smugglers operatin..."*)

### Węzeł `[32]`
Mówca: **Titus Gordion**
> ""We'd previously identified a group of smugglers operating within Wehlen who occasionally dealt in sensitive information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Titus Gordion: ""My operative, Alexei, posed as a buyer interested in acq..."*)

### Węzeł `[33]`
Mówca: **Titus Gordion**
> ""My operative, Alexei, posed as a buyer interested in acquiring documents for a fictitious political rival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""I hope Alexei covered his tracks thoroughly. The last th..."*)
  - -> `[67]` (*Player_Romus: ""Excellent work. It requires great skill to execute such ..."*)
  - -> `[34]` (*Player_Romus: ""So, they took him at his word?""*)
  - -> `[72]` (*Player_Romus: ""It’s fascinating how the shadows of society can reveal t..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, they took him at his word?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Titus Gordion: ""Alexei’s cover was impeccable.""*)

### Węzeł `[35]`
Mówca: **Titus Gordion**
> ""Alexei’s cover was impeccable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Titus Gordion: ""If your memory serves you well, he was the young man I s..."*)

### Węzeł `[36]`
Mówca: **Titus Gordion**
> ""In any case, he gained their trust and managed to acquire a trove of documents, including detailed forensic records from the Security Ministry’s archives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""A trove, huh? Alright, let's see them.""*)
  - -> `[69]` (*Player_Romus: ""That sounds a bit far-fetched, but go on.""*)
  - -> `[37]` (*Player_Romus: ""And what did they find?""*)
  - -> `[71]` (*Player_Romus: ""I do hope these documents are genuine, or there will be ..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what did they find?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[38]`
Mówca: **Titus Gordion**
> ""After meticulously combing through the records, we found a match for the fingerprints belonging to a man named Viktor Karnov.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Titus Gordion: ""He was arrested over 25 years ago for disorderly conduct..."*)

### Węzeł `[39]`
Mówca: **Titus Gordion**
> ""He was arrested over 25 years ago for disorderly conduct and public intoxication, which made him 16 years old at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Player_Romus: ""Who is he?""*)
  - -> `[43]` (*Player_Romus: ""Viktor Karnov... Viktor Karnov... Nope. Doesn't ring a b..."*)
  - -> `[40]` (*Player_Romus: ""Viktor Karnov? Should I know who that is?""*)
  - -> `[409]` (*Player_Romus_Italic: "Wait for Titus to continue."*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Viktor Karnov? Should I know who that is?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Titus Gordion: ""Viktor Karnov is a noted spy for Lespia, though his acti..."*)

### Węzeł `[41]`
Mówca: **Titus Gordion**
> ""Viktor Karnov is a well-known spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Titus Gordion: ""For Lespia.""*)

### Węzeł `[42]`
Mówca: **Titus Gordion**
> ""Based at their consulate in Zille, he’s been operating under the radar for years, effortlessly blending into various roles and evading detection.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Viktor Karnov... Viktor Karnov... Nope. Doesn't ring a bell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Titus Gordion: ""Viktor Karnov is a well-known spy.""*)

### Węzeł `[44]`
Mówca: **Titus Gordion**
> ""If your memory serves you well, he was the young man I sparred with at our first official meeting after your ascension to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Titus Gordion: ""In any case, he gained their trust and managed to acquir..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ==..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Titus Gordion: ""Despite the lack of immediate leads from the fingerprint..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Titus Gordion: ""Even though the fingerprints found at the scene, provide..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "We took a seat around the council table. Titus handed each of us a large file, its contents nearly overflowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "Jump to: [GGBombResult_Hub]"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GGBombResult_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I snapped back to reality upon entering the council room,..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I snapped back to reality upon entering the council room, reminded that I was there for a security briefing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == tr..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Titus, ever the punctual one, was already present."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Titus, ever the punctual one, was already present. And he..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Titus, ever the punctual one, was already present. And he wasn't alone. He was overseeing two men in uniform setting up a film projector and screen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Titus Gordion: ""There you are, Your Majesty. I'm pleased to see you.""*)

### Węzeł `[59]`
Mówca: **Titus Gordion**
> ""There you are, Your Majesty. I'm pleased to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "The three men, one by one, bowed in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Titus Gordion: ""As the new Royal Councilor of War and Internal Security ..."*)

### Węzeł `[61]`
Mówca: **Titus Gordion**
> ""As the new Royal Councilor of War and Internal Security for Rizia, I want to express my eternal gratitude for the trust you've bestowed upon me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Titus, ever the punctual one, was already present."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Titus Gordion: ""There you are, Your Majesty. I'm pleased to see you.""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He bowed respectfully."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "The three men, one by one, bowed in respect."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He bowed respectfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Titus Gordion: ""As the new Royal Councilor of War and Internal Security ..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent work. It requires great skill to execute such an infiltration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Titus Gordion: ""I assure you, Alexei is the best of the best in covert o..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope Alexei covered his tracks thoroughly. The last thing we need is Wehlen uncovering our involvement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Titus Gordion: ""He took all necessary measures to ensure that his activi..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds a bit far-fetched, but go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A trove, huh? Alright, let's see them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope these documents are genuine, or there will be consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Titus Gordion: ""No doubt, Your Majesty.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s fascinating how the shadows of society can reveal the most vital information.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Titus Gordion: ""A reminder of the importance of exploring every angle, e..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Titus Gordion: ""I had a gut feeling that there was more to uncover, and ..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Titus Gordion: "“It goes without saying that the Friendship Day bombing h..."*)

### Węzeł `[75]`
Mówca: **Titus Gordion**
> "“It goes without saying that the Friendship Day bombing has complicated matters regarding Zille's reunification with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Titus Gordion: ""However, what we've uncovered could be the breakthrough ..."*)

### Węzeł `[76]`
Mówca: **Titus Gordion**
> ""However, what we've uncovered could be the breakthrough that tilts the situation back in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Titus Gordion: ""As you know, you tasked me with investigating further in..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Titus Gordion**
> ""As you know, you tasked me with investigating further into the possibility that Wehlen was responsible for the bombing.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Titus Gordion**
> ""Even though the fingerprints found at the scene, provided by Wehlen, didn't give us any immediate leads, I still wasn’t convinced it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Player_Romus: ""Oh, yes. I'd nearly forgotten all about them.""*)
  - -> `[29]` (*Player_Romus: ""What did you find?""*)
  - -> `[418]` (*Player_Romus: ""Sounds like your instincts were spot on.""*)

### Węzeł `[82]`
Mówca: **Taddeus Azaro**
> ""As everyone here knows, I was tasked with resuming the foreign intelligence investigation into the infamous Friendship Day bombing in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Taddeus Azaro: ""As previously uncovered, my department identified materi..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "We all took our places around the council table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Taddeus Azaro: ""As everyone here knows, I was tasked with resuming the f..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Taddeus Azaro**
> ""As previously uncovered, my department identified material from the bomb site that came straight from CircuitRise Systems in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[88]`
Mówca: **Taddeus Azaro**
> ""Upon further investigation, we managed to identify the man responsible for obtaining the material in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Taddeus opened a large file folder he had brought in and ..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Taddeus opened a large file folder he had brought in and handed out photos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Taddeus Azaro: ""We've narrowed it down to a man by the name of Aurelio I..."*)

### Węzeł `[90]`
Mówca: **Taddeus Azaro**
> ""We've narrowed it down to a man by the name of Aurelio Iturriaga who worked as a Chief Operations Officer at CircuitRise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Taddeus Azaro: ""Mr. Iturriaga exploited his exclusive access to tamper w..."*)

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""Mr. Iturriaga exploited his exclusive access to tamper with inventory records, concealing the disappearance of vital materials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Taddeus Azaro: ""He manipulated dates, quantities, and descriptions, crea..."*)

### Węzeł `[92]`
Mówca: **Taddeus Azaro**
> ""He manipulated dates, quantities, and descriptions, creating a deceptive trail to obscure his actions from scrutiny. Or so he believed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""Impressive work, General. We're finally getting closer t..."*)
  - -> `[96]` (*Player_Romus: ""Well, well... quite the diligent individual, I must say.""*)
  - -> `[93]` (*Player_Romus: ""This is excellent news. What of his present whereabouts?""*)
  - -> `[98]` (*Player_Romus: ""So there is a culprit? He must be found and punished imm..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is excellent news. What of his present whereabouts?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Taddeus Azaro: ""Unfortunately, his trail ran cold. Any progress made was..."*)

### Węzeł `[94]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, his trail ran cold. Any progress made was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Taddeus Azaro: ""To put it plainly, we've hit a dead end.""*)

### Węzeł `[95]`
Mówca: **Taddeus Azaro**
> ""To put it plainly, we've hit a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""I had hoped for better news, General. This is a setback ..."*)
  - -> `[101]` (*Player_Romus: ""Well, that's just great. Can we expect anything differen..."*)
  - -> `[99]` (*Player_Romus: ""A dead end? Unacceptable! We can't afford setbacks like ..."*)
  - -> `[100]` (*Player_Romus: ""I appreciate your honesty, General. It's a challenging s..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, well... quite the diligent individual, I must say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Taddeus Azaro: ""That's one way of putting it. That said...""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive work, General. We're finally getting closer to uncovering the truth behind this ordeal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Taddeus Azaro: ""Thank you. Unfortunately, any progress made was lost dur..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So there is a culprit? He must be found and punished immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Taddeus Azaro: ""Unfortunately, that's as far as we got. Any progress mad..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A dead end? Unacceptable! We can't afford setbacks like this!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Taddeus Azaro: ""I wish there was more I could do.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your honesty, General. It's a challenging situation. There's only so much you could have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Taddeus Azaro: ""Thank you for understanding.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's just great. Can we expect anything different at this point?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Taddeus Azaro: ""No, Your Majesty. Not until new information presents its..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped for better news, General. This is a setback we can ill afford.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Taddeus Azaro: ""I understand, Your Majesty. But unless new information p..."*)

### Węzeł `[103]`
Mówca: **Taddeus Azaro**
> ""That's one way of putting it. That said...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Taddeus Azaro: ""Unfortunately, his trail ran cold. Any progress made was..."*)

### Węzeł `[104]`
Mówca: **Taddeus Azaro**
> ""Thank you. Unfortunately, any progress made was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Taddeus Azaro: ""To put it plainly, we've hit a dead end.""*)

### Węzeł `[105]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, that's as far as we got. Any progress made was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Taddeus Azaro: ""To put it plainly, we've hit a dead end.""*)

### Węzeł `[106]`
Mówca: **Taddeus Azaro**
> ""I understand, Your Majesty. But unless new information presents itself, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Titus Gordion: ""Well, if there's nothing more to discuss regarding the i..."*)

### Węzeł `[107]`
Mówca: **Taddeus Azaro**
> ""No, Your Majesty. Not until new information presents itself. Until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Titus Gordion: ""Well, if there's nothing more to discuss regarding the i..."*)

### Węzeł `[108]`
Mówca: **Taddeus Azaro**
> ""I wish there was more I could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""If any new information comes to light, then I will pursu..."*)

### Węzeł `[109]`
Mówca: **Taddeus Azaro**
> ""Thank you for understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Titus Gordion: ""Well, if there's nothing more to discuss regarding the i..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "The General nodded slightly, indicating his agreement, before gathering his files."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investig..."*)

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""If any new information comes to light, then I will pursue it with great diligence. But until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Titus Gordion: ""Well, if there's nothing more to discuss regarding the i..."*)

### Węzeł `[112]`
Mówca: **Titus Gordion**
> ""Well, if there's nothing more to discuss regarding the investigation, General, let's move on to the issue of Zille's impending reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "The General nodded slightly, indicating his agreement, be..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ZilleUpdate_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]`

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_Security_Briefing_Investigation_FI_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleUpdate_Hub]"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Taddeus Azaro: ""And since your orders directed us to focus the investiga..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Taddeus Azaro: ""Upon further investigation, we managed to identify the m..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucita Azaro: ""Unfortunately, there isn't a substantial update to provi..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucita Azaro: ""I hate to say it, but unfortunately, there isn't a subst..."*)

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Unfortunately, there isn't a substantial update to provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucita Azaro: ""Although you asked us to investigate Wehlen's potential ..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Titus Gordion: ""Unfortunately, I don't have a substantial update to prov..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Titus Gordion: ""Unfortunately, I don't have a significant update to offer.""*)

### Węzeł `[125]`
Mówca: **Titus Gordion**
> ""Unfortunately, I don't have a significant update to offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Titus Gordion: ""Although you asked us to investigate Pales' potential in..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Accessing necessary facilities and conducting interviews has proven challenging due to heightened security protocols related to the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""Additionally, we've had to divert a sizeable amount of i..."*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""Additionally, we've had to divert a sizeable amount of intelligence resources towards the war effort, limiting how much we can achieve in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: "'I hate to say it, but I'm afraid we've hit a dead end.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Lucita nodded slightly, indicating her agreement."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleUpdate_Hub]"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == tr..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro"); AddConversant("Titus Gordi..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this won't take too long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Always a pleasure to be here. So, what have you got for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's skip the pleasantries and get to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""Yes. Understood, sir. Lucita?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucita Azaro: ""Thank you, Titus. As you know, we're to go over the late..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "I had come to receive the latest updates on the situation in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[135]` (*Player_Romus: ""Always a pleasure to be here. So, what have you got for ..."*)
  - -> `[134]` (*Player_Romus: ""I hope this won't take too long.""*)
  - -> `[136]` (*Player_Romus: ""Let's skip the pleasantries and get to it.""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");
AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lucita Azaro: ""Hello, Your Majesty. I'm glad you could join us.""*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Upon entering the council room, I found Titus and Lucita. They were awaiting my arrival, promptly rising from their seats when they noticed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "I had come to receive the latest updates on the situation..."*)

### Węzeł `[142]`
Mówca: **Titus Gordion**
> ""I will strive for brevity, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Titus Gordion: ""As you already know, we're to go over the latest updates..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please... try to contain your excitement. What pressing matters await my ears today?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""Please... try to contain your excitement. What pressing ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""Oh, you know me, always eager to dive into the riveting ..."*)

### Węzeł `[147]`
Mówca: **Lucita Azaro**
> ""Thank you, Titus. As you know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucita Azaro: ""But before we do, we should go over our final findings r..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, you know me, always eager to dive into the riveting world of bureaucratic discussions. Well, let's hear it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[149]`
Mówca: **Lucita Azaro**
> ""Then I will get us started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucita Azaro: ""As you already know, we're to go over the latest updates..."*)

### Węzeł `[150]`
Mówca: **Lucita Azaro**
> ""As you already know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucita Azaro: ""But before we do, we should go over our final findings r..."*)

### Węzeł `[151]`
Mówca: **Lucita Azaro**
> ""Hello, Your Majesty. I'm glad you could join us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Lucita's words jolted me back to the present moment."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Lucita's words jolted me back to the present moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Upon entering the council room, I found Titus and Lucita...."*)

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""But before we do, we should go over our final findings regarding the Friendship Day bombing incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""Excellent. I've been looking forward  to settling this m..."*)
  - -> `[155]` (*Player_Romus: ""'Final findings?' I'm not sure I like the sound of that.""*)
  - -> `[158]` (*Player_Romus: ""Why do I have a bad feeling about this?""*)

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""I hate to say it, but unfortunately, there isn't a substantial update to provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucita Azaro: ""Although you asked us to investigate Pales' potential in..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Final findings?' I'm not sure I like the sound of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. I've been looking forward  to settling this matter once and for all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""As have I, however, you may not like what you're about to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do I have a bad feeling about this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucita Azaro), `[212]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[159]`
Mówca: **Lucita Azaro**
> ""I'm afraid your intuition is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[160]`
Mówca: **Lucita Azaro**
> ""Accessing necessary facilities and conducting interviews in Pales has been challenging due to heightened security and restricted movement in the region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucita Azaro: ""Additionally, communication channels have been disrupted..."*)

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""Additionally, communication channels have been disrupted, making it difficult to gather firsthand information from sources within Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: "'I hate to say it, but I'm afraid we've hit a dead end.""*)

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> "'I hate to say it, but I'm afraid we've hit a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""I had hoped for better news, Lucita. This is a setback w..."*)
  - -> `[165]` (*Player_Romus: ""Well, isn't that just peachy... Can we anticipate any ch..."*)
  - -> `[163]` (*Player_Romus: ""What do you mean a dead end? This is unacceptable!""*)
  - -> `[164]` (*Player_Romus: ""I appreciate your honesty, Lucita. It's a challenging si..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean a dead end? This is unacceptable!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro), `[227]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your honesty, Lucita. It's a challenging situation. There's only so much you could have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucita Azaro: ""Thank you for understanding, Your Majesty. I wish there ..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, isn't that just peachy... Can we anticipate any changes in the situation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro), `[227]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped for better news, Lucita. This is a setback we can ill afford.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucita Azaro: ""Believe me, I understand completely. But unless new info..."*)

### Węzeł `[167]`
Mówca: **Lucita Azaro**
> ""Believe me, I understand completely. But unless new information presents itself, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""No, Your Majesty. Not until new information comes to light, if ever. Until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[169]`
Mówca: **Lucita Azaro**
> ""Thank you for understanding, Your Majesty. I wish there was more I could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[170]`
Mówca: **Lucita Azaro**
> ""I truly wish there was more I could do. But my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucita Azaro: ""If any new information comes to light, I will pursue it ..."*)

### Węzeł `[171]`
Mówca: **Lucita Azaro**
> ""If any new information comes to light, I will pursue it with great diligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[172]`
Mówca: **Titus Gordion**
> ""Well, if there's nothing left to discuss regarding this matter, I suggest we move on to the issue of Zille's impending reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Lucita nodded slightly, indicating her agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleUpdate_Hub]"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ZilleUpdate_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]`

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Titus Gordion: ""Hello, sir. I'm glad you could join me.""*)

### Węzeł `[176]`
Mówca: **Titus Gordion**
> ""Hello, sir. I'm glad you could join me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Titus' words jolted me back to the present moment."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Titus' words jolted me back to the present moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Upon entering the council room, I found Titus awaiting my..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Upon entering the council room, I found Titus awaiting my arrival. He promptly rose from his seat when he noticed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "I had come to receive the latest updates on the situation..."*)

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""Yes. Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Titus Gordion: ""As you know, we're to go over the latest updates regardi..."*)

### Węzeł `[180]`
Mówca: **Titus Gordion**
> ""As you know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Titus Gordion: ""But before we do, we should review the final findings of..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true )"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucita Azaro: ""Of course, Your Majesty.""*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Titus Gordion: ""Certainly, Your Majesty.""*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your honesty, Titus. It's a challenging situation. There's only so much you could have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Titus Gordion: "'Thanks. I do wish I could have more.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had hoped for better news, Titus. This is a setback we can ill afford.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Titus Gordion: ""I completely understand, sir. But unless new information..."*)

### Węzeł `[186]`
Mówca: **Titus Gordion**
> ""No, sir. Not until new information comes to light, if ever. Until then, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[187]`
Mówca: **Titus Gordion**
> ""I wish there was more I could do. But my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Titus Gordion: ""If any additional information comes to light, I will pur..."*)

### Węzeł `[188]`
Mówca: **Titus Gordion**
> ""If any additional information comes to light, I will pursue it with great diligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[189]`
Mówca: **Titus Gordion**
> ""I completely understand, sir. But unless new information presents itself, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucita Azaro: ""I truly wish there was more I could do. But my hands are..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Titus Gordion: ""I wish there was more I could do. But my hands are tied.""*)

### Węzeł `[193]`
Mówca: **Lucita Azaro**
> ""Although you asked us to investigate Wehlen's potential involvement further, since the onset of the Pales conflict, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""Accessing necessary facilities and conducting interviews..."*)

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""Although you asked us to investigate Pales' potential involvement further, since the onset of the war, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucita Azaro: ""Accessing necessary facilities and conducting interviews..."*)

### Węzeł `[195]`
Mówca: **Titus Gordion**
> ""Although you asked the Duchess to investigate Wehlen's potential involvement further, since the onset of the war, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Titus Gordion: ""Accessing facilities and conducting interviews in Pales ..."*)

### Węzeł `[196]`
Mówca: **Titus Gordion**
> ""Although you asked us to investigate Pales' potential involvement further, since the onset of the war, we've faced significant limitations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Titus Gordion: ""Accessing facilities and conducting interviews in Pales ..."*)

### Węzeł `[197]`
Mówca: **Titus Gordion**
> "'Thanks. I do wish I could have more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Titus Gordion: ""Well, if there's nothing left to discuss regarding this ..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucita Azaro: ""No, Your Majesty. Not until new information comes to lig..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Titus Gordion: ""No, sir. Not until new information comes to light, if ev..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true )"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Titus Gordion: ""Yes. Understood, sir. Lucita?""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Titus Gordion: ""Yes. Understood, sir.""*)

### Węzeł `[204]`
Mówca: **Titus Gordion**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true )"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucita Azaro: ""Then I will get us started.""*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Titus Gordion: ""I will strive for brevity, sir.""*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true )"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucita Azaro: ""As you already know, we're to go over the latest updates..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Titus Gordion: ""As you already know, we're to go over the latest updates..."*)

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""As you already know, we're to go over the latest updates regarding the transfer of Zille to Rizian governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Titus Gordion: ""But before we do, we should review the final findings of..."*)

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""But before we do, we should review the final findings of my continuation of Duchess Azaro's investigation into the Friendship Day bombing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""Excellent. I've been looking forward  to settling this m..."*)
  - -> `[155]` (*Player_Romus: ""'Final findings?' I'm not sure I like the sound of that.""*)
  - -> `[158]` (*Player_Romus: ""Why do I have a bad feeling about this?""*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true )"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucita Azaro: ""As have I, however, you may not like what you're about t..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Titus Gordion: ""Same. Although, you may not like what you're about to he..."*)

### Węzeł `[216]`
Mówca: **Titus Gordion**
> ""Same. Although, you may not like what you're about to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true )"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lucita Azaro: ""I'm afraid your intuition is right.""*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Titus Gordion: ""Your intuition seems to be right.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)

### Węzeł `[223]`
Mówca: **Titus Gordion**
> ""Your intuition seems to be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[224]`
Mówca: **Titus Gordion**
> ""Unfortunately, I don't have a substantial update to provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Titus Gordion: ""Although you asked the Duchess to investigate Wehlen's p..."*)

### Węzeł `[225]`
Mówca: **Titus Gordion**
> ""Accessing facilities and conducting interviews in Pales has proven challenging due to heightened security measures and restricted movement in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Titus Gordion: ""Additionally, communication channels have been disrupted..."*)

### Węzeł `[226]`
Mówca: **Titus Gordion**
> ""Additionally, communication channels have been disrupted, making it difficult for them to gather firsthand information from sources within Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Titus Gordion: ""As much as I hate to say it, I'm afraid we've hit a dead..."*)

### Węzeł `[227]`
Mówca: **Titus Gordion**
> ""As much as I hate to say it, I'm afraid we've hit a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: ""I had hoped for better news, Titus. This is a setback we..."*)
  - -> `[165]` (*Player_Romus: ""Well, isn't that just peachy... Can we anticipate any ch..."*)
  - -> `[163]` (*Player_Romus: ""What do you mean a dead end? This is unacceptable!""*)
  - -> `[184]` (*Player_Romus: ""I appreciate your honesty, Titus. It's a challenging sit..."*)

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""I understand your apprehension, but I can assure you that our findings bring promising developments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""You won't hear it. You'll see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The sound of a ticking clock snapped me back to reality."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true..."*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == tr..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn03_Security_LucitaLeadsInvestigation == true && RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] == true  and  Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[234]`
Mówca: **Narrator**
> "Sitting at the head of my council room table, I again checked the time on the wall-mounted timepiece."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "It was fifteen past three. Lucita was late."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "It was fifteen past three. Lucita was late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "I was here to be briefed on the latest updates on Zille, ..."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "I was here to be briefed on the latest updates on Zille, but it was beginning to look like a postponement was in order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "Titus, punctual as usual, stood nearby."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "Titus, punctual as usual, stood nearby."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""It seems Lucita is fashionably late to her own council m..."*)
  - -> `[246]` (*Player_Romus: ""Lucita did say she'd be here, yes?""*)
  - -> `[238]` (*Player_Romus: "“It’s unusual for Lucita to keep us waiting like this.”"*)
  - -> `[248]` (*Player_Romus: ""I don't suppose you know what Lucita intended to discuss..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“It’s unusual for Lucita to keep us waiting like this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Titus Gordion: "“Quite uncharacteristic of her.”"*)

### Węzeł `[239]`
Mówca: **Titus Gordion**
> "“Quite uncharacteristic of her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Just as my eyes were beginning to veer toward the clock o..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Just as my eyes were beginning to veer toward the clock once more, the doors opened, and Lucita hurried in, clutching a folder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[241]`
Mówca: **Narrator**
> "Two men in military uniforms followed her, pushing a film projector into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "The trio's entrance spoke of urgency."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "The trio's entrance spoke of urgency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""You're late.""*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[243]` (*Player_Romus: "“Where have you been?”"*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Where have you been?”"
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Lucita Azaro: "“My apologies, Your Majesty. Urgent matters delayed my ar..."*)

### Węzeł `[244]`
Mówca: **Lucita Azaro**
> "“My apologies, Your Majesty. Urgent matters delayed my arrival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lucita Azaro: ""Suffice it to say we've had a breakthrough in the Friend..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I'll believe that when I hear it, Duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita did say she'd be here, yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""As far as I know. I'm just as surprised by her absence a..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems Lucita is fashionably late to her own council meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Titus Gordion: ""It's unlike her to keep us waiting.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't suppose you know what Lucita intended to discuss today, do you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Titus Gordion: ""Unfortunately, no. Only the general assessment of the si..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita. So glad you could finally join us. I was beginning to think you got lost in the maze of palace corridors.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true` AND `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Lucita Azaro: ""Please excuse my late arrival, Your Majesty. Urgent matt..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're late.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Lucita Azaro: ""My apologies, Your Majesty. I was unavoidably detained b..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? Then please proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lucita Azaro: "“Thank you. Gentlemen?""*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "Remain silent."]** — Mówca: **Player_Romus_Italic**
> "I remained silent, my cue for her to proceed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hope this doesn't devolve into a wild goose chase, Lucita.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[258]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Lucita Azaro: ""I promise it won't.""*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Lucita signaled to the men, who began setting up the film projector."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
Mówca: **Lucita Azaro**
> ""Please forgive me, Your Majesty. I had urgent matters to attend to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lucita Azaro: ""Suffice it to say we've had a breakthrough in the Friend..."*)

### Węzeł `[256]`
Mówca: **Lucita Azaro**
> ""Please excuse my late arrival, Your Majesty. Urgent matters demanded my attention elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lucita Azaro: ""Suffice it to say we've had a breakthrough in the Friend..."*)

### Węzeł `[257]`
Mówca: **Lucita Azaro**
> ""My apologies, Your Majesty. I was unavoidably detained by pressing matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lucita Azaro: ""Suffice it to say we've had a breakthrough in the Friend..."*)

### Węzeł `[258]`
Mówca: **Lucita Azaro**
> ""Suffice it to say we've had a breakthrough in the Friendship Day bombing case. A big one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[251]` (*Player_Romus: ""Really? Then please proceed.""*)
  - -> `[245]` (*Player_Romus: "“I'll believe that when I hear it, Duchess.""*)
  - -> `[252]` (*Player_Romus_Italic: "Remain silent."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""Let's pray this doesn't veer into a wild goose chase, Lu..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""Let's hope this doesn't devolve into a wild goose chase,..."*)

### Węzeł `[262]`
Mówca: **Lucita Azaro**
> "“Thank you. Gentlemen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""It won't. I can promise you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[264]`
Mówca: **Lucita Azaro**
> ""I promise it won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita. So glad you could finally join us. I was beginning to think you weren't coming.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` AND `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Lucita Azaro: ""Please forgive me, Your Majesty. I had urgent matters to..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's pray this doesn't veer into a wild goose chase, Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[258]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucita Azaro: ""It won't. I can promise you that.""*)

### Węzeł `[267]`
Mówca: **Narrator**
> "The sound of a ticking clock snapped me back to reality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "Sitting at the head of my council room table, I again che..."*)

### Węzeł `[268]`
Mówca: **Titus Gordion**
> ""As far as I know. I'm just as surprised by her absence as you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Just as my eyes were beginning to veer toward the clock o..."*)

### Węzeł `[269]`
Mówca: **Titus Gordion**
> ""Unfortunately, no. Only the general assessment of the situation regarding Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Just as my eyes were beginning to veer toward the clock o..."*)

### Węzeł `[270]`
Mówca: **Titus Gordion**
> ""It's unlike her to keep us waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Just as my eyes were beginning to veer toward the clock o..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""Lucita. So glad you could finally join us. I was beginni..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Lucita. So glad you could finally join us. I was beginni..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == fa..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Two men in military uniforms followed her, pushing a film..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""You're late.""*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[243]` (*Player_Romus: "“Where have you been?”"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == fa..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Lucita signaled to the men, who began setting up the film..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Lucita opened her folder and distributed the documents wi..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "Lucita opened her folder and distributed the documents within it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""As previously uncovered, my department identified material from the bomb site that came directly from CircuitRise Systems in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Lucita Azaro: ""And given your orders focus the investigation on Wehlen,..."*)

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""And given your orders focus the investigation on Wehlen, nothing further has come from that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == fa..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucita Azaro: ""You won't hear it. You'll see it.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == false"*)

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""But to our surprise, a piece of evidence we had nearly dismissed has turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player_Romus: ""This sounds promising. I want to hear every detail.""*)
  - -> `[288]` (*Player_Romus: ""That being?""*)
  - -> `[290]` (*Player_Romus: ""What’s this evidence, and how does it shift our entire i..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That being?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Lucita Azaro), `[315]` (Titus Gordion), `[378]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This sounds promising. I want to hear every detail.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Lucita Azaro), `[315]` (Titus Gordion), `[378]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What’s this evidence, and how does it shift our entire investigation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Lucita Azaro), `[315]` (Titus Gordion), `[378]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[291]`
Mówca: **Lucita Azaro**
> ""The fingerprints found at the scene of the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucita Azaro: ""Despite the lack of immediate leads, I wasn’t convinced ..."*)

### Węzeł `[292]`
Mówca: **Lucita Azaro**
> ""The fingerprints Wehlen provided that were found at the scene of the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucita Azaro: ""Despite the lack of immediate leads, I wasn’t convinced ..."*)

### Węzeł `[293]`
Mówca: **Titus Gordion**
> ""Your concern is understandable, but I assure you that our findings bring promising news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[294]`
Mówca: **Lucita Azaro**
> ""Unfortunately, your instincts are correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[295]`
Mówca: **Titus Gordion**
> ""I hate to say it, but your instincts are correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucita Azaro: ""Sure enough, after some thorough searching, our contact ..."*)

### Węzeł `[299]`
Mówca: **Lucita Azaro**
> ""Not much, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""The contact was on a train in Zille to meet up with my o..."*)

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""The contact was on a train in Zille to meet up with my operative at a secret beachside rendezvous. On his way there, the train derailed, and he was killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Lucita Azaro: ""Apparently, Su Omina sabotaged the train to hinder Wehle..."*)

### Węzeł `[301]`
Mówca: **Lucita Azaro**
> ""Apparently, Su Omina sabotaged the train to hinder Wehlen's logistics. It seems they were trying to disrupt any efforts to uncover information that could be damaging to their interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: ""Great. So it was all for nothing.""*)
  - -> `[308]` (*Player_Romus: ""That's disappointing news. My condolences.""*)
  - -> `[302]` (*Player_Romus: ""So, we lost our lead?""*)
  - -> `[307]` (*Player_Romus: ""I knew it was a mistake to enable Su Omina operations.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, we lost our lead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Lucita Azaro: ""Yes, Your Majesty. An unfortunate turn of events.""*)

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. An unfortunate turn of events.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Lucita Azaro: ""Not much, Your Majesty.""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew it was a mistake to enable Su Omina operations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Lucita Azaro: ""An unfortunate turn of events. Yet, despite this setback..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's disappointing news. My condolences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lucita Azaro: ""Thank you, Your Majesty. It was an unfortunate turn of e..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So it was all for nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Lucita Azaro: ""While we may not have come to the desired conclusion, Su..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""As previously uncovered, my department identified materi..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Titus Gordion: ""As previously uncovered, the Golden Guard identified mat..."*)

### Węzeł `[313]`
Mówca: **Titus Gordion**
> ""As previously uncovered, the Golden Guard identified material from the bomb site that came directly from TerraGrowth Agrochem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Titus Gordion: ""And since your orders directed us to focus the investiga..."*)

### Węzeł `[314]`
Mówca: **Titus Gordion**
> ""And since your orders directed us to focus the investigation on Wehlen, no further progress has been made on that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""However, much to our surprise, a piece of evidence we had nearly dismissed has turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player_Romus: ""This sounds promising. I want to hear every detail.""*)
  - -> `[288]` (*Player_Romus: ""That being?""*)
  - -> `[290]` (*Player_Romus: ""What’s this evidence, and how does it shift our entire i..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Lucita Azaro: ""The fingerprints Wehlen claimed they found at the crime ..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false 
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucita Azaro: ""The fingerprints found at the scene of the crime.""*)

### Węzeł `[319]`
Mówca: **Lucita Azaro**
> ""The fingerprints Wehlen claimed they found at the crime scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Lucita Azaro: ""Turns out, they do exist and we were able to get our han..."*)

### Węzeł `[320]`
Mówca: **Lucita Azaro**
> ""Turns out, they do exist and we were able to get our hands on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[321]`
Mówca: **Titus Gordion**
> ""Despite the absence of immediate leads, I wasn’t convinced that it was a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Titus Gordion: ""My gut told me there was more to uncover, and as it turn..."*)

### Węzeł `[322]`
Mówca: **Titus Gordion**
> ""My gut told me there was more to uncover, and as it turns out, I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ==..."*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Titus Gordion: ""The fingerprints Wehlen supplied, found at the crime sce..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Titus Gordion: ""The fingerprints that Wehlen claimed to have found at th..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false &&
RiziaDLC.Security_GoldenGuard_InvestigateSO == false 
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false  and 
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Titus Gordion: ""The fingerprints that were found at the scene of the cri..."*)

### Węzeł `[329]`
Mówca: **Titus Gordion**
> ""The fingerprints that were found at the scene of the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Titus Gordion: ""Despite the absence of immediate leads, I wasn’t convinc..."*)

### Węzeł `[330]`
Mówca: **Titus Gordion**
> ""The fingerprints that Wehlen claimed to have found at the crime scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Titus Gordion: ""Turns out, they do exist and we were able to get our han..."*)

### Węzeł `[331]`
Mówca: **Titus Gordion**
> ""Turns out, they do exist and we were able to get our hands on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[332]`
Mówca: **Titus Gordion**
> ""The fingerprints Wehlen supplied, found at the crime scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Titus Gordion: ""Despite the absence of immediate leads, I wasn’t convinc..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ==..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ==..."*)

### Węzeł `[336]`
Mówca: **Titus Gordion**
> ""One of my operatives managed to gain access to Wehlen's Security Ministry by infiltrating an underground network of informants and black-market traders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Titus Gordion: ""We had previously identified a group of smugglers operat..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucita Azaro: ""One of my operatives managed to get in deep with a recor..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "TitusWehlenInvestigation_Hub"*)

### Węzeł `[340]`
Mówca: **Titus Gordion**
> ""We had previously identified a group of smugglers operating within Wehlen who occasionally dealt in sensitive information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Titus Gordion: ""My operative, Alexei, posed as a buyer seeking documents..."*)

### Węzeł `[341]`
Mówca: **Titus Gordion**
> ""My operative, Alexei, posed as a buyer seeking documents for a made-up political rival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player_Romus: ""I hope Alexei covered his tracks well. The last thing we..."*)
  - -> `[347]` (*Player_Romus: ""Impressive work. It takes a lot of skill to pull off suc..."*)
  - -> `[342]` (*Player_Romus: ""And they believed him?""*)
  - -> `[346]` (*Player_Romus: ""It’s fascinating how the shadows of society can yield th..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And they believed him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Titus Gordion: ""Yes, Your Majesty. Alexei’s cover was impeccable.""*)

### Węzeł `[343]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. Alexei’s cover was impeccable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""If you recall, he was the young man I sparred with at ou..."*)

### Węzeł `[344]`
Mówca: **Titus Gordion**
> ""In any case, he earned their trust and secured a trove of documents, including detailed forensic records from the Security Ministry’s archives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: ""A trove, eh? Alright, let's see them.""*)
  - -> `[350]` (*Player_Romus: ""And where are these documents now?""*)
  - -> `[349]` (*Player_Romus: ""And what exactly did they find?""*)
  - -> `[352]` (*Player_Romus: ""Let’s not waste time. Bring those documents to me so I c..."*)

### Węzeł `[345]`
Mówca: **Titus Gordion**
> ""If you recall, he was the young man I sparred with at our first official meeting following your ascension to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Titus Gordion: ""In any case, he earned their trust and secured a trove o..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s fascinating how the shadows of society can yield the most crucial information.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Titus Gordion: ""A reminder of the importance of exploring every angle, e..."*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive work. It takes a lot of skill to pull off such an infiltration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Titus Gordion: ""Believe me, Alexei is the best of the best in covert ope..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope Alexei covered his tracks well. The last thing we need is Wehlen discovering our involvement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Titus Gordion: ""Alexei took all necessary measures to ensure his activit..."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what exactly did they find?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where are these documents now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A trove, eh? Alright, let's see them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s not waste time. Bring those documents to me so I can examine them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Titus Gordion: ""A regrettable turn of events, Your Majesty.""*)
  - -> `[38]` (*Titus Gordion: ""After meticulously combing through the records, we found..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
Mówca: **Titus Gordion**
> ""A regrettable turn of events, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Titus Gordion: ""After Alexei acquired the documents, he arranged to meet..."*)

### Węzeł `[357]`
Mówca: **Titus Gordion**
> ""After Alexei acquired the documents, he arranged to meet with another operative to hand over the evidence in a remote location.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Titus Gordion: ""However, on his way there, Alexei happened to be in the ..."*)

### Węzeł `[358]`
Mówca: **Titus Gordion**
> ""However, on his way there, Alexei happened to be in the wrong place at the wrong time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player_Romus: ""Get to the point.""*)
  - -> `[359]` (*Player_Romus: ""What do you mean?""*)
  - -> `[361]` (*Player_Romus: ""How convenient.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Titus Gordion: ""Su Omina militants had planned an attack on a convoy of ..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get to the point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Titus Gordion: ""I was just getting there, sir.""*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How convenient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Titus Gordion: ""I assure you, it was anything but convenient.""*)

### Węzeł `[362]`
Mówca: **Titus Gordion**
> ""I assure you, it was anything but convenient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Titus Gordion: ""Su Omina militants had planned an attack on a convoy of ..."*)

### Węzeł `[363]`
Mówca: **Titus Gordion**
> ""Su Omina militants had planned an attack on a convoy of Wehlen supporters who want Zille to stay with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Titus Gordion: ""When Alexei's car approached, it was caught in the cross..."*)

### Węzeł `[364]`
Mówca: **Titus Gordion**
> ""When Alexei's car approached, it was caught in the crossfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Titus Gordion: ""The militants, not distinguishing between targets, attac..."*)

### Węzeł `[365]`
Mówca: **Titus Gordion**
> ""The militants, not distinguishing between targets, attacked and destroyed his vehicle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Titus Gordion: ""Alexei was killed instantly, and the documents were dest..."*)

### Węzeł `[366]`
Mówca: **Titus Gordion**
> ""Alexei was killed instantly, and the documents were destroyed in the explosion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Titus Gordion: ""It was a tragic coincidence.""*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So, we lost our lead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Titus Gordion: ""I'm afraid so, sir.""*)

### Węzeł `[368]`
Mówca: **Titus Gordion**
> ""It was a tragic coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Player_Romus: ""Great. So you're saying this was all for nothing.""*)
  - -> `[367]` (*Player_Romus: ""Great. So, we lost our lead?""*)
  - -> `[370]` (*Player_Romus: ""That's disappointing news. My condolences to your operat..."*)
  - -> `[401]` (*Player_Romus: ""I knew enable Su Omina operations in ZIlle was a mistake.""*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. So you're saying this was all for nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Titus Gordion: ""I wouldn't say that.""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's disappointing news. My condolences to your operative.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Titus Gordion: ""Thank you, sir. It was a most unfortunate turn of events.""*)

### Węzeł `[371]`
Mówca: **Titus Gordion**
> ""I was just getting there, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Titus Gordion: ""Su Omina militants had planned an attack on a convoy of ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucita Azaro: ""But to our surprise, a piece of evidence we had nearly d..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucita Azaro: ""But to our surprise, a piece of evidence we had nearly d..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Titus Gordion: ""However, a piece of evidence we had nearly dismissed nea..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Titus Gordion: ""However, much to our surprise, a piece of evidence we ha..."*)

### Węzeł `[378]`
Mówca: **Lucita Azaro**
> ""But to our surprise, a piece of evidence we had nearly dismissed almost turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""I don't like the sound of this. What evidence?""*)
  - -> `[289]` (*Player_Romus: ""This sounds promising. I want to hear every detail.""*)
  - -> `[288]` (*Player_Romus: ""That being?""*)
  - -> `[290]` (*Player_Romus: ""What’s this evidence, and how does it shift our entire i..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the sound of this. What evidence?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Lucita Azaro), `[380]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[380]`
Mówca: **Titus Gordion**
> ""However, a piece of evidence we had nearly dismissed nearly turned out to be the key to unlocking the entire investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""I don't like the sound of this. What evidence?""*)
  - -> `[289]` (*Player_Romus: ""This sounds promising. I want to hear every detail.""*)
  - -> `[288]` (*Player_Romus: ""That being?""*)
  - -> `[290]` (*Player_Romus: ""What’s this evidence, and how does it shift our entire i..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""I can't say I condone such actions, but I suppose if it ..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[384]`
Mówca: **Lucita Azaro**
> ""Rightly, so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Lucita Azaro: ""My operative managed to coerce him into digging deeper i..."*)

### Węzeł `[385]`
Mówca: **Lucita Azaro**
> ""My operative managed to coerce him into digging deeper into their archives, far beyond the usual scope of their investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""We knew Wehlen’s databases were extensive, but rarely do..."*)

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Lucita Azaro: ""My operative managed to coerce him into digging deeper i..."*)

### Węzeł `[387]`
Mówca: **Lucita Azaro**
> ""Spy-craft 101.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Lucita Azaro: ""My operative managed to coerce him into digging deeper i..."*)

### Węzeł `[388]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. It was an unfortunate turn of events.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Lucita Azaro**
> ""An unfortunate turn of events. Yet, despite this setback, Su Omina could still be crucial to the success of Zille’s return.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[390]`
Mówca: **Lucita Azaro**
> ""While we may not have come to the desired conclusion, Su Omina's mistake is a lesson on how to refine our strategies and improve our approach to future operations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like my kind of guy!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Lucita Azaro: ""Let's hope you never have the pleasure of meeting him un..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalV..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Player_Romus: ""Sounds like my kind of guy!""*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[395]`
Mówca: **Lucita Azaro**
> ""He's a known spy for Lespia. That's who he is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Stationed at their consulate in Zille, he’s been operati..."*)

### Węzeł `[396]`
Mówca: **Lucita Azaro**
> ""It involves a lot of paperwork and fewer royal privileges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Stationed at their consulate in Zille, he’s been operati..."*)

### Węzeł `[397]`
Mówca: **Lucita Azaro**
> ""Let's hope you never have the pleasure of meeting him under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Stationed at their consulate in Zille, he’s been operati..."*)

### Węzeł `[398]`
Mówca: **Titus Gordion**
> ""Believe me, Alexei is the best of the best in covert operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""If you recall, he was the young man I sparred with at ou..."*)

### Węzeł `[399]`
Mówca: **Titus Gordion**
> ""Alexei took all necessary measures to ensure his activities remain undetected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""If you recall, he was the young man I sparred with at ou..."*)

### Węzeł `[400]`
Mówca: **Titus Gordion**
> ""A reminder of the importance of exploring every angle, even those that seem obscure or inconsequential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""If you recall, he was the young man I sparred with at ou..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew enable Su Omina operations in ZIlle was a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Titus Gordion: ""An unfortunate turn of events. However, despite this set..."*)

### Węzeł `[402]`
Mówca: **Titus Gordion**
> ""I wouldn't say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Titus Gordion: ""Although we didn't acquire the desired result, Su Omina'..."*)

### Węzeł `[403]`
Mówca: **Titus Gordion**
> ""I'm afraid so, sir.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[404]`
Mówca: **Titus Gordion**
> ""Thank you, sir. It was a most unfortunate turn of events.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[405]`
Mówca: **Titus Gordion**
> ""An unfortunate turn of events. However, despite this setback, Su Omina could still be crucial to the success of Zille’s return.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[406]`
Mówca: **Titus Gordion**
> ""Although we didn't acquire the desired result, Su Omina's mistake teaches us how to refine our strategies and enhance our approach to future operations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[407]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is he?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Titus Gordion: ""It just so happens that Viktor Karnov is a well-known spy.""*)

### Węzeł `[408]`
Mówca: **Titus Gordion**
> ""It just so happens that Viktor Karnov is a well-known spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Titus Gordion: ""For Lespia.""*)

### Węzeł `[409]`
**[WYBÓR GRACZA: "Wait for Titus to continue."]** — Mówca: **Player_Romus_Italic**
> "I waited for Titus to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Titus Gordion: ""Viktor Karnov is a well-known spy.""*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ha! Sounds like my kind of guy!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[39]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Titus Gordion: ""Let’s hope you never have the misfortune of meeting him ..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: ""Ha! Sounds like my kind of guy!""*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[414]`
Mówca: **Titus Gordion**
> ""Let’s hope you never have the misfortune of meeting him under such circumstances. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Titus Gordion: ""Viktor Karnov is a well-known spy.""*)

### Węzeł `[415]`
Mówca: **Titus Gordion**
> ""Viktor Karnov is a noted spy for Lespia, though his activities are not widely publicized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Titus Gordion: ""Based at their consulate in Zille, he’s been operating u..."*)

### Węzeł `[416]`
Mówca: **Titus Gordion**
> ""For Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Titus Gordion: ""Based at their consulate in Zille, he’s been operating u..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, yes. I'd nearly forgotten all about them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Titus Gordion), `[81]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Titus Gordion: ""I had a gut feeling that there was more to uncover, and ..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like your instincts were spot on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Titus Gordion: ""I had a gut feeling that there was more to uncover, and ..."*)

### Węzeł `[419]`
Mówca: **Titus Gordion**
> ""He took all necessary measures to ensure that his activities remain undetected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Titus Gordion: ""If your memory serves you well, he was the young man I s..."*)

### Węzeł `[420]`
Mówca: **Titus Gordion**
> ""I assure you, Alexei is the best of the best in covert operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Titus Gordion: ""If your memory serves you well, he was the young man I s..."*)

### Węzeł `[421]`
Mówca: **Titus Gordion**
> ""A reminder of the importance of exploring every angle, even those that seem obscure or inconsequential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Titus Gordion: ""If your memory serves you well, he was the young man I s..."*)

### Węzeł `[422]`
Mówca: **Titus Gordion**
> ""No doubt, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[423]`
Mówca: **Taddeus Azaro**
> ""However, any progress that *was* made regarding their possible involvement was lost during the transition between Lucita's dismissal and my appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Taddeus Azaro: ""To put it plainly, we've hit a dead end.""*)

### Węzeł `[424]`
Mówca: **Taddeus Azaro**
> ""And since your orders directed us to focus the investigation on Wehlen, no further progress has been made on that lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Taddeus Azaro: ""However, any progress that *was* made regarding their po..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Comple..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Lucita Azaro: ""Thanks to our new foreign intelligence hub, we achieved ..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true  )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucita Azaro: ""This man was rather unhappy with his current situation a..."*)

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""Thanks to our new foreign intelligence hub, we achieved this despite my department's limited resources due to the war in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucita Azaro: ""This man was rather unhappy with his current situation a..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||R..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""Good. You'll be pleased with the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Lucita Azaro: ""Unfortunately, the final findings are troubling and may ..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Titus Gordion: ""Regrettably, the final findings are troubling and could ..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Comple..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lucita Azaro: ""Good. You'll be pleased with the results.""*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Titus Gordion: ""Good. You'll be satisfied with what we've discovered.""*)

### Węzeł `[445]`
Mówca: **Titus Gordion**
> ""Good. You'll be satisfied with what we've discovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[446]`
Mówca: **Lucita Azaro**
> ""Unfortunately, the final findings are troubling and may complicate matters further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[447]`
Mówca: **Titus Gordion**
> ""Regrettably, the final findings are troubling and could complicate matters further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||R..."*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true |..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""With the support of our new foreign intelligence hub, we accomplished this despite my department's limited resources due to the war in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Lucita leaned across the table to turn on the intercom an..."*)

### Węzeł `[452]`
Mówca: **Lucita Azaro**
> ""Good. I have no doubt you'll be pleased with the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucita Azaro: ""With the support of our new foreign intelligence hub, we..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Lucita Azaro: ""Good. I have no doubt you'll be pleased with the results.""*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Titus Gordion: ""I believe you'll be satisfied with what we've discovered.""*)

### Węzeł `[456]`
Mówca: **Titus Gordion**
> ""I believe you'll be satisfied with what we've discovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Titus Gordion: ""Despite the limited resources due to the war in Pales, w..."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "Lucita leaned across the table to turn on the intercom and speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Lucita Azaro: ""Send them in.""*)

### Węzeł `[458]`
Mówca: **Lucita Azaro**
> ""Send them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "The council room doors opened, and two men in military un..."*)

### Węzeł `[459]`
Mówca: **Titus Gordion**
> ""Despite the limited resources due to the war in Pales, we succeeded thanks to our new foreign intelligence hub.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "Titus leaned across the table to turn on the intercom and..."*)

### Węzeł `[460]`
Mówca: **Narrator**
> "Titus leaned across the table to turn on the intercom and speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Titus Gordion: ""Send them in.""*)

### Węzeł `[461]`
Mówca: **Titus Gordion**
> ""Send them in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "The doors to the council room opened, and two men in mili..."*)

### Węzeł `[462]`
Mówca: **Narrator**
> "The council room doors opened, and two men in military uniforms entered, wheeling in a film projector."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "They began setting it up at the front of the room.""*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A motion picture to support your findings?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[467]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does it have to do with a film projector?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[467]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, a movie? How delightful. Is popcorn included, or do I need to bring my own?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[467]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[466]`
Mówca: **Narrator**
> "The doors to the council room opened, and two men in military uniforms wheeled in a film projector."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "They began setting it up at the front of the room.""*)

### Węzeł `[467]`
Mówca: **Narrator**
> "They began setting it up at the front of the room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Player_Romus: ""What does it have to do with a film projector?""*)
  - -> `[463]` (*Player_Romus: ""A motion picture to support your findings?""*)
  - -> `[465]` (*Player_Romus: ""Oh, a movie? How delightful. Is popcorn included, or do ..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||R..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Lucita Azaro: ""I wish I had better news, but I'm afraid the conclusions..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Titus Gordion: ""I wish I had better news, but the conclusions we've reac..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Lucita Azaro: ""I understand your concern, but I believe you'll be pleas..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Titus Gordion: ""I understand your concern, but I can assure you that you..."*)

### Węzeł `[480]`
Mówca: **Titus Gordion**
> ""I understand your concern, but I can assure you that you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[481]`
Mówca: **Lucita Azaro**
> ""I wish I had better news, but I'm afraid the conclusions we've reached will not be what you hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[482]`
Mówca: **Titus Gordion**
> ""I wish I had better news, but the conclusions we've reached will not be what you hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[483]`
Mówca: **Lucita Azaro**
> ""I understand your concern, but I believe you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Comple..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||R..."*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true |..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Lucita Azaro: ""I understand your concern, but I know you'll be pleased ..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Titus Gordion: ""I understand your concern, but I can  assure you that yo..."*)

### Węzeł `[493]`
Mówca: **Titus Gordion**
> ""I understand your concern, but I can  assure you that you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Titus Gordion: ""Despite the limited resources due to the war in Pales, w..."*)

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""I understand your concern, but I know you'll be pleased with our progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucita Azaro: ""With the support of our new foreign intelligence hub, we..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_Security_InvestigateBombingWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_Security_InvestigateBombingWehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||R..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower >= 4"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower >= 4)"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Comple..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||R..."*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true |..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Diplomacy_Pales_ATAActive == true ||RiziaDLC.Security_Pales_SendSpecialOps == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Diplomacy_Pales_ATAActive"] == true  or Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Lucita Azaro: ""I understand your apprehension, but I assure you that ou..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Titus Gordion: ""Your concern is understandable, but I assure you that ou..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Lucita Azaro: ""Unfortunately, your instincts are correct.""*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Titus Gordion: ""I hate to say it, but your instincts are correct.""*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucita Azaro: ""I understand your apprehension, but I can assure you tha..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Titus Gordion: ""Your concern is understandable, but I assure you that ou..."*)

### Węzeł `[516]`
Mówca: **Lucita Azaro**
> ""I understand your apprehension, but I assure you that our findings reveal promising developments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucita Azaro: ""With the support of our new foreign intelligence hub, we..."*)

### Węzeł `[517]`
Mówca: **Titus Gordion**
> ""Your concern is understandable, but I assure you that our findings reveal promising news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Titus Gordion: ""Despite the limited resources due to the war in Pales, w..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `TitusWehlenInvestigation_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Titus Gordion: ""One of my operatives gained access to Wehlen's Security ..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [TitusWehlenInvestigation_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "TitusWehlenInvestigation_Hub"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GGBombResult_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_WehlenInvestigation_Cooperate ==..."*)
