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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 2

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Resources_Authority`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[8]` (Paskal Beniwoll): `EnableCollectionItem("CollectionItem_BullFigurine");`
- Węzeł `[18]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 3;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `417` (*Rizia/Turn 8/A_RoyalWedding*), Węzeł `[314]`

### Węzeł `[3]`
Mówca: **Narrator**
> "My uncle turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""I have a gift for the bride and groom. The deed to a silk plantation just outside of Mermi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""But this one is for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "He reached under the table and pulled out a shining golden figurine. A bull."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""It belonged to my mother. I believe you know what it symbolizes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[15]`
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_BullFigurine");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_BullFigurine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras shall hold the throne for a thousand years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are Torases. Strong, stubborn, immovable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the King, Hugo. I take no bull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am honored, Your Grace. I will treasure it forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Narrator**
> "We both turned our attention forward as our guests began to arrive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Ha. I insist you take this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority += 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
