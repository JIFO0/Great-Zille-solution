# Rizia/Turn 3/SnO_ZilleSecurityDebrief

- **ID konwersacji:** `304`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/304_SnO_ZilleSecurityDebrief.md`
- **Liczba węzłów dialogowych:** 510
- **Liczba wyborów gracza:** 127

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.SecurityTitus_SupportGoldenGuard`
- `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel`
- `RiziaDLC.Turn01_ZilleVisit_HostileSpeech`
- `RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_GoldenGuard_Total`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub`
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Security_FundNone`
- `RiziaDLC.Security_GoldenGuard_InvestigateSO`
- `RiziaDLC.Situation_Order_KingsGuardForce_Limited`
- `RiziaDLC.Situation_Order_KingsGuardForce_Powerful`
- `RiziaDLC.Turn03_Security_LucitaLeadsInvestigation`
- `RiziaDLC.Turn03_Security_TitusLeadsInvestigation`
- `RiziaDLC.ZilleSecurityDebriefFinished`
- `RiziaDLCSupport.Journal_Turn03_Security_FundForeignIntelligence`
- `RiziaDLCSupport.Journal_Turn03_Security_FundGoldenGuard`
- `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone`
- `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel`
- `RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone`
- `RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel`
- `RiziaDLCSupport.News_Turn03_RH_BeatriceVisit`
- `RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit`
- `RiziaDLCSupport.Reports_Turn03_Jales_FriendshipDayVigil`
- `RiziaDLCText.GoldenGuardUpdate`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""I'm still in shock. How was such an attack allowed to take place in the King's pr..."** | `[11]` **Hugo Toras**: ""Your Majesty. How are you faring?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Hugo Toras**: ""I can only hope Duchess Azaro w..." |
| `[13]` | **""I'm just fine. It's the Wehzek victims of the bombing I'm concerned about.""** | `[11]` **Hugo Toras**: ""Your Majesty. How are you faring?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""It was God's will that you surv..." |
| `[14]` | **""I'm doing all right. So is Mother, in case you cared.""** | `[11]` **Hugo Toras**: ""Your Majesty. How are you faring?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Hugo Toras**: ""Of course the Queen Mother's sa..." |
| `[15]` | **""I'm worried about Wehlen's reaction. Smolak hasn't even made a public statement y..."** | `[11]` **Hugo Toras**: ""Your Majesty. How are you faring?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Hugo Toras**: ""Perhaps no news is good news in..." |
| `[20]` | **""At ease, Duchess Azaro.""** | `[384]` **Narrator**: "Now that crisis had struck, her ..."<br>`[385]` **Narrator**: "Now that crisis had struck, her ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucita Azaro**: ""Thank you, Your Majesty."" |
| `[21]` | **""I need a status report. Now.""** | `[384]` **Narrator**: "Now that crisis had struck, her ..."<br>`[385]` **Narrator**: "Now that crisis had struck, her ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucita Azaro**: ""Certainly, Your Majesty."" |
| `[22]` | **""We're not all gentlemen. Do not forget the presence of the princess.""** | `[384]` **Narrator**: "Now that crisis had struck, her ..."<br>`[385]` **Narrator**: "Now that crisis had struck, her ..." | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[389]` **Narrator**: "Lucita greeted Vina with an impa..." |
| `[23]` | **""Thank you for joining us, Duchess Azaro. Can you update us on the Zille situation?""** | `[384]` **Narrator**: "Now that crisis had struck, her ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucita Azaro**: ""Certainly, Your Majesty."" |
| `[32]` | **""Don't forget that right before the attack, someone screamed 'For the King.'""** | `[31]` **Lucita Azaro**: ""The most recent casualty report..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Lucita Azaro**: ""I haven't forgotten. Nor has We..." |
| `[33]` | **""Yes, yes, we know all that. What's new?""** | `[31]` **Lucita Azaro**: ""The most recent casualty report..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Lucita Azaro**: ""I was getting to that."" |
| `[34]` | **""Was anyone important among the dead?""** | `[31]` **Lucita Azaro**: ""The most recent casualty report..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lucita Azaro**: ""No, the most prominent Wehzek a..." |
| `[35]` | **""Thank God. From what I saw, it could have been much worse.""** | `[31]` **Lucita Azaro**: ""The most recent casualty report..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Lucita Azaro**: ""It's not good for us regardless."" |
| `[46]` | **""I appreciate the boy's efforts. But I wish he would coordinate them with me.""** | `[300]` **Lucita Azaro**: ""I should clarify, the group's o..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[60]` **Hugo Toras**: ""That's part of the reason why I..." |
| `[47]` | **""It's true. National identity should be secondary to one's loyalty to the throne.""** | `[422]` **Vina Toras**: ""Queen Lyza always said monarchy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""Do you really think the Wehzek ..." |
| `[48]` | **""That's rubbish. The monarchy and the nation of Rizia cannot be separated from one..."** | `[422]` **Vina Toras**: ""Queen Lyza always said monarchy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Hugo Toras**: ""That's the message the public n..." |
| `[49]` | **""Please don't change the subject, Vina.""** | `[422]` **Vina Toras**: ""Queen Lyza always said monarchy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Lucita Azaro**: ""Agreed, Let's get back to the t..." |
| `[50]` | **""Yes, Rico has no right using the Toras name to serve his own xenophobic agenda.""** | `[422]` **Vina Toras**: ""Queen Lyza always said monarchy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""My son is as much of a Toras as..." |
| `[54]` | **""Then what are your foreign intelligence agents good for? They didn't even predict..."** | `[53]` **Lucita Azaro**: ""Future or not, we have no concr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucita Azaro**: ""They've been doing the best the..." |
| `[55]` | **""And it's in Wehlen's interest to pin the blame for the bombing on Rizia.""** | `[53]` **Lucita Azaro**: ""Future or not, we have no concr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lucita Azaro**: ""Exactly. We still haven't ruled..." |
| `[56]` | **""Rico has no right using the Toras name to support a xenophobic agenda.""** | `[300]` **Lucita Azaro**: ""I should clarify, the group's o..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[61]` **Hugo Toras**: ""Surely you don't truly feel tha..."<br>`[338]` **Hugo Toras**: ""The group is unfairly maligned...." |
| `[57]` | **""I know the way these groups function. It's only a short leap from talk to bloodsh..."** | `[300]` **Lucita Azaro**: ""I should clarify, the group's o..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[61]` **Hugo Toras**: ""Surely you don't truly feel tha..."<br>`[338]` **Hugo Toras**: ""The group is unfairly maligned...." |
| `[58]` | **""Without them, Wehlen's criminals would be running roughshod all over our country.""** | `[300]` **Lucita Azaro**: ""I should clarify, the group's o..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[339]` **Hugo Toras**: ""That's the message the public n..." |
| `[59]` | **""What more do we need? It seems like a cut-and-dried case to me.""** | `[53]` **Lucita Azaro**: ""Future or not, we have no concr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Have you not considered the pos..." |
| `[69]` | **""Why have we not looked into this ourselves?""** | `[53]` **Lucita Azaro**: ""Future or not, we have no concr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lucita Azaro**: ""Our foreign intelligence agency..." |
| `[76]` | **""What's your point, Mr. Gordion?""** | `[75]` **Titus Gordion**: ""Prior to His Majesty's arrival,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Titus Gordion**: ""This event has shown how vulner..." |
| `[77]` | **""You missed a bomb. That counts as a massive lapse on the Golden Guard's part.""** | `[75]` **Titus Gordion**: ""Prior to His Majesty's arrival,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Titus Gordion**: ""Our job is to take every measur..." |
| `[78]` | **""You helped save our lives back there. No need to make excuses.""** | `[75]` **Titus Gordion**: ""Prior to His Majesty's arrival,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Titus Gordion**: ""It shouldn't have even come to ..." |
| `[79]` | **""It shouldn't have been your job to find the bomb. It was Wehlen's.""** | `[75]` **Titus Gordion**: ""Prior to His Majesty's arrival,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Titus Gordion**: ""Our job is to take every measur..." |
| `[88]` | **""Good point. Before giving more funding to foreign intelligence, I need to make su..."** | `[495]` **Titus Gordion**: ""I am asking for permission to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Titus Gordion**: ""Precisely. If it were up to me,..." |
| `[89]` | **""What kind of investigations did you have in mind, Captain?""** | `[495]` **Titus Gordion**: ""I am asking for permission to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Titus Gordion**: ""Your Majesty, given the resourc..." |
| `[90]` | **""Can you not make more efficient use of the funding you already have. Captain?""** | `[495]` **Titus Gordion**: ""I am asking for permission to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Titus Gordion**: ""The type of investigation I'm p..." |
| `[91]` | **""We need to find out who's behind this bombing. Can the Golden Guard help with that?""** | `[495]` **Titus Gordion**: ""I am asking for permission to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Titus Gordion**: ""That's precisely what I'm sugge..." |
| `[98]` | **""Take a moment, Mr. Esquibel.""** | `[97]` **Laurento Esquibel**: ""Excuse me, Your Majesty. My fel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Narrator**: "Laurento sat down. After catchin..." |
| `[100]` | **""Don't interrupt us. We're in the middle of an important security briefing.""** | `[97]` **Laurento Esquibel**: ""Excuse me, Your Majesty. My fel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Laurento Esquibel**: ""I understand, Your Majesty. But..." |
| `[101]` | **""What's going on?""** | `[97]` **Laurento Esquibel**: ""Excuse me, Your Majesty. My fel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Narrator**: "Laurento sat down. After catchin..." |
| `[112]` | **""Past is past. We have to focus on what we're going to do next.""** | `[111]` **Laurento Esquibel**: ""I did advise you to maintain an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Laurento Esquibel**: ""Correct. Wehlen will be expecti..." |
| `[113]` | **""Do not question my decisions, Mr. Esquibel.""** | `[111]` **Laurento Esquibel**: ""I did advise you to maintain an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Laurento Esquibel**: ""My sincerest apologies. Let's f..." |
| `[114]` | **""I didn't incite anything. I merely told the truth.""** | `[111]` **Laurento Esquibel**: ""I did advise you to maintain an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Laurento Esquibel**: ""On their own, your words might ..." |
| `[115]` | **""I'm sorry. I must have gotten carried away.""** | `[111]` **Laurento Esquibel**: ""I did advise you to maintain an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Laurento Esquibel**: ""What's done is done. But now We..." |
| `[125]` | **""How dare he insult us with these baseless accusations?""** | `[122]` **Lucita Azaro**: ""He's just testing us. His gover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Laurento Esquibel**: ""People are dead, Your Majesty. ..." |
| `[126]` | **""An apology won't be enough. I have to point the finger somewhere.""** | `[124]` **Hugo Toras**: ""Still, an apology for your hars..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lucita Azaro**: ""Then point it right back at Weh..." |
| `[127]` | **""This makes me certain that Wehlen was behind the bombing. They're trying to weake..."** | `[122]` **Lucita Azaro**: ""He's just testing us. His gover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucita Azaro**: ""You see now why I want to launc..." |
| `[128]` | **""Lack of proof never stopped Wehlen from waging war on the Bluds. The Wehzeks are ..."** | `[122]` **Lucita Azaro**: ""He's just testing us. His gover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Hugo Toras**: ""Yes, I can't imagine any respon..." |
| `[129]` | **""I'll do whatever I have to do to get President Smolak back on our side.""** | `[122]` **Lucita Azaro**: ""He's just testing us. His gover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Lucita Azaro**: ""That's dangerous, Your Majesty...." |
| `[133]` | **""I understand the need to apologize. What I won't do is blame my own people for wh..."** | `[124]` **Hugo Toras**: ""Still, an apology for your hars..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Hugo Toras**: ""Quite right. There's no need to..." |
| `[134]` | **""An apology would be an admission of guilt. I can't do that.""** | `[124]` **Hugo Toras**: ""Still, an apology for your hars..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Lucita Azaro**: ""That's right. If we let Smolak ..." |
| `[135]` | **""I'll do whatever I have to do to get the President back on our side.""** | `[124]` **Hugo Toras**: ""Still, an apology for your hars..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lucita Azaro**: ""That's dangerous, Your Majesty...." |
| `[148]` | **""Well summarized, Vina.""** | `[147]` **Vina Toras**: ""Our security response to the Zi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Vina Toras**: ""Thank you, Your Majesty."" |
| `[149]` | **""Actually, taking up Titus' offer to conduct a thorough investigation of Su Omina ..."** | `[146]` **Hugo Toras**: ""A question of priorities. Duche..."<br>`[147]` **Vina Toras**: ""Our security response to the Zi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Hugo Toras**: ""At the expense of Rico's dignit..." |
| `[150]` | **""If I fund Duchess Azaro's investigation and it exposes Wehzek wrongdoing, Smolak ..."** | `[146]` **Hugo Toras**: ""A question of priorities. Duche..."<br>`[147]` **Vina Toras**: ""Our security response to the Zi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Laurento Esquibel**: ""A tricky needle to thread, Your..." |
| `[155]` | **""Thank you for the summary, Hugo.""** | `[146]` **Hugo Toras**: ""A question of priorities. Duche..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Hugo Toras**: ""My pleasure. His Majesty alread..." |
| `[157]` | **""To be honest, I'd rather not waste our budget on either of those.""** | `[146]` **Hugo Toras**: ""A question of priorities. Duche..."<br>`[147]` **Vina Toras**: ""Our security response to the Zi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Titus Gordion**: ""A grave mistake, Your Majesty."" |
| `[159]` | **""How much would that cost us?""** | `[70]` **Lucita Azaro**: ""With an increased foreign intel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Lucita Azaro**: ""A significant portion of our em..." |
| `[161]` | **""And what if it turns out Rizian nationalists were responsible after all?""** | `[70]` **Lucita Azaro**: ""With an increased foreign intel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Lucita Azaro**: ""Then they'll be found and dealt..." |
| `[163]` | **""More budget demands? This country is not made of money, Duchess Azaro.""** | `[70]` **Lucita Azaro**: ""With an increased foreign intel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Lucita Azaro**: ""If the truth is not revealed, i..." |
| `[165]` | **""Sounds like a good idea to me.""** | `[70]` **Lucita Azaro**: ""With an increased foreign intel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Lucita Azaro**: ""Then you have better judgement ..." |
| `[181]` | **""Let's go with Lucita's proposal. Expand our intelligence force and send a team of..."** | `[180]` **Laurento Esquibel**: ""So, Your Majesty. Will the Crow..." | `Variable["RiziaDLC.Resources_Budget"] > 3` | *Brak zmian stanu* | `[310]` **Narrator**: "Lucita clasped her hands together." |
| `[182]` | **""Captain Gordion, I admire your initiative. I'll provide support to expand the Gua..."** | `[180]` **Laurento Esquibel**: ""So, Your Majesty. Will the Crow..." | `Variable["RiziaDLC.Resources_Budget"] > 3` | *Brak zmian stanu* | `[311]` **Narrator**: "Titus forcefully saluted." |
| `[183]` | **""Sorry to disappoint you both, but I've decided not to fund either of your investi..."** | `[180]` **Laurento Esquibel**: ""So, Your Majesty. Will the Crow..." | `Variable["RiziaDLC.Resources_Budget"] > 3` | *Brak zmian stanu* | `[326]` **Narrator**: "Lucita and Titus looked at each ..." |
| `[199]` | **""Yes, you're all dismissed. Enjoy the rest of your day.""** | `[192]` **Titus Gordion**: ""Nothing more to discuss, sir.""<br>`[196]` **Lucita Azaro**: ""I'm quite satisfied with our re..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Hugo Toras"); RemoveConversant("Vina To...`<br>`RemoveConversant("Hugo Toras"); RemoveConversant("Vina To...`<br>*(+1 skryptów)* | `[206]` **Narrator**: "The others began filing out of t..."<br>`[205]` **Narrator**: "The others began filing out of t..."<br>*(oraz 1 innych odgałęzień)* |
| `[200]` | **""We're done when I say we're done. But yes, we are done.""** | `[192]` **Titus Gordion**: ""Nothing more to discuss, sir.""<br>`[196]` **Lucita Azaro**: ""I'm quite satisfied with our re..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Hugo Toras"); RemoveConversant("Vina To...`<br>`RemoveConversant("Hugo Toras"); RemoveConversant("Vina To...`<br>*(+1 skryptów)* | `[206]` **Narrator**: "The others began filing out of t..."<br>`[205]` **Narrator**: "The others began filing out of t..."<br>*(oraz 1 innych odgałęzień)* |
| `[201]` | **""This meeting is adjourned.""** | `[192]` **Titus Gordion**: ""Nothing more to discuss, sir.""<br>`[196]` **Lucita Azaro**: ""I'm quite satisfied with our re..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Hugo Toras"); RemoveConversant("Vina To...`<br>`RemoveConversant("Hugo Toras"); RemoveConversant("Vina To...`<br>*(+1 skryptów)* | `[206]` **Narrator**: "The others began filing out of t..."<br>`[205]` **Narrator**: "The others began filing out of t..."<br>*(oraz 1 innych odgałęzień)* |
| `[217]` | **""I expect results, Duchess Azaro. Don't disappoint me.""** | `[214]` **Lucita Azaro**: ""Allow me to express my gratitud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Lucita Azaro**: ""I won't."" |
| `[218]` | **""Don't mention it. Your counsel is far more valuable than that of our doddering el..."** | `[214]` **Lucita Azaro**: ""Allow me to express my gratitud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Lucita Azaro**: ""Shh. They're just outside this ..." |
| `[219]` | **""Now that you have the funding, I'd like your help with an investigation of a more..."** | `[214]` **Lucita Azaro**: ""Allow me to express my gratitud..." | `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true` | *Brak zmian stanu* | `[221]` **Lucita Azaro**: ""I would be honored. What is it?"" |
| `[220]` | **""Your father would be proud, Major.""** | `[214]` **Lucita Azaro**: ""Allow me to express my gratitud..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[226]` **Lucita Azaro**: ""Thank you, Lieutenant."" |
| `[231]` | **""You are the King's guard, Mr. Gordion. Your loyalty should not be contingent on f..."** | `[215]` **Titus Gordion**: ""Thank you once again, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Titus Gordion**: ""No. Of course not. I beg your p..." |
| `[233]` | **""I expect results, Titus. Don't disappoint me.""** | `[215]` **Titus Gordion**: ""Thank you once again, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Titus Gordion**: ""I swear on my life that I will ..." |
| `[237]` | **""Good. Because there's one other investigation I'd like you to conduct for me." [I..."** | `[215]` **Titus Gordion**: ""Thank you once again, Your Maje..." | `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true` | *Brak zmian stanu* | `[238]` **Titus Gordion**: ""Is this in regard the murder in..."<br>`[435]` **Titus Gordion**: ""Yes, sir?"" |
| `[239]` | **""Yes. I'd like to know exactly how my father died.""** | `[238]` **Titus Gordion**: ""Is this in regard the murder in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Narrator**: "Titus froze in place. He spoke i..." |
| `[241]` | **""You already demonstrated that loyalty back in Zille. This is the least I can do f..."** | `[215]` **Titus Gordion**: ""Thank you once again, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Titus Gordion**: ""Again, I was only fulfilling my..." |
| `[242]` | **""Precisely. It's imperative that I receive any and all information surrounding the..."** | `[238]` **Titus Gordion**: ""Is this in regard the murder in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "Titus eyes grew wide. He lowered..." |
| `[250]` | **""Almost everyone. Leave my butler out of it.""** | `[249]` **Titus Gordion**: ""Should everyone who was present..."<br>`[432]` **Titus Gordion**: ""If there's evidence of wrongdoi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusIn...`<br>`Variable["RiziaDLC.PoisonInvestigator_Titus"] = true;` | `[254]` **Narrator**: "Titus nodded seriously." |
| `[251]` | **""Yes. Hugo, the Grand Wiseman, my mother, Lucita Azaro. And Pabel, too.""** | `[249]` **Titus Gordion**: ""Should everyone who was present..."<br>`[432]` **Titus Gordion**: ""If there's evidence of wrongdoi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusIn...`<br>`Variable["RiziaDLC.PoisonInvestigator_Titus"] = true;` | `[254]` **Narrator**: "Titus nodded seriously." |
| `[257]` | **""What is it, Your Grace?""** | `[252]` **Narrator**: "The others filed out of the room..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "My uncle looked me in the eyes." |
| `[261]` | **""I don't have anything against Rico personally. But Wehlen needs a scapegoat.""** | `[252]` **Narrator**: "The others filed out of the room..." | `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true` | *Brak zmian stanu* | `[264]` **Narrator**: "Hugo slowly shook his head." |
| `[262]` | **""Whether or not Su Omina was involved in Zille, I want Rico to rein them in.""** | `[252]` **Narrator**: "The others filed out of the room..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Narrator**: "Hugo was quiet for a moment, the..." |
| `[266]` | **""You were right. It's about time I visited Rico in Iza.""** | `[252]` **Narrator**: "The others filed out of the room..." | `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false` | *Brak zmian stanu* | `[267]` **Narrator**: "Hugo slowly nodded." |
| `[273]` | **""My days with that group are long over. We have to make it clear that they don't r..."** | `[272]` **Narrator**: "She looked meaningfully at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Lucita Azaro**: ""The continued involvement of on..." |
| `[274]` | **""I know Su Omina. They would never commit such a reprehensible act.""** | `[272]` **Narrator**: "She looked meaningfully at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Lucita Azaro**: ""They've grown more extreme sinc..." |
| `[280]` | **""What evidence are they basing this on? Anyone can scream 'For the King.'""** | `[272]` **Narrator**: "She looked meaningfully at me."<br>`[282]` **Narrator**: "She looked meaningfully at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Lucita Azaro**: ""Unclear. This is all they've to..." |
| `[283]` | **""The views of those extremists do not represent those of the throne. We have to ma..."** | `[282]` **Narrator**: "She looked meaningfully at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Lucita Azaro**: ""The continued involvement of on..." |
| `[284]` | **""What exactly has your son Rico been up to in Iza, Your Grace?""** | `[282]` **Narrator**: "She looked meaningfully at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Hugo Toras**: ""I've already spoken to Rico. He..." |
| `[287]` | **""Why was I not included in this conversation?""** | `[279]` **Hugo Toras**: ""I told you, Duchess Azaro, I've..."<br>`[286]` **Hugo Toras**: ""I've already spoken to Rico. He..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Hugo Toras**: ""Because it was superfluous. Su ..." |
| `[289]` | **""What were Su Omina's activities like in the months leading up to the attack?""** | `[279]` **Hugo Toras**: ""I told you, Duchess Azaro, I've..."<br>`[286]` **Hugo Toras**: ""I've already spoken to Rico. He..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Lucita Azaro**: ""Nothing out of the ordinary. A ..."<br>`[294]` **Lucita Azaro**: ""Nothing out of the ordinary. A ..." |
| `[296]` | **""I believe him. This has Wehlen's fingerprints all over it.""** | `[279]` **Hugo Toras**: ""I told you, Duchess Azaro, I've..."<br>`[286]` **Hugo Toras**: ""I've already spoken to Rico. He..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Hugo Toras**: ""A sight more likely than a peac..." |
| `[297]` | **""How can you trust him? Of course he wouldn't admit to being involved.""** | `[279]` **Hugo Toras**: ""I told you, Duchess Azaro, I've..."<br>`[286]` **Hugo Toras**: ""I've already spoken to Rico. He..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Hugo Toras**: ""I trust him because I trust the..." |
| `[304]` | **""You know I will always support Su Omina. If I condemn them, I'm condemning myself.""** | `[252]` **Narrator**: "The others filed out of the room..." | `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true` | *Brak zmian stanu* | `[270]` **Narrator**: "My uncle looked me in the eyes." |
| `[312]` | **""I hate to disappoint both of you, but our treasury can't afford either investigat..."** | `[180]` **Laurento Esquibel**: ""So, Your Majesty. Will the Crow..." | `(Variable["RiziaDLC.Resources_Budget"] > 3) == false` | *Brak zmian stanu* | `[326]` **Narrator**: "Lucita and Titus looked at each ..." |
| `[317]` | **""It had better not, Captain Gordion.""** | `[315]` **Titus Gordion**: ""Rest assured this will not affe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Laurento Esquibel**: ""There's still the matter of the..." |
| `[318]` | **""It's nothing personal.""** | `[315]` **Titus Gordion**: ""Rest assured this will not affe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Laurento Esquibel**: ""There's still the matter of the..." |
| `[319]` | **""A true professional. I appreciate that.""** | `[315]` **Titus Gordion**: ""Rest assured this will not affe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Laurento Esquibel**: ""There's still the matter of the..." |
| `[323]` | **""Don't be afraid to get your hands dirty, Titus.""** | `[322]` **Hugo Toras**: ""And I'm expecting tact and disc..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[340]` **Laurento Esquibel**: ""There's still the matter of the..." |
| `[324]` | **""As am I. House Toras must appear clean in all this.""** | `[322]` **Hugo Toras**: ""And I'm expecting tact and disc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Laurento Esquibel**: ""There's still the matter of the..." |
| `[325]` | **""Stop hassling my guard. My trust in Titus should be enough reassurance for you bo..."** | `[322]` **Hugo Toras**: ""And I'm expecting tact and disc..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC....` | `[340]` **Laurento Esquibel**: ""There's still the matter of the..." |
| `[331]` | **""Do you have any suggestions?""** | `[330]` **Laurento Esquibel**: ""You will, however, still have t..."<br>`[340]` **Laurento Esquibel**: ""There's still the matter of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Laurento Esquibel**: ""I suggest you tell the truth. Y..."<br>`[351]` **Laurento Esquibel**: ""I suggest a boilerplate stateme..." |
| `[332]` | **""I won't dignify their accusations with a reply.""** | `[330]` **Laurento Esquibel**: ""You will, however, still have t..."<br>`[340]` **Laurento Esquibel**: ""There's still the matter of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Laurento Esquibel**: ""The international community wil..." |
| `[333]` | **""I know exactly what to say.""** | `[330]` **Laurento Esquibel**: ""You will, however, still have t..."<br>`[340]` **Laurento Esquibel**: ""There's still the matter of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Laurento Esquibel**: ""I trust you to make the diploma..." |
| `[352]` | **""Then help me out. What do I say?""** | `[334]` **Laurento Esquibel**: ""The international community wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Laurento Esquibel**: ""I suggest you tell the truth. Y..."<br>`[351]` **Laurento Esquibel**: ""I suggest a boilerplate stateme..." |
| `[353]` | **""All right. I'll draft the statement after this meeting.""** | `[334]` **Laurento Esquibel**: ""The international community wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Laurento Esquibel**: ""I trust you to make the diploma..." |
| `[396]` | **""I want to find out exactly how my father died.""** | `[221]` **Lucita Azaro**: ""I would be honored. What is it?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Narrator**: "She froze in place." |
| `[398]` | **""Actually... never mind.""** | `[221]` **Lucita Azaro**: ""I would be honored. What is it?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Narrator**: "She gave me a puzzled look." |
| `[406]` | **""I have reason to believe the causes were less than natural.""** | `[402]` **Lucita Azaro**: ""It was a heart attack. He was a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Lucita Azaro**: ""I see."" |
| `[407]` | **""Don't question me. Just open an investigation. Discreetly.""** | `[402]` **Lucita Azaro**: ""It was a heart attack. He was a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Lucita Azaro**: ""Sorry, Your Majesty. I will."" |
| `[412]` | **""Almost everyone. Leave my butler out of it.""** | `[411]` **Lucita Azaro**: ""Am I to assume everyone who was..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaI...`<br>`Variable["RiziaDLC.PoisonInvestigator_Lucita"] = true;` | `[416]` **Narrator**: "She nodded." |
| `[413]` | **""Yes. Titus, Hugo, my mother and the Grand Wiseman. And Pabel, too.""** | `[411]` **Lucita Azaro**: ""Am I to assume everyone who was..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaI...`<br>`Variable["RiziaDLC.PoisonInvestigator_Lucita"] = true;` | `[416]` **Narrator**: "She nodded." |
| `[424]` | **""Of course they would say that. It's clear that President Smolak was behind this.""** | `[272]` **Narrator**: "She looked meaningfully at me."<br>`[282]` **Narrator**: "She looked meaningfully at Hugo." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Hugo Toras**: ""I agree."" |
| `[430]` | **""Exactly. I believe that there's reason to suspect that the late king died under q..."** | `[238]` **Titus Gordion**: ""Is this in regard the murder in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "Eyes wide, Titus hushed his voic..." |
| `[436]` | **""I'd like to know exactly how my father died. I have reason to believe that his de..."** | `[435]` **Titus Gordion**: ""Yes, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Narrator**: "Titus froze in place. He spoke i..." |
| `[437]` | **""I'd like you to initiate a murder inquiry, with a specific focus on the circumsta..."** | `[435]` **Titus Gordion**: ""Yes, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "Titus eyes grew wide. He lowered..." |
| `[438]` | **""I believe that there's reason to suspect that the late king died under questionab..."** | `[435]` **Titus Gordion**: ""Yes, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "Eyes wide, Titus hushed his voic..." |
| `[444]` | **""The crown will not provide further assistance.""** | `[180]` **Laurento Esquibel**: ""So, Your Majesty. Will the Crow..." | `(Variable["RiziaDLC.Resources_Budget"] > 3) == false` | *Brak zmian stanu* | `[326]` **Narrator**: "Lucita and Titus looked at each ..." |
| `[452]` | **""Our discussion wasn't intentionally concealed from you, nor was it pre-planned. F..."** | `[451]` **Lucita Azaro**: ""The expansion of the Golden Gua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Lucita Azaro**: ""All well and good, Your Majesty..." |
| `[453]` | **""It's not your place to question whom I talk to and when. If there's information w..."** | `[451]` **Lucita Azaro**: ""The expansion of the Golden Gua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Narrator**: "Lucita scowled." |
| `[454]` | **""It slipped my mind.""** | `[451]` **Lucita Azaro**: ""The expansion of the Golden Gua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Lucita Azaro**: ""Uh-huh."" |
| `[455]` | **""Titus and I spoke about it recently. I've been meaning to bring it up with you.""** | `[451]` **Lucita Azaro**: ""The expansion of the Golden Gua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Lucita Azaro**: ""Uh-huh."" |
| `[465]` | **""Enough with your baseless insinuations. Circumstances change, and I must make dec..."** | `[464]` **Titus Gordion**: ""I hope this isn't indicative of..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[316]` **Narrator**: "Titus bowed his head." |
| `[466]` | **""I respect you as my guardsman, Captain, but this is an internationally sensitive ..."** | `[464]` **Titus Gordion**: ""I hope this isn't indicative of..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[316]` **Narrator**: "Titus bowed his head." |
| `[467]` | **""Sometimes even the best-laid plans can take unexpected turns. I'll try to make it..."** | `[464]` **Titus Gordion**: ""I hope this isn't indicative of..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[316]` **Narrator**: "Titus bowed his head." |
| `[468]` | **""And you'll continue to have my full support. I simply agree with Duchess Azaro on..."** | `[464]` **Titus Gordion**: ""I hope this isn't indicative of..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[316]` **Narrator**: "Titus bowed his head." |
| `[474]` | **""My support for the Golden Guard remains as steadfast as ever, and your insinuatio..."** | `[473]` **Titus Gordion**: ""However, I must admit my disapp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[329]` **Hugo Toras**: ""Saving money is always prudent...." |
| `[475]` | **""And I must admit my disappointment in you, Captain. You, of all people, should kn..."** | `[473]` **Titus Gordion**: ""However, I must admit my disapp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[329]` **Hugo Toras**: ""Saving money is always prudent...." |
| `[476]` | **""Life has a way of throwing surprises into our best-laid plans. I'll try to make i..."** | `[473]` **Titus Gordion**: ""However, I must admit my disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Hugo Toras**: ""Saving money is always prudent...." |
| `[477]` | **""And you'll continue to have my full support. It's just that I share Duchess Azaro..."** | `[473]` **Titus Gordion**: ""However, I must admit my disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Hugo Toras**: ""Saving money is always prudent...." |
| `[483]` | **""You'll be included in such meetings if I deem it necessary.""** | `[482]` **Lucita Azaro**: ""Very well. But in the future, p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[486]` **Narrator**: "Lucita released an exasperated s..." |
| `[484]` | **""I'll consider it.""** | `[482]` **Lucita Azaro**: ""Very well. But in the future, p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Narrator**: "Lucita let out a sigh of exasper..." |
| `[485]` | **""Yes. Next time I'll be sure you're included. This was an isolated incident.""** | `[482]` **Lucita Azaro**: ""Very well. But in the future, p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Lucita Azaro**: ""Thank you, Your Majesty. In any..." |

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
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Getting an emergency briefing after a bo..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "A few weeks had passed since the attack in Zille."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I called Lucita, Hugo, Titus and Vina to my council chambers for a security update."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion"); AddConversant("Vina Toras..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I called Lucita, Hugo, Titus and Vina to my council chamb..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I called Lucita, Hugo and Titus to my council chambers fo..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I called Lucita, Hugo and Titus to my council chambers for a security update."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion"); AddConversant("Hugo Toras..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Titus insisted on sweeping the room before Vina and I sat down. Hugo was next to arrive, early as usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Your Majesty. How are you faring?""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Titus insisted on sweeping the room before I sat down. Hugo was next to arrive, early as usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Your Majesty. How are you faring?""*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Your Majesty. How are you faring?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""I'm still in shock. How was such an attack allowed to ta..."*)
  - -> `[13]` (*Player_Romus: ""I'm just fine. It's the Wehzek victims of the bombing I'..."*)
  - -> `[14]` (*Player_Romus: ""I'm doing all right. So is Mother, in case you cared.""*)
  - -> `[15]` (*Player_Romus: ""I'm worried about Wehlen's reaction. Smolak hasn't even ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still in shock. How was such an attack allowed to take place in the King's presence?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""I can only hope Duchess Azaro will enlighten us on that ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just fine. It's the Wehzek victims of the bombing I'm concerned about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""It was God's will that you survived. Losing two kings wi..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm doing all right. So is Mother, in case you cared.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""Of course the Queen Mother's safety is of the utmost imp..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm worried about Wehlen's reaction. Smolak hasn't even made a public statement yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""Perhaps no news is good news in this case.""*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""Perhaps no news is good news in this case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucita Azaro: ""Gentlemen!""*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""I can only hope Duchess Azaro will enlighten us on that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucita Azaro: ""Gentlemen!""*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""It was God's will that you survived. Losing two kings within a year would have been catastrophic for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucita Azaro: ""Gentlemen!""*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Of course the Queen Mother's safety is of the utmost importance to me. But losing two kings in a matter of months would have been catastrophic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucita Azaro: ""Gentlemen!""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At ease, Duchess Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Narrator), `[385]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucita Azaro: ""Thank you, Your Majesty.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need a status report. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Narrator), `[385]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucita Azaro: ""Certainly, Your Majesty.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're not all gentlemen. Do not forget the presence of the princess.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[384]` (Narrator), `[385]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "Lucita greeted Vina with an impatient half-bow."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for joining us, Duchess Azaro. Can you update us on the Zille situation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucita Azaro: ""Certainly, Your Majesty.""*)

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Still standing, she picked a dossier up off the table and..."*)

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Lucita sat and flipped open a dossier."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Lucita sat and flipped open a dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucita Azaro: ""I'll reiterate what we already know.""*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Still standing, she picked a dossier up off the table and flipped it open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucita Azaro: ""I'll reiterate what we already know.""*)

### Węzeł `[28]`
Mówca: **Lucita Azaro**
> ""I'll reiterate what we already know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucita Azaro: ""At 1605 hours on December 8, 1950, an explosive object d..."*)

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""At 1605 hours on December 8, 1950, an explosive object detonated in Smolak Square in the city of Zille. It had been planted beneath grandstands that were set up that morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucita Azaro: ""Seated in those stands were a mix of civilians and polit..."*)

### Węzeł `[30]`
Mówca: **Lucita Azaro**
> ""Seated in those stands were a mix of civilians and political figures who had been invited to the Friendship Day event, all of Wehzek heritage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""The most recent casualty report states that three civili..."*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""The most recent casualty report states that three civilians were killed in the blast. Of the 14 injured, all are now in stable condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""Thank God. From what I saw, it could have been much worse.""*)
  - -> `[34]` (*Player_Romus: ""Was anyone important among the dead?""*)
  - -> `[33]` (*Player_Romus: ""Yes, yes, we know all that. What's new?""*)
  - -> `[32]` (*Player_Romus: ""Don't forget that right before the attack, someone screa..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget that right before the attack, someone screamed 'For the King.'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucita Azaro: ""I haven't forgotten. Nor has Wehlen.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, yes, we know all that. What's new?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucita Azaro: ""I was getting to that.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was anyone important among the dead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucita Azaro: ""No, the most prominent Wehzek attendees all made it out ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank God. From what I saw, it could have been much worse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""It's not good for us regardless.""*)

### Węzeł `[36]`
Mówca: **Lucita Azaro**
> ""No, the most prominent Wehzek attendees all made it out unharmed. Wehlen's guards saw to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She turned a page."*)

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""It's not good for us regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She turned a page."*)

### Węzeł `[38]`
Mówca: **Lucita Azaro**
> ""I was getting to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She turned a page."*)

### Węzeł `[39]`
Mówca: **Lucita Azaro**
> ""I haven't forgotten. Nor has Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She turned a page."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She turned a page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucita Azaro: ""Based on the scant evidence available, Wehlen's intellig..."*)

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""Based on the scant evidence available, Wehlen's intelligence agency suspects that the Rizian nationalist group Su Omina was behind the crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[42]`
Mówca: **Vina Toras**
> ""I don't understand why Cousin Rico would even support a group like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Vina Toras: ""Queen Lyza always said monarchy was incompatible with na..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Vina Toras: ""I don't understand why Cousin Rico would even support a ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Rico has no right using the Toras name to support a xeno..."*)
  - -> `[46]` (*Player_Romus: ""I appreciate the boy's efforts. But I wish he would coor..."*)
  - -> `[57]` (*Player_Romus: ""I know the way these groups function. It's only a short ..."*)
  - -> `[58]` (*Player_Romus: ""Without them, Wehlen's criminals would be running roughs..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the boy's efforts. But I wish he would coordinate them with me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""That's part of the reason why I've been asking you to vi..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true. National identity should be secondary to one's loyalty to the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""Do you really think the Wehzek miscreants streaming into..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's rubbish. The monarchy and the nation of Rizia cannot be separated from one another. I appreciate Rico's efforts to protect both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Hugo Toras: ""That's the message the public needs to hear.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't change the subject, Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucita Azaro: ""Agreed, Let's get back to the topic at hand. Although...""*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Rico has no right using the Toras name to serve his own xenophobic agenda.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""My son is as much of a Toras as you or Princess Vina. An..."*)

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""If I may, Your Grace, why have you never once thrown your own weight behind Su Omina if you support its ideals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Hugo spread his hands wide."*)

### Węzeł `[52]`
Mówca: **Lucita Azaro**
> ""Agreed, Let's get back to the topic at hand. Although...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""Future or not, we have no concrete proof Su Omina was behind the attack. All we have is Wehlen's word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""Then what are your foreign intelligence agents good for?..."*)
  - -> `[55]` (*Player_Romus: ""And it's in Wehlen's interest to pin the blame for the b..."*)
  - -> `[69]` (*Player_Romus: ""Why have we not looked into this ourselves?""*)
  - -> `[59]` (*Player_Romus: ""What more do we need? It seems like a cut-and-dried case..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then what are your foreign intelligence agents good for? They didn't even predict this would happen!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucita Azaro: ""They've been doing the best they can with their limited ..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And it's in Wehlen's interest to pin the blame for the bombing on Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucita Azaro: ""Exactly. We still haven't ruled out the possibility that..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico has no right using the Toras name to support a xenophobic agenda.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the way these groups function. It's only a short leap from talk to bloodshed.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Without them, Wehlen's criminals would be running roughshod all over our country.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[300]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Hugo Toras: ""That's the message the public needs to hear.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What more do we need? It seems like a cut-and-dried case to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Have you not considered the possibility that the attack ..."*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""That's part of the reason why I've been asking you to visit Iza. Obviously the King should be kept abreast of the group's activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""Surely you don't truly feel that way, or you wouldn't have lent your support to the group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "He smiled warmly at Vina. My daughter looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucita Azaro: ""Future or not, we have no concrete proof Su Omina was be..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""My son is as much of a Toras as you or Princess Vina. And frankly, he should be commended for his efforts to protect the country from miscreants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""Do you really think the Wehzek miscreants streaming into this country are doing so out of loyalty to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""They've been doing the best they can with their limited resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucita Azaro: ""With an increased foreign intelligence budget, we could ..."*)

### Węzeł `[66]`
Mówca: **Lucita Azaro**
> ""Exactly. We still haven't ruled out the possibility that President Smolak himself ordered it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""Or another party interested in weakening the both of us.""*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Have you not considered the possibility that the attack was staged by Wehlen itself? Or another party interested in weakening both of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucita Azaro: ""With an increased foreign intelligence budget, we could ..."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""Or another party interested in weakening the both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucita Azaro: ""With an increased foreign intelligence budget, we could ..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why have we not looked into this ourselves?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""Our foreign intelligence agency is hamstrung by its limi..."*)

### Węzeł `[70]`
Mówca: **Lucita Azaro**
> ""With an increased foreign intelligence budget, we could commission a full investigation into the Zille incident and take measures to prevent such an event from reoccurring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: ""How much would that cost us?""*)
  - -> `[161]` (*Player_Romus: ""And what if it turns out Rizian nationalists were respon..."*)
  - -> `[163]` (*Player_Romus: ""More budget demands? This country is not made of money, ..."*)
  - -> `[165]` (*Player_Romus: ""Sounds like a good idea to me.""*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""Our foreign intelligence agency is hamstrung by its limited resources, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucita Azaro: ""With an increased foreign intelligence budget, we could ..."*)

### Węzeł `[72]`
Mówca: **Titus Gordion**
> ""Pardon me, ma'am. Major. Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "All eyes turned towards the man in the gold blazer."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "All eyes turned towards the man in the gold blazer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Titus Gordion: ""May I point out that you weren't present on the day of t..."*)

### Węzeł `[74]`
Mówca: **Titus Gordion**
> ""May I point out that you weren't present on the day of the Zille incident. The King and I were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Titus Gordion: ""Prior to His Majesty's arrival, my men and I attempted t..."*)

### Węzeł `[75]`
Mówca: **Titus Gordion**
> ""Prior to His Majesty's arrival, my men and I attempted to clear the square of every conceivable danger. However, we could not be everywhere at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""What's your point, Mr. Gordion?""*)
  - -> `[77]` (*Player_Romus: ""You missed a bomb. That counts as a massive lapse on the..."*)
  - -> `[78]` (*Player_Romus: ""You helped save our lives back there. No need to make ex..."*)
  - -> `[79]` (*Player_Romus: ""It shouldn't have been your job to find the bomb. It was..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's your point, Mr. Gordion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Titus Gordion: ""This event has shown how vulnerable you and the royal fa..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You missed a bomb. That counts as a massive lapse on the Golden Guard's part.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Titus Gordion: ""Our job is to take every measure to protect the King of ..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You helped save our lives back there. No need to make excuses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Titus Gordion: ""It shouldn't have even come to that point.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It shouldn't have been your job to find the bomb. It was Wehlen's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Titus Gordion: ""Our job is to take every measure to protect the King of ..."*)

### Węzeł `[80]`
Mówca: **Titus Gordion**
> ""It shouldn't have even come to that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Titus Gordion: ""This event has shown how vulnerable you and the royal fa..."*)

### Węzeł `[81]`
Mówca: **Titus Gordion**
> ""Our job is to take every measure to protect the King of Rizia. In that respect, we failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Titus Gordion: ""This event has shown how vulnerable you and the royal fa..."*)

### Węzeł `[82]`
Mówca: **Titus Gordion**
> ""Our job is to take every measure to protect the King of Rizia. In that respect, we failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Titus Gordion: ""This event has shown how vulnerable you and the royal fa..."*)

### Węzeł `[83]`
Mówca: **Titus Gordion**
> ""This event has shown how vulnerable you and the royal family truly are, and how ill-equipped my men and I are to seek out and neutralize threats to your safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Titus Gordion: ""Therefore, it is my opinion that any emergency funding a..."*)

### Węzeł `[84]`
Mówca: **Titus Gordion**
> ""Therefore, it is my opinion that any emergency funding allocated in the wake of the Zille attack should go towards re-expanding the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Titus Gordion: ""With a full-fledged division under my command, I could a..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucita's jaw dropped. Hugo eyed Titus uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)

### Węzeł `[86]`
Mówca: **Titus Gordion**
> ""Ma'am, it's important to recognize the historical significance of the Golden Guard. Until quite recently, our role extended far beyond mere guardians of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Titus Gordion: ""Previously, the Guard had the authority to conduct sensi..."*)

### Węzeł `[87]`
Mówca: **Titus Gordion**
> ""Previously, the Guard had the authority to conduct sensitive internal investigations without getting caught up in red tape. The Royal Family and Rizia were both more secure because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Narrator: "Lucita gritted her teeth."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. Before giving more funding to foreign intelligence, I need to make sure I'm safe within my own borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Titus Gordion: ""Precisely. If it were up to me, I would recruit a number..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of investigations did you have in mind, Captain?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Titus Gordion: ""Your Majesty, given the resources, we could recruit a nu..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you not make more efficient use of the funding you already have. Captain?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""The type of investigation I'm proposing would require mo..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to find out who's behind this bombing. Can the Golden Guard help with that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Titus Gordion: ""That's precisely what I'm suggesting. We need to recruit..."*)

### Węzeł `[92]`
Mówca: **Titus Gordion**
> ""That's precisely what I'm suggesting. We need to recruit qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Hugo Toras: ""Excuse me?""*)

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Your Majesty, given the resources, we could recruit a number of qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Hugo Toras: ""Excuse me?""*)

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""The type of investigation I'm proposing would require more, sir. We need to recruit qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Hugo Toras: ""Excuse me?""*)

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""With respect, sir, we don't know whether it's a dead end. And investigating an organization with ties to the royal family is exactly the kind of sensitive mission the Golden Guard was built for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Lucita Azaro: ""Perhaps so, Captain Gordion, but the attack took place i..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "She, Hugo and Titus glared at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "The tension was broken by a knock on the door. Laurento c..."*)

### Węzeł `[97]`
Mówca: **Laurento Esquibel**
> ""Excuse me, Your Majesty. My fellow councilors. These stairs never get easier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""Take a moment, Mr. Esquibel.""*)
  - -> `[100]` (*Player_Romus: ""Don't interrupt us. We're in the middle of an important ..."*)
  - -> `[101]` (*Player_Romus: ""What's going on?""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take a moment, Mr. Esquibel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Laurento sat down. After catching his breath, he continued."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The tension was broken by a knock on the door. Laurento came in, clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel");"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't interrupt us. We're in the middle of an important security briefing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Laurento Esquibel: ""I understand, Your Majesty. But you're going to want to ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's going on?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Laurento sat down. After catching his breath, he continued."*)

### Węzeł `[102]`
Mówca: **Laurento Esquibel**
> ""I understand, Your Majesty. But you're going to want to hear this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Laurento Esquibel: ""I've just received word from Wehlen's foreign minister. ..."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Laurento sat down. After catching his breath, he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Laurento Esquibel: ""I've just received word from Wehlen's foreign minister. ..."*)

### Węzeł `[104]`
Mówca: **Laurento Esquibel**
> ""I've just received word from Wehlen's foreign minister. President Smolak plans to make it public that Rizian nationalists were involved in the Zille incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Lucita's hands closed into fists."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Lucita's hands closed into fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)

### Węzeł `[106]`
Mówca: **Laurento Esquibel**
> ""Furthermore, given the contents of the King's speech just prior to the attack, chances are that King Romus himself will come under fire for inciting the violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "He shook his head sadly."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Laurento Esquibel: ""Furthermore, given the contents of the King's speech jus..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Laurento Esquibel: ""Our relations with Wehlen have been cordial enough that ..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "He shook his head sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Laurento Esquibel: ""I did advise you to maintain an air of civility, Your Ma..."*)

### Węzeł `[111]`
Mówca: **Laurento Esquibel**
> ""I did advise you to maintain an air of civility, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""Past is past. We have to focus on what we're going to do..."*)
  - -> `[113]` (*Player_Romus: ""Do not question my decisions, Mr. Esquibel.""*)
  - -> `[114]` (*Player_Romus: ""I didn't incite anything. I merely told the truth.""*)
  - -> `[115]` (*Player_Romus: ""I'm sorry. I must have gotten carried away.""*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Past is past. We have to focus on what we're going to do next.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Laurento Esquibel: ""Correct. Wehlen will be expecting a response from us.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not question my decisions, Mr. Esquibel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Laurento Esquibel: ""My sincerest apologies. Let's focus on how we're going t..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't incite anything. I merely told the truth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Laurento Esquibel: ""On their own, your words might not have been considered ..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. I must have gotten carried away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Laurento Esquibel: ""What's done is done. But now Wehlen will be expecting a ..."*)

### Węzeł `[116]`
Mówca: **Laurento Esquibel**
> ""Our relations with Wehlen have been cordial enough that Smolak will not immediately blame the crown. But he will be expecting a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucita Azaro: ""He's just testing us. His government can't prove anything.""*)

### Węzeł `[117]`
Mówca: **Laurento Esquibel**
> ""My sincerest apologies. Let's focus on how we're going to respond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Smolak is just testing us. His government can't prove an..."*)

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""Correct. Wehlen will be expecting a response from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Smolak is just testing us. His government can't prove an..."*)

### Węzeł `[119]`
Mówca: **Laurento Esquibel**
> ""On their own, your words might not have been considered incendiary. But their timing was most unfortunate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Laurento Esquibel: ""Wehlen will be expecting a response from us.""*)

### Węzeł `[120]`
Mówca: **Laurento Esquibel**
> ""What's done is done. But now Wehlen will be expecting a response from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Smolak is just testing us. His government can't prove an..."*)

### Węzeł `[121]`
Mówca: **Laurento Esquibel**
> ""Wehlen will be expecting a response from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""Smolak is just testing us. His government can't prove an..."*)

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""He's just testing us. His government can't prove anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""How dare he insult us with these baseless accusations?""*)
  - -> `[127]` (*Player_Romus: ""This makes me certain that Wehlen was behind the bombing..."*)
  - -> `[128]` (*Player_Romus: ""Lack of proof never stopped Wehlen from waging war on th..."*)
  - -> `[129]` (*Player_Romus: ""I'll do whatever I have to do to get President Smolak ba..."*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Smolak is just testing us. His government can't prove anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""Still, an apology for your harsh language would be in or..."*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Still, an apology for your harsh language would be in order so as not to inflame relations further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""An apology won't be enough. I have to point the finger s..."*)
  - -> `[133]` (*Player_Romus: ""I understand the need to apologize. What I won't do is b..."*)
  - -> `[134]` (*Player_Romus: ""An apology would be an admission of guilt. I can't do th..."*)
  - -> `[135]` (*Player_Romus: ""I'll do whatever I have to do to get the President back ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare he insult us with these baseless accusations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Laurento Esquibel: ""People are dead, Your Majesty. Someone must take the bla..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An apology won't be enough. I have to point the finger somewhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucita Azaro: ""Then point it right back at Wehlen. Launch an investigat..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This makes me certain that Wehlen was behind the bombing. They're trying to weaken our claim on Zille.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucita Azaro: ""You see now why I want to launch an investigation? Imagi..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lack of proof never stopped Wehlen from waging war on the Bluds. The Wehzeks are irrational.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""Yes, I can't imagine any response that would pacify that..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do whatever I have to do to get President Smolak back on our side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lucita Azaro: ""That's dangerous, Your Majesty. If we begin offering con..."*)

### Węzeł `[130]`
Mówca: **Lucita Azaro**
> ""That's dangerous, Your Majesty. If we begin offering concessions, there are no limits to what Wehlen will demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[131]`
Mówca: **Lucita Azaro**
> ""You see now why I want to launch an investigation? Imagine the reaction once it comes out that Smolak attacked his own people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""Yes, I can't imagine any response that would pacify that man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand the need to apologize. What I won't do is blame my own people for what happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Hugo Toras: ""Quite right. There's no need to throw Rico to the Wehzek..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An apology would be an admission of guilt. I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucita Azaro: ""That's right. If we let Smolak believe we have something..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do whatever I have to do to get the President back on our side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucita Azaro: ""That's dangerous, Your Majesty. If we begin offering con..."*)

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""That's right. If we let Smolak believe we have something to apologize for, there are no limits to what he'll demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[137]`
Mówca: **Laurento Esquibel**
> ""People are dead, Your Majesty. Someone must take the blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[138]`
Mówca: **Lucita Azaro**
> ""That's dangerous, Your Majesty. If we begin offering concessions, there are no limits to what Wehlen will demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""Quite right. There's no need to throw Rico to the Wehzek wolves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""Then point it right back at Wehlen. Launch an investigation. Call Smolak's bluff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[141]`
Mówca: **Laurento Esquibel**
> ""May I ask what the five of you were discussing before I came in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""Our security response to the Zille incident. Duchess Aza..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Laurento Esquibel: ""May I ask what the five of you were discussing before I ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Laurento Esquibel: ""May I ask what the four of you were discussing before I ..."*)

### Węzeł `[145]`
Mówca: **Laurento Esquibel**
> ""May I ask what the four of you were discussing before I came in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Hugo Toras: ""A question of priorities. Duchess Azaro is requesting fu..."*)

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""A question of priorities. Duchess Azaro is requesting funding for a foreign intelligence expansion in order to investigate the Zille incident. Mr. Gordion would rather his Golden Guard be enlarged and given license to conduct its own investigations within Rizia's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""If I fund Duchess Azaro's investigation and it exposes W..."*)
  - -> `[149]` (*Player_Romus: ""Actually, taking up Titus' offer to conduct a thorough i..."*)
  - -> `[157]` (*Player_Romus: ""To be honest, I'd rather not waste our budget on either ..."*)
  - -> `[155]` (*Player_Romus: ""Thank you for the summary, Hugo.""*)

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""Our security response to the Zille incident. Duchess Azaro is requesting funds for an expansion of foreign intelligence to conduct an investigation in Wehlen, while Captain Gordion would prefer the Golden Guard be expanded and given license to investigate threats within Rizia's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""If I fund Duchess Azaro's investigation and it exposes W..."*)
  - -> `[149]` (*Player_Romus: ""Actually, taking up Titus' offer to conduct a thorough i..."*)
  - -> `[157]` (*Player_Romus: ""To be honest, I'd rather not waste our budget on either ..."*)
  - -> `[148]` (*Player_Romus: ""Well summarized, Vina.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well summarized, Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Vina Toras: ""Thank you, Your Majesty.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, taking up Titus' offer to conduct a thorough investigation of Su Omina could help pacify Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Hugo Toras), `[147]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Hugo Toras: ""At the expense of Rico's dignity, and thus the dignity o..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I fund Duchess Azaro's investigation and it exposes Wehzek wrongdoing, Smolak won't have a leg to stand on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Hugo Toras), `[147]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Laurento Esquibel: ""A tricky needle to thread, Your Majesty. Pursuing such a..."*)

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""At the expense of Rico's dignity, and thus the dignity of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Titus Gordion: ""Rest assured that if the Duke of Iza has nothing to hide..."*)

### Węzeł `[152]`
Mówca: **Titus Gordion**
> ""Rest assured that if the Duke of Iza has nothing to hide, his dignity will remain intact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Laurento Esquibel: ""Showing Wehlen that you are serious about investigating ..."*)

### Węzeł `[153]`
Mówca: **Laurento Esquibel**
> ""A tricky needle to thread, Your Majesty. Pursuing such an investigation might lead the President to think you're undermining his authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucita Azaro: ""If Wehlen has nothing to hide, they will welcome our ass..."*)

### Węzeł `[154]`
Mówca: **Vina Toras**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Laurento raised an eyebrow at Titus, pleasantly surprised."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the summary, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""My pleasure. His Majesty already knows which course of a..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Laurento raised an eyebrow at Titus, pleasantly surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Laurento Esquibel: ""Interesting initiative, Mr. Gordion. Following up on Weh..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be honest, I'd rather not waste our budget on either of those.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Hugo Toras), `[147]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Titus Gordion: ""A grave mistake, Your Majesty.""*)

### Węzeł `[158]`
Mówca: **Titus Gordion**
> ""A grave mistake, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucita Azaro: ""For once we agree, Captain. Going along with Wehlen's ac..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much would that cost us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucita Azaro: ""A significant portion of our emergency funds. But it'll ..."*)

### Węzeł `[160]`
Mówca: **Lucita Azaro**
> ""A significant portion of our emergency funds. But it'll be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Titus Gordion: ""Pardon me, ma'am. Major. Duchess.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if it turns out Rizian nationalists were responsible after all?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: ""Then they'll be found and dealt with.""*)

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Then they'll be found and dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Titus Gordion: ""Pardon me, ma'am. Major. Duchess.""*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More budget demands? This country is not made of money, Duchess Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucita Azaro: ""If the truth is not revealed, it will cost us even more ..."*)

### Węzeł `[164]`
Mówca: **Lucita Azaro**
> ""If the truth is not revealed, it will cost us even more dearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Titus Gordion: ""Pardon me, ma'am. Major. Duchess.""*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a good idea to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucita Azaro: ""Then you have better judgement than your father did.""*)

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""Then you have better judgement than your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Titus Gordion: ""Pardon me, ma'am. Major. Duchess.""*)

### Węzeł `[167]`
Mówca: **Lucita Azaro**
> ""For once we agree, Captain. Going along with Wehlen's accusations without even trying to gather our own evidence would only give Smolak ammunition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Laurento Esquibel: ""So, Your Majesty. Will the Crown be funding one of these..."*)

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""If Wehlen has nothing to hide, they will welcome our assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Hugo Toras: ""Sending investigators to Zille would also shift the focu..."*)

### Węzeł `[169]`
Mówca: **Laurento Esquibel**
> ""Showing Wehlen that you are serious about investigating the potential terrorists makes diplomatic sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[170]`
Mówca: **Lucita Azaro**
> ""Let's not forget His Majesty has a personal history with the organization. Uncovering any unsavory information could harm the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Titus Gordion: ""But officially clearing Su Omina's name would be a boon ..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucita Azaro: ""Let's not forget His Majesty has a personal history with..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucita Azaro: ""I agree it's dangerous to investigate an organization th..."*)

### Węzeł `[174]`
Mówca: **Lucita Azaro**
> ""I agree it's dangerous to investigate an organization that His Majesty has blood ties to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Titus Gordion: ""But officially clearing Su Omina's name would be a boon ..."*)

### Węzeł `[175]`
Mówca: **Titus Gordion**
> ""But officially clearing Su Omina's name would be a boon for both the group and the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Laurento Esquibel: ""So, Your Majesty. Will the Crown be funding one of these..."*)

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""Sending investigators to Zille would also shift the focus away from Su Omina and the royal family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Laurento Esquibel: ""So, Your Majesty. Will the Crown be funding one of these..."*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""My pleasure. His Majesty already knows which course of action I'd prefer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Laurento raised an eyebrow at Titus, pleasantly surprised."*)

### Węzeł `[178]`
Mówca: **Laurento Esquibel**
> ""Interesting initiative, Mr. Gordion. Following up on Wehlen's leads with our own internal investigation would certainly make diplomatic sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Hugo Toras: ""Would it? Or would it cast unnecessary suspicions on the..."*)

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""Precisely. If it were up to me, I would recruit a number of qualified individuals and equip them with the technology to carry out covert surveillance in Iza--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Hugo Toras: ""Excuse me?""*)

### Węzeł `[180]`
Mówca: **Laurento Esquibel**
> ""So, Your Majesty. Will the Crown be funding one of these proposed expansions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Let's go with Lucita's proposal. Expand our intelligence force and send a team of investigators to Wehlen." [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Let's go with Lucita's proposal. Expand our intelligence force and send a team of investigators to Wehlen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Kontekst wejściowy (poprzednik):** `[180]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Lucita clasped her hands together."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Captain Gordion, I admire your initiative. I'll provide support to expand the Guard to a division-sized unit. With these extra resources, you'll conduct a full investigation into Su Omina's activities." [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Captain Gordion, I admire your initiative. I'll provide support to expand the Guard to a division-sized unit. With these extra resources, you'll conduct a full investigation into Su Omina's activities.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Kontekst wejściowy (poprzednik):** `[180]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "Titus forcefully saluted."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry to disappoint you both, but I've decided not to fund either of your investigations.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Kontekst wejściowy (poprzednik):** `[180]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Lucita and Titus looked at each other."*)

### Węzeł `[184]`
Mówca: **Titus Gordion**
> ""Thank you for your trust in the Golden Guard, sir. We won't fail you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded = true; RiziaD..."*)

### Węzeł `[185]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. I promise my department will get results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded = true; RiziaDLC.Turn03_Security_LucitaLeadsInvestigation = true;  RiziaDLCSupport.Journal_Turn03_Security_FundForeignIntelligence = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] = true;
Variable["RiziaDLC.Turn03_Security_LucitaLeadsInvestigation"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Security_FundForeignIntelligence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 4;"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded = true; RiziaDLC.Turn03_Security_TitusLeadsInvestigation = true;
RiziaDLC.Army_Unit_GoldenGuard_Total += 1;
RiziaDLC.Situation_Order_KingsGuardForce_Limited = false;
RiziaDLC.Situation_Order_KingsGuardForce_Powerful = true;
RiziaDLC.Security_GoldenGuard_InvestigateSO = true; RiziaDLCSupport.Journal_Turn03_Security_FundGoldenGuard = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = true;
Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] = true;
Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] = Variable["RiziaDLC.Army_Unit_GoldenGuard_Total"] + 1;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Limited"] = false;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Powerful"] = true;
Variable["RiziaDLC.Security_GoldenGuard_InvestigateSO"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Security_FundGoldenGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 4; RiziaDLC.Relations_Lucita..."*)

### Węzeł `[188]`
Mówca: **Laurento Esquibel**
> ""It seems the next steps are quite clear, or was there any other subject that needed discussion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Titus Gordion: ""Nothing more to discuss, sir.""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[192]`
Mówca: **Titus Gordion**
> ""Nothing more to discuss, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""Yes, you're all dismissed. Enjoy the rest of your day.""*)
  - -> `[200]` (*Player_Romus: ""We're done when I say we're done. But yes, we are done.""*)
  - -> `[201]` (*Player_Romus: ""This meeting is adjourned.""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Lucita Azaro: ""I'm quite satisfied with our results today.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""I'm quite satisfied with our results today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""Yes, you're all dismissed. Enjoy the rest of your day.""*)
  - -> `[200]` (*Player_Romus: ""We're done when I say we're done. But yes, we are done.""*)
  - -> `[201]` (*Player_Romus: ""This meeting is adjourned.""*)

### Węzeł `[197]`
Mówca: **Hugo Toras**
> ""I'll see you out. I have nothing more to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""Yes, you're all dismissed. Enjoy the rest of your day.""*)
  - -> `[200]` (*Player_Romus: ""We're done when I say we're done. But yes, we are done.""*)
  - -> `[201]` (*Player_Romus: ""This meeting is adjourned.""*)

### Węzeł `[198]`
Mówca: **Vina Toras**
> ""I think that was everything, wasn't it, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""Yes, you're all dismissed. Enjoy the rest of your day.""*)
  - -> `[200]` (*Player_Romus: ""We're done when I say we're done. But yes, we are done.""*)
  - -> `[201]` (*Player_Romus: ""This meeting is adjourned.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, you're all dismissed. Enjoy the rest of your day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Titus Gordion), `[196]` (Lucita Azaro), `[197]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're done when I say we're done. But yes, we are done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Titus Gordion), `[196]` (Lucita Azaro), `[197]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This meeting is adjourned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Titus Gordion), `[196]` (Lucita Azaro), `[197]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Vina Toras: ""I think that was everything, wasn't it, Your Majesty?""*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Hugo Toras: ""I'll see you out. I have nothing more to say.""*)

### Węzeł `[205]`
Mówca: **Narrator**
> "The others began filing out of the room. Titus stayed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "He walked up to me and looked me in the eyes."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "The others began filing out of the room. Lucita stayed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "She took off her cap and looked me in the eyes."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Vina To..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Vina To..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Vina..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "She took off her cap and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucita Azaro: ""Allow me to express my gratitude once more, Your Majesty..."*)

### Węzeł `[214]`
Mówca: **Lucita Azaro**
> ""Allow me to express my gratitude once more, Your Majesty. As a newcomer to this council, it means a lot that you would place your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""I expect results, Duchess Azaro. Don't disappoint me.""*)
  - -> `[218]` (*Player_Romus: ""Don't mention it. Your counsel is far more valuable than..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true"*)

### Węzeł `[215]`
Mówca: **Titus Gordion**
> ""Thank you once again, Your Majesty. You have the Golden Guard's undying loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""You are the King's guard, Mr. Gordion. Your loyalty shou..."*)
  - -> `[233]` (*Player_Romus: ""I expect results, Titus. Don't disappoint me.""*)
  - -> `[241]` (*Player_Romus: ""You already demonstrated that loyalty back in Zille. Thi..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true"*)

### Węzeł `[216]`
Mówca: **Narrator**
> "He walked up to me and looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Titus Gordion: ""Thank you once again, Your Majesty. You have the Golden ..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect results, Duchess Azaro. Don't disappoint me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lucita Azaro: ""I won't.""*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't mention it. Your counsel is far more valuable than that of our doddering elders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucita Azaro: ""Shh. They're just outside this door.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Now that you have the funding, I'd like your help with an investigation of a more sensitive nature." [Investigate Poisoning]"]** — Mówca: **Player_Romus**
> ""Now that you have the funding, I'd like your help with an investigation of a more sensitive nature.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucita Azaro: ""I would be honored. What is it?""*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your father would be proud, Major.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Thank you, Lieutenant.""*)

### Węzeł `[221]`
Mówca: **Lucita Azaro**
> ""I would be honored. What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Player_Romus: ""I want to find out exactly how my father died.""*)
  - -> `[398]` (*Player_Romus: ""Actually... never mind.""*)

### Węzeł `[222]`
Mówca: **Lucita Azaro**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "She shook my hand firmly."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""Your father would be proud, Major.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Thank you, Lieutenant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "She reached out and gave me a handshake. Her hand lingere..."*)

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""Shh. They're just outside this door.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "She reached out and gave me a handshake. Her hand lingere..."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "She reached out and gave me a handshake. Her hand lingered in mine for just a second longer than normal before she withdrew it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance += 1"*)

### Węzeł `[229]`
Mówca: **Lucita Azaro**
> ""I'll update you soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "She put her cap back on and hurriedly left the room."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "She put her cap back on and hurriedly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are the King's guard, Mr. Gordion. Your loyalty should not be contingent on funding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Titus Gordion: ""No. Of course not. I beg your pardon.""*)

### Węzeł `[232]`
Mówca: **Titus Gordion**
> ""No. Of course not. I beg your pardon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Titus Gordion: ""In any case, expect an update soon on the progress on Su..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect results, Titus. Don't disappoint me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Titus Gordion: ""I swear on my life that I will not.""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == ..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player_Romus: ""Good. Because there's one other investigation I'd like y..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[237]`
**[WYBÓR GRACZA: ""Good. Because there's one other investigation I'd like you to conduct for me." [Investigate Poisoning]"]** — Mówca: **Player_Romus**
> ""Good. Because there's one other investigation I'd like you to conduct for me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Kontekst wejściowy (poprzednik):** `[215]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true"*)

### Węzeł `[238]`
Mówca: **Titus Gordion**
> ""Is this in regard the murder investigation you previously alluded to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player_Romus: ""Yes. I'd like to know exactly how my father died.""*)
  - -> `[242]` (*Player_Romus: ""Precisely. It's imperative that I receive any and all in..."*)
  - -> `[430]` (*Player_Romus: ""Exactly. I believe that there's reason to suspect that t..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I'd like to know exactly how my father died.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Titus froze in place. He spoke in a low voice."*)

### Węzeł `[240]`
Mówca: **Titus Gordion**
> ""I swear on my life that I will not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Titus Gordion: ""In any case, expect an update soon on the progress on Su..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already demonstrated that loyalty back in Zille. This is the least I can do for you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Titus Gordion: ""Again, I was only fulfilling my duty. But much appreciat..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely. It's imperative that I receive any and all information surrounding the circumstances of my father's death.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Titus eyes grew wide. He lowered the volume of his voice ..."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Titus eyes grew wide. He lowered the volume of his voice so that only I could hear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Titus Gordion: ""I was also there that night, as you already know. Like y..."*)

### Węzeł `[244]`
Mówca: **Titus Gordion**
> ""I was also there that night, as you already know. Like you, I too find the circumstances suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Titus Gordion: ""If there's evidence of wrongdoing, should we regard ever..."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "Titus froze in place. He spoke in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Titus Gordion: ""As you know, I was there in the palace when it happened...."*)

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""Again, I was only fulfilling my duty. But much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Titus Gordion: ""In any case, expect an update soon on the progress on Su..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "Titus gave a dutiful bow and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[248]`
Mówca: **Titus Gordion**
> ""As you know, I was there in the palace when it happened. And believe me, I have some questions of my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Titus Gordion: ""Should everyone who was present that night be considered..."*)

### Węzeł `[249]`
Mówca: **Titus Gordion**
> ""Should everyone who was present that night be considered a suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""Almost everyone. Leave my butler out of it.""*)
  - -> `[251]` (*Player_Romus: ""Yes. Hugo, the Grand Wiseman, my mother, Lucita Azaro. A..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Almost everyone. Leave my butler out of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Titus Gordion), `[432]` (Titus Gordion), `[434]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateM..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Hugo, the Grand Wiseman, my mother, Lucita Azaro. And Pabel, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Titus Gordion), `[432]` (Titus Gordion), `[434]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateM..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "The others filed out of the room. Hugo stayed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: ""What is it, Your Grace?""*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[262]` (*Player_Romus: ""Whether or not Su Omina was involved in Zille, I want Ri..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel = true;
RiziaDLC.InvestigatePoisoning_NoPabel = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderNoPabel"] = true;
Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus = true"*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Titus nodded seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Titus Gordion: ""Consider it handled. Expect an update soon along with th..."*)

### Węzeł `[255]`
Mówca: **Titus Gordion**
> ""Consider it handled. Expect an update soon along with the progress on Su Omina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Titus gave a dutiful bow and left the room."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_TitusInvestigateMurderEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus = true"*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "My uncle looked me in the eyes."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_Denounce..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""I don't have anything against Rico personally. But Wehle..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""You were right. It's about time I visited Rico in Iza.""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have anything against Rico personally. But Wehlen needs a scapegoat.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "Hugo slowly shook his head."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether or not Su Omina was involved in Zille, I want Rico to rein them in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "Hugo was quiet for a moment, then looked me in the eyes."*)

### Węzeł `[263]`
Mówca: **Hugo Toras**
> ""Come to Iza, Romus. Speak to your cousin. You're long overdue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Without waiting for an answer, he left."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "Hugo slowly shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Hugo Toras: ""Come to Iza, Romus. Speak to your cousin. You're long ov..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Without waiting for an answer, he left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were right. It's about time I visited Rico in Iza.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Hugo slowly nodded."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "Hugo slowly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Hugo Toras: ""He'd be overjoyed. I'll arrange everything.""*)

### Węzeł `[268]`
Mówca: **Hugo Toras**
> ""He'd be overjoyed. I'll arrange everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He turned and left the room."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "Hugo was quiet for a moment, then looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Hugo Toras: ""Come to Iza, Romus. Speak to your cousin. You're long ov..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "My uncle looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Hugo Toras: ""Come to Iza, Romus. Speak to your cousin. You're long ov..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "He turned and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[272]`
Mówca: **Narrator**
> "She looked meaningfully at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Player_Romus: ""Of course they would say that. It's clear that President..."*)
  - -> `[273]` (*Player_Romus: ""My days with that group are long over. We have to make i..."*)
  - -> `[274]` (*Player_Romus: ""I know Su Omina. They would never commit such a reprehen..."*)
  - -> `[280]` (*Player_Romus: ""What evidence are they basing this on? Anyone can scream..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My days with that group are long over. We have to make it clear that they don't represent the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucita Azaro: ""The continued involvement of one Rico Toras would sugges..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Su Omina. They would never commit such a reprehensible act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucita Azaro: ""They've grown more extreme since your day. Rico Toras wo..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "She looked meaningfully at me."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "She looked meaningfully at Hugo."*)

### Węzeł `[278]`
Mówca: **Lucita Azaro**
> ""The continued involvement of one Rico Toras would suggest otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Hugo Toras: ""I told you, Duchess Azaro, I've already spoken to Rico. ..."*)

### Węzeł `[279]`
Mówca: **Hugo Toras**
> ""I told you, Duchess Azaro, I've already spoken to Rico. He had absolutely nothing to do with what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Why was I not included in this conversation?""*)
  - -> `[289]` (*Player_Romus: ""What were Su Omina's activities like in the months leadi..."*)
  - -> `[296]` (*Player_Romus: ""I believe him. This has Wehlen's fingerprints all over it.""*)
  - -> `[297]` (*Player_Romus: ""How can you trust him? Of course he wouldn't admit to be..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What evidence are they basing this on? Anyone can scream 'For the King.'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator), `[282]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucita Azaro: ""Unclear. This is all they've told us. The Duke of Iza mi..."*)

### Węzeł `[281]`
Mówca: **Lucita Azaro**
> ""They've grown more extreme since your day. Rico Toras would know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Hugo Toras: ""I told you, Duchess Azaro, I've already spoken to Rico. ..."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "She looked meaningfully at Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Player_Romus: ""Of course they would say that. It's clear that President..."*)
  - -> `[280]` (*Player_Romus: ""What evidence are they basing this on? Anyone can scream..."*)
  - -> `[283]` (*Player_Romus: ""The views of those extremists do not represent those of ..."*)
  - -> `[284]` (*Player_Romus: ""What exactly has your son Rico been up to in Iza, Your G..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The views of those extremists do not represent those of the throne. We have to make that clear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucita Azaro: ""The continued involvement of one Rico Toras would sugges..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly has your son Rico been up to in Iza, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Hugo Toras: ""I've already spoken to Rico. He had absolutely nothing t..."*)

### Węzeł `[285]`
Mówca: **Lucita Azaro**
> ""Unclear. This is all they've told us. The Duke of Iza might be able to clarify the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Hugo Toras: ""I told you, Duchess Azaro, I've already spoken to Rico. ..."*)

### Węzeł `[286]`
Mówca: **Hugo Toras**
> ""I've already spoken to Rico. He had absolutely nothing to do with what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Why was I not included in this conversation?""*)
  - -> `[289]` (*Player_Romus: ""What were Su Omina's activities like in the months leadi..."*)
  - -> `[296]` (*Player_Romus: ""I believe him. This has Wehlen's fingerprints all over it.""*)
  - -> `[297]` (*Player_Romus: ""How can you trust him? Of course he wouldn't admit to be..."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why was I not included in this conversation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Hugo Toras), `[286]` (Hugo Toras), `[426]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Hugo Toras: ""Because it was superfluous. Su Omina promotes Rizian val..."*)

### Węzeł `[288]`
Mówca: **Hugo Toras**
> ""Because it was superfluous. Su Omina promotes Rizian values. Terrorism is not part of their mission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""I should clarify, the group's official activities have n..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What were Su Omina's activities like in the months leading up to the attack?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Hugo Toras), `[286]` (Hugo Toras), `[426]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[290]`
Mówca: **Lucita Azaro**
> ""Nothing out of the ordinary. A few marches and a rally held at the Duke of Iza's mansion in protest of the new Dastnurist Grandsanctuary expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Hugo Toras: ""All peaceful events held to promote Rizian values. Su Om..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Proj..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Lucita Azaro: ""Nothing out of the ordinary. A few marches and a rally h..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Lucita Azaro: ""Nothing out of the ordinary. A few marches.""*)

### Węzeł `[294]`
Mówca: **Lucita Azaro**
> ""Nothing out of the ordinary. A few marches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Hugo Toras: ""All peaceful events held to promote Rizian values. Su Om..."*)

### Węzeł `[295]`
Mówca: **Hugo Toras**
> ""All peaceful events held to promote Rizian values. Su Omina is not and has never been a violent organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""I should clarify, the group's official activities have n..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe him. This has Wehlen's fingerprints all over it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Hugo Toras), `[286]` (Hugo Toras), `[426]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Hugo Toras: ""A sight more likely than a peaceful group of Rizians sud..."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you trust him? Of course he wouldn't admit to being involved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Hugo Toras), `[286]` (Hugo Toras), `[426]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Hugo Toras: ""I trust him because I trust the organization. Su Omina p..."*)

### Węzeł `[298]`
Mówca: **Hugo Toras**
> ""I trust him because I trust the organization. Su Omina promotes Rizian values. Its aims are peaceful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""I should clarify, the group's official activities have n..."*)

### Węzeł `[299]`
Mówca: **Hugo Toras**
> ""A sight more likely than a peaceful group of Rizians suddenly taking up bomb making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Lucita Azaro: ""I should clarify, the group's official activities have n..."*)

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""I should clarify, the group's official activities have never been violent. But individual members have printed leaflets calling for a more... 'creative' solution to the Wehzek problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""You know I will always support Su Omina. If I condemn th..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I will always support Su Omina. If I condemn them, I'm condemning myself.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "My uncle looked me in the eyes."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucita Azaro: ""I'll update you soon.""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "A few weeks had passed since the attack in Zille."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 3)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Let's go with Lucita's proposal. Expand our intelligence..."*)
  - -> `[182]` (*Player_Romus: ""Captain Gordion, I admire your initiative. I'll provide ..."*)
  - -> `[183]` (*Player_Romus: ""Sorry to disappoint you both, but I've decided not to fu..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player_Romus: ""The crown will not provide further assistance.""*)
  - -> `[312]` (*Player_Romus: ""I hate to disappoint both of you, but our treasury can't..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Lucita clasped her hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucita Azaro: ""Thank you, Your Majesty. I promise my department will ge..."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "Titus forcefully saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Titus Gordion: ""Thank you for your trust in the Golden Guard, sir. We wo..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hate to disappoint both of you, but our treasury can't afford either investigation.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Lucita and Titus looked at each other."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 4;
RiziaDLC.Relations_Lucita_Romance -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;
Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "Lucita scowled."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""Rest assured this will not affect my own commitment to your family's security, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player_Romus: ""It had better not, Captain Gordion.""*)
  - -> `[318]` (*Player_Romus: ""It's nothing personal.""*)
  - -> `[319]` (*Player_Romus: ""A true professional. I appreciate that.""*)

### Węzeł `[316]`
Mówca: **Narrator**
> "Titus bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Titus Gordion: ""Rest assured this will not affect my own commitment to y..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It had better not, Captain Gordion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Laurento Esquibel: ""There's still the matter of the King's public response.""*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nothing personal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Laurento Esquibel: ""There's still the matter of the King's public response.""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A true professional. I appreciate that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Laurento Esquibel: ""There's still the matter of the King's public response.""*)

### Węzeł `[320]`
Mówca: **Narrator**
> "Lucita scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""I'm expecting results, Mr. Gordion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Hugo Toras: ""And I'm expecting tact and discretion, needless to say.""*)

### Węzeł `[322]`
Mówca: **Hugo Toras**
> ""And I'm expecting tact and discretion, needless to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player_Romus: ""Don't be afraid to get your hands dirty, Titus.""*)
  - -> `[324]` (*Player_Romus: ""As am I. House Toras must appear clean in all this.""*)
  - -> `[325]` (*Player_Romus: ""Stop hassling my guard. My trust in Titus should be enou..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be afraid to get your hands dirty, Titus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As am I. House Toras must appear clean in all this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Laurento Esquibel: ""There's still the matter of the King's public response.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop hassling my guard. My trust in Titus should be enough reassurance for you both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Hugo -= 1"*)

### Węzeł `[326]`
Mówca: **Narrator**
> "Lucita and Titus looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_FundNone = true;  RiziaDLC.Diplomacy_We..."*)

### Węzeł `[327]`
Mówca: **Lucita Azaro**
> ""I see, Your Majesty. Thank you for considering my proposal nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Titus Gordion: ""Rest assured I remain as devoted to your security as eve..."*)

### Węzeł `[328]`
Mówca: **Titus Gordion**
> ""Rest assured I remain as devoted to your security as ever, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)

### Węzeł `[329]`
Mówca: **Hugo Toras**
> ""Saving money is always prudent. We don't know what lies ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Laurento Esquibel: ""You will, however, still have to draft a public response..."*)

### Węzeł `[330]`
Mówca: **Laurento Esquibel**
> ""You will, however, still have to draft a public response to Wehlen's statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player_Romus: ""Do you have any suggestions?""*)
  - -> `[332]` (*Player_Romus: ""I won't dignify their accusations with a reply.""*)
  - -> `[333]` (*Player_Romus: ""I know exactly what to say.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have any suggestions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Laurento Esquibel), `[340]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't dignify their accusations with a reply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Laurento Esquibel), `[340]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Laurento Esquibel: ""The international community will be anticipating it, You..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know exactly what to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Laurento Esquibel), `[340]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Laurento Esquibel: ""I trust you to make the diplomatically correct choice, Y..."*)

### Węzeł `[334]`
Mówca: **Laurento Esquibel**
> ""The international community will be anticipating it, Your Majesty. A lack of a response is also a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player_Romus: ""Then help me out. What do I say?""*)
  - -> `[353]` (*Player_Romus: ""All right. I'll draft the statement after this meeting.""*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina)"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""Surely you don't truly feel that way, or you wouldn't ha..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Hugo Toras: ""The group is unfairly maligned. If more people actually ..."*)

### Węzeł `[338]`
Mówca: **Hugo Toras**
> ""The group is unfairly maligned. If more people actually attended their events, they'd see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""That's the message the public needs to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[340]`
Mówca: **Laurento Esquibel**
> ""There's still the matter of the King's public response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player_Romus: ""Do you have any suggestions?""*)
  - -> `[332]` (*Player_Romus: ""I won't dignify their accusations with a reply.""*)
  - -> `[333]` (*Player_Romus: ""I know exactly what to say.""*)

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""Would it? Or would it cast unnecessary suspicions on the royal family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[342]`
Mówca: **Laurento Esquibel**
> ""If you wanted to go further, you could emphasize that Su Omina is a 'lone wolf' that does not represent the views of the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Hugo sniffed."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || R..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Laurento Esquibel: ""I suggest you tell the truth. You take Wehlen's intellig..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Laurento Esquibel: ""I suggest a boilerplate statement, expressing Rizia's co..."*)

### Węzeł `[346]`
Mówca: **Laurento Esquibel**
> ""I suggest you tell the truth. You take Wehlen's intelligence seriously and will be conducting your own investigation into the suspected perpetrators.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Laurento Esquibel: ""Emphasizing, of course, that Su Omina is a 'lone wolf' t..."*)

### Węzeł `[347]`
Mówca: **Laurento Esquibel**
> ""I trust you to make the diplomatically correct choice, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)

### Węzeł `[348]`
Mówca: **Laurento Esquibel**
> ""Emphasizing, of course, that Su Omina is a 'lone wolf' that does not represent the views of the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "Hugo sniffed."*)

### Węzeł `[349]`
Mówca: **Narrator**
> "Hugo sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Hugo Toras: ""Or express your confidence that the group is innocent. W..."*)

### Węzeł `[350]`
Mówca: **Hugo Toras**
> ""Or express your confidence that the group is innocent. Which it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Laurento Esquibel: ""I find it unwise to confirm or deny Su Omina's innocence..."*)

### Węzeł `[351]`
Mówca: **Laurento Esquibel**
> ""I suggest a boilerplate statement, expressing Rizia's condolences for the Wehzek victims and our wishes that the perpetrators be brought to justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Laurento Esquibel: ""If you wanted to go further, you could emphasize that Su..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then help me out. What do I say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true || Riz..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. I'll draft the statement after this meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Laurento Esquibel: ""I trust you to make the diplomatically correct choice, Y..."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "Hugo sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Hugo Toras: ""Or express your confidence that the group is innocent. W..."*)

### Węzeł `[355]`
Mówca: **Hugo Toras**
> ""Or express your confidence that the group is innocent. Which it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Laurento Esquibel: ""I find it unwise to confirm or deny Su Omina's innocence..."*)

### Węzeł `[356]`
Mówca: **Hugo Toras**
> ""That's the message the public needs to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""If I may, Your Grace, why have you never once thrown you..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Hugo spread his hands wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Hugo Toras: ""It would do the group no favors to have an old man like ..."*)

### Węzeł `[358]`
Mówca: **Hugo Toras**
> ""It would do the group no favors to have an old man like me in the spotlight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Hugo Toras: ""They need youth, vitality. They are the future of Rizia,..."*)

### Węzeł `[359]`
Mówca: **Hugo Toras**
> ""They need youth, vitality. They are the future of Rizia, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "He smiled warmly at Vina. My daughter looked away."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "Lucita nodded impatiently."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "Lucita nodded impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucita Azaro: ""Future or not, we have no concrete proof Su Omina was be..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Laurento Esquibel: ""I would also advise you to include an apology for your w..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Laurento Esquibel: ""I would advise you not to confirm or deny Su Omina's gui..."*)

### Węzeł `[367]`
Mówca: **Laurento Esquibel**
> ""I would also advise you to include an apology for your words in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Laurento Esquibel: ""It seems the next steps are quite clear, or was there an..."*)

### Węzeł `[368]`
Mówca: **Laurento Esquibel**
> ""I would advise you not to confirm or deny Su Omina's guilt at this time. Not until more is known.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "Hugo sniffed."*)

### Węzeł `[369]`
Mówca: **Laurento Esquibel**
> ""I find it unwise to confirm or deny Su Omina's innocence before more information is known. But I'll leave it to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Laurento Esquibel: ""And, well, do consider including an apology for your spe..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Laurento Esquibel: ""It seems the next steps are quite clear, or was there an..."*)

### Węzeł `[373]`
Mówca: **Laurento Esquibel**
> ""And, well, do consider including an apology for your speech in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Laurento Esquibel: ""It seems the next steps are quite clear, or was there an..."*)

### Węzeł `[374]`
Mówca: **Narrator**
> "Hugo sniffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Laurento Esquibel: ""It seems the next steps are quite clear, or was there an..."*)

### Węzeł `[375]`
Mówca: **Narrator**
> "I picked up a pen and began drafting my response to Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit = tru..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");
AddConversant("Vina Toras");
AddConversant("Hugo Toras"); AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");
AddConversant("Vina Toras");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Titus insisted on sweeping the room before Vina and I sat..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");
AddConversant("Hugo Toras"); AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Titus insisted on sweeping the room before I sat down. Hu..."*)

### Węzeł `[378]`
Mówca: **Lucita Azaro**
> ""Gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "Everyone automatically fell silent as Lucita strode throu..."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "Everyone automatically fell silent as Lucita strode through the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "She was dressed in her army major's blazer, with two star..."*)

### Węzeł `[380]`
Mówca: **Narrator**
> "She was dressed in her army major's blazer, with two stars prominently displayed above her right breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "Now that crisis had struck, her entire bearing had change..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Now that crisis had struck, her entire bearing had change..."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "Now that crisis had struck, her entire bearing had changed. She had a commanding air about her that recalled her father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Thank you for joining us, Duchess Azaro. Can you update ..."*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[21]` (*Player_Romus: ""I need a status report. Now.""*)
  - -> `[20]` (*Player_Romus: ""At ease, Duchess Azaro.""*)

### Węzeł `[385]`
Mówca: **Narrator**
> "Now that crisis had struck, her entire bearing had changed. She had a commanding air about her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[21]` (*Player_Romus: ""I need a status report. Now.""*)
  - -> `[20]` (*Player_Romus: ""At ease, Duchess Azaro.""*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""We're not all gentlemen. Do not forget the presence of t..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Narrator**
> "Lucita greeted Vina with an impatient half-bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Lucita Azaro: ""A pleasure as usual, Your Highness. Now, let's not waste..."*)

### Węzeł `[390]`
Mówca: **Lucita Azaro**
> ""A pleasure as usual, Your Highness. Now, let's not waste any more time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Still standing, she picked a dossier up off the table and..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit = true; RiziaDLCSupport.Reports_Turn03_Jales_FriendshipDayVigil = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Bronaz_BeatriceVisit"] = true;
Variable["RiziaDLCSupport.Reports_Turn03_Jales_FriendshipDayVigil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_BeatriceVisit = true;"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_RH_BeatriceVisit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_BeatriceVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleSecurityDebriefFinished = true; RiziaDLC.Di..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == ..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""Now that you have the funding, I'd like your help with a..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to find out exactly how my father died.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "She froze in place."*)

### Węzeł `[397]`
Mówca: **Narrator**
> "She shook my hand firmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucita Azaro: ""I'll update you soon.""*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually... never mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "She gave me a puzzled look."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "She gave me a puzzled look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Lucita Azaro: ""Very well, Your Majesty. I hope you know you can come to..."*)

### Węzeł `[400]`
Mówca: **Lucita Azaro**
> ""Very well, Your Majesty. I hope you know you can come to me with any request. Or anything that's on your mind at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "She reached out and gave me a handshake. Her hand lingere..."*)

### Węzeł `[401]`
Mówca: **Narrator**
> "She froze in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Lucita Azaro: ""It was a heart attack. He was an old man.""*)

### Węzeł `[402]`
Mówca: **Lucita Azaro**
> ""It was a heart attack. He was an old man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Player_Romus: ""I have reason to believe the causes were less than natur..."*)
  - -> `[407]` (*Player_Romus: ""Don't question me. Just open an investigation. Discreetly.""*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Titus Gordion");
// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Titus Gordion");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "The others began filing out of the room. Lucita stayed be..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The others began filing out of the room. Titus stayed beh..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");
RemoveConversant("Lucita Azaro");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "The others filed out of the room. Hugo stayed behind."*)

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have reason to believe the causes were less than natural.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[402]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Lucita Azaro: ""I see.""*)

### Węzeł `[407]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't question me. Just open an investigation. Discreetly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[402]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Lucita Azaro: ""Sorry, Your Majesty. I will.""*)

### Węzeł `[408]`
Mówca: **Lucita Azaro**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucita Azaro: ""It won't be easy with the Golden Guard around, but I can..."*)

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""It won't be easy with the Golden Guard around, but I can commission a small team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Lucita Azaro: ""Am I to assume everyone who was in the Palace the day of..."*)

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""Sorry, Your Majesty. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucita Azaro: ""It won't be easy with the Golden Guard around, but I can..."*)

### Węzeł `[411]`
Mówca: **Lucita Azaro**
> ""Am I to assume everyone who was in the Palace the day of his death is a suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player_Romus: ""Almost everyone. Leave my butler out of it.""*)
  - -> `[413]` (*Player_Romus: ""Yes. Titus, Hugo, my mother and the Grand Wiseman. And P..."*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Almost everyone. Leave my butler out of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[411]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigate..."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Titus, Hugo, my mother and the Grand Wiseman. And Pabel, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[411]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigate..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel = true;
RiziaDLC.PoisonInvestigator_Lucita = true;
RiziaDLC.InvestigatePoisoning_NoPabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderNoPabel"] = true;
Variable["RiziaDLC.PoisonInvestigator_Lucita"] = true;
Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita = true;"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Security_LucitaInvestigateMurderEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita = true;"*)

### Węzeł `[416]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Lucita Azaro: ""I appreciate your trust in me. Consider it handled.""*)

### Węzeł `[417]`
Mówca: **Lucita Azaro**
> ""I appreciate your trust in me. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "She reached out and gave me a handshake. Her hand lingere..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "I picked up a pen and began drafting my response to Wehlen."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "I picked up a pen and began drafting my response to Wehlen."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "I picked up a pen and began drafting my response to Wehlen."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Hugo -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Laurento Esquibel: ""There's still the matter of the King's public response.""*)

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""Queen Lyza always said monarchy was incompatible with nationalism. 'The crown knows no borders.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""Yes, Rico has no right using the Toras name to serve his..."*)
  - -> `[47]` (*Player_Romus: ""It's true. National identity should be secondary to one'..."*)
  - -> `[48]` (*Player_Romus: ""That's rubbish. The monarchy and the nation of Rizia can..."*)
  - -> `[49]` (*Player_Romus: ""Please don't change the subject, Vina.""*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course they would say that. It's clear that President Smolak was behind this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Narrator), `[282]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Hugo Toras: ""I agree.""*)

### Węzeł `[425]`
Mówca: **Hugo Toras**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Hugo Toras: ""Besides, I've already spoken to Rico. He had absolutely ..."*)

### Węzeł `[426]`
Mówca: **Hugo Toras**
> ""Besides, I've already spoken to Rico. He had absolutely nothing to do with what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""Why was I not included in this conversation?""*)
  - -> `[289]` (*Player_Romus: ""What were Su Omina's activities like in the months leadi..."*)
  - -> `[296]` (*Player_Romus: ""I believe him. This has Wehlen's fingerprints all over it.""*)
  - -> `[297]` (*Player_Romus: ""How can you trust him? Of course he wouldn't admit to be..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == ..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Titus Gordion: ""Is this in regard the murder investigation you previousl..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_SecurityTitus_DiscussPossibleMurder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Titus Gordion: ""Yes, sir?""*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. I believe that there's reason to suspect that the late king died under questionable circumstances. And I need you to dig up everything there is to know about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "Eyes wide, Titus hushed his voice, ensuring our conversat..."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "Eyes wide, Titus hushed his voice, ensuring our conversation was confidential."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Titus Gordion: ""You're not the only one troubled by your father's untime..."*)

### Węzeł `[432]`
Mówca: **Titus Gordion**
> ""If there's evidence of wrongdoing, should we regard everyone in the palace at the time as a potential suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""Almost everyone. Leave my butler out of it.""*)
  - -> `[251]` (*Player_Romus: ""Yes. Hugo, the Grand Wiseman, my mother, Lucita Azaro. A..."*)

### Węzeł `[433]`
Mówca: **Titus Gordion**
> ""You're not the only one troubled by your father's untimely death. As someone present on that fateful night, it's reassuring to know you've taken an interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Titus Gordion: ""In the event of incriminating evidence, do we need to tr..."*)

### Węzeł `[434]`
Mówca: **Titus Gordion**
> ""In the event of incriminating evidence, do we need to treat anyone who was in the palace as a potential suspect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""Almost everyone. Leave my butler out of it.""*)
  - -> `[251]` (*Player_Romus: ""Yes. Hugo, the Grand Wiseman, my mother, Lucita Azaro. A..."*)

### Węzeł `[435]`
Mówca: **Titus Gordion**
> ""Yes, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Player_Romus: ""I'd like to know exactly how my father died. I have reas..."*)
  - -> `[437]` (*Player_Romus: ""I'd like you to initiate a murder inquiry, with a specif..."*)
  - -> `[438]` (*Player_Romus: ""I believe that there's reason to suspect that the late k..."*)

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to know exactly how my father died. I have reason to believe that his death was no accident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Titus froze in place. He spoke in a low voice."*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like you to initiate a murder inquiry, with a specific focus on the circumstances surrounding my father's demise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Titus eyes grew wide. He lowered the volume of his voice ..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe that there's reason to suspect that the late king died under questionable circumstances. And I need you to dig up everything there is to know about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "Eyes wide, Titus hushed his voice, ensuring our conversat..."*)

### Węzeł `[439]`
Mówca: **Titus Gordion**
> ""In any case, expect an update soon on the progress on Su Omina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Titus gave a dutiful bow and left the room."*)

### Węzeł `[440]`
Mówca: **Hugo Toras**
> ""Excuse me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Hugo Toras: ""Captain Gordion. I am all for the expansion of the Golde..."*)

### Węzeł `[441]`
Mówca: **Hugo Toras**
> ""Captain Gordion. I am all for the expansion of the Golden Guard, but not if you insist on using it to chase a dead end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Titus Gordion: ""With respect, sir, we don't know whether it's a dead end..."*)

### Węzeł `[442]`
Mówca: **Lucita Azaro**
> ""Perhaps so, Captain Gordion, but the attack took place in Wehlen. Any resources that go towards investigating it should be allocated there, not within Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "She, Hugo and Titus glared at each other."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleSecurityDebriefFinished = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 5`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleSecurityDebriefFinished"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub = true;"*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The crown will not provide further assistance.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Lucita and Titus looked at each other."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_FundNone = true; 
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;
RiziaDLC.Relations_Lucita_Romance -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Security_FundNone"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;
Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Lucita Azaro: ""I see, Your Majesty. Thank you for considering my propos..."*)

### Węzeł `[446]`
Mówca: **Titus Gordion**
> ""Your Majesty, you recently conveyed your wish to strengthen our ranks and allow us to assume additional duties. This incident would serve as an excellent opportunity to demonstrate our capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Narrator: "Lucita spoke up sweetly."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Titus Gordion: ""Your Majesty, you recently conveyed your wish to strengt..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Titus Gordion: ""Your Majesty, you recently conveyed your apprehension ov..."*)

### Węzeł `[450]`
Mówca: **Lucita Azaro**
> ""I'm sorry, but why wasn't I privy to this discussion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucita Azaro: ""The expansion of the Golden Guard is a security-related ..."*)

### Węzeł `[451]`
Mówca: **Lucita Azaro**
> ""The expansion of the Golden Guard is a security-related issue, which, as Councilor of War and Internal Security, falls under my purview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""Titus and I spoke about it recently. I've been meaning t..."*)
  - -> `[454]` (*Player_Romus: ""It slipped my mind.""*)
  - -> `[453]` (*Player_Romus: ""It's not your place to question whom I talk to and when...."*)
  - -> `[452]` (*Player_Romus: ""Our discussion wasn't intentionally concealed from you, ..."*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our discussion wasn't intentionally concealed from you, nor was it pre-planned. Forgive me for not informing you sooner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[451]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Lucita Azaro: ""All well and good, Your Majesty, but the fact remains th..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your place to question whom I talk to and when. If there's information worth knowing, I'll ensure it's shared when I deem it appropriate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[451]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Lucita scowled."*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It slipped my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[451]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Lucita Azaro: ""Uh-huh.""*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus and I spoke about it recently. I've been meaning to bring it up with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[451]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Lucita Azaro: ""Uh-huh.""*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Lucita Azaro: ""Now that the subject has been broached, I will gently po..."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "Lucita scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1;"*)

### Węzeł `[458]`
Mówca: **Lucita Azaro**
> ""Uh-huh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Titus Gordion: ""Ma'am, it's important to recognize the historical signif..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Titus Gordion: ""I must say... last we spoke, You Majesty, I was under th..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Titus bowed his head."*)

### Węzeł `[462]`
Mówca: **Titus Gordion**
> ""I must say... last we spoke, You Majesty, I was under the impression that the Golden Guard had your full support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Titus Gordion: ""Our conversation left me with quite optimistic expectati..."*)

### Węzeł `[463]`
Mówca: **Titus Gordion**
> ""Our conversation left me with quite optimistic expectations, and it's disappointing that they won't be coming to fruition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Titus Gordion: ""I hope this isn't indicative of future commitments.""*)

### Węzeł `[464]`
Mówca: **Titus Gordion**
> ""I hope this isn't indicative of future commitments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Player_Romus: ""And you'll continue to have my full support. I simply ag..."*)
  - -> `[465]` (*Player_Romus: ""Enough with your baseless insinuations. Circumstances ch..."*)
  - -> `[466]` (*Player_Romus: ""I respect you as my guardsman, Captain, but this is an i..."*)
  - -> `[467]` (*Player_Romus: ""Sometimes even the best-laid plans can take unexpected t..."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with your baseless insinuations. Circumstances change, and I must make decisions in the best interests of Rizia, not those of the Golden Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 2;"*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect you as my guardsman, Captain, but this is an internationally sensitive incident. We've got to treat it with the seriousness it deserves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 2;"*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sometimes even the best-laid plans can take unexpected turns. I'll try to make it up to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'll continue to have my full support. I simply agree with Duchess Azaro on the course of how this investigation should proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Titus bowed his head."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Titus Gordion: ""However, I must admit my disappointment, considering you..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""Saving money is always prudent. We don't know what lies ..."*)

### Węzeł `[473]`
Mówca: **Titus Gordion**
> ""However, I must admit my disappointment, considering your previous expression of full support for the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Player_Romus: ""And you'll continue to have my full support. It's just t..."*)
  - -> `[474]` (*Player_Romus: ""My support for the Golden Guard remains as steadfast as ..."*)
  - -> `[475]` (*Player_Romus: ""And I must admit my disappointment in you, Captain. You,..."*)
  - -> `[476]` (*Player_Romus: ""Life has a way of throwing surprises into our best-laid ..."*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My support for the Golden Guard remains as steadfast as ever, and your insinuations are unfounded. Circumstances change, and decisions must be made in the best interest of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I must admit my disappointment in you, Captain. You, of all people, should know your place and respect the decisions made for the greater good of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Life has a way of throwing surprises into our best-laid plans. I'll try to make it up to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""Saving money is always prudent. We don't know what lies ..."*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'll continue to have my full support. It's just that I share Duchess Azaro's perspective on the way this investigation ought to move forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[473]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""Saving money is always prudent. We don't know what lies ..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Hugo Toras: ""Saving money is always prudent. We don't know what lies ..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.SecurityTitus_SupportGoldenGuard == true"*)
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.SecurityTitus_SupportGoldenGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Lucita Azaro: ""Very well. But in the future, please include me in confi..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.SecurityTitus_SupportGoldenGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.SecurityTitus_SupportGoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""I'm expecting results, Mr. Gordion.""*)

### Węzeł `[482]`
Mówca: **Lucita Azaro**
> ""Very well. But in the future, please include me in confidential internal security meetings. I'd appreciate being a part of the conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Player_Romus: ""Yes. Next time I'll be sure you're included. This was an..."*)
  - -> `[484]` (*Player_Romus: ""I'll consider it.""*)
  - -> `[483]` (*Player_Romus: ""You'll be included in such meetings if I deem it necessa..."*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll be included in such meetings if I deem it necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Narrator: "Lucita released an exasperated sigh."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll consider it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "Lucita let out a sigh of exasperation."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Next time I'll be sure you're included. This was an isolated incident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Lucita Azaro: ""Thank you, Your Majesty. In any case...""*)

### Węzeł `[486]`
Mówca: **Narrator**
> "Lucita released an exasperated sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Lucita Azaro: ""Nevertheless...""*)

### Węzeł `[487]`
Mówca: **Lucita Azaro**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1;"*)

### Węzeł `[488]`
Mówca: **Lucita Azaro**
> ""Thank you, Your Majesty. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""I'm expecting results, Mr. Gordion.""*)

### Węzeł `[489]`
Mówca: **Narrator**
> "Lucita let out a sigh of exasperation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Lucita Azaro: ""Anyway...""*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Romance -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Lucita Azaro: ""I'm expecting results, Mr. Gordion.""*)

### Węzeł `[491]`
Mówca: **Lucita Azaro**
> ""Nevertheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Romance -= 1;"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_MaveNortusIntelHub"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[493]`
Mówca: **Narrator**
> "Lucita gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Lucita Azaro: ""What you call 'red tape,' I call accountability. You are..."*)

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""What you call 'red tape,' I call accountability. You are asking for permission to act outside the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Titus Gordion: ""I am asking for permission to become a more agile, flexi..."*)

### Węzeł `[495]`
Mówca: **Titus Gordion**
> ""I am asking for permission to become a more agile, flexible arm of the law than any division currently in operation. This will benefit us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""Good point. Before giving more funding to foreign intell..."*)
  - -> `[89]` (*Player_Romus: ""What kind of investigations did you have in mind, Captain?""*)
  - -> `[90]` (*Player_Romus: ""Can you not make more efficient use of the funding you a..."*)
  - -> `[91]` (*Player_Romus: ""We need to find out who's behind this bombing. Can the G..."*)

### Węzeł `[496]`
Mówca: **Titus Gordion**
> ""With a full-fledged division under my command, I could also easily send a team to Iza to confirm or rule out Su Omina's involvement in what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Lucita's jaw dropped. Hugo eyed Titus uneasily."*)

### Węzeł `[497]`
Mówca: **Lucita Azaro**
> ""All well and good, Your Majesty, but the fact remains that national security is not Captain Gordion's area of expertise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Titus Gordion: ""Ma'am, it's important to recognize the historical signif..."*)

### Węzeł `[498]`
Mówca: **Lucita Azaro**
> ""Now that the subject has been broached, I will gently point out that national security is not Captain Gordion's area of expertise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Titus Gordion: ""Ma'am, it's important to recognize the historical signif..."*)

### Węzeł `[499]`
Mówca: **Titus Gordion**
> ""Your Majesty, you recently conveyed your apprehension over re-expanding the Golden Guard's ranks and duties. But this incident would serve as an excellent opportunity for us to demonstrate our capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Narrator: "Lucita spoke up sweetly."*)

### Węzeł `[500]`
Mówca: **Narrator**
> "Lucita spoke up sweetly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Lucita Azaro: ""I'm sorry, but why wasn't I privy to this discussion?""*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.GoldenGuardUpdate = "Under the reign of King..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.GoldenGuardUpdate = "Under the reign of King Romus Toras, the Golden Guard was enlarged into a division-sized unit and given expanded duties."`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.GoldenGuardUpdate"] ="Under the reign of King Romus Toras, the Golden Guard was enlarged into a division-sized unit and given expanded duties.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Laurento Esquibel: ""Excuse me, Your Majesty. My fellow councilors. These sta..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "She nodded."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Titus nodded seriously."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Titus bowed his head."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Getting an emergency briefing after a bombing attack", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Getting an emergency briefing after a bombing attack","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");"*)
