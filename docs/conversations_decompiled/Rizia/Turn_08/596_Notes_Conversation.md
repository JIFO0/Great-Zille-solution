# Rizia/Turn 8/Notes/Notes Conversation

- **ID konwersacji:** `596`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/596_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 136
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[77]** Wiktor Smolak (R)
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF`
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan`
- `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2`
- `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1`
- `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2`
- `RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints`

### Skoki między-konwersacyjne:
- Węzeł `[25]` -> **[424] Rizia/Turn 8/FPnT_ZilleNegotiations** (../Turn_08/424_FPnT_ZilleNegotiations.md), Węzeł `[1173]`
- Węzeł `[26]` -> **[424] Rizia/Turn 8/FPnT_ZilleNegotiations** (../Turn_08/424_FPnT_ZilleNegotiations.md), Węzeł `[632]`
- Węzeł `[72]` -> **[424] Rizia/Turn 8/FPnT_ZilleNegotiations** (../Turn_08/424_FPnT_ZilleNegotiations.md), Węzeł `[484]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""Fine. If it's gas imports you want, I'll make it happen. Even if it means taking ..."** | `[6]` **Wiktor Smolak (R)**: ""Can I count you to help Wehlen ..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[19]` **Wiktor Smolak (R)**: ""Excellent! Your willingness to ..." |
| `[8]` | **""I'm sorry, but I cannot condone any form of oppression against the Bludish people.""** | `[6]` **Wiktor Smolak (R)**: ""Can I count you to help Wehlen ..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[20]` **Wiktor Smolak (R)**: ""That's unfortunate to hear. Wel..."<br>`[24]` **Wiktor Smolak (R)**: ""I'm quite disappointed by your ..." |
| `[9]` | **""I thought I made myself perfectly clear. I want nothing to do with your opression..."** | `[6]` **Wiktor Smolak (R)**: ""Can I count you to help Wehlen ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[20]` **Wiktor Smolak (R)**: ""That's unfortunate to hear. Wel..."<br>`[24]` **Wiktor Smolak (R)**: ""I'm quite disappointed by your ..." |
| `[16]` | **""Alright, fine. If you're dead set on gas imports, I'll play along. But just know,..."** | `[6]` **Wiktor Smolak (R)**: ""Can I count you to help Wehlen ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[17]` | **""Yes. Whatever it takes to get Zille back. What did you have in mind?""** | `[6]` **Wiktor Smolak (R)**: ""Can I count you to help Wehlen ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Wiktor Smolak (R)**: ""I'm glad you asked. Well for st..."<br>`[46]` **Wiktor Smolak (R)**: ""Well, seeing as how you never b..." |
| `[47]` | **""Alright."** | `[45]` **Wiktor Smolak (R)**: ""Agree to one or all proposals, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[48]` | **""I'm willing to agree to only one of those proposals.""** | `[41]` **Wiktor Smolak (R)**: ""Agree to help us fight a common..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[49]` | **""No. I can't do that. The issue is too sensitive. I'm not going to put myself in a..."** | `[44]` **Wiktor Smolak (R)**: ""Agree to one or all of those pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[50]` | **""Say no more. I agree to all of them, as long as you follow through as well.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "Smolak's eyes went wide." |
| `[65]` | **""So you haven't given up on your crusades against the Bluds.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hu...` | `[66]` **Wiktor Smolak (R)**: ""That's like asking to give up o..." |
| `[69]` | **""Yes, they are indeed a threat. But the political ramifications from the your cond..."** | `[68]` **Wiktor Smolak (R)**: ""As should you. They're just as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[70]` | **""While Rizia has our own issues with the Bluds, their nothing compared to the your..."** | `[68]` **Wiktor Smolak (R)**: ""As should you. They're just as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[71]` | **""True. I can't argue with that.""** | `[68]` **Wiktor Smolak (R)**: ""As should you. They're just as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[78]` | **"“Titus, what's the meaning of this? Why aren't we heading to the palace as planned?”"** | `[77]` **Narrator**: "Before long, the presidential pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Titus Gordion**: "“I'll find out, Your Majesty.”" |
| `[84]` | **"“’Elsewhere?’ Where?”"** | `[83]` **Titus Gordion**: "“I’m sorry, Your Majesty. There’..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "The convoy pulled up to an airfi..." |
| `[88]` | **"“Well, this is unexpected.”"** | `[87]` **Narrator**: "“With Smolak at the Helm: Wehlen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "If the red carpet stretching fro..." |
| `[92]` | **"“It appears Smolak has a keen eye for... *talent*.”"** | `[91]` **Narrator**: "It wasn’t until I neared the sta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Titus Gordion**: "“If by ‘talent’ you mean pretty ..." |
| `[97]` | **""** | `[91]` **Narrator**: "It wasn’t until I neared the sta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[98]` | **""The man's got his very own private blimp... why am I not surprised?""** | `[87]` **Narrator**: "“With Smolak at the Helm: Wehlen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[99]` | **""** | `[87]` **Narrator**: "“With Smolak at the Helm: Wehlen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[100]` | **"“Looks like Smolak's crew selection process involves a very specific type.""** | `[91]` **Narrator**: "It wasn’t until I neared the sta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[101]` | **""** | `[91]` **Narrator**: "It wasn’t until I neared the sta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[102]` | **""** | `[83]` **Titus Gordion**: "“I’m sorry, Your Majesty. There’..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[103]` | **""** | `[83]` **Titus Gordion**: "“I’m sorry, Your Majesty. There’..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[104]` | **""** | `[83]` **Titus Gordion**: "“I’m sorry, Your Majesty. There’..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[105]` | **""** | `[87]` **Narrator**: "“With Smolak at the Helm: Wehlen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[106]` | **""** | `[77]` **Narrator**: "Before long, the presidential pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[107]` | **""** | `[77]` **Narrator**: "Before long, the presidential pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[108]` | **""** | `[77]` **Narrator**: "Before long, the presidential pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[110]` | **""How fortuitous that today, of all days, you chose to watch that specific film.""** | `[109]` **Narrator**: "Smolak wiped his eyes, thought w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Wiktor Smolak (R)**: "“Oh, Your Majesty! Fancy seeing ..." |
| `[112]` | **""** | `[109]` **Narrator**: "Smolak wiped his eyes, thought w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[113]` | **""** | `[109]` **Narrator**: "Smolak wiped his eyes, thought w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[114]` | **""** | `[109]` **Narrator**: "Smolak wiped his eyes, thought w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[118]` | **"“Mr. President?”"** | `[117]` **Narrator**: "And there, sitting amongst the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "He turned to me and held a finge..." |
| `[132]` | **""Is someone there?""** | `[117]` **Narrator**: "And there, sitting amongst the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "He turned to me and held a finge..." |
| `[133]` | **""Smolak, is that you?""** | `[117]` **Narrator**: "And there, sitting amongst the t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "He turned to me and held a finge..." |

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true && RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == tr..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true && RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  and  Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Wiktor Smolak (R): ""Can I count you to help Wehlen counter the Blushish thre..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true && RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  and  Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
Mówca: **Wiktor Smolak (R)**
> ""Can I count you to help Wehlen counter the Blushish threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[17]` (*Player_Romus: ""Yes. Whatever it takes to get Zille back. What did you h..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. If it's gas imports you want, I'll make it happen. Even if it means taking a hit in the short term.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[6]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Wiktor Smolak (R): ""Excellent! Your willingness to adapt to the situation is..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but I cannot condone any form of oppression against the Bludish people.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[6]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought I made myself perfectly clear. I want nothing to do with your opression of the Bludish people.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""I thought I made myself perfectly clear. I want nothing ..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""I'm sorry, but I cannot condone any form of oppression a..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""Alright, fine. If you're dead set on gas imports, I'll p..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""Fine. If it's gas imports you want, I'll make it happen...."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, fine. If you're dead set on gas imports, I'll play along. But just know, we might end up taking a financial dip faster than a lead balloon -- or should I say lead *air ship*, given our present situation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Wiktor Smolak (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Whatever it takes to get Zille back. What did you have in mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)

### Węzeł `[18]`
Mówca: **Wiktor Smolak (R)**
> ""Haha, well played, Your Majesty! It's good to see you haven't lost your sense of humor amidst all this serious talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;"*)

### Węzeł `[19]`
Mówca: **Wiktor Smolak (R)**
> ""Excellent! Your willingness to adapt to the situation is commendable, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;"*)

### Węzeł `[20]`
Mówca: **Wiktor Smolak (R)**
> ""That's unfortunate to hear. Well, if there's no changing your mind, then perhaps you'll agree to another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == tr..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Wiktor Smolak (R): ""That's unfortunate to hear. Well, if there's no changing..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1 == true ||
RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1 == true

)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImport_Hub1"] == true  or 
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_ArmsExport_Hub1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Wiktor Smolak (R): ""I'm quite disappointed by your unwillingness to compromi..."*)

### Węzeł `[24]`
Mówca: **Wiktor Smolak (R)**
> ""I'm quite disappointed by your unwillingness to compromise. In that case, I'm afraid that I have no choice but hold a referendum in Zille regarding the issue of reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ref_Hub_2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1173]`

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ZilleNeg_Hub_2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleNeg_Hub_2]"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_EnergyImports_Hub2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ref_Hub_2]"*)

### Węzeł `[29]`
Mówca: **Wiktor Smolak (R)**
> ""I'm glad you asked. Well for starters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan ==..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderB..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Wiktor Smolak (R): ""I'm glad you asked. Well for starters...""*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Wiktor Smolak (R): ""Well, seeing as how you never broke you promise to fight..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderB..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Wiktor Smolak (R): ""Assist in our efforts to combat the well-know terrorist ..."*)

### Węzeł `[36]`
Mówca: **Wiktor Smolak (R)**
> ""Your decision not to ally with our anti-terrorist operations against the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Wiktor Smolak (R): ""Agree to help us fight a common threat and you'll be one..."*)

### Węzeł `[37]`
Mówca: **Wiktor Smolak (R)**
> ""And your decision to renig on your commitment to wiping out the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Wiktor Smolak (R): ""Agree to one or all of those proposals and you'll be one..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderB..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Wiktor Smolak (R): ""And your decision to renig on your commitment to wiping ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak (R): ""Your decision not to ally with our anti-terrorist operat..."*)

### Węzeł `[41]`
Mówca: **Wiktor Smolak (R)**
> ""Agree to help us fight a common threat and you'll be one step closer to seeing Zille under the Rizian flag once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""I'm willing to agree to only one of those proposals.""*)

### Węzeł `[42]`
Mówca: **Wiktor Smolak (R)**
> ""Assist in our efforts to combat the well-know terrorist group, the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Wiktor Smolak (R): ""Agree to one or all proposals, and I can assure that you..."*)

### Węzeł `[43]`
Mówca: **Wiktor Smolak (R)**
> ""Ban Derdians from crossing into Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)

### Węzeł `[44]`
Mówca: **Wiktor Smolak (R)**
> ""Agree to one or all of those proposals and you'll be one step closer to seeing Zille under the Rizian flag once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""No. I can't do that. The issue is too sensitive. I'm not..."*)

### Węzeł `[45]`
Mówca: **Wiktor Smolak (R)**
> ""Agree to one or all proposals, and I can assure that you'll be one step closer to seeing Zille under the Rizian flag once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""Alright."*)

### Węzeł `[46]`
Mówca: **Wiktor Smolak (R)**
> ""Well, seeing as how you never broke you promise to fight them because you never said you would in the first place, you could...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan ==..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Wiktor Smolak (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm willing to agree to only one of those proposals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Wiktor Smolak (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I can't do that. The issue is too sensitive. I'm not going to put myself in a politically dangerous position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Wiktor Smolak (R))
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say no more. I agree to all of them, as long as you follow through as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Smolak's eyes went wide."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Smolak's eyes went wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Wiktor Smolak (R): ""This is excellent news! To be perfectly honestly, I wasn..."*)

### Węzeł `[52]`
Mówca: **Wiktor Smolak (R)**
> ""This is excellent news! To be perfectly honestly, I wasn't sure I could convince you to agree to just one, let alone all three.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Wiktor Smolak (R)**
> ""Allowing Derdians free reign to cross into Rizia whenever they so choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)

### Węzeł `[54]`
Mówca: **Wiktor Smolak (R)**
> ""There's the issue of Bludish migrants  still being allowed to cross your border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan ==..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan ..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Wiktor Smolak (R): ""There's the issue of Bludish migrants  still being allow..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Wiktor Smolak (R): ""Stop Bludish migrants from crossing your borders.""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderB..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Wiktor Smolak (R): ""Allowing Derdians free reign to cross into Rizia wheneve..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Wiktor Smolak (R): ""Ban Derdians from crossing into Rizia.""*)

### Węzeł `[61]`
Mówca: **Wiktor Smolak (R)**
> ""Stop Bludish migrants from crossing your borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == false && (RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == fals..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == fa..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == false && (RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == false  and  (Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""So you haven't given up on your crusades against the Blu..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 == false && (RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan == true || RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan == true ||
RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF == true)
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] == false  and  (Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_DerdianBorderBan"] == true  or  Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_BludBorderBan"] == true  or 
Variable["RiziaDLC.Diplomacy_Wehlen_PromisesBroken_AntiBFF"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you haven't given up on your crusades against the Bluds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 = true;..."*)

### Węzeł `[66]`
Mówca: **Wiktor Smolak (R)**
> ""That's like asking to give up our national security. The Bluds pose a constant threat, and we must remain vigilant in protecting our borders and our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Wiktor Smolak (R): ""As should you. They're just as much a threat to Rizia as..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1 = true; RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ZilleNeg_BludOptions_Hub1"] = true;
Variable["RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints"] = Variable["RiziaDLCIsolated.Turn08_ZilleNeg_RequestPoints"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Wiktor Smolak (R): ""That's like asking to give up our national security. The..."*)

### Węzeł `[68]`
Mówca: **Wiktor Smolak (R)**
> ""As should you. They're just as much a threat to Rizia as they are to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""While Rizia has our own issues with the Bluds, their not..."*)
  - -> `[69]` (*Player_Romus: ""Yes, they are indeed a threat. But the political ramific..."*)
  - -> `[71]` (*Player_Romus: ""True. I can't argue with that.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, they are indeed a threat. But the political ramifications from the your conditions regarding this issue is too great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleNeg_Hub_1]"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While Rizia has our own issues with the Bluds, their nothing compared to the yours, which is a result of your own making.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleNeg_Hub_1]"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""True. I can't argue with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Jump to: [ZilleNeg_Hub_1]"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ZilleNeg_Hub_1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[73]`
Mówca: **Narrator**
> "As the sun hung low in the sky, casting long shadows over the empty streets of Wraclawitz, our motorcade wound its way through the heart of Wehlen toward the presidential palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Historic buildings lined our path, their ornate facades a..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Historic buildings lined our path, their ornate facades a testament to the city's enduring legacy. Yet, despite their lavish appearance, it was clear that time had taken its toll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "At the behest of President Smolak, I had arrived here wit..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "At the behest of President Smolak, I had arrived here with the purpose of negotiating and sealing the agreement with him that would formally reunite Zille with Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "However, Smolak was conspicuously absent. Upon my plane's..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "However, Smolak was conspicuously absent. Upon my plane's landing, I was taken aback to find myself greeted not by President Smolak, but by an elaborate display of Wehlen soldiers standing in formation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Before long, the presidential palace came into view. But ..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Before long, the presidential palace came into view. But instead of turning towards the grand entrance, our convoy continued past it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[78]` (*Player_Romus: "“Titus, what's the meaning of this? Why aren't we heading..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Titus, what's the meaning of this? Why aren't we heading to the palace as planned?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Titus Gordion: "“I'll find out, Your Majesty.”"*)

### Węzeł `[79]`
Mówca: **Titus Gordion**
> "“I'll find out, Your Majesty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Titus reached for his handheld radio and contacted the le..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Titus reached for his handheld radio and contacted the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Titus Gordion: "“This is Titus. Why are we not heading to the palace?”"*)

### Węzeł `[81]`
Mówca: **Titus Gordion**
> "“This is Titus. Why are we not heading to the palace?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "A crackling response from the captain of our Wehzek secur..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "A crackling response from the captain of our Wehzek security escort came through the radio, but it was too inaudible for me to discern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Titus Gordion: "“I’m sorry, Your Majesty. There’s apparently been a chang..."*)

### Węzeł `[83]`
Mówca: **Titus Gordion**
> "“I’m sorry, Your Majesty. There’s apparently been a change of plans. President Smolak isn't at the palace. We're to meet him elsewhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[84]` (*Player_Romus: "“’Elsewhere?’ Where?”"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“’Elsewhere?’ Where?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "The convoy pulled up to an airfield on the outskirts of t..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "The convoy pulled up to an airfield on the outskirts of the palace grounds, and to my astonishment, a colossal airship awaited me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Its sleek form dominated the skyline, with President Smol..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Its sleek form dominated the skyline, with President Smolak's giant image emblazoned on its side, accompanied by the flag of Wehlen along with a bold proclamations of Wehlen's ascent:"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "“With Smolak at the Helm: Wehlen Rises, Soaring to New He..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "“With Smolak at the Helm: Wehlen Rises, Soaring to New Heights!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[98]` (*Player_Romus: ""The man's got his very own private blimp... why am I not..."*)
  - -> `[88]` (*Player_Romus: "“Well, this is unexpected.”"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Well, this is unexpected.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "If the red carpet stretching from my vehicle to the stair..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "If the red carpet stretching from my vehicle to the stairs leading to the airship’s gondola wasn’t a blatant indicator of where I could find Smolak, nothing was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Before long, I exited the vehicle and made my way down to..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Before long, I exited the vehicle and made my way down toward the airship, escorted by Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "It wasn’t until I neared the stairs that I noticed at lea..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "It wasn’t until I neared the stairs that I noticed at least a dozen or more attractive young women in impeccably pressed uniforms flanked on either side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[100]` (*Player_Romus: "“Looks like Smolak's crew selection process involves a ve..."*)
  - -> `[92]` (*Player_Romus: "“It appears Smolak has a keen eye for... *talent*.”"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“It appears Smolak has a keen eye for... *talent*.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Titus Gordion: "“If by ‘talent’ you mean pretty faces in crisp uniforms, ..."*)

### Węzeł `[93]`
Mówca: **Titus Gordion**
> "“If by ‘talent’ you mean pretty faces in crisp uniforms, then yes. A keen eye, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Stepping inside, the interior of the ship was adorned wit..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Stepping inside, the interior of the ship was adorned with lavish blue and white drapes cascading from floor-to-ceiling windows. Plush magenta seats line the cabin, each embellished with opulent tassels and cushions embroidered with the Wehlen crest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "And crystal chandeliers hung from the ceiling, casting a ..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "And crystal chandeliers hung from the ceiling, casting a dazzling array of light across the space."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "The gondola cabin practically screamed excess, to the poi..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "The gondola cabin practically screamed excess, to the point of absurdity."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man's got his very own private blimp... why am I not surprised?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Looks like Smolak's crew selection process involves a very specific type.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
Mówca: **Narrator**
> "Smolak wiped his eyes, thought whether or not it was in jest was unclear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[110]` (*Player_Romus: ""How fortuitous that today, of all days, you chose to wat..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How fortuitous that today, of all days, you chose to watch that specific film.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Wiktor Smolak (R): "“Oh, Your Majesty! Fancy seeing you here."*)

### Węzeł `[111]`
Mówca: **Wiktor Smolak (R)**
> "“Oh, Your Majesty! Fancy seeing you here."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
Mówca: **Narrator**
> "One of the crew members led us to a room where Smolak was waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "I stepped into total blackness, with the only light comin..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "I stepped into total blackness, with the only light coming from black and white images being projected onto a screen. Smolak apparently his own private movie theater onboard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "And there, sitting amongst the twenty or so seats, was th..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "And there, sitting amongst the twenty or so seats, was the President of Wehlen. He was eating popcorn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""Smolak, is that you?""*)
  - -> `[132]` (*Player_Romus: ""Is someone there?""*)
  - -> `[118]` (*Player_Romus: "“Mr. President?”"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Mr. President?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He turned to me and held a finger to his mouth."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "He turned to me and held a finger to his mouth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Wiktor Smolak (R): "“Shhh! This is the best part!”"*)

### Węzeł `[120]`
Mówca: **Wiktor Smolak (R)**
> "“Shhh! This is the best part!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I immediately recognize it as the Wehlen propaganda film,..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I immediately recognize it as the Wehlen propaganda film, "From Here to Zille" a dramatized version of the 1926 Uprising."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "In it, Wehlen soldiers are portrayed as valiant heroes, w..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "In it, Wehlen soldiers are portrayed as valiant heroes, while the Rizian forces appear bumbling and ineffectual -- highly controversial, to say the least."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "In the scene I was currently watching, a frightened Rizia..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "In the scene I was currently watching, a frightened Rizian solider stood before a firing squad, his fate seemingly sealed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Wiktor Smolak (R): "“Here it comes!”"*)

### Węzeł `[124]`
Mówca: **Wiktor Smolak (R)**
> "“Here it comes!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "But just as the guns are about to fire, a machine gun eru..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "But just as the guns are about to fire, a machine gun erupts, mowing down the entire firing squad. The Rizian turns to see a Wehlen soldier standing over him, bathed in sunlight like a divine savior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Smolak began speaking along with the actors on the screen."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Smolak began speaking along with the actors on the screen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Wiktor Smolak (R): "“’Behold the might of Wehlen! Our noble soldiers, defende..."*)

### Węzeł `[127]`
Mówca: **Wiktor Smolak (R)**
> "“’Behold the might of Wehlen! Our noble soldiers, defenders of justice and champions of the weak! We come to the aid of our Rizian brethren, ensuring peace and prosperity for all under the glorious banner of Wehlen!’""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "The young solider thanked the Wehles soldier, exclaiming ..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "The young solider thanked the Wehles soldier, exclaiming that he was forever in his debt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Soon after, the music swelled and the credits began to roll."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Soon after, the music swelled and the credits began to roll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Wiktor Smolak (R): "“Every time... gets me right in the feelings.”"*)

### Węzeł `[130]`
Mówca: **Wiktor Smolak (R)**
> "“Every time... gets me right in the feelings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "The lights came up, and it was then that I noticed a baby..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "The lights came up, and it was then that I noticed a baby, who couldn’t have been more than a year old, happily sitting next to Smolak."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is someone there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He turned to me and held a finger to his mouth."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Smolak, is that you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He turned to me and held a finger to his mouth."*)

### Węzeł `[134]`
Mówca: **Wiktor Smolak (R)**
> "“But come, let us take our leave so we can talk somewhere more comfortably.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Smolak, still holding his bag of popcorn, picked up littl..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Smolak, still holding his bag of popcorn, picked up little Wiktor in his free hand and left the room. I followed after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "We reentered the observation deck, where I was, once agai..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "We reentered the observation deck, where I was, once again, greeted by extravagance."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
