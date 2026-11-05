# Sordland/Turn04/InT_SSCHighwayIssue

- **ID konwersacji:** `50`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/050_InT_SSCHighwayIssue.md`
- **Liczba węzłów dialogowych:** 96
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn04_InT_Issue_SSC_Replace`
- `BaseGame.Turn04_InT_Issue_SSC_Warn`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.GovernmentBudget`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_Issue_SSC_Money`
- `BaseGame.Turn04_InT_Issue_SSC_Replace`
- `BaseGame.Turn04_InT_Issue_SSC_Warn`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning`
- `BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway`
- `BaseGameSupport.Report_Turn04_Holsord_SSCPromised`
- `BaseGameSupport.Report_Turn04_Holsord_SSCReplaced`
- `GameCondition.Turn04_InT_Issue`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **"“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"** | `[32]` **Lileas Graf**: "“It is very important that we cr..."<br>`[47]` **Lileas Graf**: "“I disagree completely. The SSC ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lileas Graf**: "“Why would they? The SSC respect..." |
| `[29]` | **"“Give more money to the construction managers so they can hire more workers and bu..."** | `[22]` **Lileas Graf**: "“With more resources the manager..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true; V...` | `[18]` **Symon Holl**: "“This extra investment could be ..." |
| `[30]` | **"“Replace the construction managers with more competent people to ensure the deadli..."** | `[22]` **Lileas Graf**: "“With more resources the manager..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true;...` | `[44]` **Symon Holl**: "“It's good to see that failure i..." |
| `[31]` | **"“Warn the construction managers. Send a formal warning from the Ministry of Econom..."** | `[22]` **Lileas Graf**: "“With more resources the manager..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true; Va...` | `[60]` **Symon Holl**: "“The warning will hopefully have..." |
| `[36]` | **"“It might even be necessary for us to hit the opening date.”"** | `[34]` **Symon Holl**: "“A cash injection would increase..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lileas Graf**: "“If we make the opening ceremony..." |
| `[38]` | **"“There is also the chance that the money could be wasted. We already spent so much..."** | `[34]` **Symon Holl**: "“A cash injection would increase..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Symon Holl**: "“I can only hope that they handl..." |
| `[39]` | **"“Giving them a serious warning could be the solution. A slap on the wrist can do w..."** | `[32]` **Lileas Graf**: "“It is very important that we cr..."<br>`[34]` **Symon Holl**: "“A cash injection would increase..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Symon Holl**: "“There is a good chance that the..." |
| `[41]` | **"“Officially warning them is a possibility but isn't tangible, we need action.”"** | `[32]` **Lileas Graf**: "“It is very important that we cr..."<br>`[47]` **Lileas Graf**: "“I disagree completely. The SSC ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Lileas Graf**: "“The state warning the state doe..." |
| `[48]` | **"“Finding competent managers could work. New blood can move things back on track.”"** | `[47]` **Lileas Graf**: "“I disagree completely. The SSC ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Symon Holl**: "“We have a lot of talented const..." |
| `[51]` | **"“The SSC might need more resources to speed things up. That deadline must be met.”"** | `[56]` **Lileas Graf**: "“But with that comes other issue..."<br>`[67]` **Symon Holl**: "“Either way we need them to solv..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lileas Graf**: "“I stand in agreement. The const..." |
| `[53]` | **"“We can't let mismanagement delay the project. It is unacceptable.”"** | `[56]` **Lileas Graf**: "“But with that comes other issue..."<br>`[67]` **Symon Holl**: "“Either way we need them to solv..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Symon Holl**: "“Couldn't agree more. This shoul..." |
| `[55]` | **"“The managers should be fired. This is unacceptable.”"** | `[56]` **Lileas Graf**: "“But with that comes other issue..."<br>`[67]` **Symon Holl**: "“Either way we need them to solv..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Symon Holl**: "“It would be a drastic measure b..." |
| `[57]` | **"“I trust that the SSC will accomplish it in time.”"** | `[54]` **Lileas Graf**: "“The SSC is an organisation of p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lileas Graf**: "“I think so too but maybe we sho..." |
| `[58]` | **"“How can we get the construction back on schedule?”"** | `[54]` **Lileas Graf**: "“The SSC is an organisation of p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Symon Holl**: "“That is the million ren questio..." |
| `[64]` | **"“I don't care about principles, our agreed opening dates must be met.”"** | `[54]` **Lileas Graf**: "“The SSC is an organisation of p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lileas Graf**: "“We shouldn't be risking lives, ..." |
| `[65]` | **"“This doesn't raise confidence at all. Maybe we shouldn't have picked the SSC.”"** | `[54]` **Lileas Graf**: "“The SSC is an organisation of p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: "“You see that the likes of Under..." |

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
> "But the main purpose of our visit was to solve construction issues that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The H-3 Highway construction created a second opportunity to visit the seaside town of Lenkurg known for its salmon. Thousands of people from the city were employed for construction work by the new highway project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "But the main purpose of our visit was to solve constructi..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "There also was a message of support from the mayor of Arvory, Eric Niel, who was grateful for the H-3 investments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“I have concerns about the construction due to progress b..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The mayor welcomed us to his own mansion and praised us f..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "We first met with the mayor and took a brief tour in the ..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The mayor welcomed us to his own mansion and praised us for our decision to extensively invest in the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == false"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "We first met with the mayor and took a brief tour in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Afterwards, we gathered at the city hall. Symon had a wor..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The meeting ended. The three of us went to the beach of Lenkurg. It was rather rocky, but very pristine. The sunset looked absolutely astonishing over the Markian Sea."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The day-long visit ended with a dinner involving the most..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The day-long visit ended with a dinner involving the most important people in the city. Many of them were bureaucrats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Later, we made our way back to Holsord."*)

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“That should be it. Good that we have figured out a way to move the process forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The meeting ended. The three of us went to the beach of L..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Later, we made our way back to Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Replace == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_InT_Issue = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Afterwards, we gathered at the city hall. Symon had a worried look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "There also was a message of support from the mayor of Arv..."*)

### Węzeł `[17]`
Mówca: **Lileas Graf**
> "“Trust me Mr. President this is the best investment we could have done. The SSC will only grow and learn from this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 75);  // Updates token..."*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“This extra investment could be just enough to get things back on track. However, it is unfortunate we had to spend more because we need it elsewhere too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“I'm not so sure what a warning can do to the situation on the ground. The managers already have many issues to tackle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“That should be it. Good that we have figured out a way t..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"]** — Mówca: **Player**
> "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lileas Graf), `[47]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“Why would they? The SSC respects the authorities fully. ..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Symon took a deep breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Symon Holl: "“One way or another we have to solve this issue. This can..."*)

### Węzeł `[22]`
Mówca: **Lileas Graf**
> "“With more resources the managers are more likely to hit the deadline. Any other action just hurts Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“Give more money to the construction managers so they can..."*)
  - -> `[31]` (*Player: "“Warn the construction managers. Send a formal warning fr..."*)
  - -> `[30]` (*Player: "“Replace the construction managers with more competent pe..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: "“This extra investment could be just enough to get things..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Warn = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“The warning will hopefully have a positive result to the..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Replace = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Symon Holl: "“It's good to see that failure isn't rewarded and punishe..."*)

### Węzeł `[26]`
Mówca: **Lileas Graf**
> "“This was a bad decision. This hurts the honorable SSC more than anything and will hamper our efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“That should be it. Good that we have figured out a way t..."*)

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Couldn't agree more. This shouldn't keep going on any longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lileas Graf: "“It is very important that we create jobs for our own cit..."*)

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“I stand in agreement. The construction speed can recover if they expand the workforce and buy new machinery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Symon Holl: "“A cash injection would increase the project costs even f..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Money = true; BaseGameSuppo..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Replace the construction managers with more competent people to ensure the deadline is hit.”"]** — Mówca: **Player**
> "“Replace the construction managers with more competent people to ensure the deadline is hit.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Replace = true; BaseGameSup..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"]** — Mówca: **Player**
> "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Warn = true; BaseGameSuppor..."*)

### Węzeł `[32]`
Mówca: **Lileas Graf**
> "“It is very important that we create jobs for our own citizens who are unemployed rather than foreigners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“Giving them a serious warning could be the solution. A s..."*)
  - -> `[41]` (*Player: "“Officially warning them is a possibility but isn't tangi..."*)
  - -> `[20]` (*Player: "“The state owns the SSC. They can't retaliate and bite of..."*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“We can either give the construction managers money, warn them or replace them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lileas Graf: "“With more resources the managers are more likely to hit ..."*)

### Węzeł `[34]`
Mówca: **Symon Holl**
> "“A cash injection would increase the project costs even further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“It might even be necessary for us to hit the opening date.”"*)
  - -> `[38]` (*Player: "“There is also the chance that the money could be wasted...."*)
  - -> `[39]` (*Player: "“Giving them a serious warning could be the solution. A s..."*)

### Węzeł `[35]`
Mówca: **Symon Holl**
> "“One way or another we have to solve this issue. This can lead to real complications down the line otherwise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“We can either give the construction managers money, warn..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“It might even be necessary for us to hit the opening date.”"]** — Mówca: **Player**
> "“It might even be necessary for us to hit the opening date.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lileas Graf: "“If we make the opening ceremony on time the public will ..."*)

### Węzeł `[37]`
Mówca: **Symon Holl**
> "“There is a good chance that they will take it far more seriously and take measures to increase speed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"]** — Mówca: **Player**
> "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Symon Holl: "“I can only hope that they handle the money well if they ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"]** — Mówca: **Player**
> "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lileas Graf), `[34]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Symon Holl: "“There is a good chance that they will take it far more s..."*)

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“The state warning the state doesn't make any sense at all anyway. Their reasons are just.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Officially warning them is a possibility but isn't tangible, we need action.”"]** — Mówca: **Player**
> "“Officially warning them is a possibility but isn't tangible, we need action.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lileas Graf), `[47]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lileas Graf: "“The state warning the state doesn't make any sense at al..."*)

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“I can only hope that they handle the money well if they do get it. I'm still not fully convinced.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“If we make the opening ceremony on time the public will cherish our efficiency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“It's good to see that failure isn't rewarded and punished. We will find more competent people through our networks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“It would be a drastic measure but not unreasonable. Replacing them with competent managers would do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“I disagree completely. The SSC managers are the most exp..."*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“You see that the likes of Underhall are willing to bend the rules and risk the lives of their workers to hit deadlines. The SSC abides by the rules and regulations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“One of the important issues is their construction manage..."*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“I disagree completely. The SSC managers are the most experienced construction managers in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“Officially warning them is a possibility but isn't tangi..."*)
  - -> `[20]` (*Player: "“The state owns the SSC. They can't retaliate and bite of..."*)
  - -> `[48]` (*Player: "“Finding competent managers could work. New blood can mov..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Finding competent managers could work. New blood can move things back on track.”"]** — Mówca: **Player**
> "“Finding competent managers could work. New blood can move things back on track.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“We have a lot of talented construction managers in the p..."*)

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“We have a lot of talented construction managers in the private industry who would work for us in the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“I have concerns about the construction due to progress being slower than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“We scheduled the project to finish in late 1955 but the ..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“The SSC might need more resources to speed things up. That deadline must be met.”"]** — Mówca: **Player**
> "“The SSC might need more resources to speed things up. That deadline must be met.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lileas Graf), `[67]` (Symon Holl), `[68]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lileas Graf: "“I stand in agreement. The construction speed can recover..."*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“We scheduled the project to finish in late 1955 but the Sordish State Corporation might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lileas Graf: "“After engaging with the managers, they have said that th..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“We can't let mismanagement delay the project. It is unacceptable.”"]** — Mówca: **Player**
> "“We can't let mismanagement delay the project. It is unacceptable.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lileas Graf), `[67]` (Symon Holl), `[68]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“Couldn't agree more. This shouldn't keep going on any lo..."*)

### Węzeł `[54]`
Mówca: **Lileas Graf**
> "“The SSC is an organisation of principle so they aren't rushing and risking peoples lives. The state can't be reckless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“How can we get the construction back on schedule?”"*)
  - -> `[65]` (*Player: "“This doesn't raise confidence at all. Maybe we shouldn't..."*)
  - -> `[64]` (*Player: "“I don't care about principles, our agreed opening dates ..."*)
  - -> `[57]` (*Player: "“I trust that the SSC will accomplish it in time.”"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“The managers should be fired. This is unacceptable.”"]** — Mówca: **Player**
> "“The managers should be fired. This is unacceptable.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lileas Graf), `[67]` (Symon Holl), `[68]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: "“It would be a drastic measure but not unreasonable. Repl..."*)

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“But with that comes other issues. We don't want to create chaos in the management team which could create further problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“The SSC might need more resources to speed things up. Th..."*)
  - -> `[53]` (*Player: "“We can't let mismanagement delay the project. It is unac..."*)
  - -> `[55]` (*Player: "“The managers should be fired. This is unacceptable.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“I trust that the SSC will accomplish it in time.”"]** — Mówca: **Player**
> "“I trust that the SSC will accomplish it in time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: "“I think so too but maybe we should increase their budget..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“How can we get the construction back on schedule?”"]** — Mówca: **Player**
> "“How can we increase the construction speed, Symon?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“That is the million ren question. There are a couple of ..."*)

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“That is the million ren question. There are a couple of issues that need to be resolved if we want the SSC to make the deadline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“One of the important issues is their construction manage..."*)

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“The warning will hopefully have a positive result to their performance. We could escalate further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“Why would they? The SSC respects the authorities fully. They would never dare to go against us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“One of the important issues is their construction management team. The other could be the outdated construction methods used which require more manpower, but we aren't sure if that contributes to the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: "“But with that comes other issues. We don't want to creat..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lileas Graf: "“Trust me Mr. President this is the best investment we co..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I don't care about principles, our agreed opening dates must be met.”"]** — Mówca: **Player**
> "“I don't care about principles, our agreed opening dates must be met.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: "“We shouldn't be risking lives, Mr. President. The SSC wo..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“This doesn't raise confidence at all. Maybe we shouldn't have picked the SSC.”"]** — Mówca: **Player**
> "“This doesn't raise confidence at all. Maybe we shouldn't have picked the SSC.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: "“You see that the likes of Underhall are willing to bend ..."*)

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“We shouldn't be risking lives, Mr. President. The SSC wouldn't slow construction down if it wasn't absolutely necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Symon Holl: "“Either way we need them to solve the issue at hand.”"*)

### Węzeł `[67]`
Mówca: **Symon Holl**
> "“Either way we need them to solve the issue at hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“The SSC might need more resources to speed things up. Th..."*)
  - -> `[53]` (*Player: "“We can't let mismanagement delay the project. It is unac..."*)
  - -> `[55]` (*Player: "“The managers should be fired. This is unacceptable.”"*)

### Węzeł `[68]`
Mówca: **Symon Holl**
> "“Worth considering because I'm not confident that they will hit their targets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“The SSC might need more resources to speed things up. Th..."*)
  - -> `[53]` (*Player: "“We can't let mismanagement delay the project. It is unac..."*)
  - -> `[55]` (*Player: "“The managers should be fired. This is unacceptable.”"*)

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“I think so too but maybe we should increase their budget to help them buy new machinery to speed up the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Symon Holl: "“Worth considering because I'm not confident that they wi..."*)

### Węzeł `[70]`
Mówca: **Lileas Graf**
> "“After engaging with the managers, they have said that they are moving forward slowly but steadily. The cliff-side ground-laying construction between Lenkurg and Arvory is proving more dangerous than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lileas Graf: "“The SSC is an organisation of principle so they aren't r..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == false"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == fa..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Dozens of people were outside the mansion grounds and cha..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Afterwards, we gathered at the city hall. Symon had a wor..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Dozens of people were outside the mansion grounds and chanting party slogans in a show of support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Afterwards, we gathered at the city hall. Symon had a wor..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved = true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Warn == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Warn == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_SSC_Warn == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Warn == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_SSCPromised = true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_SSC_Warn == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Replace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Replace == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_SSC_Replace == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Replace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_SSCReplaced = true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_SSC_Replace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Warn == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway ..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_SSCReplaced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_SSCPromised = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lileas Graf: "“I'm not so sure what a warning can do to the situation o..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lileas Graf: "“This was a bad decision. This hurts the honorable SSC mo..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lileas Graf: "“This was a bad decision. This hurts the honorable SSC mo..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“That should be it. Good that we have figured out a way t..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
