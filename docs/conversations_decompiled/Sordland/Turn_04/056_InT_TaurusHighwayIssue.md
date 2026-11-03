# Sordland/Turn04/InT_TaurusHighwayIssue

- **ID konwersacji:** `56`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/056_InT_TaurusHighwayIssue.md`
- **Liczba węzłów dialogowych:** 123
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn04_InT_Issue_TH_Give`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Bill_Turn04_WorkersRights_Vetoed`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Law_WorkersRightsReform`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Economy_ExpensiveWorkersPayments`
- `BaseGame.Situation_Welfare_ImprovedWorkingConditions`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_Issue_TH_Give`
- `BaseGame.Turn04_InT_Issue_TH_Money`
- `BaseGame.Turn04_InT_Issue_TH_Replace`
- `BaseGame.Turn04_InT_Issue_TH_Wait`
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
- Węzeł `[5]` (Symon Holl): `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- Węzeł `[23]` (Symon Holl): `Variable["BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate"] = true;`
- Węzeł `[58]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`
- Węzeł `[59]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`
- Węzeł `[84]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_TH_Money"] = true; Variable["BaseGameSupport.Journal_Turn04_I...`
- Węzeł `[87]` (Symon Holl): `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- Węzeł `[88]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- Węzeł `[89]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds"] = true;`
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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "But the main purpose of our visit was to resolve the strike that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The H-3 Highway construction created a second opportunity to visit the seaside town of Lenkurg known for its salmon. Thousands of people from the city were employed for construction work by the new highway project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_InT_Issue = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The mayor welcomed us at his own mansion and praised us for our decision to extensively invest in the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The mayor welcomed us at his own mansion and took us on a brief tour in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "There also was a message of support from the mayor of Arvory, Eric Niel, who was grateful for the H-3 investments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[12]`
Mówca: **Narrator**
> "We gathered at the city hall. Symon looked a little worried but Lileas was dead serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[13]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Dozens of people were outside the mansion grounds and chanting party slogans in a show of support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lileas Graf**
> "“The bill is necessary for this country. Our people need to be compensated and have safety regulations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“I think you have the power to pass it which could help solve the protests. Alternatively, we could wait it out and let them get back to work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[20]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Give == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Give == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_TH_Give == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[24]`
Mówca: **Narrator**
> "After dinner, we moved to a meeting room. Symon began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“The strike that popped up at the construction site is causing issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“After the terrible Morbel mine disaster, workers have been on edge. Vetoing the Workers' Rights bill certainly did not help with the situation either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“Strikers primary demand is for the bill to be reinstated. We have to solve the issue or the construction will stay halted longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[31]`
Mówca: **Symon Holl**
> "“Taurus Holding has reached out to us and requested more funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“We could just wait it out until the strikers get tired.”"]** — Mówca: **Player**
> "“We could just wait it out until the strikers get tired.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Why don't we just do what they want and pass the Workers' Rights bill?”"]** — Mówca: **Player**
> "“Why don't we just do what they want and pass the Workers' Rights bill?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We could replace the striking workers.”"]** — Mówca: **Player**
> "“We could replace the striking workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Lileas Graf**
> "“We can avoid many more strikes if we show them that we can adapt and change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Lileas Graf**
> "“That is an option but I am not sure how helpful it will be. Passing the bill will be respecting their demands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Lileas Graf**
> "“We can't stand idle and we can't allow our stubbornness on laws to allow a few strikers to hold the construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Symon Holl**
> "“I agree with Lileas. Doubt sitting idly will help in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Symon Holl**
> "“This could be the best choice to handle this swiftly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“This will only serve to rile up the strikers even more. We might end up with a bigger mess.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Symon Holl**
> "“We need to show people that we can finish this project, our first mega project, on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“However, following the veto, we have ceased the implementation of the policy and disbanded the expert team, resulting in a potential increase in the cost of the bill if new teams are to be established.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Absolutely not. I will not let a few strikers decide the future of our country.”"]** — Mówca: **Player**
> "“Absolutely not. I will not let a few strikers decide the future of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“You have a point.”"]** — Mówca: **Player**
> "“You have a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"]** — Mówca: **Player**
> "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“I disagree. If we don't change our laws, this will lower the trust in our government and cause stability issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“A strong government can backtrack on its decisions and accept it was wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“Making an example of the strikers is wrong. We need to tackle the root of the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“What is your decision then, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“How should we handle the strikes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“We will begin the procedure to pass the vetoed Workers' Rights bill. [-2 Government Budget]”"]** — Mówca: **Player**
> "“We will begin the procedure to pass the vetoed Workers' Rights bill.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"]** — Mówca: **Player**
> "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"]** — Mówca: **Player**
> "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“I'm not sure about this but as you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“Glad we made this choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“Respect for the state will increase. Standing by the people is the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Very well. Hopefully the backlash doesn't affect us too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Wait = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[59]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Replace = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“Regardless, the decision is made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“Well then. Thank you for coming. That is all on this matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[62]`
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Thank you everyone.”"]** — Mówca: **Player**
> "“Thank you everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Let's enjoy the hospitality of the Mayor.”"]** — Mówca: **Player**
> "“Let's enjoy the hospitality of the Mayor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Good night.”"]** — Mówca: **Player**
> "“Good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Symon Holl**
> "“That, I'm intending to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Symon nodded and we left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[67]`
Mówca: **Narrator**
> "We left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[68]`
Mówca: **Symon Holl**
> "“As per the report they have sent, to finish the highway on time, they realised more capital is necessary due to the new labour laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“I do not permit incompetence.”"]** — Mówca: **Player**
> "“I do not permit incompetence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Why do they even need the extra money?”"]** — Mówca: **Player**
> "“Why do they even need the extra money?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“It's important that we finish this project on time. Money is no matter.”"]** — Mówca: **Player**
> "“It's important that we finish this project on time. Money is no matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Lileas Graf**
> "“This is unacceptable. I should have known that a cheaper offer wasn't technically possible. We wouldn't have this issue if you decided to go with SSC instead of Taurus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“Now they are requesting more funds to be able to cover the increased costs. If we don't provide we could face a delay which would endanger our reputation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[74]`
Mówca: **Symon Holl**
> "“If we spend the extra amount they are requesting, we might miss other opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“It's unfortunate that we were put in this spot. Do we really have a choice here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“None of us do and this is specifically why there was a brief about each companies and the potential issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[77]`
Mówca: **Symon Holl**
> "“They need it for unforeseen expenses that came from the new Workers' Rights Bill. A couple of shipment companies they had contract with also increased costs on the necessary materials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“The state must have more control over these construction projects. For the next project we should appoint a direct manager from the cabinet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[79]`
Mówca: **Symon Holl**
> "“What is your decision, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Give them the additional funds.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give them the additional funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“We don't have the funds to spare.”"]** — Mówca: **Player**
> "“We don't have the funds to spare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Symon Holl**
> "“As you wish. I will allocate the funding to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Symon Holl**
> "“This will most likely cause a delay but Taurus Holding will be informed immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“First they fail to do their job properly, then they get the money. Ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[86]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[87]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“No point to delve in the past now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Lileas Graf**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“The SSC is a better option indeed.”"]** — Mówca: **Player**
> "“The SSC is a better option indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Underhall could be a partner.”"]** — Mówca: **Player**
> "“Underhall could be a partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Lileas Graf**
> "“Maybe but we could have avoided this issue. There were warning signs around Taurus all along.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Lileas Graf**
> "“Why even involve outsiders when we have our own corporation to get things done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Lileas Graf**
> "“I'm sceptical about another for profit company after Taurus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Lileas Graf**
> "“Will we sink more money into this or let them figure it out?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[99]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[100]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“I have no expectations of hitting that opening deadline at this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[102]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Vetoed = false; BaseGame.Bill_Turn04_WorkersRights_Signed = true;
BaseGame.Policy_Law_WorkersRightsReform = true; BaseGame.Situation_Welfare_ImprovedWorkingConditions = true; BaseGame.Situation_Economy_ExpensiveWorkersPayments = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Vetoed"] = false;
Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] = true;
Variable["BaseGame.Policy_Law_WorkersRightsReform"] = true;
Variable["BaseGame.Situation_Welfare_ImprovedWorkingConditions"] = true;
Variable["BaseGame.Situation_Economy_ExpensiveWorkersPayments"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[103]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign = true; BaseGameSupport.Journal_Turn04_WorkersRights_Signed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign"] = true;
Variable["BaseGameSupport.Journal_Turn04_WorkersRights_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[105]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_TH_Give = true; BaseGame.Turn04_InT_HighwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true;
Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“I'm sceptical about another for profit company after Taurus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“Why even involve outsiders when we have our own corporation to get things done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Maybe but we could have avoided this issue. There were warning signs around Taurus all along.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“The SSC is a better option indeed.”"]** — Mówca: **Player**
> "“The SSC is a better option indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Underhall could be a partner.”"]** — Mówca: **Player**
> "“Underhall could be a partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[112]`
Mówca: **Lileas Graf**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[114]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[115]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[119]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[120]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[121]`
Mówca: **Symon Holl**
> "“As much as I hate to say it, I think passing the Workers' Rights bill might be our best bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[122]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
