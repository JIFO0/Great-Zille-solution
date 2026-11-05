# Sordland/Epilogue_WorldWar

- **ID konwersacji:** `261`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_WorldWar)`
- **Lokalizacja pliku:** `Sordland/Epilogue/261_Epilogue_WorldWar.md`
- **Liczba węzłów dialogowych:** 17
- **Liczba wyborów gracza:** 5

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"The only thing you could do was to look away."** | `[3]` **Narrator**: "You rose to your feet as the bri..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_red");` | `[5]` **Narrator**: "What had started as a rumble in ..." |
| `[7]` | **"You looked outside."** | `[6]` **Narrator**: "It took all of your strength and..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_burning");` | `[8]` **Narrator**: "A mushroom-shaped cloud many sky..." |
| `[10]` | **"You couldn't believe what you were seeing."** | `[8]` **Narrator**: "A mushroom-shaped cloud many sky..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_light");` | `[9]` **Narrator**: "You barely registered the shockw..." |
| `[11]` | **"It was the last thing you saw."** | `[9]` **Narrator**: "You barely registered the shockw..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[12]` | **"You closed your ears and crouched down."** | `[5]` **Narrator**: "What had started as a rumble in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "It took all of your strength and..." |

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
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_light");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "You rose to your feet as the bright light enveloped you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: "The only thing you could do was to look away."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The only thing you could do was to look away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_red");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "What had started as a rumble in the distance was now a deafening roar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "You closed your ears and crouched down."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "It took all of your strength and courage to rise to your feet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "You looked outside."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You looked outside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_burning");"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "A mushroom-shaped cloud many skyscrapers tall was towering above Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "You couldn't believe what you were seeing."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "You barely registered the shockwave as the wall of extreme heat and pressure destroyed everything in its path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "It was the last thing you saw."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You couldn't believe what you were seeing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_light");"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was the last thing you saw."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You closed your ears and crouched down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "It took all of your strength and courage to rise to your ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_light");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "You barely registered the shockwave as the wall of extrem..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_light");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "You rose to your feet as the bright light enveloped you."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_red");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "What had started as a rumble in the distance was now a de..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_burning");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_burning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "A mushroom-shaped cloud many skyscrapers tall was towerin..."*)
