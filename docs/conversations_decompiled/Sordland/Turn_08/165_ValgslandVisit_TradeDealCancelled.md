# Sordland/Turn08/ValgslandVisit_TradeDealCancelled

- **ID konwersacji:** `165`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/165_ValgslandVisit_TradeDealCancelled.md`
- **Liczba węzłów dialogowych:** 37
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_TradeDeal`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[35]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“I was expecting this to happen.”"** | `[6]` **Deivid Wisci**: "“Because of our alliance with Le..."<br>`[24]` **Deivid Wisci**: "“Because of our alliance and tra..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Deivid Wisci**: "“Me too.”" |
| `[8]` | **"“Is there anyway we can still get them on the table?”"** | `[6]` **Deivid Wisci**: "“Because of our alliance with Le..."<br>`[24]` **Deivid Wisci**: "“Because of our alliance and tra..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Deivid Wisci**: "“Unfortunately not.”" |
| `[9]` | **"“God damn it.”"** | `[6]` **Deivid Wisci**: "“Because of our alliance with Le..."<br>`[24]` **Deivid Wisci**: "“Because of our alliance and tra..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Deivid Wisci**: "“It is unfortunate.”" |
| `[15]` | **"“I'm not going to like this, am I?”"** | `[26]` **Deivid Wisci**: "“That's not all, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "He handed me a document with the..." |
| `[31]` | **"“Go ahead.”"** | `[26]` **Deivid Wisci**: "“That's not all, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "He handed me a document with the..." |
| `[32]` | **"“What happened?”"** | `[26]` **Deivid Wisci**: "“That's not all, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "He handed me a document with the..." |
| `[34]` | **"“Is something wrong?”"** | `[25]` **Deivid Wisci**: "“Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Deivid Wisci**: "“I have just received a communic..." |
| `[35]` | **"“Deivid. Ready for the trip?”"** | `[25]` **Deivid Wisci**: "“Mr. President.”"<br>`[4]` **Narrator**: "I put down the document and slam..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Deivid Wisci**: "“I have just received a communic..." |

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
  - -> `[13]` (*Narrator: "I was in my office preparing my briefcase for the trip ah..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Deivid. Ready for the trip?”"*)

### Węzeł `[3]`
Mówca: **Deivid Wisci**
> "“They are trying to economically weaken us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Deivid Wisci: "“It looks like we have made an adversary.”"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I put down the document and slammed the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“It looks like we have made an adversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I put down the document and slammed the table."*)

### Węzeł `[6]`
Mówca: **Deivid Wisci**
> "“Because of our alliance with Lespia, they have decided to cancel the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“Is there anyway we can still get them on the table?”"*)
  - -> `[7]` (*Player: "“I was expecting this to happen.”"*)
  - -> `[9]` (*Player: "“God damn it.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I was expecting this to happen.”"]** — Mówca: **Player**
> "“I was expecting this to happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deivid Wisci), `[24]` (Deivid Wisci), `[33]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“Me too.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Is there anyway we can still get them on the table?”"]** — Mówca: **Player**
> "“Is there anyway we can still get them on the table?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deivid Wisci), `[24]` (Deivid Wisci), `[33]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Deivid Wisci: "“Unfortunately not.”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“God damn it.”"]** — Mówca: **Player**
> "“God damn it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deivid Wisci), `[24]` (Deivid Wisci), `[33]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Deivid Wisci: "“It is unfortunate.”"*)

### Węzeł `[10]`
Mówca: **Deivid Wisci**
> "“Unfortunately not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Deivid Wisci: "“It seems like the trade deal with Valgsland fell.”"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I started unpacking my briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“That's not all, Mr. President.”"*)

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“It seems like the trade deal with Valgsland fell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I started unpacking my briefcase."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I was in my office preparing my briefcase for the trip ahead to Haelm in Valgsland to discuss the trade deal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I heard two knocks and I turned around to see Deivid."*)

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“Me too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Deivid Wisci: "“It is unfortunate.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I'm not going to like this, am I?”"]** — Mówca: **Player**
> "“I'm not going to like this, am I?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "He handed me a document with the emblem of the Ministry o..."*)

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“It is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I started unpacking my briefcase."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I heard two knocks and I turned around to see Deivid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He was panting heavily."*)

### Węzeł `[18]`
Mówca: **Deivid Wisci**
> "“It is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I started unpacking my briefcase."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true && BaseGame.Lespia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true && BaseGame.Lespia_Trade..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true && BaseGame.Lespia_Tra..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true && BaseGame.Lespia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Deivid Wisci: "“Because of our alliance and trade deal with Lespia, they..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true && BaseGame.Lespia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“I have just received a communication from the Ministry of Foreign Affairs of Valgsland about our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true && BaseGame.Lespia_Trade..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He was panting heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deivid Wisci: "“Mr. President.”"*)

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Because of our alliance and trade deal with Lespia, they have decided to cancel the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“Is there anyway we can still get them on the table?”"*)
  - -> `[7]` (*Player: "“I was expecting this to happen.”"*)
  - -> `[9]` (*Player: "“God damn it.”"*)

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Deivid. Ready for the trip?”"*)
  - -> `[34]` (*Player: "“Is something wrong?”"*)

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“That's not all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Go ahead.”"*)
  - -> `[15]` (*Player: "“I'm not going to like this, am I?”"*)
  - -> `[32]` (*Player: "“What happened?”"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true )"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Deivid Wisci: "“Because of our alliance with Lespia, they have decided t..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Deivid Wisci: "“Because of our trade deal with Lespia, they have decided..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "He handed me a document with the emblem of the Ministry of Economy of Valgsland on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Deivid Wisci: "“Valgsland has put tariffs on our trade in retaliation.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Go ahead.”"]** — Mówca: **Player**
> "“Go ahead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "He handed me a document with the emblem of the Ministry o..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“What happened?”"]** — Mówca: **Player**
> "“What happened?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "He handed me a document with the emblem of the Ministry o..."*)

### Węzeł `[33]`
Mówca: **Deivid Wisci**
> "“Because of our trade deal with Lespia, they have decided to cancel the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“Is there anyway we can still get them on the table?”"*)
  - -> `[7]` (*Player: "“I was expecting this to happen.”"*)
  - -> `[9]` (*Player: "“God damn it.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Is something wrong?”"]** — Mówca: **Player**
> "“Is something wrong?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Deivid Wisci: "“I have just received a communication from the Ministry o..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Deivid. Ready for the trip?”"]** — Mówca: **Player**
> "“Deivid. Ready for the trip?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Deivid Wisci), `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Deivid Wisci: "“I have just received a communication from the Ministry o..."*)

### Węzeł `[36]`
Mówca: **Deivid Wisci**
> "“Valgsland has put tariffs on our trade in retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Deivid Wisci: "“They are trying to economically weaken us.”"*)
