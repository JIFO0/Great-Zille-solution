# Sordland/Turn06/PSnW_EducationSpending

- **ID konwersacji:** `86`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/086_PSnW_EducationSpending.md`
- **Liczba węzłów dialogowych:** 376
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn06_2ndCompanyChoice_SSC`
- `BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus`
- `BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.Decision_Turn06_Megaproject_Conriat`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.Decision_Turn06_Megaproject_Sarna`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Situation_Welfare_FailedEducationReform`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Education_Budget_Maintain`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn05_Inflation`
- `BaseGame.Turn06_EnT_Started2ndMegaproject`
- `BaseGame.Turn06_EnergyInflationCrisis`
- `BaseGame.Turn06_InT_SordishState`
- `BaseGame.Turn06_InT_Taurus`
- `BaseGame.Turn06_PSnW_Education_ImproveRural`
- `BaseGame.Turn06_PSnW_Education_Salary`
- `BaseGame.Turn06_PSnW_Education_Schools`
- `BaseGame.Turn06_PSnW_Healthcare_Privatization`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn06_PSnW_EducationInfo_Build`
- `BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve`
- `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Welfare_EducationGap`
- `BaseGame.Situation_Welfare_HappyEducationWorkers`
- `BaseGame.Situation_Welfare_HealthGap`
- `BaseGame.Situation_Welfare_ImprovedRuralSchools`
- `BaseGame.Situation_Welfare_LackOfAccessRuralEducation`
- `BaseGame.Situation_Welfare_NewRuralSchools`
- `BaseGame.Situation_Welfare_RelievedWelfareSystem`
- `BaseGame.Turn06_PSnW_Education_ImproveRural`
- `BaseGame.Turn06_PSnW_Education_Salary`
- `BaseGame.Turn06_PSnW_Education_Schools`
- `BaseGameIsolated.Turn06_PSnW_EducationInfo_Build`
- `BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve`
- `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary`
- `BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation2`
- `BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConference`
- `BaseGameSupport.Journal_Turn06_Education_ImprovedRural`
- `BaseGameSupport.Journal_Turn06_Education_RuralSchools`
- `BaseGameSupport.Journal_Turn06_Education_SalariesIncreased`
- `BaseGameSupport.News_Turn06_G_PressFreedomsUC`
- `BaseGameSupport.News_Turn06_HP_BenfiProject_SSC`
- `BaseGameSupport.News_Turn06_HP_BenfiProject_Taurus`
- `BaseGameSupport.News_Turn06_HP_BenfiProject_Underhall`
- `BaseGameSupport.News_Turn06_HP_ConriatProject_SSC`
- `BaseGameSupport.News_Turn06_HP_ConriatProject_Taurus`
- `BaseGameSupport.News_Turn06_HP_ConriatProject_Underhall`
- `BaseGameSupport.News_Turn06_HP_ErsenCaseGoesToCourt`
- `BaseGameSupport.News_Turn06_HP_MornaProject_SSC`
- `BaseGameSupport.News_Turn06_HP_MornaProject_Taurus`
- `BaseGameSupport.News_Turn06_HP_MornaProject_Underhall`
- `BaseGameSupport.News_Turn06_HP_NFPAgainstProposal`
- `BaseGameSupport.News_Turn06_HP_SarnaProject_SSC`
- `BaseGameSupport.News_Turn06_HP_SarnaProject_Taurus`
- `BaseGameSupport.News_Turn06_HP_SarnaProject_Underhall`
- `BaseGameSupport.News_Turn06_R_ErsenCaseGoesToCourt`
- `BaseGameSupport.News_Turn06_R_InflationCrisis`
- `BaseGameSupport.News_Turn06_R_PFJPAgainstProposal`
- `BaseGameSupport.News_Turn06_R_RefugeeCrisis_NoWehlenDeal`
- `BaseGameSupport.News_Turn06_ST_RefugeesFlee_NoOperation`
- `BaseGameSupport.Report_Turn06_Holsord_ErsenCaseGoesToCourt`
- `BaseGameSupport.Report_Turn06_Holsord_InflationCrisis`
- `GameCondition.Turn06_PSnW_EducationSpending`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[15]` | **"“It's nothing.”"** | `[14]` **Ciara Walda**: "“Reminiscing about the past?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Ciara Walda**: "“Let's begin then.”" |
| `[16]` | **"“Yes. It had its ups and downs but it was still fun.”"** | `[14]` **Ciara Walda**: "“Reminiscing about the past?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Ciara Walda**: "“And now we're growing old and b..." |
| `[19]` | **"“How were your university years?”"** | `[14]` **Ciara Walda**: "“Reminiscing about the past?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Ciara Walda**: "“The usual story. A few friends ..." |
| `[20]` | **"“What for?”"** | `[18]` **Ciara Walda**: "“The usual story. A few friends ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Ciara Walda**: "“Protesting against police bruta..." |
| `[22]` | **"“No good memories? You should try to be a bit more optimistic.”"** | `[18]` **Ciara Walda**: "“The usual story. A few friends ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Ciara Walda**: "“It's difficult when there's not..." |
| `[23]` | **"“We all went through tough times back then.”"** | `[18]` **Ciara Walda**: "“The usual story. A few friends ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Ciara Walda**: "“Some of us more so than others.”" |
| `[74]` | **"“You played a huge part in this too, Ciara.”"** | `[217]` **Ciara Walda**: "“The students of now will thank ..."<br>`[218]` **Ciara Walda**: "“It's a failure from my end to h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ciara Walda**: "“I am optimistic about the path ..."<br>`[223]` **Ciara Walda**: "“I'm not going to lie. I'm doubt..." |
| `[75]` | **"“That is why we are here.”"** | `[217]` **Ciara Walda**: "“The students of now will thank ..."<br>`[218]` **Ciara Walda**: "“It's a failure from my end to h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ciara Walda**: "“I am optimistic about the path ..."<br>`[223]` **Ciara Walda**: "“I'm not going to lie. I'm doubt..." |
| `[76]` | **"“I did only what was necessary.”"** | `[217]` **Ciara Walda**: "“The students of now will thank ..."<br>`[218]` **Ciara Walda**: "“It's a failure from my end to h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ciara Walda**: "“I am optimistic about the path ..."<br>`[223]` **Ciara Walda**: "“I'm not going to lie. I'm doubt..." |
| `[79]` | **"“You played a huge part in this too, Ciara.”"** | `[49]` **Ciara Walda**: "“I want to thank you for leading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "She nodded and brought out a sta..." |
| `[80]` | **"“That is why we are here.”"** | `[49]` **Ciara Walda**: "“I want to thank you for leading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "She nodded and brought out a sta..." |
| `[81]` | **"“I did only what was necessary.”"** | `[49]` **Ciara Walda**: "“I want to thank you for leading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "She nodded and brought out a sta..." |
| `[82]` | **"“There are other priorities.”"** | `[73]` **Ciara Walda**: "“And as you have already stated,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Ciara Walda**: "“What priorities can there be ot..." |
| `[83]` | **"“Do not question my decision, Ciara.”"** | `[73]` **Ciara Walda**: "“And as you have already stated,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "Her eyes widened, but she compos..." |
| `[84]` | **"“There is nothing wrong with the current education system as it is.”"** | `[73]` **Ciara Walda**: "“And as you have already stated,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Ciara Walda**: "“We've been through this. I show..." |
| `[90]` | **"“I am sure you will make do.”"** | `[54]` **Ciara Walda**: "“I doubt it will be enough to ma..."<br>`[232]` **Ciara Walda**: "“Our education system is in sham..." | `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false` | *Brak zmian stanu* | `[97]` **Ciara Walda**: "“That is precisely the problem. ..." |
| `[91]` | **"“The money was needed elsewhere.”"** | `[54]` **Ciara Walda**: "“I doubt it will be enough to ma..."<br>`[232]` **Ciara Walda**: "“Our education system is in sham..." | `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false` | *Brak zmian stanu* | `[94]` **Ciara Walda**: "“What other priorities there can..." |
| `[92]` | **"“Do not question my decision, Ciara.”"** | `[54]` **Ciara Walda**: "“I doubt it will be enough to ma..."<br>`[232]` **Ciara Walda**: "“Our education system is in sham..." | `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false` | *Brak zmian stanu* | `[96]` **Narrator**: "Her eyes widened." |
| `[131]` | **"“Tell me about the plan to build new rural schools.”"** | `[116]` **Ciara Walda**: "“Because of the additional funds..."<br>`[117]` **Ciara Walda**: "“We have the capacity to impleme..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == false` | *Brak zmian stanu* | `[132]` **Ciara Walda**: "“The issue is very critical, as ..." |
| `[134]` | **"“Why should we increase the salaries of education workers?”"** | `[116]` **Ciara Walda**: "“Because of the additional funds..."<br>`[117]` **Ciara Walda**: "“We have the capacity to impleme..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == false` | *Brak zmian stanu* | `[135]` **Ciara Walda**: "“The job itself should be held i..." |
| `[137]` | **"“What does improving rural schools entail?”"** | `[116]` **Ciara Walda**: "“Because of the additional funds..."<br>`[117]` **Ciara Walda**: "“We have the capacity to impleme..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == false` | *Brak zmian stanu* | `[138]` **Ciara Walda**: "“Where to start? At the very lea..." |
| `[140]` | **"“I am ready to decide.”"** | `[116]` **Ciara Walda**: "“Because of the additional funds..."<br>`[117]` **Ciara Walda**: "“We have the capacity to impleme..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true` | *Brak zmian stanu* | `[146]` **Narrator**: "She put the pen down and looked ..." |
| `[141]` | **"“Let's move on to the decision and get on with it.”"** | `[116]` **Ciara Walda**: "“Because of the additional funds..."<br>`[117]` **Ciara Walda**: "“We have the capacity to impleme..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true) == false` | *Brak zmian stanu* | `[146]` **Narrator**: "She put the pen down and looked ..." |
| `[147]` | **"“Build new rural schools. Our primary goal must be to increase access to education.”"** | `[146]` **Narrator**: "She put the pen down and looked ..." | `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false` | `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true...`<br>`Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEdu...`<br>*(+2 skryptów)* | `[168]` **Ciara Walda**: "“It feels gratifying that we are..." |
| `[151]` | **"“Increase salaries of teachers, principals and other education staff all around th..."** | `[146]` **Narrator**: "She put the pen down and looked ..." | `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false` | `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true;...`<br>`Variable["BaseGame.Situation_Welfare_HappyEducationWorker...`<br>*(+1 skryptów)* | `[171]` **Ciara Walda**: "“Our teachers will be grateful. ..." |
| `[160]` | **"“Improve rural education by purchasing new materials and upgrading old school equi..."** | `[146]` **Narrator**: "She put the pen down and looked ..." | `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false` | `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] =...`<br>`Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools...`<br>*(+1 skryptów)* | `[159]` **Ciara Walda**: "“That will definitely improve th..." |
| `[161]` | **"“See you at our next meeting.”"** | `[182]` **Ciara Walda**: "“We will meet again very soon.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Welfare_RelievedWelfareSyste...` | `[363]` **Narrator**: "Ciara put the papers back in her..."<br>`[177]` **Narrator**: "Ciara put the papers back in her..." |
| `[162]` | **"“Keep up the good work.”"** | `[182]` **Ciara Walda**: "“We will meet again very soon.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Welfare_RelievedWelfareSyste...` | `[363]` **Narrator**: "Ciara put the papers back in her..."<br>`[177]` **Narrator**: "Ciara put the papers back in her..." |
| `[164]` | **"“Thank you for your efforts.”"** | `[182]` **Ciara Walda**: "“We will meet again very soon.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Welfare_RelievedWelfareSyste...` | `[363]` **Narrator**: "Ciara put the papers back in her..."<br>`[177]` **Narrator**: "Ciara put the papers back in her..." |
| `[179]` | **"“Damn. I'm sorry...”"** | `[18]` **Ciara Walda**: "“The usual story. A few friends ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Ciara Walda**: "“It's okay. Many of us have expe..." |
| `[183]` | **"“Build new rural schools. Our primary goal must be to increase access to education.”"** | `[163]` **Ciara Walda**: "“As I mentioned before, there ar..." | `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false` | `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true...`<br>`Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEdu...`<br>*(+2 skryptów)* | `[202]` **Ciara Walda**: "“It feels gratifying that we are..." |
| `[187]` | **"“Increase salaries of teachers, principals and other education staff all around th..."** | `[163]` **Ciara Walda**: "“As I mentioned before, there ar..." | `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false` | `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true;...`<br>`Variable["BaseGame.Situation_Welfare_HappyEducationWorker...`<br>*(+1 skryptów)* | `[203]` **Ciara Walda**: "“Our teachers will be grateful. ..." |
| `[195]` | **"“Improve rural education by purchasing new materials and upgrading old school equi..."** | `[163]` **Ciara Walda**: "“As I mentioned before, there ar..." | `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false` | `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] =...`<br>`Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools...`<br>*(+1 skryptów)* | `[201]` **Ciara Walda**: "“That will definitely improve th..." |
| `[220]` | **"“It was not the right time and not the right choice Ciara.”"** | `[218]` **Ciara Walda**: "“It's a failure from my end to h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Ciara Walda**: "“It never is in Sordland.”" |
| `[221]` | **"“Sordland needs visionaries like you to reform to become something better.”"** | `[217]` **Ciara Walda**: "“The students of now will thank ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Ciara Walda**: "“We are onto something promising..." |

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
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_G_PressFreedomsUC = true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After a meeting with the rector and a brief tour of the University of Valgen, we gathered in a room with Ciara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "It reminded me of my own times at Deyr University of Cult..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "It reminded me of my own times at Deyr University of Culture -- at least, the more carefree moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ciara Walda: "“Reminiscing about the past?”"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "It reminded me of my own times at Holsord State Universit..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "It reminded me of my own times at Lachaven Business Schoo..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "It reminded me of my own times at Holsord State University -- at least, the more carefree moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ciara Walda: "“Reminiscing about the past?”"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "It reminded me of my own times at Lachaven Business School -- at least, the more carefree moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ciara Walda: "“Reminiscing about the past?”"*)

### Węzeł `[14]`
Mówca: **Ciara Walda**
> "“Reminiscing about the past?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“How were your university years?”"*)
  - -> `[16]` (*Player: "“Yes. It had its ups and downs but it was still fun.”"*)
  - -> `[15]` (*Player: "“It's nothing.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“It's nothing.”"]** — Mówca: **Player**
> "“It's nothing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Ciara Walda: "“Let's begin then.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Yes. It had its ups and downs but it was still fun.”"]** — Mówca: **Player**
> "“Yes. It had its ups and downs but it was still fun.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ciara Walda: "“And now we're growing old and bitter.”"*)

### Węzeł `[17]`
Mówca: **Ciara Walda**
> "“And now we're growing old and bitter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "She smiled."*)

### Węzeł `[18]`
Mówca: **Ciara Walda**
> "“The usual story. A few friends dead, a couple of them missing after the coups. Oh, and I was almost arrested once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“No good memories? You should try to be a bit more optimi..."*)
  - -> `[20]` (*Player: "“What for?”"*)
  - -> `[23]` (*Player: "“We all went through tough times back then.”"*)
  - -> `[179]` (*Player: "“Damn. I'm sorry...”"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“How were your university years?”"]** — Mówca: **Player**
> "“How were your university years?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ciara Walda: "“The usual story. A few friends dead, a couple of them mi..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“What for?”"]** — Mówca: **Player**
> "“What for?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Ciara Walda: "“Protesting against police brutality. Ironic, isn't it?”"*)

### Węzeł `[21]`
Mówca: **Ciara Walda**
> "“Protesting against police brutality. Ironic, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: "“Let's not get sidetracked.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“No good memories? You should try to be a bit more optimistic.”"]** — Mówca: **Player**
> "“No good memories? You should try to be a bit more optimistic.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Ciara Walda: "“It's difficult when there's nothing positive about those..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“We all went through tough times back then.”"]** — Mówca: **Player**
> "“We all went through tough times back then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Ciara Walda: "“Some of us more so than others.”"*)

### Węzeł `[24]`
Mówca: **Ciara Walda**
> "“It's difficult when there's nothing positive about those times. Also, being a pessimist makes me realise the problems quicker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: "“Let's not get sidetracked.""*)

### Węzeł `[25]`
Mówca: **Ciara Walda**
> "“Some of us more so than others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: "“Let's not get sidetracked.""*)

### Węzeł `[26]`
Mówca: **Ciara Walda**
> "“Let's not get sidetracked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ciara Walda: "“I want to start off by saying this.”"*)

### Węzeł `[27]`
Mówca: **Ciara Walda**
> "“Let's begin then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ciara Walda: "“I want to start off by saying this.”"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)

### Węzeł `[34]`
Mówca: **Ciara Walda**
> "“I want to start off by saying this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[35]`
Mówca: **Ciara Walda**
> "“Unfortunately our fuel is running out at the Ministry of Education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Ciara Walda: "“The state having had to rely on privatization funds is a..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[39]`
Mówca: **Ciara Walda**
> "“The state having had to rely on privatization funds is a disgrace. We are letting private interests meddle in the most essential service; learning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Ciara Walda: "“New private schools are increasing the disparity of serv..."*)

### Węzeł `[40]`
Mówca: **Ciara Walda**
> "“It was very positive to see the administration dedicate the funding that was requested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Ciara Walda: "“I am making sure that the additional funds are being use..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Ciara Walda: "“I want to thank you for allowing me to lead our educatio..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Ciara sighed."*)

### Węzeł `[44]`
Mówca: **Ciara Walda**
> "“I want to thank you for allowing me to lead our education system in the right direction. By removing nationalist indoctrination and traditional teachings we have unlocked the potential of the next generation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Ciara Walda: "“The students of now will thank us in the future Presiden..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Ciara Walda: "“Although I insist that the funds are still necessary to ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Ciara Walda: "“And as you have already stated, improving Sordland's sex..."*)

### Węzeł `[48]`
Mówca: **Ciara Walda**
> "“Although I insist that the funds are still necessary to close the gaps in services, I can't say we have been entirely off track.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Ciara Walda: "“I want to thank you for leading our education system in ..."*)

### Węzeł `[49]`
Mówca: **Ciara Walda**
> "“I want to thank you for leading our education system in the right direction. Traditional teachings have long prevented proper progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "“I did only what was necessary.”"*)
  - -> `[80]` (*Player: "“That is why we are here.”"*)
  - -> `[79]` (*Player: "“You played a huge part in this too, Ciara.”"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Ciara Walda: "“What little money we allocated from privatization will b..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“The money was needed elsewhere.”"*)
  - -> `[90]` (*Player: "“I am sure you will make do.”"*)
  - -> `[92]` (*Player: "“Do not question my decision, Ciara.”"*)

### Węzeł `[53]`
Mówca: **Ciara Walda**
> "“What little money we allocated from privatization will be diverted to improvements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ciara Walda: "“I doubt it will be enough to make substantial change.”"*)

### Węzeł `[54]`
Mówca: **Ciara Walda**
> "“I doubt it will be enough to make substantial change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“The money was needed elsewhere.”"*)
  - -> `[90]` (*Player: "“I am sure you will make do.”"*)
  - -> `[92]` (*Player: "“Do not question my decision, Ciara.”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Ciara Walda: "“It comes at a welcome surprise in Sordish politics to se..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ciara Walda: "“It was very positive to see the administration dedicate ..."*)

### Węzeł `[58]`
Mówca: **Ciara Walda**
> "“It comes at a welcome surprise in Sordish politics to see a President uphold their promises regarding education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Ciara Walda: "“I am making sure that the additional funds are being use..."*)

### Węzeł `[59]`
Mówca: **Ciara Walda**
> "“I am making sure that the additional funds are being used in the best way possible in order to resolve structural issues, speaking of.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Ciara Walda: "“Although you swore you would focus on education during y..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ciara Walda: "“Stagnation doesn't get anyone anywhere. Simply maintaini..."*)

### Węzeł `[63]`
Mówca: **Ciara Walda**
> "“Although you swore you would focus on education during your term, you have not lived up to that promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Ciara Walda: "“A fact that the people will not forget.”"*)

### Węzeł `[64]`
Mówca: **Ciara Walda**
> "“Stagnation doesn't get anyone anywhere. Simply maintaining my ministry's funds got us sitting duck with the dozens of issues left unsolvable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Ciara Walda: "“I feel personally betrayed. You promised to focus on edu..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Ciara Walda: "“Unfortunately our fuel is running out at the Ministry of..."*)

### Węzeł `[68]`
Mówca: **Ciara Walda**
> "“The effects of your decision are much greater than I think you realise. The real damage is being done to the younger generation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Ciara Walda: "“I'm trying very hard to look past that but can't really.”"*)

### Węzeł `[69]`
Mówca: **Ciara Walda**
> "“I feel personally betrayed. You promised to focus on education during our term. And here we are suffering the consequences of a budget cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ciara Walda: "“The effects of your decision are much greater than I thi..."*)

### Węzeł `[70]`
Mówca: **Ciara Walda**
> "“I'm trying very hard to look past that but can't really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "She regarded me coolly for a second."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "She regarded me coolly for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2"*)

### Węzeł `[72]`
Mówca: **Ciara Walda**
> "“We had a once in a lifetime opportunity to eradicate the political indoctrination and the traditional methods of education. We have sadly missed this chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Ciara Walda: "“It's a failure from my end to have come this far and not..."*)

### Węzeł `[73]`
Mówca: **Ciara Walda**
> "“And as you have already stated, improving Sordland's sexist and horrendously outdated education system is low on your priorities list.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“Do not question my decision, Ciara.”"*)
  - -> `[84]` (*Player: "“There is nothing wrong with the current education system..."*)
  - -> `[82]` (*Player: "“There are other priorities.”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“You played a huge part in this too, Ciara.”"]** — Mówca: **Player**
> "“You played a huge part in this too, Ciara.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Ciara Walda), `[218]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“That is why we are here.”"]** — Mówca: **Player**
> "“That is why we are here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Ciara Walda), `[218]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I did only what was necessary.”"]** — Mówca: **Player**
> "“I did only what was necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Ciara Walda), `[218]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "She nodded and brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spinning her ballpoint pen, she went through the papers, ..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "She nodded and brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spinning her ballpoint pen, she went through the papers, ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“You played a huge part in this too, Ciara.”"]** — Mówca: **Player**
> "“You played a huge part in this too, Ciara.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "She nodded and brought out a stack of papers from her bag."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“That is why we are here.”"]** — Mówca: **Player**
> "“That is why we are here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "She nodded and brought out a stack of papers from her bag."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“I did only what was necessary.”"]** — Mówca: **Player**
> "“I did only what was necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "She nodded and brought out a stack of papers from her bag."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“There are other priorities.”"]** — Mówca: **Player**
> "“There are other priorities.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Ciara Walda: "“What priorities can there be other than the future of So..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Do not question my decision, Ciara.”"]** — Mówca: **Player**
> "“Do not question my decision, Ciara.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Her eyes widened, but she composed herself quickly."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“There is nothing wrong with the current education system as it is.”"]** — Mówca: **Player**
> "“There is nothing wrong with the current education system as it is.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Ciara Walda: "“We've been through this. I showed you the statistics. Ye..."*)

### Węzeł `[85]`
Mówca: **Ciara Walda**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She brought out a stack of papers from her bag."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Her eyes widened, but she composed herself quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Ciara Walda: "“Very well, Mr. President.”"*)

### Węzeł `[87]`
Mówca: **Ciara Walda**
> "“We've been through this. I showed you the statistics. Yet you didn't listen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Ciara Walda: "“Never mind. There is no point talking about what's alrea..."*)

### Węzeł `[88]`
Mówca: **Ciara Walda**
> "“Never mind. There is no point talking about what's already done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She brought out a stack of papers from her bag."*)

### Węzeł `[89]`
Mówca: **Ciara Walda**
> "“What priorities can there be other than the future of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Ciara Walda: "“Never mind. There is no point talking about what's alrea..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“I am sure you will make do.”"]** — Mówca: **Player**
> "“I am sure you will make do.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Ciara Walda), `[232]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Ciara Walda: "“That is precisely the problem. We can't.”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“The money was needed elsewhere.”"]** — Mówca: **Player**
> "“The money was needed elsewhere.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Ciara Walda), `[232]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Ciara Walda: "“What other priorities there can be other than the future..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Do not question my decision, Ciara.”"]** — Mówca: **Player**
> "“Do not question my decision, Ciara.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Ciara Walda), `[232]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Her eyes widened."*)

### Węzeł `[93]`
Mówca: **Ciara Walda**
> "“Never mind. There is no point talking about what is already done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She brought out a stack of papers from her bag."*)

### Węzeł `[94]`
Mówca: **Ciara Walda**
> "“What other priorities there can be other than the future of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Ciara Walda: "“Never mind. There is no point talking about what is alre..."*)

### Węzeł `[95]`
Mówca: **Ciara Walda**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She brought out a stack of papers from her bag."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Her eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Ciara Walda: "“Very well, Mr. President.”"*)

### Węzeł `[97]`
Mówca: **Ciara Walda**
> "“That is precisely the problem. We can't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ciara Walda: "“We will have to make cuts from wherever we can.”"*)

### Węzeł `[98]`
Mówca: **Ciara Walda**
> "“We will have to make cuts from wherever we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She brought out a stack of papers from her bag."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "She brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spinning her ballpoint pen, she went through the papers, ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "She brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spinning her ballpoint pen, she went through the papers, ..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Spinning her ballpoint pen, she went through the papers, organising some of them together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true && ..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true &..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Maintain == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Ciara Walda: "“Our ministry has prepared the necessary framework regard..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Maintain == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“That's all there is for now.”"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Ciara Walda: "“Our ministry has prepared the necessary framework regard..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Maintain == true && ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_PSnW_EducationSpending = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_PSnW_EducationSpending"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[109]`
Mówca: **Ciara Walda**
> "“Our ministry has prepared the necessary framework regarding how to spend our increased education budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Ciara Walda: "“I have outlined three potential options.”"*)

### Węzeł `[110]`
Mówca: **Ciara Walda**
> "“Our ministry has prepared the necessary framework regarding how to spend the funds we've gained through school privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Ciara Walda: "“I have outlined three potential options.”"*)

### Węzeł `[111]`
Mówca: **Ciara Walda**
> "“We can build new rural schools, improve the standards of existing ones, or increase salaries for all education workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true && ..."*)

### Węzeł `[112]`
Mówca: **Ciara Walda**
> "“I have outlined three potential options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Ciara Walda: "“We can build new rural schools, improve the standards of..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true && ..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true &..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Ciara Walda: "“Because of the additional funds from privatization on to..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Ciara Walda: "“We have the capacity to implement only one of these opti..."*)

### Węzeł `[116]`
Mówca: **Ciara Walda**
> "“Because of the additional funds from privatization on top of the budget increase, we should be able to implement two of these options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "Education Spending Information Hub"*)

### Węzeł `[117]`
Mówca: **Ciara Walda**
> "“We have the capacity to implement only one of these options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "Education Spending Information Hub"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Education Spending Information Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“Tell me about the plan to build new rural schools.”"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == f..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“What does improving rural schools entail?”"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == fa..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "“Why should we increase the salaries of education workers?”"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == tr..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“I am ready to decide.”"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“Let's move on to the decision and get on with it.”"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Tell me about the plan to build new rural schools.”"]** — Mówca: **Player**
> "“Tell me about the plan to build new rural schools.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Ciara Walda), `[117]` (Ciara Walda), `[142]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Ciara Walda: "“The issue is very critical, as we are losing many young ..."*)

### Węzeł `[132]`
Mówca: **Ciara Walda**
> "“The issue is very critical, as we are losing many young people to ignorance and illiteracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Ciara Walda: "“Sordland's rural population is full of untapped potentia..."*)

### Węzeł `[133]`
Mówca: **Ciara Walda**
> "“Sordland's rural population is full of untapped potential. With enough education, these people could be an asset to our workforce and society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Ciara Walda: "“Look at how United Contana is pushing past Arcasia in ed..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Why should we increase the salaries of education workers?”"]** — Mówca: **Player**
> "“Why should we increase the salaries of education workers?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Ciara Walda), `[117]` (Ciara Walda), `[142]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Ciara Walda: "“The job itself should be held in higher regard and be co..."*)

### Węzeł `[135]`
Mówca: **Ciara Walda**
> "“The job itself should be held in higher regard and be compensated accordingly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ciara Walda: "“These are people who have chosen to dedicate themselves ..."*)

### Węzeł `[136]`
Mówca: **Ciara Walda**
> "“These are people who have chosen to dedicate themselves to the betterment of others. To helping raise the next generation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Ciara Walda: "“We ought to give them what they deserve.”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“What does improving rural schools entail?”"]** — Mówca: **Player**
> "“What does improving rural schools entail?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Ciara Walda), `[117]` (Ciara Walda), `[142]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ciara Walda: "“Where to start? At the very least, they need new equipme..."*)

### Węzeł `[138]`
Mówca: **Ciara Walda**
> "“Where to start? At the very least, they need new equipment and materials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ciara Walda: "“Many of these schools are facing a shortage of desks and..."*)

### Węzeł `[139]`
Mówca: **Ciara Walda**
> "“Many of these schools are facing a shortage of desks and textbooks. The ones that aren't haven't been updated since before the Soll administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ciara Walda: "“If teachers lack the resources to give Sordish youth a p..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I am ready to decide.”"]** — Mówca: **Player**
> "“I am ready to decide.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true`
- **Kontekst wejściowy (poprzednik):** `[116]` (Ciara Walda), `[117]` (Ciara Walda), `[142]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "She put the pen down and looked at me."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Let's move on to the decision and get on with it.”"]** — Mówca: **Player**
> "“Let's move on to the decision and get on with it.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Ciara Walda), `[117]` (Ciara Walda), `[142]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "She put the pen down and looked at me."*)

### Węzeł `[142]`
Mówca: **Ciara Walda**
> "“Look at how United Contana is pushing past Arcasia in education and research. It's because most of their rural populace has access to schools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Build = true"*)

### Węzeł `[143]`
Mówca: **Ciara Walda**
> "“We ought to give them what they deserve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary = true"*)

### Węzeł `[144]`
Mówca: **Ciara Walda**
> "“If teachers lack the resources to give Sordish youth a proper education, it can be as bad as if they don't go to school at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve = true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Education Spending Information Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "Education Spending Information Hub"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "She put the pen down and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == false"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == false"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == false"*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "“Build new rural schools. Our primary goal must be to increase access to education.”"]** — Mówca: **Player**
> "“Build new rural schools. Our primary goal must be to increase access to education.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false`
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools = true; BaseGame.P..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HappyEducationWorkers = true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools = true;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_LackOfAccessRuralEducation = f..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HappyEducationWorkers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyEducationWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Education_SalariesIncrease..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Increase salaries of teachers, principals and other education staff all around the country.”"]** — Mówca: **Player**
> "“Increase salaries of teachers, principals and other education staff all around the country.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false`
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary = true; BaseGame.Pu..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == false"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Salary == false)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“Increase salaries of teachers, principals and other educ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Salary == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == false"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Schools == false)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: "“Build new rural schools. Our primary goal must be to inc..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Schools == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewRuralSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Education_RuralSchools = true"*)

### Węzeł `[159]`
Mówca: **Ciara Walda**
> "“That will definitely improve the education experience for our children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true && ..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Improve rural education by purchasing new materials and upgrading old school equipment.”"]** — Mówca: **Player**
> "“Improve rural education by purchasing new materials and upgrading old school equipment.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false`
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural = true; BaseG..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“See you at our next meeting.”"]** — Mówca: **Player**
> "“See you at our next meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“Keep up the good work.”"]** — Mówca: **Player**
> "“Keep up the good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[163]`
Mówca: **Ciara Walda**
> "“As I mentioned before, there are enough resources to initiate one more policy plan. What would your preference be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == false"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == false"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == false"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Thank you for your efforts.”"]** — Mówca: **Player**
> "“Thank you for your efforts.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == false"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_ImproveRural == false)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: "“Improve rural education by purchasing new materials and ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_ImproveRural == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
Mówca: **Ciara Walda**
> "“It feels gratifying that we are finally serving the people directly. I will pass it down to the ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true && ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_LackOfAccessRuralEducation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEducation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewRuralSchools = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_ImprovedRuralSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Education_ImprovedRural = ..."*)

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“Our teachers will be grateful. The payouts shall be prepared immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true && ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_ImprovedRuralSchools = true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Policy_Welfare_EducationPrivatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true && ..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true &..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Policy_Welfare_EducationPrivatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Ciara Walda: "“As I mentioned before, there are enough resources to ini..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Policy_Welfare_EducationPrivatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“That's all there is for now.”"*)

### Węzeł `[176]`
Mówca: **Ciara Walda**
> "“That's all there is for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ciara Walda: "“I have talked with Ms. Suno to schedule some time to dis..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Ciara put the papers back in her bag and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: "“Let's not get sidetracked.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“Damn. I'm sorry...”"]** — Mówca: **Player**
> "“Damn. I'm sorry...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Ciara Walda: "“It's okay. Many of us have experienced similar stories.”"*)

### Węzeł `[180]`
Mówca: **Ciara Walda**
> "“It's okay. Many of us have experienced similar stories.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ciara Walda: "“Let's not get sidetracked.""*)

### Węzeł `[181]`
Mówca: **Ciara Walda**
> "“I have talked with Ms. Suno to schedule some time to discuss the curriculum. She's a very astute woman, your secretary. You may want to consider promoting her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Ciara Walda: "“We will meet again very soon.”"*)

### Węzeł `[182]`
Mówca: **Ciara Walda**
> "“We will meet again very soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: "“Thank you for your efforts.”"*)
  - -> `[162]` (*Player: "“Keep up the good work.”"*)
  - -> `[161]` (*Player: "“See you at our next meeting.”"*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Build new rural schools. Our primary goal must be to increase access to education.”"]** — Mówca: **Player**
> "“Build new rural schools. Our primary goal must be to increase access to education.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools = true; BaseGame.P..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HappyEducationWorkers = true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools = true;
BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_LackOfAccessRuralEducation = f..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HappyEducationWorkers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyEducationWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Education_SalariesIncrease..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“Increase salaries of teachers, principals and other education staff all around the country.”"]** — Mówca: **Player**
> "“Increase salaries of teachers, principals and other education staff all around the country.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary = true; BaseGame.Pu..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == false"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Salary == false)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player: "“Increase salaries of teachers, principals and other educ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Salary == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == false"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Schools == false)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: "“Build new rural schools. Our primary goal must be to inc..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Schools == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_NewRuralSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Education_RuralSchools = true"*)

### Węzeł `[195]`
**[WYBÓR GRACZA: "“Improve rural education by purchasing new materials and upgrading old school equipment.”"]** — Mówca: **Player**
> "“Improve rural education by purchasing new materials and upgrading old school equipment.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural = true; BaseG..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_LackOfAccessRuralEducation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEducation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_NewRuralSchools = true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == false"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_ImproveRural == false)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: "“Improve rural education by purchasing new materials and ..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_ImproveRural == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_ImprovedRuralSchools = true"*)

### Węzeł `[201]`
Mówca: **Ciara Walda**
> "“That will definitely improve the education experience for our children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“That's all there is for now.”"*)

### Węzeł `[202]`
Mówca: **Ciara Walda**
> "“It feels gratifying that we are finally serving the people directly. I will pass it down to the ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“That's all there is for now.”"*)

### Węzeł `[203]`
Mówca: **Ciara Walda**
> "“Our teachers will be grateful. The payouts shall be prepared immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“That's all there is for now.”"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_ImprovedRuralSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Education_ImprovedRural = ..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Build = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "Jump to: [Education Spending Information Hub]"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "Jump to: [Education Spending Information Hub]"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "Jump to: [Education Spending Information Hub]"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Education_RuralSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_RuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ciara Walda: "“It feels gratifying that we are finally serving the peop..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Education_SalariesIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“Our teachers will be grateful. The payouts shall be prep..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Education_ImprovedRural = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Ciara Walda: "“That will definitely improve the education experience fo..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Education_ImprovedRural = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ciara Walda: "“That will definitely improve the education experience fo..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Education_RuralSchools = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_RuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Ciara Walda: "“It feels gratifying that we are finally serving the peop..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Education_SalariesIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Ciara Walda: "“Our teachers will be grateful. The payouts shall be prep..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FailedEducationReform == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ciara Walda: "“My efforts of trying to reform the education system fail..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FailedEducationReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Ciara Walda: "“Our education system is in shambles and I'm trying to do..."*)

### Węzeł `[217]`
Mówca: **Ciara Walda**
> "“The students of now will thank us in the future President Rayne. For we have unlocked the potential of critical thought this society desperately needed. In this way you have surpassed all the leaders before you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“Sordland needs visionaries like you to reform to become ..."*)
  - -> `[76]` (*Player: "“I did only what was necessary.”"*)
  - -> `[75]` (*Player: "“That is why we are here.”"*)
  - -> `[74]` (*Player: "“You played a huge part in this too, Ciara.”"*)

### Węzeł `[218]`
Mówca: **Ciara Walda**
> "“It's a failure from my end to have come this far and not be able to make transformative change. We could have done so much more President Rayne. We didn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“I did only what was necessary.”"*)
  - -> `[75]` (*Player: "“That is why we are here.”"*)
  - -> `[74]` (*Player: "“You played a huge part in this too, Ciara.”"*)
  - -> `[220]` (*Player: "“It was not the right time and not the right choice Ciara.”"*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Ciara sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Ciara Walda: "“We had a once in a lifetime opportunity to eradicate the..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "“It was not the right time and not the right choice Ciara.”"]** — Mówca: **Player**
> "“It was not the right time and not the right choice Ciara.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Ciara Walda: "“It never is in Sordland.”"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Sordland needs visionaries like you to reform to become something better.”"]** — Mówca: **Player**
> "“Sordland needs visionaries like you to reform to become something better.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Ciara Walda: "“We are onto something promising and grand, Mr. President.”"*)

### Węzeł `[222]`
Mówca: **Ciara Walda**
> "“It never is in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "She shook her head and brought out a stack of papers from..."*)

### Węzeł `[223]`
Mówca: **Ciara Walda**
> "“I'm not going to lie. I'm doubting our strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "She shook her head and brought out a stack of papers from..."*)

### Węzeł `[224]`
Mówca: **Ciara Walda**
> "“I am optimistic about the path that lies ahead of us now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She nodded and brought out a stack of papers from her bag."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ciara Walda: "“I am optimistic about the path that lies ahead of us now.”"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Ciara Walda: "“I'm not going to lie. I'm doubting our strategy.”"*)

### Węzeł `[228]`
Mówca: **Ciara Walda**
> "“We are onto something promising and grand, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She nodded and brought out a stack of papers from her bag."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "She shook her head and brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spinning her ballpoint pen, she went through the papers, ..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelievedWelfareSystem = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_RelievedWelfareSystem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[231]`
Mówca: **Ciara Walda**
> "“My efforts of trying to reform the education system failed due to the lack of funding allocated to the Ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Ciara Walda: "“Our education system is in shambles and I'm trying to do..."*)

### Węzeł `[232]`
Mówca: **Ciara Walda**
> "“Our education system is in shambles and I'm trying to do my best to pick up the pieces and keep it going.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelievedWelfareSystem = true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[236]`
Mówca: **Ciara Walda**
> "“A fact that the people will not forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[237]`
Mówca: **Ciara Walda**
> "“New private schools are increasing the disparity of services in education. Lower-income households who can't afford the private school in their district and might need to send their children to a public school far away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EducationGap = true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HealthGap = true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConferen..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EducationGap = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_EducationGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Privatization == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HealthGap = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_HealthGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConferen..."*)

### Węzeł `[246]`
Mówca: **Ciara Walda**
> "“New private schools are increasing the disparity of services in education. Lower-income households who can't afford the private school in their district and might need to send their children to a public school far away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[247]`
Mówca: **Ciara Walda**
> "“The state having had to rely on privatization funds is a disgrace. We are letting private interests meddle in the most essential service; learning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Ciara Walda: "“New private schools are increasing the disparity of serv..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Ciara Walda: "“The state having had to rely on privatization funds is a..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Inflation == true && BaseGame.Turn06_EnergyInflationCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Inflation == true && BaseGame.Turn06_Ener..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Inflation == true && BaseGame.Turn06_En..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Inflation == true && BaseGame.Turn06_EnergyInflationCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Inflation"] == true  and  Variable["BaseGame.Turn06_EnergyInflationCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Inflation == true && BaseGame.Turn06_EnergyInflationCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Inflation"] == true  and  Variable["BaseGame.Turn06_EnergyInflationCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "After a meeting with the rector and a brief tour of the U..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_R_InflationCrisis = true; Bas..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FailedEducationReform == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FailedEducationReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_EnT_Started2ndMegaproject == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_EnT_Started2ndMegaproject == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_EnT_Started2ndMegaproject == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_EnT_Started2ndMegaproject == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_EnT_Started2ndMegaproject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_T..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_EnT_Started2ndMegaproject == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_EnT_Started2ndMegaproject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_T..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_InT_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_SordishState == true || BaseGame.Deci..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_SordishState == true || BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_SordishState == true || BaseGame.Deci..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_InT_SordishState == true || BaseGame.De..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_SordishState == true || BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_InT_SordishState"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_InT_SordishState == true || BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_SordishState"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_SarnaProject_Taurus = true;"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_BenfiProject_Taurus = true;"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_ConriatProject_Taurus = true;"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_MornaProject_Taurus = true;"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_SarnaProject_Taurus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_SarnaProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_BenfiProject_Taurus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_BenfiProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_ConriatProject_Taurus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ConriatProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_MornaProject_Taurus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_MornaProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_SarnaProject_SSC = true;"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_BenfiProject_SSC = true;"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_ConriatProject_SSC = true;"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_MornaProject_SSC = true;"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_MornaProject_SSC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_MornaProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_SarnaProject_SSC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_SarnaProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_ConriatProject_SSC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ConriatProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_BenfiProject_SSC = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_BenfiProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_SarnaProject_Underhall = t..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_BenfiProject_Underhall = t..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_ConriatProject_Underhall =..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_MornaProject_Underhall = t..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_MornaProject_Underhall = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_MornaProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_SarnaProject_Underhall = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_SarnaProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_ConriatProject_Underhall = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ConriatProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_BenfiProject_Underhall = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_BenfiProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Inflation == true && BaseGame.Turn06_Ener..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_R_InflationCrisis = true;
BaseGameSupport.Report_Turn06_Holsord_InflationCrisis = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_InflationCrisis"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_InflationCrisis"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "After a meeting with the rector and a brief tour of the U..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGam..."*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == false || BaseG..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == false  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_R_PFJPAgainstProposal = true"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == false  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_R_PFJPAgainstProposal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_PFJPAgainstProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == false || BaseGa..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false  or  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_NFPAgainstProposal = true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_NFPAgainstProposal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_NFPAgainstProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_EnT_Started2ndMegaproject == true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGam..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperatio..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_ST_RefugeesFlee_NoOperation =..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_R_RefugeeCrisis_NoWehlenDeal ..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_ST_RefugeesFlee_NoOperation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_RefugeesFlee_NoOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_R_RefugeeCrisis_NoWehlenDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_RefugeeCrisis_NoWehlenDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[340]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Sarna", "Progress_Agricultu..."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Morna", "Progress_SeaPort")..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Benfi", "Progress_Internati..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Conriat", "Progress_Industr..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || ..."*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true |..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The entire campus was visible from the windows. Students ..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "The entire campus was visible from the windows. Students ..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "The entire campus was visible from the windows. Students ..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "The entire campus was visible from the windows. Students ..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Morna == true)"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "The entire campus was visible from the windows. Students ..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Morna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelievedWelfareSystem = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_RelievedWelfareSystem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Ciara put the papers back in her bag and left the meeting..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true ..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelievedWelfareSystem = true"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "Ciara put the papers back in her bag and left the meeting..."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "Ciara put the papers back in her bag and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true &&..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Sarna", "Progress_AgriculturalZone");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","Progress_AgriculturalZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Morna", "Progress_SeaPort");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Morna","Progress_SeaPort");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Conriat", "Progress_IndustrialZone");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Conriat","Progress_IndustrialZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Benfi", "Progress_InternationalAirport");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Benfi","Progress_InternationalAirport");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn06_Holsord_ErsenCaseGoesToCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn06_Holsord_ErsenCaseGoesToCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_HP_ErsenCaseGoesToCourt = tru..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_HP_ErsenCaseGoesToCourt = true;
BaseGameSupport.News_Turn06_R_ErsenCaseGoesToCourt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ErsenCaseGoesToCourt"] = true;
Variable["BaseGameSupport.News_Turn06_R_ErsenCaseGoesToCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn06_Holsord_ErsenCaseGoesToCour..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConference = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConference"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_PSnW_EducationSpending = true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_G_PressFreedomsUC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_G_PressFreedomsUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
