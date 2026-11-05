# Rizia/Prologue

- **ID konwersacji:** `303`
- **StoryPack:** `Rizia`
- **Tura:** `Prologue`
- **Lokalizacja pliku:** `Rizia/Prologue/303_Prologue.md`
- **Liczba węzłów dialogowych:** 373
- **Liczba wyborów gracza:** 151

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Studied`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_Support_Total`
- `RiziaDLC.Army_Unit_Tank_Total`
- `RiziaDLC.Authority_Modifier_BaseMonarchRomus`
- `RiziaDLC.Budget_Modifier_RizianGoldIndustry`
- `RiziaDLC.Country_DrugTrade`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Country_Tourism`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_BaseEnergy`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Prologue_BetrayedAxel`
- `RiziaDLC.Prologue_DadLetter`
- `RiziaDLC.Prologue_DadLetter_ThrowAway`
- `RiziaDLC.Prologue_DistantAsDad`
- `RiziaDLC.Prologue_EasyLife`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_Focus_EnergyIndustry`
- `RiziaDLC.Prologue_Focus_PRCampaign`
- `RiziaDLC.Prologue_Focus_SecurityCouncil`
- `RiziaDLC.Prologue_Focus_TreasuryFinances`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_HardLife`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_InBoatAccident`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_MetAxel`
- `RiziaDLC.Prologue_Monqiz_Arrests`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Monqiz_Rebuild`
- `RiziaDLC.Prologue_NormalLife`
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Prologue_Summer_Court`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Prologue_Summer_Zille`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Resources_Military_Ships`
- `RiziaDLCSupport.Journal_Prologue_War_Stop`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"1905\|Monqiz\|Kingdom of Rizia"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_princebirth"); ;` | `[44]` **Player_Romus**: "It was your birthright."<br>`[45]` **Player_Romus**: "It was your burden."<br>*(oraz 1 innych odgałęzień)* |
| `[4]` | **"...quickly became close friends."** | `[60]` **Narrator**: "Life in Porte Drazon was less ex..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Making a lifelong friend in the palace g...`<br>`Variable["RiziaDLC.Prologue_Relations_PabelFriend"] = tru...` | `[366]` **Narrator**: "You were cut off from the world ..." |
| `[5]` | **"...enjoyed bossing him around."** | `[60]` **Narrator**: "Life in Porte Drazon was less ex..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Pushing the groundskeeper’s kid around",...`<br>`Variable["RiziaDLC.Prologue_Relations_PabelBoss"] = true;...` | `[366]` **Narrator**: "You were cut off from the world ..." |
| `[6]` | **"1930\|June 20\|Monqiz"** | `[14]` **Player_Romus**: "...focused on finding and punish..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Wedded to Princess Lena of the Kingdom o...`<br>`PrologueImage("pe_royalwedding");` | `[7]` **Player_Romus**: "You bowed."<br>`[150]` **Player_Romus**: "You kissed her hand."<br>*(oraz 1 innych odgałęzień)* |
| `[7]` | **"You bowed."** | `[6]` **Narrator**: "Your region came to see you as a..."<br>`[148]` **Narrator**: "You were a constant newspaper fi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "King Valero told you that he had..." |
| `[8]` | **"You demanded to know what was going on."** | `[6]` **Narrator**: "Your region came to see you as a..."<br>`[148]` **Narrator**: "You were a constant newspaper fi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "King Valero told you that he had..." |
| `[10]` | **"He was right."** | `[9]` **Narrator**: "King Valero told you that he had..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_LovedWife"] = true`<br>`Variable["RiziaDLC.Prologue_LovedWife"] = true; EnableJou...`<br>*(+2 skryptów)* | `[17]` **Narrator**: "You and Lena began having hours-..." |
| `[11]` | **"He was wrong."** | `[9]` **Narrator**: "King Valero told you that he had..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_Marriage_DontLove"); EnableJ...`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[12]` **Narrator**: "You and Lena went on a few dates..." |
| `[12]` | **"1932\|March 1\|A Family Man"** | `[11]` **Player_Romus**: "He was wrong." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Player_Romus**: "...had a string of affairs."<br>`[155]` **Player_Romus**: "...tried your best to be a good ..."<br>*(oraz 1 innych odgałęzień)* |
| `[13]` | **"1927\|Porte Drazon\|A Changed Country"** | `[145]` **Player_Romus**: "You wondered how King Valero cou..."<br>`[146]` **Player_Romus**: "You thanked him for restoring or..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Hanging");`<br>`PrologueImage("pe_hanging");` | `[14]` **Player_Romus**: "...focused on finding and punish..."<br>`[15]` **Player_Romus**: "...largely ignored your duties a..."<br>*(oraz 1 innych odgałęzień)* |
| `[14]` | **"...focused on finding and punishing the remaining traitors to the throne."** | `[13]` **Narrator**: "The uprising had other consequen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] = true; Vari...` | `[6]` **Narrator**: "Your region came to see you as a..." |
| `[15]` | **"...largely ignored your duties and lived a life of leisure."** | `[13]` **Narrator**: "The uprising had other consequen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] = true; ...` | `[148]` **Narrator**: "You were a constant newspaper fi..." |
| `[16]` | **"...did your best to help your region rebuild."** | `[13]` **Narrator**: "The uprising had other consequen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] = true; Vari...` | `[149]` **Narrator**: "Valenqiris came to see you as a ..." |
| `[17]` | **"1932\|March 1\|A Family Man"** | `[10]` **Player_Romus**: "He was right." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Player_Romus**: "...that your royal duties left y..."<br>`[153]` **Player_Romus**: "...that your commitment to being..."<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **"But it was too late."** | `[175]` **Narrator**: "You were putting your clothes ba..."<br>`[180]` **Narrator**: "You were in your office when you..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | `PrologueImage("pe_mourning");` | `[21]` **Narrator**: "You mourned for a while.  But yo..." |
| `[20]` | **"If anything, you became less of a believer."** | `[19]` **Narrator**: "You were devastated.  After the ..."<br>`[21]` **Narrator**: "You mourned for a while.  But yo..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[22]` **Narrator**: "Meanwhile, the situation in the ..." |
| `[22]` | **"1946\|August\|Porte Drazon"** | `[20]` **Player_Romus**: "If anything, you became less of ..."<br>`[332]` **Player_Romus**: "The world seemed dull and meanin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("SuOmina2");`<br>`PrologueImage("pe_suomina2"); ;` | `[187]` **Player_Romus**: "You wondered what the country wa..."<br>`[23]` **Player_Romus**: "You reasoned the King had brough..."<br>*(oraz 2 innych odgałęzień)* |
| `[23]` | **"You reasoned the King had brought his troubles on himself."** | `[22]` **Narrator**: "Meanwhile, the situation in the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "Even with Hugo advising him as G..." |
| `[24]` | **"1948\|October\|Porte Drazon"** | `[322]` **Player_Romus**: "...enforcing internal security a..."<br>`[323]` **Player_Romus**: "...increasing gold extraction an..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player_Romus**: "You accepted."<br>`[216]` **Player_Romus**: "You declined." |
| `[25]` | **"You accepted."** | `[24]` **Narrator**: "Outsiders also took notice of th..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("PalesVisit");`<br>`PrologueImage("pe_palesvisit"); ;`<br>*(+1 skryptów)* | `[26]` **Narrator**: "It was your first time in Pales ..." |
| `[26]` | **"1948\|October 5\|Pales\|Confrontations"** | `[25]` **Player_Romus**: "You accepted." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Player_Romus**: "...told him that would only be p..."<br>`[28]` **Player_Romus**: "...said you were looking forward..."<br>*(oraz 2 innych odgałęzień)* |
| `[27]` | **"...told him that would only be possible once Pales rejoined Rizia, where it belonged."** | `[26]` **Narrator**: "It was your first time in Pales ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_HostileToPales"] = true; Vari...` | `[30]` **Narrator**: "The duke was taken aback and ord..." |
| `[28]` | **"...said you were looking forward to putting the past behind you."** | `[26]` **Narrator**: "It was your first time in Pales ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_FriendlyToPales"] = true; Var...` | `[31]` **Narrator**: "The duke was satisfied with your..." |
| `[29]` | **"...agreed that a thaw between Rizia and Pales could be lucrative on both sides."** | `[26]` **Narrator**: "It was your first time in Pales ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_FriendlyToPales"] = true; Var...` | `[31]` **Narrator**: "The duke was satisfied with your..." |
| `[33]` | **"You rushed to see him."** | `[32]` **Narrator**: "He'd gone straight to bed after ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_DadLetter"] = false; EnableJo...`<br>`AdvanceTimeline();` | `[35]` **Narrator**: "Your father looked pale as a gho..." |
| `[34]` | **"You stayed where you were."** | `[32]` **Narrator**: "He'd gone straight to bed after ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_DadLetter"] = true; EnableJou...`<br>`AdvanceTimeline();` | `[36]` **Narrator**: "The next day, King Valero Toras ..." |
| `[35]` | **"1949\|November 18\|Porte Drazon"** | `[33]` **Player_Romus**: "You rushed to see him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player_Romus**: "He closed his eyes." |
| `[36]` | **"1949\|November 18\|Porte Drazon"** | `[34]` **Player_Romus**: "You stayed where you were." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player_Romus**: "His last words." |
| `[37]` | **"He closed his eyes."** | `[35]` **Narrator**: "Your father looked pale as a gho..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_FatherLastWords_Hear");` | `[40]` **Narrator**: "Only after his funeral, gathered..." |
| `[38]` | **"His last words."** | `[36]` **Narrator**: "The next day, King Valero Toras ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "In the letter, he warned you not..." |
| `[41]` | **"You fought back tears."** | `[39]` **Narrator**: "In the letter, he warned you not..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] = false...` | `[40]` **Narrator**: "Only after his funeral, gathered..." |
| `[42]` | **"Now, it was finally here."** | `[40]` **Narrator**: "Only after his funeral, gathered..." | *Brak (Dostępna bezwarunkowo)* | `UnlockAchievement("RiziaPrologue_Finish");`<br>`PlayLoopedMusic("R_MainTheme","R_MainTheme_Loop");`<br>*(+3 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[43]` | **"You threw it away."** | `[39]` **Narrator**: "In the letter, he warned you not..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] = true;...` | `[40]` **Narrator**: "Only after his funeral, gathered..." |
| `[44]` | **"It was your birthright."** | `[3]` **Narrator**: "You opened your eyes to this rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "From a young age, you knew you w..." |
| `[45]` | **"It was your burden."** | `[3]` **Narrator**: "You opened your eyes to this rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "From a young age, you knew you w..." |
| `[46]` | **"It was your calling."** | `[3]` **Narrator**: "You opened your eyes to this rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "From a young age, you knew you w..." |
| `[48]` | **"...visited your mother's common-born family at their home by the Zille harbor."** | `[47]` **Narrator**: "From a young age, you knew you w..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Visiting their common-born family","Fami...`<br>`Variable["RiziaDLC.Prologue_Summer_Zille"] = true; Variab...` | `[53]` **Narrator**: "Your grandparents were fisherpeo..." |
| `[49]` | **"...stayed with the Queen at the royal residence in Porte Drazon."** | `[47]` **Narrator**: "From a young age, you knew you w..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Spending summers with Queen Lyza","Royal...`<br>`Variable["RiziaDLC.Prologue_Summer_Court"] = true; Enable...` | `[52]` **Narrator**: "You were fascinated by the splen..." |
| `[50]` | **"...went hunting with your father's brother Hugo in the forests of Brenas."** | `[47]` **Narrator**: "From a young age, you knew you w..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Hunting with Uncle Hugo","forest","Brena...`<br>`Variable["RiziaDLC.Prologue_Summer_Hugo"] = true; Variabl...` | `[51]` **Narrator**: "Your uncle taught you more than ..." |
| `[54]` | **"1918\|January 28\|Porte Drazon\|A New King"** | `[68]` **Player_Romus**: "Every autumn, you returned home ..."<br>`[313]` **Player_Romus**: "It felt good to have caring rela..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Player_Romus**: "There was a new king to crown." |
| `[55]` | **"...asked him about the rumors."** | `[312]` **Narrator**: "You remember two things about Ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "Your father laughed and told you..." |
| `[56]` | **"...didn't mention either."** | `[312]` **Narrator**: "You remember two things about Ki..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[60]` **Narrator**: "Life in Porte Drazon was less ex..." |
| `[59]` | **"You had your doubts."** | `[57]` **Narrator**: "Your father laughed and told you..."<br>`[58]` **Narrator**: "Your father laughed and told you..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[60]` **Narrator**: "Life in Porte Drazon was less ex..." |
| `[60]` | **"1920"** | `[56]` **Player_Romus**: "...didn't mention either."<br>`[59]` **Player_Romus**: "You had your doubts."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_children_playing"); ;` | `[4]` **Player_Romus**: "...quickly became close friends."<br>`[5]` **Player_Romus**: "...enjoyed bossing him around."<br>*(oraz 1 innych odgałęzień)* |
| `[61]` | **"...didn't have much to do with each other."** | `[60]` **Narrator**: "Life in Porte Drazon was less ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Narrator**: "You were cut off from the world ..." |
| `[62]` | **"1923\|September"** | `[367]` **Player_Romus**: "…you desired an easy life, one w..."<br>`[368]` **Player_Romus**: "…your royal privilege came with ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_innercircle");` | `[63]` **Player_Romus**: "...that you would love to join."<br>`[64]` **Player_Romus**: "...to go to university instead."<br>*(oraz 1 innych odgałęzień)* |
| `[63]` | **"...that you would love to join."** | `[62]` **Narrator**: "When you came of age, your fathe..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Stepping into the Royal Council as the k...`<br>`Variable["RiziaDLC.Prologue_StayedOnCouncil"] = true; Var...`<br>*(+1 skryptów)* | `[66]` **Narrator**: "The council members took you und..." |
| `[64]` | **"...to go to university instead."** | `[62]` **Narrator**: "When you came of age, your fathe..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Studied"] = true; Variable["R...`<br>`AdvanceTimeline();` | `[67]` **Narrator**: "At the prestigious University of..." |
| `[65]` | **"...to join the military instead."** | `[62]` **Narrator**: "When you came of age, your fathe..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_JoinedMilitary"] = true; Vari...`<br>`AdvanceTimeline();` | `[76]` **Narrator**: "At the prestigious Camp Domus ac..." |
| `[68]` | **"Every autumn, you returned home a little wiser."** | `[51]` **Narrator**: "Your uncle taught you more than ..."<br>`[52]` **Narrator**: "You were fascinated by the splen..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[54]` **Narrator**: "When Queen Lyza died, the whole ..." |
| `[72]` | **"You believed him."** | `[57]` **Narrator**: "Your father laughed and told you..."<br>`[58]` **Narrator**: "Your father laughed and told you..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[60]` **Narrator**: "Life in Porte Drazon was less ex..." |
| `[73]` | **"...thought it was a lost cause."** | `[66]` **Narrator**: "The council members took you und..."<br>`[67]` **Narrator**: "At the prestigious University of..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("WarSpeech");`<br>`PrologueImage("pe_pales_war_begins");` | `[77]` **Narrator**: "As you continued to serve on the..."<br>`[87]` **Narrator**: "As you continued your studies, t..."<br>*(oraz 1 innych odgałęzień)* |
| `[74]` | **"...agreed that it was time to reconquer the territory."** | `[66]` **Narrator**: "The council members took you und..."<br>`[67]` **Narrator**: "At the prestigious University of..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("WarSpeech");`<br>`PrologueImage("pe_pales_war_begins");` | `[77]` **Narrator**: "As you continued to serve on the..."<br>`[87]` **Narrator**: "As you continued your studies, t..."<br>*(oraz 1 innych odgałęzień)* |
| `[75]` | **"...didn't have an opinion either way."** | `[66]` **Narrator**: "The council members took you und..."<br>`[67]` **Narrator**: "At the prestigious University of..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("WarSpeech");`<br>`PrologueImage("pe_pales_war_begins");` | `[77]` **Narrator**: "As you continued to serve on the..."<br>`[87]` **Narrator**: "As you continued your studies, t..."<br>*(oraz 1 innych odgałęzień)* |
| `[77]` | **"1925\|War and Uncertainty"** | `[73]` **Player_Romus**: "...thought it was a lost cause."<br>`[74]` **Player_Romus**: "...agreed that it was time to re..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | *Brak zmian stanu* | `[89]` **Player_Romus**: "...asked your father to stop the..."<br>`[90]` **Player_Romus**: "...demanded that he crack down o..."<br>*(oraz 1 innych odgałęzień)* |
| `[87]` | **"1925\|War and Uncertainty"** | `[73]` **Player_Romus**: "...thought it was a lost cause."<br>`[74]` **Player_Romus**: "...agreed that it was time to re..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_Studied"] == true`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | *Brak zmian stanu* | `[89]` **Player_Romus**: "...asked your father to stop the..."<br>`[90]` **Player_Romus**: "...demanded that he crack down o..."<br>*(oraz 1 innych odgałęzień)* |
| `[88]` | **"1925\|War and Uncertainty"** | `[73]` **Player_Romus**: "...thought it was a lost cause."<br>`[74]` **Player_Romus**: "...agreed that it was time to re..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | *Brak zmian stanu* | `[89]` **Player_Romus**: "...asked your father to stop the..."<br>`[90]` **Player_Romus**: "...demanded that he crack down o..."<br>*(oraz 1 innych odgałęzień)* |
| `[89]` | **"...asked your father to stop the bloodshed."** | `[77]` **Narrator**: "As you continued to serve on the..."<br>`[87]` **Narrator**: "As you continued your studies, t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[92]` **Narrator**: "Some troops were withdrawn, but ..."<br>`[108]` **Narrator**: "Some troops were withdrawn, but ..."<br>*(oraz 1 innych odgałęzień)* |
| `[90]` | **"...demanded that he crack down on the traitors."** | `[77]` **Narrator**: "As you continued to serve on the..."<br>`[87]` **Narrator**: "As you continued your studies, t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...` | `[110]` **Narrator**: "A few arrests were made, but the..."<br>`[111]` **Narrator**: "A few arrests were made, but the..."<br>*(oraz 1 innych odgałęzień)* |
| `[91]` | **"...refrained from taking sides."** | `[77]` **Narrator**: "As you continued to serve on the..."<br>`[87]` **Narrator**: "As you continued your studies, t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "You hoped it would all pass, but..."<br>`[120]` **Narrator**: "You hoped it would all pass, but..."<br>*(oraz 1 innych odgałęzień)* |
| `[92]` | **"1926\|April 7\|Porte Drazon"** | `[89]` **Player_Romus**: "...asked your father to stop the..." | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[107]` | **"The Century of Revolutions had reached Rizia at last."** | `[92]` **Narrator**: "Some troops were withdrawn, but ..."<br>`[108]` **Narrator**: "Some troops were withdrawn, but ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Narrator**: "The head of palace security insi..."<br>`[132]` **Narrator**: "The king insisted you be driven ..."<br>*(oraz 1 innych odgałęzień)* |
| `[108]` | **"1926\|April 7\|Iza"** | `[89]` **Player_Romus**: "...asked your father to stop the..." | `Variable["RiziaDLC.Prologue_Studied"] == true`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[109]` | **"1926\|April 7\|Montaklar"** | `[89]` **Player_Romus**: "...asked your father to stop the..." | `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[110]` | **"1926\|April 7\|Porte Drazon"** | `[90]` **Player_Romus**: "...demanded that he crack down o..." | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[111]` | **"1926\|April 7\|Iza"** | `[90]` **Player_Romus**: "...demanded that he crack down o..." | `Variable["RiziaDLC.Prologue_Studied"] == true`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[112]` | **"1926\|April 7\|Montaklar"** | `[90]` **Player_Romus**: "...demanded that he crack down o..." | `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[116]` | **"1926\|April 7\|Montaklar"** | `[91]` **Player_Romus**: "...refrained from taking sides." | `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[120]` | **"1926\|April 7\|Iza"** | `[91]` **Player_Romus**: "...refrained from taking sides." | `Variable["RiziaDLC.Prologue_Studied"] == true`<br>`(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[121]` | **"1926\|April 7\|Porte Drazon"** | `[91]` **Player_Romus**: "...refrained from taking sides." | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | `AdvanceTimeline();`<br>`PlaySoundEffect("ProtestorsAngry");`<br>*(+1 skryptów)* | `[107]` **Player_Romus**: "The Century of Revolutions had r..." |
| `[129]` | **"You tried to fight them."** | `[122]` **Narrator**: "The head of palace security insi..."<br>`[132]` **Narrator**: "The king insisted you be driven ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false` | *Brak zmian stanu* | `[138]` **Narrator**: "Your captors subdued you after o..." |
| `[130]` | **"You complied with their demands."** | `[122]` **Narrator**: "The head of palace security insi..."<br>`[132]` **Narrator**: "The king insisted you be driven ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "You recognized one of their voic..." |
| `[131]` | **"You tried to run away."** | `[122]` **Narrator**: "The head of palace security insi..."<br>`[132]` **Narrator**: "The king insisted you be driven ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "You ran for your life. But befor..." |
| `[134]` | **"You tried to fight them."** | `[122]` **Narrator**: "The head of palace security insi..."<br>`[132]` **Narrator**: "The king insisted you be driven ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[135]` **Narrator**: "Your military training kicked in..." |
| `[139]` | **"Then, darkness."** | `[135]` **Narrator**: "Your military training kicked in..."<br>`[136]` **Narrator**: "You ran for your life. But befor..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "They held you captive for nearly..." |
| `[140]` | **"1926\|April 13"** | `[139]` **Player_Romus**: "Then, darkness." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Player_Romus**: "Wehlen's flag." |
| `[143]` | **"Wehlen's flag."** | `[140]` **Narrator**: "They held you captive for nearly..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_WehlenRescue");`<br>`AdvanceTimeline();`<br>*(+2 skryptów)* | `[144]` **Narrator**: "At the palace, you pieced togeth..." |
| `[144]` | **"1926\|April 13\|Porte Drazon"** | `[143]` **Player_Romus**: "Wehlen's flag." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Player_Romus**: "You wondered how King Valero cou..."<br>`[146]` **Player_Romus**: "You thanked him for restoring or..."<br>*(oraz 1 innych odgałęzień)* |
| `[145]` | **"You wondered how King Valero could have been so stupid."** | `[144]` **Narrator**: "At the palace, you pieced togeth..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[13]` **Narrator**: "The uprising had other consequen..." |
| `[146]` | **"You thanked him for restoring order."** | `[144]` **Narrator**: "At the palace, you pieced togeth..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[13]` **Narrator**: "The uprising had other consequen..." |
| `[147]` | **"You were just happy to be alive."** | `[144]` **Narrator**: "At the palace, you pieced togeth..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[13]` **Narrator**: "The uprising had other consequen..." |
| `[148]` | **"1930\|June 20\|Monqiz"** | `[15]` **Player_Romus**: "...largely ignored your duties a..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Wedded to Princess Lena of the Kingdom o...`<br>`PrologueImage("pe_royalwedding");` | `[7]` **Player_Romus**: "You bowed."<br>`[150]` **Player_Romus**: "You kissed her hand."<br>*(oraz 1 innych odgałęzień)* |
| `[149]` | **"1930\|June 20\|Monqiz"** | `[16]` **Player_Romus**: "...did your best to help your re..." | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Wedded to Princess Lena of the Kingdom o...`<br>`PrologueImage("pe_royalwedding");` | `[7]` **Player_Romus**: "You bowed."<br>`[150]` **Player_Romus**: "You kissed her hand."<br>*(oraz 1 innych odgałęzień)* |
| `[150]` | **"You kissed her hand."** | `[6]` **Narrator**: "Your region came to see you as a..."<br>`[148]` **Narrator**: "You were a constant newspaper fi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "King Valero told you that he had..." |
| `[152]` | **"...that your royal duties left you too busy to spend time with family."** | `[17]` **Narrator**: "You and Lena began having hours-..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_DistantAsDad"] = true; Enable...`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." |
| `[153]` | **"...that your commitment to being a good husband and father sometimes meant you neg..."** | `[17]` **Narrator**: "You and Lena began having hours-..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_MarriageIssue_NeglectedWork");`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." |
| `[154]` | **"...that you couldn't stop yourself from having the occasional affair."** | `[17]` **Narrator**: "You and Lena began having hours-..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_HadAffairs"] = true; EnableJo...`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." |
| `[155]` | **"...tried your best to be a good father."** | `[12]` **Narrator**: "You and Lena went on a few dates..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_MarriageIssue_GoodFather");`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." |
| `[156]` | **"...ignored your family and threw yourself into your work."** | `[12]` **Narrator**: "You and Lena went on a few dates..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_DistantAsDad"] = true; Enable...`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." |
| `[157]` | **"...had a string of affairs."** | `[12]` **Narrator**: "You and Lena went on a few dates..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_HadAffairs"] = true; EnableJo...`<br>`AdvanceTimeline();`<br>*(+1 skryptów)* | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." |
| `[158]` | **"1933"** | `[154]` **Player_Romus**: "...that you couldn't stop yourse..."<br>`[157]` **Player_Romus**: "...had a string of affairs."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Player_Romus**: "...celebrated Rizia's new divers..."<br>`[160]` **Player_Romus**: "...were suspicious of these newc..."<br>*(oraz 1 innych odgałęzień)* |
| `[160]` | **"...were suspicious of these newcomers."** | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_Immigrants_Suspicion");` | `[161]` **Narrator**: "Many of the foreigners ended up ..." |
| `[161]` | **"1939\|Iza"** | `[230]` **Player_Romus**: "...celebrated Rizia's new divers..."<br>`[160]` **Player_Romus**: "...were suspicious of these newc..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();`<br>`PlaySoundEffect("SuOmina1");`<br>*(+1 skryptów)* | `[162]` **Player_Romus**: "You agreed."<br>`[334]` **Player_Romus**: "You attended, but did not speak."<br>*(oraz 1 innych odgałęzień)* |
| `[162]` | **"You agreed."** | `[161]` **Narrator**: "Many of the foreigners ended up ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_JoinedSuOmina"] = true; Varia...` | `[164]` **Narrator**: "You threw your weight behind Su ..." |
| `[163]` | **"You refused."** | `[161]` **Narrator**: "Many of the foreigners ended up ..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_SuOmina_Refused");` | `[166]` **Narrator**: "You distanced yourself from the ..." |
| `[165]` | **"...happily came along."** | `[177]` **Narrator**: "You found yourself under more an..."<br>`[178]` **Narrator**: "You found yourself under more an..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("StormAtSea");`<br>`PrologueImage("pe_sailboat");`<br>*(+1 skryptów)* | `[181]` **Narrator**: "In the middle of the Gulf of Val..." |
| `[170]` | **"...went, but only for your daughter's sake."** | `[178]` **Narrator**: "You found yourself under more an..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("StormAtSea");`<br>`PrologueImage("pe_sailboat");`<br>*(+1 skryptów)* | `[181]` **Narrator**: "In the middle of the Gulf of Val..." |
| `[171]` | **"...decided to get some work done instead."** | `[177]` **Narrator**: "You found yourself under more an..."<br>`[178]` **Narrator**: "You found yourself under more an..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_BoatTrip_Worked");`<br>`PlaySoundEffect("StormAtSea");`<br>*(+1 skryptów)* | `[180]` **Narrator**: "You were in your office when you..." |
| `[175]` | **"1942\|May 20\|Monqiz"** | `[179]` **Player_Romus**: "...decided to meet your latest l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Player_Romus**: "She died holding your hand."<br>`[18]` **Player_Romus**: "But it was too late." |
| `[176]` | **"A few years passed."** | `[164]` **Narrator**: "You threw your weight behind Su ..."<br>`[166]` **Narrator**: "You distanced yourself from the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[232]` **Narrator**: "You slowly realized that the upr..." |
| `[177]` | **"1942\|May\|Monqiz"** | `[233]` **Player_Romus**: ""Valero the Frail."" | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[165]` **Player_Romus**: "...happily came along."<br>`[171]` **Player_Romus**: "...decided to get some work done..."<br>*(oraz 1 innych odgałęzień)* |
| `[178]` | **"1942\|May\|Monqiz"** | `[233]` **Player_Romus**: ""Valero the Frail."" | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[165]` **Player_Romus**: "...happily came along."<br>`[170]` **Player_Romus**: "...went, but only for your daugh..."<br>*(oraz 2 innych odgałęzień)* |
| `[179]` | **"...decided to meet your latest lover instead."** | `[177]` **Narrator**: "You found yourself under more an..."<br>`[178]` **Narrator**: "You found yourself under more an..." | `Variable["RiziaDLC.Prologue_HadAffairs"] == true` | `EnableJournalEntry("Prologue_BoatTrip_Lover");`<br>`PlaySoundEffect("StormAtSea");`<br>*(+1 skryptów)* | `[175]` **Narrator**: "You were putting your clothes ba..." |
| `[180]` | **"1942\|May 20\|Monqiz"** | `[171]` **Player_Romus**: "...decided to get some work done..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Player_Romus**: "She died holding your hand."<br>`[18]` **Player_Romus**: "But it was too late." |
| `[181]` | **"1942\|May 20\|Monqiz"** | `[165]` **Player_Romus**: "...happily came along."<br>`[170]` **Player_Romus**: "...went, but only for your daugh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Player_Romus**: "She died holding your hand."<br>`[18]` **Player_Romus**: "But it was too late." |
| `[185]` | **"She died holding your hand."** | `[175]` **Narrator**: "You were putting your clothes ba..."<br>`[180]` **Narrator**: "You were in your office when you..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | `EnableCollectionItem("CollectionItem_WeddingRing");`<br>`PrologueImage("pe_mourning");` | `[19]` **Narrator**: "You were devastated.  After the ..." |
| `[186]` | **"You began to get suspicious as well."** | `[22]` **Narrator**: "Meanwhile, the situation in the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "Even with Hugo advising him as G..." |
| `[187]` | **"You wondered what the country was coming to."** | `[22]` **Narrator**: "Meanwhile, the situation in the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "Even with Hugo advising him as G..." |
| `[189]` | **"...told your father about your trip."** | `[30]` **Narrator**: "The duke was taken aback and ord..."<br>`[31]` **Narrator**: "The duke was satisfied with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_AxelVisitReturn_Truth");`<br>`PrologueImage("pe_meetking"); ;` | `[194]` **Narrator**: "The king was pleased you'd stood..."<br>`[195]` **Narrator**: "The king was furious. He accused..." |
| `[190]` | **"...lied to him about where you'd been."** | `[30]` **Narrator**: "The duke was taken aback and ord..."<br>`[31]` **Narrator**: "The duke was satisfied with your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_AxelVisitReturn_Lied");`<br>`PrologueImage("pe_meetking"); ;` | `[214]` **Narrator**: "A few days later, the King summo..."<br>`[213]` **Narrator**: "A few days later, the King summo..." |
| `[194]` | **"1948\|October 8\|Porte Drazon"** | `[189]` **Player_Romus**: "...told your father about your t..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true` | *Brak zmian stanu* | `[199]` **Player_Romus**: "You assured him you were on his ..."<br>`[198]` **Player_Romus**: "You begged for his forgiveness."<br>*(oraz 2 innych odgałęzień)* |
| `[195]` | **"1948\|October 8\|Porte Drazon"** | `[189]` **Player_Romus**: "...told your father about your t..." | `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false` | *Brak zmian stanu* | `[300]` **Player_Romus**: "You went against Duke Reinhart's..."<br>`[301]` **Player_Romus**: "You kept your mouth shut."<br>*(oraz 1 innych odgałęzień)* |
| `[196]` | **"You said nothing and walked out."** | `[194]` **Narrator**: "The king was pleased you'd stood..."<br>`[214]` **Narrator**: "A few days later, the King summo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Narrator**: "Valero banished you from his sig..." |
| `[197]` | **"You exploded at him for being an incompetent ruler."** | `[194]` **Narrator**: "The king was pleased you'd stood..."<br>`[195]` **Narrator**: "The king was furious. He accused..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Narrator**: "Valero banished you from his sig..." |
| `[198]` | **"You begged for his forgiveness."** | `[194]` **Narrator**: "The king was pleased you'd stood..."<br>`[214]` **Narrator**: "A few days later, the King summo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "You had only occasional contact ..." |
| `[199]` | **"You assured him you were on his side."** | `[194]` **Narrator**: "The king was pleased you'd stood..."<br>`[214]` **Narrator**: "A few days later, the King summo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "You had only occasional contact ..." |
| `[200]` | **"1949\|November\|Monqiz\|Farewells"** | `[304]` **Narrator**: "Valero banished you from his sig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Player_Romus**: "The king was dying." |
| `[201]` | **"1949\|November\|Monqiz\|Farewells"** | `[198]` **Player_Romus**: "You begged for his forgiveness."<br>`[199]` **Player_Romus**: "You assured him you were on his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Player_Romus**: "The king was dying." |
| `[202]` | **"The king was dying."** | `[200]` **Narrator**: "As Vina grew into an intelligent..."<br>`[201]` **Narrator**: "You had only occasional contact ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_deadking"); ;` | `[32]` **Narrator**: "He'd gone straight to bed after ..." |
| `[208]` | **"...refused to promise anything."** | `[26]` **Narrator**: "It was your first time in Pales ..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_AxelVisit_Neutral");` | `[209]` **Narrator**: "The duke accepted your answer. D..." |
| `[213]` | **"1948\|October 8\|Porte Drazon"** | `[190]` **Player_Romus**: "...lied to him about where you'd..." | `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false` | *Brak zmian stanu* | `[300]` **Player_Romus**: "You went against Duke Reinhart's..."<br>`[301]` **Player_Romus**: "You kept your mouth shut."<br>*(oraz 1 innych odgałęzień)* |
| `[214]` | **"1948\|October 8\|Porte Drazon"** | `[190]` **Player_Romus**: "...lied to him about where you'd..." | `Variable["RiziaDLC.Prologue_HostileToPales"] == true` | *Brak zmian stanu* | `[199]` **Player_Romus**: "You assured him you were on his ..."<br>`[198]` **Player_Romus**: "You begged for his forgiveness."<br>*(oraz 2 innych odgałęzień)* |
| `[216]` | **"You declined."** | `[24]` **Narrator**: "Outsiders also took notice of th..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_AxelInvitation_Declined");`<br>`PrologueImage("pe_letter"); ;` | `[217]` **Narrator**: "A few days later, you received a..." |
| `[218]` | **"You showed it to the king."** | `[217]` **Narrator**: "A few days later, you received a..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_meetking"); ;` | `[220]` **Narrator**: "Valero thanked you for your hone..." |
| `[219]` | **"You kept it to yourself."** | `[217]` **Narrator**: "A few days later, you received a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Narrator**: "A few days later, the King summo..." |
| `[220]` | **"1948\|October 8\|Porte Drazon"** | `[218]` **Player_Romus**: "You showed it to the king." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_HostileToPales"] = true; Vari...` | `[336]` **Player_Romus**: "You heard nothing from Pales aft..." |
| `[221]` | **"1948\|October 8\|Porte Drazon"** | `[219]` **Player_Romus**: "You kept it to yourself." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_AxelLetter_Lie");`<br>`PrologueImage("pe_meetking"); ;` | `[199]` **Player_Romus**: "You assured him you were on his ..."<br>`[198]` **Player_Romus**: "You begged for his forgiveness."<br>*(oraz 2 innych odgałęzień)* |
| `[226]` | **"...asked him about the protests."** | `[312]` **Narrator**: "You remember two things about Ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Your father laughed and told you..." |
| `[228]` | **"In faith, you finally found solace."** | `[19]` **Narrator**: "You were devastated.  After the ..."<br>`[21]` **Narrator**: "You mourned for a while.  But yo..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_religious"); ;`<br>`Variable["RiziaDLC.Prologue_Religious"] = true; Variable[...`<br>*(+1 skryptów)* | `[22]` **Narrator**: "Meanwhile, the situation in the ..." |
| `[230]` | **"...celebrated Rizia's new diversity."** | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_Immigrants_Celebrate");` | `[161]` **Narrator**: "Many of the foreigners ended up ..." |
| `[231]` | **"...welcomed the new arrivals, but were secretly glad that few of them settled in y..."** | `[158]` **Narrator**: "With Rumburg's help, Rizia's eco..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_Immigrants_Welcomed");` | `[161]` **Narrator**: "Many of the foreigners ended up ..." |
| `[232]` | **"1942\|Porte Drazon\|Dark Horizons"** | `[176]` **Player_Romus**: "A few years passed." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_frailking");` | `[233]` **Player_Romus**: ""Valero the Frail."" |
| `[233]` | **""Valero the Frail.""** | `[232]` **Narrator**: "You slowly realized that the upr..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[177]` **Narrator**: "You found yourself under more an..."<br>`[178]` **Narrator**: "You found yourself under more an..." |
| `[300]` | **"You went against Duke Reinhart's wishes and gave your father every last detail."** | `[195]` **Narrator**: "The king was furious. He accused..."<br>`[213]` **Narrator**: "A few days later, the King summo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_HostileToPales"] = true; Vari...` | `[303]` **Narrator**: "Valero wrote to Duke Reinhart th..." |
| `[301]` | **"You kept your mouth shut."** | `[195]` **Narrator**: "The king was furious. He accused..."<br>`[213]` **Narrator**: "A few days later, the King summo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Narrator**: "Valero banished you from his sig..." |
| `[307]` | **"1949\|November\|Monqiz\|Farewells"** | `[303]` **Narrator**: "Valero wrote to Duke Reinhart th..."<br>`[336]` **Player_Romus**: "You heard nothing from Pales aft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Player_Romus**: "The king was dying." |
| `[311]` | **"There was a new king to crown."** | `[54]` **Narrator**: "When Queen Lyza died, the whole ..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("QueenDeath");`<br>`PrologueImage("pe_death of queen Lyza");` | `[312]` **Narrator**: "You remember two things about Ki..." |
| `[313]` | **"It felt good to have caring relatives."** | `[51]` **Narrator**: "Your uncle taught you more than ..."<br>`[52]` **Narrator**: "You were fascinated by the splen..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[54]` **Narrator**: "When Queen Lyza died, the whole ..." |
| `[320]` | **"1947\|October\|Porte Drazon"** | `[23]` **Player_Romus**: "You reasoned the King had brough..."<br>`[186]` **Player_Romus**: "You began to get suspicious as w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Player_Romus**: "...enforcing internal security a..."<br>`[330]` **Player_Romus**: "...strengthening the armed force..."<br>*(oraz 3 innych odgałęzień)* |
| `[322]` | **"...enforcing internal security and the passing of necessary royal decrees."** | `[320]` **Narrator**: "Even with Hugo advising him as G..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] = tru...`<br>`AdvanceTimeline();` | `[24]` **Narrator**: "Outsiders also took notice of th..." |
| `[323]` | **"...increasing gold extraction and improving tax efficiency."** | `[320]` **Narrator**: "Even with Hugo advising him as G..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] = tr...`<br>`AdvanceTimeline();` | `[24]` **Narrator**: "Outsiders also took notice of th..." |
| `[324]` | **"...enhancing the extraction of oil, coal, and gas."** | `[320]` **Narrator**: "Even with Hugo advising him as G..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] = true...`<br>`AdvanceTimeline();` | `[24]` **Narrator**: "Outsiders also took notice of th..." |
| `[325]` | **"...spearheading a public relations campaign to boost national opinion of the Royal..."** | `[320]` **Narrator**: "Even with Hugo advising him as G..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Focus_PRCampaign"] = true; Va...`<br>`AdvanceTimeline();` | `[24]` **Narrator**: "Outsiders also took notice of th..." |
| `[330]` | **"...strengthening the armed forces and building new military formations."** | `[320]` **Narrator**: "Even with Hugo advising him as G..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] = true; V...`<br>`AdvanceTimeline();` | `[24]` **Narrator**: "Outsiders also took notice of th..." |
| `[332]` | **"The world seemed dull and meaningless."** | `[19]` **Narrator**: "You were devastated.  After the ..."<br>`[21]` **Narrator**: "You mourned for a while.  But yo..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[22]` **Narrator**: "Meanwhile, the situation in the ..." |
| `[333]` | **"You believed that things could be better."** | `[22]` **Narrator**: "Meanwhile, the situation in the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "Even with Hugo advising him as G..." |
| `[334]` | **"You attended, but did not speak."** | `[161]` **Narrator**: "Many of the foreigners ended up ..." | *Brak (Dostępna bezwarunkowo)* | `EnableJournalEntry("Prologue_SuOmina_Attended");` | `[335]` **Narrator**: "You watched as the organizations..." |
| `[336]` | **"You heard nothing from Pales after that."** | `[220]` **Narrator**: "Valero thanked you for your hone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Narrator**: "You stayed close with your fathe..." |
| `[367]` | **"…you desired an easy life, one where you seized every advantage you were entitled ..."** | `[366]` **Narrator**: "You were cut off from the world ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_EasyLife"] = true; Variable["...` | `[62]` **Narrator**: "When you came of age, your fathe..." |
| `[368]` | **"…your royal privilege came with unbelievable pressure, and balancing the two would..."** | `[366]` **Narrator**: "You were cut off from the world ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_NormalLife"] = true; ;` | `[62]` **Narrator**: "When you came of age, your fathe..." |
| `[369]` | **"…the years ahead would be full of challenges, but they would make your triumphs al..."** | `[366]` **Narrator**: "You were cut off from the world ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Prologue_HardLife"] = true; Variable["...` | `[62]` **Narrator**: "When you came of age, your fathe..." |

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
  - -> `[3]` (*Narrator: "1905|Monqiz|Kingdom of Rizia"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1905|Monqiz|Kingdom of Rizia"]** — Mówca: **Narrator**
> "You opened your eyes to this realm.

Becoming a king was never your choice."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_princebirth");"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...quickly became close friends."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Making a lifelong friend in the palace g..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...enjoyed bossing him around."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Pushing the groundskeeper’s kid around",..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "1930|June 20|Monqiz"]** — Mówca: **Narrator**
> "Your region came to see you as a cruel but capable leader.

One day, the king came for an unannounced visit. He brought with him a pale-skinned young woman with striking blue eyes.

Hesitantly, she introduced herself as Lena Livingston -- the sister of Queen Beatrice of Rumburg, and your wife-to-be."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Wedded to Princess Lena of the Kingdom o..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You bowed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[148]` (Narrator), `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "King Valero told you that he had no choice.   With Wehlen..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You demanded to know what was going on."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[148]` (Narrator), `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "King Valero told you that he had no choice.   With Wehlen..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "King Valero told you that he had no choice. 

With Wehlen descending into civil war, Rizia needed a new ally.

A partnership with the Kingdom of Rumburg, cemented with an arranged marriage, was in the best interest of both monarchies.

Besides, he added, you would surely grow to love her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: "He was right."*)
  - -> `[11]` (*Player_Romus: "He was wrong."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "He was right."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_LovedWife"] = true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife = true; EnableJournalEntry("P..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "He was wrong."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_Marriage_DontLove"); EnableJ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "1932|March 1|A Family Man"]** — Mówca: **Narrator**
> "You and Lena went on a few dates, but neither of you felt a spark. By the time you lifted her veil, you knew the marriage was a sham.

For your countries' sake, you slept together a few times. One of those resulted in the birth of your daughter, Vina. 

After she was born, you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: "...had a string of affairs."*)
  - -> `[155]` (*Player_Romus: "...tried your best to be a good father."*)
  - -> `[156]` (*Player_Romus: "...ignored your family and threw yourself into your work."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "1927|Porte Drazon|A Changed Country"]** — Mówca: **Narrator**
> "The uprising had other consequences.

The traitor Lucas Sazon was executed, and his pregnant wife sent into exile. As further punishment, Iza -- the capital city of Brenas, and the Sazons' ancestral home -- was handed over to your family.

Your uncle Hugo was sent to serve as its steward. In turn, you were to take his place as reigning Duke of Valenqiris.

At your childhood home in Monqiz, you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Player_Romus), `[146]` (Player_Romus), `[147]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Hanging");"*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...focused on finding and punishing the remaining traitors to the throne."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Arrests = true;  RiziaDLC.Person..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...largely ignored your duties and lived a life of leisure."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince = true; RiziaDLC.Per..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did your best to help your region rebuild."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Rebuild = true;  RiziaDLC.Resour..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "1932|March 1|A Family Man"]** — Mówca: **Narrator**
> "You and Lena began having hours-long conversations about your royal upbringings, hopes and dreams.

By the time you lifted her veil, you knew it was true love.

The years after your wedding and the birth of your daughter Vina were the happiest of your life. 

The only trouble was..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: "...that your royal duties left you too busy to spend time..."*)
  - -> `[153]` (*Player_Romus: "...that your commitment to being a good husband and fathe..."*)
  - -> `[154]` (*Player_Romus: "...that you couldn't stop yourself from having the occasi..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "But it was too late."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator), `[180]` (Narrator), `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_mourning");"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "You were devastated.

After the funeral, your mother Estela came to visit and found you hardly able to function. She promptly moved in to help out with Vina. 

Hugo suggested you turn to Wruhecism, Rizia's official religion, to cope with your loss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: "In faith, you finally found solace."*)
  - -> `[20]` (*Player_Romus: "If anything, you became less of a believer."*)
  - -> `[332]` (*Player_Romus: "The world seemed dull and meaningless."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "If anything, you became less of a believer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "You mourned for a while.

But you also had a province to lead and a young daughter to care for. Your mother Estela moved in to help out with Vina. 

Hugo suggested you turn to Wruhecism, Rizia's official religion, to cope with your loss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: "In faith, you finally found solace."*)
  - -> `[20]` (*Player_Romus: "If anything, you became less of a believer."*)
  - -> `[332]` (*Player_Romus: "The world seemed dull and meaningless."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "1946|August|Porte Drazon"]** — Mówca: **Narrator**
> "Meanwhile, the situation in the capital worsened.

Rizian nationalists continued protesting the loss of Zille and the country’s growing pluralism. Rumors spread that an anti-monarchist movement was growing once more. Several long-operating gold mines were depleting as the expenses of the kingdom grew. 

Your father called Hugo back from Iza to keep an eye on his council."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Player_Romus), `[332]` (Player_Romus), `[228]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SuOmina2");"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You reasoned the King had brought his troubles on himself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "1947|October|Porte Drazon"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "1948|October|Porte Drazon"]** — Mówca: **Narrator**
> "Outsiders also took notice of the king's decline.

One of them was Axel Reinhart, the new ruler of the Grand Duchy of Pales.

He sent you an invitation to visit him, on two conditions: You were to go alone, and without your father's knowledge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Player_Romus), `[323]` (Player_Romus), `[324]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: "You accepted."*)
  - -> `[216]` (*Player_Romus: "You declined."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PalesVisit");"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "1948|October 5|Pales|Confrontations"]** — Mówca: **Narrator**
> "It was your first time in Pales since childhood. You were surprised at how modern everything seemed now.

Duke Reinhart welcomed you to his palace. He said he was hoping to re-establish relations with Rizia once you became king.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: "...told him that would only be possible once Pales rejoin..."*)
  - -> `[28]` (*Player_Romus: "...said you were looking forward to putting the past behi..."*)
  - -> `[29]` (*Player_Romus: "...agreed that a thaw between Rizia and Pales could be lu..."*)
  - -> `[208]` (*Player_Romus: "...refused to promise anything."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told him that would only be possible once Pales rejoined Rizia, where it belonged."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Diploma..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...said you were looking forward to putting the past behind you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales = true; RiziaDLC.Diplom..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...agreed that a thaw between Rizia and Pales could be lucrative on both sides."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FriendlyToPales = true; RiziaDLC.Diplom..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The duke was taken aback and ordered you to leave at once.

Afterwards, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: "...told your father about your trip."*)
  - -> `[190]` (*Player_Romus: "...lied to him about where you'd been."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "The duke was satisfied with your answer. You spent the next few days getting to know him and the duchy better.

Afterwards, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_palesalt");"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He'd gone straight to bed after dinner. When your mother went to check in on him later, she found him comatose in the bedroom.

The doctors suspected a heart attack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: "You rushed to see him."*)
  - -> `[34]` (*Player_Romus: "You stayed where you were."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You rushed to see him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter = false; EnableJournalEntry("..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You stayed where you were."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter = true; EnableJournalEntry("P..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "1949|November 18|Porte Drazon"]** — Mówca: **Narrator**
> "Your father looked pale as a ghost. It took all his effort to speak.

In a hoarse whisper, he warned you not to follow in his footsteps.

Your reign would be a fresh start for House Toras. A new chance to take back the lands that were lost."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: "He closed his eyes."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "1949|November 18|Porte Drazon"]** — Mówca: **Narrator**
> "The next day, King Valero Toras was no more.

You and Vina traveled to Porte Drazon to comfort your mother.

She handed you a note your father had written you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: "His last words."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "He closed his eyes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_FatherLastWords_Hear");"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "His last words."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "In the letter, he warned you not to follow in his footste..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "In the letter, he warned you not to follow in his footsteps.

Your reign would be a fresh start for House Toras. A new chance to take back the lands that were lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: "You threw it away."*)
  - -> `[41]` (*Player_Romus: "You fought back tears."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Only after his funeral, gathered at the palace with your mother and daughter, did the realization begin to dawn on you.

From the day you were born, your entire life had been leading to this moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coronation");"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You fought back tears."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway = false; EnableJour..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Now, it was finally here."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("RiziaPrologue_Finish");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You threw it away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter_ThrowAway = true; EnableJourn..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was your birthright."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "From a young age, you knew you were no ordinary child.   ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was your burden."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "From a young age, you knew you were no ordinary child.   ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was your calling."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "From a young age, you knew you were no ordinary child.   ..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "From a young age, you knew you were no ordinary child. 

You were Romus Toras. Grandson of Queen Lyza, ruler of all of Rizia. Son of Crown Prince Valero, the Duke of Valenqiris.

For most of the year, you lived with your father Valero and your mother Estela in a lavish palace atop the cliffs of Monqiz. Each summer, though, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Monqiz");"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...visited your mother's common-born family at their home by the Zille harbor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Visiting their common-born family", "Fam..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...stayed with the Queen at the royal residence in Porte Drazon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Spending summers with Queen Lyza", "Roya..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...went hunting with your father's brother Hugo in the forests of Brenas."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Hunting with Uncle Hugo", "forest", "Bre..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Your uncle taught you more than just how to hold and aim a gun. 

You learned the value of staying patient and keeping your eyes and ears open at all times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: "Every autumn, you returned home a little wiser."*)
  - -> `[313]` (*Player_Romus: "It felt good to have caring relatives."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "You were fascinated by the splendor of your surroundings and the intricacies of your grandmother's court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: "Every autumn, you returned home a little wiser."*)
  - -> `[313]` (*Player_Romus: "It felt good to have caring relatives."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Your grandparents were fisherpeople of modest means, and staying with them helped you feel grounded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: "Every autumn, you returned home a little wiser."*)
  - -> `[313]` (*Player_Romus: "It felt good to have caring relatives."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "1918|January 28|Porte Drazon|A New King"]** — Mówca: **Narrator**
> "When Queen Lyza died, the whole country grieved.

But the mourning could only last for so long."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Player_Romus), `[313]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: "There was a new king to crown."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...asked him about the rumors."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Your father laughed and told you certain other royals had..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't mention either."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Your father laughed and told you certain other royals had never approved of him marrying a commoner.

But he and Estela were in love. And love conquered all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: "You had your doubts."*)
  - -> `[72]` (*Player_Romus: "You believed him."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Your father laughed and told you that some people had come to believe Rizia shouldn't be ruled by a monarch anymore.

But of course, he assured you, they were wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: "You had your doubts."*)
  - -> `[72]` (*Player_Romus: "You believed him."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had your doubts."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator), `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "1920"]** — Mówca: **Narrator**
> "Life in Porte Drazon was less exciting than you expected. You were tutored privately and rarely had contact with non-royals.

At the palace, the closest person to your age was Pabel, the groundskeeper's son -- a quiet but friendly kid who knew about every plant in the gardens. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Player_Romus), `[59]` (Player_Romus), `[72]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_children_playing");"*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't have much to do with each other."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "You were cut off from the world beyond the palace walls, ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "1923|September"]** — Mówca: **Narrator**
> "When you came of age, your father invited you to start sitting in on royal council meetings. You decided..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[367]` (Player_Romus), `[368]` (Player_Romus), `[369]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_innercircle");"*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that you would love to join."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Stepping into the Royal Council as the k..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to go to university instead."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied = true; RiziaDLC.Resources_Budg..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to join the military instead."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary = true; RiziaDLC.Resourc..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The council members took you under their wing, catching you up on the issues of the day.

One of their main concerns was Pales, a former part of Rizia that had long belonged to the Empire of Valgos.

Now that the empire had fallen, war councilor General Taddeus Azaro was launching a military campaign to take the newly independent region back. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: "...thought it was a lost cause."*)
  - -> `[74]` (*Player_Romus: "...agreed that it was time to reconquer the territory."*)
  - -> `[75]` (*Player_Romus: "...didn't have an opinion either way."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "At the prestigious University of Iza, you studied history, politics and economics to prepare for your eventual reign.

In one of your classes, an argument broke out about Pales, a former part of Rizia that had long belonged to the Empire of Valgos.

Now that the empire had fallen, your father's government was launching a military campaign to take the newly independent region back. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: "...thought it was a lost cause."*)
  - -> `[74]` (*Player_Romus: "...agreed that it was time to reconquer the territory."*)
  - -> `[75]` (*Player_Romus: "...didn't have an opinion either way."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Every autumn, you returned home a little wiser."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator), `[52]` (Narrator), `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille = true; RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 1;
EnableJournalEntry("Prologue_Summer_Zille");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 1;
EnableJournalEntry("Prologue_Summer_Zille");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Your grandparents were fisherpeople of modest means, and ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Court = true;
EnableJournalEntry("Prologue_Summer_Court");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Summer_Court"] = true;
EnableJournalEntry("Prologue_Summer_Court");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "You were fascinated by the splendor of your surroundings ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo = true;
RiziaDLC.Relations_Hugo += 1;
EnableJournalEntry("Prologue_Summer_Hugo");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] = true;
Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;
EnableJournalEntry("Prologue_Summer_Hugo");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Your uncle taught you more than just how to hold and aim ..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You believed him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator), `[58]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...thought it was a lost cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[67]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("WarSpeech");"*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...agreed that it was time to reconquer the territory."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[67]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("WarSpeech");"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't have an opinion either way."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[67]` (Narrator), `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("WarSpeech");"*)

### Węzeł `[76]`
Mówca: **Narrator**
> "At the prestigious Camp Domus academy in the mountains of Montaklar, you learned about war strategy and combat tactics.

One day, the royal war councillor, General Taddeus Azaro, came to visit. He announced a military campaign on Pales, a former part of Rizia that had long belonged to the Empire of Valgos.

Now that the empire had fallen, he said, the time was right to take the region back. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: "...thought it was a lost cause."*)
  - -> `[74]` (*Player_Romus: "...agreed that it was time to reconquer the territory."*)
  - -> `[75]` (*Player_Romus: "...didn't have an opinion either way."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "1925|War and Uncertainty"]** — Mówca: **Narrator**
> "As you continued to serve on the council, the Reclamation War dragged on.

It seemed like an easy victory until your northern neighbor Lespia got involved, sending weapons and financial aid to Pales.

Protests against the war sprouted up around the country. You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[74]` (Player_Romus), `[75]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: "...asked your father to stop the bloodshed."*)
  - -> `[90]` (*Player_Romus: "...demanded that he crack down on the traitors."*)
  - -> `[91]` (*Player_Romus: "...refrained from taking sides."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil = true;
RiziaDLC.Country_PublicOpinion += 2;
EnableJournalEntry("Prologue_Age_RoyalCouncil");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] = true;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 2;
EnableJournalEntry("Prologue_Age_RoyalCouncil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied = true;
RiziaDLC.Resources_Budget += 1;
EnableJournalEntry("Prologue_Age_University");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Studied"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;
EnableJournalEntry("Prologue_Age_University");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary = true;
RiziaDLC.Resources_Authority += 1;
EnableJournalEntry("Prologue_Age_Military");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
EnableJournalEntry("Prologue_Age_Military");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "1925|War and Uncertainty"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "1925|War and Uncertainty"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "1925|War and Uncertainty"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "1925|War and Uncertainty"]** — Mówca: **Narrator**
> "As you continued your studies, the Reclamation War dragged on.

It seemed like an easy victory until your northern neighbor Lespia got involved, sending weapons and financial aid to Pales.

Protests against the war sprouted up on campus. You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"] == true` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[74]` (Player_Romus), `[75]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: "...asked your father to stop the bloodshed."*)
  - -> `[90]` (*Player_Romus: "...demanded that he crack down on the traitors."*)
  - -> `[91]` (*Player_Romus: "...refrained from taking sides."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "1925|War and Uncertainty"]** — Mówca: **Narrator**
> "You weren't allowed to fight on the ground, so you watched from General Azaro's headquarters as the Reclamation War dragged on.

It seemed like an easy victory until your northern neighbor Lespia got involved, sending weapons and financial aid to Pales.

Dissent began brewing among your fellow recruits. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Player_Romus), `[74]` (Player_Romus), `[75]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: "...asked your father to stop the bloodshed."*)
  - -> `[90]` (*Player_Romus: "...demanded that he crack down on the traitors."*)
  - -> `[91]` (*Player_Romus: "...refrained from taking sides."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...asked your father to stop the bloodshed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist += 1; RiziaDLCSupport.Jou..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...demanded that he crack down on the traitors."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority += 1; RiziaDLC.PersonalValue..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...refrained from taking sides."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[87]` (Narrator), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "1926|April 7|Porte Drazon"]** — Mówca: **Narrator**
> "Some troops were withdrawn, but the fire had been lit.

Your next council meeting was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist += 1;
RiziaDLCSupport.Journal_Prologue_War_Stop = true;
EnableJournalEntry("Prologue_War_Stop");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;
Variable["RiziaDLCSupport.Journal_Prologue_War_Stop"] = true;
EnableJournalEntry("Prologue_War_Stop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority += 1;
RiziaDLC.PersonalValue_Pacifist -= 1;
RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableJournalEntry("Prologue_War_Crackdown");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableJournalEntry("Prologue_War_Crackdown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "1926|April 7|Porte Drazon"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "1926|April 7|Iza"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "1926|April 7|Montaklar"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "1926|April 7|Porte Drazon"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "1926|April 7|Iza"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "1926|April 7|Montaklar"*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The Century of Revolutions had reached Rizia at last."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator), `[108]` (Narrator), `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "1926|April 7|Iza"]** — Mówca: **Narrator**
> "Some troops were withdrawn, but the fire had been lit.

The next day, class was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"] == true` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "1926|April 7|Montaklar"]** — Mówca: **Narrator**
> "Some troops were withdrawn, but the fire had been lit.

The next day, General Azaro burst into headquarters with the news that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "1926|April 7|Porte Drazon"]** — Mówca: **Narrator**
> "A few arrests were made, but the fire had been lit.

Your next council meeting was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "1926|April 7|Iza"]** — Mówca: **Narrator**
> "A few arrests were made, but the fire had been lit.

The next day, class was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"] == true` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "1926|April 7|Montaklar"]** — Mówca: **Narrator**
> "A few arrests were made, but the fire had been lit.

The next day, General Azaro burst into headquarters with the news that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "1926|April 7|Porte Drazon"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "1926|April 7|Montaklar"]** — Mówca: **Narrator**
> "You hoped it would all pass, but the fire had been lit.

One day, General Azaro burst into headquarters with the news that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[91]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "1926|April 7|Iza"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "1926|April 7|Montaklar"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "1926|April 7|Iza"]** — Mówca: **Narrator**
> "You hoped it would all pass, but the fire had been lit.

One day, class was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"] == true` AND `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[91]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "1926|April 7|Porte Drazon"]** — Mówca: **Narrator**
> "You hoped it would all pass, but the fire had been lit.

Your next council meeting was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[91]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "The head of palace security insisted you be driven to a safehouse outside of Porte Drazon.

As you left city limits, though, an unmarked car swerved in front of you, blocking the road.

A trio of masked men with guns jumped out, quickly overpowered your guards and forced you out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Being dragged away by masked men", "Pala..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "The head of palace security insisted you be driven to a s..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "The king insisted you be driven back to the capital immed..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "The king insisted you be driven back to the capital immed..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to fight them."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator), `[132]` (Narrator), `[133]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Your captors subdued you after only the slightest struggl..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You complied with their demands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator), `[132]` (Narrator), `[133]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "You recognized one of their voices: Lucas Sazon, Duke of ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to run away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator), `[132]` (Narrator), `[133]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "You ran for your life. But before you could get far, you ..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "The king insisted you be driven back to the capital immediately.

As you left Iza city limits, though, an unmarked car swerved in front of you, blocking the road.

A trio of masked men with guns jumped out, quickly overpowered your guards and forced you out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Being dragged away by masked men", "Pala..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "The king insisted you be driven back to the capital immediately.

As you left Montaklar, though, an unmarked car swerved in front of you, blocking the road.

A trio of masked men with guns jumped out, quickly overpowered your guards and forced you out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Being dragged away by masked men", "Pala..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to fight them."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator), `[132]` (Narrator), `[133]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Your military training kicked in and you put up a serious..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Your military training kicked in and you put up a serious struggle. They shot you in the shoulder before you were finally subdued.

As your consciousness faded, you recognized one of your captors' voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar = true; EnableJournalEntry("Prolog..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "You ran for your life. But before you could get far, you felt a sharp pain in your leg and collapsed.

As your captors caught up with you, you recognized one of their voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp = true; EnableJournalEntry("Prolog..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "You recognized one of their voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_Kidnapping_Comply");"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Your captors subdued you after only the slightest struggle. 

You recognized one of their voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_Kidnapping_Fight");"*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then, darkness."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator), `[136]` (Narrator), `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "1926|April 13"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "1926|April 13"]** — Mówca: **Narrator**
> "They held you captive for nearly a week.

When rescue finally came, it was in the form of a man with a white, blue and magenta flag on his fatigues."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: "Wehlen's flag."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar = true;
EnableJournalEntry("Prologue_Kidnapping_FightMilitary");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Scar"] = true;
EnableJournalEntry("Prologue_Kidnapping_FightMilitary");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp = true;
EnableJournalEntry("Prologue_Kidnapping_Run");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Limp"] = true;
EnableJournalEntry("Prologue_Kidnapping_Run");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Wehlen's flag."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_WehlenRescue");"*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "1926|April 13|Porte Drazon"]** — Mówca: **Narrator**
> "At the palace, you pieced together what had happened.

In desperation, your father had pleaded for the aid of Rizia's northern neighbor, Wehlen, to neutralize the uprising.

But that help came at a price. Over the next year, the two nations worked out an agreement to transfer control of the port of Zille and its surrounding region -- home to rich natural resources and millions of people.

For the next 25 years, Zille would belong to Wehlen."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: "You wondered how King Valero could have been so stupid."*)
  - -> `[146]` (*Player_Romus: "You thanked him for restoring order."*)
  - -> `[147]` (*Player_Romus: "You were just happy to be alive."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wondered how King Valero could have been so stupid."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You thanked him for restoring order."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were just happy to be alive."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "1930|June 20|Monqiz"]** — Mówca: **Narrator**
> "You were a constant newspaper fixture. They called you the "Party Prince".

One day, the king came for an unannounced visit. He brought with him a pale-skinned young woman with striking blue eyes.

Hesitantly, she introduced herself as Lena Livingston -- the sister of Queen Beatrice of Rumburg, and your wife-to-be."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Wedded to Princess Lena of the Kingdom o..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "1930|June 20|Monqiz"]** — Mówca: **Narrator**
> "Valenqiris came to see you as a generous, capable leader.

One day, the king came for an unannounced visit. He brought with him a pale-skinned young woman with striking blue eyes.

Hesitantly, she introduced herself as Lena Livingston -- the sister of Queen Beatrice of Rumburg, and your wife-to-be."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Wedded to Princess Lena of the Kingdom o..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You kissed her hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[148]` (Narrator), `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "King Valero told you that he had no choice.   With Wehlen..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife = true;
EnableJournalEntry("Prologue_Marriage_Love");
EnableJournalEntry("Prologue_Marriage_VinaBirth");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_LovedWife"] = true;
EnableJournalEntry("Prologue_Marriage_Love");
EnableJournalEntry("Prologue_Marriage_VinaBirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that your royal duties left you too busy to spend time with family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad = true; EnableJournalEntry..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that your commitment to being a good husband and father sometimes meant you neglected your work."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_MarriageIssue_NeglectedWork");"*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that you couldn't stop yourself from having the occasional affair."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs = true; EnableJournalEntry("..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried your best to be a good father."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_MarriageIssue_GoodFather");"*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ignored your family and threw yourself into your work."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad = true; EnableJournalEntry..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...had a string of affairs."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs = true; EnableJournalEntry("..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "1933"]** — Mówca: **Narrator**
> "With Rumburg's help, Rizia's economy bounced back to levels it hadn't seen since the glory days of Queen Lyza.

Wealthy Rumburgians started moving to the cities. So did economic migrants from neighboring Morella and Derdia, and Wehzeks seeking asylum from the civil war.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Player_Romus), `[157]` (Player_Romus), `[152]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus: "...celebrated Rizia's new diversity."*)
  - -> `[160]` (*Player_Romus: "...were suspicious of these newcomers."*)
  - -> `[231]` (*Player_Romus: "...welcomed the new arrivals, but were secretly glad that..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs = true;
EnableJournalEntry("Prologue_MarriageIssue_Affairs");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_HadAffairs"] = true;
EnableJournalEntry("Prologue_MarriageIssue_Affairs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were suspicious of these newcomers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_Immigrants_Suspicion");"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "1939|Iza"]** — Mówca: **Narrator**
> "Many of the foreigners ended up in the province of Brenas, where a nationalist movement called Su Omina began demanding that the King put Rizia "above all".

As Duke of Iza, your uncle Hugo turned a blind eye to Su Omina's activities, while his teenage son Ricardus became a vocal supporter.

Eventually, Ricardus -- better known as Rico -- approached you about speaking at one of the group's rallies."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Player_Romus), `[160]` (Player_Romus), `[231]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You agreed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina = true; RiziaDLC.LeaningV..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You refused."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_SuOmina_Refused");"*)

### Węzeł `[164]`
Mówca: **Narrator**
> "You threw your weight behind Su Omina, increasing the group's legitimacy and following.

Your parents were displeased, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: "A few years passed."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...happily came along."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator), `[178]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StormAtSea");"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "You distanced yourself from the organization and from Rico. 

Your uncle was displeased, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: "A few years passed."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "1942|May|Monqiz"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "1942|May|Monqiz"*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...went, but only for your daughter's sake."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StormAtSea");"*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to get some work done instead."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator), `[178]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_BoatTrip_Worked");"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HadAffairs == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: "...decided to meet your latest lover instead."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HadAffairs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[175]`
**[WYBÓR GRACZA: "1942|May 20|Monqiz"]** — Mówca: **Narrator**
> "You were putting your clothes back on when you got the call.

The weather had turned stormy in the middle of the Gulf of Valenqiris. When the captain tried to turn the boat around, it was hit by a breaking wave and cracked in half.

The Coast Guard managed to save Vina on time. But by the time they pulled your wife out, she was barely breathing.

You rushed to the hospital."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A few years passed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Narrator), `[166]` (Narrator), `[335]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "1942|May|Monqiz"]** — Mówca: **Narrator**
> "You found yourself under more and more pressure to make up for your father's shortcomings. 

Lena was patient and understanding -- one of the many things you loved about her.

For her 10th birthday, Vina asked to go on a sailing trip with the two of you. You..."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[233]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: "...happily came along."*)
  - -> `[171]` (*Player_Romus: "...decided to get some work done instead."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "1942|May|Monqiz"]** — Mówca: **Narrator**
> "You found yourself under more and more pressure to make up for your father's shortcomings. 

Between that and your loveless marriage, you had few sources of joy in your life -- except for Vina.

For her 10th birthday, she asked you and Lena to take her on a sailing trip. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[233]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: "...happily came along."*)
  - -> `[170]` (*Player_Romus: "...went, but only for your daughter's sake."*)
  - -> `[171]` (*Player_Romus: "...decided to get some work done instead."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to meet your latest lover instead."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator), `[178]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_BoatTrip_Lover");"*)

### Węzeł `[180]`
**[WYBÓR GRACZA: "1942|May 20|Monqiz"]** — Mówca: **Narrator**
> "You were in your office when you got the call.

The weather had turned stormy in the middle of the Gulf of Valenqiris. When the captain tried to turn the boat around, it was hit by a breaking wave and cracked in half.

The coast guard managed to save Vina on time. But by the time they pulled your wife out, she was barely breathing.

You rushed to the hospital."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "1942|May 20|Monqiz"]** — Mówca: **Narrator**
> "In the middle of the Gulf of Valenqiris, the weather turned unexpectedly stormy. 

When the captain tried to turn the boat around, it was hit by a breaking wave and cracked in half.

The coast guard got to you and your daughter on time, but by the time they pulled Lena out, she was barely breathing.

They rushed her to the hospital."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Player_Romus), `[170]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: "She died holding your hand."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: "But it was too late."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "She died holding your hand."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator), `[180]` (Narrator), `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_WeddingRing");"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You began to get suspicious as well."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "1947|October|Porte Drazon"*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wondered what the country was coming to."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "1947|October|Porte Drazon"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;
EnableJournalEntry("Prologue_AxelVisit_Hostile");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_HostileToPales"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;
EnableJournalEntry("Prologue_AxelVisit_Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The duke was taken aback and ordered you to leave at once..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told your father about your trip."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator), `[31]` (Narrator), `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_AxelVisitReturn_Truth");"*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...lied to him about where you'd been."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator), `[31]` (Narrator), `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_AxelVisitReturn_Lied");"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "1948|October 8|Porte Drazon"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "1948|October 8|Porte Drazon"*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "The king was pleased you'd stood up to the duke, but furious you had gone behind his back.

He accused you of betrayal."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[189]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: "You assured him you were on his side."*)
  - -> `[198]` (*Player_Romus: "You begged for his forgiveness."*)
  - -> `[197]` (*Player_Romus: "You exploded at him for being an incompetent ruler."*)
  - -> `[196]` (*Player_Romus: "You said nothing and walked out."*)

### Węzeł `[195]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "The king was furious. He accused you of betrayal.

He ordered you to tell him about your meeting with the Duke."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[189]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: "You went against Duke Reinhart's wishes and gave your fat..."*)
  - -> `[301]` (*Player_Romus: "You kept your mouth shut."*)
  - -> `[197]` (*Player_Romus: "You exploded at him for being an incompetent ruler."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You said nothing and walked out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator), `[214]` (Narrator), `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "Valero banished you from his sights. You didn't speak to ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You exploded at him for being an incompetent ruler."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator), `[195]` (Narrator), `[213]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "Valero banished you from his sights. You didn't speak to ..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You begged for his forgiveness."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator), `[214]` (Narrator), `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "1949|November|Monqiz|Farewells"*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You assured him you were on his side."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Narrator), `[214]` (Narrator), `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "1949|November|Monqiz|Farewells"*)

### Węzeł `[200]`
**[WYBÓR GRACZA: "1949|November|Monqiz|Farewells"]** — Mówca: **Narrator**
> "As Vina grew into an intelligent, self-reliant young woman, your mother moved from Monqiz back to the capital.

She called you one night, her voice shaking."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: "The king was dying."*)

### Węzeł `[201]`
**[WYBÓR GRACZA: "1949|November|Monqiz|Farewells"]** — Mówca: **Narrator**
> "You had only occasional contact with your father in the months that followed.

As Vina grew into an intelligent, self-reliant young woman, your mother moved from Monqiz back to the capital.

She called you one night, her voice shaking."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Player_Romus), `[199]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: "The king was dying."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The king was dying."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator), `[201]` (Narrator), `[307]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_deadking");"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad = true;
EnableJournalEntry("Prologue_Axel_FatherFallout");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] = true;
EnableJournalEntry("Prologue_Axel_FatherFallout");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "1949|November|Monqiz|Farewells"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad = true;
EnableJournalEntry("Prologue_MarriageIssue_AbsentFather");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] = true;
EnableJournalEntry("Prologue_MarriageIssue_AbsentFather");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend = true; RiziaDLC.Relations_Pabel += 1;
EnableJournalEntry("Prologue_Pabel_Friends");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] = true;
Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;
EnableJournalEntry("Prologue_Pabel_Friends");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "You were cut off from the world beyond the palace walls, ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss = true; RiziaDLC.Relations_Pabel -= 1;
EnableJournalEntry("Prologue_Pabel_Boss");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] = true;
Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;
EnableJournalEntry("Prologue_Pabel_Boss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "You were cut off from the world beyond the palace walls, ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter = true;
EnableJournalEntry("Prologue_FatherDeath_Stay");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter"] = true;
EnableJournalEntry("Prologue_FatherDeath_Stay");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...refused to promise anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_AxelVisit_Neutral");"*)

### Węzeł `[209]`
Mówca: **Narrator**
> "The duke accepted your answer. Despite his disappointment, he invited you to spend the next few days getting to know him and the duchy better.

Afterwards, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_palesalt");"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "1948|October 8|Porte Drazon"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "1948|October 8|Porte Drazon"*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "A few days later, the King summoned you to the capital for a confrontation.

He'd had his personal security force, the Golden Guard, surveil you in Pales. 

He accused you of betrayal and ordered you to tell him about your meeting with the Duke."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: "You went against Duke Reinhart's wishes and gave your fat..."*)
  - -> `[301]` (*Player_Romus: "You kept your mouth shut."*)
  - -> `[197]` (*Player_Romus: "You exploded at him for being an incompetent ruler."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "A few days later, the King summoned you to the capital for a confrontation.

He'd had his personal security force, the Golden Guard, surveil you in Pales. 

He was pleased you'd stood up to the duke, but furious you had lied to him. He accused you of betrayal."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: "You assured him you were on his side."*)
  - -> `[198]` (*Player_Romus: "You begged for his forgiveness."*)
  - -> `[197]` (*Player_Romus: "You exploded at him for being an incompetent ruler."*)
  - -> `[196]` (*Player_Romus: "You said nothing and walked out."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina = true; RiziaDLC.LeaningValue_Democratic -= 1;
EnableJournalEntry("Prologue_SuOmina_Agreed");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableJournalEntry("Prologue_SuOmina_Agreed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "You threw your weight behind Su Omina, increasing the gro..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You declined."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_AxelInvitation_Declined");"*)

### Węzeł `[217]`
Mówca: **Narrator**
> "A few days later, you received a letter from Pales.

Duke Reinhart expressed his disappointment that you couldn't meet him, and wrote that he hoped to re-establish relations between Pales and Rizia once you took the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: "You showed it to the king."*)
  - -> `[219]` (*Player_Romus: "You kept it to yourself."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You showed it to the king."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meetking");"*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You kept it to yourself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "1948|October 8|Porte Drazon"*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "Valero thanked you for your honesty. He confided in you that you were one of the only people he trusted now.

He wrote back to Duke Reinhart that his ploy had failed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Prologu..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "A few days later, the King summoned you to the capital for a confrontation.

He'd ordered his personal security force, the Golden Guard, to begin inspecting family members' mail.

He accused you of betrayal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_AxelLetter_Lie");"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Arrests = true; 
RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.Resources_Authority += 1;
EnableJournalEntry("Prologue_Duke_Punish");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] = true;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
EnableJournalEntry("Prologue_Duke_Punish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "1930|June 20|Monqiz"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince = true; RiziaDLC.PersonalValue_BrokeTradition += 1;
RiziaDLC.Country_PublicOpinion += 1;
EnableJournalEntry("Prologue_Duke_Leisure");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] = true;
Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 1;
EnableJournalEntry("Prologue_Duke_Leisure");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "1930|June 20|Monqiz"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Rebuild = true; 
RiziaDLC.Resources_Budget += 1;
EnableJournalEntry("Prologue_Duke_Rebuild");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;
EnableJournalEntry("Prologue_Duke_Rebuild");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "1930|June 20|Monqiz"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident = true;
EnableJournalEntry("Prologue_BoatTrip_CameAlong");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] = true;
EnableJournalEntry("Prologue_BoatTrip_CameAlong");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "1942|May 20|Monqiz"*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...asked him about the protests."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Your father laughed and told you that some people had com..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DontPlayMapMusic();`
- **Efekt skryptowy (`userScript`):** `DontPlayMapMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "DontPlayMapAmbience();"*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In faith, you finally found solace."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_religious");"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious = true;
RiziaDLC.PersonalValue_Religious += 2;
EnableJournalEntry("Prologue_DeadWife_Religious");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Religious"] = true;
Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 2;
EnableJournalEntry("Prologue_DeadWife_Religious");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...celebrated Rizia's new diversity."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_Immigrants_Celebrate");"*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...welcomed the new arrivals, but were secretly glad that few of them settled in your province."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_Immigrants_Welcomed");"*)

### Węzeł `[232]`
**[WYBÓR GRACZA: "1942|Porte Drazon|Dark Horizons"]** — Mówca: **Narrator**
> "You slowly realized that the uprising had broken something in your father.

He began neglecting his duties as he became increasingly preoccupied with threats, both real and imaginary. 

Outside of the country, he gained a new nickname."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_frailking");"*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Valero the Frail.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FriendlyToPales = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
EnableJournalEntry("Prologue_AxelVisit_Friendly");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
EnableJournalEntry("Prologue_AxelVisit_Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The duke was satisfied with your answer. You spent the ne..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "1918|January 28|Porte Drazon|A New King"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "1920"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The council members took you under their wing, catching y..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "At the prestigious University of Iza, you studied history..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "At the prestigious Camp Domus academy in the mountains of..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("ProtestorsAngry");"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("DealSigning");"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "1927|Porte Drazon|A Changed Country"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RoyalWedding");"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RoyalWedding");"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_refugees");"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "1948|October|Porte Drazon"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "1949|November 18|Porte Drazon"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "1949|November 18|Porte Drazon"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: "Now, it was finally here."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_MetAxel = true;
EnableJournalEntry("Prologue_AxelInvitation_Accepted");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_MetAxel"] = true;
EnableJournalEntry("Prologue_AxelInvitation_Accepted");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "1948|October 5|Pales|Confrontations"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_kidnapping");"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Prologue_BetrayedAxel = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;
EnableJournalEntry("Prologue_AxelLetter_Truth");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_HostileToPales"] = true;
Variable["RiziaDLC.Prologue_BetrayedAxel"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;
EnableJournalEntry("Prologue_AxelLetter_Truth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: "You heard nothing from Pales after that."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_princebirth");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_princebirth");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: "It was your birthright."*)
  - -> `[45]` (*Player_Romus: "It was your burden."*)
  - -> `[46]` (*Player_Romus: "It was your calling."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_death of queen Lyza");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_death of queen Lyza");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "You remember two things about King Valero's coronation: t..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_children_playing");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_children_playing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: "...quickly became close friends."*)
  - -> `[5]` (*Player_Romus: "...enjoyed bossing him around."*)
  - -> `[61]` (*Player_Romus: "...didn't have much to do with each other."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_innercircle");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: "...that you would love to join."*)
  - -> `[64]` (*Player_Romus: "...to go to university instead."*)
  - -> `[65]` (*Player_Romus: "...to join the military instead."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_pales_war_begins");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_pales_war_begins");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_navy_mutiny");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_navy_mutiny");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: "The Century of Revolutions had reached Rizia at last."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_kidnapping");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_kidnapping");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: "Then, darkness."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_dealsigning");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_dealsigning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "1926|April 13|Porte Drazon"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_hanging");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_hanging");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: "...focused on finding and punishing the remaining traitor..."*)
  - -> `[15]` (*Player_Romus: "...largely ignored your duties and lived a life of leisure."*)
  - -> `[16]` (*Player_Romus: "...did your best to help your region rebuild."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_royalwedding");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_royalwedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: "You bowed."*)
  - -> `[150]` (*Player_Romus: "You kissed her hand."*)
  - -> `[8]` (*Player_Romus: "You demanded to know what was going on."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_refugees");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_refugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "1933"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suomina");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suomina");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: "You agreed."*)
  - -> `[334]` (*Player_Romus: "You attended, but did not speak."*)
  - -> `[163]` (*Player_Romus: "You refused."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_frailking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_frailking");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""Valero the Frail.""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sailboat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sailboat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident = true; EnableJournalEnt..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suomina2");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suomina2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: "You wondered what the country was coming to."*)
  - -> `[23]` (*Player_Romus: "You reasoned the King had brought his troubles on himself."*)
  - -> `[333]` (*Player_Romus: "You believed that things could be better."*)
  - -> `[186]` (*Player_Romus: "You began to get suspicious as well."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_palesvisit");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_palesvisit");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_MetAxel = true; EnableJournalEntry("Pro..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_palesalt");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_palesalt");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: "...told your father about your trip."*)
  - -> `[190]` (*Player_Romus: "...lied to him about where you'd been."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_letter");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_letter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "A few days later, you received a letter from Pales.  Duke..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meetking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: "You assured him you were on his side."*)
  - -> `[198]` (*Player_Romus: "You begged for his forgiveness."*)
  - -> `[197]` (*Player_Romus: "You exploded at him for being an incompetent ruler."*)
  - -> `[196]` (*Player_Romus: "You said nothing and walked out."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_deadking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_deadking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He'd gone straight to bed after dinner. When your mother ..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coronation");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coronation");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DontPlayMapAmbience();`
- **Efekt skryptowy (`userScript`):** `DontPlayMapAmbience();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_End");"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_gun_at_car");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_gun_at_car");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: "You complied with their demands."*)
  - -> `[131]` (*Player_Romus: "You tried to run away."*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sailboat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sailboat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "1942|May 20|Monqiz"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_sailboat");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_sailboat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "1942|May 20|Monqiz"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_mourning");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_mourning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "You were devastated.  After the funeral, your mother Este..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_religious");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_religious");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious = true; RiziaDLC.PersonalValu..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_mourning");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_mourning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "You mourned for a while.  But you also had a province to ..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meetking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "1948|October 8|Porte Drazon"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_monqiz");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_monqiz");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: "...visited your mother's common-born family at their home..."*)
  - -> `[49]` (*Player_Romus: "...stayed with the Queen at the royal residence in Porte ..."*)
  - -> `[50]` (*Player_Romus: "...went hunting with your father's brother Hugo in the fo..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meetking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meetking");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Monqiz");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_monqiz");"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("QueenDeath");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("QueenDeath");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_death of queen Lyza");"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("WarSpeech");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("WarSpeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_pales_war_begins");"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("ProtestorsAngry");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("ProtestorsAngry");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_navy_mutiny");"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Kidnap");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Kidnap");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_gun_at_car");"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("DealSigning");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("DealSigning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_dealsigning");"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Hanging");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Hanging");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_hanging");"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RoyalWedding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RoyalWedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "1932|March 1|A Family Man"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RoyalWedding");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RoyalWedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "1932|March 1|A Family Man"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SuOmina1");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SuOmina1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suomina");"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("StormAtSea");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("StormAtSea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sailboat");"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("StormAtSea");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("StormAtSea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sailboat");"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("StormAtSea");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("StormAtSea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_sailboat");"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SuOmina2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SuOmina2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suomina2");"*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You went against Duke Reinhart's wishes and gave your father every last detail."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Narrator), `[213]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Prologu..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You kept your mouth shut."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Narrator), `[213]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "Valero banished you from his sights. You didn't speak to ..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Prologue_BetrayedAxel = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= -1;
EnableJournalEntry("Prologue_Axel_FatherPloyFailed");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_HostileToPales"] = true;
Variable["RiziaDLC.Prologue_BetrayedAxel"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - -1;
EnableJournalEntry("Prologue_Axel_FatherPloyFailed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "Valero wrote to Duke Reinhart that his ploy had failed. Y..."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "Valero wrote to Duke Reinhart that his ploy had failed. You heard nothing from Pales after that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "1949|November|Monqiz|Farewells"*)

### Węzeł `[304]`
Mówca: **Narrator**
> "Valero banished you from his sights. You didn't speak to him at all in the months that followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad = true; EnableJournalEnt..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway = true;
EnableJournalEntry("Prologue_FatherLastWords_NoteDiscard");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] = true;
EnableJournalEntry("Prologue_FatherLastWords_NoteDiscard");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Only after his funeral, gathered at the palace with your ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter_ThrowAway = false;
EnableJournalEntry("Prologue_FatherLastWords_NoteKeep");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] = false;
EnableJournalEntry("Prologue_FatherLastWords_NoteKeep");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Only after his funeral, gathered at the palace with your ..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA: "1949|November|Monqiz|Farewells"]** — Mówca: **Narrator**
> "You stayed close with your father in the months that followed, though you were both too busy to see each other as often as you would have liked. 

As Vina grew into an intelligent, self-reliant young woman, your mother moved from Monqiz back to the capital.

She called you one night, her voice shaking."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Narrator), `[336]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: "The king was dying."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: "You tried to fight them."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: "You tried to fight them."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "There was a new king to crown."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("QueenDeath");"*)

### Węzeł `[312]`
Mówca: **Narrator**
> "You remember two things about King Valero's coronation: the whispers that Hugo, now the Duke of Valenqiris, was actually the rightful king. And the shouts of protesters outside the palace gates.

Alone with your father after the ceremony, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: "...asked him about the rumors."*)
  - -> `[226]` (*Player_Romus: "...asked him about the protests."*)
  - -> `[56]` (*Player_Romus: "...didn't mention either."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It felt good to have caring relatives."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator), `[52]` (Narrator), `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_WeddingRing");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_WeddingRing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_mourning");"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PalesVisit");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PalesVisit");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_palesvisit");"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_MainTheme", "R_MainTheme_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_MainTheme","R_MainTheme_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "DontPlayMapMusic();"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SuOmina1");"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("RiziaPrologue_Finish");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("RiziaPrologue_Finish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_MainTheme", "R_MainTheme_Loop");"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "1942|Porte Drazon|Dark Horizons"*)

### Węzeł `[320]`
**[WYBÓR GRACZA: "1947|October|Porte Drazon"]** — Mówca: **Narrator**
> "Even with Hugo advising him as Grand Vizier, King Valero seemed powerless to address the escalating tensions. 

Hugo suggested to the King that you be entrusted with certain responsibilities. Upon agreement from the King and the Royal Council, you were granted the opportunity to aid as the Crown Prince. 

You chose to concentrate on..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Player_Romus), `[186]` (Player_Romus), `[187]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player_Romus: "...enforcing internal security and the passing of necessa..."*)
  - -> `[330]` (*Player_Romus: "...strengthening the armed forces and building new milita..."*)
  - -> `[323]` (*Player_Romus: "...increasing gold extraction and improving tax efficiency."*)
  - -> `[324]` (*Player_Romus: "...enhancing the extraction of oil, coal, and gas."*)
  - -> `[325]` (*Player_Romus: "...spearheading a public relations campaign to boost nati..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_SecurityCouncil = true;
RiziaDLC.Resources_Authority += 2;
EvaluateConditionalInstruction("DrugTrade_Start");
RiziaDLC.Country_DrugTrade -= 1;
RiziaDLC.Authority_Modifier_BaseMonarchRomus += 1;
RiziaDLC.Country_PublicOpinion += 1;
EnableJournalEntry("Prologue_HelpFather_Security");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;
EvaluateConditionalInstruction("DrugTrade_Start");
Variable["RiziaDLC.Country_DrugTrade"] = Variable["RiziaDLC.Country_DrugTrade"] - 1;
Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] = Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] + 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 1;
EnableJournalEntry("Prologue_HelpFather_Security");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...enforcing internal security and the passing of necessary royal decrees."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_SecurityCouncil = true; RiziaDLC...."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...increasing gold extraction and improving tax efficiency."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_TreasuryFinances = true; RiziaDLC..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...enhancing the extraction of oil, coal, and gas."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_EnergyIndustry = true; RiziaDLC.R..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...spearheading a public relations campaign to boost national opinion of the Royal Family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_PRCampaign = true; RiziaDLC.Resou..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_TreasuryFinances = true;
RiziaDLC.Resources_Budget += 3;
RiziaDLC.Country_PublicOpinion -= 2;
RiziaDLC.Budget_Modifier_RizianGoldIndustry += 1;
EnableJournalEntry("Prologue_HelpFather_GoldExtractionAndTaxEfficiency");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 3;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 2;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] + 1;
EnableJournalEntry("Prologue_HelpFather_GoldExtractionAndTaxEfficiency");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_EnergyIndustry = true;
RiziaDLC.Resources_Energy += 2;
RiziaDLC.Energy_Modifier_BaseEnergy += 1;
RiziaDLC.LeaningValue_ProBusiness += 1;
RiziaDLC.Country_Tourism -= 1;
EnableJournalEntry("Prologue_HelpFather_EnergyProduction");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] = true;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 2;
Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] = Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] + 1;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] + 1;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] - 1;
EnableJournalEntry("Prologue_HelpFather_EnergyProduction");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_PRCampaign = true;
RiziaDLC.Resources_Authority += 1;
RiziaDLC.Country_Tourism += 1;
RiziaDLC.PersonalValue_BrokeTradition -= 1;
RiziaDLC.Country_PublicOpinion += 5;
EnableJournalEntry("Prologue_HelpFather_PublicRelations");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_PRCampaign"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] + 1;
Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] - 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 5;
EnableJournalEntry("Prologue_HelpFather_PublicRelations");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "1946|August|Porte Drazon"*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...strengthening the armed forces and building new military formations."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Focus_ArmedForces = true; RiziaDLC.Army..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Focus_ArmedForces = true;
RiziaDLC.Army_Unit_Support_Total += 2;
RiziaDLC.Army_Unit_Tank_Total += 1;
RiziaDLC.Resources_Military_Ships += 1;
RiziaDLC.Resources_Military_Equipment += 1000;
RiziaDLC.Resources_Military_Manpower += 500;
EnableJournalEntry("Prologue_HelpFather_ArmedForces");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] = true;
Variable["RiziaDLC.Army_Unit_Support_Total"] = Variable["RiziaDLC.Army_Unit_Support_Total"] + 2;
Variable["RiziaDLC.Army_Unit_Tank_Total"] = Variable["RiziaDLC.Army_Unit_Tank_Total"] + 1;
Variable["RiziaDLC.Resources_Military_Ships"] = Variable["RiziaDLC.Resources_Military_Ships"] + 1;
Variable["RiziaDLC.Resources_Military_Equipment"] = Variable["RiziaDLC.Resources_Military_Equipment"] + 1000;
Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] + 500;
EnableJournalEntry("Prologue_HelpFather_ArmedForces");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The world seemed dull and meaningless."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You believed that things could be better."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "1947|October|Porte Drazon"*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You attended, but did not speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "EnableJournalEntry("Prologue_SuOmina_Attended");"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "You watched as the organizations' leaders bemoaned the loss of Rizian territory, identity and values.

They stopped just short of blaming King Valero directly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: "A few years passed."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You heard nothing from Pales after that."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "1949|November|Monqiz|Farewells"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_Kidnapping_Comply");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_Kidnapping_Comply");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_Kidnapping_Fight");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_Kidnapping_Fight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_Marriage_DontLove");
EnableJournalEntry("Prologue_Marriage_VinaBirth");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_Marriage_DontLove");
EnableJournalEntry("Prologue_Marriage_VinaBirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_MarriageIssue_NeglectedWork");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_MarriageIssue_NeglectedWork");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_MarriageIssue_GoodFather");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_MarriageIssue_GoodFather");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_Immigrants_Celebrate");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_Immigrants_Celebrate");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "1939|Iza"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_Immigrants_Suspicion");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_Immigrants_Suspicion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "1939|Iza"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_Immigrants_Welcomed");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_Immigrants_Welcomed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "1939|Iza"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_SuOmina_Attended");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_SuOmina_Attended");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "You watched as the organizations' leaders bemoaned the lo..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_SuOmina_Refused");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_SuOmina_Refused");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "You distanced yourself from the organization and from Ric..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_BoatTrip_Worked");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_BoatTrip_Worked");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StormAtSea");"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_BoatTrip_Lover");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_BoatTrip_Lover");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StormAtSea");"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_AxelInvitation_Declined");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_AxelInvitation_Declined");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_letter");"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_AxelVisit_Neutral");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_AxelVisit_Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The duke accepted your answer. Despite his disappointment..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_AxelVisitReturn_Lied");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_AxelVisitReturn_Lied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meetking");"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_AxelVisitReturn_Truth");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_AxelVisitReturn_Truth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meetking");"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_AxelLetter_Lie");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_AxelLetter_Lie");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meetking");"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter = false;
EnableJournalEntry("Prologue_FatherDeath_Visit");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter"] = false;
EnableJournalEntry("Prologue_FatherDeath_Visit");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_FatherLastWords_Hear");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_FatherLastWords_Hear");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Only after his funeral, gathered at the palace with your ..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_End");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_End");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableJournalEntry("Prologue_WehlenRescue");`
- **Efekt skryptowy (`userScript`):** `EnableJournalEntry("Prologue_WehlenRescue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Visiting their common-born family", "Family Home", "Zille Province");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Visiting their common-born family","Family Home","Zille Province");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille = true; RiziaDLC.Diplomacy..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Spending summers with Queen Lyza", "Royal residence", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Spending summers with Queen Lyza","Royal residence","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Court = true; EnableJournalEntry..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Hunting with Uncle Hugo", "forest", "Brenas Province");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Hunting with Uncle Hugo","forest","Brenas Province");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo = true; RiziaDLC.Relations_..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Pushing the groundskeeper’s kid around", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Pushing the groundskeeper’s kid around","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss = true; RiziaDLC.Re..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Making a lifelong friend in the palace gardens", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Making a lifelong friend in the palace gardens","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend = true; RiziaDLC...."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Stepping into the Royal Council as the king's heir", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Stepping into the Royal Council as the king's heir","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil = true; RiziaDLC.Countr..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Being dragged away by masked men", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Being dragged away by masked men","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Kidnap");"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Wedded to Princess Lena of the Kingdom of Rumburg", "Plavo Archsanctuary", "Plavo");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Wedded to Princess Lena of the Kingdom of Rumburg","Plavo Archsanctuary","Plavo");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_royalwedding");"*)

### Węzeł `[366]`
Mówca: **Narrator**
> "You were cut off from the world beyond the palace walls, but it gave you more time for self-reflection.

During those formative years, you realized..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: "…you desired an easy life, one where you seized every adv..."*)
  - -> `[368]` (*Player_Romus: "…your royal privilege came with unbelievable pressure, an..."*)
  - -> `[369]` (*Player_Romus: "…the years ahead would be full of challenges, but they wo..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA: "…you desired an easy life, one where you seized every advantage you were entitled to. [Easier Resources]"]** — Mówca: **Player_Romus**
> "…you desired an easy life, one where you seized every advantage you were entitled to."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_EasyLife = true;  RiziaDLC.Authority_Mo..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "…your royal privilege came with unbelievable pressure, and balancing the two would be your life's work."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_NormalLife = true;"*)

### Węzeł `[369]`
**[WYBÓR GRACZA: "…the years ahead would be full of challenges, but they would make your triumphs all the sweeter. [Harder Resources]"]** — Mówca: **Player_Romus**
> "…the years ahead would be full of challenges, but they would make your triumphs all the sweeter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HardLife = true;  RiziaDLC.Authority_Mo..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_EasyLife = true; 
RiziaDLC.Authority_Modifier_BaseMonarchRomus += 4;
RiziaDLC.Energy_Modifier_BaseEnergy += 3;
RiziaDLC.Budget_Modifier_RizianGoldIndustry += 2;
RiziaDLC.Country_PublicOpinion += 5;
RiziaDLC.Resources_Energy += 3;
RiziaDLC.Resources_Budget += 4;
// House relations and Religious groups in cond.instr.`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_EasyLife"] = true;
Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] = Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] + 4;
Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] = Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] + 3;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] + 2;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 5;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 3;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;
-- House relations and Religious groups in cond.instr.;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "1923|September"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_NormalLife = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_NormalLife"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "1923|September"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HardLife = true; 
RiziaDLC.Authority_Modifier_BaseMonarchRomus -= 3;
RiziaDLC.Energy_Modifier_BaseEnergy -= 1;
RiziaDLC.Budget_Modifier_RizianGoldIndustry -= 1;
RiziaDLC.Country_PublicOpinion -= 3;
RiziaDLC.Resources_Energy -= 3;
RiziaDLC.Resources_Budget -= 2;
// House relations and Religious groups in cond.instr.`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Prologue_HardLife"] = true;
Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] = Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] - 3;
Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] = Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] - 1;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] - 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 3;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] - 3;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
-- House relations and Religious groups in cond.instr.;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "1923|September"*)
