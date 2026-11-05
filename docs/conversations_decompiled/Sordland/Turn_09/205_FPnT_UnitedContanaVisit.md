# Sordland/Turn09/FPnT_UnitedContanaVisit

- **ID konwersacji:** `205`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/205_FPnT_UnitedContanaVisit.md`
- **Liczba węzłów dialogowych:** 514
- **Liczba wyborów gracza:** 92

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[38]** Lucian Galade
- **[47]** Leon Malenyev

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_Alliance_Cancelled`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Hegel_PutInAGoodWordWithMalenyev`
- `BaseGame.Joined_CSP`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_Alliance_Cancelled`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.SuperpowerVisit_ExtravagantWelcome`
- `BaseGame.SuperpowerVisit_MilitaryWelcome`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA`
- `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB`
- `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_Alliance_Cancelled`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Capitalist`
- `BaseGame.GovernmentBudget`
- `BaseGame.Heljiland_Map_Layer`
- `BaseGame.Joined_CSP`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_Alliance_Cancelled`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised`
- `BaseGame.Policy_Diplomacy_CSP`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_TradeInitiative`
- `BaseGame.Policy_Diplomacy_TradeZone_Lespia`
- `BaseGame.Policy_Military_CSP_Officers`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Situation_Diplomacy_ArcasiaTradeHalt`
- `BaseGame.Situation_Diplomacy_Contana_Military_Support`
- `BaseGame.Situation_Diplomacy_Contana_Missile_Duru_Island`
- `BaseGame.Situation_Diplomacy_ContananInfluence`
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
- `BaseGame.Situation_Economy_FinancialInvestment_Arcasia`
- `BaseGame.Situation_Economy_FinancialInvestment_UC`
- `BaseGame.Situation_Military_AdequatelyEquippedMilitary`
- `BaseGame.Situation_Military_LackOfEquipment`
- `BaseGame.Situation_Military_ModernisedNavy`
- `BaseGame.Situation_Military_OutdatedMilitaryEquipment`
- `BaseGame.Situation_Military_UCAntiAirMissle_DuruIsland`
- `BaseGame.Sollist`
- `BaseGame.Turn09_Agnolia_CancelledHeljilandRecognition`
- `BaseGameIsolated.Turn09_FPnT_CSP_Against`
- `BaseGameIsolated.Turn09_FPnT_CSP_Aligned`
- `BaseGameIsolated.Turn09_FPnT_CSP_Neutral`
- `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA`
- `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB`
- `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC`
- `BaseGameSupport.CountryReport_Turn09_Morella_CongratulatesCSPJoin`
- `BaseGameSupport.FactionReport_Turn09_CSP_WelcomesSordland`
- `BaseGameSupport.Journal_Turn09_Joined_CSP`
- `BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Agnolia`
- `BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_AgnoliaLespia`
- `BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Lespia`
- `BaseGameSupport.News_Turn09_HP_Joined_CSP`
- `BaseGameSupport.News_Turn10_HP_CSPMarketInfluencesEnergy`
- `GameCondition.Turn09_FPnT_SuperpowerVisit`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **""How was your flight?""** | `[70]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Leon Malenyev**: ""It was definitely very long. Bu..." |
| `[21]` | **"Don't laugh."** | `[79]` **Narrator**: "As I was trying to formulate a r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "He smiled." |
| `[22]` | **"“I wanted extravagance, not a circus show. What the hell is this?”"** | `[5]` **Lucian Galade**: "“Is the welcome to your liking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucian Galade**: "“But... but I don't understand, ..." |
| `[23]` | **"Laugh."** | `[79]` **Narrator**: "As I was trying to formulate a r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "We started walking towards the r..." |
| `[24]` | **"“It looks good, Lucian. Good job.”"** | `[5]` **Lucian Galade**: "“Is the welcome to your liking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lucian Galade**: "“Thank you.”" |
| `[25]` | **"“As long as it does the trick, I don't care.”"** | `[5]` **Lucian Galade**: "“Is the welcome to your liking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: "“I am sure it will.”" |
| `[29]` | **"“Welcome to Sordland.”"** | `[43]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Leon Malenyev**: ""Thank you, Mr. Rayne."" |
| `[40]` | **""It is an honor to have you here.""** | `[70]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "He smiled thinly." |
| `[57]` | **""Please, this way. Let's move to the palace.""** | `[70]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Leon Malenyev**: ""Lead the way, Mr. President."" |
| `[62]` | **"“I've wanted to meet with you for the longest time.”"** | `[43]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Leon Malenyev**: ""You are very kind, Mr. Rayne."" |
| `[63]` | **"“It is wonderful to see you, Chairman Malenyev.”"** | `[43]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Leon Malenyev**: ""You are very kind, Mr. Rayne."" |
| `[71]` | **"“It is really good to see you, Chairman Malenyev.”"** | `[37]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Leon Malenyev**: ""You are very kind, Mr. Rayne."" |
| `[74]` | **"“I wanted to meet with you for the longest time.”"** | `[37]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Leon Malenyev**: ""You are very kind, Mr. Rayne."" |
| `[77]` | **"“Welcome to Sordland.”"** | `[37]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Leon Malenyev**: ""What a welcome, Mr. Rayne."" |
| `[82]` | **"“Welcome to Sordland.”"** | `[67]` **Narrator**: "Finally, I was within reach of o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Leon Malenyev**: ""What a welcome, Mr. Rayne. I di..." |
| `[85]` | **""It is an honor to have you here.""** | `[89]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "He smiled thinly." |
| `[86]` | **""Please, this way. Let's move to the palace.""** | `[89]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Leon Malenyev**: ""Lead the way, Mr. President."" |
| `[87]` | **"“I've wanted to meet with you for the longest time.”"** | `[67]` **Narrator**: "Finally, I was within reach of o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Leon Malenyev**: ""What a welcome, Mr. Rayne. I di..." |
| `[91]` | **""How was your flight?""** | `[89]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Leon Malenyev**: ""It was definitely very long. Bu..." |
| `[94]` | **"“It is wonderful to see you, Chairman Malenyev.”"** | `[67]` **Narrator**: "Finally, I was within reach of o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Leon Malenyev**: ""What a welcome, Mr. Rayne. I di..." |
| `[95]` | **""Didn't you like the ceremony, Chairman Malenyev?""** | `[89]` **Monica**: ""Likewise, Chairman Malenyev. We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Leon Malenyev**: ""I... am honored by the lengths ..." |
| `[97]` | **"“Don't mind us. We were just passing by.”"** | `[101]` **Narrator**: "Upon our entry, a crowd started ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Narrator**: "People laughed and started clapp..." |
| `[102]` | **"“Ladies and gentlemen. I present to you, Leon Malenyev.”"** | `[101]` **Narrator**: "Upon our entry, a crowd started ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "People started clapping." |
| `[103]` | **"“Everyone. Let's give a warm welcome to our guest of honor.”"** | `[101]` **Narrator**: "Upon our entry, a crowd started ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "People started clapping." |
| `[117]` | **""You are right. It is a scary concept.""** | `[118]` **Narrator**: "He took another sip." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Leon Malenyev**: ""I've seen many presidents and w..." |
| `[119]` | **""I believe you used your time relatively well so far, Chairman Malenyev. You had a..."** | `[118]` **Narrator**: "He took another sip." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "He laughed." |
| `[120]` | **""When I look at you, I don't see an old man.""** | `[118]` **Narrator**: "He took another sip." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "He laughed." |
| `[121]` | **"Take a sip from your glass."** | `[118]` **Narrator**: "He took another sip." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Leon Malenyev**: ""You see, Mr. Rayne..."" |
| `[129]` | **""Aren't you both?""** | `[127]` **Leon Malenyev**: ""What do you see? A hero of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "He chuckled." |
| `[130]` | **""Definitely not one of those two.""** | `[127]` **Leon Malenyev**: ""What do you see? A hero of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "He sneered." |
| `[131]` | **""I see a respectable man. And the leader of the strongest nation in the world.""** | `[127]` **Leon Malenyev**: ""What do you see? A hero of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "He sneered." |
| `[132]` | **""I'll pick 'old man' if those are my only options.""** | `[127]` **Leon Malenyev**: ""What do you see? A hero of the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Narrator**: "He chuckled." |
| `[142]` | **""Yes. It was built as his summer residence.""** | `[141]` **Leon Malenyev**: ""Was he the one? The original ow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Leon Malenyev**: ""I thought when Tarquin Soll cam..." |
| `[143]` | **""As far as I know, he didn't use it much. It was Soll who transformed this place.""** | `[141]` **Leon Malenyev**: ""Was he the one? The original ow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Leon Malenyev**: ""I thought when Tarquin Soll cam..." |
| `[144]` | **""His name is Albrecht Renan, Chairman Malenyev. And yes, he was.""** | `[141]` **Leon Malenyev**: ""Was he the one? The original ow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Leon Malenyev**: ""Oh, yes. Renan."" |
| `[146]` | **""I don't know. It's just a statue to me.""** | `[141]` **Leon Malenyev**: ""Was he the one? The original ow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Leon Malenyev**: ""To me, all of this has meaning...." |
| `[150]` | **""As a matter of fact, I am. My field was history before I entered politics.""** | `[149]` **Leon Malenyev**: ""You are not a man of history, t..." | `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true` | *Brak zmian stanu* | `[160]` **Leon Malenyev**: ""How come you are uninterested i..." |
| `[154]` | **""To be honest, not really.""** | `[149]` **Leon Malenyev**: ""You are not a man of history, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Leon Malenyev**: ""You cannot see what the future ..." |
| `[155]` | **""The future interests me more than the past.""** | `[149]` **Leon Malenyev**: ""You are not a man of history, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Leon Malenyev**: ""You cannot see what the future ..." |
| `[156]` | **""As a matter of fact, I am quite interested in history. Maybe just not the statues.""** | `[149]` **Leon Malenyev**: ""You are not a man of history, t..." | `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false` | *Brak zmian stanu* | `[160]` **Leon Malenyev**: ""How come you are uninterested i..." |
| `[157]` | **""I have no idea. You have to ask the man himself.""** | `[147]` **Leon Malenyev**: ""It is interesting that he remov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Leon Malenyev**: ""Well, I think he couldn't erase..." |
| `[158]` | **""I believe he was fond of both. He cared a lot about our national values.""** | `[147]` **Leon Malenyev**: ""It is interesting that he remov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Leon Malenyev**: ""Well, I think he couldn't erase..." |
| `[159]` | **""I know he despised the kingdom. But I think he still needed a glorious past to ma..."** | `[147]` **Leon Malenyev**: ""It is interesting that he remov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Leon Malenyev**: ""That's what I suspected. If it ..." |
| `[169]` | **""I completely agree. We need proper international cooperation to tackle these prob..."** | `[168]` **Leon Malenyev**: ""Don't you think we need to step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Leon Malenyev**: ""Precisely."" |
| `[170]` | **""I do. That's why I'm meeting with you. To change something.""** | `[168]` **Leon Malenyev**: ""Don't you think we need to step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Leon Malenyev**: ""Good."" |
| `[171]` | **""I think United Contana isn't entirely innocent in these conflicts.""** | `[168]` **Leon Malenyev**: ""Don't you think we need to step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Leon Malenyev**: ""I never claimed we were innocent."" |
| `[172]` | **""We can only do so much.""** | `[168]` **Leon Malenyev**: ""Don't you think we need to step..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Leon Malenyev**: ""Perhaps we cannot ever create o..." |
| `[181]` | **""Those days must have been devastating.""** | `[180]` **Leon Malenyev**: ""Today, the whole continent is a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Leon Malenyev**: ""They were. But the revolution l..." |
| `[182]` | **""In the end, you formed the largest country in the world.""** | `[180]` **Leon Malenyev**: ""Today, the whole continent is a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Leon Malenyev**: ""We have. And now our responsibi..." |
| `[186]` | **""There are many countries who look up to United Contana. You are not alone.""** | `[180]` **Leon Malenyev**: ""Today, the whole continent is a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Leon Malenyev**: ""That's exactly what our enemies..." |
| `[187]` | **""They are afraid of your power. Contana was never united before.""** | `[180]` **Leon Malenyev**: ""Today, the whole continent is a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Leon Malenyev**: ""They are afraid of the power of..." |
| `[206]` | **""Of course. Please follow me, Chairman Malenyev.""** | `[204]` **Leon Malenyev**: ""Can we talk somewhere a little ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "I led him up a set of back stair..." |
| `[207]` | **""Would you want to have a rest, Chairman Malenyev? We can talk later if you're not..."** | `[204]` **Leon Malenyev**: ""Can we talk somewhere a little ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Leon Malenyev**: ""Oh, no, I'm fine. I didn't come..." |
| `[235]` | **""Heljiland is an Agnolian island, Chairman Malenyev. We cannot interfere.""** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true` | *Brak zmian stanu* | `[251]` **Leon Malenyev**: ""Interfere? Do you think the Agn..." |
| `[239]` | **""Agnolia is our ally, Chairman Malenyev.""** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | `Variable["BaseGame.Agnolia_Alliance"] == true` | *Brak zmian stanu* | `[255]` **Leon Malenyev**: ""So you support what their gover..." |
| `[240]` | **""I don't want to interfere with the matters between Valgsland and Agnolia.""** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`<br>`(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false` | *Brak zmian stanu* | `[252]` **Leon Malenyev**: ""Unfortunately the time to take ..." |
| `[244]` | **""I believe Valgsland has the right to interfere. It's their people who are being m..."** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`<br>`(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false` | *Brak zmian stanu* | `[253]` **Leon Malenyev**: ""That's right. But for me, this ..." |
| `[245]` | **""Agnolia is definitely becoming a threat.""** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | `(Variable["BaseGame.Agnolia_Alliance"] == true) == false` | *Brak zmian stanu* | `[256]` **Leon Malenyev**: ""They are. Because Arcasia is fu..." |
| `[246]` | **""You are right, Chairman Malenyev. We can't.""** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Leon Malenyev**: ""Exactly. We cannot."" |
| `[247]` | **""Yes. I am behind Valgsland in this conflict.""** | `[231]` **Leon Malenyev**: ""We cannot allow that to happen,..." | `Variable["BaseGame.Valgsland_Alliance"] == true` | *Brak zmian stanu* | `[257]` **Leon Malenyev**: ""That's good to hear."" |
| `[266]` | **""I'm sure we can find a diplomatic solution with Agnolia.""** | `[265]` **Leon Malenyev**: ""United Contana will never allow..." | `Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true` | *Brak zmian stanu* | `[287]` **Leon Malenyev**: ""I'm afraid we're past that stag..." |
| `[267]` | **""I thought this was about people being killed.""** | `[265]` **Leon Malenyev**: ""United Contana will never allow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Leon Malenyev**: ""It is."" |
| `[274]` | **""So you think Arcasia's behind this?""** | `[265]` **Leon Malenyev**: ""United Contana will never allow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Leon Malenyev**: ""It's not a thought, Mr. Rayne. ..." |
| `[275]` | **""You are right, Chairman Malenyev. We can't let the western powers take control.""** | `[265]` **Leon Malenyev**: ""United Contana will never allow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Leon Malenyev**: ""So, you are ready to tear down ..."<br>`[292]` **Leon Malenyev**: ""Exactly."" |
| `[293]` | **""Yes, I am. For the good of the region.""** | `[283]` **Leon Malenyev**: ""...And break your alliance with..."<br>`[284]` **Leon Malenyev**: ""...And take away your support f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Narrator**: "He smiled." |
| `[294]` | **""Only if Sordland enters the CSP.""** | `[283]` **Leon Malenyev**: ""...And break your alliance with..."<br>`[284]` **Leon Malenyev**: ""...And take away your support f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Narrator**: "He smiled." |
| `[295]` | **""No. That's something I cannot do.""** | `[283]` **Leon Malenyev**: ""...And break your alliance with..."<br>`[284]` **Leon Malenyev**: ""...And take away your support f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Leon Malenyev**: ""Don't rush your decision."" |
| `[309]` | **""ATO says the same about the CSP.""** | `[307]` **Leon Malenyev**: ""Today, you need the CSP in orde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Leon Malenyev**: ""Okay, Mr. Rayne."" |
| `[310]` | **""I'm not sure if we *need* it, but I definitely want to cooperate.""** | `[307]` **Leon Malenyev**: ""Today, you need the CSP in orde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Leon Malenyev**: ""Don't get me wrong. Sordland is..." |
| `[311]` | **""That's why I have you here, Chairman Malenyev.""** | `[307]` **Leon Malenyev**: ""Today, you need the CSP in orde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Narrator**: "He lit his pipe and took a puff...." |
| `[322]` | **""What does the CSP offer for Sordland?""** | `[321]` **Leon Malenyev**: ""...So, hereby, I extend an invi..."<br>`[352]` **Leon Malenyev**: ""Chancellor Hegel told me that I..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true) == false` | *Brak zmian stanu* | `[326]` **Leon Malenyev**: ""Security. First and foremost, C..." |
| `[323]` | **""What do you expect in return?""** | `[321]` **Leon Malenyev**: ""...So, hereby, I extend an invi..."<br>`[352]` **Leon Malenyev**: ""Chancellor Hegel told me that I..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true) == false` | *Brak zmian stanu* | `[335]` **Leon Malenyev**: ""You must accept our doctrines a..." |
| `[324]` | **""Will you stand with us against the threat of Rumburg?""** | `[321]` **Leon Malenyev**: ""...So, hereby, I extend an invi..."<br>`[352]` **Leon Malenyev**: ""Chancellor Hegel told me that I..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC"] == true) == false` | *Brak zmian stanu* | `[356]` **Leon Malenyev**: ""Of course. Rumburg is a threat ..." |
| `[325]` | **""Unfortunately, I have to decline.""** | `[321]` **Leon Malenyev**: ""...So, hereby, I extend an invi..."<br>`[352]` **Leon Malenyev**: ""Chancellor Hegel told me that I..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true) == false` | *Brak zmian stanu* | `[417]` **Narrator**: "He narrowed his eyes and stared ..." |
| `[375]` | **""It's a deal, Chairman Malenyev. [Join CSP]""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Narrator**: "He smiled." |
| `[380]` | **""Yes. We will bring the war to them, before they are fully prepared.""** | `[358]` **Leon Malenyev**: ""But my agents told me that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Leon Malenyev**: ""I am not entirely sure about yo..." |
| `[381]` | **""I didn't want a war, but Rumburg pushed us to the edge.""** | `[358]` **Leon Malenyev**: ""But my agents told me that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Leon Malenyev**: ""I am not entirely sure about yo..." |
| `[382]` | **""You have agents in Sordland?""** | `[358]` **Leon Malenyev**: ""But my agents told me that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Narrator**: "He laughed." |
| `[389]` | **""Are you saying we shouldn't attack them?""** | `[387]` **Leon Malenyev**: ""Nobody wants to see that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Leon Malenyev**: ""I'm not trying to tell you what..." |
| `[390]` | **""Since when are you a pacifist, Chairman Malenyev?""** | `[387]` **Leon Malenyev**: ""Nobody wants to see that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Leon Malenyev**: ""I'm not trying to tell you what..." |
| `[391]` | **""What are you suggesting?""** | `[387]` **Leon Malenyev**: ""Nobody wants to see that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Leon Malenyev**: ""I'm not trying to tell you what..." |
| `[425]` | **""Of course, Chairman Malenyev. Please come this way.""** | `[424]` **Leon Malenyev**: ""Now, I'd like to have a rest, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Leon Malenyev**: ""Please."" |
| `[426]` | **""I wanted to make a deal today as well. But your terms were not acceptable.""** | `[424]` **Leon Malenyev**: ""Now, I'd like to have a rest, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Leon Malenyev**: ""It is fine, Mr. Rayne. You must..." |
| `[427]` | **""We might not have come to an agreement about the CSP, but I still want to have go..."** | `[424]` **Leon Malenyev**: ""Now, I'd like to have a rest, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Leon Malenyev**: ""Let's talk about that later, Mr..." |
| `[434]` | **""Of course, Chairman Malenyev. Please come this way.""** | `[433]` **Leon Malenyev**: ""Now, I'd like to have a rest, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[437]` **Leon Malenyev**: ""Please."" |
| `[435]` | **""Thank you for the meeting. It was a pleasure.""** | `[433]` **Leon Malenyev**: ""Now, I'd like to have a rest, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Leon Malenyev**: ""The pleasure is mine."" |
| `[479]` | **""It's a deal, Chairman Malenyev. [Join CSP, Break Alliance with Lespia and Agnolia..."** | `[321]` **Leon Malenyev**: ""...So, hereby, I extend an invi..." | `Variable["BaseGame.Agnolia_Alliance"] == true  and  Variable["BaseGame.Lespia_Alliance"] == true`<br>`Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true  and  Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true` | *Brak zmian stanu* | `[410]` **Narrator**: "He smiled." |
| `[480]` | **""It's a deal, Chairman Malenyev. [Join CSP, Break Alliance with Lespia, -2 Governm..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Narrator**: "He smiled." |
| `[481]` | **""It's a deal, Chairman Malenyev. [Join CSP, Break Alliance with Agnolia, -1 Govern..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Narrator**: "He smiled." |
| `[485]` | **"“It is wonderful to see you, Mr. Chavatangakwunua.”"** | `[43]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Leon Malenyev**: ""You are very kind, Mr. Rayne. N..." |
| `[486]` | **"“It is wonderful to see you, Mr. Chavatangakwunua.”"** | `[37]` **Narrator**: "We looked at each other and shoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Leon Malenyev**: ""You are very kind, Mr. Rayne. N..." |
| `[489]` | **"“It is wonderful to see you, Mr. Chavatangakwunua.”"** | `[67]` **Narrator**: "Finally, I was within reach of o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Leon Malenyev**: ""You are very kind, Mr. Rayne. N..." |

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
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Helj..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Leon Malenyev stepped on the carpet and started to make his way toward us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Monica and I walked over to meet him in the middle."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The door of the pitch black sedan opened and flashes went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The famous ideologue and CSP leader, Leon Malenyev, came ..."*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> "“Is the welcome to your liking, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“It looks good, Lucian. Good job.”"*)
  - -> `[22]` (*Player: "“I wanted extravagance, not a circus show. What the hell ..."*)
  - -> `[25]` (*Player: "“As long as it does the trick, I don't care.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The famous ideologue and CSP leader, Leon Malenyev, came out of the car, smiling and waving at the enormous crowd that gathered. It was not every day the Chairman of United Contana came to visit Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "He was wearing his usual "political uniform," grayish-gre..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Both sides of the maroon carpet leading up to the palace were lined with soldiers wearing military uniforms from Sordish history. They had swords, shields and spears. Some of them were on horseback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "As soon as Leon Malenyev stepped on the carpet, children ..."*)

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
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_MilitaryWelcome == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "He looked at the extraordinary interior design of the Maroon Palace. Statues, paintings and various ornaments filled both sides of the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Leon Malenyev: ""What a palace!""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_MilitaryWelcome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_MilitaryWelcome == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerVisit_MilitaryWelcome == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_MilitaryWelcome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "A maroon carpet stretched from the vehicle to the palace,..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerVisit_MilitaryWelcome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Leon Malenyev stepped on the carpet and started to make h..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "As soon as Leon Malenyev stepped on the carpet, children appeared and showered the road with roses. He approached the kids, knelt down and told them something which made them laugh for minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "It was then that the centuries-old Sordish sword dance st..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "We started walking towards the reception hall in the palace. Our path was cleared of people at once."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "He looked at the extraordinary interior design of the Mar..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucian approached my side and quietly whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: "“Is the welcome to your liking, sir?”"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "It was then that the centuries-old Sordish sword dance started. The show took around a minute at most, but Malenyev didn't even try to look like he was paying attention to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Lucian approached my side and quietly whispered."*)

### Węzeł `[19]`
Mówca: **Leon Malenyev**
> ""It was definitely very long. But it was fine. I tried to sleep most of the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""How was your flight?""]** — Mówca: **Player**
> ""How was your flight?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Leon Malenyev: ""It was definitely very long. But it was fine. I tried to..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Don't laugh."]** — Mówca: **Player_Italic**
> "I didn't laugh with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "He smiled."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I wanted extravagance, not a circus show. What the hell is this?”"]** — Mówca: **Player**
> "“I wanted extravagance, not a circus show. What the hell is this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: "“But... but I don't understand, sir. I did everything you..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Laugh."]** — Mówca: **Player_Italic**
> "I tried to laugh with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“It looks good, Lucian. Good job.”"]** — Mówca: **Player**
> "“It looks good, Lucian. Good job.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: "“Thank you.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“As long as it does the trick, I don't care.”"]** — Mówca: **Player**
> "“As long as it does the trick, I don't care.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“I am sure it will.”"*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> "“But... but I don't understand, sir. I did everything you asked.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Seeing Malenyev approach, Lucian stood back."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "He looked at me with an expressionless face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "As I was trying to formulate a response, he placed his ha..."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Seeing Malenyev approach, Lucian stood back."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Welcome to Sordland.”"]** — Mówca: **Player**
> "“Welcome to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Leon Malenyev: ""Thank you, Mr. Rayne.""*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I am sure it will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Seeing Malenyev approach, Lucian stood back."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "As soon as our inspection finished, we entered the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Leon Malenyev: ""I don't think your army needs to put on such airs in the..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "As soon as Leon Malenyev stepped on the carpet, all of the soldiers performed a hard salute. Celebratory gunshots were fired. Trumpets started playing a Sordish march."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Monica and I walked over to meet him in the middle."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Monica and I walked over to meet him in the middle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Finally, I was within reach of one of the most powerful m..."*)

### Węzeł `[34]`
Mówca: **Leon Malenyev**
> ""I don't think your army needs to put on such airs in the midst of a burgeoning global conflict. War is not show business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He looked at me with an expressionless face."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Finally, I was within reach of one of the most powerful men in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "We looked at each other and shook hands."*)

### Węzeł `[36]`
Mówca: **Leon Malenyev**
> ""Thank you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "We looked at each other and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“It is really good to see you, Chairman Malenyev.”"*)
  - -> `[74]` (*Player: "“I wanted to meet with you for the longest time.”"*)
  - -> `[77]` (*Player: "“Welcome to Sordland.”"*)
  - -> `[486]` (*Player: "“It is wonderful to see you, Mr. Chavatangakwunua.”"*)

### Węzeł `[38]`
Mówca: **Leon Malenyev**
> ""You are very kind, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "He turned to Monica and shook her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Leon Malenyev: ""Mrs. Rayne. A pleasure to meet you.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""It is an honor to have you here.""]** — Mówca: **Player**
> ""It is an honor to have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "He smiled thinly."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Monica and I walked over to meet him in the middle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Finally, I was within reach of one of the most powerful m..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Finally, I was within reach of one of the most powerful men in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "We looked at each other and shook hands."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "We looked at each other and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“It is wonderful to see you, Chairman Malenyev.”"*)
  - -> `[62]` (*Player: "“I've wanted to meet with you for the longest time.”"*)
  - -> `[29]` (*Player: "“Welcome to Sordland.”"*)
  - -> `[485]` (*Player: "“It is wonderful to see you, Mr. Chavatangakwunua.”"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "As soon as our inspection finished, we entered the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Leon Malenyev: ""I don't think your army needs to put on such airs in the..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Helj..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_He..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_CSP_Against = true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true |..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_CSP_Against = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_CSP_Against"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door of the pitch black sedan opened and flashes went..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_CSP_Aligned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_CSP_Aligned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door of the pitch black sedan opened and flashes went..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Valgsland_Alliance == true || BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true |..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Valgsland_Alliance == true || BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_CSP_Aligned = true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Valgsland_Alliance == true || BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_CSP_Neutral = true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "On the way to the entrance we stopped in front of Iosef w..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "On the way to the entrance we stopped in front of General..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_CSP_Neutral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_CSP_Neutral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door of the pitch black sedan opened and flashes went..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Please, this way. Let's move to the palace.""]** — Mówca: **Player**
> ""Please, this way. Let's move to the palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Leon Malenyev: ""Lead the way, Mr. President.""*)

### Węzeł `[58]`
Mówca: **Narrator**
> "On the way to the entrance we stopped in front of Iosef who was in charge of the troops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Malenyev smiled at the soldiers and saluted them. They sa..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "He smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "A maroon carpet stretched from the vehicle to the palace, lined with Sordish troops. War planes flew above our heads, painting the sky with the colors of the Sordish flag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "As soon as Leon Malenyev stepped on the carpet, all of th..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Malenyev smiled and saluted Valken and the soldiers. They saluted back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "As soon as our inspection finished, we entered the palace."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I've wanted to meet with you for the longest time.”"]** — Mówca: **Player**
> "“I've wanted to meet with you for the longest time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Leon Malenyev: ""You are very kind, Mr. Rayne.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It is wonderful to see you, Chairman Malenyev.”"]** — Mówca: **Player**
> "“It is wonderful to see you, Chairman Malenyev.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Leon Malenyev: ""You are very kind, Mr. Rayne.""*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Seeing Malenyev approach, Lucian stood back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Finally, I was within reach of one of the most powerful m..."*)

### Węzeł `[65]`
Mówca: **Leon Malenyev**
> ""Mrs. Rayne. A pleasure to meet you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Monica: ""Likewise, Chairman Malenyev. Welcome to Sordland.""*)

### Węzeł `[66]`
Mówca: **Leon Malenyev**
> ""Lead the way, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Finally, I was within reach of one of the most powerful men in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "“It is wonderful to see you, Chairman Malenyev.”"*)
  - -> `[87]` (*Player: "“I've wanted to meet with you for the longest time.”"*)
  - -> `[82]` (*Player: "“Welcome to Sordland.”"*)
  - -> `[489]` (*Player: "“It is wonderful to see you, Mr. Chavatangakwunua.”"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Malenyev smiled at the soldiers and saluted them. They saluted back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "As soon as our inspection finished, we entered the palace."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "On the way to the entrance we stopped in front of General Valken who was in charge of the troops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Malenyev smiled and saluted Valken and the soldiers. They..."*)

### Węzeł `[70]`
Mówca: **Monica**
> ""Likewise, Chairman Malenyev. Welcome to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""How was your flight?""*)
  - -> `[40]` (*Player: ""It is an honor to have you here.""*)
  - -> `[57]` (*Player: ""Please, this way. Let's move to the palace.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“It is really good to see you, Chairman Malenyev.”"]** — Mówca: **Player**
> "“It is really good to see you, Chairman Malenyev.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Leon Malenyev: ""You are very kind, Mr. Rayne.""*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He turned to Monica and shook her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Leon Malenyev: ""It is nice to meet you, Mrs. Rayne.""*)

### Węzeł `[73]`
Mówca: **Leon Malenyev**
> ""You are very kind, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I wanted to meet with you for the longest time.”"]** — Mówca: **Player**
> "“I wanted to meet with you for the longest time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Leon Malenyev: ""You are very kind, Mr. Rayne.""*)

### Węzeł `[75]`
Mówca: **Leon Malenyev**
> ""What a welcome, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[76]`
Mówca: **Monica**
> ""Likewise, Chairman Malenyev. Welcome to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Welcome to Sordland.”"]** — Mówca: **Player**
> "“Welcome to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Leon Malenyev: ""What a welcome, Mr. Rayne.""*)

### Węzeł `[78]`
Mówca: **Leon Malenyev**
> ""It is nice to meet you, Mrs. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Monica: ""Likewise, Chairman Malenyev. Welcome to Sordland.""*)

### Węzeł `[79]`
Mówca: **Narrator**
> "As I was trying to formulate a response, he placed his hand on my shoulder and laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Italic: "Laugh."*)
  - -> `[21]` (*Player_Italic: "Don't laugh."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Leon Malenyev: ""Relax, Mr. Rayne.""*)

### Węzeł `[81]`
Mówca: **Leon Malenyev**
> ""Relax, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Welcome to Sordland.”"]** — Mówca: **Player**
> "“Welcome to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Leon Malenyev: ""What a welcome, Mr. Rayne. I didn't know Sordland was th..."*)

### Węzeł `[83]`
Mówca: **Leon Malenyev**
> ""What a welcome, Mr. Rayne. I didn't know Sordland was this connected to its feudal past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "He turned to Monica and shook her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Leon Malenyev: ""It is nice to meet you, Mrs. Rayne.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""It is an honor to have you here.""]** — Mówca: **Player**
> ""It is an honor to have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He smiled thinly."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Please, this way. Let's move to the palace.""]** — Mówca: **Player**
> ""Please, this way. Let's move to the palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Leon Malenyev: ""Lead the way, Mr. President.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I've wanted to meet with you for the longest time.”"]** — Mówca: **Player**
> "“I've wanted to meet with you for the longest time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Leon Malenyev: ""What a welcome, Mr. Rayne. I didn't know Sordland was th..."*)

### Węzeł `[88]`
Mówca: **Leon Malenyev**
> ""It is nice to meet you, Mrs. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Monica: ""Likewise, Chairman Malenyev. Welcome to Sordland.""*)

### Węzeł `[89]`
Mówca: **Monica**
> ""Likewise, Chairman Malenyev. Welcome to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""How was your flight?""*)
  - -> `[85]` (*Player: ""It is an honor to have you here.""*)
  - -> `[86]` (*Player: ""Please, this way. Let's move to the palace.""*)
  - -> `[95]` (*Player: ""Didn't you like the ceremony, Chairman Malenyev?""*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""How was your flight?""]** — Mówca: **Player**
> ""How was your flight?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Leon Malenyev: ""It was definitely very long. But it was fine. I tried to..."*)

### Węzeł `[92]`
Mówca: **Leon Malenyev**
> ""It was definitely very long. But it was fine. I tried to sleep most of the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[93]`
Mówca: **Leon Malenyev**
> ""Lead the way, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“It is wonderful to see you, Chairman Malenyev.”"]** — Mówca: **Player**
> "“It is wonderful to see you, Chairman Malenyev.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Leon Malenyev: ""What a welcome, Mr. Rayne. I didn't know Sordland was th..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Didn't you like the ceremony, Chairman Malenyev?""]** — Mówca: **Player**
> ""Didn't you like the ceremony, Chairman Malenyev?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Leon Malenyev: ""I... am honored by the lengths to which you went, Mr. Ra..."*)

### Węzeł `[96]`
Mówca: **Leon Malenyev**
> ""I... am honored by the lengths to which you went, Mr. Rayne. Truly impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We started walking towards the reception hall in the pala..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Don't mind us. We were just passing by.”"]** — Mówca: **Player**
> "“Don't mind us. We were just passing by.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "People laughed and started clapping."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "People laughed and started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ContanaMusic");"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "At that moment, we came to the end of the corridor and entered the reception hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Upon our entry, a crowd started clapping. It was composed..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "He took a seat and I followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Leon Malenyev: ""It's very nice of you to throw a party for me before our..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Upon our entry, a crowd started clapping. It was composed of various politicians and state figures. Dry martinis were handed to both of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Ladies and gentlemen. I present to you, Leon Malenyev.”"*)
  - -> `[103]` (*Player: "“Everyone. Let's give a warm welcome to our guest of honor.”"*)
  - -> `[97]` (*Player: "“Don't mind us. We were just passing by.”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Ladies and gentlemen. I present to you, Leon Malenyev.”"]** — Mówca: **Player**
> "“Ladies and gentlemen. I present to you, Leon Malenyev.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "People started clapping."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Everyone. Let's give a warm welcome to our guest of honor.”"]** — Mówca: **Player**
> "“Everyone. Let's give a warm welcome to our guest of honor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "People started clapping."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "We arrived at a cozy little corner office with not much inside other than a table and comfortable chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "He took a seat and I followed suit."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "People started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ContanaMusic");"*)

### Węzeł `[106]`
Mówca: **Narrator**
> "Gradually, the music and the sound of the party started to fade away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "We arrived at a cozy little corner office with not much i..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "With another thunderous round of applause, the Contanian band started playing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Malenyev and I started talking to the other guests. The r..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "He and I swapped our drinks for glasses of Erlory Maroon 30-Year-Old. I knew a special spot. With our drinks in hand, we went down the stairs to the basement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "Gradually, the music and the sound of the party started t..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Malenyev and I started talking to the other guests. The reception was in full swing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "After some time chatting with the attendees, Malenyev tur..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "After some time chatting with the attendees, Malenyev turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Leon Malenyev: ""Can we go someplace where we can hear each other better?""*)

### Węzeł `[111]`
Mówca: **Leon Malenyev**
> ""Can we go someplace where we can hear each other better?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "He and I swapped our drinks for glasses of Erlory Maroon ..."*)

### Węzeł `[112]`
Mówca: **Leon Malenyev**
> ""It's very nice of you to throw a party for me before our official talks, but I am still slightly tired from the long journey over the ocean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Leon Malenyev: ""Forgive me if I didn't seem too enthusiastic about the r..."*)

### Węzeł `[113]`
Mówca: **Leon Malenyev**
> ""Forgive me if I didn't seem too enthusiastic about the reception. I just don't have the same energy of my youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "He smiled and took a sip from his glass. Then he sighed."*)

### Węzeł `[114]`
Mówca: **Leon Malenyev**
> ""Time is a funny concept, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Leon Malenyev: ""You cannot feel it in the moment, only to realize later ..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "He smiled and took a sip from his glass. Then he sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Leon Malenyev: ""Time is a funny concept, isn't it?""*)

### Węzeł `[116]`
Mówca: **Leon Malenyev**
> ""You cannot feel it in the moment, only to realize later that your life passed you by. And one day you look in the mirror and see an old man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "He took another sip."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""You are right. It is a scary concept.""]** — Mówca: **Player**
> ""You are right. It is a scary concept.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Leon Malenyev: ""I've seen many presidents and world leaders change durin..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "He took another sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""You are right. It is a scary concept.""*)
  - -> `[119]` (*Player: ""I believe you used your time relatively well so far, Cha..."*)
  - -> `[120]` (*Player: ""When I look at you, I don't see an old man.""*)
  - -> `[121]` (*Player_Italic: "Take a sip from your glass."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I believe you used your time relatively well so far, Chairman Malenyev. You had a very full life.""]** — Mówca: **Player**
> ""I believe you used your time relatively well so far, Chairman Malenyev. You had a very full life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He laughed."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""When I look at you, I don't see an old man.""]** — Mówca: **Player**
> ""When I look at you, I don't see an old man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He laughed."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Take a sip from your glass."]** — Mówca: **Player_Italic**
> "I also took a sip from my glass."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Leon Malenyev: ""You see, Mr. Rayne...""*)

### Węzeł `[122]`
Mówca: **Leon Malenyev**
> ""I've seen many presidents and world leaders change during my lifetime. I've seen toppled governments, civil wars and war crimes. I fought against imperialism and the capitalist plutocracies that took its place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Leon Malenyev: ""I look at the world today and think, it has changed so m..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Leon Malenyev: ""I've seen many presidents and world leaders change durin..."*)

### Węzeł `[124]`
Mówca: **Leon Malenyev**
> ""I look at the world today and think, it has changed so much since I joined the Rotskis as a young revolutionary...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Leon Malenyev: ""But then I look at it again and realize nothing much has..."*)

### Węzeł `[125]`
Mówca: **Leon Malenyev**
> ""But then I look at it again and realize nothing much has really changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Leon Malenyev: ""It is perhaps even more divided than ever. There are sti..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Leon Malenyev: ""What do you see? A hero of the proletariat? The red scou..."*)

### Węzeł `[127]`
Mówca: **Leon Malenyev**
> ""What do you see? A hero of the proletariat? The red scourge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""I see a respectable man. And the leader of the strongest..."*)
  - -> `[130]` (*Player: ""Definitely not one of those two.""*)
  - -> `[129]` (*Player: ""Aren't you both?""*)
  - -> `[132]` (*Player: ""I'll pick 'old man' if those are my only options.""*)

### Węzeł `[128]`
Mówca: **Leon Malenyev**
> ""You see, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Leon Malenyev: ""I've seen many presidents and world leaders change durin..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Aren't you both?""]** — Mówca: **Player**
> ""Aren't you both?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "He chuckled."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Definitely not one of those two.""]** — Mówca: **Player**
> ""Definitely not one of those two.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He sneered."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I see a respectable man. And the leader of the strongest nation in the world.""]** — Mówca: **Player**
> ""I see a respectable man. And the leader of the strongest nation in the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He sneered."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I'll pick 'old man' if those are my only options.""]** — Mówca: **Player**
> ""I'll pick 'old man' if those are my only options.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He chuckled."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "He chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Leon Malenyev: ""That's the right one. There is no need for needless exag..."*)

### Węzeł `[134]`
Mówca: **Leon Malenyev**
> ""Pfft. Say it like it is, Mr. Rayne. I'm just an old man. There is no need for exaggeration. You can speak your mind freely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Leon Malenyev: ""I've seen many presidents and world leaders change durin..."*)

### Węzeł `[135]`
Mówca: **Leon Malenyev**
> ""You surprised me. It's usually one or the other, depending on who you're asking. But never together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Leon Malenyev: ""In the end, I'm just an old man.""*)

### Węzeł `[136]`
Mówca: **Narrator**
> "He chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Leon Malenyev: ""You surprised me. It's usually one or the other, dependi..."*)

### Węzeł `[137]`
Mówca: **Leon Malenyev**
> ""That's the right one. There is no need for needless exaggeration. We are all men. And I'm an old one at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Leon Malenyev: ""I've seen many presidents and world leaders change durin..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He sneered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Leon Malenyev: ""Pfft. Say it like it is, Mr. Rayne. I'm just an old man...."*)

### Węzeł `[139]`
Mówca: **Leon Malenyev**
> ""What a palace!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He pointed at one of the statues in the corner as we walk..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "He pointed at one of the statues in the corner as we walked. It was a white marble sculpted representation of Albrecht Renan, the founder of the Renan Aristocracy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Leon Malenyev: ""Was he the one? The original owner of the Maroon Palace?""*)

### Węzeł `[141]`
Mówca: **Leon Malenyev**
> ""Was he the one? The original owner of the Maroon Palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""Yes. It was built as his summer residence.""*)
  - -> `[143]` (*Player: ""As far as I know, he didn't use it much. It was Soll who..."*)
  - -> `[144]` (*Player: ""His name is Albrecht Renan, Chairman Malenyev. And yes, ..."*)
  - -> `[146]` (*Player: ""I don't know. It's just a statue to me.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Yes. It was built as his summer residence.""]** — Mówca: **Player**
> ""Yes. It was built as his summer residence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Leon Malenyev: ""I thought when Tarquin Soll came to power, he worked tow..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""As far as I know, he didn't use it much. It was Soll who transformed this place.""]** — Mówca: **Player**
> ""As far as I know he didn't use it much. It was Soll who transformed this place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Leon Malenyev: ""I thought when Tarquin Soll came to power, he worked tow..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""His name is Albrecht Renan, Chairman Malenyev. And yes, he was.""]** — Mówca: **Player**
> ""His name is Albrecht Renan, Chairman Malenyev. And yes, he was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Leon Malenyev: ""Oh, yes. Renan.""*)

### Węzeł `[145]`
Mówca: **Leon Malenyev**
> ""I thought when Tarquin Soll came to power, he worked towards removing the republic's connection to its feudal past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Leon Malenyev: ""It is interesting that he removed the images of the last..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""I don't know. It's just a statue to me.""]** — Mówca: **Player**
> ""I don't know. It's just a statue to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Leon Malenyev: ""To me, all of this has meaning. It is always useful to k..."*)

### Węzeł `[147]`
Mówca: **Leon Malenyev**
> ""It is interesting that he removed the images of the last kings but not the older figures. Was he fond of the aristocracy, or the man?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: ""I have no idea. You have to ask the man himself.""*)
  - -> `[158]` (*Player: ""I believe he was fond of both. He cared a lot about our ..."*)
  - -> `[159]` (*Player: ""I know he despised the kingdom. But I think he still nee..."*)

### Węzeł `[148]`
Mówca: **Leon Malenyev**
> ""To me, all of this has meaning. It is always useful to know why certain historical images are displayed while others kept hidden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Leon Malenyev: ""You are not a man of history, then?""*)

### Węzeł `[149]`
Mówca: **Leon Malenyev**
> ""You are not a man of history, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[154]` (*Player: ""To be honest, not really.""*)
  - -> `[155]` (*Player: ""The future interests me more than the past.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""As a matter of fact, I am. My field was history before I entered politics.""]** — Mówca: **Player**
> ""As a matter of fact, I am. My field was history before I entered politics.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Kontekst wejściowy (poprzednik):** `[149]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Leon Malenyev: ""How come you are uninterested in your own past, then? I'..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""As a matter of fact, I am. My field was history before I..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: ""As a matter of fact, I am quite interested in history. M..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""To be honest, not really.""]** — Mówca: **Player**
> ""To be honest, not really.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Leon Malenyev: ""You cannot see what the future holds for you if you're n..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""The future interests me more than the past.""]** — Mówca: **Player**
> ""The future interests me more than the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Leon Malenyev: ""You cannot see what the future holds for you if you're n..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA: ""As a matter of fact, I am quite interested in history. Maybe just not the statues.""]** — Mówca: **Player**
> ""As a matter of fact, I am quite interested in history. Maybe just not the statues.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[149]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Leon Malenyev: ""How come you are uninterested in your own past, then? I'..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I have no idea. You have to ask the man himself.""]** — Mówca: **Player**
> ""I have no idea. You have to ask the man himself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Leon Malenyev: ""Well, I think he couldn't erase history just like that. ..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""I believe he was fond of both. He cared a lot about our national values.""]** — Mówca: **Player**
> ""I believe he was fond of both. He cared a lot about our national values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Leon Malenyev: ""Well, I think he couldn't erase history just like that. ..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""I know he despised the kingdom. But I think he still needed a glorious past to make people proud. That's where Renan came in.""]** — Mówca: **Player**
> ""I know he despised the kingdom. But I think he still needed a glorious past to make people proud. That's where Renan came in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Leon Malenyev: ""That's what I suspected. If it was not going to be the k..."*)

### Węzeł `[160]`
Mówca: **Leon Malenyev**
> ""How come you are uninterested in your own past, then? I'm not the one who put these statues here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "At that moment, we came to the end of the corridor and en..."*)

### Węzeł `[161]`
Mówca: **Leon Malenyev**
> ""You cannot see what the future holds for you if you're not literate in history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Leon Malenyev: ""It is important to learn from the past. Or else we'll ke..."*)

### Węzeł `[162]`
Mówca: **Leon Malenyev**
> ""It is important to learn from the past. Or else we'll keep on making the same mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "At that moment, we came to the end of the corridor and en..."*)

### Węzeł `[163]`
Mówca: **Leon Malenyev**
> ""That's what I suspected. If it was not going to be the kingdom he despised so much, it made sense to look further back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Leon Malenyev: ""He just left in the parts he liked. Isn't it fascinating..."*)

### Węzeł `[164]`
Mówca: **Leon Malenyev**
> ""Well, I think he couldn't erase history just like that. He still needed a past that made him and his people proud. If it was not going to be the kingdom he despised so much, it made sense to look further back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Leon Malenyev: ""He just left in the parts he liked. Isn't it fascinating..."*)

### Węzeł `[165]`
Mówca: **Leon Malenyev**
> ""In the end, I'm just an old man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Leon Malenyev: ""I've seen many presidents and world leaders change durin..."*)

### Węzeł `[166]`
Mówca: **Leon Malenyev**
> ""He just left in the parts he liked. Isn't it fascinating how a single person can alter history just like that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "At that moment, we came to the end of the corridor and en..."*)

### Węzeł `[167]`
Mówca: **Leon Malenyev**
> ""It is perhaps even more divided than ever. There are still wars in every corner of the world. There is still poverty, violence and slavery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Leon Malenyev: ""Don't you think we need to step up as leaders of this wo..."*)

### Węzeł `[168]`
Mówca: **Leon Malenyev**
> ""Don't you think we need to step up as leaders of this world to try to put an end to this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""I completely agree. We need proper international coopera..."*)
  - -> `[170]` (*Player: ""I do. That's why I'm meeting with you. To change somethi..."*)
  - -> `[171]` (*Player: ""I think United Contana isn't entirely innocent in these ..."*)
  - -> `[172]` (*Player: ""We can only do so much.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""I completely agree. We need proper international cooperation to tackle these problems.""]** — Mówca: **Player**
> ""I completely agree. We need proper international cooperation to tackle these problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Leon Malenyev: ""Precisely.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""I do. That's why I'm meeting with you. To change something.""]** — Mówca: **Player**
> ""I do. That's why I'm meeting with you. To change something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Leon Malenyev: ""Good.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I think United Contana isn't entirely innocent in these conflicts.""]** — Mówca: **Player**
> ""I think United Contana isn't entirely innocent in these conflicts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Leon Malenyev: ""I never claimed we were innocent.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""We can only do so much.""]** — Mówca: **Player**
> ""We can only do so much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Leon Malenyev: ""Perhaps we cannot ever create our utopias. But that does..."*)

### Węzeł `[173]`
Mówca: **Leon Malenyev**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[174]`
Mówca: **Leon Malenyev**
> ""I never claimed we were innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Leon Malenyev: ""I don't play games like the Arcasians. I can tell it as ..."*)

### Węzeł `[175]`
Mówca: **Leon Malenyev**
> ""I don't play games like the Arcasians. I can tell it as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Leon Malenyev: ""Yes. We were involved with a lot of conflicts that turne..."*)

### Węzeł `[176]`
Mówca: **Leon Malenyev**
> ""Perhaps we cannot ever create our utopias. But that doesn't mean we shouldn't try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[177]`
Mówca: **Leon Malenyev**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[178]`
Mówca: **Leon Malenyev**
> ""And that's where the CSP comes in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Leon Malenyev: ""But before we talk about that...""*)

### Węzeł `[179]`
Mówca: **Leon Malenyev**
> ""Yes. We were involved with a lot of conflicts that turned bloody. Was there any other way? I don't know. Probably not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Leon Malenyev: ""I still remember how Contana was a massive war zone. Whe..."*)

### Węzeł `[180]`
Mówca: **Leon Malenyev**
> ""Today, the whole continent is at peace, Mr. Rayne. And now the rest of the world is furious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""In the end, you formed the largest country in the world.""*)
  - -> `[181]` (*Player: ""Those days must have been devastating.""*)
  - -> `[186]` (*Player: ""There are many countries who look up to United Contana. ..."*)
  - -> `[187]` (*Player: ""They are afraid of your power. Contana was never united ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Those days must have been devastating.""]** — Mówca: **Player**
> ""Those days must have been devastating.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Leon Malenyev: ""They were. But the revolution lives on in Contana now. I..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""In the end, you formed the largest country in the world.""]** — Mówca: **Player**
> ""In the end, you formed the largest country in the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Leon Malenyev: ""We have. And now our responsibility is great. We cannot ..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Leon Malenyev: ""Chancellor Hegel told me a lot about you.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "After preparing his pipe, he lit it with a match. His eye..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""There are many countries who look up to United Contana. You are not alone.""]** — Mówca: **Player**
> ""There are many countries who look up to United Contana. You are not alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Leon Malenyev: ""That's exactly what our enemies are furious about.""*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""They are afraid of your power. Contana was never united before.""]** — Mówca: **Player**
> ""They are afraid of your power. Contana was never united before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Leon Malenyev: ""They are afraid of the power of the people, Mr. Rayne. T..."*)

### Węzeł `[188]`
Mówca: **Leon Malenyev**
> ""They are afraid of the power of the people, Mr. Rayne. They are afraid that the oppressed will one day unite. That was the power of our revolution in Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[189]`
Mówca: **Leon Malenyev**
> ""That's exactly what our enemies are furious about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[190]`
Mówca: **Leon Malenyev**
> ""They were. But the revolution lives on in Contana now. It's time we help others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[191]`
Mówca: **Leon Malenyev**
> ""We have. And now our responsibility is great. We cannot sit back and let Arcasian imperialism enslave the third world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Leon Malenyev: ""And that's where the CSP comes in.""*)

### Węzeł `[192]`
Mówca: **Leon Malenyev**
> ""I still remember how Contana was a massive war zone. When all the warring states were supplied weapons by the west. Kings and dictators killed each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Leon Malenyev: ""Today, the whole continent is at peace, Mr. Rayne. And n..."*)

### Węzeł `[193]`
Mówca: **Leon Malenyev**
> ""Oh, yes. Renan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Leon Malenyev: ""I thought when Tarquin Soll came to power, he worked tow..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "He took another sip from his glass and stretched his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Leon Malenyev: ""Could you help me?""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Leon Malenyev: ""Are you even aware what goes on there?""*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Leon Malenyev: ""Are you even aware what goes on there?""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[201]`
Mówca: **Leon Malenyev**
> ""But before we talk about that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "He took another sip from his glass and stretched his hand..."*)

### Węzeł `[202]`
Mówca: **Leon Malenyev**
> ""Could you help me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "I grabbed his arm and helped him stand up."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "I grabbed his arm and helped him stand up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Leon Malenyev: ""Can we talk somewhere a little less damp? I need some fr..."*)

### Węzeł `[204]`
Mówca: **Leon Malenyev**
> ""Can we talk somewhere a little less damp? I need some fresh air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""Of course. Please follow me, Chairman Malenyev.""*)
  - -> `[207]` (*Player: ""Would you want to have a rest, Chairman Malenyev? We can..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "He was wearing his usual "political uniform," grayish-green trousers and a simple tunic with a soft turn-down collar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_ExtravagantWelcome == true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Of course. Please follow me, Chairman Malenyev.""]** — Mówca: **Player**
> ""Of course. Please follow me, Chairman Malenyev.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "I led him up a set of back stairs to another unoccupied o..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Would you want to have a rest, Chairman Malenyev? We can talk later if you're not feeling well.""]** — Mówca: **Player**
> ""Would you want to have a rest, Chairman Malenyev? We can talk later if you're not feeling well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Leon Malenyev: ""Oh, no, I'm fine. I didn't come here to sleep. I just ne..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "I led him up a set of back stairs to another unoccupied office with a balcony overlooking the Hill of Pride. We took our seats around a table. It was rather chilly outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Reaching into his distinctive jacket, he pulled out a pip..."*)

### Węzeł `[209]`
Mówca: **Leon Malenyev**
> ""Oh, no, I'm fine. I didn't come here to sleep. I just need some fresh air, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "I led him up a set of back stairs to another unoccupied o..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Reaching into his distinctive jacket, he pulled out a pipe and placed some tobacco leaves inside. The smell of the leaves was overpowering, even outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)

### Węzeł `[211]`
Mówca: **Leon Malenyev**
> ""Chancellor Hegel told me a lot about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "After preparing his pipe, he lit it with a match. His eye..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "After preparing his pipe, he lit it with a match. His eyes drifted away from me while the wind blew his hair and smoke to the side. He stared at the horizon to the north."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Leon Malenyev: ""Beyond these plains lies the great Markian Sea. And in t..."*)

### Węzeł `[213]`
Mówca: **Leon Malenyev**
> ""Beyond these plains lies the great Markian Sea. And in the middle of it, a small island. Small but very important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[214]`
Mówca: **Leon Malenyev**
> ""Are you even aware what goes on there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Leon Malenyev: ""You are supporting the foreign Agnolian regime, which is..."*)

### Węzeł `[215]`
Mówca: **Leon Malenyev**
> ""Are you even aware what goes on there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Leon Malenyev: ""Your Agnolian allies installed an anti-Valgish regime in..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Leon Malenyev: ""Valgsland needs all the support we can give to bring bac..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Leon Malenyev: ""Are you aware what goes on there?""*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_HeljilandRecognised == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Leon Malenyev: ""I am glad that you gave your support to Chancellor Hegel.""*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[222]`
Mówca: **Leon Malenyev**
> ""You are supporting the foreign Agnolian regime, which is trying to destroy the local culture. The Heljilandian Valgs are being oppressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Leon Malenyev: ""All of this is happening because Valgsland joined the CSP.""*)

### Węzeł `[223]`
Mówca: **Leon Malenyev**
> ""All of this is happening because Valgsland joined the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Leon Malenyev: ""Now the western powers are trying to get Agnolia to thei..."*)

### Węzeł `[224]`
Mówca: **Leon Malenyev**
> ""Your Agnolian allies installed an anti-Valgish regime in the island, which is trying its best to remove the identity of the locals. The Heljilandian Valgs are being oppressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Leon Malenyev: ""All of this is happening because Valgsland joined the CSP.""*)

### Węzeł `[225]`
Mówca: **Leon Malenyev**
> ""I am glad that you gave your support to Chancellor Hegel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Leon Malenyev: ""It is unacceptable to see the Valgish locals of the isla..."*)

### Węzeł `[226]`
Mówca: **Leon Malenyev**
> ""It is unacceptable to see the Valgish locals of the island being destroyed by the anti-Valgish regime in Heljiland. The oppression has become more brutal than ever before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Leon Malenyev: ""All of this is happening because Valgsland joined the CSP.""*)

### Węzeł `[227]`
Mówca: **Leon Malenyev**
> ""Valgsland needs all the support we can give to bring back peace to the island. We can't let our allies stand alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Leon Malenyev: ""It is unacceptable to see the Valgish locals of the isla..."*)

### Węzeł `[228]`
Mówca: **Leon Malenyev**
> ""Are you aware what goes on there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Leon Malenyev: ""It is unacceptable to see the Valgish locals of the isla..."*)

### Węzeł `[229]`
Mówca: **Leon Malenyev**
> ""Now the western powers are trying to get Agnolia to their side. They are *selling* them financial aid, weapons and intelligence, in return for pushing their political agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Leon Malenyev: ""All of this *firepower* is now being directed at the loc..."*)

### Węzeł `[230]`
Mówca: **Leon Malenyev**
> ""All of this *firepower* is now being directed at the locals in Heljiland. They want to finally eliminate the Valgish culture in the island, and set up a military base close to Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Leon Malenyev: ""We cannot allow that to happen, can we?""*)

### Węzeł `[231]`
Mówca: **Leon Malenyev**
> ""We cannot allow that to happen, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[246]` (*Player: ""You are right, Chairman Malenyev. We can't.""*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""Heljiland is an Agnolian island, Chairman Malenyev. We c..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Heljiland is an Agnolian island, Chairman Malenyev. We cannot interfere.""]** — Mówca: **Player**
> ""Heljiland is an Agnolian island, Chairman Malenyev. We cannot interfere.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Leon Malenyev: ""Interfere? Do you think the Agnolian government is innoc..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: ""Agnolia is our ally, Chairman Malenyev.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: ""Agnolia is definitely becoming a threat.""*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Agnolia is our ally, Chairman Malenyev.""]** — Mówca: **Player**
> ""Agnolia is our ally, Chairman Malenyev.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Leon Malenyev: ""So you support what their government is trying to do?""*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""I don't want to interfere with the matters between Valgsland and Agnolia.""]** — Mówca: **Player**
> ""I don't want to interfere with the matters between Valgsland and Agnolia.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false` AND `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Leon Malenyev: ""Unfortunately the time to take a side has come, Mr. Rayn..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_HeljilandRecognised == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""I believe Valgsland has the right to interfere. It's the..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: ""I don't want to interfere with the matters between Valgs..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""I believe Valgsland has the right to interfere. It's their people who are being massacred.""]** — Mówca: **Player**
> ""I believe Valgsland has the right to interfere. It's their people who are being massacred.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true` AND `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Leon Malenyev: ""That's right. But for me, this isn't a nationalistic pro..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Agnolia is definitely becoming a threat.""]** — Mówca: **Player**
> ""Agnolia is definitely becoming a threat.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Leon Malenyev: ""They are. Because Arcasia is funding them.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""You are right, Chairman Malenyev. We can't.""]** — Mówca: **Player**
> ""You are right, Chairman Malenyev. We can't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Leon Malenyev: ""Exactly. We cannot.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Yes. I am behind Valgsland in this conflict.""]** — Mówca: **Player**
> ""Yes. I am behind Valgsland in this conflict.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[231]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Leon Malenyev: ""That's good to hear.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player: ""Yes. I am behind Valgsland in this conflict.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
Mówca: **Leon Malenyev**
> ""Interfere? Do you think the Agnolian government is innocent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Leon Malenyev: ""What do you think they'll do next, if we let them get aw..."*)

### Węzeł `[252]`
Mówca: **Leon Malenyev**
> ""Unfortunately the time to take a side has come, Mr. Rayne. You could have been right if it was just a problem between two countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Leon Malenyev: ""But it isn't. Not now that Arcasia has gotten involved.""*)

### Węzeł `[253]`
Mówca: **Leon Malenyev**
> ""That's right. But for me, this isn't a nationalistic problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Leon Malenyev: ""Whether they are Valgs, Agnolians or Contanans who are b..."*)

### Węzeł `[254]`
Mówca: **Leon Malenyev**
> ""Whether they are Valgs, Agnolians or Contanans who are being killed, it doesn't matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Leon Malenyev: ""In the end, people are dying. And for no reason other th..."*)

### Węzeł `[255]`
Mówca: **Leon Malenyev**
> ""So you support what their government is trying to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Leon Malenyev: ""What do you think they'll do next, if we let them get aw..."*)

### Węzeł `[256]`
Mówca: **Leon Malenyev**
> ""They are. Because Arcasia is funding them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Leon Malenyev: ""If we let them get away with what they're doing in Helji..."*)

### Węzeł `[257]`
Mówca: **Leon Malenyev**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Leon Malenyev: ""If we let them get away with what they're doing in Helji..."*)

### Węzeł `[258]`
Mówca: **Leon Malenyev**
> ""Exactly. We cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Leon Malenyev: ""If we let them get away with what they're doing in Helji..."*)

### Węzeł `[259]`
Mówca: **Leon Malenyev**
> ""But it isn't. Not now that Arcasia has gotten involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Leon Malenyev: ""Whether they are Valgs, Agnolians or Contanans who are b..."*)

### Węzeł `[260]`
Mówca: **Leon Malenyev**
> ""What do you think they'll do next, if we let them get away with Heljiland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Leon Malenyev: ""Everything has become a race for total influence in Merk..."*)

### Węzeł `[261]`
Mówca: **Leon Malenyev**
> ""If we let them get away with what they're doing in Heljiland, they'll do a lot more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Leon Malenyev: ""Whether they are Valgs, Agnolians or Contanans who are b..."*)

### Węzeł `[262]`
Mówca: **Leon Malenyev**
> ""In the end, people are dying. And for no reason other than the political aims of their governments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Leon Malenyev: ""Everything has become a race for total influence in Merk..."*)

### Węzeł `[263]`
Mówca: **Leon Malenyev**
> ""Everything has become a race for total influence in Merkopa. This is just a part of Arcasia's grand plan. They want the CSP removed from the region. Agnolia is their puppet in this cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "He took a long puff on his pipe."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "He took a long puff on his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Leon Malenyev: ""United Contana will never allow Arcasia to install weapo..."*)

### Węzeł `[265]`
Mówca: **Leon Malenyev**
> ""United Contana will never allow Arcasia to install weapons so close to Valgsland. Nor let them harass CSP ships. They can't be given control of the Markian Sea. Heljiland cannot fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player: ""You are right, Chairman Malenyev. We can't let the weste..."*)
  - -> `[267]` (*Player: ""I thought this was about people being killed.""*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)
  - -> `[274]` (*Player: ""So you think Arcasia's behind this?""*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""I'm sure we can find a diplomatic solution with Agnolia.""]** — Mówca: **Player**
> ""I'm sure we can find a diplomatic solution with Agnolia.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Kontekst wejściowy (poprzednik):** `[265]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Leon Malenyev: ""I'm afraid we're past that stage by now.""*)

### Węzeł `[267]`
**[WYBÓR GRACZA: ""I thought this was about people being killed.""]** — Mówca: **Player**
> ""I thought this was about people being killed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Leon Malenyev: ""It is.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Leon Malenyev: ""Your military alliance with Lespia must be cancelled imm..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_H..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: ""I'm sure we can find a diplomatic solution with Agnolia.""*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WYBÓR GRACZA: ""So you think Arcasia's behind this?""]** — Mówca: **Player**
> ""So you think Arcasia's behind this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Leon Malenyev: ""It's not a thought, Mr. Rayne. I *know*.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""You are right, Chairman Malenyev. We can't let the western powers take control.""]** — Mówca: **Player**
> ""You are right, Chairman Malenyev. We can't let the western powers take control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_H..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Leon Malenyev: ""So, you are ready to tear down the agreement...""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Leon Malenyev: ""Exactly.""*)

### Węzeł `[279]`
Mówca: **Leon Malenyev**
> ""So, you are ready to tear down the agreement...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Leon Malenyev: ""...And break your alliance with Agnolia?""*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Leon Malenyev: ""...And take away your support from Heljiland?""*)

### Węzeł `[283]`
Mówca: **Leon Malenyev**
> ""...And break your alliance with Agnolia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: ""Yes, I am. For the good of the region.""*)
  - -> `[294]` (*Player: ""Only if Sordland enters the CSP.""*)
  - -> `[295]` (*Player: ""No. That's something I cannot do.""*)

### Węzeł `[284]`
Mówca: **Leon Malenyev**
> ""...And take away your support from Heljiland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: ""Yes, I am. For the good of the region.""*)
  - -> `[294]` (*Player: ""Only if Sordland enters the CSP.""*)
  - -> `[295]` (*Player: ""No. That's something I cannot do.""*)

### Węzeł `[285]`
Mówca: **Leon Malenyev**
> ""It's not a thought, Mr. Rayne. I *know*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Leon Malenyev: ""We have agents everywhere.""*)

### Węzeł `[286]`
Mówca: **Leon Malenyev**
> ""We have agents everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[287]`
Mówca: **Leon Malenyev**
> ""I'm afraid we're past that stage by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[288]`
Mówca: **Leon Malenyev**
> ""It is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Leon Malenyev: ""It's about a group of people being destroyed to further ..."*)

### Węzeł `[289]`
Mówca: **Leon Malenyev**
> ""It's about a group of people being destroyed to further the aims of the Agnolian government...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Leon Malenyev: ""...which is working towards isolating our allies, as wel..."*)

### Węzeł `[290]`
Mówca: **Leon Malenyev**
> ""...which is working towards isolating our allies, as well as expanding the influence of Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[291]`
Mówca: **Narrator**
> "He took a another puff and started coughing heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "One of his bodyguards, dressed in full military uniform, ..."*)

### Węzeł `[292]`
Mówca: **Leon Malenyev**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[293]`
**[WYBÓR GRACZA: ""Yes, I am. For the good of the region.""]** — Mówca: **Player**
> ""Yes, I am. For the good of the region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Leon Malenyev), `[284]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "He smiled."*)

### Węzeł `[294]`
**[WYBÓR GRACZA: ""Only if Sordland enters the CSP.""]** — Mówca: **Player**
> ""Only if Sordland enters the CSP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Leon Malenyev), `[284]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "He smiled."*)

### Węzeł `[295]`
**[WYBÓR GRACZA: ""No. That's something I cannot do.""]** — Mówca: **Player**
> ""No. That's something I cannot do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Leon Malenyev), `[284]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Leon Malenyev: ""Don't rush your decision.""*)

### Węzeł `[296]`
Mówca: **Leon Malenyev**
> ""Very direct. I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Leon Malenyev: ""Very direct. I like it.""*)

### Węzeł `[298]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[299]`
Mówca: **Leon Malenyev**
> ""Don't rush your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "He took a another puff and started coughing heavily."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "One of his bodyguards, dressed in full military uniform, rushed towards us with a bottle of water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Leon Malenyev: ""Thank you, Michail. But I'm fine.""*)

### Węzeł `[301]`
Mówca: **Leon Malenyev**
> ""Thank you, Michail. But I'm fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "The guard bowed in respect as Malenyev drank from the bot..."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "The guard bowed in respect as Malenyev drank from the bottle. He left the balcony with quick steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Leon Malenyev: ""So... Where were we?""*)

### Węzeł `[303]`
Mówca: **Leon Malenyev**
> ""So... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Leon Malenyev: ""Ah, yes. Sordland's future in the CSP.""*)

### Węzeł `[304]`
Mówca: **Leon Malenyev**
> ""Ah, yes. Sordland's future in the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "He cleaned the burnt tobacco residue from his pipe and re..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "He cleaned the burnt tobacco residue from his pipe and refilled it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Leon Malenyev: ""You know we formed the CSP only in reaction to ATO. Thei..."*)

### Węzeł `[306]`
Mówca: **Leon Malenyev**
> ""You know we formed the CSP only in reaction to ATO. Their aim in the beginning was to stop us from uniting the entire continent under socialism. They failed. And now they're more scared than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Leon Malenyev: ""That's why they're growing more and more aggressive.""*)

### Węzeł `[307]`
Mówca: **Leon Malenyev**
> ""Today, you need the CSP in order to survive against the economic power of the west. United Contana is willing to give everything it has to help others in their fight against western dominance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: ""That's why I have you here, Chairman Malenyev.""*)
  - -> `[310]` (*Player: ""I'm not sure if we *need* it, but I definitely want to c..."*)
  - -> `[309]` (*Player: ""ATO says the same about the CSP.""*)

### Węzeł `[308]`
Mówca: **Leon Malenyev**
> ""That's why they're growing more and more aggressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Leon Malenyev: ""Today, you need the CSP in order to survive against the ..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""ATO says the same about the CSP.""]** — Mówca: **Player**
> ""ATO says the same about the CSP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Leon Malenyev: ""Okay, Mr. Rayne.""*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""I'm not sure if we *need* it, but I definitely want to cooperate.""]** — Mówca: **Player**
> ""I'm not sure if we *need* it, but I definitely want to cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Leon Malenyev: ""Don't get me wrong. Sordland is a powerful country.""*)

### Węzeł `[311]`
**[WYBÓR GRACZA: ""That's why I have you here, Chairman Malenyev.""]** — Mówca: **Player**
> ""That's why I have you here, Chairman Malenyev.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "He lit his pipe and took a puff. The wind pushed all of t..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "He lit his pipe and took a puff. The wind pushed all of the smoke in my face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Leon Malenyev: ""Without us, Arcasia would dominate the world. The Arcasi..."*)

### Węzeł `[313]`
Mówca: **Leon Malenyev**
> ""Don't get me wrong. Sordland is a powerful country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Leon Malenyev: ""But the world has changed. You cannot stand alone.""*)

### Węzeł `[314]`
Mówca: **Leon Malenyev**
> ""But the world has changed. You cannot stand alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "He lit his pipe and took a puff. The wind pushed all of t..."*)

### Węzeł `[315]`
Mówca: **Leon Malenyev**
> ""Okay, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Leon Malenyev: ""Why don't you talk to President Walker then?""*)

### Węzeł `[316]`
Mówca: **Leon Malenyev**
> ""Why don't you talk to President Walker then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Leon Malenyev: ""ATO helps less fortunate nations with its so-called Walk..."*)

### Węzeł `[317]`
Mówca: **Leon Malenyev**
> ""ATO helps less fortunate nations with its so-called Walker Plan, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Leon Malenyev: ""Did they not include you in it? Or did you see through t..."*)

### Węzeł `[318]`
Mówca: **Leon Malenyev**
> ""Did they not include you in it? Or did you see through their plans? That they only work for the interests of Arcasian capitalism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "He lit his pipe and took a puff. The wind pushed all of t..."*)

### Węzeł `[319]`
Mówca: **Leon Malenyev**
> ""Without us, Arcasia would dominate the world. The Arcasian Lira is already crippling other economies while they reap the benefits. Yet they claim they're the bringers of freedom. Absurd.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Leon Malenyev: ""Our pact aims to develop the parts of the world that hav..."*)

### Węzeł `[320]`
Mówca: **Leon Malenyev**
> ""Our pact aims to develop the parts of the world that have been left out. Bring people together and make a stand. Show the world the power of the people when they unite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Leon Malenyev: ""...So, hereby, I extend an invitation to Sordland. I wan..."*)

### Węzeł `[321]`
Mówca: **Leon Malenyev**
> ""...So, hereby, I extend an invitation to Sordland. I want you to see you stand with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "CSPHub"*)

### Węzeł `[322]`
**[WYBÓR GRACZA: ""What does the CSP offer for Sordland?""]** — Mówca: **Player**
> ""What does the CSP offer for Sordland?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[321]` (Leon Malenyev), `[352]` (Leon Malenyev), `[350]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Leon Malenyev: ""Security. First and foremost, CSP is a defense pact. You..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA: ""What do you expect in return?""]** — Mówca: **Player**
> ""What do you expect in return?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[321]` (Leon Malenyev), `[352]` (Leon Malenyev), `[350]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Leon Malenyev: ""You must accept our doctrines and work towards the goals..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Will you stand with us against the threat of Rumburg?""]** — Mówca: **Player**
> ""Will you stand with us against the threat of Rumburg?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[321]` (Leon Malenyev), `[352]` (Leon Malenyev), `[350]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Leon Malenyev: ""Of course. Rumburg is a threat to Merkopa. Surely they a..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA: ""Unfortunately, I have to decline.""]** — Mówca: **Player**
> ""Unfortunately, I have to decline.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[321]` (Leon Malenyev), `[352]` (Leon Malenyev), `[350]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "He narrowed his eyes and stared at me as he exhaled smoke..."*)

### Węzeł `[326]`
Mówca: **Leon Malenyev**
> ""Security. First and foremost, CSP is a defense pact. You will have the backing of the entire military power of our members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Leon Malenyev: ""United Contana and all other members are obliged to defe..."*)

### Węzeł `[327]`
Mówca: **Leon Malenyev**
> ""United Contana and all other members are obliged to defend each other in times of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Leon Malenyev: ""We also supply each nation with our military technology ..."*)

### Węzeł `[328]`
Mówca: **Leon Malenyev**
> ""We also supply each nation with our military technology and assets. As well as financial aid when it's needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Leon Malenyev: ""All members supply each other with their resources and g..."*)

### Węzeł `[329]`
Mówca: **Leon Malenyev**
> ""All members supply each other with their resources and goods, not for their own profit, but for the profit of the pact. Our combined production output will benefit both Sordland and the CSP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Leon Malenyev: ""Not to mention visa-free access to every country within ..."*)

### Węzeł `[330]`
Mówca: **Leon Malenyev**
> ""I will also offer you a small financial contribution to help you kickstart your economy. If you sign the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Leon Malenyev: ""Chancellor Hegel told me that I could trust you with the..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Leon Malenyev: ""I will also offer you a small financial contribution to ..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA = true"*)

### Węzeł `[334]`
Mówca: **Leon Malenyev**
> ""Not to mention visa-free access to every country within the CSP as well as other mutual assistance deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "He took another puff from his pipe."*)

### Węzeł `[335]`
Mówca: **Leon Malenyev**
> ""You must accept our doctrines and work towards the goals of the pact. To further our power against the ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Leon Malenyev: ""You will not import any technology from Arcasia, nor exp..."*)

### Węzeł `[336]`
Mówca: **Leon Malenyev**
> ""You will not import any technology from Arcasia, nor export natural resources to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[337]`
Mówca: **Leon Malenyev**
> ""Your military alliance with Lespia must be cancelled immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Leon Malenyev: ""You must also cancel your alliance with Agnolia.""*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Leon Malenyev: ""You must also cancel your recognition of Heljiland as Ag..."*)

### Węzeł `[341]`
Mówca: **Leon Malenyev**
> ""You must also cancel your alliance with Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_Hel..."*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_H..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true || BaseGame.Agnolia_HeljilandRecognised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Leon Malenyev: ""And finally, we want you to allow us to build a missile ..."*)

### Węzeł `[345]`
Mówca: **Leon Malenyev**
> ""You must also cancel your recognition of Heljiland as Agnolian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Leon Malenyev: ""And finally, we want you to allow us to build a missile ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true )"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Leon Malenyev: ""And stop your recognition of Heljiland as Agnolian terri..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Leon Malenyev: ""And finally, we want you to allow us to build a missile ..."*)

### Węzeł `[349]`
Mówca: **Leon Malenyev**
> ""And stop your recognition of Heljiland as Agnolian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Leon Malenyev: ""And finally, we want you to allow us to build a missile ..."*)

### Węzeł `[350]`
Mówca: **Leon Malenyev**
> ""And finally, we want you to allow us to build a missile defense system in Duru island. Which will protect both Sordland and the CSP from the threat of ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB = true"*)

### Węzeł `[351]`
Mówca: **Narrator**
> "He took another puff from his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)

### Węzeł `[352]`
Mówca: **Leon Malenyev**
> ""Chancellor Hegel told me that I could trust you with the money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA = true"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Leon Malenyev: ""But my agents told me that you might be the one who want..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Leon Malenyev: ""I promise you. Their queen will no longer meddle in Sord..."*)

### Węzeł `[356]`
Mówca: **Leon Malenyev**
> ""Of course. Rumburg is a threat to Merkopa. Surely they are being pushed by the western powers to create instability in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Leon Malenyev: ""Being a CSP member, nobody will dare attack you. And if ..."*)

### Węzeł `[357]`
Mówca: **Leon Malenyev**
> ""Being a CSP member, nobody will dare attack you. And if any conflict occurs nonetheless, you will have the entire CSP's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[358]`
Mówca: **Leon Malenyev**
> ""But my agents told me that you might be the one who wants to start a war. Not Rumburg. Is there any truth to that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Player: ""I didn't want a war, but Rumburg pushed us to the edge.""*)
  - -> `[380]` (*Player: ""Yes. We will bring the war to them, before they are full..."*)
  - -> `[382]` (*Player: ""You have agents in Sordland?""*)

### Węzeł `[359]`
Mówca: **Leon Malenyev**
> ""I promise you. Their queen will no longer meddle in Sordland nor Eastern Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC = true"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "Jump to: [CSPHub]"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "Jump to: [CSPHub]"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "Jump to: [CSPHub]"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: ""What does the CSP offer for Sordland?""*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: ""What do you expect in return?""*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC == true"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC == true)"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: ""Will you stand with us against the threat of Rumburg?""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true && BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true &&..."*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true ..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true && BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true  and  Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true && BaseGame.Lespia_Alli..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true && BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true  and  Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[375]`
**[WYBÓR GRACZA: ""It's a deal, Chairman Malenyev. [Join CSP]""]** — Mówca: **Player**
> ""It's a deal, Chairman Malenyev.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Narrator: "He smiled."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `CSPHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC == true"*)
  - -> `[325]` (*Player: ""Unfortunately, I have to decline.""*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA == true &&..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [CSPHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "CSPHub"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [CSPHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "CSPHub"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [CSPHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "CSPHub"*)

### Węzeł `[380]`
**[WYBÓR GRACZA: ""Yes. We will bring the war to them, before they are fully prepared.""]** — Mówca: **Player**
> ""Yes. We will bring the war to them, before they are fully prepared.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Leon Malenyev: ""I am not entirely sure about your decision, Mr. Rayne.""*)

### Węzeł `[381]`
**[WYBÓR GRACZA: ""I didn't want a war, but Rumburg pushed us to the edge.""]** — Mówca: **Player**
> ""I didn't want a war, but Rumburg pushed us to the edge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Leon Malenyev: ""I am not entirely sure about your decision, Mr. Rayne.""*)

### Węzeł `[382]`
**[WYBÓR GRACZA: ""You have agents in Sordland?""]** — Mówca: **Player**
> ""You have agents in Sordland?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "He laughed."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Leon Malenyev: ""We are talking about war, not agents. I have to first te..."*)

### Węzeł `[384]`
Mówca: **Leon Malenyev**
> ""I am not entirely sure about your decision, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Leon Malenyev: ""Of course, we will support you in case of a war, but all..."*)

### Węzeł `[385]`
Mówca: **Leon Malenyev**
> ""Of course, we will support you in case of a war, but all the CSP members must be included in the planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Leon Malenyev: ""I'm concerned that a conflict with Rumburg, especially w..."*)

### Węzeł `[386]`
Mówca: **Leon Malenyev**
> ""I'm concerned that a conflict with Rumburg, especially with our backing, may lead the entire world into a hot war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Leon Malenyev: ""Nobody wants to see that.""*)

### Węzeł `[387]`
Mówca: **Leon Malenyev**
> ""Nobody wants to see that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player: ""Are you saying we shouldn't attack them?""*)
  - -> `[390]` (*Player: ""Since when are you a pacifist, Chairman Malenyev?""*)
  - -> `[391]` (*Player: ""What are you suggesting?""*)

### Węzeł `[388]`
Mówca: **Leon Malenyev**
> ""We are talking about war, not agents. I have to first tell you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Leon Malenyev: ""I am not entirely sure about your decision, Mr. Rayne.""*)

### Węzeł `[389]`
**[WYBÓR GRACZA: ""Are you saying we shouldn't attack them?""]** — Mówca: **Player**
> ""Are you saying we shouldn't attack them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Leon Malenyev: ""I'm not trying to tell you what to do, Mr. Rayne. I am j..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA: ""Since when are you a pacifist, Chairman Malenyev?""]** — Mówca: **Player**
> ""Since when are you a pacifist, Chairman Malenyev?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Leon Malenyev: ""I'm not trying to tell you what to do, Mr. Rayne. I am j..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA: ""What are you suggesting?""]** — Mówca: **Player**
> ""What are you suggesting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Leon Malenyev: ""I'm not trying to tell you what to do, Mr. Rayne. I am j..."*)

### Węzeł `[392]`
Mówca: **Leon Malenyev**
> ""I'm not trying to tell you what to do, Mr. Rayne. I am just warning you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Leon Malenyev: ""But know that we will never allow Rumburg to destroy Eas..."*)

### Węzeł `[393]`
Mówca: **Leon Malenyev**
> ""But know that we will never allow Rumburg to destroy Eastern Merkopa. That is all I'm going to say for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedC = true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance = false; BaseGame.Lespia_Alliance_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lespia_Alliance"] = false;
Variable["BaseGame.Lespia_Alliance_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance = false; BaseGame.Agnolia_Alliance_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_Alliance"] = false;
Variable["BaseGame.Agnolia_Alliance_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "His handshake wasn't as strong as the name."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance = false; BaseGame.Lespia_Allianc..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance = false; BaseGame.Agnolia_Allia..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true )"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised = false; BaseGame.Tu..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised = false; BaseGame.Turn09_Agnolia_CancelledHeljilandRecognition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;
Variable["BaseGame.Turn09_Agnolia_CancelledHeljilandRecognition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Heljiland_Map_Layer = 1"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == true)"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 1"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP = true; BaseGame.Capitalist -= 3; Bas..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP = true; BaseGame.Capitalist -= 3; Bas..."*)

### Węzeł `[410]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[411]`
Mówca: **Leon Malenyev**
> ""It's good to see you stand with us, Comrade Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "We shook hands."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Leon Malenyev: ""It's good to see you stand with us, Comrade Rayne.""*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Leon Malenyev: ""It's good to see you stand with us, Mr. Rayne.""*)

### Węzeł `[415]`
Mówca: **Leon Malenyev**
> ""It's good to see you stand with us, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "We shook hands."*)

### Węzeł `[416]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Valgsland", "..."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "He narrowed his eyes and stared at me as he exhaled smoke right into my face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Leon Malenyev: ""Too bad, Mr. Rayne. I thought you knew what to expect wh..."*)

### Węzeł `[418]`
Mówca: **Leon Malenyev**
> ""Too bad, Mr. Rayne. I thought you knew what to expect when you accepted our offer to meet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Leon Malenyev: ""Looks like it was just a waste of time.""*)

### Węzeł `[419]`
Mówca: **Leon Malenyev**
> ""Looks like it was just a waste of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Narrator: "He smiled."*)

### Węzeł `[420]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Leon Malenyev: ""Nonetheless, I extend my good wishes to the Sordish peop..."*)

### Węzeł `[421]`
Mówca: **Leon Malenyev**
> ""Nonetheless, I extend my good wishes to the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Leon Malenyev: ""I wish that one day we could all set aside our differenc..."*)

### Węzeł `[422]`
Mówca: **Leon Malenyev**
> ""I wish that one day we could all set aside our differences, and all people of the world could come together. Maybe we are not ready for that today, but our revolution will keep expanding, and helping others who need it. Whether you stand with us or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "He slowly stood up from his seat, seemingly struggling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Leon Malenyev: ""Now, I'd like to have a rest, if you'll excuse me.""*)

### Węzeł `[424]`
Mówca: **Leon Malenyev**
> ""Now, I'd like to have a rest, if you'll excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Player: ""Of course, Chairman Malenyev. Please come this way.""*)
  - -> `[426]` (*Player: ""I wanted to make a deal today as well. But your terms we..."*)
  - -> `[427]` (*Player: ""We might not have come to an agreement about the CSP, bu..."*)

### Węzeł `[425]`
**[WYBÓR GRACZA: ""Of course, Chairman Malenyev. Please come this way.""]** — Mówca: **Player**
> ""Of course, Chairman Malenyev. Please come this way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Leon Malenyev: ""Please.""*)

### Węzeł `[426]`
**[WYBÓR GRACZA: ""I wanted to make a deal today as well. But your terms were not acceptable.""]** — Mówca: **Player**
> ""I wanted to make a deal today as well. But your terms were not acceptable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Leon Malenyev: ""It is fine, Mr. Rayne. You must have your own reasons fo..."*)

### Węzeł `[427]`
**[WYBÓR GRACZA: ""We might not have come to an agreement about the CSP, but I still want to have good relations with United Contana.""]** — Mówca: **Player**
> ""We might not have come to an agreement about the CSP, but I still want to have good relations with United Contana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Leon Malenyev: ""Let's talk about that later, Mr. Rayne. But thank you.""*)

### Węzeł `[428]`
Mówca: **Leon Malenyev**
> ""Let's talk about that later, Mr. Rayne. But thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "I led him back inside."*)

### Węzeł `[429]`
Mówca: **Leon Malenyev**
> ""It is fine, Mr. Rayne. You must have your own reasons for this decision. I cannot judge you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "I led him back inside."*)

### Węzeł `[430]`
Mówca: **Leon Malenyev**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "I led him back inside."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "I led him back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[432]`
Mówca: **Narrator**
> "He slowly stood up from his seat, seemingly struggling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Leon Malenyev: ""Now, I'd like to have a rest, if you'll excuse me.""*)

### Węzeł `[433]`
Mówca: **Leon Malenyev**
> ""Now, I'd like to have a rest, if you'll excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player: ""Of course, Chairman Malenyev. Please come this way.""*)
  - -> `[435]` (*Player: ""Thank you for the meeting. It was a pleasure.""*)

### Węzeł `[434]`
**[WYBÓR GRACZA: ""Of course, Chairman Malenyev. Please come this way.""]** — Mówca: **Player**
> ""Of course, Chairman Malenyev. Please come this way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Leon Malenyev: ""Please.""*)

### Węzeł `[435]`
**[WYBÓR GRACZA: ""Thank you for the meeting. It was a pleasure.""]** — Mówca: **Player**
> ""Thank you for the meeting. It was a pleasure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Leon Malenyev: ""The pleasure is mine.""*)

### Węzeł `[436]`
Mówca: **Leon Malenyev**
> ""The pleasure is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "I led him back inside."*)

### Węzeł `[437]`
Mówca: **Leon Malenyev**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "I led him back inside."*)

### Węzeł `[438]`
Mówca: **Narrator**
> "I led him back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP = true;
BaseGame.Capitalist -= 3;
BaseGame.Sollist -= 2;
BaseGame.Malenyevist += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Joined_CSP"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 5;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Joined_CSP = true"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_FPnT_SuperpowerVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_FPnT_SuperpowerVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[441]`
Mówca: **Narrator**
> "His handshake wasn't as strong as the name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Agnolia", "Ho..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised ..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = false;
BaseGame.Policy_Diplomacy_CSP = true;
BaseGame.Policy_Diplomacy_EmbargoingUnitedContana = false;

BaseGame.Policy_Diplomacy_Lespia_Alliance = false;
BaseGame.Policy_Diplomacy_TradeZone_Lespia = false;
BaseGame.Policy_Diplomacy_Agnolia_Alliance = false;
BaseGame.Policy_Diplomacy_Neutrality = false;

BaseGame.Policy_Diplomacy_TradeInitiative = true;
BaseGame.Policy_Military_CSP_Officers = true;
BaseGame.Policy_Military_JointMilitaryExercises = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = false;
Variable["BaseGame.Policy_Diplomacy_CSP"] = true;
Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] = false;
Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] = false;
Variable["BaseGame.Policy_Diplomacy_TradeZone_Lespia"] = false;
Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] = false;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;
Variable["BaseGame.Policy_Military_CSP_Officers"] = true;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Contana_Military_Support = t..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Contana_Military_Support = true;
BaseGame.Situation_Diplomacy_ArcasiaTradeHalt = true;
BaseGame.Situation_Diplomacy_Contana_Missile_Duru_Island = true;
BaseGame.Situation_Diplomacy_ContananInfluence  = true;
BaseGame.Situation_Diplomacy_LackOfAllies = false;
BaseGame.Situation_Diplomacy_StrategicAllianceMember = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;
BaseGame.Situation_Diplomacy_RumburgAggression = false;
BaseGame.Situation_Diplomacy_DiplomaticPressure = false;

BaseGame.Situation_Military_LackOfEquipment = false;
BaseGame.Situation_Military_ModernisedNavy = true;
BaseGame.Situation_Military_OutdatedMilitaryEquipment = false;
BaseGame.Situation_Military_AdequatelyEquippedMilitary = true;
BaseGame.Situation_Military_UCAntiAirMissle_DuruIsland = true;

BaseGame.Situation_Economy_FinancialInvestment_UC = true;
BaseGame.Situation_Economy_FinancialInvestment_Arcasia = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Contana_Military_Support"] = true;
Variable["BaseGame.Situation_Diplomacy_ArcasiaTradeHalt"] = true;
Variable["BaseGame.Situation_Diplomacy_Contana_Missile_Duru_Island"] = true;
Variable["BaseGame.Situation_Diplomacy_ContananInfluence"]  = true;
Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;
Variable["BaseGame.Situation_Diplomacy_StrategicAllianceMember"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
Variable["BaseGame.Situation_Diplomacy_RumburgAggression"] = false;
Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = false;
Variable["BaseGame.Situation_Military_LackOfEquipment"] = false;
Variable["BaseGame.Situation_Military_ModernisedNavy"] = true;
Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] = false;
Variable["BaseGame.Situation_Military_AdequatelyEquippedMilitary"] = true;
Variable["BaseGame.Situation_Military_UCAntiAirMissle_DuruIsland"] = true;
Variable["BaseGame.Situation_Economy_FinancialInvestment_UC"] = true;
Variable["BaseGame.Situation_Economy_FinancialInvestment_Arcasia"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RemovePlayerCountryStatus("Country_Sordland_Recognition_H..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Joined_CSP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Joined_CSP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Narrator: "He slowly stood up from his seat, seemingly struggling."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_CSP");"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance_Cancelled == true && BaseGame.Agnolia_Alliance_Cancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance_Cancelled == true && BaseGame.Ag..."*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance_Cancelled == true && BaseGame...."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance_Cancelled == true && BaseGame.Agnolia_Alliance_Cancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance_Cancelled"] == true  and  Variable["BaseGame.Agnolia_Alliance_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Agno..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance_Cancelled == true && BaseGame.Agnolia_Alliance_Cancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance_Cancelled"] == true  and  Variable["BaseGame.Agnolia_Alliance_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance_Cancelled == true"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance_Cancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance_Cancelled == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance_Cancelled == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance_Cancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Lesp..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance_Cancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance_Cancelled == true"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance_Cancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance_Cancelled == true"*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance_Cancelled == true)"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance_Cancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Agno..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance_Cancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Joined_CSP");"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_AgnoliaLespia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_AgnoliaLespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Joined_CSP = true;
BaseGameSupport.FactionReport_Turn09_CSP_WelcomesSordland = true;
BaseGameSupport.CountryReport_Turn09_Morella_CongratulatesCSPJoin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Joined_CSP"] = true;
Variable["BaseGameSupport.FactionReport_Turn09_CSP_WelcomesSordland"] = true;
Variable["BaseGameSupport.CountryReport_Turn09_Morella_CongratulatesCSPJoin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Joined_CSP");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Joined_CSP");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Agnolia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Agnolia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Lespia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_G_Joined_CSP_EndAlliance_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && ..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Leon Malenyev: ""Just know that standing alone in this world is not as ea..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "He slowly stood up from his seat, seemingly struggling."*)

### Węzeł `[469]`
Mówca: **Leon Malenyev**
> ""Just know that standing alone in this world is not as easy as it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "He slowly stood up from his seat, seemingly struggling."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Player: ""It's a deal, Chairman Malenyev. [Join CSP, Break Allianc..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player: ""It's a deal, Chairman Malenyev. [Join CSP, Break Allianc..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player: ""It's a deal, Chairman Malenyev. [Join CSP]""*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true && BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true && BaseGame.Lespia_Alli..."*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true && BaseGame.Lespia_Al..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true && BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true  and  Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player: ""It's a deal, Chairman Malenyev. [Join CSP, Break Allianc..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true && BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true  and  Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[479]`
**[WYBÓR GRACZA: ""It's a deal, Chairman Malenyev. [Join CSP, Break Alliance with Lespia and Agnolia, -3 Government Budget]""]** — Mówca: **Player**
> ""It's a deal, Chairman Malenyev.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Agnolia_Alliance"] == true  and  Variable["BaseGame.Lespia_Alliance"] == true` AND `Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedA"] == true  and  Variable["BaseGameIsolated.Turn09_FPnT_UCVisit_ListenedB"] == true`
- **Kontekst wejściowy (poprzednik):** `[321]` (Leon Malenyev)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Narrator: "He smiled."*)

### Węzeł `[480]`
**[WYBÓR GRACZA: ""It's a deal, Chairman Malenyev. [Join CSP, Break Alliance with Lespia, -2 Government Budget]""]** — Mówca: **Player**
> ""It's a deal, Chairman Malenyev.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Narrator: "He smiled."*)

### Węzeł `[481]`
**[WYBÓR GRACZA: ""It's a deal, Chairman Malenyev. [Join CSP, Break Alliance with Agnolia, -1 Government Budget]""]** — Mówca: **Player**
> ""It's a deal, Chairman Malenyev.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Narrator: "He smiled."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Valgsland", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Lespia", "Hos..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Lespia", "Hostile");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Agnolia", "Hostile");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It is wonderful to see you, Mr. Chavatangakwunua.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Leon Malenyev: ""You are very kind, Mr. Rayne. Not a lot of people would ..."*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It is wonderful to see you, Mr. Chavatangakwunua.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Leon Malenyev: ""You are very kind, Mr. Rayne. Not a lot of people would ..."*)

### Węzeł `[487]`
Mówca: **Leon Malenyev**
> ""You are very kind, Mr. Rayne. Not a lot of people would even try to pronounce my real name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Leon Malenyev: ""But you can also just call me Malenyev.""*)

### Węzeł `[488]`
Mówca: **Leon Malenyev**
> ""But you can also just call me Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It is wonderful to see you, Mr. Chavatangakwunua.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Leon Malenyev: ""You are very kind, Mr. Rayne. Not a lot of people would ..."*)

### Węzeł `[490]`
Mówca: **Leon Malenyev**
> ""You are very kind, Mr. Rayne. Not a lot of people would even try to pronounce my real name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Leon Malenyev: ""But you can also just call me Malenyev.""*)

### Węzeł `[491]`
Mówca: **Leon Malenyev**
> ""But you can also just call me Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[492]`
Mówca: **Leon Malenyev**
> ""You are very kind, Mr. Rayne. Not a lot of people would even try to pronounce my real name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Leon Malenyev: ""But you can also just call me Malenyev.""*)

### Węzeł `[493]`
Mówca: **Leon Malenyev**
> ""But you can also just call me Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He turned to Monica and shook her hand."*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("ContanaMusic");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("ContanaMusic");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "With another thunderous round of applause, the Contanian ..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = true; BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = false; 
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_CSPMarketInfluencesEnergy ..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = true; BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = false; 
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = true;..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced = true; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance_Cancelled == true && BaseGame.Ag..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Heljiland_Map_Layer = 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Heljiland_Map_Layer"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == true"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_CSP");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_CSP");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_Sordland_CSP_EconomicArea");"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemovePlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Efekt skryptowy (`userScript`):** `RemovePlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Lespia", "Country_Les..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Lespia", "Country_Lespia_Alliance");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Country_Lespia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Lespia", "Country_Les..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Lespia", "Country_Lespia_Trade");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Country_Lespia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Ag..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Alliance");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Valgsland", "Country_..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_Sordland_CSP_EconomicArea");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_CSP_EconomicArea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Valgsland", "..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_TradeTariffs");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_TradeTariffs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rizia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rizia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Joined_CSP = true; BaseGam..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Valgsland", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rizia", "Unfr..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_CSPMarketInfluencesEnergy = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_CSPMarketInfluencesEnergy"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance_Cancelled == true && BaseGame.Ag..."*)
