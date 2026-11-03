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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 56

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Bergia`
- `BaseGame.GovernmentBudget`
- `BaseGame.Relations_Walter_Promise_PrivatizationFulfilled`
- `BaseGame.Situation_Economy_PandemicFallout`
- `BaseGame.Situation_Welfare_SollistTeachings`
- `BaseGame.Sollist`
- `BaseGameIsolated.HealthBudget_Hub_Option1`
- `BaseGameIsolated.HealthBudget_Hub_Option2`
- `BaseGameIsolated.HealthBudget_Hub_Option3`
- `GameCondition.Turn06_PSnW_HealthBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[83]` (Paskal Beniwoll): `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] = true;`
- Węzeł `[87]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Welfare_HealthPrivatization"] = true;`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["BaseGame.Situation_Welfare_HealthGap"] = true;`
- Węzeł `[89]` (Paskal Beniwoll): `Variable["GameCondition.Turn06_PSnW_HealthBudget"] = true;`
- Węzeł `[90]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true; Variable["BaseGame.Situation_Wel...`
- Węzeł `[91]` (Paskal Beniwoll): `Variable["BaseGame.Healthcare"] = Variable["BaseGame.Healthcare"] + 1;`
- Węzeł `[94]` (Paskal Beniwoll): `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true; Variable["BaseGame.Public_Opinion"] = ...`
- Węzeł `[104]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Welfare_EducationReform"] = false; Variable["BaseGame.Situation_Welfare...`
- *...oraz 48 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was having my afternoon tea in the state house office in Deyr and going through newspapers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "One of the headlines piqued my interest. It read 'Polio Crisis in Wehlen'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Before I could start reading, I heard a couple of knocks. Paskal entered followed by Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> "“Mr. President. It's time for the scheduled healthcare meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
> "“Good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[8]`
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Very well. Let's begin.”"]** — Mówca: **Player**
> "“Very well. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Please take your seats.”"]** — Mówca: **Player**
> "“Please take your seats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and they have taken their seats and Paskal produced documents from his suitcase. He put them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "They have taken their seats and Paskal produced documents from his suitcase. He put them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Paskal looked at the newspaper I was reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
> "“Very troubling news from Wehlen, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
> "“I have just returned from a meeting with our top scientists on the matter of Polio. It seems to be spreading.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[158]`
  - -> `[166]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Indeed. This might have dire consequences in the region.”"]** — Mówca: **Player**
> "“Indeed. This might have dire consequences in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I'm not worried. It will stop before it reaches Sordland.”"]** — Mówca: **Player**
> "“I'm not worried. It will stop before it reaches Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
> "“What I was told by our researchers was that with the current infection rate there will soon be millions of people affected by Polio.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[18]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
> "“We need to be ready for any possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“I doubt it is that serious yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“Regardless, back to the topic. Mr. Beniwoll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“Mr. Beniwoll?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
> "“Yes. Yes, of course. Let's start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Paskal put on his reading glasses and went through the documents. He didn't say anything for a whole minute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[25]`
Mówca: **Narrator**
> "He put the papers down, cleared his throat and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
> "“As you know, I have been preparing a new privatization program that would create funds through selling of unused ministry property and some extra taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
> "“The overall mood has been positive as the administration focuses more on the healthcare. I'm excited about what we can achieve with the allocated funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[44]`
  - -> `[43]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
> "“The reduction of health funds is going to hurt no matter how we manage it. I will need to make big concessions, which will hamper our efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[39]`
  - -> `[62]`
  - -> `[170]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
> "“But I'm still happy that the administration continues to support healthcare at the same level as before. Though, this limits our options significantly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[36]`
  - -> `[168]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“We will have to make do with what we have. I want you to lead the way to solutions in healthcare.”"]** — Mówca: **Player**
> "“We will have to make do with what we have. I want you to lead the way to solutions in healthcare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
> "“I don't think that this is a matter that can be easily solved. More thought needs to be put in how do we go about lowering our budget or where do we cut it from.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
> "“I'm personally invested to solve the horrible infant and maternal death rates along with your requests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I'm sure you can figure out a way to come out of this strong. I have put trust in you.”"]** — Mówca: **Player**
> "“I'm sure you can figure out a way to come out of this strong. I have put trust in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
> "“I don't see many ways out of this particular situation. We need funds to bring improvements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Our health services seem to be working fine and don't require more investment. I'm sure we can improve what we have.”"]** — Mówca: **Player**
> "“Our health services seem to be working fine and don't require more investment. I'm sure we can improve what we have.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Healthcare isn't a urgency for this administration. We have to make do with less.”"]** — Mówca: **Player**
> "“Healthcare isn't a urgency for this administration. We have to make do with less.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“We have to minimize service disparity in the country. The situation isn't good at all.”"]** — Mówca: **Player**
> "“We have to minimize service disparity in the country. The situation isn't good at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Providing better healthcare is our goal. This administration will be known to have supported the welfare services.”"]** — Mówca: **Player**
> "“Providing better healthcare is our goal. This administration will be known to have supported the welfare services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
> "“In general, I am very content with the budget decision that was made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
> "“In general, the ministry is somewhat content with the budget decision that was made. At least we didn't get a cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
> "“In general, the ministry is not very content with the decision to cut the budget of our healthcare system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
> "“This comes as no surprise as I know you are a man of your word. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
> "“This comes as a very pleasant surprise that we all welcomed at the ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Do you have any specific areas of focus in mind?”"]** — Mówca: **Player**
> "“Do you have any specific areas of focus in mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
> "“Although, I have to say this came as a surprise to many since one of our campaign focuses was healthcare. I am not sure if we're abiding by that promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
> "“Although, I have to say this came as a surprise to many since one of our campaign focuses was healthcare. I am not sure if we're abiding by that promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“What kind of concessions?”"]** — Mówca: **Player**
> "“What kind of concessions?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
> "“I am still formulating a plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> "“I know of this too, Paskal. But this goes against our economic doctrine. Additionally, health is a key sector people expect to have in public hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“It might not go against our strategy to promote a market economy, but I'm personally against privatization of government services. Such vital services must be under state control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“Aside from creating additional funds, there is a long-term problem with privatization in a country like Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[73]`
  - -> `[79]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“Messing with that structure will definitely hurt us politically in the future. That I know for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
> "“The market should take care of it by itself. We can't regulate people like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
> "“I do agree that there is some concern there... But the benefits of competitive and quality services is greater.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“You are right. There might be structural issues... Especially due to private greed and market manipulation.”"]** — Mówca: **Player**
> "“You are right. There might be structural issues... Especially due to private greed and market manipulation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I don't see a problem with privatization. It would create additional funds and boost enterprise.”"]** — Mówca: **Player**
> "“I don't see a problem with privatization. It would create additional funds and boost enterprise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
> "“We will prevent the worst case scenarios. There needs to be healthy structural improvements in this sector.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Also in a country where most people don't have access to quality healthcare...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“People are already lacking proper healthcare even though it is free. What happens when you privatise? Prices increase as state hospitals close due to sales.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“For now it wouldn't. Privatization would be fair if our healthcare standards were high and accessible for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“What are those problems?”"]** — Mówca: **Player**
> "“What are those problems?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“This is not Arcasia nor Lespia. You are talking about Sordland, in which the healthcare is free for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“We have people who have their lives depending on a service that is free to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“But the choice is yours, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“We'll keep healthcare in state control. Don't allow any private involvement that could endanger core health services.”"]** — Mówca: **Player**
> "“We'll keep healthcare in state control. Don't allow any private involvement that could endanger core health services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""It's largely due to outdated facilities that lack proper hygiene standards and equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Building new hospitals sounds interesting. It would also boost our popularity.”"]** — Mówca: **Player**
> "“Building new hospitals sounds interesting. It would also boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_HealthPrivatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_HealthPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HealthGap = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_HealthGap"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_PSnW_HealthBudget = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_PSnW_HealthBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_TraditionalEducation = true;
BaseGame.Situation_Welfare_SollistTeachings = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true;
Variable["BaseGame.Situation_Welfare_SollistTeachings"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Healthcare += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Healthcare"] = Variable["BaseGame.Healthcare"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
> "“Excellent. We can turn that extra money to something useful. I shall let my partners know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
> "“As you wish. The health services shall remain in public hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“I don't think this was the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“Good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“Very well. Fruitful meeting nevertheless. Nice and short.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[157]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationReform = false;
BaseGame.Situation_Welfare_FailedEducationReform = true;
BaseGame.Situation_Welfare_ModernEducationTechniques = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationReform"] = false;
Variable["BaseGame.Situation_Welfare_FailedEducationReform"] = true;
Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"]** — Mówca: **Player**
> "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"]** — Mówca: **Player**
> "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Build new hospitals where they are needed. Access to health will be available for all.”"]** — Mówca: **Player**
> "“Build new hospitals where they are needed. Access to health will be available for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
> "“Since we will have extra funds, the spending policy question remains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural = true;
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
> "“Now let's get to the big question of how we will spend the extra funds dedicated to the Ministry of Health.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Salary == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Paskal gathered his documents and left along with Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Hospitals == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Just the way I like it.”"]** — Mówca: **Player**
> "“Just the way I like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Thank you for the meeting.”"]** — Mówca: **Player**
> "“Thank you for the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""It's a visible, tangible improvement that we can present as our achievement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
> ""The sad reality is that our rural clinics are woefully outdated, ill-equipped, and understaffed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
> "“We can initiate one more spending policy with our funds. Which one would should we initiate?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[180]`
  - -> `[177]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
> "“I urge you to consider these proposals. We could build new hospitals where necessary, divert funds to increase the salaries of our health workers, or invest in enhancing the existing treatment facilities in rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
> ""While the construction of new hospitals is an appealing idea, I personally don't see it as a primary concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
> "“Each of these options presents a unique path towards improving healthcare access and quality in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> ""However, implementing a nationwide, proportional salary boost would pay off politically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
> "“Therefore, I believe improving treatment in rural areas should be our course of action, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[135]`
Mówca: **Narrator**
> "A few minutes went by in contemplation as the moment to make a decision came near."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[114]`
  - -> `[111]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Increasing salaries should have a good effect for doctors, nurses and other staff who work so hard for our citizens.”"]** — Mówca: **Player**
> "“Increasing salaries should have a good effect for doctors, nurses and other staff who work so hard for our citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Improving treatment in rural areas is a must. It would prevent mistreatment, disease and sickness.”"]** — Mówca: **Player**
> "“Improving treatment in rural areas is a must. It would prevent mistreatment, disease and sickness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
> ""Well, that wraps up our discussion for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“It would be best to consider the political advantages of each one, as well as the practical advantages before making a decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewHospitals = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
> ""There's merit in the proposal to increase salaries for all health staff, with an extra emphasis on rural areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Turn06_PSnW_Healthcare_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
> "“New contracts for improvements will be drawn up immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HappyHealthWorkers = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyHealthWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
> ""In my view, the pressing issue lies in the quality and accessibility of healthcare in remote areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
> ""This approach could incentivize doctors and nurses to work in these regions where their services are desperately needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
> ""This stark disparity between urban and rural healthcare is a major contributor to the high maternal mortality rates and prevalence of other diseases in our rural communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Constructing new hospitals would score us significant political points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
> "“I'll prepare the increase as soon as possible. The workers will rejoice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
> "“We shall begin plans of hospital constructions immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
> ""Metropolitan areas are already reaping the benefits of our policies. The rural regions, which trail behind in income, deserve some attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""We're seeing an uptick in minor outbreaks in specific regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Dismissed.”"]** — Mówca: **Player**
> "“Dismissed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“What are we doing to prepare?”"]** — Mówca: **Player**
> "“What are we doing to prepare?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
> "“So we have notified all of our healthcare staff especially the ones closer to the Wehlen border. Unfortunately these are also the more rural areas where we lack equipment and staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
> "“We have notified all of our healthcare staff, especially the ones closer to the Wehlen border. Unfortunately, these are also the more rural areas where we lack equipment and staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
> "“What I was told by our researchers was that with the current infection rate, there will soon be millions of people affected by Polio.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true && BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true  and  Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_PrivatizationFulfilled = true; BaseGame.Faction_Oligarchs_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] = true;
Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "“Why am I just learning this from a newspaper?”"]** — Mówca: **Player**
> "“Why am I just learning this from a newspaper?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
> "“We are already evaluating the situation and did not want to bother you with it yet, Mr. President. We are working on a comprehensive report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "“It was not a decision that I made lightly.”"]** — Mówca: **Player**
> "“It was not a decision that I made lightly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
> "“I am sure, Mr. President. I am not questioning that. But...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“It was not a decision that I made lightly.”"]** — Mówca: **Player**
> "“It was not a decision that I made lightly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
> "“I am sure, Mr. President. I am not questioning that. But...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“Build new hospitals where they are needed. Access to health will be available for all.”"]** — Mówca: **Player**
> "“Build new hospitals where they are needed. Access to health will be available for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"]** — Mówca: **Player**
> "“Improve rural treatment by hiring health staff and upgrading equipment in rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"]** — Mówca: **Player**
> "“Increase salaries of doctors, nurses and other health staff with incentives for rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural = true;
BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Salary == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Salary == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Hospitals == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Hospitals = true;
BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_NewHospitals = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_LackOfQualityRuralHealthcare"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_HappyHealthWorkers = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Welfare_HappyHealthWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
> "“I'll prepare the increase as soon as possible. The workers will rejoice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
> "“We shall begin plans of hospital constructions immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
> "“New contracts for improvements will be drawn up immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Taurus_2ndProject_Expensive = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Taurus_2ndProject_Expensive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Taurus_2ndProject_Cheaper = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Taurus_2ndProject_Cheaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SSC_2ndProject_Cheaper = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SSC_2ndProject_Cheaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.SSC_2ndProject_Expensive = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.SSC_2ndProject_Expensive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_Privatised = true;
BaseGame.Capitalist += 5;
BaseGame.Malenyevist -= 6;
BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_Privatised"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 5;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 6;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_State = true;
BaseGame.Capitalist -= 2;
BaseGame.Malenyevist += 2;
BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_State"] = true;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_NewHospitals = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_SalariesIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_ImprovedRural = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_ImprovedRural = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_ImprovedRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_NewHospitals = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_NewHospitals"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Health_SalariesIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Health_SalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_PSnW_Healthcare_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_PSnW_Healthcare_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_R_HealthcarePrivatized = true;
BaseGameSupport.News_Turn06_E_HealthcarePrivatized = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_R_HealthcarePrivatized"] = true;
Variable["BaseGameSupport.News_Turn06_E_HealthcarePrivatized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_G_HeljilandGovernor = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_G_HeljilandGovernor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_HP_EmergencyYS_Extended = true;
BaseGameSupport.Report_Turn06_Holsord_YSJournalistReleased = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_HP_EmergencyYS_Extended"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_YSJournalistReleased"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_ST_BludsCrossBorder_Operation = true;
BaseGameSupport.Report_Turn06_Uziren_BludsCrossBorder = true;
BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_BludsCrossBorder_Operation"] = true;
Variable["BaseGameSupport.Report_Turn06_Uziren_BludsCrossBorder"] = true;
Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_JointOperation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn06_Wehlen_NoWehlenDeal = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_NoWehlenDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn06_Wehlen_BorderGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn06_Wehlen_BorderGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Healthcare >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Healthcare >= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Healthcare"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Healthcare >= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Healthcare"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Bergia -= 1;
BaseGame.Situation_Economy_PandemicFallout = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] - 1;
Variable["BaseGame.Situation_Economy_PandemicFallout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Healthcare >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Healthcare >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Healthcare"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Healthcare >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Healthcare"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Economy_PandemicFallout = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Economy_PandemicFallout"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: HealthBudgetChoices)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[268]`
  - -> `[271]`
  - -> `[275]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
> ""In my book 'The Unfortunate Man', I depicted the hardships of a poor mining family, a vivid illustration of the stark health inequalities in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
> ""As Minister of Health, I strive to rectify these disparities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [HealthBudgetChoices])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option1 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option1 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.HealthBudget_Hub_Option1 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option2 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option2 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.HealthBudget_Hub_Option2 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option3 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option3 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.HealthBudget_Hub_Option3 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WYBÓR GRACZA: "“We can proceed with the decision, Minister Beniwoll.”"]** — Mówca: **Player**
> "“We can proceed with the decision, Minister Beniwoll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseGameIsolated.HealthBudget_Hub_Option2 == true ||BaseGameIsolated.HealthBudget_Hub_Option3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseGameIsolated.HealthBudget_Hub_Option2 == true ||BaseGameIsolated.HealthBudget_Hub_Option3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.HealthBudget_Hub_Option1 == true ||BaseGameIsolated.HealthBudget_Hub_Option2 == true ||BaseGameIsolated.HealthBudget_Hub_Option3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.HealthBudget_Hub_Option1"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option2"] == true  or Variable["BaseGameIsolated.HealthBudget_Hub_Option3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
> ""But certainly, adding new healthcare facilities would be a positive step, particularly in underserved regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
> ""On a larger scale, it would boost satisfaction within the health industry and could contribute significantly to reducing maternal mortality rates, a goal that is close to my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
> ""Addressing this issue is one of my key objectives in this term, and I believe an overhaul of the rural healthcare infrastructure is a critical step in that direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "“We will promote privatization and allow the private sector to invest and buy government's health properties.” [+2 Government Budget]"]** — Mówca: **Player**
> "“We will promote privatization and allow the private sector to invest and buy government's health properties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
**[WYBÓR GRACZA: "“We will promote privatization and allow the private sector to invest and buy government's health properties.” [+1 Government Budget]"]** — Mówca: **Player**
> "“We will promote privatization and allow the private sector to invest and buy government's health properties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
