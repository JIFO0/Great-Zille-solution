# Sordland/Turn03/EnT_Budget

- **ID konwersacji:** `26`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/026_EnT_Budget.md`
- **Liczba węzłów dialogowych:** 212
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[40]** Ciara Walda
- **[44]** Lileas Graf
- **[51]** Symon Holl
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn03_StabilityOrder_BanBoth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Promise_TermFocus_Security`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGameIsolated.Turn03_EnT_Listened_Education`
- `BaseGameIsolated.Turn03_EnT_Listened_Healthcare`
- `BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement`
- `BaseGameIsolated.Turn03_EnT_Listened_Military`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn03_EnT_Listened_Education`
- `BaseGameIsolated.Turn03_EnT_Listened_Healthcare`
- `BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement`
- `BaseGameIsolated.Turn03_EnT_Listened_Military`
- `GameCondition.Turn03_EnT_BudgetOne`

### Skoki między-konwersacyjne:
- Węzeł `[209]` -> **[27] Sordland/Turn03/Budget Feedback** (../Turn_03/027_Budget_Feedback.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 7

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `GameCondition.Turn03_EnT_BudgetOne`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[84]` (Symon Holl): `Variable["GameCondition.Turn03_EnT_BudgetOne"] = true;`
- Węzeł `[96]` (Symon Holl): `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] = true;`
- Węzeł `[97]` (Symon Holl): `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] = true;`
- Węzeł `[98]` (Symon Holl): `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] = true;`
- Węzeł `[99]` (Symon Holl): `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] = true;`
- Węzeł `[209]` (Symon Holl): `ShowPagedDecisionsPanel("Panel_Budget");`
- Węzeł `[210]` (Symon Holl): `End();`

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
  - -> `[24]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
> "“We have to be careful as to what we fund so we have resources remaining for another investment project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[20]`
  - -> `[18]`

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“Today is a big day. We must prioritise our spending wisely in order to achieve the goals we set as a government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“Agreed, we have to make strategic decisions about our budget since our resources are fairly limited.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Let's begin, Mr. Holl.”"]** — Mówca: **Player**
> "“Let's begin, Mr. Holl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Thanks to Symon's expertise, I am sure we will achieve lots of great things today.”"]** — Mówca: **Player**
> "“Thanks to Symon's expertise, I am sure we will achieve many great things today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“Thank you for the compliment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“However, under these circumstances, it would worsen the economic crisis if we push it too far. It’s difficult for us to raise debt with the current unhealthy economy, but we can increase the amount of debt we can take as the economy improves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“As much as we realistically can. If we fail at improving our economy, the promises don't mean much in the big picture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“While maintaining enough political support, If I may add. Promises were made during the election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“We should prioritise the most critical branches.”"]** — Mówca: **Player**
> "“We should prioritise the most critical branches.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“One of the reasons our government was elected was because we promised that we are going to focus on the military during our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Reduction of funding in certain branches can help fund investment projects.”"]** — Mówca: **Player**
> "“Reduction of funding in certain branches can help fund investment projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Yes. The bigger our budget surplus is the more we can spend on reviving the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“We have to keep true to the election promises. Our people voted for us because of the promises we made.”"]** — Mówca: **Player**
> "“We have to keep true to the election promises. Our people voted for us because of the promises we made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[21]`
Mówca: **Nia Morgna**
> "“Law enforcement is certainly a high priority. However, I feel tackling internal corruption is of far higher importance than increasing our police presence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[22]`
Mówca: **Lileas Graf**
> "“We have so many internal threats to tackle and I'm already stretching my units far too thin with the limited resources allocated to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[23]`
Mówca: **Lileas Graf**
> "“I would like to have an increase in the funding of law enforcement to increase the size of the police force and raise salaries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The preparations for the government budget were finished. Most of the cabinet gathered in the White Room for the important occasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Nearly half a year had passed since my inauguration. The cabinet looked over-worked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I would like to use this opportunity for a statement.”"]** — Mówca: **Player**
> "“I would like to use this opportunity for a statement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“And now, the moment we've all been waiting for. It's finally time to discuss the government budget.”"]** — Mówca: **Player**
> "“And now, the moment we've all been waiting for. It's finally time to discuss the government budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Welcome, everybody. Great to see you.”"]** — Mówca: **Player**
> "“Welcome, everybody. Great to see you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“I'm quivering in my loafers with excitement, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[30]`
Mówca: **Lileas Graf**
> "“Hello.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Iosef Lancea**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[34]`
  - -> `[33]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Six months ago, all of us gathered to change the course of history. Now I'm proud of what we've achieved and what is to come.”"]** — Mówca: **Player**
> "“Six months ago, all of us gathered to change the course of history. Now I'm proud of what we've achieved and what is to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We are doing great work, and this is just the beginning. There will be many more good things to come.”"]** — Mówca: **Player**
> "“We are doing great work, and this is just the beginning. There will be many more good things to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Each and every one of you is very capable, but it's what we do as a team that counts.”"]** — Mówca: **Player**
> "“Each and every one of you is very capable, but it's what we do as a team that counts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "The ministers weren't as motivated by my statement as I had hoped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The ministers looked somewhat motivated by my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[38]`
Mówca: **Narrator**
> "The ministers appeared energized by my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
Mówca: **Lileas Graf**
> "“May the Lord be with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
> "“Given the current state of the country, improving economic situation is a political priority right now. More so than ever, if we want to win the 58 election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[41]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[43]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Much appreciated, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“Let's begin, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Budget Branches)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[47]`
  - -> `[55]`
  - -> `[58]`
  - -> `[93]`

### Węzeł `[47]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“Which branch should we discuss first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Let's talk about healthcare.”"]** — Mówca: **Player**
> "“Let's talk about healthcare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's time to hear the opinions on the military.”"]** — Mówca: **Player**
> "“It's time to hear the opinions on the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Let's discuss law enforcement.”"]** — Mówca: **Player**
> "“Let's discuss law enforcement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“What about education?”"]** — Mówca: **Player**
> "“What about education?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[55]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Military == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Military == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[57]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Listened_Military == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Education == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Education == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Listened_Education == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[63]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Security == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Security == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Security == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`
  - -> `[125]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“I must also remind you that we promised to focus on security and law enforcement during our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[119]`
  - -> `[120]`
  - -> `[125]`

### Węzeł `[68]`
Mówca: **Lileas Graf**
> "“That we are ready to defend our nation, Ms. Walda.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[69]`
Mówca: **Ciara Walda**
> "“Well, here is an argument. The Armed Forces does nothing but eat away financial resources destined for our people while stoking fears for an upcoming *war*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“Very worrying. On top of what Paskal said, we need to remember that we promised to focus on healthcare during our election campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[130]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[71]`
Mówca: **Ciara Walda**
> "“I agree with Ms. Morgna. We should not reward a structure that is responsible for an ever-increasing number of human rights violations. Additionally, corruption is the reason of our government inefficiencies. It needs to be tackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
> "“Our healthcare system is vast, and provides free services to most of our citizens. However, the quality of our health services is far worse in low-income and rural areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
> "“Therefore, I think that we should receive more funding to address this disparity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Ciara Walda**
> "“I agree. I have recently begun an investigation into healthcare in Narbel, and the numbers are not good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
> "“If we don't increase spending on health services, we at least need to maintain it. Otherwise, we are putting lives at risk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[76]`
Mówca: **Ciara Walda**
> "“Our education system is lacking. Not only in funding but also in modern curricular principles. Our outdated curriculum is wasting our youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Lileas Graf**
> "“Nonsense. Sordland is still here because of this very system that you insult. How can you insult a system that teaches our sons and daughters the principles of national identity and pride?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[78]`
Mówca: **Ciara Walda**
> "“That is the reason why I advocate two things. An increase of the budget to improve access to education in rural areas, and a new education reform.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“I must also remind you that we promised that we were going to focus on education during our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“I agree with Lileas. Sordland is Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_EnT_BudgetOne = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_EnT_BudgetOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[85]`
Mówca: **Symon Holl**
> "“There are three options regarding the budgeting of the four main branches of the government. It's either we increase, maintain or decrease the funding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Moving away from big government is the right choice.”"]** — Mówca: **Player**
> "“Moving away from big government is the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“The problem isn't the amount of money spent. It's how efficiently we spend it.”"]** — Mówca: **Player**
> "“The problem isn't the amount of money spent. It's how efficiently we spend it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Can we rely on the private sector to support us?”"]** — Mówca: **Player**
> "“Can we rely on the private sector to support us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Symon Holl**
> "“Increasing will result in an improvement of the branch which will unlock new policy options. Maintaining will keep the funding, resulting in no visible change. Decreasing causes a loss of efficiency in that branch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[87]`

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“I'm sure we can do that to a certain extent in some branches, like education and health.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't be attending this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[92]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Budget Branches])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[93]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Education == true || BaseGameIsolated.Turn03_EnT_Listened_Healthcare == true || BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == true ||BaseGameIsolated.Turn03_EnT_Listened_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Education == true || BaseGameIsolated.Turn03_EnT_Listened_Healthcare == true || BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == true ||BaseGameIsolated.Turn03_EnT_Listened_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == true  or Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[95]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_EnT_Listened_Education == true || BaseGameIsolated.Turn03_EnT_Listened_Healthcare == true || BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == true ||BaseGameIsolated.Turn03_EnT_Listened_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == true  or Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Healthcare = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[98]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Military = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_EnT_Listened_Education = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[100]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Budget Branches])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[101]`
Mówca: **Symon Holl**
> "“...The time to make a decision on the budget has come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[102]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Budget Branches])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[103]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: Jump to: [Budget Branches])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[104]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[86]`

### Węzeł `[106]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Is it possible to maintain as much state control as possible?”"]** — Mówca: **Player**
> "“Is it possible to maintain as much state control as possible?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Symon Holl**
> "“In the health and education departments, yes. However I am not sure if that would be efficient.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“Thank you, sir. Moving on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
> "“Our welfare systems are full of issues that need to be addressed, for instance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[112]`
Mówca: **Ciara Walda**
> "“It's true that many of our policies could be far better implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
> "“We need to be considerate when making such grand choices that have ripple effects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[114]`
Mówca: **Ciara Walda**
> "“Our universal healthcare system must be protected and not be tainted by private greed or interest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“Well, the state provides many services that our citizens pay for with their taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Ciara Walda**
> "“I agree. Our essential services should remain under our authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
> "“They are working on the upcoming trade agreements with Wehlen and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "Nod at Symon."]** — Mówca: **Player_Italic**
> "I nodded at Symon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I agree with Lileas. If this was another time, I would've said something different but we know the current situation.”"]** — Mówca: **Player**
> "“I agree with Lileas. If this was another time, I would've said something different but we know the current situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I agree with Nia. We need real solutions for real problems like corruption.”"]** — Mówca: **Player**
> "“I agree with Nia. We need real solutions for real problems like corruption.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[121]`
Mówca: **Nia Morgna**
> "“Directing the funds to my department would solve the problem at its root. If corruption is still rampant, all the police in the world won't help us. We need a specialized Anti-Corruption Police unit which we could create if the funds were directed to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I agree with Lucian. We can't just go back on our promise to the people.”"]** — Mówca: **Player**
> "“I agree with Lucian. We can't just go back on our promise to the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“The police are there to serve and protect the people of Sordland, Ms. Walda and that is exactly what we were doing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Lileas Graf**
> "“More funding will allow us to take care of our police forces. It is quite a simple choice, given the current status of the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“I agree with Ciara. What would people think of us if we fund the police after all that happened?”"]** — Mówca: **Player**
> "“I agree with Ciara. What would people think of us if we fund the police after all that happened?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
> "“We have just started a new analysis on what would happen if a pandemic struck Sordland. According to the results, if our healthcare facilities remain in their current state, the death toll would be unimaginable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
> "“This is a matter of life and death, Mr. President and it should be treated as such.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“We need to follow through with our promise to the people.”"]** — Mówca: **Player**
> "“We need to follow through with our promise to the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
> "“I'm not even talking about the damage to the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“That is indeed worrying. We should try to fix whatever we can as the government.”"]** — Mówca: **Player**
> "“That is indeed worrying. We should try to fix whatever we can as the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“That is only *if* a pandemic happens.”"]** — Mówca: **Player**
> "“That is only *if* a pandemic happens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“We need to improve our healthcare. What else are we here for if we can't keep our people alive?”"]** — Mówca: **Player**
> "“We need to improve our healthcare. What else are we here for if we can't keep our people alive?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“What is there to hear about? I already voiced my opinions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Iosef Lancea**
> "“Rumburg is coming whether we like it or not. If not this year, next year. If not next year, the year after that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Iosef Lancea**
> "“Mr. President. You and I have a shared responsibility to protect this nation from its enemies and I intend to do so until my last breath.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Iosef Lancea**
> "“There can be no argument against increasing the budget for our army when there is an enemy on our doorstep, waiting for us to make one wrong move! Anyone who thinks otherwise is a fool!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Iosef Lancea**
> "“I will say this with certainty. If Rumburg doesn't make a move against Sordland in 2 or 3 years, my name is not Iosef Lancea!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“Right. Pardon my theatrics, sir. But this is a serious matter. The future of our country is up to you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[140]`
Mówca: **Ciara Walda**
> "“The issues with Rumburg can be solved diplomatically. What kind of a message are we sending to them and the whole world if we suddenly start ramping up our military budget?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Iosef was beginning to lose control of the volume of his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[142]`
Mówca: **Iosef Lancea**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“People elected us for a reason. We will answer their needs.”"]** — Mówca: **Player**
> "“People elected us for a reason. We will answer their needs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "“I agree with Iosef. Rumburg is a real threat and we need to be ready.”"]** — Mówca: **Player**
> "“I agree with Iosef. Rumburg is a real threat and we need to be ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“I agree with Ciara. We need to be as diplomatic as possible.”"]** — Mówca: **Player**
> "“I agree with Ciara. We need to be as diplomatic as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“There are other more important avenues that our money can be better spent on.”"]** — Mówca: **Player**
> "“There are other more important avenues that our money can be better spent on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[147]`
Mówca: **Ciara Walda**
> "“We need to ensure the new generation is as well educated as their counterparts in more modern countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[148]`
Mówca: **Ciara Walda**
> "“To be honest, Sordland is lacking compared to Arcasia and United Contana when it comes to education levels. The backbone of any country is its people, and we need to protect our future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[149]`
Mówca: **Lileas Graf**
> "“We won't be compared to other countries. Sordland is Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“You are right Lucian. We can't let people down.”"]** — Mówca: **Player**
> "“You are right Lucian. We can't let people down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Lileas is right. We will pave our own path. We didn't get this far by imitating Arcasia or United Contana.”"]** — Mówca: **Player**
> "“Lileas is right. We will pave our own path. We didn't get this far by imitating Arcasia or United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I agree with Ciara. It is high time we invest in education and enact reforms.”"]** — Mówca: **Player**
> "“I agree with Ciara. It is high time we invest in education and enact reforms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[154]`
Mówca: **Symon Holl**
> "“Very good talking points from everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Symon Holl**
> "“Well then...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Symon placed a stack of papers on my table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Symon Holl**
> "“Consider it with care, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[158]`
Mówca: **Narrator**
> "I turned the first page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[159]`
Mówca: **Symon Holl**
> "“As we manage the government budget, we can to go into debt to invest in different branches.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[160]`
Mówca: **Symon Holl**
> "“Before we begin our discussion, there is one more thing that I want to voice my opinion on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“This budget will also be applicable to our entire term. It is very critical that we plan correctly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[162]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[164]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[167]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[170]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“Before we begin, is nobody going to mention the ban on the Red Youth?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[172]`
Mówca: **Nia Morgna**
> "“Before we begin, is nobody going to mention the ban on the Young Sords?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Lileas Graf**
> "“Did you just roll your eyes at me, young lady?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[174]`
Mówca: **Nia Morgna**
> ""However much their political aims might differ from our administration's, surely you must agree that freedom of expression must be protected at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[175]`
Mówca: **Nia Morgna**
> ""However much their political aims might differ from our administration's, surely you must agree that freedom of expression must be protected at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[176]`
Mówca: **Ciara Walda**
> "“*If* I did, it's because religion has no place at a government budget meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“Please leave your religion at the Maroon Palace gates, Ms. Graf.""]** — Mówca: **Player**
> "“Please leave your religion at the Maroon Palace gates, Ms. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "“If you have problems with the ban, call a separate meeting with me.""]** — Mówca: **Player**
> "“If you have problems with the ban, call a separate meeting with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""The ban is final. Don't question it any further.""]** — Mówca: **Player**
> ""The ban is final. Don't question it any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[180]`
Mówca: **Ciara Walda**
> ""Yes, and may I just add that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
> ""Nia-- I mean, Ms. Morgna -- is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[182]`
Mówca: **Lileas Graf**
> "“I was merely expressing my wishes for a successful trade deal. Freedom of expression must be protected at all costs, must it not, Ms. Morgna?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[183]`
Mówca: **Narrator**
> "Ciara gave a barely disguised eye roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Nia flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Nia Morgna**
> "“Thank you for bringing that up, Cia-- Ms. Walda. I agree that however much the Red Youth's political aims might differ from our administration's, freedom of expression must be protected at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[186]`
Mówca: **Narrator**
> "She broke off as she noticed that Lucian, Symon and Iosef were looking at her and Nia in stony silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""Ladies. Let's leave the extraneous chit-chat for afternoon tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Ciara shot a pleading look at Lileas, who merely pursed her lips disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[178]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Nia flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Ciara Walda**
> ""I myself strongly disagree with the Young Sords' politics, but even I believe that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[191]`
Mówca: **Nia Morgna**
> "“Before we begin, is nobody going to mention the ban on the Red Youth and Young Sords?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[192]`
Mówca: **Ciara Walda**
> ""Nia-- I mean, Ms. Morgna -- is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Narrator**
> "Nia flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Ciara Walda**
> ""I myself align far closer to the Red Youth's politics than the Young Sords' but I believe that both--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[195]`
Mówca: **Nia Morgna**
> ""Actually, in this case I agree with Cia-- Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Ciara flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Nia Morgna**
> ""According to Sordland's laws regarding the separation of Sanctuary and state--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Narrator**
> "She broke off as she noticed that Symon, Lucian and Iosef were looking at the three female ministers in stony silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Ladies. Let's leave the extraneous chit-chat for afternoon tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[200]`
  - -> `[204]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""The Lord is always welcome in these halls, Ms. Walda.""]** — Mówca: **Player**
> ""The Lord is always welcome in these halls, Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Symon started loudly shuffling some documents around. All eyes turned to the Minister of Economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[118]`

### Węzeł `[202]`
Mówca: **Narrator**
> "Nia cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Lileas was about to utter a word but a loud cough from Symon interrupted the silence in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I refrained from making a comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We should spend as much as possible to achieve growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our administration should be fiscally conservative to avoid a crash.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“A stimulating strategy could have positive political effects with increased support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“Measures of austerity have shown difficulties in appeasing voter groups.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[209]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Budget");)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Budget");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `27` (*Sordland/Turn03/Budget Feedback*), Węzeł `[1]`

### Węzeł `[210]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "“I have made up my mind about the budget. We can proceed.”"]** — Mówca: **Player**
> "“I have made up my mind about the budget. We can proceed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
