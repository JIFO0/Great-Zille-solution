# Sordland/Turn03/A_AutocratSpeech

- **ID konwersacji:** `39`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/039_A_AutocratSpeech.md`
- **Liczba węzłów dialogowych:** 351
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[34]** Gloria Tory
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_None`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGameIsolated.Turn04_A_Speech_Hub_A`
- `BaseGameIsolated.Turn04_A_Speech_Hub_B`
- `BaseGameIsolated.Turn04_A_Speech_Hub_C`
- `BaseGameIsolated.Turn04_A_Speech_Hub_D`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Policy_Order_DetentionWithoutTrial`
- `BaseGame.Policy_Order_SuspendedProtests`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExpandedHumanRights`
- `BaseGame.Situation_Law_LimitedHumanRights`
- `BaseGame.Situation_Law_SomeHumanRights`
- `BaseGame.Situation_Order_LittleSecurityPowers`
- `BaseGame.Situation_Order_Prisons_Crowded`
- `BaseGame.Situation_Order_SomeSecurityPowers`
- `BaseGame.Situation_Order_WideRangingSecurityPowers`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn04_A_Speech_Hub_A`
- `BaseGameIsolated.Turn04_A_Speech_Hub_B`
- `BaseGameIsolated.Turn04_A_Speech_Hub_C`
- `BaseGameIsolated.Turn04_A_Speech_Hub_D`
- `BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia`
- `BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC`
- `BaseGameSupport.Journal_Turn03_Autocrat_Speech`
- `BaseGameSupport.News_Turn03_E_Emergency`
- `BaseGameSupport.News_Turn03_G_Emergency`
- `BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo`
- `BaseGameSupport.News_Turn03_LT_Emergency_AllBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_BludBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_RYBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_YSBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned`
- `BaseGameSupport.News_Turn03_R_Emergency`
- `BaseGameSupport.News_Turn03_ST_Emergency_Deal`
- `BaseGameSupport.News_Turn03_ST_Emergency_NoDeal`
- `BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned`
- `BaseGameSupport.Report_Turn03_Erzaren_Emergency_BludBanned`
- `BaseGameSupport.Report_Turn03_Holsord_Emergency`
- `GameCondition.Turn03_A_AutocratSpeech`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **""Ladies and Gentlemen...""** | `[19]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""Sordland has gone through a cri..."<br>`[22]` **Player**: ""Sordland is going through criti..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **"Focus on the shooting of Bernard Circas."** | `[20]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[197]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "I brought attention to..." |
| `[22]` | **"Focus on the clashes between the Red Youth and Young Sords."** | `[20]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[197]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true` | *Brak zmian stanu* | `[25]` **Narrator**: "I brought attention to..." |
| `[23]` | **"Focus on the Bludish Freedom Front and Rumburg's aid."** | `[20]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[197]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | *Brak zmian stanu* | `[24]` **Narrator**: "I brought attention to..." |
| `[33]` | **"The threat of the Young Sords and the right wing agenda."** | `[25]` **Narrator**: "I brought attention to..."<br>`[26]` **Narrator**: "I brought attention to..." | `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true` | `PlaySoundEffect("VoteRoar"); ;` | `[47]` **Narrator**: "NFP members started yelling in p..." |
| `[37]` | **"The threat of extreme left and right wing groups in Sordland."** | `[25]` **Narrator**: "I brought attention to..."<br>`[26]` **Narrator**: "I brought attention to..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("VoteRoar"); ;` | `[46]` **Narrator**: "The opposition members started y..." |
| `[38]` | **"The threat of the Red Youth and the left wing agenda."** | `[25]` **Narrator**: "I brought attention to..."<br>`[26]` **Narrator**: "I brought attention to..." | `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true` | `PlaySoundEffect("AssemblyApplause2"); ;` | `[45]` **Narrator**: "Applauses came from the NFP seats." |
| `[42]` | **"The threat of the Bludish separatists."** | `[24]` **Narrator**: "I brought attention to..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause2"); ;` | `[44]` **Narrator**: "Applauses came from the NFP seats." |
| `[43]` | **"The threat of Rumburg."** | `[24]` **Narrator**: "I brought attention to..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause2"); ;` | `[44]` **Narrator**: "Applauses came from the NFP seats." |
| `[48]` | **"Blame the Bludish separatists for a plan to occupy Bergia."** | `[44]` **Narrator**: "Applauses came from the NFP seats."<br>`[45]` **Narrator**: "Applauses came from the NFP seats."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | *Brak zmian stanu* | `[90]` **Player**: ""In accordance with Article 57 a..."<br>`[61]` **Player**: ""The police will be given increa..."<br>*(oraz 3 innych odgałęzień)* |
| `[49]` | **"Blame the communists for a plan to overthrow the government."** | `[44]` **Narrator**: "Applauses came from the NFP seats."<br>`[45]` **Narrator**: "Applauses came from the NFP seats."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true` | *Brak zmian stanu* | `[90]` **Player**: ""In accordance with Article 57 a..."<br>`[61]` **Player**: ""The police will be given increa..."<br>*(oraz 3 innych odgałęzień)* |
| `[50]` | **"Blame the ultranationalists for a plan to overthrow the government."** | `[44]` **Narrator**: "Applauses came from the NFP seats."<br>`[45]` **Narrator**: "Applauses came from the NFP seats."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true` | *Brak zmian stanu* | `[90]` **Player**: ""In accordance with Article 57 a..."<br>`[61]` **Player**: ""The police will be given increa..."<br>*(oraz 3 innych odgałęzień)* |
| `[60]` | **"Blame foreign powers for supporting extremist groups."** | `[44]` **Narrator**: "Applauses came from the NFP seats."<br>`[45]` **Narrator**: "Applauses came from the NFP seats."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Player**: ""In accordance with Article 57 a..."<br>`[61]` **Player**: ""The police will be given increa..."<br>*(oraz 3 innych odgałęzień)* |
| `[61]` | **""The police will be given increased authority...""** | `[48]` **Player**: ""On top of that, we have found t..."<br>`[49]` **Player**: ""On top of that, we have found t..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] == false`<br>`Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true` | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] = true;` | `[90]` **Player**: ""In accordance with Article 57 a..." |
| `[65]` | **""Surveillance capabilities of the State will be increased...""** | `[48]` **Player**: ""On top of that, we have found t..."<br>`[49]` **Player**: ""On top of that, we have found t..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] == false`<br>`Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true` | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] = true;` | `[90]` **Player**: ""In accordance with Article 57 a..." |
| `[69]` | **""Suspects will not require a trial to be detained...""** | `[48]` **Player**: ""On top of that, we have found t..."<br>`[49]` **Player**: ""On top of that, we have found t..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] == false`<br>`Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true` | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] = true;` | `[90]` **Player**: ""In accordance with Article 57 a..." |
| `[73]` | **""The right to assemble in protest will be suspended...""** | `[48]` **Player**: ""On top of that, we have found t..."<br>`[49]` **Player**: ""On top of that, we have found t..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == false`<br>`Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true` | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] = true;` | `[90]` **Player**: ""In accordance with Article 57 a..." |
| `[90]` | **""In accordance with Article 57...""** | `[48]` **Player**: ""On top of that, we have found t..."<br>`[49]` **Player**: ""On top of that, we have found t..."<br>*(oraz 6 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == true` | *Brak zmian stanu* | `[282]` **Player**: ""On the basis of said Articles, ..."<br>`[283]` **Player**: ""I hereby declare a state of eme..." |
| `[96]` | **"Continue with the speech."** | `[98]` **Narrator**: "I found a time to take a breathe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "I continued among applauses from..." |
| `[103]` | **""Can you please be quiet when I'm speaking, Mr. Leke?""** | `[98]` **Narrator**: "I found a time to take a breathe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "I continued among applauses from..." |
| `[105]` | **""Ladies and gentlemen of the Assembly! We must set aside our differences.""** | `[136]` **Narrator**: "I paused and took a look at the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "USP seats applauded." |
| `[137]` | **""Today, we must fight for Sordland!""** | `[136]` **Narrator**: "I paused and took a look at the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "USP seats applauded." |
| `[138]` | **""I ask everyone to understand our situation.""** | `[136]` **Narrator**: "I paused and took a look at the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "USP seats applauded." |
| `[142]` | **""We must finally be brave and strike down the red threat!""** | `[136]` **Narrator**: "I paused and took a look at the ..." | `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true` | *Brak zmian stanu* | `[143]` **Narrator**: "USP seats applauded." |
| `[144]` | **""I ask everybody to be patient.""** | `[143]` **Narrator**: "USP seats applauded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Player**: ""I assure you that this period w..."<br>`[152]` **Player**: ""The State will swiftly address ..."<br>*(oraz 2 innych odgałęzień)* |
| `[148]` | **""We will fight against the maximists together!""** | `[143]` **Narrator**: "USP seats applauded." | `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true` | *Brak zmian stanu* | `[149]` **Player**: ""I assure you that this period w..."<br>`[152]` **Player**: ""The State will swiftly address ..."<br>*(oraz 2 innych odgałęzień)* |
| `[149]` | **""I assure you that this period will not last long.""** | `[144]` **Player**: ""I ask everybody to be patient.""<br>`[148]` **Player**: ""We will fight against the maxim..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "I saluted the crowd." |
| `[150]` | **""We will eliminate all who oppose the State!""** | `[143]` **Narrator**: "USP seats applauded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Player**: ""I assure you that this period w..."<br>`[152]` **Player**: ""The State will swiftly address ..."<br>*(oraz 2 innych odgałęzień)* |
| `[151]` | **""We ask for everybody's cooperation and support.""** | `[143]` **Narrator**: "USP seats applauded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Player**: ""I assure you that this period w..."<br>`[152]` **Player**: ""The State will swiftly address ..."<br>*(oraz 2 innych odgałęzień)* |
| `[152]` | **""The State will swiftly address the situation.""** | `[144]` **Player**: ""I ask everybody to be patient.""<br>`[148]` **Player**: ""We will fight against the maxim..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "I saluted the crowd." |
| `[156]` | **""The Bludish Issue will finally be addressed!""** | `[144]` **Player**: ""I ask everybody to be patient.""<br>`[148]` **Player**: ""We will fight against the maxim..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | *Brak zmian stanu* | `[158]` **Narrator**: "I saluted the crowd." |
| `[157]` | **""Blud separatists will soon be eradicated!""** | `[144]` **Player**: ""I ask everybody to be patient.""<br>`[148]` **Player**: ""We will fight against the maxim..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | *Brak zmian stanu* | `[158]` **Narrator**: "I saluted the crowd." |
| `[159]` | **""For a free Sordland!""** | `[158]` **Narrator**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplauseShouting");` | `[163]` **Narrator**: "The Assembly roared with all kin..." |
| `[160]` | **""For a strong Sordland!""** | `[158]` **Narrator**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplauseShouting");` | `[163]` **Narrator**: "The Assembly roared with all kin..." |
| `[161]` | **""For peace in Sordland!""** | `[158]` **Narrator**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplauseShouting");` | `[163]` **Narrator**: "The Assembly roared with all kin..." |
| `[162]` | **""For the legacy of Soll!""** | `[158]` **Narrator**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplauseShouting");` | `[163]` **Narrator**: "The Assembly roared with all kin..." |
| `[197]` | **""Honorable Members of Assembly...""** | `[19]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""Sordland has gone through a cri..."<br>`[22]` **Player**: ""Sordland is going through criti..."<br>*(oraz 1 innych odgałęzień)* |
| `[198]` | **""Brothers and sisters...""** | `[19]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""Sordland has gone through a cri..."<br>`[22]` **Player**: ""Sordland is going through criti..."<br>*(oraz 1 innych odgałęzień)* |
| `[282]` | **""On the basis of said Articles, I hereby declare a state of emergency and order th..."** | `[90]` **Player**: ""In accordance with Article 57 a..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyLoud");` | `[91]` **Narrator**: "There was a loud reaction from t..." |
| `[283]` | **""I hereby declare a state of emergency in Sordland!""** | `[90]` **Player**: ""In accordance with Article 57 a..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyLoud");` | `[91]` **Narrator**: "There was a loud reaction from t..." |
| `[284]` | **""Show some respect!""** | `[98]` **Narrator**: "I found a time to take a breathe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "I continued among applauses from..." |

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
  - -> `[3]` (*Narrator: "I had recently signed the Emergency Act, which created a ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had recently signed the Emergency Act, which created a ruckus in the Sordish Police Forces and the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Now it was time to make a speech in the Assembly and decl..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Now it was time to make a speech in the Assembly and declare the emergency in public."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I walked with quick steps in the corridors of the Grand N..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I walked with quick steps in the corridors of the Grand National Assembly, giving my greetings to the people I encountered on my way towards the parliamentary hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyShouting");"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "When I entered the hall, the Assembly was in complete chaos, with shouting and cursing between the parties. There was a heavy argument about a proposal made by an MP from NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I took my seat inside the special area reserved for the m..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I took my seat inside the special area reserved for the ministers. Gloria was shouting from her seat at the center of the hall as she hit the gavel three times, with each strike heavier than the one before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Gloria Tory: "<shout>"ORDER! ORDER!"</shout>"*)

### Węzeł `[8]`
Mówca: **Gloria Tory**
> "<shout>"ORDER! ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "I saw Kesaro Kibener standing up from his seat and shouti..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Despite her efforts, the argument continued for a couple of minutes before everybody took back to their seats and finally went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Gloria Tory: ""Mr. Kibener, next time when I tell you to do so, either ..."*)

### Węzeł `[10]`
Mówca: **Gloria Tory**
> ""Mr. Kibener, next time when I tell you to do so, either take your seat or leave the hall; so we can proceed with the procedures of this Assembly and continue our duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Some MP's from the NFP side shouted back at her in protest."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Some MP's from the NFP side shouted back at her in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gloria Tory: ""Honorable ladies and gentlemen, if you allow me to conti..."*)

### Węzeł `[12]`
Mówca: **Gloria Tory**
> ""Honorable ladies and gentlemen, if you allow me to continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "She pointed at me with her hand."*)

### Węzeł `[13]`
Mówca: **Gloria Tory**
> ""We have the President here with us today. He has an important declaration to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The Assembly fell silent."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "I saw Kesaro Kibener standing up from his seat and shouting towards the members of the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gloria Tory: ""Mr. Kibener! Calm yourself! Show respect to the procedur..."*)

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""Mr. Kibener! Calm yourself! Show respect to the procedures of this Assembly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Despite her efforts, the argument continued for a couple ..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "She pointed at me with her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Gloria Tory: ""We have the President here with us today. He has an impo..."*)

### Węzeł `[17]`
Mówca: **Gloria Tory**
> ""The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I walked to the stand as loud clapping started in the USP..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "The Assembly fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""The President has the floor.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I walked to the stand as loud clapping started in the USP's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""Ladies and Gentlemen...""*)
  - -> `[197]` (*Player: ""Honorable Members of Assembly...""*)
  - -> `[198]` (*Player: ""Brothers and sisters...""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen...""]** — Mówca: **Player**
> ""Ladies and Gentlemen of the Grand National Assembly of Sordland! I am here today to present an important decision of the State concerning the recent troubling developments in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "Focus on the shooting of Bernard Circas."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Focus on the shooting of Bernard Circas."]** — Mówca: **Player**
> ""Sordland has gone through a critical day on January when Bernard Circas was shot by a militant member of the Young Sords. That day marked the beginning of terror against Sordland and its citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[197]` (Player), `[198]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "I brought attention to..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Focus on the clashes between the Red Youth and Young Sords."]** — Mówca: **Player**
> ""Sordland is going through critical times! The clashes between extremist political organizations have taken their fights to the streets and started threatening the national security of our country.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[197]` (Player), `[198]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "I brought attention to..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Focus on the Bludish Freedom Front and Rumburg's aid."]** — Mówca: **Player**
> ""Sordland has long been plagued by Bludish separatist groups inside our borders. Their threat, however, has never been greater. They have been heavily arming themselves with military aid from Rumburg against Sordland!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[197]` (Player), `[198]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "I brought attention to..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "I brought attention to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "The threat of the Bludish separatists."*)
  - -> `[43]` (*Player: "The threat of Rumburg."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "I brought attention to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[37]` (*Player: "The threat of extreme left and right wing groups in Sordl..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "I brought attention to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[37]` (*Player: "The threat of extreme left and right wing groups in Sordl..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || Ba..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "Focus on the clashes between the Red Youth and Young Sords."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "Focus on the Bludish Freedom Front and Rumburg's aid."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WYBÓR GRACZA: "The threat of the Young Sords and the right wing agenda."]** — Mówca: **Player**
> ""Young Sords and their actions against the public and the State can no longer be tolerated. Thus, the Sordish ultranationalist movement must be regarded as a national security threat from today onwards.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("VoteRoar");"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "The threat of the Young Sords and the right wing agenda."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA: "The threat of extreme left and right wing groups in Sordland."]** — Mówca: **Player**
> ""Sordland is clearly experiencing a dangerous civil strife between left and right wing extremist groups, which put our citizens lives in danger and act against our State in hopes of toppling our government. Today we find ourselves in a time of emergency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("VoteRoar");"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "The threat of the Red Youth and the left wing agenda."]** — Mówca: **Player**
> ""Red Youth and their actions against the public and the State can no longer be tolerated. Thus, the Sordish communist movement must be regarded as a national security threat from today onwards.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator), `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause2");"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "The threat of the Red Youth and the left wing agenda."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WYBÓR GRACZA: "The threat of the Bludish separatists."]** — Mówca: **Player**
> ""All Bludish separatist groups and the supporters of Bludish Freedom Front must be regarded as national security threats from today onwards. Sordland can no longer harbour these paramilitary organizations who plans to attack our sovereign nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause2");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "The threat of Rumburg."]** — Mówca: **Player**
> ""With the armament of the BFF, Rumburg has shown a clear aggressive stance against Sordland. They pose a major national security threat for our country. We must stay strong and be ready against their treacherous actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause2");"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Applauses came from the NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[60]` (*Player: "Blame foreign powers for supporting extremist groups."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Applauses came from the NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[60]` (*Player: "Blame foreign powers for supporting extremist groups."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The opposition members started yelling in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[60]` (*Player: "Blame foreign powers for supporting extremist groups."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "NFP members started yelling in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[60]` (*Player: "Blame foreign powers for supporting extremist groups."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Blame the Bludish separatists for a plan to occupy Bergia."]** — Mówca: **Player**
> ""On top of that, we have found that the Bludish separatists are planning to occupy the region of Bergia and form a new nation inside our borders. Therefore, the State has decided to take extraordinary measures to handle these threats swiftly.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[45]` (Narrator), `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "SpeechHub"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Blame the communists for a plan to overthrow the government."]** — Mówca: **Player**
> ""On top of that, we have found that the communists are planning to stage a communist revolution in Sordland by toppling our government. Therefore, the State has decided to take extraordinary measures to handle these threats swiftly.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[45]` (Narrator), `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "SpeechHub"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Blame the ultranationalists for a plan to overthrow the government."]** — Mówca: **Player**
> ""On top of that, we have found that the ultranationalists are planning to overthrow our government and bring a totalist maximist state. Therefore, the State has decided to take extraordinary measures to handle these threats swiftly.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[45]` (Narrator), `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "SpeechHub"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "Blame the ultranationalists for a plan to overthrow the g..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "Blame the communists for a plan to overthrow the government."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "Blame the Bludish separatists for a plan to occupy Bergia."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA: "Blame foreign powers for supporting extremist groups."]** — Mówca: **Player**
> ""The foreign powers are to be blamed! They are disrespecting the sovereignty of our nation and agitate and support these extremist groups against our country in hopes of toppling our government to establish a puppet state. The State will now react swiftly to these threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[45]` (Narrator), `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "SpeechHub"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""The police will be given increased authority...""]** — Mówca: **Player**
> ""The police will be given increased authority in regard to their use of force. Searching civilians and orders for confiscations will be permissible beyond their legal limits for the duration of the Emergency period.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] == false` AND `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player), `[49]` (Player), `[50]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_A = true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_A == false"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_B == false"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Surveillance capabilities of the State will be increased...""]** — Mówca: **Player**
> ""Surveillance capabilities of the State will be increased beyond their limits until further notice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] == false` AND `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player), `[49]` (Player), `[50]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_B = true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_C == false"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Suspects will not require a trial to be detained...""]** — Mówca: **Player**
> ""Suspects will not require a trial to be detained if said crime endangers the State and the wellbeing of its citizens.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] == false` AND `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player), `[49]` (Player), `[50]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_C = true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_D == false"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WYBÓR GRACZA: ""The right to assemble in protest will be suspended...""]** — Mówca: **Player**
> ""The right to assemble in protest will be suspended for the duration of the Emergency. All citizens are expected to abide by the law and the police is given permission to use force against assembled crowds.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == false` AND `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player), `[49]` (Player), `[50]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_D = true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SpeechHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolate..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_A == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_A == false"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_A_Speech_Hub_A == false)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_A == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""The police will be given increased authority...""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_A_Speech_Hub_A == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_B == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_B == false"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_A_Speech_Hub_B == false)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_B == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Surveillance capabilities of the State will be increased..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_A_Speech_Hub_B == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_C == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_C == false"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_A_Speech_Hub_C == false)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_C == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""Suspects will not require a trial to be detained...""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_A_Speech_Hub_C == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_D == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_D == false"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_A_Speech_Hub_D == false)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_D == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""The right to assemble in protest will be suspended...""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_A_Speech_Hub_D == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolated.Turn04_A_Speech_Hub_B || BaseGameIsolated.Turn04_A_Speech_Hub_C || BaseGameIsolated.Turn04_A_Speech_Hub_D == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolate..."*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsola..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolated.Turn04_A_Speech_Hub_B || BaseGameIsolated.Turn04_A_Speech_Hub_C || BaseGameIsolated.Turn04_A_Speech_Hub_D == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""In accordance with Article 57...""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolated.Turn04_A_Speech_Hub_B || BaseGameIsolated.Turn04_A_Speech_Hub_C || BaseGameIsolated.Turn04_A_Speech_Hub_D == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
**[WYBÓR GRACZA: ""In accordance with Article 57...""]** — Mówca: **Player**
> ""In accordance with Article 57 and 58 of the Constitution, the State holds the right to order for these measures to be taken in a situation of emergency like we have today.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Player), `[49]` (Player), `[50]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""On the basis of said Articles, I hereby declare a state ..."*)
  - -> `[283]` (*Player: ""I hereby declare a state of emergency in Sordland!""*)

### Węzeł `[91]`
Mówca: **Narrator**
> "There was a loud reaction from the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Mansoun Leke, a Bludish MP, who was regarded as the leade..."*)

### Węzeł `[92]`
Mówca: **Gloria Tory**
> ""The President has not finished!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "I found a time to take a breather during the loud commotion."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Gloria hit the gavel again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gloria Tory: ""The President has not finished!""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Mansoun Leke, a Bludish MP, who was regarded as the leader of the independents, jumped from his seat and started shouting at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Mansoun Leke: "<shout>"THIS IS TOTALISM!"</shout>"*)

### Węzeł `[95]`
Mówca: **Mansoun Leke**
> "<shout>"THIS IS TOTALISM!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Gloria hit the gavel again."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "Continue with the speech."]** — Mówca: **Player**
> ""These measures, although extraordinary, were completely necessary for us to take. We must be vigilant as a nation in times of crisis and surely we will be triumphant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "I continued among applauses from the USP seats."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SpeechHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "SpeechHub"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "I found a time to take a breather during the loud commotion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "Continue with the speech."*)
  - -> `[103]` (*Player: ""Can you please be quiet when I'm speaking, Mr. Leke?""*)
  - -> `[284]` (*Player: ""Show some respect!""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_C = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "Jump to: [SpeechHub]"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "Jump to: [SpeechHub]"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "Jump to: [SpeechHub]"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Speech_Hub_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "Jump to: [SpeechHub]"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Can you please be quiet when I'm speaking, Mr. Leke?""]** — Mówca: **Player**
> ""Can you please be quiet when I'm speaking, Mr. Leke?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "I continued among applauses from the USP seats."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "I continued among applauses from the USP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_None == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Assembly! We must set aside our differences.""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Assembly! We must set aside our differences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "USP seats applauded."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_None == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_None == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_None == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_None == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_None"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: ""We will be resuming with our foreign policy as usual dur..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_None == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_None"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[109]`
Mówca: **Narrator**
> ""We will be resuming with our foreign policy as usual during this period of Emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: ""We must be strong as a nation and preserve our connectio..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> ""In accordance with the Emergency Act, Sordland will sever all diplomatic ties with Rumburg for their treacherous actions. We will be responding with an embargo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: ""In accordance with the Emergency Act, Sordland will seve..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: ""In accordance with the Emergency Act, Sordland will seve..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[117]`
Mówca: **Narrator**
> ""In accordance with the Emergency Act, Sordland will sever all diplomatic ties with United Contana for their treacherous actions. We will be responding with an embargo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: ""Same measures will also be taken against United Contana...""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[121]`
Mówca: **Narrator**
> ""Same measures will also be taken against United Contana...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: ""In accordance with the Emergency Act, Sordland will seve..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Sordland will stand alone if needs be. Whatever the case..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> ""In accordance with the Emergency Act, Sordland will sever all diplomatic ties with Arcasia for their actions of treason against Sordland. We will be responding with an embargo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Sordland will stand alone if needs be. Whatever the case..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: ""Same measures will also be taken against Arcasia.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Sordland will stand alone if needs be. Whatever the case..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> ""Same measures will also be taken against Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Sordland will stand alone if needs be. Whatever the case..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: ""...And Arcasia.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Sordland will stand alone if needs be. Whatever the case..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> ""Sordland will stand alone if needs be. Whatever the case may be, we must be strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "I paused and took a look at the Assembly."*)

### Węzeł `[134]`
Mówca: **Narrator**
> ""...And Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Sordland will stand alone if needs be. Whatever the case..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> ""We must be strong as a nation and preserve our connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "I paused and took a look at the Assembly."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "I paused and took a look at the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""Ladies and gentlemen of the Assembly! We must set aside ..."*)
  - -> `[137]` (*Player: ""Today, we must fight for Sordland!""*)
  - -> `[138]` (*Player: ""I ask everyone to understand our situation.""*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Today, we must fight for Sordland!""]** — Mówca: **Player**
> ""Today, we must fight for Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "USP seats applauded."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""I ask everyone to understand our situation.""]** — Mówca: **Player**
> ""I ask everyone to understand our situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "USP seats applauded."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""We must finally be brave and strike down the red threat!""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""We must finally be brave and strike down the red threat!""]** — Mówca: **Player**
> ""We must finally be brave and strike down the red threat!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Kontekst wejściowy (poprzednik):** `[136]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "USP seats applauded."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "USP seats applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""We ask for everybody's cooperation and support.""*)
  - -> `[150]` (*Player: ""We will eliminate all who oppose the State!""*)
  - -> `[144]` (*Player: ""I ask everybody to be patient.""*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""I ask everybody to be patient.""]** — Mówca: **Player**
> ""I ask everybody to be patient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""I assure you that this period will not last long.""*)
  - -> `[152]` (*Player: ""The State will swiftly address the situation.""*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""We will fight against the maximists together!""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WYBÓR GRACZA: ""We will fight against the maximists together!""]** — Mówca: **Player**
> ""We will fight against the maximists together!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""I assure you that this period will not last long.""*)
  - -> `[152]` (*Player: ""The State will swiftly address the situation.""*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I assure you that this period will not last long.""]** — Mówca: **Player**
> ""I assure you that this period will not last long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Player), `[148]` (Player), `[150]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "I saluted the crowd."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""We will eliminate all who oppose the State!""]** — Mówca: **Player**
> ""We will eliminate all who oppose the State!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""I assure you that this period will not last long.""*)
  - -> `[152]` (*Player: ""The State will swiftly address the situation.""*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""We ask for everybody's cooperation and support.""]** — Mówca: **Player**
> ""We ask for everybody's cooperation and support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""I assure you that this period will not last long.""*)
  - -> `[152]` (*Player: ""The State will swiftly address the situation.""*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""The State will swiftly address the situation.""]** — Mówca: **Player**
> ""The State will swiftly address the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Player), `[148]` (Player), `[150]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "I saluted the crowd."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: ""The Bludish Issue will finally be addressed!""*)
  - -> `[157]` (*Player: ""Blud separatists will soon be eradicated!""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
**[WYBÓR GRACZA: ""The Bludish Issue will finally be addressed!""]** — Mówca: **Player**
> ""The Bludish Issue will finally be addressed!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Player), `[148]` (Player), `[150]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "I saluted the crowd."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""Blud separatists will soon be eradicated!""]** — Mówca: **Player**
> ""Blud separatists will soon be eradicated!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Player), `[148]` (Player), `[150]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "I saluted the crowd."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "I saluted the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: ""For a free Sordland!""*)
  - -> `[160]` (*Player: ""For a strong Sordland!""*)
  - -> `[161]` (*Player: ""For peace in Sordland!""*)
  - -> `[162]` (*Player: ""For the legacy of Soll!""*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""For a free Sordland!""]** — Mówca: **Player**
> ""For a free Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplauseShouting");"*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""For a strong Sordland!""]** — Mówca: **Player**
> ""For a strong Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplauseShouting");"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""For peace in Sordland!""]** — Mówca: **Player**
> ""For peace in Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplauseShouting");"*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""For the legacy of Soll!""]** — Mówca: **Player**
> ""For the legacy of Soll!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplauseShouting");"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "The Assembly roared with all kinds of different reactions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "While most of the USP members applauded, all of the oppos..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "While most of the USP members applauded, all of the opposition yelled in protest as I left the stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gloria Tory: ""Thank you for the announcement, Mr. President.""*)

### Węzeł `[165]`
Mówca: **Narrator**
> "The sounds of protest gradually increased as I walked towards my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[166]`
Mówca: **Gloria Tory**
> ""Thank you for the announcement, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "The sounds of protest gradually increased as I walked tow..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Mansoun Leke started yelling at me again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Mansoun Leke: "<shout>"YOU ARE JUST LIKE SOLL!"</shout>"*)

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> "<shout>"YOU ARE JUST LIKE SOLL!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Mansoun Leke: "<shout>"LEAVE BLUDISH PEOPLE ALONE!"</shout>"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Mansoun Leke started yelling at me again."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[172]`
Mówca: **Mansoun Leke**
> "<shout>"LEAVE BLUDISH PEOPLE ALONE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Kesaro stood up from his seat and walked closer to me and yelled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Kesaro Kibener: "<shout>"This is a mistake, Mr. President! How dare you ta..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Kesaro stood up from his seat and walked closer to me and..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Mansoun Leke started yelling at me again."*)

### Węzeł `[177]`
Mówca: **Kesaro Kibener**
> "<shout>"This is a mistake, Mr. President! How dare you target the nationalists?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Kesaro Kibener: "<shout>"Young Sords are a group of people who love their ..."*)

### Węzeł `[178]`
Mówca: **Kesaro Kibener**
> "<shout>"Young Sords are a group of people who love their country and Sordish culture! They are not the enemies!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Gloria started hitting the gavel again when the situation..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Gloria started hitting the gavel again when the situation..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Kesaro stood up from his seat and yelled back at Mansoun."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Kesaro stood up from his seat and yelled back at Mansoun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Kesaro Kibener: "<shout>"YOU LIVE IN SORDLAND, MR. LEKE!"</shout>"*)

### Węzeł `[183]`
Mówca: **Kesaro Kibener**
> "<shout>"YOU LIVE IN SORDLAND, MR. LEKE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Kesaro Kibener: "<shout>"YOU CANNOT FIGHT AGAINST THIS COUNTRY AND EXPECT ..."*)

### Węzeł `[184]`
Mówca: **Kesaro Kibener**
> "<shout>"YOU CANNOT FIGHT AGAINST THIS COUNTRY AND EXPECT IT NOT TO REACT!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Gloria started hitting the gavel again when the situation..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Mansoun Leke started yelling at me again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Mansoun Leke: "<shout>"Wasn't it enough that the ultranationalists murde..."*)

### Węzeł `[186]`
Mówca: **Mansoun Leke**
> "<shout>"Wasn't it enough that the ultranationalists murdered Bernard Circas in cold blood!?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Mansoun Leke: "<shout>"Now you are declaring a war against the left! You..."*)

### Węzeł `[187]`
Mówca: **Mansoun Leke**
> "<shout>"Now you are declaring a war against the left! You are just like Soll, Mr. President!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Mansoun Leke: "<shout>"A cold blooded nationalist!"</shout>"*)

### Węzeł `[188]`
Mówca: **Mansoun Leke**
> "<shout>"A cold blooded nationalist!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Kesaro stood up from his seat and yelled back at Mansoun."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Gloria started hitting the gavel again when the situation escalated further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Gloria Tory: "<shout>"ORDER!"</shout>"*)

### Węzeł `[190]`
Mówca: **Narrator**
> "Kesaro stood up from his seat and yelled back at Mansoun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Kesaro Kibener: "<shout>"HOW DARE YOU TALK LIKE THAT IN HERE?"</shout>"*)

### Węzeł `[191]`
Mówca: **Kesaro Kibener**
> "<shout>"HOW DARE YOU TALK LIKE THAT IN HERE?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Kesaro Kibener: "<shout>"YOU LIVE IN SORDLAND, MR. LEKE!"</shout>"*)

### Węzeł `[192]`
Mówca: **Kesaro Kibener**
> "<shout>"YOU LIVE IN SORDLAND, MR. LEKE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Gloria started hitting the gavel again when the situation..."*)

### Węzeł `[193]`
Mówca: **Gloria Tory**
> "<shout>"ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Gloria Tory: ""Gentlemen, when will you learn to behave like adults?""*)

### Węzeł `[194]`
Mówca: **Gloria Tory**
> ""Gentlemen, when will you learn to behave like adults?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Once I was sure the Assembly's attention was on Gloria, I..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Once I was sure the Assembly's attention was on Gloria, I left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "I walked back to the Palace in silence."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "I walked back to the Palace in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_Autocrat_Speech = true"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: ""Honorable Members of Assembly...""]** — Mówca: **Player**
> ""Honorable Members of the Grand National Assembly of Sordland! I am here today to present an important decision of the State concerning the recent troubling developments in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "Focus on the shooting of Bernard Circas."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters! I am here today to present an important decision of the State concerning the recent troubling developments in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "Focus on the shooting of Bernard Circas."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_Autocrat_Speech = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_Autocrat_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Poli..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_AutocratSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishProblem = false; BaseGame.S..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Policy_Law_Decree_Stronger = true; BaseGame.Policy_Law_Decree_Default = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] = true;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = true;
Variable["BaseGame.Policy_Law_Decree_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger = true; BaseGame.Ref..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_SomeHumanRights = false; BaseGame.Situation_Law_LimitedHumanRights = true; 
BaseGame.Situation_Law_ExpandedHumanRights = false;

BaseGame.Situation_Order_WideRangingSecurityPowers = true; 
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_LittleSecurityPowers = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = true;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishOppression = true; 
BaseGame.Policy_Law_Ban_WPB = true;
BaseGameSupport.Report_Turn03_Erzaren_Emergency_BludBanned = true;
BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGameSupport.Report_Turn03_Erzaren_Emergency_BludBanned"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingArcasia = true;
BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingArcasia = true; BaseG..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingUnitedContana = true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg = true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo = tru..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo = true..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo = tru..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true &..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true &..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo = tru..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo =..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo =..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo = true..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo = true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true &&..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_AllBanned = true..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true &&..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned = t..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true &&..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned = t..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && Ba..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned = tru..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_AllBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_AllBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_BludBanned = tru..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_RYBanned = true;..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Emergency_YSBanned = true;..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned = true; BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_BludBanned = true; BaseGame.Policy_Law_Ban_WPB = true;
BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_BludBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_RYBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_RYBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Emergency_YSBanned = true; BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_YSBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Emergency_Deal = true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_Emergency_NoDeal = true"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Emergency_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Emergency_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_G_Emergency = true; BaseGameS..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_Emergency_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Emergency_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_G_Emergency = true; BaseGameS..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_G_Emergency = true;
BaseGameSupport.News_Turn03_R_Emergency = true;
BaseGameSupport.News_Turn03_E_Emergency = true;
BaseGameSupport.Report_Turn03_Holsord_Emergency = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_G_Emergency"] = true;
Variable["BaseGameSupport.News_Turn03_R_Emergency"] = true;
Variable["BaseGameSupport.News_Turn03_E_Emergency"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_Emergency"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_AutocratSpeech = true"*)

### Węzeł `[282]`
**[WYBÓR GRACZA: ""On the basis of said Articles, I hereby declare a state of emergency and order the Emergency Act's swift execution.""]** — Mówca: **Player**
> ""On the basis of said Articles, I hereby declare a state of emergency and order the Emergency Act's swift execution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLoud");"*)

### Węzeł `[283]`
**[WYBÓR GRACZA: ""I hereby declare a state of emergency in Sordland!""]** — Mówca: **Player**
> ""I hereby declare a state of emergency in Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLoud");"*)

### Węzeł `[284]`
**[WYBÓR GRACZA: ""Show some respect!""]** — Mówca: **Player**
> ""Show some respect!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "I continued among applauses from the USP seats."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DetentionWithoutTrial = true; BaseG..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_Authority = true;  BaseGame.Public_..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SuspendedProtests = true; BaseGame...."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DetentionWithoutTrial = true;
BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_Authority = true; 
BaseGame.Public_Opinion  -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Order_Authority"] = true;
Variable["BaseGame.Public_Opinion"]  =  - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SuspendedProtests = true; BaseGame.Situation_Order_Prisons_Crowded = true;
BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Order_SuspendedProtests"] = true;
Variable["BaseGame.Situation_Order_Prisons_Crowded"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 3;
BaseGame.Malenyevist -= 1;
BaseGame.Capitalist -= 2;
BaseGame.Sollist += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 3;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 3;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_EmergencyDecree == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 3; BaseGame.Malenyevist -= 1; Base..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_EmergencyDecree == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 2;"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist -= 2;"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 2;"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = true; BaseGame..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "// End"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// End`
- **Efekt skryptowy (`userScript`):** `-- End;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_La..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "// End"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_LimitedHumanRights = true;
BaseGame.Situation_Law_SomeHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_LimitedHumanRights"] = true;
Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "// End"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true
||
BaseGame.Policy_Law_Ban_RedYouth == true 
|| 
BaseGame.Policy_Law_Ban_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_La..."*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true
||
BaseGame.Policy_Law_Ban_RedYouth == true 
|| 
BaseGame.Policy_Law_Ban_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true
 or 
Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true 
 or  
Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_LimitedHumanRights = true; BaseGam..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true
||
BaseGame.Policy_Law_Ban_RedYouth == true 
|| 
BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true
 or 
Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true 
 or  
Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "// End"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// End`
- **Efekt skryptowy (`userScript`):** `-- End;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger = true; BaseGame.Reform_Law_Decrees_Default = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] = true;
Variable["BaseGame.Reform_Law_Decrees_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = false; BaseGame...."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Arvory", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Narbel", "City_Widesprea..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Arvory", "City_Widesprea..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "// Emergency Declared"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Narbel", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Narbel","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_Widespre..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Valgen", "City_Widesprea..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Valgen", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Valgen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Vesord", "City_Widesprea..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Vesord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Vesord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "// Emergency Declared"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Emergency Declared`
- **Efekt skryptowy (`userScript`):** `-- Emergency Declared;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Morna", "City_Widespread..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "City_Widespre..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Benfi", "City_Widespread..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Borin", "City_Widespread..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Borin", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Borin","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lachaven", "City_Widespr..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lachaven", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Estord", "City_Widesprea..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Estord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Estord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erlory", "City_Widesprea..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erlory", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erlory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyShouting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "When I entered the hall, the Assembly was in complete cha..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("VoteRoar");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("VoteRoar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "NFP members started yelling in protest."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("VoteRoar");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("VoteRoar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The opposition members started yelling in protest."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Applauses came from the NFP seats."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Applauses came from the NFP seats."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Applauses came from the NFP seats."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyLoud");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "There was a loud reaction from the Assembly."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplauseShouting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplauseShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)
