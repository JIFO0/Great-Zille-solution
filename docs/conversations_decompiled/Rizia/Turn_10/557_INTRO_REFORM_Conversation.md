# Rizia/Turn 10/STRIKE SCENE/INTRO_REFORM/INTRO_REFORM Conversation

- **ID konwersacji:** `557`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/557_INTRO_REFORM_Conversation.md`
- **Liczba węzłów dialogowych:** 255
- **Liczba wyborów gracza:** 43

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.HouseOfDelegates_Speaker_Adarfo`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Manus_SecurityThreat`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[29]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""I think we've started on the wrong foot here. Before we talk further, I want to r..."** | `[172]` **Hugo Toras**: ""So it is true. You were collabo..."<br>`[183]` **Hugo Toras**: ""Is is true, Romus? You were col..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "I raised my glass." |
| `[4]` | **""A wise man once said, 'Resistance to change is futile when the wheels of time tur..."** | `[92]` **Narrator**: "Everyone was seated around a lon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Narrator**: "There was a tense silence follow..." |
| `[5]` | **""I've called you in here as a courtesy to let you know that there's going to be so..."** | `[92]` **Narrator**: "Everyone was seated around a lon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Hugo Toras**: ""Well, I think the curtain in th..." |
| `[6]` | **""Thank you everyone for coming here this evening. I have something important to te..."** | `[92]` **Narrator**: "Everyone was seated around a lon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "There was a tense silence follow..." |
| `[10]` | **""For centuries, the monarchy has been the stabilizing force of Rizia...""** | `[9]` **Narrator**: "There was a ripple of light laug..."<br>`[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[46]` **Player_Romus**: ""But clinging too tightly to tra..."<br>`[44]` **Player_Romus**: ""While the Crown has borne the w..."<br>*(oraz 4 innych odgałęzień)* |
| `[11]` | **""You people have taken Rizia for granted.""** | `[9]` **Narrator**: "There was a ripple of light laug..."<br>`[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[46]` **Player_Romus**: ""But clinging too tightly to tra..."<br>`[44]` **Player_Romus**: ""While the Crown has borne the w..."<br>*(oraz 4 innych odgałęzień)* |
| `[12]` | **""Rizia deserves more than the weight of its history -- she deserves a future unsha..."** | `[9]` **Narrator**: "There was a ripple of light laug..."<br>`[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[46]` **Player_Romus**: ""But clinging too tightly to tra..."<br>`[44]` **Player_Romus**: ""While the Crown has borne the w..."<br>*(oraz 4 innych odgałęzień)* |
| `[17]` | **""To my mother, Queen Estela, and to the future of Rizia!""** | `[18]` **Narrator**: "I raised my glass." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "It was subtle, but it was enough." |
| `[20]` | **""For a democratic Rizia!""** | `[18]` **Narrator**: "I raised my glass." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "It was subtle, but it was enough." |
| `[21]` | **""Now. I want everybody to listen to me very carefully.""** | `[92]` **Narrator**: "Everyone was seated around a lon..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[11]` **Player_Romus**: ""You people have taken Rizia for..."<br>`[10]` **Player_Romus**: ""For centuries, the monarchy has..."<br>*(oraz 4 innych odgałęzień)* |
| `[23]` | **""We can no longer ignore the growing reform movement nor their legitimate request ..."** | `[9]` **Narrator**: "There was a ripple of light laug..."<br>`[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?""<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLC.Reform_Movement_Grows"] == true` | `--;` | `[33]` **Narrator**: "I gestured at the servers to bri..." |
| `[30]` | **""This is the time to heed the calls of the people. They have been loud and clear.""** | `[9]` **Narrator**: "There was a ripple of light laug..."<br>`[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?""<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | `--;` | `[33]` **Narrator**: "I gestured at the servers to bri..." |
| `[32]` | **"Gesture to the servers to bring the constitutional draft."** | `[9]` **Narrator**: "There was a ripple of light laug..."<br>`[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?""<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "They approached the table and la..." |
| `[35]` | **""So... I've gathered you here on this meaningful day to reform our great kingdom a..."** | `[22]` **Narrator**: "The nobles exchanged confused lo..."<br>`[75]` **Hugo Toras**: ""What changes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Rico Toras**: ""What!?""<br>`[72]` **Narrator**: "The chamber seemed to freeze, th..." |
| `[43]` | **""Shut up and listen to me.""** | `[15]` **Taddeus Azaro**: ""Resistance? To what, exactly?"" | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[11]` **Player_Romus**: ""You people have taken Rizia for..."<br>`[10]` **Player_Romus**: ""For centuries, the monarchy has..."<br>*(oraz 4 innych odgałęzień)* |
| `[44]` | **""While the Crown has borne the weight of your greed and apathy, you grew fat on th..."** | `[10]` **Player_Romus**: ""For centuries, the monarchy has..."<br>`[11]` **Player_Romus**: ""You people have taken Rizia for..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucita Azaro**: "You’re speaking in riddles, dear.""<br>`[55]` **Lucita Azaro**: ""You’re speaking in riddles, You..."<br>*(oraz 2 innych odgałęzień)* |
| `[45]` | **""But I see no heirs to this legacy, only scavengers circling a dying institution.""** | `[10]` **Player_Romus**: ""For centuries, the monarchy has..."<br>`[11]` **Player_Romus**: ""You people have taken Rizia for..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucita Azaro**: "You’re speaking in riddles, dear.""<br>`[55]` **Lucita Azaro**: ""You’re speaking in riddles, You..."<br>*(oraz 2 innych odgałęzień)* |
| `[46]` | **""But clinging too tightly to tradition risks dragging us into ruin.""** | `[10]` **Player_Romus**: ""For centuries, the monarchy has..."<br>`[11]` **Player_Romus**: ""You people have taken Rizia for..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucita Azaro**: "You’re speaking in riddles, dear.""<br>`[55]` **Lucita Azaro**: ""You’re speaking in riddles, You..."<br>*(oraz 2 innych odgałęzień)* |
| `[66]` | **""I will be transferring the Crown's lawmaking powers to the House of Delegates ent..."** | `[22]` **Narrator**: "The nobles exchanged confused lo..."<br>`[75]` **Hugo Toras**: ""What changes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Rico Toras**: ""What!?""<br>`[72]` **Narrator**: "The chamber seemed to freeze, th..." |
| `[67]` | **""Alright. I'll be clear. We are reforming the Kingdom with a new constitution, and..."** | `[22]` **Narrator**: "The nobles exchanged confused lo..."<br>`[75]` **Hugo Toras**: ""What changes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Rico Toras**: ""What!?""<br>`[72]` **Narrator**: "The chamber seemed to freeze, th..." |
| `[71]` | **""What I'm implying is that there will be changes. Changes that prioritizes the peo..."** | `[22]` **Narrator**: "The nobles exchanged confused lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Hugo Toras**: ""What changes?"" |
| `[73]` | **""I need you to sign these documents to show your support for the outlined changes.""** | `[22]` **Narrator**: "The nobles exchanged confused lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Hugo Toras**: ""What changes?"" |
| `[76]` | **""That really doesn't matter. You will have to accept the changes either way.""** | `[75]` **Hugo Toras**: ""What changes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "The chamber seemed to freeze, th..." |
| `[77]` | **""Feel free to read the proposal in detail. When you've finished, add your signatur..."** | `[75]` **Hugo Toras**: ""What changes?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "The chamber seemed to freeze, th..." |
| `[79]` | **""I know all of you have your own personal opinions and concerns about this. That’s..."** | `[94]` **Taddeus Azaro**: ""You're completely out of your m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "He folded his arms." |
| `[89]` | **""As a matter of fact, I can.""** | `[87]` **Taddeus Azaro**: ""With all due respect, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Taddeus Azaro**: ""You're completely out of your m..." |
| `[90]` | **""Please, General. You must understand this is a necessity.""** | `[87]` **Taddeus Azaro**: ""With all due respect, Your Maje..."<br>`[94]` **Taddeus Azaro**: ""You're completely out of your m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "He folded his arms." |
| `[91]` | **""If you don't want any trouble, you'd better just play along and sign the documents.""** | `[87]` **Taddeus Azaro**: ""With all due respect, Your Maje..."<br>`[94]` **Taddeus Azaro**: ""You're completely out of your m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Nobody lifted a finger." |
| `[176]` | **""If our monarchy is to survive this century, we must adapt. Fully empowering the H..."** | `[95]` **Narrator**: "He folded his arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Rico Toras**: ""I will say right from the start..."<br>`[205]` **Angelica Sazon**: ""The need for such a radical act..."<br>*(oraz 1 innych odgałęzień)* |
| `[177]` | **""The Rizian People's Party has already drafted the constitution together with the ..."** | `[95]` **Narrator**: "He folded his arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Rico Toras**: ""I will say right from the start..."<br>`[205]` **Angelica Sazon**: ""The need for such a radical act..."<br>*(oraz 1 innych odgałęzień)* |
| `[178]` | **""I wholeheartedly support the calls for reform. I ask you to do the same.""** | `[95]` **Narrator**: "He folded his arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Rico Toras**: ""I will say right from the start..."<br>`[205]` **Angelica Sazon**: ""The need for such a radical act..."<br>*(oraz 1 innych odgałęzień)* |
| `[179]` | **""Feel free to read the proposal in detail. When you've finished, add your signatur..."** | `[95]` **Narrator**: "He folded his arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Nobody lifted a finger." |
| `[184]` | **""None of that matters now, Hugo. What *does* matter is that these reforms will be ..."** | `[172]` **Hugo Toras**: ""So it is true. You were collabo..."<br>`[183]` **Hugo Toras**: ""Is is true, Romus? You were col..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[42]` **Taddeus Azaro**: ""I did not leave the frontlines ..."<br>`[36]` **Carlos Robles Azaro**: ""Give me a break. This is a dire..." |
| `[185]` | **""I had to hide it. You gave me no other choice.""** | `[172]` **Hugo Toras**: ""So it is true. You were collabo..."<br>`[183]` **Hugo Toras**: ""Is is true, Romus? You were col..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[42]` **Taddeus Azaro**: ""I did not leave the frontlines ..."<br>`[36]` **Carlos Robles Azaro**: ""Give me a break. This is a dire..." |
| `[186]` | **""It is true. I won't become a monarch who desperately clings to power in this day ..."** | `[172]` **Hugo Toras**: ""So it is true. You were collabo..."<br>`[183]` **Hugo Toras**: ""Is is true, Romus? You were col..." | `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false` | `--;` | `[42]` **Taddeus Azaro**: ""I did not leave the frontlines ..."<br>`[36]` **Carlos Robles Azaro**: ""Give me a break. This is a dire..." |
| `[190]` | **""It is true. When acceded the throne, I told everybody that I intended to reform t..."** | `[172]` **Hugo Toras**: ""So it is true. You were collabo..."<br>`[183]` **Hugo Toras**: ""Is is true, Romus? You were col..." | `Variable["RiziaDLC.Focus_Government_Reform"] == true` | `--;` | `[42]` **Taddeus Azaro**: ""I did not leave the frontlines ..."<br>`[36]` **Carlos Robles Azaro**: ""Give me a break. This is a dire..." |
| `[191]` | **""I'm not here to have a debate. Please cooperate so we can move on.""** | `[172]` **Hugo Toras**: ""So it is true. You were collabo..."<br>`[183]` **Hugo Toras**: ""Is is true, Romus? You were col..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[42]` **Taddeus Azaro**: ""I did not leave the frontlines ..."<br>`[36]` **Carlos Robles Azaro**: ""Give me a break. This is a dire..." |
| `[206]` | **""Not so fast.""** | `[37]` **Narrator**: "He grasped the wheels of his cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Suddenly, the doors clicked shut." |
| `[207]` | **""Don't let him leave.""** | `[37]` **Narrator**: "He grasped the wheels of his cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Suddenly, the doors clicked shut." |
| `[208]` | **""You are mistaken. I am not *asking* for your support.""** | `[37]` **Narrator**: "He grasped the wheels of his cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Suddenly, the doors clicked shut." |
| `[209]` | **""Regardless of what happens today, I truly appreciate everyone who has supported m..."** | `[18]` **Narrator**: "I raised my glass." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "It was subtle, but it was enough." |
| `[211]` | **""Where do you think you're going?""** | `[37]` **Narrator**: "He grasped the wheels of his cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Suddenly, the doors clicked shut." |
| `[232]` | **""This isn't a joke.""** | `[9]` **Narrator**: "There was a ripple of light laug..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "There was a tense silence follow..." |

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
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "AddConversant("Taddeus Azaro"); AddConversant("Hugo Toras..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: ""I think we've started on the wrong foot here. Before we talk further, I want to raise a glass to all of you."
[Give the signal]"]** — Mówca: **Player_Romus**
> ""I think we've started on the wrong foot here. Before we talk further, I want to raise a glass to all of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras), `[183]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I raised my glass."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise man once said, 'Resistance to change is futile when the wheels of time turn unceasingly.'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "There was a tense silence followed by uneasy glances."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've called you in here as a courtesy to let you know that there's going to be some changes around here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Well, I think the curtain in this room looks just fine, ..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you everyone for coming here this evening. I have something important to tell you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "There was a tense silence followed by uneasy glances."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Once inside, I closed the door, leaving the celebrations behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Everyone was seated around a long table, the taxidermied ..."*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Well, I think the curtain in this room looks just fine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "There was a ripple of light laughter among the group."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "There was a ripple of light laughter among the group."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[232]` (*Player_Romus: ""This isn't a joke.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For centuries, the monarchy has been the stabilizing force of Rizia...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[15]` (Taddeus Azaro), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You people have taken Rizia for granted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[15]` (Taddeus Azaro), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia deserves more than the weight of its history -- she deserves a future unshackled from the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[15]` (Taddeus Azaro), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[11]` (*Player_Romus: ""You people have taken Rizia for granted.""*)
  - -> `[10]` (*Player_Romus: ""For centuries, the monarchy has been the stabilizing for..."*)
  - -> `[12]` (*Player_Romus: ""Rizia deserves more than the weight of its history -- sh..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "There was a tense silence followed by uneasy glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Taddeus Azaro: ""Resistance? To what, exactly?""*)

### Węzeł `[15]`
Mówca: **Taddeus Azaro**
> ""Resistance? To what, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[43]` (*Player_Romus: ""Shut up and listen to me.""*)

### Węzeł `[16]`
Mówca: **Narrator**
> "It was subtle, but it was enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "As we lifted our glasses, the doors clicked shut."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To my mother, Queen Estela, and to the future of Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "It was subtle, but it was enough."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I raised my glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""For a democratic Rizia!""*)
  - -> `[17]` (*Player_Romus: ""To my mother, Queen Estela, and to the future of Rizia!""*)
  - -> `[209]` (*Player_Romus: ""Regardless of what happens today, I truly appreciate eve..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "As we lifted our glasses, the doors clicked shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For a democratic Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "It was subtle, but it was enough."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now. I want everybody to listen to me very carefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "The nobles exchanged confused looks, their unease growing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[71]` (*Player_Romus: ""What I'm implying is that there will be changes. Changes..."*)
  - -> `[73]` (*Player_Romus: ""I need you to sign these documents to show your support ..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can no longer ignore the growing reform movement nor their legitimate request to be granted their political rights.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[15]` (Taddeus Azaro), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""This is the time to heed the calls of the people. They h..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""We can no longer ignore the growing reform movement nor ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the time to heed the calls of the people. They have been loud and clear.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[15]` (Taddeus Azaro), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I gestured at the servers to bring forth the paperwork th..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "Gesture to the servers to bring the constitutional draft."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the servers to bring forth the paperwork they were holding."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[15]` (Taddeus Azaro), `[21]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "They approached the table and laid the constitutional dra..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "I gestured at the servers to bring forth the paperwork they were holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "They approached the table and laid the constitutional dra..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "They approached the table and laid the constitutional draft, "The Rizian Fundamental Law," upon it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So... I've gathered you here on this meaningful day to reform our great kingdom and finally give the people of Rizia the right to rule themselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[36]`
Mówca: **Carlos Robles Azaro**
> ""Give me a break. This is a direct attack against the Rizian monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "He grasped the wheels of his chair and turned toward the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Romus: ""You are mistaken. I am not *asking* for your support.""*)
  - -> `[207]` (*Player_Romus: ""Don't let him leave.""*)
  - -> `[206]` (*Player_Romus: ""Not so fast.""*)
  - -> `[211]` (*Player_Romus: ""Where do you think you're going?""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Taddeus Azaro: ""I did not leave the frontlines just to listen to this po..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Carlos Robles Azaro: ""Give me a break. This is a direct attack against the Riz..."*)

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""Your Majesty, you must admit that this is incredibly ill timing. Our focus should be on the war, not reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[42]`
Mówca: **Taddeus Azaro**
> ""I did not leave the frontlines just to listen to this populist drivel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucita Azaro: ""Your Majesty, you must admit that this is incredibly ill..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shut up and listen to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While the Crown has borne the weight of your greed and apathy, you grew fat on the very people you were meant to serve.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I see no heirs to this legacy, only scavengers circling a dying institution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But clinging too tightly to tradition risks dragging us into ruin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Player_Romus), `[11]` (Player_Romus), `[12]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[46]` (*Player_Romus: ""But clinging too tightly to tradition risks dragging us ..."*)
  - -> `[44]` (*Player_Romus: ""While the Crown has borne the weight of your greed and a..."*)
  - -> `[45]` (*Player_Romus: ""But I see no heirs to this legacy, only scavengers circl..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> "You’re speaking in riddles, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: "You’re speaking in riddles, dear.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""You’re speaking in riddles, Your Majesty.""*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[56]`
Mówca: **Taddeus Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""Just what exactly are you implying?""*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Carlos Robles Azaro: ""You’re speaking in riddles, Your Majesty.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Taddeus Azaro: ""You’re speaking in riddles, Your Majesty.""*)

### Węzeł `[60]`
Mówca: **Carlos Robles Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""Just what exactly are you implying?""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Carlos Robles Azaro: ""Yes, Your Majesty... What exactly is it you're implying?""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Taddeus Azaro: ""Just what exactly are you implying?""*)

### Węzeł `[64]`
Mówca: **Carlos Robles Azaro**
> ""Yes, Your Majesty... What exactly is it you're implying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[65]`
Mówca: **Taddeus Azaro**
> ""Just what exactly are you implying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be transferring the Crown's lawmaking powers to the House of Delegates entirely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. I'll be clear. We are reforming the Kingdom with a new constitution, and you are not going to stand in its way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus_Italic: "Gesture to the servers to bring the constitutional draft."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I gestured at the servers to bring forth the paperwork th..."*)

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""Just what exactly are you implying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What I'm implying is that there will be changes. Changes that prioritizes the people of Rizia over the nobility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""What changes?""*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The chamber seemed to freeze, their eyes reflecting shock and muted outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "General Taddeus was the first to break the silence."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need you to sign these documents to show your support for the outlined changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""What changes?""*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Manus gave me a troubled glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "The nobles exchanged confused looks, their unease growing."*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""What changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[76]` (*Player_Romus: ""That really doesn't matter. You will have to accept the ..."*)
  - -> `[77]` (*Player_Romus: ""Feel free to read the proposal in detail. When you've fi..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That really doesn't matter. You will have to accept the changes either way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The chamber seemed to freeze, their eyes reflecting shock..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Feel free to read the proposal in detail. When you've finished, add your signature, if you please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The chamber seemed to freeze, their eyes reflecting shock..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""So... I've gathered you here on this meaningful day to r..."*)
  - -> `[66]` (*Player_Romus: ""I will be transferring the Crown's lawmaking powers to t..."*)
  - -> `[67]` (*Player_Romus: ""Alright. I'll be clear. We are reforming the Kingdom wit..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know all of you have your own personal opinions and concerns about this. That’s why I’ve brought you here -- to ensure we embrace this change together on the best possible terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "He folded his arms."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "The chamber seemed to freeze, their eyes reflecting shock and muted outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "After a long silence, Hugo was the first to act. He leane..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "After a long silence, Hugo was the first to act. He leaned on the table and took a look at the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""Really? You brought Sazon's proposal to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Hugo Toras: ""Really? You brought the RPP's proposal to us?""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Really? You brought Sazon's proposal to us?""*)

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""Really? You brought the RPP's proposal to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[87]`
Mówca: **Taddeus Azaro**
> ""With all due respect, Your Majesty, you cannot simply make that decision on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""If you don't want any trouble, you'd better just play al..."*)
  - -> `[89]` (*Player_Romus: ""As a matter of fact, I can.""*)
  - -> `[90]` (*Player_Romus: ""Please, General. You must understand this is a necessity.""*)

### Węzeł `[88]`
Mówca: **Narrator**
> "General Taddeus was the first to break the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Taddeus Azaro: ""With all due respect, Your Majesty, you cannot simply ma..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a matter of fact, I can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Taddeus Azaro: ""You're completely out of your mind!""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, General. You must understand this is a necessity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Taddeus Azaro), `[94]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "He folded his arms."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't want any trouble, you'd better just play along and sign the documents.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Taddeus Azaro), `[94]` (Taddeus Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Nobody lifted a finger."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Everyone was seated around a long table, the taxidermied animal heads looming above them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Now. I want everybody to listen to me very carefully.""*)
  - -> `[5]` (*Player_Romus: ""I've called you in here as a courtesy to let you know th..."*)
  - -> `[4]` (*Player_Romus: ""A wise man once said, 'Resistance to change is futile wh..."*)
  - -> `[6]` (*Player_Romus: ""Thank you everyone for coming here this evening. I have ..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Nobody lifted a finger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "After a long silence, Hugo was the first to act. He leane..."*)

### Węzeł `[94]`
Mówca: **Taddeus Azaro**
> ""You're completely out of your mind!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""If you don't want any trouble, you'd better just play al..."*)
  - -> `[79]` (*Player_Romus: ""I know all of you have your own personal opinions and co..."*)
  - -> `[90]` (*Player_Romus: ""Please, General. You must understand this is a necessity.""*)

### Węzeł `[95]`
Mówca: **Narrator**
> "He folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""I wholeheartedly support the calls for reform. I ask you..."*)
  - -> `[177]` (*Player_Romus: ""The Rizian People's Party has already drafted the consti..."*)
  - -> `[176]` (*Player_Romus: ""If our monarchy is to survive this century, we must adap..."*)
  - -> `[179]` (*Player_Romus: ""Feel free to read the proposal in detail. When you've fi..."*)

### Węzeł `[96]`
Mówca: **Carlos Robles Azaro**
> ""What's the meaning of this, Your Majesty? Since when do the noble houses listen to demands from communist thugs?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[97]`
Mówca: **Carlos Robles Azaro**
> ""Sotelato's radicals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Carlos Robles Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[98]`
Mówca: **Taddeus Azaro**
> ""The boy behind the protests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Taddeus Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Taddeus Azaro: ""The boy behind the protests?""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Manus gave me a troubled glance."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "The nobles exchanged confused looks, their unease growing."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SecurityThreat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SecurityThreat == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_SecurityThreat == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SecurityThreat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_SecurityThreat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Taddeus Azaro: ""The traitor behind the protests?""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_SecurityThreat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_SecurityThreat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Taddeus Azaro: ""The boy behind the protests?""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Taddeus Azaro: ""The boy who wants to dismantle the Rizian Crown?""*)

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""The traitor behind the protests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Taddeus Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""The boy who wants to dismantle the Rizian Crown?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Taddeus Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[113]`
Mówca: **Taddeus Azaro**
> ""What's the meaning of this, Your Majesty? Since when do the noble houses listen to demands from enemies of the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[114]`
Mówca: **Taddeus Azaro**
> ""What's the meaning of this, Your Majesty? Since when do the noble houses bow to populism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Manus Sazon: ""I am standing right here, General.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Angelica Sazon: ""House Sazon has nothing to do with this, General. Please..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Leona Sazon: ""House Sazon has nothing to do with this, General. I advi..."*)

### Węzeł `[121]`
Mówca: **Rico Toras**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The chamber seemed to freeze, their eyes reflecting shock..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Rico Toras: ""What!?""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The chamber seemed to freeze, their eyes reflecting shock..."*)

### Węzeł `[125]`
Mówca: **Manus Sazon**
> ""With all due respect, General, Mr. Sotelato is the leader of the RPP. He represents a greater part of the Rizian population than House Azaro does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "All eyes snapped to Manus, their gazes filled with alarm."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Speaker_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Speaker_Adarfo == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Speaker_Adarfo == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Speaker_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Speaker_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Manus Sazon: ""With all due respect, General, Mr. Sotelato is the Speak..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Speaker_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Speaker_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Manus Sazon: ""With all due respect, General, Mr. Sotelato is the leade..."*)

### Węzeł `[129]`
Mówca: **Manus Sazon**
> ""With all due respect, General, Mr. Sotelato is the Speaker of the House of Delegates. He represents a greater part of the Rizian population than House Azaro does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "All eyes snapped to Manus, their gazes filled with alarm."*)

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""I am standing right here, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Speaker_Adarfo == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[134]`
Mówca: **Manus Sazon**
> ""And with all due respect, as the leader of the RPP, I represent a greater part of the Rizian population than House Azaro does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "All eyes snapped to Manus, their gazes filled with alarm."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Manus Sazon: ""And with all due respect, as the leader of the RPP, I re..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Manus Sazon: ""Nobody wants to dismantle the monarchy. The RPP only wan..."*)

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""Nobody wants to dismantle the monarchy. The RPP only wants reforms. A true constitutional monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Manus Sazon: ""And with all due respect, as the leader of the RPP, I re..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "The others nodded in approval. Hugo stood up and looked a..."*)

### Węzeł `[140]`
Mówca: **Angelica Sazon**
> ""House Sazon has nothing to do with this, General. Please be more respectful when speaking about my son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Carlos Robles Azaro: ""Right. His absence speaks volumes.""*)

### Węzeł `[141]`
Mówca: **Leona Sazon**
> ""House Sazon has nothing to do with this, General. I advise you to be more respectful to my cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Carlos Robles Azaro: ""Right. His absence speaks volumes.""*)

### Węzeł `[142]`
Mówca: **Carlos Robles Azaro**
> ""Right. His absence speaks volumes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Hugo stood up and looked at me."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Carlos Robles Azaro: ""Sotelato's radicals?""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Taddeus Azaro: ""Sotelato's radicals?""*)

### Węzeł `[146]`
Mówca: **Taddeus Azaro**
> ""What's the meaning of this, Your Majesty? Since when do the noble houses listen to demands from anti-monarchists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[147]`
Mówca: **Taddeus Azaro**
> ""Sotelato's radicals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Taddeus Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SecurityThreat == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SecurityThreat == true"*)

### Węzeł `[151]`
Mówca: **Carlos Robles Azaro**
> ""The traitor's son behind the protests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Carlos Robles Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Carlos Robles Azaro: ""The traitor's son behind the protests?""*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Carlos Robles Azaro: ""The traitor's son behind the protests?""*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Carlos Robles Azaro: ""The traitor's son who wants to dismantle the Rizian Crown?""*)

### Węzeł `[158]`
Mówca: **Carlos Robles Azaro**
> ""What's the meaning of this, Your Majesty? Since when do the noble houses bow to populism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SecurityThreat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_SecurityThreat == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_SecurityThreat == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_SecurityThreat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_SecurityThreat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Carlos Robles Azaro: ""The traitor behind the protests?""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_SecurityThreat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_SecurityThreat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[162]`
Mówca: **Carlos Robles Azaro**
> ""The traitor's son who wants to dismantle the Rizian Crown?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Carlos Robles Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[163]`
Mówca: **Carlos Robles Azaro**
> ""What's the meaning of this, Your Majesty? Since when do the noble houses listen to demands from enemies of the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[164]`
Mówca: **Carlos Robles Azaro**
> ""The traitor behind the protests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Carlos Robles Azaro: ""What's the meaning of this, Your Majesty? Since when do ..."*)

### Węzeł `[165]`
Mówca: **Lucita Azaro**
> ""Should have known he was part of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Hugo stood up and looked at me."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucita Azaro: ""Should have known he was part of this.""*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Rico Toras: ""Should have known he was part of this.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Hubertus Toras: ""Should have known he was part of this.""*)

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""So it is true. You were collaborating behind the scenes then? Without consulting the Royal Houses?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "All eyes snapped to Manus, their gazes filled with alarm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[174]`
Mówca: **Rico Toras**
> ""Should have known he was part of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Hugo stood up and looked at me."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Hugo stood up and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Hugo Toras: ""So it is true. You were collaborating behind the scenes ..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our monarchy is to survive this century, we must adapt. Fully empowering the House of Delegates and entrusting governance to the people is the only path forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian People's Party has already drafted the constitution together with the reform movement. It is more than evident that this is what the people want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wholeheartedly support the calls for reform. I ask you to do the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Feel free to read the proposal in detail. When you've finished, add your signature, if you please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Nobody lifted a finger."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Nobody lifted a finger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "After a long silence, Hugo was the first to act. He leane..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Hugo leaned on the table and took a look at the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[182]`
Mówca: **Narrator**
> "The others nodded in approval. Hugo stood up and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Hugo Toras: ""Is is true, Romus? You were collaborating with this man ..."*)

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""Is is true, Romus? You were collaborating with this man behind the scenes? Against the wishes of the Royal Houses?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of that matters now, Hugo. What *does* matter is that these reforms will be enacted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras), `[183]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had to hide it. You gave me no other choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras), `[183]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true. I won't become a monarch who desperately clings to power in this day and age. The reformists are right about Rizia's future.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras), `[183]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""It is true. When acceded the throne, I told everybody th..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""It is true. I won't become a monarch who desperately cli..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true. When acceded the throne, I told everybody that I intended to reform the country, didn't I?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras), `[183]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not here to have a debate. Please cooperate so we can move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Hugo Toras), `[183]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus: ""I think we've started on the wrong foot here. Before we ..."*)
  - -> `[184]` (*Player_Romus: ""None of that matters now, Hugo. What *does* matter is th..."*)
  - -> `[185]` (*Player_Romus: ""I had to hide it. You gave me no other choice.""*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[191]` (*Player_Romus: ""I'm not here to have a debate. Please cooperate so we ca..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[194]`
Mówca: **Taddeus Azaro**
> ""Nobody will be signing anything. What you're asking is unacceptable. You'll have no support from us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Taddeus Azaro: ""Forcing our hand in this underhanded way is not just unc..."*)

### Węzeł `[195]`
Mówca: **Taddeus Azaro**
> ""Forcing our hand in this underhanded way is not just unconventional -- it's a blatant insult to the Royal Houses of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Taddeus Azaro: ""With all due respect, House Azaro will take its leave.""*)

### Węzeł `[196]`
Mówca: **Taddeus Azaro**
> ""With all due respect, House Azaro will take its leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "He grasped the wheels of his chair and turned toward the ..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Rico Toras: ""I will say right from the start that His Majesty's opini..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[200]`
Mówca: **Rico Toras**
> ""I will say right from the start that His Majesty's opinion does not reflect that of the rest of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Hugo leaned on the table and took a look at the proposal."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Angelica Sazon: ""The need for such a radical action is by no means eviden..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Hubertus Toras: ""The need for such a radical action is by no means eviden..."*)

### Węzeł `[204]`
Mówca: **Hubertus Toras**
> ""The need for such a radical action is by no means evident, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Hugo leaned on the table and took a look at the proposal."*)

### Węzeł `[205]`
Mówca: **Angelica Sazon**
> ""The need for such a radical action is by no means evident, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Hugo leaned on the table and took a look at the proposal."*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not so fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Suddenly, the doors clicked shut."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't let him leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Suddenly, the doors clicked shut."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are mistaken. I am not *asking* for your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Suddenly, the doors clicked shut."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless of what happens today, I truly appreciate everyone who has supported me over the past few years.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "It was subtle, but it was enough."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Suddenly, the doors clicked shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where do you think you're going?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Suddenly, the doors clicked shut."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[213]`
Mówca: **Narrator**
> "There was a tense silence followed by uneasy glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucita Azaro: ""I must say I agree.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""I must say I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Taddeus Azaro: ""Nobody will be signing anything. What you're asking is u..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Angelica Sazon: ""I must say I agree.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Hugo Toras: ""He is right.""*)

### Węzeł `[221]`
Mówca: **Angelica Sazon**
> ""I must say I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Taddeus Azaro: ""Nobody will be signing anything. What you're asking is u..."*)

### Węzeł `[222]`
Mówca: **Hugo Toras**
> ""He is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Taddeus Azaro: ""Nobody will be signing anything. What you're asking is u..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Rico Toras: ""They are right.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[226]`
Mówca: **Rico Toras**
> ""They are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Taddeus Azaro: ""Nobody will be signing anything. What you're asking is u..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Angelica Sazon: ""I must say I agree.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Hugo Toras: ""She's right.""*)

### Węzeł `[230]`
Mówca: **Angelica Sazon**
> ""I must say I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Taddeus Azaro: ""Nobody will be signing anything. What you're asking is u..."*)

### Węzeł `[231]`
Mówca: **Hugo Toras**
> ""She's right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Taddeus Azaro: ""Nobody will be signing anything. What you're asking is u..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't a joke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "There was a tense silence followed by uneasy glances."*)

### Węzeł `[233]`
Mówca: **Hubertus Toras**
> ""Should have known he was part of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Hugo stood up and looked at me."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Taddeus Azaro"); AddConversant("Hugo Toras"); AddConversant("Leona Sazon"); AddConversant("Hubertus Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Taddeus Azaro");
AddConversant("Hugo Toras");
AddConversant("Leona Sazon");
AddConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Carlos Robles Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Angelica Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Rico Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Rico Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Once inside, I closed the door, leaving the celebrations ..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Carlos == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Carlos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "AddConversant("Carlos Robles Azaro");"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Carlos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "AddConversant("Angelica Sazon");"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Manus == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Manus == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rico"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rico)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rico`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "AddConversant("Rico Toras");"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rico)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Once inside, I closed the door, leaving the celebrations ..."*)
