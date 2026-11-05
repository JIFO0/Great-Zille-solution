# Rizia/Turn 6/SnO_PalesDealSigning

- **ID konwersacji:** `369`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/369_SnO_PalesDealSigning.md`
- **Liczba węzłów dialogowych:** 556
- **Liczba wyborów gracza:** 123

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[99]** Patricio Alvarez (R)

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Incident_Naval_FocusAidOnValero`
- `RiziaDLC.Incident_Naval_NoRescue`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.MITZ_ScrewedOverLespia`
- `RiziaDLC.Pales_PostIncident_Deal_25`
- `RiziaDLC.Pales_PostIncident_Deal_Cede`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Policy_Economy_AureusField_Extractions`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Economy_AureusField_HighExtraction`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.War_Incident_Border`
- `RiziaDLC.War_Incident_Naval`
- `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening`
- `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_PalesPipelineConstruction`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_AureusGasField`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_AureusField_Extractions`
- `RiziaDLC.Policy_Economy_PalesPipeline_Completed`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Economy_AureusField_HighExtraction`
- `RiziaDLC.Situation_Economy_AureusField_LowExtraction`
- `RiziaDLC.Situation_Economy_AureusField_MediumExtraction`
- `RiziaDLC.VinaManus_Together`
- `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening`
- `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy`
- `RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[22]` | **""You must be dying to return home. Thank you for accepting this duty, Vina. It mea..."** | `[20]` **Vina Toras**: ""I'm glad you made it, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Vina Toras**: ""Uh... I wouldn't exactly call i..." |
| `[23]` | **""Good to see you, Vina. How were the meetings? I'm told there are no issues.""** | `[20]` **Vina Toras**: ""I'm glad you made it, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Vina Toras**: ""They were long and arduous for ..." |
| `[24]` | **""Did you miss your old man?""** | `[20]` **Vina Toras**: ""I'm glad you made it, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Vina Toras**: ""Ha. Not when you put it like th..." |
| `[44]` | **""Great work. Keep it up.""** | `[43]` **Vina Toras**: ""There were no issues with the a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "We were led into the conference ..." |
| `[45]` | **""Thank you, Vina. You've done an amazing job.""** | `[43]` **Vina Toras**: ""There were no issues with the a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "We were led into the conference ..." |
| `[46]` | **""Come on, then. Let's get this over with, shall we?""** | `[43]` **Vina Toras**: ""There were no issues with the a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "We were led into the conference ..." |
| `[53]` | **""Thank you, Duke Reinhart. Your words mean a lot for me and our kingdom.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Axel Reinhart**: ""I must also thank your daughter..."<br>`[62]` **Axel Reinhart**: ""I must also thank our partners ..." |
| `[54]` | **""You are so kind, Duke Reinhart. Thank you for having us.""** | `[51]` **Axel Reinhart**: ""I'm looking forward to settling..."<br>`[52]` **Axel Reinhart**: ""Today is not just about signing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Axel Reinhart**: ""I must also thank your daughter..."<br>`[62]` **Axel Reinhart**: ""I must also thank our partners ..." |
| `[55]` | **""It is a pleasure to be here under such promising circumstances. This deal will ma..."** | `[51]` **Axel Reinhart**: ""I'm looking forward to settling..."<br>`[52]` **Axel Reinhart**: ""Today is not just about signing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Axel Reinhart**: ""I must also thank your daughter..."<br>`[62]` **Axel Reinhart**: ""I must also thank our partners ..." |
| `[56]` | **""To be fair, I don't need a meeting with you to enjoy my visit to this great city.""** | `[51]` **Axel Reinhart**: ""I'm looking forward to settling..."<br>`[52]` **Axel Reinhart**: ""Today is not just about signing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Axel Reinhart**: ""Uh... Fair enough!"" |
| `[101]` | **""I missed you, Vina. How was Pales?""** | `[20]` **Vina Toras**: ""I'm glad you made it, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Vina Toras**: ""To be honest, I had a great tim..." |
| `[104]` | **""I see. Is it *Axel* now?""** | `[103]` **Vina Toras**: ""Axel went above and beyond to m..."<br>`[420]` **Vina Toras**: ""There were some scary moments. ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Vina Toras**: ""Oh come on, Father. It's not li..." |
| `[105]` | **""Did he? Don't fall for his theatrics. He's a snake through and through.""** | `[103]` **Vina Toras**: ""Axel went above and beyond to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Vina Toras**: ""I think you have a very distort..." |
| `[106]` | **""Good to know. I'm happy you had a good time here.""** | `[103]` **Vina Toras**: ""Axel went above and beyond to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Vina Toras**: ""I should show you around the Ol..." |
| `[107]` | **""Be careful, Vina. It's *Duke Reinhart* and it will stay that way.""** | `[103]` **Vina Toras**: ""Axel went above and beyond to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Vina Toras**: ""Oh God. What are you talking ab..." |
| `[116]` | **""Yes, yes. Let's just get this over with.""** | `[51]` **Axel Reinhart**: ""I'm looking forward to settling..."<br>`[52]` **Axel Reinhart**: ""Today is not just about signing..." | `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true  or  Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true  or Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true` | *Brak zmian stanu* | `[117]` **Narrator**: "There was a brief silence as his..." |
| `[139]` | **"Sign the papers."** | `[138]` **Narrator**: "The assistants placed all the ne..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("SigningApplause");`<br>`PlaySoundEffect("SigningApplause");` | `[140]` **Narrator**: "The room broke into a lengthy ro..."<br>`[353]` **Narrator**: "After me, the documents were als..." |
| `[169]` | **""I get it, Laurento. You've thanked me enough already.""** | `[168]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Laurento Esquibel**: ""Sorry. I didn't mean to come ac..." |
| `[170]` | **""We couldn't have done it without your help, Mr. Esquibel.""** | `[168]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Laurento Esquibel**: ""Much obliged."" |
| `[171]` | **""You know I would have preferred a better deal.""** | `[168]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false` | *Brak zmian stanu* | `[174]` **Laurento Esquibel**: ""No time to dwell on that now. W..." |
| `[172]` | **"Don't comment."** | `[168]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Upon our arrival to Castle Reinh..."<br>`[342]` **Narrator**: "Upon our arrival to Castle Reinh..." |
| `[176]` | **""I get it, Laurento. You've thanked me enough already.""** | `[175]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Laurento Esquibel**: ""Sorry. I do realize how much yo..." |
| `[177]` | **""So do I, Mr. Esquibel. Your advice and assistance was invaluable as usual.""** | `[175]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Laurento Esquibel**: ""Much obliged."" |
| `[178]` | **""You know I would have preferred a better deal.""** | `[175]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false) == false` | *Brak zmian stanu* | `[181]` **Laurento Esquibel**: ""No time to dwell on that now. W..." |
| `[179]` | **"Don't comment."** | `[175]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "Upon our arrival to Castle Reinh..." |
| `[182]` | **""And how was Pales?""** | `[25]` **Vina Toras**: ""Ha. Not when you put it like th..."<br>`[42]` **Vina Toras**: ""Uh... I wouldn't exactly call i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Vina Toras**: ""There were no issues with the a..." |
| `[183]` | **""Fine.""** | `[42]` **Vina Toras**: ""Uh... I wouldn't exactly call i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Vina Toras**: ""There were no issues with the a..." |
| `[184]` | **""And how did the meetings go?""** | `[25]` **Vina Toras**: ""Ha. Not when you put it like th..."<br>`[42]` **Vina Toras**: ""Uh... I wouldn't exactly call i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Vina Toras**: ""They were long and arduous for ..." |
| `[185]` | **""Well, I missed you too.""** | `[25]` **Vina Toras**: ""Ha. Not when you put it like th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Her face gave way to a wide grin." |
| `[192]` | **"Don't comment."** | `[193]` **Laurento Esquibel**: ""I certainly didn't expect this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "He pointed at a mock rig surroun..." |
| `[194]` | **""What on earth have they done?""** | `[193]` **Laurento Esquibel**: ""I certainly didn't expect this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Laurento Esquibel**: ""It seems the Palesians went abo..." |
| `[195]` | **""Well, a deal this important deserves a spectacle.""** | `[193]` **Laurento Esquibel**: ""I certainly didn't expect this."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Laurento Esquibel**: ""I can't debate that."" |
| `[202]` | **""Okay. That's a little too much.""** | `[167]` **Narrator**: "The geysers were choreographed t..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[206]` **Narrator**: "As the music came to an end and ..." |
| `[203]` | **""Damn. This is amazing.""** | `[167]` **Narrator**: "The geysers were choreographed t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "As the music came to an end and ..." |
| `[204]` | **""Organizing this must have cost as much as the drilling facility itself.""** | `[167]` **Narrator**: "The geysers were choreographed t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "As the music came to an end and ..." |
| `[205]` | **"Don't comment."** | `[167]` **Narrator**: "The geysers were choreographed t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "As the music came to an end and ..." |
| `[220]` | **""Duke Reinhart, my friend, I want to thank you from the bottom of my heart for you..."** | `[219]` **Narrator**: "I took the microphone amidst the..." | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false` | `--;` | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych odgałęzień)* |
| `[221]` | **""Ladies, gentlemen, dear friends. I would like to thank Duke Reinhart for inviting..."** | `[219]` **Narrator**: "I took the microphone amidst the..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych odgałęzień)* |
| `[222]` | **""Mr. Reinhart, Mr. Alvarez, LesPower and ladies and gentlemen...""** | `[219]` **Narrator**: "I took the microphone amidst the..." | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` | `--;` | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych odgałęzień)* |
| `[226]` | **""Mr. Reinhart, esteemed delegates, ladies and gentlemen...""** | `[219]` **Narrator**: "I took the microphone amidst the..." | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false` | `--;` | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych odgałęzień)* |
| `[227]` | **""Duke Reinhart, Prime Minister Alvarez. I want to thank you both from the bottom o..."** | `[219]` **Narrator**: "I took the microphone amidst the..." | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false  and  Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true` | `--;` | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych odgałęzień)* |
| `[229]` | **""We are here to celebrate a truly significant event. A testament to our countries’..."** | `[220]` **Player_Romus**: ""Duke Reinhart, my friend, I wan..."<br>`[221]` **Player_Romus**: ""Ladies, gentlemen, dear friends..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>`[245]` **Player_Romus**: ""We are more than excited about ..."<br>*(oraz 4 innych odgałęzień)* |
| `[230]` | **""Relations between Rizia, Pales and Lespia have reached a new peak. Our peaceful d..."** | `[220]` **Player_Romus**: ""Duke Reinhart, my friend, I wan..."<br>`[221]` **Player_Romus**: ""Ladies, gentlemen, dear friends..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` | `--;` | `[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>`[245]` **Player_Romus**: ""We are more than excited about ..."<br>*(oraz 4 innych odgałęzień)* |
| `[231]` | **""Despite a recent deterioration of Rizian-Palesian relations, we have come togethe..."** | `[220]` **Player_Romus**: ""Duke Reinhart, my friend, I wan..."<br>`[221]` **Player_Romus**: ""Ladies, gentlemen, dear friends..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true` | `--;` | `[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>`[245]` **Player_Romus**: ""We are more than excited about ..."<br>*(oraz 4 innych odgałęzień)* |
| `[235]` | **""Despite attempts to divide our countries, we deliberately chose the path to peace..."** | `[220]` **Player_Romus**: ""Duke Reinhart, my friend, I wan..."<br>`[221]` **Player_Romus**: ""Ladies, gentlemen, dear friends..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true` | `--;` | `[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>`[245]` **Player_Romus**: ""We are more than excited about ..."<br>*(oraz 4 innych odgałęzień)* |
| `[236]` | **""Today, we have concluded a historic agreement, which is a testament to true diplo..."** | `[220]` **Player_Romus**: ""Duke Reinhart, my friend, I wan..."<br>`[221]` **Player_Romus**: ""Ladies, gentlemen, dear friends..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false` | `--;` | `[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>`[245]` **Player_Romus**: ""We are more than excited about ..."<br>*(oraz 4 innych odgałęzień)* |
| `[241]` | **""Relations between Rizia and Pales have reached a new peak. Our agreement regardin..."** | `[220]` **Player_Romus**: ""Duke Reinhart, my friend, I wan..."<br>`[221]` **Player_Romus**: ""Ladies, gentlemen, dear friends..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false` | `--;` | `[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>`[245]` **Player_Romus**: ""We are more than excited about ..."<br>*(oraz 4 innych odgałęzień)* |
| `[245]` | **""We are more than excited about the massive amounts of energy this gas field will ..."** | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true` | `--;` | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych odgałęzień)* |
| `[246]` | **""Thanks to our cooperation with Pales, Rizia will soon be transporting billions of..."** | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true` | `--;` | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych odgałęzień)* |
| `[247]` | **""I am honored to announce the official agreement between our countries.""** | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true` | `--;` | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych odgałęzień)* |
| `[248]` | **""Let us not forget that, despite holding the right to claim part ownership of Aure..."** | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false` | `--;` | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych odgałęzień)* |
| `[249]` | **""In the name of peace and friendship, my kingdom selflessly gave away our claim to..."** | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false` | `--;` | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych odgałęzień)* |
| `[250]` | **""I am honored to announce the official agreement between our three countries.""** | `[229]` **Player_Romus**: ""We are here to celebrate a trul..."<br>`[230]` **Player_Romus**: ""Relations between Rizia, Pales ..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false` | `--;` | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych odgałęzień)* |
| `[255]` | **""I would like to note that extracting and transporting gas is not as easy as some ..."** | `[245]` **Player_Romus**: ""We are more than excited about ..."<br>`[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych odgałęzień)* |
| `[256]` | **""This project has many benefits not only for our people and our country, but also ..."** | `[245]` **Player_Romus**: ""We are more than excited about ..."<br>`[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true` | `--;` | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych odgałęzień)* |
| `[260]` | **"[Gesture at the geysers] "Believe me, ladies and gentlemen, I am as shocked as eve..."** | `[219]` **Narrator**: "I took the microphone amidst the..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[261]` **Narrator**: "The crowd burst out in laughter." |
| `[262]` | **""This field will hopefully have many benefits not only for Pales and its people, b..."** | `[245]` **Player_Romus**: ""We are more than excited about ..."<br>`[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false` | `--;` | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych odgałęzień)* |
| `[263]` | **""Thanks to the support and professionalism of LesPower, the project is already bei..."** | `[245]` **Player_Romus**: ""We are more than excited about ..."<br>`[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` | `--;` | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych odgałęzień)* |
| `[267]` | **""Thanks to the support and professionalism of our Palesian counterparts, future en..."** | `[245]` **Player_Romus**: ""We are more than excited about ..."<br>`[246]` **Player_Romus**: ""Thanks to our cooperation with ..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false` | `--;` | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych odgałęzień)* |
| `[269]` | **""I am certain that in the future, Rizia and Pales will implement many more mutuall..."** | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Player_Romus**: ""Before I finish, I would like t..."<br>`[306]` **Player_Romus**: ""Before I finish, I would also l..."<br>*(oraz 5 innych odgałęzień)* |
| `[270]` | **""I must point out that we live in a volatile region, with conflicts over resources..."** | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Player_Romus**: ""Before I finish, I would like t..."<br>`[306]` **Player_Romus**: ""Before I finish, I would also l..."<br>*(oraz 5 innych odgałęzień)* |
| `[271]` | **""It is my intention that Rizia continue on the path of peaceful conflict resolutio..."** | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Player_Romus**: ""Before I finish, I would like t..."<br>`[306]` **Player_Romus**: ""Before I finish, I would also l..."<br>*(oraz 5 innych odgałęzień)* |
| `[272]` | **""I would like to congratulate the Palesian leadership for displaying the political..."** | `[255]` **Player_Romus**: ""I would like to note that extra..."<br>`[256]` **Player_Romus**: ""This project has many benefits ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[279]` **Player_Romus**: ""Before I finish, I would like t..."<br>`[306]` **Player_Romus**: ""Before I finish, I would also l..."<br>*(oraz 5 innych odgałęzień)* |
| `[274]` | **""Before I finish, I would like to highlight the importance of Palesian-Rizian frie..."** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false` | `--;` | `[286]` **Player_Romus**: ""Both of our countries are impor..."<br>`[288]` **Player_Romus**: ""The Kingdom of Rizia sees the p..."<br>*(oraz 2 innych odgałęzień)* |
| `[275]` | **""Before I finish, I would like to highlight the importance of Lespian-Rizian frien..."** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true` | `--;` | `[282]` **Player_Romus**: ""We must not forget. Major power..."<br>`[530]` **Player_Romus**: ""My father King Valero was wrong..."<br>*(oraz 2 innych odgałęzień)* |
| `[279]` | **""Before I finish, I would like to highlight how important it is for the monarchies..."** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] =...` | `[290]` **Player_Romus**: ""Both the Rizian and Palesian mo..."<br>`[291]` **Player_Romus**: ""In these turbulent times, the g..."<br>*(oraz 1 innych odgałęzień)* |
| `[280]` | **""I won't bore you all for much longer. I know you want to see what happens when we..."** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`<br>`Variable["RiziaDLC.Trait_FunnyKing"] == true` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[282]` | **""We must not forget. Major powers like us have a responsibility to our region. Tod..."** | `[275]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[283]` | **""Prime Minister Alvarez and I have had our differences in the past. I hope this ag..."** | `[275]` **Player_Romus**: ""Before I finish, I would like t..." | `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[284]` | **""The Kingdom of Rizia believes in strengthening its cooperation with the member st..."** | `[275]` **Player_Romus**: ""Before I finish, I would like t..." | `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true) == false` | `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] =...`<br>`--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[286]` | **""Both of our countries are important exporters of natural resources. I believe ene..."** | `[274]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[287]` | **""Duke Reinhart and I have had our differences in the past. I hope this initiative ..."** | `[274]` **Player_Romus**: ""Before I finish, I would like t..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[288]` | **""The Kingdom of Rizia sees the people of Pales as our brothers and sisters. Let to..."** | `[274]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[290]` | **""Both the Rizian and Palesian monarchies are important exporters of natural resour..."** | `[279]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[291]` | **""In these turbulent times, the guiding hand of a king or a queen -- or a Duke or a..."** | `[279]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[292]` | **""We see the Grand Duchy of Pales as a potential future GRACE member, and a powerfu..."** | `[279]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[295]` | **""Now... Let the inauguration of the Palestream pipeline begin!""** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[297]` | **""As a closing word, I would like to thank everyone who has worked so hard on the d..."** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[298]` | **""Now... Let the inauguration of the Aureus drilling rig begin!""** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true`<br>`(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[299]` | **""As a closing word, I would like to thank everyone who has worked so hard on the d..."** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true`<br>`(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[300]` | **""Now... Let the ceremonies begin!""** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[301]` | **""As a closing word, I would like to thank everyone who has worked so hard on reach..."** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true) == false`<br>`(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[302]` | **""I wish success to all of you and to all of us in the future.""** | `[280]` **Player_Romus**: ""I won't bore you all for much l..."<br>`[541]` **Player_Romus**: ""I won't bore you all for much l..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true` | `--;` | `[315]` **Player_Romus**: ""Glovurius axa Rizia axa Pales!""<br>`[312]` **Player_Romus**: ""Thank you and have a good eveni..."<br>*(oraz 2 innych odgałęzień)* |
| `[306]` | **""Before I finish, I would also like to say a few words about the tragic events tha..."** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[310]` **Player_Romus**: ""I am still deeply saddened by t..."<br>`[308]` **Player_Romus**: ""Thanks to the conciliatory atti..."<br>*(oraz 3 innych odgałęzień)* |
| `[307]` | **""It is a sad reality that misunderstandings and lack of communication led to the l..."** | `[306]` **Player_Romus**: ""Before I finish, I would also l..." | `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[308]` | **""Thanks to the conciliatory attitude of Duke Reinhart, we managed to reach an agre..."** | `[306]` **Player_Romus**: ""Before I finish, I would also l..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[309]` | **""The Kingdom of Rizia believes in compassion. We not only forgave each other, but ..."** | `[306]` **Player_Romus**: ""Before I finish, I would also l..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[310]` | **""I am still deeply saddened by the loss of life that occurred. We must never forge..."** | `[306]` **Player_Romus**: ""Before I finish, I would also l..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[312]` | **""Thank you and have a good evening.""** | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd");` | `[316]` **Narrator**: "The crowd roared with applause. ..." |
| `[313]` | **""Congratulations, everybody!""** | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd");` | `[316]` **Narrator**: "The crowd roared with applause. ..." |
| `[314]` | **""God bless you all.""** | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `PlaySoundEffect("CheerCrowd");` | `[316]` **Narrator**: "The crowd roared with applause. ..." |
| `[315]` | **""Glovurius axa Rizia axa Pales!""** | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("CheerCrowd");` | `[316]` **Narrator**: "The crowd roared with applause. ..." |
| `[361]` | **""You must be desperate to get back and see Manus. As I promised, you may announce ..."** | `[43]` **Vina Toras**: ""There were no issues with the a..." | `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true` | *Brak zmian stanu* | `[365]` **Vina Toras**: ""Manus... Yes, of course. Thank ..." |
| `[402]` | **""The best? We lost what should rightfully belong to us!""** | `[175]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false` | *Brak zmian stanu* | `[403]` **Laurento Esquibel**: ""But we avoided an international..." |
| `[410]` | **""But at what cost? Lespia's getting the gas that should belong to us.""** | `[168]` **Laurento Esquibel**: ""I want to applaud you again, Yo..." | `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` | *Brak zmian stanu* | `[411]` **Laurento Esquibel**: ""If we play nice with both natio..." |
| `[419]` | **""I am so, so sorry for what I put you through.""** | `[418]` **Vina Toras**: ""Father! I can't tell you how go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Vina Toras**: ""There were some scary moments. ..." |
| `[421]` | **""Did anyone hurt you? You can tell me.""** | `[418]` **Vina Toras**: ""Father! I can't tell you how go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Vina Toras**: ""I'm just fine. Axel and the Pal..." |
| `[423]` | **""Thanks for your hard work despite the unpleasantness.""** | `[418]` **Vina Toras**: ""Father! I can't tell you how go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Vina Toras**: ""Ehm... you're welcome. I was ju..." |
| `[428]` | **""I thank the good Lord that you are safe.""** | `[418]` **Vina Toras**: ""Father! I can't tell you how go..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[429]` **Vina Toras**: ""I was never in any real trouble..." |
| `[430]` | **""This was your greatest challenge as a princess yet, and you passed with flying co..."** | `[420]` **Vina Toras**: ""There were some scary moments. ..."<br>`[422]` **Vina Toras**: ""I'm just fine. Axel and the Pal..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[437]` **Narrator**: "She beamed." |
| `[434]` | **""Nearly losing you made me realize how much your happiness means to me. Once we're..."** | `[420]` **Vina Toras**: ""There were some scary moments. ..."<br>`[422]` **Vina Toras**: ""I'm just fine. Axel and the Pal..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true` | *Brak zmian stanu* | `[435]` **Narrator**: "She gave me a quick hug." |
| `[441]` | **""I'm just grateful that the culprit has been jailed and we can put this whole mess..."** | `[420]` **Vina Toras**: ""There were some scary moments. ..."<br>`[422]` **Vina Toras**: ""I'm just fine. Axel and the Pal..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Lucita_Arrested"] == true` | *Brak zmian stanu* | `[442]` **Vina Toras**: ""I still can't believe Duchess A..." |
| `[450]` | **""You've earned the right to gloat. Mr. Prime Minister. You and Reinhart won fair a..."** | `[343]` **Patricio Alvarez (R)**: ""Lespia and LesPower are incredi..." | `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false` | *Brak zmian stanu* | `[455]` **Patricio Alvarez (R)**: ""Your own showing wasn't half ba..." |
| `[451]` | **""Indeed. I'm happy we managed to see through the nefarious forces trying to set us..."** | `[343]` **Patricio Alvarez (R)**: ""Lespia and LesPower are incredi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Narrator**: "The smile dropped from his face." |
| `[452]` | **""Energy really is the great unifier, isn't it?""** | `[343]` **Patricio Alvarez (R)**: ""Lespia and LesPower are incredi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Patricio Alvarez (R)**: ""I'll say. And there's more than..." |
| `[456]` | **""What did your friend Dwight have to say about all this?""** | `[343]` **Patricio Alvarez (R)**: ""Lespia and LesPower are incredi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Patricio Alvarez (R)**: ""President Walker? I wouldn't kn..." |
| `[462]` | **""I'll drink to that. What about you, Alvarez?""** | `[337]` **Axel Reinhart**: ""To our future partners!"" | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` | *Brak zmian stanu* | `[463]` **Patricio Alvarez (R)**: ""Hm. You said it."" |
| `[464]` | **""To South Merkopa's newest energy superpowers.""** | `[337]` **Axel Reinhart**: ""To our future partners!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "After exchanging congratulations..." |
| `[465]` | **""To the extraordinary opportunities Aureus will bring.""** | `[337]` **Axel Reinhart**: ""To our future partners!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "After exchanging congratulations..." |
| `[466]` | **""To international cooperation.""** | `[337]` **Axel Reinhart**: ""To our future partners!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "After exchanging congratulations..." |
| `[467]` | **""It's a good thing Mother's not here. Wouldn't want her getting ideas for her next..."** | `[193]` **Laurento Esquibel**: ""I certainly didn't expect this."" | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[471]` **Laurento Esquibel**: ""She would definitely appreciate..." |
| `[475]` | **""Making a mockery of God's wonders... who do they think they are?""** | `[167]` **Narrator**: "The geysers were choreographed t..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[206]` **Narrator**: "As the music came to an end and ..." |
| `[491]` | **"Turn the valve."** | `[490]` **Narrator**: "As the moment of the ceremonial ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Narrator**: "Instead of the expected mechanic..." |
| `[493]` | **"Turn the valve."** | `[324]` **Narrator**: "As the moment of the ceremonial ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Narrator**: "Instead of the expected mechanic..." |
| `[494]` | **""Get Princess Vina up here. This honor belongs to her as well.""** | `[324]` **Narrator**: "As the moment of the ceremonial ..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[495]` **Narrator**: "My daughter eagerly bounded up t..." |
| `[500]` | **""Get Princess Vina up here. This honor belongs to her as well.""** | `[490]` **Narrator**: "As the moment of the ceremonial ..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[504]` **Narrator**: "My daughter eagerly bounded up t..." |
| `[509]` | **"Press the button."** | `[328]` **Narrator**: "Duke Reinhart, Prime Minister Al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Narrator**: "There was a series of industrial..." |
| `[510]` | **""Get Princess Vina up here. This honor belongs to her as well.""** | `[328]` **Narrator**: "Duke Reinhart, Prime Minister Al..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[514]` **Narrator**: "My daughter eagerly bounded up t..." |
| `[526]` | **""Together, we identified and punished the responsible party, enabling us to mend o..."** | `[306]` **Player_Romus**: ""Before I finish, I would also l..." | `Variable["RiziaDLC.Lucita_Arrested"] == true` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[530]` | **""My father King Valero was wrong to mistrust Lespia. With Mr. Alvarez at the helm,..."** | `[275]` **Player_Romus**: ""Before I finish, I would like t..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[534]` | **""My kingdom believes that our partnerships with our neighbors are our greatest ass..."** | `[274]` **Player_Romus**: ""Before I finish, I would like t..." | `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false` | `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] =...`<br>`--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[541]` | **""I won't bore you all for much longer. I know you want to see what happens when we..."** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`<br>`Variable["RiziaDLC.Trait_FunnyKing"] == true` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |
| `[542]` | **""I can see you are getting impatient. I will bring my speech to a close.""** | `[269]` **Player_Romus**: ""I am certain that in the future..."<br>`[270]` **Player_Romus**: ""I must point out that we live i..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | `--;` | `[295]` **Player_Romus**: ""Now... Let the inauguration of ..."<br>`[297]` **Player_Romus**: ""As a closing word, I would like..."<br>*(oraz 5 innych odgałęzień)* |

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
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Signing an energy deal with Pales and Le..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After exchanging pleasantries, we were led inside. The light of the camera flashes nearly blinded us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[4]`
Mówca: **Axel Reinhart**
> ""Welcome back, Your Majesty. It's a delight to have you here with us once again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I was here to finalize our deal with Duke Reinhart and Prime Minister Alvarez. Today, Rizia would officially cede its claim to the Aureus gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the smiling faces of the Palesian and Lespian delegations as well as Duke Reinhart, who waited at the front gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "After exchanging pleasantries, we were led inside. The li..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The city was familiar to me by now. But the atmosphere was far more welcoming than it had ever been before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "I was here to sign our deal with Duke Reinhart as resolve..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I was here to finalize our concession to Duke Reinhart, a..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "I was here to sign our deal with Duke Reinhart as resolved by the AN. After today, Rizia would own 50 percent of the Aureus gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty. This was a te..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I was here to finalize our concession to Duke Reinhart, according to the AN's resolution. After today, Rizia's claim on the Aureus gas field would be officially null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty. This was a te..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Vina was already inside, standing next to the Palesian foreign affairs team. She came to me when we entered the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Vina Toras: ""I'm glad you made it, Father.""*)

### Węzeł `[20]`
Mówca: **Vina Toras**
> ""I'm glad you made it, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""I missed you, Vina. How was Pales?""*)
  - -> `[22]` (*Player_Romus: ""You must be dying to return home. Thank you for acceptin..."*)
  - -> `[23]` (*Player_Romus: ""Good to see you, Vina. How were the meetings? I'm told t..."*)
  - -> `[24]` (*Player_Romus: ""Did you miss your old man?""*)

### Węzeł `[21]`
Mówca: **Narrator**
> "We took our seats around a large table along with the delegates from each country's ministry of foreign affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must be dying to return home. Thank you for accepting this duty, Vina. It means a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Vina Toras: ""Uh... I wouldn't exactly call it *dying*. But yes, thank..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to see you, Vina. How were the meetings? I'm told there are no issues.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Vina Toras: ""They were long and arduous for sure. But honestly, it wa..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you miss your old man?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Vina Toras: ""Ha. Not when you put it like that.""*)

### Węzeł `[25]`
Mówca: **Vina Toras**
> ""Ha. Not when you put it like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""And how was Pales?""*)
  - -> `[184]` (*Player_Romus: ""And how did the meetings go?""*)
  - -> `[185]` (*Player_Romus: ""Well, I missed you too.""*)

### Węzeł `[26]`
Mówca: **Vina Toras**
> ""They were long and arduous for sure. But honestly, it wasn't as boring as I'd have thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Vina Toras: ""There were no issues with the agreement, and I'm told ev..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "For the third time since my coronation, our convoy drove ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "For the second time since my coronation, our convoy drove..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "For the third time since my coronation, our convoy drove steadily across the cobbled streets of Old Town Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "The city was familiar to me by now. But the atmosphere wa..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Deal_Cede == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I was here to finalize our concession to Duke Reinhart. A..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Deal_Cede == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_25 == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_25 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_25 == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Deal_25 == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_25 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "I was here to sign our deal with Duke Reinhart. After tod..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Deal_25 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I was here to sign our deal with Duke Reinhart as resolve..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "I was here to sign our deal with Duke Reinhart as resolved by the AN. After today, Rizia would own 50 percent of the Aureus gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty, for your deci..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "I was here to sign our deal with Duke Reinhart. After today, Rizia would own 25 percent of the Aureus gas field. Not as much as I wanted, but better than nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty, for your deci..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "I was here to finalize our concession to Duke Reinhart. After today, the Aureus gas field would officially belong to the Grand Duchy of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "After exchanging pleasantries, we were led inside. The light of the cameras nearly blinded us as we walked in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "We took our seats around a large table along with the del..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the smiling faces of the Palesian delegation as well as Duke Reinhart, waiting for us by the front gate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "After exchanging pleasantries, we were led inside. The li..."*)

### Węzeł `[42]`
Mówca: **Vina Toras**
> ""Uh... I wouldn't exactly call it *dying*. But yes, thank you, Father. I did my best to offer support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""And how was Pales?""*)
  - -> `[184]` (*Player_Romus: ""And how did the meetings go?""*)
  - -> `[183]` (*Player_Romus: ""Fine.""*)

### Węzeł `[43]`
Mówca: **Vina Toras**
> ""There were no issues with the agreement, and I'm told everything is ready for you to sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[44]` (*Player_Romus: ""Great work. Keep it up.""*)
  - -> `[45]` (*Player_Romus: ""Thank you, Vina. You've done an amazing job.""*)
  - -> `[46]` (*Player_Romus: ""Come on, then. Let's get this over with, shall we?""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great work. Keep it up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "We were led into the conference room where the meeting wa..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Vina. You've done an amazing job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "We were led into the conference room where the meeting wa..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, then. Let's get this over with, shall we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "We were led into the conference room where the meeting wa..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "We were led into the conference room where the meeting was to take place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Axel Reinhart: ""I'm looking forward to settling this Aureus business and..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Axel Reinhart: ""Today is not just about signing a deal. It's about layin..."*)

### Węzeł `[51]`
Mówca: **Axel Reinhart**
> ""I'm looking forward to settling this Aureus business and paving the way for a thaw between Pales and Rizia once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""It is a pleasure to be here under such promising circums..."*)
  - -> `[54]` (*Player_Romus: ""You are so kind, Duke Reinhart. Thank you for having us.""*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC..."*)
  - -> `[56]` (*Player_Romus: ""To be fair, I don't need a meeting with you to enjoy my ..."*)

### Węzeł `[52]`
Mówca: **Axel Reinhart**
> ""Today is not just about signing a deal. It's about laying the foundation for cooperation and mutual benefit between Pales and Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""It is a pleasure to be here under such promising circums..."*)
  - -> `[54]` (*Player_Romus: ""You are so kind, Duke Reinhart. Thank you for having us.""*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC..."*)
  - -> `[56]` (*Player_Romus: ""To be fair, I don't need a meeting with you to enjoy my ..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duke Reinhart. Your words mean a lot for me and our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are so kind, Duke Reinhart. Thank you for having us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Axel Reinhart), `[52]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a pleasure to be here under such promising circumstances. This deal will mark a new chapter for both of our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Axel Reinhart), `[52]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be fair, I don't need a meeting with you to enjoy my visit to this great city.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Axel Reinhart), `[52]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""Uh... Fair enough!""*)

### Węzeł `[57]`
Mówca: **Narrator**
> "He started laughing along with everyone else at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[58]`
Mówca: **Axel Reinhart**
> ""I must also thank your daughter. It's rare that a princess has such a knack for diplomatic intricacies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Vina blushed and bowed her head."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Axel Reinhart: ""I must also thank your daughter. It's rare that a prince..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Axel Reinhart: ""I must also thank our partners in the Rizian delegation...."*)

### Węzeł `[62]`
Mówca: **Axel Reinhart**
> ""I must also thank our partners in the Rizian delegation. They were instrumental in working out all the legal particulars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The delegates bowed their heads."*)

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> ""Uh... Fair enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "He started laughing along with everyone else at the table."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Vina blushed and bowed her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Axel Reinhart: ""We'll finalize the official details right now. Everythin..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "The delegates bowed their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Axel Reinhart: ""We'll finalize the official details right now. Everythin..."*)

### Węzeł `[66]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to cede half of its AN-acknowledged claim to the Aureus field to Pales, granting the Grand Duchy a 75 percent share in total.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Patricio Alvarez (R): ""The contract for extraction and transportation of Palesi..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDL..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_25 == true"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_25 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_25 == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Deal_25 == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_25 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Axel Reinhart: ""Rizia has agreed to cede half of its AN-acknowledged cla..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Deal_25 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Axel Reinhart: ""Both Rizia and Pales accept the Alliance of Nations' res..."*)

### Węzeł `[76]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Ownership of the Aureus gas field will be divided evenly between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Patricio Alvarez (R): ""Rizian Oil and Gas will control the rights to the Rizian..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Axel Reinhart: ""Both Rizia and Pales accept the Alliance of Nations' res..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Axel Reinhart: ""Rizia has agreed to cede its claim to the Aureus gas fie..."*)

### Węzeł `[80]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to cede its claim to the Aureus gas field, in exchange for lasting peace between the kingdom and the Grand Duchy of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Patricio Alvarez (R): ""And LesPower of Lespia will receive the sole right to ex..."*)

### Węzeł `[81]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Pales will be granted sole ownership of the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Patricio Alvarez (R): ""And LesPower of Lespia will receive the sole right to ex..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDL..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Cede == true || Rizia..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Axel Reinhart: ""Rizia has agreed to cede its claim to the Aureus gas fie..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Axel Reinhart: ""Rizia has agreed to purchase the sole right  to extract ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "I was here to finalize our deal with Duke Reinhart. After..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede == true"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "I was here to finalize our deal with Duke Reinhart. After today, Rizia would own the rights to the Aureus gas field -- and a fully operational pipeline to go with it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty, for your deci..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_HighExtraction = true;
RiziaDLC.Energy_Modifier_AureusGasField = 8`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] = true;
Variable["RiziaDLC.Energy_Modifier_AureusGasField"] = 8;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions = true; R..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "// SYMBOLIC DRILLING // INCOME ADDED TURN 7"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The assistants placed all the necessary papers in front o..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SYMBOLIC DRILLING // INCOME ADDED TURN 7`
- **Efekt skryptowy (`userScript`):** `-- SYMBOLIC DRILLING -- INCOME ADDED TURN 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening = true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaD..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "// SYMBOLIC OPENING OF PIPELINE // INCOME ADDED IMMEDIATELY"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SYMBOLIC OPENING OF PIPELINE // INCOME ADDED IMMEDIATELY`
- **Efekt skryptowy (`userScript`):** `-- SYMBOLIC OPENING OF PIPELINE -- INCOME ADDED IMMEDIATELY;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_PalesPipeline_Project = false; Ri..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I missed you, Vina. How was Pales?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Vina Toras: ""To be honest, I had a great time here.""*)

### Węzeł `[102]`
Mówca: **Vina Toras**
> ""To be honest, I had a great time here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""Axel went above and beyond to make sure of it.""*)

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""Axel went above and beyond to make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: ""Good to know. I'm happy you had a good time here.""*)
  - -> `[104]` (*Player_Romus: ""I see. Is it *Axel* now?""*)
  - -> `[107]` (*Player_Romus: ""Be careful, Vina. It's *Duke Reinhart* and it will stay ..."*)
  - -> `[105]` (*Player_Romus: ""Did he? Don't fall for his theatrics. He's a snake throu..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Is it *Axel* now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras), `[420]` (Vina Toras), `[422]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Vina Toras: ""Oh come on, Father. It's not like that.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did he? Don't fall for his theatrics. He's a snake through and through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Vina Toras: ""I think you have a very distorted perception of him.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know. I'm happy you had a good time here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Vina Toras: ""I should show you around the Old Town before we leave. I..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful, Vina. It's *Duke Reinhart* and it will stay that way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""Oh God. What are you talking about?""*)

### Węzeł `[108]`
Mówca: **Vina Toras**
> ""Oh God. What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Vina Toras: ""Anyway...""*)

### Węzeł `[109]`
Mówca: **Vina Toras**
> ""Oh come on, Father. It's not like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Vina Toras: ""Anyway...""*)

### Węzeł `[110]`
Mówca: **Vina Toras**
> ""I think you have a very distorted perception of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Vina Toras: ""Anyway...""*)

### Węzeł `[111]`
Mówca: **Vina Toras**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)

### Węzeł `[112]`
Mówca: **Vina Toras**
> ""I should show you around the Old Town before we leave. It's amazing how well-preserved it is, even in the middle of all the skyscrapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Vina Toras: ""Anyway...""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC.Pales_PostIncident_Deal_25 == true ||RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true ||RiziaDLC.Diplomacy_Pales_GasField_Cede == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaD..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC.Pales_PostIncident_Deal_25 == true ||RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true ||RiziaDLC.Diplomacy_Pales_GasField_Cede == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true  or  Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true  or Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""Yes, yes. Let's just get this over with.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC.Pales_PostIncident_Deal_25 == true ||RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true ||RiziaDLC.Diplomacy_Pales_GasField_Cede == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true  or  Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true  or Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, yes. Let's just get this over with.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true  or  Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true  or Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Axel Reinhart), `[52]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "There was a brief silence as his expression soured."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "There was a brief silence as his expression soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Axel Reinhart: ""As I was saying...""*)

### Węzeł `[118]`
Mówca: **Axel Reinhart**
> ""As I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[119]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to purchase the sole right  to extract resources from the Aureus Field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_HighExtraction = t..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Patricio Alvarez (R): ""And Pales has agreed to give LesPower shared control ove..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Patricio Alvarez (R): ""And LesPower of Lespia will receive the sole right to ex..."*)

### Węzeł `[123]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to cede its claim to the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "AddConversant("Patricio Alvarez (R)");"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "We took our seats around a large table along with the del..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Axel Reinhart: ""Both Rizia and Pales accept the Alliance of Nations' res..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Axel Reinhart: ""Both Rizia and Pales accept the Alliance of Nations' res..."*)

### Węzeł `[130]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Ownership of the Aureus gas field will be divided evenly between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Patricio Alvarez (R): ""Rizian Oil and Gas will control the rights to the Rizian..."*)

### Węzeł `[131]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Pales will be granted sole ownership of the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Patricio Alvarez (R): ""And LesPower of Lespia will receive the sole right to ex..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_MediumExtraction = true;
RiziaDLC.Energy_Modifier_AureusGasField = 4`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Economy_AureusField_MediumExtraction"] = true;
Variable["RiziaDLC.Energy_Modifier_AureusGasField"] = 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions = true; R..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_LowExtraction = true;
RiziaDLC.Energy_Modifier_AureusGasField = 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Economy_AureusField_LowExtraction"] = true;
Variable["RiziaDLC.Energy_Modifier_AureusGasField"] = 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions = true; R..."*)

### Węzeł `[134]`
Mówca: **Patricio Alvarez (R)**
> ""And Pales has agreed to give LesPower shared control over the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Patricio Alvarez (R): ""In turn, Lespia will be granting extraction rights for o..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Inside, we were greeted by the Lespian Prime Minister Alvarez and representatives from LesPower."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Patricio Alvarez (R): ""It's good to see you, Your Majesty.""*)

### Węzeł `[136]`
Mówca: **Patricio Alvarez (R)**
> ""It's good to see you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Patricio Alvarez (R): ""Lespia and LesPower are incredibly pleased that your nat..."*)

### Węzeł `[137]`
Mówca: **Patricio Alvarez (R)**
> ""In turn, Lespia will be granting extraction rights for one-quarter of the Aureus field to Rizian Oil and Gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_LowExtraction = tr..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "The assistants placed all the necessary papers in front of us to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("DealSigning");"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "Sign the papers."]** — Mówca: **Player_Romus_Italic**
> "I signed the papers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[140]`
Mówca: **Narrator**
> "The room broke into a lengthy round of applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy += 6`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_HighExtraction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_HighExtraction == ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_AureusField_HighExtraction =..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_HighExtraction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy += 6"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_AureusField_HighExtraction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy += 2"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_HighExtraction == ..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "IsStatusInToken("Rizia_Country_Pales", "Progress_Construc..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The assistants placed all the necessary papers in front o..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "After exchanging congratulations, we were led outdoors into the courtyard, where a stage had been set up for the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "As we stepped onto the stage, the applause of the crowd b..."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "We stood in front of a massive board with an illustrated map of the Antacean Sea, depicting the Aureus field as a bridge connecting Pales, Rizia and Lespia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "We stood in front of a massive board with an illustrated ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[155]`
Mówca: **Narrator**
> "We stood in front of a massive board with an illustrated map of the Antacean Sea, depicting the Aureus field as a bridge connecting Pales and Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "The stage itself was an outlandish construct, dominated by a towering replica of a drilling rig with a huge logo of LesPower on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Made to look like a sophisticated machine with oversized ..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "As we stepped onto the stage, the applause of the crowd blended with the loud music from the speakers and the clicks of camera shutters -- overwhelming me for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Made to look like a sophisticated machine with oversized dials, levers, and flashing lights, it was less a piece of industrial equipment and more a prop from a science fiction movie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "Laurento leaned in and whispered."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == t..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "The stage itself was an outlandish construct, dominated b..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "The stage itself was an outlandish construct, dominated b..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == t..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: ""Now... Let the inauguration of the Aureus drilling rig b..."*)
  - -> `[299]` (*Player_Romus: ""As a closing word, I would like to thank everyone who ha..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: ""Now... Let the ceremonies begin!""*)
  - -> `[301]` (*Player_Romus: ""As a closing word, I would like to thank everyone who ha..."*)
  - -> `[302]` (*Player_Romus: ""I wish success to all of you and to all of us in the fut..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "The stage itself was an outlandish construct, dominated by a colossal replica of a pipeline with a gigantic valve wheel at its center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "The valve was painted in garish colors and connected to a..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "The valve was painted in garish colors and connected to a series of exaggerated, cartoonish pipes that snaked their way across the stage, complete with artificial steam vents and blinking lights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "Laurento leaned in and whispered."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "The geysers were choreographed to erupt in unison with the crescendo of the music."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[203]` (*Player_Romus: ""Damn. This is amazing.""*)
  - -> `[204]` (*Player_Romus: ""Organizing this must have cost as much as the drilling f..."*)
  - -> `[205]` (*Player_Romus_Italic: "Don't comment."*)

### Węzeł `[168]`
Mówca: **Laurento Esquibel**
> ""I want to applaud you again, Your Majesty, for your decisive actions. We very narrowly avoided an international incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""We couldn't have done it without your help, Mr. Esquibel.""*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[172]` (*Player_Romus_Italic: "Don't comment."*)
  - -> `[169]` (*Player_Romus: ""I get it, Laurento. You've thanked me enough already.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get it, Laurento. You've thanked me enough already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Laurento Esquibel: ""Sorry. I didn't mean to come across as a sycophant.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We couldn't have done it without your help, Mr. Esquibel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Laurento Esquibel: ""Much obliged.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I would have preferred a better deal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[168]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Laurento Esquibel: ""No time to dwell on that now. We are here to celebrate.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[173]`
Mówca: **Laurento Esquibel**
> ""Sorry. I didn't mean to come across as a sycophant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[174]`
Mówca: **Laurento Esquibel**
> ""No time to dwell on that now. We are here to celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[175]`
Mówca: **Laurento Esquibel**
> ""I want to applaud you again, Your Majesty. This was a tense situation, and I believe Rizia made the best of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == tr..."*)
  - -> `[177]` (*Player_Romus: ""So do I, Mr. Esquibel. Your advice and assistance was in..."*)
  - -> `[179]` (*Player_Romus_Italic: "Don't comment."*)
  - -> `[176]` (*Player_Romus: ""I get it, Laurento. You've thanked me enough already.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get it, Laurento. You've thanked me enough already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Laurento Esquibel: ""Sorry. I do realize how much you hate sycophants.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So do I, Mr. Esquibel. Your advice and assistance was invaluable as usual.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Laurento Esquibel: ""Much obliged.""*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I would have preferred a better deal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[175]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Laurento Esquibel: ""No time to dwell on that now. We are here to celebrate.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[180]`
Mówca: **Laurento Esquibel**
> ""Sorry. I do realize how much you hate sycophants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[181]`
Mówca: **Laurento Esquibel**
> ""No time to dwell on that now. We are here to celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how was Pales?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Vina Toras), `[42]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Vina Toras: ""There were no issues with the agreement, and I'm told ev..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Vina Toras: ""There were no issues with the agreement, and I'm told ev..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how did the meetings go?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Vina Toras), `[42]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Vina Toras: ""They were long and arduous for sure. But honestly, it wa..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I missed you too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Her face gave way to a wide grin."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Her face gave way to a wide grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Vina Toras: ""There were no issues with the agreement, and I'm told ev..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "We would also be inaugurating the opening of the Palestream pipeline, delivering gas from the field to Rizia on LesPower's terms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty. This was a te..."*)

### Węzeł `[188]`
Mówca: **Axel Reinhart**
> ""We'll finalize the official details right now. Everything that happens afterwards is just for show.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Axel Reinhart: ""So...""*)

### Węzeł `[189]`
Mówca: **Axel Reinhart**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "He gestured at the assistants in the room. They quickly p..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "He gestured at the assistants in the room. They quickly placed enormous files on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[191]`
Mówca: **Narrator**
> "Laurento leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Laurento Esquibel: ""I certainly didn't expect this.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I did not comment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "He pointed at a mock rig surrounding the stage. There wer..."*)

### Węzeł `[193]`
Mówca: **Laurento Esquibel**
> ""I certainly didn't expect this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""Well, a deal this important deserves a spectacle.""*)
  - -> `[194]` (*Player_Romus: ""What on earth have they done?""*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[192]` (*Player_Romus_Italic: "Don't comment."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What on earth have they done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Laurento Esquibel: ""It seems the Palesians went above and beyond for this ce..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, a deal this important deserves a spectacle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Laurento Esquibel: ""I can't debate that.""*)

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""It seems the Palesians went above and beyond for this ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "He pointed at a mock rig surrounding the stage. There wer..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == t..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player_Romus: ""Now... Let the inauguration of the Palestream pipeline b..."*)
  - -> `[297]` (*Player_Romus: ""As a closing word, I would like to thank everyone who ha..."*)
  - -> `[302]` (*Player_Romus: ""I wish success to all of you and to all of us in the fut..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true"*)

### Węzeł `[200]`
Mówca: **Laurento Esquibel**
> ""I can't debate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "He pointed at a mock rig surrounding the stage. There wer..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "He pointed at a mock rig surrounding the stage. There were a series of artificial geysers, engineered to spout water and colored lights at timed intervals, simulating the dramatic discovery of natural gas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "The geysers were choreographed to erupt in unison with th..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's a little too much.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "As the music came to an end and the applause subsided, I ..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damn. This is amazing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "As the music came to an end and the applause subsided, I ..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Organizing this must have cost as much as the drilling facility itself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "As the music came to an end and the applause subsided, I ..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "As the music came to an end and the applause subsided, I ..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "As the music came to an end and the applause subsided, I took a closer look at the crowd that was gathered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Politicians, journalists and energy executives in their b..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Politicians, journalists and energy executives in their best formal attire were standing somewhat awkwardly amidst this bizarre setting. They cast amused glances at the entertainers who mingled among them - performers dressed as engineers and geologists, complete with exaggeratedly large yellow helmets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Duke Reinhart then took the microphone and started explaining the importance of Aureus and the deal that had been finalized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_HighExtraction == ..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "After thanking and congratulating LesPower, he turned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Inci..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_HighExtraction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_HighExtraction == ..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_AureusField_HighExtraction =..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_AureusField_HighExtraction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "After congratulating the delegates and thanking me, he tu..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_AureusField_HighExtraction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "After thanking and congratulating LesPower, he turned tow..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "After congratulating the delegates and thanking me, he turned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Inci..."*)

### Węzeł `[214]`
Mówca: **Axel Reinhart**
> ""...And I invite King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart"); RemoveConversant("Patr..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Inci..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.In..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Axel Reinhart: ""...And I invite King Romus.""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Axel Reinhart: ""...And I invite His Majesty, King Romus of Rizia.""*)

### Węzeł `[218]`
Mówca: **Axel Reinhart**
> ""...And I invite His Majesty, King Romus of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart"); RemoveConversant("Patr..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "I took the microphone amidst the applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""Ladies, gentlemen, dear friends. I would like to thank D..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDL..."*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, my friend, I want to thank you from the bottom of my heart for your understanding and cooperation over these past few years.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies, gentlemen, dear friends. I would like to thank Duke Reinhart for inviting us to attend this grand ceremony.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Reinhart, Mr. Alvarez, LesPower and ladies and gentlemen...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDL..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false && Rizia..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false  and  Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""Duke Reinhart, Prime Minister Alvarez. I want to thank y..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false  and  Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Reinhart, esteemed delegates, ladies and gentlemen...""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, Prime Minister Alvarez. I want to thank you both from the bottom of my heart for your understanding and cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false  and  Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""We are here to celebrate a truly significant event. A te..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are here to celebrate a truly significant event. A testament to our countries’ unbreakable bonds and ever-growing ambition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Player_Romus), `[221]` (Player_Romus), `[222]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relations between Rizia, Pales and Lespia have reached a new peak. Our peaceful division of rights to the Aureus field reflects that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Player_Romus), `[221]` (Player_Romus), `[222]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite a recent deterioration of Rizian-Palesian relations, we have come together to achieve a historic agreement -- a testament to true diplomacy and our mutual desire for cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Player_Romus), `[221]` (Player_Romus), `[222]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Despite a recent deterioration of Rizian-Palesian relati..."*)
  - -> `[235]` (*Player_Romus: ""Despite attempts to divide our countries, we deliberatel..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Romus: ""Today, we have concluded a historic agreement, which is ..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite attempts to divide our countries, we deliberately chose the path to peace and mutual growth.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Player_Romus), `[221]` (Player_Romus), `[222]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we have concluded a historic agreement, which is a testament to true diplomacy and our mutual desire for cooperation.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Player_Romus), `[221]` (Player_Romus), `[222]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: ""Relations between Rizia, Pales and Lespia have reached a..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""Relations between Rizia and Pales have reached a new pea..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relations between Rizia and Pales have reached a new peak. Our agreement regarding the Aureus field reflects that.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Player_Romus), `[221]` (Player_Romus), `[222]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""Thanks to our cooperation with Pales, Rizia will soon be..."*)
  - -> `[245]` (*Player_Romus: ""We are more than excited about the massive amounts of en..."*)
  - -> `[247]` (*Player_Romus: ""I am honored to announce the official agreement between ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""In the name of peace and friendship, my kingdom selfless..."*)
  - -> `[248]` (*Player_Romus: ""Let us not forget that, despite holding the right to cla..."*)
  - -> `[250]` (*Player_Romus: ""I am honored to announce the official agreement between ..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are more than excited about the massive amounts of energy this gas field will produce.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Romus), `[230]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to our cooperation with Pales, Rizia will soon be transporting billions of cubic meters of natural gas.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Romus), `[230]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am honored to announce the official agreement between our countries.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Romus), `[230]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let us not forget that, despite holding the right to claim part ownership of Aureus, Rizia decided to cede all of our rights to our partners in Pales.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Romus), `[230]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the name of peace and friendship, my kingdom selflessly gave away our claim to this massive new gas resource.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Romus), `[230]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am honored to announce the official agreement between our three countries.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[229]` (Player_Romus), `[230]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[255]` (*Player_Romus: ""I would like to note that extracting and transporting ga..."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""This project has many benefits not only for our people a..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""This field will hopefully have many benefits not only fo..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to note that extracting and transporting gas is not as easy as some may think. It will be a great undertaking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Player_Romus), `[246]` (Player_Romus), `[247]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This project has many benefits not only for our people and our country, but also for our neighbors and the region as a whole.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Kontekst wejściowy (poprzednik):** `[245]` (Player_Romus), `[246]` (Player_Romus), `[247]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus: "[Gesture at the geysers] "Believe me, ladies and gentleme..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[260]`
**[WYBÓR GRACZA: "[Gesture at the geysers] "Believe me, ladies and gentlemen, I am as shocked as every one of you.""]** — Mówca: **Player_Romus**
> ""Believe me, ladies and gentlemen, I am as shocked as every one of you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "The crowd burst out in laughter."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "The crowd burst out in laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This field will hopefully have many benefits not only for Pales and its people, but also for its neighbors and the region as a whole.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Player_Romus), `[246]` (Player_Romus), `[247]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to the support and professionalism of LesPower, the project is already being implemented in a timely manner.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Player_Romus), `[246]` (Player_Romus), `[247]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player_Romus: ""Thanks to the support and professionalism of LesPower, t..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""Thanks to the support and professionalism of our Palesia..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to the support and professionalism of our Palesian counterparts, future energy deals will be completed in a flash.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[245]` (Player_Romus), `[246]` (Player_Romus), `[247]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""I am certain that in the future, Rizia and Pales will im..."*)
  - -> `[270]` (*Player_Romus: ""I must point out that we live in a volatile region, with..."*)
  - -> `[271]` (*Player_Romus: ""It is my intention that Rizia continue on the path of pe..."*)
  - -> `[272]` (*Player_Romus: ""I would like to congratulate the Palesian leadership for..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am certain that in the future, Rizia and Pales will implement many more mutually beneficial joint projects, whether in energy or other fields.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Player_Romus), `[256]` (Player_Romus), `[262]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must point out that we live in a volatile region, with conflicts over resources, ideology and religion brewing on all fronts. Let Rizia and Pales serve as an example to all those around us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Player_Romus), `[256]` (Player_Romus), `[262]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my intention that Rizia continue on the path of peaceful conflict resolution. We will remain one of the most reliable trading partners in Merkopa.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Player_Romus), `[256]` (Player_Romus), `[262]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to congratulate the Palesian leadership for displaying the political courage and will to accomplish this extraordinary partnership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Player_Romus), `[256]` (Player_Romus), `[262]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true &..."*)
  - -> `[279]` (*Player_Romus: ""Before I finish, I would like to highlight how important..."*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would like to highlight the importance of Palesian-Rizian friendship to Southern Merkopa.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would like to highlight the importance of Lespian-Rizian friendship to Southern Merkopa.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true && RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true &..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true && RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""Before I finish, I would like to highlight the importanc..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true && RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""Before I finish, I would like to highlight the importanc..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would like to highlight how important it is for the monarchies of Merkopa to stick together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't bore you all for much longer. I know you want to see what happens when we turn that wheel.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true` AND `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player_Romus: ""We must not forget. Major powers like us have a responsi..."*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaD..."*)
  - -> `[530]` (*Player_Romus: ""My father King Valero was wrong to mistrust Lespia. With..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not forget. Major powers like us have a responsibility to our region. Today, we are showing the world that we take our duties seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Alvarez and I have had our differences in the past. I hope this agreement will go some way towards mending those fences.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia believes in strengthening its cooperation with the member states of the ATO. There is so much we can gain from each other.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[275]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player_Romus: ""Both of our countries are important exporters of natural..."*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[288]` (*Player_Romus: ""The Kingdom of Rizia sees the people of Pales as our bro..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of our countries are important exporters of natural resources. I believe energy giants like us have a responsibility to the region. And today, we are showing the world that we take our duties seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart and I have had our differences in the past. I hope this initiative will go some way towards mending those fences.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[274]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia sees the people of Pales as our brothers and sisters. Let today be a step towards unity between us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player_Romus: ""Both the Rizian and Palesian monarchies are important ex..."*)
  - -> `[291]` (*Player_Romus: ""In these turbulent times, the guiding hand of a king or ..."*)
  - -> `[292]` (*Player_Romus: ""We see the Grand Duchy of Pales as a potential future GR..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both the Rizian and Palesian monarchies are important exporters of natural resources. I believe energy giants like us have a responsibility to the region. And today, we are showing the world that we take our duties seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In these turbulent times, the guiding hand of a king or a queen -- or a Duke or a Duchess -- is more necessary than ever. We shall prove to the world exactly what we are capable of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We see the Grand Duchy of Pales as a potential future GRACE member, and a powerful ally. Let today be a step towards that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Let the inauguration of the Palestream pipeline begin!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player_Romus: ""Glovurius axa Rizia axa Pales!""*)
  - -> `[312]` (*Player_Romus: ""Thank you and have a good evening.""*)
  - -> `[313]` (*Player_Romus: ""Congratulations, everybody!""*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a closing word, I would like to thank everyone who has worked so hard on the design and construction of this gas pipeline: the engineers and builders, as well as the employees of all the contractors involved.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Let the inauguration of the Aureus drilling rig begin!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true` AND `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a closing word, I would like to thank everyone who has worked so hard on the design and construction of this drilling facility: the engineers and builders, as well as the employees of all the contractors involved.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true` AND `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Let the ceremonies begin!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a closing word, I would like to thank everyone who has worked so hard on reaching a resolution on Aureus. This is an asset for the entire region.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true) == false` AND `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish success to all of you and to all of us in the future.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Kontekst wejściowy (poprzednik):** `[280]` (Player_Romus), `[541]` (Player_Romus), `[542]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Inci..."*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_In..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player_Romus: ""Before I finish, I would also like to say a few words ab..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would also like to say a few words about the tragic events that occurred recently.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player_Romus: ""I am still deeply saddened by the loss of life that occu..."*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[308]` (*Player_Romus: ""Thanks to the conciliatory attitude of Duke Reinhart, we..."*)
  - -> `[309]` (*Player_Romus: ""The Kingdom of Rizia believes in compassion. We not only..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a sad reality that misunderstandings and lack of communication led to the loss of lives. But we must put this behind us and look ahead.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[306]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to the conciliatory attitude of Duke Reinhart, we managed to reach an agreement in time to avoid further bloodshed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia believes in compassion. We not only forgave each other, but also reached a historic resolution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am still deeply saddened by the loss of life that occurred. We must never forget this incident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you and have a good evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Player_Romus), `[297]` (Player_Romus), `[298]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations, everybody!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Player_Romus), `[297]` (Player_Romus), `[298]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God bless you all.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[295]` (Player_Romus), `[297]` (Player_Romus), `[298]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia axa Pales!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Player_Romus), `[297]` (Player_Romus), `[298]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[316]`
Mówca: **Narrator**
> "The crowd roared with applause. I gave the microphone back to Duke Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "Duke Reinhart, Prime Minister Alvarez and I were guided t..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "Duke Reinhart and Prime Minister Alvarez were guided towa..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == t..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "As the moment of the ceremonial valve-turning approached,..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "As the main event approached, a gigantic faux control pan..."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "He shook my hand and gestured for Prime Minister Alvarez to join us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[324]`
Mówca: **Narrator**
> "As the moment of the ceremonial valve-turning approached, we walked to the massive valve in the middle of the stage and placed our hands on it, posing for the cameras as we did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus_Italic: "Turn the valve."*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[325]`
Mówca: **Narrator**
> "Instead of the expected mechanical hum, the speakers erupted with the sound of whistles and party horns. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Narrator: "Through the fog, I noticed Vina and the Duke of Pales gri..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "As the main event approached, a gigantic faux control panel was wheeled onto the stage. The panel, festooned with blinking lights and oversized buttons, was set for the ceremonial ‘activation’ of the gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[327]`
Mówca: **Narrator**
> "Duke Reinhart and Prime Minister Alvarez were guided towards the panel, where they were handed gloves to operate the machinery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "With a theatrical flourish, they pressed the buttons and ..."*)

### Węzeł `[328]`
Mówca: **Narrator**
> "Duke Reinhart, Prime Minister Alvarez and I were guided towards the panel. We placed our hands on it, posing for the cameras as we did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Player_Romus_Italic: "Press the button."*)
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[329]`
Mówca: **Narrator**
> "With a theatrical flourish, they pressed the buttons and the mock rig came to life. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Narrator: "After a few more minutes of picture-taking, they left the..."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "There was a series of industrial sounds as the mock rig came to life. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "After a few more minutes of picture-taking, we left the s..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "After a few more minutes of picture-taking, we left the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[332]`
Mówca: **Narrator**
> "I couldn't help but feel relieved once we were finally out of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""To our future partners!""*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "DisableToken("Rizia_Event_Aureus");"*)

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""To our future partners!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Player_Romus: ""To international cooperation.""*)
  - -> `[465]` (*Player_Romus: ""To the extraordinary opportunities Aureus will bring.""*)
  - -> `[464]` (*Player_Romus: ""To South Merkopa's newest energy superpowers.""*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SYMBOLIC DRILLING // NO INCOME`
- **Efekt skryptowy (`userScript`):** `-- SYMBOLIC DRILLING -- NO INCOME;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "He looked at me with a sly smile."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the smiling faces of the Palesian and Lespian delegations as well as Duke Reinhart, waiting for us by the front gate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[343]`
Mówca: **Patricio Alvarez (R)**
> ""Lespia and LesPower are incredibly pleased that your nations have reached a mutual understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Player_Romus: ""Energy really is the great unifier, isn't it?""*)
  - -> `[451]` (*Player_Romus: ""Indeed. I'm happy we managed to see through the nefariou..."*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == tr..."*)
  - -> `[456]` (*Player_Romus: ""What did your friend Dwight have to say about all this?""*)

### Węzeł `[344]`
Mówca: **Patricio Alvarez (R)**
> ""We will assume shared control over three-quarters of the field, while Rizian Oil and Gas will control the remaining 25 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_LowExtraction = tr..."*)

### Węzeł `[345]`
Mówca: **Patricio Alvarez (R)**
> ""The contract for extraction and transportation of Palesian gas has been given to our state corporation LesPower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Patricio Alvarez (R): ""We will assume shared control over three-quarters of the..."*)

### Węzeł `[346]`
Mówca: **Patricio Alvarez (R)**
> ""Rizian Oil and Gas will control the rights to the Rizian half of the field, while Lespia will share control over the Palesian half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Patricio Alvarez (R): ""Extraction and transportation from that half of the fiel..."*)

### Węzeł `[347]`
Mówca: **Patricio Alvarez (R)**
> ""Extraction and transportation from that half of the field will be carried out by our state corporation LesPower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_AureusField_MediumExtraction =..."*)

### Węzeł `[348]`
Mówca: **Patricio Alvarez (R)**
> ""From this point on, the extraction and transportation of Palesian gas will be handled by us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "// SYMBOLIC DRILLING // NO INCOME"*)

### Węzeł `[349]`
Mówca: **Patricio Alvarez (R)**
> ""And LesPower of Lespia will receive the sole right to extract resources from the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Patricio Alvarez (R): ""From this point on, the extraction and transportation of..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SigningApplause");"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SigningApplause");"*)

### Węzeł `[353]`
Mówca: **Narrator**
> "After me, the documents were also passed to Prime Minister Alvarez. As soon as he finished signing, the room broke into a lengthy round of applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[354]`
Mówca: **Axel Reinhart**
> ""To our future partners!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Patricio Alvarez (R): ""I'll drink to that. After the ceremony, obviously.""*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Duke Reinhart then took the microphone and started explai..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "Prime Minister Alvarez then took the microphone and start..."*)

### Węzeł `[358]`
Mówca: **Narrator**
> "Prime Minister Alvarez then took the microphone and started explaining the importance of Aureus and the deal that had been finalized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "After a brief introduction, he gave the microphone to Duk..."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "After a brief introduction, he gave the microphone to Duke Reinhart. The Palesian leader made his own brief speech before turning towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Inci..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableToken("Rizia_Event_Aureus");`
- **Efekt skryptowy (`userScript`):** `DisableToken("Rizia_Event_Aureus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Axel Reinhart: ""To our future partners!""*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must be desperate to get back and see Manus. As I promised, you may announce your courtship at once.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[43]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Vina Toras: ""Manus... Yes, of course. Thank you so much, Father.""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player_Romus: ""You must be desperate to get back and see Manus. As I pr..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
Mówca: **Vina Toras**
> ""Manus... Yes, of course. Thank you so much, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "As she spoke, her gaze inadvertently traveled to where Du..."*)

### Węzeł `[366]`
Mówca: **Narrator**
> "As she spoke, her gaze inadvertently traveled to where Duke Reinhart was standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "We were led into the conference room where the meeting wa..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_PalesPipeline_Project = false;
RiziaDLC.Policy_Economy_PalesPipeline_Completed = true;
RemoveTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
EnableReport("Construction_Pales_PipelineCompleted");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = false;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Completed"] = true;
RemoveTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
EnableReport("Construction_Pales_PipelineCompleted");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening = true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Vina was already inside, standing next to the Palesian fo..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Patricio Alvarez (R)");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Patricio Alvarez (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Inside, we were greeted by the Lespian Prime Minister Alv..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Axel Reinhart: ""Welcome back, Your Majesty. It's a delight to have you h..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "I took the microphone amidst the applause."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaD..."*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && Rizi..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales = t..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales = true; RiziaDLC.VinaManus_Together = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales"] = true;
Variable["RiziaDLC.VinaManus_Together"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ForThePeople","R_ForThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel");"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false"*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == false )"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy =..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras");"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras");"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales = true;"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaD..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaD..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("DealSigning");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("DealSigning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus_Italic: "Sign the papers."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SigningApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SigningApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "After me, the documents were also passed to Prime Ministe..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SigningApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SigningApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "The room broke into a lengthy round of applause."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "The crowd roared with applause. I gave the microphone bac..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_GasCorpPlaque")`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_GasCorpPlaque");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "I couldn't help but feel relieved once we were finally ou..."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "In the car, I glanced over at the PAR Aureus Plaque, a celebratory gift from the Rizian Oil and Gas Corporation, sitting snugly on the seat next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_GasCorpPlaque")"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IsStatusInToken("Rizia_Country_Pales", "Progress_Construction_PalesPipeline")`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "IsStatusInToken("Rizia_Country_Pales", "Progress_Construc..."*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(IsStatusInToken("Rizia_Country_Pales", "Progress_Constr..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IsStatusInToken("Rizia_Country_Pales", "Progress_Construction_PalesPipeline")`
- **Warunek bezpośredni (`conditionsString`):** `IsStatusInToken("Rizia_Country_Pales","Progress_Construction_PalesPipeline")`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(IsStatusInToken("Rizia_Country_Pales", "Progress_Construction_PalesPipeline"))`
- **Warunek bezpośredni (`conditionsString`):** `(IsStatusInToken("Rizia_Country_Pales","Progress_Construction_PalesPipeline")) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Pales", "Progres..."*)

### Węzeł `[396]`
Mówca: **Narrator**
> "The city was familiar to me by now. But the atmosphere was much more cheerful and cordial than it had been during my last visit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[397]`
Mówca: **Narrator**
> "For the second time since my coronation, our convoy drove steadily across the cobbled streets of Old Town Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The city was familiar to me by now. But the atmosphere wa..."*)

### Węzeł `[398]`
Mówca: **Laurento Esquibel**
> ""Much obliged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == tr..."*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player_Romus: ""The best? We lost what should rightfully belong to us!""*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""You know I would have preferred a better deal.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The best? We lost what should rightfully belong to us!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false`
- **Kontekst wejściowy (poprzednik):** `[175]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Laurento Esquibel: ""But we avoided an international incident. That's somethi..."*)

### Węzeł `[403]`
Mówca: **Laurento Esquibel**
> ""But we avoided an international incident. That's something to be proud of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "We would also be inaugurating the opening of the Palestre..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty. This was a te..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false && RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false && RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player_Romus: ""But at what cost? Lespia's getting the gas that should b..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false && RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""You know I would have preferred a better deal.""*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But at what cost? Lespia's getting the gas that should belong to us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Kontekst wejściowy (poprzednik):** `[168]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Laurento Esquibel: ""If we play nice with both nations, we could yet claim a ..."*)

### Węzeł `[411]`
Mówca: **Laurento Esquibel**
> ""If we play nice with both nations, we could yet claim a greater share of the rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[412]`
Mówca: **Laurento Esquibel**
> ""Much obliged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Vina was already inside, standing next to the Palesian fo..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false"*)

### Węzeł `[416]`
Mówca: **Narrator**
> "Vina was already inside, standing next to the Palesian foreign affairs team. She ran to me the moment I entered the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "AddConversant("Vina Toras");"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Vina Toras: ""Father! I can't tell you how good it is to see you again.""*)

### Węzeł `[418]`
Mówca: **Vina Toras**
> ""Father! I can't tell you how good it is to see you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player_Romus: ""I am so, so sorry for what I put you through.""*)
  - -> `[421]` (*Player_Romus: ""Did anyone hurt you? You can tell me.""*)
  - -> `[423]` (*Player_Romus: ""Thanks for your hard work despite the unpleasantness.""*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am so, so sorry for what I put you through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Vina Toras: ""There were some scary moments. But I never actually beli..."*)

### Węzeł `[420]`
Mówca: **Vina Toras**
> ""There were some scary moments. But I never actually believed Axel would let anything happen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[430]` (*Player_Romus: ""This was your greatest challenge as a princess yet, and ..."*)
  - -> `[104]` (*Player_Romus: ""I see. Is it *Axel* now?""*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did anyone hurt you? You can tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Vina Toras: ""I'm just fine. Axel and the Palesians took good care of ..."*)

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""I'm just fine. Axel and the Palesians took good care of me the whole time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[430]` (*Player_Romus: ""This was your greatest challenge as a princess yet, and ..."*)
  - -> `[104]` (*Player_Romus: ""I see. Is it *Axel* now?""*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your hard work despite the unpleasantness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Vina Toras: ""Ehm... you're welcome. I was just doing my diplomatic du..."*)

### Węzeł `[424]`
Mówca: **Vina Toras**
> ""Ehm... you're welcome. I was just doing my diplomatic duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[430]` (*Player_Romus: ""This was your greatest challenge as a princess yet, and ..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Player_Romus: ""I thank the good Lord that you are safe.""*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank the good Lord that you are safe.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[418]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Vina Toras: ""I was never in any real trouble. Axel and the Palesians ..."*)

### Węzeł `[429]`
Mówca: **Vina Toras**
> ""I was never in any real trouble. Axel and the Palesians made sure I was taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[430]` (*Player_Romus: ""This was your greatest challenge as a princess yet, and ..."*)
  - -> `[104]` (*Player_Romus: ""I see. Is it *Axel* now?""*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was your greatest challenge as a princess yet, and you passed with flying colors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[420]` (Vina Toras), `[422]` (Vina Toras), `[424]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Narrator: "She beamed."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_ApproveAfterPales == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_ApproveAfterPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player_Romus: ""Nearly losing you made me realize how much your happines..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nearly losing you made me realize how much your happiness means to me. Once we're back in Rizia, we'll announce your relationship with Manus straight away.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[420]` (Vina Toras), `[422]` (Vina Toras), `[424]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Narrator: "She gave me a quick hug."*)

### Węzeł `[435]`
Mówca: **Narrator**
> "She gave me a quick hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Vina Toras: ""The houses will be fine with it. You'll see.""*)

### Węzeł `[436]`
Mówca: **Vina Toras**
> ""The houses will be fine with it. You'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Vina Toras: ""Anyway...""*)

### Węzeł `[437]`
Mówca: **Narrator**
> "She beamed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Vina Toras: ""I should show you around the Old Town before we leave. I..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Player_Romus: ""I'm just grateful that the culprit has been jailed and w..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just grateful that the culprit has been jailed and we can put this whole mess behind us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[420]` (Vina Toras), `[422]` (Vina Toras), `[424]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Vina Toras: ""I still can't believe Duchess Azaro would sabotage our d..."*)

### Węzeł `[442]`
Mówca: **Vina Toras**
> ""I still can't believe Duchess Azaro would sabotage our deal like that. She's every bit as war-hungry as the stereotypes""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Vina Toras: ""Anyway...""*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal == true"*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Vina Toras: ""The incident slowed things down, of course, but my Pales..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_PostIncident_Peace_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Vina Toras: ""There were no issues with the agreement, and I'm told ev..."*)

### Węzeł `[446]`
Mówca: **Vina Toras**
> ""The incident slowed things down, of course, but my Palesian counterparts and I managed to get the paperwork into shape. All you have to do is sign it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "We were led into the conference room where the meeting wa..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == tr..."*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player_Romus: ""You've earned the right to gloat. Mr. Prime Minister. Yo..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've earned the right to gloat. Mr. Prime Minister. You and Reinhart won fair and square.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false`
- **Kontekst wejściowy (poprzednik):** `[343]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Patricio Alvarez (R): ""Your own showing wasn't half bad, Your Majesty. You had ..."*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. I'm happy we managed to see through the nefarious forces trying to set us against each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Narrator: "The smile dropped from his face."*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Energy really is the great unifier, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Patricio Alvarez (R): ""I'll say. And there's more than enough in the Aureus fie..."*)

### Węzeł `[453]`
Mówca: **Narrator**
> "The smile dropped from his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "We took our seats around a large table along with the del..."*)

### Węzeł `[454]`
Mówca: **Patricio Alvarez (R)**
> ""I'll say. And there's more than enough in the Aureus field to go round.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "We took our seats around a large table along with the del..."*)

### Węzeł `[455]`
Mówca: **Patricio Alvarez (R)**
> ""Your own showing wasn't half bad, Your Majesty. You had us worried for a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "We took our seats around a large table along with the del..."*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did your friend Dwight have to say about all this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Patricio Alvarez (R): ""President Walker? I wouldn't know.""*)

### Węzeł `[457]`
Mówca: **Patricio Alvarez (R)**
> ""President Walker? I wouldn't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "We took our seats around a large table along with the del..."*)

### Węzeł `[458]`
Mówca: **Patricio Alvarez (R)**
> ""I'll drink to that. After the ceremony, obviously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "After exchanging congratulations, we were led outdoors in..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Player_Romus: ""I'll drink to that. What about you, Alvarez?""*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll drink to that. What about you, Alvarez?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Kontekst wejściowy (poprzednik):** `[337]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Patricio Alvarez (R): ""Hm. You said it.""*)

### Węzeł `[463]`
Mówca: **Patricio Alvarez (R)**
> ""Hm. You said it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "After exchanging congratulations, we were led outdoors in..."*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To South Merkopa's newest energy superpowers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "After exchanging congratulations, we were led outdoors in..."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the extraordinary opportunities Aureus will bring.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "After exchanging congratulations, we were led outdoors in..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To international cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "After exchanging congratulations, we were led outdoors in..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a good thing Mother's not here. Wouldn't want her getting ideas for her next outfit.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[193]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Laurento Esquibel: ""She would definitely appreciate... whatever that is.""*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""It's a good thing Mother's not here. Wouldn't want her g..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[471]`
Mówca: **Laurento Esquibel**
> ""She would definitely appreciate... whatever that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "He pointed at a mock rig surrounding the stage. There wer..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Player_Romus: ""Making a mockery of God's wonders... who do they think t..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""Okay. That's a little too much.""*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Making a mockery of God's wonders... who do they think they are?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "As the music came to an end and the applause subsided, I ..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""God bless you all.""*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Narrator: "He shook my hand and smiled appreciatively as I was usher..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "He shook my hand and gestured for Prime Minister Alvarez ..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "He shook my hand and beckoned me to follow him."*)

### Węzeł `[485]`
Mówca: **Narrator**
> "He shook my hand and beckoned me to follow him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[486]`
Mówca: **Narrator**
> "He shook my hand and smiled appreciatively as I was ushered into the wings. Prime Minister Alvarez triumphantly took my place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "As the main event approached, a gigantic faux control pan..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == t..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Narrator: "As the moment of the ceremonial valve-turning approached,..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "As the main event approached, a gigantic faux control pan..."*)

### Węzeł `[490]`
Mówca: **Narrator**
> "As the moment of the ceremonial valve-turning approached, the three of us walked to the massive valve in the middle and placed our hands on it, posing for the cameras as we did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus_Italic: "Turn the valve."*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[491]`
**[WYBÓR GRACZA: "Turn the valve."]** — Mówca: **Player_Romus_Italic**
> "With a dramatic countdown, we turned the wheel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Narrator: "Instead of the expected mechanical hum, the speakers erup..."*)

### Węzeł `[492]`
Mówca: **Narrator**
> "Instead of the expected mechanical hum, the speakers erupted with the sound of whistles and party horns. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "After a few more minutes of picture-taking, we left the s..."*)

### Węzeł `[493]`
**[WYBÓR GRACZA: "Turn the valve."]** — Mówca: **Player_Romus_Italic**
> "With a dramatic countdown, Reinhart and I turned the wheel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Narrator: "Instead of the expected mechanical hum, the speakers erup..."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get Princess Vina up here. This honor belongs to her as well.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[324]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Narrator: "My daughter eagerly bounded up to the stage. Together, th..."*)

### Węzeł `[495]`
Mówca: **Narrator**
> "My daughter eagerly bounded up to the stage. Together, the three of us turned the wheel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "Instead of the expected mechanical hum, the speakers erup..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""Get Princess Vina up here. This honor belongs to her as ..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[499]`
Mówca: **Narrator**
> "Through the fog, I noticed Vina and the Duke of Pales grinning at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "After a few more minutes of picture-taking, we left the s..."*)

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get Princess Vina up here. This honor belongs to her as well.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[490]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Narrator: "My daughter eagerly bounded up to the stage. Together, al..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Player_Romus: ""Get Princess Vina up here. This honor belongs to her as ..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[504]`
Mówca: **Narrator**
> "My daughter eagerly bounded up to the stage. Together, all four of us turned the wheel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "Instead of the expected mechanical hum, the speakers erup..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "We stood in front of a massive board with an illustrated ..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Narrator: "We stood in front of a massive board with an illustrated ..."*)

### Węzeł `[508]`
Mówca: **Narrator**
> "We stood in front of a massive board with an illustrated map of the Antacean Sea, depicting the Aureus field as a bridge connecting Pales and Lespia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[509]`
**[WYBÓR GRACZA: "Press the button."]** — Mówca: **Player_Romus_Italic**
> "With a dramatic countdown, Reinhart, Alvarez and I each pressed one of the buttons on the panel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "There was a series of industrial sounds as the mock rig c..."*)

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get Princess Vina up here. This honor belongs to her as well.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[328]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "My daughter eagerly bounded up to the stage. She, Reinhar..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player_Romus: ""Get Princess Vina up here. This honor belongs to her as ..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[514]`
Mówca: **Narrator**
> "My daughter eagerly bounded up to the stage. She, Reinhart, Alvarez and I each pressed one of the buttons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Narrator: "With a series of industrial sounds, the mock rig came to ..."*)

### Węzeł `[515]`
Mówca: **Narrator**
> "With a series of industrial sounds, the mock rig came to life. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Narrator: "Through the fog, I noticed Vina and the Duke of Pales gri..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "In the car, I glanced over at the PAR Aureus Plaque, a ce..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "I couldn't help but feel relieved once we were finally ou..."*)

### Węzeł `[519]`
Mówca: **Narrator**
> "After a few more minutes of picture-taking, they left the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus: ""Mr. Reinhart, Mr. Alvarez, LesPower and ladies and gentl..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""Duke Reinhart, my friend, I want to thank you from the b..."*)
  - -> `[226]` (*Player_Romus: ""Mr. Reinhart, esteemed delegates, ladies and gentlemen...""*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player_Romus: ""Together, we identified and punished the responsible par..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player_Romus: ""It is a sad reality that misunderstandings and lack of c..."*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we identified and punished the responsible party, enabling us to mend our relations and turn over a new leaf.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[306]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaDLC.MITZ_ScrewedOverLespia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaD..."*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == true || Rizi..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaDLC.MITZ_ScrewedOverLespia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""Prime Minister Alvarez and I have had our differences in..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaDLC.MITZ_ScrewedOverLespia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player_Romus: ""The Kingdom of Rizia believes in strengthening its coope..."*)

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father King Valero was wrong to mistrust Lespia. With Mr. Alvarez at the helm, I believe the Republic will be a valuable partner to us in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Duke Reinhart and I have had our differences in the past..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player_Romus: ""My kingdom believes that our partnerships with our neigh..."*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom believes that our partnerships with our neighbors are our greatest asset. We shall continue to foster those partnerships, even at the expense of our own wealth.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[274]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Player_Romus: ""I can see you are getting impatient. I will bring my spe..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == t..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""I won't bore you all for much longer. I know you want to..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Player_Romus: ""I won't bore you all for much longer. I know you want to..."*)

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't bore you all for much longer. I know you want to see what happens when we turn on that rig.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false` AND `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can see you are getting impatient. I will bring my speech to a close.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Romus), `[270]` (Player_Romus), `[271]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[545]`
Mówca: **Narrator**
> "He looked at me with a sly smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Patricio Alvarez (R): ""As a gesture of gratitude for the magnanimity of King Ro..."*)

### Węzeł `[546]`
Mówca: **Patricio Alvarez (R)**
> ""As a gesture of gratitude for the magnanimity of King Romus, we shall also fund the construction of a pipeline from the Aureus field to Rizia. With the volume and price of gas deliveries to be agreed on -- or not -- at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening = true"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_AureusField_Extractions == true"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_AureusField_Extractions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_AureusField_Extractions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Narrator: "I was here to finalize our deal with Duke Reinhart. After..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I was here to finalize our deal with Duke Reinhart and Pr..."*)

### Węzeł `[554]`
Mówca: **Narrator**
> "I was here to finalize our deal with Duke Reinhart. After today, Rizia would own the rights to the Aureus gas field -- and a fully operational pipeline to go with it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Laurento Esquibel: ""I want to applaud you again, Your Majesty. This was a te..."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Signing an energy deal with Pales and Lespia", "Old Town", "Grand-Duchy of Pales");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Signing an energy deal with Pales and Lespia","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");"*)
