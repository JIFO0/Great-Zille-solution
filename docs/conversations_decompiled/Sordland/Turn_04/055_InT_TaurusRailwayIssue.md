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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.GovernmentBudget`
- `BaseGame.Situation_Economy_ExpensiveWorkersPayments`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[10]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- Węzeł `[16]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Money"] = true; Variable["BaseGameSupport.Journal_Turn04_I...`
- Węzeł `[28]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`
- Węzeł `[48]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true; Variable["BaseGame.Turn04_InT_RailwayIssue_...`
- Węzeł `[53]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`
- Węzeł `[73]` (Symon Holl): `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- Węzeł `[77]` (Symon Holl): `Variable["BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate"] = true;`
- Węzeł `[90]` (Symon Holl): `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- *...oraz 12 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
> "“Even though I agree with your point Gus, this could be the best choice to handle this discreetly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Gus Manger**
> "“I don't support that bill just like you Mr. President. The reason is simple, I know it will cause issues with corporations and result in increased employee costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Gus Manger**
> "“There is little point in passing that bill late. Maybe the best way out of this is replacing the workers on strike.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[7]`
Mówca: **Gus Manger**
> "“Rather than incompetence, according to their report, their expenses increased drastically due to the new bill increasing workers costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Good night.”"]** — Mówca: **Player**
> "“Good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“However, following the veto, we have ceased the implementation of the policy and disbanded the expert team, resulting in a potential increase in the cost of the bill if new teams are to be established.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[10]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[11]`
Mówca: **Gus Manger**
> "“Let's see what happens. If we miss the deadlines the people will lose faith in our capabilities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Let's enjoy the hospitality of the Mayor.”"]** — Mówca: **Player**
> "“Let's enjoy the hospitality of the Mayor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“I doubt sitting idly will help in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[14]`
Mówca: **Gus Manger**
> "“Let's hope this will be enough to have a timely opening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Thank you everyone.”"]** — Mówca: **Player**
> "“Thank you everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[16]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I do not permit incompetence.”"]** — Mówca: **Player**
> "“I do not permit incompetence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“This will most likely cause a delay but Taurus Holding will be informed immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Well then. Thank you for coming. That is all on this matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[15]`
  - -> `[8]`

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“As you wish. I will allocate the funding to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“The strike that popped up at the construction site is causing issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“After the terrible Morbel mine disaster, workers have been on edge. Vetoing the Workers' Rights bill certainly did not help with the situation either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Symon Holl**
> "“That, I'm intending to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Strikers primary demand is for the bill to be reinstated. We have to solve the issue or the construction will stay halted longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Replace = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“We don't have the funds to spare.”"]** — Mówca: **Player**
> "“We don't have the funds to spare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Give them the additional funds.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give them the additional funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[31]`
Mówca: **Symon Holl**
> "“Taurus Holding has reached out to us and requested more funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Symon nodded and we left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“Regardless, the decision is made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We could just wait it out until the strikers get tired.”"]** — Mówca: **Player**
> "“We could just wait it out until the strikers get tired.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Why don't we just do what they want and pass the Workers' Rights bill?”"]** — Mówca: **Player**
> "“Why don't we just do what they want and pass the Workers' Rights bill?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Indeed we could just replace the striking workers.”"]** — Mówca: **Player**
> "“Indeed we could just replace the striking workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Symon Holl**
> "“This will only serve to rile up the strikers even more. We might end up with a bigger mess.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Why do they even need the extra money?”"]** — Mówca: **Player**
> "“Why do they even need the extra money?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“And give in to the rabble? How many more strikes are going to create if we show them that they can change what the state has already decided on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“What is your decision, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[29]`

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“This could work. I bet they will get tired after some time and go back to their jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“It's important that we finish this project on time. Money is no matter.”"]** — Mówca: **Player**
> "“It's important that we finish this project on time. Money is no matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[43]`
Mówca: **Gus Manger**
> "“I think this is our best bet. We can't stand idle and we can't allow a few strikers to change the laws of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"]** — Mówca: **Player**
> "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[45]`
Mówca: **Narrator**
> "We left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"]** — Mówca: **Player**
> "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“Realities of running a business is to be able to adapt to changing circumstances. The most important thing here is to finish the project on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Give = true; BaseGame.Turn04_InT_RailwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true;
Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“We will begin the procedure to pass the vetoed Workers' Rights bill. [-2 Government Budget]”"]** — Mówca: **Player**
> "“We will begin the procedure to pass the vetoed Workers' Rights bill.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“We need to show people that we can finish this project, our first mega project, on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“They need it for unforeseen expenses that came from the new Workers' Rights Bill. A couple of shipment companies they had contracts with also increased costs on the necessary materials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“It is unfortunate but construction can be disrupted when costs change dramatically. I knew that something was wrong when they offered the contract for cheaper. Underhall wouldn't have had this problem due to their wealth of experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[53]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Wait = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“As per the report they have sent, to finish the railway on time, they realised more capital is necessary due to the new labour laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Absolutely not. I will not let a few strikers decide the future of our country.”"]** — Mówca: **Player**
> "“Absolutely not. I will not let a few strikers decide the future of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“You have a point.”"]** — Mówca: **Player**
> "“You have a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"]** — Mówca: **Player**
> "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“I'm not sure about this but as you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[59]`
Mówca: **Gus Manger**
> "“Regardless, we might not have the choice if we want to finish this project on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“If we spend the extra amount they are requesting, we might miss other opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Gus Manger**
> "“I agree. If we let them change our laws on whim, this will lower the trust in our government and cause stability issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“Very well. Hopefully the backlash doesn't affect us too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“He does but we can't just let anyone change our laws after we sign them. What type of message does that send to the people? A weak government that backtracks on its decisions?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[64]`
Mówca: **Gus Manger**
> "“If this causes a delay it would also cause us to lose face in-front of the eyes of the public. Sinking more money into Taurus isn't ideal either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[38]`
  - -> `[42]`

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“Exactly. This is the only way to stop this from happening again. Make an example of the strikers so that no one else attempts it again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“So, anyone can change the laws of Sordland by organising a little strike. Respect for the state will be undermined.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
Mówca: **Symon Holl**
> "“How should we handle the strikes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[46]`
  - -> `[44]`

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“This is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[69]`
Mówca: **Symon Holl**
> "“They should've seen this coming. If they didn't, which is the case, that's incompetency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[70]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“On top of it, this will affect all the companies in Sordland causing them to pay extra money to their employees. This small matter shouldn't have affected the whole country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“I will certainly join you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[73]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_InT_Issue = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[74]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Give == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Give == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_TH_Give == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
Mówca: **Narrator**
> "The main purpose of our visit was to solve construction issues that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Narrator**
> "The L-1 Railway construction created the perfect opportunity to visit the green technological nerve centre of Sordland. Dozens of electrical engineers from the city were part of the electrification upgrade of the rail track."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Narrator**
> "The Gelsord Research Council was very reluctant to let us use their facilities as the rectors weren't at all pleased by the reduction of education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[86]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Symon looked a little more stressed than usual. Gus was also here to find solutions. He eyed me for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[88]`
Mówca: **Narrator**
> "The Gelsord Research Council was very willing to let us use their facilities because the rectors were pleased by the increase of the education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Narrator**
> "The Gelsord Research Council let us use their facilities, but the rectors weren't interested in our affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[90]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[91]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[92]`
Mówca: **Gus Manger**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like Underhall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[100]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Underhall is a better option indeed.”"]** — Mówca: **Player**
> "“Underhall is a better option indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Gus Manger**
> "“True but we took an extra risk on this one. If something is too good to be true, it isn't. I had a bad feeling about the cheaper contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Gus Manger**
> "“There are people I know in the management of Underhall. They will be available for a second project in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Gus Manger**
> "“The question is are we going to give Taurus the funds they requested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[98]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“Not the fossil of a company. If anybody will have timeline issues it is them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“The SSC could be a partner.”"]** — Mówca: **Player**
> "“The SSC could be a partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign = true; BaseGameSupport.Journal_Turn04_WorkersRights_Signed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign"] = true;
Variable["BaseGameSupport.Journal_Turn04_WorkersRights_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[102]`
Mówca: **Gus Manger**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like Underhall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Underhall is a better option indeed.”"]** — Mówca: **Player**
> "“Underhall is a better option indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“The SSC could be a partner.”"]** — Mówca: **Player**
> "“The SSC could be a partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Gus Manger**
> "“True but we took an extra risk on this one. If something is too good to be true, it isn't. I had a bad feeling about the cheaper contract.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“There are people I know in the management of Underhall. They will be available for a second project in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“Not the fossil of a company. If anybody will have timeline issues it is them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[109]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Vetoed = false; BaseGame.Bill_Turn04_WorkersRights_Signed = true;
BaseGame.Policy_Law_WorkersRightsReform = true; BaseGame.Situation_Welfare_ImprovedWorkingConditions = true; BaseGame.Situation_Economy_ExpensiveWorkersPayments = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Vetoed"] = false;
Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] = true;
Variable["BaseGame.Policy_Law_WorkersRightsReform"] = true;
Variable["BaseGame.Situation_Welfare_ImprovedWorkingConditions"] = true;
Variable["BaseGame.Situation_Economy_ExpensiveWorkersPayments"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[110]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[111]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[113]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[117]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[118]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[119]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[120]`
Mówca: **Symon Holl**
> "“As much as I hate to say it, I think passing the Workers' Rights bill might be our best bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[121]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[128]`
Mówca: **Narrator**
> "We left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Symon nodded and we left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[130]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[132]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Education == true && BaseGame.Turn03_EnT_Education_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Vetoed == true && BaseGame.Promise_TermFocus_Health == true && BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true && BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Vetoed"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true  and  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
