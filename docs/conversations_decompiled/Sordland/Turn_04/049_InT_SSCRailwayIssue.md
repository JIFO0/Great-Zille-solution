# Sordland/Turn04/InT_SSCRailwayIssue

- **ID konwersacji:** `49`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/049_InT_SSCRailwayIssue.md`
- **Liczba węzłów dialogowych:** 95
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn04_InT_Issue_SSC_Replace`
- `BaseGame.Turn04_InT_Issue_SSC_Warn`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.GovernmentBudget`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn04_InT_Issue_SSC_Money`
- `BaseGame.Turn04_InT_Issue_SSC_Replace`
- `BaseGame.Turn04_InT_Issue_SSC_Warn`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning`
- `BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway`
- `BaseGameSupport.Report_Turn04_Holsord_SSCPromised`
- `BaseGameSupport.Report_Turn04_Holsord_SSCReplaced`
- `GameCondition.Turn04_InT_Issue`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[22]` | **"“Do we have a case of project mismanagement?”"** | `[63]` **Gus Manger**: "“The SSC reported that they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Gus Manger**: "“That is my theory because they ..." |
| `[23]` | **"“Finding competent managers could work. New blood can move things back on track.”"** | `[28]` **Gus Manger**: "“The shake-up could have a posit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Gus Manger**: "“I know many skilled and experie..." |
| `[26]` | **"“The incompetent managers should be fired. This is a disgrace.”"** | `[39]` **Gus Manger**: "“State owned corporations like t..."<br>`[69]` **Symon Holl**: "“We must focus on solving the is..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Symon Holl**: "“It would be a drastic measure b..." |
| `[31]` | **"“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"** | `[28]` **Gus Manger**: "“The shake-up could have a posit..."<br>`[70]` **Gus Manger**: "“You are right. My advice would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Symon Holl**: "“I don't expect them to bite bac..." |
| `[37]` | **"“We can't let mismanagement delay the project. It is unacceptable.”"** | `[39]` **Gus Manger**: "“State owned corporations like t..."<br>`[69]` **Symon Holl**: "“We must focus on solving the is..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Symon Holl**: "“Couldn't agree more. This shoul..." |
| `[38]` | **"“Warn the construction managers. Send a formal warning from the Ministry of Econom..."** | `[33]` **Gus Manger**: "“I say we replace them with more..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true; Va...` | `[25]` **Symon Holl**: "“The warning will hopefully have..." |
| `[40]` | **"“Giving them a serious warning could be the solution. A slap on the wrist can do w..."** | `[51]` **Symon Holl**: "“A cash injection to hire more w..."<br>`[70]` **Gus Manger**: "“You are right. My advice would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Symon Holl**: "“There is a good chance that the..." |
| `[41]` | **"“Replace the construction managers with more competent people to ensure the deadli..."** | `[33]` **Gus Manger**: "“I say we replace them with more..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true;...` | `[43]` **Symon Holl**: "“It's good to see that failure i..." |
| `[46]` | **"“How can we speed up the construction to get back on track?”"** | `[63]` **Gus Manger**: "“The SSC reported that they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Symon Holl**: "“That is the million ren questio..." |
| `[50]` | **"“The SSC might need more resources to speed things up. That deadline must be met.”"** | `[39]` **Gus Manger**: "“State owned corporations like t..."<br>`[69]` **Symon Holl**: "“We must focus on solving the is..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Gus Manger**: "“They aren't managing to maintai..." |
| `[52]` | **"“It might even be necessary for us to hit the opening date.”"** | `[51]` **Symon Holl**: "“A cash injection to hire more w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Symon Holl**: "“Let's hope that they handle the..." |
| `[60]` | **"“There is also the chance that the money could be wasted. We already spent so much..."** | `[51]` **Symon Holl**: "“A cash injection to hire more w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Gus Manger**: "“I think that chance is far more..." |
| `[61]` | **"“Give more money to the construction managers so they can hire more workers and bu..."** | `[33]` **Gus Manger**: "“I say we replace them with more..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true; V...` | `[62]` **Symon Holl**: "“This extra investment could be ..." |
| `[64]` | **"“Officially warning them is a possibility but isn't tangible, we need action.”"** | `[28]` **Gus Manger**: "“The shake-up could have a posit..."<br>`[70]` **Gus Manger**: "“You are right. My advice would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Gus Manger**: "“I don't know who they will list..." |
| `[65]` | **"“You were right. The administration won't work with the SSC again.”"** | `[63]` **Gus Manger**: "“The SSC reported that they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Gus Manger**: "“Good call, Mr. President. Under..." |
| `[66]` | **"“I need to hear solutions not excuses or reasons.”"** | `[63]` **Gus Manger**: "“The SSC reported that they have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Gus Manger**: "“Excuse my bluntness, sir. The m..." |

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
  - -> `[4]` (*Narrator: "The L-1 Railway construction created the perfect opportun..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The main purpose of our visit was to solve construction issues that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The L-1 Railway construction created the perfect opportunity to visit the green technological nerve centre of Sordland. Dozens of electrical engineers from the city were part of the electrification upgrade of the rail track."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The main purpose of our visit was to solve construction i..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "There was also a message of support from the mayor of Anrica, Curtan Leste, who was grateful for the L-1 investments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: "“We scheduled the project to finish in late 1955 but I ha..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The Gelsord Research Council was very willing to let us u..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The Gelsord Research Council was very reluctant to let us..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The Gelsord Research Council let us use their facilities,..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The Gelsord Research Council was very willing to let us use their facilities because the rectors were pleased by the increase of the education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Symon looked a little more stressed than usual. Gus was a..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "The Gelsord Research Council let us use their facilities, but the rectors weren't interested in our affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Symon looked a little more stressed than usual. Gus was a..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The Gelsord Research Council was very reluctant to let us use their facilities as the rectors weren't at all pleased by the reduction of education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Symon looked a little more stressed than usual. Gus was a..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "The meeting ended. The three of us toured the Advanced Research and Development divisions in Gelsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "The day-long visit ended with a dinner involving the most..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "The day-long visit ended with a dinner involving the most important people in the city. Many of them were scientists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Later, we made our way back to Holsord."*)

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“That should be it. Good that we have figured out a way to move the process forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "The meeting ended. The three of us toured the Advanced Re..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Later, we made our way back to Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Replace == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_InT_Issue = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Symon looked a little more stressed than usual. Gus was also here to find solutions. He eyed me for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "There was also a message of support from the mayor of Anr..."*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“We scheduled the project to finish in late 1955 but I have concerns about the construction due to progress being slower than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Gus Manger: "“I expected some issue even before we started this. This ..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Do we have a case of project mismanagement?”"]** — Mówca: **Player**
> "“Do we have a case of project mismanagement?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Gus Manger: "“That is my theory because they knew about the zones the ..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Finding competent managers could work. New blood can move things back on track.”"]** — Mówca: **Player**
> "“Finding competent managers could work. New blood can move things back on track.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gus Manger: "“I know many skilled and experienced people in the constr..."*)

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“I know many skilled and experienced people in the construction industry. So does Symon too, I presume.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“The warning will hopefully have a positive result to their performance. We could escalate further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“The incompetent managers should be fired. This is a disgrace.”"]** — Mówca: **Player**
> "“The incompetent managers should be fired. This is a disgrace.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger), `[69]` (Symon Holl), `[73]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Symon Holl: "“It would be a drastic measure but not unreasonable. Repl..."*)

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“It would be a drastic measure but not unreasonable. Replacing them with competent managers would do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gus Manger: "“The shake-up could have a positive result but what if th..."*)

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“The shake-up could have a positive result but what if the SSC overall boycotts against this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“Officially warning them is a possibility but isn't tangi..."*)
  - -> `[31]` (*Player: "“The state owns the SSC. They can't retaliate and bite of..."*)
  - -> `[23]` (*Player: "“Finding competent managers could work. New blood can mov..."*)

### Węzeł `[29]`
Mówca: **Gus Manger**
> "“I will personally go and talk to a few SSC managers and tell them of the gravity of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: "“That should be it. Good that we have figured out a way t..."*)

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“I don't expect them to bite back but maybe they can further slow the construction by protesting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"]** — Mówca: **Player**
> "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Gus Manger), `[70]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: "“I don't expect them to bite back but maybe they can furt..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Symon took a deep breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Symon Holl: "“One way or another we have to solve this issue. This can..."*)

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“I say we replace them with more competent managers. It should help resolve the resources being handled inefficiently.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“Give more money to the construction managers so they can..."*)
  - -> `[38]` (*Player: "“Warn the construction managers. Send a formal warning fr..."*)
  - -> `[41]` (*Player: "“Replace the construction managers with more competent pe..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gus Manger: "“This proves that they have failed at their base contract..."*)

### Węzeł `[35]`
Mówca: **Symon Holl**
> "“Couldn't agree more. This shouldn't keep going on any longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Gus Manger: "“You are right. My advice would be to warn them. There is..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Replace = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: "“It's good to see that failure isn't rewarded and punishe..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“We can't let mismanagement delay the project. It is unacceptable.”"]** — Mówca: **Player**
> "“We can't let mismanagement delay the project. It is unacceptable.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger), `[69]` (Symon Holl), `[73]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Symon Holl: "“Couldn't agree more. This shouldn't keep going on any lo..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"]** — Mówca: **Player**
> "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Warn = true; BaseGameSuppor..."*)

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“State owned corporations like them never really receive performance penalties and that's why they are incompetent and lack responsibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“The SSC might need more resources to speed things up. Th..."*)
  - -> `[37]` (*Player: "“We can't let mismanagement delay the project. It is unac..."*)
  - -> `[26]` (*Player: "“The incompetent managers should be fired. This is a disg..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"]** — Mówca: **Player**
> "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl), `[70]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Symon Holl: "“There is a good chance that they will take this far more..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Replace the construction managers with more competent people to ensure the deadline is hit.”"]** — Mówca: **Player**
> "“Replace the construction managers with more competent people to ensure the deadline is hit.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Replace = true; BaseGameSup..."*)

### Węzeł `[42]`
Mówca: **Gus Manger**
> "“I'll make some calls. Got good contacts that can be added to the potential candidates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: "“That should be it. Good that we have figured out a way t..."*)

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“It's good to see that failure isn't rewarded and punished. We will find more competent people through our networks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“There is a good chance that they will take this far more seriously and take measures to increase speed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“One of the important issues is their construction management team. The other could be the outdated construction methods used which require more manpower, but we aren't sure if that contributes to the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger: "“State owned corporations like them never really receive ..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“How can we speed up the construction to get back on track?”"]** — Mówca: **Player**
> "“How can we speed up the construction to get back on track?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Symon Holl: "“That is the million ren question. There are a couple of ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“This extra investment could be just enough to get things..."*)

### Węzeł `[48]`
Mówca: **Symon Holl**
> "“That is the million ren question. There are a couple of issues that need to be resolved if we want the SSC to make the deadline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: "“One of the important issues is their construction manage..."*)

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“They aren't managing to maintain the speed of the construction with the resources given. Why should they receive more?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Symon Holl: "“A cash injection to hire more workers and buy more machi..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“The SSC might need more resources to speed things up. That deadline must be met.”"]** — Mówca: **Player**
> "“The SSC might need more resources to speed things up. That deadline must be met.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger), `[69]` (Symon Holl), `[73]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“They aren't managing to maintain the speed of the constr..."*)

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“A cash injection to hire more workers and buy more machinery could have a positive effect on the construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“It might even be necessary for us to hit the opening date.”"*)
  - -> `[60]` (*Player: "“There is also the chance that the money could be wasted...."*)
  - -> `[40]` (*Player: "“Giving them a serious warning could be the solution. A s..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It might even be necessary for us to hit the opening date.”"]** — Mówca: **Player**
> "“It might even be necessary for us to hit the opening date.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Symon Holl: "“Let's hope that they handle the money well. I'm still no..."*)

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“Let's hope that they handle the money well. I'm still not a hundred percent sure about this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[54]`
Mówca: **Gus Manger**
> "“That is my theory because they knew about the zones the track passes by. The old SSC construction managers think they are untouchable and that they have no obligations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: "“One of the important issues is their construction manage..."*)

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“We can either give the construction managers more money, warn them or replace them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“I say we replace them with more competent managers. It s..."*)

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“One way or another we have to solve this issue. This can lead to real complications down the line otherwise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Symon Holl: "“We can either give the construction managers more money,..."*)

### Węzeł `[57]`
Mówca: **Gus Manger**
> "“I think that chance is far more likely. I wouldn't take that risk if I were you because there are many more critical investments we can make.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Warn = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: "“The warning will hopefully have a positive result to the..."*)

### Węzeł `[59]`
Mówca: **Gus Manger**
> "“This proves that they have failed at their base contractual agreement. What a shame that we trusted them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 75);  // Updates token..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"]** — Mówca: **Player**
> "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gus Manger: "“I think that chance is far more likely. I wouldn't take ..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Money = true; BaseGameSuppo..."*)

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“This extra investment could be just enough to get things back on track. However, it is unfortunate we had to spend more because we need it elsewhere too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“The SSC reported that they have been slowed down due to several areas on the way to Gelsord having a potential for landslides that could endanger the workers. My argument is that they should have known about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Do we have a case of project mismanagement?”"*)
  - -> `[46]` (*Player: "“How can we speed up the construction to get back on track?”"*)
  - -> `[65]` (*Player: "“You were right. The administration won't work with the S..."*)
  - -> `[66]` (*Player: "“I need to hear solutions not excuses or reasons.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Officially warning them is a possibility but isn't tangible, we need action.”"]** — Mówca: **Player**
> "“Officially warning them is a possibility but isn't tangible, we need action.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Gus Manger), `[70]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gus Manger: "“I don't know who they will listen to if they aren't list..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“You were right. The administration won't work with the SSC again.”"]** — Mówca: **Player**
> "“You were right. The administration won't work with the SSC again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Gus Manger: "“Good call, Mr. President. Underhall should be available ..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I need to hear solutions not excuses or reasons.”"]** — Mówca: **Player**
> "“I need to hear solutions not excuses or reasons.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Gus Manger: "“Excuse my bluntness, sir. The management of SSC is hard ..."*)

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“Excuse my bluntness, sir. The management of SSC is hard to communicate with because they have the know-it-all attitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Symon Holl: "“It would be possible to demand a change in leadership.”"*)

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“Good call, Mr. President. Underhall should be available for a second project in the future if we have the budget to do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Symon Holl: "“We must focus on solving the issue at hand.”"*)

### Węzeł `[69]`
Mówca: **Symon Holl**
> "“We must focus on solving the issue at hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“The SSC might need more resources to speed things up. Th..."*)
  - -> `[37]` (*Player: "“We can't let mismanagement delay the project. It is unac..."*)
  - -> `[26]` (*Player: "“The incompetent managers should be fired. This is a disg..."*)

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“You are right. My advice would be to warn them. There is a chance they might wake up to the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“Giving them a serious warning could be the solution. A s..."*)
  - -> `[64]` (*Player: "“Officially warning them is a possibility but isn't tangi..."*)
  - -> `[31]` (*Player: "“The state owns the SSC. They can't retaliate and bite of..."*)

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“I don't know who they will listen to if they aren't listening to the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Symon took a deep breath and continued."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved = true"*)

### Węzeł `[73]`
Mówca: **Symon Holl**
> "“It would be possible to demand a change in leadership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“The SSC might need more resources to speed things up. Th..."*)
  - -> `[37]` (*Player: "“We can't let mismanagement delay the project. It is unac..."*)
  - -> `[26]` (*Player: "“The incompetent managers should be fired. This is a disg..."*)

### Węzeł `[74]`
Mówca: **Gus Manger**
> "“I expected some issue even before we started this. This corporation is full of fossils that don't know how to solve problems reactively.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“The SSC reported that they have been slowed down due to ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Replace == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Replace == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_SSC_Replace == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Replace == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_SSCReplaced = true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_SSC_Replace == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Warn == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway ..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_SSCReplaced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Warn == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Warn == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_SSC_Warn == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Warn == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_SSCPromised = true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_SSC_Warn == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_SSCPromised = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_InT_Issue = true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Gus Manger: "“I will personally go and talk to a few SSC managers and ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gus Manger: "“I'll make some calls. Got good contacts that can be adde..."*)

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
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gus Manger: "“I'll make some calls. Got good contacts that can be adde..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: "“That should be it. Good that we have figured out a way t..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
