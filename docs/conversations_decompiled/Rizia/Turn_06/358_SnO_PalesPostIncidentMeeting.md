# Rizia/Turn 6/SnO_PalesPostIncidentMeeting

- **ID konwersacji:** `358`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/358_SnO_PalesPostIncidentMeeting.md`
- **Liczba węzłów dialogowych:** 847
- **Liczba wyborów gracza:** 258

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Rumburg_Hostile`
- `RiziaDLC.CountryRelation_Rumburg_Unfriendly`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Incident_Naval_FocusAidOnValero`
- `RiziaDLC.Incident_Naval_FreeShips`
- `RiziaDLC.Incident_Naval_NoRescue`
- `RiziaDLC.Incident_Naval_RescueBoth`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg`
- `RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed`
- `RiziaDLC.PostIncident_Border_JointInvestigation`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.War_Incident_Naval`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Pales_PostIncident_Deal_25`
- `RiziaDLC.Pales_PostIncident_Deal_50`
- `RiziaDLC.Pales_PostIncident_Deal_Cede`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PostIncident_Border_JointInvestigation`
- `RiziaDLC.PostIncident_Border_ReleasedSoldiers`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Military_PalesianWarDeployment`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn06_Pales_ListenedToDemands`
- `RiziaDLCSupport.News_Turn06_G_PalesWarStart`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentNoDeal`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentTalkBreakdown`
- `RiziaDLCSupport.News_Turn06_RH_PalesWarStart`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentNoDeal`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentTalkBreakdown`
- `RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales`
- `RiziaDLCSupport.News_Turn06_V_PalesWarStart`
- `RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`
- `RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **"Shake his hand."** | `[16]` **Narrator**: "He extended his hand for a hands..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "He stared at me, brow furrowed." |
| `[18]` | **"Leave his hand hanging."** | `[16]` **Narrator**: "He extended his hand for a hands..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Axel Reinhart**: ""You're not even going to bother..." |
| `[44]` | **""Orchestrated incident? It was your soldiers that went inside and occupied a fort.""** | `[28]` **Axel Reinhart**: ""...Whatever you intend to do. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Axel Reinhart**: ""And it was the Rizian Army that..."<br>`[75]` **Axel Reinhart**: ""We know that your soldiers inci..." |
| `[45]` | **""Hold on a second. According to our reports, your soldiers shot first. And I seem ..."** | `[28]` **Axel Reinhart**: ""...Whatever you intend to do. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Axel Reinhart**: ""So you decided to kill every si..."<br>`[76]` **Axel Reinhart**: ""And you're going to claim we sh..." |
| `[46]` | **""Believe me, I'm on the same boat as you. Our reports suggest that your soldiers s..."** | `[28]` **Axel Reinhart**: ""...Whatever you intend to do. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Axel Reinhart**: ""Looking for answers? After you ..."<br>`[56]` **Axel Reinhart**: ""Your reports *suggest* utter li..." |
| `[57]` | **""Not at all. I am merely stating our stance, Your Grace.""** | `[118]` **Axel Reinhart**: ""Are you here to threaten me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Axel Reinhart**: ""I see that, Your Majesty. It is..." |
| `[58]` | **""Thank you for having us...""** | `[15]` **Axel Reinhart**: ""I wish I could say your visit t..."<br>`[266]` **Axel Reinhart**: ""I wish I could say your visit t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "He extended his hand for a hands..." |
| `[59]` | **""I hope we can sort this problem out today, Your Grace.""** | `[15]` **Axel Reinhart**: ""I wish I could say your visit t..."<br>`[266]` **Axel Reinhart**: ""I wish I could say your visit t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "He extended his hand for a hands..." |
| `[60]` | **""Duke Reinhart.""** | `[15]` **Axel Reinhart**: ""I wish I could say your visit t..."<br>`[266]` **Axel Reinhart**: ""I wish I could say your visit t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "He extended his hand for a hands..." |
| `[61]` | **"Don't say anything."** | `[15]` **Axel Reinhart**: ""I wish I could say your visit t..."<br>`[266]` **Axel Reinhart**: ""I wish I could say your visit t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "He extended his hand for a hands..." |
| `[62]` | **"Don't interrupt."** | `[26]` **Axel Reinhart**: ""So please. Listen to me very ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Axel Reinhart**: ""If you think I'd let Rizia use ..."<br>`[34]` **Axel Reinhart**: ""You not only cancelled your dea..." |
| `[63]` | **""No. I'm not going to let you dictate anything. You're going to listen to me now.""** | `[26]` **Axel Reinhart**: ""So please. Listen to me very ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "He looked at me, discomfort and ..." |
| `[78]` | **""The deal wasn't in the best interests of the Rizian people. We will cede our righ..."** | `[35]` **Axel Reinhart**: ""Please help me understand, *You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Axel Reinhart**: ""Rizia has no right to block acc..." |
| `[79]` | **""Rizia is laying claim to the entirety of the Aureus field. And frankly, I don't t..."** | `[35]` **Axel Reinhart**: ""Please help me understand, *You..."<br>`[74]` **Axel Reinhart**: ""Please help me understand, *You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Axel Reinhart**: ""Rizia has no right to do that, ..." |
| `[80]` | **""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I ..."** | `[35]` **Axel Reinhart**: ""Please help me understand, *You..."<br>`[74]` **Axel Reinhart**: ""Please help me understand, *You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Duke Reinhart raised an eyebrow." |
| `[81]` | **""We will not recognize the biased and unjustified resolution of the AN. Lespia and..."** | `[74]` **Axel Reinhart**: ""Please help me understand, *You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Axel Reinhart**: ""Look at what you are saying, Yo..." |
| `[85]` | **""Let's get our facts straight, Your Grace. Your ships were warned but they not onl..."** | `[35]` **Axel Reinhart**: ""Please help me understand, *You..."<br>`[74]` **Axel Reinhart**: ""Please help me understand, *You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Axel Reinhart**: ""We are not the side who fired a..." |
| `[90]` | **""The deal wasn't in the best interests of the Rizian people. We will cede our righ..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`<br>`Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[72]` **Axel Reinhart**: ""Rizia has no right to block acc..." |
| `[91]` | **""I have decided to take the entirety of the Aureus field. And frankly, I don't thi..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[102]` **Axel Reinhart**: ""Rizia has no right to do that, ..." |
| `[92]` | **""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I ..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[108]` **Narrator**: "Duke Reinhart raised an eyebrow." |
| `[93]` | **""We will not recognize the biased and unjustified resolution of the AN. Lespia and..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`<br>`Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[113]` **Axel Reinhart**: ""Look at what you are saying, Yo..." |
| `[94]` | **""Your ships were warned. Not only did they ignore that warning, they rammed into o..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `Variable["RiziaDLC.War_Incident_Naval"] == true` | *Brak zmian stanu* | `[116]` **Axel Reinhart**: ""I refuse to even respond to tha..." |
| `[98]` | **""We believe that this was an orchestrated incident to incite instability. I am not..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false` | *Brak zmian stanu* | `[215]` **Axel Reinhart**: ""So you decided to kill every si..."<br>`[218]` **Axel Reinhart**: ""You may not have falsified the ..." |
| `[99]` | **""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I ..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false` | *Brak zmian stanu* | `[219]` **Narrator**: "Duke Reinhart raised an eyebrow." |
| `[100]` | **""Your soldiers went inside Rizia and occupied a fort. Is this not an act of war, Y..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false` | *Brak zmian stanu* | `[216]` **Axel Reinhart**: ""And it was the Rizian Army that..."<br>`[75]` **Axel Reinhart**: ""We know that your soldiers inci..." |
| `[101]` | **""There is a lot of misinformation going about. There are conflicting reports on wh..."** | `[89]` **Narrator**: "He looked at me, discomfort and ..." | `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false` | *Brak zmian stanu* | `[208]` **Axel Reinhart**: ""Looking for answers? After you ..."<br>`[217]` **Axel Reinhart**: ""Your reports *suggest* utter li..." |
| `[125]` | **""It's true, it was my decision to blockade the field. But the incident wouldn't ha..."** | `[118]` **Axel Reinhart**: ""Are you here to threaten me?""<br>`[124]` **Axel Reinhart**: ""So tell me, Your Majesty. What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Axel Reinhart**: ""Are you not going to accept any..." |
| `[126]` | **""It was an accident, Your Grace. Rizia, by no means, wanted to escalate the tensio..."** | `[124]` **Axel Reinhart**: ""So tell me, Your Majesty. What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Axel Reinhart**: ""You allowed our sailors to die ..."<br>`[154]` **Axel Reinhart**: ""I find it difficult to believe,..." |
| `[127]` | **""Our stance is clear. Aureus lies inside our borders and anyone who enters that te..."** | `[118]` **Axel Reinhart**: ""Are you here to threaten me?""<br>`[124]` **Axel Reinhart**: ""So tell me, Your Majesty. What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Axel Reinhart**: ""Are you not going to accept any..." |
| `[128]` | **""We are all deeply saddened by the incident. I'd like to offer our sympathies and ..."** | `[124]` **Axel Reinhart**: ""So tell me, Your Majesty. What ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Axel Reinhart**: ""You allowed our sailors to die ..."<br>`[156]` **Axel Reinhart**: ""Thank you, Your Majesty."" |
| `[130]` | **""It was an accident, Your Grace. Rizia, by no means, wanted to escalate the tensio..."** | `[118]` **Axel Reinhart**: ""Are you here to threaten me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Axel Reinhart**: ""I refuse to accept your comment..." |
| `[131]` | **""We are all deeply saddened by the incident. I'd like to offer sympathies and apol..."** | `[118]` **Axel Reinhart**: ""Are you here to threaten me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[764]` **Axel Reinhart**: ""Don't mock me, Your Majesty. Co..." |
| `[158]` | **""Yes. And we are all deeply saddened by the incident. I'd like to offer our sympat..."** | `[155]` **Axel Reinhart**: ""Is this going to be Rizia's off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Axel Reinhart**: ""You allowed our sailors to die ..."<br>`[156]` **Axel Reinhart**: ""Thank you, Your Majesty."" |
| `[160]` | **""I hope to decide that after today's meeting.""** | `[155]` **Axel Reinhart**: ""Is this going to be Rizia's off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Axel Reinhart**: ""Rizia had better have something..." |
| `[161]` | **""Our stance is clear. Aureus lies inside our borders and anyone who enters that te..."** | `[155]` **Axel Reinhart**: ""Is this going to be Rizia's off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Axel Reinhart**: ""Are you not going to accept any..." |
| `[165]` | **""We did our best to save your officers, but we couldn't reach them in time.""** | `[159]` **Narrator**: "He had no expression on his face." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Axel Reinhart**: ""Oh, please. Then why did you ca..." |
| `[166]` | **""We had to focus our aid on our flagship that was damaged almost beyond repair. Th..."** | `[159]` **Narrator**: "He had no expression on his face." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Axel Reinhart**: ""I understand. Rizian lives seem..." |
| `[167]` | **""What do you want me to offer you? I am willing to do what it takes to preserve pe..."** | `[157]` **Axel Reinhart**: ""But Pales is expecting more tha..."<br>`[159]` **Narrator**: "He had no expression on his face."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "He straightened his back." |
| `[168]` | **""Of course not. Your ship rammed into our vessel and sank. Rizia has nothing to do..."** | `[162]` **Axel Reinhart**: ""Are you not going to accept any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "Suddenly he bursted out in hyste..." |
| `[169]` | **""Not for retaliating for your attack against our flagship. Pales is the one that e..."** | `[162]` **Axel Reinhart**: ""Are you not going to accept any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Axel Reinhart**: ""Then I have nothing else to say..." |
| `[170]` | **""I will. However, Pales must understand and respect Rizia's stance on Aureus.""** | `[162]` **Axel Reinhart**: ""Are you not going to accept any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Axel Reinhart**: ""No. I will not allow Rizia to t..." |
| `[171]` | **""We will not accept responsibility for retaliating for your attack against our fla..."** | `[142]` **Axel Reinhart**: ""Is this Rizia's official stance..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Axel Reinhart**: ""Then I have nothing else to say..." |
| `[173]` | **""Yes, Your Grace.""** | `[142]` **Axel Reinhart**: ""Is this Rizia's official stance..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Axel Reinhart**: ""Then I have nothing else to say..." |
| `[174]` | **""It doesn't have to be.""** | `[142]` **Axel Reinhart**: ""Is this Rizia's official stance..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Axel Reinhart**: ""No. I will not allow Rizia to t..." |
| `[180]` | **""Nobody wants a war, Your Grace. I am here to reach a mutual understanding with you.""** | `[139]` **Axel Reinhart**: ""You are pushing me into a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Axel Reinhart**: ""You allowed our sailors to die ..."<br>`[200]` **Axel Reinhart**: ""You'd better have something to ..." |
| `[181]` | **""Now you seem to be threatening me. And I don't like where this is going.""** | `[139]` **Axel Reinhart**: ""You are pushing me into a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Axel Reinhart**: ""Nor do I."" |
| `[182]` | **""Perhaps we can still reach an agreement. But Pales must understand and respect Ri..."** | `[139]` **Axel Reinhart**: ""You are pushing me into a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Axel Reinhart**: ""No. I will not allow Rizia to t..." |
| `[186]` | **""Where is Vina?""** | `[26]` **Axel Reinhart**: ""So please. Listen to me very ca..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[187]` **Narrator**: "He looked annoyed when I disrupt..." |
| `[191]` | **""Okay. Let's discuss.""** | `[157]` **Axel Reinhart**: ""But Pales is expecting more tha..."<br>`[163]` **Axel Reinhart**: ""Rizia had better have something..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "He straightened his back." |
| `[192]` | **""There's nothing else I can offer you.""** | `[157]` **Axel Reinhart**: ""But Pales is expecting more tha..."<br>`[163]` **Axel Reinhart**: ""Rizia had better have something..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Axel Reinhart**: ""Then I have nothing else to say..." |
| `[201]` | **""You have to trust me, Your Grace.""** | `[195]` **Axel Reinhart**: ""These are not the actions of a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Axel Reinhart**: ""Then you have to prove it, Your..." |
| `[202]` | **""I assure you, we want peace. But if you keep pushing us, we are ready for anything.""** | `[195]` **Axel Reinhart**: ""These are not the actions of a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Axel Reinhart**: ""Rizia will no longer dictate an..." |
| `[203]` | **""We don't need to be enemies. Please understand the predicament I'm in. I cannot l..."** | `[195]` **Axel Reinhart**: ""These are not the actions of a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Axel Reinhart**: ""Rizia will no longer dictate an..." |
| `[204]` | **""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I ..."** | `[28]` **Axel Reinhart**: ""...Whatever you intend to do. Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "Duke Reinhart raised an eyebrow." |
| `[225]` | **""No. I'm only here to take my daughter home to Rizia.""** | `[118]` **Axel Reinhart**: ""Are you here to threaten me?"" | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[230]` **Axel Reinhart**: ""And then what, Your Majesty?"" |
| `[229]` | **""Don't worry, Your Grace. As long as Vina and I can leave Pales in peace, there wi..."** | `[139]` **Axel Reinhart**: ""You are pushing me into a corne..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[237]` **Axel Reinhart**: ""You claim peace and you're stil..." |
| `[235]` | **""Regardless of who shot first, your soldiers went inside Rizia and occupied a cast..."** | `[77]` **Axel Reinhart**: ""So please tell me, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Axel Reinhart**: ""Regardless of who shot first?"" |
| `[236]` | **""I'd like to know the same, Duke Reinhart. The incident at our border is deeply re..."** | `[77]` **Axel Reinhart**: ""So please tell me, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Axel Reinhart**: ""Peaceful resolution? When Rizia..." |
| `[238]` | **""Nobody wants a war, Your Grace. I am here to reach a mutual understanding with you.""** | `[175]` **Axel Reinhart**: ""We will stand alone if need be...."<br>`[257]` **Axel Reinhart**: ""I don't think you want to find ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Axel Reinhart**: ""You allowed our sailors to die ..."<br>`[200]` **Axel Reinhart**: ""You'd better have something to ..." |
| `[239]` | **""Do you think Pales can stand against Rizia?""** | `[175]` **Axel Reinhart**: ""We will stand alone if need be...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Axel Reinhart**: ""I don't think you want to find ..." |
| `[243]` | **""You've made your point, Your Grace. I don't intend to pursue any aggression. Rizi..."** | `[175]` **Axel Reinhart**: ""We will stand alone if need be...."<br>`[257]` **Axel Reinhart**: ""I don't think you want to find ..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[237]` **Axel Reinhart**: ""You claim peace and you're stil..." |
| `[244]` | **""Enough of this. Do you want reconciliation or not?""** | `[175]` **Axel Reinhart**: ""We will stand alone if need be...."<br>`[257]` **Axel Reinhart**: ""I don't think you want to find ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Axel Reinhart**: ""Rizia will no longer dictate an..." |
| `[245]` | **""It doesn't matter now, Your Grace. The fact is that is now part of the negotiatio..."** | `[164]` **Axel Reinhart**: ""Oh, please. Then why did you ca..."<br>`[179]` **Axel Reinhart**: ""And why did you capture our shi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Axel Reinhart**: ""Rizia will no longer dictate an..." |
| `[246]` | **""We did not capture anything. Your sailors will be released after the vessels are ..."** | `[164]` **Axel Reinhart**: ""Oh, please. Then why did you ca..."<br>`[179]` **Axel Reinhart**: ""And why did you capture our shi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Axel Reinhart**: ""It sounds like they're being he..." |
| `[247]` | **""There are consequences for rash actions, Your Grace. They ignored our warnings an..."** | `[164]` **Axel Reinhart**: ""Oh, please. Then why did you ca..."<br>`[179]` **Axel Reinhart**: ""And why did you capture our shi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Axel Reinhart**: ""Exactly, Your Majesty. There ar..." |
| `[258]` | **""You're wrong. I intend to find out.""** | `[257]` **Axel Reinhart**: ""I don't think you want to find ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "He paused for a moment. His face..." |
| `[267]` | **""The reports we received can be deceptive, and I fear we are both victims of a lar..."** | `[77]` **Axel Reinhart**: ""So please tell me, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Axel Reinhart**: ""Defend your sovereignty? Or exp..." |
| `[277]` | **""Appearances can be deceptive, and I fear we are both victims of a larger game. It..."** | `[271]` **Axel Reinhart**: ""You must understand how this ap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Axel Reinhart**: ""Defend your sovereignty? Or exp..." |
| `[278]` | **""I understand. But I must assure you. I am here with peaceful intentions, Your Gra..."** | `[271]` **Axel Reinhart**: ""You must understand how this ap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "He sighed." |
| `[279]` | **""How about my perspective? I was told it was your soldiers who initiated a firefig..."** | `[271]` **Axel Reinhart**: ""You must understand how this ap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Axel Reinhart**: ""Defend your sovereignty? Or exp..." |
| `[280]` | **""Those reports are not accurate, Duke Reinhart. Rizia has no interest in provoking..."** | `[270]` **Axel Reinhart**: ""Defend your sovereignty? Or exp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Axel Reinhart**: ""Perceived as hostile? So, we ar..."<br>`[311]` **Axel Reinhart**: ""Perceived as hostile? So, we ar..." |
| `[281]` | **""And why would I believe the Palesian reports?""** | `[270]` **Axel Reinhart**: ""Defend your sovereignty? Or exp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Axel Reinhart**: ""You know the same goes for me, ..." |
| `[284]` | **""Let's get our facts straight, Your Grace. Our reports suggest otherwise. You can'..."** | `[77]` **Axel Reinhart**: ""So please tell me, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Axel Reinhart**: ""I am to believe Rizian reports?..." |
| `[285]` | **""What would we gain from this, Your Grace?""** | `[270]` **Axel Reinhart**: ""Defend your sovereignty? Or exp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Axel Reinhart**: ""I don't know..."" |
| `[296]` | **""It was interpreted as an occupation by the army and they responded accordingly. I..."** | `[293]` **Axel Reinhart**: ""So, how can I trust the words o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Axel Reinhart**: ""An occupation?"" |
| `[297]` | **""Duke Reinhart, the positioning of our troops is purely defensive. The real questi..."** | `[293]` **Axel Reinhart**: ""So, how can I trust the words o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Axel Reinhart**: ""Provocative? It is common for p..." |
| `[298]` | **""Impulsive actions? The real question is, why did Palesian forces decide to enter ..."** | `[293]` **Axel Reinhart**: ""So, how can I trust the words o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Axel Reinhart**: ""They were caught in the open wh..." |
| `[299]` | **""I am filled with regret about this whole thing. I am here to listen to your conce..."** | `[293]` **Axel Reinhart**: ""So, how can I trust the words o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Axel Reinhart**: ""I want to trust you but Rizian ..." |
| `[303]` | **""Of course you have a right to secure your borders. Just the same way as we do.""** | `[301]` **Axel Reinhart**: ""Provocative? It is common for p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Axel Reinhart**: ""Rizia responded disproportionat..." |
| `[304]` | **""Securing borders is one thing, Duke, but reports indicate an aggressive stance fr..."** | `[301]` **Axel Reinhart**: ""Provocative? It is common for p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Axel Reinhart**: ""Miscommunication? You speak as ..." |
| `[305]` | **""I'm not saying that, Your Grace. The real question is, why did Palesian forces de..."** | `[301]` **Axel Reinhart**: ""Provocative? It is common for p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Axel Reinhart**: ""They were caught in the open wh..." |
| `[306]` | **""Only according to the Palesian reports.""** | `[300]` **Axel Reinhart**: ""They were caught in the open wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Axel Reinhart**: ""Do you really believe I am afte..." |
| `[307]` | **""Refuge? They did not surrender when they were surrounded, Your Grace. They were n..."** | `[300]` **Axel Reinhart**: ""They were caught in the open wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Axel Reinhart**: ""Do you really believe I am afte..." |
| `[312]` | **""Of course. They will be allowed to leave immediately.""** | `[295]` **Axel Reinhart**: ""If you want to have a dialogue,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"]...` | `[335]` **Axel Reinhart**: ""Good."" |
| `[313]` | **""Well... That depends on the outcome of our meeting, doesn't it?""** | `[295]` **Axel Reinhart**: ""If you want to have a dialogue,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Axel Reinhart**: ""You cannot threaten Pales any l..." |
| `[314]` | **""I'm afraid that cannot happen. They need to surrender to us, and at the very leas..."** | `[295]` **Axel Reinhart**: ""If you want to have a dialogue,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Axel Reinhart**: ""You cannot threaten Pales any l..." |
| `[321]` | **""Your reports say one thing, Duke, but ours indicate an aggressive stance from you..."** | `[300]` **Axel Reinhart**: ""They were caught in the open wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Axel Reinhart**: ""Miscommunication? You speak as ..." |
| `[322]` | **""It looks like a very deliberate choice, Your Grace. Pales is the land of *paleacc..."** | `[300]` **Axel Reinhart**: ""They were caught in the open wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Axel Reinhart**: ""Are you claiming Pales wants to..." |
| `[326]` | **""I'm not brushing anything aside. I suspect it could be an inside job.""** | `[317]` **Axel Reinhart**: ""This cannot be brushed aside as..."<br>`[354]` **Axel Reinhart**: ""This cannot be brushed aside as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Axel Reinhart**: ""An inside job? From Rizia?"" |
| `[327]` | **""I do not and I never would underestimate the gravity of the situation, Your Grace..."** | `[317]` **Axel Reinhart**: ""This cannot be brushed aside as..."<br>`[354]` **Axel Reinhart**: ""This cannot be brushed aside as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Axel Reinhart**: ""A noble sentiment, but how do I..." |
| `[328]` | **""Are you going to threaten me, Your Grace? I'm doing my best to reach an understan..."** | `[317]` **Axel Reinhart**: ""This cannot be brushed aside as..."<br>`[354]` **Axel Reinhart**: ""This cannot be brushed aside as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Axel Reinhart**: ""For good reason."" |
| `[339]` | **""And yet, my reports suggest the exact opposite. That it was your forces who seeme..."** | `[330]` **Axel Reinhart**: ""A noble sentiment, but how do I..."<br>`[338]` **Axel Reinhart**: ""And how do I reconcile it with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Axel Reinhart**: ""We cannot rely on biased perspe..." |
| `[340]` | **""This disparity in reports is precisely why a joint investigation is critical. We ..."** | `[330]` **Axel Reinhart**: ""A noble sentiment, but how do I..."<br>`[338]` **Axel Reinhart**: ""And how do I reconcile it with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Axel Reinhart**: ""Biased perspective? Are you sug..." |
| `[342]` | **""I'm not brushing anything aside. I suspect it could be an inside job.""** | `[341]` **Axel Reinhart**: ""This cannot be brushed aside as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Axel Reinhart**: ""An inside job? From Rizia?"" |
| `[343]` | **""I do not and I never would underestimate the gravity of the situation, Your Grace..."** | `[341]` **Axel Reinhart**: ""This cannot be brushed aside as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Axel Reinhart**: ""A noble sentiment, but how do I..." |
| `[344]` | **""Are you going to threaten me, Your Grace? I'm doing my best to reach an understan..."** | `[341]` **Axel Reinhart**: ""This cannot be brushed aside as..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Axel Reinhart**: ""For good reason."" |
| `[345]` | **""What would we gain from this, Your Grace? This happened right before the signing ..."** | `[330]` **Axel Reinhart**: ""A noble sentiment, but how do I..."<br>`[338]` **Axel Reinhart**: ""And how do I reconcile it with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Axel Reinhart**: ""Sabotage, you say?"" |
| `[349]` | **""Are you suggesting that Rizia is fabricating its reports?""** | `[348]` **Axel Reinhart**: ""We cannot rely on biased perspe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Axel Reinhart**: ""Not at all. But it is a possibi..." |
| `[350]` | **""I agree. And there's nothing we would gain from this. This happened right before ..."** | `[348]` **Axel Reinhart**: ""We cannot rely on biased perspe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Axel Reinhart**: ""Sabotage, you say?"" |
| `[351]` | **""I suspect it could be an inside job.""** | `[348]` **Axel Reinhart**: ""We cannot rely on biased perspe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Axel Reinhart**: ""An inside job? From Rizia?"" |
| `[356]` | **""Not fabricating, Your Grace, but there is always a lens through which situations ..."** | `[346]` **Axel Reinhart**: ""Biased perspective? Are you sug..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Axel Reinhart**: ""The 'objective truth' is a slip..." |
| `[357]` | **""No. I'm not pointing fingers at Pales. It could be from within Rizia as well.""** | `[346]` **Axel Reinhart**: ""Biased perspective? Are you sug..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Axel Reinhart**: ""Confusion and paranoia. This pe..." |
| `[358]` | **""It is a possibility. How can either of us be certain?""** | `[346]` **Axel Reinhart**: ""Biased perspective? Are you sug..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Axel Reinhart**: ""Looking for certainty is a slip..." |
| `[365]` | **""I suppose it could be an inside job.""** | `[364]` **Axel Reinhart**: ""I'm merely pointing out the bia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Axel Reinhart**: ""So, you also think that your re..." |
| `[366]` | **""Each side has a bias, Your Grace, we don't have a monopoly over it. Our goal shou..."** | `[364]` **Axel Reinhart**: ""I'm merely pointing out the bia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Axel Reinhart**: ""The 'objective truth' is a slip..." |
| `[367]` | **""No. I won't allow you to point fingers at Rizia. It could be from within Pales as..."** | `[353]` **Axel Reinhart**: ""So, you also think that your re..."<br>`[364]` **Axel Reinhart**: ""I'm merely pointing out the bia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Axel Reinhart**: ""What are you insinuating at?"" |
| `[368]` | **""I don't want to believe that but it is a possibility.""** | `[353]` **Axel Reinhart**: ""So, you also think that your re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Axel Reinhart**: ""It is a possibility, indeed."" |
| `[369]` | **""They are as trustworthy as the Palesian reports.""** | `[353]` **Axel Reinhart**: ""So, you also think that your re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Axel Reinhart**: ""What do we about it then, Your ..." |
| `[370]` | **""I'm starting to suspect that.""** | `[353]` **Axel Reinhart**: ""So, you also think that your re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Axel Reinhart**: ""It is a possibility, indeed."" |
| `[374]` | **""Of course. As soon as Vina leaves Pales with me.""** | `[295]` **Axel Reinhart**: ""If you want to have a dialogue,..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"]...` | `[335]` **Axel Reinhart**: ""Good."" |
| `[378]` | **""They will be released. As soon as Vina leaves Pales with me.""** | `[333]` **Axel Reinhart**: ""If you do not release them, it ..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"]...` | `[335]` **Axel Reinhart**: ""Good."" |
| `[379]` | **""Fine. They will be released immediately.""** | `[333]` **Axel Reinhart**: ""If you do not release them, it ..." | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"]...` | `[335]` **Axel Reinhart**: ""Good."" |
| `[380]` | **""No. Pales cannot dictate that.""** | `[333]` **Axel Reinhart**: ""If you do not release them, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Axel Reinhart**: ""You are the side that initiated..." |
| `[383]` | **""On the contrary, Duke Reinhart. Delay benefits neither of us. The longer this ten..."** | `[363]` **Axel Reinhart**: ""Your call for a joint investiga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Axel Reinhart**: ""There is great risk, indeed. Bu..." |
| `[384]` | **""Your Grace, we need to act swiftly and decisively to prevent a conflict that woul..."** | `[363]` **Axel Reinhart**: ""Your call for a joint investiga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[386]` **Axel Reinhart**: ""Catastrophic, indeed. But can y..." |
| `[385]` | **""What is your suggestion, Your Grace?""** | `[363]` **Axel Reinhart**: ""Your call for a joint investiga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Axel Reinhart**: ""Neutral international observers..." |
| `[389]` | **""I don't think either of us can assure that, Your Grace.""** | `[386]` **Axel Reinhart**: ""Catastrophic, indeed. But can y..."<br>`[387]` **Axel Reinhart**: ""There is great risk, indeed. Bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Axel Reinhart**: ""No. But neutral international o..." |
| `[390]` | **""I propose we involve neutral international observers in the investigation. Let th..."** | `[386]` **Axel Reinhart**: ""Catastrophic, indeed. But can y..."<br>`[387]` **Axel Reinhart**: ""There is great risk, indeed. Bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Axel Reinhart**: ""I agree. That could be a way to..." |
| `[391]` | **""Regardless of the investigation, Rizia wants to continue with our previous deal a..."** | `[386]` **Axel Reinhart**: ""Catastrophic, indeed. But can y..."<br>`[387]` **Axel Reinhart**: ""There is great risk, indeed. Bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Axel Reinhart**: ""And what if the investigations ..." |
| `[393]` | **""Agreed.""** | `[388]` **Axel Reinhart**: ""Neutral international observers..."<br>`[392]` **Axel Reinhart**: ""I agree. That could be a way to..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Axel Reinhart**: ""And what if the investigations ..." |
| `[394]` | **""That would work, Your Grace. However, their findings must be accepted by both Riz..."** | `[388]` **Axel Reinhart**: ""Neutral international observers..."<br>`[392]` **Axel Reinhart**: ""I agree. That could be a way to..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Axel Reinhart**: ""And what if the investigations ..." |
| `[399]` | **""Yes. And I deeply regret what happened.""** | `[398]` **Axel Reinhart**: ""Are you going to listen to our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Axel Reinhart**: ""You'd better have something to ..." |
| `[400]` | **""I'm listening.""** | `[398]` **Axel Reinhart**: ""Are you going to listen to our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "He straightened his back." |
| `[401]` | **""No, Your Grace. You are making a mistake with your harsh attitude. I'm done liste..."** | `[398]` **Axel Reinhart**: ""Are you going to listen to our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "He paused for a moment. His face..." |
| `[403]` | **"Keep listening."** | `[254]` **Axel Reinhart**: ""Either you will listen to our d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Axel Reinhart**: ""...Or... Well... Let's not even..." |
| `[404]` | **""I understand...""** | `[254]` **Axel Reinhart**: ""Either you will listen to our d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Axel Reinhart**: ""Good."" |
| `[405]` | **""Or what, Your Grace?""** | `[254]` **Axel Reinhart**: ""Either you will listen to our d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Axel Reinhart**: ""Let's not imagine that scenario."" |
| `[413]` | **""That would be a cause for war.""** | `[412]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Axel Reinhart**: ""Your attack was the cause for e..." |
| `[414]` | **""You cannot afford to keep your navy at the field at all times, Your Grace.""** | `[412]` **Axel Reinhart**: ""We will not bow down against yo..." | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[419]` **Axel Reinhart**: ""Oh, you don't know our new capa..." |
| `[415]` | **""You intended to escalate the situation further, after all...""** | `[412]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Axel Reinhart**: ""Your attack was the cause for e..." |
| `[416]` | **""I will let the world know about your stance. Let's see who they'll support.""** | `[412]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Axel Reinhart**: ""You seem confident... As if we ..."<br>`[417]` **Axel Reinhart**: ""You seem confident despite Rizi..." |
| `[425]` | **""Neutral is a strong word, Your Grace. The international community too have their ..."** | `[388]` **Axel Reinhart**: ""Neutral international observers..."<br>`[423]` **Axel Reinhart**: ""No. But neutral international o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Axel Reinhart**: ""There is no other way to resolv..." |
| `[426]` | **""Exactly. Whatever the findings, we shall abide by them and take the necessary ste..."** | `[392]` **Axel Reinhart**: ""I agree. That could be a way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Axel Reinhart**: ""And what if the investigations ..." |
| `[429]` | **""Then we face those revelations together and act in the interests of peace and jus..."** | `[424]` **Axel Reinhart**: ""And what if the investigations ..."<br>`[427]` **Axel Reinhart**: ""And what if the investigations ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Axel Reinhart**: ""You might be right."" |
| `[430]` | **""If our expectations from the start are like this, how do we resolve this issue? I..."** | `[424]` **Axel Reinhart**: ""And what if the investigations ..."<br>`[427]` **Axel Reinhart**: ""And what if the investigations ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Axel Reinhart**: ""You might be right."" |
| `[431]` | **""Then we will act accordingly, Your Grace.""** | `[424]` **Axel Reinhart**: ""And what if the investigations ..."<br>`[427]` **Axel Reinhart**: ""And what if the investigations ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Axel Reinhart**: ""That doesn't inspire confidence..." |
| `[449]` | **""This disparity in reports is precisely why a joint investigation is critical. We ..."** | `[447]` **Axel Reinhart**: ""What are you insinuating at?""<br>`[448]` **Axel Reinhart**: ""What do we about it then, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Axel Reinhart**: ""Biased perspective? Are you sug..." |
| `[450]` | **""Look, Your Grace. I think there's someone else behind this incident. We can't poi..."** | `[447]` **Axel Reinhart**: ""What are you insinuating at?""<br>`[448]` **Axel Reinhart**: ""What do we about it then, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Narrator**: "He straightened his back." |
| `[452]` | **""This seems like a plan to sabotage our rights on the Aureus. We made a deal, Duke..."** | `[447]` **Axel Reinhart**: ""What are you insinuating at?""<br>`[448]` **Axel Reinhart**: ""What do we about it then, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Axel Reinhart**: ""What?"" |
| `[453]` | **""Simply nothing.""** | `[448]` **Axel Reinhart**: ""What do we about it then, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Axel Reinhart**: ""What?"" |
| `[454]` | **""I'm just saying it could be anyone. We simply cannot jump to conclusions.""** | `[447]` **Axel Reinhart**: ""What are you insinuating at?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Axel Reinhart**: ""What do we about it then, Your ..." |
| `[456]` | **""We cannot rule out Pales, Your Grace. I don't think I trust your words.""** | `[447]` **Axel Reinhart**: ""What are you insinuating at?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Axel Reinhart**: ""What?"" |
| `[460]` | **""Yes." [Begin Investigations]"** | `[459]` **Axel Reinhart**: ""So you accept to conduct joint ..."<br>`[787]` **Axel Reinhart**: ""So do you accept to conduct joi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PostIncident_Border_JointInvestigation...` | `[463]` **Axel Reinhart**: ""Good."" |
| `[461]` | **""No. I don't see a point in it anymore.""** | `[459]` **Axel Reinhart**: ""So you accept to conduct joint ..."<br>`[787]` **Axel Reinhart**: ""So do you accept to conduct joi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Axel Reinhart**: ""Then your deal is off the table..." |
| `[466]` | **""You are right.""** | `[428]` **Axel Reinhart**: ""There is no other way to resolv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Axel Reinhart**: ""So you accept to conduct joint ..." |
| `[467]` | **""I'm sorry but I don't support this. There are other powers at play and I cannot h..."** | `[428]` **Axel Reinhart**: ""There is no other way to resolv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Axel Reinhart**: ""So you accept to conduct joint ..." |
| `[468]` | **""Fine. I understand.""** | `[428]` **Axel Reinhart**: ""There is no other way to resolv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Axel Reinhart**: ""So you accept to conduct joint ..." |
| `[470]` | **""Absolutely not.""** | `[438]` **Axel Reinhart**: ""To ensure that, we will proceed..."<br>`[442]` **Axel Reinhart**: ""To ensure that, you will cede h..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "He paused for a moment. His face..." |
| `[475]` | **""Anything for peace." [Accept the deal] [-2 Budget]"** | `[438]` **Axel Reinhart**: ""To ensure that, we will proceed..."<br>`[442]` **Axel Reinhart**: ""To ensure that, you will cede h..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;...`<br>*(+1 skryptów)* | `[533]` **Axel Reinhart**: ""That's great to hear!"" |
| `[476]` | **""Anything for peace." [Accept the deal] [-1 Budget]"** | `[438]` **Axel Reinhart**: ""To ensure that, we will proceed..."<br>`[442]` **Axel Reinhart**: ""To ensure that, you will cede h..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 1`<br>`(Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)) == false` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;...`<br>*(+1 skryptów)* | `[533]` **Axel Reinhart**: ""That's great to hear!"" |
| `[477]` | **""I can agree to the gas field but not the reparations.""** | `[438]` **Axel Reinhart**: ""To ensure that, we will proceed..."<br>`[442]` **Axel Reinhart**: ""To ensure that, you will cede h..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Axel Reinhart**: ""I think we can make it work, Yo..."<br>`[487]` **Axel Reinhart**: ""I think we can make it work, Yo..."<br>*(oraz 2 innych odgałęzień)* |
| `[478]` | **""I can agree to the reparations but not the gas field.""** | `[438]` **Axel Reinhart**: ""To ensure that, we will proceed..."<br>`[442]` **Axel Reinhart**: ""To ensure that, you will cede h..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Axel Reinhart**: ""That will not do, Your Majesty...."<br>`[490]` **Axel Reinhart**: ""That will not do, Your Majesty...."<br>*(oraz 1 innych odgałęzień)* |
| `[496]` | **""Absolutely not. We are not giving up anything.""** | `[495]` **Axel Reinhart**: ""You must, at the very least, ag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "He paused for a moment. His face..." |
| `[497]` | **""Fine. I agree to it." [Agree to 50%] [-1 Budget]"** | `[495]` **Axel Reinhart**: ""You must, at the very least, ag..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealF...` | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[498]` | **""But we won't, Your Grace. Your attitude made me change my mind about Aureus. Rizi..."** | `[524]` **Axel Reinhart**: ""You must claim responsibility f..."<br>`[525]` **Axel Reinhart**: ""I think we can make it work, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Axel Reinhart**: ""What!?"" |
| `[499]` | **""Deal." [Accept the deal]"** | `[487]` **Axel Reinhart**: ""I think we can make it work, Yo..." | *Brak (Dostępna bezwarunkowo)* | `-- RIZIA CEDES 25% GAS FIELD;`<br>`Variable["RiziaDLC.Pales_PostIncident_Deal_25"] = true;`<br>*(+1 skryptów)* | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[500]` | **""Deal." [Accept the deal]"** | `[482]` **Axel Reinhart**: ""I think we can make it work, Yo..."<br>`[574]` **Axel Reinhart**: ""If you cede the field to us off..." | *Brak (Dostępna bezwarunkowo)* | `-- RIZIA CEDES GAS FIELD;`<br>`Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`<br>*(+1 skryptów)* | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[505]` | **""Absolutely not. We are not giving up that field.""** | `[504]` **Axel Reinhart**: ""You must, at the very least, ag..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "He paused for a moment. His face..." |
| `[506]` | **""Fine. I agree to it." [-1 Budget]"** | `[504]` **Axel Reinhart**: ""You must, at the very least, ag..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...`<br>`Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealF...` | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[513]` | **""Absolutely not. We are not giving up that field.""** | `[512]` **Axel Reinhart**: ""You must, at the very least, re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "He paused for a moment. His face..." |
| `[514]` | **""Fine. I agree to it." [Agree to deal]"** | `[512]` **Axel Reinhart**: ""You must, at the very least, re..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`<br>`Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealF...` | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[526]` | **""Deal." [Accept the deal]"** | `[525]` **Axel Reinhart**: ""I think we can make it work, Yo..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`<br>*(+1 skryptów)* | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[527]` | **""Deal." [Accept the deal] [-2 Budget]"** | `[524]` **Axel Reinhart**: ""You must claim responsibility f..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`<br>*(+1 skryptów)* | `[517]` **Axel Reinhart**: ""That's great to hear!"" |
| `[534]` | **""Let's calm down, Your Grace. Nobody wants a war.""** | `[412]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[535]` **Axel Reinhart**: ""Rizia cannot threaten us with w..." |
| `[538]` | **""You will not get away with this.""** | `[421]` **Axel Reinhart**: ""If you really think anyone will..."<br>`[537]` **Axel Reinhart**: ""I intend to block your access t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[539]` | **""If you try to block our access, we will take it by force. This would be cause for..."** | `[421]` **Axel Reinhart**: ""If you really think anyone will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[540]` | **""If you try to block our access, we will take it by force. This is a cause for war.""** | `[537]` **Axel Reinhart**: ""I intend to block your access t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[541]` | **""Fine. Take the whole field. I couldn't care less.""** | `[421]` **Axel Reinhart**: ""If you really think anyone will..."<br>`[543]` **Axel Reinhart**: ""Pales is ready to defend what i..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[546]` **Narrator**: "He looked at me with skepticism." |
| `[544]` | **""We will not retaliate. But you are making a mistake. This will have dire conseque..."** | `[543]` **Axel Reinhart**: ""Pales is ready to defend what i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Axel Reinhart**: ""You have forced my hand, Your M..." |
| `[545]` | **""Then war it is, Your Grace.""** | `[543]` **Axel Reinhart**: ""Pales is ready to defend what i..." | *Brak (Dostępna bezwarunkowo)* | `-- WAR!;` | `[577]` **Narrator**: "A sudden spasm of fear took hold..." |
| `[549]` | **""I will cede all of our rights to Pales. We don't need to be enemies.""** | `[548]` **Axel Reinhart**: ""As long as Rizia respects our c..."<br>`[603]` **Axel Reinhart**: ""If you make the deal official, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Axel Reinhart**: ""Really? You would do that for P..." |
| `[550]` | **""I can never officially recognize that, Your Grace. But I intend to leave Pales al..."** | `[548]` **Axel Reinhart**: ""As long as Rizia respects our c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[562]` **Axel Reinhart**: ""I understand this was a difficu..." |
| `[551]` | **""There will be no more working together. Let that be clear.""** | `[548]` **Axel Reinhart**: ""As long as Rizia respects our c..."<br>`[563]` **Axel Reinhart**: ""But perhaps we can still work t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Axel Reinhart**: ""I'm sorry you came all the way ..." |
| `[556]` | **""Well... Thank you for the meeting nonetheless.""** | `[555]` **Axel Reinhart**: ""I would have rather have come t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Axel Reinhart**: ""I'm sorry you came all the way ..." |
| `[557]` | **""Thank you for nothing.""** | `[555]` **Axel Reinhart**: ""I would have rather have come t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Axel Reinhart**: ""I'm sorry you came all the way ..." |
| `[558]` | **""You know what? In the name of friendship, I'm willing to officially cede our righ..."** | `[555]` **Axel Reinhart**: ""I would have rather have come t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[559]` **Narrator**: "He looked at me with skepticism." |
| `[565]` | **"Shake his hand."** | `[564]` **Narrator**: "He stood up and reached out for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Axel Reinhart**: ""Well, then. Have a nice day, Yo..." |
| `[566]` | **"Ignore his hand."** | `[564]` **Narrator**: "He stood up and reached out for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Axel Reinhart**: ""Well, then. Have a nice day, Yo..." |
| `[568]` | **""Despite everything, Rizia is ready for that, Your Grace. You can count on us.""** | `[563]` **Axel Reinhart**: ""But perhaps we can still work t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[570]` **Axel Reinhart**: ""At least we have reached some l..." |
| `[569]` | **""We will see about that.""** | `[563]` **Axel Reinhart**: ""But perhaps we can still work t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[570]` **Axel Reinhart**: ""At least we have reached some l..." |
| `[575]` | **""Well... No I can't. Thank you for the meeting nonetheless.""** | `[574]` **Axel Reinhart**: ""If you cede the field to us off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Axel Reinhart**: ""I'm sorry you came all the way ..." |
| `[576]` | **""If you don't pull your ships back from the field... War it is, Your Grace.""** | `[555]` **Axel Reinhart**: ""I would have rather have come t..." | *Brak (Dostępna bezwarunkowo)* | `-- WAR!;` | `[577]` **Narrator**: "A sudden spasm of fear took hold..." |
| `[598]` | **""If you do anything to Vina, Pales will cease to exist, Your Grace. I promise you ..."** | `[412]` **Axel Reinhart**: ""We will not bow down against yo..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[535]` **Axel Reinhart**: ""Rizia cannot threaten us with w..." |
| `[602]` | **""Fine. Just take the whole field in exchange for Vina.""** | `[537]` **Axel Reinhart**: ""I intend to block your access t..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[603]` **Axel Reinhart**: ""If you make the deal official, ..." |
| `[604]` | **""No. I won't sign that deal. But you have to let Vina go. Otherwise it will be war.""** | `[603]` **Axel Reinhart**: ""If you make the deal official, ..." | *Brak (Dostępna bezwarunkowo)* | `-- WAR!;` | `[577]` **Narrator**: "A sudden spasm of fear took hold..." |
| `[605]` | **""Listen. I suspect this was fabricated by another player in our region. We should ..."** | `[459]` **Axel Reinhart**: ""So you accept to conduct joint ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Narrator**: "He straightened his back." |
| `[610]` | **""You can't do that.""** | `[609]` **Axel Reinhart**: ""And you know what, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Axel Reinhart**: ""Well... If you're not offering ..." |
| `[611]` | **""That would be a grand mistake.""** | `[609]` **Axel Reinhart**: ""And you know what, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Axel Reinhart**: ""Well... If you're not offering ..." |
| `[612]` | **""Look, Your Grace. I think there's someone else behind this incident. We can't poi..."** | `[609]` **Axel Reinhart**: ""And you know what, Your Majesty..."<br>`[615]` **Axel Reinhart**: ""Well... If you're not offering ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Narrator**: "He straightened his back." |
| `[613]` | **""We cannot rely solely on biased perspectives, Your Grace. We should investigate t..."** | `[609]` **Axel Reinhart**: ""And you know what, Your Majesty..."<br>`[615]` **Axel Reinhart**: ""Well... If you're not offering ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Axel Reinhart**: ""Biased perspective? Are you sug..." |
| `[619]` | **""I hope not.""** | `[618]` **Axel Reinhart**: ""I hope no more incidents will t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Axel Reinhart**: ""Well, then. Have a nice day, Yo..." |
| `[620]` | **""The responsibility falls on both of our shoulders.""** | `[618]` **Axel Reinhart**: ""I hope no more incidents will t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Axel Reinhart**: ""Well, then. Have a nice day, Yo..." |
| `[621]` | **""I won't let that happen.""** | `[618]` **Axel Reinhart**: ""I hope no more incidents will t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Axel Reinhart**: ""Well, then. Have a nice day, Yo..." |
| `[622]` | **""Agreed.""** | `[618]` **Axel Reinhart**: ""I hope no more incidents will t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Axel Reinhart**: ""Well, then. Have a nice day, Yo..." |
| `[631]` | **""That would be a cause for war.""** | `[630]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[656]` **Axel Reinhart**: ""Your attack was the cause for e..." |
| `[633]` | **""Let's calm down, Your Grace. Nobody wants a war.""** | `[630]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Axel Reinhart**: ""Rizia cannot threaten us with w..." |
| `[637]` | **""You will not get away with this.""** | `[632]` **Axel Reinhart**: ""If you really think the AN woul..."<br>`[636]` **Axel Reinhart**: ""I intend to block access to Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[638]` | **""If you try to block our access, we will take it by force. This would be cause for..."** | `[632]` **Axel Reinhart**: ""If you really think the AN woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[639]` | **""If you try to block our access, we will take it by force. This is a cause for war.""** | `[636]` **Axel Reinhart**: ""I intend to block access to Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[640]` | **""Fine. Take the whole field. I couldn't care less. I will back off from the deal.""** | `[632]` **Axel Reinhart**: ""If you really think the AN woul..."<br>`[642]` **Axel Reinhart**: ""Rizia will not extract anything..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[645]` **Narrator**: "He looked at me with skepticism." |
| `[643]` | **""You are making a mistake. This will have dire consequences for both of our countr..."** | `[642]` **Axel Reinhart**: ""Rizia will not extract anything..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[662]` **Axel Reinhart**: ""You forced my hand, Your Majesty."" |
| `[644]` | **""Then war it is, Your Grace.""** | `[642]` **Axel Reinhart**: ""Rizia will not extract anything..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[577]` **Narrator**: "A sudden spasm of fear took hold..." |
| `[650]` | **""Fine. Just take the whole field in exchange for Vina. I will back off from the de..."** | `[636]` **Axel Reinhart**: ""I intend to block access to Riz..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[646]` **Axel Reinhart**: ""Good."" |
| `[651]` | **""You cannot simply back off from the deal at the last minute like this, Your Grace.""** | `[630]` **Axel Reinhart**: ""We will not bow down against yo..." | `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false` | *Brak zmian stanu* | `[655]` **Axel Reinhart**: ""Oh, but I can, Your Majesty."" |
| `[652]` | **""You intended to escalate the situation further after all...""** | `[630]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[656]` **Axel Reinhart**: ""Your attack was the cause for e..." |
| `[653]` | **""The world will learn about how you cancelled the deal. Let's see who they'll supp..."** | `[630]` **Axel Reinhart**: ""We will not bow down against yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[654]` **Axel Reinhart**: ""You seem confident despite havi..." |
| `[660]` | **""If you do anything to Vina, Pales will cease to exist, Your Grace. I promise you ..."** | `[630]` **Axel Reinhart**: ""We will not bow down against yo..." | `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true` | *Brak zmian stanu* | `[634]` **Axel Reinhart**: ""Rizia cannot threaten us with w..." |
| `[661]` | **""Let's calm down, Your Grace. Can't we work something out? Rizia wants to keep the..."** | `[636]` **Axel Reinhart**: ""I intend to block access to Riz..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[734]` **Axel Reinhart**: ""I want Rizia to pay reparations..."<br>`[743]` **Axel Reinhart**: ""I want a neutral investigation ..." |
| `[664]` | **""Well... Thank you for the meeting nonetheless.""** | `[663]` **Axel Reinhart**: ""I would have rather achieved so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Axel Reinhart**: ""I'm sorry you came all the way ..." |
| `[665]` | **""Thank you for nothing.""** | `[663]` **Axel Reinhart**: ""I would have rather achieved so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Axel Reinhart**: ""I'm sorry you came all the way ..." |
| `[666]` | **""If you don't sign that deal, then war it is, Your Grace.""** | `[663]` **Axel Reinhart**: ""I would have rather achieved so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[577]` **Narrator**: "A sudden spasm of fear took hold..." |
| `[669]` | **""Fine. Aureus is completely yours. We don't need to be enemies.""** | `[668]` **Axel Reinhart**: ""As long as Rizia respects it, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[672]` **Axel Reinhart**: ""Then, peace will prevail."" |
| `[670]` | **""I can not force you to sign the deal, Your Grace. But I don't intend to work toge..."** | `[663]` **Axel Reinhart**: ""I would have rather achieved so..."<br>`[668]` **Axel Reinhart**: ""As long as Rizia respects it, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[673]` **Axel Reinhart**: ""So be it."" |
| `[671]` | **""You know what, Your Grace? If you go this path, expect a military response. War, ..."** | `[668]` **Axel Reinhart**: ""As long as Rizia respects it, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[577]` **Narrator**: "A sudden spasm of fear took hold..." |
| `[679]` | **""Can you give me any guarantee that you will sign the deal after the investigations?""** | `[678]` **Axel Reinhart**: ""Until we have clear answers, Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[686]` **Axel Reinhart**: ""As long as Rizia's name has bee..." |
| `[680]` | **""That's fair. I understand.""** | `[678]` **Axel Reinhart**: ""Until we have clear answers, Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Axel Reinhart**: ""Great to hear."" |
| `[681]` | **""We have invested heavily into this project, Your Grace. If you decide to sabotage..."** | `[678]` **Axel Reinhart**: ""Until we have clear answers, Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[688]` **Axel Reinhart**: ""There is no need for threats."" |
| `[682]` | **""Agreed.""** | `[678]` **Axel Reinhart**: ""Until we have clear answers, Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[683]` **Axel Reinhart**: ""Great to hear."" |
| `[689]` | **""Alright. Thank you for the meeting, Your Grace.""** | `[687]` **Axel Reinhart**: ""If Rizia's name will be cleared..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Axel Reinhart**: ""Thank you for coming to Pales."" |
| `[690]` | **""Good. You'd better not break your promise.""** | `[687]` **Axel Reinhart**: ""If Rizia's name will be cleared..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Axel Reinhart**: ""Thank you for coming to Pales."" |
| `[691]` | **""I understand.""** | `[687]` **Axel Reinhart**: ""If Rizia's name will be cleared..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Axel Reinhart**: ""Thank you for coming to Pales."" |
| `[705]` | **""I'm not going to play into your hand. Rizia is not going to be forced to offer an..."** | `[615]` **Axel Reinhart**: ""Well... If you're not offering ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Axel Reinhart**: ""Then your deal is off the table..." |
| `[706]` | **""Rumburg.""** | `[464]` **Axel Reinhart**: ""Okay... And who might that be?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[712]` **Axel Reinhart**: ""The Queen?"" |
| `[707]` | **""Lespia.""** | `[464]` **Axel Reinhart**: ""Okay... And who might that be?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[719]` **Axel Reinhart**: ""Of course you would say that."" |
| `[708]` | **""Morella.""** | `[464]` **Axel Reinhart**: ""Okay... And who might that be?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[710]` **Axel Reinhart**: ""Why would Morellans be behind t..." |
| `[709]` | **""Valgsland.""** | `[464]` **Axel Reinhart**: ""Okay... And who might that be?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[718]` **Axel Reinhart**: ""Yes... Valgsland has ambitions ..." |
| `[720]` | **""Our relationship has soured of late. I suspect my sister-in-law is trying to hass..."** | `[714]` **Axel Reinhart**: ""Are you claiming she wanted to ..."<br>`[713]` **Axel Reinhart**: ""Isn't she the one who's fuellin..." | `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true`<br>`(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false` | *Brak zmian stanu* | `[723]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[721]` | **""The amount of gas we'll gain from Aureus will have other nations begging at our f..."** | `[714]` **Axel Reinhart**: ""Are you claiming she wanted to ..."<br>`[713]` **Axel Reinhart**: ""Isn't she the one who's fuellin..." | `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false` | *Brak zmian stanu* | `[723]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[722]` | **""She is counting on Rizia to annex Pales and become more powerful -- and thus of m..."** | `[714]` **Axel Reinhart**: ""Are you claiming she wanted to ..."<br>`[713]` **Axel Reinhart**: ""Isn't she the one who's fuellin..." | `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false` | *Brak zmian stanu* | `[723]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[725]` | **""You are underestimating their new government. Prime Minister Saltana is a trouble..."** | `[711]` **Axel Reinhart**: ""Their influence and presence is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[726]` | **""They are commies, Axel. You know what they are capable of.""** | `[711]` **Axel Reinhart**: ""Their influence and presence is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[727]` | **""We are fighting against Saltana's nationalization of the Meftiem International Tr..."** | `[711]` **Axel Reinhart**: ""Their influence and presence is..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true` | *Brak zmian stanu* | `[728]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[730]` | **""You know they will come to reclaim Pales sooner or later, Your Grace. That's why ..."** | `[718]` **Axel Reinhart**: ""Yes... Valgsland has ambitions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[777]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[731]` | **""They are commies, Axel. You know what they are capable of.""** | `[718]` **Axel Reinhart**: ""Yes... Valgsland has ambitions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[777]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[732]` | **""We are a threat in their eyes. Valgsland doesn't want our countries to be close.""** | `[718]` **Axel Reinhart**: ""Yes... Valgsland has ambitions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[777]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[736]` | **""Deal." [-1 Budget]"** | `[735]` **Axel Reinhart**: ""These are my terms, Your Majesty."" | `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[686]` **Axel Reinhart**: ""As long as Rizia's name has bee..." |
| `[737]` | **""There's no way I can accept this. If you back away from our deal like this, you w..."** | `[735]` **Axel Reinhart**: ""These are my terms, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[641]` **Axel Reinhart**: ""As I already said, it is not a ..." |
| `[747]` | **""Deal.""** | `[735]` **Axel Reinhart**: ""These are my terms, Your Majesty."" | `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false` | *Brak zmian stanu* | `[686]` **Axel Reinhart**: ""As long as Rizia's name has bee..." |
| `[753]` | **""I offered you a chance for peace, Axel. But you are standing in my way.""** | `[750]` **Axel Reinhart**: ""You are no longer welcome here."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Vina_Hostage"] = true; Variable["Rizia...` | `[752]` **Narrator**: "His security quickly ushered me ..."<br>`[751]` **Axel Reinhart**: ""Goodbye, Romus. I'll take good ..." |
| `[754]` | **""We will meet again.""** | `[750]` **Axel Reinhart**: ""You are no longer welcome here."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Vina_Hostage"] = true; Variable["Rizia...` | `[752]` **Narrator**: "His security quickly ushered me ..."<br>`[751]` **Axel Reinhart**: ""Goodbye, Romus. I'll take good ..." |
| `[755]` | **""Don't worry. We will make it quick.""** | `[750]` **Axel Reinhart**: ""You are no longer welcome here."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Vina_Hostage"] = true; Variable["Rizia...` | `[752]` **Narrator**: "His security quickly ushered me ..."<br>`[751]` **Axel Reinhart**: ""Goodbye, Romus. I'll take good ..." |
| `[780]` | **""I know her well and I don't trust her one bit. I suspect my sister-in-law is tryi..."** | `[714]` **Axel Reinhart**: ""Are you claiming she wanted to ..." | `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true) == false` | *Brak zmian stanu* | `[723]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[781]` | **""We are a threat in their eyes. Morella doesn't want our countries to be close.""** | `[711]` **Axel Reinhart**: ""Their influence and presence is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[782]` | **""Just think about it, Axel. It just makes sense.""** | `[724]` **Axel Reinhart**: ""There are no reports or traces ..."<br>`[729]` **Axel Reinhart**: ""There are no reports or traces ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[785]` **Axel Reinhart**: ""No, Your Majesty."" |
| `[783]` | **""I don't have any proof.""** | `[724]` **Axel Reinhart**: ""There are no reports or traces ..."<br>`[729]` **Axel Reinhart**: ""There are no reports or traces ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[785]` **Axel Reinhart**: ""No, Your Majesty."" |
| `[784]` | **""What else do you want? That's enough proof of their meddling.""** | `[724]` **Axel Reinhart**: ""There are no reports or traces ..."<br>`[729]` **Axel Reinhart**: ""There are no reports or traces ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[785]` **Axel Reinhart**: ""No, Your Majesty."" |
| `[789]` | **""And they have been pushing over the control of Aureus through a deal with you. Ha..."** | `[776]` **Axel Reinhart**: ""Lespia is our biggest partner. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[793]` **Axel Reinhart**: ""Mr. Alvarez is surely mad about..." |
| `[790]` | **""That is precisely the point. They want you to stay reliant on them and having a s..."** | `[776]` **Axel Reinhart**: ""Lespia is our biggest partner. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[793]` **Axel Reinhart**: ""Mr. Alvarez is surely mad about..." |
| `[791]` | **""We are a threat in their eyes. Lespia doesn't want our countries to be close. You..."** | `[776]` **Axel Reinhart**: ""Lespia is our biggest partner. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[793]` **Axel Reinhart**: ""Mr. Alvarez is surely mad about..." |
| `[792]` | **""They are the direct agents of ATO in all Eastern Merkopa. This is their plan to d..."** | `[776]` **Axel Reinhart**: ""Lespia is our biggest partner. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[797]` **Axel Reinhart**: ""I don't buy that, Your Majesty."" |
| `[794]` | **""Why wouldn't he? He has both the means and the goals to sabotage our deal. And he..."** | `[793]` **Axel Reinhart**: ""Mr. Alvarez is surely mad about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[798]` **Axel Reinhart**: ""I suppose you might be right.""<br>`[802]` **Axel Reinhart**: ""I don't know, Your Majesty. I w..." |
| `[795]` | **""Who else, Your Grace? Rizia is surely not behind this as we've already paid our s..."** | `[793]` **Axel Reinhart**: ""Mr. Alvarez is surely mad about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[798]` **Axel Reinhart**: ""I suppose you might be right.""<br>`[802]` **Axel Reinhart**: ""I don't know, Your Majesty. I w..." |
| `[796]` | **""They are puppets of the game Arcasia is playing in our region. You know how far t..."** | `[793]` **Axel Reinhart**: ""Mr. Alvarez is surely mad about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[798]` **Axel Reinhart**: ""I suppose you might be right.""<br>`[802]` **Axel Reinhart**: ""I don't know, Your Majesty. I w..." |
| `[811]` | **""Anything for peace." [-1 Budget]"** | `[810]` **Axel Reinhart**: ""I only ask of a modest sum. As ..." | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[818]` **Axel Reinhart**: ""Great. Then I believe I can mak..." |
| `[812]` | **""No, Your Grace. Absolutely out of the question.""** | `[810]` **Axel Reinhart**: ""I only ask of a modest sum. As ..."<br>`[813]` **Axel Reinhart**: ""You have to pay for the Palesia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[814]` **Axel Reinhart**: ""Then there won't be any deals."" |
| `[815]` | **""Anything for peace." [-2 Budget]"** | `[813]` **Axel Reinhart**: ""You have to pay for the Palesia..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[818]` **Axel Reinhart**: ""Great. Then I believe I can mak..." |
| `[841]` | **""I can't afford your symbolism, Duke.""** | `[810]` **Axel Reinhart**: ""I only ask of a modest sum. As ..." | `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false` | *Brak zmian stanu* | `[814]` **Axel Reinhart**: ""Then there won't be any deals."" |
| `[845]` | **""Peace is too expensive for our kingdom, Duke.""** | `[813]` **Axel Reinhart**: ""You have to pay for the Palesia..." | `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false` | *Brak zmian stanu* | `[814]` **Axel Reinhart**: ""Then there won't be any deals."" |

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
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Balancing peace and war after a crisis",..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The specter of the recent naval incident cast a long shadow over our relations. I sensed it in the mood of everyone around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the expressionless faces of the Palesian delegation with no sight of the Duke himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "No pleasantries were exchanged and no diplomatic gestures..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Our convoy drove steadily across the cobbled streets of Old Town Pales. It was my second visit to the Palesian capital since becoming King of Rizia, and the atmosphere this time was far more tense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Naval == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The specter of the recent naval incident cast a long shad..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The specter of the recent border incident cast a long sha..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The specter of the recent border incident cast a long shadow over our relations. I sensed it in the mood of everyone around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Upon our arrival to Castle Reinhart, we were greeted by t..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "No pleasantries were exchanged and no diplomatic gestures were played to the cameras. We were instead quickly ushered inside as the reporters were blocked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Nobody from my security detail nor the welcoming delegati..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Nobody from my security detail nor the welcoming delegation spoke as we entered the room where the meeting was to take place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "When Duke Reinhart entered the room, everyone else left. ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "When Duke Reinhart entered the room, everyone else left. He didn't speak a word until we were completely alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Axel Reinhart: ""King Romus. Your rushed arrival here is a testament to t..."*)

### Węzeł `[14]`
Mówca: **Axel Reinhart**
> ""King Romus. Your rushed arrival here is a testament to the gravity of our situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC..."*)

### Węzeł `[15]`
Mówca: **Axel Reinhart**
> ""I wish I could say your visit today brings me comfort, but under these circumstances, I find it hard to extend a warm welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""Thank you for having us...""*)
  - -> `[59]` (*Player_Romus: ""I hope we can sort this problem out today, Your Grace.""*)
  - -> `[60]` (*Player_Romus: ""Duke Reinhart.""*)
  - -> `[61]` (*Player_Romus_Italic: "Don't say anything."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "He extended his hand for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[18]` (*Player_Romus_Italic: "Leave his hand hanging."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "I shook his hand and we both sat down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He stared at me, brow furrowed."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Leave his hand hanging."]** — Mówca: **Player_Romus_Italic**
> "I left his hand hanging and took a seat. He followed me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Axel Reinhart: ""You're not even going to bother, eh?""*)

### Węzeł `[19]`
Mówca: **Axel Reinhart**
> ""You're not even going to bother, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Axel Reinhart: ""You dare to attack my people, then fail to show respect ..."*)

### Węzeł `[20]`
Mówca: **Axel Reinhart**
> ""You dare to attack my people, then fail to show respect to me in the very heart of our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He stared at me, brow furrowed."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Naval == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Axel Reinhart: ""If you think I'd let Rizia use an orchestrated incident ..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "He stared at me, brow furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Axel Reinhart: ""Look. I do not intend to allow Pales be pushed around by..."*)

### Węzeł `[25]`
Mówca: **Axel Reinhart**
> ""Look. I do not intend to allow Pales be pushed around by Rizia any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Axel Reinhart: ""So please. Listen to me very carefully...""*)

### Węzeł `[26]`
Mówca: **Axel Reinhart**
> ""So please. Listen to me very carefully...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[62]` (*Player_Romus_Italic: "Don't interrupt."*)
  - -> `[63]` (*Player_Romus: ""No. I'm not going to let you dictate anything. You're go..."*)

### Węzeł `[27]`
Mówca: **Axel Reinhart**
> ""If you think I'd let Rizia use an orchestrated incident as justification for, well..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Axel Reinhart: ""...Whatever you intend to do. You'd be wrong.""*)

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""...Whatever you intend to do. You'd be wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""Let's not start on the wrong foot, Your Grace. I am awar..."*)
  - -> `[44]` (*Player_Romus: ""Orchestrated incident? It was your soldiers that went in..."*)
  - -> `[45]` (*Player_Romus: ""Hold on a second. According to our reports, your soldier..."*)
  - -> `[46]` (*Player_Romus: ""Believe me, I'm on the same boat as you. Our reports sug..."*)

### Węzeł `[29]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling in your favor, you went and deployed your navy to the field -- completely going against the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Axel Reinhart: ""What right does the Rizian Navy have to block our access..."*)

### Węzeł `[30]`
Mówca: **Axel Reinhart**
> ""Is this not a declaration of war? What dialogue could you possibly be after?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Axel Reinhart: ""Please help me understand, *Your Majesty.* Because I'm h..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Axel Reinhart: ""You not only cancelled your deal at the last minute, you..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[34]`
Mówca: **Axel Reinhart**
> ""You not only cancelled your deal at the last minute, you went against international law by deploying your navy and blockading Aureus. And now you sank a Palesian ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Axel Reinhart: ""Is this not a declaration of war? What dialogue could yo..."*)

### Węzeł `[35]`
Mówca: **Axel Reinhart**
> ""Please help me understand, *Your Majesty.* Because I'm having a devil of a time making sense of your actions right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""The deal wasn't in the best interests of the Rizian peop..."*)
  - -> `[79]` (*Player_Romus: ""Rizia is laying claim to the entirety of the Aureus fiel..."*)
  - -> `[80]` (*Player_Romus: ""Let's not start on the wrong foot, Your Grace. I am awar..."*)
  - -> `[85]` (*Player_Romus: ""Let's get our facts straight, Your Grace. Your ships wer..."*)

### Węzeł `[36]`
Mówca: **Axel Reinhart**
> ""What right does the Rizian Navy have to block our access to the field? You not only went against international law, you sank a Palesian ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Axel Reinhart: ""Is this not a declaration of war? What dialogue could yo..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_Deployed..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_Deployed..."*)

### Węzeł `[40]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling against you, you went and deployed your navy to the field -- in direct violation of the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Axel Reinhart: ""What right does the Rizian Navy have to block our access..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Axel Reinhart: ""Looking for answers? After you kill every single one of ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Axel Reinhart: ""Your reports *suggest* utter lies, Your Majesty.""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Orchestrated incident? It was your soldiers that went inside and occupied a fort.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on a second. According to our reports, your soldiers shot first. And I seem to believe those reports.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, I'm on the same boat as you. Our reports suggest that your soldiers shot first. I came here to get some answers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""Looking for answers? After you kill every single one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Axel Reinhart: ""Your reports *suggest* utter lies, Your Majesty.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Axel Reinhart: ""So you decided to kill every single one of them before v..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Axel Reinhart: ""And you're going to claim we shot first?""*)

### Węzeł `[51]`
Mówca: **Axel Reinhart**
> ""So you decided to kill every single one of them before verifying any of your reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Axel Reinhart: ""And you're going to claim we shot first?""*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Axel Reinhart: ""And it was the Rizian Army that killed every single one ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[55]`
Mówca: **Axel Reinhart**
> ""And it was the Rizian Army that killed every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[56]`
Mówca: **Axel Reinhart**
> ""Your reports *suggest* utter lies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not at all. I am merely stating our stance, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Axel Reinhart: ""I see that, Your Majesty. It is a stance of aggression a..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for having us...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Axel Reinhart), `[266]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He extended his hand for a handshake."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope we can sort this problem out today, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Axel Reinhart), `[266]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He extended his hand for a handshake."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Axel Reinhart), `[266]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He extended his hand for a handshake."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I did not respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Axel Reinhart), `[266]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He extended his hand for a handshake."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "Don't interrupt."]** — Mówca: **Player_Romus_Italic**
> "I listened to his words."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not going to let you dictate anything. You're going to listen to me now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "He looked at me, discomfort and concern etched onto his h..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_Deployed..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_Deploy..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Axel Reinhart: ""Despite the AN ruling in your favor, you went and deploy..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Axel Reinhart: ""Despite the AN ruling in your favor, you insisted on mai..."*)

### Węzeł `[67]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling in your favor, you insisted on maintaining your blockade of the field -- completely going against the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Axel Reinhart: ""What right does the Rizian Navy have to block our access..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_Deployed..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_Deploy..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Axel Reinhart: ""Despite the AN ruling against you, you went and deployed..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Axel Reinhart: ""Despite the AN ruling against you, you insisted on maint..."*)

### Węzeł `[71]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling against you, you insisted on maintaining your blockade of the field -- in direct violation of the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Axel Reinhart: ""What right does the Rizian Navy have to block our access..."*)

### Węzeł `[72]`
Mówca: **Axel Reinhart**
> ""Rizia has no right to block access to Aureus, Your Majesty. This is an open attack against Pales and international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Axel Reinhart: ""Are you here to threaten me?""*)

### Węzeł `[73]`
Mówca: **Axel Reinhart**
> ""Is this not a declaration of war? What dialogue could you possibly be after?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Axel Reinhart: ""Please help me understand, *Your Majesty.* Because I'm h..."*)

### Węzeł `[74]`
Mówca: **Axel Reinhart**
> ""Please help me understand, *Your Majesty.* Because I'm having a devil of a time making sense of your actions right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""Rizia is laying claim to the entirety of the Aureus fiel..."*)
  - -> `[80]` (*Player_Romus: ""Let's not start on the wrong foot, Your Grace. I am awar..."*)
  - -> `[81]` (*Player_Romus: ""We will not recognize the biased and unjustified resolut..."*)
  - -> `[85]` (*Player_Romus: ""Let's get our facts straight, Your Grace. Your ships wer..."*)

### Węzeł `[75]`
Mówca: **Axel Reinhart**
> ""We know that your soldiers incited the incident. Our guards moved to the islet during the firefight -- simply because they were under fire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Axel Reinhart: ""So please tell me, Your Majesty. What in the hell happen..."*)

### Węzeł `[76]`
Mówca: **Axel Reinhart**
> ""And you're going to claim we shot first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[77]`
Mówca: **Axel Reinhart**
> ""So please tell me, Your Majesty. What in the hell happened at Navar Castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player_Romus: ""Let's get our facts straight, Your Grace. Our reports su..."*)
  - -> `[235]` (*Player_Romus: ""Regardless of who shot first, your soldiers went inside ..."*)
  - -> `[236]` (*Player_Romus: ""I'd like to know the same, Duke Reinhart. The incident a..."*)
  - -> `[267]` (*Player_Romus: ""The reports we received can be deceptive, and I fear we ..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The deal wasn't in the best interests of the Rizian people. We will cede our rights no longer. Your ships have to respect our claims.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Axel Reinhart: ""Rizia has no right to block access to Aureus, Your Majes..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is laying claim to the entirety of the Aureus field. And frankly, I don't think Pales can do anything about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Axel Reinhart), `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Axel Reinhart: ""Rizia has no right to do that, Your Majesty. This is an ..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Axel Reinhart), `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Duke Reinhart raised an eyebrow."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not recognize the biased and unjustified resolution of the AN. Lespia and their western sponsors manipulated the ruling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Axel Reinhart: ""Look at what you are saying, Your Majesty. The ruling wa..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Axel Reinhart: ""The international community acknowledged your claim and ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Axel Reinhart: ""Rizia has no right to block access to that field, Your M..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get our facts straight, Your Grace. Your ships were warned but they not only ignored them, our flagship was rammed into.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Axel Reinhart), `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Axel Reinhart: ""We are not the side who fired at you.""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Naval == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Naval == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[91]` (*Player_Romus: ""I have decided to take the entirety of the Aureus field...."*)
  - -> `[92]` (*Player_Romus: ""Let's not start on the wrong foot, Your Grace. I am awar..."*)
  - -> `[94]` (*Player_Romus: ""Your ships were warned. Not only did they ignore that wa..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Naval == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""We believe that this was an orchestrated incident to inc..."*)
  - -> `[100]` (*Player_Romus: ""Your soldiers went inside Rizia and occupied a fort. Is ..."*)
  - -> `[99]` (*Player_Romus: ""Let's not start on the wrong foot, Your Grace. I am awar..."*)
  - -> `[101]` (*Player_Romus: ""There is a lot of misinformation going about. There are ..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "He looked at me, discomfort and concern etched onto his handsome features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The deal wasn't in the best interests of the Rizian people. We will cede our rights no longer. Your ships have to respect our claims.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true` AND `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Rizia has no right to block ac..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have decided to take the entirety of the Aureus field. And frankly, I don't think Pales can do anything about it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Rizia has no right to do that,..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Duke Reinhart raised an eyebrow."]"*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not recognize the biased and unjustified resolution of the AN. Lespia and their western sponsors manipulated the ruling.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false` AND `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Look at what you are saying, Y..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your ships were warned. Not only did they ignore that warning, they rammed into our flagship. Did you give the order yourself?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Axel Reinhart: ""I refuse to even respond to that question, Your Majesty.""*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""The deal wasn't in the best interests of the Rizian peop..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""We will not recognize the biased and unjustified resolut..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We believe that this was an orchestrated incident to incite instability. I am not sure who is behind this, but our reports suggest it was the Palesians who shot first.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Duke Reinhart raised an eyebrow."]"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your soldiers went inside Rizia and occupied a fort. Is this not an act of war, Your Grace?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is a lot of misinformation going about. There are conflicting reports on which side shot first. I came here to get some answers.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[102]`
Mówca: **Axel Reinhart**
> ""Rizia has no right to do that, Your Majesty. This is an open attack against Pales and international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Axel Reinhart: ""Are you here to threaten me?""*)

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""Peace? You are directly responsible for sinking our ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Axel Reinhart: ""So tell me, Your Majesty. What is the stance of your kin..."*)

### Węzeł `[104]`
Mówca: **Axel Reinhart**
> ""Peace? You are directly responsible for sinking our ship and the loss of Palesian lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Axel Reinhart: ""So tell me, Your Majesty. What is the stance of your kin..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Inc..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.I..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Axel Reinhart: ""Peace? You are directly responsible for sinking our ship.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Axel Reinhart: ""Peace? You are directly responsible for sinking our ship..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Duke Reinhart raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Inc..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Rizia has no right to do that, You..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Axel Reinhart: ""Rizia has no right to do that, Your Majesty. This is an ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Rizia has no right to block access..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Axel Reinhart: ""Rizia has no right to block access to Aureus, Your Majes..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Duke Reinhart raised an eyebrow."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Duke Reinhart raised an eyebrow."*)

### Węzeł `[112]`
Mówca: **Axel Reinhart**
> ""Rizia has no right to block access to that field, Your Majesty. This is an open attack against Pales and international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Axel Reinhart: ""Are you here to threaten me?""*)

### Węzeł `[113]`
Mówca: **Axel Reinhart**
> ""Look at what you are saying, Your Majesty. The ruling was manipulated because you don't like the outcome?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Look at what you are saying, Your..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Axel Reinhart: ""Look at what you are saying, Your Majesty. The ruling wa..."*)

### Węzeł `[115]`
Mówca: **Axel Reinhart**
> ""We are not the side who fired at you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Inc..."*)

### Węzeł `[116]`
Mówca: **Axel Reinhart**
> ""I refuse to even respond to that question, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""We are not the side who fired ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""We are not the side who fired at y..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Axel Reinhart: ""We are not the side who fired at you.""*)

### Węzeł `[118]`
Mówca: **Axel Reinhart**
> ""Are you here to threaten me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[131]` (*Player_Romus: ""We are all deeply saddened by the incident. I'd like to ..."*)
  - -> `[57]` (*Player_Romus: ""Not at all. I am merely stating our stance, Your Grace.""*)
  - -> `[130]` (*Player_Romus: ""It was an accident, Your Grace. Rizia, by no means, want..."*)
  - -> `[125]` (*Player_Romus: ""It's true, it was my decision to blockade the field. But..."*)
  - -> `[127]` (*Player_Romus: ""Our stance is clear. Aureus lies inside our borders and ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Inc..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.I..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Axel Reinhart: ""Rizia is directly responsible for sinking our ship.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Axel Reinhart: ""Rizia is directly responsible for sinking our ship and t..."*)

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""Rizia is directly responsible for sinking our ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Axel Reinhart: ""So tell me, Your Majesty. What is the stance of your kin..."*)

### Węzeł `[123]`
Mówca: **Axel Reinhart**
> ""Rizia is directly responsible for sinking our ship and the loss of Palesian lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Axel Reinhart: ""So tell me, Your Majesty. What is the stance of your kin..."*)

### Węzeł `[124]`
Mówca: **Axel Reinhart**
> ""So tell me, Your Majesty. What is the stance of your kingdom? What are you trying to achieve here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""It's true, it was my decision to blockade the field. But..."*)
  - -> `[126]` (*Player_Romus: ""It was an accident, Your Grace. Rizia, by no means, want..."*)
  - -> `[127]` (*Player_Romus: ""Our stance is clear. Aureus lies inside our borders and ..."*)
  - -> `[128]` (*Player_Romus: ""We are all deeply saddened by the incident. I'd like to ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true, it was my decision to blockade the field. But the incident wouldn't have happened if your ship didn't ram into us. The damage it inflicted was extensive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Axel Reinhart), `[124]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Axel Reinhart: ""Are you not going to accept any responsibility?""*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was an accident, Your Grace. Rizia, by no means, wanted to escalate the tensions. The admirals reacted on their own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our stance is clear. Aureus lies inside our borders and anyone who enters that territory is subject to Rizian law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Axel Reinhart), `[124]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Axel Reinhart: ""Are you not going to accept any responsibility?""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are all deeply saddened by the incident. I'd like to offer our sympathies and apologies on behalf of our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[129]`
Mówca: **Axel Reinhart**
> ""The international community acknowledged your claim and rewarded you half of the entire field. What more do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Axel Reinhart: ""Rizia has no right to block access to that field, Your M..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was an accident, Your Grace. Rizia, by no means, wanted to escalate the tensions. The admirals reacted on their own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Axel Reinhart: ""I refuse to accept your comments. Don't mock me, Your Ma..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are all deeply saddened by the incident. I'd like to offer sympathies and apologies on behalf of our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Axel Reinhart: ""Don't mock me, Your Majesty. Consider your offer rejected.""*)

### Węzeł `[132]`
Mówca: **Axel Reinhart**
> ""I refuse to accept your comments. Don't mock me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[133]`
Mówca: **Axel Reinhart**
> ""You just told me about your intentions of not letting go of Aureus. You gave the order to blockade the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Axel Reinhart: ""You may regard Pales as an insignificant appendage of yo..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Axel Reinhart: ""You just told me about your intentions of not letting go..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Axel Reinhart: ""You just told me about your intentions of not respecting..."*)

### Węzeł `[137]`
Mówca: **Axel Reinhart**
> ""You just told me about your intentions of not respecting the AN's resolution. You gave the order to blockade the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Axel Reinhart: ""You may regard Pales as an insignificant appendage of yo..."*)

### Węzeł `[138]`
Mówca: **Axel Reinhart**
> ""You may regard Pales as an insignificant appendage of your own kingdom -- but you have not seen our reach in the world yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Axel Reinhart: ""You are pushing me into a corner. And I have decided not..."*)

### Węzeł `[139]`
Mówca: **Axel Reinhart**
> ""You are pushing me into a corner. And I have decided not to allow Rizia push us around any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[180]` (*Player_Romus: ""Nobody wants a war, Your Grace. I am here to reach a mut..."*)
  - -> `[181]` (*Player_Romus: ""Now you seem to be threatening me. And I don't like wher..."*)
  - -> `[182]` (*Player_Romus: ""Perhaps we can still reach an agreement. But Pales must ..."*)

### Węzeł `[140]`
Mówca: **Axel Reinhart**
> ""I see that, Your Majesty. It is a stance of aggression and war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[141]`
Mówca: **Axel Reinhart**
> ""No. I will not allow Rizia to threaten Pales like this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Axel Reinhart: ""We will stand alone if need be. But we will not bow down..."*)

### Węzeł `[142]`
Mówca: **Axel Reinhart**
> ""Is this Rizia's official stance then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""Yes, Your Grace.""*)
  - -> `[174]` (*Player_Romus: ""It doesn't have to be.""*)
  - -> `[171]` (*Player_Romus: ""We will not accept responsibility for retaliating for yo..."*)

### Węzeł `[143]`
Mówca: **Axel Reinhart**
> ""Are you not going to accept any responsibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Axel Reinhart: ""Is this Rizia's official stance then?""*)

### Węzeł `[144]`
Mówca: **Axel Reinhart**
> ""Don't expect me to believe that was an accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "He had no expression on his face."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || Riz..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Axel Reinhart: ""You allowed our sailors to die in the sea and captured o..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Axel Reinhart: ""Thank you, Your Majesty.""*)

### Węzeł `[148]`
Mówca: **Axel Reinhart**
> ""You allowed our sailors to die in the sea and captured our vessels, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Axel Reinhart: ""Don't expect me to believe you are saddened by any of th..."*)

### Węzeł `[149]`
Mówca: **Axel Reinhart**
> ""Don't expect me to believe you are saddened by any of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "He had no expression on his face."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || Riz..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Axel Reinhart: ""You allowed our sailors to die in the sea and captured o..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Axel Reinhart: ""I find it difficult to believe, Your Majesty.""*)

### Węzeł `[153]`
Mówca: **Axel Reinhart**
> ""You allowed our sailors to die in the sea and captured our vessels, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Axel Reinhart: ""Don't expect me to believe that was an accident.""*)

### Węzeł `[154]`
Mówca: **Axel Reinhart**
> ""I find it difficult to believe, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Axel Reinhart: ""Is this going to be Rizia's official stance then?""*)

### Węzeł `[155]`
Mówca: **Axel Reinhart**
> ""Is this going to be Rizia's official stance then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""Our stance is clear. Aureus lies inside our borders and ..."*)
  - -> `[160]` (*Player_Romus: ""I hope to decide that after today's meeting.""*)
  - -> `[158]` (*Player_Romus: ""Yes. And we are all deeply saddened by the incident. I'd..."*)

### Węzeł `[156]`
Mówca: **Axel Reinhart**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Axel Reinhart: ""But Pales is expecting more than an apology.""*)

### Węzeł `[157]`
Mówca: **Axel Reinhart**
> ""But Pales is expecting more than an apology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""What do you want me to offer you? I am willing to do wha..."*)
  - -> `[191]` (*Player_Romus: ""Okay. Let's discuss.""*)
  - -> `[192]` (*Player_Romus: ""There's nothing else I can offer you.""*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And we are all deeply saddened by the incident. I'd like to offer our sympathies and apologies on behalf of our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "He had no expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""We did our best to save your officers, but we couldn't r..."*)
  - -> `[166]` (*Player_Romus: ""We had to focus our aid on our flagship that was damaged..."*)
  - -> `[167]` (*Player_Romus: ""What do you want me to offer you? I am willing to do wha..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope to decide that after today's meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Axel Reinhart: ""Rizia had better have something to offer, Your Majesty. ..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our stance is clear. Aureus lies inside our borders and anyone who enters that territory is subject to Rizian law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Axel Reinhart: ""Are you not going to accept any responsibility?""*)

### Węzeł `[162]`
Mówca: **Axel Reinhart**
> ""Are you not going to accept any responsibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""I will. However, Pales must understand and respect Rizia..."*)
  - -> `[169]` (*Player_Romus: ""Not for retaliating for your attack against our flagship..."*)
  - -> `[168]` (*Player_Romus: ""Of course not. Your ship rammed into our vessel and sank..."*)

### Węzeł `[163]`
Mówca: **Axel Reinhart**
> ""Rizia had better have something to offer, Your Majesty. It is not you who will dictate this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""What do you want me to offer you? I am willing to do wha..."*)
  - -> `[191]` (*Player_Romus: ""Okay. Let's discuss.""*)
  - -> `[192]` (*Player_Romus: ""There's nothing else I can offer you.""*)

### Węzeł `[164]`
Mówca: **Axel Reinhart**
> ""Oh, please. Then why did you capture our ships? Was that also in the name of humanitarian aid?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""It doesn't matter now, Your Grace. The fact is that is n..."*)
  - -> `[246]` (*Player_Romus: ""We did not capture anything. Your sailors will be releas..."*)
  - -> `[247]` (*Player_Romus: ""There are consequences for rash actions, Your Grace. The..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We did our best to save your officers, but we couldn't reach them in time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Axel Reinhart: ""Oh, please. Then why did you capture our ships? Was that..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had to focus our aid on our flagship that was damaged almost beyond repair. There were hundreds of people on that ship, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Axel Reinhart: ""I understand. Rizian lives seem to matter more, after al..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want me to offer you? I am willing to do what it takes to preserve peace between our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Axel Reinhart), `[159]` (Narrator), `[163]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He straightened his back."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. Your ship rammed into our vessel and sank. Rizia has nothing to do with this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Suddenly he bursted out in hysterical laughter."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not for retaliating for your attack against our flagship. Pales is the one that escalated the incident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""Then I have nothing else to say. Except this.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. However, Pales must understand and respect Rizia's stance on Aureus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""No. I will not allow Rizia to threaten Pales like this, ..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not accept responsibility for retaliating for your attack against our flagship. Pales is the one that escalated the incident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""Then I have nothing else to say. Except this.""*)

### Węzeł `[172]`
Mówca: **Axel Reinhart**
> ""I understand. Rizian lives seem to matter more, after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Axel Reinhart: ""And why did you capture our ships again? Was that also a..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""Then I have nothing else to say. Except this.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't have to be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""No. I will not allow Rizia to threaten Pales like this, ..."*)

### Węzeł `[175]`
Mówca: **Axel Reinhart**
> ""We will stand alone if need be. But we will not bow down to your harassment any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[238]` (*Player_Romus: ""Nobody wants a war, Your Grace. I am here to reach a mut..."*)
  - -> `[239]` (*Player_Romus: ""Do you think Pales can stand against Rizia?""*)
  - -> `[244]` (*Player_Romus: ""Enough of this. Do you want reconciliation or not?""*)

### Węzeł `[176]`
Mówca: **Axel Reinhart**
> ""Then I have nothing else to say. Except this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Suddenly he bursted out in hysterical laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Axel Reinhart: ""I didn't expect you to come up with such nonsense.""*)

### Węzeł `[178]`
Mówca: **Axel Reinhart**
> ""I didn't expect you to come up with such nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Axel Reinhart: ""I have nothing left to say. Except this.""*)

### Węzeł `[179]`
Mówca: **Axel Reinhart**
> ""And why did you capture our ships again? Was that also an *unintentional* consequence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""It doesn't matter now, Your Grace. The fact is that is n..."*)
  - -> `[246]` (*Player_Romus: ""We did not capture anything. Your sailors will be releas..."*)
  - -> `[247]` (*Player_Romus: ""There are consequences for rash actions, Your Grace. The..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody wants a war, Your Grace. I am here to reach a mutual understanding with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now you seem to be threatening me. And I don't like where this is going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Axel Reinhart: ""Nor do I.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps we can still reach an agreement. But Pales must understand and respect Rizia's stance on Aureus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""No. I will not allow Rizia to threaten Pales like this, ..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Where is Vina?""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where is Vina?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "He looked annoyed when I disrupted him."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "He looked annoyed when I disrupted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Axel Reinhart: ""She is safe and sound, Your Majesty. Don't worry.""*)

### Węzeł `[188]`
Mówca: **Axel Reinhart**
> ""She is safe and sound, Your Majesty. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Axel Reinhart: ""We'll bring her in later. But first, you will listen to ..."*)

### Węzeł `[189]`
Mówca: **Axel Reinhart**
> ""We'll bring her in later. But first, you will listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Naval == true"*)

### Węzeł `[190]`
Mówca: **Axel Reinhart**
> ""Nor do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""Then I have nothing else to say. Except this.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Let's discuss.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Axel Reinhart), `[163]` (Axel Reinhart), `[200]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He straightened his back."*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing else I can offer you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Axel Reinhart), `[163]` (Axel Reinhart), `[200]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Axel Reinhart: ""Then I have nothing else to say. Except this.""*)

### Węzeł `[193]`
Mówca: **Narrator**
> "He straightened his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Pales_ListenedToDemands = true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""You'd better have something to off..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Axel Reinhart: ""You'd better have something to offer other than an apolo..."*)

### Węzeł `[195]`
Mówca: **Axel Reinhart**
> ""These are not the actions of a country that wants peace. Wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""You have to trust me, Your Grace.""*)
  - -> `[202]` (*Player_Romus: ""I assure you, we want peace. But if you keep pushing us,..."*)
  - -> `[203]` (*Player_Romus: ""We don't need to be enemies. Please understand the predi..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || Riz..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Axel Reinhart: ""You allowed our sailors to die in the sea and captured o..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""You'd better have something to..."*)

### Węzeł `[199]`
Mówca: **Axel Reinhart**
> ""You allowed our sailors to die in the sea and captured our vessels, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Axel Reinhart: ""These are not the actions of a country that wants peace...."*)

### Węzeł `[200]`
Mówca: **Axel Reinhart**
> ""You'd better have something to offer other than an apology, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""What do you want me to offer you? I am willing to do wha..."*)
  - -> `[191]` (*Player_Romus: ""Okay. Let's discuss.""*)
  - -> `[192]` (*Player_Romus: ""There's nothing else I can offer you.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have to trust me, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Axel Reinhart: ""Then you have to prove it, Your Majesty.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I assure you, we want peace. But if you keep pushing us, we are ready for anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Axel Reinhart: ""Rizia will no longer dictate anything, Your Majesty.""*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need to be enemies. Please understand the predicament I'm in. I cannot let go of that field so easily.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Axel Reinhart: ""Rizia will no longer dictate anything, Your Majesty.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Duke Reinhart raised an eyebrow."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Axel Reinhart: ""Looking for answers? After you kill every single one of ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Axel Reinhart: ""Your reports *suggest* utter lies, Your Majesty.""*)

### Węzeł `[208]`
Mówca: **Axel Reinhart**
> ""Looking for answers? After you kill every single one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Axel Reinhart: ""Your reports *suggest* utter lies, Your Majesty.""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Axel Reinhart: ""And it was the Rizian Army that killed every single one ..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""We know that your soldiers inc..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Axel Reinhart: ""So you decided to kill every single one of them before v..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Axel Reinhart: ""You may not have falsified the reports yourself, Your Ma..."*)

### Węzeł `[215]`
Mówca: **Axel Reinhart**
> ""So you decided to kill every single one of them before verifying any of those reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Axel Reinhart: ""You may not have falsified the reports yourself, Your Ma..."*)

### Węzeł `[216]`
Mówca: **Axel Reinhart**
> ""And it was the Rizian Army that killed every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""We know that your soldiers inc..."*)

### Węzeł `[217]`
Mówca: **Axel Reinhart**
> ""Your reports *suggest* utter lies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""We know that your soldiers inc..."*)

### Węzeł `[218]`
Mówca: **Axel Reinhart**
> ""You may not have falsified the reports yourself, Your Majesty. But obfuscation is afoot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""We know that your soldiers inc..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Duke Reinhart raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Duke Reinhart raised an eyebrow."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Duke Reinhart raised an eyebrow."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""We know that your soldiers incited..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player_Romus: ""No. I'm only here to take my daughter home to Rizia.""*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm only here to take my daughter home to Rizia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[118]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Axel Reinhart: ""And then what, Your Majesty?""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""Don't worry, Your Grace. As long as Vina and I can leave..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Your Grace. As long as Vina and I can leave Pales in peace, there will be no such aggression from us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Axel Reinhart: ""You claim peace and you're still making threats?""*)

### Węzeł `[230]`
Mówca: **Axel Reinhart**
> ""And then what, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Axel Reinhart: ""You claim you want peace after the Rizian Army killed ev..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[234]`
Mówca: **Axel Reinhart**
> ""You claim you want peace after the Rizian Army killed every single Palesian involved?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Axel Reinhart: ""We know that your soldiers incited the incident. Our gua..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless of who shot first, your soldiers went inside Rizia and occupied a castle in the process. So please, don't try to blame Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Axel Reinhart: ""Regardless of who shot first?""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to know the same, Duke Reinhart. The incident at our border is deeply regrettable, and I assure you, Rizia seeks a peaceful resolution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Axel Reinhart: ""Peaceful resolution? When Rizian troops are shooting at ..."*)

### Węzeł `[237]`
Mówca: **Axel Reinhart**
> ""You claim peace and you're still making threats?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody wants a war, Your Grace. I am here to reach a mutual understanding with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Axel Reinhart), `[257]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think Pales can stand against Rizia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Axel Reinhart: ""I don't think you want to find that out, Your Majesty.""*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Romus: ""You've made your point, Your Grace. I don't intend to pu..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point, Your Grace. I don't intend to pursue any aggression. Rizia only wants peace. I just need Vina to come back with me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[175]` (Axel Reinhart), `[257]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Axel Reinhart: ""You claim peace and you're still making threats?""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this. Do you want reconciliation or not?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Axel Reinhart), `[257]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Axel Reinhart: ""Rizia will no longer dictate anything, Your Majesty.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter now, Your Grace. The fact is that is now part of the negotiations, whether you like it or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Axel Reinhart), `[179]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Axel Reinhart: ""Rizia will no longer dictate anything, Your Majesty.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We did not capture anything. Your sailors will be released after the vessels are fully inspected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Axel Reinhart), `[179]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Axel Reinhart: ""It sounds like they're being held captive to me.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are consequences for rash actions, Your Grace. They ignored our warnings and rammed into our ship. I don't think I need to repeat this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Axel Reinhart), `[179]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Axel Reinhart: ""Exactly, Your Majesty. There are consequences for rash a..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Axel Reinhart: ""You seem confident... As if we were the side that broke ..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Axel Reinhart: ""You seem confident despite Rizia's clear breach of inter..."*)

### Węzeł `[251]`
Mówca: **Axel Reinhart**
> ""Rizia will no longer dictate anything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Axel Reinhart: ""Either you will listen to our demands and back off from ..."*)

### Węzeł `[252]`
Mówca: **Axel Reinhart**
> ""Exactly, Your Majesty. There are consequences for rash actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Axel Reinhart: ""And your actions are leading us to war.""*)

### Węzeł `[253]`
Mówca: **Axel Reinhart**
> ""And your actions are leading us to war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Axel Reinhart: ""Either you will listen to our demands and back off from ..."*)

### Węzeł `[254]`
Mówca: **Axel Reinhart**
> ""Either you will listen to our demands and back off from Aureus completely...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Player_Romus_Italic: "Keep listening."*)
  - -> `[404]` (*Player_Romus: ""I understand...""*)
  - -> `[405]` (*Player_Romus: ""Or what, Your Grace?""*)

### Węzeł `[255]`
Mówca: **Axel Reinhart**
> ""It sounds like they're being held captive to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Axel Reinhart: ""Either you will listen to our demands and back off from ..."*)

### Węzeł `[256]`
Mówca: **Axel Reinhart**
> ""I have nothing left to say. Except this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[257]`
Mówca: **Axel Reinhart**
> ""I don't think you want to find that out, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[238]` (*Player_Romus: ""Nobody wants a war, Your Grace. I am here to reach a mut..."*)
  - -> `[258]` (*Player_Romus: ""You're wrong. I intend to find out.""*)
  - -> `[244]` (*Player_Romus: ""Enough of this. Do you want reconciliation or not?""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're wrong. I intend to find out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He paused for a moment. His face darkened."*)

### Węzeł `[259]`
Mówca: **Narrator**
> "He paused for a moment. His face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Axel Reinhart: ""Either you will listen to our demands and back off from ..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || Riz..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "He paused for a moment. His face darkened."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Axel Reinhart: ""Are you going to listen to our concerns, or not?""*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true || RiziaD..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Axel Reinhart: ""I wish I could say your visit today brings me comfort, b..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Axel Reinhart: ""I wish I could say your visit today brings me comfort, b..."*)

### Węzeł `[266]`
Mówca: **Axel Reinhart**
> ""I wish I could say your visit today brings me comfort, but under these circumstances, I find it hard to extend a warm greeting. But still... Welcome back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""Thank you for having us...""*)
  - -> `[59]` (*Player_Romus: ""I hope we can sort this problem out today, Your Grace.""*)
  - -> `[60]` (*Player_Romus: ""Duke Reinhart.""*)
  - -> `[61]` (*Player_Romus_Italic: "Don't say anything."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The reports we received can be deceptive, and I fear we are both victims of a larger game. It is not my desire, nor the desire of Rizia, to escalate tensions. We seek only to defend our sovereignty, as you do yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Axel Reinhart: ""Defend your sovereignty? Or expand it at the cost of our..."*)

### Węzeł `[268]`
Mówca: **Axel Reinhart**
> ""Regardless of who shot first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[269]`
Mówca: **Axel Reinhart**
> ""Peaceful resolution? When Rizian troops are shooting at our borders, and reports of aggression filter through every channel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Axel Reinhart: ""You must understand how this appears from my perspective.""*)

### Węzeł `[270]`
Mówca: **Axel Reinhart**
> ""Defend your sovereignty? Or expand it at the cost of ours? Reports suggest it was Rizian soldiers who fired first, instigating the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""What would we gain from this, Your Grace?""*)
  - -> `[281]` (*Player_Romus: ""And why would I believe the Palesian reports?""*)
  - -> `[280]` (*Player_Romus: ""Those reports are not accurate, Duke Reinhart. Rizia has..."*)

### Węzeł `[271]`
Mówca: **Axel Reinhart**
> ""You must understand how this appears from my perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""How about my perspective? I was told it was your soldier..."*)
  - -> `[278]` (*Player_Romus: ""I understand. But I must assure you. I am here with peac..."*)
  - -> `[277]` (*Player_Romus: ""Appearances can be deceptive, and I fear we are both vic..."*)

### Węzeł `[272]`
Mówca: **Axel Reinhart**
> ""You killed our soldiers at the castle and ignore the reason how everything started?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Axel Reinhart: ""You must understand how this appears from my perspective.""*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Axel Reinhart: ""You killed our soldiers at the castle and ignore the rea..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Axel Reinhart: ""I am to believe Rizian reports? When Rizian troops are s..."*)

### Węzeł `[276]`
Mówca: **Axel Reinhart**
> ""I am to believe Rizian reports? When Rizian troops are shooting at our borders, and reports of aggression filter through every channel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Axel Reinhart: ""You must understand how this appears from my perspective.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Appearances can be deceptive, and I fear we are both victims of a larger game. It is not my desire, nor the desire of Rizia, to escalate tensions. We seek only to defend our sovereignty, as you do yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Axel Reinhart: ""Defend your sovereignty? Or expand it at the cost of our..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. But I must assure you. I am here with peaceful intentions, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He sighed."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How about my perspective? I was told it was your soldiers who initiated a firefight and occupied a castle inside Rizia. We are only defending our sovereignty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[271]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Axel Reinhart: ""Defend your sovereignty? Or expand it at the cost of our..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those reports are not accurate, Duke Reinhart. Rizia has no interest in provoking a war. The situation at the border was a defensive response, triggered by movements we perceived as hostile.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would I believe the Palesian reports?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Axel Reinhart: ""You know the same goes for me, Your Majesty.""*)

### Węzeł `[282]`
Mówca: **Axel Reinhart**
> ""Perceived as hostile? So, we are to believe this was all a misunderstanding? A tragic error in judgment that cost lives?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He sighed."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Axel Reinhart: ""Look, Your Majesty. You speak of peace and cooperation, ..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get our facts straight, Your Grace. Our reports suggest otherwise. You can't claim to be the source of the truth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Axel Reinhart: ""I am to believe Rizian reports? When Rizian troops are s..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would we gain from this, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Axel Reinhart: ""I don't know...""*)

### Węzeł `[286]`
Mówca: **Axel Reinhart**
> ""You know the same goes for me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He sighed."*)

### Węzeł `[287]`
Mówca: **Axel Reinhart**
> ""I don't know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He sighed."*)

### Węzeł `[288]`
Mówca: **Axel Reinhart**
> ""Look, Your Majesty. You speak of peace and cooperation, yet the actions at the border tell a different story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Axel Reinhart: ""Your soldiers surrounded and killed every Palesian in th..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Axel Reinhart: ""At this very moment, our soldiers in that castle are sur..."*)

### Węzeł `[292]`
Mówca: **Axel Reinhart**
> ""Your soldiers surrounded and killed every Palesian in the castle without hesitation. You didn't think about communicating with me then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Axel Reinhart: ""So, how can I trust the words of a king whose armies tak..."*)

### Węzeł `[293]`
Mówca: **Axel Reinhart**
> ""So, how can I trust the words of a king whose armies take impulsive actions and stand ready to march into my lands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player_Romus: ""It was interpreted as an occupation by the army and they..."*)
  - -> `[297]` (*Player_Romus: ""Duke Reinhart, the positioning of our troops is purely d..."*)
  - -> `[298]` (*Player_Romus: ""Impulsive actions? The real question is, why did Palesia..."*)
  - -> `[299]` (*Player_Romus: ""I am filled with regret about this whole thing. I am her..."*)

### Węzeł `[294]`
Mówca: **Axel Reinhart**
> ""At this very moment, our soldiers in that castle are surrounded by your forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Axel Reinhart: ""If you want to have a dialogue, they must first be allow..."*)

### Węzeł `[295]`
Mówca: **Axel Reinhart**
> ""If you want to have a dialogue, they must first be allowed to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[312]` (*Player_Romus: ""Of course. They will be allowed to leave immediately.""*)
  - -> `[313]` (*Player_Romus: ""Well... That depends on the outcome of our meeting, does..."*)
  - -> `[314]` (*Player_Romus: ""I'm afraid that cannot happen. They need to surrender to..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was interpreted as an occupation by the army and they responded accordingly. I cannot fault my soldiers for protecting our borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Axel Reinhart: ""An occupation?""*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, the positioning of our troops is purely defensive. The real question is, why were Palesian forces so close to the border in a manner that could be interpreted as provocative?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Axel Reinhart: ""Provocative? It is common for patrols to be near borders..."*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impulsive actions? The real question is, why did Palesian forces decide to enter a paleacci inside our borders and stay there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Axel Reinhart: ""They were caught in the open when your forces opened fir..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am filled with regret about this whole thing. I am here to listen to your concerns. You have to trust me, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Axel Reinhart: ""I want to trust you but Rizian actions make it very diff..."*)

### Węzeł `[300]`
Mówca: **Axel Reinhart**
> ""They were caught in the open when your forces opened fire, Your Majesty. They only took refuge there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player_Romus: ""Only according to the Palesian reports.""*)
  - -> `[307]` (*Player_Romus: ""Refuge? They did not surrender when they were surrounded..."*)
  - -> `[321]` (*Player_Romus: ""Your reports say one thing, Duke, but ours indicate an a..."*)
  - -> `[322]` (*Player_Romus: ""It looks like a very deliberate choice, Your Grace. Pale..."*)

### Węzeł `[301]`
Mówca: **Axel Reinhart**
> ""Provocative? It is common for patrols to be near borders. It is another thing entirely to respond with gunfire. Do you suggest we do not have the right to secure our own borders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: ""Of course you have a right to secure your borders. Just ..."*)
  - -> `[304]` (*Player_Romus: ""Securing borders is one thing, Duke, but reports indicat..."*)
  - -> `[305]` (*Player_Romus: ""I'm not saying that, Your Grace. The real question is, w..."*)

### Węzeł `[302]`
Mówca: **Axel Reinhart**
> ""An occupation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Axel Reinhart: ""They were caught in the open when your forces opened fir..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course you have a right to secure your borders. Just the same way as we do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Axel Reinhart: ""Rizia responded disproportionately harsh, Your Majesty. ..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Securing borders is one thing, Duke, but reports indicate an aggressive stance from your patrols. We must consider the possibility of miscommunication among our forces, perhaps even deliberate misinformation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Axel Reinhart: ""Miscommunication? You speak as if the incident was a mer..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not saying that, Your Grace. The real question is, why did Palesian forces decide to enter a paleacci inside our borders and stay there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Axel Reinhart: ""They were caught in the open when your forces opened fir..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only according to the Palesian reports.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Axel Reinhart: ""Do you really believe I am after a ruined medieval castle?""*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Refuge? They did not surrender when they were surrounded, Your Grace. They were not the victims here. They killed six of our soldiers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Axel Reinhart: ""Do you really believe I am after a ruined medieval castle?""*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Axel Reinhart: ""Perceived as hostile? So, we are to believe this was all..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Axel Reinhart: ""Perceived as hostile? So, we are to believe this was all..."*)

### Węzeł `[311]`
Mówca: **Axel Reinhart**
> ""Perceived as hostile? So, we are to believe this was all a misunderstanding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He sighed."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. They will be allowed to leave immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; Riz..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... That depends on the outcome of our meeting, doesn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Axel Reinhart: ""You cannot threaten Pales any longer, Your Majesty. I wi..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid that cannot happen. They need to surrender to us, and at the very least, stand trial for their actions against Rizian people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Axel Reinhart: ""You cannot threaten Pales any longer, Your Majesty. I wi..."*)

### Węzeł `[315]`
Mówca: **Axel Reinhart**
> ""I want to trust you but Rizian actions make it very difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Axel Reinhart: ""They were caught in the open when your forces opened fir..."*)

### Węzeł `[316]`
Mówca: **Axel Reinhart**
> ""Miscommunication? You speak as if the incident was a mere diplomatic faux pas. Lives were lost, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Axel Reinhart: ""This cannot be brushed aside as a misunderstanding.""*)

### Węzeł `[317]`
Mówca: **Axel Reinhart**
> ""This cannot be brushed aside as a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: ""I'm not brushing anything aside. I suspect it could be a..."*)
  - -> `[327]` (*Player_Romus: ""I do not and I never would underestimate the gravity of ..."*)
  - -> `[328]` (*Player_Romus: ""Are you going to threaten me, Your Grace? I'm doing my b..."*)

### Węzeł `[318]`
Mówca: **Axel Reinhart**
> ""Rizia responded disproportionately harsh, Your Majesty. Wouldn't you say so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Axel Reinhart: ""We were in close cooperation since we agreed on our deal..."*)

### Węzeł `[319]`
Mówca: **Axel Reinhart**
> ""We were in close cooperation since we agreed on our deal on Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Axel Reinhart: ""Why would Rizia act in this manner, right before the dea..."*)

### Węzeł `[320]`
Mówca: **Axel Reinhart**
> ""Why would Rizia act in this manner, right before the deal is finalized?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Axel Reinhart: ""This cannot be brushed aside as a misunderstanding.""*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your reports say one thing, Duke, but ours indicate an aggressive stance from your patrols. We must consider the possibility of miscommunication among our forces, perhaps even deliberate misinformation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Axel Reinhart: ""Miscommunication? You speak as if the incident was a mer..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It looks like a very deliberate choice, Your Grace. Pales is the land of *paleaccis.* Was that a coincidence your forces occupied one?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Axel Reinhart: ""Are you claiming Pales wants to invade and occupy Rizia?""*)

### Węzeł `[323]`
Mówca: **Axel Reinhart**
> ""Are you claiming Pales wants to invade and occupy Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Axel Reinhart: ""Nobody would believe that, Your Majesty. And you know yo..."*)

### Węzeł `[324]`
Mówca: **Axel Reinhart**
> ""Nobody would believe that, Your Majesty. And you know you also don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Axel Reinhart: ""Rizia responded disproportionately harsh, Your Majesty. ..."*)

### Węzeł `[325]`
Mówca: **Axel Reinhart**
> ""Do you really believe I am after a ruined medieval castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Axel Reinhart: ""Nobody would believe that, Your Majesty. And you know yo..."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not brushing anything aside. I suspect it could be an inside job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Axel Reinhart), `[354]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Axel Reinhart: ""An inside job? From Rizia?""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not and I never would underestimate the gravity of the situation, Your Grace. But we must not let this tragedy set the course for our nations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Axel Reinhart), `[354]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Axel Reinhart: ""A noble sentiment, but how do I reconcile it with the re..."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you going to threaten me, Your Grace? I'm doing my best to reach an understanding but you are constantly pointing fingers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Axel Reinhart), `[354]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Axel Reinhart: ""For good reason.""*)

### Węzeł `[329]`
Mówca: **Axel Reinhart**
> ""For good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Axel Reinhart: ""And how do I reconcile it with the reports from my comma..."*)

### Węzeł `[330]`
Mówca: **Axel Reinhart**
> ""A noble sentiment, but how do I reconcile it with the reports from my commanders? They claim your forces were not just defending, but actively pursuing engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Romus: ""And yet, my reports suggest the exact opposite. That it ..."*)
  - -> `[340]` (*Player_Romus: ""This disparity in reports is precisely why a joint inves..."*)
  - -> `[345]` (*Player_Romus: ""What would we gain from this, Your Grace? This happened ..."*)

### Węzeł `[331]`
Mówca: **Axel Reinhart**
> ""An inside job? From Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Axel Reinhart: ""So, you also think that your reports are untrustworthy?""*)

### Węzeł `[332]`
Mówca: **Axel Reinhart**
> ""You cannot threaten Pales any longer, Your Majesty. I will not bow down to your threats. Palesians interpret this as an act of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Axel Reinhart: ""If you do not release them, it is proof that Rizia was a..."*)

### Węzeł `[333]`
Mówca: **Axel Reinhart**
> ""If you do not release them, it is proof that Rizia was after aggression all along and this incident was all a ruse to justify war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[380]` (*Player_Romus: ""No. Pales cannot dictate that.""*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; RiziaDLC.Vina_Hostage = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"] = true;
Variable["RiziaDLC.Vina_Hostage"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[335]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Axel Reinhart: ""Now... It is common for patrols to be near borders. It i..."*)

### Węzeł `[336]`
Mówca: **Axel Reinhart**
> ""Now... It is common for patrols to be near borders. It is another thing entirely to respond with gunfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""We were in close cooperation since we agreed on our deal..."*)

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""We were in close cooperation since we agreed on our deal on Aureus. And right before the signing... This happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Axel Reinhart: ""This cannot be brushed aside as a misunderstanding.""*)

### Węzeł `[338]`
Mówca: **Axel Reinhart**
> ""And how do I reconcile it with the reports from my commanders? They claim your forces were not just defending, but actively pursuing engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Romus: ""And yet, my reports suggest the exact opposite. That it ..."*)
  - -> `[340]` (*Player_Romus: ""This disparity in reports is precisely why a joint inves..."*)
  - -> `[345]` (*Player_Romus: ""What would we gain from this, Your Grace? This happened ..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet, my reports suggest the exact opposite. That it was your forces who seemed to be edging closer to a conflict. We won't reach anywhere like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Axel Reinhart), `[338]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Axel Reinhart: ""We cannot rely on biased perspective of the Rizian force..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This disparity in reports is precisely why a joint investigation is critical. We cannot rely solely on biased perspectives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Axel Reinhart), `[338]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Axel Reinhart: ""Biased perspective? Are you suggesting that Pales is fab..."*)

### Węzeł `[341]`
Mówca: **Axel Reinhart**
> ""This cannot be brushed aside as a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""I'm not brushing anything aside. I suspect it could be a..."*)
  - -> `[343]` (*Player_Romus: ""I do not and I never would underestimate the gravity of ..."*)
  - -> `[344]` (*Player_Romus: ""Are you going to threaten me, Your Grace? I'm doing my b..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not brushing anything aside. I suspect it could be an inside job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Axel Reinhart: ""An inside job? From Rizia?""*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not and I never would underestimate the gravity of the situation, Your Grace. But we must not let this tragedy set the course for our nations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Axel Reinhart: ""A noble sentiment, but how do I reconcile it with the re..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you going to threaten me, Your Grace? I'm doing my best to reach an understanding but you are constantly pointing fingers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Axel Reinhart: ""For good reason.""*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would we gain from this, Your Grace? This happened right before the signing of our deal. This is definitely intended to sabotage our claims on Aureus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Axel Reinhart), `[338]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Axel Reinhart: ""Sabotage, you say?""*)

### Węzeł `[346]`
Mówca: **Axel Reinhart**
> ""Biased perspective? Are you suggesting that Pales is fabricating its reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player_Romus: ""Not fabricating, Your Grace, but there is always a lens ..."*)
  - -> `[357]` (*Player_Romus: ""No. I'm not pointing fingers at Pales. It could be from ..."*)
  - -> `[358]` (*Player_Romus: ""It is a possibility. How can either of us be certain?""*)

### Węzeł `[347]`
Mówca: **Axel Reinhart**
> ""Sabotage, you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Axel Reinhart: ""Rizian nationalists? An inside job?""*)

### Węzeł `[348]`
Mówca: **Axel Reinhart**
> ""We cannot rely on biased perspective of the Rizian forces. There is clearly a mismatch between our reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player_Romus: ""I agree. And there's nothing we would gain from this. Th..."*)
  - -> `[349]` (*Player_Romus: ""Are you suggesting that Rizia is fabricating its reports?""*)
  - -> `[351]` (*Player_Romus: ""I suspect it could be an inside job.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you suggesting that Rizia is fabricating its reports?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Axel Reinhart: ""Not at all. But it is a possibility.""*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. And there's nothing we would gain from this. This happened right before the signing of our deal. This is definitely intended to sabotage our claims on Aureus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Axel Reinhart: ""Sabotage, you say?""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect it could be an inside job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Axel Reinhart: ""An inside job? From Rizia?""*)

### Węzeł `[352]`
Mówca: **Axel Reinhart**
> ""An inside job? From Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Axel Reinhart: ""So, you also think that your reports are untrustworthy?""*)

### Węzeł `[353]`
Mówca: **Axel Reinhart**
> ""So, you also think that your reports are untrustworthy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""No. I won't allow you to point fingers at Rizia. It coul..."*)
  - -> `[368]` (*Player_Romus: ""I don't want to believe that but it is a possibility.""*)
  - -> `[369]` (*Player_Romus: ""They are as trustworthy as the Palesian reports.""*)
  - -> `[370]` (*Player_Romus: ""I'm starting to suspect that.""*)

### Węzeł `[354]`
Mówca: **Axel Reinhart**
> ""This cannot be brushed aside as a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: ""I'm not brushing anything aside. I suspect it could be a..."*)
  - -> `[327]` (*Player_Romus: ""I do not and I never would underestimate the gravity of ..."*)
  - -> `[328]` (*Player_Romus: ""Are you going to threaten me, Your Grace? I'm doing my b..."*)

### Węzeł `[355]`
Mówca: **Axel Reinhart**
> ""Rizian nationalists? An inside job?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Axel Reinhart: ""So, you also think that your reports are untrustworthy?""*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not fabricating, Your Grace, but there is always a lens through which situations are viewed. Each side sees the other's actions through a filter of suspicion and defense. Our goal should be to remove these filters and seek the objective truth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Axel Reinhart: ""The 'objective truth' is a slippery concept, Your Majest..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not pointing fingers at Pales. It could be from within Rizia as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Axel Reinhart: ""Confusion and paranoia. This perspective is a slippery s..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a possibility. How can either of us be certain?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Axel Reinhart: ""Looking for certainty is a slippery slope, Your Majesty...."*)

### Węzeł `[359]`
Mówca: **Axel Reinhart**
> ""Not at all. But it is a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Axel Reinhart: ""I'm merely pointing out the biases Rizians have.""*)

### Węzeł `[360]`
Mówca: **Axel Reinhart**
> ""The 'objective truth' is a slippery concept, Your Majesty. What is true for Rizia may not be true for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Axel Reinhart: ""Your call for a joint investigation seems more like a ta..."*)

### Węzeł `[361]`
Mówca: **Axel Reinhart**
> ""Looking for certainty is a slippery slope, Your Majesty. What is true for Rizia may not be true for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Axel Reinhart: ""Your call for a joint investigation seems more like a ta..."*)

### Węzeł `[362]`
Mówca: **Axel Reinhart**
> ""Confusion and paranoia. This perspective is a slippery slope, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Axel Reinhart: ""Your call for a joint investigation seems more like a ta..."*)

### Węzeł `[363]`
Mówca: **Axel Reinhart**
> ""Your call for a joint investigation seems more like a tactic to buy time, perhaps to strengthen your position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""On the contrary, Duke Reinhart. Delay benefits neither o..."*)
  - -> `[384]` (*Player_Romus: ""Your Grace, we need to act swiftly and decisively to pre..."*)
  - -> `[385]` (*Player_Romus: ""What is your suggestion, Your Grace?""*)

### Węzeł `[364]`
Mówca: **Axel Reinhart**
> ""I'm merely pointing out the biases Rizians have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player_Romus: ""Each side has a bias, Your Grace, we don't have a monopo..."*)
  - -> `[365]` (*Player_Romus: ""I suppose it could be an inside job.""*)
  - -> `[367]` (*Player_Romus: ""No. I won't allow you to point fingers at Rizia. It coul..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose it could be an inside job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Axel Reinhart: ""So, you also think that your reports are untrustworthy?""*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Each side has a bias, Your Grace, we don't have a monopoly over it. Our goal should be to remove these filters and seek the objective truth. A joint investigation may be necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Axel Reinhart: ""The 'objective truth' is a slippery concept, Your Majest..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I won't allow you to point fingers at Rizia. It could be from within Pales as well. Your side would be giving away their rights to the field, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Axel Reinhart), `[364]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Axel Reinhart: ""What are you insinuating at?""*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to believe that but it is a possibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Axel Reinhart: ""It is a possibility, indeed.""*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are as trustworthy as the Palesian reports.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Axel Reinhart: ""What do we about it then, Your Majesty?""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm starting to suspect that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Axel Reinhart: ""It is a possibility, indeed.""*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Player_Romus: ""Of course. As soon as Vina leaves Pales with me.""*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. As soon as Vina leaves Pales with me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[295]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; Riz..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player_Romus: ""They will be released. As soon as Vina leaves Pales with..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""Fine. They will be released immediately.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will be released. As soon as Vina leaves Pales with me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[333]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; Riz..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. They will be released immediately.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[333]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; Riz..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Pales cannot dictate that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Axel Reinhart: ""You are the side that initiated the attack, Your Majesty.""*)

### Węzeł `[381]`
Mówca: **Axel Reinhart**
> ""You are the side that initiated the attack, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Axel Reinhart: ""If you are not willing to listen to Palesian demands, we..."*)

### Węzeł `[382]`
Mówca: **Axel Reinhart**
> ""If you are not willing to listen to Palesian demands, we will interpret this as an attack on our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; Riz..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the contrary, Duke Reinhart. Delay benefits neither of us. The longer this tension persists, the greater the risk of escalation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Axel Reinhart: ""There is great risk, indeed. But can you assure me that ..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Grace, we need to act swiftly and decisively to prevent a conflict that would be catastrophic for both our nations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Axel Reinhart: ""Catastrophic, indeed. But can you assure me that this in..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is your suggestion, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Axel Reinhart: ""Neutral international observers must be involved for it ..."*)

### Węzeł `[386]`
Mówca: **Axel Reinhart**
> ""Catastrophic, indeed. But can you assure me that this investigation will not be swayed by the powers at play?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Player_Romus: ""Regardless of the investigation, Rizia wants to continue..."*)
  - -> `[389]` (*Player_Romus: ""I don't think either of us can assure that, Your Grace.""*)
  - -> `[390]` (*Player_Romus: ""I propose we involve neutral international observers in ..."*)

### Węzeł `[387]`
Mówca: **Axel Reinhart**
> ""There is great risk, indeed. But can you assure me that this investigation will not be swayed by the powers at play?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Player_Romus: ""Regardless of the investigation, Rizia wants to continue..."*)
  - -> `[389]` (*Player_Romus: ""I don't think either of us can assure that, Your Grace.""*)
  - -> `[390]` (*Player_Romus: ""I propose we involve neutral international observers in ..."*)

### Węzeł `[388]`
Mówca: **Axel Reinhart**
> ""Neutral international observers must be involved for it to be a proper investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player_Romus: ""Agreed.""*)
  - -> `[394]` (*Player_Romus: ""That would work, Your Grace. However, their findings mus..."*)
  - -> `[425]` (*Player_Romus: ""Neutral is a strong word, Your Grace. The international ..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think either of us can assure that, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Axel Reinhart), `[387]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Axel Reinhart: ""No. But neutral international observers can.""*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I propose we involve neutral international observers in the investigation. Let them be our eyes and ears, free from the biases of our national interests.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Axel Reinhart), `[387]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Axel Reinhart: ""I agree. That could be a way to ensure the investigation..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless of the investigation, Rizia wants to continue with our previous deal and preserve peace with Pales. Can you assure me if it's a possibility?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Axel Reinhart), `[387]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Axel Reinhart: ""And what if the investigations reveal actions that canno..."*)

### Węzeł `[392]`
Mówca: **Axel Reinhart**
> ""I agree. That could be a way to ensure the investigation is not swayed by either side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player_Romus: ""Exactly. Whatever the findings, we shall abide by them a..."*)
  - -> `[393]` (*Player_Romus: ""Agreed.""*)
  - -> `[394]` (*Player_Romus: ""That would work, Your Grace. However, their findings mus..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Axel Reinhart), `[392]` (Axel Reinhart), `[423]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Axel Reinhart: ""And what if the investigations reveal actions that canno..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would work, Your Grace. However, their findings must be accepted by both Rizia and Pales, without question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Axel Reinhart), `[392]` (Axel Reinhart), `[423]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Axel Reinhart: ""And what if the investigations reveal actions that canno..."*)

### Węzeł `[395]`
Mówca: **Axel Reinhart**
> ""Rizia will no longer dictate anything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Either you will listen to our ..."*)

### Węzeł `[396]`
Mówca: **Axel Reinhart**
> ""Then you have to prove it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Either you will listen to our ..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Either you will listen to our dema..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Axel Reinhart: ""Either you will listen to our demands and back off from ..."*)

### Węzeł `[398]`
Mówca: **Axel Reinhart**
> ""Are you going to listen to our concerns, or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""No, Your Grace. You are making a mistake with your harsh..."*)
  - -> `[399]` (*Player_Romus: ""Yes. And I deeply regret what happened.""*)
  - -> `[400]` (*Player_Romus: ""I'm listening.""*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And I deeply regret what happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""You'd better have something to..."*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He straightened his back."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Your Grace. You are making a mistake with your harsh attitude. I'm done listening to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He paused for a moment. His face darkened."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""You'd better have something to off..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Axel Reinhart: ""You'd better have something to offer other than an apolo..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Axel Reinhart: ""...Or... Well... Let's not even imagine that scenario.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or what, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Axel Reinhart: ""Let's not imagine that scenario.""*)

### Węzeł `[406]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He straightened his back."*)

### Węzeł `[407]`
Mówca: **Axel Reinhart**
> ""...Or... Well... Let's not even imagine that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He straightened his back."*)

### Węzeł `[408]`
Mówca: **Narrator**
> "He paused for a moment. His face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Axel Reinhart: ""I see.""*)

### Węzeł `[409]`
Mówca: **Axel Reinhart**
> ""Let's not imagine that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He straightened his back."*)

### Węzeł `[410]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Axel Reinhart: ""Then you won't be surprised to hear that the Palesian Na..."*)

### Węzeł `[411]`
Mówca: **Axel Reinhart**
> ""Then you won't be surprised to hear that the Palesian Navy has been deployed to the Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[412]`
Mówca: **Axel Reinhart**
> ""We will not bow down against your aggression any longer. Rizia will have no access whatsoever to any energy from the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player_Romus: ""That would be a cause for war.""*)
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[415]` (*Player_Romus: ""You intended to escalate the situation further, after al..."*)
  - -> `[416]` (*Player_Romus: ""I will let the world know about your stance. Let's see w..."*)
  - -> `[534]` (*Player_Romus: ""Let's calm down, Your Grace. Nobody wants a war.""*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be a cause for war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Axel Reinhart: ""Your attack was the cause for everything, Your Majesty, ..."*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot afford to keep your navy at the field at all times, Your Grace.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Axel Reinhart: ""Oh, you don't know our new capabilities, Your Majesty.""*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You intended to escalate the situation further, after all...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Axel Reinhart: ""Your attack was the cause for everything, Your Majesty, ..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will let the world know about your stance. Let's see who they'll support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[417]`
Mówca: **Axel Reinhart**
> ""You seem confident despite Rizia's clear breach of international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Axel Reinhart: ""If you really think anyone will support Rizia, you are l..."*)

### Węzeł `[418]`
Mówca: **Axel Reinhart**
> ""Your attack was the cause for everything, Your Majesty, and you know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Axel Reinhart: ""Rizia cannot threaten us with war anymore, Your Majesty...."*)

### Węzeł `[419]`
Mówca: **Axel Reinhart**
> ""Oh, you don't know our new capabilities, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Axel Reinhart: ""I intend to block your access to Aureus, and I don't thi..."*)

### Węzeł `[420]`
Mówca: **Axel Reinhart**
> ""You seem confident... As if we were the side that broke their promise and cancelled a deal at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Axel Reinhart: ""If you really think anyone will support Rizia, you are l..."*)

### Węzeł `[421]`
Mówca: **Axel Reinhart**
> ""If you really think anyone will support Rizia, you are living in a land of fantasy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Player_Romus: ""You will not get away with this.""*)
  - -> `[539]` (*Player_Romus: ""If you try to block our access, we will take it by force..."*)
  - -> `[541]` (*Player_Romus: ""Fine. Take the whole field. I couldn't care less.""*)

### Węzeł `[422]`
Mówca: **Axel Reinhart**
> ""It is a possibility, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Axel Reinhart: ""What do we about it then, Your Majesty?""*)

### Węzeł `[423]`
Mówca: **Axel Reinhart**
> ""No. But neutral international observers can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player_Romus: ""Agreed.""*)
  - -> `[394]` (*Player_Romus: ""That would work, Your Grace. However, their findings mus..."*)
  - -> `[425]` (*Player_Romus: ""Neutral is a strong word, Your Grace. The international ..."*)

### Węzeł `[424]`
Mówca: **Axel Reinhart**
> ""And what if the investigations reveal actions that cannot simply be rectified? What if they expose a deeper plot or intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: ""Then we face those revelations together and act in the i..."*)
  - -> `[430]` (*Player_Romus: ""If our expectations from the start are like this, how do..."*)
  - -> `[431]` (*Player_Romus: ""Then we will act accordingly, Your Grace.""*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neutral is a strong word, Your Grace. The international community too have their biases.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Axel Reinhart), `[423]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Axel Reinhart: ""There is no other way to resolve this without the presen..."*)

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. Whatever the findings, we shall abide by them and take the necessary steps to rectify any wrongs and restore peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Axel Reinhart: ""And what if the investigations reveal actions that canno..."*)

### Węzeł `[427]`
Mówca: **Axel Reinhart**
> ""And what if the investigations reveal actions that cannot simply be rectified? What if they expose a deeper plot or intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: ""Then we face those revelations together and act in the i..."*)
  - -> `[430]` (*Player_Romus: ""If our expectations from the start are like this, how do..."*)
  - -> `[431]` (*Player_Romus: ""Then we will act accordingly, Your Grace.""*)

### Węzeł `[428]`
Mówca: **Axel Reinhart**
> ""There is no other way to resolve this without the presence of a third party, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Player_Romus: ""Fine. I understand.""*)
  - -> `[466]` (*Player_Romus: ""You are right.""*)
  - -> `[467]` (*Player_Romus: ""I'm sorry but I don't support this. There are other powe..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we face those revelations together and act in the interests of peace and justice. It is a risk, but one I believe we must take for the greater good of our people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart), `[427]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Axel Reinhart: ""You might be right.""*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our expectations from the start are like this, how do we resolve this issue? If both sides want peace, why would any result change anything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart), `[427]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Axel Reinhart: ""You might be right.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we will act accordingly, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart), `[427]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Axel Reinhart: ""That doesn't inspire confidence, Your Majesty.""*)

### Węzeł `[432]`
Mówca: **Axel Reinhart**
> ""First of all, you will release our ships and our sailors immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Axel Reinhart: ""And you will pay reparations for the ship you sank, as w..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || Riz..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Axel Reinhart: ""First of all, you will release our ships and our sailors..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Axel Reinhart: ""First of all, you must pay reparations for the ship you ..."*)

### Węzeł `[436]`
Mówca: **Axel Reinhart**
> ""Needless to say, your navy will never be deployed back to Aureus again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[437]`
Mówca: **Axel Reinhart**
> ""And you will pay reparations for the ship you sank, as well as the sailors who lost their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[438]`
Mówca: **Axel Reinhart**
> ""To ensure that, we will proceed with our previously agreed-upon deal. You will officially give up your claim to the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Player_Romus: ""Absolutely not.""*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval..."*)
  - -> `[477]` (*Player_Romus: ""I can agree to the gas field but not the reparations.""*)
  - -> `[478]` (*Player_Romus: ""I can agree to the reparations but not the gas field.""*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Axel Reinhart: ""To ensure that, we will proceed with our previously agre..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[442]`
Mówca: **Axel Reinhart**
> ""To ensure that, you will cede half of the rights you obtained to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Player_Romus: ""Absolutely not.""*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval..."*)
  - -> `[477]` (*Player_Romus: ""I can agree to the gas field but not the reparations.""*)
  - -> `[478]` (*Player_Romus: ""I can agree to the reparations but not the gas field.""*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Axel Reinhart: ""To ensure that, you will cede half of the rights you obt..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Axel Reinhart: ""To ensure that, you will sign an official concession ack..."*)

### Węzeł `[446]`
Mówca: **Narrator**
> "He straightened his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Axel Reinhart: ""Okay... And who might that be?""*)

### Węzeł `[447]`
Mówca: **Axel Reinhart**
> ""What are you insinuating at?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Player_Romus: ""We cannot rule out Pales, Your Grace. I don't think I tr..."*)
  - -> `[454]` (*Player_Romus: ""I'm just saying it could be anyone. We simply cannot jum..."*)
  - -> `[449]` (*Player_Romus: ""This disparity in reports is precisely why a joint inves..."*)
  - -> `[450]` (*Player_Romus: ""Look, Your Grace. I think there's someone else behind th..."*)
  - -> `[452]` (*Player_Romus: ""This seems like a plan to sabotage our rights on the Aur..."*)

### Węzeł `[448]`
Mówca: **Axel Reinhart**
> ""What do we about it then, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Player_Romus: ""Simply nothing.""*)
  - -> `[449]` (*Player_Romus: ""This disparity in reports is precisely why a joint inves..."*)
  - -> `[450]` (*Player_Romus: ""Look, Your Grace. I think there's someone else behind th..."*)
  - -> `[452]` (*Player_Romus: ""This seems like a plan to sabotage our rights on the Aur..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This disparity in reports is precisely why a joint investigation is critical. We cannot rely solely on biased perspectives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[448]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Biased perspective? Are you su..."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look, Your Grace. I think there's someone else behind this incident. We can't point the fingers at ourselves, we must work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[448]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Narrator: "He straightened his back."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Biased perspective? Are you sugges..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Axel Reinhart: ""Biased perspective? Are you suggesting that Pales is fab..."*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This seems like a plan to sabotage our rights on the Aureus. We made a deal, Duke Reinhart and regardless of what happened, you cannot back away from it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart), `[448]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Axel Reinhart: ""What?""*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Simply nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Axel Reinhart: ""What?""*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just saying it could be anyone. We simply cannot jump to conclusions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Axel Reinhart: ""What do we about it then, Your Majesty?""*)

### Węzeł `[455]`
Mówca: **Axel Reinhart**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Axel Reinhart: ""I hope you are not claiming we had a hand in this.""*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot rule out Pales, Your Grace. I don't think I trust your words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[447]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Axel Reinhart: ""What?""*)

### Węzeł `[457]`
Mówca: **Axel Reinhart**
> ""That doesn't inspire confidence, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "He sighed."*)

### Węzeł `[458]`
Mówca: **Axel Reinhart**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Axel Reinhart: ""So you accept to conduct joint investigations together w..."*)

### Węzeł `[459]`
Mówca: **Axel Reinhart**
> ""So you accept to conduct joint investigations together with international partners or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Player_Romus: ""Yes." [Begin Investigations]"*)
  - -> `[605]` (*Player_Romus: ""Listen. I suspect this was fabricated by another player ..."*)
  - -> `[461]` (*Player_Romus: ""No. I don't see a point in it anymore.""*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes." [Begin Investigations]"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart), `[787]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_JointInvestigation = true"*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I don't see a point in it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart), `[787]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Axel Reinhart: ""Then your deal is off the table, Your Majesty.""*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PostIncident_Border_JointInvestigation = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[463]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Axel Reinhart: ""We will not take any actions until the results are in.""*)

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""Okay... And who might that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Player_Romus: ""Rumburg.""*)
  - -> `[707]` (*Player_Romus: ""Lespia.""*)
  - -> `[709]` (*Player_Romus: ""Valgsland.""*)
  - -> `[708]` (*Player_Romus: ""Morella.""*)

### Węzeł `[465]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Axel Reinhart: ""So you accept to conduct joint investigations together w..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Axel Reinhart: ""So you accept to conduct joint investigations together w..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry but I don't support this. There are other powers at play and I cannot hand them the keys.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Axel Reinhart: ""So you accept to conduct joint investigations together w..."*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Axel Reinhart: ""So you accept to conduct joint investigations together w..."*)

### Węzeł `[469]`
Mówca: **Axel Reinhart**
> ""First of all, you must pay reparations for the ship you sank, and the suffering and chaos it brought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[470]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart), `[442]` (Axel Reinhart), `[763]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He paused for a moment. His face darkened."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Pales_ListenedToDemands = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Pales_ListenedToDemands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval..."*)
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Nav..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Player_Romus: ""Anything for peace." [Accept the deal] [-2 Budget]"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[475]`
**[WYBÓR GRACZA: ""Anything for peace." [Accept the deal] [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)`
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart), `[442]` (Axel Reinhart), `[763]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 2"*)

### Węzeł `[476]`
**[WYBÓR GRACZA: ""Anything for peace." [Accept the deal] [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1` AND `(Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)) == false`
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart), `[442]` (Axel Reinhart), `[763]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can agree to the gas field but not the reparations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart), `[442]` (Axel Reinhart), `[763]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can agree to the reparations but not the gas field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart), `[442]` (Axel Reinhart), `[763]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Axel Reinhart: ""I think we can make it work, Your Majesty.""*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[482]`
Mówca: **Axel Reinhart**
> ""I think we can make it work, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Player_Romus: ""Deal." [Accept the deal]"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// RIZIA CEDES GAS FIELD`
- **Efekt skryptowy (`userScript`):** `-- RIZIA CEDES GAS FIELD;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede = true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Axel Reinhart: ""I think we can make it work, Your Majesty.""*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)

### Węzeł `[487]`
Mówca: **Axel Reinhart**
> ""I think we can make it work, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Player_Romus: ""Deal." [Accept the deal]"*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// RIZIA CEDES 25% GAS FIELD`
- **Efekt skryptowy (`userScript`):** `-- RIZIA CEDES 25% GAS FIELD;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_25 = true"*)

### Węzeł `[489]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Axel Reinhart: ""You must claim responsibility for the Palesian lives tha..."*)

### Węzeł `[490]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty. You cannot simply get the entirety of Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Axel Reinhart: ""You must, at the very least, agree to the AN's resolutio..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Axel Reinhart: ""That will not do, Your Majesty. You cannot simply get th..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Axel Reinhart: ""That will not do, Your Majesty.""*)

### Węzeł `[494]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Axel Reinhart: ""You must, at the very least, agree to the AN's resolutio..."*)

### Węzeł `[495]`
Mówca: **Axel Reinhart**
> ""You must, at the very least, agree to the AN's resolution and make the deal official. They already gave you half of the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Player_Romus: ""Absolutely not. We are not giving up anything.""*)
  - -> `[497]` (*Player_Romus: ""Fine. I agree to it." [Agree to 50%] [-1 Budget]"*)

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We are not giving up anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "He paused for a moment. His face da...."*)

### Węzeł `[497]`
**[WYBÓR GRACZA: ""Fine. I agree to it." [Agree to 50%] [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. I agree to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Pales_PostIncide..."*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But we won't, Your Grace. Your attitude made me change my mind about Aureus. Rizia will not give up an inch of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Axel Reinhart), `[525]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Axel Reinhart: ""What!?""*)

### Węzeł `[499]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "// RIZIA CEDES 25% GAS FIELD"*)

### Węzeł `[500]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Axel Reinhart), `[574]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "// RIZIA CEDES GAS FIELD"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;
RiziaDLC.Pales_PostIncident_Deal_50 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Pales_PostIncident_Deal_50"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededP..."*)

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""You must, at the very least, agree to the AN's resolution and acknowledge Palesian ownership of the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Player_Romus: ""Absolutely not. We are not giving up that field.""*)
  - -> `[506]` (*Player_Romus: ""Fine. I agree to it." [-1 Budget]"*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We are not giving up that field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[504]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "He paused for a moment. His face da...."*)

### Węzeł `[506]`
**[WYBÓR GRACZA: ""Fine. I agree to it." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. I agree to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[504]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Pales_PostIncide..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;
RiziaDLC.Pales_PostIncident_Deal_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded ..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Axel Reinhart: ""That will not do, Your Majesty. You cannot simply cancel..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[511]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty. You cannot simply cancel your deal to cede your rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Axel Reinhart: ""You must, at the very least, respect our previous agreem..."*)

### Węzeł `[512]`
Mówca: **Axel Reinhart**
> ""You must, at the very least, respect our previous agreement and make the deal official. We can reconsider reparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player_Romus: ""Absolutely not. We are not giving up that field.""*)
  - -> `[514]` (*Player_Romus: ""Fine. I agree to it." [Agree to deal]"*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We are not giving up that field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "He paused for a moment. His face da...."*)

### Węzeł `[514]`
**[WYBÓR GRACZA: ""Fine. I agree to it." [Agree to deal]"]** — Mówca: **Player_Romus**
> ""Fine. I agree to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede = true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded ..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "He paused for a moment. His face da..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He paused for a moment. His face darkened."*)

### Węzeł `[517]`
Mówca: **Axel Reinhart**
> ""That's great to hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Axel Reinhart: ""I knew you would see reason.""*)

### Węzeł `[518]`
Mówca: **Axel Reinhart**
> ""I knew you would see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Narrator: "We shook hands."*)

### Węzeł `[519]`
Mówca: **Axel Reinhart**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "He paused for a moment. His face da...."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede = true"*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Naval_FocusAidOnValero == true || Rizia..."*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || Riz..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Axel Reinhart: ""That will not do, Your Majesty.""*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Axel Reinhart: ""I think we can make it work, Your Majesty.""*)

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""You must claim responsibility for the Palesian lives that were lost in the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Player_Romus: ""But we won't, Your Grace. Your attitude made me change m..."*)
  - -> `[527]` (*Player_Romus: ""Deal." [Accept the deal] [-2 Budget]"*)

### Węzeł `[525]`
Mówca: **Axel Reinhart**
> ""I think we can make it work, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Player_Romus: ""But we won't, Your Grace. Your attitude made me change m..."*)
  - -> `[526]` (*Player_Romus: ""Deal." [Accept the deal]"*)

### Węzeł `[526]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[525]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[527]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal] [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede = true"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded ..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded ..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_25 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededP..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded ..."*)

### Węzeł `[533]`
Mówca: **Axel Reinhart**
> ""That's great to hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Axel Reinhart: ""I knew you would see reason.""*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's calm down, Your Grace. Nobody wants a war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Axel Reinhart: ""Rizia cannot threaten us with war anymore, Your Majesty...."*)

### Węzeł `[535]`
Mówca: **Axel Reinhart**
> ""Rizia cannot threaten us with war anymore, Your Majesty. I thought you were a more careful man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Axel Reinhart: ""And you seem not to be aware of our naval capabilities.""*)

### Węzeł `[536]`
Mówca: **Axel Reinhart**
> ""And you seem not to be aware of our naval capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Axel Reinhart: ""I intend to block your access to Aureus, and I don't thi..."*)

### Węzeł `[537]`
Mówca: **Axel Reinhart**
> ""I intend to block your access to Aureus, and I don't think you can do anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Player_Romus: ""You will not get away with this.""*)
  - -> `[540]` (*Player_Romus: ""If you try to block our access, we will take it by force..."*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not get away with this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Axel Reinhart), `[537]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. O..."*)

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This would be cause for war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. O..."*)

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This is a cause for war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[537]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. O..."*)

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Take the whole field. I couldn't care less.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[421]` (Axel Reinhart), `[543]` (Axel Reinhart), `[537]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "He looked at me with skepticism."*)

### Węzeł `[542]`
Mówca: **Axel Reinhart**
> ""As I already said, it is not a matter of *if* anymore. Our navy should be arriving as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Axel Reinhart: ""Pales is ready to defend what is ours.""*)

### Węzeł `[543]`
Mówca: **Axel Reinhart**
> ""Pales is ready to defend what is ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Player_Romus: ""We will not retaliate. But you are making a mistake. Thi..."*)
  - -> `[545]` (*Player_Romus: ""Then war it is, Your Grace.""*)
  - -> `[541]` (*Player_Romus: ""Fine. Take the whole field. I couldn't care less.""*)

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not retaliate. But you are making a mistake. This will have dire consequences for both of our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[543]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Axel Reinhart: ""You have forced my hand, Your Majesty.""*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then war it is, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[543]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "// WAR!"*)

### Węzeł `[546]`
Mówca: **Narrator**
> "He looked at me with skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Axel Reinhart: ""I will.""*)

### Węzeł `[547]`
Mówca: **Axel Reinhart**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Axel Reinhart: ""As long as Rizia respects our claim and our sovereignty,..."*)

### Węzeł `[548]`
Mówca: **Axel Reinhart**
> ""As long as Rizia respects our claim and our sovereignty, we can still work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""I will cede all of our rights to Pales. We don't need to..."*)
  - -> `[550]` (*Player_Romus: ""I can never officially recognize that, Your Grace. But I..."*)
  - -> `[551]` (*Player_Romus: ""There will be no more working together. Let that be clear.""*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will cede all of our rights to Pales. We don't need to be enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Axel Reinhart), `[603]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Axel Reinhart: ""Really? You would do that for Pales?""*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can never officially recognize that, Your Grace. But I intend to leave Pales alone. We don't need to be enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Axel Reinhart: ""I understand this was a difficult decision to make.""*)

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no more working together. Let that be clear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Axel Reinhart), `[563]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Axel Reinhart: ""I'm sorry you came all the way here for this.""*)

### Węzeł `[552]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_Deal = true"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// WAR!`
- **Efekt skryptowy (`userScript`):** `-- WAR!;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Narrator: "A sudden spasm of fear took hold of his face."*)

### Węzeł `[554]`
Mówca: **Axel Reinhart**
> ""You have forced my hand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Axel Reinhart: ""I would have rather have come to an understanding. But h..."*)

### Węzeł `[555]`
Mówca: **Axel Reinhart**
> ""I would have rather have come to an understanding. But here we are...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Player_Romus: ""Well... Thank you for the meeting nonetheless.""*)
  - -> `[557]` (*Player_Romus: ""Thank you for nothing.""*)
  - -> `[558]` (*Player_Romus: ""You know what? In the name of friendship, I'm willing to..."*)
  - -> `[576]` (*Player_Romus: ""If you don't pull your ships back from the field... War ..."*)

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... Thank you for the meeting nonetheless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Axel Reinhart: ""I'm sorry you came all the way here for this.""*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Axel Reinhart: ""I'm sorry you came all the way here for this.""*)

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? In the name of friendship, I'm willing to officially cede our rights to the field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Narrator: "He looked at me with skepticism."*)

### Węzeł `[559]`
Mówca: **Narrator**
> "He looked at me with skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Axel Reinhart: ""That would be a massive gesture.""*)

### Węzeł `[560]`
Mówca: **Axel Reinhart**
> ""That would be a massive gesture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Axel Reinhart: ""As long as Rizia respects our claim and our sovereignty,..."*)

### Węzeł `[561]`
Mówca: **Axel Reinhart**
> ""I'm sorry you came all the way here for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Narrator: "He stood up and reached out for a handshake."*)

### Węzeł `[562]`
Mówca: **Axel Reinhart**
> ""I understand this was a difficult decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Axel Reinhart: ""But perhaps we can still work together in the future.""*)

### Węzeł `[563]`
Mówca: **Axel Reinhart**
> ""But perhaps we can still work together in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player_Romus: ""Despite everything, Rizia is ready for that, Your Grace...."*)
  - -> `[569]` (*Player_Romus: ""We will see about that.""*)
  - -> `[551]` (*Player_Romus: ""There will be no more working together. Let that be clear.""*)

### Węzeł `[564]`
Mówca: **Narrator**
> "He stood up and reached out for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[566]` (*Player_Romus_Italic: "Ignore his hand."*)

### Węzeł `[565]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "We shook hands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[564]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty.""*)

### Węzeł `[566]`
**[WYBÓR GRACZA: "Ignore his hand."]** — Mówca: **Player_Romus_Italic**
> "I ignored his hand and stood up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[564]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty.""*)

### Węzeł `[567]`
Mówca: **Axel Reinhart**
> ""Well, then. Have a nice day, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "DisableToken("Rizia_Event_Aureus");"*)

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite everything, Rizia is ready for that, Your Grace. You can count on us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Axel Reinhart: ""At least we have reached some level of understanding.""*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will see about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Axel Reinhart: ""At least we have reached some level of understanding.""*)

### Węzeł `[570]`
Mówca: **Axel Reinhart**
> ""At least we have reached some level of understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Axel Reinhart: ""Thank you for coming to Pales, Your Majesty.""*)

### Węzeł `[571]`
Mówca: **Narrator**
> "We both stood up and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty.""*)

### Węzeł `[572]`
Mówca: **Axel Reinhart**
> ""Thank you for coming to Pales, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Narrator: "We both stood up and shook hands."*)

### Węzeł `[573]`
Mówca: **Axel Reinhart**
> ""Really? You would do that for Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Axel Reinhart: ""If you cede the field to us officially, not only the inc..."*)

### Węzeł `[574]`
Mówca: **Axel Reinhart**
> ""If you cede the field to us officially, not only the incident can be put behind us but I would be indebted to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Player_Romus: ""Well... No I can't. Thank you for the meeting nonetheless.""*)
  - -> `[500]` (*Player_Romus: ""Deal." [Accept the deal]"*)

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... No I can't. Thank you for the meeting nonetheless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Axel Reinhart: ""I'm sorry you came all the way here for this.""*)

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't pull your ships back from the field... War it is, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "// WAR!"*)

### Węzeł `[577]`
Mówca: **Narrator**
> "A sudden spasm of fear took hold of his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Axel Reinhart: ""I see.""*)

### Węzeł `[578]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War = true; RiziaDLC.Situation_Military_Pa..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_NoDeal = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentNoDeal = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentNoDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentNoDeal"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentNoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit ..."*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War = true;
RiziaDLC.Situation_Military_PalesianWarDeployment = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentTalkBreakdown = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentTalkBreakdown = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower = -100;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_War"] = true;
Variable["RiziaDLC.Situation_Military_PalesianWarDeployment"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentTalkBreakdown"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentTalkBreakdown"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -100;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_V_PalesWarStart = true; Rizia..."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Peace_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Axel Reinhart: ""We will make it official soon, Your Majesty. I will invi..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)"*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede = true; RiziaDLCSup..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_Cede = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Axel Reinhart: ""That's great to hear!""*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_PostIncident_Deal_25 = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Axel Reinhart: ""That's great to hear!""*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Axel Reinhart: ""Needless to say, Vina will be returned to Rizia -- witho..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Axel Reinhart: ""Needless to say, your navy will never be deployed back t..."*)

### Węzeł `[590]`
Mówca: **Axel Reinhart**
> ""Needless to say, Vina will be returned to Rizia -- without a scratch on her, by the way. But of course, your navy will never be deployed back to Aureus again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Axel Reinhart: ""And I'm afraid I may have changed my mind about allowing..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Axel Reinhart: ""We will not bow down against your aggression any longer...."*)

### Węzeł `[594]`
Mówca: **Axel Reinhart**
> ""And I'm afraid I may have changed my mind about allowing your daughter to return home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Axel Reinhart: ""We will not bow down against your aggression any longer...."*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Player_Romus: ""If you do anything to Vina, Pales will cease to exist, Y..."*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""You cannot afford to keep your navy at the field at all ..."*)

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you do anything to Vina, Pales will cease to exist, Your Grace. I promise you that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Axel Reinhart: ""Rizia cannot threaten us with war anymore, Your Majesty...."*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Player_Romus: ""Fine. Just take the whole field in exchange for Vina.""*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Player_Romus: ""Fine. Take the whole field. I couldn't care less.""*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Just take the whole field in exchange for Vina.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[537]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Axel Reinhart: ""If you make the deal official, we can still work together.""*)

### Węzeł `[603]`
Mówca: **Axel Reinhart**
> ""If you make the deal official, we can still work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""I will cede all of our rights to Pales. We don't need to..."*)
  - -> `[604]` (*Player_Romus: ""No. I won't sign that deal. But you have to let Vina go...."*)

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I won't sign that deal. But you have to let Vina go. Otherwise it will be war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[603]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "// WAR!"*)

### Węzeł `[605]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen. I suspect this was fabricated by another player in our region. We should be working together instead of suspecting each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Narrator: "He straightened his back."*)

### Węzeł `[606]`
Mówca: **Axel Reinhart**
> ""Then your deal is off the table, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Axel Reinhart: ""If Rizia can't be a trustable partner, I will not sign t..."*)

### Węzeł `[607]`
Mówca: **Axel Reinhart**
> ""If Rizia can't be a trustable partner, I will not sign the papers -- and you will not be able to extract anything from Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Axel Reinhart: ""We will not bow down against your aggression any longer...."*)

### Węzeł `[608]`
Mówca: **Axel Reinhart**
> ""I hope you are not claiming we had a hand in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Axel Reinhart: ""And you know what, Your Majesty? We can back off from th..."*)

### Węzeł `[609]`
Mówca: **Axel Reinhart**
> ""And you know what, Your Majesty? We can back off from the deal, because the extraction rights were not officially finalized yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Player_Romus: ""You can't do that.""*)
  - -> `[611]` (*Player_Romus: ""That would be a grand mistake.""*)
  - -> `[612]` (*Player_Romus: ""Look, Your Grace. I think there's someone else behind th..."*)
  - -> `[613]` (*Player_Romus: ""We cannot rely solely on biased perspectives, Your Grace..."*)

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[609]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Axel Reinhart: ""Well... If you're not offering any solution out of this ..."*)

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be a grand mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[609]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Axel Reinhart: ""Well... If you're not offering any solution out of this ..."*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look, Your Grace. I think there's someone else behind this incident. We can't point the fingers at ourselves, we must work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[609]` (Axel Reinhart), `[615]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Narrator: "He straightened his back."*)

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot rely solely on biased perspectives, Your Grace. We should investigate this incident thoroughly before taking any drastic actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[609]` (Axel Reinhart), `[615]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Biased perspective? Are you su..."*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Biased perspective? Are you sugges..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Axel Reinhart: ""Biased perspective? Are you suggesting that Pales is fab..."*)

### Węzeł `[615]`
Mówca: **Axel Reinhart**
> ""Well... If you're not offering any solution out of this mess, I will back off from the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Player_Romus: ""I'm not going to play into your hand. Rizia is not going..."*)
  - -> `[612]` (*Player_Romus: ""Look, Your Grace. I think there's someone else behind th..."*)
  - -> `[613]` (*Player_Romus: ""We cannot rely solely on biased perspectives, Your Grace..."*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""Then your deal is off the table, Y..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Axel Reinhart: ""Then your deal is off the table, Your Majesty.""*)

### Węzeł `[617]`
Mówca: **Axel Reinhart**
> ""We will make it official soon, Your Majesty. I will invite you to Pales again for the final steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Axel Reinhart: ""I hope no more incidents will take place before then.""*)

### Węzeł `[618]`
Mówca: **Axel Reinhart**
> ""I hope no more incidents will take place before then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Player_Romus: ""Agreed.""*)
  - -> `[621]` (*Player_Romus: ""I won't let that happen.""*)
  - -> `[620]` (*Player_Romus: ""The responsibility falls on both of our shoulders.""*)
  - -> `[619]` (*Player_Romus: ""I hope not.""*)

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty. We'll see eac..."*)

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The responsibility falls on both of our shoulders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty. We'll see eac..."*)

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't let that happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty. We'll see eac..."*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[618]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty. We'll see eac..."*)

### Węzeł `[623]`
Mówca: **Axel Reinhart**
> ""Well, then. Have a nice day, Your Majesty. We'll see each other again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit ..."*)

### Węzeł `[624]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_JointInvestigation == true"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[627]`
Mówca: **Narrator**
> "I left the meeting room with quick steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Narrator: "Laurento was waiting for me outside. I told him about eve..."*)

### Węzeł `[628]`
Mówca: **Narrator**
> "Laurento was waiting for me outside. I told him about everything we'd talked about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[629]`
Mówca: **Axel Reinhart**
> ""Well, then. Have a nice day, Your Majesty. We'll see each other again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_JointInvestigation = true; R..."*)

### Węzeł `[630]`
Mówca: **Axel Reinhart**
> ""We will not bow down against your aggression any longer. Rizia will have no access whatsoever to any energy from the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Player_Romus: ""That would be a cause for war.""*)
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[652]` (*Player_Romus: ""You intended to escalate the situation further after all..."*)
  - -> `[653]` (*Player_Romus: ""The world will learn about how you cancelled the deal. L..."*)
  - -> `[633]` (*Player_Romus: ""Let's calm down, Your Grace. Nobody wants a war.""*)

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be a cause for war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[630]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Axel Reinhart: ""Your attack was the cause for everything, Your Majesty, ..."*)

### Węzeł `[632]`
Mówca: **Axel Reinhart**
> ""If you really think the AN would support Rizia, you are living in a land of fantasy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Player_Romus: ""You will not get away with this.""*)
  - -> `[638]` (*Player_Romus: ""If you try to block our access, we will take it by force..."*)
  - -> `[640]` (*Player_Romus: ""Fine. Take the whole field. I couldn't care less. I will..."*)

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's calm down, Your Grace. Nobody wants a war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[630]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Axel Reinhart: ""Rizia cannot threaten us with war anymore, Your Majesty...."*)

### Węzeł `[634]`
Mówca: **Axel Reinhart**
> ""Rizia cannot threaten us with war anymore, Your Majesty. I thought you were a more careful man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Axel Reinhart: ""And you seem not to be aware of our navy's capabilities.""*)

### Węzeł `[635]`
Mówca: **Axel Reinhart**
> ""And you seem not to be aware of our navy's capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Axel Reinhart: ""I intend to block access to Rizia, and I don't think you..."*)

### Węzeł `[636]`
Mówca: **Axel Reinhart**
> ""I intend to block access to Rizia, and I don't think you can do anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Player_Romus: ""Let's calm down, Your Grace. Can't we work something out..."*)
  - -> `[637]` (*Player_Romus: ""You will not get away with this.""*)
  - -> `[639]` (*Player_Romus: ""If you try to block our access, we will take it by force..."*)
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[637]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not get away with this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[632]` (Axel Reinhart), `[636]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. D..."*)

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This would be cause for war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[632]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. D..."*)

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This is a cause for war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[636]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. D..."*)

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Take the whole field. I couldn't care less. I will back off from the deal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[632]` (Axel Reinhart), `[642]` (Axel Reinhart), `[636]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "He looked at me with skepticism."*)

### Węzeł `[641]`
Mówca: **Axel Reinhart**
> ""As I already said, it is not a matter of *if* anymore. Deal is off the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Axel Reinhart: ""Rizia will not extract anything from Aureus.""*)

### Węzeł `[642]`
Mówca: **Axel Reinhart**
> ""Rizia will not extract anything from Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Player_Romus: ""You are making a mistake. This will have dire consequenc..."*)
  - -> `[644]` (*Player_Romus: ""Then war it is, Your Grace.""*)
  - -> `[640]` (*Player_Romus: ""Fine. Take the whole field. I couldn't care less. I will..."*)

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are making a mistake. This will have dire consequences for both of our countries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[642]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Axel Reinhart: ""You forced my hand, Your Majesty.""*)

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then war it is, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[642]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "A sudden spasm of fear took hold of...."*)

### Węzeł `[645]`
Mówca: **Narrator**
> "He looked at me with skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[646]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Axel Reinhart: ""As long as Rizia respects it, we may still continue our ..."*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Player_Romus: ""Fine. Just take the whole field in exchange for Vina. I ..."*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Player_Romus: ""Fine. Take the whole field. I couldn't care less. I will..."*)

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Just take the whole field in exchange for Vina. I will back off from the deal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[636]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot simply back off from the deal at the last minute like this, Your Grace.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[630]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Axel Reinhart: ""Oh, but I can, Your Majesty.""*)

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You intended to escalate the situation further after all...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[630]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Axel Reinhart: ""Your attack was the cause for everything, Your Majesty, ..."*)

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world will learn about how you cancelled the deal. Let's see who they'll support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[630]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Axel Reinhart: ""You seem confident despite having no real friends outsid..."*)

### Węzeł `[654]`
Mówca: **Axel Reinhart**
> ""You seem confident despite having no real friends outside of GRACE, Your Majesty. We have powerful allies in the international arena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Axel Reinhart: ""If you really think the AN would support Rizia, you are ..."*)

### Węzeł `[655]`
Mówca: **Axel Reinhart**
> ""Oh, but I can, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Axel Reinhart: ""I intend to block access to Rizia, and I don't think you..."*)

### Węzeł `[656]`
Mówca: **Axel Reinhart**
> ""Your attack was the cause for everything, Your Majesty, and you know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Axel Reinhart: ""Rizia cannot threaten us with war anymore, Your Majesty...."*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Player_Romus: ""If you do anything to Vina, Pales will cease to exist, Y..."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Player_Romus: ""You cannot simply back off from the deal at the last min..."*)

### Węzeł `[660]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you do anything to Vina, Pales will cease to exist, Your Grace. I promise you that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[630]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Axel Reinhart: ""Rizia cannot threaten us with war anymore, Your Majesty...."*)

### Węzeł `[661]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's calm down, Your Grace. Can't we work something out? Rizia wants to keep the deal between our countries. We've invested so much into this project.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[636]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[662]`
Mówca: **Axel Reinhart**
> ""You forced my hand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Axel Reinhart: ""I would have rather achieved something here today. But h..."*)

### Węzeł `[663]`
Mówca: **Axel Reinhart**
> ""I would have rather achieved something here today. But here we are...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Player_Romus: ""Well... Thank you for the meeting nonetheless.""*)
  - -> `[665]` (*Player_Romus: ""Thank you for nothing.""*)
  - -> `[666]` (*Player_Romus: ""If you don't sign that deal, then war it is, Your Grace.""*)
  - -> `[670]` (*Player_Romus: ""I can not force you to sign the deal, Your Grace. But I ..."*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... Thank you for the meeting nonetheless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[663]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""I'm sorry you came all the way..."*)

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[663]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""I'm sorry you came all the way..."*)

### Węzeł `[666]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't sign that deal, then war it is, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[663]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "A sudden spasm of fear took hold of...."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "A sudden spasm of fear took hold of..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Narrator: "A sudden spasm of fear took hold of his face."*)

### Węzeł `[668]`
Mówca: **Axel Reinhart**
> ""As long as Rizia respects it, we may still continue our relations with your kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Player_Romus: ""Fine. Aureus is completely yours. We don't need to be en..."*)
  - -> `[670]` (*Player_Romus: ""I can not force you to sign the deal, Your Grace. But I ..."*)
  - -> `[671]` (*Player_Romus: ""You know what, Your Grace? If you go this path, expect a..."*)

### Węzeł `[669]`
**[WYBÓR GRACZA: ""Fine. Aureus is completely yours. We don't need to be enemies.""]** — Mówca: **Player_Romus**
> ""Fine. Aureus is completely yours. We don't need to be enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[668]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Axel Reinhart: ""Then, peace will prevail.""*)

### Węzeł `[670]`
**[WYBÓR GRACZA: ""I can not force you to sign the deal, Your Grace. But I don't intend to work together with Pales anymore. You have lost the support of Rizia.""]** — Mówca: **Player_Romus**
> ""I can not force you to sign the deal, Your Grace. But I don't intend to work together with Pales anymore. You have lost the support of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[663]` (Axel Reinhart), `[668]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Axel Reinhart: ""So be it.""*)

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what, Your Grace? If you go this path, expect a military response. War, it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[668]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "A sudden spasm of fear took hold of...."*)

### Węzeł `[672]`
Mówca: **Axel Reinhart**
> ""Then, peace will prevail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""I understand this was a diffic..."*)

### Węzeł `[673]`
Mówca: **Axel Reinhart**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""I understand this was a diffic..."*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""I understand this was a difficult..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Axel Reinhart: ""I understand this was a difficult decision to make.""*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""I'm sorry you came all the way her..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Axel Reinhart: ""I'm sorry you came all the way here for this.""*)

### Węzeł `[676]`
Mówca: **Axel Reinhart**
> ""We will not take any actions until the results are in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Axel Reinhart: ""But until we clear this up, we have to cancel the offici..."*)

### Węzeł `[677]`
Mówca: **Axel Reinhart**
> ""But until we clear this up, we have to cancel the official signing of our deal for the time being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Axel Reinhart: ""Until we have clear answers, Pales will not be transferr..."*)

### Węzeł `[678]`
Mówca: **Axel Reinhart**
> ""Until we have clear answers, Pales will not be transferring the extraction rights to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Player_Romus: ""Agreed.""*)
  - -> `[679]` (*Player_Romus: ""Can you give me any guarantee that you will sign the dea..."*)
  - -> `[680]` (*Player_Romus: ""That's fair. I understand.""*)
  - -> `[681]` (*Player_Romus: ""We have invested heavily into this project, Your Grace. ..."*)

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you give me any guarantee that you will sign the deal after the investigations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[678]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Axel Reinhart: ""As long as Rizia's name has been cleared, I promise you,..."*)

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fair. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[678]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Axel Reinhart: ""Great to hear.""*)

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have invested heavily into this project, Your Grace. If you decide to sabotage it, I promise you, Pales will pay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[678]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Axel Reinhart: ""There is no need for threats.""*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[678]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Axel Reinhart: ""Great to hear.""*)

### Węzeł `[683]`
Mówca: **Axel Reinhart**
> ""Great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Axel Reinhart: ""Thank you for coming to Pales.""*)

### Węzeł `[684]`
Mówca: **Narrator**
> "We both stood up and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Axel Reinhart: ""Well, then. Have a nice day, Your Majesty. We'll see eac..."*)

### Węzeł `[685]`
Mówca: **Axel Reinhart**
> ""Thank you for coming to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Narrator: "We both stood up and shook hands."*)

### Węzeł `[686]`
Mówca: **Axel Reinhart**
> ""As long as Rizia's name has been cleared, I promise you, we will continue with the deal as promised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Axel Reinhart: ""Thank you for coming to Pales.""*)

### Węzeł `[687]`
Mówca: **Axel Reinhart**
> ""If Rizia's name will be cleared, Pales will resume the deal as promised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Player_Romus: ""I understand.""*)
  - -> `[689]` (*Player_Romus: ""Alright. Thank you for the meeting, Your Grace.""*)
  - -> `[690]` (*Player_Romus: ""Good. You'd better not break your promise.""*)

### Węzeł `[688]`
Mówca: **Axel Reinhart**
> ""There is no need for threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Axel Reinhart: ""If Rizia's name will be cleared, Pales will resume the d..."*)

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Thank you for the meeting, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[687]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Axel Reinhart: ""Thank you for coming to Pales.""*)

### Węzeł `[690]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. You'd better not break your promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[687]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Axel Reinhart: ""Thank you for coming to Pales.""*)

### Węzeł `[691]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[687]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Axel Reinhart: ""Thank you for coming to Pales.""*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PostIncident_Border_JointInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PostIncident_Border_JointInvestigation == true"*)
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PostIncident_Border_JointInvestigation == true)"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PostIncident_Border_JointInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Axel Reinhart: ""Oh, by the way... Miss Toras will be staying with us unt..."*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PostIncident_Border_JointInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Narrator: "The Duke waved his hand. The door opened, and I saw Vina ..."*)

### Węzeł `[695]`
Mówca: **Narrator**
> "The Duke waved his hand. The door opened, and I saw Vina waiting for me outside by the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Axel Reinhart: ""We do not take hostages here, Your Majesty.""*)

### Węzeł `[696]`
Mówca: **Axel Reinhart**
> ""We do not take hostages here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < -1"*)

### Węzeł `[697]`
Mówca: **Narrator**
> "He smiled as my daughter rushed to embrace me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[698]`
Mówca: **Axel Reinhart**
> ""Oh, by the way... Miss Toras will be staying with us until the investigations are complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage = true"*)

### Węzeł `[699]`
Mówca: **Axel Reinhart**
> ""You are making the same mistakes are your father, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Axel Reinhart: ""You will be responsible for all of the lives that will b..."*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage = true; RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Axel Reinhart: ""Goodbye, Romus. I'll take good care of your daughter unt..."*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)"*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage = true; RiziaDLCSupport.Reports_Tur..."*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Narrator: "His security quickly ushered me outside."*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Narrator: "He smiled broadly."*)

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to play into your hand. Rizia is not going to be forced to offer anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[615]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""Then your deal is off the tabl..."*)

### Węzeł `[706]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Axel Reinhart: ""The Queen?""*)

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Axel Reinhart: ""Of course you would say that.""*)

### Węzeł `[708]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Axel Reinhart: ""Why would Morellans be behind this, Your Majesty?""*)

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Valgsland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Axel Reinhart: ""Yes... Valgsland has ambitions in these regions. But the..."*)

### Węzeł `[710]`
Mówca: **Axel Reinhart**
> ""Why would Morellans be behind this, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Axel Reinhart: ""Their influence and presence is all too weak to orchestr..."*)

### Węzeł `[711]`
Mówca: **Axel Reinhart**
> ""Their influence and presence is all too weak to orchestrate something of this scale without alerting our security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Player_Romus: ""You are underestimating their new government. Prime Mini..."*)
  - -> `[726]` (*Player_Romus: ""They are commies, Axel. You know what they are capable of.""*)
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[781]` (*Player_Romus: ""We are a threat in their eyes. Morella doesn't want our ..."*)

### Węzeł `[712]`
Mówca: **Axel Reinhart**
> ""The Queen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Axel Reinhart: ""Isn't she the one who's fuelling Rizia's political ambit..."*)

### Węzeł `[713]`
Mówca: **Axel Reinhart**
> ""Isn't she the one who's fuelling Rizia's political ambitions in Southern Merkopa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true"*)

### Węzeł `[714]`
Mówca: **Axel Reinhart**
> ""Are you claiming she wanted to stop Rizia from getting access to more gas -- despite being Rizia's largest energy partner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || Ri..."*)
  - -> `[721]` (*Player_Romus: ""The amount of gas we'll gain from Aureus will have other..."*)
  - -> `[722]` (*Player_Romus: ""She is counting on Rizia to annex Pales and become more ..."*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || RiziaDLC.CountryRelation_Rumburg_Hostile == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || Ri..."*)
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || ..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || RiziaDLC.CountryRelation_Rumburg_Hostile == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Player_Romus: ""Our relationship has soured of late. I suspect my sister..."*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || RiziaDLC.CountryRelation_Rumburg_Hostile == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Player_Romus: ""I know her well and I don't trust her one bit. I suspect..."*)

### Węzeł `[718]`
Mówca: **Axel Reinhart**
> ""Yes... Valgsland has ambitions in these regions. But they don't have any reason to sabotage this deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Player_Romus: ""You know they will come to reclaim Pales sooner or later..."*)
  - -> `[731]` (*Player_Romus: ""They are commies, Axel. You know what they are capable of.""*)
  - -> `[732]` (*Player_Romus: ""We are a threat in their eyes. Valgsland doesn't want ou..."*)

### Węzeł `[719]`
Mówca: **Axel Reinhart**
> ""Of course you would say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Axel Reinhart: ""Lespia is our biggest partner. And you've been long desp..."*)

### Węzeł `[720]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our relationship has soured of late. I suspect my sister-in-law is trying to hassle us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true` AND `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Axel Reinhart), `[713]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[721]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The amount of gas we'll gain from Aureus will have other nations begging at our feet. Queen Beatrice would never stand for it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Axel Reinhart), `[713]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[722]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is counting on Rizia to annex Pales and become more powerful -- and thus of more use to her.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Axel Reinhart), `[713]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[723]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Axel Reinhart: ""There are no reports or traces of any Rumburgian activit..."*)

### Węzeł `[724]`
Mówca: **Axel Reinhart**
> ""There are no reports or traces of any Rumburgian activity. If you cannot show me any proof -- this will only sound like a conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[725]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are underestimating their new government. Prime Minister Saltana is a troublesome woman. She wants our monarchies gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[711]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are commies, Axel. You know what they are capable of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[711]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are fighting against Saltana's nationalization of the Meftiem International Trade Zone. This is her way of incapacitating us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[711]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[728]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Axel Reinhart: ""There are no reports or traces of any Morellan activity...."*)

### Węzeł `[729]`
Mówca: **Axel Reinhart**
> ""There are no reports or traces of any Morellan activity. If you cannot show me any proof -- this will only sound like a conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know they will come to reclaim Pales sooner or later, Your Grace. That's why they want to keep the field in your hands for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[718]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[731]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are commies, Axel. You know what they are capable of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[718]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[732]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are a threat in their eyes. Valgsland doesn't want our countries to be close.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[718]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[733]`
Mówca: **Axel Reinhart**
> ""And I want a neutral investigation by the international community to be conducted. We will wait for the results before finalizing the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Axel Reinhart: ""These are my terms, Your Majesty.""*)

### Węzeł `[734]`
Mówca: **Axel Reinhart**
> ""I want Rizia to pay reparations for the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Axel Reinhart: ""And I want a neutral investigation by the international ..."*)

### Węzeł `[735]`
Mówca: **Axel Reinhart**
> ""These are my terms, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[737]` (*Player_Romus: ""There's no way I can accept this. If you back away from ..."*)

### Węzeł `[736]`
**[WYBÓR GRACZA: ""Deal." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Kontekst wejściowy (poprzednik):** `[735]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[737]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no way I can accept this. If you back away from our deal like this, you will be throwing everything you had with Rizia away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[735]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Axel Reinhart: ""As I already said, it is not a matter of *if* anymore. D..."*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PostIncident_Border_JointInvestigation = true;
RiziaDLC.Pales_PostIncident_Peace_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] = true;
Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit ..."*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Axel Reinhart: ""As long as Rizia's name has been cleared, I promise you,..."*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Axel Reinhart: ""I want Rizia to pay reparations for the incident.""*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Axel Reinhart: ""I want a neutral investigation by the international comm..."*)

### Węzeł `[743]`
Mówca: **Axel Reinhart**
> ""I want a neutral investigation by the international community to be conducted. We will wait for the results before finalizing the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Axel Reinhart: ""These are my terms, Your Majesty.""*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Player_Romus: ""Deal." [-1 Budget]"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Player_Romus: ""Deal.""*)

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Deal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[735]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Axel Reinhart: ""As long as Rizia's name has been cleared, I promise you,..."*)

### Węzeł `[748]`
Mówca: **Axel Reinhart**
> ""You will be responsible for all of the lives that will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Narrator: "He quickly got up and gestured at the door."*)

### Węzeł `[749]`
Mówca: **Narrator**
> "He quickly got up and gestured at the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Axel Reinhart: ""You are no longer welcome here.""*)

### Węzeł `[750]`
Mówca: **Axel Reinhart**
> ""You are no longer welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Player_Romus: ""We will meet again.""*)
  - -> `[753]` (*Player_Romus: ""I offered you a chance for peace, Axel. But you are stan..."*)
  - -> `[755]` (*Player_Romus: ""Don't worry. We will make it quick.""*)

### Węzeł `[751]`
Mówca: **Axel Reinhart**
> ""Goodbye, Romus. I'll take good care of your daughter until the war is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Narrator: "His security quickly ushered me outside."*)

### Węzeł `[752]`
Mówca: **Narrator**
> "His security quickly ushered me outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Narrator: "I walked through the hall with quick steps -- images of w..."*)

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I offered you a chance for peace, Axel. But you are standing in my way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[750]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[754]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will meet again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[750]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[755]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. We will make it quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[750]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[756]`
Mówca: **Narrator**
> "I walked through the hall with quick steps -- images of war and horror appearing in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Narrator: "Laurento was waiting for me outside with a concerned look..."*)

### Węzeł `[757]`
Mówca: **Narrator**
> "Laurento was waiting for me outside with a concerned look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Narrator: "I tried to tell him about what happened with as few words..."*)

### Węzeł `[758]`
Mówca: **Narrator**
> "I tried to tell him about what happened with as few words as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[759]`
Mówca: **Narrator**
> "He smiled broadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Narrator: "I took one last look back as I went outside to rejoin Lau..."*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_25 = true; RiziaDLCSuppo..."*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Deal_Cede = true; RiziaDLCSup..."*)

### Węzeł `[763]`
Mówca: **Axel Reinhart**
> ""To ensure that, you will sign an official concession acknowledging the AN arbitration results and Pales' full ownership of the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Player_Romus: ""Absolutely not.""*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval..."*)
  - -> `[477]` (*Player_Romus: ""I can agree to the gas field but not the reparations.""*)
  - -> `[478]` (*Player_Romus: ""I can agree to the reparations but not the gas field.""*)

### Węzeł `[764]`
Mówca: **Axel Reinhart**
> ""Don't mock me, Your Majesty. Consider your offer rejected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true"*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < -1"*)
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < -1)"*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "As Laurento, Vina and I left the castle, my daughter was ..."*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Narrator: "He smiled as my daughter rushed to embrace me."*)

### Węzeł `[768]`
Mówca: **Narrator**
> "As Laurento, Vina and I left the castle, my daughter was the only one who wasn't smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[769]`
Mówca: **Narrator**
> "I took one last look back as I went outside to rejoin Laurento and tell him what I'd agreed to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[770]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true"*)
  - -> `[772]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true)"*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Axel Reinhart: ""Are you claiming she wanted to stop Rizia from getting a..."*)

### Węzeł `[772]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Player_Romus: ""Our relationship has soured of late. I suspect my sister..."*)
  - -> `[721]` (*Player_Romus: ""The amount of gas we'll gain from Aureus will have other..."*)
  - -> `[722]` (*Player_Romus: ""She is counting on Rizia to annex Pales and become more ..."*)

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true )"*)

### Węzeł `[774]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Player_Romus: ""We are fighting against Saltana's nationalization of the..."*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[776]`
Mówca: **Axel Reinhart**
> ""Lespia is our biggest partner. And you've been long despising the assistance they've given us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Player_Romus: ""And they have been pushing over the control of Aureus th..."*)
  - -> `[790]` (*Player_Romus: ""That is precisely the point. They want you to stay relia..."*)
  - -> `[791]` (*Player_Romus: ""We are a threat in their eyes. Lespia doesn't want our c..."*)
  - -> `[792]` (*Player_Romus: ""They are the direct agents of ATO in all Eastern Merkopa..."*)

### Węzeł `[777]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Axel Reinhart: ""There are no reports or traces of any Valgish activity. ..."*)

### Węzeł `[778]`
Mówca: **Axel Reinhart**
> ""There are no reports or traces of any Valgish activity. If you cannot show me any proof -- this will only sound like a conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[779]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]` (*Player_Romus: ""Just think about it, Axel. It just makes sense.""*)
  - -> `[783]` (*Player_Romus: ""I don't have any proof.""*)
  - -> `[784]` (*Player_Romus: ""What else do you want? That's enough proof of their medd..."*)

### Węzeł `[780]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know her well and I don't trust her one bit. I suspect my sister-in-law is trying to hassle us.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[714]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are a threat in their eyes. Morella doesn't want our countries to be close.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[711]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just think about it, Axel. It just makes sense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[724]` (Axel Reinhart), `[729]` (Axel Reinhart), `[778]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Axel Reinhart: ""No, Your Majesty.""*)

### Węzeł `[783]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have any proof.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[724]` (Axel Reinhart), `[729]` (Axel Reinhart), `[778]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Axel Reinhart: ""No, Your Majesty.""*)

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What else do you want? That's enough proof of their meddling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[724]` (Axel Reinhart), `[729]` (Axel Reinhart), `[778]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Axel Reinhart: ""No, Your Majesty.""*)

### Węzeł `[785]`
Mówca: **Axel Reinhart**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Axel Reinhart: ""I am much more convinced that we need this neutral inves..."*)

### Węzeł `[786]`
Mówca: **Axel Reinhart**
> ""I am much more convinced that we need this neutral investigation. I don't see any other path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "Jump to: [Axel Reinhart: ""So do you accept to conduct jo..."*)

### Węzeł `[787]`
Mówca: **Axel Reinhart**
> ""So do you accept to conduct joint investigations together with international partners or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Player_Romus: ""Yes." [Begin Investigations]"*)
  - -> `[461]` (*Player_Romus: ""No. I don't see a point in it anymore.""*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Axel Reinhart: ""So do you accept to conduct joint..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Axel Reinhart: ""So do you accept to conduct joint investigations togethe..."*)

### Węzeł `[789]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And they have been pushing over the control of Aureus through a deal with you. Haven't they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Axel Reinhart: ""Mr. Alvarez is surely mad about our deal to sell the rig..."*)

### Węzeł `[790]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is precisely the point. They want you to stay reliant on them and having a separate deal with us surely didn't make them happy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Axel Reinhart: ""Mr. Alvarez is surely mad about our deal to sell the rig..."*)

### Węzeł `[791]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are a threat in their eyes. Lespia doesn't want our countries to be close. You know that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Axel Reinhart: ""Mr. Alvarez is surely mad about our deal to sell the rig..."*)

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are the direct agents of ATO in all Eastern Merkopa. This is their plan to dismantle our monarchies from within.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[776]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Axel Reinhart: ""I don't buy that, Your Majesty.""*)

### Węzeł `[793]`
Mówca: **Axel Reinhart**
> ""Mr. Alvarez is surely mad about our deal to sell the rights to Rizia instead, but do you really think he'd go that far...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""Why wouldn't he? He has both the means and the goals to ..."*)
  - -> `[795]` (*Player_Romus: ""Who else, Your Grace? Rizia is surely not behind this as..."*)
  - -> `[796]` (*Player_Romus: ""They are puppets of the game Arcasia is playing in our r..."*)

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why wouldn't he? He has both the means and the goals to sabotage our deal. And he is succeeding with every second we suspect each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[793]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0"*)

### Węzeł `[795]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who else, Your Grace? Rizia is surely not behind this as we've already paid our sum for the rights. And this happens right before it's finalized. The only loser of this deal is Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[793]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0"*)

### Węzeł `[796]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are puppets of the game Arcasia is playing in our region. You know how far they can go, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[793]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0"*)

### Węzeł `[797]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[798]`
Mówca: **Axel Reinhart**
> ""I suppose you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Axel Reinhart: ""We have to look into this together.""*)

### Węzeł `[799]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0"*)
  - -> `[801]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0)"*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Axel Reinhart: ""I suppose you might be right.""*)

### Węzeł `[801]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Axel Reinhart: ""I don't know, Your Majesty. I won't be convinced like th..."*)

### Węzeł `[802]`
Mówca: **Axel Reinhart**
> ""I don't know, Your Majesty. I won't be convinced like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Axel Reinhart: ""I am much more convinced that we need this neutral inves..."*)

### Węzeł `[803]`
Mówca: **Axel Reinhart**
> ""We have to look into this together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Narrator: "He stopped for a moment to think."*)

### Węzeł `[804]`
Mówca: **Narrator**
> "He stopped for a moment to think."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Axel Reinhart: ""However, if you really want us to continue with this dea..."*)

### Węzeł `[805]`
Mówca: **Axel Reinhart**
> ""However, if you really want us to continue with this deal, I expect you to acknowledge the Rizian mistakes that led to this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Axel Reinhart: ""My people will expect something from your side. If we're..."*)

### Węzeł `[806]`
Mówca: **Axel Reinhart**
> ""My people will expect something from your side. If we're to be going this route together, I expect you to pay reparations for the violent exchange.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Axel Reinhart: ""You have to pay for the Palesian lives that were killed ..."*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Axel Reinhart: ""I only ask of a modest sum. As a symbolic gesture.""*)

### Węzeł `[810]`
Mówca: **Axel Reinhart**
> ""I only ask of a modest sum. As a symbolic gesture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[812]` (*Player_Romus: ""No, Your Grace. Absolutely out of the question.""*)

### Węzeł `[811]`
**[WYBÓR GRACZA: ""Anything for peace." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[810]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Your Grace. Absolutely out of the question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[810]` (Axel Reinhart), `[813]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Axel Reinhart: ""Then there won't be any deals.""*)

### Węzeł `[813]`
Mówca: **Axel Reinhart**
> ""You have to pay for the Palesian lives that were killed by the Rizian Army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[812]` (*Player_Romus: ""No, Your Grace. Absolutely out of the question.""*)

### Węzeł `[814]`
Mówca: **Axel Reinhart**
> ""Then there won't be any deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Axel Reinhart: ""I am much more convinced that we need this neutral inves..."*)

### Węzeł `[815]`
**[WYBÓR GRACZA: ""Anything for peace." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[813]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 2"*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Axel Reinhart: ""Great. Then I believe I can make our signing work on our..."*)

### Węzeł `[817]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Axel Reinhart: ""Great. Then I believe I can make our signing work on our..."*)

### Węzeł `[818]`
Mówca: **Axel Reinhart**
> ""Great. Then I believe I can make our signing work on our previously agreed-upon date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Axel Reinhart: ""I knew you would see reason.""*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableToken("Rizia_Event_Aureus");`
- **Efekt skryptowy (`userScript`):** `DisableToken("Rizia_Event_Aureus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_PostIncident_Peace_NoDeal = true; RiziaDLC..."*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales = true;"*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Axel Reinhart: ""You are making the same mistakes are your father, it see..."*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_V_PalesWarStart = true;
RiziaDLCSupport.News_Turn06_RH_PalesWarStart = true;
RiziaDLCSupport.News_Turn06_G_PalesWarStart = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_PalesWarStart"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PalesWarStart"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PalesWarStart"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Com..."*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Com..."*)
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_C..."*)

### Węzeł `[825]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed = t..."*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Axel Reinhart: ""You are making the same mistakes are your father, it see..."*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Narrator: "I left the meeting room with quick steps."*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Axel Reinhart: ""That's great to hear!""*)

### Węzeł `[832]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Axel Reinhart: ""That's great to hear!""*)

### Węzeł `[833]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true"*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Impasse","R_Impasse_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Our convoy drove steadily across the cobbled streets of O..."*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""Anything for peace." [Accept the deal] [-1 Budget]"*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[838]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[840]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Player_Romus: ""Anything for peace." [-1 Budget]"*)

### Węzeł `[840]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Player_Romus: ""I can't afford your symbolism, Duke.""*)

### Węzeł `[841]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't afford your symbolism, Duke.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Kontekst wejściowy (poprzednik):** `[810]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Axel Reinhart: ""Then there won't be any deals.""*)

### Węzeł `[842]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[844]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Player_Romus: ""Anything for peace." [-2 Budget]"*)

### Węzeł `[844]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Player_Romus: ""Peace is too expensive for our kingdom, Duke.""*)

### Węzeł `[845]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Peace is too expensive for our kingdom, Duke.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[813]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Axel Reinhart: ""Then there won't be any deals.""*)

### Węzeł `[846]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Balancing peace and war after a crisis", "Old Town", "Grand-Duchy of Pales");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Balancing peace and war after a crisis","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");"*)
