# Rizia/Turn 9/A_ZilleReturnedSpeech

- **ID konwersacji:** `440`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/440_A_ZilleReturnedSpeech.md`
- **Liczba węzłów dialogowych:** 319
- **Liczba wyborów gracza:** 76

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Diplomacy_Wehlen_FundBFF`
- `RiziaDLC.Policy_Economy_IncomeTax10`
- `RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax`
- `RiziaDLC.Prologue_Summer_Zille`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Resources_Military_DerdianMercenaries_Zille`
- `RiziaDLC.Resources_Military_RumburgianBFFMercenaries`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Success`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Success`
- `RiziaDLC.ZilleReferendum_StoppedByAN`
- `RiziaDLC.ZilleReferendum_Won`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Authority_Modifier_TerritorialReclaimation`
- `RiziaDLC.Budget_Modifier_IncomeTax`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_Diplomacy_ZLLAActive`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleOwnership_RiziaImperii`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii`
- `RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome`
- `RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToBrenas`
- `RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToRiziaImperii`
- `RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival`
- `RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""My esteemed subjects, today marks a momentous occasion in the history of our grea..."** | `[181]` **Narrator**: "The applause subsided. I began t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Player_Romus**: ""After a prolonged period of est..."<br>`[11]` **Player_Romus**: ""For it was the Crown's strength..."<br>*(oraz 1 innych odgałęzień)* |
| `[4]` | **""The strength and fortitude of those living under Wehlen's yoke has been an inspir..."** | `[7]` **Player_Romus**: ""After a prolonged period of est..."<br>`[23]` **Player_Romus**: ""The path before us was arduous,..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: ""Looking back on what you endure..."<br>`[8]` **Player_Romus**: ""But let's not dwell on the tria..."<br>*(oraz 1 innych odgałęzień)* |
| `[5]` | **""Together, we will march forward into the annals of history, hand in hand, as prou..."** | `[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>`[15]` **Player_Romus**: ""And so, my loyal subjects, let ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd2");` | `[97]` **Narrator**: "As I finished my speech, the cro..." |
| `[6]` | **""With Zille's return, we stand poised to achieve greatness beyond measure, as one ..."** | `[234]` **Narrator**: "I motioned for the crowd to quie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player_Romus**: ""So let us honor the memories of..."<br>`[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>*(oraz 2 innych odgałęzień)* |
| `[7]` | **""After a prolonged period of estrangement, Zille is finally returning home.""** | `[3]` **Player_Romus**: ""My esteemed subjects, today mar..."<br>`[10]` **Player_Romus**: ""Citizens of Zille, let us revel..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>`[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""But let's not dwell on the trials of the past, but rather look towards the promis..."** | `[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>`[12]` **Player_Romus**: ""To those who stood with us in o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Cheers erupted once more." |
| `[9]` | **""Therefore, raise your voices in celebration, for today marks the dawn of a new er..."** | `[6]` **Player_Romus**: ""With Zille's return, we stand p..."<br>`[14]` **Player_Romus**: ""The return of Zille serves as a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Player_Romus**: ""May the sacrifices of those who..."<br>`[5]` **Player_Romus**: ""Together, we will march forward..."<br>*(oraz 2 innych odgałęzień)* |
| `[10]` | **""Citizens of Zille, let us revel in the glory of our triumph over the iron fist of..."** | `[181]` **Narrator**: "The applause subsided. I began t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Player_Romus**: ""After a prolonged period of est..."<br>`[11]` **Player_Romus**: ""For it was the Crown's strength..."<br>*(oraz 1 innych odgałęzień)* |
| `[11]` | **""For it was the Crown's strength and determination that secured this victory.""** | `[3]` **Player_Romus**: ""My esteemed subjects, today mar..."<br>`[10]` **Player_Romus**: ""Citizens of Zille, let us revel..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>`[12]` **Player_Romus**: ""To those who stood with us in o..."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **""To those who stood with us in our quest to reclaim what is rightfully ours. Your ..."** | `[7]` **Player_Romus**: ""After a prolonged period of est..."<br>`[11]` **Player_Romus**: ""For it was the Crown's strength..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: ""Looking back on what you endure..."<br>`[8]` **Player_Romus**: ""But let's not dwell on the tria..."<br>*(oraz 2 innych odgałęzień)* |
| `[13]` | **""As one nation, united under our banner, we shall forge a future of unparalleled g..."** | `[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>`[12]` **Player_Romus**: ""To those who stood with us in o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Cheers erupted once more." |
| `[14]` | **""The return of Zille serves as a testament to the strength of the monarchy and the..."** | `[234]` **Narrator**: "I motioned for the crowd to quie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>`[15]` **Player_Romus**: ""And so, my loyal subjects, let ..."<br>*(oraz 1 innych odgałęzień)* |
| `[15]` | **""And so, my loyal subjects, let us seize this moment as an opportunity to reaffirm..."** | `[6]` **Player_Romus**: ""With Zille's return, we stand p..."<br>`[14]` **Player_Romus**: ""The return of Zille serves as a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Player_Romus**: ""Together, we will march forward..."<br>`[16]` **Player_Romus**: ""As one, we shall crush all who ..."<br>*(oraz 1 innych odgałęzień)* |
| `[16]` | **""As one, we shall crush all who would dare to defy us and cement our legacy as the..."** | `[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>`[15]` **Player_Romus**: ""And so, my loyal subjects, let ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd2");` | `[97]` **Narrator**: "As I finished my speech, the cro..." |
| `[17]` | **""My subjects, today brings a somber moment as we witness the return of Zille, a la..."** | `[181]` **Narrator**: "The applause subsided. I began t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player_Romus**: ""However, it was through our end..."<br>`[24]` **Player_Romus**: ""Yet, it was through the strengt..."<br>*(oraz 3 innych odgałęzień)* |
| `[18]` | **""To the resilient people of Zille, I offer my deepest sympathies. Your resilience ..."** | `[7]` **Player_Romus**: ""After a prolonged period of est..."<br>`[11]` **Player_Romus**: ""For it was the Crown's strength..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: ""Looking back on what you endure..."<br>`[8]` **Player_Romus**: ""But let's not dwell on the tria..."<br>*(oraz 2 innych odgałęzień)* |
| `[19]` | **""Looking back on what you endured, remember the solidarity that sustained you. In ..."** | `[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>`[12]` **Player_Romus**: ""To those who stood with us in o..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Cheers erupted once more." |
| `[20]` | **""While the road to liberation was fraught with challenges, overcoming those hardsh..."** | `[234]` **Narrator**: "I motioned for the crowd to quie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player_Romus**: ""So let us honor the memories of..."<br>`[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>*(oraz 2 innych odgałęzień)* |
| `[21]` | **""So let us honor the memories of those we have lost and the dreams that have been ..."** | `[6]` **Player_Romus**: ""With Zille's return, we stand p..."<br>`[20]` **Player_Romus**: ""While the road to liberation wa..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Player_Romus**: ""May the sacrifices of those who..."<br>`[5]` **Player_Romus**: ""Together, we will march forward..."<br>*(oraz 2 innych odgałęzień)* |
| `[22]` | **""May the sacrifices of those who fought for freedom guide us forward with resilien..."** | `[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>`[21]` **Player_Romus**: ""So let us honor the memories of..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd2");` | `[97]` **Narrator**: "As I finished my speech, the cro..." |
| `[23]` | **""The path before us was arduous, but in the end, we persevered.""** | `[17]` **Player_Romus**: ""My subjects, today brings a som..."<br>`[26]` **Player_Romus**: ""Dear brethren, today heralds a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>`[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>*(oraz 2 innych odgałęzień)* |
| `[24]` | **""Yet, it was through the strength and determination of the Crown that this victory..."** | `[17]` **Player_Romus**: ""My subjects, today brings a som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>`[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>*(oraz 1 innych odgałęzień)* |
| `[25]` | **""To our brothers and sisters in Zille, I offer my humble prayers and deepest bless..."** | `[7]` **Player_Romus**: ""After a prolonged period of est..."<br>`[11]` **Player_Romus**: ""For it was the Crown's strength..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: ""Looking back on what you endure..."<br>`[8]` **Player_Romus**: ""But let's not dwell on the tria..."<br>*(oraz 2 innych odgałęzień)* |
| `[26]` | **""Dear brethren, today heralds a sacred moment as we witness the return of Zille.""** | `[181]` **Narrator**: "The applause subsided. I began t..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[23]` **Player_Romus**: ""The path before us was arduous,..."<br>`[7]` **Player_Romus**: ""After a prolonged period of est..."<br>*(oraz 2 innych odgałęzień)* |
| `[30]` | **""For it was through our enduring faith in the Almighty that this victory has been ..."** | `[3]` **Player_Romus**: ""My esteemed subjects, today mar..."<br>`[10]` **Player_Romus**: ""Citizens of Zille, let us revel..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>`[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>*(oraz 1 innych odgałęzień)* |
| `[31]` | **""However, it was through our enduring faith in the Almighty that this triumph has ..."** | `[17]` **Player_Romus**: ""My subjects, today brings a som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>`[4]` **Player_Romus**: ""The strength and fortitude of t..."<br>*(oraz 1 innych odgałęzień)* |
| `[32]` | **""United in our devotion and reverence, let us give thanks for the divine grace tha..."** | `[12]` **Player_Romus**: ""To those who stood with us in o..."<br>`[18]` **Player_Romus**: ""To the resilient people of Zill..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Cheers erupted once more." |
| `[33]` | **""Together, we'll walk the path of righteousness, guided by the eternal light of ou..."** | `[234]` **Narrator**: "I motioned for the crowd to quie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player_Romus**: ""So let us honor the memories of..."<br>`[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>*(oraz 2 innych odgałęzień)* |
| `[34]` | **""In conclusion, we extend prayers of gratitude and thanksgiving for the divine ble..."** | `[6]` **Player_Romus**: ""With Zille's return, we stand p..."<br>`[14]` **Player_Romus**: ""The return of Zille serves as a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Player_Romus**: ""May the sacrifices of those who..."<br>`[5]` **Player_Romus**: ""Together, we will march forward..."<br>*(oraz 2 innych odgałęzień)* |
| `[35]` | **""And may our faith continue to strengthen us as we embark on this sacred journey t..."** | `[9]` **Player_Romus**: ""Therefore, raise your voices in..."<br>`[15]` **Player_Romus**: ""And so, my loyal subjects, let ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd2");` | `[97]` **Narrator**: "As I finished my speech, the cro..." |
| `[38]` | **""We'll fix it up so that it's exactly the way that it was.""** | `[37]` **Estela Toras**: ""I really have missed this place..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Estela Toras**: ""Nothing will be exactly the way..." |
| `[39]` | **""It was a difficult time for all of us. But it's over now.""** | `[274]` **Estela Toras**: ""I look forward to the day when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Estela Toras**: ""Thank Dast for that."" |
| `[40]` | **""I understand. Father's decision to hand over Zille to Wehlen cast a shadow over m..."** | `[274]` **Estela Toras**: ""I look forward to the day when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Estela Toras**: ""Consider the shadow lifted."" |
| `[47]` | **""It was my duty, Mother. For our kingdom, and for our family.""** | `[134]` **Estela Toras**: ""Even if you had to resort to ra..."<br>`[63]` **Estela Toras**: ""I'm proud of you, son. If not f..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false` | *Brak zmian stanu* | `[51]` **Estela Toras**: ""And you fulfilled that duty adm..." |
| `[48]` | **""Glad I could step in where Father fell short. Wouldn't want his legacy tarnished ..."** | `[134]` **Estela Toras**: ""Even if you had to resort to ra..."<br>`[63]` **Estela Toras**: ""I'm proud of you, son. If not f..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false` | *Brak zmian stanu* | `[68]` **Estela Toras**: ""His legacy may have had its fla..." |
| `[49]` | **""That's very kind of you to say. I'm truly touched.""** | `[134]` **Estela Toras**: ""Even if you had to resort to ra..."<br>`[63]` **Estela Toras**: ""I'm proud of you, son. If not f..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`<br>`(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false` | *Brak zmian stanu* | `[67]` **Estela Toras**: ""Well, I wouldn't say it if it w..." |
| `[50]` | **""Zille belongs with us. Plain and simple.""** | `[134]` **Estela Toras**: ""Even if you had to resort to ra..."<br>`[63]` **Estela Toras**: ""I'm proud of you, son. If not f..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false` | *Brak zmian stanu* | `[70]` **Estela Toras**: ""The only thing left to do now i..." |
| `[55]` | **""Zille.""** | `[36]` **Narrator**: "The familiar scent of saltwater ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "Mother briefly paused when she r..." |
| `[56]` | **""I never thought I'd see the day...""** | `[37]` **Estela Toras**: ""I really have missed this place..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Estela Toras**: ""Personally, I had no doubt in m..." |
| `[57]` | **""The pain of what King Valero let us lose, you mean.""** | `[274]` **Estela Toras**: ""I look forward to the day when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Estela Toras**: ""Don't speak ill of your father...." |
| `[64]` | **""Trust me, Mother, you had it easy compared to the rest of us. And by us, I mean me.""** | `[274]` **Estela Toras**: ""I look forward to the day when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Estela Toras**: ""Well, forgive me for not sheddi..." |
| `[79]` | **""True change comes from within. Our focus should be on uplifting people's spirits ..."** | `[82]` **Estela Toras**: ""You should have the square's na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Estela Toras**: ""If that's what you believe, dea..." |
| `[80]` | **""Back to Fedo Square?""** | `[82]` **Estela Toras**: ""You should have the square's na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Estela Toras**: ""The Sazons would love that, I'm..." |
| `[81]` | **""It's best we keep it as is. Knowing Smolak, it'd be sure to cause an internationa..."** | `[82]` **Estela Toras**: ""You should have the square's na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Estela Toras**: ""If renaming a square is all it ..." |
| `[83]` | **""You're absolutely right, Mother. It's time to rid our city of reminders of the pa..."** | `[82]` **Estela Toras**: ""You should have the square's na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Estela Toras**: ""Good. The last thing we'd want ..." |
| `[88]` | **""Thank you. I'll do my best to represent our kingdom with dignity and grace as you..."** | `[78]` **Estela Toras**: ""Good luck."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "A smile graced her lips before s..." |
| `[89]` | **""Luck is for the weak, Mother. But thanks all the same.""** | `[78]` **Estela Toras**: ""Good luck."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Mother rolled he eyes and shook ..." |
| `[90]` | **""'Good luck?' Please... I make my own luck.""** | `[78]` **Estela Toras**: ""Good luck."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Mother rolled her eyes and shook..." |
| `[91]` | **""I appreciate the sentiment, Mother. May the divine light guide my words and actio..."** | `[78]` **Estela Toras**: ""Good luck."" | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "A gentle smile adorned her face ..." |
| `[107]` | **""Would you rather that all of Zille belonged to him?""** | `[106]` **Estela Toras**: ""So it's Smolak's house now. I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Estela Toras**: ""Of course not. But this parting..." |
| `[111]` | **""I truly regret promising it to him. But it was the only option left after years o..."** | `[106]` **Estela Toras**: ""So it's Smolak's house now. I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Estela Toras**: ""He was toying with you, Romus. ..." |
| `[112]` | **""It was falling apart anyway. You'd never have moved back in.""** | `[106]` **Estela Toras**: ""So it's Smolak's house now. I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Estela Toras**: ""You know that's not the point, ..." |
| `[113]` | **""It wasn't a one-sided bargain. Did you see the doorstopper he gave me?""** | `[106]` **Estela Toras**: ""So it's Smolak's house now. I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Estela Toras**: ""Oh, I saw it, all right. No but..." |
| `[129]` | **"Instruct security to remove them."** | `[316]` **Narrator**: "They were shouting that the will..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[77]` **Narrator**: "It wasn't long before I was led ..." |
| `[138]` | **""I appreciate your sentiments, but let's not overlook the people of Zille. Their v..."** | `[134]` **Estela Toras**: ""Even if you had to resort to ra..."<br>`[63]` **Estela Toras**: ""I'm proud of you, son. If not f..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.ZilleReferendum_Won"] == true`<br>`(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false` | *Brak zmian stanu* | `[143]` **Estela Toras**: ""Ah, yes, the power of this so-c..."<br>`[139]` **Estela Toras**: ""Their resilience was truly rema..." |
| `[162]` | **"Ignore them."** | `[316]` **Narrator**: "They were shouting that the will..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[77]` **Narrator**: "It wasn't long before I was led ..." |
| `[187]` | **""As you all know, Zille has historically been a vital part of the province of Bren..."** | `[186]` **Narrator**: "Cheers erupted once more." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Player_Romus**: ""It is with joy that I announce ..."<br>`[198]` **Player_Romus**: ""However, returning it outright ..."<br>*(oraz 2 innych odgałęzień)* |
| `[188]` | **""I thank the members of House Sazon for their patience in awaiting the return of t..."** | `[186]` **Narrator**: "Cheers erupted once more." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Player_Romus**: ""It is with joy that I announce ..."<br>`[198]` **Player_Romus**: ""However, returning it outright ..."<br>*(oraz 1 innych odgałęzień)* |
| `[189]` | **""We must not forget the reason we lost Zille in the first place. Because of the re..."** | `[186]` **Narrator**: "Cheers erupted once more." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Player_Romus**: ""However, I'm a forgiving king. ..."<br>`[197]` **Player_Romus**: ""To return it to the Sazons woul..."<br>*(oraz 2 innych odgałęzień)* |
| `[190]` | **""I myself attach many happy childhood memories to Zille. It holds a special place ..."** | `[186]` **Narrator**: "Cheers erupted once more." | `Variable["RiziaDLC.Prologue_Summer_Zille"] == true` | *Brak zmian stanu* | `[209]` **Player_Romus**: ""I hope that House Sazon will ta..."<br>`[211]` **Player_Romus**: ""It is with joy in my heart that..."<br>*(oraz 2 innych odgałęzień)* |
| `[194]` | **""I myself am one-half Zillean. This region holds a special place in my heart and t..."** | `[186]` **Narrator**: "Cheers erupted once more." | `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false` | *Brak zmian stanu* | `[209]` **Player_Romus**: ""I hope that House Sazon will ta..."<br>`[211]` **Player_Romus**: ""It is with joy in my heart that..."<br>*(oraz 2 innych odgałęzień)* |
| `[195]` | **""It is with joy that I announce the return of Zille to its original custodians, Br..."** | `[187]` **Player_Romus**: ""As you all know, Zille has hist..."<br>`[188]` **Player_Romus**: ""I thank the members of House Sa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true; Variab...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[228]` **Narrator**: "Angelica Sazon stood and applaud..." |
| `[196]` | **""However, I'm a forgiving king. Therefore, I announce the return of this land to i..."** | `[189]` **Player_Romus**: ""We must not forget the reason w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true; Variab...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[228]` **Narrator**: "Angelica Sazon stood and applaud..." |
| `[197]` | **""To return it to the Sazons would reward their misdeeds. I therefore announce that..."** | `[189]` **Player_Romus**: ""We must not forget the reason w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true; ...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[218]` **Narrator**: "There was some applause from the..." |
| `[198]` | **""However, returning it outright would reward the Sazons for their misdeeds. Theref..."** | `[187]` **Player_Romus**: ""As you all know, Zille has hist..."<br>`[188]` **Player_Romus**: ""I thank the members of House Sa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true; ...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[218]` **Narrator**: "There was some applause from the..." |
| `[199]` | **""But in these precarious times, we need unity, not feudalism. Zille shall be guide..."** | `[187]` **Player_Romus**: ""As you all know, Zille has hist..."<br>`[188]` **Player_Romus**: ""I thank the members of House Sa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true; ...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[218]` **Narrator**: "There was some applause from the..." |
| `[200]` | **""But in these precarious times, we need unity, not feudalism. Zille shall be firml..."** | `[189]` **Player_Romus**: ""We must not forget the reason w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true; ...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[218]` **Narrator**: "There was some applause from the..." |
| `[201]` | **""In the meantime, the Sazons have proven themselves to be great allies. I shall th..."** | `[189]` **Player_Romus**: ""We must not forget the reason w..." | `Variable["RiziaDLC.Country_HouseSazon"] > 2  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true; Variab...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[228]` **Narrator**: "Angelica Sazon stood and applaud..." |
| `[208]` | **"And now that House Sazon and House Toras are reconciled, I find it only fitting to..."** | `[187]` **Player_Romus**: ""As you all know, Zille has hist..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true; Variab...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[228]` **Narrator**: "Angelica Sazon stood and applaud..." |
| `[209]` | **""I hope that House Sazon will take good care of it once it is reincorporated into ..."** | `[190]` **Player_Romus**: ""I myself attach many happy chil..."<br>`[194]` **Player_Romus**: ""I myself am one-half Zillean. T..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true; Variab...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[228]` **Narrator**: "Angelica Sazon stood and applaud..." |
| `[210]` | **""I, therefore, cannot simply hand it back to House Sazon and Brenas. It will belon..."** | `[190]` **Player_Romus**: ""I myself attach many happy chil..."<br>`[194]` **Player_Romus**: ""I myself am one-half Zillean. T..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true; ...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[218]` **Narrator**: "There was some applause from the..." |
| `[211]` | **""It is with joy in my heart that I announce the return of Zille to its original cu..."** | `[190]` **Player_Romus**: ""I myself attach many happy chil..."<br>`[194]` **Player_Romus**: ""I myself am one-half Zillean. T..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true; Variab...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[228]` **Narrator**: "Angelica Sazon stood and applaud..." |
| `[212]` | **""In that spirit, and in the interest of promoting unity over feudalism, Zille shal..."** | `[190]` **Player_Romus**: ""I myself attach many happy chil..."<br>`[194]` **Player_Romus**: ""I myself am one-half Zillean. T..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true; ...`<br>`AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_...`<br>*(+1 skryptów)* | `[218]` **Narrator**: "There was some applause from the..." |
| `[266]` | **""We'll turn it into a magnificent villa. The Queen Mother's very own luxury retreat.""** | `[37]` **Estela Toras**: ""I really have missed this place..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Narrator**: "She shook her head." |
| `[267]` | **""You and me both.""** | `[37]` **Estela Toras**: ""I really have missed this place..." | `Variable["RiziaDLC.Prologue_Summer_Zille"] == true` | *Brak zmian stanu* | `[271]` **Estela Toras**: ""I'm glad you're as attached to ..." |
| `[278]` | **""Don't get too used to it. I gave the Sords permission to turn the house into anot..."** | `[37]` **Estela Toras**: ""I really have missed this place..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true  and  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true` | *Brak zmian stanu* | `[279]` **Narrator**: "She stared daggers at me." |

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
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Proclaiming the return of Zille", "Smola..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My esteemed subjects, today marks a momentous occasion in the history of our great realm.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""After a prolonged period of estrangement, Zille is final..."*)
  - -> `[11]` (*Player_Romus: ""For it was the Crown's strength and determination that s..."*)
  - -> `[30]` (*Player_Romus: ""For it was through our enduring faith in the Almighty th..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The strength and fortitude of those living under Wehlen's yoke has been an inspiration to us all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[23]` (Player_Romus), `[24]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Looking back on what you endured, remember the solidarit..."*)
  - -> `[8]` (*Player_Romus: ""But let's not dwell on the trials of the past, but rathe..."*)
  - -> `[13]` (*Player_Romus: ""As one nation, united under our banner, we shall forge a..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we will march forward into the annals of history, hand in hand, as proud citizens of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Player_Romus), `[15]` (Player_Romus), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd2");"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Zille's return, we stand poised to achieve greatness beyond measure, as one people, one kingdom, united in purpose.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""So let us honor the memories of those we have lost and t..."*)
  - -> `[9]` (*Player_Romus: ""Therefore, raise your voices in celebration, for today m..."*)
  - -> `[15]` (*Player_Romus: ""And so, my loyal subjects, let us seize this moment as a..."*)
  - -> `[34]` (*Player_Romus: ""In conclusion, we extend prayers of gratitude and thanks..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After a prolonged period of estrangement, Zille is finally returning home.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[10]` (Player_Romus), `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""To the resilient people of Zille, I offer my deepest sym..."*)
  - -> `[4]` (*Player_Romus: ""The strength and fortitude of those living under Wehlen'..."*)
  - -> `[12]` (*Player_Romus: ""To those who stood with us in our quest to reclaim what ..."*)
  - -> `[25]` (*Player_Romus: ""To our brothers and sisters in Zille, I offer my humble ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But let's not dwell on the trials of the past, but rather look towards the promise of a future forged in unity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[12]` (Player_Romus), `[18]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Cheers erupted once more."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Therefore, raise your voices in celebration, for today marks the dawn of a new era for our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[14]` (Player_Romus), `[20]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""May the sacrifices of those who fought for freedom guide..."*)
  - -> `[5]` (*Player_Romus: ""Together, we will march forward into the annals of histo..."*)
  - -> `[16]` (*Player_Romus: ""As one, we shall crush all who would dare to defy us and..."*)
  - -> `[35]` (*Player_Romus: ""And may our faith continue to strengthen us as we embark..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Citizens of Zille, let us revel in the glory of our triumph over the iron fist of Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""After a prolonged period of estrangement, Zille is final..."*)
  - -> `[11]` (*Player_Romus: ""For it was the Crown's strength and determination that s..."*)
  - -> `[30]` (*Player_Romus: ""For it was through our enduring faith in the Almighty th..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For it was the Crown's strength and determination that secured this victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[10]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""To the resilient people of Zille, I offer my deepest sym..."*)
  - -> `[12]` (*Player_Romus: ""To those who stood with us in our quest to reclaim what ..."*)
  - -> `[25]` (*Player_Romus: ""To our brothers and sisters in Zille, I offer my humble ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To those who stood with us in our quest to reclaim what is rightfully ours. Your loyalty shall be remembered and rewarded.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[11]` (Player_Romus), `[23]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Looking back on what you endured, remember the solidarit..."*)
  - -> `[8]` (*Player_Romus: ""But let's not dwell on the trials of the past, but rathe..."*)
  - -> `[13]` (*Player_Romus: ""As one nation, united under our banner, we shall forge a..."*)
  - -> `[32]` (*Player_Romus: ""United in our devotion and reverence, let us give thanks..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As one nation, united under our banner, we shall forge a future of unparalleled greatness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[12]` (Player_Romus), `[18]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Cheers erupted once more."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The return of Zille serves as a testament to the strength of the monarchy and the inevitability of our victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""Therefore, raise your voices in celebration, for today m..."*)
  - -> `[15]` (*Player_Romus: ""And so, my loyal subjects, let us seize this moment as a..."*)
  - -> `[34]` (*Player_Romus: ""In conclusion, we extend prayers of gratitude and thanks..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And so, my loyal subjects, let us seize this moment as an opportunity to reaffirm our commitment to our kingdom's unmatched dominance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[14]` (Player_Romus), `[20]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""Together, we will march forward into the annals of histo..."*)
  - -> `[16]` (*Player_Romus: ""As one, we shall crush all who would dare to defy us and..."*)
  - -> `[35]` (*Player_Romus: ""And may our faith continue to strengthen us as we embark..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As one, we shall crush all who would dare to defy us and cement our legacy as the unquestioned rulers of this land.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Player_Romus), `[15]` (Player_Romus), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd2");"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My subjects, today brings a somber moment as we witness the return of Zille, a land marred by suffering and division.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""However, it was through our enduring faith in the Almigh..."*)
  - -> `[24]` (*Player_Romus: ""Yet, it was through the strength and determination of th..."*)
  - -> `[23]` (*Player_Romus: ""The path before us was arduous, but in the end, we perse..."*)
  - -> `[7]` (*Player_Romus: ""After a prolonged period of estrangement, Zille is final..."*)
  - -> `[30]` (*Player_Romus: ""For it was through our enduring faith in the Almighty th..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the resilient people of Zille, I offer my deepest sympathies. Your resilience in the face of adversity was a beacon of light in such dark times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[11]` (Player_Romus), `[23]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Looking back on what you endured, remember the solidarit..."*)
  - -> `[8]` (*Player_Romus: ""But let's not dwell on the trials of the past, but rathe..."*)
  - -> `[13]` (*Player_Romus: ""As one nation, united under our banner, we shall forge a..."*)
  - -> `[32]` (*Player_Romus: ""United in our devotion and reverence, let us give thanks..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looking back on what you endured, remember the solidarity that sustained you. In shared suffering, you found the strength to persevere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Player_Romus), `[12]` (Player_Romus), `[18]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Cheers erupted once more."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While the road to liberation was fraught with challenges, overcoming those hardships has helped us emerge stronger than ever before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""So let us honor the memories of those we have lost and t..."*)
  - -> `[9]` (*Player_Romus: ""Therefore, raise your voices in celebration, for today m..."*)
  - -> `[15]` (*Player_Romus: ""And so, my loyal subjects, let us seize this moment as a..."*)
  - -> `[34]` (*Player_Romus: ""In conclusion, we extend prayers of gratitude and thanks..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So let us honor the memories of those we have lost and the dreams that have been shattered along the way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[20]` (Player_Romus), `[33]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""May the sacrifices of those who fought for freedom guide..."*)
  - -> `[5]` (*Player_Romus: ""Together, we will march forward into the annals of histo..."*)
  - -> `[16]` (*Player_Romus: ""As one, we shall crush all who would dare to defy us and..."*)
  - -> `[35]` (*Player_Romus: ""And may our faith continue to strengthen us as we embark..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the sacrifices of those who fought for freedom guide us forward with resilience and hope.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Player_Romus), `[21]` (Player_Romus), `[34]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd2");"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The path before us was arduous, but in the end, we persevered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""To the resilient people of Zille, I offer my deepest sym..."*)
  - -> `[4]` (*Player_Romus: ""The strength and fortitude of those living under Wehlen'..."*)
  - -> `[12]` (*Player_Romus: ""To those who stood with us in our quest to reclaim what ..."*)
  - -> `[25]` (*Player_Romus: ""To our brothers and sisters in Zille, I offer my humble ..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet, it was through the strength and determination of the Crown that this victory has been achieved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""To the resilient people of Zille, I offer my deepest sym..."*)
  - -> `[4]` (*Player_Romus: ""The strength and fortitude of those living under Wehlen'..."*)
  - -> `[12]` (*Player_Romus: ""To those who stood with us in our quest to reclaim what ..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To our brothers and sisters in Zille, I offer my humble prayers and deepest blessings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[11]` (Player_Romus), `[23]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Looking back on what you endured, remember the solidarit..."*)
  - -> `[8]` (*Player_Romus: ""But let's not dwell on the trials of the past, but rathe..."*)
  - -> `[13]` (*Player_Romus: ""As one nation, united under our banner, we shall forge a..."*)
  - -> `[32]` (*Player_Romus: ""United in our devotion and reverence, let us give thanks..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dear brethren, today heralds a sacred moment as we witness the return of Zille.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""The path before us was arduous, but in the end, we perse..."*)
  - -> `[7]` (*Player_Romus: ""After a prolonged period of estrangement, Zille is final..."*)
  - -> `[11]` (*Player_Romus: ""For it was the Crown's strength and determination that s..."*)
  - -> `[30]` (*Player_Romus: ""For it was through our enduring faith in the Almighty th..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Dear brethren, today heralds a sacred moment as we witne..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For it was through our enduring faith in the Almighty that this victory has been attained.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[10]` (Player_Romus), `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""To the resilient people of Zille, I offer my deepest sym..."*)
  - -> `[4]` (*Player_Romus: ""The strength and fortitude of those living under Wehlen'..."*)
  - -> `[25]` (*Player_Romus: ""To our brothers and sisters in Zille, I offer my humble ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, it was through our enduring faith in the Almighty that this triumph has been attained.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""To the resilient people of Zille, I offer my deepest sym..."*)
  - -> `[4]` (*Player_Romus: ""The strength and fortitude of those living under Wehlen'..."*)
  - -> `[12]` (*Player_Romus: ""To those who stood with us in our quest to reclaim what ..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""United in our devotion and reverence, let us give thanks for the divine grace that has reunited us with our brethren.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Player_Romus), `[18]` (Player_Romus), `[25]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Cheers erupted once more."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we'll walk the path of righteousness, guided by the eternal light of our faith.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""So let us honor the memories of those we have lost and t..."*)
  - -> `[9]` (*Player_Romus: ""Therefore, raise your voices in celebration, for today m..."*)
  - -> `[15]` (*Player_Romus: ""And so, my loyal subjects, let us seize this moment as a..."*)
  - -> `[34]` (*Player_Romus: ""In conclusion, we extend prayers of gratitude and thanks..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In conclusion, we extend prayers of gratitude and thanksgiving for the divine blessings that have brought Zille back into our fold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[14]` (Player_Romus), `[20]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""May the sacrifices of those who fought for freedom guide..."*)
  - -> `[5]` (*Player_Romus: ""Together, we will march forward into the annals of histo..."*)
  - -> `[16]` (*Player_Romus: ""As one, we shall crush all who would dare to defy us and..."*)
  - -> `[35]` (*Player_Romus: ""And may our faith continue to strengthen us as we embark..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And may our faith continue to strengthen us as we embark on this sacred journey together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Player_Romus), `[15]` (Player_Romus), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd2");"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "The familiar scent of saltwater filled the air, prompting old memories to rush back to me and a single word to escape my lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Zille.""*)

### Węzeł `[37]`
Mówca: **Estela Toras**
> ""I really have missed this place, despite the dismal state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I never thought I'd see the day...""*)
  - -> `[38]` (*Player_Romus: ""We'll fix it up so that it's exactly the way that it was.""*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)
  - -> `[266]` (*Player_Romus: ""We'll turn it into a magnificent villa. The Queen Mother..."*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Ec..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll fix it up so that it's exactly the way that it was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Estela Toras: ""Nothing will be exactly the way it was, darling. We can'..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a difficult time for all of us. But it's over now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Estela Toras: ""Thank Dast for that.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. Father's decision to hand over Zille to Wehlen cast a shadow over my entire reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Estela Toras: ""Consider the shadow lifted.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true )"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn08_ZilleNeg_GiveSmolakEstelasHome == true"*)

### Węzeł `[46]`
Mówca: **Narrator**
> "She stopped before turning to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Estela Toras: ""I'm proud of you, son. If not for your leadership, this ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my duty, Mother. For our kingdom, and for our family.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Estela Toras), `[63]` (Estela Toras), `[118]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Estela Toras: ""And you fulfilled that duty admirably, my dear.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glad I could step in where Father fell short. Wouldn't want his legacy tarnished any further.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Estela Toras), `[63]` (Estela Toras), `[118]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Estela Toras: ""His legacy may have had its flaws, but please don't disc..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very kind of you to say. I'm truly touched.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false` AND `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Estela Toras), `[63]` (Estela Toras), `[118]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Estela Toras: ""Well, I wouldn't say it if it wasn't true.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille belongs with us. Plain and simple.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Estela Toras), `[63]` (Estela Toras), `[118]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: ""The only thing left to do now is decide who's in charge...""*)

### Węzeł `[51]`
Mówca: **Estela Toras**
> ""And you fulfilled that duty admirably, my dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: ""The only thing left to do now is decide who's in charge...""*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The distant tolling of a bell tower interrupted her words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Estela Toras: ""Time to go. The festivities will be starting soon. And s..."*)

### Węzeł `[53]`
Mówca: **Estela Toras**
> ""Time to go. The festivities will be starting soon. And someone here is scheduled to give a speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "With a nod of acknowledgment, we left her childhood home ..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "With a nod of acknowledgment, we left her childhood home behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_Mother..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Mother briefly paused when she reached the bedroom, gazin..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I never thought I'd see the day...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Estela Toras: ""Personally, I had no doubt in my mind that Zille would b..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The pain of what King Valero let us lose, you mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Estela Toras: ""Don't speak ill of your father. Now is neither the time ..."*)

### Węzeł `[58]`
Mówca: **Estela Toras**
> ""Consider the shadow lifted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "She stopped before turning to face me."*)

### Węzeł `[59]`
Mówca: **Estela Toras**
> ""Thank Dast for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "She stopped before turning to face me."*)

### Węzeł `[60]`
Mówca: **Estela Toras**
> ""Don't speak ill of your father. Now is neither the time nor the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Estela Toras: ""Although, I would be remiss to ignore the impact his dec..."*)

### Węzeł `[61]`
Mówca: **Estela Toras**
> ""Although, I would be remiss to ignore the impact his decisions have had on our family and kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Halting, Mother turned to face me."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Halting, Mother turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Estela Toras: ""I'm proud of you, son. If not for your leadership, this ..."*)

### Węzeł `[63]`
Mówca: **Estela Toras**
> ""I'm proud of you, son. If not for your leadership, this house and so many others would have been lost forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, Mother, you had it easy compared to the rest of us. And by us, I mean me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Estela Toras: ""Well, forgive me for not shedding tears over your royal ..."*)

### Węzeł `[65]`
Mówca: **Estela Toras**
> ""Well, forgive me for not shedding tears over your royal discomfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "An uncomfortable silence stretched between us. Finally, M..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "An uncomfortable silence stretched between us. Finally, Mother broke the tension with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Estela Toras: ""I'm proud of you, son. If not for your leadership, this ..."*)

### Węzeł `[67]`
Mówca: **Estela Toras**
> ""Well, I wouldn't say it if it wasn't true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: ""The only thing left to do now is decide who's in charge...""*)

### Węzeł `[68]`
Mówca: **Estela Toras**
> ""His legacy may have had its flaws, but please don't discount the sacrifices he made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Estela Toras: ""You've seen firsthand how hard it is to keep this kingdo..."*)

### Węzeł `[69]`
Mówca: **Estela Toras**
> ""You've seen firsthand how hard it is to keep this kingdom together...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[70]`
Mówca: **Estela Toras**
> ""The only thing left to do now is decide who's in charge...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "As we made our way through the city, I felt a sense of renewal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The streets bustled with activity, alive with the energy ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The streets bustled with activity, alive with the energy of the festival. The once-damaged tenement buildings now stood proudly, freshly repainted to conceal the scars of the past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Before long we passed a sign for Smolak Square, where the..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Before long we passed a sign for Smolak Square, where the event was being held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Estela Toras: ""You should have the square's name changed as soon as hum..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Soldiers from the Rizian army were dispersed throughout the crowd, watchful for any sign of trouble."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Walking towards the center of the square, I couldn't igno..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Walking towards the center of the square, I couldn't ignore the solemnity of the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Where the former grandstand once stood, there was now a m..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Memories of that fateful day flooded back to me -- the chaos, the screams, the confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "It wasn't long before I was led to the podium to deliver my speech. Mother gently placed her hand on my arm, stopping me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Estela Toras: ""Good luck.""*)

### Węzeł `[78]`
Mówca: **Estela Toras**
> ""Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[89]` (*Player_Romus: ""Luck is for the weak, Mother. But thanks all the same.""*)
  - -> `[88]` (*Player_Romus: ""Thank you. I'll do my best to represent our kingdom with..."*)
  - -> `[90]` (*Player_Romus: ""'Good luck?' Please... I make my own luck.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""True change comes from within. Our focus should be on uplifting people's spirits before we tackle the task of renaming squares.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Estela Toras: ""If that's what you believe, dear, then I won't argue.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Back to Fedo Square?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Estela Toras: ""The Sazons would love that, I'm certain.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's best we keep it as is. Knowing Smolak, it'd be sure to cause an international incident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Estela Toras: ""If renaming a square is all it takes to cause an interna..."*)

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""You should have the square's name changed as soon as humanly possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""You're absolutely right, Mother. It's time to rid our ci..."*)
  - -> `[81]` (*Player_Romus: ""It's best we keep it as is. Knowing Smolak, it'd be sure..."*)
  - -> `[79]` (*Player_Romus: ""True change comes from within. Our focus should be on up..."*)
  - -> `[80]` (*Player_Romus: ""Back to Fedo Square?""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're absolutely right, Mother. It's time to rid our city of reminders of the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Estela Toras: ""Good. The last thing we'd want is any reminder of that s..."*)

### Węzeł `[84]`
Mówca: **Estela Toras**
> ""The Sazons would love that, I'm certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "As my mother and I stepped out of the car, we were met wi..."*)

### Węzeł `[85]`
Mówca: **Estela Toras**
> ""If renaming a square is all it takes to cause an international incident, then perhaps we need to reevaluate our diplomatic strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "As my mother and I stepped out of the car, we were met wi..."*)

### Węzeł `[86]`
Mówca: **Estela Toras**
> ""Good. The last thing we'd want is any reminder of that slimeball.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "As my mother and I stepped out of the car, we were met wi..."*)

### Węzeł `[87]`
Mówca: **Estela Toras**
> ""If that's what you believe, dear, then I won't argue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "As my mother and I stepped out of the car, we were met wi..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. I'll do my best to represent our kingdom with dignity and grace as you have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "A smile graced her lips before she gave me a light kiss o..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Luck is for the weak, Mother. But thanks all the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Mother rolled he eyes and shook her head, seeming only sl..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Good luck?' Please... I make my own luck.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Mother rolled her eyes and shook her head, though her dem..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the sentiment, Mother. May the divine light guide my words and actions as I address our people.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[78]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "A gentle smile adorned her face before she kissed me on t..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "A smile graced her lips before she gave me a light kiss on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Mother rolled he eyes and shook her head, seeming only slightly annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "A gentle smile adorned her face before she kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Mother rolled her eyes and shook her head, though her demeanor suggested she wasn't truly upset."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "As I stepped onto the stage and took my place behind the podium, the crowd erupted in applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "As I finished my speech, the crowd broke into loud cheers once more, their joy reverberating through the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Local Zille representatives approached me, holding a leat..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "I accepted it, quickly scanning its contents before taking up the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "And without a moment's hesitation, I signed my name, fulf..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "And without a moment's hesitation, I signed my name, fulfilling a promise now complete."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAn..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I glanced over at my mother. She had tears shining in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Offering her a reassuring smile, I turned back to the cro..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Offering her a reassuring smile, I turned back to the crowd, the memory of their praise etched into my mind forever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[103]`
Mówca: **Narrator**
> "My mother and I stood before the chain-link fence that now surrounded her old childhood home in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The beachfront shack looked as rundown as before, but, th..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "The beachfront shack looked as rundown as before, but, this time, a giant Wehlen flag fluttered proudly from its facade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Mother turned to me, simmering with palpable resentment."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Mother turned to me, simmering with palpable resentment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Estela Toras: ""So it's Smolak's house now. I can't believe my beloved s..."*)

### Węzeł `[106]`
Mówca: **Estela Toras**
> ""So it's Smolak's house now. I can't believe my beloved son would agree to such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""I truly regret promising it to him. But it was the only ..."*)
  - -> `[107]` (*Player_Romus: ""Would you rather that all of Zille belonged to him?""*)
  - -> `[112]` (*Player_Romus: ""It was falling apart anyway. You'd never have moved back..."*)
  - -> `[113]` (*Player_Romus: ""It wasn't a one-sided bargain. Did you see the doorstopp..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you rather that all of Zille belonged to him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Estela Toras: ""Of course not. But this parting shot of his is almost to..."*)

### Węzeł `[108]`
Mówca: **Estela Toras**
> ""Of course not. But this parting shot of his is almost too insulting to bear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Mother sighed heavily, her anger warring with her sense o..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Mother sighed heavily, her anger warring with her sense of duty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Estela Toras: ""But you made the right decision. You didn't stoop to his..."*)

### Węzeł `[110]`
Mówca: **Estela Toras**
> ""But you made the right decision. You didn't stoop to his childish level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "She took a final look back at the house."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I truly regret promising it to him. But it was the only option left after years of negotiation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Estela Toras: ""He was toying with you, Romus. As he has been for years.""*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was falling apart anyway. You'd never have moved back in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Estela Toras: ""You know that's not the point, darling.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It wasn't a one-sided bargain. Did you see the doorstopper he gave me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Estela Toras: ""Oh, I saw it, all right. No buts about it.""*)

### Węzeł `[114]`
Mówca: **Estela Toras**
> ""He was toying with you, Romus. As he has been for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Mother sighed heavily, her anger warring with her sense o..."*)

### Węzeł `[115]`
Mówca: **Estela Toras**
> ""You know that's not the point, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Mother sighed heavily, her anger warring with her sense o..."*)

### Węzeł `[116]`
Mówca: **Estela Toras**
> ""Oh, I saw it, all right. No buts about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Mother sighed heavily, her anger warring with her sense o..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "She took a final look back at the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Estela Toras: ""I'm proud of you, son. If not for your leadership, many ..."*)

### Węzeł `[118]`
Mówca: **Estela Toras**
> ""I'm proud of you, son. If not for your leadership, many more homes than mine would have been lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "My mother and I stood before the chain-link fence that no..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == tr..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Only a select few knew that the crowd had been meticulous..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "On the other side of the square, a group of Derdian and Bludish Golcondists led a series of victorious-sounding chants. I could just make out the words "Yollak Bluderat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Only a select few knew that the crowd had been meticulously orchestrated, ensuring that only my supporters were present."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Walking towards the center of the square, I couldn't igno..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true |..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "My thoughts were then abruptly interrupted by the distant..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "It wasn't long before I was led to the podium to deliver ..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "My thoughts were then abruptly interrupted by the distant shouts of Wehzek protesters at the back of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "They were shouting that the will of the people of Zille h..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "Instruct security to remove them."]** — Mówca: **Player_Romus_Italic**
> "With a brief nod and a discreet hand gesture, I indicated for the protesters to be removed as quietly as possible, without making a scene."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1;"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "It wasn't long before I was led to the podium to deliver ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == tr..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Estela Toras: ""Even if you had to resort to rather... unconventional ta..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[134]`
Mówca: **Estela Toras**
> ""Even if you had to resort to rather... unconventional tactics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Won == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""I appreciate your sentiments, but let's not overlook the..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""That's very kind of you to say. I'm truly touched.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your sentiments, but let's not overlook the people of Zille. Their votes and collective will are the reason why we're here today.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true` AND `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Estela Toras), `[63]` (Estela Toras), `[118]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true..."*)

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""Their resilience was truly remarkable. All those years without giving up hope...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == tr..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Estela Toras: ""Ah, yes, the power of this so-called 'democracy at work'..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true ||RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true  or Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Estela Toras: ""Their resilience was truly remarkable. All those years w..."*)

### Węzeł `[143]`
Mówca: **Estela Toras**
> ""Ah, yes, the power of this so-called 'democracy at work' I keep hearing about. No extra persuasion necessary, I'm sure...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "I spotted a group of Su Omina members, proudly displaying their insignia and banners."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "I spotted a group of Su Omina members, proudly displaying..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)

### Węzeł `[148]`
Mówca: **Narrator**
> "A group of ATA volunteers glared at them in obvious contempt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Won == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I accepted it, quickly scanning the referendum results be..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "I accepted it, quickly scanning its contents before takin..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Local Zille representatives approached me, holding a leather portfolio containing the legislation that would officially reunify Zille with Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "I accepted it, quickly scanning the referendum results before taking up the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "And without a moment's hesitation, I signed my name, fulf..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn = t..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn = t..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Won == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_RefVote ..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_RH_ZilleReturnSpeech_Negotiat..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The distant tolling of a bell tower interrupted her words."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturnSpeech_SpeechAndSignature"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I glanced over at my mother. She had tears shining in her..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "Mother briefly paused when she reached the bedroom, gazing ruefully at the peeling paint on the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Estela Toras: ""I really have missed this place, despite the dismal state.""*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "Ignore them."]** — Mówca: **Player_Romus_Italic**
> "I chose to ignore the protesters."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1;"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "It wasn't long before I was led to the podium to deliver ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturnedSpeech_MothersHome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "As we made our way through the city, I felt a sense of re..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVote"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn = t..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_StoppedByAN == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_RH_Turn09_RH_ZilleReturnSpeech_ANVot..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_StoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Zille_CelebratesReturn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success = true; RiziaDLC.Situation_D..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "As I stepped onto the stage and took my place behind the ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "As I finished my speech, the crowd broke into loud cheers..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "It was then that I noticed my daughter and her husband si..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "It was then that I noticed my daughter and her husband sitting in the very front row. Manus' eyes met with mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Next to him, Angelica Sazon wore a deadly serious express..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The applause subsided. I began to speak."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Next to him, Angelica Sazon wore a deadly serious expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The applause subsided. I began to speak."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "The applause subsided. I began to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""My subjects, today brings a somber moment as we witness ..."*)
  - -> `[3]` (*Player_Romus: ""My esteemed subjects, today marks a momentous occasion i..."*)
  - -> `[10]` (*Player_Romus: ""Citizens of Zille, let us revel in the glory of our triu..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "It was then that I noticed Angelica Sazon in the front ro..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The applause subsided. I began to speak."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "It was then that I noticed Angelica Sazon in the front row. She wore a deadly serious expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The applause subsided. I began to speak."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Cheers erupted once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: ""As you all know, Zille has historically been a vital par..."*)
  - -> `[188]` (*Player_Romus: ""I thank the members of House Sazon for their patience in..."*)
  - -> `[189]` (*Player_Romus: ""We must not forget the reason we lost Zille in the first..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you all know, Zille has historically been a vital part of the province of Brenas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[195]` (*Player_Romus: ""It is with joy that I announce the return of Zille to it..."*)
  - -> `[198]` (*Player_Romus: ""However, returning it outright would reward the Sazons f..."*)
  - -> `[199]` (*Player_Romus: ""But in these precarious times, we need unity, not feudal..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank the members of House Sazon for their patience in awaiting the return of this part of their ancestral homeland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""It is with joy that I announce the return of Zille to it..."*)
  - -> `[198]` (*Player_Romus: ""However, returning it outright would reward the Sazons f..."*)
  - -> `[199]` (*Player_Romus: ""But in these precarious times, we need unity, not feudal..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not forget the reason we lost Zille in the first place. Because of the rebellion led by the traitorous Duke Lucas Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_Marriage..."*)
  - -> `[196]` (*Player_Romus: ""However, I'm a forgiving king. Therefore, I announce the..."*)
  - -> `[197]` (*Player_Romus: ""To return it to the Sazons would reward their misdeeds. ..."*)
  - -> `[200]` (*Player_Romus: ""But in these precarious times, we need unity, not feudal..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I myself attach many happy childhood memories to Zille. It holds a special place in my heart.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""I hope that House Sazon will take good care of it once i..."*)
  - -> `[211]` (*Player_Romus: ""It is with joy in my heart that I announce the return of..."*)
  - -> `[210]` (*Player_Romus: ""I, therefore, cannot simply hand it back to House Sazon ..."*)
  - -> `[212]` (*Player_Romus: ""In that spirit, and in the interest of promoting unity o..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Zille == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""I myself attach many happy childhood memories to Zille. ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""I myself am one-half Zillean. This region holds a specia..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I myself am one-half Zillean. This region holds a special place in my heart and that of my mother.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""I hope that House Sazon will take good care of it once i..."*)
  - -> `[211]` (*Player_Romus: ""It is with joy in my heart that I announce the return of..."*)
  - -> `[210]` (*Player_Romus: ""I, therefore, cannot simply hand it back to House Sazon ..."*)
  - -> `[212]` (*Player_Romus: ""In that spirit, and in the interest of promoting unity o..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with joy that I announce the return of Zille to its original custodians, Brenas and House Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Player_Romus), `[188]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas = true; RiziaDLC.Authority..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, I'm a forgiving king. Therefore, I announce the return of this land to its rightful custodians. Zille shall once again belong to Brenas and House Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas = true; RiziaDLC.Authority..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To return it to the Sazons would reward their misdeeds. I therefore announce that Zille will be governed like Rizia Imperii, by the central government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii = true; RiziaDLC.Aut..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, returning it outright would reward the Sazons for their misdeeds. Therefore, Zille shall be ruled by the central government, just as Rizia Imperii.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Player_Romus), `[188]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii = true; RiziaDLC.Aut..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But in these precarious times, we need unity, not feudalism. Zille shall be guided by the firm hand of the central government, not a noble house.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Player_Romus), `[188]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii = true; RiziaDLC.Aut..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But in these precarious times, we need unity, not feudalism. Zille shall be firmly governed by the central authority, not one noble house.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii = true; RiziaDLC.Aut..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the meantime, the Sazons have proven themselves to be great allies. I shall therefore allow them to resume governance of the region that was taken from them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Country_HouseSazon"] > 2  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[189]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas = true; RiziaDLC.Authority..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_Marriage..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_Marria..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 2  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""In the meantime, the Sazons have proven themselves to be..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon > 2 || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 2  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Romus: "And now that House Sazon and House Toras are reconciled, ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And now that House Sazon and House Toras are reconciled, I find it only fitting to name the Sazons stewards of this land once more.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[187]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas = true; RiziaDLC.Authority..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that House Sazon will take good care of it once it is reincorporated into Brenas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas = true; RiziaDLC.Authority..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I, therefore, cannot simply hand it back to House Sazon and Brenas. It will belong to the central government's jurisdiction, as Rizia Imperii.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii = true; RiziaDLC.Aut..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with joy in my heart that I announce the return of Zille to its original custodians, Brenas and House Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas = true; RiziaDLC.Authority..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In that spirit, and in the interest of promoting unity over feudalism, Zille shall belong to Rizia Imperii from henceforth onwards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_RiziaImperii = true; RiziaDLC.Aut..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas = true;
RiziaDLC.Authority_Modifier_TerritorialReclaimation += 1;
RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas = true;
RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToBrenas = true;
RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_Brenas");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] = true;
Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] = Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] + 1;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToBrenas"] = true;
Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToBrenas"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory"] = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_Brenas");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_City_Zille", "Rizia_City..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_RiziaImperii = true;
RiziaDLC.Authority_Modifier_TerritorialReclaimation += 2;
RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToRiziaImperii = true;
RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii = true;
RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_RiziaImperii");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] = true;
Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] = Variable["RiziaDLC.Authority_Modifier_TerritorialReclaimation"] + 2;
Variable["RiziaDLCSupport.News_Turn09_RH_ZilleReturn_GiveToRiziaImperii"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ZilleReturn_GiveToRiziaImperii"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Regions_ZilleTerritory"] = false;
EnableCodexEntry("Locations_Regions_ZilleTerritory_RiziaImperii");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_City_Zille", "Rizia_City..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Angelica Sazon angrily rose from her seat."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[218]`
Mówca: **Narrator**
> "There was some applause from the crowd, as well as a few murmurs of concern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Angelica Sazon angrily rose from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Her son grabbed her arm and gently persuaded her to sit d..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "With a haughty glance in my direction, she turned and left."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Her son grabbed her arm and gently persuaded her to sit down once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "I motioned for the crowd to quiet down. I had to finish m..."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "With a haughty glance in my direction, she turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "I motioned for the crowd to quiet down. I had to finish m..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "Angelica Sazon stood and applauded fiercely."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[228]`
Mówca: **Narrator**
> "Angelica Sazon stood and applauded fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Manus and Vina joined her."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "A group of Sazon supporters began chanting "Glovurius axa..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Manus and Vina joined her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "A group of Sazon supporters began chanting "Glovurius axa..."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "A group of Sazon supporters began chanting "Glovurius axa Sazoni!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Some audience members joined them while others sat with t..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "I motioned for the crowd to quiet down. I had to finish my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""While the road to liberation was fraught with challenges..."*)
  - -> `[6]` (*Player_Romus: ""With Zille's return, we stand poised to achieve greatnes..."*)
  - -> `[14]` (*Player_Romus: ""The return of Zille serves as a testament to the strengt..."*)
  - -> `[33]` (*Player_Romus: ""Together, we'll walk the path of righteousness, guided b..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success = true;
RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = false;
RiziaDLC.Policy_Diplomacy_ZLLAActive = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReturn_Success"] = true;
Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = false;
Variable["RiziaDLC.Policy_Diplomacy_ZLLAActive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && R..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_City_Zille", "Rizia_City_HouseSazon");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_HouseSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_City_Nanta", "Rizia_City..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_City_Nanta", "Rizia_City_HouseSazon");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Nanta","Rizia_City_HouseSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_City_Zille", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Zille","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_City_Nanta", "Rizia_City..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_City_Nanta", "Rizia_City_HouseToras");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_City_Nanta","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "There was some applause from the crowd, as well as a few ..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_RiziaImperii == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && R..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true &&..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_RiziaImperii == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_IncomeTax += 4;"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_RiziaImperii == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.Z..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_RiziaImperii == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.Z..."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_RiziaImperii == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_IncomeTax += 2;"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_RiziaImperii == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_RiziaImperii"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && R..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_IncomeTax += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_IncomeTax += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_IncomeTax += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_Brenas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && R..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true &&..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_Brenas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_IncomeTax += 2;"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax == true && RiziaDLC.ZilleOwnership_Brenas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_IncreaseIncomeTax"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.Z..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_Brenas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.Z..."*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_Brenas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_IncomeTax += 1;"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_IncomeTax10 == true && RiziaDLC.ZilleOwnership_Brenas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_IncomeTax10"] == true  and  Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_IncomeTax += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_IncomeTax"] = Variable["RiziaDLC.Budget_Modifier_IncomeTax"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Nanta_StreetFestival = true;"*)

### Węzeł `[256]`
Mówca: **Narrator**
> "As my mother and I stepped out of the car, we were met with a sea of cheering faces, their palpable enthusiasm filling the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Zille == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "I walked alongside my mother through her dilapidated chil..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "I walked alongside my mother through her dilapidated chil..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""Zille belongs with us. Plain and simple.""*)
  - -> `[48]` (*Player_Romus: ""Glad I could step in where Father fell short. Wouldn't w..."*)
  - -> `[47]` (*Player_Romus: ""It was my duty, Mother. For our kingdom, and for our fam..."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Won == true"*)

### Węzeł `[261]`
Mówca: **Narrator**
> "The scent of saltwater filled the air. Almost involuntarily, a single word escaped her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Estela Toras: ""Zille.""*)

### Węzeł `[262]`
Mówca: **Estela Toras**
> ""Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Mother briefly paused when she reached the bedroom, gazin..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Zille == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""You and me both.""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll turn it into a magnificent villa. The Queen Mother's very own luxury retreat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "She shook her head."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and me both.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Estela Toras: ""I'm glad you're as attached to the house as I am. It sho..."*)

### Węzeł `[268]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Estela Toras: ""That would just feel wrong. Although I wouldn't mind upg..."*)

### Węzeł `[269]`
Mówca: **Estela Toras**
> ""That would just feel wrong. Although I wouldn't mind upgrading the bed linens to a higher thread count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Estela Toras: ""I look forward to the day when I can come here without b..."*)

### Węzeł `[270]`
Mówca: **Estela Toras**
> ""Nothing will be exactly the way it was, darling. We can't bring back the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Estela Toras: ""But bringing back the house? That would be lovely.""*)

### Węzeł `[271]`
Mówca: **Estela Toras**
> ""I'm glad you're as attached to the house as I am. It shows the King hasn't forgotten his roots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Estela Toras: ""I look forward to the day when I can come here without b..."*)

### Węzeł `[272]`
Mówca: **Estela Toras**
> ""But bringing back the house? That would be lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Estela Toras: ""I look forward to the day when I can come here without b..."*)

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""Personally, I had no doubt in my mind that Zille would be ours again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Estela Toras: ""I look forward to the day when I can come here without b..."*)

### Węzeł `[274]`
Mówca: **Estela Toras**
> ""I look forward to the day when I can come here without being reminded of the pain of what we lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""Trust me, Mother, you had it easy compared to the rest o..."*)
  - -> `[57]` (*Player_Romus: ""The pain of what King Valero let us lose, you mean.""*)
  - -> `[39]` (*Player_Romus: ""It was a difficult time for all of us. But it's over now.""*)
  - -> `[40]` (*Player_Romus: ""I understand. Father's decision to hand over Zille to We..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Ec..."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  and  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Romus: ""Don't get too used to it. I gave the Sords permission to..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true && RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true  and  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too used to it. I gave the Sords permission to turn the house into another resort.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  and  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "She stared daggers at me."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "She stared daggers at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Estela Toras: ""If you think that's funny, you're as bad as Smolak.""*)

### Węzeł `[280]`
Mówca: **Estela Toras**
> ""If you think that's funny, you're as bad as Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Estela Toras: ""I look forward to the day when I can come here without b..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "A group of ATA volunteers glared at them in obvious conte..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "I spotted a group of ATA volunteers, proudly waving Rizia..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[287]`
Mówca: **Narrator**
> "I spotted a group of ATA volunteers, proudly waving Rizian flags."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille ==..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == t..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_DerdianMercenaries_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_DerdianMercenaries_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == t..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == t..."*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries ==..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "On the other side of the square, a group of Derdian and B..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "On the other side of the square, a group of Derdian Golco..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "On the other side of the square, a group of Derdian Golcondists led a series of victorious-sounding chants."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)

### Węzeł `[295]`
Mówca: **Narrator**
> "On the other side of the square, a group of Bludish Wehzeks led a series of victorious-sounding chants. I could just make out the words "Yollak Bluderat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_RumburgianBFFMercenaries == t..."*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries ==..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "On the other side of the square, a group of Bludish Wehze..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_RumburgianBFFMercenaries == true || RiziaDLC.Diplomacy_Wehlen_FundBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_RumburgianBFFMercenaries"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_StoppedByAN == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "AN peacekeeping forces were dispersed throughout the crow..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_StoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true"*)

### Węzeł `[302]`
Mówca: **Narrator**
> "AN peacekeeping forces were dispersed throughout the crowd, watchful for any sign of trouble."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Walking towards the center of the square, I couldn't igno..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_Interfere_Army_Success == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_Interfere_Army_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Soldiers from the Rizian army were dispersed throughout t..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Walking towards the center of the square, I couldn't igno..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""I appreciate the sentiment, Mother. May the divine light..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "Manus Sazon's brow was knitted. Vina put a comforting arm..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "I motioned for the crowd to quiet down. I had to finish m..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "Manus Sazon's brow was knitted. Vina put a comforting arm around him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "I motioned for the crowd to quiet down. I had to finish m..."*)

### Węzeł `[313]`
Mówca: **Narrator**
> "I walked alongside my mother through her dilapidated childhood home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The familiar scent of saltwater filled the air, prompting..."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "I walked alongside my mother through her dilapidated childhood home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "The scent of saltwater filled the air. Almost involuntari..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "Where the former grandstand once stood, there was now a memorial to the victims of the bombing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Memories of that fateful day flooded back to me -- the ch..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "They were shouting that the will of the people of Zille had been ignored."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus_Italic: "Instruct security to remove them."*)
  - -> `[162]` (*Player_Romus_Italic: "Ignore them."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "Some audience members joined them while others sat with their arms crossed, looking dissatisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "I motioned for the crowd to quiet down. I had to finish m..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Proclaiming the return of Zille", "Smolak Square", "Zille");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Proclaiming the return of Zille","Smolak Square","Zille");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)
