# Sordland/Turn02/InT_RailwayContract

- **ID konwersacji:** `25`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/025_InT_RailwayContract.md`
- **Liczba węzłów dialogowych:** 221
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
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
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`
- `BaseGameSupport.Journal_Turn02_ConstructionSSC`
- `BaseGameSupport.Journal_Turn02_ConstructionTaurus`
- `BaseGameSupport.Journal_Turn02_ConstructionUnderhall`
- `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand`
- `BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand`
- `BaseGameSupport.News_Turn02_HP_L1_SSC`
- `BaseGameSupport.News_Turn02_HP_L1_Taurus`
- `BaseGameSupport.News_Turn02_HP_L1_Underhall`
- `BaseGameSupport.News_Turn02_ST_L1_SSC`
- `BaseGameSupport.News_Turn02_ST_L1_Taurus`
- `GameCondition.Turn02_InT_Contract`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"“I hope so, Gus.”"** | `[6]` **Gus Manger**: "“That is a given. But we'll also..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Gus Manger**: "“This project will help along my..." |
| `[5]` | **"Look at the files."** | `[15]` **Narrator**: "Symon handed the files over to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Gus Manger**: "“I reviewed the listed corporati..." |
| `[10]` | **"“I trust your economic plans, Symon.”"** | `[6]` **Gus Manger**: "“That is a given. But we'll also..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Symon Holl**: "“I am glad to hear that. We shou..." |
| `[18]` | **"“The Sordish State Corporation.”"** | `[16]` **Symon Holl**: "“Which corporation should we tal..."<br>`[65]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false` | *Brak zmian stanu* | `[32]` **Symon Holl**: "“The respected Sordish State Cor..." |
| `[27]` | **"“Underhall Construction.”"** | `[16]` **Symon Holl**: "“Which corporation should we tal..."<br>`[65]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false` | *Brak zmian stanu* | `[33]` **Symon Holl**: "“The real estate and constructio..." |
| `[31]` | **"“Taurus Holding.”"** | `[16]` **Symon Holl**: "“Which corporation should we tal..."<br>`[65]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false` | *Brak zmian stanu* | `[34]` **Symon Holl**: "“Taurus Holding was founded in 1..." |
| `[43]` | **"“What will it take to stop the recession?”"** | `[41]` **Gus Manger**: "“I am sure we will. According to..."<br>`[42]` **Symon Holl**: "“According to my estimations, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Symon Holl**: "“This is just the beginning. We ..." |
| `[44]` | **"“What kind of end results do we expect?”"** | `[41]` **Gus Manger**: "“I am sure we will. According to..."<br>`[42]` **Symon Holl**: "“According to my estimations, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Symon Holl**: "“Short-term employment and long-..." |
| `[45]` | **"“Failure during this project is not an option.”"** | `[41]` **Gus Manger**: "“I am sure we will. According to..."<br>`[42]` **Symon Holl**: "“According to my estimations, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Gus Manger**: "“You are right. We need to work ..." |
| `[46]` | **"“Do you need additional support?”"** | `[41]` **Gus Manger**: "“I am sure we will. According to..."<br>`[42]` **Symon Holl**: "“According to my estimations, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Symon Holl**: "“Not as of right now. However, t..." |
| `[65]` | **"“I am on the fence about the SSC.”"** | `[193]` **Symon Holl**: "“According to the preliminary ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishSta...` | `[18]` **Player**: "“The Sordish State Corporation.”"<br>`[27]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[66]` | **"“I like the SSC, but want to hear about the others.”"** | `[193]` **Symon Holl**: "“According to the preliminary ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishSta...` | `[18]` **Player**: "“The Sordish State Corporation.”"<br>`[27]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[67]` | **"“I would like to hear your thoughts, Symon.”"** | `[39]` **Gus Manger**: "“I had the chance to work with U..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Symon Holl**: "“I think that they have been doi..." |
| `[68]` | **"“How was your experience with them?”"** | `[39]` **Gus Manger**: "“I had the chance to work with U..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Gus Manger**: "“Out of all three, this is the c..." |
| `[73]` | **"“I have settled on the SSC. [-2 Government Budget]”"** | `[101]` **Narrator**: "It was time to make a decision a..."<br>`[193]` **Symon Holl**: "“According to the preliminary ca..." | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` | `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] ...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"...`<br>*(+1 skryptów)* | `[135]` **Symon Holl**: "“Good that we are staying consis..."<br>`[168]` **Narrator**: "Symon signed a certain section o..." |
| `[76]` | **"“I am not sure about Underhall Construction.”"** | `[194]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallC...` | `[18]` **Player**: "“The Sordish State Corporation.”"<br>`[27]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[77]` | **"“Underhall seems interesting, but let's see the others.”"** | `[194]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallC...` | `[18]` **Player**: "“The Sordish State Corporation.”"<br>`[27]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[78]` | **"“I have settled on Underhall Construction. [-2 Government Budget]”"** | `[101]` **Narrator**: "It was time to make a decision a..."<br>`[194]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstr...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionUnde...`<br>*(+1 skryptów)* | `[140]` **Symon Holl**: "“Good that we are staying consis..."<br>`[169]` **Narrator**: "Symon signed a certain section o..." |
| `[81]` | **"“Why should we pick Taurus?”"** | `[40]` **Gus Manger**: "“They are a very interesting cor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Symon Holl**: "“It would fit our election promi..."<br>`[87]` **Symon Holl**: "“Taurus has completed fewer proj..." |
| `[82]` | **"“Why shouldn't we go with Taurus?”"** | `[40]` **Gus Manger**: "“They are a very interesting cor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Gus Manger**: "“To be frank, what was the large..." |
| `[91]` | **"“I don't feel confident about Taurus Holding.”"** | `[196]` **Symon Holl**: "“The project manager from Taurus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHold...` | `[18]` **Player**: "“The Sordish State Corporation.”"<br>`[27]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[92]` | **"“Taurus is definitely worth considering.”"** | `[196]` **Symon Holl**: "“The project manager from Taurus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHold...` | `[18]` **Player**: "“The Sordish State Corporation.”"<br>`[27]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[93]` | **"“I have settled on Taurus Holding.”"** | `[101]` **Narrator**: "It was time to make a decision a..."<br>`[196]` **Symon Holl**: "“The project manager from Taurus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"]...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionTaur...` | `[145]` **Symon Holl**: "“Good that we are staying consis..."<br>`[170]` **Narrator**: "Symon signed a certain section o..." |
| `[108]` | **"“Thank you. This concludes the meeting.”"** | `[111]` **Gus Manger**: "“It will be a pleasure to celebr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "The meeting ended and we spent t..." |
| `[110]` | **"“I think we are off to a good start.”"** | `[106]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Symon Holl**: "“My expectations are that the gr..." |
| `[113]` | **"“That's great news.”"** | `[106]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Symon Holl**: "“My expectations are that the gr..." |
| `[114]` | **"“Good luck to us.”"** | `[106]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Symon Holl**: "“My expectations are that the gr..." |
| `[118]` | **"“We need to be able to trust the corporation. This is a base requirement for the c..."** | `[70]` **Symon Holl**: "“Nonetheless, they subjected the..."<br>`[74]` **Symon Holl**: "“I am not so sure about trusting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Gus Manger**: "“I think their capabilities are ..." |
| `[119]` | **"“Working conditions must be respected. This doesn't inspire confidence.”"** | `[70]` **Symon Holl**: "“Nonetheless, they subjected the..."<br>`[74]` **Symon Holl**: "“I am not so sure about trusting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: ""Let me just point out that some..." |
| `[122]` | **"“The lack of a dynamic attitude is disappointing.”"** | `[58]` **Gus Manger**: "“There is also the fact that con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Symon Holl**: "“I have no great admiration for ..." |
| `[123]` | **"“The regional railway system has no relation to this.”"** | `[152]` **Gus Manger**: "“Look at the abysmal regional ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Symon Holl**: "“I have no great admiration for ..." |
| `[124]` | **"“The experience they bring to the table is beneficial.”"** | `[58]` **Gus Manger**: "“There is also the fact that con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Symon Holl**: "“I have no great admiration for ..." |
| `[125]` | **"“They do have a wealth of knowledge in infrastructure.”"** | `[152]` **Gus Manger**: "“Look at the abysmal regional ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Symon Holl**: "“I have no great admiration for ..." |
| `[126]` | **"“The innovative aspect is refreshing. Especially if they can deliver.”"** | `[175]` **Symon Holl**: "“It won several awards internati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Gus Manger**: "“That's a big 'if', Mr. Presiden..." |
| `[127]` | **"“It seems like they lack the necessary experience.”"** | `[175]` **Symon Holl**: "“It won several awards internati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Gus Manger**: "“Exactly. And why take such a ri..." |
| `[128]` | **"“We shouldn't put our first project at risk. There is too much at stake here.”"** | `[151]` **Gus Manger**: "“Choosing this corporation is to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Symon Holl**: "“They took a joint contract in A..." |
| `[129]` | **"“Their capabilities matter more than the history they have. We need to make unbias..."** | `[151]` **Gus Manger**: "“Choosing this corporation is to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Symon Holl**: "“They took a joint contract in A..." |
| `[198]` | **"“I have settled on the SSC. [-1 Government Budget]”"** | `[101]` **Narrator**: "It was time to make a decision a..."<br>`[193]` **Symon Holl**: "“According to the preliminary ca..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] ...`<br>`Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"...`<br>*(+1 skryptów)* | `[135]` **Symon Holl**: "“Good that we are staying consis..."<br>`[168]` **Narrator**: "Symon signed a certain section o..." |
| `[210]` | **"“Just wanted to try my chances.""** | `[209]` **Gus Manger**: "“Appreciate you taking up my off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Gus Manger**: "“One has to play the game to be ..." |
| `[211]` | **"“Thanks for arranging the opportunity. I'll treat you to a 30-year-old Erlory Maro..."** | `[209]` **Gus Manger**: "“Appreciate you taking up my off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Gus Manger**: "“My pleasure, Mr. President. I'm..." |
| `[215]` | **"“*If* being the key word. I might lose all the money I put in.”"** | `[209]` **Gus Manger**: "“Appreciate you taking up my off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Gus Manger**: "“The least likely scenario. You ..." |

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
  - -> `[8]` (*Narrator: "We arrived in Anrica by train. After being greeted by cro..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We were here for a significant meeting about the L-1 project. Several construction companies sent their representatives to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "“I hope so, Gus.”"]** — Mówca: **Player**
> "“I hope so, Gus.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gus Manger: "“This project will help along my rural development plans ..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "Look at the files."]** — Mówca: **Player_Italic**
> "I looked at the files. Three corporations were listed. The Sordish State Corporation, Underhall Construction and Taurus Holding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Gus Manger: "“I reviewed the listed corporations. I also wrote down so..."*)

### Węzeł `[6]`
Mówca: **Gus Manger**
> "“That is a given. But we'll also see improvements in everything from logistics to growth. You made the right choice for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“I trust your economic plans, Symon.”"*)
  - -> `[4]` (*Player: "“I hope so, Gus.”"*)

### Węzeł `[7]`
Mówca: **Symon Holl**
> "“I came by train yesterday and it was a little uncomfortable. Besides starting our economic recovery, this project will make the journey here much more pleasant, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Gus Manger: "“That is a given. But we'll also see improvements in ever..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "We arrived in Anrica by train. After being greeted by crowds of cheering citizens and the local government officials, we headed to the city hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "We were here for a significant meeting about the L-1 proj..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Even though Lileas Graf couldn't make the meeting, I had Symon Holl and Gus Manger by my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: "“I came by train yesterday and it was a little uncomforta..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I trust your economic plans, Symon.”"]** — Mówca: **Player**
> "“I trust your economic plans, Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Symon Holl: "“I am glad to hear that. We should be able to slow down t..."*)

### Węzeł `[11]`
Mówca: **Symon Holl**
> "“I am glad to hear that. We should be able to slow down the recession if we finish this project successfully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gus Manger: "“I am sure we will. According to your document many citiz..."*)

### Węzeł `[12]`
Mówca: **Gus Manger**
> "“This project will help along my rural development plans by attracting new businesses to the area. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Symon Holl: "“According to my estimations, the new railway will give a..."*)

### Węzeł `[13]`
Mówca: **Symon Holl**
> "“I have the overview of the companies here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Symon handed the files over to me."*)

### Węzeł `[14]`
Mówca: **Gus Manger**
> "“I reviewed the listed corporations. I also wrote down some notes and ideas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Symon Holl: "“Which corporation should we talk about?”"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Symon handed the files over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Italic: "Look at the files."*)

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“Which corporation should we talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Railway Companies Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“The Sordish State Corporation.”"]** — Mówca: **Player**
> "“The Sordish State Corporation.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Symon Holl), `[65]` (Player), `[66]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Symon Holl: "“The respected Sordish State Corporation, also known as t..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp =..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“The Sordish State Corporation.”"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "Jump to: [Railway Companies Hub]"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Railway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruct..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“Underhall Construction.”"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Underhall Construction.”"]** — Mówca: **Player**
> "“Underhall Construction.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Symon Holl), `[65]` (Player), `[66]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: "“The real estate and construction giant was founded in 19..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == f..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Taurus Holding.”"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Taurus Holding.”"]** — Mówca: **Player**
> "“Taurus Holding.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Symon Holl), `[65]` (Player), `[66]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Symon Holl: "“Taurus Holding was founded in 1946 and is owned by the e..."*)

### Węzeł `[32]`
Mówca: **Symon Holl**
> "“The respected Sordish State Corporation, also known as the SSC, was founded in 1891.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Symon Holl: "“It is the main state corporation tasked with running the..."*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> "“The real estate and construction giant was founded in 1925 and expanded during the economic boom of the '30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[34]`
Mówca: **Symon Holl**
> "“Taurus Holding was founded in 1946 and is owned by the entrepreneur Geralt Fais.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Symon Holl: "“It is a new holding company whose subsidiaries use cutti..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp =..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "It was time to make a decision about which company to awa..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Gus Manger**
> "“The SSC is the primary reason why our current infrastructure is outdated. We need more adaptive construction companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“I had the chance to work with Underhall Construction in Holsord. They took several contracts for the central station renovation and excelled at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“I would like to hear your thoughts, Symon.”"*)
  - -> `[68]` (*Player: "“How was your experience with them?”"*)

### Węzeł `[40]`
Mówca: **Gus Manger**
> "“They are a very interesting corporation, especially because of their innovative construction methods. But I don't think they're suitable for large projects like these.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "“Why should we pick Taurus?”"*)
  - -> `[82]` (*Player: "“Why shouldn't we go with Taurus?”"*)

### Węzeł `[41]`
Mówca: **Gus Manger**
> "“I am sure we will. According to your document many citizens will be employed because of business expansions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“What will it take to stop the recession?”"*)
  - -> `[44]` (*Player: "“What kind of end results do we expect?”"*)
  - -> `[45]` (*Player: "“Failure during this project is not an option.”"*)
  - -> `[46]` (*Player: "“Do you need additional support?”"*)

### Węzeł `[42]`
Mówca: **Symon Holl**
> "“According to my estimations, the new railway will give about 50.000 citizens from the Greater Holsord and Gelsland areas employment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“What will it take to stop the recession?”"*)
  - -> `[44]` (*Player: "“What kind of end results do we expect?”"*)
  - -> `[45]` (*Player: "“Failure during this project is not an option.”"*)
  - -> `[46]` (*Player: "“Do you need additional support?”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“What will it take to stop the recession?”"]** — Mówca: **Player**
> "“What will it take to stop the recession?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Gus Manger), `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Symon Holl: "“This is just the beginning. We will need to follow this ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“What kind of end results do we expect?”"]** — Mówca: **Player**
> "“What kind of end results do we expect?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Gus Manger), `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Symon Holl: "“Short-term employment and long-term economic development..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Failure during this project is not an option.”"]** — Mówca: **Player**
> "“Failure during this project is not an option.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Gus Manger), `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“You are right. We need to work together and think things..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Do you need additional support?”"]** — Mówca: **Player**
> "“Do you need additional support?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Gus Manger), `[42]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Symon Holl: "“Not as of right now. However, things might come up if th..."*)

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“This is just the beginning. We will need to follow this project up with several other economic investments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Gus Manger: "“Which is dependent on our government budget, right?”"*)

### Węzeł `[48]`
Mówca: **Symon Holl**
> "“Not as of right now. However, things might come up if the project doesn't go according to plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Gus Manger: "“I agree with Symon. Additional financial or political su..."*)

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“You are right. We need to work together and think things through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Symon Holl: "“Our economic revitalization plan is set to be a success...."*)

### Węzeł `[50]`
Mówca: **Symon Holl**
> "“Short-term employment and long-term economic development in the Gelsland and Greater Holsord regions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gus Manger: "“There are so many forgotten people living in the less de..."*)

### Węzeł `[51]`
Mówca: **Gus Manger**
> "“Which is dependent on our government budget, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Symon Holl: "“Yes.”"*)

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“There are so many forgotten people living in the less developed areas between Lachaven and Holsord. They will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“Our economic revitalization plan is set to be a success. Failure is indeed not an option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[54]`
Mówca: **Gus Manger**
> "“I agree with Symon. Additional financial or political support might be necessary if certain parties or issues block us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Symon searched through the documents he was holding and f..."*)

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“They have experience, knowledge and manpower for a project this size. I'm not so sure about their efficiency, though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Gus Manger: "“There is also the fact that construction times are long...."*)

### Węzeł `[57]`
Mówca: **Gus Manger**
> "“The Sordish State Corporation lacks a modern way of thinking. They also under-perform with their slow construction methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Gus stopped and laughed."*)

### Węzeł `[58]`
Mówca: **Gus Manger**
> "“There is also the fact that construction times are long. Which is mostly due to their outdated methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“The experience they bring to the table is beneficial.”"*)
  - -> `[122]` (*Player: "“The lack of a dynamic attitude is disappointing.”"*)

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“I have no great admiration for the SSC, but their track record clearly shows completed contracts with thousands of employees who have experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Symon Holl: "“According to the preliminary calculations of the SSC, th..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_Planned == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Symon Holl: "“However, this would fulfil your initial election promise..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“The disadvantage would be going against your election pr..."*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“The disadvantage would be going against your election promises of moving away from a state-dominant economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gus Manger: "“The Sordish State Corporation lacks a modern way of thin..."*)

### Węzeł `[64]`
Mówca: **Symon Holl**
> "“However, this would fulfil your initial election promise of using a state-dominant planned economy to improve the bleak recession situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Symon Holl: "“They have experience, knowledge and manpower for a proje..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I am on the fence about the SSC.”"]** — Mówca: **Player**
> "“I am on the fence about the SSC.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I like the SSC, but want to hear about the others.”"]** — Mówca: **Player**
> "“I like the SSC, but want to hear about the others.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I would like to hear your thoughts, Symon.”"]** — Mówca: **Player**
> "“I would like to hear your thoughts, Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Symon Holl: "“I think that they have been doing relatively well in the..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“How was your experience with them?”"]** — Mówca: **Player**
> "“How was your experience with them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Gus Manger: "“Out of all three, this is the company I can trust. They ..."*)

### Węzeł `[69]`
Mówca: **Symon Holl**
> "“I think that they have been doing relatively well in the private sector, where they are dominating the construction industry with successful projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Symon Holl: "“Nonetheless, they subjected their workers to conditions ..."*)

### Węzeł `[70]`
Mówca: **Symon Holl**
> "“Nonetheless, they subjected their workers to conditions below our working standards during the Holsord Central Station contract. Which is troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“Working conditions must be respected. This doesn't inspi..."*)
  - -> `[118]` (*Player: "“We need to be able to trust the corporation. This is a b..."*)

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“Having worked on the renovation project, I can say that the conditions were not bad. Extra effort was needed to finish it on time, which they did. That is all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Symon Holl: "“Underhall has specifically mentioned their solid track r..."*)

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“Out of all three, this is the company I can trust. They work hard, long and fast to accomplish their contracts. They will get this done if we give it to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Symon Holl: "“I am not so sure about trusting them with such a big con..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator), `[193]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState = true"*)

### Węzeł `[74]`
Mówca: **Symon Holl**
> "“I am not so sure about trusting them with such a big contract. Especially after certain issues surrounding the treatment of their workers. But at least they have worked on several mega-projects and always delivered on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“Working conditions must be respected. This doesn't inspi..."*)
  - -> `[118]` (*Player: "“We need to be able to trust the corporation. This is a b..."*)

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“They worked on two infrastructure projects in Gelsland and one in Greater Holsord that were worth two billion Ren in total.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Symon Holl: "“Underhall has specifically mentioned their solid track r..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I am not sure about Underhall Construction.”"]** — Mówca: **Player**
> "“I am not sure about Underhall Construction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Underhall seems interesting, but let's see the others.”"]** — Mówca: **Player**
> "“Underhall seems interesting, but let's see the others.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I have settled on Underhall Construction. [-2 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Underhall Construction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator), `[194]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction = t..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Railway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "Jump to: [Railway Companies Hub]"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Why should we pick Taurus?”"]** — Mówca: **Player**
> "“Why should we pick Taurus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Why shouldn't we go with Taurus?”"]** — Mówca: **Player**
> "“Why shouldn't we go with Taurus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gus Manger: "“To be frank, what was the largest mega-project they work..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Symon Holl: "“It would fit our election promises of switching to a fre..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“Taurus has completed fewer projects than the other compa..."*)

### Węzeł `[86]`
Mówca: **Gus Manger**
> "“To be frank, what was the largest mega-project they worked on? I don't even remember.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Gus shook his head."*)

### Węzeł `[87]`
Mówca: **Symon Holl**
> "“Taurus has completed fewer projects than the other companies. However, they are slightly faster and cheaper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Symon Holl: "“It won several awards internationally for being one of t..."*)

### Węzeł `[88]`
Mówca: **Symon Holl**
> "“It would fit our election promises of switching to a free-market economy. Awarding contracts to privately owned corporations would be a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Symon Holl: "“Taurus has completed fewer projects than the other compa..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Railway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "Jump to: [Railway Companies Hub]"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“I don't feel confident about Taurus Holding.”"]** — Mówca: **Player**
> "“I don't feel confident about Taurus Holdings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Taurus is definitely worth considering.”"]** — Mówca: **Player**
> "“Taurus is definitely worth considering.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding.”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator), `[196]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding = true"*)

### Węzeł `[94]`
Mówca: **Gus Manger**
> "“Exactly. And why take such a risk now? We need to play it safer with companies like Underhall. They've always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Symon Holl: "“The project manager from Taurus Holding mentioned that t..."*)

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“If we are going to try a different company, this one is the most unique.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Symon Holl: "“The project manager from Taurus Holding mentioned that t..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction = true; BaseGame.Turn04_InT_RailwayIssue_Solved = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] = true;
Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionUnderhall = true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionTaurus = true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionSSC = true"*)

### Węzeł `[99]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled = false"*)

### Węzeł `[100]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group will be pleased. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled = true"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "It was time to make a decision about which company to award the L-1 High-Speed Railway contract to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[78]` (*Player: "“I have settled on Underhall Construction. [-2 Government..."*)
  - -> `[93]` (*Player: "“I have settled on Taurus Holding.”"*)

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Gus Manger: "“No hard feelings, Mr. President. At the end of the day, ..."*)

### Węzeł `[103]`
Mówca: **Gus Manger**
> "“No hard feelings, Mr. President. At the end of the day, the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Symon Holl: "“The company will be notified today, and construction wor..."*)

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“You made the right choice. I can tell from my experience that we will be very satisfied with this company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Symon Holl: "“The company will be notified today, and construction wor..."*)

### Węzeł `[105]`
Mówca: **Gus Manger**
> "“No hard feelings, Mr. President. At the end of the day the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Symon Holl: "“The company will be notified today, and construction wor..."*)

### Węzeł `[106]`
Mówca: **Symon Holl**
> "“The company will be notified today, and construction work will begin immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 25);  // Updates token..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "The meeting ended and we spent the remainder of the day attending events in Anrica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "It was very refreshing to attend cultural dance events an..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Thank you. This concludes the meeting.”"]** — Mówca: **Player**
> "“Thank you. This concludes the meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The meeting ended and we spent the remainder of the day a..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_InT_Contract = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_InT_Contract"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I think we are off to a good start.”"]** — Mówca: **Player**
> "“I think we are off to a good start.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Symon Holl: "“My expectations are that the grand opening ceremony will..."*)

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“It will be a pleasure to celebrate together. For now, I'll return to my duties and visit some foreign partners in Rizia. See you soon, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“Thank you. This concludes the meeting.”"*)

### Węzeł `[112]`
Mówca: **Symon Holl**
> "“My expectations are that the grand opening ceremony will be late next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Gus Manger: "“It will be a pleasure to celebrate together. For now, I'..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“That's great news.”"]** — Mówca: **Player**
> "“That is great news.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Symon Holl: "“My expectations are that the grand opening ceremony will..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Good luck to us.”"]** — Mówca: **Player**
> "“Good luck to us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Symon Holl: "“My expectations are that the grand opening ceremony will..."*)

### Węzeł `[115]`
Mówca: **Symon Holl**
> "“It is the main state corporation tasked with running the day-to-day construction services of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Gus Manger: "“The SSC is the primary reason why our current infrastruc..."*)

### Węzeł `[116]`
Mówca: **Symon Holl**
> "“The CEO of Underhall is Kris Schar, the mayor of Conriat. He sold half of his shares a few years ago but seemed very eager about the L-1 bid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Gus Manger: "“I had the chance to work with Underhall Construction in ..."*)

### Węzeł `[117]`
Mówca: **Symon Holl**
> "“It is a new holding company whose subsidiaries use cutting-edge technology from Arcasia to reduce construction costs and prices. They are known to provide for their workers, who are part of the Labour Union of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Gus Manger: "“They are a very interesting corporation, especially beca..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“We need to be able to trust the corporation. This is a base requirement for the contract.”"]** — Mówca: **Player**
> "“We need to be able to trust the corporation. This is a base requirement for the contract.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Symon Holl), `[74]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Gus Manger: "“I think their capabilities are very suitable for the L-1..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Working conditions must be respected. This doesn't inspire confidence.”"]** — Mówca: **Player**
> "“Working conditions must be respected. This doesn't inspire confidence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Symon Holl), `[74]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: ""Let me just point out that some of the workers were Agno..."*)

### Węzeł `[120]`
Mówca: **Gus Manger**
> ""Let me just point out that some of the workers were Agnolian and Wehzek. Technically, Sordish labor laws didn't apply to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gus Manger: "“Having worked on the renovation project, I can say that ..."*)

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“I think their capabilities are very suitable for the L-1 Railway project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gus Manger: "“They worked on two infrastructure projects in Gelsland a..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“The lack of a dynamic attitude is disappointing.”"]** — Mówca: **Player**
> "“The lack of a dynamic attitude is disappointing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“I have no great admiration for the SSC, but their track ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“The regional railway system has no relation to this.”"]** — Mówca: **Player**
> "“The regional railway system has no relation to this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“I have no great admiration for the SSC, but their track ..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“The experience they bring to the table is beneficial.”"]** — Mówca: **Player**
> "“The experience they bring to the table is beneficial.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“I have no great admiration for the SSC, but their track ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“They do have a wealth of knowledge in infrastructure.”"]** — Mówca: **Player**
> "“They do have a wealth of knowledge in infrastructure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“I have no great admiration for the SSC, but their track ..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“The innovative aspect is refreshing. Especially if they can deliver.”"]** — Mówca: **Player**
> "“The innovative aspect is refreshing. Especially if they can deliver.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Gus Manger: "“That's a big 'if', Mr. President. We need to play it saf..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“It seems like they lack the necessary experience.”"]** — Mówca: **Player**
> "“It seems like they lack the necessary experience.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gus Manger: "“Exactly. And why take such a risk now? We need to play i..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“We shouldn't put our first project at risk. There is too much at stake here.”"]** — Mówca: **Player**
> "“We shouldn't put our first project at risk. There is too much at stake here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Symon Holl: "“They took a joint contract in Arcasia for restructuring ..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"]** — Mówca: **Player**
> "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Symon Holl: "“They took a joint contract in Arcasia for restructuring ..."*)

### Węzeł `[130]`
Mówca: **Symon Holl**
> "“Picking this corporation would fit our market economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Symon Holl: "“The CEO of Underhall is Kris Schar, the mayor of Conriat..."*)

### Węzeł `[131]`
Mówca: **Symon Holl**
> "“Picking this corporation would go against our planned economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Symon Holl: "“The CEO of Underhall is Kris Schar, the mayor of Conriat..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Symon Holl: "“Picking this corporation would fit our market economy po..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Symon Holl: "“Picking this corporation would go against our planned ec..."*)

### Węzeł `[135]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[140]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[145]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "It was very refreshing to attend cultural dance events and hear the traditional Sordish music of the region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[151]`
Mówca: **Gus Manger**
> "“Choosing this corporation is too risky for a project like this. What if things were to go wrong?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: "“We shouldn't put our first project at risk. There is too..."*)
  - -> `[129]` (*Player: "“Their capabilities matter more than the history they hav..."*)

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“Look at the abysmal regional railway system!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "“The regional railway system has no relation to this.”"*)
  - -> `[125]` (*Player: "“They do have a wealth of knowledge in infrastructure.”"*)

### Węzeł `[153]`
Mówca: **Symon Holl**
> "“They took a joint contract in Arcasia for restructuring the highway intersection of one of the major cities. It went well, but it is their only large-scale success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Symon Holl: "“If we are going to try a different company, this one is ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Symon Holl: "“Some in the Lotherberg Group will be pleased. The contra..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Symon Holl: "“Some in the Lotherberg Group won't like this, but the co..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDeman..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDeman..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Symon Holl: "“Some in the Lotherberg Group won't like this, but the co..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[165]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Gus Manger: "“You made the right choice. I can tell from my experience..."*)

### Węzeł `[166]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled = false"*)

### Węzeł `[167]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gus Manger: "“No hard feelings, Mr. President. At the end of the day t..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[169]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Gus shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Gus Manger: "“Choosing this corporation is too risky for a project lik..."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Gus stopped and laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Gus Manger: "“Look at the abysmal regional railway system!”"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand =..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Symon searched through the documents he was holding and found the one he was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Symon Holl: "“I have the overview of the companies here.”"*)

### Węzeł `[175]`
Mówca: **Symon Holl**
> "“It won several awards internationally for being one of the fastest growing and advanced companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: "“The innovative aspect is refreshing. Especially if they ..."*)
  - -> `[127]` (*Player: "“It seems like they lack the necessary experience.”"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_L1_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_L1_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_L1_Taurus = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_L1_SSC = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_L1_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_L1_SSC = true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_L1_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_L1_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_InT_Contract = true"*)

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
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_L1_Underhall = true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_L1_Taurus = true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_L1_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_InT_Contract = true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_L1_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_L1_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_InT_Contract = true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionUnderhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionUnderhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionTaurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionTaurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionSSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Gus Manger: "“No hard feelings, Mr. President. At the end of the day, ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_FulfilledTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Gus Manger: "“You made the right choice. I can tell from my experience..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_DidntFulfillTuskBribeDemand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gus Manger: "“No hard feelings, Mr. President. At the end of the day t..."*)

### Węzeł `[193]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they would need more resources to finish a project of this size.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“I am on the fence about the SSC.”"*)
  - -> `[66]` (*Player: "“I like the SSC, but want to hear about the others.”"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[194]`
Mówca: **Symon Holl**
> "“Underhall has specifically mentioned their solid track record and highlighted that they do anticipate to go over budget, but that they will finish on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“I am not sure about Underhall Construction.”"*)
  - -> `[77]` (*Player: "“Underhall seems interesting, but let's see the others.”"*)
  - -> `[78]` (*Player: "“I have settled on Underhall Construction. [-2 Government..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[196]`
Mówca: **Symon Holl**
> "“The project manager from Taurus Holding mentioned that they would be able to finish the project with the allocated funding. They are the only company who found the budget sufficient, making them a cheaper alternative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“I don't feel confident about Taurus Holding.”"*)
  - -> `[92]` (*Player: "“Taurus is definitely worth considering.”"*)
  - -> `[93]` (*Player: "“I have settled on Taurus Holding.”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator), `[193]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState = true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: "“I have settled on the SSC. [-1 Government Budget]”"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“I have settled on the SSC. [-2 Government Budget]”"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ConstructionSSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ConstructionSSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ConstructionSSC = true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend =..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Even though Lileas Graf couldn't make the meeting, I had ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Gus was first to arrive. He greeted me with a heartwarmin..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Gus was first to arrive. He greeted me with a heartwarming smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Gus Manger: "“Hello Mr President. Good to see you again.”"*)

### Węzeł `[208]`
Mówca: **Gus Manger**
> "“Hello Mr President. Good to see you again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Gus Manger: "“Appreciate you taking up my offer on the stock investmen..."*)

### Węzeł `[209]`
Mówca: **Gus Manger**
> "“Appreciate you taking up my offer on the stock investment. Armadine is a very promising corporation, and if everything goes well you will make solid returns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: "“Thanks for arranging the opportunity. I'll treat you to ..."*)
  - -> `[215]` (*Player: "“*If* being the key word. I might lose all the money I pu..."*)
  - -> `[210]` (*Player: "“Just wanted to try my chances.""*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "“Just wanted to try my chances.""]** — Mówca: **Player**
> "“Just wanted to try my chances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Gus Manger: "“One has to play the game to be able to win.”"*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "“Thanks for arranging the opportunity. I'll treat you to a 30-year-old Erlory Maroon if they make solid profits.”"]** — Mówca: **Player**
> "“Thanks for arranging the opportunity. I'll treat you to a 30-year-old Erlory Maroon if they make solid profits.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Gus Manger: "“My pleasure, Mr. President. I'm looking forward to that ..."*)

### Węzeł `[212]`
Mówca: **Gus Manger**
> "“My pleasure, Mr. President. I'm looking forward to that Erlory Maroon already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Symon Holl joined us. After settling down, we moved on to..."*)

### Węzeł `[213]`
Mówca: **Gus Manger**
> "“One has to play the game to be able to win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Symon Holl joined us. After settling down, we moved on to..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Symon Holl joined us. After settling down, we moved on to discuss the details of the L-1 Railway project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: "“I came by train yesterday and it was a little uncomforta..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“*If* being the key word. I might lose all the money I put in.”"]** — Mówca: **Player**
> "“*If* being the key word. I might lose all the money I put in.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Gus Manger: "“The least likely scenario. You can trust me on these sub..."*)

### Węzeł `[216]`
Mówca: **Gus Manger**
> "“The least likely scenario. You can trust me on these subjects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Symon Holl joined us. After settling down, we moved on to..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 25);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 25);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“I think we are off to a good start.”"*)
  - -> `[113]` (*Player: "“That's great news.”"*)
  - -> `[114]` (*Player: "“Good luck to us.”"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[220]`
Mówca: **Gus Manger**
> "“That's a big 'if', Mr. President. We need to play it safer with companies like Underhall. They've always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Symon Holl: "“The project manager from Taurus Holding mentioned that t..."*)
