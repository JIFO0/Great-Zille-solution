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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 14

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.GovernmentBudget`
- `BaseGame.Turn04_InT_Issue_SSC_Warn`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[19]` (Symon Holl): `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- Węzeł `[34]` (Symon Holl): `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- Węzeł `[36]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true; Variable["BaseGameSupport.Journal_Turn0...`
- Węzeł `[47]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true; Variable["BaseGameSupport.Journal_Turn04_...`
- Węzeł `[58]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true; Variable["BaseGameSupport.Journal_Turn04_I...`
- Węzeł `[72]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- Węzeł `[81]` (Symon Holl): `Variable["BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway"] = true;`
- Węzeł `[82]` (Symon Holl): `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCReplaced"] = true;`
- *...oraz 6 innych węzłów ze skryptami.*

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
> "The main purpose of our visit was to solve construction issues that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The L-1 Railway construction created the perfect opportunity to visit the green technological nerve centre of Sordland. Dozens of electrical engineers from the city were part of the electrification upgrade of the rail track."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Narrator**
> "There was also a message of support from the mayor of Anrica, Curtan Leste, who was grateful for the L-1 investments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[6]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The Gelsord Research Council was very willing to let us use their facilities because the rectors were pleased by the increase of the education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[13]`
Mówca: **Narrator**
> "The Gelsord Research Council let us use their facilities, but the rectors weren't interested in our affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The Gelsord Research Council was very reluctant to let us use their facilities as the rectors weren't at all pleased by the reduction of education funding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Narrator**
> "The meeting ended. The three of us toured the Advanced Research and Development divisions in Gelsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "The day-long visit ended with a dinner involving the most important people in the city. Many of them were scientists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Symon Holl**
> "“That should be it. Good that we have figured out a way to move the process forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Later, we made our way back to Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[19]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_InT_Issue = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Symon looked a little more stressed than usual. Gus was also here to find solutions. He eyed me for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“We scheduled the project to finish in late 1955 but I have concerns about the construction due to progress being slower than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Do we have a case of project mismanagement?”"]** — Mówca: **Player**
> "“Do we have a case of project mismanagement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Finding competent managers could work. New blood can move things back on track.”"]** — Mówca: **Player**
> "“Finding competent managers could work. New blood can move things back on track.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“I know many skilled and experienced people in the construction industry. So does Symon too, I presume.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“The warning will hopefully have a positive result to their performance. We could escalate further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“The incompetent managers should be fired. This is a disgrace.”"]** — Mówca: **Player**
> "“The incompetent managers should be fired. This is a disgrace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“It would be a drastic measure but not unreasonable. Replacing them with competent managers would do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Gus Manger**
> "“The shake-up could have a positive result but what if the SSC overall boycotts against this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[31]`
  - -> `[23]`

### Węzeł `[29]`
Mówca: **Gus Manger**
> "“I will personally go and talk to a few SSC managers and tell them of the gravity of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“I don't expect them to bite back but maybe they can further slow the construction by protesting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"]** — Mówca: **Player**
> "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Symon took a deep breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“I say we replace them with more competent managers. It should help resolve the resources being handled inefficiently.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[38]`
  - -> `[41]`

### Węzeł `[34]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[35]`
Mówca: **Symon Holl**
> "“Couldn't agree more. This shouldn't keep going on any longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Replace = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“We can't let mismanagement delay the project. It is unacceptable.”"]** — Mówca: **Player**
> "“We can't let mismanagement delay the project. It is unacceptable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"]** — Mówca: **Player**
> "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“State owned corporations like them never really receive performance penalties and that's why they are incompetent and lack responsibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[37]`
  - -> `[26]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"]** — Mówca: **Player**
> "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Replace the construction managers with more competent people to ensure the deadline is hit.”"]** — Mówca: **Player**
> "“Replace the construction managers with more competent people to ensure the deadline is hit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[42]`
Mówca: **Gus Manger**
> "“I'll make some calls. Got good contacts that can be added to the potential candidates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“It's good to see that failure isn't rewarded and punished. We will find more competent people through our networks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“There is a good chance that they will take this far more seriously and take measures to increase speed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“One of the important issues is their construction management team. The other could be the outdated construction methods used which require more manpower, but we aren't sure if that contributes to the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“How can we speed up the construction to get back on track?”"]** — Mówca: **Player**
> "“How can we speed up the construction to get back on track?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[48]`
Mówca: **Symon Holl**
> "“That is the million ren question. There are a couple of issues that need to be resolved if we want the SSC to make the deadline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“They aren't managing to maintain the speed of the construction with the resources given. Why should they receive more?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“The SSC might need more resources to speed things up. That deadline must be met.”"]** — Mówca: **Player**
> "“The SSC might need more resources to speed things up. That deadline must be met.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“A cash injection to hire more workers and buy more machinery could have a positive effect on the construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[60]`
  - -> `[40]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It might even be necessary for us to hit the opening date.”"]** — Mówca: **Player**
> "“It might even be necessary for us to hit the opening date.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“Let's hope that they handle the money well. I'm still not a hundred percent sure about this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[54]`
Mówca: **Gus Manger**
> "“That is my theory because they knew about the zones the track passes by. The old SSC construction managers think they are untouchable and that they have no obligations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“We can either give the construction managers more money, warn them or replace them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“One way or another we have to solve this issue. This can lead to real complications down the line otherwise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
Mówca: **Gus Manger**
> "“I think that chance is far more likely. I wouldn't take that risk if I were you because there are many more critical investments we can make.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[58]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Warn = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[59]`
Mówca: **Gus Manger**
> "“This proves that they have failed at their base contractual agreement. What a shame that we trusted them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"]** — Mówca: **Player**
> "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“This extra investment could be just enough to get things back on track. However, it is unfortunate we had to spend more because we need it elsewhere too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“The SSC reported that they have been slowed down due to several areas on the way to Gelsord having a potential for landslides that could endanger the workers. My argument is that they should have known about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[46]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Officially warning them is a possibility but isn't tangible, we need action.”"]** — Mówca: **Player**
> "“Officially warning them is a possibility but isn't tangible, we need action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“You were right. The administration won't work with the SSC again.”"]** — Mówca: **Player**
> "“You were right. The administration won't work with the SSC again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I need to hear solutions not excuses or reasons.”"]** — Mówca: **Player**
> "“I need to hear solutions not excuses or reasons.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“Excuse my bluntness, sir. The management of SSC is hard to communicate with because they have the know-it-all attitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“Good call, Mr. President. Underhall should be available for a second project in the future if we have the budget to do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Symon Holl**
> "“We must focus on solving the issue at hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[37]`
  - -> `[26]`

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“You are right. My advice would be to warn them. There is a chance they might wake up to the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[64]`
  - -> `[31]`

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“I don't know who they will listen to if they aren't listening to the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[72]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[73]`
Mówca: **Symon Holl**
> "“It would be possible to demand a change in leadership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[37]`
  - -> `[26]`

### Węzeł `[74]`
Mówca: **Gus Manger**
> "“I expected some issue even before we started this. This corporation is full of fossils that don't know how to solve problems reactively.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[75]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Replace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Replace == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[77]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_SSC_Replace == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[80]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Railway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[82]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_SSCReplaced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Warn == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Warn == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_SSC_Warn == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[86]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_SSCPromised = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[87]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[88]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[89]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[93]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[94]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
