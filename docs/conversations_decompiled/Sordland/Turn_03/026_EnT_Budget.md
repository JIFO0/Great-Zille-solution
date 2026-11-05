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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“Let's begin, Mr. Holl.”"** | `[201]` **Narrator**: "Symon started loudly shuffling s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Symon Holl**: "“Gladly.”" |
| `[7]` | **"“Thanks to Symon's expertise, I am sure we will achieve lots of great things today.”"** | `[201]` **Narrator**: "Symon started loudly shuffling s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Symon Holl**: "“Thank you for the compliment.”" |
| `[16]` | **"“We should prioritise the most critical branches.”"** | `[3]` **Symon Holl**: "“We have to be careful as to wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Symon Holl**: "“Agreed, we have to make strateg..." |
| `[18]` | **"“Reduction of funding in certain branches can help fund investment projects.”"** | `[3]` **Symon Holl**: "“We have to be careful as to wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Symon Holl**: "“Yes. The bigger our budget surp..." |
| `[20]` | **"“We have to keep true to the election promises. Our people voted for us because of..."** | `[3]` **Symon Holl**: "“We have to be careful as to wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Symon Holl**: "“As much as we realistically can..." |
| `[26]` | **"“I would like to use this opportunity for a statement.”"** | `[25]` **Narrator**: "Nearly half a year had passed si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Lucian Galade**: "“Of course, sir.”" |
| `[27]` | **"“And now, the moment we've all been waiting for. It's finally time to discuss the ..."** | `[25]` **Narrator**: "Nearly half a year had passed si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Symon Holl**: "“I'm quivering in my loafers wit..." |
| `[28]` | **"“Welcome, everybody. Great to see you.”"** | `[25]` **Narrator**: "Nearly half a year had passed si..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lileas Graf**: "“Hello.”" |
| `[33]` | **"“Six months ago, all of us gathered to change the course of history. Now I'm proud..."** | `[32]` **Lucian Galade**: "“Of course, sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "The ministers appeared energized..." |
| `[34]` | **"“We are doing great work, and this is just the beginning. There will be many more ..."** | `[32]` **Lucian Galade**: "“Of course, sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "The ministers looked somewhat mo..." |
| `[35]` | **"“Each and every one of you is very capable, but it's what we do as a team that cou..."** | `[32]` **Lucian Galade**: "“Of course, sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "The ministers weren't as motivat..." |
| `[51]` | **"“Let's talk about healthcare.”"** | `[50]` **Symon Holl**: "“Which branch should we discuss ..."<br>`[150]` **Player**: "“You are right Lucian. We can't ..."<br>*(oraz 15 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == false` | *Brak zmian stanu* | `[72]` **Paskal Beniwoll**: "“Our healthcare system is vast, ..." |
| `[52]` | **"“It's time to hear the opinions on the military.”"** | `[50]` **Symon Holl**: "“Which branch should we discuss ..."<br>`[150]` **Player**: "“You are right Lucian. We can't ..."<br>*(oraz 15 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == false` | *Brak zmian stanu* | `[133]` **Iosef Lancea**: "“What is there to hear about? I ..." |
| `[53]` | **"“Let's discuss law enforcement.”"** | `[50]` **Symon Holl**: "“Which branch should we discuss ..."<br>`[150]` **Player**: "“You are right Lucian. We can't ..."<br>*(oraz 15 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == false` | *Brak zmian stanu* | `[23]` **Lileas Graf**: "“I would like to have an increas..." |
| `[54]` | **"“What about education?”"** | `[50]` **Symon Holl**: "“Which branch should we discuss ..."<br>`[150]` **Player**: "“You are right Lucian. We can't ..."<br>*(oraz 15 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == false` | *Brak zmian stanu* | `[76]` **Ciara Walda**: "“Our education system is lacking..." |
| `[86]` | **"“Moving away from big government is the right choice.”"** | `[89]` **Symon Holl**: "“Increasing will result in an im..." | `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true` | *Brak zmian stanu* | `[115]` **Lileas Graf**: "“Well, the state provides many s..." |
| `[87]` | **"“The problem isn't the amount of money spent. It's how efficiently we spend it.”"** | `[89]` **Symon Holl**: "“Increasing will result in an im..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Ciara Walda**: "“It's true that many of our poli..." |
| `[88]` | **"“Can we rely on the private sector to support us?”"** | `[89]` **Symon Holl**: "“Increasing will result in an im..." | `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true` | *Brak zmian stanu* | `[90]` **Symon Holl**: "“I'm sure we can do that to a ce..." |
| `[107]` | **"“Is it possible to maintain as much state control as possible?”"** | `[89]` **Symon Holl**: "“Increasing will result in an im..." | `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false` | *Brak zmian stanu* | `[108]` **Symon Holl**: "“In the health and education dep..." |
| `[118]` | **"Nod at Symon."** | `[201]` **Narrator**: "Symon started loudly shuffling s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Symon Holl**: "“Today is a big day. We must pri..." |
| `[119]` | **"“I agree with Lileas. If this was another time, I would've said something differen..."** | `[67]` **Lucian Galade**: "“I must also remind you that we ..."<br>`[124]` **Lileas Graf**: "“More funding will allow us to t..." | `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforce...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[120]` | **"“I agree with Nia. We need real solutions for real problems like corruption.”"** | `[67]` **Lucian Galade**: "“I must also remind you that we ..."<br>`[124]` **Lileas Graf**: "“More funding will allow us to t..." | `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforce...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[122]` | **"“I agree with Lucian. We can't just go back on our promise to the people.”"** | `[67]` **Lucian Galade**: "“I must also remind you that we ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforce...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[125]` | **"“I agree with Ciara. What would people think of us if we fund the police after all..."** | `[67]` **Lucian Galade**: "“I must also remind you that we ..."<br>`[124]` **Lileas Graf**: "“More funding will allow us to t..." | `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforce...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[128]` | **"“We need to follow through with our promise to the people.”"** | `[70]` **Lucian Galade**: "“Very worrying. On top of what P..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[130]` | **"“That is indeed worrying. We should try to fix whatever we can as the government.”"** | `[70]` **Lucian Galade**: "“Very worrying. On top of what P..."<br>`[127]` **Paskal Beniwoll**: "“This is a matter of life and de..." | `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[131]` | **"“That is only *if* a pandemic happens.”"** | `[70]` **Lucian Galade**: "“Very worrying. On top of what P..."<br>`[127]` **Paskal Beniwoll**: "“This is a matter of life and de..." | `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[132]` | **"“We need to improve our healthcare. What else are we here for if we can't keep our..."** | `[70]` **Lucian Galade**: "“Very worrying. On top of what P..."<br>`[127]` **Paskal Beniwoll**: "“This is a matter of life and de..." | `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[143]` | **"“People elected us for a reason. We will answer their needs.”"** | `[17]` **Lucian Galade**: "“One of the reasons our governme..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"]...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[144]` | **"“I agree with Iosef. Rumburg is a real threat and we need to be ready.”"** | `[17]` **Lucian Galade**: "“One of the reasons our governme..."<br>`[142]` **Iosef Lancea**: "“Exactly.”" | `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"]...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[145]` | **"“I agree with Ciara. We need to be as diplomatic as possible.”"** | `[17]` **Lucian Galade**: "“One of the reasons our governme..."<br>`[142]` **Iosef Lancea**: "“Exactly.”" | `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"]...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[146]` | **"“There are other more important avenues that our money can be better spent on.”"** | `[17]` **Lucian Galade**: "“One of the reasons our governme..."<br>`[142]` **Iosef Lancea**: "“Exactly.”" | `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"]...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[150]` | **"“You are right Lucian. We can't let people down.”"** | `[82]` **Lucian Galade**: "“I must also remind you that we ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[151]` | **"“Lileas is right. We will pave our own path. We didn't get this far by imitating A..."** | `[82]` **Lucian Galade**: "“I must also remind you that we ..."<br>`[83]` **Iosef Lancea**: "“I agree with Lileas. Sordland i..." | `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[152]` | **"“I agree with Ciara. It is high time we invest in education and enact reforms.”"** | `[82]` **Lucian Galade**: "“I must also remind you that we ..."<br>`[83]` **Iosef Lancea**: "“I agree with Lileas. Sordland i..." | `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[153]` | **"“I will think about it.”"** | `[82]` **Lucian Galade**: "“I must also remind you that we ..."<br>`[83]` **Iosef Lancea**: "“I agree with Lileas. Sordland i..." | `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false` | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"...` | `[51]` **Player**: "“Let's talk about healthcare.”"<br>`[53]` **Player**: "“Let's discuss law enforcement.”"<br>*(oraz 3 innych odgałęzień)* |
| `[177]` | **"“Please leave your religion at the Maroon Palace gates, Ms. Graf.""** | `[199]` **Lucian Galade**: ""Ladies. Let's leave the extrane..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Narrator**: "Lileas was about to utter a word..." |
| `[178]` | **"“If you have problems with the ban, call a separate meeting with me.""** | `[188]` **Narrator**: "Ciara shot a pleading look at Li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "Symon started loudly shuffling s..." |
| `[179]` | **""The ban is final. Don't question it any further.""** | `[188]` **Narrator**: "Ciara shot a pleading look at Li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "Symon started loudly shuffling s..." |
| `[200]` | **""The Lord is always welcome in these halls, Ms. Walda.""** | `[199]` **Lucian Galade**: ""Ladies. Let's leave the extrane..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "Symon started loudly shuffling s..." |
| `[204]` | **"Don't comment."** | `[199]` **Lucian Galade**: ""Ladies. Let's leave the extrane..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Narrator**: "Symon started loudly shuffling s..." |
| `[205]` | **"“We should spend as much as possible to achieve growth.”"** | `[13]` **Symon Holl**: "“However, under these circumstan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Lucian Galade**: "“A stimulating strategy could ha..." |
| `[206]` | **"“Our administration should be fiscally conservative to avoid a crash.”"** | `[13]` **Symon Holl**: "“However, under these circumstan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Lucian Galade**: "“Measures of austerity have show..." |
| `[211]` | **"“I have made up my mind about the budget. We can proceed.”"** | `[50]` **Symon Holl**: "“Which branch should we discuss ..."<br>`[150]` **Player**: "“You are right Lucian. We can't ..."<br>*(oraz 15 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == true  or Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == true` | `Variable["GameCondition.Turn03_EnT_BudgetOne"] = true;` | `[154]` **Symon Holl**: "“Very good talking points from e..." |

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
  - -> `[24]` (*Narrator: "The preparations for the government budget were finished...."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
> "“We have to be careful as to what we fund so we have resources remaining for another investment project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“We should prioritise the most critical branches.”"*)
  - -> `[20]` (*Player: "“We have to keep true to the election promises. Our peopl..."*)
  - -> `[18]` (*Player: "“Reduction of funding in certain branches can help fund i..."*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“Today is a big day. We must prioritise our spending wisely in order to achieve the goals we set as a government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“While maintaining enough political support, If I may add..."*)

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“Agreed, we have to make strategic decisions about our budget since our resources are fairly limited.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Symon Holl: "“Before we begin our discussion, there is one more thing ..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Let's begin, Mr. Holl.”"]** — Mówca: **Player**
> "“Let's begin, Mr. Holl.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Symon Holl: "“Gladly.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Thanks to Symon's expertise, I am sure we will achieve lots of great things today.”"]** — Mówca: **Player**
> "“Thanks to Symon's expertise, I am sure we will achieve many great things today.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Symon Holl: "“Thank you for the compliment.”"*)

### Węzeł `[8]`
Mówca: **Symon Holl**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“Today is a big day. We must prioritise our spending wise..."*)

### Węzeł `[9]`
Mówca: **Symon Holl**
> "“Thank you for the compliment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“Today is a big day. We must prioritise our spending wise..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“One of the reasons our government was elected was becaus..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: "“I agree with Iosef. Rumburg is a real threat and we need..."*)
  - -> `[145]` (*Player: "“I agree with Ciara. We need to be as diplomatic as possi..."*)
  - -> `[146]` (*Player: "“There are other more important avenues that our money ca..."*)

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“However, under these circumstances, it would worsen the economic crisis if we push it too far. It’s difficult for us to raise debt with the current unhealthy economy, but we can increase the amount of debt we can take as the economy improves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: "“We should spend as much as possible to achieve growth.”"*)
  - -> `[206]` (*Player: "“Our administration should be fiscally conservative to av..."*)

### Węzeł `[14]`
Mówca: **Symon Holl**
> "“As much as we realistically can. If we fail at improving our economy, the promises don't mean much in the big picture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Symon Holl: "“Before we begin our discussion, there is one more thing ..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“While maintaining enough political support, If I may add. Promises were made during the election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Symon Holl: "“There are three options regarding the budgeting of the f..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“We should prioritise the most critical branches.”"]** — Mówca: **Player**
> "“We should prioritise the most critical branches.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Symon Holl: "“Agreed, we have to make strategic decisions about our bu..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“One of the reasons our government was elected was because we promised that we are going to focus on the military during our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "“People elected us for a reason. We will answer their nee..."*)
  - -> `[144]` (*Player: "“I agree with Iosef. Rumburg is a real threat and we need..."*)
  - -> `[145]` (*Player: "“I agree with Ciara. We need to be as diplomatic as possi..."*)
  - -> `[146]` (*Player: "“There are other more important avenues that our money ca..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Reduction of funding in certain branches can help fund investment projects.”"]** — Mówca: **Player**
> "“Reduction of funding in certain branches can help fund investment projects.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“Yes. The bigger our budget surplus is the more we can sp..."*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“Yes. The bigger our budget surplus is the more we can spend on reviving the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Symon Holl: "“Before we begin our discussion, there is one more thing ..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“We have to keep true to the election promises. Our people voted for us because of the promises we made.”"]** — Mówca: **Player**
> "“We have to keep true to the election promises. Our people voted for us because of the promises we made.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Symon Holl: "“As much as we realistically can. If we fail at improving..."*)

### Węzeł `[21]`
Mówca: **Nia Morgna**
> "“Law enforcement is certainly a high priority. However, I feel tackling internal corruption is of far higher importance than increasing our police presence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Nia Morgna: "“Directing the funds to my department would solve the pro..."*)

### Węzeł `[22]`
Mówca: **Lileas Graf**
> "“We have so many internal threats to tackle and I'm already stretching my units far too thin with the limited resources allocated to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Nia cleared her throat."*)

### Węzeł `[23]`
Mówca: **Lileas Graf**
> "“I would like to have an increase in the funding of law enforcement to increase the size of the police force and raise salaries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lileas Graf: "“We have so many internal threats to tackle and I'm alrea..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The preparations for the government budget were finished. Most of the cabinet gathered in the White Room for the important occasion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Nearly half a year had passed since my inauguration. The ..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Nearly half a year had passed since my inauguration. The cabinet looked over-worked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“I would like to use this opportunity for a statement.”"*)
  - -> `[27]` (*Player: "“And now, the moment we've all been waiting for. It's fin..."*)
  - -> `[28]` (*Player: "“Welcome, everybody. Great to see you.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I would like to use this opportunity for a statement.”"]** — Mówca: **Player**
> "“I would like to use this opportunity for a statement.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: "“Of course, sir.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“And now, the moment we've all been waiting for. It's finally time to discuss the government budget.”"]** — Mówca: **Player**
> "“And now, the moment we've all been waiting for. It's finally time to discuss the government budget.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Symon Holl: "“I'm quivering in my loafers with excitement, Mr. Preside..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Welcome, everybody. Great to see you.”"]** — Mówca: **Player**
> "“Welcome, everybody. Great to see you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lileas Graf: "“Hello.”"*)

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“I'm quivering in my loafers with excitement, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't b..."*)

### Węzeł `[30]`
Mówca: **Lileas Graf**
> "“Hello.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Iosef Lancea: "“Mr. President.”"*)

### Węzeł `[31]`
Mówca: **Iosef Lancea**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't b..."*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Each and every one of you is very capable, but it's what..."*)
  - -> `[34]` (*Player: "“We are doing great work, and this is just the beginning...."*)
  - -> `[33]` (*Player: "“Six months ago, all of us gathered to change the course ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Six months ago, all of us gathered to change the course of history. Now I'm proud of what we've achieved and what is to come.”"]** — Mówca: **Player**
> "“Six months ago, all of us gathered to change the course of history. Now I'm proud of what we've achieved and what is to come.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "The ministers appeared energized by my statement."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We are doing great work, and this is just the beginning. There will be many more good things to come.”"]** — Mówca: **Player**
> "“We are doing great work, and this is just the beginning. There will be many more good things to come.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The ministers looked somewhat motivated by my statement."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Each and every one of you is very capable, but it's what we do as a team that counts.”"]** — Mówca: **Player**
> "“Each and every one of you is very capable, but it's what we do as a team that counts.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The ministers weren't as motivated by my statement as I h..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "The ministers weren't as motivated by my statement as I had hoped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“Thank you, sir. Moving on.”"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The ministers looked somewhat motivated by my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: "“Thank you, sir.”"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "The ministers appeared energized by my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""Much appreciated, sir.""*)

### Węzeł `[39]`
Mówca: **Lileas Graf**
> "“May the Lord be with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "Ciara gave a barely disguised eye roll."*)

### Węzeł `[40]`
Mówca: **Lucian Galade**
> "“Given the current state of the country, improving economic situation is a political priority right now. More so than ever, if we want to win the 58 election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Symon Holl: "“This budget will also be applicable to our entire term. ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“Very worrying. On top of what Paskal said, we need to re..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“That is indeed worrying. We should try to fix whatever w..."*)
  - -> `[131]` (*Player: "“That is only *if* a pandemic happens.”"*)
  - -> `[132]` (*Player: "“We need to improve our healthcare. What else are we here..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Much appreciated, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't b..."*)

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“Let's begin, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“Which branch should we discuss first?”"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Budget Branches`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Military == false"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education == false"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education == true ||..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“Let's discuss law enforcement.”"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“Which branch should we discuss first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "Budget Branches"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Let's talk about healthcare.”"]** — Mówca: **Player**
> "“Let's talk about healthcare.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[150]` (Player), `[151]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Paskal Beniwoll: "“Our healthcare system is vast, and provides free service..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's time to hear the opinions on the military.”"]** — Mówca: **Player**
> "“It's time to hear the opinions on the military.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[150]` (Player), `[151]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Iosef Lancea: "“What is there to hear about? I already voiced my opinions.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Let's discuss law enforcement.”"]** — Mówca: **Player**
> "“Let's discuss law enforcement.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[150]` (Player), `[151]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lileas Graf: "“I would like to have an increase in the funding of law e..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“What about education?”"]** — Mówca: **Player**
> "“What about education?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[150]` (Player), `[151]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Ciara Walda: "“Our education system is lacking. Not only in funding but..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Military == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Military == false"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Listened_Military == false)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Military == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“It's time to hear the opinions on the military.”"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Listened_Military == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Education == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education == false"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Listened_Education == false)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Education == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“What about education?”"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Listened_Education == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Let's talk about healthcare.”"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Listened_Healthcare == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Security == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“I must also remind you that we promised to focus on secu..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“I agree with Lileas. If this was another time, I would'v..."*)
  - -> `[120]` (*Player: "“I agree with Nia. We need real solutions for real proble..."*)
  - -> `[125]` (*Player: "“I agree with Ciara. What would people think of us if we ..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“I must also remind you that we promised to focus on security and law enforcement during our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "“I agree with Lucian. We can't just go back on our promis..."*)
  - -> `[119]` (*Player: "“I agree with Lileas. If this was another time, I would'v..."*)
  - -> `[120]` (*Player: "“I agree with Nia. We need real solutions for real proble..."*)
  - -> `[125]` (*Player: "“I agree with Ciara. What would people think of us if we ..."*)

### Węzeł `[68]`
Mówca: **Lileas Graf**
> "“That we are ready to defend our nation, Ms. Walda.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Iosef Lancea: "“Exactly.”"*)

### Węzeł `[69]`
Mówca: **Ciara Walda**
> "“Well, here is an argument. The Armed Forces does nothing but eat away financial resources destined for our people while stoking fears for an upcoming *war*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ciara Walda: "“The issues with Rumburg can be solved diplomatically. Wh..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“Very worrying. On top of what Paskal said, we need to remember that we promised to focus on healthcare during our election campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: "“We need to follow through with our promise to the people.”"*)
  - -> `[130]` (*Player: "“That is indeed worrying. We should try to fix whatever w..."*)
  - -> `[131]` (*Player: "“That is only *if* a pandemic happens.”"*)
  - -> `[132]` (*Player: "“We need to improve our healthcare. What else are we here..."*)

### Węzeł `[71]`
Mówca: **Ciara Walda**
> "“I agree with Ms. Morgna. We should not reward a structure that is responsible for an ever-increasing number of human rights violations. Additionally, corruption is the reason of our government inefficiencies. It needs to be tackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lileas Graf: "“The police are there to serve and protect the people of ..."*)

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
> "“Our healthcare system is vast, and provides free services to most of our citizens. However, the quality of our health services is far worse in low-income and rural areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Paskal Beniwoll: "“Therefore, I think that we should receive more funding t..."*)

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
> "“Therefore, I think that we should receive more funding to address this disparity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Ciara Walda: "“I agree. I have recently begun an investigation into hea..."*)

### Węzeł `[74]`
Mówca: **Ciara Walda**
> "“I agree. I have recently begun an investigation into healthcare in Narbel, and the numbers are not good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Paskal Beniwoll: "“If we don't increase spending on health services, we at ..."*)

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
> "“If we don't increase spending on health services, we at least need to maintain it. Otherwise, we are putting lives at risk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Paskal Beniwoll: "“We have just started a new analysis on what would happen..."*)

### Węzeł `[76]`
Mówca: **Ciara Walda**
> "“Our education system is lacking. Not only in funding but also in modern curricular principles. Our outdated curriculum is wasting our youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ciara Walda: "“That is the reason why I advocate two things. An increas..."*)

### Węzeł `[77]`
Mówca: **Lileas Graf**
> "“Nonsense. Sordland is still here because of this very system that you insult. How can you insult a system that teaches our sons and daughters the principles of national identity and pride?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lileas Graf: "“We won't be compared to other countries. Sordland is Sor..."*)

### Węzeł `[78]`
Mówca: **Ciara Walda**
> "“That is the reason why I advocate two things. An increase of the budget to improve access to education in rural areas, and a new education reform.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Ciara Walda: "“To be honest, Sordland is lacking compared to Arcasia an..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: "“I must also remind you that we promised that we were goi..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“Lileas is right. We will pave our own path. We didn't ge..."*)
  - -> `[152]` (*Player: "“I agree with Ciara. It is high time we invest in educati..."*)
  - -> `[153]` (*Player: "“I will think about it.”"*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“I must also remind you that we promised that we were going to focus on education during our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“You are right Lucian. We can't let people down.”"*)
  - -> `[151]` (*Player: "“Lileas is right. We will pave our own path. We didn't ge..."*)
  - -> `[152]` (*Player: "“I agree with Ciara. It is high time we invest in educati..."*)
  - -> `[153]` (*Player: "“I will think about it.”"*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“I agree with Lileas. Sordland is Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_EnT_BudgetOne = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_EnT_BudgetOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Symon Holl: "“Very good talking points from everyone.”"*)

### Węzeł `[85]`
Mówca: **Symon Holl**
> "“There are three options regarding the budgeting of the four main branches of the government. It's either we increase, maintain or decrease the funding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Symon Holl: "“Increasing will result in an improvement of the branch w..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Moving away from big government is the right choice.”"]** — Mówca: **Player**
> "“Moving away from big government is the right choice.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lileas Graf: "“Well, the state provides many services that our citizens..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“The problem isn't the amount of money spent. It's how efficiently we spend it.”"]** — Mówca: **Player**
> "“The problem isn't the amount of money spent. It's how efficiently we spend it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Ciara Walda: "“It's true that many of our policies could be far better ..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Can we rely on the private sector to support us?”"]** — Mówca: **Player**
> "“Can we rely on the private sector to support us?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Symon Holl: "“I'm sure we can do that to a certain extent in some bran..."*)

### Węzeł `[89]`
Mówca: **Symon Holl**
> "“Increasing will result in an improvement of the branch which will unlock new policy options. Maintaining will keep the funding, resulting in no visible change. Decreasing causes a loss of efficiency in that branch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[87]` (*Player: "“The problem isn't the amount of money spent. It's how ef..."*)

### Węzeł `[90]`
Mówca: **Symon Holl**
> "“I'm sure we can do that to a certain extent in some branches, like education and health.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Ciara Walda: "“Our universal healthcare system must be protected and no..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't be attending this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lucian Galade: "“They are working on the upcoming trade agreements with W..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Budget Branches]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "Budget Branches"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Education == true || BaseGameIsolated.Turn03_EnT_Listened_Healthcare == true || BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == true ||BaseGameIsolated.Turn03_EnT_Listened_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education == true ||..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Listened_Education == true ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Education == true || BaseGameIsolated.Turn03_EnT_Listened_Healthcare == true || BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == true ||BaseGameIsolated.Turn03_EnT_Listened_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == true  or Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: "“I have made up my mind about the budget. We can proceed.”"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Listened_Education == true || BaseGameIsolated.Turn03_EnT_Listened_Healthcare == true || BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement == true ||BaseGameIsolated.Turn03_EnT_Listened_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == true  or Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Healthcare = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "Jump to: [Budget Branches]"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "Jump to: [Budget Branches]"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Military = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "Jump to: [Budget Branches]"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Listened_Education = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "Jump to: [Budget Branches]"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Budget Branches]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "Budget Branches"*)

### Węzeł `[101]`
Mówca: **Symon Holl**
> "“...The time to make a decision on the budget has come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Symon Holl: "“Consider it with care, Mr. President.”"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Budget Branches]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "Budget Branches"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Budget Branches]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "Budget Branches"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“Can we rely on the private sector to support us?”"*)
  - -> `[86]` (*Player: "“Moving away from big government is the right choice.”"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“Is it possible to maintain as much state control as poss..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Is it possible to maintain as much state control as possible?”"]** — Mówca: **Player**
> "“Is it possible to maintain as much state control as possible?”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Symon Holl: "“In the health and education departments, yes. However I ..."*)

### Węzeł `[108]`
Mówca: **Symon Holl**
> "“In the health and education departments, yes. However I am not sure if that would be efficient.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Ciara Walda: "“Our universal healthcare system must be protected and no..."*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“Thank you, sir. Moving on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't b..."*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“Sadly, Petr Vectern, Gus Manger and Deivid Wisci won't b..."*)

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
> "“Our welfare systems are full of issues that need to be addressed, for instance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Symon Holl: "“We have to be careful as to what we fund so we have reso..."*)

### Węzeł `[112]`
Mówca: **Ciara Walda**
> "“It's true that many of our policies could be far better implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Paskal Beniwoll: "“Our welfare systems are full of issues that need to be a..."*)

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
> "“We need to be considerate when making such grand choices that have ripple effects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Symon Holl: "“We have to be careful as to what we fund so we have reso..."*)

### Węzeł `[114]`
Mówca: **Ciara Walda**
> "“Our universal healthcare system must be protected and not be tainted by private greed or interest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Paskal Beniwoll: "“We need to be considerate when making such grand choices..."*)

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“Well, the state provides many services that our citizens pay for with their taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Ciara Walda: "“I agree. Our essential services should remain under our ..."*)

### Węzeł `[116]`
Mówca: **Ciara Walda**
> "“I agree. Our essential services should remain under our authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Symon Holl: "“We have to be careful as to what we fund so we have reso..."*)

### Węzeł `[117]`
Mówca: **Lucian Galade**
> "“They are working on the upcoming trade agreements with Wehlen and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lileas Graf: "“May the Lord be with them.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "Nod at Symon."]** — Mówca: **Player_Italic**
> "I nodded at Symon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“Today is a big day. We must prioritise our spending wise..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I agree with Lileas. If this was another time, I would've said something different but we know the current situation.”"]** — Mówca: **Player**
> "“I agree with Lileas. If this was another time, I would've said something different but we know the current situation.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade), `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement = true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I agree with Nia. We need real solutions for real problems like corruption.”"]** — Mówca: **Player**
> "“I agree with Nia. We need real solutions for real problems like corruption.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade), `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement = true"*)

### Węzeł `[121]`
Mówca: **Nia Morgna**
> "“Directing the funds to my department would solve the problem at its root. If corruption is still rampant, all the police in the world won't help us. We need a specialized Anti-Corruption Police unit which we could create if the funds were directed to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Ciara Walda: "“I agree with Ms. Morgna. We should not reward a structur..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I agree with Lucian. We can't just go back on our promise to the people.”"]** — Mówca: **Player**
> "“I agree with Lucian. We can't just go back on our promise to the people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement = true"*)

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“The police are there to serve and protect the people of Sordland, Ms. Walda and that is exactly what we were doing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lileas Graf: "“More funding will allow us to take care of our police fo..."*)

### Węzeł `[124]`
Mówca: **Lileas Graf**
> "“More funding will allow us to take care of our police forces. It is quite a simple choice, given the current status of the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“I agree with Ciara. What would people think of us if we fund the police after all that happened?”"]** — Mówca: **Player**
> "“I agree with Ciara. What would people think of us if we fund the police after all that happened?”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade), `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement = true"*)

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
> "“We have just started a new analysis on what would happen if a pandemic struck Sordland. According to the results, if our healthcare facilities remain in their current state, the death toll would be unimaginable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Paskal Beniwoll: "“I'm not even talking about the damage to the economy.”"*)

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
> "“This is a matter of life and death, Mr. President and it should be treated as such.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“We need to follow through with our promise to the people.”"]** — Mówca: **Player**
> "“We need to follow through with our promise to the people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Healthcare = true"*)

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
> "“I'm not even talking about the damage to the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Paskal Beniwoll: "“This is a matter of life and death, Mr. President and it..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“That is indeed worrying. We should try to fix whatever we can as the government.”"]** — Mówca: **Player**
> "“That is indeed worrying. We should try to fix whatever we can as the government.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade), `[127]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Healthcare = true"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“That is only *if* a pandemic happens.”"]** — Mówca: **Player**
> "“That is only *if* a pandemic happens.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade), `[127]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Healthcare = true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“We need to improve our healthcare. What else are we here for if we can't keep our people alive?”"]** — Mówca: **Player**
> "“We need to improve our healthcare. What else are we here for if we can't keep our people alive?”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade), `[127]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Healthcare = true"*)

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“What is there to hear about? I already voiced my opinions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Iosef Lancea: "“Rumburg is coming whether we like it or not. If not this..."*)

### Węzeł `[134]`
Mówca: **Iosef Lancea**
> "“Rumburg is coming whether we like it or not. If not this year, next year. If not next year, the year after that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Iosef Lancea: "“Mr. President. You and I have a shared responsibility to..."*)

### Węzeł `[135]`
Mówca: **Iosef Lancea**
> "“Mr. President. You and I have a shared responsibility to protect this nation from its enemies and I intend to do so until my last breath.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Iosef Lancea: "“I will say this with certainty. If Rumburg doesn't make ..."*)

### Węzeł `[136]`
Mówca: **Iosef Lancea**
> "“There can be no argument against increasing the budget for our army when there is an enemy on our doorstep, waiting for us to make one wrong move! Anyone who thinks otherwise is a fool!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“Mr. Lancea.”"*)

### Węzeł `[137]`
Mówca: **Iosef Lancea**
> "“I will say this with certainty. If Rumburg doesn't make a move against Sordland in 2 or 3 years, my name is not Iosef Lancea!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Iosef was beginning to lose control of the volume of his ..."*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Iosef Lancea: "“Right. Pardon my theatrics, sir. But this is a serious m..."*)

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“Right. Pardon my theatrics, sir. But this is a serious matter. The future of our country is up to you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Ciara Walda: "“Well, here is an argument. The Armed Forces does nothing..."*)

### Węzeł `[140]`
Mówca: **Ciara Walda**
> "“The issues with Rumburg can be solved diplomatically. What kind of a message are we sending to them and the whole world if we suddenly start ramping up our military budget?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lileas Graf: "“That we are ready to defend our nation, Ms. Walda.”"*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Iosef was beginning to lose control of the volume of his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Iosef Lancea: "“There can be no argument against increasing the budget f..."*)

### Węzeł `[142]`
Mówca: **Iosef Lancea**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“People elected us for a reason. We will answer their needs.”"]** — Mówca: **Player**
> "“People elected us for a reason. We will answer their needs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Military = true"*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "“I agree with Iosef. Rumburg is a real threat and we need to be ready.”"]** — Mówca: **Player**
> "“I agree with Iosef. Rumburg is a real threat and we need to be ready.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade), `[142]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Military = true"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“I agree with Ciara. We need to be as diplomatic as possible.”"]** — Mówca: **Player**
> "“I agree with Ciara. We need to be as diplomatic as possible.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade), `[142]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Military = true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“There are other more important avenues that our money can be better spent on.”"]** — Mówca: **Player**
> "“There are other more important avenues that our money can be better spent on.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade), `[142]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Military = true"*)

### Węzeł `[147]`
Mówca: **Ciara Walda**
> "“We need to ensure the new generation is as well educated as their counterparts in more modern countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lileas Graf: "“Nonsense. Sordland is still here because of this very sy..."*)

### Węzeł `[148]`
Mówca: **Ciara Walda**
> "“To be honest, Sordland is lacking compared to Arcasia and United Contana when it comes to education levels. The backbone of any country is its people, and we need to protect our future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Ciara Walda: "“We need to ensure the new generation is as well educated..."*)

### Węzeł `[149]`
Mówca: **Lileas Graf**
> "“We won't be compared to other countries. Sordland is Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“I agree with Lileas. Sordland is Sordland!”"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“You are right Lucian. We can't let people down.”"]** — Mówca: **Player**
> "“You are right Lucian. We can't let people down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education = true"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Lileas is right. We will pave our own path. We didn't get this far by imitating Arcasia or United Contana.”"]** — Mówca: **Player**
> "“Lileas is right. We will pave our own path. We didn't get this far by imitating Arcasia or United Contana.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade), `[83]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education = true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I agree with Ciara. It is high time we invest in education and enact reforms.”"]** — Mówca: **Player**
> "“I agree with Ciara. It is high time we invest in education and enact reforms.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade), `[83]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education = true"*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Lucian Galade), `[83]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Listened_Education = true"*)

### Węzeł `[154]`
Mówca: **Symon Holl**
> "“Very good talking points from everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Symon Holl: "“Well then...”"*)

### Węzeł `[155]`
Mówca: **Symon Holl**
> "“Well then...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Symon Holl: "“...The time to make a decision on the budget has come.”"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Symon placed a stack of papers on my table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "I turned the first page."*)

### Węzeł `[157]`
Mówca: **Symon Holl**
> "“Consider it with care, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Symon placed a stack of papers on my table."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "I turned the first page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Budget");"*)

### Węzeł `[159]`
Mówca: **Symon Holl**
> "“As we manage the government budget, we can to go into debt to invest in different branches.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“However, under these circumstances, it would worsen the ..."*)

### Węzeł `[160]`
Mówca: **Symon Holl**
> "“Before we begin our discussion, there is one more thing that I want to voice my opinion on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Symon Holl: "“As we manage the government budget, we can to go into de..."*)

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“This budget will also be applicable to our entire term. It is very critical that we plan correctly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: "“Let's begin, then.”"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“Before we begin, is nobody going to mention the ban on t..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == ..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords =..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Nia Morgna: "“Before we begin, is nobody going to mention the ban on t..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Nia Morgna: "“Before we begin, is nobody going to mention the ban on t..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lileas Graf: "“Did you just roll your eyes at me, young lady?”"*)

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“Before we begin, is nobody going to mention the ban on the Red Youth?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Nia flashed her an appreciative smile."*)

### Węzeł `[172]`
Mówca: **Nia Morgna**
> "“Before we begin, is nobody going to mention the ban on the Young Sords?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Nia Morgna: ""However much their political aims might differ from our ..."*)

### Węzeł `[173]`
Mówca: **Lileas Graf**
> "“Did you just roll your eyes at me, young lady?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“*If* I did, it's because religion has no place at a gove..."*)

### Węzeł `[174]`
Mówca: **Nia Morgna**
> ""However much their political aims might differ from our administration's, surely you must agree that freedom of expression must be protected at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ciara Walda: ""Nia-- I mean, Ms. Morgna -- is right.""*)

### Węzeł `[175]`
Mówca: **Nia Morgna**
> ""However much their political aims might differ from our administration's, surely you must agree that freedom of expression must be protected at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Ciara Walda: ""Nia-- I mean, Ms. Morgna -- is right.""*)

### Węzeł `[176]`
Mówca: **Ciara Walda**
> "“*If* I did, it's because religion has no place at a government budget meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lileas Graf: "“I was merely expressing my wishes for a successful trade..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“Please leave your religion at the Maroon Palace gates, Ms. Graf.""]** — Mówca: **Player**
> "“Please leave your religion at the Maroon Palace gates, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Lileas was about to utter a word but a loud cough from Sy..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“If you have problems with the ban, call a separate meeting with me.""]** — Mówca: **Player**
> "“If you have problems with the ban, call a separate meeting with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Symon started loudly shuffling some documents around. All..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""The ban is final. Don't question it any further.""]** — Mówca: **Player**
> ""The ban is final. Don't question it any further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Symon started loudly shuffling some documents around. All..."*)

### Węzeł `[180]`
Mówca: **Ciara Walda**
> ""Yes, and may I just add that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "She broke off as she noticed that Lucian, Symon and Iosef..."*)

### Węzeł `[181]`
Mówca: **Ciara Walda**
> ""Nia-- I mean, Ms. Morgna -- is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Nia flashed her an appreciative smile."*)

### Węzeł `[182]`
Mówca: **Lileas Graf**
> "“I was merely expressing my wishes for a successful trade deal. Freedom of expression must be protected at all costs, must it not, Ms. Morgna?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Nia Morgna: ""Actually, in this case I agree with Cia-- Ms. Walda.""*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Ciara gave a barely disguised eye roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true"*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Nia flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Nia Morgna: "“Thank you for bringing that up, Cia-- Ms. Walda. I agree..."*)

### Węzeł `[185]`
Mówca: **Nia Morgna**
> "“Thank you for bringing that up, Cia-- Ms. Walda. I agree that however much the Red Youth's political aims might differ from our administration's, freedom of expression must be protected at all costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Ciara Walda: ""Yes, and may I just add that--""*)

### Węzeł `[186]`
Mówca: **Narrator**
> "She broke off as she noticed that Lucian, Symon and Iosef were looking at her and Nia in stony silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: ""Ladies. Let's leave the extraneous chit-chat for afterno..."*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""Ladies. Let's leave the extraneous chit-chat for afternoon tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Ciara shot a pleading look at Lileas, who merely pursed h..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Ciara shot a pleading look at Lileas, who merely pursed her lips disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""The ban is final. Don't question it any further.""*)
  - -> `[178]` (*Player: "“If you have problems with the ban, call a separate meeti..."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Nia flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Ciara Walda: ""I myself strongly disagree with the Young Sords' politic..."*)

### Węzeł `[190]`
Mówca: **Ciara Walda**
> ""I myself strongly disagree with the Young Sords' politics, but even I believe that--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "She broke off as she noticed that Lucian, Symon and Iosef..."*)

### Węzeł `[191]`
Mówca: **Nia Morgna**
> "“Before we begin, is nobody going to mention the ban on the Red Youth and Young Sords?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Nia Morgna: ""However much their political aims might differ from our ..."*)

### Węzeł `[192]`
Mówca: **Ciara Walda**
> ""Nia-- I mean, Ms. Morgna -- is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Nia flashed her an appreciative smile."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "Nia flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Ciara Walda: ""I myself align far closer to the Red Youth's politics th..."*)

### Węzeł `[194]`
Mówca: **Ciara Walda**
> ""I myself align far closer to the Red Youth's politics than the Young Sords' but I believe that both--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "She broke off as she noticed that Lucian, Symon and Iosef..."*)

### Węzeł `[195]`
Mówca: **Nia Morgna**
> ""Actually, in this case I agree with Cia-- Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Ciara flashed her an appreciative smile."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Ciara flashed her an appreciative smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Nia Morgna: ""According to Sordland's laws regarding the separation of..."*)

### Węzeł `[197]`
Mówca: **Nia Morgna**
> ""According to Sordland's laws regarding the separation of Sanctuary and state--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "She broke off as she noticed that Symon, Lucian and Iosef..."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "She broke off as she noticed that Symon, Lucian and Iosef were looking at the three female ministers in stony silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: ""Ladies. Let's leave the extraneous chit-chat for afterno..."*)

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Ladies. Let's leave the extraneous chit-chat for afternoon tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: "“Please leave your religion at the Maroon Palace gates, M..."*)
  - -> `[200]` (*Player: ""The Lord is always welcome in these halls, Ms. Walda.""*)
  - -> `[204]` (*Player_Italic: "Don't comment."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""The Lord is always welcome in these halls, Ms. Walda.""]** — Mówca: **Player**
> ""The Lord is always welcome in these halls, Ms. Walda.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Symon started loudly shuffling some documents around. All..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Symon started loudly shuffling some documents around. All eyes turned to the Minister of Economy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“Let's begin, Mr. Holl.”"*)
  - -> `[7]` (*Player: "“Thanks to Symon's expertise, I am sure we will achieve l..."*)
  - -> `[118]` (*Player_Italic: "Nod at Symon."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Nia cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Nia Morgna: "“Law enforcement is certainly a high priority. However, I..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Lileas was about to utter a word but a loud cough from Symon interrupted the silence in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Symon started loudly shuffling some documents around. All..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I refrained from making a comment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Symon started loudly shuffling some documents around. All..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We should spend as much as possible to achieve growth.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: "“A stimulating strategy could have positive political eff..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our administration should be fiscally conservative to avoid a crash.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: "“Measures of austerity have shown difficulties in appeasi..."*)

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“A stimulating strategy could have positive political effects with increased support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucian Galade: "“Given the current state of the country, improving econom..."*)

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“Measures of austerity have shown difficulties in appeasing voter groups.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucian Galade: "“Given the current state of the country, improving econom..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Budget");`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Budget");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "“I have made up my mind about the budget. We can proceed.”"]** — Mówca: **Player**
> "“I have made up my mind about the budget. We can proceed.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_EnT_Listened_Education"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_Healthcare"] == true  or  Variable["BaseGameIsolated.Turn03_EnT_Listened_LawEnforcement"] == true  or Variable["BaseGameIsolated.Turn03_EnT_Listened_Military"] == true`
- **Kontekst wejściowy (poprzednik):** `[50]` (Symon Holl), `[150]` (Player), `[151]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_EnT_BudgetOne = true"*)
