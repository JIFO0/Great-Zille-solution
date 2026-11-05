# Rizia/Turn 10/ExecutionDecisions

- **ID konwersacji:** `334`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/334_ExecutionDecisions.md`
- **Liczba węzłów dialogowych:** 18
- **Liczba wyborów gracza:** 3

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"Press your seal on the wax."** | `[9]` **Narrator**: "I reviewed the papers once more." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "It was done. The decision had be..." |
| `[13]` | **"Do not execute anyone."** | `[7]` **Narrator**: "In that impenetrable prison, the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_ExecutionDecisio...` | `[9]` **Narrator**: "I reviewed the papers once more." |
| `[14]` | **"Punishment by execution."** | `[7]` **Narrator**: "In that impenetrable prison, the..." | *Brak (Dostępna bezwarunkowo)* | `ShowPagedDecisionsPanel("Panel_Executions");` | `[9]` **Narrator**: "I reviewed the papers once more." |

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
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Ordering the execution of those who fail..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I always found the Porte Drazon Citadel as majestic as it was unnerving. With its long metal spires, the building emanated an aura of terrifying grandiosity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Just looking at it sent a shiver down my spine."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Just looking at it sent a shiver down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "In my study, a stack of papers were waiting for me."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "In my study, a stack of papers were waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "A matter of life and death."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "A matter of life and death."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "In that impenetrable prison, there were people residing o..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "In that impenetrable prison, there were people residing on my orders. I had to decide on their fates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus_Italic: "Punishment by execution."*)
  - -> `[13]` (*Player_Romus_Italic: "Do not execute anyone."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Executions");`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Executions");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I reviewed the papers once more."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I reviewed the papers once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus_Italic: "Press your seal on the wax."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Press your seal on the wax."]** — Mówca: **Player_Romus_Italic**
> "I pressed my ring on the wax, sealing the order."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "It was done. The decision had been made."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "It was done. The decision had been made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Do not execute anyone."]** — Mówca: **Player_Romus_Italic**
> "I decided not to execute anyone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne =..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Punishment by execution."]** — Mówca: **Player_Romus_Italic**
> "I decided to punish these prisoners by execution."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Executions");"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_ExecutionDecisions_NoOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I reviewed the papers once more."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I always found the Porte Drazon Citadel as majestic as it..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Ordering the execution of those who failed them", "Porte Drazon Citadel", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Ordering the execution of those who failed them","Porte Drazon Citadel","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)
