# Sordland/Turn08/A_AschrafAnniversary

- **ID konwersacji:** `144`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/144_A_AschrafAnniversary.md`
- **Liczba węzłów dialogowych:** 471
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.BFF_Threatens_President`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction`
- `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle`
- `BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary_Security`
- `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Negative`
- `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Positive`
- `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Security`
- `GameCondition.Turn08_A_AschrafAnniversary`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"“I hope so.”"** | `[10]` **Lucian Galade**: "“I must say this was a good deci..."<br>`[185]` **Lucian Galade**: "“I must say this was a good deci..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucian Galade**: "“If we play our cards right, I a..." |
| `[11]` | **"“Better safe than sorry.”"** | `[10]` **Lucian Galade**: "“I must say this was a good deci..."<br>`[252]` **Lucian Galade**: "“I must say this was a good deci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Lucian Galade**: "“I agree.”" |
| `[12]` | **"“That was my intention all along.”"** | `[10]` **Lucian Galade**: "“I must say this was a good deci..."<br>`[185]` **Lucian Galade**: "“I must say this was a good deci..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucian Galade**: "“As expected.”" |
| `[40]` | **"“No need for pleasantries. I want this over with as quickly as possible.”"** | `[14]` **Mansoun Leke**: "“Welcome to Erzaren, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[46]` **Narrator**: "He pointed at the security guard..."<br>`[269]` **Narrator**: "He pointed at the gendarmerie fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[41]` | **"“It looks like I am not welcome here, Mr. Leke.”"** | `[14]` **Mansoun Leke**: "“Welcome to Erzaren, Mr. Preside..." | `Variable["BaseGame.Bludish_Opinion"] <= 0` | *Brak zmian stanu* | `[207]` **Mansoun Leke**: "“Very perceptive of you. I wonde..."<br>`[42]` **Mansoun Leke**: "“Very perceptive of you. But tha..." |
| `[48]` | **"“They are here for protection.”"** | `[47]` **Mansoun Leke**: "“I am not sure how bringing your..."<br>`[270]` **Mansoun Leke**: "“I am not sure how bringing your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Mansoun Leke**: "“Protection from your own citize..." |
| `[49]` | **"“They are not my personal army. They protect the government.”"** | `[47]` **Mansoun Leke**: "“I am not sure how bringing your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Mansoun Leke**: "“I see. The government must have..." |
| `[50]` | **"“Let's *go*.”"** | `[47]` **Mansoun Leke**: "“I am not sure how bringing your..."<br>`[270]` **Mansoun Leke**: "“I am not sure how bringing your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Mansoun Leke**: "“On a day like this, when you wa..." |
| `[52]` | **"Shake his hand."** | `[14]` **Mansoun Leke**: "“Welcome to Erzaren, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[46]` **Narrator**: "He pointed at the security guard..."<br>`[269]` **Narrator**: "He pointed at the gendarmerie fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[53]` | **"Take his hand and raise it in a display of unity."** | `[14]` **Mansoun Leke**: "“Welcome to Erzaren, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "I heard shouts in Bludish coming..."<br>`[58]` **Narrator**: "I heard some applause from the c..." |
| `[67]` | **"Pick up a candle."** | `[66]` **Narrator**: "Mansoun gestured towards the can..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Re...` | `[71]` **Narrator**: "He picked up the candle for Asch..." |
| `[68]` | **"Pick up the red candle."** | `[66]` **Narrator**: "Mansoun gestured towards the can..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_As...` | `[70]` **Narrator**: "He also picked up a candle and s..." |
| `[69]` | **"Do not pick a candle."** | `[66]` **Narrator**: "Mansoun gestured towards the can..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[72]` **Narrator**: "He picked up the candle for Asch..." |
| `[86]` | **"Light the torch."** | `[84]` **Narrator**: "When we arrived, he pointed at a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Narrator**: "I turned around and realized the..." |
| `[87]` | **"Light the torch together with Mansoun."** | `[84]` **Narrator**: "When we arrived, he pointed at a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[88]` **Narrator**: "I turned around and realized the..." |
| `[89]` | **"“My fellow citizens.”"** | `[435]` **Player_Italic**: "I ignored them and started my sp..."<br>`[446]` **Lucian Galade**: ""Good luck, sir.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.BFF_Threatens_President"] == true) == false` | *Brak zmian stanu* | `[91]` **Player**: "“We are here to mourn Watani Asc..."<br>`[283]` **Player**: "“We are here to mourn those who,..." |
| `[90]` | **"“Brothers and sisters.”"** | `[435]` **Player_Italic**: "I ignored them and started my sp..."<br>`[446]` **Lucian Galade**: ""Good luck, sir.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.BFF_Threatens_President"] == true) == false` | *Brak zmian stanu* | `[91]` **Player**: "“We are here to mourn Watani Asc..."<br>`[283]` **Player**: "“We are here to mourn those who,..." |
| `[91]` | **"“We are here to mourn Watani Aschraf and many others who have lost their lives.”"** | `[89]` **Player**: "“My fellow citizens.”"<br>`[90]` **Player**: "“Brothers and sisters.”"<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false` | *Brak zmian stanu* | `[98]` **Player**: "“I am not standing before you to..."<br>`[97]` **Player**: "“They were brave men and women w..."<br>*(oraz 1 innych odgałęzień)* |
| `[92]` | **"“Free people of Bludia.”"** | `[435]` **Player_Italic**: "I ignored them and started my sp..."<br>`[446]` **Lucian Galade**: ""Good luck, sir.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.BFF_Threatens_President"] == true) == false` | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...`<br>`Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[91]` **Player**: "“We are here to mourn Watani Asc..."<br>`[283]` **Player**: "“We are here to mourn those who,..." |
| `[93]` | **"“Let me tell you one thing. I dream of a truly united Sordland. A country where be..."** | `[117]` **Player**: "“Don't play into the hands of th..."<br>`[118]` **Player_Italic**: "I paid no attention."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: "“I feel responsible and ashamed ..."<br>`[104]` **Player**: "“Let this be a testament of our ..."<br>*(oraz 1 innych odgałęzień)* |
| `[94]` | **"Signal the security to detain him."** | `[28]` **Narrator**: "As our convoy slowed down, a you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Narrator**: "There was an outcry from the cro..."<br>`[96]` **Narrator**: "Seeing the boy get dragged away ..." |
| `[95]` | **"Do not do anything."** | `[28]` **Narrator**: "As our convoy slowed down, a you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Our vehicle came to a stop." |
| `[97]` | **"“They were brave men and women who only wanted to protect their land.”"** | `[91]` **Player**: "“We are here to mourn Watani Asc..."<br>`[283]` **Player**: "“We are here to mourn those who,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[102]` **Player**: "“Despite attempts to divide us, ..."<br>`[100]` **Player**: "“I share your hatred and anger. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[98]` | **"“I am not standing before you today as the President. I am standing here as one of..."** | `[91]` **Player**: "“We are here to mourn Watani Asc..."<br>`[283]` **Player**: "“We are here to mourn those who,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "“Despite attempts to divide us, ..."<br>`[100]` **Player**: "“I share your hatred and anger. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **"“I condemn the events that led to the loss of these lives.”"** | `[91]` **Player**: "“We are here to mourn Watani Asc..."<br>`[283]` **Player**: "“We are here to mourn those who,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Player**: "“Despite attempts to divide us, ..."<br>`[100]` **Player**: "“I share your hatred and anger. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **"“I share your hatred and anger. I feel it too, I assure you. Like a red-hot iron, ..."** | `[98]` **Player**: "“I am not standing before you to..."<br>`[99]` **Player**: "“I condemn the events that led t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "An old man from the crowd yelled..."<br>`[131]` **Narrator**: "An old man from the crowd yelled..." |
| `[101]` | **"“I assure you, this administration will do its absolute best to mend the wounds.”"** | `[98]` **Player**: "“I am not standing before you to..."<br>`[99]` **Player**: "“I condemn the events that led t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "An old man from the crowd yelled..."<br>`[135]` **Narrator**: "An old man from the crowd yelled..." |
| `[102]` | **"“Despite attempts to divide us, our people will stand as one. We are Sord. We are ..."** | `[98]` **Player**: "“I am not standing before you to..."<br>`[99]` **Player**: "“I condemn the events that led t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "An old man from the crowd yelled..."<br>`[127]` **Narrator**: "An old man from the crowd yelled..." |
| `[103]` | **"“We are all the same before God. Remember the words: 'Love thy brothers and thy si..."** | `[117]` **Player**: "“Don't play into the hands of th..."<br>`[118]` **Player_Italic**: "I paid no attention."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: "“I feel responsible and ashamed ..."<br>`[104]` **Player**: "“Let this be a testament of our ..."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **"“Let this be a testament of our unity for future generations! Let's stand together..."** | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...`<br>`Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....`<br>*(+1 skryptów)* | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..."<br>*(oraz 1 innych odgałęzień)* |
| `[105]` | **"“I feel responsible and ashamed for the actions of my predecessors. Most of all, I..."** | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....`<br>`Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...`<br>*(+2 skryptów)* | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..."<br>*(oraz 1 innych odgałęzień)* |
| `[106]` | **"“We must always stay together in the face of adversity. Against all odds.”"** | `[117]` **Player**: "“Don't play into the hands of th..."<br>`[118]` **Player_Italic**: "I paid no attention."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: "“I feel responsible and ashamed ..."<br>`[104]` **Player**: "“Let this be a testament of our ..."<br>*(oraz 1 innych odgałęzień)* |
| `[107]` | **"“Mistakes were made. The innocent people of Izzam paid the price. But we cannot le..."** | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..."<br>*(oraz 1 innych odgałęzień)* |
| `[108]` | **"“I need help from each and every one of you. To make this country a better place f..."** | `[107]` **Player**: "“Mistakes were made. The innocen..."<br>`[104]` **Player**: "“Let this be a testament of our ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Media_Censored"] == true` | *Brak zmian stanu* | `[138]` **Player**: "“Are you with me?”"<br>`[111]` **Player**: "“Morning will come!”"<br>*(oraz 2 innych odgałęzień)* |
| `[109]` | **"“The responsibility falls on all of our shoulders. Because we don't have anyone bu..."** | `[107]` **Player**: "“Mistakes were made. The innocen..."<br>`[104]` **Player**: "“Let this be a testament of our ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Media_Censored"] == true` | *Brak zmian stanu* | `[138]` **Player**: "“Are you with me?”"<br>`[111]` **Player**: "“Morning will come!”"<br>*(oraz 2 innych odgałęzień)* |
| `[110]` | **"“Yollak Bluderat!”"** | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..." | `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true` | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...`<br>`Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[113]` **Narrator**: "There was no reaction from the c..." |
| `[111]` | **"“Morning will come!”"** | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[113]` **Narrator**: "There was no reaction from the c..." |
| `[112]` | **"“Thank you.”"** | `[107]` **Player**: "“Mistakes were made. The innocen..."<br>`[104]` **Player**: "“Let this be a testament of our ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Media_Censored"] == true` | *Brak zmian stanu* | `[113]` **Narrator**: "There was no reaction from the c..." |
| `[117]` | **"“Don't play into the hands of the separationists. United we stand. Divided we fall.”"** | `[114]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[118]` | **"Pay no attention."** | `[114]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[119]` | **"“To what end? We need to break this vicious cycle of violence and vengeance for a ..."** | `[115]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[120]` | **"Pay no attention."** | `[115]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[121]` | **"Pay no attention."** | `[116]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[122]` | **"“Despite these kinds of attempts to divide us, we will be united as one. We will w..."** | `[116]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[123]` | **"“Let me finish.”"** | `[116]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[136]` | **"“Let me finish.”"** | `[114]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[137]` | **"“Let me finish.”"** | `[115]` **Narrator**: "An old man from the crowd yelled..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: "“Let me tell you one thing. I dr..."<br>`[103]` **Player**: "“We are all the same before God...."<br>*(oraz 1 innych odgałęzień)* |
| `[138]` | **"“Are you with me?”"** | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "There was no reaction from the c..." |
| `[161]` | **"“Thank you.”"** | `[160]` **Mansoun Leke**: "“I must admit, Mr. President. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "He extended his hand to me for a..." |
| `[162]` | **"“Just doing my duty.”"** | `[160]` **Mansoun Leke**: "“I must admit, Mr. President. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "He extended his hand to me for a..." |
| `[163]` | **"“I hope the crowd thinks the same.”"** | `[160]` **Mansoun Leke**: "“I must admit, Mr. President. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "He extended his hand to me for a..." |
| `[165]` | **"Shake his hand."** | `[164]` **Narrator**: "He extended his hand to me for a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Mansoun Leke**: "“Thank you, Mr. President.”"<br>`[167]` **Mansoun Leke**: "“Thank you for this, Mr. Preside..." |
| `[166]` | **"Hug him."** | `[164]` **Narrator**: "He extended his hand to me for a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Mansoun Leke**: "“Thank you, Mr. President.”"<br>`[167]` **Mansoun Leke**: "“Thank you for this, Mr. Preside..." |
| `[173]` | **"“What's the rush?”"** | `[172]` **Lucian Galade**: "“Well done, sir. This will prove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Lucian Galade**: "“The whole trip runs on a schedu..." |
| `[174]` | **"“Exactly my plan.”"** | `[172]` **Lucian Galade**: "“Well done, sir. This will prove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Narrator**: "Lucian bowed his head." |
| `[175]` | **"“Time will tell.”"** | `[172]` **Lucian Galade**: "“Well done, sir. This will prove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Narrator**: "Lucian bowed his head." |
| `[186]` | **"“Yes. But I am still worried about our safety.”"** | `[185]` **Lucian Galade**: "“I must say this was a good deci..."<br>`[256]` **Lucian Galade**: "“I must say this was a good deci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucian Galade**: "“It is certainly risky. But if w..." |
| `[237]` | **"Keep walking."** | `[463]` **Narrator**: "<shout>"Have respect for the dea..."<br>`[465]` **Narrator**: "<shout>"Don't mock the dead, you..." | `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false` | *Brak zmian stanu* | `[84]` **Narrator**: "When we arrived, he pointed at a..."<br>`[85]` **Narrator**: "When we arrived, Mansoun lit the..." |
| `[238]` | **"Signal security to detain him."** | `[463]` **Narrator**: "<shout>"Have respect for the dea..."<br>`[465]` **Narrator**: "<shout>"Don't mock the dead, you..." | `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false` | *Brak zmian stanu* | `[239]` **Narrator**: "Mansoun looked at me with a mix ..." |
| `[271]` | **"“It's the governor's doing.”"** | `[270]` **Mansoun Leke**: "“I am not sure how bringing your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Mansoun Leke**: "“The man who abuses his authorit..." |
| `[272]` | **"“They are not my army. They protect the Special Region of Bergia.”"** | `[270]` **Mansoun Leke**: "“I am not sure how bringing your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Mansoun Leke**: "“I see. The government must have..." |
| `[274]` | **"“Let's just move on, Mr. Leke.”"** | `[273]` **Mansoun Leke**: "“The man who abuses his authorit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "He clenched his jaw." |
| `[275]` | **"“I am supportive of you, Mr. Leke. I want him gone as much as you.”"** | `[273]` **Mansoun Leke**: "“The man who abuses his authorit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "He clenched his jaw." |
| `[276]` | **"“We are trying our best to contain him, but without changing the laws there's noth..."** | `[273]` **Mansoun Leke**: "“The man who abuses his authorit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "He clenched his jaw." |
| `[278]` | **"“My only intention is to stand in solidarity with our Bludish people.”"** | `[261]` **Mansoun Leke**: "“I suppose the governor's huge a..."<br>`[265]` **Mansoun Leke**: "“I don't know what your intentio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "He raised an eyebrow." |
| `[279]` | **"“Let's just move on, Mr. Leke.”"** | `[261]` **Mansoun Leke**: "“I suppose the governor's huge a..."<br>`[265]` **Mansoun Leke**: "“I don't know what your intentio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "He clenched his jaw." |
| `[280]` | **"“Watch your words. You are speaking to the president.”"** | `[261]` **Mansoun Leke**: "“I suppose the governor's huge a..."<br>`[265]` **Mansoun Leke**: "“I don't know what your intentio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "He clenched his jaw." |
| `[282]` | **"Leave the candle next to it."** | `[84]` **Narrator**: "When we arrived, he pointed at a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Narrator**: "I turned around and realized the..." |
| `[283]` | **"“We are here to mourn those who, tragically, lost their lives in Izzam.”"** | `[89]` **Player**: "“My fellow citizens.”"<br>`[90]` **Player**: "“Brothers and sisters.”"<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false` | *Brak zmian stanu* | `[98]` **Player**: "“I am not standing before you to..."<br>`[97]` **Player**: "“They were brave men and women w..."<br>*(oraz 1 innych odgałęzień)* |
| `[287]` | **"“To our unity!”"** | `[108]` **Player**: "“I need help from each and every..."<br>`[109]` **Player**: "“The responsibility falls on all..." | `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false` | *Brak zmian stanu* | `[113]` **Narrator**: "There was no reaction from the c..." |
| `[290]` | **"“Not everything is about votes.”"** | `[172]` **Lucian Galade**: "“Well done, sir. This will prove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lucian Galade**: "“It's not?”" |
| `[314]` | **"“I'm glad I brought this much security.”"** | `[313]` **Lucian Galade**: "“That was close.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Narrator**: "We entered our vehicles and star..." |
| `[315]` | **"“They will pay for this.”"** | `[313]` **Lucian Galade**: "“That was close.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Narrator**: "We entered our vehicles and star..." |
| `[316]` | **"“We should have been more careful.”"** | `[313]` **Lucian Galade**: "“That was close.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Narrator**: "We entered our vehicles and star..." |
| `[352]` | **"“That boy! Make sure he is okay!”"** | `[322]` **Narrator**: "A woman, probably his mother, fe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "Everything became a blur. The gu..." |
| `[353]` | **"“My God.”"** | `[322]` **Narrator**: "A woman, probably his mother, fe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "Everything became a blur. The gu..." |
| `[354]` | **"“Get an ambulance now!”"** | `[322]` **Narrator**: "A woman, probably his mother, fe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "Everything became a blur. The gu..." |
| `[355]` | **"“We have to get out of here.”"** | `[322]` **Narrator**: "A woman, probably his mother, fe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "Everything became a blur. The gu..." |
| `[434]` | **"Signal to Lucian."** | `[433]` **Narrator**: "Just then, I noticed a few BFF f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Lucian Galade**: ""Is there something wrong, sir?"" |
| `[435]` | **"Start the speech."** | `[433]` **Narrator**: "Just then, I noticed a few BFF f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Player**: "“Brothers and sisters.”"<br>`[89]` **Player**: "“My fellow citizens.”"<br>*(oraz 1 innych odgałęzień)* |
| `[437]` | **""There are people in the crowd with BFF flags. I thought security wouldn't allow s..."** | `[436]` **Lucian Galade**: ""Is there something wrong, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Lucian Galade**: ""Are you sure, sir? I can't see ..." |
| `[438]` | **""I'm not sure if I should continue with the speech, Lucian. I think we might be in..."** | `[436]` **Lucian Galade**: ""Is there something wrong, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Lucian Galade**: ""Do you want to cancel the speec..." |
| `[439]` | **""I saw some BFF flags. Could you please check if everything's all right?""** | `[436]` **Lucian Galade**: ""Is there something wrong, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Lucian Galade**: ""Are you sure, sir? The police w..." |
| `[444]` | **""Okay, never mind. I'll continue with the speech.""** | `[443]` **Narrator**: "The crowd was getting restless." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Lucian Galade**: ""Good luck, sir."" |
| `[445]` | **""Yes. I want to cancel the speech. Let's leave this place immediately.""** | `[443]` **Narrator**: "The crowd was getting restless." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_Cr...` | `[448]` **Lucian Galade**: ""Of course, sir. Please follow me."" |

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
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The city had been of particular importance to the Bludish people ever since the Izzam Incident and the death of Watani Aschraf over two decades ago. Today, we were here to commemorate the anniversary of those events."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "The ceremonies were to be held in the aptly named Izzam S..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Our massive convoy could barely fit through the narrow streets, disrupting local traffic and creating noisy chaos in the usually tranquil city. Pedestrians stared at us in fear as we and our heavily armed security forces drove towards the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion -= 1"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == false"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Our convoy could barely fit through the narrow streets, disrupting local traffic and creating noisy chaos in the usually tranquil city. Pedestrians stared at us with concern as we and our security forces drove towards the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“I hope so.”"]** — Mówca: **Player**
> "“I hope so.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade), `[185]` (Lucian Galade), `[252]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: "“If we play our cards right, I am certain.”"*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. This will help ease the tensions. But I hope bringing this much security won't cause any problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“Better safe than sorry.”"*)
  - -> `[9]` (*Player: "“I hope so.”"*)
  - -> `[12]` (*Player: "“That was my intention all along.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Better safe than sorry.”"]** — Mówca: **Player**
> "“Better safe than sorry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade), `[252]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“I agree.”"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“That was my intention all along.”"]** — Mówca: **Player**
> "“That was my intention all along.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade), `[185]` (Lucian Galade), `[252]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“As expected.”"*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“We are almost there. I can hear the crowd.”"*)

### Węzeł `[14]`
Mówca: **Mansoun Leke**
> "“Welcome to Erzaren, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[40]` (*Player: "“No need for pleasantries. I want this over with as quick..."*)
  - -> `[53]` (*Player_Italic: "Take his hand and raise it in a display of unity."*)
  - -> `[52]` (*Player_Italic: "Shake his hand."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“It is certainly risky. But if we manage to win some hearts today, it will be worth it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“We are almost there. I can hear the crowd.”"*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“If we play our cards right, I am certain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“We are almost there. I can hear the crowd.”"*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“As expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“We are almost there. I can hear the crowd.”"*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“We are almost there. I can hear the crowd.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I heard the chants and shouting from outside. Lucian lean..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "I heard the chants and shouting from the outside. Lucian ..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“They are telling us to go back where we came from.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I heard the chants and shouting from outside. Lucian leaned closer to the window, listening to their voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“They are telling us to go back where we came from.”"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "I heard the chants and shouting from the outside. Lucian leaned closer to the window, listening to their voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“They seem to be chanting 'Yollak Bluderat'. I believe that means 'Free Bludia' in Bludish, or something of that sort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "A large crowd had assembled in the square. There were probably at least ten thousand people. Most of them were yelling insults and obscenities at me. I heard a few shouts of "Soll's boot licker!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "As our convoy slowed down, a young Bludish man ran in fro..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "A large crowd had assembled in the square. There were probably at least ten thousand people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Our vehicle came to a stop."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "As our convoy slowed down, a young Bludish man ran in front of our vehicle and spat on my window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Italic: "Signal the security to detain him."*)
  - -> `[95]` (*Player_Italic: "Do not do anything."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“Mr. Leke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Mansoun Leke: "“Mr. Galade. Welcome. Shall we move on to the Sanctuary, ..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Our vehicle came to a stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The security detail left their vehicles with their machin..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "My driver exited the vehicle and opened the door for me."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The security detail left their vehicles with their machine guns openly displayed. I followed them. The crowd seemed to be riled up at the sight of guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "My driver exited the vehicle and opened the door for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "We were greeted by Mansoun Leke. He wore a coat over his suit which was marked with the red and turquoise stripes of the Bludish movement's flag. He moved forward to greet us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Mansoun Leke: "“Welcome to Erzaren, Mr. President.”"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“It looks like I am not welcome here, Mr. Leke.”"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WYBÓR GRACZA: "“No need for pleasantries. I want this over with as quickly as possible.”"]** — Mówca: **Player**
> "“No need for pleasantries. I want this over with as quickly as possible.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“It looks like I am not welcome here, Mr. Leke.”"]** — Mówca: **Player**
> "“It looks like I am not welcome here, Mr. Leke.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_Emerge..."*)

### Węzeł `[42]`
Mówca: **Mansoun Leke**
> "“Very perceptive of you. But that is why you are here, if I am correct. To fix this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "He pointed at the security guards with guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Mansoun Leke: "“I am not sure how bringing your personal army will help.”"*)

### Węzeł `[47]`
Mówca: **Mansoun Leke**
> "“I am not sure how bringing your personal army will help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“They are not my personal army. They protect the governme..."*)
  - -> `[48]` (*Player: "“They are here for protection.”"*)
  - -> `[50]` (*Player: "“Let's *go*.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“They are here for protection.”"]** — Mówca: **Player**
> "“They are here for protection.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Mansoun Leke), `[270]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mansoun Leke: "“Protection from your own citizens? I guess there must be..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“They are not my personal army. They protect the government.”"]** — Mówca: **Player**
> "“They are not my personal army. They protect the government.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Mansoun Leke: "“I see. The government must have a reason to fear its own..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Let's *go*.”"]** — Mówca: **Player**
> "“Let's *go*.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Mansoun Leke), `[270]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Mansoun Leke: "“On a day like this, when you want to show support for th..."*)

### Węzeł `[51]`
Mówca: **Mansoun Leke**
> "“Protection from your own citizens? I guess there must be a reason to be fearful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Mansoun Leke: "“On a day like this, when you want to show support for th..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "We shook hands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "Take his hand and raise it in a display of unity."]** — Mówca: **Player_Italic**
> "I held our clasped hands up so that the crowd could see them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I heard shouts in Bludish coming from the crowd."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I heard some applause from the crowd."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "I heard shouts in Bludish coming from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "I heard some applause from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[59]`
Mówca: **Mansoun Leke**
> "“I see. The government must have a reason to fear its own citizens then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Mansoun Leke: "“On a day like this, when you want to show support for th..."*)

### Węzeł `[60]`
Mówca: **Mansoun Leke**
> "“On a day like this, when you want to show support for the murdered Bludish people... You bring men with guns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> "“Mr. Galade. Welcome. Shall we move on to the Sanctuary, then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: "“Let's go.”"*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "We made our way to the Erzaren Sanctuary, which stood at ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "We made our way to the Erzaren Sanctuary, which stood at the end of the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "A much smaller replica of the Archsanctuary in Deyr, the ..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "A much smaller replica of the Archsanctuary in Deyr, the ancient building had a mystical aura emanting from its blackened walls. We entered the building through the ornamented large metal gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "As we walked, the noise of the crowd faded out. Everyone ..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "As we walked, the noise of the crowd faded out. Everyone fell silent for the ceremony. Thousands of candles were burning inside the Sanctuary, one for each person that died in Izzam. The red candle in the center was for Watani Aschraf."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Mansoun gestured towards the candles."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Mansoun gestured towards the candles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Italic: "Pick up a candle."*)
  - -> `[68]` (*Player_Italic: "Pick up the red candle."*)
  - -> `[69]` (*Player_Italic: "Do not pick a candle."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "Pick up a candle."]** — Mówca: **Player_Italic**
> "I picked up one of the candles."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandl..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "Pick up the red candle."]** — Mówca: **Player_Italic**
> "I picked up the red candle for Watani Aschraf."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "Do not pick a candle."]** — Mówca: **Player_Italic**
> "I did not pick a candle. Instead, I let Mansoun lead the way. His face soured."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "He also picked up a candle and started walking out. Many others followed suit, including us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_AschrafCandle");"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "He picked up the candle for Aschraf and started walking out. Many others followed suit, including us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The atmosphere outside had completely changed. Not a sing..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He picked up the candle for Aschraf and started walking out. Many others followed suit, including us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The atmosphere outside had completely changed. Not a sing..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The atmosphere outside had completely changed. Not a single noise came from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "We slowly walked towards Aschraf's grave. On the way, hun..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "We slowly walked towards Aschraf's grave. On the way, hundreds of people joined us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He also picked up a candle and started walking out. Many ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "He picked up the candle for Aschraf and started walking o..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandl..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCan..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emergenc..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emergenc..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCan..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emergenc..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandl..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Seeing the red candle in my hand, some people started shouting at me, breaking the silence. One man managed to break the security cordon and ran towards me, screaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "<shout>"Don't defile Aschraf's spirit, you racist dog! Ta..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "When we arrived, he pointed at a huge standing torch above the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player_Italic: "Leave the candle next to it."*)
  - -> `[86]` (*Player_Italic: "Light the torch."*)
  - -> `[87]` (*Player_Italic: "Light the torch together with Mansoun."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "When we arrived, Mansoun lit the unlit candle above the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I turned around and realized the sheer amount of people w..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "Light the torch."]** — Mówca: **Player_Italic**
> "I lit the torch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I turned around and realized the sheer amount of people w..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "Light the torch together with Mansoun."]** — Mówca: **Player_Italic**
> "We lit the torch together."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "I turned around and realized the sheer amount of people who were following us. They were all looking at me, waiting to hear what I would say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“My fellow citizens.”"]** — Mówca: **Player**
> "“My fellow citizens.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[435]` (Player_Italic), `[446]` (Lucian Galade), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“We are here to mourn Watani Aschraf and many others who ..."*)
  - -> `[283]` (*Player: "“We are here to mourn those who, tragically, lost their l..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Brothers and sisters.”"]** — Mówca: **Player**
> "“Brothers and sisters.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[435]` (Player_Italic), `[446]` (Lucian Galade), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“We are here to mourn Watani Aschraf and many others who ..."*)
  - -> `[283]` (*Player: "“We are here to mourn those who, tragically, lost their l..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“We are here to mourn Watani Aschraf and many others who have lost their lives.”"]** — Mówca: **Player**
> "“We are here to mourn Watani Aschraf and many others who have lost their lives.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player), `[90]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: "“I am not standing before you today as the President. I a..."*)
  - -> `[97]` (*Player: "“They were brave men and women who only wanted to protect..."*)
  - -> `[99]` (*Player: "“I condemn the events that led to the loss of these lives.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Free people of Bludia.”"]** — Mówca: **Player**
> "“Free people of Bludia.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[435]` (Player_Italic), `[446]` (Lucian Galade), `[88]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Let me tell you one thing. I dream of a truly united Sordland. A country where being a Blud or a Sord does not matter.”"]** — Mówca: **Player**
> "“Let me tell you one thing. I dream of a truly united Sordland. A country where being a Blud or a Sord does not matter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Player), `[118]` (Player_Italic), `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“I feel responsible and ashamed for the actions of my pre..."*)
  - -> `[104]` (*Player: "“Let this be a testament of our unity for future generati..."*)
  - -> `[107]` (*Player: "“Mistakes were made. The innocent people of Izzam paid th..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "Signal the security to detain him."]** — Mówca: **Player_Italic**
> "I signalled the security guards to detain him. They immediately ran out and the boy disappeared from my sight. Another guard came over to wipe the car window."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "Do not do anything."]** — Mówca: **Player_Italic**
> "I did not do anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Our vehicle came to a stop."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Seeing the boy get dragged away caused an outcry from the crowd. Hundreds of people rushed at our car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "The local police forces did their best to calm the angry ..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“They were brave men and women who only wanted to protect their land.”"]** — Mówca: **Player**
> "“They were brave men and women who only wanted to protect their land.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Player), `[283]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“I am not standing before you today as the President. I am standing here as one of you.”"]** — Mówca: **Player**
> "“I am not standing before you today as the President. I am standing here as one of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Player), `[283]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Despite attempts to divide us, our people will stand as ..."*)
  - -> `[100]` (*Player: "“I share your hatred and anger. I feel it too, I assure y..."*)
  - -> `[101]` (*Player: "“I assure you, this administration will do its absolute b..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“I condemn the events that led to the loss of these lives.”"]** — Mówca: **Player**
> "“I condemn the events that led to the loss of these lives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Player), `[283]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Despite attempts to divide us, our people will stand as ..."*)
  - -> `[100]` (*Player: "“I share your hatred and anger. I feel it too, I assure y..."*)
  - -> `[101]` (*Player: "“I assure you, this administration will do its absolute b..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I share your hatred and anger. I feel it too, I assure you. Like a red-hot iron, it takes a long time for it to cool. But I look at the lost lives and think, what would they want?”"]** — Mówca: **Player**
> "“I share your hatred and anger. I feel it too, I assure you. Like a red-hot iron, it takes a long time for it to cool. But I look at the lost lives and think, what would they want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Player), `[99]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“I assure you, this administration will do its absolute best to mend the wounds.”"]** — Mówca: **Player**
> "“I assure you, this administration will do its absolute best to mend the wounds.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Player), `[99]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Despite attempts to divide us, our people will stand as one. We are Sord. We are Blud. We are all united under one flag.”"]** — Mówca: **Player**
> "“Despite attempts to divide us, our people will stand as one. We are Sord. We are Blud. We are all united under one flag.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Player), `[99]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“We are all the same before God. Remember the words: 'Love thy brothers and thy sisters.'”"]** — Mówca: **Player**
> "“We are all the same before God. Remember the words: 'Love thy brothers and thy sisters.'”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Player), `[118]` (Player_Italic), `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“I feel responsible and ashamed for the actions of my pre..."*)
  - -> `[104]` (*Player: "“Let this be a testament of our unity for future generati..."*)
  - -> `[107]` (*Player: "“Mistakes were made. The innocent people of Izzam paid th..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Let this be a testament of our unity for future generations! Let's stand together as Blud and Sord.”"]** — Mówca: **Player**
> "“Let this be a testament of our unity for future generations! Let's stand together as Blud and Sord.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[103]` (Player), `[106]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I feel responsible and ashamed for the actions of my predecessors. Most of all, I feel the desperation to remove this black mark from our history.”"]** — Mówca: **Player**
> "“I feel responsible and ashamed for the actions of my predecessors. Most of all, I feel the desperation to remove this black mark from our history.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[103]` (Player), `[106]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“We must always stay together in the face of adversity. Against all odds.”"]** — Mówca: **Player**
> "“We must always stay together in the face of adversity. Against all odds.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Player), `[118]` (Player_Italic), `[119]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“I feel responsible and ashamed for the actions of my pre..."*)
  - -> `[104]` (*Player: "“Let this be a testament of our unity for future generati..."*)
  - -> `[107]` (*Player: "“Mistakes were made. The innocent people of Izzam paid th..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Mistakes were made. The innocent people of Izzam paid the price. But we cannot let the past divide us.”"]** — Mówca: **Player**
> "“Mistakes were made. The innocent people of Izzam paid the price. But we cannot let the past divide us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[103]` (Player), `[106]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I need help from each and every one of you. To make this country a better place for everyone.”"]** — Mówca: **Player**
> "“I need help from each and every one of you. To make this country a better place for everyone.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: "“Are you with me?”"*)
  - -> `[111]` (*Player: "“Morning will come!”"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“The responsibility falls on all of our shoulders. Because we don't have anyone but each other.”"]** — Mówca: **Player**
> "“The responsibility falls on all of our shoulders. Because we don't have anyone but each other.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: "“Are you with me?”"*)
  - -> `[111]` (*Player: "“Morning will come!”"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Yollak Bluderat!”"]** — Mówca: **Player**
> "“Yollak Bluderat!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Morning will come!”"]** — Mówca: **Player**
> "“Morning will come!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true`
- **Kontekst wejściowy (poprzednik):** `[107]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "There was no reaction from the crowd. Only silence."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "There was no reaction from the crowd. Only silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "Your flag! Your nation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "“Let me finish.”"*)
  - -> `[117]` (*Player: "“Don't play into the hands of the separationists. United ..."*)
  - -> `[118]` (*Player_Italic: "Pay no attention."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "Revenge!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Let me finish.”"*)
  - -> `[119]` (*Player: "“To what end? We need to break this vicious cycle of viol..."*)
  - -> `[120]` (*Player_Italic: "Pay no attention."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "Bullshit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "“Let me finish.”"*)
  - -> `[122]` (*Player: "“Despite these kinds of attempts to divide us, we will be..."*)
  - -> `[121]` (*Player_Italic: "Pay no attention."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Don't play into the hands of the separationists. United we stand. Divided we fall.”"]** — Mówca: **Player**
> "“Don't play into the hands of the separationists. United we stand. Divided we fall.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "Pay no attention."]** — Mówca: **Player_Italic**
> "I paid no attention."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“To what end? We need to break this vicious cycle of violence and vengeance for a better future.”"]** — Mówca: **Player**
> "“To what end? We need to break this vicious cycle of violence and vengeance for a better future.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "Pay no attention."]** — Mówca: **Player_Italic**
> "I paid no attention."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Pay no attention."]** — Mówca: **Player_Italic**
> "I paid no attention."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Despite these kinds of attempts to divide us, we will be united as one. We will work together!”"]** — Mówca: **Player**
> "“Despite these kinds of attempts to divide us, we will be united as one. We will work together!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“Let me finish.”"]** — Mówca: **Player**
> "“Let me finish.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "An old man from the crowd yelled: "Your flag! Your nation!""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "An old man from the crowd yelled: "He is right!""*)

### Węzeł `[127]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "He is right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "An old man from the crowd yelled: "Revenge!""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "An old man from the crowd yelled: "He is right!""*)

### Węzeł `[131]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "He is right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "An old man from the crowd yelled: "Bullshit!""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "An old man from the crowd yelled: "He speaks the truth!""*)

### Węzeł `[135]`
Mówca: **Narrator**
> "An old man from the crowd yelled: "He speaks the truth!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Let me finish.”"]** — Mówca: **Player**
> "“Let me finish.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Let me finish.”"]** — Mówca: **Player**
> "“Let me finish.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Let me tell you one thing. I dream of a truly united Sor..."*)
  - -> `[103]` (*Player: "“We are all the same before God. Remember the words: 'Lov..."*)
  - -> `[106]` (*Player: "“We must always stay together in the face of adversity. A..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“Are you with me?”"]** — Mówca: **Player**
> "“Are you with me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "There was no reaction from the crowd. Only silence."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“I need help from each and every one of you. To make this..."*)
  - -> `[109]` (*Player: "“The responsibility falls on all of our shoulders. Becaus..."*)
  - -> `[112]` (*Player: "“Thank you.”"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“I need help from each and every one of you. To make this..."*)
  - -> `[109]` (*Player: "“The responsibility falls on all of our shoulders. Becaus..."*)
  - -> `[112]` (*Player: "“Thank you.”"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“We are here to mourn Watani Aschraf and many others who ..."*)
  - -> `[283]` (*Player: "“We are here to mourn those who, tragically, lost their l..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Despite attempts to divide us, our people will stand as ..."*)
  - -> `[100]` (*Player: "“I share your hatred and anger. I feel it too, I assure y..."*)
  - -> `[101]` (*Player: "“I assure you, this administration will do its absolute b..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“I need help from each and every one of you. To make this..."*)
  - -> `[109]` (*Player: "“The responsibility falls on all of our shoulders. Becaus..."*)
  - -> `[112]` (*Player: "“Thank you.”"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 3;
BaseGame.Public_Opinion -= 1;
BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 3;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "There was no reaction from the crowd. Only silence."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 1;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "There was no reaction from the crowd. Only silence."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I turned around and realized the sheer amount of people w..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He picked up the candle for Aschraf and started walking o..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 5;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 5;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "He pointed at the security guards with guns."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Our vehicle came to a stop."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > -1 && BaseGame.Bludish_Opinion > -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReact..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > -1 && BaseGame.Bludish_Opinion > -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > -1  and  Variable["BaseGame.Bludish_Opinion"] > -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > -1 && BaseGame.Bludish_Opinion > -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > -1  and  Variable["BaseGame.Bludish_Opinion"] > -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Mansoun leaned in closer to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Mansoun Leke: "“I must admit, Mr. President. That was a good speech.”"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Lucian looked at me worriedly. People started coming closer and closer to us, chanting "Yollak Bluderat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[155]`
Mówca: **Narrator**
> "I was immediately surrounded by the security detail I had brought with me. They had drawn their guns and were pointing them at the approaching crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: "“We must leave, sir. Now!”"*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> "“We must leave, sir. Now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "I turned to follow him. Just then, someone yelled "Yollak..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "There was the deafening noise of machine gun fire. I closed my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "The noise stopped. I gathered up the courage to open my e..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Everything became a blur. The guards circled around me, shielding me from the chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "They escorted me to our vehicle in a matter of seconds. I..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "They escorted me to our vehicle in a matter of seconds. I heard more gunshots as we drove out of Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion -= 10"*)

### Węzeł `[160]`
Mówca: **Mansoun Leke**
> "“I must admit, Mr. President. That was a good speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player: "“Thank you.”"*)
  - -> `[162]` (*Player: "“Just doing my duty.”"*)
  - -> `[163]` (*Player: "“I hope the crowd thinks the same.”"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He extended his hand to me for a handshake."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“Just doing my duty.”"]** — Mówca: **Player**
> "“Just doing my duty.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He extended his hand to me for a handshake."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“I hope the crowd thinks the same.”"]** — Mówca: **Player**
> "“I hope the crowd thinks the same.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He extended his hand to me for a handshake."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "He extended his hand to me for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Italic: "Shake his hand."*)
  - -> `[166]` (*Player_Italic: "Hug him."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "As we shook hands, the crowd started to clap."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseG..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "Hug him."]** — Mówca: **Player_Italic**
> "Instead of going for the handshake, I spread my arms and hugged him. Suddenly, the whole crowd erupted in applause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseG..."*)

### Węzeł `[167]`
Mówca: **Mansoun Leke**
> "“Thank you for this, Mr. President. I don't think the people of Erzaren will ever forget this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Mansoun Leke: "“You have become the first and only president brave enoug..."*)

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> "“You have become the first and only president brave enough to come to Erzaren and pay respects to the Izzam victims. I hope this will be the start of a new era.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Mansoun Leke: "“Thank you.”"*)

### Węzeł `[169]`
Mówca: **Mansoun Leke**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Lucian rushed over to me."*)

### Węzeł `[170]`
Mówca: **Lucian Galade**
> "“Sir, it's time to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "We started making our way back to the convoy."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "We started making our way back to the convoy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucian Galade: "“Well done, sir. This will prove very useful in the upcom..."*)

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“Well done, sir. This will prove very useful in the upcoming elections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“Exactly my plan.”"*)
  - -> `[173]` (*Player: "“What's the rush?”"*)
  - -> `[175]` (*Player: "“Time will tell.”"*)
  - -> `[290]` (*Player: "“Not everything is about votes.”"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "“What's the rush?”"]** — Mówca: **Player**
> "“What's the rush?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Lucian Galade: "“The whole trip runs on a schedule, sir. The convoy needs..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Exactly my plan.”"]** — Mówca: **Player**
> "“Exactly my plan.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "Lucian bowed his head."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Time will tell.”"]** — Mówca: **Player**
> "“Time will tell.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "Lucian bowed his head."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "Lucian bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "We entered our vehicles and started making our way back h..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "We entered our vehicles and started making our way back home from Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_AschrafAnniversary = true"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Lucian grabbed my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: "“We must leave. Now!”"*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“We must leave. Now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "With only our personal guards protecting us against a cro..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "With only our personal guards protecting us against a crowd of thousands, we starting making our way back to the cars hastily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The convoy started driving away as soon as we were seated..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "The convoy started driving away as soon as we were seated. The windows of the vehicles were completely covered with rotten vegetables, eggs and splatters of paint by the time we finally left the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion -= 1"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_AschrafAnniversary = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_AschrafAnniversary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += BaseGameIsolated.Turn09_A_Asc..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion -= 10`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_AschrafAnniversary = true"*)

### Węzeł `[185]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. This will help ease tensions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“Yes. But I am still worried about our safety.”"*)
  - -> `[9]` (*Player: "“I hope so.”"*)
  - -> `[12]` (*Player: "“That was my intention all along.”"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Yes. But I am still worried about our safety.”"]** — Mówca: **Player**
> "“Yes. But I am still worried about our safety.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Lucian Galade), `[256]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“It is certainly risky. But if we manage to win some hear..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "We entered the historic center wearing flak vests, transported by an armored personnel carrier. I gazed out its windows at the city's rundown buildings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Our massive convoy could barely fit through the narrow st..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "There was an outcry from the crowd. Hundreds of people sh..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Seeing the boy get dragged away caused an outcry from the..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "There was an outcry from the crowd. Hundreds of people shouted slurs at us while keeping their distance. The heavy weaponry that the security carried seemed to have startled them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "The ceremonies were to be held in the aptly named Izzam Square, several blocks away from Lake Soll and the sunken ruins of the village of Izzam."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "We entered the historic center in the presidential Kadilla. The streets were littered with broken glass and the walls defaced with graffiti. I sensed a heavy regional police presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Our convoy could barely fit through the narrow streets, d..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "The local police forces did their best to calm the angry crowd and pushed them away from our vehicle. I suddenly had the feeling that our forces were in danger of being overwhelmed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "After a few hours' drive, we finally arrived in the ancient walled city of Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The city had been of particular importance to the Bludish..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: "“They seem to be chanting your name, sir. I believe they ..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: "“They seem to be chanting 'Yollak Bluderat'. I believe th..."*)

### Węzeł `[199]`
Mówca: **Lucian Galade**
> "“They seem to be chanting your name, sir. I believe they are happy with their new autonomy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "The crowd before me had signs in their hands protesting m..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[203]`
Mówca: **Narrator**
> "The crowd before me had signs in their hands protesting my decision to centralize Bergia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_Emerge..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_Emer..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -10  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Mansoun Leke: "“Very perceptive of you. I wonder why that is the case...”"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= -10 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -10  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Mansoun Leke: "“Very perceptive of you. But that is why you are here, if..."*)

### Węzeł `[207]`
Mówca: **Mansoun Leke**
> "“Very perceptive of you. I wonder why that is the case...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emergenc..."*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emerge..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Seeing the red candle in my hand, some people started sho..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emergenc..."*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emerge..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Someone from the crowd shouted at me, breaking the silence."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emergenc..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_Emerge..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Some people started shouting at me, breaking the silence...."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0 || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Noticing I had no candle in my hand, someone in the crowd..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Someone from the crowd shouted at me, breaking the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "<shout>"Don't mock the dead, you racist dog! You are defi..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "I noticed an excessively high amount of regional police, ..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "I noticed an excessively high amount of regional police, as well as the gendarmerie and local police. They formed a human barricade around the square, staring intimidatingly at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lucian Galade: "“Must be the governor's doing.”"*)

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“Must be the governor's doing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Some people started shouting at me, breaking the silence. One man managed to break the security cordon and ran towards me, screaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Narrator: "<shout>"You cannot defile our traditions, you racist dog!..."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Noticing I had no candle in my hand, someone in the crowd shouted at me, breaking the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Narrator: "<shout>"Have respect for the dead!"</shout>"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == false"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == false)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "We entered the historic center wearing flak vests, transp..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "We entered the historic center wearing flak vests, transp..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Before he could get to me, security forces grabbed the ma..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Before he could get to me, one of my presidential guards ..."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "Before he could get to me, security forces grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Mansoun looked at me with a mix of fear and anger in his ..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Before he could get to me, one of my presidential guards grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Mansoun looked at me with a mix of fear and anger in his ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "Before I could react, security forces grabbed the man and..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Italic: "Signal security to detain him."*)
  - -> `[237]` (*Player_Italic: "Keep walking."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "Before I could react, security forces grabbed the man and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Mansoun looked at me with a mix of fear and anger in his ..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Italic**
> "I ignored the man and kept walking."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[463]` (Narrator), `[465]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA: "Signal security to detain him."]** — Mówca: **Player_Italic**
> "Before I finished my gesture, security forces grabbed the man and dragged him away."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[463]` (Narrator), `[465]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Mansoun looked at me with a mix of fear and anger in his ..."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Mansoun looked at me with a mix of fear and anger in his eyes, but he knew better than to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true || BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCan..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true || BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true  or  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "When we arrived, he pointed at a huge standing torch abov..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle == true || BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandle"] == true  or  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_RegularCandle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "When we arrived, Mansoun lit the unlit candle above the g..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion += 1;
BaseGame.Democratic -= 1;
BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_AschrafCandl..."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "We entered the historic center wearing flak vests, transported by an armored personnel carrier. The streets were littered with broken glass and the walls defaced with graffiti. I sensed a heavy regional police presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Our massive convoy could barely fit through the narrow st..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == false"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == false)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "We entered the historic center in the presidential Kadill..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "We entered the historic center in the presidential Kadill..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "We entered the historic center in the presidential Kadilla. I gazed out its windows at the city's rundown buildings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Our convoy could barely fit through the narrow streets, d..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Lucian Galade: "“I must say this was a good decision, sir. After giving t..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: "“I must say this was a good decision, sir. This will help..."*)

### Węzeł `[252]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. After giving the Bludish autonomy, this will send a strong message that you are on their side. But I hope bringing this much security won't cause any problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“Better safe than sorry.”"*)
  - -> `[9]` (*Player: "“I hope so.”"*)
  - -> `[12]` (*Player: "“That was my intention all along.”"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Lucian Galade: "“I must say this was a good decision, sir. After giving t..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucian Galade: "“I must say this was a good decision, sir. This will help..."*)

### Węzeł `[256]`
Mówca: **Lucian Galade**
> "“I must say this was a good decision, sir. After giving the Bludish autonomy, this will send a strong message that you are on their side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“Yes. But I am still worried about our safety.”"*)
  - -> `[9]` (*Player: "“I hope so.”"*)
  - -> `[12]` (*Player: "“That was my intention all along.”"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("FuriousJeers");"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("FuriousJeers");"*)

### Węzeł `[260]`
Mówca: **Narrator**
> "A large crowd had assembled in the square. There were probably at least ten thousand people. Most of them were yelling insults and obscenities at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "As our convoy slowed down, a young Bludish man ran in fro..."*)

### Węzeł `[261]`
Mówca: **Mansoun Leke**
> "“I suppose the governor's huge army wasn't enough. Bergia has already become a police state. A truly *special* zone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: "“Let's just move on, Mr. Leke.”"*)
  - -> `[280]` (*Player: "“Watch your words. You are speaking to the president.”"*)
  - -> `[278]` (*Player: "“My only intention is to stand in solidarity with our Blu..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Mansoun Leke: "“I suppose the governor's huge army wasn't enough. Bergia..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Mansoun Leke: "“I don't know what your intention is, but I only ask of y..."*)

### Węzeł `[265]`
Mówca: **Mansoun Leke**
> "“I don't know what your intention is, but I only ask of you to at least be respectful during the ceremony, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: "“Let's just move on, Mr. Leke.”"*)
  - -> `[280]` (*Player: "“Watch your words. You are speaking to the president.”"*)
  - -> `[278]` (*Player: "“My only intention is to stand in solidarity with our Blu..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He pointed at the gendarmerie forces."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“Mr. Leke.”"*)

### Węzeł `[269]`
Mówca: **Narrator**
> "He pointed at the gendarmerie forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Mansoun Leke: "“I am not sure how bringing your army will help.”"*)

### Węzeł `[270]`
Mówca: **Mansoun Leke**
> "“I am not sure how bringing your army will help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player: "“They are not my army. They protect the Special Region of..."*)
  - -> `[48]` (*Player: "“They are here for protection.”"*)
  - -> `[50]` (*Player: "“Let's *go*.”"*)
  - -> `[271]` (*Player: "“It's the governor's doing.”"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It's the governor's doing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Mansoun Leke: "“The man who abuses his authority to oppress Bergia.”"*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "“They are not my army. They protect the Special Region of Bergia.”"]** — Mówca: **Player**
> "“They are not my army. They protect the Special Region of Bergia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Mansoun Leke: "“I see. The government must have a reason to fear its own..."*)

### Węzeł `[273]`
Mówca: **Mansoun Leke**
> "“The man who abuses his authority to oppress Bergia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: "“Let's just move on, Mr. Leke.”"*)
  - -> `[275]` (*Player: "“I am supportive of you, Mr. Leke. I want him gone as muc..."*)
  - -> `[276]` (*Player: "“We are trying our best to contain him, but without chang..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA: "“Let's just move on, Mr. Leke.”"]** — Mówca: **Player**
> "“Let's just move on, Mr. Leke.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "He clenched his jaw."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I am supportive of you, Mr. Leke. I want him gone as much as you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "He clenched his jaw."*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We are trying our best to contain him, but without changing the laws there's nothing I can do about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "He clenched his jaw."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "He clenched his jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“Mr. Leke.”"*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "“My only intention is to stand in solidarity with our Bludish people.”"]** — Mówca: **Player**
> "“My only intention is to stand in solidarity with our Bludish people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Mansoun Leke), `[265]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He raised an eyebrow."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "“Let's just move on, Mr. Leke.”"]** — Mówca: **Player**
> "“Let's just move on, Mr. Leke.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Mansoun Leke), `[265]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "He clenched his jaw."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "“Watch your words. You are speaking to the president.”"]** — Mówca: **Player**
> "“Watch your words. You are speaking to the president.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Mansoun Leke), `[265]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "He clenched his jaw."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“Mr. Leke.”"*)

### Węzeł `[282]`
**[WYBÓR GRACZA: "Leave the candle next to it."]** — Mówca: **Player_Italic**
> "I put the candle next to the torch."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I turned around and realized the sheer amount of people w..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "“We are here to mourn those who, tragically, lost their lives in Izzam.”"]** — Mówca: **Player**
> "“We are here to mourn those who, tragically, lost their lives in Izzam.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Player), `[90]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: "“I am not standing before you today as the President. I a..."*)
  - -> `[97]` (*Player: "“They were brave men and women who only wanted to protect..."*)
  - -> `[99]` (*Player: "“I condemn the events that led to the loss of these lives.”"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Yollak Bluderat!”"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true || BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player: "“To our unity!”"*)

### Węzeł `[287]`
**[WYBÓR GRACZA: "“To our unity!”"]** — Mówca: **Player**
> "“To our unity!”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  or  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "There was no reaction from the crowd. Only silence."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "One man broke the silence and shouted "Do not listen to murderers!", and threw a tomato. It hit the ground right in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[289]`
Mówca: **Narrator**
> "Lucian rushed over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucian Galade: "“Sir, it's time to go.”"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "“Not everything is about votes.”"]** — Mówca: **Player**
> "“Not everything is about votes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucian Galade: "“It's not?”"*)

### Węzeł `[291]`
Mówca: **Lucian Galade**
> "“It's not?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "We entered our vehicles and started making our way back h..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: ""Despite ultranationalists, we keep marching!" shouted a ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> ""Despite ultranationalists, we keep marching!" shouted a group of people in the very front, who also started waving the flags of the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: ""You cannot claim that you support us after trying to kil..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[299]`
Mówca: **Narrator**
> ""You cannot claim that you support us after trying to kill our language!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: ""What were you doing in Wehlen against our people? You ar..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[303]`
Mówca: **Narrator**
> ""What were you doing in Wehlen against our people? You are responsible of the deaths of thousands!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "There was a moment of complete silence. Then, the whole c..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: ""You supported Murderer Smolak in his crusade against our..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "There was a moment of complete silence. Then, the whole c..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> ""You supported Murderer Smolak in his crusade against our people! You denied entry to innocent refugees! You are responsible for the deaths of thousands!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "There was a moment of complete silence. Then, the whole c..."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "There was a moment of complete silence. Then, the whole crowd erupted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Lucian looked at me worriedly. People started coming clos..."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "I was immediately surrounded by the local police forces. They had drawn their guns and were pointing them at the approaching crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Hearing the chaos, regional police forces and the gendarm..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Hearing the chaos, regional police forces and the gendarmerie also rushed to our aid. Suddenly, the entire crowd was surrounded by an army."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucian Galade: "“Sir, I think we must leave.”"*)

### Węzeł `[311]`
Mówca: **Narrator**
> "As the security forces pushed everyone away, the presidential guard escorted us back to our vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Lucian Galade: "“That was close.”"*)

### Węzeł `[312]`
Mówca: **Lucian Galade**
> "“Sir, I think we must leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "As the security forces pushed everyone away, the presiden..."*)

### Węzeł `[313]`
Mówca: **Lucian Galade**
> "“That was close.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player: "“I'm glad I brought this much security.”"*)
  - -> `[315]` (*Player: "“They will pay for this.”"*)
  - -> `[316]` (*Player: "“We should have been more careful.”"*)

### Węzeł `[314]`
**[WYBÓR GRACZA: "“I'm glad I brought this much security.”"]** — Mówca: **Player**
> "“I'm glad I brought this much security.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "We entered our vehicles and starting making our way back ..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA: "“They will pay for this.”"]** — Mówca: **Player**
> "“They will pay for this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "We entered our vehicles and starting making our way back ..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA: "“We should have been more careful.”"]** — Mówca: **Player**
> "“We should have been more careful.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "We entered our vehicles and starting making our way back ..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "We entered our vehicles and starting making our way back home from Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "I turned to follow him. Just then, someone yelled "Yollak Bluderat" and dashed towards us with a knife."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("MachineGun");"*)

### Węzeł `[319]`
Mówca: **Narrator**
> "The noise stopped. I gathered up the courage to open my eyes again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "I looked at the crowd."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "The man had fallen to the ground. The crowd panicked and began to scatter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "I saw another body on the ground behind him. It was a boy."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "I looked at the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "The man had fallen to the ground. The crowd panicked and ..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "A woman, probably his mother, fell on her knees right next to him and caressed his head. Her scream pierced the panic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: "“That boy! Make sure he is okay!”"*)
  - -> `[353]` (*Player: "“My God.”"*)
  - -> `[354]` (*Player: "“Get an ambulance now!”"*)
  - -> `[355]` (*Player: "“We have to get out of here.”"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true) || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tru..."*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Decision_Turn05_AutocratEmergency_Extend == t..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true) || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "I was immediately surrounded by the local police forces. ..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true) || BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)  or  Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Lucian grabbed my shoulder."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseG..."*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true || Bas..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Mansoun Leke: "“Thank you, Mr. President.”"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Mansoun Leke: "“Thank you for this, Mr. President. I don't think the peo..."*)

### Węzeł `[329]`
Mówca: **Mansoun Leke**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Mansoun Leke: "“I don't know if any of this really makes a difference af..."*)

### Węzeł `[330]`
Mówca: **Mansoun Leke**
> "“I don't know if any of this really makes a difference after what you have done against the Bludish people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Mansoun Leke: "“Still, you came here to Erzaren for the anniversary of t..."*)

### Węzeł `[331]`
Mówca: **Mansoun Leke**
> "“Still, you came here to Erzaren for the anniversary of the Izzam Incident. That is a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Lucian rushed over to me."*)

### Węzeł `[332]`
Mówca: **Lucian Galade**
> "“The whole trip runs on a schedule, sir. The convoy needs to start driving now, or else we won't make it back in time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "We entered our vehicles and started making our way back h..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion += BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"];`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 4;"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[351]`
Mówca: **Narrator**
> "I saw another body on the ground behind him. It was a boy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "A woman, probably his mother, fell on her knees right nex..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA: "“That boy! Make sure he is okay!”"]** — Mówca: **Player**
> "“That boy! Make sure he is okay!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Everything became a blur. The guards circled around me, s..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA: "“My God.”"]** — Mówca: **Player**
> "“My God.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Everything became a blur. The guards circled around me, s..."*)

### Węzeł `[354]`
**[WYBÓR GRACZA: "“Get an ambulance now!”"]** — Mówca: **Player**
> "“Get an ambulance now!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Everything became a blur. The guards circled around me, s..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA: "“We have to get out of here.”"]** — Mówca: **Player**
> "“We have to get out of here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Everything became a blur. The guards circled around me, s..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Negative = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Negative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "One man broke the silence and shouted "Do not listen to m..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Positive = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Positive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Mansoun leaned in closer to me."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary_Security = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_Joined_Aschraf_Anniversary_Security"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Security = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_Security"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Joined_Aschraf_Anniversary_..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "One man broke the silence and shouted "Do not listen to m..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn0..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Tur..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] >= 10  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = false; BaseGam..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bludish_Opinion"] >= 10  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -12"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -12"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= -12)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -12`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = true; BaseGame..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= -12)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = false; BaseGam..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Reform_BludishRights_Amendment_Proposal == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true &&..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Reform_BludishRights_Amendment_Proposal == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = true; BaseGame..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Reform_BludishRights_Amendment_Proposal == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == false  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bludish_Opinion >= 10 && BaseGameIsolated.Turn0..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_..."*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn0..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] > 0  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = false; BaseGam..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bludish_Opinion > 0 && BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction > 0) || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bludish_Opinion"] > 0  and  Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] > 0)  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = false; BaseGam..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = true;
BaseGame.Situation_Law_BludishReconciliation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = true;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = true;
BaseGame.Situation_Law_BludishReconciliation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = true;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == false"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_AschrafCandle");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_AschrafCandle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The atmosphere outside had completely changed. Not a sing..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "On our way to Erzaren, we stopped in Deyr to meet with th..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "On our way to Erzaren, we stopped in Deyr to meet with th..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)

### Węzeł `[398]`
Mówca: **Narrator**
> "On our way to Erzaren, we stopped in Deyr to meet with the Governor of Bergia, Phelix Bron, to discuss the security situation within the Special Zone. He wished us luck at the event and told us to be careful before bidding us farewell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "After a few hours' drive, we finally arrived in the ancie..."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "On our way to Erzaren, we stopped in Deyr to meet with the Governor of Bergia, Herbert Krull, to discuss the security situation within the Special Zone. He wished us luck at the event and told us to be extremely careful before bidding us farewell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "After a few hours' drive, we finally arrived in the ancie..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == true)"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "On our way to Erzaren, we stopped in Deyr to meet with th..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "On our way to inner Erzaren, we stopped to meet with the ..."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "On our way to Erzaren, we stopped in Deyr to meet with the new Governor of Bergia, Ishval Ersen, to discuss the implementation of the autonomous zone. He welcomed us with great sympathy and care, and wished us the best for the event."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "After a few hours' drive, we finally arrived in the ancie..."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "On our way to inner Erzaren, we stopped to meet with the local police chief, Ionas Fisser, to discuss how the abolishment of the Zone was faring for the locals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The city had been of particular importance to the Bludish..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Arrest_FetihEjall == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "I saw many signs that condemned the arrest of Fetih Ejall."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)

### Węzeł `[408]`
Mówca: **Narrator**
> "I saw many signs that condemned the arrest of Fetih Ejall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "We were greeted by Mansoun Leke. He wore a coat over his ..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Narrator: "I saw many signs that condemned the ban on the Workers' P..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "We were greeted by Mansoun Leke. He wore a coat over his ..."*)

### Węzeł `[412]`
Mówca: **Narrator**
> "I saw many signs that condemned the ban on the Workers' Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "We were greeted by Mansoun Leke. He wore a coat over his ..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I turned around and realized the sheer amount of people w..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“We are here to mourn Watani Aschraf and many others who ..."*)
  - -> `[283]` (*Player: "“We are here to mourn those who, tragically, lost their l..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= 0"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= 0)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 2;
BaseGame.Public_Opinion -= 1;
BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "There was no reaction from the crowd. Only silence."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_WillHappen == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "One man broke the silence and shouted "Do not listen to m..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_WillHappen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Unrest_BFF_WillHappen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Unrest_BFF_WillHappen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "I was immediately surrounded by the security detail I had..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true && BaseGame.Unrest_BFF_WillHappen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true  and  Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tru..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Threatens_President == true)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Threatens_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "Just then, I noticed a few BFF flags waving at the very b..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Threatens_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Brothers and sisters.”"*)
  - -> `[89]` (*Player: "“My fellow citizens.”"*)
  - -> `[92]` (*Player: "“Free people of Bludia.”"*)

### Węzeł `[433]`
Mówca: **Narrator**
> "Just then, I noticed a few BFF flags waving at the very back of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player_Italic: "Signal to Lucian."*)
  - -> `[435]` (*Player_Italic: "Start the speech."*)

### Węzeł `[434]`
**[WYBÓR GRACZA: "Signal to Lucian."]** — Mówca: **Player_Italic**
> "I signalled to Lucian. He immediately bowed his head towards mine so I could whisper in his ear."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucian Galade: ""Is there something wrong, sir?""*)

### Węzeł `[435]`
**[WYBÓR GRACZA: "Start the speech."]** — Mówca: **Player_Italic**
> "I ignored them and started my speech."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Brothers and sisters.”"*)
  - -> `[89]` (*Player: "“My fellow citizens.”"*)
  - -> `[92]` (*Player: "“Free people of Bludia.”"*)

### Węzeł `[436]`
Mówca: **Lucian Galade**
> ""Is there something wrong, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player: ""There are people in the crowd with BFF flags. I thought ..."*)
  - -> `[438]` (*Player: ""I'm not sure if I should continue with the speech, Lucia..."*)
  - -> `[439]` (*Player: ""I saw some BFF flags. Could you please check if everythi..."*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There are people in the crowd with BFF flags. I thought security wouldn't allow such a thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lucian Galade: ""Are you sure, sir? I can't see anything. The police woul..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not sure if I should continue with the speech, Lucian. I think we might be in danger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Lucian Galade: ""Do you want to cancel the speech, sir?""*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I saw some BFF flags. Could you please check if everything's all right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Lucian Galade: ""Are you sure, sir? The police wouldn't have allowed thos..."*)

### Węzeł `[440]`
Mówca: **Lucian Galade**
> ""Are you sure, sir? The police wouldn't have allowed those flags here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "The crowd was getting restless."*)

### Węzeł `[441]`
Mówca: **Lucian Galade**
> ""Are you sure, sir? I can't see anything. The police wouldn't have allowed those flags here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "The crowd was getting restless."*)

### Węzeł `[442]`
Mówca: **Lucian Galade**
> ""Do you want to cancel the speech, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "The crowd was getting restless."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "The crowd was getting restless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player: ""Yes. I want to cancel the speech. Let's leave this place..."*)
  - -> `[444]` (*Player: ""Okay, never mind. I'll continue with the speech.""*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Okay, never mind. I'll continue with the speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Lucian Galade: ""Good luck, sir.""*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes. I want to cancel the speech. Let's leave this place immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReactio..."*)

### Węzeł `[446]`
Mówca: **Lucian Galade**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Brothers and sisters.”"*)
  - -> `[89]` (*Player: "“My fellow citizens.”"*)
  - -> `[92]` (*Player: "“Free people of Bludia.”"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction -= 4;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] = Variable["BaseGameIsolated.Turn09_A_AschrafAnniversary_CrowdReaction"] - 4;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Lucian Galade: ""Of course, sir. Please follow me.""*)

### Węzeł `[448]`
Mówca: **Lucian Galade**
> ""Of course, sir. Please follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "We quickly made our way offstage amid surprised looks fro..."*)

### Węzeł `[449]`
Mówca: **Narrator**
> "We quickly made our way offstage amid surprised looks from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Narrator: "A man shouted, "Yes! Run away to your home! Don't ever co..."*)

### Węzeł `[450]`
Mówca: **Narrator**
> "A man shouted, "Yes! Run away to your home! Don't ever come back here!" and threw a tomato. It hit the ground right in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "There was a second of silence. Then, the entire crowd eru..."*)

### Węzeł `[451]`
Mówca: **Narrator**
> "Lucian looked at me worriedly. People started walking closer and closer to us, chanting "Yollak Bluderat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: ""Despite ultranationalists, we keep marching!" shouted a ..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Lucian grabbed my shoulder."*)

### Węzeł `[455]`
Mówca: **Narrator**
> "There was a second of silence. Then, the entire crowd erupted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "Lucian looked at me worriedly. People started walking clo..."*)

### Węzeł `[456]`
Mówca: **Narrator**
> ""Despite ultranationalists, we keep marching!" shouted a group of people in the very front, wielding the flags of the Workers Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Lucian grabbed my shoulder."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_AschrafAnniversary = true"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_AschrafAnniversary = true"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_WillHappen == true)"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = true; BaseGame..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_WillHappen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[463]`
Mówca: **Narrator**
> "<shout>"Have respect for the dead!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[464]`
Mówca: **Narrator**
> "<shout>"You cannot defile our traditions, you racist dog! At least have respect for the dead!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[465]`
Mówca: **Narrator**
> "<shout>"Don't mock the dead, you racist dog! You are defiling that candle in your hands!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "<shout>"Don't defile Aschraf's spirit, you racist dog! Take your hands off that candle!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("FuriousJeers");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("FuriousJeers");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "A large crowd had assembled in the square. There were pro..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("FuriousJeers");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("FuriousJeers");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "A large crowd had assembled in the square. There were pro..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "A large crowd had assembled in the square. There were pro..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("MachineGun");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("MachineGun");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "There was the deafening noise of machine gun fire. I clos..."*)
