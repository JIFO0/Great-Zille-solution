# Rizia/Turn 9/Wehlen Derdia Meditation

- **ID konwersacji:** `437`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/437_Wehlen_Derdia_Meditation.md`
- **Liczba węzłów dialogowych:** 394
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[70]** Laurento Esquibel
- **[77]** Wiktor Smolak (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGameSupport.News_Turn07_R_RitualFailed`
- `RiziaDLC.CountryRelation_Sordland_Allied`
- `RiziaDLC.CountryRelation_Sordland_Friendly`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Resources_Military_Ships`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco`
- `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Policy_Economy_WehlenPipeline_Project`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Resources_Military_Ships`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Failed`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Success`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Failed`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimSeaRoute`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline`
- `RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil`
- `RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth`
- `RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia`
- `RiziaDLCSupport.News_Turn09_G_PrayerSeaRoute`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[438] Rizia/Turn 9/Pabel Extradition** (../Turn_09/438_Pabel_Extradition.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[25]` | **""Have you or have you not been harboring BFF terrorists within your borders, Azmal?""** | `[20]` **Jorga Azmal**: ""With help from His Majesty, I m..."<br>`[24]` **Jorga Azmal**: ""A pursuit aided by His Majesty,..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false` | *Brak zmian stanu* | `[29]` **Jorga Azmal**: ""We give shelter to Golcondists ..." |
| `[26]` | **""The BFF are not true Golcondists, Supreme Wiseman. They're mere puppets of superp..."** | `[20]` **Jorga Azmal**: ""With help from His Majesty, I m..."<br>`[24]` **Jorga Azmal**: ""A pursuit aided by His Majesty,..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false` | *Brak zmian stanu* | `[32]` **Jorga Azmal**: ""As I said at the Alliance of Na..." |
| `[27]` | **""Yes, President Smolak, you can't use the BFF as justification for animosity towar..."** | `[20]` **Jorga Azmal**: ""With help from His Majesty, I m..."<br>`[15]` **Jorga Azmal**: ""The same Bludish Freedom Front ..." | `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false` | *Brak zmian stanu* | `[31]` **Jorga Azmal**: ""So many Golcondists have died. ..." |
| `[28]` | **""You cannot wave away the threat that the BFF still poses to Wehlen.""** | `[24]` **Jorga Azmal**: ""A pursuit aided by His Majesty,..."<br>`[16]` **Jorga Azmal**: ""We understand the BFF has cause..." | `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false` | *Brak zmian stanu* | `[33]` **Jorga Azmal**: ""Nor can we condemn our fellow G..." |
| `[30]` | **""I did find Operation Bear Trap rather over the top, President Smolak.""** | `[20]` **Jorga Azmal**: ""With help from His Majesty, I m..."<br>`[24]` **Jorga Azmal**: ""A pursuit aided by His Majesty,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Jorga Azmal**: ""Over the top?! That's all the c..." |
| `[35]` | **""Operation Bear Trap raised alarms for us here in Rizia as well.""** | `[15]` **Jorga Azmal**: ""The same Bludish Freedom Front ..."<br>`[16]` **Jorga Azmal**: ""We understand the BFF has cause..." | `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false` | *Brak zmian stanu* | `[36]` **Jorga Azmal**: ""Yet not enough for you to cut t..." |
| `[43]` | **""What's in Deyr again?""** | `[41]` **Laurento Esquibel**: ""A longstanding point of content..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[51]` **Narrator**: "Azmal and Smolak gave me flabber..." |
| `[47]` | **""Why has Wehlen been blocking the Derdians on their holy pilgrimage, President Smo..."** | `[41]` **Laurento Esquibel**: ""A longstanding point of content..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Wiktor Smolak (R)**: ""The Archsanctuay of Deyr is fir..." |
| `[49]` | **""Ah, yes. Our most holy of holy sites.""** | `[41]` **Laurento Esquibel**: ""A longstanding point of content..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[50]` **Narrator**: "Azmal nodded." |
| `[55]` | **""It sounds like that's a problem for the Sords, not the Rizians.""** | `[41]` **Laurento Esquibel**: ""A longstanding point of content..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Wiktor Smolak (R)**: ""I wish it were that easy. My fr..."<br>`[60]` **Wiktor Smolak (R)**: ""Except that Derdians must pass ..." |
| `[70]` | **""The Derdians don't have to pass through Wehlen to reach Deyr. We could help them ..."** | `[53]` **Jorga Azmal**: ""The Archsanctuary of Deyr is wh..."<br>`[54]` **Jorga Azmal**: ""Yet it is said that every true ..."<br>*(oraz 14 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == false`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 1) == false` | `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"]...` | `[71]` **Laurento Esquibel**: ""Yes, I've looked into the possi..." |
| `[82]` | **""Your corridor solution worked with Morella, Laurento. Can we not do the same thin..."** | `[53]` **Jorga Azmal**: ""The Archsanctuary of Deyr is wh..."<br>`[54]` **Jorga Azmal**: ""Yet it is said that every true ..."<br>*(oraz 12 innych węzłów)* | `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`<br>`Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == false` | *Brak zmian stanu* | `[91]` **Laurento Esquibel**: ""It might."" |
| `[89]` | **""Let's get creative. There must be something that Wehlen would accept in exchange ..."** | `[53]` **Jorga Azmal**: ""The Archsanctuary of Deyr is wh..."<br>`[54]` **Jorga Azmal**: ""Yet it is said that every true ..."<br>*(oraz 14 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == false`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 1) == false` | `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"]...` | `[129]` **Wiktor Smolak (R)**: ""Well... yes, there is."" |
| `[90]` | **""Laurento, your corridor solution may not have worked with Morella, but could it w..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Laurento Esquibel**: ""It might."" |
| `[111]` | **""What if Rizia oversees the security of some kind of prayer corridor through Wehlen?""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Laurento Esquibel**: ""Yes, that's one idea my departm..." |
| `[149]` | **""My kingdom would be very happy to supply the expertise and infrastructure for an ..."** | `[150]` **Jorga Azmal**: ""But we cannot afford the infras..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Wiktor Smolak (R)**: ""Wehlen will also happily chip in.""<br>`[170]` **Laurento Esquibel**: ""We can definitely afford that.""<br>*(oraz 1 innych odgałęzień)* |
| `[151]` | **""Perhaps you could supply Wehlen with missiles to raise the needed funds.""** | `[150]` **Jorga Azmal**: ""But we cannot afford the infras..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Wiktor Smolak (R)**: ""No offense, Your Majesty, but W..." |
| `[153]` | **""If Wehlen is so desperate to sell oil, they should pay for the pipeline themselves.""** | `[150]` **Jorga Azmal**: ""But we cannot afford the infras..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Wiktor Smolak (R)**: ""I can agree to fund part of it...."<br>`[175]` **Wiktor Smolak (R)**: ""If we were that desperate, Your..." |
| `[182]` | **""Here is my solution.""** | `[53]` **Jorga Azmal**: ""The Archsanctuary of Deyr is wh..."<br>`[54]` **Jorga Azmal**: ""Yet it is said that every true ..."<br>*(oraz 14 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == true`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 1) == false` | *Brak zmian stanu* | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." |
| `[190]` | **""We will fund a secure prayer corridor from Derdia through Wehlen to Sordland." [-..."** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorBot...`<br>*(+1 skryptów)* | `[231]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>`[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[191]` | **""We will send troops to oversee the security of a Golcondist prayer corridor throu..."** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Military_Manpower"] > 250` | `Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...`<br>`Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorBot...`<br>*(+1 skryptów)* | `[243]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>`[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[198]` | **""We will create a sea route for Golcondist pilgrims to reach Sordland without havi..."** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | `Variable["RiziaDLC.Resources_Military_Ships"] >= 1  and  Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true` | `Variable["RiziaDLC.Resources_Military_Ships"] = Variable[...` | `[257]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>`[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[202]` | **""Together with Wehlen, we will fund an oil pipeline between Wehlen and Derdia. A s..."** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3` | `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"...`<br>`AddTokenStatusImmediately("Rizia_Country_Wehlen","Progres...`<br>*(+1 skryptów)* | `[271]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>`[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[203]` | **""We will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrima..."** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | `Variable["RiziaDLC.Resources_Budget"] >= 2`<br>`(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3) == false` | `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"...`<br>`AddTokenStatusImmediately("Rizia_Country_Wehlen","Progres...`<br>*(+1 skryptów)* | `[285]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>`[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[204]` | **""Your nations must practice trust and cooperation. Remember, we all pray to the sa..."** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "Neither of them looked satisfied." |
| `[208]` | **""You must fight a Derdian Duel of Generosity.""** | `[186]` **Narrator**: "Both Azmal and Smolak leaned for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Wiktor Smolak's eyes lit up with..." |
| `[225]` | **""You will shake hands.""** | `[224]` **Jorga Azmal**: ""Halaita."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Narrator**: "Smolak eagerly reached out his h..." |
| `[226]` | **""I thank the Lord for watching over today's talks.""** | `[224]` **Jorga Azmal**: ""Halaita."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Jorga Azmal**: ""Praise be to He who unites the ..." |
| `[230]` | **""Now bring the khisha.""** | `[224]` **Jorga Azmal**: ""Halaita."" | `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco"] == true` | *Brak zmian stanu* | `[334]` **Narrator**: "A Wehzek khisha pipe was standin..." |
| `[232]` | **""It is. Take it or leave it." [-1 Authority]"** | `[231]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Authority"] >= 1` | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[239]` | **""If it helps, Rizia will allocate additional funding towards the project." [-1 Bud..."** | `[231]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[240]` | **""Unfortunately, yes.""** | `[231]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>`[243]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Narrator**: "They both shook their heads." |
| `[244]` | **""It is. Take it or leave it." [-1 Authority]"** | `[243]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Authority"] >= 1` | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...`<br>`Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[251]` | **""If it helps, Rizia will allocate additional funding towards the project." [-1 Bud..."** | `[243]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[258]` | **""It is. Take it or leave it." [-1 Authority]"** | `[257]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Authority"] >= 1` | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...`<br>`Variable["RiziaDLC.Resources_Military_Ships"] = Variable[...` | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[265]` | **""If it helps, Rizia will allocate additional funding towards the project." [-1 Bud..."** | `[257]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Resources_Military_Ships"] = Variable[...` | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[272]` | **""It is. Take it or leave it." [-1 Authority]"** | `[271]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Authority"] >= 1  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false` | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...`<br>`Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[279]` | **""If it helps, Rizia will allocate additional funding towards the project." [-2 Bud..."** | `[271]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Budget"] >= 4` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[286]` | **""It is. Take it or leave it." [-2 Authority]"** | `[285]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Authority"] >= 2  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false` | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...`<br>`Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[293]` | **""If it helps, Rizia will allocate additional funding towards the project." [-1 Bud..."** | `[285]` **Wiktor Smolak (R)**: ""Hrm. That's the best you can do?"" | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"...`<br>*(+2 skryptów)* | `[215]` **Wiktor Smolak (R)**: ""Wehlen accepts, Your Majesty!"" |
| `[302]` | **""I am sorry Rizia could not have been more helpful.""** | `[211]` **Jorga Azmal**: ""No! Both of you will stop insul..."<br>`[214]` **Jorga Azmal**: ""This was a waste of both of our..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Wiktor Smolak (R)**: ""It's not your fault, Your Majes..." |
| `[303]` | **""I hope this will not impact our efforts to form the South Merkopan Alliance.""** | `[211]` **Jorga Azmal**: ""No! Both of you will stop insul..."<br>`[214]` **Jorga Azmal**: ""This was a waste of both of our..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Intermerkopum_Efforts"] == true` | *Brak zmian stanu* | `[312]` **Jorga Azmal**: ""Your willingness to help Derdia..."<br>`[313]` **Jorga Azmal**: ""Two failed mediations in one da..."<br>*(oraz 1 innych odgałęzień)* |
| `[304]` | **""It was nonetheless a pleasure to see you both.""** | `[211]` **Jorga Azmal**: ""No! Both of you will stop insul..."<br>`[214]` **Jorga Azmal**: ""This was a waste of both of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Wiktor Smolak (R)**: ""Anytime, Your Majesty."" |
| `[305]` | **""I hope you can still assure us a safe return of the Zille territory, Mr. Smolak.""** | `[211]` **Jorga Azmal**: ""No! Both of you will stop insul..."<br>`[214]` **Jorga Azmal**: ""This was a waste of both of our..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Wiktor Smolak (R)**: ""Of course, Your Majesty."" |
| `[340]` | **""I hope this means I can count on both of your countries' cooperation in the forma..."** | `[224]` **Jorga Azmal**: ""Halaita."" | `Variable["RiziaDLC.Intermerkopum_Efforts"] == true` | *Brak zmian stanu* | `[341]` **Wiktor Smolak (R)**: ""Very gladly. Together, we will ..." |
| `[346]` | **""I look forward to that day, President Smolak.""** | `[343]` **Wiktor Smolak (R)**: ""I'm up to my elbows in paperwor..."<br>`[377]` **Wiktor Smolak (R)**: ""I'm working hard to conclude ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Narrator**: "He bowed and left the suite." |
| `[347]` | **""You had better not be planning any last-minute surprises.""** | `[343]` **Wiktor Smolak (R)**: ""I'm up to my elbows in paperwor..."<br>`[377]` **Wiktor Smolak (R)**: ""I'm working hard to conclude ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Wiktor Smolak (R)**: ""Me? Never."" |
| `[348]` | **""Rest assured that Rizia shall make the transition as smooth as possible.""** | `[343]` **Wiktor Smolak (R)**: ""I'm up to my elbows in paperwor..."<br>`[377]` **Wiktor Smolak (R)**: ""I'm working hard to conclude ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Wiktor Smolak (R)**: ""There is no doubt in my mind."" |
| `[359]` | **""Halaita.""** | `[355]` **Jorga Azmal**: ""I am truly grateful for all you..."<br>`[362]` **Jorga Azmal**: ""I am grateful for your help tod..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[361]` | **""Life is full of surprises, Supreme Wiseman.""** | `[360]` **Jorga Azmal**: ""I am truly grateful for your he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[363]` | **""Together, we shall take on the world.""** | `[355]` **Jorga Azmal**: ""I am truly grateful for all you..."<br>`[360]` **Jorga Azmal**: ""I am truly grateful for your he..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[364]` | **""It was my pleasure.""** | `[355]` **Jorga Azmal**: ""I am truly grateful for all you..."<br>`[362]` **Jorga Azmal**: ""I am grateful for your help tod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[365]` | **""Wiktor is an unusual fellow. But he holds true to his word.""** | `[360]` **Jorga Azmal**: ""I am truly grateful for your he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[367]` | **""I look forward to that day, President Smolak.""** | `[366]` **Wiktor Smolak (R)**: ""I'm up to my elbows in paperwor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Narrator**: "He bowed as Laurento escorted hi..." |
| `[368]` | **""You had better not be planning any last-minute surprises.""** | `[366]` **Wiktor Smolak (R)**: ""I'm up to my elbows in paperwor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Wiktor Smolak (R)**: ""Me? Never."" |
| `[369]` | **""Rest assured that Rizia shall make the transition as smooth as possible.""** | `[366]` **Wiktor Smolak (R)**: ""I'm up to my elbows in paperwor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Wiktor Smolak (R)**: ""There is no doubt in my mind."" |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true ||..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true ||..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true ..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "A short while later, we reconvened with Jorga Azmal aroun..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Wiktor Smolak, Jorga Azmal and a handful of their ministe..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Wiktor Smolak, Jorga Azmal and a handful of their ministers joined us around the conference table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Laurento Esquibel: ""Gentlemen. I know it has been historically difficult for..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "A short while later, we reconvened with Jorga Azmal around the table. This time, we were joined by Wiktor Smolak and his entourage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Laurento Esquibel: ""Gentlemen. I know it has been historically difficult for..."*)

### Węzeł `[8]`
Mówca: **Laurento Esquibel**
> ""Gentlemen. I know it has been historically difficult for Wehlen and Derdia to find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Smolak opened his arms wide."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Smolak opened his arms wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Wiktor Smolak (R): ""I have no idea what you mean, Mr. Esquibel. Derdians are..."*)

### Węzeł `[10]`
Mówca: **Wiktor Smolak (R)**
> ""I have no idea what you mean, Mr. Esquibel. Derdians are always welcome in my republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Wiktor Smolak (R): ""Or they would be, were it not for their troublesome asso..."*)

### Węzeł `[11]`
Mówca: **Wiktor Smolak (R)**
> ""Or they would be, were it not for their troublesome associations with the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_BFF_ThreatEliminated == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Jorga Azmal: ""The same Bludish Freedom Front that your cruel military ..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_BFF_ThreatEliminated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Jorga Azmal: ""We understand the BFF has caused problems for you in the..."*)

### Węzeł `[15]`
Mówca: **Jorga Azmal**
> ""The same Bludish Freedom Front that your cruel military operation all but eliminated?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""We understand the BFF has caused problems for you in the past. But we feel for the innocent Bluds who got caught in the crossfire during your single-minded pursuit of the organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan ==..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Jorga Azmal: ""With help from His Majesty, I might add.""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""Yes, President Smolak, you can't use the BFF as justific..."*)
  - -> `[25]` (*Player_Romus: ""Have you or have you not been harboring BFF terrorists w..."*)
  - -> `[26]` (*Player_Romus: ""The BFF are not true Golcondists, Supreme Wiseman. They'..."*)
  - -> `[35]` (*Player_Romus: ""Operation Bear Trap raised alarms for us here in Rizia a..."*)

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""With help from His Majesty, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""Yes, President Smolak, you can't use the BFF as justific..."*)
  - -> `[25]` (*Player_Romus: ""Have you or have you not been harboring BFF terrorists w..."*)
  - -> `[26]` (*Player_Romus: ""The BFF are not true Golcondists, Supreme Wiseman. They'..."*)
  - -> `[30]` (*Player_Romus: ""I did find Operation Bear Trap rather over the top, Pres..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan ==..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Jorga Azmal: ""A pursuit aided by His Majesty, I might add.""*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Have you or have you not been harboring BFF terrorists w..."*)
  - -> `[26]` (*Player_Romus: ""The BFF are not true Golcondists, Supreme Wiseman. They'..."*)
  - -> `[28]` (*Player_Romus: ""You cannot wave away the threat that the BFF still poses..."*)
  - -> `[35]` (*Player_Romus: ""Operation Bear Trap raised alarms for us here in Rizia a..."*)

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""A pursuit aided by His Majesty, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Have you or have you not been harboring BFF terrorists w..."*)
  - -> `[26]` (*Player_Romus: ""The BFF are not true Golcondists, Supreme Wiseman. They'..."*)
  - -> `[28]` (*Player_Romus: ""You cannot wave away the threat that the BFF still poses..."*)
  - -> `[30]` (*Player_Romus: ""I did find Operation Bear Trap rather over the top, Pres..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you or have you not been harboring BFF terrorists within your borders, Azmal?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Jorga Azmal), `[24]` (Jorga Azmal), `[15]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Jorga Azmal: ""We give shelter to Golcondists in need. We keep no recor..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The BFF are not true Golcondists, Supreme Wiseman. They're mere puppets of superpowers who want to destabilize Wehlen.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Jorga Azmal), `[24]` (Jorga Azmal), `[15]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Jorga Azmal: ""As I said at the Alliance of Nations, there is only one ..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, President Smolak, you can't use the BFF as justification for animosity towards Derdia now that they no longer pose a threat.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Jorga Azmal), `[15]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Jorga Azmal: ""So many Golcondists have died. Am I wrong in fearing tha..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot wave away the threat that the BFF still poses to Wehlen.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Jorga Azmal), `[16]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Jorga Azmal: ""Nor can we condemn our fellow Golcondists for fighting f..."*)

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""We give shelter to Golcondists in need. We keep no record of their pasts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Laurento tapped on the table."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did find Operation Bear Trap rather over the top, President Smolak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Jorga Azmal), `[24]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Jorga Azmal: ""Over the top?! That's all the criticism the King of Rizi..."*)

### Węzeł `[31]`
Mówca: **Jorga Azmal**
> ""So many Golcondists have died. Am I wrong in fearing that Derdia will be next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Laurento tapped on the table."*)

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""As I said at the Alliance of Nations, there is only one superpower that I believe in. And He has blessed the Bluds on their holly mission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Laurento tapped on the table."*)

### Węzeł `[33]`
Mówca: **Jorga Azmal**
> ""Nor can we condemn our fellow Golcondists for fighting for their beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Laurento tapped on the table."*)

### Węzeł `[34]`
Mówca: **Jorga Azmal**
> ""Over the top?! That's all the criticism the King of Rizia can manage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Operation Bear Trap raised alarms for us here in Rizia as well.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[15]` (Jorga Azmal), `[16]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Jorga Azmal: ""Yet not enough for you to cut ties with Wehlen.""*)

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""Yet not enough for you to cut ties with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Laurento tapped on the table."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Laurento tapped on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Laurento Esquibel: ""The BFF is a volatile topic. Which is precisely why we s..."*)

### Węzeł `[38]`
Mówca: **Laurento Esquibel**
> ""The BFF is a volatile topic. Which is precisely why we should not be talking about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Laurento Esquibel: ""Let us focus instead on what Derdia and Wehlen can do fo..."*)

### Węzeł `[39]`
Mówca: **Laurento Esquibel**
> ""Let us focus instead on what Derdia and Wehlen can do for each other, and what the Kingdom of Rizia can do for you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Both men were silent. They nodded warily."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Both men were silent. They nodded warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Laurento Esquibel: ""A longstanding point of contention has been Derdians gai..."*)

### Węzeł `[41]`
Mówca: **Laurento Esquibel**
> ""A longstanding point of contention has been Derdians gaining passage to Deyr in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[47]` (*Player_Romus: ""Why has Wehlen been blocking the Derdians on their holy ..."*)
  - -> `[55]` (*Player_Romus: ""It sounds like that's a problem for the Sords, not the R..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Laurento tapped on the table."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's in Deyr again?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[41]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Azmal and Smolak gave me flabbergasted stares."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""Ah, yes. Our most holy of holy sites.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""What's in Deyr again?""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why has Wehlen been blocking the Derdians on their holy pilgrimage, President Smolak?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Wiktor Smolak (R): ""The Archsanctuay of Deyr is first and foremost a Dastnur..."*)

### Węzeł `[48]`
Mówca: **Wiktor Smolak (R)**
> ""The Archsanctuay of Deyr is first and foremost a Dastnurist site, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Jorga Azmal: ""Yet it is said that every true believer in Nurity must v..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes. Our most holy of holy sites.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Azmal nodded."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Azmal nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Wiktor Smolak (R): ""It is the site of God's descension to Saint Dast. And th..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Azmal and Smolak gave me flabbergasted stares."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Jorga Azmal: ""It is our holiest of holy sites, Your Majesty. Where God..."*)

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""It is our holiest of holy sites, Your Majesty. Where God delivered His message to Saint Dast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Wiktor Smolak (R): ""Hmm. It's funny how your beloved St. Wruhec didn't come ..."*)

### Węzeł `[53]`
Mówca: **Jorga Azmal**
> ""The Archsanctuary of Deyr is where Nurity as a whole came to be. Every true believer must visit it at least once, no matter their denomination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Deyr solutions"*)

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""Yet it is said that every true believer in Nurity must visit it at least once. Wruhecists included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Deyr solutions"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like that's a problem for the Sords, not the Rizians.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)

### Węzeł `[56]`
Mówca: **Wiktor Smolak (R)**
> ""I wish it were that easy. My friend Anton would solve this in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_RitualFailed == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Wiktor Smolak (R): ""I wish it were that easy. My friend Anton would solve th..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Wiktor Smolak (R): ""Except that Derdians must pass through Wehlen to reach D..."*)

### Węzeł `[60]`
Mówca: **Wiktor Smolak (R)**
> ""Except that Derdians must pass through Wehlen to reach Deyr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Jorga Azmal: ""If there was another way to get there, we would use it.""*)

### Węzeł `[61]`
Mówca: **Wiktor Smolak (R)**
> ""It is the site of God's descension to Saint Dast. And therefore of particular importance to Dastnurists, not Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Jorga Azmal: ""The Archsanctuary of Deyr is where Nurity as a whole cam..."*)

### Węzeł `[62]`
Mówca: **Wiktor Smolak (R)**
> ""Hmm. It's funny how your beloved St. Wruhec didn't come up once in that description.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Jorga Azmal: ""The Archsanctuary of Deyr is where Nurity as a whole cam..."*)

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""Your 'friend' couldn't even get the Descension Day ceremony right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Deyr solutions"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_RitualFailed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_RitualFailed == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.News_Turn07_R_RitualFailed == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_RitualFailed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.News_Turn07_R_RitualFailed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Jorga Azmal: ""Your 'friend' couldn't even get the Descension Day cerem..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.News_Turn07_R_RitualFailed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.News_Turn07_R_RitualFailed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Jorga Azmal: ""And why should I trust a man who harbors the same murder..."*)

### Węzeł `[67]`
Mówca: **Jorga Azmal**
> ""And why should I trust a man who harbors the same murderous intentions as you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Deyr solutions"*)

### Węzeł `[68]`
Mówca: **Jorga Azmal**
> ""If there was another way to get there, we would use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Deyr solutions"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Deyr solutions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || ..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Derdians don't have to pass through Wehlen to reach Deyr. We could help them find a sea route.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == false` AND `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Jorga Azmal), `[54]` (Jorga Azmal), `[63]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute = true"*)

### Węzeł `[71]`
Mówca: **Laurento Esquibel**
> ""Yes, I've looked into the possibility. It would go from Yol through the Sudis Sea all the way around to Lachaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Friendly == true || Riz..."*)

### Węzeł `[72]`
Mówca: **Laurento Esquibel**
> ""Sordland would have to agree to it. But we're on good terms with them right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships >= 1"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Friendly == true || RiziaDLC.CountryRelation_Sordland_Allied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Friendly == true || Riz..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Friendly == true || R..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Friendly == true || RiziaDLC.CountryRelation_Sordland_Allied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Laurento Esquibel: ""Sordland would have to agree to it. But we're on good te..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Friendly == true || RiziaDLC.CountryRelation_Sordland_Allied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Laurento Esquibel: ""The problem is that Sordland would have to agree with it..."*)

### Węzeł `[76]`
Mówca: **Laurento Esquibel**
> ""The problem is that Sordland would have to agree with it. And we're not on the best of terms right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Ships >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships >= 1"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Ships >= 1)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Ships >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Ships"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Laurento Esquibel: ""And we can supply the ships ourselves.""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Ships >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Ships"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Laurento Esquibel: ""The problem is that we don't have enough ships to spare.""*)

### Węzeł `[80]`
Mówca: **Laurento Esquibel**
> ""And we can supply the ships ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[81]`
Mówca: **Laurento Esquibel**
> ""The problem is that we don't have enough ships to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your corridor solution worked with Morella, Laurento. Can we not do the same thing with Wehlen?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true` AND `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Jorga Azmal), `[54]` (Jorga Azmal), `[63]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Laurento Esquibel: ""It might.""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Your corridor solution worked with Morella, Laurento. Ca..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""Laurento, your corridor solution may not have worked wit..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""What if Rizia oversees the security of some kind of pray..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get creative. There must be something that Wehlen would accept in exchange for allowing Derdians through to Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == false` AND `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Jorga Azmal), `[54]` (Jorga Azmal), `[63]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline = true"*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Laurento, your corridor solution may not have worked with Morella, but could it work with Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Laurento Esquibel: ""It might.""*)

### Węzeł `[91]`
Mówca: **Laurento Esquibel**
> ""It might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Laurento Esquibel: ""President Smolak, His Majesty is referring to the creati..."*)

### Węzeł `[92]`
Mówca: **Laurento Esquibel**
> ""President Smolak, His Majesty is referring to the creation of a secure corridor through Wehlen. Derdian pilgrims would be able to pass into Sordland using this route and this route only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[93]`
Mówca: **Wiktor Smolak (R)**
> ""Keeping your Golcondists from fraternizing with ours. Yes, I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor = true"*)

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""It has yet to be implemented in Morella. But I have high hopes for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Wiktor Smolak (R): ""Keeping your Golcondists from fraternizing with ours. Ye..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Jorga Azmal: ""It has yet to be implemented in Morella. But I have high..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3"*)

### Węzeł `[98]`
Mówca: **Jorga Azmal**
> ""I did not agree to the idea before, and I do not understand why it is being proposed again now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Wiktor Smolak (R): ""Sounds like a ringing endorsement, Supreme Wiseman.""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Jorga Azmal: ""I did not agree to the idea before, and I do not underst..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Jorga Azmal: ""Prime Minister Saltana did not agree to the idea. I myse..."*)

### Węzeł `[102]`
Mówca: **Wiktor Smolak (R)**
> ""Sounds like a ringing endorsement, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor = true"*)

### Węzeł `[103]`
Mówca: **Jorga Azmal**
> ""Prime Minister Saltana did not agree to the idea. I myself was open to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Wiktor Smolak (R): ""Keeping your Golcondists from fraternizing with ours. Ye..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Deyr solutions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "Deyr solutions"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""The Derdians don't have to pass through Wehlen to reach ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if Rizia oversees the security of some kind of prayer corridor through Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Laurento Esquibel: ""Yes, that's one idea my department had.""*)

### Węzeł `[112]`
Mówca: **Laurento Esquibel**
> ""Yes, that's one idea my department had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Laurento Esquibel: ""We would plot a route through Wehlen known as 'St. Wruhe..."*)

### Węzeł `[113]`
Mówca: **Laurento Esquibel**
> ""We would plot a route through Wehlen known as 'St. Wruhec's Corridor'. Derdian pilgrims would be able to pass into Sordland using this route and this route only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Laurento Esquibel: ""Rizia would be responsible for the route's security.""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower > 250"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower > 250)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower > 250`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Laurento Esquibel: ""We have the military manpower to make sure the route is ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower > 250)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] > 250) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Laurento Esquibel: ""Unfortunately, we can't spare the military manpower to e..."*)

### Węzeł `[117]`
Mówca: **Laurento Esquibel**
> ""Unfortunately, we can't spare the military manpower to ensure the security of the route.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Laurento Esquibel: ""But we have the budget to contract an independent securi..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[121]`
Mówca: **Laurento Esquibel**
> ""We have the military manpower to make sure the route is secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[122]`
Mówca: **Laurento Esquibel**
> ""Rizia would be responsible for the route's security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Jorga Azmal: ""So long as your forces were able to keep Wehlen from blo..."*)

### Węzeł `[123]`
Mówca: **Jorga Azmal**
> ""So long as your forces were able to keep Wehlen from blocking our journey, I would agree to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Wiktor Smolak (R): ""Keeping your Golcondists from fraternizing with ours. Ye..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Laurento Esquibel: ""Or we can contract an independent security company.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[127]`
Mówca: **Laurento Esquibel**
> ""Or we can contract an independent security company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[128]`
Mówca: **Laurento Esquibel**
> ""But we have the budget to contract an independent security company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[129]`
Mówca: **Wiktor Smolak (R)**
> ""Well... yes, there is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Wiktor Smolak (R): ""We want Derdia to buy our oil.""*)

### Węzeł `[130]`
Mówca: **Wiktor Smolak (R)**
> ""We want Derdia to buy our oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[131]`
Mówca: **Wiktor Smolak (R)**
> ""We are still suffering the effects of the GRACE embargo on us, among other sanctions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Jorga Azmal: ""It is no secret that Derdia needs energy, Mr. President.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Wiktor Smolak (R): ""We are still suffering the effects of the GRACE embargo ..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Wiktor Smolak (R): ""We have been the subject of unfair sanctions. But we hav..."*)

### Węzeł `[135]`
Mówca: **Wiktor Smolak (R)**
> ""We have been the subject of unfair sanctions. But we have plenty of energy to spare for the right customer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Jorga Azmal: ""It is no secret that Derdia needs energy, Mr. President.""*)

### Węzeł `[136]`
Mówca: **Jorga Azmal**
> ""It is no secret that Derdia needs energy, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)

### Węzeł `[137]`
Mówca: **Jorga Azmal**
> ""All the more so since Rizia failed to deliver on its energy promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Fail..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fa..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Jorga Azmal: ""All the more so since Rizia failed to deliver on its ene..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true"*)

### Węzeł `[141]`
Mówca: **Wiktor Smolak (R)**
> ""Ha! That's Rizia for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Jorga Azmal: ""But we cannot afford the infrastructure that such an agr..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Fail..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Fa..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Wiktor Smolak (R): ""Ha! That's Rizia for you.""*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Jorga Azmal: ""But we cannot afford the infrastructure that such an agr..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Jorga Azmal: ""Although not as much as we used to, thanks to our recent..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Jorga Azmal: ""But we cannot afford the infrastructure that such an agr..."*)

### Węzeł `[148]`
Mówca: **Jorga Azmal**
> ""Although not as much as we used to, thanks to our recent deal with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Jorga Azmal: ""But we cannot afford the infrastructure that such an agr..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom would be very happy to supply the expertise and infrastructure for an oil pipeline between your two nations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[150]`
Mówca: **Jorga Azmal**
> ""But we cannot afford the infrastructure that such an agreement would require.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player_Romus: ""My kingdom would be very happy to supply the expertise a..."*)
  - -> `[151]` (*Player_Romus: ""Perhaps you could supply Wehlen with missiles to raise t..."*)
  - -> `[153]` (*Player_Romus: ""If Wehlen is so desperate to sell oil, they should pay f..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you could supply Wehlen with missiles to raise the needed funds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Wiktor Smolak (R): ""No offense, Your Majesty, but Wehlen has no need for Der..."*)

### Węzeł `[152]`
Mówca: **Wiktor Smolak (R)**
> ""No offense, Your Majesty, but Wehlen has no need for Derdian missiles. Have you seen our arsenal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Laurento Esquibel: ""Your Majesty, Rizia should consider funding this pipelin..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Wehlen is so desperate to sell oil, they should pay for the pipeline themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Wiktor Smolak (R): ""I can agree to fund part of it. But not all.""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Wiktor Smolak (R): ""If we were that desperate, Your Majesty, you would have ..."*)

### Węzeł `[157]`
Mówca: **Wiktor Smolak (R)**
> ""I can agree to fund part of it. But not all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[158]`
Mówca: **Wiktor Smolak (R)**
> ""Wehlen will also happily chip in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Wiktor Smolak (R): ""Wehlen will also happily chip in.""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Laurento Esquibel: ""Between our two nations, we can definitely afford this.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Laurento Esquibel: ""Even then, I am not certain Rizia can afford it.""*)

### Węzeł `[165]`
Mówca: **Laurento Esquibel**
> ""Between our two nations, we can definitely afford this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[166]`
Mówca: **Laurento Esquibel**
> ""Even then, I am not certain Rizia can afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Laurento Esquibel: ""We can definitely afford that.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Laurento Esquibel: ""I am not certain Rizia can afford it.""*)

### Węzeł `[170]`
Mówca: **Laurento Esquibel**
> ""We can definitely afford that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[171]`
Mówca: **Laurento Esquibel**
> ""I am not certain Rizia can afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[172]`
Mówca: **Laurento Esquibel**
> ""Unfortunate. It could've been a pivotal step forward in the South Merkopan alliance we are building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[173]`
Mówca: **Laurento Esquibel**
> ""Such a deal could be a pivotal step forward in the South Merkopan alliance we are building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[174]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, Rizia should consider funding this pipeline. If we can afford it, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[175]`
Mówca: **Wiktor Smolak (R)**
> ""If we were that desperate, Your Majesty, you would have had Zille back five years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Laurento Esquibel: ""Your Majesty, Rizia should consider funding this pipelin..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Let's get creative. There must be something that Wehlen ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Wiktor Smolak (R): ""Well... yes, there is.""*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower > 250"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Laurento Esquibel: ""Yes, I've looked into the possibility. It would go from ..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here is my solution.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == true` AND `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Jorga Azmal), `[54]` (Jorga Azmal), `[63]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Both Azmal and Smolak leaned forward to listen to me."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == true || RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || ..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true |..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == true || RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""Here is my solution.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == true || RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Narrator**
> "Both Azmal and Smolak leaned forward to listen to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaD..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaD..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.Countr..."*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[204]` (*Player_Romus: ""Your nations must practice trust and cooperation. Rememb..."*)
  - -> `[208]` (*Player_Romus: ""You must fight a Derdian Duel of Generosity.""*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaD..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && Rizi..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""We will fund a secure prayer corridor from Derdia throug..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[190]`
**[WYBÓR GRACZA: ""We will fund a secure prayer corridor from Derdia through Wehlen to Sordland." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""We will fund a secure prayer corridor from Derdia through Wehlen to Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA: ""We will send troops to oversee the security of a Golcondist prayer corridor through Wehlen." [-250 Manpower]"]** — Mówca: **Player_Romus**
> ""We will send troops to oversee the security of a Golcondist prayer corridor through Wehlen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Military_Manpower > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaD..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && Rizi..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Military_Manpower > 250`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""We will send troops to oversee the security of a Golcond..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Military_Manpower > 250)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Military_Manpower"] > 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.CountryRelation_Sordland_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.Countr..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.Coun..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.CountryRelation_Sordland_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Ships"] >= 1  and  Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""We will create a sea route for Golcondist pilgrims to re..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.CountryRelation_Sordland_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Ships"] >= 1  and  Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
**[WYBÓR GRACZA: ""We will create a sea route for Golcondist pilgrims to reach Sordland without having to cross into Wehlen." [-1 Ships]"]** — Mówca: **Player_Romus**
> ""We will create a sea route for Golcondist pilgrims to reach Sordland without having to cross into Wehlen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Military_Ships"] >= 1  and  Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true && RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == ..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport =..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true && RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""Together with Wehlen, we will fund an oil pipeline betwe..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true && RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Together with Wehlen, we will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Together with Wehlen, we will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""We will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""We will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2` AND `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your nations must practice trust and cooperation. Remember, we all pray to the same God.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Neither of them looked satisfied."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player_Romus: ""We will fund an oil pipeline between Wehlen and Derdia. ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must fight a Derdian Duel of Generosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Wiktor Smolak's eyes lit up with glee. He stood up and st..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "Wiktor Smolak's eyes lit up with glee. He stood up and started punching the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Wiktor Smolak (R): ""I've always wanted to do one of these! Will you be your ..."*)

### Węzeł `[210]`
Mówca: **Wiktor Smolak (R)**
> ""I've always wanted to do one of these! Will you be your own champion, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Jorga Azmal: ""No! Both of you will stop insulting myself and my religi..."*)

### Węzeł `[211]`
Mówca: **Jorga Azmal**
> ""No! Both of you will stop insulting myself and my religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""I am sorry Rizia could not have been more helpful.""*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[305]` (*Player_Romus: ""I hope you can still assure us a safe return of the Zill..."*)
  - -> `[304]` (*Player_Romus: ""It was nonetheless a pleasure to see you both.""*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Neither of them looked satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Wiktor Smolak (R): ""We didn't need to come to Rizia to hear that.""*)

### Węzeł `[213]`
Mówca: **Wiktor Smolak (R)**
> ""We didn't need to come to Rizia to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Jorga Azmal: ""This was a waste of both of our time.""*)

### Węzeł `[214]`
Mówca: **Jorga Azmal**
> ""This was a waste of both of our time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""I am sorry Rizia could not have been more helpful.""*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[305]` (*Player_Romus: ""I hope you can still assure us a safe return of the Zill..."*)
  - -> `[304]` (*Player_Romus: ""It was nonetheless a pleasure to see you both.""*)

### Węzeł `[215]`
Mówca: **Wiktor Smolak (R)**
> ""Wehlen accepts, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Success = true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower -= 250; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Ships -= 1; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimSeaRoute = true; RiziaDLCSupport.News_Turn09_G_PrayerSeaRoute = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Ships"] = Variable["RiziaDLC.Resources_Military_Ships"] - 1;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimSeaRoute"] = true;
Variable["RiziaDLCSupport.News_Turn09_G_PrayerSeaRoute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Wiktor Smolak (R): ""Wehlen accepts, Your Majesty!""*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Wehlen", "Progre..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Wehlen", "Progre..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEff..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Wiktor Smolak (R): ""Hrm. That's the best you can do?""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[224]`
Mówca: **Jorga Azmal**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true"*)
  - -> `[226]` (*Player_Romus: ""I thank the Lord for watching over today's talks.""*)
  - -> `[225]` (*Player_Romus: ""You will shake hands.""*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will shake hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "Smolak eagerly reached out his hand. Azmal shook it."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank the Lord for watching over today's talks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Jorga Azmal: ""Praise be to He who unites the universe.""*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: ""Now bring the khisha.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now bring the khisha.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco"] == true`
- **Kontekst wejściowy (poprzednik):** `[224]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "A Wehzek khisha pipe was standing in the corner of the ro..."*)

### Węzeł `[231]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[240]` (*Player_Romus: ""Unfortunately, yes.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[231]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority -= 1"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 1)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""It is. Take it or leave it." [-1 Authority]"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Romus: ""If it helps, Rizia will allocate additional funding towa..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[239]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[231]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Wiktor Smolak (R)), `[243]` (Wiktor Smolak (R)), `[257]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "They both shook their heads."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[243]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[240]` (*Player_Romus: ""Unfortunately, yes.""*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[243]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority -= 1"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 1)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player_Romus: ""It is. Take it or leave it." [-1 Authority]"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""If it helps, Rizia will allocate additional funding towa..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[243]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower -= 250; RiziaDLCSupp..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower -= 250; RiziaDLCSupp..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEff..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Wiktor Smolak (R): ""Hrm. That's the best you can do?""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower -= 250; RiziaDLCSupp..."*)

### Węzeł `[257]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[240]` (*Player_Romus: ""Unfortunately, yes.""*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[257]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority -= 1"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 1)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""It is. Take it or leave it." [-1 Authority]"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""If it helps, Rizia will allocate additional funding towa..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[257]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships -= 1; RiziaDLCSupport.J..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships -= 1; RiziaDLCSupport.J..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEff..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Wiktor Smolak (R): ""Hrm. That's the best you can do?""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Ships -= 1; RiziaDLCSupport.J..."*)

### Węzeł `[271]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_D..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[240]` (*Player_Romus: ""Unfortunately, yes.""*)

### Węzeł `[272]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 1  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false`
- **Kontekst wejściowy (poprzednik):** `[271]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority -= 1"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_D..."*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player_Romus: ""It is. Take it or leave it." [-1 Authority]"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 4)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""If it helps, Rizia will allocate additional funding towa..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[279]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[271]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 2"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; Ri..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; Ri..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEff..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Wiktor Smolak (R): ""Hrm. That's the best you can do?""*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; Ri..."*)

### Węzeł `[285]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_D..."*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[240]` (*Player_Romus: ""Unfortunately, yes.""*)

### Węzeł `[286]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-2 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 2  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false`
- **Kontekst wejściowy (poprzednik):** `[285]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority -= 2"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_D..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 2  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player_Romus: ""It is. Take it or leave it." [-2 Authority]"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 2  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player_Romus: ""If it helps, Rizia will allocate additional funding towa..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[293]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[285]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; Ri..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; Ri..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffor..."*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEff..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Wiktor Smolak (R): ""Hrm. That's the best you can do?""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; Ri..."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "They both shook their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Wiktor Smolak (R): ""Then our efforts today were in vain.""*)

### Węzeł `[300]`
Mówca: **Wiktor Smolak (R)**
> ""Then our efforts today were in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Jorga Azmal: ""Halaita.""*)

### Węzeł `[301]`
Mówca: **Jorga Azmal**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""I am sorry Rizia could not have been more helpful.""*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[305]` (*Player_Romus: ""I hope you can still assure us a safe return of the Zill..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry Rizia could not have been more helpful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Jorga Azmal), `[214]` (Jorga Azmal), `[301]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Wiktor Smolak (R): ""It's not your fault, Your Majesty.""*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this will not impact our efforts to form the South Merkopan Alliance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Kontekst wejściowy (poprzednik):** `[211]` (Jorga Azmal), `[214]` (Jorga Azmal), `[301]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was nonetheless a pleasure to see you both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Jorga Azmal), `[214]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Wiktor Smolak (R): ""Anytime, Your Majesty.""*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you can still assure us a safe return of the Zille territory, Mr. Smolak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Jorga Azmal), `[214]` (Jorga Azmal), `[301]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Wiktor Smolak (R): ""Of course, Your Majesty.""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Jorga Azmal: ""Two failed mediations in one day? That is truly not a go..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Jorga Azmal: ""We will see about that.""*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Jorga Azmal: ""Your willingness to help Derdia and Morella shows that y..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)

### Węzeł `[312]`
Mówca: **Jorga Azmal**
> ""Your willingness to help Derdia and Morella shows that your efforts are in good faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; Rizi..."*)

### Węzeł `[313]`
Mówca: **Jorga Azmal**
> ""Two failed mediations in one day? That is truly not a good omen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; Rizi..."*)

### Węzeł `[314]`
Mówca: **Wiktor Smolak (R)**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Wiktor Smolak (R): ""A deal with Derdia would have been a mere bonus.""*)

### Węzeł `[315]`
Mówca: **Wiktor Smolak (R)**
> ""A deal with Derdia would have been a mere bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: ""I hope this will not impact our efforts to form the Sout..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Wiktor Smolak (R)**
> ""It's not your fault, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[320]`
Mówca: **Wiktor Smolak (R)**
> ""Anytime, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Jorga Azmal: ""Two failed mediations in one day. The Lord has not bless..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Jorga Azmal: ""You have both failed the Golcondists. You will be judged..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Jorga Azmal: ""I thank you nonetheless for your help with Morella.""*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)

### Węzeł `[327]`
Mówca: **Jorga Azmal**
> ""I thank you nonetheless for your help with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; Rizi..."*)

### Węzeł `[328]`
Mówca: **Jorga Azmal**
> ""Two failed mediations in one day. The Lord has not blessed Rizia with the gift of diplomacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; Rizi..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_DerdiaWehlenMediation_Success = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Jorga Azmal: ""Halaita.""*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Failed = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Wiktor Smolak (R): ""Sorry to cut this party short, but I really must be going.""*)

### Węzeł `[331]`
Mówca: **Jorga Azmal**
> ""We will see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; Rizi..."*)

### Węzeł `[332]`
Mówca: **Jorga Azmal**
> ""You have both failed the Golcondists. You will be judged poorly for it at the end of your days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; Rizi..."*)

### Węzeł `[333]`
Mówca: **Narrator**
> "Smolak eagerly reached out his hand. Azmal shook it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Wiktor Smolak (R): ""Now. I must be going.""*)

### Węzeł `[334]`
Mówca: **Narrator**
> "A Wehzek khisha pipe was standing in the corner of the room. An aide moved it to our table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Wiktor Smolak (R): ""How thoughtful of Your Majesty! But I really must be goi..."*)

### Węzeł `[335]`
Mówca: **Wiktor Smolak (R)**
> ""How thoughtful of Your Majesty! But I really must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[336]`
Mówca: **Jorga Azmal**
> ""Praise be to He who unites the universe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Wiktor Smolak (R): ""Such modesty. All praise must go to King Romus!""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player_Romus: ""I hope this means I can count on both of your countries'..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this means I can count on both of your countries' cooperation in the formation of a South Merkopan alliance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Kontekst wejściowy (poprzednik):** `[224]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Wiktor Smolak (R): ""Very gladly. Together, we will make Rumburg regret its d..."*)

### Węzeł `[341]`
Mówca: **Wiktor Smolak (R)**
> ""Very gladly. Together, we will make Rumburg regret its decision to mess with us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "Laurento swallowed."*)

### Węzeł `[342]`
Mówca: **Wiktor Smolak (R)**
> ""Such modesty. All praise must go to King Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Wiktor Smolak (R): ""Now. I must be going.""*)

### Węzeł `[343]`
Mówca: **Wiktor Smolak (R)**
> ""I'm up to my elbows in paperwork for the Zille transition. My citizens have so many concerns. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player_Romus: ""I look forward to that day, President Smolak.""*)
  - -> `[347]` (*Player_Romus: ""You had better not be planning any last-minute surprises.""*)
  - -> `[348]` (*Player_Romus: ""Rest assured that Rizia shall make the transition as smo..."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "Laurento swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Wiktor Smolak (R): ""Now. I must be going.""*)

### Węzeł `[345]`
Mówca: **Wiktor Smolak (R)**
> ""Now. I must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to that day, President Smolak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Wiktor Smolak (R)), `[377]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "He bowed and left the suite."*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had better not be planning any last-minute surprises.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Wiktor Smolak (R)), `[377]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Wiktor Smolak (R): ""Me? Never.""*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured that Rizia shall make the transition as smooth as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Wiktor Smolak (R)), `[377]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Wiktor Smolak (R): ""There is no doubt in my mind.""*)

### Węzeł `[349]`
Mówca: **Wiktor Smolak (R)**
> ""Me? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "He bowed and left the suite."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "He bowed and left the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)

### Węzeł `[351]`
Mówca: **Wiktor Smolak (R)**
> ""There is no doubt in my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "He bowed and left the suite."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true"*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Jorga Azmal: ""I am truly grateful for your help today, Your Majesty. I..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)

### Węzeł `[355]`
Mówca: **Jorga Azmal**
> ""I am truly grateful for all your help today, Your Majesty. Thanks to Rizia, the great Republic of Derdia shall finally be brought out of isolation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Halaita.""*)
  - -> `[363]` (*Player_Romus: ""Together, we shall take on the world.""*)
  - -> `[364]` (*Player_Romus: ""It was my pleasure.""*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Jorga Azmal: ""I am truly grateful for all your help today, Your Majest..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Jorga Azmal: ""I am grateful for your help today, Your Majesty. Thanks ..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Jorga Azmal), `[362]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[360]`
Mówca: **Jorga Azmal**
> ""I am truly grateful for your help today, Your Majesty. I would never have thought Wehlen would be a more cooperative partner than Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player_Romus: ""Life is full of surprises, Supreme Wiseman.""*)
  - -> `[365]` (*Player_Romus: ""Wiktor is an unusual fellow. But he holds true to his wo..."*)
  - -> `[363]` (*Player_Romus: ""Together, we shall take on the world.""*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Life is full of surprises, Supreme Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[362]`
Mówca: **Jorga Azmal**
> ""I am grateful for your help today, Your Majesty. Thanks to Rizia, the great Republic of Derdia shall finally be brought out of isolation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Halaita.""*)
  - -> `[363]` (*Player_Romus: ""Together, we shall take on the world.""*)
  - -> `[364]` (*Player_Romus: ""It was my pleasure.""*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we shall take on the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Jorga Azmal), `[360]` (Jorga Azmal), `[362]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my pleasure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Jorga Azmal), `[362]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wiktor is an unusual fellow. But he holds true to his word.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[366]`
Mówca: **Wiktor Smolak (R)**
> ""I'm up to my elbows in paperwork for the Zille transition. My citizens have so many concerns. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""I look forward to that day, President Smolak.""*)
  - -> `[368]` (*Player_Romus: ""You had better not be planning any last-minute surprises.""*)
  - -> `[369]` (*Player_Romus: ""Rest assured that Rizia shall make the transition as smo..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to that day, President Smolak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "He bowed as Laurento escorted him out of the suite. I sat..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had better not be planning any last-minute surprises.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Wiktor Smolak (R): ""Me? Never.""*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured that Rizia shall make the transition as smooth as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Wiktor Smolak (R): ""There is no doubt in my mind.""*)

### Węzeł `[370]`
Mówca: **Wiktor Smolak (R)**
> ""Me? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "He bowed as Laurento escorted him out of the suite. I sat..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "He bowed as Laurento escorted him out of the suite. I sat alone with Azmal for a long minute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[372]`
Mówca: **Wiktor Smolak (R)**
> ""There is no doubt in my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "He bowed as Laurento escorted him out of the suite. I sat..."*)

### Węzeł `[373]`
Mówca: **Wiktor Smolak (R)**
> ""Sorry to cut this party short, but I really must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Wiktor Smolak (R): ""I'm up to my elbows in paperwork for the Zille transitio..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Wiktor Smolak (R): ""I'm working hard to conclude our agreed-upon transfer fo..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Wiktor Smolak (R): ""I'm up to my elbows in paperwork for the Zille transitio..."*)

### Węzeł `[377]`
Mówca: **Wiktor Smolak (R)**
> ""I'm working hard to conclude our agreed-upon transfer for Zille. There are a few paperwork challenges left but all is going splendidly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player_Romus: ""I look forward to that day, President Smolak.""*)
  - -> `[347]` (*Player_Romus: ""You had better not be planning any last-minute surprises.""*)
  - -> `[348]` (*Player_Romus: ""Rest assured that Rizia shall make the transition as smo..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true"*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth = true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia = true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Wiktor Smolak (R): ""Wehlen accepts, Your Majesty!""*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Wiktor Smolak (R): ""Wehlen accepts, Your Majesty!""*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Wiktor Smolak (R): ""Wehlen accepts, Your Majesty!""*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Laurento Esquibel: ""Unfortunate. It could've been a pivotal step forward in ..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Laurento Esquibel: ""Unfortunate. But surely there's another way forward.""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Laurento Esquibel: ""Such a deal could be a pivotal step forward in the South..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Laurento Esquibel: ""Brokering a connection between Wehlen and Derdia could b..."*)

### Węzeł `[390]`
Mówca: **Laurento Esquibel**
> ""Unfortunate. But surely there's another way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[391]`
Mówca: **Laurento Esquibel**
> ""Brokering a connection between Wehlen and Derdia could be beneficial for everyone involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Deyr solutions]"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Wehlen", "Progress_Construction_WehlenPipeline");
ScheduleProgress("Progress_Construction_WehlenPipeline", 1);`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Wehlen","Progress_Construction_WehlenPipeline");
ScheduleProgress("Progress_Construction_WehlenPipeline", 1);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil = true"*)
