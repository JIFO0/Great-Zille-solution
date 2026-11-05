# Rizia/Turn 2/Pabel Valero Poisoning Talk

- **ID konwersacji:** `301`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/301_Pabel_Valero_Poisoning_Talk.md`
- **Liczba węzłów dialogowych:** 198
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[300] Rizia/Turn 2/P_VinaAtMonqiz** (../Turn_02/300_P_VinaAtMonqiz.md), Węzeł `[523]`
- Węzeł `[45]` -> **[300] Rizia/Turn 2/P_VinaAtMonqiz** (../Turn_02/300_P_VinaAtMonqiz.md), Węzeł `[182]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""It was a heart attack. What else would I need to know?""** | `[4]` **Pabel Adria**: ""Your Majesty... How much have y..."<br>`[8]` **Pabel Adria**: ""Listen, Rom... How much have th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Pabel Adria**: ""That was the official explanati..." |
| `[10]` | **""I haven't cared enough to go digging around.""** | `[4]` **Pabel Adria**: ""Your Majesty... How much have y..."<br>`[8]` **Pabel Adria**: ""Listen, Rom... How much have th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Pabel Adria**: ""Funny you should mention digging."" |
| `[11]` | **""Not a lot. Do you suspect something?""** | `[4]` **Pabel Adria**: ""Your Majesty... How much have y..."<br>`[8]` **Pabel Adria**: ""Listen, Rom... How much have th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Pabel Adria**: ""Well, this is what I know..."" |
| `[19]` | **""I think I see where this is going.""** | `[18]` **Pabel Adria**: ""He told me you can make an extr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Pabel Adria**: ""I know it seems preposterous, b..." |
| `[20]` | **""Why didn't you ever tell me about this plant?""** | `[18]` **Pabel Adria**: ""He told me you can make an extr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Pabel Adria**: ""You were the royal heir. Why wo..."<br>`[33]` **Pabel Adria**: ""I only spoke to you when I was ..." |
| `[21]` | **""Mandragora? You've been reading too many fantasy novels.""** | `[18]` **Pabel Adria**: ""He told me you can make an extr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Pabel Adria**: ""The name sounds silly, I know. ..." |
| `[25]` | **""When was the last time you saw the plants?""** | `[24]` **Pabel Adria**: ""After he died, I went out to th..."<br>`[67]` **Pabel Adria**: ""So yes, it's possible their dis..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == false` | *Brak zmian stanu* | `[59]` **Pabel Adria**: ""A few months before that, maybe..." |
| `[26]` | **""Who was around the palace that night?""** | `[24]` **Pabel Adria**: ""After he died, I went out to th..."<br>`[67]` **Pabel Adria**: ""So yes, it's possible their dis..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == false` | *Brak zmian stanu* | `[63]` **Pabel Adria**: ""The Queen Mother, obviously. Gr..." |
| `[34]` | **""Thank you. You're dismissed.""** | `[36]` **Narrator**: "I noticed an identical towel on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "He took a step closer to the tub..." |
| `[35]` | **""Is there another reason you wanted to come in?""** | `[36]` **Narrator**: "I noticed an identical towel on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "He took a step closer to the tub..." |
| `[37]` | **""Two towels? Are you crazy, Pabel?""** | `[36]` **Narrator**: "I noticed an identical towel on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "He took a step closer to the tub..." |
| `[40]` | **""Why? Don't you trust the Golden Guard?""** | `[39]` **Pabel Adria**: ""Actually, there was something I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Pabel Adria**: ""I don't know whom I can trust, ..." |
| `[41]` | **""Sounds serious.""** | `[39]` **Pabel Adria**: ""Actually, there was something I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Pabel Adria**: ""It might be. Or it might not be..." |
| `[42]` | **""I'd really rather not have company in here, Pabel. Save the talk for another day.""** | `[39]` **Pabel Adria**: ""Actually, there was something I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Pabel Adria**: ""If... if you insist."" |
| `[49]` | **""Well? What did you want to tell me?""** | `[48]` **Narrator**: "There was a small stool next to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Pabel spoke the next words slowly." |
| `[50]` | **""No need for modesty.""** | `[48]` **Narrator**: "There was a small stool next to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Pabel Adria**: ""Oh. Pardon me."" |
| `[60]` | **""Could someone have slipped it in his supper?""** | `[24]` **Pabel Adria**: ""After he died, I went out to th..."<br>`[67]` **Pabel Adria**: ""So yes, it's possible their dis..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == false` | *Brak zmian stanu* | `[64]` **Narrator**: "Pabel grimaced." |
| `[61]` | **""I've heard enough. It sounds like his paranoia was rubbing off on you.""** | `[24]` **Pabel Adria**: ""After he died, I went out to th..."<br>`[67]` **Pabel Adria**: ""So yes, it's possible their dis..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true` | *Brak zmian stanu* | `[28]` **Pabel Adria**: ""You may be right."" |
| `[62]` | **""All right. Let's say Father was indeed poisoned. What would be the motivation?""** | `[24]` **Pabel Adria**: ""After he died, I went out to th..."<br>`[67]` **Pabel Adria**: ""So yes, it's possible their dis..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true` | *Brak zmian stanu* | `[91]` **Pabel Adria**: ""We both know His Majesty had a ..." |
| `[65]` | **"""** | `[197]` **Pabel Adria**: ""Lucita Azaro was also in town, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects...` | `[25]` **Player_Romus**: ""When was the last time you saw ..."<br>`[26]` **Player_Romus**: ""Who was around the palace that ..."<br>*(oraz 4 innych odgałęzień)* |
| `[69]` | **""If he was poisoned, the coroner would have caught it.""** | `[24]` **Pabel Adria**: ""After he died, I went out to th..."<br>`[67]` **Pabel Adria**: ""So yes, it's possible their dis..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == false` | *Brak zmian stanu* | `[70]` **Pabel Adria**: ""Mandragora is a naturally occur..." |
| `[93]` | **""So I have a secret friend in the palace.""** | `[92]` **Pabel Adria**: ""But the goal could simply have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Pabel Adria**: ""No matter what, I would urge yo..." |
| `[94]` | **""Or I'm next.""** | `[92]` **Pabel Adria**: ""But the goal could simply have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Pabel Adria**: ""No matter what, I would urge yo..." |
| `[95]` | **""Nobody wanted me to be King that badly.""** | `[92]` **Pabel Adria**: ""But the goal could simply have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Pabel Adria**: ""No matter what, I would urge yo..." |
| `[98]` | **""I see. I'm going to have to look into this further." [Potential Investigation]"** | `[29]` **Pabel Adria**: ""And all of those people are sti..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedP...` | `[143]` **Narrator**: "Pabel nodded." |
| `[99]` | **""Even if you're right, this isn't worth pursuing. Nobody's going to murder me.""** | `[29]` **Pabel Adria**: ""And all of those people are sti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "I heard Pabel sigh quietly." |
| `[100]` | **""I'm not seeing it, Pabel. It's too fantastical.""** | `[29]` **Pabel Adria**: ""And all of those people are sti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Pabel Adria**: ""It's indeed a stretch, Your Maj..."<br>`[113]` **Pabel Adria**: ""You're right, Romus. Forget I e..." |
| `[101]` | **""Wait. What if *you* did it and you're trying to throw me off your trail?""** | `[29]` **Pabel Adria**: ""And all of those people are sti..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[107]` **Narrator**: "Pabel drew his breath in through..." |
| `[115]` | **"'I *know* I'm right. Who would possibly want to kill me?""** | `[108]` **Pabel Adria**: ""I hope you're right."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Pabel Adria**: ""You're the king, Romus. You can..."<br>`[194]` **Pabel Adria**: ""I beg your pardon, Your Majesty..." |
| `[135]` | **""Bi mare volu...""** | `[129]` **Pabel Adria**: ""Trust me, old friend. I'll alwa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Pabel Adria**: ""...un oxit solu."" |
| `[136]` | **""Speaking of backs, can you give mine a scrub while you're here?""** | `[125]` **Pabel Adria**: ""We may not be the close confida..."<br>`[129]` **Pabel Adria**: ""Trust me, old friend. I'll alwa..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Pabel Adria**: ""With pleasure, my king.""<br>`[167]` **Pabel Adria**: ""Right away, Your Majesty."" |
| `[137]` | **""I was your superior. As I am now. Don't try to rise above your station.""** | `[133]` **Pabel Adria**: ""Yes, you tormented me in childh..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[153]` **Narrator**: "A pained expression flashed acro..." |
| `[138]` | **""If you've said all you have to say, you're dismissed.""** | `[125]` **Pabel Adria**: ""We may not be the close confida..."<br>`[129]` **Pabel Adria**: ""Trust me, old friend. I'll alwa..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Pabel Adria**: ""I...""<br>`[173]` **Pabel Adria**: ""That's everything, Your Majesty..." |
| `[139]` | **""Thank you for bringing it up with me regardless, though.""** | `[108]` **Pabel Adria**: ""I hope you're right.""<br>`[112]` **Pabel Adria**: ""It's indeed a stretch, Your Maj..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Pabel Adria**: ""Of course. I would never hide a..."<br>`[106]` **Pabel Adria**: ""Of course, Your Majesty. Your w..." |
| `[140]` | **""I will. Gladly.""** | `[112]` **Pabel Adria**: ""It's indeed a stretch, Your Maj..."<br>`[113]` **Pabel Adria**: ""You're right, Romus. Forget I e..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[142]` **Pabel Adria**: ""I was only looking out for your..." |
| `[144]` | **""Thanks for bringing it to my attention.""** | `[143]` **Narrator**: "Pabel nodded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Pabel Adria**: ""Of course. I would never hide a..."<br>`[106]` **Pabel Adria**: ""Of course, Your Majesty. Your w..." |
| `[145]` | **""What do you think I should do next?""** | `[143]` **Narrator**: "Pabel nodded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Pabel Adria**: ""I wish I knew. Try to find out ..." |
| `[149]` | **""I'm sorry about that. I didn't know any better.""** | `[133]` **Pabel Adria**: ""Yes, you tormented me in childh..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[156]` **Pabel Adria**: ""Past is past, Your Majesty."" |
| `[150]` | **""Remember I'm still your superior. Don't try to rise above your station.""** | `[125]` **Pabel Adria**: ""We may not be the close confida..."<br>`[129]` **Pabel Adria**: ""Trust me, old friend. I'll alwa..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[153]` **Narrator**: "A pained expression flashed acro..." |
| `[171]` | **""Pabel?""** | `[170]` **Pabel Adria**: ""I'll take my leave before your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Pabel Adria**: ""Romus?""<br>`[183]` **Pabel Adria**: ""Your Majesty?"" |
| `[175]` | **""Butler!""** | `[170]` **Pabel Adria**: ""I'll take my leave before your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "He laughed." |
| `[176]` | **""See you later.""** | `[170]` **Pabel Adria**: ""I'll take my leave before your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "He quietly exited the room, leav..." |
| `[184]` | **""Stay and chat? Baths are boring alone.""** | `[178]` **Pabel Adria**: ""What is it, Mr. Manger?""<br>`[182]` **Pabel Adria**: ""Romus?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Pabel Adria**: ""As my king commands."" |
| `[186]` | **""I'm happy there's one member of my inner circle I can trust.""** | `[178]` **Pabel Adria**: ""What is it, Mr. Manger?""<br>`[182]` **Pabel Adria**: ""Romus?""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "He bowed his head in gratitude a..." |

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
  - -> `[3]` (*Narrator: "The door slowly opened and Pabel entered, a fluffy towel ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The door slowly opened and Pabel entered, a fluffy towel in his arms. He hung it on a hook on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I noticed an identical towel on the hook next to it."*)

### Węzeł `[4]`
Mówca: **Pabel Adria**
> ""Your Majesty... How much have you been told about your father's death?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""It was a heart attack. What else would I need to know?""*)
  - -> `[10]` (*Player_Romus: ""I haven't cared enough to go digging around.""*)
  - -> `[11]` (*Player_Romus: ""Not a lot. Do you suspect something?""*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Pabel Adria: ""Your Majesty... How much have you been told about your f..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Pabel Adria: ""Listen, Rom... How much have they told you about your fa..."*)

### Węzeł `[8]`
Mówca: **Pabel Adria**
> ""Listen, Rom... How much have they told you about your father's death?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""It was a heart attack. What else would I need to know?""*)
  - -> `[10]` (*Player_Romus: ""I haven't cared enough to go digging around.""*)
  - -> `[11]` (*Player_Romus: ""Not a lot. Do you suspect something?""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a heart attack. What else would I need to know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Pabel Adria), `[8]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Pabel Adria: ""That was the official explanation, yes.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't cared enough to go digging around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Pabel Adria), `[8]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Pabel Adria: ""Funny you should mention digging.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not a lot. Do you suspect something?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Pabel Adria), `[8]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Pabel Adria: ""Well, this is what I know...""*)

### Węzeł `[12]`
Mówca: **Pabel Adria**
> ""Well, this is what I know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[13]`
Mówca: **Pabel Adria**
> ""Funny you should mention digging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[14]`
Mówca: **Pabel Adria**
> ""That was the official explanation, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[15]`
Mówca: **Pabel Adria**
> ""Back when my dad was still alive, he showed me every single plant in the Palas Rezna gardens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Pabel Adria: ""One of them was mandragora. Big green leaves, pretty pur..."*)

### Węzeł `[16]`
Mówca: **Pabel Adria**
> ""You remember my father, the groundskeeper. When I was younger, he showed me every single plant in the gardens of Palas Rezna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Pabel Adria: ""One of them was mandragora. Big green leaves, pretty pur..."*)

### Węzeł `[17]`
Mówca: **Pabel Adria**
> ""One of them was mandragora. Big green leaves, pretty purple flowers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Pabel Adria: ""He told me you can make an extract from its roots. A lit..."*)

### Węzeł `[18]`
Mówca: **Pabel Adria**
> ""He told me you can make an extract from its roots. A little bit helps you sleep. More than that causes delirium. And a lot stops your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""I think I see where this is going.""*)
  - -> `[21]` (*Player_Romus: ""Mandragora? You've been reading too many fantasy novels.""*)
  - -> `[20]` (*Player_Romus: ""Why didn't you ever tell me about this plant?""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I see where this is going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Pabel Adria: ""I know it seems preposterous, but....""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you ever tell me about this plant?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mandragora? You've been reading too many fantasy novels.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Pabel Adria: ""The name sounds silly, I know. That's why it stuck in my..."*)

### Węzeł `[22]`
Mówca: **Pabel Adria**
> ""You were the royal heir. Why would you need to know about gardening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Pabel Adria: ""When I attended to your father on his sickbed, he didn't..."*)

### Węzeł `[23]`
Mówca: **Pabel Adria**
> ""The name sounds silly, I know. That's why it stuck in my head all these years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Pabel Adria: ""When I attended to your father on his sickbed, he didn't..."*)

### Węzeł `[24]`
Mówca: **Pabel Adria**
> ""After he died, I went out to the part of the garden where my father had planted the mandragora. Nothing but a smooth patch of dirt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "Valero Poison Qs"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When was the last time you saw the plants?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Pabel Adria), `[67]` (Pabel Adria), `[65]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Pabel Adria: ""A few months before that, maybe. I remembered the flower..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was around the palace that night?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Pabel Adria), `[67]` (Pabel Adria), `[65]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Pabel Adria: ""The Queen Mother, obviously. Grand Wiseman Ignacius. Tit..."*)

### Węzeł `[27]`
Mówca: **Pabel Adria**
> ""There were only a few people King Valero trusted by the end. If my suspicions are correct, it means one of them took advantage of that trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Pabel Adria: ""And all of those people are still in your inner circle t..."*)

### Węzeł `[28]`
Mówca: **Pabel Adria**
> ""You may be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Pabel Adria: ""But please, look out for yourself nonetheless.""*)

### Węzeł `[29]`
Mówca: **Pabel Adria**
> ""And all of those people are still in your inner circle today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""I see. I'm going to have to look into this further." [Po..."*)
  - -> `[99]` (*Player_Romus: ""Even if you're right, this isn't worth pursuing. Nobody'..."*)
  - -> `[100]` (*Player_Romus: ""I'm not seeing it, Pabel. It's too fantastical.""*)
  - -> `[101]` (*Player_Romus: ""Wait. What if *you* did it and you're trying to throw me..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Pabel Adria: ""You were the royal heir. Why would you need to know abou..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Pabel Adria: ""I only spoke to you when I was spoken to, Your Majesty.""*)

### Węzeł `[33]`
Mówca: **Pabel Adria**
> ""I only spoke to you when I was spoken to, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Pabel Adria: ""When I attended to your father on his sickbed, he didn't..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. You're dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He took a step closer to the tub, conscientiously keeping..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there another reason you wanted to come in?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He took a step closer to the tub, conscientiously keeping..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "I noticed an identical towel on the hook next to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Thank you. You're dismissed.""*)
  - -> `[35]` (*Player_Romus: ""Is there another reason you wanted to come in?""*)
  - -> `[37]` (*Player_Romus: ""Two towels? Are you crazy, Pabel?""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Two towels? Are you crazy, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "He took a step closer to the tub, conscientiously keeping..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "He took a step closer to the tub, conscientiously keeping his eyes on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Pabel Adria: ""Actually, there was something I wanted to bring up. With..."*)

### Węzeł `[39]`
Mówca: **Pabel Adria**
> ""Actually, there was something I wanted to bring up. Without any guards around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""Why? Don't you trust the Golden Guard?""*)
  - -> `[41]` (*Player_Romus: ""Sounds serious.""*)
  - -> `[42]` (*Player_Romus: ""I'd really rather not have company in here, Pabel. Save ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Don't you trust the Golden Guard?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Pabel Adria: ""I don't know whom I can trust, to be honest.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds serious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Pabel Adria: ""It might be. Or it might not be. I'm not sure.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd really rather not have company in here, Pabel. Save the talk for another day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Pabel Adria: ""If... if you insist.""*)

### Węzeł `[43]`
Mówca: **Pabel Adria**
> ""If... if you insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He backed out the door, bowing slightly as he did so."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He backed out the door, bowing slightly as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaDLC.Relations_Pabel -= 1]"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RiziaDLC.Relations_Pabel -= 1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Pabel Adria: ""Romus?""*)

### Węzeł `[46]`
Mówca: **Pabel Adria**
> ""I don't know whom I can trust, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "There was a small stool next to the tub. He moved over to..."*)

### Węzeł `[47]`
Mówca: **Pabel Adria**
> ""It might be. Or it might not be. I'm not sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "There was a small stool next to the tub. He moved over to..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "There was a small stool next to the tub. He moved over to it and sat with his back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""Well? What did you want to tell me?""*)
  - -> `[50]` (*Player_Romus: ""No need for modesty.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? What did you want to tell me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Pabel spoke the next words slowly."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need for modesty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Pabel Adria: ""Oh. Pardon me.""*)

### Węzeł `[51]`
Mówca: **Pabel Adria**
> ""Oh. Pardon me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Pabel turned around, still taking care to look only at my..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Pabel turned around, still taking care to look only at my face. He spoke the next words slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Pabel spoke the next words slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Pabel Adria: ""Back when my dad was still alive, he showed me every sin..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Pabel Adria: ""You remember my father, the groundskeeper. When I was yo..."*)

### Węzeł `[57]`
Mówca: **Pabel Adria**
> ""I know it seems preposterous, but....""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Pabel Adria: ""When I attended to your father on his sickbed, he didn't..."*)

### Węzeł `[58]`
Mówca: **Pabel Adria**
> ""When I attended to your father on his sickbed, he didn't seem like a man suffering from heart failure. He was in a complete daze, as if he didn't even recognize me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Pabel Adria: ""After he died, I went out to the part of the garden wher..."*)

### Węzeł `[59]`
Mówca: **Pabel Adria**
> ""A few months before that, maybe. I remembered the flowers blooming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Pabel Adria: ""So yes, it's possible their disappearance had nothing to..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could someone have slipped it in his supper?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Pabel Adria), `[67]` (Pabel Adria), `[65]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Pabel grimaced."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. It sounds like his paranoia was rubbing off on you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true`
- **Kontekst wejściowy (poprzednik):** `[24]` (Pabel Adria), `[67]` (Pabel Adria), `[65]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Pabel Adria: ""You may be right.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Let's say Father was indeed poisoned. What would be the motivation?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true`
- **Kontekst wejściowy (poprzednik):** `[24]` (Pabel Adria), `[67]` (Pabel Adria), `[65]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Pabel Adria: ""We both know His Majesty had a long list of enemies.""*)

### Węzeł `[63]`
Mówca: **Pabel Adria**
> ""The Queen Mother, obviously. Grand Wiseman Ignacius. Titus and his men...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Pabel Adria: ""Lucita Azaro was also in town, meeting with your uncle t..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Pabel grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Pabel Adria: ""I was tasting all of His Majesty's food at that time. So..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: """]** — Mówca: **Pabel Adria**
> ""So quite the list. Not including me, of course."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects = true"*)

### Węzeł `[66]`
Mówca: **Pabel Adria**
> ""I was tasting all of His Majesty's food at that time. So whoever it was would have had to be very creative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper = true"*)

### Węzeł `[67]`
Mówca: **Pabel Adria**
> ""So yes, it's possible their disappearance had nothing to do with the King's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants = true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Valero Poison Qs`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true ||..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he was poisoned, the coroner would have caught it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Pabel Adria), `[67]` (Pabel Adria), `[65]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Pabel Adria: ""Mandragora is a naturally occurring substance. It may no..."*)

### Węzeł `[70]`
Mówca: **Pabel Adria**
> ""Mandragora is a naturally occurring substance. It may not have raised a flag.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner = true"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""When was the last time you saw the plants?""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Who was around the palace that night?""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Could someone have slipped it in his supper?""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""If he was poisoned, the coroner would have caught it.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "Jump to: [Valero Poison Qs]"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "Jump to: [Valero Poison Qs]"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "Jump to: [Valero Poison Qs]"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "Jump to: [Valero Poison Qs]"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Valero Poison Qs]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "Valero Poison Qs"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true ||..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true ..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I've heard enough. It sounds like his paranoia was rubbi..."*)
  - -> `[62]` (*Player_Romus: ""All right. Let's say Father was indeed poisoned. What wo..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
Mówca: **Pabel Adria**
> ""We both know His Majesty had a long list of enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Pabel Adria: ""But the goal could simply have been to put you on the th..."*)

### Węzeł `[92]`
Mówca: **Pabel Adria**
> ""But the goal could simply have been to put you on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""So I have a secret friend in the palace.""*)
  - -> `[94]` (*Player_Romus: ""Or I'm next.""*)
  - -> `[95]` (*Player_Romus: ""Nobody wanted me to be King that badly.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So I have a secret friend in the palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Pabel Adria: ""No matter what, I would urge you to look out for yourself.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or I'm next.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Pabel Adria: ""No matter what, I would urge you to look out for yourself.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody wanted me to be King that badly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Pabel Adria: ""No matter what, I would urge you to look out for yourself.""*)

### Węzeł `[96]`
Mówca: **Pabel Adria**
> ""But please, look out for yourself nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Pabel Adria: ""There were only a few people King Valero trusted by the ..."*)

### Węzeł `[97]`
Mówca: **Pabel Adria**
> ""No matter what, I would urge you to look out for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Pabel Adria: ""There were only a few people King Valero trusted by the ..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""I see. I'm going to have to look into this further." [Potential Investigation]"]** — Mówca: **Player_Romus**
> ""I see. I'm going to have to look into this further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel = true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if you're right, this isn't worth pursuing. Nobody's going to murder me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "I heard Pabel sigh quietly."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not seeing it, Pabel. It's too fantastical.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. What if *you* did it and you're trying to throw me off your trail?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[102]`
Mówca: **Pabel Adria**
> ""Of course. I would never hide anything from you. You and I go too far back for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Pabel Adria: ""Of course. I would never hide anything from you. You and..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Pabel Adria: ""Of course, Your Majesty. Your well-being is of the utmos..."*)

### Węzeł `[106]`
Mówca: **Pabel Adria**
> ""Of course, Your Majesty. Your well-being is of the utmost importance to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Pabel drew his breath in through his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[108]`
Mówca: **Pabel Adria**
> ""I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Romus: "'I *know* I'm right. Who would possibly want to kill me?""*)
  - -> `[139]` (*Player_Romus: ""Thank you for bringing it up with me regardless, though.""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Pabel Adria: ""It's indeed a stretch, Your Majesty. Please forget I bro..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Pabel Adria: ""You're right, Romus. Forget I even brought it up.""*)

### Węzeł `[112]`
Mówca: **Pabel Adria**
> ""It's indeed a stretch, Your Majesty. Please forget I broached the subject, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Thank you for bringing it up with me regardless, though.""*)
  - -> `[140]` (*Player_Romus: ""I will. Gladly.""*)

### Węzeł `[113]`
Mówca: **Pabel Adria**
> ""You're right, Romus. Forget I even brought it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Thank you for bringing it up with me regardless, though.""*)
  - -> `[140]` (*Player_Romus: ""I will. Gladly.""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Pabel nodded."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "'I *know* I'm right. Who would possibly want to kill me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == false"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "I heard Pabel sigh quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Pabel Adria: ""I hope you're right.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Pabel Adria: ""I can assure you of my innocence, Your Majesty.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Pabel Adria: ""Why would I even be telling you all this, then?""*)

### Węzeł `[120]`
Mówca: **Pabel Adria**
> ""I can assure you of my innocence, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[121]`
Mówca: **Pabel Adria**
> ""Why would I even be telling you all this, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel < 0"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss == true"*)

### Węzeł `[125]`
Mówca: **Pabel Adria**
> ""We may not be the close confidantes we once were, but I'll always have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Speaking of backs, can you give mine a scrub while you'r..."*)
  - -> `[150]` (*Player_Romus: ""Remember I'm still your superior. Don't try to rise abov..."*)
  - -> `[138]` (*Player_Romus: ""If you've said all you have to say, you're dismissed.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel < 0"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel < 0)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Pabel Adria: ""We may not be the close confidantes we once were, but I'..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Pabel Adria: ""Trust me, old friend. I'll always have your back.""*)

### Węzeł `[129]`
Mówca: **Pabel Adria**
> ""Trust me, old friend. I'll always have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Speaking of backs, can you give mine a scrub while you'r..."*)
  - -> `[135]` (*Player_Romus: ""Bi mare volu...""*)
  - -> `[150]` (*Player_Romus: ""Remember I'm still your superior. Don't try to rise abov..."*)
  - -> `[138]` (*Player_Romus: ""If you've said all you have to say, you're dismissed.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelBoss == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Pabel Adria: ""Yes, you tormented me in childhood. But as the royal but..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelBoss == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Pabel Adria: ""I am the royal butler. It's my job to have your back.""*)

### Węzeł `[133]`
Mówca: **Pabel Adria**
> ""Yes, you tormented me in childhood. But as the royal butler, it's my job to have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Speaking of backs, can you give mine a scrub while you'r..."*)
  - -> `[137]` (*Player_Romus: ""I was your superior. As I am now. Don't try to rise abov..."*)
  - -> `[149]` (*Player_Romus: ""I'm sorry about that. I didn't know any better.""*)
  - -> `[138]` (*Player_Romus: ""If you've said all you have to say, you're dismissed.""*)

### Węzeł `[134]`
Mówca: **Pabel Adria**
> ""I am the royal butler. It's my job to have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Speaking of backs, can you give mine a scrub while you'r..."*)
  - -> `[150]` (*Player_Romus: ""Remember I'm still your superior. Don't try to rise abov..."*)
  - -> `[138]` (*Player_Romus: ""If you've said all you have to say, you're dismissed.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Pabel Adria: ""...un oxit solu.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Speaking of backs, can you give mine a scrub while you're here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Pabel Adria), `[129]` (Pabel Adria), `[133]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was your superior. As I am now. Don't try to rise above your station.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you've said all you have to say, you're dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Pabel Adria), `[129]` (Pabel Adria), `[133]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for bringing it up with me regardless, though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Pabel Adria), `[112]` (Pabel Adria), `[113]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. Gladly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Pabel Adria), `[113]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Pabel Adria: ""I was only looking out for your own well-being.""*)

### Węzeł `[142]`
Mówca: **Pabel Adria**
> ""I was only looking out for your own well-being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Pabel nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: ""Thanks for bringing it to my attention.""*)
  - -> `[145]` (*Player_Romus: ""What do you think I should do next?""*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for bringing it to my attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think I should do next?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Pabel Adria: ""I wish I knew. Try to find out as much as you can withou..."*)

### Węzeł `[146]`
Mówca: **Pabel Adria**
> ""I wish I knew. Try to find out as much as you can without raising suspicion, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Pabel Adria: ""I'll keep an ear out myself. Palace gossip gets around.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Pabel drew his breath in through his teeth."*)

### Węzeł `[148]`
Mówca: **Pabel Adria**
> ""I'll keep an ear out myself. Palace gossip gets around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about that. I didn't know any better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 1"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember I'm still your superior. Don't try to rise above your station.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Pabel Adria), `[129]` (Pabel Adria), `[134]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Pabel Adria: ""Past is past, Your Majesty.""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "A pained expression flashed across his face."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "A pained expression flashed across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Pabel Adria: ""I would never presume to do that, Your Majesty.""*)

### Węzeł `[154]`
Mówca: **Pabel Adria**
> ""I would never presume to do that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Pabel Adria: ""I'll take my leave now. I hope the water is still warm.""*)

### Węzeł `[155]`
Mówca: **Pabel Adria**
> ""I'll take my leave now. I hope the water is still warm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "He quietly exited the room, leaving me to finish my bath."*)

### Węzeł `[156]`
Mówca: **Pabel Adria**
> ""Past is past, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Pabel Adria: ""I'll take my leave now. I hope the water is still warm.""*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true && Rizi..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Pabel Adria: ""I...""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Pabel Adria: ""That's everything, Your Majesty. I hope your bathwater i..."*)

### Węzeł `[160]`
Mówca: **Pabel Adria**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "He paused for a moment."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Pabel Adria: ""No, that's everything. I'll take my leave before the bat..."*)

### Węzeł `[162]`
Mówca: **Pabel Adria**
> ""No, that's everything. I'll take my leave before the bathwater gets cold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "He quietly exited the room, leaving me to finish my bath."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true && Rizi..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Pabel Adria: ""With pleasure, my king.""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Pabel Adria: ""Right away, Your Majesty.""*)

### Węzeł `[166]`
Mówca: **Pabel Adria**
> ""With pleasure, my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "He took a warm, soapy washcloth and carefully ran it over..."*)

### Węzeł `[167]`
Mówca: **Pabel Adria**
> ""Right away, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He took a warm, soapy washcloth and scrubbed my back in a..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "He took a warm, soapy washcloth and carefully ran it over my back and shoulders. I felt the day's tension leaving my body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He took a warm, soapy washcloth and scrubbed my back in a businesslike manner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[170]`
Mówca: **Pabel Adria**
> ""I'll take my leave before your water gets too cold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""Pabel?""*)
  - -> `[175]` (*Player_Romus: ""Butler!""*)
  - -> `[176]` (*Player_Romus: ""See you later.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "He quietly exited the room, leaving me to finish my bath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[173]`
Mówca: **Pabel Adria**
> ""That's everything, Your Majesty. I hope your bathwater is still warm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "He quietly exited the room, leaving me to finish my bath."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "He finished the phrase with a gentle smile, then rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Pabel Adria: ""I'll take my leave before your water gets too cold.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Butler!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "He laughed."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "He quietly exited the room, leaving me to finish my bath."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Pabel Adria: ""What is it, Mr. Manger?""*)

### Węzeł `[178]`
Mówca: **Pabel Adria**
> ""What is it, Mr. Manger?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""Stay and chat? Baths are boring alone.""*)
  - -> `[186]` (*Player_Romus: ""I'm happy there's one member of my inner circle I can tr..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Pabel Adria: ""Romus?""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Pabel Adria: ""Your Majesty?""*)

### Węzeł `[182]`
Mówca: **Pabel Adria**
> ""Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""Stay and chat? Baths are boring alone.""*)
  - -> `[186]` (*Player_Romus: ""I'm happy there's one member of my inner circle I can tr..."*)

### Węzeł `[183]`
Mówca: **Pabel Adria**
> ""Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""Stay and chat? Baths are boring alone.""*)
  - -> `[186]` (*Player_Romus: ""I'm happy there's one member of my inner circle I can tr..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay and chat? Baths are boring alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[182]` (Pabel Adria), `[183]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Pabel Adria: ""As my king commands.""*)

### Węzeł `[185]`
Mówca: **Pabel Adria**
> ""...un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He finished the phrase with a gentle smile, then rose fro..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy there's one member of my inner circle I can trust.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[182]` (Pabel Adria), `[183]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "He bowed his head in gratitude and quietly exited, leavin..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "He bowed his head in gratitude and quietly exited, leaving me to finish my bath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[188]`
Mówca: **Pabel Adria**
> ""As my king commands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "He sat down. We kept talking as I finished my bath."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "He sat down. We kept talking as I finished my bath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == false"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == false)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Pabel Adria: ""You're the king, Romus. You can't lift a finger without ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Pabel Adria: ""I beg your pardon, Your Majesty, but you're the king. En..."*)

### Węzeł `[193]`
Mówca: **Pabel Adria**
> ""You're the king, Romus. You can't lift a finger without making an enemy of someone somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[194]`
Mówca: **Pabel Adria**
> ""I beg your pardon, Your Majesty, but you're the king. Enemies come with the territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[197]`
Mówca: **Pabel Adria**
> ""Lucita Azaro was also in town, meeting with your uncle to discuss the interim security councilor position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Pabel Adria: """*)
