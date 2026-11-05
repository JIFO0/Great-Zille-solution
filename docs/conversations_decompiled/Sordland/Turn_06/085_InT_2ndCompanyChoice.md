# Sordland/Turn06/InT_2ndCompanyChoice

- **ID konwersacji:** `85`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/085_InT_2ndCompanyChoice.md`
- **Liczba węzłów dialogowych:** 213
- **Liczba wyborów gracza:** 33

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
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.Decision_Turn06_Megaproject_Conriat`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.Promise_Economy_FreeMarket`
- `BaseGame.Promise_Economy_Planned`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn06_InT_SordishState`
- `BaseGame.Turn06_InT_Underhall`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy_Consistent`
- `BaseGame.GovernmentBudget`
- `BaseGame.Turn06_InT_SordishState`
- `BaseGame.Turn06_InT_Taurus`
- `BaseGame.Turn06_InT_Underhall`
- `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp`
- `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding`
- `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction`
- `BaseGameSupport.Journal_Turn06_Company_SSC`
- `BaseGameSupport.Journal_Turn06_Company_Taurus`
- `BaseGameSupport.Journal_Turn06_Company_Underhall`
- `GameCondition.Turn06_InT_Investment2CompanyChoice`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"Look at the files."** | `[21]` **Narrator**: "Symon handed the files over to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Gus Manger**: "“I reviewed the listed corporati..." |
| `[8]` | **"“That's great news.”"** | `[99]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Symon Holl**: "“My expectations for a grand ope..." |
| `[10]` | **"“Underhall seems interesting but let's see the others.”"** | `[62]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallC...` | `[34]` **Player**: "“The Sordish State Corporation.”"<br>`[44]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[11]` | **"“They do have a wealth of knowledge in infrastructure.”"** | `[69]` **Gus Manger**: "“Look at the abysmal regional ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Symon Holl**: "“I don't share a great admiratio..." |
| `[17]` | **"“The experience they bring to the table is beneficial.”"** | `[83]` **Gus Manger**: "“There is also the fact that con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Symon Holl**: "“I don't share a great admiratio..." |
| `[34]` | **"“The Sordish State Corporation.”"** | `[24]` **Symon Holl**: "“Which corporation should we tal..."<br>`[94]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false` | *Brak zmian stanu* | `[54]` **Symon Holl**: "“The respected Sordish State Cor..." |
| `[40]` | **"“How was your experience with them?”"** | `[65]` **Gus Manger**: "“I had the chance to work with U..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Gus Manger**: "“Out of all three, this is the c..." |
| `[44]` | **"“Underhall Construction.”"** | `[24]` **Symon Holl**: "“Which corporation should we tal..."<br>`[94]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false` | *Brak zmian stanu* | `[55]` **Symon Holl**: "“The real estate and constructio..." |
| `[52]` | **"“Taurus Holding.”"** | `[24]` **Symon Holl**: "“Which corporation should we tal..."<br>`[94]` **Player**: "“I am on the fence about the SSC.”"<br>*(oraz 5 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false` | *Brak zmian stanu* | `[57]` **Symon Holl**: "“Taurus Holding was founded in 1..." |
| `[70]` | **"“Good luck to us.”"** | `[99]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Symon Holl**: "“My expectations for a grand ope..." |
| `[74]` | **"“I think we are off to a good start.”"** | `[99]` **Symon Holl**: "“The company will be notified to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Symon Holl**: "“My expectations for a grand ope..." |
| `[75]` | **"“Their capabilities matter more than the history they have. We need to make unbias..."** | `[68]` **Gus Manger**: "“Choosing this corporation is to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Symon Holl**: "“They took a joint contract in A..." |
| `[76]` | **"“We shouldn't put our first project at risk. There is too much at stake here.”"** | `[68]` **Gus Manger**: "“Choosing this corporation is to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Symon Holl**: "“They took a joint contract in A..." |
| `[77]` | **"“It seems like they lack the necessary experience.”"** | `[115]` **Symon Holl**: "“It won several awards internati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Gus Manger**: "“Exactly. And why take such a ri..." |
| `[78]` | **"“The innovative aspect is refreshing. Especially if they can deliver.”"** | `[115]` **Symon Holl**: "“It won several awards internati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Gus Manger**: "“But why take such a risk now? E..." |
| `[80]` | **"“Thank you. This concludes the meeting.”"** | `[73]` **Gus Manger**: "“I will be returning to my dutie..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn06_Company_Underhal...`<br>`Variable["GameCondition.Turn06_InT_Investment2CompanyChoi...`<br>*(+3 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[92]` | **"“We need to be able to trust the corporation. This is a base requirement for the c..."** | `[102]` **Symon Holl**: "“Nonetheless, they treated their..."<br>`[106]` **Symon Holl**: "“I am not so sure about trusting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Gus Manger**: "“I think their capabilities are ..." |
| `[93]` | **"“The regional railway system has no relation to this.”"** | `[69]` **Gus Manger**: "“Look at the abysmal regional ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Symon Holl**: "“I don't share a great admiratio..." |
| `[94]` | **"“I am on the fence about the SSC.”"** | `[64]` **Symon Holl**: "“According to the preliminary ca..."<br>`[187]` **Symon Holl**: "“According to the preliminary ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishSta...` | `[34]` **Player**: "“The Sordish State Corporation.”"<br>`[44]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[95]` | **"“I like the SSC, but want to hear about the others.”"** | `[64]` **Symon Holl**: "“According to the preliminary ca..."<br>`[187]` **Symon Holl**: "“According to the preliminary ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishSta...` | `[34]` **Player**: "“The Sordish State Corporation.”"<br>`[44]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[96]` | **"“The lack of a dynamic attitude is disappointing.”"** | `[83]` **Gus Manger**: "“There is also the fact that con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Symon Holl**: "“I don't share a great admiratio..." |
| `[98]` | **"“I would like to hear your thoughts, Symon.”"** | `[65]` **Gus Manger**: "“I had the chance to work with U..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Symon Holl**: "“I think that they have been doi..." |
| `[100]` | **"“Why shouldn't we go with, Taurus?”"** | `[66]` **Gus Manger**: "“They are a very interesting cor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Gus Manger**: "“To be frank, what was the large..." |
| `[105]` | **"“I have settled on the SSC. [-1 Government Budget]”"** | `[64]` **Symon Holl**: "“According to the preliminary ca..."<br>`[143]` **Narrator**: "It was time to make a decision a..." | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Turn06_InT_SordishState"] = true;` | `[29]` **Symon Holl**: "“Good that we are staying consis..."<br>`[89]` **Narrator**: "Symon signed a certain section o..." |
| `[110]` | **"“I am not sure about Underhall Construction.”"** | `[62]` **Symon Holl**: "“Underhall has specifically ment..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallC...` | `[34]` **Player**: "“The Sordish State Corporation.”"<br>`[44]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[112]` | **"“I have settled on Underhall Construction. [-1 Government Budget]”"** | `[62]` **Symon Holl**: "“Underhall has specifically ment..."<br>`[143]` **Narrator**: "It was time to make a decision a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn06_InT_Underhall"] = true;`<br>`Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[16]` **Symon Holl**: "“Good that we are staying consis..."<br>`[97]` **Narrator**: "Symon signed a certain section o..." |
| `[117]` | **"“Why should we pick, Taurus?”"** | `[66]` **Gus Manger**: "“They are a very interesting cor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Symon Holl**: "“It would fit our election promi..."<br>`[124]` **Symon Holl**: "“Taurus has completed fewer proj..." |
| `[118]` | **"“Working conditions must be respected. This doesn't inspire confidence.”"** | `[102]` **Symon Holl**: "“Nonetheless, they treated their..."<br>`[106]` **Symon Holl**: "“I am not so sure about trusting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Gus Manger**: "Yes, but some of the workers wer..." |
| `[130]` | **"“I don't feel confident about Taurus Holding.”"** | `[56]` **Symon Holl**: "“The project manager from Taurus..."<br>`[186]` **Symon Holl**: "“But, the project manager from T..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHold...` | `[34]` **Player**: "“The Sordish State Corporation.”"<br>`[44]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[131]` | **"“Taurus is definitely worth considering.”"** | `[56]` **Symon Holl**: "“The project manager from Taurus..."<br>`[186]` **Symon Holl**: "“But, the project manager from T..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHold...` | `[34]` **Player**: "“The Sordish State Corporation.”"<br>`[44]` **Player**: "“Underhall Construction.”"<br>*(oraz 2 innych odgałęzień)* |
| `[132]` | **"“I have settled on Taurus Holding.”"** | `[56]` **Symon Holl**: "“The project manager from Taurus..."<br>`[143]` **Narrator**: "It was time to make a decision a..." | `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false` | `Variable["BaseGame.Turn06_InT_Taurus"] = true;` | `[18]` **Symon Holl**: "“Good that we are staying consis..."<br>`[119]` **Narrator**: "Symon signed a certain section o..." |
| `[188]` | **"“I have settled on the SSC.”"** | `[187]` **Symon Holl**: "“According to the preliminary ca..."<br>`[143]` **Narrator**: "It was time to make a decision a..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | `Variable["BaseGame.Turn06_InT_SordishState"] = true;` | `[29]` **Symon Holl**: "“Good that we are staying consis..."<br>`[89]` **Narrator**: "Symon signed a certain section o..." |
| `[190]` | **"“I have settled on Taurus Holding. [-1 Government Budget]”"** | `[186]` **Symon Holl**: "“But, the project manager from T..."<br>`[143]` **Narrator**: "It was time to make a decision a..." | `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Turn06_InT_Taurus"] = true;` | `[18]` **Symon Holl**: "“Good that we are staying consis..."<br>`[119]` **Narrator**: "Symon signed a certain section o..." |

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
  - -> `[7]` (*Narrator: "We met with Symon and Gus to pick a company for our new g..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Benfi International Airport was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Benfi", "Progress_Internati..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Look at the files."]** — Mówca: **Player_Italic**
> "I looked at the files. Three corporations were listed. The Sordish State Corporation, Underhall Construction and Taurus Holding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Gus Manger: "“I reviewed the listed corporations. I also wrote down so..."*)

### Węzeł `[5]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Symon started searching the documents he was holding for ..."*)

### Węzeł `[6]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and expanding our air network, this project will boost tourism in Benfi heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "We met with Symon and Gus to pick a company for our new government project."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“That's great news.”"]** — Mówca: **Player**
> "“That is great news.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: "“My expectations for a grand opening ceremony are late ne..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Symon Holl: "“Besides supporting our economic recovery and expanding o..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Underhall seems interesting but let's see the others.”"]** — Mówca: **Player**
> "“Underhall seems interesting but let's see the others.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“They do have a wealth of knowledge in infrastructure.”"]** — Mówca: **Player**
> "“They do have a wealth of knowledge in infrastructure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Symon Holl: "“I don't share a great admiration for the SSC but their t..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“The experience they bring to the table is beneficial.”"]** — Mówca: **Player**
> "“The experience they bring to the table is beneficial.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Symon Holl: "“I don't share a great admiration for the SSC but their t..."*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“I have the overview of the companies here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Symon handed the files over to me."*)

### Węzeł `[20]`
Mówca: **Gus Manger**
> "“I reviewed the listed corporations. I also wrote down some notes and ideas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Symon Holl: "“Which corporation should we talk about?”"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Symon handed the files over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Italic: "Look at the files."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_SordishState = true"*)

### Węzeł `[24]`
Mówca: **Symon Holl**
> "“Which corporation should we talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Consistent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Consistent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[29]`
Mówca: **Symon Holl**
> "“Good that we are staying consistent to our economic strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Consistent = true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Railway Companies Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: "“Good that we are staying consistent to our economic stra..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Symon signed a certain section of the dossier and fixed h..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“The Sordish State Corporation.”"]** — Mówca: **Player**
> "“The Sordish State Corporation.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Symon Holl), `[94]` (Player), `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Symon Holl: "“The respected Sordish State Corporation also known as th..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp =..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“The Sordish State Corporation.”"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "Jump to: [Railway Companies Hub]"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Railway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“How was your experience with them?”"]** — Mówca: **Player**
> "“How was your experience with them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Gus Manger: "“Out of all three, this is the company I can trust. They ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruct..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Underhall Construction.”"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Underhall Construction.”"]** — Mówca: **Player**
> "“Underhall Construction.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Symon Holl), `[94]` (Player), `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Symon Holl: "“The real estate and construction giant was founded in 19..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Symon Holl: "“Picking this corporation would fit our market economy po..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Symon Holl: "“Picking this corporation would go against our planned ec..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == f..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“Taurus Holding.”"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
Mówca: **Symon Holl**
> "“Picking this corporation would go against our planned economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Symon Holl: "“The CEO of Underhall is Kris Schar, the mayor of Conriat..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Taurus Holding.”"]** — Mówca: **Player**
> "“Taurus Holding.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Symon Holl), `[94]` (Player), `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Symon Holl: "“Taurus Holding was founded in 1946 and is owned by the e..."*)

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“Picking this corporation would fit our market economy policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Symon Holl: "“The CEO of Underhall is Kris Schar, the mayor of Conriat..."*)

### Węzeł `[54]`
Mówca: **Symon Holl**
> "“The respected Sordish State Corporation also known as the SSC was founded in 1891.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Symon Holl: "“It is the main state corporation tasked with running the..."*)

### Węzeł `[55]`
Mówca: **Symon Holl**
> "“The real estate and construction giant was founded in 1925, they expanded during the economic boom of the 30's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[56]`
Mówca: **Symon Holl**
> "“The project manager from Taurus Holding mentioned that they would be able to finish the project with the allocated funding. They found the budget sufficient unlike Underhall, making them a cheaper alternative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“I don't feel confident about Taurus Holding.”"*)
  - -> `[131]` (*Player: "“Taurus is definitely worth considering.”"*)
  - -> `[132]` (*Player: "“I have settled on Taurus Holding.”"*)

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“Taurus Holding was founded in 1946 and is owned by the entrepreneur Geralt Fais.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Symon Holl: "“It is a new holding company whose subsidiaries use cutti..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == ..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp =..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "It was time to make a decision about which company to awa..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp == true && BaseGameIsolated.Turn02_InT_Listened_TaurusHolding == true && BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] == true  and  Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Symon Holl**
> "“Underhall has specifically mentioned their solid track record and highlighted that the costs of the project would be more than expected for a project of this scale, but finished on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“I am not sure about Underhall Construction.”"*)
  - -> `[10]` (*Player: "“Underhall seems interesting but let's see the others.”"*)
  - -> `[112]` (*Player: "“I have settled on Underhall Construction. [-1 Government..."*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“The SSC is the primary reason why our infrastructure is outdated as is. We need more adaptive construction companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)

### Węzeł `[64]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they would need more resources to finish a project of this size.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "“I am on the fence about the SSC.”"*)
  - -> `[95]` (*Player: "“I like the SSC, but want to hear about the others.”"*)
  - -> `[105]` (*Player: "“I have settled on the SSC. [-1 Government Budget]”"*)

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“I had the chance to work with Underhall Construction before in Holsord. They took several contracts for the central station renovation and excelled at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: "“I would like to hear your thoughts, Symon.”"*)
  - -> `[40]` (*Player: "“How was your experience with them?”"*)

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“They are a very interesting corporation especially because of their innovative construction methods, but aren't suitable for large projects like these.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Why should we pick, Taurus?”"*)
  - -> `[100]` (*Player: "“Why shouldn't we go with, Taurus?”"*)

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“I wish the choice was different but at the end of the day the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Symon Holl: "“The company will be notified today and the construction ..."*)

### Węzeł `[68]`
Mówca: **Gus Manger**
> "“Choosing this corporation is too risky for a project like this. If things were to go wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“We shouldn't put our first project at risk. There is too..."*)
  - -> `[75]` (*Player: "“Their capabilities matter more than the history they hav..."*)

### Węzeł `[69]`
Mówca: **Gus Manger**
> "“Look at the abysmal regional railway system!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“The regional railway system has no relation to this.”"*)
  - -> `[11]` (*Player: "“They do have a wealth of knowledge in infrastructure.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Good luck to us.”"]** — Mówca: **Player**
> "“Good luck to us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: "“My expectations for a grand opening ceremony are late ne..."*)

### Węzeł `[71]`
Mówca: **Symon Holl**
> "“They took a joint contract in Arcasia for restructuring the highway intersection of one of the major cities. It went well but it is their only large-scale success.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Symon Holl: "“If we are going to try a different company this is the m..."*)

### Węzeł `[72]`
Mówca: **Symon Holl**
> "“My expectations for a grand opening ceremony are late next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gus Manger: "“I will be returning to my duties. See you soon, Mr. Pres..."*)

### Węzeł `[73]`
Mówca: **Gus Manger**
> "“I will be returning to my duties. See you soon, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“Thank you. This concludes the meeting.”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I think we are off to a good start.”"]** — Mówca: **Player**
> "“I think we are off to a good start.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Symon Holl: "“My expectations for a grand opening ceremony are late ne..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"]** — Mówca: **Player**
> "“Their capabilities matter more than the history they have. We need to make unbiased decisions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Symon Holl: "“They took a joint contract in Arcasia for restructuring ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“We shouldn't put our first project at risk. There is too much at stake here.”"]** — Mówca: **Player**
> "“We shouldn't put our first project at risk. There is too much at stake here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Symon Holl: "“They took a joint contract in Arcasia for restructuring ..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“It seems like they lack the necessary experience.”"]** — Mówca: **Player**
> "“It seems like they lack the necessary experience.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Gus Manger: "“Exactly. And why take such a risk now when we need to pl..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“The innovative aspect is refreshing. Especially if they can deliver.”"]** — Mówca: **Player**
> "“The innovative aspect is refreshing. Especially if they can deliver.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Gus Manger: "“But why take such a risk now? Especially when we know th..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_InT_Investment2CompanyChoice = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_InT_Investment2CompanyChoice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Thank you. This concludes the meeting.”"]** — Mówca: **Player**
> "“Thank you. This concludes the meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Underhall == true"*)

### Węzeł `[81]`
Mówca: **Symon Holl**
> "“They have experience, knowledge and manpower for a project this size. I'm not so sure about their efficiency though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Gus Manger: "“There is also the fact that construction times are long...."*)

### Węzeł `[82]`
Mówca: **Gus Manger**
> "“The Sordish State Corporation lacks a modern way of thinking. They also under-perform with their slow construction methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Gus stopped and laughed."*)

### Węzeł `[83]`
Mówca: **Gus Manger**
> "“There is also the fact that construction times are long. Which are caused by outdated methods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“The experience they bring to the table is beneficial.”"*)
  - -> `[96]` (*Player: "“The lack of a dynamic attitude is disappointing.”"*)

### Węzeł `[84]`
Mówca: **Symon Holl**
> "“I don't share a great admiration for the SSC but their track record clearly shows completed contracts with thousands of employees who have experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_Planned == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_Planned == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Symon Holl: "“It would fulfil your initial election promise of using a..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Gus Manger: "“The disadvantage would be going against your election pr..."*)

### Węzeł `[88]`
Mówca: **Gus Manger**
> "“The disadvantage would be going against your election promises of moving away from a state dominant economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gus Manger: "“The Sordish State Corporation lacks a modern way of thin..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Symon Holl: "“Some in the Lotherberg Group won't like this, but the co..."*)

### Węzeł `[90]`
Mówca: **Gus Manger**
> "“I wish the outcome of the meeting was different but at the end of the day the success of the project is what matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Symon Holl: "“The company will be notified today and the construction ..."*)

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“It would fulfil your initial election promise of using a state-dominant planned economy to improve the bleak recession situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Symon Holl: "“They have experience, knowledge and manpower for a proje..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“We need to be able to trust the corporation. This is a base requirement for the contract.”"]** — Mówca: **Player**
> "“We need to be able to trust the corporation. This is a base requirement for the contract.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl), `[106]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gus Manger: "“I think their capabilities are very suitable for a proje..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“The regional railway system has no relation to this.”"]** — Mówca: **Player**
> "“The regional railway system has no relation to this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Symon Holl: "“I don't share a great admiration for the SSC but their t..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“I am on the fence about the SSC.”"]** — Mówca: **Player**
> "“I am on the fence about the SSC.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Symon Holl), `[187]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I like the SSC, but want to hear about the others.”"]** — Mówca: **Player**
> "“I like the SSC, but want to hear about the others.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Symon Holl), `[187]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_SordishStateCorp = true"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“The lack of a dynamic attitude is disappointing.”"]** — Mówca: **Player**
> "“The lack of a dynamic attitude is disappointing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Symon Holl: "“I don't share a great admiration for the SSC but their t..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“I would like to hear your thoughts, Symon.”"]** — Mówca: **Player**
> "“I would like to hear your thoughts, Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Symon Holl: "“I think that they have been doing relatively well in the..."*)

### Węzeł `[99]`
Mówca: **Symon Holl**
> "“The company will be notified today and the construction work will begin immediately after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“I think we are off to a good start.”"*)
  - -> `[8]` (*Player: "“That's great news.”"*)
  - -> `[70]` (*Player: "“Good luck to us.”"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Why shouldn't we go with, Taurus?”"]** — Mówca: **Player**
> "“Why shouldn't we go with, Taurus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gus Manger: "“To be frank, what was the largest mega-project they work..."*)

### Węzeł `[101]`
Mówca: **Symon Holl**
> "“I think that they have been doing relatively well in the private sector, where they are dominating the construction industry with successful projects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: "“Nonetheless, they treated their workers below our workin..."*)

### Węzeł `[102]`
Mówca: **Symon Holl**
> "“Nonetheless, they treated their workers below our working standards during the Holsord Central Station contract. Which is troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“Working conditions must be respected. This doesn't inspi..."*)
  - -> `[92]` (*Player: "“We need to be able to trust the corporation. This is a b..."*)

### Węzeł `[103]`
Mówca: **Gus Manger**
> "“Having worked on the renovation project, I can say that the working conditions were not bad. Extra effort was needed to finish it on time, which they did, that is all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“Underhall has specifically mentioned their solid track r..."*)

### Węzeł `[104]`
Mówca: **Gus Manger**
> "“Out of all three, this is the company I can trust. They work hard, long and fast to accomplish their contracts. They will get this done if we give it to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Symon Holl: "“I am not so sure about trusting them with such a big con..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I have settled on the SSC. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[64]` (Symon Holl), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[106]`
Mówca: **Symon Holl**
> "“I am not so sure about trusting them with such a big contract. Especially after the workers issues but at least they have worked on several mega-projects and always delivered on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“Working conditions must be respected. This doesn't inspi..."*)
  - -> `[92]` (*Player: "“We need to be able to trust the corporation. This is a b..."*)

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“I think their capabilities are very suitable for a project like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gus Manger: "“They worked on two infrastructure projects in Gelsland a..."*)

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“They worked on two infrastructure projects in Gelsland and one in Greater Holsord that were worth two billion Ren in total.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Symon Holl: "“Underhall has specifically mentioned their solid track r..."*)

### Węzeł `[109]`
Mówca: **Gus Manger**
> "Yes, but some of the workers were Agnolian and Wehzek thus not under Sordish Labour Laws but under the immigration act.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Gus Manger: "“Having worked on the renovation project, I can say that ..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I am not sure about Underhall Construction.”"]** — Mówca: **Player**
> "“I am not sure about Underhall Construction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_UnderhallConstructio..."*)

### Węzeł `[111]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Taurus Holding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Gus Manger: "“I wish the outcome of the meeting was different but at t..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I have settled on Underhall Construction. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Underhall Construction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Symon Holl), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Underhall = true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Railway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_UnderhallConstruction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "Jump to: [Railway Companies Hub]"*)

### Węzeł `[115]`
Mówca: **Symon Holl**
> "“It won several awards internationally for being one of the fastest growing and advanced companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“The innovative aspect is refreshing. Especially if they ..."*)
  - -> `[77]` (*Player: "“It seems like they lack the necessary experience.”"*)

### Węzeł `[116]`
Mówca: **Gus Manger**
> "“Very glad that you have made this choice. I can tell from my experience that we will be very satisfied with this company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Symon Holl: "“The company will be notified today and the construction ..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Why should we pick, Taurus?”"]** — Mówca: **Player**
> "“Why should we pick, Taurus?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Working conditions must be respected. This doesn't inspire confidence.”"]** — Mówca: **Player**
> "“Working conditions must be respected. This doesn't inspire confidence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl), `[106]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Gus Manger: "Yes, but some of the workers were Agnolian and Wehzek thu..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Symon signed a certain section of the dossier and fixed his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Symon Holl: "“Very well, Mr. President. The contract will be awarded t..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Economy_FreeMarket == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Economy_FreeMarket == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Economy_FreeMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Economy_FreeMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Symon Holl: "“It would fit our election promises of switching to a fre..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Economy_FreeMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Economy_FreeMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Symon Holl: "“Taurus has completed fewer projects than the other compa..."*)

### Węzeł `[123]`
Mówca: **Gus Manger**
> "“To be frank, what was the largest mega-project they worked on? I don't even remember.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Gus shook his head."*)

### Węzeł `[124]`
Mówca: **Symon Holl**
> "“Taurus has completed fewer projects than the other companies. However, they are slightly faster and cheaper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Symon Holl: "“It won several awards internationally for being one of t..."*)

### Węzeł `[125]`
Mówca: **Symon Holl**
> "“It would fit our election promises of switching to a free-market economy. Awarding contracts to privately owned corporations would be a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Symon Holl: "“Taurus has completed fewer projects than the other compa..."*)

### Węzeł `[126]`
Mówca: **Symon Holl**
> "“It is a new holding company whose subsidiaries use cutting-edge technology from Arcasia to reduce construction costs and prices. They are known to provide for their workers who are part of the Labour Union of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Gus Manger: "“They are a very interesting corporation especially becau..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Symon started searching the documents he was holding for a while. He spoke when he found the one he was looking for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“I have the overview of the companies here.”"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Railway Companies Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "Railway Companies Hub"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_InT_Listened_TaurusHolding"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "Jump to: [Railway Companies Hub]"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I don't feel confident about Taurus Holding.”"]** — Mówca: **Player**
> "“I don't feel confident about Taurus Holdings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Symon Holl), `[186]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Taurus is definitely worth considering.”"]** — Mówca: **Player**
> "“Taurus is definitely worth considering.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Symon Holl), `[186]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_InT_Listened_TaurusHolding = true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding.”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[56]` (Symon Holl), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Taurus = true"*)

### Węzeł `[133]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. The contract will be awarded to Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Gus Manger: "“Very glad that you have made this choice. I can tell fro..."*)

### Węzeł `[134]`
Mówca: **Gus Manger**
> "“Exactly. And why take such a risk now when we need to play it safer with companies like Underhall? They always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Gus stopped and laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Gus Manger: "“Look at the abysmal regional railway system!”"*)

### Węzeł `[136]`
Mówca: **Symon Holl**
> "“If we are going to try a different company this is the most unique.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[137]`
Mówca: **Symon Holl**
> "“The CEO of Underhall is Kris Schar, the mayor of Conriat. He sold half of his shares a few years ago but seemed very eager on our megaproject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“I had the chance to work with Underhall Construction bef..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_InT_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_InT_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Gus shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Gus Manger: "“Choosing this corporation is too risky for a project lik..."*)

### Węzeł `[141]`
Mówca: **Symon Holl**
> "“It is the main state corporation tasked with running the day to day construction services of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“The SSC is the primary reason why our infrastructure is ..."*)

### Węzeł `[142]`
Mówca: **Symon Holl**
> "“Some in the Lotherberg Group won't like this, but the contract will be awarded to the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Gus Manger: "“I wish the choice was different but at the end of the da..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "It was time to make a decision about which company to award the contract to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[112]` (*Player: "“I have settled on Underhall Construction. [-1 Government..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Benfi International Airport was a massive investment, and..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Conriat Industrial Zone was a massive investment, and man..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Morna == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Port of Morna was a massive investment, and many construc..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Morna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Sarna Agricultural Zone was a massive investment, and man..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Conriat Industrial Zone was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Conriat", "Progress_Industr..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Port of Morna was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Morna", "Progress_SeaPort")..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Sarna Agricultural Zone was a massive investment, and many construction companies already wanted to take the contract for it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Sarna", "Progress_Agricultu..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Symon Holl: "“Besides supporting our economic recovery and providing n..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Symon Holl: "“Besides supporting our economic recovery and expanding o..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Symon was ready to brief me about the top three contenders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Symon Holl: "“Besides supporting our economic recovery and providing n..."*)

### Węzeł `[159]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. Especially with the new L-1 line, Conriat and Greater Holsord will benefit enormously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Gus Manger: "“This was a good choice.”"*)

### Węzeł `[160]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and providing new jobs, this project will boost our industrial output in Conriat heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[161]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and expanding our sea network, this project will boost our trade heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[162]`
Mówca: **Symon Holl**
> "“Besides supporting our economic recovery and providing new jobs, this project will boost our agricultural input heavily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[166]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Gus Manger: "“This was a good choice.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Gus Manger: "“That is a given now. This project will improve so many t..."*)

### Węzeł `[173]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. Especially with our massive investments in Lorren, the whole region will benefit a lot from this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Gus Manger: ""This port can have the potential to be the next Lachaven.""*)

### Węzeł `[174]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Symon started searching the documents he was holding for ..."*)

### Węzeł `[175]`
Mówca: **Gus Manger**
> ""This port can have the potential to be the next Lachaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Symon started searching the documents he was holding for ..."*)

### Węzeł `[176]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. Especially with our massive investments in Bergia, the whole region will benefit a lot from this. Sarna may become the next big city in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gus Manger: "“This was a good choice.”"*)

### Węzeł `[177]`
Mówca: **Gus Manger**
> "“That is a given now. This project will improve so many things, for sure. The farmers in Sarna needed our help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gus Manger: "“This was a good choice.”"*)

### Węzeł `[178]`
Mówca: **Gus Manger**
> "“This was a good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Symon started searching the documents he was holding for ..."*)

### Węzeł `[179]`
Mówca: **Gus Manger**
> "“This was a good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Symon started searching the documents he was holding for ..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Symon Holl: "“According to the preliminary calculations of the SSC, th..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Symon Holl: "“According to the preliminary calculations of the SSC, th..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Symon Holl: "“But, the project manager from Taurus Holding mentioned t..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Symon Holl: "“The project manager from Taurus Holding mentioned that t..."*)

### Węzeł `[186]`
Mówca: **Symon Holl**
> "“But, the project manager from Taurus Holding mentioned that they would need more funding for the project. They found the budget insufficient for such a massive construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "“I have settled on Taurus Holding. [-1 Government Budget]”"*)
  - -> `[130]` (*Player: "“I don't feel confident about Taurus Holding.”"*)
  - -> `[131]` (*Player: "“Taurus is definitely worth considering.”"*)

### Węzeł `[187]`
Mówca: **Symon Holl**
> "“According to the preliminary calculations of the SSC, they reported that they would be able to finish the project on time with the allocated funding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "“I have settled on the SSC.”"*)
  - -> `[94]` (*Player: "“I am on the fence about the SSC.”"*)
  - -> `[95]` (*Player: "“I like the SSC, but want to hear about the others.”"*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I have settled on the SSC.”"]** — Mówca: **Player**
> "“I have settled on the SSC.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[187]` (Symon Holl), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_SordishState = true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_SordishState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_InT_SordishState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[190]`
**[WYBÓR GRACZA: "“I have settled on Taurus Holding. [-1 Government Budget]”"]** — Mówca: **Player**
> "“I have settled on Taurus Holding.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Symon Holl), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Taurus = true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "“I have settled on the SSC.”"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“I have settled on the SSC. [-1 Government Budget]”"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: "“I have settled on Taurus Holding. [-1 Government Budget]”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "“I have settled on Taurus Holding.”"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_Underhall == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_InT_Underhall == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_InT_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Company_Underhall = true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_InT_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_SordishState == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Company_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Company_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_InT_Investment2CompanyChoice = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_SordishState == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_InT_SordishState == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_InT_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Company_SSC = true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_InT_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Company_Taurus = true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Company_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Company_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_InT_Investment2CompanyChoice = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Company_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Company_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_InT_Investment2CompanyChoice = true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Benfi", "Progress_InternationalAirport");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Benfi","Progress_InternationalAirport");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Symon was ready to brief me about the top three contenders."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Conriat", "Progress_IndustrialZone");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Conriat","Progress_IndustrialZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Symon was ready to brief me about the top three contenders."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Morna", "Progress_SeaPort");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Morna","Progress_SeaPort");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Symon was ready to brief me about the top three contenders."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Sarna", "Progress_AgriculturalZone");

// Assigns given token status to the given city`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","Progress_AgriculturalZone");
-- Assigns given token status to the given city;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Symon was ready to brief me about the top three contenders."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[212]`
Mówca: **Gus Manger**
> "“But why take such a risk now? Especially when we know that Underhall has always delivered for the government on time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
