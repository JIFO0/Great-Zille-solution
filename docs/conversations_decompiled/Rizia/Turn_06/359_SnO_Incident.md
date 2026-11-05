# Rizia/Turn 6/SnO_Incident

- **ID konwersacji:** `359`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/359_SnO_Incident.md`
- **Liczba węzłów dialogowych:** 485
- **Liczba wyborów gracza:** 106

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[81]** Titus Gordion
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Intention_Pales_DeclareWar`
- `RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed`
- `RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed`
- `RiziaDLC.Policy_RD_Order_TankFactory_Completed`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLC.War_Incident_Naval`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina`
- `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_DeclareWar`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Incident_Border_NoAction`
- `RiziaDLC.Incident_Naval_FocusAidOnValero`
- `RiziaDLC.Incident_Naval_FreeShips`
- `RiziaDLC.Incident_Naval_NoRescue`
- `RiziaDLC.Incident_Naval_RescueBoth`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia`
- `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina`
- `RiziaDLCSupport.News_Turn06_G_LandIncident`
- `RiziaDLCSupport.News_Turn06_G_NavalIncident`
- `RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar`
- `RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales`
- `RiziaDLCSupport.News_Turn06_RH_LandIncident`
- `RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression`
- `RiziaDLCSupport.News_Turn06_RH_RecruitementDrive`
- `RiziaDLCSupport.News_Turn06_RH_WhereIsVina`
- `RiziaDLCSupport.News_Turn06_V_LandIncident`
- `RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentFreeShips`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentNoRescue`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentRescueBoth`
- `RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentValeroFocus`
- `RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustryOutputIncrease`
- `RiziaDLCSupport.Reports_Turn06_FortAles_CityOnHighAlert`
- `RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion`
- `RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDenouncesWeakness`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront`
- `RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar`
- `RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_CommunicationsBlackout`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina`
- `RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""Do you know what this is about?""** | `[19]` **Narrator**: "I put on my clothes and followed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Titus Gordion**: ""I was told to come and get you,..." |
| `[10]` | **""Titus? Why am I being disturbed at this hour?""** | `[19]` **Narrator**: "I put on my clothes and followed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Titus Gordion**: ""I was told to come and get you,..." |
| `[11]` | **"Stay silent."** | `[19]` **Narrator**: "I put on my clothes and followed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "When we arrived at the doors to ..."<br>`[13]` **Narrator**: "When we arrived at the doors to ..." |
| `[28]` | **""You're not making this any easier. I need to know what happened. Right now.""** | `[24]` **Hugo Toras**: ""Make sure you are ready. I'm su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Hugo Toras**: ""You are right. Let's just go in."" |
| `[29]` | **""I am always ready, uncle.""** | `[24]` **Hugo Toras**: ""Make sure you are ready. I'm su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Hugo Toras**: ""I'm glad to hear that."" |
| `[30]` | **""I don't have time for this. Just step inside and let me in, so we can discuss it ..."** | `[24]` **Hugo Toras**: ""Make sure you are ready. I'm su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Hugo Toras**: ""You are right. Let's just go in."" |
| `[31]` | **""Don't be cryptic with me. You are supposed to be my Grand Vizier.""** | `[24]` **Hugo Toras**: ""Make sure you are ready. I'm su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Hugo Toras**: ""You are right. Let's just go in."" |
| `[46]` | **""An act of war? I'm sure there's a misunderstanding.""** | `[44]` **Lucita Azaro**: ""I wish there was another way to..." | `(Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false` | *Brak zmian stanu* | `[55]` **Lucita Azaro**: ""This is what we know so far..."" |
| `[47]` | **""This sounds serious. Let's just calm down and start from the beginning.""** | `[44]` **Lucita Azaro**: ""I wish there was another way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucita Azaro**: ""This is what we know so far..."" |
| `[48]` | **""Ah... The conflict we've all been waiting for.""** | `[44]` **Lucita Azaro**: ""I wish there was another way to..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true` | *Brak zmian stanu* | `[54]` **Narrator**: "There was a brief silence. Nobod..." |
| `[52]` | **""Tell me what happened. Now.""** | `[44]` **Lucita Azaro**: ""I wish there was another way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucita Azaro**: ""This is what we know so far..."" |
| `[53]` | **"Gesture for her to continue."** | `[44]` **Lucita Azaro**: ""I wish there was another way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Lucita Azaro**: ""This is what we know so far..."" |
| `[59]` | **""There is something fishy about this. I need more details.""** | `[81]` **Lucita Azaro**: ""The report from the border forc..."<br>`[84]` **Lucita Azaro**: ""Unfortunately as I've stated be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Hugo Toras**: ""I agree. The timing is too perf..." |
| `[60]` | **""Are we absolutely sure they shot at us first?""** | `[81]` **Lucita Azaro**: ""The report from the border forc..."<br>`[84]` **Lucita Azaro**: ""Unfortunately as I've stated be..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Lucita Azaro**: ""It is too early to be certain. ..." |
| `[61]` | **""And what happened to the attackers?""** | `[81]` **Lucita Azaro**: ""The report from the border forc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Lucita Azaro**: ""Unfortunately as I've stated be..." |
| `[65]` | **""And the casualties?""** | `[58]` **Elena Werner**: ""Yes. Navar Castle is one of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucita Azaro**: ""Six of our soldiers, Your Majes..." |
| `[66]` | **""Okay. That's the last straw. If they want war, we'll bring them war.""** | `[58]` **Elena Werner**: ""Yes. Navar Castle is one of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Hugo Toras**: ""Perhaps we may need to."" |
| `[67]` | **""Don't make me laugh. Are you saying Pales is invading us?""** | `[58]` **Elena Werner**: ""Yes. Navar Castle is one of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucita Azaro**: ""Not necessarily, Your Majesty. ..." |
| `[68]` | **""WHAT!? How could such an attack even take place?""** | `[58]` **Elena Werner**: ""Yes. Navar Castle is one of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucita Azaro**: ""I will do everything in my abil..." |
| `[69]` | **""Paleaccis? Are you saying they are after a medieval castle?""** | `[58]` **Elena Werner**: ""Yes. Navar Castle is one of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucita Azaro**: ""No, Your Majesty. I would not s..." |
| `[75]` | **""May the Divine's embrace be upon them, as they return to the source of all creati..."** | `[72]` **Lucita Azaro**: ""Six of our soldiers, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[338]` **Sal Ignacius**: ""Halaita."" |
| `[76]` | **""Those six represented more than numbers, they were sons of Rizia. Make sure their..."** | `[72]` **Lucita Azaro**: ""Six of our soldiers, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lucita Azaro**: ""Of course, Your Majesty."" |
| `[78]` | **""And theirs?""** | `[72]` **Lucita Azaro**: ""Six of our soldiers, Your Majes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lucita Azaro**: ""We don't know yet."" |
| `[82]` | **""And the casualties?""** | `[81]` **Lucita Azaro**: ""The report from the border forc..."<br>`[84]` **Lucita Azaro**: ""Unfortunately as I've stated be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucita Azaro**: ""Six of our soldiers, Your Majes..." |
| `[93]` | **""And do we know how many of them are there right now?""** | `[84]` **Lucita Azaro**: ""Unfortunately as I've stated be..."<br>`[91]` **Hugo Toras**: ""There is something incredibly s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Lucita Azaro**: ""The commanding officer at the b..." |
| `[94]` | **""The real question is: why are they still alive?""** | `[84]` **Lucita Azaro**: ""Unfortunately as I've stated be..."<br>`[91]` **Hugo Toras**: ""There is something incredibly s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lucita Azaro**: ""I would like to know the answer..." |
| `[97]` | **""I agree. We need more details.""** | `[91]` **Hugo Toras**: ""There is something incredibly s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucita Azaro**: ""It is too early to be certain a..." |
| `[100]` | **""Mr. Esquibel, what is your opinion on this incident?""** | `[101]` **Narrator**: "Laurento looked at her skeptically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Laurento Esquibel**: ""Your Majesty, it's perplexing. ..." |
| `[102]` | **""It is too early to be certain of anything. We cannot act without establishing pro..."** | `[101]` **Narrator**: "Laurento looked at her skeptically." | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[105]` **Lucita Azaro**: ""You're right, Your Majesty. But..." |
| `[103]` | **""But what is your opinion, Duchess? Do you believe the reports?""** | `[101]` **Narrator**: "Laurento looked at her skeptically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Lucita Azaro**: ""As I've said, it is too early t..." |
| `[104]` | **""What say you of this incursion, Hugo, Your Grace?""** | `[101]` **Narrator**: "Laurento looked at her skeptically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Hugo Toras**: ""The timing is too perfect for t..." |
| `[106]` | **""And what if it's a false flag?""** | `[101]` **Narrator**: "Laurento looked at her skeptically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Hugo Toras**: ""It is a possibility. To stir di..." |
| `[113]` | **""And who might that be?""** | `[108]` **Laurento Esquibel**: ""Someone is trying to sabotage o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Laurento Esquibel**: ""We need to consider all possibi..." |
| `[114]` | **""What if it's a false flag? This can be exactly what they are trying to make us th..."** | `[108]` **Laurento Esquibel**: ""Someone is trying to sabotage o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Hugo Toras**: ""Yes. It could also be a ruse, a..." |
| `[115]` | **""I agree.""** | `[108]` **Laurento Esquibel**: ""Someone is trying to sabotage o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucita Azaro**: ""Pales has long been unfriendly ..." |
| `[116]` | **""And those would be?""** | `[112]` **Hugo Toras**: ""But it could also be a ruse, a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Hugo Toras**: ""Possibly a false flag operation..." |
| `[117]` | **""Do you think it could be a false flag operation?""** | `[112]` **Hugo Toras**: ""But it could also be a ruse, a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Hugo Toras**: ""It is a possibility. To stir di..." |
| `[118]` | **""I agree.""** | `[112]` **Hugo Toras**: ""But it could also be a ruse, a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Lucita Azaro**: ""Pales has long been unfriendly ..." |
| `[119]` | **""I doubt that.""** | `[112]` **Hugo Toras**: ""But it could also be a ruse, a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Lucita Azaro**: ""Pales has long been unfriendly ..." |
| `[128]` | **""And who might that be?""** | `[126]` **Laurento Esquibel**: ""Someone is trying to sabotage o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Laurento Esquibel**: ""We need to consider all possibi..." |
| `[129]` | **""What if it's an inside job? Someone who knows our patrols, our weaknesses at the ..."** | `[126]` **Laurento Esquibel**: ""Someone is trying to sabotage o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Laurento Esquibel**: ""That is a possibility we must s..." |
| `[130]` | **""I agree.""** | `[126]` **Laurento Esquibel**: ""Someone is trying to sabotage o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Laurento Esquibel**: ""We must consider the possibilit..." |
| `[137]` | **""What if it's an inside job? Someone who knows our patrols, our weaknesses at the ..."** | `[133]` **Lucita Azaro**: ""This is a blunt show of force, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Laurento Esquibel**: ""That is a possibility we must s..." |
| `[138]` | **""I agree.""** | `[133]` **Lucita Azaro**: ""This is a blunt show of force, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Laurento Esquibel**: ""That is a possibility we must s..." |
| `[139]` | **""I highly doubt that Pales would organize an attack like this.""** | `[133]` **Lucita Azaro**: ""This is a blunt show of force, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Laurento Esquibel**: ""We must consider the possibilit..." |
| `[153]` | **""Hold on. Where is Vina? Did we manage to communicate with her at all?""** | `[154]` **Narrator**: "She pointed at the map showing t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Lucita Azaro**: ""Unfortunately, not yet, Your Ma..." |
| `[155]` | **"Wait for Lucita to speak."** | `[154]` **Narrator**: "She pointed at the map showing t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucita Azaro**: ""During the brief firefight, the..." |
| `[156]` | **""I'm getting really worried. Please make it quick.""** | `[154]` **Narrator**: "She pointed at the map showing t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lucita Azaro**: ""During the brief firefight, the..." |
| `[163]` | **""It is too early to be certain of anything. We cannot act so hastily while the Pri..."** | `[101]` **Narrator**: "Laurento looked at her skeptically." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[164]` **Lucita Azaro**: ""You're right, Your Majesty. We ..." |
| `[178]` | **""We must not leap to the drumbeat of war, nor to conclusions. We will investigate ..."** | `[175]` **Narrator**: "I looked upon my council, a tabl..." | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[203]` **Narrator**: "The councillors fell silent, a q..." |
| `[182]` | **""We must not leap to the drumbeat of war, nor to conclusions. We cannot afford to ..."** | `[175]` **Narrator**: "I looked upon my council, a tabl..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[203]` **Narrator**: "The councillors fell silent, a q..." |
| `[183]` | **""I've heard enough. Pales has provoked us for the last time. We will prepare for w..."** | `[175]` **Narrator**: "I looked upon my council, a tabl..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[191]` **Narrator**: "The councillors fell silent, a s..." |
| `[187]` | **""Enough! Pales has dared to shed Rizian blood, and such insolence demands retribut..."** | `[175]` **Narrator**: "I looked upon my council, a tabl..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[191]` **Narrator**: "The councillors fell silent, a s..." |
| `[188]` | **""First, we will get rid of those Palesian soldiers who still have the audacity to ..."** | `[175]` **Narrator**: "I looked upon my council, a tabl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "The councillors fell silent, a r..." |
| `[189]` | **""We cannot allow those soldiers to kill our people and leave our soil unscathed. M..."** | `[175]` **Narrator**: "I looked upon my council, a tabl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "The councillors fell silent, a r..." |
| `[221]` | **""Hold on. Vina is still in Pales. Did we manage to communicate with her at all?""** | `[222]` **Narrator**: "She pointed at the freshly print..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Lucita Azaro**: ""Unfortunately, not yet, Your Ma..." |
| `[223]` | **"Wait for Lucita to speak."** | `[222]` **Narrator**: "She pointed at the freshly print..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Lucita Azaro**: ""The vessel that was sunk was no..." |
| `[224]` | **""I don't have time to read all that. Tell me exactly what happened.""** | `[222]` **Narrator**: "She pointed at the freshly print..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Lucita Azaro**: ""The vessel that was sunk was no..." |
| `[229]` | **""And the casualties?""** | `[228]` **Elena Werner**: ""That's true. Our fleet only act..."<br>`[240]` **Lucita Azaro**: ""I share the same opinion.""<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true) == false` | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Cas...` | `[243]` **Lucita Azaro**: ""We're still ascertaining the fu..." |
| `[230]` | **""Okay. That's the last straw. If they want war, we'll bring them war.""** | `[228]` **Elena Werner**: ""That's true. Our fleet only act..." | `(Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[234]` **Hugo Toras**: ""Perhaps we may need to."" |
| `[231]` | **""Wait. Can you go back to the part where they rammed into our flagship?""** | `[228]` **Elena Werner**: ""That's true. Our fleet only act..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Lucita Azaro**: ""I know it sounds ridiculous, Yo..." |
| `[232]` | **""WHAT!? How can you let such an incident take place?""** | `[228]` **Elena Werner**: ""That's true. Our fleet only act..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Lucita Azaro**: ""The admiral was given the autho..." |
| `[233]` | **""And the extent of the damage?""** | `[228]` **Elena Werner**: ""That's true. Our fleet only act..."<br>`[240]` **Lucita Azaro**: ""I share the same opinion.""<br>*(oraz 5 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true) == false` | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Dam...` | `[241]` **Lucita Azaro**: ""Severe, Your Majesty. The impac..." |
| `[244]` | **""May the Divine's embrace be upon them, as they are healed by the source of all cr..."** | `[243]` **Lucita Azaro**: ""We're still ascertaining the fu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[337]` **Sal Ignacius**: ""Halaita."" |
| `[245]` | **""I hope for the Duke's sake that we have no Rizian casualties on board.""** | `[243]` **Lucita Azaro**: ""We're still ascertaining the fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Narrator**: "Hugo sighed heavily." |
| `[246]` | **""And theirs?""** | `[243]` **Lucita Azaro**: ""We're still ascertaining the fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Lucita Azaro**: ""We don't know yet, Your Majesty."" |
| `[259]` | **""How did the engagement come to pass?""** | `[240]` **Lucita Azaro**: ""I share the same opinion.""<br>`[267]` **Lucita Azaro**: ""The vessel that initiated the c..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true) == false` | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Eng...` | `[265]` **Lucita Azaro**: ""According to the report, around..." |
| `[263]` | **""I've heard enough. We can't spend any more time on this. We need to talk action.""** | `[240]` **Lucita Azaro**: ""I share the same opinion.""<br>`[267]` **Lucita Azaro**: ""The vessel that initiated the c..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Hugo Toras**: ""I agree. The admiral is waiting..." |
| `[268]` | **""How dare they...""** | `[267]` **Lucita Azaro**: ""The vessel that initiated the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Hugo Toras**: ""Reinhart is playing a dangerous..." |
| `[269]` | **""They will pay for what they've done.""** | `[267]` **Lucita Azaro**: ""The vessel that initiated the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Hugo Toras**: ""Reinhart is playing a dangerous..." |
| `[273]` | **""Thank you for the reports. How do you think we should respond?""** | `[240]` **Lucita Azaro**: ""I share the same opinion.""<br>`[267]` **Lucita Azaro**: ""The vessel that initiated the c..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true` | *Brak zmian stanu* | `[291]` **Hugo Toras**: ""We should consider capturing th..." |
| `[279]` | **""And the Palesian ship?""** | `[272]` **Lucita Azaro**: ""The damage control teams are wo..."<br>`[281]` **Lucita Azaro**: ""Therefore we must act quickly, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Lucita Azaro**: ""It sustained catastrophic damag..." |
| `[280]` | **""That sounds incredibly serious. We can't afford to lose our most valuable vessel ..."** | `[272]` **Lucita Azaro**: ""The damage control teams are wo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Lucita Azaro**: ""Therefore we must act quickly, ..." |
| `[287]` | **""And the remaining Palesian vessels?""** | `[240]` **Lucita Azaro**: ""I share the same opinion.""<br>`[267]` **Lucita Azaro**: ""The vessel that initiated the c..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true` | *Brak zmian stanu* | `[288]` **Lucita Azaro**: ""The remaining two, upon seeing ..." |
| `[299]` | **""Duchess Azaro, what is the current status of the Palesian sailors? Do you think t..."** | `[298]` **Lucita Azaro**: ""Our fleet is currently fully fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Lucita Azaro**: ""Your Majesty, the sailors from ..." |
| `[300]` | **""What's the distance to the nearest Rizian port for additional support?""** | `[298]` **Lucita Azaro**: ""Our fleet is currently fully fo..."<br>`[312]` **Lucita Azaro**: ""This has unfortunately left us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Lucita Azaro**: ""The closest port capable of dis..." |
| `[301]` | **""What are your thoughts, Councillor Esquibel?""** | `[298]` **Lucita Azaro**: ""Our fleet is currently fully fo..."<br>`[312]` **Lucita Azaro**: ""This has unfortunately left us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Laurento Esquibel**: ""Your Majesty, leaving the Pales..." |
| `[302]` | **""Hugo, what do you think?""** | `[298]` **Lucita Azaro**: ""Our fleet is currently fully fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Hugo Toras**: ""They provoked us, Your Majesty...." |
| `[313]` | **""I don't think their sailors are a priority for us.""** | `[312]` **Lucita Azaro**: ""This has unfortunately left us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Laurento Esquibel**: ""Your Majesty, leaving the Pales..." |
| `[325]` | **""Vina, what do you think?""** | `[310]` **Lucita Azaro**: ""Diverting our frigates to rescu..."<br>`[361]` **Sal Ignacius**: ""Wise words, Your Highness.""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] == false` | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vin...` | `[359]` **Vina Toras**: ""We should divert our efforts to..." |
| `[326]` | **""I'll be honest. This incident is what we needed. Pales has long been a problem fo..."** | `[310]` **Lucita Azaro**: ""Diverting our frigates to rescu..."<br>`[361]` **Sal Ignacius**: ""Wise words, Your Highness.""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true` | *Brak zmian stanu* | `[346]` **Vina Toras**: ""Father. You can't be serious.""<br>`[347]` **Laurento Esquibel**: ""What does that mean, Your Majes..." |
| `[330]` | **""Do you think Lespia could have any hand in this? This happened right after we can..."** | `[310]` **Lucita Azaro**: ""Diverting our frigates to rescu..."<br>`[361]` **Sal Ignacius**: ""Wise words, Your Highness.""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] == false` | `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Les...` | `[363]` **Laurento Esquibel**: ""The Lespians are furious about ..." |
| `[331]` | **""I think I have the picture. Any last thoughts before I announce my decision?""** | `[310]` **Lucita Azaro**: ""Diverting our frigates to rescu..."<br>`[361]` **Sal Ignacius**: ""Wise words, Your Highness.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Sal Ignacius**: ""May the Divine grant you streng..." |
| `[332]` | **""Alright. Here is what we'll do...""** | `[310]` **Lucita Azaro**: ""Diverting our frigates to rescu..."<br>`[361]` **Sal Ignacius**: ""Wise words, Your Highness.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Player_Romus**: ""We will not attempt any rescue ..."<br>`[355]` **Player_Romus**: ""Our first duty is to our own. F..."<br>*(oraz 4 innych odgałęzień)* |
| `[349]` | **""I've heard enough. Pales has provoked us for the last time. We must prepare for w..."** | `[332]` **Player_Romus**: ""Alright. Here is what we'll do...""<br>`[342]` **Hugo Toras**: ""House Toras expects you to use ..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[354]` **Narrator**: "The councillors fell silent, a s..." |
| `[353]` | **""Enough! Pales has dared to attack us, and such insolence demands retribution. I w..."** | `[332]` **Player_Romus**: ""Alright. Here is what we'll do...""<br>`[342]` **Hugo Toras**: ""House Toras expects you to use ..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[354]` **Narrator**: "The councillors fell silent, a s..." |
| `[355]` | **""Our first duty is to our own. Focus all efforts on the RRN Valero. Dispatch a res..."** | `[332]` **Player_Romus**: ""Alright. Here is what we'll do...""<br>`[342]` **Hugo Toras**: ""House Toras expects you to use ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] = tr...` | `[374]` **Lucita Azaro**: ""Understood, Your Majesty. I wil..." |
| `[356]` | **""We must attempt both rescues. Divert our frigates to aid the Palesian sailors as ..."** | `[332]` **Player_Romus**: ""Alright. Here is what we'll do...""<br>`[342]` **Hugo Toras**: ""House Toras expects you to use ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Incident_Naval_RescueBoth"] = true; Va...` | `[375]` **Lucita Azaro**: ""Understood, Your Majesty. I wil..." |
| `[357]` | **""Release the surrounded Palesian ships and instruct them to assist their sailors. ..."** | `[332]` **Player_Romus**: ""Alright. Here is what we'll do...""<br>`[342]` **Hugo Toras**: ""House Toras expects you to use ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Incident_Naval_FreeShips"] = true; Var...` | `[376]` **Lucita Azaro**: ""Understood, Your Majesty. I wil..." |
| `[358]` | **""We will not attempt any rescue attempts for their sailors. Focus all rescue effor..."** | `[332]` **Player_Romus**: ""Alright. Here is what we'll do...""<br>`[342]` **Hugo Toras**: ""House Toras expects you to use ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Incident_Naval_NoRescue"] = true; Vari...` | `[365]` **Lucita Azaro**: ""Understood, Your Majesty. I wil..." |
| `[369]` | **""You already know about my intentions. We were waiting for them to initiate the at..."** | `[228]` **Elena Werner**: ""That's true. Our fleet only act..." | `Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true` | *Brak zmian stanu* | `[234]` **Hugo Toras**: ""Perhaps we may need to."" |
| `[405]` | **""You've all already heard my decision. We'll call it here.""** | `[394]` **Narrator**: "The councillors fell silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Narrator**: "The councillors bowed in respect..." |
| `[406]` | **""Hold on. I want to hear it. Is there anybody who has the guts to question my deci..."** | `[394]` **Narrator**: "The councillors fell silent." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[414]` **Narrator**: "There was complete silence." |
| `[410]` | **""Thank you. Dismissed.""** | `[394]` **Narrator**: "The councillors fell silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Narrator**: "The councillors bowed in respect..." |
| `[411]` | **""Was there anything else?""** | `[394]` **Narrator**: "The councillors fell silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Hugo Toras**: ""I believe that was all, Your Ma..." |
| `[427]` | **""I'm surprised you're not on Mr. Esquibel's side.""** | `[434]` **Elena Werner**: ""But in this instance, I cannot ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Elena Werner**: ""Why? There is a time for diplom..." |
| `[429]` | **""Request her return immediately. We have to hope they will not do anything insane.""** | `[428]` **Laurento Esquibel**: ""And Princess Vina, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[432]` **Laurento Esquibel**: ""Of course, Your Majesty."" |
| `[430]` | **""I sent her there to teach her a lesson. A little time spent as a hostage will onl..."** | `[428]` **Laurento Esquibel**: ""And Princess Vina, Your Majesty..." | `Variable["RiziaDLC.Relations_Vina"] < 0` | *Brak zmian stanu* | `[449]` **Narrator**: "Laurento looked at me in shock." |
| `[431]` | **""If they indeed try to take her as hostage, we'll burn Pales to the ground.""** | `[428]` **Laurento Esquibel**: ""And Princess Vina, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Laurento Esquibel**: ""Oh..."" |
| `[437]` | **""Thank you, Duchess.""** | `[436]` **Lucita Azaro**: ""I will signal the general staff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Lucita Azaro**: ""I wish it had not come to this...." |
| `[438]` | **""Great. I trust you all to begin the preparations.""** | `[436]` **Lucita Azaro**: ""I will signal the general staff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Lucita Azaro**: ""I wish it had not come to this...." |
| `[439]` | **""Any other questions or comments?""** | `[436]` **Lucita Azaro**: ""I will signal the general staff..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Narrator**: "Laurento looked at me but then a..." |
| `[448]` | **""If they do, call their bluff. Duke Reinhart knows better than to mess with the Ro..."** | `[428]` **Laurento Esquibel**: ""And Princess Vina, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[432]` **Laurento Esquibel**: ""Of course, Your Majesty."" |
| `[450]` | **""You're speaking my language, Ms. Werner.""** | `[434]` **Elena Werner**: ""But in this instance, I cannot ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Laurento Esquibel**: ""Elena. I'm disappointed in you."" |
| `[451]` | **""Precisely. We cannot become an energy superpower without making sacrifices.""** | `[434]` **Elena Werner**: ""But in this instance, I cannot ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Laurento Esquibel**: ""Elena. I'm disappointed in you."" |
| `[452]` | **""This has nothing to do with the gas field. It's blood for blood.""** | `[434]` **Elena Werner**: ""But in this instance, I cannot ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Laurento Esquibel**: ""Elena. I'm disappointed in you."" |

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
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Gridlock", "R_Gridlock_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// BORDER INCIDENT HAPPENS - PLAYER DOESNT KNOW`
- **Efekt skryptowy (`userScript`):** `-- BORDER INCIDENT HAPPENS - PLAYER DOESNT KNOW;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_LandIncident = true; RiziaD..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NAVAL INCIDENT HAPPENS`
- **Efekt skryptowy (`userScript`):** `-- NAVAL INCIDENT HAPPENS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Naval == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Receiving late-night news of a military ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Receiving late-night news of a military ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I was woken up in the middle of the night by the Golden Guard. Due to the sensitivity of the information, I had to be urgently briefed in person."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "As the king, I knew such a summons could only mean dire n..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know what this is about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Titus Gordion: ""I was told to come and get you, Your Majesty. I believe ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus? Why am I being disturbed at this hour?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Titus Gordion: ""I was told to come and get you, Your Majesty. I believe ..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "On our way to the chambers, we spoke no words to each other."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[12]`
Mówca: **Titus Gordion**
> ""I was told to come and get you, Your Majesty. I believe there is an important situation that needs your immediate attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "When we arrived at the doors to the Council of Chambers, Uncle Hugo greeted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo >= 1"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Hugo >= 1)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Hugo"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""Romus, my boy... ""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Hugo >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Hugo"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""Your Majesty...""*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Romus, my boy... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""I'm afraid we'll be facing our biggest crisis yet. I mus..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I put on my clothes and followed Titus through the corrid..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I put on my clothes and followed Titus through the corridors of the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""Do you know what this is about?""*)
  - -> `[10]` (*Player_Romus: ""Titus? Why am I being disturbed at this hour?""*)
  - -> `[11]` (*Player_Romus_Italic: "Stay silent."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "He tugged on my arm, leaned in, and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo >= 1"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "He tugged on my arm, leaned in, and whispered."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""I'm afraid we'll be facing our biggest crisis yet. I mus..."*)

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""I'm afraid we'll be facing our biggest crisis yet. I must stress -- this is the time everybody needs a calm and resilient leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He took a long look at me and my clothes that I'd rushed ..."*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Make sure you are ready. I'm sure you'll do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""You're not making this any easier. I need to know what h..."*)
  - -> `[30]` (*Player_Romus: ""I don't have time for this. Just step inside and let me ..."*)
  - -> `[29]` (*Player_Romus: ""I am always ready, uncle.""*)
  - -> `[31]` (*Player_Romus: ""Don't be cryptic with me. You are supposed to be my Gran..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "He took a long look at me and my clothes that I'd rushed to put on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""Your butler couldn't be summoned in time, I take it.""*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""Your butler couldn't be summoned in time, I take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "He put his hand on my shoulder."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "He put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""Make sure you are ready. I'm sure you'll do the right th..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not making this any easier. I need to know what happened. Right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""You are right. Let's just go in.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am always ready, uncle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""I'm glad to hear that.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time for this. Just step inside and let me in, so we can discuss it properly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""You are right. Let's just go in.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be cryptic with me. You are supposed to be my Grand Vizier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""You are right. Let's just go in.""*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""You are right. Let's just go in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He opened the doors for us and we entered a scene of bare..."*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""I'm glad to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He opened the doors for us and we entered a scene of bare..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "He opened the doors for us and we entered a scene of barely restrained chaos. The councillors were already gathered inside, their faces etched with lines of worry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Upon my entrance, they all stood up immediately."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");
AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Sal Ignacius");
RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Sal Ignacius");
RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Lucita approached me with a calm demeanor that contrasted..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "As the king, I knew such a summons could only mean dire news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Upon my entrance, they all stood up immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro"); AddConversant("Laurento Es..."*)

### Węzeł `[38]`
Mówca: **Lucita Azaro**
> ""Your Majesty... We have an emergency to report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucita Azaro: ""About an hour ago, we received grave news. To put it mil..."*)

### Węzeł `[39]`
Mówca: **Lucita Azaro**
> ""A very serious incident at sea, around the Aureus gas field, has unfolded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Sal Ignacius: ""May the Divine God protect us.""*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucita approached me with a calm demeanor that contrasted with the anxious atmosphere inside. She bowed and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucita Azaro: ""Your Majesty... We have an emergency to report.""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Naval == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucita Azaro: ""A very serious incident at sea, around the Aureus gas fi..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucita Azaro: ""A very serious incident at our southern border with Pale..."*)

### Węzeł `[44]`
Mówca: **Lucita Azaro**
> ""I wish there was another way to put this. The Grand Duchy of Pales has committed an act of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus_Italic: "Gesture for her to continue."*)
  - -> `[47]` (*Player_Romus: ""This sounds serious. Let's just calm down and start from..."*)
  - -> `[52]` (*Player_Romus: ""Tell me what happened. Now.""*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsola..."*)

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""A very serious incident at our southern border with Pales has unfolded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Sal Ignacius: ""May the Divine God protect us.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An act of war? I'm sure there's a misunderstanding.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""This is what we know so far...""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This sounds serious. Let's just calm down and start from the beginning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""This is what we know so far...""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah... The conflict we've all been waiting for.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "There was a brief silence. Nobody responded."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true || RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsola..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIso..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true || RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""Ah... The conflict we've all been waiting for.""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true || RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true || RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true  or  Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""An act of war? I'm sure there's a misunderstanding.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me what happened. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""This is what we know so far...""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "Gesture for her to continue."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent and gestured for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""This is what we know so far...""*)

### Węzeł `[54]`
Mówca: **Narrator**
> "There was a brief silence. Nobody responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""This is what we know so far...""*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""This is what we know so far...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""About an hour ago, we received grave news. To put it mildly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""Approximately an hour ago, a violent exchange erupted between our soldiers and Palesian forces at our border near Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false"*)

### Węzeł `[58]`
Mówca: **Elena Werner**
> ""Yes. Navar Castle is one of the most well-preserved Rezenid-era paleaccis outside of Pales. It is on a small islet on the River Alca -- directly at our border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""And the casualties?""*)
  - -> `[67]` (*Player_Romus: ""Don't make me laugh. Are you saying Pales is invading us?""*)
  - -> `[68]` (*Player_Romus: ""WHAT!? How could such an attack even take place?""*)
  - -> `[69]` (*Player_Romus: ""Paleaccis? Are you saying they are after a medieval cast..."*)
  - -> `[66]` (*Player_Romus: ""Okay. That's the last straw. If they want war, we'll bri..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is something fishy about this. I need more details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro), `[84]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I agree. The timing is too perfect. We were about to sig..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are we absolutely sure they shot at us first?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro), `[84]` (Lucita Azaro), `[91]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucita Azaro: ""It is too early to be certain. We are currently relying ..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what happened to the attackers?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucita Azaro: ""Unfortunately as I've stated before, they have taken ref..."*)

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I agree. The timing is too perfect. We were about to sign the deal to transfer the extraction rights of Aureus to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucita Azaro: ""It is too early to be certain about anything. We are cur..."*)

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""It appears they made a bold and bloody incursion. They've crossed the river and taken refuge in Navar Castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""The paleaccis?""*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""The paleaccis?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Elena Werner: ""Yes. Navar Castle is one of the most well-preserved Reze..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the casualties?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""Six of our soldiers, Your Majesty.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's the last straw. If they want war, we'll bring them war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""Perhaps we may need to.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me laugh. Are you saying Pales is invading us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""Not necessarily, Your Majesty. I would not say that.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT!? How could such an attack even take place?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""I will do everything in my ability to get to the root of..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Paleaccis? Are you saying they are after a medieval castle?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""No, Your Majesty. I would not say that.""*)

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""This is highly symbolic though. Pales is the land of the paleaccis. It is their national identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Elena Werner: ""The choice of the target definitely doesn't seem like a ..."*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""No, Your Majesty. I would not say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""This is highly symbolic though. Pales is the land of the..."*)

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Six of our soldiers, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""May the Divine's embrace be upon them, as they return to..."*)
  - -> `[76]` (*Player_Romus: ""Those six represented more than numbers, they were sons ..."*)
  - -> `[78]` (*Player_Romus: ""And theirs?""*)

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""Not necessarily, Your Majesty. I would not say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The fact they took control of a paleaccis is highly symb..."*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""I will do everything in my ability to get to the root of this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The fact they took control of a paleaccis is highly symb..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Divine's embrace be upon them, as they return to the source of all creation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those six represented more than numbers, they were sons of Rizia. Make sure their families are properly taken care of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucita Azaro: ""Of course, Your Majesty.""*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""Perhaps we may need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Laurento Esquibel: ""I would advise caution, Your Majesty.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And theirs?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucita Azaro: ""We don't know yet.""*)

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""The fact they took control of a paleaccis is highly symbolic. Pales is the land of the paleaccis. It is their national identity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Elena Werner: ""The choice of the target definitely doesn't seem like a ..."*)

### Węzeł `[80]`
Mówca: **Elena Werner**
> ""The choice of the target definitely doesn't seem like a coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""The report from the border force states that our soldier..."*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""The report from the border force states that our soldiers were patrolling just outside of the castle when they were shot at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""And the casualties?""*)
  - -> `[60]` (*Player_Romus: ""Are we absolutely sure they shot at us first?""*)
  - -> `[59]` (*Player_Romus: ""There is something fishy about this. I need more details.""*)
  - -> `[61]` (*Player_Romus: ""And what happened to the attackers?""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the casualties?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro), `[84]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""Six of our soldiers, Your Majesty.""*)

### Węzeł `[83]`
Mówca: **Laurento Esquibel**
> ""I would advise caution, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""The report from the border force states that our soldier..."*)

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""Unfortunately as I've stated before, they have taken refuge in the castle during the firefight and they are still inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""And the casualties?""*)
  - -> `[60]` (*Player_Romus: ""Are we absolutely sure they shot at us first?""*)
  - -> `[59]` (*Player_Romus: ""There is something fishy about this. I need more details.""*)
  - -> `[94]` (*Player_Romus: ""The real question is: why are they still alive?""*)
  - -> `[93]` (*Player_Romus: ""And do we know how many of them are there right now?""*)

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""We don't know yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Sal Ignacius: ""May St. Wruhec embrace their souls.""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Sal Ignacius: ""Halaita.""*)

### Węzeł `[87]`
Mówca: **Lucita Azaro**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Sal Ignacius: ""May St. Wruhec embrace their souls.""*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Hugo sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""There is something incredibly shady about this. The timi..."*)

### Węzeł `[89]`
Mówca: **Lucita Azaro**
> ""It is too early to be certain. We are currently relying on the preliminary news we've received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""According to one onlooker, the first shot was fired from..."*)

### Węzeł `[90]`
Mówca: **Lucita Azaro**
> ""However, the report of the commanding officer implicitly states they were 'attacked' while they were on patrol duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucita Azaro: ""The squad on duty was forced to fall back. As a result, ..."*)

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""There is something incredibly shady about this. The timing and how the incident took place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""I agree. We need more details.""*)
  - -> `[60]` (*Player_Romus: ""Are we absolutely sure they shot at us first?""*)
  - -> `[94]` (*Player_Romus: ""The real question is: why are they still alive?""*)
  - -> `[93]` (*Player_Romus: ""And do we know how many of them are there right now?""*)

### Węzeł `[92]`
Mówca: **Lucita Azaro**
> ""It is too early to be certain about anything. We are currently relying on the preliminary news we've received.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""According to one onlooker, the first shot was fired from..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And do we know how many of them are there right now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Lucita Azaro), `[91]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""The commanding officer at the border suspects at least a..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The real question is: why are they still alive?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Lucita Azaro), `[91]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucita Azaro: ""I would like to know the answer to that question myself,..."*)

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""I would like to know the answer to that question myself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucita Azaro: ""It is too early to be certain about anything. We are cur..."*)

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""During the brief firefight, the Palesians managed to cross our border at the Alca River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucita Azaro: ""It appears they made a bold and bloody incursion. They'v..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We need more details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucita Azaro: ""It is too early to be certain about anything. We are cur..."*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""The commanding officer at the border suspects at least a dozen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucita Azaro: ""It is too early to be certain about anything. We are cur..."*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""According to one onlooker, the first shot was fired from our side directly from the paleaccis. But I find it hard to believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucita Azaro: ""However, the report of the commanding officer implicitly..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Esquibel, what is your opinion on this incident?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Laurento Esquibel: ""Your Majesty, it's perplexing. The Palesians gain nothin..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Laurento looked at her skeptically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""Mr. Esquibel, what is your opinion on this incident?""*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[103]` (*Player_Romus: ""But what is your opinion, Duchess? Do you believe the re..."*)
  - -> `[104]` (*Player_Romus: ""What say you of this incursion, Hugo, Your Grace?""*)
  - -> `[106]` (*Player_Romus: ""And what if it's a false flag?""*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is too early to be certain of anything. We cannot act without establishing proper communication channels with Pales.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""You're right, Your Majesty. But it seems Pales didn't ca..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But what is your opinion, Duchess? Do you believe the reports?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucita Azaro: ""As I've said, it is too early to be certain about anythi..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What say you of this incursion, Hugo, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""The timing is too perfect for this not to have been plan..."*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""You're right, Your Majesty. But it seems Pales didn't care about establishing communication before they killed six of our soldiers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Laurento Esquibel: ""Your Majesty, it's perplexing. The Palesians gain nothin..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if it's a false flag?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""It is a possibility. To stir discord among us, or even p..."*)

### Węzeł `[107]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, it's perplexing. The Palesians gain nothing by occupying an old castle within our borders. Especially considering our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Laurento Esquibel: ""Someone is trying to sabotage our deal. I think that's c..."*)

### Węzeł `[108]`
Mówca: **Laurento Esquibel**
> ""Someone is trying to sabotage our deal. I think that's clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""And who might that be?""*)
  - -> `[114]` (*Player_Romus: ""What if it's a false flag? This can be exactly what they..."*)
  - -> `[115]` (*Player_Romus: ""I agree.""*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""It is a possibility. To stir discord among us, or even provoke a harsh retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Lucita scoffed."*)

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""As I've said, it is too early to be certain about anything. However, there is no reason to doubt the reports coming from our official channels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Laurento Esquibel: ""Your Majesty, it's perplexing. The Palesians gain nothin..."*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""The timing is too perfect for this not to have been planned, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Hugo Toras: ""But it could also be a ruse, a distraction from their tr..."*)

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""But it could also be a ruse, a distraction from their true intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""And those would be?""*)
  - -> `[117]` (*Player_Romus: ""Do you think it could be a false flag operation?""*)
  - -> `[118]` (*Player_Romus: ""I agree.""*)
  - -> `[119]` (*Player_Romus: ""I doubt that.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And who might that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Laurento Esquibel: ""We need to consider all possibilities, Your Majesty.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if it's a false flag? This can be exactly what they are trying to make us think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""Yes. It could also be a ruse, a distraction from their t..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""Pales has long been unfriendly towards us and coveted ou..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And those would be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""Possibly a false flag operation. To stir discord among u..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think it could be a false flag operation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""It is a possibility. To stir discord among us, or even p..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Pales has long been unfriendly towards us and coveted ou..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Pales has long been unfriendly towards us and coveted ou..."*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""Possibly a false flag operation. To stir discord among us, or even provoke a harsh retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Lucita scoffed."*)

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""It can very well turn out to be a false flag operation. To stir discord among us, or even provoke a harsh retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Lucita scoffed."*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Yes. It could also be a ruse, a distraction from their true intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Hugo Toras: ""It can very well turn out to be a false flag operation. ..."*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Pales has long been unfriendly towards us and coveted our lands. They wouldn't want to give away their rights to Aureus so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""This is a blunt show of force, a test of our resolve -- ..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Lucita scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Pales has long been unfriendly towards us and coveted ou..."*)

### Węzeł `[125]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, it's perplexing. The Palesians gain nothing by occupying an old castle within our borders. Especially considering our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Laurento Esquibel: ""Someone is trying to sabotage our deal. I think that's c..."*)

### Węzeł `[126]`
Mówca: **Laurento Esquibel**
> ""Someone is trying to sabotage our deal. I think that's clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player_Romus: ""And who might that be?""*)
  - -> `[129]` (*Player_Romus: ""What if it's an inside job? Someone who knows our patrol..."*)
  - -> `[130]` (*Player_Romus: ""I agree.""*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""This is a blunt show of force, a test of our resolve -- right before the signing of our energy deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Laurento Esquibel: ""Your Majesty, it's perplexing. The Palesians gain nothin..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And who might that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Laurento Esquibel: ""We need to consider all possibilities, Your Majesty.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if it's an inside job? Someone who knows our patrols, our weaknesses at the border.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Laurento Esquibel: ""That is a possibility we must seriously consider, Your M..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Laurento Esquibel: ""We must consider the possibility of an inside job as wel..."*)

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""Pales has long been unfriendly towards us and coveted our lands. They wouldn't want to give away their rights to Aureus so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""This is a blunt show of force, a test of our resolve -- ..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Lucita scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""Pales has long been unfriendly towards us and coveted ou..."*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""This is a blunt show of force, a test of our resolve -- right before the signing of our energy deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""I agree.""*)
  - -> `[137]` (*Player_Romus: ""What if it's an inside job? Someone who knows our patrol..."*)
  - -> `[139]` (*Player_Romus: ""I highly doubt that Pales would organize an attack like ..."*)

### Węzeł `[134]`
Mówca: **Laurento Esquibel**
> ""We need to consider all possibilities, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Laurento Esquibel: ""One obvious explanation is that this was an inside job. ..."*)

### Węzeł `[135]`
Mówca: **Laurento Esquibel**
> ""There is also the possibility that the true provocateur was someone else entirely. An external party who doesn't want us to sign the deal with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Elena Werner: ""Lespia would certainly fit that bill.""*)

### Węzeł `[136]`
Mówca: **Laurento Esquibel**
> ""That is a possibility we must seriously consider, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "Lucita gave him a furious stare."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if it's an inside job? Someone who knows our patrols, our weaknesses at the border.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Laurento Esquibel: ""That is a possibility we must seriously consider, Your M..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Laurento Esquibel: ""That is a possibility we must seriously consider, Your M..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I highly doubt that Pales would organize an attack like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Laurento Esquibel: ""We must consider the possibility of an inside job as wel..."*)

### Węzeł `[140]`
Mówca: **Laurento Esquibel**
> ""We must consider the possibility of an inside job as well. Someone who knows our patrols and our weaknesses at the borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "Lucita gave him a furious stare."*)

### Węzeł `[141]`
Mówca: **Laurento Esquibel**
> ""One obvious explanation is that this was an inside job. Someone who knows our patrols and our weaknesses at the borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "Lucita gave him a furious stare."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "When we arrived at the doors to the council chambers, Hug..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "When we arrived at the doors to the Council of Chambers, ..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "When we arrived at the doors to the council chambers, Hugo and Vina greeted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras"); AddConversant("Vina Toras");"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");
AddConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");
AddConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Hugo Toras: ""Apologies for disturbing both of you at this hour. Thank..."*)

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""Of course, Uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "He tugged on my arm, leaned in, and whispered."*)

### Węzeł `[148]`
Mówca: **Hugo Toras**
> ""Apologies for disturbing both of you at this hour. Thank you for being here so quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""Of course, Uncle.""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""During the brief firefight, the Palesians managed to cro..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_WhereIsVina = true; RiziaD..."*)

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""We'll talk about how to handle this situation. Could you tell us the details first, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lucita Azaro: ""Of course, Your Grace.""*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on. Where is Vina? Did we manage to communicate with her at all?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucita Azaro: ""Unfortunately, not yet, Your Majesty.""*)

### Węzeł `[154]`
Mówca: **Narrator**
> "She pointed at the map showing the border between Rizia and Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""Hold on. Where is Vina? Did we manage to communicate wit..."*)
  - -> `[155]` (*Player_Romus_Italic: "Wait for Lucita to speak."*)
  - -> `[156]` (*Player_Romus: ""I'm getting really worried. Please make it quick.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "Wait for Lucita to speak."]** — Mówca: **Player_Romus_Italic**
> "I waited for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""During the brief firefight, the Palesians managed to cro..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm getting really worried. Please make it quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""During the brief firefight, the Palesians managed to cro..."*)

### Węzeł `[157]`
Mówca: **Lucita Azaro**
> ""Unfortunately, not yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Laurento Esquibel: ""As far as I'm aware, she is supposed to be at the port o..."*)

### Węzeł `[158]`
Mówca: **Laurento Esquibel**
> ""As far as I'm aware, she is supposed to be at the port of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""We'll talk about how to handle this situation. Could you..."*)

### Węzeł `[159]`
Mówca: **Lucita Azaro**
> ""Of course, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""During the brief firefight, the Palesians managed to cro..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""It is too early to be certain of anything. We cannot act..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""It is too early to be certain of anything. We cannot act..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is too early to be certain of anything. We cannot act so hastily while the Princess is in Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucita Azaro: ""You're right, Your Majesty. We have to exercise utmost c..."*)

### Węzeł `[164]`
Mówca: **Lucita Azaro**
> ""You're right, Your Majesty. We have to exercise utmost caution. They can even hold her as a hostage if we're not careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Laurento Esquibel: ""Your Majesty, it's perplexing. The Palesians gain nothin..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Vina Toras: ""What if it's neither Pales nor treachery within, but ano..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Hugo Toras: ""If that's true, then we fell right into his hands by del..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Laurento Esquibel: ""There is also the possibility that the true provocateur ..."*)

### Węzeł `[171]`
Mówca: **Vina Toras**
> ""What if it's neither Pales nor treachery within, but another player on the world stage seeking to embroil us in conflict?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Everybody turned towards Vina."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Everybody turned towards Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Elena Werner: ""Lespia would certainly fit that bill.""*)

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""Lespia would certainly fit that bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "The chamber fell into a restless silence. The theory was ..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "The chamber fell into a restless silence. The theory was as plausible as it was terrifying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I looked upon my council, a tableau of concern, ambition ..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "I looked upon my council, a tableau of concern, ambition and fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[188]` (*Player_Romus: ""First, we will get rid of those Palesian soldiers who st..."*)
  - -> `[189]` (*Player_Romus: ""We cannot allow those soldiers to kill our people and le..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""If that's true, then we fell right into his hands by delivering Vina to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucita Azaro: ""I'm afraid that's the most likely scenario.""*)

### Węzeł `[177]`
Mówca: **Lucita Azaro**
> ""I'm afraid that's the most likely scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Laurento Esquibel: ""There is also the possibility that the true provocateur ..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not leap to the drumbeat of war, nor to conclusions. We will investigate this thoroughly. Establish communications with Pales immediately. We will not act until I talk to the Duke myself and demand an explanation.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "The councillors fell silent, a questioning look on their ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""We must not leap to the drumbeat of war, nor to conclusi..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""We must not leap to the drumbeat of war, nor to conclusi..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not leap to the drumbeat of war, nor to conclusions. We cannot afford to be hasty while Vina is in their hands. We will not act until I talk to the Duke myself and demand an explanation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "The councillors fell silent, a questioning look on their ..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. Pales has provoked us for the last time. We will prepare for war.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "The councillors fell silent, a shocked look on their faces."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: ""Enough! Pales has dared to shed Rizian blood, and such i..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""I've heard enough. Pales has provoked us for the last ti..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough! Pales has dared to shed Rizian blood, and such insolence demands retribution. I will show them the might of our kingdom. Prepare for war!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "The councillors fell silent, a shocked look on their faces."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First, we will get rid of those Palesian soldiers who still have the audacity to occupy our land, and then we will get to the bottom of this. I will not talk to the Duke until those soldiers are dealt with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "The councillors fell silent, a resolved look on their faces."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot allow those soldiers to kill our people and leave our soil unscathed. Make sure they are eliminated or captured immediately. After that's done, I will talk to the Duke and demand an explanation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "The councillors fell silent, a resolved look on their faces."*)

### Węzeł `[190]`
Mówca: **Lucita Azaro**
> ""Approximately half an hour ago, the ships we sent to enforce our claim to the Aureus gas field fired on and sunk a Palesian vessel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucita Azaro: ""According to our reports, a small fleet of three Palesia..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "The councillors fell silent, a shocked look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""Understood, Your Majesty. Our soldiers will march at you..."*)

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. Our soldiers will march at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DeclareWar = true; RiziaDLCSuppo..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "The councillors fell silent, a resolved look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers = true; RiziaDLC.Di..."*)

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the commander know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Hugo Toras: ""A prudent decision. Our enemies will see hesitation as w..."*)

### Węzeł `[195]`
Mówca: **Hugo Toras**
> ""A prudent decision. Our enemies will see hesitation as weakness. We must show them there are repercussions for their actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""I still believe this to be hasty, Your Majesty. We should first hear what they have to say before conducting any operations on the castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""I believe His Majesty has already made his decision.""*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Vina Toras: ""But what if this was indeed an inside job or a third par..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Laurento Esquibel: ""I still believe this to be hasty, Your Majesty. We shoul..."*)

### Węzeł `[200]`
Mówca: **Vina Toras**
> ""But what if this was indeed an inside job or a third party? I fear this path may lead to unnecessary bloodshed. Don't you think it's best to talk to Duke Reinhart before we act?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Laurento Esquibel: ""I agree with Her Highness, Your Majesty. We should first..."*)

### Węzeł `[201]`
Mówca: **Laurento Esquibel**
> ""I agree with Her Highness, Your Majesty. We should first hear what they have to say before conducting any operations on the castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""I believe His Majesty has already made his decision.""*)

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""I believe His Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales = true;"*)

### Węzeł `[203]`
Mówca: **Narrator**
> "The councillors fell silent, a questioning look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_NoAction = true; RiziaDLCSupport..."*)

### Węzeł `[204]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty, but let us not delay. Every moment we ponder, Pales grows bolder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[205]`
Mówca: **Hugo Toras**
> ""Our enemies will see hesitation as weakness. If we don't show them there are repercussions for their actions, this will only embolden them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Sal Ignacius: ""I believe His Majesty has already made his decision.""*)

### Węzeł `[206]`
Mówca: **Laurento Esquibel**
> ""I agree with your decision, Your Majesty. We have to be calm if we want to find out the truth and reach an understanding with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Hugo Toras: ""Our enemies will see hesitation as weakness. If we don't..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Vina Toras: ""I support the decision. We have to be calm if we want to..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Laurento Esquibel: ""I agree with your decision, Your Majesty. We have to be ..."*)

### Węzeł `[210]`
Mówca: **Vina Toras**
> ""I support the decision. We have to be calm if we want to find out the truth and reach an understanding with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Hugo Toras: ""Our enemies will see hesitation as weakness. If we don't..."*)

### Węzeł `[211]`
Mówca: **Lucita Azaro**
> ""The squad on duty was forced to fall back. As a result, the Palesians managed to enter the castle. The commander reported they have surrounded them but waiting for orders before taking any actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Laurento looked at her skeptically."*)

### Węzeł `[212]`
Mówca: **Lucita Azaro**
> ""Their other two vessels were immediately surrounded. They are still being kept at the location of the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Hugo Toras: ""It's an outrage! They were warned, yet they encroached u..."*)

### Węzeł `[213]`
Mówca: **Hugo Toras**
> ""It's an outrage! They were warned, yet they encroached upon the field, knowing that our navy would defend it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Elena Werner: ""That's true. Our fleet only acted in defense of our nati..."*)

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""According to our reports, a small fleet of three Palesian ships advanced directly at our ships despite repeated warnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false"*)

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""The vessel that was sunk was not only warned, it managed to ram into our flagship -- RRN Valero -- damaging it almost beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucita Azaro: ""Our fleet then acted in retaliation, discharging its wea..."*)

### Węzeł `[216]`
Mówca: **Lucita Azaro**
> ""Our fleet then acted in retaliation, discharging its weapons at the Palesians and sinking one of their ships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucita Azaro: ""Their other two vessels were immediately surrounded. The..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""The vessel that was sunk was not only warned, it managed..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_WhereIsVina = true; RiziaD..."*)

### Węzeł `[220]`
Mówca: **Hugo Toras**
> ""We'll talk about how to handle this situation. Could you tell us the details first, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucita Azaro: ""Of course, Your Grace.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on. Vina is still in Pales. Did we manage to communicate with her at all?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucita Azaro: ""Unfortunately, not yet, Your Majesty.""*)

### Węzeł `[222]`
Mówca: **Narrator**
> "She pointed at the freshly printed report on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""Hold on. Vina is still in Pales. Did we manage to commun..."*)
  - -> `[223]` (*Player_Romus_Italic: "Wait for Lucita to speak."*)
  - -> `[224]` (*Player_Romus: ""I don't have time to read all that. Tell me exactly what..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: "Wait for Lucita to speak."]** — Mówca: **Player_Romus_Italic**
> "I waited for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""The vessel that was sunk was not only warned, it managed..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time to read all that. Tell me exactly what happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""The vessel that was sunk was not only warned, it managed..."*)

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""Unfortunately, not yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Laurento Esquibel: ""As far as I'm aware, she is supposed to be at the port o..."*)

### Węzeł `[226]`
Mówca: **Laurento Esquibel**
> ""As far as I'm aware, she is supposed to be at the port of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Hugo Toras: ""We'll talk about how to handle this situation. Could you..."*)

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""Of course, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""The vessel that was sunk was not only warned, it managed..."*)

### Węzeł `[228]`
Mówca: **Elena Werner**
> ""That's true. Our fleet only acted in defense of our nation's asset. But this is still a disaster. The sinking of a ship is a grave matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""And the casualties?""*)
  - -> `[233]` (*Player_Romus: ""And the extent of the damage?""*)
  - -> `[231]` (*Player_Romus: ""Wait. Can you go back to the part where they rammed into..."*)
  - -> `[232]` (*Player_Romus: ""WHAT!? How can you let such an incident take place?""*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intention_Pales_DeclareWar == true"*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the casualties?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[228]` (Elena Werner), `[240]` (Lucita Azaro), `[267]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties = ..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's the last straw. If they want war, we'll bring them war.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[228]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Hugo Toras: ""Perhaps we may need to.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. Can you go back to the part where they rammed into our flagship?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Lucita Azaro: ""I know it sounds ridiculous, Your Majesty.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHAT!? How can you let such an incident take place?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Lucita Azaro: ""The admiral was given the authority to do *whatever it t..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the extent of the damage?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[228]` (Elena Werner), `[240]` (Lucita Azaro), `[267]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages = true"*)

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""Perhaps we may need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Laurento Esquibel: ""I would advise caution, Your Majesty. Why don't we go ov..."*)

### Węzeł `[235]`
Mówca: **Laurento Esquibel**
> ""I would advise caution, Your Majesty. Why don't we go over the report first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Elena Werner: ""It seemed to be a very intentional attack to provoke a r..."*)

### Węzeł `[236]`
Mówca: **Lucita Azaro**
> ""The admiral was given the authority to do *whatever it takes* not to let Palesian ships into the field, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Lucita Azaro: ""I'm afraid it was the Palesians who forced our hand.""*)

### Węzeł `[237]`
Mówca: **Lucita Azaro**
> ""I'm afraid it was the Palesians who forced our hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Elena Werner: ""It seemed to be a very intentional attack to provoke a r..."*)

### Węzeł `[238]`
Mówca: **Lucita Azaro**
> ""I know it sounds ridiculous, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Elena Werner: ""It seemed to be a very intentional attack to provoke a r..."*)

### Węzeł `[239]`
Mówca: **Elena Werner**
> ""It seemed to be a very intentional attack to provoke a response from us. And I think they have already succeeded in their plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lucita Azaro: ""I share the same opinion.""*)

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""I share the same opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "NavalIncidentHub"*)

### Węzeł `[241]`
Mówca: **Lucita Azaro**
> ""Severe, Your Majesty. The impact compromised the hull's integrity, causing significant flooding in the engine room and adjacent compartments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucita Azaro: ""The Valero's propulsion system is heavily damaged, rende..."*)

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""The admiral is waiting for your orders on how to deal with the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucita Azaro: ""Additionally, it is reported that there are survivors fr..."*)

### Węzeł `[243]`
Mówca: **Lucita Azaro**
> ""We're still ascertaining the full extent, but preliminary reports suggest multiple injuries aboard the Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""And theirs?""*)
  - -> `[244]` (*Player_Romus: ""May the Divine's embrace be upon them, as they are heale..."*)
  - -> `[245]` (*Player_Romus: ""I hope for the Duke's sake that we have no Rizian casual..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Divine's embrace be upon them, as they are healed by the source of all creation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope for the Duke's sake that we have no Rizian casualties on board.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And theirs?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucita Azaro: ""We don't know yet, Your Majesty.""*)

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""We don't know yet, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Sal Ignacius: ""May St. Wruhec embrace their souls.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Sal Ignacius: ""Halaita.""*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Hugo sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub]"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NavalIncidentHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties ==..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement ==..."*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement ==..."*)
  - -> `[263]` (*Player_Romus: ""I've heard enough. We can't spend any more time on this...."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucita Azaro: ""We're still ascertaining the full extent, but preliminar..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties ==..."*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties ..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""And the casualties?""*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucita Azaro: ""Severe, Your Majesty. The impact compromised the hull's ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == ..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""And the extent of the damage?""*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How did the engagement come to pass?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[240]` (Lucita Azaro), `[267]` (Lucita Azaro), `[277]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement = ..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement ==..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement ..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player_Romus: ""How did the engagement come to pass?""*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. We can't spend any more time on this. We need to talk action.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Lucita Azaro), `[267]` (Lucita Azaro), `[277]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Hugo Toras: ""I agree. The admiral is waiting for our decision.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucita Azaro: ""According to the report, around 0400 hours, our naval fo..."*)

### Węzeł `[265]`
Mówca: **Lucita Azaro**
> ""According to the report, around 0400 hours, our naval forces, consisting of the flagship RRN Valero and three frigates, were patrolling the field, when the Palesian fleet, composed of three armed vessels, approached the disputed zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucita Azaro: ""Despite repeated warnings, they continued their advance ..."*)

### Węzeł `[266]`
Mówca: **Lucita Azaro**
> ""Despite repeated warnings, they continued their advance -- executing aggressive maneuvers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lucita Azaro: ""The vessel that initiated the conflict attempted to bypa..."*)

### Węzeł `[267]`
Mówca: **Lucita Azaro**
> ""The vessel that initiated the conflict attempted to bypass our blockade, accelerating towards the RRN Valero. In a reckless act, it rammed our flagship on the starboard side near the engine room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub]"*)
  - -> `[268]` (*Player_Romus: ""How dare they...""*)
  - -> `[269]` (*Player_Romus: ""They will pay for what they've done.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare they...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Hugo Toras: ""Reinhart is playing a dangerous game.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will pay for what they've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Hugo Toras: ""Reinhart is playing a dangerous game.""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NavalIncidentHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "NavalIncidentHub"*)

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""The Valero's propulsion system is heavily damaged, rendering the ship immobile. It is currently running on emergency power, but the flooding is critical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Lucita Azaro: ""The damage control teams are working tirelessly, but wit..."*)

### Węzeł `[272]`
Mówca: **Lucita Azaro**
> ""The damage control teams are working tirelessly, but without external assistance, the risk of losing the flagship is very high. We estimate approximately 150 sailors are engaged in containment efforts as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""And the Palesian ship?""*)
  - -> `[280]` (*Player_Romus: ""That sounds incredibly serious. We can't afford to lose ..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the reports. How do you think we should respond?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true`
- **Kontekst wejściowy (poprzednik):** `[240]` (Lucita Azaro), `[267]` (Lucita Azaro), `[277]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Hugo Toras: ""We should consider capturing their remaining ships as a ..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement ==..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement ..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""And the remaining Palesian vessels?""*)
  - -> `[273]` (*Player_Romus: ""Thank you for the reports. How do you think we should re..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[277]`
Mówca: **Hugo Toras**
> ""Reinhart is playing a dangerous game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub]"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NavalIncidentHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "NavalIncidentHub"*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the Palesian ship?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Lucita Azaro), `[281]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""It sustained catastrophic damage post-collision. Seconds..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds incredibly serious. We can't afford to lose our most valuable vessel by an attack like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucita Azaro: ""Therefore we must act quickly, Your Majesty. Our fleet r..."*)

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""Therefore we must act quickly, Your Majesty. Our fleet requires all the help we can give.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""And the Palesian ship?""*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub]"*)

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""It sustained catastrophic damage post-collision. Seconds after the collision, it was shot at by multiple shots by our frigates. It capsized minutes after the ramming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Lucita Azaro: ""However, there are reasons to believe the collision was ..."*)

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""However, there are reasons to believe the collision was enough for it to sink -- and our shots may not be the main reason. It is too early to tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucita Azaro: ""Our initial reports indicate survivors, but they are in ..."*)

### Węzeł `[284]`
Mówca: **Lucita Azaro**
> ""Our initial reports indicate survivors, but they are in perilous waters, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Laurento Esquibel: ""We can't simply let them drown. We have to do something.""*)

### Węzeł `[285]`
Mówca: **Laurento Esquibel**
> ""We can't simply let them drown. We have to do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucita Azaro: ""We need our efforts focused on saving the Valero and our..."*)

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""We need our efforts focused on saving the Valero and our sailors inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub]"*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the remaining Palesian vessels?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Engagement"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Damages"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub1_Casualties"] == true`
- **Kontekst wejściowy (poprzednik):** `[240]` (Lucita Azaro), `[267]` (Lucita Azaro), `[277]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Lucita Azaro: ""The remaining two, upon seeing their companion's fate, c..."*)

### Węzeł `[288]`
Mówca: **Lucita Azaro**
> ""The remaining two, upon seeing their companion's fate, ceased their advance and are currently held at a standoff distance. They're completely surrounded and outgunned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucita Azaro: ""The admiral is waiting for your orders on how to deal wi..."*)

### Węzeł `[289]`
Mówca: **Hugo Toras**
> ""I agree. The admiral is waiting for our decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Lucita Azaro: ""Exactly.""*)

### Węzeł `[290]`
Mówca: **Lucita Azaro**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Hugo Toras: ""We should consider capturing their remaining ships as a ..."*)

### Węzeł `[291]`
Mówca: **Hugo Toras**
> ""We should consider capturing their remaining ships as a bargaining chip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Elena Werner: ""As I understand, we already have them surrounded.""*)

### Węzeł `[292]`
Mówca: **Elena Werner**
> ""As I understand, we already have them surrounded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lucita Azaro: ""Yes, we do.""*)

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Yes, we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Lucita Azaro: ""The remaining two, upon seeing their companion's fate, c..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true &..."*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: ""Do you think Lespia could have any hand in this? This ha..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[297]`
Mówca: **Lucita Azaro**
> ""Additionally, it is reported that there are survivors from the colliding ship. These are perilous waters, Your Majesty, so we do not know if we'll be able to manage a complete rescue operation without any help arriving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lucita Azaro: ""Our fleet is currently fully focused on holding the rema..."*)

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""Our fleet is currently fully focused on holding the remaining vessels in place, while trying to help the RRN Valero contain the flooding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player_Romus: ""Duchess Azaro, what is the current status of the Palesia..."*)
  - -> `[300]` (*Player_Romus: ""What's the distance to the nearest Rizian port for addit..."*)
  - -> `[301]` (*Player_Romus: ""What are your thoughts, Councillor Esquibel?""*)
  - -> `[302]` (*Player_Romus: ""Hugo, what do you think?""*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro, what is the current status of the Palesian sailors? Do you think they can be saved?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Lucita Azaro: ""Your Majesty, the sailors from the capsized vessel are i..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the distance to the nearest Rizian port for additional support?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Lucita Azaro), `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Lucita Azaro: ""The closest port capable of dispatching a rescue team is..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are your thoughts, Councillor Esquibel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Lucita Azaro), `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Laurento Esquibel: ""Your Majesty, leaving the Palesian sailors to fend for t..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo, what do you think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Hugo Toras: ""They provoked us, Your Majesty. We cannot simply keep pl..."*)

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""The closest port capable of dispatching a rescue team is on the mainland. Under current conditions, it would take several hours for a rescue team to reach the site.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Elena Werner: ""Those sailors don’t have several hours in these waters, ..."*)

### Węzeł `[304]`
Mówca: **Elena Werner**
> ""Those sailors don’t have several hours in these waters, Your Grace. We're talking about the open sea, and they're likely without sufficient life-saving equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Laurento Esquibel: ""Your Majesty, leaving the Palesian sailors to fend for t..."*)

### Węzeł `[305]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, leaving the Palesian sailors to fend for themselves could be seen as a severe dereliction of maritime duty. It would damage our international standing and the Duke would paint us as inhumane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Hugo Toras: ""This is their game, Councillor Esquibel. We can't let th..."*)

### Węzeł `[306]`
Mówca: **Hugo Toras**
> ""This is their game, Councillor Esquibel. We can't let them write the rules for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucita Azaro: ""However, focusing our efforts on the RRN Valero is cruci..."*)

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""However, focusing our efforts on the RRN Valero is crucial. It’s not only about saving our flagship -- which is our most expensive asset in the navy -- but also about preventing further loss of Rizian life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Lucita Azaro: ""Diverting our frigates to rescue could jeopardize the co..."*)

### Węzeł `[308]`
Mówca: **Hugo Toras**
> ""They provoked us, Your Majesty. We cannot simply keep playing their game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Hugo Toras: ""We need to give a strong response. I don't think we shou..."*)

### Węzeł `[309]`
Mówca: **Hugo Toras**
> ""We need to give a strong response. I don't think we should let those ships go free. We need them as leverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[310]`
Mówca: **Lucita Azaro**
> ""Diverting our frigates to rescue could jeopardize the containment efforts on the Valero -- as well as risk the escape of the Palesian vessels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "NavalIncidentHub2"*)

### Węzeł `[311]`
Mówca: **Lucita Azaro**
> ""Your Majesty, the sailors from the capsized vessel are in deep waters. Our frigates are currently occupied with both containing the situation aboard the RRN Valero and maintaining a perimeter around the remaining Palesian ships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucita Azaro: ""This has unfortunately left us with limited resources to..."*)

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""This has unfortunately left us with limited resources to mount an immediate rescue operation for the Palesian sailors. We can send a rescue team instead of diverting the resources of our fleet there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player_Romus: ""I don't think their sailors are a priority for us.""*)
  - -> `[300]` (*Player_Romus: ""What's the distance to the nearest Rizian port for addit..."*)
  - -> `[301]` (*Player_Romus: ""What are your thoughts, Councillor Esquibel?""*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think their sailors are a priority for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Laurento Esquibel: ""Your Majesty, leaving the Palesian sailors to fend for t..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Vina Toras: ""What about the sailors waiting for rescue?""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Elena Werner: ""I agree, Your Grace. We need all the leverage against Pa..."*)

### Węzeł `[317]`
Mówca: **Vina Toras**
> ""What about the sailors waiting for rescue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "Laurento nodded in approval and quickly cut in."*)

### Węzeł `[318]`
Mówca: **Elena Werner**
> ""I agree, Your Grace. We need all the leverage against Pales. However, we cannot let them paint us as the aggressors when they clearly initiated the attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Elena Werner: ""We should show compassion to their sailors.""*)

### Węzeł `[319]`
Mówca: **Elena Werner**
> ""We should show compassion to their sailors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "Laurento nodded in approval and quickly cut in."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "Laurento nodded in approval and quickly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Laurento Esquibel: ""Your Majesty, leaving the Palesian sailors to fend for t..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Player_Romus: ""Vina, what do you think?""*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false && RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Vina Toras: ""We should divert our efforts to rescue their sailors. Ou..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, what do you think?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina"] == false`
- **Kontekst wejściowy (poprzednik):** `[310]` (Lucita Azaro), `[361]` (Sal Ignacius), `[364]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Vina = true"*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be honest. This incident is what we needed. Pales has long been a problem for us. We can use this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true`
- **Kontekst wejściowy (poprzednik):** `[310]` (Lucita Azaro), `[361]` (Sal Ignacius), `[364]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == t..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: ""I'll be honest. This incident is what we needed. Pales h..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think Lespia could have any hand in this? This happened right after we cancelled our deal to cede the field to them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true  and  Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] == false`
- **Kontekst wejściowy (poprzednik):** `[310]` (Lucita Azaro), `[361]` (Sal Ignacius), `[364]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia = true"*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I have the picture. Any last thoughts before I announce my decision?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Lucita Azaro), `[361]` (Sal Ignacius), `[364]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Sal Ignacius: ""May the Divine grant you strength, Your Majesty.""*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Here is what we'll do...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Lucita Azaro), `[361]` (Sal Ignacius), `[364]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "NavalIncidentDecision"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Incident_Naval_Hub2_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Laurento Esquibel: ""The Lespians are furious about it. But I don't think wou..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NavalIncidentHub2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true &..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive == true"*)
  - -> `[331]` (*Player_Romus: ""I think I have the picture. Any last thoughts before I a..."*)
  - -> `[332]` (*Player_Romus: ""Alright. Here is what we'll do...""*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NavalIncidentDecision`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""We will not attempt any rescue attempts for their sailor..."*)
  - -> `[355]` (*Player_Romus: ""Our first duty is to our own. Focus all efforts on the R..."*)
  - -> `[356]` (*Player_Romus: ""We must attempt both rescues. Divert our frigates to aid..."*)
  - -> `[357]` (*Player_Romus: ""Release the surrounded Palesian ships and instruct them ..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[336]`
Mówca: **Sal Ignacius**
> ""May the Divine God protect us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)

### Węzeł `[337]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[338]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[339]`
Mówca: **Sal Ignacius**
> ""May St. Wruhec embrace their souls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[340]`
Mówca: **Sal Ignacius**
> ""May St. Wruhec embrace their souls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[341]`
Mówca: **Sal Ignacius**
> ""May the Divine grant you strength, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Hugo Toras: ""House Toras expects you to use this opportunity, Your Ma..."*)

### Węzeł `[342]`
Mówca: **Hugo Toras**
> ""House Toras expects you to use this opportunity, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "NavalIncidentDecision"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Vina Toras: ""Father. You can't be serious.""*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Laurento Esquibel: ""What does that mean, Your Majesty?""*)

### Węzeł `[346]`
Mówca: **Vina Toras**
> ""Father. You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "NavalIncidentDecision"*)

### Węzeł `[347]`
Mówca: **Laurento Esquibel**
> ""What does that mean, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "NavalIncidentDecision"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NavalIncidentHub2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "NavalIncidentHub2"*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. Pales has provoked us for the last time. We must prepare for war.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[332]` (Player_Romus), `[342]` (Hugo Toras), `[346]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The councillors fell silent, a shocked look on their faces."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""Enough! Pales has dared to attack us, and such insolence..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: ""I've heard enough. Pales has provoked us for the last ti..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough! Pales has dared to attack us, and such insolence demands retribution. I will show them the might of our kingdom. Prepare for war!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[332]` (Player_Romus), `[342]` (Hugo Toras), `[346]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The councillors fell silent, a shocked look on their faces."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "The councillors fell silent, a shocked look on their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""Understood, Your Majesty. Our soldiers will march at you..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our first duty is to our own. Focus all efforts on the RRN Valero. Dispatch a rescue team from the mainland for the Palesian sailors, but our immediate priority is saving the Valero and its crew. Keep the frigates focused on the Palesian ships.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Player_Romus), `[342]` (Hugo Toras), `[346]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero = true; RiziaDLC..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must attempt both rescues. Divert our frigates to aid the Palesian sailors as well as to continue to assist the Valero. Send for the mainland rescue team as backup.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Player_Romus), `[342]` (Hugo Toras), `[346]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_RescueBoth = true; RiziaDLCSuppor..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Release the surrounded Palesian ships and instruct them to assist their sailors. Our frigates will focus on the Valero.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Player_Romus), `[342]` (Hugo Toras), `[346]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FreeShips = true; RiziaDLCSupport..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not attempt any rescue attempts for their sailors. Focus all rescue efforts on the RRN Valero. Dispatch a rescue team from the mainland for the flagship, but make sure our frigates are locked onto the Palesian ships in the meantime.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Player_Romus), `[342]` (Hugo Toras), `[346]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_NoRescue = true; RiziaDLC.Diploma..."*)

### Węzeł `[359]`
Mówca: **Vina Toras**
> ""We should divert our efforts to rescue their sailors. Our priority should be human lives, regardless if it's Palesian or Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Vina Toras: ""And if it was indeed their plan to push us into a corner..."*)

### Węzeł `[360]`
Mówca: **Vina Toras**
> ""And if it was indeed their plan to push us into a corner -- we shouldn't fall for their trap. We should show the world that Rizia has compassion even when attacked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Sal Ignacius: ""Wise words, Your Highness.""*)

### Węzeł `[361]`
Mówca: **Sal Ignacius**
> ""Wise words, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub2]"*)

### Węzeł `[362]`
Mówca: **Hugo Toras**
> ""Without a greenlight from Lespia, the Duke would never do something like this. I think the connection is obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Laurento Esquibel: ""Even if that's true, that makes our situation only worse..."*)

### Węzeł `[363]`
Mówca: **Laurento Esquibel**
> ""The Lespians are furious about it. But I don't think would have forced the Palesians to engage us directly like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Hugo Toras: ""Without a greenlight from Lespia, the Duke would never d..."*)

### Węzeł `[364]`
Mówca: **Laurento Esquibel**
> ""Even if that's true, that makes our situation only worse. We cannot afford to go against Lespia while half of the world is backing them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [NavalIncidentHub2]"*)

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Hugo Toras: ""It's a sound approach, Your Majesty. Our flagship repres..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intention_Pales_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intention_Pales_DeclareWar == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intention_Pales_DeclareWar == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intention_Pales_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Player_Romus: ""You already know about my intentions. We were waiting fo..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intention_Pales_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: ""Okay. That's the last straw. If they want war, we'll bri..."*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already know about my intentions. We were waiting for them to initiate the attack -- and they did. It's time for us to bring them the war they wanted.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Intention_Pales_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[228]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Hugo Toras: ""Perhaps we may need to.""*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_NoRescue = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentNoRescue = true;
RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests = true;
RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Incident_Naval_NoRescue"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentNoRescue"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests"] = true;
Variable["RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Lucita Azaro: ""Understood, Your Majesty. I will let the admiral know ab..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentValeroFocus = true;
RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests = true;
RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentValeroFocus"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests"] = true;
Variable["RiziaDLCSupport.News_Turn06_V_SailorsLeftToDie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Lucita Azaro: ""Understood, Your Majesty. I will let the admiral know ab..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_RescueBoth = true;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentRescueBoth = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentRescueBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Lucita Azaro: ""Understood, Your Majesty. I will let the admiral know ab..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FreeShips = true;
RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentFreeShips = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Incident_Naval_FreeShips"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Aureus_NavalIncidentFreeShips"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Lucita Azaro: ""Understood, Your Majesty. I will let the admiral know ab..."*)

### Węzeł `[374]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Hugo Toras: ""It's a sound approach, Your Majesty. Our flagship repres..."*)

### Węzeł `[375]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Hugo Toras: ""It's a risky maneuver, Your Majesty. I hope this does no..."*)

### Węzeł `[376]`
Mówca: **Lucita Azaro**
> ""Understood, Your Majesty. I will let the admiral know about your orders immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Hugo Toras: ""It's a risky maneuver, Your Majesty. I hope this does no..."*)

### Węzeł `[377]`
Mówca: **Hugo Toras**
> ""It's a risky maneuver, Your Majesty. I hope this does not come at the cost of our flagship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Elena Werner: ""Juggling both responsibilities will be a challenge, but ..."*)

### Węzeł `[378]`
Mówca: **Hugo Toras**
> ""It's a risky maneuver, Your Majesty. I hope this does not come at the cost of losing all of our leverage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Elena Werner: ""Releasing their ships is regrettable, but it may be the ..."*)

### Węzeł `[379]`
Mówca: **Hugo Toras**
> ""It's a sound approach, Your Majesty. Our flagship represents Rizia's strength. We cannot afford to lose it -- nor the ships that attacked us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Elena Werner: ""I agree. It makes sense from a resource management persp..."*)

### Węzeł `[380]`
Mówca: **Elena Werner**
> ""I agree. It makes sense from a resource management perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Elena Werner: ""...Of course, the human cost is regrettable.""*)

### Węzeł `[381]`
Mówca: **Elena Werner**
> ""...Of course, the human cost is regrettable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Lucita Azaro: ""The rescue crew can still make it in time to save everyo..."*)

### Węzeł `[382]`
Mówca: **Elena Werner**
> ""Juggling both responsibilities will be a challenge, but it may be the best course to mitigate broader consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[383]`
Mówca: **Elena Werner**
> ""Releasing their ships is regrettable, but it may be the best course to mitigate broader consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared = true;
RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursionCleared"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarLand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucita Azaro: ""Understood, Your Majesty. I will let the commander know ..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_NoAction = true;
RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion = true;
RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDenouncesWeakness = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Incident_Border_NoAction"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_FortAles_PalesIncursion"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDenouncesWeakness"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucita Azaro: ""Understood, Your Majesty, but let us not delay. Every mo..."*)

### Węzeł `[386]`
Mówca: **Laurento Esquibel**
> ""This action may have diplomatic repercussions, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Hugo Toras: ""I believe His Majesty has already made his decision.""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Vina Toras: ""I understand that the safety of our crew must be our par..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Laurento Esquibel: ""This action may have diplomatic repercussions, Your Maje..."*)

### Węzeł `[390]`
Mówca: **Vina Toras**
> ""I understand that the safety of our crew must be our paramount concern, but why don't we divert our ships that are already in the scene to help?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Laurento Esquibel: ""I agree with Your Highness, Your Majesty. This action ma..."*)

### Węzeł `[391]`
Mówca: **Laurento Esquibel**
> ""I agree with Your Highness, Your Majesty. This action may have diplomatic repercussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Hugo Toras: ""I believe His Majesty has already made his decision.""*)

### Węzeł `[392]`
Mówca: **Lucita Azaro**
> ""The rescue crew can still make it in time to save everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[393]`
Mówca: **Hugo Toras**
> ""I believe His Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_ValeroSaved");"*)

### Węzeł `[394]`
Mówca: **Narrator**
> "The councillors fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Player_Romus: ""You've all already heard my decision. We'll call it here.""*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[410]` (*Player_Romus: ""Thank you. Dismissed.""*)
  - -> `[411]` (*Player_Romus: ""Was there anything else?""*)

### Węzeł `[395]`
Mówca: **Sal Ignacius**
> ""I believe His Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales = true;"*)

### Węzeł `[396]`
Mówca: **Laurento Esquibel**
> ""This is the best course of action in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Hugo Toras: ""Our House and Rizian nationalists would have expected us..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Vina Toras: ""I support the decision. This could foster goodwill, desp..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Laurento Esquibel: ""This is the best course of action in my opinion.""*)

### Węzeł `[400]`
Mówca: **Vina Toras**
> ""I support the decision. This could foster goodwill, despite the complexities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Laurento Esquibel: ""I agree with Her Highness, Your Majesty.""*)

### Węzeł `[401]`
Mówca: **Laurento Esquibel**
> ""I agree with Her Highness, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Hugo Toras: ""Our House and Rizian nationalists would have expected us..."*)

### Węzeł `[402]`
Mówca: **Hugo Toras**
> ""Our House and Rizian nationalists would have expected us to use this opportunity, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Hugo Toras: ""I can only hope this doesn't turn into a larger problem.""*)

### Węzeł `[403]`
Mówca: **Hugo Toras**
> ""I can only hope this doesn't turn into a larger problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Sal Ignacius: ""I believe Your Majesty has already made his decision.""*)

### Węzeł `[404]`
Mówca: **Sal Ignacius**
> ""I believe Your Majesty has already made his decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales = true;"*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've all already heard my decision. We'll call it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "The councillors bowed in respect and left the room."*)

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on. I want to hear it. Is there anybody who has the guts to question my decision?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[394]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "There was complete silence."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Player_Romus: ""Hold on. I want to hear it. Is there anybody who has the..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. Dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "The councillors bowed in respect and left the room."*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was there anything else?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Hugo Toras: ""I believe that was all, Your Majesty.""*)

### Węzeł `[412]`
Mówca: **Hugo Toras**
> ""I believe that was all, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "The councillors bowed in respect and left the room."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DeclareWar = true; RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_DeclareWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_RecruitementDrive = true; ..."*)

### Węzeł `[414]`
Mówca: **Narrator**
> "There was complete silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Hugo Toras: ""I believe that was all, Your Majesty.""*)

### Węzeł `[415]`
Mówca: **Narrator**
> "The councillors bowed in respect and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Rizia_Map_Music_Tense");"*)

### Węzeł `[416]`
Mówca: **Hugo Toras**
> ""I didn't expect to hear this, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Hugo Toras: ""But if Your Majesty thinks that time has finally come --..."*)

### Węzeł `[417]`
Mówca: **Hugo Toras**
> ""But if Your Majesty thinks that time has finally come -- so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Elena Werner: ""I have always been a proponent of peace.""*)

### Węzeł `[418]`
Mówca: **Lucita Azaro**
> ""We've all heard the King, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucita Azaro: ""I will signal the general staff immediately.""*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Vina Toras: ""Father? Really?""*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Hugo Toras: ""I didn't expect to hear this, to say the least.""*)

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""Father? Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Hugo Toras: ""I didn't expect to hear this, to say the least.""*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Laurento Esquibel: ""And Princess Vina, Your Majesty? She's still in Pales, a..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Laurento Esquibel: ""Is this not reckless, Your Majesty?""*)

### Węzeł `[426]`
Mówca: **Elena Werner**
> ""I have always been a proponent of peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Elena Werner: ""But in this instance, I cannot ignore the potential econ..."*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm surprised you're not on Mr. Esquibel's side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Elena Werner: ""Why? There is a time for diplomacy, and a time for action.""*)

### Węzeł `[428]`
Mówca: **Laurento Esquibel**
> ""And Princess Vina, Your Majesty? She's still in Pales, and they might try to keep her after what has happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[448]` (*Player_Romus: ""If they do, call their bluff. Duke Reinhart knows better..."*)
  - -> `[429]` (*Player_Romus: ""Request her return immediately. We have to hope they wil..."*)
  - -> `[431]` (*Player_Romus: ""If they indeed try to take her as hostage, we'll burn Pa..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Request her return immediately. We have to hope they will not do anything insane.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Laurento Esquibel: ""Of course, Your Majesty.""*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I sent her there to teach her a lesson. A little time spent as a hostage will only help her learn it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Kontekst wejściowy (poprzednik):** `[428]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "Laurento looked at me in shock."*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they indeed try to take her as hostage, we'll burn Pales to the ground.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Laurento Esquibel: ""Oh...""*)

### Węzeł `[432]`
Mówca: **Laurento Esquibel**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage = true;  RiziaDLCSupport.Reports_Tu..."*)

### Węzeł `[433]`
Mówca: **Lucita Azaro**
> ""I wish it had not come to this. But our military is ready to rise to the challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "The councillors fell silent."*)

### Węzeł `[434]`
Mówca: **Elena Werner**
> ""But in this instance, I cannot ignore the potential economic boom the Aureus field represents...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player_Romus: ""You're speaking my language, Ms. Werner.""*)
  - -> `[451]` (*Player_Romus: ""Precisely. We cannot become an energy superpower without..."*)
  - -> `[452]` (*Player_Romus: ""This has nothing to do with the gas field. It's blood fo..."*)
  - -> `[427]` (*Player_Romus: ""I'm surprised you're not on Mr. Esquibel's side.""*)

### Węzeł `[435]`
Mówca: **Lucita Azaro**
> ""We've all heard the King, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucita Azaro: ""I will signal the general staff immediately.""*)

### Węzeł `[436]`
Mówca: **Lucita Azaro**
> ""I will signal the general staff immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""Thank you, Duchess.""*)
  - -> `[438]` (*Player_Romus: ""Great. I trust you all to begin the preparations.""*)
  - -> `[439]` (*Player_Romus: ""Any other questions or comments?""*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucita Azaro: ""I wish it had not come to this. But our military is read..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. I trust you all to begin the preparations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucita Azaro: ""I wish it had not come to this. But our military is read..."*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any other questions or comments?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "Laurento looked at me but then averted his eyes."*)

### Węzeł `[440]`
Mówca: **Laurento Esquibel**
> ""Is this not reckless, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Laurento Esquibel: ""Have we considered all diplomatic avenues? Are we prepar..."*)

### Węzeł `[441]`
Mówca: **Narrator**
> "Laurento looked at me but then averted his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "The councillors fell silent."*)

### Węzeł `[442]`
Mówca: **Laurento Esquibel**
> ""Have we considered all diplomatic avenues? Are we prepared for the repercussions?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Lucita Azaro: ""We've all heard the King, Mr. Esquibel.""*)

### Węzeł `[443]`
Mówca: **Laurento Esquibel**
> ""Oh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Laurento Esquibel: ""Of course, Your Majesty.""*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage = true; 
RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lucita Azaro: ""We've all heard the King, ladies and gentlemen.""*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player_Romus: ""I sent her there to teach her a lesson. A little time sp..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they do, call their bluff. Duke Reinhart knows better than to mess with the Royal Family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Laurento Esquibel: ""Of course, Your Majesty.""*)

### Węzeł `[449]`
Mówca: **Narrator**
> "Laurento looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Laurento Esquibel: ""Of course, Your Majesty.""*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're speaking my language, Ms. Werner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Laurento Esquibel: ""Elena. I'm disappointed in you.""*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely. We cannot become an energy superpower without making sacrifices.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Laurento Esquibel: ""Elena. I'm disappointed in you.""*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This has nothing to do with the gas field. It's blood for blood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Laurento Esquibel: ""Elena. I'm disappointed in you.""*)

### Węzeł `[453]`
Mówca: **Laurento Esquibel**
> ""Elena. I'm disappointed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "Laurento turned to me for one last appeal."*)

### Węzeł `[454]`
Mówca: **Narrator**
> "Laurento turned to me for one last appeal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[455]`
Mówca: **Elena Werner**
> ""Why? There is a time for diplomacy, and a time for action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "Laurento turned to me for one last appeal."*)

### Węzeł `[456]`
Mówca: **Narrator**
> "Lucita gave him a furious stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Lucita Azaro: ""What are you implying about our intelligence, Mr. Esquib..."*)

### Węzeł `[457]`
Mówca: **Lucita Azaro**
> ""What are you implying about our intelligence, Mr. Esquibel? Or the loyalty of our military officers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "She shook her head."*)

### Węzeł `[458]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""I didn't want to believe this. But could it be that Axel Reinhart never wanted peace with Rizia in the first place? Was the entire sale of the gas field a charade?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Lucita Azaro: ""I didn't want to believe this. But could it be that Axel..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Lucita Azaro: ""I almost don't want to say it, but has Pales been playin..."*)

### Węzeł `[463]`
Mówca: **Lucita Azaro**
> ""I almost don't want to say it, but has Pales been playing the long game this entire time? Was Reinhart's supposed friendliness an act to gain our trust and reclaim territory?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval = true;
RiziaDLCSupport.News_Turn06_G_NavalIncident = true;
RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression = true;
RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests = true;
RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaDemandsWarNaval"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_NavalIncident"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PalesNavalAgression"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_AntiRizianProtests"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucita Azaro: ""Approximately half an hour ago, the ships we sent to enf..."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_G_LandIncident = true;
RiziaDLCSupport.News_Turn06_RH_LandIncident = true;
RiziaDLCSupport.News_Turn06_V_LandIncident = true;
RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_LandIncident"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LandIncident"] = true;
Variable["RiziaDLCSupport.News_Turn06_V_LandIncident"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Terador_PeaceActivistsGather"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""Approximately an hour ago, a violent exchange erupted be..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_WhereIsVina = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_WhereIsVina"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "She pointed at the map showing the border between Rizia a..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_WhereIsVina = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_WhereIsVina"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_VigilForVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "She pointed at the freshly printed report on the table."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront ..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_TankFactory_Completed == true ||..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_TankFactory_Completed == true ||..."*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_TankFactory_Completed == true ..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_TankFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustr..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_TankFactory_Completed == true || RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed == true || RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_TankFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_MilitaryEquipmentFactory_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Order_SupportVehicleFactory_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaMarchesToFront"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_TankFactory_Completed == true ||..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustryOutputIncrease = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_FolceDator_MilitaryIndustryOutputIncrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_RecruitementDrive = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_CommunicationsBlackout = true;
RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar = true;
RiziaDLCSupport.Reports_Turn06_FortAles_CityOnHighAlert = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_RecruitementDrive"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_CommunicationsBlackout"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Montaklar_AzaroRalliesForWar"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_FortAles_CityOnHighAlert"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "The councillors fell silent."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Gridlock", "R_Gridlock_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Gridlock","R_Gridlock_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I was woken up in the middle of the night by the Golden G..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucita Azaro: ""I wish there was another way to put this. The Grand Duch..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_ValeroSaved");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_ValeroSaved");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_KingToTravelToPales = true;"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Receiving late-night news of a military incident at sea", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Receiving late-night news of a military incident at sea","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "// NAVAL INCIDENT HAPPENS"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Receiving late-night news of a military incident at the southern border", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Receiving late-night news of a military incident at the southern border","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "// BORDER INCIDENT HAPPENS - PLAYER DOESNT KNOW"*)
