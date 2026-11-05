# Sordland/Turn07/STATUS QUO

- **ID konwersacji:** `138`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/138_STATUS_QUO.md`
- **Liczba węzłów dialogowych:** 98
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[19]** Walter Tusk

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“President Rayne speaking.”"** | `[5]` **Narrator**: "I entered and picked up the phone." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Walter Tusk**: "“Good afternoon.”" |
| `[9]` | **"“Mr. Tusk. To what do I owe the pleasure?”"** | `[5]` **Narrator**: "I entered and picked up the phone." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Walter Tusk**: "“Good afternoon, President.”" |
| `[10]` | **"“Walter. What do you want?”"** | `[5]` **Narrator**: "I entered and picked up the phone." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Walter Tusk**: "“Good afternoon, President.”" |
| `[28]` | **"“Why am I not surprised?”"** | `[45]` **Walter Tusk**: "“I found some evidence linking h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Walter Tusk**: "“Frankly, I was not surprised ei..." |
| `[31]` | **"“There is no such thing.”"** | `[23]` **Walter Tusk**: "“News about a deal between you a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Walter Tusk**: "“So you say.”" |
| `[32]` | **"“Where did you hear that?”"** | `[23]` **Walter Tusk**: "“News about a deal between you a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Walter Tusk**: "“When one is in business as long..." |
| `[33]` | **"“What kind of a deal?”"** | `[23]` **Walter Tusk**: "“News about a deal between you a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Walter Tusk**: "“Oh, something about controlling..." |
| `[34]` | **"“Very well. I will see what I can do.”"** | `[53]` **Walter Tusk**: "“You will bring a known criminal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Walter Tusk**: "“Good man.”" |
| `[36]` | **"“No promises.”"** | `[53]` **Walter Tusk**: "“You will bring a known criminal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Walter Tusk**: "“All I ask is for you to think a..." |
| `[57]` | **"“I do. But why are you helping me?”"** | `[51]` **Walter Tusk**: "“I hope you can appreciate that.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Walter Tusk**: ""Think about it as an investment.”" |
| `[58]` | **"“Thank you, Walter. I'm glad I can depend on you.""** | `[51]` **Walter Tusk**: "“I hope you can appreciate that.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Walter Tusk**: "“Anytime.”" |
| `[59]` | **"“If you ever use this against me...”"** | `[51]` **Walter Tusk**: "“I hope you can appreciate that.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Walter Tusk**: "“I wouldn't make threats if I we..." |
| `[62]` | **"“Is the information about the cartel ties verified?”"** | `[68]` **Walter Tusk**: "“That's not too much to ask, rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Walter Tusk**: "“I wouldn't tell you if that was..." |
| `[63]` | **"“No promises.”"** | `[68]` **Walter Tusk**: "“That's not too much to ask, rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Walter Tusk**: "“If you don't do it, you will su..." |
| `[64]` | **"“Very well. Deal.”"** | `[68]` **Walter Tusk**: "“That's not too much to ask, rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Walter Tusk**: "“Good man.”" |
| `[66]` | **"“Are you certain? That is a big accusation.”"** | `[45]` **Walter Tusk**: "“I found some evidence linking h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Walter Tusk**: "“I wouldn't call you if I wasn't.”" |
| `[75]` | **"“I don't believe it. You are just trying to undermine him.”"** | `[45]` **Walter Tusk**: "“I found some evidence linking h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Walter Tusk**: "“I'm afraid the evidence is clear.”" |
| `[78]` | **"“I will decide after I see the evidence.”"** | `[53]` **Walter Tusk**: "“You will bring a known criminal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Walter Tusk**: "“Fair enough.”" |
| `[80]` | **"“What do you want?”"** | `[77]` **Walter Tusk**: "“If you do what I say.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Walter Tusk**: "“Let me tell you what I want fir..." |
| `[81]` | **"“I won't give in to your false accusations.”"** | `[77]` **Walter Tusk**: "“If you do what I say.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Walter Tusk**: "“Let me tell you what I want fir..." |
| `[82]` | **"“You dare threaten me?”"** | `[77]` **Walter Tusk**: "“If you do what I say.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Walter Tusk**: "“Yes, President. I do.”" |
| `[88]` | **"“This is your lucky day. I've already ordered an investigation into HOS.”"** | `[53]` **Walter Tusk**: "“You will bring a known criminal..." | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true` | *Brak zmian stanu* | `[92]` **Walter Tusk**: "“How uncharacteristically wise o..." |
| `[96]` | **"“This is your lucky day. I've already ordered an investigation into HOS.”"** | `[68]` **Walter Tusk**: "“That's not too much to ask, rig..." | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true` | *Brak zmian stanu* | `[97]` **Walter Tusk**: "“How uncharacteristically wise o..." |

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
  - -> `[3]` (*Narrator: "Livia intercepted me in front of my office and informed m..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Livia intercepted me in front of my office and informed me that I had a call from Walter Tusk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I entered and picked up the phone."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I entered and picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Walter. What do you want?”"*)
  - -> `[9]` (*Player: "“Mr. Tusk. To what do I owe the pleasure?”"*)
  - -> `[8]` (*Player: "“President Rayne speaking.”"*)

### Węzeł `[6]`
Mówca: **Walter Tusk**
> "“Anytime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Walter Tusk: "“Now, nothing in this life is free.”"*)

### Węzeł `[7]`
Mówca: **Walter Tusk**
> "“Good afternoon, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Walter Tusk: "“Not the nicest way to pick up the phone.”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“President Rayne speaking.”"]** — Mówca: **Player**
> "“President Rayne speaking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Walter Tusk: "“Good afternoon.”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Mr. Tusk. To what do I owe the pleasure?”"]** — Mówca: **Player**
> "“Mr. Tusk. To what do I owe the pleasure?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Walter Tusk: "“Good afternoon, President.”"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Walter. What do you want?”"]** — Mówca: **Player**
> "“Walter. What do you want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Walter Tusk: "“Good afternoon, President.”"*)

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“If you don't do it, you will suffer the consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[12]`
Mówca: **Walter Tusk**
> "“If you want to keep being one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The line dropped dead."*)

### Węzeł `[13]`
Mówca: **Walter Tusk**
> "“Here is what this will cost you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Walter Tusk: "“That damn boy. Marcel Koronti.”"*)

### Węzeł `[14]`
Mówca: **Walter Tusk**
> "“Not the nicest way to pick up the phone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Walter Tusk: "“I heard some disturbing news.”"*)

### Węzeł `[15]`
Mówca: **Walter Tusk**
> "“Have a good afternoon and think about what I said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The line dropped dead."*)

### Węzeł `[16]`
Mówca: **Walter Tusk**
> "“Heed my words, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Walter Tusk: "“He is a dangerous man.”"*)

### Węzeł `[17]`
Mówca: **Walter Tusk**
> "“Good afternoon, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Walter Tusk: "“I heard some disturbing news.”"*)

### Węzeł `[18]`
Mówca: **Walter Tusk**
> "“All I ask is for you to think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“Good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Walter Tusk: "“I heard some disturbing news.”"*)

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“I heard some disturbing news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“That's not too much to ask, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Walter Tusk: "“You will bring a known criminal to justice.”"*)

### Węzeł `[22]`
Mówca: **Walter Tusk**
> "“Frankly, I was not surprised either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Walter Tusk: "“What I want is simple.”"*)

### Węzeł `[23]`
Mówca: **Walter Tusk**
> "“News about a deal between you and Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“What kind of a deal?”"*)
  - -> `[32]` (*Player: "“Where did you hear that?”"*)
  - -> `[31]` (*Player: "“There is no such thing.”"*)

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“Listen, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Walter Tusk: "“I did not call you to threaten you.”"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Walter Tusk: "“News about a deal between you and Marcel Koronti.”"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Walter Tusk: "“That damn boy. Marcel Koronti.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Why am I not surprised?”"]** — Mówca: **Player**
> "“Why am I not surprised?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Walter Tusk: "“Frankly, I was not surprised either.”"*)

### Węzeł `[29]`
Mówca: **Walter Tusk**
> "“I want you to start an investigation into Heart of Sordland. That's all I ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Walter Tusk: "“That's not too much to ask, is it?""*)

### Węzeł `[30]`
Mówca: **Walter Tusk**
> "“Oh, something about controlling the media.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“There is no such thing.”"]** — Mówca: **Player**
> "“There is no such thing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Walter Tusk: "“So you say.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Where did you hear that?”"]** — Mówca: **Player**
> "“Where did you hear that?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Walter Tusk: "“When one is in business as long as I am, one hears things.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“What kind of a deal?”"]** — Mówca: **Player**
> "“What kind of a deal?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Walter Tusk: "“Oh, something about controlling the media.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Very well. I will see what I can do.”"]** — Mówca: **Player**
> "“Very well. I will see what I can do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Walter Tusk: "“Good man.”"*)

### Węzeł `[35]`
Mówca: **Walter Tusk**
> "“Good man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“No promises.”"]** — Mówca: **Player**
> "“No promises.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Walter Tusk: "“All I ask is for you to think about it.”"*)

### Węzeł `[37]`
Mówca: **Walter Tusk**
> "“I will give all the information I have to the officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Walter Tusk: "“I want you to start an investigation into Heart of Sordl..."*)

### Węzeł `[38]`
Mówca: **Walter Tusk**
> "“When one is in business as long as I am, one hears things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[39]`
Mówca: **Walter Tusk**
> "“What I want is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Walter Tusk: "“I will give all the information I have to the officials.”"*)

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“So you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[41]`
Mówca: **Walter Tusk**
> "“Heed my words, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Walter Tusk: "“If you want to keep being one.”"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Walter Tusk: "“Listen, President.”"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Walter Tusk: "“Listen to me carefully now, Rayne.”"*)

### Węzeł `[45]`
Mówca: **Walter Tusk**
> "“I found some evidence linking him to Koranelli cartel. A powerful crime syndicate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“Are you certain? That is a big accusation.”"*)
  - -> `[75]` (*Player: "“I don't believe it. You are just trying to undermine him.”"*)
  - -> `[28]` (*Player: "“Why am I not surprised?”"*)

### Węzeł `[46]`
Mówca: **Walter Tusk**
> "“That damn boy. Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Walter Tusk: "“I found some evidence linking him to Koranelli cartel. A..."*)

### Węzeł `[47]`
Mówca: **Walter Tusk**
> "“I wouldn't tell you if that wasn't the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[48]`
Mówca: **Walter Tusk**
> "“I did not call you to threaten you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Walter Tusk: "“I am calling you as a friend.”"*)

### Węzeł `[49]`
Mówca: **Walter Tusk**
> "“I am calling you as a friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Walter Tusk: "“I suppressed those rumors for you.”"*)

### Węzeł `[50]`
Mówca: **Walter Tusk**
> "“I suppressed those rumors for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Walter Tusk: "“I hope you can appreciate that.”"*)

### Węzeł `[51]`
Mówca: **Walter Tusk**
> "“I hope you can appreciate that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“I do. But why are you helping me?”"*)
  - -> `[58]` (*Player: "“Thank you, Walter. I'm glad I can depend on you.""*)
  - -> `[59]` (*Player: "“If you ever use this against me...”"*)

### Węzeł `[52]`
Mówca: **Walter Tusk**
> "“Listen to me carefully now, Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Walter Tusk: "“I suppressed those rumors for you.”"*)

### Węzeł `[53]`
Mówca: **Walter Tusk**
> "“You will bring a known criminal to justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“I will decide after I see the evidence.”"*)
  - -> `[36]` (*Player: "“No promises.”"*)
  - -> `[34]` (*Player: "“Very well. I will see what I can do.”"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“Good man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[55]`
Mówca: **Walter Tusk**
> "“He is a dangerous man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Walter Tusk: "“I have to attend to my business now.”"*)

### Węzeł `[56]`
Mówca: **Walter Tusk**
> "“I want him out of the equation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Walter Tusk: "“I found some evidence linking him to the Koranelli carte..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“I do. But why are you helping me?”"]** — Mówca: **Player**
> "“I do. But why are you helping me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Walter Tusk: ""Think about it as an investment.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Thank you, Walter. I'm glad I can depend on you.""]** — Mówca: **Player**
> "“Thank you, Walter. I'm glad I can depend on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Walter Tusk: "“Anytime.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“If you ever use this against me...”"]** — Mówca: **Player**
> "“If you ever use this against me...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“I wouldn't make threats if I were you.”"*)

### Węzeł `[60]`
Mówca: **Walter Tusk**
> ""Think about it as an investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Walter Tusk: "“Now, nothing in this life is free.”"*)

### Węzeł `[61]`
Mówca: **Walter Tusk**
> "“That damn boy. Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Walter Tusk: "“I want him out of the equation.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Is the information about the cartel ties verified?”"]** — Mówca: **Player**
> "“Is the information about the cartel ties verified?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Walter Tusk: "“I wouldn't tell you if that wasn't the case.”"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“No promises.”"]** — Mówca: **Player**
> "“No promises.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Walter Tusk: "“If you don't do it, you will suffer the consequences.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Very well. Deal.”"]** — Mówca: **Player**
> "“Very well. Deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Walter Tusk: "“Good man.”"*)

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“I wouldn't make threats if I were you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Walter Tusk: "“Now, nothing in this life is free.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Are you certain? That is a big accusation.”"]** — Mówca: **Player**
> "“Are you certain? That is a big accusation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Walter Tusk: "“I wouldn't call you if I wasn't.”"*)

### Węzeł `[67]`
Mówca: **Walter Tusk**
> "“I have to attend to my business now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Walter Tusk: "“Have a good afternoon and think about what I said.”"*)

### Węzeł `[68]`
Mówca: **Walter Tusk**
> "“That's not too much to ask, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Is the information about the cartel ties verified?”"*)
  - -> `[63]` (*Player: "“No promises.”"*)
  - -> `[64]` (*Player: "“Very well. Deal.”"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“Now, nothing in this life is free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Walter Tusk: "“Here is what this will cost you.”"*)

### Węzeł `[70]`
Mówca: **Walter Tusk**
> "“Let me tell you what I want first and I will let you decide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Walter Tusk: "“That damn boy. Marcel Koronti.”"*)

### Węzeł `[71]`
Mówca: **Walter Tusk**
> "“Fair enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[72]`
Mówca: **Walter Tusk**
> "“I suppressed those rumors for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Walter Tusk: "“For now.”"*)

### Węzeł `[73]`
Mówca: **Walter Tusk**
> "“For now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Walter Tusk: "“They will stay that way...”"*)

### Węzeł `[74]`
Mówca: **Walter Tusk**
> "“I want you to start an investigation into Heart of Sordland. That's all I ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Walter Tusk: "“That's not too much to ask, right?""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I don't believe it. You are just trying to undermine him.”"]** — Mówca: **Player**
> "“I don't believe it. You are just trying to undermine him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Walter Tusk: "“I'm afraid the evidence is clear.”"*)

### Węzeł `[76]`
Mówca: **Walter Tusk**
> "“They will stay that way...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Walter Tusk: "“If you do what I say.”"*)

### Węzeł `[77]`
Mówca: **Walter Tusk**
> "“If you do what I say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“You dare threaten me?”"*)
  - -> `[81]` (*Player: "“I won't give in to your false accusations.”"*)
  - -> `[80]` (*Player: "“What do you want?”"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I will decide after I see the evidence.”"]** — Mówca: **Player**
> "“I will decide after I see the evidence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Walter Tusk: "“Fair enough.”"*)

### Węzeł `[79]`
Mówca: **Walter Tusk**
> "“I will feed the information to the officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Walter Tusk: "“I want you to start an investigation into Heart of Sordl..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“What do you want?”"]** — Mówca: **Player**
> "“What do you want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Walter Tusk: "“Let me tell you what I want first and I will let you dec..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“I won't give in to your false accusations.”"]** — Mówca: **Player**
> "“I won't give in to your false accusations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Walter Tusk: "“Let me tell you what I want first and I will let you dec..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“You dare threaten me?”"]** — Mówca: **Player**
> "“You dare threaten me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Walter Tusk: "“Yes, President. I do.”"*)

### Węzeł `[83]`
Mówca: **Walter Tusk**
> "“What I want from you is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Walter Tusk: "“I will feed the information to the officials.”"*)

### Węzeł `[84]`
Mówca: **Walter Tusk**
> "“I'm afraid the evidence is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Walter Tusk: "“What I want is simple.”"*)

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“I found some evidence linking him to the Koranelli cartel. A powerful crime syndicate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Walter Tusk: "“What I want from you is simple.”"*)

### Węzeł `[86]`
Mówca: **Walter Tusk**
> "“Yes, President. I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Walter Tusk: "“Let me tell you what I want first and I will let you dec..."*)

### Węzeł `[87]`
Mówca: **Walter Tusk**
> "“I wouldn't call you if I wasn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Walter Tusk: "“What I want is simple.”"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“This is your lucky day. I've already ordered an investigation into HOS.”"]** — Mówca: **Player**
> "“This is your lucky day. I've already ordered an investigation into HOS.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Walter Tusk: "“How uncharacteristically wise of you.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“This is your lucky day. I've already ordered an investig..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
Mówca: **Walter Tusk**
> "“How uncharacteristically wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: "“Heed my words, President.”"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“This is your lucky day. I've already ordered an investig..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WYBÓR GRACZA: "“This is your lucky day. I've already ordered an investigation into HOS.”"]** — Mówca: **Player**
> "“This is your lucky day. I've already ordered an investigation into HOS.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Walter Tusk: "“How uncharacteristically wise of you.""*)

### Węzeł `[97]`
Mówca: **Walter Tusk**
> "“How uncharacteristically wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Walter Tusk: "“Heed my words, President.”"*)
