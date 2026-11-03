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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 14

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.GovernmentBudget`
- `BaseGame.Turn04_InT_Issue_SSC_Warn`
- `BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[15]` (Symon Holl): `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- Węzeł `[23]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true; Variable["BaseGameSupport.Journal_Turn04_...`
- Węzeł `[24]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true; Variable["BaseGameSupport.Journal_Turn04_I...`
- Węzeł `[25]` (Symon Holl): `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true; Variable["BaseGameSupport.Journal_Turn0...`
- Węzeł `[63]` (Symon Holl): `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- Węzeł `[75]` (Symon Holl): `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- Węzeł `[85]` (Symon Holl): `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCReplaced"] = true;`
- Węzeł `[86]` (Symon Holl): `Variable["BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway"] = true;`
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
> "But the main purpose of our visit was to solve construction issues that began to endanger the deadline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The H-3 Highway construction created a second opportunity to visit the seaside town of Lenkurg known for its salmon. Thousands of people from the city were employed for construction work by the new highway project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Narrator**
> "There also was a message of support from the mayor of Arvory, Eric Niel, who was grateful for the H-3 investments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[6]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The mayor welcomed us to his own mansion and praised us for our decision to extensively invest in the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[10]`
Mówca: **Narrator**
> "We first met with the mayor and took a brief tour in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The meeting ended. The three of us went to the beach of Lenkurg. It was rather rocky, but very pristine. The sunset looked absolutely astonishing over the Markian Sea."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The day-long visit ended with a dinner involving the most important people in the city. Many of them were bureaucrats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“That should be it. Good that we have figured out a way to move the process forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Later, we made our way back to Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[15]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_InT_Issue = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_InT_Issue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Afterwards, we gathered at the city hall. Symon had a worried look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[17]`
Mówca: **Lileas Graf**
> "“Trust me Mr. President this is the best investment we could have done. The SSC will only grow and learn from this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“This extra investment could be just enough to get things back on track. However, it is unfortunate we had to spend more because we need it elsewhere too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“I'm not so sure what a warning can do to the situation on the ground. The managers already have many issues to tackle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"]** — Mówca: **Player**
> "“The state owns the SSC. They can't retaliate and bite off the hand that feeds them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Symon took a deep breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[22]`
Mówca: **Lileas Graf**
> "“With more resources the managers are more likely to hit the deadline. Any other action just hurts Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[31]`
  - -> `[30]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Money = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCFunds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Warn = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCWarning"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[25]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Replace = true; BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] = true;
Variable["BaseGameSupport.Journal_Turn04_Infrastructure_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[26]`
Mówca: **Lileas Graf**
> "“This was a bad decision. This hurts the honorable SSC more than anything and will hamper our efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[27]`
Mówca: **Symon Holl**
> "“Couldn't agree more. This shouldn't keep going on any longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“I stand in agreement. The construction speed can recover if they expand the workforce and buy new machinery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Give more money to the construction managers so they can hire more workers and buy machinery to hit the deadline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Replace the construction managers with more competent people to ensure the deadline is hit.”"]** — Mówca: **Player**
> "“Replace the construction managers with more competent people to ensure the deadline is hit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"]** — Mówca: **Player**
> "“Warn the construction managers. Send a formal warning from the Ministry of Economy and the Presidency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[32]`
Mówca: **Lileas Graf**
> "“It is very important that we create jobs for our own citizens who are unemployed rather than foreigners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[41]`
  - -> `[20]`

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“We can either give the construction managers money, warn them or replace them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[34]`
Mówca: **Symon Holl**
> "“A cash injection would increase the project costs even further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Symon Holl**
> "“One way or another we have to solve this issue. This can lead to real complications down the line otherwise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“It might even be necessary for us to hit the opening date.”"]** — Mówca: **Player**
> "“It might even be necessary for us to hit the opening date.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Symon Holl**
> "“There is a good chance that they will take it far more seriously and take measures to increase speed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"]** — Mówca: **Player**
> "“There is also the chance that the money could be wasted. We already spent so much on this investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"]** — Mówca: **Player**
> "“Giving them a serious warning could be the solution. A slap on the wrist can do wonders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“The state warning the state doesn't make any sense at all anyway. Their reasons are just.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Officially warning them is a possibility but isn't tangible, we need action.”"]** — Mówca: **Player**
> "“Officially warning them is a possibility but isn't tangible, we need action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“I can only hope that they handle the money well if they do get it. I'm still not fully convinced.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“If we make the opening ceremony on time the public will cherish our efficiency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“It's good to see that failure isn't rewarded and punished. We will find more competent people through our networks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“It would be a drastic measure but not unreasonable. Replacing them with competent managers would do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“You see that the likes of Underhall are willing to bend the rules and risk the lives of their workers to hit deadlines. The SSC abides by the rules and regulations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“I disagree completely. The SSC managers are the most experienced construction managers in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[20]`
  - -> `[48]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Finding competent managers could work. New blood can move things back on track.”"]** — Mówca: **Player**
> "“Finding competent managers could work. New blood can move things back on track.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“We have a lot of talented construction managers in the private industry who would work for us in the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“I have concerns about the construction due to progress being slower than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“The SSC might need more resources to speed things up. That deadline must be met.”"]** — Mówca: **Player**
> "“The SSC might need more resources to speed things up. That deadline must be met.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“We scheduled the project to finish in late 1955 but the Sordish State Corporation might miss that target with the current trajectory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“We can't let mismanagement delay the project. It is unacceptable.”"]** — Mówca: **Player**
> "“We can't let mismanagement delay the project. It is unacceptable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[54]`
Mówca: **Lileas Graf**
> "“The SSC is an organisation of principle so they aren't rushing and risking peoples lives. The state can't be reckless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[65]`
  - -> `[64]`
  - -> `[57]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“The managers should be fired. This is unacceptable.”"]** — Mówca: **Player**
> "“The managers should be fired. This is unacceptable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“But with that comes other issues. We don't want to create chaos in the management team which could create further problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“I trust that the SSC will accomplish it in time.”"]** — Mówca: **Player**
> "“I trust that the SSC will accomplish it in time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“How can we get the construction back on schedule?”"]** — Mówca: **Player**
> "“How can we increase the construction speed, Symon?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“That is the million ren question. There are a couple of issues that need to be resolved if we want the SSC to make the deadline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“The warning will hopefully have a positive result to their performance. We could escalate further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“Why would they? The SSC respects the authorities fully. They would never dare to go against us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“One of the important issues is their construction management team. The other could be the outdated construction methods used which require more manpower, but we aren't sure if that contributes to the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[63]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I don't care about principles, our agreed opening dates must be met.”"]** — Mówca: **Player**
> "“I don't care about principles, our agreed opening dates must be met.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“This doesn't raise confidence at all. Maybe we shouldn't have picked the SSC.”"]** — Mówca: **Player**
> "“This doesn't raise confidence at all. Maybe we shouldn't have picked the SSC.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“We shouldn't be risking lives, Mr. President. The SSC wouldn't slow construction down if it wasn't absolutely necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Symon Holl**
> "“Either way we need them to solve the issue at hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[68]`
Mówca: **Symon Holl**
> "“Worth considering because I'm not confident that they will hit their targets.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“I think so too but maybe we should increase their budget to help them buy new machinery to speed up the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Lileas Graf**
> "“After engaging with the managers, they have said that they are moving forward slowly but steadily. The cliff-side ground-laying construction between Lenkurg and Arvory is proving more dangerous than expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[71]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Dozens of people were outside the mansion grounds and chanting party slogans in a show of support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[75]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[76]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Warn == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Warn == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[78]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_SSC_Warn == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Warn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Replace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_Issue_SSC_Replace == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[81]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_Issue_SSC_Replace == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Replace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[82]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_SSCReplaced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCReplaced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[86]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_SSCManagers_Fired_Highway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[87]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_SSCPromised = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_SSCPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[88]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

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
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[93]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[94]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[95]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
