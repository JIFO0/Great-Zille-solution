# Sordland/Turn02/InT_HighwayContract

- **ID konwersacji:** `24`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/024_InT_HighwayContract.md`
- **Liczba węzłów dialogowych:** 215
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`
- `BaseGameSupport.Journal_Turn02_ConstructionSSC`
- `BaseGameSupport.Journal_Turn02_ConstructionTaurus`
- `BaseGameSupport.Journal_Turn02_ConstructionUnderhall`
- `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand`
- `BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand`
- `BaseGameSupport.News_Turn02_HP_H3_SSC`
- `BaseGameSupport.News_Turn02_HP_H3_Taurus`
- `BaseGameSupport.News_Turn02_HP_H3_Underhall`
- `BaseGameSupport.News_Turn02_ST_H3_SSC`
- `BaseGameSupport.News_Turn02_ST_H3_Taurus`
- `GameCondition.Turn02_InT_Contract`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **"“I would like to hear your thoughts, Symon.”"** | `[12]` **Lileas Graf**: "“I had to work with Underhall Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Symon Holl**: "“I think that they have been doi..." |
| `[14]` | **"“I trust your plan, Symon.”"** | `[11]` **Lileas Graf**: "“More importantly, it will lead ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Symon Holl**: "“I am glad to hear that. We shou..." |
| `[15]` | **"“I hope so, Lileas.”"** | `[11]` **Lileas Graf**: "“More importantly, it will lead ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lileas Graf**: "“With the highway, we will be we..." |
| `[17]` | **"“How was your experience with them?”"** | `[12]` **Lileas Graf**: "“I had to work with Underhall Co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lileas Graf**: "“Out of all three, this is the c..." |
| `[18]` | **"“Thank you. This concludes the meeting.”"** | `[115]` **Lileas Graf**: "“I'd better get back to work, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "The meeting ended and we spent t..." |
| `[35]` | **"“Why should we pick Taurus?”"** | `[56]` **Lileas Graf**: "“There are other things Taurus d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Symon Holl**: "“It would fit our election promi..."<br>`[30]` **Symon Holl**: "“Taurus has completed fewer proj..." |
| `[36]` | **"“Do you need additional support?”"** | `[22]` **Symon Holl**: "“According to my estimations thi..."<br>`[23]` **Lileas Graf**: "“I look forward to a positive fi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Symon Holl**: "“Not as of right now. However, t..." |
| `[37]` | **"“Failure during this project is not an option.”"** | `[22]` **Symon Holl**: "“According to my estimations thi..."<br>`[23]` **Lileas Graf**: "“I look forward to a positive fi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Lileas Graf**: "“We'll not let the people or our..." |
| `[38]` | **"“What kind of end results do we expect?”"** | `[22]` **Symon Holl**: "“According to my estimations thi..."<br>`[23]` **Lileas Graf**: "“I look forward to a positive fi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Symon Holl**: "“Short-term employment and long-..." |
| `[39]` | **"“What will it take to stop the recession?”"** | `[22]` **Symon Holl**: "“According to my estimations thi..."<br>`[23]` **Lileas Graf**: "“I look forward to a positive fi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Symon Holl**: "“This is just the beginning. We ..." |
| `[40]` | **"“Why shouldn't we go with Taurus?”"** | `[56]` **Lileas Graf**: "“There are other things Taurus d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lileas Graf**: "“Well, one of our promises would..."<br>`[31]` **Lileas Graf**: "“This company is completely priv..." |
| `[59]` | **"“Underhall Construction.”"** | `[102]` **Symon Holl**: "“Which corporation should we tal..."<br>`[88]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false` | *Brak zmian stanu* | `[98]` **Symon Holl**: "“The real estate and constructio..." |
| `[67]` | **"“I have settled on Taurus Holding.”"** | `[48]` **Narrator**: "It was time to decide which comp..."<br>`[202]` **Symon Holl**: "“The project manager from Taurus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"]...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionTaur...` | `[138]` **Symon Holl**: "“Good that we are staying consis..."<br>`[175]` **Narrator**: "Symon signed a certain section o..." |
| `[69]` | **"“Taurus is definitely worth considering.”"** | `[202]` **Symon Holl**: "“The project manager from Taurus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHold...` | `[77]` **Player**: "“The Sordish State Corporation.”"<br>`[59]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[70]` | **"“I don't feel confident about Taurus Holding.”"** | `[202]` **Symon Holl**: "“The project manager from Taurus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHold...` | `[77]` **Player**: "“The Sordish State Corporation.”"<br>`[59]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[77]` | **"“The Sordish State Corporation.”"** | `[102]` **Symon Holl**: "“Which corporation should we tal..."<br>`[88]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false` | *Brak zmian stanu* | `[93]` **Symon Holl**: "“The respected Sordish State Cor..." |
| `[88]` | **"“I am on the fence about the SSC.”"** | `[198]` **Symon Holl**: "“According to the preliminary ca..."<br>`[87]` **Lileas Graf**: "“I don't agree with your negativ..." | `Variable["BaseGame.Promise_Economy_Planned"] == true` | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishSta...` | `[77]` **Player**: "“The Sordish State Corporation.”"<br>`[59]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[89]` | **"“I like the SSC, but want to hear about the others.”"** | `[198]` **Symon Holl**: "“According to the preliminary ca..."<br>`[87]` **Lileas Graf**: "“I don't agree with your negativ..." | `Variable["BaseGame.Promise_Economy_Planned"] == true` | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishSta...` | `[77]` **Player**: "“The Sordish State Corporation.”"<br>`[59]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[90]` | **"“Taurus Holding.”"** | `[102]` **Symon Holl**: "“Which corporation should we tal..."<br>`[88]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false` | *Brak zmian stanu* | `[60]` **Symon Holl**: "“Taurus Holding was founded in 1..." |
| `[94]` | **"Look at the files."** | `[92]` **Narrator**: "Symon handed the files over to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Lileas Graf**: "“I reviewed them. I also took th..." |
| `[100]` | **"“I have settled on the SSC. [-2 Government Budget]”"** | `[48]` **Narrator**: "It was time to decide which comp..."<br>`[198]` **Symon Holl**: "“According to the preliminary ca..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`<br>`Variable["BaseGame.Promise_Economy_Planned"] == true` | `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] ...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"...`<br>*(+1 skryptów)* | `[148]` **Symon Holl**: "“Good that we are staying consis..."<br>`[173]` **Narrator**: "Symon signed a certain section o..." |
| `[104]` | **"“I am not sure about Underhall Construction.”"** | `[201]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallC...` | `[77]` **Player**: "“The Sordish State Corporation.”"<br>`[59]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[105]` | **"“Underhall seems interesting, but let's hear about the others.”"** | `[201]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallC...` | `[77]` **Player**: "“The Sordish State Corporation.”"<br>`[59]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[106]` | **"“I have settled on Underhall Construction. [-2 Government Budget]”"** | `[48]` **Narrator**: "It was time to decide which comp..."<br>`[201]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstr...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionUnde...`<br>*(+1 skryptów)* | `[146]` **Symon Holl**: "“Good that we are staying consis..."<br>`[174]` **Narrator**: "Symon signed a certain section o..." |
| `[113]` | **"“That's great news.”"** | `[4]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Symon Holl**: "“My expectations are that the gr..." |
| `[116]` | **"“I think we are off to a good start.”"** | `[4]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Symon Holl**: "“My expectations are that the gr..." |
| `[117]` | **"“Good luck to us.”"** | `[4]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Symon Holl**: "“My expectations are that the gr..." |
| `[121]` | **"“Working conditions must be respected. This doesn't inspire confidence.”"** | `[42]` **Symon Holl**: "“I am not too sure about trustin..."<br>`[51]` **Symon Holl**: "“Nonetheless, they subjected the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Lileas Graf**: "“I agree. The workers were undoc..." |
| `[122]` | **"“We need to be able to trust the corporation. This is a base requirement for the c..."** | `[42]` **Symon Holl**: "“I am not too sure about trustin..."<br>`[51]` **Symon Holl**: "“Nonetheless, they subjected the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Lileas Graf**: "“They indeed did work on three s..." |
| `[125]` | **"“The experience they bring to the table is beneficial.”"** | `[86]` **Symon Holl**: "“The outdated construction metho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“I don't agree with your negativ..." |
| `[126]` | **"“The lack of a modern attitude is disappointing.”"** | `[86]` **Symon Holl**: "“The outdated construction metho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“I don't agree with your negativ..." |
| `[127]` | **"“The regional highway system has no relation to this.”"** | `[155]` **Symon Holl**: "“A simple look at the regional h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“I don't agree with your negativ..." |
| `[128]` | **"“They do have a wealth of knowledge in infrastructure.”"** | `[155]` **Symon Holl**: "“A simple look at the regional h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“I don't agree with your negativ..." |
| `[129]` | **"“The innovative aspect is refreshing. Especially if they can deliver.”"** | `[156]` **Symon Holl**: "“It won several awards internati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Lileas Graf**: "“They were only involved in smal..." |
| `[130]` | **"“It seems like they lack the necessary experience.”"** | `[156]` **Symon Holl**: "“It won several awards internati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Lileas Graf**: "“They were only involved in smal..." |
| `[131]` | **"“We shouldn't risk our first project. There is too much at stake here.”"** | `[157]` **Lileas Graf**: "“Choosing this company is too mu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Symon Holl**: "“They took a joint contract in A..." |
| `[132]` | **"“Their capabilities matter more than the history they have. We need to make unbias..."** | `[157]` **Lileas Graf**: "“Choosing this company is too mu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Symon Holl**: "“They took a joint contract in A..." |
| `[206]` | **"“I have settled on the SSC. [-1 Government Budget]”"** | `[48]` **Narrator**: "It was time to decide which comp..."<br>`[198]` **Symon Holl**: "“According to the preliminary ca..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`<br>`Variable["BaseGame.Promise_Economy_Planned"] == true` | `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] ...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"...`<br>*(+1 skryptów)* | `[148]` **Symon Holl**: "“Good that we are staying consis..." |

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
  - -> `[6]` (*Narrator: "After a lengthy drive on cliffside roads, we arrived in L..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction = true; BaseGame.Turn04_InT_HighwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] = true;
Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionUnderhall = true"*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> "“The company will be notified today and construction work will begin immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 25);  // Updates token..."*)

### Węzeł `[5]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group will be pleased. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled = true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "After a lengthy drive on cliffside roads, we arrived in Lenkurg. There, crowds of cheering citizens greeted us and the local government officials escorted us to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "We were here for a significant meeting about the H-3 proj..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "We were here for a significant meeting about the H-3 project. Several construction companies sent their representatives to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Gus Manger couldn't make the meeting due to his visit to ..."*)

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“We'll not let the people or ourselves down. I won't let that happen to any of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Symon Holl: "“Our economic revitalization plan is set to be a success...."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Gus Manger couldn't make the meeting due to his visit to Rizia, but I had Symon Holl and Lileas Graf by my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Symon Holl: "“Besides starting our economic recovery, this project wil..."*)

### Węzeł `[10]`
Mówca: **Symon Holl**
> "“Besides starting our economic recovery, this project will cut the time it takes to get here by road in half, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lileas Graf: "“More importantly, it will lead to improvement in Agnland..."*)

### Węzeł `[11]`
Mówca: **Lileas Graf**
> "“More importantly, it will lead to improvement in Agnland. I have lived with these people and seen them suffer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "“I trust your plan, Symon.”"*)
  - -> `[15]` (*Player: "“I hope so, Lileas.”"*)

### Węzeł `[12]`
Mówca: **Lileas Graf**
> "“I had to work with Underhall Construction before in Holsord. They accepted several contracts for the renovation of our central station and left much to be desired. The H-3 project shouldn't be left to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“I would like to hear your thoughts, Symon.”"*)
  - -> `[17]` (*Player: "“How was your experience with them?”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I would like to hear your thoughts, Symon.”"]** — Mówca: **Player**
> "“I would like to hear your thoughts, Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“I think that they have been doing relatively well in the..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I trust your plan, Symon.”"]** — Mówca: **Player**
> "“I trust your plan, Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: "“I am glad to hear that. We should be able to slow down t..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I hope so, Lileas.”"]** — Mówca: **Player**
> "“I hope so, Lileas.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lileas Graf: "“With the highway, we will be well on our way to economic..."*)

### Węzeł `[16]`
Mówca: **Lileas Graf**
> "“Well, one of our promises would be respected. We promised to focus on the planned economy to create jobs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lileas Graf: "“This company is completely private and directed by a non..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“How was your experience with them?”"]** — Mówca: **Player**
> "“How was your experience with them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“Out of all three, this is the company I trust the least...."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Thank you. This concludes the meeting.”"]** — Mówca: **Player**
> "“Thank you. This concludes the meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The meeting ended and we spent the remainder of the day a..."*)

### Węzeł `[19]`
Mówca: **Lileas Graf**
> "“With the highway, we will be well on our way to economically strengthening this weak region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Symon Holl: "“According to my estimations this project will give about..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_InT_Contract = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_InT_Contract"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“I am glad to hear that. We should be able to slow down the recession if we finish this project successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lileas Graf: "“I look forward to a positive financial outcome. Accordin..."*)

### Węzeł `[22]`
Mówca: **Symon Holl**
> "“According to my estimations this project will give about 50.000 citizens from Agnland employment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“What will it take to stop the recession?”"*)
  - -> `[38]` (*Player: "“What kind of end results do we expect?”"*)
  - -> `[37]` (*Player: "“Failure during this project is not an option.”"*)
  - -> `[36]` (*Player: "“Do you need additional support?”"*)

### Węzeł `[23]`
Mówca: **Lileas Graf**
> "“I look forward to a positive financial outcome. According to my sources, we'll lift many people in these areas out of poverty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“What will it take to stop the recession?”"*)
  - -> `[38]` (*Player: "“What kind of end results do we expect?”"*)
  - -> `[37]` (*Player: "“Failure during this project is not an option.”"*)
  - -> `[36]` (*Player: "“Do you need additional support?”"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The meeting ended and we spent the remainder of the day attending events in Lenkurg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "It was nice to enjoy the natural beauty of Agnland and to..."*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> "“If we are going to try a different company, this is the most unique.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Symon Holl: "“The project manager from Taurus Holding mentioned that t..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_Planned == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lileas Graf: "“Well, one of our promises would be respected. We promise..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lileas Graf: "“This company is completely private and directed by a non..."*)

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“It would fit our election promises of switching to a free-market economy. Awarding contracts to privately owned corporations would be a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: "“Taurus has completed fewer projects than the other compa..."*)

### Węzeł `[30]`
Mówca: **Symon Holl**
> "“Taurus has completed fewer projects than the other companies. However, they are slightly faster and cheaper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Symon Holl: "“It won several awards internationally for being one of t..."*)

### Węzeł `[31]`
Mówca: **Lileas Graf**
> "“This company is completely private and directed by a non-government board. Do we even remember if they worked on a mega-project at all?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "Lileas sighed."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Symon Holl: "“It would fit our election promises of switching to a fre..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: "“Taurus has completed fewer projects than the other compa..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Why should we pick Taurus?”"]** — Mówca: **Player**
> "“Why should we pick Taurus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Do you need additional support?”"]** — Mówca: **Player**
> "“Do you need additional support?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Symon Holl), `[23]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Symon Holl: "“Not as of right now. However, things might come up if th..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Failure during this project is not an option.”"]** — Mówca: **Player**
> "“Failure during this project is not an option.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Symon Holl), `[23]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lileas Graf: "“We'll not let the people or ourselves down. I won't let ..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“What kind of end results do we expect?”"]** — Mówca: **Player**
> "“What kind of end results do we expect?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Symon Holl), `[23]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Symon Holl: "“Short-term employment and long-term economic development..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“What will it take to stop the recession?”"]** — Mówca: **Player**
> "“What will it take to stop the recession?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Symon Holl), `[23]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Symon Holl: "“This is just the beginning. We will need to follow this ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Why shouldn't we go with Taurus?”"]** — Mówca: **Player**
> "“Why shouldn't we go with Taurus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)

### Węzeł `[41]`
Mówca: **Lileas Graf**
> "“Thank you for the offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“I am not too sure about trusting them with the contract but at least they have worked on several mega-projects and always delivered on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: "“Working conditions must be respected. This doesn't inspi..."*)
  - -> `[122]` (*Player: "“We need to be able to trust the corporation. This is a b..."*)

### Węzeł `[43]`
Mówca: **Symon Holl**
> "“Our economic revitalization plan is set to be a success. Failure is indeed not an option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“Out of all three, this is the company I trust the least. They seem to fail at respecting the contract terms of their workers. They're likely to cause trouble.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Symon Holl: "“I am not too sure about trusting them with the contract ..."*)

### Węzeł `[45]`
Mówca: **Lileas Graf**
> "“The underdeveloped cities of Lenkurg and Arvory will receive a lot more investment after this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“The SSC is one of our most trusted and honorable companies. They have served us a long time. I have worked with them on several occasions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“That depends on the government budget. We need to make sure we have enough money to fund critical ministries but still have enough left to invest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Symon Holl: "“Yes.”"*)

### Węzeł `[48]`
Mówca: **Narrator**
> "It was time to decide which company would be awarded the H-3 Highway contract."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[106]` (*Player: "“I have settled on Underhall Construction. [-2 Government..."*)
  - -> `[67]` (*Player: "“I have settled on Taurus Holding.”"*)

### Węzeł `[49]`
Mówca: **Symon Holl**
> "“Short-term employment and long-term economic development in the Nargis and Agnland regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lileas Graf: "“The underdeveloped cities of Lenkurg and Arvory will rec..."*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“They were only involved in smaller-scale regional projects. This doesn't prove their capabilities for larger undertakings that are more complex.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Symon Holl: "“The project manager from Taurus Holding mentioned that t..."*)

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“Nonetheless, they subjected their workers to conditions beneath our standards during the Holsord Central Station contract. Which is troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: "“Working conditions must be respected. This doesn't inspi..."*)
  - -> `[122]` (*Player: "“We need to be able to trust the corporation. This is a b..."*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“I think that they have been doing relatively well in the private sector, where they are dominating the construction industry with successful projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Symon Holl: "“Nonetheless, they subjected their workers to conditions ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == f..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Taurus Holding.”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“There are other things Taurus does very well, like providing consultants for state corporations. But I can't vouch for their infrastructure construction at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Why should we pick Taurus?”"*)
  - -> `[40]` (*Player: "“Why shouldn't we go with Taurus?”"*)

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Not as of right now. However, things might come up if the project doesn't go according to plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lileas Graf: "“Thank you for the offer.”"*)

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“This is just the beginning. We will need to follow this project up with several other economic investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“That depends on the government budget. We need to make s..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Underhall Construction.”"]** — Mówca: **Player**
> "“Underhall Construction.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl), `[88]` (Player), `[89]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Symon Holl: "“The real estate and construction giant was founded in 19..."*)

### Węzeł `[60]`
Mówca: **Symon Holl**
> "“Taurus Holding was founded in 1946 and is owned by the entrepreneur Geralt Fais.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Symon Holl: "“It is a new holding company whose subsidiaries use cutti..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp =..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“The Sordish State Corporation.”"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Highway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "Highway Companies Hub"*)

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“It would fulfill your initial election promise of using a state-dominant planned economy to improve Sordland's bleak economic prospects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lileas Graf: "“They have the experience and the manpower to pull off a ..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Highway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "Highway Companies Hub"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding.”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[202]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding = true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Highway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "Highway Companies Hub"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Taurus is definitely worth considering.”"]** — Mówca: **Player**
> "“Taurus is definitely worth considering.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“I don't feel confident about Taurus Holding.”"]** — Mówca: **Player**
> "“I don't feel confident about Taurus Holdings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true"*)

### Węzeł `[71]`
Mówca: **Symon Holl**
> "“It goes against your election promises of moving away from a state-planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Symon Holl: "“Most importantly the Sordish State Corporation uses outd..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_Planned == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lileas Graf: "“It would fulfill your initial election promise of using ..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Symon Holl: "“It goes against your election promises of moving away fr..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "Jump to: [Highway Companies Hub]"*)

### Węzeł `[76]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this. But the contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“The Sordish State Corporation.”"]** — Mówca: **Player**
> "“The Sordish State Corporation.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl), `[88]` (Player), `[89]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Symon Holl: "“The respected Sordish State Corporation, also known as t..."*)

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“I wish the outcome of this meeting was different. But at the end of the day, the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“The company will be notified today and construction work..."*)

### Węzeł `[79]`
Mówca: **Symon Holl**
> "“Most importantly the Sordish State Corporation uses outdated methods, resulting in slower construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Symon Holl: "“A simple look at the regional highways shows us the prob..."*)

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“I wish you had chosen differently. But at the end of the day, the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“The company will be notified today and construction work..."*)

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[82]`
Mówca: **Lileas Graf**
> "“I'm so glad that you have made this choice. I can tell from my experience that we will be very satisfied with this corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: "“The company will be notified today and construction work..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionTaurus = true"*)

### Węzeł `[84]`
Mówca: **Lileas Graf**
> "“They have the experience and the manpower to pull off a project like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Lileas paused for a second."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "Jump to: [Highway Companies Hub]"*)

### Węzeł `[86]`
Mówca: **Symon Holl**
> "“The outdated construction methods that they use concern me. They are several decades behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“The experience they bring to the table is beneficial.”"*)
  - -> `[126]` (*Player: "“The lack of a modern attitude is disappointing.”"*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“I don't agree with your negative statements, Symon. The SSC's record clearly shows completed contracts with thousands of employees who have more than 20 years of experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I am on the fence about the SSC.”"]** — Mówca: **Player**
> "“I am on the fence about the SSC.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[198]` (Symon Holl), `[87]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“I like the SSC, but want to hear about the others.”"]** — Mówca: **Player**
> "“I like the SSC, but want to hear about the others.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[198]` (Symon Holl), `[87]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Taurus Holding.”"]** — Mówca: **Player**
> "“Taurus Holding.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl), `[88]` (Player), `[89]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Symon Holl: "“Taurus Holding was founded in 1946 and is owned by the e..."*)

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“I have the overview of the companies here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Symon handed the files over to me."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Symon handed the files over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Italic: "Look at the files."*)

### Węzeł `[93]`
Mówca: **Symon Holl**
> "“The respected Sordish State Corporation, also known as the SSC was founded in 1891.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Symon Holl: "“It is the main state corporation tasked with running the..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "Look at the files."]** — Mówca: **Player_Italic**
> "I looked at the files. Three corporations were listed. The Sordish State Corporation, Underhall Construction and Taurus Holding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lileas Graf: "“I reviewed them. I also took the liberty of asking the m..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruct..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Underhall Construction.”"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
Mówca: **Symon Holl**
> "“The real estate and construction giant was founded in 1925 and expanded during the economic boom of the '30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[99]`
Mówca: **Lileas Graf**
> "“According to them, the tight completion schedule necessitated such bad labor conditions. Which still doesn't justify the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Symon Holl: "“Underhall has specifically mentioned their solid track r..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` AND `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[198]` (Symon Holl), `[87]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState = true"*)

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“I reviewed them. I also took the liberty of asking the mayor of Arvory to give his opinion on the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: "“Which corporation should we talk about?”"*)

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“Which corporation should we talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "Highway Companies Hub"*)

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“But during the station project, we had to extensively negotiate with the union so as to not lose a serious labor law violation case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Symon Holl: "“Underhall has specifically mentioned their solid track r..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I am not sure about Underhall Construction.”"]** — Mówca: **Player**
> "“I am not sure about Underhall Construction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Underhall seems interesting, but let's hear about the others.”"]** — Mówca: **Player**
> "“Underhall seems interesting, but let's hear about the others.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“I have settled on Underhall Construction. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Underhall Construction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[201]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction = t..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "Jump to: [Highway Companies Hub]"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionSSC = true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Highway Companies Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp =..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "It was time to decide which company would be awarded the ..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA: "“That's great news.”"]** — Mówca: **Player**
> "“That is great news.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Symon Holl: "“My expectations are that the grand opening ceremony will..."*)

### Węzeł `[114]`
Mówca: **Symon Holl**
> "“My expectations are that the grand opening ceremony will happen late next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lileas Graf: "“I'd better get back to work, then.”"*)

### Węzeł `[115]`
Mówca: **Lileas Graf**
> "“I'd better get back to work, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Thank you. This concludes the meeting.”"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“I think we are off to a good start.”"]** — Mówca: **Player**
> "“I think we are off to a good start.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Symon Holl: "“My expectations are that the grand opening ceremony will..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Good luck to us.”"]** — Mówca: **Player**
> "“Good luck to us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Symon Holl: "“My expectations are that the grand opening ceremony will..."*)

### Węzeł `[118]`
Mówca: **Symon Holl**
> "“It is the main state corporation tasked with running the day-to-day construction services of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: "“The SSC is one of our most trusted and honorable compani..."*)

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“The CEO of Underhall is Kris Schar, the mayor of Conriat. He sold half of his shares a few years ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lileas Graf: "“I had to work with Underhall Construction before in Hols..."*)

### Węzeł `[120]`
Mówca: **Symon Holl**
> "“It is a new holding company whose subsidiaries use cutting-edge technology from Arcasia to reduce construction costs and prices. They are known to provide for their workers, who are part of the Labour Union of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: "“There are other things Taurus does very well, like provi..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Working conditions must be respected. This doesn't inspire confidence.”"]** — Mówca: **Player**
> "“Working conditions must be respected. This doesn't inspire confidence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Symon Holl), `[51]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lileas Graf: "“I agree. The workers were undocumented Agnolian and Wehz..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“We need to be able to trust the corporation. This is a base requirement for the contract.”"]** — Mówca: **Player**
> "“We need to be able to trust the corporation. This is a base requirement for the contract.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Symon Holl), `[51]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lileas Graf: "“They indeed did work on three significant infrastructure..."*)

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“I agree. The workers were undocumented Agnolian and Wehzek immigrants with no papers. A clear violation of our laws.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: "“According to them, the tight completion schedule necessi..."*)

### Węzeł `[124]`
Mówca: **Lileas Graf**
> "“They indeed did work on three significant infrastructure projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lileas Graf: "“But during the station project, we had to extensively ne..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“The experience they bring to the table is beneficial.”"]** — Mówca: **Player**
> "“The experience they bring to the table is beneficial.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“I don't agree with your negative statements, Symon. The ..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“The lack of a modern attitude is disappointing.”"]** — Mówca: **Player**
> "“The lack of a modern attitude is disappointing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“I don't agree with your negative statements, Symon. The ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“The regional highway system has no relation to this.”"]** — Mówca: **Player**
> "“The regional highway system has no relation to this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“I don't agree with your negative statements, Symon. The ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“They do have a wealth of knowledge in infrastructure.”"]** — Mówca: **Player**
> "“They do have a wealth of knowledge in infrastructure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“I don't agree with your negative statements, Symon. The ..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“The innovative aspect is refreshing. Especially if they can deliver.”"]** — Mówca: **Player**
> "“The innovative aspect is refreshing. Especially if they can deliver.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“They were only involved in smaller-scale regional projec..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“It seems like they lack the necessary experience.”"]** — Mówca: **Player**
> "“It seems like they lack the necessary experience.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“They were only involved in smaller-scale regional projec..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“We shouldn't risk our first project. There is too much at stake here.”"]** — Mówca: **Player**
> "“We shouldn't risk our first project. There is too much at stake here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Symon Holl: "“They took a joint contract in Arcasia for restructuring ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"]** — Mówca: **Player**
> "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Symon Holl: "“They took a joint contract in Arcasia for restructuring ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Symon Holl: "“Picking this corporation would fit our market economy po..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Symon Holl: "“Picking this corporation would go against our planned ec..."*)

### Węzeł `[136]`
Mówca: **Symon Holl**
> "“Picking this corporation would go against our planned economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“The CEO of Underhall is Kris Schar, the mayor of Conriat..."*)

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“Picking this corporation would fit our market economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“The CEO of Underhall is Kris Schar, the mayor of Conriat..."*)

### Węzeł `[138]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[146]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[148]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "It was nice to enjoy the natural beauty of Agnland and to eat some good fish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[154]`
Mówca: **Lileas Graf**
> "“Secondly, they are the only company to have worked in the Agnland region out of all three corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Symon Holl: "“The outdated construction methods that they use concern ..."*)

### Węzeł `[155]`
Mówca: **Symon Holl**
> "“A simple look at the regional highways shows us the problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: "“The regional highway system has no relation to this.”"*)
  - -> `[128]` (*Player: "“They do have a wealth of knowledge in infrastructure.”"*)

### Węzeł `[156]`
Mówca: **Symon Holl**
> "“It won several awards internationally for being one of the fastest growing and advanced companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "“The innovative aspect is refreshing. Especially if they ..."*)
  - -> `[130]` (*Player: "“It seems like they lack the necessary experience.”"*)

### Węzeł `[157]`
Mówca: **Lileas Graf**
> "“Choosing this company is too much of a risk for such an important project, especially when a proven candidate like the SSC exists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“We shouldn't risk our first project. There is too much a..."*)
  - -> `[132]` (*Player: "“Their capabilities matter more than the history they hav..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDeman..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Symon Holl: "“Some in the Lotherberg Group won't like this. But the co..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDeman..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Symon Holl: "“Some in the Lotherberg Group won't like this, but the co..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Symon Holl: "“Some in the Lotherberg Group will be pleased. The contra..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[169]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“I wish you had chosen differently. But at the end of the..."*)

### Węzeł `[170]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“I wish the outcome of this meeting was different. But at..."*)

### Węzeł `[171]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lileas Graf: "“I'm so glad that you have made this choice. I can tell f..."*)

### Węzeł `[172]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled = false"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "Lileas sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lileas Graf: "“Choosing this company is too much of a risk for such an ..."*)

### Węzeł `[177]`
Mówca: **Symon Holl**
> "“They took a joint contract in Arcasia for restructuring the highway intersection of one of the major cities. It went well but it is their only large-scale success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: "“If we are going to try a different company, this is the ..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Lileas paused for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lileas Graf: "“Secondly, they are the only company to have worked in th..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand =..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Symon searched through the documents he was holding and found the one he was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Symon Holl: "“I have the overview of the companies here.”"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_H3_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_H3_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_H3_Taurus = true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_H3_Underhall = true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_H3_Taurus = true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_H3_SSC = true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_H3_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_H3_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_InT_Contract = true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_H3_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_H3_SSC = true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_H3_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_InT_Contract = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_H3_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_H3_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_InT_Contract = true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionSSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionUnderhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionUnderhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionTaurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionTaurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“I wish you had chosen differently. But at the end of the..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“I wish the outcome of this meeting was different. But at..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lileas Graf: "“I'm so glad that you have made this choice. I can tell f..."*)

### Węzeł `[198]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they would need more resources to finish a project of this size.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“I am on the fence about the SSC.”"*)
  - -> `[89]` (*Player: "“I like the SSC, but want to hear about the others.”"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[201]`
Mówca: **Symon Holl**
> "“Underhall has specifically mentioned their solid track record and highlighted that they do anticipate to go over budget, but that the project will be finished on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: "“I am not sure about Underhall Construction.”"*)
  - -> `[105]` (*Player: "“Underhall seems interesting, but let's hear about the ot..."*)
  - -> `[106]` (*Player: "“I have settled on Underhall Construction. [-2 Government..."*)

### Węzeł `[202]`
Mówca: **Symon Holl**
> "“The project manager from Taurus Holding mentioned that they would be able to finish the project with the allocated funding. They are the only company who found the budget sufficient, making them a cheaper alternative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“I don't feel confident about Taurus Holding.”"*)
  - -> `[69]` (*Player: "“Taurus is definitely worth considering.”"*)
  - -> `[67]` (*Player: "“I have settled on Taurus Holding.”"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: "“I have settled on the SSC. [-1 Government Budget]”"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“I have settled on the SSC. [-2 Government Budget]”"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` AND `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[198]` (Symon Holl), `[87]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState = true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionSSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionSSC = true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_Planned == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“I am on the fence about the SSC.”"*)
  - -> `[89]` (*Player: "“I like the SSC, but want to hear about the others.”"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Symon Holl: "“According to the preliminary calculations of the SSC, th..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 25);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 25);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: "“I think we are off to a good start.”"*)
  - -> `[113]` (*Player: "“That's great news.”"*)
  - -> `[117]` (*Player: "“Good luck to us.”"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
