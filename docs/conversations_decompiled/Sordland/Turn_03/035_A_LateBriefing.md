# Sordland/Turn03/A_LateBriefing

- **ID konwersacji:** `35`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/035_A_LateBriefing.md`
- **Liczba węzłów dialogowych:** 71
- **Liczba wyborów gracza:** 13

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `GameCondition.Turn03_LateBrief_DictatorBranch`
- `GameCondition.Turn03_LateBrief_ReformistBranch`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Reform_Reformist_Path`
- `BaseGameSupport.Journal_Turn03_LateReform_Dictator`
- `BaseGameSupport.Journal_Turn03_LateReform_Reformist`
- `GameCondition.Turn03_A_LateBriefing`
- `GameCondition.Turn03_LateBrief_DictatorBranch`
- `GameCondition.Turn03_LateBrief_ReformistBranch`

### Skoki między-konwersacyjne:
- Węzeł `[6]` -> **[36] Sordland/Turn03/LateDictatorSection** (../Turn_03/036_LateDictatorSection.md), Węzeł `[1]`
- Węzeł `[59]` -> **[37] Sordland/Turn03/LateReformistSection** (../Turn_03/037_LateReformistSection.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""Your service is appreciated.""** | `[13]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: ""Thank you for the kind words, s..." |
| `[15]` | **""If we do this, I promise, you will be kings.""** | `[13]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: ""Thank you for the kind words, s..." |
| `[16]` | **""Together we will make Sordland great.""** | `[13]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Petr Vectern**: ""Yes we will!"" |
| `[17]` | **""Thanks for the meeting, gentlemen.""** | `[13]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucian Galade**: ""Thank you for your time, sir."" |
| `[24]` | **""Your service is appreciated.""** | `[9]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lucian Galade**: ""Thank you for the kind words, s..." |
| `[25]` | **""If we do this, we will be remembered as heroes.""** | `[9]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Petr Vectern**: ""That would be really great!"" |
| `[26]` | **""Together we will democratize Sordland.""** | `[9]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Petr Vectern**: ""Ours too, of course."" |
| `[27]` | **""Thanks for the meeting, everybody.""** | `[9]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: ""Thank you for your time, sir."" |
| `[45]` | **""The Vice President has a point. It's us versus them now.""** | `[42]` **Lucian Galade**: ""Let's not act rash. They have a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Petr Vectern**: ""The lines are drawn sir."" |
| `[46]` | **""Let's consider all of our options carefully.""** | `[42]` **Lucian Galade**: ""Let's not act rash. They have a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Petr Vectern**: ""True, sorry I got a little hoth..." |
| `[47]` | **""The future lies in a true reform of the constitution. The people elected us for t..."** | `[42]` **Lucian Galade**: ""Let's not act rash. They have a..." | `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true` | *Brak zmian stanu* | `[48]` **Petr Vectern**: ""Why don't we take more power aw..." |
| `[56]` | **""Let's consolidate our constitutional power and remove the Old Guard equation.""** | `[58]` **Lucian Galade**: ""The reform committee has presen..." | `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] == false` | `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"]...`<br>`Variable["BaseGame.Reform_Dictator_Path"] = true; Variabl...` | `[61]` **Petr Vectern**: ""I will fully support you, Anton."" |
| `[57]` | **""We should not be blinded by hatred of foes. Our true purpose will be real reform ..."** | `[58]` **Lucian Galade**: ""The reform committee has presen..." | `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] == false` | `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"...`<br>`Variable["BaseGame.Reform_Reformist_Path"] = true; Variab...` | `[59]` **Petr Vectern**: ""Very well if that is your decis..." |

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
  - -> `[4]` (*Narrator: "The reform committee had intensified work after the negot..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_LateBriefing = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The reform committee had intensified work after the negotiations with the Old Guard broke down. Options regarding the new Constitution were already laid out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention = false"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "A few minutes later, Lucian and Petr arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""After what they pulled off I say let's screw them over. ..."*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""There are some people in USP who would support a new Constitution with more executive powers. Getting the support of the nationalists is our best bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> ""Now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Petr Vectern: ""I'll present your input to the committee. In a few month..."*)

### Węzeł `[8]`
Mówca: **Petr Vectern**
> ""I'll present your input to the committee. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""I think this was yet another fruitful meeting, sir.""*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""Your service is appreciated.""*)
  - -> `[25]` (*Player: ""If we do this, we will be remembered as heroes.""*)
  - -> `[26]` (*Player: ""Together we will democratize Sordland.""*)
  - -> `[27]` (*Player: ""Thanks for the meeting, everybody.""*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""But now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""I'll present your input to the USP leaders and the Natio..."*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> ""Well, regardless of what you decide, we will need to work together with all the cabinet to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""But now we have a better picture of your intentions, sir..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""I'll present your input to the USP leaders and the National Front. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: ""I think this was yet another fruitful meeting, sir. I tr..."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir. I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Your service is appreciated.""*)
  - -> `[15]` (*Player: ""If we do this, I promise, you will be kings.""*)
  - -> `[16]` (*Player: ""Together we will make Sordland great.""*)
  - -> `[17]` (*Player: ""Thanks for the meeting, gentlemen.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""Thank you for the kind words, sir.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""If we do this, I promise, you will be kings.""]** — Mówca: **Player**
> ""If we do this, I promise, you will be kings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""Thank you for the kind words, sir.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Together we will make Sordland great.""]** — Mówca: **Player**
> ""Together we will make Sordland great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""Yes we will!""*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Thanks for the meeting, gentlemen.""]** — Mówca: **Player**
> ""Thanks for the meeting, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: ""Thank you for your time, sir.""*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: ""Thank you, Anton.""*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""Yes we will!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""I'm sure you will lead us to greatness, sir. Thanks for ..."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: ""You can count on us, Anton.""*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""I think this is where we'll call it, sir. Have a good day.""*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""I'm sure you will lead us to greatness, sir. Thanks for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""I think this is where we'll call it, sir. Have a good day.""*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""I think this is where we'll call it, sir. Have a good day.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""Thank you for the kind words, sir.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""If we do this, we will be remembered as heroes.""]** — Mówca: **Player**
> ""If we do this, we will be remembered as heroes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Petr Vectern: ""That would be really great!""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Together we will democratize Sordland.""]** — Mówca: **Player**
> ""Together we will democratize Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: ""Ours too, of course.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Thanks for the meeting, everybody.""]** — Mówca: **Player**
> ""Thanks for the meeting, everybody.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""Thank you for your time, sir.""*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""You can count on us, Anton.""*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Since we have arrived at the same page with Ms. Morgna a..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: ""Thank you, Anton.""*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Since we have arrived at the same page with Ms. Morgna a..."*)

### Węzeł `[32]`
Mówca: **Petr Vectern**
> ""That would be really great!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "He laughed."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Since we have arrived at the same page with Ms. Morgna a..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""Yes, sir. Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Since we have arrived at the same page with Ms. Morgna a..."*)

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""Ours too, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""Yes, sir. Thank you for your time.""*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Since we have arrived at the same page with Ms. Morgna again I will reach out to her to for guidance on the draft constitution work. She has principles and wouldn't go against her own code out of previous disagreements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""Anyway, I think this is where we'll call it, sir. Have a..."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""Anyway, I think this is where we'll call it, sir. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""I think this is where we'll call it, sir. Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Narrator: "..."`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_LateBriefing = true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Narrator: "..."`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_LateBriefing = true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path = true;
BaseGame.Reform_Dictator_Intention = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Dictator_Path"] = true;
Variable["BaseGame.Reform_Dictator_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Petr Vectern: ""I will fully support you, Anton.""*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""Let's not act rash. They have already begun mobilising support against our reform attempts but if we go down the route of removing the Court vote on legislation, it must be thoroughly considered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""The Vice President has a point. It's us versus them now.""*)
  - -> `[46]` (*Player: ""Let's consider all of our options carefully.""*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[43]`
Mówca: **Petr Vectern**
> ""After what they pulled off I say let's screw them over. We can go all the way with the reforms and shatter the power of the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: ""The people chose us to make real change and to do it, we..."*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""The people chose us to make real change and to do it, we need to gain as much constitutional power to remove the obstructionists from power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: ""Let's not act rash. They have already begun mobilising s..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""The Vice President has a point. It's us versus them now.""]** — Mówca: **Player**
> ""The Vice President has a point. It's us versus them now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: ""The lines are drawn sir.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Let's consider all of our options carefully.""]** — Mówca: **Player**
> ""Let's consider all of our options carefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Petr Vectern: ""True, sorry I got a little hotheaded.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""The future lies in a true reform of the constitution. The people elected us for that, let us embrace our purpose.""]** — Mówca: **Player**
> ""The future lies in a true reform of the constitution. The people elected us for that, let us embrace our purpose.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Petr Vectern: ""Why don't we take more power away from them?""*)

### Węzeł `[48]`
Mówca: **Petr Vectern**
> ""Why don't we take more power away from them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""The reform committee has presented two options. It's eit..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path = true;
BaseGame.Reform_Reformist_Intention = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reformist_Path"] = true;
Variable["BaseGame.Reform_Reformist_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: ""Very well if that is your decision. We will need to enga..."*)

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""True, sorry I got a little hotheaded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""The reform committee has presented two options. It's eit..."*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""It was always. But how do we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""The reform committee has presented two options. It's eit..."*)

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""The lines are drawn sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""It was always. But how do we proceed?""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""The future lies in a true reform of the constitution. Th..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Let's consolidate our constitutional power and remove the Old Guard equation.""]** — Mówca: **Player**
> ""Let's consolidate our constitutional power and remove the Old Guard equation.""
- **Wymagania odblokowania (kod gry):** `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_LateBrief_DictatorBranch = true; Bas..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We should not be blinded by hatred of foes. Our true purpose will be real reform for the future of this nation.""]** — Mówca: **Player**
> ""We should not be blinded by hatred of foes. Our true purpose will be real reform for the future of this nation.""
- **Wymagania odblokowania (kod gry):** `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] == false`
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_LateBrief_ReformistBranch = true; Ba..."*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""The reform committee has presented two options. It's either we take more power to ourselves to beat the Old Guard or we opt for a true reformist agenda to democratise Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_LateBrief_ReformistBranch == false"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_LateBrief_DictatorBranch == false"*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""Very well if that is your decision. We will need to engage further with the progressive wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Intention"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "A few minutes later, Lucian and Petr arrived."*)

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""I will fully support you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: ""There are some people in USP who would support a new Con..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_LateBrief_ReformistBranch = true; BaseGameSupport.Journal_Turn03_LateReform_Reformist = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] = true;
Variable["BaseGameSupport.Journal_Turn03_LateReform_Reformist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path = true; BaseGame.Reform_Re..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_LateBrief_DictatorBranch = true; BaseGameSupport.Journal_Turn03_LateReform_Dictator = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] = true;
Variable["BaseGameSupport.Journal_Turn03_LateReform_Dictator"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path = true; BaseGame.Reform_Dic..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_LateBrief_ReformistBranch == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_LateBrief_ReformistBranch == false"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn03_LateBrief_ReformistBranch == false)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_LateBrief_ReformistBranch == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Let's consolidate our constitutional power and remove th..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn03_LateBrief_ReformistBranch == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn03_LateBrief_ReformistBranch"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_LateBrief_DictatorBranch == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_LateBrief_DictatorBranch == false"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn03_LateBrief_DictatorBranch == false)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_LateBrief_DictatorBranch == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""We should not be blinded by hatred of foes. Our true pur..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn03_LateBrief_DictatorBranch == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn03_LateBrief_DictatorBranch"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
