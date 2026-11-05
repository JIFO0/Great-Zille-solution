# Rizia/Turn 10/NewGovernment_Default

- **ID konwersacji:** `355`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/355_NewGovernment_Default.md`
- **Liczba węzłów dialogowych:** 321
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Angelica`
- `RiziaDLC.Council_GrandVizier_Axel`
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_GrandVizier_Sal`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NewGov_PalesDebtPlan_DontPay`
- `RiziaDLC.Pales_Reconstruction_NoFunds`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.ReparationsAccepted_NoFunds`
- `RiziaDLCIsolated.NewGov_Butterfly_Chaos`
- `RiziaDLCIsolated.NewGov_Butterfly_Seasons`
- `RiziaDLCIsolated.NewGov_Butterfly_Taste`
- `RiziaDLCIsolated.NewGov_Butterfly_Traveled`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_Pales`
- `RiziaDLCIsolated.NewGov_Epic_NoAction_Zille`
- `RiziaDLCIsolated.NewGov_ForeignAffairs`
- `RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.NewGov_Butterfly_Chaos`
- `RiziaDLCIsolated.NewGov_Butterfly_Seasons`
- `RiziaDLCIsolated.NewGov_Butterfly_Taste`
- `RiziaDLCIsolated.NewGov_Butterfly_Traveled`
- `RiziaDLCIsolated.NewGov_DomesticAffairs`
- `RiziaDLCIsolated.NewGov_ForeignAffairs`

### Skoki między-konwersacyjne:
- Węzeł `[73]` -> **[577] Rizia/Turn 10/Foreign_Affairs/Foreign_Affairs Conversation** (../Turn_10/577_Foreign_Affairs_Conversation.md), Węzeł `[1]`
- Węzeł `[74]` -> **[576] Rizia/Turn 10/Domestic Affairs/Domestic Affairs Conversation** (../Turn_10/576_Domestic_Affairs_Conversation.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"Perhaps it was the timing – this season of change, of endings and beginnings."** | `[6]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = t...` | `[9]` **Narrator**: "I was not the man I had been whe..." |
| `[8]` | **"I couldn't help but think that I, too, had traveled a great distance."** | `[6]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = ...` | `[9]` **Narrator**: "I was not the man I had been whe..." |
| `[11]` | **"I thought about how the flutter of a butterfly's wings could send ripples through ..."** | `[6]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;` | `[13]` **Narrator**: "How even the smallest decisions ..." |
| `[12]` | **"I couldn't stop thinking about how when butterflies land on you, they’re tasting y..."** | `[6]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;` | `[10]` **Narrator**: "A knock at the door drew me from..." |
| `[66]` | **""Ah, more paperwork. How delightful.""** | `[62]` **Angelica Sazon**: "“Your Majesty, the latest report..."<br>`[63]` **Axel Reinhart**: "“Your Majesty, the latest report..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "I took the folder before they tu..." |
| `[67]` | **""Guess I should get this over with...""** | `[62]` **Angelica Sazon**: "“Your Majesty, the latest report..."<br>`[63]` **Axel Reinhart**: "“Your Majesty, the latest report..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "I took the folder before they tu..." |
| `[68]` | **""Excellent. I will retire to my study and look this over.""** | `[62]` **Angelica Sazon**: "“Your Majesty, the latest report..."<br>`[63]` **Axel Reinhart**: "“Your Majesty, the latest report..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "I took the folder before they tu..." |
| `[69]` | **""Thank you. You may go.""** | `[62]` **Angelica Sazon**: "“Your Majesty, the latest report..."<br>`[63]` **Axel Reinhart**: "“Your Majesty, the latest report..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "I took the folder before they tu..." |
| `[71]` | **"Foreign affairs."** | `[76]` **Narrator**: "I sat in my chair and took a mom..." | `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false` | `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[3]` **Narrator**: "I stood on the palace balcony, w..." |
| `[72]` | **"Domestic matters."** | `[76]` **Narrator**: "I sat in my chair and took a mom..." | `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false` | `Variable["RiziaDLCIsolated.NewGov_DomesticAffairs"] = true;`<br>`PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");` | `[3]` **Narrator**: "I stood on the palace balcony, w..." |
| `[170]` | **""It is resolved. I'm not paying for it.""** | `[159]` **Hugo Toras**: ""I take it that the matter of Pa..."<br>`[160]` **Sal Ignacius**: ""I see that the matter of Pales ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..."<br>*(oraz 2 innych odgałęzień)* |
| `[171]` | **"“If they wish to rise from the rubble, they’ll find a way.""** | `[159]` **Hugo Toras**: ""I take it that the matter of Pa..."<br>`[160]` **Sal Ignacius**: ""I see that the matter of Pales ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..."<br>*(oraz 2 innych odgałęzień)* |
| `[172]` | **"“I wish it were different. But the treasury is not endless.""** | `[159]` **Hugo Toras**: ""I take it that the matter of Pa..."<br>`[160]` **Sal Ignacius**: ""I see that the matter of Pales ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..."<br>*(oraz 2 innych odgałęzień)* |
| `[173]` | **"“Then it is well-matched with the rest of the world.”"** | `[159]` **Hugo Toras**: ""I take it that the matter of Pa..."<br>`[160]` **Sal Ignacius**: ""I see that the matter of Pales ..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..."<br>*(oraz 2 innych odgałęzień)* |
| `[210]` | **"“There is nothing more to be done.""** | `[219]` **Lucita Azaro**: ""Your Majesty, forgive my presum..."<br>`[232]` **Lucita Azaro**: ""Forgive my presumption, but I e..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..." |
| `[211]` | **""You assumed correctly.""** | `[219]` **Lucita Azaro**: ""Your Majesty, forgive my presum..."<br>`[232]` **Lucita Azaro**: ""Forgive my presumption, but I e..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..." |
| `[213]` | **"“The absence of change is the directive.”"** | `[219]` **Lucita Azaro**: ""Your Majesty, forgive my presum..."<br>`[232]` **Lucita Azaro**: ""Forgive my presumption, but I e..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..." |
| `[220]` | **"“If no order has been given, then you have your answer.”"** | `[219]` **Lucita Azaro**: ""Your Majesty, forgive my presum..."<br>`[232]` **Lucita Azaro**: ""Forgive my presumption, but I e..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[227]` **Hugo Toras**: ""Very well. I will speak of it n..."<br>`[228]` **Sal Ignacius**: ""Very well. I will speak of it n..." |

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
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I stood on the palace balcony, watching as a flurry of monarch butterflies drifted through the air, their orange wings catching the late spring afternoon sunlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "They had come from as far as Rumburg, journeying thousand..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "They had come from as far as Rumburg, journeying thousands of miles to reach southern Xina, where they would winter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Rizia lay in the heart of their migration path."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Rizia lay in the heart of their migration path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I had seen them before, but this time, something about th..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I had seen them before, but this time, something about their passage struck me differently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus_Italic: "Perhaps it was the timing – this season of change, of end..."*)
  - -> `[8]` (*Player_Romus_Italic: "I couldn't help but think that I, too, had traveled a gre..."*)
  - -> `[11]` (*Player_Romus_Italic: "I thought about how the flutter of a butterfly's wings co..."*)
  - -> `[12]` (*Player_Romus_Italic: "I couldn't stop thinking about how when butterflies land ..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Perhaps it was the timing – this season of change, of endings and beginnings."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Seasons = true;"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't help but think that I, too, had traveled a great distance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Traveled = true;"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I was not the man I had been when I first took the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A knock at the door drew me from my thoughts."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "A knock at the door drew me from my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.P..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I thought about how the flutter of a butterfly's wings could send ripples through the air, unseen but far-reaching."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Chaos = true;"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't stop thinking about how when butterflies land on you, they’re tasting you with their feet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Taste = true;"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "How even the smallest decisions in my reign -- those made in quiet moments -- could set off a chain of events far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A knock at the door drew me from my thoughts."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Seasons = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I was not the man I had been when I first took the throne."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Traveled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I was not the man I had been when I first took the throne."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Chaos = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "How even the smallest decisions in my reign -- those made..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Taste = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "A knock at the door drew me from my thoughts."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "As their footsteps faded down the corridor, I turned my gaze to the window overlooking the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The sun had begun to set, and the silhouettes of butterfl..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The sun had begun to set, and the silhouettes of butterflies fluttered against the fading light."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Seasons == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Traveled == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Chaos == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Taste == true"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I was once again reminded of the distance I had traveled to get here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "How my journey was far from over, and I would see it through to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "I was once again reminded that, like the seasons, I too had changed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "And my transformation would carry me far into the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "I was once again reminded of how the smallest of actions could result in consequences far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "I was once again reminded that they taste with their feet -- how life is fully of strange, unexpected oddities."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "And that as King of Rizia, it was my sole responsibility to deal with whatever came my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "And no matter how strange the journey ahead might be, I would face the future head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I stood on the palace balcony, watching as a flurry of mo..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Seasons == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Seasons == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Seasons == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "I was once again reminded that, like the seasons, I too h..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Traveled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Traveled == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Traveled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I was once again reminded of the distance I had traveled ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Chaos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Chaos == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Chaos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "I was once again reminded of how the smallest of actions ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Taste == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Taste == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Taste == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Taste == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "I was once again reminded that they taste with their feet..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Taste == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Narrator**
> "With no Grand Vizier to mediate between me and the matters of my kingdom, I alone was responsible for reviewing them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "With one last glance at the butterflies, I stepped inside..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "An attendant stepped forward, head bowed, holding a leather-bound folder thick with reports."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "With no Grand Vizier to mediate between me and the matter..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.Path_Stratocracy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.P..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.Path_Stratocracy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == false  or  Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Empty == false || RiziaDLC.Path_Stratocracy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == false  or  Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "An attendant stepped forward, head bowed, holding a leath..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "With one last glance at the butterflies, I stepped inside and made my way to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Setting the folder down, I took out the reports and sprea..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Setting the folder down, I took out the reports and spread them across my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "I sat in my chair and took a moment to scan the contents,..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Angelica stepped forward, head bowed. One of her aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "AddConversant("Angelica Sazon");"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Axel stepped forward, head bowed. One of his aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Sal stepped forward, head bowed. One of his aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Hugo stepped forward, head bowed. One of his aides proffered a leather-bound folder thick with documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Hugo stepped forward, head bowed. One of his aides proffe..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Sal stepped forward, head bowed. One of his aides proffer..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Axel == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Axel stepped forward, head bowed. One of his aides proffe..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Angelica stepped forward, head bowed. One of her aides pr..."*)

### Węzeł `[62]`
Mówca: **Angelica Sazon**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[65]`
Mówca: **Hugo Toras**
> "“Your Majesty, the latest reports from the kingdom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, more paperwork. How delightful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Angelica Sazon), `[63]` (Axel Reinhart), `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I took the folder before they turned and left."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guess I should get this over with...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Angelica Sazon), `[63]` (Axel Reinhart), `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I took the folder before they turned and left."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent. I will retire to my study and look this over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Angelica Sazon), `[63]` (Axel Reinhart), `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I took the folder before they turned and left."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. You may go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Angelica Sazon), `[63]` (Axel Reinhart), `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I took the folder before they turned and left."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""Thank you. You may go.""*)
  - -> `[68]` (*Player_Romus: ""Excellent. I will retire to my study and look this over.""*)
  - -> `[67]` (*Player_Romus: ""Guess I should get this over with...""*)
  - -> `[66]` (*Player_Romus: ""Ah, more paperwork. How delightful.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "Foreign affairs."]** — Mówca: **Player_Romus_Italic**
> "I turned my attention to foreign affairs."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_ForeignAffairs = true;"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "Domestic matters."]** — Mówca: **Player_Romus_Italic**
> "I opened the dossier on domestic matters."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_DomesticAffairs = true;"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_ForeignAffairs = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_DomesticAffairs = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_DomesticAffairs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[75]`
Mówca: **Narrator**
> "I took the folder before they turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "I sat in my chair and took a moment to scan the contents, considering where to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_ForeignAffairs == false"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_ForeignAffairs == false"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Hugo Toras: "“Your Majesty, the latest reports from the kingdom.”"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Sal Ignacius: "“Your Majesty, the latest reports from the kingdom.”"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: "“Your Majesty, the latest reports from the kingdom.”"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ignacius"); RemoveConversant("Axel Reinhart"); RemoveConversant("Angelica Sazon"); 
RemoveConversant("Taddeus Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Sal Ignacius");
RemoveConversant("Axel Reinhart");
RemoveConversant("Angelica Sazon");
RemoveConversant("Taddeus Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "With one last glance at the butterflies, I stepped inside..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Angelica Sazon: "“Your Majesty, the latest reports from the kingdom.”"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NewGovEnding_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Cou..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "It wasn't long before they entered my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true && Ri..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone and summoned the attendant on the other end to summon my aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true && Ri..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Council_GrandVizier_Sal == true || RiziaDLC.Council_GrandVizier_Axel == true || RiziaDLC.Council_GrandVizier_Angelica == true || RiziaDLC.Path_Stratocracy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Cou..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.C..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Council_GrandVizier_Sal == true || RiziaDLC.Council_GrandVizier_Axel == true || RiziaDLC.Council_GrandVizier_Angelica == true || RiziaDLC.Path_Stratocracy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Sal"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Axel"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true  or  Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true || RiziaDLC.Council_GrandVizier_Sal == true || RiziaDLC.Council_GrandVizier_Axel == true || RiziaDLC.Council_GrandVizier_Angelica == true || RiziaDLC.Path_Stratocracy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Sal"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Axel"] == true  or  Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true  or  Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Now that I was done, I pressed the button on my speakerph..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Axel and his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Sal and his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Hugo and his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "It wasn't long before they entered my chambers, where I handed them what I had signed and sealed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "They said they would "handle this at once," before depart..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon my wife and her aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Now that I was done, I pressed the button on my speakerphone, instructing the attendant on the other end to summon Angelica and her aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "AddConversant("Angelica Sazon");"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Now that I was done, I pressed the button on my speakerph..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Axel == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "Now that I was done, I pressed the button on my speakerph..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[100]`
Mówca: **Angelica Sazon**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Now that I was done, I pressed the button on my speakerph..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)

### Węzeł `[104]`
Mówca: **Sal Ignacius**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Now that I was done, I pressed the button on my speakerph..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Now that I was done, I pressed the button on my speakerph..."*)

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "It wasn't long before they entered my chambers."*)

### Węzeł `[111]`
Mówca: **Axel Reinhart**
> ""Bold. Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "It wasn't long before they entered my chambers."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Angelica Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "It wasn't long before they entered my chambers."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "It wasn't long before they entered my chambers."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "It wasn't long before they entered my chambers."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""Bold. Consider it handled.""*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Axel == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Axel Reinhart: ""Bold. Consider it handled.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Sal Ignacius: ""Bold. Consider it handled.""*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""As for funding the reparations for Pales, it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Hugo Toras: ""In any case, I'll see to it that your orders are carried..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Angelica Sazon: ""Bold. Consider it handled.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucita Azaro: ""Bold. Consider it handled.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true && Ri..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true && ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "I handed the reports back to them."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true 
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "I handed them what I had signed and sealed, which they ca..."*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Hugo Toras: ""In any case, I'll see to it that your orders are carried..."*)

### Węzeł `[133]`
Mówca: **Sal Ignacius**
> ""As for funding Pales' reconciliation... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Sal Ignacius: ""Nevertheless, by His grace, your orders will be carried ..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "I handed them what I had signed and sealed, which they carefully looked over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NewGov_PalesDebtPlan_DontPay == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NewGov_PalesDebtPlan_DontPay == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDL..."*)

### Węzeł `[138]`
Mówca: **Angelica Sazon**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Angelica Sazon: ""Nevertheless, Your Majesty, I'll see to it that your ord..."*)

### Węzeł `[139]`
Mówca: **Angelica Sazon**
> ""As for funding Pales' reconciliation... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Angelica Sazon: ""Nevertheless, Your Majesty, I'll see to it that your ord..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""As for funding Pales reconstruction... it's a heavy pric..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""As for funding the reparations for Pales, it's a heavy p..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Sal Ignacius: ""As for funding Pales reconstruction... it's a heavy pric..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sal Ignacius: ""As for funding Pales' reconciliation... it's a heavy pri..."*)

### Węzeł `[155]`
Mówca: **Sal Ignacius**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Sal Ignacius: ""Nevertheless, by His grace, your orders will be carried ..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Angelica Sazon: ""As for funding Pales reconstruction... it's a heavy pric..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Angelica Sazon: ""As for funding Pales' reconciliation... it's a heavy pri..."*)

### Węzeł `[159]`
Mówca: **Hugo Toras**
> ""I take it that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[160]`
Mówca: **Sal Ignacius**
> ""I see that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[161]`
Mówca: **Sal Ignacius**
> ""I see that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[162]`
Mówca: **Angelica Sazon**
> ""I see that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[163]`
Mówca: **Angelica Sazon**
> ""I see that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[164]`
Mówca: **Lucita Azaro**
> ""I see that the matter of Pales reconstruction remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[165]`
Mówca: **Lucita Azaro**
> ""I see that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""It is resolved. I'm not paying for it.""*)
  - -> `[171]` (*Player_Romus: "“If they wish to rise from the rubble, they’ll find a way.""*)
  - -> `[172]` (*Player_Romus: "“I wish it were different. But the treasury is not endless.""*)
  - -> `[173]` (*Player_Romus: "“Then it is well-matched with the rest of the world.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Hugo Toras: ""Very well. I will speak of it no more. If that’s all, I’..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is resolved. I'm not paying for it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Hugo Toras), `[160]` (Sal Ignacius), `[161]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“If they wish to rise from the rubble, they’ll find a way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Hugo Toras), `[160]` (Sal Ignacius), `[161]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I wish it were different. But the treasury is not endless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Hugo Toras), `[160]` (Sal Ignacius), `[161]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Then it is well-matched with the rest of the world.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Hugo Toras), `[160]` (Sal Ignacius), `[161]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""I take it that the matter of Pales reparations remains unresolved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""As for funding Pales' reconciliation... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucita Azaro: ""Nevertheless, I'll see to it that your orders are carrie..."*)

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""In any case, I'll see to it that your orders are carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Hugo bowed, then turned and strode out."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Hugo bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[178]`
Mówca: **Sal Ignacius**
> ""Nevertheless, by His grace, your orders will be carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Sal bowed, then turned and strode out."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Sal bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[180]`
Mówca: **Angelica Sazon**
> ""Nevertheless, Your Majesty, I'll see to it that your orders are carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Angelica bowed, then turned and walked out."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Angelica bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""Nevertheless, I'll see to it that your orders are carried out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Lucita bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Lucita gave a slight nod before she turned and walked out."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "Lucita bowed, then turned and walked out."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "Lucita gave a slight nod before she turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ignacius"); RemoveConversant("Axel Reinhart"); RemoveConversant("Angelica Sazon"); 
RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Sal Ignacius");
RemoveConversant("Axel Reinhart");
RemoveConversant("Angelica Sazon");
RemoveConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "As their footsteps faded down the corridor, I turned my g..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Hugo Toras: ""I take it that the matter of Pales reconstruction remain..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Hugo Toras: ""I take it that the matter of Pales reparations remains u..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Sal Ignacius: ""I see that the matter of Pales reconstruction remains un..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Sal Ignacius: ""I see that the matter of Pales reparations remains unres..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Angelica Sazon: ""I see that the matter of Pales reconstruction remains un..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Angelica Sazon: ""I see that the matter of Pales reparations remains unres..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucita Azaro: ""I see that the matter of Pales reconstruction remains un..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucita Azaro: ""I see that the matter of Pales reparations remains unres..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“There is nothing more to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[232]` (Lucita Azaro), `[274]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You assumed correctly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[232]` (Lucita Azaro), `[274]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Hugo bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“The absence of change is the directive.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[232]` (Lucita Azaro), `[274]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Sal bowed, then turned and strode out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Angelica bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "Lucita bowed, then turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Lucita gave a slight nod before she turned and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""You assumed correctly.""*)
  - -> `[213]` (*Player_Romus: "“The absence of change is the directive.”"*)
  - -> `[210]` (*Player_Romus: "“There is nothing more to be done.""*)
  - -> `[220]` (*Player_Romus: "“If no order has been given, then you have your answer.”"*)

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“If no order has been given, then you have your answer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Lucita Azaro), `[232]` (Lucita Azaro), `[274]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Sal Ignacius: ""Very well. I will speak of it no more. If that’s all, I’..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Angelica Sazon: ""Very well. I will speak of it no more. If that’s all, I’..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Lucita Azaro: ""Very well. I will speak of it no more. If that’s all, I’..."*)

### Węzeł `[227]`
Mówca: **Hugo Toras**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Hugo bowed, then turned and strode out."*)

### Węzeł `[228]`
Mówca: **Sal Ignacius**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Sal bowed, then turned and strode out."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Lucita gave a slight nod before she turned and walked out."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Lucita bowed, then turned and walked out."*)

### Węzeł `[232]`
Mówca: **Lucita Azaro**
> ""Forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[233]`
Mówca: **Angelica Sazon**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Angelica bowed, then turned and walked out."*)

### Węzeł `[234]`
Mówca: **Lucita Azaro**
> ""Very well. I will speak of it no more. If that’s all, I’ll be on my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[236]`
Mówca: **Lucita Azaro**
> ""As for funding Pales reconstruction... it's a heavy price to pay… but unavoidable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucita Azaro: ""Nevertheless, I'll see to it that your orders are carrie..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Lucita Azaro: ""As for funding Pales reconstruction... it's a heavy pric..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucita Azaro: ""As for funding Pales' reconciliation... it's a heavy pri..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "They said they would "handle this at once," before departing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDLC.ReparationsAccepted_NoFunds == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDL..."*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == false && Rizia..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDLC.ReparationsAccepted_NoFunds == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == false  and  Variable["RiziaDLC.ReparationsAccepted_NoFunds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "My advisor bowed once more before departing."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == false && RiziaDLC.ReparationsAccepted_NoFunds == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == false  and  Variable["RiziaDLC.ReparationsAccepted_NoFunds"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NewGov_PalesDebtPlan_DontPay == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NewGov_PalesDebtPlan_DontPay == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NewGov_PalesDebtPlan_DontPay == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NewGov_PalesDebtPlan_DontPay"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_PalesReport_CrumpleThrow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[250]`
Mówca: **Narrator**
> "My advisor's attention was drawn to the report on Pales I had thrown across the room. An assistant retrieved it and smoothed it out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[251]`
Mówca: **Narrator**
> "The report on Pales was still sitting on my desk. My advisor eyed it cautiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Sal == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Sal Ignacius: ""Your Majesty, forgive my presumption, but I expected som..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "The report on Pales was still sitting on my desk. My advi..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "The report on Pales was still sitting on my desk. My advi..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Angelica == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Angelica Sazon: ""Your Majesty, forgive my presumption, but I expected som..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)

### Węzeł `[261]`
Mówca: **Narrator**
> "My advisor bowed once more before departing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "The report on Pales was still sitting on my desk. My advisor eyed it cautiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "My advisor's attention was drawn to the report on Pales I..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "My advisor's attention was drawn to the report on Pales I..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "My advisor's attention was drawn to the report on Pales I had thrown across the room. An assistant retrieved it and smoothed it out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Hugo Toras: ""Your Majesty, forgive my presumption, but I expected som..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Sal == true"*)

### Węzeł `[270]`
Mówca: **Narrator**
> "I handed the reports back to them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NewGov_PalesDebtPlan_DontPay == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Axel == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Axel == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Axel Reinhart: ""Your Majesty, forgive my presumption, but I expected som..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Angelica == true"*)

### Węzeł `[274]`
Mówca: **Hugo Toras**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[275]`
Mówca: **Sal Ignacius**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[276]`
Mówca: **Angelica Sazon**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[277]`
Mówca: **Axel Reinhart**
> ""Your Majesty, forgive my presumption, but I expected some directive on these matters. Am I to assume the course remains unchanged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Reconstruction_NoFunds == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Reconstruction_NoFunds == true )"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Reconstruction_NoFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucita Azaro: ""Your Majesty, forgive my presumption, but I expected som..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Reconstruction_NoFunds == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Reconstruction_NoFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucita Azaro: ""Forgive my presumption, but I expected some directive on..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true && Ri..."*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true && ..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "I handed the reports back to them, saying nothing in them..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Epic_NoAction_Zille == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_Pales == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary == true && 
RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs == true &&
RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy == true 
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Zille"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_Pales"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_AllianceAndMilitary"] == true  and  
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_GovAffairs"] == true  and 
Variable["RiziaDLCIsolated.NewGov_Epic_NoAction_EconomyAndEnergy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "It wasn't long before they entered my chambers, where I h..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "I handed the reports back to them, saying nothing in them warranted decisive action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "They acknowledged my remark, bowed and departed."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "They acknowledged my remark, bowed and departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PromiseToAbdicate == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "And that just like the seasons, all things -- including m..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "And my transformation would carry me far into the future."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "And that just like the seasons, all things -- including my reign -- had to end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PromiseToAbdicate == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "And that my long journey was nearing its end."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "How my journey was far from over, and I would see it thro..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "And that my long journey was nearing its end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PromiseToAbdicate == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "And that one of those consequences was the imminent end o..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "And that as King of Rizia, it was my sole responsibility ..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "And that one of those consequences was the imminent end of my reign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PromiseToAbdicate == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "I wondered what direction my own life would take once my ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "And no matter how strange the journey ahead might be, I w..."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "I wondered what direction my own life would take once my reign came to an end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Path_Stratocracy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Path_Stratocracy == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Path_Stratocracy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Path_Stratocracy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[306]`
Mówca: **Narrator**
> "Two columns of men in military garb walked in purposefully. They parted to reveal the Queen Consort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> "“Romus, Your Majesty. We've brought the latest reports from the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucita Azaro: "“Romus, Your Majesty. We've brought the latest reports fr..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Empty == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Two columns of men in military garb walked in purposefull..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Empty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "Two columns of men in military garb walked in purposefull..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "Two columns of men in military garb walked in purposefully. They parted to reveal my Grand Vizier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_ForeignAffairs == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_ForeignAffairs == false"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_ForeignAffairs == false)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_ForeignAffairs == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "ForeignAffairs_Hub"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_ForeignAffairs == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_ForeignAffairs == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_ForeignAffairs == false"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_ForeignAffairs == false)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_ForeignAffairs == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "DomesticAffairs_Hub"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_ForeignAffairs == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_ForeignAffairs"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ForeignAffairs_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus_Italic: "Foreign affairs."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DomesticAffairs_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus_Italic: "Domestic matters."*)
