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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[32]` | **"“We could just wait it out until the strikers get tired.”"** | `[19]` **Lileas Graf**: "“I think you have the power to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Lileas Graf**: "“That is an option but I am not ..." |
| `[33]` | **"“Why don't we just do what they want and pass the Workers' Rights bill?”"** | `[19]` **Lileas Graf**: "“I think you have the power to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lileas Graf**: "“We can avoid many more strikes ..." |
| `[34]` | **"“We could replace the striking workers.”"** | `[19]` **Lileas Graf**: "“I think you have the power to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Lileas Graf**: "“We can't stand idle and we can'..." |
| `[43]` | **"“Absolutely not. I will not let a few strikers decide the future of our country.”"** | `[42]` **Symon Holl**: "“However, following the veto, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: "“I disagree. If we don't change ..." |
| `[44]` | **"“You have a point.”"** | `[42]` **Symon Holl**: "“However, following the veto, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lileas Graf**: "“A strong government can backtra..." |
| `[45]` | **"“We need to cut the head of the snake to truly stop this issue by replacing the st..."** | `[42]` **Symon Holl**: "“However, following the veto, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Lileas Graf**: "“Making an example of the strike..." |
| `[51]` | **"“We will begin the procedure to pass the vetoed Workers' Rights bill. [-2 Governme..."** | `[50]` **Symon Holl**: "“How should we handle the strikes?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true; Var...`<br>`Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>*(+2 skryptów)* | `[55]` **Lileas Graf**: "“Glad we made this choice.”" |
| `[52]` | **"“I'm not worried. Let's just wait it out. They will stop at one point and everythi..."** | `[50]` **Symon Holl**: "“How should we handle the strikes?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn04_Infrastructure_T...`<br>*(+1 skryptów)* | `[54]` **Symon Holl**: "“I'm not sure about this but as ..." |
| `[53]` | **"“Order Taurus Holding to replace the strikers with new workers. This should fix ou..."** | `[50]` **Symon Holl**: "“How should we handle the strikes?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn04_Infrastructure_T...`<br>*(+2 skryptów)* | `[57]` **Symon Holl**: "“Very well. Hopefully the backla..." |
| `[62]` | **"“Thank you everyone.”"** | `[61]` **Symon Holl**: "“Well then. Thank you for coming..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Symon nodded and we left the mee..." |
| `[63]` | **"“Let's enjoy the hospitality of the Mayor.”"** | `[61]` **Symon Holl**: "“Well then. Thank you for coming..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Symon Holl**: "“That, I'm intending to.”" |
| `[64]` | **"“Good night.”"** | `[61]` **Symon Holl**: "“Well then. Thank you for coming..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Symon nodded and we left the mee..." |
| `[69]` | **"“I do not permit incompetence.”"** | `[73]` **Lileas Graf**: "“Now they are requesting more fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lileas Graf**: "“None of us do and this is speci..." |
| `[70]` | **"“Why do they even need the extra money?”"** | `[73]` **Lileas Graf**: "“Now they are requesting more fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Symon Holl**: "“They need it for unforeseen exp..." |
| `[71]` | **"“It's important that we finish this project on time. Money is no matter.”"** | `[73]` **Lileas Graf**: "“Now they are requesting more fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Symon Holl**: "“If we spend the extra amount th..." |
| `[80]` | **"“Give them the additional funds.” [-1 Government Budget]"** | `[79]` **Symon Holl**: "“What is your decision, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Symon Holl**: "“As you wish. I will allocate th..." |
| `[81]` | **"“We don't have the funds to spare.”"** | `[79]` **Symon Holl**: "“What is your decision, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Symon Holl**: "“This will most likely cause a d..." |
| `[92]` | **"“Mistakes happen in any project.”"** | `[91]` **Lileas Graf**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lileas Graf**: "“Maybe but we could have avoided..." |
| `[93]` | **"“The SSC is a better option indeed.”"** | `[91]` **Lileas Graf**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lileas Graf**: "“Why even involve outsiders when..." |
| `[94]` | **"“Underhall could be a partner.”"** | `[91]` **Lileas Graf**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Lileas Graf**: "“I'm sceptical about another for..." |
| `[109]` | **"“Mistakes happen in any project.”"** | `[112]` **Lileas Graf**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Lileas Graf**: "“Maybe but we could have avoided..." |
| `[110]` | **"“The SSC is a better option indeed.”"** | `[112]` **Lileas Graf**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Lileas Graf**: "“Why even involve outsiders when..." |
| `[111]` | **"“Underhall could be a partner.”"** | `[112]` **Lileas Graf**: "“One thing is for certain, our a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Lileas Graf**: "“I'm sceptical about another for..." |

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
  - -> `[4]` (*Narrator: "The H-3 Highway construction created a second opportunity..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "But the main purpose of our visit was to resolve the strike that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The H-3 Highway construction created a second opportunity to visit the seaside town of Lenkurg known for its salmon. Thousands of people from the city were employed for construction work by the new highway project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "But the main purpose of our visit was to resolve the stri..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_InT_Issue = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The mayor welcomed us at his own mansion and praised us for our decision to extensively invest in the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == false"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The mayor welcomed us at his own mansion and praised us f..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The mayor welcomed us at his own mansion and took us on a..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The mayor welcomed us at his own mansion and took us on a brief tour in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "We gathered at the city hall. Symon looked a little worri..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "There also was a message of support from the mayor of Arvory, Eric Niel, who was grateful for the H-3 investments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "After dinner, we moved to a meeting room. Symon began."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "We gathered at the city hall. Symon looked a little worried but Lileas was dead serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "There also was a message of support from the mayor of Arv..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == false"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == fa..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Dozens of people were outside the mansion grounds and cha..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "We gathered at the city hall. Symon looked a little worri..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Dozens of people were outside the mansion grounds and chanting party slogans in a show of support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "We gathered at the city hall. Symon looked a little worri..."*)

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lileas Graf: "“The bill is necessary for this country. Our people need ..."*)

### Węzeł `[18]`
Mówca: **Lileas Graf**
> "“The bill is necessary for this country. Our people need to be compensated and have safety regulations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lileas Graf: "“I think you have the power to pass it which could help s..."*)

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“I think you have the power to pass it which could help solve the protests. Alternatively, we could wait it out and let them get back to work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“We could just wait it out until the strikers get tired.”"*)
  - -> `[33]` (*Player: "“Why don't we just do what they want and pass the Workers..."*)
  - -> `[34]` (*Player: "“We could replace the striking workers.”"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Give == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_TH_Give == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Give == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate =..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_TH_Give == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_TH_Give"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_WorkersRights_SignedLate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "After dinner, we moved to a meeting room. Symon began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“The strike that popped up at the construction site is causing issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Symon Holl: "“After the terrible Morbel mine disaster, workers have be..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Symon Holl: "“Taurus Holding has reached out to us and requested more ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: "“The strike that popped up at the construction site is ca..."*)

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“After the terrible Morbel mine disaster, workers have been on edge. Vetoing the Workers' Rights bill certainly did not help with the situation either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: "“Strikers primary demand is for the bill to be reinstated..."*)

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“Strikers primary demand is for the bill to be reinstated. We have to solve the issue or the construction will stay halted longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: "“We scheduled the construction to finish sooner but Tauru..."*)

### Węzeł `[31]`
Mówca: **Symon Holl**
> "“Taurus Holding has reached out to us and requested more funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Symon Holl: "“As per the report they have sent, to finish the highway ..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“We could just wait it out until the strikers get tired.”"]** — Mówca: **Player**
> "“We could just wait it out until the strikers get tired.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lileas Graf: "“That is an option but I am not sure how helpful it will ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Why don't we just do what they want and pass the Workers' Rights bill?”"]** — Mówca: **Player**
> "“Why don't we just do what they want and pass the Workers' Rights bill?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: "“We can avoid many more strikes if we show them that we c..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We could replace the striking workers.”"]** — Mówca: **Player**
> "“We could replace the striking workers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lileas Graf: "“We can't stand idle and we can't allow our stubbornness ..."*)

### Węzeł `[35]`
Mówca: **Lileas Graf**
> "“We can avoid many more strikes if we show them that we can adapt and change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Symon Holl: "“This could be the best choice to handle this swiftly.”"*)

### Węzeł `[36]`
Mówca: **Lileas Graf**
> "“That is an option but I am not sure how helpful it will be. Passing the bill will be respecting their demands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Symon Holl: "“I agree with Lileas. Doubt sitting idly will help in thi..."*)

### Węzeł `[37]`
Mówca: **Lileas Graf**
> "“We can't stand idle and we can't allow our stubbornness on laws to allow a few strikers to hold the construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Symon Holl: "“This will only serve to rile up the strikers even more. ..."*)

### Węzeł `[38]`
Mówca: **Symon Holl**
> "“I agree with Lileas. Doubt sitting idly will help in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Symon Holl: "“We need to show people that we can finish this project, ..."*)

### Węzeł `[39]`
Mówca: **Symon Holl**
> "“This could be the best choice to handle this swiftly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Symon Holl: "“We need to show people that we can finish this project, ..."*)

### Węzeł `[40]`
Mówca: **Symon Holl**
> "“This will only serve to rile up the strikers even more. We might end up with a bigger mess.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Symon Holl: "“We need to show people that we can finish this project, ..."*)

### Węzeł `[41]`
Mówca: **Symon Holl**
> "“We need to show people that we can finish this project, our first mega project, on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Symon Holl: "“As much as I hate to say it, I think passing the Workers..."*)

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“However, following the veto, we have ceased the implementation of the policy and disbanded the expert team, resulting in a potential increase in the cost of the bill if new teams are to be established.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“Absolutely not. I will not let a few strikers decide the..."*)
  - -> `[44]` (*Player: "“You have a point.”"*)
  - -> `[45]` (*Player: "“We need to cut the head of the snake to truly stop this ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Absolutely not. I will not let a few strikers decide the future of our country.”"]** — Mówca: **Player**
> "“Absolutely not. I will not let a few strikers decide the future of our country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: "“I disagree. If we don't change our laws, this will lower..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“You have a point.”"]** — Mówca: **Player**
> "“You have a point.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“A strong government can backtrack on its decisions and a..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"]** — Mówca: **Player**
> "“We need to cut the head of the snake to truly stop this issue by replacing the strikers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lileas Graf: "“Making an example of the strikers is wrong. We need to t..."*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“I disagree. If we don't change our laws, this will lower the trust in our government and cause stability issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lileas Graf: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“A strong government can backtrack on its decisions and accept it was wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lileas Graf: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“Making an example of the strikers is wrong. We need to tackle the root of the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lileas Graf: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“What is your decision then, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“How should we handle the strikes?”"*)

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“How should we handle the strikes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“We will begin the procedure to pass the vetoed Workers' ..."*)
  - -> `[52]` (*Player: "“I'm not worried. Let's just wait it out. They will stop ..."*)
  - -> `[53]` (*Player: "“Order Taurus Holding to replace the strikers with new wo..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“We will begin the procedure to pass the vetoed Workers' Rights bill. [-2 Government Budget]”"]** — Mówca: **Player**
> "“We will begin the procedure to pass the vetoed Workers' Rights bill.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give = true; BaseGame.Turn04..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"]** — Mówca: **Player**
> "“I'm not worried. Let's just wait it out. They will stop at one point and everything will be alright.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Wait = true"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"]** — Mówca: **Player**
> "“Order Taurus Holding to replace the strikers with new workers. This should fix our issue.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Replace = true"*)

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“I'm not sure about this but as you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“Glad we made this choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 75);  // Updates token..."*)

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“Respect for the state will increase. Standing by the people is the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Very well. Hopefully the backlash doesn't affect us too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Wait = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Wait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Replace = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Replace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusRepla..."*)

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“Regardless, the decision is made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Symon Holl: "“Well then. Thank you for coming. That is all on this mat..."*)

### Węzeł `[61]`
Mówca: **Symon Holl**
> "“Well then. Thank you for coming. That is all on this matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“Let's enjoy the hospitality of the Mayor.”"*)
  - -> `[62]` (*Player: "“Thank you everyone.”"*)
  - -> `[64]` (*Player: "“Good night.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Thank you everyone.”"]** — Mówca: **Player**
> "“Thank you everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Symon nodded and we left the meeting room."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Let's enjoy the hospitality of the Mayor.”"]** — Mówca: **Player**
> "“Let's enjoy the hospitality of the Mayor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Symon Holl: "“That, I'm intending to.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Good night.”"]** — Mówca: **Player**
> "“Good night.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Symon nodded and we left the meeting room."*)

### Węzeł `[65]`
Mówca: **Symon Holl**
> "“That, I'm intending to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "We left the meeting room."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Symon nodded and we left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "We left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Give == true"*)

### Węzeł `[68]`
Mówca: **Symon Holl**
> "“As per the report they have sent, to finish the highway on time, they realised more capital is necessary due to the new labour laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Symon Holl: "“We scheduled the construction to finish sooner but Tauru..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“I do not permit incompetence.”"]** — Mówca: **Player**
> "“I do not permit incompetence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lileas Graf: "“None of us do and this is specifically why there was a b..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Why do they even need the extra money?”"]** — Mówca: **Player**
> "“Why do they even need the extra money?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Symon Holl: "“They need it for unforeseen expenses that came from the ..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“It's important that we finish this project on time. Money is no matter.”"]** — Mówca: **Player**
> "“It's important that we finish this project on time. Money is no matter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Symon Holl: "“If we spend the extra amount they are requesting, we mig..."*)

### Węzeł `[72]`
Mówca: **Lileas Graf**
> "“This is unacceptable. I should have known that a cheaper offer wasn't technically possible. We wouldn't have this issue if you decided to go with SSC instead of Taurus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lileas Graf: "“Now they are requesting more funds to be able to cover t..."*)

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“Now they are requesting more funds to be able to cover the increased costs. If we don't provide we could face a delay which would endanger our reputation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "“I do not permit incompetence.”"*)
  - -> `[70]` (*Player: "“Why do they even need the extra money?”"*)
  - -> `[71]` (*Player: "“It's important that we finish this project on time. Mone..."*)

### Węzeł `[74]`
Mówca: **Symon Holl**
> "“If we spend the extra amount they are requesting, we might miss other opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“It's unfortunate that we were put in this spot. Do we re..."*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“It's unfortunate that we were put in this spot. Do we really have a choice here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lileas Graf: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“None of us do and this is specifically why there was a brief about each companies and the potential issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Symon Holl: "“No point to delve in the past now.”"*)

### Węzeł `[77]`
Mówca: **Symon Holl**
> "“They need it for unforeseen expenses that came from the new Workers' Rights Bill. A couple of shipment companies they had contract with also increased costs on the necessary materials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“The state must have more control over these construction..."*)

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“The state must have more control over these construction projects. For the next project we should appoint a direct manager from the cabinet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lileas Graf: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[79]`
Mówca: **Symon Holl**
> "“What is your decision, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“Give them the additional funds.” [-1 Government Budget]"*)
  - -> `[81]` (*Player: "“We don't have the funds to spare.”"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Give them the additional funds.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give them the additional funds.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Symon Holl: "“As you wish. I will allocate the funding to Taurus Holdi..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“We don't have the funds to spare.”"]** — Mówca: **Player**
> "“We don't have the funds to spare.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Symon Holl: "“This will most likely cause a delay but Taurus Holding w..."*)

### Węzeł `[82]`
Mówca: **Symon Holl**
> "“As you wish. I will allocate the funding to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_TH_Money = true; BaseGameSuppor..."*)

### Węzeł `[83]`
Mówca: **Symon Holl**
> "“This will most likely cause a delay but Taurus Holding will be informed immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFun..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“First they fail to do their job properly, then they get the money. Ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 75);  // Updates token..."*)

### Węzeł `[86]`
Mówca: **Symon Holl**
> "“We scheduled the construction to finish sooner but Taurus Holding might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lileas Graf: "“This is unacceptable. I should have known that a cheaper..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lileas Graf: "“First they fail to do their job properly, then they get ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved = true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusNoFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lileas Graf: "“I have no expectations of hitting that opening deadline ..."*)

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“No point to delve in the past now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lileas Graf: "“One thing is for certain, our administration must avoid ..."*)

### Węzeł `[91]`
Mówca: **Lileas Graf**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "“Mistakes happen in any project.”"*)
  - -> `[93]` (*Player: "“The SSC is a better option indeed.”"*)
  - -> `[94]` (*Player: "“Underhall could be a partner.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lileas Graf: "“Maybe but we could have avoided this issue. There were w..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“The SSC is a better option indeed.”"]** — Mówca: **Player**
> "“The SSC is a better option indeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lileas Graf: "“Why even involve outsiders when we have our own corporat..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Underhall could be a partner.”"]** — Mówca: **Player**
> "“Underhall could be a partner.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lileas Graf: "“I'm sceptical about another for profit company after Tau..."*)

### Węzeł `[95]`
Mówca: **Lileas Graf**
> "“Maybe but we could have avoided this issue. There were warning signs around Taurus all along.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lileas Graf: "“Will we sink more money into this or let them figure it ..."*)

### Węzeł `[96]`
Mówca: **Lileas Graf**
> "“Why even involve outsiders when we have our own corporation to get things done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lileas Graf: "“Will we sink more money into this or let them figure it ..."*)

### Węzeł `[97]`
Mówca: **Lileas Graf**
> "“I'm sceptical about another for profit company after Taurus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lileas Graf: "“Will we sink more money into this or let them figure it ..."*)

### Węzeł `[98]`
Mówca: **Lileas Graf**
> "“Will we sink more money into this or let them figure it out?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Symon Holl: "“What is your decision, Mr. President?”"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusWait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“I have no expectations of hitting that opening deadline at this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Vetoed = false; BaseGame.Bill_Turn04_WorkersRights_Signed = true;
BaseGame.Policy_Law_WorkersRightsReform = true; BaseGame.Situation_Welfare_ImprovedWorkingConditions = true; BaseGame.Situation_Economy_ExpensiveWorkersPayments = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Vetoed"] = false;
Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] = true;
Variable["BaseGame.Policy_Law_WorkersRightsReform"] = true;
Variable["BaseGame.Situation_Welfare_ImprovedWorkingConditions"] = true;
Variable["BaseGame.Situation_Economy_ExpensiveWorkersPayments"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lileas Graf: "“Glad we made this choice.”"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign = true; BaseGameSupport.Journal_Turn04_WorkersRights_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Infrastructure_TaurusSign"] = true;
Variable["BaseGameSupport.Journal_Turn04_WorkersRights_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Vetoed = false; BaseGa..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_TH_Give = true; BaseGame.Turn04_InT_HighwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_TH_Give"] = true;
Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2"*)

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“I'm sceptical about another for profit company after Taurus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“What is your decision then, Mr. President?”"*)

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“Why even involve outsiders when we have our own corporation to get things done?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“What is your decision then, Mr. President?”"*)

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Maybe but we could have avoided this issue. There were warning signs around Taurus all along.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“What is your decision then, Mr. President?”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Mistakes happen in any project.”"]** — Mówca: **Player**
> "“Mistakes happen in any project.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“Maybe but we could have avoided this issue. There were w..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“The SSC is a better option indeed.”"]** — Mówca: **Player**
> "“The SSC is a better option indeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lileas Graf: "“Why even involve outsiders when we have our own corporat..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Underhall could be a partner.”"]** — Mówca: **Player**
> "“Underhall could be a partner.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lileas Graf: "“I'm sceptical about another for profit company after Tau..."*)

### Węzeł `[112]`
Mówca: **Lileas Graf**
> "“One thing is for certain, our administration must avoid working with Taurus in the future and opt for safe choices like SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“Mistakes happen in any project.”"*)
  - -> `[110]` (*Player: "“The SSC is a better option indeed.”"*)
  - -> `[111]` (*Player: "“Underhall could be a partner.”"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Symon Holl: "“I'm not sure about this but as you wish.”"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Symon Holl: "“Very well. Hopefully the backlash doesn't affect us too ..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Symon Holl: "“Very well. Hopefully the backlash doesn't affect us too ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: "“Respect for the state will increase. Standing by the peo..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“Regardless, the decision is made.”"*)

### Węzeł `[121]`
Mówca: **Symon Holl**
> "“As much as I hate to say it, I think passing the Workers' Rights bill might be our best bet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Symon Holl: "“However, following the veto, we have ceased the implemen..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
