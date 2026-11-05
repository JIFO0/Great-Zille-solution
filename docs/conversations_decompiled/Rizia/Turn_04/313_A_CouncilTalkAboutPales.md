# Rizia/Turn 4/A_CouncilTalkAboutPales

- **ID konwersacji:** `313`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/313_A_CouncilTalkAboutPales.md`
- **Liczba węzłów dialogowych:** 418
- **Liczba wyborów gracza:** 83

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[80]** Elena Werner
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Resources_Military_NavalBombardmentCapability`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Turn02_Diplomacy_Intention_ATO`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase`
- `RiziaDLC.Enable_Policy_RD_Order_ExpandTeradorAirbase`
- `RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Authority`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed`
- `RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende`
- `RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende1952`
- `RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVanHoorten`
- `RiziaDLCSupport.Codex_Locations_Countries_Agnolia`
- `RiziaDLCSupport.Codex_Locations_Countries_Agnolia_1952`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade`
- `RiziaDLCSupport.Reports_Turn04_NavyDeployed`
- `RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"Don't look at her."** | `[6]` **Narrator**: "I took a seat across from Lucita." | `Variable["RiziaDLC.Relations_Lucita_Romance"] > 1` | *Brak zmian stanu* | `[99]` **Narrator**: "The other councilors busied them..."<br>`[100]` **Narrator**: "My fellow councilors were all po..." |
| `[9]` | **""Yes, please.""** | `[8]` **Hugo Toras**: ""Good morning, Your Majesty. Sho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Laurento Esquibel**: ""I'll take it from here. As you ..." |
| `[10]` | **""I've read the reports. I know about the Palesian drillship.""** | `[8]` **Hugo Toras**: ""Good morning, Your Majesty. Sho..." | *Brak (Dostępna bezwarunkowo)* | `EnableToken("Rizia_Event_Aureus");` | `[105]` **Lucita Azaro**: ""Your Majesty, I have advocated ..." |
| `[12]` | **"Look at her."** | `[6]` **Narrator**: "I took a seat across from Lucita." | `Variable["RiziaDLC.Relations_Lucita_Romance"] > 1` | *Brak zmian stanu* | `[85]` **Narrator**: "She blushed. The other councilor..."<br>`[86]` **Narrator**: "She blushed. The other councilor..." |
| `[17]` | **""Well... why is this a dispute? I thought our maritime borders were clear.""** | `[16]` **Elena Werner**: ""Then where should we start, You..."<br>`[124]` **Hugo Toras**: ""Its strategic location between ..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == false` | *Brak zmian stanu* | `[23]` **Laurento Esquibel**: ""They've been shifting for the p..." |
| `[18]` | **""Do we now know how much gas the field contains?""** | `[16]` **Elena Werner**: ""Then where should we start, You..."<br>`[124]` **Hugo Toras**: ""Its strategic location between ..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == false` | *Brak zmian stanu* | `[20]` **Elena Werner**: ""We still don't have exact numbe..." |
| `[19]` | **""That's enough information. I'm ready to discuss our response.""** | `[16]` **Elena Werner**: ""Then where should we start, You..."<br>`[124]` **Hugo Toras**: ""Its strategic location between ..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == true` | *Brak zmian stanu* | `[44]` **Laurento Esquibel**: ""Very well."" |
| `[28]` | **""So it's clear. Pales is breaking the law by claiming sole ownership.""** | `[26]` **Laurento Esquibel**: ""And in case of overlap, no one ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Laurento Esquibel**: ""Technically, no. Reinhart's pre..." |
| `[31]` | **""Are both Pales and Rizia signatories of this directive?""** | `[26]` **Laurento Esquibel**: ""And in case of overlap, no one ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Laurento Esquibel**: ""Rizia has both signed and ratif..." |
| `[32]` | **""What happens if a country violates that directive?""** | `[26]` **Laurento Esquibel**: ""And in case of overlap, no one ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucita Azaro**: ""They'd be subject to prosecutio..." |
| `[45]` | **""Can't we just split the field 50-50 with Pales. That's what we have a legal claim..."** | `[237]` **Laurento Esquibel**: ""Shall we discuss our diplomatic..."<br>`[238]` **Laurento Esquibel**: ""Perhaps we should at least disc..."<br>*(oraz 11 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == false` | *Brak zmian stanu* | `[49]` **Elena Werner**: ""Yes, that was the outcome I was..." |
| `[46]` | **""What if I were to let Pales keep its claim to the entire field?""** | `[237]` **Laurento Esquibel**: ""Shall we discuss our diplomatic..."<br>`[238]` **Laurento Esquibel**: ""Perhaps we should at least disc..."<br>*(oraz 11 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == false` | *Brak zmian stanu* | `[172]` **Elena Werner**: ""Given Rizia's current natural g..."<br>`[173]` **Elena Werner**: ""Though we do not strictly need ..." |
| `[47]` | **""Does Rizia need the gas from the field?""** | `[16]` **Elena Werner**: ""Then where should we start, You..."<br>`[124]` **Hugo Toras**: ""Its strategic location between ..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == false` | *Brak zmian stanu* | `[133]` **Elena Werner**: ""I'll be blunt, Your Majesty. Ou..."<br>`[139]` **Elena Werner**: ""We are not desperate. For now."" |
| `[80]` | **""I would welcome any other suggestions from my councilors.""** | `[237]` **Laurento Esquibel**: ""Shall we discuss our diplomatic..."<br>`[238]` **Laurento Esquibel**: ""Perhaps we should at least disc..."<br>*(oraz 11 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == true  or Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == true` | *Brak zmian stanu* | `[315]` **Narrator**: "Hugo cleared his throat." |
| `[106]` | **""I completely agree, Lucita. We cannot ignore this obvious provocation.""** | `[105]` **Lucita Azaro**: ""Your Majesty, I have advocated ..." | `Variable["RiziaDLC.Relations_Lucita_Romance"] > 0` | *Brak zmian stanu* | `[112]` **Narrator**: "Hugo cast a sidelong glance at m..." |
| `[110]` | **""I share those concerns, Duchess. The Palesians were out of line to send that ship.""** | `[105]` **Lucita Azaro**: ""Your Majesty, I have advocated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Hugo Toras**: ""A response from Rizia is certai..." |
| `[111]` | **""I still believe that caution is called for. I want to know all the details before..."** | `[105]` **Lucita Azaro**: ""Your Majesty, I have advocated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Hugo Toras**: ""Very wise of you, Your Majesty."" |
| `[113]` | **""I'm sure there is a logical explanation. We shouldn't assume this was an act of a..."** | `[105]` **Lucita Azaro**: ""Your Majesty, I have advocated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Hugo Toras**: ""I agree, Your Majesty. But we c..." |
| `[121]` | **""You're right as usual, Ms. Werner. I want to know everything I can about the disp..."** | `[120]` **Elena Werner**: ""You're getting ahead of yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Elena Werner**: ""Then where should we start, You..." |
| `[122]` | **""I'm all caught up on the details. Let's get to the meat of the matter.""** | `[120]` **Elena Werner**: ""You're getting ahead of yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Elena Werner**: ""Very well."" |
| `[123]` | **""That's fair enough. What are we even using Caleqabiz for, anyway?""** | `[81]` **Laurento Esquibel**: ""The Palesians furthermore state..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Hugo Toras**: ""Its strategic location between ..." |
| `[125]` | **""But that's nonsense, right? It wouldn't hold up in an international court.""** | `[81]` **Laurento Esquibel**: ""The Palesians furthermore state..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Elena Werner**: ""That's debatable, Your Majesty...." |
| `[127]` | **""How dare they disparage our island? They will pay for their impertinence.""** | `[81]` **Laurento Esquibel**: ""The Palesians furthermore state..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[129]` **Hugo Toras**: ""Caleqabiz may be small, but it ..." |
| `[145]` | **""Sounds shady. I wouldn't be surprised if this Gasom was on the verge of bankruptcy.""** | `[143]` **Elena Werner**: ""President Ewald Alphonso was pl..."<br>`[144]` **Elena Werner**: ""Although we rejected Sordland's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Elena Werner**: ""Whatever the state of the compa..." |
| `[146]` | **""Alphonso's slipping in the polls already, eh? I wonder who the next guy will be.""** | `[143]` **Elena Werner**: ""President Ewald Alphonso was pl..."<br>`[144]` **Elena Werner**: ""Although we rejected Sordland's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Elena Werner**: ""It's too early to tell. He coul..." |
| `[147]` | **""That sounds promising nonetheless. Follow up that lead if you can.""** | `[143]` **Elena Werner**: ""President Ewald Alphonso was pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Elena Werner**: ""Yes, I'll keep you posted."" |
| `[148]` | **""Just as well. I've had enough dealings with the Sords.""** | `[143]` **Elena Werner**: ""President Ewald Alphonso was pl..."<br>`[144]` **Elena Werner**: ""Although we rejected Sordland's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Elena Werner**: ""Their gas holdings are quite pr..." |
| `[184]` | **""You will not question Duchess Azaro's ability to do her job.""** | `[185]` **Hugo Toras**: ""You were involved in this, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "Lucita flashed me a grateful smile." |
| `[186]` | **""Duchess, I do hope this surveillance didn't pull too much focus away from the Zil..."** | `[185]` **Hugo Toras**: ""You were involved in this, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "Lucita tried to conceal her indi..." |
| `[189]` | **""Actually, it was my idea.""** | `[185]` **Hugo Toras**: ""You were involved in this, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "Lucita flashed me a grateful smile." |
| `[190]` | **""I believed the same. But she convinced me the Pales situation was worth keeping a..."** | `[185]` **Hugo Toras**: ""You were involved in this, Your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Lucita Azaro**: ""It did, Your Majesty."" |
| `[191]` | **""Actually, I don't understand how this changes anything. We knew Pales and Lespia ..."** | `[197]` **Lucita Azaro**: ""I would humbly ask my fellow co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Lucita Azaro**: ""What this evidence proves is th..." |
| `[193]` | **""I do find it worrying that Lespia is so heavily involved in this expedition.""** | `[197]` **Lucita Azaro**: ""I would humbly ask my fellow co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Lucita Azaro**: ""What this evidence proves is th..." |
| `[199]` | **""Yes, Hugo, don't try to turn me against the Duchess. We're all colleagues here.""** | `[197]` **Lucita Azaro**: ""I would humbly ask my fellow co..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[201]` **Narrator**: "Hugo's expression remained placid." |
| `[211]` | **""There is no compromise where Lespia is involved. They'll steamroll over us at the..."** | `[206]` **Laurento Esquibel**: ""Alternately, we could find a co..."<br>`[210]` **Laurento Esquibel**: ""That isn't necessarily bad for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Elena Werner**: ""You know what Lespian Protectio..." |
| `[215]` | **""I want to leave Lespia out of it. This dispute is between Rizia and Pales.""** | `[206]` **Laurento Esquibel**: ""Alternately, we could find a co..."<br>`[210]` **Laurento Esquibel**: ""That isn't necessarily bad for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Elena Werner**: ""I wish it were that simple, You..." |
| `[216]` | **""But then what happens if Morella and their Valgslandian friends get involved? The..."** | `[206]` **Laurento Esquibel**: ""Alternately, we could find a co..."<br>`[210]` **Laurento Esquibel**: ""That isn't necessarily bad for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Lucita Azaro**: ""And that could lead to the kind..." |
| `[217]` | **""That would be one way to get closer to ATO, yes.""** | `[206]` **Laurento Esquibel**: ""Alternately, we could find a co..."<br>`[210]` **Laurento Esquibel**: ""That isn't necessarily bad for ..." | `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true` | *Brak zmian stanu* | `[220]` **Lucita Azaro**: ""Are we sure that's what we want..." |
| `[224]` | **""He ruined his chances at building on our rapport when he sent that ship.""** | `[39]` **Laurento Esquibel**: ""You established a rapport with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Laurento Esquibel**: ""The ship has not started drilli..." |
| `[225]` | **""He ruined his chances at reaching an understanding when he sent that ship.""** | `[43]` **Laurento Esquibel**: ""I know you and Duke Reinhart do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Laurento Esquibel**: ""The ship has not started drilli..." |
| `[226]` | **""I don't want to come to an understanding. I want to crush his Grand Duchy to smit..."** | `[43]` **Laurento Esquibel**: ""I know you and Duke Reinhart do..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[234]` **Narrator**: "Laurento blanched." |
| `[228]` | **""For your sake, Mr. Esquibel, I will try to be diplomatic.""** | `[43]` **Laurento Esquibel**: ""I know you and Duke Reinhart do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Laurento Esquibel**: ""You know how much I respected y..." |
| `[229]` | **""I have no idea whether his intentions were sincere. He might still harbor a grudg..."** | `[39]` **Laurento Esquibel**: ""You established a rapport with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Laurento Esquibel**: ""The only way to find out is to ..." |
| `[230]` | **""That will be hard with Lespia looking over his shoulder. But I will try to be dip..."** | `[39]` **Laurento Esquibel**: ""You established a rapport with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Laurento Esquibel**: ""You know how much I respected y..." |
| `[231]` | **""You're right. If we meet in person, I'm sure I'll be able to get him to back down.""** | `[39]` **Laurento Esquibel**: ""You established a rapport with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Laurento Esquibel**: ""I am sure of it as well."" |
| `[239]` | **""We don't need a third party. We can settle this between ourselves.""** | `[50]` **Elena Werner**: ""But it seems that without the a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Laurento Esquibel**: ""If you can't, though, the Allia..." |
| `[240]` | **""Do you mean asking the Alliance of Nations to arbitrate the dispute?""** | `[50]` **Elena Werner**: ""But it seems that without the a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Laurento Esquibel**: ""Correct, Your Majesty. AN arbit..." |
| `[245]` | **""You're right, Hugo. First Pales, then Zille, then this? We must preserve what's l..."** | `[244]` **Hugo Toras**: ""I am certain that if we give up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Lucita Azaro**: ""If we do cede the field, it mus..." |
| `[247]` | **""On the other hand, won't fighting for our rightful part of the field take up reso..."** | `[244]` **Hugo Toras**: ""I am certain that if we give up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Elena Werner**: ""You do have a point there, Your..." |
| `[248]` | **""What if we're actually wrong about having a claim to the field? Ceding it to Pale..."** | `[244]` **Hugo Toras**: ""I am certain that if we give up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Elena Werner**: ""The value of the gas in the fie..." |
| `[254]` | **""A third party... like the Rizian military?""** | `[50]` **Elena Werner**: ""But it seems that without the a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Laurento Esquibel**: ""I believe Ms. Werner was referr..." |
| `[258]` | **""I don't like the idea any more than you do, Hugo. But my father taught me that so..."** | `[244]` **Hugo Toras**: ""I am certain that if we give up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Hugo Toras**: ""Up to a point, Your Majesty. Wh..." |
| `[260]` | **""We have Rumburg on our side. I'm sure Queen Beatrice would support us through the..."** | `[255]` **Laurento Esquibel**: ""With that said, it's definitely..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Laurento Esquibel**: ""The weight of GRACE versus that..." |
| `[261]` | **""It does sound like the law is on our side. Maybe this is the easiest way forward.""** | `[255]` **Laurento Esquibel**: ""With that said, it's definitely..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Elena Werner**: ""On the other hand, if the AN do..." |
| `[262]` | **""We don't have time to spare. I want that gas *now*.""** | `[255]` **Laurento Esquibel**: ""With that said, it's definitely..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Elena Werner**: ""Even if we were granted part of..." |
| `[263]` | **""No, the AN will muddle everything up with its bureaucracy. I want to talk to the ..."** | `[255]` **Laurento Esquibel**: ""With that said, it's definitely..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Laurento Esquibel**: ""I would encourage you to try, Y..." |
| `[275]` | **""Is there a way we can claim the entire field for Rizia?""** | `[237]` **Laurento Esquibel**: ""Shall we discuss our diplomatic..."<br>`[238]` **Laurento Esquibel**: ""Perhaps we should at least disc..."<br>*(oraz 11 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == false` | *Brak zmian stanu* | `[276]` **Laurento Esquibel**: ""Not without major diplomatic re..." |
| `[279]` | **""That would make our gas extraction dependent on their conditions. No, thanks.""** | `[278]` **Elena Werner**: ""The only way for Rizian Oil and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Lucita Azaro**: ""Agreed, Your Majesty. And don't..."<br>`[311]` **Lucita Azaro**: ""Agreed, Your Majesty. And don't..." |
| `[280]` | **""Sounds costlier than I envisioned, but we would certainly reap the rewards. Why d..."** | `[278]` **Elena Werner**: ""The only way for Rizian Oil and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Lucita Azaro**: ""We could, but we have to rememb..."<br>`[286]` **Lucita Azaro**: ""We could, but we have to consid..." |
| `[281]` | **""Or reconquer Pales. Right, Duchess Azaro?""** | `[278]` **Elena Werner**: ""The only way for Rizian Oil and..." | `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true` | *Brak zmian stanu* | `[295]` **Narrator**: "I saw a hint of a smile on Lucit..."<br>`[301]` **Narrator**: "Lucita shook her head." |
| `[318]` | **""I don't like the idea of it being present in the gas field during our negotiation..."** | `[317]` **Hugo Toras**: ""We have still not decided what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Lucita Azaro**: ""I do, Your Majesty. But my fell..." |
| `[319]` | **""We shouldn't immediately interpret the ship as a provocation. This could all be a..."** | `[317]` **Hugo Toras**: ""We have still not decided what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Hugo Toras**: ""Respectfully, Your Majesty, the..." |
| `[320]` | **""We have to do *something*, obviously. The Palesians must not be allowed to get aw..."** | `[317]` **Hugo Toras**: ""We have still not decided what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Lucita Azaro**: ""I have one idea, Your Majesty. ..." |
| `[327]` | **""'Young lady'? I know you come from a different generation, Mr. Esquibel, but that..."** | `[271]` **Laurento Esquibel**: ""Are you in your right mind, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Laurento Esquibel**: ""Excuse me, Your Majesty. But on..." |
| `[329]` | **""I second that. A military response could have disastrous consequences.""** | `[271]` **Laurento Esquibel**: ""Are you in your right mind, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Laurento Esquibel**: ""Tensions with Pales are high en..."<br>`[336]` **Laurento Esquibel**: ""We were on the verge of reconci..." |
| `[330]` | **""It's not an outlandish suggestion. We've already established that Pales is violat..."** | `[271]` **Laurento Esquibel**: ""Are you in your right mind, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Laurento Esquibel**: ""Tensions with Pales are high en..."<br>`[336]` **Laurento Esquibel**: ""We were on the verge of reconci..." |
| `[343]` | **""That settles it, then. I want us to have a fighting chance to claim our rightful ..."** | `[342]` **Elena Werner**: ""If we do end up in arbitration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Hugo Toras**: ""I agree that asserting Rizian s..." |
| `[345]` | **""Even so, the risk of escalation is too high. It doesn't seem worth it.""** | `[342]` **Elena Werner**: ""If we do end up in arbitration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Laurento Esquibel**: ""Precisely, Your Majesty."" |
| `[350]` | **""I am hesitant to interfere. What if ATO retaliates?""** | `[342]` **Elena Werner**: ""If we do end up in arbitration ..." | `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true` | *Brak zmian stanu* | `[351]` **Lucita Azaro**: ""There may be LesPower executive..." |
| `[352]` | **""Pales and Lespia are literally testing the waters with us. If we let them reach t..."** | `[342]` **Elena Werner**: ""If we do end up in arbitration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Hugo Toras**: ""I agree that asserting Rizian s..." |
| `[367]` | **""I understand the implications. But I fear we have no other choice. We will instit..."** | `[365]` **Lucita Azaro**: ""Still, this is not a decision t..."<br>`[366]` **Lucita Azaro**: ""This is not a decision to take ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...` | `[377]` **Narrator**: "Lucita nodded." |
| `[368]` | **""I agree. And I think we should exercise caution. I will meet with Duke Reinhart b..."** | `[365]` **Lucita Azaro**: ""Still, this is not a decision t..."<br>`[366]` **Lucita Azaro**: ""This is not a decision to take ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Narrator**: "Laurento nodded, relieved." |
| `[369]` | **""I see through your manipulations, Duchess Azaro, and I will not give in. We will ..."** | `[365]` **Lucita Azaro**: ""Still, this is not a decision t..."<br>`[366]` **Lucita Azaro**: ""This is not a decision to take ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Lucita Azaro**: ""Manipulations?! I--"" |
| `[370]` | **""I do not take Duke Reinhart's violation of the law lightly, either. Our navy will..."** | `[365]` **Lucita Azaro**: ""Still, this is not a decision t..."<br>`[366]` **Lucita Azaro**: ""This is not a decision to take ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillshi...` | `[381]` **Narrator**: "Lucita nodded. Laurento and Elen..." |
| `[390]` | **""I hope I don't regret following your advice, Mr. Esquibel.""** | `[389]` **Hugo Toras**: ""I'll adjourn the meeting so Mr...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Laurento Esquibel**: ""I am certain you would have reg..." |
| `[391]` | **""Thank you all for your time.""** | `[389]` **Hugo Toras**: ""I'll adjourn the meeting so Mr...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "The meeting drew to a close." |
| `[392]` | **""I fully expect a peaceful resolution.""** | `[389]` **Hugo Toras**: ""I'll adjourn the meeting so Mr...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Lucita Azaro**: ""Good luck, Your Majesty. I mean..." |
| `[393]` | **""I hope there are no more unpleasant surprises.""** | `[389]` **Hugo Toras**: ""I'll adjourn the meeting so Mr...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Hugo Toras**: ""We'll see to it that there aren..." |
| `[397]` | **""I fully expect a peaceful resolution. This is just a precaution.""** | `[385]` **Hugo Toras**: ""I'll adjourn the meeting so Duc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Laurento Esquibel**: ""No need to justify it, Your Maj..." |
| `[398]` | **""I wish I could see the look on Reinhart's face when he finds out about this.""** | `[385]` **Hugo Toras**: ""I'll adjourn the meeting so Duc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Laurento Esquibel**: ""You'll see him very soon, Your ..." |
| `[399]` | **""Thank you for the suggestion, Duchess. I knew you could be counted on.""** | `[385]` **Hugo Toras**: ""I'll adjourn the meeting so Duc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Narrator**: "She bowed her head modestly." |
| `[404]` | **""Thank you all for your time.""** | `[385]` **Hugo Toras**: ""I'll adjourn the meeting so Duc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Narrator**: "The meeting drew to a close." |
| `[410]` | **""They are the ones who are escalating. We cannot simply stay idle. We need a stron..."** | `[271]` **Laurento Esquibel**: ""Are you in your right mind, you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Laurento Esquibel**: ""Tensions with Pales are high en..."<br>`[336]` **Laurento Esquibel**: ""We were on the verge of reconci..." |

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
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Managing the resource conflict with the ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had called a council meeting in Fort Ales to discuss our strategy in the Pales gas dispute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The city was named after its most famous building, a Valg..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The city was named after its most famous building, a Valgish fortress that now served as the government headquarters for the Pales Administrative District."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel"); AddConversant("Elena ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Titus escorted me down the hallway to a nondescript conference room, where Laurento, Lucita, Elena and Hugo were already waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I took a seat across from Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance > 1"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Don't look at her."]** — Mówca: **Player_Romus_Italic**
> "I looked around the room."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 1`
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Good morning, Your Majesty. Should we fill you in on the situation so far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""Yes, please.""*)
  - -> `[10]` (*Player_Romus: ""I've read the reports. I know about the Palesian drillsh..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Laurento Esquibel: ""I'll take it from here. As you know, our joint team of r..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've read the reports. I know about the Palesian drillship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "EnableToken("Rizia_Event_Aureus");"*)

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""Duke Reinhart is now under the impression that the entire gas field belongs to Pales. He has ordered that exploratory drilling begin immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Lucita had a worried look on her face."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Look at her."]** — Mówca: **Player_Romus_Italic**
> "We made eye contact for a brief moment."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 1`
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)

### Węzeł `[13]`
Mówca: **Laurento Esquibel**
> ""I'll take it from here. As you know, our joint team of researchers recently completed their assessment of the gas field between Pales and Rizia -- tentatively nicknamed Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Laurento Esquibel: ""The Rizian surveyors determined that the field lay in bo..."*)

### Węzeł `[14]`
Mówca: **Elena Werner**
> ""However, a few days after our team's return to port, we received the news that the Palesians had made a different decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Laurento Esquibel: ""Duke Reinhart is now under the impression that the entir..."*)

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""The Rizian surveyors determined that the field lay in both Rizian and Palesian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Elena Werner: ""However, a few days after our team's return to port, we ..."*)

### Węzeł `[16]`
Mówca: **Elena Werner**
> ""Then where should we start, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "Gas Dispute Question Hub"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... why is this a dispute? I thought our maritime borders were clear.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Elena Werner), `[124]` (Hugo Toras), `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Laurento Esquibel: ""They've been shifting for the past century.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do we now know how much gas the field contains?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Elena Werner), `[124]` (Hugo Toras), `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Elena Werner: ""We still don't have exact numbers. But the surveyors hav..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's enough information. I'm ready to discuss our response.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Elena Werner), `[124]` (Hugo Toras), `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Laurento Esquibel: ""Very well.""*)

### Węzeł `[20]`
Mówca: **Elena Werner**
> ""We still don't have exact numbers. But the surveyors have confirmed that it's a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Elena Werner: ""Quite possibly more than the current natural gas reserve..."*)

### Węzeł `[21]`
Mówca: **Elena Werner**
> ""Quite possibly more than the current natural gas reserves of Rizia and Pales combined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucita Azaro: ""In other words, whichever country controls the Aureus fi..."*)

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""In other words, whichever country controls the Aureus field will become Merkopa's next energy superpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize = true"*)

### Węzeł `[23]`
Mówca: **Laurento Esquibel**
> ""They've been shifting for the past century.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Laurento Esquibel: ""The late Empire of Valgos used to control the waters bet..."*)

### Węzeł `[24]`
Mówca: **Laurento Esquibel**
> ""The late Empire of Valgos used to control the waters between Pales and Caleqabiz. But the area came into question when the island joined Rizia in 1855.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Laurento Esquibel: ""Since then, both Rizia and Pales have variously claimed ..."*)

### Węzeł `[25]`
Mówca: **Elena Werner**
> ""Ah, yes. ANDOR.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Elena Werner: ""A nation has the sovereign right to any undersea gas and..."*)

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""And in case of overlap, no one country may exploit those resources without the other's agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""So it's clear. Pales is breaking the law by claiming sol..."*)
  - -> `[31]` (*Player_Romus: ""Are both Pales and Rizia signatories of this directive?""*)
  - -> `[32]` (*Player_Romus: ""What happens if a country violates that directive?""*)

### Węzeł `[27]`
Mówca: **Elena Werner**
> ""A nation has the sovereign right to any undersea gas and oil wells located within 200 kilometers of its coast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Laurento Esquibel: ""And in case of overlap, no one country may exploit those..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So it's clear. Pales is breaking the law by claiming sole ownership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Laurento Esquibel: ""Technically, no. Reinhart's predecessor signed ANDOR, bu..."*)

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""The borders that Rizia recognizes today are the ones defined by the 1942 AN Directive on Offshore Resources. According to those, the field should be split almost exactly evenly between our two nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Elena Werner: ""Ah, yes. ANDOR.""*)

### Węzeł `[30]`
Mówca: **Laurento Esquibel**
> ""Technically, no. Reinhart's predecessor signed ANDOR, but the Duke has yet to ratify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Laurento Esquibel: ""The Palesians furthermore state that as a sparsely popul..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are both Pales and Rizia signatories of this directive?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Laurento Esquibel: ""Rizia has both signed and ratified ANDOR. Reinhart's pre..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happens if a country violates that directive?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucita Azaro: ""They'd be subject to prosecution in an international cou..."*)

### Węzeł `[33]`
Mówca: **Laurento Esquibel**
> ""Rizia has both signed and ratified ANDOR. Reinhart's predecessor signed the directive, but the Duke has yet to ratify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Laurento Esquibel: ""The Palesians furthermore state that as a sparsely popul..."*)

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""They'd be subject to prosecution in an international court. And any military action against them would be fully justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Laurento Esquibel: ""Technically, Pales wouldn't be violating ANDOR by drilli..."*)

### Węzeł `[35]`
Mówca: **Laurento Esquibel**
> ""Technically, Pales wouldn't be violating ANDOR by drilling without Rizia's consent. Reinhart's predecessor signed the directive, but the Duke has yet to ratify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Laurento Esquibel: ""The Palesians furthermore state that as a sparsely popul..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Gas Dispute Question Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == ..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == ..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Gas Dispute Question Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "Gas Dispute Question Hub"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Gas Dispute Question Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "Gas Dispute Question Hub"*)

### Węzeł `[39]`
Mówca: **Laurento Esquibel**
> ""You established a rapport with Duke Reinhart prior to your coronation. Perhaps there's a way to build on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""He ruined his chances at building on our rapport when he..."*)
  - -> `[231]` (*Player_Romus: ""You're right. If we meet in person, I'm sure I'll be abl..."*)
  - -> `[229]` (*Player_Romus: ""I have no idea whether his intentions were sincere. He m..."*)
  - -> `[230]` (*Player_Romus: ""That will be hard with Lespia looking over his shoulder...."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FriendlyToPales == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Laurento Esquibel: ""You established a rapport with Duke Reinhart prior to yo..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FriendlyToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Laurento Esquibel: ""I know you and Duke Reinhart don't have much of a rappor..."*)

### Węzeł `[43]`
Mówca: **Laurento Esquibel**
> ""I know you and Duke Reinhart don't have much of a rapport. But it might not be too late to come to an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""For your sake, Mr. Esquibel, I will try to be diplomatic.""*)
  - -> `[226]` (*Player_Romus: ""I don't want to come to an understanding. I want to crus..."*)
  - -> `[225]` (*Player_Romus: ""He ruined his chances at reaching an understanding when ..."*)

### Węzeł `[44]`
Mówca: **Laurento Esquibel**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we just split the field 50-50 with Pales. That's what we have a legal claim to, isn't it?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == false`
- **Kontekst wejściowy (poprzednik):** `[237]` (Laurento Esquibel), `[238]` (Laurento Esquibel), `[265]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Elena Werner: ""Yes, that was the outcome I was hoping for before this i..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I were to let Pales keep its claim to the entire field?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == false`
- **Kontekst wejściowy (poprzednik):** `[237]` (Laurento Esquibel), `[238]` (Laurento Esquibel), `[265]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= 1"*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Does Rizia need the gas from the field?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Elena Werner), `[124]` (Hugo Toras), `[126]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= 1"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Gas Dispute Question Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "Gas Dispute Question Hub"*)

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""Yes, that was the outcome I was hoping for before this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Elena Werner: ""But it seems that without the aid of a third party, shar..."*)

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""But it seems that without the aid of a third party, sharing the field will be more difficult than expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Romus: ""We don't need a third party. We can settle this between ..."*)
  - -> `[240]` (*Player_Romus: ""Do you mean asking the Alliance of Nations to arbitrate ..."*)
  - -> `[254]` (*Player_Romus: ""A third party... like the Rizian military?""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Pales Diplomacy Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share =..."*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede ==..."*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Pales Diplomacy Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales Diplomacy Hub"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "The meeting drew to a close."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "I spent a sleepless night in Fort Ales, wondering what wo..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "I spent a sleepless night in Fort Ales, wondering what would happen when the ship from Pales got to its destination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase =..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == ..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""Well... why is this a dispute? I thought our maritime bo..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == ..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize =..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""Do we now know how much gas the field contains?""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == ..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed =..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""Does Rizia need the gas from the field?""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == ..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed =..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""That's enough information. I'm ready to discuss our resp..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gas Dispute Question Hub]"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gas Dispute Question Hub]"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gas Dispute Question Hub]"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share =..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""Can't we just split the field 50-50 with Pales. That's w..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede ==..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede ..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""What if I were to let Pales keep its claim to the entire..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales Diplomacy Hub]"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == true || RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == true ||RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Claim..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == true || RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == true ||RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == true  or Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""I would welcome any other suggestions from my councilors.""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == true || RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == true ||RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == true  or Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would welcome any other suggestions from my councilors.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == true  or Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == true`
- **Kontekst wejściowy (poprzednik):** `[237]` (Laurento Esquibel), `[238]` (Laurento Esquibel), `[265]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Hugo cleared his throat."*)

### Węzeł `[81]`
Mówca: **Laurento Esquibel**
> ""The Palesians furthermore state that as a sparsely populated island, Caleqabiz should not have the same maritime radius as mainland Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""That's fair enough. What are we even using Caleqabiz for..."*)
  - -> `[125]` (*Player_Romus: ""But that's nonsense, right? It wouldn't hold up in an in..."*)
  - -> `[127]` (*Player_Romus: ""How dare they disparage our island? They will pay for th..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_CompromisingPhoto == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "She blushed. The other councilors studiously trained thei..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_CompromisingPhoto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "She blushed. The other councilors didn't seem to notice."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "She blushed. The other councilors studiously trained their eyes away from us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Good morning, Your Majesty. Should we fill you in on the..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "She blushed. The other councilors didn't seem to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Good morning, Your Majesty. Should we fill you in on the..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");

// Adds the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Titus escorted me down the hallway to a nondescript confe..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "My daughter had requested to stay home this time around, ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I took a seat across from Lucita."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "My daughter had requested to stay home this time around, claiming she was feeling unwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I took a seat across from Lucita."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_NavyDeployed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_NavyDeployed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase =..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance > 1"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Romance > 1)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus_Italic: "Look at her."*)
  - -> `[7]` (*Player_Romus_Italic: "Don't look at her."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Romance > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "My fellow councilors were all poring over various documen..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_CompromisingPhoto == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_CompromisingPhoto == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_CompromisingPhoto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "The other councilors busied themselves with the documents..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_CompromisingPhoto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "My fellow councilors were all poring over various documen..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The other councilors busied themselves with the documents they were holding. Hugo finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Good morning, Your Majesty. Should we fill you in on the..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "My fellow councilors were all poring over various documents. Hugo finally stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Good morning, Your Majesty. Should we fill you in on the..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked = ..."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Lucita had a worried look on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucita Azaro: ""A Palesian drillship departed the port of Remaz at 0800 ..."*)

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""A Palesian drillship departed the port of Remaz at 0800 this morning. It is expected to reach the field by this time tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "EnableToken("Rizia_Event_Aureus");"*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""Your Majesty, I have advocated for caution regarding Pales in the past. But this strikes me as highly concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance > 0"*)
  - -> `[110]` (*Player_Romus: ""I share those concerns, Duchess. The Palesians were out ..."*)
  - -> `[111]` (*Player_Romus: ""I still believe that caution is called for. I want to kn..."*)
  - -> `[113]` (*Player_Romus: ""I'm sure there is a logical explanation. We shouldn't as..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I completely agree, Lucita. We cannot ignore this obvious provocation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 0`
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Hugo cast a sidelong glance at my use of Lucita's first n..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance > 0"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Romance > 0)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: ""I completely agree, Lucita. We cannot ignore this obviou..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Romance > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I share those concerns, Duchess. The Palesians were out of line to send that ship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Hugo Toras: ""A response from Rizia is certainly warranted. I called t..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still believe that caution is called for. I want to know all the details before we decide on our reaction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Hugo Toras: ""Very wise of you, Your Majesty.""*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Hugo cast a sidelong glance at my use of Lucita's first name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""Provocation or not, it indeed mustn't be ignored. I call..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure there is a logical explanation. We shouldn't assume this was an act of aggression.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hugo Toras: ""I agree, Your Majesty. But we cannot let the act go unre..."*)

### Węzeł `[114]`
Mówca: **Hugo Toras**
> ""A response from Rizia is certainly warranted. I called this meeting today to decide on our course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""We have a meeting set with Duke Reinhart in two days. By..."*)

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""Very wise of you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""We have a meeting set with Duke Reinhart in two days. By..."*)

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""I agree, Your Majesty. But we cannot let the act go unremarked upon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""We have a meeting set with Duke Reinhart in two days. By..."*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""Provocation or not, it indeed mustn't be ignored. I called this meeting today to decide our course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""We have a meeting set with Duke Reinhart in two days. By..."*)

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""We have a meeting set with Duke Reinhart in two days. By which time the ship will have reached its destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Laurento Esquibel: ""It is my hope that the Palesians are still open to negot..."*)

### Węzeł `[119]`
Mówca: **Laurento Esquibel**
> ""It is my hope that the Palesians are still open to negotiating the field's ownership, and that this is just a tactic to give them an edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Elena Werner: ""You're getting ahead of yourself, Laurento. The King sho..."*)

### Węzeł `[120]`
Mówca: **Elena Werner**
> ""You're getting ahead of yourself, Laurento. The King should be as informed about this dispute as possible before heading to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""You're right as usual, Ms. Werner. I want to know everyt..."*)
  - -> `[122]` (*Player_Romus: ""I'm all caught up on the details. Let's get to the meat ..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right as usual, Ms. Werner. I want to know everything I can about the disputed field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Elena Werner: ""Then where should we start, Your Majesty?""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm all caught up on the details. Let's get to the meat of the matter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Elena Werner: ""Very well.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fair enough. What are we even using Caleqabiz for, anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""Its strategic location between mainland Merkopa and Kyru..."*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Its strategic location between mainland Merkopa and Kyrute makes it a very useful port and naval base. And we should not forget about the presence of the exiled ex-Duchess Angelica Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders = true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But that's nonsense, right? It wouldn't hold up in an international court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Elena Werner: ""That's debatable, Your Majesty. With enough legal firepo..."*)

### Węzeł `[126]`
Mówca: **Elena Werner**
> ""That's debatable, Your Majesty. With enough legal firepower and international support, Pales could have a case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders = true"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare they disparage our island? They will pay for their impertinence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Hugo Toras: ""Caleqabiz may be small, but it holds large strategic imp..."*)

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""Caleqabiz may be small, but it holds large strategic importance. It is unfair to call it a lesser part of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders = true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= 1"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal <= 1)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Elena Werner: ""I'll be blunt, Your Majesty. Our existing gas reserves a..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Elena Werner: ""We are not desperate. For now.""*)

### Węzeł `[133]`
Mówca: **Elena Werner**
> ""I'll be blunt, Your Majesty. Our existing gas reserves are dwindling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)

### Węzeł `[134]`
Mówca: **Elena Werner**
> ""The Esqiris field off of Valenqiris is on the verge of shutting down if we do not invest in its expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Pro..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Elena Werner: ""Our expansion of the Esqiris field will increase gas pro..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Elena Werner: ""The Esqiris field off of Valenqiris is on the verge of s..."*)

### Węzeł `[138]`
Mówca: **Elena Werner**
> ""Our expansion of the Esqiris field will increase gas production, though access to even half of Aureus would yield better results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[139]`
Mówca: **Elena Werner**
> ""We are not desperate. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true || RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true || RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true  or  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Elena Werner: ""President Ewald Alphonso was pleased enough with our tra..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true || RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true  or  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Elena Werner: ""Although we rejected Sordland's trade deal, President Al..."*)

### Węzeł `[143]`
Mówca: **Elena Werner**
> ""President Ewald Alphonso was pleased enough with our trade deal that he has hinted at offering us a stake in his own gas company, Gasom. But next year's Sordish elections may jeopardize that offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""That sounds promising nonetheless. Follow up that lead i..."*)
  - -> `[148]` (*Player_Romus: ""Just as well. I've had enough dealings with the Sords.""*)
  - -> `[146]` (*Player_Romus: ""Alphonso's slipping in the polls already, eh? I wonder w..."*)
  - -> `[145]` (*Player_Romus: ""Sounds shady. I wouldn't be surprised if this Gasom was ..."*)

### Węzeł `[144]`
Mówca: **Elena Werner**
> ""Although we rejected Sordland's trade deal, President Alphonso has hinted at an opportunity to invest in his own gas company, Gasom, through back channels. But next year's Sordish elections may jeopardize that offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""Just as well. I've had enough dealings with the Sords.""*)
  - -> `[146]` (*Player_Romus: ""Alphonso's slipping in the polls already, eh? I wonder w..."*)
  - -> `[145]` (*Player_Romus: ""Sounds shady. I wouldn't be surprised if this Gasom was ..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds shady. I wouldn't be surprised if this Gasom was on the verge of bankruptcy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner), `[144]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Elena Werner: ""Whatever the state of the company, there's no denying th..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alphonso's slipping in the polls already, eh? I wonder who the next guy will be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner), `[144]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Elena Werner: ""It's too early to tell. He could still pull off a win.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds promising nonetheless. Follow up that lead if you can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Elena Werner: ""Yes, I'll keep you posted.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just as well. I've had enough dealings with the Sords.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Elena Werner), `[144]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Elena Werner: ""Their gas holdings are quite prodigious. I wouldn't writ..."*)

### Węzeł `[149]`
Mówca: **Elena Werner**
> ""Their gas holdings are quite prodigious. I wouldn't write them off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 3"*)

### Węzeł `[150]`
Mówca: **Elena Werner**
> ""It's too early to tell. He could still pull off a win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 3"*)

### Węzeł `[151]`
Mówca: **Elena Werner**
> ""Whatever the state of the company, there's no denying that Sordland has prodigious gas holdings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 3"*)

### Węzeł `[152]`
Mówca: **Elena Werner**
> ""Yes, I'll keep you posted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 3"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 3"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 3)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Elena Werner: ""Outside of gas, our overall energy reserves are healthy.""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Elena Werner: ""Sordish or otherwise, we could really use the gas to bol..."*)

### Węzeł `[156]`
Mówca: **Elena Werner**
> ""Outside of gas, our overall energy reserves are healthy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[157]`
Mówca: **Elena Werner**
> ""Sordish or otherwise, we could really use the gas to bolster our overall energy reserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Elena Werner: ""And we can't forget about the contract we signed with Ru..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Elena Werner: ""But we don't know what the future might bring.""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Elena Werner: ""And we can't forget about the contract we signed with Ru..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Elena Werner: ""We're running low as it is, and we don't know what the f..."*)

### Węzeł `[164]`
Mówca: **Elena Werner**
> ""And we can't forget about the contract we signed with Rumburg. We are exporting and making good on our energy obligations already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed = true"*)

### Węzeł `[165]`
Mówca: **Elena Werner**
> ""But we don't know what the future might bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed = true"*)

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""We're running low as it is, and we don't know what the future might bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed = true"*)

### Węzeł `[167]`
Mówca: **Elena Werner**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps"*)

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""Actually, I have some additional information that could influence our response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Hugo Toras: ""By all means, Duchess Azaro, go on.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= 1"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal <= 1)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Elena Werner: ""Given Rizia's current natural gas needs, we should not r..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Elena Werner: ""Though we do not strictly need the gas from the field, w..."*)

### Węzeł `[172]`
Mówca: **Elena Werner**
> ""Given Rizia's current natural gas needs, we should not relinquish our claim on the field without seriously considering the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Laurento Esquibel: ""Don't forget, Ms. Werner. What we would lose from ceding..."*)

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""Though we do not strictly need the gas from the field, we should not relinquish it without seriously considering the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Laurento Esquibel: ""Don't forget, Ms. Werner. What we would lose from ceding..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_Pales_SendSpecialOps)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Lucita raised a hand."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_Pales_SendSpecialOps)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Lucita raised a hand."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Lucita raised a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucita Azaro: ""Actually, I have some additional information that could ..."*)

### Węzeł `[178]`
Mówca: **Hugo Toras**
> ""By all means, Duchess Azaro, go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "She took out a photograph. It showed a number of men in b..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "She took out a photograph. It showed a number of men in business suits boarding a large vessel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucita Azaro: ""Our intelligence in Pales managed to get a visual on the..."*)

### Węzeł `[180]`
Mówca: **Lucita Azaro**
> ""Our intelligence in Pales managed to get a visual on the boat before it departed. This man here is a representative from LesPower, the Lespian energy corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Hugo stared at her coldly."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Hugo stared at her coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""I was not informed that we had active intelligence opera..."*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""I was not informed that we had active intelligence operating in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucita Azaro: ""His Majesty and I made the decision to establish it.""*)

### Węzeł `[183]`
Mówca: **Lucita Azaro**
> ""His Majesty and I made the decision to establish it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Hugo Toras: ""You were involved in this, Your Majesty? I thought the W..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not question Duchess Azaro's ability to do her job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Lucita flashed me a grateful smile."*)

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""You were involved in this, Your Majesty? I thought the Wehlen investigation took full precedence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""You will not question Duchess Azaro's ability to do her ..."*)
  - -> `[189]` (*Player_Romus: ""Actually, it was my idea.""*)
  - -> `[190]` (*Player_Romus: ""I believed the same. But she convinced me the Pales situ..."*)
  - -> `[186]` (*Player_Romus: ""Duchess, I do hope this surveillance didn't pull too muc..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess, I do hope this surveillance didn't pull too much focus away from the Zille investigation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Lucita tried to conceal her indignance."*)

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""It did not, Your Majesty. I'll remind you that my department has been almost completely uninvolved in the Zille bombing fallout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucita Azaro: ""I would humbly ask my fellow councilors to focus on the ..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Lucita tried to conceal her indignance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, it was my idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Lucita flashed me a grateful smile."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believed the same. But she convinced me the Pales situation was worth keeping an eye on, and that turned out to be the case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucita Azaro: ""It did, Your Majesty.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I don't understand how this changes anything. We knew Pales and Lespia were in cahoots.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""What this evidence proves is that it's not Pales alone a..."*)

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""What this evidence proves is that it's not Pales alone asserting its claim to the field. Lespia, and by extension ATO, is after that gas and all the money and power that comes with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Laurento Esquibel: ""This photo sends a different message to me. Could it be ..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do find it worrying that Lespia is so heavily involved in this expedition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""What this evidence proves is that it's not Pales alone a..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Lucita flashed me a grateful smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucita Azaro: ""I would humbly ask my fellow councilors to focus on the ..."*)

### Węzeł `[195]`
Mówca: **Lucita Azaro**
> ""It did, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucita Azaro: ""I would humbly ask my fellow councilors to focus on the ..."*)

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""This photo sends a different message to me. Could it be possible that Lespia pressured Pales into claiming the field and sending the ship? And if so, can we use that fact to drive a wedge between the two?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Laurento Esquibel: ""Alternately, we could find a compromise that involves al..."*)

### Węzeł `[197]`
Mówca: **Lucita Azaro**
> ""I would humbly ask my fellow councilors to focus on the content of these findings, not the methods used to obtain them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""Yes, Hugo, don't try to turn me against the Duchess. We'..."*)
  - -> `[191]` (*Player_Romus: ""Actually, I don't understand how this changes anything. ..."*)
  - -> `[193]` (*Player_Romus: ""I do find it worrying that Lespia is so heavily involved..."*)

### Węzeł `[198]`
Mówca: **Hugo Toras**
> ""Forgive me, both of you. The last thing we need in this council is discord. And Duchess Azaro's findings are concerning to me as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucita Azaro: ""What this evidence proves is that it's not Pales alone a..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, don't try to turn me against the Duchess. We're all colleagues here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Hugo's expression remained placid."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Hugo's expression remained placid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Hugo Toras: ""Forgive me, both of you. The last thing we need in this ..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucita Azaro: ""It did not, Your Majesty. I'll remind you that my depart..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lucita Azaro: ""It did not, Your Majesty. If anything, our forces in Weh..."*)

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""It did not, Your Majesty. If anything, our forces in Wehlen have doubled down on their efforts as the Zille handover deadline approaches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucita Azaro: ""I would humbly ask my fellow councilors to focus on the ..."*)

### Węzeł `[206]`
Mówca: **Laurento Esquibel**
> ""Alternately, we could find a compromise that involves all three of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""There is no compromise where Lespia is involved. They'll..."*)
  - -> `[215]` (*Player_Romus: ""I want to leave Lespia out of it. This dispute is betwee..."*)
  - -> `[216]` (*Player_Romus: ""But then what happens if Morella and their Valgslandian ..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_ATO == true"*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Lucita raised a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucita Azaro: ""What troubles me is the specter of Lespia.""*)

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""What troubles me is the specter of Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucita Azaro: ""If Pales claims the field, I am almost certain that our ..."*)

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""If Pales claims the field, I am almost certain that our northern neighbors will end up with the rights to it. They could be a presence in our waters for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Laurento Esquibel: ""That isn't necessarily bad for us. Maybe a compromise ca..."*)

### Węzeł `[210]`
Mówca: **Laurento Esquibel**
> ""That isn't necessarily bad for us. Maybe a compromise can be found that involves all three of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""There is no compromise where Lespia is involved. They'll..."*)
  - -> `[215]` (*Player_Romus: ""I want to leave Lespia out of it. This dispute is betwee..."*)
  - -> `[216]` (*Player_Romus: ""But then what happens if Morella and their Valgslandian ..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_ATO == true"*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no compromise where Lespia is involved. They'll steamroll over us at the first chance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Laurento Esquibel), `[210]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Elena Werner: ""You know what Lespian Protectionism is like, Laurento. T..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Diplomacy_Intention_ATO == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Diplomacy_Intention_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""That would be one way to get closer to ATO, yes.""*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to leave Lespia out of it. This dispute is between Rizia and Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Laurento Esquibel), `[210]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Elena Werner: ""I wish it were that simple, Your Majesty. But Pales will..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But then what happens if Morella and their Valgslandian friends get involved? They won't be happy with an ATO member drilling so far south.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Laurento Esquibel), `[210]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucita Azaro: ""And that could lead to the kind of consequences I was wa..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be one way to get closer to ATO, yes.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true`
- **Kontekst wejściowy (poprzednik):** `[206]` (Laurento Esquibel), `[210]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucita Azaro: ""Are we sure that's what we want, though? Especially with..."*)

### Węzeł `[218]`
Mówca: **Lucita Azaro**
> ""And that could lead to the kind of consequences I was warning you about earlier, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Laurento had a pained expression on his face."*)

### Węzeł `[219]`
Mówca: **Elena Werner**
> ""I wish it were that simple, Your Majesty. But Pales will have to sell the gas from the Aureus field to someone. And our northern neighbors are the most likely candidates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Laurento had a pained expression on his face."*)

### Węzeł `[220]`
Mówca: **Lucita Azaro**
> ""Are we sure that's what we want, though? Especially with Morella and Valgsland waiting in the wings...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Laurento had a pained expression on his face."*)

### Węzeł `[221]`
Mówca: **Elena Werner**
> ""You know what Lespian Protectionism is like, Laurento. The republic isn't exactly keen on sharing resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Laurento had a pained expression on his face."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "Laurento had a pained expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Laurento Esquibel: ""I still don't think we should give up on the possibility..."*)

### Węzeł `[223]`
Mówca: **Laurento Esquibel**
> ""I still don't think we should give up on the possibility of negotiation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales == true"*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He ruined his chances at building on our rapport when he sent that ship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Laurento Esquibel: ""The ship has not started drilling yet. It could be he do..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He ruined his chances at reaching an understanding when he sent that ship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Laurento Esquibel: ""The ship has not started drilling yet. It could be he do..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to come to an understanding. I want to crush his Grand Duchy to smithereens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1; RiziaDLC.PersonalVa..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1; RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "Laurento blanched."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For your sake, Mr. Esquibel, I will try to be diplomatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Laurento Esquibel: ""You know how much I respected your father. But with you,..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea whether his intentions were sincere. He might still harbor a grudge against Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Laurento Esquibel: ""The only way to find out is to talk to him.""*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will be hard with Lespia looking over his shoulder. But I will try to be diplomatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Laurento Esquibel: ""You know how much I respected your father. But with you,..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. If we meet in person, I'm sure I'll be able to get him to back down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Laurento Esquibel: ""I am sure of it as well.""*)

### Węzeł `[232]`
Mówca: **Laurento Esquibel**
> ""The only way to find out is to talk to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Laurento Esquibel: ""Shall we discuss our diplomatic options? Are you leaning..."*)

### Węzeł `[233]`
Mówca: **Laurento Esquibel**
> ""You know how much I respected your father. But with you, I see a chance for a new approach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Laurento Esquibel: ""Shall we discuss our diplomatic options? Are you leaning..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "Laurento blanched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Laurento Esquibel: ""Perhaps we should at least discuss our diplomatic option..."*)

### Węzeł `[235]`
Mówca: **Laurento Esquibel**
> ""The ship has not started drilling yet. It could be he doesn't intend for it to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Laurento Esquibel: ""Perhaps we should at least discuss our diplomatic option..."*)

### Węzeł `[236]`
Mówca: **Laurento Esquibel**
> ""I am sure of it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Laurento Esquibel: ""Shall we discuss our diplomatic options? Are you leaning..."*)

### Węzeł `[237]`
Mówca: **Laurento Esquibel**
> ""Shall we discuss our diplomatic options? Are you leaning towards any particular outcome?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales Diplomacy Hub"*)

### Węzeł `[238]`
Mówca: **Laurento Esquibel**
> ""Perhaps we should at least discuss our diplomatic options? Are you leaning towards any particular outcome?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "Pales Diplomacy Hub"*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need a third party. We can settle this between ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Laurento Esquibel: ""If you can't, though, the Alliance of Nations would be c..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you mean asking the Alliance of Nations to arbitrate the dispute?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Laurento Esquibel: ""Correct, Your Majesty. AN arbitration is the typical pat..."*)

### Węzeł `[241]`
Mówca: **Laurento Esquibel**
> ""Don't forget, Ms. Werner. What we would lose from ceding the field, we might gain from a closer partnership with Pales and Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Hugo Toras: ""On the other hand, Mr. Esquibel, it will make us look we..."*)

### Węzeł `[242]`
Mówca: **Hugo Toras**
> ""On the other hand, Mr. Esquibel, it will make us look weak. And the foreign powers will jump on the opportunity like vultures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "My uncle's hand unconsciously formed a fist."*)

### Węzeł `[243]`
Mówca: **Hugo Toras**
> ""Think about how much territory we have relinquished already. How much wealth we have lost because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Hugo Toras: ""I am certain that if we give up this gas field, the Wehz..."*)

### Węzeł `[244]`
Mówca: **Hugo Toras**
> ""I am certain that if we give up this gas field, the Wehzeks will be even more emboldened to keep their grip on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""You're right, Hugo. First Pales, then Zille, then this? ..."*)
  - -> `[247]` (*Player_Romus: ""On the other hand, won't fighting for our rightful part ..."*)
  - -> `[248]` (*Player_Romus: ""What if we're actually wrong about having a claim to the..."*)
  - -> `[258]` (*Player_Romus: ""I don't like the idea any more than you do, Hugo. But my..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Hugo. First Pales, then Zille, then this? We must preserve what's left of our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucita Azaro: ""If we do cede the field, it must be done very carefully...."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "My uncle's hand unconsciously formed a fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Hugo Toras: ""Think about how much territory we have relinquished alre..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand, won't fighting for our rightful part of the field take up resources we should be using to get Zille back?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Elena Werner: ""You do have a point there, Your Majesty. We would have t..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if we're actually wrong about having a claim to the field? Ceding it to Pales would save us a lot of trouble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Elena Werner: ""The value of the gas in the field is high enough that I ..."*)

### Węzeł `[249]`
Mówca: **Elena Werner**
> ""You do have a point there, Your Majesty. We would have to allocate our funding very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede = ..."*)

### Węzeł `[250]`
Mówca: **Lucita Azaro**
> ""If we do cede the field, it must be done very carefully. We can't let Duke Reinhart think that his intimidation tactics worked on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede = ..."*)

### Węzeł `[251]`
Mówca: **Elena Werner**
> ""Unfortunately, arbitration is an expensive and time-consuming process. And there's no guarantee it would end in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Laurento Esquibel: ""With that said, it's definitely the safest way to avoid ..."*)

### Węzeł `[252]`
Mówca: **Laurento Esquibel**
> ""Correct, Your Majesty. AN arbitration is the typical path in disputes like these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Elena Werner: ""Unfortunately, arbitration is an expensive and time-cons..."*)

### Węzeł `[253]`
Mówca: **Laurento Esquibel**
> ""If you can't, though, the Alliance of Nations would be called in to arbitrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Elena Werner: ""Unfortunately, arbitration is an expensive and time-cons..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A third party... like the Rizian military?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Laurento Esquibel: ""I believe Ms. Werner was referring to the Alliance of Na..."*)

### Węzeł `[255]`
Mówca: **Laurento Esquibel**
> ""With that said, it's definitely the safest way to avoid a diplomatic incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus: ""We have Rumburg on our side. I'm sure Queen Beatrice wou..."*)
  - -> `[261]` (*Player_Romus: ""It does sound like the law is on our side. Maybe this is..."*)
  - -> `[263]` (*Player_Romus: ""No, the AN will muddle everything up with its bureaucrac..."*)
  - -> `[262]` (*Player_Romus: ""We don't have time to spare. I want that gas *now*.""*)

### Węzeł `[256]`
Mówca: **Laurento Esquibel**
> ""I believe Ms. Werner was referring to the Alliance of Nations. It's usually called on to arbitrate disputes like these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Elena Werner: ""Unfortunately, arbitration is an expensive and time-cons..."*)

### Węzeł `[257]`
Mówca: **Elena Werner**
> ""The value of the gas in the field is high enough that I think it's worth defending our claim for as long as we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede = ..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the idea any more than you do, Hugo. But my father taught me that sometimes we have to sacrifice part of our kingdom to save the rest of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Hugo Toras: ""Up to a point, Your Majesty. What happens when we have n..."*)

### Węzeł `[259]`
Mówca: **Hugo Toras**
> ""Up to a point, Your Majesty. What happens when we have nothing left to sacrifice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede = ..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have Rumburg on our side. I'm sure Queen Beatrice would support us through the arbitration process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Laurento Esquibel: ""The weight of GRACE versus that of Lespia and ATO. We wo..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It does sound like the law is on our side. Maybe this is the easiest way forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Elena Werner: ""On the other hand, if the AN does end up ruling against ..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have time to spare. I want that gas *now*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Elena Werner: ""Even if we were granted part of the field instantly, it ..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, the AN will muddle everything up with its bureaucracy. I want to talk to the Duke man to man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Laurento Esquibel: ""I would encourage you to try, Your Majesty.""*)

### Węzeł `[264]`
Mówca: **Elena Werner**
> ""Even if we were granted part of the field instantly, it would take a while before gas extraction could begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Elena Werner: ""But yes, arbitration would take even longer.""*)

### Węzeł `[265]`
Mówca: **Elena Werner**
> ""But yes, arbitration would take even longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share =..."*)

### Węzeł `[266]`
Mówca: **Elena Werner**
> ""On the other hand, if the AN does end up ruling against us, that would be definitive. We would be forced to completely give up our claim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share =..."*)

### Węzeł `[267]`
Mówca: **Laurento Esquibel**
> ""The weight of GRACE versus that of Lespia and ATO. We would be evenly matched.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share =..."*)

### Węzeł `[268]`
Mówca: **Laurento Esquibel**
> ""I would encourage you to try, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share =..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales Diplomacy Hub]"*)

### Węzeł `[270]`
Mówca: **Narrator**
> "She spoke slowly, as if thinking out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucita Azaro: ""With His Majesty's blessing... the Rizian navy could sur..."*)

### Węzeł `[271]`
Mówca: **Laurento Esquibel**
> ""Are you in your right mind, young lady? The navy? We'd be escalating the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player_Romus: ""'Young lady'? I know you come from a different generatio..."*)
  - -> `[329]` (*Player_Romus: ""I second that. A military response could have disastrous..."*)
  - -> `[330]` (*Player_Romus: ""It's not an outlandish suggestion. We've already establi..."*)
  - -> `[410]` (*Player_Romus: ""They are the ones who are escalating. We cannot simply s..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Claim..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""Is there a way we can claim the entire field for Rizia?""*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there a way we can claim the entire field for Rizia?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == false`
- **Kontekst wejściowy (poprzednik):** `[237]` (Laurento Esquibel), `[238]` (Laurento Esquibel), `[265]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Laurento Esquibel: ""Not without major diplomatic repercussions, I'm afraid.""*)

### Węzeł `[276]`
Mówca: **Laurento Esquibel**
> ""Not without major diplomatic repercussions, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Elena Werner: ""No matter which maritime boundaries you look at, it's cl..."*)

### Węzeł `[277]`
Mówca: **Elena Werner**
> ""No matter which maritime boundaries you look at, it's clear that half of the field lies in Palesian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Elena Werner: ""The only way for Rizian Oil and Gas to access the entire..."*)

### Węzeł `[278]`
Mówca: **Elena Werner**
> ""The only way for Rizian Oil and Gas to access the entire field would be for us to purchase the exploration rights from Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""That would make our gas extraction dependent on their co..."*)
  - -> `[280]` (*Player_Romus: ""Sounds costlier than I envisioned, but we would certainl..."*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would make our gas extraction dependent on their conditions. No, thanks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds costlier than I envisioned, but we would certainly reap the rewards. Why don't we pursue that option?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or reconquer Pales. Right, Duchess Azaro?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Kontekst wejściowy (poprzednik):** `[278]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance > 2"*)

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""We could, but we have to remember that Lespia is involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucita Azaro: ""We know for a fact that LesPower has designs on the gas ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_Pales_SendSpecialOps == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""We could, but we have to remember that Lespia is involved.""*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucita Azaro: ""We could, but we have to consider Lespia's potential inv..."*)

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""We could, but we have to consider Lespia's potential involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Lucita Azaro: ""If Lespia already has designs on the field, Pales could ..."*)

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""We know for a fact that LesPower has designs on the gas field. If we want the rights, we will have to outbid them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Laurento Esquibel: ""And before that, we'd have to convince Duke Reinhart tha..."*)

### Węzeł `[288]`
Mówca: **Laurento Esquibel**
> ""Which may be difficult, considering the shaky state of Rizian-Palesian relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)

### Węzeł `[289]`
Mówca: **Laurento Esquibel**
> ""And before that, we'd have to convince Duke Reinhart that Rizia is a trustworthy partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Laurento Esquibel: ""Which may be difficult, considering the shaky state of R..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Laurento Esquibel: ""Which might be possible. Reinhart still seems to trust y..."*)

### Węzeł `[293]`
Mówca: **Laurento Esquibel**
> ""Which might be possible. Reinhart still seems to trust you more than your father, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)

### Węzeł `[294]`
Mówca: **Lucita Azaro**
> ""If Lespia already has designs on the field, Pales could force us to outbid them for access to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Laurento Esquibel: ""And before that, we'd have to convince Duke Reinhart tha..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "I saw a hint of a smile on Lucita's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Lucita Azaro: ""I am still not convinced that's the right course of acti..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance > 2"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Romance > 2)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "I saw a hint of a smile on Lucita's face."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Romance > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "Lucita shook her head."*)

### Węzeł `[299]`
Mówca: **Lucita Azaro**
> ""I am still not convinced that's the right course of action for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""However, if you insisted on a new campaign against Pales..."*)

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""However, if you insisted on a new campaign against Pales, I would be obliged to provide counsel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "Laurento wiped his brow."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "Lucita shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Lucita Azaro: ""I am still not convinced that's the right course of acti..."*)

### Węzeł `[302]`
Mówca: **Lucita Azaro**
> ""I am still not convinced that's the right course of action for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lucita Azaro: ""Although it would make this dispute considerably less co..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_TakeBackLand == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""Or reconquer Pales. Right, Duchess Azaro?""*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_TakeBackLand == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[306]`
Mówca: **Lucita Azaro**
> ""Although it would make this dispute considerably less complicated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Narrator: "Laurento wiped his brow."*)

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. And don't forget about Lespia's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucita Azaro: ""We know for a fact that LesPower has designs on the gas ..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_Pales_SendSpecialOps == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucita Azaro: ""Agreed, Your Majesty. And don't forget about Lespia's in..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Lucita Azaro: ""Agreed, Your Majesty. And don't forget about Lespia's po..."*)

### Węzeł `[311]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. And don't forget about Lespia's potential involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Lucita Azaro: ""If Lespia already has designs on the field, Pales could ..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales Diplomacy Hub]"*)

### Węzeł `[313]`
Mówca: **Narrator**
> "Laurento wiped his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Laurento Esquibel: ""I beg of you to trust your first instincts, Duchess Azar..."*)

### Węzeł `[314]`
Mówca: **Laurento Esquibel**
> ""I beg of you to trust your first instincts, Duchess Azaro. Pursuing a path of aggression could delay our access to the gas field for months or even years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAl..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "Hugo cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Hugo Toras: ""If I may, Your Majesty.""*)

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""If I may, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Hugo Toras: ""We have still not decided what to do about the Palesian ..."*)

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""We have still not decided what to do about the Palesian drillship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player_Romus: ""I don't like the idea of it being present in the gas fie..."*)
  - -> `[320]` (*Player_Romus: ""We have to do *something*, obviously. The Palesians must..."*)
  - -> `[319]` (*Player_Romus: ""We shouldn't immediately interpret the ship as a provoca..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the idea of it being present in the gas field during our negotiations. But I don't see a way to stop it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""I do, Your Majesty. But my fellow councilors won't like ..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't immediately interpret the ship as a provocation. This could all be a misunderstanding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Hugo Toras: ""Respectfully, Your Majesty, the Palesians' intentions ar..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to do *something*, obviously. The Palesians must not be allowed to get away with this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucita Azaro: ""I have one idea, Your Majesty. But my fellow councilors ..."*)

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""I do, Your Majesty. But my fellow councilors won't like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "She spoke slowly, as if thinking out loud."*)

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""I have one idea, Your Majesty. But my fellow councilors won't like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "She spoke slowly, as if thinking out loud."*)

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""Respectfully, Your Majesty, the Palesians' intentions are crystal clear to me. Even if Duke Reinhart is open to negotiations, he sent this ship to rattle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Lucita Azaro: ""My suggestion is to rattle him right back.""*)

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""My suggestion is to rattle him right back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "She spoke slowly, as if thinking out loud."*)

### Węzeł `[325]`
Mówca: **Lucita Azaro**
> ""With His Majesty's blessing... the Rizian navy could surround the field, preventing the drillship from reaching its destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Laurento looked up in outrage."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "Laurento looked up in outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Laurento Esquibel: ""Are you in your right mind, young lady? The navy? We'd b..."*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Young lady'? I know you come from a different generation, Mr. Esquibel, but that address was completely out of line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Laurento Esquibel: ""Excuse me, Your Majesty. But only the impetuousness of y..."*)

### Węzeł `[328]`
Mówca: **Laurento Esquibel**
> ""Excuse me, Your Majesty. But only the impetuousness of youth could be behind such a rash response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Elena Werner: ""Actually, my elderly friend, Duchess Azaro may have the ..."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I second that. A military response could have disastrous consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not an outlandish suggestion. We've already established that Pales is violating international law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[331]`
Mówca: **Elena Werner**
> ""Actually, my elderly friend, Duchess Azaro may have the right idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "Laurento looked at her indignantly."*)

### Węzeł `[332]`
Mówca: **Laurento Esquibel**
> ""Tensions with Pales are high enough already. This could bring them to a boiling point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Elena Werner: ""The Duchess is not talking about sinking the drilling sh..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Laurento Esquibel: ""Tensions with Pales are high enough already. This could ..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Laurento Esquibel: ""We were on the verge of reconciling with Pales after all..."*)

### Węzeł `[336]`
Mówca: **Laurento Esquibel**
> ""We were on the verge of reconciling with Pales after all these years. This would shatter our chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Elena Werner: ""The Duchess is not talking about sinking the drilling sh..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "Laurento looked at her indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Elena Werner: ""Of course we shouldn't fire on their ship. But a blockad..."*)

### Węzeł `[338]`
Mówca: **Elena Werner**
> ""Of course we shouldn't fire on their ship. But a blockade would keep the gas field clear until you've had a chance to speak with Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Elena Werner: ""If we do end up in arbitration talks, Pales having an es..."*)

### Węzeł `[339]`
Mówca: **Elena Werner**
> ""The Duchess is not talking about sinking the drilling ship, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "Laurento looked at her indignantly."*)

### Węzeł `[340]`
Mówca: **Elena Werner**
> ""A blockade could keep the field clear until His Majesty has had a chance to speak with Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Elena Werner: ""If we do end up in arbitration talks, Pales having an es..."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "Laurento looked at her indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Elena Werner: ""A blockade could keep the field clear until His Majesty ..."*)

### Węzeł `[342]`
Mówca: **Elena Werner**
> ""If we do end up in arbitration talks, Pales having an established presence in the Aureus field would give them an unwarranted edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player_Romus: ""That settles it, then. I want us to have a fighting chan..."*)
  - -> `[345]` (*Player_Romus: ""Even so, the risk of escalation is too high. It doesn't ..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)
  - -> `[352]` (*Player_Romus: ""Pales and Lespia are literally testing the waters with u..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That settles it, then. I want us to have a fighting chance to claim our rightful part of the field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[342]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Hugo Toras: ""I agree that asserting Rizian sovereignty is of the utmo..."*)

### Węzeł `[344]`
Mówca: **Hugo Toras**
> ""I too am wary of miring ourselves in another conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Hugo Toras: ""Yes, sending the navy would help assert Rizian sovereign..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even so, the risk of escalation is too high. It doesn't seem worth it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[342]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Laurento Esquibel: ""Precisely, Your Majesty.""*)

### Węzeł `[346]`
Mówca: **Laurento Esquibel**
> ""Precisely, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Hugo Toras: ""I too am wary of miring ourselves in another conflict.""*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_Pales_SendSpecialOps == true)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player_Romus: ""I am hesitant to interfere. What if ATO retaliates?""*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am hesitant to interfere. What if ATO retaliates?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Kontekst wejściowy (poprzednik):** `[342]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Lucita Azaro: ""There may be LesPower executives on board the ship, but ..."*)

### Węzeł `[351]`
Mówca: **Lucita Azaro**
> ""There may be LesPower executives on board the ship, but it is flying the Palesian flag. Neither Lespia nor ATO would be allowed to get involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Hugo Toras: ""I too am wary of miring ourselves in another conflict.""*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales and Lespia are literally testing the waters with us. If we let them reach the field, we have already lost it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[342]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Hugo Toras: ""I agree that asserting Rizian sovereignty is of the utmo..."*)

### Węzeł `[353]`
Mówca: **Hugo Toras**
> ""I agree that asserting Rizian sovereignty is of the utmost importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""Especially knowing what we know about Lespia's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Hugo Toras: ""But I am wary of miring ourselves in another conflict. W..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_Pales_SendSpecialOps == true"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_Pales_SendSpecialOps == true)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_Pales_SendSpecialOps == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Hugo Toras: ""Especially knowing what we know about Lespia's involveme..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_Pales_SendSpecialOps == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Hugo Toras: ""But I am wary of miring ourselves in another conflict. W..."*)

### Węzeł `[358]`
Mówca: **Hugo Toras**
> ""But I am wary of miring ourselves in another conflict. What if the Palesians call our bluff?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_NavalBombardmentCapability > 0"*)

### Węzeł `[359]`
Mówca: **Hugo Toras**
> ""Yes, sending the navy would help assert Rizian sovereignty, but are we strong enough to defend ourselves should the Palesians call our bluff?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_NavalBombardmentCapability > 0"*)

### Węzeł `[360]`
Mówca: **Lucita Azaro**
> ""We don't need to worry about that, Your Grace. Our navy is capable of outgunning Pales if need be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Lucita Azaro: ""Still, this is not a decision to take lightly.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_NavalBombardmentCapability > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_NavalBombardmentCapability > 0"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_NavalBombardmentCapability ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_NavalBombardmentCapability > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_NavalBombardmentCapability"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Lucita Azaro: ""We don't need to worry about that, Your Grace. Our navy ..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_NavalBombardmentCapability > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_NavalBombardmentCapability"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Lucita Azaro: ""That is a concern, Your Grace. We have a capable navy, b..."*)

### Węzeł `[364]`
Mówca: **Lucita Azaro**
> ""That is a concern, Your Grace. We have a capable navy, but we won't be able to outgun Pales if it comes down to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Lucita Azaro: ""This is not a decision to take lightly.""*)

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""Still, this is not a decision to take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""I understand the implications. But I fear we have no oth..."*)
  - -> `[370]` (*Player_Romus: ""I do not take Duke Reinhart's violation of the law light..."*)
  - -> `[368]` (*Player_Romus: ""I agree. And I think we should exercise caution. I will ..."*)
  - -> `[369]` (*Player_Romus: ""I see through your manipulations, Duchess Azaro, and I w..."*)

### Węzeł `[366]`
Mówca: **Lucita Azaro**
> ""This is not a decision to take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""I understand the implications. But I fear we have no oth..."*)
  - -> `[370]` (*Player_Romus: ""I do not take Duke Reinhart's violation of the law light..."*)
  - -> `[368]` (*Player_Romus: ""I agree. And I think we should exercise caution. I will ..."*)
  - -> `[369]` (*Player_Romus: ""I see through your manipulations, Duchess Azaro, and I w..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA: ""I understand the implications. But I fear we have no other choice. We will institute a naval blockade of the gas field immediately." [Order Blockade, +1 Authority]"]** — Mówca: **Player_Romus**
> ""I understand the implications. But I fear we have no other choice. We will institute a naval blockade of the gas field immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro), `[366]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; ..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. And I think we should exercise caution. I will meet with Duke Reinhart before deciding our next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro), `[366]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "Laurento nodded, relieved."*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see through your manipulations, Duchess Azaro, and I will not give in. We will refrain from provoking Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro), `[366]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Lucita Azaro: ""Manipulations?! I--""*)

### Węzeł `[370]`
**[WYBÓR GRACZA: ""I do not take Duke Reinhart's violation of the law lightly, either. Our navy will show him that Rizia cannot be intimidated." [Order Blockade, +1 Authority]"]** — Mówca: **Player_Romus**
> ""I do not take Duke Reinhart's violation of the law lightly, either. Our navy will show him that Rizia cannot be intimidated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Lucita Azaro), `[366]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; ..."*)

### Węzeł `[371]`
Mówca: **Lucita Azaro**
> ""Manipulations?! I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "She clenched her jaw and forced herself to smile."*)

### Węzeł `[372]`
Mówca: **Narrator**
> "She clenched her jaw and forced herself to smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lucita Azaro: ""I understand, Your Majesty. Let me know if there's any o..."*)

### Węzeł `[373]`
Mówca: **Lucita Azaro**
> ""I understand, Your Majesty. Let me know if there's any other way I can support you in your negotiations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 2;"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1;"*)

### Węzeł `[375]`
Mówca: **Narrator**
> "Laurento nodded, relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Laurento Esquibel: ""Very good, Your Majesty. I'll get everything in order fo..."*)

### Węzeł `[376]`
Mówca: **Laurento Esquibel**
> ""Very good, Your Majesty. I'll get everything in order for your meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Lucita Azaro: ""Our naval forces will be on standby in case you change y..."*)

### Węzeł `[377]`
Mówca: **Narrator**
> "Lucita nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2; RiziaDLC...."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true;
RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade = true;
RiziaDLC.Resources_Authority += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "Lucita nodded. Laurento and Elena exchanged troubled glan..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade = true;
RiziaDLC.Resources_Authority += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Lucita nodded."*)

### Węzeł `[380]`
Mówca: **Lucita Azaro**
> ""As you wish, Your Majesty. I'll make the order right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Narrator: "Laurento attempted to smile."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "Lucita nodded. Laurento and Elena exchanged troubled glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2; RiziaDLC...."*)

### Węzeł `[382]`
Mówca: **Narrator**
> "Laurento attempted to smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Laurento Esquibel: ""This will add a tense background to negotiations, to say..."*)

### Węzeł `[383]`
Mówca: **Laurento Esquibel**
> ""This will add a tense background to negotiations, to say the least. But I have faith it will all work out for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Elena Werner: ""That's the spirit, Laurento. I'm sure our ships will onl..."*)

### Węzeł `[384]`
Mówca: **Elena Werner**
> ""That's the spirit, Laurento. I'm sure our ships will only be in place for a few days at most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Hugo Toras: ""I'll adjourn the meeting so Duchess Azaro may begin prep..."*)

### Węzeł `[385]`
Mówca: **Hugo Toras**
> ""I'll adjourn the meeting so Duchess Azaro may begin preparations. We will inform you of the navy's position prior to your departure for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player_Romus: ""I fully expect a peaceful resolution. This is just a pre..."*)
  - -> `[398]` (*Player_Romus: ""I wish I could see the look on Reinhart's face when he f..."*)
  - -> `[399]` (*Player_Romus: ""Thank you for the suggestion, Duchess. I knew you could ..."*)
  - -> `[404]` (*Player_Romus: ""Thank you all for your time.""*)

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""Our naval forces will be on standby in case you change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Hugo Toras: ""I pray to St. Wruhec that they will not be needed.""*)

### Węzeł `[387]`
Mówca: **Hugo Toras**
> ""I pray to St. Wruhec that they will not be needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1;"*)

### Węzeł `[388]`
Mówca: **Narrator**
> "There was a moment's silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Hugo Toras: ""I'll adjourn the meeting so Mr. Esquibel can begin his p..."*)

### Węzeł `[389]`
Mówca: **Hugo Toras**
> ""I'll adjourn the meeting so Mr. Esquibel can begin his preparations. We'll keep you abreast of any changes prior to your departure for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Player_Romus: ""I fully expect a peaceful resolution.""*)
  - -> `[391]` (*Player_Romus: ""Thank you all for your time.""*)
  - -> `[390]` (*Player_Romus: ""I hope I don't regret following your advice, Mr. Esquibel.""*)
  - -> `[393]` (*Player_Romus: ""I hope there are no more unpleasant surprises.""*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I don't regret following your advice, Mr. Esquibel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Laurento Esquibel: ""I am certain you would have regretted a military respons..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you all for your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully expect a peaceful resolution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Lucita Azaro: ""Good luck, Your Majesty. I mean that sincerely.""*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope there are no more unpleasant surprises.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Hugo Toras: ""We'll see to it that there aren't.""*)

### Węzeł `[394]`
Mówca: **Hugo Toras**
> ""We'll see to it that there aren't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[395]`
Mówca: **Laurento Esquibel**
> ""I am certain you would have regretted a military response more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[396]`
Mówca: **Lucita Azaro**
> ""Good luck, Your Majesty. I mean that sincerely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully expect a peaceful resolution. This is just a precaution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Laurento Esquibel: ""No need to justify it, Your Majesty. This is your decisi..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I could see the look on Reinhart's face when he finds out about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Laurento Esquibel: ""You'll see him very soon, Your Majesty.""*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the suggestion, Duchess. I knew you could be counted on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "She bowed her head modestly."*)

### Węzeł `[400]`
Mówca: **Laurento Esquibel**
> ""You'll see him very soon, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[401]`
Mówca: **Laurento Esquibel**
> ""No need to justify it, Your Majesty. This is your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[402]`
Mówca: **Lucita Azaro**
> ""I'm just doing my job, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[403]`
Mówca: **Narrator**
> "She bowed her head modestly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Lucita Azaro: ""I'm just doing my job, Your Majesty.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you all for your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[405]`
Mówca: **Narrator**
> "The meeting drew to a close."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "I spent a sleepless night in Fort Ales, wondering what wo..."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "I spent a sleepless night in Fort Ales, wondering what would happen when the Rizian navy reached its destination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_NavyDeployed = true"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "The meeting drew to a close."*)

### Węzeł `[408]`
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
  - -> `[380]` (*Lucita Azaro: ""As you wish, Your Majesty. I'll make the order right away.""*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "There was a moment's silence."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are the ones who are escalating. We cannot simply stay idle. We need a strong response.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase = true;
RiziaDLC.Enable_Policy_RD_Order_ExpandTeradorAirbase = true;
RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_ExpandTeradorAirbase"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVa..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableToken("Rizia_Event_Aureus");`
- **Efekt skryptowy (`userScript`):** `EnableToken("Rizia_Event_Aureus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""Your Majesty, I have advocated for caution regarding Pal..."*)

### Węzeł `[414]`
Mówca: **Laurento Esquibel**
> ""Since then, both Rizia and Pales have variously claimed ownership of these waters and the resources therein.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Laurento Esquibel: ""The borders that Rizia recognizes today are the ones def..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryPresident("Rizia_Country_Agnolia", "PM Maartin Van Hoorten");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryPresident("Rizia_Country_Agnolia","PM Maartin Van Hoorten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I had called a council meeting in Fort Ales to discuss ou..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVanHoorten = true;
RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende1952 = true;
RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende = false;
RiziaDLCSupport.Codex_Locations_Countries_Agnolia = false;
RiziaDLCSupport.Codex_Locations_Countries_Agnolia_1952 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVanHoorten"] = true;
Variable["RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende1952"] = true;
Variable["RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende"] = false;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Agnolia"] = false;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Agnolia_1952"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "UpdateCountryPresident("Rizia_Country_Agnolia", "PM Maart..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Managing the resource conflict with the Grand-Duchy of Pales", "Fort Ales", "Pales Administrative District");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Managing the resource conflict with the Grand-Duchy of Pales","Fort Ales","Pales Administrative District");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");"*)
