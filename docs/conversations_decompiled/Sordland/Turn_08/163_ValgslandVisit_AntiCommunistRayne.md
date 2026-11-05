# Sordland/Turn08/ValgslandVisit_AntiCommunistRayne

- **ID konwersacji:** `163`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/163_ValgslandVisit_AntiCommunistRayne.md`
- **Liczba węzłów dialogowych:** 123
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[26]** Emmerich Hegel

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[3]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“Thank you for the *warm* hospitality.”"** | `[5]` **Emmerich Hegel**: "“Enjoy your stay in Valgsland.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Emmerich Hegel**: "“Sarcasm, huh? Haven't heard tha..." |
| `[10]` | **"“I won't sit idly while you insult me. The deal is off. We are finished here.”"** | `[82]` **Emmerich Hegel**: "“Then let's talk about your deal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Emmerich Hegel**: "“Suit yourself.”" |
| `[11]` | **"“I am definitely not staying after this.”"** | `[5]` **Emmerich Hegel**: "“Enjoy your stay in Valgsland.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Emmerich Hegel**: "“Suit yourself.”" |
| `[16]` | **"“I will. Have a good day, Chancellor Hegel.”"** | `[5]` **Emmerich Hegel**: "“Enjoy your stay in Valgsland.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Emmerich Hegel**: "“Have a good day, Mr. Rayne.”" |
| `[17]` | **"“I think that we have come far. After all, we are standing here side by side inste..."** | `[53]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Emmerich Hegel**: "“We can do so much more through ..." |
| `[24]` | **"“That's it? Sure. I will announce it as soon as possible.”"** | `[23]` **Emmerich Hegel**: "“Recognise Heljiland as Valgslan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Emmerich Hegel**: "“Then consider our trade deal se..." |
| `[25]` | **"“Why? What are you after?”"** | `[23]` **Emmerich Hegel**: "“Recognise Heljiland as Valgslan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Emmerich Hegel**: "“Is that a yes or a no?”" |
| `[31]` | **"“There is no way I can do that.”"** | `[23]` **Emmerich Hegel**: "“Recognise Heljiland as Valgslan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Emmerich Hegel**: "“Suit yourself.”" |
| `[33]` | **"“Fine. Deal.”"** | `[27]` **Emmerich Hegel**: "“Is that a yes or a no?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Emmerich Hegel**: "“Then consider our trade deal se..." |
| `[34]` | **"“I reject. You are asking for too much.”"** | `[27]` **Emmerich Hegel**: "“Is that a yes or a no?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Emmerich Hegel**: "“Suit yourself.”" |
| `[36]` | **"“Thank you.”"** | `[21]` **Emmerich Hegel**: "“Mr. Rayne. Welcome to Valgsland.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He gestured towards the painting." |
| `[37]` | **"“It's good to be here.”"** | `[21]` **Emmerich Hegel**: "“Mr. Rayne. Welcome to Valgsland.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He gestured towards the painting." |
| `[38]` | **"“So. Where do we begin?”"** | `[21]` **Emmerich Hegel**: "“Mr. Rayne. Welcome to Valgsland.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He gestured towards the painting." |
| `[40]` | **"“I don't answer to you, Chancellor Hegel.”"** | `[81]` **Emmerich Hegel**: "“Your actions are clear as day.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Narrator**: "Hegel frowned." |
| `[42]` | **"Shake hands."** | `[41]` **Narrator**: "He extended his hand for a hands..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Emmerich Hegel**: "“We are at the end of our alloca..." |
| `[43]` | **"Don't shake his hand."** | `[41]` **Narrator**: "He extended his hand for a hands..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Emmerich Hegel**: "“We are at the end of our alloca..." |
| `[58]` | **"“Nothing. It's just a painting.”"** | `[53]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Emmerich Hegel**: "“A response that I expected.”" |
| `[59]` | **"“It is a reminder. One misstep and we are back to painting the world with more blo..."** | `[53]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Emmerich Hegel**: "“As the leaders of this world, w..." |
| `[65]` | **"“You have the gall to say that after all this?”"** | `[74]` **Emmerich Hegel**: "“A trade deal between Valgsland ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Emmerich Hegel**: "“I do.”" |
| `[66]` | **"“Let's hear it. What do you want?”"** | `[74]` **Emmerich Hegel**: "“A trade deal between Valgsland ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Emmerich Hegel**: "“What I want is simple.”" |
| `[67]` | **"“You are making it less likely with every minute passing.”"** | `[74]` **Emmerich Hegel**: "“A trade deal between Valgsland ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Emmerich Hegel**: "“What I want is simple.”" |
| `[83]` | **"“My hand was forced when I made those decisions.”"** | `[81]` **Emmerich Hegel**: "“Your actions are clear as day.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Hegel frowned." |
| `[84]` | **"“You have just lowered your chances of achieving a trade deal.”"** | `[82]` **Emmerich Hegel**: "“Then let's talk about your deal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Emmerich Hegel**: "“From the looks of it, you need ..." |
| `[86]` | **"“That's enough! I didn't come here to hear threats. We are done here!”"** | `[92]` **Emmerich Hegel**: "“My problem is with you, Mr. Ray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Emmerich Hegel**: "“Suit yourself.”" |
| `[87]` | **"“You don't have to like me to trade with Sordland.”"** | `[92]` **Emmerich Hegel**: "“My problem is with you, Mr. Ray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Emmerich Hegel**: "“True. But I can certainly make ..." |
| `[88]` | **"“Then it goes both ways, Chancellor Hegel.”"** | `[92]` **Emmerich Hegel**: "“My problem is with you, Mr. Ray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Emmerich Hegel**: "“I am glad that at least we can ..." |
| `[89]` | **"“I expect nothing more.”"** | `[82]` **Emmerich Hegel**: "“Then let's talk about your deal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Emmerich Hegel**: "“Good.”" |
| `[91]` | **"“Chancellor Hegel. Please. Sordland's concerns are Sordland's alone.”"** | `[81]` **Emmerich Hegel**: "“Your actions are clear as day.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Narrator**: "Hegel frowned." |

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
  - -> `[15]` (*Narrator: "He briefly scanned me from head to toe."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Emmerich Hegel: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[3]`
Mówca: **Emmerich Hegel**
> "“Have a good day, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He turned around and walked away, leaving me alone in the..."*)

### Węzeł `[4]`
Mówca: **Emmerich Hegel**
> "“We are at the end of our allocated time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Emmerich Hegel: "“I must go back to work.”"*)

### Węzeł `[5]`
Mówca: **Emmerich Hegel**
> "“Enjoy your stay in Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“I am definitely not staying after this.”"*)
  - -> `[6]` (*Player: "“Thank you for the *warm* hospitality.”"*)
  - -> `[16]` (*Player: "“I will. Have a good day, Chancellor Hegel.”"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Thank you for the *warm* hospitality.”"]** — Mówca: **Player**
> "“Thank you for the *warm* hospitality.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Emmerich Hegel: "“Sarcasm, huh? Haven't heard that one before.”"*)

### Węzeł `[7]`
Mówca: **Emmerich Hegel**
> "“Sarcasm, huh? Haven't heard that one before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Emmerich Hegel: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[8]`
Mówca: **Emmerich Hegel**
> "“I am glad that at least we can agree on one matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Emmerich Hegel: "“Let me tell you this, Mr. Rayne.”"*)

### Węzeł `[9]`
Mówca: **Emmerich Hegel**
> "“Excuses. Is that it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Emmerich Hegel: "“Are you saying that you're not only weak, but also can't..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I won't sit idly while you insult me. The deal is off. We are finished here.”"]** — Mówca: **Player**
> "“I won't sit idly while you insult me. The deal is off. We are finished here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Suit yourself.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I am definitely not staying after this.”"]** — Mówca: **Player**
> "“I am definitely not staying after this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Emmerich Hegel: "“Suit yourself.”"*)

### Węzeł `[12]`
Mówca: **Emmerich Hegel**
> "“Have a safe trip back home, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He turned around and walked away, leaving me alone in the..."*)

### Węzeł `[13]`
Mówca: **Emmerich Hegel**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Emmerich Hegel: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[14]`
Mówca: **Emmerich Hegel**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Emmerich Hegel: "“Have a safe trip back home, Mr. Rayne.”"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "He briefly scanned me from head to toe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "We shook hands as he stared me down."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I will. Have a good day, Chancellor Hegel.”"]** — Mówca: **Player**
> "“I will. Have a good day, Chancellor Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Emmerich Hegel: "“Have a good day, Mr. Rayne.”"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"]** — Mówca: **Player**
> "“I think that we have come far. After all, we are standing here side by side instead of facing each other on a battlefield.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Emmerich Hegel: "“We can do so much more through unity. However, not every..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "We shook hands as he stared me down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Emmerich Hegel: "“Mr. Rayne. Welcome to Valgsland.”"*)

### Węzeł `[19]`
Mówca: **Emmerich Hegel**
> "“I must go back to work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Emmerich Hegel: "“Enjoy your stay in Valgsland.”"*)

### Węzeł `[20]`
Mówca: **Emmerich Hegel**
> "“I sincerely hope you understand that the world doesn't work that way anymore, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Emmerich Hegel: "“Perhaps in the past, but not anymore.”"*)

### Węzeł `[21]`
Mówca: **Emmerich Hegel**
> "“Mr. Rayne. Welcome to Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“It's good to be here.”"*)
  - -> `[36]` (*Player: "“Thank you.”"*)
  - -> `[38]` (*Player: "“So. Where do we begin?”"*)

### Węzeł `[22]`
Mówca: **Emmerich Hegel**
> "“No you don't. But you will answer to the people of your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Emmerich Hegel: "“Do not underestimate your people, Mr. Rayne, or it might..."*)

### Węzeł `[23]`
Mówca: **Emmerich Hegel**
> "“Recognise Heljiland as Valgslandian territory and I am ready to come to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“That's it? Sure. I will announce it as soon as possible.”"*)
  - -> `[25]` (*Player: "“Why? What are you after?”"*)
  - -> `[31]` (*Player: "“There is no way I can do that.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“That's it? Sure. I will announce it as soon as possible.”"]** — Mówca: **Player**
> "“That's it? Sure. I will announce it as soon as possible.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Emmerich Hegel: "“Then consider our trade deal sealed, Mr. Rayne.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Why? What are you after?”"]** — Mówca: **Player**
> "“Why? What are you after?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Emmerich Hegel: "“Is that a yes or a no?”"*)

### Węzeł `[26]`
Mówca: **Emmerich Hegel**
> "“We can do so much more through unity. However, not everyone wants that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "We started walking."*)

### Węzeł `[27]`
Mówca: **Emmerich Hegel**
> "“Is that a yes or a no?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“Fine. Deal.”"*)
  - -> `[34]` (*Player: "“I reject. You are asking for too much.”"*)

### Węzeł `[28]`
Mówca: **Emmerich Hegel**
> "“Do not underestimate your people, Mr. Rayne, or it might be the end of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Emmerich Hegel: "“After all, it was the people who brought imperialism to ..."*)

### Węzeł `[29]`
Mówca: **Emmerich Hegel**
> "“Perhaps in the past, but not anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Emmerich Hegel: "“Listen, Mr. Rayne.”"*)

### Węzeł `[30]`
Mówca: **Emmerich Hegel**
> "“Then consider our trade deal sealed, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.V..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“There is no way I can do that.”"]** — Mówca: **Player**
> "“There is no way I can do that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Suit yourself.”"*)

### Węzeł `[32]`
Mówca: **Emmerich Hegel**
> "“Are you saying that you're not only weak, but also can't own up to your mistakes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Emmerich Hegel: "“To be honest, you do not surprise me, Mr. Rayne.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Fine. Deal.”"]** — Mówca: **Player**
> "“Fine. Deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Emmerich Hegel: "“Then consider our trade deal sealed, Mr. Rayne.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I reject. You are asking for too much.”"]** — Mówca: **Player**
> "“I reject. You are asking for too much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Suit yourself.”"*)

### Węzeł `[35]`
Mówca: **Emmerich Hegel**
> "“I have no qualms about what has been negotiated so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“It's good to be here.”"]** — Mówca: **Player**
> "“It's good to be here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“So. Where do we begin?”"]** — Mówca: **Player**
> "“So. Where do we begin?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[39]`
Mówca: **Emmerich Hegel**
> "“Then consider our trade deal sealed, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.V..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I don't answer to you, Chancellor Hegel.”"]** — Mówca: **Player**
> "“I don't answer to you, Chancellor Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Hegel frowned."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "He extended his hand for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Italic: "Shake hands."*)
  - -> `[43]` (*Player_Italic: "Don't shake his hand."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Shake hands."]** — Mówca: **Player_Italic**
> "We shook hands on it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Emmerich Hegel: "“We are at the end of our allocated time.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Don't shake his hand."]** — Mówca: **Player_Italic**
> "I didn't shake his hand. He shrugged."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Emmerich Hegel: "“We are at the end of our allocated time.”"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He gestured towards the painting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Emmerich Hegel: "“This was made in 1776 by the famous Valgslandian painter..."*)

### Węzeł `[45]`
Mówca: **Emmerich Hegel**
> "“After all, it was the people who brought imperialism to its knees.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Emmerich Hegel: "“Listen, Mr. Rayne.”"*)

### Węzeł `[46]`
Mówca: **Emmerich Hegel**
> "“This was made in 1776 by the famous Valgslandian painter, Otto Kiebern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "I looked at the painting. It must've been over five meter..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "I looked at the painting. It must've been over five meters tall. It was a battle scene. On the left side there were banners carried by Valgs; on the right, Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Countless spears formed a triangle at the center. The sky..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "He turned around and walked away, leaving me alone in the empty halls of the Royal Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[49]`
Mówca: **Emmerich Hegel**
> "“To be honest, you do not surprise me, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Emmerich Hegel: "“Listen, Mr. Rayne.”"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Valgsland_TradeDeal = true;
BaseGame.Agnolia_HeljilandRecognised = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Valgsland_TradeDeal"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAn..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Countless spears formed a triangle at the center. The sky was red from the blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Emmerich Hegel: "“What do you think about it?”"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Hegel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Emmerich Hegel: "“Excuses. Is that it?”"*)

### Węzeł `[53]`
Mówca: **Emmerich Hegel**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“I think that we have come far. After all, we are standin..."*)
  - -> `[58]` (*Player: "“Nothing. It's just a painting.”"*)
  - -> `[59]` (*Player: "“It is a reminder. One misstep and we are back to paintin..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Hegel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Emmerich Hegel: "“I sincerely hope you understand that the world doesn't w..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Hegel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Emmerich Hegel: "“No you don't. But you will answer to the people of your ..."*)

### Węzeł `[56]`
Mówca: **Emmerich Hegel**
> "“Listen, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Emmerich Hegel: "“You have come here for a trade deal.”"*)

### Węzeł `[57]`
Mówca: **Emmerich Hegel**
> "“What I want is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Emmerich Hegel: "“Recognise Heljiland as Valgslandian territory and I am r..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Nothing. It's just a painting.”"]** — Mówca: **Player**
> "“Nothing. It's just a painting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Emmerich Hegel: "“A response that I expected.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“It is a reminder. One misstep and we are back to painting the world with more blood.”"]** — Mówca: **Player**
> "“It is a reminder. One misstep and we are back to painting the world with more blood.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Emmerich Hegel: "“As the leaders of this world, we must be careful, Mr. Ra..."*)

### Węzeł `[60]`
Mówca: **Emmerich Hegel**
> "“Let me tell you this, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Emmerich Hegel: "“A trade deal between Valgsland and Sordland is possible.”"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Emmerich Hegel: "“Sordish fishing output from the Agnland region in return..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[64]`
Mówca: **Emmerich Hegel**
> "“I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Emmerich Hegel: "“What I want is simple.”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“You have the gall to say that after all this?”"]** — Mówca: **Player**
> "“You have the gall to say that after all this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Emmerich Hegel: "“I do.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Let's hear it. What do you want?”"]** — Mówca: **Player**
> "“Let's hear it. What do you want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Emmerich Hegel: "“What I want is simple.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“You are making it less likely with every minute passing.”"]** — Mówca: **Player**
> "“You are making it less likely with every minute passing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Emmerich Hegel: "“What I want is simple.”"*)

### Węzeł `[68]`
Mówca: **Emmerich Hegel**
> "“You have come here for a trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Emmerich Hegel: "“Then let's talk about your deal and we will call it a day.”"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Emmerich Hegel: "“Sordish wheat from the Bergia region in return for Valgs..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[72]`
Mówca: **Emmerich Hegel**
> "“You started privatizing your economy and sold state assets to make the rich even richer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Emmerich Hegel: "“Your actions are clear as day.”"*)

### Węzeł `[73]`
Mówca: **Emmerich Hegel**
> "“As the leaders of this world, we must be careful, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Emmerich Hegel: "“Especially around those who are willing and ready to do ..."*)

### Węzeł `[74]`
Mówca: **Emmerich Hegel**
> "“A trade deal between Valgsland and Sordland is possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“Let's hear it. What do you want?”"*)
  - -> `[65]` (*Player: "“You have the gall to say that after all this?”"*)
  - -> `[67]` (*Player: "“You are making it less likely with every minute passing.”"*)

### Węzeł `[75]`
Mówca: **Emmerich Hegel**
> "“I must admit I have been watching your rule with worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[76]`
Mówca: **Emmerich Hegel**
> "“A response that I expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "We started walking."*)

### Węzeł `[77]`
Mówca: **Emmerich Hegel**
> "“True. But I can certainly make your life harder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Emmerich Hegel: "“Let me tell you this, Mr. Rayne.”"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Emmerich Hegel: "“Sordish coal from the Lorren region in return for Valgsl..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Emmerich Hegel: "“Sordish tungsten in return for Valgsland's hard-earned m..."*)

### Węzeł `[81]`
Mówca: **Emmerich Hegel**
> "“Your actions are clear as day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“I don't answer to you, Chancellor Hegel.”"*)
  - -> `[91]` (*Player: "“Chancellor Hegel. Please. Sordland's concerns are Sordla..."*)
  - -> `[83]` (*Player: "“My hand was forced when I made those decisions.”"*)

### Węzeł `[82]`
Mówca: **Emmerich Hegel**
> "“Then let's talk about your deal and we will call it a day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“I expect nothing more.”"*)
  - -> `[84]` (*Player: "“You have just lowered your chances of achieving a trade ..."*)
  - -> `[10]` (*Player: "“I won't sit idly while you insult me. The deal is off. W..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“My hand was forced when I made those decisions.”"]** — Mówca: **Player**
> "“My hand was forced when I made those decisions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Hegel frowned."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“You have just lowered your chances of achieving a trade deal.”"]** — Mówca: **Player**
> "“You have just lowered your chances of achieving a trade deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Emmerich Hegel: "“From the looks of it, you need this more than I do.”"*)

### Węzeł `[85]`
Mówca: **Emmerich Hegel**
> "“Especially around those who are willing and ready to do precisely that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "We started walking."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“That's enough! I didn't come here to hear threats. We are done here!”"]** — Mówca: **Player**
> "“That's enough! I didn't come here to hear threats. We are done here!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“Suit yourself.”"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“You don't have to like me to trade with Sordland.”"]** — Mówca: **Player**
> "“You don't have to like me to trade with Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Emmerich Hegel: "“True. But I can certainly make your life harder.”"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Then it goes both ways, Chancellor Hegel.”"]** — Mówca: **Player**
> "“Then it goes both ways, Chancellor Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Emmerich Hegel: "“I am glad that at least we can agree on one matter.”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“I expect nothing more.”"]** — Mówca: **Player**
> "“I expect nothing more.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Emmerich Hegel: "“Good.”"*)

### Węzeł `[90]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Emmerich Hegel: "“I must admit I have been watching your rule with worry.”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Chancellor Hegel. Please. Sordland's concerns are Sordland's alone.”"]** — Mówca: **Player**
> "“Chancellor Hegel. Please. Sordland's concerns are Sordland's alone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Hegel frowned."*)

### Węzeł `[92]`
Mówca: **Emmerich Hegel**
> "“My problem is with you, Mr. Rayne. It's with how you lead Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: "“You don't have to like me to trade with Sordland.”"*)
  - -> `[88]` (*Player: "“Then it goes both ways, Chancellor Hegel.”"*)
  - -> `[86]` (*Player: "“That's enough! I didn't come here to hear threats. We ar..."*)

### Węzeł `[93]`
Mówca: **Emmerich Hegel**
> "“From the looks of it, you need this more than I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Emmerich Hegel: "“Here is what I am proposing.”"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Privatization == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel: "“You started privatizing your economy and sold state asse..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Emmerich Hegel: "“Your actions are clear as day.”"*)

### Węzeł `[97]`
Mówca: **Emmerich Hegel**
> "“I am even impartial to the trade deal you have made with those damn Agnolians.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Emmerich Hegel: "“My problem is with you, Mr. Rayne. It's with how you lea..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Emmerich Hegel: "“You accepted Arcasian aid and sold your sovereignty by l..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Emmerich Hegel: "“I am even impartial to the trade deal you have made with..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Emmerich Hegel: "“My problem is with you, Mr. Rayne. It's with how you lea..."*)

### Węzeł `[104]`
Mówca: **Emmerich Hegel**
> "“No. My problem is not with the deal itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[105]`
Mówca: **Emmerich Hegel**
> "“You banned completely legal organizations such as the Red Youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)

### Węzeł `[106]`
Mówca: **Emmerich Hegel**
> "“It's a good deal, really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Emmerich Hegel: "“No. My problem is not with the deal itself.”"*)

### Węzeł `[107]`
Mówca: **Emmerich Hegel**
> "“Here is what I am proposing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Emmerich Hegel: "“I have no qualms about what has been negotiated so far.”"*)

### Węzeł `[108]`
Mówca: **Emmerich Hegel**
> "“Sordish fishing output from the Agnland region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Emmerich Hegel: "“It's a good deal, really.”"*)

### Węzeł `[109]`
Mówca: **Emmerich Hegel**
> "“Sordish wheat from the Bergia region in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Emmerich Hegel: "“It's a good deal, really.”"*)

### Węzeł `[110]`
Mówca: **Emmerich Hegel**
> "“Sordish coal from the Lorren region in return for Valgsland's hard-earned money”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Emmerich Hegel: "“It's a good deal, really.”"*)

### Węzeł `[111]`
Mówca: **Emmerich Hegel**
> "“Sordish tungsten in return for Valgsland's hard-earned money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Emmerich Hegel: "“It's a good deal, really.”"*)

### Węzeł `[112]`
Mówca: **Emmerich Hegel**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Emmerich Hegel: "“Here is what I am proposing.”"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Emmerich Hegel: "“You banned completely legal organizations such as the Re..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization == true"*)

### Węzeł `[116]`
Mówca: **Emmerich Hegel**
> "“You accepted Arcasian aid and sold your sovereignty by letting them build bases.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Emmerich Hegel: "“You extended the emergency in your country with seemingl..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[120]`
Mówca: **Emmerich Hegel**
> "“You extended the emergency in your country with seemingly no end in sight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDealAndHeljiland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Agnolia", "Ne..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Agnolia", "Neutral");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He extended his hand for a handshake."*)
