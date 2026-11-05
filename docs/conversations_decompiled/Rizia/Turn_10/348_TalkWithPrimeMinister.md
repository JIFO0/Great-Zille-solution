# Rizia/Turn 10/TalkWithPrimeMinister

- **ID konwersacji:** `348`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/348_TalkWithPrimeMinister.md`
- **Liczba węzłów dialogowych:** 834
- **Liczba wyborów gracza:** 92

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pales_DidntRatifyTreaty`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Legislative_RegionalSenate`
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Situation_Welfare_LivingStandards_Acceptable`
- `RiziaDLC.Situation_Welfare_LivingStandards_Average`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Successor_Son`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.War_BorderOutcome_Peace_Annexation`
- `RiziaDLC.War_BorderOutcome_Peace_PalesDivided`
- `RiziaDLC.War_Happened`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.NewGov_Reform_ElectionIssues`
- `RiziaDLCIsolated.NewGov_Reform_PalesUpdate`
- `RiziaDLCIsolated.NewGov_Reform_UpperHouse`
- `RiziaDLCIsolated.NewGov_Reform_ZilleUpdate`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.TalkWithPM_EndorseAdarfo`
- `RiziaDLC.TalkWithPM_Endorse_Daria`
- `RiziaDLC.TalkWithPM_Endorse_DariaPlan`
- `RiziaDLC.TalkWithPM_Endorse_Manus`
- `RiziaDLC.TalkWithPM_Endorse_ManusPlan`
- `RiziaDLCIsolated.NewGov_Reform_ElectionIssues`
- `RiziaDLCIsolated.NewGov_Reform_PalesUpdate`
- `RiziaDLCIsolated.NewGov_Reform_UpperHouse`
- `RiziaDLCIsolated.NewGov_Reform_ZilleUpdate`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_AdarfoElectionsUpdate`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_DariaElectionsUpdate`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Adarfo`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Daria`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_DariaPlan`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Manus`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_ManusPlan`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_NoOne`
- `RiziaDLCSupport.Journal_Turn10_TalkWithPM_ManusElectionsUpdate`
- `RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Adarfo`
- `RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Daria`
- `RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Manus`
- `RiziaDLCSupport.News_Turn10_V_TalkWithPM_Adarfo`
- `RiziaDLCSupport.News_Turn10_V_TalkWithPM_Daria`
- `RiziaDLCSupport.News_Turn10_V_TalkWithPM_Manus`

### Skoki między-konwersacyjne:
- Węzeł `[125]` -> **[546] Rizia/Turn 10/Pales_Reform_Branch/Pales_Reform_Branch Conversation** (../Turn_10/546_Pales_Reform_Branch_Conversation.md), Węzeł `[1]`
- Węzeł `[130]` -> **[547] Rizia/Turn 10/Zille_Reform_Branch/Zille_Reform_Branch Conversation** (../Turn_10/547_Zille_Reform_Branch_Conversation.md), Węzeł `[1]`
- Węzeł `[140]` -> **[548] Rizia/Turn 10/Upper_House_Branch/Upper_House_Branch Conversation** (../Turn_10/548_Upper_House_Branch_Conversation.md), Węzeł `[1]`
- Węzeł `[664]` -> **[550] Rizia/Turn 10/Election_Issues/Election_Issues Conversation** (../Turn_10/550_Election_Issues_Conversation.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"“That could change the moment results don’t go their way.”"** | `[10]` **Manus Sazon**: ""Both parties had their concerns..."<br>`[97]` **Daria de Rava**: ""While both parties have their c..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Manus Sazon**: "“Hence the safeguards we've put ..."<br>`[98]` **Daria de Rava**: "“Hence the safeguards we've impl..."<br>*(oraz 1 innych odgałęzień)* |
| `[13]` | **"“I've heard enough about the election process. I trust you to see this through the..."** | `[10]` **Manus Sazon**: ""Both parties had their concerns..."<br>`[97]` **Daria de Rava**: ""While both parties have their c..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Manus Sazon**: ""Thank you for your confidence i..."<br>`[119]` **Daria de Rava**: ""The RNC will not let you down, ..."<br>*(oraz 1 innych odgałęzień)* |
| `[17]` | **"“No one can claim the election was being conducted in secrecy.”"** | `[16]` **Manus Sazon**: "“And international observers are..."<br>`[100]` **Daria de Rava**: "“And international observers are..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Manus Sazon**: "“My thoughts exactly. Regular up..."<br>`[101]` **Daria de Rava**: "“Regular updates will be provide..."<br>*(oraz 1 innych odgałęzień)* |
| `[20]` | **""They better -- any obstruction will not be tolerated.""** | `[10]` **Manus Sazon**: ""Both parties had their concerns..."<br>`[97]` **Daria de Rava**: ""While both parties have their c..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Manus Sazon**: ""Naturally, but those decisions ..."<br>`[219]` **Daria de Rava**: ""Of course, but those decisions ..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **""What about mudslinging? Are we seeing much of that?""** | `[10]` **Manus Sazon**: ""Both parties had their concerns..."<br>`[97]` **Daria de Rava**: ""While both parties have their c..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Manus Sazon**: ""In Iza, the mud’s still flying,..."<br>`[215]` **Daria de Rava**: ""In Iza, the mud’s still flying,..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **""I sometimes wonder how the average citizen can keep up with the complexity of the..."** | `[16]` **Manus Sazon**: "“And international observers are..."<br>`[100]` **Daria de Rava**: "“And international observers are..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Manus Sazon**: ""It’s certainly a lot to manage,..."<br>`[254]` **Daria de Rava**: ""It’s certainly a lot to manage,..."<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **""Good, good. We can't afford any lapses, especially not with the eyes of the world..."** | `[16]` **Manus Sazon**: "“And international observers are..."<br>`[100]` **Daria de Rava**: "“And international observers are..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Manus Sazon**: ""We're aware of the scrutiny, an..."<br>`[250]` **Daria de Rava**: ""We're keenly aware of the scrut..."<br>*(oraz 1 innych odgałęzień)* |
| `[24]` | **""It all sounds perfect on paper, but we both know things rarely go as planned.""** | `[16]` **Manus Sazon**: "“And international observers are..."<br>`[100]` **Daria de Rava**: "“And international observers are..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Manus Sazon**: ""That’s why we've built in mecha..."<br>`[258]` **Daria de Rava**: ""That’s why we've established me..."<br>*(oraz 1 innych odgałęzień)* |
| `[121]` | **""How are things looking in Pales?""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == false  and  (Variable["RiziaDLC.Pales_Rizia_Unification"] == true  or  Variable["RiziaDLC.War_Happened"] == true)` | `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] = ...`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[723]` **Narrator**: "I was just fastening the last bu..." |
| `[126]` | **""How’s the situation progressing in Zille?""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == false  and  Variable["RiziaDLC.ZilleReturn_Success"] == true` | `Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] = ...`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[723]` **Narrator**: "I was just fastening the last bu..." |
| `[132]` | **""What progress has been made with the House of Lords?""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`<br>`Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or 
Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)` | `Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] = t...`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[723]` **Narrator**: "I was just fastening the last bu..." |
| `[133]` | **""What progress has been made with the Regional Senate?""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`<br>`Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or 
Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)` | `Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] = t...`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[723]` **Narrator**: "I was just fastening the last bu..." |
| `[182]` | **""I hope I haven't kept you waiting too long.""** | `[393]` **Daria de Rava**: ""Ah! You're here.""<br>`[394]` **Manus Sazon**: ""Your Majesty! Good to see you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Manus Sazon**: ""My time is yours.""<br>`[186]` **Daria de Rava**: ""Not at all."" |
| `[187]` | **""Always a pleasure to see you, Adarfo.""** | `[398]` **Narrator**: "I could sense contempt lurking b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""Of course.""<br>`[382]` **Daria de Rava**: ""Yes, of course.""<br>*(oraz 1 innych odgałęzień)* |
| `[188]` | **""Some of us prefer to leave the mundane tasks to the professionals.""** | `[398]` **Narrator**: "I could sense contempt lurking b..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[192]` **Narrator**: "He removed his palm from the doo..." |
| `[193]` | **""I’ve got more important matters to attend to than opening doors. You might try fo..."** | `[398]` **Narrator**: "I could sense contempt lurking b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "His expression went cold." |
| `[196]` | **""A lot of color, a lot of slogans... I just hope there’s substance behind all the ..."** | `[418]` **Narrator**: "The words “Every Vote Matters” e..."<br>`[420]` **Narrator**: "The words “For a Future We Can T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Manus Sazon**: ""That’s always the risk. But I b..."<br>`[677]` **Daria de Rava**: ""A fair concern. But I believe t..."<br>*(oraz 1 innych odgałęzień)* |
| `[231]` | **""I appreciate the update. Now, let's get to where we're going.""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == true` | `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Manus...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Daria...`<br>*(+1 skryptów)* | `[813]` **Narrator**: "The motorcade soon pulled up to ..."<br>`[232]` **Narrator**: "The motorcade soon pulled up to ..." |
| `[243]` | **""That's an endorsement in all but name. My answer is no.""** | `[581]` **Daria de Rava**: ""If you could mention this in yo..."<br>`[583]` **Daria de Rava**: ""That stability doesn't come wit..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endor...` | `[541]` **Manus Sazon**: ""Very well. Just thought I'd ask.""<br>`[544]` **Daria de Rava**: ""Fair enough. I won’t press the ..." |
| `[290]` | **""Tell them I'll be right down.""** | `[295]` **Narrator**: "A chance for a quiet conversatio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Narrator**: "Sebastian nodded and left the room."<br>`[309]` **Pabel Adria**: ""Right away."" |
| `[291]` | **""Great. How do I look?""** | `[295]` **Narrator**: "A chance for a quiet conversatio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Narrator**: "I stood tall, my suit sharp and ..." |
| `[292]` | **""I'm not coming. Tell the Prime Minister I have to wash my hair.""** | `[295]` **Narrator**: "A chance for a quiet conversatio..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[299]` **Narrator**: "Sebastian looked stunned. He sti..."<br>`[303]` **Narrator**: "Pabel laughed politely, well acc..." |
| `[293]` | **""I'll be there when I see fit.""** | `[295]` **Narrator**: "A chance for a quiet conversatio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Narrator**: "Sebastian gave a nod and left th..."<br>`[315]` **Pabel Adria**: ""Yes, Your Majesty. Right away."" |
| `[357]` | **""It’s hard to keep up with all the demands. But here I am.""** | `[355]` **Daria de Rava**: ""Ah! You're here. You know, for ..."<br>`[356]` **Manus Sazon**: ""Good to see you, Your Majesty. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""Of course.""<br>`[382]` **Daria de Rava**: ""Yes, of course.""<br>*(oraz 1 innych odgałęzień)* |
| `[358]` | **""I come and go as I see fit.""** | `[354]` **Narrator**: "I could sense contempt lurking b..."<br>`[355]` **Daria de Rava**: ""Ah! You're here. You know, for ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""Of course.""<br>`[382]` **Daria de Rava**: ""Yes, of course.""<br>*(oraz 1 innych odgałęzień)* |
| `[359]` | **""I wouldn't dare. You know how I am about appearances.""** | `[355]` **Daria de Rava**: ""Ah! You're here. You know, for ..."<br>`[356]` **Manus Sazon**: ""Good to see you, Your Majesty. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""Of course.""<br>`[382]` **Daria de Rava**: ""Yes, of course.""<br>*(oraz 1 innych odgałęzień)* |
| `[360]` | **""I wouldn't miss this. At last, my legacy as a reformer preserved for all to see.""** | `[354]` **Narrator**: "I could sense contempt lurking b..."<br>`[355]` **Daria de Rava**: ""Ah! You're here. You know, for ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""Of course.""<br>`[382]` **Daria de Rava**: ""Yes, of course.""<br>*(oraz 1 innych odgałęzień)* |
| `[361]` | **""Waiting is good for the soul, don’t you think?""** | `[354]` **Narrator**: "I could sense contempt lurking b..."<br>`[355]` **Daria de Rava**: ""Ah! You're here. You know, for ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[373]` **Manus Sazon**: ""It does give one time to think,..."<br>`[372]` **Daria de Rava**: ""I suppose it gives time for ref..."<br>*(oraz 1 innych odgałęzień)* |
| `[374]` | **""I’d say you’re lucky I showed up at all.""** | `[354]` **Narrator**: "I could sense contempt lurking b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Manus Sazon**: ""Of course.""<br>`[382]` **Daria de Rava**: ""Yes, of course.""<br>*(oraz 1 innych odgałęzień)* |
| `[395]` | **""Likewise.""** | `[394]` **Manus Sazon**: ""Your Majesty! Good to see you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Narrator**: "An attendant opened the nearest ..." |
| `[397]` | **""Always a pleasure to see you, Daria.""** | `[393]` **Daria de Rava**: ""Ah! You're here."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Narrator**: "An attendant opened the nearest ..." |
| `[399]` | **""I'm glad you remembered your manners.""** | `[401]` **Narrator**: "I slid into the backseat, with M..."<br>`[402]` **Narrator**: "I slid into the backseat, with D..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[704]` **Manus Sazon**: ""The King of Rizia is to be resp..."<br>`[708]` **Daria de Rava**: ""I would never disrespect the Ki..." |
| `[400]` | **""This feels right. The King and Prime Minister, steering the country together.""** | `[401]` **Narrator**: "I slid into the backseat, with M..."<br>`[402]` **Narrator**: "I slid into the backseat, with D..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[712]` **Manus Sazon**: ""It's our people who determine t..."<br>`[713]` **Daria de Rava**: ""I'm grateful to be allowed behi..." |
| `[404]` | **""Forgive my rudeness, Mr. Prime Minister. I still haven't gotten used to the new o..."** | `[403]` **Narrator**: "I got in and took the seat besid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Adarfo Sotelato**: ""I understand. You'll adjust to ..." |
| `[405]` | **""This feels right. The King and Prime Minister, steering the country together.""** | `[403]` **Narrator**: "I got in and took the seat besid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Adarfo Sotelato**: ""I'm behind the wheel, Toras. Yo..." |
| `[410]` | **"“How wonderfully humble. A banner with your face larger than the city itself.”"** | `[418]` **Narrator**: "The words “Every Vote Matters” e..."<br>`[420]` **Narrator**: "The words “For a Future We Can T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "Manus chuckled."<br>`[665]` **Narrator**: "Daria's expression stiffens for ..."<br>*(oraz 1 innych odgałęzień)* |
| `[422]` | **""How are the election preparations shaping up?""** | `[418]` **Narrator**: "The words “Every Vote Matters” e..."<br>`[420]` **Narrator**: "The words “For a Future We Can T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[678]` **Narrator**: "Through the glass, I saw volunte..." |
| `[424]` | **""Wait... I get a vote too, right?""** | `[418]` **Narrator**: "The words “Every Vote Matters” e..."<br>`[420]` **Narrator**: "The words “For a Future We Can T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[438]` **Manus Sazon**: ""Of course. Everyone gets a voic..."<br>`[673]` **Daria de Rava**: ""Yes, Your Majesty. Everyone get..."<br>*(oraz 1 innych odgałęzień)* |
| `[445]` | **""It's just a piece of paper, in the end.""** | `[444]` **Manus Sazon**: ""Oh, and the protective glass is..."<br>`[532]` **Daria de Rava**: ""Rizia's future is in that case...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[451]` **Narrator**: "I looked it over a moment longer..." |
| `[449]` | **""Okay, we saw it. Let's be on our way.""** | `[444]` **Manus Sazon**: ""Oh, and the protective glass is..."<br>`[532]` **Daria de Rava**: ""Rizia's future is in that case...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Narrator**: "I turned and headed back toward ..." |
| `[450]` | **""It's something, isn't it? Proof that we can start again.""** | `[444]` **Manus Sazon**: ""Oh, and the protective glass is..."<br>`[532]` **Daria de Rava**: ""Rizia's future is in that case...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[451]` **Narrator**: "I looked it over a moment longer..." |
| `[452]` | **""May God guide those who carry out its words.""** | `[444]` **Manus Sazon**: ""Oh, and the protective glass is..."<br>`[532]` **Daria de Rava**: ""Rizia's future is in that case...."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[451]` **Narrator**: "I looked it over a moment longer..." |
| `[453]` | **""If you'd told me that sooner, I'd have ordered it for every window in the palace.""** | `[444]` **Manus Sazon**: ""Oh, and the protective glass is..."<br>`[532]` **Daria de Rava**: ""Rizia's future is in that case...."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[451]` **Narrator**: "I looked it over a moment longer..." |
| `[459]` | **""If you want a good word from me about the elections, you can forget it.""** | `[468]` **Manus Sazon**: ""Before you go, there is one mor..."<br>`[469]` **Daria de Rava**: ""Before you go, there is one mor..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[775]` **Adarfo Sotelato**: ""Ha. No, nothing of the sort.""<br>`[541]` **Manus Sazon**: ""Very well. Just thought I'd ask.""<br>*(oraz 1 innych odgałęzień)* |
| `[477]` | **""What is it?""** | `[468]` **Manus Sazon**: ""Before you go, there is one mor..."<br>`[469]` **Daria de Rava**: ""Before you go, there is one mor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Narrator**: "Manus stepped toward me."<br>`[458]` **Narrator**: "Daria stepped toward me."<br>*(oraz 1 innych odgałęzień)* |
| `[478]` | **""No. Good day.""** | `[468]` **Manus Sazon**: ""Before you go, there is one mor..."<br>`[469]` **Daria de Rava**: ""Before you go, there is one mor..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[460]` **Narrator**: "I didn't turn back as I made my ..." |
| `[479]` | **"Wave at the crowd."** | `[441]` **Narrator**: "Manus and I stepped out of the c..."<br>`[442]` **Narrator**: "Daria and I stepped out of the c..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Narrator**: ""Your Majesty! Prime Minister! A..." |
| `[480]` | **"Continue onward."** | `[441]` **Narrator**: "Manus and I stepped out of the c..."<br>`[442]` **Narrator**: "Daria and I stepped out of the c..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[481]` **Narrator**: ""Your Majesty! Prime Minister! A..." |
| `[486]` | **"Pose with the prime minister for a photo."** | `[481]` **Narrator**: ""Your Majesty! Prime Minister! A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[485]` **Narrator**: "Manus and I briefly came togethe..."<br>`[488]` **Narrator**: "Daria and I briefly came togethe..."<br>*(oraz 1 innych odgałęzień)* |
| `[487]` | **"Don't pose for a photo and continue onward."** | `[481]` **Narrator**: ""Your Majesty! Prime Minister! A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[517]` **Narrator**: "We passed through the foyer and ..." |
| `[493]` | **""People love a good picture. I suppose this is what democracy looks like.""** | `[485]` **Narrator**: "Manus and I briefly came togethe..."<br>`[488]` **Narrator**: "Daria and I briefly came togethe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Manus Sazon**: ""I think there's more to it than..."<br>`[521]` **Daria de Rava**: ""I'd say democracy is a bit more..."<br>*(oraz 1 innych odgałęzień)* |
| `[494]` | **""I suppose we should smile for the cameras.""** | `[485]` **Narrator**: "Manus and I briefly came togethe..."<br>`[488]` **Narrator**: "Daria and I briefly came togethe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Manus Sazon**: ""Absolutely.""<br>`[497]` **Daria de Rava**: ""Naturally.""<br>*(oraz 1 innych odgałęzień)* |
| `[495]` | **""These moments... They’ll be all we have to remember when the dust settles.""** | `[485]` **Narrator**: "Manus and I briefly came togethe..."<br>`[488]` **Narrator**: "Daria and I briefly came togethe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Manus Sazon**: "“And what a picture it will make.""<br>`[525]` **Daria de Rava**: ""I hope it’s not just the pictur..."<br>*(oraz 1 innych odgałęzień)* |
| `[556]` | **""No matter what happens, no one can rewrite what I have done.""** | `[555]` **Narrator**: "I caught sight of the display ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Narrator**: "I looked around the chamber once..." |
| `[558]` | **""They call this progress, yet they stand on the foundation I built.""** | `[555]` **Narrator**: "I caught sight of the display ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Narrator**: "I looked around the chamber once..." |
| `[559]` | **""Perhaps this will lead Rizia to something greater. Perhaps my rule was the bridge..."** | `[555]` **Narrator**: "I caught sight of the display ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Narrator**: "I looked around the chamber once..." |
| `[560]` | **""My time is ending, but Rizia will endure. It must.""** | `[555]` **Narrator**: "I caught sight of the display ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Narrator**: "I looked around the chamber once..." |
| `[565]` | **""I’ll gladly lend my support to your cause.""** | `[237]` **Manus Sazon**: ""If you were to talk about those..."<br>`[239]` **Manus Sazon**: ""If you could mention that in yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] = true;...` | `[540]` **Manus Sazon**: ""You will?! That's great! You ha..." |
| `[567]` | **""I can’t back this message. There are more important issues right now.""** | `[237]` **Manus Sazon**: ""If you were to talk about those..."<br>`[239]` **Manus Sazon**: ""If you could mention that in yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[539]` **Manus Sazon**: ""I understand your position, You..." |
| `[569]` | **""If mentioning your plans will bring hope to the people, I’ll talk about them. Tho..."** | `[237]` **Manus Sazon**: ""If you were to talk about those..."<br>`[239]` **Manus Sazon**: ""If you could mention that in yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] = true;...` | `[538]` **Manus Sazon**: ""Thank you, Your Majesty. Your s..." |
| `[574]` | **""I’ll mention it. Security is vital, and if my words can help, I’ll gladly support..."** | `[581]` **Daria de Rava**: ""If you could mention this in yo..."<br>`[583]` **Daria de Rava**: ""That stability doesn't come wit..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] = true;...` | `[542]` **Daria de Rava**: ""You will?! That’s wonderful! I’..." |
| `[575]` | **""The policy is sound, but I can’t endorse your campaign directly. However, I’ll me..."** | `[581]` **Daria de Rava**: ""If you could mention this in yo..."<br>`[583]` **Daria de Rava**: ""That stability doesn't come wit..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] = true;...` | `[542]` **Daria de Rava**: ""You will?! That’s wonderful! I’..." |
| `[576]` | **""I can’t back this message. There are more important issues right now.""** | `[581]` **Daria de Rava**: ""If you could mention this in yo..."<br>`[583]` **Daria de Rava**: ""That stability doesn't come wit..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[543]` **Daria de Rava**: ""Well, I appreciate your time re..." |
| `[577]` | **""I see the value in your message, and I’ll openly support you. Stability and secur..."** | `[581]` **Daria de Rava**: ""If you could mention this in yo..."<br>`[583]` **Daria de Rava**: ""That stability doesn't come wit..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] = true; Var...` | `[542]` **Daria de Rava**: ""You will?! That’s wonderful! I’..." |
| `[578]` | **""I won't just mention it. I will openly endorse you as a candidate.""** | `[237]` **Manus Sazon**: ""If you were to talk about those..."<br>`[239]` **Manus Sazon**: ""If you could mention that in yo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] = true; Var...` | `[540]` **Manus Sazon**: ""You will?! That's great! You ha..." |
| `[593]` | **"“You mean... everyone more likely to vote for you.”"** | `[7]` **Manus Sazon**: "“The challenge, of course, is en..."<br>`[94]` **Daria de Rava**: "“The main challenge, naturally, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[594]` **Manus Sazon**: "“I mean everyone, Your Majesty. ..."<br>`[623]` **Daria de Rava**: "“I mean everyone, Your Majesty. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[595]` | **""I suppose some still need convincing that their vote actually matters.""** | `[7]` **Manus Sazon**: "“The challenge, of course, is en..."<br>`[94]` **Daria de Rava**: "“The main challenge, naturally, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[632]` **Manus Sazon**: ""A valid concern, but one we are..."<br>`[643]` **Daria de Rava**: ""It’s a valid concern, but we ar..."<br>*(oraz 1 innych odgałęzień)* |
| `[596]` | **""This is all happening so fast.""** | `[7]` **Manus Sazon**: "“The challenge, of course, is en..."<br>`[94]` **Daria de Rava**: "“The main challenge, naturally, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[629]` **Manus Sazon**: ""Fast, yes -- but that doesn't m..."<br>`[630]` **Daria de Rava**: ""Fast, yes -- but not careless o..."<br>*(oraz 1 innych odgałęzień)* |
| `[597]` | **""It sounds like things are moving in the right direction.""** | `[7]` **Manus Sazon**: "“The challenge, of course, is en..."<br>`[94]` **Daria de Rava**: "“The main challenge, naturally, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[659]` **Manus Sazon**: ""Absolutely.""<br>`[645]` **Daria de Rava**: "“Certainly.""<br>*(oraz 1 innych odgałęzień)* |
| `[625]` | **""Maybe we should put the ballot boxes in pubs -- that would get their attention.""** | `[7]` **Manus Sazon**: "“The challenge, of course, is en..."<br>`[94]` **Daria de Rava**: "“The main challenge, naturally, ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[634]` **Manus Sazon**: "“As entertaining as that would b..."<br>`[633]` **Daria de Rava**: ""While that may get attention, i..."<br>*(oraz 1 innych odgałęzień)* |
| `[660]` | **""What does the data say about voters' top issues?""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == false` | `Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"]...`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[723]` **Narrator**: "I was just fastening the last bu..." |
| `[681]` | **""No time for small talk. The hall of the people is waiting.""** | `[273]` **Narrator**: "Soon after, my motorcade turned ..." | `(Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Manus...`<br>`Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Daria...`<br>*(+1 skryptów)* | `[813]` **Narrator**: "The motorcade soon pulled up to ..."<br>`[232]` **Narrator**: "The motorcade soon pulled up to ..." |
| `[682]` | **""It would behoove you to remember that you are only Prime Minister because of my s..."** | `[403]` **Narrator**: "I got in and took the seat besid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[684]` **Adarfo Sotelato**: ""I do thank you for keeping the ..." |
| `[689]` | **""How is Vina? She won't say a word to me.""** | `[401]` **Narrator**: "I slid into the backseat, with M..." | `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`<br>`Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[690]` **Narrator**: "Manus gave me a thin-lipped smile." |
| `[695]` | **""About Vina's inheritance. I hope you know it's nothing personal.""** | `[401]` **Narrator**: "I slid into the backseat, with M..." | `Variable["RiziaDLC.Successor_Son"] == true`<br>`(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`<br>`Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[696]` **Narrator**: "Manus gave me a thin-lipped smile." |
| `[701]` | **""How is Vina?""** | `[401]` **Narrator**: "I slid into the backseat, with M..." | `(Variable["RiziaDLC.Successor_Son"] == true) == false`<br>`(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`<br>`Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[702]` **Narrator**: "Manus gave me a patient smile." |
| `[714]` | **""This feels odd. I'm not used to sharing a car.""** | `[401]` **Narrator**: "I slid into the backseat, with M..."<br>`[402]` **Narrator**: "I slid into the backseat, with D..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[718]` **Manus Sazon**: ""Odd or not, this is the new ord..."<br>`[719]` **Daria de Rava**: ""I never dreamed I'd ride side b..." |
| `[720]` | **"Don't remark on it."** | `[418]` **Narrator**: "The words “Every Vote Matters” e..."<br>`[420]` **Narrator**: "The words “For a Future We Can T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Narrator**: "As we drove through the streets,..." |
| `[724]` | **""Nothing says ‘progress’ like swapping a sign.""** | `[211]` **Narrator**: "He was replacing the "King's Ave..."<br>`[767]` **Narrator**: "He was replacing the "King's Ave..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Manus followed my gaze and clear..."<br>`[95]` **Narrator**: "Daria followed my gaze and clear..."<br>*(oraz 1 innych odgałęzień)* |
| `[725]` | **""Even the streets must bear witness to the new order.""** | `[211]` **Narrator**: "He was replacing the "King's Ave..."<br>`[767]` **Narrator**: "He was replacing the "King's Ave..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Manus followed my gaze and clear..."<br>`[95]` **Narrator**: "Daria followed my gaze and clear..."<br>*(oraz 1 innych odgałęzień)* |
| `[726]` | **""Good. Let the city reflect its new reality.""** | `[211]` **Narrator**: "He was replacing the "King's Ave..."<br>`[767]` **Narrator**: "He was replacing the "King's Ave..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Manus followed my gaze and clear..."<br>`[95]` **Narrator**: "Daria followed my gaze and clear..."<br>*(oraz 1 innych odgałęzień)* |
| `[727]` | **""Huh. You couldn't come up with anything better?""** | `[211]` **Narrator**: "He was replacing the "King's Ave..."<br>`[767]` **Narrator**: "He was replacing the "King's Ave..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Manus followed my gaze and clear..."<br>`[95]` **Narrator**: "Daria followed my gaze and clear..."<br>*(oraz 1 innych odgałęzień)* |
| `[730]` | **""Yes?""** | `[729]` **Adarfo Sotelato**: ""One more thing..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Narrator**: "Manus stepped toward me."<br>`[458]` **Narrator**: "Daria stepped toward me."<br>*(oraz 1 innych odgałęzień)* |
| `[770]` | **""May Rizia's next prime minister have the integrity to carry out its words.""** | `[444]` **Manus Sazon**: ""Oh, and the protective glass is..."<br>`[532]` **Daria de Rava**: ""Rizia's future is in that case...."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[451]` **Narrator**: "I looked it over a moment longer..." |
| `[785]` | **""You say that like it's a good thing. Truth be told, the constant pressure to live..."** | `[779]` **Adarfo Sotelato**: ""To your credit, you've done a l..."<br>`[783]` **Adarfo Sotelato**: ""It doesn't matter that you've t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[793]` **Adarfo Sotelato**: ""Nobody's forcing you to stay on..." |
| `[786]` | **""And you want them to worship you instead?""** | `[779]` **Adarfo Sotelato**: ""To your credit, you've done a l..."<br>`[783]` **Adarfo Sotelato**: ""It doesn't matter that you've t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[792]` **Adarfo Sotelato**: ""No. I want us to work together."" |
| `[787]` | **""Well, I am a superior specimen of a human being.""** | `[779]` **Adarfo Sotelato**: ""To your credit, you've done a l..."<br>`[783]` **Adarfo Sotelato**: ""It doesn't matter that you've t..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[796]` **Narrator**: "He rolled his eyes." |
| `[791]` | **""I know it's not fair. But Rizia can't shake off a thousand years of royal traditi..."** | `[779]` **Adarfo Sotelato**: ""To your credit, you've done a l..."<br>`[783]` **Adarfo Sotelato**: ""It doesn't matter that you've t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[771]` **Adarfo Sotelato**: ""I get it. And I'm looking forwa..." |
| `[795]` | **""Work on your attitude first.""** | `[771]` **Adarfo Sotelato**: ""I get it. And I'm looking forwa..."<br>`[792]` **Adarfo Sotelato**: ""No. I want us to work together.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[805]` **Narrator**: "With a short, rueful laugh, he m..." |
| `[798]` | **""Good luck with your campaign.""** | `[771]` **Adarfo Sotelato**: ""I get it. And I'm looking forwa..."<br>`[792]` **Adarfo Sotelato**: ""No. I want us to work together.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[806]` **Narrator**: "He nodded in acknowledgement bef..." |
| `[799]` | **""Likewise, Mr. Prime Minister. You have my endorsement.""** | `[771]` **Adarfo Sotelato**: ""I get it. And I'm looking forwa..."<br>`[794]` **Adarfo Sotelato**: ""But if you do stick around, I'm..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] = true; Var...` | `[736]` **Narrator**: "He lowered his head in acknowled..." |
| `[803]` | **""You signed a major treaty without my approval. You can fuck right off.""** | `[771]` **Adarfo Sotelato**: ""I get it. And I'm looking forwa..."<br>`[792]` **Adarfo Sotelato**: ""No. I want us to work together.""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true` | *Brak zmian stanu* | `[804]` **Narrator**: "Anger flashed in his eyes. Witho..." |

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
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Manus Sazon**
> "“As you can see, voter registration is progressing well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Manus Sazon: ""With steady employment, improved wages, and greater acce..."*)

### Węzeł `[4]`
Mówca: **Manus Sazon**
> "“And we've deployed additional teams to ensure every eligible citizen has the opportunity to register.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[5]`
Mówca: **Manus Sazon**
> "“There’s also been a tremendous effort put into our voter education campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: "“Pamphlets, radio broadcasts, even town hall meetings -- ..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> "“Pamphlets, radio broadcasts, even town hall meetings -- everything we can do to make sure people understand their rights and responsibilities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: "“The challenge, of course, is ensuring the message reache..."*)

### Węzeł `[7]`
Mówca: **Manus Sazon**
> "“The challenge, of course, is ensuring the message reaches everyone, particularly those unaccustomed to voting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Manus followed my gaze and cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Manus Sazon: ""Yes, even the small details are changing. New street nam..."*)

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""We've finalized all thirty-seven electoral districts as of yesterday, and the ballots have been refined for simplicity, leaving no room for ambiguities or misinterpretation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""Both parties had their concerns, but the RNC is largely ..."*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Both parties had their concerns, but the RNC is largely cooperating with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“That could change the moment results don’t go their way.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Manus Sazon), `[97]` (Daria de Rava), `[111]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[12]`
Mówca: **Manus Sazon**
> "“Hence the safeguards we've put in place. The system will withstand pressure, no matter the outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: "“Any attempts at disruption will be dealt with swiftly. T..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I've heard enough about the election process. I trust you to see this through the right way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Manus Sazon), `[97]` (Daria de Rava), `[111]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Thank you for your confidence in me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "Jump to: [Skip Election Talk]"*)

### Węzeł `[15]`
Mówca: **Manus Sazon**
> "“Any attempts at disruption will be dealt with swiftly. The integrity of this election will not be compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: "“And international observers are on board, whose presence..."*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> "“And international observers are on board, whose presence should reinforce public confidence in the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“No one can claim the election was being conducted in secrecy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Manus Sazon), `[100]` (Daria de Rava), `[114]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> "“My thoughts exactly. Regular updates will be published to maintain transparency, and any irregularities will be addressed openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: "“Once voting concludes, results will be quickly processed..."*)

### Węzeł `[19]`
Mówca: **Manus Sazon**
> "“Once voting concludes, results will be quickly processed. We expect to announce them without unnecessary delay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Manus Sazon: ""And if disputes arise, we have legal avenues in place to..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They better -- any obstruction will not be tolerated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Manus Sazon), `[97]` (Daria de Rava), `[111]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about mudslinging? Are we seeing much of that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Manus Sazon), `[97]` (Daria de Rava), `[111]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sometimes wonder how the average citizen can keep up with the complexity of the politics we've put in place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Manus Sazon), `[100]` (Daria de Rava), `[114]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good, good. We can't afford any lapses, especially not with the eyes of the world watching.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Manus Sazon), `[100]` (Daria de Rava), `[114]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It all sounds perfect on paper, but we both know things rarely go as planned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Manus Sazon), `[100]` (Daria de Rava), `[114]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[25]`
Mówca: **Manus Sazon**
> ""And if disputes arise, we have legal avenues in place to handle them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "As we drove through the streets, I caught sight of a newl..."*)

### Węzeł `[26]`
Mówca: **Manus Sazon**
> ""With steady employment, improved wages, and greater access to resources, people are engaging eagerly in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Manus Sazon: ""Participation is strong in the cities, though some of th..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Manus Sazon: "“As you can see, voter registration is progressing well.""*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Daria de Rava: "“As you can see, voter registration is moving forward acc..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Adarfo Sotelato: ""You can see for yourself that voter registration is proc..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Manus followed my gaze and cleared his throat."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Daria followed my gaze and cleared her throat."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Adarfo followed my gaze and cleared his throat."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""What about mudslinging? Are we seeing much of that?""*)
  - -> `[11]` (*Player_Romus: "“That could change the moment results don’t go their way.”"*)
  - -> `[20]` (*Player_Romus: ""They better -- any obstruction will not be tolerated.""*)
  - -> `[13]` (*Player_Romus: "“I've heard enough about the election process. I trust yo..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Good, good. We can't afford any lapses, especially not w..."*)
  - -> `[22]` (*Player_Romus: ""I sometimes wonder how the average citizen can keep up w..."*)
  - -> `[17]` (*Player_Romus: "“No one can claim the election was being conducted in sec..."*)
  - -> `[24]` (*Player_Romus: ""It all sounds perfect on paper, but we both know things ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Manus Sazon: "“Hence the safeguards we've put in place. The system will..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Daria de Rava: "“Hence the safeguards we've implemented. The system is bu..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Adarfo Sotelato: ""That’s why we've built in safeguards. This system is res..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Manus Sazon: ""Naturally, but those decisions are in the people's hands..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Daria de Rava: ""Of course, but those decisions are in the people's hands..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Adarfo Sotelato: ""That’s not for you to decide. It's in the people's hands..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Manus Sazon: ""Thank you for your confidence in me, Your Majesty.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Daria de Rava: ""The RNC will not let you down, Your Majesty.""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Adarfo Sotelato: ""Good. I hope your remaining loyalists feel the same way.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Manus Sazon: ""In Iza, the mud’s still flying, but it doesn't reflect t..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Daria de Rava: ""In Iza, the mud’s still flying, but that’s hardly repres..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Adarfo Sotelato: ""In Iza, the mud’s still flying -- proof that some still ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: "“My thoughts exactly. Regular updates will be published t..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Daria de Rava: "“Regular updates will be provided to maintain transparenc..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Adarfo Sotelato: ""Regular updates will be shared to maintain transparency,..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Manus Sazon: ""That’s why we've built in mechanisms to handle any issue..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Daria de Rava: ""That’s why we've established mechanisms to address any i..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Adarfo Sotelato: ""That’s why we've established mechanisms to address such ..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Manus Sazon: ""It’s certainly a lot to manage, but we've made strides i..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Daria de Rava: ""It’s certainly a lot to manage, but we've made significa..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Adarfo Sotelato: ""Your position of privilege is blinding you to the capabi..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Manus Sazon: ""We're aware of the scrutiny, and that's why we’re ensuri..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Daria de Rava: ""We're keenly aware of the scrutiny, and that's why we’re..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Adarfo Sotelato: ""You think I don't know that? Every detail is being handl..."*)

### Węzeł `[89]`
Mówca: **Daria de Rava**
> "“As you can see, voter registration is moving forward accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Daria de Rava: ""With stable employment, rising wages, and improved acces..."*)

### Węzeł `[90]`
Mówca: **Daria de Rava**
> ""With stable employment, rising wages, and improved access to resources, people are engaging eagerly in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Daria de Rava: "“Cities are seeing strong participation, though some of t..."*)

### Węzeł `[91]`
Mówca: **Daria de Rava**
> "“And we've dispatched additional teams to make sure every eligible citizen has the chance to register.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[92]`
Mówca: **Daria de Rava**
> "“There’s also been a significant push in our voter education efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Daria de Rava: "“Pamphlets, radio broadcasts, town hall meetings -- every..."*)

### Węzeł `[93]`
Mówca: **Daria de Rava**
> "“Pamphlets, radio broadcasts, town hall meetings -- everything we can manage to ensure people understand their rights and responsibilities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Daria de Rava: "“The main challenge, naturally, is reaching everyone, esp..."*)

### Węzeł `[94]`
Mówca: **Daria de Rava**
> "“The main challenge, naturally, is reaching everyone, especially those unfamiliar with voting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Daria followed my gaze and cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Daria de Rava: ""As you can see, not everything is changing. The public n..."*)

### Węzeł `[96]`
Mówca: **Daria de Rava**
> ""All thirty-seven electoral districts were finalized as of yesterday, and the ballots have been refined for simplicity, leaving no room for ambiguities or misinterpretation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Daria de Rava: ""While both parties have their concerns, the RPP is large..."*)

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""While both parties have their concerns, the RPP is largely cooperating with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[98]`
Mówca: **Daria de Rava**
> "“Hence the safeguards we've implemented. The system is built to withstand pressure, regardless of the outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Daria de Rava: "“Rest assured, any attempts at disruption will be handled..."*)

### Węzeł `[99]`
Mówca: **Daria de Rava**
> "“Rest assured, any attempts at disruption will be handled swiftly. The integrity of this election will not be compromised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Daria de Rava: "“And international observers are involved, adding an extr..."*)

### Węzeł `[100]`
Mówca: **Daria de Rava**
> "“And international observers are involved, adding an extra layer of confidence in the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[101]`
Mówca: **Daria de Rava**
> "“Regular updates will be provided to maintain transparency, and any irregularities will be addressed openly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Daria de Rava: "“Once voting concludes, results will be processed quickly..."*)

### Węzeł `[102]`
Mówca: **Daria de Rava**
> "“Once voting concludes, results will be processed quickly. We aim to announce them without delay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Daria de Rava: "“And if disputes arise, we have legal channels to handle ..."*)

### Węzeł `[103]`
Mówca: **Daria de Rava**
> "“And if disputes arise, we have legal channels to handle them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "As we drove through the streets, I caught sight of a newl..."*)

### Węzeł `[104]`
Mówca: **Adarfo Sotelato**
> ""You can see for yourself that voter registration is proceeding well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Adarfo Sotelato: ""With stable jobs, better wages, and expanded access to r..."*)

### Węzeł `[105]`
Mówca: **Adarfo Sotelato**
> ""And we've sent out more teams to ensure every eligible citizen gets a chance to register.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[106]`
Mówca: **Adarfo Sotelato**
> "“We've also made a significant push in our voter education efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Adarfo Sotelato: ""Pamphlets, radio broadcasts, town halls -- whatever we c..."*)

### Węzeł `[107]`
Mówca: **Adarfo Sotelato**
> ""Pamphlets, radio broadcasts, town halls -- whatever we can do to make sure people understand what’s at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Adarfo Sotelato: ""The main challenge is making sure the message reaches ev..."*)

### Węzeł `[108]`
Mówca: **Adarfo Sotelato**
> ""The main challenge is making sure the message reaches everyone, especially those who've never voted before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Adarfo followed my gaze and cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Adarfo Sotelato: ""Yes, even the small details are subject to change. New s..."*)

### Węzeł `[110]`
Mówca: **Adarfo Sotelato**
> ""All thirty-seven electoral districts were finalized yesterday, and the ballots have been simplified to ensure there’s no room for ambiguity or misinterpretation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Adarfo Sotelato: ""While both parties have their concerns, we've managed to..."*)

### Węzeł `[111]`
Mówca: **Adarfo Sotelato**
> ""While both parties have their concerns, we've managed to keep the RNC satisfied enough that they're largely cooperating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[112]`
Mówca: **Adarfo Sotelato**
> ""That’s why we've built in safeguards. This system is resilient enough to handle the pressure, no matter what happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Adarfo Sotelato: ""If anyone tries to disrupt things, it’ll be swiftly deal..."*)

### Węzeł `[113]`
Mówca: **Adarfo Sotelato**
> ""If anyone tries to disrupt things, it’ll be swiftly dealt with. We won’t let anyone compromise the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Adarfo Sotelato: ""International observers are involved, which should stren..."*)

### Węzeł `[114]`
Mówca: **Adarfo Sotelato**
> ""International observers are involved, which should strengthen public confidence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[115]`
Mówca: **Adarfo Sotelato**
> ""Regular updates will be shared to maintain transparency, and any irregularities will be addressed openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Adarfo Sotelato: ""Once the voting ends, results will be processed quickly...."*)

### Węzeł `[116]`
Mówca: **Adarfo Sotelato**
> ""Once the voting ends, results will be processed quickly. We plan to announce them without any unnecessary delay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Adarfo Sotelato: ""And if disputes come up, we have legal channels ready to..."*)

### Węzeł `[117]`
Mówca: **Adarfo Sotelato**
> ""And if disputes come up, we have legal channels ready to handle them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "As we drove through the streets, I caught sight of a newl..."*)

### Węzeł `[118]`
Mówca: **Adarfo Sotelato**
> ""With stable jobs, better wages, and expanded access to resources, people are showing strong interest in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Adarfo Sotelato: ""Cities are seeing strong participation, however, the mor..."*)

### Węzeł `[119]`
Mówca: **Daria de Rava**
> ""The RNC will not let you down, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "Jump to: [Skip Election Talk]"*)

### Węzeł `[120]`
Mówca: **Adarfo Sotelato**
> ""Good. I hope your remaining loyalists feel the same way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "Jump to: [Skip Election Talk]"*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are things looking in Pales?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == false  and  (Variable["RiziaDLC.Pales_Rizia_Unification"] == true  or  Variable["RiziaDLC.War_Happened"] == true)`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_PalesUpdate = true;"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_PalesUpdate == false && (RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_Happened == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_PalesUpdate == false && (R..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Reform_PalesUpdate == false && ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_PalesUpdate == false && (RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == false  and  (Variable["RiziaDLC.Pales_Rizia_Unification"] == true  or  Variable["RiziaDLC.War_Happened"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""How are things looking in Pales?""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Reform_PalesUpdate == false && (RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_Happened == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == false  and  (Variable["RiziaDLC.Pales_Rizia_Unification"] == true  or  Variable["RiziaDLC.War_Happened"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_PalesUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How’s the situation progressing in Zille?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == false  and  Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_ZilleUpdate = true;"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == false && RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == false && Ri..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == false && ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == false && RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == false  and  Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""How’s the situation progressing in Zille?""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == false && RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == false  and  Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_ZilleUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reform_Report_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_ElectionIssues == false"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_UpperHouse == false && (Ri..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_PalesUpdate == false && (R..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == false && Ri..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_PalesUpdate == true || Riz..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What progress has been made with the House of Lords?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true` AND `Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or 
Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_UpperHouse = true;"*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What progress has been made with the Regional Senate?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false` AND `Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or 
Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_UpperHouse = true;"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_UpperHouse == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true ||
RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_UpperHouse == false && (Ri..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Reform_UpperHouse == false && (..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_UpperHouse == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true ||
RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or 
Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Reform_UpperHouse == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true ||
RiziaDLC.Reform_Legislative_RegionalSenate == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or 
Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""What progress has been made with the House of Lords?""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""What progress has been made with the Regional Senate?""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_UpperHouse = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[141]`
Mówca: **Manus Sazon**
> ""In Iza, the mud’s still flying, but it doesn't reflect the general picture, which has remained quite civil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Manus Sazon: ""But should that mud turn to brick, we have security meas..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[148]`
Mówca: **Manus Sazon**
> ""As you can see, voter registration is progressing well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Manus Sazon: ""Life carries on as usual for most, and turnout has refle..."*)

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""Life carries on as usual for most, and turnout has reflected that -- solid participation in the cities, with some delay in the outlying regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Manus Sazon: ""We've deployed additional teams to ensure every eligible..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Manus Sazon: ""As you can see, voter registration is progressing well.""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[153]`
Mówca: **Daria de Rava**
> ""As you can see, voter registration is progressing steadily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Daria de Rava: ""Life continues as usual for most, and turnout reflects t..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Daria de Rava: ""As you can see, voter registration is progressing steadi..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Adarfo Sotelato: ""As you can see, we're turning out voters steadily.""*)

### Węzeł `[157]`
Mówca: **Daria de Rava**
> ""Life continues as usual for most, and turnout reflects that -- strong participation in the cities, with some delay in the rural areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""We've dispatched additional teams to make sure every eli..."*)

### Węzeł `[158]`
Mówca: **Adarfo Sotelato**
> ""As you can see, we're turning out voters steadily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Adarfo Sotelato: ""Life continues as normal for many, and turnout has mirro..."*)

### Węzeł `[159]`
Mówca: **Adarfo Sotelato**
> ""Life continues as normal for many, and turnout has mirrored that -- good participation in urban centers, though there’s been some lag in the more remote regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Adarfo Sotelato: ""While I wish there was more enthusiasm, I am nonetheless..."*)

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""Voter registration is progressing, though not without difficulty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Manus Sazon: ""The strain many households are facing, both rural and ur..."*)

### Węzeł `[161]`
Mówca: **Manus Sazon**
> ""The strain many households are facing, both rural and urban communities, has made participation more challenging than we’d hoped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Manus Sazon: ""Which is why we've sent out more teams to ensure every e..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Manus Sazon: ""Voter registration is progressing, though not without di..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[165]`
Mówca: **Daria de Rava**
> ""Voter registration is moving forward, Your Majesty, though we've encountered some challenges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Daria de Rava: ""The hardship endured by so many families, in both rural ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Daria de Rava: ""Voter registration is moving forward, Your Majesty, thou..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Adarfo Sotelato: ""Registration efforts are underway, Your Majesty, but it'..."*)

### Węzeł `[169]`
Mówca: **Daria de Rava**
> ""The hardship endured by so many families, in both rural and urban areas, has made it more difficult than ever to get people engaged in this process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Daria de Rava: ""Which is why we've dispatched additional teams to make s..."*)

### Węzeł `[170]`
Mówca: **Adarfo Sotelato**
> ""Registration efforts are underway, Your Majesty, but it's been anything but smooth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Adarfo Sotelato: ""The hardships many households are facing, both rural and..."*)

### Węzeł `[171]`
Mówca: **Adarfo Sotelato**
> ""The hardships many households are facing, both rural and urban communities, have made participation more difficult than anticipated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Adarfo Sotelato: ""Which is why we've sent out more teams to ensure every e..."*)

### Węzeł `[172]`
Mówca: **Manus Sazon**
> ""Participation is strong in the cities, though some of the more remote regions have been slower to respond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Manus Sazon: "“And we've deployed additional teams to ensure every elig..."*)

### Węzeł `[173]`
Mówca: **Daria de Rava**
> "“Cities are seeing strong participation, though some of the more remote areas are slower to respond.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Daria de Rava: "“And we've dispatched additional teams to make sure every..."*)

### Węzeł `[174]`
Mówca: **Adarfo Sotelato**
> ""Cities are seeing strong participation, however, the more remote areas have been slower to respond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Adarfo Sotelato: ""And we've sent out more teams to ensure every eligible c..."*)

### Węzeł `[175]`
Mówca: **Manus Sazon**
> ""Which is why we've sent out more teams to ensure every eligible citizen gets a chance to register.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[176]`
Mówca: **Daria de Rava**
> ""Which is why we've dispatched additional teams to make sure every eligible citizen has the chance to register.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[177]`
Mówca: **Adarfo Sotelato**
> ""Which is why we've sent out more teams to ensure every eligible citizen gets a chance to register.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[178]`
Mówca: **Adarfo Sotelato**
> ""While I wish there was more enthusiasm, I am nonetheless pleased with what we've seen so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Adarfo Sotelato: ""Either way, we've sent out more teams to ensure every el..."*)

### Węzeł `[179]`
Mówca: **Adarfo Sotelato**
> ""Either way, we've sent out more teams to ensure every eligible citizen gets a chance to register.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[180]`
Mówca: **Daria de Rava**
> ""We've dispatched additional teams to make sure every eligible citizen has the chance to register.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[181]`
Mówca: **Manus Sazon**
> ""We've deployed additional teams to ensure every eligible citizen has the opportunity to register.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Gazing out again, I saw people on the street passing out ..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I haven't kept you waiting too long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Daria de Rava), `[394]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Manus Sazon: ""My time is yours.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Daria de Rava: ""Not at all.""*)

### Węzeł `[186]`
Mówca: **Daria de Rava**
> ""Not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Always a pleasure to see you, Adarfo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Some of us prefer to leave the mundane tasks to the professionals.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[398]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "He removed his palm from the doorhandle, his expression c..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""Some of us prefer to leave the mundane tasks to the prof..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[192]`
Mówca: **Narrator**
> "He removed his palm from the doorhandle, his expression cold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ve got more important matters to attend to than opening doors. You might try focusing on the bigger picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "His expression went cold."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "His expression went cold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Gazing out again, I saw people on the street passing out pamphlets and wearing pins supporting their chosen candidates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A lot of color, a lot of slogans... I just hope there’s substance behind all the noise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Narrator), `[420]` (Narrator), `[423]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[197]`
Mówca: **Manus Sazon**
> ""What can I say? My face tested well with focus groups. Of course, I’d rather people remember the policies than the posters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "His expression turned serious as he gestured outside."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Manus Sazon: ""That’s always the risk. But I believe the people are pay..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Daria de Rava: ""A fair concern. But I believe the people see beyond the ..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Adarfo Sotelato: ""Well, we can’t all rely on a crown to do the talking.""*)

### Węzeł `[204]`
Mówca: **Narrator**
> "His expression turned serious as he gestured outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Narrator: "Through the glass, I saw volunteers at a registration boo..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Manus Sazon: "“There’s also been a tremendous effort put into our voter..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

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
  - -> `[92]` (*Daria de Rava: "“There’s also been a significant push in our voter educat..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Adarfo Sotelato: "“We've also made a significant push in our voter educatio..."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "He was replacing the "King's Avenue" sign that had marked the city's main thoroughfare for generations with "Liberty Street.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Player_Romus: ""Good. Let the city reflect its new reality.""*)
  - -> `[724]` (*Player_Romus: ""Nothing says ‘progress’ like swapping a sign.""*)
  - -> `[725]` (*Player_Romus: ""Even the streets must bear witness to the new order.""*)
  - -> `[727]` (*Player_Romus: ""Huh. You couldn't come up with anything better?""*)

### Węzeł `[212]`
Mówca: **Manus Sazon**
> ""Yes, even the small details are changing. New street names, new boundaries--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Manus Sazon: ""We've finalized all thirty-seven electoral districts as ..."*)

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""As you can see, not everything is changing. The public needs the continuity your presence as King provides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Daria de Rava: ""All thirty-seven electoral districts were finalized as o..."*)

### Węzeł `[214]`
Mówca: **Adarfo Sotelato**
> ""Yes, even the small details are subject to change. New street names, new boundaries--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Adarfo Sotelato: ""All thirty-seven electoral districts were finalized yest..."*)

### Węzeł `[215]`
Mówca: **Daria de Rava**
> ""In Iza, the mud’s still flying, but that’s hardly representative -- most districts have been quite civil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Daria de Rava: ""But should that mud turn to brick, we have security meas..."*)

### Węzeł `[216]`
Mówca: **Adarfo Sotelato**
> ""In Iza, the mud’s still flying -- proof that some still cling to old divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Adarfo Sotelato: ""But across the country, the people have demonstrated the..."*)

### Węzeł `[217]`
Mówca: **Adarfo Sotelato**
> ""But across the country, the people have demonstrated their commitment to cooperation and progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Adarfo Sotelato: ""However, should that mud turn to brick, we have security..."*)

### Węzeł `[218]`
Mówca: **Manus Sazon**
> ""Naturally, but those decisions are in the people's hands now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""Security measures have been put in place to prevent such..."*)

### Węzeł `[219]`
Mówca: **Daria de Rava**
> ""Of course, but those decisions are in the people's hands now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Daria de Rava: ""Security measures are in place to guard against such thi..."*)

### Węzeł `[220]`
Mówca: **Adarfo Sotelato**
> ""That’s not for you to decide. It's in the people's hands now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Adarfo Sotelato: ""Security precautions have been established to protect ag..."*)

### Węzeł `[221]`
Mówca: **Manus Sazon**
> ""Security measures have been put in place to prevent such things as election tampering, and local authorities are fully briefed on their role in ensuring voter safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: "“Any attempts at disruption will be dealt with swiftly. T..."*)

### Węzeł `[222]`
Mówca: **Daria de Rava**
> ""Security measures are in place to guard against such thing as election tampering, and local authorities have been thoroughly briefed on their responsibility for ensuring voter safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Daria de Rava: "“Rest assured, any attempts at disruption will be handled..."*)

### Węzeł `[223]`
Mówca: **Adarfo Sotelato**
> ""Security precautions have been established to protect against such things as election tampering, and local authorities have received clear instructions on their role in ensuring voter safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Adarfo Sotelato: ""If anyone tries to disrupt things, it’ll be swiftly deal..."*)

### Węzeł `[224]`
Mówca: **Manus Sazon**
> ""But should that mud turn to brick, we have security measures in place. And local authorities are fully briefed on their role in ensuring voter safety.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: "“Any attempts at disruption will be dealt with swiftly. T..."*)

### Węzeł `[225]`
Mówca: **Daria de Rava**
> ""But should that mud turn to brick, we have security measures in place. Local authorities are also fully briefed on their role in ensuring voter safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Daria de Rava: "“Rest assured, any attempts at disruption will be handled..."*)

### Węzeł `[226]`
Mówca: **Adarfo Sotelato**
> ""However, should that mud turn to brick, we have security measures in place. And local authorities are fully briefed on their role in ensuring voter safety.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Adarfo Sotelato: ""If anyone tries to disrupt things, it’ll be swiftly deal..."*)

### Węzeł `[227]`
Mówca: **Manus Sazon**
> ""We're aware of the scrutiny, and that's why we’re ensuring every detail is handled meticulously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Manus Sazon: ""Regular updates will be published to maintain transparen..."*)

### Węzeł `[228]`
Mówca: **Manus Sazon**
> ""Regular updates will be published to maintain transparency, and any irregularities will be made public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: "“Once voting concludes, results will be quickly processed..."*)

### Węzeł `[229]`
Mówca: **Manus Sazon**
> ""It’s certainly a lot to manage, but we've made strides in simplifying communication.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Manus Sazon: ""Regular updates will be made public to maintain transpar..."*)

### Węzeł `[230]`
Mówca: **Manus Sazon**
> ""Regular updates will be made public to maintain transparency, and any irregularities will be addressed openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: "“Once voting concludes, results will be quickly processed..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the update. Now, let's get to where we're going.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == true`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "The motorcade soon pulled up to the House of Delegates' entrance. We were flanked by local law enforcement and the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "A crowd of reporters and onlookers surrounded the entrance."*)

### Węzeł `[233]`
Mówca: **Manus Sazon**
> ""Your support for reforms has already given people a reason to believe things can get better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""If you were to talk about those issues during your upcom..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: ""With conditions holding steady, my campaign’s focused on..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Manus Sazon: ""As you know, with living conditions being what they are,..."*)

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""If you were to talk about those issues during your upcoming address, it would be a great help to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[238]`
Mówca: **Manus Sazon**
> ""Your push for reforms has laid the groundwork for those improvements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Manus Sazon: ""If you could mention that in your speech, it would show ..."*)

### Węzeł `[239]`
Mówca: **Manus Sazon**
> ""If you could mention that in your speech, it would show people there's a plan -- that we're building on something real.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[240]`
Mówca: **Manus Sazon**
> ""Living conditions are better than they've been in years, and my campaign is about protecting that progress -- ensuring we don’t backslide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Manus Sazon: ""Your decrees and the reforms you've supported have broug..."*)

### Węzeł `[241]`
Mówca: **Manus Sazon**
> ""Your decrees and the reforms you've supported have brought us to this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""If you could highlight that in your upcoming speech, it ..."*)

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""If you could highlight that in your upcoming speech, it would remind people that stability doesn't just happen -- it takes smart choices and steady leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an endorsement in all but name. My answer is no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Daria de Rava), `[583]` (Daria de Rava), `[584]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_NoOne =..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "Manus and I stepped out of the car. He waved at the crowd."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[247]`
Mówca: **Narrator**
> "A crowd of reporters and onlookers surrounded the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[248]`
Mówca: **Manus Sazon**
> ""That’s why we've built in mechanisms to handle any issues that arise to ensure a swift resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Manus Sazon: ""Regular updates will be made public to maintain transpar..."*)

### Węzeł `[249]`
Mówca: **Manus Sazon**
> ""Regular updates will be made public to maintain transparency, and any irregularities will be addressed openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: "“Once voting concludes, results will be quickly processed..."*)

### Węzeł `[250]`
Mówca: **Daria de Rava**
> ""We're keenly aware of the scrutiny, and that's why we’re ensuring every detail is handled meticulously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Daria de Rava: ""Regular updates will be published to maintain transparen..."*)

### Węzeł `[251]`
Mówca: **Daria de Rava**
> ""Regular updates will be published to maintain transparency, and any irregularities will be made public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Daria de Rava: "“Once voting concludes, results will be processed quickly..."*)

### Węzeł `[252]`
Mówca: **Adarfo Sotelato**
> ""You think I don't know that? Every detail is being handled meticulously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Adarfo Sotelato: ""Regular updates will be published to maintain transparen..."*)

### Węzeł `[253]`
Mówca: **Adarfo Sotelato**
> ""Regular updates will be published to maintain transparency, and any irregularities will be made public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Adarfo Sotelato: ""Once the voting ends, results will be processed quickly...."*)

### Węzeł `[254]`
Mówca: **Daria de Rava**
> ""It’s certainly a lot to manage, but we've made significant progress in simplifying communication.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Daria de Rava: ""Regular updates will be published to maintain transparen..."*)

### Węzeł `[255]`
Mówca: **Daria de Rava**
> ""Regular updates will be published to maintain transparency, and any irregularities will be made public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Daria de Rava: "“Once voting concludes, results will be processed quickly..."*)

### Węzeł `[256]`
Mówca: **Adarfo Sotelato**
> ""Your position of privilege is blinding you to the capabilities of the average person. Nevertheless, we'd made significant progress in simplifying communication.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Adarfo Sotelato: ""Regular updates are being published to maintain transpar..."*)

### Węzeł `[257]`
Mówca: **Adarfo Sotelato**
> ""Regular updates are being published to maintain transparency, and any irregularities is made public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Adarfo Sotelato: ""Once the voting ends, results will be processed quickly...."*)

### Węzeł `[258]`
Mówca: **Daria de Rava**
> ""That’s why we've established mechanisms to address any issues that arise and ensure a swift resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Daria de Rava: ""Regular updates will be made public to maintain transpar..."*)

### Węzeł `[259]`
Mówca: **Daria de Rava**
> ""Regular updates will be made public to maintain transparency, and any irregularities will be addressed openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Daria de Rava: "“Once voting concludes, results will be processed quickly..."*)

### Węzeł `[260]`
Mówca: **Adarfo Sotelato**
> ""That’s why we've established mechanisms to address such issues, should they arise, to ensure a swift resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Adarfo Sotelato: ""Regular updates will be made public to maintain transpar..."*)

### Węzeł `[261]`
Mówca: **Adarfo Sotelato**
> ""Regular updates will be made public to maintain transparency, and any irregularities will be addressed openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Adarfo Sotelato: ""Once the voting ends, results will be processed quickly...."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "As we drove through the streets, I caught sight of a newly painted mural of Rizia spanning the entire side of a building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "The sprawling image was bold and captivating, its colors ..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "The sprawling image was bold and captivating, its colors vivid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_..."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "Pales' coastal beauty and bustling port were depicted with detailed precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_BorderOutcome_Peace_Annexation == false || RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_..."*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.Wa..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_BorderOutcome_Peace_Annexation == false || RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true  or  Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == false  or  Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "Pales' coastal beauty and bustling port were depicted wit..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true || RiziaDLC.War_BorderOutcome_Peace_Annexation == false || RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true  or  Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == false  or  Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Zille's rocky coast, beachside resorts, and mining towns ..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "At the center, in the heart of the mural, was the slogan ..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "Zille's rocky coast, beachside resorts, and mining towns stood out at the top."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "At the center, in the heart of the mural, was the slogan ..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "At the center, in the heart of the mural, was the slogan "Unity Through Choice, Strength Through Voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "Soon after, my motorcade turned a corner and the House of..."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "Soon after, my motorcade turned a corner and the House of Delegates came into view down the street."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Reform_Report_Hub"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "Daria and I stepped out of the car. She waved at the crowd."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "Adarfo and I stepped out of the car. He threw his fist in..."*)

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""With conditions holding steady, my campaign’s focused on building momentum -- improving education, strengthening infrastructure, that sort of thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Manus Sazon: ""Your push for reforms has laid the groundwork for those ..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_PalesUpdate == true || RiziaDLCIsolated.NewGov_Reform_UpperHouse == true || RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == true || RiziaDLCIsolated.NewGov_Reform_ElectionIssues == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_PalesUpdate == true || Riz..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Reform_PalesUpdate == true || R..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_PalesUpdate == true || RiziaDLCIsolated.NewGov_Reform_UpperHouse == true || RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == true || RiziaDLCIsolated.NewGov_Reform_ElectionIssues == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""I appreciate the update. Now, let's get to where we're g..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Reform_PalesUpdate == true || RiziaDLCIsolated.NewGov_Reform_UpperHouse == true || RiziaDLCIsolated.NewGov_Reform_ZilleUpdate == true || RiziaDLCIsolated.NewGov_Reform_ElectionIssues == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Player_Romus: ""No time for small talk. The hall of the people is waiting.""*)

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""As you know, with living conditions being what they are, I'm running on a campaign of rebuilding -- jobs, homes, and security for those who've had the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Manus Sazon: ""Your support for reforms has already given people a reas..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == t..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "It was my head butler, Sebastian, who stepped inside. He ..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria");"*)

### Węzeł `[285]`
Mówca: **Narrator**
> "It was my head butler, Sebastian, who stepped inside. He informed me that my motorcade had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "I was to make my way to the House of Delegates, where a n..."*)

### Węzeł `[286]`
Mówca: **Pabel Adria**
> ""Your motorcade has arrived, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "I was to make my way to the House of Delegates, where a n..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Pabel stepped inside."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Soon after, I stepped outside the palace doors and approa..."*)

### Węzeł `[289]`
Mówca: **Narrator**
> "Pabel stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Pabel Adria: ""Your motorcade has arrived, Your Majesty.""*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell them I'll be right down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. How do I look?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "I stood tall, my suit sharp and simple."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not coming. Tell the Prime Minister I have to wash my hair.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be there when I see fit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "I was to make my way to the House of Delegates, where a newly built display case for our new constitution awaited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Narrator: "I'd been invited to a private viewing before it was unvei..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "A chance for a quiet conversation about how the election campaign was unfolding, and how the kingdom was faring without my decision-making."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player_Romus: ""I'll be there when I see fit.""*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[290]` (*Player_Romus: ""Tell them I'll be right down.""*)
  - -> `[291]` (*Player_Romus: ""Great. How do I look?""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == t..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "Sebastian looked stunned. He still hadn't quite figured o..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "Pabel laughed politely, well accustomed to my humor."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "Sebastian looked stunned. He still hadn't quite figured out my sense of humor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "I quickly reassured him, telling him I was kidding and th..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""I'm not coming. Tell the Prime Minister I have to wash m..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[303]`
Mówca: **Narrator**
> "Pabel laughed politely, well accustomed to my humor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Pabel Adria: ""I'll alert the media.""*)

### Węzeł `[304]`
Mówca: **Pabel Adria**
> ""I'll alert the media.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[305]`
Mówca: **Narrator**
> "I quickly reassured him, telling him I was kidding and that I'd be right down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "Not to be rushed, I took my time, pausing to glance at my..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == t..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Sebastian nodded and left the room."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Pabel Adria: ""Right away.""*)

### Węzeł `[309]`
Mówca: **Pabel Adria**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "He nodded and left the room."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Sebastian nodded and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Soon after, I stepped outside the palace doors and approa..."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "He nodded and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == t..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Sebastian gave a nod and left the room."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Pabel Adria: ""Yes, Your Majesty. Right away.""*)

### Węzeł `[315]`
Mówca: **Pabel Adria**
> ""Yes, Your Majesty. Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Pabel nodded and left the room."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "Sebastian gave a nod and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "Not to be rushed, I took my time, pausing to glance at my..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "Pabel nodded and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == t..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: ""Fit for royalty, as always, Your Majesty," he replied."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == true  or  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Pabel Adria: ""Regal as always, Your Majesty.""*)

### Węzeł `[321]`
Mówca: **Pabel Adria**
> ""Regal as always, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "He gave a slight nod before leaving the room."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Sebastian gave a slight nod before leaving the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Soon after, I stepped outside the palace doors and approa..."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "He gave a slight nod before leaving the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[324]`
Mówca: **Narrator**
> ""Fit for royalty, as always, Your Majesty," he replied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Sebastian gave a slight nod before leaving the room."*)

### Węzeł `[325]`
Mówca: **Narrator**
> "I stood tall, my suit sharp and simple."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "Not to be rushed, I took my time, pausing to glance at my..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "Not to be rushed, I took my time, pausing to glance at myself one last time in the mirror before making my way through the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "I approached the entrance where my motorcade awaited."*)

### Węzeł `[328]`
Mówca: **Narrator**
> "I approached the entrance where my motorcade awaited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[329]`
Mówca: **Narrator**
> "There, Manus Sazon stood, waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Manus Sazon: ""Good to see you, Your Majesty. I was beginning to wonder..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato");"*)

### Węzeł `[336]`
Mówca: **Narrator**
> "There, Daria de Rava stood, waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Daria de Rava: ""Ah! You're here. You know, for a moment there I was begi..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "But Adarfo Sotelato was nowhere to be found. After a moment, the back door of the nearest car opened, and there he was, seated inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Adarfo Sotelato: ""You've kept us waiting, *Your Majesty.*""*)

### Węzeł `[338]`
Mówca: **Narrator**
> "Soon after, I stepped outside the palace doors and approached my waiting motorcade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[339]`
Mówca: **Narrator**
> "Manus Sazon was there, as expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Manus Sazon: ""Your Majesty! Good to see you.""*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "But Adarfo Sotelato was nowhere to be found."*)

### Węzeł `[346]`
Mówca: **Narrator**
> "Daria de Rava was there, as expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Daria de Rava: ""Ah! You're here.""*)

### Węzeł `[347]`
Mówca: **Narrator**
> "But Adarfo Sotelato was nowhere to be found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Narrator: "After a moment, the back door of the nearest car opened, ..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "There, Manus Sazon stood, waiting for me."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Manus Sazon was there, as expected."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "Daria de Rava was there, as expected."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "There, Daria de Rava stood, waiting for me."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "But Adarfo Sotelato was nowhere to be found. After a mome..."*)

### Węzeł `[353]`
Mówca: **Adarfo Sotelato**
> ""You've kept us waiting, *Your Majesty.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "I could sense contempt lurking behind his veneer of cordi..."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "I could sense contempt lurking behind his veneer of cordiality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""I come and go as I see fit.""*)
  - -> `[374]` (*Player_Romus: ""I’d say you’re lucky I showed up at all.""*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[360]` (*Player_Romus: ""I wouldn't miss this. At last, my legacy as a reformer p..."*)

### Węzeł `[355]`
Mówca: **Daria de Rava**
> ""Ah! You're here. You know, for a moment there I was beginning to think you weren't coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""I wouldn't dare. You know how I am about appearances.""*)
  - -> `[357]` (*Player_Romus: ""It’s hard to keep up with all the demands. But here I am.""*)
  - -> `[358]` (*Player_Romus: ""I come and go as I see fit.""*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[360]` (*Player_Romus: ""I wouldn't miss this. At last, my legacy as a reformer p..."*)

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""Good to see you, Your Majesty. I was beginning to wonder if you’d changed your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""I wouldn't dare. You know how I am about appearances.""*)
  - -> `[357]` (*Player_Romus: ""It’s hard to keep up with all the demands. But here I am.""*)
  - -> `[358]` (*Player_Romus: ""I come and go as I see fit.""*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[360]` (*Player_Romus: ""I wouldn't miss this. At last, my legacy as a reformer p..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s hard to keep up with all the demands. But here I am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Daria de Rava), `[356]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I come and go as I see fit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Narrator), `[355]` (Daria de Rava), `[356]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't dare. You know how I am about appearances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Daria de Rava), `[356]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't miss this. At last, my legacy as a reformer preserved for all to see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Narrator), `[355]` (Daria de Rava), `[356]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Waiting is good for the soul, don’t you think?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[354]` (Narrator), `[355]` (Daria de Rava), `[356]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player_Romus: ""Waiting is good for the soul, don’t you think?""*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Manus Sazon: ""It does give one time to think, certainly.""*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Daria de Rava: ""I suppose it gives time for reflection and readiness.""*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Adarfo Sotelato: ""I wouldn't know. I don't believe in one.""*)

### Węzeł `[371]`
Mówca: **Adarfo Sotelato**
> ""I wouldn't know. I don't believe in one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "A momentary silence fell between us, as if each were wait..."*)

### Węzeł `[372]`
Mówca: **Daria de Rava**
> ""I suppose it gives time for reflection and readiness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[373]`
Mówca: **Manus Sazon**
> ""It does give one time to think, certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’d say you’re lucky I showed up at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Manus Sazon: ""Of course.""*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Daria de Rava: ""Yes, of course.""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Adarfo Sotelato: ""Right...""*)

### Węzeł `[381]`
Mówca: **Adarfo Sotelato**
> ""Right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "A momentary silence fell between us, as if each were wait..."*)

### Węzeł `[382]`
Mówca: **Daria de Rava**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[383]`
Mówca: **Manus Sazon**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "An attendant opened the nearest car door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[385]`
Mówca: **Manus Sazon**
> ""After you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "I slid into the backseat, with Manus following behind."*)

### Węzeł `[386]`
Mówca: **Narrator**
> "A momentary silence fell between us, as if each were waiting for the other to blink first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Adarfo Sotelato: ""Well, are you getting in or not?""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Manus Sazon: ""After you.""*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Daria de Rava: ""Please, after you.""*)

### Węzeł `[390]`
Mówca: **Daria de Rava**
> ""Please, after you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "I slid into the backseat, with Daria following behind."*)

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""Well, are you getting in or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "I got in and took the seat beside him."*)

### Węzeł `[392]`
Mówca: **Adarfo Sotelato**
> ""Ah, *Your Majesty*, still haven’t learned to open your own door, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "I could sense contempt lurking behind his veneer of cordi..."*)

### Węzeł `[393]`
Mówca: **Daria de Rava**
> ""Ah! You're here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player_Romus: ""I wouldn't miss this. At last, my legacy as a reformer p..."*)
  - -> `[397]` (*Player_Romus: ""Always a pleasure to see you, Daria.""*)
  - -> `[182]` (*Player_Romus: ""I hope I haven't kept you waiting too long.""*)

### Węzeł `[394]`
Mówca: **Manus Sazon**
> ""Your Majesty! Good to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player_Romus: ""I wouldn't miss this. At last, my legacy as a reformer p..."*)
  - -> `[395]` (*Player_Romus: ""Likewise.""*)
  - -> `[182]` (*Player_Romus: ""I hope I haven't kept you waiting too long.""*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Likewise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[396]`
Mówca: **Manus Sazon**
> ""My time is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Always a pleasure to see you, Daria.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "An attendant opened the nearest car door."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "I could sense contempt lurking behind his veneer of cordiality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player_Romus: ""I wouldn't miss this. At last, my legacy as a reformer p..."*)
  - -> `[187]` (*Player_Romus: ""Always a pleasure to see you, Adarfo.""*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[193]` (*Player_Romus: ""I’ve got more important matters to attend to than openin..."*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you remembered your manners.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Narrator), `[402]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This feels right. The King and Prime Minister, steering the country together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Narrator), `[402]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[401]`
Mówca: **Narrator**
> "I slid into the backseat, with Manus following behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[399]` (*Player_Romus: ""I'm glad you remembered your manners.""*)
  - -> `[400]` (*Player_Romus: ""This feels right. The King and Prime Minister, steering ..."*)
  - -> `[714]` (*Player_Romus: ""This feels odd. I'm not used to sharing a car.""*)

### Węzeł `[402]`
Mówca: **Narrator**
> "I slid into the backseat, with Daria following behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Player_Romus: ""I'm glad you remembered your manners.""*)
  - -> `[400]` (*Player_Romus: ""This feels right. The King and Prime Minister, steering ..."*)
  - -> `[714]` (*Player_Romus: ""This feels odd. I'm not used to sharing a car.""*)

### Węzeł `[403]`
Mówca: **Narrator**
> "I got in and took the seat beside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player_Romus: ""Forgive my rudeness, Mr. Prime Minister. I still haven't..."*)
  - -> `[682]` (*Player_Romus: ""It would behoove you to remember that you are only Prime..."*)
  - -> `[405]` (*Player_Romus: ""This feels right. The King and Prime Minister, steering ..."*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive my rudeness, Mr. Prime Minister. I still haven't gotten used to the new order of things.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Adarfo Sotelato: ""I understand. You'll adjust to your new role soon enough.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This feels right. The King and Prime Minister, steering the country together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Adarfo Sotelato: ""I'm behind the wheel, Toras. You're just along for the r..."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "Before long, the motorcade was on its way, leaving the palace walls behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "I couldn't help but notice the overwhelming sight of elec..."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "I couldn't help but notice the overwhelming sight of election banners and flyers plastered everywhere -- on lampposts, storefronts, even hanging from windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "The streets were awash with the colors of both the RNC an..."*)

### Węzeł `[408]`
Mówca: **Narrator**
> "The streets were awash with the colors of both the RNC and RPP, each trying to outdo the other with grand promises."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "It was all-consuming -- election fever, in full swing."*)

### Węzeł `[409]`
Mówca: **Narrator**
> "It was all-consuming -- election fever, in full swing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“How wonderfully humble. A banner with your face larger than the city itself.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Narrator), `[420]` (Narrator), `[423]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "I spotted a large poster of Manus on the side of a buildi..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "I spotted a large poster of Daria on the side of a buildi..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "There, I spotted a large poster of Adarfo on the side of ..."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "I spotted a large poster of Manus on the side of a building, his confident smile stretching across it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "The words “Every Vote Matters” emblazoned beneath his face."*)

### Węzeł `[418]`
Mówca: **Narrator**
> "The words “Every Vote Matters” emblazoned beneath his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: "“How wonderfully humble. A banner with your face larger t..."*)
  - -> `[422]` (*Player_Romus: ""How are the election preparations shaping up?""*)
  - -> `[424]` (*Player_Romus: ""Wait... I get a vote too, right?""*)
  - -> `[196]` (*Player_Romus: ""A lot of color, a lot of slogans... I just hope there’s ..."*)
  - -> `[720]` (*Player_Romus_Italic: "Don't remark on it."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "I spotted a large poster of Daria on the side of a building, her confident smile stretching across it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Narrator: "The words “For a Future We Can Trust” emblazoned beneath ..."*)

### Węzeł `[420]`
Mówca: **Narrator**
> "The words “For a Future We Can Trust” emblazoned beneath her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: "“How wonderfully humble. A banner with your face larger t..."*)
  - -> `[422]` (*Player_Romus: ""How are the election preparations shaping up?""*)
  - -> `[424]` (*Player_Romus: ""Wait... I get a vote too, right?""*)
  - -> `[196]` (*Player_Romus: ""A lot of color, a lot of slogans... I just hope there’s ..."*)
  - -> `[720]` (*Player_Romus_Italic: "Don't remark on it."*)

### Węzeł `[421]`
Mówca: **Narrator**
> "There, I spotted a large poster of Adarfo on the side of a building, his stern look glaring down from the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "The words “Equality for All, Power to the People” emblazo..."*)

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are the election preparations shaping up?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Narrator), `[420]` (Narrator), `[423]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Narrator: "Through the glass, I saw volunteers at a registration boo..."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "The words “Equality for All, Power to the People” emblazoned beneath his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: "“How wonderfully humble. A banner with your face larger t..."*)
  - -> `[422]` (*Player_Romus: ""How are the election preparations shaping up?""*)
  - -> `[424]` (*Player_Romus: ""Wait... I get a vote too, right?""*)
  - -> `[196]` (*Player_Romus: ""A lot of color, a lot of slogans... I just hope there’s ..."*)
  - -> `[720]` (*Player_Romus_Italic: "Don't remark on it."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait... I get a vote too, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Narrator), `[420]` (Narrator), `[423]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "Manus chuckled."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Narrator: "Daria's expression stiffens for a moment, but she maintai..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Narrator: "Adarfo didn't flinch."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "Manus chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Manus Sazon: ""What can I say? My face tested well with focus groups. O..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Manus Sazon: ""Of course. Everyone gets a voice in this, Your Majesty -..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Daria de Rava: ""Yes, Your Majesty. Everyone gets a voice in this -- equa..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Narrator: "Adarfo smirked."*)

### Węzeł `[438]`
Mówca: **Manus Sazon**
> ""Of course. Everyone gets a voice in this, Your Majesty -- equally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "He gestured outside."*)

### Węzeł `[439]`
Mówca: **Manus Sazon**
> ""That’s always the risk. But I believe the people are paying attention where it matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "He gestured outside."*)

### Węzeł `[440]`
Mówca: **Narrator**
> "I'd been invited to a private viewing before it was unveiled to the public, just the interim prime minister and myself --"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "A chance for a quiet conversation about how the election ..."*)

### Węzeł `[441]`
Mówca: **Narrator**
> "Manus and I stepped out of the car. He waved at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player_Romus_Italic: "Wave at the crowd."*)
  - -> `[480]` (*Player_Romus_Italic: "Continue onward."*)

### Węzeł `[442]`
Mówca: **Narrator**
> "Daria and I stepped out of the car. She waved at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player_Romus_Italic: "Wave at the crowd."*)
  - -> `[480]` (*Player_Romus_Italic: "Continue onward."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "Adarfo and I stepped out of the car. He threw his fist into the air, rallying some members of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player_Romus_Italic: "Wave at the crowd."*)
  - -> `[480]` (*Player_Romus_Italic: "Continue onward."*)

### Węzeł `[444]`
Mówca: **Manus Sazon**
> ""Oh, and the protective glass is 12 centimeters thick -- enough to stop a bullet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a piece of paper, in the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Manus Sazon), `[532]` (Daria de Rava), `[533]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "I looked it over a moment longer before turning toward th..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Player_Romus: ""May God guide those who carry out its words.""*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Player_Romus: ""May Rizia's next prime minister have the integrity to ca..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, we saw it. Let's be on our way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Manus Sazon), `[532]` (Daria de Rava), `[533]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Narrator: "I turned and headed back toward the chamber's exit."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's something, isn't it? Proof that we can start again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Manus Sazon), `[532]` (Daria de Rava), `[533]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "I looked it over a moment longer before turning toward th..."*)

### Węzeł `[451]`
Mówca: **Narrator**
> "I looked it over a moment longer before turning toward the chamber's exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God guide those who carry out its words.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[444]` (Manus Sazon), `[532]` (Daria de Rava), `[533]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "I looked it over a moment longer before turning toward th..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you'd told me that sooner, I'd have ordered it for every window in the palace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[444]` (Manus Sazon), `[532]` (Daria de Rava), `[533]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "I looked it over a moment longer before turning toward th..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.T..."*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Player_Romus: ""If you'd told me that sooner, I'd have ordered it for ev..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[457]`
Mówca: **Narrator**
> "Manus stepped toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[458]`
Mówca: **Narrator**
> "Daria stepped toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want a good word from me about the elections, you can forget it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon), `[469]` (Daria de Rava), `[729]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == false"*)

### Węzeł `[460]`
Mówca: **Narrator**
> "I didn't turn back as I made my way out of the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "I walked toward the seats, each one now a symbol of the u..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Manus Sazon: ""Living conditions are better than they've been in years,..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Manus stepped toward me."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.T..."*)
  - -> `[450]` (*Player_Romus: ""It's something, isn't it? Proof that we can start again.""*)
  - -> `[449]` (*Player_Romus: ""Okay, we saw it. Let's be on our way.""*)
  - -> `[445]` (*Player_Romus: ""It's just a piece of paper, in the end.""*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""Before you go, there is one more thing I wanted to discuss -- more of a request, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""No. Good day.""*)
  - -> `[477]` (*Player_Romus: ""What is it?""*)
  - -> `[459]` (*Player_Romus: ""If you want a good word from me about the elections, you..."*)

### Węzeł `[469]`
Mówca: **Daria de Rava**
> ""Before you go, there is one more thing I wanted to speak with you about -- more of a request, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""No. Good day.""*)
  - -> `[477]` (*Player_Romus: ""What is it?""*)
  - -> `[459]` (*Player_Romus: ""If you want a good word from me about the elections, you..."*)

### Węzeł `[470]`
Mówca: **Narrator**
> "I turned and headed back toward the chamber's exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Manus Sazon: ""Before you go, there is one more thing I wanted to discu..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Daria de Rava: ""Before you go, there is one more thing I wanted to speak..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Adarfo Sotelato: ""One more thing...""*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon), `[469]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Good day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon), `[469]` (Daria de Rava), `[729]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "I didn't turn back as I made my way out of the chamber."*)

### Węzeł `[479]`
**[WYBÓR GRACZA: "Wave at the crowd."]** — Mówca: **Player_Romus_Italic**
> "The crowd cheered, but a few voices of opposition could be heard."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[441]` (Narrator), `[442]` (Narrator), `[443]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: ""Your Majesty! Prime Minister! A photo, please!" a report..."*)

### Węzeł `[480]`
**[WYBÓR GRACZA: "Continue onward."]** — Mówca: **Player_Romus_Italic**
> "I chose not to wave at the crowd, and continued toward the main entrance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[441]` (Narrator), `[442]` (Narrator), `[443]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: ""Your Majesty! Prime Minister! A photo, please!" a report..."*)

### Węzeł `[481]`
Mówca: **Narrator**
> ""Your Majesty! Prime Minister! A photo, please!" a reporter yelled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Player_Romus_Italic: "Pose with the prime minister for a photo."*)
  - -> `[487]` (*Player_Romus_Italic: "Don't pose for a photo and continue onward."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "Manus and I briefly came together for the photo. Bulb fla..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[485]`
Mówca: **Narrator**
> "Manus and I briefly came together for the photo. Bulb flashes from all around momentarily blinded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""I suppose we should smile for the cameras.""*)
  - -> `[493]` (*Player_Romus: ""People love a good picture. I suppose this is what democ..."*)
  - -> `[495]` (*Player_Romus: ""These moments... They’ll be all we have to remember when..."*)

### Węzeł `[486]`
**[WYBÓR GRACZA: "Pose with the prime minister for a photo."]** — Mówca: **Player_Romus_Italic**
> "I decided to pose for a photo with the prime minister."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[487]`
**[WYBÓR GRACZA: "Don't pose for a photo and continue onward."]** — Mówca: **Player_Romus_Italic**
> "I kept walking."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Narrator: "We passed through the foyer and the hall, empty except fo..."*)

### Węzeł `[488]`
Mówca: **Narrator**
> "Daria and I briefly came together for the photo. Bulb flashes from all around momentarily blinded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""I suppose we should smile for the cameras.""*)
  - -> `[493]` (*Player_Romus: ""People love a good picture. I suppose this is what democ..."*)
  - -> `[495]` (*Player_Romus: ""These moments... They’ll be all we have to remember when..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "Daria and I briefly came together for the photo. Bulb fla..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Narrator: "Adarfo and I briefly came together for the photo. Bulb fl..."*)

### Węzeł `[492]`
Mówca: **Narrator**
> "Adarfo and I briefly came together for the photo. Bulb flashes from all around momentarily blinded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""I suppose we should smile for the cameras.""*)
  - -> `[493]` (*Player_Romus: ""People love a good picture. I suppose this is what democ..."*)
  - -> `[495]` (*Player_Romus: ""These moments... They’ll be all we have to remember when..."*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People love a good picture. I suppose this is what democracy looks like.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Narrator), `[488]` (Narrator), `[492]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose we should smile for the cameras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Narrator), `[488]` (Narrator), `[492]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These moments... They’ll be all we have to remember when the dust settles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Narrator), `[488]` (Narrator), `[492]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[496]`
Mówca: **Manus Sazon**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[497]`
Mówca: **Daria de Rava**
> ""Naturally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Manus Sazon: ""Absolutely.""*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Daria de Rava: ""Naturally.""*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Adarfo Sotelato: "“Only if you mean it.”"*)

### Węzeł `[504]`
Mówca: **Adarfo Sotelato**
> "“Only if you mean it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Manus Sazon: ""A symbol of our people's strength and the future we're b..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Daria de Rava: ""I'd say democracy is a bit more complicated than that.""*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Adarfo Sotelato: "“I think the people would prefer actual change, not just ..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Manus Sazon: "“And what a picture it will make.""*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Daria de Rava: ""I hope it’s not just the pictures they remember.""*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Adarfo Sotelato: ""Some of us will be remembered more fondly than others.""*)

### Węzeł `[517]`
Mówca: **Narrator**
> "We passed through the foyer and the hall, empty except for us, until we reached the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "At the center of the room near the podiums, a newly refur..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""I think there's more to it than just a photo.""*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[521]`
Mówca: **Daria de Rava**
> ""I'd say democracy is a bit more complicated than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[522]`
Mówca: **Adarfo Sotelato**
> ""Some of us will be remembered more fondly than others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""I think there's more to it than just a photo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[524]`
Mówca: **Adarfo Sotelato**
> "“I think the people would prefer actual change, not just a moment for the camera.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[525]`
Mówca: **Daria de Rava**
> ""I hope it’s not just the pictures they remember.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Daria de Rava: ""Rizia's future is in that case. To think this is what we..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Adarfo Sotelato: ""Funny... a king admiring the handiwork of the people.""*)

### Węzeł `[529]`
Mówca: **Manus Sazon**
> "“And what a picture it will make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "After the photos, we headed up the steps and entered the ..."*)

### Węzeł `[530]`
Mówca: **Narrator**
> "After the photos, we headed up the steps and entered the House of Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Narrator: "We passed through the foyer and the hall, empty except fo..."*)

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""A symbol of our people's strength and the future we're building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Manus Sazon: ""Oh, and the protective glass is 12 centimeters thick -- ..."*)

### Węzeł `[532]`
Mówca: **Daria de Rava**
> ""Rizia's future is in that case. To think this is what we've worked so hard for...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[533]`
Mówca: **Adarfo Sotelato**
> ""We’ll see if it truly represents all of us, or just the few who hold the power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[534]`
Mówca: **Narrator**
> "At the center of the room near the podiums, a newly refurbished secure display case proudly showcased Rizia’s new constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Daria de Rava: ""Given our current living standards, my campaign is cente..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)

### Węzeł `[538]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty. Your support will do more than you realize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "Manus reached out and shook my hand, his grip firm with g..."*)

### Węzeł `[539]`
Mówca: **Manus Sazon**
> ""I understand your position, Your Majesty. I appreciate your time regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Manus gave a polite nod before he turned and left."*)

### Węzeł `[540]`
Mówca: **Manus Sazon**
> ""You will?! That's great! You have my sincerest gratitude. Thank you, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "Manus reached out and shook my hand, his grip firm with g..."*)

### Węzeł `[541]`
Mówca: **Manus Sazon**
> ""Very well. Just thought I'd ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Manus gave a polite nod before he turned and left."*)

### Węzeł `[542]`
Mówca: **Daria de Rava**
> ""You will?! That’s wonderful! I’m truly grateful. Thank you, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Narrator: "Daria reached out and shook my hand, her eyes shining wit..."*)

### Węzeł `[543]`
Mówca: **Daria de Rava**
> ""Well, I appreciate your time regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Narrator: "Daria gave a polite nod before she turned and left."*)

### Węzeł `[544]`
Mówca: **Daria de Rava**
> ""Fair enough. I won’t press the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Narrator: "Daria gave a polite nod before she turned and left."*)

### Węzeł `[545]`
Mówca: **Narrator**
> "Manus reached out and shook my hand, his grip firm with gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Narrator: "When he realized he had been shaking my hand far longer t..."*)

### Węzeł `[546]`
Mówca: **Narrator**
> "Manus gave a polite nod before he turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[547]`
Mówca: **Narrator**
> "Daria reached out and shook my hand, her eyes shining with gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Daria de Rava");"*)

### Węzeł `[548]`
Mówca: **Narrator**
> "As the doors closed behind him, I took in the desolate room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "I walked toward the seats, each one now a symbol of the u..."*)

### Węzeł `[549]`
Mówca: **Narrator**
> "I walked toward the seats, each one now a symbol of the uncertain future that awaited us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "I caught sight of the display case once more. What it rep..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Narrator: "As the doors closed behind him, I took in the desolate room."*)

### Węzeł `[551]`
Mówca: **Narrator**
> "Daria gave a polite nod before she turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Daria de Rava");"*)

### Węzeł `[552]`
Mówca: **Narrator**
> "When he realized he had been shaking my hand far longer than necessary, he quickly withdrew and gave a slight bow before leaving the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Daria de Rava");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Narrator: "As the doors closed behind her, I took in the desolate room."*)

### Węzeł `[554]`
Mówca: **Narrator**
> "As the doors closed behind her, I took in the desolate room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "I walked toward the seats, each one now a symbol of the u..."*)

### Węzeł `[555]`
Mówca: **Narrator**
> "I caught sight of the display case once more. What it represented was impossible to ignore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Player_Romus: ""They call this progress, yet they stand on the foundatio..."*)
  - -> `[556]` (*Player_Romus: ""No matter what happens, no one can rewrite what I have d..."*)
  - -> `[559]` (*Player_Romus: ""Perhaps this will lead Rizia to something greater. Perha..."*)
  - -> `[560]` (*Player_Romus: ""My time is ending, but Rizia will endure. It must.""*)

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what happens, no one can rewrite what I have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Narrator: "I looked around the chamber once more, but the only reply..."*)

### Węzeł `[557]`
Mówca: **Narrator**
> "I looked around the chamber once more, but the only reply was the hush of an empty room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Narrator: "With nothing left to say, I turned to leave, carrying wit..."*)

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They call this progress, yet they stand on the foundation I built.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Narrator: "I looked around the chamber once more, but the only reply..."*)

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps this will lead Rizia to something greater. Perhaps my rule was the bridge that made it possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Narrator: "I looked around the chamber once more, but the only reply..."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My time is ending, but Rizia will endure. It must.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Narrator: "I looked around the chamber once more, but the only reply..."*)

### Węzeł `[561]`
Mówca: **Narrator**
> "With nothing left to say, I turned to leave, carrying with me the knowledge that one chapter had ended and another was beginning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Average == tru..."*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Average == t..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Daria de Rava: ""I’m running a campaign focused on strengthening our econ..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Average == true || RiziaDLC.Situation_Welfare_LivingStandards_Acceptable == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Acceptable"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Daria de Rava: ""With living conditions being what they are, I’m running ..."*)

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll gladly lend my support to your cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon), `[239]` (Manus Sazon), `[242]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_ManusPlan = true; RiziaDLCSup..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_ManusPlan = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_ManusPlan = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_ManusPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Manus Sazon: ""Thank you, Your Majesty. Your support will do more than ..."*)

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can’t back this message. There are more important issues right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon), `[239]` (Manus Sazon), `[242]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Manus Sazon: ""I understand your position, Your Majesty. I appreciate y..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Manus = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Manus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Manus"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Manus Sazon: ""You will?! That's great! You have my sincerest gratitude..."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If mentioning your plans will bring hope to the people, I’ll talk about them. Though I’m not sure it will be enough to change minds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon), `[239]` (Manus Sazon), `[242]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_ManusPlan = true; RiziaDLCSup..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_ManusPlan = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_ManusPlan = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_Endorse_ManusPlan"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_ManusPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Manus Sazon: ""You will?! That's great! You have my sincerest gratitude..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_Daria = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Daria = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_Endorse_Daria"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Daria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Daria de Rava: ""You will?! That’s wonderful! I’m truly grateful. Thank y..."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_DariaPlan = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_DariaPlan = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_DariaPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Daria de Rava: ""You will?! That’s wonderful! I’m truly grateful. Thank y..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_Endorse_DariaPlan = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_DariaPlan = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_Endorse_DariaPlan"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_DariaPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Daria de Rava: ""You will?! That’s wonderful! I’m truly grateful. Thank y..."*)

### Węzeł `[574]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll mention it. Security is vital, and if my words can help, I’ll gladly support it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Daria de Rava), `[583]` (Daria de Rava), `[584]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_DariaPlan = true; RiziaDLCSup..."*)

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The policy is sound, but I can’t endorse your campaign directly. However, I’ll mention the need for security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Daria de Rava), `[583]` (Daria de Rava), `[584]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_DariaPlan = true; RiziaDLCSup..."*)

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can’t back this message. There are more important issues right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Daria de Rava), `[583]` (Daria de Rava), `[584]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Daria de Rava: ""Well, I appreciate your time regardless.""*)

### Węzeł `[577]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see the value in your message, and I’ll openly support you. Stability and security are paramount.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Daria de Rava), `[583]` (Daria de Rava), `[584]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Daria = true; RiziaDLCSupport..."*)

### Węzeł `[578]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't just mention it. I will openly endorse you as a candidate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon), `[239]` (Manus Sazon), `[242]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_Endorse_Manus = true; RiziaDLCSupport..."*)

### Węzeł `[579]`
Mówca: **Daria de Rava**
> ""An endorsement from the King would show the people that we are working toward rebuilding from the ground up...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Daria de Rava: ""That stability doesn't come without effort, and it takes..."*)

### Węzeł `[580]`
Mówca: **Daria de Rava**
> ""Highlighting that in your upcoming speech would show the people there’s a clear and secure path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Daria de Rava: ""It would remind them that the RNC is not just maintainin..."*)

### Węzeł `[581]`
Mówca: **Daria de Rava**
> ""If you could mention this in your speech, it would reassure the people that we’re not just protecting what you've built, but working on Rizia's future security and growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[582]`
Mówca: **Daria de Rava**
> ""With living conditions being what they are, I’m running on a campaign focused on strengthening our economy and ensuring the security of every citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Daria de Rava: ""An endorsement from the King would show the people that ..."*)

### Węzeł `[583]`
Mówca: **Daria de Rava**
> ""That stability doesn't come without effort, and it takes strong leadership to get us there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[584]`
Mówca: **Daria de Rava**
> ""It would remind them that the RNC is not just maintaining stability -- we’re securing their future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Romus: ""That's an endorsement in all but name. My answer is no.""*)
  - -> `[577]` (*Player_Romus: ""I see the value in your message, and I’ll openly support..."*)
  - -> `[575]` (*Player_Romus: ""The policy is sound, but I can’t endorse your campaign d..."*)
  - -> `[574]` (*Player_Romus: ""I’ll mention it. Security is vital, and if my words can ..."*)
  - -> `[576]` (*Player_Romus: ""I can’t back this message. There are more important issu..."*)

### Węzeł `[586]`
Mówca: **Daria de Rava**
> ""Given our current living standards, my campaign is centered on securing our prosperity and solidifying Rizia’s position as a regional powerhouse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Daria de Rava: ""If you could mention this in your speech, it would reass..."*)

### Węzeł `[587]`
Mówca: **Daria de Rava**
> ""I’m running a campaign focused on strengthening our economy and ensuring the security of every citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Daria de Rava: ""Highlighting that in your upcoming speech would show the..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""I can’t back this message. There are more important issu..."*)
  - -> `[569]` (*Player_Romus: ""If mentioning your plans will bring hope to the people, ..."*)
  - -> `[578]` (*Player_Romus: ""I won't just mention it. I will openly endorse you as a ..."*)
  - -> `[565]` (*Player_Romus: ""I’ll gladly lend my support to your cause.""*)
  - -> `[243]` (*Player_Romus: ""That's an endorsement in all but name. My answer is no.""*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Manus Sazon: ""Very well. Just thought I'd ask.""*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Daria de Rava: ""Fair enough. I won’t press the matter.""*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[593]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[94]` (Daria de Rava), `[108]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[594]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[94]` (Daria de Rava), `[108]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[94]` (Daria de Rava), `[108]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[597]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[94]` (Daria de Rava), `[108]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Manus Sazon: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Daria de Rava: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Adarfo Sotelato: ""I mean everyone, even those who might not vote in my fav..."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Player_Romus: ""It sounds like things are moving in the right direction.""*)
  - -> `[595]` (*Player_Romus: ""I suppose some still need convincing that their vote act..."*)
  - -> `[593]` (*Player_Romus: "“You mean... everyone more likely to vote for you.”"*)
  - -> `[596]` (*Player_Romus: ""This is all happening so fast.""*)
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Manus Sazon: ""Fast, yes -- but that doesn't mean rushed. We've been th..."*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Daria de Rava: ""Fast, yes -- but not careless or rushed. We've been thor..."*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Adarfo Sotelato: ""It may feel fast to you, but for those who've spent thei..."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Manus Sazon: ""A valid concern, but one we are addressing.""*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Daria de Rava: ""It’s a valid concern, but we are working on it.""*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Adarfo Sotelato: ""True, especially after experiencing Rizia's sham of an e..."*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Manus Sazon: ""Absolutely.""*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Daria de Rava: "“Certainly.""*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Adarfo Sotelato: ""They are.""*)

### Węzeł `[623]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[624]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in pubs -- that would get their attention.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Manus Sazon), `[94]` (Daria de Rava), `[108]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Player_Romus: ""Maybe we should put the ballot boxes in pubs -- that wou..."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[629]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[630]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[631]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[632]`
Mówca: **Manus Sazon**
> ""A valid concern, but one we are addressing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[633]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need. Instead, we've focused on strengthening the process itself, which will lay the foundation for genuine trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[634]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[635]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us to get this right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Daria de Rava: ""While that may get attention, it's not the kind we need...."*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Adarfo Sotelato: ""This isn't a joke. The people are counting on us to get ..."*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Manus Sazon: "“As entertaining as that would be, we’re still focused on..."*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[642]`
Mówca: **Narrator**
> "As the motorcade slowed at the intersection, my gaze lingered on a city worker balanced on a ladder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[643]`
Mówca: **Daria de Rava**
> ""It’s a valid concern, but we are working on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[644]`
Mówca: **Adarfo Sotelato**
> ""True, especially after experiencing Rizia's sham of an electoral system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[645]`
Mówca: **Daria de Rava**
> "“Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[646]`
Mówca: **Adarfo Sotelato**
> ""They are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Manus Sazon: ""Moreover, centralizing the government has allowed us to ..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Manus Sazon: ""Obviously, care will need to be taken to ensure uniform ..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Daria de Rava: ""Moreover, centralizing the government, while it has led ..."*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Daria de Rava: ""With Rizia still not centralized, care will need to be t..."*)

### Węzeł `[653]`
Mówca: **Manus Sazon**
> ""Moreover, centralizing the government has allowed us to provide uniform oversight across all regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Manus Sazon: ""I've already invited independent observers from Kyrute t..."*)

### Węzeł `[654]`
Mówca: **Daria de Rava**
> ""Moreover, centralizing the government, while it has led to a loss of autonomy for the regions, has allowed us to provide uniform oversight across all areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Daria de Rava: ""Rigorous identification checks will be key to making sur..."*)

### Węzeł `[655]`
Mówca: **Adarfo Sotelato**
> ""Moreover, centralizing power has allowed us to employ strict oversight across all regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Adarfo Sotelato: ""And we are strictly limiting campaign funding so that Ri..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Adarfo Sotelato: ""Moreover, centralizing power has allowed us to employ st..."*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Adarfo Sotelato: ""We'll need to take care to ensure uniformity across all ..."*)

### Węzeł `[659]`
Mówca: **Manus Sazon**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[660]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does the data say about voters' top issues?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == false`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_ElectionIssues = true;"*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_ElectionIssues == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Reform_ElectionIssues == false"*)
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Reform_ElectionIssues == false)"*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_ElectionIssues == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Player_Romus: ""What does the data say about voters' top issues?""*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Reform_ElectionIssues == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Reform_ElectionIssues = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[665]`
Mówca: **Narrator**
> "Daria's expression stiffens for a moment, but she maintained her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Daria de Rava: ""Oh, I know. I was worried it wasn’t big enough.""*)

### Węzeł `[666]`
Mówca: **Daria de Rava**
> ""Oh, I know. I was worried it wasn’t big enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Daria de Rava: ""Kidding aside, I believe leaders should be seen. The peo..."*)

### Węzeł `[667]`
Mówca: **Daria de Rava**
> ""Kidding aside, I believe leaders should be seen. The people deserve to know who they’re voting for. Simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Narrator: "She gestured outside."*)

### Węzeł `[668]`
Mówca: **Narrator**
> "She gestured outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Narrator: "Through the glass, I saw volunteers at a registration boo..."*)

### Węzeł `[669]`
Mówca: **Narrator**
> "Adarfo didn't flinch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Adarfo Sotelato: ""I considered something smaller, but then I thought -- wh..."*)

### Węzeł `[670]`
Mówca: **Adarfo Sotelato**
> ""I considered something smaller, but then I thought -- why disappoint?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Adarfo Sotelato: ""Seriously though, a leader should be seen. The people ne..."*)

### Węzeł `[671]`
Mówca: **Adarfo Sotelato**
> ""Seriously though, a leader should be seen. The people need to know who stands for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "He gestured outside."*)

### Węzeł `[672]`
Mówca: **Narrator**
> "He gestured outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Narrator: "Through the glass, I saw volunteers at a registration boo..."*)

### Węzeł `[673]`
Mówca: **Daria de Rava**
> ""Yes, Your Majesty. Everyone gets a voice in this -- equally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Narrator: "She gestured outside."*)

### Węzeł `[674]`
Mówca: **Narrator**
> "Adarfo smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Adarfo Sotelato: ""Yes, your vote counts -- just like everyone else's.""*)

### Węzeł `[675]`
Mówca: **Adarfo Sotelato**
> ""Yes, your vote counts -- just like everyone else's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "He gestured outside."*)

### Węzeł `[676]`
Mówca: **Adarfo Sotelato**
> ""Well, we can’t all rely on a crown to do the talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "He gestured outside."*)

### Węzeł `[677]`
Mówca: **Daria de Rava**
> ""A fair concern. But I believe the people see beyond the spectacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Narrator: "She gestured outside."*)

### Węzeł `[678]`
Mówca: **Narrator**
> "Through the glass, I saw volunteers at a registration booth outside the retirement community, guiding senior citizens through the process."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reform_Report_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Reform_Report_Hub"*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Narrator: "I was just fastening the last button of my coat when a fi..."*)

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for small talk. The hall of the people is waiting.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.NewGov_Reform_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_UpperHouse"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.NewGov_Reform_ElectionIssues"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[273]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would behoove you to remember that you are only Prime Minister because of my successful reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Adarfo Sotelato: ""I do thank you for keeping the noble houses from causing..."*)

### Węzeł `[683]`
Mówca: **Adarfo Sotelato**
> ""I understand. You'll adjust to your new role soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[684]`
Mówca: **Adarfo Sotelato**
> ""I do thank you for keeping the noble houses from causing trouble. But I or one of my comrades would have wound up in this car with or without you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[685]`
Mówca: **Adarfo Sotelato**
> ""I'm behind the wheel, Toras. You're just along for the ride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_Estranged == true)"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_Estranged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Player_Romus: ""How is Vina? She won't say a word to me.""*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_Estranged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Son == true"*)

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is Vina? She won't say a word to me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true` AND `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[401]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "Manus gave me a thin-lipped smile."*)

### Węzeł `[690]`
Mówca: **Narrator**
> "Manus gave me a thin-lipped smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Manus Sazon: ""She's apoplectic, of course, as is my mother. But they'l..."*)

### Węzeł `[691]`
Mówca: **Manus Sazon**
> ""She's apoplectic, of course, as is my mother. But they'll be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Manus Sazon: ""Don't tell the Princess, but I fully approve your decisi..."*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Son == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Son == true"*)
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Successor_Son == true)"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Son == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Successor_Son"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Player_Romus: ""About Vina's inheritance. I hope you know it's nothing p..."*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Successor_Son == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Successor_Son"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Player_Romus: ""How is Vina?""*)

### Węzeł `[695]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""About Vina's inheritance. I hope you know it's nothing personal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Successor_Son"] == true` AND `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false` AND `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[401]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Narrator: "Manus gave me a thin-lipped smile."*)

### Węzeł `[696]`
Mówca: **Narrator**
> "Manus gave me a thin-lipped smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Manus Sazon: ""Don't tell the Princess, but I fully approve your decisi..."*)

### Węzeł `[697]`
Mówca: **Manus Sazon**
> ""Don't tell the Princess, but I fully approve your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Manus Sazon: ""Rizia's heiress apparent married to the Prime Minister w..."*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_Estranged == true"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[701]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is Vina?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Successor_Son"] == true) == false` AND `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false` AND `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[401]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Narrator: "Manus gave me a patient smile."*)

### Węzeł `[702]`
Mówca: **Narrator**
> "Manus gave me a patient smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Manus Sazon: ""Your Majesty, I'd appreciate it if we saved such discuss..."*)

### Węzeł `[703]`
Mówca: **Manus Sazon**
> ""Your Majesty, I'd appreciate it if we saved such discussions for family occasions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Manus Sazon: ""The fact that Rizia's heiress apparent is married to the..."*)

### Węzeł `[704]`
Mówca: **Manus Sazon**
> ""The King of Rizia is to be respected, whether or not he leads the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Manus Sazon: ""The King of Rizia is to be respected, whether or not he ..."*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Daria de Rava: ""I would never disrespect the King of Rizia, Your Majesty.""*)

### Węzeł `[708]`
Mówca: **Daria de Rava**
> ""I would never disrespect the King of Rizia, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Manus Sazon: ""It's our people who determine the direction. We just tur..."*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Daria de Rava: ""I'm grateful to be allowed behind the wheel.""*)

### Węzeł `[712]`
Mówca: **Manus Sazon**
> ""It's our people who determine the direction. We just turn the wheel as they see fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[713]`
Mówca: **Daria de Rava**
> ""I'm grateful to be allowed behind the wheel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[714]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This feels odd. I'm not used to sharing a car.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Narrator), `[402]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Manus Sazon: ""Odd or not, this is the new order.""*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Daria de Rava: ""I never dreamed I'd ride side by side with the King of R..."*)

### Węzeł `[718]`
Mówca: **Manus Sazon**
> ""Odd or not, this is the new order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[719]`
Mówca: **Daria de Rava**
> ""I never dreamed I'd ride side by side with the King of Rizia, let alone have powers that supercede his.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[720]`
**[WYBÓR GRACZA: "Don't remark on it."]** — Mówca: **Player_Romus_Italic**
> "I said nothing. We rode on in silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Narrator), `[420]` (Narrator), `[423]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "Jump to: [Skip Election Talk]"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Skip Election Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "As we drove through the streets, I caught sight of a newl..."*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Skip Election Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "Skip Election Talk"*)

### Węzeł `[723]`
Mówca: **Narrator**
> "I was just fastening the last button of my coat when a firm knock on my chamber door caught my attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == true || RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[724]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing says ‘progress’ like swapping a sign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Narrator), `[767]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[725]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even the streets must bear witness to the new order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Narrator), `[767]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Let the city reflect its new reality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Narrator), `[767]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Huh. You couldn't come up with anything better?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Narrator), `[767]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[728]`
Mówca: **Adarfo Sotelato**
> ""Funny... a king admiring the handiwork of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Adarfo Sotelato: ""We’ll see if it truly represents all of us, or just the ..."*)

### Węzeł `[729]`
Mówca: **Adarfo Sotelato**
> ""One more thing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""No. Good day.""*)
  - -> `[459]` (*Player_Romus: ""If you want a good word from me about the elections, you..."*)
  - -> `[730]` (*Player_Romus: ""Yes?""*)

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[729]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "Daria stepped toward me."*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Adarfo Sotelato: ""I don't believe Rizia still needs a king. But our people..."*)

### Węzeł `[734]`
Mówca: **Adarfo Sotelato**
> ""I don't believe Rizia still needs a king. But our people do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Adarfo Sotelato: ""No matter how much I've tried to convince them otherwise..."*)

### Węzeł `[735]`
Mówca: **Adarfo Sotelato**
> ""No matter how much I've tried to convince them otherwise, some part of them is in thrall to the Crown and whoever's wearing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true |..."*)

### Węzeł `[736]`
Mówca: **Narrator**
> "He lowered his head in acknowledgement -- the closest he'd ever come to bowing to me -- before making his exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Narrator: "As the doors closed behind him, I took in the desolate room."*)

### Węzeł `[738]`
Mówca: **Narrator**
> "After a moment, the back door of the nearest car opened, and there he was, seated inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Adarfo Sotelato: ""Ah, *Your Majesty*, still haven’t learned to open your o..."*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Manus Sazon: ""Your electoral reforms set the stage for fair elections...."*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Manus Sazon: ""With our new Electoral Commission now fully operational,..."*)

### Węzeł `[742]`
Mówca: **Manus Sazon**
> ""Your electoral reforms set the stage for fair elections. We've also established an Electoral Commission to make the process more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[743]`
Mówca: **Manus Sazon**
> ""With our new Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Daria de Rava: ""Your electoral reforms may have dealt a blow to the RNC ..."*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Daria de Rava: ""We've established an Electoral Commission to oversee the..."*)

### Węzeł `[747]`
Mówca: **Daria de Rava**
> ""Your electoral reforms may have dealt a blow to the RNC at the time, but they did prime the populace to believe their vote is important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Daria de Rava: ""We've also established an Electoral Commission to overse..."*)

### Węzeł `[748]`
Mówca: **Daria de Rava**
> ""We've also established an Electoral Commission to oversee the process and eliminate the possibility of voter fraud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[749]`
Mówca: **Daria de Rava**
> ""We've established an Electoral Commission to oversee the process and eliminate the possibility of voter fraud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Adarfo Sotelato: ""Fortunately, your electoral reforms set the stage for fa..."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Adarfo Sotelato: ""With our new independent Electoral Commission now fully ..."*)

### Węzeł `[753]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, your electoral reforms set the stage for fair elections. And with our new independent Electoral Commission now fully operational, we’re almost finished training the officials who'll oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[754]`
Mówca: **Adarfo Sotelato**
> ""With our new independent Electoral Commission now fully operational, we’re almost finished training the officials who'll oversee the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[755]`
Mówca: **Manus Sazon**
> ""Obviously, care will need to be taken to ensure uniform oversight across our various provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Manus Sazon: ""I've already invited independent observers from Kyrute t..."*)

### Węzeł `[756]`
Mówca: **Daria de Rava**
> ""With Rizia still not centralized, care will need to be taken to ensure uniform oversight across our various provinces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Daria de Rava: ""Rigorous identification checks will be key to making sur..."*)

### Węzeł `[757]`
Mówca: **Adarfo Sotelato**
> ""We'll need to take care to ensure uniformity across all of Rizia's provinces, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Adarfo Sotelato: ""And we are strictly limiting campaign funding so that Ri..."*)

### Węzeł `[758]`
Mówca: **Manus Sazon**
> ""I've already invited independent observers from Kyrute to help count the votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[759]`
Mówca: **Daria de Rava**
> ""Rigorous identification checks will be key to making sure that only those Rizians who are qualified to vote do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[760]`
Mówca: **Adarfo Sotelato**
> ""And we are strictly limiting campaign funding so that Rizia's wealthy cannot exert undue influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[763]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "He was replacing the "King's Avenue" sign that had marked..."*)

### Węzeł `[763]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[764]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Narrator: "He was replacing the "King's Avenue" sign that had marked..."*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "He was scraping graffiti off the sign that marked the cit..."*)

### Węzeł `[767]`
Mówca: **Narrator**
> "He was replacing the "King's Avenue" sign that had marked the city's main thoroughfare for generations with "Revolution Road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Player_Romus: ""Good. Let the city reflect its new reality.""*)
  - -> `[724]` (*Player_Romus: ""Nothing says ‘progress’ like swapping a sign.""*)
  - -> `[725]` (*Player_Romus: ""Even the streets must bear witness to the new order.""*)
  - -> `[727]` (*Player_Romus: ""Huh. You couldn't come up with anything better?""*)

### Węzeł `[768]`
Mówca: **Narrator**
> "He was scraping graffiti off the sign that marked the city's main thoroughfare, King's Avenue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Daria followed my gaze and cleared her throat."*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Skip Election Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "Skip Election Talk"*)

### Węzeł `[770]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May Rizia's next prime minister have the integrity to carry out its words.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[444]` (Manus Sazon), `[532]` (Daria de Rava), `[533]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "I looked it over a moment longer before turning toward th..."*)

### Węzeł `[771]`
Mówca: **Adarfo Sotelato**
> ""I get it. And I'm looking forward to working together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Player_Romus: ""Good luck with your campaign.""*)
  - -> `[795]` (*Player_Romus: ""Work on your attitude first.""*)
  - -> `[799]` (*Player_Romus: ""Likewise, Mr. Prime Minister. You have my endorsement.""*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)

### Węzeł `[772]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == false"*)
  - -> `[774]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == false)"*)

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[774]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Adarfo Sotelato: ""Ha. No, nothing of the sort.""*)

### Węzeł `[775]`
Mówca: **Adarfo Sotelato**
> ""Ha. No, nothing of the sort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Adarfo Sotelato: ""I don't believe Rizia still needs a king. But our people..."*)

### Węzeł `[776]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_LivingStandards_Great`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true |..."*)
  - -> `[778]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true..."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_LivingStandards_Great`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Adarfo Sotelato: ""To your credit, you've done a lot for them. But even if ..."*)

### Węzeł `[778]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_LivingStandards_Great)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true |..."*)

### Węzeł `[779]`
Mówca: **Adarfo Sotelato**
> ""To your credit, you've done a lot for them. But even if you hadn't, they'd still worship the ground you walk on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Player_Romus: ""You say that like it's a good thing. Truth be told, the ..."*)
  - -> `[786]` (*Player_Romus: ""And you want them to worship you instead?""*)
  - -> `[791]` (*Player_Romus: ""I know it's not fair. But Rizia can't shake off a thousa..."*)
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[780]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_LivingStandards_Great`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Good == true |..."*)
  - -> `[782]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true..."*)

### Węzeł `[781]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_LivingStandards_Great`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Adarfo Sotelato: ""You've hardly lifted a finger to improve their standing,..."*)

### Węzeł `[782]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Good == true || RiziaDLC.Situation_Welfare_LivingStandards_Great)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Adarfo Sotelato: ""It doesn't matter that you've treated them like shit. Th..."*)

### Węzeł `[783]`
Mówca: **Adarfo Sotelato**
> ""It doesn't matter that you've treated them like shit. They'll still worship the ground you walk on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Player_Romus: ""You say that like it's a good thing. Truth be told, the ..."*)
  - -> `[786]` (*Player_Romus: ""And you want them to worship you instead?""*)
  - -> `[791]` (*Player_Romus: ""I know it's not fair. But Rizia can't shake off a thousa..."*)
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[784]`
Mówca: **Adarfo Sotelato**
> ""You've hardly lifted a finger to improve their standing, and they still worship the ground you walk on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Player_Romus: ""You say that like it's a good thing. Truth be told, the ..."*)
  - -> `[786]` (*Player_Romus: ""And you want them to worship you instead?""*)
  - -> `[791]` (*Player_Romus: ""I know it's not fair. But Rizia can't shake off a thousa..."*)
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[785]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You say that like it's a good thing. Truth be told, the constant pressure to live up to their expectations is killing me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[779]` (Adarfo Sotelato), `[783]` (Adarfo Sotelato), `[784]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Adarfo Sotelato: ""Nobody's forcing you to stay on the throne, you know.""*)

### Węzeł `[786]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you want them to worship you instead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[779]` (Adarfo Sotelato), `[783]` (Adarfo Sotelato), `[784]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Adarfo Sotelato: ""No. I want us to work together.""*)

### Węzeł `[787]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I am a superior specimen of a human being.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[779]` (Adarfo Sotelato), `[783]` (Adarfo Sotelato), `[784]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Narrator: "He rolled his eyes."*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Player_Romus: ""Well, I am a superior specimen of a human being.""*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[791]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know it's not fair. But Rizia can't shake off a thousand years of royal tradition just because you say so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[779]` (Adarfo Sotelato), `[783]` (Adarfo Sotelato), `[784]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Adarfo Sotelato: ""I get it. And I'm looking forward to working together.""*)

### Węzeł `[792]`
Mówca: **Adarfo Sotelato**
> ""No. I want us to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Player_Romus: ""Good luck with your campaign.""*)
  - -> `[795]` (*Player_Romus: ""Work on your attitude first.""*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)

### Węzeł `[793]`
Mówca: **Adarfo Sotelato**
> ""Nobody's forcing you to stay on the throne, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Adarfo Sotelato: ""But if you do stick around, I'm looking forward to worki..."*)

### Węzeł `[794]`
Mówca: **Adarfo Sotelato**
> ""But if you do stick around, I'm looking forward to working together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Player_Romus: ""Good luck with your campaign.""*)
  - -> `[795]` (*Player_Romus: ""Work on your attitude first.""*)
  - -> `[799]` (*Player_Romus: ""Likewise, Mr. Prime Minister. You have my endorsement.""*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)

### Węzeł `[795]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Work on your attitude first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[771]` (Adarfo Sotelato), `[792]` (Adarfo Sotelato), `[794]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Narrator: "With a short, rueful laugh, he made his exit."*)

### Węzeł `[796]`
Mówca: **Narrator**
> "He rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Adarfo Sotelato: ""I'm trying to say that I'm looking forward to working to..."*)

### Węzeł `[797]`
Mówca: **Adarfo Sotelato**
> ""I'm trying to say that I'm looking forward to working together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Player_Romus: ""Good luck with your campaign.""*)
  - -> `[795]` (*Player_Romus: ""Work on your attitude first.""*)
  - -> `[799]` (*Player_Romus: ""Likewise, Mr. Prime Minister. You have my endorsement.""*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)

### Węzeł `[798]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good luck with your campaign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[771]` (Adarfo Sotelato), `[792]` (Adarfo Sotelato), `[794]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Narrator: "He nodded in acknowledgement before making his exit."*)

### Węzeł `[799]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Likewise, Mr. Prime Minister. You have my endorsement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[771]` (Adarfo Sotelato), `[794]` (Adarfo Sotelato), `[797]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.TalkWithPM_EndorseAdarfo = true; RiziaDLCSupport..."*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_DidntRatifyTreaty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)
  - -> `[802]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_DidntRatifyTreaty == true)"*)

### Węzeł `[801]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_DidntRatifyTreaty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Player_Romus: ""You signed a major treaty without my approval. You can f..."*)

### Węzeł `[802]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_DidntRatifyTreaty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[803]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You signed a major treaty without my approval. You can fuck right off.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true`
- **Kontekst wejściowy (poprzednik):** `[771]` (Adarfo Sotelato), `[792]` (Adarfo Sotelato), `[794]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Narrator: "Anger flashed in his eyes. Without another word, he made ..."*)

### Węzeł `[804]`
Mówca: **Narrator**
> "Anger flashed in his eyes. Without another word, he made his exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[805]`
Mówca: **Narrator**
> "With a short, rueful laugh, he made his exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[806]`
Mówca: **Narrator**
> "He nodded in acknowledgement before making his exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.TalkWithPM_EndorseAdarfo = true; RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Adarfo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.TalkWithPM_EndorseAdarfo"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Narrator: "He lowered his head in acknowledgement -- the closest he'..."*)

### Węzeł `[808]`
Mówca: **Manus Sazon**
> ""The fact that Rizia's heiress apparent is married to the Prime Minister is already raising questions about the legitimacy of our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[809]`
Mówca: **Manus Sazon**
> ""Rizia's heiress apparent married to the Prime Minister would've raised questions about the legitimacy of our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Before long, the motorcade was on its way, leaving the pa..."*)

### Węzeł `[810]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)
  - -> `[812]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction == true)"*)

### Węzeł `[811]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Narrator: "The motorcade soon pulled up to the House of Delegates' e..."*)

### Węzeł `[812]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "The motorcade soon pulled up to the House of Delegates' e..."*)

### Węzeł `[813]`
Mówca: **Narrator**
> "The motorcade soon pulled up to the House of Delegates' entrance. We were flanked by local law enforcement and a few guards from Palantor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "A crowd of reporters and onlookers surrounded the entrance."*)

### Węzeł `[814]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_NoOne = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_Endorse_NoOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_TalkWithPM_ManusElectionsUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_ManusElectionsUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[818]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[817]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_TalkWithPM_ManusElectionsU..."*)

### Węzeł `[818]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_TalkWithPM_DariaElectionsU..."*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_TalkWithPM_AdarfoElections..."*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_TalkWithPM_DariaElectionsUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_DariaElectionsUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_TalkWithPM_AdarfoElectionsUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_TalkWithPM_AdarfoElectionsUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[825]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Manus = true; R..."*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Daria = true; R..."*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Adarfo = true; ..."*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Manus = true; RiziaDLCSupport.News_Turn10_V_TalkWithPM_Manus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Manus"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_TalkWithPM_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 2;"*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Daria = true; RiziaDLCSupport.News_Turn10_V_TalkWithPM_Daria = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Daria"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_TalkWithPM_Daria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 2;"*)

### Węzeł `[832]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Adarfo = true; RiziaDLCSupport.News_Turn10_V_TalkWithPM_Adarfo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_TalkWithPM_Adarfo"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_TalkWithPM_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 2;"*)

### Węzeł `[833]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "End();"*)
