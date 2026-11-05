# Sordland/Turn10/Grander Plans

- **ID konwersacji:** `232`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/232_Grander_Plans.md`
- **Liczba węzłów dialogowych:** 132
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Enable_LateOpenHighway`
- `BaseGame.Enable_LateOpenRailway`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Situation_Welfare_HousingAssistance`
- `BaseGame.Situation_Welfare_UnemploymentWage`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_BasicIncomePromise`
- `BaseGameIsolated.Debate_NuclearPromise`
- `BaseGameIsolated.Debate_SpacePromise`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[233] Sordland/Turn10/Economy** (../Turn_10/233_Economy.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Just kidding. We have too many problems to solve here at home before we can think..."** | `[67]` **Narrator**: "The other candidates burst out l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Moderator**: ""Very well."" |
| `[18]` | **""Absolutely.""** | `[9]` **Moderator**: ""Mr. President, just prior to to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Moderator**: ""Would you like to tell us what ..." |
| `[25]` | **""We have an alliance. Aren't you supposed to be on my side?""** | `[54]` **Frens Ricter**: ""I agree, but you've already pro..."<br>`[55]` **Frens Ricter**: ""You're both mad. Disincentivizi..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Alliance_PFJP"] == true` | *Brak zmian stanu* | `[26]` **Frens Ricter**: ""Well, you didn't run this by me."" |
| `[30]` | **""Laugh all you want. I'm going to make it happen.""** | `[56]` **Manoly Suheil**: ""There are so many problems stil..."<br>`[82]` **Manoly Suheil**: ""Perhaps, but you've already pro..."<br>*(oraz 7 innych węzłów)* | `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false` | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[39]` | **""Citizens will still work. My plan will only ensure nobody has to go homeless.""** | `[7]` **Kesaro Kibener**: ""Each Sordish citizen wants to c..."<br>`[38]` **Manoly Suheil**: ""I've been pushing to include th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[41]` | **""Sordland must develop a nuclear arsenal.""** | `[88]` **Moderator**: ""Would you like to tell us what ..."<br>`[116]` **Moderator**: ""Please go on."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Debate_NuclearPromise"] = true;` | `[80]` **Narrator**: "The candidates around me gasped ..."<br>`[79]` **Narrator**: "The candidates around me gasped ..." |
| `[42]` | **""We will grant a basic living wage to every man and woman in Sordland. Unemployed ..."** | `[88]` **Moderator**: ""Would you like to tell us what ..."<br>`[116]` **Moderator**: ""Please go on."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] = ...` | `[78]` **Narrator**: "The candidates around me gasped ..."<br>`[105]` **Narrator**: "The candidates around me gasped ..." |
| `[43]` | **""I want Sordland to put a man on the moon.""** | `[88]` **Moderator**: ""Would you like to tell us what ..."<br>`[116]` **Moderator**: ""Please go on."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "The other candidates burst out l..." |
| `[74]` | **""I'm serious. Sordland is going into space.""** | `[67]` **Narrator**: "The other candidates burst out l..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Debate_SpacePromise"] = true;` | `[86]` **Lileas Graf**: ""You couldn't even open a railwa..." |
| `[87]` | **""No, that release was sent out in error. I'm keeping my plans modest.""** | `[9]` **Moderator**: ""Mr. President, just prior to to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Moderator**: ""Very well."" |
| `[89]` | **""You'll find out once I get re-elected.""** | `[88]` **Moderator**: ""Would you like to tell us what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Moderator**: ""Very well."" |
| `[91]` | **""With nuclear war an increasing possibility, survival on other planets is somethin..."** | `[54]` **Frens Ricter**: ""I agree, but you've already pro..."<br>`[56]` **Manoly Suheil**: ""There are so many problems stil..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[92]` | **""If we want to be taken seriously by the superpowers, this is the only way.""** | `[54]` **Frens Ricter**: ""I agree, but you've already pro..."<br>`[56]` **Manoly Suheil**: ""There are so many problems stil..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[93]` | **""A space program would create thousands of jobs while boosting our national morale.""** | `[56]` **Manoly Suheil**: ""There are so many problems stil..."<br>`[84]` **Lileas Graf**: ""You couldn't even open a highwa..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[100]` | **""Only via mutually assured destruction can we achieve peace with our enemies.""** | `[81]` **Frens Ricter**: ""You're insane. If we even attem..."<br>`[85]` **Manoly Suheil**: ""You're insane. If we even attem..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[101]` | **""A nuclear program would create thousands of jobs and boost national morale.""** | `[81]` **Frens Ricter**: ""You're insane. If we even attem..."<br>`[85]` **Manoly Suheil**: ""You're insane. If we even attem..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[107]` | **""With a guaranteed income, Sordish people will spend as never before. The economy ..."** | `[7]` **Kesaro Kibener**: ""Each Sordish citizen wants to c..."<br>`[38]` **Manoly Suheil**: ""I've been pushing to include th..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[108]` | **""By removing the bureaucracy associated with the welfare system, my plan will save..."** | `[7]` **Kesaro Kibener**: ""Each Sordish citizen wants to c..."<br>`[38]` **Manoly Suheil**: ""I've been pushing to include th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[115]` | **""Yes, and I can't wait to unveil them.""** | `[9]` **Moderator**: ""Mr. President, just prior to to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Moderator**: ""Please go on."" |
| `[120]` | **""My administration is already providing assistance to unemployed citizens. This is..."** | `[55]` **Frens Ricter**: ""You're both mad. Disincentivizi..."<br>`[130]` **Denis Stahler**: ""I don't believe a word of it."" | `Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true` | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[121]` | **""My administration is already providing housing assistance to low-income citizens...."** | `[55]` **Frens Ricter**: ""You're both mad. Disincentivizi..."<br>`[130]` **Denis Stahler**: ""I don't believe a word of it."" | `Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true`<br>`(Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true) == false` | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |
| `[125]` | **""You're supposed to be my ally, Kesaro.""** | `[7]` **Kesaro Kibener**: ""Each Sordish citizen wants to c..." | `Variable["BaseGame.Reform_Alliance_NFP"] == true` | *Brak zmian stanu* | `[126]` **Kesaro Kibener**: ""Well, you didn't run this by me."" |
| `[131]` | **""All I have in mind is Sordish people and Sordish people alone.""** | `[130]` **Denis Stahler**: ""I don't believe a word of it."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Moderator**: ""Very interesting."" |

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
  - -> `[9]` (*Moderator: ""Mr. President, just prior to tonight's debate your press..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Manoly Suheil: ""Perhaps, but you've already proven yourself incapable of..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Denis Stahler: ""There are so many problems still to be solved in Sordlan..."*)

### Węzeł `[6]`
Mówca: **Moderator**
> ""Very interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[7]`
Mówca: **Kesaro Kibener**
> ""Each Sordish citizen wants to contribute and work for their country. There is no need for such programs, the only necessity is opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""Citizens will still work. My plan will only ensure nobod..."*)
  - -> `[107]` (*Player: ""With a guaranteed income, Sordish people will spend as n..."*)
  - -> `[108]` (*Player: ""By removing the bureaucracy associated with the welfare ..."*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Just kidding. We have too many problems to solve here at home before we can think of entering the space race.""]** — Mówca: **Player**
> ""Just kidding. We have too many problems to solve here at home before we can think of entering the space race.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Moderator: ""Very well.""*)

### Węzeł `[9]`
Mówca: **Moderator**
> ""Mr. President, just prior to tonight's debate your press office signaled there could be grander plans in store for your second term. Is that correct?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Yes, and I can't wait to unveil them.""*)
  - -> `[18]` (*Player: ""Absolutely.""*)
  - -> `[87]` (*Player: ""No, that release was sent out in error. I'm keeping my p..."*)

### Węzeł `[10]`
Mówca: **Mansoun Leke**
> ""I'm happy some of our parties' so-called radical ideas are beginning to filter into the political mainstream.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Frens Ricter: ""I agree with this plan in theory, but it would bankrupt ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true) || BaseGame.Enable_LateOpenRailway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn04_InT_RailwayIssue_Solved == false && Base..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn04_InT_RailwayIssue_Solved == false && Ba..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true) || BaseGame.Enable_LateOpenRailway == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true)  or  Variable["BaseGame.Enable_LateOpenRailway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true) || BaseGame.Enable_LateOpenRailway == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true)  or  Variable["BaseGame.Enable_LateOpenRailway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn04_InT_HighwayIssue_Solved == false && Base..."*)

### Węzeł `[17]`
Mówca: **Moderator**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Absolutely.""]** — Mówca: **Player**
> ""Absolutely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Moderator: ""Would you like to tell us what those are?""*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true) || BaseGame.Enable_LateOpenHighway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn04_InT_HighwayIssue_Solved == false && Base..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn04_InT_HighwayIssue_Solved == false && Ba..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true) || BaseGame.Enable_LateOpenHighway == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true)  or  Variable["BaseGame.Enable_LateOpenHighway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true) || BaseGame.Enable_LateOpenHighway == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true)  or  Variable["BaseGame.Enable_LateOpenHighway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Kesaro Kibener: ""As your alliance partner, I pledge the NFP will also str..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Kesaro Kibener: ""This has been a goal of the NFP for some time now. But A..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We have an alliance. Aren't you supposed to be on my side?""]** — Mówca: **Player**
> ""We have an alliance. Aren't you supposed to be on my side?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Kontekst wejściowy (poprzednik):** `[54]` (Frens Ricter), `[55]` (Frens Ricter), `[60]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Frens Ricter: ""Well, you didn't run this by me.""*)

### Węzeł `[26]`
Mówca: **Frens Ricter**
> ""Well, you didn't run this by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lileas Graf: ""You couldn't even open a railway on time, and now you're..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Laugh all you want. I'm going to make it happen.""]** — Mówca: **Player**
> ""Laugh all you want. I'm going to make it happen.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[56]` (Manoly Suheil), `[82]` (Manoly Suheil), `[84]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""We have an alliance. Aren't you supposed to be on my side?""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Laugh all you want. I'm going to make it happen.""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lileas Graf: ""You couldn't even open a highway on time, and now you're..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[37]`
Mówca: **Kesaro Kibener**
> ""This has been a goal of the NFP for some time now. But Anton Rayne cannot be trusted with his finger on the nuclear button.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[38]`
Mówca: **Manoly Suheil**
> ""I've been pushing to include this in the next PFJP platform as well, but it's a hard sell with voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""Citizens will still work. My plan will only ensure nobod..."*)
  - -> `[107]` (*Player: ""With a guaranteed income, Sordish people will spend as n..."*)
  - -> `[108]` (*Player: ""By removing the bureaucracy associated with the welfare ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Citizens will still work. My plan will only ensure nobody has to go homeless.""]** — Mówca: **Player**
> ""Citizens will still work. My plan will only ensure nobody has to go homeless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Kesaro Kibener), `[38]` (Manoly Suheil), `[47]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[40]`
Mówca: **Kesaro Kibener**
> ""As your alliance partner, I pledge the NFP will also strive to enhance our nuclear capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Sordland must develop a nuclear arsenal.""]** — Mówca: **Player**
> ""Sordland must develop a nuclear arsenal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Moderator), `[116]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_NuclearPromise = true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""We will grant a basic living wage to every man and woman in Sordland. Unemployed or otherwise.""]** — Mówca: **Player**
> ""We will grant a basic living wage to every man and woman in Sordland. Unemployed or otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Moderator), `[116]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_BasicIncomePromise = true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""I want Sordland to put a man on the moon.""]** — Mówca: **Player**
> ""I want Sordland to put a man on the moon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Moderator), `[116]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "The other candidates burst out laughing."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Manoly Suheil: ""There are so many problems still to be solved in Sordlan..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Denis Stahler: ""There are so many problems still to be solved in Sordlan..."*)

### Węzeł `[47]`
Mówca: **Remus Holstron**
> ""You're mad. Sordish citizens want to work for their money. Handouts will only make them soft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""Citizens will still work. My plan will only ensure nobod..."*)
  - -> `[107]` (*Player: ""With a guaranteed income, Sordish people will spend as n..."*)
  - -> `[108]` (*Player: ""By removing the bureaucracy associated with the welfare ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Frens Ricter: ""You're both mad. Disincentivizing work will crater this ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Kesaro Kibener: ""Each Sordish citizen wants to contribute and work for th..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[54]`
Mówca: **Frens Ricter**
> ""I agree, but you've already proven yourself incapable of managing basic infrastructure projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[55]`
Mówca: **Frens Ricter**
> ""You're both mad. Disincentivizing work will crater this country's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_UnemploymentWage == true"*)
  - -> `[39]` (*Player: ""Citizens will still work. My plan will only ensure nobod..."*)
  - -> `[107]` (*Player: ""With a guaranteed income, Sordish people will spend as n..."*)

### Węzeł `[56]`
Mówca: **Manoly Suheil**
> ""There are so many problems still to be solved in Sordland. Space is just a flashy distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Laugh all you want. I'm going to make it happen.""*)
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[93]` (*Player: ""A space program would create thousands of jobs while boo..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Frens Ricter: ""I agree, but you've already proven yourself incapable of..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[60]`
Mówca: **Frens Ricter**
> ""I agree with this plan in theory, but it would bankrupt our country in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "The candidates around me gasped -- except for Remus, who ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The candidates around me gasped -- except for Kesaro, who..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "The other candidates burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""I'm serious. Sordland is going into space.""*)
  - -> `[8]` (*Player: ""Just kidding. We have too many problems to solve here at..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Manoly Suheil: ""You're insane. If we even attempt this, it's only a matt..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Denis Stahler: ""You're insane. If we even attempt this, it's only a matt..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Frens Ricter: ""You're insane. If we even attempt this, it's only a matt..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""I'm serious. Sordland is going into space.""]** — Mówca: **Player**
> ""I'm serious. Sordland is going into space.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_SpacePromise = true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Manoly Suheil: ""I've been pushing to include this in the next PFJP platf..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "The candidates around me gasped -- except Mansoun and Denis, who looked pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Mansoun Leke: ""I'm happy some of our parties' so-called radical ideas a..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "The candidates around me gasped -- except for Remus, who looked intrigued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Remus Holstron: ""I guess the USP has gotten it's hands on our new manifes..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "The candidates around me gasped -- except for Kesaro, who looked faintly intrigued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[81]`
Mówca: **Frens Ricter**
> ""You're insane. If we even attempt this, it's only a matter of time before Sordland becomes a crater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[100]` (*Player: ""Only via mutually assured destruction can we achieve pea..."*)
  - -> `[101]` (*Player: ""A nuclear program would create thousands of jobs and boo..."*)

### Węzeł `[82]`
Mówca: **Manoly Suheil**
> ""Perhaps, but you've already proven yourself incapable of managing basic infrastructure projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Laugh all you want. I'm going to make it happen.""*)
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)

### Węzeł `[83]`
Mówca: **Remus Holstron**
> ""I guess the USP has gotten it's hands on our new manifesto. In the new age nuclear power plays an important role. We need to position Sords as the dominant power in the region and our party is committed to such ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[84]`
Mówca: **Lileas Graf**
> ""You couldn't even open a highway on time, and now you're talking about building rockets?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Laugh all you want. I'm going to make it happen.""*)
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[93]` (*Player: ""A space program would create thousands of jobs while boo..."*)

### Węzeł `[85]`
Mówca: **Manoly Suheil**
> ""You're insane. If we even attempt this, it's only a matter of time before Sordland becomes a crater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[100]` (*Player: ""Only via mutually assured destruction can we achieve pea..."*)
  - -> `[101]` (*Player: ""A nuclear program would create thousands of jobs and boo..."*)

### Węzeł `[86]`
Mówca: **Lileas Graf**
> ""You couldn't even open a railway on time, and now you're talking about building rockets?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Laugh all you want. I'm going to make it happen.""*)
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[93]` (*Player: ""A space program would create thousands of jobs while boo..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""No, that release was sent out in error. I'm keeping my plans modest.""]** — Mówca: **Player**
> ""No, that release was sent out in error. I'm keeping my plans modest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Moderator: ""Very well.""*)

### Węzeł `[88]`
Mówca: **Moderator**
> ""Would you like to tell us what those are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""I want Sordland to put a man on the moon.""*)
  - -> `[41]` (*Player: ""Sordland must develop a nuclear arsenal.""*)
  - -> `[42]` (*Player: ""We will grant a basic living wage to every man and woman..."*)
  - -> `[89]` (*Player: ""You'll find out once I get re-elected.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""You'll find out once I get re-elected.""]** — Mówca: **Player**
> ""You'll find out once I get re-elected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Moderator: ""Very well.""*)

### Węzeł `[90]`
Mówca: **Denis Stahler**
> ""There are so many problems still to be solved in Sordland. Space is just a flashy distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Laugh all you want. I'm going to make it happen.""*)
  - -> `[91]` (*Player: ""With nuclear war an increasing possibility, survival on ..."*)
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[93]` (*Player: ""A space program would create thousands of jobs while boo..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""With nuclear war an increasing possibility, survival on other planets is something we must consider.""]** — Mówca: **Player**
> ""With nuclear war an increasing possibility, survival on other planets is something we must consider.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Frens Ricter), `[56]` (Manoly Suheil), `[60]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""If we want to be taken seriously by the superpowers, this is the only way.""]** — Mówca: **Player**
> ""If we want to be taken seriously by the superpowers, this is the only way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Frens Ricter), `[56]` (Manoly Suheil), `[60]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""A space program would create thousands of jobs while boosting our national morale.""]** — Mówca: **Player**
> ""A space program would create thousands of jobs while boosting our national morale.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Manoly Suheil), `[84]` (Lileas Graf), `[86]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[94]`
Mówca: **Denis Stahler**
> ""You're insane. If we even attempt this, it's only a matter of time before Sordland becomes a crater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""If we want to be taken seriously by the superpowers, thi..."*)
  - -> `[100]` (*Player: ""Only via mutually assured destruction can we achieve pea..."*)
  - -> `[101]` (*Player: ""A nuclear program would create thousands of jobs and boo..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "The candidates around me gasped -- except for Lileas, who..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "The candidates around me gasped -- except for Lileas, who smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""This was a longtime ambition of Tarquin Soll. However, A..."*)

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""This was a longtime ambition of Tarquin Soll. However, Anton Rayne cannot be trusted to fulfill it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Only via mutually assured destruction can we achieve peace with our enemies.""]** — Mówca: **Player**
> ""Only via mutually assured destruction can we achieve peace with our enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Frens Ricter), `[85]` (Manoly Suheil), `[94]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""A nuclear program would create thousands of jobs and boost national morale.""]** — Mówca: **Player**
> ""A nuclear program would create thousands of jobs and boost national morale.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Frens Ricter), `[85]` (Manoly Suheil), `[94]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The candidates around me gasped -- except Mansoun and Den..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "The candidates around me gasped -- except Denis, who rais..."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "The candidates around me gasped -- except Denis, who raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Denis Stahler: ""If you think that kind of empty promise will win over my..."*)

### Węzeł `[106]`
Mówca: **Denis Stahler**
> ""If you think that kind of empty promise will win over my voters, you're dead wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""With a guaranteed income, Sordish people will spend as never before. The economy will thrive.""]** — Mówca: **Player**
> ""With a guaranteed income, Sordish people will spend as never before. The economy will thrive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Kesaro Kibener), `[38]` (Manoly Suheil), `[47]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""By removing the bureaucracy associated with the welfare system, my plan will save us millions.""]** — Mówca: **Player**
> ""By removing the bureaucracy associated with the welfare system, my plan will save us millions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Kesaro Kibener), `[38]` (Manoly Suheil), `[47]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_SpacePromise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn04_InT_RailwayIssue_Solved == false && Base..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_NuclearPromise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_NuclearPromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_BasicIncomePromise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_BasicIncomePromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HousingAssistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HousingAssistance == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_HousingAssistance == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HousingAssistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""My administration is already providing housing assistanc..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_HousingAssistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Yes, and I can't wait to unveil them.""]** — Mówca: **Player**
> ""Yes, and I can't wait to unveil them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Moderator: ""Please go on.""*)

### Węzeł `[116]`
Mówca: **Moderator**
> ""Please go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""I want Sordland to put a man on the moon.""*)
  - -> `[41]` (*Player: ""Sordland must develop a nuclear arsenal.""*)
  - -> `[42]` (*Player: ""We will grant a basic living wage to every man and woman..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_UnemploymentWage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_UnemploymentWage == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_UnemploymentWage == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_UnemploymentWage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""My administration is already providing assistance to une..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_UnemploymentWage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HousingAssistance == true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""My administration is already providing assistance to unemployed citizens. This is just a logical extension of that policy.""]** — Mówca: **Player**
> ""My administration is already providing assistance to unemployed citizens. This is just a logical extension of that policy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true`
- **Kontekst wejściowy (poprzednik):** `[55]` (Frens Ricter), `[130]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""My administration is already providing housing assistance to low-income citizens. This is just a logical extension of that policy"]** — Mówca: **Player**
> ""My administration is already providing housing assistance to low-income citizens. This is just a logical extension of that policy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Welfare_HousingAssistance"] == true` AND `(Variable["BaseGame.Situation_Welfare_UnemploymentWage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[55]` (Frens Ricter), `[130]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""You're supposed to be my ally, Kesaro.""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WYBÓR GRACZA: ""You're supposed to be my ally, Kesaro.""]** — Mówca: **Player**
> ""You're supposed to be my ally, Kesaro.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Kesaro Kibener: ""Well, you didn't run this by me.""*)

### Węzeł `[126]`
Mówca: **Kesaro Kibener**
> ""Well, you didn't run this by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Remus Holstron: ""You're mad. Sordish citizens want to work for their mone..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Denis Stahler: ""I don't believe a word of it.""*)

### Węzeł `[130]`
Mówca: **Denis Stahler**
> ""I don't believe a word of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_UnemploymentWage == true"*)
  - -> `[107]` (*Player: ""With a guaranteed income, Sordish people will spend as n..."*)
  - -> `[108]` (*Player: ""By removing the bureaucracy associated with the welfare ..."*)
  - -> `[131]` (*Player: ""All I have in mind is Sordish people and Sordish people ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""All I have in mind is Sordish people and Sordish people alone.""]** — Mówca: **Player**
> ""All I have in mind is Sordish people and Sordish people alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Moderator: ""Very interesting.""*)
