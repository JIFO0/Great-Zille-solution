# Sordland/TBD - Turn11_War/WIPSnO_RumburgWarOffensiveOne

- **ID konwersacji:** `278`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/278_WIPSnO_RumburgWarOffensiveOne.md`
- **Liczba węzłów dialogowych:** 49
- **Liczba wyborów gracza:** 8

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[42]** Valken Kruger
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Gentlemen!""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Iosef Lancea**: ""Mr. President."" |
| `[13]` | **"*Salute*"** | `[10]` **Narrator**: "Iosef's proud and joyful express..."<br>`[12]` **Narrator**: "While Iosef's proud and joyful e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Iosef Lancea**: ""Of course, Mr. President!"" |
| `[14]` | **""You looked like a man who's just won a lottery ticket, general.""** | `[10]` **Narrator**: "Iosef's proud and joyful express..."<br>`[12]` **Narrator**: "While Iosef's proud and joyful e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Valken Kruger**: ""It seems that the Minister of D..." |
| `[15]` | **""Let's us get straight to business.""** | `[10]` **Narrator**: "Iosef's proud and joyful express..."<br>`[12]` **Narrator**: "While Iosef's proud and joyful e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Iosef Lancea**: ""Of course, Mr. President!"" |
| `[16]` | **""Both of your expressions are sending me mixed signals... I hope that the war effo..."** | `[12]` **Narrator**: "While Iosef's proud and joyful e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Valken Kruger**: ""It seems that the Minister of D..." |
| `[23]` | **""This is great news. Somebody brings the champaign. We need to celebrate this vict..."** | `[22]` **Narrator**: "Briefly describe what happened o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Iosef Lancea**: ""Not yet, Mr. President. The war..."<br>`[26]` **Valken Kruger**: ""Mr. President, the war is not o..." |
| `[24]` | **""Excellent work, generals. I had no doubt in your capabilities to fight for your c..."** | `[22]` **Narrator**: "Briefly describe what happened o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Iosef Lancea**: ""Thank you, Mr. President.""<br>`[36]` **Valken Kruger**: ""Thank you, Mr. President."" |
| `[25]` | **""Good, we are one step closer to ending this war.""** | `[22]` **Narrator**: "Briefly describe what happened o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Iosef Lancea**: ""Right, let us move on with the ..."<br>`[41]` **Valken Kruger**: ""Right, let us move on with the ..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)
  - -> `[2]` (*System / OUTPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""Gentlemen!""*)

### Węzeł `[2]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `input`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `output`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
Mówca: **Iosef Lancea**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Gentlemen!""]** — Mówca: **Player**
> ""Gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Iosef Lancea: ""Mr. President.""*)

### Węzeł `[6]`
Mówca: **Valken Kruger**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Iosef and Valken turned around and gave me a firm salute."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Iosef's proud and joyful expression vibrant across the bu..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Valken Kruger: ""Mr. President!""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Iosef's proud and joyful expression vibrant across the busy war room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "*Salute*"*)
  - -> `[14]` (*Player: ""You looked like a man who's just won a lottery ticket, g..."*)
  - -> `[15]` (*Player: ""Let's us get straight to business.""*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Iosef and Valken turned around and gave me a firm salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "While Iosef's proud and joyful expression vibrant across ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "While Iosef's proud and joyful expression vibrant across the busy war room. General Valken is stern and emotionless as ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "*Salute*"*)
  - -> `[14]` (*Player: ""You looked like a man who's just won a lottery ticket, g..."*)
  - -> `[15]` (*Player: ""Let's us get straight to business.""*)
  - -> `[16]` (*Player: ""Both of your expressions are sending me mixed signals......"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "*Salute*"]** — Mówca: **Player**
> "*Salute*"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Iosef Lancea: ""Of course, Mr. President!""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""You looked like a man who's just won a lottery ticket, general.""]** — Mówca: **Player**
> ""You looked like a man who's just won a lottery ticket, general.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Valken Kruger: ""It seems that the Minister of Defence forgot that we're ..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Let's us get straight to business.""]** — Mówca: **Player**
> ""Let's us get straight to business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator), `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Iosef Lancea: ""Of course, Mr. President!""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Both of your expressions are sending me mixed signals... I hope that the war effort is going well.""]** — Mówca: **Player**
> ""Both of your expressions are sending me mixed signals... I hope that the war effort is going well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Valken Kruger: ""It seems that the Minister of Defence forgot that we're ..."*)

### Węzeł `[17]`
Mówca: **Iosef Lancea**
> ""Of course, Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Iosef Lancea: ""I'm happy to report to you, Mr. President. That our firs..."*)

### Węzeł `[18]`
Mówca: **Iosef Lancea**
> ""I'm happy to report to you, Mr. President. That our first phase of the war was a complete success,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Briefly describe what happened on the battle field based ..."*)

### Węzeł `[19]`
Mówca: **Valken Kruger**
> ""It seems that the Minister of Defence forgot that we're still at war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Iosef Lancea: ""My apologies, but we need to take every wins we can get.""*)

### Węzeł `[20]`
Mówca: **Iosef Lancea**
> ""My apologies, but we need to take every wins we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Iosef Lancea: ""Speaking of which...""*)

### Węzeł `[21]`
Mówca: **Iosef Lancea**
> ""Speaking of which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Iosef Lancea: ""I'm happy to report to you, Mr. President. That our firs..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Briefly describe what happened on the battle field based on the plan chosen.

Fran ?

Made"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""This is great news. Somebody brings the champaign. We ne..."*)
  - -> `[24]` (*Player: ""Excellent work, generals. I had no doubt in your capabil..."*)
  - -> `[25]` (*Player: ""Good, we are one step closer to ending this war.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""This is great news. Somebody brings the champaign. We need to celebrate this victory.""]** — Mówca: **Player**
> ""This is great news. Somebody brings the champaign. We need to celebrate this victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Excellent work, generals. I had no doubt in your capabilities to fight for your country.""]** — Mówca: **Player**
> ""Excellent work, generals. I had no doubt in your capabilities to fight for your country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Good, we are one step closer to ending this war.""]** — Mówca: **Player**
> ""Good, we are one step closer to ending this war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[26]`
Mówca: **Valken Kruger**
> ""Mr. President, the war is not over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Valken spoke with his regular, impassive tone, yet I coul..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Valken spoke with his regular, impassive tone, yet I could feel the tension in the room rising."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Then he glared over to one of the staff that was about to..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Then he glared over to one of the staff that was about to go and grab a bottle of champaign. Freezing him in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Valken Kruger: ""This is not yet the time to celebrate. This is the time ..."*)

### Węzeł `[29]`
Mówca: **Valken Kruger**
> ""This is not yet the time to celebrate. This is the time to focus and achieve absolute victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Iosef Lancea: ""I'm afraid the General is correct, Mr. President.""*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Iosef Lancea: ""Not yet, Mr. President. The war is not over.""*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Valken Kruger: ""Mr. President, the war is not over yet.""*)

### Węzeł `[33]`
Mówca: **Iosef Lancea**
> ""I'm afraid the General is correct, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Iosef Lancea: ""We must not drown ourselves in small victories and forge..."*)

### Węzeł `[34]`
Mówca: **Iosef Lancea**
> ""Not yet, Mr. President. The war is not over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Iosef Lancea: ""We must not drown ourselves in small victories and forge..."*)

### Węzeł `[35]`
Mówca: **Iosef Lancea**
> ""We must not drown ourselves in small victories and forget the final goal of the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[36]`
Mówca: **Valken Kruger**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Iosef Lancea: ""Thank you, Mr. President.""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Valken Kruger: ""Thank you, Mr. President.""*)

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[41]`
Mówca: **Valken Kruger**
> ""Right, let us move on with the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: ""With our success in phase 1 of this campaign.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Iosef Lancea: ""Right, let us move on with the meeting.""*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Valken Kruger: ""Right, let us move on with the meeting.""*)

### Węzeł `[45]`
Mówca: **Iosef Lancea**
> ""Right, let us move on with the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: ""With our success in phase 1 of this campaign.""*)

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> ""With our success in phase 1 of this campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: ""We have captured the cities of Alferdon, Crimsrad and Ra..."*)

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> ""We have captured the cities of Alferdon, Crimsrad and Rachaster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Iosef Lancea: ""They will serve us well as supply and defence point for ..."*)

### Węzeł `[48]`
Mówca: **Iosef Lancea**
> ""They will serve us well as supply and defence point for our front line to encircle and capture Tzarsbourgh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "output"*)
