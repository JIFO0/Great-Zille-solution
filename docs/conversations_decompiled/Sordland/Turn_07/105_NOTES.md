# Sordland/Turn07/NOTES

- **ID konwersacji:** `105`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/105_NOTES.md`
- **Liczba węzłów dialogowych:** 22
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[36]** Heron Garaci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""I don't like this offer, Mr. Garaci. I need something better than that.""** | `[4]` **Heron Garaci**: ""You know I have both the expert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[10]` | **""It is an interesting offer.""** | `[4]` **Heron Garaci**: ""You know I have both the expert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Heron Garaci**: ""I think it's mutually beneficial."" |
| `[11]` | **""You're asking too much.""** | `[4]` **Heron Garaci**: ""You know I have both the expert..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[12]` | **""I don't know if I can trust you more than Mrs. Morgna.""** | `[4]` **Heron Garaci**: ""You know I have both the expert..." | `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false` | *Brak zmian stanu* | `[18]` **Heron Garaci**: ""I'll show you my influence and ..." |
| `[16]` | **""I like your offer.""** | `[4]` **Heron Garaci**: ""You know I have both the expert..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[17]` **Heron Garaci**: ""I think it's mutually beneficial."" |
| `[20]` | **""It's a deal. I'll make you the next minister of justice.""** | `[19]` **Heron Garaci**: ""So... What do you say, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[21]` | **""Agreed. I'll give you the seat if we pass the vote.""** | `[19]` **Heron Garaci**: ""So... What do you say, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[22]` | **""I'm conflicted.""** | `[19]` **Heron Garaci**: ""So... What do you say, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Heron Garaci**
> ""I'm offering my help in exchange for a position in the cabinet. As the Minister of Law and Justice in the next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[4]`
Mówca: **Heron Garaci**
> ""You know I have both the expertise and the influence. It's a huge offer, Mr. President. For both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""It is an interesting offer.""*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[11]` (*Player: ""You're asking too much.""*)
  - -> `[9]` (*Player: ""I don't like this offer, Mr. Garaci. I need something be..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Heron Garaci: ""I think you'd also agree that Mrs. Morgna isn't doing mu..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Heron Garaci: ""You know I have both the expertise and the influence. It..."*)

### Węzeł `[8]`
Mówca: **Heron Garaci**
> ""I think you'd also agree that Mrs. Morgna isn't doing much to justify the retainment of her position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Heron Garaci: ""You know I have both the expertise and the influence. It..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""I don't like this offer, Mr. Garaci. I need something better than that.""]** — Mówca: **Player**
> ""I don't like this offer, Mr. Garaci. I need something better than that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Heron Garaci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA: ""It is an interesting offer.""]** — Mówca: **Player**
> ""It is an interesting offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Heron Garaci: ""I think it's mutually beneficial.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""You're asking too much.""]** — Mówca: **Player**
> ""You're asking too much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Heron Garaci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I don't know if I can trust you more than Mrs. Morgna.""]** — Mówca: **Player**
> ""I don't know if I can trust you more than Mrs. Morgna.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Heron Garaci: ""I'll show you my influence and my reliability at the vot..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: ""I like your offer.""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""I don't know if I can trust you more than Mrs. Morgna.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I like your offer.""]** — Mówca: **Player**
> ""I like your offer.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Heron Garaci: ""I think it's mutually beneficial.""*)

### Węzeł `[17]`
Mówca: **Heron Garaci**
> ""I think it's mutually beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Heron Garaci: ""So... What do you say, Mr. President?""*)

### Węzeł `[18]`
Mówca: **Heron Garaci**
> ""I'll show you my influence and my reliability at the vote as long as you can promise me that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Heron Garaci: ""So... What do you say, Mr. President?""*)

### Węzeł `[19]`
Mówca: **Heron Garaci**
> ""So... What do you say, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""It's a deal. I'll make you the next minister of justice.""*)
  - -> `[21]` (*Player: ""Agreed. I'll give you the seat if we pass the vote.""*)
  - -> `[22]` (*Player: ""I'm conflicted.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""It's a deal. I'll make you the next minister of justice.""]** — Mówca: **Player**
> ""It's a deal. I'll make you the next minister of justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Heron Garaci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Agreed. I'll give you the seat if we pass the vote.""]** — Mówca: **Player**
> ""Agreed. I'll give you the seat if we pass the vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Heron Garaci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I'm conflicted.""]** — Mówca: **Player**
> ""I'm conflicted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Heron Garaci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
