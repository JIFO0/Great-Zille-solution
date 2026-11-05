# Sordland/Epilogue_ElectionDeath

- **ID konwersacji:** `258`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ElectionDeath)`
- **Lokalizacja pliku:** `Sordland/Epilogue/258_Epilogue_ElectionDeath.md`
- **Liczba węzłów dialogowych:** 23
- **Liczba wyborów gracza:** 4

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **"You looked down."** | `[3]` **Narrator**: "Time froze. You saw the crowd lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "Your shirt was stained with bloo..."<br>`[18]` **Narrator**: "Your shirt was stained with bloo..." |
| `[14]` | **"Your vision started fading."** | `[4]` **Narrator**: "You heard someone yell "Or Dax Q..."<br>`[12]` **Narrator**: "You heard someone yell "For Free..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "A dull pain engulfed your body. ..." |
| `[15]` | **"The end had come."** | `[11]` **Narrator**: "A dull pain engulfed your body. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[16]` | **"You felt cold."** | `[17]` **Narrator**: "Your shirt was stained with bloo..."<br>`[18]` **Narrator**: "Your shirt was stained with bloo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "You heard someone yell "For Free..."<br>`[4]` **Narrator**: "You heard someone yell "Or Dax Q..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Narrator: "Time froze. You saw the crowd looking at you in shock."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Time froze. You saw the crowd looking at you in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "You looked down."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "You heard someone yell "Or Dax Querna! Qival Rumburgia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "Your vision started fading."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Your shirt was stained with blood.  You lost your balance..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Your shirt was stained with blood.  You fell into Monica'..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Secur..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "You heard someone yell "For Free Bludia! Yollak Bluderat!""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumburg..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "A dull pain engulfed your body. You felt weak and tired.

You closed your eyes for one last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "The end had come."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "You heard someone yell "For Free Bludia! Yollak Bluderat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "Your vision started fading."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You looked down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your vision started fading."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator), `[12]` (Narrator), `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "A dull pain engulfed your body. You felt weak and tired. ..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The end had come."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt cold."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Unrest_BFF_Happened == true && BaseGame.Securit..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Your shirt was stained with blood.

You lost your balance and fell to the floor. People started screaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "You felt cold."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Your shirt was stained with blood.

You fell into Monica's arms. She screamed while holding your bloodied hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "You felt cold."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumburg..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_RumburgWarWin == true && BaseGame.Rumbu..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "You heard someone yell "Or Dax Querna! Qival Rumburgia!""*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "You heard someone scream."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "You heard someone scream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "Your vision started fading."*)
