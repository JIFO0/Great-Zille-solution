# Sordland/Turn06/PSnW_HealthBudget

- **ID konwersacji:** `89`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/089_PSnW_HealthBudget.md`
- **Liczba węzłów dialogowych:** 289
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Economy`
- `BaseGame.Healthcare`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Walter_Promise_Privatization`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Maintain`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn06_PSnW_Healthcare_Hospitals`
- `BaseGame.Turn06_PSnW_Healthcare_ImproveRural`
- `BaseGame.Turn06_PSnW_Healthcare_Privatization`
- `BaseGame.Turn06_PSnW_Healthcare_Salary`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.HealthBudget_Hub_Option1`
- `BaseGameIsolated.HealthBudget_Hub_Option2`
- `BaseGameIsolated.HealthBudget_Hub_Option3`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Economy_Bergia`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.GovernmentBudget`
- `BaseGame.Healthcare`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Policy_Welfare_HealthPrivatization`
- `BaseGame.Policy_Welfare_TraditionalEducation`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Walter_Promise_PrivatizationFulfilled`
- `BaseGame.SSC_2ndProject_Cheaper`
- `BaseGame.SSC_2ndProject_Expensive`
- `BaseGame.Situation_Economy_PandemicFallout`
- `BaseGame.Situation_Welfare_FailedEducationReform`
- `BaseGame.Situation_Welfare_HappyHealthWorkers`
- `BaseGame.Situation_Welfare_HealthGap`
- `BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare`
- `BaseGame.Situation_Welfare_ModernEducationTechniques`
- `BaseGame.Situation_Welfare_NewHospitals`
- `BaseGame.Situation_Welfare_QualityRuralHealthServices`
- `BaseGame.Situation_Welfare_SollistTeachings`
- `BaseGame.Sollist`
- `BaseGame.Taurus_2ndProject_Cheaper`
- `BaseGame.Taurus_2ndProject_Expensive`
- `BaseGame.Turn06_PSnW_Healthcare_Hospitals`
- `BaseGame.Turn06_PSnW_Healthcare_ImproveRural`
- `BaseGame.Turn06_PSnW_Healthcare_Privatization`
- `BaseGame.Turn06_PSnW_Healthcare_Salary`
- `BaseGameIsolated.HealthBudget_Hub_Option1`
- `BaseGameIsolated.HealthBudget_Hub_Option2`
- `BaseGameIsolated.HealthBudget_Hub_Option3`
- `BaseGameSupport.CountryReport_Turn06_Wehlen_BorderGuard`
- `BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation`
- `BaseGameSupport.CountryReport_Turn06_Wehlen_NoWehlenDeal`
- `BaseGameSupport.Journal_Turn06_Health_ImprovedRural`
- `BaseGameSupport.Journal_Turn06_Health_NewHospitals`
- `BaseGameSupport.Journal_Turn06_Health_Privatised`
- `BaseGameSupport.Journal_Turn06_Health_SalariesIncreased`
- `BaseGameSupport.Journal_Turn06_Health_State`
- `BaseGameSupport.News_Turn06_E_HealthcarePrivatized`
- `BaseGameSupport.News_Turn06_G_HeljilandGovernor`
- `BaseGameSupport.News_Turn06_HP_EmergencyYS_Extended`
- `BaseGameSupport.News_Turn06_R_HealthcarePrivatized`
- `BaseGameSupport.News_Turn06_ST_BludsCrossBorder_Operation`
- `BaseGameSupport.Report_Turn06_Holsord_YSJournalistReleased`
- `BaseGameSupport.Report_Turn06_Uziren_BludsCrossBorder`
- `GameCondition.Turn06_PSnW_HealthBudget`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“Very well. Let's begin.”"** | `[7]` **Paskal Beniwoll**: "“Good afternoon.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "They have taken their seats and ..." |
| `[9]` | **"“Please take your seats.”"** | `[7]` **Paskal Beniwoll**: "“Good afternoon.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "They have taken their seats and ..." |
| `[10]` | **"Nod."** | `[7]` **Paskal Beniwoll**: "“Good afternoon.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "Paskal looked at the newspaper I..." |
| `[15]` | **"“Indeed. This might have dire consequences in the region.”"** | `[14]` **Paskal Beniwoll**: "“I have just returned from a mee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "He nodded." |
| `[16]` | **"“I'm not worried. It will stop before it reaches Sordland.”"** | `[14]` **Paskal Beniwoll**: "“I have just returned from a mee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Paskal Beniwoll**: "“What I was told by our research..." |
| `[36]` | **"“We will have to make do with what we have. I want you to lead the way to solution..."** | `[35]` **Paskal Beniwoll**: "“But I'm still happy that the ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Paskal Beniwoll**: "“I don't see many ways out of th..." |
| `[39]` | **"“I'm sure you can figure out a way to come out of this strong. I have put trust in..."** | `[31]` **Paskal Beniwoll**: "“The reduction of health funds i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Paskal Beniwoll**: "“I don't think that this is a ma..." |
| `[41]` | **"“Our health services seem to be working fine and don't require more investment. I'..."** | `[35]` **Paskal Beniwoll**: "“But I'm still happy that the ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Paskal Beniwoll**: "“I don't see many ways out of th..." |
| `[42]` | **"“Healthcare isn't a urgency for this administration. We have to make do with less.”"** | `[31]` **Paskal Beniwoll**: "“The reduction of health funds i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Paskal Beniwoll**: "“I don't think that this is a ma..." |
| `[43]` | **"“We have to minimize service disparity in the country. The situation isn't good at..."** | `[30]` **Paskal Beniwoll**: "“The overall mood has been posit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Paskal Beniwoll**: "“I'm personally invested to solv..." |
| `[44]` | **"“Providing better healthcare is our goal. This administration will be known to hav..."** | `[30]` **Paskal Beniwoll**: "“The overall mood has been posit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Paskal Beniwoll**: "“I'm personally invested to solv..." |
| `[53]` | **"“Do you have any specific areas of focus in mind?”"** | `[30]` **Paskal Beniwoll**: "“The overall mood has been posit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Paskal Beniwoll**: "“I'm personally invested to solv..." |
| `[62]` | **"“What kind of concessions?”"** | `[31]` **Paskal Beniwoll**: "“The reduction of health funds i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Paskal Beniwoll**: "“I am still formulating a plan.”" |
| `[73]` | **"“You are right. There might be structural issues... Especially due to private gree..."** | `[69]` **Lucian Galade**: "“Aside from creating additional ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: "“Also in a country where most pe..." |
| `[74]` | **"“I don't see a problem with privatization. It would create additional funds and bo..."** | `[69]` **Lucian Galade**: "“Aside from creating additional ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lucian Galade**: "“For now it wouldn't. Privatizat..." |
| `[79]` | **"“What are those problems?”"** | `[69]` **Lucian Galade**: "“Aside from creating additional ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Lucian Galade**: "“People are already lacking prop..." |
| `[84]` | **"“We'll keep healthcare in state control. Don't allow any private involvement that ..."** | `[82]` **Lucian Galade**: "“But the choice is yours, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn06_Health_State"] =...` | `[93]` **Paskal Beniwoll**: "“As you wish. The health service..." |
| `[86]` | **"“Building new hospitals sounds interesting. It would also boost our popularity.”"** | `[132]` **Paskal Beniwoll**: "“Each of these options presents ..."<br>`[127]` **Lucian Galade**: ""It's a visible, tangible improv..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == false` | *Brak zmian stanu* | `[131]` **Paskal Beniwoll**: ""While the construction of new h..." |
| `[105]` | **"“Improve rural treatment by hiring health staff and upgrading equipment in rural a..."** | `[135]` **Narrator**: "A few minutes went by in contemp..." | `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false` | `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] ...`<br>`Variable["BaseGame.Situation_Welfare_LackOfQualityRuralHe...`<br>*(+2 skryptów)* | `[147]` **Paskal Beniwoll**: "“New contracts for improvements ..." |
| `[106]` | **"“Increase salaries of doctors, nurses and other health staff with incentives for r..."** | `[135]` **Narrator**: "A few minutes went by in contemp..." | `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false` | `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true...`<br>`Variable["BaseGame.Situation_Welfare_HappyHealthWorkers"]...`<br>*(+1 skryptów)* | `[153]` **Paskal Beniwoll**: "“I'll prepare the increase as so..." |
| `[107]` | **"“Build new hospitals where they are needed. Access to health will be available for..."** | `[135]` **Narrator**: "A few minutes went by in contemp..." | `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false` | `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] = t...`<br>`Variable["BaseGame.Situation_Welfare_NewHospitals"] = true;`<br>*(+1 skryptów)* | `[154]` **Paskal Beniwoll**: "“We shall begin plans of hospita..." |
| `[125]` | **"“Just the way I like it.”"** | `[103]` **Lucian Galade**: "“Very well. Fruitful meeting nev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Paskal gathered his documents an..." |
| `[126]` | **"“Thank you for the meeting.”"** | `[103]` **Lucian Galade**: "“Very well. Fruitful meeting nev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Paskal gathered his documents an..." |
| `[136]` | **"“Increasing salaries should have a good effect for doctors, nurses and other staff..."** | `[132]` **Paskal Beniwoll**: "“Each of these options presents ..."<br>`[127]` **Lucian Galade**: ""It's a visible, tangible improv..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == false` | *Brak zmian stanu* | `[141]` **Paskal Beniwoll**: ""There's merit in the proposal t..." |
| `[137]` | **"“Improving treatment in rural areas is a must. It would prevent mistreatment, dise..."** | `[132]` **Paskal Beniwoll**: "“Each of these options presents ..."<br>`[127]` **Lucian Galade**: ""It's a visible, tangible improv..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == false` | *Brak zmian stanu* | `[128]` **Paskal Beniwoll**: ""The sad reality is that our rur..." |
| `[157]` | **"“Dismissed.”"** | `[103]` **Lucian Galade**: "“Very well. Fruitful meeting nev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Paskal gathered his documents an..." |
| `[158]` | **"“What are we doing to prepare?”"** | `[14]` **Paskal Beniwoll**: "“I have just returned from a mee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Paskal Beniwoll**: "“We have notified all of our hea..." |
| `[166]` | **"“Why am I just learning this from a newspaper?”"** | `[14]` **Paskal Beniwoll**: "“I have just returned from a mee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Paskal Beniwoll**: "“We are already evaluating the s..." |
| `[168]` | **"“It was not a decision that I made lightly.”"** | `[35]` **Paskal Beniwoll**: "“But I'm still happy that the ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Paskal Beniwoll**: "“I am sure, Mr. President. I am ..." |
| `[170]` | **"“It was not a decision that I made lightly.”"** | `[31]` **Paskal Beniwoll**: "“The reduction of health funds i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Paskal Beniwoll**: "“I am sure, Mr. President. I am ..." |
| `[172]` | **"“Build new hospitals where they are needed. Access to health will be available for..."** | `[129]` **Paskal Beniwoll**: "“We can initiate one more spendi..." | `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false` | `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] = t...`<br>`Variable["BaseGame.Situation_Welfare_NewHospitals"] = true;`<br>*(+1 skryptów)* | `[192]` **Paskal Beniwoll**: "“We shall begin plans of hospita..." |
| `[174]` | **"“Improve rural treatment by hiring health staff and upgrading equipment in rural a..."** | `[129]` **Paskal Beniwoll**: "“We can initiate one more spendi..." | `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false` | `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] ...`<br>`Variable["BaseGame.Situation_Welfare_LackOfQualityRuralHe...`<br>*(+2 skryptów)* | `[193]` **Paskal Beniwoll**: "“New contracts for improvements ..." |
| `[175]` | **"“Increase salaries of doctors, nurses and other health staff with incentives for r..."** | `[129]` **Paskal Beniwoll**: "“We can initiate one more spendi..." | `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false` | `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true...`<br>`Variable["BaseGame.Situation_Welfare_HappyHealthWorkers"]...`<br>*(+1 skryptów)* | `[191]` **Paskal Beniwoll**: "“I'll prepare the increase as so..." |
| `[274]` | **"“We can proceed with the decision, Minister Beniwoll.”"** | `[132]` **Paskal Beniwoll**: "“Each of these options presents ..."<br>`[127]` **Lucian Galade**: ""It's a visible, tangible improv..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == true` | *Brak zmian stanu* | `[259]` **Paskal Beniwoll**: ""In my book 'The Unfortunate Man..." |
| `[282]` | **"“We will promote privatization and allow the private sector to invest and buy gove..."** | `[82]` **Lucian Galade**: "“But the choice is yours, Mr. Pr..." | `Variable["BaseGame.Economy"] >= 5` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"]...`<br>*(+4 skryptów)* | `[92]` **Paskal Beniwoll**: "“Excellent. We can turn that ext..." |
| `[287]` | **"“We will promote privatization and allow the private sector to invest and buy gove..."** | `[82]` **Lucian Galade**: "“But the choice is yours, Mr. Pr..." | `(Variable["BaseGame.Economy"] >= 5) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"]...`<br>*(+4 skryptów)* | `[92]` **Paskal Beniwoll**: "“Excellent. We can turn that ext..." |

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
  - -> `[3]` (*Narrator: "I was having my afternoon tea in the state house office i..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was having my afternoon tea in the state house office in Deyr and going through newspapers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "One of the headlines piqued my interest. It read 'Polio C..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "One of the headlines piqued my interest. It read 'Polio Crisis in Wehlen'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Before I could start reading, I heard a couple of knocks...."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Before I could start reading, I heard a couple of knocks. Paskal entered followed by Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: "“Mr. President. It's time for the scheduled healthcare me..."*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> "“Mr. President. It's time for the scheduled healthcare meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Paskal Beniwoll: "“Good afternoon.”"*)

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
> "“Good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“Please take your seats.”"*)
  - -> `[8]` (*Player: "“Very well. Let's begin.”"*)
  - -> `[10]` (*Player_Italic: "Nod."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Very well. Let's begin.”"]** — Mówca: **Player**
> "“Very well. Let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "They have taken their seats and Paskal produced documents..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Please take your seats.”"]** — Mówca: **Player**
> "“Please take your seats.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "They have taken their seats and Paskal produced documents..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and they have taken their seats and Paskal produced documents from his suitcase. He put them on the table."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Paskal looked at the newspaper I was reading."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "They have taken their seats and Paskal produced documents from his suitcase. He put them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Paskal looked at the newspaper I was reading."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Paskal looked at the newspaper I was reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Paskal Beniwoll: "“Very troubling news from Wehlen, Mr. President.”"*)

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
> "“Very troubling news from Wehlen, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Paskal Beniwoll: "“I have just returned from a meeting with our top scienti..."*)

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
> "“I have just returned from a meeting with our top scientists on the matter of Polio. It seems to be spreading.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“Indeed. This might have dire consequences in the region.”"*)
  - -> `[16]` (*Player: "“I'm not worried. It will stop before it reaches Sordland.”"*)
  - -> `[158]` (*Player: "“What are we doing to prepare?”"*)
  - -> `[166]` (*Player: "“Why am I just learning this from a newspaper?”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Indeed. This might have dire consequences in the region.”"]** — Mówca: **Player**
> "“Indeed. This might have dire consequences in the region.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "He nodded."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I'm not worried. It will stop before it reaches Sordland.”"]** — Mówca: **Player**
> "“I'm not worried. It will stop before it reaches Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Paskal Beniwoll: "“What I was told by our researchers was that with the cur..."*)

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
> "“What I was told by our researchers was that with the current infection rate there will soon be millions of people affected by Polio.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Paskal Beniwoll: "“So we have notified all of our healthcare staff especial..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Paskal Beniwoll: "“What I was told by our researchers was that with the cur..."*)

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
> "“We need to be ready for any possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“I doubt it is that serious yet.”"*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“I doubt it is that serious yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“Regardless, back to the topic. Mr. Beniwoll.”"*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“Regardless, back to the topic. Mr. Beniwoll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Paskal put on his reading glasses and went through the do..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“Mr. Beniwoll?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Paskal Beniwoll: "“Yes. Yes, of course. Let's start.”"*)

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
> "“Yes. Yes, of course. Let's start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He put the papers down, cleared his throat and looked at me."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Paskal put on his reading glasses and went through the documents. He didn't say anything for a whole minute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“Mr. Beniwoll?”"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "He put the papers down, cleared his throat and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Paskal Beniwoll: "“In general, I am very content with the budget decision t..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true"*)

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
> "“As you know, I have been preparing a new privatization program that would create funds through selling of unused ministry property and some extra taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
> "“The overall mood has been positive as the administration focuses more on the healthcare. I'm excited about what we can achieve with the allocated funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“Do you have any specific areas of focus in mind?”"*)
  - -> `[44]` (*Player: "“Providing better healthcare is our goal. This administra..."*)
  - -> `[43]` (*Player: "“We have to minimize service disparity in the country. Th..."*)

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
> "“The reduction of health funds is going to hurt no matter how we manage it. I will need to make big concessions, which will hamper our efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“Healthcare isn't a urgency for this administration. We h..."*)
  - -> `[39]` (*Player: "“I'm sure you can figure out a way to come out of this st..."*)
  - -> `[62]` (*Player: "“What kind of concessions?”"*)
  - -> `[170]` (*Player: "“It was not a decision that I made lightly.”"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Paskal Beniwoll: "“In general, the ministry is somewhat content with the bu..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Paskal Beniwoll: "“In general, the ministry is not very content with the de..."*)

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
> "“But I'm still happy that the administration continues to support healthcare at the same level as before. Though, this limits our options significantly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“Our health services seem to be working fine and don't re..."*)
  - -> `[36]` (*Player: "“We will have to make do with what we have. I want you to..."*)
  - -> `[168]` (*Player: "“It was not a decision that I made lightly.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“We will have to make do with what we have. I want you to lead the way to solutions in healthcare.”"]** — Mówca: **Player**
> "“We will have to make do with what we have. I want you to lead the way to solutions in healthcare.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Paskal Beniwoll: "“I don't see many ways out of this particular situation. ..."*)

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
> "“I don't think that this is a matter that can be easily solved. More thought needs to be put in how do we go about lowering our budget or where do we cut it from.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Paskal Beniwoll: "“As you know, I have been preparing a new privatization p..."*)

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
> "“I'm personally invested to solve the horrible infant and maternal death rates along with your requests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Paskal Beniwoll: "“As you know, I have been preparing a new privatization p..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I'm sure you can figure out a way to come out of this strong. I have put trust in you.”"]** — Mówca: **Player**
> "“I'm sure you can figure out a way to come out of this strong. I have put trust in you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Paskal Beniwoll: "“I don't think that this is a matter that can be easily s..."*)

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
> "“I don't see many ways out of this particular situation. We need funds to bring improvements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Paskal Beniwoll: "“As you know, I have been preparing a new privatization p..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Our health services seem to be working fine and don't require more investment. I'm sure we can improve what we have.”"]** — Mówca: **Player**
> "“Our health services seem to be working fine and don't require more investment. I'm sure we can improve what we have.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Paskal Beniwoll: "“I don't see many ways out of this particular situation. ..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Healthcare isn't a urgency for this administration. We have to make do with less.”"]** — Mówca: **Player**
> "“Healthcare isn't a urgency for this administration. We have to make do with less.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Paskal Beniwoll: "“I don't think that this is a matter that can be easily s..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“We have to minimize service disparity in the country. The situation isn't good at all.”"]** — Mówca: **Player**
> "“We have to minimize service disparity in the country. The situation isn't good at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Paskal Beniwoll: "“I'm personally invested to solve the horrible infant and..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Providing better healthcare is our goal. This administration will be known to have supported the welfare services.”"]** — Mówca: **Player**
> "“Providing better healthcare is our goal. This administration will be known to have supported the welfare services.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Paskal Beniwoll: "“I'm personally invested to solve the horrible infant and..."*)

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
> "“In general, I am very content with the budget decision that was made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
> "“In general, the ministry is somewhat content with the budget decision that was made. At least we didn't get a cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
> "“In general, the ministry is not very content with the decision to cut the budget of our healthcare system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Paskal Beniwoll: "“This comes as no surprise as I know you are a man of you..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Paskal Beniwoll: "“This comes as a very pleasant surprise that we all welco..."*)

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
> "“This comes as no surprise as I know you are a man of your word. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Paskal Beniwoll: "“The overall mood has been positive as the administration..."*)

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
> "“This comes as a very pleasant surprise that we all welcomed at the ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Paskal Beniwoll: "“The overall mood has been positive as the administration..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Do you have any specific areas of focus in mind?”"]** — Mówca: **Player**
> "“Do you have any specific areas of focus in mind?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Paskal Beniwoll: "“I'm personally invested to solve the horrible infant and..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Paskal Beniwoll: "“Although, I have to say this came as a surprise to many ..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Paskal Beniwoll: "“But I'm still happy that the administration continues to..."*)

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
> "“Although, I have to say this came as a surprise to many since one of our campaign focuses was healthcare. I am not sure if we're abiding by that promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Paskal Beniwoll: "“But I'm still happy that the administration continues to..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Paskal Beniwoll: "“Although, I have to say this came as a surprise to many ..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Paskal Beniwoll: "“The reduction of health funds is going to hurt no matter..."*)

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
> "“Although, I have to say this came as a surprise to many since one of our campaign focuses was healthcare. I am not sure if we're abiding by that promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Paskal Beniwoll: "“The reduction of health funds is going to hurt no matter..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“What kind of concessions?”"]** — Mówca: **Player**
> "“What kind of concessions?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Paskal Beniwoll: "“I am still formulating a plan.”"*)

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
> "“I am still formulating a plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Paskal Beniwoll: "“I don't think that this is a matter that can be easily s..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> "“I know of this too, Paskal. But this goes against our economic doctrine. Additionally, health is a key sector people expect to have in public hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“Aside from creating additional funds, there is a long-te..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: "“I know of this too, Paskal. But this goes against our ec..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: "“It might not go against our strategy to promote a market..."*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“It might not go against our strategy to promote a market economy, but I'm personally against privatization of government services. Such vital services must be under state control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“Aside from creating additional funds, there is a long-te..."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“Aside from creating additional funds, there is a long-term problem with privatization in a country like Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“I don't see a problem with privatization. It would creat..."*)
  - -> `[73]` (*Player: "“You are right. There might be structural issues... Espec..."*)
  - -> `[79]` (*Player: "“What are those problems?”"*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“Messing with that structure will definitely hurt us politically in the future. That I know for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: "“But the choice is yours, Mr. President.”"*)

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
> "“The market should take care of it by itself. We can't regulate people like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“This is not Arcasia nor Lespia. You are talking about So..."*)

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
> "“I do agree that there is some concern there... But the benefits of competitive and quality services is greater.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“This is not Arcasia nor Lespia. You are talking about So..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“You are right. There might be structural issues... Especially due to private greed and market manipulation.”"]** — Mówca: **Player**
> "“You are right. There might be structural issues... Especially due to private greed and market manipulation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: "“Also in a country where most people don't have access to..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I don't see a problem with privatization. It would create additional funds and boost enterprise.”"]** — Mówca: **Player**
> "“I don't see a problem with privatization. It would create additional funds and boost enterprise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: "“For now it wouldn't. Privatization would be fair if our ..."*)

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
> "“We will prevent the worst case scenarios. There needs to be healthy structural improvements in this sector.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“This is not Arcasia nor Lespia. You are talking about So..."*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Also in a country where most people don't have access to quality healthcare...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Paskal Beniwoll: "“I do agree that there is some concern there... But the b..."*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“People are already lacking proper healthcare even though it is free. What happens when you privatise? Prices increase as state hospitals close due to sales.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Paskal Beniwoll: "“We will prevent the worst case scenarios. There needs to..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“For now it wouldn't. Privatization would be fair if our healthcare standards were high and accessible for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Paskal Beniwoll: "“The market should take care of it by itself. We can't re..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“What are those problems?”"]** — Mówca: **Player**
> "“What are those problems?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: "“People are already lacking proper healthcare even though..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“This is not Arcasia nor Lespia. You are talking about Sordland, in which the healthcare is free for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: "“We have people who have their lives depending on a servi..."*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“We have people who have their lives depending on a service that is free to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“Messing with that structure will definitely hurt us poli..."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“But the choice is yours, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)
  - -> `[84]` (*Player: "“We'll keep healthcare in state control. Don't allow any ..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_HealthPrivatization = true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“We'll keep healthcare in state control. Don't allow any private involvement that could endanger core health services.”"]** — Mówca: **Player**
> "“We'll keep healthcare in state control. Don't allow any private involvement that could endanger core health services.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_State = true; BaseG..."*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""It's largely due to outdated facilities that lack proper hygiene standards and equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option3 = true"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Building new hospitals sounds interesting. It would also boost our popularity.”"]** — Mówca: **Player**
> "“Building new hospitals sounds interesting. It would also boost our popularity.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == false`
- **Kontekst wejściowy (poprzednik):** `[132]` (Paskal Beniwoll), `[127]` (Lucian Galade), `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Paskal Beniwoll: ""While the construction of new hospitals is an appealing ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_HealthPrivatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_HealthPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HealthGap = true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HealthGap = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_HealthGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Healthcare += 1"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_PSnW_HealthBudget = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_PSnW_HealthBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_TraditionalEducation = true;
BaseGame.Situation_Welfare_SollistTeachings = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true;
Variable["BaseGame.Situation_Welfare_SollistTeachings"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Healthcare += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Healthcare"] = Variable["BaseGame.Healthcare"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_Privatised = true; ..."*)

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
> "“Excellent. We can turn that extra money to something useful. I shall let my partners know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: "“I don't think this was the right choice.”"*)

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
> "“As you wish. The health services shall remain in public hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“Good choice.”"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HappyHealthWorkers = true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Paskal Beniwoll: "“Now let's get to the big question of how we will spend t..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true &&..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true &&..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Paskal Beniwoll: "“Since we will have extra funds, the spending policy ques..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“I don't think this was the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“Good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“Very well. Fruitful meeting nevertheless. Nice and short.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Just the way I like it.”"*)
  - -> `[126]` (*Player: "“Thank you for the meeting.”"*)
  - -> `[157]` (*Player: "“Dismissed.”"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationReform = false;
BaseGame.Situation_Welfare_FailedEducationReform = true;
BaseGame.Situation_Welfare_ModernEducationTechniques = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationReform"] = false;
Variable["BaseGame.Situation_Welfare_FailedEducationReform"] = true;
Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_TraditionalEducation = true; Base..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"]** — Mówca: **Player**
> "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural = true; Base..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"]** — Mówca: **Player**
> "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary = true; BaseGame.P..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Build new hospitals where they are needed. Access to health will be available for all.”"]** — Mówca: **Player**
> "“Build new hospitals where they are needed. Access to health will be available for all.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals = true; BaseGam..."*)

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
> "“Since we will have extra funds, the spending policy question remains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Paskal Beniwoll: "“I urge you to consider these proposals. We could build n..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural = true;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare =..."*)

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
> "“Now let's get to the big question of how we will spend the extra funds dedicated to the Ministry of Health.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Paskal Beniwoll: "“I urge you to consider these proposals. We could build n..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“Improve rural treatment by hiring health staff and upgra..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == false"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Salary == false)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“Increase salaries of doctors, nurses and other health st..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Salary == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true )"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == true"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Paskal gathered his documents and left along with Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == false"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“Build new hospitals where they are needed. Access to hea..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewHospitals = true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Just the way I like it.”"]** — Mówca: **Player**
> "“Just the way I like it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Paskal gathered his documents and left along with Lucian."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Thank you for the meeting.”"]** — Mówca: **Player**
> "“Thank you for the meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Paskal gathered his documents and left along with Lucian."*)

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""It's a visible, tangible improvement that we can present as our achievement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option1 = true"*)

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
> ""The sad reality is that our rural clinics are woefully outdated, ill-equipped, and understaffed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Paskal Beniwoll: ""This stark disparity between urban and rural healthcare ..."*)

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
> "“We can initiate one more spending policy with our funds. Which one would should we initiate?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == false"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == false"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false"*)

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
> "“I urge you to consider these proposals. We could build new hospitals where necessary, divert funds to increase the salaries of our health workers, or invest in enhancing the existing treatment facilities in rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Paskal Beniwoll: "“Each of these options presents a unique path towards imp..."*)

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
> ""While the construction of new hospitals is an appealing idea, I personally don't see it as a primary concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Paskal Beniwoll: ""In my view, the pressing issue lies in the quality and a..."*)

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
> "“Each of these options presents a unique path towards improving healthcare access and quality in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "HealthBudgetChoices"*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""However, implementing a nationwide, proportional salary boost would pay off politically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option2 = true"*)

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
> "“Therefore, I believe improving treatment in rural areas should be our course of action, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“It would be best to consider the political advantages of..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "A few minutes went by in contemplation as the moment to make a decision came near."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == false"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == false"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Increasing salaries should have a good effect for doctors, nurses and other staff who work so hard for our citizens.”"]** — Mówca: **Player**
> "“Increasing salaries should have a good effect for doctors, nurses and other staff who work so hard for our citizens.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == false`
- **Kontekst wejściowy (poprzednik):** `[132]` (Paskal Beniwoll), `[127]` (Lucian Galade), `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Paskal Beniwoll: ""There's merit in the proposal to increase salaries for a..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Improving treatment in rural areas is a must. It would prevent mistreatment, disease and sickness.”"]** — Mówca: **Player**
> "“Improving treatment in rural areas is a must. It would prevent mistreatment, disease and sickness.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == false`
- **Kontekst wejściowy (poprzednik):** `[132]` (Paskal Beniwoll), `[127]` (Lucian Galade), `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Paskal Beniwoll: ""The sad reality is that our rural clinics are woefully o..."*)

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
> ""Well, that wraps up our discussion for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“Very well. Fruitful meeting nevertheless. Nice and short.”"*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“It would be best to consider the political advantages of each one, as well as the practical advantages before making a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "A few minutes went by in contemplation as the moment to m..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewHospitals = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_NewHospitals = true"*)

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
> ""There's merit in the proposal to increase salaries for all health staff, with an extra emphasis on rural areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Paskal Beniwoll: ""This approach could incentivize doctors and nurses to wo..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_ImprovedRural = true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Paskal Beniwoll: "“We can initiate one more spending policy with our funds...."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Paskal Beniwoll: ""Well, that wraps up our discussion for now.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices = true"*)

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
> "“New contracts for improvements will be drawn up immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HappyHealthWorkers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyHealthWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_SalariesIncreased =..."*)

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
> ""In my view, the pressing issue lies in the quality and accessibility of healthcare in remote areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Paskal Beniwoll: ""But certainly, adding new healthcare facilities would be..."*)

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
> ""This approach could incentivize doctors and nurses to work in these regions where their services are desperately needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Paskal Beniwoll: ""On a larger scale, it would boost satisfaction within th..."*)

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
> ""This stark disparity between urban and rural healthcare is a major contributor to the high maternal mortality rates and prevalence of other diseases in our rural communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Paskal Beniwoll: ""Addressing this issue is one of my key objectives in thi..."*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Constructing new hospitals would score us significant political points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: ""It's a visible, tangible improvement that we can present..."*)

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
> "“I'll prepare the increase as soon as possible. The workers will rejoice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
> "“We shall begin plans of hospital constructions immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[155]`
Mówca: **Lucian Galade**
> ""Metropolitan areas are already reaping the benefits of our policies. The rural regions, which trail behind in income, deserve some attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: ""However, implementing a nationwide, proportional salary ..."*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""We're seeing an uptick in minor outbreaks in specific regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""It's largely due to outdated facilities that lack proper..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Dismissed.”"]** — Mówca: **Player**
> "“Dismissed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Paskal gathered his documents and left along with Lucian."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“What are we doing to prepare?”"]** — Mówca: **Player**
> "“What are we doing to prepare?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Paskal Beniwoll: "“We have notified all of our healthcare staff, especially..."*)

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
> "“So we have notified all of our healthcare staff especially the ones closer to the Wehlen border. Unfortunately these are also the more rural areas where we lack equipment and staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Paskal Beniwoll: "“We need to be ready for any possibility.”"*)

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
> "“We have notified all of our healthcare staff, especially the ones closer to the Wehlen border. Unfortunately, these are also the more rural areas where we lack equipment and staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Paskal Beniwoll: "“What I was told by our researchers was that with the cur..."*)

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
> "“What I was told by our researchers was that with the current infection rate, there will soon be millions of people affected by Polio.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Paskal Beniwoll: "“We need to be ready for any possibility.”"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true && ..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true &..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_PrivatizationFulfilled ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = false"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_PrivatizationFulfilled = true; BaseGame.Faction_Oligarchs_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] = true;
Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_PSnW_HealthBudget = true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "“Why am I just learning this from a newspaper?”"]** — Mówca: **Player**
> "“Why am I just learning this from a newspaper?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Paskal Beniwoll: "“We are already evaluating the situation and did not want..."*)

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
> "“We are already evaluating the situation and did not want to bother you with it yet, Mr. President. We are working on a comprehensive report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Paskal Beniwoll: "“We have notified all of our healthcare staff, especially..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“It was not a decision that I made lightly.”"]** — Mówca: **Player**
> "“It was not a decision that I made lightly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Paskal Beniwoll: "“I am sure, Mr. President. I am not questioning that. But..."*)

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
> "“I am sure, Mr. President. I am not questioning that. But...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Paskal Beniwoll: "“I don't see many ways out of this particular situation. ..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“It was not a decision that I made lightly.”"]** — Mówca: **Player**
> "“It was not a decision that I made lightly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Paskal Beniwoll: "“I am sure, Mr. President. I am not questioning that. But..."*)

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
> "“I am sure, Mr. President. I am not questioning that. But...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Paskal Beniwoll: "“I don't think that this is a matter that can be easily s..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“Build new hospitals where they are needed. Access to health will be available for all.”"]** — Mówca: **Player**
> "“Build new hospitals where they are needed. Access to health will be available for all.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals = true; BaseGam..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HappyHealthWorkers = true"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"]** — Mówca: **Player**
> "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural = true; Base..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"]** — Mówca: **Player**
> "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false`
- **Kontekst wejściowy (poprzednik):** `[129]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary = true; BaseGame.P..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural = true;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare =..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“Improve rural treatment by hiring health staff and upgra..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == false"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Salary == false)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "“Increase salaries of doctors, nurses and other health st..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Salary == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == false"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: "“Build new hospitals where they are needed. Access to hea..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewHospitals = true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewHospitals = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_NewHospitals = true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_ImprovedRural = true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices = true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HappyHealthWorkers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyHealthWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Health_SalariesIncreased =..."*)

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
> "“I'll prepare the increase as soon as possible. The workers will rejoice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Paskal Beniwoll: ""Well, that wraps up our discussion for now.""*)

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
> "“We shall begin plans of hospital constructions immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Paskal Beniwoll: ""Well, that wraps up our discussion for now.""*)

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
> "“New contracts for improvements will be drawn up immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Paskal Beniwoll: ""Well, that wraps up our discussion for now.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Taurus_2ndProject_Expensive = true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Taurus_2ndProject_Cheaper = true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Taurus_2ndProject_Expensive = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Taurus_2ndProject_Expensive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Taurus_2ndProject_Cheaper = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Taurus_2ndProject_Cheaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.SSC_2ndProject_Cheaper = true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.SSC_2ndProject_Expensive = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SSC_2ndProject_Cheaper = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SSC_2ndProject_Cheaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SSC_2ndProject_Expensive = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SSC_2ndProject_Expensive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_Privatised = true;
BaseGame.Capitalist += 5;
BaseGame.Malenyevist -= 6;
BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_Privatised"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 6;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Paskal Beniwoll: "“Excellent. We can turn that extra money to something use..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_State = true;
BaseGame.Capitalist -= 2;
BaseGame.Malenyevist += 2;
BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_State"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Paskal Beniwoll: "“As you wish. The health services shall remain in public ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_NewHospitals = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Paskal Beniwoll: "“We shall begin plans of hospital constructions immediate..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_SalariesIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Paskal Beniwoll: "“I'll prepare the increase as soon as possible. The worke..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_ImprovedRural = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Paskal Beniwoll: "“New contracts for improvements will be drawn up immediat..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_ImprovedRural = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Paskal Beniwoll: "“New contracts for improvements will be drawn up immediat..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_NewHospitals = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Paskal Beniwoll: "“We shall begin plans of hospital constructions immediate..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Health_SalariesIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Paskal Beniwoll: "“I'll prepare the increase as soon as possible. The worke..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Paskal Beniwoll: ""Well, that wraps up our discussion for now.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Paskal Beniwoll: ""Well, that wraps up our discussion for now.""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_R_HealthcarePrivatized = true..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_R_HealthcarePrivatized = true;
BaseGameSupport.News_Turn06_E_HealthcarePrivatized = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_HealthcarePrivatized"] = true;
Variable["BaseGameSupport.News_Turn06_E_HealthcarePrivatized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_G_HeljilandGovernor = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_G_HeljilandGovernor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true )"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_EmergencyYS_Extended = tru..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_EmergencyYS_Extended = true;
BaseGameSupport.Report_Turn06_Holsord_YSJournalistReleased = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_EmergencyYS_Extended"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_YSJournalistReleased"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Healthcare >= 1"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_ST_BludsCrossBorder_Operation..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_ST_BludsCrossBorder_Operation = true;
BaseGameSupport.Report_Turn06_Uziren_BludsCrossBorder = true;
BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_BludsCrossBorder_Operation"] = true;
Variable["BaseGameSupport.Report_Turn06_Uziren_BludsCrossBorder"] = true;
Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn06_Wehlen_NoWehlenDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_NoWehlenDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn06_Wehlen_BorderGuard =..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn06_Wehlen_NoWehlenDeal ..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn06_Wehlen_BorderGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_BorderGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_G_HeljilandGovernor = true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_PSnW_HealthBudget = true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Healthcare >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Healthcare >= 0"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Healthcare >= 0)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Healthcare >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Healthcare"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_PandemicFallout = false;"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Healthcare >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Healthcare"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia -= 1; BaseGame.Situation_Economy_..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia -= 1;
BaseGame.Situation_Economy_PandemicFallout = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] - 1;
Variable["BaseGame.Situation_Economy_PandemicFallout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Healthcare >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Healthcare >= 1"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Healthcare >= 1)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Healthcare >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Healthcare"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_PandemicFallout = false;"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Healthcare >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Healthcare"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Healthcare >= 0"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_PandemicFallout = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_PandemicFallout"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Privatization == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true && ..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_PSnW_HealthBudget = true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationReform = false; BaseGame..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `HealthBudgetChoices`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option1 == false"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option2 == false"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option3 == false"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseG..."*)

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
> ""In my book 'The Unfortunate Man', I depicted the hardships of a poor mining family, a vivid illustration of the stark health inequalities in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Paskal Beniwoll: ""As Minister of Health, I strive to rectify these dispari..."*)

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
> ""As Minister of Health, I strive to rectify these disparities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Paskal Beniwoll: "“Therefore, I believe improving treatment in rural areas ..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [HealthBudgetChoices]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "HealthBudgetChoices"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "Jump to: [HealthBudgetChoices]"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "Jump to: [HealthBudgetChoices]"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "Jump to: [HealthBudgetChoices]"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option1 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option1 == false"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.HealthBudget_Hub_Option1 == false)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option1 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“Building new hospitals sounds interesting. It would also..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.HealthBudget_Hub_Option1 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option2 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option2 == false"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.HealthBudget_Hub_Option2 == false)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option2 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "“Increasing salaries should have a good effect for doctor..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.HealthBudget_Hub_Option2 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option3 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option3 == false"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.HealthBudget_Hub_Option3 == false)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option3 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Improving treatment in rural areas is a must. It would p..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.HealthBudget_Hub_Option3 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WYBÓR GRACZA: "“We can proceed with the decision, Minister Beniwoll.”"]** — Mówca: **Player**
> "“We can proceed with the decision, Minister Beniwoll.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == true`
- **Kontekst wejściowy (poprzednik):** `[132]` (Paskal Beniwoll), `[127]` (Lucian Galade), `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Paskal Beniwoll: ""In my book 'The Unfortunate Man', I depicted the hardshi..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseGameIsolated.HealthBudget_Hub_Option2 == true ||BaseGameIsolated.HealthBudget_Hub_Option3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseG..."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.HealthBudget_Hub_Option1 == true ||Bas..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseGameIsolated.HealthBudget_Hub_Option2 == true ||BaseGameIsolated.HealthBudget_Hub_Option3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: "“We can proceed with the decision, Minister Beniwoll.”"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseGameIsolated.HealthBudget_Hub_Option2 == true ||BaseGameIsolated.HealthBudget_Hub_Option3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
> ""But certainly, adding new healthcare facilities would be a positive step, particularly in underserved regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""Constructing new hospitals would score us significant po..."*)

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
> ""On a larger scale, it would boost satisfaction within the health industry and could contribute significantly to reducing maternal mortality rates, a goal that is close to my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lucian Galade: ""Metropolitan areas are already reaping the benefits of o..."*)

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
> ""Addressing this issue is one of my key objectives in this term, and I believe an overhaul of the rural healthcare infrastructure is a critical step in that direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: ""We're seeing an uptick in minor outbreaks in specific re..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[282]`
**[WYBÓR GRACZA: "“We will promote privatization and allow the private sector to invest and buy government's health properties.” [+2 Government Budget]"]** — Mówca: **Player**
> "“We will promote privatization and allow the private sector to invest and buy government's health properties.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] >= 5`
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 2;"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization = true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: "“We will promote privatization and allow the private sect..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player: "“We will promote privatization and allow the private sect..."*)

### Węzeł `[287]`
**[WYBÓR GRACZA: "“We will promote privatization and allow the private sector to invest and buy government's health properties.” [+1 Government Budget]"]** — Mówca: **Player**
> "“We will promote privatization and allow the private sector to invest and buy government's health properties.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 1;"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization = true"*)
