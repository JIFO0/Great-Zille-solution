# Sordland/Turn01/Start_Inauguration

- **ID konwersacji:** `6`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/006_Start_Inauguration.md`
- **Liczba węzłów dialogowych:** 134
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_None`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_TermFocus_Military`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Malenyevist`
- `BaseGame.Sollist`
- `BaseGameSupport.Codex_Characters_Others_SergeWolkner`
- `BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace`
- `BaseGameSupport.FactionReport_Turn01_ATO_HumanRightsReport`
- `BaseGameSupport.News_Turn01_E_Infrastructure`
- `BaseGameSupport.News_Turn01_E_Sollonomics`
- `BaseGameSupport.News_Turn01_HP_CampaignBill_HaltedWorkResumes`
- `BaseGameSupport.News_Turn01_HP_Speech_ChangeHope`
- `BaseGameSupport.News_Turn01_HP_Speech_DireSituation`
- `BaseGameSupport.News_Turn01_HP_Speech_Unity`
- `BaseGameSupport.News_Turn01_LT_NewAssembly`
- `BaseGameSupport.News_Turn01_R_AnotherUSP`
- `BaseGameSupport.News_Turn01_ST_President_Deyr`
- `BaseGameSupport.News_Turn01_ST_President_Holsord`
- `BaseGameSupport.News_Turn01_ST_President_Lachaven`
- `BaseGameSupport.Report_Turn01_Arvory_LackofInvestment`
- `BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers`
- `BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues`
- `BaseGameSupport.Report_Turn01_Holsord_StaffGathers`
- `BaseGameSupport.Report_Turn01_Lachaven_Port`
- `BaseGameSupport.Report_Turn01_Laren_LowProduction`
- `GameCondition.Turn01_Start_Inauguration`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“I am ready.”"** | `[6]` **Orso Hawker**: "“The time for the oath has come.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Orso Hawker**: "“Please repeat after me. I do so..." |
| `[8]` | **"“It has indeed.”"** | `[6]` **Orso Hawker**: "“The time for the oath has come.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Orso Hawker**: "“Please repeat after me. I do so..." |
| `[9]` | **"“Let’s start.”"** | `[6]` **Orso Hawker**: "“The time for the oath has come.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Orso Hawker**: "“Please repeat after me. I do so..." |
| `[11]` | **"“I do solemnly swear...”"** | `[10]` **Orso Hawker**: "“Please repeat after me. I do so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Orso Hawker**: "“And to the best of my ability, ..." |
| `[13]` | **"“And to the best of my ability, preserve, protect and defend...”"** | `[12]` **Orso Hawker**: "“And to the best of my ability, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Orso Hawker**: "“You may now deliver your inaugu..." |
| `[15]` | **"“Thank you.”"** | `[14]` **Orso Hawker**: "“You may now deliver your inaugu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player**: "“Dear citizens of Sordland!”"<br>`[93]` **Player**: "“Brothers and sisters!”"<br>*(oraz 1 innych odgałęzień)* |
| `[16]` | **"“It is an honor.”"** | `[14]` **Orso Hawker**: "“You may now deliver your inaugu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player**: "“Dear citizens of Sordland!”"<br>`[93]` **Player**: "“Brothers and sisters!”"<br>*(oraz 1 innych odgałęzień)* |
| `[17]` | **"“Let's begin.”"** | `[14]` **Orso Hawker**: "“You may now deliver your inaugu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player**: "“Dear citizens of Sordland!”"<br>`[93]` **Player**: "“Brothers and sisters!”"<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **"“Dear citizens of Sordland!”"** | `[15]` **Player**: "“Thank you, Mr. Hawker.”"<br>`[16]` **Player**: "“It is an honor, sir.”"<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "The crowd looked very eager to l..." |
| `[20]` | **"“The idea of unity.”"** | `[19]` **Narrator**: "The crowd looked very eager to l..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_HP_Speech_Unity"] =...` | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **"“The current dire situation.”"** | `[19]` **Narrator**: "The crowd looked very eager to l..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_HP_Speech_DireSitua...` | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **"“Change and hope.”"** | `[19]` **Narrator**: "The crowd looked very eager to l..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_HP_Speech_ChangeHop...` | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych odgałęzień)* |
| `[23]` | **"“It is time for a united and powerful Sordland once again!”"** | `[95]` **Player**: "“I promise you, we *will* stop t..."<br>`[96]` **Player**: "“The future awaits us! It's time..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Hundreds of thousands cheered. T..." |
| `[24]` | **"“Change now, not in the next decade, or years. Today!”"** | `[95]` **Player**: "“I promise you, we *will* stop t..."<br>`[96]` **Player**: "“The future awaits us! It's time..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Hundreds of thousands cheered. T..." |
| `[25]` | **"“Our capacity as a nation has never been greater!”"** | `[95]` **Player**: "“I promise you, we *will* stop t..."<br>`[96]` **Player**: "“The future awaits us! It's time..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Hundreds of thousands cheered. T..." |
| `[27]` | **"“Nice to meet you, Serge.”"** | `[46]` **Serge Wolkner**: "“If you'll allow me to introduce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Serge Wolkner**: "“It's an honor.”" |
| `[28]` | **"“It's a pleasure.”"** | `[46]` **Serge Wolkner**: "“If you'll allow me to introduce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Serge Wolkner**: "“The pleasure is all but mine.”" |
| `[33]` | **"“So do I, Serge. It is the beating heart of the nation after all.”"** | `[32]` **Serge Wolkner**: "“Every time I look at it, I am r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Serge Wolkner**: "“Well said, Mr. President.”" |
| `[34]` | **"“We all owe a great debt to the men who led the country from here.”"** | `[32]` **Serge Wolkner**: "“Every time I look at it, I am r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Serge Wolkner**: "“Their service will not be forgo..." |
| `[35]` | **"“It is in good hands now.”"** | `[32]` **Serge Wolkner**: "“Every time I look at it, I am r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Serge Wolkner**: "“I am sure of that, Mr. President.”" |
| `[41]` | **"“Goodbye.”"** | `[68]` **Narrator**: "He referred to the famous Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "I made my way upstairs through t..." |
| `[42]` | **"“See you soon.”"** | `[68]` **Narrator**: "He referred to the famous Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "I made my way upstairs through t..." |
| `[49]` | **"“If we stand together, we prevail.”"** | `[21]` **Player**: "“We are enduring economic hardsh..."<br>`[22]` **Player**: "“You, the people, have chosen. T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "“I promise you, we *will* stop t..."<br>`[98]` **Player**: "“First, we must rewrite our brok..."<br>*(oraz 3 innych odgałęzień)* |
| `[50]` | **"“The issues that plague us.”"** | `[21]` **Player**: "“We are enduring economic hardsh..."<br>`[22]` **Player**: "“You, the people, have chosen. T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "“I promise you, we *will* stop t..."<br>`[98]` **Player**: "“First, we must rewrite our brok..."<br>*(oraz 3 innych odgałęzień)* |
| `[51]` | **"“Our capabilities.”"** | `[21]` **Player**: "“We are enduring economic hardsh..."<br>`[22]` **Player**: "“You, the people, have chosen. T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Player**: "“I promise you, we *will* stop t..."<br>`[98]` **Player**: "“First, we must rewrite our brok..."<br>*(oraz 3 innych odgałęzień)* |
| `[62]` | **"“At ease, Serge.”"** | `[46]` **Serge Wolkner**: "“If you'll allow me to introduce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Serge Wolkner**: "“As you wish, Mr. President.”" |
| `[66]` | **"“It's just a building, Serge.”"** | `[32]` **Serge Wolkner**: "“Every time I look at it, I am r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Serge Wolkner**: "“You are right, Mr. President. I..." |
| `[69]` | **"“Vectern sis da!”"** | `[68]` **Narrator**: "He referred to the famous Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "I made my way upstairs through t..." |
| `[70]` | **"The die was cast."** | `[61]` **Narrator**: "Thousands were watching the inau..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "In the distance, the Maroon Pala..." |
| `[71]` | **"Raise fist."** | `[26]` **Narrator**: "Hundreds of thousands cheered. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "I took a long look at the people..." |
| `[72]` | **"Wave."** | `[26]` **Narrator**: "Hundreds of thousands cheered. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "I took a long look at the people..." |
| `[73]` | **"Enjoy the moment."** | `[26]` **Narrator**: "Hundreds of thousands cheered. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "I took a long look at the people..." |
| `[93]` | **"“Brothers and sisters!”"** | `[15]` **Player**: "“Thank you, Mr. Hawker.”"<br>`[16]` **Player**: "“It is an honor, sir.”"<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "The crowd looked very eager to l..." |
| `[94]` | **"“My fellow Sords!”"** | `[15]` **Player**: "“Thank you, Mr. Hawker.”"<br>`[16]` **Player**: "“It is an honor, sir.”"<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "The crowd looked very eager to l..." |
| `[95]` | **"“I promise you, we *will* stop the recession and eliminate poverty!”"** | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "“It is time for a united and pow..."<br>`[24]` **Player**: "“Change now, not in the next dec..."<br>*(oraz 1 innych odgałęzień)* |
| `[96]` | **"“The future awaits us! It's time to turn our faces to the east!”"** | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Promise_Diplomacy_East"] == true` | *Brak zmian stanu* | `[23]` **Player**: "“It is time for a united and pow..."<br>`[24]` **Player**: "“Change now, not in the next dec..."<br>*(oraz 1 innych odgałęzień)* |
| `[97]` | **"“The future awaits us! It's time to turn our faces to the west!”"** | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Promise_Diplomacy_West"] == true` | *Brak zmian stanu* | `[23]` **Player**: "“It is time for a united and pow..."<br>`[24]` **Player**: "“Change now, not in the next dec..."<br>*(oraz 1 innych odgałęzień)* |
| `[98]` | **"“First, we must rewrite our broken Constitution from 1929!”"** | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: "“It is time for a united and pow..."<br>`[24]` **Player**: "“Change now, not in the next dec..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **"“The future awaits us! Sordland is above all in the world!”"** | `[49]` **Player**: "“In the past, there have been ti..."<br>`[50]` **Player**: "“We still have insufficient infr..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Promise_Diplomacy_None"] == true` | *Brak zmian stanu* | `[23]` **Player**: "“It is time for a united and pow..."<br>`[24]` **Player**: "“Change now, not in the next dec..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[59]` (*Narrator: "Two weeks had passed since we won the election."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "In the distance, the Maroon Palace stood on top of the famous Hill of Pride. I had no way of knowing what future awaited me there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I looked at my family. My son and daughter, Franc and Dea..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I looked at my family. My son and daughter, Franc and Deana, were next to Monica, my wife. Her eyes were glimmering with pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Then I turned towards the key people who made it all poss..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "As my thoughts slowly faded away, the reality of the situation dawned on me. Orso Hawker, the Chief Justice of the Supreme Court, was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Orso Hawker: "“The time for the oath has come.”"*)

### Węzeł `[6]`
Mówca: **Orso Hawker**
> "“The time for the oath has come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“I am ready.”"*)
  - -> `[8]` (*Player: "“It has indeed.”"*)
  - -> `[9]` (*Player: "“Let’s start.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I am ready.”"]** — Mówca: **Player**
> "“I am ready.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Orso Hawker: "“Please repeat after me. I do solemnly swear...”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“It has indeed.”"]** — Mówca: **Player**
> "“It has indeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Orso Hawker: "“Please repeat after me. I do solemnly swear...”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Let’s start.”"]** — Mówca: **Player**
> "“Let’s start.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Orso Hawker: "“Please repeat after me. I do solemnly swear...”"*)

### Węzeł `[10]`
Mówca: **Orso Hawker**
> "“Please repeat after me. I do solemnly swear...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“I do solemnly swear...”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I do solemnly swear...”"]** — Mówca: **Player**
> "“I do solemnly swear that I will respectfully execute the office of the President of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Orso Hawker: "“And to the best of my ability, preserve, protect and def..."*)

### Węzeł `[12]`
Mówca: **Orso Hawker**
> "“And to the best of my ability, preserve, protect and defend...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“And to the best of my ability, preserve, protect and def..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“And to the best of my ability, preserve, protect and defend...”"]** — Mówca: **Player**
> "“And to the best of my ability, preserve, protect and defend the people and the constitution of the Republic of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Orso Hawker: "“You may now deliver your inauguration speech, Mr. Presid..."*)

### Węzeł `[14]`
Mówca: **Orso Hawker**
> "“You may now deliver your inauguration speech, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“Thank you.”"*)
  - -> `[16]` (*Player: "“It is an honor.”"*)
  - -> `[17]` (*Player: "“Let's begin.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you, Mr. Hawker.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Dear citizens of Sordland!”"*)
  - -> `[93]` (*Player: "“Brothers and sisters!”"*)
  - -> `[94]` (*Player: "“My fellow Sords!”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It is an honor.”"]** — Mówca: **Player**
> "“It is an honor, sir.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Dear citizens of Sordland!”"*)
  - -> `[93]` (*Player: "“Brothers and sisters!”"*)
  - -> `[94]` (*Player: "“My fellow Sords!”"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Good, let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Dear citizens of Sordland!”"*)
  - -> `[93]` (*Player: "“Brothers and sisters!”"*)
  - -> `[94]` (*Player: "“My fellow Sords!”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Dear citizens of Sordland!”"]** — Mówca: **Player**
> "“Dear citizens of Sordland!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Player), `[16]` (Player), `[17]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The crowd looked very eager to listen to me."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The crowd looked very eager to listen to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“The idea of unity.”"*)
  - -> `[21]` (*Player: "“The current dire situation.”"*)
  - -> `[22]` (*Player: "“Change and hope.”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“The idea of unity.”"]** — Mówca: **Player**
> "“For many generations, this country and its long history have kept us tied to an idea – the idea of unity, and our people’s right for a free and prosperous life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_HP_Speech_Unity = true;"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“The current dire situation.”"]** — Mówca: **Player**
> "“We are enduring economic hardship like never before, and today, our nation is falling apart. Our people – we –suffer in this dire situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_HP_Speech_DireSituation = true;"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Change and hope.”"]** — Mówca: **Player**
> "“You, the people, have chosen. Together, we will bring prosperity and reform to our nation. It is a time of hope, it is a time of change.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_HP_Speech_ChangeHope = true;"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“It is time for a united and powerful Sordland once again!”"]** — Mówca: **Player**
> "“It is time for a united and powerful Sordland once again!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Hundreds of thousands cheered. They were shouting my name..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Change now, not in the next decade, or years. Today!”"]** — Mówca: **Player**
> "“Change now, not in the next decade or years. Today!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Hundreds of thousands cheered. They were shouting my name..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Our capacity as a nation has never been greater!”"]** — Mówca: **Player**
> "“Our capacity as a nation has never been greater!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Hundreds of thousands cheered. They were shouting my name..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Hundreds of thousands cheered. They were shouting my name in unison. I felt the responsibility, the power and the burden all at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Italic: "Raise fist."*)
  - -> `[72]` (*Player_Italic: "Wave."*)
  - -> `[73]` (*Player_Italic: "Enjoy the moment."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Nice to meet you, Serge.”"]** — Mówca: **Player**
> "“Nice to meet you, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Serge Wolkner: "“It's an honor.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's a pleasure.”"]** — Mówca: **Player**
> "“It's a pleasure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Serge Wolkner: "“The pleasure is all but mine.”"*)

### Węzeł `[29]`
Mówca: **Serge Wolkner**
> "“It's an honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He respectfully bowed his head before opening the car doo..."*)

### Węzeł `[30]`
Mówca: **Serge Wolkner**
> "“The pleasure is all but mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He respectfully bowed his head before opening the car doo..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "The motorcade began to move. On the way, Serge proceeded to explain his duties as a driver."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "As minutes passed by, I found myself lost in thought agai..."*)

### Węzeł `[32]`
Mówca: **Serge Wolkner**
> "“Every time I look at it, I am reminded of my duty to this nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“It is in good hands now.”"*)
  - -> `[33]` (*Player: "“So do I, Serge. It is the beating heart of the nation af..."*)
  - -> `[34]` (*Player: "“We all owe a great debt to the men who led the country f..."*)
  - -> `[66]` (*Player: "“It's just a building, Serge.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“So do I, Serge. It is the beating heart of the nation after all.”"]** — Mówca: **Player**
> "“So do I, Serge. It is the beating heart of the nation after all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Serge Wolkner: "“Well said, Mr. President.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We all owe a great debt to the men who led the country from here.”"]** — Mówca: **Player**
> "“We all owe a great debt to the men who led the country from here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Serge Wolkner: "“Their service will not be forgotten.”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“It is in good hands now.”"]** — Mówca: **Player**
> "“It is in good hands now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Serge Wolkner: "“I am sure of that, Mr. President.”"*)

### Węzeł `[36]`
Mówca: **Serge Wolkner**
> "“I am sure of that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The car drove past the majestic gates, continued uphill t..."*)

### Węzeł `[37]`
Mówca: **Serge Wolkner**
> "“Well said, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The car drove past the majestic gates, continued uphill t..."*)

### Węzeł `[38]`
Mówca: **Serge Wolkner**
> "“Their service will not be forgotten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The car drove past the majestic gates, continued uphill t..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "The car drove past the majestic gates, continued uphill to the entrance and stopped in front of the doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Serge got out of the car and opened the door for me."*)

### Węzeł `[40]`
Mówca: **Serge Wolkner**
> "“Have a great day, Mr. President. A Morgna wes core.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He referred to the famous Sordish phrase from the times o..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "I made my way upstairs through the extravagant corridors ..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“See you soon.”"]** — Mówca: **Player**
> "“See you soon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "I made my way upstairs through the extravagant corridors ..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "I made my way upstairs through the extravagant corridors of the palace. Marble and engraved wooden finishes decorated the interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_Start_Inauguration = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_Start_Inauguration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[45]`
Mówca: **Serge Wolkner**
> "“Hello, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I still felt euphoric from the aftermath of my speech. He..."*)

### Węzeł `[46]`
Mówca: **Serge Wolkner**
> "“If you'll allow me to introduce myself, I am Serge, your new driver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“Nice to meet you, Serge.”"*)
  - -> `[62]` (*Player: "“At ease, Serge.”"*)
  - -> `[28]` (*Player: "“It's a pleasure.”"*)

### Węzeł `[47]`
Mówca: **Serge Wolkner**
> "“We will be heading towards the palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The motorcade began to move. On the way, Serge proceeded ..."*)

### Węzeł `[48]`
Mówca: **Serge Wolkner**
> "“Isn't it a beauty? The Maroon Palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace = ..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“If we stand together, we prevail.”"]** — Mówca: **Player**
> "“In the past, there have been times of survival – times of conflict and economic hardship too – but whenever we stood together, we prevailed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“I promise you, we *will* stop the recession and eliminat..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true"*)
  - -> `[98]` (*Player: "“First, we must rewrite our broken Constitution from 1929!”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“The issues that plague us.”"]** — Mówca: **Player**
> "“We still have insufficient infrastructure – houses without electricity, without water. We have crime in our streets, unemployment within the youth, and we still have injustices in the government that plague us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“I promise you, we *will* stop the recession and eliminat..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true"*)
  - -> `[98]` (*Player: "“First, we must rewrite our broken Constitution from 1929!”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Our capabilities.”"]** — Mówca: **Player**
> "“Our workers are no less productive than a decade ago. Our capable minds are no less inventive, our products and services no less requested than they were last week, last month, or last year.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“I promise you, we *will* stop the recession and eliminat..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true"*)
  - -> `[98]` (*Player: "“First, we must rewrite our broken Constitution from 1929!”"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "I still felt euphoric from the aftermath of my speech. Hearing my new title made me smile even more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Serge Wolkner: "“If you'll allow me to introduce myself, I am Serge, your..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "I took a long look at the people of Sordland to burn this moment into my memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "One of the presidential guards came by to notify me that ..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "The presidential state car was a jet black Kadilla with flags of Sordland above the front headlights. Next to it, a man was holding the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_SergeWolkner = true"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "As minutes passed by, I found myself lost in thought again, barely paying attention to what he was saying. He suddenly gestured out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Serge Wolkner: "“Isn't it a beauty? The Maroon Palace.”"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "He was right. Sunlight glinted off the palace's many maroon-coloured domes. It was so bright that I had to look away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Serge Wolkner: "“Every time I look at it, I am reminded of my duty to thi..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Serge got out of the car and opened the door for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Serge Wolkner: "“Have a great day, Mr. President. A Morgna wes core.”"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Then I turned towards the key people who made it all possible. Of course, each individual was promised an important position in my government."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Two weeks had passed since we won the election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "And now I was about to be sworn in as the 4th President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Thousands were watching the inauguration ceremony and che..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Thousands were watching the inauguration ceremony and cheering my name: Anton Rayne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Italic: "The die was cast."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“At ease, Serge.”"]** — Mówca: **Player**
> "“At ease, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Serge Wolkner: "“As you wish, Mr. President.”"*)

### Węzeł `[63]`
Mówca: **Serge Wolkner**
> "“As you wish, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He respectfully bowed his head before opening the car doo..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "One of the presidential guards came by to notify me that it was time to leave. I made my way to the leading car in the motorcade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "The presidential state car was a jet black Kadilla with f..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "He respectfully bowed his head before opening the car door and gesturing inside. I entered the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Serge Wolkner: "“We will be heading towards the palace.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“It's just a building, Serge.”"]** — Mówca: **Player**
> "“It's just a building, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Serge Wolkner: "“You are right, Mr. President. I don't know much about ar..."*)

### Węzeł `[67]`
Mówca: **Serge Wolkner**
> "“You are right, Mr. President. I don't know much about architecture, but for me, it's the most beautiful building in all of Holsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "The car drove past the majestic gates, continued uphill t..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "He referred to the famous Sordish phrase from the times of revolution; "A Morgna wes core, Vectern sis da!" which meant "Morning will come, Victory is close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“Goodbye.”"*)
  - -> `[42]` (*Player: "“See you soon.”"*)
  - -> `[69]` (*Player: "“Vectern sis da!”"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "I made my way upstairs through the extravagant corridors ..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "The die was cast."]** — Mówca: **Player_Italic**
> "The die was cast and there my story began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "In the distance, the Maroon Palace stood on top of the fa..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "Raise fist."]** — Mówca: **Player_Italic**
> "I raised my fist in the air, which triggered a huge burst of applause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I took a long look at the people of Sordland to burn this..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "Wave."]** — Mówca: **Player_Italic**
> "I waved at the crowd, which made the people cheer louder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I took a long look at the people of Sordland to burn this..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "Enjoy the moment."]** — Mówca: **Player_Italic**
> "Taking a deep breath in, I enjoyed the moment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I took a long look at the people of Sordland to burn this..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_HP_Speech_DireSituation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_HP_Speech_DireSituation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“If we stand together, we prevail.”"*)
  - -> `[50]` (*Player: "“The issues that plague us.”"*)
  - -> `[51]` (*Player: "“Our capabilities.”"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_HP_Speech_ChangeHope = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_HP_Speech_ChangeHope"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“If we stand together, we prevail.”"*)
  - -> `[50]` (*Player: "“The issues that plague us.”"*)
  - -> `[51]` (*Player: "“Our capabilities.”"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_HP_Speech_Unity = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_HP_Speech_Unity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“If we stand together, we prevail.”"*)
  - -> `[50]` (*Player: "“The issues that plague us.”"*)
  - -> `[51]` (*Player: "“Our capabilities.”"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_President_Deyr = true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_President_Deyr = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_President_Deyr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "My footsteps echoed in the colossal halls. The guards bow..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_President_Holsord = true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_President_Lachaven = true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_President_Holsord = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_President_Holsord"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "My footsteps echoed in the colossal halls. The guards bow..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_President_Lachaven = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_President_Lachaven"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "My footsteps echoed in the colossal halls. The guards bow..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Laren_LowProduction = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Laren_LowProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Lachaven_Port = true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Lachaven_Port = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Lachaven_Port"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Arvory_LackofInvestment = true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Arvory_LackofInvestment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Arvory_LackofInvestment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "And now I was about to be sworn in as the 4th President o..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Laren_LowProduction = true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_SergeWolkner = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Serge Wolkner: "“Hello, Mr. President.”"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He was right. Sunlight glinted off the palace's many maro..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_E_Sollonomics = true;
BaseGameSupport.News_Turn01_E_Infrastructure = true;
BaseGameSupport.News_Turn01_LT_NewAssembly = true;
BaseGameSupport.News_Turn01_R_AnotherUSP = true;
BaseGameSupport.FactionReport_Turn01_ATO_HumanRightsReport = true;
BaseGameSupport.News_Turn01_HP_CampaignBill_HaltedWorkResumes = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_E_Sollonomics"] = true;
Variable["BaseGameSupport.News_Turn01_E_Infrastructure"] = true;
Variable["BaseGameSupport.News_Turn01_LT_NewAssembly"] = true;
Variable["BaseGameSupport.News_Turn01_R_AnotherUSP"] = true;
Variable["BaseGameSupport.FactionReport_Turn01_ATO_HumanRightsReport"] = true;
Variable["BaseGameSupport.News_Turn01_HP_CampaignBill_HaltedWorkResumes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Brothers and sisters!”"]** — Mówca: **Player**
> "“Brothers and sisters!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Player), `[16]` (Player), `[17]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The crowd looked very eager to listen to me."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“My fellow Sords!”"]** — Mówca: **Player**
> "“My fellow Sords!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Player), `[16]` (Player), `[17]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The crowd looked very eager to listen to me."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I promise you, we *will* stop the recession and eliminate poverty!”"]** — Mówca: **Player**
> "“I promise you, we *will* stop the recession and eliminate poverty!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“It is time for a united and powerful Sordland once again!”"*)
  - -> `[24]` (*Player: "“Change now, not in the next decade, or years. Today!”"*)
  - -> `[25]` (*Player: "“Our capacity as a nation has never been greater!”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“The future awaits us! It's time to turn our faces to the east!”"]** — Mówca: **Player**
> "“The future awaits us! It's time to turn our faces to the east!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“It is time for a united and powerful Sordland once again!”"*)
  - -> `[24]` (*Player: "“Change now, not in the next decade, or years. Today!”"*)
  - -> `[25]` (*Player: "“Our capacity as a nation has never been greater!”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“The future awaits us! It's time to turn our faces to the west!”"]** — Mówca: **Player**
> "“The future awaits us! It's time to turn our faces to the west!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“It is time for a united and powerful Sordland once again!”"*)
  - -> `[24]` (*Player: "“Change now, not in the next decade, or years. Today!”"*)
  - -> `[25]` (*Player: "“Our capacity as a nation has never been greater!”"*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“First, we must rewrite our broken Constitution from 1929!”"]** — Mówca: **Player**
> "“First, we must rewrite our broken Constitution from 1929!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“It is time for a united and powerful Sordland once again!”"*)
  - -> `[24]` (*Player: "“Change now, not in the next decade, or years. Today!”"*)
  - -> `[25]` (*Player: "“Our capacity as a nation has never been greater!”"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“The future awaits us! Sordland is above all in the world!”"]** — Mówca: **Player**
> "“The future awaits us! Sordland is above all in the world!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_None"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Player), `[50]` (Player), `[51]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“It is time for a united and powerful Sordland once again!”"*)
  - -> `[24]` (*Player: "“Change now, not in the next decade, or years. Today!”"*)
  - -> `[25]` (*Player: "“Our capacity as a nation has never been greater!”"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“The future awaits us! It's time to turn our faces to the..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: "“The future awaits us! It's time to turn our faces to the..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_None == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_None == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_None == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: "“The future awaits us! Sordland is above all in the world!”"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_None == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1;"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 1;"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 1;"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues = ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues = ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues = ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers =..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_StaffGathers = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_Start_Inauguration = true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_StaffGathers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_StaffGathers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_Start_Inauguration = true"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "I saw my previous rival and former president, Ewald Alphonso, who gave me a slight nod. Tarquin Soll was also invited, but as expected, he didn’t leave his island retreat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "As my thoughts slowly faded away, the reality of the situ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true && Base..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true && Ba..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "I saw my previous rival and former president, Ewald Alpho..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_Takeover_PublicBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true || ..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true || BaseGame.Prologue_Party_Takeover_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true || ..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true |..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true || BaseGame.Prologue_Party_Takeover_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "I saw my previous rival and former president, Ewald Alpho..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true || BaseGame.Prologue_Party_Takeover_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "I saw my previous rival and former president, Ewald Alpho..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "I saw my previous rival and former president, Ewald Alphonso. Tarquin Soll was also invited, but as expected, he didn’t leave his island retreat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "As my thoughts slowly faded away, the reality of the situ..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "I saw my previous rival and former president, Ewald Alphonso. Tarquin Soll was also invited, but as expected, he didn't leave his island retreat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "As my thoughts slowly faded away, the reality of the situ..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "My footsteps echoed in the colossal halls. The guards bowed their heads in respect as I opened the massive doors to my new office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_E_Sollonomics = true; BaseGam..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
