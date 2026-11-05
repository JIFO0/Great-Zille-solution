# Sordland/Turn01/Petr Opens Whisky

- **ID konwersacji:** `5`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/005_Petr_Opens_Whisky.md`
- **Liczba węzłów dialogowych:** 24
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[4] Sordland/Turn01/A_PoliticalOverview** (../Turn_01/004_A_PoliticalOverview.md), Węzeł `[226]`
- Węzeł `[13]` -> **[4] Sordland/Turn01/A_PoliticalOverview** (../Turn_01/004_A_PoliticalOverview.md), Węzeł `[223]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“I sure do hope so.”"** | `[4]` **Petr Vectern**: "“I assure you it won't. We will ..."<br>`[9]` **Petr Vectern**: "“We learned from it all.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[6]` | **"“Relax. I'm just joking.”"** | `[4]` **Petr Vectern**: "“I assure you it won't. We will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "He let out a nervous laugh." |
| `[7]` | **"“We wouldn't get much done. Remember the last administration?”"** | `[19]` **Petr Vectern**: "“What a taste! This is how we sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Petr Vectern**: "“Yeah, but we are different. All..." |
| `[8]` | **"“We can't make the same mistakes again.”"** | `[18]` **Petr Vectern**: "“Yeah, but we are different. All..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Petr Vectern**: "“We learned from it all.”" |
| `[11]` | **"“Yes, we did.”"** | `[9]` **Petr Vectern**: "“We learned from it all.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[12]` | **"“The future awaits, Petr.”"** | `[23]` **Petr Vectern**: "“The 1924? That was my freshman ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Player_Italic**: "I raised my glass and toasted wi..." |
| `[15]` | **"“We could, but maybe we shouldn't.”"** | `[19]` **Petr Vectern**: "“What a taste! This is how we sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Petr Vectern**: "“Maybe not. But thanks for the d..." |
| `[16]` | **"Toast."** | `[12]` **Player**: "“The future awaits, Petr.”"<br>`[21]` **Player**: "“Screw 1924. It is tainting this..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Petr really seemed to be enjoyin..." |
| `[21]` | **"“Screw 1924. It is tainting this moment.”"** | `[23]` **Petr Vectern**: "“The 1924? That was my freshman ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Player_Italic**: "I raised my glass and toasted wi..." |
| `[22]` | **"“I hope it won't be the case for my cabinet.”"** | `[18]` **Petr Vectern**: "“Yeah, but we are different. All..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "He suddenly looked a bit anxious..." |

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
  - -> `[10]` (*Narrator: "I opened the expensive bottle of whiskey and poured it in..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[3]`
Mówca: **Narrator**
> "He let out a nervous laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“I assure you it won't. We will not make the same mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“Relax. I'm just joking.”"*)
  - -> `[5]` (*Player: "“I sure do hope so.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“I sure do hope so.”"]** — Mówca: **Player**
> "“I sure do hope so.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern), `[9]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Relax. I'm just joking.”"]** — Mówca: **Player**
> "“Relax. I'm just joking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "He let out a nervous laugh."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“We wouldn't get much done. Remember the last administration?”"]** — Mówca: **Player**
> "“We wouldn't get much done. Remember the last administration?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: "“Yeah, but we are different. All they did was enjoy the p..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“We can't make the same mistakes again.”"]** — Mówca: **Player**
> "“We can't make the same mistakes again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Petr Vectern: "“We learned from it all.”"*)

### Węzeł `[9]`
Mówca: **Petr Vectern**
> "“We learned from it all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“I sure do hope so.”"*)
  - -> `[11]` (*Player: "“Yes, we did.”"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I opened the expensive bottle of whiskey and poured it in the two glasses I prepared. The exquisite smell filled the room immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: "“The 1924? That was my freshman year. Also the year after..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Yes, we did.”"]** — Mówca: **Player**
> "“Yes, we did.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“The future awaits, Petr.”"]** — Mówca: **Player**
> "“The future awaits, Petr.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Toast."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Arrives For Political Overview]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[14]`
Mówca: **Petr Vectern**
> "“Maybe not. But thanks for the drink. This is really amazing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Arrives For Political Overview]"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“We could, but maybe we shouldn't.”"]** — Mówca: **Player**
> "“We could, but maybe we shouldn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Petr Vectern: "“Maybe not. But thanks for the drink. This is really amaz..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Toast."]** — Mówca: **Player_Italic**
> "I raised my glass and toasted with Petr before smelling the whiskey and taking a sip. The sweet vanilla tone combined with an oaky taste developed into a lingering smokiness."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Petr really seemed to be enjoying himself."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Petr really seemed to be enjoying himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: "“What a taste! This is how we should start all meetings, ..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“Yeah, but we are different. All they did was enjoy the privilege.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“I hope it won't be the case for my cabinet.”"*)
  - -> `[8]` (*Player: "“We can't make the same mistakes again.”"*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> "“What a taste! This is how we should start all meetings, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“We wouldn't get much done. Remember the last administrat..."*)
  - -> `[15]` (*Player: "“We could, but maybe we shouldn't.”"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "He suddenly looked a bit anxious on his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: "“I assure you it won't. We will not make the same mistakes.”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Screw 1924. It is tainting this moment.”"]** — Mówca: **Player**
> "“Screw 1924. It is tainting this moment.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Italic: "Toast."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I hope it won't be the case for my cabinet.”"]** — Mówca: **Player**
> "“I hope it won't be the case for my cabinet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "He suddenly looked a bit anxious on his chair."*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“The 1924? That was my freshman year. Also the year after the revolution. Very difficult times, to be honest, but this smells like heaven.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“The future awaits, Petr.”"*)
  - -> `[21]` (*Player: "“Screw 1924. It is tainting this moment.”"*)
