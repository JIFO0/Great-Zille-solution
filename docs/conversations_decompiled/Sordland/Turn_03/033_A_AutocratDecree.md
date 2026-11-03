# Sordland/Turn03/A_AutocratDecree

- **ID konwersacji:** `33`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/033_A_AutocratDecree.md`
- **Liczba węzłów dialogowych:** 43
- **Liczba wyborów gracza:** 11

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis`
- `BaseGameSupport.News_Turn03_LT_BenfiFestival`
- `GameCondition.Turn03_A_Pre_Constitution`

### Skoki między-konwersacyjne:
- Węzeł `[40]` -> **[34] Sordland/Turn03/Autocrat Post Discussion** (../Turn_03/034_Autocrat_Post_Discussion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[36]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- Węzeł `[39]` (Orso Hawker): `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- Węzeł `[40]` (Orso Hawker): `ShowPagedDecisionsPanel("Panel_EmergencyDecree"); -- Shows Paged Decisions Panel with the name in...`
- Węzeł `[41]` (Orso Hawker): `End();`
- Węzeł `[42]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Orso Hawker)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Orso Hawker**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[4]`
Mówca: **Narrator**
> "They placed the draft for the Emergency act in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""It's because Mr. Ricter made it known that our administration is blocking the reforms. Many are protesting against that now too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Not long after, Orso and Lucian arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[18]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Greetings.”"]** — Mówca: **Player**
> "“Greetings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Finally, you're here.""]** — Mówca: **Player**
> "“Finally, you're here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Livia Suno**
> ""Understood, sir. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I was walking to my office. Today was the day to finally write the Emergency Act and order the execution of the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[11]`
Mówca: **Livia Suno**
> ""Fine, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Talks with the leading figures of the Old Guards were fruitful and the preparation for the emergency was already underway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I feel better now that I've seen you, Livia.""]** — Mówca: **Player**
> "“I feel better now that I've seen you, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Livia left to hang up my coat. I walked into my office and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I walked in the marble corridors of the Palace, thinking about the huge decisions I was going to make."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Livia Suno**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[17]`
Mówca: **Narrator**
> "My secretary greeted me at the entrance to my presidential office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Good morning everybody.”"]** — Mówca: **Player**
> "“Good morning everybody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[19]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I'm just fine.""]** — Mówca: **Player**
> "“I'm just fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I'm about to make stressful decisions. So, not feeling that great.”"]** — Mówca: **Player**
> "“I'm about to make stressful decisions. So, not feeling that great.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[22]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""How are you today?""]** — Mówca: **Player**
> ""How are you today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Good morning, Livia.”"]** — Mówca: **Player**
> "“Good morning, Livia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[25]`
Mówca: **Livia Suno**
> ""Whatever you say, sir. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""You're right, sweetheart. It isn't your place.""]** — Mówca: **Player**
> ""You're right, sweetheart. It isn't your place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""You may be right. But I just don't see any other way out of this.""]** — Mówca: **Player**
> ""You may be right. But I just don't see any other way out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“I'm your boss, Livia. Don't question my decisions.""]** — Mówca: **Player**
> "“I'm your boss, Livia. Don't question my decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
Mówca: **Livia Suno**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
Mówca: **Narrator**
> "She averted her eyes away from me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[31]`
Mówca: **Livia Suno**
> ""More importantly, how are you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[13]`

### Węzeł `[32]`
Mówca: **Livia Suno**
> ""How are you today, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[13]`

### Węzeł `[33]`
Mówca: **Narrator**
> "After carefully examining the draft and my own notes, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
Mówca: **Orso Hawker**
> ""It's time to start the emergency period. The situation on the streets got worse after we last met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[35]`
Mówca: **Orso Hawker**
> ""Regardless of who they are or what they support, the situation is clear. Let's see how we'll proceed with the President's decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[36]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_BenfiFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[37]`
Mówca: **Narrator**
> "She paused before taking my coat. It looked like she had something on her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Livia Suno**
> ""Mr. Rayne, it may not be my place to say this, but I'm wondering about your reasoning behind this emergency act. The people want reforms, and delaying them will only lead to more violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[39]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Pre_Constitution = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[40]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_EmergencyDecree");

// Shows Paged Decisions Panel with the name in database)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_EmergencyDecree");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `34` (*Sordland/Turn03/Autocrat Post Discussion*), Węzeł `[1]`

### Węzeł `[41]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[42]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
