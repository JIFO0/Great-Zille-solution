# Sordland/Turn08/Other Cabinet Updates

- **ID konwersacji:** `177`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/177_Other_Cabinet_Updates.md`
- **Liczba węzłów dialogowych:** 389
- **Liczba wyborów gracza:** 82

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[35]** Gus Manger
- **[51]** Symon Holl
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.GovernmentBudget`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Economy_TourismAct`
- `BaseGame.Situation_Diplomacy_LespiaTradeTariffs`
- `BaseGame.Situation_Diplomacy_ValgslandTradeTariffs`
- `BaseGame.Situation_Economy_Gruni_LightTowerRegion`
- `BaseGame.Situation_Economy_Gruni_MaintainingGrowth`
- `BaseGame.Situation_Economy_Tourism_Average`
- `BaseGame.Situation_Economy_Tourism_Booming`
- `BaseGame.Situation_Order_BFF_ThreatAlarming`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn08_HP_SAFReady`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[176] Sordland/Turn08/PoliticsBillsBriefing** (../Turn_08/176_PoliticsBillsBriefing.md), Węzeł `[126]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""He's thinking very hard about what he did wrong.""** | `[4]` **Symon Holl**: ""Mr. President. Where's the Vice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Symon Holl**: ""I see."" |
| `[7]` | **""I don't know. Have you seen him?""** | `[4]` **Symon Holl**: ""Mr. President. Where's the Vice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Symon Holl**: ""Not lately."" |
| `[8]` | **""That's confidential, Mr. Holl.""** | `[4]` **Symon Holl**: ""Mr. President. Where's the Vice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Symon Holl**: ""Understood."" |
| `[19]` | **""Very good. Those are nasty vices anyway.""** | `[80]` **Symon Holl**: ""In addition to bringing in need..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Symon Holl**: ""Ordinarily, I'd advise against ..." |
| `[20]` | **""We can't tax people's booze and cigarettes. There'd be riots in the streets.""** | `[80]` **Symon Holl**: ""In addition to bringing in need..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Symon Holl**: ""Your public opinion would suffe..." |
| `[21]` | **""Interesting initiatives. But would the income we'd receive be worth the harm to S..."** | `[80]` **Symon Holl**: ""In addition to bringing in need..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Symon Holl**: ""Good question. The tax wouldn't..." |
| `[52]` | **""Oh. I hope the increased threat of the BFF won't put a damper on that.""** | `[51]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[26]` **Symon Holl**: ""Thankfully, tourism to Sordland..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true`<br>`(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[73]` **Symon Holl**: ""The increased what!? I'd better..." |
| `[65]` | **""Wait until the world finds out we eliminated the BFF menace. They'll come in drov..."** | `[51]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[26]` **Symon Holl**: ""Thankfully, tourism to Sordland..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true`<br>`(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false`<br>`(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[72]` **Symon Holl**: ""We did? Congratulations, Mr. Pr..." |
| `[66]` | **""Oh. I hope the increased threat of the BFF won't make matters worse.""** | `[50]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[33]` **Symon Holl**: ""Especially since the Sordish to..."<br>*(oraz 4 innych węzłów)* | `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true`<br>`(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[73]` **Symon Holl**: ""The increased what!? I'd better..." |
| `[67]` | **""Wait until the world finds out we've eliminated the BFF menace. They'll come in d..."** | `[50]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[33]` **Symon Holl**: ""Especially since the Sordish to..."<br>*(oraz 4 innych węzłów)* | `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"]`<br>`(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false`<br>`(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[72]` **Symon Holl**: ""We did? Congratulations, Mr. Pr..." |
| `[68]` | **""That's good news. Thanks for telling me.""** | `[51]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[26]` **Symon Holl**: ""Thankfully, tourism to Sordland..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[77]` **Symon Holl**: ""I never quite understood why an..." |
| `[69]` | **""Who wouldn't want to visit Sordland? It's the best country in the world!""** | `[50]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[33]` **Symon Holl**: ""Especially since the Sordish to..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[74]` **Symon Holl**: ""To live in, perhaps. But have y..." |
| `[70]` | **""That's disappointing to hear.""** | `[50]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[33]` **Symon Holl**: ""Especially since the Sordish to..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[75]` **Symon Holl**: ""To be fair, I never understood ..." |
| `[71]` | **""Why wouldn't tourism be skyrocketing? Sordland is the best country in the world!""** | `[51]` **Symon Holl**: ""Our investment in cultural pres..."<br>`[26]` **Symon Holl**: ""Thankfully, tourism to Sordland..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false` | *Brak zmian stanu* | `[77]` **Symon Holl**: ""I never quite understood why an..." |
| `[86]` | **""That's how it is around here. A new adventure every day.""** | `[84]` **Gus Manger**: ""Some excitement around the Pala..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Gus Manger**: ""You can say that again."" |
| `[87]` | **""Don't worry about it, Gus. Focus on your job.""** | `[84]` **Gus Manger**: ""Some excitement around the Pala..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Gus Manger**: ""I'm sure you're handling it ver..." |
| `[88]` | **""This should be a lesson to everyone. Double-cross me, and you'll pay the price.""** | `[84]` **Gus Manger**: ""Some excitement around the Pala..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "Gus and Symon exchanged worried ..." |
| `[89]` | **""The real excitement is yet to come, believe me.""** | `[84]` **Gus Manger**: ""Some excitement around the Pala..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Gus Manger**: ""Consider my breath bated."" |
| `[118]` | **""Well, don't celebrate too early. The term isn't over yet.""** | `[117]` **Gus Manger**: ""This is everything I'd hoped to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Gus Manger**: ""That's true. But it's safe to s..." |
| `[119]` | **""Congratulations, Gus. I know how much this project meant to you.""** | `[117]` **Gus Manger**: ""This is everything I'd hoped to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Gus Manger**: ""Not just to me, Mr. President. ..." |
| `[120]` | **""That's fantastic news. It shows what can be accomplished when the president, cabi..."** | `[117]` **Gus Manger**: ""This is everything I'd hoped to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Gus Manger**: ""We've managed to do what Soll a..." |
| `[121]` | **""It seems to me like my remaining time in office would be better spent focusing on..."** | `[165]` **Gus Manger**: ""If we seize every possible oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "Gus gritted his teeth." |
| `[122]` | **""Terrific. Gruni is the breadbasket of Sordland. Its success will benefit us all.""** | `[117]` **Gus Manger**: ""This is everything I'd hoped to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Gus Manger**: ""Exactly. Thank you for believin..." |
| `[123]` | **""Well, keep at it. I know how much Gruni means to you.""** | `[165]` **Gus Manger**: ""If we seize every possible oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Gus Manger**: ""Not just to me, Mr. President. ..." |
| `[124]` | **""All right. I'll see what I can do to help boost development there.""** | `[165]` **Gus Manger**: ""If we seize every possible oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Gus Manger**: ""That would be great, Mr. Presid..." |
| `[125]` | **""You can't just give up. I know how much Gruni means to you.""** | `[128]` **Gus Manger**: ""What could have been a beacon o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Gus Manger**: ""Not just to me, Mr. President. ..." |
| `[126]` | **""I knew it from the beginning. It made no sense to try to turn Gruni into somethin..."** | `[128]` **Gus Manger**: ""What could have been a beacon o..."<br>`[313]` **Narrator**: "Deivid left the White Room, gent..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Gus Manger**: ""Gruni is the green heart of thi..." |
| `[127]` | **""Perhaps this wouldn't be happening if you'd focused as much attention on Gruni as..."** | `[128]` **Gus Manger**: ""What could have been a beacon o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "Gus gritted his teeth." |
| `[152]` | **""I'm suspicious as well. I'm sure they'll want something in exchange.""** | `[137]` **Symon Holl**: ""I'm suspicious, of course, but ..."<br>`[147]` **Symon Holl**: ""I'm suspicious, of course, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Gus Manger**: ""First you accept Contanan aid, ..." |
| `[153]` | **""Ah. Our alliance with Valgsland is already paying off.""** | `[137]` **Symon Holl**: ""I'm suspicious, of course, but ..."<br>`[147]` **Symon Holl**: ""I'm suspicious, of course, but ..." | `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true` | *Brak zmian stanu* | `[164]` **Gus Manger**: ""First you accept Contanan aid, ..." |
| `[160]` | **""It worked out well when we accepted their help before.""** | `[137]` **Symon Holl**: ""I'm suspicious, of course, but ..."<br>`[147]` **Symon Holl**: ""I'm suspicious, of course, but ..." | `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true` | *Brak zmian stanu* | `[164]` **Gus Manger**: ""First you accept Contanan aid, ..." |
| `[161]` | **""It was a mistake accepting aid from them before. I won't do so again.""** | `[137]` **Symon Holl**: ""I'm suspicious, of course, but ..."<br>`[147]` **Symon Holl**: ""I'm suspicious, of course, but ..." | `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true` | *Brak zmian stanu* | `[164]` **Gus Manger**: ""First you accept Contanan aid, ..." |
| `[162]` | **""It gladdens my heart that our comrades are willing to lend a helping hand.""** | `[137]` **Symon Holl**: ""I'm suspicious, of course, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Gus Manger**: ""First you accept Contanan aid, ..." |
| `[188]` | **""I trust your wisdom, Deivid.""** | `[187]` **Deivid Wisci**: ""Fortunately, I believe any shor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "Symon and Gus rose from their se..."<br>`[196]` **Symon Holl**: ""I fully expect our partnership ..."<br>*(oraz 1 innych odgałęzień)* |
| `[189]` | **""I wouldn't have agreed to the alliance if I didn't believe that as well. I'm look..."** | `[187]` **Deivid Wisci**: ""Fortunately, I believe any shor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "Symon and Gus rose from their se..."<br>`[196]` **Symon Holl**: ""I fully expect our partnership ..."<br>*(oraz 1 innych odgałęzień)* |
| `[190]` | **""What if I break off the alliance? Will the tariffs end?""** | `[187]` **Deivid Wisci**: ""Fortunately, I believe any shor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Narrator**: "Symon raised an eyebrow. He gest..." |
| `[206]` | **""Thank you, Symon.""** | `[205]` **Symon Holl**: ""We'll leave you to your meeting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "Symon and Gus rose from their se..." |
| `[207]` | **""I'll pass them on.""** | `[205]` **Symon Holl**: ""We'll leave you to your meeting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "Symon and Gus rose from their se..." |
| `[208]` | **""Have a good afternoon, both of you.""** | `[205]` **Symon Holl**: ""We'll leave you to your meeting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "Symon and Gus rose from their se..." |
| `[215]` | **""What's delicate about it? They sent us a sex spy. They'll have to answer for it.""** | `[214]` **Deivid Wisci**: ""This is a very delicate situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Deivid Wisci**: ""Please understand..."" |
| `[216]` | **""I understand. Our relations with Rumburg were precarious enough before this.""** | `[214]` **Deivid Wisci**: ""This is a very delicate situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Deivid Wisci**: ""Please understand..."" |
| `[217]` | **""You don't have to tell me that.""** | `[214]` **Deivid Wisci**: ""This is a very delicate situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Deivid Wisci**: ""Please understand..."" |
| `[219]` | **""It's been a rough few days, Deivid.""** | `[218]` **Deivid Wisci**: ""How are you, Anton? You look as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deivid Wisci**: ""I'll be very brief. Perhaps we ..." |
| `[220]` | **""Sleeplessness comes part and parcel with this job. You know that.""** | `[218]` **Deivid Wisci**: ""How are you, Anton? You look as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deivid Wisci**: ""I'll be very brief. Perhaps we ..." |
| `[221]` | **""You're better off not knowing.""** | `[218]` **Deivid Wisci**: ""How are you, Anton? You look as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deivid Wisci**: ""I'll be very brief. Perhaps we ..." |
| `[222]` | **""Can I ask you a personal question? Were you ever unfaithful to Cathrin?""** | `[218]` **Deivid Wisci**: ""How are you, Anton? You look as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Narrator**: "He blinked, slightly taken aback." |
| `[227]` | **""This isn't about me. This is about Petr.""** | `[226]` **Deivid Wisci**: ""Why? Have you broken your vows ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "He looked at me sadly." |
| `[228]` | **""Forget I asked. Let's talk diplomacy.""** | `[226]` **Deivid Wisci**: ""Why? Have you broken your vows ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Deivid Wisci**: ""Yes, we should leave this topic..." |
| `[229]` | **""No. Although God knows I've thought about it.""** | `[226]` **Deivid Wisci**: ""Why? Have you broken your vows ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "He looked at me sternly." |
| `[230]` | **""Never. I love my wife more than anything.""** | `[226]` **Deivid Wisci**: ""Why? Have you broken your vows ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Narrator**: "He looked relieved." |
| `[274]` | **""Bringing Rumburg to justice for what it's done is far more important than reconci..."** | `[257]` **Deivid Wisci**: ""We must exercise caution. The s..."<br>`[268]` **Deivid Wisci**: ""An incident such as this might ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Deivid Wisci**: ""The quest for 'justice' has bli..." |
| `[276]` | **""You're right as usual. The last thing we want is a war on our hands.""** | `[257]` **Deivid Wisci**: ""We must exercise caution. The s..."<br>`[268]` **Deivid Wisci**: ""An incident such as this might ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Deivid Wisci**: ""A compromise in the name of the..." |
| `[277]` | **""I don't even know if peace is possible after so many years of animosity.""** | `[257]` **Deivid Wisci**: ""We must exercise caution. The s..."<br>`[275]` **Deivid Wisci**: ""But we must exercise caution. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Deivid Wisci**: ""There is always hope for peace...." |
| `[289]` | **""Of course, Deivid. It's always valuable having you around.""** | `[288]` **Deivid Wisci**: ""That would be General Lancea wi..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Iosef Lancea"); ;` | `[292]` **Narrator**: "Iosef brusquely entered and took..." |
| `[290]` | **""A military update on Valgsland? I think I have an idea what this could be about.""** | `[288]` **Deivid Wisci**: ""That would be General Lancea wi..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Iosef Lancea"); ;` | `[292]` **Narrator**: "Iosef brusquely entered and took..." |
| `[291]` | **""I'm already starting to wonder whether that alliance was a good idea.""** | `[288]` **Deivid Wisci**: ""That would be General Lancea wi..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Iosef Lancea"); ;` | `[292]` **Narrator**: "Iosef brusquely entered and took..." |
| `[297]` | **""And? What role is Sordland expected to play in this invasion?""** | `[296]` **Iosef Lancea**: ""Their war minister has informed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Iosef Lancea**: ""Not an active one, thankfully."" |
| `[298]` | **""Time for our armies to practice shooting Agnolians.""** | `[296]` **Iosef Lancea**: ""Their war minister has informed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Iosef Lancea**: ""There'll be no need for that, t..." |
| `[299]` | **""I hope they're not planning anything too drastic.""** | `[296]` **Iosef Lancea**: ""Their war minister has informed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Iosef Lancea**: ""If they are, they're leaving us..." |
| `[300]` | **""Good. I'm happy to help our brothers-in-arms claim their rightful land.""** | `[296]` **Iosef Lancea**: ""Their war minister has informed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Iosef Lancea**: ""Thankfully, they're not asking ..." |
| `[308]` | **""Our Valgish comrades will surely come to our aid.""** | `[307]` **Iosef Lancea**: ""The Valgs had better not back d..." | `Variable["BaseGame.Archetype_ComradeRayne"]` | *Brak zmian stanu* | `[322]` **Narrator**: "Iosef raised an eyebrow." |
| `[310]` | **""It's always a pleasure, Deivid.""** | `[309]` **Deivid Wisci**: ""I'll leave you to it, Anton. I ..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Deivid Wisci"); ;` | `[313]` **Narrator**: "Deivid left the White Room, gent..." |
| `[311]` | **""Thanks for your brevity. Have a good day.""** | `[309]` **Deivid Wisci**: ""I'll leave you to it, Anton. I ..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Deivid Wisci"); ;` | `[313]` **Narrator**: "Deivid left the White Room, gent..." |
| `[312]` | **""We'll talk soon.""** | `[309]` **Deivid Wisci**: ""I'll leave you to it, Anton. I ..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Deivid Wisci"); ;` | `[313]` **Narrator**: "Deivid left the White Room, gent..." |
| `[315]` | **""I hope you will not let your personal feelings about the Republic of Valgsland un..."** | `[307]` **Iosef Lancea**: ""The Valgs had better not back d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Iosef Lancea**: ""Of course not, Mr. President. S..." |
| `[316]` | **""This alliance was not my first choice either. But I do trust Valgsland to provide..."** | `[307]` **Iosef Lancea**: ""The Valgs had better not back d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Deivid Wisci**: ""They could prove to be a formid..." |
| `[317]` | **""May it never come to that.""** | `[307]` **Iosef Lancea**: ""The Valgs had better not back d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Deivid Wisci**: ""Agreed."" |
| `[335]` | **""Have a good afternoon, gentlemen.""** | `[334]` **Iosef Lancea**: ""Hope you tear those Rumburgians..."<br>`[330]` **Narrator**: "He and Deivid stood up." | `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false` | `RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef...`<br>`Variable["BaseGameSupport.News_Turn08_HP_SAFReady"] = true;` | `[339]` **Narrator**: "My ministers left. Deivid gently..." |
| `[336]` | **""They'll get what's coming to them. Don't worry.""** | `[334]` **Iosef Lancea**: ""Hope you tear those Rumburgians..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef...`<br>`Variable["BaseGameSupport.News_Turn08_HP_SAFReady"] = true;` | `[339]` **Narrator**: "My ministers left. Deivid gently..." |
| `[337]` | **""Thank you both for the updates.""** | `[334]` **Iosef Lancea**: ""Hope you tear those Rumburgians..."<br>`[330]` **Narrator**: "He and Deivid stood up." | `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false` | `RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef...`<br>`Variable["BaseGameSupport.News_Turn08_HP_SAFReady"] = true;` | `[339]` **Narrator**: "My ministers left. Deivid gently..." |
| `[338]` | **""We'll speak again soon.""** | `[330]` **Narrator**: "He and Deivid stood up." | `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false` | `RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef...`<br>`Variable["BaseGameSupport.News_Turn08_HP_SAFReady"] = true;` | `[339]` **Narrator**: "My ministers left. Deivid gently..." |
| `[349]` | **""That's a good idea, Paskal. Those people have enough to worry about without feari..."** | `[348]` **Paskal Beniwoll**: ""The first is a measure to provi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Paskal Beniwoll**: ""Exactly, Mr. President. Receivi..." |
| `[350]` | **""Aren't you afraid that will lead to more workers going on indefinite 'sick leave'..."** | `[348]` **Paskal Beniwoll**: ""The first is a measure to provi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Paskal Beniwoll**: ""This doesn't seem to have happe..." |
| `[351]` | **""It should be up to companies to pay those workers' salaries. Not the government.""** | `[348]` **Paskal Beniwoll**: ""The first is a measure to provi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Paskal Beniwoll**: ""Ideally, perhaps, but not all c..." |
| `[352]` | **""All right. What's the other one?""** | `[348]` **Paskal Beniwoll**: ""The first is a measure to provi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Paskal Beniwoll**: ""The second is called the Childr..." |
| `[358]` | **""Very good. Children are indeed our future, even if they are not born into wealth.""** | `[357]` **Paskal Beniwoll**: ""The second is called the Childr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Paskal Beniwoll**: ""Yes, every child deserves a cha..." |
| `[359]` | **""So you're advocating we *pay* our poorest citizens to reproduce. What could go wr..."** | `[357]` **Paskal Beniwoll**: ""The second is called the Childr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Paskal Beniwoll**: ""The aim is for all children to ..." |
| `[360]` | **""These seem like quite lavish expenditures, Paskal.""** | `[357]` **Paskal Beniwoll**: ""The second is called the Childr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Paskal Beniwoll**: ""For a Sordland where every chil..." |
| `[366]` | **""I'm looking forward to it.""** | `[365]` **Paskal Beniwoll**: ""We will discuss everything else..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Paskal nodded and exited the room." |
| `[367]` | **""Thank you, Paskal.""** | `[365]` **Paskal Beniwoll**: ""We will discuss everything else..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Paskal nodded and exited the room." |
| `[368]` | **""Have a great day.""** | `[365]` **Paskal Beniwoll**: ""We will discuss everything else..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Paskal nodded and exited the room." |
| `[375]` | **""I never promised to support their invasion. Tell them we will provide no support.""** | `[296]` **Iosef Lancea**: ""Their war minister has informed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Iosef Lancea**: ""Of course not. Thankfully, they..." |

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
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""I knew it from the beginning. It made no sense to try to..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Symon came in shortly afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: ""Mr. President. Where's the Vice President today?""*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> ""Mr. President. Where's the Vice President today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""He's thinking very hard about what he did wrong.""*)
  - -> `[7]` (*Player: ""I don't know. Have you seen him?""*)
  - -> `[8]` (*Player: ""That's confidential, Mr. Holl.""*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Symon Holl");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Symon Holl");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Symon came in shortly afterwards."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's thinking very hard about what he did wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: ""I see.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't know. Have you seen him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Symon Holl: ""Not lately.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's confidential, Mr. Holl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Symon Holl: ""Understood.""*)

### Węzeł `[9]`
Mówca: **Symon Holl**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Symon's expression remained unchanged as he sat down to f..."*)

### Węzeł `[10]`
Mówca: **Symon Holl**
> ""Not lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Symon's expression remained unchanged as he sat down to f..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Symon's expression remained unchanged as he sat down to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Symon Holl: ""I just wanted to provide you with a few updates on the e..."*)

### Węzeł `[12]`
Mówca: **Symon Holl**
> ""I just wanted to provide you with a few updates on the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[13]`
Mówca: **Symon Holl**
> ""You may have noticed that the government budget is in need of a boost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: ""My ministry is therefore working on a bill that will inc..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget < 0)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: ""You may have noticed that the government budget is in ne..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: ""The government budget is currently healthy enough that w..."*)

### Węzeł `[17]`
Mówca: **Symon Holl**
> ""My ministry is therefore working on a bill that will increase the tax on tobacco products from 10 to 30 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: ""A similar bill is being drafted to introduce a 20 percen..."*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> ""A similar bill is being drafted to introduce a 20 percent tax on alcohol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Symon Holl: ""In addition to bringing in needed revenue, the new laws ..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very good. Those are nasty vices anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Symon Holl: ""Ordinarily, I'd advise against this kind of thing. But w..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We can't tax people's booze and cigarettes. There'd be riots in the streets.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Symon Holl: ""Your public opinion would suffer. There's no getting aro..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting initiatives. But would the income we'd receive be worth the harm to Sordish businesses?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Symon Holl: ""Good question. The tax wouldn't apply to products design..."*)

### Węzeł `[22]`
Mówca: **Symon Holl**
> ""Your public opinion would suffer. There's no getting around that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Symon Holl: ""Ordinarily, I'd advise against this kind of thing. But w..."*)

### Węzeł `[23]`
Mówca: **Symon Holl**
> ""Good question. The tax wouldn't apply to products designated for export, which would mitigate the damage somewhat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Symon Holl: ""Ordinarily, I'd advise against this kind of thing. But w..."*)

### Węzeł `[24]`
Mówca: **Symon Holl**
> ""Ordinarily, I'd advise against this kind of thing. But with our budget dipping into the red, any measure that would reverse our deficit is worth considering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming == true"*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> ""The government budget is currently healthy enough that we don't need to worry about introducing new tax measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming == true"*)

### Węzeł `[26]`
Mówca: **Symon Holl**
> ""Thankfully, tourism to Sordland is on the rise, so we can expect to see a healthy stream of income there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Tourism_Booming == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Symon Holl: ""Thankfully, tourism to Sordland is on the rise, so we ca..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Tourism_Booming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Average == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Average == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Tourism_Average == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: ""Especially since the Sordish tourism industry has been s..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Tourism_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Symon Holl: ""Especially since our income from tourism is on the decli..."*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> ""Especially since the Sordish tourism industry has been stagnating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[34]`
Mówca: **Symon Holl**
> ""Especially since our income from tourism is on the decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[35]`
Mówca: **Symon Holl**
> ""Especially since tourism to Sordland is on the rise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Booming == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Tourism_Booming == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Booming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Symon Holl: ""Especially since tourism to Sordland is on the rise.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Tourism_Booming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Booming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Average == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Average == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Tourism_Average == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Tourism_Average == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Tourism_Average == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Tourism_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Symon Holl: ""Although it might be a nice fallback considering that th..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Tourism_Average == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Tourism_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed =..."*)

### Węzeł `[42]`
Mówca: **Symon Holl**
> ""Although it might be a nice fallback considering that the Sordish tourism industry has recently been stagnating due to stability issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[43]`
Mówca: **Symon Holl**
> ""Although it might be a nice fallback since our income from tourism is on the decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_TourismAct == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_TourismAct == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_TourismAct == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_TourismAct"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Symon Holl: ""Our investment in cultural preservation paid off, it see..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_TourismAct == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""That's good news. Thanks for telling me.""*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming == true"*)
  - -> `[71]` (*Player: ""Why wouldn't tourism be skyrocketing? Sordland is the be..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_TourismAct == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_TourismAct == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_TourismAct == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_TourismAct"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: ""Our investment in cultural preservation failed to produc..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_TourismAct == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: ""That's disappointing to hear.""*)
  - -> `[69]` (*Player: ""Who wouldn't want to visit Sordland? It's the best count..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming == true"*)

### Węzeł `[50]`
Mówca: **Symon Holl**
> ""Our investment in cultural preservation failed to produce the intended effect, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: ""That's disappointing to hear.""*)
  - -> `[69]` (*Player: ""Who wouldn't want to visit Sordland? It's the best count..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming == true"*)

### Węzeł `[51]`
Mówca: **Symon Holl**
> ""Our investment in cultural preservation paid off, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""That's good news. Thanks for telling me.""*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming == true"*)
  - -> `[71]` (*Player: ""Why wouldn't tourism be skyrocketing? Sordland is the be..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh. I hope the increased threat of the BFF won't put a damper on that.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true` AND `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl), `[26]` (Symon Holl), `[35]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: ""The increased what!? I'd better have a talk with Lileas.""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatAlarming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_BFF_ThreatAlarming == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatAlarming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""Oh. I hope the increased threat of the BFF won't make ma..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_BFF_ThreatAlarming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatAlarming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_BFF_ThreatAlarming == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatAlarming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: ""Oh. I hope the increased threat of the BFF won't put a d..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_BFF_ThreatAlarming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_BFF_ThreatEliminated == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Wait until the world finds out we eliminated the BFF men..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_BFF_ThreatEliminated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_BFF_ThreatEliminated)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""Wait until the world finds out we've eliminated the BFF ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_BFF_ThreatEliminated)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait until the world finds out we eliminated the BFF menace. They'll come in droves.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true` AND `(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false` AND `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl), `[26]` (Symon Holl), `[35]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: ""We did? Congratulations, Mr. President.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh. I hope the increased threat of the BFF won't make matters worse.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true` AND `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[33]` (Symon Holl), `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: ""The increased what!? I'd better have a talk with Lileas.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait until the world finds out we've eliminated the BFF menace. They'll come in droves.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"]` AND `(Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] == true) == false` AND `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[33]` (Symon Holl), `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: ""We did? Congratulations, Mr. President.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good news. Thanks for telling me.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl), `[26]` (Symon Holl), `[35]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Symon Holl: ""I never quite understood why anyone would want to vacati..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who wouldn't want to visit Sordland? It's the best country in the world!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[33]` (Symon Holl), `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Symon Holl: ""To live in, perhaps. But have you seen Lespia's beaches?""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's disappointing to hear.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[33]` (Symon Holl), `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Symon Holl: ""To be fair, I never understood why anyone would want to ..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why wouldn't tourism be skyrocketing? Sordland is the best country in the world!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Economy_TourismAct"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl), `[26]` (Symon Holl), `[35]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Symon Holl: ""I never quite understood why anyone would want to vacati..."*)

### Węzeł `[72]`
Mówca: **Symon Holl**
> ""We did? Congratulations, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "There was a knock on the door. Gus Manger strolled in and..."*)

### Węzeł `[73]`
Mówca: **Symon Holl**
> ""The increased what!? I'd better have a talk with Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "There was a knock on the door. Gus Manger strolled in and..."*)

### Węzeł `[74]`
Mówca: **Symon Holl**
> ""To live in, perhaps. But have you seen Lespia's beaches?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "There was a knock on the door. Gus Manger strolled in and..."*)

### Węzeł `[75]`
Mówca: **Symon Holl**
> ""To be fair, I never understood why anyone would want to vacation in Sordland when Lespia is right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "There was a knock on the door. Gus Manger strolled in and..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "There was a knock on the door. Gus Manger strolled in and grabbed a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "AddConversant("Gus Manger");"*)

### Węzeł `[77]`
Mówca: **Symon Holl**
> ""I never quite understood why anyone would want to vacation in Sordland when Lespia is right there. But I suppose our country has a certain charm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "There was a knock on the door. Gus Manger strolled in and..."*)

### Węzeł `[78]`
Mówca: **Gus Manger**
> ""Mr. President. Symon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)

### Węzeł `[79]`
Mówca: **Symon Holl**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Symon's expression remained unchanged as he sat down to f..."*)

### Węzeł `[80]`
Mówca: **Symon Holl**
> ""In addition to bringing in needed revenue, the new laws would curb excessive drinking and smoking in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""Very good. Those are nasty vices anyway.""*)
  - -> `[20]` (*Player: ""We can't tax people's booze and cigarettes. There'd be r..."*)
  - -> `[21]` (*Player: ""Interesting initiatives. But would the income we'd recei..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true ||..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Gus Manger: ""Some excitement around the Palace lately, I've heard.""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Symon Holl: ""Thanks for joining us, Gus. I believe you wanted to upda..."*)

### Węzeł `[84]`
Mówca: **Gus Manger**
> ""Some excitement around the Palace lately, I've heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""That's how it is around here. A new adventure every day.""*)
  - -> `[87]` (*Player: ""Don't worry about it, Gus. Focus on your job.""*)
  - -> `[88]` (*Player: ""This should be a lesson to everyone. Double-cross me, an..."*)
  - -> `[89]` (*Player: ""The real excitement is yet to come, believe me.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Gus Manger");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Gus Manger");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Gus Manger: ""Mr. President. Symon.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's how it is around here. A new adventure every day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: ""You can say that again.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry about it, Gus. Focus on your job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gus Manger: ""I'm sure you're handling it very well.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This should be a lesson to everyone. Double-cross me, and you'll pay the price.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Gus and Symon exchanged worried looks."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The real excitement is yet to come, believe me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Gus Manger: ""Consider my breath bated.""*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Gus and Symon exchanged worried looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger: ""Anyway...""*)

### Węzeł `[91]`
Mówca: **Gus Manger**
> ""I'm sure you're handling it very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger: ""Anyway...""*)

### Węzeł `[92]`
Mówca: **Gus Manger**
> ""You can say that again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger: ""Anyway...""*)

### Węzeł `[93]`
Mówca: **Gus Manger**
> ""Consider my breath bated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger: ""Anyway...""*)

### Węzeł `[94]`
Mówca: **Gus Manger**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Gus Manger: ""You both know how revitalizing the Gruni region has alwa..."*)

### Węzeł `[95]`
Mówca: **Gus Manger**
> ""You both know how revitalizing the Gruni region has always been my pet project of sorts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_LightTowerRegion == true"*)

### Węzeł `[96]`
Mówca: **Symon Holl**
> ""Thanks for joining us, Gus. I believe you wanted to update the President on the latest developments in the Gruni region?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Gus nodded vigorously."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Gus nodded vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Gus Manger: ""Yes, you both know how revitalizing the region has alway..."*)

### Węzeł `[98]`
Mówca: **Gus Manger**
> ""Yes, you both know how revitalizing the region has always been my pet project of sorts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_LightTowerRegion == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Gruni_LightTowerRegion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_LightTowerRegion == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Gruni_LightTowerRegion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger: ""Well. Thanks to the efforts of my ministry and the wise ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true"*)

### Węzeł `[102]`
Mówca: **Gus Manger**
> ""Well. Thanks to the efforts of my ministry and the wise allocation of funding on the President's part, it looks like the project has finally found success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Symon Holl: ""I've been keeping an eye on Gruni as well, of course. An..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Gruni_MaintainingGrowth == t..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Gruni_MaintainingGrowth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Gus Manger: ""Well. Thanks to the efforts of my ministry and the fundi..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Gruni_MaintainingGrowth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Gruni_MaintainingGrowth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Gus Manger: ""Well. I'm saddened to say that despite my ministry's bes..."*)

### Węzeł `[106]`
Mówca: **Gus Manger**
> ""Well. Thanks to the efforts of my ministry and the funding allocated by the President, Gruni is looking stable these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Symon Holl: ""Stable? That's it?""*)

### Węzeł `[107]`
Mówca: **Symon Holl**
> ""Stable? That's it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Gus shrugged."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Gus shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Gus Manger: ""It's far from the massive surge in economic growth that ..."*)

### Węzeł `[109]`
Mówca: **Gus Manger**
> ""Well. I'm saddened to say that despite my ministry's best efforts, we're going to have to close the books on this project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Symon Holl: ""'Close the books', Mr. Manger? What does that mean?""*)

### Węzeł `[110]`
Mówca: **Symon Holl**
> ""'Close the books', Mr. Manger? What does that mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Gus sighed."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Gus sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Gus Manger: ""It means that without a massive injection of funding, th..."*)

### Węzeł `[112]`
Mówca: **Gus Manger**
> ""It means that without a massive injection of funding, the economic growth I had hoped to see in the region is simply not going to happen during this term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Gus Manger: ""What could have been a beacon of success for Sordland is..."*)

### Węzeł `[113]`
Mówca: **Gus Manger**
> ""It's far from the massive surge in economic growth that I had hoped to see. But I still believe the area has a wealth of untapped potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Gus Manger: ""If we seize every possible opportunity to invest in Grun..."*)

### Węzeł `[114]`
Mówca: **Symon Holl**
> ""I've been keeping an eye on Gruni as well, of course. And it does seem to be experiencing a surge in economic growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Gus smiled proudly."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Gus smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Gus Manger: ""Wine production, shipping, agriculture... the investment..."*)

### Węzeł `[116]`
Mówca: **Gus Manger**
> ""Wine production, shipping, agriculture... the investments are pouring in. I'd call this turnaround a beacon of success for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Gus Manger: ""This is everything I'd hoped to see at the start of our ..."*)

### Węzeł `[117]`
Mówca: **Gus Manger**
> ""This is everything I'd hoped to see at the start of our term and more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""Well, don't celebrate too early. The term isn't over yet.""*)
  - -> `[119]` (*Player: ""Congratulations, Gus. I know how much this project meant..."*)
  - -> `[120]` (*Player: ""That's fantastic news. It shows what can be accomplished..."*)
  - -> `[122]` (*Player: ""Terrific. Gruni is the breadbasket of Sordland. Its succ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, don't celebrate too early. The term isn't over yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Gus Manger: ""That's true. But it's safe to say we're on the right tra..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Congratulations, Gus. I know how much this project meant to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Gus Manger: ""Not just to me, Mr. President. To all of Sordland.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's fantastic news. It shows what can be accomplished when the president, cabinet and Assembly all work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Gus Manger: ""We've managed to do what Soll and Alphonso couldn't.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems to me like my remaining time in office would be better spent focusing on other regions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Gus gritted his teeth."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Terrific. Gruni is the breadbasket of Sordland. Its success will benefit us all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Gus Manger: ""Exactly. Thank you for believing in its potential.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, keep at it. I know how much Gruni means to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Gus Manger: ""Not just to me, Mr. President. It's the breadbasket of t..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. I'll see what I can do to help boost development there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gus Manger: ""That would be great, Mr. President. I only hope it's not..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You can't just give up. I know how much Gruni means to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: ""Not just to me, Mr. President. It's the breadbasket of t..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew it from the beginning. It made no sense to try to turn Gruni into something it wasn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Gus Manger), `[313]` (Narrator), `[339]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Gus Manger: ""Gruni is the green heart of this nation, Mr. President.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps this wouldn't be happening if you'd focused as much attention on Gruni as you have on your side ventures.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Gus gritted his teeth."*)

### Węzeł `[128]`
Mówca: **Gus Manger**
> ""What could have been a beacon of success for Sordland is turning into a cesspool of crime, unemployment and homelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: ""Perhaps this wouldn't be happening if you'd focused as m..."*)
  - -> `[125]` (*Player: ""You can't just give up. I know how much Gruni means to y..."*)
  - -> `[126]` (*Player: ""I knew it from the beginning. It made no sense to try to..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Gus gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gus Manger: ""If Gruni is failing, it is not for my lack of trying. Yo..."*)

### Węzeł `[130]`
Mówca: **Gus Manger**
> ""If Gruni is failing, it is not for my lack of trying. You have no idea how much blood, sweat and tears I put into my development plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Symon Holl: ""Try to calm down, Gus. The President makes decisions on ..."*)

### Węzeł `[131]`
Mówca: **Gus Manger**
> ""I still believe it's brimming with untapped potential. It saddens me to no end to see that go to waste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Symon Holl: ""Try to calm down, Gus. The President makes decisions on ..."*)

### Węzeł `[132]`
Mówca: **Symon Holl**
> ""Try to calm down, Gus. The President makes decisions on behalf of the entire country, not only your home region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Symon Holl: ""In any case, I've heard that United Contana is preparing..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "The door to the White Room opened slowly, and Deivid made..."*)

### Węzeł `[136]`
Mówca: **Symon Holl**
> ""In any case, I've heard that United Contana is preparing to offer us a substantial agricultural aid package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Symon Holl: ""I'm suspicious, of course, but perhaps their funding can..."*)

### Węzeł `[137]`
Mówca: **Symon Holl**
> ""I'm suspicious, of course, but perhaps their funding can turn Gruni around where our efforts did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""I'm suspicious as well. I'm sure they'll want something ..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_Alliance == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[162]` (*Player: ""It gladdens my heart that our comrades are willing to le..."*)

### Węzeł `[138]`
Mówca: **Gus Manger**
> ""Not just to me, Mr. President. It's the breadbasket of this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Symon Holl: ""I'll be on the lookout for further opportunities to inve..."*)

### Węzeł `[139]`
Mówca: **Gus Manger**
> ""That would be great, Mr. President. I only hope it's not too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Symon Holl: ""I'll be on the lookout for further opportunities to inve..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Gus gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Gus Manger: ""It's a self-fulfilling prophecy, Mr. President. If Gruni..."*)

### Węzeł `[141]`
Mówca: **Gus Manger**
> ""It's a self-fulfilling prophecy, Mr. President. If Gruni is neglected, of course it will fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Symon Holl: ""Try to calm down, Gus. The President makes decisions on ..."*)

### Węzeł `[142]`
Mówca: **Symon Holl**
> ""I'll be on the lookout for further opportunities to invest in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Symon Holl: ""Apropos, I've heard that United Contana is preparing to ..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "The door to the White Room opened slowly, and Deivid made..."*)

### Węzeł `[146]`
Mówca: **Symon Holl**
> ""Apropos, I've heard that United Contana is preparing to offer us a substantial agricultural aid package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Symon Holl: ""I'm suspicious, of course, but accepting their offer cou..."*)

### Węzeł `[147]`
Mówca: **Symon Holl**
> ""I'm suspicious, of course, but accepting their offer could send development in Gruni through the roof.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""I'm suspicious as well. I'm sure they'll want something ..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_Alliance == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[148]`
Mówca: **Gus Manger**
> ""That's true. But it's safe to say we're on the right track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Symon Holl: ""Very good work, both of you.""*)

### Węzeł `[149]`
Mówca: **Gus Manger**
> ""Not just to me, Mr. President. To all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Symon Holl: ""Very good work, both of you.""*)

### Węzeł `[150]`
Mówca: **Gus Manger**
> ""We've managed to do what Soll and Alphonso couldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Symon Holl: ""Very good work, both of you.""*)

### Węzeł `[151]`
Mówca: **Gus Manger**
> ""Exactly. Thank you for believing in its potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Symon Holl: ""Very good work, both of you.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm suspicious as well. I'm sure they'll want something in exchange.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Symon Holl), `[147]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gus Manger: ""First you accept Contanan aid, next they spark an uprisi..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ah. Our alliance with Valgsland is already paying off.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Symon Holl), `[147]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gus Manger: ""First you accept Contanan aid, next they spark an uprisi..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_Alliance == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: ""Ah. Our alliance with Valgsland is already paying off.""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""It worked out well when we accepted their help before.""*)
  - -> `[161]` (*Player: ""It was a mistake accepting aid from them before. I won't..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It worked out well when we accepted their help before.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Symon Holl), `[147]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gus Manger: ""First you accept Contanan aid, next they spark an uprisi..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a mistake accepting aid from them before. I won't do so again.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Kontekst wejściowy (poprzednik):** `[137]` (Symon Holl), `[147]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gus Manger: ""First you accept Contanan aid, next they spark an uprisi..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It gladdens my heart that our comrades are willing to lend a helping hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Gus Manger: ""First you accept Contanan aid, next they spark an uprisi..."*)

### Węzeł `[163]`
Mówca: **Symon Holl**
> ""Very good work, both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[164]`
Mówca: **Gus Manger**
> ""First you accept Contanan aid, next they spark an uprising against hardworking landowners like my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_LightTowerRegion == true"*)

### Węzeł `[165]`
Mówca: **Gus Manger**
> ""If we seize every possible opportunity to invest in Gruni now, we could still see positive results within our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""It seems to me like my remaining time in office would be..."*)
  - -> `[123]` (*Player: ""Well, keep at it. I know how much Gruni means to you.""*)
  - -> `[124]` (*Player: ""All right. I'll see what I can do to help boost developm..."*)

### Węzeł `[166]`
Mówca: **Gus Manger**
> ""Not just to me, Mr. President. It's the breadbasket of this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: ""I still believe it's brimming with untapped potential. I..."*)

### Węzeł `[167]`
Mówca: **Gus Manger**
> ""Gruni is the green heart of this nation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: ""I still believe it's brimming with untapped potential. I..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Gruni_LightTowerRegion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_Gruni_LightTowerRegion == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_Gruni_LightTowerRegion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "The door to the White Room opened slowly, and Deivid made..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Economy_Gruni_LightTowerRegion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Economy_Gruni_LightTowerRegion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Gus Manger: ""I won't deny Gruni needs the money. But there's got to b..."*)

### Węzeł `[171]`
Mówca: **Gus Manger**
> ""I won't deny Gruni needs the money. But there's got to be another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "The door to the White Room opened slowly, and Deivid made..."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "The door to the White Room opened slowly, and Deivid made his way in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "AddConversant("Deivid Wisci");"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Deivid Wisci");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Deivid Wisci");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Deivid Wisci: ""Oh, hello, gentlemen. I'm early again, aren't I?""*)

### Węzeł `[174]`
Mówca: **Deivid Wisci**
> ""Oh, hello, gentlemen. I'm early again, aren't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Symon Holl: ""Not to worry, Mr. Wisci. We've just about wrapped things..."*)

### Węzeł `[175]`
Mówca: **Symon Holl**
> ""Not to worry, Mr. Wisci. We've just about wrapped things up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true |..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true || BaseGame.Situation_Diplomacy_ValgslandTradeTariffs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true |..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true || BaseGame.Situation_Diplomacy_ValgslandTradeTariffs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_LespiaTradeTariffs"] == true  or  Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Symon Holl: ""While we're both here, we may as well talk about the eco..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_LespiaTradeTariffs == true || BaseGame.Situation_Diplomacy_ValgslandTradeTariffs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_LespiaTradeTariffs"] == true  or  Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Base..."*)

### Węzeł `[179]`
Mówca: **Symon Holl**
> ""While we're both here, we may as well talk about the economic impact of our recent alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Deivid Wisci: ""A wise idea, Mr. Holl. Our new partnership is not withou..."*)

### Węzeł `[180]`
Mówca: **Deivid Wisci**
> ""A wise idea, Mr. Holl. Our new partnership is not without its consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true )"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Deivid Wisci: ""As you may recall, almost immediately after we sealed ou..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Deivid Wisci: ""As you may recall, almost immediately after we sealed ou..."*)

### Węzeł `[184]`
Mówca: **Deivid Wisci**
> ""As you may recall, almost immediately after we sealed our alliance with Lespia, Valgsland imposed strict tariffs on us in retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Symon Holl: ""The fallout won't impact our economy right away, but I d..."*)

### Węzeł `[185]`
Mówca: **Symon Holl**
> ""The fallout won't impact our economy right away, but I do expect a significant hit before the end of the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Deivid Wisci: ""Fortunately, I believe any short-term economic harm impa..."*)

### Węzeł `[186]`
Mówca: **Deivid Wisci**
> ""As you may recall, almost immediately after we sealed our alliance with Valgsland, Lespia imposed strict tariffs on us in retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Symon Holl: ""The fallout won't impact our economy right away, but I d..."*)

### Węzeł `[187]`
Mówca: **Deivid Wisci**
> ""Fortunately, I believe any short-term economic harm imparted by these tariffs will be offset by the alliance's long-term benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: ""I trust your wisdom, Deivid.""*)
  - -> `[189]` (*Player: ""I wouldn't have agreed to the alliance if I didn't belie..."*)
  - -> `[190]` (*Player: ""What if I break off the alliance? Will the tariffs end?""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I trust your wisdom, Deivid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Base..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't have agreed to the alliance if I didn't believe that as well. I'm looking at the big picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Base..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What if I break off the alliance? Will the tariffs end?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "Symon raised an eyebrow. He gestured for Deivid to answer."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "Symon raised an eyebrow. He gestured for Deivid to answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Deivid Wisci: ""The diplomatic chaos caused by ending our alliance would..."*)

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> ""The diplomatic chaos caused by ending our alliance would dent our economy far more than these tariffs will, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Base..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Symon Holl: ""I fully expect our partnership with Lespia to pay off. A..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Symon Holl: ""I'm not fully convinced the Valgsland partnership will p..."*)

### Węzeł `[196]`
Mówca: **Symon Holl**
> ""I fully expect our partnership with Lespia to pay off. Arcasia has already taken notice and is planning on sending us a generous aid offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Deivid Wisci: ""Although I've heard that aid will be military in nature,..."*)

### Węzeł `[197]`
Mówca: **Symon Holl**
> ""I'm not fully convinced the Valgsland partnership will pay off. Although the aid offer from United Contana is a head start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Deivid Wisci: ""Yes, and a sign of possible greater interest from the CSP.""*)

### Węzeł `[198]`
Mówca: **Deivid Wisci**
> ""Although I've heard that aid will be military in nature, which raises questions about their real motivations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Symon Holl: ""They're clearly gauging our interests in joining ATO. Wh..."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "Symon and Gus rose from their seats and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Symon Holl"); RemoveConversant("Gus Man..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Symon Holl");
RemoveConversant("Gus Manger");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Symon Holl");
RemoveConversant("Gus Manger");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "After the door closed, Deivid regarded me for a second. H..."*)

### Węzeł `[201]`
Mówca: **Deivid Wisci**
> ""Yes, and a sign of possible greater interest from the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Symon grimaced."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Symon grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Symon Holl: ""Hooray.""*)

### Węzeł `[203]`
Mówca: **Symon Holl**
> ""Hooray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Symon Holl: ""We'll leave you to your meeting, gentlemen. My regards t..."*)

### Węzeł `[204]`
Mówca: **Symon Holl**
> ""They're clearly gauging our interests in joining ATO. Which, from a purely financial standpoint, would be a great move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Symon Holl: ""We'll leave you to your meeting, gentlemen. My regards t..."*)

### Węzeł `[205]`
Mówca: **Symon Holl**
> ""We'll leave you to your meeting, gentlemen. My regards to Mr. Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""Thank you, Symon.""*)
  - -> `[207]` (*Player: ""I'll pass them on.""*)
  - -> `[208]` (*Player: ""Have a good afternoon, both of you.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Symon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Symon and Gus rose from their seats and left the room."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll pass them on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Symon and Gus rose from their seats and left the room."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have a good afternoon, both of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Symon and Gus rose from their seats and left the room."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "After the door closed, Deivid regarded me for a second. His blue eyes seemed to see right through me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true || Ba..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true || Ba..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true || ..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Deivid Wisci: ""My ministry was notified about the Rumburgian infiltrator.""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Deivid Wisci: ""How are you, Anton? You look as if you haven't slept in ..."*)

### Węzeł `[213]`
Mówca: **Deivid Wisci**
> ""My ministry was notified about the Rumburgian infiltrator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deivid Wisci: ""This is a very delicate situation, Anton.""*)

### Węzeł `[214]`
Mówca: **Deivid Wisci**
> ""This is a very delicate situation, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""What's delicate about it? They sent us a sex spy. They'l..."*)
  - -> `[216]` (*Player: ""I understand. Our relations with Rumburg were precarious..."*)
  - -> `[217]` (*Player: ""You don't have to tell me that.""*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's delicate about it? They sent us a sex spy. They'll have to answer for it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Deivid Wisci: ""Please understand...""*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand. Our relations with Rumburg were precarious enough before this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Deivid Wisci: ""Please understand...""*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't have to tell me that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Deivid Wisci: ""Please understand...""*)

### Węzeł `[218]`
Mówca: **Deivid Wisci**
> ""How are you, Anton? You look as if you haven't slept in ages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""It's been a rough few days, Deivid.""*)
  - -> `[220]` (*Player: ""Sleeplessness comes part and parcel with this job. You k..."*)
  - -> `[221]` (*Player: ""You're better off not knowing.""*)
  - -> `[222]` (*Player: ""Can I ask you a personal question? Were you ever unfaith..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's been a rough few days, Deivid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deivid Wisci: ""I'll be very brief. Perhaps we can even carve out some t..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sleeplessness comes part and parcel with this job. You know that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deivid Wisci: ""I'll be very brief. Perhaps we can even carve out some t..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're better off not knowing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deivid Wisci: ""I'll be very brief. Perhaps we can even carve out some t..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can I ask you a personal question? Were you ever unfaithful to Cathrin?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "He blinked, slightly taken aback."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "He blinked, slightly taken aback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Deivid Wisci: ""I've met many a beautiful woman in the course of my trav..."*)

### Węzeł `[224]`
Mówca: **Deivid Wisci**
> ""I've met many a beautiful woman in the course of my travels. But no, even in my younger days, I was never tempted to stray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Deivid Wisci: ""My deep love for my wife -- as well as the need to prote..."*)

### Węzeł `[225]`
Mówca: **Deivid Wisci**
> ""My deep love for my wife -- as well as the need to protect my reputation as a statesman -- prevented me from doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Deivid Wisci: ""Why? Have you broken your vows with Monica, Anton?""*)

### Węzeł `[226]`
Mówca: **Deivid Wisci**
> ""Why? Have you broken your vows with Monica, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: ""This isn't about me. This is about Petr.""*)
  - -> `[229]` (*Player: ""No. Although God knows I've thought about it.""*)
  - -> `[230]` (*Player: ""Never. I love my wife more than anything.""*)
  - -> `[228]` (*Player: ""Forget I asked. Let's talk diplomacy.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't about me. This is about Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "He looked at me sadly."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Forget I asked. Let's talk diplomacy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Deivid Wisci: ""Yes, we should leave this topic for another day.""*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Although God knows I've thought about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He looked at me sternly."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Never. I love my wife more than anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "He looked relieved."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "He looked at me sternly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Deivid Wisci: ""Some thoughts are better off not translated into actions.""*)

### Węzeł `[232]`
Mówca: **Deivid Wisci**
> ""Some thoughts are better off not translated into actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: ""But let's have this conversation over tea, not during a ..."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "He looked relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deivid Wisci: ""Some men go their entire lives without finding what you ..."*)

### Węzeł `[234]`
Mówca: **Deivid Wisci**
> ""Some men go their entire lives without finding what you and I have. Best not to mess it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: ""But let's have this conversation over tea, not during a ..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "He looked at me sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Deivid Wisci: ""Men of our stature are granted a certain power in societ..."*)

### Węzeł `[236]`
Mówca: **Deivid Wisci**
> ""Men of our stature are granted a certain power in society. Some know how to wield it responsibly, and others do not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Deivid Wisci: ""I see that Mr. Vectern wants to do right by his wife and..."*)

### Węzeł `[237]`
Mówca: **Deivid Wisci**
> ""I see that Mr. Vectern wants to do right by his wife and his position. I hope someday he finds the strength to face his demons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: ""But let's have this conversation over tea, not during a ..."*)

### Węzeł `[238]`
Mówca: **Deivid Wisci**
> ""Yes, we should leave this topic for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deivid Wisci: ""I'll be very brief. Perhaps we can even carve out some t..."*)

### Węzeł `[239]`
Mówca: **Deivid Wisci**
> ""I'll be very brief. Perhaps we can even carve out some time for you to rest your eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)

### Węzeł `[240]`
Mówca: **Deivid Wisci**
> ""But let's have this conversation over tea, not during a cabinet meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deivid Wisci: ""I'll be very brief. Perhaps we can even carve out some t..."*)

### Węzeł `[241]`
Mówca: **Deivid Wisci**
> ""I'm very glad to report that our diplomatic efforts with Rumburg have been met with an equally diplomatic response from the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Deivid Wisci: ""We may even be able to enter peace talks with the Queen ..."*)

### Węzeł `[242]`
Mówca: **Deivid Wisci**
> ""Please understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrant..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Deivid Wisci: ""I'm very glad to report that our diplomatic efforts with..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Deivid Wisci: ""Regretfully, tensions are continuing to mount between So..."*)

### Węzeł `[246]`
Mówca: **Deivid Wisci**
> ""We may even be able to enter peace talks with the Queen very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Deivid Wisci: ""But we must exercise caution. The slightest provocation ..."*)

### Węzeł `[247]`
Mówca: **Deivid Wisci**
> ""Regretfully, tensions are continuing to mount between Sordland and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)

### Węzeł `[248]`
Mówca: **Deivid Wisci**
> ""As you might imagine, our decision to grant asylum to their whistleblower Mr. Hailstone did not sit well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsyl..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deivid Wisci: ""As you might imagine, our decision to grant asylum to th..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Deivid Wisci: ""As you might imagine, the embargo we decreed has not bee..."*)

### Węzeł `[252]`
Mówca: **Deivid Wisci**
> ""As you might imagine, the embargo we decreed has not been sitting well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Deivid Wisci: ""We must exercise caution. The slightest provocation on e..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Deivid Wisci: ""Nor did the embargo we decreed.""*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Deivid Wisci: ""We must exercise caution. The slightest provocation on e..."*)

### Węzeł `[256]`
Mówca: **Deivid Wisci**
> ""Nor did the embargo we decreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Deivid Wisci: ""We must exercise caution. The slightest provocation on e..."*)

### Węzeł `[257]`
Mówca: **Deivid Wisci**
> ""We must exercise caution. The slightest provocation on either side could cost us our chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: ""Bringing Rumburg to justice for what it's done is far mo..."*)
  - -> `[276]` (*Player: ""You're right as usual. The last thing we want is a war o..."*)
  - -> `[277]` (*Player: ""I don't even know if peace is possible after so many yea..."*)

### Węzeł `[258]`
Mówca: **Deivid Wisci**
> ""The tensions between Sordland and Rumburg have not eased. Quite the contrary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)

### Węzeł `[259]`
Mówca: **Deivid Wisci**
> ""As you might imagine, our decision to grant asylum to their whistleblower Mr. Hailstone did not sit well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsyl..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Deivid Wisci: ""As you might imagine, our decision to grant asylum to th..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Deivid Wisci: ""As you might imagine, the embargo we decreed has not bee..."*)

### Węzeł `[263]`
Mówca: **Deivid Wisci**
> ""As you might imagine, the embargo we decreed has not been sitting well with the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deivid Wisci: ""An incident such as this might serve as a tipping point...."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Deivid Wisci: ""Nor did the embargo we decreed.""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deivid Wisci: ""An incident such as this might serve as a tipping point...."*)

### Węzeł `[267]`
Mówca: **Deivid Wisci**
> ""Nor did the embargo we decreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deivid Wisci: ""An incident such as this might serve as a tipping point...."*)

### Węzeł `[268]`
Mówca: **Deivid Wisci**
> ""An incident such as this might serve as a tipping point. Place too much blame on Rumburg, and we may lose our chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: ""Bringing Rumburg to justice for what it's done is far mo..."*)
  - -> `[276]` (*Player: ""You're right as usual. The last thing we want is a war o..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrant..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Deivid Wisci: ""Prior to this revelation, our diplomatic efforts with Ru..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Deivid Wisci: ""The tensions between Sordland and Rumburg have not eased..."*)

### Węzeł `[272]`
Mówca: **Deivid Wisci**
> ""Prior to this revelation, our diplomatic efforts with Rumburg had been met with an equally diplomatic response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Deivid Wisci: ""In fact, there were indications that the Kingdom would s..."*)

### Węzeł `[273]`
Mówca: **Deivid Wisci**
> ""In fact, there were indications that the Kingdom would soon be ready to begin peace talks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deivid Wisci: ""An incident such as this might serve as a tipping point...."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bringing Rumburg to justice for what it's done is far more important than reconciliation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Deivid Wisci), `[268]` (Deivid Wisci), `[275]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deivid Wisci: ""The quest for 'justice' has blinded many a leader over t..."*)

### Węzeł `[275]`
Mówca: **Deivid Wisci**
> ""But we must exercise caution. The slightest provocation on either side could cost us our chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: ""Bringing Rumburg to justice for what it's done is far mo..."*)
  - -> `[276]` (*Player: ""You're right as usual. The last thing we want is a war o..."*)
  - -> `[277]` (*Player: ""I don't even know if peace is possible after so many yea..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right as usual. The last thing we want is a war on our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Deivid Wisci), `[268]` (Deivid Wisci), `[275]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Deivid Wisci: ""A compromise in the name of the greater good may spare c..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't even know if peace is possible after so many years of animosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Deivid Wisci), `[275]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Deivid Wisci: ""There is always hope for peace. No matter what.""*)

### Węzeł `[278]`
Mówca: **Deivid Wisci**
> ""There is always hope for peace. No matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[279]`
Mówca: **Deivid Wisci**
> ""The quest for 'justice' has blinded many a leader over the centuries. Don't let it cloud your eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> ""A compromise in the name of the greater good may spare countless lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[281]`
Mówca: **Narrator**
> "A pair of loud, precise raps came on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Deivid Wisci: ""That would be General Lancea with a further update on th..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "A pair of loud, precise raps came on the door."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Deivid Wisci: ""I'll leave you to it, Anton. I know you've got a lot on ..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Iosef Lancea");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Iosef Lancea");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Iosef brusquely entered and took a seat facing me. He and..."*)

### Węzeł `[286]`
Mówca: **Iosef Lancea**
> ""Mr. President. Mr. Wisci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Iosef Lancea: ""For better or for worse, we are now in a military allian..."*)

### Węzeł `[287]`
Mówca: **Iosef Lancea**
> ""For better or for worse, we are now in a military alliance with the Republic of Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "He paused, as if he couldn't bring himself to go on. Fina..."*)

### Węzeł `[288]`
Mówca: **Deivid Wisci**
> ""That would be General Lancea with a further update on the Valgsland alliance. If you don't mind, I'll stay for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player: ""Of course, Deivid. It's always valuable having you around.""*)
  - -> `[290]` (*Player: ""A military update on Valgsland? I think I have an idea w..."*)
  - -> `[291]` (*Player: ""I'm already starting to wonder whether that alliance was..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course, Deivid. It's always valuable having you around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "AddConversant("Iosef Lancea");"*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A military update on Valgsland? I think I have an idea what this could be about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "AddConversant("Iosef Lancea");"*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already starting to wonder whether that alliance was a good idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "AddConversant("Iosef Lancea");"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Iosef brusquely entered and took a seat facing me. He and Deivid nodded at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Iosef Lancea: ""Mr. President. Mr. Wisci.""*)

### Węzeł `[293]`
Mówca: **Narrator**
> "He paused, as if he couldn't bring himself to go on. Finally, he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Iosef Lancea: ""As I expected, the commies -- Valgslandians -- began ask..."*)

### Węzeł `[294]`
Mówca: **Iosef Lancea**
> ""As I expected, the commies -- Valgslandians -- began asking for our assistance practically as soon as the ink was dry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[295]`
Mówca: **Iosef Lancea**
> ""Sordland's recognition of Heljiland as Valgish territory has emboldened the Republic to begin planning its invasion of the island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Iosef Lancea: ""Their war minister has informed me that it will commence..."*)

### Węzeł `[296]`
Mówca: **Iosef Lancea**
> ""Their war minister has informed me that it will commence in the coming months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Player: ""And? What role is Sordland expected to play in this inva..."*)
  - -> `[298]` (*Player: ""Time for our armies to practice shooting Agnolians.""*)
  - -> `[299]` (*Player: ""I hope they're not planning anything too drastic.""*)
  - -> `[300]` (*Player: ""Good. I'm happy to help our brothers-in-arms claim their..."*)
  - -> `[375]` (*Player: ""I never promised to support their invasion. Tell them we..."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And? What role is Sordland expected to play in this invasion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Iosef Lancea: ""Not an active one, thankfully.""*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Time for our armies to practice shooting Agnolians.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Iosef Lancea: ""There'll be no need for that, thankfully.""*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope they're not planning anything too drastic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Iosef Lancea: ""If they are, they're leaving us out of it.""*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good. I'm happy to help our brothers-in-arms claim their rightful land.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Iosef Lancea: ""Thankfully, they're not asking us to play an active role.""*)

### Węzeł `[301]`
Mówca: **Iosef Lancea**
> ""Not an active one, thankfully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: ""We are readying our forces for assistance with aerial re..."*)

### Węzeł `[302]`
Mówca: **Iosef Lancea**
> ""There'll be no need for that, thankfully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: ""We are readying our forces for assistance with aerial re..."*)

### Węzeł `[303]`
Mówca: **Iosef Lancea**
> ""If they are, they're leaving us out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: ""We are readying our forces for assistance with aerial re..."*)

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> ""Thankfully, they're not asking us to play an active role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: ""We are readying our forces for assistance with aerial re..."*)

### Węzeł `[305]`
Mówca: **Iosef Lancea**
> ""We are readying our forces for assistance with aerial reconnaissance and a naval blockade. But our troops will not set foot on the island itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Deivid Wisci: ""I too expected that allying with Valgsland would necessi..."*)

### Węzeł `[306]`
Mówca: **Deivid Wisci**
> ""I too expected that allying with Valgsland would necessitate our involvement in the Heljiland situation. I'm grateful that's as far as it goes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Iosef Lancea: ""The Valgs had better not back down if it comes to war be..."*)

### Węzeł `[307]`
Mówca: **Iosef Lancea**
> ""The Valgs had better not back down if it comes to war between Sordland and Rumburg, that's for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne"*)
  - -> `[315]` (*Player: ""I hope you will not let your personal feelings about the..."*)
  - -> `[316]` (*Player: ""This alliance was not my first choice either. But I do t..."*)
  - -> `[317]` (*Player: ""May it never come to that.""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our Valgish comrades will surely come to our aid.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_ComradeRayne"]`
- **Kontekst wejściowy (poprzednik):** `[307]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Iosef raised an eyebrow."*)

### Węzeł `[309]`
Mówca: **Deivid Wisci**
> ""I'll leave you to it, Anton. I know you've got a lot on your plate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: ""It's always a pleasure, Deivid.""*)
  - -> `[311]` (*Player: ""Thanks for your brevity. Have a good day.""*)
  - -> `[312]` (*Player: ""We'll talk soon.""*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's always a pleasure, Deivid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci");"*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks for your brevity. Have a good day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci");"*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We'll talk soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci");"*)

### Węzeł `[313]`
Mówca: **Narrator**
> "Deivid left the White Room, gently closing the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Deivid Wisci");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Deivid Wisci");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "Deivid left the White Room, gently closing the door behin..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope you will not let your personal feelings about the Republic of Valgsland undermine this alliance, General.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Iosef Lancea: ""Of course not, Mr. President. Sordland's allies are my o..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This alliance was not my first choice either. But I do trust Valgsland to provide assistance if we're in need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Deivid Wisci: ""They could prove to be a formidable ally indeed.""*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""May it never come to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Deivid Wisci: ""Agreed.""*)

### Węzeł `[318]`
Mówca: **Deivid Wisci**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "He glanced at Iosef."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player: ""Our Valgish comrades will surely come to our aid.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
Mówca: **Narrator**
> "Iosef raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Iosef Lancea: ""Comrades, eh? You're starting to sound like them.""*)

### Węzeł `[323]`
Mówca: **Iosef Lancea**
> ""Comrades, eh? You're starting to sound like them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "Deivid glanced at him."*)

### Węzeł `[324]`
Mówca: **Iosef Lancea**
> ""Of course not, Mr. President. Sordland's allies are my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "Deivid glanced at him."*)

### Węzeł `[325]`
Mówca: **Deivid Wisci**
> ""They could prove to be a formidable ally indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "He glanced at Iosef."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "He glanced at Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Deivid Wisci: ""If that's all, Mr. Lancea, I suggest we leave President ..."*)

### Węzeł `[327]`
Mówca: **Deivid Wisci**
> ""If that's all, Mr. Lancea, I suggest we leave President Rayne to it. It's been a long morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Iosef Lancea: ""All right, Mr. President.""*)

### Węzeł `[328]`
Mówca: **Narrator**
> "Deivid glanced at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Deivid Wisci: ""If that's all, Mr. Lancea, I suggest we leave President ..."*)

### Węzeł `[329]`
Mówca: **Iosef Lancea**
> ""All right, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "He and Deivid stood up."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "He and Deivid stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true || Ba..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true || Ba..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true || ..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Iosef Lancea: ""Hope you tear those Rumburgians a new one for installing..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Livia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: ""Thank you both for the updates.""*)
  - -> `[335]` (*Player: ""Have a good afternoon, gentlemen.""*)
  - -> `[338]` (*Player: ""We'll speak again soon.""*)

### Węzeł `[334]`
Mówca: **Iosef Lancea**
> ""Hope you tear those Rumburgians a new one for installing a damn spy in your office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player: ""They'll get what's coming to them. Don't worry.""*)
  - -> `[337]` (*Player: ""Thank you both for the updates.""*)
  - -> `[335]` (*Player: ""Have a good afternoon, gentlemen.""*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have a good afternoon, gentlemen.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Iosef Lancea), `[330]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They'll get what's coming to them. Don't worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you both for the updates.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Iosef Lancea), `[330]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We'll speak again soon.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[330]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Deivid Wisci"); RemoveConversant("Iosef..."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "My ministers left. Deivid gently closed the door behind them, allowing me a moment of quiet once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Deivid Wisci");
RemoveConversant("Iosef Lancea");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Deivid Wisci");
RemoveConversant("Iosef Lancea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_SAFReady = true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Paskal Beniwoll");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Paskal Beniwoll");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "Paskal walked in next. He didn't bother taking a seat."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "Paskal walked in next. He didn't bother taking a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Paskal Beniwoll: ""Mr. President. Only a brief update from me today.""*)

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
> ""Mr. President. Only a brief update from me today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Paskal Beniwoll: ""My ministry has been working on a pair of bills that wil..."*)

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
> ""My ministry has been working on a pair of bills that will soon go to the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Paskal Beniwoll: ""The first is a measure to provide state benefits to all ..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget > 0)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "AddConversant("Paskal Beniwoll");"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "AddConversant("Symon Holl");"*)

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
> ""The first is a measure to provide state benefits to all citizens who are forced to miss work due to long-term illness or disability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: ""That's a good idea, Paskal. Those people have enough to ..."*)
  - -> `[350]` (*Player: ""Aren't you afraid that will lead to more workers going o..."*)
  - -> `[351]` (*Player: ""It should be up to companies to pay those workers' salar..."*)
  - -> `[352]` (*Player: ""All right. What's the other one?""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a good idea, Paskal. Those people have enough to worry about without fearing for their financial security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Paskal Beniwoll: ""Exactly, Mr. President. Receiving these benefits may eve..."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Aren't you afraid that will lead to more workers going on indefinite 'sick leave' for made-up reasons?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Paskal Beniwoll: ""This doesn't seem to have happened in other countries th..."*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It should be up to companies to pay those workers' salaries. Not the government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Paskal Beniwoll: ""Ideally, perhaps, but not all companies -- especially sm..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. What's the other one?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Paskal Beniwoll: ""The second is called the Children for Future Act. It wou..."*)

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
> ""Ideally, perhaps, but not all companies -- especially small businesses -- can afford such generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Paskal Beniwoll: ""This measure would ensure every sick or disabled employe..."*)

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
> ""This measure would ensure every sick or disabled employee has access to equal benefits without disincentivizing businesses from hiring those employees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Paskal Beniwoll: ""The second is called the Children for Future Act. It wou..."*)

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
> ""This doesn't seem to have happened in other countries that introduced such measures, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Paskal Beniwoll: ""The second is called the Children for Future Act. It wou..."*)

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
> ""Exactly, Mr. President. Receiving these benefits may even help them recover and get back to work faster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Paskal Beniwoll: ""The second is called the Children for Future Act. It wou..."*)

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
> ""The second is called the Children for Future Act. It would provide direct financial support for low-income families with children, while ensuring that the children of unemployed parents have access to education and healthcare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""Very good. Children are indeed our future, even if they ..."*)
  - -> `[359]` (*Player: ""So you're advocating we *pay* our poorest citizens to re..."*)
  - -> `[360]` (*Player: ""These seem like quite lavish expenditures, Paskal.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very good. Children are indeed our future, even if they are not born into wealth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Paskal Beniwoll: ""Yes, every child deserves a chance to thrive, regardless..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you're advocating we *pay* our poorest citizens to reproduce. What could go wrong with that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Paskal Beniwoll: ""The aim is for all children to have a chance to thrive, ..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These seem like quite lavish expenditures, Paskal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Paskal Beniwoll: ""For a Sordland where every child is given a chance to th..."*)

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
> ""The aim is for all children to have a chance to thrive, regardless of their background.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Paskal Beniwoll: ""Look for these measures to cross your desk soon. Assumin..."*)

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
> ""Yes, every child deserves a chance to thrive, regardless of background.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Paskal Beniwoll: ""Look for these measures to cross your desk soon. Assumin..."*)

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
> ""For a Sordland where every child is given a chance to thrive regardless of background, it will be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Paskal Beniwoll: ""Look for these measures to cross your desk soon. Assumin..."*)

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
> ""Look for these measures to cross your desk soon. Assuming they're approved by the Assembly, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Paskal Beniwoll: ""We will discuss everything else in more detail during ou..."*)

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
> ""We will discuss everything else in more detail during our upcoming annual health report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player: ""I'm looking forward to it.""*)
  - -> `[367]` (*Player: ""Thank you, Paskal.""*)
  - -> `[368]` (*Player: ""Have a great day.""*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm looking forward to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Paskal nodded and exited the room."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Paskal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Paskal nodded and exited the room."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have a great day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Paskal nodded and exited the room."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "Paskal nodded and exited the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Paskal Beniwoll");"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Paskal Beniwoll");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Paskal Beniwoll");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "AddConversant("Symon Holl");"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_HeljilandRecognised == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Iosef Lancea: ""Sordland's recognition of Heljiland as Valgish territory..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Iosef Lancea: ""Our military alliance has emboldened the Republic to beg..."*)

### Węzeł `[374]`
Mówca: **Iosef Lancea**
> ""Our military alliance has emboldened the Republic to begin planning its invasion of the island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Iosef Lancea: ""Their war minister has informed me that it will commence..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I never promised to support their invasion. Tell them we will provide no support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Iosef Lancea: ""Of course not. Thankfully, they're not asking us to play..."*)

### Węzeł `[376]`
Mówca: **Iosef Lancea**
> ""Of course not. Thankfully, they're not asking us to play an active role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: ""We are readying our forces for assistance with aerial re..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed =..."*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: ""Although it might be a nice fallback since our income fr..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Symon Holl: ""Although it might be a nice fallback since our tourism i..."*)

### Węzeł `[380]`
Mówca: **Symon Holl**
> ""Although it might be a nice fallback since our tourism income is on the decline, due to our lack of investment earlier in the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TourismAct == true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_SAFReady = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_SAFReady"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "My ministers left. Deivid gently closed the door behind t..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Base..."*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Ba..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Symon Holl: ""I have some thoughts regarding the wider consequences of..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Symon and Gus rose from their seats and left the room."*)

### Węzeł `[385]`
Mówca: **Symon Holl**
> ""I have some thoughts regarding the wider consequences of our diplomatic actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Base..."*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true || Ba..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance == true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Lespia_Alliance == true || BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == true  or  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Symon and Gus rose from their seats and left the room."*)
