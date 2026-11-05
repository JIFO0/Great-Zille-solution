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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“Greetings.”"** | `[6]` **Narrator**: "Not long after, Orso and Lucian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Orso Hawker**: ""Good morning, Mr. President."" |
| `[8]` | **"“Finally, you're here.""** | `[6]` **Narrator**: "Not long after, Orso and Lucian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Orso Hawker**: ""Good morning, Mr. President."" |
| `[13]` | **"“I feel better now that I've seen you, Livia.""** | `[31]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[32]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She averted her eyes away from m..." |
| `[18]` | **"“Good morning everybody.”"** | `[6]` **Narrator**: "Not long after, Orso and Lucian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Orso Hawker**: ""Good morning, Mr. President."" |
| `[20]` | **"“I'm just fine.""** | `[31]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[32]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Livia Suno**: ""That's good to hear."" |
| `[21]` | **"“I'm about to make stressful decisions. So, not feeling that great.”"** | `[31]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[32]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Livia Suno**: ""I'm sorry to hear that."" |
| `[23]` | **""How are you today?""** | `[19]` **Livia Suno**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Livia Suno**: ""Fine, thank you."" |
| `[24]` | **"“Good morning, Livia.”"** | `[19]` **Livia Suno**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Livia Suno**: ""How are you today, sir?"" |
| `[26]` | **""You're right, sweetheart. It isn't your place.""** | `[38]` **Livia Suno**: ""Mr. Rayne, it may not be my pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Livia Suno**: ""Understood, sir. I'll take your..." |
| `[27]` | **""You may be right. But I just don't see any other way out of this.""** | `[38]` **Livia Suno**: ""Mr. Rayne, it may not be my pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Livia Suno**: ""Whatever you say, sir. I'll tak..." |
| `[28]` | **"“I'm your boss, Livia. Don't question my decisions.""** | `[38]` **Livia Suno**: ""Mr. Rayne, it may not be my pla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Livia Suno**: ""Whatever you say, sir. I'll tak..." |

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
  - -> `[10]` (*Narrator: "I was walking to my office. Today was the day to finally ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Orso Hawker**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Orso Hawker: ""It's time to start the emergency period. The situation o..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "They placed the draft for the Emergency act in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""It's because Mr. Ricter made it known that our administration is blocking the reforms. Many are protesting against that now too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Orso Hawker: ""Regardless of who they are or what they support, the sit..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Not long after, Orso and Lucian arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“Greetings.”"*)
  - -> `[8]` (*Player: "“Finally, you're here.""*)
  - -> `[18]` (*Player: "“Good morning everybody.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Greetings.”"]** — Mówca: **Player**
> "“Greetings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Orso Hawker: ""Good morning, Mr. President.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Finally, you're here.""]** — Mówca: **Player**
> "“Finally, you're here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Orso Hawker: ""Good morning, Mr. President.""*)

### Węzeł `[9]`
Mówca: **Livia Suno**
> ""Understood, sir. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Livia left to hang up my coat. I walked into my office an..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I was walking to my office. Today was the day to finally write the Emergency Act and order the execution of the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_BenfiFestival = true"*)

### Węzeł `[11]`
Mówca: **Livia Suno**
> ""Fine, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Livia Suno: ""More importantly, how are you, sir?""*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Talks with the leading figures of the Old Guards were fruitful and the preparation for the emergency was already underway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I walked in the marble corridors of the Palace, thinking ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I feel better now that I've seen you, Livia.""]** — Mówca: **Player**
> "“I feel better now that I've seen you, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Livia Suno), `[32]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She averted her eyes away from me and smiled."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Livia left to hang up my coat. I walked into my office and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Not long after, Orso and Lucian arrived."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I walked in the marble corridors of the Palace, thinking about the huge decisions I was going to make."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "My secretary greeted me at the entrance to my presidentia..."*)

### Węzeł `[16]`
Mówca: **Livia Suno**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "My secretary greeted me at the entrance to my presidential office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Livia Suno: ""Good morning, Mr. President.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Good morning everybody.”"]** — Mówca: **Player**
> "“Good morning everybody.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Orso Hawker: ""Good morning, Mr. President.""*)

### Węzeł `[19]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“Good morning, Livia.”"*)
  - -> `[23]` (*Player: ""How are you today?""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I'm just fine.""]** — Mówca: **Player**
> "“I'm just fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Livia Suno), `[32]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Livia Suno: ""That's good to hear.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I'm about to make stressful decisions. So, not feeling that great.”"]** — Mówca: **Player**
> "“I'm about to make stressful decisions. So, not feeling that great.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Livia Suno), `[32]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Livia Suno: ""I'm sorry to hear that.""*)

### Węzeł `[22]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""How are you today?""]** — Mówca: **Player**
> ""How are you today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Livia Suno: ""Fine, thank you.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Good morning, Livia.”"]** — Mówca: **Player**
> "“Good morning, Livia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Livia Suno: ""How are you today, sir?""*)

### Węzeł `[25]`
Mówca: **Livia Suno**
> ""Whatever you say, sir. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Livia left to hang up my coat. I walked into my office an..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""You're right, sweetheart. It isn't your place.""]** — Mówca: **Player**
> ""You're right, sweetheart. It isn't your place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Livia Suno: ""Understood, sir. I'll take your coat now.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""You may be right. But I just don't see any other way out of this.""]** — Mówca: **Player**
> ""You may be right. But I just don't see any other way out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Livia Suno: ""Whatever you say, sir. I'll take your coat now.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“I'm your boss, Livia. Don't question my decisions.""]** — Mówca: **Player**
> "“I'm your boss, Livia. Don't question my decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Livia Suno: ""Whatever you say, sir. I'll take your coat now.""*)

### Węzeł `[29]`
Mówca: **Livia Suno**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "She averted her eyes away from me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Livia Suno: ""Thank you, Mr. President.""*)

### Węzeł `[31]`
Mówca: **Livia Suno**
> ""More importantly, how are you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“I'm just fine.""*)
  - -> `[21]` (*Player: "“I'm about to make stressful decisions. So, not feeling t..."*)
  - -> `[13]` (*Player: "“I feel better now that I've seen you, Livia.""*)

### Węzeł `[32]`
Mówca: **Livia Suno**
> ""How are you today, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“I'm just fine.""*)
  - -> `[21]` (*Player: "“I'm about to make stressful decisions. So, not feeling t..."*)
  - -> `[13]` (*Player: "“I feel better now that I've seen you, Livia.""*)

### Węzeł `[33]`
Mówca: **Narrator**
> "After carefully examining the draft and my own notes, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_EmergencyDecree");  // Sho..."*)

### Węzeł `[34]`
Mówca: **Orso Hawker**
> ""It's time to start the emergency period. The situation on the streets got worse after we last met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""It's because Mr. Ricter made it known that our administr..."*)

### Węzeł `[35]`
Mówca: **Orso Hawker**
> ""Regardless of who they are or what they support, the situation is clear. Let's see how we'll proceed with the President's decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "They placed the draft for the Emergency act in front of me."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_BenfiFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Talks with the leading figures of the Old Guards were fru..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "She paused before taking my coat. It looked like she had something on her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Livia Suno: ""Mr. Rayne, it may not be my place to say this, but I'm w..."*)

### Węzeł `[38]`
Mówca: **Livia Suno**
> ""Mr. Rayne, it may not be my place to say this, but I'm wondering about your reasoning behind this emergency act. The people want reforms, and delaying them will only lead to more violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""You're right, sweetheart. It isn't your place.""*)
  - -> `[27]` (*Player: ""You may be right. But I just don't see any other way out..."*)
  - -> `[28]` (*Player: "“I'm your boss, Livia. Don't question my decisions.""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Pre_Constitution = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After carefully examining the draft and my own notes, I b..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_EmergencyDecree");

// Shows Paged Decisions Panel with the name in database`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_EmergencyDecree");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "End();"*)
