# Rizia/Turn 6/Star_Align_Notes/Star_Align_Notes Conversation

- **ID konwersacji:** `585`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/585_Star_Align_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 29
- **Liczba wyborów gracza:** 7

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""That I am. It symbolizes the timeless connection between our faith and the heavens.""** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[19]` **Sal Ignacius**: ""Indeed it does."" |
| `[5]` | **""I'm a Wruhecist. How the hell could you possibly think I'm not?""** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[21]` **Narrator**: "Sal respectfully bowed his head." |
| `[15]` | **""It's unsettling that you'd doubt my familiarity.""** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[28]` **Narrator**: "Sal offered a respectful bow of ..." |
| `[16]` | **""That I am. The celestial alignment holds great importance in our religious herita..."** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[27]` **Sal Ignacius**: ""I'm glad you think so."" |
| `[17]` | **""Indeed, I've been rehearsing my 'impressed by the universe' face for weeks now.""** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[26]` **Sal Ignacius**: ""It truly completes your counten..." |
| `[18]` | **""Yes. I've been preparing for weeks to truly appreciate the awe-inspiring celestia..."** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[23]` **Sal Ignacius**: ""That pleases me to hear it."" |
| `[22]` | **""Vaguely... I mean, I know about it as much as the next person.""** | `[3]` **Sal Ignacius**: ""It's remarkable that we're abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Sal Ignacius**: ""I'm surprised to hear it. In th..." |

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
Mówca: **Sal Ignacius**
> ""It's remarkable that we're about to witness the same celestial alignment St. Wruhec beheld so many years ago. You're acquainted with the story, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[22]` (*Player_Romus: ""Vaguely... I mean, I know about it as much as the next p..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That I am. It symbolizes the timeless connection between our faith and the heavens.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Sal Ignacius: ""Indeed it does.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm a Wruhecist. How the hell could you possibly think I'm not?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Sal respectfully bowed his head."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""That I am. It symbolizes the timeless connection between..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""That I am. The celestial alignment holds great importanc..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""Indeed, I've been rehearsing my 'impressed by the univer..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""Yes. I've been preparing for weeks to truly appreciate t..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""I'm a Wruhecist. How the hell could you possibly think I..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""It's unsettling that you'd doubt my familiarity.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's unsettling that you'd doubt my familiarity.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Sal offered a respectful bow of his head."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That I am. The celestial alignment holds great importance in our religious heritage.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Sal Ignacius: ""I'm glad you think so.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, I've been rehearsing my 'impressed by the universe' face for weeks now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Sal Ignacius: ""It truly completes your countenance, Your Majesty.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I've been preparing for weeks to truly appreciate the awe-inspiring celestial alignment.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Sal Ignacius: ""That pleases me to hear it.""*)

### Węzeł `[19]`
Mówca: **Sal Ignacius**
> ""Indeed it does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)

### Węzeł `[20]`
Mówca: **Sal Ignacius**
> ""Forgive me. That was never my intention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Sal respectfully bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Sal Ignacius: ""Forgive me. That was never my intention.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vaguely... I mean, I know about it as much as the next person.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Sal Ignacius: ""I'm surprised to hear it. In that case...""*)

### Węzeł `[23]`
Mówca: **Sal Ignacius**
> ""That pleases me to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)

### Węzeł `[24]`
Mówca: **Sal Ignacius**
> ""I'm surprised to hear it. In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)

### Węzeł `[25]`
Mówca: **Sal Ignacius**
> ""As we celebrate tonight's event, I'd be honored to retell the story.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
Mówca: **Sal Ignacius**
> ""It truly completes your countenance, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> ""I'm glad you think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Sal offered a respectful bow of his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Sal Ignacius: ""That was never my intention. Forgive me.""*)

### Węzeł `[29]`
Mówca: **Sal Ignacius**
> ""That was never my intention. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""As we celebrate tonight's event, I'd be honored to retel..."*)
