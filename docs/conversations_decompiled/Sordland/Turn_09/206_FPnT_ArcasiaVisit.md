# Sordland/Turn09/FPnT_ArcasiaVisit

- **ID konwersacji:** `206`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/206_FPnT_ArcasiaVisit.md`
- **Liczba węzłów dialogowych:** 432
- **Liczba wyborów gracza:** 72

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[24]** Dwight Walker
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Enable_PressRelease`
- `BaseGame.Joined_ATO`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.SuperpowerVisit_ExtravagantWelcome`
- `BaseGame.SuperpowerVisit_MilitaryWelcome`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn07_Fled_WalterTusk`
- `BaseGame.Turn07_Investigate_Oligarchs`
- `BaseGame.Turn08_SnO_KorontiInvestigationStopped`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGameIsolated.Turn09_FPnT_ATO_Against`
- `BaseGameIsolated.Turn09_FPnT_ATO_Aligned`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Joined_ATO`
- `BaseGame.Malenyevist`
- `BaseGame.Oligarchs_Extradited`
- `BaseGame.Policy_Diplomacy_ATO`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_TradeInitiative`
- `BaseGame.Policy_Diplomacy_TradeZone_Valgsland`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Military_ATO_Officers`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence`
- `BaseGame.Situation_Diplomacy_Arcasia_Military_Support`
- `BaseGame.Situation_Diplomacy_ArcasianInfluence`
- `BaseGame.Situation_Diplomacy_DiplomaticPressure`
- `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence`
- `BaseGame.Situation_Diplomacy_Energy_ForeignManipulation`
- `BaseGame.Situation_Diplomacy_Energy_Independence`
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_LackOfAllies`
- `BaseGame.Situation_Diplomacy_RumburgAggression`
- `BaseGame.Situation_Diplomacy_StrategicAllianceMember`
- `BaseGame.Situation_Diplomacy_UnitedContanaTradeHalt`
- `BaseGame.Situation_Economy_FinancialInvestment_Arcasia`
- `BaseGame.Situation_Economy_FinancialInvestment_UC`
- `BaseGame.Situation_Military_ATOMilitaryStructure`
- `BaseGame.Situation_Military_AdequatelyEquippedMilitary`
- `BaseGame.Situation_Military_HappyMilitaryPersonnel`
- `BaseGame.Situation_Military_LackOfEquipment`
- `BaseGame.Situation_Military_ModernisedAirForce`
- `BaseGame.Situation_Military_OutdatedMilitaryEquipment`
- `BaseGame.Situation_Military_UnhappyMilitaryPersonnel`
- `BaseGame.Sollist`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_Alliance_Cancelled`
- `BaseGameIsolated.Turn09_FPnT_ATO_Against`
- `BaseGameIsolated.Turn09_FPnT_ATO_Aligned`
- `BaseGameIsolated.Turn09_FPnT_ATO_Neutral`
- `BaseGameSupport.CountryReport_Turn09_Derdia_CursesATOJoin`
- `BaseGameSupport.FactionReport_Turn09_ATO_WelcomesSordland`
- `BaseGameSupport.Journal_Turn09_Joined_ATO`
- `BaseGameSupport.News_Turn09_G_ATO_ValgslandAlliance_Cancelled`
- `BaseGameSupport.News_Turn09_HP_ATO_ValgslandAlliance_Cancelled`
- `BaseGameSupport.News_Turn09_HP_Joined_ATO`
- `BaseGameSupport.News_Turn10_HP_ATOMarketInfluencesEnergy`
- `GameCondition.Turn09_FPnT_SuperpowerVisit`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **"“What I meant with extravagant was not a circus show. What the hell is this?”"** | `[5]` **Lucian Galade**: "“Is the welcome to your liking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: "“But... but I don't understand, ..." |
| `[18]` | **"“It looks good, Lucian. Good job.”"** | `[5]` **Lucian Galade**: "“Is the welcome to your liking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Lucian Galade**: "“Thank you.”" |
| `[19]` | **"“As long as it does the trick, I don't care.”"** | `[5]` **Lucian Galade**: "“Is the welcome to your liking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: "“I am sure it will.”" |
| `[32]` | **"“Welcome to Sordland.”"** | `[31]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Dwight Walker**: "“Thank you.”" |
| `[33]` | **"“I wanted to meet with you for the longest time.”"** | `[31]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Dwight Walker**: "“I assure you, the feeling is mu..." |
| `[34]` | **"“It is really good to see you, Mr. President.”"** | `[31]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Dwight Walker**: "“I assure you, the feeling is mu..." |
| `[59]` | **"“It is really good to see you, Mr. President.”"** | `[60]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Dwight Walker**: "“I assure you, the feeling is mu..." |
| `[61]` | **"“Welcome to Sordland.”"** | `[60]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Dwight Walker**: "“Thank you.”" |
| `[62]` | **"“I wanted to meet with you for the longest time.”"** | `[60]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Dwight Walker**: "“I assure you, the feeling is mu..." |
| `[67]` | **"Laugh."** | `[46]` **Narrator**: "He laughed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "We started walking towards the r..." |
| `[68]` | **"Don't laugh."** | `[46]` **Narrator**: "He laughed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "We started walking towards the r..." |
| `[83]` | **"“It is really good to see you, Mr. President.”"** | `[82]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Dwight Walker**: "“I assure you, the feeling is mu..." |
| `[84]` | **"“I wanted to meet with you for the longest time.”"** | `[82]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Dwight Walker**: "“I assure you, the feeling is mu..." |
| `[86]` | **"“Welcome to Sordland.”"** | `[82]` **Narrator**: "We shook hands." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Dwight Walker**: "“Thank you.”" |
| `[89]` | **"“We are very sorry to hear that.”"** | `[88]` **Dwight Walker**: "“I was almost going to think tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Dwight Walker**: "“I'm just joking, Mr. President...." |
| `[90]` | **"“I'm a simple man. Not really a fan of extravagance.”"** | `[88]` **Dwight Walker**: "“I was almost going to think tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Dwight Walker**: "“Me, Mr. President... I am the e..." |
| `[91]` | **"“Of course not! You are our guest of honor!”"** | `[88]` **Dwight Walker**: "“I was almost going to think tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Dwight Walker**: "“I'm just joking, Mr. President...." |
| `[109]` | **"“Don't mind us. We were just passing by.”"** | `[108]` **Narrator**: "Upon our entry, they started cla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "People laughed and started clapp..." |
| `[110]` | **"“Ladies and gentlemen. I present to you, President Walker.”"** | `[108]` **Narrator**: "Upon our entry, they started cla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "People started clapping." |
| `[111]` | **"“Everyone. Let's give a warm welcome to our guest of honor.”"** | `[108]` **Narrator**: "Upon our entry, they started cla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "People started clapping." |
| `[125]` | **"“President Walker, why don't we have a chat somewhere quiet?”"** | `[124]` **Narrator**: "President Walker grabbed Monica'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Dwight Walker**: "“Right when we were getting to t..." |
| `[126]` | **"Interject and dance with Monica yourself."** | `[124]` **Narrator**: "President Walker grabbed Monica'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "We hadn't danced since our weddi..." |
| `[127]` | **"Finish your martini."** | `[124]` **Narrator**: "President Walker grabbed Monica'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "Swirling around, Monica looked l..." |
| `[139]` | **"“That goes both ways, Mr. Walker.”"** | `[138]` **Dwight Walker**: "“I never took you for a dancer, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Dwight Walker**: "“I do practice in my free time b..." |
| `[140]` | **"“Just one of my good qualities.”"** | `[138]` **Dwight Walker**: "“I never took you for a dancer, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Dwight Walker**: "“I'm beginning to see how you la..." |
| `[141]` | **"“I thought I would mess it up.”"** | `[138]` **Dwight Walker**: "“I never took you for a dancer, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Dwight Walker**: "“Well. You certainly didn't.”" |
| `[151]` | **"“I know, and I cherish every moment of it.”"** | `[150]` **Dwight Walker**: "“And Mr. Rayne. You are one luck..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Narrator**: "Monica gave me an extremely stra..."<br>`[157]` **Narrator**: "Monica looked at me and smiled." |
| `[152]` | **"“We had enough fun. Let's talk about business.”"** | `[150]` **Dwight Walker**: "“And Mr. Rayne. You are one luck..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Dwight Walker**: "“Right when I was just getting s..." |
| `[153]` | **"“I hope you enjoyed your little dance.”"** | `[150]` **Dwight Walker**: "“And Mr. Rayne. You are one luck..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Dwight Walker**: "“I think we both did, right Moni..." |
| `[163]` | **"“I don't smoke, Mr. Walker. Thanks.”"** | `[162]` **Narrator**: "He took a seat and I followed su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Dwight Walker**: "“These are the best cigars in th..." |
| `[164]` | **"Take one of the cigars."** | `[162]` **Narrator**: "He took a seat and I followed su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "He pulled out a Rippo lighter an..." |
| `[168]` | **"“Yes, I am sure.”"** | `[167]` **Dwight Walker**: "“These are the best cigars in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "He pulled out a Rippo lighter an..." |
| `[169]` | **"“Well, when you put it like that... sure.”"** | `[167]` **Dwight Walker**: "“These are the best cigars in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "He pulled out a Rippo lighter an..." |
| `[174]` | **"“Never had an Erlory Maroon before?”"** | `[173]` **Dwight Walker**: "“Ah. This is a really good one. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "He took a puff from his cigar, f..." |
| `[175]` | **"“I'm glad you liked it.”"** | `[173]` **Dwight Walker**: "“Ah. This is a really good one. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "He took a puff from his cigar, f..." |
| `[176]` | **"Wait for him to start the conversation."** | `[173]` **Dwight Walker**: "“Ah. This is a really good one. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "He took a puff from his cigar, f..." |
| `[185]` | **"“I like stronger ones.”"** | `[184]` **Dwight Walker**: "“What type of whiskey do you like?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Dwight Walker**: "“A man after my own heart.”" |
| `[186]` | **"“I prefer wine.”"** | `[184]` **Dwight Walker**: "“What type of whiskey do you like?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "He bursted into a laugh." |
| `[187]` | **"“I am good with whatever is made here in Sordland.”"** | `[184]` **Dwight Walker**: "“What type of whiskey do you like?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Dwight Walker**: "“A fine answer but a bit restric..." |
| `[192]` | **"“I like complex flavours.”"** | `[184]` **Dwight Walker**: "“What type of whiskey do you like?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Dwight Walker**: "“As good as they are, they can g..." |
| `[197]` | **"“The type I can't refuse?”"** | `[196]` **Dwight Walker**: "“I want to make you an offer.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Dwight Walker**: "“Of course not. This is an offer..." |
| `[198]` | **"“I'm listening.”"** | `[196]` **Dwight Walker**: "“I want to make you an offer.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Dwight Walker**: "“Good.”" |
| `[199]` | **"“I was waiting for this moment.”"** | `[196]` **Dwight Walker**: "“I want to make you an offer.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Dwight Walker**: "“Good.”" |
| `[207]` | **"“Let's not talk about the scandal. We have much more important matters to discuss.”"** | `[206]` **Dwight Walker**: "“I heard you got into a scandal...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "He grinned." |
| `[208]` | **"“Yes. What of it?”"** | `[206]` **Dwight Walker**: "“I heard you got into a scandal...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "He grinned." |
| `[209]` | **"“Truly unfortunate chain of events.”"** | `[206]` **Dwight Walker**: "“I heard you got into a scandal...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Dwight Walker**: "“Indeed.”" |
| `[216]` | **"“Let's get it over with.”"** | `[196]` **Dwight Walker**: "“I want to make you an offer.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Dwight Walker**: "“Listen closely.”" |
| `[254]` | **"“Do you dare threaten me here, in my palace?”"** | `[253]` **Dwight Walker**: "“Before you answer, let me assur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Dwight Walker**: "“Hah. Yes I am. It wouldn't be m..." |
| `[256]` | **"“I accept, Mr. Walker. [Join ATO, Break Alliance with Valgsland, -2 Government Bud..."** | `[253]` **Dwight Walker**: "“Before you answer, let me assur..." | `Variable["BaseGame.Valgsland_Alliance"] == true` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[257]` | **"“You can't expect me to hand over the military command to you.”"** | `[253]` **Dwight Walker**: "“Before you answer, let me assur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Dwight Walker**: "“You won't be handing over the e..." |
| `[262]` | **"“It appears that I thought wrongly about you. I decline, Mr. Walker.”"** | `[253]` **Dwight Walker**: "“Before you answer, let me assur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Dwight Walker**: "“Then that's too bad. You have d..." |
| `[265]` | **"“Very well. I accept. [Join ATO, Break Alliance with Valgsland, -2 Government Budg..."** | `[258]` **Dwight Walker**: "“So, what will it be, Mr. Rayne?..."<br>`[260]` **Dwight Walker**: "“Besides, that part is not up fo..." | `Variable["BaseGame.Valgsland_Alliance"] == true` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[266]` | **"“I have to decline, Mr. Walker.”"** | `[258]` **Dwight Walker**: "“So, what will it be, Mr. Rayne?..."<br>`[260]` **Dwight Walker**: "“Besides, that part is not up fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Dwight Walker**: "“Then that's too bad. You have d..." |
| `[279]` | **"“I say aye! I accept, Mr. Walker.  [Join ATO, Break Alliance with Valgsland, -2 Go..."** | `[250]` **Dwight Walker**: "“Let's make history. Here. Tonig..." | `Variable["BaseGame.Valgsland_Alliance"] == true` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[280]` | **"“Thank you for the offer however, we currently have no plans to enter ATO.”"** | `[250]` **Dwight Walker**: "“Let's make history. Here. Tonig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Dwight Walker**: "“At least I know that I tried.”" |
| `[281]` | **"“I assure you we can hold our own against Rumburg just fine.”"** | `[250]` **Dwight Walker**: "“Let's make history. Here. Tonig..." | `Variable["BaseGame.RumburgIncident_DeclareWar"] == true` | *Brak zmian stanu* | `[282]` **Dwight Walker**: "“I didn't mean any offence, Mr. ..." |
| `[283]` | **"“Is that all you are asking for? I was expecting more demands.”"** | `[250]` **Dwight Walker**: "“Let's make history. Here. Tonig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Dwight Walker**: "“But, why, Mr. Rayne? In my mind..." |
| `[291]` | **"“Unfortunately I can't accept your offer, Mr. Walker.”"** | `[286]` **Dwight Walker**: "“There is much to gain for both ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Dwight Walker**: "“At least I know that I tried.”" |
| `[292]` | **"“Very well. I accept. [Join ATO, Break Alliance with Valgsland, -2 Government Budg..."** | `[286]` **Dwight Walker**: "“There is much to gain for both ..." | `Variable["BaseGame.Valgsland_Alliance"] == true` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[309]` | **"“I assure you we can hold out our own just fine.”"** | `[250]` **Dwight Walker**: "“Let's make history. Here. Tonig..." | `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[282]` **Dwight Walker**: "“I didn't mean any offence, Mr. ..." |
| `[320]` | **""I can't believe we pulled that off.""** | `[135]` **Narrator**: "Applause and whistles echoed aro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Narrator**: "Monica blinked and abruptly remo..."<br>`[326]` **Monica**: ""At your service, Mr. President."" |
| `[321]` | **""You saved me, Monica.""** | `[135]` **Narrator**: "Applause and whistles echoed aro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Narrator**: "Monica blinked and abruptly remo..."<br>`[326]` **Monica**: ""At your service, Mr. President."" |
| `[345]` | **"“Thank you, but there is no need. I don't care about them at all.”"** | `[344]` **Dwight Walker**: "“I can send them back to you if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Dwight Walker**: "“Very well.”" |
| `[346]` | **"“Please do. They can't be living the good life after disrespecting me the way they..."** | `[344]` **Dwight Walker**: "“I can send them back to you if ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Oligarchs_Extradited"] = true;` | `[349]` **Dwight Walker**: "“Very well. I will have them dep..." |
| `[347]` | **"“This can't be for free. What do you want in return?”"** | `[344]` **Dwight Walker**: "“I can send them back to you if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Dwight Walker**: "“Let's just say that this is a s..." |
| `[356]` | **"“As a matter of fact, Tusk is under investigation and Koronti already belongs in p..."** | `[344]` **Dwight Walker**: "“I can send them back to you if ..." | `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false` | *Brak zmian stanu* | `[357]` **Dwight Walker**: "“Justice must be served, yes."" |
| `[358]` | **""All right. Deport the bastards.""** | `[348]` **Dwight Walker**: "“Let's just say that this is a s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Oligarchs_Extradited"] = true;` | `[349]` **Dwight Walker**: "“Very well. I will have them dep..." |
| `[359]` | **""No, don't do anything. It wouldn't be right.""** | `[348]` **Dwight Walker**: "“Let's just say that this is a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Dwight Walker**: "“Very well.”" |
| `[394]` | **"“Very well. I accept. [Join ATO]”"** | `[286]` **Dwight Walker**: "“There is much to gain for both ..." | `(Variable["BaseGame.Valgsland_Alliance"] == true) == false` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[398]` | **"“I say aye! I accept, Mr. Walker. [Join ATO]”"** | `[250]` **Dwight Walker**: "“Let's make history. Here. Tonig..." | `(Variable["BaseGame.Valgsland_Alliance"] == true) == false` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[402]` | **"“Very well. I accept. [Join ATO]”"** | `[258]` **Dwight Walker**: "“So, what will it be, Mr. Rayne?..."<br>`[260]` **Dwight Walker**: "“Besides, that part is not up fo..." | `(Variable["BaseGame.Valgsland_Alliance"] == true) == false` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |
| `[406]` | **"“I accept, Mr. Walker. [Join ATO]”"** | `[253]` **Dwight Walker**: "“Before you answer, let me assur..." | `(Variable["BaseGame.Valgsland_Alliance"] == true) == false` | *Brak zmian stanu* | `[261]` **Dwight Walker**: "“That's what I'd like to hear.”" |

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
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_FPnT_SuperpowerVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_FPnT_SuperpowerVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The door of the car opened and flashes went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Dwight Walker, President of Arcasia, Head of the ATO came..."*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> "“Is the welcome to your liking, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“It looks good, Lucian. Good job.”"*)
  - -> `[17]` (*Player: "“What I meant with extravagant was not a circus show. Wha..."*)
  - -> `[19]` (*Player: "“As long as it does the trick, I don't care.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Dwight Walker, President of Arcasia, Head of the ATO came out of the car, smiling and waving at the enormous crowd that gathered. It was not every day an Arcasian president came to visit Sordland after all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_ExtravagantWelcome == true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Both sides of the maroon carpet leading up to the palace were lined up with soldiers wearing military uniforms of the Kingdom of Sordland era. They had swords, shields, spears and some of them were on horseback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "As soon as President Walker stepped on the carpet, childr..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_ExtravagantWelcome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_ExtravagantWelcome == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerVisit_ExtravagantWelcome == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_ExtravagantWelcome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Both sides of the maroon carpet leading up to the palace ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerVisit_ExtravagantWelcome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_MilitaryWelcome == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_MilitaryWelcome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_MilitaryWelcome == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerVisit_MilitaryWelcome == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_MilitaryWelcome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "Next to the maroon carpet to the palace, Sordish troops w..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerVisit_MilitaryWelcome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "President Walker stepped on the carpet and started to mak..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "As soon as President Walker stepped on the carpet, children appeared and showered the road with roses. He slowly started walking towards us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "It was then the centuries old Sordish sword dance started..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucian approached my side and quietly whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: "“Is the welcome to your liking, sir?”"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "It was then the centuries old Sordish sword dance started. The show took a minute at most and President Walker watched it quietly with a stern face, nodding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian approached my side and quietly whispered."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“What I meant with extravagant was not a circus show. What the hell is this?”"]** — Mówca: **Player**
> "“What I meant with extravagant was not a circus show. What the hell is this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“But... but I don't understand, sir. I did everything you..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“It looks good, Lucian. Good job.”"]** — Mówca: **Player**
> "“It looks good, Lucian. Good job.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“Thank you.”"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“As long as it does the trick, I don't care.”"]** — Mówca: **Player**
> "“As long as it does the trick, I don't care.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“I am sure it will.”"*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“But... but I don't understand, sir. I did everything you asked.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Seeing that President Walker was approaching, Lucian stoo..."*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Seeing that President Walker was approaching, Lucian stoo..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“I am sure it will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Seeing that President Walker was approaching, Lucian stoo..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Seeing that President Walker was approaching, Lucian stood back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Finally, I was in reaching distance to one of the most po..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Finally, I was in reaching distance to one of the most powerful men in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He looked at Monica first, bowed and kissed her hand for ..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "He looked at Monica first, bowed and kissed her hand for a second longer than I'd like."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Dwight Walker: "“Mr. Rayne. If you told me I would get to meet with your ..."*)

### Węzeł `[26]`
Mówca: **Dwight Walker**
> "“Mr. Rayne. If you told me I would get to meet with your lovely wife, I would've come sooner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Dwight Walker: "“I'm charmed, Ms. Rayne.”"*)

### Węzeł `[27]`
Mówca: **Monica**
> "“Oh my. Thank you, Mr. Walker. It's a pleasure to meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Dwight Walker: "“No.”"*)

### Węzeł `[28]`
Mówca: **Dwight Walker**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Dwight Walker: "“The pleasure is all mine, Ms. Rayne.”"*)

### Węzeł `[29]`
Mówca: **Dwight Walker**
> "“The pleasure is all mine, Ms. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: "“I hope your wife and the family is well.”"*)

### Węzeł `[30]`
Mówca: **Dwight Walker**
> "“Mr. President. It is so good to finally meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "We shook hands."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“It is really good to see you, Mr. President.”"*)
  - -> `[33]` (*Player: "“I wanted to meet with you for the longest time.”"*)
  - -> `[32]` (*Player: "“Welcome to Sordland.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Welcome to Sordland.”"]** — Mówca: **Player**
> "“Welcome to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Dwight Walker: "“Thank you.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“I wanted to meet with you for the longest time.”"]** — Mówca: **Player**
> "“I wanted to meet with you for the longest time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Dwight Walker: "“I assure you, the feeling is mutual. That's why I am her..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“It is really good to see you, Mr. President.”"]** — Mówca: **Player**
> "“It is really good to see you, Mr. President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Dwight Walker: "“I assure you, the feeling is mutual. That's why I am her..."*)

### Węzeł `[35]`
Mówca: **Dwight Walker**
> "“I assure you, the feeling is mutual. That's why I am here in fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[36]`
Mówca: **Dwight Walker**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "We started walking towards the reception hall in the palace. Our path was cleared of people at once."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He was simply looking around at the extraordinary interio..."*)

### Węzeł `[38]`
Mówca: **Dwight Walker**
> "“I'm charmed, Ms. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Monica: "“Oh my. Thank you, Mr. Walker. It's a pleasure to meet wi..."*)

### Węzeł `[39]`
Mówca: **Monica**
> "“I hope your wife and the family is well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Dwight Walker: "“They are very well, Ms. Rayne. Thank you. Unfortunately ..."*)

### Węzeł `[40]`
Mówca: **Dwight Walker**
> "“They are very well, Ms. Rayne. Thank you. Unfortunately they couldn't make it here today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Dwight Walker: "“And who do we have here?”"*)

### Węzeł `[41]`
Mówca: **Dwight Walker**
> "“And who do we have here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Dwight Walker: "“Mr. President. It is so good to finally meet with you.”"*)

### Węzeł `[42]`
Mówca: **Narrator**
> "As soon as President Walker stepped on the carpet, all of the soldiers performed a hard salute. Celebratory gunshots were fired. Trumpets started playing a Sordish march."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Along with Monica, I started walking over to meet him mid..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Along with Monica, I started walking over to meet him mid way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Finally, I was in reaching distance to one of the most po..."*)

### Węzeł `[44]`
Mówca: **Dwight Walker**
> "“Mr. President. One would think you are prepared to go to war with me instead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "He laughed."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Finally, I was in reaching distance to one of the most powerful men in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He looked at Monica first, bowed and kissed her hand for ..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Italic: "Laugh."*)
  - -> `[68]` (*Player_Italic: "Don't laugh."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "He looked at Monica first, bowed and kissed her hand for a second longer than I liked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Dwight Walker: "“Mr. Rayne. If you told me I would get to meet with your ..."*)

### Węzeł `[48]`
Mówca: **Dwight Walker**
> "“Mr. Rayne. If you told me I would get to meet with your lovely wife, I would've come sooner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Dwight Walker: "“I'm charmed, Ms. Rayne.”"*)

### Węzeł `[49]`
Mówca: **Dwight Walker**
> "“I'm charmed, Ms. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Monica: "“Oh my. Thank you, Mr. Walker. It's a pleasure to meet wi..."*)

### Węzeł `[50]`
Mówca: **Monica**
> "“Oh my. Thank you, Mr. Walker. It's a pleasure to meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Dwight Walker: "“No.”"*)

### Węzeł `[51]`
Mówca: **Dwight Walker**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Dwight Walker: "“The pleasure is all mine, Ms. Rayne.”"*)

### Węzeł `[52]`
Mówca: **Dwight Walker**
> "“And who do we have here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Dwight Walker: "“Mr. President. It is so good to finally meet with you.”"*)

### Węzeł `[53]`
Mówca: **Dwight Walker**
> "“The pleasure is all mine, Ms. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Monica: "“I hope your wife and the family is well.”"*)

### Węzeł `[54]`
Mówca: **Dwight Walker**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[55]`
Mówca: **Dwight Walker**
> "“Mr. President. It is so good to finally meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "We shook hands."*)

### Węzeł `[56]`
Mówca: **Dwight Walker**
> "“They are very well, Ms. Rayne. Thank you. Unfortunately they couldn't make it here today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Dwight Walker: "“And who do we have here?”"*)

### Węzeł `[57]`
Mówca: **Dwight Walker**
> "“I assure you, the feeling is mutual. That's why I am here in fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[58]`
Mówca: **Monica**
> "“I hope your wife and the family is well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Dwight Walker: "“They are very well, Ms. Rayne. Thank you. Unfortunately ..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“It is really good to see you, Mr. President.”"]** — Mówca: **Player**
> "“It is really good to see you, Mr. President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Dwight Walker: "“I assure you, the feeling is mutual. That's why I am her..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“It is really good to see you, Mr. President.”"*)
  - -> `[62]` (*Player: "“I wanted to meet with you for the longest time.”"*)
  - -> `[61]` (*Player: "“Welcome to Sordland.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Welcome to Sordland.”"]** — Mówca: **Player**
> "“Welcome to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Dwight Walker: "“Thank you.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I wanted to meet with you for the longest time.”"]** — Mówca: **Player**
> "“I wanted to meet with you for the longest time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Dwight Walker: "“I assure you, the feeling is mutual. That's why I am her..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "On the way to the entrance we stopped in front of General Valken who was in charge of the troops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Dwight Walker: "“General.”"*)

### Węzeł `[64]`
Mówca: **Dwight Walker**
> "“General.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "President Walker saluted Valken and the soldiers. They sa..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "President Walker saluted Valken and the soldiers. They saluted back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "As soon as our inspection finished, we entered the palace."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "As soon as our inspection finished, we entered the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Dwight Walker: "“Mr. President. One would think you are prepared to go to..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "Laugh."]** — Mówca: **Player_Italic**
> "I laughed at his joke."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "Don't laugh."]** — Mówca: **Player_Italic**
> "I didn't laugh at his joke which turned the situation a little bit awkward."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "President Walker stepped on the carpet and started to make his way towards us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Along with Monica, I started walking over to meet him mid..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Along with Monica, I started walking over to meet him mid way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Finally, I was in reaching distance to one of the most po..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Finally, I was in reaching distance to one of the most powerful men in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He looked at Monica first, bowed and kissed her hand for ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He looked at Monica first, bowed and kissed her hand for a second longer than I liked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Dwight Walker: "“Mr. Rayne. If you told me I would get to meet with your ..."*)

### Węzeł `[73]`
Mówca: **Dwight Walker**
> "“I assure you, the feeling is mutual. That's why I am here in fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "He turned and looked around."*)

### Węzeł `[74]`
Mówca: **Dwight Walker**
> "“Mr. Rayne. If you told me I would get to meet with your lovely wife, I would've come sooner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Dwight Walker: "“I'm charmed, Ms. Rayne.”"*)

### Węzeł `[75]`
Mówca: **Dwight Walker**
> "“I'm charmed, Ms. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Monica: "“Oh my. Thank you, Mr. Walker. It's a pleasure to meet wi..."*)

### Węzeł `[76]`
Mówca: **Monica**
> "“Oh my. Thank you, Mr. Walker. It's a pleasure to meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Dwight Walker: "“No.”"*)

### Węzeł `[77]`
Mówca: **Dwight Walker**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Dwight Walker: "“The pleasure is all mine, Ms. Rayne.”"*)

### Węzeł `[78]`
Mówca: **Dwight Walker**
> "“The pleasure is all mine, Ms. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Monica: "“I hope your wife and the family is well.”"*)

### Węzeł `[79]`
Mówca: **Dwight Walker**
> "“They are very well, Ms. Rayne. Thank you. Unfortunately they couldn't make it here today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Dwight Walker: "“And who do we have here?”"*)

### Węzeł `[80]`
Mówca: **Monica**
> "“I hope your wife and the family is well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Dwight Walker: "“They are very well, Ms. Rayne. Thank you. Unfortunately ..."*)

### Węzeł `[81]`
Mówca: **Dwight Walker**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "He turned and looked around."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“It is really good to see you, Mr. President.”"*)
  - -> `[84]` (*Player: "“I wanted to meet with you for the longest time.”"*)
  - -> `[86]` (*Player: "“Welcome to Sordland.”"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“It is really good to see you, Mr. President.”"]** — Mówca: **Player**
> "“It is really good to see you, Mr. President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Dwight Walker: "“I assure you, the feeling is mutual. That's why I am her..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“I wanted to meet with you for the longest time.”"]** — Mówca: **Player**
> "“I wanted to meet with you for the longest time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Dwight Walker: "“I assure you, the feeling is mutual. That's why I am her..."*)

### Węzeł `[85]`
Mówca: **Dwight Walker**
> "“Mr. President. It is so good to finally meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "We shook hands."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Welcome to Sordland.”"]** — Mówca: **Player**
> "“Welcome to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Dwight Walker: "“Thank you.”"*)

### Węzeł `[87]`
Mówca: **Dwight Walker**
> "“And who do we have here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Dwight Walker: "“Mr. President. It is so good to finally meet with you.”"*)

### Węzeł `[88]`
Mówca: **Dwight Walker**
> "“I was almost going to think that you weren't expecting me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“We are very sorry to hear that.”"*)
  - -> `[90]` (*Player: "“I'm a simple man. Not really a fan of extravagance.”"*)
  - -> `[91]` (*Player: "“Of course not! You are our guest of honor!”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“We are very sorry to hear that.”"]** — Mówca: **Player**
> "“We are very sorry to hear that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Dwight Walker: "“I'm just joking, Mr. President. Don't fret over it.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“I'm a simple man. Not really a fan of extravagance.”"]** — Mówca: **Player**
> "“I'm a simple man. Not really a fan of extravagance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Dwight Walker: "“Me, Mr. President... I am the exact opposite.”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Of course not! You are our guest of honor!”"]** — Mówca: **Player**
> "“Of course not! You are our guest of honor!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Dwight Walker: "“I'm just joking, Mr. President. Don't fret over it.”"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "He turned and looked around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Dwight Walker: "“I was almost going to think that you weren't expecting me.”"*)

### Węzeł `[93]`
Mówca: **Dwight Walker**
> "“Me, Mr. President... I am the exact opposite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "He laughed."*)

### Węzeł `[94]`
Mówca: **Dwight Walker**
> "“I'm just joking, Mr. President. Don't fret over it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "He laughed."*)

### Węzeł `[95]`
Mówca: **Dwight Walker**
> "“I'm just joking, Mr. President. Don't fret over it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "He laughed."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland_HeljilandRecognised == true || BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true || BaseGame.Valgsla..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland_HeljilandRecognised == true || BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Valgsland_HeljilandRecognised"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Against = true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland_HeljilandRecognised == true || BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Valgsland_HeljilandRecognised"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Ba..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Against = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_ATO_Against"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door of the car opened and flashes went off."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Aligned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_ATO_Aligned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door of the car opened and flashes went off."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false) || BaseGame.Lespia_Alliance == true || BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Ba..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_EmergencyDecree_Embargo_UC == true && ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false) || BaseGame.Lespia_Alliance == true || BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false)  or  Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Aligned = true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false) || BaseGame.Lespia_Alliance == true || BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false)  or  Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Neutral = true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Neutral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_ATO_Neutral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door of the car opened and flashes went off."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He was simply looking around at the extraordinary interior design of the Maroon Palace. Statues, paintings and various ornaments filled both sides of the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "We passed the corridor and entered the reception hall. Th..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "We passed the corridor and entered the reception hall. The crowd inside was composed of various politicians and state figures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Upon our entry, they started clapping. Dry martinis were ..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Upon our entry, they started clapping. Dry martinis were handed to both of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Ladies and gentlemen. I present to you, President Walker.”"*)
  - -> `[111]` (*Player: "“Everyone. Let's give a warm welcome to our guest of honor.”"*)
  - -> `[109]` (*Player: "“Don't mind us. We were just passing by.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Don't mind us. We were just passing by.”"]** — Mówca: **Player**
> "“Don't mind us. We were just passing by.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "People laughed and started clapping."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Ladies and gentlemen. I present to you, President Walker.”"]** — Mówca: **Player**
> "“Ladies and gentlemen. I present to you, President Walker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "People started clapping."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Everyone. Let's give a warm welcome to our guest of honor.”"]** — Mówca: **Player**
> "“Everyone. Let's give a warm welcome to our guest of honor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "People started clapping."*)

### Węzeł `[112]`
Mówca: **Dwight Walker**
> "“Thank you. President Rayne. It is really good to be here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Dwight Walker: "“And thank you everyone for the warm welcome.”"*)

### Węzeł `[113]`
Mówca: **Dwight Walker**
> "“And thank you everyone for the warm welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ArcasiaMusic");"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "People started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Dwight Walker: "“Thank you. President Rayne. It is really good to be here.”"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "With another thunderous round of applause, the jazz band started playing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "President Walker and I separated and started mingling wit..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "People laughed and started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Dwight Walker: "“Thank you. President Rayne. It is really good to be here.”"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "President Walker and I separated and started mingling with the crowd. The reception was in full swing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "After some time chatting with the attendees, President Wa..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "She looked over at me before smiling at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Monica: "“Yes, of course. If I can call you Dwight.”"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "After some time chatting with the attendees, President Walker approached us. He bowed before my wife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Dwight Walker: "“Ms. Rayne. Can I call you Monica?”"*)

### Węzeł `[120]`
Mówca: **Dwight Walker**
> "“Ms. Rayne. Can I call you Monica?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "She looked over at me before smiling at him."*)

### Węzeł `[121]`
Mówca: **Monica**
> "“Yes, of course. If I can call you Dwight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "He took her hand and they started dancing. I turned aroun..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "He took her hand and they started dancing. I turned around to talk to the waiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "I was into my third martini when I heard a whistle. I tur..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "I was into my third martini when I heard a whistle. I turned around and saw Monica, dancing very closely with President Walker. All eyes in the room were on them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "President Walker grabbed Monica's waist."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "President Walker grabbed Monica's waist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“President Walker, why don't we have a chat somewhere qui..."*)
  - -> `[126]` (*Player_Italic: "Interject and dance with Monica yourself."*)
  - -> `[127]` (*Player_Italic: "Finish your martini."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“President Walker, why don't we have a chat somewhere quiet?”"]** — Mówca: **Player**
> "“President Walker, why don't we have a chat somewhere quiet?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Dwight Walker: "“Right when we were getting to the good part.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "Interject and dance with Monica yourself."]** — Mówca: **Player_Italic**
> "I moved in and caught an opportunity to take Monica's hand. We started dancing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "We hadn't danced since our wedding. I was struggling to r..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "Finish your martini."]** — Mówca: **Player_Italic**
> "I watched from the sidelines and finished my martini while faking claps and smiles."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Swirling around, Monica looked like she was having fun."*)

### Węzeł `[128]`
Mówca: **Dwight Walker**
> "“Right when we were getting to the good part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Dwight Walker: "“Fine. Let's have a chat.”"*)

### Węzeł `[129]`
Mówca: **Dwight Walker**
> "“Fine. Let's have a chat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The President and I swapped our drinks for Erlory Maroon ..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "The band played on. For a moment, it felt like it was only the two of us in the room. We moved together as one, seamlessly gliding across the dance floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "At some point, a spotlight began shining on us. As the so..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "We hadn't danced since our wedding. I was struggling to remember the right steps. President Walker was watching us with his arms crossed and a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Monica: "“It's right, right, left, right.”"*)

### Węzeł `[132]`
Mówca: **Monica**
> "“It's right, right, left, right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "As Monica whispered the steps in my ear, I followed along..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "As Monica whispered the steps in my ear, I followed along -- at first hesitantly, then smoother and more confident. It was starting to come back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "The band played on. For a moment, it felt like it was onl..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "At some point, a spotlight began shining on us. As the song came to an end, I spun Monica around and dramatically dipped her on the last beat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Applause and whistles echoed around us. We went back to t..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Applause and whistles echoed around us. We went back to the bar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: ""I can't believe we pulled that off.""*)
  - -> `[321]` (*Player: ""You saved me, Monica.""*)

### Węzeł `[136]`
Mówca: **Narrator**
> "President Walker approached, clapping and whistling himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Dwight Walker: "“Bravo! Bravo! Well done!”"*)

### Węzeł `[137]`
Mówca: **Dwight Walker**
> "“Bravo! Bravo! Well done!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Dwight Walker: "“I never took you for a dancer, Mr. Rayne.”"*)

### Węzeł `[138]`
Mówca: **Dwight Walker**
> "“I never took you for a dancer, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“That goes both ways, Mr. Walker.”"*)
  - -> `[140]` (*Player: "“Just one of my good qualities.”"*)
  - -> `[141]` (*Player: "“I thought I would mess it up.”"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“That goes both ways, Mr. Walker.”"]** — Mówca: **Player**
> "“That goes both ways, Mr. Walker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Dwight Walker: "“I do practice in my free time but, I could never hope to..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“Just one of my good qualities.”"]** — Mówca: **Player**
> "“Just one of my good qualities.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Dwight Walker: "“I'm beginning to see how you landed such a beautiful wife.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I thought I would mess it up.”"]** — Mówca: **Player**
> "“I thought I would mess it up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Dwight Walker: "“Well. You certainly didn't.”"*)

### Węzeł `[142]`
Mówca: **Dwight Walker**
> "“I'm beginning to see how you landed such a beautiful wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "The waiter came by and we swapped our empty glasses with ..."*)

### Węzeł `[143]`
Mówca: **Dwight Walker**
> "“I do practice in my free time but, I could never hope to be as good as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "The waiter came by and we swapped our empty glasses with ..."*)

### Węzeł `[144]`
Mówca: **Dwight Walker**
> "“Well. You certainly didn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "The waiter came by and we swapped our empty glasses with ..."*)

### Węzeł `[145]`
Mówca: **Dwight Walker**
> "“Let's talk about some business, shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The President and I swapped our drinks for Erlory Maroon ..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "The waiter came by and we swapped our empty glasses with filled ones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Dwight Walker: "“Let's talk about some business, shall we?”"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Swirling around, Monica looked like she was having fun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "They finally finished their dance after a few minutes and..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "They finally finished their dance after a few minutes and came over to the bar that I was leaning on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Dwight Walker: "“Monica. You are full of surprises.”"*)

### Węzeł `[149]`
Mówca: **Dwight Walker**
> "“Monica. You are full of surprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Monica: "“Thank you, Mr. Walker.”"*)

### Węzeł `[150]`
Mówca: **Dwight Walker**
> "“And Mr. Rayne. You are one lucky guy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "“We had enough fun. Let's talk about business.”"*)
  - -> `[151]` (*Player: "“I know, and I cherish every moment of it.”"*)
  - -> `[153]` (*Player: "“I hope you enjoyed your little dance.”"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I know, and I cherish every moment of it.”"]** — Mówca: **Player**
> "“I know, and I cherish every moment of it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“We had enough fun. Let's talk about business.”"]** — Mówca: **Player**
> "“We had enough fun. Let's talk about business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Dwight Walker: "“Right when I was just getting started.”"*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I hope you enjoyed your little dance.”"]** — Mówca: **Player**
> "“I hope you enjoyed your little dance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Dwight Walker: "“I think we both did, right Monica?”"*)

### Węzeł `[154]`
Mówca: **Monica**
> "“Thank you, Mr. Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Dwight Walker: "“And Mr. Rayne. You are one lucky guy.”"*)

### Węzeł `[155]`
Mówca: **Dwight Walker**
> "“I think we both did, right Monica?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Monica: "“Yes, Dwight. Thank you for accompanying me.”"*)

### Węzeł `[156]`
Mówca: **Monica**
> "“Yes, Dwight. Thank you for accompanying me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)

### Węzeł `[157]`
Mówca: **Narrator**
> "Monica looked at me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Dwight Walker: "“Ah. You lovebirds.”"*)

### Węzeł `[158]`
Mówca: **Dwight Walker**
> "“Ah. You lovebirds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The President and I swapped our drinks for Erlory Maroon ..."*)

### Węzeł `[159]`
Mówca: **Dwight Walker**
> "“Fine. Let's have a chat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The President and I swapped our drinks for Erlory Maroon ..."*)

### Węzeł `[160]`
Mówca: **Dwight Walker**
> "“Right when I was just getting started.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Dwight Walker: "“Fine. Let's have a chat.”"*)

### Węzeł `[161]`
Mówca: **Narrator**
> "The President and I swapped our drinks for Erlory Maroon 30 year olds. I knew a special spot. With our drinks at hand, we went down the stairs to the basement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Gradually, the music and the sound of the party started t..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "He took a seat and I followed suit. He pulled out two cigars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "“I don't smoke, Mr. Walker. Thanks.”"*)
  - -> `[164]` (*Player_Italic: "Take one of the cigars."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“I don't smoke, Mr. Walker. Thanks.”"]** — Mówca: **Player**
> "“I don't smoke, Mr. Walker. Thanks.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Dwight Walker: "“These are the best cigars in the world. I guarantee it. ..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "Take one of the cigars."]** — Mówca: **Player_Italic**
> "I took one of the cigars."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "He pulled out a Rippo lighter and lit my cigar before lig..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Gradually, the music and the sound of the party started to fade away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "We arrived at a cozy little corner office with not much i..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "We arrived at a cozy little corner office with not much inside other than a table and comfortable chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He took a seat and I followed suit. He pulled out two cig..."*)

### Węzeł `[167]`
Mówca: **Dwight Walker**
> "“These are the best cigars in the world. I guarantee it. Are you sure?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: "“Yes, I am sure.”"*)
  - -> `[169]` (*Player: "“Well, when you put it like that... sure.”"*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“Yes, I am sure.”"]** — Mówca: **Player**
> "“Yes, I am sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He pulled out a Rippo lighter and lit his cigar."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Well, when you put it like that... sure.”"]** — Mówca: **Player**
> "“Well, when you put it like that... sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "He pulled out a Rippo lighter and lit my cigar before lig..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "He pulled out a Rippo lighter and lit my cigar before lighting his own."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_PressRelease == true"*)

### Węzeł `[171]`
Mówca: **Narrator**
> "He pulled out a Rippo lighter and lit his cigar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_PressRelease == true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "We clinked our glasses and took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Dwight Walker: "“Ah. This is a really good one. Very smoky. I like it.”"*)

### Węzeł `[173]`
Mówca: **Dwight Walker**
> "“Ah. This is a really good one. Very smoky. I like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "“I'm glad you liked it.”"*)
  - -> `[174]` (*Player: "“Never had an Erlory Maroon before?”"*)
  - -> `[176]` (*Player_Italic: "Wait for him to start the conversation."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Never had an Erlory Maroon before?”"]** — Mówca: **Player**
> "“Never had an Erlory Maroon before?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "He took a puff from his cigar, filling the small room wit..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“I'm glad you liked it.”"]** — Mówca: **Player**
> "“I'm glad you liked it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "He took a puff from his cigar, filling the small room wit..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "Wait for him to start the conversation."]** — Mówca: **Player_Italic**
> "I waited for him to start the conversation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "He took a puff from his cigar, filling the small room wit..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "He took a puff from his cigar, filling the small room with smoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Dwight Walker: "“Definitely miles better than Valgslandian whiskey.”"*)

### Węzeł `[178]`
Mówca: **Dwight Walker**
> "“Definitely miles better than Valgslandian whiskey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Dwight Walker: "“But, I like Lespian whiskey more. It pairs better with t..."*)

### Węzeł `[179]`
Mówca: **Dwight Walker**
> "“But, I like Lespian whiskey more. It pairs better with their cigars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Dwight Walker: "“You see, Mr. Rayne. Whiskeys are a little bit like count..."*)

### Węzeł `[180]`
Mówca: **Dwight Walker**
> "“You see, Mr. Rayne. Whiskeys are a little bit like countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Dwight Walker: "“Some are stronger, some are weaker. Some are older, some..."*)

### Węzeł `[181]`
Mówca: **Dwight Walker**
> "“Some are stronger, some are weaker. Some are older, some are younger. Many are complex but sometimes simple is the best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Dwight Walker: "“I personally like stronger whiskeys in general. That's w..."*)

### Węzeł `[182]`
Mówca: **Dwight Walker**
> "“I personally like stronger whiskeys in general. That's why I liked this one. Yes. It is definitely promising.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Dwight Walker: "“But whatever you drink, in the end, it all boils down to..."*)

### Węzeł `[183]`
Mówca: **Dwight Walker**
> "“But whatever you drink, in the end, it all boils down to your own taste. And I assure you, Mr. Rayne. My sense of taste is *very* refined.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Dwight Walker: "“What type of whiskey do you like?”"*)

### Węzeł `[184]`
Mówca: **Dwight Walker**
> "“What type of whiskey do you like?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“I like complex flavours.”"*)
  - -> `[185]` (*Player: "“I like stronger ones.”"*)
  - -> `[186]` (*Player: "“I prefer wine.”"*)
  - -> `[187]` (*Player: "“I am good with whatever is made here in Sordland.”"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I like stronger ones.”"]** — Mówca: **Player**
> "“I like stronger ones.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Dwight Walker: "“A man after my own heart.”"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“I prefer wine.”"]** — Mówca: **Player**
> "“I prefer wine.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "He bursted into a laugh."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“I am good with whatever is made here in Sordland.”"]** — Mówca: **Player**
> "“I am good with whatever is made here in Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Dwight Walker: "“A fine answer but a bit restricted, I would say.”"*)

### Węzeł `[188]`
Mówca: **Dwight Walker**
> "“A fine answer but a bit restricted, I would say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "He tugged at his tie to loosen it a little."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "He bursted into a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Dwight Walker: "“Good one, Mr. Rayne.”"*)

### Węzeł `[190]`
Mówca: **Dwight Walker**
> "“Good one, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "He tugged at his tie to loosen it a little."*)

### Węzeł `[191]`
Mówca: **Dwight Walker**
> "“A man after my own heart.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "He tugged at his tie to loosen it a little."*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“I like complex flavours.”"]** — Mówca: **Player**
> "“I like complex flavours.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Dwight Walker: "“As good as they are, they can get tiring.”"*)

### Węzeł `[193]`
Mówca: **Dwight Walker**
> "“As good as they are, they can get tiring.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "He tugged at his tie to loosen it a little."*)

### Węzeł `[194]`
Mówca: **Dwight Walker**
> "“You know why I'm here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Dwight Walker: "“I want to make you an offer.”"*)

### Węzeł `[195]`
Mówca: **Narrator**
> "He tugged at his tie to loosen it a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti == true || BaseGame.Tu..."*)

### Węzeł `[196]`
Mówca: **Dwight Walker**
> "“I want to make you an offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: "“The type I can't refuse?”"*)
  - -> `[198]` (*Player: "“I'm listening.”"*)
  - -> `[199]` (*Player: "“I was waiting for this moment.”"*)
  - -> `[216]` (*Player: "“Let's get it over with.”"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“The type I can't refuse?”"]** — Mówca: **Player**
> "“The type I can't refuse?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Dwight Walker: "“Of course not. This is an offer. Not an order.”"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Dwight Walker: "“Good.”"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“I was waiting for this moment.”"]** — Mówca: **Player**
> "“I was waiting for this moment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Dwight Walker: "“Good.”"*)

### Węzeł `[200]`
Mówca: **Dwight Walker**
> "“Of course not. This is an offer. Not an order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Dwight Walker: "“Listen closely.”"*)

### Węzeł `[201]`
Mówca: **Dwight Walker**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Dwight Walker: "“Listen closely.”"*)

### Węzeł `[202]`
Mówca: **Dwight Walker**
> "“Listen closely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_PressRelease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_PressRelease == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Enable_PressRelease == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_PressRelease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Enable_PressRelease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Dwight Walker: "“I heard you got into a scandal. Something about a secret..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Enable_PressRelease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Enable_PressRelease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "We clinked our glasses and took a sip."*)

### Węzeł `[206]`
Mówca: **Dwight Walker**
> "“I heard you got into a scandal. Something about a secretary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: "“Truly unfortunate chain of events.”"*)
  - -> `[208]` (*Player: "“Yes. What of it?”"*)
  - -> `[207]` (*Player: "“Let's not talk about the scandal. We have much more impo..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "“Let's not talk about the scandal. We have much more important matters to discuss.”"]** — Mówca: **Player**
> "“Let's not talk about the scandal. We have much more important matters to discuss.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He grinned."*)

### Węzeł `[208]`
**[WYBÓR GRACZA: "“Yes. What of it?”"]** — Mówca: **Player**
> "“Yes. What of it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He grinned."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "“Truly unfortunate chain of events.”"]** — Mówca: **Player**
> "“Truly unfortunate chain of events.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Dwight Walker: "“Indeed.”"*)

### Węzeł `[210]`
Mówca: **Dwight Walker**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He grinned."*)

### Węzeł `[211]`
Mówca: **Dwight Walker**
> "“Relax. It's just a scandal and I'm no reporter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Dwight Walker: "“I just made it out alive of a bad one myself. Oof. It wa..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Dwight Walker: "“Relax. It's just a scandal and I'm no reporter.”"*)

### Węzeł `[213]`
Mówca: **Dwight Walker**
> "“I just made it out alive of a bad one myself. Oof. It was a rough one too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Dwight Walker: "“You get used to it. A couple of people in prison, couple..."*)

### Węzeł `[214]`
Mówca: **Dwight Walker**
> "“You get used to it. A couple of people in prison, couple people silenced... you know the drill.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Dwight Walker: "“Cheers to your survival then, Mr. Rayne.”"*)

### Węzeł `[215]`
Mówca: **Dwight Walker**
> "“Cheers to your survival then, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "We clinked our glasses and took a sip."*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Let's get it over with.”"]** — Mówca: **Player**
> "“Let's get it over with.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Dwight Walker: "“Listen closely.”"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Dwight Walker: "“I know that you are preparing to go to war against Rumbu..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Dwight Walker: "“Times are changing and so is the balance of the world.”"*)

### Węzeł `[220]`
Mówca: **Dwight Walker**
> "“I know that you are preparing to go to war against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Dwight Walker: "“And that your embargo on United Contana makes me the onl..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Dwight Walker: "“I am willing to support you in your endeavour.”"*)

### Węzeł `[224]`
Mówca: **Dwight Walker**
> "“And that your embargo on United Contana makes me the only superpower that you can align with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Dwight Walker: "“I am willing to support you in your endeavour.”"*)

### Węzeł `[225]`
Mówca: **Dwight Walker**
> "“I am willing to support you in your endeavour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Against == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Against == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Against == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_FPnT_ATO_Against == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Against == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_FPnT_ATO_Against"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_FPnT_ATO_Against == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_FPnT_ATO_Against"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Aligned == true"*)

### Węzeł `[229]`
Mówca: **Dwight Walker**
> "“But understand that I am saying this despite your attempts to get closer to Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Dwight Walker: "“And that has a price. So here is my offer.”"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true || BaseGame.Valgsla..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Dwight Walker: "“But understand that I am saying this despite your attemp..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true || BaseGame.Valgsland_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Dwight Walker: "“But understand that I am saying this despite your previo..."*)

### Węzeł `[233]`
Mówca: **Dwight Walker**
> "“But understand that I am saying this despite your previous actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Dwight Walker: "“And that has a price. So here is my offer.”"*)

### Węzeł `[234]`
Mówca: **Dwight Walker**
> "“And that has a price. So here is my offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Dwight Walker: "“ATO will generously welcome you as a member state. You w..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Aligned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Aligned == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_FPnT_ATO_Aligned == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_ATO_Aligned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_FPnT_ATO_Aligned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Dwight Walker: "“I think there is much we can achieve together and you ha..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_FPnT_ATO_Aligned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_FPnT_ATO_Aligned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Dwight Walker: "“If you accept, I would like to extend you a warm welcome..."*)

### Węzeł `[238]`
Mówca: **Dwight Walker**
> "“I think there is much we can achieve together and you have shown me the proof.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[239]`
Mówca: **Dwight Walker**
> "“ATO will generously welcome you as a member state. You will have all privileges and responsibilities that come with it. I want to underline responsibilities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Dwight Walker: "“In return, ATO will attach as a parallel military struct..."*)

### Węzeł `[240]`
Mówca: **Dwight Walker**
> "“In return, ATO will attach as a parallel military structure next to the Sordish military. That includes all branches. Air, navy, army. We will provide our very own Generals to work alongside the Sordish command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Dwight Walker: "“Please try to understand me, Mr. Rayne. Under normal cir..."*)

### Węzeł `[241]`
Mówca: **Dwight Walker**
> "“Please try to understand me, Mr. Rayne. Under normal circumstances, this is not required of ATO members. But this is the price I am putting on the survival of your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Arcasia_Military_Influence =..."*)

### Węzeł `[242]`
Mówca: **Dwight Walker**
> "“If you ask me it is a generous price in return for all the privileges you will receive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Dwight Walker: "“Before you answer, let me assure you. If you reject my k..."*)

### Węzeł `[243]`
Mówca: **Dwight Walker**
> "“If you accept, I would like to extend you a warm welcome to ATO as a full member state. This of course comes along with lots of privileges and responsibilities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Dwight Walker: "“In ATO, we protect each other. We have a mutual defense ..."*)

### Węzeł `[244]`
Mówca: **Dwight Walker**
> "“Join us, Mr. Rayne and you will have the entire backing of ATO. Soldiers, jet fighters, warships... whatever you like.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Dwight Walker: "“During peacetime, you will see the effects even more! Ou..."*)

### Węzeł `[245]`
Mówca: **Dwight Walker**
> "“All I ask in return is mutual loyalty to one another in the pact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Dwight Walker: "“The Sordish Armed Forces will be a member of the ATO mil..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Dwight Walker: "“A friend of Lespia is our friend as well.”"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Dwight Walker: "“If you accept, I would like to extend you a warm welcome..."*)

### Węzeł `[249]`
Mówca: **Dwight Walker**
> "“A friend of Lespia is our friend as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Dwight Walker: "“If you accept, I would like to extend you a warm welcome..."*)

### Węzeł `[250]`
Mówca: **Dwight Walker**
> "“Let's make history. Here. Tonight. What do you say?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[283]` (*Player: "“Is that all you are asking for? I was expecting more dem..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[280]` (*Player: "“Thank you for the offer however, we currently have no pl..."*)

### Węzeł `[251]`
Mówca: **Dwight Walker**
> "“In ATO, we protect each other. We have a mutual defense clause in the case of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Dwight Walker: "“Join us, Mr. Rayne and you will have the entire backing ..."*)

### Węzeł `[252]`
Mówca: **Dwight Walker**
> "“During peacetime, you will see the effects even more! Our combined production output will benefit both Sordland and ATO. We will have free-trade zone agreements, free visa access, investments, you name it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Dwight Walker: "“All I ask in return is mutual loyalty to one another in ..."*)

### Węzeł `[253]`
Mówca: **Dwight Walker**
> "“Before you answer, let me assure you. If you reject my kind offer, you won't like the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[254]` (*Player: "“Do you dare threaten me here, in my palace?”"*)
  - -> `[257]` (*Player: "“You can't expect me to hand over the military command to..."*)
  - -> `[262]` (*Player: "“It appears that I thought wrongly about you. I decline, ..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA: "“Do you dare threaten me here, in my palace?”"]** — Mówca: **Player**
> "“Do you dare threaten me here, in my palace?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Dwight Walker: "“Hah. Yes I am. It wouldn't be my first time threatening ..."*)

### Węzeł `[255]`
Mówca: **Dwight Walker**
> "“Hah. Yes I am. It wouldn't be my first time threatening a president in his palace either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Dwight Walker: "“So, what will it be, Mr. Rayne? Will you be able to prot..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA: "“I accept, Mr. Walker. [Join ATO, Break Alliance with Valgsland, -2 Government Budget]”"]** — Mówca: **Player**
> "“I accept, Mr. Walker.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[253]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "“You can't expect me to hand over the military command to you.”"]** — Mówca: **Player**
> "“You can't expect me to hand over the military command to you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Dwight Walker: "“You won't be handing over the entire military command. O..."*)

### Węzeł `[258]`
Mówca: **Dwight Walker**
> "“So, what will it be, Mr. Rayne? Will you be able to protect your own country at the cost of your own pride?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[266]` (*Player: "“I have to decline, Mr. Walker.”"*)

### Węzeł `[259]`
Mówca: **Dwight Walker**
> "“You won't be handing over the entire military command. Only a part of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Dwight Walker: "“Besides, that part is not up for negotiation. Take it or..."*)

### Węzeł `[260]`
Mówca: **Dwight Walker**
> "“Besides, that part is not up for negotiation. Take it or leave it. Your choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[266]` (*Player: "“I have to decline, Mr. Walker.”"*)

### Węzeł `[261]`
Mówca: **Dwight Walker**
> "“That's what I'd like to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "We stood up and shook hands."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: "“It appears that I thought wrongly about you. I decline, Mr. Walker.”"]** — Mówca: **Player**
> "“It appears that I thought wrongly about you. I decline, Mr. Walker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Dwight Walker: "“Then that's too bad. You have doomed your country, Mr. R..."*)

### Węzeł `[263]`
Mówca: **Dwight Walker**
> "“Then that's too bad. You have doomed your country, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Dwight Walker: "“May God help you and your country.”"*)

### Węzeł `[264]`
Mówca: **Dwight Walker**
> "“May God help you and your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "He grabbed his glass and downed the remaining whiskey."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "“Very well. I accept. [Join ATO, Break Alliance with Valgsland, -2 Government Budget]”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[258]` (Dwight Walker), `[260]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“I have to decline, Mr. Walker.”"]** — Mówca: **Player**
> "“I have to decline, Mr. Walker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Dwight Walker), `[260]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Dwight Walker: "“Then that's too bad. You have doomed your country, Mr. R..."*)

### Węzeł `[267]`
Mówca: **Dwight Walker**
> "“Welcome to ATO, Mr. Rayne. Welcome home.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Dwight Walker: "“Cheers to new found partnerships!”"*)

### Węzeł `[268]`
Mówca: **Narrator**
> "We stood up and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Dwight Walker: "“Welcome to ATO, Mr. Rayne. Welcome home.”"*)

### Węzeł `[269]`
Mówca: **Dwight Walker**
> "“Cheers to new found partnerships!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "We clinked our glasses and downed the remaining whiskey."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "We clinked our glasses and downed the remaining whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Lespia", "All..."*)

### Węzeł `[271]`
Mówca: **Dwight Walker**
> "“Now it's starting to taste better!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Dwight Walker: "“Let's go upstairs, Mr. Rayne. We have much to discuss.”"*)

### Węzeł `[272]`
Mówca: **Dwight Walker**
> "“Let's go upstairs, Mr. Rayne. We have much to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Dwight Walker: "“But, more importantly... we need to celebrate!”"*)

### Węzeł `[273]`
Mówca: **Dwight Walker**
> "“But, more importantly... we need to celebrate!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Dwight Walker: "“Besides, I have a few more dance moves to show off.”"*)

### Węzeł `[274]`
Mówca: **Narrator**
> "He grabbed his glass and downed the remaining whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Dwight Walker: "“This tastes like piss.”"*)

### Węzeł `[275]`
Mówca: **Dwight Walker**
> "“This tastes like piss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Dwight Walker: "“I'm going upstairs to join the party to wash the bad tas..."*)

### Węzeł `[276]`
Mówca: **Dwight Walker**
> "“I'm going upstairs to join the party to wash the bad taste left in my mouth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Dwight Walker: "“I will leave at first light.”"*)

### Węzeł `[277]`
Mówca: **Dwight Walker**
> "“I will leave at first light.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)

### Węzeł `[278]`
Mówca: **Dwight Walker**
> "“Goodbye, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "“I say aye! I accept, Mr. Walker.  [Join ATO, Break Alliance with Valgsland, -2 Government Budget]”"]** — Mówca: **Player**
> "“I say aye! I accept, Mr. Walker.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[250]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "“Thank you for the offer however, we currently have no plans to enter ATO.”"]** — Mówca: **Player**
> "“Thank you for the offer however, we currently have no plans to enter ATO.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Dwight Walker: "“At least I know that I tried.”"*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "“I assure you we can hold our own against Rumburg just fine.”"]** — Mówca: **Player**
> "“I assure you we can hold our own against Rumburg just fine.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[250]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Dwight Walker: "“I didn't mean any offence, Mr. Rayne. I am fully aware o..."*)

### Węzeł `[282]`
Mówca: **Dwight Walker**
> "“I didn't mean any offence, Mr. Rayne. I am fully aware of the capabilities of the mighty Sordish Armed Forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Dwight Walker: "“Where I am coming is more so from the perspective of fri..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "“Is that all you are asking for? I was expecting more demands.”"]** — Mówca: **Player**
> "“Is that all you are asking for? I was expecting more demands.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Dwight Walker: "“But, why, Mr. Rayne? In my mind we are already aligned.”"*)

### Węzeł `[284]`
Mówca: **Dwight Walker**
> "“But, why, Mr. Rayne? In my mind we are already aligned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Dwight Walker: "“Where I am coming is more so from the perspective of fri..."*)

### Węzeł `[285]`
Mówca: **Dwight Walker**
> "“Where I am coming is more so from the perspective of friendship and stability in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Dwight Walker: "“There is much to gain for both of us which makes this th..."*)

### Węzeł `[286]`
Mówca: **Dwight Walker**
> "“There is much to gain for both of us which makes this the perfect partnership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[291]` (*Player: "“Unfortunately I can't accept your offer, Mr. Walker.”"*)

### Węzeł `[287]`
Mówca: **Dwight Walker**
> "“At least I know that I tried.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Dwight Walker: "“Don't close yourself to the opportunity. Maybe you are n..."*)

### Węzeł `[288]`
Mówca: **Dwight Walker**
> "“Don't close yourself to the opportunity. Maybe you are not ready now but you might be ready in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Dwight Walker: "“I usually get what I want, Mr. Rayne and trust me, you w..."*)

### Węzeł `[289]`
Mówca: **Dwight Walker**
> "“I usually get what I want, Mr. Rayne and trust me, you won't get rid of me that easily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "He smiled and we shook hands."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "He smiled and we shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Dwight Walker: "“Regardless, it was good to meet with you. I hope this is..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA: "“Unfortunately I can't accept your offer, Mr. Walker.”"]** — Mówca: **Player**
> "“Unfortunately I can't accept your offer, Mr. Walker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Dwight Walker: "“At least I know that I tried.”"*)

### Węzeł `[292]`
**[WYBÓR GRACZA: "“Very well. I accept. [Join ATO, Break Alliance with Valgsland, -2 Government Budget]”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[286]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[293]`
Mówca: **Dwight Walker**
> "“Regardless, it was good to meet with you. I hope this is the start of something good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "He grabbed his glass and downed the remaining whiskey."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "He grabbed his glass and downed the remaining whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Dwight Walker: "“Now it starts to taste better!”"*)

### Węzeł `[295]`
Mówca: **Dwight Walker**
> "“Now it starts to taste better!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Dwight Walker: "“Let's go upstairs, Mr. Rayne and join the party, Mr. Ray..."*)

### Węzeł `[296]`
Mówca: **Dwight Walker**
> "“Let's go upstairs, Mr. Rayne and join the party, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)

### Węzeł `[297]`
Mówca: **Dwight Walker**
> "“I have a few more dance moves to show off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[298]`
Mówca: **Dwight Walker**
> "“Besides, I have a few more dance moves to show off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO = true;"*)

### Węzeł `[299]`
Mówca: **Dwight Walker**
> "“Times are changing and so is the balance of the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Dwight Walker: "“Soon, instead of a fractured world, we will see a more u..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Dwight Walker: "“Besides, your embargo on United Contana makes ATO the on..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Dwight Walker: "“I want you by our side. The winning side.”"*)

### Węzeł `[303]`
Mówca: **Dwight Walker**
> "“Besides, your embargo on United Contana makes ATO the only side that you can align with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Dwight Walker: "“I want you by our side. The winning side.”"*)

### Węzeł `[304]`
Mówca: **Dwight Walker**
> "“Soon, instead of a fractured world, we will see a more united world. There is us, ATO against them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[305]`
Mówca: **Dwight Walker**
> "“I want you by our side. The winning side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_ATO_Against == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: "“I assure you we can hold our own against Rumburg just fi..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: "“I assure you we can hold out our own just fine.”"*)

### Węzeł `[309]`
**[WYBÓR GRACZA: "“I assure you we can hold out our own just fine.”"]** — Mówca: **Player**
> "“I assure you we can hold out our own just fine.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Dwight Walker: "“I didn't mean any offence, Mr. Rayne. I am fully aware o..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Joined_ATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 5; BaseGame.Sollist -= 2; BaseGame..."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "Next to the maroon carpet to the palace, Sordish troops were lined up. Sordish war planes flew above our heads, painting the sky with the colors of the Sordish flag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "As soon as President Walker stepped on the carpet, all of..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "On the way to the entrance we stopped in front of Iosef w..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "On the way to the entrance we stopped in front of General..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "On the way to the entrance we stopped in front of Iosef who was in charge of the troops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "President Walker saluted him and the soldiers. They salut..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "President Walker saluted him and the soldiers. They saluted back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "As soon as our inspection finished, we entered the palace."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "As soon as our inspection finished, we entered the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Dwight Walker: "“Mr. President. One would think you are prepared to go to..."*)

### Węzeł `[318]`
Mówca: **Dwight Walker**
> "“The Sordish Armed Forces will be a member of the ATO military structure. All branches be it air, navy, army will collaborate with the alliance network. We will provide assistance and training for free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Dwight Walker: "“Our armies will learn how to fight together and be stron..."*)

### Węzeł `[319]`
Mówca: **Dwight Walker**
> "“Our armies will learn how to fight together and be stronger than ever in the face of the Malenyevist threat!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Arcasia_Military_Support = true"*)

### Węzeł `[320]`
**[WYBÓR GRACZA: ""I can't believe we pulled that off.""]** — Mówca: **Player**
> ""I can't believe we pulled that off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)

### Węzeł `[321]`
**[WYBÓR GRACZA: ""You saved me, Monica.""]** — Mówca: **Player**
> ""You saved me, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion <= 0)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "Monica blinked and abruptly removed her hand from mine."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Monica: ""At your service, Mr. President.""*)

### Węzeł `[325]`
Mówca: **Monica**
> ""Next time, let me take care of myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "President Walker approached, clapping and whistling himself."*)

### Węzeł `[326]`
Mówca: **Monica**
> ""At your service, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "President Walker approached, clapping and whistling himself."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "Monica blinked and abruptly removed her hand from mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Monica: ""Next time, let me take care of myself.""*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion <= 0)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "Monica gave me an extremely strained smile."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Monica looked at me and smiled."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "Monica gave me an extremely strained smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Dwight Walker: "“Ah. You lovebirds.”"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion <= 0)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "Behind his back, she gave me a taunting look."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Behind his back, she grimaced at me and exaggeratedly hel..."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Behind his back, she grimaced at me and exaggeratedly held her nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The President and I swapped our drinks for Erlory Maroon ..."*)

### Węzeł `[336]`
Mówca: **Narrator**
> "Behind his back, she gave me a taunting look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The President and I swapped our drinks for Erlory Maroon ..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_MarcelKoronti == true || BaseGame.Turn07_Fled_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti == true || BaseGame.Tu..."*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Fled_MarcelKoronti == true || BaseGame...."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_MarcelKoronti == true || BaseGame.Turn07_Fled_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_Fled_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Dwight Walker: "“It has come to my ears that two businessmen from your co..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Fled_MarcelKoronti == true || BaseGame.Turn07_Fled_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_Fled_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Dwight Walker: "“You know why I'm here.”"*)

### Węzeł `[340]`
Mówca: **Dwight Walker**
> "“As you know, Arcasia is a country that has freedom at its very foundation. Anyone is welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Dwight Walker: "“But, make no mistake. I have no compassion for deserters.”"*)

### Węzeł `[341]`
Mówca: **Dwight Walker**
> "“But, make no mistake. I have no compassion for deserters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Dwight Walker: "“I can send them back to you if you want.”"*)

### Węzeł `[342]`
Mówca: **Dwight Walker**
> "“It has come to my ears that two businessmen from your country are now living in Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Dwight Walker: "“Their names are Marcel Koronti and Walter Tusk.”"*)

### Węzeł `[343]`
Mówca: **Dwight Walker**
> "“Their names are Marcel Koronti and Walter Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Dwight Walker: "“As you know, Arcasia is a country that has freedom at it..."*)

### Węzeł `[344]`
Mówca: **Dwight Walker**
> "“I can send them back to you if you want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame..."*)
  - -> `[345]` (*Player: "“Thank you, but there is no need. I don't care about them..."*)
  - -> `[346]` (*Player: "“Please do. They can't be living the good life after disr..."*)
  - -> `[347]` (*Player: "“This can't be for free. What do you want in return?”"*)

### Węzeł `[345]`
**[WYBÓR GRACZA: "“Thank you, but there is no need. I don't care about them at all.”"]** — Mówca: **Player**
> "“Thank you, but there is no need. I don't care about them at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Dwight Walker: "“Very well.”"*)

### Węzeł `[346]`
**[WYBÓR GRACZA: "“Please do. They can't be living the good life after disrespecting me the way they did.”"]** — Mówca: **Player**
> "“Please do. They can't be living the good life after disrespecting me the way they did.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Oligarchs_Extradited = true"*)

### Węzeł `[347]`
**[WYBÓR GRACZA: "“This can't be for free. What do you want in return?”"]** — Mówca: **Player**
> "“This can't be for free. What do you want in return?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Dwight Walker: "“Let's just say that this is a sign of my goodwill.”"*)

### Węzeł `[348]`
Mówca: **Dwight Walker**
> "“Let's just say that this is a sign of my goodwill.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""All right. Deport the bastards.""*)
  - -> `[359]` (*Player: ""No, don't do anything. It wouldn't be right.""*)

### Węzeł `[349]`
Mówca: **Dwight Walker**
> "“Very well. I will have them deported back to their homeland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Dwight Walker: "“Now that is out of the way, let's cut to the chase.”"*)

### Węzeł `[350]`
Mówca: **Dwight Walker**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Dwight Walker: "“Now that is out of the way, let's cut to the chase.”"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Oligarchs_Extradited = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Oligarchs_Extradited"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Dwight Walker: "“Very well. I will have them deported back to their homel..."*)

### Węzeł `[352]`
Mówca: **Dwight Walker**
> "“Now that is out of the way, let's cut to the chase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Dwight Walker: "“You know why I'm here.”"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame..."*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGa..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player: "“As a matter of fact, Tusk is under investigation and Kor..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Oligarchs == true && BaseGame.Turn08_SnO_KorontiInvestigationStopped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WYBÓR GRACZA: "“As a matter of fact, Tusk is under investigation and Koronti already belongs in prison. Yes, please send them back.""]** — Mówca: **Player**
> "“As a matter of fact, Tusk is under investigation and Koronti already belongs in prison. Yes, please send them back.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] == true  and  Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] == false`
- **Kontekst wejściowy (poprzednik):** `[344]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Dwight Walker: "“Justice must be served, yes.""*)

### Węzeł `[357]`
Mówca: **Dwight Walker**
> "“Justice must be served, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Oligarchs_Extradited = true"*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""All right. Deport the bastards.""]** — Mówca: **Player**
> ""All right. Deport the bastards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Oligarchs_Extradited = true"*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""No, don't do anything. It wouldn't be right.""]** — Mówca: **Player**
> ""No, don't do anything. It wouldn't be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Dwight Walker: "“Very well.”"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance = false; BaseGame.Valgsland_Alliance_Cancelled = true;
BaseGameSupport.News_Turn09_G_ATO_ValgslandAlliance_Cancelled = true;
BaseGameSupport.News_Turn09_HP_ATO_ValgslandAlliance_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_Alliance"] = false;
Variable["BaseGame.Valgsland_Alliance_Cancelled"] = true;
Variable["BaseGameSupport.News_Turn09_G_ATO_ValgslandAlliance_Cancelled"] = true;
Variable["BaseGameSupport.News_Turn09_HP_ATO_ValgslandAlliance_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Joined_ATO = true"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Neutrality = false; BaseGame.Po..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Arcasia_Military_Influence =..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Neutrality = false;
BaseGame.Policy_Diplomacy_ATO = true;
BaseGame.Policy_Diplomacy_Valgsland_Alliance = false;
BaseGame.Policy_Diplomacy_TradeZone_Valgsland = false;
BaseGame.Policy_Diplomacy_EmbargoingArcasia = false;

BaseGame.Policy_Diplomacy_TradeInitiative = true;
BaseGame.Policy_Military_JointMilitaryExercises = true;
BaseGame.Policy_Military_ATO_Officers = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
Variable["BaseGame.Policy_Diplomacy_ATO"] = true;
Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] = false;
Variable["BaseGame.Policy_Diplomacy_TradeZone_Valgsland"] = false;
Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] = false;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;
Variable["BaseGame.Policy_Military_ATO_Officers"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_ArcasianInfluence = true; Ba..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_ArcasianInfluence = true;
BaseGame.Situation_Diplomacy_LackOfAllies = false;
BaseGame.Situation_Diplomacy_StrategicAllianceMember = true;
BaseGame.Situation_Diplomacy_UnitedContanaTradeHalt = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;
BaseGame.Situation_Diplomacy_RumburgAggression = false;
BaseGame.Situation_Diplomacy_DiplomaticPressure = false;

BaseGame.Situation_Military_LackOfEquipment = false;
BaseGame.Situation_Military_OutdatedMilitaryEquipment = false;
BaseGame.Situation_Military_AdequatelyEquippedMilitary = true;
BaseGame.Situation_Military_ModernisedAirForce = true;

BaseGame.Situation_Economy_FinancialInvestment_UC = false;
BaseGame.Situation_Economy_FinancialInvestment_Arcasia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_ArcasianInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;
Variable["BaseGame.Situation_Diplomacy_StrategicAllianceMember"] = true;
Variable["BaseGame.Situation_Diplomacy_UnitedContanaTradeHalt"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
Variable["BaseGame.Situation_Diplomacy_RumburgAggression"] = false;
Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = false;
Variable["BaseGame.Situation_Military_LackOfEquipment"] = false;
Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] = false;
Variable["BaseGame.Situation_Military_AdequatelyEquippedMilitary"] = true;
Variable["BaseGame.Situation_Military_ModernisedAirForce"] = true;
Variable["BaseGame.Situation_Economy_FinancialInvestment_UC"] = false;
Variable["BaseGame.Situation_Economy_FinancialInvestment_Arcasia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Valgsland", "Country_..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Arcasia_Military_Influence =..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Arcasia_Military_Support = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Support"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Dwight Walker: "“Let's make history. Here. Tonight. What do you say?”"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Dwight Walker: "“If you ask me it is a generous price in return for all t..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence = false;
BaseGame.Situation_Diplomacy_Arcasia_Military_Support = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] = false;
Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Support"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Arcasia_Military_Influence =..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Arcasia_Military_Influence..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_ATOMilitaryStructure = true; ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Arcasia_Military_Influence == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Arcasia_Military_Influence"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_ATOMilitaryStructure = true;
BaseGame.Situation_Military_HappyMilitaryPersonnel = false;
BaseGame.Situation_Military_UnhappyMilitaryPersonnel = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Military_ATOMilitaryStructure"] = true;
Variable["BaseGame.Situation_Military_HappyMilitaryPersonnel"] = false;
Variable["BaseGame.Situation_Military_UnhappyMilitaryPersonnel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Joined_ATO = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Joined_ATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_ATO");"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Joined_ATO = true; 
BaseGameSupport.FactionReport_Turn09_ATO_WelcomesSordland = true;
BaseGameSupport.CountryReport_Turn09_Derdia_CursesATOJoin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Joined_ATO"] = true;
Variable["BaseGameSupport.FactionReport_Turn09_ATO_WelcomesSordland"] = true;
Variable["BaseGameSupport.CountryReport_Turn09_Derdia_CursesATOJoin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Joined_ATO");"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance = false; BaseGame.Valgsland_A..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Joined_ATO = true"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && ..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Dwight Walker: "“I have a few more dance moves to show off. Unlike Sordla..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Dwight Walker: "“I have a few more dance moves to show off.”"*)

### Węzeł `[386]`
Mówca: **Dwight Walker**
> "“I have a few more dance moves to show off. Unlike Sordland, I don't dance alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && ..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Dwight Walker: "“It's a shame that Sordland stands alone. Goodbye, Mr. Ra..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Dwight Walker: "“Goodbye, Mr. Rayne.”"*)

### Węzeł `[390]`
Mówca: **Dwight Walker**
> "“It's a shame that Sordland stands alone. Goodbye, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player: "“Very well. I accept. [Join ATO, Break Alliance with Valg..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: "“Very well. I accept. [Join ATO]”"*)

### Węzeł `[394]`
**[WYBÓR GRACZA: "“Very well. I accept. [Join ATO]”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[286]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: "“I say aye! I accept, Mr. Walker.  [Join ATO, Break Allia..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player: "“I say aye! I accept, Mr. Walker. [Join ATO]”"*)

### Węzeł `[398]`
**[WYBÓR GRACZA: "“I say aye! I accept, Mr. Walker. [Join ATO]”"]** — Mówca: **Player**
> "“I say aye! I accept, Mr. Walker.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[250]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: "“Very well. I accept. [Join ATO, Break Alliance with Valg..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player: "“Very well. I accept. [Join ATO]”"*)

### Węzeł `[402]`
**[WYBÓR GRACZA: "“Very well. I accept. [Join ATO]”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[258]` (Dwight Walker), `[260]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: "“I accept, Mr. Walker. [Join ATO, Break Alliance with Val..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Player: "“I accept, Mr. Walker. [Join ATO]”"*)

### Węzeł `[406]`
**[WYBÓR GRACZA: "“I accept, Mr. Walker. [Join ATO]”"]** — Mówca: **Player**
> "“I accept, Mr. Walker.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[253]` (Dwight Walker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Dwight Walker: "“That's what I'd like to hear.”"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 5;
BaseGame.Sollist -= 2;
BaseGame.Malenyevist -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Lespia", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Valgsland", "..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Valgsland", "Hostile");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Dwight Walker: "“Now it's starting to taste better!”"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("ArcasiaMusic");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("ArcasiaMusic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "With another thunderous round of applause, the jazz band ..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = true; BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = false; 
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_ATOMarketInfluencesEnergy ..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = true; BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = false; 
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = true;..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation ==..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignManipulation =..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = true; 
BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = false;
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced = true; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_ATOMarketInfluencesEnergy ..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_ATO");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_ATO");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_Sordland_ATO_EconomicArea");"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_Alliance");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Valgsland", "Country_..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_Trade");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Lespia", "Country_Les..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_Sordland_ATO_EconomicArea");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_ATO_EconomicArea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Lespia", "All..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Lespia", "Country_Lespia_TradeTariffs");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Country_Lespia_TradeTariffs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Lespia", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Joined_ATO = true;  BaseGa..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_ATOMarketInfluencesEnergy = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_ATOMarketInfluencesEnergy"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Joined_ATO");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Joined_ATO");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
