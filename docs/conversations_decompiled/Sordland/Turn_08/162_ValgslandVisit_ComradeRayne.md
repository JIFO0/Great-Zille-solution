# Sordland/Turn08/ValgslandVisit_ComradeRayne

- **ID konwersacji:** `162`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/162_ValgslandVisit_ComradeRayne.md`
- **Liczba węzłów dialogowych:** 194
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[26]** Emmerich Hegel

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Reform_Autocrat_CourtVote_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.GovernmentBudget`
- `BaseGame.Hegel_PutInAGoodWordWithMalenyev`
- `BaseGame.Malenyevist`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[3]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **"“Let's hope we can stay that way.”"** | `[89]` **Emmerich Hegel**: "“No two countries in this world ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Emmerich Hegel**: "“I am sure we will.”" |
| `[15]` | **"“I won't meddle in the affairs between Valgsland and Agnolia.”"** | `[14]` **Emmerich Hegel**: "“What do you say, Comrade Rayne?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Emmerich Hegel**: "“So you'd prefer to stay neutral.”" |
| `[16]` | **"“I am with you, Comrade Hegel.” [+1 Budget]"** | `[14]` **Emmerich Hegel**: "“What do you say, Comrade Rayne?..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true...`<br>`Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_H...` | `[29]` **Emmerich Hegel**: "“Then it is time!”" |
| `[17]` | **"“Please, Comrade Hegel. You must remain calm. So many lives would be lost.”"** | `[14]` **Emmerich Hegel**: "“What do you say, Comrade Rayne?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Emmerich Hegel**: "“So many Valgslandian lives are ..." |
| `[24]` | **"“So. Where do we begin?”"** | `[18]` **Emmerich Hegel**: "“Comrade Rayne! It is so good to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "He gestured towards the painting." |
| `[26]` | **"“Likewise.”"** | `[18]` **Emmerich Hegel**: "“Comrade Rayne! It is so good to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "He gestured towards the painting." |
| `[28]` | **"“It's a pleasure to finally meet with you.”"** | `[18]` **Emmerich Hegel**: "“Comrade Rayne! It is so good to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "He gestured towards the painting." |
| `[44]` | **"“What can you tell me about Comrade Malenyev?”"** | `[67]` **Narrator**: "Smoked bear meat, a local delica..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Emmerich Hegel**: "“Ah. You have spotted the portra..." |
| `[48]` | **"“Let's talk about business, shall we?”"** | `[67]` **Narrator**: "Smoked bear meat, a local delica..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Two cups of coffee were brought ..." |
| `[51]` | **"“Thank you for the offer, but there is no need.”"** | `[40]` **Emmerich Hegel**: "“Would you like that?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Emmerich Hegel**: "“Very well.”" |
| `[52]` | **"“Nothing would make me happier. Thank you.”"** | `[40]` **Emmerich Hegel**: "“Would you like that?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = t...` | `[73]` **Emmerich Hegel**: "“Very well.”" |
| `[56]` | **"“It is a reminder. One misstep and we are back to painting the world with more blo..."** | `[49]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Emmerich Hegel**: "“As the leaders of this world, w..." |
| `[58]` | **"“Nothing. It's just a painting.”"** | `[49]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Emmerich Hegel**: "“Certainly a fair viewpoint, Com..." |
| `[60]` | **"“I think that we have come far. After all, we are standing here side by side inste..."** | `[49]` **Emmerich Hegel**: "“What do you think about it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Emmerich Hegel**: "“We can do so much more through ..." |
| `[61]` | **"“Good luck.”"** | `[59]` **Emmerich Hegel**: "“Comrade Rayne, I'm afraid you w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Emmerich Hegel**: "“Thank you.”" |
| `[62]` | **"“Is there anything I can help with?”"** | `[59]` **Emmerich Hegel**: "“Comrade Rayne, I'm afraid you w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Emmerich Hegel**: "“Thank you for the offer, but no.”" |
| `[63]` | **"“Of course, Comrade Hegel. It was a pleasure.”"** | `[59]` **Emmerich Hegel**: "“Comrade Rayne, I'm afraid you w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Emmerich Hegel**: "“The pleasure is mine.”" |
| `[95]` | **"“I would slaughter them the same way they slaughtered us!”"** | `[104]` **Emmerich Hegel**: "“Imagine they did that to the So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Emmerich Hegel**: "“Exactly!”" |
| `[96]` | **"“Comrade Hegel. I urge you to remain calm. No one wants war.”"** | `[104]` **Emmerich Hegel**: "“Imagine they did that to the So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Emmerich Hegel**: "“Valgsland is being attacked!”" |
| `[97]` | **"“I would approach the matter diplomatically. Surely a middle way can be found.”"** | `[104]` **Emmerich Hegel**: "“Imagine they did that to the So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Emmerich Hegel**: "“Middle way?”" |
| `[99]` | **"“It is great to hear these important words coming from you.”"** | `[89]` **Emmerich Hegel**: "“No two countries in this world ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "He nodded and pointed towards an..." |
| `[101]` | **"“Exactly my thoughts.”"** | `[89]` **Emmerich Hegel**: "“No two countries in this world ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "He nodded and pointed towards an..." |
| `[125]` | **"“Very generous. Thank you.”"** | `[114]` **Emmerich Hegel**: "“I had my doubts in the beginnin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Emmerich Hegel**: "“No. Thank you, Comrade Rayne.”" |
| `[126]` | **"“What doubts did you have?”"** | `[114]` **Emmerich Hegel**: "“I had my doubts in the beginnin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Emmerich Hegel**: "“Nothing you should worry about.”" |
| `[129]` | **"“The same goes for me too, Comrade Hegel. Thank you.”"** | `[114]` **Emmerich Hegel**: "“I had my doubts in the beginnin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Emmerich Hegel**: "“What's a deal or two between Va..." |
| `[130]` | **"“Past is past. We need to look into the future.”"** | `[122]` **Emmerich Hegel**: "“The most shameful event in all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Emmerich Hegel**: "“I agree completely.”" |
| `[131]` | **"“Another result of the evils of imperialism.”"** | `[122]` **Emmerich Hegel**: "“The most shameful event in all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Emmerich Hegel**: "“Well said, Comrade Rayne.”" |
| `[132]` | **"“You make good points, Comrade Hegel. Very well. I accept!”"** | `[136]` **Emmerich Hegel**: "“Are you sure about this, Comrad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Emmerich Hegel**: "“Most excellent!”" |
| `[133]` | **"“Sordland can protect itself against threats. I will have to refuse.”"** | `[136]` **Emmerich Hegel**: "“Are you sure about this, Comrad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Emmerich Hegel**: "“I don't understand your reasoni..." |
| `[134]` | **"“We will never forget the extremely shameful display by the Valgslandian navy. ”"** | `[122]` **Emmerich Hegel**: "“The most shameful event in all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Emmerich Hegel**: "“We will never forget the sins o..." |
| `[150]` | **"“Sordland is part of a fragile balance. I don't want to disturb it.""** | `[167]` **Emmerich Hegel**: "“And why is that, Comrade Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Emmerich Hegel**: "“You yourself say that balance i..." |
| `[153]` | **"“I definitely do.”"** | `[65]` **Emmerich Hegel**: "“Sorry about that. You know how ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Emmerich Hegel**: "“Revolution is a slow process, C..." |
| `[158]` | **"“What was that about?”"** | `[65]` **Emmerich Hegel**: "“Sorry about that. You know how ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Emmerich Hegel**: "“A director of a foreign joint-v..." |
| `[160]` | **"“Let's move on with the scheduled program.”"** | `[65]` **Emmerich Hegel**: "“Sorry about that. You know how ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Emmerich Hegel**: "“Sure.”" |
| `[162]` | **"“Although I am ready, Sordland is not. Our countries' past still haunts the minds ..."** | `[167]` **Emmerich Hegel**: "“And why is that, Comrade Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Emmerich Hegel**: "“So you say.”" |
| `[163]` | **"“If an alliance happens, I want it to happen on my terms and at a more opportune t..."** | `[167]` **Emmerich Hegel**: "“And why is that, Comrade Rayne?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Emmerich Hegel**: "“I say the time is now.”" |
| `[169]` | **"“I accept, Comrade Hegel. May this brighten the future of both of our countries!”"** | `[105]` **Emmerich Hegel**: "“What do you say, Comrade Rayne?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Emmerich Hegel**: "“Most excellent!”" |
| `[170]` | **"“Thank you for the offer, Comrade Hegel. However, I will have to refuse.”"** | `[105]` **Emmerich Hegel**: "“What do you say, Comrade Rayne?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Emmerich Hegel**: "“And why is that, Comrade Rayne?”" |
| `[177]` | **"“Nothing to worry about, Comrade Hegel. Everything has been handled.”"** | `[176]` **Emmerich Hegel**: "“I hope everything is alright.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Emmerich Hegel**: "“Very well.”" |
| `[178]` | **"“That is none of your concern, Comrade Hegel.”"** | `[176]` **Emmerich Hegel**: "“I hope everything is alright.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Emmerich Hegel**: "“No need to go on the defensive.”" |
| `[179]` | **"“Let's change the topic.”"** | `[176]` **Emmerich Hegel**: "“I hope everything is alright.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Emmerich Hegel**: "“Very well.”" |

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
  - -> `[4]` (*Narrator: "Upon seeing me, he smiled and opened his arms."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Emmerich Hegel: "“The pleasure is mine.”"*)

### Węzeł `[3]`
Mówca: **Emmerich Hegel**
> "“The pleasure is mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel: "“Have a good day and enjoy Haelm.”"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Upon seeing me, he smiled and opened his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We hugged and he patted me on the shoulder."*)

### Węzeł `[5]`
Mówca: **Emmerich Hegel**
> "“Comrade Rayne. I am planning on invading Heljiland to save Valgslandian people from the clutches of the murderous Agnolian governor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Emmerich Hegel: "“Don't worry. I don't wish to pull Sordland into this con..."*)

### Węzeł `[6]`
Mówca: **Emmerich Hegel**
> "“Don't worry. I don't wish to pull Sordland into this conflict in any way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Emmerich Hegel: "“This is not your battle, after all.”"*)

### Węzeł `[7]`
Mówca: **Emmerich Hegel**
> "“Very well. I won't push further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Hegel looked down for a moment. He walked over to the win..."*)

### Węzeł `[8]`
Mówca: **Emmerich Hegel**
> "“This is not your battle, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Emmerich Hegel: "“What I want from you is simple.”"*)

### Węzeł `[9]`
Mówca: **Emmerich Hegel**
> "“Comrade Malenyev is a good friend of mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Emmerich Hegel: "“Although I don't agree with him on every matter, he dema..."*)

### Węzeł `[10]`
Mówca: **Emmerich Hegel**
> "“What I want from you is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Emmerich Hegel: "“I want you to recognize Heljiland as Valgslandian territ..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "We hugged and he patted me on the shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Emmerich Hegel: "“Comrade Rayne! It is so good to see you. I've wanted to ..."*)

### Węzeł `[12]`
Mówca: **Emmerich Hegel**
> "“I want you to recognize Heljiland as Valgslandian territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Emmerich Hegel: "“If we have Sordland behind our cause, everything will be..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Let's hope we can stay that way.”"]** — Mówca: **Player**
> "“Let's hope we can stay that way.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Emmerich Hegel: "“I am sure we will.”"*)

### Węzeł `[14]`
Mówca: **Emmerich Hegel**
> "“What do you say, Comrade Rayne? Are you with me? I will also provide some minor financial assistance as a fellow traveller.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“I am with you, Comrade Hegel.” [+1 Budget]"*)
  - -> `[15]` (*Player: "“I won't meddle in the affairs between Valgsland and Agno..."*)
  - -> `[17]` (*Player: "“Please, Comrade Hegel. You must remain calm. So many liv..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I won't meddle in the affairs between Valgsland and Agnolia.”"]** — Mówca: **Player**
> "“I won't meddle in the affairs between Valgsland and Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Emmerich Hegel: "“So you'd prefer to stay neutral.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“I am with you, Comrade Hegel.” [+1 Budget]"]** — Mówca: **Player**
> "“I am with you, Comrade Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised = true; BaseGame.A..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Please, Comrade Hegel. You must remain calm. So many lives would be lost.”"]** — Mówca: **Player**
> "“Please, Comrade Hegel. You must remain calm. So many lives would be lost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Emmerich Hegel: "“So many Valgslandian lives are already lost!”"*)

### Węzeł `[18]`
Mówca: **Emmerich Hegel**
> "“Comrade Rayne! It is so good to see you. I've wanted to meet you in person for a long time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“It's a pleasure to finally meet with you.”"*)
  - -> `[26]` (*Player: "“Likewise.”"*)
  - -> `[24]` (*Player: "“So. Where do we begin?”"*)

### Węzeł `[19]`
Mówca: **Emmerich Hegel**
> "“Although I don't agree with him on every matter, he demands respect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Emmerich Hegel: "“Valgslandian Socialism aims to eliminate the power of th..."*)

### Węzeł `[20]`
Mówca: **Emmerich Hegel**
> "“There are two things on my mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "He turned to me."*)

### Węzeł `[21]`
Mówca: **Emmerich Hegel**
> "“So many Valgslandian lives are already lost!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Emmerich Hegel: "“Very well. I will take that as a no.”"*)

### Węzeł `[22]`
Mówca: **Emmerich Hegel**
> "“However, our revolution here in Valgsland owes a great deal to Malenyev. He is the father of Malenyevism and a symbol of global revolution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Emmerich Hegel: "“Not only is he the first communist revolutionary leader ..."*)

### Węzeł `[23]`
Mówca: **Emmerich Hegel**
> "“Very well. I will take that as a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Emmerich Hegel: "“Although I would appreciate the support, our matters are..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“So. Where do we begin?”"]** — Mówca: **Player**
> "“So. Where do we begin?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[25]`
Mówca: **Emmerich Hegel**
> "“Although I would appreciate the support, our matters are not yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Emmerich Hegel: "“I will commence the invasion regardless.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Likewise.”"]** — Mówca: **Player**
> "“Likewise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[27]`
Mówca: **Emmerich Hegel**
> "“I will commence the invasion regardless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "As the assistant collected the empty glasses, he whispere..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's a pleasure to finally meet with you.”"]** — Mówca: **Player**
> "“It's a pleasure to finally meet with you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He gestured towards the painting."*)

### Węzeł `[29]`
Mówca: **Emmerich Hegel**
> "“Then it is time!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Emmerich Hegel: "“We have achieved a lot today, Comrade Rayne.”"*)

### Węzeł `[30]`
Mówca: **Emmerich Hegel**
> "“If we have Sordland behind our cause, everything will be easier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Emmerich Hegel: "“What do you say, Comrade Rayne? Are you with me? I will ..."*)

### Węzeł `[31]`
Mówca: **Emmerich Hegel**
> "“Ah. You have spotted the portrait. Well. Where do I begin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Emmerich Hegel: "“Comrade Malenyev is a good friend of mine.”"*)

### Węzeł `[32]`
Mówca: **Emmerich Hegel**
> "“So you'd prefer to stay neutral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Emmerich Hegel: "“Very well. I respect that.”"*)

### Węzeł `[33]`
Mówca: **Emmerich Hegel**
> "“Comrade Rayne. If you'd like, I can put in a good word for you with Comrade Malenyev. I have the feeling you would get along with him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Emmerich Hegel: "“Would you like that?”"*)

### Węzeł `[34]`
Mówca: **Emmerich Hegel**
> "“Very well. I respect that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Emmerich Hegel: "“Although I would appreciate the support, as you said, ou..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He gestured towards the painting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Emmerich Hegel: "“This was made in 1776 by the famous Valgslandian painter..."*)

### Węzeł `[36]`
Mówca: **Emmerich Hegel**
> "“Although I would appreciate the support, as you said, our matters are not yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Emmerich Hegel: "“I will commence the invasion regardless.”"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Hegel looked down for a moment. He walked over to the window and gazed outside, his arms crossed behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Emmerich Hegel: "“Now that we are allies, I must tell you something.”"*)

### Węzeł `[38]`
Mówca: **Emmerich Hegel**
> "“This was made in 1776 by the famous Valgslandian painter, Otto Kiebern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "I looked at the painting. It must've been over five meter..."*)

### Węzeł `[39]`
Mówca: **Emmerich Hegel**
> "“We have achieved a lot today, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Emmerich Hegel: "“Another!”"*)

### Węzeł `[40]`
Mówca: **Emmerich Hegel**
> "“Would you like that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“Nothing would make me happier. Thank you.”"*)
  - -> `[51]` (*Player: "“Thank you for the offer, but there is no need.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The assistant immediately showed up with two more shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Agnolia", "Un..."*)

### Węzeł `[42]`
Mówca: **Emmerich Hegel**
> "“Another!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The assistant immediately showed up with two more shots o..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "I looked at the painting. It must've been over five meters tall. It was a battle scene. On the left side, there were banners carried by Valgs; on the right, Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Countless spears formed a triangle at the center. The sky..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“What can you tell me about Comrade Malenyev?”"]** — Mówca: **Player**
> "“What can you tell me about Comrade Malenyev?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Emmerich Hegel: "“Ah. You have spotted the portrait. Well. Where do I begin?”"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "We gulped down the shots after clinking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "As the assistant collected the empty glasses, he whispere..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Countless spears formed a triangle at the center. The sky was red from the blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Emmerich Hegel: "“What do you think about it?”"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised = true;
BaseGame.Agnolia_HeljilandRecognised = false;
BaseGame.GovernmentBudget += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] = true;
Variable["BaseGame.Agnolia_HeljilandRecognised"] = false;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRe..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Let's talk about business, shall we?”"]** — Mówca: **Player**
> "“Let's talk about business, shall we?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Two cups of coffee were brought by an assistant. I took a..."*)

### Węzeł `[49]`
Mówca: **Emmerich Hegel**
> "“What do you think about it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“I think that we have come far. After all, we are standin..."*)
  - -> `[58]` (*Player: "“Nothing. It's just a painting.”"*)
  - -> `[56]` (*Player: "“It is a reminder. One misstep and we are back to paintin..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "As the assistant collected the empty glasses, he whispered into Hegel's ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "His eyes widened and he clenched his fists in anger."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Thank you for the offer, but there is no need.”"]** — Mówca: **Player**
> "“Thank you for the offer, but there is no need.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Emmerich Hegel: "“Very well.”"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“Nothing would make me happier. Thank you.”"]** — Mówca: **Player**
> "“Nothing would make me happier. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev = true; BaseGam..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "His eyes widened and he clenched his fists in anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Emmerich Hegel: "“The Agnolians did what?!”"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal =..."*)

### Węzeł `[55]`
Mówca: **Emmerich Hegel**
> "“The Agnolians did what?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "He composed himself and smiled at me."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“It is a reminder. One misstep and we are back to painting the world with more blood.”"]** — Mówca: **Player**
> "“It is a reminder. One misstep and we are back to painting the world with more blood.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Emmerich Hegel: "“As the leaders of this world, we must be careful, Comrad..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "He composed himself and smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Emmerich Hegel: "“Comrade Rayne, I'm afraid you will have to excuse me. Th..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Nothing. It's just a painting.”"]** — Mówca: **Player**
> "“Nothing. It's just a painting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Emmerich Hegel: "“Certainly a fair viewpoint, Comrade Rayne.”"*)

### Węzeł `[59]`
Mówca: **Emmerich Hegel**
> "“Comrade Rayne, I'm afraid you will have to excuse me. There is a matter I need to attend to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“Of course, Comrade Hegel. It was a pleasure.”"*)
  - -> `[62]` (*Player: "“Is there anything I can help with?”"*)
  - -> `[61]` (*Player: "“Good luck.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I think that we have come far. After all, we are standing here side by side instead of facing each other a battlefield.”"]** — Mówca: **Player**
> "“I think that we have come far. After all, we are standing here side by side instead of facing each other a battlefield.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Emmerich Hegel: "“We can do so much more through unity, Comrade Rayne.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Emmerich Hegel: "“Thank you.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Is there anything I can help with?”"]** — Mówca: **Player**
> "“Is there anything I can help with?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Emmerich Hegel: "“Thank you for the offer, but no.”"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Of course, Comrade Hegel. It was a pleasure.”"]** — Mówca: **Player**
> "“Of course, Comrade Hegel. It was a pleasure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Emmerich Hegel: "“The pleasure is mine.”"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev = true;
BaseGame.Malenyevist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Emmerich Hegel: "“Very well.”"*)

### Węzeł `[65]`
Mówca: **Emmerich Hegel**
> "“Sorry about that. You know how it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: "“I definitely do.”"*)
  - -> `[158]` (*Player: "“What was that about?”"*)
  - -> `[160]` (*Player: "“Let's move on with the scheduled program.”"*)

### Węzeł `[66]`
Mówca: **Emmerich Hegel**
> "“Thank you for the offer, but no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel: "“Have a good day and enjoy Haelm.”"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Smoked bear meat, a local delicacy, was served with eggs. After a very delicious meal we sat down on two couches. I immediately saw the portrait of Leon "Malenyev" Chavatangakwunua staring down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“What can you tell me about Comrade Malenyev?”"*)
  - -> `[48]` (*Player: "“Let's talk about business, shall we?”"*)

### Węzeł `[68]`
Mówca: **Emmerich Hegel**
> "“As the leaders of this world, we must be careful, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Emmerich Hegel: "“Especially around those who are willing and ready to do ..."*)

### Węzeł `[69]`
Mówca: **Emmerich Hegel**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel: "“Have a good day and enjoy Haelm.”"*)

### Węzeł `[70]`
Mówca: **Emmerich Hegel**
> "“Certainly a fair viewpoint, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "We started walking."*)

### Węzeł `[71]`
Mówca: **Emmerich Hegel**
> "“We can do so much more through unity, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "We started walking."*)

### Węzeł `[72]`
Mówca: **Emmerich Hegel**
> "“Have a good day and enjoy Haelm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "We shook hands and Hegel left in a hurry."*)

### Węzeł `[73]`
Mówca: **Emmerich Hegel**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Two cups of coffee were brought by an assistant. I took a..."*)

### Węzeł `[74]`
Mówca: **Emmerich Hegel**
> "“Especially around those who are willing and ready to do precisely that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "We started walking."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "We shook hands and Hegel left in a hurry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Emmerich Hegel: "“I think you and I are like-minded people, Comrade Rayne.”"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "We made our way to the exquisite dining room. I looked around at the tableware. Everything seemed to be colored gold, blue and white."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Smoked bear meat, a local delicacy, was served with eggs...."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "He turned to me and put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Emmerich Hegel: "“Comrade Rayne. I am planning on invading Heljiland to sa..."*)

### Węzeł `[79]`
Mówca: **Emmerich Hegel**
> "“If they want to mess with Valgsland, they will see our might!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "He turned to me and put his hand on my shoulder."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Two cups of coffee were brought by an assistant. I took a sip while he lit his pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Emmerich Hegel: "“Let's begin, then.”"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Emmerich Hegel: "“To me, this painting tells me how far we have come. Sord..."*)

### Węzeł `[82]`
Mówca: **Emmerich Hegel**
> "“I don't understand your reasoning, but perhaps you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Emmerich Hegel: "“Very well. I won't push further.”"*)

### Węzeł `[83]`
Mówca: **Emmerich Hegel**
> "“I do not know how much longer I can show restraint.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Emmerich Hegel: "“If they want to mess with Valgsland, they will see our m..."*)

### Węzeł `[84]`
Mówca: **Emmerich Hegel**
> "“How can I stay calm?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Emmerich Hegel: "“If they want to mess with Valgsland, they will see our m..."*)

### Węzeł `[85]`
Mówca: **Emmerich Hegel**
> "“Agnolia clearly wants war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Emmerich Hegel: "“How can I stay calm?”"*)

### Węzeł `[86]`
Mówca: **Emmerich Hegel**
> "“To me, this painting tells me how far we have come. Sords and Valgs may have had our troubles, but ultimately, we are brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Emmerich Hegel: "“No two countries in this world understand each other more.”"*)

### Węzeł `[87]`
Mówca: **Emmerich Hegel**
> "“Let's begin, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Emmerich Hegel: "“Now, before you say anything...”"*)

### Węzeł `[88]`
Mówca: **Emmerich Hegel**
> "“The window for diplomatic action is closing, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Emmerich Hegel: "“I do not know how much longer I can show restraint.""*)

### Węzeł `[89]`
Mówca: **Emmerich Hegel**
> "“No two countries in this world understand each other more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“Exactly my thoughts.”"*)
  - -> `[99]` (*Player: "“It is great to hear these important words coming from you.”"*)
  - -> `[13]` (*Player: "“Let's hope we can stay that way.”"*)

### Węzeł `[90]`
Mówca: **Emmerich Hegel**
> "“Follow me. We will have a short breakfast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We made our way to the exquisite dining room. I looked ar..."*)

### Węzeł `[91]`
Mówca: **Emmerich Hegel**
> "“Now, before you say anything...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Emmerich Hegel: "“I think you will be glad to hear that I accept the deal.”"*)

### Węzeł `[92]`
Mówca: **Emmerich Hegel**
> "“Valgsland is being attacked!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Emmerich Hegel: "“Agnolia clearly wants war.”"*)

### Węzeł `[93]`
Mówca: **Emmerich Hegel**
> "“Exactly!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Emmerich Hegel: "“I do not know how much longer I can show restraint.""*)

### Węzeł `[94]`
Mówca: **Emmerich Hegel**
> "“Middle way?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Emmerich Hegel: "“The window for diplomatic action is closing, Comrade Ray..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I would slaughter them the same way they slaughtered us!”"]** — Mówca: **Player**
> "“I would slaughter them the same way they slaughtered us!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Emmerich Hegel: "“Exactly!”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Comrade Hegel. I urge you to remain calm. No one wants war.”"]** — Mówca: **Player**
> "“Comrade Hegel. I urge you to remain calm. No one wants war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Emmerich Hegel: "“Valgsland is being attacked!”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“I would approach the matter diplomatically. Surely a middle way can be found.”"]** — Mówca: **Player**
> "“I would approach the matter diplomatically. Surely a middle way can be found.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Emmerich Hegel: "“Middle way?”"*)

### Węzeł `[98]`
Mówca: **Emmerich Hegel**
> "“I think you and I are like-minded people, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Emmerich Hegel: "“I would like to solidify our newfound friendship and adm..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“It is great to hear these important words coming from you.”"]** — Mówca: **Player**
> "“It is great to hear these important words coming from you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "He nodded and pointed towards another painting that was a..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "After receiving the order, the guard hastily left. Hegel walked over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Emmerich Hegel: "“Sorry about that. You know how it is.”"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Exactly my thoughts.”"]** — Mówca: **Player**
> "“Exactly my thoughts.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "He nodded and pointed towards another painting that was a..."*)

### Węzeł `[102]`
Mówca: **Emmerich Hegel**
> "“I think you will be glad to hear that I accept the deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal = true"*)

### Węzeł `[103]`
Mówca: **Emmerich Hegel**
> "“I would like to solidify our newfound friendship and admiration with a military alliance between Valgsland and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Emmerich Hegel: "“A pact that connects our two nations. No! It's much more..."*)

### Węzeł `[104]`
Mówca: **Emmerich Hegel**
> "“Imagine they did that to the Sordish people. What would you do, Comrade Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“Comrade Hegel. I urge you to remain calm. No one wants w..."*)
  - -> `[95]` (*Player: "“I would slaughter them the same way they slaughtered us!”"*)
  - -> `[97]` (*Player: "“I would approach the matter diplomatically. Surely a mid..."*)

### Węzeł `[105]`
Mówca: **Emmerich Hegel**
> "“What do you say, Comrade Rayne? Are you ready to achieve greatness with me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“I accept, Comrade Hegel. May this brighten the future of..."*)
  - -> `[170]` (*Player: "“Thank you for the offer, Comrade Hegel. However, I will ..."*)

### Węzeł `[106]`
Mówca: **Emmerich Hegel**
> "“As if their occupation is not enough, they kill my people in their homes in Heljiland. Slaughtering them like mere cattle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Emmerich Hegel: "“Imagine they did that to the Sordish people. What would ..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "He nodded and pointed towards another painting that was almost as large as the first one. A burning city was depicted. Looking closer, I realized it was Conriat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Emmerich Hegel: "“The Great Fire of Conriat.”"*)

### Węzeł `[108]`
Mówca: **Emmerich Hegel**
> "“I have had it with those damn Agnolians who claim *our* land as their own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Emmerich Hegel: "“As if their occupation is not enough, they kill my peopl..."*)

### Węzeł `[109]`
Mówca: **Emmerich Hegel**
> "“I am sure we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He pointed towards another painting that was almost as la..."*)

### Węzeł `[110]`
Mówca: **Emmerich Hegel**
> "“Now that we are allies, I must tell you something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Emmerich Hegel: "“I have had it with those damn Agnolians who claim *our* ..."*)

### Węzeł `[111]`
Mówca: **Emmerich Hegel**
> "“Revolution is a slow process, Comrade Rayne. Slow but sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[112]`
Mówca: **Emmerich Hegel**
> "“Now that that's out of the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Emmerich Hegel: "“There are two things on my mind.”"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He pointed towards another painting that was almost as large as the first one. A burning city was depicted. Looking closer, I realized it was Conriat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Emmerich Hegel: "“The Great Fire of Conriat.”"*)

### Węzeł `[114]`
Mówca: **Emmerich Hegel**
> "“I had my doubts in the beginning, but they disappeared once I met you in person.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "“The same goes for me too, Comrade Hegel. Thank you.”"*)
  - -> `[126]` (*Player: "“What doubts did you have?”"*)
  - -> `[125]` (*Player: "“Very generous. Thank you.”"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "The strong bite of alcohol turned into a sweeter aftertaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Hegel looked down for a moment. He walked over to the win..."*)

### Węzeł `[116]`
Mówca: **Emmerich Hegel**
> "“A pact that connects our two nations. No! It's much more than that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Emmerich Hegel: "“A sign that unity between Valgs and Sords has finally ar..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "We clinked the glasses and drank our shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "The strong bite of alcohol turned into a sweeter aftertaste."*)

### Węzeł `[118]`
Mówca: **Emmerich Hegel**
> "“The Great Fire of Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Emmerich Hegel: "“The most shameful event in all of Valgslandian history. ..."*)

### Węzeł `[119]`
Mówca: **Emmerich Hegel**
> "“In Valgsland we drink on a contract, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "We clinked the glasses and drank our shots."*)

### Węzeł `[120]`
Mówca: **Emmerich Hegel**
> "“No one can exploit our people and expect to get away with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "After receiving the order, the guard hastily left. Hegel ..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "He called out to a nearby assistant. A moment later, the assistant returned with two shots of vodka."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Emmerich Hegel: "“In Valgsland we drink on a contract, Comrade Rayne.”"*)

### Węzeł `[122]`
Mówca: **Emmerich Hegel**
> "“The most shameful event in all of Valgslandian history. The scars of it must still sting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“Another result of the evils of imperialism.”"*)
  - -> `[130]` (*Player: "“Past is past. We need to look into the future.”"*)
  - -> `[134]` (*Player: "“We will never forget the extremely shameful display by t..."*)

### Węzeł `[123]`
Mówca: **Emmerich Hegel**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Valgsland_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance = ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Very generous. Thank you.”"]** — Mówca: **Player**
> "“Very generous. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Emmerich Hegel: "“No. Thank you, Comrade Rayne.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“What doubts did you have?”"]** — Mówca: **Player**
> "“What doubts did you have?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Emmerich Hegel: "“Nothing you should worry about.”"*)

### Węzeł `[127]`
Mówca: **Emmerich Hegel**
> "“Most excellent!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Lespia", "Unf..."*)

### Węzeł `[128]`
Mówca: **Emmerich Hegel**
> "“I think it is time to bury the hatchet. But I also understand where you are coming from.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Emmerich Hegel: "“As you know, the rogue state of Rumburg is on the move.”"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“The same goes for me too, Comrade Hegel. Thank you.”"]** — Mówca: **Player**
> "“The same goes for me too, Comrade Hegel. Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Emmerich Hegel: "“What's a deal or two between Valgsland and Sordland? We ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Past is past. We need to look into the future.”"]** — Mówca: **Player**
> "“Past is past. We need to look into the future.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Emmerich Hegel: "“I agree completely.”"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Another result of the evils of imperialism.”"]** — Mówca: **Player**
> "“Another result of the evils of imperialism.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Emmerich Hegel: "“Well said, Comrade Rayne.”"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“You make good points, Comrade Hegel. Very well. I accept!”"]** — Mówca: **Player**
> "“You make good points, Comrade Hegel. Very well. I accept!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Emmerich Hegel: "“Most excellent!”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Sordland can protect itself against threats. I will have to refuse.”"]** — Mówca: **Player**
> "“Sordland can protect itself against threats. I will have to refuse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Emmerich Hegel: "“I don't understand your reasoning, but perhaps you are r..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“We will never forget the extremely shameful display by the Valgslandian navy. ”"]** — Mówca: **Player**
> "“We will never forget the extremely shameful display by the Valgslandian navy. ”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Emmerich Hegel: "“We will never forget the sins of our fathers.”"*)

### Węzeł `[135]`
Mówca: **Emmerich Hegel**
> "“A director of a foreign joint-venture mining corporation decided not to pay his miners their salary for two consecutive months. He will be handled.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Emmerich Hegel: "“Revolution is a slow process, Comrade Rayne. Slow but su..."*)

### Węzeł `[136]`
Mówca: **Emmerich Hegel**
> "“Are you sure about this, Comrade Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "“You make good points, Comrade Hegel. Very well. I accept!”"*)
  - -> `[133]` (*Player: "“Sordland can protect itself against threats. I will have..."*)

### Węzeł `[137]`
Mówca: **Emmerich Hegel**
> "“A sign that unity between Valgs and Sords has finally arrived!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "He clenched his fist and looked at me."*)

### Węzeł `[138]`
Mówca: **Emmerich Hegel**
> "“I am offering a helping hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Emmerich Hegel: "“Are you sure about this, Comrade Rayne?”"*)

### Węzeł `[139]`
Mówca: **Emmerich Hegel**
> "“Give the miners what they want. As for the director of the company, I want him to face a trial for undermining the workers of Valgsland. Relay it to the Minister of Justice at once!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Emmerich Hegel: "“No one can exploit our people and expect to get away wit..."*)

### Węzeł `[140]`
Mówca: **Emmerich Hegel**
> "“If you want to protect your country against what might come next, you will need allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Emmerich Hegel: "“I am offering a helping hand.”"*)

### Węzeł `[141]`
Mówca: **Emmerich Hegel**
> "“We will never forget the sins of our fathers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Emmerich Hegel: "“Thankfully, we in Valgsland have now cut off the head of..."*)

### Węzeł `[142]`
Mówca: **Emmerich Hegel**
> "“As you know, the rogue state of Rumburg is on the move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Emmerich Hegel: "“If you want to protect your country against what might c..."*)

### Węzeł `[143]`
Mówca: **Emmerich Hegel**
> "“Well said, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Emmerich Hegel: "“Thankfully, we in Valgsland have now cut off the head of..."*)

### Węzeł `[144]`
Mówca: **Emmerich Hegel**
> "“I agree completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Emmerich Hegel: "“Thankfully, we in Valgsland have now cut off the head of..."*)

### Węzeł `[145]`
Mówca: **Emmerich Hegel**
> "“No. Thank you, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Emmerich Hegel: "“I will sign the papers shortly.”"*)

### Węzeł `[146]`
Mówca: **Emmerich Hegel**
> "“Our two countries have never been closer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Emmerich Hegel: "“As you know, the rogue state of Rumburg is on the move.”"*)

### Węzeł `[147]`
Mówca: **Emmerich Hegel**
> "“Nothing you should worry about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Emmerich Hegel: "“I will sign the papers shortly.”"*)

### Węzeł `[148]`
Mówca: **Emmerich Hegel**
> "“What's a deal or two between Valgsland and Sordland? We have so much more possibility between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Emmerich Hegel: "“I will sign the papers shortly.”"*)

### Węzeł `[149]`
Mówca: **Emmerich Hegel**
> "“If it tips to the wrong side, Valgsland may be your only way out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Emmerich Hegel: "“As you know, the rogue state of Rumburg is on the move.”"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Sordland is part of a fragile balance. I don't want to disturb it.""]** — Mówca: **Player**
> "“Sordland is part of a fragile balance. I don't want to disturb it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Emmerich Hegel: "“You yourself say that balance is fragile. It will tip no..."*)

### Węzeł `[151]`
Mówca: **Emmerich Hegel**
> "“If not now, when?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Emmerich Hegel: "“Our two countries have never been closer.”"*)

### Węzeł `[152]`
Mówca: **Emmerich Hegel**
> "“Thankfully, we in Valgsland have now cut off the head of the snake called imperialism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "A guard approached the Chancellor."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I definitely do.”"]** — Mówca: **Player**
> "“I definitely do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Emmerich Hegel: "“Revolution is a slow process, Comrade Rayne. Slow but su..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "A guard approached the Chancellor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Emmerich Hegel: "“If you will excuse me for one minute.”"*)

### Węzeł `[155]`
Mówca: **Emmerich Hegel**
> "“You yourself say that balance is fragile. It will tip no matter what you do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Emmerich Hegel: "“If it tips to the wrong side, Valgsland may be your only..."*)

### Węzeł `[156]`
Mówca: **Emmerich Hegel**
> "“So you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Emmerich Hegel: "“I think it is time to bury the hatchet. But I also under..."*)

### Węzeł `[157]`
Mówca: **Emmerich Hegel**
> "“I say the time is now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Emmerich Hegel: "“If not now, when?”"*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“What was that about?”"]** — Mówca: **Player**
> "“What was that about?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Emmerich Hegel: "“A director of a foreign joint-venture mining corporation..."*)

### Węzeł `[159]`
Mówca: **Emmerich Hegel**
> "“If you will excuse me for one minute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "The chancellor stepped away with the guard while I looked..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Let's move on with the scheduled program.”"]** — Mówca: **Player**
> "“Let's move on with the scheduled program.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Emmerich Hegel: "“Sure.”"*)

### Węzeł `[161]`
Mówca: **Emmerich Hegel**
> "“What did you say?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Hegel's loud voice echoed in the empty halls."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“Although I am ready, Sordland is not. Our countries' past still haunts the minds of my people.”"]** — Mówca: **Player**
> "“Although I am ready, Sordland is not. Our countries' past still haunts the minds of my people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Emmerich Hegel: "“So you say.”"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“If an alliance happens, I want it to happen on my terms and at a more opportune time.”"]** — Mówca: **Player**
> "“If an alliance happens, I want it to happen on my terms and at a more opportune time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Emmerich Hegel: "“I say the time is now.”"*)

### Węzeł `[164]`
Mówca: **Narrator**
> "The chancellor stepped away with the guard while I looked around. I saw a more recent painting, depicting the upheaval of farmers against an aristocrat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Emmerich Hegel: "“What did you say?!”"*)

### Węzeł `[165]`
Mówca: **Emmerich Hegel**
> "“I will sign the papers shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He got up from his seat, walked over to the window and lo..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "Hegel's loud voice echoed in the empty halls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Emmerich Hegel: "“Give the miners what they want. As for the director of t..."*)

### Węzeł `[167]`
Mówca: **Emmerich Hegel**
> "“And why is that, Comrade Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“Sordland is part of a fragile balance. I don't want to d..."*)
  - -> `[162]` (*Player: "“Although I am ready, Sordland is not. Our countries' pas..."*)
  - -> `[163]` (*Player: "“If an alliance happens, I want it to happen on my terms ..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "He clenched his fist and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Emmerich Hegel: "“What do you say, Comrade Rayne? Are you ready to achieve..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“I accept, Comrade Hegel. May this brighten the future of both of our countries!”"]** — Mówca: **Player**
> "“I accept, Comrade Hegel. May this brighten the future of both of our countries!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Emmerich Hegel: "“Most excellent!”"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Thank you for the offer, Comrade Hegel. However, I will have to refuse.”"]** — Mówca: **Player**
> "“Thank you for the offer, Comrade Hegel. However, I will have to refuse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Emmerich Hegel: "“And why is that, Comrade Rayne?”"*)

### Węzeł `[171]`
Mówca: **Narrator**
> "He got up from his seat, walked over to the window and looked outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Emmerich Hegel: "“Now that that's out of the way.”"*)

### Węzeł `[172]`
Mówca: **Emmerich Hegel**
> "“I hear there is still an emergency declared in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Emmerich Hegel: "“I hope everything is alright.”"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Emmerich Hegel: "“I hear there is still an emergency declared in Sordland.”"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Emmerich Hegel: "“Follow me. We will have a short breakfast.”"*)

### Węzeł `[176]`
Mówca: **Emmerich Hegel**
> "“I hope everything is alright.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: "“Nothing to worry about, Comrade Hegel. Everything has be..."*)
  - -> `[178]` (*Player: "“That is none of your concern, Comrade Hegel.”"*)
  - -> `[179]` (*Player: "“Let's change the topic.”"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“Nothing to worry about, Comrade Hegel. Everything has been handled.”"]** — Mówca: **Player**
> "“Nothing to worry about, Comrade Hegel. Everything has been handled.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Emmerich Hegel: "“Very well.”"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“That is none of your concern, Comrade Hegel.”"]** — Mówca: **Player**
> "“That is none of your concern, Comrade Hegel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Emmerich Hegel: "“No need to go on the defensive.”"*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“Let's change the topic.”"]** — Mówca: **Player**
> "“Let's change the topic.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Emmerich Hegel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Emmerich Hegel: "“Very well.”"*)

### Węzeł `[180]`
Mówca: **Emmerich Hegel**
> "“No need to go on the defensive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Emmerich Hegel: "“I get the signal, Comrade Rayne.”"*)

### Węzeł `[181]`
Mówca: **Emmerich Hegel**
> "“I get the signal, Comrade Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Emmerich Hegel: "“Follow me. We will have a short breakfast.”"*)

### Węzeł `[182]`
Mówca: **Emmerich Hegel**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Emmerich Hegel: "“Follow me. We will have a short breakfast.”"*)

### Węzeł `[183]`
Mówca: **Emmerich Hegel**
> "“Valgslandian Socialism aims to eliminate the power of the state by promoting the responsibility, freedom and well-being of the people. One of our key cornerstones is the devolution of big government to smaller councils with high citizen participation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Emmerich Hegel: "“We believe that the revolution in Valgsland is stable en..."*)

### Węzeł `[184]`
Mówca: **Emmerich Hegel**
> "“We believe that the revolution in Valgsland is stable enough that we do not need the vanguardist approach of Malenyevism. We are already in the process of such a transformation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Emmerich Hegel: "“However, our revolution here in Valgsland owes a great d..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_TradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Emmerich Hegel: "“I had my doubts in the beginning, but they disappeared o..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "He called out to a nearby assistant. A moment later, the ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_HeljilandRecognized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Emmerich Hegel: "“Then it is time!”"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Agnolia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Agnolia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "We gulped down the shots after clinking."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Lespia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Lespia","Unfriendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Valgsland", "..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Valgsland", "Allied");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Valgsland","Allied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance = true"*)

### Węzeł `[191]`
Mówca: **Emmerich Hegel**
> "“Not only is he the first communist revolutionary leader of the world, he managed to unite a whole continent, forming the greatest country in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Emmerich Hegel: "“Comrade Rayne. If you'd like, I can put in a good word f..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "Hegel looked down for a moment. He walked over to the window and gazed outside, his arms crossed behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Emmerich Hegel: "“Even if you're not with us, I will tell you something yo..."*)

### Węzeł `[193]`
Mówca: **Emmerich Hegel**
> "“Even if you're not with us, I will tell you something you may want to know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Emmerich Hegel: "“I have had it with those damn Agnolians who claim *our* ..."*)
