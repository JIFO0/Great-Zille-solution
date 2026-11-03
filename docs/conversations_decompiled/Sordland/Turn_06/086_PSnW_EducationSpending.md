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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 66

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[108]` (Ciara Walda): `Variable["GameCondition.Turn06_PSnW_EducationSpending"] = true;`
- Węzeł `[148]` (Ciara Walda): `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true; Variable["BaseGame.Public_Opinion"] = V...`
- Węzeł `[149]` (Ciara Walda): `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true; Variable["BaseGame.Public_Opinion"] = ...`
- Węzeł `[150]` (Ciara Walda): `Variable["BaseGame.Situation_Welfare_HappyEducationWorkers"] = true;`
- Węzeł `[158]` (Ciara Walda): `Variable["BaseGame.Situation_Welfare_NewRuralSchools"] = true;`
- Węzeł `[169]` (Ciara Walda): `Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEducation"] = false;`
- Węzeł `[170]` (Ciara Walda): `Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools"] = true;`
- Węzeł `[172]` (Ciara Walda): `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] = true; Variable["BaseGame.Public_Opinion...`
- *...oraz 58 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Ciara Walda)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After a meeting with the rector and a brief tour of the University of Valgen, we gathered in a room with Ciara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Narrator**
> "It reminded me of my own times at Deyr University of Culture -- at least, the more carefree moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "It reminded me of my own times at Holsord State University -- at least, the more carefree moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Narrator**
> "It reminded me of my own times at Lachaven Business School -- at least, the more carefree moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Ciara Walda**
> "“Reminiscing about the past?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[16]`
  - -> `[15]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“It's nothing.”"]** — Mówca: **Player**
> "“It's nothing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Yes. It had its ups and downs but it was still fun.”"]** — Mówca: **Player**
> "“Yes. It had its ups and downs but it was still fun.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Ciara Walda**
> "“And now we're growing old and bitter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[18]`
Mówca: **Ciara Walda**
> "“The usual story. A few friends dead, a couple of them missing after the coups. Oh, and I was almost arrested once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[20]`
  - -> `[23]`
  - -> `[179]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“How were your university years?”"]** — Mówca: **Player**
> "“How were your university years?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“What for?”"]** — Mówca: **Player**
> "“What for?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Ciara Walda**
> "“Protesting against police brutality. Ironic, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“No good memories? You should try to be a bit more optimistic.”"]** — Mówca: **Player**
> "“No good memories? You should try to be a bit more optimistic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“We all went through tough times back then.”"]** — Mówca: **Player**
> "“We all went through tough times back then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Ciara Walda**
> "“It's difficult when there's nothing positive about those times. Also, being a pessimist makes me realise the problems quicker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Ciara Walda**
> "“Some of us more so than others.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Ciara Walda**
> "“Let's not get sidetracked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[27]`
Mówca: **Ciara Walda**
> "“Let's begin then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[30]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[33]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[34]`
Mówca: **Ciara Walda**
> "“I want to start off by saying this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Ciara Walda**
> "“Unfortunately our fuel is running out at the Ministry of Education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[36]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[39]`
Mówca: **Ciara Walda**
> "“The state having had to rely on privatization funds is a disgrace. We are letting private interests meddle in the most essential service; learning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[40]`
Mówca: **Ciara Walda**
> "“It was very positive to see the administration dedicate the funding that was requested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[41]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[44]`
Mówca: **Ciara Walda**
> "“I want to thank you for allowing me to lead our education system in the right direction. By removing nationalist indoctrination and traditional teachings we have unlocked the potential of the next generation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[45]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[48]`
Mówca: **Ciara Walda**
> "“Although I insist that the funds are still necessary to close the gaps in services, I can't say we have been entirely off track.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Ciara Walda**
> "“I want to thank you for leading our education system in the right direction. Traditional teachings have long prevented proper progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[80]`
  - -> `[79]`

### Węzeł `[50]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`
  - -> `[92]`

### Węzeł `[53]`
Mówca: **Ciara Walda**
> "“What little money we allocated from privatization will be diverted to improvements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Ciara Walda**
> "“I doubt it will be enough to make substantial change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`
  - -> `[92]`

### Węzeł `[55]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[58]`
Mówca: **Ciara Walda**
> "“It comes at a welcome surprise in Sordish politics to see a President uphold their promises regarding education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Ciara Walda**
> "“I am making sure that the additional funds are being used in the best way possible in order to resolve structural issues, speaking of.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[60]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Ciara Walda**
> "“Although you swore you would focus on education during your term, you have not lived up to that promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[64]`
Mówca: **Ciara Walda**
> "“Stagnation doesn't get anyone anywhere. Simply maintaining my ministry's funds got us sitting duck with the dozens of issues left unsolvable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[65]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[68]`
Mówca: **Ciara Walda**
> "“The effects of your decision are much greater than I think you realise. The real damage is being done to the younger generation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Ciara Walda**
> "“I feel personally betrayed. You promised to focus on education during our term. And here we are suffering the consequences of a budget cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Ciara Walda**
> "“I'm trying very hard to look past that but can't really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "She regarded me coolly for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[72]`
Mówca: **Ciara Walda**
> "“We had a once in a lifetime opportunity to eradicate the political indoctrination and the traditional methods of education. We have sadly missed this chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[73]`
Mówca: **Ciara Walda**
> "“And as you have already stated, improving Sordland's sexist and horrendously outdated education system is low on your priorities list.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[82]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“You played a huge part in this too, Ciara.”"]** — Mówca: **Player**
> "“You played a huge part in this too, Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“That is why we are here.”"]** — Mówca: **Player**
> "“That is why we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I did only what was necessary.”"]** — Mówca: **Player**
> "“I did only what was necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[77]`
Mówca: **Narrator**
> "She nodded and brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[78]`
Mówca: **Narrator**
> "She nodded and brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“You played a huge part in this too, Ciara.”"]** — Mówca: **Player**
> "“You played a huge part in this too, Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“That is why we are here.”"]** — Mówca: **Player**
> "“That is why we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“I did only what was necessary.”"]** — Mówca: **Player**
> "“I did only what was necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“There are other priorities.”"]** — Mówca: **Player**
> "“There are other priorities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Do not question my decision, Ciara.”"]** — Mówca: **Player**
> "“Do not question my decision, Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“There is nothing wrong with the current education system as it is.”"]** — Mówca: **Player**
> "“There is nothing wrong with the current education system as it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Ciara Walda**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Her eyes widened, but she composed herself quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[87]`
Mówca: **Ciara Walda**
> "“We've been through this. I showed you the statistics. Yet you didn't listen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Ciara Walda**
> "“Never mind. There is no point talking about what's already done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[89]`
Mówca: **Ciara Walda**
> "“What priorities can there be other than the future of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“I am sure you will make do.”"]** — Mówca: **Player**
> "“I am sure you will make do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“The money was needed elsewhere.”"]** — Mówca: **Player**
> "“The money was needed elsewhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Do not question my decision, Ciara.”"]** — Mówca: **Player**
> "“Do not question my decision, Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Ciara Walda**
> "“Never mind. There is no point talking about what is already done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[94]`
Mówca: **Ciara Walda**
> "“What other priorities there can be other than the future of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Ciara Walda**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Her eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[97]`
Mówca: **Ciara Walda**
> "“That is precisely the problem. We can't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Ciara Walda**
> "“We will have to make cuts from wherever we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Narrator**
> "She brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Narrator**
> "She brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Spinning her ballpoint pen, she went through the papers, organising some of them together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Maintain == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[104]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Maintain == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[105]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[108]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_PSnW_EducationSpending = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_PSnW_EducationSpending"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[109]`
Mówca: **Ciara Walda**
> "“Our ministry has prepared the necessary framework regarding how to spend our increased education budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Ciara Walda**
> "“Our ministry has prepared the necessary framework regarding how to spend the funds we've gained through school privatization.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Ciara Walda**
> "“We can build new rural schools, improve the standards of existing ones, or increase salaries for all education workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Ciara Walda**
> "“I have outlined three potential options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Ciara Walda**
> "“Because of the additional funds from privatization on top of the budget increase, we should be able to implement two of these options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Ciara Walda**
> "“We have the capacity to implement only one of these options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Education Spending Information Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[125]`
  - -> `[122]`
  - -> `[128]`

### Węzeł `[119]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[121]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[124]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[127]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[128]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[130]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve == true || BaseGameIsolated.Turn06_PSnW_EducationInfo_Build == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] == true  or  Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Tell me about the plan to build new rural schools.”"]** — Mówca: **Player**
> "“Tell me about the plan to build new rural schools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Ciara Walda**
> "“The issue is very critical, as we are losing many young people to ignorance and illiteracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Ciara Walda**
> "“Sordland's rural population is full of untapped potential. With enough education, these people could be an asset to our workforce and society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Why should we increase the salaries of education workers?”"]** — Mówca: **Player**
> "“Why should we increase the salaries of education workers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Ciara Walda**
> "“The job itself should be held in higher regard and be compensated accordingly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Ciara Walda**
> "“These are people who have chosen to dedicate themselves to the betterment of others. To helping raise the next generation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“What does improving rural schools entail?”"]** — Mówca: **Player**
> "“What does improving rural schools entail?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Ciara Walda**
> "“Where to start? At the very least, they need new equipment and materials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Ciara Walda**
> "“Many of these schools are facing a shortage of desks and textbooks. The ones that aren't haven't been updated since before the Soll administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I am ready to decide.”"]** — Mówca: **Player**
> "“I am ready to decide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Let's move on to the decision and get on with it.”"]** — Mówca: **Player**
> "“Let's move on to the decision and get on with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Ciara Walda**
> "“Look at how United Contana is pushing past Arcasia in education and research. It's because most of their rural populace has access to schools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[143]`
Mówca: **Ciara Walda**
> "“We ought to give them what they deserve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[144]`
Mówca: **Ciara Walda**
> "“If teachers lack the resources to give Sordish youth a proper education, it can be as bad as if they don't go to school at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[145]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [Education Spending Information Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[146]`
Mówca: **Narrator**
> "She put the pen down and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[152]`
  - -> `[165]`

### Węzeł `[147]`
**[WYBÓR GRACZA: "“Build new rural schools. Our primary goal must be to increase access to education.”"]** — Mówca: **Player**
> "“Build new rural schools. Our primary goal must be to increase access to education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools = true;
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[150]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HappyEducationWorkers = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyEducationWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Increase salaries of teachers, principals and other education staff all around the country.”"]** — Mówca: **Player**
> "“Increase salaries of teachers, principals and other education staff all around the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[152]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[154]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_Salary == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[155]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[157]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_Schools == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[158]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewRuralSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[159]`
Mówca: **Ciara Walda**
> "“That will definitely improve the education experience for our children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Improve rural education by purchasing new materials and upgrading old school equipment.”"]** — Mówca: **Player**
> "“Improve rural education by purchasing new materials and upgrading old school equipment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“See you at our next meeting.”"]** — Mówca: **Player**
> "“See you at our next meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "“Keep up the good work.”"]** — Mówca: **Player**
> "“Keep up the good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[163]`
Mówca: **Ciara Walda**
> "“As I mentioned before, there are enough resources to initiate one more policy plan. What would your preference be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[188]`
  - -> `[197]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Thank you for your efforts.”"]** — Mówca: **Player**
> "“Thank you for your efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[165]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[167]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_ImproveRural == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
Mówca: **Ciara Walda**
> "“It feels gratifying that we are finally serving the people directly. I will pass it down to the ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_LackOfAccessRuralEducation = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEducation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[170]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_ImprovedRuralSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“Our teachers will be grateful. The payouts shall be prepared immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Policy_Welfare_EducationPrivatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Policy_Welfare_EducationPrivatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[175]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Policy_Welfare_EducationPrivatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Ciara Walda**
> "“That's all there is for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Ciara put the papers back in her bag and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[178]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "“Damn. I'm sorry...”"]** — Mówca: **Player**
> "“Damn. I'm sorry...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Ciara Walda**
> "“It's okay. Many of us have experienced similar stories.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
> "“I have talked with Ms. Suno to schedule some time to discuss the curriculum. She's a very astute woman, your secretary. You may want to consider promoting her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Ciara Walda**
> "“We will meet again very soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[162]`
  - -> `[161]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Build new rural schools. Our primary goal must be to increase access to education.”"]** — Mówca: **Player**
> "“Build new rural schools. Our primary goal must be to increase access to education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools = true;
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[186]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HappyEducationWorkers = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyEducationWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“Increase salaries of teachers, principals and other education staff all around the country.”"]** — Mówca: **Player**
> "“Increase salaries of teachers, principals and other education staff all around the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[188]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Salary == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[190]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_Salary == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_Schools == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[193]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_Schools == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewRuralSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "“Improve rural education by purchasing new materials and upgrading old school equipment.”"]** — Mówca: **Player**
> "“Improve rural education by purchasing new materials and upgrading old school equipment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[196]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_LackOfAccessRuralEducation = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfAccessRuralEducation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[199]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Education_ImproveRural == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Education_ImproveRural = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[201]`
Mówca: **Ciara Walda**
> "“That will definitely improve the education experience for our children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[202]`
Mówca: **Ciara Walda**
> "“It feels gratifying that we are finally serving the people directly. I will pass it down to the ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[203]`
Mówca: **Ciara Walda**
> "“Our teachers will be grateful. The payouts shall be prepared immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[204]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_ImprovedRuralSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_ImprovedRuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[205]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Build = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Build"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[206]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Salary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[207]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_PSnW_EducationInfo_Improve"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[208]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Education_RuralSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_RuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[209]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Education_SalariesIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[210]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Education_ImprovedRural = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[211]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Education_ImprovedRural = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[212]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Education_RuralSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_RuralSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[213]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Education_SalariesIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Education_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[214]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[216]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FailedEducationReform == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[217]`
Mówca: **Ciara Walda**
> "“The students of now will thank us in the future President Rayne. For we have unlocked the potential of critical thought this society desperately needed. In this way you have surpassed all the leaders before you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[76]`
  - -> `[75]`
  - -> `[74]`

### Węzeł `[218]`
Mówca: **Ciara Walda**
> "“It's a failure from my end to have come this far and not be able to make transformative change. We could have done so much more President Rayne. We didn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[75]`
  - -> `[74]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Ciara sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "“It was not the right time and not the right choice Ciara.”"]** — Mówca: **Player**
> "“It was not the right time and not the right choice Ciara.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“Sordland needs visionaries like you to reform to become something better.”"]** — Mówca: **Player**
> "“Sordland needs visionaries like you to reform to become something better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[222]`
Mówca: **Ciara Walda**
> "“It never is in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[223]`
Mówca: **Ciara Walda**
> "“I'm not going to lie. I'm doubting our strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[224]`
Mówca: **Ciara Walda**
> "“I am optimistic about the path that lies ahead of us now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[225]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[227]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[228]`
Mówca: **Ciara Walda**
> "“We are onto something promising and grand, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[229]`
Mówca: **Narrator**
> "She shook her head and brought out a stack of papers from her bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[230]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_RelievedWelfareSystem = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_RelievedWelfareSystem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[231]`
Mówca: **Ciara Walda**
> "“My efforts of trying to reform the education system failed due to the lack of funding allocated to the Ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Ciara Walda**
> "“Our education system is in shambles and I'm trying to do my best to pick up the pieces and keep it going.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[233]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[235]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Ciara Walda**
> "“A fact that the people will not forget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[237]`
Mówca: **Ciara Walda**
> "“New private schools are increasing the disparity of services in education. Lower-income households who can't afford the private school in their district and might need to send their children to a public school far away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[238]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[240]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[244]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EducationGap = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_EducationGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[245]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HealthGap = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_HealthGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[246]`
Mówca: **Ciara Walda**
> "“New private schools are increasing the disparity of services in education. Lower-income households who can't afford the private school in their district and might need to send their children to a public school far away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[247]`
Mówca: **Ciara Walda**
> "“The state having had to rely on privatization funds is a disgrace. We are letting private interests meddle in the most essential service; learning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[248]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[251]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Inflation == true && BaseGame.Turn06_EnergyInflationCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Inflation == true && BaseGame.Turn06_EnergyInflationCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Inflation"] == true  and  Variable["BaseGame.Turn06_EnergyInflationCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Inflation == true && BaseGame.Turn06_EnergyInflationCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Inflation"] == true  and  Variable["BaseGame.Turn06_EnergyInflationCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[254]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[255]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FailedEducationReform == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[259]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[262]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[263]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[264]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[265]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_EnT_Started2ndMegaproject == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_EnT_Started2ndMegaproject == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_EnT_Started2ndMegaproject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_EnT_Started2ndMegaproject == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_EnT_Started2ndMegaproject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[268]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_InT_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_InT_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_SordishState == true || BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_SordishState == true || BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_InT_SordishState"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[273]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_InT_SordishState == true || BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_SordishState"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[274]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[276]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Sarna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[279]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[282]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Conriat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[283]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_SarnaProject_Taurus = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_SarnaProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[284]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_BenfiProject_Taurus = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_BenfiProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_ConriatProject_Taurus = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ConriatProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_MornaProject_Taurus = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_MornaProject_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[288]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[290]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Sarna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[293]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Conriat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[298]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_MornaProject_SSC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_MornaProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[299]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_SarnaProject_SSC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_SarnaProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[300]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_ConriatProject_SSC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ConriatProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[301]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_BenfiProject_SSC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_BenfiProject_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[302]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[304]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Sarna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[307]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[310]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Conriat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_MornaProject_Underhall = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_MornaProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[312]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_SarnaProject_Underhall = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_SarnaProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[313]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_ConriatProject_Underhall = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ConriatProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_BenfiProject_Underhall = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_BenfiProject_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[317]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_R_InflationCrisis = true;
BaseGameSupport.Report_Turn06_Holsord_InflationCrisis = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_InflationCrisis"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_InflationCrisis"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[318]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == false  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == false || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == false  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_R_PFJPAgainstProposal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_PFJPAgainstProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[322]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false  or  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == false || BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_NFPAgainstProposal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_NFPAgainstProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[327]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[329]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[330]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[332]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[333]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_ST_RefugeesFlee_NoOperation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_RefugeesFlee_NoOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[337]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_R_RefugeeCrisis_NoWehlenDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_RefugeeCrisis_NoWehlenDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[339]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[340]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[341]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[342]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[343]`
Mówca: **Narrator**
> "The entire campus was visible from the windows. Students were reading books, studying and having picnics under the trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[344]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_2ndCompanyChoice_SSC == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus == true || BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_SSC"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Taurus"] == true  or  Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[347]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[349]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[352]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Conriat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[355]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Sarna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[356]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Morna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Morna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[358]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Morna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[359]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_RelievedWelfareSystem = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_RelievedWelfareSystem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[360]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[362]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Narrator**
> "Ciara put the papers back in her bag and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[364]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Sarna", "Progress_AgriculturalZone");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","Progress_AgriculturalZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[365]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Morna", "Progress_SeaPort");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Morna","Progress_SeaPort");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[366]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Conriat", "Progress_IndustrialZone");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Conriat","Progress_IndustrialZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[367]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Benfi", "Progress_InternationalAirport");

// Assigns given token status to the given city)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Benfi","Progress_InternationalAirport");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[368]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn06_Holsord_ErsenCaseGoesToCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn06_Holsord_ErsenCaseGoesToCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_ErsenCaseGoesToCourt = true;
BaseGameSupport.News_Turn06_R_ErsenCaseGoesToCourt = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_ErsenCaseGoesToCourt"] = true;
Variable["BaseGameSupport.News_Turn06_R_ErsenCaseGoesToCourt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[370]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[372]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[373]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConference = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn06_CSP_GalmlandConference"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[374]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[375]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_G_PressFreedomsUC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_G_PressFreedomsUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
