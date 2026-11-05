# Sordland/Turn01/Trailer_Intro

- **ID konwersacji:** `7`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/007_Trailer_Intro.md`
- **Liczba węzłów dialogowych:** 8
- **Liczba wyborów gracza:** 2

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[51]** Symon Holl

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
| `[5]` | **""Promote market economy.""** | `[4]` **Symon Holl**: ""What will our grand economic pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Symon Holl**: ""I will get to work on it immedi..." |
| `[6]` | **""Promote planned economy.""** | `[4]` **Symon Holl**: ""What will our grand economic pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Symon Holl**: ""I will get to work on it immedi..." |

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
  - -> `[3]` (*Narrator: "Symon Holl sat right across from me."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Symon Holl sat right across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: ""What will our grand economic plan be, Mr. President?""*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> ""What will our grand economic plan be, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""Promote market economy.""*)
  - -> `[6]` (*Player: ""Promote planned economy.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Promote market economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: ""I will get to work on it immediately.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Promote planned economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: ""I will get to work on it immediately.""*)

### Węzeł `[7]`
Mówca: **Symon Holl**
> ""I will get to work on it immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
