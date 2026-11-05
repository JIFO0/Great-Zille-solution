# Sordland/Turn05/FPnT_AgnoliaTradeVisit

- **ID konwersacji:** `77`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/077_FPnT_AgnoliaTradeVisit.md`
- **Liczba węzłów dialogowych:** 400
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[18]** Maartin Van Hoorten
- **[21]** Deivid Wisci
- **[51]** Symon Holl
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.AgnoliaTradeDeal_Negotiation`
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_CheaperSteel`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Policy_Diplomacy_Agnolia_Trade`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_Wehlen_Trade`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn05_FPnT_Immigration_Tight`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AgnoliaTradeDeal_Negotiation`
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_CheaperSteel`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Economy_Agnland`
- `BaseGame.GovernmentBudget`
- `BaseGame.Heljiland_Map_Layer`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised`
- `BaseGame.Policy_Diplomacy_Agnolia_Trade`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_TradeInitiative`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access`
- `BaseGame.Situation_Diplomacy_Agnolia_CheapSteelPrice`
- `BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_LackOfAllies`
- `BaseGame.Situation_Economy_DecreasedTrade`
- `BaseGame.Situation_Economy_IncreasedTrade`
- `BaseGame.Situation_Economy_RecoveredTrade`
- `BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHeljilandDeal`
- `BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed`
- `BaseGameSupport.Journal_Turn05_Trade_AgnoliaMilitarySigned`
- `BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned`
- `BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse`
- `BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized`
- `BaseGameSupport.News_Turn05_G_VanHoortenRecognized`
- `BaseGameSupport.News_Turn05_HP_AgnoliaAlliance`
- `BaseGameSupport.News_Turn05_HP_AgnoliaDeal`
- `BaseGameSupport.News_Turn05_HP_JournalistArrestedRY`
- `BaseGameSupport.News_Turn05_R_DarknessDescendsRY`
- `BaseGameSupport.Report_Turn05_Lenkurg_Unrest`
- `BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed`
- `GameCondition.Turn05_FPnT_AgnoliaTradeVisit`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“I don't blame them. It is in a very strategic position.”"** | `[7]` **Deivid Wisci**: "“So many conflicts over such a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Deivid Wisci**: "“Certainly. If you have Heljilan..." |
| `[9]` | **"“I know. I was just thinking the same thing.”"** | `[7]` **Deivid Wisci**: "“So many conflicts over such a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Deivid Wisci**: "“Thousands of people died fighti..." |
| `[10]` | **"“If I was in the shoes of the Agnolian Prime Minister, I would do anything to prot..."** | `[7]` **Deivid Wisci**: "“So many conflicts over such a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Deivid Wisci**: "“Of course. But as I get older, ..." |
| `[17]` | **"“Me included. I wouldn't want do anything to injure our relationship with Valgsland.”"** | `[16]` **Deivid Wisci**: "“Nobody wants to make an enemy o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Deivid Wisci**: "“I agree. We should try our best..." |
| `[18]` | **"“I don't care who we're up against. We will cross that bridge when we come to it.”"** | `[16]` **Deivid Wisci**: "“Nobody wants to make an enemy o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Deivid Wisci**: "“We should try to look at the bi..." |
| `[37]` | **"Wave at the crowd."** | `[36]` **Narrator**: "After the guards made their way ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Prime Minister Van Hoorten was n..." |
| `[38]` | **"Proceed without a gesture."** | `[36]` **Narrator**: "After the guards made their way ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Prime Minister Van Hoorten was n..." |
| `[42]` | **"“Let's go.”"** | `[41]` **Serge Wolkner**: "“Good day, sir. I hope the fligh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I got in the car and we made our..." |
| `[43]` | **"“Yes, it was. Thank you, Serge.”"** | `[41]` **Serge Wolkner**: "“Good day, sir. I hope the fligh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I got in the car and we made our..." |
| `[44]` | **"Nod."** | `[41]` **Serge Wolkner**: "“Good day, sir. I hope the fligh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I got in the car and we made our..." |
| `[52]` | **"“They can yell all they want.”"** | `[51]` **Serge Wolkner**: "“You know... I never knew Agnoli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Serge Wolkner**: ""I know what it is. They were al..." |
| `[53]` | **"“You are absolutely right, Serge. So ungrateful.”"** | `[51]` **Serge Wolkner**: "“You know... I never knew Agnoli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Serge Wolkner**: ""I know what it is. They were al..." |
| `[54]` | **"“There have been so many issues in Sordland. I don't know if I can call myself a g..."** | `[51]` **Serge Wolkner**: "“You know... I never knew Agnoli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Serge Wolkner**: "“Sir, humility is important but ..." |
| `[62]` | **"“Don't mention it.”"** | `[61]` **Serge Wolkner**: "“A true leader, I dare say.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Serge Wolkner**: "“Very well, sir. I just want to ..." |
| `[63]` | **"“How is little Anton doing?”"** | `[61]` **Serge Wolkner**: "“A true leader, I dare say.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Serge Wolkner**: "“He is fine, sir. A strong boy. ..." |
| `[64]` | **"“I treat my people well.”"** | `[61]` **Serge Wolkner**: "“A true leader, I dare say.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Serge Wolkner**: "“I can attest to that myself. I ..." |
| `[74]` | **"“Thank you so much for the warm welcome. It is great to be here.”"** | `[73]` **Maartin Van Hoorten**: "“Mr. President. Welcome to Agnol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "He reached out for a handshake. ..." |
| `[75]` | **"“Prime Minister.”"** | `[73]` **Maartin Van Hoorten**: "“Mr. President. Welcome to Agnol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "He reached out for a handshake. ..." |
| `[76]` | **"“Good to see you, Maartin.”"** | `[73]` **Maartin Van Hoorten**: "“Mr. President. Welcome to Agnol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "He reached out for a handshake. ..." |
| `[78]` | **"Overpower his handshake."** | `[77]` **Narrator**: "He reached out for a handshake. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "He gestured to the entrance of t..." |
| `[79]` | **"Shake hands."** | `[77]` **Narrator**: "He reached out for a handshake. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "He gestured to the entrance of t..." |
| `[80]` | **"Shake hands and hug after."** | `[77]` **Narrator**: "He reached out for a handshake. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "He gestured to the entrance of t..." |
| `[87]` | **"“I hope so, Mr. Van Hoorten.”"** | `[86]` **Maartin Van Hoorten**: "“This here is one of the first t..."<br>`[377]` **Maartin Van Hoorten**: "“This here is one of the first t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "Our photos were taken again. I g..." |
| `[88]` | **"“This is an amazing gift. Thank you.”"** | `[86]` **Maartin Van Hoorten**: "“This here is one of the first t..."<br>`[377]` **Maartin Van Hoorten**: "“This here is one of the first t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "Our photos were taken again. I g..." |
| `[89]` | **"“Very good.”"** | `[86]` **Maartin Van Hoorten**: "“This here is one of the first t..."<br>`[377]` **Maartin Van Hoorten**: "“This here is one of the first t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "Our photos were taken again. I g..." |
| `[91]` | **"Gift a Sordish-bred puppy despite Maartin's known fear of dogs."** | `[90]` **Narrator**: "Our photos were taken again. I g..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Varia...` | `[96]` **Narrator**: "Maartin stepped backwards when t..." |
| `[92]` | **"Gift one of the original copies of the first constitution of Sordland."** | `[90]` **Narrator**: "Our photos were taken again. I g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Maartin Van Hoorten**: "“Ah! An excellent copy. I have a..." |
| `[93]` | **"Gift an ornamented ceremonial sword made with Sordish steel."** | `[90]` **Narrator**: "Our photos were taken again. I g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Maartin Van Hoorten**: "“Ah! An excellent specimen. This..." |
| `[102]` | **"“Are you not fond of these ceremonies?”"** | `[100]` **Maartin Van Hoorten**: "“Sheesh. I'm thankful to be done..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Maartin Van Hoorten**: "“I think they are a waste of tim..." |
| `[103]` | **"“I was just about to say the same. I'm not fond of these either.”"** | `[100]` **Maartin Van Hoorten**: "“Sheesh. I'm thankful to be done..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Maartin Van Hoorten**: "“It's one of the tougher parts o..." |
| `[105]` | **"Nod."** | `[100]` **Maartin Van Hoorten**: "“Sheesh. I'm thankful to be done..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "He got up from his chair and mov..." |
| `[107]` | **"“I will have an Erlory Maroon 30-year-old.”"** | `[101]` **Maartin Van Hoorten**: "“Would you like a drink, Mr. Ray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Maartin Van Hoorten**: "“Ah, you're keeping it Sordish. ..." |
| `[108]` | **"“I wouldn't mind some Agnolian vodka.”"** | `[101]` **Maartin Van Hoorten**: "“Would you like a drink, Mr. Ray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Maartin Van Hoorten**: "“Ah, you know your drink!”" |
| `[109]` | **"“Just water is fine.”"** | `[101]` **Maartin Van Hoorten**: "“Would you like a drink, Mr. Ray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Maartin Van Hoorten**: "“As you wish.”" |
| `[114]` | **"“What was with that protest outside? Can't you control them?”"** | `[113]` **Narrator**: "He poured the drinks and gave mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Maartin Van Hoorten**: "“Lashing out at me before we eve..." |
| `[116]` | **"“Let's go straight to business.”"** | `[113]` **Narrator**: "He poured the drinks and gave mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Maartin Van Hoorten**: "“Let's.”" |
| `[129]` | **"“Before I start caring about Agnolian citizens, I must care about my own people.”"** | `[128]` **Maartin Van Hoorten**: "“I would definitely prefer Sordl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Maartin Van Hoorten**: "“A valid point, but you are not ..." |
| `[130]` | **"“The decision has already been made.”"** | `[128]` **Maartin Van Hoorten**: "“I would definitely prefer Sordl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Maartin Van Hoorten**: "“Unfortunate.”" |
| `[131]` | **"“Why don't you deal with the problems in your own country first?”"** | `[128]` **Maartin Van Hoorten**: "“I would definitely prefer Sordl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Maartin Van Hoorten**: "“Unfortunately, because we share..." |
| `[135]` | **"“Thank you.”"** | `[134]` **Maartin Van Hoorten**: "“It is reassuring to see Sordlan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "He took a sip from his vodka." |
| `[136]` | **"“Are you implying we haven't been modern?”"** | `[134]` **Maartin Van Hoorten**: "“It is reassuring to see Sordlan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Maartin Van Hoorten**: "“Well, certainly not under Tarqu..." |
| `[138]` | **"“*Colonel* Soll and you will learn to respect him.”"** | `[137]` **Maartin Van Hoorten**: "“Well, certainly not under Tarqu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Maartin Van Hoorten**: "“No need to get angry because of..." |
| `[141]` | **"“He is irrelevant now.”"** | `[137]` **Maartin Van Hoorten**: "“Well, certainly not under Tarqu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Maartin Van Hoorten**: "“Exactly. Now is the time of Ant..." |
| `[142]` | **"“I see you did your homework. We think alike. Don't you worry. I will modernize th..."** | `[137]` **Maartin Van Hoorten**: "“Well, certainly not under Tarqu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Maartin Van Hoorten**: "“That is...actually very good an..." |
| `[151]` | **"“I had no choice but to deal with our issues in Sordland.”"** | `[148]` **Maartin Van Hoorten**: "“I know that you have declared a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Maartin Van Hoorten**: "“Sometimes we leaders have to ma..." |
| `[152]` | **"“That is none of your business.”"** | `[148]` **Maartin Van Hoorten**: "“I know that you have declared a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Maartin Van Hoorten**: "“But it is precisely my business..." |
| `[155]` | **"“It is going well. We are eliminating the threats one by one. Internal *and* exter..."** | `[148]` **Maartin Van Hoorten**: "“I know that you have declared a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Maartin Van Hoorten**: "“It is worrying that a state of ..." |
| `[157]` | **"“Not if you keep acting like *you* have the upper hand.”"** | `[149]` **Maartin Van Hoorten**: "“So tell me, Mr. Rayne. Is Sordl..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Varia...` | `[161]` **Maartin Van Hoorten**: "“Then you see, we might have a p..." |
| `[158]` | **"“As long as Agnolia is a reliable trading partner.”"** | `[149]` **Maartin Van Hoorten**: "“So tell me, Mr. Rayne. Is Sordl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Maartin Van Hoorten**: "“I can assure you. We are.”" |
| `[159]` | **"“Of course, Mr. Van Hoorten. You can trust Sordland.”"** | `[149]` **Maartin Van Hoorten**: "“So tell me, Mr. Rayne. Is Sordl..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Varia...` | `[162]` **Maartin Van Hoorten**: "“Very good.”" |
| `[169]` | **"“So, what's it going to be?”"** | `[168]` **Narrator**: "Van Hoorten leaned back further ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Maartin Van Hoorten**: "“First of all, if we shake hands..."<br>`[183]` **Maartin Van Hoorten**: "“I'm afraid with all your action..." |
| `[170]` | **"“Are you going to talk all day about past deeds or are we going to sign this deal?”"** | `[168]` **Narrator**: "Van Hoorten leaned back further ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Maartin Van Hoorten**: "“First of all, if we shake hands..."<br>`[183]` **Maartin Van Hoorten**: "“I'm afraid with all your action..." |
| `[185]` | **"“I accept.” [-1 Government Budget]"** | `[184]` **Maartin Van Hoorten**: "“What do you say, Mr. Rayne?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agricultur...`<br>`RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agn...` | `[188]` **Maartin Van Hoorten**: "“Excellent.”" |
| `[186]` | **"“This is not a beneficial deal for Sordland.”"** | `[184]` **Maartin Van Hoorten**: "“What do you say, Mr. Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Maartin Van Hoorten**: "“You went through all this effor..." |
| `[196]` | **"“Very well. I accept.”"** | `[198]` **Maartin Van Hoorten**: "“What do you think?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Agnolia_Alliance"] = true; Variable["B...`<br>`Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] = ...`<br>*(+3 skryptów)* | `[200]` **Maartin Van Hoorten**: "“That is excellent to hear. Our ..." |
| `[197]` | **"“Sordland is not ready to go that far with Agnolia.”"** | `[198]` **Maartin Van Hoorten**: "“What do you think?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Maartin Van Hoorten**: "“That is unfortunate. It would'v..." |
| `[205]` | **"“You are asking too much.”"** | `[204]` **Maartin Van Hoorten**: "“What better act to cement our a..."<br>`[297]` **Maartin Van Hoorten**: "“Wouldn't it be fitting for Sord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Maartin Van Hoorten**: "“It is a reasonable request, but..." |
| `[206]` | **"“Another sensible deal. I accept again.”"** | `[204]` **Maartin Van Hoorten**: "“What better act to cement our a..."<br>`[297]` **Maartin Van Hoorten**: "“Wouldn't it be fitting for Sord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Maartin Van Hoorten**: "“Most excellent!”" |
| `[214]` | **"“You are making a grave mistake.”"** | `[189]` **Maartin Van Hoorten**: "“I'm sorry that you've come all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Maartin Van Hoorten**: "“Solve your own problems first b..." |
| `[215]` | **"“Wait. Can't we work something out?”"** | `[189]` **Maartin Van Hoorten**: "“I'm sorry that you've come all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Maartin Van Hoorten**: "“It is difficult..."" |
| `[221]` | **"“Be careful with your words, Mr. Van Hoorten.”"** | `[213]` **Maartin Van Hoorten**: "“I took you for someone you were..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Maartin Van Hoorten**: "“My apologies.”" |
| `[222]` | **"“You are in no position to judge me. I have made my decision.”"** | `[213]` **Maartin Van Hoorten**: "“I took you for someone you were..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Maartin Van Hoorten**: "“I thought this could be the sta..." |
| `[223]` | **"“There is nothing else to talk about. We are done here.”"** | `[213]` **Maartin Van Hoorten**: "“I took you for someone you were..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Maartin Van Hoorten**: "“I thought this could be the sta..." |
| `[226]` | **"“Did you bring me here to ridicule me?”"** | `[189]` **Maartin Van Hoorten**: "“I'm sorry that you've come all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Maartin Van Hoorten**: "“Of course not.”" |
| `[230]` | **"“I won't be joining. It's time we were on our way back home.”"** | `[219]` **Maartin Van Hoorten**: "“We must continue the official p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Narrator**: "His eyes widened in surprise." |
| `[231]` | **"“After you.”"** | `[219]` **Maartin Van Hoorten**: "“We must continue the official p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Narrator**: "As soon as we left the office, I..." |
| `[234]` | **"“I won't say it twice.”"** | `[232]` **Maartin Van Hoorten**: "“But this is customary. Every So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Maartin Van Hoorten**: "“This is outrageous. You are not..." |
| `[235]` | **"“When you put it like that...sure.”"** | `[232]` **Maartin Van Hoorten**: "“But this is customary. Every So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Narrator**: "As soon as we left the office, I..." |
| `[241]` | **"“You are very welcome to come visit Sordland.”"** | `[240]` **Narrator**: "I got up from my chair." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Maartin Van Hoorten**: "“Surely we can arrange something.”" |
| `[242]` | **"“Take care, Maartin.”"** | `[240]` **Narrator**: "I got up from my chair." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Maartin Van Hoorten**: "“You as well.”" |
| `[243]` | **"Leave without a word."** | `[240]` **Narrator**: "I got up from my chair." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Narrator**: "Outside, Serge was waiting for m..." |
| `[257]` | **"“Thank you. You are very kind.”"** | `[167]` **Maartin Van Hoorten**: "“Well done, Mr. Rayne.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Narrator**: "Van Hoorten leaned back further ..." |
| `[258]` | **"“I didn't do it for Agnolia. I did it for the people of Sordland.”"** | `[167]` **Maartin Van Hoorten**: "“Well done, Mr. Rayne.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Maartin Van Hoorten**: "“Of course. Everything we do is ..." |
| `[259]` | **"“No need for flattery.”"** | `[167]` **Maartin Van Hoorten**: "“Well done, Mr. Rayne.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Maartin Van Hoorten**: "“I give credit when it's necessa..." |
| `[266]` | **"“I wonder what propaganda their state is feeding them...""** | `[51]` **Serge Wolkner**: "“You know... I never knew Agnoli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Serge Wolkner**: ""They are afraid of you, sir. Th..." |
| `[268]` | **"“I'm sorry, but I can't agree to this.""** | `[184]` **Maartin Van Hoorten**: "“What do you say, Mr. Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Maartin Van Hoorten**: "“You went through all this effor..." |
| `[269]` | **"“I can't agree to the higher prices. We prefer to continue with the current steel ..."** | `[212]` **Maartin Van Hoorten**: "“You are throwing many months of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Maartin Van Hoorten**: "“We believe that Sordland has be..." |
| `[270]` | **"“Agnolian steel isn't worth that much, Mr. Van Hoorten.”"** | `[212]` **Maartin Van Hoorten**: "“You are throwing many months of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Maartin Van Hoorten**: "“Is that so? You'd rather import..." |
| `[271]` | **"“I'm sorry but my answer is no.”"** | `[212]` **Maartin Van Hoorten**: "“You are throwing many months of..."<br>`[272]` **Maartin Van Hoorten**: "“Is that so? You'd rather import..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Maartin Van Hoorten**: "“I took you for someone you were..." |
| `[275]` | **"“Is there no room for discussion?”"** | `[274]` **Maartin Van Hoorten**: "“Our people believe that we have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Maartin Van Hoorten**: "“We don't want to lose our coope..." |
| `[276]` | **"“Then I will accept, Mr. Van Hoorten. We don't want to lose such an important part..."** | `[274]` **Maartin Van Hoorten**: "“Our people believe that we have..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agricultur...`<br>`RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agn...` | `[188]` **Maartin Van Hoorten**: "“Excellent.”" |
| `[277]` | **"“I'm sorry but my answer is no.”"** | `[274]` **Maartin Van Hoorten**: "“Our people believe that we have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Maartin Van Hoorten**: "“I took you for someone you were..." |
| `[278]` | **"“Look, Mr. Van Hoorten. Let's discuss if lower prices are possible.”"** | `[272]` **Maartin Van Hoorten**: "“Is that so? You'd rather import..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Maartin Van Hoorten**: "“We believe that Sordland has be..." |
| `[279]` | **"“No, but that does not change the fact that the prices are too high.”"** | `[272]` **Maartin Van Hoorten**: "“Is that so? You'd rather import..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Maartin Van Hoorten**: "“We believe that Sordland has be..." |
| `[281]` | **"“I agree. Sordland will recognize the island.”"** | `[282]` **Maartin Van Hoorten**: "“Wouldn't it be fitting for Sord..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true; ...`<br>`Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_R...`<br>*(+2 skryptów)* | `[188]` **Maartin Van Hoorten**: "“Excellent.”" |
| `[285]` | **"“You are asking too much.”"** | `[282]` **Maartin Van Hoorten**: "“Wouldn't it be fitting for Sord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Maartin Van Hoorten**: "“Sordland is rejecting a trade d..." |
| `[303]` | **"“Fair enough. Sordland will recognise the island and Agnolia's other conditions.” ..."** | `[300]` **Maartin Van Hoorten**: "“We can only agree to this deal ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true; ...`<br>`Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaSig...`<br>*(+5 skryptów)* | *Koniec sceny / Terminal* |
| `[305]` | **"“You are asking too much.”"** | `[300]` **Maartin Van Hoorten**: "“We can only agree to this deal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Maartin Van Hoorten**: "“We are asking too much?”" |
| `[381]` | **"“A true gentleman. I can respect that about you, Mr. Hoorten.”"** | `[113]` **Narrator**: "He poured the drinks and gave mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Maartin Van Hoorten**: "“This is how we do things in Agn..." |
| `[382]` | **"“Let's change the course of our nations.”"** | `[168]` **Narrator**: "Van Hoorten leaned back further ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Maartin Van Hoorten**: "“First of all, if we shake hands..."<br>`[183]` **Maartin Van Hoorten**: "“I'm afraid with all your action..." |

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
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Sordland One's flight from Holsord to Staalport took three hours but went very smoothly. We were about to touch down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Deivid left his seat and came over while Symon was enjoyi..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Deivid left his seat and came over while Symon was enjoying his newspaper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Deivid Wisci: "“Looks like we are about to land, Mr. President.”"*)

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“Looks like we are about to land, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I looked outside. I could see Heljiland, the island in be..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I looked outside. I could see Heljiland, the island in between Valgsland and Agnolia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Deivid Wisci: "“So many conflicts over such a small piece of land. The i..."*)

### Węzeł `[7]`
Mówca: **Deivid Wisci**
> "“So many conflicts over such a small piece of land. The island can barely sustain itself without outside help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“I know. I was just thinking the same thing.”"*)
  - -> `[10]` (*Player: "“If I was in the shoes of the Agnolian Prime Minister, I ..."*)
  - -> `[8]` (*Player: "“I don't blame them. It is in a very strategic position.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“I don't blame them. It is in a very strategic position.”"]** — Mówca: **Player**
> "“I don't blame them. It is in a very strategic position.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Deivid Wisci: "“Certainly. If you have Heljiland, you are in control of ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I know. I was just thinking the same thing.”"]** — Mówca: **Player**
> "“I know. I was just thinking the same thing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deivid Wisci: "“Thousands of people died fighting for it. I wonder if it..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“If I was in the shoes of the Agnolian Prime Minister, I would do anything to protect the motherland.”"]** — Mówca: **Player**
> "“If I was in the shoes of the Agnolian Prime Minister, I would do anything to protect the motherland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Deivid Wisci: "“Of course. But as I get older, I started to question mor..."*)

### Węzeł `[11]`
Mówca: **Deivid Wisci**
> "“Thousands of people died fighting for it. I wonder if it was worth it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“I suspect it will be one of the topics that Mr. Van Hoor..."*)

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“Of course. But as I get older, I started to question more things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“I suspect it will be one of the topics that Mr. Van Hoor..."*)

### Węzeł `[13]`
Mówca: **Deivid Wisci**
> "“Certainly. If you have Heljiland, you are in control of the whole Valgos Channel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“I suspect it will be one of the topics that Mr. Van Hoor..."*)

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“I suspect it will be one of the topics that Mr. Van Hoorten will bring up as a bargaining chip. We must be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Deivid Wisci: "“Heljiland might be under the control of Agnolia, but the..."*)

### Węzeł `[15]`
Mówca: **Deivid Wisci**
> "“Heljiland might be under the control of Agnolia, but the international community has yet to recognise it. For a good reason, too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Deivid Wisci: "“Nobody wants to make an enemy of Valgsland. Especially b..."*)

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“Nobody wants to make an enemy of Valgsland. Especially because of the support of United Contana and the CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“I don't care who we're up against. We will cross that br..."*)
  - -> `[17]` (*Player: "“Me included. I wouldn't want do anything to injure our r..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Me included. I wouldn't want do anything to injure our relationship with Valgsland.”"]** — Mówca: **Player**
> "“Me included. I wouldn't want do anything to injure our relationship with Valgsland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Deivid Wisci: "“I agree. We should try our best to stick to the middle g..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I don't care who we're up against. We will cross that bridge when we come to it.”"]** — Mówca: **Player**
> "“I don't care who we're up against. We will cross that bridge when we come to it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Deivid Wisci: "“We should try to look at the bigger picture.”"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Aside from the point of Heljiland, we need to be careful with the additional requests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Symon Holl: "“According to the deal that was negotiated so far, they w..."*)

### Węzeł `[20]`
Mówca: **Deivid Wisci**
> "“We should try to look at the bigger picture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Symon folded his newspaper, got up from his seat and sat ..."*)

### Węzeł `[21]`
Mówca: **Deivid Wisci**
> "“I agree. We should try our best to stick to the middle ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Symon folded his newspaper, got up from his seat and sat ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Symon folded his newspaper, got up from his seat and sat right next to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“Aside from the point of Heljiland, we need to be careful..."*)

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“According to the deal that was negotiated so far, they want to sell us their steel for a higher price and they are requesting easier access to our agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Symon Holl: "“In return, they are promising cash flow and investments,..."*)

### Węzeł `[24]`
Mówca: **Symon Holl**
> "“In return, they are promising cash flow and investments, especially in the Agnland region. It's not hard to guess why.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Deivid Wisci: "“Precisely. Agnolian immigrants in our Agnland region mak..."*)

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“During the initial negotiations, they brought up the topic of immigration many times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == false"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == false"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_FPnT_Immigration_Tight == false)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Deivid Wisci: "“The fact that we have relaxed our immigration laws will ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_FPnT_Immigration_Tight == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Deivid Wisci: "“Our job will be harder because of our new tightened immi..."*)

### Węzeł `[29]`
Mówca: **Deivid Wisci**
> "“The fact that we have relaxed our immigration laws will help tremendously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Let's see if we can shake hands on it.”"*)

### Węzeł `[30]`
Mówca: **Deivid Wisci**
> "“Our job will be harder because of our new tightened immigration laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Let's see if we can shake hands on it.”"*)

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Let's see if we can shake hands on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The pilot made an announcement that the descent had start..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The pilot made an announcement that the descent had started. Deivid and Symon went back to their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I took another look outside the window. I could see Staal..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "I took another look outside the window. I could see Staalport, the capital city of Agnolia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The large dockyards of the city and the canals -- "Staal"..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The large dockyards of the city and the canals -- "Staal" in Agnolian -- appeared closer as our descent continued. Staalport was certainly a fitting name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PlaneLandingSmoothly");"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "A couple of minutes later, we finally touched down. The plane parked. I took a final look out the window. The welcoming ceremony from Agnolia was waiting along the red carpet outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "After the guards made their way out, I exited the plane."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "After the guards made their way out, I exited the plane."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Italic: "Wave at the crowd."*)
  - -> `[38]` (*Player_Italic: "Proceed without a gesture."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "Wave at the crowd."]** — Mówca: **Player_Italic**
> "I waved at the crowd that gathered. There were many camera flashes. I started to make my way downstairs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Prime Minister Van Hoorten was nowhere in sight. Instead,..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Proceed without a gesture."]** — Mówca: **Player_Italic**
> "I started to make my way downstairs. There were many camera flashes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Prime Minister Van Hoorten was nowhere in sight. Instead,..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Prime Minister Van Hoorten was nowhere in sight. Instead, I was greeted by the Foreign Minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "After handshakes and a couple of photos, I moved to the c..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "After handshakes and a couple of photos, I moved to the car where Serge was waiting to drive me to the office of Prime Minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Serge Wolkner: "“Good day, sir. I hope the flight was comfortable.”"*)

### Węzeł `[41]`
Mówca: **Serge Wolkner**
> "“Good day, sir. I hope the flight was comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“Yes, it was. Thank you, Serge.”"*)
  - -> `[42]` (*Player: "“Let's go.”"*)
  - -> `[44]` (*Player_Italic: "Nod."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Let's go.”"]** — Mówca: **Player**
> "“Let's go.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I got in the car and we made our way through the foreign ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Yes, it was. Thank you, Serge.”"]** — Mówca: **Player**
> "“Yes, it was. Thank you, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I got in the car and we made our way through the foreign ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I got in the car and we made our way through the foreign ..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "I got in the car and we made our way through the foreign streets. Our convoy was protected by Sordish and Agnolian guards in their vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "We got on the highway beside the port and saw dozens of d..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "We got on the highway beside the port and saw dozens of dockyards and ships anchored. Some of the boats and machinery looked old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "The city itself looked very grey and grim. The buildings ..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "The city itself looked very grey and grim. The buildings had a touch of Rumburg's famous Monarkian architecture with a mixture of Sordish signature domes on the older ones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "We were now on the main road to the office of the Prime M..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "We were now on the main road to the office of the Prime Minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Serge Wolkner: "“Looks like they are not too happy to see you, sir.”"*)

### Węzeł `[49]`
Mówca: **Serge Wolkner**
> "“Looks like they are not too happy to see you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Serge pointed at the crowd that gathered on both sides of the street. It was a protest. They were shouting and yelling at our convoy. Some of them held signs written in Sordish: 'Go Home Rayne', 'We Don't Want Autocrats In Agnolia.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Serge Wolkner: "“You know... I never knew Agnolians were so ungrateful. N..."*)

### Węzeł `[51]`
Mówca: **Serge Wolkner**
> "“You know... I never knew Agnolians were so ungrateful. Not everyone sees a great leader like you everyday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“You are absolutely right, Serge. So ungrateful.”"*)
  - -> `[52]` (*Player: "“They can yell all they want.”"*)
  - -> `[54]` (*Player: "“There have been so many issues in Sordland. I don't know..."*)
  - -> `[266]` (*Player: "“I wonder what propaganda their state is feeding them...""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“They can yell all they want.”"]** — Mówca: **Player**
> "“They can yell all they want.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Serge Wolkner: ""I know what it is. They were always scared of Sordland's..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“You are absolutely right, Serge. So ungrateful.”"]** — Mówca: **Player**
> "“You are absolutely right, Serge. So ungrateful.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Serge Wolkner: ""I know what it is. They were always scared of Sordland's..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“There have been so many issues in Sordland. I don't know if I can call myself a great leader.”"]** — Mówca: **Player**
> "“There have been so many issues in Sordland. I don't know if I can call myself a great leader.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Serge Wolkner: "“Sir, humility is important but not in this case. They we..."*)

### Węzeł `[55]`
Mówca: **Serge Wolkner**
> ""I know what it is. They were always scared of Sordland's potential. And now they are afraid that a lion leads Sordland. They are afraid of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[56]`
Mówca: **Serge Wolkner**
> "“Sir, humility is important but not in this case. They were always scared of Sordland's potential. And now they are afraid that a lion leads Sordland. They are afraid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[57]`
Mówca: **Serge Wolkner**
> "“Not just that, but you are a man who is selfless enough to help your driver's children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Serge Wolkner: "“A true leader, I dare say.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Serge Wolkner: "“Not just that, but you are a man who is selfless enough ..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The convoy started slowing down."*)

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> "“A true leader, I dare say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“How is little Anton doing?”"*)
  - -> `[64]` (*Player: "“I treat my people well.”"*)
  - -> `[62]` (*Player: "“Don't mention it.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Don't mention it.”"]** — Mówca: **Player**
> "“Don't mention it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Serge Wolkner: "“Very well, sir. I just want to say that I am honored to ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“How is little Anton doing?”"]** — Mówca: **Player**
> "“How is little Anton doing?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Serge Wolkner: "“He is fine, sir. A strong boy. Takes after his namesake ..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I treat my people well.”"]** — Mówca: **Player**
> "“I treat my people well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Serge Wolkner: "“I can attest to that myself. I am honored to be your dri..."*)

### Węzeł `[65]`
Mówca: **Serge Wolkner**
> "“He is fine, sir. A strong boy. Takes after his namesake for sure!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The convoy started slowing down."*)

### Węzeł `[66]`
Mówca: **Serge Wolkner**
> "“I can attest to that myself. I am honored to be your driver. And very grateful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The convoy started slowing down."*)

### Węzeł `[67]`
Mówca: **Serge Wolkner**
> "“Very well, sir. I just want to say that I am honored to be your driver. And very grateful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The convoy started slowing down."*)

### Węzeł `[68]`
Mówca: **Serge Wolkner**
> "“We have arrived, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "The car continued through the gates while the security ve..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "The convoy started slowing down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Serge Wolkner: "“We have arrived, sir.”"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "The car continued through the gates while the security vehicles went the other way. We finally came to a stop in front of the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Serge left the car and opened the car door. I exited and ..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Serge left the car and opened the car door. I exited and began walking to the door where dozens of press and the Prime Minister were waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I saw the PM much more clearly as I neared the door. He w..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "I saw the PM much more clearly as I neared the door. He was shorter than I thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Maartin Van Hoorten: "“Mr. President. Welcome to Agnolia and to the beautiful c..."*)

### Węzeł `[73]`
Mówca: **Maartin Van Hoorten**
> "“Mr. President. Welcome to Agnolia and to the beautiful city of Staalport.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“Prime Minister.”"*)
  - -> `[74]` (*Player: "“Thank you so much for the warm welcome. It is great to b..."*)
  - -> `[76]` (*Player: "“Good to see you, Maartin.”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Thank you so much for the warm welcome. It is great to be here.”"]** — Mówca: **Player**
> "“Thank you so much for the warm welcome. It is great to be here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He reached out for a handshake. The press surrounding us ..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Prime Minister.”"]** — Mówca: **Player**
> "“Prime Minister.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He reached out for a handshake. The press surrounding us ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Good to see you, Maartin.”"]** — Mówca: **Player**
> "“Good to see you, Maartin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He reached out for a handshake. The press surrounding us ..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He reached out for a handshake. The press surrounding us had been waiting for this moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Italic: "Overpower his handshake."*)
  - -> `[79]` (*Player_Italic: "Shake hands."*)
  - -> `[80]` (*Player_Italic: "Shake hands and hug after."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "Overpower his handshake."]** — Mówca: **Player_Italic**
> "I overpowered his handshake and he got caught by surprise as the press took the picture of me having the upper hand. He smiled awkwardly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He gestured to the entrance of the two-hundred-year old P..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "Shake hands."]** — Mówca: **Player_Italic**
> "We shook hands and smiled at the cameras as the press took pictures."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He gestured to the entrance of the two-hundred-year old P..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "Shake hands and hug after."]** — Mówca: **Player_Italic**
> "We shook hands and I went for a hug which was received well by the Prime Minister. The press went wild and took more pictures."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He gestured to the entrance of the two-hundred-year old P..."*)

### Węzeł `[81]`
Mówca: **Maartin Van Hoorten**
> "“This way, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "We entered and the press followed us inside."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "He gestured to the entrance of the two-hundred-year old Parliament building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Maartin Van Hoorten: "“This way, please.”"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "We entered and the press followed us inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Maartin Van Hoorten: "“I would like to present you with a gift as a sign of fri..."*)

### Węzeł `[84]`
Mówca: **Maartin Van Hoorten**
> "“I would like to present you with a gift as a sign of friendship between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "An assistant showed up immediately with a large glass cas..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "An assistant showed up immediately with a large glass case in her hands. It contained a single sheet of parchment inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[86]`
Mówca: **Maartin Van Hoorten**
> "“This here is one of the first treaties written between Sordland and Agnolia. May it mark the renewal of our friendship today as well!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "“I hope so, Mr. Van Hoorten.”"*)
  - -> `[88]` (*Player: "“This is an amazing gift. Thank you.”"*)
  - -> `[89]` (*Player: "“Very good.”"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I hope so, Mr. Van Hoorten.”"]** — Mówca: **Player**
> "“I hope so, Mr. Van Hoorten.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Maartin Van Hoorten), `[377]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Our photos were taken again. I gestured at one of my reta..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“This is an amazing gift. Thank you.”"]** — Mówca: **Player**
> "“This is an amazing gift. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Maartin Van Hoorten), `[377]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Our photos were taken again. I gestured at one of my reta..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Very good.”"]** — Mówca: **Player**
> "“Very good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Maartin Van Hoorten), `[377]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Our photos were taken again. I gestured at one of my reta..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Our photos were taken again. I gestured at one of my retainers who was holding our gift to the PM."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Italic: "Gift one of the original copies of the first constitution..."*)
  - -> `[91]` (*Player_Italic: "Gift a Sordish-bred puppy despite Maartin's known fear of..."*)
  - -> `[93]` (*Player_Italic: "Gift an ornamented ceremonial sword made with Sordish steel."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "Gift a Sordish-bred puppy despite Maartin's known fear of dogs."]** — Mówca: **Player_Italic**
> "Our gift was a Sordish-bred puppy, despite Maartin's known fear of dogs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation -= 1"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "Gift one of the original copies of the first constitution of Sordland."]** — Mówca: **Player_Italic**
> "Our gift was one of the original copies of the first constitution of Sordland."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Maartin Van Hoorten: "“Ah! An excellent copy. I have always wondered what one o..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "Gift an ornamented ceremonial sword made with Sordish steel."]** — Mówca: **Player_Italic**
> "Our gift was an ornamented ceremonial sword made with Sordish steel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Maartin Van Hoorten: "“Ah! An excellent specimen. This must be hundreds of year..."*)

### Węzeł `[94]`
Mówca: **Maartin Van Hoorten**
> "“Ah! An excellent copy. I have always wondered what one of the originals looked like. Thank you for this excellent gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The cameras flashed once again."*)

### Węzeł `[95]`
Mówca: **Maartin Van Hoorten**
> "“Ah! An excellent specimen. This must be hundreds of years old. It looks like this is Sordish steel as well. Very fitting. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The cameras flashed once again."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Maartin stepped backwards when the puppy howled. He very uncomfortably held the dog in his hands and tried to smile at the reporters before putting the dog down on the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The cameras flashed once again."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "The cameras flashed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Maartin Van Hoorten: "“Let's go to my office. Follow me.”"*)

### Węzeł `[98]`
Mówca: **Maartin Van Hoorten**
> "“Let's go to my office. Follow me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "I followed him and we entered the office of the Prime Min..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "I followed him and we entered the office of the Prime Minister. With its minimalist wooden decor, the room was far more modest than I expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "We sat down. He leaned back and made himself comfortable."*)

### Węzeł `[100]`
Mówca: **Maartin Van Hoorten**
> "“Sheesh. I'm thankful to be done with the ceremonies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Are you not fond of these ceremonies?”"*)
  - -> `[103]` (*Player: "“I was just about to say the same. I'm not fond of these ..."*)
  - -> `[105]` (*Player_Italic: "Nod."*)

### Węzeł `[101]`
Mówca: **Maartin Van Hoorten**
> "“Would you like a drink, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“I wouldn't mind some Agnolian vodka.”"*)
  - -> `[107]` (*Player: "“I will have an Erlory Maroon 30-year-old.”"*)
  - -> `[109]` (*Player: "“Just water is fine.”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Are you not fond of these ceremonies?”"]** — Mówca: **Player**
> "“Are you not fond of these ceremonies?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Maartin Van Hoorten: "“I think they are a waste of time, but alas, that is one ..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“I was just about to say the same. I'm not fond of these either.”"]** — Mówca: **Player**
> "“I was just about to say the same. I'm not fond of these either.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Maartin Van Hoorten: "“It's one of the tougher parts of our job.”"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "We sat down. He leaned back and made himself comfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Maartin Van Hoorten: "“Sheesh. I'm thankful to be done with the ceremonies.”"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He got up from his chair and moved over to the bar. There..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He got up from his chair and moved over to the bar. There were many varieties of liquor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Maartin Van Hoorten: "“Would you like a drink, Mr. Rayne?”"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“I will have an Erlory Maroon 30-year-old.”"]** — Mówca: **Player**
> "“I will have an Erlory Maroon 30-year-old.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Maartin Van Hoorten: "“Ah, you're keeping it Sordish. A very good whiskey for s..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I wouldn't mind some Agnolian vodka.”"]** — Mówca: **Player**
> "“I wouldn't mind some Agnolian vodka.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Maartin Van Hoorten: "“Ah, you know your drink!”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Just water is fine.”"]** — Mówca: **Player**
> "“Just water is fine.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Maartin Van Hoorten: "“As you wish.”"*)

### Węzeł `[110]`
Mówca: **Maartin Van Hoorten**
> "“Ah, you know your drink!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He poured the drinks and gave mine to me before sitting d..."*)

### Węzeł `[111]`
Mówca: **Maartin Van Hoorten**
> "“Ah, you're keeping it Sordish. A very good whiskey for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He poured the drinks and gave mine to me before sitting d..."*)

### Węzeł `[112]`
Mówca: **Maartin Van Hoorten**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He poured the drinks and gave mine to me before sitting d..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He poured the drinks and gave mine to me before sitting down again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: "“Let's go straight to business.”"*)
  - -> `[381]` (*Player: "“A true gentleman. I can respect that about you, Mr. Hoor..."*)
  - -> `[114]` (*Player: "“What was with that protest outside? Can't you control th..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“What was with that protest outside? Can't you control them?”"]** — Mówca: **Player**
> "“What was with that protest outside? Can't you control them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Maartin Van Hoorten: "“Lashing out at me before we even start discussing the tr..."*)

### Węzeł `[115]`
Mówca: **Maartin Van Hoorten**
> "“Lashing out at me before we even start discussing the trade deal? Please look at your own country first before indulging yourself with Agnolian matters, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation -= 1"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Let's go straight to business.”"]** — Mówca: **Player**
> "“Let's go straight to business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Maartin Van Hoorten: "“Let's.”"*)

### Węzeł `[117]`
Mówca: **Maartin Van Hoorten**
> "“Let's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[118]`
Mówca: **Maartin Van Hoorten**
> "“First of all, if we shake hands on it, this agreement is going to be extremely beneficial for both of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Maartin Van Hoorten: "“You should be able to solve your recession in no time wi..."*)

### Węzeł `[119]`
Mówca: **Maartin Van Hoorten**
> "“You should be able to solve your recession in no time with the investment and money flow coming from us. This is, as you know, on top of the reduced tariffs for trade between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Maartin Van Hoorten: "“Of course in return, as discussed between my people and ..."*)

### Węzeł `[120]`
Mówca: **Maartin Van Hoorten**
> "“Of course in return, as discussed between my people and your people before, you will allow us privileged access to your agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Maartin Van Hoorten: "“You will be buying steel from us for a higher price, whi..."*)

### Węzeł `[121]`
Mówca: **Maartin Van Hoorten**
> "“First of all, I would like to say that I have been watching your recent immigration policy changes. I am glad that you have decided to keep it relaxed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Maartin Van Hoorten: "“Immigrants are very important for beneficial economical ..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation += 2"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation -= 1"*)

### Węzeł `[125]`
Mówca: **Maartin Van Hoorten**
> "“First of all, I would like to say that I have been watching your recent immigration policy changes. We have worries about the new and tighter immigration laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Maartin Van Hoorten: "“Immigrants are very important for beneficial economical ..."*)

### Węzeł `[126]`
Mówca: **Maartin Van Hoorten**
> "“Immigrants are very important for beneficial economical development. We believe that very much in Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Maartin Van Hoorten: "“It is reassuring to see Sordland move in a more modern d..."*)

### Węzeł `[127]`
Mówca: **Maartin Van Hoorten**
> "“Immigrants are very important for beneficial economical development. We believe that very much in Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Maartin Van Hoorten: "“I would definitely prefer Sordland to be welcoming to Ag..."*)

### Węzeł `[128]`
Mówca: **Maartin Van Hoorten**
> "“I would definitely prefer Sordland to be welcoming to Agnolian citizens and vice versa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“The decision has already been made.”"*)
  - -> `[129]` (*Player: "“Before I start caring about Agnolian citizens, I must ca..."*)
  - -> `[131]` (*Player: "“Why don't you deal with the problems in your own country..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“Before I start caring about Agnolian citizens, I must care about my own people.”"]** — Mówca: **Player**
> "“Before I start caring about Agnolian citizens, I must care about my own people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Maartin Van Hoorten: "“A valid point, but you are not giving me much incentive ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“The decision has already been made.”"]** — Mówca: **Player**
> "“The decision has already been made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Maartin Van Hoorten: "“Unfortunate.”"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Why don't you deal with the problems in your own country first?”"]** — Mówca: **Player**
> "“Why don't you deal with the problems in your own country first?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Maartin Van Hoorten: "“Unfortunately, because we share a direct border, I can't..."*)

### Węzeł `[132]`
Mówca: **Maartin Van Hoorten**
> "“Unfortunately, because we share a direct border, I can't simply ignore the problems of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[133]`
Mówca: **Maartin Van Hoorten**
> "“A valid point, but you are not giving me much incentive to work with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[134]`
Mówca: **Maartin Van Hoorten**
> "“It is reassuring to see Sordland move in a more modern direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "“Are you implying we haven't been modern?”"*)
  - -> `[135]` (*Player: "“Thank you.”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Are you implying we haven't been modern?”"]** — Mówca: **Player**
> "“Are you implying we haven't been modern?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Maartin Van Hoorten: "“Well, certainly not under Tarquin Soll. What did you cal..."*)

### Węzeł `[137]`
Mówca: **Maartin Van Hoorten**
> "“Well, certainly not under Tarquin Soll. What did you call him? Corporal Soll? General Soll?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: "“*Colonel* Soll and you will learn to respect him.”"*)
  - -> `[141]` (*Player: "“He is irrelevant now.”"*)
  - -> `[142]` (*Player: "“I see you did your homework. We think alike. Don't you w..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“*Colonel* Soll and you will learn to respect him.”"]** — Mówca: **Player**
> "“*Colonel* Soll and you will learn to respect him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Maartin Van Hoorten: "“No need to get angry because of our differing opinions.”"*)

### Węzeł `[139]`
Mówca: **Maartin Van Hoorten**
> "“No need to get angry because of our differing opinions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "He took a sip from his vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“He is irrelevant now.”"]** — Mówca: **Player**
> "“He is irrelevant now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Maartin Van Hoorten: "“Exactly. Now is the time of Anton Rayne.”"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“I see you did your homework. We think alike. Don't you worry. I will modernize the country.”"]** — Mówca: **Player**
> "“I see you did your homework. We think alike. Don't you worry. I will modernize the country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Maartin Van Hoorten: "“That is...actually very good and refreshing to hear. I h..."*)

### Węzeł `[143]`
Mówca: **Maartin Van Hoorten**
> "“Exactly. Now is the time of Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[144]`
Mówca: **Maartin Van Hoorten**
> "“That is...actually very good and refreshing to hear. I hope you can do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation -= 1"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Maartin Van Hoorten: "“So tell me, Mr. Rayne. Is Sordland a reliable trading pa..."*)

### Węzeł `[148]`
Mówca: **Maartin Van Hoorten**
> "“I know that you have declared a state of emergency. So early into your presidency, too. So, tell me. How is that going?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: "“It is going well. We are eliminating the threats one by ..."*)
  - -> `[151]` (*Player: "“I had no choice but to deal with our issues in Sordland.”"*)
  - -> `[152]` (*Player: "“That is none of your business.”"*)

### Węzeł `[149]`
Mówca: **Maartin Van Hoorten**
> "“So tell me, Mr. Rayne. Is Sordland a reliable trading partner to Agnolia?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: "“Not if you keep acting like *you* have the upper hand.”"*)
  - -> `[158]` (*Player: "“As long as Agnolia is a reliable trading partner.”"*)
  - -> `[159]` (*Player: "“Of course, Mr. Van Hoorten. You can trust Sordland.”"*)

### Węzeł `[150]`
Mówca: **Maartin Van Hoorten**
> "“But it is precisely my business. I need to know if Sordland is a reliable trading partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Maartin Van Hoorten: "“So tell me, Mr. Rayne. Is Sordland a reliable trading pa..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I had no choice but to deal with our issues in Sordland.”"]** — Mówca: **Player**
> "“I had no choice but to deal with our issues in Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Maartin Van Hoorten: "“Sometimes we leaders have to make tough choices. But you..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“That is none of your business.”"]** — Mówca: **Player**
> "“That is none of your business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Maartin Van Hoorten: "“But it is precisely my business. I need to know if Sordl..."*)

### Węzeł `[153]`
Mówca: **Maartin Van Hoorten**
> "“It is worrying that a state of emergency was declared right next to our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Maartin Van Hoorten: "“The reason I am asking these questions is because I need..."*)

### Węzeł `[154]`
Mówca: **Maartin Van Hoorten**
> "“Sometimes we leaders have to make tough choices. But you need to understand that I need trustworthy trading partners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Maartin Van Hoorten: "“So tell me, Mr. Rayne. Is Sordland a reliable trading pa..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“It is going well. We are eliminating the threats one by one. Internal *and* external.”"]** — Mówca: **Player**
> "“It is going well. We are eliminating the threats one by one. Internal *and* external.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Maartin Van Hoorten: "“It is worrying that a state of emergency was declared ri..."*)

### Węzeł `[156]`
Mówca: **Maartin Van Hoorten**
> "“The reason I am asking these questions is because I need to know if Sordland is a reliable trading partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Maartin Van Hoorten: "“So tell me, Mr. Rayne. Is Sordland a reliable trading pa..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Not if you keep acting like *you* have the upper hand.”"]** — Mówca: **Player**
> "“Not if you keep acting like *you* have the upper hand.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation -= 1"*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“As long as Agnolia is a reliable trading partner.”"]** — Mówca: **Player**
> "“As long as Agnolia is a reliable trading partner.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Maartin Van Hoorten: "“I can assure you. We are.”"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Of course, Mr. Van Hoorten. You can trust Sordland.”"]** — Mówca: **Player**
> "“Of course, Mr. Van Hoorten. You can trust Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation += 1"*)

### Węzeł `[160]`
Mówca: **Maartin Van Hoorten**
> "“I can assure you. We are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[161]`
Mówca: **Maartin Van Hoorten**
> "“Then you see, we might have a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[162]`
Mówca: **Maartin Van Hoorten**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation += 1"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Van Hoorten leaned back further in contemplation."*)

### Węzeł `[166]`
Mówca: **Maartin Van Hoorten**
> "“It was a good move to start building that highway. Overall, this will positively affect our trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Maartin Van Hoorten: "“Well done, Mr. Rayne.”"*)

### Węzeł `[167]`
Mówca: **Maartin Van Hoorten**
> "“Well done, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: "“Thank you. You are very kind.”"*)
  - -> `[258]` (*Player: "“I didn't do it for Agnolia. I did it for the people of S..."*)
  - -> `[259]` (*Player: "“No need for flattery.”"*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Van Hoorten leaned back further in contemplation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“So, what's it going to be?”"*)
  - -> `[382]` (*Player: "“Let's change the course of our nations.”"*)
  - -> `[170]` (*Player: "“Are you going to talk all day about past deeds or are we..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“So, what's it going to be?”"]** — Mówca: **Player**
> "“So, what's it going to be?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Pr..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Are you going to talk all day about past deeds or are we going to sign this deal?”"]** — Mówca: **Player**
> "“Are you going to talk all day about past deeds or are we going to sign this deal?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Pr..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Maartin stepped backwards when the puppy howled. He very ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Maartin Van Hoorten: "“First of all, I would like to say that I have been watch..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Maartin Van Hoorten: "“First of all, I would like to say that I have been watch..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Maartin Van Hoorten: "“I know that you have declared a state of emergency. So e..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Maartin Van Hoorten: "“Then you see, we might have a problem.”"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Maartin Van Hoorten: "“Very good.”"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[179]`
Mówca: **Maartin Van Hoorten**
> "“You will be buying steel from us for a higher price, which is a small price to pay really. That is the deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Maartin Van Hoorten: "“What do you say, Mr. Rayne?”"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Pr..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame...."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] >= 2  or  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Maartin Van Hoorten: "“First of all, if we shake hands on it, this agreement is..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] >= 2  or  Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Maartin Van Hoorten: "“I'm afraid with all your actions so far, I am not convin..."*)

### Węzeł `[183]`
Mówca: **Maartin Van Hoorten**
> "“I'm afraid with all your actions so far, I am not convinced that Sordland is the right partner for Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Maartin Van Hoorten: "“Sordland is simply too volatile. Elected politicians are..."*)

### Węzeł `[184]`
Mówca: **Maartin Van Hoorten**
> "“What do you say, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "“I accept.” [-1 Government Budget]"*)
  - -> `[268]` (*Player: "“I'm sorry, but I can't agree to this.""*)
  - -> `[186]` (*Player: "“This is not a beneficial deal for Sordland.”"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_A..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“This is not a beneficial deal for Sordland.”"]** — Mówca: **Player**
> "“This is not a beneficial deal for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Maartin Van Hoorten: "“You went through all this effort to come and say no to me?”"*)

### Węzeł `[187]`
Mówca: **Maartin Van Hoorten**
> "“You went through all this effort to come and say no to me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Maartin Van Hoorten: "“You are throwing many months of work down the drain. Thi..."*)

### Węzeł `[188]`
Mówca: **Maartin Van Hoorten**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal = true; BaseGameSupport.Journa..."*)

### Węzeł `[189]`
Mówca: **Maartin Van Hoorten**
> "“I'm sorry that you've come all this way for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: "“Did you bring me here to ridicule me?”"*)
  - -> `[214]` (*Player: "“You are making a grave mistake.”"*)
  - -> `[215]` (*Player: "“Wait. Can't we work something out?”"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal = true; BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_TradeDeal"] = true;
Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Trade = true; BaseGame...."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Trade = false;"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed = true"*)

### Węzeł `[193]`
Mówca: **Maartin Van Hoorten**
> "“Before we dive into the paperwork for the trade deal, I want to offer you another possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Maartin Van Hoorten: "“I would like to expand on our new partnership. We have r..."*)

### Węzeł `[194]`
Mówca: **Maartin Van Hoorten**
> "“I would like to expand on our new partnership. We have regional forces like Rumburg that have been imposing danger on both of our countries. I am of the mind that we must unite. So...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Maartin Van Hoorten: "“By the powers bestowed upon me as the Prime Minister of ..."*)

### Węzeł `[195]`
Mówca: **Maartin Van Hoorten**
> "“By the powers bestowed upon me as the Prime Minister of Agnolia, I am offering a military alliance between Sordland and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Maartin Van Hoorten: "“What do you think?”"*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Very well. I accept.”"]** — Mówca: **Player**
> "“Very well. I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance = true;  BaseGameSupport.Journa..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Sordland is not ready to go that far with Agnolia.”"]** — Mówca: **Player**
> "“Sordland is not ready to go that far with Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Maartin Van Hoorten: "“That is unfortunate. It would've been beneficial against..."*)

### Węzeł `[198]`
Mówca: **Maartin Van Hoorten**
> "“What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "“Very well. I accept.”"*)
  - -> `[197]` (*Player: "“Sordland is not ready to go that far with Agnolia.”"*)

### Węzeł `[199]`
Mówca: **Maartin Van Hoorten**
> "“That is unfortunate. It would've been beneficial against the Rumburg threat. However, Agnolia can stand by itself against any threat just fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[200]`
Mówca: **Maartin Van Hoorten**
> "“That is excellent to hear. Our ministers will go over the details later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[201]`
Mówca: **Maartin Van Hoorten**
> "“Now that we have gone this far and are willing to enter an alliance, there is another topic that I would like to bring up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Maartin Van Hoorten: "“As you know, Heljiland has been long contested between A..."*)

### Węzeł `[202]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland. Those warmongers want to take back the island.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Maartin Van Hoorten: "“You know how the international community does not recogn..."*)

### Węzeł `[203]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Maartin Van Hoorten: "“What better act to cement our alliance than announcing t..."*)

### Węzeł `[204]`
Mówca: **Maartin Van Hoorten**
> "“What better act to cement our alliance than announcing to the world that Sordland recognises Heljiland to be Agnolian territory?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: "“You are asking too much.”"*)
  - -> `[206]` (*Player: "“Another sensible deal. I accept again.”"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“You are asking too much.”"]** — Mówca: **Player**
> "“You are asking too much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Maartin Van Hoorten), `[297]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Maartin Van Hoorten: "“It is a reasonable request, but I won't push too far on ..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "“Another sensible deal. I accept again.”"]** — Mówca: **Player**
> "“Another sensible deal. I accept again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Maartin Van Hoorten), `[297]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Maartin Van Hoorten: "“Most excellent!”"*)

### Węzeł `[207]`
Mówca: **Maartin Van Hoorten**
> "“Most excellent!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Maartin Van Hoorten: "“Today is a historic day!”"*)

### Węzeł `[208]`
Mówca: **Maartin Van Hoorten**
> "“It is a reasonable request, but I won't push too far on the matter. We have achieved enough for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Maartin Van Hoorten: "“Well then.”"*)

### Węzeł `[209]`
Mówca: **Deivid Wisci**
> "“Precisely. Agnolian immigrants in our Agnland region make up a good chunk of the area's economy now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deivid Wisci: "“During the initial negotiations, they brought up the top..."*)

### Węzeł `[210]`
Mówca: **Maartin Van Hoorten**
> "“I think they are a waste of time, but alas, that is one of our jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He got up from his chair and moved over to the bar. There..."*)

### Węzeł `[211]`
Mówca: **Maartin Van Hoorten**
> "“It's one of the tougher parts of our job.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He got up from his chair and moved over to the bar. There..."*)

### Węzeł `[212]`
Mówca: **Maartin Van Hoorten**
> "“You are throwing many months of work down the drain. This is a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: "“I can't agree to the higher prices. We prefer to continu..."*)
  - -> `[270]` (*Player: "“Agnolian steel isn't worth that much, Mr. Van Hoorten.”"*)
  - -> `[271]` (*Player: "“I'm sorry but my answer is no.”"*)

### Węzeł `[213]`
Mówca: **Maartin Van Hoorten**
> "“I took you for someone you were not, I suppose. But you are no different than your predecessors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“Be careful with your words, Mr. Van Hoorten.”"*)
  - -> `[222]` (*Player: "“You are in no position to judge me. I have made my decis..."*)
  - -> `[223]` (*Player: "“There is nothing else to talk about. We are done here.”"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“You are making a grave mistake.”"]** — Mówca: **Player**
> "“You are making a grave mistake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Maartin Van Hoorten: "“Solve your own problems first before you threaten me, Mr..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Wait. Can't we work something out?”"]** — Mówca: **Player**
> "“Wait. Can't we work something out?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Maartin Van Hoorten: "“It is difficult...""*)

### Węzeł `[216]`
Mówca: **Maartin Van Hoorten**
> "“Today is a historic day!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Maartin Van Hoorten: "“Congratulations, Mr. Rayne, for making all the right dec..."*)

### Węzeł `[217]`
Mówca: **Maartin Van Hoorten**
> "“Congratulations, Mr. Rayne, for making all the right decisions today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised = true; BaseGame.Pol..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "He stood up from his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Maartin Van Hoorten: "“We must continue the official program. As you know, we w..."*)

### Węzeł `[219]`
Mówca: **Maartin Van Hoorten**
> "“We must continue the official program. As you know, we will pay a visit to our founder's grave for another ceremony. Afterwards, we will move on to the state dinner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: "“I won't be joining. It's time we were on our way back ho..."*)
  - -> `[231]` (*Player: "“After you.”"*)

### Węzeł `[220]`
Mówca: **Maartin Van Hoorten**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "He stood up from his chair."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Be careful with your words, Mr. Van Hoorten.”"]** — Mówca: **Player**
> "“Be careful with your words, Mr. Van Hoorten.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Maartin Van Hoorten: "“My apologies.”"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“You are in no position to judge me. I have made my decision.”"]** — Mówca: **Player**
> "“You are in no position to judge me. I have made my decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Maartin Van Hoorten: "“I thought this could be the start of a new era, but appa..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: "“There is nothing else to talk about. We are done here.”"]** — Mówca: **Player**
> "“There is nothing else to talk about. We are done here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Maartin Van Hoorten: "“I thought this could be the start of a new era, but appa..."*)

### Węzeł `[224]`
Mówca: **Maartin Van Hoorten**
> "“I thought this could be the start of a new era, but apparently not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Agnolia", "Ne..."*)

### Węzeł `[225]`
Mówca: **Maartin Van Hoorten**
> "“My apologies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Maartin Van Hoorten: "“I thought this could be the start of a new era, but appa..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Did you bring me here to ridicule me?”"]** — Mówca: **Player**
> "“Did you bring me here to ridicule me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Maartin Van Hoorten: "“Of course not.”"*)

### Węzeł `[227]`
Mówca: **Maartin Van Hoorten**
> "“Of course not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[228]`
Mówca: **Maartin Van Hoorten**
> "“Solve your own problems first before you threaten me, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[229]`
Mówca: **Maartin Van Hoorten**
> "“It is difficult...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Maartin Van Hoorten: "“But I will still offer an alternative for the sake of ou..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: "“I won't be joining. It's time we were on our way back home.”"]** — Mówca: **Player**
> "“I won't be joining. It's time we were on our way back home.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "His eyes widened in surprise."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "“After you.”"]** — Mówca: **Player**
> "“After you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "As soon as we left the office, I briefed Symon and Deivid..."*)

### Węzeł `[232]`
Mówca: **Maartin Van Hoorten**
> "“But this is customary. Every Sordish president before you has done this. This won't sit well with us. I must insist we follow the protocol.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: "“I won't say it twice.”"*)
  - -> `[235]` (*Player: "“When you put it like that...sure.”"*)

### Węzeł `[233]`
Mówca: **Narrator**
> "His eyes widened in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Maartin Van Hoorten: "“But this is customary. Every Sordish president before yo..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“I won't say it twice.”"]** — Mówca: **Player**
> "“I won't say it twice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Maartin Van Hoorten: "“This is outrageous. You are not giving confidence to the..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "“When you put it like that...sure.”"]** — Mówca: **Player**
> "“When you put it like that...sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "As soon as we left the office, I briefed Symon and Deivid..."*)

### Węzeł `[236]`
Mówca: **Maartin Van Hoorten**
> "“This is outrageous. You are not giving confidence to the people of Agnolia right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Maartin Van Hoorten: "“But it is your decision, after all.”"*)

### Węzeł `[237]`
Mówca: **Maartin Van Hoorten**
> "“But it is your decision, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Maartin Van Hoorten: "“Very well. I will let them know that you are heading out.”"*)

### Węzeł `[238]`
Mówca: **Maartin Van Hoorten**
> "“Very well. I will let them know that you are heading out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Maartin Van Hoorten: "“See you later, Mr. President. We will be in touch.”"*)

### Węzeł `[239]`
Mówca: **Maartin Van Hoorten**
> "“See you later, Mr. President. We will be in touch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "I got up from my chair."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "I got up from my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player: "“Take care, Maartin.”"*)
  - -> `[241]` (*Player: "“You are very welcome to come visit Sordland.”"*)
  - -> `[243]` (*Player_Italic: "Leave without a word."*)

### Węzeł `[241]`
**[WYBÓR GRACZA: "“You are very welcome to come visit Sordland.”"]** — Mówca: **Player**
> "“You are very welcome to come visit Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Maartin Van Hoorten: "“Surely we can arrange something.”"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Take care, Maartin.”"]** — Mówca: **Player**
> "“Take care, Maartin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Maartin Van Hoorten: "“You as well.”"*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "Leave without a word."]** — Mówca: **Player_Italic**
> "I left without a word."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Outside, Serge was waiting for me. I got in the car and w..."*)

### Węzeł `[244]`
Mówca: **Maartin Van Hoorten**
> "“You as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Outside, Serge was waiting for me. I got in the car and w..."*)

### Węzeł `[245]`
Mówca: **Maartin Van Hoorten**
> "“Surely we can arrange something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Outside, Serge was waiting for me. I got in the car and w..."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Outside, Serge was waiting for me. I got in the car and we started driving back to the airport."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "I briefed Symon and Deivid. The trip back was mostly silent."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "I briefed Symon and Deivid. The trip back was mostly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "I couldn't help but let out a sigh of relief when we touc..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "I couldn't help but let out a sigh of relief when we touched down in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "As soon as we left the office, I briefed Symon and Deivid on the outcome of the meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "The rest of our state trip was full of fake smiles, hands..."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "The rest of our state trip was full of fake smiles, handshakes, incredibly long ceremonies and even longer meetings between our ministers and their counterparts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "When we came to the end of the trip, the way back was mos..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "When we came to the end of the trip, the way back was mostly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "I couldn't help but let out a sigh of relief when we touc..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_FPnT_AgnoliaTradeVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_FPnT_AgnoliaTradeVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised = true;
BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_Sordland_Recognition_Helj..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance = true; 
BaseGameSupport.Journal_Turn05_Trade_AgnoliaMilitarySigned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_Alliance"] = true;
Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaMilitarySigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance = true; BaseGa..."*)

### Węzeł `[255]`
Mówca: **Maartin Van Hoorten**
> "“We were willing at first, but the situation has changed. We do not have confidence in your state anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Maartin Van Hoorten: "“I'm sorry that you've come all this way for this.”"*)

### Węzeł `[256]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Maartin Van Hoorten: "“It was a good move to start building that highway. Overa..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "“Thank you. You are very kind.”"]** — Mówca: **Player**
> "“Thank you. You are very kind.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Van Hoorten leaned back further in contemplation."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: "“I didn't do it for Agnolia. I did it for the people of Sordland.”"]** — Mówca: **Player**
> "“I didn't do it for Agnolia. I did it for the people of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Maartin Van Hoorten: "“Of course. Everything we do is for our people.”"*)

### Węzeł `[259]`
**[WYBÓR GRACZA: "“No need for flattery.”"]** — Mówca: **Player**
> "“No need for flattery.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Maartin Van Hoorten: "“I give credit when it's necessary.”"*)

### Węzeł `[260]`
Mówca: **Maartin Van Hoorten**
> "“Of course. Everything we do is for our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Van Hoorten leaned back further in contemplation."*)

### Węzeł `[261]`
Mówca: **Maartin Van Hoorten**
> "“I give credit when it's necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Van Hoorten leaned back further in contemplation."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Serge pointed at the crowd that gathered on both sides of..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Serge pointed at the crowd that gathered on both sides of..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Serge pointed at the crowd that gathered on both sides of the street. It was a protest. They were shouting and yelling at our convoy. Some of them held signs written in Sordish: 'Sordland Must Pay Its Debts To Agnolia'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Serge Wolkner: "“You know... I never knew Agnolians were so ungrateful. N..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“I wonder what propaganda their state is feeding them...""]** — Mówca: **Player**
> "“I wonder what propaganda their state is feeding them...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Serge Wolkner: ""They are afraid of you, sir. They are scared that Sordla..."*)

### Węzeł `[267]`
Mówca: **Serge Wolkner**
> ""They are afraid of you, sir. They are scared that Sordland will reach its potential. They don't want you to be seen as the great hero you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I'm sorry, but I can't agree to this.""]** — Mówca: **Player**
> "“I'm sorry, but I can't agree to this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Maartin Van Hoorten: "“You went through all this effort to come and say no to me?”"*)

### Węzeł `[269]`
**[WYBÓR GRACZA: "“I can't agree to the higher prices. We prefer to continue with the current steel deal.”"]** — Mówca: **Player**
> "“I can't agree to the higher prices. We prefer to continue with the current steel deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Maartin Van Hoorten: "“We believe that Sordland has been given an unfair advant..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA: "“Agnolian steel isn't worth that much, Mr. Van Hoorten.”"]** — Mówca: **Player**
> "“Agnolian steel isn't worth that much, Mr. Van Hoorten.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Maartin Van Hoorten: "“Is that so? You'd rather import it from Rumburg then?”"*)

### Węzeł `[271]`
**[WYBÓR GRACZA: "“I'm sorry but my answer is no.”"]** — Mówca: **Player**
> "“I'm sorry but my answer is no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Maartin Van Hoorten), `[272]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Maartin Van Hoorten: "“I took you for someone you were not, I suppose. But you ..."*)

### Węzeł `[272]`
Mówca: **Maartin Van Hoorten**
> "“Is that so? You'd rather import it from Rumburg then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player: "“Look, Mr. Van Hoorten. Let's discuss if lower prices are..."*)
  - -> `[279]` (*Player: "“No, but that does not change the fact that the prices ar..."*)
  - -> `[271]` (*Player: "“I'm sorry but my answer is no.”"*)

### Węzeł `[273]`
Mówca: **Maartin Van Hoorten**
> "“We believe that Sordland has been given an unfair advantage for too long because of the previous agreements. We can no longer accept this, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Maartin Van Hoorten: "“Our people believe that we have long been overshadowed b..."*)

### Węzeł `[274]`
Mówca: **Maartin Van Hoorten**
> "“Our people believe that we have long been overshadowed by Sordland. I am here to fix that. With a beneficial trade for both us, nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player: "“Is there no room for discussion?”"*)
  - -> `[276]` (*Player: "“Then I will accept, Mr. Van Hoorten. We don't want to lo..."*)
  - -> `[277]` (*Player: "“I'm sorry but my answer is no.”"*)

### Węzeł `[275]`
**[WYBÓR GRACZA: "“Is there no room for discussion?”"]** — Mówca: **Player**
> "“Is there no room for discussion?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Maartin Van Hoorten: "“We don't want to lose our cooperation with Sordland. May..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "“Then I will accept, Mr. Van Hoorten. We don't want to lose such an important partner as Agnolia.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Then I will accept, Mr. Van Hoorten. We don't want to lose such an important partner as Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_A..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "“I'm sorry but my answer is no.”"]** — Mówca: **Player**
> "“I'm sorry but my answer is no.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Maartin Van Hoorten: "“I took you for someone you were not, I suppose. But you ..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "“Look, Mr. Van Hoorten. Let's discuss if lower prices are possible.”"]** — Mówca: **Player**
> "“Look, Mr. Van Hoorten. Let's discuss if lower prices are possible.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Maartin Van Hoorten: "“We believe that Sordland has been given an unfair advant..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "“No, but that does not change the fact that the prices are too high.”"]** — Mówca: **Player**
> "“No, but that does not change the fact that the prices are too high.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Maartin Van Hoorten: "“We believe that Sordland has been given an unfair advant..."*)

### Węzeł `[280]`
Mówca: **Maartin Van Hoorten**
> "“We don't want to lose our cooperation with Sordland. Maybe I can agree with the old prices. I will offer an alternative for the sake of our history together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Maartin Van Hoorten: "“As you know, Heljiland has been long contested between A..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "“I agree. Sordland will recognize the island.”"]** — Mówca: **Player**
> "“I agree. Sordland will recognize the island.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised = true; BaseGame.Agn..."*)

### Węzeł `[282]`
Mówca: **Maartin Van Hoorten**
> "“Wouldn't it be fitting for Sordland to finally announce the recognition of Heljiland as Agnolian territory? If you do that, we'll have a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: "“I agree. Sordland will recognize the island.”"*)
  - -> `[285]` (*Player: "“You are asking too much.”"*)

### Węzeł `[283]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Maartin Van Hoorten: "“Wouldn't it be fitting for Sordland to finally announce ..."*)

### Węzeł `[284]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Maartin Van Hoorten: "“You know how the international community does not recogn..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "“You are asking too much.”"]** — Mówca: **Player**
> "“You are asking too much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Maartin Van Hoorten: "“Sordland is rejecting a trade deal that rights the wrong..."*)

### Węzeł `[286]`
Mówca: **Maartin Van Hoorten**
> "“Sordland is rejecting a trade deal that rights the wrongs of the past, and doesn't recognize its partners' territories... Yet we are the ones asking for too much?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Maartin Van Hoorten: "“I took you for someone you were not, I suppose. But you ..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised = true;
BaseGame.Agnolia_CheaperSteel = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_CheaperSteel"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised ..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Maartin Van Hoorten: "“Well then.”"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Maartin Van Hoorten: "“Now that we have gone this far and are willing to enter ..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Maartin Van Hoorten: "“Well then.”"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Maartin Van Hoorten: "“But there is another topic I would like to bring up.”"*)

### Węzeł `[294]`
Mówca: **Maartin Van Hoorten**
> "“But there is another topic I would like to bring up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Maartin Van Hoorten: "“As you know, Heljiland has been long contested between A..."*)

### Węzeł `[295]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland. Those warmongers want to take back the island.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Maartin Van Hoorten: "“You know how the international community does not recogn..."*)

### Węzeł `[296]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Maartin Van Hoorten: "“Wouldn't it be fitting for Sordland to finally announce ..."*)

### Węzeł `[297]`
Mówca: **Maartin Van Hoorten**
> "“Wouldn't it be fitting for Sordland to finally announce the recognition of Heljiland as Agnolian territory?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: "“You are asking too much.”"*)
  - -> `[206]` (*Player: "“Another sensible deal. I accept again.”"*)

### Węzeł `[298]`
Mówca: **Maartin Van Hoorten**
> "“But I will still offer an alternative for the sake of our history together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Maartin Van Hoorten: "“First, you will allow us privileged access to your agric..."*)

### Węzeł `[299]`
Mówca: **Maartin Van Hoorten**
> "“As you know, Heljiland has been long contested between Agnolia and Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Maartin Van Hoorten: "“You know how the international community does not recogn..."*)

### Węzeł `[300]`
Mówca: **Maartin Van Hoorten**
> "“We can only agree to this deal if Sordland finally announces the recognition of Heljiland as Agnolian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player: "“Fair enough. Sordland will recognise the island and Agno..."*)
  - -> `[305]` (*Player: "“You are asking too much.”"*)

### Węzeł `[301]`
Mówca: **Maartin Van Hoorten**
> "“You know how the international community does not recognise our rightful claim on the island. *Including Sordland*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Maartin Van Hoorten: "“We can only agree to this deal if Sordland finally annou..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised = true;
BaseGame.Agnolia_TradeDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_TradeDeal"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned = true;"*)

### Węzeł `[303]`
**[WYBÓR GRACZA: "“Fair enough. Sordland will recognise the island and Agnolia's other conditions.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Fair enough. Sordland will recognise the island and accept Agnolia's other conditions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised = true; BaseGame.Agn..."*)

### Węzeł `[304]`
Mówca: **Maartin Van Hoorten**
> "“We are asking too much?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Maartin Van Hoorten: "“I took you for someone you were not, I suppose. But you ..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA: "“You are asking too much.”"]** — Mówca: **Player**
> "“You are asking too much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Maartin Van Hoorten)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Maartin Van Hoorten: "“We are asking too much?”"*)

### Węzeł `[306]`
Mówca: **Maartin Van Hoorten**
> "“And you will buy steel from us for a higher price that rights the wrongs of the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Maartin Van Hoorten: "“And there is this issue...”"*)

### Węzeł `[307]`
Mówca: **Maartin Van Hoorten**
> "“First, you will allow us privileged access to your agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Maartin Van Hoorten: "“And you will buy steel from us for a higher price that r..."*)

### Węzeł `[308]`
Mówca: **Maartin Van Hoorten**
> "“And there is this issue...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Maartin Van Hoorten: "“As you know, Heljiland has been long contested between A..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access = true;
BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access"] = true;
Variable["BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Ag..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_AgnoliaSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Trade = true; BaseGame...."*)

### Węzeł `[311]`
Mówca: **Maartin Van Hoorten**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Maartin Van Hoorten: "“Well then.”"*)

### Węzeł `[312]`
Mówca: **Maartin Van Hoorten**
> "“Unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He took a sip from his vodka."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Heljiland_Map_Layer = 2"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHeljilandDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHeljilandDeal"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_HeljilandRecognized")"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true || BaseGame.Reform_Autocrat_Path == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEn..."*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_Law..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true || BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] > 0  and  (Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lenkurg_Unrest = true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true || BaseGame.Reform_Autocrat_Path == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] > 0  and  (Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lenkurg_Unrest = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lenkurg_Unrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "It was time to discuss the good news."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_AgnoliaAlliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_AgnoliaAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_AgnoliaTradeVisit = true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_AgnoliaDeal = true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_AgnoliaTradeVisit = true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_AgnoliaDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_AgnoliaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_CheaperSteel == true"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_CheaperSteel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_CheaperSteel == true"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_CheaperSteel == true)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_CheaperSteel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_CheaperSteel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_AgnoliaTradeVisit = true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_CheaperSteel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_CheaperSteel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse = true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_AgnoliaDeal_Worse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_AgnoliaTradeVisit = true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_R_DarknessDescendsRY = true; ..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEn..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_R_DarknessDescendsRY = true;
BaseGameSupport.News_Turn05_HP_JournalistArrestedRY = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_DarknessDescendsRY"] = true;
Variable["BaseGameSupport.News_Turn05_HP_JournalistArrestedRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0 && (BaseGame.Turn03_EnT_LawEn..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation += 1"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "He paused for a moment."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AgnoliaTradeDeal_Negotiation += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] = Variable["BaseGame.AgnoliaTradeDeal_Negotiation"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "He paused for a moment."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_CheaperSteel == true"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_CheaperSteel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_CheaperSteel == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_CheaperSteel == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_CheaperSteel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_CheaperSteel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_CheaperSteel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_CheaperSteel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2; BaseGame.GovernmentBudget -..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Agnland += 1;"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;
BaseGame.GovernmentBudget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Agnland += 1;"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_VanHoortenRecognized = true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized = true"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_VanHoortenNotRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGam..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_VanHoortenRecognized = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_VanHoortenRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGam..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Trade = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;
BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = true;
BaseGame.Policy_Diplomacy_Neutrality = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;
Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_A..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Trade = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Maartin Van Hoorten: "“Well then.”"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Trade = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnol..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access = true;
BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access"] = true;
Variable["BaseGame.Situation_Diplomacy_Agnolia_HighSteelPrice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Ag..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access = true;
BaseGame.Situation_Diplomacy_Agnolia_CheapSteelPrice = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_Access"] = true;
Variable["BaseGame.Situation_Diplomacy_Agnolia_CheapSteelPrice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_Sordland_Recognition_Helj..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = true;
BaseGame.Policy_Diplomacy_Neutrality = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Agnolia_Agriculture_Market_A..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance = true;
BaseGame.Policy_Military_JointMilitaryExercises = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] = true;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnol..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGam..."*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseG..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_IncreasedTrade = true; BaseGam..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_IncreasedTrade = false; BaseGa..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGam..."*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseG..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGam..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_RecoveredTrade = false; BaseGa..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_RecoveredTrade = true;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = true;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_IncreasedTrade = true;
BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = true;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_LackOfAllies = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Maartin Van Hoorten: "“That is excellent to hear. Our ministers will go over th..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Agnland += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Maartin Van Hoorten: "“This here is one of the first treaties written between S..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Maartin Van Hoorten: "“This here is one of the first treaties written between S..."*)

### Węzeł `[377]`
Mówca: **Maartin Van Hoorten**
> "“This here is one of the first treaties written between Sordland and Agnolia. Just like the one you prepared with Mr. Wisci before my term. May it mark the renewal of our friendship today as well!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "“I hope so, Mr. Van Hoorten.”"*)
  - -> `[88]` (*Player: "“This is an amazing gift. Thank you.”"*)
  - -> `[89]` (*Player: "“Very good.”"*)

### Węzeł `[378]`
Mówca: **Maartin Van Hoorten**
> "“Sordland is simply too volatile. Elected politicians are getting killed in your country left and right. Not to mention the subsequent protests in between...well...the left and right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Maartin Van Hoorten: "“We were willing at first, but the situation has changed...."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "It was time to discuss the good news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_AgnoliaAlliance");"*)

### Węzeł `[380]`
Mówca: **Maartin Van Hoorten**
> "“This is how we do things in Agnolia, Mr. Rayne. I appreciate the kind words, but flattery alone won't sway me this day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[381]`
**[WYBÓR GRACZA: "“A true gentleman. I can respect that about you, Mr. Hoorten.”"]** — Mówca: **Player**
> "“A true gentleman. I can respect that about you, Mr. Hoorten.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Maartin Van Hoorten: "“This is how we do things in Agnolia, Mr. Rayne. I apprec..."*)

### Węzeł `[382]`
**[WYBÓR GRACZA: "“Let's change the course of our nations.”"]** — Mówca: **Player**
> "“Let's change the course of our nations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.AgnoliaTradeDeal_Negotiation >= 2 || BaseGame.Pr..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PlaneLandingSmoothly");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PlaneLandingSmoothly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "A couple of minutes later, we finally touched down. The p..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Agnolia", "Neutral");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_AgnoliaFailed = true"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Ribel_BergianPoliceAmbushed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Agnolia", "Progress_D..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Heljiland_Map_Layer = 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Heljiland_Map_Layer"] = 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Valgsland_CondemnsHe..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_CheapSteel");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_CheapSteel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Maartin Van Hoorten: "“Excellent.”"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_CheapSteel");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_CheapSteel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_Sordland_Recognition_Helj..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Alliance");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_AgnoliaAlliance");"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Trade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Maartin Van Hoorten: "“Before we dive into the paperwork for the trade deal, I ..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Maartin Van Hoorten: "“Excellent.”"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Maartin Van Hoorten: "“Well then.”"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnol..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Agnolia", "Progress_DiplomaticMission_Agnolia");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Agnolia","Progress_DiplomaticMission_Agnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Sordland One's flight from Holsord to Staalport took thre..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_AgnoliaAlliance");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_AgnoliaAlliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_AgnoliaAlliance = true"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_HeljilandRecognized")`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_HeljilandRecognized");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Agnolia", "Country_Agnolia_Trade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Country_Agnolia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Maartin Van Hoorten: "“Excellent.”"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_AgnoliaAlliance");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_AgnoliaAlliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_LackOfAllies = false;"*)
