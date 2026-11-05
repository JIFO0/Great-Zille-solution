# Sordland/Turn07/HOS AND BERGIA STEEL MINORITY OR MAJORITY NATIONALISED

- **ID konwersacji:** `134`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/134_HOS_AND_BERGIA_STEEL_MINORITY_OR_MAJORITY_NATIONALISED.md`
- **Liczba węzłów dialogowych:** 121
- **Liczba wyborów gracza:** 22

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[19]** Walter Tusk
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Media_SordlandToday_Bias`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Media_SordlandToday_Bias`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“Yes, I spared you as much as I could. Don't forget that.”"** | `[6]` **Marcel Koronti**: "“But as you could've done far mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Marcel Koronti**: "“That doesn't necessarily mean I..." |
| `[8]` | **"“No hard feelings, Marcel.”"** | `[6]` **Marcel Koronti**: "“But as you could've done far mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Marcel Koronti**: "“In our line of business, there ..." |
| `[9]` | **"“Thanks for being cooperative.”"** | `[6]` **Marcel Koronti**: "“But as you could've done far mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Marcel Koronti**: "“If we're quite finished, I will..." |
| `[16]` | **"“Give me back my pen.”"** | `[65]` **Marcel Koronti**: "“Now what?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "Marcel halfheartedly leaned acro..." |
| `[27]` | **"“I hope you can understand where this is coming from.”"** | `[98]` **Narrator**: "Walter scrutinized him very clos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Marcel Koronti**: "“No, I don't.”" |
| `[29]` | **"“I am sorry it had to come to this.”"** | `[110]` **Marcel Koronti**: "“Well, it's rare a president doe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Marcel Koronti**: "“No. I am sorry about what will ..." |
| `[31]` | **"“Enough. You will obey me regardless.”"** | `[110]` **Marcel Koronti**: "“Well, it's rare a president doe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Walter Tusk**: "“Now you are starting to show yo..." |
| `[32]` | **"“Unfortunately, these sacrifices are necessary.”"** | `[110]` **Marcel Koronti**: "“Well, it's rare a president doe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Marcel Koronti**: "“For what? Ending the recession?..." |
| `[50]` | **"“And look at where we are now.”"** | `[23]` **Walter Tusk**: "“I should've destroyed you when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Walter Tusk**: "“Screw you.”" |
| `[55]` | **"“Good riddance.”"** | `[22]` **Walter Tusk**: "“I couldn't be more wrong.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Walter Tusk**: "“Screw you.”" |
| `[57]` | **"“We *had* a deal.”"** | `[98]` **Narrator**: "Walter scrutinized him very clos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Marcel Koronti**: "“So you betrayed me. I see.”" |
| `[61]` | **"“Lucian.”"** | `[69]` **Narrator**: "Marcel halfheartedly leaned acro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "He grabbed the pen from Marcel's..." |
| `[64]` | **"“Get up, come closer and give me back my pen.”"** | `[69]` **Narrator**: "Marcel halfheartedly leaned acro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "Marcel got up from his seat and ..." |
| `[66]` | **"“Keep the pen. A gift from me and a reminder.”"** | `[65]` **Marcel Koronti**: "“Now what?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Marcel Koronti**: "“Rest assured. I will never forg..." |
| `[70]` | **"“No.”"** | `[78]` **Walter Tusk**: "“There is no way out of this, is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "Walter sighed." |
| `[73]` | **"“Sign it or else.”"** | `[78]` **Walter Tusk**: "“There is no way out of this, is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "Walter sighed." |
| `[74]` | **"“I did my best to prevent this.”"** | `[22]` **Walter Tusk**: "“I couldn't be more wrong.”"<br>`[23]` **Walter Tusk**: "“I should've destroyed you when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Walter Tusk**: "“Not enough, President. Not enou..." |
| `[79]` | **"Hand him your own pen."** | `[80]` **Walter Tusk**: "“Neither do I.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Walter Tusk**: "“There is no way out of this, is..." |
| `[82]` | **"“I played you like a fiddle.”"** | `[22]` **Walter Tusk**: "“I couldn't be more wrong.”"<br>`[23]` **Walter Tusk**: "“I should've destroyed you when ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Walter Tusk**: "“Screw you.”" |
| `[93]` | **"“Wake up. I just used you, Marcel.”"** | `[98]` **Narrator**: "Walter scrutinized him very clos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Marcel Koronti**: "“So you betrayed me. I see.”" |
| `[112]` | **"“Yes, that's why I only took a minority share.""** | `[98]` **Narrator**: "Walter scrutinized him very clos..." | `Variable["BaseGame.HeartOfSordland_Nationalization"] < 2` | *Brak zmian stanu* | `[116]` **Marcel Koronti**: "“So you stabbed me in the back b..." |
| `[118]` | **"“I don't need your deal now that I have your company.""** | `[98]` **Narrator**: "Walter scrutinized him very clos..." | `(Variable["BaseGame.HeartOfSordland_Nationalization"] < 2) == false` | *Brak zmian stanu* | `[119]` **Marcel Koronti**: "“You coward. You'll pay for this."" |

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
  - -> `[109]` (*Narrator: "The two oligarchs looked at each other and then at me."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[3]`
Mówca: **Marcel Koronti**
> "“You're not the boss of me. Or of anyone, come to think of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Marcel and Walter angrily packed their belongings and lef..."*)

### Węzeł `[4]`
Mówca: **Marcel Koronti**
> "“No. I am not happy at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Marcel Koronti: "“But as you could've done far more damage, let's say that..."*)

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“If we're quite finished, I will take my leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Marcel Koronti: "“Come on, Walter. Let's go.”"*)

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“But as you could've done far more damage, let's say that I am ready to put this unfortunate decision behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“Thanks for being cooperative.”"*)
  - -> `[8]` (*Player: "“No hard feelings, Marcel.”"*)
  - -> `[7]` (*Player: "“Yes, I spared you as much as I could. Don't forget that.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Yes, I spared you as much as I could. Don't forget that.”"]** — Mówca: **Player**
> "“Yes, I spared you as much as I could. Don't forget that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Marcel Koronti: "“That doesn't necessarily mean I'll spare you when the ti..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“No hard feelings, Marcel.”"]** — Mówca: **Player**
> "“No hard feelings, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Marcel Koronti: "“In our line of business, there is no place for feelings.”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Thanks for being cooperative.”"]** — Mówca: **Player**
> "“Thanks for being cooperative.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“If we're quite finished, I will take my leave.""*)

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“In our line of business, there is no place for feelings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“If we're quite finished, I will take my leave.""*)

### Węzeł `[11]`
Mówca: **Marcel Koronti**
> "“Just like your presidency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias = false"*)

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“That doesn't necessarily mean I'll spare you when the time comes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Marcel Koronti: "“If we're quite finished, I will take my leave.""*)

### Węzeł `[13]`
Mówca: **Marcel Koronti**
> ""Our deal is over, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Marcel Koronti: "“Just like your presidency.”"*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Marcel's shoulders slumped in defeat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Marcel Koronti: "“I--”"*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Gentlemen, don't make this more difficult.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: "“Sign the papers.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Give me back my pen.”"]** — Mówca: **Player**
> "“Give me back my pen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Marcel halfheartedly leaned across the table with the pen..."*)

### Węzeł `[17]`
Mówca: **Walter Tusk**
> "“Shame on me for actually believing we could work together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Walter Tusk: "“I couldn't be more wrong.”"*)

### Węzeł `[18]`
Mówca: **Walter Tusk**
> "“However, I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Walter Tusk: "“This could've turned out much worse for me *and* you if ..."*)

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“This could've turned out much worse for me *and* you if not for our...friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Walter Tusk: "“I've signed the damn paperwork. We're done here.”"*)

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“I've signed the damn paperwork. We're done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Walter Tusk: "“Come on, Marcel. Let's go.”"*)

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“Your time will come too, Rayne. Believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Walter Tusk: "“Come on, Marcel. Let's go.”"*)

### Węzeł `[22]`
Mówca: **Walter Tusk**
> "“I couldn't be more wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“I did my best to prevent this.”"*)
  - -> `[55]` (*Player: "“Good riddance.”"*)
  - -> `[82]` (*Player: "“I played you like a fiddle.”"*)

### Węzeł `[23]`
Mówca: **Walter Tusk**
> "“I should've destroyed you when I had the chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“I did my best to prevent this.”"*)
  - -> `[82]` (*Player: "“I played you like a fiddle.”"*)
  - -> `[50]` (*Player: "“And look at where we are now.”"*)

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“Come on, Marcel. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Walter Tusk: "“We have work to do.”"*)

### Węzeł `[25]`
Mówca: **Walter Tusk**
> "“We have work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Marcel Koronti: "“You might have the upper hand for now.”"*)

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“I knew you would end up destroying everything Sordland stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Walter Tusk: "“I should've destroyed you when I had the chance.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“I hope you can understand where this is coming from.”"]** — Mówca: **Player**
> "“I hope you can understand where this is coming from.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Marcel Koronti: "“No, I don't.”"*)

### Węzeł `[28]`
Mówca: **Marcel Koronti**
> "“Come on, Walter. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Marcel Koronti: "“We have work to do.”"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I am sorry it had to come to this.”"]** — Mówca: **Player**
> "“I am sorry it had to come to this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Marcel Koronti: "“No. I am sorry about what will happen next.”"*)

### Węzeł `[30]`
Mówca: **Marcel Koronti**
> "“We have work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Walter Tusk: "“You might have the upper hand for now.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Enough. You will obey me regardless.”"]** — Mówca: **Player**
> "“Enough. You will obey me regardless.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Walter Tusk: "“Now you are starting to show your true face.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Unfortunately, these sacrifices are necessary.”"]** — Mówca: **Player**
> "“Unfortunately, these sacrifices are necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Marcel Koronti: "“For what? Ending the recession? We both know that's not ..."*)

### Węzeł `[33]`
Mówca: **Walter Tusk**
> "“You might have the upper hand for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Walter Tusk: "“But don't go ordering me around, boy.”"*)

### Węzeł `[34]`
Mówca: **Walter Tusk**
> "“But don't go ordering me around, boy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Walter Tusk: "“Otherwise, I will make you regret it.”"*)

### Węzeł `[35]`
Mówca: **Walter Tusk**
> "“Otherwise, I will make you regret it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Marcel Koronti: "“Hah.”"*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Sign the papers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Marcel's shoulders slumped in defeat."*)

### Węzeł `[37]`
Mówca: **Walter Tusk**
> "“Not enough, President. Not enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Gentlemen, don't make this more difficult.”"*)

### Węzeł `[38]`
Mówca: **Walter Tusk**
> "“I knew this would happen. I should've trusted my gut feeling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Walter Tusk: "“Shame on me for actually believing we could work together.”"*)

### Węzeł `[39]`
Mówca: **Marcel Koronti**
> "“Otherwise, I will make you regret it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Walter Tusk: "“Hah.”"*)

### Węzeł `[40]`
Mówca: **Marcel Koronti**
> "“You might have the upper hand for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Marcel Koronti: "“But don't go ordering me around, old man.”"*)

### Węzeł `[41]`
Mówca: **Marcel Koronti**
> "“But don't go ordering me around, old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Marcel Koronti: "“Otherwise, I will make you regret it.”"*)

### Węzeł `[42]`
Mówca: **Marcel Koronti**
> "“No. I am sorry about what will happen next.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Walter Tusk: "“This is nonsense.”"*)

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“For what? Ending the recession? We both know that's not the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Walter Tusk: "“This is nonsense.”"*)

### Węzeł `[44]`
Mówca: **Walter Tusk**
> "“Now you are starting to show your true face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Walter Tusk: "“This is nonsense.”"*)

### Węzeł `[45]`
Mówca: **Walter Tusk**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Walter Tusk: "“You're not half the man your father was. Remember that.""*)

### Węzeł `[46]`
Mówca: **Walter Tusk**
> "“I had a gut feeling, President. I knew you were not to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Walter Tusk: "“I knew you would end up destroying everything Sordland s..."*)

### Węzeł `[47]`
Mówca: **Walter Tusk**
> "“You're not half the man your father was. Remember that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Marcel and Walter angrily packed their belongings and lef..."*)

### Węzeł `[48]`
Mówca: **Marcel Koronti**
> "“Rest assured. I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization < BaseGame.Bergi..."*)

### Węzeł `[49]`
Mówca: **Marcel Koronti**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Marcel Koronti: "“You're not the boss of me. Or of anyone, come to think o..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“And look at where we are now.”"]** — Mówca: **Player**
> "“And look at where we are now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[51]`
Mówca: **Walter Tusk**
> "“This is nonsense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Walter Tusk: "“I beg you to rethink this decision.”"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Marcel and Walter angrily packed their belongings and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[53]`
Mówca: **Walter Tusk**
> "“Screw you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Gentlemen, don't make this more difficult.”"*)

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“I beg you to rethink this decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lucian placed the agreement papers in front of them."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Good riddance.”"]** — Mówca: **Player**
> "“Good riddance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "He grabbed the pen from Marcel's hands and gave it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization < BaseGame.Bergi..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We *had* a deal.”"]** — Mówca: **Player**
> "“We *had* a deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Marcel Koronti: "“So you betrayed me. I see.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization < BaseGame.BergiaSteel_Nationalization`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization < BaseGame.Bergi..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization < BaseGame.Ber..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization < BaseGame.BergiaSteel_Nationalization`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] < Variable["BaseGame.BergiaSteel_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization < BaseGame.BergiaSteel_Nationalization)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] < Variable["BaseGame.BergiaSteel_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Lucian.”"]** — Mówca: **Player**
> "“Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He grabbed the pen from Marcel's hands and gave it to me."*)

### Węzeł `[62]`
Mówca: **Walter Tusk**
> "“Fine. I will sign it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "He signed the documents in a painfully slow manner, then handed my pen to Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "Marcel signed the papers."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Get up, come closer and give me back my pen.”"]** — Mówca: **Player**
> "“Get up, come closer and give me back my pen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Marcel got up from his seat and gave me the pen."*)

### Węzeł `[65]`
Mówca: **Marcel Koronti**
> "“Now what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“Keep the pen. A gift from me and a reminder.”"*)
  - -> `[16]` (*Player: "“Give me back my pen.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Keep the pen. A gift from me and a reminder.”"]** — Mówca: **Player**
> "“Keep the pen. A gift from me and a reminder.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Marcel Koronti: "“Rest assured. I will never forget what you have done to ..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Mr. Koronti. Mr. Tusk. Here are the agreements that pertain to the nationalization and the transfer of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "He pointed to various sections and pages on the stack of ..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Marcel got up from his seat and gave me the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization < BaseGame.Bergi..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Marcel halfheartedly leaned across the table with the pen in his hand. It was still too far away for me to reach it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“Lucian.”"*)
  - -> `[64]` (*Player: "“Get up, come closer and give me back my pen.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“No.”"]** — Mówca: **Player**
> "“No.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Walter sighed."*)

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Marcel Koronti: "“I don't have a pen.”"*)

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“Mr. President. I am not happy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Marcel Koronti: "“No. I am not happy at all.”"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Sign it or else.”"]** — Mówca: **Player**
> "“Sign it or else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Walter sighed."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I did my best to prevent this.”"]** — Mówca: **Player**
> "“I did my best to prevent this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Walter Tusk), `[23]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Walter Tusk: "“Not enough, President. Not enough.”"*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Walter sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Walter Tusk: "“Fine. I will sign it.”"*)

### Węzeł `[76]`
Mówca: **Narrator**
> "Marcel signed the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Marcel Koronti: "“Now what?”"*)

### Węzeł `[77]`
Mówca: **Marcel Koronti**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Walter Tusk: "“Neither do I.”"*)

### Węzeł `[78]`
Mówca: **Walter Tusk**
> "“There is no way out of this, is there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“No.”"*)
  - -> `[73]` (*Player: "“Sign it or else.”"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "Hand him your own pen."]** — Mówca: **Player_Italic**
> "I handed him my own pen with the Presidential sigil on it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Walter Tusk: "“There is no way out of this, is there?”"*)

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“Neither do I.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Italic: "Hand him your own pen."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Lucian placed the agreement papers in front of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“Mr. Koronti. Mr. Tusk. Here are the agreements that pert..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“I played you like a fiddle.”"]** — Mówca: **Player**
> "“I played you like a fiddle.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Walter Tusk), `[23]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Walter Tusk: "“Screw you.”"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Walter Tusk: "“You are putting me in a difficult position.”"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Walter Tusk: "“I will never forget what you have done to me.”"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Marcel Koronti: ""Our deal is over, Mr. President.""*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Marcel Koronti: "“Mr. President. I am not happy.”"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Walter Tusk: "“I knew this would happen. I should've trusted my gut fee..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Walter Tusk: "“I had a gut feeling, President. I knew you were not to b..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "He pointed to various sections and pages on the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Wake up. I just used you, Marcel.”"]** — Mówca: **Player**
> "“Wake up. I just used you, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Marcel Koronti: "“So you betrayed me. I see.”"*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Marcel skimmed through the papers, then looked at Walter ..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Marcel skimmed through the papers, then looked at Walter in dismay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "He turned to me again."*)

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“No, I don't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "He turned to me again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Walter scrutinized him very closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization < 2"*)
  - -> `[57]` (*Player: "“We *had* a deal.”"*)
  - -> `[93]` (*Player: "“Wake up. I just used you, Marcel.”"*)
  - -> `[27]` (*Player: "“I hope you can understand where this is coming from.”"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Marcel Koronti: "“We had a deal, Rayne!""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Marcel Koronti: "“This is insanity!”"*)

### Węzeł `[102]`
Mówca: **Walter Tusk**
> "“I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Walter Tusk: "“Your time will come too, Rayne. Believe me.”"*)

### Węzeł `[103]`
Mówca: **Walter Tusk**
> "“You are putting me in a difficult position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Walter Tusk: "“However, I understand.”"*)

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“This is insanity!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[105]`
Mówca: **Marcel Koronti**
> "“We had a deal, Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Walter scrutinized him very closely."*)

### Węzeł `[106]`
Mówca: **Marcel Koronti**
> "“So you betrayed me. I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[107]`
Mówca: **Walter Tusk**
> "“This might be one of those rare moments where we are aligned, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Marcel Koronti: "“Well, it's rare a president does something this colossal..."*)

### Węzeł `[108]`
Mówca: **Marcel Koronti**
> "“To put it mildly. You can't just take away our shares in our own companies and expect no repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Walter Tusk: "“This might be one of those rare moments where we are ali..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "The two oligarchs looked at each other and then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Walter Tusk: "“You are making a terrible mistake.”"*)

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“Well, it's rare a president does something this colossally stupid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Enough. You will obey me regardless.”"*)
  - -> `[32]` (*Player: "“Unfortunately, these sacrifices are necessary.”"*)
  - -> `[29]` (*Player: "“I am sorry it had to come to this.”"*)

### Węzeł `[111]`
Mówca: **Walter Tusk**
> "“You are making a terrible mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Marcel Koronti: "“To put it mildly. You can't just take away our shares in..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Yes, that's why I only took a minority share.""]** — Mówca: **Player**
> "“Yes, that's why I only took a minority share.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.HeartOfSordland_Nationalization"] < 2`
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Marcel Koronti: "“So you stabbed me in the back but failed to stick the kn..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization < 2"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization < 2)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“Yes, that's why I only took a minority share.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“I don't need your deal now that I have your company.""*)

### Węzeł `[116]`
Mówca: **Marcel Koronti**
> "“So you stabbed me in the back but failed to stick the knife in all the way. You're stupider than I thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Marcel Koronti: "“Come on, Walter. Let's go.”"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“I don't need your deal now that I have your company.""]** — Mówca: **Player**
> "“I don't need your deal now that I have your company.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] < 2) == false`
- **Kontekst wejściowy (poprzednik):** `[98]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Marcel Koronti: "“You coward. You'll pay for this.""*)

### Węzeł `[119]`
Mówca: **Marcel Koronti**
> "“You coward. You'll pay for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "He signed the documents in a painfully slow manner, then ..."*)
