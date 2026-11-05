# Rizia/Turn 10/VinaFuneral

- **ID konwersacji:** `332`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/332_VinaFuneral.md`
- **Liczba węzłów dialogowych:** 141
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Successor_Hubertus`
- `RiziaDLC.Successor_Hugo`
- `RiziaDLC.Successor_Rico`
- `RiziaDLC.Successor_Vina`
- `RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother`
- `RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself`
- `RiziaDLC.VinaFuneral_PromisedEstela_NotToDie`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLCSupport.Journal_Turn10_VinaFuneral_PromisedEstelaNotToDie`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"A sword."** | `[10]` **Hugo Toras**: ""An offering for the Heiress's p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Hugo Toras**: ""The sword is heavy. Sharp and s..." |
| `[11]` | **"A rose."** | `[10]` **Hugo Toras**: ""An offering for the Heiress's p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Hugo Toras**: ""The rose has thorns. Beautiful ..." |
| `[12]` | **"A feather."** | `[10]` **Hugo Toras**: ""An offering for the Heiress's p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Hugo Toras**: ""The feather is light. Free and ..." |
| `[14]` | **"A gold coin."** | `[10]` **Hugo Toras**: ""An offering for the Heiress's p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Hugo Toras**: ""The gold is heart. Generous and..." |
| `[22]` | **""How are you holding up, Mother?""** | `[21]` **Narrator**: "To my left was my mother. Her ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Estela Toras**: ""Losing Lena, then Vina..."" |
| `[23]` | **"Stay silent."** | `[21]` **Narrator**: "To my left was my mother. Her ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "She gripped my arm as the flag o..." |
| `[29]` | **""I promise, mother.""** | `[27]` **Estela Toras**: ""You won't die too, will you, da..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.VinaFuneral_PromisedEstela_NotToDie"] ...` | `[31]` **Narrator**: "A single tear fell down her cheek." |
| `[30]` | **"Do not answer."** | `[27]` **Estela Toras**: ""You won't die too, will you, da..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "A single tear fell down her cheek." |
| `[38]` | **"Let her go."** | `[37]` **Narrator**: "She stood and went toward Vina a..."<br>`[44]` **Narrator**: "Her voice wavered. She didn't so..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerse...`<br>`RemoveConversant("Estela Toras");` | `[47]` **Narrator**: "She went up alongside Vina's sto..." |
| `[39]` | **"Quietly gesture for her to return to her seat."** | `[37]` **Narrator**: "She stood and went toward Vina a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Estela Toras**: ""Can't a grandmother say her far..." |
| `[40]` | **"Join her."** | `[37]` **Narrator**: "She stood and went toward Vina a..."<br>`[44]` **Narrator**: "Her voice wavered. She didn't so..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMothe...` | `[49]` **Narrator**: "She went up alongside Vina's sto..." |
| `[42]` | **""Come back. That's an order.""** | `[44]` **Narrator**: "Her voice wavered. She didn't so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "She reluctantly returned to her ..." |
| `[52]` | **"Say your final words to Vina."** | `[119]` **Narrator**: "The ceremonial guardsmen gave he..."<br>`[120]` **Narrator**: "Hugo allowed her some time befor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Player_Romus**: ""I am sorry.""<br>`[55]` **Player_Romus**: ""I love you.""<br>*(oraz 3 innych odgałęzień)* |
| `[53]` | **"Return to seat."** | `[119]` **Narrator**: "The ceremonial guardsmen gave he..."<br>`[120]` **Narrator**: "Hugo allowed her some time befor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "Several ceremonial guardsmen pic..." |
| `[54]` | **""I am sorry.""** | `[52]` **Player_Romus_Italic**: "I stepped forward, taking the pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "I kissed her on the forehead and..." |
| `[55]` | **""I love you.""** | `[52]` **Player_Romus_Italic**: "I stepped forward, taking the pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "I kissed her on the forehead and..." |
| `[56]` | **""Say hello to your mother for me.""** | `[52]` **Player_Romus_Italic**: "I stepped forward, taking the pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "I kissed her on the forehead and..." |
| `[57]` | **""I will never forgive myself.""** | `[52]` **Player_Romus_Italic**: "I stepped forward, taking the pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "I kissed her on the forehead and..." |
| `[58]` | **""I will avenge you.""** | `[52]` **Player_Romus_Italic**: "I stepped forward, taking the pl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "I kissed her on the forehead and..." |
| `[64]` | **"Pour gold over Vina's coffin."** | `[122]` **Narrator**: "Other ceremonial guardsmen, each..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "As I watched the gold solidify, ..." |
| `[85]` | **"A sword."** | `[84]` **Narrator**: "It was customary for me, as both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Player_Romus**: ""The sword is heavy. Sharp and s..." |
| `[86]` | **"A rose."** | `[84]` **Narrator**: "It was customary for me, as both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Player_Romus**: ""The rose has thorns. Beautiful ..." |
| `[87]` | **"A feather."** | `[84]` **Narrator**: "It was customary for me, as both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player_Romus**: ""The feather is light. Free and ..." |
| `[88]` | **"A gold coin."** | `[84]` **Narrator**: "It was customary for me, as both..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Player_Romus**: ""The gold is heart. Generous and..." |
| `[91]` | **""The sword is heavy. Sharp and strong.""** | `[85]` **Player_Romus_Italic**: "I presented a sword." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "I held it up for all to see." |
| `[92]` | **""The rose has thorns. Beautiful and defiant.""** | `[86]` **Player_Romus_Italic**: "I presented a rose." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "I held it up for all to see." |
| `[93]` | **""The feather is light. Free and flowing.""** | `[87]` **Player_Romus_Italic**: "I presented a feather." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "I held it up for all to see." |
| `[94]` | **""The gold is heart. Generous and gracious.""** | `[88]` **Player_Romus_Italic**: "I presented a gold coin." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "I held it up for all to see." |
| `[99]` | **""And so, Vina passes. The first of her name. Daughter of Romus I. Daughter of late..."** | `[96]` **Narrator**: "I held it up for all to see." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "The crowd began to collectively ..." |
| `[102]` | **""May this offering guide her to the realms beyond, where her ancestors await. ""** | `[96]` **Narrator**: "I held it up for all to see." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "The crowd began to collectively ..." |
| `[103]` | **""Vina, your journey has ended too soon. May this gift be a token of my love, to ac..."** | `[96]` **Narrator**: "I held it up for all to see." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "The crowd began to collectively ..." |
| `[107]` | **""By the grace of God, may this offering guide you into the next world, where your ..."** | `[96]` **Narrator**: "I held it up for all to see." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[100]` **Narrator**: "The crowd began to collectively ..." |
| `[111]` | **""Wait! You must follow protocol.""** | `[37]` **Narrator**: "She stood and went toward Vina a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Estela Toras**: ""Can't a grandmother say her far..." |

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
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Burying their daughter after a lost war"..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had done this countless times now. Far too often. My wife, my father, and so many others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "But I had never expected that I would have to bury my own..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "But I had never expected that I would have to bury my own daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""Make way. Make way for the Princess of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "As per tradition, Hugo was leading the cortège. Around us were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "We arrived at the entrance to the National Mausoleum. Hug..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "We arrived at the entrance to the National Mausoleum. Hugo stopped and I moved over to the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "He knelt before me."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "He knelt before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""An offering for the Heiress's passage into Golconda, You..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "A sword."]** — Mówca: **Player_Romus_Italic**
> "I handed him the sword."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""The sword is heavy. Sharp and strong.""*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""An offering for the Heiress's passage into Golconda, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus_Italic: "A sword."*)
  - -> `[11]` (*Player_Romus_Italic: "A rose."*)
  - -> `[12]` (*Player_Romus_Italic: "A feather."*)
  - -> `[14]` (*Player_Romus_Italic: "A gold coin."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "A rose."]** — Mówca: **Player_Romus_Italic**
> "I handed him the rose."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""The rose has thorns. Beautiful and defiant.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "A feather."]** — Mówca: **Player_Romus_Italic**
> "I handed him the feather."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""The feather is light. Free and flowing.""*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""The sword is heavy. Sharp and strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He turned to the crowd and held it high. Silence was deaf..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "A gold coin."]** — Mówca: **Player_Romus_Italic**
> "I handed him the gold coin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""The gold is heart. Generous and gracious.""*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""The rose has thorns. Beautiful and defiant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He turned to the crowd and held it high. Silence was deaf..."*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""The feather is light. Free and flowing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He turned to the crowd and held it high. Silence was deaf..."*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""The gold is heart. Generous and gracious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He turned to the crowd and held it high. Silence was deaf..."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""And so, Vina passes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""The first of her name. Daughter of Romus I. Daughter of ..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "He turned to the crowd and held it high. Silence was deafening. His voice roared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""And so, Vina passes.""*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""The first of her name. Daughter of Romus I. Daughter of the late Princess Consort Lena. Princess of Rizia. Heir to Valenqiris and the lands of Rizia Imperii.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "To my left was my mother. Her eyes were still red from crying, but she held her head up high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""How are you holding up, Mother?""*)
  - -> `[23]` (*Player_Romus_Italic: "Stay silent."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you holding up, Mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Estela Toras: ""Losing Lena, then Vina...""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "She gripped my arm as the flag of Rizia was removed by ce..."*)

### Węzeł `[24]`
Mówca: **Estela Toras**
> ""Losing Lena, then Vina...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Estela Toras: ""The women of this family must be cursed.""*)

### Węzeł `[25]`
Mówca: **Estela Toras**
> ""The women of this family must be cursed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Estela Toras: ""Perhaps it really is my fault. A commoner tainting the T..."*)

### Węzeł `[26]`
Mówca: **Estela Toras**
> ""Perhaps it really is my fault. A commoner tainting the Toras bloodline and dooming its heirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed ..."*)

### Węzeł `[27]`
Mówca: **Estela Toras**
> ""You won't die too, will you, darling? I want you to promise me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""I promise, mother.""*)
  - -> `[30]` (*Player_Romus_Italic: "Do not answer."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "She turned to me with a serious look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Estela Toras: ""You won't die too, will you, darling? I want you to prom..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise, mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaFuneral_PromisedEstela_NotToDie = true; Rizi..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "Do not answer."]** — Mówca: **Player_Romus_Italic**
> "I did not answer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "A single tear fell down her cheek."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "A single tear fell down her cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Estela Toras: ""We must... pay our respects.""*)

### Węzeł `[32]`
Mówca: **Estela Toras**
> ""We must... pay our respects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Her voice broke off."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Her voice broke off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "She gripped my arm as the flag of Rizia was removed by ce..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "She gripped my arm as the flag of Rizia was removed by ceremonial guardsmen, revealing Vina's serene face. There was an undeniable calmness about her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Estela Toras: ""Oh, my dearest Vina.""*)

### Węzeł `[35]`
Mówca: **Estela Toras**
> ""Oh, my dearest Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Estela Toras: ""What did they do to you? How did we let this happen?""*)

### Węzeł `[36]`
Mówca: **Estela Toras**
> ""What did they do to you? How did we let this happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "She stood and went toward Vina as her grief took over."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "She stood and went toward Vina as her grief took over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus_Italic: "Quietly gesture for her to return to her seat."*)
  - -> `[111]` (*Player_Romus: ""Wait! You must follow protocol.""*)
  - -> `[38]` (*Player_Romus_Italic: "Let her go."*)
  - -> `[40]` (*Player_Romus_Italic: "Join her."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Let her go."]** — Mówca: **Player_Romus_Italic**
> "I let her go."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself = true"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "Quietly gesture for her to return to her seat."]** — Mówca: **Player_Romus_Italic**
> "I quietly gestured for her to sit down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Estela Toras: ""Can't a grandmother say her farewells?""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "Join her."]** — Mówca: **Player_Romus_Italic**
> "I joined her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother = true"*)

### Węzeł `[41]`
Mówca: **Estela Toras**
> ""Can't a grandmother say her farewells?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Estela Toras: ""I never said goodbye before she left for Pales. The last..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come back. That's an order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "She reluctantly returned to her seat."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "She reluctantly returned to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Several ceremonial guardsmen picked up the sarcophagus lid."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Her voice wavered. She didn't sound like her usual self."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""Come back. That's an order.""*)
  - -> `[38]` (*Player_Romus_Italic: "Let her go."*)
  - -> `[40]` (*Player_Romus_Italic: "Join her."*)

### Węzeł `[45]`
Mówca: **Estela Toras**
> ""I never said goodbye before she left for Pales. The last thing I told her was to watch her waistline...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Her voice wavered. She didn't sound like her usual self."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Several ceremonial guardsmen picked up the sarcophagus lid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "She went up alongside Vina's stone encasement and stood for a moment. After whispering a few words, she gripped its sides, as if reluctant to let go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Hugo allowed her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "She went up alongside Vina's stone encasement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Estela Toras: ""Oh, my darling girl. If I was harsh on you, it was becau..."*)

### Węzeł `[50]`
Mówca: **Estela Toras**
> ""Oh, my darling girl. If I was harsh on you, it was because you were my favorite person in the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Estela Toras: ""Farewell, Your Highness. Your grandmother will love you ..."*)

### Węzeł `[51]`
Mówca: **Estela Toras**
> ""Farewell, Your Highness. Your grandmother will love you forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "She gripped the sides of the sarcophagus, as if reluctant..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Say your final words to Vina."]** — Mówca: **Player_Romus_Italic**
> "I stepped forward, taking the place where my mother had been, to say my final words to Vina."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator), `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""I am sorry.""*)
  - -> `[55]` (*Player_Romus: ""I love you.""*)
  - -> `[56]` (*Player_Romus: ""Say hello to your mother for me.""*)
  - -> `[57]` (*Player_Romus: ""I will never forgive myself.""*)
  - -> `[58]` (*Player_Romus: ""I will avenge you.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "Return to seat."]** — Mówca: **Player_Romus_Italic**
> "I returned to my seat."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator), `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Several ceremonial guardsmen picked up the sarcophagus lid."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I kissed her on the forehead and went back to my throne."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I kissed her on the forehead and went back to my throne."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say hello to your mother for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I kissed her on the forehead and went back to my throne."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will never forgive myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I kissed her on the forehead and went back to my throne."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will avenge you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I kissed her on the forehead and went back to my throne."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "I kissed her on the forehead and went back to my throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Several ceremonial guardsmen picked up the sarcophagus lid."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaFuneral_PromisedEstela_NotToDie = true; RiziaDLCSupport.Journal_Turn10_VinaFuneral_PromisedEstelaNotToDie = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.VinaFuneral_PromisedEstela_NotToDie"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_VinaFuneral_PromisedEstelaNotToDie"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "A single tear fell down her cheek."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_JoinedMother"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "She went up alongside Vina's stone encasement."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.VinaFuneral_CoffinFarewell_MotherHerself"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "A vessel filled with molten gold was presented to me by a guardsman. I was handed protective gloves, allowing me to grip it without harm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Other ceremonial guardsmen, each carrying their own vesse..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "Pour gold over Vina's coffin."]** — Mówca: **Player_Romus_Italic**
> "Together, we poured the molten gold over Vina's stone coffin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "As I watched the gold solidify, I felt weak. Frail."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "As I watched the gold solidify, I felt weak. Frail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Just like my father."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Just like my father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened = true; RiziaDLC.Successor_..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Make way. Make way for the Princess of Rizia.""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "The crowd began to collectively pray and chant her name a..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "To my left was my mother. Her eyes were still red from cr..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "They walked it toward Vina and carefully lowered it onto ..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "They walked it toward Vina and carefully lowered it onto its final resting place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "A vessel filled with molten gold was presented to me by a..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "She went up alongside Vina's stone encasement and stood f..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Several ceremonial guardsmen picked up the sarcophagus lid."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Successor_Hugo = true;
RiziaDLC.Vina_FuneralHappened = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Successor_Hugo"] = true;
Variable["RiziaDLC.Vina_FuneralHappened"] = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Still", "R_Still_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Still","R_Still_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I had done this countless times now. Far too often. My wi..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == false)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Despite his resignation as Grand Vizier, Hugo had agreed ..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "As per tradition, Hugo was leading the cortège. Around us..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Despite his resignation as Grand Vizier, Hugo had agreed to lead the cortège. Around us were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "We arrived at the entrance to the National Mausoleum. Hug..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrest..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "With overcast skies above and a light drizzle falling, I ..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "It was customary for me, as both her father and the King of Rizia, to present an offering for the Heiress's passage into Golconda."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player_Romus_Italic: "A sword."*)
  - -> `[86]` (*Player_Romus_Italic: "A rose."*)
  - -> `[87]` (*Player_Romus_Italic: "A feather."*)
  - -> `[88]` (*Player_Romus_Italic: "A gold coin."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "A sword."]** — Mówca: **Player_Romus_Italic**
> "I presented a sword."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The sword is heavy. Sharp and strong.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "A rose."]** — Mówca: **Player_Romus_Italic**
> "I presented a rose."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""The rose has thorns. Beautiful and defiant.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "A feather."]** — Mówca: **Player_Romus_Italic**
> "I presented a feather."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""The feather is light. Free and flowing.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "A gold coin."]** — Mówca: **Player_Romus_Italic**
> "I presented a gold coin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Romus: ""The gold is heart. Generous and gracious.""*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Around me were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "It was customary for me, as both her father and the King ..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "It wasn't long before we entered the tomb, where Vina's sarcophagus, draped in the Rizian flag, had been placed next to her mother's. The lid was laid off to the side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Her resting place, like that of all royals, had been prep..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The sword is heavy. Sharp and strong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I held it up for all to see."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rose has thorns. Beautiful and defiant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I held it up for all to see."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The feather is light. Free and flowing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I held it up for all to see."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The gold is heart. Generous and gracious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I held it up for all to see."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Her resting place, like that of all royals, had been prepared early on in life, a precaution for when the inevitable came."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I was glad Lena had not lived to see this day. I knew it ..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "I held it up for all to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[102]` (*Player_Romus: ""May this offering guide her to the realms beyond, where ..."*)
  - -> `[99]` (*Player_Romus: ""And so, Vina passes. The first of her name. Daughter of ..."*)
  - -> `[103]` (*Player_Romus: ""Vina, your journey has ended too soon. May this gift be ..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Only a select few were permitted to enter -- immediate family, close relatives, and high-ranking nobility. The rest of the crowd remained outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "As we moved through the corridor, a hushed reverence fell..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "As we moved through the corridor, a hushed reverence fell over the smaller group, a stark contrast to the swelling voices from beyond the stone walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "It wasn't long before we entered the tomb, where Vina's s..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And so, Vina passes. The first of her name. Daughter of Romus I. Daughter of late Queen Lena. Princess of Rizia. Heir to the lands of Rizia Imperii.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The crowd began to collectively pray and chant her name a..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "The crowd began to collectively pray and chant her name as I went inside the mausoleum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Only a select few were permitted to enter -- immediate fa..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "With overcast skies above and a light drizzle falling, I arrived at the entrance to the National Mausoleum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Around me were thousands of people, crying for their Prin..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May this offering guide her to the realms beyond, where her ancestors await. ""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The crowd began to collectively pray and chant her name a..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina, your journey has ended too soon. May this gift be a token of my love, to accompany you as you cross into the afterlife.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The crowd began to collectively pray and chant her name a..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""By the grace of God, may this offering guide you into th..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""May this offering guide her to the realms beyond, where ..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the grace of God, may this offering guide you into the next world, where your spirit will rest beside those who came before you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The crowd began to collectively pray and chant her name a..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I was glad Lena had not lived to see this day. I knew it would have destroyed her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I sat in one of the empty seats set out for the royal fam..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "The crowd began to collectively pray and chant her name as we turned and went inside the mausoleum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Only a select few were permitted to enter -- immediate fa..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "I sat in one of the empty seats set out for the royal family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait! You must follow protocol.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Estela Toras: ""Can't a grandmother say her farewells?""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrest..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Hugo allowed her some time before gently guiding her back..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "The ceremonial guardsmen gave her some time before gently..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "The ceremonial guardsmen gave her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "AddConversant("Estela Toras");"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrest..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Hugo allowed her some time before gently guiding her back..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "The ceremonial guardsmen gave her some time before gently..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "The ceremonial guardsmen gave her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus_Italic: "Say your final words to Vina."*)
  - -> `[53]` (*Player_Romus_Italic: "Return to seat."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Hugo allowed her some time before gently guiding her back to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus_Italic: "Say your final words to Vina."*)
  - -> `[53]` (*Player_Romus_Italic: "Return to seat."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "She gripped the sides of the sarcophagus, as if reluctant to let go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Other ceremonial guardsmen, each carrying their own vessels, stood in formation around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus_Italic: "Pour gold over Vina's coffin."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrest..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Successor_Hugo = true; RiziaDLC.Vina_FuneralHapp..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened = true;
RiziaDLC.Successor_Vina = false;
RiziaDLC.Successor_Rico = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_FuneralHappened"] = true;
Variable["RiziaDLC.Successor_Vina"] = false;
Variable["RiziaDLC.Successor_Rico"] = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrest..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened = true; RiziaDLC.Successor_..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Arrested == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FuneralHappened = true; RiziaDLC.Successor_..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened = true;
RiziaDLC.Successor_Vina = false;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_FuneralHappened"] = true;
Variable["RiziaDLC.Successor_Vina"] = false;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FuneralHappened = true;
RiziaDLC.Successor_Vina = false;
RiziaDLC.Successor_Hubertus = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_FuneralHappened"] = true;
Variable["RiziaDLC.Successor_Vina"] = false;
Variable["RiziaDLC.Successor_Hubertus"] = true;
EnableCodexEntry("Characters_Family_VinaToras_DiedInWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed ..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Execute..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Estela Toras: ""And with even Hugo gone... Our house has turned to dust.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "She turned to me with a serious look."*)

### Węzeł `[135]`
Mówca: **Estela Toras**
> ""And with even Hugo gone... Our house has turned to dust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "She turned to me with a serious look."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform_Success == true && RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Refo..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform_Success == true && RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true  or  (Variable["RiziaDLC.Reform_Success"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Despite everything I'd done, Hugo had agreed to lead the ..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true || (RiziaDLC.Reform_Success == true && RiziaDLC.BirthdayGathering_ViolentAction == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true  or  (Variable["RiziaDLC.Reform_Success"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Despite everything I'd done, Hugo had agreed to lead the cortège out of love for his great-niece. Around us were thousands of people, crying for their Princess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "We arrived at the entrance to the National Mausoleum. Hug..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Burying their daughter after a lost war", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Burying their daughter after a lost war","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Still", "R_Still_Loop");"*)
