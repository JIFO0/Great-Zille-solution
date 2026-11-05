# Rizia/Turn 8/VINA ESCAPES

- **ID konwersacji:** `415`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/415_VINA_ESCAPES.md`
- **Liczba węzłów dialogowych:** 176
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Law_Homosexuality_Banned`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement`
- `RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[414] Rizia/Turn 8/P_NightBeforeWedding** (../Turn_08/414_P_NightBeforeWedding.md), Węzeł `[784]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""Seating arrangements? Is that a euphemism for something?""** | `[8]` **Narrator**: "Titus shadowed us as Pabel steer..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[21]` **Narrator**: "He shook his head briskly and wi..." |
| `[13]` | **""I need to check in on Vina.""** | `[8]` **Narrator**: "Titus shadowed us as Pabel steer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Pabel Adria**: ""This will only be a moment."" |
| `[17]` | **""This had better be quick.""** | `[8]` **Narrator**: "Titus shadowed us as Pabel steer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Pabel Adria**: ""It will be. Hopefully."" |
| `[18]` | **""Can't you figure it out yourself?""** | `[8]` **Narrator**: "Titus shadowed us as Pabel steer..." | `Variable["RiziaDLC.Vina_Engaged"] == true` | *Brak zmian stanu* | `[19]` **Pabel Adria**: ""I've been trying."" |
| `[27]` | **""Easy. Going clockwise, it's Agard, Qinal, Nahrburk, Free Cities.""** | `[26]` **Pabel Adria**: ""The Qinali, meanwhile, would li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Pabel made a note." |
| `[28]` | **""Right. How about Free Cities, Nahrburk, Agard, Qinal?""** | `[26]` **Pabel Adria**: ""The Qinali, meanwhile, would li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Pabel made a note." |
| `[29]` | **""From the top of the table, it's Narhburk, Qinal, Agard, Free Cities.""** | `[26]` **Pabel Adria**: ""The Qinali, meanwhile, would li..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWedd...` | `[32]` **Narrator**: "Pabel made a note." |
| `[30]` | **""I have no idea. Ask someone else.""** | `[26]` **Pabel Adria**: ""The Qinali, meanwhile, would li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Pabel Adria**: ""I'm sorry, Your Majesty. I was ..." |
| `[40]` | **""That just means you're getting old, Pabel.""** | `[35]` **Pabel Adria**: ""This must be a very emotional t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "From just down the hall, I heard..."<br>`[47]` **Narrator**: "I detected a slight nervous quiv..." |
| `[44]` | **""There's nothing romantic about tomorrow. It's a political event, nothing more.""** | `[35]` **Pabel Adria**: ""This must be a very emotional t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "From just down the hall, I heard..."<br>`[47]` **Narrator**: "I detected a slight nervous quiv..." |
| `[45]` | **""I still have the congratulatory cigar you gave me. You must have saved up for it ..."** | `[35]` **Pabel Adria**: ""This must be a very emotional t..." | `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true` | *Brak zmian stanu* | `[53]` **Pabel Adria**: ""Lespia's finest. The import tax..." |
| `[46]` | **""All sparrows have to leave the nest sometime.""** | `[35]` **Pabel Adria**: ""This must be a very emotional t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "From just down the hall, I heard..."<br>`[47]` **Narrator**: "I detected a slight nervous quiv..." |
| `[49]` | **""Huh. You were there?""** | `[35]` **Pabel Adria**: ""This must be a very emotional t..." | `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false` | *Brak zmian stanu* | `[54]` **Pabel Adria**: ""I was serving just beneath the ..." |
| `[55]` | **""Was this really such an urgent matter?""** | `[47]` **Narrator**: "I detected a slight nervous quiv..."<br>`[48]` **Narrator**: "From just down the hall, I heard..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Pabel Adria**: ""No, I suppose it wasn't. Forgiv..." |
| `[56]` | **""I have to go.""** | `[47]` **Narrator**: "I detected a slight nervous quiv..."<br>`[48]` **Narrator**: "From just down the hall, I heard..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Pabel Adria**: ""Very well. I've gotten all your..." |
| `[57]` | **""Pabel, where is Vina?""** | `[47]` **Narrator**: "I detected a slight nervous quiv..."<br>`[48]` **Narrator**: "From just down the hall, I heard..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Pabel Adria**: ""She's been in her room this ent..." |
| `[67]` | **""WHERE IS SHE?!""** | `[66]` **Narrator**: "I went inside and saw that the w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Estela Toras**: ""I... I don't know."" |
| `[68]` | **"Look out the window."** | `[66]` **Narrator**: "I went inside and saw that the w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Estela Toras**: ""I... I have no idea what happen..." |
| `[69]` | **""Did you let her run away?""** | `[66]` **Narrator**: "I went inside and saw that the w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Estela Toras**: ""No, of course not!"" |
| `[80]` | **""We're hosting a diplomatic luncheon?""** | `[8]` **Narrator**: "Titus shadowed us as Pabel steer..." | `(Variable["RiziaDLC.Vina_Engaged"] == true) == false` | *Brak zmian stanu* | `[81]` **Pabel Adria**: ""Apparently, yes."" |
| `[83]` | **""You're lying. I heard her talking to someone in there.""** | `[73]` **Estela Toras**: ""I came here to give her some mo..."<br>`[82]` **Estela Toras**: ""I knew she'd been feeling down ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Estela Toras**: ""Interesting. Perhaps she was on..." |
| `[84]` | **""TITUS! FIND HER!""** | `[73]` **Estela Toras**: ""I came here to give her some mo..."<br>`[82]` **Estela Toras**: ""I knew she'd been feeling down ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Titus Gordion**: ""I'm already on it, Your Majesty."" |
| `[85]` | **""She can't have gone far. The palace grounds are under heavy security.""** | `[73]` **Estela Toras**: ""I came here to give her some mo..."<br>`[82]` **Estela Toras**: ""I knew she'd been feeling down ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Titus Gordion**: ""I'm communicating with my fello..." |
| `[89]` | **""If she didn't want to get married, she could have just told me.""** | `[73]` **Estela Toras**: ""I came here to give her some mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Estela Toras**: ""She did tell you, Romus."" |
| `[90]` | **""If she wasn't happy, she could have just told me.""** | `[82]` **Estela Toras**: ""I knew she'd been feeling down ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Estela Toras**: ""She did tell you, Romus."" |
| `[95]` | **""Track him down. See that he gets what's coming to him.""** | `[98]` **Titus Gordion**: ""I tried to reach him, but he's ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[105]` **Titus Gordion**: ""I'll try my best, Your Majesty."" |
| `[96]` | **""You have to find him, Titus. I want my daughter back.""** | `[98]` **Titus Gordion**: ""I tried to reach him, but he's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Titus Gordion**: ""I'll try my best, Your Majesty."" |
| `[97]` | **""So she had an accomplice. I thought you Golden Guards were incorruptible.""** | `[98]` **Titus Gordion**: ""I tried to reach him, but he's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Estela Toras**: ""Everybody has a weakness, darli..." |
| `[102]` | **""It's that easy for someone to escape the palace?!""** | `[98]` **Titus Gordion**: ""I tried to reach him, but he's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Titus Gordion**: ""Your Majesty, Palas Rezna's sec..." |
| `[111]` | **""Pabel had a hand in this, didn't he? Where did he go?""** | `[110]` **Narrator**: "He dashed out, leaving me alone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "My mother shrugged." |
| `[112]` | **""Seriously, Mother. Did you help her escape?""** | `[110]` **Narrator**: "He dashed out, leaving me alone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Estela Toras**: ""How many times must I tell you?..." |
| `[116]` | **""Tell me where she is, or I'll tell everyone you're a Dastnurist.""** | `[110]` **Narrator**: "He dashed out, leaving me alone ..." | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true` | *Brak zmian stanu* | `[121]` **Estela Toras**: ""Go on, then. I honestly don't k..." |
| `[117]` | **""What the hell am I supposed to do now?""** | `[110]` **Narrator**: "He dashed out, leaving me alone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "My mother shrugged." |
| `[131]` | **""Shit. All that wartime sympathy, literally out the window.""** | `[127]` **Estela Toras**: ""Your real problem is telling th..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[157]` **Estela Toras**: ""Not to mention our family's lin..." |
| `[137]` | **""This is just cold feet. She'll come back eventually.""** | `[127]` **Estela Toras**: ""Your real problem is telling th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Estela Toras**: ""If she doesn't, it'll be the en..." |
| `[138]` | **""If Titus does manage to track her down, I'll have her beheaded.""** | `[127]` **Estela Toras**: ""Your real problem is telling th..."<br>`[128]` **Estela Toras**: ""Your real problem is explaining..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[160]` **Estela Toras**: ""If you do, that'll be the end o..." |
| `[142]` | **""They'll make me look like a monster.""** | `[128]` **Estela Toras**: ""Your real problem is explaining..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Estela Toras**: ""What's more, our family's line ..." |
| `[143]` | **""This is just a tantrum. I'm sure she'll come back eventually.""** | `[128]` **Estela Toras**: ""Your real problem is explaining..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Estela Toras**: ""If she doesn't, it'll be the en..." |
| `[147]` | **""And Hugo. What do I tell Hugo?""** | `[127]` **Estela Toras**: ""Your real problem is telling th..." | `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true` | *Brak zmian stanu* | `[155]` **Estela Toras**: ""You tell him that he's your new..." |
| `[151]` | **""And Axel. What do I tell Axel?""** | `[127]` **Estela Toras**: ""Your real problem is telling th..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false` | *Brak zmian stanu* | `[154]` **Estela Toras**: ""You tell him that the Rizia-Pal..." |
| `[152]` | **""This was all my fault. I should have listened to her.""** | `[127]` **Estela Toras**: ""Your real problem is telling th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Estela Toras**: ""It's too late now. You can cons..." |

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
  - -> `[3]` (*Narrator: "I entered the palace's residential wing and began making ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I entered the palace's residential wing and began making my way to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As I neared Vina's door, I thought I heard her speaking t..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "As I neared Vina's door, I thought I heard her speaking to someone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I was about to step closer when I felt a hand on my shoul..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I was about to step closer when I felt a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Pabel Adria: ""Your Majesty! There you are.""*)

### Węzeł `[6]`
Mówca: **Pabel Adria**
> ""Your Majesty! There you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[7]`
Mówca: **Pabel Adria**
> ""I'm afraid there's an urgent matter regarding wedding seating arrangements. This way, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Titus shadowed us as Pabel steered me back down the hall ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Titus shadowed us as Pabel steered me back down the hall towards my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[13]` (*Player_Romus: ""I need to check in on Vina.""*)
  - -> `[17]` (*Player_Romus: ""This had better be quick.""*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Pabel Adria: ""I'm afraid there's an urgent matter regarding wedding se..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Pabel Adria: ""I'm afraid there's an urgent matter regarding the seatin..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seating arrangements? Is that a euphemism for something?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "He shook his head briskly and withdrew a seating diagram ..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need to check in on Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Pabel Adria: ""This will only be a moment.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""Seating arrangements? Is that a euphemism for something?""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This had better be quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Pabel Adria: ""It will be. Hopefully.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't you figure it out yourself?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Pabel Adria: ""I've been trying.""*)

### Węzeł `[19]`
Mówca: **Pabel Adria**
> ""I've been trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He withdrew a seating diagram from his breast pocket."*)

### Węzeł `[20]`
Mówca: **Pabel Adria**
> ""It will be. Hopefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He withdrew a seating diagram from his breast pocket."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "He shook his head briskly and withdrew a seating diagram from his breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Pabel Adria: ""At table 12, we have delegations from Agard, Qinal, the ..."*)

### Węzeł `[22]`
Mówca: **Pabel Adria**
> ""This will only be a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He withdrew a seating diagram from his breast pocket."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He withdrew a seating diagram from his breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Pabel Adria: ""At table 12, we have delegations from Agard, Qinal, the ..."*)

### Węzeł `[24]`
Mówca: **Pabel Adria**
> ""At table 12, we have delegations from Agard, Qinal, the Free Cities and Nahrburk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Pabel Adria: ""Our guests from Qinal and the Free Cities refuse to sit ..."*)

### Węzeł `[25]`
Mówca: **Pabel Adria**
> ""Our guests from Qinal and the Free Cities refuse to sit next to each other or directly across from one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Pabel Adria: ""The Qinali, meanwhile, would like to sit directly to the..."*)

### Węzeł `[26]`
Mówca: **Pabel Adria**
> ""The Qinali, meanwhile, would like to sit directly to the left of our guest from Nahrburk, who in turn has asked to sit across from the Agardian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""Easy. Going clockwise, it's Agard, Qinal, Nahrburk, Free..."*)
  - -> `[29]` (*Player_Romus: ""From the top of the table, it's Narhburk, Qinal, Agard, ..."*)
  - -> `[28]` (*Player_Romus: ""Right. How about Free Cities, Nahrburk, Agard, Qinal?""*)
  - -> `[30]` (*Player_Romus: ""I have no idea. Ask someone else.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Easy. Going clockwise, it's Agard, Qinal, Nahrburk, Free Cities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Pabel made a note."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. How about Free Cities, Nahrburk, Agard, Qinal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Pabel made a note."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From the top of the table, it's Narhburk, Qinal, Agard, Free Cities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrange..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea. Ask someone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Pabel Adria: ""I'm sorry, Your Majesty. I was afraid of causing an inte..."*)

### Węzeł `[31]`
Mówca: **Pabel Adria**
> ""Perfect. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Pabel made a note."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Pabel Adria: ""Perfect. Thank you.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_VinaEscapes_CorrectWeddingArrangement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Pabel made a note."*)

### Węzeł `[34]`
Mówca: **Pabel Adria**
> ""I'm sorry, Your Majesty. I was afraid of causing an international scandal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[35]`
Mówca: **Pabel Adria**
> ""This must be a very emotional time for you. I still remember Her Highness' birth celebrations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""That just means you're getting old, Pabel.""*)
  - -> `[44]` (*Player_Romus: ""There's nothing romantic about tomorrow. It's a politica..."*)
  - -> `[46]` (*Player_Romus: ""All sparrows have to leave the nest sometime.""*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[36]`
Mówca: **Pabel Adria**
> ""I'm afraid there's an urgent matter regarding the seating arrangements for tomorrow's diplomatic luncheon. This way please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Titus shadowed us as Pabel steered me back down the hall ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Pabel Adria: ""This must be a very emotional time for you. I still reme..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That just means you're getting old, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""I still have the congratulatory cigar you gave me. You m..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""Huh. You were there?""*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing romantic about tomorrow. It's a political event, nothing more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have the congratulatory cigar you gave me. You must have saved up for it for months.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Pabel Adria: ""Lespia's finest. The import taxes were horrendous.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All sparrows have to leave the nest sometime.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "I detected a slight nervous quiver in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Was this really such an urgent matter?""*)
  - -> `[56]` (*Player_Romus: ""I have to go.""*)
  - -> `[57]` (*Player_Romus: ""Pabel, where is Vina?""*)

### Węzeł `[48]`
Mówca: **Narrator**
> "From just down the hall, I heard the sound of barking. Bruno."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Was this really such an urgent matter?""*)
  - -> `[56]` (*Player_Romus: ""I have to go.""*)
  - -> `[57]` (*Player_Romus: ""Pabel, where is Vina?""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Huh. You were there?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Pabel Adria: ""I was serving just beneath the head butler at the time.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "From just down the hall, I heard the sound of barking. Br..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "I detected a slight nervous quiver in his voice."*)

### Węzeł `[53]`
Mówca: **Pabel Adria**
> ""Lespia's finest. The import taxes were horrendous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[54]`
Mówca: **Pabel Adria**
> ""I was serving just beneath the head butler at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this really such an urgent matter?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Pabel Adria: ""No, I suppose it wasn't. Forgive me for wasting your time.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Pabel Adria: ""Very well. I've gotten all your clothes ready for tomorr..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel, where is Vina?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Pabel Adria: ""She's been in her room this entire time.""*)

### Węzeł `[58]`
Mówca: **Pabel Adria**
> ""No, I suppose it wasn't. Forgive me for wasting your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Homosexuality_Banned == true && (Rizi..."*)

### Węzeł `[59]`
Mówca: **Pabel Adria**
> ""Very well. I've gotten all your clothes ready for tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Homosexuality_Banned == true && (Rizi..."*)

### Węzeł `[60]`
Mówca: **Pabel Adria**
> ""She's been in her room this entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Homosexuality_Banned == true && (Rizi..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "I rushed back down the hallway to Vina's room. Bruno was standing there, barking in front of a wide-open door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "I went inside and saw that the window was open as well. M..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I rushed back down the hallway to Vina's room. Bruno was ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "I rushed back down the hallway to Vina's room. Her door w..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "I rushed back down the hallway to Vina's room. Her door was wide open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "I went inside and saw that the window was open as well. M..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "I went inside and saw that the window was open as well. My mother was standing in front of it, her face pale as a sheet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""WHERE IS SHE?!""*)
  - -> `[69]` (*Player_Romus: ""Did you let her run away?""*)
  - -> `[68]` (*Player_Romus_Italic: "Look out the window."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""WHERE IS SHE?!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: ""I... I don't know.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "Look out the window."]** — Mówca: **Player_Romus_Italic**
> "I looked out the window at the palace gardens below. Nobody was there."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Estela Toras: ""I... I have no idea what happened.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you let her run away?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Estela Toras: ""No, of course not!""*)

### Węzeł `[70]`
Mówca: **Estela Toras**
> ""I... I don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[71]`
Mówca: **Estela Toras**
> ""No, of course not!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[72]`
Mówca: **Estela Toras**
> ""I... I have no idea what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[73]`
Mówca: **Estela Toras**
> ""I came here to give her some motherly advice ahead of her wedding. I opened the door, and she was gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""If she didn't want to get married, she could have just t..."*)
  - -> `[83]` (*Player_Romus: ""You're lying. I heard her talking to someone in there.""*)
  - -> `[84]` (*Player_Romus: ""TITUS! FIND HER!""*)
  - -> `[85]` (*Player_Romus: ""She can't have gone far. The palace grounds are under he..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Estela Toras: ""I came here to give her some motherly advice ahead of he..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Estela Toras: ""I knew she'd been feeling down lately, so I came to chec..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""Can't you figure it out yourself?""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""We're hosting a diplomatic luncheon?""*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're hosting a diplomatic luncheon?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Pabel Adria: ""Apparently, yes.""*)

### Węzeł `[81]`
Mówca: **Pabel Adria**
> ""Apparently, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He withdrew a seating diagram from his breast pocket."*)

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""I knew she'd been feeling down lately, so I came to check up on her. I opened the door, and she was gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""You're lying. I heard her talking to someone in there.""*)
  - -> `[84]` (*Player_Romus: ""TITUS! FIND HER!""*)
  - -> `[85]` (*Player_Romus: ""She can't have gone far. The palace grounds are under he..."*)
  - -> `[90]` (*Player_Romus: ""If she wasn't happy, she could have just told me.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lying. I heard her talking to someone in there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Estela Toras), `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Estela Toras: ""Interesting. Perhaps she was on the phone.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""TITUS! FIND HER!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Estela Toras), `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Titus Gordion: ""I'm already on it, Your Majesty.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She can't have gone far. The palace grounds are under heavy security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Estela Toras), `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Titus Gordion: ""I'm communicating with my fellow guards now, Your Majesty.""*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Titus spoke into his radio. I struggled to make out the words on the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Titus Gordion: ""I've received word that one of my men left his shift ear..."*)

### Węzeł `[87]`
Mówca: **Titus Gordion**
> ""I'm already on it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Titus spoke into his radio. I struggled to make out the w..."*)

### Węzeł `[88]`
Mówca: **Titus Gordion**
> ""I'm communicating with my fellow guards now, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Titus spoke into his radio. I struggled to make out the w..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she didn't want to get married, she could have just told me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Estela Toras: ""She did tell you, Romus.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she wasn't happy, she could have just told me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Estela Toras: ""She did tell you, Romus.""*)

### Węzeł `[91]`
Mówca: **Estela Toras**
> ""She did tell you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Titus spoke into his radio. I struggled to make out the w..."*)

### Węzeł `[92]`
Mówca: **Estela Toras**
> ""Interesting. Perhaps she was on the phone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Titus spoke into his radio. I struggled to make out the w..."*)

### Węzeł `[93]`
Mówca: **Estela Toras**
> ""She did tell you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Titus spoke into his radio. I struggled to make out the w..."*)

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""I've received word that one of my men left his shift early just now. He was complaining of indigestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Titus Gordion: ""I tried to reach him, but he's already turned his radio ..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Track him down. See that he gets what's coming to him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[98]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Titus Gordion: ""I'll try my best, Your Majesty.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have to find him, Titus. I want my daughter back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Titus Gordion: ""I'll try my best, Your Majesty.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So she had an accomplice. I thought you Golden Guards were incorruptible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Estela Toras: ""Everybody has a weakness, darling. Even Captain Gordion ..."*)

### Węzeł `[98]`
Mówca: **Titus Gordion**
> ""I tried to reach him, but he's already turned his radio off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[96]` (*Player_Romus: ""You have to find him, Titus. I want my daughter back.""*)
  - -> `[97]` (*Player_Romus: ""So she had an accomplice. I thought you Golden Guards we..."*)
  - -> `[102]` (*Player_Romus: ""It's that easy for someone to escape the palace?!""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""Track him down. See that he gets what's coming to him.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's that easy for someone to escape the palace?!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Titus Gordion: ""Your Majesty, Palas Rezna's security systems are designe..."*)

### Węzeł `[103]`
Mówca: **Estela Toras**
> ""Everybody has a weakness, darling. Even Captain Gordion here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Titus cleared his throat."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Titus cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Titus Gordion: ""Right now, the goal is getting Princess Vina back. We ca..."*)

### Węzeł `[105]`
Mówca: **Titus Gordion**
> ""I'll try my best, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""I'm going to talk to the guards at the gates. See if I c..."*)

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""Your Majesty, Palas Rezna's security systems are designed to keep intruders out. Not to keep princesses in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""I'm going to talk to the guards at the gates. See if I c..."*)

### Węzeł `[107]`
Mówca: **Titus Gordion**
> ""Right now, the goal is getting Princess Vina back. We can discuss the particulars later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""I'm going to talk to the guards at the gates. See if I c..."*)

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""I'm going to talk to the guards at the gates. See if I can find out more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSea..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "He dashed out, leaving me alone with my mother."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "He dashed out, leaving me alone with my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Pabel had a hand in this, didn't he? Where did he go?""*)
  - -> `[112]` (*Player_Romus: ""Seriously, Mother. Did you help her escape?""*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == true"*)
  - -> `[117]` (*Player_Romus: ""What the hell am I supposed to do now?""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel had a hand in this, didn't he? Where did he go?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "My mother shrugged."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seriously, Mother. Did you help her escape?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Estela Toras: ""How many times must I tell you? She was already gone whe..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""Tell me where she is, or I'll tell everyone you're a Das..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me where she is, or I'll tell everyone you're a Dastnurist.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Kontekst wejściowy (poprzednik):** `[110]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Estela Toras: ""Go on, then. I honestly don't know.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell am I supposed to do now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "My mother shrugged."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "My mother shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Estela Toras: ""Your butler knows every nook and cranny of this palace, ..."*)

### Węzeł `[119]`
Mówca: **Estela Toras**
> ""Your butler knows every nook and cranny of this palace, including the secret passageways. If he played any role in her escape, he's long gone by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""How many times must I tell you? She was already gone when I came in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[121]`
Mówca: **Estela Toras**
> ""Go on, then. I honestly don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Estela Toras: ""If she did drive off with that guard, they could have go..."*)

### Węzeł `[122]`
Mówca: **Estela Toras**
> ""You could track her down. But she'll only try to escape again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Estela Toras: ""Your real problem is telling the rest of the continent t..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Estela Toras: ""Your real problem is explaining to the international pre..."*)

### Węzeł `[127]`
Mówca: **Estela Toras**
> ""Your real problem is telling the rest of the continent that Rizia's big royal wedding is off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[137]` (*Player_Romus: ""This is just cold feet. She'll come back eventually.""*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)
  - -> `[152]` (*Player_Romus: ""This was all my fault. I should have listened to her.""*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[128]`
Mówca: **Estela Toras**
> ""Your real problem is explaining to the international press that the Kingdom of Rizia can't hold on to its princesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""They'll make me look like a monster.""*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[143]` (*Player_Romus: ""This is just a tantrum. I'm sure she'll come back eventu..."*)

### Węzeł `[129]`
Mówca: **Estela Toras**
> ""If she did drive off with that guard, they could have gone anywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[130]`
Mówca: **Narrator**
> "My mother shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Estela Toras: ""You could track her down. But she'll only try to escape ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shit. All that wartime sympathy, literally out the window.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Estela Toras: ""Not to mention our family's line of succession.""*)

### Węzeł `[132]`
Mówca: **Narrator**
> "There was pain in his eyes as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Pabel Adria: ""Good night, Romus. And good luck.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_Homosexuality_Banned == true && (RiziaDLC.Relations_Pabel_Together == true || RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Homosexuality_Banned == true && (Rizi..."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_Homosexuality_Banned == true && (Ri..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_Homosexuality_Banned == true && (RiziaDLC.Relations_Pabel_Together == true || RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_Homosexuality_Banned"] == true  and  (Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "There was pain in his eyes as he looked at me."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_Homosexuality_Banned == true && (RiziaDLC.Relations_Pabel_Together == true || RiziaDLC.Prologue_Relations_PabelFriend == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_Homosexuality_Banned"] == true  and  (Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[136]`
Mówca: **Pabel Adria**
> ""Good night, Romus. And good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is just cold feet. She'll come back eventually.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Estela Toras: ""If she doesn't, it'll be the end of our family's line of..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Titus does manage to track her down, I'll have her beheaded.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras), `[128]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Estela Toras: ""If you do, that'll be the end of your line of succession.""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus: ""If Titus does manage to track her down, I'll have her be..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll make me look like a monster.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Estela Toras: ""What's more, our family's line of succession will be mos..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is just a tantrum. I'm sure she'll come back eventually.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Estela Toras: ""If she doesn't, it'll be the end of our family's line of..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""Shit. All that wartime sympathy, literally out the window.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And Hugo. What do I tell Hugo?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Estela Toras: ""You tell him that he's your new successor.""*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""And Hugo. What do I tell Hugo?""*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""And Axel. What do I tell Axel?""*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And Axel. What do I tell Axel?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Estela Toras: ""You tell him that the Rizia-Pales reunion everyone's bee..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was all my fault. I should have listened to her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Estela Toras: ""It's too late now. You can consider this the end of our ..."*)

### Węzeł `[153]`
Mówca: **Estela Toras**
> ""If she doesn't, it'll be the end of our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[154]`
Mówca: **Estela Toras**
> ""You tell him that the Rizia-Pales reunion everyone's been waiting for will have to happen another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "She sighed."*)

### Węzeł `[155]`
Mówca: **Estela Toras**
> ""You tell him that he's your new successor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[156]`
Mówca: **Estela Toras**
> ""If she doesn't, it'll be the end of our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[157]`
Mówca: **Estela Toras**
> ""Not to mention our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[158]`
Mówca: **Estela Toras**
> ""But perhaps that's a small price to pay for Her Highness' happiness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "She slowly walked away, lost in thought."*)

### Węzeł `[159]`
Mówca: **Estela Toras**
> ""It's too late now. You can consider this the end of our family's line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[160]`
Mówca: **Estela Toras**
> ""If you do, that'll be the end of your line of succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Estela Toras: ""Unless...""*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "She sighed."*)

### Węzeł `[164]`
Mówca: **Estela Toras**
> ""Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "She slowly walked away, lost in thought."*)

### Węzeł `[165]`
Mówca: **Estela Toras**
> ""What's more, our family's line of succession will be most definitively over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Estela Toras: ""But perhaps that's a small price to pay for Her Highness..."*)

### Węzeł `[167]`
Mówca: **Estela Toras**
> ""But perhaps that's a small price to pay for Her Highness' happiness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "She slowly walked away, lost in thought."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Estela Toras: ""Unless...""*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "She sighed."*)

### Węzeł `[171]`
Mówca: **Estela Toras**
> ""Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "She slowly walked away, lost in thought."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Estela Toras: ""But perhaps that's a small price to pay for Her Highness..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "She slowly walked away, lost in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_PorteDrazon_GoldenGuardSearchesVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)
