# Sordland/Turn04/InT_TaurusRailwayIssue

- **ID konwersacji:** `55`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/055_InT_TaurusRailwayIssue.md`
- **Liczba węzłów dialogowych:** 136
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Vetoed`
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn04_InT_Issue_TH_Give`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Bill_Turn04_WorkersRights_Vetoed`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Law_WorkersRightsReform`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_ExpensiveWorkersPayments`
- `BaseGame.Situation_Welfare_ImprovedWorkingConditions`
- `BaseGame.Turn04_InT_Issue_TH_Give`
- `BaseGame.Turn04_InT_Issue_TH_Money`
- `BaseGame.Turn04_InT_Issue_TH_Replace`
- `BaseGame.Turn04_InT_Issue_TH_Wait`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds`
- `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds`
- `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced`
- `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign`
- `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait`
- `BaseGameSupport.Journal_Turn04_WorkersRights_Signed`
- `BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate`
- `GameCondition.Turn04_InT_Issue`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“Good night.”"** | `[19]` **Symon Holl**: "“Well then. Thank you for coming..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "Symon nodded and we left the mee..."<br>`[32]` **Narrator**: "Symon nodded and we left the mee..." |
| `[12]` | **"“Let's enjoy the hospitality of the Mayor.”"** | `[19]` **Symon Holl**: "“Well then. Thank you for coming..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Symon Holl**: "“That, I'm intending to.”" |
| `[15]` | **"“Thank you everyone.”"** | `[19]` **Symon Holl**: "“Well then. Thank you for coming..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "Symon nodded and we left the mee..."<br>`[32]` **Narrator**: "Symon nodded and we left the mee..." |
| `[17]` | **"“I do not permit incompetence.”"** | `[64]` **Gus Manger**: "“If this causes a delay it would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Gus Manger**: "“Rather than incompetence, accor..." |
| `[29]` | **"“We don't have the funds to spare.”"** | `[40]` **Symon Holl**: "“What is your decision, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Symon Holl**: "“This will most likely cause a d..." |
| `[30]` | **"“Give them the additional funds.” [-1 Government Budget]"** | `[40]` **Symon Holl**: "“What is your decision, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Symon Holl**: "“As you wish. I will allocate th..." |
| `[34]` | **"“We could just wait it out until the strikers get tired.”"** | `[6]` **Gus Manger**: "“There is little point in passin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Gus Manger**: "“This could work. I bet they wil..." |
| `[35]` | **"“Why don't we just do what they want and pass the Workers' Rights bill?”"** | `[6]` **Gus Manger**: "“There is little point in passin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Gus Manger**: "“And give in to the rabble? How ..." |
| `[36]` | **"“Indeed we could just replace the striking workers.”"** | `[6]` **Gus Manger**: "“There is little point in passin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Gus Manger**: "“I think this is our best bet. W..." |
| `[38]` | **"“Why do they even need the extra money?”"** | `[64]` **Gus Manger**: "“If this causes a delay it would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Symon Holl**: "“They need it for unforeseen exp..." |
| `[42]` | **"“It's important that we finish this project on time. Money is no matter.”"** | `[64]` **Gus Manger**: "“If this causes a delay it would..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Symon Holl**: "“If we spend the extra amount th..." |
| `[44]` | **"“Order Taurus Holding to replace the strikers with new workers. This should fix ou..."** | `[67]` **Symon Holl**: "“How should we handle the strikes?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn04_Infrastructure_T...`<br>*(+2 skryptów)* | `[62]` **Symon Holl**: "“Very well. Hopefully the backla..." |
| `[46]` | **"“I'm not worried. Let's just wait it out. They will stop at one point and everythi..."** | `[67]` **Symon Holl**: "“How should we handle the strikes?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn04_Infrastructure_T...`<br>*(+1 skryptów)* | `[58]` **Symon Holl**: "“I'm not sure about this but as ..." |
| `[49]` | **"“We will begin the procedure to pass the vetoed Workers' Rights bill. [-2 Governme..."** | `[67]` **Symon Holl**: "“How should we handle the strikes?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true; Var...`<br>`Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>*(+2 skryptów)* | `[68]` **Gus Manger**: "“This is unfortunate.”" |
| `[55]` | **"“Absolutely not. I will not let a few strikers decide the future of our country.”"** | `[9]` **Symon Holl**: "“However, following the veto, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Gus Manger**: "“I agree. If we let them change ..." |
| `[56]` | **"“You have a point.”"** | `[9]` **Symon Holl**: "“However, following the veto, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Gus Manger**: "“He does but we can't just let a..." |
| `[57]` | **"“We need to cut the head of the snake to truly stop this issue by replacing the st..."** | `[9]` **Symon Holl**: "“However, following the veto, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Gus Manger**: "“Exactly. This is the only way t..." |
| `[93]` | **"“Mistakes happen in any project.”"** | `[92]` **Gus Manger**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Gus Manger**: "“True but we took an extra risk ..." |
| `[94]` | **"“Underhall is a better option indeed.”"** | `[92]` **Gus Manger**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Gus Manger**: "“There are people I know in the ..." |
| `[100]` | **"“The SSC could be a partner.”"** | `[92]` **Gus Manger**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Gus Manger**: "“Not the fossil of a company. If..." |
| `[103]` | **"“Mistakes happen in any project.”"** | `[102]` **Gus Manger**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Gus Manger**: "“True but we took an extra risk ..." |
| `[104]` | **"“Underhall is a better option indeed.”"** | `[102]` **Gus Manger**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Gus Manger**: "“There are people I know in the ..." |
| `[105]` | **"“The SSC could be a partner.”"** | `[102]` **Gus Manger**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Gus Manger**: "“Not the fossil of a company. If..." |

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
  - -> `[79]` (*Narrator: "The L-1 Railway construction created the perfect opportun..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
> "“Even though I agree with your point Gus, this could be the best choice to handle this discreetly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“We need to show people that we can finish this project, ..."*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Gus Manger: "“I don't support that bill just like you Mr. President. T..."*)

### Węzeł `[5]`
Mówca: **Gus Manger**
> "“I don't support that bill just like you Mr. President. The reason is simple, I know it will cause issues with corporations and result in increased employee costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Gus Manger: "“There is little point in passing that bill late. Maybe t..."*)

### Węzeł `[6]`
Mówca: **Gus Manger**
> "“There is little point in passing that bill late. Maybe the best way out of this is replacing the workers on strike.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“We could just wait it out until the strikers get tired.”"*)
  - -> `[35]` (*Player: "“Why don't we just do what they want and pass the Workers..."*)
  - -> `[36]` (*Player: "“Indeed we could just replace the striking workers.”"*)

### Węzeł `[7]`
Mówca: **Gus Manger**
> "“Rather than incompetence, according to their report, their expenses increased drastically due to the new bill increasing workers costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Symon Holl: "“They should've seen this coming. If they didn't, which i..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Good night.”"]** — Mówca: **Player**
> "“Good night.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“However, following the veto, we have ceased the implementation of the policy and disbanded the expert team, resulting in a potential increase in the cost of the bill if new teams are to be established.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "“Absolutely not. I will not let a few strikers decide the..."*)
  - -> `[56]` (*Player: "“You have a point.”"*)
  - -> `[57]` (*Player: "“We need to cut the head of the snake to truly stop this ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign ..."*)

### Węzeł `[11]`
Mówca: **Gus Manger**
> "“Let's see what happens. If we miss the deadlines the people will lose faith in our capabilities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Let's enjoy the hospitality of the Mayor.”"]** — Mówca: **Player**
> "“Let's enjoy the hospitality of the Mayor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Symon Holl: "“That, I'm intending to.”"*)

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“I doubt sitting idly will help in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“We need to show people that we can finish this project, ..."*)

### Węzeł `[14]`
Mówca: **Gus Manger**
> "“Let's hope this will be enough to have a timely opening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 75);  // Updates token..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Thank you everyone.”"]** — Mówca: **Player**
> "“Thank you everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I do not permit incompetence.”"]** — Mówca: **Player**
> "“I do not permit incompetence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Gus Manger: "“Rather than incompetence, according to their report, the..."*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“This will most likely cause a delay but Taurus Holding will be informed immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFun..."*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Well then. Thank you for coming. That is all on this matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“Let's enjoy the hospitality of the Mayor.”"*)
  - -> `[15]` (*Player: "“Thank you everyone.”"*)
  - -> `[8]` (*Player: "“Good night.”"*)

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“As you wish. I will allocate the funding to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Money = true; BaseGameSuppor..."*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“The strike that popped up at the construction site is causing issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: "“After the terrible Morbel mine disaster, workers have be..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Symon Holl: "“Taurus Holding has reached out to us and requested more ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: "“The strike that popped up at the construction site is ca..."*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“After the terrible Morbel mine disaster, workers have been on edge. Vetoing the Workers' Rights bill certainly did not help with the situation either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“Strikers primary demand is for the bill to be reinstated..."*)

### Węzeł `[26]`
Mówca: **Symon Holl**
> "“That, I'm intending to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Gus Manger: "“I will certainly join you.”"*)

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Strikers primary demand is for the bill to be reinstated. We have to solve the issue or the construction will stay halted longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“We scheduled the construction to finish sooner but Tauru..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Replace = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusRepla..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“We don't have the funds to spare.”"]** — Mówca: **Player**
> "“We don't have the funds to spare.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: "“This will most likely cause a delay but Taurus Holding w..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Give them the additional funds.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give them the additional funds.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“As you wish. I will allocate the funding to Taurus Holdi..."*)

### Węzeł `[31]`
Mówca: **Symon Holl**
> "“Taurus Holding has reached out to us and requested more funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Symon Holl: "“As per the report they have sent, to finish the railway ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Symon nodded and we left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“Regardless, the decision is made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“Well then. Thank you for coming. That is all on this mat..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We could just wait it out until the strikers get tired.”"]** — Mówca: **Player**
> "“We could just wait it out until the strikers get tired.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gus Manger: "“This could work. I bet they will get tired after some ti..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Why don't we just do what they want and pass the Workers' Rights bill?”"]** — Mówca: **Player**
> "“Why don't we just do what they want and pass the Workers' Rights bill?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger: "“And give in to the rabble? How many more strikes are goi..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Indeed we could just replace the striking workers.”"]** — Mówca: **Player**
> "“Indeed we could just replace the striking workers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gus Manger: "“I think this is our best bet. We can't stand idle and we..."*)

### Węzeł `[37]`
Mówca: **Symon Holl**
> "“This will only serve to rile up the strikers even more. We might end up with a bigger mess.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“We need to show people that we can finish this project, ..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Why do they even need the extra money?”"]** — Mówca: **Player**
> "“Why do they even need the extra money?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Symon Holl: "“They need it for unforeseen expenses that came from the ..."*)

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“And give in to the rabble? How many more strikes are going to create if we show them that they can change what the state has already decided on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Symon Holl: "“Even though I agree with your point Gus, this could be t..."*)

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“What is your decision, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: "“Give them the additional funds.” [-1 Government Budget]"*)
  - -> `[29]` (*Player: "“We don't have the funds to spare.”"*)

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“This could work. I bet they will get tired after some time and go back to their jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“I doubt sitting idly will help in this case.”"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“It's important that we finish this project on time. Money is no matter.”"]** — Mówca: **Player**
> "“It's important that we finish this project on time. Money is no matter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“If we spend the extra amount they are requesting, we mig..."*)

### Węzeł `[43]`
Mówca: **Gus Manger**
> "“I think this is our best bet. We can't stand idle and we can't allow a few strikers to change the laws of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Symon Holl: "“This will only serve to rile up the strikers even more. ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"]** — Mówca: **Player**
> "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Replace = true"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "We left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"]** — Mówca: **Player**
> "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Wait = true"*)

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“Realities of running a business is to be able to adapt to changing circumstances. The most important thing here is to finish the project on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Give = true; BaseGame.Turn04_InT_RailwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true;
Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“We will begin the procedure to pass the vetoed Workers' Rights bill. [-2 Government Budget]”"]** — Mówca: **Player**
> "“We will begin the procedure to pass the vetoed Workers' Rights bill.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give = true; BaseGame.Turn04..."*)

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“We need to show people that we can finish this project, our first mega project, on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Symon Holl: "“As much as I hate to say it, I think passing the Workers..."*)

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“They need it for unforeseen expenses that came from the new Workers' Rights Bill. A couple of shipment companies they had contracts with also increased costs on the necessary materials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gus Manger: "“Realities of running a business is to be able to adapt t..."*)

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“It is unfortunate but construction can be disrupted when costs change dramatically. I knew that something was wrong when they offered the contract for cheaper. Underhall wouldn't have had this problem due to their wealth of experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“If this causes a delay it would also cause us to lose fa..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Wait = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait ..."*)

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“As per the report they have sent, to finish the railway on time, they realised more capital is necessary due to the new labour laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Symon Holl: "“We scheduled the construction to finish sooner but Tauru..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Absolutely not. I will not let a few strikers decide the future of our country.”"]** — Mówca: **Player**
> "“Absolutely not. I will not let a few strikers decide the future of our country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Gus Manger: "“I agree. If we let them change our laws on whim, this wi..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“You have a point.”"]** — Mówca: **Player**
> "“You have a point.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“He does but we can't just let anyone change our laws aft..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"]** — Mówca: **Player**
> "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“Exactly. This is the only way to stop this from happenin..."*)

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“I'm not sure about this but as you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[59]`
Mówca: **Gus Manger**
> "“Regardless, we might not have the choice if we want to finish this project on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“If we spend the extra amount they are requesting, we might miss other opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gus Manger: "“Regardless, we might not have the choice if we want to f..."*)

### Węzeł `[61]`
Mówca: **Gus Manger**
> "“I agree. If we let them change our laws on whim, this will lower the trust in our government and cause stability issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“Very well. Hopefully the backlash doesn't affect us too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“He does but we can't just let anyone change our laws after we sign them. What type of message does that send to the people? A weak government that backtracks on its decisions?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[64]`
Mówca: **Gus Manger**
> "“If this causes a delay it would also cause us to lose face in-front of the eyes of the public. Sinking more money into Taurus isn't ideal either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“I do not permit incompetence.”"*)
  - -> `[38]` (*Player: "“Why do they even need the extra money?”"*)
  - -> `[42]` (*Player: "“It's important that we finish this project on time. Mone..."*)

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“Exactly. This is the only way to stop this from happening again. Make an example of the strikers so that no one else attempts it again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gus Manger: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“So, anyone can change the laws of Sordland by organising a little strike. Respect for the state will be undermined.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gus Manger: "“On top of it, this will affect all the companies in Sord..."*)

### Węzeł `[67]`
Mówca: **Symon Holl**
> "“How should we handle the strikes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“We will begin the procedure to pass the vetoed Workers' ..."*)
  - -> `[46]` (*Player: "“I'm not worried. Let's just wait it out. They will stop ..."*)
  - -> `[44]` (*Player: "“Order Taurus Holding to replace the strikers with new wo..."*)

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“This is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 75);  // Updates token..."*)

### Węzeł `[69]`
Mówca: **Symon Holl**
> "“They should've seen this coming. If they didn't, which is the case, that's incompetency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[70]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gus Manger: "“It is unfortunate but construction can be disrupted when..."*)

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“On top of it, this will affect all the companies in Sordland causing them to pay extra money to their employees. This small matter shouldn't have affected the whole country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“I will certainly join you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_InT_Issue = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Give == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_TH_Give == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Give == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate =..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_TH_Give == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "The main purpose of our visit was to solve construction issues that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "The L-1 Railway construction created the perfect opportunity to visit the green technological nerve centre of Sordland. Dozens of electrical engineers from the city were part of the electrification upgrade of the rail track."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The main purpose of our visit was to solve construction i..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "The Gelsord Research Council was very reluctant to let us use their facilities as the rectors weren't at all pleased by the reduction of education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Symon looked a little more stressed than usual. Gus was a..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "The Gelsord Research Council was very willing to let us u..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The Gelsord Research Council was very reluctant to let us..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "The Gelsord Research Council let us use their facilities,..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Symon looked a little more stressed than usual. Gus was also here to find solutions. He eyed me for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "The Gelsord Research Council was very willing to let us use their facilities because the rectors were pleased by the increase of the education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Symon looked a little more stressed than usual. Gus was a..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "The Gelsord Research Council let us use their facilities, but the rectors weren't interested in our affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Symon looked a little more stressed than usual. Gus was a..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Gus Manger: "“Let's hope this will be enough to have a timely opening.”"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved = true"*)

### Węzeł `[92]`
Mówca: **Gus Manger**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like Underhall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Mistakes happen in any project.”"*)
  - -> `[94]` (*Player: "“Underhall is a better option indeed.”"*)
  - -> `[100]` (*Player: "“The SSC could be a partner.”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Gus Manger: "“True but we took an extra risk on this one. If something..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Underhall is a better option indeed.”"]** — Mówca: **Player**
> "“Underhall is a better option indeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Gus Manger: "“There are people I know in the management of Underhall. ..."*)

### Węzeł `[95]`
Mówca: **Gus Manger**
> "“True but we took an extra risk on this one. If something is too good to be true, it isn't. I had a bad feeling about the cheaper contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Gus Manger: "“The question is are we going to give Taurus the funds th..."*)

### Węzeł `[96]`
Mówca: **Gus Manger**
> "“There are people I know in the management of Underhall. They will be available for a second project in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Gus Manger: "“The question is are we going to give Taurus the funds th..."*)

### Węzeł `[97]`
Mówca: **Gus Manger**
> "“The question is are we going to give Taurus the funds they requested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Symon Holl: "“What is your decision, Mr. President?”"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Gus Manger: "“Let's see what happens. If we miss the deadlines the peo..."*)

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“Not the fossil of a company. If anybody will have timeline issues it is them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Gus Manger: "“The question is are we going to give Taurus the funds th..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“The SSC could be a partner.”"]** — Mówca: **Player**
> "“The SSC could be a partner.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Gus Manger: "“Not the fossil of a company. If anybody will have timeli..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign = true; BaseGameSupport.Journal_Turn04_WorkersRights_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign"] = true;
Variable["BaseGameSupport.Journal_Turn04_WorkersRights_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Vetoed = false; BaseGa..."*)

### Węzeł `[102]`
Mówca: **Gus Manger**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like Underhall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“Mistakes happen in any project.”"*)
  - -> `[104]` (*Player: "“Underhall is a better option indeed.”"*)
  - -> `[105]` (*Player: "“The SSC could be a partner.”"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Gus Manger: "“True but we took an extra risk on this one. If something..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Underhall is a better option indeed.”"]** — Mówca: **Player**
> "“Underhall is a better option indeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gus Manger: "“There are people I know in the management of Underhall. ..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“The SSC could be a partner.”"]** — Mówca: **Player**
> "“The SSC could be a partner.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gus Manger: "“Not the fossil of a company. If anybody will have timeli..."*)

### Węzeł `[106]`
Mówca: **Gus Manger**
> "“True but we took an extra risk on this one. If something is too good to be true, it isn't. I had a bad feeling about the cheaper contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Symon Holl: "“How should we handle the strikes?”"*)

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“There are people I know in the management of Underhall. They will be available for a second project in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Symon Holl: "“How should we handle the strikes?”"*)

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“Not the fossil of a company. If anybody will have timeline issues it is them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Symon Holl: "“How should we handle the strikes?”"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Vetoed = false; BaseGame.Bill_Turn04_WorkersRights_Signed = true;
BaseGame.Policy_Law_WorkersRightsReform = true; BaseGame.Situation_Welfare_ImprovedWorkingConditions = true; BaseGame.Situation_Economy_ExpensiveWorkersPayments = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Vetoed"] = false;
Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] = true;
Variable["BaseGame.Policy_Law_WorkersRightsReform"] = true;
Variable["BaseGame.Situation_Welfare_ImprovedWorkingConditions"] = true;
Variable["BaseGame.Situation_Economy_ExpensiveWorkersPayments"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Gus Manger: "“This is unfortunate.”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“Very well. Hopefully the backlash doesn't affect us too ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“Very well. Hopefully the backlash doesn't affect us too ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Symon Holl: "“I'm not sure about this but as you wish.”"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Gus Manger: "“So, anyone can change the laws of Sordland by organising..."*)

### Węzeł `[120]`
Mówca: **Symon Holl**
> "“As much as I hate to say it, I think passing the Workers' Rights bill might be our best bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: "“However, following the veto, we have ceased the implemen..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "We left the meeting room."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && ..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "We left the meeting room."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "We left the meeting room."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "We left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Symon nodded and we left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Symon nodded and we left the meeting room."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && Ba..."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && ..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Symon nodded and we left the meeting room."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon nodded and we left the meeting room."*)
