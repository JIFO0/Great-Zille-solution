# Sordland/Turn07/IntroWithLucian

- **ID konwersacji:** `125`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/125_IntroWithLucian.md`
- **Liczba węzłów dialogowych:** 124
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.Decision_Turn06_Megaproject_Conriat`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.Decision_Turn06_Megaproject_Sarna`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reform_Court_Success`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[4]`
- Węzeł `[5]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[11]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[13]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[62]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[63]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[95]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Anything you want to say before we go in?""** | `[18]` **Lucian Galade**: ""Of course, sir. I'll be doing m..."<br>`[52]` **Narrator**: "He fixed his tie."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: ""I only want to congratulate you..."<br>`[29]` **Lucian Galade**: ""No, sir. Just keep your cool wi..."<br>*(oraz 2 innych odgałęzień)* |
| `[6]` | **""Thank you, Lucian. You look tired. How are you holding up?""** | `[68]` **Lucian Galade**: ""The Vice President will be open..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Lucian Galade**: ""It's nothing, sir. I am ready a..." |
| `[7]` | **""I couldn't have done it without you.""** | `[76]` **Lucian Galade**: ""I only want to congratulate you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "He slightly bowed his head." |
| `[10]` | **""Good to know. I need you at your full potential.""** | `[8]` **Lucian Galade**: ""It's nothing, sir. I am ready a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucian Galade**: ""Of course, sir. I'll be doing m..." |
| `[12]` | **""I hope so, Lucian. I can't have my team get worn out at a time like this.""** | `[8]` **Lucian Galade**: ""It's nothing, sir. I am ready a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucian Galade**: ""Of course, sir. I'll be doing m..." |
| `[14]` | **""Are you sure? You can be honest with me.""** | `[8]` **Lucian Galade**: ""It's nothing, sir. I am ready a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucian Galade**: ""I'm always honest with you, sir."" |
| `[40]` | **""Thank you, Lucian.""** | `[76]` **Lucian Galade**: ""I only want to congratulate you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucian Galade**: ""No, sir. Thank *you* for reform..." |
| `[41]` | **""It is an emergency... What do they expect?""** | `[72]` **Lucian Galade**: ""You already knew and expected t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lucian Galade**: ""You are right, sir."" |
| `[42]` | **""They don't even have the guts to face me. If the party doesn't fall in line, we m..."** | `[70]` **Lucian Galade**: ""The party is quite discontent a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lucian Galade**: ""Such radical changes towards th..." |
| `[50]` | **""We need their trust. We have to do something to prove our capabilities.""** | `[70]` **Lucian Galade**: ""The party is quite discontent a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Lucian Galade**: ""Of course, sir. Let's discuss t..." |
| `[51]` | **""Alright. Let's go to the meeting and hear these concerns out.""** | `[70]` **Lucian Galade**: ""The party is quite discontent a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Lucian Galade**: ""Of course, sir."" |
| `[54]` | **""I'm afraid we're trapped. Our future is up to the Old Guard now.""** | `[30]` **Lucian Galade**: ""I can't let them bring you down..."<br>`[82]` **Lucian Galade**: ""But we can't allow them to brin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Lucian Galade**: ""Please sir, don't be like that...." |
| `[55]` | **""Alright. Let's get on with this meeting then.""** | `[30]` **Lucian Galade**: ""I can't let them bring you down..."<br>`[82]` **Lucian Galade**: ""But we can't allow them to brin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucian Galade**: ""Of course, sir."" |
| `[56]` | **""We will resist, Lucian. Don't you worry. Nothing will happen to us.""** | `[30]` **Lucian Galade**: ""I can't let them bring you down..."<br>`[82]` **Lucian Galade**: ""But we can't allow them to brin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lucian Galade**: ""Of course, sir."" |
| `[57]` | **""Alright, let's go in and hear them out.""** | `[35]` **Lucian Galade**: ""No, sir. Everything is under co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucian Galade**: ""Of course, sir."" |
| `[58]` | **""What concerns?""** | `[35]` **Lucian Galade**: ""No, sir. Everything is under co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: ""There are members of the cabine..."<br>`[96]` **Lucian Galade**: ""The party is quite discontent a..." |
| `[59]` | **""Concerns? It doesn't sound like everything is under control.""** | `[35]` **Lucian Galade**: ""No, sir. Everything is under co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: ""There are members of the cabine..."<br>`[96]` **Lucian Galade**: ""The party is quite discontent a..." |
| `[67]` | **""I'm ready. Let's go.""** | `[18]` **Lucian Galade**: ""Of course, sir. I'll be doing m..."<br>`[52]` **Narrator**: "He fixed his tie."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lucian Galade**: ""Of course, sir."" |
| `[69]` | **""They don't even have the guts to face me. If the party doesn't fall in line, we m..."** | `[53]` **Lucian Galade**: ""Some Sollists have also been na..."<br>`[72]` **Lucian Galade**: ""You already knew and expected t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucian Galade**: ""Such radical change towards the..." |
| `[73]` | **""We need their trust. We have to do something to prove our capabilities.""** | `[53]` **Lucian Galade**: ""Some Sollists have also been na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Lucian Galade**: ""Of course, sir. Let's discuss t..." |
| `[77]` | **""Alright, let's go in and hear them out.""** | `[29]` **Lucian Galade**: ""No, sir. Just keep your cool wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucian Galade**: ""Of course, sir."" |
| `[79]` | **""Alright. Let's go to the meeting and hear these concerns out.""** | `[53]` **Lucian Galade**: ""Some Sollists have also been na..."<br>`[72]` **Lucian Galade**: ""You already knew and expected t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lucian Galade**: ""Of course, sir."" |
| `[81]` | **""We have done it together.""** | `[76]` **Lucian Galade**: ""I only want to congratulate you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "He slightly bowed his head." |
| `[83]` | **""Do you really think they can impeach me?""** | `[39]` **Lucian Galade**: ""I have already been doing my be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Lucian Galade**: ""They declared that the state of..." |
| `[84]` | **""It doesn't sound like it's going well.""** | `[39]` **Lucian Galade**: ""I have already been doing my be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lucian Galade**: ""The investigation has already b..." |
| `[85]` | **""I trust you Lucian. Take it easy.""** | `[39]` **Lucian Galade**: ""I have already been doing my be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: ""Thank you for your trust in me...." |
| `[90]` | **""What concerns?""** | `[29]` **Lucian Galade**: ""No, sir. Just keep your cool wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Lucian Galade**: ""Our failure of the reforms had ..." |
| `[91]` | **""What are you saying? Should I be expecting something?""** | `[29]` **Lucian Galade**: ""No, sir. Just keep your cool wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucian Galade**: ""No, sir. I don't believe there'..." |

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
  - -> `[71]` (*Narrator: "Lucian stood upright, holding a large folder of files und..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Anything you want to say before we go in?""*)

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""Especially all that lobbying work. But it's nothing to break me down, sir. Trust me, I'm fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He fixed his tie."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Anything you want to say before we go in?""]** — Mówca: **Player**
> ""Anything you want to say before we go in?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucian Galade), `[52]` (Narrator), `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoToMeeting]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Thank you, Lucian. You look tired. How are you holding up?""]** — Mówca: **Player**
> ""Thank you, Lucian. You look tired. How are you holding up?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: ""It's nothing, sir. I am ready and able as always.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I couldn't have done it without you.""]** — Mówca: **Player**
> ""I couldn't have done it without you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "He slightly bowed his head."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""It's nothing, sir. I am ready and able as always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""Good to know. I need you at your full potential.""*)
  - -> `[12]` (*Player: ""I hope so, Lucian. I can't have my team get worn out at ..."*)
  - -> `[14]` (*Player: ""Are you sure? You can be honest with me.""*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Good to know. I need you at your full potential.""]** — Mówca: **Player**
> ""Good to know. I need you at your full potential.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: ""Of course, sir. I'll be doing my best.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoToMeeting]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I hope so, Lucian. I can't have my team get worn out at a time like this.""]** — Mówca: **Player**
> ""I hope so, Lucian. I can't have my team get worn out at a time like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: ""Of course, sir. I'll be doing my best.""*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoToMeeting]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Are you sure? You can be honest with me.""]** — Mówca: **Player**
> ""Are you sure? You can be honest with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""I'm always honest with you, sir.""*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""I'm always honest with you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""I'll admit, this last year was tough.""*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll be doing my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I'm ready. Let's go.""*)
  - -> `[4]` (*Player: ""Anything you want to say before we go in?""*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Mr. Vice President must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Please sir, don't be like that. You'll get through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gestured to the door."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""I only want to congratulate you again, sir. You wrote hi..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Vice President Vectern must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Mr. Vice President must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""No, sir. Just keep your cool with the cabinet. I believe..."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""No, sir. Just keep your cool with the cabinet. I believe concerns will be raised in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""What are you saying? Should I be expecting something?""*)
  - -> `[90]` (*Player: ""What concerns?""*)
  - -> `[77]` (*Player: ""Alright, let's go in and hear them out.""*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""I can't let them bring you down however they like. We must resist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""We will resist, Lucian. Don't you worry. Nothing will ha..."*)
  - -> `[55]` (*Player: ""Alright. Let's get on with this meeting then.""*)
  - -> `[54]` (*Player: ""I'm afraid we're trapped. Our future is up to the Old Gu..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""No, sir. Everything is under control. But I'm sure the m..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""There's not much to say, sir. We should find a way to re..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""No, sir. Everything is under control. But I'm sure the ministers will raise their concerns at the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""Concerns? It doesn't sound like everything is under cont..."*)
  - -> `[58]` (*Player: ""What concerns?""*)
  - -> `[57]` (*Player: ""Alright, let's go in and hear them out.""*)

### Węzeł `[36]`
Mówca: **Narrator**
> "He gestured at the door with the files he held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: ""I think we should go, sir. Mr. Vice President must have ..."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""There's not much to say, sir. We should find a way to restrain the Supreme Court from impeaching you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""I have already been doing my best to find ways around it..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "He gestured to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""I think we should go, sir. Vice President Vectern must h..."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""I have already been doing my best to find ways around it. Please stay composed and do not worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""I trust you Lucian. Take it easy.""*)
  - -> `[84]` (*Player: ""It doesn't sound like it's going well.""*)
  - -> `[83]` (*Player: ""Do you really think they can impeach me?""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Thank you, Lucian.""]** — Mówca: **Player**
> ""Thank you, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""No, sir. Thank *you* for reforming the constitution.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""It is an emergency... What do they expect?""]** — Mówca: **Player**
> ""It is an emergency... What do they expect?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""You are right, sir.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""]** — Mówca: **Player**
> ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: ""Such radical changes towards the end of our term is not ..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""I'll admit, this last year was tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He gestured to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""I think we should go, sir. Mr. Vice President must have ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""Especially all that work with the Old Guard. But it's no..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "He stared down at the floor for a few seconds and then gestured at the door with the files he held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""I think we should go, sir. Vice President Vectern must h..."*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Especially all that work with the Old Guard. But it's nothing to break me down, sir. Trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He fixed his tie."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""We need their trust. We have to do something to prove our capabilities.""]** — Mówca: **Player**
> ""We need their trust. We have to do something to prove our capabilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: ""Of course, sir. Let's discuss that in the meeting.""*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Alright. Let's go to the meeting and hear these concerns out.""]** — Mówca: **Player**
> ""Alright. Let's go to the meeting and hear these concerns out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[52]`
Mówca: **Narrator**
> "He fixed his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I'm ready. Let's go.""*)
  - -> `[4]` (*Player: ""Anything you want to say before we go in?""*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Some Sollists have also been nagging our ministers about the short-lived state of emergency, which they believe has only worsened the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""We need their trust. We have to do something to prove ou..."*)
  - -> `[79]` (*Player: ""Alright. Let's go to the meeting and hear these concerns..."*)
  - -> `[69]` (*Player: ""They don't even have the guts to face me. If the party d..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'm afraid we're trapped. Our future is up to the Old Guard now.""]** — Mówca: **Player**
> ""I'm afraid we're trapped. Our future is up to the Old Guard now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade), `[82]` (Lucian Galade), `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""Please sir, don't be like that. You'll get through this.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Alright. Let's get on with this meeting then.""]** — Mówca: **Player**
> ""Alright. Let's get on with this meeting then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade), `[82]` (Lucian Galade), `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""We will resist, Lucian. Don't you worry. Nothing will happen to us.""]** — Mówca: **Player**
> ""We will resist, Lucian. Don't you worry. Nothing will happen to us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Lucian Galade), `[82]` (Lucian Galade), `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Alright, let's go in and hear them out.""]** — Mówca: **Player**
> ""Alright, let's go in and hear them out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""What concerns?""]** — Mówca: **Player**
> ""What concerns?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Concerns? It doesn't sound like everything is under control.""]** — Mówca: **Player**
> ""Concerns? It doesn't sound like everything is under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""Thank you for your trust in me. However, this is a very important matter, sir. I cannot take it easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""I can't let them bring you down however they like. We mu..."*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""Such radical changes towards the end of our term is not advised, sir. But we could talk about these in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "He gestured at the door with the files he held."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoToMeeting]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoToMeeting]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""Our failure of the reforms had a huge impact on public opinion. And also on some of the ministers, from the looks of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""The party is quite discontent about the whole situation...."*)

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Of course, sir. Let's discuss that in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "He gestured at the door with the files he held."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""The cabinet has gathered in the White Room, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""The Vice President will be opening the session soon. We ..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I'm ready. Let's go.""]** — Mówca: **Player**
> ""I'm ready. Let's go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Lucian Galade), `[52]` (Narrator), `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""The Vice President will be opening the session soon. We can go in whenever you're ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I'm ready. Let's go.""*)
  - -> `[4]` (*Player: ""Anything you want to say before we go in?""*)
  - -> `[6]` (*Player: ""Thank you, Lucian. You look tired. How are you holding up?""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""]** — Mówca: **Player**
> ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade), `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""Such radical change towards the end of our term is not a..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""The party is quite discontent about the whole situation. They believe your presidency has destroyed the USP's prestige.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""We need their trust. We have to do something to prove ou..."*)
  - -> `[51]` (*Player: ""Alright. Let's go to the meeting and hear these concerns..."*)
  - -> `[42]` (*Player: ""They don't even have the guts to face me. If the party d..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Lucian stood upright, holding a large folder of files under his arm. He bowed in acknowledgement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""You already knew and expected this, I presume. I just wanted to give you a heads up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""It is an emergency... What do they expect?""*)
  - -> `[79]` (*Player: ""Alright. Let's go to the meeting and hear these concerns..."*)
  - -> `[69]` (*Player: ""They don't even have the guts to face me. If the party d..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""We need their trust. We have to do something to prove our capabilities.""]** — Mówca: **Player**
> ""We need their trust. We have to do something to prove our capabilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""Of course, sir. Let's discuss that in the meeting.""*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""No, sir. I don't believe there's anything we didn't expect. However, our failure of the reforms had a huge impact on public opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""The party is quite discontent about the whole situation...."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""I only want to congratulate you again, sir. You wrote history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""Thank you, Lucian.""*)
  - -> `[7]` (*Player: ""I couldn't have done it without you.""*)
  - -> `[81]` (*Player: ""We have done it together.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Alright, let's go in and hear them out.""]** — Mówca: **Player**
> ""Alright, let's go in and hear them out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Alright. Let's go to the meeting and hear these concerns out.""]** — Mówca: **Player**
> ""Alright. Let's go to the meeting and hear these concerns out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Lucian Galade), `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""Such radical change towards the end of our term is not advised, sir. But we could talk about this in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He gestured to the door."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We have done it together.""]** — Mówca: **Player**
> ""We have done it together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "He slightly bowed his head."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""But we can't allow them to bring you down however they like. We must resist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""We will resist, Lucian. Don't you worry. Nothing will ha..."*)
  - -> `[55]` (*Player: ""Alright. Let's get on with this meeting then.""*)
  - -> `[54]` (*Player: ""I'm afraid we're trapped. Our future is up to the Old Gu..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Do you really think they can impeach me?""]** — Mówca: **Player**
> ""Do you really think they can impeach me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""They declared that the state of emergency was unlawful, ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""It doesn't sound like it's going well.""]** — Mówca: **Player**
> ""It doesn't sound like it's going well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: ""The investigation has already been opened against you, s..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I trust you Lucian. Take it easy.""]** — Mówca: **Player**
> ""I trust you Lucian. Take it easy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: ""Thank you for your trust in me. However, this is a very ..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Of course, sir. Let's discuss that in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He gestured to the door."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""The investigation has already been opened against you, sir. But I'm sure nothing will come out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: ""We can't let them bring you down however they like. We m..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""You are right, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He stared down at the floor for a few seconds and then ge..."*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Vice President Vectern must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Jump to: [GoToMeeting]"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""What concerns?""]** — Mówca: **Player**
> ""What concerns?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""Our failure of the reforms had a huge impact on public o..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""What are you saying? Should I be expecting something?""]** — Mówca: **Player**
> ""What are you saying? Should I be expecting something?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""No, sir. I don't believe there's anything we didn't expe..."*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""No, sir. Thank *you* for reforming the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "He gestured to the door."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""They declared that the state of emergency was unlawful, sir. Theoretically, they can do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""But we can't allow them to bring you down however they l..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "He slightly bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "He gestured to the door."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GoToMeeting]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: ""Especially all that lobbying work. But it's nothing to b..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""The party is quite discontent about the administration since we have not pursued any constitutional reforms. They believe your presidency has destroyed the USP's prestige.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""Some Sollists have also been nagging our ministers about..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: ""There are members of the cabinet that are quite disconte..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""The party is quite discontent about the administration s..."*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> ""We can't let them bring you down however they like. We must resist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""We will resist, Lucian. Don't you worry. Nothing will ha..."*)
  - -> `[55]` (*Player: ""Alright. Let's get on with this meeting then.""*)
  - -> `[54]` (*Player: ""I'm afraid we're trapped. Our future is up to the Old Gu..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "He gestured to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: ""I think we should go, sir. Vice President Vectern must h..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""There are members of the cabinet that are quite discontent about the state of emergency, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""You already knew and expected this, I presume. I just wa..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He looked exhausted."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_InternationalAirport", 50);  // ..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_IndustrialZone", 50);  // Update..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_SeaPort", 50);  // Updates token..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "He looked exhausted."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""The cabinet has gathered in the White Room, sir.""*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_AgriculturalZone", 50);  // Upda..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Morna == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "He looked exhausted."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Morna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He looked exhausted."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He looked exhausted."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_InternationalAirport", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_InternationalAirport", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""The cabinet has gathered in the White Room, sir.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_IndustrialZone", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_IndustrialZone", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""The cabinet has gathered in the White Room, sir.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_SeaPort", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_SeaPort", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""The cabinet has gathered in the White Room, sir.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_AgriculturalZone", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_AgriculturalZone", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""The cabinet has gathered in the White Room, sir.""*)
