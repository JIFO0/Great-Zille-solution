# Rizia/Turn 8/Bull Gift

- **ID konwersacji:** `418`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/418_Bull_Gift.md`
- **Liczba węzłów dialogowych:** 19
- **Liczba wyborów gracza:** 4

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Trait_FunnyKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Resources_Authority`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[417] Rizia/Turn 8/A_RoyalWedding** (../Turn_08/417_A_RoyalWedding.md), Węzeł `[314]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""House Toras shall hold the throne for a thousand years.""** | `[7]` **Hugo Toras**: ""It belonged to my mother. I bel..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...` | `[16]` **Narrator**: "We both turned our attention for..." |
| `[10]` | **""We are Torases. Strong, stubborn, immovable.""** | `[7]` **Hugo Toras**: ""It belonged to my mother. I bel..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...` | `[16]` **Narrator**: "We both turned our attention for..." |
| `[11]` | **""I am the King, Hugo. I take no bull.""** | `[7]` **Hugo Toras**: ""It belonged to my mother. I bel..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[17]` **Hugo Toras**: ""Ha. I insist you take this one."" |
| `[15]` | **""I am honored, Your Grace. I will treasure it forever.""** | `[7]` **Hugo Toras**: ""It belonged to my mother. I bel..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Resources_Authority"] = Variable["Rizi...` | `[16]` **Narrator**: "We both turned our attention for..." |

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
  - -> `[3]` (*Narrator: "My uncle turned to me."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[3]`
Mówca: **Narrator**
> "My uncle turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Hugo Toras: ""I have a gift for the bride and groom. The deed to a sil..."*)

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""I have a gift for the bride and groom. The deed to a silk plantation just outside of Mermi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""But this one is for you.""*)

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""But this one is for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He reached under the table and pulled out a shining golde..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "He reached under the table and pulled out a shining golden figurine. A bull."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_BullFigurine");"*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""It belonged to my mother. I believe you know what it symbolizes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""House Toras shall hold the throne for a thousand years.""*)
  - -> `[10]` (*Player_Romus: ""We are Torases. Strong, stubborn, immovable.""*)
  - -> `[15]` (*Player_Romus: ""I am honored, Your Grace. I will treasure it forever.""*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_BullFigurine");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_BullFigurine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""It belonged to my mother. I believe you know what it sym..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras shall hold the throne for a thousand years.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority += 3;"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are Torases. Strong, stubborn, immovable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority += 3;"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the King, Hugo. I take no bull.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""Ha. I insist you take this one.""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""I am the King, Hugo. I take no bull.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am honored, Your Grace. I will treasure it forever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority += 3;"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "We both turned our attention forward as our guests began to arrive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Ha. I insist you take this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority += 3;"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "We both turned our attention forward as our guests began ..."*)
